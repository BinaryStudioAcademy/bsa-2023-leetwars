using LeetWars.Core.DAL.Enums;
using System.Text.Json.Serialization;

namespace LeetWars.Core.Common.DTO.Friendship
{
    public class UpdateFriendshipDto
    {
        public long UserId { get; set; }
        public long FriendshipId { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public FriendshipStatus FriendshipStatus { get; set; }

        public UpdateFriendshipDto(long userId, long friendshipId, FriendshipStatus friendshipStatus)
        {
            UserId = userId;
            FriendshipId = friendshipId;
            FriendshipStatus = friendshipStatus;
        }
    }
}
