using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace LeetWars.Core.DAL.Context.EntityConfigurations
{
    public class ChallengeLevelConfig : IEntityTypeConfiguration<ChallengeLevel>
    {
        public void Configure(EntityTypeBuilder<ChallengeLevel> builder)
        {
            builder.Property(e => e.Name)
                .HasMaxLength(50);
        }
    }
}
