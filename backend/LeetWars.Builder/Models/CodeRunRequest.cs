﻿namespace LeetWars.Builder.Models
{
    public class CodeRunRequest
    {
        public string UserConnectionId { get; set; } = string.Empty;
        public long UserId { get; set; }
        public long ChallengeVersionId { get; set;}
        public bool IsBuilt { get; set; }
        public string Language { get; set; } = string.Empty;
        public string UserCode { get; set; } = string.Empty;
        public string? Preloaded { get; set; }
        public string? Tests { get; set; }

    }
}
