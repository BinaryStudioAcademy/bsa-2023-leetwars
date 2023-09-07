using LeetWars.Core.Common.DTO.ChallengeStar;

namespace LeetWars.Core.BLL.Interfaces
{
    public interface IStarService
    {
        Task<ChallengeStarDto> Add(ChallengeStarDto challengeStarDto);
        Task<ChallengeStarDto> Update(ChallengeStarDto challengeStarDto);
        Task Delete(long id);
    }
}
