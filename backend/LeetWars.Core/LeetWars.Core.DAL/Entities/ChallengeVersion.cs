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
        public List<LanguageVersion> LanguageVersions { get; } = new();
        public List<UserSolution> Solutions { get; } = new();
        public List<Test> Tests { get; } = new();
        public Language? Language { get; set; }


        public ChallengeVersion(string initialSolution, string completeSolution)
        {
            InitialSolution = initialSolution;
            CompleteSolution = completeSolution;
        }
    }
}
