namespace DeskUniverse_Backend.Models;

public class Campaign
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Name { get; set; }
    public string? SessionDate { get; set; }
    public string? SessionHour { get; set; }
}