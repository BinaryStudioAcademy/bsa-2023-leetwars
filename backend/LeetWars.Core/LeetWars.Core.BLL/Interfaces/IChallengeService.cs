using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.CodeRunRequest;
using LeetWars.Core.Common.DTO.ChallengeStar;
using LeetWars.Core.Common.DTO.Filters;
using LeetWars.Core.Common.DTO.Notifications;
using LeetWars.Core.Common.DTO.SortingModel;
using LeetWars.Core.DAL.Entities;
using LeetWars.Core.Common.DTO.CodeFight;
using LeetWars.Core.Common.DTO.User;
using LeetWars.Core.Common.DTO.ChallengeLevel;

namespace LeetWars.Core.BLL.Interfaces
{
    public interface IChallengeService
    {
        void SendCodeRunRequest(CodeRunRequestDto request);

        Task<ICollection<ChallengePreviewDto>> GetChallengesAsync(ChallengesFiltersDto filters, PageSettingsDto? page, SortingModel? sortingModel);

        Task<ChallengePreviewDto> GetChallengeSuggestionAsync(SuggestionSettingsDto settings);

        Task<ChallengeFullDto> CreateChallengeAsync(NewChallengeDto challengeDto);

        Task<ChallengeFullDto> EditChallengeAsync(ChallengeEditDto challengeEditDto);

        Task DeleteChallengeAsync(long challengeId);

        Task<ChallengeFullDto> GetChallengeFullDtoByIdAsync(long id);

        Task<ChallengePreviewDto> UpdateStarAsync(ChallengeStarDto challengeStarDto);

        Task<List<ChallengeLevelDto>> GetChallengeLevelsAsync();

        Task<BriefChallengeInfoDto> GetBriefChallengeInfoByIdAsync(long challengeId);

        Task<BriefChallengeInfoDto> GetCodeFightChallengeAsync(CodeFightChallengeSettingsDto settings);
    }
}
