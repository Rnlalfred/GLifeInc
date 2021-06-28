using GLifeInc.Application.Features.Documents.Commands.AddEdit;
using GLifeInc.Application.Features.Documents.Queries.GetAll;
using GLifeInc.Application.Requests.Documents;
using GLifeInc.Shared.Wrapper;
using System.Threading.Tasks;
using GLifeInc.Application.Features.Documents.Queries.GetById;

namespace GLifeInc.Client.Infrastructure.Managers.Misc.Document
{
    public interface IDocumentManager : IManager
    {
        Task<PaginatedResult<GetAllDocumentsResponse>> GetAllAsync(GetAllPagedDocumentsRequest request);

        Task<IResult<GetDocumentByIdResponse>> GetByIdAsync(GetDocumentByIdQuery request);

        Task<IResult<int>> SaveAsync(AddEditDocumentCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}