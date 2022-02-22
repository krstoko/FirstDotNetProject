using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstDotNetProject.Dtos.Character;
using FirstDotNetProject.Dtos.Weapon;
using FirstDotNetProject.Models;

namespace FirstDotNetProject.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}