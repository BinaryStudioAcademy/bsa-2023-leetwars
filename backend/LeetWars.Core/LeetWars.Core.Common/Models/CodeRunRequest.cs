namespace LeetWars.Core.Common.Models
{
    public class CodeRunRequest
    {
        public long UserId { get; set; }
        public long ChallengeVersionId { get; set;}
        public bool IsBuilt { get; set; } = false;
        public string Language { get; set; } = string.Empty;
        public string UserCode { get; set; } = string.Empty;
        public string? Preloaded { get; set; }
        public string? Tests { get; set; }

    }
}
