using LeetWars.Core.Common.DTO.ChallengeLevel;
using LeetWars.Core.Common.DTO.Language;
using LeetWars.Core.Common.DTO.Tag;
using LeetWars.Core.DAL.Enums;


namespace LeetWars.Core.Common.DTO.ChallengeGenerate
{
    public class ChallengeGenerateResponseDto
    {
        public string Description { get; set; }

        public string CompleteSolution { get; set; }
        public string InitialSolution { get; set; }
        public string TestCases { get; set; }

        public string ExampleTestCases { get; set; }

        public string Title { get; set; } = string.Empty;

        public ChallengeCategory Category { get; set; }

        public ChallengeLevelDto? Level { get; set; }
        public ICollection<TagDto>? Tags { get; set; }
        public LanguageDto? Language { get; set; }
        public ChallengeGenerateResponseDto() { }
    }
}
