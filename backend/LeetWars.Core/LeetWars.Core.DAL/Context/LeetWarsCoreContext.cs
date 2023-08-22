using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace LeetWars.Core.DAL.Context
{
    public class LeetWarsCoreContext : DbContext
    {
        public DbSet<Challenge> Challenges => Set<Challenge>();
        public DbSet<ChallengeLevel> ChallengeLevels => Set<ChallengeLevel>();
        public DbSet<ChallengeVersion> ChallengeVersions => Set<ChallengeVersion>();
        public DbSet<Language> Languages => Set<Language>();
        public DbSet<LanguageVersion> LanguageVersions => Set<LanguageVersion>();
        public DbSet<Subscription> Subscriptions => Set<Subscription>();
        public DbSet<SubscriptionType> SubscriptionTypes => Set<SubscriptionType>();
        public DbSet<Tag> Tags => Set<Tag>();
        public DbSet<Test> Tests => Set<Test>();
        public DbSet<User> Users => Set<User>();
        public DbSet<UserLanguageLevel> UserLanguageLevels => Set<UserLanguageLevel>();
        public DbSet<UserSolution> UserSolutions => Set<UserSolution>();

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
