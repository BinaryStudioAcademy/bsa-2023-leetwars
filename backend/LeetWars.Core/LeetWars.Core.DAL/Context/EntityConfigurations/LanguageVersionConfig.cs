using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Entities.HelperEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeetWars.Core.DAL.Context.EntityConfigurations
{
    public class LanguageVersionConfig : IEntityTypeConfiguration<LanguageVersion>
    {
        public void Configure(EntityTypeBuilder<LanguageVersion> builder)
        {
            builder.Property(e => e.Version)
                .HasMaxLength(EntitySettings.MaxShortNameLength);

            builder.HasKey(l => l.Id).HasName("PK_LanguageVersion");
        }
    }
}
