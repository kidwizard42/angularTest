using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace angularTest.Controllers;

[ApiController]
public class NotesController : ControllerBase
{
    //GET: /<controller>/

    string noteText = "noteText endpoint";
    Dictionary<int, string> obj = new Dictionary<int, string>() { { 1, "soccer" }, { 2, "goat is messi" } };

    [HttpGet]
    [Route("notesbro")]
    public Dictionary<int,string> Get()
    {
        Console.WriteLine("everything looks good here");

        return obj;
    }

    [HttpGet]
    [Route("notesbro/{id}")]
    //public Dictionary<int, string> GetW(int id)
    public IActionResult GetW(int id)
    {
        //Response.StatusCode = 404;

        return BadRequest("HMMM I guess this is better for us");

        //try {

        //return new Dictionary<int, string>() { { id, obj[id] } };
        //}
        //catch
        //{

        //    //return BadRequest("bruv what are you on");
        //    throw new BadHttpRequestException("bro this did not work man", 401);
        //}
        
    }


    [HttpPut]
    [Route("notesbro")]
    public Dictionary<int,string> UpdateNote(UpdatedNote updatedNote)
    {
        int[] allThekeys = updatedNote.Keys.ToArray();
        int key = allThekeys[0];
        string[] allTheTexts = updatedNote.Values.ToArray();
        string text = allTheTexts[0];
        

        if (obj.TryGetValue(key, out string? val))
        {
            obj[key] = text;
            return obj;
        }
        
        return obj;
    }

    public class UpdatedNote : Dictionary<int,string>
    {
        int key;
        string? value;
    }

}
