using LeetWars.Core.Common.DTO.Badge;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.Language;
using LeetWars.Core.Common.DTO.Subscription;
using LeetWars.Core.Common.DTO.UserLanguageLevel;
using LeetWars.Core.Common.DTO.UserSolution;
using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.Common.DTO.User
{
    public class UserFullDto : Entity<long>, IDtoWithImage
    {
        public Country Country { get; set; }
        public int Timezone { get; set; }
        public Sex Sex { get; set; }
        public UserStatus Status { get; set; }
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? ImagePath { get; set; }
        public long TotalScore { get; set; }
        public long Reputation { get; set; }
        public DateTime RegisteredAt { get; set; }
        public string OAuthToken { get; set; } = string.Empty;
        public bool IsSubscribed { get; set; }
        public bool IsBanned { get; set; }
        public ICollection<SubscriptionDto>? Subscriptions { get; set; }
        public ICollection<LanguageDto>? PreferredLanguages { get; set; }
        public ICollection<UserLanguageLevelDto>? LanguagesWithLevels { get; set; }
        public ICollection<UserSolutionDto>? Solutions { get; set; }
        public ICollection<ChallengeDto>? Challenges { get; set; }
        public ICollection<BadgeDto>? Badges { get; set; }
    }
}
