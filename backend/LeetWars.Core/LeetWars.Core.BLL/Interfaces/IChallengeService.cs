using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.Filters;
using LeetWars.Core.Common.Models;

namespace LeetWars.Core.BLL.Interfaces
{
    public interface IChallengeService
    {
        Task<ICollection<ChallengePreviewDto>> GetChallengesAsync(ChallengesFiltersDto filters);

        Task<ChallengeFullDto> GetChallengeByIdAsync(long id);

        void SendCodeRunRequest(CodeRunRequest request);
    }
}
