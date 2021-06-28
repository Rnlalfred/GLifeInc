using AutoMapper;
using GLifeInc.Application.Requests.Identity;
using GLifeInc.Application.Responses.Identity;

namespace GLifeInc.Client.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<PermissionResponse, PermissionRequest>().ReverseMap();
            CreateMap<RoleClaimResponse, RoleClaimRequest>().ReverseMap();
        }
    }
}