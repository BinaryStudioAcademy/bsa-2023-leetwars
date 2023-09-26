using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.DAL.Entities
{
    public class ChallengeLevel : Entity<long>
    {
        public int Reward { get; set; }

        public LanguageLevel SkillLevel { get; set; }
    }
}
