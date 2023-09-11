namespace LeetWars.Builder.Models
{
    public class CodeRunResults
    {
        public long UserId { get; set; }
        public long ChallengeVersionId { get; set; }
        public string Language { get; set; } = string.Empty;
        public bool IsBuilt { get; set; }
        public string? BuildResults { get; set; }
        public string? TestRunResults { get; set; }

    }
}
