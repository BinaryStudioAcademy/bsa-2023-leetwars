using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Entities.HelperEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace LeetWars.Core.DAL.Context.EntityConfigurations
{
    internal class ChallengeVersionConfig : IEntityTypeConfiguration<ChallengeVersion>
    {
        public void Configure(EntityTypeBuilder<ChallengeVersion> builder)
        {
            builder.HasOne(e => e.Language)
                .WithMany()
                .HasForeignKey(e => e.LanguageId);
            builder.HasMany(e => e.LanguageVersions)
                .WithMany(e => e.ChallengeVersions)
                .UsingEntity<ChallengeVersionLanguageVersion>(
                    j => j.HasOne<LanguageVersion>().WithMany().HasForeignKey(e => e.LanguageVersionId).OnDelete(DeleteBehavior.Restrict),
                    j => j.HasOne<ChallengeVersion>().WithMany().HasForeignKey(e => e.ChallengeVersionId).OnDelete(DeleteBehavior.Restrict))
                    .HasKey(j => new { j.ChallengeVersionId, j.LanguageVersionId });
            builder.HasMany(e => e.Solutions)
                .WithOne()
                .HasForeignKey(e => e.ChallengeVersionId);
            builder.HasMany(e => e.Tests)
                .WithOne()
                .HasForeignKey(e => e.ChallengeVersionId);
        }
    }
}
