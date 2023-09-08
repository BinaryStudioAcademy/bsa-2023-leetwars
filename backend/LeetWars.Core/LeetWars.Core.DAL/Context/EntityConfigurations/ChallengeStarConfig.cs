using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeetWars.Core.DAL.Context.EntityConfigurations
{
    public class ChallengeStarConfig : IEntityTypeConfiguration<ChallengeStar>
    {
        public void Configure(EntityTypeBuilder<ChallengeStar> builder)
        {
            builder.HasOne(cs => cs.Challenge)
                   .WithMany(c => c.Stars)
                   .HasForeignKey(cs => cs.ChallengeId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(cs => cs.Author)
                   .WithMany()
                   .HasForeignKey(cs => cs.AuthorId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
