using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.Challenge;
using Microsoft.AspNetCore.Mvc;

namespace LeetWars.Core.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LanguageController : ControllerBase
    {
        public LanguageController(ILanguageService languageService)
        {
            _languageService = languageService;
        }

        [HttpGet]
        public async Task<ActionResult<ChallengePreviewDto>> GetAllAsync()
        {
            var languages = await _languageService.GetAllLanguageAsync();
            return Ok(languages);
        }

        private readonly ILanguageService _languageService;
    }
}
