using AutoMapper;
using GLifeInc.Application.Interfaces.Chat;
using GLifeInc.Application.Models.Chat;
using GLifeInc.Infrastructure.Models.Identity;

namespace GLifeInc.Infrastructure.Mappings
{
    public class ChatHistoryProfile : Profile
    {
        public ChatHistoryProfile()
        {
            CreateMap<ChatHistory<IChatUser>, ChatHistory<BlazorHeroUser>>().ReverseMap();
        }
    }
}