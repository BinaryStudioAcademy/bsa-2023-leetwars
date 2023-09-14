using LeetWars.Core.Common.DTO.ChallengeVersion;
using LeetWars.Core.Common.DTO.Tag;
using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.Common.DTO.Challenge
{
    public class ChallengeEditDto : AuditEntity<long>
    {
        public string Title { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
        public long LevelId { get; set; }
        public ChallengeCategory Category { get; set; }
        public ICollection<TagDto>? Tags { get; set; }
        public ICollection<EditChallengeVersionDto>? Versions { get; set; }
    }
}
