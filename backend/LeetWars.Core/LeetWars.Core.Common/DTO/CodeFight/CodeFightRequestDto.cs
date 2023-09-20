﻿using LeetWars.Core.Common.DTO.Filters;
using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.Common.DTO.CodeFight
{
    public class CodeFightRequestDto
    {
        public long SenderId { get; set; }
        public long ReceiverId { get; set; }
        public CodeFightChallengeSettingsDto ChallengeSettings { get; set; } = null!;
    }
}
