using LeetWars.Core.Common.DTO.ChallengeLevel;
using LeetWars.Core.Common.DTO.ChallengeVersion;
using LeetWars.Core.Common.DTO.Tag;
using LeetWars.Core.Common.DTO.User;
using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.Common.DTO.Challenge
{
    public class ChallengeFullDto : AuditEntity<long>
    {
        public string Title { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
        public int LevelId { get; set; }
        public ChallengeLevelDto? Level { get; set; }
        public UserDto? Author { get; set; }
        public ICollection<TagDto>? Tags { get; set; }
        public ICollection<ChallengeVersionDto>? Versions { get; set; }
    }
}
