namespace strore.server.Models;

public class User
{
    public string Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
    public string StoreId { get; set; }
}