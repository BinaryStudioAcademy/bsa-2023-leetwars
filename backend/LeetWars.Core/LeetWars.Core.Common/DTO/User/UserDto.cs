﻿using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.Common.DTO.User
{
    public class UserDto : Entity<long>
    {
        public Country Country { get; set; }
        public int Timezone { get; set; }
        public Sex Sex { get; set; }
        public UserStatus Status { get; set; }
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public long TotalScore { get; set; }
        public DateTime RegisteredAt { get; set; }
        public string OAuthToken { get; set; } = string.Empty;
        public bool IsSubscribed { get; set; }
        public bool IsBanned { get; set; }
    }
}