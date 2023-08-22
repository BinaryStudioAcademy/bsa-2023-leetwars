namespace LeetWars.Core.DAL.Entities
{
    public class Challenge : AuditEntity<long>
    {
        public long AuthorId { get; set; }
        public string Title { get; set; }
        public string Instructions { get; set; }
        public int LevelId { get; set; }
        public ChallengeLevel? Level { get; set; }
        public User? Author { get; set; }
        public List<Tag> Tags { get; } = new();
        public List<ChallengeVersion> Versions { get; } = new();

        public Challenge(string title, string instructions)
        {
            Title = title;
            Instructions = instructions;
        }
    }
}
