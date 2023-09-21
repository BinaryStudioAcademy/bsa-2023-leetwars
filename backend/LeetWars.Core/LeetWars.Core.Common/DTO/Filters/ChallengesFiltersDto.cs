using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.Common.DTO.Filters
{
    public class ChallengesFiltersDto
    {
        public string? Title { get; set; }
        public ChallengeStatus? ChallengeStatus { get; set; }
        public long? LanguageId { get; set; }
        public ICollection<long>? TagsIds { get; set; }
        public ChallengesProgress? Progress { get; set; }

        public LanguageLevel? SkillLevel { get; set; }
    }
}