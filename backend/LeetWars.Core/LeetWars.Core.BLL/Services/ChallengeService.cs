using System.Security.Cryptography;
using AutoMapper;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.Filters;
using LeetWars.Core.DAL.Context;
using LeetWars.Core.DAL.Entities;
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
                challenges = FilterChallengesByProgress(challenges, filters.Progress);
            }

            if (page is not null && page.PageSize > 0 && page.PageNumber > 0)
            {
                challenges = challenges.Skip(page.PageSize * (page.PageNumber - 1))
                    .Take(page.PageSize);
            }

            var filterChallenges = challenges.AsEnumerable();

            //filter runs on the client because filters.TagsIds[] didn't pass to the server and SQL query get error
            if (filters.TagsIds != null)
            {
                filterChallenges = filterChallenges.Where(challenge =>
                    filters.TagsIds.All(
                        filterTagId => challenge.Tags.Any(tag => tag.Id.Equals(filterTagId))
                    )
                );
            }

            return _mapper.Map<List<ChallengePreviewDto>>(filterChallenges.ToList());
        }

        public async Task<ChallengePreviewDto> GetChallengeSuggestionAsync(SuggestionSettingsDto settings)
        {
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

            challenges = FilterChallengesBySuggestionType(challenges, settings.SuggestionType);

            var randomPosition = GetRandomInt(challenges.Count());
            
            return _mapper.Map<ChallengePreviewDto>(await challenges.Skip(randomPosition).FirstOrDefaultAsync());
        }

        private IQueryable<Challenge> FilterChallengesByProgress(IQueryable<Challenge> challenges, ChallengesProgress? progress)
        {
            var userId = _userIdGetter.CurrentUserId;

            return progress switch
            {
                ChallengesProgress.NotStarted => challenges.Where(challenge => challenge.Versions.All(version =>
                    !version.Solutions.Any() || version.Solutions.All(solution =>
                        solution.User == null || solution.User.Uid != userId))),
                ChallengesProgress.Started => challenges.Where(challenge => challenge.Versions.Any(version =>
                    version.Solutions.Any(solution =>
                        solution.User != null && solution.User.Uid == userId && !solution.SubmittedAt.HasValue))),
                ChallengesProgress.Completed => challenges.Where(challenge => challenge.Versions.Any(version =>
                    version.Solutions.Any(solution =>
                        solution.User != null && solution.User.Uid == userId && solution.SubmittedAt.HasValue))),
                _ => challenges
            };
        }
        private IQueryable<Challenge> FilterChallengesBySuggestionType(IQueryable<Challenge> challenges, SuggestionType suggestionType)
        {
            var userId = _userIdGetter.CurrentUserId;

            return suggestionType switch
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
        }

        private static int GetRandomInt(int maxValue)
        {
            using (var generator = RandomNumberGenerator.Create())
            {
                var data = new byte[4];
                generator.GetBytes(data);
                var randomValue = Math.Abs(BitConverter.ToInt32(data, 0));

                return randomValue % maxValue;
            }
        }

        public async Task<ChallengeFullDto> GetChallengeByIdAsync(long id)
        {
            var challenges = await _context.Challenges
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
                .FirstOrDefaultAsync(challenge => challenge.Id == id);

            return _mapper.Map<ChallengeFullDto>(challenges);
        }
    }
}