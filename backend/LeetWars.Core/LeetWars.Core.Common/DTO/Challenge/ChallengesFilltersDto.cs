using LeetWars.Core.Common.DTO.Tag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetWars.Core.Common.DTO.Challenge
{
    public class ChallengesFilltersDto
    {
        public string? Title { get; set; }
        public int? ChallengeStatus { get; set; }
        public int? LanguageId { get; set; }
        public ICollection<int>? TagsIds { get; set; }

        //TODO: ByProgress
    }
}