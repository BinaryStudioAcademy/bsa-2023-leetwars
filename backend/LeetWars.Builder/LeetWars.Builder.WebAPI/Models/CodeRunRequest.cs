﻿namespace LeetWars.Builder.Models
{
    public class CodeRunRequest
    {
        public string UserConnectionId { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public string UserCode { get; set; } = string.Empty;
        
        public bool IsSubmitRequest { get; set; }
        public string? Preloaded { get; set; }
        public string? Tests { get; set; }
    }
}
