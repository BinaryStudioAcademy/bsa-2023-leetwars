using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Entities.HelperEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeetWars.Core.DAL.Context.EntityConfigurations
{
    public class SubscriptionConfig : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder.Property(e => e.Cost)
                .HasColumnType($"decimal(18,{EntitySettings.DecimalPartLength})");

            //Connections
            builder.HasOne(e => e.SubscriptionType)
                .WithMany()
                .HasForeignKey(e => e.TypeId);
        }
    }
}
