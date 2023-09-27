using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.DAL.Entities
{
    public class ChallengeVersion : AuditEntity<long>
    {
        public long LanguageId { get; set; }
        public long ChallengeId { get; set; }
        public string InitialSolution { get; set; }
        public string CompleteSolution { get; set; }
        public string PreloadedCode { get; set; }
        public string TestCases { get; set; }
        public string ExampleTestCases { get; set; }

        public ChallengeStatus Status { get; set; }
        public ICollection<UserSolution> Solutions { get; } = new List<UserSolution>();
        public Language? Language { get; set; }
        public User? Author { get; set; }


        public ChallengeVersion(string initialSolution, string completeSolution, string preloadedCode, string testCases,
            string exampleTestCases)
        {
            InitialSolution = initialSolution;
            CompleteSolution = completeSolution;
            PreloadedCode = preloadedCode;
            TestCases = testCases;
            ExampleTestCases = exampleTestCases;
        }
    }
}