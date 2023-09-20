using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.ChallengeLevel;
using LeetWars.Core.Common.DTO.ChallengeStar;
using LeetWars.Core.Common.DTO.CodeFight;
using LeetWars.Core.Common.DTO.Filters;
using LeetWars.Core.Common.DTO.SortingModel;
using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.BLL.Interfaces
{
    public interface IChallengeService
    {
        Task<ICollection<ChallengePreviewDto>> GetChallengesAsync(ChallengesFiltersDto filters, PageSettingsDto? page, SortingModel? sortingModel);
        Task<ChallengePreviewDto> GetChallengeSuggestionAsync(SuggestionSettingsDto settings);
        Task<ChallengeFullDto> CreateChallengeAsync(NewChallengeDto challengeDto);
        Task<ChallengeFullDto> EditChallengeAsync(ChallengeEditDto challengeEditDto);
        Task<ChallengeFullDto> GetChallengeFullDtoByIdAsync(long id);
        Task<List<ChallengeLevelDto>> GetChallengesLevelsAsync();
        Task SendCodeFightRequest(CodeFightRequestDto requestDto);
        Task<ChallengePreviewDto> UpdateStarAsync(ChallengeStarDto challengeStarDto);
    }
}
