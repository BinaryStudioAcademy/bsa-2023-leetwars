using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Interfaces;
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
        public DbSet<LanguageVersion> LanguageVersions => Set<LanguageVersion>();
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

        private readonly IUidProvider _userUidProvider;

        private long? _creatorId;
        public LeetWarsCoreContext(DbContextOptions<LeetWarsCoreContext> options, IUidProvider userUidProvider) : base(options)
        {
            _userUidProvider = userUidProvider;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Configure();

            modelBuilder.Seed();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            SetAuditEntityData();

            return base.SaveChangesAsync(cancellationToken);
        }

        public override int SaveChanges()
        {
            SetAuditEntityData();

            return base.SaveChanges();
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            SetAuditEntityData();

            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        private void SetAuditEntityData()
        {
            ChangeTracker.DetectChanges();
            var added = this.ChangeTracker.Entries()
                        .Where(t => t.State == EntityState.Added && t.Entity is AuditEntity<long>)
                        .ToArray();

            foreach (var entity in added)
            {
                var auditEntity = entity.Entity as AuditEntity<long>;

                _creatorId ??= Users.SingleOrDefault(e => e.Uid == _userUidProvider.Uid)?.Id;
                if (auditEntity is not null)
                {
                    auditEntity.CreatedAt = DateTime.UtcNow;
                    auditEntity.CreatedBy = _creatorId;
                }
            }

        }
    }
}
