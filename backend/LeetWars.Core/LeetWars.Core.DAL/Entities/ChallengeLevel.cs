using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.DAL.Entities
{
    public class ChallengeLevel : Entity<long>
    {
        public SkillLevel DifficultyLevel { get; set; }
        public int Reward { get; set; }
        
        public LanguageLevel SkillLevel { get; set; }

        public ChallengeLevel(SkillLevel difficultyLevel)
        {
            DifficultyLevel = difficultyLevel;
        }
    }
}
