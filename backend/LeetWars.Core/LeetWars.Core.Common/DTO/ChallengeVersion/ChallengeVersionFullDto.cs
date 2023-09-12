using LeetWars.Core.Common.DTO.Language;
using LeetWars.Core.Common.DTO.LanguageVersion;
using LeetWars.Core.Common.DTO.Test;
using LeetWars.Core.Common.DTO.User;
using LeetWars.Core.Common.DTO.UserSolution;
using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.Common.DTO.ChallengeVersion
{
    public class ChallengeVersionFullDto : AuditEntity<long>
    {
        public long LanguageId { get; set; }
        public long ChallengeId { get; set; }
        public string InitialSolution { get; set; } = string.Empty;
        public string CompleteSolution { get; set; } = string.Empty;
        public string PreloadedCode { get; set; } = string.Empty;
        public string TestCases { get; set; } = string.Empty;
        public string ExampleTestCases { get; set; } = string.Empty;
        public ChallengeStatus Status { get; set; }
        public ICollection<LanguageVersionDto>? LanguageVersions { get; set; }
        public ICollection<UserSolutionDto>? Solutions { get; set; }
        public LanguageFullDto? Language { get; set; }
        public UserDto? Author { get; set; }
    }
}
