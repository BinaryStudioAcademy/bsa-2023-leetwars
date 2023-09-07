using AutoMapper;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.ChallengeStar;
using LeetWars.Core.DAL.Context;
using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

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

        public async Task Delete(long id)
        {
            var challengeStar = await _context.ChallengeStars.SingleOrDefaultAsync(cs => cs.Id == id);

            if(challengeStar is null)
            {
                throw new ArgumentNullException(nameof(challengeStar));
            }

            _context.ChallengeStars.Remove(challengeStar);

            await _context.SaveChangesAsync();
        }

        public async Task<ChallengeStarDto> Update(ChallengeStarDto challengeStarDto)
        {
            if(challengeStarDto.IsStar)
            {
                await Add(challengeStarDto);
            }
            else
            {
                await Delete(challengeStarDto.Id);
            }

            return challengeStarDto;
        }
    }
}
