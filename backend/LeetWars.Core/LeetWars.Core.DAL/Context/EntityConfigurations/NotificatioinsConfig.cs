using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LeetWars.Core.DAL.Context.EntityConfigurations
{
    public class NotificationsConfig : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            //Connections
            builder.HasOne(e => e.Sender)
                .WithMany()
                .HasForeignKey(e => e.SenderId);

            builder.HasOne(e => e.Challenge)
                .WithMany()
                .HasForeignKey(e => e.ChallengeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.Friendship)
                .WithMany()
                .HasForeignKey(e => e.FriendshipId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
