using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.Common.DTO.Challenge
{
    public class ChallengeRewardDto : Entity<int>
    {
        public long ChallengeId { get; set; }

        public int Reward { get; set; }
    }
}
