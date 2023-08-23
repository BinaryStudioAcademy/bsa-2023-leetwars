﻿using Bogus;
using LeetWars.Core.DAL.Context.EntityConfigurations;
using LeetWars.Core.DAL.Context.SeedSettings;
using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Entities.HelperEntities;
using LeetWars.Core.DAL.Enums;
using LeetWars.Core.DAL.Extensions;
using Microsoft.EntityFrameworkCore;

namespace LeetWars.Core.DAL.Context
{
    public static class ModelBuilderExtensions
    {

        public static void Configure(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EntityConfig<long>).Assembly);
        }

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tag>().HasData(SeedDefaults.Tags);
            modelBuilder.Entity<ChallengeLevel>().HasData(SeedDefaults.ChallengeLevels);
            modelBuilder.Entity<Language>().HasData(SeedDefaults.Languages);

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

            var challengeVersionEntities = GenerateChallengeVersions(userEntities, challengeEntities);
            modelBuilder.Entity<ChallengeVersion>().HasData(challengeVersionEntities);

            var testEntities = GenerateTests(userEntities, challengeVersionEntities);
            modelBuilder.Entity<Test>().HasData(testEntities);

            var userSolutionEntities = GenerateUserSolutions(userEntities, challengeVersionEntities);
            modelBuilder.Entity<UserSolution>().HasData(userSolutionEntities);
        }

        private static ICollection<Challenge> GenerateChallenges(ICollection<User> users, int count = 70)
        {
            Faker.GlobalUniqueIndex = 0;

            return new Faker<Challenge>()
                .CustomInstantiator(f => new Challenge(f.Hacker.Phrase().LimitLength(EntitySettings.MaxGeneralNameLength), f.Lorem.Text()))
                .UseSeed(SeedDefaults.ChallengeSeed)
                .RuleFor(e => e.Id, f => f.IndexGlobal)
                .RuleFor(e => e.CreatedBy, f => f.PickRandom(users).Id)
                .RuleFor(e => e.LevelId, f => f.PickRandom(SeedDefaults.ChallengeLevels.AsEnumerable()).Id)
                .RuleFor(p => p.CreatedAt, (f, e) =>
                {
                    var author = users.ToList().Find(a => a.Id == e.CreatedBy);
                    return f.Date.Between(author?.RegisteredAt ?? DateTime.Now, DateTime.Now);
                })
                .Generate(count);
        }

        private static ICollection<ChallengeVersion> GenerateChallengeVersions(ICollection<User> users, ICollection<Challenge> challenges, int count = 200)
        {
            Faker.GlobalUniqueIndex = 0;

            return new Faker<ChallengeVersion>()
                .CustomInstantiator(f => new ChallengeVersion(f.Lorem.Sentence(), f.Lorem.Text()))
                .UseSeed(SeedDefaults.ChallengeVersionSeed)
                .RuleFor(e => e.Id, f => f.IndexGlobal)
                .RuleFor(e => e.LanguageId, f => f.PickRandom(SeedDefaults.Languages.AsEnumerable()).Id)
                .RuleFor(e => e.ChallengeId, f => f.PickRandom(challenges).Id)
                .RuleFor(e => e.Status, f => f.PickRandom<ChallengeStatus>())
                .RuleFor(e => e.CreatedBy, f => f.PickRandom(users).Id)
                .RuleFor(p => p.CreatedAt, (f, e) =>
                {
                    var challenge = challenges.ToList().Find(a => a.Id == e.ChallengeId);
                    return f.Date.Between(challenge?.CreatedAt ?? DateTime.Now, DateTime.Now);
                })
                .Generate(count);
        }

        private static ICollection<LanguageVersion> GenerateLanguageVersions(int count = 9)
        {
            Faker.GlobalUniqueIndex = 0;

            return new Faker<LanguageVersion>()
                .CustomInstantiator( f => new LanguageVersion(f.System.Version().ToString().LimitLength(EntitySettings.MaxShortNameLength)))
                .UseSeed(SeedDefaults.LanguageVersionSeed)
                .RuleFor(e => e.Id, f => f.IndexGlobal)
                .RuleFor(e => e.LanguageId, f => f.PickRandom(SeedDefaults.Languages.AsEnumerable()).Id)
                .Generate(count);
        }

        private static ICollection<SubscriptionType> GenerateSubscriptionTypes(int count = 3)
        {
            Faker.GlobalUniqueIndex = 0;

            return new Faker<SubscriptionType>()
                .CustomInstantiator(f => new SubscriptionType(string.Join(" ", f.Random.Words(3)).LimitLength(EntitySettings.MaxShortNameLength), f.Lorem.Sentence().LimitLength(EntitySettings.MaxDescriptionLength)))
                .UseSeed(SeedDefaults.SubscriptionTypeSeed)
                .RuleFor(e => e.Id, f => f.IndexGlobal)
                .RuleFor(e => e.Cost, f => Math.Round(f.Random.Decimal(0m, 200m), EntitySettings.DecimalPartLength))
                .RuleFor(e => e.BillingPeriod, f => f.PickRandom<BillingPeriod>())
                .Generate(count);
        }

        private static ICollection<Subscription> GenerateSubscriptions(ICollection<SubscriptionType> subscriptionTypes, ICollection<User> users, int count = 110)
        {
            Faker.GlobalUniqueIndex = 0;

            return new Faker<Subscription>()
                .CustomInstantiator(f => new Subscription(f.Random.AlphaNumeric(16)))
                .UseSeed(SeedDefaults.SubscriptionSeed)
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

        private static ICollection<Test> GenerateTests(ICollection<User> users, ICollection<ChallengeVersion> challengeVersions, int count = 200)
        {
            Faker.GlobalUniqueIndex = 0;

            return new Faker<Test>()
                .CustomInstantiator(f => new Test(f.Lorem.Text()))
                .UseSeed(SeedDefaults.TestSeed)
                .RuleFor(e => e.Id, f => f.IndexGlobal)
                .RuleFor(e => e.ChallengeVersionId, f => f.PickRandom(challengeVersions).Id)
                .RuleFor(e => e.IsPublic, f => f.Random.Bool(0.7f))
                .RuleFor(e => e.CreatedBy, f => f.PickRandom(users).Id)
                .RuleFor(p => p.CreatedAt, (f, e) =>
                {
                    var challengeVersion = challengeVersions.ToList().Find(a => a.Id == e.ChallengeVersionId);
                    return f.Date.Between(challengeVersion?.CreatedAt ?? DateTime.Now, DateTime.Now);
                })
                .Generate(count);
        }

        private static ICollection<UserSolution> GenerateUserSolutions(ICollection<User> users, ICollection<ChallengeVersion> challengeVersions, int count = 200)
        {
            Faker.GlobalUniqueIndex = 0;

            return new Faker<UserSolution>()
                .CustomInstantiator(f => new UserSolution(f.Lorem.Text(), f.Lorem.Text()))
                .UseSeed(SeedDefaults.UserSolutionSeed)
                .RuleFor(e => e.Id, f => f.IndexGlobal)
                .RuleFor(e => e.CreatedBy, f => f.PickRandom(users).Id)
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

        private static ICollection<User> GenerateUsers(int count = 40)
        {
            Faker.GlobalUniqueIndex = 0;

            int uniqueIntForUserId = 0;

            return new Faker<User>()
                .CustomInstantiator(f => new User(f.Name.FirstName().LimitLength(EntitySettings.MaxGeneralNameLength), 
                        f.Name.LastName().LimitLength(EntitySettings.MaxGeneralNameLength), 
                        f.Internet.UserName().LimitLength(EntitySettings.MaxUserNameLength - 3) + (uniqueIntForUserId++),
                        f.Internet.Email().LimitLength(EntitySettings.MaxEmailLength), 
                        f.Random.String2(30) + ".jpg", 
                        f.Random.AlphaNumeric(32)))
                .UseSeed(SeedDefaults.UserSeed)
                .RuleFor(e => e.Id, f => f.IndexGlobal)
                .RuleFor(e => e.Country, f => f.PickRandom<Country>())
                .RuleFor(e => e.Sex, f => f.PickRandom<Sex>())
                .RuleFor(e => e.Status, f => f.PickRandom<UserStatus>())
                .RuleFor(e => e.Timezone, f => f.Random.Int(-12, 12))
                .RuleFor(e => e.BirthDate, f => f.Date.Between(new DateTime(1980, 1, 1, 0, 0, 0, DateTimeKind.Utc), new DateTime(2000, 12, 31, 0, 0, 0, DateTimeKind.Utc)))
                .RuleFor(e => e.TotalScore, f => f.Random.Long(0, 100000))
                .RuleFor(e => e.IsBanned, f => f.Random.Bool(0.05f))
                .RuleFor(e => e.IsSubscribed, f => f.Random.Bool(0.8f))
                .RuleFor(p => p.RegisteredAt, f => f.Date.Between(new DateTime(2016, 1, 1, 0, 0, 0, DateTimeKind.Utc), DateTime.Now))
                .Generate(count);
        }

    }
}