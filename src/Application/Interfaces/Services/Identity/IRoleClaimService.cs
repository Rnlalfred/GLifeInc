using System.Collections.Generic;
using System.Threading.Tasks;
using GLifeInc.Application.Interfaces.Common;
using GLifeInc.Application.Requests.Identity;
using GLifeInc.Application.Responses.Identity;
using GLifeInc.Shared.Wrapper;

namespace GLifeInc.Application.Interfaces.Services.Identity
{
    public interface IRoleClaimService : IService
    {
        Task<Result<List<RoleClaimResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

        Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

        Task<Result<string>> SaveAsync(RoleClaimRequest request);

        Task<Result<string>> DeleteAsync(int id);
    }
}