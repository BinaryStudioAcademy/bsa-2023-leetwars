using LeetWars.Core.BLL.Interfaces;
using System.Text;

namespace LeetWars.Core.BLL.Services
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient _httpClient;

        public HttpService()
        {
            _httpClient = new HttpClient();
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }

        public async Task<HttpResponseMessage> PostRequestAsync(string uri, string content)
        {
            return await _httpClient.PostAsync(uri, new StringContent(content, Encoding.UTF8, "application/json"));
        }
    }
}
