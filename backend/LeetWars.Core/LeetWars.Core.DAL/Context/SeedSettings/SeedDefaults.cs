﻿using LeetWars.Core.DAL.Entities;
using System.Collections.Immutable;

namespace LeetWars.Core.DAL.Context.SeedSettings
{
    public static class SeedDefaults
    {
        public static readonly int UserSeed = 1234;

        public static readonly int UserSolutionSeed = 2345;

        public static readonly int ChallengeSeed = 3456;

        public static readonly int ChallengeVersionSeed = 4567;

        public static readonly int SubscriptionSeed = 5678;

        public static readonly int SubscriptionTypeSeed = 6789;

        public static readonly int TestSeed = 7890;

        public static readonly int LanguageVersionSeed = 8901;

        public static readonly ImmutableArray<Tag> Tags = ImmutableArray.CreateRange(new Tag[]
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
        });

        public static readonly ImmutableArray<ChallengeLevel> ChallengeLevels = ImmutableArray.CreateRange(new ChallengeLevel[]
        {
            new ChallengeLevel("Easy"){ Id = 1, Reward = 10 },
            new ChallengeLevel("Medium"){ Id = 2, Reward = 20 },
            new ChallengeLevel("Difficult"){ Id = 3, Reward = 30 },
            new ChallengeLevel("Extreme"){ Id = 4, Reward = 40 }
        });

        public static readonly ImmutableArray<Language> Languages = ImmutableArray.CreateRange(new Language[]
        {
            new Language("C#"){Id = 1},
            new Language("Typescript"){Id = 2},
            new Language("Python"){Id = 3},
            new Language("Javascript"){Id = 4}
        });
        
        public static readonly ImmutableArray<Badge> Badges = ImmutableArray.CreateRange(new Badge[]
        {
            new Badge("Jan LeetWars Challenge Badge", "/static/images/badges/2023-01.png", "/static/images/badges/2023-01.gif"){Id = 1},
            new Badge("Feb LeetWars Challenge Badge", "/static/images/badges/2023-02.png", "/static/images/badges/2023-02.gif"){Id = 2},
            new Badge("Mar LeetWars Challenge Badge", "/static/images/badges/2023-03.png", "/static/images/badges/2023-03.gif"){Id = 3},
            new Badge("Apr LeetWars Challenge Badge", "/static/images/badges/2023-04.png", "/static/images/badges/2023-04.gif"){Id = 4},
            new Badge("May LeetWars Challenge Badge", "/static/images/badges/2023-05.png", "/static/images/badges/2023-05.gif"){Id = 5},
            new Badge("Jun LeetWars Challenge Badge", "/static/images/badges/2023-06.png", "/static/images/badges/2023-06.gif"){Id = 6},
            new Badge("Jul LeetWars Challenge Badge", "/static/images/badges/2023-07.png", "/static/images/badges/2023-07.gif"){Id = 7},
            new Badge("Aug LeetWars Challenge Badge", "/static/images/badges/2023-08.png", "/static/images/badges/2023-08.gif"){Id = 8},
            new Badge("Sep LeetWars Challenge Badge", "/static/images/badges/2023-09.png", "/static/images/badges/2023-09.gif"){Id = 9},
            new Badge("Oct LeetWars Challenge Badge", "/static/images/badges/2023-10.png", "/static/images/badges/2023-10.gif"){Id = 10},
            new Badge("Nov LeetWars Challenge Badge", "/static/images/badges/2023-11.png", "/static/images/badges/2023-11.gif"){Id = 11},
            new Badge("Dec LeetWars Challenge Badge", "/static/images/badges/2023-12.png", "/static/images/badges/2023-12.gif"){Id = 12},
        });

    }
}
