﻿using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.Common.DTO.ChallengeVersion
{
    public class NewChallengeVersionDto
    {
        public long? CreatedBy { get; set; }
        public long LanguageId { get; set; }
        public long ChallengeId { get; set; }
        public string InitialSolution { get; set; } = string.Empty;
        public string CompleteSolution { get; set; } = string.Empty;
        public string PreloadedCode { get; set; } = string.Empty;
        public string TestCases { get; set; } = string.Empty;
        public string ExampleTestCases { get; set; } = string.Empty;
        public ChallengeStatus Status { get; set; }
    }
}
