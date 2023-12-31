﻿namespace LeetWars.Core.DAL.Entities
{
    public class Language : Entity<long>
    {
        public string Name { get; set; }
        public ICollection<User> Users { get; } = new List<User>();
        public ICollection<UserPreferences>? UserPreferences { get; }

        public Language(string name)
        {
            Name = name;
        }
    }
}
