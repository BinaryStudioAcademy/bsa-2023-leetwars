namespace LeetWars.Core.BLL.Interfaces
{
    public interface IHttpService
    {
        public Task<HttpResponseMessage> PostRequestAsync(string uri, string content);
    }
}
