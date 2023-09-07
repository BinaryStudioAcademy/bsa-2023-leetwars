﻿using LeetWars.Core.Common.DTO.Language;
using LeetWars.Core.Common.DTO.Tag;
using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.Common.DTO.Challenge
{
    public class ChallengePreviewDto : Entity<long>
    {
        public string AuthorName { get; set; } = string.Empty;

        public string LevelName { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;
        
        public string Instructions { get; set; } = string.Empty;
        
        public ChallengeCategory Category { get; set; }

        public ICollection<TagDto>? Tags { get; set; }

        public ICollection<LanguageDto>? Languages { get; set; }
        
        public int Status { get; set; }

        public bool isStarry { get; set; }
    }
}
