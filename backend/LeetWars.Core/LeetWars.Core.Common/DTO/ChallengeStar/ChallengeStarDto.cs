using LeetWars.Core.Common.DTO.Challenge;

namespace LeetWars.Core.Common.DTO.ChallengeStar
{
    public class ChallengeStarDto
    {
        public ChallengePreviewDto Challenge { get; set; } = null!;

        public long AuthorId { get; set; }

        public bool IsStar { get; set; }
    }
}
