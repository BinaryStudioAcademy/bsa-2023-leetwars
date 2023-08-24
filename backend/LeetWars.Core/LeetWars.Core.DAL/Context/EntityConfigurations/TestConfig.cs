using LeetWars.Core.DAL.Entities.HelperEntities;
using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LeetWars.Core.DAL.Context.EntityConfigurations
{
    public class TestConfig : IEntityTypeConfiguration<Test>
    {
        public void Configure(EntityTypeBuilder<Test> builder)
        {
            //Connections
            builder.HasOne(e => e.Author)
                .WithMany()
                .HasForeignKey(e => e.CreatedBy);
        }
    }
}
