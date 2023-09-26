using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.CodeRunRequest;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.Filters;
using LeetWars.Core.Common.DTO.ChallengeStar;
using LeetWars.Core.Common.DTO.CodeFight;
using LeetWars.Core.Common.DTO.Notifications;
using LeetWars.Core.Common.DTO.SortingModel;
using LeetWars.Core.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using LeetWars.Core.Common.DTO.User;

namespace LeetWars.Core.WebAPI.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class CodeFightController : ControllerBase
    {
        private readonly ICodeFightService _codeFightService;

        public CodeFightController(ICodeFightService codeFightService)
        {
            _codeFightService = codeFightService;
        }

        [HttpPost("codeFightRequestStarted")]
        public async Task<ActionResult<List<UserDto>>> SendCodeFightRequestStartedAsync([FromBody] CodeFightRequestDto requestDto)
        {
            var users = await _codeFightService.SendCodeFightRequestStartedAsync(requestDto);

            return Ok(users);
        }


        [HttpPost("codeFightRequestEnded")]
        public async Task<ActionResult<List<UserDto>>> SendcodeFightRequestEndedAsync([FromBody] NewNotificationDto notification)
        {
            var users = await _codeFightService.SendcodeFightRequestEndedAsync(notification);

            return Ok(users);
        }

        [HttpPost("codefightstart")]
        public async Task<ActionResult<List<UserDto>>> SendCodeFightStartAsync([FromBody] NewNotificationDto notificationDto)
        {
            var users = await _codeFightService.SendCodeFightStartAsync(notificationDto);

            return Ok(users);
        }

        [HttpPost("codefightend")]
        public async Task<ActionResult<List<UserDto>>> SendCodeFightEndAsync([FromBody] CodeFightEndDto codeFightEndDto)
        {
            var users = await _codeFightService.SendCodeFightEndAsync(codeFightEndDto);

            return Ok(users);
        }
    }
}
