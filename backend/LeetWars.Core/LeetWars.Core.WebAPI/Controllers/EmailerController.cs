using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.Mail;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace LeetWars.Core.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmailerController : ControllerBase
    {
        private readonly IHttpService _httpService;
        private readonly IConfiguration _configuration;

        public EmailerController(IHttpService httpService, IConfiguration configuration)
        {
            _httpService = httpService;
            _configuration = configuration;
        }

        [HttpPost("sendEmail")]
        public async Task<ActionResult<MailDto>> SendEmail(MailDto mailDto)
        {
            var emailApiUri = _configuration["EmailApiURI"];
            var objectToSend = JsonConvert.SerializeObject(mailDto);
            var request = await _httpService.PostRequestAsync(emailApiUri, objectToSend);
            return StatusCode((int)request.StatusCode, request);
        }
    }
}
