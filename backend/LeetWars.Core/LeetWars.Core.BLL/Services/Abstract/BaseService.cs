using AutoMapper;
using LeetWars.Core.DAL.Context;

namespace LeetWars.Core.BLL.Services
{
    public abstract class BaseService
    {
        private protected readonly LeetWarsCoreContext _context;
        private protected readonly IMapper _mapper;

        protected BaseService(LeetWarsCoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
