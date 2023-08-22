using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace LeetWars.Core.DAL.Context.EntityConfigurations
{
    public class LanguageVersionConfig : IEntityTypeConfiguration<LanguageVersion>
    {
        public void Configure(EntityTypeBuilder<LanguageVersion> builder)
        {
            builder.Property(e => e.Version)
                .HasMaxLength(15);
        }
    }
}
