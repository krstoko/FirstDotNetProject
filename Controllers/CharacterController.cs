using Microsoft.AspNetCore.Mvc;
using FirstDotNetProject.Models;
using System.Collections.Generic;

namespace FirstDotNetProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character{Name = "Sam"}
        };

        [HttpGet("GetAll")]
        public ActionResult<Character> Get()
        {
            return Ok(characters);
        }

        [HttpGet]

        public ActionResult<Character> GetSingle()
        {
            return Ok(characters[0]);
        }
    }
}