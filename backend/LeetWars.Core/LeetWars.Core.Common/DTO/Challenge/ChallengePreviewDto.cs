using LeetWars.Core.Common.DTO.Language;
using LeetWars.Core.Common.DTO.Tag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetWars.Core.Common.DTO.Challenge
{
    public class ChallengePreviewDto
    {
        public string AuthorName { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public ICollection<TagDto>? Tags { get; set; }

        public ICollection<LanguageDto>? Languages { get; set; }

        public int Status { get; set; }
    }
}
