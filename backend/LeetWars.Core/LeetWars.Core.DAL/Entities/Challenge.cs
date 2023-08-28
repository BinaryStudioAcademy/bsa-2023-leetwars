﻿namespace LeetWars.Core.DAL.Entities
{
    public class Challenge : AuditEntity<long>
    {
        public string Title { get; set; }
        public string Instructions { get; set; }
        public int LevelId { get; set; }
        public ChallengeLevel? Level { get; set; }
        public User? Author { get; set; }
        public List<Tag> Tags { get; } = new();
        public ICollection<ChallengeVersion> Versions { get; } = new List<ChallengeVersion>();

        public Challenge(string title, string instructions)
        {
            Title = title;
            Instructions = instructions;
        }
    }
}
