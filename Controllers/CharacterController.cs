using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace C_WebApiTraining.Controllers
{
    [Route("api/[controller]")] // Where we will find the controller
    [ApiController] // Indicates all type are HTTP responses
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character> {
            new Character(),
            new Character { Id = 1, Name = "Sam" }
        };

        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id)
        {
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }

        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character character)
        {
            characters.Add(character);
            return Ok(characters);
        }

    }
}
