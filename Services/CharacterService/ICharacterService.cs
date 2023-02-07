using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<AddCharacterDto>>> AddCharacter(Character newCharacter);
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
    }
}