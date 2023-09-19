using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.Common.DTO.ChallengeLevel
{
    public class NewChallengeLevelDto
    {
        public SkillLevel DifficultyLevel { get; set; }
        public int Reward { get; set; }
        public LanguageLevel SkillLevel { get; set; }
    }
}
