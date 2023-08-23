using LeetWars.Core.Common.DTO.User;
using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.Common.DTO.UserSolution
{
    public class UserSolutionFullDto : AuditEntity<long>
    {
        public long UserId { get; set; }
        public long ChallengeVersionId { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Output { get; set; } = string.Empty;
        public DateTime? SubmittedAt { get; set; }
        public UserDto? User { get; set; }
    }
}
