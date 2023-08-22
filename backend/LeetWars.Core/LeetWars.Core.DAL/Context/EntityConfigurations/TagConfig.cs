using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Entities.HelperEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeetWars.Core.DAL.Context.EntityConfigurations
{
    public class TagConfig : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.Property(e => e.Name)
                .HasMaxLength(EntitySettings.MaxTagNameLength);
        }
    }
}
