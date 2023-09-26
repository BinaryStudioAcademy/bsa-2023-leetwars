using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.Tag;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LeetWars.Core.WebAPI.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class TagsController : ControllerBase
    {
        private readonly ITagService _tagService;

        public TagsController(ITagService tagService)
        {
            _tagService = tagService;
        }

        /// <summary>
        /// Get all challenge tags
        /// </summary>
        /// <returns>Collection of challenge tags</returns>
        [HttpGet]
        public async Task<ActionResult<ICollection<TagDto>>> GetAllAsync()
        {
            var tags = await _tagService.GetAllTagsAsync();

            return Ok(tags);
        }
    }
}
