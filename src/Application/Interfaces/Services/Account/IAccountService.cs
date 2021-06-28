using GLifeInc.Application.Interfaces.Common;
using GLifeInc.Application.Requests.Identity;
using GLifeInc.Shared.Wrapper;
using System.Threading.Tasks;

namespace GLifeInc.Application.Interfaces.Services.Account
{
    public interface IAccountService : IService
    {
        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model, string userId);

        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}