﻿namespace LeetWars.Core.Common.DTO.Filters
{
    public class LeaderBoardPageSettingsDto : PageSettingsDto
    {
        public bool HasFriends { get; set; }

        public string? UserName { get; set; }
    }
}
