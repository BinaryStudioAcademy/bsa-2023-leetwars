using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeetWars.Core.DAL.Context.EntityConfigurations
{
    public class LanguageConfig : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.Property(e => e.Name)
                .HasMaxLength(15);
            //Connections
            builder.HasMany(e => e.LanguageVersions)
                .WithOne()
                .HasForeignKey(e => e.LanguageId);
        }
    }
}
