using Bogus;
using Bogus.DataSets;
using LeetWars.Core.DAL.Context.EntityConfigurations;
using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Entities.HelperEntities;
using LeetWars.Core.DAL.Enums;
using LeetWars.Core.DAL.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace LeetWars.Core.DAL.Context
{
    public static class ModelBuilderExtensions
    {
        private static readonly int UserSeed = 1234;

        private static readonly int UserSolutionSeed = 2345;

        private static readonly int ChallengeSeed = 3456;

        private static readonly int ChallengeVersionSeed = 4567;

        private static readonly int SubscriptionSeed = 5678;

        private static readonly int SubscriptionTypeSeed = 6789;

        private static readonly int TestSeed = 7890;

        private static readonly int LanguageVersionSeed = 8901;

        private static readonly IList<Tag> Tags = new List<Tag>()
        {
            new Tag("Arrays"){ Id = 1 },
            new Tag("Algorithms"){ Id = 2 },
            new Tag("Backend"){ Id = 3 },
            new Tag("Async"){ Id = 4 },
            new Tag("AI"){ Id = 5 },
            new Tag("Concurrency"){ Id = 6 },
            new Tag("Filtering"){ Id = 7 },
            new Tag("Fundamentals"){ Id = 8 },
            new Tag("Heaps"){ Id = 9 },
        };

        private static readonly IList<ChallengeLevel> ChallengeLevels = new List<ChallengeLevel>()
        {
            new ChallengeLevel("Easy"){ Id = 1, Reward = 10 },
            new ChallengeLevel("Medium"){ Id = 2, Reward = 20 },
            new ChallengeLevel("Difficult"){ Id = 3, Reward = 30 },
            new ChallengeLevel("Extreme"){ Id = 4, Reward = 40 }
        };

        private static readonly IList<Language> Languages = new List<Language>()
        {
            new Language("C#"){Id = 1},
            new Language("Typescript"){Id = 2},
            new Language("Python"){Id = 3},
            new Language("Javascript"){Id = 4}
        };

        public static void Configure(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EntityConfig<long>).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EntityConfig<int>).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ChallengeConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ChallengeLevelConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ChallengeVersionConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LanguageConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LanguageVersionConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SubscriptionConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SubscriptionTypeConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TagConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserLanguageLevelConfig).Assembly);
        }

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tag>().HasData(Tags);
            modelBuilder.Entity<ChallengeLevel>().HasData(ChallengeLevels);
            modelBuilder.Entity<Language>().HasData(Languages);

            var userEntities = GenerateUsers();
            modelBuilder.Entity<User>().HasData(userEntities);

            var subscriptionTypeEntities = GenerateSubscriptionTypes();
            modelBuilder.Entity<SubscriptionType>().HasData(subscriptionTypeEntities);

            var languageVersionEntities = GenerateLanguageVersions();
            modelBuilder.Entity<LanguageVersion>().HasData(languageVersionEntities);

            var challengeEntities = GenerateChallenges(userEntities);
            modelBuilder.Entity<Challenge>().HasData(challengeEntities);

            var subscriptionEntities = GenerateSubscriptions(subscriptionTypeEntities, userEntities);
            modelBuilder.Entity<Subscription>().HasData(subscriptionEntities);

            var challengeVersionEntities = GenerateChallengeVersions(challengeEntities);
            modelBuilder.Entity<ChallengeVersion>().HasData(challengeVersionEntities);

            var testEntities = GenerateTests(challengeVersionEntities);
            modelBuilder.Entity<Test>().HasData(testEntities);

            var userSolutionEntities = GenerateUserSolutions(userEntities, challengeVersionEntities);
            modelBuilder.Entity<UserSolution>().HasData(userSolutionEntities);
        }

        private static IList<Challenge> GenerateChallenges(IList<User> users, int count = 70)
        {
            Faker.GlobalUniqueIndex = 0;

            return new Faker<Challenge>()
                .CustomInstantiator(f => new Challenge(f.Hacker.Phrase().LimitLength(EntitySettings.MaxGeneralNameLength), f.Lorem.Text()))
                .UseSeed(ChallengeSeed)
                .RuleFor(e => e.Id, f => f.IndexGlobal)
                .RuleFor(e => e.AuthorId, f => f.PickRandom(users).Id)
                .RuleFor(e => e.LevelId, f => f.PickRandom(ChallengeLevels).Id)
                .RuleFor(p => p.CreatedAt, (f, e) =>
                {
                    var author = users.ToList().Find(a => a.Id == e.AuthorId);
                    return f.Date.Between(author?.RegisteredAt ?? DateTime.Now, DateTime.Now);
                })
                .Generate(count);
        }

        private static IList<ChallengeVersion> GenerateChallengeVersions(IList<Challenge> challenges, int count = 200)
        {
            Faker.GlobalUniqueIndex = 0;

            return new Faker<ChallengeVersion>()
                .CustomInstantiator(f => new ChallengeVersion(f.Lorem.Sentence(), f.Lorem.Text()))
                .UseSeed(ChallengeVersionSeed)
                .RuleFor(e => e.Id, f => f.IndexGlobal)
                .RuleFor(e => e.LanguageId, f => f.PickRandom(Languages).Id)
                .RuleFor(e => e.ChallengeId, f => f.PickRandom(challenges).Id)
                .RuleFor(e => e.Status, f => f.PickRandom<ChallengeStatus>())
                .RuleFor(p => p.CreatedAt, (f, e) =>
                {
                    var challenge = challenges.ToList().Find(a => a.Id == e.ChallengeId);
                    return f.Date.Between(challenge?.CreatedAt ?? DateTime.Now, DateTime.Now);
                })
                .Generate(count);
        }

        private static IList<LanguageVersion> GenerateLanguageVersions(int count = 3)
        {
            Faker.GlobalUniqueIndex = 0;

            return new Faker<LanguageVersion>()
                .CustomInstantiator( f => new LanguageVersion(f.System.Version().ToString().LimitLength(EntitySettings.MaxShortNameLength)))
                .UseSeed(LanguageVersionSeed)
                .RuleFor(e => e.Id, f => f.IndexGlobal)
                .RuleFor(e => e.LanguageId, f => f.PickRandom(Languages).Id)
                .Generate(count);
        }

        private static IList<SubscriptionType> GenerateSubscriptionTypes(int count = 3)
        {
            Faker.GlobalUniqueIndex = 0;

            return new Faker<SubscriptionType>()
                .CustomInstantiator(f => new SubscriptionType(string.Join(" ", f.Random.Words(3)).LimitLength(EntitySettings.MaxShortNameLength), f.Lorem.Sentence().LimitLength(EntitySettings.MaxDescriptionLength)))
                .UseSeed(SubscriptionTypeSeed)
                .RuleFor(e => e.Id, f => f.IndexGlobal)
                .RuleFor(e => e.Cost, f => Math.Round(f.Random.Decimal(0m, 200m), EntitySettings.DecimalPartLength))
                .RuleFor(e => e.BillingPeriod, f => f.PickRandom<BillingPeriod>())
                .Generate(count);
        }

        private static IList<Subscription> GenerateSubscriptions(IList<SubscriptionType> subscriptionTypes, IList<User> users, int count = 110)
        {
            Faker.GlobalUniqueIndex = 0;

            return new Faker<Subscription>()
                .CustomInstantiator(f => new Subscription(f.Random.AlphaNumeric(16)))
                .UseSeed(SubscriptionSeed)
                .RuleFor(e => e.Id, f => f.IndexGlobal)
                .RuleFor(e => e.UserId, f => f.PickRandom(users).Id)
                .RuleFor(e => e.TypeId, f => f.PickRandom(subscriptionTypes).Id)
                .RuleFor(p => p.Cost, (f, e) =>
                {
                    var subscriptionType = subscriptionTypes.ToList().Find(a => a.Id == e.TypeId);
                    return subscriptionType?.Cost ?? 0m;
                })
                .RuleFor(p => p.SubscribedDate, (f, e) =>
                {
                    var user = users.ToList().Find(a => a.Id == e.UserId);
                    return f.Date.Between(user?.RegisteredAt ?? DateTime.Now, DateTime.Now);
                })
                .RuleFor(p => p.StartDate, (f, e) =>
                {
                    return f.Date.Between(e.SubscribedDate, DateTime.Now);
                })
                .RuleFor(p => p.EndDate, (f, e) =>
                {
                    return f.Date.Between(e.StartDate, e.StartDate.AddYears(1));
                })
                .RuleFor(p => p.UnsubscribedDate, (f, e) =>
                {
                    return f.Date.Between(e.SubscribedDate, DateTime.Now).OrNull(f, 0.07f);
                })
                .RuleFor(e => e.IsActive, f => f.Random.Bool())
                .Generate(count);
        }

        private static IList<Test> GenerateTests(IList<ChallengeVersion> challengeVersions, int count = 200)
        {
            Faker.GlobalUniqueIndex = 0;

            return new Faker<Test>()
                .CustomInstantiator(f => new Test(f.Lorem.Text()))
                .UseSeed(TestSeed)
                .RuleFor(e => e.Id, f => f.IndexGlobal)
                .RuleFor(e => e.ChallengeVersionId, f => f.PickRandom(challengeVersions).Id)
                .RuleFor(e => e.IsPublic, f => f.Random.Bool(0.7f))
                .RuleFor(p => p.CreatedAt, (f, e) =>
                {
                    var challengeVersion = challengeVersions.ToList().Find(a => a.Id == e.ChallengeVersionId);
                    return f.Date.Between(challengeVersion?.CreatedAt ?? DateTime.Now, DateTime.Now);
                })
                .Generate(count);
        }

        private static IList<UserSolution> GenerateUserSolutions(IList<User> users, IList<ChallengeVersion> challengeVersions, int count = 200)
        {
            Faker.GlobalUniqueIndex = 0;

            return new Faker<UserSolution>()
                .CustomInstantiator(f => new UserSolution(f.Lorem.Text(), f.Lorem.Text()))
                .UseSeed(UserSolutionSeed)
                .RuleFor(e => e.Id, f => f.IndexGlobal)
                .RuleFor(e => e.UserId, f => f.PickRandom(users).Id)
                .RuleFor(e => e.ChallengeVersionId, f => f.PickRandom(challengeVersions).Id)
                .RuleFor(p => p.CreatedAt, (f, e) =>
                {
                    var challengeVersion = challengeVersions.ToList().Find(a => a.Id == e.ChallengeVersionId);
                    return f.Date.Between(challengeVersion?.CreatedAt ?? DateTime.Now, DateTime.Now);
                })
                .RuleFor(p => p.SubmittedAt, (f, e) =>
                {
                    return f.Date.Between(e.CreatedAt, DateTime.Now).OrNull(f, 0.1f);
                })
                .Generate(count);
        }

        private static IList<User> GenerateUsers(int count = 40)
        {
            Faker.GlobalUniqueIndex = 0;
            int uniqueIntForUserId = 0;

            return new Faker<User>()
                .CustomInstantiator(f => new User(f.Name.FirstName().LimitLength(EntitySettings.MaxGeneralNameLength), 
                        f.Name.LastName().LimitLength(EntitySettings.MaxGeneralNameLength), 
                        f.Internet.UserName().LimitLength(EntitySettings.MaxUserNameLength - 3) + (uniqueIntForUserId++), 
                        f.Internet.Email().LimitLength(EntitySettings.MaxEmailLength), 
                        f.System.DirectoryPath().LimitLength(EntitySettings.MaxPathLength), 
                        f.Random.AlphaNumeric(32)))
                .UseSeed(UserSeed)
                .RuleFor(e => e.Id, f => f.IndexGlobal)
                .RuleFor(e => e.Country, f => f.PickRandom<Country>())
                .RuleFor(e => e.Sex, f => f.PickRandom<Sex>())
                .RuleFor(e => e.Status, f => f.PickRandom<UserStatus>())
                .RuleFor(e => e.Timezone, f => f.Random.Int(-12, 12))
                .RuleFor(e => e.BirthDate, f => f.Date.Between(new DateTime(1980, 1, 1), new DateTime(2000, 12, 31)))
                .RuleFor(e => e.TotalScore, f => f.Random.Long(0, 100000))
                .RuleFor(e => e.IsBanned, f => f.Random.Bool(0.05f))
                .RuleFor(e => e.IsSubscribed, f => f.Random.Bool(0.8f))
                .RuleFor(p => p.RegisteredAt, f => f.Date.Between(new DateTime(2016, 1, 1), DateTime.Now))
                .Generate(count);
        }

    }
}