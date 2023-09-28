using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace LeetWars.Core.DAL.Context.EntityConfigurations
{
    public class UserNotificationsConfig : IEntityTypeConfiguration<UserNotification>
    {
        public void Configure(EntityTypeBuilder<UserNotification> builder)
        {
            builder.HasKey(e => new { e.ReceiverId, e.NotificationId });

            builder.HasOne(e => e.Receiver)
                .WithMany()
                .HasForeignKey(e => e.ReceiverId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Notification)
                .WithMany()
                .HasForeignKey(e => e.NotificationId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
