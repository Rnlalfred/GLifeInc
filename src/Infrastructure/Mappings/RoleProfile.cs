using AutoMapper;
using GLifeInc.Infrastructure.Models.Identity;
using GLifeInc.Application.Responses.Identity;

namespace GLifeInc.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, BlazorHeroRole>().ReverseMap();
        }
    }
}