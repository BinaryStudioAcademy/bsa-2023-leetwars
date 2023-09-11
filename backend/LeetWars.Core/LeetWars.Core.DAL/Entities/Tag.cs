namespace LeetWars.Core.DAL.Entities
{
    public class Tag : Entity<long>
    {
        public string Name { get; set; }
        public ICollection<Challenge> Challenges { get; } = new List<Challenge>();
        public ICollection<ChallengeTag> ChallengeTags { get; } = new List<ChallengeTag>();

        public Tag(string name)
        {
            Name = name;
        }
    }
}
