using C_WebApiTraining.Dtos.Character;
using C_WebApiTraining.Dtos.Weapon;

namespace C_WebApiTraining.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}
