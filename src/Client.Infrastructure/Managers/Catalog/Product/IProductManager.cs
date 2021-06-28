using GLifeInc.Application.Features.Products.Commands.AddEdit;
using GLifeInc.Application.Features.Products.Queries.GetAllPaged;
using GLifeInc.Application.Requests.Catalog;
using GLifeInc.Shared.Wrapper;
using System.Threading.Tasks;

namespace GLifeInc.Client.Infrastructure.Managers.Catalog.Product
{
    public interface IProductManager : IManager
    {
        Task<PaginatedResult<GetAllPagedProductsResponse>> GetProductsAsync(GetAllPagedProductsRequest request);

        Task<IResult<string>> GetProductImageAsync(int id);

        Task<IResult<int>> SaveAsync(AddEditProductCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}