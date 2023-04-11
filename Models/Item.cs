namespace DeskUniverse_Backend.Models;

public class Item
{
    public int Id { get; set; }
    public int characterId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
}