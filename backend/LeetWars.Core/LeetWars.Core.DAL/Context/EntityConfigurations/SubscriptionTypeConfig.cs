using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeetWars.Core.DAL.Context.EntityConfigurations
{
    public class SubscriptionTypeConfig : IEntityTypeConfiguration<SubscriptionType>
    {
        public void Configure(EntityTypeBuilder<SubscriptionType> builder)
        {
            builder.Property(e => e.Name)
                .HasMaxLength(30);
            builder.Property(e => e.Description)
                .HasMaxLength(100);
            builder.Property(e => e.Cost)
                .HasColumnType("decimal(18,2)");
        }
    }
}
