using LeetWars.Core.Common.DTO.Language;

namespace LeetWars.Core.Common.DTO.UserPrefferences
{
    public class UserPreferencesDto 
    {
        public LanguageDto? Language{ get; set; }

        public string? Theme { get; set; }

        public bool? WordWrap { get; set; }

        public int? TabWidth { get; set; }

        public int? FontSize { get; set; }
    }
}
