﻿using C_WebApiTraining.Dtos.Character;
using C_WebApiTraining.Services.CharacterService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace C_WebApiTraining.Controllers
{
    [Route("api/[controller]")] // Where we will find the controller
    [ApiController] // Indicates all type are HTTP responses
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> AddCharacter(AddCharacterDto newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> UpdateCharacter(UpdateCharacterDto updatedCharacter)
        {
            var response = await _characterService.UpdateCharacter(updatedCharacter);

            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpDelete("{id}")]    
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> Delete(int id)
        {
            var response = await _characterService.DeleteCharacter(id);

            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

    }
}
