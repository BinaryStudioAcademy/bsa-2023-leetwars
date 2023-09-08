namespace LeetWars.Core.BLL.Interfaces
{
    public interface IHttpService : IDisposable
    {
        public Task<HttpResponseMessage> PostRequestAsync(string uri, string content);
    }
}
