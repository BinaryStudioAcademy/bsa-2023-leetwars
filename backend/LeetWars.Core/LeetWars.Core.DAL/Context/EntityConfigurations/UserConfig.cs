using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Entities.HelperEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeetWars.Core.DAL.Context.EntityConfigurations
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(e => e.FirstName)
                .HasMaxLength(EntitySettings.MaxGeneralNameLength);

            builder.Property(e => e.LastName)
                .HasMaxLength(EntitySettings.MaxGeneralNameLength);

            builder.Property(e => e.UserName)
                .HasMaxLength(EntitySettings.MaxUserNameLength);

            builder.Property(e => e.Email)
                .HasMaxLength(EntitySettings.MaxEmailLength);

            builder.Property(e => e.ImagePath)
                .HasMaxLength(EntitySettings.MaxPathLength);

            //Connections
            builder.HasIndex(e => e.UserName)
                .IsUnique();

            builder.HasIndex(e => e.Email)
                .IsUnique();

            builder.HasMany(e => e.PreferredLanguages)
                .WithMany(l => l.Users)
                .UsingEntity<UserPreferredLanguage>();

            builder.HasMany(e => e.LanguagesWithLevels)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId);

            builder.HasMany(e => e.Subscriptions)
                .WithOne()
                .HasForeignKey(e => e.UserId);

            builder.HasMany(e => e.Challenges)
                .WithOne(e => e.Author)
                .HasForeignKey(e => e.CreatedBy);

            builder.HasMany(e => e.Solutions)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(e => e.ChallengeVersions)
                .WithOne(e => e.Author)
                .HasForeignKey(e => e.CreatedBy);
        }
    }
}
