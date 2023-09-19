using LeetWars.Core.Common.DTO.User;
using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.Common.DTO.Challenge
{
    public class BriefChallengeInfoDto : Entity<long>
    {
        public BriefUserInfoDto Author { get; set; } = new();

        public long ChallengeId { get; set; }

        public string Title { get; set; } = string.Empty;
    }
}
