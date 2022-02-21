using Microsoft.AspNetCore.Mvc;
using FirstDotNetProject.Models;
using System.Collections.Generic;
using FirstDotNetProject.Services.CharacterService;
using System.Threading.Tasks;
using FirstDotNetProject.Dtos.Character;

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
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]



        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }


        [HttpPost]

        public async Task<ActionResult<ServiceResponse<List<AddCharacterDto>>>> AddCharacter(AddCharacterDto newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> UpdateCharacter(UpdateCharacterDto updateCharacter)
        {
            var result = await _characterService.UpdateCharacter(updateCharacter);
            if (result.Data == null)
            {
                return NotFound(result);
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> DeleteCharacter(int id)
        {
            var result = await _characterService.DeleteCharacter(id);
            if (result.Data == null)
            {
                return NotFound(result);
            }
            return Ok(result);
        }
    }
}