using AutoMapper;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO;
using LeetWars.Core.DAL.Context;
using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace LeetWars.Core.BLL.Services
{
    public class SampleService : BaseService
    {
        public SampleService(LeetWarsCoreContext context, IMapper mapper) : base(context, mapper) { }
    }
}
