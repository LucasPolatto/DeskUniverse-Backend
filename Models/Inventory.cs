namespace DeskUniverse_Backend.Models;

public class Inventory
{
    public int Id { get; set; }
    public int characterId { get; set; }
    public string Name { get; set; }
    public int Size { get; set; }
    public int Type { get; set; }
    public string? Description { get; set; }
}