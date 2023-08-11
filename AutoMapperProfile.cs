using AutoMapper;
using C_WebApiTraining.Dtos.Character;
using C_WebApiTraining.Dtos.Skill;
using C_WebApiTraining.Dtos.Weapon;

namespace C_WebApiTraining
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<UpdateCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
        }
    }
}
