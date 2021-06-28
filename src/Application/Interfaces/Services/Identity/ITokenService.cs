using GLifeInc.Application.Interfaces.Common;
using GLifeInc.Application.Requests.Identity;
using GLifeInc.Application.Responses.Identity;
using GLifeInc.Shared.Wrapper;
using System.Threading.Tasks;

namespace GLifeInc.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}