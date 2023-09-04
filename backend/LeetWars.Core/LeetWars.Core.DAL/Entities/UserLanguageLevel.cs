using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.DAL.Entities
{
    public class UserLanguageLevel
    {
        public long UserId { get; set; }
        public int LanguageId { get; set; }
        public LanguageLevel Level { get; set; }
        public User? User { get; set; }
        public Language? Language { get; set; }
    }
}
