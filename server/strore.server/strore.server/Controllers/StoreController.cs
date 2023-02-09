using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using strore.server.DataBase;
using strore.server.Models;

namespace strore.server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StoreController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public StoreController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/Store
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Store>>> GetStores()
    {
        return await _context.Stores.ToListAsync();
    }

    // GET: api/Store/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Store>> GetStore(string id)
    {
        var store = await _context.Stores.FindAsync(id);

        if (store == null)
        {
            return NotFound();
        }

        return store;
    }

    // POST: api/Store
    [HttpPost]
    public async Task<ActionResult<Store>> PostStore(Store store)
    {
        _context.Stores.Add(store);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetStore", new { id = store.Id }, store);
    }

    // PUT: api/Store/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutStore(string id, Store store)
    {
        if (id != store.Id)
        {
            return BadRequest();
        }

        _context.Entry(store).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!StoreExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // DELETE: api/Store/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<Store>> DeleteStore(string id)
    {
        var store = await _context.Stores.FindAsync(id);
        if (store == null)
        {
            return NotFound();
        }

        _context.Stores.Remove(store);
        await _context.SaveChangesAsync();

        return store;
    }

    private bool StoreExists(string id)
    {
        return _context.Stores.Any(e => e.Id == id);
    }
}
