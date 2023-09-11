using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Entities.HelperEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeetWars.Core.DAL.Context.EntityConfigurations
{
    public class LanguageConfig : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.Property(e => e.Name)
                .HasMaxLength(EntitySettings.MaxShortNameLength);

            builder.HasKey(l => l.Id).HasName("PK_Language");
            
            //Connections
            builder.HasMany(e => e.LanguageVersions)
                .WithOne()
                .HasForeignKey(e => e.LanguageId)
                .HasConstraintName("FK_LanguageVersion_Language_LanguageId");
        }
    }
}
