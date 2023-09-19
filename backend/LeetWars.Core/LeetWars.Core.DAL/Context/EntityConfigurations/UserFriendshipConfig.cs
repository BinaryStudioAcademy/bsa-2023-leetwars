using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeetWars.Core.DAL.Context.EntityConfigurations
{
    public class UserFriendshipConfig : IEntityTypeConfiguration<UserFriendship>
    {
        public void Configure(EntityTypeBuilder<UserFriendship> builder)
        {
            builder.HasKey(uf => new { uf.FriendshipId, uf.UserId });
        }
    }
}
