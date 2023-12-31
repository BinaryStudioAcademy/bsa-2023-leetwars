﻿namespace LeetWars.Core.DAL.Entities
{
    public class UserPreferences : Entity<long>
    {
        public long UserId { get; set; }
        public long? LanguageId { get; set; }
        public string? Theme { get; set; } 
        public bool? IsWordWrap { get; set; }
        public int? TabSize { get; set; }
        public int? FontSize { get; set; }
        public bool? IsMinimap { get; set; }
        public User? User { get; set; }
        public Language? Language { get; set; }
    }
}
