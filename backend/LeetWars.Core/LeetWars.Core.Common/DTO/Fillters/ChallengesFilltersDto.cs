using LeetWars.Core.Common.DTO.Tag;
using LeetWars.Core.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetWars.Core.Common.DTO.Fillters
{
    public class ChallengesFilltersDto
    {
        public string? Title { get; set; }
        public ChallengeStatus? ChallengeStatus { get; set; }
        public int? LanguageId { get; set; }
        public ICollection<int>? TagsIds { get; set; }
        public ChallengesProgress? Progress { get; set; }
    }
}