using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeetWars.Core.DAL.Context.EntityConfigurations
{
    public class ChallengeLevelConfig : IEntityTypeConfiguration<ChallengeLevel>
    {
        public void Configure(EntityTypeBuilder<ChallengeLevel> builder)
        {
            builder.HasKey(t => t.Id).HasName("PK_ChallengeLevel");
        }
    }
}
