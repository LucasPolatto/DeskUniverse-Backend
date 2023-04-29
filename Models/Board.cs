namespace DeskUniverse_Backend.Models;

public class Board
{
    public int Id { get; set; }
    public int CampaignId { get; set; }
    public string Name { get; set; }
    public int? BackgroundURL { get; set; }
}