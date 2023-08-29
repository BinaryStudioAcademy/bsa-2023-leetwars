using AutoMapper;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.Tag;
using LeetWars.Core.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace LeetWars.Core.BLL.Services
{
    public class TagService : BaseService, ITagService
    {
        public TagService(LeetWarsCoreContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<ICollection<TagDto>> GetAllTagsAsync()
        {
            var tags = await _context.Tags.ToListAsync();

            return _mapper.Map<ICollection<TagDto>>(tags);
        }
    }
}
