using AutoMapper;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.Friendship;
using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.BLL.MappingProfiles.Resolvers
{
    public class FriendshipResolver : IValueResolver<Friendship, FriendshipPreviewDto, long>
    {
        private readonly IUserGetter _userGetter;

        public FriendshipResolver(IUserGetter userGetter)
        {
            _userGetter = userGetter;
        }

        public long Resolve(Friendship source, FriendshipPreviewDto destination, long destMember, ResolutionContext context)
        {
            var currentUserId = _userGetter.CurrentUser?.Id;
            return source.UserFriendships.First(uf => uf.UserId != currentUserId).UserId;
        }
    }
}
