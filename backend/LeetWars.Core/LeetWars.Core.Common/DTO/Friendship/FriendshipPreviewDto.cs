using LeetWars.Core.DAL.Enums;
using System.Text.Json.Serialization;

namespace LeetWars.Core.Common.DTO.Friendship
{
    public class FriendshipPreviewDto
    {
        public long FriendshipId { get; set; }
        public long FriendId { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public FriendshipStatus FriendshipStatus { get; set; }
    }
}
