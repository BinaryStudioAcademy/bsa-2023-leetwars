using AutoMapper;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.ChallengeStar;
using LeetWars.Core.DAL.Context;
using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.BLL.Services
{
    public class StarService : BaseService, IStarService
    {
        public StarService(LeetWarsCoreContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<ChallengeStarDto> Add(ChallengeStarDto challengeStarDto)
        {
            await _context.ChallengeStars.AddAsync(_mapper.Map<ChallengeStar>(challengeStarDto));

            await _context.SaveChangesAsync();

            return challengeStarDto;
        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<ChallengeStarDto> Update(ChallengeStarDto challengeStarDto)
        {
            throw new NotImplementedException();
        }
    }
}
