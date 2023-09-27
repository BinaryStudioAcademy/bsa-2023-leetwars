using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeetWars.Core.DAL.Context.EntityConfigurations
{
    public class CodeFightConfig : IEntityTypeConfiguration<CodeFight>
    {
        public void Configure(EntityTypeBuilder<CodeFight> builder)
        {
            builder.HasOne(codeFight => codeFight.Sender)
                   .WithOne()
                   .HasForeignKey<CodeFight>(codeFight => codeFight.SenderId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(codeFight => codeFight.Receiver)
                   .WithOne()
                   .HasForeignKey<CodeFight>(codeFight => codeFight.ReceiverId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
