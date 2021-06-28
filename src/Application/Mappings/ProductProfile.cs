using AutoMapper;
using GLifeInc.Application.Features.Products.Commands.AddEdit;
using GLifeInc.Domain.Entities.Catalog;

namespace GLifeInc.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddEditProductCommand, Product>().ReverseMap();
        }
    }
}