using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.Language;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LeetWars.Core.WebAPI.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class LanguageController : ControllerBase
    {
        private readonly ILanguageService _languageService;

        public LanguageController(ILanguageService languageService)
        {
            _languageService = languageService;
        }

        /// <summary>
        /// Get all programming languages
        /// </summary>
        /// <returns>Programming languages</returns>
        [HttpGet]
        public async Task<ActionResult<ICollection<LanguageDto>>> GetAllAsync()
        {
            var languages = await _languageService.GetAllLanguageAsync();

            return Ok(languages);
        }
    }
}
