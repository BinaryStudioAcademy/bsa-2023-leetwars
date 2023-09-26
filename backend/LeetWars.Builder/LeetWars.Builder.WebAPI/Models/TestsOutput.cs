namespace LeetWars.Builder.Models
{
    public class TestsOutput
    {
        public bool IsSuccess { get; set; }
        public int FailedCount { get; set; }
        public int PassedCount { get; set; }
        public string OverallDuration { get; set; }
        public ICollection<Test> TestsWithData { get; set; }

        public TestsOutput(bool isSuccess, string overallDuration, ICollection<Test> testsWithData, int failedCount, int passedCount)
        {
            OverallDuration = overallDuration;
            IsSuccess = isSuccess;
            TestsWithData = testsWithData;
            FailedCount = failedCount;
            PassedCount = passedCount;
        }
    }
}
