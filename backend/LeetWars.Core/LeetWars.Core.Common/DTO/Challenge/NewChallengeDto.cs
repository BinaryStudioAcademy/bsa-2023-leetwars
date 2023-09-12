﻿using LeetWars.Core.Common.DTO.ChallengeVersion;
using LeetWars.Core.Common.DTO.Tag;
using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.DAL.Entities
{
    public class NewChallengeDto
    {
        public long? CreatedBy { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
        public long LevelId { get; set; }
        public ChallengeCategory Category { get; set; }
        public ICollection<TagDto>? Tags { get; set; }
        public ICollection<NewChallengeVersionDto>? Versions { get; set; }

    }
}
