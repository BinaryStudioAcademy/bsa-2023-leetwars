﻿namespace LeetWars.Core.DAL.Entities
{
    public abstract class AuditEntity<T> : Entity<T> where T : struct
    {
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public T? CreatedBy { get; set; }
    }
}