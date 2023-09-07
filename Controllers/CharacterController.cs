using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rest_Demo.DTO;
using Rest_Demo.Models;
using Rest_Demo.Service;

namespace Rest_Demo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet("GetAll")]
        public ActionResult<List<Character>> get()
        {
            return Ok(_characterService.GetAllCharacters());
        }


        [HttpGet("GetById/{id}")]
        public ActionResult<List<CharacterDTO>> get(int id)
        {
            return Ok(_characterService.GetCharacterById(id));
        }

        [HttpPost]
        public ActionResult<List<CharacterDTO>> add(GetCharacterDTO newCharacter)
        {
            return Ok(_characterService.AddCharacter(newCharacter));
        }


    }
}

