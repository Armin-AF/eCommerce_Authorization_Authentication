using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace strore.server.Models;

public class User: IdentityUser<string>
{
    public string Role { get; set; }
    public string? StoreId { get; set; }
}