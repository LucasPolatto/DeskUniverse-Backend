using Microsoft.AspNetCore.Mvc;
using DeskUniverse_Backend.Models;

namespace DeskUniverse_Backend.Controllers;

[ApiController]
[Route("token")]
public class TokenController : ControllerBase
{
    private DeskUniDB db;

    public TokenController(DeskUniDB db)
    {
        this.db = db;
    }

    [HttpGet]
    public ActionResult Read()
    {        
        return Ok(db.Tokens.ToList());
    }

    [HttpPost]
    public ActionResult Create(Token token)
    {
        db.Tokens.Add(token);
        db.SaveChanges();

        return Created(token.Id.ToString(), token);
    }
    
    [HttpDelete]
    [Route("{id}")]
    public ActionResult Delete(int id)
    {
        Token? token = db.Tokens.Find(id);

        if(token == null)
            return NotFound();

        db.Tokens.Remove(token);
        db.SaveChanges();

        return Ok();
    }

    [HttpPut]
    [Route("{id}")]
    public ActionResult Update(int id, Token update)
    {
        Token? _token = db.Tokens.Find(id);
        if(_token == null)
            return NotFound();

        _token.ImageURL = update.ImageURL;
        _token.Position = update.Position;
        _token.Health = update.Health;
        _token.Mana = update.Mana;

        db.SaveChanges();
        return Ok();
    }

}