namespace LeetWars.Core.DAL.Entities
{
    public class ChallengeStar : Entity<long>
    {
        public long ChallengeId { get; set; }

        public long AuthorId { get; set; }

        public Challenge? Challenge { get; set; }

        public User? Author { get; set; }
    }
}
