using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.Common.DTO.UserLanguageLevel
{
    public class UserLanguageLevelDto
    {
        public long UserId { get; set; }
        public int LanguageId { get; set; }
        public LanguageLevel Level { get; set; }
    }
}
