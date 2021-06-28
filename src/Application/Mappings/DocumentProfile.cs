using AutoMapper;
using GLifeInc.Application.Features.Documents.Commands.AddEdit;
using GLifeInc.Application.Features.Documents.Queries.GetById;
using GLifeInc.Domain.Entities.Misc;

namespace GLifeInc.Application.Mappings
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<AddEditDocumentCommand, Document>().ReverseMap();
            CreateMap<GetDocumentByIdResponse, Document>().ReverseMap();
        }
    }
}