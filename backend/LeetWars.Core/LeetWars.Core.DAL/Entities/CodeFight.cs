namespace LeetWars.Core.DAL.Entities
{
    public class CodeFight : Entity<long>
    {
        public long SenderId { get; set; }
        public long ReceiverId { get; set; }
        public long ChallengeId { get; set; }

        public User? Sender { get; set; }
        public User? Receiver { get; set; }
    }
}
