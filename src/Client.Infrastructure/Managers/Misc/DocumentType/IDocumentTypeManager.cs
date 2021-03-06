using System.Collections.Generic;
using System.Threading.Tasks;
using GLifeInc.Application.Features.DocumentTypes.Commands.AddEdit;
using GLifeInc.Application.Features.DocumentTypes.Queries.GetAll;
using GLifeInc.Shared.Wrapper;

namespace GLifeInc.Client.Infrastructure.Managers.Misc.DocumentType
{
    public interface IDocumentTypeManager : IManager
    {
        Task<IResult<List<GetAllDocumentTypesResponse>>> GetAllAsync();

        Task<IResult<int>> SaveAsync(AddEditDocumentTypeCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}