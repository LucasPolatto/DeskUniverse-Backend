namespace DeskUniverse_Backend.Models;

public class Image
{
    public int Id { get; set; }
    public string ImageURL { get; set; }
    public int? UserId { get; set; }
    public int? CampaignId { get; set; }
    public int? CharacterId { get; set; }
    public int? ItemId { get; set; }
    public int? SkillId { get; set; }
}