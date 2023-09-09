using LeetWars.Core.BLL.Interfaces;
using System.Text;

namespace LeetWars.Core.BLL.Services
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient _httpClient;
        private bool disposedValue;

        public HttpService()
        {
            _httpClient = new HttpClient();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _httpClient.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<HttpResponseMessage> PostRequestAsync(string uri, string content)
        {
            return await _httpClient.PostAsync(uri, new StringContent(content, Encoding.UTF8, "application/json"));
        }
    }
}
