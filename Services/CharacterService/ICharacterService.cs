using System.Collections.Generic;
using System.Threading.Tasks;
using FirstDotNetProject.Models;

namespace FirstDotNetProject.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<Character>>> GetAllCharacters();
        Task<ServiceResponse<Character>> GetCharacterById(int id);

        Task<ServiceResponse<List<Character>>> AddCharacter(Character character);
    }
}