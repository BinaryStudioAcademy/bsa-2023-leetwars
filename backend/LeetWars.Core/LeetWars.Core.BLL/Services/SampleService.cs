using AutoMapper;
using LeetWars.Core.DAL.Context;

namespace LeetWars.Core.BLL.Services
{
    public class SampleService : BaseService
    {
        public SampleService(LeetWarsCoreContext context, IMapper mapper) : base(context, mapper) { }
    }
}
