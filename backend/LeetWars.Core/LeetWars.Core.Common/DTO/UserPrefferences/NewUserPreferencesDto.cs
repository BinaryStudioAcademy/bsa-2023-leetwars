using LeetWars.Core.Common.DTO.Language;

namespace LeetWars.Core.Common.DTO.UserPrefferences
{
    public class NewUserPreferencesDto
    {
        public long? LanguageId { get; set; }

        public string? Theme { get; set; }

        public bool? IsWordWrap { get; set; }

        public bool? IsMinimap { get; set; }

        public int? TabSize { get; set; }

        public int? FontSize { get; set; }
    }
}