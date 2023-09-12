using AutoMapper;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.ChallengeLevel;
using LeetWars.Core.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace LeetWars.Core.BLL.Services;

public class ChallengeLevelService : BaseService, IChallengeLevelService
{
    public ChallengeLevelService(LeetWarsCoreContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<ChallengeLevelDto>> GetAllLevelsAsync()
    {
        var levels = await _context.ChallengeLevels.ToListAsync();

        return _mapper.Map<ICollection<ChallengeLevelDto>>(levels);
    }
}
