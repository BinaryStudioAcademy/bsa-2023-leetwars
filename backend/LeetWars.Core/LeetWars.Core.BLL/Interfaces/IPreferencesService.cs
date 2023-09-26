using LeetWars.Core.Common.DTO.UserPrefferences;

namespace LeetWars.Core.BLL.Interfaces
{
    public interface IPreferencesService
    {
        public Task<UserPreferencesDto> GetUserPreferences();

        public Task<UserPreferencesDto> SetUserPreferences(NewUserPreferencesDto newPreferences);
    }
}
