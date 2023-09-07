using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.Common.DTO.ChallengeStar
{
    public class ChallengeStarDto : Entity<long>
    {
        public long ChallengeId { get; set; }

        public string AuthorId { get; set; } = string.Empty;

        public bool IsStar { get; set; }
    }
}
