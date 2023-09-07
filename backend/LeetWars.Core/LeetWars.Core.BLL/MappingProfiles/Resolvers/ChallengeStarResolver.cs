using AutoMapper;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.BLL.MappingProfiles.Resolvers
{
    public class ChallengeStarResolver : IValueResolver<Challenge, ChallengePreviewDto, bool>
    {
        private readonly IUserIdGetter _userIdGetter;

        public ChallengeStarResolver(IUserIdGetter userIdGetter)
        {
            _userIdGetter = userIdGetter;
        }

        public bool Resolve(Challenge src, ChallengePreviewDto dest, bool destMember, ResolutionContext context)
        {
            return src.Stars.Any(star => star.ChallengeId == src.Id && star.Author is not null ? star.Author.Uid == _userIdGetter.CurrentUserId : false);
        }
    }
}
