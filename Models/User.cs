namespace DeskUniverse_Backend.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public bool Master { get; set; } = false;
}