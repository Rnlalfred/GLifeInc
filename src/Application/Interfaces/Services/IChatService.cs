using GLifeInc.Application.Responses.Identity;
using GLifeInc.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using GLifeInc.Application.Interfaces.Chat;
using GLifeInc.Application.Models.Chat;

namespace GLifeInc.Application.Interfaces.Services
{
    public interface IChatService
    {
        Task<Result<IEnumerable<ChatUserResponse>>> GetChatUsersAsync(string userId);

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> message);

        Task<Result<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string userId, string contactId);
    }
}