using Microsoft.AspNetCore.Mvc;
using DeskUniverse_Backend.Models;

namespace DeskUniverse_Backend.Controllers;

[ApiController]
[Route("item")]
public class ItemController : ControllerBase
{
    private DeskUniDB db;

    public ItemController(DeskUniDB db)
    {
        this.db = db;
    }

    [HttpGet]
    public ActionResult Read()
    {        
        return Ok(db.Itens.ToList());
    }

    [HttpPost]
    public ActionResult Create(Item item)
    {
        db.Itens.Add(item);
        db.SaveChanges();

        return Created(item.Id.ToString(), item);
    }
    
    [HttpDelete]
    [Route("{id}")]
    public ActionResult Delete(int id)
    {
        Item? item = db.Itens.Find(id);

        if(item == null)
            return NotFound();

        db.Itens.Remove(item);
        db.SaveChanges();

        return Ok();
    }

    [HttpPut]
    [Route("{id}")]
    public ActionResult Update(int id, Item update)
    {
        Item? _item = db.Itens.Find(id);
        if(_item == null)
            return NotFound();

        _item.Name = update.Name;
        _item.Description = update.Description;

        db.SaveChanges();
        return Ok();
    }

}