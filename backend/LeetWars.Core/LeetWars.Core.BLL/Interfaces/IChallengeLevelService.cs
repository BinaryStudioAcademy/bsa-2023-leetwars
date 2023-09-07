using LeetWars.Core.Common.DTO.ChallengeLevel;

namespace LeetWars.Core.BLL.Interfaces;

public interface IChallengeLevelService
{
    Task<ICollection<ChallengeLevelDto>> GetAllLevelsAsync();
}