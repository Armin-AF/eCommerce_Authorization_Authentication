using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using strore.server.Models;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;

namespace strore.server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController: ControllerBase
{
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;
    private readonly IConfiguration _config;

    public UserController(UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration config)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _config = config;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterViewModel model)
    {
        const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        var random = new Random();
        var userName = new string(
            Enumerable.Repeat(validChars, 8)
                .Select(s => s[random.Next(s.Length)])
                .ToArray()
        );
        
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var user = new User()
        {
            Id = Guid.NewGuid().ToString(),
            Email = model.Email,
            UserName = "user" + Guid.NewGuid().ToString("N"), // Generate a unique username
            Role = model.Role,
        };

        var result = await _userManager.CreateAsync(user, model.Password);

        if (!result.Succeeded)
        {
            return BadRequest(result.Errors);
        }

        await _signInManager.SignInAsync(user, false); 

        return Ok();
    }

    [HttpPost("login")]
    [AllowAnonymous]
    public async Task<IActionResult> Login([FromBody] LoginViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);

        if (!result.Succeeded)
        {
            return BadRequest("Email or password is incorrect");
        }

        var user = await _userManager.FindByEmailAsync(model.Email);

        return Ok(new
        {
            token = GenerateJwtToken(user),
            user = new
            {
                email = user.Email,
                role = user.Role,
                storeId = user.StoreId
            }
        });
    }
    
    [HttpGet]
    [Authorize]
    public async Task<IActionResult> Get()
    {
        var user = await _userManager.GetUserAsync(User);

        return Ok(new
        {
            email = user.Email,
            role = user.Role,
            storeId = user.StoreId
        });
    }

    private string GenerateJwtToken(User user)
    {
        var claims = new List<Claim>
        {
            new Claim(JwtRegisteredClaimNames.Sub, user.Email),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(ClaimTypes.NameIdentifier, user.Id)
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var expires = DateTime.Now.AddDays(Convert.ToDouble(_config["Jwt:ExpireDays"]));

        var token = new JwtSecurityToken(
            _config["Jwt:Issuer"],
            _config["Jwt:Issuer"],
            claims,
            expires: expires,
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}

