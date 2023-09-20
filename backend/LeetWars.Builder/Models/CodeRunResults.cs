namespace LeetWars.Builder.Models
{
    public class CodeRunResults
    {
        public string UserConnectionId { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public BuildResult? BuildResults { get; set; }
        public TestsOutput? TestRunResults { get; set; }
    }
}
