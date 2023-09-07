namespace LeetWars.Core.DAL.Entities
{
    public class ChallengeStar : Entity<long>
    {
        public long ChallengeId { get; set; }

        public string AuthorId { get; set; } = string.Empty;

        public Challenge? Challenge { get; set; }

        public User? Author { get; set; }
    }
}
