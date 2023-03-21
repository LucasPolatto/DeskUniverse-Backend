using Microsoft.AspNetCore.Mvc;
using DeskUniverse_Backend.Models;

namespace DeskUniverse_Backend.Controllers;

[ApiController]
[Route("character")]
public class CharacterController : ControllerBase
{
    private DeskUniDB db;

    public CharacterController(DeskUniDB db)
    {
        this.db = db;
    }

    [HttpGet]
    public ActionResult Read()
    {        
        return Ok(db.Characters.ToList());
    }

    [HttpPost]
    public ActionResult Create(Character character)
    {
        db.Characters.Add(character);
        db.SaveChanges();

        return Created(character.Id.ToString(), character);
    }
    
    [HttpDelete]
    [Route("{id}")]
    public ActionResult Delete(int id)
    {
        Character? character = db.Characters.Find(id);

        if(character == null)
            return NotFound();

        db.Characters.Remove(character);
        db.SaveChanges();

        return Ok();
    }

    [HttpPut]
    [Route("{id}")]
    public ActionResult Update(int id, Character update)
    {
        Character? _character = db.Characters.Find(id);
        if(_character == null)
            return NotFound();

        //Identificação do Personagem

        _character.CampaignId = update.CampaignId;
        _character.Name = update.Name;
        _character.Race = update.Race;
        _character.Gender = update.Gender;
        _character.Age = update.Age;
        _character.Class = update.Class;
        _character.Description = update.Description;
        _character.History = update.History;


        //Estatísticas do Personagem
        _character.Level = update.Level;
        _character.Health = update.Health;
        _character.Mana = update.Mana;
        _character.STR = update.STR;
        _character.DEX = update.DEX;
        _character.CON = update.CON;
        _character.INT = update.INT;
        _character.WIS = update.WIS;
        _character.CHA = update.CHA;
        _character.WIL = update.WIL;
        _character.PD = update.PD;
        _character.MD = update.MD;

        db.SaveChanges();
        return Ok();
    }

}