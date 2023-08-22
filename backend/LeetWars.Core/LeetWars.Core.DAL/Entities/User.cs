using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.DAL.Entities
{
    public class User : Entity<long>
    {
        public Country Country { get; set; }
        public int Timezone { get; set; }
        public Sex Sex { get; set; }
        public UserStatus Status { get; set; }
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }
        public long TotalScore { get; set; }
        public DateTime RegisteredAt { get; set; }
        public string OAuthToken { get; set; }
        public bool IsSubscribed { get; set; }
        public bool IsBanned { get; set; }
        public List<Subscription> Subscriptions { get; } = new();
        public List<Language> PreferredLanguages { get; } = new();
        public List<UserLanguageLevel> LanguagesWithLevels { get; } = new();
        public List<UserSolution> Solutions { get; } = new();
        public List<Challenge> Challenges { get; } = new();


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
