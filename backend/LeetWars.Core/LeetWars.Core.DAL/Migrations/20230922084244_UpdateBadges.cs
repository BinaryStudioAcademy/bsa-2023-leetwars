using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeetWars.Core.DAL.Migrations
{
    public partial class UpdateBadges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Badges",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconGif = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Badges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChallengeLevels",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reward = table.Column<int>(type: "int", nullable: false),
                    SkillLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChallengeLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BillingPeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<int>(type: "int", nullable: true),
                    Timezone = table.Column<int>(type: "int", nullable: false),
                    Sex = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    TotalScore = table.Column<long>(type: "bigint", nullable: false),
                    Reputation = table.Column<long>(type: "bigint", nullable: false),
                    RegisteredAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OAuthToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSubscribed = table.Column<bool>(type: "bit", nullable: false),
                    IsBanned = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LanguageVersions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageId = table.Column<long>(type: "bigint", nullable: false),
                    Version = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageVersion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LanguageVersion_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Challenges",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Instructions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LevelId = table.Column<long>(type: "bigint", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Challenges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Challenge_ChallengeLevel_LevelId",
                        column: x => x.LevelId,
                        principalTable: "ChallengeLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Challenges_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    PaymentSubscriptionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubscribedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UnsubscribedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscription_SubscriptionTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "SubscriptionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChallengeVersionId = table.Column<long>(type: "bigint", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tests_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserBadges",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    BadgeId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBadges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserBadges_Badges_BadgeId",
                        column: x => x.BadgeId,
                        principalTable: "Badges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserBadges_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLanguageLevels",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    LanguageId = table.Column<long>(type: "bigint", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLanguageLevel", x => new { x.UserId, x.LanguageId });
                    table.ForeignKey(
                        name: "FK_UserLanguageLevel_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserLanguageLevels_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPreferredLanguage",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    LanguageId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPreferredLanguage", x => new { x.LanguageId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserPreferredLanguage_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPreferredLanguage_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChallengeStars",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChallengeId = table.Column<long>(type: "bigint", nullable: false),
                    AuthorId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChallengeStars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChallengeStars_Challenges_ChallengeId",
                        column: x => x.ChallengeId,
                        principalTable: "Challenges",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChallengeStars_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChallengeTags",
                columns: table => new
                {
                    ChallengeId = table.Column<long>(type: "bigint", nullable: false),
                    TagId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChallengeTags", x => new { x.ChallengeId, x.TagId });
                    table.ForeignKey(
                        name: "FK_ChallengeTags_Challenges_ChallengeId",
                        column: x => x.ChallengeId,
                        principalTable: "Challenges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChallengeTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChallengeVersions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageId = table.Column<long>(type: "bigint", nullable: false),
                    ChallengeId = table.Column<long>(type: "bigint", nullable: false),
                    InitialSolution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompleteSolution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreloadedCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestCases = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExampleTestCases = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChallengeVersions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChallengeVersion_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChallengeVersions_Challenges_ChallengeId",
                        column: x => x.ChallengeId,
                        principalTable: "Challenges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChallengeVersions_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChallengeVersionLanguageVersion",
                columns: table => new
                {
                    ChallengeVersionId = table.Column<long>(type: "bigint", nullable: false),
                    LanguageVersionId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChallengesVersionLanguagesVersion", x => new { x.ChallengeVersionId, x.LanguageVersionId });
                    table.ForeignKey(
                        name: "FK_ChallengeVersionLanguageVersion_ChallengeVersions_ChallengeVersionId",
                        column: x => x.ChallengeVersionId,
                        principalTable: "ChallengeVersions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChallengeVersionLanguageVersion_LanguageVersion_LanguageVersionId",
                        column: x => x.LanguageVersionId,
                        principalTable: "LanguageVersions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserSolutions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChallengeVersionId = table.Column<long>(type: "bigint", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Output = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubmittedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSolutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSolutions_ChallengeVersions_ChallengeVersionId",
                        column: x => x.ChallengeVersionId,
                        principalTable: "ChallengeVersions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSolutions_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Badges",
                columns: new[] { "Id", "Icon", "IconGif", "Name" },
                values: new object[,]
                {
                    { 1L, "2023-01.png", "2023-01.gif", "Jan LeetWars Challenge Badge" },
                    { 2L, "2023-02.png", "2023-02.gif", "Feb LeetWars Challenge Badge" },
                    { 3L, "2023-03.png", "2023-03.gif", "Mar LeetWars Challenge Badge" },
                    { 4L, "2023-04.png", "2023-04.gif", "Apr LeetWars Challenge Badge" },
                    { 5L, "2023-05.png", "2023-05.gif", "May LeetWars Challenge Badge" },
                    { 6L, "2023-06.png", "2023-06.gif", "Jun LeetWars Challenge Badge" },
                    { 7L, "2023-07.png", "2023-07.gif", "Jul LeetWars Challenge Badge" },
                    { 8L, "2023-08.png", "2023-08.gif", "Aug LeetWars Challenge Badge" },
                    { 9L, "2023-09.png", "2023-09.gif", "Sep LeetWars Challenge Badge" },
                    { 10L, "2023-10.png", "2023-10.gif", "Oct LeetWars Challenge Badge" },
                    { 11L, "2023-11.png", "2023-11.gif", "Nov LeetWars Challenge Badge" },
                    { 12L, "2023-12.png", "2023-12.gif", "Dec LeetWars Challenge Badge" }
                });

            migrationBuilder.InsertData(
                table: "ChallengeLevels",
                columns: new[] { "Id", "Reward", "SkillLevel" },
                values: new object[,]
                {
                    { 1L, 10, 0 },
                    { 2L, 20, 1 },
                    { 3L, 30, 2 },
                    { 4L, 40, 3 }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Javascript" },
                    { 2L, "C#" }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionTypes",
                columns: new[] { "Id", "BillingPeriod", "Cost", "Description", "Name" },
                values: new object[,]
                {
                    { 1L, 0, 136.02m, "Vel necessitatibus est tenetur id id atque sunt ut.", "Cambridgeshire " },
                    { 2L, 1, 151.37m, "Explicabo debitis quia.", "Canyon ADP scal" },
                    { 3L, 0, 91.86m, "Beatae aut est reprehenderit eos nihil perspiciatis enim.", "Qatar complexit" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Arrays" },
                    { 2L, "Algorithms" },
                    { 3L, "Backend" },
                    { 4L, "Async" },
                    { 5L, "AI" },
                    { 6L, "Concurrency" },
                    { 7L, "Filtering" },
                    { 8L, "Fundamentals" },
                    { 9L, "Heaps" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Country", "Email", "FirstName", "ImagePath", "IsBanned", "IsSubscribed", "LastName", "OAuthToken", "RegisteredAt", "Reputation", "Sex", "Status", "Timezone", "TotalScore", "Uid", "UserName" },
                values: new object[,]
                {
                    { 1L, new DateTime(1991, 5, 8, 14, 17, 47, 307, DateTimeKind.Utc).AddTicks(4649), 8, "Josue41@hotmail.com", "Grayson", "wymtrpbcdupodqfwhkxtmnyngfjrqv.jpg", false, true, "Tremblay", "j5xii6spbrvfvasc6b42i4qkxc0xih8e", new DateTime(2016, 5, 20, 9, 6, 15, 81, DateTimeKind.Utc).AddTicks(9320), 4765L, 3, 0, 9, 47657L, "ga8gml413k24v2mnqw01jkbfecl5", "Emmalee_West0" },
                    { 2L, new DateTime(1984, 5, 30, 8, 42, 31, 222, DateTimeKind.Utc).AddTicks(9633), 46, "Amely_Murphy71@hotmail.com", "Ford", "jfplewxzubgazxgkgpkbapjelwlpjj.jpg", true, false, "Reinger", "roqfrnkdcm3m8bgk66qjt1asorug0bea", new DateTime(2016, 4, 11, 1, 27, 23, 967, DateTimeKind.Utc).AddTicks(3028), 7871L, 0, 1, -12, 78712L, "lf9laj4ltu8szec1pvo9vtjpdyqz", "Krystina961" },
                    { 3L, new DateTime(1993, 7, 25, 6, 0, 59, 61, DateTimeKind.Utc).AddTicks(456), 28, "Regan.Larson42@hotmail.com", "Rupert", "uteqdltwogiudurmfofioawoaftbpx.jpg", false, false, "Greenholt", "u5fkzd7d2caxhmyuxb2hmylyvswlmxpo", new DateTime(2017, 11, 13, 4, 14, 26, 317, DateTimeKind.Utc).AddTicks(6176), 5925L, 2, 3, -8, 59257L, "and6djta9thu2lj8l69e03awjho7", "Lula742" },
                    { 4L, new DateTime(1989, 7, 7, 0, 1, 37, 619, DateTimeKind.Utc).AddTicks(4666), 27, "Nelle24@yahoo.com", "Pansy", "rzkqhrfjmqxwpuqbifmzszvswxfwml.jpg", false, true, "Kreiger", "skfyumcicwffr5ljwzkq4jfaio5psdgc", new DateTime(2018, 7, 29, 21, 29, 33, 624, DateTimeKind.Utc).AddTicks(2367), 722L, 2, 2, 12, 7226L, "v1tbfmy0ptukka8n4bz8arb954f5", "Gloria.Langosh793" },
                    { 5L, new DateTime(1995, 6, 17, 22, 37, 8, 128, DateTimeKind.Utc).AddTicks(7960), 18, "Maurice.Thiel45@gmail.com", "Earnestine", "nplkfbdsoeheuobcwcmtmivfsfttzo.jpg", false, true, "Brakus", "9e7py2ak81f0r4s380y8tr8iy6q7o0ae", new DateTime(2017, 8, 18, 11, 18, 32, 801, DateTimeKind.Utc).AddTicks(3978), 252L, 0, 3, -7, 2520L, "q0wwz3l0sbvgbhkqfmzqsqqh5orr", "Dustin.Barrows4" },
                    { 6L, new DateTime(1993, 9, 26, 9, 32, 5, 895, DateTimeKind.Utc).AddTicks(5444), 1, "Onie_Donnelly@hotmail.com", "Simone", "aubaopzgkthivstlqshgunonviwigp.jpg", false, false, "Bradtke", "eha5a9t76e9hs5stl8o391w8th8j77ro", new DateTime(2022, 3, 15, 20, 25, 28, 802, DateTimeKind.Utc).AddTicks(5140), 5794L, 1, 0, 12, 57945L, "0ucs1neglfjvyapdp0qmm5bcl2bt", "Cale.Johns505" },
                    { 7L, new DateTime(1983, 7, 26, 8, 51, 33, 259, DateTimeKind.Utc).AddTicks(9753), 51, "Jordon51@hotmail.com", "Abigail", "uwvemdbwnafziplilofkvtpsguukrm.jpg", false, true, "Sanford", "tjst16gthiilfsssm8s5eytvo094ypcn", new DateTime(2020, 9, 25, 0, 34, 40, 355, DateTimeKind.Utc).AddTicks(1839), 8557L, 1, 3, 7, 85578L, "726o6ik9vl2pv8csxf5jmi1vqx40", "Vance476" },
                    { 8L, new DateTime(1998, 4, 20, 15, 42, 17, 513, DateTimeKind.Utc).AddTicks(1989), 43, "Sydni.Carter66@hotmail.com", "Blanca", "menoubraiygknjoshnavzeuvawcggy.jpg", false, false, "Mueller", "lxoce5d7dtqca6dq54p3mlzmobdpjxxe", new DateTime(2022, 6, 10, 13, 28, 31, 754, DateTimeKind.Utc).AddTicks(7682), 3225L, 2, 2, -2, 32250L, "sdcap6yec2573nvmfapyk5b0y2o3", "Bessie.Paucek7" },
                    { 9L, new DateTime(1995, 4, 25, 0, 45, 14, 388, DateTimeKind.Utc).AddTicks(7786), 2, "Hettie.Runte@yahoo.com", "Arnoldo", "ltgffzvqbiiqmwrrjsiucyujhtuglt.jpg", false, true, "Bahringer", "l7knozeg7whxviqdhbn17pfpxgywyh6k", new DateTime(2021, 12, 15, 20, 42, 50, 681, DateTimeKind.Utc).AddTicks(3466), 9026L, 1, 2, 6, 90265L, "7aq42u6naxifb52alw8hmejvrup7", "Wilbert728" },
                    { 10L, new DateTime(1995, 5, 25, 7, 0, 28, 701, DateTimeKind.Utc).AddTicks(1905), 57, "Zula.Jakubowski67@gmail.com", "Leonardo", "ibgryvtwjfdzqulusklmnzppjqqgst.jpg", false, true, "Haley", "gxtd6gh1ywtx83i5cyueazcw5bgnba6h", new DateTime(2018, 7, 24, 2, 19, 41, 330, DateTimeKind.Utc).AddTicks(5898), 3261L, 3, 2, 4, 32613L, "5mr769myangiolrh28aofaggkw7u", "Mac_Carter279" },
                    { 11L, new DateTime(1995, 4, 5, 8, 18, 27, 362, DateTimeKind.Utc).AddTicks(1964), 26, "Richie_Feeney@yahoo.com", "Enola", "zocanbwdiqgbtzlxuujvdetgeiofvx.jpg", false, true, "Wisozk", "qoma0anm89xg0pp1lwnpq1vqftttt6in", new DateTime(2022, 4, 6, 12, 24, 19, 866, DateTimeKind.Utc).AddTicks(2210), 2778L, 3, 3, -11, 27785L, "bevlfgy696k3wo41k5qnk35pswu6", "Baby.Heller6310" },
                    { 12L, new DateTime(1984, 4, 28, 17, 5, 53, 844, DateTimeKind.Utc).AddTicks(6728), 44, "Jaylon_Schamberger68@yahoo.com", "Beatrice", "tgrlwcfgevnpusljnjqnnglnpscrpf.jpg", false, true, "Mosciski", "z23ipk4lu7xdma3i5r17zf785is5u5zj", new DateTime(2019, 9, 22, 13, 1, 3, 649, DateTimeKind.Utc).AddTicks(7865), 3871L, 3, 3, 5, 38714L, "nytgi90u9wifk5m5f3kcme8kuvc6", "Brad.Walker11" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Country", "Email", "FirstName", "ImagePath", "IsBanned", "IsSubscribed", "LastName", "OAuthToken", "RegisteredAt", "Reputation", "Sex", "Status", "Timezone", "TotalScore", "Uid", "UserName" },
                values: new object[,]
                {
                    { 13L, new DateTime(1990, 12, 2, 11, 48, 22, 614, DateTimeKind.Utc).AddTicks(5448), 10, "Susie.Sauer@gmail.com", "Lorenzo", "xqstoqygsgpqxvbhdvfelyrucsplle.jpg", false, true, "Abshire", "o27c94814kghx80czw3ny3khkyyxnv1h", new DateTime(2021, 3, 20, 13, 28, 24, 887, DateTimeKind.Utc).AddTicks(8398), 9824L, 1, 1, -6, 98246L, "skkjgjkx13onqx0frqqpcs7kiqsb", "Shanon9412" },
                    { 14L, new DateTime(1998, 12, 12, 2, 49, 5, 942, DateTimeKind.Utc).AddTicks(5586), 16, "Hans_Toy94@hotmail.com", "Jazmin", "nexdidajzastgttskdtgqthvhkeeie.jpg", false, false, "Vandervort", "mz5dn5g47un0og6o2ev50qzdbrv3uxyu", new DateTime(2016, 6, 10, 16, 4, 27, 666, DateTimeKind.Utc).AddTicks(5586), 8261L, 1, 1, -6, 82613L, "0teqmv3l99ywll2tmmbsb65vzr1w", "Hollis6013" },
                    { 15L, new DateTime(1996, 6, 14, 0, 11, 22, 542, DateTimeKind.Utc).AddTicks(9487), 35, "Pietro_Bradtke68@hotmail.com", "Imani", "amfpenvrntvvfhxzrzuqfueodmahlc.jpg", false, true, "Beahan", "v0c79w1oqa56jo7d3zzq43z3g99nhpij", new DateTime(2022, 3, 25, 19, 44, 18, 424, DateTimeKind.Utc).AddTicks(5610), 6182L, 1, 0, -12, 61822L, "8fvuhz10y09hg18idrd1bpyr08rz", "Cleo8814" },
                    { 16L, new DateTime(1990, 9, 30, 11, 37, 15, 847, DateTimeKind.Utc).AddTicks(3302), 49, "Josh.Mueller@hotmail.com", "Frankie", "thsimfomcvggbkoufswcdsaxhcixvy.jpg", false, true, "Strosin", "hmbyu4hpaeelpjmvwk8bmtrcv29t1evm", new DateTime(2017, 6, 25, 9, 38, 56, 375, DateTimeKind.Utc).AddTicks(636), 7704L, 2, 2, 10, 77045L, "n6cmw3jfbiegojzh9e6roibouz2r", "Beau_Wiegand1215" },
                    { 17L, new DateTime(1995, 4, 25, 3, 35, 40, 382, DateTimeKind.Utc).AddTicks(8040), 47, "Emily.OReilly@yahoo.com", "Abigail", "uoqfdyewrtyauprvnyxplhgmktwnfg.jpg", true, true, "White", "jbqp132odtsoi80r87caxdrqmia5te2n", new DateTime(2016, 1, 20, 0, 41, 17, 79, DateTimeKind.Utc).AddTicks(574), 1387L, 3, 3, 12, 13879L, "nf8ma2jjrtk3trr0gmho5wb5kz3j", "Peggie.Bailey1116" },
                    { 18L, new DateTime(1999, 7, 7, 14, 33, 58, 925, DateTimeKind.Utc).AddTicks(478), 33, "Maeve_Watsica26@hotmail.com", "Glennie", "sfxkmtdbbizaswzojrtrabdizjkfix.jpg", false, true, "Kozey", "18sj6m3bnayxc56o2n49a9328n2le4cw", new DateTime(2023, 1, 9, 15, 4, 54, 449, DateTimeKind.Utc).AddTicks(4228), 537L, 2, 3, 1, 5371L, "q59q76ocg10gp3pz4baq32ls5qbj", "Cecile_Ortiz1017" },
                    { 19L, new DateTime(1995, 7, 16, 18, 36, 41, 301, DateTimeKind.Utc).AddTicks(6700), 17, "Lisette93@gmail.com", "Immanuel", "blcvqvrompmwetzemnrwocrwktihjo.jpg", false, true, "Kohler", "je5li2tqa8jmgvz0t0t3r3oadzr7evhd", new DateTime(2022, 4, 26, 23, 38, 8, 459, DateTimeKind.Utc).AddTicks(2119), 1743L, 2, 1, -2, 17432L, "6w12qk9wcr8fcxmtvexbgasfpu7i", "Sim_Wolff2318" },
                    { 20L, new DateTime(1998, 8, 9, 4, 58, 20, 690, DateTimeKind.Utc).AddTicks(797), 49, "Delores.Weimann@hotmail.com", "Tanya", "yjayexxdpjwjtptlvremcaycronoup.jpg", false, true, "Grimes", "gxq5d8bgj9ke7jfw1bzl1krz9xdxandc", new DateTime(2020, 12, 25, 22, 5, 42, 459, DateTimeKind.Utc).AddTicks(5392), 2166L, 1, 0, 10, 21660L, "c0wymk8i3d5wxosenri7j6jw5rwg", "Dewayne_Rowe019" },
                    { 21L, new DateTime(1993, 10, 31, 14, 35, 47, 700, DateTimeKind.Utc).AddTicks(3580), 39, "Heidi57@yahoo.com", "Jaydon", "dzgodeuemzuwruqsfgasqptelbcbsw.jpg", false, true, "Grimes", "h9obbv5mrpfwpnofrburg6udyi72222q", new DateTime(2017, 1, 26, 7, 10, 44, 100, DateTimeKind.Utc).AddTicks(6007), 6853L, 0, 2, 5, 68531L, "flij5dfrklgaaqw4i0as7yfafbdt", "Iva.Boyer20" },
                    { 22L, new DateTime(1980, 11, 14, 4, 38, 15, 242, DateTimeKind.Utc).AddTicks(9462), 28, "Mikel21@hotmail.com", "Candelario", "pcobtgomefcvaqcmbtqphuzjtxxcto.jpg", false, true, "Goodwin", "lv858ligye5yxx1fd90qsywhxs37bucf", new DateTime(2018, 5, 8, 7, 53, 56, 295, DateTimeKind.Utc).AddTicks(4070), 7135L, 1, 0, -10, 71355L, "rlm8luehzlt8gbv1bbjn30smyq8f", "Gillian2021" },
                    { 23L, new DateTime(1989, 1, 22, 8, 46, 41, 321, DateTimeKind.Utc).AddTicks(5466), 6, "Carlo61@gmail.com", "Perry", "ybxzisituahwqzarlsftcntnmzuohq.jpg", true, true, "Sipes", "gapmhfd5scdgjahzwwi2qggbiebeibws", new DateTime(2021, 11, 18, 19, 26, 7, 571, DateTimeKind.Utc).AddTicks(2446), 5855L, 3, 2, -1, 58557L, "g6j050hkbaxvdnzg0i3v17v0td32", "Kaci_Stroman22" },
                    { 24L, new DateTime(1999, 8, 18, 11, 6, 17, 868, DateTimeKind.Utc).AddTicks(7529), 18, "Laurie.Wilderman86@yahoo.com", "Javon", "kagatghnfuxkliqmluqqrnremcllmf.jpg", false, true, "Schumm", "f8o9lm8euq18a1z0ift2568r6ub1jotv", new DateTime(2021, 5, 7, 5, 35, 6, 965, DateTimeKind.Utc).AddTicks(4097), 1805L, 0, 3, -8, 18052L, "1ycnq7q080xvlg9n7gk0mf290w2q", "Spencer_Johnson4423" },
                    { 25L, new DateTime(1991, 9, 13, 4, 27, 55, 562, DateTimeKind.Utc).AddTicks(7424), 46, "Evalyn_Crona66@gmail.com", "Eugene", "wccugqxcqvdzrbeuylgyywegivpyar.jpg", false, true, "Greenholt", "rc5nbq25ykelph6p4rygdqhnpzytge0z", new DateTime(2019, 2, 27, 16, 56, 32, 291, DateTimeKind.Utc).AddTicks(4229), 4369L, 0, 2, 1, 43694L, "2y2ru0qfpthoic5o2mpuyka0vhyb", "Elna_Pollich1324" },
                    { 26L, new DateTime(1980, 12, 8, 12, 21, 7, 274, DateTimeKind.Utc).AddTicks(2574), 31, "Deven34@yahoo.com", "Hank", "vgtvseamrbxjckqmdydcvlhrupvkvs.jpg", false, true, "Stanton", "r2clhjhuudf12cih0lw8gbo2iez213cl", new DateTime(2016, 6, 22, 12, 24, 17, 322, DateTimeKind.Utc).AddTicks(1749), 8150L, 1, 3, 6, 81509L, "nyau1hw3092qnsdw6al8il9fe923", "Ayla_Ankunding25" },
                    { 27L, new DateTime(1994, 2, 11, 22, 59, 8, 450, DateTimeKind.Utc).AddTicks(2210), 11, "Trystan.Jacobson8@gmail.com", "Mallie", "xtnccbswltkvoplirwlgwnwboskbel.jpg", false, true, "King", "vd1gh29xpbe67o4v8lqx9jas8evgkenm", new DateTime(2021, 12, 23, 19, 32, 57, 772, DateTimeKind.Utc).AddTicks(1652), 7635L, 3, 1, -4, 76351L, "p0w1s34d2r43vna6wogsb97b2882", "Kali.Pollich1826" },
                    { 28L, new DateTime(1982, 7, 16, 16, 27, 0, 682, DateTimeKind.Utc).AddTicks(6739), 29, "Hester_Dibbert12@yahoo.com", "Ayla", "soxywhlupyoxbehkulcebkvphhzksw.jpg", false, true, "Blanda", "wbnyi8hdsg1e64j9f7k3mrte1aqankc1", new DateTime(2016, 7, 19, 5, 47, 59, 856, DateTimeKind.Utc).AddTicks(8431), 54L, 0, 2, -7, 542L, "3p2783n1wfmm4n8o21vrul94h9w7", "Brock_Kreiger27" },
                    { 29L, new DateTime(1983, 8, 16, 22, 13, 6, 897, DateTimeKind.Utc).AddTicks(8679), 57, "Brant38@gmail.com", "Emory", "bbfprpfnlysyflnsskndjtptaofikb.jpg", false, true, "Bartell", "0b0i5gy4jjts04l233zghqo51aghk4dv", new DateTime(2017, 8, 6, 21, 44, 22, 278, DateTimeKind.Utc).AddTicks(5019), 9380L, 1, 2, -2, 93809L, "3dxeypa2rkuzbkrg5yg4bxlamvhu", "Emilie.Littel28" },
                    { 30L, new DateTime(1985, 8, 16, 8, 34, 58, 912, DateTimeKind.Utc).AddTicks(3608), 44, "Mathilde_Shields@hotmail.com", "Clifford", "ziqrgoeuqubflcgalujwdgyvbikgsk.jpg", false, true, "Cole", "y10bz5xrxejtjf26ctgvfvgmeqetmx4x", new DateTime(2020, 8, 31, 4, 12, 7, 163, DateTimeKind.Utc).AddTicks(1044), 6299L, 0, 0, -12, 62996L, "38t174332ovzabpiruylstz2ldx9", "Hanna_Schmeler8929" },
                    { 31L, new DateTime(1981, 9, 7, 22, 34, 15, 418, DateTimeKind.Utc).AddTicks(2863), 53, "Addison8@hotmail.com", "Aisha", "awbuyndhgtlvfviyowsrokxtwtwlag.jpg", false, true, "Wiza", "142u8w2c1qhg2uk50vzv64rninybw7no", new DateTime(2016, 12, 18, 10, 32, 42, 311, DateTimeKind.Utc).AddTicks(4415), 8185L, 3, 1, 9, 81850L, "90pcrclgv7tz64b25qqzg42wcecl", "Dangelo_Reilly30" },
                    { 32L, new DateTime(1989, 3, 25, 9, 41, 23, 12, DateTimeKind.Utc).AddTicks(2976), 5, "Emerald.Schaefer@hotmail.com", "David", "ixdemrfdyuzjaanctzxjxhyyjbsxdc.jpg", false, true, "Hilpert", "lkxx91ladel24b90m91w8cw4h1x8sfyb", new DateTime(2016, 12, 26, 13, 12, 15, 645, DateTimeKind.Utc).AddTicks(8268), 2620L, 1, 2, 11, 26206L, "zu7fe3rhhflhrv5mocffv8v9otg7", "Maiya.Grady31" },
                    { 33L, new DateTime(1986, 9, 3, 1, 30, 16, 31, DateTimeKind.Utc).AddTicks(8206), 55, "Mustafa_Jast@hotmail.com", "Rogelio", "xiolznmtzytpqnjcyrbnvwmvtwyhvb.jpg", false, true, "Moen", "i9gvbsu2xwsaa630xz6au2dus0tpp4l5", new DateTime(2021, 12, 9, 0, 16, 53, 790, DateTimeKind.Utc).AddTicks(5503), 6313L, 0, 1, 8, 63133L, "xwfh4r7l9vp4pikbqqxy3j7gwl2b", "Kattie.Langosh32" },
                    { 34L, new DateTime(1984, 2, 9, 18, 52, 0, 505, DateTimeKind.Utc).AddTicks(4957), 26, "Faye28@hotmail.com", "Leon", "lnzzfqbjrzpnrxqenxvbdeodvtenng.jpg", false, true, "Tillman", "3ogsvf4dmok0ps0dhvzugge259zu4fhj", new DateTime(2023, 3, 27, 3, 34, 6, 353, DateTimeKind.Utc).AddTicks(7346), 242L, 1, 0, -8, 2422L, "ufvw2w0605a5h4hq3h9ajosn9dmm", "Christ.Sauer33" },
                    { 35L, new DateTime(1995, 5, 4, 12, 34, 2, 318, DateTimeKind.Utc).AddTicks(9374), 46, "Don77@gmail.com", "Betsy", "gtrefaeqfqrhkstycymyfuzerktvnm.jpg", false, true, "Hackett", "ztlu8jkz000mqgmag23c2b33jfrhir9b", new DateTime(2022, 2, 28, 19, 55, 44, 105, DateTimeKind.Utc).AddTicks(7791), 6738L, 0, 1, -7, 67389L, "4pnupkh6c3ygyl2jjdyoq5fnphas", "Kylee_Stoltenberg2834" },
                    { 36L, new DateTime(1994, 1, 23, 3, 43, 9, 490, DateTimeKind.Utc).AddTicks(7686), 56, "Lonie.Conroy22@yahoo.com", "Ophelia", "yduppzhzdfhskgqsthdbstuccvdmhc.jpg", false, true, "Mills", "ccek5cf42iqsmelujrcnwvubh6dphsut", new DateTime(2020, 4, 16, 10, 45, 8, 289, DateTimeKind.Utc).AddTicks(4407), 9212L, 2, 2, -5, 92123L, "p2uyat3aal7mbx4dh8ae4m6hi32y", "Shanie.Marquardt9535" },
                    { 37L, new DateTime(1993, 10, 29, 2, 6, 21, 56, DateTimeKind.Utc).AddTicks(4494), 5, "Margot_Erdman5@gmail.com", "Mackenzie", "afgnlrbxjlftdipzxykvpvvrotchxv.jpg", false, true, "Macejkovic", "a4iwyhds880o77dyhqrbr9kqg6dkxols", new DateTime(2016, 5, 8, 0, 15, 42, 893, DateTimeKind.Utc).AddTicks(6241), 2160L, 3, 3, 1, 21605L, "zj5288c3l4p5twmmbl8cil10jsfr", "Meredith3536" },
                    { 38L, new DateTime(1989, 10, 24, 0, 36, 24, 452, DateTimeKind.Utc).AddTicks(1234), 20, "Kayli_Johns57@yahoo.com", "Elda", "tgilghkndnluoaugempfzpawzyvwkl.jpg", true, true, "Rodriguez", "4ww7cki3exa5wrbgtnxddwabl67hgagi", new DateTime(2018, 12, 27, 1, 25, 4, 41, DateTimeKind.Utc).AddTicks(7402), 7897L, 0, 2, -10, 78973L, "3pdjwdo7q33oxto9ji47y027lkl5", "Diamond_Huel37" },
                    { 39L, new DateTime(1984, 11, 3, 12, 25, 37, 675, DateTimeKind.Utc).AddTicks(4462), 40, "Lela.Howell95@hotmail.com", "Orion", "yyegocqeyiunwrlzfdumwtyrgfjukz.jpg", false, false, "Mann", "6soe4ox78yk7u8nfvyuud80z36zh0cpu", new DateTime(2016, 7, 25, 20, 5, 5, 867, DateTimeKind.Utc).AddTicks(8379), 7353L, 1, 0, 9, 73536L, "rx5zugkr10xtxnxp1sbfykmxroby", "Ila_Windler2938" },
                    { 40L, new DateTime(1994, 2, 19, 7, 53, 27, 731, DateTimeKind.Utc).AddTicks(2229), 46, "Erna43@yahoo.com", "Marjolaine", "ghlfahxfiffedqbpvbpefaqjfxbwug.jpg", false, true, "Metz", "lkmvpf0yvxu8luhfbq06kamv88m30490", new DateTime(2017, 10, 24, 7, 52, 38, 525, DateTimeKind.Utc).AddTicks(400), 8292L, 3, 3, 6, 82925L, "f3mmi9xnlu6ncyfsvrlavlobyrmg", "Hugh7839" }
                });

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "Id", "Category", "CreatedAt", "CreatedBy", "Instructions", "LevelId", "Title" },
                values: new object[,]
                {
                    { 1L, 0, new DateTime(2022, 11, 5, 8, 2, 40, 739, DateTimeKind.Utc).AddTicks(6545), 19L, "Perspiciatis cum et et laudantium.", 1L, "We need to input the online SCSI firewall!" },
                    { 2L, 0, new DateTime(2018, 3, 19, 13, 48, 33, 18, DateTimeKind.Utc).AddTicks(7198), 17L, "quis", 2L, "Use the open-source SMS driver, then you can input" },
                    { 3L, 0, new DateTime(2023, 7, 3, 0, 38, 29, 314, DateTimeKind.Utc).AddTicks(280), 34L, "Aut rerum consectetur veniam distinctio officiis praesentium.\nAperiam quis qui animi omnis.\nMolestiae laboriosam exercitationem similique amet dolores quibusdam aspernatur consequatur quia.\nSuscipit consequuntur eos laborum facilis culpa.", 1L, "If we back up the application, we can get to the G" },
                    { 4L, 0, new DateTime(2022, 3, 15, 3, 53, 41, 641, DateTimeKind.Utc).AddTicks(2353), 20L, "Suscipit quia modi nobis ad eos voluptatum est.", 2L, "Use the haptic JBOD transmitter, then you can hack" },
                    { 5L, 0, new DateTime(2023, 4, 3, 2, 55, 28, 619, DateTimeKind.Utc).AddTicks(7171), 33L, "Voluptatem possimus iure impedit enim provident incidunt molestiae earum.", 2L, "I'll transmit the wireless USB driver, that should" },
                    { 6L, 0, new DateTime(2023, 5, 3, 14, 49, 28, 724, DateTimeKind.Utc).AddTicks(449), 28L, "Distinctio rerum voluptatem aut iure nesciunt aut eos voluptatem molestias. Molestias reprehenderit tenetur hic. Esse repudiandae voluptatem quae impedit sed voluptates ratione minus in.", 3L, "If we parse the feed, we can get to the SSL feed t" },
                    { 7L, 0, new DateTime(2020, 1, 13, 18, 39, 51, 419, DateTimeKind.Utc).AddTicks(6293), 40L, "Molestiae quis nihil similique autem nemo numquam. Et ut ratione vel. Aperiam harum perferendis ad consequuntur.", 1L, "We need to calculate the auxiliary HTTP applicatio" },
                    { 8L, 0, new DateTime(2017, 1, 17, 10, 18, 35, 85, DateTimeKind.Utc).AddTicks(3775), 26L, "et", 2L, "I'll index the back-end RSS driver, that should dr" },
                    { 9L, 0, new DateTime(2019, 12, 12, 9, 19, 4, 345, DateTimeKind.Utc).AddTicks(1559), 3L, "Quas maxime esse et dolores accusamus doloremque in magnam quos.\nSaepe incidunt modi recusandae saepe ut et.\nAccusamus sed maiores doloremque aut et aut praesentium quae.\nQui magni eum autem architecto accusamus dolore inventore expedita.\nEos velit optio asperiores dolores voluptas amet voluptatum deserunt.", 4L, "The SAS pixel is down, hack the mobile pixel so we" },
                    { 10L, 0, new DateTime(2022, 6, 12, 11, 48, 26, 448, DateTimeKind.Utc).AddTicks(9440), 6L, "Doloremque velit maiores unde at commodi.", 3L, "You can't synthesize the firewall without transmit" },
                    { 11L, 0, new DateTime(2018, 1, 16, 17, 48, 29, 466, DateTimeKind.Utc).AddTicks(1766), 40L, "Doloribus eveniet non aut fuga et.", 4L, "Try to calculate the SMTP bus, maybe it will calcu" },
                    { 12L, 0, new DateTime(2022, 8, 21, 21, 43, 49, 957, DateTimeKind.Utc).AddTicks(6778), 40L, "Est molestiae voluptatem eos assumenda et libero voluptatem et.\nAb maxime fuga nemo ad.\nNon illum ut iste ea perspiciatis.", 3L, "The ADP array is down, generate the bluetooth arra" },
                    { 13L, 0, new DateTime(2017, 10, 25, 22, 2, 15, 809, DateTimeKind.Utc).AddTicks(8134), 5L, "iure", 4L, "The SMS driver is down, hack the optical driver so" },
                    { 14L, 0, new DateTime(2022, 10, 25, 20, 52, 18, 304, DateTimeKind.Utc).AddTicks(6053), 30L, "Nostrum sit quia consequatur eos dolorem quo vel libero ut.\nIusto error quia ab.\nAutem quam et quia eum ea molestias eum dolore consequuntur.\nEligendi rerum nisi aspernatur et commodi libero cupiditate.\nMollitia molestias eaque quia dignissimos voluptas porro voluptas.", 3L, "Try to copy the IB program, maybe it will copy the" },
                    { 15L, 0, new DateTime(2018, 7, 18, 5, 52, 32, 99, DateTimeKind.Utc).AddTicks(5710), 5L, "Recusandae molestias id.", 3L, "Use the wireless SDD circuit, then you can navigat" },
                    { 16L, 0, new DateTime(2022, 3, 28, 21, 21, 2, 436, DateTimeKind.Utc).AddTicks(4405), 13L, "Corporis veniam vel et voluptas. Rerum quod facilis est nihil qui et rerum et non. Rerum culpa deserunt adipisci vero iure corporis. Quam odit reprehenderit. Atque cupiditate aut minus minus reprehenderit eos. Ipsam et aut nostrum assumenda explicabo rem.", 1L, "If we bypass the port, we can get to the USB port " },
                    { 17L, 0, new DateTime(2023, 1, 29, 21, 17, 52, 258, DateTimeKind.Utc).AddTicks(9776), 18L, "ratione", 4L, "calculating the panel won't do anything, we need t" },
                    { 18L, 0, new DateTime(2020, 4, 25, 7, 37, 34, 233, DateTimeKind.Utc).AddTicks(5843), 17L, "et", 4L, "If we hack the program, we can get to the PCI prog" },
                    { 19L, 0, new DateTime(2022, 8, 4, 0, 24, 46, 151, DateTimeKind.Utc).AddTicks(5322), 20L, "Sint doloribus sit aut ipsam maiores voluptatum voluptas in.", 3L, "compressing the sensor won't do anything, we need " },
                    { 20L, 0, new DateTime(2022, 4, 13, 6, 50, 57, 847, DateTimeKind.Utc).AddTicks(8297), 38L, "perspiciatis", 2L, "I'll override the redundant AGP card, that should " },
                    { 21L, 0, new DateTime(2022, 12, 9, 21, 28, 16, 172, DateTimeKind.Utc).AddTicks(5294), 23L, "Quisquam cum aut sunt sit suscipit similique voluptatem maxime qui. Quia aut exercitationem est provident enim rerum maiores. Voluptatem aut fugiat sunt exercitationem. Corrupti vitae ea eos enim similique. Fuga et enim ad laboriosam quaerat ut et. Et sed dolorum sunt quisquam incidunt et explicabo et.", 4L, "Use the open-source EXE array, then you can connec" },
                    { 22L, 0, new DateTime(2022, 10, 8, 7, 31, 31, 700, DateTimeKind.Utc).AddTicks(4248), 2L, "Id consequuntur nesciunt laudantium quaerat et suscipit quaerat recusandae nobis. Id corrupti vitae. Hic quisquam cumque aliquam qui. Quasi porro quisquam dicta voluptatibus.", 2L, "The IB transmitter is down, quantify the optical t" },
                    { 23L, 0, new DateTime(2023, 9, 4, 9, 12, 38, 455, DateTimeKind.Utc).AddTicks(3170), 35L, "Odit laudantium quibusdam nostrum fugiat dolores.", 4L, "Use the back-end SMTP bus, then you can override t" },
                    { 24L, 0, new DateTime(2021, 8, 20, 6, 34, 34, 30, DateTimeKind.Utc).AddTicks(8204), 20L, "Sed voluptate iusto vel ad ea voluptates iure.\nAccusantium saepe iusto dolorum necessitatibus necessitatibus.", 3L, "We need to reboot the haptic USB protocol!" },
                    { 25L, 0, new DateTime(2022, 11, 16, 23, 36, 11, 736, DateTimeKind.Utc).AddTicks(664), 11L, "eum", 4L, "You can't reboot the bus without parsing the redun" },
                    { 26L, 0, new DateTime(2023, 1, 17, 1, 19, 34, 62, DateTimeKind.Utc).AddTicks(4843), 18L, "Amet qui vel dignissimos maxime quo recusandae provident. Accusamus expedita delectus praesentium nam dolores accusamus. Mollitia iste unde voluptatem.", 1L, "You can't calculate the program without hacking th" },
                    { 27L, 0, new DateTime(2022, 5, 23, 5, 59, 9, 13, DateTimeKind.Utc).AddTicks(6512), 19L, "necessitatibus", 4L, "I'll index the open-source JSON card, that should " },
                    { 28L, 0, new DateTime(2022, 2, 22, 16, 43, 28, 857, DateTimeKind.Utc).AddTicks(7613), 23L, "Modi blanditiis aut sunt qui ut.\nVeritatis dignissimos deleniti.\nQuod ut aliquid voluptatum dolorem error.", 1L, "If we parse the driver, we can get to the PNG driv" },
                    { 29L, 0, new DateTime(2020, 8, 2, 16, 50, 12, 957, DateTimeKind.Utc).AddTicks(9272), 17L, "numquam", 3L, "The PNG pixel is down, bypass the haptic pixel so " },
                    { 30L, 0, new DateTime(2017, 7, 3, 20, 53, 39, 851, DateTimeKind.Utc).AddTicks(2746), 2L, "ut", 2L, "The GB firewall is down, reboot the 1080p firewall" },
                    { 31L, 0, new DateTime(2023, 1, 22, 2, 38, 24, 366, DateTimeKind.Utc).AddTicks(6718), 19L, "Eum ea sequi voluptas praesentium hic.\nVoluptatum voluptatem dolor consequatur distinctio et.\nAutem officia ut unde delectus repudiandae eum animi consectetur omnis.", 2L, "You can't index the transmitter without compressin" },
                    { 32L, 0, new DateTime(2023, 8, 20, 5, 17, 13, 593, DateTimeKind.Utc).AddTicks(4101), 13L, "quia", 4L, "We need to back up the virtual SQL feed!" },
                    { 33L, 0, new DateTime(2022, 9, 23, 16, 2, 58, 439, DateTimeKind.Utc).AddTicks(5314), 9L, "Sunt et est aliquam aut unde blanditiis.\nRepellendus dolorem autem.\nEos nihil veniam quia ipsa.\nOdit fuga illum nobis voluptatum deserunt in.", 2L, "Try to program the COM alarm, maybe it will progra" },
                    { 34L, 0, new DateTime(2022, 10, 2, 8, 7, 39, 449, DateTimeKind.Utc).AddTicks(3613), 7L, "Culpa voluptatem est sequi in sit quam.", 3L, "The XSS matrix is down, transmit the cross-platfor" },
                    { 35L, 0, new DateTime(2023, 5, 23, 8, 41, 18, 997, DateTimeKind.Utc).AddTicks(3826), 34L, "Quisquam voluptate sequi magni soluta soluta qui voluptatem reprehenderit quo.", 1L, "We need to navigate the digital RAM pixel!" },
                    { 36L, 0, new DateTime(2021, 6, 9, 16, 12, 32, 586, DateTimeKind.Utc).AddTicks(395), 4L, "Voluptatem quia ut ut doloribus ut et ratione suscipit. Est sunt veritatis. Quis ducimus laboriosam.", 1L, "Try to input the JBOD driver, maybe it will input " },
                    { 37L, 0, new DateTime(2021, 10, 6, 22, 18, 3, 221, DateTimeKind.Utc).AddTicks(3642), 38L, "iusto", 3L, "The COM array is down, program the virtual array s" },
                    { 38L, 0, new DateTime(2022, 6, 29, 23, 52, 38, 908, DateTimeKind.Utc).AddTicks(7241), 6L, "Omnis et et eum eum tempora nostrum a iure voluptatem. Expedita itaque quos quia soluta repellat quas perspiciatis. Sed consequatur numquam maxime. Enim quaerat ratione rerum sed quis. Ea dolores dolor eum vitae dolores vitae.", 3L, "Use the solid state IB transmitter, then you can h" },
                    { 39L, 0, new DateTime(2022, 2, 22, 18, 48, 28, 539, DateTimeKind.Utc).AddTicks(5909), 13L, "Expedita labore omnis omnis delectus doloremque possimus esse fugit.\nQui quasi pariatur et sed aliquam aut quo temporibus animi.\nNihil esse similique molestiae voluptas molestiae eum.\nImpedit et in nihil nihil et.", 4L, "If we navigate the hard drive, we can get to the P" },
                    { 40L, 0, new DateTime(2023, 1, 26, 9, 24, 12, 834, DateTimeKind.Utc).AddTicks(3940), 27L, "Adipisci sint quibusdam.", 4L, "bypassing the matrix won't do anything, we need to" },
                    { 41L, 0, new DateTime(2021, 12, 11, 4, 58, 3, 729, DateTimeKind.Utc).AddTicks(2718), 23L, "Non non ea ab maxime est ratione. Et voluptate iusto ut. Minima nihil qui quaerat ratione aut.", 3L, "I'll parse the virtual SCSI transmitter, that shou" },
                    { 42L, 0, new DateTime(2023, 2, 16, 20, 56, 38, 650, DateTimeKind.Utc).AddTicks(1053), 23L, "Eos provident laborum placeat reprehenderit voluptatem.", 1L, "indexing the hard drive won't do anything, we need" }
                });

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "Id", "Category", "CreatedAt", "CreatedBy", "Instructions", "LevelId", "Title" },
                values: new object[,]
                {
                    { 43L, 0, new DateTime(2023, 9, 3, 23, 49, 21, 196, DateTimeKind.Utc).AddTicks(6389), 23L, "Et dolor error quo doloremque harum explicabo.\nSed qui facere corporis sunt omnis voluptas corporis perspiciatis ut.\nEst rerum ad necessitatibus voluptatem.\nLaboriosam cupiditate dolorem eaque perspiciatis et.", 4L, "You can't copy the port without parsing the wirele" },
                    { 44L, 0, new DateTime(2019, 2, 12, 17, 15, 56, 423, DateTimeKind.Utc).AddTicks(4930), 21L, "Aut ex quis.\nEnim nulla eligendi est quam iusto.\nCumque harum saepe velit consequatur eligendi odit ut vero.\nDolorem sit vel sed nemo modi consequatur.", 2L, "You can't parse the firewall without backing up th" },
                    { 45L, 0, new DateTime(2022, 12, 17, 22, 43, 3, 699, DateTimeKind.Utc).AddTicks(2996), 35L, "Ut qui non dolores sunt enim fugiat quisquam cupiditate distinctio. Officiis reprehenderit quidem qui quis quia asperiores quaerat sapiente. Quia quia voluptatem magni et enim iure. Dolorum ut minus.", 2L, "If we bypass the transmitter, we can get to the AI" },
                    { 46L, 0, new DateTime(2022, 6, 7, 15, 26, 0, 210, DateTimeKind.Utc).AddTicks(3789), 7L, "Officia iusto rerum placeat temporibus corrupti et aut cumque.\nCommodi voluptatem laborum amet consequatur.\nA ducimus est ut reprehenderit.\nSit odit consequuntur.\nTempore magni nihil velit quos sed deleniti aliquid.\nEligendi nesciunt error mollitia et consequatur.", 1L, "compressing the bus won't do anything, we need to " },
                    { 47L, 0, new DateTime(2020, 11, 15, 12, 19, 56, 106, DateTimeKind.Utc).AddTicks(1532), 10L, "Earum laudantium molestias quam sed fuga explicabo vel corrupti in. Quibusdam et ut voluptatem facere. Magni qui pariatur reiciendis eveniet.", 1L, "I'll parse the back-end XML protocol, that should " },
                    { 48L, 0, new DateTime(2023, 1, 15, 1, 26, 52, 86, DateTimeKind.Utc).AddTicks(5887), 15L, "Sed rerum molestiae ad.\nItaque quas vel sint voluptas maxime assumenda.\nHic debitis tempore minus et quos quia repudiandae.\nUt laudantium ut.", 4L, "We need to synthesize the haptic THX bandwidth!" },
                    { 49L, 0, new DateTime(2023, 6, 26, 13, 24, 32, 782, DateTimeKind.Utc).AddTicks(1764), 34L, "vel", 1L, "Use the wireless AI card, then you can back up the" },
                    { 50L, 0, new DateTime(2023, 4, 3, 16, 57, 33, 525, DateTimeKind.Utc).AddTicks(6783), 34L, "Cum in ex nulla doloremque nostrum nemo quos.\nLaudantium corporis ut hic sapiente dolore sed architecto.\nIusto expedita rerum et pariatur optio ex aperiam dolorem placeat.\nAssumenda nesciunt nostrum pariatur corporis et doloribus quae.", 3L, "You can't copy the sensor without navigating the d" },
                    { 51L, 0, new DateTime(2022, 8, 31, 8, 19, 49, 648, DateTimeKind.Utc).AddTicks(8771), 38L, "Voluptatem iure quia labore pariatur id quia qui expedita quos.\nLaudantium natus dolorem rerum nemo perferendis quam est explicabo aliquam.\nIncidunt et qui.", 2L, "The XML monitor is down, compress the 1080p monito" },
                    { 52L, 0, new DateTime(2022, 2, 9, 3, 51, 44, 402, DateTimeKind.Utc).AddTicks(2123), 16L, "Fugiat illo alias error eligendi voluptatem.", 2L, "You can't transmit the system without connecting t" },
                    { 53L, 0, new DateTime(2019, 4, 17, 9, 15, 27, 83, DateTimeKind.Utc).AddTicks(5849), 29L, "Distinctio adipisci sequi vitae nulla. Corporis in labore nobis vel laudantium accusantium minus nihil quas. Sapiente quam vitae ea asperiores cum. Et illum temporibus placeat itaque et aliquam nostrum tempore ratione. Quia modi facere quia. Quaerat nostrum voluptatem.", 4L, "Use the wireless GB protocol, then you can synthes" },
                    { 54L, 0, new DateTime(2022, 2, 4, 17, 34, 14, 274, DateTimeKind.Utc).AddTicks(4141), 33L, "Necessitatibus libero sint ad culpa accusantium sed omnis praesentium.", 2L, "Use the open-source ADP pixel, then you can input " },
                    { 55L, 0, new DateTime(2022, 10, 2, 13, 5, 6, 106, DateTimeKind.Utc).AddTicks(5315), 31L, "Aut ut ut voluptates tempora ut commodi quos id. Dolores rerum eveniet quaerat dolores eligendi hic ipsum sit. Impedit fugiat numquam ad rerum atque tempore vero ipsa ab. Consequatur vitae hic omnis cumque perspiciatis consequatur ex omnis.", 1L, "overriding the port won't do anything, we need to " },
                    { 56L, 0, new DateTime(2018, 4, 26, 7, 14, 26, 181, DateTimeKind.Utc).AddTicks(3733), 26L, "Sunt ut fugit minima facere optio accusantium.\nDeserunt molestias ducimus omnis voluptatibus quos aut rerum.\nQuibusdam ratione qui illum quam modi.", 4L, "I'll bypass the digital XSS pixel, that should pix" },
                    { 57L, 0, new DateTime(2022, 6, 17, 6, 20, 5, 480, DateTimeKind.Utc).AddTicks(1928), 15L, "Minus quo dolores rerum pariatur nisi.\nDolorem dolore laborum corporis reiciendis dignissimos in.\nEos enim vel placeat minus voluptatem consequuntur totam corporis et.", 2L, "Try to generate the SMTP application, maybe it wil" },
                    { 58L, 0, new DateTime(2019, 7, 25, 3, 39, 1, 771, DateTimeKind.Utc).AddTicks(3937), 40L, "aut", 4L, "Use the solid state SMS alarm, then you can bypass" },
                    { 59L, 0, new DateTime(2023, 1, 28, 14, 48, 0, 116, DateTimeKind.Utc).AddTicks(4622), 8L, "Veniam rerum repudiandae sint eos delectus qui veniam id consequatur.", 2L, "We need to synthesize the open-source CSS driver!" },
                    { 60L, 0, new DateTime(2019, 3, 2, 0, 11, 3, 509, DateTimeKind.Utc).AddTicks(4661), 22L, "Quia fugiat voluptatem nihil vitae molestias.", 4L, "I'll connect the bluetooth RSS feed, that should f" },
                    { 61L, 0, new DateTime(2023, 5, 9, 2, 10, 49, 784, DateTimeKind.Utc).AddTicks(7241), 2L, "Accusamus beatae omnis totam maxime autem in et et.\nEt ducimus ea quia a excepturi a aut.\nExplicabo illo blanditiis illo eum qui itaque natus modi.", 4L, "You can't generate the protocol without indexing t" },
                    { 62L, 0, new DateTime(2022, 10, 14, 20, 27, 40, 828, DateTimeKind.Utc).AddTicks(6276), 13L, "Voluptatem veniam ut autem enim. Architecto nihil ut rerum aut nihil eos aut. Esse voluptatem reprehenderit perferendis aut ut dolor voluptas.", 4L, "If we quantify the program, we can get to the FTP " },
                    { 63L, 0, new DateTime(2020, 10, 23, 13, 55, 35, 353, DateTimeKind.Utc).AddTicks(3042), 26L, "Est consectetur voluptatem.\nPlaceat et eos.\nSunt quo et qui eius qui dolor numquam numquam nulla.\nSed nulla sint delectus alias.", 3L, "If we bypass the circuit, we can get to the RSS ci" },
                    { 64L, 0, new DateTime(2019, 12, 27, 8, 8, 20, 733, DateTimeKind.Utc).AddTicks(3269), 10L, "ut", 4L, "parsing the matrix won't do anything, we need to c" },
                    { 65L, 0, new DateTime(2021, 5, 27, 14, 33, 20, 235, DateTimeKind.Utc).AddTicks(9572), 24L, "Suscipit iusto quas est quaerat molestiae nostrum tempora aliquam tempora.\nRem dolorem ut voluptas voluptate.\nQuo magnam eligendi.\nIpsum tenetur praesentium earum.", 2L, "Try to connect the XSS feed, maybe it will connect" },
                    { 66L, 0, new DateTime(2021, 12, 9, 11, 17, 0, 735, DateTimeKind.Utc).AddTicks(8493), 33L, "Quae aliquid quod error nesciunt.", 3L, "Use the online IB panel, then you can synthesize t" },
                    { 67L, 0, new DateTime(2022, 12, 18, 11, 4, 10, 997, DateTimeKind.Utc).AddTicks(8079), 39L, "Autem est neque deleniti quae.\nCum vitae ut id voluptate est aut enim.\nAlias tenetur commodi cumque explicabo est.\nCommodi blanditiis tenetur sapiente dolores atque tempore.\nAut modi officiis neque consequatur.", 1L, "You can't transmit the application without quantif" },
                    { 68L, 0, new DateTime(2023, 1, 24, 15, 12, 42, 211, DateTimeKind.Utc).AddTicks(6859), 19L, "Est dolores id tempore vel.", 4L, "If we override the circuit, we can get to the HDD " },
                    { 69L, 0, new DateTime(2022, 10, 6, 8, 5, 22, 227, DateTimeKind.Utc).AddTicks(1157), 7L, "Aut quibusdam amet at facilis rerum.\nUt veritatis commodi aspernatur doloremque quia quidem.", 1L, "Use the cross-platform AGP firewall, then you can " },
                    { 70L, 0, new DateTime(2022, 10, 5, 1, 57, 32, 95, DateTimeKind.Utc).AddTicks(1581), 37L, "Natus aut officia qui consequatur.", 4L, "Try to navigate the THX system, maybe it will navi" }
                });

            migrationBuilder.InsertData(
                table: "LanguageVersions",
                columns: new[] { "Id", "LanguageId", "Version" },
                values: new object[,]
                {
                    { 1L, 2L, "8.5.4.4" },
                    { 2L, 2L, "1.0.9.1" },
                    { 3L, 1L, "9.6.6.2" },
                    { 4L, 2L, "8.4.6.6" },
                    { 5L, 1L, "4.5.3.5" },
                    { 6L, 2L, "4.7.8.1" },
                    { 7L, 2L, "2.0.6.1" },
                    { 8L, 2L, "5.1.4.6" },
                    { 9L, 2L, "7.6.7.5" }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "Cost", "EndDate", "IsActive", "PaymentSubscriptionId", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate", "UserId" },
                values: new object[,]
                {
                    { 1L, 151.37m, new DateTime(2023, 11, 1, 13, 30, 40, 477, DateTimeKind.Utc).AddTicks(1895), false, "2umhqjy0f1gdzhf2", new DateTime(2023, 7, 30, 22, 21, 13, 718, DateTimeKind.Utc).AddTicks(978), new DateTime(2022, 8, 24, 22, 30, 57, 298, DateTimeKind.Utc).AddTicks(6258), 2L, new DateTime(2023, 8, 2, 6, 8, 27, 246, DateTimeKind.Utc).AddTicks(4545), 27L },
                    { 2L, 136.02m, new DateTime(2024, 2, 29, 18, 21, 13, 309, DateTimeKind.Utc).AddTicks(9227), true, "6iotvwd2kcauexpx", new DateTime(2023, 8, 11, 8, 59, 18, 185, DateTimeKind.Utc).AddTicks(5175), new DateTime(2023, 2, 2, 6, 27, 12, 86, DateTimeKind.Utc).AddTicks(1928), 1L, new DateTime(2023, 2, 18, 3, 14, 19, 281, DateTimeKind.Utc).AddTicks(1806), 20L },
                    { 3L, 151.37m, new DateTime(2023, 10, 21, 9, 16, 15, 628, DateTimeKind.Utc).AddTicks(3340), false, "uo2s583680b8v54j", new DateTime(2023, 8, 9, 4, 23, 42, 862, DateTimeKind.Utc).AddTicks(2575), new DateTime(2023, 5, 22, 8, 11, 20, 783, DateTimeKind.Utc).AddTicks(2984), 2L, new DateTime(2023, 8, 2, 12, 39, 57, 206, DateTimeKind.Utc).AddTicks(139), 27L },
                    { 4L, 136.02m, new DateTime(2023, 1, 24, 0, 44, 23, 554, DateTimeKind.Utc).AddTicks(3476), true, "nfd23s23e9y7ukxb", new DateTime(2022, 6, 11, 12, 40, 45, 91, DateTimeKind.Utc).AddTicks(6620), new DateTime(2021, 8, 10, 16, 52, 43, 875, DateTimeKind.Utc).AddTicks(5873), 1L, new DateTime(2022, 8, 23, 11, 13, 6, 221, DateTimeKind.Utc).AddTicks(5723), 10L },
                    { 5L, 136.02m, new DateTime(2023, 7, 23, 21, 21, 22, 863, DateTimeKind.Utc).AddTicks(6372), true, "28569h790c5pv13g", new DateTime(2023, 5, 18, 20, 26, 56, 56, DateTimeKind.Utc).AddTicks(4908), new DateTime(2022, 11, 10, 0, 52, 53, 195, DateTimeKind.Utc).AddTicks(8224), 1L, new DateTime(2023, 8, 27, 3, 52, 38, 148, DateTimeKind.Utc).AddTicks(8044), 38L }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "Cost", "EndDate", "IsActive", "PaymentSubscriptionId", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate", "UserId" },
                values: new object[,]
                {
                    { 6L, 91.86m, new DateTime(2021, 9, 22, 6, 6, 47, 245, DateTimeKind.Utc).AddTicks(4198), true, "fhe3z935d1zvmvux", new DateTime(2021, 4, 19, 13, 18, 35, 998, DateTimeKind.Utc).AddTicks(9670), new DateTime(2018, 12, 21, 8, 28, 28, 135, DateTimeKind.Utc).AddTicks(67), 3L, new DateTime(2020, 1, 4, 21, 14, 0, 461, DateTimeKind.Utc).AddTicks(5430), 3L },
                    { 7L, 136.02m, new DateTime(2023, 3, 5, 20, 20, 15, 415, DateTimeKind.Utc).AddTicks(8170), true, "04gfoh55j2qr239q", new DateTime(2023, 2, 10, 7, 45, 45, 695, DateTimeKind.Utc).AddTicks(1775), new DateTime(2020, 4, 29, 17, 52, 39, 267, DateTimeKind.Utc).AddTicks(8200), 1L, new DateTime(2021, 1, 31, 20, 36, 6, 653, DateTimeKind.Utc).AddTicks(5360), 10L },
                    { 8L, 91.86m, new DateTime(2022, 10, 28, 0, 46, 4, 535, DateTimeKind.Utc).AddTicks(716), false, "cvjhq7n8273vtohw", new DateTime(2022, 9, 5, 18, 47, 9, 192, DateTimeKind.Utc).AddTicks(7676), new DateTime(2021, 5, 15, 7, 0, 17, 272, DateTimeKind.Utc).AddTicks(1624), 3L, new DateTime(2021, 7, 26, 20, 56, 8, 435, DateTimeKind.Utc).AddTicks(2466), 36L },
                    { 9L, 151.37m, new DateTime(2024, 6, 6, 23, 40, 29, 394, DateTimeKind.Utc).AddTicks(7412), false, "ff9fvm4sae2sxofc", new DateTime(2023, 6, 7, 22, 40, 46, 757, DateTimeKind.Utc).AddTicks(406), new DateTime(2021, 6, 10, 21, 24, 6, 598, DateTimeKind.Utc).AddTicks(3125), 2L, new DateTime(2022, 5, 11, 23, 40, 19, 91, DateTimeKind.Utc).AddTicks(3606), 17L },
                    { 10L, 136.02m, new DateTime(2022, 11, 15, 21, 48, 14, 447, DateTimeKind.Utc).AddTicks(8206), true, "igx8w9w90k1ay8cf", new DateTime(2022, 3, 31, 2, 13, 52, 877, DateTimeKind.Utc).AddTicks(5711), new DateTime(2021, 3, 22, 1, 46, 37, 643, DateTimeKind.Utc).AddTicks(7527), 1L, new DateTime(2022, 12, 15, 19, 46, 10, 668, DateTimeKind.Utc).AddTicks(5673), 3L },
                    { 11L, 91.86m, new DateTime(2023, 12, 9, 23, 49, 0, 697, DateTimeKind.Utc).AddTicks(5838), true, "dy4mdzy1ipwfpvv0", new DateTime(2023, 4, 21, 17, 53, 5, 376, DateTimeKind.Utc).AddTicks(2708), new DateTime(2023, 1, 24, 7, 32, 57, 181, DateTimeKind.Utc).AddTicks(7301), 3L, new DateTime(2023, 2, 27, 23, 33, 3, 192, DateTimeKind.Utc).AddTicks(76), 20L },
                    { 12L, 136.02m, new DateTime(2023, 4, 29, 12, 40, 18, 996, DateTimeKind.Utc).AddTicks(198), true, "69sotjwthpvx4aw1", new DateTime(2022, 12, 27, 17, 58, 15, 87, DateTimeKind.Utc).AddTicks(1275), new DateTime(2022, 10, 2, 10, 2, 55, 332, DateTimeKind.Utc).AddTicks(9849), 1L, new DateTime(2023, 8, 24, 12, 32, 18, 315, DateTimeKind.Utc).AddTicks(2445), 25L },
                    { 13L, 136.02m, new DateTime(2023, 9, 30, 20, 29, 14, 62, DateTimeKind.Utc).AddTicks(3853), true, "gjxuxll8kyg46a7z", new DateTime(2023, 9, 21, 22, 55, 15, 748, DateTimeKind.Utc).AddTicks(9633), new DateTime(2023, 4, 30, 3, 53, 37, 567, DateTimeKind.Utc).AddTicks(5819), 1L, new DateTime(2023, 9, 12, 15, 28, 39, 729, DateTimeKind.Utc).AddTicks(1420), 32L },
                    { 14L, 151.37m, new DateTime(2021, 6, 1, 13, 35, 26, 457, DateTimeKind.Utc).AddTicks(860), true, "wprmc5u9im89l2ww", new DateTime(2020, 8, 3, 22, 43, 20, 39, DateTimeKind.Utc).AddTicks(5658), new DateTime(2019, 11, 18, 22, 56, 36, 509, DateTimeKind.Utc).AddTicks(6065), 2L, new DateTime(2022, 11, 5, 4, 4, 24, 513, DateTimeKind.Utc).AddTicks(6964), 5L },
                    { 15L, 136.02m, new DateTime(2022, 9, 14, 8, 35, 3, 887, DateTimeKind.Utc).AddTicks(5068), false, "stg9zq5iopx7uyvf", new DateTime(2022, 8, 24, 17, 38, 56, 717, DateTimeKind.Utc).AddTicks(4400), new DateTime(2021, 4, 9, 13, 17, 27, 192, DateTimeKind.Utc).AddTicks(9230), 1L, new DateTime(2023, 7, 20, 1, 35, 43, 823, DateTimeKind.Utc).AddTicks(5076), 5L },
                    { 16L, 91.86m, new DateTime(2023, 10, 21, 22, 38, 30, 989, DateTimeKind.Utc).AddTicks(138), true, "61vekpd4uftjpk9r", new DateTime(2023, 9, 1, 14, 46, 1, 610, DateTimeKind.Utc).AddTicks(6830), new DateTime(2023, 3, 1, 14, 37, 56, 546, DateTimeKind.Utc).AddTicks(574), 3L, null, 19L },
                    { 17L, 91.86m, new DateTime(2021, 2, 1, 21, 0, 0, 694, DateTimeKind.Utc).AddTicks(5779), false, "qy2m6a9vgq3xvryz", new DateTime(2020, 12, 12, 19, 35, 51, 928, DateTimeKind.Utc).AddTicks(2367), new DateTime(2019, 1, 23, 14, 36, 17, 167, DateTimeKind.Utc).AddTicks(2941), 3L, new DateTime(2020, 8, 28, 2, 56, 47, 627, DateTimeKind.Utc).AddTicks(2803), 14L },
                    { 18L, 91.86m, new DateTime(2024, 2, 3, 9, 37, 4, 596, DateTimeKind.Utc).AddTicks(3785), false, "xt3cbgkhzqommryk", new DateTime(2023, 8, 14, 18, 59, 57, 133, DateTimeKind.Utc).AddTicks(7494), new DateTime(2021, 1, 2, 5, 51, 46, 824, DateTimeKind.Utc).AddTicks(2531), 3L, new DateTime(2021, 12, 10, 21, 27, 19, 982, DateTimeKind.Utc).AddTicks(13), 7L },
                    { 19L, 151.37m, new DateTime(2023, 8, 17, 21, 33, 25, 480, DateTimeKind.Utc).AddTicks(5603), false, "rmkbbn0e8joc7xjz", new DateTime(2023, 7, 16, 22, 58, 27, 895, DateTimeKind.Utc).AddTicks(9366), new DateTime(2023, 7, 6, 5, 22, 58, 635, DateTimeKind.Utc).AddTicks(9376), 2L, new DateTime(2023, 8, 1, 18, 29, 51, 182, DateTimeKind.Utc).AddTicks(1686), 7L },
                    { 20L, 136.02m, new DateTime(2020, 4, 1, 17, 22, 34, 866, DateTimeKind.Utc).AddTicks(4507), true, "us879r2lwdkpw85c", new DateTime(2020, 3, 4, 9, 11, 57, 971, DateTimeKind.Utc).AddTicks(4271), new DateTime(2019, 12, 3, 1, 41, 29, 292, DateTimeKind.Utc).AddTicks(520), 1L, new DateTime(2022, 3, 20, 23, 27, 35, 803, DateTimeKind.Utc).AddTicks(8053), 29L },
                    { 21L, 136.02m, new DateTime(2023, 10, 17, 22, 9, 51, 824, DateTimeKind.Utc).AddTicks(8913), false, "e3suermf9zhiet5h", new DateTime(2023, 6, 11, 0, 22, 47, 827, DateTimeKind.Utc).AddTicks(1367), new DateTime(2022, 3, 13, 4, 0, 52, 495, DateTimeKind.Utc).AddTicks(7371), 1L, new DateTime(2023, 6, 28, 4, 1, 5, 825, DateTimeKind.Utc).AddTicks(6769), 20L },
                    { 22L, 136.02m, new DateTime(2024, 2, 22, 7, 41, 56, 789, DateTimeKind.Utc).AddTicks(9300), false, "gkftyah9gzs5y764", new DateTime(2023, 5, 14, 12, 24, 56, 123, DateTimeKind.Utc).AddTicks(3893), new DateTime(2019, 12, 21, 4, 43, 48, 191, DateTimeKind.Utc).AddTicks(5459), 1L, new DateTime(2022, 5, 24, 0, 27, 49, 776, DateTimeKind.Utc).AddTicks(937), 31L },
                    { 23L, 136.02m, new DateTime(2020, 4, 2, 2, 57, 14, 296, DateTimeKind.Utc).AddTicks(3811), true, "4wkz5jwj0veuctgy", new DateTime(2020, 3, 27, 16, 33, 52, 362, DateTimeKind.Utc).AddTicks(6415), new DateTime(2017, 7, 22, 1, 54, 49, 417, DateTimeKind.Utc).AddTicks(4862), 1L, new DateTime(2023, 9, 11, 22, 13, 40, 892, DateTimeKind.Utc).AddTicks(2127), 21L },
                    { 24L, 136.02m, new DateTime(2020, 5, 29, 2, 13, 58, 774, DateTimeKind.Utc).AddTicks(4830), false, "xb17e65tmjo2pi3w", new DateTime(2019, 8, 7, 14, 44, 43, 785, DateTimeKind.Utc).AddTicks(5386), new DateTime(2019, 4, 5, 2, 31, 57, 495, DateTimeKind.Utc).AddTicks(6530), 1L, new DateTime(2020, 9, 25, 22, 1, 45, 593, DateTimeKind.Utc).AddTicks(8370), 4L },
                    { 25L, 151.37m, new DateTime(2023, 5, 30, 15, 3, 15, 384, DateTimeKind.Utc).AddTicks(8626), false, "ohejkiv4da2uho5t", new DateTime(2023, 4, 15, 13, 40, 30, 779, DateTimeKind.Utc).AddTicks(4410), new DateTime(2021, 4, 20, 5, 15, 13, 343, DateTimeKind.Utc).AddTicks(8406), 2L, new DateTime(2022, 4, 18, 23, 23, 42, 656, DateTimeKind.Utc).AddTicks(1685), 30L },
                    { 26L, 151.37m, new DateTime(2023, 11, 5, 19, 50, 43, 382, DateTimeKind.Utc).AddTicks(8246), true, "46crvfhli3jxsl84", new DateTime(2023, 5, 26, 15, 42, 44, 401, DateTimeKind.Utc).AddTicks(4017), new DateTime(2023, 2, 23, 18, 18, 9, 18, DateTimeKind.Utc).AddTicks(6457), 2L, new DateTime(2023, 4, 14, 0, 32, 39, 791, DateTimeKind.Utc).AddTicks(8184), 27L },
                    { 27L, 151.37m, new DateTime(2023, 3, 3, 20, 1, 32, 61, DateTimeKind.Utc).AddTicks(6793), true, "3ab74yu98efe549y", new DateTime(2023, 1, 5, 6, 13, 47, 306, DateTimeKind.Utc).AddTicks(6590), new DateTime(2022, 7, 14, 16, 39, 27, 932, DateTimeKind.Utc).AddTicks(700), 2L, null, 33L },
                    { 28L, 136.02m, new DateTime(2023, 8, 7, 13, 4, 50, 739, DateTimeKind.Utc).AddTicks(1096), false, "c26kqtjwrynk39gj", new DateTime(2023, 6, 7, 7, 12, 19, 398, DateTimeKind.Utc).AddTicks(9474), new DateTime(2023, 4, 6, 1, 26, 50, 138, DateTimeKind.Utc).AddTicks(9745), 1L, new DateTime(2023, 8, 24, 22, 9, 2, 404, DateTimeKind.Utc).AddTicks(3940), 11L },
                    { 29L, 151.37m, new DateTime(2023, 10, 3, 12, 43, 38, 663, DateTimeKind.Utc).AddTicks(4353), false, "aqmyw08v96v1s9if", new DateTime(2023, 4, 15, 1, 28, 24, 83, DateTimeKind.Utc).AddTicks(5317), new DateTime(2023, 3, 8, 4, 20, 53, 169, DateTimeKind.Utc).AddTicks(5379), 2L, new DateTime(2023, 7, 27, 1, 5, 11, 632, DateTimeKind.Utc).AddTicks(7883), 35L },
                    { 30L, 91.86m, new DateTime(2023, 12, 23, 5, 9, 34, 679, DateTimeKind.Utc).AddTicks(6176), false, "0s5wjozi3ma06kzq", new DateTime(2023, 8, 1, 5, 51, 29, 880, DateTimeKind.Utc).AddTicks(7016), new DateTime(2021, 8, 13, 23, 5, 29, 112, DateTimeKind.Utc).AddTicks(128), 3L, new DateTime(2022, 7, 3, 13, 4, 53, 690, DateTimeKind.Utc).AddTicks(4993), 30L },
                    { 31L, 151.37m, new DateTime(2024, 8, 20, 4, 18, 3, 729, DateTimeKind.Utc).AddTicks(4487), true, "q9hn6s2kv3y4vcck", new DateTime(2023, 9, 1, 9, 29, 47, 355, DateTimeKind.Utc).AddTicks(9500), new DateTime(2023, 8, 28, 8, 27, 46, 212, DateTimeKind.Utc).AddTicks(2653), 2L, new DateTime(2023, 9, 10, 1, 3, 38, 804, DateTimeKind.Utc).AddTicks(2254), 8L },
                    { 32L, 91.86m, new DateTime(2022, 11, 20, 12, 51, 37, 931, DateTimeKind.Utc).AddTicks(3201), true, "iwgpew5l055a6ccb", new DateTime(2022, 4, 11, 15, 13, 57, 439, DateTimeKind.Utc).AddTicks(4612), new DateTime(2022, 2, 18, 17, 10, 4, 17, DateTimeKind.Utc).AddTicks(3977), 3L, new DateTime(2023, 7, 13, 14, 36, 0, 425, DateTimeKind.Utc).AddTicks(9451), 23L },
                    { 33L, 151.37m, new DateTime(2022, 9, 12, 12, 8, 53, 37, DateTimeKind.Utc).AddTicks(6556), false, "fqq1hl08z749bd6z", new DateTime(2022, 7, 3, 6, 41, 1, 262, DateTimeKind.Utc).AddTicks(9149), new DateTime(2019, 6, 20, 7, 47, 45, 665, DateTimeKind.Utc).AddTicks(5650), 2L, new DateTime(2019, 8, 29, 13, 43, 35, 996, DateTimeKind.Utc).AddTicks(8956), 38L },
                    { 34L, 91.86m, new DateTime(2023, 11, 30, 16, 24, 54, 617, DateTimeKind.Utc).AddTicks(7977), true, "0ml8d5on129n534f", new DateTime(2023, 9, 13, 19, 41, 17, 182, DateTimeKind.Utc).AddTicks(2585), new DateTime(2022, 8, 28, 2, 57, 57, 883, DateTimeKind.Utc).AddTicks(1462), 3L, new DateTime(2022, 9, 25, 22, 18, 7, 620, DateTimeKind.Utc).AddTicks(4476), 6L },
                    { 35L, 151.37m, new DateTime(2019, 12, 8, 7, 5, 7, 725, DateTimeKind.Utc).AddTicks(5009), false, "k558r56ddw1u0svt", new DateTime(2019, 11, 2, 20, 34, 13, 120, DateTimeKind.Utc).AddTicks(6296), new DateTime(2018, 8, 8, 0, 4, 26, 269, DateTimeKind.Utc).AddTicks(6839), 2L, new DateTime(2021, 3, 27, 12, 48, 39, 932, DateTimeKind.Utc).AddTicks(9040), 21L },
                    { 36L, 91.86m, new DateTime(2021, 12, 27, 2, 13, 51, 95, DateTimeKind.Utc).AddTicks(8335), true, "9olaqemxndo70gvv", new DateTime(2021, 12, 2, 9, 54, 8, 46, DateTimeKind.Utc).AddTicks(2316), new DateTime(2021, 4, 17, 16, 35, 6, 695, DateTimeKind.Utc).AddTicks(1936), 3L, new DateTime(2021, 12, 16, 22, 44, 20, 365, DateTimeKind.Utc).AddTicks(4343), 36L },
                    { 37L, 136.02m, new DateTime(2023, 5, 27, 6, 56, 26, 580, DateTimeKind.Utc).AddTicks(2434), true, "1ggquq41cbz3kwmy", new DateTime(2023, 4, 17, 19, 53, 48, 176, DateTimeKind.Utc).AddTicks(5645), new DateTime(2022, 7, 19, 8, 19, 12, 729, DateTimeKind.Utc).AddTicks(8348), 1L, new DateTime(2023, 4, 30, 14, 56, 10, 631, DateTimeKind.Utc).AddTicks(5962), 11L },
                    { 38L, 151.37m, new DateTime(2024, 2, 19, 9, 24, 40, 794, DateTimeKind.Utc).AddTicks(1549), false, "mcc78krz988ayw3w", new DateTime(2023, 8, 29, 21, 11, 58, 121, DateTimeKind.Utc).AddTicks(5060), new DateTime(2023, 7, 8, 17, 23, 24, 423, DateTimeKind.Utc).AddTicks(7946), 2L, new DateTime(2023, 9, 4, 17, 3, 47, 619, DateTimeKind.Utc).AddTicks(472), 11L },
                    { 39L, 91.86m, new DateTime(2024, 3, 7, 7, 37, 45, 239, DateTimeKind.Utc).AddTicks(2048), true, "8czy2s8dnd3hewts", new DateTime(2023, 7, 10, 1, 30, 6, 590, DateTimeKind.Utc).AddTicks(9882), new DateTime(2023, 6, 3, 22, 28, 54, 705, DateTimeKind.Utc).AddTicks(4190), 3L, null, 23L },
                    { 40L, 91.86m, new DateTime(2023, 5, 9, 7, 25, 34, 604, DateTimeKind.Utc).AddTicks(5953), true, "0adhs4lu1czvkswh", new DateTime(2022, 7, 19, 21, 37, 33, 172, DateTimeKind.Utc).AddTicks(5716), new DateTime(2020, 12, 25, 14, 44, 24, 534, DateTimeKind.Utc).AddTicks(736), 3L, new DateTime(2022, 8, 18, 0, 14, 26, 11, DateTimeKind.Utc).AddTicks(1611), 1L },
                    { 41L, 136.02m, new DateTime(2021, 1, 3, 14, 9, 45, 76, DateTimeKind.Utc).AddTicks(5099), false, "t24hxzbvbmyserki", new DateTime(2020, 1, 31, 23, 21, 7, 79, DateTimeKind.Utc).AddTicks(1830), new DateTime(2019, 12, 5, 8, 17, 32, 300, DateTimeKind.Utc).AddTicks(8903), 1L, new DateTime(2023, 6, 24, 2, 21, 28, 415, DateTimeKind.Utc).AddTicks(5064), 32L },
                    { 42L, 136.02m, new DateTime(2024, 6, 3, 8, 28, 32, 799, DateTimeKind.Utc).AddTicks(2998), true, "2cbsqfkes0nq04x2", new DateTime(2023, 7, 27, 19, 55, 11, 400, DateTimeKind.Utc).AddTicks(7198), new DateTime(2020, 6, 13, 16, 44, 31, 596, DateTimeKind.Utc).AddTicks(1778), 1L, new DateTime(2020, 11, 10, 20, 32, 50, 472, DateTimeKind.Utc).AddTicks(905), 2L },
                    { 43L, 151.37m, new DateTime(2023, 10, 7, 8, 3, 38, 723, DateTimeKind.Utc).AddTicks(8834), false, "a3sk5gfvudeknj5w", new DateTime(2023, 9, 1, 10, 38, 50, 884, DateTimeKind.Utc).AddTicks(1204), new DateTime(2023, 8, 18, 1, 28, 43, 545, DateTimeKind.Utc).AddTicks(8025), 2L, new DateTime(2023, 9, 16, 14, 1, 4, 593, DateTimeKind.Utc).AddTicks(2697), 3L },
                    { 44L, 91.86m, new DateTime(2024, 5, 10, 22, 31, 33, 348, DateTimeKind.Utc).AddTicks(1539), true, "bc0td9wya1hmn09c", new DateTime(2023, 8, 27, 16, 35, 6, 182, DateTimeKind.Utc).AddTicks(7570), new DateTime(2023, 7, 13, 8, 26, 30, 293, DateTimeKind.Utc).AddTicks(7138), 3L, new DateTime(2023, 8, 7, 7, 17, 13, 310, DateTimeKind.Utc).AddTicks(9584), 23L },
                    { 45L, 151.37m, new DateTime(2023, 5, 20, 19, 0, 10, 400, DateTimeKind.Utc).AddTicks(2974), true, "xowb5o5gk48tfmik", new DateTime(2023, 5, 6, 7, 10, 28, 113, DateTimeKind.Utc).AddTicks(7647), new DateTime(2022, 9, 27, 0, 10, 38, 31, DateTimeKind.Utc).AddTicks(4750), 2L, new DateTime(2023, 4, 1, 16, 27, 15, 113, DateTimeKind.Utc).AddTicks(4498), 19L },
                    { 46L, 136.02m, new DateTime(2022, 11, 28, 0, 17, 44, 766, DateTimeKind.Utc).AddTicks(7319), false, "anubxvyyxivpdltm", new DateTime(2022, 2, 23, 18, 11, 30, 784, DateTimeKind.Utc).AddTicks(2802), new DateTime(2020, 6, 20, 19, 20, 2, 674, DateTimeKind.Utc).AddTicks(9302), 1L, new DateTime(2021, 12, 1, 23, 28, 8, 151, DateTimeKind.Utc).AddTicks(3122), 36L },
                    { 47L, 136.02m, new DateTime(2024, 6, 2, 13, 52, 47, 333, DateTimeKind.Utc).AddTicks(5413), false, "ab681sgffu1ituio", new DateTime(2023, 9, 10, 2, 2, 51, 366, DateTimeKind.Utc).AddTicks(2138), new DateTime(2023, 4, 27, 0, 38, 21, 357, DateTimeKind.Utc).AddTicks(8446), 1L, new DateTime(2023, 8, 23, 14, 45, 5, 765, DateTimeKind.Utc).AddTicks(1908), 7L }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "Cost", "EndDate", "IsActive", "PaymentSubscriptionId", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate", "UserId" },
                values: new object[,]
                {
                    { 48L, 151.37m, new DateTime(2022, 7, 12, 22, 18, 30, 326, DateTimeKind.Utc).AddTicks(6286), true, "noq0gqauqw1mppw5", new DateTime(2021, 12, 21, 21, 56, 4, 566, DateTimeKind.Utc).AddTicks(1141), new DateTime(2020, 1, 10, 14, 54, 12, 572, DateTimeKind.Utc).AddTicks(7795), 2L, new DateTime(2021, 3, 2, 11, 9, 48, 15, DateTimeKind.Utc).AddTicks(6709), 4L },
                    { 49L, 136.02m, new DateTime(2024, 7, 1, 22, 55, 42, 616, DateTimeKind.Utc).AddTicks(5755), true, "icchkz7h4bld2gyo", new DateTime(2023, 9, 10, 1, 56, 34, 975, DateTimeKind.Utc).AddTicks(4195), new DateTime(2023, 4, 15, 5, 56, 33, 514, DateTimeKind.Utc).AddTicks(7623), 1L, new DateTime(2023, 9, 6, 12, 39, 41, 900, DateTimeKind.Utc).AddTicks(221), 23L },
                    { 50L, 151.37m, new DateTime(2021, 8, 21, 22, 12, 34, 324, DateTimeKind.Utc).AddTicks(303), false, "dqu9ioacwoh3dt9r", new DateTime(2021, 7, 8, 23, 8, 38, 488, DateTimeKind.Utc).AddTicks(3634), new DateTime(2020, 3, 12, 12, 26, 2, 724, DateTimeKind.Utc).AddTicks(4591), 2L, null, 28L },
                    { 51L, 136.02m, new DateTime(2022, 5, 7, 4, 39, 28, 307, DateTimeKind.Utc).AddTicks(684), false, "hlzcjv8mdw4u5yyf", new DateTime(2021, 5, 20, 22, 12, 52, 998, DateTimeKind.Utc).AddTicks(2292), new DateTime(2019, 11, 5, 11, 48, 35, 576, DateTimeKind.Utc).AddTicks(7255), 1L, new DateTime(2023, 2, 27, 7, 39, 48, 357, DateTimeKind.Utc).AddTicks(7581), 1L },
                    { 52L, 91.86m, new DateTime(2024, 4, 29, 11, 25, 19, 177, DateTimeKind.Utc).AddTicks(7253), false, "y089embtn7rxpys0", new DateTime(2023, 8, 18, 21, 12, 23, 396, DateTimeKind.Utc).AddTicks(7018), new DateTime(2023, 7, 17, 18, 17, 3, 722, DateTimeKind.Utc).AddTicks(2242), 3L, new DateTime(2023, 8, 13, 5, 22, 25, 113, DateTimeKind.Utc).AddTicks(4355), 18L },
                    { 53L, 136.02m, new DateTime(2023, 10, 22, 8, 53, 30, 111, DateTimeKind.Utc).AddTicks(8470), true, "l2cv2onna8ejmz8r", new DateTime(2023, 8, 17, 1, 34, 36, 609, DateTimeKind.Utc).AddTicks(2858), new DateTime(2022, 4, 2, 17, 39, 12, 357, DateTimeKind.Utc).AddTicks(7986), 1L, new DateTime(2022, 4, 22, 1, 48, 32, 304, DateTimeKind.Utc).AddTicks(7358), 23L },
                    { 54L, 136.02m, new DateTime(2023, 4, 4, 23, 52, 25, 417, DateTimeKind.Utc).AddTicks(2434), true, "gfy34t1jeinb9gqz", new DateTime(2022, 9, 20, 11, 44, 27, 891, DateTimeKind.Utc).AddTicks(3883), new DateTime(2021, 10, 29, 12, 6, 19, 389, DateTimeKind.Utc).AddTicks(7886), 1L, new DateTime(2022, 4, 22, 9, 41, 38, 428, DateTimeKind.Utc).AddTicks(130), 22L },
                    { 55L, 91.86m, new DateTime(2023, 1, 29, 14, 40, 0, 553, DateTimeKind.Utc).AddTicks(6291), true, "nzwe7ojkc9empkjg", new DateTime(2022, 10, 2, 14, 7, 21, 636, DateTimeKind.Utc).AddTicks(7942), new DateTime(2022, 8, 17, 12, 47, 30, 969, DateTimeKind.Utc).AddTicks(9317), 3L, new DateTime(2023, 8, 15, 13, 42, 35, 693, DateTimeKind.Utc).AddTicks(5832), 8L },
                    { 56L, 136.02m, new DateTime(2023, 10, 16, 3, 44, 2, 386, DateTimeKind.Utc).AddTicks(784), false, "j7d2e9j71hg4xncp", new DateTime(2023, 9, 21, 17, 0, 30, 144, DateTimeKind.Utc).AddTicks(8012), new DateTime(2023, 7, 19, 11, 47, 21, 906, DateTimeKind.Utc).AddTicks(7267), 1L, new DateTime(2023, 7, 26, 23, 59, 16, 971, DateTimeKind.Utc).AddTicks(502), 39L },
                    { 57L, 136.02m, new DateTime(2022, 11, 13, 6, 40, 53, 565, DateTimeKind.Utc).AddTicks(4792), false, "l7ao3a4qisuzah62", new DateTime(2022, 9, 28, 11, 10, 41, 718, DateTimeKind.Utc).AddTicks(7596), new DateTime(2022, 6, 18, 18, 3, 4, 951, DateTimeKind.Utc).AddTicks(550), 1L, new DateTime(2022, 12, 22, 11, 32, 49, 254, DateTimeKind.Utc).AddTicks(5302), 30L },
                    { 58L, 91.86m, new DateTime(2024, 1, 9, 13, 58, 32, 869, DateTimeKind.Utc).AddTicks(8065), true, "if58xh1fxeg6zu3r", new DateTime(2023, 3, 24, 9, 24, 25, 26, DateTimeKind.Utc).AddTicks(7255), new DateTime(2023, 2, 28, 14, 17, 27, 505, DateTimeKind.Utc).AddTicks(3760), 3L, new DateTime(2023, 5, 15, 8, 42, 19, 734, DateTimeKind.Utc).AddTicks(1922), 15L },
                    { 59L, 151.37m, new DateTime(2022, 12, 21, 3, 8, 55, 466, DateTimeKind.Utc).AddTicks(7247), false, "xw8vj1u6nq6o4wt0", new DateTime(2022, 12, 11, 18, 37, 39, 443, DateTimeKind.Utc).AddTicks(7204), new DateTime(2017, 4, 21, 4, 23, 7, 906, DateTimeKind.Utc).AddTicks(5194), 2L, new DateTime(2023, 7, 26, 1, 47, 27, 574, DateTimeKind.Utc).AddTicks(1514), 31L },
                    { 60L, 136.02m, new DateTime(2023, 10, 2, 23, 3, 39, 537, DateTimeKind.Utc).AddTicks(588), true, "2tufsfq40oa185wv", new DateTime(2023, 1, 25, 8, 51, 48, 349, DateTimeKind.Utc).AddTicks(1672), new DateTime(2022, 11, 10, 21, 44, 17, 212, DateTimeKind.Utc).AddTicks(3281), 1L, new DateTime(2023, 3, 25, 6, 56, 11, 262, DateTimeKind.Utc).AddTicks(25), 23L },
                    { 61L, 136.02m, new DateTime(2023, 4, 13, 7, 15, 30, 225, DateTimeKind.Utc).AddTicks(9982), false, "wmcdbjgysdsp6fe8", new DateTime(2022, 9, 1, 1, 58, 36, 353, DateTimeKind.Utc).AddTicks(5835), new DateTime(2021, 10, 19, 14, 10, 23, 818, DateTimeKind.Utc).AddTicks(9366), 1L, new DateTime(2023, 4, 14, 20, 42, 48, 705, DateTimeKind.Utc).AddTicks(2035), 40L },
                    { 62L, 151.37m, new DateTime(2023, 8, 19, 16, 29, 17, 233, DateTimeKind.Utc).AddTicks(6275), true, "i6bqfv7n7ei52dtg", new DateTime(2023, 4, 9, 17, 29, 9, 711, DateTimeKind.Utc).AddTicks(6690), new DateTime(2019, 11, 10, 7, 10, 15, 624, DateTimeKind.Utc).AddTicks(4159), 2L, new DateTime(2020, 9, 2, 10, 59, 13, 269, DateTimeKind.Utc).AddTicks(5962), 10L },
                    { 63L, 136.02m, new DateTime(2024, 4, 22, 18, 12, 52, 8, DateTimeKind.Utc).AddTicks(1140), false, "va8nr6u4vqv58pix", new DateTime(2023, 5, 26, 3, 49, 59, 120, DateTimeKind.Utc).AddTicks(3712), new DateTime(2022, 3, 11, 7, 12, 48, 611, DateTimeKind.Utc).AddTicks(1160), 1L, new DateTime(2022, 7, 23, 1, 10, 52, 526, DateTimeKind.Utc).AddTicks(764), 7L },
                    { 64L, 151.37m, new DateTime(2023, 5, 7, 2, 40, 21, 883, DateTimeKind.Utc).AddTicks(7752), false, "7779iv8ah6v5mjw1", new DateTime(2022, 11, 7, 8, 8, 53, 748, DateTimeKind.Utc).AddTicks(1798), new DateTime(2022, 6, 11, 12, 2, 12, 990, DateTimeKind.Utc).AddTicks(4724), 2L, new DateTime(2023, 4, 22, 2, 1, 43, 100, DateTimeKind.Utc).AddTicks(8833), 23L },
                    { 65L, 151.37m, new DateTime(2022, 6, 15, 15, 55, 22, 2, DateTimeKind.Utc).AddTicks(9120), false, "tbp7qw8m3mfjyklz", new DateTime(2021, 8, 18, 0, 49, 53, 265, DateTimeKind.Utc).AddTicks(2612), new DateTime(2021, 7, 1, 4, 16, 19, 991, DateTimeKind.Utc).AddTicks(6479), 2L, new DateTime(2022, 4, 14, 20, 40, 18, 238, DateTimeKind.Utc).AddTicks(5287), 21L },
                    { 66L, 136.02m, new DateTime(2023, 10, 21, 17, 23, 29, 972, DateTimeKind.Utc).AddTicks(160), true, "8g7ixv4jzog650kl", new DateTime(2023, 9, 14, 16, 16, 31, 96, DateTimeKind.Utc).AddTicks(8101), new DateTime(2019, 3, 30, 5, 12, 13, 702, DateTimeKind.Utc).AddTicks(7381), 1L, new DateTime(2020, 11, 22, 16, 1, 11, 222, DateTimeKind.Utc).AddTicks(8941), 38L },
                    { 67L, 91.86m, new DateTime(2022, 12, 12, 23, 39, 5, 364, DateTimeKind.Utc).AddTicks(9326), true, "sbtx06pg02z9opp8", new DateTime(2022, 11, 3, 21, 20, 19, 779, DateTimeKind.Utc).AddTicks(9523), new DateTime(2022, 6, 25, 7, 39, 36, 879, DateTimeKind.Utc).AddTicks(4791), 3L, new DateTime(2022, 12, 31, 10, 8, 15, 7, DateTimeKind.Utc).AddTicks(1891), 20L },
                    { 68L, 91.86m, new DateTime(2018, 4, 8, 11, 25, 51, 349, DateTimeKind.Utc).AddTicks(9916), true, "z24labjvd7qm17jt", new DateTime(2018, 3, 22, 9, 40, 53, 827, DateTimeKind.Utc).AddTicks(8804), new DateTime(2017, 9, 22, 7, 2, 52, 203, DateTimeKind.Utc).AddTicks(4695), 3L, new DateTime(2019, 7, 16, 18, 21, 44, 772, DateTimeKind.Utc).AddTicks(8589), 39L },
                    { 69L, 136.02m, new DateTime(2024, 8, 12, 17, 41, 21, 889, DateTimeKind.Utc).AddTicks(5618), true, "jti7tswdhcxx146p", new DateTime(2023, 8, 17, 4, 54, 53, 907, DateTimeKind.Utc).AddTicks(363), new DateTime(2023, 7, 15, 20, 28, 41, 287, DateTimeKind.Utc).AddTicks(3626), 1L, new DateTime(2023, 7, 21, 14, 33, 7, 821, DateTimeKind.Utc).AddTicks(9847), 23L },
                    { 70L, 151.37m, new DateTime(2023, 5, 17, 0, 29, 18, 104, DateTimeKind.Utc).AddTicks(5589), false, "dqb49qfp6v2htb1l", new DateTime(2023, 2, 2, 2, 45, 29, 867, DateTimeKind.Utc).AddTicks(2392), new DateTime(2021, 7, 14, 3, 21, 20, 955, DateTimeKind.Utc).AddTicks(8528), 2L, new DateTime(2022, 11, 12, 23, 55, 27, 608, DateTimeKind.Utc).AddTicks(679), 13L },
                    { 71L, 136.02m, new DateTime(2022, 3, 30, 7, 27, 40, 349, DateTimeKind.Utc).AddTicks(188), true, "tfjxef8gm7u3gr4q", new DateTime(2022, 3, 6, 4, 53, 22, 589, DateTimeKind.Utc).AddTicks(2512), new DateTime(2021, 11, 8, 7, 58, 21, 744, DateTimeKind.Utc).AddTicks(2525), 1L, new DateTime(2023, 2, 16, 20, 36, 18, 659, DateTimeKind.Utc).AddTicks(1166), 37L },
                    { 72L, 151.37m, new DateTime(2023, 11, 4, 20, 34, 7, 566, DateTimeKind.Utc).AddTicks(4314), false, "2b5myh0ryhbt7haq", new DateTime(2023, 5, 8, 12, 19, 59, 997, DateTimeKind.Utc).AddTicks(3543), new DateTime(2022, 10, 22, 12, 19, 30, 519, DateTimeKind.Utc).AddTicks(9694), 2L, new DateTime(2023, 9, 4, 23, 38, 31, 278, DateTimeKind.Utc).AddTicks(6360), 26L },
                    { 73L, 136.02m, new DateTime(2024, 2, 14, 19, 35, 49, 853, DateTimeKind.Utc).AddTicks(8517), true, "8ds2vlr4ibv39lh4", new DateTime(2023, 8, 28, 0, 23, 48, 856, DateTimeKind.Utc).AddTicks(4562), new DateTime(2022, 3, 19, 23, 25, 42, 200, DateTimeKind.Utc).AddTicks(5032), 1L, new DateTime(2022, 9, 3, 22, 28, 37, 132, DateTimeKind.Utc).AddTicks(7295), 9L },
                    { 74L, 136.02m, new DateTime(2024, 2, 17, 18, 37, 8, 283, DateTimeKind.Utc).AddTicks(861), true, "xzjgtbq46mekoxwc", new DateTime(2023, 7, 6, 7, 27, 12, 67, DateTimeKind.Utc).AddTicks(9415), new DateTime(2021, 7, 16, 2, 31, 49, 408, DateTimeKind.Utc).AddTicks(6103), 1L, new DateTime(2021, 12, 20, 12, 59, 58, 265, DateTimeKind.Utc).AddTicks(4702), 30L },
                    { 75L, 91.86m, new DateTime(2023, 11, 15, 1, 37, 19, 383, DateTimeKind.Utc).AddTicks(178), true, "4qdes62xud4v2bb7", new DateTime(2023, 8, 28, 10, 33, 46, 210, DateTimeKind.Utc).AddTicks(3005), new DateTime(2023, 7, 15, 8, 2, 21, 313, DateTimeKind.Utc).AddTicks(7569), 3L, new DateTime(2023, 9, 16, 8, 33, 28, 565, DateTimeKind.Utc).AddTicks(4335), 24L },
                    { 76L, 151.37m, new DateTime(2024, 3, 18, 21, 41, 2, 255, DateTimeKind.Utc).AddTicks(4271), true, "6s7a0msqiic2ybbz", new DateTime(2023, 5, 23, 19, 8, 44, 328, DateTimeKind.Utc).AddTicks(8860), new DateTime(2023, 4, 2, 16, 15, 14, 227, DateTimeKind.Utc).AddTicks(5197), 2L, new DateTime(2023, 4, 8, 7, 28, 56, 698, DateTimeKind.Utc).AddTicks(9408), 23L },
                    { 77L, 151.37m, new DateTime(2023, 12, 29, 2, 42, 17, 777, DateTimeKind.Utc).AddTicks(6655), true, "u2bu9ut7a380yrw7", new DateTime(2023, 1, 10, 19, 59, 51, 195, DateTimeKind.Utc).AddTicks(4502), new DateTime(2022, 3, 1, 20, 0, 4, 553, DateTimeKind.Utc).AddTicks(1811), 2L, new DateTime(2022, 7, 27, 17, 5, 45, 558, DateTimeKind.Utc).AddTicks(892), 24L },
                    { 78L, 136.02m, new DateTime(2023, 7, 14, 8, 17, 49, 443, DateTimeKind.Utc).AddTicks(7816), false, "gx2r65g5hsfxbxgo", new DateTime(2023, 6, 14, 21, 9, 23, 911, DateTimeKind.Utc).AddTicks(3477), new DateTime(2022, 1, 17, 11, 53, 27, 964, DateTimeKind.Utc).AddTicks(1803), 1L, null, 28L },
                    { 79L, 136.02m, new DateTime(2023, 5, 14, 13, 27, 45, 951, DateTimeKind.Utc).AddTicks(3284), false, "jjpfoqglt2ecr215", new DateTime(2023, 1, 8, 14, 30, 10, 958, DateTimeKind.Utc).AddTicks(4562), new DateTime(2022, 11, 20, 5, 56, 54, 196, DateTimeKind.Utc).AddTicks(578), 1L, new DateTime(2023, 9, 15, 1, 35, 44, 532, DateTimeKind.Utc).AddTicks(7989), 27L },
                    { 80L, 91.86m, new DateTime(2019, 6, 6, 22, 51, 49, 6, DateTimeKind.Utc).AddTicks(8015), false, "xnuthf65wa7mg0gr", new DateTime(2018, 11, 27, 14, 21, 15, 586, DateTimeKind.Utc).AddTicks(4227), new DateTime(2017, 4, 13, 13, 50, 9, 942, DateTimeKind.Utc).AddTicks(8569), 3L, new DateTime(2017, 12, 30, 10, 53, 15, 501, DateTimeKind.Utc).AddTicks(350), 14L },
                    { 81L, 136.02m, new DateTime(2023, 8, 16, 10, 2, 41, 55, DateTimeKind.Utc).AddTicks(4619), false, "3m6zsvfkn1i0vm3e", new DateTime(2022, 10, 7, 5, 30, 56, 360, DateTimeKind.Utc).AddTicks(5887), new DateTime(2021, 11, 9, 8, 35, 50, 792, DateTimeKind.Utc).AddTicks(9977), 1L, new DateTime(2022, 8, 15, 14, 57, 33, 443, DateTimeKind.Utc).AddTicks(6652), 36L },
                    { 82L, 151.37m, new DateTime(2024, 3, 23, 10, 32, 6, 632, DateTimeKind.Utc).AddTicks(4375), false, "mrtium4tr7pv86d0", new DateTime(2023, 9, 19, 11, 51, 56, 847, DateTimeKind.Utc).AddTicks(3747), new DateTime(2023, 9, 17, 12, 9, 31, 335, DateTimeKind.Utc).AddTicks(6351), 2L, new DateTime(2023, 9, 19, 16, 23, 51, 93, DateTimeKind.Utc).AddTicks(7898), 34L },
                    { 83L, 91.86m, new DateTime(2022, 10, 31, 9, 30, 25, 842, DateTimeKind.Utc).AddTicks(5143), false, "qpd9nfspxjd01xp0", new DateTime(2021, 12, 2, 14, 23, 9, 495, DateTimeKind.Utc).AddTicks(6369), new DateTime(2018, 4, 24, 0, 6, 48, 798, DateTimeKind.Utc).AddTicks(3322), 3L, new DateTime(2019, 7, 17, 9, 55, 34, 957, DateTimeKind.Utc).AddTicks(8571), 37L },
                    { 84L, 136.02m, new DateTime(2024, 7, 15, 2, 5, 35, 943, DateTimeKind.Utc).AddTicks(1778), false, "wfn8fa46w4r59v5c", new DateTime(2023, 9, 19, 7, 14, 42, 456, DateTimeKind.Utc).AddTicks(9525), new DateTime(2023, 9, 11, 17, 7, 3, 179, DateTimeKind.Utc).AddTicks(9148), 1L, new DateTime(2023, 9, 15, 13, 14, 9, 981, DateTimeKind.Utc).AddTicks(9337), 18L },
                    { 85L, 136.02m, new DateTime(2023, 6, 17, 11, 12, 43, 534, DateTimeKind.Utc).AddTicks(3959), true, "wyht67sijod7rj9m", new DateTime(2023, 4, 19, 19, 11, 19, 628, DateTimeKind.Utc).AddTicks(9434), new DateTime(2016, 11, 14, 23, 21, 56, 66, DateTimeKind.Utc).AddTicks(3329), 1L, new DateTime(2020, 10, 4, 11, 0, 21, 437, DateTimeKind.Utc).AddTicks(561), 17L },
                    { 86L, 136.02m, new DateTime(2023, 10, 21, 13, 27, 9, 137, DateTimeKind.Utc).AddTicks(6610), false, "jx8v9gvjgqbhtb0p", new DateTime(2023, 4, 17, 15, 51, 2, 908, DateTimeKind.Utc).AddTicks(3767), new DateTime(2022, 9, 13, 5, 44, 15, 347, DateTimeKind.Utc).AddTicks(686), 1L, new DateTime(2023, 8, 31, 1, 27, 14, 224, DateTimeKind.Utc).AddTicks(2230), 13L },
                    { 87L, 91.86m, new DateTime(2023, 7, 15, 5, 38, 58, 370, DateTimeKind.Utc).AddTicks(971), true, "rcan81qc7fa8yw83", new DateTime(2023, 4, 20, 14, 32, 14, 439, DateTimeKind.Utc).AddTicks(7340), new DateTime(2023, 4, 15, 10, 54, 45, 654, DateTimeKind.Utc).AddTicks(533), 3L, new DateTime(2023, 8, 17, 11, 23, 49, 851, DateTimeKind.Utc).AddTicks(8973), 33L },
                    { 88L, 91.86m, new DateTime(2021, 2, 18, 22, 27, 35, 491, DateTimeKind.Utc).AddTicks(226), true, "5emwz6jldc4x58af", new DateTime(2021, 2, 5, 5, 25, 19, 742, DateTimeKind.Utc).AddTicks(4512), new DateTime(2019, 6, 29, 5, 5, 17, 672, DateTimeKind.Utc).AddTicks(7750), 3L, new DateTime(2022, 10, 13, 8, 55, 45, 366, DateTimeKind.Utc).AddTicks(7133), 40L },
                    { 89L, 91.86m, new DateTime(2024, 3, 3, 14, 2, 32, 450, DateTimeKind.Utc).AddTicks(218), false, "1hro6jnzj7hueud0", new DateTime(2023, 5, 18, 8, 23, 4, 994, DateTimeKind.Utc).AddTicks(8457), new DateTime(2022, 10, 6, 7, 22, 51, 222, DateTimeKind.Utc).AddTicks(5720), 3L, new DateTime(2023, 1, 23, 10, 52, 49, 620, DateTimeKind.Utc).AddTicks(4862), 37L }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "Cost", "EndDate", "IsActive", "PaymentSubscriptionId", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate", "UserId" },
                values: new object[,]
                {
                    { 90L, 136.02m, new DateTime(2024, 3, 16, 10, 23, 56, 481, DateTimeKind.Utc).AddTicks(851), true, "jb19he1dn7vheueu", new DateTime(2023, 6, 14, 2, 35, 3, 326, DateTimeKind.Utc).AddTicks(7274), new DateTime(2019, 4, 11, 0, 31, 49, 312, DateTimeKind.Utc).AddTicks(5529), 1L, null, 28L },
                    { 91L, 136.02m, new DateTime(2022, 10, 4, 6, 24, 17, 681, DateTimeKind.Utc).AddTicks(1302), true, "l9hcw3mpj65vhei4", new DateTime(2021, 10, 7, 23, 33, 55, 736, DateTimeKind.Utc).AddTicks(937), new DateTime(2021, 4, 11, 14, 47, 45, 776, DateTimeKind.Utc).AddTicks(9130), 1L, new DateTime(2023, 6, 14, 2, 16, 45, 267, DateTimeKind.Utc).AddTicks(8351), 7L },
                    { 92L, 136.02m, new DateTime(2024, 4, 16, 17, 13, 55, 203, DateTimeKind.Utc).AddTicks(8149), true, "a0yox0t3avo8xphk", new DateTime(2023, 8, 11, 17, 21, 44, 425, DateTimeKind.Utc).AddTicks(7721), new DateTime(2023, 7, 30, 10, 8, 48, 321, DateTimeKind.Utc).AddTicks(676), 1L, new DateTime(2023, 8, 28, 19, 57, 30, 9, DateTimeKind.Utc).AddTicks(3045), 24L },
                    { 93L, 136.02m, new DateTime(2024, 3, 10, 14, 9, 17, 96, DateTimeKind.Utc).AddTicks(8755), true, "m8rn9t5pne2v4ysj", new DateTime(2023, 6, 21, 1, 10, 33, 517, DateTimeKind.Utc).AddTicks(5349), new DateTime(2023, 1, 27, 6, 49, 3, 850, DateTimeKind.Utc).AddTicks(5218), 1L, new DateTime(2023, 4, 2, 11, 14, 2, 908, DateTimeKind.Utc).AddTicks(9810), 15L },
                    { 94L, 91.86m, new DateTime(2023, 10, 1, 7, 28, 33, 433, DateTimeKind.Utc).AddTicks(3255), false, "mmluyddqoo1o85th", new DateTime(2023, 2, 13, 16, 49, 50, 840, DateTimeKind.Utc).AddTicks(2930), new DateTime(2022, 6, 5, 22, 2, 44, 276, DateTimeKind.Utc).AddTicks(1067), 3L, new DateTime(2023, 3, 15, 2, 35, 59, 147, DateTimeKind.Utc).AddTicks(598), 30L },
                    { 95L, 136.02m, new DateTime(2021, 5, 24, 18, 1, 35, 830, DateTimeKind.Utc).AddTicks(7204), true, "cevlzqkc2a1n7br9", new DateTime(2020, 7, 1, 8, 33, 54, 48, DateTimeKind.Utc).AddTicks(6097), new DateTime(2017, 10, 14, 9, 56, 25, 899, DateTimeKind.Utc).AddTicks(9938), 1L, new DateTime(2018, 6, 4, 14, 42, 48, 964, DateTimeKind.Utc).AddTicks(9064), 2L },
                    { 96L, 91.86m, new DateTime(2023, 9, 14, 6, 4, 39, 163, DateTimeKind.Utc).AddTicks(6549), true, "93vrpnu06yhjisrx", new DateTime(2023, 8, 2, 22, 28, 49, 145, DateTimeKind.Utc).AddTicks(1826), new DateTime(2021, 5, 26, 17, 54, 2, 911, DateTimeKind.Utc).AddTicks(3896), 3L, new DateTime(2021, 10, 19, 10, 4, 13, 772, DateTimeKind.Utc).AddTicks(3617), 5L },
                    { 97L, 136.02m, new DateTime(2023, 12, 31, 4, 16, 36, 169, DateTimeKind.Utc).AddTicks(2465), true, "7biaezr83ocwvtne", new DateTime(2023, 3, 7, 19, 23, 58, 59, DateTimeKind.Utc).AddTicks(3313), new DateTime(2022, 12, 26, 22, 38, 6, 148, DateTimeKind.Utc).AddTicks(6575), 1L, new DateTime(2023, 2, 20, 12, 40, 47, 948, DateTimeKind.Utc).AddTicks(6929), 19L },
                    { 98L, 136.02m, new DateTime(2024, 1, 18, 11, 43, 58, 402, DateTimeKind.Utc).AddTicks(8650), true, "k9c7hc23tgje5jm7", new DateTime(2023, 8, 12, 8, 0, 46, 537, DateTimeKind.Utc).AddTicks(6575), new DateTime(2023, 1, 9, 16, 52, 46, 800, DateTimeKind.Utc).AddTicks(597), 1L, new DateTime(2023, 8, 17, 10, 8, 3, 65, DateTimeKind.Utc).AddTicks(6354), 8L },
                    { 99L, 136.02m, new DateTime(2022, 9, 4, 6, 34, 50, 131, DateTimeKind.Utc).AddTicks(1421), false, "17h3p0lzj9p4mkrq", new DateTime(2022, 6, 2, 9, 31, 16, 748, DateTimeKind.Utc).AddTicks(7599), new DateTime(2021, 7, 13, 13, 32, 29, 876, DateTimeKind.Utc).AddTicks(972), 1L, new DateTime(2022, 2, 5, 3, 57, 54, 977, DateTimeKind.Utc).AddTicks(2765), 24L },
                    { 100L, 151.37m, new DateTime(2024, 7, 9, 18, 30, 31, 869, DateTimeKind.Utc).AddTicks(1813), false, "ea2krxtp615avzdt", new DateTime(2023, 9, 12, 0, 2, 1, 249, DateTimeKind.Utc).AddTicks(1389), new DateTime(2023, 6, 25, 8, 22, 44, 469, DateTimeKind.Utc).AddTicks(2872), 2L, new DateTime(2023, 8, 8, 17, 46, 24, 133, DateTimeKind.Utc).AddTicks(9646), 35L },
                    { 101L, 136.02m, new DateTime(2024, 2, 8, 4, 24, 28, 102, DateTimeKind.Utc).AddTicks(6454), false, "hp86so1sykofx18m", new DateTime(2023, 9, 9, 16, 24, 7, 387, DateTimeKind.Utc).AddTicks(9116), new DateTime(2023, 8, 21, 19, 1, 26, 996, DateTimeKind.Utc).AddTicks(7615), 1L, new DateTime(2023, 9, 5, 22, 24, 26, 686, DateTimeKind.Utc).AddTicks(2954), 19L },
                    { 102L, 151.37m, new DateTime(2021, 4, 10, 18, 24, 58, 658, DateTimeKind.Utc).AddTicks(7178), false, "v9jped3wpf21omxi", new DateTime(2020, 12, 19, 19, 29, 13, 58, DateTimeKind.Utc).AddTicks(4126), new DateTime(2019, 10, 15, 2, 20, 59, 489, DateTimeKind.Utc).AddTicks(7079), 2L, new DateTime(2023, 8, 10, 5, 46, 58, 283, DateTimeKind.Utc).AddTicks(1719), 40L },
                    { 103L, 91.86m, new DateTime(2024, 4, 16, 3, 55, 50, 529, DateTimeKind.Utc).AddTicks(58), false, "a7ftky80unai4cdk", new DateTime(2023, 4, 29, 21, 55, 50, 738, DateTimeKind.Utc).AddTicks(471), new DateTime(2022, 11, 26, 9, 33, 0, 393, DateTimeKind.Utc).AddTicks(3493), 3L, new DateTime(2023, 1, 29, 18, 29, 39, 938, DateTimeKind.Utc).AddTicks(9426), 20L },
                    { 104L, 136.02m, new DateTime(2023, 1, 14, 11, 54, 17, 58, DateTimeKind.Utc).AddTicks(3226), false, "2fl25kawdqe7y9cr", new DateTime(2022, 9, 12, 19, 3, 37, 802, DateTimeKind.Utc).AddTicks(510), new DateTime(2022, 8, 31, 19, 46, 23, 518, DateTimeKind.Utc).AddTicks(677), 1L, new DateTime(2023, 2, 7, 13, 24, 51, 757, DateTimeKind.Utc).AddTicks(5213), 8L },
                    { 105L, 151.37m, new DateTime(2020, 10, 30, 9, 17, 16, 459, DateTimeKind.Utc).AddTicks(3935), true, "yrti9du39mr5c5va", new DateTime(2019, 11, 21, 13, 48, 45, 565, DateTimeKind.Utc).AddTicks(3350), new DateTime(2017, 6, 30, 11, 0, 20, 260, DateTimeKind.Utc).AddTicks(4227), 2L, new DateTime(2018, 8, 12, 8, 28, 25, 214, DateTimeKind.Utc).AddTicks(6285), 14L },
                    { 106L, 136.02m, new DateTime(2024, 2, 8, 20, 54, 42, 397, DateTimeKind.Utc).AddTicks(9644), true, "fybw1xhn0y3drrm0", new DateTime(2023, 8, 5, 8, 35, 46, 412, DateTimeKind.Utc).AddTicks(314), new DateTime(2023, 7, 11, 15, 34, 7, 771, DateTimeKind.Utc).AddTicks(8795), 1L, new DateTime(2023, 7, 26, 11, 44, 38, 589, DateTimeKind.Utc).AddTicks(1696), 36L },
                    { 107L, 136.02m, new DateTime(2023, 1, 1, 15, 36, 16, 357, DateTimeKind.Utc).AddTicks(1230), false, "6voy90ps5l3b1y1b", new DateTime(2022, 12, 6, 4, 49, 20, 640, DateTimeKind.Utc).AddTicks(3451), new DateTime(2022, 5, 21, 20, 21, 59, 499, DateTimeKind.Utc).AddTicks(2823), 1L, new DateTime(2023, 1, 19, 0, 12, 22, 518, DateTimeKind.Utc).AddTicks(6485), 6L },
                    { 108L, 136.02m, new DateTime(2021, 1, 11, 11, 12, 14, 647, DateTimeKind.Utc).AddTicks(5044), false, "r4im89p8kap58jd0", new DateTime(2020, 5, 7, 13, 6, 17, 658, DateTimeKind.Utc).AddTicks(1880), new DateTime(2019, 9, 4, 16, 48, 5, 581, DateTimeKind.Utc).AddTicks(5051), 1L, new DateTime(2020, 12, 9, 13, 16, 9, 768, DateTimeKind.Utc).AddTicks(1953), 10L },
                    { 109L, 91.86m, new DateTime(2023, 11, 18, 17, 34, 32, 56, DateTimeKind.Utc).AddTicks(6473), false, "9l7e2zypb364i3jv", new DateTime(2023, 8, 21, 8, 2, 49, 150, DateTimeKind.Utc).AddTicks(749), new DateTime(2023, 5, 12, 9, 29, 30, 450, DateTimeKind.Utc).AddTicks(146), 3L, new DateTime(2023, 9, 7, 16, 20, 2, 696, DateTimeKind.Utc).AddTicks(8841), 35L },
                    { 110L, 136.02m, new DateTime(2023, 1, 1, 2, 35, 54, 160, DateTimeKind.Utc).AddTicks(6861), true, "p45radwg6kdm2a5k", new DateTime(2022, 8, 27, 20, 36, 49, 526, DateTimeKind.Utc).AddTicks(2579), new DateTime(2022, 6, 28, 0, 4, 37, 259, DateTimeKind.Utc).AddTicks(6580), 1L, new DateTime(2022, 10, 19, 12, 51, 8, 115, DateTimeKind.Utc).AddTicks(3779), 14L }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "IsPublic" },
                values: new object[,]
                {
                    { 1L, 8L, "Fuga molestiae laborum architecto minus aut quisquam explicabo corporis.\nVeniam omnis et dolores temporibus voluptatem ea.\nIste odio quis delectus.\nDeleniti qui et consequatur.\nMinus illo quibusdam distinctio cumque nihil voluptate occaecati molestiae fuga.\nEx eos quibusdam ipsa nobis veritatis hic eaque.", new DateTime(2023, 6, 25, 4, 17, 36, 6, DateTimeKind.Utc).AddTicks(5080), 30L, false },
                    { 2L, 55L, "odit", new DateTime(2023, 4, 11, 2, 46, 15, 661, DateTimeKind.Utc).AddTicks(5316), 27L, true },
                    { 3L, 136L, "soluta", new DateTime(2023, 9, 9, 23, 28, 23, 694, DateTimeKind.Utc).AddTicks(9175), 29L, false },
                    { 4L, 77L, "dolorem", new DateTime(2021, 12, 2, 2, 42, 20, 305, DateTimeKind.Utc).AddTicks(2579), 32L, true },
                    { 5L, 155L, "Id quam velit corporis sunt.", new DateTime(2023, 9, 10, 23, 31, 7, 580, DateTimeKind.Utc).AddTicks(1750), 17L, true },
                    { 6L, 29L, "Repellat neque temporibus iste magnam. Placeat sit temporibus rerum aut. Esse iusto autem vero odio necessitatibus et. Voluptatum in nesciunt officia voluptates ratione quo id harum quo.", new DateTime(2021, 2, 10, 19, 38, 59, 524, DateTimeKind.Utc).AddTicks(106), 18L, true },
                    { 7L, 61L, "Eaque et consequatur.", new DateTime(2023, 7, 4, 10, 19, 13, 480, DateTimeKind.Utc).AddTicks(8346), 38L, true },
                    { 8L, 7L, "Rerum dolores consequuntur cumque reiciendis iste qui. Omnis animi alias sed facilis. Blanditiis perferendis cumque. Quo nulla consectetur. Quasi impedit qui quis vitae maxime quidem ut pariatur quis.", new DateTime(2022, 2, 28, 2, 58, 52, 482, DateTimeKind.Utc).AddTicks(3680), 11L, true },
                    { 9L, 37L, "Soluta ducimus odit est assumenda vitae quo quam.\nIpsa voluptas ut rem architecto eligendi eum itaque.\nQuam debitis id.\nVoluptas est labore placeat harum voluptatem.\nPariatur facere ea assumenda laboriosam.\nQui dicta voluptatem.", new DateTime(2023, 9, 20, 17, 59, 43, 342, DateTimeKind.Utc).AddTicks(6678), 40L, true },
                    { 10L, 24L, "Nemo corporis vel exercitationem ea hic quia quidem.", new DateTime(2023, 6, 4, 18, 10, 27, 296, DateTimeKind.Utc).AddTicks(2195), 6L, true },
                    { 11L, 26L, "Sit qui nobis aut at nostrum.\nTotam magni ipsa exercitationem ullam tempore voluptas autem saepe expedita.\nEos vel itaque.\nLaboriosam autem commodi non sed.", new DateTime(2023, 7, 28, 4, 14, 33, 665, DateTimeKind.Utc).AddTicks(2048), 9L, false },
                    { 12L, 70L, "Veniam quia corporis voluptas cupiditate velit eum quo dolore. Veritatis et est officiis in. Voluptatum aut totam aperiam. Est fugit necessitatibus maxime voluptas quia porro. Et eius quas fuga vero deleniti dolorum deserunt vel.", new DateTime(2023, 2, 4, 19, 39, 51, 329, DateTimeKind.Utc).AddTicks(5395), 40L, false },
                    { 13L, 98L, "dicta", new DateTime(2022, 8, 4, 8, 59, 5, 360, DateTimeKind.Utc).AddTicks(3969), 36L, false },
                    { 14L, 148L, "Quo voluptatem rerum corporis quidem veritatis velit explicabo. Labore nam vitae voluptas. Iste accusantium temporibus. Omnis similique distinctio ut quod aperiam. Cupiditate accusantium nesciunt aperiam ducimus non.", new DateTime(2022, 5, 28, 6, 0, 54, 969, DateTimeKind.Utc).AddTicks(6345), 8L, true },
                    { 15L, 69L, "maiores", new DateTime(2023, 1, 7, 4, 42, 38, 352, DateTimeKind.Utc).AddTicks(9872), 23L, false },
                    { 16L, 140L, "Sit sit quibusdam ab quia nobis.\nPariatur aperiam voluptatibus.\nQuia culpa id.", new DateTime(2023, 8, 27, 12, 55, 43, 617, DateTimeKind.Utc).AddTicks(2209), 2L, true },
                    { 17L, 38L, "placeat", new DateTime(2022, 12, 10, 14, 7, 40, 522, DateTimeKind.Utc).AddTicks(3695), 36L, false },
                    { 18L, 89L, "Incidunt unde eius.\nRerum dolorem magnam nihil reprehenderit qui.\nVoluptatibus ut ea beatae accusamus eius odit sit id eum.", new DateTime(2023, 8, 15, 8, 15, 7, 325, DateTimeKind.Utc).AddTicks(995), 21L, false },
                    { 19L, 62L, "Similique eos et cupiditate.\nEst vero corporis illum deserunt magni aut sit ut.\nVel veritatis enim quo iure incidunt.\nNam aperiam velit voluptas expedita error consequatur optio laudantium quis.\nEt dolores aliquam architecto qui dolor cumque.", new DateTime(2023, 2, 7, 22, 45, 37, 85, DateTimeKind.Utc).AddTicks(7966), 3L, false },
                    { 20L, 2L, "Atque ipsum ex laudantium expedita. Et tenetur cum voluptatum et quia eaque doloribus nostrum dolores. Magni voluptas rem. Assumenda et nemo est sunt.", new DateTime(2023, 9, 20, 11, 43, 33, 72, DateTimeKind.Utc).AddTicks(1092), 19L, false },
                    { 21L, 137L, "inventore", new DateTime(2023, 8, 28, 8, 36, 42, 687, DateTimeKind.Utc).AddTicks(2225), 7L, true }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "IsPublic" },
                values: new object[,]
                {
                    { 22L, 56L, "Aut ut exercitationem aut.", new DateTime(2023, 2, 9, 6, 5, 40, 880, DateTimeKind.Utc).AddTicks(2587), 19L, false },
                    { 23L, 26L, "impedit", new DateTime(2023, 4, 11, 16, 17, 57, 534, DateTimeKind.Utc).AddTicks(1324), 38L, true },
                    { 24L, 2L, "pariatur", new DateTime(2023, 9, 10, 15, 42, 19, 376, DateTimeKind.Utc).AddTicks(5644), 38L, false },
                    { 25L, 30L, "Ea et quo iusto natus ducimus perspiciatis illum eveniet eaque. Voluptas dolores dolor voluptatem enim praesentium pariatur deleniti hic corporis. Quia et unde et accusantium deleniti praesentium laudantium. Autem labore esse recusandae laborum dolorum. Eveniet soluta mollitia necessitatibus ipsam.", new DateTime(2023, 8, 29, 13, 21, 51, 193, DateTimeKind.Utc).AddTicks(2706), 7L, true },
                    { 26L, 79L, "Totam velit autem et fuga est.\nNon rerum quidem quam et.\nIusto harum excepturi dicta beatae.\nUt eligendi fugit tenetur.\nAliquid velit ex itaque eos eum veniam ex fuga.\nRepellat non alias.", new DateTime(2023, 8, 15, 17, 51, 9, 553, DateTimeKind.Utc).AddTicks(3918), 10L, false },
                    { 27L, 52L, "Voluptatem provident provident aut est.\nVitae natus et voluptatem quo aliquid et.\nVoluptatem non suscipit eum quasi et aliquid.\nOdio nemo odio.", new DateTime(2022, 9, 8, 13, 4, 50, 286, DateTimeKind.Utc).AddTicks(3124), 19L, true },
                    { 28L, 148L, "Et optio sed. Aut voluptatum sit voluptas corporis est molestiae corporis nisi. Delectus molestiae ea culpa voluptates et et sapiente.", new DateTime(2021, 8, 28, 14, 25, 6, 46, DateTimeKind.Utc).AddTicks(9326), 4L, true },
                    { 29L, 9L, "Voluptatem dolorum ad et.", new DateTime(2023, 2, 27, 16, 14, 4, 431, DateTimeKind.Utc).AddTicks(6504), 28L, false },
                    { 30L, 41L, "dignissimos", new DateTime(2023, 8, 13, 1, 12, 36, 100, DateTimeKind.Utc).AddTicks(1391), 3L, false },
                    { 31L, 17L, "et", new DateTime(2023, 9, 22, 8, 35, 27, 938, DateTimeKind.Utc).AddTicks(1734), 39L, true },
                    { 32L, 42L, "Aut nihil dicta.", new DateTime(2023, 9, 19, 5, 14, 34, 496, DateTimeKind.Utc).AddTicks(8337), 28L, true },
                    { 33L, 81L, "Distinctio aperiam ratione corporis soluta qui quos incidunt.", new DateTime(2023, 7, 7, 5, 6, 21, 277, DateTimeKind.Utc).AddTicks(4655), 17L, false },
                    { 34L, 92L, "At officiis omnis. Inventore tenetur voluptatem est est. Occaecati similique ut minus voluptatem consequatur facere optio porro libero. Et odio occaecati dolor facilis et voluptas pariatur eaque.", new DateTime(2023, 9, 7, 0, 30, 0, 623, DateTimeKind.Utc).AddTicks(2790), 19L, true },
                    { 35L, 45L, "Non sint minima est in eum nihil.", new DateTime(2022, 9, 8, 11, 51, 54, 607, DateTimeKind.Utc).AddTicks(9699), 36L, true },
                    { 36L, 27L, "Itaque nam eligendi velit culpa.", new DateTime(2022, 10, 20, 10, 46, 21, 513, DateTimeKind.Utc).AddTicks(3643), 18L, false },
                    { 37L, 7L, "esse", new DateTime(2022, 1, 27, 18, 33, 18, 473, DateTimeKind.Utc).AddTicks(665), 32L, false },
                    { 38L, 30L, "Aut nemo dolore aut beatae.", new DateTime(2023, 8, 5, 5, 56, 1, 909, DateTimeKind.Utc).AddTicks(2847), 38L, true },
                    { 39L, 150L, "Beatae ex exercitationem et ea aut.", new DateTime(2023, 9, 13, 16, 55, 30, 888, DateTimeKind.Utc).AddTicks(3441), 40L, true },
                    { 40L, 5L, "Beatae est quam et quisquam laudantium officia. Aut fugiat est quo magnam sint eos molestiae. Aliquam enim omnis totam ea. Aut repudiandae est molestiae rerum enim magnam laboriosam labore corrupti. Est iure qui omnis modi consequatur vero maxime. Cupiditate occaecati distinctio voluptatem quos illo rerum est id error.", new DateTime(2023, 9, 12, 8, 57, 23, 126, DateTimeKind.Utc).AddTicks(7205), 29L, true },
                    { 41L, 76L, "Sed cumque nihil.\nQuos sed ut perspiciatis autem rem id est aperiam.\nEt quisquam reprehenderit commodi veniam magnam dolores.\nFugiat commodi non id tempore ducimus.\nAlias officia quia animi ratione enim sequi voluptatem.\nAperiam maiores enim.", new DateTime(2022, 8, 3, 11, 4, 35, 733, DateTimeKind.Utc).AddTicks(6231), 24L, false },
                    { 42L, 8L, "nihil", new DateTime(2022, 3, 8, 9, 35, 33, 548, DateTimeKind.Utc).AddTicks(4236), 15L, true },
                    { 43L, 41L, "Cumque culpa aut et inventore.", new DateTime(2023, 9, 6, 17, 5, 25, 422, DateTimeKind.Utc).AddTicks(1338), 35L, false },
                    { 44L, 14L, "In quia rerum tempora voluptas in quis sit ullam earum. Minus magnam voluptatem non ut laborum sit veniam cum sequi. Ut similique ipsum quis voluptatem est qui quia velit. Repudiandae cumque earum debitis illum fugiat aliquid hic. Odit doloremque possimus. Quis et aperiam aut doloribus magnam similique fuga.", new DateTime(2023, 7, 11, 22, 29, 56, 649, DateTimeKind.Utc).AddTicks(3127), 22L, false },
                    { 45L, 23L, "Deleniti eos sint.", new DateTime(2023, 5, 2, 18, 48, 42, 905, DateTimeKind.Utc).AddTicks(8280), 22L, true },
                    { 46L, 36L, "Et vitae omnis. Suscipit quidem ab voluptas qui officiis et tempore tempora ut. Officiis nulla architecto et. Esse expedita et omnis officiis consequatur cupiditate sint vero incidunt. Omnis et tenetur voluptatem et rem qui.", new DateTime(2023, 7, 21, 13, 7, 49, 519, DateTimeKind.Utc).AddTicks(5697), 28L, true },
                    { 47L, 32L, "dignissimos", new DateTime(2023, 7, 18, 0, 31, 12, 896, DateTimeKind.Utc).AddTicks(5757), 37L, false },
                    { 48L, 91L, "corporis", new DateTime(2023, 6, 11, 18, 19, 55, 768, DateTimeKind.Utc).AddTicks(8233), 1L, true },
                    { 49L, 2L, "Alias aut cupiditate fugit magni maiores repudiandae.\nDolore est enim illum magnam.\nQuaerat repellendus quia exercitationem minus in.\nSint et eveniet.\nNecessitatibus omnis perspiciatis reprehenderit provident corrupti quis sequi voluptas rem.\nVoluptas commodi unde optio dolorem architecto.", new DateTime(2023, 9, 19, 2, 23, 6, 914, DateTimeKind.Utc).AddTicks(3553), 26L, true },
                    { 50L, 12L, "Quia eligendi veniam itaque quam occaecati. Ipsa et dolores et et consequatur. Porro quia maiores distinctio et recusandae dolor voluptatem sapiente placeat. Voluptate maiores molestias. Aliquam magnam odit et quia quasi quo quia aliquid. Aut maiores iusto dolores tempora corporis voluptatem quibusdam.", new DateTime(2023, 9, 11, 6, 47, 14, 60, DateTimeKind.Utc).AddTicks(4228), 4L, true },
                    { 51L, 177L, "eos", new DateTime(2023, 7, 6, 11, 24, 43, 318, DateTimeKind.Utc).AddTicks(5263), 13L, true },
                    { 52L, 21L, "Sed aut quia.\nRerum dolores dolor dolore voluptates.\nSint quidem non fugit rerum ut rerum minus dignissimos est.\nRerum numquam autem mollitia amet dolore nobis.\nVoluptas odit tempore ducimus quisquam enim.\nQuaerat omnis nisi.", new DateTime(2023, 1, 6, 9, 34, 13, 756, DateTimeKind.Utc).AddTicks(6012), 23L, true },
                    { 53L, 37L, "Voluptatem dolores maxime voluptatem.", new DateTime(2023, 8, 21, 0, 22, 13, 270, DateTimeKind.Utc).AddTicks(5344), 40L, true },
                    { 54L, 84L, "ea", new DateTime(2023, 9, 8, 1, 35, 2, 332, DateTimeKind.Utc).AddTicks(1317), 16L, false },
                    { 55L, 31L, "Assumenda qui assumenda.\nAmet quia nulla recusandae.\nConsequuntur reprehenderit ad.\nInventore optio quibusdam et in.\nQuas distinctio dolor.\nAut qui voluptatem voluptatem dolorum.", new DateTime(2023, 9, 18, 8, 5, 19, 472, DateTimeKind.Utc).AddTicks(8064), 40L, false },
                    { 56L, 141L, "Repellendus quae est sint fugiat non.", new DateTime(2022, 5, 8, 1, 17, 39, 938, DateTimeKind.Utc).AddTicks(1843), 9L, true },
                    { 57L, 19L, "Nisi tenetur delectus facere sed est eum et officia.\nDistinctio distinctio accusamus rerum tempora soluta non qui maxime.\nEveniet ad est ratione quo quod quia id sunt ut.\nQuas voluptas voluptatum.\nLibero veniam quia dolor repellat eveniet a adipisci aliquam doloribus.\nDelectus ipsa tempore voluptate repellat.", new DateTime(2023, 9, 6, 10, 2, 20, 687, DateTimeKind.Utc).AddTicks(4758), 34L, false },
                    { 58L, 117L, "corporis", new DateTime(2023, 6, 22, 15, 9, 47, 853, DateTimeKind.Utc).AddTicks(2416), 19L, true },
                    { 59L, 1L, "Id nesciunt saepe qui voluptates natus in. Ea maxime explicabo. Beatae qui nesciunt blanditiis omnis beatae non neque aut et. Earum provident et commodi laudantium vitae voluptatem rem. Aspernatur culpa occaecati. Commodi similique magni fugit aut voluptates temporibus sed minus.", new DateTime(2022, 3, 21, 2, 37, 59, 638, DateTimeKind.Utc).AddTicks(7828), 37L, false },
                    { 60L, 150L, "Pariatur optio facilis eum sint hic.\nConsequatur adipisci recusandae consequatur ipsa ad reiciendis nulla et.\nVoluptas sunt quia hic illum voluptatem veritatis sed cupiditate non.\nVoluptates blanditiis aut dolores quidem voluptatem ut.\nRecusandae eligendi ipsam velit impedit quia.", new DateTime(2023, 1, 31, 1, 0, 33, 552, DateTimeKind.Utc).AddTicks(8464), 37L, true },
                    { 61L, 181L, "Dolores aperiam suscipit dolores. Et doloremque perspiciatis culpa impedit asperiores. Suscipit explicabo id consequuntur molestias ea magnam quo. Error sit aut cum et dolorem. Architecto nesciunt consequatur soluta blanditiis consequatur esse nihil totam alias. Cupiditate ut at ex.", new DateTime(2023, 6, 26, 4, 50, 5, 916, DateTimeKind.Utc).AddTicks(9488), 27L, true },
                    { 62L, 169L, "dolor", new DateTime(2021, 6, 16, 8, 4, 32, 101, DateTimeKind.Utc).AddTicks(148), 14L, true },
                    { 63L, 157L, "porro", new DateTime(2023, 8, 24, 19, 8, 51, 310, DateTimeKind.Utc).AddTicks(9096), 14L, false }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "IsPublic" },
                values: new object[,]
                {
                    { 64L, 18L, "Rem nihil nisi ipsam. Ut cum ipsam distinctio molestias. Est voluptatum officia non. Est consequatur magni autem. Consequuntur omnis voluptatem dicta esse est atque in.", new DateTime(2023, 8, 7, 0, 51, 47, 995, DateTimeKind.Utc).AddTicks(6841), 8L, true },
                    { 65L, 157L, "eum", new DateTime(2023, 6, 17, 12, 25, 0, 962, DateTimeKind.Utc).AddTicks(86), 1L, true },
                    { 66L, 69L, "Et nostrum rerum aut et.", new DateTime(2023, 6, 3, 12, 8, 36, 61, DateTimeKind.Utc).AddTicks(1823), 29L, true },
                    { 67L, 184L, "Aut velit ut nam voluptatem tempora accusamus voluptatem adipisci.\nSint voluptas quae debitis autem quia minima natus.\nEt est dignissimos vero fugiat officiis voluptates modi.\nCupiditate omnis molestiae molestias consequatur ut delectus eligendi eaque.\nVoluptatem dolor occaecati vitae nesciunt.\nEst natus et.", new DateTime(2023, 8, 16, 20, 44, 6, 435, DateTimeKind.Utc).AddTicks(2362), 37L, true },
                    { 68L, 25L, "tenetur", new DateTime(2023, 8, 23, 23, 1, 50, 747, DateTimeKind.Utc).AddTicks(8382), 18L, true },
                    { 69L, 105L, "Consequatur sit quibusdam iusto vel aut.\nOptio voluptates soluta dolorem perferendis et et explicabo facilis quis.\nVeritatis ipsam nulla ut distinctio animi voluptatem voluptas.\nDolorem incidunt non eos non voluptatum voluptates.\nQuas quis est enim omnis animi consequatur beatae molestias.", new DateTime(2022, 12, 18, 17, 22, 22, 574, DateTimeKind.Utc).AddTicks(5659), 34L, true },
                    { 70L, 19L, "rem", new DateTime(2023, 4, 23, 1, 44, 11, 741, DateTimeKind.Utc).AddTicks(3700), 18L, false },
                    { 71L, 10L, "Velit fugit aut praesentium autem.\nEum perspiciatis rerum sed sit magni.\nEa error quam ullam porro voluptatum nesciunt.\nNulla necessitatibus repellat quas.\nPossimus autem ipsam.", new DateTime(2022, 7, 6, 1, 32, 12, 175, DateTimeKind.Utc).AddTicks(513), 14L, true },
                    { 72L, 75L, "dicta", new DateTime(2023, 9, 17, 17, 38, 42, 889, DateTimeKind.Utc).AddTicks(5125), 13L, true },
                    { 73L, 98L, "Fugit saepe excepturi et excepturi fugit deserunt ea ratione possimus. Et quia aliquid. Aut tenetur qui nihil. Tempora natus provident. Magni ducimus enim a vitae repellat voluptates sunt laudantium amet.", new DateTime(2023, 2, 6, 5, 42, 41, 486, DateTimeKind.Utc).AddTicks(7873), 20L, false },
                    { 74L, 79L, "Repudiandae non dolore quaerat iure itaque id vel commodi.\nArchitecto velit nobis id omnis.\nCupiditate temporibus et voluptas harum.\nVoluptatem nulla excepturi voluptatem voluptatem.\nIncidunt corrupti quis dolor veritatis modi ipsam.", new DateTime(2023, 9, 8, 18, 31, 28, 723, DateTimeKind.Utc).AddTicks(5284), 30L, true },
                    { 75L, 38L, "Quisquam est quo autem dolor ducimus dolor.\nSapiente autem corrupti et voluptatem mollitia dolor in.\nUt sint sed ratione officiis reiciendis saepe eos.\nQuam et quasi et quae iste.", new DateTime(2023, 4, 9, 15, 6, 5, 348, DateTimeKind.Utc).AddTicks(9647), 24L, true },
                    { 76L, 46L, "eos", new DateTime(2022, 8, 26, 17, 44, 27, 836, DateTimeKind.Utc).AddTicks(2940), 18L, true },
                    { 77L, 43L, "Quaerat architecto quisquam pariatur necessitatibus reiciendis molestias deserunt.\nMolestiae pariatur tempore earum labore voluptatem.\nQuaerat similique nesciunt.\nNon quos explicabo repellat ad iure est et.", new DateTime(2022, 11, 18, 7, 38, 50, 589, DateTimeKind.Utc).AddTicks(4784), 23L, true },
                    { 78L, 23L, "Debitis eum cumque quasi.", new DateTime(2023, 9, 16, 9, 29, 19, 107, DateTimeKind.Utc).AddTicks(417), 22L, false },
                    { 79L, 177L, "Fugiat et eveniet illo perspiciatis dolor voluptatem quis. Omnis voluptas voluptatibus quisquam sunt et consequatur facilis et. Officiis molestias ad quod ea recusandae voluptas consectetur. Suscipit sed delectus animi laudantium aliquam. Quia quo consequatur et et provident.", new DateTime(2023, 1, 8, 1, 10, 47, 366, DateTimeKind.Utc).AddTicks(6127), 18L, true },
                    { 80L, 66L, "Dolores soluta blanditiis eveniet quisquam nesciunt possimus labore natus voluptas.", new DateTime(2023, 9, 20, 2, 0, 55, 521, DateTimeKind.Utc).AddTicks(7306), 9L, true },
                    { 81L, 65L, "Autem neque sint totam magni dolor expedita fugiat.\nUt laboriosam sed impedit exercitationem dolore.", new DateTime(2023, 6, 17, 10, 57, 48, 266, DateTimeKind.Utc).AddTicks(9371), 28L, true },
                    { 82L, 40L, "Odio impedit perferendis rerum. Quia eligendi qui excepturi eveniet itaque non est hic rerum. Consequatur quas et et minima molestiae esse. Pariatur doloremque nostrum officia officiis exercitationem non voluptatem.", new DateTime(2023, 5, 29, 0, 18, 33, 679, DateTimeKind.Utc).AddTicks(7333), 29L, true },
                    { 83L, 96L, "Sit deleniti eos vero.", new DateTime(2023, 6, 14, 12, 20, 15, 804, DateTimeKind.Utc).AddTicks(2823), 24L, true },
                    { 84L, 28L, "Eum voluptas sed vitae et delectus sint nostrum.\nEaque sapiente aut odit quo.\nDelectus temporibus id aspernatur.", new DateTime(2022, 2, 8, 10, 0, 22, 859, DateTimeKind.Utc).AddTicks(4038), 3L, true },
                    { 85L, 9L, "Molestiae nihil velit aut odit.", new DateTime(2023, 8, 27, 14, 55, 35, 940, DateTimeKind.Utc).AddTicks(3408), 40L, true },
                    { 86L, 96L, "ut", new DateTime(2023, 3, 18, 18, 22, 41, 74, DateTimeKind.Utc).AddTicks(8005), 4L, true },
                    { 87L, 18L, "occaecati", new DateTime(2023, 5, 22, 15, 2, 29, 224, DateTimeKind.Utc).AddTicks(6648), 9L, true },
                    { 88L, 63L, "qui", new DateTime(2021, 11, 15, 8, 44, 27, 219, DateTimeKind.Utc).AddTicks(2015), 33L, true },
                    { 89L, 89L, "Assumenda sed aut omnis voluptatem ut ipsam.\nQuia delectus culpa rerum neque.", new DateTime(2023, 4, 29, 21, 4, 48, 275, DateTimeKind.Utc).AddTicks(6346), 10L, true },
                    { 90L, 137L, "Iste et sint.\nQuisquam necessitatibus veniam.\nEt ullam eveniet fugiat non autem enim assumenda.\nNemo voluptas quae necessitatibus sed recusandae labore quidem porro.", new DateTime(2023, 8, 21, 16, 28, 16, 369, DateTimeKind.Utc).AddTicks(9360), 11L, true },
                    { 91L, 5L, "est", new DateTime(2023, 9, 14, 21, 28, 30, 203, DateTimeKind.Utc).AddTicks(2173), 1L, true },
                    { 92L, 109L, "Ipsa molestiae aliquam et vel et quasi maxime tenetur.", new DateTime(2023, 8, 17, 12, 59, 51, 817, DateTimeKind.Utc).AddTicks(1271), 20L, true },
                    { 93L, 52L, "Totam magni aliquid maiores cum laudantium consequatur perferendis consequatur.", new DateTime(2022, 8, 17, 16, 29, 48, 79, DateTimeKind.Utc).AddTicks(7492), 9L, true },
                    { 94L, 172L, "Quam deleniti veritatis voluptatem laboriosam. Voluptatem reprehenderit doloremque dolorem necessitatibus omnis dicta quasi autem. Tempore saepe similique sint distinctio et est voluptatem eaque. Dignissimos quia perspiciatis eligendi dolorem hic. Nihil reiciendis asperiores. Voluptatem quam cum accusamus sapiente.", new DateTime(2023, 3, 16, 20, 44, 22, 318, DateTimeKind.Utc).AddTicks(2482), 23L, true },
                    { 95L, 52L, "Iusto sed aliquid tempora delectus nihil iste accusamus. Tempora molestiae nisi inventore pariatur suscipit nisi earum. Nam explicabo quibusdam dolores cupiditate voluptatum saepe ab. Voluptates aspernatur maxime autem atque nihil in odit. Rem quisquam aut quisquam.", new DateTime(2023, 8, 12, 9, 19, 1, 577, DateTimeKind.Utc).AddTicks(4664), 24L, true },
                    { 96L, 68L, "Consequatur fugit dolorum dolorem et.", new DateTime(2023, 9, 9, 11, 4, 20, 590, DateTimeKind.Utc).AddTicks(597), 26L, true },
                    { 97L, 30L, "Suscipit sint consequatur est est repellat et odio rerum atque. Dolor accusamus modi officia earum tempore tempore ut. Voluptatibus natus labore qui quis recusandae fugit.", new DateTime(2023, 9, 5, 9, 22, 55, 775, DateTimeKind.Utc).AddTicks(3480), 3L, true },
                    { 98L, 74L, "qui", new DateTime(2023, 9, 16, 18, 22, 27, 197, DateTimeKind.Utc).AddTicks(8355), 8L, true },
                    { 99L, 38L, "Quos illo eligendi voluptas autem odio ullam. Delectus voluptatem reiciendis nesciunt eaque velit. Omnis soluta quam ea voluptas aut consectetur eius culpa quod. Eaque enim quo ea tempora eveniet voluptatem.", new DateTime(2023, 8, 8, 17, 32, 39, 445, DateTimeKind.Utc).AddTicks(9932), 38L, true },
                    { 100L, 4L, "Harum impedit ad ut vitae culpa magni minus cumque. Quas ullam velit excepturi quo ullam fugiat. Officia et ea.", new DateTime(2023, 8, 24, 13, 58, 54, 407, DateTimeKind.Utc).AddTicks(9812), 23L, true },
                    { 101L, 96L, "quo", new DateTime(2023, 8, 12, 21, 16, 43, 75, DateTimeKind.Utc).AddTicks(4409), 39L, true },
                    { 102L, 94L, "Quia quia repudiandae voluptatem et nesciunt odio. Sunt tempora eveniet non atque. Mollitia vel sunt facere quia velit ducimus id eos.", new DateTime(2023, 7, 10, 8, 9, 27, 383, DateTimeKind.Utc).AddTicks(2633), 1L, false },
                    { 103L, 66L, "Qui optio minus sunt ut corporis.", new DateTime(2023, 6, 20, 2, 10, 55, 67, DateTimeKind.Utc).AddTicks(2722), 21L, true },
                    { 104L, 74L, "Aspernatur qui nisi nam neque.", new DateTime(2023, 9, 12, 2, 35, 11, 792, DateTimeKind.Utc).AddTicks(2067), 6L, true },
                    { 105L, 19L, "Quibusdam veritatis animi eaque sed excepturi. Esse eaque accusamus voluptas provident neque. Qui quas illo molestiae in eos saepe quae ut.", new DateTime(2023, 6, 11, 4, 4, 18, 300, DateTimeKind.Utc).AddTicks(1880), 2L, false }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "IsPublic" },
                values: new object[,]
                {
                    { 106L, 62L, "Ut hic at ut quis exercitationem quo nihil.", new DateTime(2022, 4, 10, 5, 24, 29, 126, DateTimeKind.Utc).AddTicks(6238), 1L, true },
                    { 107L, 29L, "quia", new DateTime(2021, 4, 14, 6, 33, 26, 475, DateTimeKind.Utc).AddTicks(8195), 33L, true },
                    { 108L, 37L, "Non beatae inventore.", new DateTime(2023, 9, 13, 11, 41, 0, 796, DateTimeKind.Utc).AddTicks(9609), 23L, true },
                    { 109L, 64L, "Sequi accusamus vitae nihil.\nSint doloribus doloribus debitis ut maxime et omnis dolore.\nVoluptatem rerum est fugit ut voluptatibus unde.\nEa amet consectetur saepe omnis.", new DateTime(2022, 6, 27, 16, 11, 7, 518, DateTimeKind.Utc).AddTicks(8517), 22L, false },
                    { 110L, 39L, "Doloremque eos aperiam nemo omnis.", new DateTime(2023, 7, 15, 14, 45, 55, 467, DateTimeKind.Utc).AddTicks(2076), 33L, true },
                    { 111L, 20L, "Cupiditate vel qui repellat libero voluptatem id et. Est omnis soluta occaecati culpa. Odio totam qui. Fuga perspiciatis exercitationem numquam iusto doloribus in quia et et.", new DateTime(2023, 3, 29, 13, 49, 0, 961, DateTimeKind.Utc).AddTicks(4331), 22L, false },
                    { 112L, 52L, "Vitae qui non quasi non sint aliquid repellat.", new DateTime(2023, 6, 1, 22, 24, 19, 578, DateTimeKind.Utc).AddTicks(7291), 15L, true },
                    { 113L, 8L, "Ex atque quibusdam rerum. Incidunt mollitia exercitationem consequatur. Pariatur aut maiores. Nobis voluptatem ut.", new DateTime(2022, 11, 5, 15, 15, 30, 951, DateTimeKind.Utc).AddTicks(8776), 38L, false },
                    { 114L, 141L, "Odit adipisci exercitationem autem pariatur quidem. Sed excepturi quod aut odio minus et ad iusto. Non occaecati reiciendis cum quo commodi.", new DateTime(2023, 5, 10, 17, 44, 26, 461, DateTimeKind.Utc).AddTicks(8185), 23L, false },
                    { 115L, 35L, "Error esse velit sit provident.\nRecusandae et dignissimos quis corporis est exercitationem et ullam dolore.", new DateTime(2022, 7, 29, 14, 5, 31, 320, DateTimeKind.Utc).AddTicks(5659), 32L, true },
                    { 116L, 49L, "Nihil explicabo temporibus.", new DateTime(2023, 5, 24, 10, 1, 56, 262, DateTimeKind.Utc).AddTicks(8484), 17L, false },
                    { 117L, 62L, "Veritatis ratione neque quia reprehenderit accusantium ea ut quis.", new DateTime(2022, 4, 27, 17, 46, 47, 102, DateTimeKind.Utc).AddTicks(4071), 4L, true },
                    { 118L, 65L, "Quia animi quos minima assumenda earum.\nNecessitatibus voluptatum doloribus voluptatem ut dolores nesciunt.", new DateTime(2023, 4, 25, 1, 9, 56, 662, DateTimeKind.Utc).AddTicks(7757), 7L, false },
                    { 119L, 16L, "et", new DateTime(2023, 6, 2, 21, 34, 56, 411, DateTimeKind.Utc).AddTicks(9790), 37L, true },
                    { 120L, 155L, "Aut assumenda consequatur ad quam omnis reiciendis. Et error consequatur inventore quia sunt enim cumque. Impedit eos fugiat consequuntur aut earum.", new DateTime(2023, 9, 12, 16, 57, 58, 984, DateTimeKind.Utc).AddTicks(6276), 18L, true },
                    { 121L, 92L, "Eligendi enim qui.", new DateTime(2023, 9, 8, 7, 42, 47, 333, DateTimeKind.Utc).AddTicks(1865), 25L, true },
                    { 122L, 15L, "Ut dolor sequi qui qui dolor sequi corrupti.", new DateTime(2022, 11, 9, 14, 5, 43, 581, DateTimeKind.Utc).AddTicks(2346), 35L, false },
                    { 123L, 53L, "Labore autem alias.\nDicta cum voluptatibus incidunt eligendi est aut exercitationem est.\nSoluta ut sequi ut nobis.\nVitae cum tempore et voluptas voluptas fugit ipsam animi.", new DateTime(2023, 7, 25, 19, 32, 40, 523, DateTimeKind.Utc).AddTicks(6952), 8L, true },
                    { 124L, 67L, "Veritatis animi nostrum vel ipsa sint.", new DateTime(2023, 9, 18, 17, 23, 8, 536, DateTimeKind.Utc).AddTicks(9342), 33L, true },
                    { 125L, 193L, "Iusto a nihil. Dolorem cumque itaque natus. Possimus et quia natus libero harum voluptatem a. Provident incidunt voluptates dolorum quis eos at facilis saepe provident. Accusamus fuga aut modi.", new DateTime(2023, 7, 21, 12, 26, 12, 752, DateTimeKind.Utc).AddTicks(3991), 26L, false },
                    { 126L, 23L, "Odio saepe commodi.\nTempora inventore deleniti dolore repudiandae velit voluptas eligendi aliquid.\nNumquam illum officia voluptas ad.", new DateTime(2023, 5, 30, 10, 49, 23, 70, DateTimeKind.Utc).AddTicks(5471), 17L, false },
                    { 127L, 150L, "Aspernatur similique autem asperiores. In similique totam temporibus perferendis aliquam non. Quibusdam neque est dolorum sit accusantium recusandae non.", new DateTime(2021, 4, 18, 2, 32, 11, 765, DateTimeKind.Utc).AddTicks(7033), 3L, false },
                    { 128L, 26L, "Aliquam eaque unde non. Eaque a repudiandae blanditiis sint expedita dignissimos quia. Occaecati velit natus veritatis quia deleniti sit nesciunt dolor voluptas. Velit expedita consectetur temporibus minus rerum distinctio fugit reprehenderit.", new DateTime(2023, 6, 26, 13, 29, 22, 906, DateTimeKind.Utc).AddTicks(322), 19L, false },
                    { 129L, 30L, "Magnam consectetur cumque ea qui consequatur facilis iure culpa. Doloribus cum aut nesciunt aspernatur aliquam. Est excepturi eum assumenda. Est aut asperiores. Qui libero assumenda minus fugiat.", new DateTime(2023, 9, 6, 23, 51, 34, 463, DateTimeKind.Utc).AddTicks(6314), 26L, true },
                    { 130L, 45L, "Eius reprehenderit perferendis et quia ut a maiores enim ut. Dolores dolore alias. Numquam quasi magni totam est.", new DateTime(2023, 9, 10, 22, 3, 26, 808, DateTimeKind.Utc).AddTicks(5801), 4L, true },
                    { 131L, 184L, "Quod et neque reprehenderit magni quia magnam quas.\nQuis ut repudiandae.\nSit aut sit dolores iste ad.\nFugiat itaque reprehenderit sunt quidem et.\nEst delectus enim eaque dolor.\nSimilique numquam sint voluptatem voluptas.", new DateTime(2023, 8, 20, 8, 43, 20, 481, DateTimeKind.Utc).AddTicks(8790), 40L, true },
                    { 132L, 13L, "nulla", new DateTime(2023, 8, 9, 6, 58, 12, 838, DateTimeKind.Utc).AddTicks(2481), 40L, true },
                    { 133L, 126L, "Qui quam ut commodi.", new DateTime(2023, 4, 5, 14, 28, 23, 705, DateTimeKind.Utc).AddTicks(3910), 27L, false },
                    { 134L, 33L, "Facilis ut consequatur sit temporibus iste et aut sunt. Expedita similique tenetur corrupti suscipit facere unde rem quam. Est magnam qui est dolorum fugiat asperiores. Velit et natus vitae ex dolores aliquid a. Sint enim distinctio inventore ut.", new DateTime(2023, 8, 5, 22, 17, 0, 72, DateTimeKind.Utc).AddTicks(6951), 38L, true },
                    { 135L, 94L, "Quos ab consequuntur fugit suscipit aut quia reprehenderit consequatur vitae.", new DateTime(2023, 1, 29, 13, 31, 8, 605, DateTimeKind.Utc).AddTicks(3304), 23L, false },
                    { 136L, 105L, "Nemo sunt numquam blanditiis eos vel vel aperiam neque.", new DateTime(2023, 9, 19, 4, 0, 55, 678, DateTimeKind.Utc).AddTicks(8017), 30L, true },
                    { 137L, 40L, "Assumenda dignissimos sed dolore ea sed ducimus placeat et.", new DateTime(2022, 7, 15, 6, 3, 13, 949, DateTimeKind.Utc).AddTicks(6911), 6L, false },
                    { 138L, 96L, "Debitis molestias quam. Aliquid quidem recusandae. Fugit tempore explicabo tenetur in et et ea. Veniam earum excepturi dignissimos recusandae aperiam.", new DateTime(2023, 9, 9, 20, 7, 28, 979, DateTimeKind.Utc).AddTicks(8517), 33L, false },
                    { 139L, 28L, "quia", new DateTime(2023, 5, 14, 10, 13, 33, 519, DateTimeKind.Utc).AddTicks(3028), 10L, true },
                    { 140L, 150L, "Similique nemo ducimus magni.\nVel magni est voluptatem dolores quia deserunt.\nNatus nihil consequatur eos nulla et earum voluptatum eligendi adipisci.\nNam quibusdam error rerum qui et ratione.", new DateTime(2023, 4, 19, 0, 47, 25, 267, DateTimeKind.Utc).AddTicks(1927), 8L, true },
                    { 141L, 116L, "quo", new DateTime(2023, 6, 11, 4, 38, 2, 20, DateTimeKind.Utc).AddTicks(400), 3L, true },
                    { 142L, 173L, "Consequatur et vel et et cupiditate vitae quis.", new DateTime(2023, 8, 9, 7, 52, 27, 328, DateTimeKind.Utc).AddTicks(6797), 26L, true },
                    { 143L, 53L, "Totam quo illum dolore odit nesciunt ut voluptatem occaecati optio. Similique ipsum ab nulla officia eos magni maiores. Debitis veniam iste rerum commodi et quos amet ut.", new DateTime(2023, 1, 25, 3, 18, 54, 271, DateTimeKind.Utc).AddTicks(7267), 39L, true },
                    { 144L, 12L, "Dolore iste ut unde sit. Eos unde necessitatibus tenetur voluptates voluptatem. Nihil et et. Veniam ipsa amet sequi accusamus rerum id nam neque ea.", new DateTime(2023, 9, 7, 12, 36, 40, 626, DateTimeKind.Utc).AddTicks(4730), 31L, true },
                    { 145L, 2L, "Iste laboriosam culpa saepe odio consequatur corrupti nihil.", new DateTime(2023, 9, 17, 9, 17, 6, 560, DateTimeKind.Utc).AddTicks(8208), 17L, true },
                    { 146L, 59L, "quasi", new DateTime(2019, 6, 16, 23, 52, 23, 190, DateTimeKind.Utc).AddTicks(1708), 33L, false },
                    { 147L, 10L, "Dolores vel tempore harum.\nVero accusantium assumenda quis sed velit distinctio laborum natus vitae.\nMinus qui rem omnis omnis ratione vel voluptatum sit quos.\nAut dolorem ducimus.\nQuibusdam autem unde nihil sapiente et voluptatem natus.\nPraesentium expedita quisquam itaque asperiores non natus molestias qui consequatur.", new DateTime(2022, 11, 27, 18, 40, 3, 611, DateTimeKind.Utc).AddTicks(4365), 11L, true }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "IsPublic" },
                values: new object[,]
                {
                    { 148L, 35L, "Error adipisci laborum iure voluptas ratione id voluptas voluptate et.", new DateTime(2021, 10, 15, 7, 33, 39, 645, DateTimeKind.Utc).AddTicks(9128), 6L, true },
                    { 149L, 141L, "totam", new DateTime(2021, 12, 26, 14, 30, 16, 761, DateTimeKind.Utc).AddTicks(6972), 4L, true },
                    { 150L, 6L, "Atque dicta recusandae qui corrupti nesciunt quis aut cupiditate.", new DateTime(2022, 12, 4, 19, 2, 26, 340, DateTimeKind.Utc).AddTicks(3626), 18L, true },
                    { 151L, 96L, "Amet ipsam illo debitis.\nVel facilis dolores consequatur enim asperiores est.\nFacere labore nostrum natus est quo non blanditiis.\nDistinctio dignissimos rem corporis.\nLabore voluptates nihil.", new DateTime(2023, 5, 20, 13, 12, 27, 776, DateTimeKind.Utc).AddTicks(6039), 33L, true },
                    { 152L, 105L, "Ab unde laboriosam aut odio iusto numquam numquam neque.", new DateTime(2023, 7, 28, 12, 10, 8, 599, DateTimeKind.Utc).AddTicks(1591), 31L, true },
                    { 153L, 44L, "Repellat quia quo alias expedita est voluptate tempora. Voluptate qui nam unde eligendi. Doloribus esse laudantium labore perferendis ut est dicta voluptatem. Dignissimos minima impedit sint quia et ab eum sit corporis. Aut suscipit fugit dignissimos eos fugit illum aperiam. Omnis libero rem aut qui ex nisi dolorum eos.", new DateTime(2023, 7, 22, 5, 13, 26, 909, DateTimeKind.Utc).AddTicks(6177), 2L, true },
                    { 154L, 41L, "non", new DateTime(2023, 9, 16, 18, 6, 25, 235, DateTimeKind.Utc).AddTicks(3772), 13L, false },
                    { 155L, 181L, "Non iure explicabo voluptatibus vitae ut quibusdam debitis ut. Illo ipsum esse omnis consequatur id cupiditate delectus dicta. Ut distinctio repudiandae distinctio voluptatem ullam. Fugit iusto et vero inventore ipsam porro eos vitae debitis. Ad asperiores dolorem maiores quia animi.", new DateTime(2023, 7, 5, 7, 20, 47, 96, DateTimeKind.Utc).AddTicks(1288), 25L, true },
                    { 156L, 89L, "Repellat necessitatibus aut et accusamus rem et distinctio dolor.\nNobis odio et recusandae asperiores vero.\nQuidem est vero odit est explicabo id voluptatibus.\nIpsam soluta autem cum totam mollitia rem.\nVero dolorem sed.\nEnim est ducimus facere quos unde qui perspiciatis est.", new DateTime(2023, 8, 12, 14, 27, 34, 38, DateTimeKind.Utc).AddTicks(1427), 27L, false },
                    { 157L, 138L, "Cum enim quibusdam. Aut sit nesciunt facere accusamus odit reiciendis. Ut esse beatae. Et pariatur commodi fugit voluptate ex adipisci perspiciatis praesentium. Nulla et eligendi consequuntur possimus nam. Commodi laboriosam perspiciatis quis optio delectus earum qui optio.", new DateTime(2023, 8, 20, 1, 5, 20, 460, DateTimeKind.Utc).AddTicks(7927), 23L, true },
                    { 158L, 76L, "Neque perferendis quasi iusto soluta cumque quia.\nMagnam quae dignissimos.\nMolestias inventore quod aliquid enim quis.", new DateTime(2022, 10, 13, 8, 38, 49, 256, DateTimeKind.Utc).AddTicks(9779), 22L, true },
                    { 159L, 38L, "Distinctio quo rem consequatur aut voluptate. Sunt et provident aut nobis tempora quia distinctio sit. Sed est cupiditate blanditiis rerum quidem. Eaque aliquam voluptas delectus. Illo impedit inventore consectetur. Sit maiores pariatur.", new DateTime(2023, 5, 4, 16, 5, 38, 12, DateTimeKind.Utc).AddTicks(8020), 26L, true },
                    { 160L, 26L, "Et nam dicta dolorem rerum veritatis aut. Nemo ea sapiente porro architecto. Assumenda quisquam facilis eveniet quis. Qui illo dolores.", new DateTime(2022, 12, 27, 17, 34, 8, 617, DateTimeKind.Utc).AddTicks(8811), 28L, true },
                    { 161L, 2L, "voluptas", new DateTime(2023, 9, 16, 7, 30, 48, 323, DateTimeKind.Utc).AddTicks(1222), 22L, false },
                    { 162L, 46L, "excepturi", new DateTime(2021, 2, 23, 16, 4, 49, 521, DateTimeKind.Utc).AddTicks(7730), 25L, true },
                    { 163L, 46L, "tenetur", new DateTime(2021, 3, 27, 3, 18, 18, 698, DateTimeKind.Utc).AddTicks(8793), 34L, false },
                    { 164L, 137L, "Occaecati sed iste asperiores cum ut et nihil in ipsum.", new DateTime(2023, 9, 18, 3, 55, 22, 725, DateTimeKind.Utc).AddTicks(1700), 11L, true },
                    { 165L, 25L, "Esse quam numquam delectus illum. Unde ipsa debitis ut inventore qui. Nam nesciunt aut omnis facilis. Quis sit ut consequatur quasi voluptate itaque.", new DateTime(2023, 9, 5, 20, 42, 7, 531, DateTimeKind.Utc).AddTicks(2718), 22L, true },
                    { 166L, 138L, "aut", new DateTime(2023, 9, 9, 13, 1, 38, 74, DateTimeKind.Utc).AddTicks(9696), 17L, true },
                    { 167L, 94L, "hic", new DateTime(2023, 9, 8, 14, 49, 50, 444, DateTimeKind.Utc).AddTicks(4979), 1L, true },
                    { 168L, 34L, "Aliquam enim quas quo aliquam. Magnam qui quia minima ratione esse qui. Debitis adipisci magnam quas magni asperiores vitae. Pariatur magnam cupiditate porro vel itaque dignissimos.", new DateTime(2023, 9, 14, 18, 45, 28, 185, DateTimeKind.Utc).AddTicks(7484), 19L, true },
                    { 169L, 105L, "Optio qui veniam labore doloribus culpa cum quia.\nEius rerum reprehenderit eum rerum.", new DateTime(2023, 3, 4, 4, 20, 42, 421, DateTimeKind.Utc).AddTicks(1436), 27L, true },
                    { 170L, 26L, "Quam magnam amet sed eligendi ipsam hic molestiae.", new DateTime(2023, 3, 27, 9, 3, 29, 528, DateTimeKind.Utc).AddTicks(8325), 29L, true },
                    { 171L, 1L, "Dolores nam eius necessitatibus.", new DateTime(2022, 4, 13, 3, 45, 50, 640, DateTimeKind.Utc).AddTicks(9651), 36L, true },
                    { 172L, 109L, "Nihil aut et occaecati et quibusdam reprehenderit voluptate totam. Ducimus in placeat unde cum. Placeat sapiente qui quas et maiores dolorum ducimus. Incidunt dolor corporis.", new DateTime(2023, 8, 9, 13, 43, 54, 977, DateTimeKind.Utc).AddTicks(7186), 30L, false },
                    { 173L, 49L, "Quia qui voluptate mollitia aut. Aperiam itaque a ab voluptatem. Nisi sit officiis qui quo in. Ad odio corrupti illo nihil eum sit sunt dolorum. Molestias sit occaecati maiores ad rem dolor laboriosam. Nihil sit laudantium quae nam.", new DateTime(2023, 7, 12, 2, 0, 6, 59, DateTimeKind.Utc).AddTicks(5721), 31L, false },
                    { 174L, 7L, "Doloremque et architecto corrupti fugiat porro in voluptatibus. Eos incidunt velit voluptatem. Accusamus maxime atque quasi eos optio. Nisi optio dolorum consequatur qui qui expedita deserunt fuga. Sed quo accusantium deleniti ipsam dignissimos dolores. Facere dolor ea sequi voluptas tenetur.", new DateTime(2021, 3, 28, 15, 1, 16, 491, DateTimeKind.Utc).AddTicks(4587), 9L, false },
                    { 175L, 45L, "ad", new DateTime(2023, 7, 15, 13, 44, 7, 48, DateTimeKind.Utc).AddTicks(9424), 9L, true },
                    { 176L, 37L, "Soluta odio eveniet quod reprehenderit officia.\nAut cumque labore ut omnis.", new DateTime(2023, 8, 21, 16, 5, 32, 632, DateTimeKind.Utc).AddTicks(4497), 26L, false },
                    { 177L, 49L, "Vero nam possimus laborum. Consequuntur molestias ut numquam consequatur dolores sit. Ratione maiores illum alias vero eaque delectus similique natus. Aliquid perspiciatis magnam aut repellendus quis quod alias corporis.", new DateTime(2023, 8, 26, 14, 34, 46, 7, DateTimeKind.Utc).AddTicks(4332), 13L, true },
                    { 178L, 61L, "Et aut labore et aut. Illo dolor voluptate ipsam. Fuga magnam officiis voluptatum. Exercitationem dolorem voluptate quasi aliquid sequi est. Voluptatum alias adipisci. Exercitationem fugiat adipisci saepe dolor natus nihil dicta voluptas.", new DateTime(2023, 6, 23, 20, 10, 5, 167, DateTimeKind.Utc).AddTicks(2844), 6L, false },
                    { 179L, 58L, "similique", new DateTime(2023, 9, 1, 4, 33, 55, 979, DateTimeKind.Utc).AddTicks(6785), 5L, true },
                    { 180L, 13L, "Debitis sit delectus sint possimus earum praesentium nesciunt sit deserunt.", new DateTime(2023, 9, 4, 18, 47, 4, 944, DateTimeKind.Utc).AddTicks(4244), 11L, true },
                    { 181L, 106L, "Ducimus est qui reprehenderit nostrum.\nDicta voluptatem culpa minima officia aliquam rerum ex magnam.", new DateTime(2023, 9, 1, 0, 13, 21, 239, DateTimeKind.Utc).AddTicks(9874), 17L, false },
                    { 182L, 52L, "autem", new DateTime(2023, 8, 13, 15, 40, 2, 447, DateTimeKind.Utc).AddTicks(2518), 39L, true },
                    { 183L, 81L, "et", new DateTime(2023, 6, 11, 17, 51, 8, 852, DateTimeKind.Utc).AddTicks(5500), 9L, true },
                    { 184L, 15L, "Tempore veritatis aut non qui eius aut aliquam quia. Officiis et ut ut pariatur et velit totam. Necessitatibus voluptates voluptatem quasi corrupti totam ratione saepe ducimus. Consequatur sunt deserunt ut.", new DateTime(2023, 6, 11, 6, 15, 32, 473, DateTimeKind.Utc).AddTicks(8321), 8L, true },
                    { 185L, 110L, "Animi ut sed dolore sapiente sunt sit voluptates tempore.", new DateTime(2023, 4, 9, 18, 37, 11, 489, DateTimeKind.Utc).AddTicks(8571), 33L, false },
                    { 186L, 155L, "praesentium", new DateTime(2023, 9, 11, 21, 19, 36, 589, DateTimeKind.Utc).AddTicks(1142), 40L, true },
                    { 187L, 40L, "odio", new DateTime(2023, 5, 27, 22, 35, 8, 866, DateTimeKind.Utc).AddTicks(6817), 6L, true },
                    { 188L, 28L, "Sed omnis distinctio.\nBeatae quidem nesciunt perspiciatis temporibus omnis.\nQui ducimus ut.", new DateTime(2022, 11, 30, 0, 56, 14, 969, DateTimeKind.Utc).AddTicks(9899), 10L, true },
                    { 189L, 33L, "Dignissimos consectetur aperiam adipisci corporis.", new DateTime(2023, 8, 24, 18, 40, 15, 725, DateTimeKind.Utc).AddTicks(8637), 11L, true }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "IsPublic" },
                values: new object[,]
                {
                    { 190L, 57L, "Consequatur perferendis autem sed magni dignissimos. Dicta vitae sint dolores officiis rerum sunt laborum. Aut omnis eveniet dolore. Molestiae natus molestiae sint.", new DateTime(2021, 11, 10, 8, 41, 55, 993, DateTimeKind.Utc).AddTicks(5946), 33L, true },
                    { 191L, 24L, "Suscipit quo officia et dignissimos aut non temporibus fugiat. Ad cupiditate inventore neque enim. Expedita consectetur ipsum magni. Adipisci adipisci rerum. Et id libero corporis sint nulla.", new DateTime(2023, 7, 20, 15, 20, 54, 384, DateTimeKind.Utc).AddTicks(3709), 14L, true },
                    { 192L, 22L, "quas", new DateTime(2023, 9, 10, 7, 49, 59, 398, DateTimeKind.Utc).AddTicks(6311), 1L, false },
                    { 193L, 150L, "velit", new DateTime(2023, 5, 24, 3, 51, 16, 518, DateTimeKind.Utc).AddTicks(3990), 2L, true },
                    { 194L, 62L, "Non voluptatem illo porro.", new DateTime(2022, 12, 5, 18, 13, 55, 659, DateTimeKind.Utc).AddTicks(2487), 6L, false },
                    { 195L, 90L, "Dolores eos atque sint iusto beatae et.\nFuga dolores quo deleniti molestiae dolorem aut voluptatibus.\nMinima ut quam asperiores magnam sint quis voluptas temporibus.\nDolor fuga qui distinctio et velit.\nQuas iure fuga dolores.\nSunt autem ratione qui sit eius.", new DateTime(2023, 8, 21, 5, 43, 51, 966, DateTimeKind.Utc).AddTicks(9339), 22L, true },
                    { 196L, 35L, "Totam natus qui dolore.\nAut voluptatem facilis mollitia laudantium.\nTempora voluptatum voluptates.", new DateTime(2022, 8, 9, 0, 56, 43, 988, DateTimeKind.Utc).AddTicks(6157), 27L, true },
                    { 197L, 61L, "Quibusdam distinctio fuga pariatur occaecati.", new DateTime(2023, 4, 27, 14, 7, 7, 905, DateTimeKind.Utc).AddTicks(8850), 4L, true },
                    { 198L, 98L, "Aperiam quam sit quidem animi quaerat ipsa excepturi nisi fugiat. Voluptas ab quas ut nemo qui eum necessitatibus magni consequatur. Odio aut recusandae.", new DateTime(2023, 8, 29, 9, 25, 14, 317, DateTimeKind.Utc).AddTicks(4749), 35L, false },
                    { 199L, 89L, "deleniti", new DateTime(2022, 7, 30, 2, 27, 23, 198, DateTimeKind.Utc).AddTicks(9942), 8L, true },
                    { 200L, 83L, "culpa", new DateTime(2023, 7, 10, 11, 40, 56, 223, DateTimeKind.Utc).AddTicks(9607), 17L, true }
                });

            migrationBuilder.InsertData(
                table: "UserBadges",
                columns: new[] { "Id", "BadgeId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[,]
                {
                    { 1L, 10L, new DateTime(2023, 9, 22, 11, 42, 43, 279, DateTimeKind.Local).AddTicks(9197), null, 14L },
                    { 2L, 8L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(743), null, 25L },
                    { 3L, 12L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(771), null, 37L },
                    { 4L, 2L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(783), null, 38L },
                    { 5L, 3L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(793), null, 3L },
                    { 6L, 10L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(803), null, 24L },
                    { 7L, 3L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(812), null, 7L },
                    { 8L, 1L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(822), null, 18L },
                    { 9L, 5L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(831), null, 7L },
                    { 10L, 12L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(840), null, 35L },
                    { 11L, 1L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(850), null, 23L },
                    { 12L, 3L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(859), null, 10L },
                    { 13L, 10L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(868), null, 32L },
                    { 14L, 1L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(877), null, 33L },
                    { 15L, 11L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(901), null, 4L },
                    { 16L, 3L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(912), null, 11L },
                    { 17L, 4L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(920), null, 4L },
                    { 18L, 9L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(930), null, 9L },
                    { 19L, 10L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1072), null, 21L },
                    { 20L, 3L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1093), null, 37L },
                    { 21L, 9L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1104), null, 13L },
                    { 22L, 4L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1118), null, 5L },
                    { 23L, 11L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1134), null, 36L },
                    { 24L, 10L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1264), null, 26L },
                    { 25L, 10L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1279), null, 2L },
                    { 26L, 4L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1290), null, 20L },
                    { 27L, 4L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1298), null, 37L },
                    { 28L, 1L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1307), null, 26L },
                    { 29L, 8L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1317), null, 14L },
                    { 30L, 10L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1327), null, 39L },
                    { 31L, 9L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1340), null, 23L }
                });

            migrationBuilder.InsertData(
                table: "UserBadges",
                columns: new[] { "Id", "BadgeId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[,]
                {
                    { 32L, 8L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1350), null, 15L },
                    { 33L, 7L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1360), null, 31L },
                    { 34L, 12L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1421), null, 40L },
                    { 35L, 8L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1433), null, 14L },
                    { 36L, 1L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1448), null, 27L },
                    { 37L, 8L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1456), null, 5L },
                    { 38L, 11L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1465), null, 2L },
                    { 39L, 9L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1475), null, 17L },
                    { 40L, 5L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1484), null, 23L },
                    { 41L, 10L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1492), null, 38L },
                    { 42L, 8L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1505), null, 14L },
                    { 43L, 6L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1522), null, 37L },
                    { 44L, 3L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1541), null, 8L },
                    { 45L, 8L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1550), null, 7L },
                    { 46L, 1L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1558), null, 8L },
                    { 47L, 9L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1567), null, 15L },
                    { 48L, 2L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1575), null, 14L },
                    { 49L, 5L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1584), null, 23L },
                    { 50L, 11L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1592), null, 17L },
                    { 51L, 5L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1602), null, 17L },
                    { 52L, 11L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1734), null, 14L },
                    { 53L, 8L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1747), null, 14L },
                    { 54L, 7L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1756), null, 20L },
                    { 55L, 1L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1767), null, 22L },
                    { 56L, 6L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1775), null, 33L },
                    { 57L, 6L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1787), null, 16L },
                    { 58L, 9L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1813), null, 7L },
                    { 59L, 10L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1829), null, 35L },
                    { 60L, 1L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1838), null, 13L },
                    { 61L, 3L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1850), null, 26L },
                    { 62L, 3L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1863), null, 10L },
                    { 63L, 3L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1872), null, 15L },
                    { 64L, 12L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1894), null, 1L },
                    { 65L, 5L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1912), null, 12L },
                    { 66L, 2L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1924), null, 5L },
                    { 67L, 7L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1938), null, 30L },
                    { 68L, 2L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1951), null, 3L },
                    { 69L, 2L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1966), null, 21L },
                    { 70L, 11L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1980), null, 22L },
                    { 71L, 12L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(1988), null, 14L },
                    { 72L, 9L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(2000), null, 15L },
                    { 73L, 11L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(2015), null, 1L }
                });

            migrationBuilder.InsertData(
                table: "UserBadges",
                columns: new[] { "Id", "BadgeId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[,]
                {
                    { 74L, 1L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(2025), null, 18L },
                    { 75L, 8L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(2041), null, 28L },
                    { 76L, 9L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(2050), null, 16L },
                    { 77L, 10L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(2060), null, 24L },
                    { 78L, 12L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(2069), null, 9L },
                    { 79L, 3L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(2128), null, 6L },
                    { 80L, 10L, new DateTime(2023, 9, 22, 11, 42, 43, 280, DateTimeKind.Local).AddTicks(2144), null, 15L }
                });

            migrationBuilder.InsertData(
                table: "ChallengeTags",
                columns: new[] { "ChallengeId", "TagId" },
                values: new object[,]
                {
                    { 1L, 5L },
                    { 1L, 9L },
                    { 2L, 5L },
                    { 2L, 8L },
                    { 3L, 5L },
                    { 3L, 6L },
                    { 4L, 4L },
                    { 4L, 9L },
                    { 5L, 4L },
                    { 5L, 7L },
                    { 6L, 3L },
                    { 6L, 5L },
                    { 7L, 1L },
                    { 7L, 4L },
                    { 8L, 2L },
                    { 8L, 5L },
                    { 9L, 5L },
                    { 9L, 6L },
                    { 10L, 5L },
                    { 10L, 9L },
                    { 11L, 2L },
                    { 11L, 5L },
                    { 12L, 2L },
                    { 12L, 6L },
                    { 13L, 6L },
                    { 13L, 7L },
                    { 14L, 2L },
                    { 14L, 5L },
                    { 15L, 1L },
                    { 15L, 4L },
                    { 16L, 1L },
                    { 16L, 6L },
                    { 17L, 1L },
                    { 17L, 9L },
                    { 18L, 5L },
                    { 18L, 7L },
                    { 19L, 2L },
                    { 19L, 3L },
                    { 20L, 6L },
                    { 20L, 9L },
                    { 21L, 5L },
                    { 21L, 6L }
                });

            migrationBuilder.InsertData(
                table: "ChallengeTags",
                columns: new[] { "ChallengeId", "TagId" },
                values: new object[,]
                {
                    { 22L, 4L },
                    { 22L, 9L },
                    { 23L, 3L },
                    { 23L, 7L },
                    { 24L, 3L },
                    { 24L, 5L },
                    { 25L, 1L },
                    { 25L, 2L },
                    { 26L, 3L },
                    { 26L, 4L },
                    { 27L, 6L },
                    { 28L, 1L },
                    { 28L, 5L },
                    { 29L, 6L },
                    { 29L, 9L },
                    { 30L, 1L },
                    { 30L, 2L },
                    { 31L, 3L },
                    { 32L, 8L },
                    { 33L, 5L },
                    { 33L, 8L },
                    { 34L, 3L },
                    { 34L, 6L },
                    { 35L, 2L },
                    { 35L, 3L },
                    { 36L, 2L },
                    { 36L, 7L },
                    { 37L, 1L },
                    { 37L, 2L },
                    { 38L, 1L },
                    { 38L, 7L },
                    { 39L, 3L },
                    { 39L, 7L },
                    { 40L, 2L },
                    { 40L, 8L },
                    { 41L, 3L },
                    { 42L, 1L },
                    { 42L, 4L },
                    { 43L, 1L },
                    { 43L, 6L },
                    { 44L, 2L },
                    { 44L, 4L }
                });

            migrationBuilder.InsertData(
                table: "ChallengeTags",
                columns: new[] { "ChallengeId", "TagId" },
                values: new object[,]
                {
                    { 45L, 8L },
                    { 45L, 9L },
                    { 46L, 1L },
                    { 46L, 7L },
                    { 47L, 2L },
                    { 47L, 3L },
                    { 48L, 3L },
                    { 48L, 4L },
                    { 49L, 3L },
                    { 49L, 5L },
                    { 50L, 2L },
                    { 50L, 6L },
                    { 51L, 7L },
                    { 51L, 9L },
                    { 52L, 3L },
                    { 52L, 6L },
                    { 53L, 1L },
                    { 53L, 7L },
                    { 54L, 2L },
                    { 54L, 4L },
                    { 55L, 1L },
                    { 55L, 2L },
                    { 56L, 6L },
                    { 56L, 9L },
                    { 57L, 2L },
                    { 58L, 2L },
                    { 59L, 4L },
                    { 59L, 8L },
                    { 60L, 4L },
                    { 60L, 9L },
                    { 61L, 6L },
                    { 61L, 9L },
                    { 62L, 1L },
                    { 62L, 8L },
                    { 63L, 2L },
                    { 63L, 8L },
                    { 64L, 3L },
                    { 64L, 6L },
                    { 65L, 2L },
                    { 65L, 7L },
                    { 66L, 4L },
                    { 66L, 7L }
                });

            migrationBuilder.InsertData(
                table: "ChallengeTags",
                columns: new[] { "ChallengeId", "TagId" },
                values: new object[,]
                {
                    { 67L, 6L },
                    { 67L, 7L },
                    { 68L, 2L },
                    { 68L, 3L },
                    { 69L, 4L },
                    { 69L, 8L },
                    { 70L, 6L },
                    { 70L, 9L }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[,]
                {
                    { 1L, 2L, "Doloribus modi voluptatum facere eius rerum provident nemo soluta quidem.", new DateTime(2019, 4, 11, 18, 49, 11, 682, DateTimeKind.Utc).AddTicks(4758), 21L, "Est aut repellendus qui fugit. Sed fugit explicabo autem cum consequuntur alias. Quo alias et quisquam voluptates. Nisi voluptatem omnis inventore velit ipsum maxime fuga.", "Eos quae aliquid qui est sit quidem doloribus.", 2L, "", 0, "Dolores nostrum earum deleniti iusto aut nesciunt modi et." },
                    { 2L, 3L, "maxime", new DateTime(2023, 9, 10, 1, 17, 25, 943, DateTimeKind.Utc).AddTicks(9021), 30L, "Cum voluptatibus quibusdam corporis saepe dolores.\nError magni eum dolore minima amet.\nTemporibus esse magni nihil est officiis ducimus aut dolorem sit.\nUllam nulla iure.\nMinima accusamus magnam quia laudantium id ut corrupti.", "Dolores et fugit vero vitae adipisci odit aspernatur.", 1L, "", 1, "Voluptatum quia quia nesciunt sequi impedit necessitatibus voluptas repellat.\nOmnis est magnam rerum eum repudiandae minima tenetur.\nAtque reprehenderit accusamus dolore est.\nMaiores non et perspiciatis.\nMinima pariatur dignissimos eum." },
                    { 3L, 4L, "Corrupti iusto ipsam sapiente.", new DateTime(2023, 2, 9, 11, 23, 55, 799, DateTimeKind.Utc).AddTicks(2439), 9L, "nam", "Perferendis nesciunt minima cupiditate.", 2L, "", 2, "maxime" },
                    { 4L, 5L, "quisquam", new DateTime(2023, 8, 21, 14, 43, 59, 403, DateTimeKind.Utc).AddTicks(4042), 34L, "Eveniet ut delectus voluptates dolorem laudantium laudantium.\nSequi officiis sapiente et ducimus fugiat exercitationem dolorem adipisci veniam.\nQuidem earum tempore molestias commodi eaque.\nPorro impedit libero aut.\nExpedita expedita est fugit mollitia aut ab eum.\nQuaerat consequatur distinctio illo maiores sit molestiae.", "Perferendis et pariatur sapiente repellat.", 1L, "", 3, "Molestiae hic et officiis accusantium nostrum repellat aut et." },
                    { 5L, 6L, "Enim aliquid neque nemo dolore possimus quisquam optio veniam. Qui nulla vel in. Blanditiis vel sit. Cupiditate quo quo doloribus sunt unde ex doloremque necessitatibus. Veniam dolor officiis eos molestias explicabo enim necessitatibus soluta.", new DateTime(2023, 8, 3, 0, 39, 28, 58, DateTimeKind.Utc).AddTicks(4191), 38L, "Tempore provident inventore voluptas nihil rerum totam expedita hic vel.", "Aut ullam distinctio tempora omnis animi officiis.", 2L, "", 3, "Ullam unde libero dolorem voluptatem et. Eius nemo modi. Ipsum modi eaque iusto commodi architecto omnis necessitatibus est. Eos repellat delectus culpa maiores officiis deleniti cumque similique. Et sed ab esse quis voluptatem et veniam." },
                    { 6L, 7L, "Laborum illo ipsum fuga ratione ipsa sequi.\nQui dolor nesciunt sit itaque quidem.\nNisi voluptate qui placeat facere omnis ea quia ea voluptatibus.\nLaborum sit consequatur iure nisi voluptatem temporibus sed.\nEst totam voluptas excepturi et expedita dignissimos et.", new DateTime(2022, 5, 26, 20, 48, 53, 739, DateTimeKind.Utc).AddTicks(2293), 38L, "est", "Unde nihil officia minima quae id.", 1L, "", 2, "atque" },
                    { 7L, 8L, "Iusto consequatur ut. Et tempora officiis error enim nulla. Suscipit molestiae perferendis. Debitis consequuntur perspiciatis dolorum architecto placeat error eum aut repellendus.", new DateTime(2018, 6, 18, 16, 27, 4, 265, DateTimeKind.Utc).AddTicks(7980), 15L, "Atque inventore beatae totam.\nNecessitatibus velit quia et pariatur voluptas veniam rerum sed qui.\nAccusamus fuga id dolorum praesentium.", "Assumenda maiores placeat magnam debitis assumenda facilis velit et.", 1L, "", 0, "Cumque velit aspernatur voluptatum fugiat aut consequatur est voluptatum." },
                    { 8L, 9L, "In dolores perferendis libero aspernatur praesentium sint quis eos et.", new DateTime(2021, 6, 7, 10, 43, 6, 939, DateTimeKind.Utc).AddTicks(2559), 38L, "voluptatem", "Voluptatem ea natus quis dignissimos.", 2L, "", 1, "Officia harum in ab at at dolorem qui nobis. Rerum quo aliquam. Et illo voluptas culpa ea ducimus ea. Et eum est est neque qui." },
                    { 9L, 10L, "a", new DateTime(2022, 6, 23, 11, 42, 14, 228, DateTimeKind.Utc).AddTicks(6507), 19L, "Aliquid dolorum iste quia voluptatibus dolores nostrum ab quia dolor. Doloremque odio suscipit animi recusandae quo voluptatem odio. Esse quam ut optio quo non. Recusandae soluta ratione.", "Et dolor molestias et officia quos laboriosam porro aut.", 2L, "", 3, "Voluptatem autem voluptas ducimus maiores. Odit error adipisci ea vitae eligendi. Laboriosam commodi atque. Dolor eos est repellat enim aliquam ratione. A voluptatem assumenda delectus quaerat est recusandae aliquam provident. Rerum eius accusamus rerum recusandae cum et officia odit aliquid." },
                    { 10L, 11L, "Labore sint dolores. Totam expedita reprehenderit sed blanditiis. Qui non aliquid. Suscipit ab eaque ea consequatur aut eum impedit natus. Sint magnam incidunt velit adipisci voluptatem. Sed animi tempora blanditiis.", new DateTime(2022, 7, 5, 11, 45, 33, 13, DateTimeKind.Utc).AddTicks(5610), 9L, "In esse et veniam.", "Ut cumque sint tenetur sed et.", 2L, "", 1, "Laudantium accusantium possimus mollitia totam blanditiis odio corrupti asperiores. Dolor ut vitae aut molestias pariatur expedita provident ex. Nihil numquam nihil. Consequatur eos dolor quae." },
                    { 11L, 12L, "Exercitationem ut ut.", new DateTime(2023, 2, 7, 22, 24, 20, 433, DateTimeKind.Utc).AddTicks(1181), 37L, "Ex sit magnam animi natus deserunt voluptas.\nReprehenderit nesciunt et dignissimos omnis veniam et doloribus.\nEt accusamus nostrum aliquam.\nRepellat tenetur eaque.\nImpedit ut et sit.\nIste voluptatum at quaerat hic facilis quod.", "Aut aut molestiae quaerat.", 2L, "", 0, "facere" },
                    { 12L, 13L, "Harum nemo aliquam suscipit exercitationem error iure rerum. Et autem culpa nemo delectus voluptates. Pariatur ut nihil.", new DateTime(2023, 8, 20, 20, 4, 18, 732, DateTimeKind.Utc).AddTicks(2379), 1L, "Voluptatum amet a dolorem modi consequuntur.\nQuia commodi perferendis ut repellat dolore.\nConsequatur eveniet quidem enim quae voluptatum fugit error.\nAut veritatis quo nemo fugiat deserunt veritatis ad.\nEt nihil autem.", "Ut qui rerum quaerat perferendis iusto ea.", 1L, "", 2, "Dolorem occaecati minus natus explicabo repudiandae. Totam architecto sequi blanditiis vero nulla perspiciatis consequatur. Ut dolor ut enim atque amet quia. Dicta reiciendis aliquid doloribus qui perferendis odio ratione. Magnam atque minus." },
                    { 13L, 14L, "Ex nulla quam iste aliquam ex repudiandae atque.", new DateTime(2023, 4, 24, 2, 22, 26, 727, DateTimeKind.Utc).AddTicks(1785), 31L, "Non corporis quod eius vel ut repudiandae.\nQuis et voluptas corrupti.\nQuaerat in minus provident quae sint et dolor labore.\nAt praesentium ea ut.\nRerum ducimus repudiandae voluptatum quod sit voluptas nobis ut magni.\nExpedita non velit voluptatibus tempora explicabo quasi esse.", "Harum at maiores aut aliquid perferendis adipisci.", 1L, "", 1, "odit" },
                    { 14L, 15L, "Rerum omnis voluptatem.", new DateTime(2023, 6, 21, 5, 17, 42, 975, DateTimeKind.Utc).AddTicks(7550), 15L, "At maxime dolorem recusandae necessitatibus dolores ea velit.\nLaboriosam voluptas quaerat doloribus omnis iure rerum magnam perspiciatis.\nEt vero deleniti autem culpa eaque animi ut consequatur laborum.\nQuos consequatur inventore cupiditate labore voluptas.\nNeque ducimus aliquam eos facilis dolores est.\nDoloremque aspernatur consequuntur autem beatae earum quos quo.", "Asperiores hic odio.", 1L, "", 3, "aperiam" },
                    { 15L, 16L, "A velit laudantium cupiditate veritatis ex sunt aspernatur quidem. Non nisi sit et consequatur et eius asperiores sed. Alias explicabo ipsa cum et autem nisi. Sequi aut aut nulla quod.", new DateTime(2022, 5, 11, 11, 41, 38, 210, DateTimeKind.Utc).AddTicks(7495), 33L, "Perferendis temporibus quae fugiat est consequatur quis. Ipsum veritatis in officiis et. Cum nulla rerum fuga impedit doloremque qui unde deserunt. Et aliquid ratione quisquam molestiae. Commodi qui velit incidunt nulla.", "Eveniet nostrum voluptatem eaque.", 1L, "", 2, "Harum id enim quisquam at reprehenderit beatae magnam harum. Assumenda laboriosam saepe. Non ipsa ut accusamus voluptas eos nesciunt repellendus expedita. Perferendis dolorem earum provident distinctio consequatur animi quam. Ipsum et et soluta." },
                    { 16L, 17L, "Dolores laboriosam dolores sit libero inventore odit facilis.\nTotam velit omnis ea.\nVero est odio vero optio.\nTempore est consequatur.\nOdit quia perspiciatis cumque in.", new DateTime(2023, 5, 2, 15, 5, 36, 468, DateTimeKind.Utc).AddTicks(8977), 9L, "Sit amet repudiandae unde excepturi ea et veniam veniam.\nNemo cumque ea ab.", "Qui in ea.", 1L, "", 2, "Rem cumque at consequatur tempora et facilis corporis ut iste. Autem ipsum sapiente. Qui ratione et dolores quas ut." },
                    { 17L, 18L, "Consequatur facilis quae.\nEaque doloribus aspernatur autem earum quos.\nExplicabo delectus expedita quisquam quam aspernatur vel animi nostrum.\nNecessitatibus itaque adipisci optio ab est pariatur.\nPariatur nostrum unde animi sed et illo ea sunt.", new DateTime(2023, 9, 21, 20, 33, 44, 86, DateTimeKind.Utc).AddTicks(1723), 10L, "Corporis blanditiis qui eos reprehenderit culpa sint impedit at dolor.", "Sed et harum dolores qui optio quisquam omnis est.", 2L, "", 0, "Fugit animi quo et dolorem sed ipsum." },
                    { 18L, 19L, "Inventore cupiditate doloribus ab quia et ab enim. Nesciunt debitis quis officiis quos. Saepe voluptate quia ut culpa ut.", new DateTime(2022, 11, 19, 23, 57, 58, 553, DateTimeKind.Utc).AddTicks(3649), 33L, "Corporis corporis rerum dolor sed.\nSapiente error dolore praesentium quos quia asperiores.\nImpedit tenetur voluptatem ipsum nostrum in dolores explicabo quae.\nFacere possimus sit maxime.\nEst velit vel commodi et consequatur error molestias nihil quas.", "Velit labore dolores.", 2L, "", 3, "Sit accusamus animi maxime molestiae qui.\nVoluptas quia enim.\nRecusandae ea dicta numquam.\nAccusamus qui atque dolorum odit non quis molestias.\nCorporis fugiat quis nemo culpa voluptatem omnis minus." },
                    { 19L, 20L, "Natus ullam voluptatem vel non quaerat omnis. Ea provident eius. Iste quaerat cum a dicta et ratione. Ipsam libero id iusto nobis fugiat.", new DateTime(2022, 12, 6, 16, 40, 29, 274, DateTimeKind.Utc).AddTicks(10), 28L, "Non earum qui et non saepe natus. Consequuntur vel ducimus ducimus dolor eveniet tenetur ut hic qui. Dolorem repudiandae doloribus laboriosam quo eligendi quidem.", "Vel molestias exercitationem odio.", 2L, "", 2, "Laudantium culpa accusamus fuga. Quidem excepturi ipsa explicabo. Nemo placeat soluta qui. Maxime ut cumque." },
                    { 20L, 21L, "Hic maxime tenetur nesciunt delectus omnis vero corporis.\nEt et in quis nemo ea ut quidem eius animi.", new DateTime(2023, 2, 28, 23, 42, 12, 73, DateTimeKind.Utc).AddTicks(5389), 30L, "natus", "Eum dolor optio magnam.", 2L, "", 1, "Consequatur voluptas velit cum dolore dolorum ut. Facilis voluptatem sed. Ducimus officiis non possimus." },
                    { 21L, 22L, "Autem vel aut sapiente nostrum provident.", new DateTime(2022, 11, 6, 18, 13, 51, 15, DateTimeKind.Utc).AddTicks(2998), 5L, "Adipisci eaque vero atque possimus debitis adipisci eaque. Voluptas fugiat vitae consectetur voluptates excepturi nihil voluptatem illo voluptatem. Veniam hic est architecto dolores aut quibusdam. Doloremque maxime aliquid molestiae nobis ut explicabo consequuntur. Maiores blanditiis sit quo asperiores ut harum ut ullam et.", "Nostrum neque dolorem totam non veritatis aperiam aperiam.", 1L, "", 3, "eaque" },
                    { 22L, 23L, "neque", new DateTime(2023, 9, 6, 6, 24, 53, 149, DateTimeKind.Utc).AddTicks(3064), 33L, "Velit dolor maxime tenetur molestiae distinctio commodi.\nOptio iusto pariatur eos.", "Autem maiores totam dolore voluptatem repellendus doloribus et beatae laudantium.", 1L, "", 3, "In quis vel iure blanditiis dolorem mollitia quo est quis." },
                    { 23L, 24L, "Est sint iure tenetur numquam dolor.\nQuia dolore temporibus rem suscipit excepturi dicta quas.\nOmnis cumque pariatur sapiente.", new DateTime(2023, 3, 30, 19, 28, 15, 978, DateTimeKind.Utc).AddTicks(1106), 14L, "quod", "Maiores sit qui et eveniet.", 2L, "", 0, "Autem minus in ullam.\nRepellat et ullam unde molestias natus.\nQuod reiciendis dolor atque quaerat." },
                    { 24L, 25L, "Illum aut modi quia. Quos molestiae dolorem hic consequatur. Voluptatem mollitia eius deserunt possimus repellendus laboriosam a laudantium. Sed qui quod voluptatibus illo aut omnis incidunt eligendi eveniet. Eum sapiente libero vel voluptatibus et deserunt porro ea earum.", new DateTime(2023, 5, 7, 3, 1, 31, 295, DateTimeKind.Utc).AddTicks(4257), 12L, "Numquam omnis dolorem placeat et veritatis voluptatem. Corporis qui aut quibusdam quia sunt porro. Eos adipisci aliquam impedit iure saepe dolores. Corporis voluptas labore ut expedita dolor. Aut dolorum molestiae reiciendis.", "Ut soluta sit at velit repellendus ad accusamus autem.", 2L, "", 3, "Accusamus aliquam reiciendis consectetur sint dicta eaque autem magni aliquam. Atque atque qui quis reprehenderit. Mollitia quaerat repudiandae est." },
                    { 25L, 26L, "Ut deserunt debitis et illo culpa.\nMolestiae neque voluptatem minima eligendi ducimus repudiandae.", new DateTime(2023, 7, 18, 4, 41, 0, 967, DateTimeKind.Utc).AddTicks(8718), 15L, "Deleniti itaque voluptas ducimus iusto id dignissimos dolore harum vero. Sed sapiente repellat fugit. Atque molestiae itaque excepturi praesentium qui. Hic sint aperiam. Pariatur nihil et atque est error ipsa facilis. Voluptatem dolore eum illo voluptatem reiciendis quia.", "Incidunt distinctio dolor.", 2L, "", 0, "Consequuntur cum aut dolor eligendi mollitia aut est sunt rerum. Voluptatum qui porro fugiat. Vel inventore facilis totam consequatur consequuntur. Officia optio ut expedita laudantium tempora voluptas. Labore iste eligendi illo maiores sit ipsam sunt." },
                    { 26L, 27L, "veritatis", new DateTime(2022, 11, 4, 11, 33, 3, 700, DateTimeKind.Utc).AddTicks(2931), 27L, "Provident rerum et aliquid corrupti. Ut mollitia aut corrupti. Cupiditate modi necessitatibus error corporis laborum.", "Accusamus mollitia fugiat.", 2L, "", 3, "Placeat itaque autem non in itaque deserunt." },
                    { 27L, 28L, "molestiae", new DateTime(2022, 7, 3, 23, 59, 43, 858, DateTimeKind.Utc).AddTicks(1616), 1L, "Quo vel cumque vel iusto mollitia unde.", "Dolorem sed eveniet est rerum porro et.", 1L, "", 3, "quasi" },
                    { 28L, 29L, "Blanditiis et ad sint dolorem voluptas. Voluptas qui vel. At corrupti voluptates animi reprehenderit. Autem voluptate voluptatem.", new DateTime(2021, 11, 17, 9, 16, 20, 69, DateTimeKind.Utc).AddTicks(4378), 40L, "libero", "Atque sapiente aspernatur voluptas laborum asperiores totam aperiam.", 1L, "", 0, "In possimus sit temporibus vel nesciunt id autem culpa et.\nEt in nesciunt beatae vel velit.\nOptio omnis et sed aut est esse perferendis animi.\nLabore sed quia accusamus temporibus eum.\nOmnis fugiat reiciendis dolore dolorem pariatur iusto repellendus laborum." },
                    { 29L, 30L, "dolores", new DateTime(2018, 11, 1, 1, 5, 56, 354, DateTimeKind.Utc).AddTicks(4205), 21L, "Quis voluptatem perspiciatis iusto mollitia provident non rem.\nEt unde placeat doloribus consequatur.\nEum perspiciatis temporibus illo eveniet omnis.\nSed aut est dignissimos id facilis ullam.", "Quam illum necessitatibus et veniam facilis est quis et natus.", 2L, "", 2, "aperiam" },
                    { 30L, 31L, "Mollitia hic ratione quia dolorum consequatur consectetur quibusdam nemo et.", new DateTime(2023, 7, 18, 5, 25, 3, 288, DateTimeKind.Utc).AddTicks(2724), 12L, "Velit iusto eum voluptatem molestiae quis ipsum officia.\nQuae sed porro nihil minus sapiente voluptatibus delectus est recusandae.\nRerum aut recusandae maiores.\nEsse nulla doloribus dolore suscipit alias expedita quis.\nRem et qui tempore ex.\nMolestiae commodi modi magni dicta explicabo assumenda veritatis.", "Rerum tempore et natus dolorem.", 1L, "", 2, "et" },
                    { 31L, 32L, "Laboriosam officia ipsa debitis.", new DateTime(2023, 9, 10, 18, 7, 6, 977, DateTimeKind.Utc).AddTicks(9875), 32L, "Id ad placeat aut ut.", "Qui illo tempora et nulla sint molestias.", 2L, "", 2, "Voluptatem provident magnam exercitationem." },
                    { 32L, 33L, "nulla", new DateTime(2023, 4, 29, 7, 39, 19, 223, DateTimeKind.Utc).AddTicks(8447), 27L, "quidem", "Illo ad aperiam laudantium velit et non rerum.", 1L, "", 0, "dolore" },
                    { 33L, 34L, "Et provident laborum provident assumenda nulla ut ut sit. Consequatur eos sunt voluptatem quos aliquam fugit. Eligendi aut ab maiores quo totam quasi delectus. Vel nihil voluptas incidunt earum dolor maiores qui. Velit aut voluptatem ea eligendi et repellendus sed. Nulla id laboriosam deserunt cupiditate commodi voluptatibus magnam explicabo consequatur.", new DateTime(2022, 11, 7, 18, 17, 15, 942, DateTimeKind.Utc).AddTicks(4714), 8L, "ut", "Consequatur voluptatem maiores enim commodi dicta omnis deleniti optio.", 2L, "", 2, "Praesentium aut ipsum officia.\nMagnam autem nihil sapiente officia odio dolor.\nPerferendis qui sit amet nihil sed harum similique tempora.\nSit repellendus eveniet ea.\nEligendi vitae quia repudiandae." },
                    { 34L, 35L, "Consequatur soluta aliquid qui sint et iure totam veritatis in. In voluptas aut est. Consequuntur qui aut velit cupiditate voluptas in quis aut.", new DateTime(2023, 8, 27, 16, 49, 15, 362, DateTimeKind.Utc).AddTicks(6849), 7L, "Aut explicabo ut beatae et aut numquam illo.", "Provident eum rem.", 2L, "", 3, "dicta" }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[,]
                {
                    { 35L, 36L, "Cumque maxime repellat id autem quae aut reiciendis.", new DateTime(2021, 7, 8, 8, 19, 32, 171, DateTimeKind.Utc).AddTicks(9645), 40L, "Totam asperiores saepe labore temporibus quis fugit ullam incidunt numquam.", "Hic est ea itaque ut ullam.", 1L, "", 3, "Ipsa quibusdam quaerat atque necessitatibus et voluptate eum iusto.\nLaudantium tenetur impedit fuga beatae illum necessitatibus ut earum.\nTemporibus repudiandae voluptatibus aut aliquid ut laboriosam inventore non.\nBeatae a consequatur.\nMaxime est eligendi quia sint." },
                    { 36L, 37L, "aliquid", new DateTime(2023, 3, 7, 13, 52, 56, 104, DateTimeKind.Utc).AddTicks(5465), 9L, "Minima deserunt similique tempore quia qui voluptas non ut accusamus.\nProvident iste quaerat.", "Vel nesciunt magni ut.", 1L, "", 2, "Molestias hic ex debitis molestiae quia nobis qui. At voluptatem sint sunt et natus inventore. Possimus cumque eveniet quasi. Accusantium voluptatem et fugiat." },
                    { 37L, 38L, "Enim et eaque quaerat deserunt deserunt est voluptatum.", new DateTime(2023, 8, 17, 19, 45, 10, 420, DateTimeKind.Utc).AddTicks(6711), 21L, "Dolores porro consequuntur doloribus rerum mollitia consequatur sint itaque ut.\nVoluptate fugit labore quas dolores nisi alias.\nMagnam provident quam et necessitatibus.", "Sunt deleniti recusandae deserunt velit.", 2L, "", 1, "quaerat" },
                    { 38L, 39L, "At aliquid rerum nihil. Illo magni autem sit odio at deleniti. Odit voluptatibus debitis quaerat autem. Eum quo quibusdam ut aut est vitae ducimus iusto ut. Harum dignissimos nemo. Et qui in.", new DateTime(2022, 10, 23, 18, 5, 35, 197, DateTimeKind.Utc).AddTicks(256), 39L, "sequi", "Aperiam et ut.", 2L, "", 2, "Adipisci in ipsa ut qui quia et neque vel." },
                    { 39L, 40L, "Aut voluptate ipsum minima blanditiis voluptas deleniti a est quibusdam.\nTempore saepe repellendus rerum consequatur sint harum nisi maxime et.\nRem rerum et.\nAccusantium laudantium sed dolore officia impedit similique.", new DateTime(2023, 3, 23, 4, 8, 8, 917, DateTimeKind.Utc).AddTicks(7330), 14L, "Iusto eligendi esse sint facilis laborum ea quo quis.", "Illo fugit recusandae explicabo cupiditate est.", 2L, "", 3, "Et rerum ea aliquam cum est maiores quia. Omnis nesciunt sit quae veniam id. Aliquid qui omnis voluptas itaque quis est vero illum sit. Commodi quia ad aut aut eos ipsum sit aperiam. Dicta quasi dolor inventore ullam." },
                    { 40L, 41L, "Debitis aut similique cumque.\nDistinctio assumenda impedit quidem quo.", new DateTime(2022, 1, 18, 10, 20, 26, 8, DateTimeKind.Utc).AddTicks(2141), 13L, "et", "Odio distinctio saepe dolorum delectus neque.", 1L, "", 0, "Animi quo quisquam. Repudiandae ut animi quaerat reprehenderit voluptas et. Est voluptate rerum iusto sit veniam dolor magnam et. Illum architecto repudiandae explicabo quia id ipsum." },
                    { 41L, 42L, "Itaque atque quaerat voluptas molestiae laborum magnam.", new DateTime(2023, 4, 18, 8, 21, 40, 977, DateTimeKind.Utc).AddTicks(6428), 7L, "Assumenda nam natus.\nIste enim maiores.\nEt quisquam eveniet quo rerum consequatur.\nEst repellat aperiam quaerat eligendi molestiae ipsam officia pariatur incidunt.\nQui incidunt minima ut ab quod nisi occaecati at molestias.\nAlias laudantium suscipit.", "Ut quis dolore.", 2L, "", 1, "Iste fuga ipsum fuga inventore. Facilis soluta qui. Repellat dicta magnam. Consequatur optio suscipit aliquid eum." },
                    { 42L, 43L, "Ad ut est blanditiis architecto impedit eum quidem repudiandae.\nSed sit libero sequi quos molestiae a in fuga.\nSunt et alias sunt ratione enim distinctio vel non quo.", new DateTime(2023, 9, 6, 18, 55, 13, 134, DateTimeKind.Utc).AddTicks(6123), 6L, "eum", "Esse reprehenderit natus temporibus.", 1L, "", 3, "Omnis quaerat totam beatae voluptates in et ex." },
                    { 43L, 44L, "aliquid", new DateTime(2022, 6, 11, 0, 22, 0, 327, DateTimeKind.Utc).AddTicks(7065), 7L, "Nobis velit sint natus delectus enim.\nQuod quas et a asperiores cumque fuga necessitatibus error.\nAb et velit aperiam.\nConsequatur qui dicta.", "Eaque molestiae sapiente animi reprehenderit sit aliquid.", 2L, "", 1, "Enim voluptas ab perferendis odit beatae ipsam." },
                    { 44L, 45L, "Nihil maxime non.\nNulla sed iste ipsam veritatis nihil.\nPerspiciatis voluptas ut tenetur.\nAutem error animi quia rem.", new DateTime(2023, 3, 3, 13, 43, 53, 989, DateTimeKind.Utc).AddTicks(1722), 23L, "fuga", "Et error nobis velit aliquid.", 2L, "", 2, "Nam sit nesciunt ducimus qui enim et enim autem sed." },
                    { 45L, 46L, "Velit dolorem temporibus voluptates quia sunt consequuntur.", new DateTime(2022, 7, 5, 16, 53, 8, 243, DateTimeKind.Utc).AddTicks(9192), 30L, "Aperiam expedita quis aut rerum libero quis.\nAperiam qui asperiores temporibus id impedit dolores animi.\nFacilis commodi aliquid sunt aut eum enim vitae cum doloribus.", "Voluptas est id debitis aperiam dolor quas.", 2L, "", 3, "Est facere nesciunt consequatur natus sequi. Molestiae est rerum dicta animi dolorem exercitationem asperiores veniam. Est sunt harum voluptas expedita explicabo temporibus eveniet. Atque laudantium autem et dolores sunt consequatur sunt. Vero soluta voluptas ipsa est veniam facere. Quo occaecati vel repellat quos sint ipsa officiis odio." },
                    { 46L, 47L, "illo", new DateTime(2021, 2, 4, 10, 58, 17, 97, DateTimeKind.Utc).AddTicks(1085), 11L, "Deserunt non ut. Itaque nostrum minima corrupti. Ex aut voluptatibus consequatur maxime. Esse quia voluptas.", "Culpa totam omnis velit enim expedita.", 1L, "", 3, "Sunt cupiditate voluptatem voluptatem dolor dolor odio earum autem. Aut non tempora ad aspernatur. Quia soluta quod." },
                    { 47L, 48L, "provident", new DateTime(2023, 5, 13, 1, 40, 37, 610, DateTimeKind.Utc).AddTicks(8472), 32L, "laudantium", "Itaque quia et non et tenetur autem aliquam.", 1L, "", 3, "Consequatur asperiores fuga nulla ratione distinctio corporis perferendis cupiditate iste." },
                    { 48L, 49L, "Id qui voluptatem.\nMagnam quam qui et neque qui sapiente veritatis quia.\nBeatae praesentium vero nam neque et.\nNam quae cum esse ullam.\nRepellendus eum et perferendis assumenda vitae molestiae qui.\nQui ut quo quis rerum inventore voluptate nisi at.", new DateTime(2023, 8, 31, 22, 7, 11, 812, DateTimeKind.Utc).AddTicks(1047), 39L, "Qui quasi ea.", "Sunt atque vel sint excepturi voluptas quo perferendis vitae est.", 2L, "", 1, "Hic omnis iste tempora voluptatibus." },
                    { 49L, 50L, "Autem sit eius aliquam nihil qui sapiente a porro accusantium.", new DateTime(2023, 5, 17, 1, 37, 35, 468, DateTimeKind.Utc).AddTicks(414), 33L, "Ipsam non distinctio voluptatum deserunt iure voluptatum et voluptates doloremque.\nAut animi illum cumque dolorem iusto asperiores.", "Sunt explicabo magni consectetur reiciendis maxime natus veniam ipsam.", 1L, "", 3, "Doloremque in illo id placeat iure et qui omnis." },
                    { 50L, 51L, "Ipsum consectetur dolor recusandae aliquam earum quos neque corrupti. Sit omnis doloremque recusandae repellat. Quae alias recusandae est tempore impedit voluptas in enim. Veritatis aut accusamus omnis. In in molestiae id voluptas in. Ut officiis quia.", new DateTime(2022, 10, 19, 4, 42, 3, 934, DateTimeKind.Utc).AddTicks(1705), 8L, "quisquam", "Autem et qui.", 2L, "", 1, "Nihil modi repellendus voluptatem aut ut officiis eos.\nNon qui laudantium nihil animi dolorum aut aut eum exercitationem.\nRepudiandae possimus aut id adipisci sequi nihil ut et inventore.\nPerferendis possimus dolores officiis dicta commodi.\nConsequatur eveniet cum enim optio consequatur quis enim.\nEt blanditiis et asperiores dolorem consequatur." },
                    { 51L, 52L, "Qui aliquam animi inventore id ipsam.\nId dolorum sint velit et expedita facilis quod esse et.", new DateTime(2023, 3, 12, 13, 41, 20, 783, DateTimeKind.Utc).AddTicks(883), 9L, "Delectus officiis aut optio natus cupiditate. Ipsa deleniti est sit sapiente. Ex id unde mollitia.", "Unde ut atque qui qui consequuntur impedit quis qui provident.", 2L, "", 0, "Inventore aliquid est dolorem debitis rerum nesciunt. Magni quasi et quas vero ducimus aut. Sed necessitatibus est et quia non molestiae iure architecto." },
                    { 52L, 53L, "Quaerat ut modi rerum sit magni non.\nUt impedit nobis impedit pariatur.\nAutem temporibus dolorem unde et vel voluptatibus.\nOmnis molestias et fugit rem dolorum sunt.\nVeritatis qui atque.", new DateTime(2022, 4, 9, 2, 25, 54, 130, DateTimeKind.Utc).AddTicks(8651), 9L, "ut", "Exercitationem doloremque amet ipsam velit nulla nihil iure facere sed.", 1L, "", 1, "Quis sapiente debitis beatae quod. Hic quia quas est natus labore quae mollitia. Sunt nihil eos et nobis corrupti porro. Eius distinctio enim amet quia facilis quis modi." },
                    { 53L, 54L, "Quos eligendi dolorum qui expedita autem.", new DateTime(2023, 1, 18, 10, 13, 36, 302, DateTimeKind.Utc).AddTicks(8607), 33L, "Mollitia id tenetur est.\nVoluptas hic sit quis rerum.\nRepellat est autem magnam vitae voluptatem et ipsam veritatis.\nOmnis dolorem aut animi omnis hic adipisci.\nMaiores eligendi dolorem quod non et dolor sint commodi expedita.\nMolestiae rerum ut sequi sunt veritatis.", "Quasi minima fuga blanditiis consequatur quidem omnis incidunt sunt.", 1L, "", 3, "Esse et sint et soluta numquam eum totam.\nTenetur dolor autem ut repudiandae autem suscipit inventore aperiam impedit.\nLibero molestiae quod." },
                    { 54L, 55L, "Aut sed illum possimus. Iure rerum itaque. Dolore quia rem similique ut. Ut quidem impedit ut tempore ut ut et aperiam vel. Qui similique ducimus et ut et. Consequatur aliquid sed.", new DateTime(2023, 1, 26, 3, 46, 24, 736, DateTimeKind.Utc).AddTicks(1313), 29L, "Animi minus atque exercitationem aperiam iure. Ea reiciendis id sed eius ut blanditiis. Vitae vel exercitationem incidunt officia eum ratione totam id commodi.", "Quia autem qui natus.", 2L, "", 3, "Sequi quia harum aut perferendis id nisi sit ut.\nRem sit at culpa.\nRepudiandae rem eaque.\nAutem fuga similique vel corrupti suscipit ad autem laudantium.\nUnde quo corporis delectus." },
                    { 55L, 56L, "Iste corrupti nisi labore perferendis aut excepturi mollitia.", new DateTime(2023, 3, 3, 23, 42, 55, 34, DateTimeKind.Utc).AddTicks(7963), 8L, "Possimus quos tempore fuga dolores quidem blanditiis ut.\nRecusandae sequi similique quo beatae consequatur occaecati sed.\nQuaerat eos qui cupiditate voluptas hic doloribus in.\nHarum officiis in quia enim architecto ab similique cum.\nAutem consequatur consequatur eos rem consequatur iste.", "Numquam repellat et rerum.", 1L, "", 2, "nesciunt" },
                    { 56L, 57L, "Dolor qui reprehenderit dolorem qui voluptas quos temporibus excepturi magni.\nQuod porro aliquam minima libero porro est voluptas ipsam in.\nNon quibusdam sed assumenda consequatur rem occaecati suscipit sint qui.\nDicta modi ipsa beatae rerum eum nisi dolor.\nIure similique aspernatur corporis quisquam ab.", new DateTime(2023, 1, 7, 5, 8, 4, 201, DateTimeKind.Utc).AddTicks(387), 11L, "Ut quia et. Repellat et aperiam labore. Architecto rerum quam dolores perferendis similique ea. Incidunt quae a ratione nam illum quia eos. Similique qui voluptatem atque consequatur accusamus. Nesciunt sed non tenetur earum corporis sunt.", "Architecto ipsa iusto corporis id non ut neque.", 1L, "", 0, "Sint reprehenderit a voluptatem sint dolorem necessitatibus mollitia harum." },
                    { 57L, 58L, "Debitis officiis id ea dolores nostrum sunt veritatis quidem dicta.", new DateTime(2021, 4, 6, 6, 7, 1, 577, DateTimeKind.Utc).AddTicks(8120), 15L, "repudiandae", "Sed sit quas aliquam non eveniet.", 2L, "", 3, "et" },
                    { 58L, 59L, "eos", new DateTime(2023, 6, 28, 16, 45, 39, 864, DateTimeKind.Utc).AddTicks(9825), 35L, "Cupiditate praesentium sed veniam optio vel. Hic odit adipisci non natus veritatis labore. Corporis cumque ipsa. Et quas odio magni consequatur optio.", "Molestiae a earum veritatis qui autem cum voluptas et.", 1L, "", 1, "A harum veniam sint at blanditiis est.\nDoloremque vel repellat nesciunt quis quis fuga sed.\nEveniet sed qui voluptatum tenetur recusandae vel.\nVoluptatibus illum delectus voluptas." },
                    { 59L, 60L, "Ipsum eaque minima voluptatem autem facere.\nReiciendis sint voluptatem quis ut aliquam sapiente dicta sit aut.\nTempora et rerum ipsam nihil autem eveniet.", new DateTime(2019, 3, 6, 3, 40, 24, 935, DateTimeKind.Utc).AddTicks(9578), 18L, "Consequuntur optio modi commodi necessitatibus totam. Facere ipsam ea et nobis voluptatum magni voluptatem molestias quisquam. Consectetur consequatur cum voluptate quae sapiente illo molestias. Animi aliquam inventore aspernatur deleniti repellendus commodi at fuga dolores. Alias expedita excepturi ea quia tempora earum eos aut perferendis.", "Ea doloremque rerum provident harum voluptates aliquam nisi.", 1L, "", 3, "Sunt ab ea provident modi pariatur suscipit.\nAt voluptatibus quia porro nisi necessitatibus.\nQuam fugit quos.\nSimilique unde culpa qui possimus minima dolorem facere." },
                    { 60L, 61L, "Quaerat corporis voluptatem eveniet fugit ad rerum.", new DateTime(2023, 8, 8, 22, 50, 5, 24, DateTimeKind.Utc).AddTicks(3018), 39L, "Ipsam ut qui sit consectetur voluptate.\nOdit atque et explicabo vel dolor omnis dolores aut ut.\nDolorum explicabo non eos sint et temporibus sapiente.\nQuod at possimus cumque aliquam consequuntur fugit dolores atque eum.", "Est vel quisquam est voluptatem enim vel error.", 1L, "", 0, "quod" },
                    { 61L, 62L, "Nam omnis quasi consequuntur.\nVeniam blanditiis voluptatem ut incidunt incidunt.\nVoluptatem magnam est repudiandae voluptas nobis.\nIllo est ratione.", new DateTime(2023, 3, 29, 8, 30, 44, 516, DateTimeKind.Utc).AddTicks(8924), 1L, "Dolor maiores doloribus unde.\nQuod veniam porro.", "Sit facilis quia suscipit.", 2L, "", 0, "Quam perferendis voluptas enim quo qui et molestiae. Consectetur voluptatibus et consequuntur nobis eum ipsa. Molestiae aut necessitatibus iste. Earum exercitationem qui consequatur et expedita molestias. Sint dolor occaecati voluptatum voluptatem enim." },
                    { 62L, 63L, "unde", new DateTime(2022, 1, 29, 13, 34, 35, 707, DateTimeKind.Utc).AddTicks(9504), 3L, "Velit et quas voluptas.", "Voluptatibus nam explicabo saepe.", 2L, "", 1, "Officia sint fugit tempore velit aut est nam natus.\nQuia id incidunt ut error reiciendis.\nOmnis ducimus est et quam dolores consequatur exercitationem quibusdam at." },
                    { 63L, 64L, "Facere omnis non sint consectetur asperiores.", new DateTime(2021, 6, 26, 16, 53, 5, 510, DateTimeKind.Utc).AddTicks(2381), 16L, "dolorem", "Ut ipsum quasi suscipit tempore officia.", 1L, "", 0, "optio" },
                    { 64L, 65L, "Quos ut corrupti aut ad culpa ipsam. Et facilis vel quae sunt at non aut. Voluptate ratione eum. Est voluptas perferendis eos.", new DateTime(2022, 4, 26, 21, 33, 26, 443, DateTimeKind.Utc).AddTicks(5118), 30L, "et", "Voluptatem sed ea commodi dolorum.", 1L, "", 3, "Enim tempora quod deserunt et aliquam aperiam autem cumque. Illum sed fugiat quam sint laudantium error ex dolorem voluptate. Aliquid nostrum non placeat quam. Nulla numquam rem accusamus commodi. Excepturi iusto soluta ut eius perspiciatis quo qui fugiat. Sunt officia accusantium repellat aut." },
                    { 65L, 66L, "neque", new DateTime(2022, 10, 26, 13, 36, 22, 338, DateTimeKind.Utc).AddTicks(1665), 24L, "Quia maiores fugiat natus nisi.", "Sapiente recusandae provident voluptas vitae ut.", 2L, "", 1, "aut" },
                    { 66L, 67L, "Porro ut voluptatem dicta laborum eum.", new DateTime(2023, 1, 21, 6, 10, 47, 624, DateTimeKind.Utc).AddTicks(2685), 37L, "Laudantium accusamus harum libero beatae reiciendis.\nNobis tempore qui exercitationem.\nOdit aut nihil aut maiores.", "Sed dolorum quisquam.", 2L, "", 2, "rem" },
                    { 67L, 68L, "Delectus ut blanditiis a.\nSapiente modi corrupti aperiam facere et quam ipsa repudiandae.", new DateTime(2023, 9, 12, 14, 29, 41, 458, DateTimeKind.Utc).AddTicks(6065), 7L, "Perferendis praesentium aliquam aut autem nesciunt at.\nHic nostrum est eum enim non fugit qui fuga.", "Dolores voluptatum illum quia accusantium nulla a quis.", 2L, "", 3, "amet" },
                    { 68L, 69L, "Labore a architecto qui impedit ut. Et ut dicta. Velit nemo consequatur nisi non. Est corrupti modi qui rerum deserunt quas aperiam ipsum ut. Aut beatae culpa eaque harum nisi qui.", new DateTime(2023, 7, 6, 10, 3, 44, 231, DateTimeKind.Utc).AddTicks(4031), 10L, "consectetur", "Nihil dicta et voluptas illo est nostrum.", 2L, "", 0, "Eum et vitae aut." },
                    { 69L, 70L, "Similique optio ut rerum omnis.", new DateTime(2022, 11, 11, 10, 6, 6, 847, DateTimeKind.Utc).AddTicks(7797), 24L, "Dolor accusantium explicabo delectus expedita.\nUllam necessitatibus ratione minima excepturi dignissimos expedita dignissimos.\nCommodi enim et consequatur quas vero ducimus a.\nLaboriosam in ex.\nQui culpa quae provident deleniti.", "Dolores nulla nulla occaecati molestiae et et.", 2L, "", 3, "Ut error delectus modi asperiores quasi perspiciatis.\nEa laboriosam nobis optio quisquam.\nConsequatur reprehenderit commodi eaque aliquam.\nVeritatis est velit eligendi.\nMaiores similique est saepe dignissimos sit ut ullam consequatur.\nNam vel ipsam." },
                    { 70L, 1L, "Ullam perspiciatis aut dolores enim dignissimos.\nEt sunt et quaerat quis aperiam maxime similique.\nVoluptatibus sapiente est error.\nQuaerat perspiciatis ullam.\nUt inventore nihil autem amet iusto possimus iusto.\nNulla aperiam dolorem aperiam non corrupti voluptatem sint sit aspernatur.", new DateTime(2023, 1, 10, 2, 2, 19, 986, DateTimeKind.Utc).AddTicks(1027), 16L, "Rerum facere ut. Cupiditate labore ducimus quam est alias. Non vero ut. Quo architecto iste et eaque culpa. Quia aspernatur sed et.", "Dolores nisi ut et maxime dolorem illum ut.", 1L, "", 3, "Illo quia recusandae quo. Sint ea suscipit ipsa repellat qui fugiat aperiam iure doloremque. Ut consectetur et at qui." },
                    { 72L, 3L, "Eos quo dolorum eum error non porro molestiae et inventore.", new DateTime(2023, 8, 27, 11, 1, 26, 911, DateTimeKind.Utc).AddTicks(6307), 22L, "laborum", "Nemo nesciunt magni maxime repellat corrupti.", 2L, "", 2, "iure" },
                    { 73L, 4L, "Aspernatur iure quas est nulla aut.\nEt assumenda iusto.\nTempore ducimus natus voluptas voluptas aut.\nTemporibus quod animi nemo optio laborum.\nNon ipsam rem exercitationem voluptatem perferendis.", new DateTime(2022, 5, 21, 5, 35, 38, 547, DateTimeKind.Utc).AddTicks(5532), 8L, "Dolorem non dolor expedita tenetur eos.", "Quia dolorem consequuntur.", 1L, "", 1, "alias" },
                    { 74L, 5L, "Quidem repellendus sed est.\nNihil aliquam libero ipsa explicabo et fugit.\nFacere fugiat animi ad.\nOccaecati quos dolores consequuntur adipisci repellendus et ullam exercitationem esse.\nIn cum magni voluptatem.\nVoluptatem dolorem animi unde voluptas facere et.", new DateTime(2023, 9, 2, 7, 52, 49, 445, DateTimeKind.Utc).AddTicks(4719), 33L, "Ad omnis et quia in tempore molestias officia facere enim.\nMagni voluptas ut laudantium quam.\nQuibusdam culpa qui libero repellat.\nNeque assumenda et consectetur dicta ipsum mollitia qui.\nVoluptas dolores at accusantium consequatur a et itaque.\nIn pariatur minima ducimus dolorum accusantium voluptas.", "Vitae sed est autem pariatur quisquam facere debitis dolorem temporibus.", 2L, "", 2, "Accusantium amet cum." },
                    { 75L, 6L, "Est atque quam quam nesciunt ducimus. Aut nisi est odio laborum voluptate officiis rerum. Sunt voluptatem ducimus porro. Animi nihil excepturi error. Itaque error sunt et in sed odit omnis ratione.", new DateTime(2023, 8, 29, 3, 34, 23, 470, DateTimeKind.Utc).AddTicks(2782), 19L, "Beatae eos asperiores velit aut iusto voluptatem neque. Autem maiores quaerat ipsum. Et vero vel. Aut porro aspernatur aut ut quas vero. Sit quia recusandae blanditiis dolorum rerum voluptas sint. Autem similique consequatur non consequuntur.", "Labore magnam ad.", 1L, "", 0, "Nesciunt eligendi eum." },
                    { 76L, 7L, "corporis", new DateTime(2021, 12, 31, 2, 4, 1, 504, DateTimeKind.Utc).AddTicks(4477), 29L, "Veniam magnam eveniet incidunt libero possimus ipsa.", "Nostrum reiciendis in.", 2L, "", 1, "Distinctio aut qui delectus ut." },
                    { 77L, 8L, "Error placeat repellendus recusandae harum ratione.\nVeniam tempora sit vel rem.\nVel facilis officiis.\nAt repellendus quasi beatae.", new DateTime(2021, 9, 28, 21, 20, 46, 355, DateTimeKind.Utc).AddTicks(1637), 31L, "Odit doloribus provident totam sapiente animi.", "Perferendis culpa voluptatibus facilis perferendis.", 2L, "", 1, "Nobis et perferendis exercitationem id soluta blanditiis sunt." }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[,]
                {
                    { 79L, 10L, "Autem aliquid harum. Quia aperiam est ipsa cupiditate enim officia quisquam nesciunt. Harum dicta molestias error quo voluptatibus officiis impedit. Dolorem dignissimos aut dolore ad laborum asperiores. Sint dolores consequuntur eos. Harum ad et ut numquam expedita maxime harum voluptatem.", new DateTime(2023, 7, 31, 4, 46, 1, 707, DateTimeKind.Utc).AddTicks(4733), 33L, "Modi numquam non aliquid velit quibusdam tempora dolor numquam earum.\nCum consequatur earum sed voluptatibus repellat sint reprehenderit.\nDistinctio atque impedit amet quibusdam.\nEt non at dolorum.", "Porro doloribus perspiciatis incidunt facere nobis vel.", 1L, "", 3, "Animi libero dolor dolore ipsa omnis nesciunt vitae pariatur. Consequatur consequatur temporibus sit et non odit tempore qui. Officia illum qui. Et consequatur assumenda eius. Accusamus aut ducimus aut et tempore rerum illum sint debitis. Delectus inventore delectus eum voluptates." },
                    { 81L, 12L, "Odit explicabo ipsa blanditiis voluptatibus.", new DateTime(2023, 5, 18, 18, 8, 4, 45, DateTimeKind.Utc).AddTicks(2193), 3L, "In sunt quia enim.\nNam earum non facere qui ut voluptas.\nOmnis dicta est eum odio eligendi facilis quasi quia iure.\nEa aut provident cumque soluta qui dicta sed.", "Suscipit incidunt beatae similique.", 1L, "", 0, "Voluptatem eligendi odit veritatis aut ad praesentium magnam praesentium eligendi.\nEst rerum eaque assumenda.\nEt fuga similique quibusdam quaerat rerum sapiente voluptatem." },
                    { 83L, 14L, "Aut culpa provident exercitationem numquam ducimus ut.", new DateTime(2023, 5, 11, 1, 54, 23, 876, DateTimeKind.Utc).AddTicks(3732), 14L, "Sunt veritatis architecto voluptatum tenetur error voluptas repellat dicta.\nPossimus quas blanditiis.\nEt et facilis id ad amet eaque ea aspernatur veniam.\nEveniet rerum eum ut ipsam aut animi.", "Temporibus debitis neque omnis.", 2L, "", 2, "Placeat et consequuntur ratione.\nEligendi deserunt laborum eos cupiditate nesciunt et ut molestiae." },
                    { 84L, 15L, "Rerum fugiat aut ea id ex magnam dolorum eligendi. Enim eum numquam sapiente temporibus molestiae. Dolorum earum explicabo.", new DateTime(2023, 7, 19, 10, 38, 42, 905, DateTimeKind.Utc).AddTicks(9719), 4L, "Earum harum quas laboriosam corrupti natus ad sint dignissimos beatae. Aut quaerat consequuntur voluptatum sunt nemo explicabo. Assumenda non fugiat sunt.", "Id quibusdam veritatis.", 2L, "", 3, "Placeat debitis deserunt quia. Et earum non iure necessitatibus culpa praesentium. Odio quos nisi accusantium et eligendi. Sit corrupti placeat fugit harum minima. Quod dignissimos vero illo consequatur eligendi soluta commodi non. Voluptatem nam quo." },
                    { 86L, 17L, "Officia amet modi modi omnis recusandae vel natus omnis consequuntur. Rerum ullam unde qui est debitis. Molestias voluptatem nostrum. Quidem occaecati totam. Voluptate reiciendis esse quas.", new DateTime(2023, 2, 7, 10, 15, 39, 228, DateTimeKind.Utc).AddTicks(6807), 11L, "Facere cupiditate cupiditate fugiat ratione ad esse consequatur.\nOdit maiores culpa at dolorum laborum esse quis rerum omnis.\nVoluptates aliquam architecto rerum debitis perspiciatis laborum et dolor.\nAnimi ipsa animi dolorem et delectus.", "Dicta alias doloribus aspernatur praesentium quasi eum mollitia assumenda sequi.", 2L, "", 3, "Adipisci natus voluptatem.\nAliquam corrupti sunt est voluptate enim debitis est numquam.\nCupiditate aut officiis necessitatibus.\nQui non deserunt." },
                    { 89L, 20L, "Totam possimus aut adipisci adipisci voluptate veritatis est consequatur aliquam.\nEligendi nihil sunt harum dolore.\nInventore voluptatem id voluptas itaque non iure.\nAperiam tempore non.\nSed soluta rerum maxime qui a sed et aut quia.\nAutem commodi et voluptate.", new DateTime(2022, 4, 20, 23, 26, 15, 346, DateTimeKind.Utc).AddTicks(6654), 8L, "Sapiente voluptate cupiditate non odit quo autem libero.\nVoluptates consectetur aut soluta ex dignissimos voluptas tempore reprehenderit.\nEos est qui aut non.", "Et nihil delectus aliquid.", 1L, "", 3, "Eaque nostrum blanditiis eum nostrum ducimus sed voluptatem. Eum quam quia neque id at fugiat. Sunt ducimus hic quo magni aspernatur ducimus cumque. Consequatur commodi deleniti eos occaecati natus ea laboriosam harum et. Id reprehenderit iusto perspiciatis iusto molestiae." },
                    { 90L, 21L, "Doloremque nobis sit id atque est qui nihil illo eaque.\nNihil omnis eaque qui occaecati recusandae qui nemo deserunt magni.\nExpedita commodi quaerat qui.\nQuibusdam earum est vel.\nAlias quisquam ea fuga cum aperiam suscipit vel sed.\nUt qui voluptatem nihil rerum nam asperiores perspiciatis inventore fugiat.", new DateTime(2023, 6, 29, 8, 22, 6, 292, DateTimeKind.Utc).AddTicks(2208), 6L, "Sint non atque.", "Ea cumque reprehenderit et asperiores aut.", 1L, "", 2, "Illum aut accusantium qui." },
                    { 91L, 22L, "Reprehenderit nesciunt dolore excepturi laboriosam iste consequatur perspiciatis aut qui. Perspiciatis omnis facere ut deleniti mollitia vero natus. Et enim corrupti sed atque. Repellat animi maiores modi cumque nesciunt doloremque commodi vero. Harum sint deleniti sint modi ut consequuntur dicta. Fugit mollitia hic eos velit quia maiores laboriosam.", new DateTime(2023, 1, 22, 10, 20, 12, 97, DateTimeKind.Utc).AddTicks(4426), 22L, "Et nulla vitae vel rerum vitae saepe ratione ea aut.\nMinima ab praesentium repellendus ab.", "Cum est voluptas.", 2L, "", 3, "Libero impedit accusantium.\nIste non natus culpa eligendi voluptatum." },
                    { 92L, 23L, "Mollitia voluptate illo eveniet ex.", new DateTime(2023, 9, 6, 9, 31, 8, 98, DateTimeKind.Utc).AddTicks(6952), 39L, "Ut ut et expedita.\nMolestias facere est non.\nExpedita maiores rerum sequi dolore et mollitia consequatur minima architecto.\nMollitia aut unde omnis officiis repellat.", "Asperiores et corrupti perferendis ea aut velit unde.", 2L, "", 1, "id" },
                    { 93L, 24L, "Eum at quaerat quidem sit quam mollitia laborum cupiditate.\nEst iusto dolores labore quam ut nobis autem aliquam ex.", new DateTime(2023, 3, 4, 21, 33, 1, 222, DateTimeKind.Utc).AddTicks(2635), 3L, "nostrum", "Aut eos assumenda.", 1L, "", 2, "Consectetur nisi similique et ut officiis maxime. Occaecati ut voluptas sed nihil vel. In officia tenetur dolorem aliquid aut repudiandae asperiores laudantium. Cumque voluptas qui qui rem nam hic sint ut." },
                    { 94L, 25L, "Sapiente voluptate ad ut aut asperiores voluptas aut.\nAsperiores ab labore vel voluptatem.\nMaxime omnis consequuntur.\nSaepe molestiae in.", new DateTime(2022, 12, 8, 11, 26, 54, 728, DateTimeKind.Utc).AddTicks(8908), 19L, "Qui tenetur est omnis voluptatum cum. Sunt beatae cumque quia illum corrupti autem ducimus sit. Quia facere hic dolorem consequuntur ullam inventore voluptatibus minus dicta. Aut sed quo enim laboriosam non est fugiat tempore. Sequi eum atque exercitationem id autem impedit omnis laboriosam laboriosam.", "Molestias magni provident qui nihil asperiores provident quo quibusdam.", 1L, "", 1, "Minus dolorem impedit ut et animi.\nVoluptatem ut omnis itaque autem rerum aliquid natus eius.\nAtque sint vitae nostrum sint soluta repudiandae repellendus.\nLibero et molestias quis iure.\nQuos rerum consequatur dolorem magni officiis cum qui et." },
                    { 95L, 26L, "Deserunt ab quis a et eos deleniti ad.\nEt expedita aperiam.\nEt laudantium officiis.\nMolestias aliquid molestiae reprehenderit placeat voluptas.\nEt assumenda dicta impedit voluptates facere.", new DateTime(2023, 7, 28, 18, 2, 43, 438, DateTimeKind.Utc).AddTicks(462), 1L, "voluptate", "Et ullam sit et.", 1L, "", 1, "quia" },
                    { 96L, 27L, "Ratione velit consequatur aliquid nulla est dolorem nemo.", new DateTime(2022, 6, 26, 13, 8, 7, 371, DateTimeKind.Utc).AddTicks(3792), 34L, "Iusto sed recusandae laborum nobis. Et laborum culpa. Ex voluptas et sint omnis eius quisquam. Ut atque consequuntur doloremque molestiae minus inventore qui impedit.", "Nulla architecto et ipsam consequatur nobis et quae corporis dolorem.", 1L, "", 1, "omnis" },
                    { 98L, 29L, "Fuga quisquam veniam dolorem.\nEt fugit laudantium incidunt quisquam aperiam.\nEt dolores vel qui beatae architecto qui et delectus perspiciatis.", new DateTime(2022, 3, 23, 21, 50, 14, 716, DateTimeKind.Utc).AddTicks(9610), 20L, "Explicabo qui eum a accusantium.", "Nostrum voluptatem soluta ratione placeat iusto illo.", 2L, "", 1, "Voluptas qui debitis accusamus illum quaerat a qui accusantium quasi." },
                    { 100L, 31L, "Aperiam rerum qui voluptas.\nMolestiae consectetur ipsum voluptatem incidunt enim ipsa quisquam asperiores quos.\nNecessitatibus aut aut dolorum voluptas fuga sint ut.\nQuia tempora est provident soluta beatae nostrum aspernatur iusto.", new DateTime(2023, 4, 24, 4, 38, 7, 672, DateTimeKind.Utc).AddTicks(6583), 6L, "Suscipit minus et omnis eum vitae quaerat officia repellendus.\nVoluptate ut vel cupiditate est velit.\nRerum totam voluptatem reiciendis earum quis.", "Qui dolores quae molestias ut ut.", 2L, "", 0, "Perspiciatis excepturi aut in occaecati illum." },
                    { 101L, 32L, "cumque", new DateTime(2023, 9, 14, 16, 5, 28, 156, DateTimeKind.Utc).AddTicks(6891), 22L, "Quibusdam eligendi aut eveniet nihil est harum qui perspiciatis asperiores.\nMolestiae aut et possimus ut.", "Sed aut hic itaque sint ut laudantium dignissimos qui.", 1L, "", 3, "Ipsam ut perferendis ducimus dolorem maiores laboriosam autem.\nQuia eius dolore.\nReprehenderit ducimus non deleniti eligendi cumque qui illo soluta.\nRem qui quo inventore voluptas rem exercitationem.\nAccusamus sit minima et ipsam iste et ut reprehenderit cupiditate.\nAb omnis porro enim." },
                    { 105L, 36L, "Quia nam voluptatem voluptatem minima corrupti quia et non. Corporis alias omnis distinctio sed eum omnis molestiae perferendis eos. Minus perferendis minus ut totam laboriosam eum.", new DateTime(2022, 12, 4, 2, 39, 6, 840, DateTimeKind.Utc).AddTicks(2972), 18L, "Natus et temporibus eveniet rerum quis. Vitae dolor similique culpa vitae eum facere aliquam quod dolorem. Aliquid voluptas a sit deserunt est quam nostrum. Ratione earum voluptatum eius itaque nihil laborum doloribus esse. Corrupti quia quidem illo illo.", "Excepturi eum eum corporis repudiandae vero quia dolores ad.", 2L, "", 0, "asperiores" },
                    { 106L, 37L, "Est eos voluptatum aliquid voluptatum.", new DateTime(2023, 5, 28, 3, 36, 42, 681, DateTimeKind.Utc).AddTicks(6944), 40L, "Aut est neque labore.\nCupiditate vel temporibus enim qui a dolore ut doloribus est.\nUt non perferendis eius molestiae nihil est eum facere voluptas.\nReprehenderit ut et qui.\nQuasi numquam voluptas voluptas.", "Porro dicta rerum voluptas quaerat facilis possimus.", 2L, "", 2, "Aliquid facilis autem assumenda omnis. Voluptate laboriosam laborum quo repellendus ut ea molestiae numquam. Nihil explicabo veritatis ullam ratione a exercitationem rerum amet." },
                    { 108L, 39L, "Maiores blanditiis molestiae. Occaecati hic accusantium porro omnis veritatis repudiandae. Velit maiores expedita rerum quia quidem. Et et maiores. Fugit nihil rerum voluptas explicabo ea non. Exercitationem consequatur suscipit blanditiis eum enim ad.", new DateTime(2023, 2, 15, 4, 49, 28, 333, DateTimeKind.Utc).AddTicks(4544), 21L, "Repellat et vel sed in sit non.", "Dolor id et non voluptas dolore itaque.", 1L, "", 0, "Explicabo animi ea et impedit ea sint omnis.\nMolestiae ullam id." },
                    { 109L, 40L, "Voluptatibus ut et.", new DateTime(2023, 7, 24, 16, 12, 15, 699, DateTimeKind.Utc).AddTicks(9917), 35L, "animi", "Eos non enim.", 1L, "", 2, "Adipisci atque quo ut magnam ut." },
                    { 110L, 41L, "Aut est ut maiores veniam autem debitis ipsam voluptas.\nDolor laborum impedit sit ea aperiam non reprehenderit.\nFacilis ut veritatis.", new DateTime(2022, 2, 2, 0, 16, 55, 633, DateTimeKind.Utc).AddTicks(1513), 37L, "temporibus", "Deleniti et sequi beatae necessitatibus cumque.", 2L, "", 3, "fugit" },
                    { 115L, 46L, "Tempore fuga molestias ea.\nMinus sequi laboriosam.\nIn officiis molestiae neque quia voluptatum repellendus ipsam.\nAliquam qui inventore eveniet maxime repellat consequuntur.", new DateTime(2022, 7, 11, 16, 5, 6, 811, DateTimeKind.Utc).AddTicks(2991), 32L, "In voluptas quia nesciunt quo et expedita ut non. Similique tempore exercitationem hic. Omnis aut excepturi.", "Autem qui deserunt nobis doloremque rerum adipisci.", 1L, "", 2, "Vitae illo cumque eos quo ex sint minima ipsum praesentium." },
                    { 116L, 47L, "corporis", new DateTime(2022, 4, 12, 20, 48, 38, 328, DateTimeKind.Utc).AddTicks(6378), 39L, "Nobis officiis vel magni totam perspiciatis voluptate fugiat.", "Recusandae voluptatem aperiam sunt et.", 2L, "", 1, "Et atque consequatur minus quisquam qui quis." },
                    { 117L, 48L, "Tempora voluptates sint voluptatem et consequatur.", new DateTime(2023, 3, 12, 8, 3, 41, 141, DateTimeKind.Utc).AddTicks(6769), 5L, "blanditiis", "Doloribus quas ipsa et eveniet cum.", 2L, "", 3, "Exercitationem modi sit. Aspernatur velit rem. Quibusdam corrupti neque voluptate ut perferendis autem illo aperiam. Et eligendi deleniti nobis laborum delectus." },
                    { 122L, 53L, "Minus officiis dolorem aut praesentium facere.", new DateTime(2022, 9, 15, 1, 37, 38, 603, DateTimeKind.Utc).AddTicks(3011), 15L, "Et dolores consequatur.", "Enim qui rerum ut molestiae.", 2L, "", 3, "Aut et rerum repellat odio.\nSit sapiente eos quidem quos odio aut iste non.\nVero iure culpa labore ipsum odit aut reiciendis.\nLibero ducimus nostrum architecto voluptate tempore eum blanditiis.\nQuam non vitae est eveniet nihil sapiente maiores.\nNostrum et voluptatem at voluptatem tenetur molestiae animi." },
                    { 126L, 57L, "Quaerat cupiditate ad illo facilis ex numquam.\nLaudantium iure rerum aut eos qui velit iste.\nNulla aut omnis laudantium numquam vitae.\nEligendi aperiam quis.\nVel cumque deleniti vitae molestiae impedit consequatur molestiae.", new DateTime(2022, 8, 6, 3, 36, 6, 511, DateTimeKind.Utc).AddTicks(8964), 21L, "amet", "Laboriosam ab veritatis quasi iusto corrupti non doloremque.", 2L, "", 2, "Optio molestiae blanditiis accusantium laboriosam qui ipsum molestiae.\nAccusantium recusandae quae sit distinctio.\nAut ipsa dignissimos dolore commodi est maiores cupiditate et voluptas.\nAut a molestiae commodi voluptatibus doloremque ab aspernatur enim ut." },
                    { 128L, 59L, "Totam quis animi modi rerum facere eaque.", new DateTime(2023, 8, 18, 16, 41, 4, 210, DateTimeKind.Utc).AddTicks(3438), 29L, "Et alias qui ea nemo sed enim sunt quo sequi.\nVoluptatem nulla voluptate illum omnis quos distinctio ab recusandae.\nSunt quo est.\nSit exercitationem voluptas.\nUt at est placeat nulla autem animi.\nEsse a quisquam commodi consequatur sit maiores magnam.", "Enim molestiae nemo est quae dolorum voluptatibus expedita quia architecto.", 2L, "", 3, "Ut aliquam cum itaque quae qui aut magni maxime.\nTempore non iure placeat." },
                    { 129L, 60L, "Aut voluptas reiciendis et. Aperiam vel corporis quasi similique alias. Eius beatae beatae cumque sit similique maxime. Pariatur qui voluptatem et. Maiores eum consequatur voluptas quia temporibus ipsa.", new DateTime(2022, 11, 2, 14, 33, 16, 63, DateTimeKind.Utc).AddTicks(4284), 26L, "Deleniti saepe sit occaecati nobis sit et eveniet odit harum. Vel iure voluptatem. Illo et ipsam velit veritatis unde.", "Saepe sunt deleniti a.", 2L, "", 1, "et" },
                    { 132L, 63L, "Sapiente quae excepturi rerum inventore. Aut nulla deleniti est consequatur. Repellendus eveniet deleniti id aut qui non repudiandae.", new DateTime(2021, 1, 12, 23, 49, 46, 106, DateTimeKind.Utc).AddTicks(6088), 9L, "Quidem odit similique possimus qui et aut dolores.", "Dolores perspiciatis qui sed provident accusamus totam quas.", 1L, "", 1, "Dolores reprehenderit recusandae hic dolores deleniti est quis." },
                    { 136L, 67L, "Occaecati sed impedit quia laborum perspiciatis qui.", new DateTime(2023, 9, 2, 20, 39, 43, 197, DateTimeKind.Utc).AddTicks(5406), 10L, "Et iure consectetur.\nAd quia aut quia id quidem animi quia inventore.\nCorrupti tempore sed architecto necessitatibus corrupti.\nVeritatis illo quo.", "Accusamus libero sed rerum assumenda voluptatum temporibus sint blanditiis voluptate.", 1L, "", 3, "qui" },
                    { 137L, 68L, "consectetur", new DateTime(2023, 8, 12, 1, 37, 32, 305, DateTimeKind.Utc).AddTicks(8266), 35L, "Exercitationem architecto sit dicta impedit similique.", "Saepe et incidunt.", 1L, "", 0, "Repellat labore magni exercitationem illo.\nRerum recusandae iure voluptatem non illo voluptatem ut maxime placeat.\nDoloribus consequatur sit." },
                    { 138L, 69L, "Aut ipsum ut alias fugiat eaque officiis delectus molestiae quia. Illo velit similique ab recusandae deserunt. Inventore fugit delectus labore ipsam error sit veniam eum tenetur.", new DateTime(2023, 8, 18, 4, 22, 58, 504, DateTimeKind.Utc).AddTicks(7077), 5L, "cum", "Eum sed quo.", 1L, "", 2, "Asperiores officiis voluptatem saepe neque qui ea laudantium eaque nemo. Repellendus dolore necessitatibus. Nam quaerat illo qui. Necessitatibus cumque beatae alias accusamus at suscipit. Unde expedita et sed nesciunt velit corrupti sit dolor. Necessitatibus atque amet deleniti sit aut nulla blanditiis." },
                    { 140L, 1L, "Est est occaecati eos id cupiditate blanditiis aut.\nPariatur commodi aperiam et iusto quia culpa voluptas non culpa.\nDolorem nulla quae at incidunt qui unde.", new DateTime(2023, 8, 18, 17, 18, 8, 917, DateTimeKind.Utc).AddTicks(4835), 3L, "Inventore voluptates autem.", "Enim et magni ut.", 2L, "", 3, "Et asperiores quis sed ad temporibus officia et." },
                    { 141L, 2L, "Et voluptas error libero et voluptatem aut et.\nAmet at beatae.", new DateTime(2021, 10, 13, 1, 7, 2, 868, DateTimeKind.Utc).AddTicks(60), 12L, "Voluptatem aliquam quibusdam.\nQuis placeat voluptatem incidunt repellat.\nMagni autem quis accusantium voluptatem velit.\nDoloremque vitae nulla nihil qui itaque reiciendis qui.\nVoluptatem ducimus est omnis minus et illo debitis et.", "Quibusdam et corrupti aut.", 1L, "", 3, "Est et quo accusantium aut." },
                    { 148L, 9L, "Est ut consequatur id illum omnis consequatur eum.\nLabore et perferendis dolores inventore aut sunt.", new DateTime(2021, 1, 22, 6, 32, 16, 531, DateTimeKind.Utc).AddTicks(1084), 27L, "Accusantium deserunt harum et voluptas.\nNesciunt velit non et ratione exercitationem.", "Aperiam quia sint repellendus non.", 1L, "", 1, "Earum amet dicta similique qui voluptatem sit.\nVoluptatem ex aut est velit ipsum repellat ut.\nNatus odit provident minima cum facere.\nAd quibusdam qui quibusdam aut consequatur.\nEt provident a vitae sed est sit ex quo." },
                    { 150L, 11L, "Perferendis eaque cumque.\nDolore nisi optio.\nDolorem iste dolorum placeat eaque rerum.\nVoluptas eaque magnam sunt itaque.\nAt et est quasi dicta repudiandae eligendi ut.\nEst culpa ad ex velit voluptatem quas nemo est eos.", new DateTime(2021, 3, 2, 0, 0, 42, 364, DateTimeKind.Utc).AddTicks(3777), 8L, "Eos error esse quaerat dolorem quae.", "Facilis non iste ullam illum a exercitationem vel iure.", 1L, "", 1, "Dicta nemo consequatur voluptatem accusamus est ut est eos sunt.\nIn nesciunt iure aut sit neque et alias voluptatem officiis.\nIpsa rem soluta placeat voluptas qui qui animi tempora." },
                    { 155L, 16L, "Dolorem voluptas mollitia natus provident enim.", new DateTime(2023, 9, 1, 18, 45, 17, 176, DateTimeKind.Utc).AddTicks(3260), 18L, "ab", "Quis vero at voluptate dolores facere ea.", 2L, "", 0, "Laboriosam et impedit debitis dignissimos nostrum.\nRepellendus impedit sint aspernatur nam.\nPerferendis eius aut dolor." },
                    { 157L, 18L, "Et voluptate tempore.\nMollitia quae ex ut neque id enim.", new DateTime(2023, 4, 16, 20, 9, 35, 374, DateTimeKind.Utc).AddTicks(7766), 1L, "Laudantium totam dolores perspiciatis repellendus quia neque.", "Laborum quidem tenetur quia.", 1L, "", 3, "Recusandae qui ipsam nobis quod exercitationem sapiente perferendis aliquid animi.\nAliquam sit adipisci." },
                    { 167L, 28L, "blanditiis", new DateTime(2023, 5, 28, 9, 40, 19, 939, DateTimeKind.Utc).AddTicks(4215), 40L, "placeat", "Modi magnam maiores eos.", 2L, "", 1, "alias" },
                    { 169L, 30L, "Et distinctio quibusdam.\nQuos unde veniam iusto ut libero aspernatur et quia.\nDolores laudantium ipsa commodi.\nAperiam fuga quaerat beatae inventore.\nQui consequatur vel repellat.\nSint temporibus earum nam tempore velit quia.", new DateTime(2018, 2, 28, 21, 55, 20, 311, DateTimeKind.Utc).AddTicks(2336), 36L, "Perferendis minima ullam eum iusto odit. Iste et cum est dolorem vel minima ut necessitatibus. Quo velit sequi qui eligendi officiis. Deleniti et in aperiam. Eaque odio vel et et optio ut consectetur aliquam at. Qui est voluptas fugiat sint.", "Laudantium mollitia ut.", 1L, "", 0, "Aut fugit illo.\nQuia doloribus dignissimos vel occaecati alias iste est iure molestiae.\nQuis qui id culpa ipsa perspiciatis.\nIusto commodi voluptatem nemo impedit perspiciatis quos dicta nostrum ex.\nDolore incidunt excepturi quia aut itaque.\nConsequatur fuga eos repellat." },
                    { 172L, 33L, "Et dolores vitae possimus placeat qui earum sit itaque et.\nIn sed consequuntur placeat voluptas in.\nVoluptas dolorem unde illum perspiciatis.\nMolestiae sit praesentium in autem.\nEt aliquid repellat dicta qui aut.\nEst omnis atque voluptate et pariatur maiores voluptate optio non.", new DateTime(2023, 1, 14, 20, 45, 20, 70, DateTimeKind.Utc).AddTicks(6282), 27L, "Itaque perspiciatis a ut vel accusantium. Ducimus qui id reprehenderit quo facere voluptas. Recusandae delectus iste voluptates qui et architecto voluptas rerum. Magni voluptatibus labore est rerum inventore ipsum ex dolores.", "Repellendus esse repellendus enim et excepturi eum inventore ut autem.", 2L, "", 3, "Minus similique corrupti consequatur omnis in sunt tenetur." },
                    { 173L, 34L, "Id non alias totam quia qui at animi et. Dolor ipsam impedit nobis quae laboriosam omnis possimus cum. Ex et exercitationem necessitatibus. Expedita iure non laborum quisquam.", new DateTime(2023, 3, 23, 4, 36, 26, 653, DateTimeKind.Utc).AddTicks(8208), 25L, "Reprehenderit qui ut eius sint nam ipsam possimus occaecati est.", "Vel sed vitae maiores.", 1L, "", 1, "eos" }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[,]
                {
                    { 177L, 38L, "Dolor illum quis cupiditate vero assumenda repudiandae eaque ratione est.", new DateTime(2022, 12, 5, 16, 12, 16, 580, DateTimeKind.Utc).AddTicks(6785), 13L, "Fugiat quaerat ut ratione.", "Nisi ipsum deserunt odio neque voluptatem perferendis explicabo id.", 1L, "", 3, "illo" },
                    { 181L, 42L, "In quibusdam temporibus autem quod soluta aut cum hic. Accusantium cum atque vitae. Magnam quia nemo dolorum non maiores iste nostrum voluptas. Officiis maxime eius. Odio adipisci commodi voluptatem temporibus iusto animi.", new DateTime(2023, 5, 4, 23, 29, 20, 287, DateTimeKind.Utc).AddTicks(9306), 23L, "Neque velit delectus voluptatum quidem libero possimus pariatur repudiandae culpa.", "Facilis dolorum vitae voluptatem.", 1L, "", 0, "Nihil error excepturi sint. Consequatur dolorem sapiente neque repellendus quis officiis. Quia dolores officiis sit molestias accusantium est accusamus itaque. Illo molestias ipsa distinctio velit eligendi est quaerat." },
                    { 184L, 45L, "Soluta et totam necessitatibus.", new DateTime(2023, 7, 18, 17, 51, 6, 56, DateTimeKind.Utc).AddTicks(2366), 19L, "Omnis sed eligendi fuga sequi.\nUnde et nesciunt aut et at eos aut sint.\nId consequatur quo consequatur et neque debitis aut voluptatem.", "Quaerat fuga similique.", 1L, "", 0, "Quis commodi officia voluptatum autem esse.\nVel sequi maxime.\nEum enim nostrum ipsam officia nemo perferendis quo quia.\nAdipisci et dolorem rerum similique." },
                    { 193L, 54L, "quis", new DateTime(2023, 2, 7, 10, 0, 52, 535, DateTimeKind.Utc).AddTicks(8833), 8L, "Voluptate incidunt quidem.\nOdit eius possimus dolor veritatis dolorum dolor.\nQuae aut dolore nobis velit velit sequi ut.\nRem dolorem id assumenda quia.", "Tenetur vel dolore necessitatibus animi qui sed.", 2L, "", 3, "Aliquam dolor quia laborum qui eum.\nAccusamus ex in in inventore enim qui." }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "Output", "SubmittedAt" },
                values: new object[,]
                {
                    { 1L, 117L, "Vitae earum pariatur animi saepe explicabo asperiores molestiae et nihil. Esse provident id saepe nesciunt enim. Neque nemo dolore cupiditate temporibus vitae. Ut est voluptates qui minima dolor totam reprehenderit. Dolores non blanditiis facere numquam et facilis. Saepe sequi adipisci labore nesciunt.", new DateTime(2023, 8, 26, 23, 3, 35, 433, DateTimeKind.Utc).AddTicks(8518), 33L, "Tempora minus et in facilis natus voluptatem voluptas non. Dignissimos dicta dolor delectus molestiae alias accusantium voluptatem. Delectus cumque iste. Ea nam aut et. Necessitatibus molestiae odit quibusdam ullam ad ab quae.", new DateTime(2023, 9, 20, 19, 45, 18, 953, DateTimeKind.Utc).AddTicks(6488) },
                    { 2L, 35L, "Ea iste quos non incidunt consectetur numquam.\nQuod facilis dolorem libero.\nNostrum voluptates tempore non sint debitis et.\nFacilis temporibus molestias repudiandae aut amet non.\nIpsum amet perferendis id.\nAlias aut deleniti optio ea optio numquam.", new DateTime(2022, 9, 21, 18, 43, 14, 249, DateTimeKind.Utc).AddTicks(5561), 8L, "Aut vel dolores cupiditate et consectetur consequatur voluptatem. Voluptatem quasi quo assumenda maiores sit aliquid consequatur alias. Sunt praesentium voluptatem recusandae hic nostrum et consectetur ut aut.", new DateTime(2023, 4, 25, 0, 35, 6, 207, DateTimeKind.Utc).AddTicks(4201) },
                    { 3L, 60L, "Eum distinctio corporis ut dolorem et velit.", new DateTime(2023, 8, 17, 10, 29, 40, 58, DateTimeKind.Utc).AddTicks(9284), 40L, "Quis laboriosam dolores soluta illo est numquam.", new DateTime(2023, 9, 21, 0, 15, 9, 300, DateTimeKind.Utc).AddTicks(9390) },
                    { 4L, 157L, "Repellat est sequi.\nEaque cupiditate consequuntur harum deserunt atque delectus nisi.\nAut voluptate ut tenetur sint quam consequatur praesentium.", new DateTime(2023, 5, 7, 2, 28, 7, 327, DateTimeKind.Utc).AddTicks(1387), 1L, "Corrupti quasi omnis.\nRerum iusto dicta.\nMolestiae velit ut reprehenderit assumenda similique vel consequatur neque.\nUt velit sunt ut sint maiores beatae et.", new DateTime(2023, 6, 7, 19, 44, 26, 679, DateTimeKind.Utc).AddTicks(3583) },
                    { 5L, 49L, "Aspernatur qui delectus ut.", new DateTime(2023, 6, 2, 23, 19, 8, 958, DateTimeKind.Utc).AddTicks(2627), 7L, "nobis", new DateTime(2023, 9, 13, 3, 7, 21, 917, DateTimeKind.Utc).AddTicks(973) },
                    { 6L, 172L, "perferendis", new DateTime(2023, 5, 2, 16, 24, 31, 25, DateTimeKind.Utc).AddTicks(2674), 33L, "Esse voluptas facere autem. Delectus qui iste error voluptatem. Molestiae sequi impedit velit iste. Ipsum tempore molestiae esse aperiam eos accusantium placeat.", new DateTime(2023, 5, 5, 6, 34, 23, 967, DateTimeKind.Utc).AddTicks(5084) },
                    { 7L, 37L, "aut", new DateTime(2023, 9, 6, 5, 16, 1, 411, DateTimeKind.Utc).AddTicks(4828), 7L, "Iure saepe quas accusamus magni repellat velit ea.\nReprehenderit est labore.\nPorro earum consequatur nulla aspernatur a.\nVel nihil qui quae unde aut quo sed.\nA velit aut commodi asperiores vel nam.", null },
                    { 8L, 13L, "Voluptatem error provident quo beatae culpa modi repellendus.\nQuasi suscipit soluta neque praesentium voluptatem sed quis.", new DateTime(2023, 8, 24, 14, 18, 15, 220, DateTimeKind.Utc).AddTicks(6251), 28L, "Reiciendis sint debitis. Et ad sed perspiciatis omnis non. Placeat error explicabo accusantium maiores deleniti repellat praesentium. Id et eos. Expedita magni et impedit voluptatibus. Qui consequuntur nulla explicabo expedita aut.", new DateTime(2023, 9, 16, 17, 1, 2, 451, DateTimeKind.Utc).AddTicks(6903) },
                    { 9L, 47L, "Ut officia fugit quasi.\nSit rerum quis esse placeat nemo.\nDolor qui est est omnis.", new DateTime(2023, 6, 7, 7, 37, 2, 855, DateTimeKind.Utc).AddTicks(1252), 12L, "Consequuntur iure deserunt ut rem iusto et.", new DateTime(2023, 8, 16, 23, 47, 25, 474, DateTimeKind.Utc).AddTicks(5426) },
                    { 10L, 2L, "qui", new DateTime(2023, 9, 15, 9, 8, 45, 178, DateTimeKind.Utc).AddTicks(8269), 3L, "earum", new DateTime(2023, 9, 17, 7, 53, 47, 8, DateTimeKind.Utc).AddTicks(1741) },
                    { 11L, 98L, "Explicabo repellendus enim quia aut voluptas aperiam voluptatem. Sed aut placeat possimus nobis facilis quidem excepturi aperiam voluptatem. Possimus sunt magnam. Omnis rerum nihil possimus ut eius voluptates laboriosam provident aut. Nobis quia mollitia velit ab sequi quidem est earum. Aliquam amet vel quis temporibus.", new DateTime(2023, 1, 6, 22, 40, 37, 653, DateTimeKind.Utc).AddTicks(1349), 5L, "Omnis tenetur consequatur sed ea unde laudantium. Minima cum nam quia voluptas numquam officiis. A excepturi repudiandae quo non earum sed ipsam nemo distinctio. Qui voluptas iure iste praesentium nostrum vel. Molestiae et ratione voluptas ab id et debitis sapiente.", new DateTime(2023, 1, 17, 7, 4, 54, 563, DateTimeKind.Utc).AddTicks(8757) },
                    { 12L, 35L, "Nulla dolor ipsam qui fugiat.\nTempora cumque doloremque aut exercitationem necessitatibus sed quia.\nHic dignissimos rerum beatae consequatur maxime et aut omnis veritatis.\nQuia in magni deleniti.", new DateTime(2022, 11, 14, 5, 27, 40, 425, DateTimeKind.Utc).AddTicks(7104), 39L, "qui", new DateTime(2023, 4, 22, 20, 13, 53, 495, DateTimeKind.Utc).AddTicks(2245) },
                    { 13L, 61L, "Et et sit. Eos maiores voluptas ut qui in mollitia consequatur. Animi provident reiciendis soluta sed possimus.", new DateTime(2023, 6, 20, 14, 4, 29, 833, DateTimeKind.Utc).AddTicks(659), 11L, "Similique unde accusamus rem sint quo mollitia ea.\nQuos at ut necessitatibus soluta nulla.\nRerum beatae ipsam nemo possimus omnis.\nEst in autem placeat harum eum a adipisci quam et.", new DateTime(2023, 9, 8, 21, 56, 53, 62, DateTimeKind.Utc).AddTicks(784) },
                    { 14L, 38L, "alias", new DateTime(2023, 8, 19, 4, 27, 15, 657, DateTimeKind.Utc).AddTicks(6303), 6L, "Consequuntur aut excepturi blanditiis impedit at.", new DateTime(2023, 9, 11, 11, 20, 6, 714, DateTimeKind.Utc).AddTicks(8763) },
                    { 15L, 9L, "eveniet", new DateTime(2023, 2, 25, 18, 9, 40, 408, DateTimeKind.Utc).AddTicks(9049), 4L, "nam", new DateTime(2023, 3, 16, 20, 52, 34, 915, DateTimeKind.Utc).AddTicks(4311) },
                    { 16L, 81L, "Iusto laboriosam fuga dolor autem.\nAut consequatur ipsam alias laboriosam molestiae dolor.\nEarum nam eveniet quas cupiditate.\nSint inventore ducimus.", new DateTime(2023, 8, 28, 22, 38, 38, 948, DateTimeKind.Utc).AddTicks(9888), 34L, "Aut possimus mollitia non repudiandae nisi.", new DateTime(2023, 8, 30, 20, 12, 23, 331, DateTimeKind.Utc).AddTicks(6343) },
                    { 17L, 22L, "tempore", new DateTime(2023, 9, 6, 15, 35, 14, 584, DateTimeKind.Utc).AddTicks(6225), 40L, "Tempore quae quia iste qui rerum voluptas consequuntur debitis adipisci. Ab et dolor autem necessitatibus magnam. Sunt omnis vel deleniti in expedita dolores quibusdam. Sit eum in modi placeat id eos nulla perferendis ad. Ut sint sint totam est porro rerum autem velit. Cumque modi fugiat.", new DateTime(2023, 9, 15, 5, 37, 28, 595, DateTimeKind.Utc).AddTicks(6308) },
                    { 18L, 167L, "Repellendus repudiandae distinctio.\nUllam aut impedit enim nostrum.\nCommodi et odio temporibus expedita nulla repudiandae eum nobis assumenda.\nMollitia hic deleniti id maxime et similique quo.", new DateTime(2023, 8, 5, 17, 5, 12, 934, DateTimeKind.Utc).AddTicks(6325), 20L, "Facere facere sed consequatur quaerat.\nUt maxime dolor atque.\nSunt laboriosam id qui consectetur cupiditate dolor et ea a.\nEa amet delectus dolor eligendi iste qui qui mollitia.\nVeniam doloribus et nobis tempore et officia placeat.", new DateTime(2023, 8, 16, 1, 14, 24, 592, DateTimeKind.Utc).AddTicks(2615) },
                    { 19L, 116L, "Ut illo quae. Ut nostrum velit repellat qui non ipsa. Rem temporibus sit.", new DateTime(2022, 10, 13, 13, 18, 58, 109, DateTimeKind.Utc).AddTicks(9368), 9L, "necessitatibus", new DateTime(2023, 6, 24, 13, 12, 40, 697, DateTimeKind.Utc).AddTicks(3724) },
                    { 20L, 61L, "Aut debitis sit nesciunt qui et odit.\nEligendi quia tempore.\nInventore est doloribus.\nEt nostrum quod laborum excepturi ad eligendi.\nIste voluptas rem ab autem voluptatem rerum sed ipsum hic.\nVelit qui voluptas.", new DateTime(2023, 8, 21, 9, 16, 49, 406, DateTimeKind.Utc).AddTicks(1750), 34L, "Recusandae eaque dolor qui nisi itaque.", new DateTime(2023, 9, 15, 2, 36, 24, 424, DateTimeKind.Utc).AddTicks(988) },
                    { 21L, 17L, "Voluptatem beatae est amet explicabo id illum doloremque inventore.", new DateTime(2023, 9, 22, 10, 34, 40, 710, DateTimeKind.Utc).AddTicks(837), 23L, "et", new DateTime(2023, 9, 22, 10, 42, 10, 419, DateTimeKind.Utc).AddTicks(5121) },
                    { 22L, 27L, "Ipsa enim cum.\nQuos odit culpa et dolores reiciendis.", new DateTime(2023, 6, 8, 11, 36, 31, 864, DateTimeKind.Utc).AddTicks(9642), 16L, "voluptatem", new DateTime(2023, 9, 12, 23, 52, 57, 642, DateTimeKind.Utc).AddTicks(7013) },
                    { 23L, 37L, "Corporis ut iusto in.", new DateTime(2023, 8, 29, 10, 48, 50, 439, DateTimeKind.Utc).AddTicks(4754), 34L, "Perferendis quia perferendis quisquam eos. Officia nulla vel laudantium. Est fugit beatae excepturi maiores voluptatem ab. Modi ipsa ut autem perferendis labore voluptatem aliquid aut. Id repudiandae et cum qui explicabo autem id omnis. Doloribus iusto perspiciatis.", new DateTime(2023, 9, 4, 19, 5, 37, 779, DateTimeKind.Utc).AddTicks(8267) },
                    { 24L, 89L, "autem", new DateTime(2023, 6, 28, 7, 46, 39, 569, DateTimeKind.Utc).AddTicks(632), 13L, "Ut ab sunt.", new DateTime(2023, 9, 22, 8, 27, 14, 245, DateTimeKind.Utc).AddTicks(7891) },
                    { 25L, 59L, "Illo est omnis repellendus non ut maiores eos.\nUt recusandae quo repellendus dolores molestias.\nEst aut dolor.\nSunt ut corrupti error.\nAut fugiat et ut est exercitationem voluptate explicabo.\nQuos quasi placeat ut sit in neque et.", new DateTime(2021, 1, 14, 8, 15, 46, 334, DateTimeKind.Utc).AddTicks(7111), 32L, "Non repellendus vel nesciunt omnis enim. Molestiae nobis dolorum excepturi veniam maiores aperiam. Dolores omnis mollitia est dolore non quod inventore alias. Voluptas ratione rerum eum quae iusto. Repudiandae voluptatem sed ipsam voluptatem ad dolor exercitationem.", new DateTime(2021, 4, 30, 20, 37, 19, 999, DateTimeKind.Utc).AddTicks(2511) },
                    { 26L, 96L, "Quas voluptatem est illo aspernatur voluptas rerum. Qui consequatur quisquam iusto neque eos. Rerum sit voluptas quis quo dolores excepturi. Minima illum voluptatum. Quae sit hic accusantium et error. Eos sed iusto vel sunt qui voluptatem et.", new DateTime(2023, 1, 5, 20, 8, 36, 205, DateTimeKind.Utc).AddTicks(4327), 21L, "Ut dolores molestiae itaque assumenda molestiae dolores.\nEt aut asperiores voluptatem voluptas labore.\nOfficiis voluptas eos omnis repellendus et accusamus.", new DateTime(2023, 2, 28, 1, 33, 48, 840, DateTimeKind.Utc).AddTicks(2992) },
                    { 27L, 42L, "In molestiae et et est rem nisi non aut.", new DateTime(2023, 9, 15, 22, 12, 38, 7, DateTimeKind.Utc).AddTicks(2458), 26L, "Labore facilis et qui ut aut qui tenetur impedit quam.\nConsequatur nihil corrupti voluptatum est sed molestias natus sed et.", new DateTime(2023, 9, 16, 9, 22, 51, 534, DateTimeKind.Utc).AddTicks(34) },
                    { 28L, 72L, "Ut minus sunt facere eveniet.\nModi eveniet qui praesentium explicabo nam ipsam architecto nesciunt.\nAut atque labore repellat minus voluptas.\nAlias voluptates voluptatem est ullam quae architecto.\nMolestias vel cum commodi nobis ea inventore non.", new DateTime(2023, 9, 15, 20, 6, 39, 107, DateTimeKind.Utc).AddTicks(4695), 39L, "Dolorum ab totam blanditiis omnis omnis amet vitae.\nOmnis commodi assumenda perspiciatis voluptatem dolores similique voluptas officiis eius.\nPariatur excepturi id officia quis rerum quo rem qui illo.", new DateTime(2023, 9, 15, 22, 57, 12, 288, DateTimeKind.Utc).AddTicks(4823) },
                    { 29L, 20L, "Rem illo fugit sapiente fugit sapiente.\nLaborum magni nisi omnis.\nNumquam et odio voluptas et aut ipsam debitis dolorem.\nVoluptas quo earum et consequatur repellendus voluptatem non ipsam qui.", new DateTime(2023, 8, 14, 9, 10, 59, 791, DateTimeKind.Utc).AddTicks(2412), 17L, "iure", new DateTime(2023, 9, 18, 1, 24, 7, 446, DateTimeKind.Utc).AddTicks(5493) },
                    { 30L, 94L, "Excepturi consequatur sint aliquid quo ullam eos esse. Mollitia incidunt expedita quis. Numquam in voluptatem quia sequi ex officia. Doloremque delectus possimus eum magnam ad sint.", new DateTime(2023, 9, 17, 7, 38, 41, 166, DateTimeKind.Utc).AddTicks(1032), 26L, "Iusto quos qui voluptatum autem deserunt quasi. Facilis id autem porro ex autem aut. Hic voluptate et consectetur dolorum dicta dicta repudiandae suscipit. Deserunt aut ab et ut quia rerum est modi autem. Id est et dolores.", new DateTime(2023, 9, 18, 11, 36, 51, 983, DateTimeKind.Utc).AddTicks(3633) },
                    { 31L, 3L, "Esse voluptas aut aut cupiditate et ut voluptate.\nEos voluptas repellat veritatis praesentium dolor.\nVelit eum nam voluptatem enim libero non et.", new DateTime(2023, 4, 27, 1, 33, 58, 410, DateTimeKind.Utc).AddTicks(8017), 28L, "Aut autem odit.", new DateTime(2023, 5, 28, 8, 51, 32, 12, DateTimeKind.Utc).AddTicks(8566) },
                    { 32L, 140L, "Veritatis commodi assumenda debitis eum nobis animi voluptas et.\nConsectetur non ad.\nAtque hic incidunt.\nMaxime fugit nemo cum totam hic.", new DateTime(2023, 8, 19, 7, 3, 46, 339, DateTimeKind.Utc).AddTicks(8577), 15L, "Fugit et repellendus omnis dolorem et repudiandae dolores totam. Ad molestiae maiores laborum eaque alias voluptatibus dolor dignissimos eum. Ut reprehenderit reiciendis officiis rerum nihil atque iure. Illum et vitae rerum atque voluptatem facilis exercitationem commodi est.", new DateTime(2023, 8, 21, 0, 26, 25, 68, DateTimeKind.Utc).AddTicks(98) },
                    { 33L, 167L, "Quas enim tempore atque dolorem cupiditate rem dolores in.", new DateTime(2023, 9, 1, 2, 18, 29, 823, DateTimeKind.Utc).AddTicks(8011), 37L, "aut", new DateTime(2023, 9, 10, 8, 15, 38, 509, DateTimeKind.Utc).AddTicks(3088) },
                    { 34L, 95L, "Voluptas aspernatur consequuntur est ea.\nQuam facere totam est cupiditate nisi voluptatem iure.", new DateTime(2023, 8, 20, 15, 56, 29, 424, DateTimeKind.Utc).AddTicks(3193), 9L, "et", new DateTime(2023, 9, 10, 22, 49, 59, 980, DateTimeKind.Utc).AddTicks(2054) },
                    { 35L, 76L, "Sequi quo reprehenderit nihil officiis non qui dignissimos ut officia.\nNam autem dolores ipsam quibusdam placeat assumenda alias.\nIllo voluptas repellendus sint vel.\nEius aperiam nesciunt et maiores incidunt ut eius dolorum occaecati.\nAsperiores aut ut harum beatae.", new DateTime(2023, 1, 18, 14, 18, 30, 329, DateTimeKind.Utc).AddTicks(2494), 36L, "Maxime praesentium unde porro in laborum.", new DateTime(2023, 4, 24, 6, 12, 25, 705, DateTimeKind.Utc).AddTicks(5053) },
                    { 36L, 43L, "Officiis laborum reiciendis.", new DateTime(2023, 2, 2, 8, 3, 33, 226, DateTimeKind.Utc).AddTicks(7185), 15L, "Sed id velit voluptatem nesciunt.\nQuibusdam et possimus necessitatibus laudantium minus aut qui aliquid assumenda.", new DateTime(2023, 6, 29, 7, 10, 39, 793, DateTimeKind.Utc).AddTicks(466) },
                    { 37L, 23L, "A commodi incidunt laudantium nihil vel et.\nCupiditate autem fugiat eum suscipit qui iure quo id.\nQui quisquam ratione.", new DateTime(2023, 7, 26, 19, 10, 26, 962, DateTimeKind.Utc).AddTicks(8531), 18L, "Nihil odit quaerat et sed voluptatum quod alias tempora temporibus.\nAutem est sit beatae autem.\nHarum non sit natus cupiditate iusto quia sapiente libero doloremque.\nReprehenderit et voluptatum corporis atque ut.\nIpsam quia minima et ab illo fugiat animi unde.\nMollitia amet enim aperiam voluptas quod sint dignissimos optio.", new DateTime(2023, 7, 29, 16, 33, 51, 949, DateTimeKind.Utc).AddTicks(9287) },
                    { 38L, 16L, "Laborum sunt enim illo enim.\nSunt omnis aliquam nihil alias neque.\nQui et rerum nihil.\nDeleniti possimus in et repudiandae.", new DateTime(2023, 5, 19, 7, 0, 20, 473, DateTimeKind.Utc).AddTicks(3368), 3L, "Et culpa facilis architecto laborum sunt id placeat eius. Ut minus veniam. Optio enim excepturi eaque excepturi minima error impedit quaerat. Et corporis illo est et voluptatibus distinctio ut consectetur. Est asperiores fugit sit explicabo voluptates natus. Molestias necessitatibus et eligendi vitae nihil.", new DateTime(2023, 9, 7, 0, 50, 4, 767, DateTimeKind.Utc).AddTicks(2616) },
                    { 39L, 157L, "Voluptatem eos ducimus.\nEaque sint voluptas labore consequatur.\nUt omnis dolorem nihil sequi sit rerum animi quisquam sit.", new DateTime(2023, 5, 21, 14, 36, 31, 514, DateTimeKind.Utc).AddTicks(9471), 6L, "consequatur", new DateTime(2023, 7, 4, 5, 18, 55, 741, DateTimeKind.Utc).AddTicks(2313) },
                    { 40L, 24L, "Eveniet laborum ullam sint tempore aliquam id dolor officiis. Ut ut occaecati voluptas sequi quia sed ex. Repellendus recusandae pariatur vero ipsa saepe hic qui excepturi sunt. Quis et quis officia doloribus molestiae praesentium et. Ut mollitia neque. Beatae rerum recusandae nulla consequatur dolor eveniet vel.", new DateTime(2023, 6, 25, 4, 11, 53, 491, DateTimeKind.Utc).AddTicks(691), 28L, "Beatae pariatur quae facere quaerat dolorum est non modi.", new DateTime(2023, 8, 6, 17, 13, 40, 447, DateTimeKind.Utc).AddTicks(4581) },
                    { 41L, 177L, "Eos rerum quia quasi. Est quia omnis ea. Aut ea minus adipisci accusamus perferendis quaerat nostrum quod earum. Sed doloremque nemo quis. Totam sed est neque aperiam. Deserunt omnis aperiam non hic minus necessitatibus architecto et aut.", new DateTime(2023, 2, 6, 2, 41, 25, 782, DateTimeKind.Utc).AddTicks(7183), 36L, "Ipsum quos et voluptatem laboriosam eius id. Fugiat illo distinctio vero. Cumque qui corporis. Illo labore molestiae consectetur voluptas dolor nesciunt. Veritatis cupiditate ea nam sit velit ut quis nobis sed.", new DateTime(2023, 5, 5, 1, 40, 28, 989, DateTimeKind.Utc).AddTicks(3770) },
                    { 42L, 117L, "Omnis et autem architecto recusandae aperiam quasi est.", new DateTime(2023, 8, 25, 0, 27, 15, 209, DateTimeKind.Utc).AddTicks(3575), 22L, "Et minus et ea ipsam laboriosam vel ad eligendi sed.", new DateTime(2023, 9, 2, 22, 14, 31, 51, DateTimeKind.Utc).AddTicks(1474) }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "Output", "SubmittedAt" },
                values: new object[,]
                {
                    { 43L, 60L, "Earum suscipit autem libero exercitationem dolores.", new DateTime(2023, 8, 23, 20, 29, 22, 555, DateTimeKind.Utc).AddTicks(1310), 6L, "Cum repellendus accusamus.", new DateTime(2023, 9, 19, 7, 4, 2, 894, DateTimeKind.Utc).AddTicks(9005) },
                    { 44L, 83L, "Rerum aliquam quibusdam error et fugiat aut magnam.", new DateTime(2023, 5, 19, 9, 10, 28, 260, DateTimeKind.Utc).AddTicks(6777), 38L, "amet", new DateTime(2023, 8, 1, 16, 26, 33, 301, DateTimeKind.Utc).AddTicks(2863) },
                    { 45L, 52L, "Sapiente magnam quia ut a in.\nIste excepturi ratione quia et rerum magni sunt.", new DateTime(2023, 4, 11, 13, 29, 50, 626, DateTimeKind.Utc).AddTicks(556), 30L, "Cumque autem nihil.\nNatus ipsa ut quis veritatis doloremque quisquam.\nCupiditate tenetur quia blanditiis est.\nVoluptate voluptate exercitationem.\nMolestiae architecto quia sapiente quae commodi.\nVel architecto deleniti maxime provident fugiat facere.", new DateTime(2023, 5, 27, 12, 38, 5, 428, DateTimeKind.Utc).AddTicks(8932) },
                    { 46L, 38L, "Fugiat ut fuga magnam distinctio sit voluptate.\nQuia iusto dolor corporis ducimus et numquam.\nAsperiores et id dolore a et provident.", new DateTime(2023, 6, 30, 22, 24, 16, 394, DateTimeKind.Utc).AddTicks(1545), 13L, "Quisquam corporis suscipit magni odio dolorum. Voluptatem et sunt. Autem cumque commodi voluptate non.", new DateTime(2023, 8, 14, 1, 55, 18, 176, DateTimeKind.Utc).AddTicks(9337) },
                    { 47L, 167L, "quia", new DateTime(2023, 6, 8, 8, 52, 15, 800, DateTimeKind.Utc).AddTicks(9373), 3L, "quis", new DateTime(2023, 8, 16, 13, 55, 32, 294, DateTimeKind.Utc).AddTicks(692) },
                    { 48L, 47L, "Non laudantium aut non.\nAsperiores nesciunt dolore.\nIure consequuntur voluptatem velit.\nAutem quo molestiae recusandae.\nEt deserunt ratione laborum.", new DateTime(2023, 8, 12, 2, 3, 7, 862, DateTimeKind.Utc).AddTicks(1336), 34L, "et", new DateTime(2023, 9, 21, 0, 32, 9, 154, DateTimeKind.Utc).AddTicks(4358) },
                    { 49L, 76L, "Distinctio quos eveniet corporis voluptatem voluptatem ipsam deserunt.\nDolor quisquam beatae eum dicta.\nNatus quaerat modi expedita deleniti reprehenderit ut veritatis at.", new DateTime(2022, 10, 24, 4, 39, 39, 71, DateTimeKind.Utc).AddTicks(4758), 9L, "delectus", new DateTime(2023, 1, 26, 7, 11, 31, 808, DateTimeKind.Utc).AddTicks(3063) },
                    { 50L, 184L, "Sed impedit voluptatum provident aut tempore et.\nEnim delectus saepe sit esse possimus occaecati consequuntur.\nDignissimos asperiores voluptates enim quia molestiae quae ullam.\nVeritatis cumque sed repellat porro.\nLaboriosam ut unde voluptatem vitae est aut maiores in quod.", new DateTime(2023, 8, 23, 22, 53, 26, 302, DateTimeKind.Utc).AddTicks(7299), 39L, "explicabo", null },
                    { 51L, 25L, "Sit quod eum aliquam esse minima et.", new DateTime(2023, 8, 22, 10, 26, 57, 848, DateTimeKind.Utc).AddTicks(8914), 25L, "omnis", new DateTime(2023, 9, 1, 2, 1, 33, 594, DateTimeKind.Utc).AddTicks(9735) },
                    { 52L, 91L, "Non quis quae voluptatibus. Aut sit similique necessitatibus suscipit. Enim et dolorum. Omnis nihil optio et molestias perferendis magni. Est quos aliquid autem quis quia et nulla ab.", new DateTime(2023, 5, 30, 6, 1, 31, 377, DateTimeKind.Utc).AddTicks(1553), 20L, "Incidunt quisquam exercitationem deserunt nobis qui.", new DateTime(2023, 9, 16, 7, 53, 27, 92, DateTimeKind.Utc).AddTicks(1296) },
                    { 53L, 66L, "Deserunt facere rerum omnis nam ipsum eos vitae quas in. Voluptatibus quidem sapiente ea ut corrupti. Consequatur in iure. Deleniti eum aut sint perferendis voluptas id et corporis sunt. Iure dolor blanditiis aperiam nostrum iure. Voluptatem voluptatem eius eveniet.", new DateTime(2023, 4, 10, 13, 15, 20, 940, DateTimeKind.Utc).AddTicks(6211), 4L, "nihil", new DateTime(2023, 7, 11, 6, 49, 4, 859, DateTimeKind.Utc).AddTicks(6751) },
                    { 54L, 84L, "Natus animi nihil ad inventore perspiciatis ratione nesciunt consequatur voluptatum.", new DateTime(2023, 9, 11, 13, 26, 16, 851, DateTimeKind.Utc).AddTicks(2582), 40L, "Officia magnam dolor et itaque velit est accusamus dolores labore.\nQui est nemo nihil voluptatum alias ab laudantium.", null },
                    { 55L, 105L, "reiciendis", new DateTime(2023, 4, 18, 18, 6, 41, 510, DateTimeKind.Utc).AddTicks(9487), 11L, "Qui cum quidem aut amet sed voluptas ex quam dolorum.\nDistinctio quae nihil ea aperiam.\nSit labore est soluta consequatur molestiae sed aut.", new DateTime(2023, 5, 5, 11, 37, 27, 853, DateTimeKind.Utc).AddTicks(566) },
                    { 56L, 148L, "Necessitatibus soluta error aperiam omnis sed. Culpa quia qui molestiae. Suscipit est voluptate nihil. Corrupti facilis excepturi.", new DateTime(2023, 2, 7, 12, 36, 49, 591, DateTimeKind.Utc).AddTicks(7214), 40L, "Magnam occaecati nihil molestiae commodi vel dolore eligendi.\nAut magnam sequi quod quibusdam repellat repudiandae autem.\nQui natus modi.", new DateTime(2023, 7, 5, 20, 32, 46, 361, DateTimeKind.Utc).AddTicks(7599) },
                    { 57L, 141L, "et", new DateTime(2022, 12, 8, 20, 58, 30, 597, DateTimeKind.Utc).AddTicks(3067), 38L, "enim", new DateTime(2022, 12, 19, 3, 17, 38, 856, DateTimeKind.Utc).AddTicks(2448) },
                    { 58L, 43L, "Dolorem sed officiis saepe voluptas ea vitae.\nNam et eaque sunt pariatur praesentium.", new DateTime(2023, 7, 19, 22, 4, 19, 989, DateTimeKind.Utc).AddTicks(8656), 19L, "Nihil magnam laborum itaque ad perferendis laboriosam sit.", new DateTime(2023, 8, 11, 22, 45, 30, 606, DateTimeKind.Utc).AddTicks(637) },
                    { 59L, 89L, "Quo amet modi itaque est sit.\nQuas nobis sed nobis.\nDoloremque nam praesentium atque occaecati vero.\nVeritatis et eos suscipit vel et eligendi.", new DateTime(2022, 8, 21, 7, 13, 4, 883, DateTimeKind.Utc).AddTicks(7800), 30L, "Ut est necessitatibus a qui iste.", null },
                    { 60L, 41L, "voluptatem", new DateTime(2023, 9, 11, 4, 47, 48, 837, DateTimeKind.Utc).AddTicks(4155), 3L, "magnam", new DateTime(2023, 9, 12, 22, 1, 14, 115, DateTimeKind.Utc).AddTicks(26) },
                    { 61L, 181L, "Nihil explicabo quam in cumque pariatur velit architecto repellat. Vel sapiente a enim est ut rem non quibusdam dolore. Consequatur occaecati ipsa. Rerum voluptatem atque itaque ut et non neque necessitatibus.", new DateTime(2023, 5, 10, 3, 51, 20, 800, DateTimeKind.Utc).AddTicks(2730), 29L, "et", new DateTime(2023, 8, 28, 15, 40, 8, 828, DateTimeKind.Utc).AddTicks(8529) },
                    { 62L, 108L, "Velit quia qui.", new DateTime(2023, 8, 12, 12, 9, 11, 594, DateTimeKind.Utc).AddTicks(7070), 16L, "Id distinctio soluta vero sunt dolores facere saepe sunt.", new DateTime(2023, 9, 5, 11, 34, 26, 484, DateTimeKind.Utc).AddTicks(5361) },
                    { 63L, 9L, "praesentium", new DateTime(2022, 8, 18, 10, 57, 8, 760, DateTimeKind.Utc).AddTicks(6643), 33L, "veniam", new DateTime(2023, 7, 29, 13, 3, 37, 282, DateTimeKind.Utc).AddTicks(523) },
                    { 64L, 140L, "Reiciendis nihil est possimus voluptatem fugiat expedita deserunt quas debitis.", new DateTime(2023, 8, 26, 10, 14, 8, 324, DateTimeKind.Utc).AddTicks(2118), 10L, "Autem odio doloremque eos exercitationem nostrum nisi sed modi.", new DateTime(2023, 9, 11, 10, 58, 40, 425, DateTimeKind.Utc).AddTicks(797) },
                    { 65L, 193L, "Rerum quod sed sit. Fugit impedit accusantium dolores magnam perspiciatis sed modi vitae ab. Animi dignissimos nulla est non eum sunt velit nostrum. Placeat provident quas dolorem ea voluptates ipsam commodi.", new DateTime(2023, 6, 4, 13, 42, 35, 707, DateTimeKind.Utc).AddTicks(3165), 15L, "Cum eum voluptas voluptatem. Nesciunt eaque et. Alias voluptatem voluptas.", new DateTime(2023, 6, 13, 9, 50, 49, 43, DateTimeKind.Utc).AddTicks(3126) },
                    { 66L, 110L, "Dolorem sint necessitatibus ullam commodi dolor cupiditate ut saepe.", new DateTime(2022, 3, 4, 10, 20, 22, 533, DateTimeKind.Utc).AddTicks(2557), 16L, "Eius repudiandae nihil molestiae et occaecati blanditiis illum libero.\nIn non libero animi est ratione quia.\nEum placeat veritatis illo ut et repellendus non sapiente.\nQui consectetur qui dolorem.\nQui non non et quasi.\nNatus fugit deleniti qui harum sint soluta harum voluptas corrupti.", null },
                    { 67L, 44L, "Laudantium eos sunt iste enim incidunt voluptatum reprehenderit ut non. Libero possimus quos aut rerum ut quidem. Voluptates laboriosam est aut eveniet adipisci et.", new DateTime(2023, 4, 18, 19, 5, 29, 18, DateTimeKind.Utc).AddTicks(1237), 4L, "qui", new DateTime(2023, 6, 11, 15, 37, 34, 927, DateTimeKind.Utc).AddTicks(8776) },
                    { 68L, 122L, "Consequatur consequatur et dolore nam et veniam placeat aut aspernatur. Rerum eligendi odit ut esse numquam aliquam id. Eaque consectetur commodi distinctio accusantium beatae ullam officiis.", new DateTime(2023, 7, 14, 8, 43, 27, 134, DateTimeKind.Utc).AddTicks(1508), 40L, "Assumenda corporis quia dolores voluptatem fugiat suscipit dolore explicabo odio.\nAutem aspernatur et voluptatem nihil.", new DateTime(2023, 7, 23, 10, 4, 14, 171, DateTimeKind.Utc).AddTicks(997) },
                    { 69L, 132L, "Saepe dolorum rerum qui modi qui.", new DateTime(2021, 10, 16, 16, 23, 24, 809, DateTimeKind.Utc).AddTicks(1430), 16L, "Et adipisci sapiente. Sint ut ad culpa aut consequatur molestias. Nobis qui voluptatem id impedit. Enim illo necessitatibus illo reprehenderit.", new DateTime(2022, 10, 16, 22, 56, 43, 261, DateTimeKind.Utc).AddTicks(9631) },
                    { 70L, 19L, "Sequi aperiam nemo officiis et sapiente id amet.\nPerspiciatis incidunt dolore.", new DateTime(2022, 12, 8, 2, 35, 15, 270, DateTimeKind.Utc).AddTicks(6129), 28L, "Quia modi vel ea.\nNon harum aliquid sequi accusamus et in.\nUt qui expedita necessitatibus assumenda ut ex ut.\nCupiditate ea est ut amet exercitationem.\nDistinctio aut necessitatibus quas nihil architecto exercitationem.\nQuis mollitia ducimus occaecati.", new DateTime(2023, 1, 7, 1, 42, 31, 901, DateTimeKind.Utc).AddTicks(57) },
                    { 71L, 128L, "hic", new DateTime(2023, 9, 10, 10, 30, 9, 895, DateTimeKind.Utc).AddTicks(9300), 8L, "Deleniti sequi cupiditate aut eum.\nVoluptatem et perspiciatis voluptatem suscipit voluptas dolores veritatis.\nArchitecto voluptatem neque nesciunt velit animi ipsum eveniet fugiat officia.\nSint aliquam reprehenderit sapiente.\nQui dolorum voluptatem quia.\nVoluptatibus dolorem dolore mollitia modi expedita ab molestiae.", new DateTime(2023, 9, 21, 18, 51, 37, 818, DateTimeKind.Utc).AddTicks(8933) },
                    { 72L, 72L, "Temporibus voluptate voluptatum quod nemo quaerat est exercitationem mollitia sit.", new DateTime(2023, 8, 29, 2, 7, 1, 69, DateTimeKind.Utc).AddTicks(150), 24L, "Repellendus est eius dolor id dolor sunt. Sint error consectetur earum. Rem est placeat.", new DateTime(2023, 8, 31, 1, 22, 53, 824, DateTimeKind.Utc).AddTicks(3464) },
                    { 73L, 33L, "Ratione in sit voluptatum nostrum.", new DateTime(2022, 12, 25, 16, 15, 14, 867, DateTimeKind.Utc).AddTicks(1839), 27L, "Blanditiis quam totam rerum in et.\nSed perferendis eius temporibus officiis nulla.\nEt amet repellendus ipsa perspiciatis.\nId nihil nesciunt.\nLaboriosam quis architecto id quisquam nihil quibusdam.", new DateTime(2023, 7, 12, 21, 33, 35, 240, DateTimeKind.Utc).AddTicks(5905) },
                    { 74L, 52L, "Dolores aut quis.\nEos sit in.\nEos est eum est magnam maiores.\nAut facere quaerat eos ullam quis perspiciatis officiis.\nNemo quam quia id optio unde.\nSed tenetur ut velit et.", new DateTime(2023, 5, 19, 11, 7, 50, 143, DateTimeKind.Utc).AddTicks(9989), 12L, "et", new DateTime(2023, 8, 29, 23, 57, 22, 75, DateTimeKind.Utc).AddTicks(9791) },
                    { 75L, 105L, "Perspiciatis soluta facilis. Voluptatibus voluptatem temporibus provident repellendus. Tempora saepe quod odio veritatis aut dolor. Dolores nostrum minus veniam in. In aspernatur delectus odio sed voluptatum sit ipsa. Nostrum debitis dignissimos sapiente aliquid error sit.", new DateTime(2022, 12, 7, 4, 4, 46, 490, DateTimeKind.Utc).AddTicks(9579), 5L, "Qui eligendi laboriosam repudiandae.\nCommodi temporibus aperiam ut suscipit id veniam quaerat aut.\nAssumenda rerum ullam aliquid asperiores nemo quaerat sit nemo ducimus.\nEt aut molestiae maxime deleniti perspiciatis enim.", new DateTime(2023, 2, 12, 22, 37, 22, 655, DateTimeKind.Utc).AddTicks(8831) },
                    { 76L, 24L, "architecto", new DateTime(2023, 6, 14, 5, 28, 17, 329, DateTimeKind.Utc).AddTicks(4255), 28L, "Impedit maiores aut et laboriosam voluptatem.\nSoluta porro qui molestiae officiis error molestias.\nLaudantium exercitationem maxime.\nEst sequi at inventore ut nesciunt ut non sed.", new DateTime(2023, 7, 9, 0, 12, 45, 100, DateTimeKind.Utc).AddTicks(4691) },
                    { 77L, 65L, "Iusto hic minima doloribus nulla. Omnis ratione rerum. Consectetur et velit quisquam. Sit ut fugiat ad vero molestiae ipsa blanditiis doloribus.", new DateTime(2022, 12, 5, 18, 41, 19, 223, DateTimeKind.Utc).AddTicks(7916), 40L, "quae", null },
                    { 78L, 115L, "Accusantium ut laudantium temporibus omnis sunt explicabo repudiandae.\nRecusandae sequi molestiae.", new DateTime(2022, 8, 17, 11, 50, 11, 280, DateTimeKind.Utc).AddTicks(7442), 36L, "Vel rerum minima aperiam iste dolorum qui qui quos nostrum.", null },
                    { 79L, 132L, "Totam atque optio laudantium et sit.\nSit omnis perferendis.\nOccaecati fugiat nam quo alias ratione dolor ut ut dolor.", new DateTime(2023, 6, 4, 12, 15, 23, 23, DateTimeKind.Utc).AddTicks(6193), 1L, "Et at quia necessitatibus delectus.", new DateTime(2023, 7, 16, 10, 16, 37, 465, DateTimeKind.Utc).AddTicks(6870) },
                    { 80L, 76L, "Veniam repudiandae beatae aspernatur delectus quis vero eum odio.\nBlanditiis ut vitae vitae dicta pariatur et dolore veniam illo.\nEt laborum est nostrum.\nQuia ut quia.\nAut dolores nihil eos quisquam ut aspernatur.\nConsequatur aut iste recusandae consectetur aut porro expedita aut.", new DateTime(2023, 1, 16, 1, 58, 35, 20, DateTimeKind.Utc).AddTicks(2997), 6L, "Culpa totam esse. Nobis eius corporis iure aut vero velit tenetur quaerat et. Voluptatem non modi ea. Placeat repellat labore voluptatum dolores ut officiis qui ut. Modi magnam magni vitae asperiores laboriosam quisquam et. Quas non quo repellat.", new DateTime(2023, 7, 3, 7, 4, 36, 887, DateTimeKind.Utc).AddTicks(8155) },
                    { 81L, 42L, "Distinctio error sint nostrum.\nTempora itaque velit ducimus nisi sunt esse.\nQuidem rerum qui quia.", new DateTime(2023, 9, 11, 16, 41, 29, 46, DateTimeKind.Utc).AddTicks(3385), 33L, "Qui ipsa vero et eaque repellat sunt. Necessitatibus natus omnis perferendis sunt molestias error nobis non. Esse aut dolor iure qui neque ea exercitationem eum. Distinctio dolor et blanditiis rerum quibusdam in. Impedit repellat aliquam qui dolores quasi occaecati. Temporibus iste voluptas distinctio quasi quaerat est eum blanditiis quisquam.", new DateTime(2023, 9, 19, 5, 5, 53, 135, DateTimeKind.Utc).AddTicks(6050) },
                    { 82L, 21L, "Quia aut veritatis explicabo magni omnis odit.\nReiciendis numquam sed eum aut quo accusamus quo quis et.", new DateTime(2023, 9, 16, 0, 16, 32, 923, DateTimeKind.Utc).AddTicks(5877), 40L, "Dignissimos in quia fugit.", new DateTime(2023, 9, 16, 9, 58, 1, 142, DateTimeKind.Utc).AddTicks(2778) },
                    { 83L, 115L, "et", new DateTime(2022, 7, 30, 21, 32, 12, 600, DateTimeKind.Utc).AddTicks(8530), 39L, "Eos velit eum optio molestiae et iste.\nVeniam reprehenderit nulla.\nMaxime aut totam voluptatum voluptas omnis nostrum alias.\nConsequatur itaque rerum aspernatur.", new DateTime(2023, 4, 26, 3, 2, 47, 157, DateTimeKind.Utc).AddTicks(2157) },
                    { 84L, 59L, "Quam at praesentium consequatur cum quis. Laborum voluptatem sed dolor ut autem. Debitis deserunt eum nobis libero eius.", new DateTime(2020, 8, 12, 9, 16, 58, 889, DateTimeKind.Utc).AddTicks(1757), 21L, "Ab voluptatum rerum animi totam enim.", new DateTime(2022, 7, 6, 13, 14, 2, 956, DateTimeKind.Utc).AddTicks(1410) }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "Output", "SubmittedAt" },
                values: new object[,]
                {
                    { 85L, 84L, "quia", new DateTime(2023, 8, 13, 20, 39, 9, 766, DateTimeKind.Utc).AddTicks(7588), 19L, "aut", new DateTime(2023, 9, 18, 16, 31, 39, 655, DateTimeKind.Utc).AddTicks(5619) },
                    { 86L, 43L, "Soluta quisquam ut et. Vel veniam fugit aut alias repellat. Voluptatibus quia architecto et sed aspernatur voluptas et ipsum. Neque aspernatur fuga qui commodi aperiam. Ipsam voluptatem id commodi voluptatem.", new DateTime(2022, 7, 9, 18, 8, 49, 318, DateTimeKind.Utc).AddTicks(341), 38L, "debitis", null },
                    { 87L, 60L, "Non quia ducimus.", new DateTime(2023, 9, 13, 0, 15, 34, 818, DateTimeKind.Utc).AddTicks(2618), 24L, "nisi", new DateTime(2023, 9, 15, 18, 24, 45, 278, DateTimeKind.Utc).AddTicks(8192) },
                    { 88L, 45L, "Natus odio exercitationem accusamus. Magnam fugiat quos reiciendis qui odio. Sint velit reiciendis assumenda eaque quia assumenda tempore. Tenetur est dolor iste voluptatem blanditiis. Non minus et rem sit aut ipsam corrupti illo. Eius repellendus distinctio occaecati.", new DateTime(2023, 1, 9, 23, 34, 27, 521, DateTimeKind.Utc).AddTicks(4879), 1L, "molestiae", new DateTime(2023, 4, 15, 22, 30, 1, 469, DateTimeKind.Utc).AddTicks(2174) },
                    { 89L, 181L, "magnam", new DateTime(2023, 5, 6, 12, 41, 0, 876, DateTimeKind.Utc).AddTicks(7037), 39L, "Autem id nam fugit enim. Autem ipsa sapiente et assumenda delectus. Earum aut quos quo nulla.", new DateTime(2023, 9, 10, 11, 42, 13, 617, DateTimeKind.Utc).AddTicks(2241) },
                    { 90L, 37L, "Mollitia vitae quis molestias. Dolorem aliquid sit dolor impedit qui. Aut autem asperiores dolorum natus doloribus nesciunt eaque doloremque deleniti.", new DateTime(2023, 9, 18, 6, 11, 48, 596, DateTimeKind.Utc).AddTicks(4389), 6L, "Nemo voluptate pariatur.", new DateTime(2023, 9, 22, 0, 2, 11, 684, DateTimeKind.Utc).AddTicks(3738) },
                    { 91L, 26L, "Impedit facere qui voluptas earum et ipsam voluptas ipsum. Est sapiente neque doloribus reprehenderit aliquid minus est. Dolorem sed officia ad.", new DateTime(2023, 6, 22, 19, 14, 24, 917, DateTimeKind.Utc).AddTicks(2561), 40L, "quasi", new DateTime(2023, 7, 20, 3, 13, 6, 828, DateTimeKind.Utc).AddTicks(8861) },
                    { 92L, 89L, "asperiores", new DateTime(2023, 3, 12, 6, 29, 28, 436, DateTimeKind.Utc).AddTicks(8424), 38L, "Accusamus aut modi numquam nihil. Porro voluptatem nisi provident dignissimos nobis ratione repudiandae. Voluptatem magni vel tenetur quo quia deleniti. Eligendi delectus ea animi. Ut libero dolor velit velit impedit. Et molestias rem impedit qui in enim.", null },
                    { 93L, 67L, "Officiis sit consequatur magnam neque reprehenderit eos provident. Sit fugit magnam aut cum. Dolore corrupti odio reprehenderit veniam facilis expedita odit et. Pariatur unde in et tempore. Quibusdam optio tempore autem animi. Rerum unde magni eum reiciendis modi.", new DateTime(2023, 9, 21, 10, 29, 39, 126, DateTimeKind.Utc).AddTicks(5315), 35L, "Exercitationem aliquam sint vel.\nFuga velit atque doloremque numquam architecto enim earum enim.\nVeniam laudantium culpa cum ipsam omnis ullam aut sequi.", new DateTime(2023, 9, 21, 17, 5, 29, 506, DateTimeKind.Utc).AddTicks(4721) },
                    { 94L, 79L, "Neque nesciunt iste nostrum expedita nobis.\nPorro iure non facilis culpa cupiditate beatae consequatur ut.\nAspernatur excepturi rerum aut sit.\nRepellat autem voluptas cupiditate ut qui ratione.", new DateTime(2023, 8, 15, 5, 31, 22, 937, DateTimeKind.Utc).AddTicks(1859), 10L, "Expedita ratione dolor possimus omnis fuga omnis quo sapiente.\nNisi expedita corporis et dolor sed expedita aut et sequi.\nVoluptate qui error iste sint saepe neque animi maiores.", new DateTime(2023, 9, 14, 21, 2, 21, 888, DateTimeKind.Utc).AddTicks(582) },
                    { 95L, 128L, "Id rem minus molestiae ab sunt. Laboriosam architecto dolores maxime qui. Quia dolor quia.", new DateTime(2023, 9, 14, 3, 59, 48, 242, DateTimeKind.Utc).AddTicks(9721), 9L, "Eius velit quidem. Et fugit aut est porro autem et omnis. Ipsam dolor labore sit nihil accusamus ea illo enim.", new DateTime(2023, 9, 17, 15, 44, 18, 189, DateTimeKind.Utc).AddTicks(8222) },
                    { 96L, 137L, "Architecto illum dolorum non consequatur veniam aut quod sed. Architecto in sed delectus sunt quis eveniet velit saepe. Qui repellendus fugit rerum rerum voluptates voluptatibus temporibus ut adipisci.", new DateTime(2023, 8, 24, 9, 59, 34, 125, DateTimeKind.Utc).AddTicks(4111), 26L, "inventore", new DateTime(2023, 9, 13, 5, 56, 0, 81, DateTimeKind.Utc).AddTicks(1258) },
                    { 97L, 72L, "Eos officia nemo illo quis expedita est magnam enim reprehenderit. Praesentium voluptatem magni qui nostrum nihil minus. Aspernatur corporis enim assumenda et sunt perferendis est libero libero. Incidunt reiciendis aut repellat quibusdam eos voluptatum veritatis animi nostrum.", new DateTime(2023, 9, 13, 23, 52, 27, 349, DateTimeKind.Utc).AddTicks(5060), 21L, "qui", null },
                    { 98L, 16L, "Consequatur reiciendis voluptate recusandae numquam deserunt.", new DateTime(2023, 7, 2, 17, 8, 26, 384, DateTimeKind.Utc).AddTicks(3781), 17L, "Deleniti enim aut odit qui vel. Perspiciatis ex voluptatem sit. Vel facilis magni est sapiente sunt temporibus. Dolore temporibus aut ad. Distinctio repudiandae qui quae. Ea aut ipsa sunt culpa voluptas velit doloremque ratione eos.", new DateTime(2023, 7, 4, 3, 17, 41, 392, DateTimeKind.Utc).AddTicks(1528) },
                    { 99L, 173L, "Ad dolore magnam sit eaque. Eos est ullam id repudiandae et totam laboriosam. Laudantium et ea quos est veritatis.", new DateTime(2023, 5, 20, 18, 40, 55, 763, DateTimeKind.Utc).AddTicks(5634), 19L, "Molestiae est assumenda sed commodi a aut dolore rem in. Et rerum iure recusandae velit tenetur necessitatibus. Aut fugit modi. Vitae harum sapiente in consequatur qui totam ad.", new DateTime(2023, 8, 2, 11, 47, 20, 473, DateTimeKind.Utc).AddTicks(5741) },
                    { 100L, 67L, "Laboriosam dolores nam ducimus saepe. Cumque dolorem incidunt nihil beatae assumenda quia est rem. Sed reiciendis nobis atque in iste ullam autem consequatur.", new DateTime(2023, 9, 21, 19, 7, 38, 510, DateTimeKind.Utc).AddTicks(2398), 22L, "Fugiat voluptatem autem.", new DateTime(2023, 9, 22, 4, 27, 26, 151, DateTimeKind.Utc).AddTicks(92) },
                    { 101L, 50L, "Omnis dolor quis non eos ipsum.", new DateTime(2022, 12, 18, 5, 51, 25, 927, DateTimeKind.Utc).AddTicks(8661), 16L, "Optio aut optio dolores quas.", new DateTime(2023, 5, 16, 13, 38, 28, 348, DateTimeKind.Utc).AddTicks(8170) },
                    { 102L, 148L, "Dignissimos officia quisquam et quas iusto officiis provident voluptas. Vitae nesciunt commodi molestiae velit in iste. Eum repudiandae quam nemo sed.", new DateTime(2021, 5, 17, 18, 48, 57, 965, DateTimeKind.Utc).AddTicks(8357), 26L, "Illum voluptate eos quis reprehenderit.", new DateTime(2022, 9, 26, 7, 48, 6, 202, DateTimeKind.Utc).AddTicks(3474) },
                    { 103L, 63L, "error", new DateTime(2023, 5, 15, 21, 30, 35, 823, DateTimeKind.Utc).AddTicks(9887), 30L, "harum", new DateTime(2023, 9, 3, 17, 45, 20, 665, DateTimeKind.Utc).AddTicks(3462) },
                    { 104L, 116L, "Sapiente non omnis voluptatibus.\nIn minima qui dolores iure ut provident est.\nMinus neque ducimus.", new DateTime(2022, 8, 4, 3, 22, 16, 501, DateTimeKind.Utc).AddTicks(8190), 8L, "Repellendus explicabo consequatur. Quos et est in culpa qui quo possimus repellat. Ducimus non deserunt velit ut molestias quo consequuntur.", new DateTime(2023, 3, 13, 0, 15, 24, 697, DateTimeKind.Utc).AddTicks(3480) },
                    { 105L, 47L, "Voluptate sint dignissimos ullam aliquid et quia earum.\nEaque placeat aut accusamus soluta tempore.\nProvident perferendis culpa aut similique aperiam consequatur.\nSed expedita saepe velit fuga a nobis earum.\nUt quae velit ipsam cumque quia culpa.", new DateTime(2023, 5, 21, 23, 54, 48, 919, DateTimeKind.Utc).AddTicks(7462), 17L, "Non omnis a quaerat sint dolores fuga alias non consequuntur.\nAut quis molestias omnis aspernatur eligendi ut consequatur voluptatem provident.\nConsequatur quaerat ut quidem voluptatum.\nEum est alias beatae sint.\nArchitecto ut et.", new DateTime(2023, 9, 22, 8, 1, 22, 600, DateTimeKind.Utc).AddTicks(3596) },
                    { 106L, 65L, "Autem tempore est sed id et est quisquam. Iure culpa tenetur optio quis. Expedita ut ipsum labore consequuntur eveniet consectetur quaerat iusto officiis. Exercitationem deserunt itaque voluptatem in deserunt asperiores et dolor. Temporibus id modi inventore reprehenderit ea qui est quos hic. Fugit dolores velit est repellendus sint est.", new DateTime(2022, 11, 20, 8, 30, 21, 120, DateTimeKind.Utc).AddTicks(1727), 22L, "Aliquam nam placeat suscipit perferendis dolor.\nVel maiores a.\nOdit et accusamus.\nRerum sit minus ut est provident earum.\nEnim dolor aspernatur non libero autem beatae nemo officiis in.", new DateTime(2023, 4, 14, 11, 1, 56, 701, DateTimeKind.Utc).AddTicks(4434) },
                    { 107L, 57L, "Error repudiandae molestias doloribus laudantium consequatur sunt.", new DateTime(2022, 2, 21, 2, 54, 19, 147, DateTimeKind.Utc).AddTicks(4998), 19L, "Suscipit tenetur quia asperiores rerum ipsam id odio nesciunt.\nAliquam ut voluptatem voluptates et quia non autem suscipit sed.", null },
                    { 108L, 141L, "Nulla ipsum cupiditate maiores et tenetur maxime ex libero qui.\nEius suscipit aperiam error laudantium voluptatem eius saepe.\nLaboriosam aliquam voluptatum velit quia quas commodi.\nMollitia et hic enim aut aut deserunt maiores iure.", new DateTime(2023, 7, 9, 2, 23, 38, 708, DateTimeKind.Utc).AddTicks(2387), 18L, "Et neque ullam ut rerum porro sed velit.", new DateTime(2023, 8, 26, 9, 50, 8, 294, DateTimeKind.Utc).AddTicks(9805) },
                    { 109L, 20L, "Officia eligendi voluptas dolor quia officia officiis.\nNihil quidem iure suscipit provident odio in architecto ab.\nDolorem iusto ipsa porro provident atque.\nNemo molestiae aut.\nId quia unde quae quia consequatur nostrum veritatis.\nMollitia deleniti nostrum ut fugit enim.", new DateTime(2023, 8, 21, 18, 20, 1, 408, DateTimeKind.Utc).AddTicks(5579), 35L, "Nam alias quia qui deserunt sit saepe in iste.", new DateTime(2023, 9, 12, 18, 42, 52, 205, DateTimeKind.Utc).AddTicks(75) },
                    { 110L, 22L, "Qui excepturi voluptas.\nQuia iusto veniam perferendis natus.\nUt qui quas id modi sequi corporis rerum molestiae et.\nPerferendis autem et facilis et dolores magni numquam quibusdam dolor.\nReprehenderit deleniti nostrum quibusdam atque quos laboriosam similique eaque.\nDoloremque et unde quaerat illo ut itaque est reprehenderit.", new DateTime(2023, 9, 19, 9, 27, 59, 450, DateTimeKind.Utc).AddTicks(9345), 10L, "id", new DateTime(2023, 9, 21, 14, 41, 54, 479, DateTimeKind.Utc).AddTicks(6731) },
                    { 111L, 89L, "Voluptatem quibusdam omnis sed provident.\nVoluptatem enim nihil libero consequatur ullam ea laborum.\nVoluptatibus commodi odit.\nAnimi et consectetur cupiditate voluptate id.\nRatione nemo atque.", new DateTime(2022, 9, 6, 1, 12, 42, 115, DateTimeKind.Utc).AddTicks(417), 35L, "ullam", null },
                    { 112L, 47L, "Perferendis molestias doloremque a sint.", new DateTime(2023, 8, 5, 0, 59, 45, 758, DateTimeKind.Utc).AddTicks(4440), 36L, "culpa", new DateTime(2023, 8, 9, 20, 18, 48, 729, DateTimeKind.Utc).AddTicks(9210) },
                    { 113L, 27L, "Aliquam architecto iusto.", new DateTime(2023, 3, 26, 21, 1, 47, 125, DateTimeKind.Utc).AddTicks(9084), 30L, "Sint blanditiis animi porro eum. Quis a et explicabo est. Quo ab sunt. Similique voluptates cum quas dolorem est optio excepturi quia expedita.", new DateTime(2023, 7, 11, 16, 53, 23, 718, DateTimeKind.Utc).AddTicks(2531) },
                    { 114L, 108L, "Quibusdam natus voluptates ipsam consequuntur ipsum est fuga dolore quis. Doloremque fugit corporis doloribus autem molestias cupiditate veniam assumenda provident. Possimus sunt molestias ipsum et sequi ea aperiam voluptatem. Sit et aliquam provident ut magnam dolor quas at. Voluptatum velit id quia.", new DateTime(2023, 9, 3, 10, 59, 39, 274, DateTimeKind.Utc).AddTicks(5996), 30L, "Eius sunt nemo facilis.\nVel consequatur aut illum aut tenetur iste dolores voluptatem non.\nAut cumque enim.\nPraesentium voluptate aliquam.", new DateTime(2023, 9, 9, 17, 52, 6, 769, DateTimeKind.Utc).AddTicks(88) },
                    { 115L, 40L, "Suscipit harum amet non qui rerum.", new DateTime(2022, 9, 1, 2, 31, 30, 58, DateTimeKind.Utc).AddTicks(441), 19L, "Nihil magnam est voluptatem dignissimos. Rerum ea earum voluptatem iure dolores rem incidunt vel. Vel fugiat error et illo ab est praesentium sit.", new DateTime(2023, 4, 8, 1, 8, 17, 430, DateTimeKind.Utc).AddTicks(3129) },
                    { 116L, 73L, "Tenetur laboriosam rerum.", new DateTime(2022, 6, 5, 15, 59, 5, 856, DateTimeKind.Utc).AddTicks(2064), 14L, "Consequatur sint eum omnis reprehenderit. A doloribus eos. Consequatur neque voluptas fugit reprehenderit nostrum. Autem natus voluptatem qui aut. Culpa autem illum repellat ipsam ut dolores.", null },
                    { 117L, 126L, "Expedita quidem quas nisi laborum molestiae natus.\nAutem sequi soluta nam doloremque excepturi.", new DateTime(2023, 1, 24, 2, 3, 22, 554, DateTimeKind.Utc).AddTicks(7288), 18L, "rem", new DateTime(2023, 3, 25, 16, 18, 3, 844, DateTimeKind.Utc).AddTicks(4455) },
                    { 118L, 43L, "Ducimus est illo tempora magni assumenda dicta quod.\nAut porro molestiae omnis voluptatum.", new DateTime(2023, 2, 28, 4, 25, 59, 675, DateTimeKind.Utc).AddTicks(9605), 34L, "Sit iure accusantium nulla quidem debitis aut.", new DateTime(2023, 3, 25, 19, 11, 20, 506, DateTimeKind.Utc).AddTicks(6126) },
                    { 119L, 38L, "repellendus", new DateTime(2023, 6, 18, 2, 20, 48, 201, DateTimeKind.Utc).AddTicks(7494), 32L, "Vero saepe rerum accusamus sit ad accusantium.\nItaque voluptate tempora.", new DateTime(2023, 9, 18, 11, 2, 26, 103, DateTimeKind.Utc).AddTicks(5962) },
                    { 120L, 17L, "Perspiciatis quia aut similique fuga. Debitis similique facilis eveniet. Totam veritatis harum laboriosam ut qui deleniti.", new DateTime(2023, 9, 22, 4, 48, 10, 682, DateTimeKind.Utc).AddTicks(2145), 40L, "Alias dolor optio.\nDebitis ipsa eaque pariatur dolorem porro.\nOmnis quis ut vel pariatur quia.\nEst blanditiis nihil vel dolorem.\nEarum neque nesciunt ut consequatur autem.", new DateTime(2023, 9, 22, 6, 35, 28, 8, DateTimeKind.Utc).AddTicks(4485) },
                    { 121L, 7L, "Aspernatur maxime dolor voluptas quisquam.", new DateTime(2019, 10, 26, 9, 58, 41, 119, DateTimeKind.Utc).AddTicks(1599), 39L, "Fugit repudiandae eligendi sunt.", null },
                    { 122L, 37L, "voluptate", new DateTime(2023, 9, 14, 9, 3, 36, 651, DateTimeKind.Utc).AddTicks(3740), 2L, "Non porro aut et eaque.\nQuisquam voluptatem aut aut asperiores hic ut modi sint.\nEt maiores ut maiores enim accusantium.\nQuasi aut possimus sed omnis beatae.\nAt molestiae vel ipsa sunt.", new DateTime(2023, 9, 19, 21, 52, 56, 930, DateTimeKind.Utc).AddTicks(5713) },
                    { 123L, 23L, "Et culpa aspernatur aut excepturi aperiam cumque qui et.", new DateTime(2023, 7, 31, 12, 4, 0, 563, DateTimeKind.Utc).AddTicks(8561), 38L, "Et a quas dolore vel inventore veniam tempore.", null },
                    { 124L, 95L, "et", new DateTime(2023, 8, 20, 1, 13, 24, 838, DateTimeKind.Utc).AddTicks(9036), 20L, "Voluptas corporis numquam non.\nSed necessitatibus ut repellat et dicta.\nQuos eligendi molestiae.\nAmet vitae et dolor.", new DateTime(2023, 8, 20, 14, 8, 50, 135, DateTimeKind.Utc).AddTicks(4127) },
                    { 125L, 16L, "Doloremque officiis perferendis vel non.\nOmnis quia et aspernatur dolores iure.\nVoluptas veritatis eaque qui accusamus.", new DateTime(2023, 6, 4, 7, 16, 44, 524, DateTimeKind.Utc).AddTicks(410), 38L, "Vero tenetur esse officia impedit eligendi consequuntur ut velit.\nAutem voluptates sunt.", new DateTime(2023, 8, 21, 4, 8, 0, 442, DateTimeKind.Utc).AddTicks(9727) },
                    { 126L, 177L, "sint", new DateTime(2023, 2, 2, 12, 14, 22, 469, DateTimeKind.Utc).AddTicks(4558), 26L, "Dicta officia soluta nihil rerum et commodi et.", new DateTime(2023, 5, 26, 14, 22, 50, 863, DateTimeKind.Utc).AddTicks(2901) }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "Output", "SubmittedAt" },
                values: new object[,]
                {
                    { 127L, 12L, "Et quisquam est eius ullam dicta cumque voluptatum repellendus. Recusandae consequatur debitis alias et dicta cupiditate ratione et eum. Veniam ab voluptatum ut assumenda consequatur dolorem impedit vitae assumenda. Et repudiandae consequatur ea. Dicta velit repellat rerum quia.", new DateTime(2023, 9, 3, 3, 54, 38, 325, DateTimeKind.Utc).AddTicks(8158), 28L, "Omnis omnis facilis ex fugit sapiente doloremque illo.\nRerum numquam libero quia soluta provident porro debitis voluptas.\nDolores qui sit delectus harum aliquam illum iusto.\nAccusamus earum cumque rerum enim possimus doloribus eius.\nTotam mollitia quia quod sequi vero doloremque voluptatem.", new DateTime(2023, 9, 20, 3, 17, 51, 511, DateTimeKind.Utc).AddTicks(2054) },
                    { 128L, 45L, "odio", new DateTime(2022, 11, 15, 15, 23, 34, 435, DateTimeKind.Utc).AddTicks(3505), 29L, "Quis qui aut aspernatur exercitationem non exercitationem amet eum amet. Ea esse eligendi enim asperiores velit ipsum. Reprehenderit in quia recusandae atque similique est. Vero qui recusandae. Cumque cumque assumenda et harum.", new DateTime(2023, 5, 18, 21, 14, 9, 711, DateTimeKind.Utc).AddTicks(6129) },
                    { 129L, 93L, "In voluptas soluta porro error nostrum mollitia enim commodi. Velit quae est non. Sunt et iusto animi saepe molestiae officiis.", new DateTime(2023, 7, 18, 3, 56, 39, 880, DateTimeKind.Utc).AddTicks(4821), 37L, "Soluta minima ipsa.\nMaiores rerum est exercitationem explicabo et labore ipsa enim.\nExercitationem suscipit doloribus suscipit corrupti.\nSunt voluptatibus amet quo qui.\nAut consequatur magni.", new DateTime(2023, 7, 20, 5, 40, 32, 264, DateTimeKind.Utc).AddTicks(2159) },
                    { 130L, 25L, "In vel ut aut placeat iste fuga. Non consectetur ratione corporis natus. Ut ipsum exercitationem quas optio sunt quia qui saepe itaque.", new DateTime(2023, 8, 24, 19, 35, 29, 552, DateTimeKind.Utc).AddTicks(4627), 8L, "dolorem", new DateTime(2023, 8, 25, 3, 49, 53, 15, DateTimeKind.Utc).AddTicks(8642) },
                    { 131L, 34L, "Dolor deserunt a modi unde.", new DateTime(2023, 9, 10, 8, 8, 9, 599, DateTimeKind.Utc).AddTicks(5036), 28L, "Ut velit ut eos et sunt voluptatibus. Quas id qui amet. Aliquid aliquam atque voluptas similique qui eum quam est sint. Id sit dolor nisi culpa rerum maxime.", new DateTime(2023, 9, 18, 9, 35, 38, 343, DateTimeKind.Utc).AddTicks(6054) },
                    { 132L, 193L, "Deserunt adipisci eaque et. Non eius commodi molestiae laboriosam. Saepe voluptatibus labore ipsa qui illum.", new DateTime(2023, 6, 5, 1, 20, 0, 89, DateTimeKind.Utc).AddTicks(950), 10L, "Quae autem quidem.\nIste doloribus praesentium repudiandae reprehenderit est nemo.\nMagnam reprehenderit asperiores amet vel distinctio.", new DateTime(2023, 8, 15, 21, 15, 27, 475, DateTimeKind.Utc).AddTicks(4135) },
                    { 133L, 29L, "odit", new DateTime(2020, 9, 22, 10, 0, 24, 430, DateTimeKind.Utc).AddTicks(2299), 18L, "voluptas", new DateTime(2023, 4, 9, 0, 4, 45, 155, DateTimeKind.Utc).AddTicks(8073) },
                    { 134L, 6L, "Quibusdam iste praesentium molestias.\nEt nemo ut quod doloremque.\nFacilis officia dolore vero omnis sequi odio iure est iure.\nHarum rem quas modi voluptatem soluta.\nVoluptas quae rerum.\nVoluptatem adipisci et et voluptatem.", new DateTime(2023, 6, 30, 13, 16, 56, 493, DateTimeKind.Utc).AddTicks(1638), 4L, "Nobis laborum aut consequuntur. Dolor adipisci autem fuga eligendi dolorem. Nisi quod ex molestiae. Consequatur veritatis quae et delectus ut maiores explicabo laboriosam quia. Tempora quo alias. Praesentium qui nihil fugiat expedita nisi.", new DateTime(2023, 7, 26, 5, 1, 52, 340, DateTimeKind.Utc).AddTicks(9655) },
                    { 135L, 20L, "modi", new DateTime(2023, 6, 30, 17, 49, 58, 605, DateTimeKind.Utc).AddTicks(9036), 28L, "Voluptas nihil itaque ratione saepe rerum qui.\nImpedit doloribus aperiam et at qui voluptatem repellendus.\nLaboriosam omnis rerum aperiam occaecati ut rerum voluptates.\nEius quia officia.\nVoluptas molestiae eum et numquam occaecati ut at officia.\nVel maiores quia libero enim doloremque consectetur.", new DateTime(2023, 8, 7, 20, 46, 49, 178, DateTimeKind.Utc).AddTicks(3007) },
                    { 136L, 7L, "Voluptatem iusto exercitationem labore debitis nam. Magni tenetur modi est nobis. Non et rerum.", new DateTime(2019, 3, 1, 0, 28, 56, 927, DateTimeKind.Utc).AddTicks(2163), 15L, "Dolores ab in mollitia. Debitis dolorem provident dolorem asperiores. Aut cupiditate quis enim saepe. Id et impedit. Omnis vero dolorem dignissimos nihil nisi dolores possimus non impedit. Magni porro debitis odio sint voluptas delectus.", new DateTime(2019, 8, 8, 11, 54, 53, 278, DateTimeKind.Utc).AddTicks(410) },
                    { 137L, 42L, "Enim maxime aperiam.\nMinima eius eaque minima culpa adipisci incidunt.\nFuga sed est omnis.", new DateTime(2023, 9, 19, 17, 58, 32, 577, DateTimeKind.Utc).AddTicks(9253), 28L, "Facere consequatur dolores officiis reiciendis et rerum aliquam.\nEst blanditiis quisquam excepturi odit dolorum aperiam reprehenderit.\nMaiores et in sunt iusto exercitationem et nobis.", new DateTime(2023, 9, 20, 18, 9, 48, 713, DateTimeKind.Utc).AddTicks(6784) },
                    { 138L, 84L, "Reiciendis officia ad vel accusamus illo ullam rerum sapiente.", new DateTime(2023, 9, 13, 3, 19, 4, 198, DateTimeKind.Utc).AddTicks(1870), 3L, "Consequuntur rem quisquam quae consequatur et exercitationem.", new DateTime(2023, 9, 15, 18, 6, 57, 835, DateTimeKind.Utc).AddTicks(1922) },
                    { 139L, 27L, "Et nostrum iste ullam.", new DateTime(2023, 2, 21, 8, 32, 20, 210, DateTimeKind.Utc).AddTicks(5175), 14L, "Quam repellat officiis sed sint.", new DateTime(2023, 7, 13, 10, 49, 36, 6, DateTimeKind.Utc).AddTicks(374) },
                    { 140L, 173L, "Non ipsum assumenda delectus rerum suscipit quia architecto. Aut doloribus optio non ut. Et voluptas maxime nisi provident aspernatur dicta. Animi amet provident expedita.", new DateTime(2023, 4, 11, 13, 13, 31, 722, DateTimeKind.Utc).AddTicks(1864), 37L, "Iure ut et nulla tenetur dignissimos accusantium vero voluptas.", new DateTime(2023, 5, 16, 13, 27, 46, 588, DateTimeKind.Utc).AddTicks(1383) },
                    { 141L, 167L, "aut", new DateTime(2023, 7, 7, 21, 14, 2, 222, DateTimeKind.Utc).AddTicks(7112), 25L, "Id minima ut itaque ducimus et. Voluptas ipsa ipsum dolor aut cum ipsa. Voluptates quo molestiae at reiciendis. Officia eum odio fugiat vel molestiae. Delectus itaque quisquam ut rerum non cum quos corrupti doloremque.", new DateTime(2023, 8, 23, 1, 41, 45, 127, DateTimeKind.Utc).AddTicks(4478) },
                    { 142L, 129L, "Quis veritatis repudiandae quia aliquid tenetur maiores est asperiores.\nSaepe laudantium odit.\nVoluptatum quisquam officiis.\nQui et dolorem.", new DateTime(2023, 5, 17, 8, 3, 53, 885, DateTimeKind.Utc).AddTicks(6268), 26L, "Aut nihil consequatur enim repudiandae.", new DateTime(2023, 8, 14, 12, 20, 44, 659, DateTimeKind.Utc).AddTicks(8839) },
                    { 143L, 57L, "explicabo", new DateTime(2022, 10, 18, 10, 13, 52, 117, DateTimeKind.Utc).AddTicks(813), 22L, "Omnis officia voluptas commodi suscipit eius nam animi voluptatem molestiae.", new DateTime(2023, 6, 22, 3, 0, 59, 734, DateTimeKind.Utc).AddTicks(8237) },
                    { 144L, 141L, "fugit", new DateTime(2022, 7, 10, 15, 9, 36, 960, DateTimeKind.Utc).AddTicks(5674), 40L, "Odit dolor perspiciatis facilis quasi reiciendis qui velit.\nSimilique architecto aut aut.\nFugit occaecati nobis et eum dolore cumque quia in.\nVoluptas qui consequatur quia est blanditiis omnis qui ad libero.\nReiciendis ipsa quia exercitationem ex beatae magnam in qui.\nSunt aliquid officiis laborum ea iste ab aut sunt.", new DateTime(2023, 4, 25, 15, 3, 22, 576, DateTimeKind.Utc).AddTicks(3677) },
                    { 145L, 184L, "Nobis quod autem.\nCumque dignissimos rerum eos voluptatum natus est voluptatum.\nDucimus consequatur rerum aperiam.\nAut dolores excepturi consequatur.\nQui officia cumque tempore delectus mollitia eum et tempore eum.\nSimilique expedita distinctio.", new DateTime(2023, 8, 18, 17, 59, 49, 220, DateTimeKind.Utc).AddTicks(4973), 37L, "accusamus", new DateTime(2023, 9, 18, 9, 39, 12, 292, DateTimeKind.Utc).AddTicks(1828) },
                    { 146L, 137L, "In perspiciatis explicabo et fuga.", new DateTime(2023, 8, 18, 17, 56, 57, 459, DateTimeKind.Utc).AddTicks(3318), 6L, "Quas ipsam quo et sunt repellat est et perspiciatis.\nVoluptatem aspernatur sunt.\nAut voluptatem quis.\nQuia adipisci voluptatem ipsa corrupti voluptates ducimus quaerat corporis.", new DateTime(2023, 9, 14, 4, 33, 8, 816, DateTimeKind.Utc).AddTicks(6457) },
                    { 147L, 7L, "unde", new DateTime(2020, 6, 24, 19, 9, 56, 927, DateTimeKind.Utc).AddTicks(4851), 26L, "Deserunt vitae officiis dolores veritatis molestiae autem tempore dolor.\nNostrum nam earum ratione.\nCommodi quia nobis laudantium eum non et fugiat optio.", new DateTime(2021, 7, 19, 14, 10, 59, 440, DateTimeKind.Utc).AddTicks(2633) },
                    { 148L, 17L, "Et sit eligendi dolor qui inventore sunt. Eligendi ut enim. Aut laudantium non. Alias adipisci eum. Sunt nihil necessitatibus reiciendis magnam quia quos aut perspiciatis.", new DateTime(2023, 9, 22, 7, 3, 33, 960, DateTimeKind.Utc).AddTicks(332), 15L, "Labore optio minus aperiam laborum qui reiciendis repudiandae ut deserunt.", new DateTime(2023, 9, 22, 8, 40, 17, 162, DateTimeKind.Utc).AddTicks(1065) },
                    { 149L, 35L, "Consequatur voluptas error.\nSoluta totam sed.", new DateTime(2022, 6, 18, 20, 40, 45, 339, DateTimeKind.Utc).AddTicks(5403), 13L, "Provident ad similique vitae sunt incidunt voluptatem aperiam.", new DateTime(2022, 11, 11, 3, 8, 31, 916, DateTimeKind.Utc).AddTicks(5535) },
                    { 150L, 61L, "veniam", new DateTime(2023, 6, 9, 7, 43, 59, 271, DateTimeKind.Utc).AddTicks(2190), 13L, "Nostrum velit harum iusto quos enim rerum quia.\nAliquid consequuntur sit voluptatem.\nQuia id ducimus quidem optio excepturi dolor ut quis.", new DateTime(2023, 8, 27, 9, 33, 15, 737, DateTimeKind.Utc).AddTicks(232) },
                    { 151L, 59L, "Unde velit qui repudiandae et. Aspernatur dolor quaerat. Qui aspernatur ut et. Perferendis mollitia qui dolorem in.", new DateTime(2022, 4, 11, 11, 46, 28, 650, DateTimeKind.Utc).AddTicks(1896), 28L, "A iure dolorem voluptatem earum dicta natus architecto consequatur.\nQuasi culpa id sed sint recusandae et ut at.\nIpsam eum aut in voluptate adipisci.\nSequi nam voluptatibus minus quidem soluta.\nAssumenda non esse assumenda nesciunt optio optio quia.\nEnim ut voluptas.", new DateTime(2022, 7, 31, 17, 20, 25, 625, DateTimeKind.Utc).AddTicks(1243) },
                    { 152L, 50L, "temporibus", new DateTime(2023, 2, 26, 14, 37, 42, 332, DateTimeKind.Utc).AddTicks(7343), 17L, "In culpa nihil voluptates maxime eligendi.", new DateTime(2023, 3, 18, 14, 0, 40, 209, DateTimeKind.Utc).AddTicks(1482) },
                    { 153L, 17L, "Iure sint rerum consectetur nesciunt quod adipisci ex sed. Beatae et repudiandae rem blanditiis consequatur quas. Aliquam numquam consectetur rerum doloribus vero velit consequatur exercitationem. Facilis quia laudantium et maxime impedit nostrum eligendi. Aperiam harum soluta dolore modi. Molestiae fugiat dolore.", new DateTime(2023, 9, 22, 9, 26, 45, 434, DateTimeKind.Utc).AddTicks(9), 1L, "In deserunt deserunt rerum minus in dignissimos cupiditate doloremque dolor. Ducimus atque quo commodi. Est facere sed. Omnis cupiditate totam non. Ut ut et et accusantium neque tempora. Possimus et culpa officiis temporibus.", new DateTime(2023, 9, 22, 9, 49, 43, 204, DateTimeKind.Utc).AddTicks(5313) },
                    { 154L, 66L, "Ut omnis molestias soluta necessitatibus sit.", new DateTime(2023, 5, 13, 4, 24, 45, 259, DateTimeKind.Utc).AddTicks(1073), 25L, "Facere consectetur ab quia eum et voluptas.", new DateTime(2023, 5, 13, 13, 52, 23, 328, DateTimeKind.Utc).AddTicks(1869) },
                    { 155L, 39L, "Facilis dolor neque eos quod quasi sit deserunt. Numquam qui laboriosam quia praesentium. Dolor voluptas libero et.", new DateTime(2023, 5, 13, 13, 20, 2, 428, DateTimeKind.Utc).AddTicks(9569), 6L, "Praesentium quos quisquam.\nNon enim impedit aliquam.\nIste ratione aperiam et eveniet qui quia facere.\nNihil mollitia repellendus voluptates expedita qui iste.", new DateTime(2023, 6, 3, 17, 2, 39, 663, DateTimeKind.Utc).AddTicks(2904) },
                    { 156L, 193L, "Nesciunt et quia libero eos quos.", new DateTime(2023, 7, 14, 10, 30, 4, 883, DateTimeKind.Utc).AddTicks(7618), 34L, "Aut sunt ipsum adipisci ipsum mollitia voluptas qui occaecati repudiandae.\nAmet ut incidunt unde.", new DateTime(2023, 8, 10, 10, 27, 23, 879, DateTimeKind.Utc).AddTicks(1840) },
                    { 157L, 19L, "Est quis libero.", new DateTime(2022, 12, 12, 5, 38, 35, 695, DateTimeKind.Utc).AddTicks(9210), 33L, "Inventore sit quaerat sapiente ea porro est. Atque sed eum unde maiores. Rerum aperiam quia nostrum consectetur qui omnis fugiat ratione.", new DateTime(2023, 4, 19, 19, 45, 29, 945, DateTimeKind.Utc).AddTicks(8418) },
                    { 158L, 51L, "Exercitationem ea possimus reprehenderit laboriosam et amet. Aliquam blanditiis non aliquid praesentium nemo quo perferendis animi. Expedita dolorem vel nobis voluptas autem. Aperiam praesentium consequatur iure. Vero qui id aut dicta. Tempora iusto corporis eum.", new DateTime(2023, 5, 28, 21, 51, 36, 142, DateTimeKind.Utc).AddTicks(3295), 16L, "Itaque error deleniti est quos voluptatem consequatur at praesentium incidunt. Qui laborum sint sapiente dolorem corporis adipisci vel. Doloribus mollitia omnis placeat ducimus modi. Repellendus neque sequi enim incidunt accusamus maxime ut. Maxime ut delectus quos.", new DateTime(2023, 6, 23, 19, 36, 54, 376, DateTimeKind.Utc).AddTicks(52) },
                    { 159L, 51L, "Ut enim repellat amet iste fugit hic nisi. Minus et enim tempore modi est nemo a corrupti. Et laborum minus nihil tenetur. Rerum perferendis culpa velit.", new DateTime(2023, 8, 24, 11, 7, 50, 247, DateTimeKind.Utc).AddTicks(9819), 13L, "Placeat aut sint saepe sequi vitae tempore.\nQuibusdam natus nihil aut odit eligendi qui nesciunt quisquam.\nVoluptatem qui deserunt.\nInventore sed nulla ipsa a tempore aut.\nQui ut accusamus nam cupiditate.\nNihil quibusdam sequi officiis illum occaecati quasi illo.", null },
                    { 160L, 45L, "Enim laudantium maiores. Repudiandae voluptatibus quae aut. Alias et molestiae. Nesciunt eos dignissimos dolorem quia qui. Itaque reprehenderit culpa architecto ut consequatur tempora et adipisci nihil. Dolore excepturi eaque asperiores voluptate soluta eum.", new DateTime(2022, 8, 8, 0, 57, 28, 240, DateTimeKind.Utc).AddTicks(7757), 36L, "Ipsa placeat illum et rerum quidem voluptatem minima. Consequatur rerum ea non dolorem aut. Voluptates animi et possimus et sint cumque qui voluptate sint. Neque minus voluptas repellendus suscipit minus. Eveniet rerum voluptas quia.", new DateTime(2022, 10, 9, 17, 44, 34, 462, DateTimeKind.Utc).AddTicks(8523) },
                    { 161L, 74L, "expedita", new DateTime(2023, 9, 9, 6, 15, 15, 944, DateTimeKind.Utc).AddTicks(3737), 31L, "Fugit occaecati assumenda repellendus debitis delectus magni consequuntur ab. Praesentium quisquam quaerat doloribus perspiciatis facilis. Laborum libero facere enim labore quia nihil. Ut soluta laudantium dolores facilis quod error suscipit. Ab non asperiores alias blanditiis assumenda quae.", new DateTime(2023, 9, 19, 3, 12, 14, 785, DateTimeKind.Utc).AddTicks(2727) },
                    { 162L, 193L, "dicta", new DateTime(2023, 5, 9, 21, 56, 17, 922, DateTimeKind.Utc).AddTicks(6364), 27L, "Quae quia dolorem mollitia officiis in.\nVitae laboriosam veniam.", new DateTime(2023, 8, 10, 1, 27, 36, 377, DateTimeKind.Utc).AddTicks(3968) },
                    { 163L, 128L, "Earum suscipit et qui sequi ut nihil et est.", new DateTime(2023, 9, 14, 6, 25, 26, 190, DateTimeKind.Utc).AddTicks(1549), 36L, "Et mollitia vero asperiores quia eligendi reprehenderit. Repudiandae quia vel non sint fugit atque. Omnis consectetur nam pariatur temporibus ex. Ad corrupti rerum necessitatibus. Quia explicabo modi dolorum aut. Voluptates est consequatur repellat tempora maiores molestias.", new DateTime(2023, 9, 18, 13, 19, 32, 985, DateTimeKind.Utc).AddTicks(4300) },
                    { 164L, 109L, "Quia est praesentium fugit odit id.\nQui qui quas.", new DateTime(2023, 9, 20, 5, 18, 45, 156, DateTimeKind.Utc).AddTicks(4567), 23L, "Sed iure illum tenetur consectetur illum commodi quia quibusdam.", new DateTime(2023, 9, 21, 18, 14, 15, 797, DateTimeKind.Utc).AddTicks(1227) },
                    { 165L, 193L, "Facere voluptas eius at at quibusdam. Voluptas molestias alias illum fugiat. Modi dolores itaque sit. Corrupti sit vel sit et ullam. Dolorum placeat rerum dolores iusto voluptas qui iste quasi.", new DateTime(2023, 4, 10, 20, 40, 49, 509, DateTimeKind.Utc).AddTicks(838), 10L, "Hic ut officia. Amet soluta illum unde autem natus. Veniam voluptatem dolores a molestiae. Similique quam eos et voluptatem incidunt. Molestiae enim architecto.", new DateTime(2023, 5, 8, 15, 45, 17, 829, DateTimeKind.Utc).AddTicks(4829) },
                    { 166L, 172L, "Sed eveniet sunt et. Dicta facere qui veritatis in distinctio rem itaque. Qui inventore et voluptate debitis voluptatem molestiae eaque ut. Repudiandae est in. Aut reprehenderit tenetur non sequi voluptatem voluptas. Non earum est est dolorem similique dolorem.", new DateTime(2023, 8, 24, 7, 25, 47, 850, DateTimeKind.Utc).AddTicks(9767), 6L, "Dolores et mollitia eius libero maiores debitis quisquam corporis.\nEx unde quo.\nMolestias sed aliquid.\nDignissimos magni voluptatem tempore delectus accusamus consequuntur iste.\nAut voluptatibus ea officiis necessitatibus aliquam fugit rem.", new DateTime(2023, 9, 14, 7, 45, 55, 20, DateTimeKind.Utc).AddTicks(5254) },
                    { 167L, 3L, "Voluptas ipsum vel incidunt qui ut delectus numquam dolores quia.\nDeleniti laudantium totam qui sunt fugit ut omnis.\nRerum sed totam nostrum mollitia sunt commodi dolore.\nTenetur rem atque rerum quo velit.", new DateTime(2023, 7, 11, 9, 10, 35, 615, DateTimeKind.Utc).AddTicks(2899), 28L, "Voluptates quo sit qui vel.\nDolorum quidem aut cum tempora autem id fuga.\nOptio perferendis natus cumque sunt quidem nesciunt ut porro.\nPerspiciatis id voluptatem mollitia placeat enim doloremque nisi.\nIusto itaque quisquam aut dolorem temporibus libero a natus.", new DateTime(2023, 8, 5, 18, 7, 27, 425, DateTimeKind.Utc).AddTicks(7937) },
                    { 168L, 19L, "Rerum repellat expedita est facere itaque corporis qui.\nEarum rem eaque quaerat ea adipisci qui vel amet.", new DateTime(2023, 7, 5, 5, 28, 53, 967, DateTimeKind.Utc).AddTicks(4484), 1L, "Minus repudiandae quam cum. Non eligendi architecto adipisci necessitatibus perspiciatis voluptate. Et aperiam nobis. Nobis repellat quam. Doloribus nulla velit et corporis veniam. Modi provident distinctio tempore numquam quos et vitae labore.", new DateTime(2023, 8, 22, 8, 5, 33, 397, DateTimeKind.Utc).AddTicks(9617) }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "Output", "SubmittedAt" },
                values: new object[,]
                {
                    { 169L, 69L, "Harum non omnis neque voluptas impedit quas itaque iste quibusdam.\nQuasi eius possimus exercitationem molestiae accusamus pariatur distinctio.", new DateTime(2023, 6, 27, 11, 10, 17, 579, DateTimeKind.Utc).AddTicks(7690), 8L, "officiis", new DateTime(2023, 9, 18, 8, 44, 14, 566, DateTimeKind.Utc).AddTicks(2468) },
                    { 170L, 20L, "non", new DateTime(2023, 7, 29, 14, 30, 19, 569, DateTimeKind.Utc).AddTicks(5085), 33L, "Sunt ut temporibus enim nostrum sunt molestias nam praesentium.", new DateTime(2023, 9, 3, 19, 22, 57, 959, DateTimeKind.Utc).AddTicks(6702) },
                    { 171L, 115L, "aut", new DateTime(2023, 5, 31, 5, 10, 53, 751, DateTimeKind.Utc).AddTicks(3570), 35L, "aliquam", new DateTime(2023, 7, 24, 5, 38, 45, 542, DateTimeKind.Utc).AddTicks(5459) },
                    { 172L, 173L, "Est illo non ipsam et aut. Quod impedit qui minima rerum laudantium sed quam. Iure quo quasi eos.", new DateTime(2023, 8, 7, 5, 31, 43, 296, DateTimeKind.Utc).AddTicks(3716), 31L, "Earum molestiae quo libero rem architecto et.\nDelectus eius pariatur dignissimos blanditiis.\nQui non amet et sint maiores.\nQui quasi temporibus distinctio vel sed dicta qui facere.\nEt dolor corrupti ut necessitatibus omnis corporis consectetur libero sunt.\nIpsam qui laborum.", new DateTime(2023, 8, 18, 14, 4, 54, 658, DateTimeKind.Utc).AddTicks(2786) },
                    { 173L, 51L, "Aut quibusdam non ea quae consequatur explicabo. Provident tempora non corporis rerum distinctio delectus. Aliquam et aut debitis.", new DateTime(2023, 5, 18, 1, 40, 18, 887, DateTimeKind.Utc).AddTicks(7814), 30L, "saepe", new DateTime(2023, 6, 9, 10, 41, 50, 463, DateTimeKind.Utc).AddTicks(330) },
                    { 174L, 13L, "Quo sint accusamus voluptas quis ut eligendi illo non.", new DateTime(2023, 8, 4, 21, 14, 31, 318, DateTimeKind.Utc).AddTicks(527), 35L, "Magni iste et.\nNihil libero aspernatur.\nNatus doloribus adipisci consequatur adipisci consequatur doloribus veritatis quibusdam perferendis.", new DateTime(2023, 9, 10, 7, 26, 17, 201, DateTimeKind.Utc).AddTicks(1595) },
                    { 175L, 2L, "Expedita omnis ad magni est cumque.\nDolor fugit suscipit itaque enim sint molestias.\nEsse tempora pariatur voluptatem eos est sint voluptates harum.", new DateTime(2023, 9, 14, 6, 43, 31, 650, DateTimeKind.Utc).AddTicks(3063), 39L, "Vero consectetur quam eum eos sunt omnis.", new DateTime(2023, 9, 20, 5, 13, 53, 222, DateTimeKind.Utc).AddTicks(2611) },
                    { 176L, 32L, "Nihil esse aliquam et quia corrupti.", new DateTime(2023, 7, 14, 10, 17, 30, 294, DateTimeKind.Utc).AddTicks(4339), 13L, "commodi", new DateTime(2023, 9, 11, 16, 21, 57, 544, DateTimeKind.Utc).AddTicks(9120) },
                    { 177L, 89L, "Id pariatur facilis officiis non voluptas reprehenderit commodi minus.", new DateTime(2022, 9, 2, 4, 57, 36, 967, DateTimeKind.Utc).AddTicks(5101), 10L, "Unde a dolores praesentium eligendi et qui qui odio.", new DateTime(2023, 3, 16, 22, 3, 26, 369, DateTimeKind.Utc).AddTicks(1817) },
                    { 178L, 10L, "Rerum sequi eos sit optio minima.", new DateTime(2023, 3, 8, 2, 51, 19, 990, DateTimeKind.Utc).AddTicks(1765), 20L, "enim", new DateTime(2023, 3, 18, 23, 58, 27, 821, DateTimeKind.Utc).AddTicks(1533) },
                    { 179L, 43L, "ab", new DateTime(2023, 2, 2, 7, 35, 5, 22, DateTimeKind.Utc).AddTicks(4690), 32L, "Itaque eos accusamus voluptas similique.\nVoluptatem similique ipsa culpa architecto deserunt dolores aut.", new DateTime(2023, 3, 22, 7, 16, 45, 82, DateTimeKind.Utc).AddTicks(8568) },
                    { 180L, 56L, "Enim consequatur modi ut.", new DateTime(2023, 3, 16, 7, 7, 43, 376, DateTimeKind.Utc).AddTicks(6049), 38L, "Dolorem velit sit qui beatae incidunt fugiat.\nEt ipsa officia qui facere.\nLabore error velit ut.", new DateTime(2023, 5, 13, 17, 55, 11, 730, DateTimeKind.Utc).AddTicks(4519) },
                    { 181L, 181L, "Consequuntur libero voluptas facilis officiis tenetur rem minus. Harum in non excepturi ut ut. Quisquam praesentium et qui cumque voluptatem doloremque. Voluptatem quasi libero quibusdam. Eos rerum suscipit dolores ea.", new DateTime(2023, 5, 29, 3, 0, 14, 245, DateTimeKind.Utc).AddTicks(7635), 39L, "dolorem", new DateTime(2023, 8, 10, 22, 42, 21, 798, DateTimeKind.Utc).AddTicks(3091) },
                    { 182L, 81L, "qui", new DateTime(2023, 5, 29, 0, 39, 14, 44, DateTimeKind.Utc).AddTicks(7501), 5L, "Iure ipsa sit facere officia.\nTempora et voluptatem.", new DateTime(2023, 8, 9, 4, 59, 44, 68, DateTimeKind.Utc).AddTicks(1972) },
                    { 183L, 42L, "Totam ut placeat veritatis et sequi quibusdam aut.", new DateTime(2023, 9, 19, 12, 41, 9, 85, DateTimeKind.Utc).AddTicks(1776), 35L, "Maiores illo soluta exercitationem nihil.\nFacere soluta et.\nExcepturi ad illum aut sunt laboriosam alias.\nOfficiis commodi quis aliquid repellat omnis amet.\nAut quo ut et vitae adipisci pariatur omnis et.", new DateTime(2023, 9, 20, 3, 43, 55, 232, DateTimeKind.Utc).AddTicks(7760) },
                    { 184L, 193L, "Inventore a ut non tenetur eos vel quibusdam. Nobis autem sint harum illo magni odit. Voluptatibus repudiandae ducimus eum non ipsam nihil.", new DateTime(2023, 3, 22, 12, 0, 33, 740, DateTimeKind.Utc).AddTicks(5704), 29L, "accusamus", new DateTime(2023, 5, 20, 6, 1, 43, 61, DateTimeKind.Utc).AddTicks(2186) },
                    { 185L, 55L, "Eligendi earum mollitia et non.", new DateTime(2023, 6, 16, 1, 56, 5, 642, DateTimeKind.Utc).AddTicks(1256), 17L, "reiciendis", new DateTime(2023, 8, 5, 8, 28, 32, 117, DateTimeKind.Utc).AddTicks(7473) },
                    { 186L, 74L, "Non nihil est sit a tempore enim non rerum. Necessitatibus dicta nesciunt illum id magnam vel aut nam. Fugit sed sit harum fugiat recusandae accusantium itaque perferendis aut. Sit quaerat saepe temporibus atque tempore at ut culpa nihil. Tenetur vitae ipsa veritatis qui id.", new DateTime(2023, 9, 17, 21, 28, 15, 12, DateTimeKind.Utc).AddTicks(6248), 5L, "Deserunt adipisci libero optio cum cupiditate perferendis sit. Est suscipit excepturi. Necessitatibus impedit dolorem voluptatem doloremque quia culpa a laboriosam. Sint nihil culpa.", new DateTime(2023, 9, 18, 10, 3, 28, 830, DateTimeKind.Utc).AddTicks(921) },
                    { 187L, 74L, "facere", new DateTime(2023, 9, 6, 7, 7, 4, 805, DateTimeKind.Utc).AddTicks(5419), 40L, "ex", new DateTime(2023, 9, 8, 2, 30, 50, 498, DateTimeKind.Utc).AddTicks(1047) },
                    { 188L, 20L, "Recusandae sunt eveniet sed adipisci sit ut.\nIn quisquam nobis quod aliquam odit sequi.\nExplicabo quam quam velit et tempora labore omnis qui provident.\nUt et sint neque et quis dolorem sequi.\nConsequatur laudantium voluptates quaerat sed iste.", new DateTime(2023, 8, 27, 20, 1, 16, 405, DateTimeKind.Utc).AddTicks(1262), 21L, "Commodi aut debitis. Quia sit ut ut quaerat laborum. Pariatur dolores iure distinctio laborum repellat quos distinctio. Voluptas blanditiis molestiae tenetur est sit harum.", new DateTime(2023, 9, 5, 19, 29, 5, 804, DateTimeKind.Utc).AddTicks(8016) },
                    { 189L, 83L, "Molestiae voluptas quibusdam eos ut. Nobis accusantium numquam dignissimos in tempore architecto. Est sed et amet. Corporis et tempore et quo voluptatem eum accusantium architecto. Quaerat voluptas maiores odio voluptatem ut.", new DateTime(2023, 9, 16, 1, 23, 15, 990, DateTimeKind.Utc).AddTicks(8208), 25L, "Possimus itaque beatae et numquam excepturi ratione excepturi. Ut excepturi laboriosam veniam consectetur quae reprehenderit. Facere sint dicta voluptas sint deserunt.", new DateTime(2023, 9, 16, 19, 26, 25, 781, DateTimeKind.Utc).AddTicks(1788) },
                    { 190L, 54L, "illo", new DateTime(2023, 5, 8, 20, 41, 22, 59, DateTimeKind.Utc).AddTicks(6282), 14L, "debitis", new DateTime(2023, 9, 5, 23, 52, 31, 478, DateTimeKind.Utc).AddTicks(690) },
                    { 191L, 167L, "Velit error excepturi dolorem omnis natus.", new DateTime(2023, 6, 2, 22, 43, 33, 552, DateTimeKind.Utc).AddTicks(5495), 6L, "reiciendis", new DateTime(2023, 8, 4, 13, 24, 20, 504, DateTimeKind.Utc).AddTicks(6905) },
                    { 192L, 4L, "Labore nisi totam temporibus voluptatem reprehenderit iste minima quas. Harum alias nulla voluptas dolorem. Maiores exercitationem quas occaecati.", new DateTime(2023, 8, 28, 16, 12, 31, 542, DateTimeKind.Utc).AddTicks(2303), 22L, "Fugiat ab mollitia aut voluptatibus et amet quos.", new DateTime(2023, 9, 13, 17, 40, 54, 868, DateTimeKind.Utc).AddTicks(4733) },
                    { 193L, 38L, "Adipisci sit aut incidunt quia quas molestiae quae.\nQuis est debitis in.\nNisi deserunt praesentium omnis.\nEsse adipisci nostrum velit ut explicabo aut.\nId dolor velit in harum velit ullam aut.", new DateTime(2023, 8, 25, 12, 43, 13, 620, DateTimeKind.Utc).AddTicks(4936), 36L, "Explicabo commodi voluptas consequuntur omnis nulla est.", new DateTime(2023, 9, 4, 5, 51, 16, 691, DateTimeKind.Utc).AddTicks(9008) },
                    { 194L, 23L, "Accusantium nisi quos et est odit eos ipsam.\nVoluptatem voluptatem recusandae quibusdam eos totam minima vitae vero.", new DateTime(2023, 5, 20, 15, 29, 53, 868, DateTimeKind.Utc).AddTicks(2717), 8L, "consequatur", new DateTime(2023, 8, 8, 20, 8, 45, 515, DateTimeKind.Utc).AddTicks(5033) },
                    { 195L, 28L, "Explicabo autem et voluptatem perferendis itaque est quasi aut. Debitis ea tenetur ab. Aut quis repudiandae vel quod voluptas quidem.", new DateTime(2022, 8, 19, 13, 10, 3, 402, DateTimeKind.Utc).AddTicks(815), 15L, "Unde illum qui nulla illo pariatur praesentium aut dicta.", new DateTime(2023, 1, 26, 9, 3, 13, 447, DateTimeKind.Utc).AddTicks(1226) },
                    { 196L, 50L, "In voluptatum rerum reiciendis cum velit dolores. Atque ex provident maiores minima rerum blanditiis aut. Id adipisci atque. Sit tenetur quod architecto voluptatem animi dolorem eos ea. Asperiores tenetur non dignissimos. Vel pariatur officiis voluptate.", new DateTime(2023, 7, 5, 20, 46, 41, 714, DateTimeKind.Utc).AddTicks(7556), 33L, "Similique dolores molestiae illum.", new DateTime(2023, 7, 29, 7, 14, 39, 700, DateTimeKind.Utc).AddTicks(6666) },
                    { 197L, 55L, "Assumenda vel occaecati ratione et.\nConsequatur enim et vitae sit.\nAperiam et quas nostrum qui et minus.\nDolorem iste ducimus praesentium vel aliquam molestias adipisci inventore.\nAspernatur nam enim culpa odio veritatis facilis ut earum.", new DateTime(2023, 7, 13, 10, 23, 51, 556, DateTimeKind.Utc).AddTicks(456), 26L, "Impedit corrupti enim.\nRepellendus quod ut voluptatum similique veritatis.\nItaque quia numquam recusandae veritatis sit et pariatur laborum.\nDistinctio maiores occaecati enim qui.", new DateTime(2023, 8, 17, 14, 49, 3, 973, DateTimeKind.Utc).AddTicks(1159) },
                    { 198L, 19L, "amet", new DateTime(2023, 4, 9, 15, 47, 9, 317, DateTimeKind.Utc).AddTicks(4573), 39L, "nulla", new DateTime(2023, 6, 26, 9, 13, 16, 671, DateTimeKind.Utc).AddTicks(5619) },
                    { 199L, 105L, "Enim aperiam rerum sit autem tempora consequuntur.", new DateTime(2023, 1, 31, 2, 28, 53, 999, DateTimeKind.Utc).AddTicks(3167), 34L, "Libero maiores possimus ab quas.\nFugit sit fugit praesentium dolorem architecto omnis error facere.\nConsequatur aut repudiandae.\nSit vitae quia libero iure hic harum itaque beatae in.\nEt deserunt perferendis unde sed.\nQuibusdam blanditiis ex enim dolores est.", new DateTime(2023, 4, 4, 22, 58, 12, 984, DateTimeKind.Utc).AddTicks(3073) },
                    { 200L, 150L, "Sequi libero alias odit officia distinctio dicta distinctio omnis.\nDolor aliquam porro qui.\nDeleniti placeat perferendis omnis rerum sunt sint iste deserunt.", new DateTime(2021, 8, 26, 3, 26, 40, 973, DateTimeKind.Utc).AddTicks(1791), 20L, "et", new DateTime(2023, 1, 22, 0, 22, 59, 100, DateTimeKind.Utc).AddTicks(911) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Challenges_CreatedBy",
                table: "Challenges",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Challenges_LevelId",
                table: "Challenges",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_ChallengeStars_AuthorId",
                table: "ChallengeStars",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_ChallengeStars_ChallengeId",
                table: "ChallengeStars",
                column: "ChallengeId");

            migrationBuilder.CreateIndex(
                name: "IX_ChallengeTags_TagId",
                table: "ChallengeTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_ChallengeVersionLanguageVersion_LanguageVersionId",
                table: "ChallengeVersionLanguageVersion",
                column: "LanguageVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_ChallengeVersions_ChallengeId",
                table: "ChallengeVersions",
                column: "ChallengeId");

            migrationBuilder.CreateIndex(
                name: "IX_ChallengeVersions_CreatedBy",
                table: "ChallengeVersions",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ChallengeVersions_LanguageId",
                table: "ChallengeVersions",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageVersions_LanguageId",
                table: "LanguageVersions",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_TypeId",
                table: "Subscriptions",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_UserId",
                table: "Subscriptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_CreatedBy",
                table: "Tests",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserBadges_BadgeId",
                table: "UserBadges",
                column: "BadgeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBadges_UserId",
                table: "UserBadges",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLanguageLevels_LanguageId",
                table: "UserLanguageLevels",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPreferredLanguage_UserId",
                table: "UserPreferredLanguage",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserSolutions_ChallengeVersionId",
                table: "UserSolutions",
                column: "ChallengeVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSolutions_CreatedBy",
                table: "UserSolutions",
                column: "CreatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChallengeStars");

            migrationBuilder.DropTable(
                name: "ChallengeTags");

            migrationBuilder.DropTable(
                name: "ChallengeVersionLanguageVersion");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "UserBadges");

            migrationBuilder.DropTable(
                name: "UserLanguageLevels");

            migrationBuilder.DropTable(
                name: "UserPreferredLanguage");

            migrationBuilder.DropTable(
                name: "UserSolutions");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "LanguageVersions");

            migrationBuilder.DropTable(
                name: "SubscriptionTypes");

            migrationBuilder.DropTable(
                name: "Badges");

            migrationBuilder.DropTable(
                name: "ChallengeVersions");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Challenges");

            migrationBuilder.DropTable(
                name: "ChallengeLevels");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
