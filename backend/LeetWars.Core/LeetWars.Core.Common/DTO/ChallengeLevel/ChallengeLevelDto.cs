using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.Common.DTO.ChallengeLevel
{
    public class ChallengeLevelDto : Entity<int>
    {
        public string Name { get; set; } = string.Empty;
        public int Reward { get; set; }
    }
}
