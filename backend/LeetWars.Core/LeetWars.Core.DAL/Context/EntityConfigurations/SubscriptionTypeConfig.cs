using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Entities.HelperEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeetWars.Core.DAL.Context.EntityConfigurations
{
    public class SubscriptionTypeConfig : IEntityTypeConfiguration<SubscriptionType>
    {
        public void Configure(EntityTypeBuilder<SubscriptionType> builder)
        {
            builder.Property(e => e.Name)
                .HasMaxLength(EntitySettings.MaxShortNameLength);

            builder.Property(e => e.Description)
                .HasMaxLength(EntitySettings.MaxDescriptionLength);

            builder.Property(e => e.Cost)
                .HasColumnType($"decimal(18,{EntitySettings.DecimalPartLength})");
        }
    }
}
