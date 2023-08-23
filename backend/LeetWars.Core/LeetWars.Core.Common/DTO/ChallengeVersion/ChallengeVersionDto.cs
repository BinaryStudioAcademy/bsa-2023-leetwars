using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.Common.DTO.ChallengeVersion
{
    public class ChallengeVersionDto : AuditEntity<long>
    {
        public int LanguageId { get; set; }
        public long ChallengeId { get; set; }
        public string InitialSolution { get; set; } = string.Empty;
        public string CompleteSolution { get; set; } = string.Empty;
        public ChallengeStatus Status { get; set; }
    }
}
