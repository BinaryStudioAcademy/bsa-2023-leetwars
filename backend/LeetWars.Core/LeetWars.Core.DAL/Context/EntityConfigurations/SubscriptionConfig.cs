using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeetWars.Core.DAL.Context.EntityConfigurations
{
    public class SubscriptionConfig : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder.Property(e => e.Cost)
                .HasColumnType("decimal(18,2)");
            builder.HasOne(e => e.SubscriptionType)
                .WithMany()
                .HasForeignKey(e => e.TypeId);
        }
    }
}
