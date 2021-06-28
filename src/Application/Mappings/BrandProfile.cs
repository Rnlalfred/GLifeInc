using AutoMapper;
using GLifeInc.Application.Features.Brands.Commands.AddEdit;
using GLifeInc.Application.Features.Brands.Queries.GetAll;
using GLifeInc.Application.Features.Brands.Queries.GetById;
using GLifeInc.Domain.Entities.Catalog;

namespace GLifeInc.Application.Mappings
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<AddEditBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsResponse, Brand>().ReverseMap();
        }
    }
}