using LeetWars.Core.DAL.Entities.HelperEntities;
using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LeetWars.Core.DAL.Context.EntityConfigurations
{
    internal class UserPreferencesConfig : IEntityTypeConfiguration<UserPreferences>
    {
        public void Configure(EntityTypeBuilder<UserPreferences> builder)
        {
            builder.Property(e => e.Id)
            .ValueGeneratedOnAdd();
        }
    }
}