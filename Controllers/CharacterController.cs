using Microsoft.AspNetCore.Mvc;
using FirstDotNetProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace FirstDotNetProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character{Id = 1,Name = "Sam"}
        };

        [HttpGet("GetAll")]
        public ActionResult<Character> Get()
        {
            return Ok(characters);
        }

        [HttpGet("{id}")]

        public ActionResult<Character> GetSingle(int id)
        {
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }
    }
}