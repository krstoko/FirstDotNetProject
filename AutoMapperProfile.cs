using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FirstDotNetProject.Dtos.Character;
using FirstDotNetProject.Dtos.Fight;
using FirstDotNetProject.Dtos.Skill;
using FirstDotNetProject.Dtos.Weapon;
using FirstDotNetProject.Models;

namespace FirstDotNetProject
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
            CreateMap<Character, HighScoreDto>();
        }
    }
}