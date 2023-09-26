using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Entities.HelperEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeetWars.Core.DAL.Context
{
    public class ChallengeConfig : IEntityTypeConfiguration<Challenge>
    {
        public void Configure(EntityTypeBuilder<Challenge> builder)
        {
            builder.Property(e => e.Title)
                .HasMaxLength(EntitySettings.MaxGeneralNameLength);

            //Connections
            builder.HasMany(e => e.Tags)
                .WithMany(e => e.Challenges)
                .UsingEntity<ChallengeTag>();

            builder.HasOne(e => e.Level)
                .WithMany()
                .HasForeignKey(e => e.LevelId)
                .HasConstraintName("FK_Challenge_ChallengeLevel_LevelId");

            builder.HasMany(e => e.Versions)
                .WithOne()
                .HasForeignKey(e => e.ChallengeId);
        }
    }
}
