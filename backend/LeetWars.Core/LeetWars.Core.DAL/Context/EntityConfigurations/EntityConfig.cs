using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LeetWars.Core.DAL.Context.EntityConfigurations
{
    public class EntityConfig<T> : IEntityTypeConfiguration<Entity<T>> where T : struct
    {
        public void Configure(EntityTypeBuilder<Entity<T>> builder)
        {
            builder.Property(e => e.Id)
             .ValueGeneratedOnAdd();
        }
    }
}
