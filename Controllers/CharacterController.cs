using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace C_WebApiTraining.Controllers
{
    [Route("api/[controller]")] // Where we will find the controller
    [ApiController] // Indicates all type are HTTP responses
    public class CharacterController : ControllerBase
    {
        private static Character knight = new Character();

        public IActionResult Get()
        {
            return Ok(knight);
        }
    }
}
