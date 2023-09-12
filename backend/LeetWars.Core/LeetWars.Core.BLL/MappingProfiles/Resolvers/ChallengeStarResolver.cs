using AutoMapper;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.BLL.MappingProfiles.Resolvers
{
    public class ChallengeStarResolver : IValueResolver<Challenge, ChallengePreviewDto, bool>
    {
        private readonly IUserGetter _userGetter;

        public ChallengeStarResolver(IUserGetter userGetter)
        {
            _userGetter = userGetter;
        }

        public bool Resolve(Challenge src, ChallengePreviewDto dest, bool destMember, ResolutionContext context)
        {
            return src.Stars.Any(star => star.ChallengeId == src.Id && star.Author is not null ? star.Author == _userGetter.CurrentUser : default);
        }
    }
}
