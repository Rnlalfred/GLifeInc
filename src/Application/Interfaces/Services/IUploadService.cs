using GLifeInc.Application.Requests;

namespace GLifeInc.Application.Interfaces.Services
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}