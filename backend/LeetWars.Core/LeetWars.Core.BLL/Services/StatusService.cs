using AutoMapper;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetWars.Core.BLL.Services
{
    public class StatusService : BaseService, IStatusService
    {
        public StatusService(LeetWarsCoreContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public Task<ICollection<int>> GetAllStatusesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
