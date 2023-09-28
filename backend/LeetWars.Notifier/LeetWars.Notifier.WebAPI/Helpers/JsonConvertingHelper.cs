using Newtonsoft.Json;

namespace LeetWars.Notifier.WebAPI.Helpers;

public static class JsonConvertingHelper
{
    public static bool TryDeserialize<T>(string message, out T? result)
    {
        try
        {
            result = JsonConvert.DeserializeObject<T>(message, new JsonSerializerSettings()
            {
                MissingMemberHandling = MissingMemberHandling.Error
            });
            
            return true;
        }
        catch
        {
            result = default!;
            return false;
        }
    }
}