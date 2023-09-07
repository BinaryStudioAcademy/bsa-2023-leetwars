using LeetWars.Core.Common.DTO.ChallengeStar;

namespace LeetWars.Core.BLL.Interfaces
{
    public interface IStarService
    {
        Task<ChallengeStarDto> Update(ChallengeStarDto challengeStarDto);
    }
}
