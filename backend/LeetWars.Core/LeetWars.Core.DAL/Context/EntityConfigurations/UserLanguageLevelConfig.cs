using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeetWars.Core.DAL.Context.EntityConfigurations
{
    public class UserLanguageLevelConfig : IEntityTypeConfiguration<UserLanguageLevel>
    {
        public void Configure(EntityTypeBuilder<UserLanguageLevel> builder)
        {
            //Connections
            builder.HasKey(e => new {e.UserId, e.LanguageId }).HasName("PK_UserLanguageLevel");

            builder.HasOne(e => e.Language)
                .WithMany()
                .HasForeignKey(e => e.LanguageId)
                .HasConstraintName("FK_UserLanguageLevel_Languages_LanguageId");
        }
    }
}
