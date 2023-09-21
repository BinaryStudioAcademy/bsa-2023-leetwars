using LeetWars.Core.Common.DTO.ChallengeLevel;
using LeetWars.Core.Common.DTO.Tag;
using LeetWars.Core.Common.DTO.User;
using LeetWars.Core.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetWars.Core.Common.DTO.ChallengeRequest
{
    public class ChallengeGenerateRequestDto

    {
        public string Title { get; set; } = string.Empty;

        public ChallengeCategory Category { get; set; }

        public ChallengeLevelDto? Level { get; set; }
        public ICollection<TagDto>? Tags { get; set; }
    }
}
