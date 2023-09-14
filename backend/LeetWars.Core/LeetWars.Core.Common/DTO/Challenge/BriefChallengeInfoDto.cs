using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.Common.DTO.Challenge
{
    public class BriefChallengeInfoDto :AuditEntity<long>
    {
        public long ChallengeId { get; set; }

        public string Title { get; set; } = string.Empty;
    }
}
