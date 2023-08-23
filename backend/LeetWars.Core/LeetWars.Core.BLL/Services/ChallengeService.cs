using AutoMapper;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.Language;
using LeetWars.Core.DAL.Context;
using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Enums;
using Microsoft.EntityFrameworkCore;
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

        public async Task<ICollection<ChallengePreviewDto>> GetChallengesAsync(ChallengesFilltersDto filters)
        {
            var challenges = await _context.Challenges
                .Include(challenge => challenge.Tags)
                .Include(challenge => challenge.Author)
                .Include(challenge => challenge.Versions)
                    .ThenInclude(version => version.Language)
                .ToListAsync();

            if (!string.IsNullOrEmpty(filters.Title))
            {
                challenges = challenges.Where(challenge =>
                    challenge.Title.Contains(filters.Title, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            if (filters.ChallengeStatus.HasValue)
            {
                challenges = challenges.Where(challenge =>
                    challenge.Versions.Any(version => version.Status == (ChallengeStatus)filters.ChallengeStatus.Value))
                    .ToList();
            }

            if (filters.LanguageId.HasValue)
            {
                challenges = challenges.Where(challenge =>
                    challenge.Versions.Any(version => version.LanguageId == filters.LanguageId))
                    .ToList();
            }

            if (filters.TagsIds.Any())
            {
                challenges = challenges.Where(challenge =>
                    challenge.Tags.Any(tag => filters.TagsIds.Contains(tag.Id))).ToList();
            }

            var challengeDtoList = challenges.Select(challenge => new ChallengePreviewDto
            {
                AuthorName = challenge.Author.UserName,
                Title = challenge.Title,
                Tags = challenge.Tags.Select(tag => new Common.DTO.Tag.TagDto
                {
                    Id = tag.Id,
                    Name = tag.Name,
                }).ToList(),
                Languages = challenge.Versions.Select(version => new LanguageDto
                {
                    Id = version.Language.Id,
                    Name = version.Language.Name
                }).ToList()
            }).ToList();

            return challengeDtoList;
        }
    }
}
