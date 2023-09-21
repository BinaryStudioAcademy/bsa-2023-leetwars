using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.Common.DTO.ChallengeLevel
{
    public class ChallengeLevelDto : Entity<long>
    {
        public int Reward { get; set; }
        public LanguageLevel SkillLevel { get; set; }
    }
}
