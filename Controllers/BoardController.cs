using Microsoft.AspNetCore.Mvc;
using DeskUniverse_Backend.Models;

namespace DeskUniverse_Backend.Controllers;

[ApiController]
[Route("board")]
public class BoardController : ControllerBase
{
    private DeskUniDB db;

    public BoardController(DeskUniDB db)
    {
        this.db = db;
    }

    [HttpGet]
    public ActionResult Read()
    {        
        return Ok(db.Boards.ToList());
    }

    [HttpPost]
    public ActionResult Create(Board board)
    {
        db.Boards.Add(board);
        db.SaveChanges();

        return Created(board.Id.ToString(), board);
    }
    
    [HttpDelete]
    [Route("{id}")]
    public ActionResult Delete(int id)
    {
        Board? board = db.Boards.Find(id);

        if(board == null)
            return NotFound();

        db.Boards.Remove(board);
        db.SaveChanges();

        return Ok();
    }

    [HttpPut]
    [Route("{id}")]
    public ActionResult Update(int id, Board update)
    {
        Board? _board = db.Boards.Find(id);
        if(_board == null)
            return NotFound();

        _board.Name = update.Name;
        _board.BackgroundURL = update.BackgroundURL;

        db.SaveChanges();
        return Ok();
    }

}