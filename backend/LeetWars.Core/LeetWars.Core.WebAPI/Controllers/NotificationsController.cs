using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.Tag;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LeetWars.Core.WebAPI.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class NotificationsController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationsController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        /// <summary>
        /// Get all notifications of a single user by id
        /// </summary>
        /// <returns>Collection of user's notification, read and unseen</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<ICollection<TagDto>>> GetAllAsync([FromRoute] long id)
        {
            var notifications = await _notificationService.GetNotificationsByUserIdAsync(id);

            return Ok(notifications);
        }

        /// <summary>
        /// Updates status of notifications to read
        /// </summary>
        /// <returns>Status of the operation</returns>
        [HttpPut]
        public async Task<ActionResult> UpdateStatusToRead([FromBody] long[] ids)
        {
            await _notificationService.UpdateStatusToRead(ids);

            return Ok();
        }
    }
}
