﻿using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.Common.DTO.LanguageVersion
{
    public class LanguageVersionDto : Entity<long>
    {
        public long LanguageId { get; set; }
        public string Version { get; set; } = string.Empty;
    }
}
