using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.Notifications;
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
        /// Get all notifications of a current user
        /// </summary>
        /// <returns>Collection of user's notification, read and unseen</returns>
        [HttpGet]
        public async Task<ActionResult<ICollection<NotificationDto>>> GetAllAsync()
        {
            var notifications = await _notificationService.GetNotificationsOfCurrentUserAsync();

            return Ok(notifications);
        }

        /// <summary>
        /// Updates status of notifications to read
        /// </summary>
        /// <param name="ids">Array of ids of users that have read their messages</param>
        /// <returns>Status of the operation</returns>
        [HttpPut]
        public async Task<ActionResult> UpdateStatusToReadAsync([FromBody] long[] ids)
        {
            await _notificationService.UpdateStatusToReadByUserIdsAsync(ids);

            return Ok();
        }
    }
}
