using GLifeInc.Application.Models.Chat;
using GLifeInc.Application.Responses.Identity;
using GLifeInc.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using GLifeInc.Application.Interfaces.Chat;

namespace GLifeInc.Client.Infrastructure.Managers.Communication
{
    public interface IChatManager : IManager
    {
        Task<IResult<IEnumerable<ChatUserResponse>>> GetChatUsersAsync();

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> chatHistory);

        Task<IResult<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string cId);
    }
}