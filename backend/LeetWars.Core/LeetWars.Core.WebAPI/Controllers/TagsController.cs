using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.Tag;
using Microsoft.AspNetCore.Mvc;

namespace LeetWars.Core.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TagsController : ControllerBase
    {
        public TagsController(ITagService tagService)
        {
            _tagService = tagService;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<TagDto>>> GetAllAsync()
        {
            var tags = await _tagService.GetAllTagsAsync();
            return Ok(tags);
        }

        private readonly ITagService _tagService;
    }
}
