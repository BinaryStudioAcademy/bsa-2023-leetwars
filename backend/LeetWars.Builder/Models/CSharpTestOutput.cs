namespace LeetWars.Builder.Models
{
    public class CSharpTestOutput
    {
        public string OverallOutcome { get; set; }
        public string FailedCount { get; set; }
        public string PassedCount { get; set; }
        public string OverallDuration { get; set; }
        public ICollection<CSharpTest> TestsWithData { get; set; }

        public CSharpTestOutput(string overallOutcome, string overallDuration, ICollection<CSharpTest> testsWithData, string failedCount, string passedCount)
        {
            OverallDuration = overallDuration;
            OverallOutcome = overallOutcome;
            TestsWithData = testsWithData;
            FailedCount = failedCount;
            PassedCount = passedCount;
        }
    }
}
