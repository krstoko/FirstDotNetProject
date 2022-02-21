using Microsoft.AspNetCore.Mvc;
using FirstDotNetProject.Models;
using System.Collections.Generic;
using System.Linq;
using FirstDotNetProject.Services.CharacterService;
using System.Threading.Tasks;

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

        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<Character>> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]



        public async Task<ActionResult<Character>> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }


        [HttpPost]

        public async Task<ActionResult<List<Character>>> addCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return Ok(await _characterService.AddCharacter(newCharacter));
        }
    }
}