using C_WebApiTraining.Dtos.Fight;
using C_WebApiTraining.Services.FightService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace C_WebApiTraining.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FightController : ControllerBase
    {
        private readonly IFightService _fightService;

        public FightController(IFightService fightService)
        {
            _fightService = fightService;
        }

        [HttpPost("Weapon")]
        public async Task<ActionResult<ServiceResponse<AttackResultDto>>> WeaponAttack(WeaponAttackDto request)
        {
            return Ok(await _fightService.WeaponAttack(request));
        }

        [HttpPost("Skill")]
        public async Task<ActionResult<ServiceResponse<AttackResultDto>>> SkillAttacl(SkillAttackDto request)
        {
            return Ok(await _fightService.SkillAttack(request));
        }
    }
}
