using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Entities.HelperEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeetWars.Core.DAL.Context.EntityConfigurations
{
    internal class ChallengeVersionConfig : IEntityTypeConfiguration<ChallengeVersion>
    {
        public void Configure(EntityTypeBuilder<ChallengeVersion> builder)
        {
            //Connections
            builder.HasOne(e => e.Language)
                .WithMany()
                .HasForeignKey(e => e.LanguageId)
                .HasConstraintName("FK_ChallengeVersion_Language_LanguageId");

            builder.HasMany(e => e.LanguageVersions)
                .WithMany(e => e.ChallengeVersions)
                .UsingEntity<ChallengeVersionLanguageVersion>(
                    j => j.HasOne<LanguageVersion>()
                        .WithMany()
                        .HasForeignKey(e => e.LanguageVersionId)
                        .HasConstraintName("FK_ChallengeVersionLanguageVersion_LanguageVersion_LanguageVersionId")
                        .OnDelete(DeleteBehavior.Restrict),
                    j => j.HasOne<ChallengeVersion>()
                        .WithMany()
                        .HasForeignKey(e => e.ChallengeVersionId)
                        .OnDelete(DeleteBehavior.Restrict))
                    .HasKey(j => new { j.ChallengeVersionId, j.LanguageVersionId })
                    .HasName("PK_ChallengesVersionLanguagesVersion");

            builder.HasMany(e => e.Solutions)
                .WithOne()
                .HasForeignKey(e => e.ChallengeVersionId);
        }
    }
}
