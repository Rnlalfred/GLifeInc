using GLifeInc.Application.Interfaces.Common;

namespace GLifeInc.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}