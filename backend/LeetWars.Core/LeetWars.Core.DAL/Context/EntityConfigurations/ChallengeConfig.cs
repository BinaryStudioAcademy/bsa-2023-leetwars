using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace LeetWars.Core.DAL.Context
{
    public class ChallengeConfig : IEntityTypeConfiguration<Challenge>
    {
        public void Configure(EntityTypeBuilder<Challenge> builder)
        {
            builder.Property(e => e.Title)
                .HasMaxLength(50);
            //Connections
            builder.HasMany(e => e.Tags)
                .WithMany(e => e.Challenges);
            builder.HasOne(e => e.Level)
                .WithMany()
                .HasForeignKey(e => e.LevelId);
            builder.HasMany(e => e.Versions)
                .WithOne()
                .HasForeignKey(e => e.ChallengeId);
        }
    }
}
