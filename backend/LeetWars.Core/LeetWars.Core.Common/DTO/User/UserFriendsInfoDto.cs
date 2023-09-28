using LeetWars.Core.Common.DTO.Friendship;

namespace LeetWars.Core.Common.DTO.User
{
    public class UserFriendsInfoDto : BriefUserInfoDto
    {
        public ICollection<FriendshipPreviewDto>? Friendships { get; set; }
    }
}
