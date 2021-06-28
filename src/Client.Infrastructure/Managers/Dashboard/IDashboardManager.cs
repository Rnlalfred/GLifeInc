using GLifeInc.Shared.Wrapper;
using System.Threading.Tasks;
using GLifeInc.Application.Features.Dashboards.Queries.GetData;

namespace GLifeInc.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}