using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.DAL.Entities
{
    public class ChallengeVersion : AuditEntity<long>
    {
        public int LanguageId { get; set; }
        public long ChallengeId { get; set; }
        public string InitialSolution { get; set; }
        public string CompleteSolution { get; set; }
        public ChallengeStatus Status { get; set; }
        public ICollection<LanguageVersion> LanguageVersions { get; } = new List<LanguageVersion>();
        public ICollection<UserSolution> Solutions { get; } = new List<UserSolution>();
        public ICollection<Test> Tests { get; } = new List<Test>();
        public Language? Language { get; set; }
        public User? Author { get; set; }


        public ChallengeVersion(string initialSolution, string completeSolution)
        {
            InitialSolution = initialSolution;
            CompleteSolution = completeSolution;
        }
    }
}
