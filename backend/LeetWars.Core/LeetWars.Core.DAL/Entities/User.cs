using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.DAL.Entities
{
    public class User : Entity<long>
    {
        public string Uid { get; set; }  = string.Empty;
        public Country? Country { get; set; }
        public int Timezone { get; set; }
        public Sex Sex { get; set; }
        public UserStatus Status { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string UserName { get; set; }  = string.Empty;
        public string Email { get; set; }  = string.Empty;
        public string? ImagePath { get; set; }
        public long TotalScore { get; set; }
        public long Reputation { get; set; }
        public DateTime RegisteredAt { get; set; }
        public string? OAuthToken { get; set; }
        public bool IsSubscribed { get; set; }
        public bool IsBanned { get; set; }
        public ICollection<Subscription> Subscriptions { get; } = new List<Subscription>();
        public ICollection<Language> PreferredLanguages { get; } = new List<Language>();
        public ICollection<UserLanguageLevel> LanguagesWithLevels { get; } = new List<UserLanguageLevel>();
        public ICollection<UserSolution> Solutions { get; } = new List<UserSolution>();
        public ICollection<Challenge> Challenges { get; } = new List<Challenge>();
        public ICollection<ChallengeVersion> ChallengeVersions { get; } = new List<ChallengeVersion>();
        public ICollection<UserBadge> UserBadges { get; } = new List<UserBadge>();

        public User() {}

        public User(string firstName, string lastName, string userName, string email, string imagePath, string oAuthToken)
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Email = email;
            ImagePath = imagePath;
            OAuthToken = oAuthToken;
        }
    }
}
