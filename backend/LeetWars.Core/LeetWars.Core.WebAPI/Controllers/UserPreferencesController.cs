using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.UserPrefferences;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LeetWars.Core.WebAPI.Controllers
{
    [ApiController]
    [Route("preferences")]
    public class UserPreferencesController : ControllerBase
    {
        private readonly IPreferencesService _preferencesService;
        public UserPreferencesController(IPreferencesService preferencesService)
        {
            _preferencesService = preferencesService;
        }

        [HttpGet]
        public async Task<ActionResult<UserPreferencesDto>> GetUserPreferences()
        {
            var createdUser = await _preferencesService.GetUserPreferences();
            return Ok(createdUser);
        }


        [HttpPost]
        public async Task<ActionResult<UserPreferencesDto>> SetUserPreferences(NewUserPreferencesDto newPreferences)
        {
            var createdUser = await _preferencesService.SetUserPreferences(newPreferences);
            return Ok(createdUser);
        }
    }
}
