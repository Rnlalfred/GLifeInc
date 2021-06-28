using GLifeInc.Application.Interfaces.Common;
using GLifeInc.Application.Requests.Identity;
using GLifeInc.Application.Responses.Identity;
using GLifeInc.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GLifeInc.Application.Interfaces.Services.Identity
{
    public interface IRoleService : IService
    {
        Task<Result<List<RoleResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleResponse>> GetByIdAsync(string id);

        Task<Result<string>> SaveAsync(RoleRequest request);

        Task<Result<string>> DeleteAsync(string id);

        Task<Result<PermissionResponse>> GetAllPermissionsAsync(string roleId);

        Task<Result<string>> UpdatePermissionsAsync(PermissionRequest request);
    }
}