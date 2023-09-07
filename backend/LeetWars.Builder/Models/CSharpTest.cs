namespace LeetWars.Builder.Models
{
    public class CSharpTest
    {
        public string TestName { get; set; }
        public string Outcome { get; set; }
        public string? ErrorMessage { get; set; }
        public string Duration { get; set; }

        public CSharpTest(string testName, string outcome, string duration)
        {
            TestName = testName;
            Outcome = outcome;
            Duration = duration;
        }
    }

}
