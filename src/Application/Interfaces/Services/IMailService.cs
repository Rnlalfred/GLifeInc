using GLifeInc.Application.Requests.Mail;
using System.Threading.Tasks;

namespace GLifeInc.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}