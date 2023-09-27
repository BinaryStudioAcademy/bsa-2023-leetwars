using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace LeetWars.Core.DAL.Context
{
    public class LeetWarsCoreContext : DbContext
    {
        public DbSet<Challenge> Challenges => Set<Challenge>();
        public DbSet<ChallengeLevel> ChallengeLevels => Set<ChallengeLevel>();
        public DbSet<ChallengeVersion> ChallengeVersions => Set<ChallengeVersion>();
        public DbSet<ChallengeStar> ChallengeStars => Set<ChallengeStar>();
        public DbSet<Language> Languages => Set<Language>();
        public DbSet<Subscription> Subscriptions => Set<Subscription>();
        public DbSet<SubscriptionType> SubscriptionTypes => Set<SubscriptionType>();
        public DbSet<Tag> Tags => Set<Tag>();
        public DbSet<ChallengeTag> ChallengeTags => Set<ChallengeTag>();
        public DbSet<UserPreferredLanguage> UserPreferredLanguage => Set<UserPreferredLanguage>();
        public DbSet<Test> Tests => Set<Test>();
        public DbSet<User> Users => Set<User>();
        public DbSet<UserLanguageLevel> UserLanguageLevels => Set<UserLanguageLevel>();
        public DbSet<UserSolution> UserSolutions => Set<UserSolution>();
        public DbSet<Badge> Badges => Set<Badge>();
        public DbSet<UserBadge> UserBadges => Set<UserBadge>();
        public DbSet<Notification> Notifications => Set<Notification>();
        public DbSet<UserNotification> UserNotifications => Set<UserNotification>();
        public DbSet<CodeFight> CodeFights => Set<CodeFight>();

        public LeetWarsCoreContext(DbContextOptions<LeetWarsCoreContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Configure();

            modelBuilder.Seed();
        }
    }
}
