namespace LeetWars.Core.DAL.Entities
{
    public class Test : AuditEntity<long>
    {
        public long ChallengeVersionId { get; set; }
        public string Code { get; set; }
        public bool IsPublic { get; set; }
        public User? Author { get; set; }

        public Test(string code)
        {
            Code = code;
        }

    }
}
