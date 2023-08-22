using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Entities.HelperEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

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
            builder.HasMany(e => e.PreferredLanguages)
                .WithMany(l => l.Users)
                .UsingEntity("PreferredLanguages");
            builder.HasMany(e => e.LanguagesWithLevels)
                .WithOne()
                .HasForeignKey(e => e.UserId);
            builder.HasMany(e => e.Subscriptions)
                .WithOne()
                .HasForeignKey(e => e.UserId);
            builder.HasMany(e => e.Challenges)
                .WithOne(e => e.Author)
                .HasForeignKey(e => e.AuthorId);
            builder.HasMany(e => e.Solutions)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
