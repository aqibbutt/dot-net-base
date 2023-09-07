using System;
using Rest_Demo.DTO;
using Rest_Demo.Models;

namespace Rest_Demo.Service
{
	public interface ICharacterService
	{

        ServiceResponse<List<CharacterDTO>> GetAllCharacters();
        ServiceResponse<CharacterDTO> GetCharacterById(int id);
        ServiceResponse<List<CharacterDTO>> AddCharacter(GetCharacterDTO character);
	}
}

