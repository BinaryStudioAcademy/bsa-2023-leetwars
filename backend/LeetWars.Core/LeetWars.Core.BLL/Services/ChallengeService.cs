using System.Security.Cryptography;
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
        private readonly IUserIdGetter _userIdGetter;

        public ChallengeService(
            LeetWarsCoreContext context,
            IMapper mapper,
            IUserIdGetter userIdGetter
        ) : base(context, mapper)
        {
            _userIdGetter = userIdGetter;
        }

        public async Task<ICollection<ChallengePreviewDto>> GetChallengesAsync(ChallengesFiltersDto filters,
            PageSettingsDto? page)
        {
            var userId = _userIdGetter.CurrentUserId;

            var challenges = _context.Challenges
                .Include(challenge => challenge.Tags)
                .Include(challenge => challenge.Author)
                .Include(challenge => challenge.Level)
                .Include(challenge => challenge.Versions)
                    .ThenInclude(version => version.Language)
                .Include(challenge => challenge.Versions)
                    .ThenInclude(version => version.Solutions)
                        .ThenInclude(solution => solution.User)
                .AsQueryable();

            if (!string.IsNullOrEmpty(filters.Title))
            {
                var title = Uri.UnescapeDataString(filters.Title);
                challenges = challenges.Where(p => p.Title.ToLower().Contains(title.ToLower()));
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

            if (filters.Progress.HasValue)
            {
                challenges = filters.Progress switch
                {
                    ChallengesProgress.NotStarted => challenges.Where(challenge => challenge.Versions.All(version =>
                        version.Solutions.Count == 0 || version.Solutions.All(solution =>
                            solution.User == null || solution.User.Uid != userId))),
                    ChallengesProgress.Started => challenges.Where(challenge => challenge.Versions.Any(version =>
                        version.Solutions.Any(solution =>
                            solution.User != null && solution.User.Uid == userId && solution.SubmittedAt == null))),
                    ChallengesProgress.Completed => challenges.Where(challenge => challenge.Versions.Any(version =>
                        version.Solutions.Any(solution =>
                            solution.User != null && solution.User.Uid == userId && solution.SubmittedAt.HasValue &&
                            solution.SubmittedAt.Value != DateTime.MinValue))),
                    _ => challenges
                };
            }

            if (page is not null && page.PageSize > 0 && page.PageNumber > 0)
            {
                challenges = challenges.Skip(page.PageSize * (page.PageNumber - 1))
                    .Take(page.PageSize);
            }

            var filteredChallenges = await challenges.ToListAsync();

            //filter runs on the client because filters.TagsIds[] didn't pass to the server and SQL query get error
            if (filters.TagsIds != null)
            {
                filteredChallenges = filteredChallenges.Where(challenge =>
                    filters.TagsIds.All(
                        filterTagId => challenge.Tags.Any(tag => tag.Id.Equals(filterTagId))
                    )
                ).ToList();
            }

            return _mapper.Map<List<ChallengePreviewDto>>(filteredChallenges);
        }

        public async Task<ChallengePreviewDto> GetChallengeSuggestionAsync(SuggestionSettingsDto settings)
        {
            var userId = _userIdGetter.CurrentUserId;

            var random = new Random(DateTime.Now.Millisecond);

            var challenges = _context.Challenges
                .Include(challenge => challenge.Tags)
                .Include(challenge => challenge.Author)
                .Include(challenge => challenge.Level)
                .Include(challenge => challenge.Versions)
                    .ThenInclude(version => version.Language)
                .Include(challenge => challenge.Versions)
                    .ThenInclude(version => version.Solutions)
                        .ThenInclude(solution => solution.User)
                .Where(c => c.Versions.Any(v => v.LanguageId == settings.LanguageId))
                .AsQueryable();

            challenges = settings.SuggestionType switch
            {
                SuggestionType.Beta => challenges.Where(challenge =>
                    challenge.Versions.Any(version => version.Status == ChallengeStatus.Beta)),
                SuggestionType.Fundamentals => challenges.Where(challenge =>
                    challenge.Level != null && challenge.Level.Name.ToLower().Contains("easy")),
                SuggestionType.RankUp => challenges.Where(challenge =>
                    challenge.Level != null && challenge.Level.Name.ToLower().Contains("medium")),
                SuggestionType.PracticeAndRepeat => challenges.Where(challenge => challenge.Versions.Any(version =>
                    version.Solutions.Any(solution => solution.User != null && solution.User.Uid == userId))),
                _ => challenges
            };

            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                var data = new byte[4];
                rng.GetBytes(data);
                var randomValue = Math.Abs(BitConverter.ToInt32(data, 0));

                int randomPosition = (randomValue % challenges.Count());
                
                return _mapper.Map<ChallengePreviewDto>(await challenges.Skip(randomPosition)
                    .FirstOrDefaultAsync());
            }
        }
    }
}