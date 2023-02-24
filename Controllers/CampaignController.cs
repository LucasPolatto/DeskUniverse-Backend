using Microsoft.AspNetCore.Mvc;
using DeskUniverse_Backend.Models;

namespace DeskUniverse_Backend.Controllers;

[ApiController]
[Route("campaign")]
public class CampaignController : ControllerBase
{
    private DeskUniDB db;

    public CampaignController(DeskUniDB db)
    {
        this.db = db;
    }

    [HttpGet]
    public ActionResult Read()
    {        
        return Ok(db.Campaigns.ToList());
    }

    [HttpPost]
    public ActionResult Create(Campaign campaign)
    {
        db.Campaigns.Add(campaign);
        db.SaveChanges();

        return Created(campaign.Id.ToString(), campaign);
    }
    
    [HttpDelete]
    [Route("{id}")]
    public ActionResult Delete(int id)
    {
        Campaign? campaign = db.Campaigns.Find(id);

        if(campaign == null)
            return NotFound();

        db.Campaigns.Remove(campaign);
        db.SaveChanges();

        return Ok();
    }

    [HttpPut]
    [Route("{id}")]
    public ActionResult Update(int id, Campaign update)
    {
        Campaign? _campaign = db.Campaigns.Find(id);
        if(_campaign == null)
            return NotFound();

        _campaign.Name = update.Name;
        _campaign.SessionDate = update.SessionDate;
        _campaign.SessionHour = update.SessionHour;

        db.SaveChanges();
        return Ok();
    }

}