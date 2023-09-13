using LeetWars.Core.Common.DTO.CodeRunRequest;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.ChallengeStar;
using LeetWars.Core.Common.DTO.Filters;
using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.BLL.Interfaces
{
    public interface IChallengeService
    {
        void SendCodeRunRequest(CodeRunRequestDto request);
        Task<ICollection<ChallengePreviewDto>> GetChallengesAsync(ChallengesFiltersDto filters, PageSettingsDto? page);
        Task<ChallengePreviewDto> GetChallengeSuggestionAsync(SuggestionSettingsDto settings);
        Task<ChallengeFullDto> CreateChallengeAsync(NewChallengeDto challengeDto);
        Task<ChallengeFullDto> GetChallengeFullDtoByIdAsync(long id);
        Task<ChallengePreviewDto> UpdateAsync(ChallengeStarDto challengeStarDto);
    }
}
