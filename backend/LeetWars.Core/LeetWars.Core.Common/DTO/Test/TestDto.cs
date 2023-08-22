using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.Common.DTO.Test
{
    public class TestDto : AuditEntity<long>
    {
        public long ChallengeVersionId { get; set; }
        public string Code { get; set; } = string.Empty;
        public bool IsPublic { get; set; }
    }
}
