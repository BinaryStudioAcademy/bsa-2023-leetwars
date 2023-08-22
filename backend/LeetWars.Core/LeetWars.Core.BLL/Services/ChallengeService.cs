using AutoMapper;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetWars.Core.BLL.Services
{
    public class ChallengeService : BaseService, IChallengeService
    {
        public ChallengeService(LeetWarsCoreContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<ICollection<ChallengePreviewDto>> GetChallengesAsync(ChallengesFilltersDto fillters)
        {
            throw new NotImplementedException();
        }
    }
}
