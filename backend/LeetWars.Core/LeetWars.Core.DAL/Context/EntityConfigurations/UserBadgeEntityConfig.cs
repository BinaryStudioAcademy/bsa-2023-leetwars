using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeetWars.Core.DAL.Context.EntityConfigurations;

public class UserBadgeEntityConfig : IEntityTypeConfiguration<UserBadge>
{
    public void Configure(EntityTypeBuilder<UserBadge> builder)
    {
        builder.HasOne(x => x.User)
            .WithMany(x => x.UserBadges)
            .HasForeignKey(x => x.UserId);

        builder.HasOne(x => x.Badge)
            .WithMany(x => x.BadgeUsers)
            .HasForeignKey(x => x.BadgeId);
    }
}