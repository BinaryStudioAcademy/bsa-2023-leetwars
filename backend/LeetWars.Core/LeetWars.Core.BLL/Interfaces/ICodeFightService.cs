using LeetWars.Core.Common.DTO.CodeFight;
using LeetWars.Core.Common.DTO.Notifications;
using LeetWars.Core.Common.DTO.User;

namespace LeetWars.Core.BLL.Interfaces
{
    public interface ICodeFightService
    {
        Task<List<UserDto>> SendCodeFightRequestStartedAsync(CodeFightRequestDto requestDto);
        Task<List<UserDto>> SendcodeFightRequestEndedAsync(NotificationDto notification);
        Task<List<UserDto>> SendCodeFightStartAsync(NotificationDto notificationDto);
        Task<List<UserDto>> SendCodeFightEndAsync(CodeFightEndDto codeFightEndDto);
    }
}
