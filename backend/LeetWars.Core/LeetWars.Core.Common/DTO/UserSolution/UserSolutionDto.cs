using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.Common.DTO.UserSolution
{
    public class UserSolutionDto : AuditEntity<long>
    {
        public long ChallengeVersionId { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Output { get; set; } = string.Empty;
        public DateTime? SubmittedAt { get; set; }
    }
}

