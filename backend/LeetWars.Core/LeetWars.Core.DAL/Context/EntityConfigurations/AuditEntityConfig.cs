using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeetWars.Core.DAL.Context.EntityConfigurations
{
    public class AuditEntityConfig<T> : IEntityTypeConfiguration<AuditEntity<T>> where T : struct
    {
        public void Configure(EntityTypeBuilder<AuditEntity<T>> builder)
        {
            builder.Property(e => e.CreatedBy)
                .IsRequired();
        }
    }
}
