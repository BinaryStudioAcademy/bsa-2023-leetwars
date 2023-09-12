using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.DAL.Entities
{
    public class ChallengeLevel : Entity<long>
    {
        public string Name { get; set; }
        public int Reward { get; set; }
        
        public LanguageLevel SkillLevel { get; set; }

        public ChallengeLevel(string name)
        {
            Name = name;
        }
    }
}
