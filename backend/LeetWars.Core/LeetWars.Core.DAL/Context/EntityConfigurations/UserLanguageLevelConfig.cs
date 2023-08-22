using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace LeetWars.Core.DAL.Context.EntityConfigurations
{
    public class UserLanguageLevelConfig : IEntityTypeConfiguration<UserLanguageLevel>
    {
        public void Configure(EntityTypeBuilder<UserLanguageLevel> builder)
        {
            //Connections
            builder.HasKey(e => new {e.UserId, e.LanguageId });
            builder.HasOne(e => e.Language)
                .WithMany()
                .HasForeignKey(e => e.LanguageId);
        }
    }
}
