using LeetWars.Core.BLL.Exceptions;
using LeetWars.Core.DAL.Enums;
using System.Net;

namespace LeetWars.Core.WebAPI.Extentions
{
    public static class ExceptionFilterExtensions
    {
        public static (HttpStatusCode statusCode, ErrorCode errorCode) ParseException(this Exception exception)
        {
            return exception switch
            {
                NotFoundException _ => (HttpStatusCode.NotFound, ErrorCode.NotFound),
                InvalidUsernameOrPasswordException _ => (HttpStatusCode.Unauthorized, ErrorCode.InvalidUsernameOrPassword),
                _ => (HttpStatusCode.InternalServerError, ErrorCode.General),
            };
        }
    }
}
