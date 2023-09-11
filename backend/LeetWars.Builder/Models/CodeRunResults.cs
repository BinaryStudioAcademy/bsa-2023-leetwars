namespace LeetWars.Builder.Models
{
    public class CodeRunResults
    {
        public long UserId { get; set; }
        public long ChallengeVersionId { get; set; }
        public string Language { get; set; } = string.Empty;
        public BuildResult? BuildResults { get; set; }
        public string? TestRunResults { get; set; }
    }
}
