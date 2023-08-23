namespace LeetWars.Core.DAL.Entities
{
    public class UserSolution : AuditEntity<long>
    {
        public long ChallengeVersionId { get; set; }
        public string Code { get; set; }
        public string Output { get; set; }
        public DateTime? SubmittedAt { get; set; }
        public User? User { get; set; }

        public UserSolution(string code, string output)
        {
            Code = code;
            Output = output;
        }
    }
}
