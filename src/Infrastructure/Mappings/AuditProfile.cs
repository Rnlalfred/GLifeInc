using AutoMapper;
using GLifeInc.Infrastructure.Models.Audit;
using GLifeInc.Application.Responses.Audit;

namespace GLifeInc.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}