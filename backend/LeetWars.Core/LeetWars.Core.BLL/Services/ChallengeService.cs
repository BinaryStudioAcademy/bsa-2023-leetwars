using AutoMapper;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.Filters;
using LeetWars.Core.DAL.Context;
using LeetWars.Core.DAL.Enums;
using Microsoft.EntityFrameworkCore;

namespace LeetWars.Core.BLL.Services
{
    public class ChallengeService : BaseService, IChallengeService
    {
        public ChallengeService(LeetWarsCoreContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<ICollection<ChallengePreviewDto>> GetChallengesAsync(ChallengesFiltersDto filters)
        {
            var challenges = _context.Challenges
                    .Include(challenge => challenge.Tags)
                    .Include(challenge => challenge.Author)
                    .Include(challenge => challenge.Versions)
                        .ThenInclude(version => version.Language)
                     .Include(challenge => challenge.Versions)
                        .ThenInclude(version => version.Solutions)
                    .AsQueryable();

            if (!string.IsNullOrEmpty(filters.Title))
            {
                challenges = challenges.Where(p => p.Title.ToLower().Contains(filters.Title.ToLower()));
            }

            if (filters.ChallengeStatus.HasValue)
            {
                challenges = challenges.Where(challenge => 
                    challenge.Versions.Any(version => version.Status == filters.ChallengeStatus));
            }

            if (filters.LanguageId.HasValue)
            {
                challenges = challenges.Where(challenge =>
                    challenge.Versions.Any(version => version.LanguageId == filters.LanguageId));
            }

            if (filters.TagsIds != null)
            {
                challenges = challenges.Where(challenge =>
                    challenge.Tags.Any(tag => filters.TagsIds.Contains(tag.Id)));
            }

            if (filters.Progress.HasValue)
            {
                challenges = filters.Progress switch
                {
                    ChallengesProgress.NotStarted => challenges.Where(challenge => !challenge.Versions.Any(version => version.Solutions.Any())),
                    ChallengesProgress.Started => challenges.Where(challenge => challenge.Versions.Any(version => version.Solutions.Any())),
                    ChallengesProgress.Completed => challenges.Where(challenge => challenge.Versions.All(version => 
                        version.Solutions.All(solution => solution.SubmittedAt.HasValue && solution.SubmittedAt.Value != DateTime.MinValue))),
                    _ => challenges
                };
            }


            var filteredChallenges = await challenges.ToListAsync();
            return _mapper.Map<List<ChallengePreviewDto>>(filteredChallenges);
        }

        public async Task<ChallengeFullDto> GetChallengeByIdAsync(long id)
        {
            var challenges = await _context.Challenges
                .Where(challenge => challenge.Id == id)
                .Include(challenge => challenge.Level)
                .Include(challenge => challenge.Tags)
                .Include(challenge => challenge.Author)
                .Include(challenge => challenge.Versions)
                    .ThenInclude(version => version.Language)
                .Include(challenge => challenge.Versions)
                    .ThenInclude(version => version.Solutions)
                .Include(challenge => challenge.Versions)
                    .ThenInclude(version => version.Tests
                        .Where(test => test.IsPublic))
                .Include(challenge => challenge.Versions)
                    .ThenInclude(version => version.LanguageVersions)
                .Include(challenge => challenge.Versions)
                    .ThenInclude(version => version.Author)
                .FirstOrDefaultAsync();

            return _mapper.Map<ChallengeFullDto>(challenges);
        }
    }
}
