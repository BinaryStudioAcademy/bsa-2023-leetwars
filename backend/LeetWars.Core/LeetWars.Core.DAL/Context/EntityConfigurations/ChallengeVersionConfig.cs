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

            builder.HasMany(e => e.Solutions)
                .WithOne()
                .HasForeignKey(e => e.ChallengeVersionId);
        }
    }
}
