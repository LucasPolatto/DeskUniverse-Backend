using Microsoft.AspNetCore.Mvc;
using DeskUniverse_Backend.Models;

namespace DeskUniverse_Backend.Controllers;

[ApiController]
[Route("image")]
public class ImageController : ControllerBase
{
    private DeskUniDB db;

    public ImageController(DeskUniDB db)
    {
        this.db = db;
    }

    [HttpGet]
    public ActionResult Read()
    {        
        return Ok(db.Images.ToList());
    }

    [HttpPost]
    public ActionResult Create(Image image)
    {
        db.Images.Add(image);
        db.SaveChanges();

        return Created(image.Id.ToString(), image);
    }
    
    [HttpDelete]
    [Route("{id}")]
    public ActionResult Delete(int id)
    {
        Image? image = db.Images.Find(id);

        if(image == null)
            return NotFound();

        db.Images.Remove(image);
        db.SaveChanges();

        return Ok();
    }

    [HttpPut]
    [Route("{id}")]
    public ActionResult Update(int id, Image update)
    {
        Image? _image = db.Images.Find(id);
        if(_image == null)
            return NotFound();

        _image.ImageURL = update.ImageURL;

        db.SaveChanges();
        return Ok();
    }

}