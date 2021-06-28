using AutoMapper;
using GLifeInc.Application.Features.DocumentTypes.Commands.AddEdit;
using GLifeInc.Application.Features.DocumentTypes.Queries.GetAll;
using GLifeInc.Application.Features.DocumentTypes.Queries.GetById;
using GLifeInc.Domain.Entities.Misc;

namespace GLifeInc.Application.Mappings
{
    public class DocumentTypeProfile : Profile
    {
        public DocumentTypeProfile()
        {
            CreateMap<AddEditDocumentTypeCommand, DocumentType>().ReverseMap();
            CreateMap<GetDocumentTypeByIdResponse, DocumentType>().ReverseMap();
            CreateMap<GetAllDocumentTypesResponse, DocumentType>().ReverseMap();
        }
    }
}