using AutoMapper;
using LeetWars.Core.BLL.Exceptions;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.ChallengeStar;
using LeetWars.Core.Common.DTO.ChallengeVersion;
using LeetWars.Core.Common.DTO.CodeRunRequest;
using LeetWars.Core.Common.DTO.Filters;
using LeetWars.Core.Common.DTO.Notifications;
using LeetWars.Core.Common.DTO.SortingModel;
using LeetWars.Core.Common.DTO.Tag;
using LeetWars.Core.DAL.Context;
using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Enums;
using LeetWars.Core.DAL.Extensions;
using Microsoft.EntityFrameworkCore;
using LeetWars.Core.Common.DTO.CodeFight;
using System.Linq.Expressions;
using System.Security.Cryptography;
using LeetWars.Core.Common.DTO.ChallengeLevel;

namespace LeetWars.Core.BLL.Services
{
    public class ChallengeService : BaseService, IChallengeService
    {
        private readonly INotificationSenderService _notificationSenderService;
        private readonly IBuilderSenderService _builderSenderService;
        private readonly IUserGetter _userGetter;
        private readonly IUserService _userService;

        public ChallengeService(
            INotificationSenderService notificationSenderService,
            IBuilderSenderService builderSenderService,
            LeetWarsCoreContext context,
            IMapper mapper,
            IUserGetter userGetter,
            IUserService userService
        ) : base(context, mapper)
        {
            _userService = userService;
            _notificationSenderService = notificationSenderService;
            _builderSenderService = builderSenderService;
            _userGetter = userGetter;
        }

        public async Task<ICollection<ChallengePreviewDto>> GetChallengesAsync(ChallengesFiltersDto filters,
                    PageSettingsDto? page, SortingModel? sortingModel)
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
                .Include(challenge => challenge.Stars)
                    .ThenInclude(star => star.Author)
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

            if (filters.TagsIds is not null)
            {
                var filterTags = _context.Tags.Where(tag =>
                    filters.TagsIds.Contains(tag.Id));

                challenges = challenges.Where(challenge =>
                    filterTags.All(tag => challenge.Tags.Contains(tag)));
            }

            if (filters.SkillLevel is not null)
            {
                challenges = challenges.Where(challenge =>
                challenge.Level != null && challenge.Level.SkillLevel == filters.SkillLevel);
            }

            challenges = SortByProperty(challenges, sortingModel);

            if (page is not null && page.PageSize > 0 && page.PageNumber > 0)
            {
                challenges = challenges.Skip(page.PageSize * (page.PageNumber - 1))
                    .Take(page.PageSize);
            }

            return _mapper.Map<List<ChallengePreviewDto>>(await challenges.ToListAsync());
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
                .AsQueryable();

            if (settings.LanguageId is not null)
            {
                challenges = challenges.Where(c => c.Versions.Any(v => v.LanguageId == settings.LanguageId));
            }

            challenges = await FilterChallengesBySuggestionTypeAsync(challenges, settings);

            var randomPosition = GetRandomInt(challenges.Count());

            return _mapper.Map<ChallengePreviewDto>(await challenges.Skip(randomPosition).FirstOrDefaultAsync());
        }

        public async Task<List<ChallengeLevelDto>> GetChallengeLevelsAsync()
        {
            return _mapper.Map<List<ChallengeLevelDto>>(await _context.ChallengeLevels.ToListAsync());
        }

        public async Task<ChallengeFullDto> GetChallengeFullDtoByIdAsync(long id)
        {
            var challenge = await GetChallengeByIdAsync(id);
            return _mapper.Map<ChallengeFullDto>(challenge);
        }

        public async Task<ChallengePreviewDto> UpdateStarAsync(ChallengeStarDto challengeStarDto)
        {
            Expression<Func<ChallengeStar, bool>> delegateToCheckChallengeStar =
               cs => cs.Author!.Id == challengeStarDto.AuthorId
            && cs.Challenge!.Id == challengeStarDto.Challenge.Id;

            if (!challengeStarDto.IsStar)
            {
                var challengeStar = _mapper.Map<ChallengeStar>(challengeStarDto);

                if (await _context.ChallengeStars.AnyAsync(delegateToCheckChallengeStar))
                {
                    throw new NotFoundException(nameof(ChallengeStar));
                }

                var briefChallenge = await GetBriefChallengeInfoByIdAsync(challengeStarDto.Challenge.Id);

                var newNotification = new NewNotificationDto()
                {
                    ReceiverId = briefChallenge.Author.Id.ToString(),
                    Sender = await _userService.GetBriefUserInfoByIdAsync(challengeStarDto.AuthorId),
                    TypeNotification = TypeNotifications.LikeChallenge,
                    Challenge = briefChallenge
                };

                _notificationSenderService.SendNotificationToRabbitMQ(newNotification);

                await _context.ChallengeStars.AddAsync(challengeStar);
            }
            else
            {
                var challengeStar = await GetChallengeStarAsync(delegateToCheckChallengeStar);

                if (challengeStar is null)
                {
                    throw new NotFoundException(nameof(ChallengeStar));
                }

                _context.ChallengeStars.Remove(challengeStar);
            }

            await _context.SaveChangesAsync();

            var challenge = await GetChallengeByIdAsync(challengeStarDto.Challenge.Id);

            return _mapper.Map<ChallengePreviewDto>(challenge);
        }

        public async Task<ChallengeFullDto> CreateChallengeAsync(NewChallengeDto challengeDto)
        {
            var currentUser = _userGetter.GetCurrentUserOrThrow();
            var challenge = _mapper.Map<Challenge>(challengeDto);

            challenge.CreatedAt = DateTime.UtcNow;
            challenge.CreatedBy = currentUser.Id;
            _context.Challenges.Add(challenge);

            await _context.SaveChangesAsync();

            var challengeTags = _mapper.Map<ICollection<Tag>>(challengeDto.Tags)
                .Select(tag => new ChallengeTag()
                {
                    ChallengeId = challenge.Id,
                    TagId = tag.Id,
                }).ToList();

            _context.ChallengeTags.AddRange(challengeTags);

            var challengeVersions = _mapper.Map<ICollection<ChallengeVersion>>(challengeDto.Versions)
                .Select(version =>
                {
                    version.ChallengeId = challenge.Id;
                    version.CreatedAt = DateTime.UtcNow;
                    version.CreatedBy = currentUser.Id;
                    return version;
                }).ToList();

            _context.ChallengeVersions.AddRange(challengeVersions);

            await _context.SaveChangesAsync();

            var briefChallenge = await GetBriefChallengeInfoByIdAsync(challenge.Id);

            var newNotification = new NewNotificationDto()
            {
                TypeNotification = TypeNotifications.NewChallenge,
                Challenge = briefChallenge,
                Message = "New challenge!",
            };

            _notificationSenderService.SendNotificationToRabbitMQ(newNotification);

            return _mapper.Map<ChallengeFullDto>(challenge);
        }

        public async Task<ChallengeFullDto> EditChallengeAsync(ChallengeEditDto challengeEditDto)
        {
            var currentUser = _userGetter.GetCurrentUserOrThrow();
            if (currentUser.Id != challengeEditDto.CreatedBy)
            {
                throw new AccessDeniedException();
            }

            var challenge = await GetChallengeByIdAsync(challengeEditDto.Id);

            _mapper.Map(challengeEditDto, challenge);
            UpdateChallengeVersions(challenge, challengeEditDto.Versions!, currentUser.Id);
            UpdateChallengeTags(challenge, challengeEditDto.Tags!);

            await _context.SaveChangesAsync();
            return await GetChallengeFullDtoByIdAsync(challenge.Id);
        }

        public async Task DeleteChallengeAsync(long challengeId)
        {
            var challenge = await GetChallengeByIdAsync(challengeId);
            _context.Challenges.Remove(challenge);
            await _context.SaveChangesAsync();
        }

        public async Task SetWeeklyChallengesAsync()
        {
            await ResetLastWeeklyChallengeAsync();

            var levels = Enum.GetValues(typeof(LanguageLevel))
                                            .Cast<LanguageLevel>()
                                            .ToArray();

            foreach(var level in levels) 
            {
                var challengesByLevel = _context.Challenges
                    .Where(x => x.Level != null && x.Level.SkillLevel == level)
                    .AsQueryable();

                var randomPosition = GetRandomInt(await challengesByLevel.CountAsync());
                var weeklyChallenge = await challengesByLevel.Skip(randomPosition).FirstOrDefaultAsync();
                if (weeklyChallenge is not null)
                {
                    weeklyChallenge.IsWeekly = true;
                    _context.Update(weeklyChallenge);
                }
            }
            await _context.SaveChangesAsync();
        }

        public async Task<BriefChallengeInfoDto> GetBriefChallengeInfoByIdAsync(long challengeId)
        {
            var challenge = await _context.Challenges
                .Include(x => x.Author)
                .FirstOrDefaultAsync(challenge => challenge.Id == challengeId);

            return _mapper.Map<BriefChallengeInfoDto>(challenge);
        }

        public async Task<BriefChallengeInfoDto> GetCodeFightChallengeAsync(CodeFightChallengeSettingsDto settings)
        {
            var challenges = _context.Challenges
                .Include(challenge => challenge.Author)
                .Include(challenge => challenge.Versions)
                    .ThenInclude(challengeVersion => challengeVersion.Language)
                .Include(challenge => challenge.Level)
                .Where(challenge => challenge.Level!.SkillLevel == settings.Level &&
                       challenge.Versions.Any(challengeversion => challengeversion.LanguageId == settings.LanguageId));

            if(await challenges.CountAsync() == 0)
            {
                var randomPositionWhenNochallenges = GetRandomInt(await _context.Challenges.CountAsync());

                return _mapper.Map<BriefChallengeInfoDto>(await _context.Challenges.Skip(randomPositionWhenNochallenges).FirstAsync());
            }

            var randomPosition = GetRandomInt(challenges.Count());

            return _mapper.Map<BriefChallengeInfoDto>(await challenges.Skip(randomPosition).FirstAsync());
        }

        public void SendCodeRunRequest(CodeRunRequestDto request)
        {
            _builderSenderService.SendNotificationToRabbitMQ(request);
        }

        private async Task ResetLastWeeklyChallengeAsync()
        {
            var weeklyChallengesToReset = await _context.Challenges
                .Where(x => x.IsWeekly)
                .ToListAsync();

            weeklyChallengesToReset
                .ForEach(challenge => challenge.IsWeekly = false);

            _context.UpdateRange(weeklyChallengesToReset);
            await _context.SaveChangesAsync();
        }

        private void UpdateChallengeVersions(Challenge challenge, ICollection<EditChallengeVersionDto> versions, long currentUserId)
        {
            _context.ChallengeVersions.RemoveRange(challenge.Versions);

            var challengeVersions = _mapper.Map<ICollection<ChallengeVersion>>(versions)
                .Select(version =>
                {
                    version.ChallengeId = challenge.Id;
                    version.CreatedBy = currentUserId;
                    return version;
                }).ToList();

            _context.ChallengeVersions.AddRange(challengeVersions);
        }

        private void UpdateChallengeTags(Challenge challenge, ICollection<TagDto> tags)
        {
            var challengeTags = _context.ChallengeTags.Where(tag => tag.ChallengeId == challenge.Id);
            _context.ChallengeTags.RemoveRange(challengeTags);

            var editedChallengeTags = _mapper.Map<ICollection<Tag>>(tags)
                .Select(tag => new ChallengeTag()
                {
                    ChallengeId = challenge.Id,
                    TagId = tag.Id,
                }).ToList();

            _context.ChallengeTags.AddRange(editedChallengeTags);
        }

        private async Task<Challenge> GetChallengeByIdAsync(long challengeId)
        {
            var challenge = await _context.Challenges
                .Include(challenge => challenge.Level)
                .Include(challenge => challenge.Tags)
                .Include(challenge => challenge.Author)
                .Include(challenge => challenge.Versions)
                    .ThenInclude(version => version.Language!)
                    .ThenInclude(language => language.LanguageVersions)
                .Include(challenge => challenge.Versions)
                    .ThenInclude(version => version.Solutions)
                .Include(challenge => challenge.Versions)
                    .ThenInclude(version => version.LanguageVersions)
                .Include(challenge => challenge.Versions)
                    .ThenInclude(version => version.Author)
                .Include(challenge => challenge.Stars)
                    .ThenInclude(star => star.Author)
                .SingleOrDefaultAsync(challenge => challenge.Id == challengeId);

            return challenge ?? throw new NotFoundException(nameof(Challenge), challengeId);
        }

        private async Task<ChallengeStar?> GetChallengeStarAsync(Expression<Func<ChallengeStar, bool>> condition)
        {
            return await _context.ChallengeStars
                    .Include(challengeStar => challengeStar.Challenge)
                    .Include(challengeStar => challengeStar.Author)
                        .ThenInclude(author => author!.Challenges)
                    .SingleOrDefaultAsync(condition);
        }

        private async Task<LanguageLevel> GetUserLevelAsync(long? languageId)
        {
            var userId = _userGetter.CurrentUserId;
            var userLevel = await _context
                .UserLanguageLevels
                .Include(userLevel => userLevel.User)
                .Where(userLevel => userLevel.User != null && userLevel.User.Uid == userId && userLevel.LanguageId == languageId)
                .FirstOrDefaultAsync();

            return userLevel?.Level ?? LanguageLevel.Easy;
        }

        private IQueryable<Challenge> FilterChallengesByProgress(IQueryable<Challenge> challenges, ChallengesProgress? progress)
        {
            var userId = _userGetter.CurrentUserId;

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

        private async Task<IQueryable<Challenge>> FilterChallengesBySuggestionTypeAsync(IQueryable<Challenge> challenges, SuggestionSettingsDto settings)
        {
            var userId = _userGetter.CurrentUserId;
            var userLevel = await GetUserLevelAsync(settings.LanguageId);
            var userNextLevel = userLevel.GetNextLevel();

            return settings.SuggestionType switch
            {
                SuggestionType.Beta => challenges.Where(challenge =>
                    challenge.Versions.Any(version => version.Status == ChallengeStatus.Beta)),
                SuggestionType.Fundamentals => challenges.Where(challenge =>
                    challenge.Category == ChallengeCategory.Fundamentals),
                SuggestionType.RankUp => challenges.Where(challenge =>
                    challenge.Level != null && challenge.Level.SkillLevel == userNextLevel),
                SuggestionType.PracticeAndRepeat => challenges.Where(challenge => challenge.Versions.Any(version =>
                    version.Solutions.Any(solution => solution.User != null && solution.User.Uid == userId))),
                SuggestionType.Weekly => challenges.Where(challenge =>
                    challenge.Level != null && challenge.Level.SkillLevel == userLevel && challenge.IsWeekly),
                _ => challenges
            };
        }

        private static IOrderedQueryable<Challenge> SortByProperty(IQueryable<Challenge> challenges, SortingModel? sortingModel)
        {
            return sortingModel switch
            {
                { Property: SortingProperty.Title, Order: SortingOrder.Ascending } => challenges.OrderBy(x => x.Title.TrimStart()),
                { Property: SortingProperty.Title, Order: SortingOrder.Descending } => challenges.OrderByDescending(x => x.Title.TrimStart()),
                { Property: SortingProperty.Level, Order: SortingOrder.Ascending } => challenges.OrderBy(x => x.Level),
                { Property: SortingProperty.Level, Order: SortingOrder.Descending } => challenges.OrderByDescending(x => x.Level),
                { Property: SortingProperty.Stars, Order: SortingOrder.Ascending } => challenges.OrderBy(x => x.Stars.Count),
                { Property: SortingProperty.Stars, Order: SortingOrder.Descending } => challenges.OrderByDescending(x => x.Stars.Count),
                { Property: SortingProperty.CreatedAt, Order: SortingOrder.Ascending } => challenges.OrderBy(x => x.CreatedAt),
                { Property: SortingProperty.CreatedAt, Order: SortingOrder.Descending } => challenges.OrderByDescending(x => x.CreatedAt),

                _ => throw new NotFoundException(nameof(SortingProperty))
            };
        }

        private static int GetRandomInt(int maxValue)
        {
            if (maxValue == 0)
            {
                return 0;
            }

            using (var generator = RandomNumberGenerator.Create())
            {
                var data = new byte[4];
                generator.GetBytes(data);
                var randomValue = Math.Abs(BitConverter.ToInt32(data, 0));

                return randomValue % maxValue;
            }
        }
    }
}