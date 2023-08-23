using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.Common.DTO.Challenge
{
    public class ChallengeDto : AuditEntity<long>
    {
        public string Title { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
        public int LevelId { get; set; }
    }
}
