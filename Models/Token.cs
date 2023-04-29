namespace DeskUniverse_Backend.Models;

public class Token
{
    public int Id { get; set; }
    public int CampaignId { get; set; }
    public string? ImageURL { get; set; }
    public int? Health { get; set; }
    public int? Mana { get; set; }
}