﻿namespace LeetWars.Core.DAL.Entities
{
    public class ChallengeLevel : Entity<int>
    {
        public string Name { get; set; }
        public int Reward { get; set; }

        public ChallengeLevel(string name)
        {
            Name = name;
        }
    }
}