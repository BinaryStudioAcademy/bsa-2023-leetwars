using AutoMapper;
using LeetWars.Core.BLL.Exceptions;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.UserPrefferences;
using LeetWars.Core.DAL.Context;
using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace LeetWars.Core.BLL.Services
{
    public class PreferencesService : BaseService, IPreferencesService
    {
        private readonly IUserGetter _userGetter;
        public PreferencesService(LeetWarsCoreContext context,
                       IMapper mapper,
                       IUserGetter userGetter
                       ) : base(context, mapper)
        {
            _userGetter = userGetter;
        }
        public async Task<UserPreferencesDto> GetUserPreferences()
        {
            //var currentUser = await _context.Users.FirstOrDefaultAsync(x => x.Uid == _userGetter.CurrentUserId)
            //                 ?? throw new NotFoundException(nameof(User), _userGetter.CurrentUserId);

            var preferences = await _context.UserPreferences.FirstOrDefaultAsync(x => x.UserId ==6);

            return _mapper.Map<UserPreferencesDto>(preferences);
        }

        public async Task<UserPreferencesDto> SetUserPreferences(NewUserPreferencesDto newPreferences)
        {
            //var currentUser = await _context.Users.FirstOrDefaultAsync(x => x.Uid == _userGetter.CurrentUserId)
            //                 ?? throw new NotFoundException(nameof(User), _userGetter.CurrentUserId);

            var currentPreferences = await _context.UserPreferences.FirstOrDefaultAsync(x => x.UserId == 6);

            var updatedPreferences = currentPreferences is not null
                ?  UpdateUserPreferences(currentPreferences, newPreferences)
                : await AddUserPreferences(newPreferences, 6); 

            await _context.SaveChangesAsync();

            return _mapper.Map<UserPreferencesDto>(currentPreferences);
        }

        private async Task<UserPreferencesDto> AddUserPreferences(NewUserPreferencesDto newPreferences, long userId)
        {
            var preferences = _mapper.Map<UserPreferences>(newPreferences);
            preferences.UserId = userId;
            await _context.AddAsync(preferences);
            return _mapper.Map<UserPreferencesDto>(preferences);
        }

        private UserPreferencesDto UpdateUserPreferences(UserPreferences currentPreferences, NewUserPreferencesDto newPreferences)
        {
            currentPreferences.Theme = newPreferences.Theme;
            currentPreferences.FontSize = newPreferences.FontSize;
            currentPreferences.TabWidth = newPreferences.TabWidth;
            currentPreferences.WordWrap = newPreferences.WordWrap;
            currentPreferences.LanguageId = newPreferences.LanguageId;

            _context.Update(currentPreferences);

            return _mapper.Map<UserPreferencesDto>(currentPreferences);
        }
    }
}
