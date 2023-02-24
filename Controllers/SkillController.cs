using Microsoft.AspNetCore.Mvc;
using DeskUniverse_Backend.Models;

namespace DeskUniverse_Backend.Controllers;

[ApiController]
[Route("skill")]
public class SkillController : ControllerBase
{
    private DeskUniDB db;

    public SkillController(DeskUniDB db)
    {
        this.db = db;
    }

    [HttpGet]
    public ActionResult Read()
    {        
        return Ok(db.Skills.ToList());
    }

    [HttpPost]
    public ActionResult Create(Skill skill)
    {
        db.Skills.Add(skill);
        db.SaveChanges();

        return Created(skill.Id.ToString(), skill);
    }
    
    [HttpDelete]
    [Route("{id}")]
    public ActionResult Delete(int id)
    {
        Skill? skill = db.Skills.Find(id);

        if(skill == null)
            return NotFound();

        db.Skills.Remove(skill);
        db.SaveChanges();

        return Ok();
    }

    [HttpPut]
    [Route("{id}")]
    public ActionResult Update(int id, Skill update)
    {
        Skill? _skill = db.Skills.Find(id);
        if(_skill == null)
            return NotFound();

        _skill.Name = update.Name;
        _skill.Description = update.Description;

        db.SaveChanges();
        return Ok();
    }

}