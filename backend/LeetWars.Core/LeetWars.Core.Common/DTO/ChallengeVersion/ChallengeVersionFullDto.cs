using LeetWars.Core.Common.DTO.Language;
using LeetWars.Core.Common.DTO.LanguageVersion;
using LeetWars.Core.Common.DTO.Test;
using LeetWars.Core.Common.DTO.UserSolution;
using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.Common.DTO.ChallengeVersion
{
    public class ChallengeVersionFullDto
    {
        public int LanguageId { get; set; }
        public long ChallengeId { get; set; }
        public string InitialSolution { get; set; } = string.Empty;
        public string CompleteSolution { get; set; } = string.Empty;
        public ChallengeStatus Status { get; set; }
        public List<LanguageVersionDto> LanguageVersions { get; set; } = new();
        public List<UserSolutionDto> Solutions { get; set; } = new();
        public List<TestDto> Tests { get; set; } = new();
        public LanguageDto? Language { get; set; }
    }
}
