using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.DAL.Entities
{
    public class Challenge : AuditEntity<long>
    {
        public string Title { get; set; }
        public string Instructions { get; set; }
        public int LevelId { get; set; }
        public ChallengeLevel? Level { get; set; }
        
        public ChallengeCategory Category { get; set; }
        public User? Author { get; set; }
        public ICollection<Tag> Tags { get; } = new List<Tag>();
        public ICollection<ChallengeVersion> Versions { get; } = new List<ChallengeVersion>();
        public ICollection<ChallengeStar> Stars { get; } = new List<ChallengeStar>();   

        public Challenge(string title, string instructions)
        {
            Title = title;
            Instructions = instructions;
        }
    }
}
