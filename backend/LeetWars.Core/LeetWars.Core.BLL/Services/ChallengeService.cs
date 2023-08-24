using AutoMapper;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.Fillters;
using LeetWars.Core.Common.DTO.Language;
using LeetWars.Core.DAL.Context;
using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace LeetWars.Core.BLL.Services
{
    public class ChallengeService : BaseService, IChallengeService
    {
        public ChallengeService(LeetWarsCoreContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<ICollection<ChallengePreviewDto>> GetChallengesAsync(ChallengesFilltersDto fillters)
        {
            var challenges = _context.Challenges
                    .Include(challenge => challenge.Tags)
                    .Include(challenge => challenge.Author)
                    .Include(challenge => challenge.Versions)
                        .ThenInclude(version => version.Language)
                     .Include(challenge => challenge.Versions)
                        .ThenInclude(version => version.Solutions)
                    .AsQueryable();

            if (!string.IsNullOrEmpty(fillters.Title))
            {
                challenges = challenges.Where(p => p.Title.ToLower().Contains(fillters.Title.ToLower()));
            }

            if (fillters.ChallengeStatus.HasValue)
            {
                challenges = challenges.Where(challenge =>
                    challenge.Versions.First().Status == fillters.ChallengeStatus);
            }

            if (fillters.LanguageId.HasValue)
            {
                challenges = challenges.Where(challenge =>
                    challenge.Versions.Any(version => version.LanguageId == fillters.LanguageId));
            }

            if (fillters.TagsIds != null)
            {
                challenges = challenges.Where(challenge =>
                    challenge.Tags.Any(tag => fillters.TagsIds.Contains(tag.Id)));
            }

            if (fillters.Progress.HasValue)
            {
                challenges = fillters.Progress switch
                {
                    ChallengesProgress.NotStarted => challenges.Where(challenge => challenge.Versions.All(version =>
                        version.Solutions.Count == 0)),

                    ChallengesProgress.Started => challenges.Where(challenge => challenge.Versions.Any(version =>
                        version.Solutions.Count > 0)),

                    ChallengesProgress.Completed => challenges.Where(challenge => challenge.Versions.All(version =>
                        version.Solutions.All(solution => solution.SubmittedAt != null))),

                    _ => challenges
                };
            }

            var filteredChallenges = await challenges.ToListAsync();
            return _mapper.Map<List<ChallengePreviewDto>>(filteredChallenges);
        }
    }
}
