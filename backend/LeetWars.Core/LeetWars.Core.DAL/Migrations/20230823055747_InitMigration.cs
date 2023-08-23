using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeetWars.Core.DAL.Migrations
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChallengeLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Reward = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChallengeLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BillingPeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<int>(type: "int", nullable: false),
                    Timezone = table.Column<int>(type: "int", nullable: false),
                    Sex = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: false),
                    TotalScore = table.Column<long>(type: "bigint", nullable: false),
                    RegisteredAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OAuthToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    Version = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageVersions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LanguageVersions_Languages_LanguageId",
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
                    AuthorId = table.Column<long>(type: "bigint", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Instructions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LevelId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Challenges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Challenges_ChallengeLevels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "ChallengeLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Challenges_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreferredLanguages",
                columns: table => new
                {
                    PreferredLanguagesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreferredLanguages", x => new { x.PreferredLanguagesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_PreferredLanguages_Languages_PreferredLanguagesId",
                        column: x => x.PreferredLanguagesId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreferredLanguages_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    PaymentSubscriptionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Subscriptions_SubscriptionTypes_TypeId",
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
                name: "UserLanguageLevels",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLanguageLevels", x => new { x.UserId, x.LanguageId });
                    table.ForeignKey(
                        name: "FK_UserLanguageLevels_Languages_LanguageId",
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
                name: "ChallengeTag",
                columns: table => new
                {
                    ChallengesId = table.Column<long>(type: "bigint", nullable: false),
                    TagsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChallengeTag", x => new { x.ChallengesId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_ChallengeTag_Challenges_ChallengesId",
                        column: x => x.ChallengesId,
                        principalTable: "Challenges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChallengeTag_Tags_TagsId",
                        column: x => x.TagsId,
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
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    ChallengeId = table.Column<long>(type: "bigint", nullable: false),
                    InitialSolution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompleteSolution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChallengeVersions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChallengeVersions_Challenges_ChallengeId",
                        column: x => x.ChallengeId,
                        principalTable: "Challenges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChallengeVersions_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChallengeVersionLanguageVersion",
                columns: table => new
                {
                    ChallengeVersionId = table.Column<long>(type: "bigint", nullable: false),
                    LanguageVersionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChallengeVersionLanguageVersion", x => new { x.ChallengeVersionId, x.LanguageVersionId });
                    table.ForeignKey(
                        name: "FK_ChallengeVersionLanguageVersion_ChallengeVersions_ChallengeVersionId",
                        column: x => x.ChallengeVersionId,
                        principalTable: "ChallengeVersions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChallengeVersionLanguageVersion_LanguageVersions_LanguageVersionId",
                        column: x => x.LanguageVersionId,
                        principalTable: "LanguageVersions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tests_ChallengeVersions_ChallengeVersionId",
                        column: x => x.ChallengeVersionId,
                        principalTable: "ChallengeVersions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSolutions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    ChallengeVersionId = table.Column<long>(type: "bigint", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Output = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubmittedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                        name: "FK_UserSolutions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ChallengeLevels",
                columns: new[] { "Id", "Name", "Reward" },
                values: new object[,]
                {
                    { 1, "Easy", 10 },
                    { 2, "Medium", 20 },
                    { 3, "Difficult", 30 },
                    { 4, "Extreme", 40 }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "C#" },
                    { 2, "Typescript" },
                    { 3, "Python" },
                    { 4, "Javascript" }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionTypes",
                columns: new[] { "Id", "BillingPeriod", "Cost", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 0, 136.02m, "Vel necessitatibus est tenetur id id atque sunt ut.", "Cambridgeshire " },
                    { 2, 1, 151.37m, "Explicabo debitis quia.", "Canyon ADP scal" },
                    { 3, 0, 91.86m, "Beatae aut est reprehenderit eos nihil perspiciatis enim.", "Qatar complexit" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Arrays" },
                    { 2, "Algorithms" },
                    { 3, "Backend" },
                    { 4, "Async" },
                    { 5, "AI" },
                    { 6, "Concurrency" },
                    { 7, "Filtering" },
                    { 8, "Fundamentals" },
                    { 9, "Heaps" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Country", "Email", "FirstName", "ImagePath", "IsBanned", "IsSubscribed", "LastName", "OAuthToken", "RegisteredAt", "Sex", "Status", "Timezone", "TotalScore", "UserName" },
                values: new object[,]
                {
                    { 1L, new DateTime(1993, 2, 24, 9, 18, 32, 656, DateTimeKind.Unspecified).AddTicks(2617), 26, "Josue41@hotmail.com", "Grayson", "/wymtrpbcdupodqfwhkxtmnyngfjrqv.jpg", false, true, "Tremblay", "j5xii6spbrvfvasc6b42i4qkxc0xih8e", new DateTime(2016, 9, 22, 8, 24, 51, 823, DateTimeKind.Unspecified).AddTicks(2598), 1, 0, -1, 60915L, "Emmalee_West0" },
                    { 2L, new DateTime(1988, 2, 12, 22, 44, 58, 841, DateTimeKind.Unspecified).AddTicks(3506), 25, "Mitchel4@yahoo.com", "Kristopher", "/ooilkjpddwfvomzpbjspeczybqrwsj.jpg", false, true, "Blanda", "7mg6vwys190zw8d8ke20ld5fvglddroq", new DateTime(2020, 11, 15, 6, 17, 59, 4, DateTimeKind.Unspecified).AddTicks(3136), 3, 2, 2, 34838L, "Blake631" },
                    { 3L, new DateTime(1991, 9, 27, 20, 32, 48, 50, DateTimeKind.Unspecified).AddTicks(2864), 7, "Kay29@hotmail.com", "Deja", "/uruwlaikhplhphodpuwfuzkjbswrhw.jpg", false, false, "Haley", "tjpdyqzs4d07s1t1uan24qztisafsq5n", new DateTime(2016, 12, 8, 9, 11, 23, 196, DateTimeKind.Unspecified).AddTicks(1114), 1, 3, 10, 23246L, "Jacquelyn182" },
                    { 4L, new DateTime(1993, 1, 5, 19, 57, 27, 174, DateTimeKind.Unspecified).AddTicks(9656), 28, "Kara_Ankunding3@yahoo.com", "Rachel", "/ftbpxwdlozkfjcjhymqzvyibmqypyw.jpg", false, true, "Pagac", "swlmxpoand6djta9thu2lj8l69e03awj", new DateTime(2020, 7, 12, 2, 0, 45, 940, DateTimeKind.Unspecified).AddTicks(6282), 2, 0, 0, 76727L, "Jayda.Doyle3" },
                    { 5L, new DateTime(1980, 9, 23, 6, 52, 56, 292, DateTimeKind.Unspecified).AddTicks(167), 22, "Orval.Erdman74@yahoo.com", "Loma", "/xhgrzkqhrfjmqxwpuqbifmzszvswxf.jpg", false, true, "Schultz", "vhfskfyumcicwffr5ljwzkq4jfaio5ps", new DateTime(2020, 11, 1, 1, 53, 45, 866, DateTimeKind.Unspecified).AddTicks(9480), 1, 1, 10, 82585L, "Deangelo.Sch4" },
                    { 6L, new DateTime(1981, 3, 5, 1, 59, 53, 769, DateTimeKind.Unspecified).AddTicks(7548), 23, "Damon33@gmail.com", "Vernice", "/zghthgddlemqszlbosihchaoaiswsg.jpg", false, true, "Armstrong", "gikge714qk6b6sj23v3hqhbu8p7rqzk9", new DateTime(2016, 3, 20, 16, 27, 23, 144, DateTimeKind.Unspecified).AddTicks(7409), 0, 2, 12, 28021L, "Merlin_Schul5" },
                    { 7L, new DateTime(1988, 10, 5, 3, 59, 54, 595, DateTimeKind.Unspecified).AddTicks(4360), 32, "Ursula_Ferry23@gmail.com", "Helene", "/nyetfrahktaxxzcpauiwmimoslqztu.jpg", false, true, "Abbott", "qqh5orrb2v8q09r7w35exfiwr7gm0s20", new DateTime(2022, 3, 7, 11, 12, 40, 265, DateTimeKind.Unspecified).AddTicks(4975), 2, 3, -6, 73975L, "Norwood.Buck6" },
                    { 8L, new DateTime(1985, 9, 28, 21, 8, 34, 884, DateTimeKind.Unspecified).AddTicks(7502), 3, "Jordyn_Lindgren@hotmail.com", "Maybell", "/iwigpkmhdhhvffkgmuduvpfrchbxfv.jpg", false, true, "Roberts", "h8j77ro0ucs1neglfjvyapdp0qmm5bcl", new DateTime(2020, 6, 5, 10, 57, 6, 121, DateTimeKind.Unspecified).AddTicks(5784), 1, 3, -12, 652L, "Henriette.Ni7" },
                    { 9L, new DateTime(1983, 10, 27, 19, 37, 38, 966, DateTimeKind.Unspecified).AddTicks(8052), 20, "Jaunita.Spencer@gmail.com", "Janie", "/gnuwvemdbwnafziplilofkvtpsguuk.jpg", false, true, "Wilkinson", "ogtjst16gthiilfsssm8s5eytvo094yp", new DateTime(2020, 4, 7, 1, 30, 0, 47, DateTimeKind.Unspecified).AddTicks(49), 2, 0, -11, 66960L, "Providenci_A8" },
                    { 10L, new DateTime(1987, 9, 8, 2, 6, 58, 381, DateTimeKind.Unspecified).AddTicks(1715), 40, "Patricia.Walker@yahoo.com", "Donald", "/oqnbwsydaxiwuewkjpdqcrngvxdzlr.jpg", false, false, "Torphy", "h6iks1o0by8djdjq9j0uz6st1v398ylx", new DateTime(2021, 7, 21, 11, 3, 24, 382, DateTimeKind.Unspecified).AddTicks(216), 1, 1, -9, 21532L, "Leanne_Bedna9" },
                    { 11L, new DateTime(1986, 10, 30, 13, 4, 23, 299, DateTimeKind.Unspecified).AddTicks(430), 57, "Asa_Nicolas@hotmail.com", "Eunice", "/priksnyykujihsezkjbefcqwqlhszo.jpg", false, true, "Greenholt", "5b0y2o3roofvbkxu20z6aqkfri1fr987", new DateTime(2022, 8, 7, 16, 20, 43, 867, DateTimeKind.Unspecified).AddTicks(9841), 3, 2, -11, 33445L, "Chandler.Hom10" },
                    { 12L, new DateTime(1990, 5, 6, 18, 6, 2, 959, DateTimeKind.Unspecified).AddTicks(5583), 50, "Verda.Schinner@gmail.com", "Madilyn", "/tugltpfoqrzklfxmywntjmhqafslsy.jpg", false, true, "Pollich", "gywyh6k7aq42u6naxifb52alw8hmejvr", new DateTime(2022, 11, 24, 15, 12, 31, 287, DateTimeKind.Unspecified).AddTicks(7619), 2, 0, -12, 50225L, "Gavin_Reinge11" },
                    { 13L, new DateTime(1990, 5, 3, 11, 10, 44, 617, DateTimeKind.Unspecified).AddTicks(9801), 37, "Willard18@gmail.com", "Mohamed", "/zkukribgryvtwjfdzqulusklmnzppj.jpg", false, true, "McClure", "nm9prgxtd6gh1ywtx83i5cyueazcw5bg", new DateTime(2017, 7, 15, 18, 16, 52, 164, DateTimeKind.Unspecified).AddTicks(1461), 1, 1, -8, 15042L, "Ole6512" },
                    { 14L, new DateTime(1993, 5, 20, 23, 4, 4, 892, DateTimeKind.Unspecified).AddTicks(7492), 48, "Jovany_Pacocha@yahoo.com", "Celestine", "/mbfhrkhmloxfwzwtqtiuqiizcjwcqo.jpg", true, true, "Gibson", "t8kkzk20i2u5bm92rzgxssct55q96bj7", new DateTime(2021, 1, 5, 17, 57, 6, 493, DateTimeKind.Unspecified).AddTicks(3702), 3, 2, 4, 28772L, "Leopold6513" },
                    { 15L, new DateTime(1989, 5, 9, 11, 50, 28, 465, DateTimeKind.Unspecified).AddTicks(1597), 40, "Maxwell_Bauch@hotmail.com", "Lonny", "/qstbwtlvvvvenqikwpkmzegeocxrdb.jpg", false, true, "Feeney", "k5qnk35pswu6gus1qa5mt3m4xggkhsur", new DateTime(2017, 10, 31, 11, 42, 57, 119, DateTimeKind.Unspecified).AddTicks(262), 3, 1, 5, 87680L, "Deonte.Waelc14" },
                    { 16L, new DateTime(1997, 11, 14, 20, 7, 26, 876, DateTimeKind.Unspecified).AddTicks(4806), 37, "Joanne_Hilll@yahoo.com", "Chloe", "/nglnpscrpfzbcnspdpwfyjqhcndtaf.jpg", false, true, "Schowalter", "zf785is5u5zjnytgi90u9wifk5m5f3kc", new DateTime(2021, 12, 3, 14, 14, 52, 251, DateTimeKind.Unspecified).AddTicks(5642), 1, 0, 2, 86138L, "Juanita_Mona15" },
                    { 17L, new DateTime(1993, 9, 6, 15, 13, 11, 647, DateTimeKind.Unspecified).AddTicks(3510), 34, "Jaylan88@yahoo.com", "Vince", "/teycxuraxqstoqygsgpqxvbhdvfely.jpg", true, true, "Russel", "os3plgg5o27c94814kghx80czw3ny3kh", new DateTime(2022, 2, 15, 5, 19, 21, 942, DateTimeKind.Unspecified).AddTicks(8184), 3, 3, 11, 86419L, "Maybell_DuBu16" },
                    { 18L, new DateTime(1993, 2, 5, 1, 11, 38, 546, DateTimeKind.Unspecified).AddTicks(688), 10, "Amber_Botsford72@hotmail.com", "Kendall", "/yalusssjufpnsuieijhnzrjrmxliep.jpg", false, true, "Marks", "vewqmyi5x5b40dz0qr8rqpe5q9mratae", new DateTime(2021, 1, 8, 13, 59, 44, 330, DateTimeKind.Unspecified).AddTicks(6056), 0, 1, -8, 98054L, "Kamille_Kirl17" },
                    { 19L, new DateTime(1992, 8, 30, 14, 11, 30, 71, DateTimeKind.Unspecified).AddTicks(9329), 40, "Jadon.Dibbert40@hotmail.com", "Carli", "/wdatzjitwcwyyvavktqwcpghyxppcv.jpg", false, false, "Koch", "mmbsb65vzr1waca9wtzu2f17aawqs3rp", new DateTime(2021, 2, 7, 12, 25, 34, 543, DateTimeKind.Unspecified).AddTicks(9389), 0, 1, -7, 17124L, "Breanne_Dool18" },
                    { 20L, new DateTime(1980, 3, 2, 13, 30, 17, 557, DateTimeKind.Unspecified).AddTicks(4008), 18, "Zion_Osinski62@hotmail.com", "Joyce", "/fueodmahlcwaifgxbrthdenrfjczzt.jpg", false, false, "Rowe", "43z3g99nhpij8fvuhz10y09hg18idrd1", new DateTime(2020, 9, 7, 20, 57, 44, 88, DateTimeKind.Unspecified).AddTicks(1001), 2, 3, 7, 24724L, "Rosalind2919" },
                    { 21L, new DateTime(1980, 10, 16, 19, 14, 19, 862, DateTimeKind.Unspecified).AddTicks(216), 52, "Rachelle.Hickle94@gmail.com", "Gordon", "/zudvnqlathsimfomcvggbkoufswcds.jpg", false, true, "Dietrich", "0w92cwtxhmbyu4hpaeelpjmvwk8bmtrc", new DateTime(2021, 1, 19, 0, 28, 9, 204, DateTimeKind.Unspecified).AddTicks(1987), 0, 1, 8, 40527L, "Alfred_Saway20" },
                    { 22L, new DateTime(1985, 1, 13, 10, 52, 46, 135, DateTimeKind.Unspecified).AddTicks(4769), 43, "Emmy.Lakin@yahoo.com", "Cayla", "/rozmgketrnirwzbuvrrxnuyneayuau.jpg", false, true, "Heaney", "04fbnc2sjm74y5uorx0slntixwlga9ge", new DateTime(2021, 5, 15, 2, 46, 49, 244, DateTimeKind.Unspecified).AddTicks(1069), 3, 2, -7, 53546L, "Liliane5521" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Country", "Email", "FirstName", "ImagePath", "IsBanned", "IsSubscribed", "LastName", "OAuthToken", "RegisteredAt", "Sex", "Status", "Timezone", "TotalScore", "UserName" },
                values: new object[,]
                {
                    { 23L, new DateTime(1985, 8, 1, 11, 42, 11, 968, DateTimeKind.Unspecified).AddTicks(9187), 38, "Marion1@hotmail.com", "Amber", "/tgfihyjttpnhevkcqqlgqhbootvocv.jpg", false, false, "Brown", "rr0gmho5wb5kz3jtwuzq4130eh6osi3t", new DateTime(2019, 3, 2, 16, 56, 43, 815, DateTimeKind.Unspecified).AddTicks(7244), 3, 3, 6, 71204L, "Andre_Pacoch22" },
                    { 24L, new DateTime(1981, 12, 15, 1, 48, 9, 700, DateTimeKind.Unspecified).AddTicks(1476), 8, "Aaliyah_Rempel56@hotmail.com", "Jazmyn", "/jrtrabdizjkfixbguoeqciqhzyieer.jpg", false, true, "Robel", "2n49a9328n2le4cwq59q76ocg10gp3pz", new DateTime(2017, 3, 21, 18, 12, 21, 972, DateTimeKind.Unspecified).AddTicks(6763), 1, 1, 6, 7810L, "Bobbie3023" },
                    { 25L, new DateTime(1985, 11, 24, 0, 20, 19, 826, DateTimeKind.Unspecified).AddTicks(4962), 4, "Tobin17@yahoo.com", "Mozelle", "/xlmxzuuggqieyblcvqvrompmwetzem.jpg", false, true, "Haag", "jnvj2oveqbadjje5li2tqa8jmgvz0t0t", new DateTime(2017, 9, 6, 11, 8, 30, 475, DateTimeKind.Unspecified).AddTicks(1125), 3, 0, 4, 38713L, "Juliet_McClu24" },
                    { 26L, new DateTime(1993, 11, 24, 21, 15, 2, 804, DateTimeKind.Unspecified).AddTicks(8752), 5, "Armand.Rempel@gmail.com", "Grayson", "/xitgliyqvwkyhlhulswfnhpiktelnv.jpg", false, true, "Torp", "wa9rxq0u8xgdxc0y6wv4ldvcqlqfto5h", new DateTime(2021, 12, 6, 22, 49, 9, 252, DateTimeKind.Unspecified).AddTicks(8260), 0, 3, -10, 54533L, "Jess9125" },
                    { 27L, new DateTime(1988, 10, 31, 8, 24, 19, 549, DateTimeKind.Unspecified).AddTicks(3428), 5, "Emilia.Kling@gmail.com", "Kristian", "/okfolxaizpaouzgxkxhqjijaxypofn.jpg", false, true, "Konopelski", "3d5wxosenri7j6jw5rwgue5wv726nhag", new DateTime(2016, 12, 2, 16, 43, 49, 623, DateTimeKind.Unspecified).AddTicks(8443), 1, 1, 4, 87203L, "Thad3726" },
                    { 28L, new DateTime(1980, 6, 15, 22, 55, 6, 657, DateTimeKind.Unspecified).AddTicks(6478), 43, "Javon_Ziemann68@gmail.com", "Wayne", "/uqsfgasqptelbcbswmhriiwdpuslxs.jpg", false, true, "Funk", "nofrburg6udyi72222qflij5dfrklgaa", new DateTime(2023, 3, 31, 5, 48, 8, 247, DateTimeKind.Unspecified).AddTicks(7528), 3, 0, 0, 30201L, "Kariane7927" },
                    { 29L, new DateTime(1999, 3, 13, 16, 23, 36, 572, DateTimeKind.Unspecified).AddTicks(126), 0, "Arely_Lehner68@hotmail.com", "Herta", "/lcddhkwcfwsocfpcobtgomefcvaqcm.jpg", false, false, "Gutkowski", "2rnlaszcqww3qklv858ligye5yxx1fd9", new DateTime(2016, 10, 24, 21, 45, 37, 601, DateTimeKind.Unspecified).AddTicks(8670), 2, 3, 12, 49377L, "Haylie_Hane28" },
                    { 30L, new DateTime(1990, 2, 22, 7, 30, 2, 825, DateTimeKind.Unspecified).AddTicks(3845), 6, "Linnie_Friesen@yahoo.com", "Dagmar", "/kmzpugliwbhinqcauqytflmhecbsfi.jpg", false, true, "Hahn", "astjvjq65n1mx2wzbpcqs0aumy0ogp7q", new DateTime(2018, 1, 22, 21, 30, 46, 286, DateTimeKind.Unspecified).AddTicks(7010), 2, 2, 0, 99608L, "Rosetta_Herm29" },
                    { 31L, new DateTime(1992, 7, 5, 16, 55, 47, 144, DateTimeKind.Unspecified).AddTicks(6842), 56, "Gayle.Cronin36@yahoo.com", "Lexi", "/mnhmzxxnbtllinkiknixumeoaeamoh.jpg", false, true, "Kohler", "axvdnzg0i3v17v0td324zngfl0crhtwf", new DateTime(2022, 8, 8, 7, 37, 43, 556, DateTimeKind.Unspecified).AddTicks(6844), 3, 1, 1, 95248L, "Earnestine.P30" },
                    { 32L, new DateTime(1989, 6, 11, 1, 21, 54, 551, DateTimeKind.Unspecified).AddTicks(7804), 26, "Clementina.Sanford45@yahoo.com", "Gerhard", "/iqmluqqrnremcllmflgrgpqfkvtbgh.jpg", true, true, "Adams", "1z0ift2568r6ub1jotv1ycnq7q080xvl", new DateTime(2019, 3, 23, 0, 26, 19, 31, DateTimeKind.Unspecified).AddTicks(7593), 1, 2, -8, 57424L, "Daryl.Bailey31" },
                    { 33L, new DateTime(1989, 6, 10, 17, 32, 33, 414, DateTimeKind.Unspecified).AddTicks(6334), 41, "Charlene93@gmail.com", "Anibal", "/efirihhruvdgietprwccugqxcqvdzr.jpg", false, true, "Gaylord", "26syf9xyu59btlx0orc5nbq25ykelph6", new DateTime(2021, 1, 29, 7, 23, 53, 341, DateTimeKind.Unspecified).AddTicks(9808), 0, 3, 12, 38702L, "Ahmad7432" },
                    { 34L, new DateTime(1985, 9, 18, 12, 7, 8, 669, DateTimeKind.Unspecified).AddTicks(692), 7, "Wilford.Bernier77@gmail.com", "Mellie", "/watlsvmrnjercqsvyohawmyiufrool.jpg", false, true, "Zemlak", "iqeeu30jqk9s5cu9rtp60ho1wd2emh4x", new DateTime(2022, 5, 13, 20, 11, 50, 246, DateTimeKind.Unspecified).AddTicks(2611), 0, 3, -2, 67055L, "Uriah.Sipes33" },
                    { 35L, new DateTime(1984, 8, 23, 0, 30, 52, 491, DateTimeKind.Unspecified).AddTicks(9846), 26, "Jerrold_Lehner@yahoo.com", "Heath", "/wjkabjnmapxglirbnkzcbcipryhvam.jpg", false, false, "Sporer", "w3092qnsdw6al8il9fe923jetr1td32n", new DateTime(2019, 1, 31, 0, 48, 33, 375, DateTimeKind.Unspecified).AddTicks(8317), 2, 2, 8, 18771L, "Merle3334" },
                    { 36L, new DateTime(1986, 1, 3, 18, 49, 34, 512, DateTimeKind.Unspecified).AddTicks(6), 7, "Alvera.Prosacco76@gmail.com", "Michaela", "/kvoplirwlgwnwboskbelwjalmcgysi.jpg", false, true, "Beatty", "e67o4v8lqx9jas8evgkenmp0w1s34d2r", new DateTime(2019, 5, 30, 11, 41, 16, 491, DateTimeKind.Unspecified).AddTicks(166), 0, 3, 4, 18001L, "Armando_Veum35" },
                    { 37L, new DateTime(1984, 4, 10, 16, 56, 4, 423, DateTimeKind.Unspecified).AddTicks(4479), 8, "Dangelo79@gmail.com", "Otha", "/jirtmfucbdmjvmleyodsoxywhlupyo.jpg", false, true, "Harris", "v15aesf362etlbayepvwbnyi8hdsg1e6", new DateTime(2021, 10, 18, 15, 56, 11, 470, DateTimeKind.Unspecified).AddTicks(5528), 2, 1, -2, 56163L, "Dena736" },
                    { 38L, new DateTime(1987, 7, 10, 12, 45, 18, 739, DateTimeKind.Unspecified).AddTicks(5295), 41, "Eva71@yahoo.com", "Reyes", "/bffcrbxlqqdrfrbbwtvpgdmhxfnesf.jpg", false, true, "Hudson", "40bg2b1bji66469d227lok7igxpy7gjq", new DateTime(2016, 3, 5, 4, 4, 26, 887, DateTimeKind.Unspecified).AddTicks(9033), 1, 2, -9, 76635L, "Amie.Greenfe37" },
                    { 39L, new DateTime(1996, 9, 28, 0, 46, 10, 761, DateTimeKind.Unspecified).AddTicks(2751), 12, "Adan44@gmail.com", "Kendrick", "/zdoovuadpccczmmsrdahlmodjwckyk.jpg", false, false, "Emmerich", "ypa2rkuzbkrg5yg4bxlamvhuzhkf6xpm", new DateTime(2022, 8, 15, 6, 42, 52, 357, DateTimeKind.Unspecified).AddTicks(7110), 0, 0, -2, 91228L, "Enid038" },
                    { 40L, new DateTime(1986, 5, 3, 0, 9, 9, 628, DateTimeKind.Unspecified).AddTicks(9643), 4, "Dejuan78@hotmail.com", "Mathilde", "/qubflcgalujwdgyvbikgskybaizeyt.jpg", false, true, "Shields", "xejtjf26ctgvfvgmeqetmx4x38t17433", new DateTime(2021, 10, 14, 2, 55, 33, 443, DateTimeKind.Unspecified).AddTicks(535), 2, 3, 12, 31229L, "Jaqueline.Le39" }
                });

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "Instructions", "LevelId", "Title" },
                values: new object[,]
                {
                    { 1L, 19L, new DateTime(2022, 1, 20, 16, 53, 12, 525, DateTimeKind.Unspecified).AddTicks(5004), "Perspiciatis cum et et laudantium.", 1, "We need to input the online SCSI firewall!" },
                    { 2L, 17L, new DateTime(2022, 7, 21, 8, 16, 37, 872, DateTimeKind.Unspecified).AddTicks(2368), "quis", 2, "Use the open-source SMS driver, then you can input" },
                    { 3L, 34L, new DateTime(2023, 1, 23, 11, 3, 28, 61, DateTimeKind.Unspecified).AddTicks(9661), "Aut rerum consectetur veniam distinctio officiis praesentium.\nAperiam quis qui animi omnis.\nMolestiae laboriosam exercitationem similique amet dolores quibusdam aspernatur consequatur quia.\nSuscipit consequuntur eos laborum facilis culpa.", 1, "If we back up the application, we can get to the G" },
                    { 4L, 20L, new DateTime(2021, 12, 31, 3, 50, 56, 883, DateTimeKind.Unspecified).AddTicks(339), "Suscipit quia modi nobis ad eos voluptatum est.", 2, "Use the haptic JBOD transmitter, then you can hack" },
                    { 5L, 33L, new DateTime(2022, 12, 19, 2, 11, 1, 396, DateTimeKind.Unspecified).AddTicks(1189), "Voluptatem possimus iure impedit enim provident incidunt molestiae earum.", 2, "I'll transmit the wireless USB driver, that should" },
                    { 6L, 28L, new DateTime(2023, 8, 15, 12, 26, 35, 895, DateTimeKind.Unspecified).AddTicks(7936), "Distinctio rerum voluptatem aut iure nesciunt aut eos voluptatem molestias. Molestias reprehenderit tenetur hic. Esse repudiandae voluptatem quae impedit sed voluptates ratione minus in.", 3, "If we parse the feed, we can get to the SSL feed t" },
                    { 7L, 40L, new DateTime(2022, 6, 26, 0, 29, 34, 401, DateTimeKind.Unspecified).AddTicks(9141), "Molestiae quis nihil similique autem nemo numquam. Et ut ratione vel. Aperiam harum perferendis ad consequuntur.", 1, "We need to calculate the auxiliary HTTP applicatio" },
                    { 8L, 26L, new DateTime(2022, 1, 25, 5, 9, 24, 679, DateTimeKind.Unspecified).AddTicks(3540), "et", 2, "I'll index the back-end RSS driver, that should dr" },
                    { 9L, 3L, new DateTime(2019, 4, 26, 11, 53, 12, 29, DateTimeKind.Unspecified).AddTicks(7100), "Quas maxime esse et dolores accusamus doloremque in magnam quos.\nSaepe incidunt modi recusandae saepe ut et.\nAccusamus sed maiores doloremque aut et aut praesentium quae.\nQui magni eum autem architecto accusamus dolore inventore expedita.\nEos velit optio asperiores dolores voluptas amet voluptatum deserunt.", 4, "The SAS pixel is down, hack the mobile pixel so we" },
                    { 10L, 6L, new DateTime(2017, 5, 27, 6, 46, 14, 197, DateTimeKind.Unspecified).AddTicks(7562), "Doloremque velit maiores unde at commodi.", 3, "You can't synthesize the firewall without transmit" },
                    { 11L, 40L, new DateTime(2021, 11, 9, 15, 19, 35, 842, DateTimeKind.Unspecified).AddTicks(7859), "Doloribus eveniet non aut fuga et.", 4, "Try to calculate the SMTP bus, maybe it will calcu" },
                    { 12L, 40L, new DateTime(2023, 4, 20, 19, 6, 11, 128, DateTimeKind.Unspecified).AddTicks(7220), "Est molestiae voluptatem eos assumenda et libero voluptatem et.\nAb maxime fuga nemo ad.\nNon illum ut iste ea perspiciatis.", 3, "The ADP array is down, generate the bluetooth arra" },
                    { 13L, 5L, new DateTime(2020, 12, 2, 14, 31, 49, 184, DateTimeKind.Unspecified).AddTicks(1630), "iure", 4, "The SMS driver is down, hack the optical driver so" },
                    { 14L, 30L, new DateTime(2021, 12, 26, 8, 29, 19, 776, DateTimeKind.Unspecified).AddTicks(8264), "Nostrum sit quia consequatur eos dolorem quo vel libero ut.\nIusto error quia ab.\nAutem quam et quia eum ea molestias eum dolore consequuntur.\nEligendi rerum nisi aspernatur et commodi libero cupiditate.\nMollitia molestias eaque quia dignissimos voluptas porro voluptas.", 3, "Try to copy the IB program, maybe it will copy the" },
                    { 15L, 5L, new DateTime(2021, 4, 3, 19, 31, 51, 877, DateTimeKind.Unspecified).AddTicks(9613), "Recusandae molestias id.", 3, "Use the wireless SDD circuit, then you can navigat" },
                    { 16L, 13L, new DateTime(2020, 1, 10, 13, 1, 56, 699, DateTimeKind.Unspecified).AddTicks(6480), "Corporis veniam vel et voluptas. Rerum quod facilis est nihil qui et rerum et non. Rerum culpa deserunt adipisci vero iure corporis. Quam odit reprehenderit. Atque cupiditate aut minus minus reprehenderit eos. Ipsam et aut nostrum assumenda explicabo rem.", 1, "If we bypass the port, we can get to the USB port " },
                    { 17L, 18L, new DateTime(2021, 3, 25, 8, 12, 25, 197, DateTimeKind.Unspecified).AddTicks(2214), "ratione", 4, "calculating the panel won't do anything, we need t" },
                    { 18L, 17L, new DateTime(2022, 12, 20, 3, 45, 16, 910, DateTimeKind.Unspecified).AddTicks(8324), "et", 4, "If we hack the program, we can get to the PCI prog" },
                    { 19L, 20L, new DateTime(2022, 6, 2, 4, 56, 32, 500, DateTimeKind.Unspecified).AddTicks(9803), "Sint doloribus sit aut ipsam maiores voluptatum voluptas in.", 3, "compressing the sensor won't do anything, we need " },
                    { 20L, 38L, new DateTime(2021, 5, 14, 11, 42, 10, 4, DateTimeKind.Unspecified).AddTicks(8867), "perspiciatis", 2, "I'll override the redundant AGP card, that should " },
                    { 21L, 23L, new DateTime(2021, 9, 25, 22, 13, 49, 987, DateTimeKind.Unspecified).AddTicks(5622), "Quisquam cum aut sunt sit suscipit similique voluptatem maxime qui. Quia aut exercitationem est provident enim rerum maiores. Voluptatem aut fugiat sunt exercitationem. Corrupti vitae ea eos enim similique. Fuga et enim ad laboriosam quaerat ut et. Et sed dolorum sunt quisquam incidunt et explicabo et.", 4, "Use the open-source EXE array, then you can connec" },
                    { 22L, 2L, new DateTime(2023, 4, 15, 14, 16, 9, 147, DateTimeKind.Unspecified).AddTicks(7968), "Id consequuntur nesciunt laudantium quaerat et suscipit quaerat recusandae nobis. Id corrupti vitae. Hic quisquam cumque aliquam qui. Quasi porro quisquam dicta voluptatibus.", 2, "The IB transmitter is down, quantify the optical t" },
                    { 23L, 35L, new DateTime(2023, 7, 1, 12, 57, 57, 266, DateTimeKind.Unspecified).AddTicks(6733), "Odit laudantium quibusdam nostrum fugiat dolores.", 4, "Use the back-end SMTP bus, then you can override t" },
                    { 24L, 20L, new DateTime(2021, 5, 21, 22, 49, 36, 213, DateTimeKind.Unspecified).AddTicks(4425), "Sed voluptate iusto vel ad ea voluptates iure.\nAccusantium saepe iusto dolorum necessitatibus necessitatibus.", 3, "We need to reboot the haptic USB protocol!" },
                    { 25L, 11L, new DateTime(2023, 1, 14, 17, 7, 29, 989, DateTimeKind.Unspecified).AddTicks(9492), "eum", 4, "You can't reboot the bus without parsing the redun" },
                    { 26L, 18L, new DateTime(2021, 2, 5, 8, 32, 33, 692, DateTimeKind.Unspecified).AddTicks(8470), "Amet qui vel dignissimos maxime quo recusandae provident. Accusamus expedita delectus praesentium nam dolores accusamus. Mollitia iste unde voluptatem.", 1, "You can't calculate the program without hacking th" },
                    { 27L, 19L, new DateTime(2021, 3, 26, 22, 11, 12, 357, DateTimeKind.Unspecified).AddTicks(1809), "necessitatibus", 4, "I'll index the open-source JSON card, that should " },
                    { 28L, 23L, new DateTime(2019, 10, 21, 17, 16, 53, 721, DateTimeKind.Unspecified).AddTicks(2811), "Modi blanditiis aut sunt qui ut.\nVeritatis dignissimos deleniti.\nQuod ut aliquid voluptatum dolorem error.", 1, "If we parse the driver, we can get to the PNG driv" },
                    { 29L, 17L, new DateTime(2023, 1, 8, 19, 24, 2, 289, DateTimeKind.Unspecified).AddTicks(189), "numquam", 3, "The PNG pixel is down, bypass the haptic pixel so " },
                    { 30L, 2L, new DateTime(2021, 5, 1, 1, 45, 31, 107, DateTimeKind.Unspecified).AddTicks(5629), "ut", 2, "The GB firewall is down, reboot the 1080p firewall" },
                    { 31L, 19L, new DateTime(2022, 6, 10, 2, 1, 40, 315, DateTimeKind.Unspecified).AddTicks(7796), "Eum ea sequi voluptas praesentium hic.\nVoluptatum voluptatem dolor consequatur distinctio et.\nAutem officia ut unde delectus repudiandae eum animi consectetur omnis.", 2, "You can't index the transmitter without compressin" },
                    { 32L, 13L, new DateTime(2023, 6, 3, 9, 22, 55, 934, DateTimeKind.Unspecified).AddTicks(1429), "quia", 4, "We need to back up the virtual SQL feed!" },
                    { 33L, 9L, new DateTime(2021, 9, 27, 9, 13, 27, 189, DateTimeKind.Unspecified).AddTicks(4865), "Sunt et est aliquam aut unde blanditiis.\nRepellendus dolorem autem.\nEos nihil veniam quia ipsa.\nOdit fuga illum nobis voluptatum deserunt in.", 2, "Try to program the COM alarm, maybe it will progra" },
                    { 34L, 7L, new DateTime(2023, 3, 2, 19, 20, 15, 347, DateTimeKind.Unspecified).AddTicks(9352), "Culpa voluptatem est sequi in sit quam.", 3, "The XSS matrix is down, transmit the cross-platfor" },
                    { 35L, 34L, new DateTime(2022, 10, 9, 16, 13, 17, 528, DateTimeKind.Unspecified).AddTicks(738), "Quisquam voluptate sequi magni soluta soluta qui voluptatem reprehenderit quo.", 1, "We need to navigate the digital RAM pixel!" },
                    { 36L, 4L, new DateTime(2022, 4, 5, 12, 28, 44, 34, DateTimeKind.Unspecified).AddTicks(3185), "Voluptatem quia ut ut doloribus ut et ratione suscipit. Est sunt veritatis. Quis ducimus laboriosam.", 1, "Try to input the JBOD driver, maybe it will input " },
                    { 37L, 38L, new DateTime(2020, 7, 21, 15, 11, 37, 167, DateTimeKind.Unspecified).AddTicks(2683), "iusto", 3, "The COM array is down, program the virtual array s" },
                    { 38L, 6L, new DateTime(2017, 8, 20, 16, 50, 54, 346, DateTimeKind.Unspecified).AddTicks(3877), "Omnis et et eum eum tempora nostrum a iure voluptatem. Expedita itaque quos quia soluta repellat quas perspiciatis. Sed consequatur numquam maxime. Enim quaerat ratione rerum sed quis. Ea dolores dolor eum vitae dolores vitae.", 3, "Use the solid state IB transmitter, then you can h" },
                    { 39L, 13L, new DateTime(2019, 10, 19, 12, 28, 44, 972, DateTimeKind.Unspecified).AddTicks(3149), "Expedita labore omnis omnis delectus doloremque possimus esse fugit.\nQui quasi pariatur et sed aliquam aut quo temporibus animi.\nNihil esse similique molestiae voluptas molestiae eum.\nImpedit et in nihil nihil et.", 4, "If we navigate the hard drive, we can get to the P" },
                    { 40L, 27L, new DateTime(2021, 2, 13, 23, 46, 21, 980, DateTimeKind.Unspecified).AddTicks(3990), "Adipisci sint quibusdam.", 4, "bypassing the matrix won't do anything, we need to" },
                    { 41L, 23L, new DateTime(2019, 4, 26, 3, 11, 46, 961, DateTimeKind.Unspecified).AddTicks(1071), "Non non ea ab maxime est ratione. Et voluptate iusto ut. Minima nihil qui quaerat ratione aut.", 3, "I'll parse the virtual SCSI transmitter, that shou" },
                    { 42L, 23L, new DateTime(2022, 3, 12, 13, 10, 33, 282, DateTimeKind.Unspecified).AddTicks(2796), "Eos provident laborum placeat reprehenderit voluptatem.", 1, "indexing the hard drive won't do anything, we need" }
                });

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "Instructions", "LevelId", "Title" },
                values: new object[,]
                {
                    { 43L, 23L, new DateTime(2023, 7, 9, 10, 16, 21, 474, DateTimeKind.Unspecified).AddTicks(6290), "Et dolor error quo doloremque harum explicabo.\nSed qui facere corporis sunt omnis voluptas corporis perspiciatis ut.\nEst rerum ad necessitatibus voluptatem.\nLaboriosam cupiditate dolorem eaque perspiciatis et.", 4, "You can't copy the port without parsing the wirele" },
                    { 44L, 21L, new DateTime(2021, 11, 6, 1, 50, 36, 253, DateTimeKind.Unspecified).AddTicks(9141), "Aut ex quis.\nEnim nulla eligendi est quam iusto.\nCumque harum saepe velit consequatur eligendi odit ut vero.\nDolorem sit vel sed nemo modi consequatur.", 2, "You can't parse the firewall without backing up th" },
                    { 45L, 35L, new DateTime(2021, 6, 1, 12, 15, 58, 511, DateTimeKind.Unspecified).AddTicks(5067), "Ut qui non dolores sunt enim fugiat quisquam cupiditate distinctio. Officiis reprehenderit quidem qui quis quia asperiores quaerat sapiente. Quia quia voluptatem magni et enim iure. Dolorum ut minus.", 2, "If we bypass the transmitter, we can get to the AI" },
                    { 46L, 7L, new DateTime(2023, 1, 4, 18, 35, 20, 627, DateTimeKind.Unspecified).AddTicks(2593), "Officia iusto rerum placeat temporibus corrupti et aut cumque.\nCommodi voluptatem laborum amet consequatur.\nA ducimus est ut reprehenderit.\nSit odit consequuntur.\nTempore magni nihil velit quos sed deleniti aliquid.\nEligendi nesciunt error mollitia et consequatur.", 1, "compressing the bus won't do anything, we need to " },
                    { 47L, 10L, new DateTime(2022, 6, 28, 8, 56, 22, 47, DateTimeKind.Unspecified).AddTicks(9948), "Earum laudantium molestias quam sed fuga explicabo vel corrupti in. Quibusdam et ut voluptatem facere. Magni qui pariatur reiciendis eveniet.", 1, "I'll parse the back-end XML protocol, that should " },
                    { 48L, 15L, new DateTime(2020, 12, 22, 13, 20, 15, 242, DateTimeKind.Unspecified).AddTicks(8633), "Sed rerum molestiae ad.\nItaque quas vel sint voluptas maxime assumenda.\nHic debitis tempore minus et quos quia repudiandae.\nUt laudantium ut.", 4, "We need to synthesize the haptic THX bandwidth!" },
                    { 49L, 34L, new DateTime(2023, 1, 6, 15, 14, 15, 16, DateTimeKind.Unspecified).AddTicks(7191), "vel", 1, "Use the wireless AI card, then you can back up the" },
                    { 50L, 34L, new DateTime(2022, 6, 2, 12, 3, 58, 67, DateTimeKind.Unspecified).AddTicks(9867), "Cum in ex nulla doloremque nostrum nemo quos.\nLaudantium corporis ut hic sapiente dolore sed architecto.\nIusto expedita rerum et pariatur optio ex aperiam dolorem placeat.\nAssumenda nesciunt nostrum pariatur corporis et doloribus quae.", 3, "You can't copy the sensor without navigating the d" },
                    { 51L, 38L, new DateTime(2021, 12, 21, 5, 29, 22, 670, DateTimeKind.Unspecified).AddTicks(3907), "Voluptatem iure quia labore pariatur id quia qui expedita quos.\nLaudantium natus dolorem rerum nemo perferendis quam est explicabo aliquam.\nIncidunt et qui.", 2, "The XML monitor is down, compress the 1080p monito" },
                    { 52L, 16L, new DateTime(2023, 3, 13, 20, 6, 21, 313, DateTimeKind.Unspecified).AddTicks(3518), "Fugiat illo alias error eligendi voluptatem.", 2, "You can't transmit the system without connecting t" },
                    { 53L, 29L, new DateTime(2018, 9, 14, 2, 44, 52, 723, DateTimeKind.Unspecified).AddTicks(7170), "Distinctio adipisci sequi vitae nulla. Corporis in labore nobis vel laudantium accusantium minus nihil quas. Sapiente quam vitae ea asperiores cum. Et illum temporibus placeat itaque et aliquam nostrum tempore ratione. Quia modi facere quia. Quaerat nostrum voluptatem.", 4, "Use the wireless GB protocol, then you can synthes" },
                    { 54L, 33L, new DateTime(2021, 4, 22, 2, 46, 55, 568, DateTimeKind.Unspecified).AddTicks(6796), "Necessitatibus libero sint ad culpa accusantium sed omnis praesentium.", 2, "Use the open-source ADP pixel, then you can input " },
                    { 55L, 31L, new DateTime(2023, 6, 29, 17, 42, 30, 203, DateTimeKind.Unspecified).AddTicks(3457), "Aut ut ut voluptates tempora ut commodi quos id. Dolores rerum eveniet quaerat dolores eligendi hic ipsum sit. Impedit fugiat numquam ad rerum atque tempore vero ipsa ab. Consequatur vitae hic omnis cumque perspiciatis consequatur ex omnis.", 1, "overriding the port won't do anything, we need to " },
                    { 56L, 26L, new DateTime(2022, 5, 14, 14, 25, 57, 324, DateTimeKind.Unspecified).AddTicks(2757), "Sunt ut fugit minima facere optio accusantium.\nDeserunt molestias ducimus omnis voluptatibus quos aut rerum.\nQuibusdam ratione qui illum quam modi.", 4, "I'll bypass the digital XSS pixel, that should pix" },
                    { 57L, 15L, new DateTime(2018, 9, 20, 23, 2, 58, 708, DateTimeKind.Unspecified).AddTicks(7948), "Minus quo dolores rerum pariatur nisi.\nDolorem dolore laborum corporis reiciendis dignissimos in.\nEos enim vel placeat minus voluptatem consequuntur totam corporis et.", 2, "Try to generate the SMTP application, maybe it wil" },
                    { 58L, 40L, new DateTime(2022, 5, 2, 19, 3, 29, 351, DateTimeKind.Unspecified).AddTicks(6632), "aut", 4, "Use the solid state SMS alarm, then you can bypass" },
                    { 59L, 8L, new DateTime(2022, 1, 7, 9, 16, 33, 109, DateTimeKind.Unspecified).AddTicks(1527), "Veniam rerum repudiandae sint eos delectus qui veniam id consequatur.", 2, "We need to synthesize the open-source CSS driver!" },
                    { 60L, 22L, new DateTime(2021, 9, 18, 0, 14, 9, 319, DateTimeKind.Unspecified).AddTicks(9634), "Quia fugiat voluptatem nihil vitae molestias.", 4, "I'll connect the bluetooth RSS feed, that should f" },
                    { 61L, 2L, new DateTime(2023, 7, 3, 16, 16, 40, 815, DateTimeKind.Unspecified).AddTicks(5400), "Accusamus beatae omnis totam maxime autem in et et.\nEt ducimus ea quia a excepturi a aut.\nExplicabo illo blanditiis illo eum qui itaque natus modi.", 4, "You can't generate the protocol without indexing t" },
                    { 62L, 13L, new DateTime(2021, 5, 11, 7, 21, 31, 828, DateTimeKind.Unspecified).AddTicks(6503), "Voluptatem veniam ut autem enim. Architecto nihil ut rerum aut nihil eos aut. Esse voluptatem reprehenderit perferendis aut ut dolor voluptas.", 4, "If we quantify the program, we can get to the FTP " },
                    { 63L, 26L, new DateTime(2022, 12, 15, 11, 47, 49, 54, DateTimeKind.Unspecified).AddTicks(2210), "Est consectetur voluptatem.\nPlaceat et eos.\nSunt quo et qui eius qui dolor numquam numquam nulla.\nSed nulla sint delectus alias.", 3, "If we bypass the circuit, we can get to the RSS ci" },
                    { 64L, 10L, new DateTime(2022, 2, 17, 6, 23, 50, 451, DateTimeKind.Unspecified).AddTicks(3002), "ut", 4, "parsing the matrix won't do anything, we need to c" },
                    { 65L, 24L, new DateTime(2017, 5, 15, 19, 10, 21, 355, DateTimeKind.Unspecified).AddTicks(3466), "Suscipit iusto quas est quaerat molestiae nostrum tempora aliquam tempora.\nRem dolorem ut voluptas voluptate.\nQuo magnam eligendi.\nIpsum tenetur praesentium earum.", 2, "Try to connect the XSS feed, maybe it will connect" },
                    { 66L, 33L, new DateTime(2021, 1, 29, 23, 10, 54, 847, DateTimeKind.Unspecified).AddTicks(2014), "Quae aliquid quod error nesciunt.", 3, "Use the online IB panel, then you can synthesize t" },
                    { 67L, 39L, new DateTime(2023, 7, 14, 16, 49, 14, 135, DateTimeKind.Unspecified).AddTicks(7715), "Autem est neque deleniti quae.\nCum vitae ut id voluptate est aut enim.\nAlias tenetur commodi cumque explicabo est.\nCommodi blanditiis tenetur sapiente dolores atque tempore.\nAut modi officiis neque consequatur.", 1, "You can't transmit the application without quantif" },
                    { 68L, 19L, new DateTime(2022, 6, 14, 15, 21, 27, 279, DateTimeKind.Unspecified).AddTicks(8071), "Est dolores id tempore vel.", 4, "If we override the circuit, we can get to the HDD " },
                    { 69L, 7L, new DateTime(2023, 3, 4, 18, 14, 9, 83, DateTimeKind.Unspecified).AddTicks(9015), "Aut quibusdam amet at facilis rerum.\nUt veritatis commodi aspernatur doloremque quia quidem.", 1, "Use the cross-platform AGP firewall, then you can " },
                    { 70L, 37L, new DateTime(2023, 5, 27, 5, 27, 24, 337, DateTimeKind.Unspecified).AddTicks(1802), "Natus aut officia qui consequatur.", 4, "Try to navigate the THX system, maybe it will navi" }
                });

            migrationBuilder.InsertData(
                table: "LanguageVersions",
                columns: new[] { "Id", "LanguageId", "Version" },
                values: new object[,]
                {
                    { 1, 4, "8.5.4.4" },
                    { 2, 3, "1.0.9.1" },
                    { 3, 2, "9.6.6.2" },
                    { 4, 4, "8.4.6.6" },
                    { 5, 1, "4.5.3.5" },
                    { 6, 3, "4.7.8.1" },
                    { 7, 3, "2.0.6.1" },
                    { 8, 4, "5.1.4.6" },
                    { 9, 4, "7.6.7.5" }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "Cost", "EndDate", "IsActive", "PaymentSubscriptionId", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate", "UserId" },
                values: new object[,]
                {
                    { 1L, 151.37m, new DateTime(2023, 5, 2, 14, 5, 25, 185, DateTimeKind.Unspecified).AddTicks(7035), false, "2umhqjy0f1gdzhf2", new DateTime(2023, 1, 29, 5, 4, 21, 614, DateTimeKind.Unspecified).AddTicks(4782), new DateTime(2019, 6, 30, 10, 23, 6, 735, DateTimeKind.Unspecified).AddTicks(6438), 2, new DateTime(2023, 2, 7, 3, 49, 15, 305, DateTimeKind.Unspecified).AddTicks(70), 27L },
                    { 2L, 136.02m, new DateTime(2024, 1, 27, 7, 52, 15, 678, DateTimeKind.Unspecified).AddTicks(8885), true, "6iotvwd2kcauexpx", new DateTime(2023, 7, 8, 22, 30, 20, 554, DateTimeKind.Unspecified).AddTicks(4833), new DateTime(2022, 12, 15, 20, 2, 30, 562, DateTimeKind.Unspecified).AddTicks(3811), 1, new DateTime(2023, 1, 1, 22, 51, 59, 451, DateTimeKind.Unspecified).AddTicks(6985), 20L },
                    { 3L, 151.37m, new DateTime(2023, 5, 18, 0, 40, 49, 300, DateTimeKind.Unspecified).AddTicks(6060), false, "uo2s583680b8v54j", new DateTime(2023, 3, 5, 19, 48, 16, 534, DateTimeKind.Unspecified).AddTicks(5295), new DateTime(2022, 5, 6, 7, 53, 53, 492, DateTimeKind.Unspecified).AddTicks(250), 2, new DateTime(2023, 2, 8, 4, 56, 18, 152, DateTimeKind.Unspecified).AddTicks(5014), 27L },
                    { 4L, 136.02m, new DateTime(2023, 9, 29, 14, 51, 33, 575, DateTimeKind.Unspecified).AddTicks(7818), true, "nfd23s23e9y7ukxb", new DateTime(2023, 2, 15, 2, 47, 55, 113, DateTimeKind.Unspecified).AddTicks(962), new DateTime(2022, 10, 14, 20, 4, 15, 11, DateTimeKind.Unspecified).AddTicks(1053), 1, new DateTime(2023, 3, 16, 14, 46, 8, 23, DateTimeKind.Unspecified).AddTicks(3152), 10L },
                    { 5L, 136.02m, new DateTime(2023, 4, 11, 15, 34, 40, 197, DateTimeKind.Unspecified).AddTicks(1070), true, "28569h790c5pv13g", new DateTime(2023, 2, 4, 19, 0, 2, 643, DateTimeKind.Unspecified).AddTicks(5320), new DateTime(2022, 4, 11, 15, 18, 2, 791, DateTimeKind.Unspecified).AddTicks(639), 1, new DateTime(2023, 7, 12, 21, 10, 27, 204, DateTimeKind.Unspecified).AddTicks(9411), 38L }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "Cost", "EndDate", "IsActive", "PaymentSubscriptionId", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate", "UserId" },
                values: new object[,]
                {
                    { 6L, 91.86m, new DateTime(2021, 4, 16, 21, 29, 35, 64, DateTimeKind.Unspecified).AddTicks(9344), true, "fhe3z935d1zvmvux", new DateTime(2020, 11, 12, 4, 41, 23, 818, DateTimeKind.Unspecified).AddTicks(4816), new DateTime(2018, 3, 14, 22, 7, 17, 470, DateTimeKind.Unspecified).AddTicks(2925), 3, new DateTime(2019, 5, 23, 9, 25, 57, 791, DateTimeKind.Unspecified).AddTicks(9017), 3L },
                    { 7L, 136.02m, new DateTime(2023, 6, 17, 7, 16, 22, 751, DateTimeKind.Unspecified).AddTicks(4437), true, "04gfoh55j2qr239q", new DateTime(2023, 5, 24, 17, 9, 4, 620, DateTimeKind.Unspecified).AddTicks(6107), new DateTime(2022, 4, 8, 13, 55, 8, 479, DateTimeKind.Unspecified).AddTicks(6269), 1, new DateTime(2022, 7, 29, 15, 40, 12, 849, DateTimeKind.Unspecified).AddTicks(8833), 10L },
                    { 8L, 91.86m, new DateTime(2022, 7, 1, 2, 2, 32, 638, DateTimeKind.Unspecified).AddTicks(5722), false, "cvjhq7n8273vtohw", new DateTime(2022, 5, 9, 20, 3, 37, 296, DateTimeKind.Unspecified).AddTicks(2682), new DateTime(2020, 9, 26, 23, 42, 57, 861, DateTimeKind.Unspecified).AddTicks(2353), 3, new DateTime(2020, 12, 25, 11, 2, 16, 267, DateTimeKind.Unspecified).AddTicks(2632), 36L },
                    { 9L, 151.37m, new DateTime(2024, 8, 1, 8, 20, 12, 674, DateTimeKind.Unspecified).AddTicks(354), false, "ff9fvm4sae2sxofc", new DateTime(2023, 8, 2, 7, 20, 30, 36, DateTimeKind.Unspecified).AddTicks(3348), new DateTime(2023, 3, 11, 12, 57, 45, 775, DateTimeKind.Unspecified).AddTicks(152), 2, new DateTime(2023, 5, 16, 19, 13, 19, 945, DateTimeKind.Unspecified).AddTicks(8649), 17L },
                    { 10L, 136.02m, new DateTime(2022, 7, 30, 13, 38, 18, 136, DateTimeKind.Unspecified).AddTicks(8054), true, "igx8w9w90k1ay8cf", new DateTime(2021, 12, 12, 18, 3, 56, 566, DateTimeKind.Unspecified).AddTicks(5559), new DateTime(2020, 10, 10, 14, 12, 40, 445, DateTimeKind.Unspecified).AddTicks(7009), 1, new DateTime(2022, 10, 6, 1, 56, 57, 391, DateTimeKind.Unspecified).AddTicks(1379), 3L },
                    { 11L, 91.86m, new DateTime(2023, 10, 28, 17, 59, 7, 83, DateTimeKind.Unspecified).AddTicks(4689), true, "dy4mdzy1ipwfpvv0", new DateTime(2023, 3, 10, 12, 3, 11, 762, DateTimeKind.Unspecified).AddTicks(1559), new DateTime(2022, 12, 6, 4, 11, 3, 638, DateTimeKind.Unspecified).AddTicks(3065), 3, new DateTime(2023, 1, 12, 13, 49, 15, 195, DateTimeKind.Unspecified).AddTicks(41), 20L },
                    { 12L, 136.02m, new DateTime(2023, 1, 7, 8, 59, 52, 140, DateTimeKind.Unspecified).AddTicks(1201), true, "69sotjwthpvx4aw1", new DateTime(2022, 9, 6, 14, 17, 48, 231, DateTimeKind.Unspecified).AddTicks(2278), new DateTime(2022, 5, 16, 21, 52, 29, 188, DateTimeKind.Unspecified).AddTicks(7554), 1, new DateTime(2023, 7, 16, 13, 34, 21, 341, DateTimeKind.Unspecified).AddTicks(8992), 25L },
                    { 13L, 136.02m, new DateTime(2023, 8, 31, 22, 8, 19, 97, DateTimeKind.Unspecified).AddTicks(266), true, "gjxuxll8kyg46a7z", new DateTime(2023, 8, 23, 0, 34, 20, 783, DateTimeKind.Unspecified).AddTicks(6046), new DateTime(2023, 5, 20, 0, 58, 58, 138, DateTimeKind.Unspecified).AddTicks(3702), 1, new DateTime(2023, 8, 16, 21, 59, 43, 537, DateTimeKind.Unspecified).AddTicks(8557), 32L },
                    { 14L, 151.37m, new DateTime(2023, 1, 9, 19, 43, 27, 852, DateTimeKind.Unspecified).AddTicks(5931), true, "wprmc5u9im89l2ww", new DateTime(2022, 3, 14, 4, 51, 21, 435, DateTimeKind.Unspecified).AddTicks(729), new DateTime(2021, 11, 14, 21, 53, 34, 876, DateTimeKind.Unspecified).AddTicks(1696), 2, new DateTime(2023, 3, 28, 9, 0, 47, 610, DateTimeKind.Unspecified).AddTicks(9818), 5L },
                    { 15L, 136.02m, new DateTime(2023, 3, 15, 15, 14, 13, 930, DateTimeKind.Unspecified).AddTicks(6570), false, "stg9zq5iopx7uyvf", new DateTime(2023, 2, 23, 0, 18, 6, 760, DateTimeKind.Unspecified).AddTicks(5902), new DateTime(2022, 7, 6, 17, 2, 1, 341, DateTimeKind.Unspecified).AddTicks(954), 1, new DateTime(2023, 7, 24, 16, 49, 41, 194, DateTimeKind.Unspecified).AddTicks(8675), 5L },
                    { 16L, 91.86m, new DateTime(2023, 9, 5, 0, 38, 58, 577, DateTimeKind.Unspecified).AddTicks(4758), true, "61vekpd4uftjpk9r", new DateTime(2023, 7, 16, 16, 46, 29, 199, DateTimeKind.Unspecified).AddTicks(1450), new DateTime(2022, 8, 18, 13, 48, 8, 520, DateTimeKind.Unspecified).AddTicks(1105), 3, null, 19L },
                    { 17L, 91.86m, new DateTime(2022, 10, 12, 17, 7, 11, 767, DateTimeKind.Unspecified).AddTicks(2465), false, "qy2m6a9vgq3xvryz", new DateTime(2022, 8, 22, 15, 43, 3, 0, DateTimeKind.Unspecified).AddTicks(9053), new DateTime(2021, 12, 16, 23, 57, 25, 126, DateTimeKind.Unspecified).AddTicks(1724), 3, new DateTime(2022, 7, 15, 3, 52, 12, 417, DateTimeKind.Unspecified).AddTicks(3222), 14L },
                    { 18L, 91.86m, new DateTime(2024, 1, 24, 1, 42, 13, 202, DateTimeKind.Unspecified).AddTicks(6697), false, "xt3cbgkhzqommryk", new DateTime(2023, 8, 4, 11, 5, 5, 740, DateTimeKind.Unspecified).AddTicks(406), new DateTime(2022, 4, 24, 22, 59, 13, 607, DateTimeKind.Unspecified).AddTicks(2373), 3, new DateTime(2022, 10, 9, 10, 0, 5, 170, DateTimeKind.Unspecified).AddTicks(8130), 7L },
                    { 19L, 151.37m, new DateTime(2023, 8, 22, 7, 27, 46, 454, DateTimeKind.Unspecified).AddTicks(1675), false, "rmkbbn0e8joc7xjz", new DateTime(2023, 7, 21, 8, 52, 48, 869, DateTimeKind.Unspecified).AddTicks(5438), new DateTime(2023, 7, 16, 2, 59, 26, 749, DateTimeKind.Unspecified).AddTicks(1306), 2, new DateTime(2023, 7, 29, 2, 21, 35, 543, DateTimeKind.Unspecified).AddTicks(4612), 7L },
                    { 20L, 136.02m, new DateTime(2019, 10, 6, 8, 28, 45, 930, DateTimeKind.Unspecified).AddTicks(9033), true, "us879r2lwdkpw85c", new DateTime(2019, 9, 7, 22, 26, 20, 441, DateTimeKind.Unspecified).AddTicks(6468), new DateTime(2019, 5, 28, 1, 34, 14, 900, DateTimeKind.Unspecified).AddTicks(5979), 1, new DateTime(2021, 12, 17, 21, 47, 21, 546, DateTimeKind.Unspecified).AddTicks(5551), 29L },
                    { 21L, 136.02m, new DateTime(2023, 9, 9, 15, 30, 38, 580, DateTimeKind.Unspecified).AddTicks(7876), false, "e3suermf9zhiet5h", new DateTime(2023, 5, 3, 17, 43, 34, 583, DateTimeKind.Unspecified).AddTicks(330), new DateTime(2021, 12, 29, 0, 11, 29, 900, DateTimeKind.Unspecified).AddTicks(1260), 1, new DateTime(2023, 5, 22, 5, 50, 16, 419, DateTimeKind.Unspecified).AddTicks(6130), 20L },
                    { 22L, 136.02m, new DateTime(2024, 5, 13, 0, 24, 19, 961, DateTimeKind.Unspecified).AddTicks(3562), false, "gkftyah9gzs5y764", new DateTime(2023, 8, 3, 5, 7, 19, 294, DateTimeKind.Unspecified).AddTicks(8155), new DateTime(2023, 1, 24, 7, 2, 35, 179, DateTimeKind.Unspecified).AddTicks(4064), 1, new DateTime(2023, 6, 9, 11, 48, 58, 141, DateTimeKind.Unspecified).AddTicks(4283), 31L },
                    { 23L, 136.02m, new DateTime(2022, 4, 19, 18, 27, 54, 616, DateTimeKind.Unspecified).AddTicks(5040), true, "4wkz5jwj0veuctgy", new DateTime(2022, 4, 14, 8, 4, 32, 682, DateTimeKind.Unspecified).AddTicks(7644), new DateTime(2021, 3, 28, 20, 39, 25, 707, DateTimeKind.Unspecified).AddTicks(2913), 1, new DateTime(2023, 8, 19, 6, 15, 9, 166, DateTimeKind.Unspecified).AddTicks(7607), 21L },
                    { 24L, 136.02m, new DateTime(2021, 12, 14, 18, 17, 11, 310, DateTimeKind.Unspecified).AddTicks(2788), false, "xb17e65tmjo2pi3w", new DateTime(2021, 2, 23, 2, 10, 28, 657, DateTimeKind.Unspecified).AddTicks(3698), new DateTime(2020, 12, 9, 19, 3, 2, 981, DateTimeKind.Unspecified).AddTicks(8374), 1, new DateTime(2021, 11, 1, 5, 53, 47, 184, DateTimeKind.Unspecified).AddTicks(7682), 4L },
                    { 25L, 151.37m, new DateTime(2022, 12, 19, 13, 5, 48, 306, DateTimeKind.Unspecified).AddTicks(3021), false, "ohejkiv4da2uho5t", new DateTime(2022, 11, 4, 14, 40, 20, 216, DateTimeKind.Unspecified).AddTicks(1958), new DateTime(2019, 3, 22, 5, 56, 49, 416, DateTimeKind.Unspecified).AddTicks(9613), 2, new DateTime(2021, 1, 13, 21, 37, 7, 936, DateTimeKind.Unspecified).AddTicks(6060), 30L },
                    { 26L, 151.37m, new DateTime(2022, 11, 1, 15, 50, 10, 927, DateTimeKind.Unspecified).AddTicks(1526), true, "46crvfhli3jxsl84", new DateTime(2022, 5, 22, 22, 24, 11, 287, DateTimeKind.Unspecified).AddTicks(2090), new DateTime(2021, 6, 3, 4, 50, 32, 875, DateTimeKind.Unspecified).AddTicks(9234), 2, new DateTime(2021, 12, 9, 19, 47, 39, 927, DateTimeKind.Unspecified).AddTicks(683), 27L },
                    { 27L, 151.37m, new DateTime(2022, 10, 11, 14, 46, 20, 507, DateTimeKind.Unspecified).AddTicks(2868), true, "3ab74yu98efe549y", new DateTime(2022, 8, 15, 0, 58, 35, 752, DateTimeKind.Unspecified).AddTicks(2665), new DateTime(2021, 12, 7, 14, 28, 13, 453, DateTimeKind.Unspecified).AddTicks(1021), 2, null, 33L },
                    { 28L, 136.02m, new DateTime(2023, 8, 8, 4, 46, 51, 752, DateTimeKind.Unspecified).AddTicks(8667), false, "c26kqtjwrynk39gj", new DateTime(2023, 6, 7, 22, 54, 20, 412, DateTimeKind.Unspecified).AddTicks(7045), new DateTime(2023, 4, 24, 13, 56, 14, 35, DateTimeKind.Unspecified).AddTicks(5401), 1, new DateTime(2023, 8, 3, 0, 11, 42, 714, DateTimeKind.Unspecified).AddTicks(214), 11L },
                    { 29L, 151.37m, new DateTime(2022, 10, 30, 4, 53, 31, 824, DateTimeKind.Unspecified).AddTicks(4481), false, "aqmyw08v96v1s9if", new DateTime(2022, 5, 12, 4, 52, 55, 153, DateTimeKind.Unspecified).AddTicks(2328), new DateTime(2022, 1, 21, 15, 47, 54, 39, DateTimeKind.Unspecified).AddTicks(5306), 2, new DateTime(2023, 3, 8, 17, 44, 44, 596, DateTimeKind.Unspecified).AddTicks(1233), 35L },
                    { 30L, 91.86m, new DateTime(2023, 10, 11, 0, 40, 34, 104, DateTimeKind.Unspecified).AddTicks(1016), false, "0s5wjozi3ma06kzq", new DateTime(2023, 5, 20, 1, 22, 29, 305, DateTimeKind.Unspecified).AddTicks(1856), new DateTime(2019, 10, 19, 9, 57, 43, 207, DateTimeKind.Unspecified).AddTicks(5872), 3, new DateTime(2021, 5, 31, 18, 35, 30, 445, DateTimeKind.Unspecified).AddTicks(886), 30L },
                    { 31L, 151.37m, new DateTime(2024, 6, 19, 8, 30, 2, 915, DateTimeKind.Unspecified).AddTicks(9903), true, "q9hn6s2kv3y4vcck", new DateTime(2023, 7, 1, 13, 41, 46, 542, DateTimeKind.Unspecified).AddTicks(4916), new DateTime(2023, 6, 21, 10, 46, 51, 155, DateTimeKind.Unspecified).AddTicks(5996), 2, new DateTime(2023, 7, 23, 5, 18, 56, 94, DateTimeKind.Unspecified).AddTicks(3263), 8L },
                    { 32L, 91.86m, new DateTime(2020, 9, 25, 17, 24, 6, 867, DateTimeKind.Unspecified).AddTicks(5800), true, "iwgpew5l055a6ccb", new DateTime(2020, 2, 15, 5, 7, 2, 922, DateTimeKind.Unspecified).AddTicks(3187), new DateTime(2019, 10, 12, 1, 4, 11, 582, DateTimeKind.Unspecified).AddTicks(5106), 3, new DateTime(2023, 3, 4, 3, 6, 39, 936, DateTimeKind.Unspecified).AddTicks(8005), 23L },
                    { 33L, 151.37m, new DateTime(2021, 11, 29, 8, 42, 12, 963, DateTimeKind.Unspecified).AddTicks(1680), false, "fqq1hl08z749bd6z", new DateTime(2021, 9, 19, 3, 14, 21, 188, DateTimeKind.Unspecified).AddTicks(4273), new DateTime(2016, 12, 6, 9, 26, 32, 41, DateTimeKind.Unspecified).AddTicks(4857), 2, new DateTime(2017, 3, 27, 2, 30, 55, 552, DateTimeKind.Unspecified).AddTicks(9592), 38L },
                    { 34L, 91.86m, new DateTime(2023, 9, 27, 22, 27, 59, 290, DateTimeKind.Unspecified).AddTicks(7588), true, "0ml8d5on129n534f", new DateTime(2023, 7, 12, 1, 44, 21, 855, DateTimeKind.Unspecified).AddTicks(2196), new DateTime(2018, 6, 5, 6, 27, 32, 2, DateTimeKind.Unspecified).AddTicks(1025), 3, new DateTime(2018, 10, 23, 20, 24, 6, 891, DateTimeKind.Unspecified).AddTicks(4339), 6L },
                    { 35L, 151.37m, new DateTime(2022, 3, 23, 21, 18, 50, 724, DateTimeKind.Unspecified).AddTicks(9525), false, "k558r56ddw1u0svt", new DateTime(2022, 2, 16, 13, 7, 21, 843, DateTimeKind.Unspecified).AddTicks(453), new DateTime(2021, 8, 24, 14, 6, 16, 734, DateTimeKind.Unspecified).AddTicks(1250), 2, new DateTime(2022, 9, 3, 9, 53, 47, 5, DateTimeKind.Unspecified).AddTicks(6900), 21L },
                    { 36L, 91.86m, new DateTime(2021, 6, 26, 14, 16, 54, 996, DateTimeKind.Unspecified).AddTicks(7115), true, "9olaqemxndo70gvv", new DateTime(2021, 6, 1, 21, 57, 11, 947, DateTimeKind.Unspecified).AddTicks(1096), new DateTime(2020, 8, 23, 23, 8, 5, 464, DateTimeKind.Unspecified).AddTicks(4313), 3, new DateTime(2021, 6, 19, 19, 58, 23, 215, DateTimeKind.Unspecified).AddTicks(347), 36L },
                    { 37L, 136.02m, new DateTime(2023, 6, 11, 10, 21, 8, 489, DateTimeKind.Unspecified).AddTicks(5647), true, "1ggquq41cbz3kwmy", new DateTime(2023, 5, 2, 23, 18, 30, 85, DateTimeKind.Unspecified).AddTicks(8858), new DateTime(2022, 10, 20, 16, 56, 43, 384, DateTimeKind.Unspecified).AddTicks(6839), 1, new DateTime(2023, 5, 12, 2, 12, 39, 239, DateTimeKind.Unspecified).AddTicks(2375), 11L },
                    { 38L, 151.37m, new DateTime(2024, 1, 27, 1, 16, 56, 602, DateTimeKind.Unspecified).AddTicks(4684), false, "mcc78krz988ayw3w", new DateTime(2023, 8, 6, 13, 4, 13, 929, DateTimeKind.Unspecified).AddTicks(8195), new DateTime(2023, 6, 30, 8, 35, 54, 354, DateTimeKind.Unspecified).AddTicks(7752), 2, new DateTime(2023, 8, 10, 16, 47, 8, 862, DateTimeKind.Unspecified).AddTicks(3716), 11L },
                    { 39L, 91.86m, new DateTime(2023, 10, 22, 2, 37, 19, 640, DateTimeKind.Unspecified).AddTicks(4367), true, "8czy2s8dnd3hewts", new DateTime(2023, 2, 23, 12, 18, 53, 65, DateTimeKind.Unspecified).AddTicks(295), new DateTime(2022, 11, 27, 17, 22, 46, 757, DateTimeKind.Unspecified).AddTicks(3266), 3, null, 23L },
                    { 40L, 91.86m, new DateTime(2023, 5, 4, 1, 3, 11, 203, DateTimeKind.Unspecified).AddTicks(1931), true, "0adhs4lu1czvkswh", new DateTime(2022, 7, 14, 15, 15, 9, 771, DateTimeKind.Unspecified).AddTicks(1694), new DateTime(2021, 1, 22, 9, 27, 29, 301, DateTimeKind.Unspecified).AddTicks(5606), 3, new DateTime(2022, 8, 11, 1, 27, 24, 448, DateTimeKind.Unspecified).AddTicks(5766), 1L },
                    { 41L, 136.02m, new DateTime(2022, 3, 5, 22, 0, 37, 98, DateTimeKind.Unspecified).AddTicks(7484), false, "t24hxzbvbmyserki", new DateTime(2021, 4, 3, 5, 20, 18, 877, DateTimeKind.Unspecified).AddTicks(3704), new DateTime(2021, 2, 24, 10, 3, 45, 683, DateTimeKind.Unspecified).AddTicks(9531), 1, new DateTime(2023, 6, 25, 1, 53, 4, 405, DateTimeKind.Unspecified).AddTicks(404), 32L },
                    { 42L, 136.02m, new DateTime(2024, 6, 8, 20, 7, 13, 145, DateTimeKind.Unspecified).AddTicks(6683), true, "2cbsqfkes0nq04x2", new DateTime(2023, 8, 2, 7, 33, 51, 747, DateTimeKind.Unspecified).AddTicks(883), new DateTime(2022, 6, 4, 22, 18, 50, 717, DateTimeKind.Unspecified).AddTicks(9708), 1, new DateTime(2022, 7, 30, 17, 45, 11, 932, DateTimeKind.Unspecified).AddTicks(8033), 2L },
                    { 43L, 151.37m, new DateTime(2023, 9, 4, 4, 12, 2, 63, DateTimeKind.Unspecified).AddTicks(4624), false, "a3sk5gfvudeknj5w", new DateTime(2023, 7, 30, 6, 47, 14, 223, DateTimeKind.Unspecified).AddTicks(6994), new DateTime(2023, 7, 13, 19, 39, 11, 375, DateTimeKind.Unspecified).AddTicks(5291), 2, new DateTime(2023, 8, 16, 14, 45, 28, 811, DateTimeKind.Unspecified).AddTicks(8907), 3L },
                    { 44L, 91.86m, new DateTime(2024, 3, 4, 22, 22, 15, 254, DateTimeKind.Unspecified).AddTicks(2926), true, "bc0td9wya1hmn09c", new DateTime(2023, 6, 21, 16, 25, 48, 88, DateTimeKind.Unspecified).AddTicks(8957), new DateTime(2023, 3, 3, 12, 8, 44, 557, DateTimeKind.Unspecified).AddTicks(6160), 3, new DateTime(2023, 5, 3, 3, 23, 33, 462, DateTimeKind.Unspecified).AddTicks(5173), 23L },
                    { 45L, 151.37m, new DateTime(2022, 12, 29, 14, 17, 6, 323, DateTimeKind.Unspecified).AddTicks(3830), true, "xowb5o5gk48tfmik", new DateTime(2022, 12, 15, 3, 24, 25, 299, DateTimeKind.Unspecified).AddTicks(9283), new DateTime(2021, 11, 10, 17, 14, 18, 66, DateTimeKind.Unspecified).AddTicks(9482), 2, new DateTime(2022, 10, 13, 15, 59, 7, 52, DateTimeKind.Unspecified).AddTicks(4042), 19L },
                    { 46L, 136.02m, new DateTime(2022, 6, 16, 21, 51, 51, 492, DateTimeKind.Unspecified).AddTicks(1048), false, "anubxvyyxivpdltm", new DateTime(2021, 9, 12, 15, 45, 37, 509, DateTimeKind.Unspecified).AddTicks(6531), new DateTime(2019, 8, 19, 1, 19, 4, 492, DateTimeKind.Unspecified).AddTicks(5881), 1, new DateTime(2021, 6, 1, 9, 5, 30, 924, DateTimeKind.Unspecified).AddTicks(8221), 36L },
                    { 47L, 136.02m, new DateTime(2024, 5, 9, 19, 19, 17, 733, DateTimeKind.Unspecified).AddTicks(6417), false, "ab681sgffu1ituio", new DateTime(2023, 8, 17, 7, 29, 21, 766, DateTimeKind.Unspecified).AddTicks(3142), new DateTime(2023, 6, 11, 19, 37, 36, 803, DateTimeKind.Unspecified).AddTicks(2), 1, new DateTime(2023, 8, 8, 18, 34, 19, 376, DateTimeKind.Unspecified).AddTicks(6849), 7L }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "Cost", "EndDate", "IsActive", "PaymentSubscriptionId", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate", "UserId" },
                values: new object[,]
                {
                    { 48L, 151.37m, new DateTime(2023, 2, 20, 14, 32, 54, 596, DateTimeKind.Unspecified).AddTicks(5464), true, "noq0gqauqw1mppw5", new DateTime(2022, 8, 1, 14, 10, 28, 836, DateTimeKind.Unspecified).AddTicks(319), new DateTime(2021, 5, 28, 10, 27, 24, 380, DateTimeKind.Unspecified).AddTicks(8087), 2, new DateTime(2022, 2, 4, 12, 32, 23, 471, DateTimeKind.Unspecified).AddTicks(554), 4L },
                    { 49L, 136.02m, new DateTime(2024, 5, 15, 2, 20, 37, 655, DateTimeKind.Unspecified).AddTicks(9212), true, "icchkz7h4bld2gyo", new DateTime(2023, 7, 24, 5, 21, 30, 14, DateTimeKind.Unspecified).AddTicks(7652), new DateTime(2022, 7, 29, 23, 24, 14, 555, DateTimeKind.Unspecified).AddTicks(5642), 1, new DateTime(2023, 7, 15, 14, 7, 1, 130, DateTimeKind.Unspecified).AddTicks(5772), 23L },
                    { 50L, 151.37m, new DateTime(2023, 8, 22, 20, 31, 28, 97, DateTimeKind.Unspecified).AddTicks(5605), false, "dqu9ioacwoh3dt9r", new DateTime(2023, 7, 9, 18, 34, 6, 136, DateTimeKind.Unspecified).AddTicks(3165), new DateTime(2023, 6, 13, 0, 9, 21, 596, DateTimeKind.Unspecified).AddTicks(9640), 2, null, 28L },
                    { 51L, 136.02m, new DateTime(2022, 5, 26, 12, 15, 30, 441, DateTimeKind.Unspecified).AddTicks(3603), false, "hlzcjv8mdw4u5yyf", new DateTime(2021, 6, 9, 5, 48, 55, 132, DateTimeKind.Unspecified).AddTicks(5211), new DateTime(2019, 12, 27, 8, 12, 39, 272, DateTimeKind.Unspecified).AddTicks(338), 1, new DateTime(2023, 2, 9, 4, 31, 2, 402, DateTimeKind.Unspecified).AddTicks(3937), 1L },
                    { 52L, 91.86m, new DateTime(2023, 12, 26, 13, 29, 32, 663, DateTimeKind.Unspecified).AddTicks(8852), false, "y089embtn7rxpys0", new DateTime(2023, 4, 15, 23, 16, 36, 882, DateTimeKind.Unspecified).AddTicks(8617), new DateTime(2022, 12, 16, 20, 24, 12, 416, DateTimeKind.Unspecified).AddTicks(4127), 3, new DateTime(2023, 3, 25, 19, 19, 41, 363, DateTimeKind.Unspecified).AddTicks(7516), 18L },
                    { 53L, 136.02m, new DateTime(2023, 8, 1, 4, 3, 8, 660, DateTimeKind.Unspecified).AddTicks(6919), true, "l2cv2onna8ejmz8r", new DateTime(2023, 5, 26, 20, 44, 15, 158, DateTimeKind.Unspecified).AddTicks(1307), new DateTime(2020, 1, 24, 14, 6, 4, 276, DateTimeKind.Unspecified).AddTicks(9792), 1, new DateTime(2020, 3, 11, 14, 2, 24, 503, DateTimeKind.Unspecified).AddTicks(1441), 23L },
                    { 54L, 136.02m, new DateTime(2023, 10, 4, 4, 57, 23, 689, DateTimeKind.Unspecified).AddTicks(3426), true, "gfy34t1jeinb9gqz", new DateTime(2023, 3, 21, 3, 54, 10, 882, DateTimeKind.Unspecified).AddTicks(5948), new DateTime(2022, 11, 3, 7, 8, 13, 642, DateTimeKind.Unspecified).AddTicks(6217), 1, new DateTime(2023, 1, 16, 6, 22, 40, 892, DateTimeKind.Unspecified).AddTicks(5180), 22L },
                    { 55L, 91.86m, new DateTime(2021, 7, 14, 22, 27, 22, 689, DateTimeKind.Unspecified).AddTicks(2081), true, "nzwe7ojkc9empkjg", new DateTime(2021, 3, 17, 21, 54, 43, 772, DateTimeKind.Unspecified).AddTicks(3732), new DateTime(2020, 11, 22, 14, 48, 42, 771, DateTimeKind.Unspecified).AddTicks(4521), 3, new DateTime(2023, 5, 20, 10, 51, 4, 915, DateTimeKind.Unspecified).AddTicks(4711), 8L },
                    { 56L, 136.02m, new DateTime(2023, 9, 16, 17, 1, 11, 811, DateTimeKind.Unspecified).AddTicks(4011), false, "j7d2e9j71hg4xncp", new DateTime(2023, 8, 23, 6, 17, 39, 570, DateTimeKind.Unspecified).AddTicks(1239), new DateTime(2023, 8, 14, 2, 22, 20, 688, DateTimeKind.Unspecified).AddTicks(3889), 1, new DateTime(2023, 8, 15, 4, 5, 8, 104, DateTimeKind.Unspecified).AddTicks(9526), 39L },
                    { 57L, 136.02m, new DateTime(2021, 12, 22, 4, 3, 57, 32, DateTimeKind.Unspecified).AddTicks(1007), false, "l7ao3a4qisuzah62", new DateTime(2021, 11, 6, 8, 33, 45, 185, DateTimeKind.Unspecified).AddTicks(3811), new DateTime(2021, 5, 4, 18, 51, 30, 50, DateTimeKind.Unspecified).AddTicks(6866), 1, new DateTime(2022, 4, 10, 11, 6, 18, 724, DateTimeKind.Unspecified).AddTicks(5689), 30L },
                    { 58L, 91.86m, new DateTime(2022, 7, 1, 15, 59, 15, 859, DateTimeKind.Unspecified).AddTicks(1177), true, "if58xh1fxeg6zu3r", new DateTime(2021, 9, 14, 6, 30, 48, 37, DateTimeKind.Unspecified).AddTicks(4659), new DateTime(2021, 6, 13, 17, 39, 39, 909, DateTimeKind.Unspecified).AddTicks(2218), 3, new DateTime(2022, 4, 4, 8, 46, 54, 117, DateTimeKind.Unspecified).AddTicks(7366), 15L },
                    { 59L, 151.37m, new DateTime(2023, 7, 19, 22, 17, 48, 332, DateTimeKind.Unspecified).AddTicks(1605), false, "xw8vj1u6nq6o4wt0", new DateTime(2023, 7, 10, 13, 9, 37, 854, DateTimeKind.Unspecified).AddTicks(2986), new DateTime(2022, 8, 27, 8, 46, 12, 820, DateTimeKind.Unspecified).AddTicks(6412), 2, new DateTime(2023, 8, 14, 9, 10, 6, 163, DateTimeKind.Unspecified).AddTicks(5200), 31L },
                    { 60L, 136.02m, new DateTime(2022, 9, 24, 10, 55, 47, 351, DateTimeKind.Unspecified).AddTicks(2333), true, "2tufsfq40oa185wv", new DateTime(2022, 1, 16, 20, 43, 56, 163, DateTimeKind.Unspecified).AddTicks(3417), new DateTime(2021, 7, 17, 11, 32, 16, 143, DateTimeKind.Unspecified).AddTicks(8571), 1, new DateTime(2022, 6, 9, 1, 3, 16, 575, DateTimeKind.Unspecified).AddTicks(5254), 23L },
                    { 61L, 136.02m, new DateTime(2023, 12, 4, 19, 51, 8, 739, DateTimeKind.Unspecified).AddTicks(5560), false, "wmcdbjgysdsp6fe8", new DateTime(2023, 4, 23, 23, 49, 39, 212, DateTimeKind.Unspecified).AddTicks(6963), new DateTime(2023, 1, 14, 13, 46, 35, 349, DateTimeKind.Unspecified).AddTicks(148), 1, new DateTime(2023, 7, 3, 22, 0, 7, 260, DateTimeKind.Unspecified).AddTicks(2622), 40L },
                    { 62L, 151.37m, new DateTime(2023, 10, 27, 7, 3, 7, 519, DateTimeKind.Unspecified).AddTicks(3620), true, "i6bqfv7n7ei52dtg", new DateTime(2023, 6, 17, 8, 2, 59, 997, DateTimeKind.Unspecified).AddTicks(4035), new DateTime(2022, 1, 29, 5, 48, 32, 363, DateTimeKind.Unspecified).AddTicks(7727), 2, new DateTime(2022, 5, 29, 10, 7, 40, 975, DateTimeKind.Unspecified).AddTicks(3036), 10L },
                    { 63L, 136.02m, new DateTime(2024, 5, 23, 15, 42, 59, 641, DateTimeKind.Unspecified).AddTicks(2094), false, "va8nr6u4vqv58pix", new DateTime(2023, 6, 26, 1, 20, 6, 753, DateTimeKind.Unspecified).AddTicks(4666), new DateTime(2022, 11, 22, 14, 24, 1, 123, DateTimeKind.Unspecified).AddTicks(9646), 1, new DateTime(2023, 1, 26, 23, 10, 4, 852, DateTimeKind.Unspecified).AddTicks(8531), 7L },
                    { 64L, 151.37m, new DateTime(2022, 1, 5, 14, 4, 17, 52, DateTimeKind.Unspecified).AddTicks(5193), false, "7779iv8ah6v5mjw1", new DateTime(2021, 7, 8, 19, 32, 48, 916, DateTimeKind.Unspecified).AddTicks(9239), new DateTime(2020, 7, 12, 3, 0, 3, 501, DateTimeKind.Unspecified).AddTicks(685), 2, new DateTime(2022, 8, 15, 14, 8, 51, 12, DateTimeKind.Unspecified).AddTicks(6510), 23L },
                    { 65L, 151.37m, new DateTime(2023, 8, 26, 22, 8, 37, 0, DateTimeKind.Unspecified).AddTicks(5610), false, "tbp7qw8m3mfjyklz", new DateTime(2022, 10, 29, 7, 3, 8, 262, DateTimeKind.Unspecified).AddTicks(9102), new DateTime(2022, 10, 10, 15, 47, 6, 695, DateTimeKind.Unspecified).AddTicks(5663), 2, new DateTime(2023, 1, 30, 16, 28, 2, 521, DateTimeKind.Unspecified).AddTicks(8565), 21L },
                    { 66L, 136.02m, new DateTime(2023, 9, 17, 2, 40, 26, 928, DateTimeKind.Unspecified).AddTicks(2995), true, "8g7ixv4jzog650kl", new DateTime(2023, 8, 11, 1, 33, 28, 53, DateTimeKind.Unspecified).AddTicks(936), new DateTime(2016, 7, 29, 23, 44, 4, 415, DateTimeKind.Unspecified).AddTicks(8566), 1, new DateTime(2019, 3, 8, 1, 3, 7, 88, DateTimeKind.Unspecified).AddTicks(2964), 38L },
                    { 67L, 91.86m, new DateTime(2022, 10, 18, 10, 7, 22, 947, DateTimeKind.Unspecified).AddTicks(4423), true, "sbtx06pg02z9opp8", new DateTime(2022, 9, 9, 7, 48, 37, 362, DateTimeKind.Unspecified).AddTicks(4620), new DateTime(2022, 4, 20, 9, 1, 44, 855, DateTimeKind.Unspecified).AddTicks(8409), 3, new DateTime(2022, 11, 10, 9, 32, 14, 554, DateTimeKind.Unspecified).AddTicks(2877), 20L },
                    { 68L, 91.86m, new DateTime(2022, 11, 26, 14, 53, 19, 828, DateTimeKind.Unspecified).AddTicks(4090), true, "z24labjvd7qm17jt", new DateTime(2022, 11, 9, 13, 8, 22, 306, DateTimeKind.Unspecified).AddTicks(2978), new DateTime(2022, 10, 14, 16, 54, 11, 465, DateTimeKind.Unspecified).AddTicks(7256), 3, new DateTime(2023, 1, 17, 5, 37, 54, 748, DateTimeKind.Unspecified).AddTicks(7893), 39L },
                    { 69L, 136.02m, new DateTime(2024, 5, 22, 17, 37, 26, 235, DateTimeKind.Unspecified).AddTicks(1878), true, "jti7tswdhcxx146p", new DateTime(2023, 5, 27, 4, 50, 58, 252, DateTimeKind.Unspecified).AddTicks(6623), new DateTime(2023, 3, 9, 14, 2, 21, 957, DateTimeKind.Unspecified).AddTicks(4922), 1, new DateTime(2023, 3, 23, 13, 34, 17, 530, DateTimeKind.Unspecified).AddTicks(3766), 23L },
                    { 70L, 151.37m, new DateTime(2022, 5, 18, 14, 53, 15, 396, DateTimeKind.Unspecified).AddTicks(4256), false, "dqb49qfp6v2htb1l", new DateTime(2022, 2, 3, 17, 9, 27, 159, DateTimeKind.Unspecified).AddTicks(1059), new DateTime(2018, 4, 23, 2, 39, 24, 364, DateTimeKind.Unspecified).AddTicks(13), 2, new DateTime(2021, 7, 21, 6, 2, 23, 789, DateTimeKind.Unspecified).AddTicks(9393), 13L },
                    { 71L, 136.02m, new DateTime(2023, 4, 28, 3, 42, 3, 284, DateTimeKind.Unspecified).AddTicks(829), true, "tfjxef8gm7u3gr4q", new DateTime(2023, 4, 3, 23, 32, 39, 64, DateTimeKind.Unspecified).AddTicks(6995), new DateTime(2023, 3, 5, 11, 57, 27, 648, DateTimeKind.Unspecified).AddTicks(6375), 1, new DateTime(2023, 6, 29, 22, 31, 36, 663, DateTimeKind.Unspecified).AddTicks(7736), 37L },
                    { 72L, 151.37m, new DateTime(2024, 1, 18, 9, 59, 46, 248, DateTimeKind.Unspecified).AddTicks(9577), false, "2b5myh0ryhbt7haq", new DateTime(2023, 7, 22, 1, 45, 38, 679, DateTimeKind.Unspecified).AddTicks(8806), new DateTime(2023, 6, 5, 9, 10, 53, 225, DateTimeKind.Unspecified).AddTicks(6854), 2, new DateTime(2023, 8, 19, 5, 54, 20, 806, DateTimeKind.Unspecified).AddTicks(3503), 26L },
                    { 73L, 136.02m, new DateTime(2023, 12, 23, 12, 23, 35, 334, DateTimeKind.Unspecified).AddTicks(4488), true, "8ds2vlr4ibv39lh4", new DateTime(2023, 7, 5, 17, 11, 34, 337, DateTimeKind.Unspecified).AddTicks(533), new DateTime(2020, 10, 3, 20, 13, 47, 742, DateTimeKind.Unspecified).AddTicks(2335), 1, new DateTime(2021, 8, 20, 16, 34, 40, 103, DateTimeKind.Unspecified).AddTicks(9226), 9L },
                    { 74L, 136.02m, new DateTime(2023, 11, 15, 4, 59, 46, 306, DateTimeKind.Unspecified).AddTicks(2868), true, "xzjgtbq46mekoxwc", new DateTime(2023, 4, 2, 17, 49, 50, 91, DateTimeKind.Unspecified).AddTicks(1422), new DateTime(2019, 8, 27, 18, 25, 18, 459, DateTimeKind.Unspecified).AddTicks(2700), 1, new DateTime(2020, 6, 10, 0, 2, 5, 25, DateTimeKind.Unspecified).AddTicks(4194), 30L },
                    { 75L, 91.86m, new DateTime(2023, 9, 3, 8, 0, 6, 623, DateTimeKind.Unspecified).AddTicks(5358), true, "4qdes62xud4v2bb7", new DateTime(2023, 6, 16, 16, 56, 33, 450, DateTimeKind.Unspecified).AddTicks(8185), new DateTime(2023, 2, 17, 13, 18, 46, 213, DateTimeKind.Unspecified).AddTicks(7836), 3, new DateTime(2023, 8, 6, 19, 25, 21, 125, DateTimeKind.Unspecified).AddTicks(7554), 24L },
                    { 76L, 151.37m, new DateTime(2023, 8, 26, 22, 35, 17, 843, DateTimeKind.Unspecified).AddTicks(1815), true, "6s7a0msqiic2ybbz", new DateTime(2022, 10, 31, 15, 43, 44, 555, DateTimeKind.Unspecified).AddTicks(7840), new DateTime(2022, 6, 29, 10, 16, 25, 980, DateTimeKind.Unspecified).AddTicks(4538), 2, new DateTime(2022, 7, 13, 2, 53, 27, 575, DateTimeKind.Unspecified).AddTicks(1512), 23L },
                    { 77L, 151.37m, new DateTime(2022, 9, 21, 16, 42, 37, 495, DateTimeKind.Unspecified).AddTicks(9986), true, "u2bu9ut7a380yrw7", new DateTime(2021, 10, 4, 10, 0, 10, 913, DateTimeKind.Unspecified).AddTicks(7833), new DateTime(2019, 6, 6, 10, 28, 14, 592, DateTimeKind.Unspecified).AddTicks(856), 2, new DateTime(2020, 7, 9, 22, 26, 42, 373, DateTimeKind.Unspecified).AddTicks(437), 24L },
                    { 78L, 136.02m, new DateTime(2023, 9, 16, 7, 44, 40, 926, DateTimeKind.Unspecified).AddTicks(4917), false, "gx2r65g5hsfxbxgo", new DateTime(2023, 8, 17, 20, 36, 15, 394, DateTimeKind.Unspecified).AddTicks(578), new DateTime(2023, 7, 20, 10, 24, 26, 344, DateTimeKind.Unspecified).AddTicks(9786), 1, null, 28L },
                    { 79L, 136.02m, new DateTime(2021, 4, 12, 11, 24, 38, 780, DateTimeKind.Unspecified).AddTicks(5060), false, "jjpfoqglt2ecr215", new DateTime(2020, 12, 7, 12, 27, 3, 787, DateTimeKind.Unspecified).AddTicks(6338), new DateTime(2020, 5, 31, 12, 35, 46, 461, DateTimeKind.Unspecified).AddTicks(9415), 1, new DateTime(2023, 7, 25, 19, 19, 3, 958, DateTimeKind.Unspecified).AddTicks(7764), 27L },
                    { 80L, 91.86m, new DateTime(2022, 6, 5, 18, 49, 13, 832, DateTimeKind.Unspecified).AddTicks(7878), false, "xnuthf65wa7mg0gr", new DateTime(2021, 11, 26, 10, 18, 40, 412, DateTimeKind.Unspecified).AddTicks(4090), new DateTime(2021, 4, 26, 11, 24, 58, 796, DateTimeKind.Unspecified).AddTicks(5920), 3, new DateTime(2021, 7, 29, 14, 19, 0, 354, DateTimeKind.Unspecified).AddTicks(7225), 14L },
                    { 81L, 136.02m, new DateTime(2023, 4, 26, 18, 57, 49, 364, DateTimeKind.Unspecified).AddTicks(1937), false, "3m6zsvfkn1i0vm3e", new DateTime(2022, 6, 17, 14, 26, 4, 669, DateTimeKind.Unspecified).AddTicks(3205), new DateTime(2021, 5, 4, 11, 52, 50, 363, DateTimeKind.Unspecified).AddTicks(1109), 1, new DateTime(2022, 4, 13, 18, 2, 59, 306, DateTimeKind.Unspecified).AddTicks(7984), 36L },
                    { 82L, 151.37m, new DateTime(2024, 2, 17, 12, 43, 56, 611, DateTimeKind.Unspecified).AddTicks(2563), false, "mrtium4tr7pv86d0", new DateTime(2023, 8, 15, 14, 3, 46, 826, DateTimeKind.Unspecified).AddTicks(1935), new DateTime(2023, 8, 10, 9, 57, 29, 376, DateTimeKind.Unspecified).AddTicks(2315), 2, new DateTime(2023, 8, 16, 1, 51, 6, 581, DateTimeKind.Unspecified).AddTicks(229), 34L },
                    { 83L, 91.86m, new DateTime(2024, 2, 8, 6, 38, 17, 821, DateTimeKind.Unspecified).AddTicks(2130), false, "qpd9nfspxjd01xp0", new DateTime(2023, 3, 11, 13, 38, 4, 388, DateTimeKind.Unspecified).AddTicks(4538), new DateTime(2022, 4, 15, 18, 4, 10, 814, DateTimeKind.Unspecified).AddTicks(1464), 3, new DateTime(2022, 8, 6, 3, 53, 6, 267, DateTimeKind.Unspecified).AddTicks(7325), 37L },
                    { 84L, 136.02m, new DateTime(2024, 6, 6, 5, 51, 44, 927, DateTimeKind.Unspecified).AddTicks(7039), false, "wfn8fa46w4r59v5c", new DateTime(2023, 8, 11, 11, 0, 51, 441, DateTimeKind.Unspecified).AddTicks(4786), new DateTime(2023, 7, 14, 1, 56, 44, 941, DateTimeKind.Unspecified).AddTicks(6883), 1, new DateTime(2023, 7, 28, 10, 25, 27, 734, DateTimeKind.Unspecified).AddTicks(4897), 18L },
                    { 85L, 136.02m, new DateTime(2023, 9, 20, 6, 8, 6, 888, DateTimeKind.Unspecified).AddTicks(2449), true, "wyht67sijod7rj9m", new DateTime(2023, 7, 23, 14, 6, 42, 982, DateTimeKind.Unspecified).AddTicks(7924), new DateTime(2022, 4, 15, 12, 46, 20, 58, DateTimeKind.Unspecified).AddTicks(9359), 1, new DateTime(2023, 1, 21, 5, 13, 36, 987, DateTimeKind.Unspecified).AddTicks(6972), 17L },
                    { 86L, 136.02m, new DateTime(2023, 2, 6, 13, 38, 9, 638, DateTimeKind.Unspecified).AddTicks(4676), false, "jx8v9gvjgqbhtb0p", new DateTime(2022, 8, 4, 4, 17, 24, 81, DateTimeKind.Unspecified).AddTicks(9410), new DateTime(2021, 2, 23, 8, 25, 16, 81, DateTimeKind.Unspecified).AddTicks(4270), 1, new DateTime(2023, 6, 29, 18, 41, 53, 841, DateTimeKind.Unspecified).AddTicks(3173), 13L },
                    { 87L, 91.86m, new DateTime(2023, 4, 8, 13, 40, 18, 914, DateTimeKind.Unspecified).AddTicks(1448), true, "rcan81qc7fa8yw83", new DateTime(2023, 1, 13, 4, 10, 29, 202, DateTimeKind.Unspecified).AddTicks(1707), new DateTime(2023, 1, 5, 18, 49, 6, 690, DateTimeKind.Unspecified).AddTicks(8104), 3, new DateTime(2023, 7, 2, 16, 59, 13, 231, DateTimeKind.Unspecified).AddTicks(1591), 33L },
                    { 88L, 91.86m, new DateTime(2022, 11, 8, 18, 3, 56, 186, DateTimeKind.Unspecified).AddTicks(2435), true, "5emwz6jldc4x58af", new DateTime(2022, 10, 26, 1, 1, 40, 437, DateTimeKind.Unspecified).AddTicks(6721), new DateTime(2022, 4, 24, 15, 29, 39, 139, DateTimeKind.Unspecified).AddTicks(2283), 3, new DateTime(2023, 5, 7, 6, 39, 7, 537, DateTimeKind.Unspecified).AddTicks(5584), 40L },
                    { 89L, 91.86m, new DateTime(2024, 5, 7, 19, 24, 13, 131, DateTimeKind.Unspecified).AddTicks(4407), false, "1hro6jnzj7hueud0", new DateTime(2023, 7, 22, 13, 44, 45, 676, DateTimeKind.Unspecified).AddTicks(2646), new DateTime(2023, 5, 27, 12, 48, 57, 506, DateTimeKind.Unspecified).AddTicks(6659), 3, new DateTime(2023, 6, 23, 20, 1, 18, 96, DateTimeKind.Unspecified).AddTicks(5670), 37L }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "Cost", "EndDate", "IsActive", "PaymentSubscriptionId", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate", "UserId" },
                values: new object[,]
                {
                    { 90L, 136.02m, new DateTime(2024, 5, 20, 3, 23, 26, 648, DateTimeKind.Unspecified).AddTicks(8825), true, "jb19he1dn7vheueu", new DateTime(2023, 8, 17, 19, 34, 33, 494, DateTimeKind.Unspecified).AddTicks(5248), new DateTime(2023, 5, 25, 9, 0, 49, 918, DateTimeKind.Unspecified).AddTicks(1801), 1, null, 28L },
                    { 91L, 136.02m, new DateTime(2023, 9, 4, 11, 12, 6, 512, DateTimeKind.Unspecified).AddTicks(8030), true, "l9hcw3mpj65vhei4", new DateTime(2022, 9, 8, 4, 21, 44, 567, DateTimeKind.Unspecified).AddTicks(7665), new DateTime(2022, 6, 12, 12, 32, 45, 24, DateTimeKind.Unspecified).AddTicks(6954), 1, new DateTime(2023, 7, 5, 7, 25, 51, 733, DateTimeKind.Unspecified).AddTicks(8916), 7L },
                    { 92L, 136.02m, new DateTime(2024, 1, 6, 12, 57, 30, 271, DateTimeKind.Unspecified).AddTicks(9834), true, "a0yox0t3avo8xphk", new DateTime(2023, 5, 2, 13, 5, 19, 493, DateTimeKind.Unspecified).AddTicks(9406), new DateTime(2023, 3, 30, 7, 33, 21, 402, DateTimeKind.Unspecified).AddTicks(9860), 1, new DateTime(2023, 6, 17, 18, 19, 29, 348, DateTimeKind.Unspecified).AddTicks(8794), 24L },
                    { 93L, 136.02m, new DateTime(2023, 5, 14, 20, 17, 35, 228, DateTimeKind.Unspecified).AddTicks(3443), true, "m8rn9t5pne2v4ysj", new DateTime(2022, 8, 25, 0, 35, 44, 554, DateTimeKind.Unspecified).AddTicks(9582), new DateTime(2021, 2, 8, 2, 8, 28, 943, DateTimeKind.Unspecified).AddTicks(4184), 1, new DateTime(2021, 10, 19, 13, 33, 36, 793, DateTimeKind.Unspecified).AddTicks(9345), 15L },
                    { 94L, 91.86m, new DateTime(2023, 3, 3, 4, 5, 8, 357, DateTimeKind.Unspecified).AddTicks(8944), false, "mmluyddqoo1o85th", new DateTime(2022, 7, 16, 13, 26, 25, 764, DateTimeKind.Unspecified).AddTicks(8619), new DateTime(2021, 4, 11, 8, 55, 6, 590, DateTimeKind.Unspecified).AddTicks(6234), 3, new DateTime(2022, 9, 8, 5, 4, 40, 372, DateTimeKind.Unspecified).AddTicks(9122), 30L },
                    { 95L, 136.02m, new DateTime(2023, 5, 4, 21, 17, 58, 105, DateTimeKind.Unspecified).AddTicks(6882), true, "cevlzqkc2a1n7br9", new DateTime(2022, 6, 11, 11, 50, 16, 323, DateTimeKind.Unspecified).AddTicks(5775), new DateTime(2021, 6, 8, 4, 27, 52, 148, DateTimeKind.Unspecified).AddTicks(4390), 1, new DateTime(2021, 9, 2, 20, 38, 13, 980, DateTimeKind.Unspecified).AddTicks(7717), 2L },
                    { 96L, 91.86m, new DateTime(2023, 9, 11, 9, 45, 2, 718, DateTimeKind.Unspecified).AddTicks(2462), true, "93vrpnu06yhjisrx", new DateTime(2023, 7, 31, 2, 9, 12, 699, DateTimeKind.Unspecified).AddTicks(7739), new DateTime(2022, 7, 28, 10, 42, 33, 565, DateTimeKind.Unspecified).AddTicks(709), 3, new DateTime(2022, 10, 3, 13, 1, 52, 145, DateTimeKind.Unspecified).AddTicks(4014), 5L },
                    { 97L, 136.02m, new DateTime(2023, 6, 23, 7, 38, 2, 15, DateTimeKind.Unspecified).AddTicks(3798), true, "7biaezr83ocwvtne", new DateTime(2022, 8, 29, 18, 19, 18, 763, DateTimeKind.Unspecified).AddTicks(6884), new DateTime(2022, 4, 23, 20, 30, 0, 635, DateTimeKind.Unspecified).AddTicks(359), 1, new DateTime(2022, 8, 2, 4, 24, 20, 693, DateTimeKind.Unspecified).AddTicks(7638), 19L },
                    { 98L, 136.02m, new DateTime(2023, 10, 18, 12, 3, 49, 7, DateTimeKind.Unspecified).AddTicks(1464), true, "k9c7hc23tgje5jm7", new DateTime(2023, 5, 12, 8, 20, 37, 141, DateTimeKind.Unspecified).AddTicks(9389), new DateTime(2021, 11, 21, 0, 55, 31, 214, DateTimeKind.Unspecified).AddTicks(991), 1, new DateTime(2023, 5, 25, 2, 3, 49, 312, DateTimeKind.Unspecified).AddTicks(1330), 8L },
                    { 99L, 136.02m, new DateTime(2020, 5, 15, 15, 11, 55, 109, DateTimeKind.Unspecified).AddTicks(2067), false, "17h3p0lzj9p4mkrq", new DateTime(2020, 2, 11, 11, 57, 59, 772, DateTimeKind.Unspecified).AddTicks(3522), new DateTime(2017, 9, 19, 15, 45, 19, 693, DateTimeKind.Unspecified).AddTicks(6931), 1, new DateTime(2019, 3, 31, 19, 4, 10, 699, DateTimeKind.Unspecified).AddTicks(8700), 24L },
                    { 100L, 151.37m, new DateTime(2024, 5, 20, 12, 58, 12, 364, DateTimeKind.Unspecified).AddTicks(1022), false, "ea2krxtp615avzdt", new DateTime(2023, 7, 23, 18, 29, 41, 744, DateTimeKind.Unspecified).AddTicks(598), new DateTime(2022, 12, 6, 5, 47, 12, 369, DateTimeKind.Unspecified).AddTicks(231), 2, new DateTime(2023, 4, 14, 18, 54, 27, 604, DateTimeKind.Unspecified).AddTicks(4840), 35L },
                    { 101L, 136.02m, new DateTime(2023, 12, 29, 18, 17, 5, 938, DateTimeKind.Unspecified).AddTicks(1679), false, "hp86so1sykofx18m", new DateTime(2023, 7, 31, 6, 16, 45, 223, DateTimeKind.Unspecified).AddTicks(4341), new DateTime(2023, 6, 27, 3, 56, 51, 449, DateTimeKind.Unspecified).AddTicks(8588), 1, new DateTime(2023, 7, 24, 11, 50, 31, 119, DateTimeKind.Unspecified).AddTicks(8008), 19L },
                    { 102L, 151.37m, new DateTime(2023, 1, 31, 2, 30, 1, 617, DateTimeKind.Unspecified).AddTicks(555), false, "v9jped3wpf21omxi", new DateTime(2022, 10, 11, 3, 34, 16, 16, DateTimeKind.Unspecified).AddTicks(7503), new DateTime(2022, 5, 28, 12, 51, 9, 327, DateTimeKind.Unspecified).AddTicks(3910), 2, new DateTime(2023, 8, 9, 18, 55, 15, 883, DateTimeKind.Unspecified).AddTicks(1621), 40L },
                    { 103L, 91.86m, new DateTime(2024, 3, 5, 13, 33, 53, 269, DateTimeKind.Unspecified).AddTicks(9560), false, "a7ftky80unai4cdk", new DateTime(2023, 3, 19, 7, 33, 53, 478, DateTimeKind.Unspecified).AddTicks(9973), new DateTime(2022, 10, 3, 14, 38, 16, 78, DateTimeKind.Unspecified).AddTicks(7697), 3, new DateTime(2022, 12, 12, 1, 27, 34, 374, DateTimeKind.Unspecified).AddTicks(2247), 20L },
                    { 104L, 136.02m, new DateTime(2021, 5, 31, 1, 28, 45, 5, DateTimeKind.Unspecified).AddTicks(3347), false, "2fl25kawdqe7y9cr", new DateTime(2021, 1, 27, 8, 38, 5, 749, DateTimeKind.Unspecified).AddTicks(631), new DateTime(2020, 12, 28, 9, 26, 9, 325, DateTimeKind.Unspecified).AddTicks(2428), 1, new DateTime(2022, 2, 1, 6, 37, 34, 745, DateTimeKind.Unspecified).AddTicks(8526), 8L },
                    { 105L, 151.37m, new DateTime(2023, 3, 13, 19, 34, 44, 968, DateTimeKind.Unspecified).AddTicks(6162), true, "yrti9du39mr5c5va", new DateTime(2022, 4, 4, 22, 38, 56, 126, DateTimeKind.Unspecified).AddTicks(1808), new DateTime(2021, 5, 24, 13, 47, 12, 255, DateTimeKind.Unspecified).AddTicks(1171), 2, new DateTime(2021, 10, 18, 17, 41, 27, 3, DateTimeKind.Unspecified).AddTicks(9823), 14L },
                    { 106L, 136.02m, new DateTime(2023, 12, 29, 13, 20, 19, 74, DateTimeKind.Unspecified).AddTicks(5155), true, "fybw1xhn0y3drrm0", new DateTime(2023, 6, 25, 1, 1, 23, 88, DateTimeKind.Unspecified).AddTicks(5825), new DateTime(2023, 5, 25, 13, 59, 0, 116, DateTimeKind.Unspecified).AddTicks(9561), 1, new DateTime(2023, 6, 12, 21, 2, 58, 128, DateTimeKind.Unspecified).AddTicks(4946), 36L },
                    { 107L, 136.02m, new DateTime(2019, 11, 2, 4, 48, 51, 530, DateTimeKind.Unspecified).AddTicks(633), false, "6voy90ps5l3b1y1b", new DateTime(2019, 10, 6, 16, 17, 34, 948, DateTimeKind.Unspecified).AddTicks(3079), new DateTime(2017, 2, 10, 15, 43, 54, 263, DateTimeKind.Unspecified).AddTicks(4961), 1, new DateTime(2020, 5, 7, 11, 23, 8, 281, DateTimeKind.Unspecified).AddTicks(3698), 6L },
                    { 108L, 136.02m, new DateTime(2022, 12, 16, 15, 44, 18, 604, DateTimeKind.Unspecified).AddTicks(5360), false, "r4im89p8kap58jd0", new DateTime(2022, 4, 11, 17, 38, 21, 615, DateTimeKind.Unspecified).AddTicks(2196), new DateTime(2022, 1, 2, 7, 22, 50, 592, DateTimeKind.Unspecified).AddTicks(2909), 1, new DateTime(2022, 7, 8, 2, 16, 12, 135, DateTimeKind.Unspecified).AddTicks(3840), 10L },
                    { 109L, 91.86m, new DateTime(2023, 8, 18, 22, 33, 20, 991, DateTimeKind.Unspecified).AddTicks(332), false, "9l7e2zypb364i3jv", new DateTime(2023, 5, 21, 13, 1, 38, 84, DateTimeKind.Unspecified).AddTicks(4608), new DateTime(2022, 7, 30, 23, 19, 43, 24, DateTimeKind.Unspecified).AddTicks(3901), 3, new DateTime(2023, 7, 11, 3, 52, 13, 23, DateTimeKind.Unspecified).AddTicks(5981), 35L },
                    { 110L, 136.02m, new DateTime(2023, 8, 9, 0, 50, 38, 141, DateTimeKind.Unspecified).AddTicks(1299), true, "p45radwg6kdm2a5k", new DateTime(2023, 4, 4, 10, 33, 28, 726, DateTimeKind.Unspecified).AddTicks(8813), new DateTime(2023, 3, 13, 11, 36, 59, 796, DateTimeKind.Unspecified).AddTicks(2870), 1, new DateTime(2023, 4, 23, 10, 40, 39, 610, DateTimeKind.Unspecified).AddTicks(1387), 14L }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "InitialSolution", "LanguageId", "Status" },
                values: new object[,]
                {
                    { 1L, 59L, "Doloribus modi voluptatum facere eius rerum provident nemo soluta quidem.", new DateTime(2022, 6, 29, 13, 25, 57, 757, DateTimeKind.Unspecified).AddTicks(2807), "Eos quae aliquid qui est sit quidem doloribus.", 2, 1 },
                    { 2L, 8L, "repellendus", new DateTime(2022, 11, 30, 7, 51, 31, 57, DateTimeKind.Unspecified).AddTicks(5055), "Deleniti iusto aut nesciunt modi et quibusdam corrupti nisi est.", 2, 2 },
                    { 3L, 59L, "alias", new DateTime(2022, 2, 16, 12, 46, 29, 791, DateTimeKind.Unspecified).AddTicks(229), "Explicabo autem cum.", 2, 0 },
                    { 4L, 11L, "Eos molestias adipisci id dolores et fugit vero vitae.\nOdit aspernatur amet maxime.\nEt vel voluptatum quia quia nesciunt sequi impedit.\nVoluptas repellat nam omnis est magnam rerum eum repudiandae minima.\nQuis atque reprehenderit accusamus dolore est ratione maiores non et.", new DateTime(2023, 5, 17, 6, 26, 17, 517, DateTimeKind.Unspecified).AddTicks(4028), "Voluptates facilis nisi voluptatem omnis inventore velit ipsum.", 3, 1 },
                    { 5L, 68L, "Dolores in error magni eum dolore minima amet voluptates temporibus. Magni nihil est officiis ducimus aut. Sit dicta ullam nulla. Cumque minima accusamus magnam quia laudantium.", new DateTime(2022, 8, 31, 23, 21, 42, 416, DateTimeKind.Unspecified).AddTicks(273), "Eum eligendi dolorum qui cum voluptatibus.", 3, 1 },
                    { 6L, 51L, "Corrupti iusto ipsam sapiente.\nMaxime alias nam.\nLaborum eius mollitia quis perferendis et pariatur sapiente repellat.", new DateTime(2023, 5, 4, 1, 39, 5, 282, DateTimeKind.Unspecified).AddTicks(5801), "Id nulla nesciunt perferendis nesciunt minima.", 1, 1 },
                    { 7L, 70L, "Delectus voluptates dolorem laudantium laudantium.\nSequi officiis sapiente et ducimus fugiat exercitationem dolorem adipisci veniam.\nQuidem earum tempore molestias commodi eaque.\nPorro impedit libero aut.\nExpedita expedita est fugit mollitia aut ab eum.\nQuaerat consequatur distinctio illo maiores sit molestiae.", new DateTime(2023, 8, 7, 1, 45, 41, 949, DateTimeKind.Unspecified).AddTicks(25), "Hic et officiis accusantium nostrum repellat aut et error itaque.", 1, 3 },
                    { 8L, 47L, "Enim aliquid neque nemo dolore possimus quisquam optio veniam. Qui nulla vel in. Blanditiis vel sit. Cupiditate quo quo doloribus sunt unde ex doloremque necessitatibus. Veniam dolor officiis eos molestias explicabo enim necessitatibus soluta.", new DateTime(2022, 10, 31, 18, 30, 38, 62, DateTimeKind.Unspecified).AddTicks(8841), "Aut ullam distinctio tempora omnis animi officiis.", 4, 1 },
                    { 9L, 16L, "at", new DateTime(2021, 8, 7, 21, 21, 27, 513, DateTimeKind.Unspecified).AddTicks(3900), "Libero dolorem voluptatem et vitae eius nemo.", 1, 0 },
                    { 10L, 32L, "Culpa maiores officiis deleniti cumque similique optio et sed ab. Quis voluptatem et veniam iusto rerum. Provident inventore voluptas nihil rerum totam expedita hic. Sint rerum earum facilis iusto unde nihil officia minima. Id occaecati quod. Laborum illo ipsum fuga ratione ipsa sequi.", new DateTime(2023, 6, 16, 7, 35, 28, 580, DateTimeKind.Unspecified).AddTicks(8279), "Architecto omnis necessitatibus est eum.", 2, 3 },
                    { 11L, 65L, "Omnis ea quia ea voluptatibus id laborum sit consequatur. Nisi voluptatem temporibus sed porro est. Voluptas excepturi et expedita dignissimos et. Atque aut est et. Recusandae rerum dolor assumenda maiores placeat magnam debitis. Facilis velit et qui totam et iusto consequatur ut.", new DateTime(2022, 11, 8, 4, 36, 39, 230, DateTimeKind.Unspecified).AddTicks(7978), "Itaque quidem debitis nisi voluptate.", 2, 0 },
                    { 12L, 63L, "Dolorum architecto placeat error eum aut repellendus. Est cumque velit aspernatur voluptatum fugiat. Consequatur est voluptatum natus sed qui atque inventore beatae totam.", new DateTime(2023, 3, 6, 18, 32, 38, 581, DateTimeKind.Unspecified).AddTicks(2670), "Enim nulla explicabo suscipit molestiae perferendis et.", 4, 1 },
                    { 13L, 3L, "Blanditiis quia commodi non quis voluptatem.\nNatus quis dignissimos ipsam et.\nDolores perferendis libero aspernatur praesentium sint.\nEos et at iusto illum.\nHarum in ab at at dolorem qui.", new DateTime(2023, 6, 23, 13, 30, 54, 832, DateTimeKind.Unspecified).AddTicks(9660), "Pariatur voluptas veniam rerum sed qui ipsam accusamus fuga.", 3, 3 },
                    { 14L, 58L, "Ea atque et eum est est.", new DateTime(2022, 10, 2, 12, 44, 30, 876, DateTimeKind.Unspecified).AddTicks(4141), "Omnis et illo voluptas culpa.", 1, 0 },
                    { 15L, 21L, "Quos laboriosam porro aut consequuntur a voluptas.", new DateTime(2022, 6, 14, 18, 12, 59, 804, DateTimeKind.Unspecified).AddTicks(9901), "Voluptatem non reprehenderit dolor et dolor molestias.", 4, 1 },
                    { 16L, 49L, "ea", new DateTime(2023, 3, 25, 9, 41, 50, 61, DateTimeKind.Unspecified).AddTicks(3955), "Ducimus maiores praesentium odit error.", 1, 0 },
                    { 17L, 3L, "Ratione illum a voluptatem assumenda. Quaerat est recusandae aliquam provident molestiae rerum eius accusamus rerum. Cum et officia odit aliquid saepe corrupti repellat aliquid dolorum. Quia voluptatibus dolores nostrum ab quia dolor.", new DateTime(2023, 4, 4, 11, 53, 49, 291, DateTimeKind.Unspecified).AddTicks(8252), "Atque similique dolor eos est.", 3, 1 },
                    { 18L, 2L, "Quo non aspernatur recusandae soluta ratione quibusdam et.", new DateTime(2022, 12, 6, 3, 25, 25, 19, DateTimeKind.Unspecified).AddTicks(3228), "Recusandae quo voluptatem odio rem esse quam.", 2, 1 },
                    { 19L, 38L, "Totam expedita reprehenderit sed blanditiis. Qui non aliquid. Suscipit ab eaque ea consequatur aut eum impedit natus. Sint magnam incidunt velit adipisci voluptatem.", new DateTime(2018, 12, 30, 7, 13, 32, 646, DateTimeKind.Unspecified).AddTicks(1672), "Sint tenetur sed et debitis qui eaque labore.", 1, 2 },
                    { 20L, 30L, "Odio corrupti asperiores nulla dolor ut.\nAut molestias pariatur.\nProvident ex beatae nihil numquam nihil adipisci consequatur.\nDolor quae sit consequuntur.", new DateTime(2021, 12, 24, 20, 4, 9, 183, DateTimeKind.Unspecified).AddTicks(9921), "Et iusto possimus laudantium accusantium possimus.", 2, 2 },
                    { 21L, 40L, "Ut doloremque facere similique.", new DateTime(2021, 12, 16, 3, 8, 37, 738, DateTimeKind.Unspecified).AddTicks(4687), "Nisi eius repellendus labore aut aut molestiae quaerat iure voluptatem.", 4, 1 },
                    { 22L, 2L, "Et dignissimos omnis veniam.\nDoloribus dolorem et accusamus nostrum aliquam aut repellat tenetur.\nQuia impedit ut.", new DateTime(2023, 2, 28, 1, 54, 57, 425, DateTimeKind.Unspecified).AddTicks(3971), "Animi natus deserunt voluptas.", 2, 2 },
                    { 23L, 41L, "voluptates", new DateTime(2021, 1, 7, 9, 24, 49, 803, DateTimeKind.Unspecified).AddTicks(1623), "At quaerat hic facilis quod expedita.", 2, 1 },
                    { 24L, 41L, "Error iure rerum molestiae et.", new DateTime(2023, 7, 1, 22, 48, 56, 92, DateTimeKind.Unspecified).AddTicks(4179), "Quaerat perferendis iusto ea et quia cumque harum nemo aliquam.", 2, 1 },
                    { 25L, 48L, "Optio totam architecto sequi blanditiis vero nulla perspiciatis consequatur et.\nDolor ut enim atque amet.", new DateTime(2023, 8, 1, 10, 4, 0, 564, DateTimeKind.Unspecified).AddTicks(704), "Voluptatem pariatur ut nihil aut cum vel dolorem occaecati minus.", 1, 0 },
                    { 26L, 52L, "magnam", new DateTime(2023, 7, 10, 23, 59, 36, 148, DateTimeKind.Unspecified).AddTicks(7359), "Doloribus qui perferendis odio ratione.", 2, 2 },
                    { 27L, 18L, "Commodi perferendis ut.", new DateTime(2023, 3, 20, 8, 13, 59, 996, DateTimeKind.Unspecified).AddTicks(5325), "Voluptatum amet a dolorem modi consequuntur.", 4, 2 },
                    { 28L, 69L, "Deserunt veritatis ad perferendis et nihil autem quia cupiditate.", new DateTime(2023, 6, 21, 12, 54, 26, 476, DateTimeKind.Unspecified).AddTicks(1193), "Quidem enim quae voluptatum fugit error nihil aut veritatis quo.", 1, 2 },
                    { 29L, 44L, "Aliquam ex repudiandae atque beatae odit excepturi.", new DateTime(2022, 5, 23, 6, 6, 33, 744, DateTimeKind.Unspecified).AddTicks(8490), "Maiores aut aliquid perferendis adipisci odio expedita ex nulla.", 4, 2 },
                    { 30L, 60L, "Quaerat in minus provident quae sint et dolor labore.", new DateTime(2022, 5, 29, 1, 30, 12, 868, DateTimeKind.Unspecified).AddTicks(1470), "Eius vel ut repudiandae et quis et voluptas.", 1, 1 },
                    { 31L, 53L, "Nobis ut magni harum expedita.\nVelit voluptatibus tempora explicabo quasi esse aspernatur.", new DateTime(2018, 12, 27, 21, 28, 55, 887, DateTimeKind.Unspecified).AddTicks(9891), "Aut rerum ducimus repudiandae voluptatum.", 2, 2 },
                    { 32L, 43L, "Maxime dolorem recusandae necessitatibus dolores ea velit vero laboriosam. Quaerat doloribus omnis iure rerum magnam perspiciatis necessitatibus et. Deleniti autem culpa eaque animi ut consequatur laborum laudantium. Consequatur inventore cupiditate labore voluptas officia. Ducimus aliquam eos facilis.", new DateTime(2023, 7, 10, 20, 24, 36, 274, DateTimeKind.Unspecified).AddTicks(4590), "Hic odio nostrum dicta rerum omnis voluptatem consectetur aperiam id.", 1, 2 },
                    { 33L, 38L, "Sit nulla autem hic dolore eveniet nostrum voluptatem. Et qui nulla. Velit laudantium cupiditate veritatis ex sunt aspernatur quidem voluptas non. Sit et consequatur et eius.", new DateTime(2017, 8, 27, 21, 22, 38, 312, DateTimeKind.Unspecified).AddTicks(5350), "Consequuntur autem beatae.", 4, 2 },
                    { 34L, 54L, "Voluptatem sequi aut aut nulla.", new DateTime(2023, 4, 3, 0, 29, 36, 971, DateTimeKind.Unspecified).AddTicks(8864), "Ipsa cum et.", 3, 2 },
                    { 35L, 63L, "assumenda", new DateTime(2023, 8, 6, 1, 17, 5, 65, DateTimeKind.Unspecified).AddTicks(599), "Id enim quisquam at reprehenderit beatae magnam harum.", 2, 3 },
                    { 36L, 13L, "Expedita est perferendis dolorem earum provident distinctio consequatur animi. Consectetur ipsum et et soluta vel. Est perferendis temporibus quae fugiat est consequatur quis.", new DateTime(2022, 6, 29, 2, 44, 27, 619, DateTimeKind.Unspecified).AddTicks(8301), "Ut accusamus voluptas.", 2, 0 },
                    { 37L, 47L, "Et aliquid ratione quisquam molestiae.\nCommodi qui velit incidunt nulla.\nQuod dolorem vitae consequatur qui.\nEa animi autem qui dolores laboriosam dolores.", new DateTime(2022, 8, 12, 0, 3, 59, 235, DateTimeKind.Unspecified).AddTicks(750), "Et at cum nulla rerum fuga impedit doloremque qui.", 1, 0 },
                    { 38L, 41L, "Optio consequuntur tempore est consequatur nemo odit quia perspiciatis.", new DateTime(2020, 2, 14, 19, 34, 12, 204, DateTimeKind.Unspecified).AddTicks(4911), "Nesciunt totam velit omnis ea quaerat vero est.", 3, 3 },
                    { 39L, 68L, "autem", new DateTime(2023, 6, 7, 12, 31, 31, 292, DateTimeKind.Unspecified).AddTicks(3031), "Rem cumque at consequatur tempora et facilis corporis ut iste.", 1, 1 },
                    { 40L, 38L, "Sit amet repudiandae unde excepturi ea et veniam veniam.\nNemo cumque ea ab.", new DateTime(2020, 1, 1, 5, 10, 40, 992, DateTimeKind.Unspecified).AddTicks(9590), "Et dolores quas ut.", 2, 0 },
                    { 41L, 39L, "Consequatur facilis quae.\nEaque doloribus aspernatur autem earum quos.\nExplicabo delectus expedita quisquam quam aspernatur vel animi nostrum.\nNecessitatibus itaque adipisci optio ab est pariatur.\nPariatur nostrum unde animi sed et illo ea sunt.", new DateTime(2022, 2, 10, 8, 52, 29, 161, DateTimeKind.Unspecified).AddTicks(486), "Sed et harum dolores qui optio quisquam omnis est.", 2, 0 },
                    { 42L, 65L, "reprehenderit", new DateTime(2022, 9, 17, 18, 5, 57, 675, DateTimeKind.Unspecified).AddTicks(8692), "Et dolorem sed ipsum atque reiciendis corporis blanditiis qui.", 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "InitialSolution", "LanguageId", "Status" },
                values: new object[,]
                {
                    { 43L, 37L, "libero", new DateTime(2020, 9, 18, 6, 53, 53, 483, DateTimeKind.Unspecified).AddTicks(7172), "Maiores eius dolore repellat sunt velit labore dolores nulla.", 1, 3 },
                    { 44L, 62L, "debitis", new DateTime(2022, 4, 3, 19, 0, 49, 229, DateTimeKind.Unspecified).AddTicks(6263), "Et ab enim consequatur.", 2, 1 },
                    { 45L, 18L, "Qui ipsa voluptas quia enim et.\nEa dicta numquam tempore accusamus qui atque dolorum odit non.\nMolestias optio corporis fugiat quis.\nCulpa voluptatem omnis minus deserunt.\nNemo corporis corporis rerum dolor sed omnis sapiente.", new DateTime(2023, 4, 20, 1, 35, 54, 23, DateTimeKind.Unspecified).AddTicks(8951), "Voluptate quia ut culpa ut molestias autem in sit accusamus.", 3, 1 },
                    { 46L, 35L, "nostrum", new DateTime(2022, 10, 24, 15, 11, 51, 363, DateTimeKind.Unspecified).AddTicks(58), "Asperiores et impedit tenetur voluptatem.", 2, 0 },
                    { 47L, 40L, "Vel commodi et consequatur. Molestias nihil quas omnis delectus consequatur quaerat. Vel molestias exercitationem odio. Consequatur non natus ullam voluptatem vel non quaerat omnis. Ea provident eius.", new DateTime(2022, 10, 31, 14, 10, 21, 306, DateTimeKind.Unspecified).AddTicks(5941), "Facere possimus sit maxime.", 3, 1 },
                    { 48L, 10L, "Laudantium culpa accusamus fuga. Quidem excepturi ipsa explicabo. Nemo placeat soluta qui. Maxime ut cumque.", new DateTime(2018, 9, 16, 12, 44, 4, 660, DateTimeKind.Unspecified).AddTicks(7016), "Dicta et ratione dignissimos ipsam libero id iusto nobis fugiat.", 4, 2 },
                    { 49L, 23L, "Ut hic qui dolorum dolorem repudiandae doloribus laboriosam quo eligendi. Non porro est qui magni eum dolor optio. Quidem qui cumque hic maxime. Nesciunt delectus omnis vero corporis eveniet et et in quis. Ea ut quidem eius animi. Tempora in consequatur voluptas velit cum dolore dolorum ut vitae.", new DateTime(2023, 7, 14, 15, 0, 58, 540, DateTimeKind.Unspecified).AddTicks(6574), "Qui et non saepe natus rerum consequuntur vel ducimus ducimus.", 3, 0 },
                    { 50L, 3L, "Veniam et nostrum neque dolorem totam non veritatis.", new DateTime(2023, 5, 3, 17, 5, 46, 582, DateTimeKind.Unspecified).AddTicks(6193), "Officiis non possimus voluptatem natus voluptatibus.", 1, 1 },
                    { 51L, 42L, "eaque", new DateTime(2022, 6, 23, 9, 55, 53, 923, DateTimeKind.Unspecified).AddTicks(4780), "Vel aut sapiente nostrum provident.", 4, 2 },
                    { 52L, 6L, "Voluptates voluptas fugiat. Consectetur voluptates excepturi. Voluptatem illo voluptatem laborum veniam hic.", new DateTime(2023, 8, 16, 7, 32, 36, 882, DateTimeKind.Unspecified).AddTicks(998), "Vero atque possimus.", 4, 1 },
                    { 53L, 47L, "Sit quo asperiores ut harum ut. Et ab omnis odit vitae. Autem maiores totam dolore voluptatem repellendus doloribus et beatae laudantium. Neque quos voluptates. Quis vel iure blanditiis dolorem mollitia. Est quis animi qui sed velit dolor maxime tenetur.", new DateTime(2022, 8, 23, 11, 17, 39, 445, DateTimeKind.Unspecified).AddTicks(1727), "Minus doloremque maxime aliquid molestiae nobis ut explicabo consequuntur.", 4, 1 },
                    { 54L, 55L, "Et eveniet harum labore. Est sint iure tenetur numquam dolor. Quia dolore temporibus rem suscipit excepturi dicta quas.", new DateTime(2023, 8, 15, 4, 21, 15, 822, DateTimeKind.Unspecified).AddTicks(2061), "Iusto pariatur eos sit repellat et aut autem.", 1, 2 },
                    { 55L, 15L, "Molestias natus ad quod reiciendis dolor atque.", new DateTime(2023, 6, 27, 1, 43, 3, 446, DateTimeKind.Unspecified).AddTicks(5231), "Cupiditate ad dolorem autem minus in ullam quam repellat et.", 2, 2 },
                    { 56L, 16L, "Velit repellendus ad accusamus autem facere deserunt eius illum.\nModi quia nisi quos molestiae dolorem hic consequatur omnis voluptatem.", new DateTime(2022, 10, 7, 5, 20, 51, 250, DateTimeKind.Unspecified).AddTicks(9993), "Voluptas assumenda et ut.", 3, 2 },
                    { 57L, 49L, "omnis", new DateTime(2023, 8, 20, 16, 23, 20, 570, DateTimeKind.Unspecified).AddTicks(5143), "Laboriosam a laudantium delectus sed qui quod voluptatibus illo.", 1, 3 },
                    { 58L, 9L, "Repudiandae sunt sint accusamus aliquam reiciendis consectetur sint dicta eaque.\nMagni aliquam minima atque atque qui quis reprehenderit neque.\nQuaerat repudiandae est assumenda harum omnis numquam.\nDolorem placeat et veritatis voluptatem dolorum corporis qui aut.", new DateTime(2022, 5, 30, 12, 42, 51, 591, DateTimeKind.Unspecified).AddTicks(8441), "Sapiente libero vel voluptatibus et deserunt.", 4, 2 },
                    { 59L, 8L, "Voluptas labore ut expedita dolor.", new DateTime(2022, 9, 28, 14, 8, 0, 338, DateTimeKind.Unspecified).AddTicks(5905), "Eos adipisci aliquam impedit iure saepe dolores.", 1, 2 },
                    { 60L, 65L, "Deserunt debitis et illo culpa.", new DateTime(2019, 5, 17, 3, 22, 44, 421, DateTimeKind.Unspecified).AddTicks(2189), "Quod sint quis omnis et incidunt distinctio dolor distinctio doloremque.", 3, 0 },
                    { 61L, 42L, "Aut dolor eligendi mollitia aut est sunt rerum. Voluptatum qui porro fugiat. Vel inventore facilis totam consequatur consequuntur.", new DateTime(2022, 7, 30, 18, 13, 6, 836, DateTimeKind.Unspecified).AddTicks(6396), "Eligendi ducimus repudiandae dolorem tempore.", 3, 2 },
                    { 62L, 65L, "Sunt repellat et delectus deleniti. Voluptas ducimus iusto id dignissimos dolore harum vero dolor sed. Repellat fugit nihil atque molestiae itaque excepturi praesentium qui alias.", new DateTime(2021, 7, 14, 11, 44, 9, 532, DateTimeKind.Unspecified).AddTicks(1151), "Laudantium tempora voluptas quidem labore iste eligendi illo.", 4, 0 },
                    { 63L, 2L, "eum", new DateTime(2022, 10, 12, 2, 50, 26, 224, DateTimeKind.Unspecified).AddTicks(9840), "Nihil et atque est error ipsa facilis fuga voluptatem.", 1, 3 },
                    { 64L, 10L, "Placeat itaque autem non in itaque deserunt.", new DateTime(2020, 9, 22, 19, 47, 57, 388, DateTimeKind.Unspecified).AddTicks(4823), "Inventore ex minus illo accusamus mollitia fugiat ratione veritatis.", 4, 1 },
                    { 65L, 24L, "Modi necessitatibus error corporis laborum voluptatibus eum.", new DateTime(2021, 10, 7, 17, 52, 17, 629, DateTimeKind.Unspecified).AddTicks(5470), "Et aliquid corrupti neque ut mollitia aut corrupti.", 3, 2 },
                    { 66L, 37L, "quasi", new DateTime(2023, 1, 24, 5, 8, 12, 931, DateTimeKind.Unspecified).AddTicks(455), "Eveniet est rerum porro et fugit molestiae.", 2, 2 },
                    { 67L, 41L, "Aspernatur voluptas laborum asperiores totam aperiam rerum rem eum blanditiis.\nAd sint dolorem voluptas veritatis voluptas qui vel consequatur.\nCorrupti voluptates animi reprehenderit quasi autem voluptate voluptatem excepturi.\nAut in possimus sit temporibus vel nesciunt id.", new DateTime(2021, 3, 3, 4, 10, 28, 126, DateTimeKind.Unspecified).AddTicks(631), "Vel iusto mollitia unde dolor et voluptatem tempora.", 2, 0 },
                    { 68L, 17L, "Optio omnis et sed aut est esse perferendis animi.", new DateTime(2021, 9, 25, 4, 37, 3, 591, DateTimeKind.Unspecified).AddTicks(5563), "In nesciunt beatae vel.", 2, 2 },
                    { 69L, 63L, "Laborum veritatis libero voluptatem ut doloribus velit asperiores quam.", new DateTime(2023, 2, 24, 9, 29, 19, 432, DateTimeKind.Unspecified).AddTicks(3830), "Temporibus eum officiis omnis fugiat reiciendis dolore dolorem pariatur.", 4, 0 },
                    { 70L, 41L, "Quis voluptatem perspiciatis iusto mollitia provident non rem.\nEt unde placeat doloribus consequatur.\nEum perspiciatis temporibus illo eveniet omnis.\nSed aut est dignissimos id facilis ullam.", new DateTime(2020, 3, 28, 15, 26, 3, 95, DateTimeKind.Unspecified).AddTicks(1168), "Est quis et natus sed dolores ipsa aperiam.", 3, 2 },
                    { 71L, 36L, "Mollitia hic ratione quia dolorum consequatur consectetur quibusdam nemo et.", new DateTime(2023, 8, 16, 13, 40, 32, 242, DateTimeKind.Unspecified).AddTicks(6073), "Rerum tempore et natus dolorem.", 1, 2 },
                    { 72L, 52L, "Porro nihil minus sapiente voluptatibus delectus est. Neque rerum aut recusandae maiores harum esse nulla doloribus dolore. Alias expedita quis magnam rem.", new DateTime(2023, 5, 10, 15, 9, 10, 309, DateTimeKind.Unspecified).AddTicks(8969), "Velit iusto eum voluptatem molestiae quis ipsum officia.", 2, 2 },
                    { 73L, 37L, "Minima qui dolorum qui illo tempora et.", new DateTime(2021, 11, 28, 10, 11, 22, 257, DateTimeKind.Unspecified).AddTicks(4146), "Molestiae commodi modi magni dicta explicabo assumenda veritatis.", 4, 2 },
                    { 74L, 19L, "Voluptatem provident magnam exercitationem.", new DateTime(2022, 10, 3, 20, 7, 3, 539, DateTimeKind.Unspecified).AddTicks(1986), "Laboriosam officia ipsa debitis.", 2, 2 },
                    { 75L, 63L, "Laudantium velit et.", new DateTime(2023, 7, 15, 15, 2, 4, 917, DateTimeKind.Unspecified).AddTicks(4847), "Aut ut ut est repellendus est qui illo.", 4, 0 },
                    { 76L, 57L, "distinctio", new DateTime(2020, 1, 7, 10, 13, 50, 954, DateTimeKind.Unspecified).AddTicks(9245), "Dolore voluptatem quidem dicta.", 3, 3 },
                    { 77L, 54L, "Assumenda nulla ut ut sit id consequatur.\nSunt voluptatem quos aliquam.\nPorro eligendi aut.\nMaiores quo totam.\nDelectus tempore vel.", new DateTime(2023, 7, 5, 16, 3, 5, 622, DateTimeKind.Unspecified).AddTicks(6265), "Enim commodi dicta omnis deleniti optio earum reiciendis eos et.", 2, 0 },
                    { 78L, 49L, "voluptatem", new DateTime(2023, 7, 4, 18, 59, 7, 683, DateTimeKind.Unspecified).AddTicks(1238), "Maiores qui quo velit.", 2, 2 },
                    { 79L, 16L, "Voluptatibus magnam explicabo consequatur libero.\nRatione praesentium aut ipsum officia unde magnam autem.\nSapiente officia odio dolor voluptas perferendis.\nSit amet nihil sed harum similique.", new DateTime(2022, 11, 13, 11, 41, 27, 489, DateTimeKind.Unspecified).AddTicks(7600), "Eveniet nulla id laboriosam.", 1, 1 },
                    { 80L, 38L, "aut", new DateTime(2020, 6, 25, 4, 19, 15, 484, DateTimeKind.Unspecified).AddTicks(2146), "Ea dolore eligendi vitae quia repudiandae perferendis ut rerum sint.", 1, 3 },
                    { 81L, 41L, "in", new DateTime(2022, 10, 17, 12, 55, 32, 486, DateTimeKind.Unspecified).AddTicks(7309), "Voluptatem ut consequatur soluta aliquid qui sint et iure totam.", 1, 3 },
                    { 82L, 4L, "Qui dicta nisi libero aut explicabo ut beatae et aut.", new DateTime(2023, 4, 11, 8, 54, 53, 498, DateTimeKind.Unspecified).AddTicks(2867), "Nulla consequuntur qui aut velit cupiditate voluptas in.", 1, 2 },
                    { 83L, 69L, "Ut ullam molestiae nobis cumque maxime repellat id autem quae.", new DateTime(2023, 7, 15, 6, 29, 33, 698, DateTimeKind.Unspecified).AddTicks(4095), "Temporibus ducimus hic est.", 1, 2 },
                    { 84L, 9L, "Impedit fuga beatae illum necessitatibus ut earum autem temporibus repudiandae. Aut aliquid ut laboriosam inventore non fugit beatae a consequatur. Maxime est eligendi quia sint. Earum totam asperiores saepe labore temporibus.", new DateTime(2020, 4, 22, 17, 15, 11, 852, DateTimeKind.Unspecified).AddTicks(8969), "Ipsa quibusdam quaerat atque necessitatibus et voluptate eum iusto.", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "InitialSolution", "LanguageId", "Status" },
                values: new object[,]
                {
                    { 85L, 10L, "vel", new DateTime(2018, 5, 26, 12, 57, 43, 370, DateTimeKind.Unspecified).AddTicks(151), "Consequatur omnis reiciendis aperiam.", 1, 2 },
                    { 86L, 5L, "Molestiae quia nobis qui quas at voluptatem sint sunt et.", new DateTime(2023, 6, 24, 15, 8, 56, 559, DateTimeKind.Unspecified).AddTicks(5825), "Eveniet voluptatem porro molestias hic.", 3, 0 },
                    { 87L, 42L, "aut", new DateTime(2023, 3, 4, 1, 49, 54, 982, DateTimeKind.Unspecified).AddTicks(7905), "Eveniet quasi adipisci accusantium voluptatem et fugiat provident.", 2, 2 },
                    { 88L, 10L, "Iste quaerat consequuntur porro non quisquam exercitationem. Deleniti recusandae deserunt velit nihil facilis enim. Eaque quaerat deserunt deserunt est voluptatum modi quaerat placeat et.", new DateTime(2018, 3, 15, 5, 56, 43, 239, DateTimeKind.Unspecified).AddTicks(285), "Qui voluptas non ut.", 4, 2 },
                    { 89L, 8L, "Alias quis magnam provident quam.\nNecessitatibus reiciendis minima sint et beatae aperiam et ut delectus.\nNeque at aliquid rerum nihil id illo magni autem.\nOdio at deleniti.", new DateTime(2023, 6, 14, 18, 59, 48, 522, DateTimeKind.Unspecified).AddTicks(8604), "Rerum mollitia consequatur sint itaque ut animi voluptate fugit labore.", 2, 3 },
                    { 90L, 6L, "aut", new DateTime(2023, 8, 18, 22, 53, 50, 535, DateTimeKind.Unspecified).AddTicks(731), "Autem asperiores eum quo quibusdam.", 3, 1 },
                    { 91L, 64L, "in", new DateTime(2022, 4, 26, 21, 55, 4, 235, DateTimeKind.Unspecified).AddTicks(6915), "Eaque harum dignissimos nemo architecto et qui in ullam assumenda.", 1, 1 },
                    { 92L, 7L, "fugit", new DateTime(2023, 3, 10, 6, 27, 40, 427, DateTimeKind.Unspecified).AddTicks(3651), "Neque vel explicabo sequi est deserunt ut quam ducimus.", 4, 2 },
                    { 93L, 53L, "Est quibusdam voluptatibus tempore saepe repellendus rerum consequatur sint harum.", new DateTime(2018, 11, 26, 3, 34, 0, 931, DateTimeKind.Unspecified).AddTicks(1863), "Voluptatum voluptatibus aut voluptate ipsum minima blanditiis voluptas.", 2, 1 },
                    { 94L, 40L, "officia", new DateTime(2022, 10, 1, 20, 2, 10, 208, DateTimeKind.Unspecified).AddTicks(8227), "Rerum et mollitia accusantium laudantium sed.", 3, 3 },
                    { 95L, 66L, "Nesciunt sit quae veniam id aut aliquid qui omnis.", new DateTime(2022, 9, 30, 8, 19, 54, 961, DateTimeKind.Unspecified).AddTicks(5364), "Et rerum ea aliquam cum est maiores quia.", 4, 1 },
                    { 96L, 20L, "sit", new DateTime(2021, 7, 10, 9, 32, 24, 31, DateTimeKind.Unspecified).AddTicks(9244), "Illum sit possimus commodi quia ad aut aut eos.", 1, 0 },
                    { 97L, 30L, "Quis aut omnis laboriosam ut et odio distinctio saepe.\nDelectus neque tempore amet adipisci debitis aut.\nCumque voluptatem distinctio assumenda impedit quidem quo.", new DateTime(2022, 9, 19, 22, 3, 38, 54, DateTimeKind.Unspecified).AddTicks(7405), "Inventore ullam ducimus pariatur iusto eligendi esse sint facilis.", 4, 0 },
                    { 98L, 18L, "Rerum iusto sit veniam dolor magnam. Ut illum architecto repudiandae explicabo quia. Ipsum qui et et beatae ipsam inventore. Ut quis dolore. Officia itaque atque quaerat voluptas molestiae.", new DateTime(2023, 2, 25, 20, 31, 34, 750, DateTimeKind.Unspecified).AddTicks(5450), "Quisquam deserunt repudiandae ut animi quaerat reprehenderit voluptas et.", 3, 3 },
                    { 99L, 58L, "facilis", new DateTime(2023, 8, 22, 8, 40, 29, 684, DateTimeKind.Unspecified).AddTicks(3403), "Iste fuga ipsum fuga inventore.", 3, 0 },
                    { 100L, 42L, "Eum provident sapiente aperiam assumenda.\nNatus inventore iste enim maiores atque et quisquam.\nQuo rerum consequatur et est repellat aperiam quaerat eligendi molestiae.", new DateTime(2022, 7, 12, 10, 52, 57, 102, DateTimeKind.Unspecified).AddTicks(1658), "Magnam laboriosam consequatur.", 2, 3 },
                    { 101L, 24L, "alias", new DateTime(2022, 2, 23, 7, 32, 25, 727, DateTimeKind.Unspecified).AddTicks(1980), "Qui incidunt minima ut ab quod nisi occaecati at molestias.", 2, 2 },
                    { 102L, 11L, "Aliquid autem ad ut est blanditiis architecto impedit.\nQuidem repudiandae possimus sed sit libero sequi quos molestiae.\nIn fuga repellat sunt et alias sunt ratione enim distinctio.\nNon quo odio harum omnis quaerat totam beatae voluptates.\nEt ex quia eum quam recusandae.", new DateTime(2021, 12, 3, 15, 49, 2, 985, DateTimeKind.Unspecified).AddTicks(224), "Minima consectetur esse reprehenderit.", 1, 2 },
                    { 103L, 50L, "Odit beatae ipsam. Totam velit nobis velit sint natus delectus. Dolorem quod quas et a.", new DateTime(2023, 7, 4, 7, 52, 58, 604, DateTimeKind.Unspecified).AddTicks(5649), "Sapiente animi reprehenderit sit aliquid modi aliquid ut sint enim.", 4, 2 },
                    { 104L, 25L, "Libero corporis nesciunt.", new DateTime(2023, 5, 18, 18, 50, 23, 713, DateTimeKind.Unspecified).AddTicks(7745), "Ut ab et velit aperiam sed consequatur.", 3, 2 },
                    { 105L, 19L, "Sed iste ipsam veritatis nihil consequuntur perspiciatis voluptas ut.", new DateTime(2023, 2, 10, 0, 35, 37, 511, DateTimeKind.Unspecified).AddTicks(2021), "Velit aliquid excepturi ducimus ipsa nihil maxime non.", 4, 1 },
                    { 106L, 61L, "Enim et enim autem sed consectetur.", new DateTime(2023, 7, 31, 15, 20, 33, 710, DateTimeKind.Unspecified).AddTicks(7660), "Quia rem exercitationem ut nam sit nesciunt.", 3, 2 },
                    { 107L, 25L, "dolor", new DateTime(2023, 4, 15, 20, 41, 36, 920, DateTimeKind.Unspecified).AddTicks(6035), "Est voluptas est id debitis.", 3, 2 },
                    { 108L, 34L, "Natus sequi placeat. Est rerum dicta animi dolorem exercitationem. Veniam cumque est sunt harum voluptas expedita explicabo temporibus eveniet.", new DateTime(2023, 7, 18, 11, 47, 49, 778, DateTimeKind.Unspecified).AddTicks(4559), "Temporibus voluptates quia sunt consequuntur omnis eos laudantium est.", 3, 1 },
                    { 109L, 66L, "Veniam facere at quo occaecati vel repellat quos. Ipsa officiis odio est incidunt dolorum aperiam expedita quis aut. Libero quis harum aperiam qui asperiores temporibus id impedit dolores.", new DateTime(2022, 1, 5, 12, 24, 2, 807, DateTimeKind.Unspecified).AddTicks(5257), "Dolores sunt consequatur sunt qui vero soluta.", 3, 2 },
                    { 110L, 57L, "Placeat maxime inventore ea culpa totam omnis.\nEnim expedita nesciunt illo.\nSed qui sunt cupiditate voluptatem voluptatem dolor dolor odio earum.\nQuia aut non tempora ad aspernatur accusantium quia soluta.\nAut quis vitae deserunt non ut nesciunt itaque.\nMinima corrupti nemo ex aut.", new DateTime(2019, 1, 8, 11, 57, 52, 416, DateTimeKind.Unspecified).AddTicks(6944), "Sunt aut eum enim vitae.", 4, 2 },
                    { 111L, 52L, "Et non et tenetur autem.\nUt provident corrupti non consequatur.\nFuga nulla ratione distinctio corporis perferendis cupiditate iste et laudantium.\nDelectus temporibus rem reiciendis sunt.\nVel sint excepturi voluptas quo perferendis.\nEst provident recusandae.", new DateTime(2023, 5, 5, 0, 11, 49, 552, DateTimeKind.Unspecified).AddTicks(6354), "Quia voluptas enim aut ut beatae.", 1, 1 },
                    { 112L, 64L, "Praesentium vero nam.", new DateTime(2023, 2, 19, 7, 46, 11, 543, DateTimeKind.Unspecified).AddTicks(4337), "Magnam quam qui et neque qui sapiente veritatis quia.", 1, 1 },
                    { 113L, 23L, "Et perferendis assumenda vitae molestiae qui autem qui ut.\nQuis rerum inventore voluptate nisi at qui laboriosam.\nOmnis iste tempora voluptatibus quis accusantium qui quasi ea facilis.\nTenetur facere et sunt explicabo magni.\nReiciendis maxime natus veniam.", new DateTime(2023, 8, 12, 10, 33, 50, 208, DateTimeKind.Unspecified).AddTicks(5030), "Cum esse ullam.", 2, 3 },
                    { 114L, 66L, "Porro accusantium ad voluptas doloremque in illo id placeat iure. Qui omnis et dicta delectus ipsam. Distinctio voluptatum deserunt iure. Et voluptates doloremque in aut animi. Cumque dolorem iusto asperiores eaque est illum magnam aut. Et qui vel eveniet illum ipsum consectetur dolor recusandae.", new DateTime(2021, 6, 30, 15, 55, 56, 615, DateTimeKind.Unspecified).AddTicks(4982), "Eius aliquam nihil.", 2, 1 },
                    { 115L, 25L, "Recusandae est tempore. Voluptas in enim voluptatem veritatis aut accusamus omnis. In in molestiae id voluptas in.", new DateTime(2023, 3, 1, 9, 16, 27, 331, DateTimeKind.Unspecified).AddTicks(932), "Commodi sit omnis doloremque recusandae repellat.", 1, 3 },
                    { 116L, 1L, "Non qui laudantium nihil animi dolorum aut aut eum exercitationem. Repudiandae possimus aut id adipisci sequi nihil ut et inventore. Perferendis possimus dolores officiis dicta commodi.", new DateTime(2023, 2, 17, 17, 0, 59, 768, DateTimeKind.Unspecified).AddTicks(6902), "Hic harum nihil modi repellendus voluptatem aut ut.", 3, 3 },
                    { 117L, 44L, "Asperiores dolorem consequatur perferendis. Hic magnam sit consequuntur hic unde ut atque. Qui consequuntur impedit quis qui provident quod eos autem. Aliquam animi inventore id ipsam et.", new DateTime(2022, 8, 2, 1, 56, 24, 903, DateTimeKind.Unspecified).AddTicks(8257), "Optio consequatur quis enim quam.", 3, 2 },
                    { 118L, 10L, "Quo sit et inventore aliquid est dolorem debitis rerum nesciunt.", new DateTime(2023, 2, 25, 18, 43, 24, 888, DateTimeKind.Unspecified).AddTicks(7228), "Expedita facilis quod.", 3, 0 },
                    { 119L, 25L, "Molestiae iure architecto possimus. Atque delectus officiis. Optio natus cupiditate ipsam ipsa deleniti est sit sapiente.", new DateTime(2023, 5, 15, 23, 30, 46, 519, DateTimeKind.Unspecified).AddTicks(7167), "Vero ducimus aut omnis sed necessitatibus est.", 1, 2 },
                    { 120L, 60L, "ipsam", new DateTime(2022, 6, 18, 18, 39, 16, 930, DateTimeKind.Unspecified).AddTicks(464), "Et quia quia tempore voluptatibus exercitationem doloremque.", 2, 1 },
                    { 121L, 25L, "non", new DateTime(2023, 6, 14, 20, 52, 32, 609, DateTimeKind.Unspecified).AddTicks(1036), "Sed similique cum animi quaerat ut modi rerum sit.", 2, 2 },
                    { 122L, 50L, "Molestias et fugit rem dolorum sunt voluptatem veritatis qui. Possimus nisi veniam quis sapiente debitis. Quod nihil hic. Quas est natus labore quae. Qui sunt nihil eos et nobis corrupti.", new DateTime(2023, 3, 25, 1, 38, 34, 21, DateTimeKind.Unspecified).AddTicks(1644), "Pariatur est autem temporibus dolorem unde et vel.", 3, 0 },
                    { 123L, 30L, "ut", new DateTime(2022, 11, 19, 6, 36, 47, 96, DateTimeKind.Unspecified).AddTicks(1945), "Amet quia facilis quis modi.", 1, 0 },
                    { 124L, 19L, "Quos eligendi dolorum qui expedita autem.", new DateTime(2022, 12, 4, 17, 55, 24, 180, DateTimeKind.Unspecified).AddTicks(5354), "Quasi minima fuga blanditiis consequatur quidem omnis incidunt sunt.", 3, 2 },
                    { 125L, 44L, "Autem ut repudiandae autem. Inventore aperiam impedit et libero. Quod eligendi rerum voluptatem mollitia id. Est ullam voluptas hic sit quis rerum voluptas repellat est. Magnam vitae voluptatem et ipsam veritatis deserunt omnis dolorem. Animi omnis hic adipisci maiores maiores eligendi dolorem quod.", new DateTime(2022, 10, 10, 4, 41, 1, 842, DateTimeKind.Unspecified).AddTicks(4583), "Sint et soluta numquam eum totam.", 3, 3 },
                    { 126L, 19L, "sunt", new DateTime(2023, 6, 1, 8, 58, 46, 570, DateTimeKind.Unspecified).AddTicks(9193), "Expedita esse molestiae rerum ut.", 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "InitialSolution", "LanguageId", "Status" },
                values: new object[,]
                {
                    { 127L, 58L, "aut", new DateTime(2022, 5, 16, 13, 46, 11, 102, DateTimeKind.Unspecified).AddTicks(3488), "Dolorem quia autem qui natus illum omnis.", 3, 3 },
                    { 128L, 27L, "Ut quidem impedit ut tempore ut ut et aperiam vel.\nQui similique ducimus et ut et.\nConsequatur aliquid sed.\nLibero at sequi quia harum aut perferendis.\nNisi sit ut dolorem rem sit at culpa.\nRepudiandae rem eaque.", new DateTime(2022, 8, 7, 5, 36, 1, 863, DateTimeKind.Unspecified).AddTicks(5221), "Rerum itaque aliquam dolore quia rem.", 4, 2 },
                    { 129L, 11L, "Delectus at vitae laudantium animi.\nAtque exercitationem aperiam iure iste ea reiciendis id.\nEius ut blanditiis.\nVitae vel exercitationem incidunt officia eum ratione totam id commodi.\nIllum porro voluptas dolorem numquam repellat et rerum ipsam id.\nCorrupti nisi labore perferendis aut excepturi mollitia.", new DateTime(2023, 3, 9, 6, 51, 18, 126, DateTimeKind.Unspecified).AddTicks(6963), "Corrupti suscipit ad autem laudantium velit.", 1, 2 },
                    { 130L, 65L, "Similique quo beatae consequatur.\nSed quisquam quaerat eos qui cupiditate voluptas.\nDoloribus in at harum officiis in quia enim architecto ab.\nCum perspiciatis autem consequatur consequatur eos rem.\nIste amet tempore quia eveniet cumque architecto ipsa iusto.\nId non ut neque quisquam.", new DateTime(2022, 7, 8, 3, 35, 17, 398, DateTimeKind.Unspecified).AddTicks(8562), "Possimus quos tempore fuga dolores quidem blanditiis ut.", 3, 3 },
                    { 131L, 51L, "reiciendis", new DateTime(2022, 6, 9, 13, 4, 33, 298, DateTimeKind.Unspecified).AddTicks(783), "Dolorem qui voluptas quos temporibus excepturi.", 3, 1 },
                    { 132L, 13L, "Rem occaecati suscipit.\nQui quod dicta modi ipsa beatae rerum.\nNisi dolor iure iure similique aspernatur corporis quisquam ab.\nVero sint reprehenderit a voluptatem.\nDolorem necessitatibus mollitia harum a fugiat voluptatem.", new DateTime(2021, 5, 6, 22, 38, 1, 953, DateTimeKind.Unspecified).AddTicks(3469), "Porro est voluptas ipsam in a non quibusdam.", 2, 2 },
                    { 133L, 40L, "Incidunt quae a ratione nam illum quia eos.", new DateTime(2021, 7, 3, 0, 43, 35, 438, DateTimeKind.Unspecified).AddTicks(4287), "Et aperiam labore officia architecto rerum quam dolores perferendis similique.", 2, 1 },
                    { 134L, 18L, "Sunt sit dicta ut odio. Sed sit quas aliquam non eveniet. Voluptates debitis officiis id ea dolores. Sunt veritatis quidem dicta odit. Architecto repudiandae reiciendis. Ea voluptate possimus molestiae a earum veritatis qui autem cum.", new DateTime(2023, 1, 23, 14, 2, 39, 47, DateTimeKind.Unspecified).AddTicks(7696), "Consequatur accusamus molestias nesciunt sed non.", 2, 0 },
                    { 135L, 43L, "Minus doloremque vel repellat nesciunt quis quis fuga.", new DateTime(2023, 7, 14, 19, 56, 44, 503, DateTimeKind.Unspecified).AddTicks(2286), "Qui id a harum veniam sint at.", 1, 3 },
                    { 136L, 68L, "voluptatibus", new DateTime(2023, 8, 22, 3, 9, 47, 938, DateTimeKind.Unspecified).AddTicks(55), "Voluptatum tenetur recusandae vel.", 4, 1 },
                    { 137L, 22L, "Hic odit adipisci non natus veritatis labore.", new DateTime(2023, 4, 20, 21, 33, 0, 449, DateTimeKind.Unspecified).AddTicks(7317), "Laudantium cupiditate praesentium sed veniam optio.", 1, 2 },
                    { 138L, 38L, "Accusamus quidem soluta ea doloremque.", new DateTime(2023, 2, 10, 6, 27, 30, 270, DateTimeKind.Unspecified).AddTicks(796), "Et quas odio magni consequatur optio.", 4, 2 },
                    { 139L, 27L, "minima", new DateTime(2023, 7, 25, 23, 9, 43, 887, DateTimeKind.Unspecified).AddTicks(9363), "Nisi molestias incidunt reprehenderit ipsum.", 1, 3 },
                    { 140L, 22L, "et", new DateTime(2023, 7, 27, 6, 54, 55, 812, DateTimeKind.Unspecified).AddTicks(6484), "Sint voluptatem quis ut aliquam sapiente dicta sit aut qui.", 3, 1 },
                    { 141L, 40L, "Voluptatibus quia porro nisi necessitatibus quia quam fugit quos.", new DateTime(2022, 8, 3, 6, 31, 26, 725, DateTimeKind.Unspecified).AddTicks(8595), "Cum non id sunt ab ea provident modi pariatur suscipit.", 3, 2 },
                    { 142L, 54L, "Consequuntur optio modi commodi necessitatibus totam. Facere ipsam ea et nobis voluptatum magni voluptatem molestias quisquam. Consectetur consequatur cum voluptate quae sapiente illo molestias. Animi aliquam inventore aspernatur deleniti repellendus commodi at fuga dolores. Alias expedita excepturi ea quia tempora earum eos aut perferendis.", new DateTime(2021, 4, 24, 5, 45, 8, 544, DateTimeKind.Unspecified).AddTicks(2933), "Possimus minima dolorem facere.", 2, 1 },
                    { 143L, 52L, "Quaerat corporis voluptatem eveniet fugit ad rerum.", new DateTime(2023, 6, 8, 20, 58, 28, 979, DateTimeKind.Unspecified).AddTicks(9345), "Est vel quisquam est voluptatem enim vel error.", 1, 2 },
                    { 144L, 9L, "Et explicabo vel dolor omnis dolores. Ut libero dolorum explicabo non eos sint et temporibus sapiente. Quod at possimus cumque aliquam consequuntur fugit dolores atque eum.", new DateTime(2022, 3, 25, 12, 14, 8, 418, DateTimeKind.Unspecified).AddTicks(1634), "Ipsam ut qui sit consectetur voluptate.", 1, 3 },
                    { 145L, 39L, "Nam omnis quasi consequuntur.\nVeniam blanditiis voluptatem ut incidunt incidunt.\nVoluptatem magnam est repudiandae voluptas nobis.\nIllo est ratione.", new DateTime(2021, 5, 30, 7, 53, 25, 70, DateTimeKind.Unspecified).AddTicks(1597), "Sit facilis quia suscipit.", 4, 2 },
                    { 146L, 9L, "Molestiae animi consectetur voluptatibus.", new DateTime(2022, 11, 29, 9, 12, 27, 980, DateTimeKind.Unspecified).AddTicks(4596), "Voluptas enim quo.", 3, 2 },
                    { 147L, 8L, "Earum exercitationem qui consequatur et expedita molestias. Sint dolor occaecati voluptatum voluptatem enim. Quae consectetur dolor maiores doloribus unde veritatis. Veniam porro repellat ut perferendis atque modi voluptatibus. Explicabo saepe quasi unde perspiciatis ut et officia.", new DateTime(2022, 5, 20, 2, 27, 56, 590, DateTimeKind.Unspecified).AddTicks(1621), "Dolorem molestiae aut.", 4, 2 },
                    { 148L, 69L, "Id incidunt ut.", new DateTime(2023, 6, 7, 16, 43, 35, 892, DateTimeKind.Unspecified).AddTicks(4293), "Est nam natus.", 3, 3 },
                    { 149L, 36L, "Consequuntur velit et quas voluptas reiciendis. Quasi iusto reprehenderit ut ipsum quasi. Tempore officia ea atque facere. Non sint consectetur asperiores explicabo optio voluptatem dolorem nihil. Autem in quaerat. Sed ea commodi dolorum saepe.", new DateTime(2023, 1, 3, 19, 59, 50, 745, DateTimeKind.Unspecified).AddTicks(8431), "Est et quam dolores consequatur exercitationem.", 2, 1 },
                    { 150L, 25L, "Sunt at non.\nQuasi voluptate ratione.\nTempora est voluptas perferendis eos repudiandae aut et enim.\nQuod deserunt et aliquam.\nAutem cumque voluptatibus.\nSed fugiat quam sint laudantium error ex dolorem voluptate.", new DateTime(2023, 3, 2, 3, 50, 21, 482, DateTimeKind.Unspecified).AddTicks(1080), "Aut ad culpa ipsam placeat et.", 2, 1 },
                    { 151L, 23L, "Ut eius perspiciatis quo qui fugiat nemo sunt.\nAccusantium repellat aut magni et qui repellendus.\nQui voluptatum sapiente recusandae provident voluptas vitae ut.\nNeque tempora aut blanditiis.", new DateTime(2023, 8, 14, 14, 52, 29, 927, DateTimeKind.Unspecified).AddTicks(1525), "Quam veniam nulla numquam rem accusamus commodi omnis.", 2, 3 },
                    { 152L, 21L, "Voluptatum porro ut voluptatem dicta laborum.\nAperiam rem placeat quis vel laudantium.\nHarum libero beatae reiciendis dolores nobis tempore qui exercitationem.\nOdit aut nihil aut maiores.\nMinus voluptates quia expedita dolores voluptatum illum quia accusantium nulla.", new DateTime(2021, 11, 25, 8, 57, 46, 652, DateTimeKind.Unspecified).AddTicks(9635), "Nisi consequatur voluptas officia quos ipsa sed.", 4, 2 },
                    { 153L, 52L, "Corrupti aperiam facere et. Ipsa repudiandae aut amet in ab. Perferendis praesentium aliquam aut autem nesciunt at. Hic nostrum est eum enim non fugit qui fuga. Nulla neque a molestias nihil dicta et voluptas illo est. Repudiandae expedita eum labore a.", new DateTime(2023, 6, 9, 22, 12, 20, 863, DateTimeKind.Unspecified).AddTicks(6096), "Delectus ut blanditiis a.", 1, 2 },
                    { 154L, 55L, "Nemo consequatur nisi non.", new DateTime(2023, 7, 11, 20, 49, 2, 27, DateTimeKind.Unspecified).AddTicks(6278), "Et ut dicta.", 4, 1 },
                    { 155L, 45L, "culpa", new DateTime(2021, 9, 26, 10, 13, 28, 669, DateTimeKind.Unspecified).AddTicks(8030), "Rerum deserunt quas aperiam ipsum ut provident aut.", 1, 1 },
                    { 156L, 17L, "consectetur", new DateTime(2023, 2, 8, 12, 0, 32, 745, DateTimeKind.Unspecified).AddTicks(9253), "Eos eum et vitae aut.", 4, 0 },
                    { 157L, 63L, "Similique optio ut rerum omnis.", new DateTime(2023, 2, 12, 10, 39, 18, 650, DateTimeKind.Unspecified).AddTicks(856), "Dolores nulla nulla occaecati molestiae et et.", 3, 2 },
                    { 158L, 5L, "Optio quisquam ut consequatur reprehenderit commodi eaque aliquam.", new DateTime(2023, 2, 6, 16, 8, 27, 434, DateTimeKind.Unspecified).AddTicks(1551), "Delectus modi asperiores quasi perspiciatis laboriosam ea.", 1, 2 },
                    { 159L, 22L, "Alias nam vel ipsam quas.", new DateTime(2023, 4, 18, 22, 42, 58, 318, DateTimeKind.Unspecified).AddTicks(391), "Temporibus maiores similique est saepe dignissimos sit ut.", 4, 0 },
                    { 160L, 36L, "Ratione minima excepturi dignissimos expedita dignissimos fuga commodi enim et.", new DateTime(2022, 11, 17, 12, 52, 22, 577, DateTimeKind.Unspecified).AddTicks(4258), "Delectus expedita facilis.", 1, 3 },
                    { 161L, 17L, "Odit est dolores nisi ut et maxime. Illum ut rerum et. Ullam perspiciatis aut dolores enim dignissimos. Et sunt et quaerat quis aperiam maxime similique. Voluptatibus sapiente est error. Quaerat perspiciatis ullam.", new DateTime(2022, 12, 4, 22, 44, 32, 387, DateTimeKind.Unspecified).AddTicks(5272), "Consequatur laboriosam in ex ut qui culpa quae provident deleniti.", 3, 0 },
                    { 162L, 37L, "corrupti", new DateTime(2020, 11, 10, 2, 26, 15, 747, DateTimeKind.Unspecified).AddTicks(657), "Amet iusto possimus iusto necessitatibus nulla aperiam dolorem aperiam.", 1, 0 },
                    { 163L, 59L, "repellat", new DateTime(2022, 8, 25, 19, 7, 59, 985, DateTimeKind.Unspecified).AddTicks(1823), "Inventore ut illo quia recusandae quo earum sint ea suscipit.", 3, 0 },
                    { 164L, 57L, "Ut provident veritatis rerum.\nUt velit cupiditate labore ducimus quam est alias alias.\nVero ut dolores quo architecto iste et.\nCulpa sed quia.\nSed et fugit.\nAutem sed sunt sequi rerum accusamus saepe consectetur soluta rerum.", new DateTime(2019, 7, 14, 5, 56, 45, 720, DateTimeKind.Unspecified).AddTicks(5693), "Enim ut consectetur.", 4, 2 },
                    { 165L, 28L, "Omnis officia aspernatur dolores atque maxime in dolores.\nMinima quia sed ipsa ea.\nNulla rerum maiores blanditiis nemo nesciunt magni maxime repellat corrupti.\nAut eos quo dolorum eum error.\nPorro molestiae et inventore.", new DateTime(2022, 2, 26, 7, 14, 34, 80, DateTimeKind.Unspecified).AddTicks(277), "Aperiam iure et esse.", 1, 0 },
                    { 166L, 1L, "Aspernatur iure quas est nulla aut.\nEt assumenda iusto.\nTempore ducimus natus voluptas voluptas aut.\nTemporibus quod animi nemo optio laborum.\nNon ipsam rem exercitationem voluptatem perferendis.", new DateTime(2022, 10, 17, 17, 28, 30, 171, DateTimeKind.Unspecified).AddTicks(7318), "Et provident soluta perferendis quia dolorem consequuntur.", 1, 1 },
                    { 167L, 14L, "Est autem pariatur. Facere debitis dolorem temporibus eligendi necessitatibus ipsum quidem. Sed est et nihil aliquam libero ipsa explicabo et.", new DateTime(2023, 5, 15, 9, 32, 51, 268, DateTimeKind.Unspecified).AddTicks(2240), "Non dolor expedita tenetur eos quia vel quia quia.", 1, 3 },
                    { 168L, 42L, "Exercitationem esse consequuntur in cum. Voluptatem laborum voluptatem dolorem. Unde voluptas facere et nemo ipsa accusantium. Cum expedita delectus sint. Omnis et quia in tempore.", new DateTime(2022, 8, 3, 3, 44, 35, 124, DateTimeKind.Unspecified).AddTicks(3648), "Ad molestiae occaecati quos dolores consequuntur adipisci.", 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "InitialSolution", "LanguageId", "Status" },
                values: new object[,]
                {
                    { 169L, 12L, "Culpa qui libero repellat est neque assumenda et consectetur.", new DateTime(2023, 8, 1, 4, 56, 11, 977, DateTimeKind.Unspecified).AddTicks(2160), "Magni voluptas ut laudantium quam.", 1, 2 },
                    { 170L, 32L, "Minima ducimus dolorum accusantium voluptas in id qui aut.\nLabore magnam ad.\nNihil voluptate est atque quam quam nesciunt ducimus tempore.\nNisi est odio laborum voluptate officiis rerum numquam sunt.", new DateTime(2023, 6, 15, 5, 54, 21, 49, DateTimeKind.Unspecified).AddTicks(2888), "Voluptas dolores at accusantium consequatur a et itaque.", 1, 2 },
                    { 171L, 8L, "in", new DateTime(2022, 4, 20, 14, 50, 4, 422, DateTimeKind.Unspecified).AddTicks(6597), "Nihil excepturi error omnis itaque error sunt.", 1, 2 },
                    { 172L, 19L, "Asperiores velit aut iusto.\nNeque consequuntur autem.", new DateTime(2022, 6, 28, 14, 4, 2, 902, DateTimeKind.Unspecified).AddTicks(8709), "Explicabo nesciunt eligendi eum est illum.", 4, 0 },
                    { 173L, 58L, "Recusandae blanditiis dolorum.\nVoluptas sint ut autem similique consequatur non consequuntur quasi vitae.", new DateTime(2022, 9, 19, 16, 27, 43, 258, DateTimeKind.Unspecified).AddTicks(4929), "Vero vel excepturi aut porro aspernatur aut ut quas vero.", 2, 0 },
                    { 174L, 18L, "Veniam magnam eveniet incidunt libero possimus ipsa.", new DateTime(2023, 4, 30, 4, 53, 7, 678, DateTimeKind.Unspecified).AddTicks(3289), "In amet corporis enim voluptatem distinctio aut qui delectus ut.", 4, 2 },
                    { 175L, 51L, "Error placeat repellendus recusandae harum ratione.\nVeniam tempora sit vel rem.\nVel facilis officiis.\nAt repellendus quasi beatae.", new DateTime(2023, 1, 24, 11, 49, 12, 749, DateTimeKind.Unspecified).AddTicks(1675), "Perferendis culpa voluptatibus facilis perferendis.", 2, 2 },
                    { 176L, 37L, "Enim dolores odit doloribus provident totam sapiente.", new DateTime(2022, 11, 25, 17, 22, 47, 464, DateTimeKind.Unspecified).AddTicks(8836), "Exercitationem id soluta.", 3, 1 },
                    { 177L, 22L, "officiis", new DateTime(2023, 4, 19, 7, 4, 40, 649, DateTimeKind.Unspecified).AddTicks(9839), "Molestiae suscipit inventore non sed recusandae odit voluptatum.", 2, 0 },
                    { 178L, 27L, "Omnis quasi aut ut qui aut voluptate quia aliquam.\nEt ipsam distinctio quibusdam aliquid.\nAut explicabo aut sunt reiciendis voluptate iusto.\nQuibusdam temporibus quas commodi.\nVoluptatibus tempore saepe nesciunt recusandae neque ut dicta.", new DateTime(2022, 12, 1, 21, 48, 12, 319, DateTimeKind.Unspecified).AddTicks(7429), "Minima et pariatur.", 1, 3 },
                    { 179L, 57L, "facere", new DateTime(2022, 6, 14, 6, 47, 33, 509, DateTimeKind.Unspecified).AddTicks(8127), "Et est porro doloribus perspiciatis.", 3, 3 },
                    { 180L, 62L, "Est ipsa cupiditate. Officia quisquam nesciunt qui harum. Molestias error quo.", new DateTime(2022, 7, 4, 3, 28, 24, 369, DateTimeKind.Unspecified).AddTicks(5213), "Autem aliquid harum.", 4, 2 },
                    { 181L, 45L, "eos", new DateTime(2021, 7, 25, 0, 4, 46, 541, DateTimeKind.Unspecified).AddTicks(4295), "Dignissimos aut dolore ad laborum asperiores dolorem sint dolores.", 4, 1 },
                    { 182L, 39L, "Animi libero dolor dolore ipsa omnis nesciunt vitae pariatur. Consequatur consequatur temporibus sit et non odit tempore qui. Officia illum qui. Et consequatur assumenda eius. Accusamus aut ducimus aut et tempore rerum illum sint debitis. Delectus inventore delectus eum voluptates.", new DateTime(2020, 8, 29, 3, 27, 34, 928, DateTimeKind.Unspecified).AddTicks(5434), "Numquam expedita maxime harum voluptatem.", 3, 3 },
                    { 183L, 66L, "dolor", new DateTime(2022, 10, 23, 6, 48, 17, 599, DateTimeKind.Unspecified).AddTicks(9135), "Non aliquid velit quibusdam.", 1, 2 },
                    { 184L, 42L, "Ea distinctio atque impedit amet quibusdam. Et non at dolorum. Et consequatur rerum asperiores placeat. Blanditiis aperiam dolor sed saepe. Debitis ipsum velit aliquid accusantium itaque maiores eum. Nemo velit modi id quas nisi iste consectetur minus optio.", new DateTime(2023, 7, 28, 1, 8, 12, 366, DateTimeKind.Unspecified).AddTicks(2641), "Earum sed voluptatibus.", 4, 2 },
                    { 185L, 18L, "Mollitia accusamus eaque. Accusamus temporibus suscipit quos laborum nam aliquam. Asperiores ut nulla dignissimos. Delectus dolores voluptatem eius suscipit incidunt beatae. Nisi quis odit explicabo ipsa blanditiis voluptatibus. Voluptas a voluptatem eligendi odit veritatis aut ad.", new DateTime(2023, 6, 8, 22, 24, 10, 764, DateTimeKind.Unspecified).AddTicks(8379), "Quia hic quis facilis perspiciatis aut numquam sequi voluptas.", 2, 1 },
                    { 186L, 48L, "Similique quibusdam quaerat rerum sapiente voluptatem cupiditate.\nIncidunt in sunt quia enim sunt nam.\nNon facere qui ut voluptas maiores omnis dicta est eum.\nEligendi facilis quasi quia iure et.\nAut provident cumque soluta qui.\nSed corporis quae.", new DateTime(2022, 2, 5, 19, 11, 34, 189, DateTimeKind.Unspecified).AddTicks(8395), "Est rerum eaque assumenda.", 1, 1 },
                    { 187L, 22L, "Et in culpa fugiat.\nNesciunt architecto sit omnis repudiandae totam dolores labore pariatur.", new DateTime(2023, 4, 18, 19, 26, 45, 238, DateTimeKind.Unspecified).AddTicks(5184), "Maiores cumque molestias sit quaerat eveniet exercitationem.", 1, 1 },
                    { 188L, 64L, "Dolores non vel sequi quas cumque dignissimos. Voluptatibus et cumque molestias sunt pariatur praesentium distinctio asperiores hic. Enim facilis suscipit assumenda nisi laborum optio.", new DateTime(2023, 4, 17, 18, 43, 51, 692, DateTimeKind.Unspecified).AddTicks(1504), "Cumque ea occaecati sapiente aut impedit rerum error nemo magni.", 1, 2 },
                    { 189L, 53L, "Accusamus aut nam.\nAb quisquam et qui blanditiis autem vero.\nUt enim sit modi temporibus debitis.\nOmnis totam ut aut.\nProvident exercitationem numquam ducimus ut expedita eos.", new DateTime(2019, 4, 30, 19, 3, 22, 679, DateTimeKind.Unspecified).AddTicks(7993), "Quibusdam at hic.", 1, 2 },
                    { 190L, 41L, "Et ut molestiae eligendi. Accusamus sunt veritatis architecto voluptatum tenetur. Voluptas repellat dicta ab possimus quas blanditiis. Et et facilis id ad amet eaque ea aspernatur veniam. Eveniet rerum eum ut ipsam aut animi.", new DateTime(2021, 11, 20, 21, 13, 59, 959, DateTimeKind.Unspecified).AddTicks(9959), "Et eligendi deserunt laborum.", 4, 1 },
                    { 191L, 67L, "Rerum fugiat aut ea id ex magnam dolorum eligendi. Enim eum numquam sapiente temporibus molestiae. Dolorum earum explicabo.", new DateTime(2023, 8, 13, 8, 16, 10, 235, DateTimeKind.Unspecified).AddTicks(7208), "Id quibusdam veritatis.", 4, 0 },
                    { 192L, 35L, "Quos nisi accusantium et eligendi voluptate.", new DateTime(2022, 11, 15, 4, 38, 1, 982, DateTimeKind.Unspecified).AddTicks(4422), "Deserunt quia officia et earum non iure necessitatibus culpa praesentium.", 1, 3 },
                    { 193L, 54L, "Aut voluptatem nam quo facere quia rerum.\nHarum quas laboriosam corrupti natus ad sint dignissimos beatae ut.\nQuaerat consequuntur voluptatum sunt nemo explicabo velit assumenda non fugiat.", new DateTime(2021, 6, 26, 7, 30, 35, 825, DateTimeKind.Unspecified).AddTicks(8284), "Minima vel quod dignissimos vero illo consequatur eligendi.", 3, 3 },
                    { 194L, 47L, "Dolorem itaque laborum non. Impedit aut in provident. Ex dolorum omnis odio ex aut inventore. Similique velit mollitia rerum ipsa blanditiis aspernatur rerum.", new DateTime(2023, 8, 21, 5, 53, 52, 380, DateTimeKind.Unspecified).AddTicks(3573), "Sit officiis maiores voluptatibus et aut animi consequatur atque magni.", 4, 1 },
                    { 195L, 52L, "Aut error quibusdam.\nEt ea aspernatur sed dolore.\nNihil reprehenderit autem repudiandae qui modi eveniet nesciunt.\nVoluptatem quo odio vitae ut eos doloribus pariatur sed.\nVoluptas necessitatibus velit quia molestias iusto doloremque ratione placeat.", new DateTime(2023, 5, 27, 15, 24, 51, 592, DateTimeKind.Unspecified).AddTicks(4833), "Commodi assumenda sit animi deserunt eius.", 4, 3 },
                    { 196L, 36L, "Veritatis illum aliquid aliquid provident atque quaerat nesciunt.", new DateTime(2023, 3, 24, 3, 7, 25, 805, DateTimeKind.Unspecified).AddTicks(2412), "Dolorum sunt ab doloribus vero iusto.", 3, 2 },
                    { 197L, 7L, "ratione", new DateTime(2022, 10, 10, 6, 0, 34, 595, DateTimeKind.Unspecified).AddTicks(2866), "Consequatur aut enim et voluptatum omnis.", 2, 1 },
                    { 198L, 33L, "doloribus", new DateTime(2023, 4, 26, 15, 22, 25, 125, DateTimeKind.Unspecified).AddTicks(1837), "Praesentium delectus dicta.", 1, 0 },
                    { 199L, 66L, "modi", new DateTime(2022, 7, 8, 4, 25, 31, 463, DateTimeKind.Unspecified).AddTicks(9796), "Assumenda sequi ut unde rerum officia amet.", 4, 3 },
                    { 200L, 40L, "Quasi quidem occaecati totam labore.\nReiciendis esse quas impedit sunt alias.", new DateTime(2023, 4, 24, 22, 37, 14, 580, DateTimeKind.Unspecified).AddTicks(8255), "Consequuntur vel rerum ullam unde qui est debitis aspernatur.", 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "IsPublic" },
                values: new object[,]
                {
                    { 1L, 14L, "Fuga molestiae laborum architecto minus aut quisquam explicabo corporis.\nVeniam omnis et dolores temporibus voluptatem ea.\nIste odio quis delectus.\nDeleniti qui et consequatur.\nMinus illo quibusdam distinctio cumque nihil voluptate occaecati molestiae fuga.\nEx eos quibusdam ipsa nobis veritatis hic eaque.", new DateTime(2023, 5, 29, 20, 27, 33, 355, DateTimeKind.Unspecified).AddTicks(6024), false },
                    { 2L, 68L, "Ducimus velit expedita. Dolores soluta et minus. Commodi magnam dolorem dolorum veritatis autem sunt enim.", new DateTime(2022, 7, 14, 14, 13, 5, 650, DateTimeKind.Unspecified).AddTicks(5617), false },
                    { 3L, 115L, "corporis", new DateTime(2023, 6, 6, 19, 26, 32, 42, DateTimeKind.Unspecified).AddTicks(8615), false },
                    { 4L, 111L, "Eum corporis aliquam repellat neque temporibus.", new DateTime(2023, 6, 6, 12, 57, 42, 937, DateTimeKind.Unspecified).AddTicks(1658), true },
                    { 5L, 8L, "Rerum aut dolorum esse iusto autem vero odio necessitatibus.\nReiciendis voluptatum in nesciunt.\nVoluptates ratione quo id harum quo ut.", new DateTime(2023, 3, 18, 13, 40, 50, 456, DateTimeKind.Unspecified).AddTicks(8026), true },
                    { 6L, 100L, "Eaque et consequatur.", new DateTime(2023, 7, 28, 16, 51, 27, 286, DateTimeKind.Unspecified).AddTicks(4183), true },
                    { 7L, 123L, "In rerum dolores consequuntur cumque reiciendis iste.\nVoluptas omnis animi alias sed facilis odit.\nPerferendis cumque architecto quo nulla consectetur.\nQuasi impedit qui quis vitae maxime quidem ut pariatur quis.\nSuscipit quaerat cumque.", new DateTime(2023, 6, 11, 2, 52, 16, 82, DateTimeKind.Unspecified).AddTicks(7215), false },
                    { 8L, 154L, "Est assumenda vitae.\nQuam cumque ipsa voluptas ut rem architecto eligendi eum.\nEt quam debitis id rem voluptas est labore placeat harum.\nEnim pariatur facere ea.", new DateTime(2023, 7, 13, 5, 31, 0, 535, DateTimeKind.Unspecified).AddTicks(7204), true },
                    { 9L, 198L, "Voluptatem corporis fuga.", new DateTime(2023, 6, 10, 12, 38, 35, 151, DateTimeKind.Unspecified).AddTicks(9012), false },
                    { 10L, 27L, "Vel exercitationem ea hic quia.\nConsectetur illo magni quia est esse ducimus sit.\nNobis aut at nostrum molestiae totam.", new DateTime(2023, 5, 5, 8, 22, 12, 788, DateTimeKind.Unspecified).AddTicks(7054), true },
                    { 11L, 75L, "Voluptas autem saepe expedita explicabo eos vel itaque.", new DateTime(2023, 8, 15, 9, 38, 52, 274, DateTimeKind.Unspecified).AddTicks(6728), true },
                    { 12L, 163L, "Sed non quo non dolorem temporibus tempore.", new DateTime(2022, 10, 27, 21, 28, 43, 733, DateTimeKind.Unspecified).AddTicks(4434), true },
                    { 13L, 175L, "Cupiditate velit eum quo dolore magnam veritatis et est.", new DateTime(2023, 2, 27, 11, 44, 46, 100, DateTimeKind.Unspecified).AddTicks(3530), true },
                    { 14L, 130L, "Totam aperiam excepturi.", new DateTime(2023, 7, 8, 23, 20, 41, 768, DateTimeKind.Unspecified).AddTicks(5218), true },
                    { 15L, 163L, "Porro facere et eius.\nFuga vero deleniti dolorum deserunt vel sunt.\nRepellat aut quia dicta minus quo debitis et.", new DateTime(2023, 5, 19, 21, 30, 30, 969, DateTimeKind.Unspecified).AddTicks(8960), true },
                    { 16L, 114L, "Corporis quidem veritatis velit explicabo adipisci labore nam.\nVoluptas aperiam iste.\nTemporibus reprehenderit omnis.", new DateTime(2022, 8, 27, 18, 22, 18, 612, DateTimeKind.Unspecified).AddTicks(8646), true },
                    { 17L, 76L, "Cupiditate accusantium nesciunt aperiam ducimus non.\nVelit sit quas amet maiores iste nulla natus dolor porro.", new DateTime(2021, 3, 22, 1, 57, 1, 718, DateTimeKind.Unspecified).AddTicks(4088), true },
                    { 18L, 11L, "quibusdam", new DateTime(2023, 5, 24, 22, 41, 1, 430, DateTimeKind.Unspecified).AddTicks(9800), true },
                    { 19L, 7L, "pariatur", new DateTime(2023, 8, 8, 7, 10, 55, 130, DateTimeKind.Unspecified).AddTicks(5931), false },
                    { 20L, 121L, "culpa", new DateTime(2023, 6, 22, 11, 35, 12, 229, DateTimeKind.Unspecified).AddTicks(7725), false },
                    { 21L, 13L, "aliquam", new DateTime(2023, 7, 12, 6, 29, 30, 360, DateTimeKind.Unspecified).AddTicks(1944), false },
                    { 22L, 181L, "Non quis eaque incidunt. Eius iure rerum dolorem magnam nihil reprehenderit. Aut voluptatibus ut ea beatae accusamus eius odit. Id eum libero id cupiditate. Expedita et sit similique eos et cupiditate aut est vero. Illum deserunt magni aut sit.", new DateTime(2022, 5, 10, 14, 0, 13, 32, DateTimeKind.Unspecified).AddTicks(1601), true },
                    { 23L, 143L, "enim", new DateTime(2023, 6, 26, 4, 3, 53, 530, DateTimeKind.Unspecified).AddTicks(3088), true },
                    { 24L, 199L, "Velit voluptas expedita. Consequatur optio laudantium quis sed et dolores. Architecto qui dolor cumque quas. Illo fuga reiciendis quia ad atque ipsum ex laudantium. Earum et tenetur cum voluptatum et quia eaque.", new DateTime(2023, 1, 27, 15, 10, 45, 886, DateTimeKind.Unspecified).AddTicks(6572), true },
                    { 25L, 169L, "magni", new DateTime(2023, 8, 7, 1, 38, 56, 862, DateTimeKind.Unspecified).AddTicks(3389), true },
                    { 26L, 26L, "Est sunt perferendis aut blanditiis. Ipsa inventore debitis quos quia reprehenderit blanditiis incidunt aut. Exercitationem aut blanditiis dolor blanditiis.", new DateTime(2023, 8, 10, 18, 0, 13, 186, DateTimeKind.Unspecified).AddTicks(385), true },
                    { 27L, 187L, "minima", new DateTime(2023, 5, 5, 20, 58, 53, 980, DateTimeKind.Unspecified).AddTicks(7147), true },
                    { 28L, 134L, "Non ab at error non ea et quo. Natus ducimus perspiciatis illum eveniet eaque. Voluptas dolores dolor voluptatem enim praesentium pariatur deleniti hic corporis.", new DateTime(2023, 8, 3, 10, 35, 28, 392, DateTimeKind.Unspecified).AddTicks(5681), true },
                    { 29L, 108L, "Deleniti praesentium laudantium.\nAutem labore esse recusandae laborum dolorum.\nEveniet soluta mollitia necessitatibus ipsam.\nQuae dolorem rerum tempore.\nEa totam velit autem et fuga est quia non.\nQuidem quam et ea iusto harum excepturi dicta beatae et.", new DateTime(2023, 7, 22, 14, 52, 13, 941, DateTimeKind.Unspecified).AddTicks(5337), true },
                    { 30L, 101L, "Velit ex itaque eos eum. Ex fuga illo repellat non. Fuga autem et. Est laudantium quaerat voluptatem provident. Aut est provident vitae natus et voluptatem. Aliquid et in voluptatem non suscipit eum quasi.", new DateTime(2022, 3, 30, 0, 8, 4, 628, DateTimeKind.Unspecified).AddTicks(7916), true },
                    { 31L, 200L, "Odio nihil molestias praesentium quis.", new DateTime(2023, 4, 25, 13, 23, 20, 318, DateTimeKind.Unspecified).AddTicks(9181), true },
                    { 32L, 11L, "Qui aut voluptatum sit voluptas corporis est.\nCorporis nisi facilis delectus molestiae ea culpa voluptates et et.\nEt velit sunt modi dignissimos sit voluptatem dolorum ad et.\nNihil cumque unde.\nDignissimos voluptas eos.", new DateTime(2023, 1, 4, 14, 47, 56, 799, DateTimeKind.Unspecified).AddTicks(3810), false },
                    { 33L, 78L, "Sapiente autem praesentium vitae.\nNihil dicta laboriosam.", new DateTime(2023, 8, 13, 1, 8, 35, 895, DateTimeKind.Unspecified).AddTicks(2499), true },
                    { 34L, 128L, "Distinctio aperiam ratione corporis soluta qui quos incidunt.", new DateTime(2023, 1, 14, 2, 32, 21, 864, DateTimeKind.Unspecified).AddTicks(3815), false },
                    { 35L, 145L, "Magnam ab at officiis omnis ad inventore tenetur voluptatem est.", new DateTime(2022, 7, 27, 3, 52, 39, 604, DateTimeKind.Unspecified).AddTicks(8257), false },
                    { 36L, 8L, "Voluptatem consequatur facere optio porro libero eum et.\nOccaecati dolor facilis et voluptas pariatur.\nEligendi amet blanditiis.", new DateTime(2023, 4, 1, 21, 43, 3, 153, DateTimeKind.Unspecified).AddTicks(5667), true },
                    { 37L, 16L, "Est in eum nihil commodi. Rerum ratione et voluptatem. Nam eligendi velit culpa modi hic iusto et aspernatur esse. Recusandae quibusdam nobis. Sit aut nemo dolore aut.", new DateTime(2023, 5, 27, 10, 48, 11, 866, DateTimeKind.Unspecified).AddTicks(1681), true },
                    { 38L, 56L, "Deleniti beatae ex exercitationem et ea. Repudiandae autem repellat. Officiis illum ut beatae est quam et quisquam laudantium officia. Aut fugiat est quo magnam sint eos molestiae.", new DateTime(2023, 1, 14, 11, 3, 30, 258, DateTimeKind.Unspecified).AddTicks(8187), true },
                    { 39L, 148L, "Necessitatibus aut repudiandae est molestiae. Enim magnam laboriosam labore corrupti impedit est iure qui omnis. Consequatur vero maxime delectus. Occaecati distinctio voluptatem quos illo rerum est.", new DateTime(2023, 6, 10, 17, 37, 52, 688, DateTimeKind.Unspecified).AddTicks(6833), true },
                    { 40L, 160L, "quisquam", new DateTime(2023, 8, 9, 21, 59, 35, 961, DateTimeKind.Unspecified).AddTicks(8751), true },
                    { 41L, 141L, "sed", new DateTime(2023, 6, 30, 10, 42, 25, 520, DateTimeKind.Unspecified).AddTicks(5517), true },
                    { 42L, 101L, "Ut perspiciatis autem rem id est aperiam.", new DateTime(2023, 3, 24, 3, 42, 2, 898, DateTimeKind.Unspecified).AddTicks(1710), false }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "IsPublic" },
                values: new object[,]
                {
                    { 43L, 74L, "Veniam magnam dolores et fugiat.", new DateTime(2023, 4, 17, 3, 46, 23, 803, DateTimeKind.Unspecified).AddTicks(6083), true },
                    { 44L, 21L, "Alias officia quia animi ratione enim sequi voluptatem.\nAperiam maiores enim.\nCumque culpa nisi alias nihil veritatis sed.\nVoluptas iusto sit cumque culpa.", new DateTime(2022, 1, 21, 14, 41, 40, 642, DateTimeKind.Unspecified).AddTicks(9365), false },
                    { 45L, 81L, "Eos ut voluptates temporibus aut in quia rerum tempora voluptas.", new DateTime(2023, 1, 28, 2, 39, 7, 384, DateTimeKind.Unspecified).AddTicks(6002), true },
                    { 46L, 31L, "Rerum minus magnam voluptatem non ut laborum sit veniam cum.", new DateTime(2023, 3, 8, 7, 55, 44, 943, DateTimeKind.Unspecified).AddTicks(2291), false },
                    { 47L, 8L, "Voluptatem est qui quia velit.\nRepudiandae cumque earum debitis illum fugiat aliquid hic.", new DateTime(2022, 11, 10, 3, 55, 40, 735, DateTimeKind.Unspecified).AddTicks(6241), true },
                    { 48L, 16L, "Et aperiam aut doloribus magnam. Fuga fugit est non modi voluptatem inventore. Eos sint amet quia non amet. Omnis vitae et vitae omnis voluptatibus suscipit quidem ab. Qui officiis et tempore tempora ut sequi officiis nulla.", new DateTime(2023, 8, 19, 10, 7, 47, 536, DateTimeKind.Unspecified).AddTicks(7215), false },
                    { 49L, 102L, "Et omnis officiis consequatur cupiditate sint vero incidunt.", new DateTime(2022, 1, 13, 0, 33, 5, 342, DateTimeKind.Unspecified).AddTicks(7443), true },
                    { 50L, 27L, "Rem qui quis voluptatum cum nobis beatae dignissimos quaerat aut. Perspiciatis doloremque corporis nobis aut sit in libero repellat culpa. Aut cupiditate fugit.", new DateTime(2023, 8, 9, 19, 48, 12, 832, DateTimeKind.Unspecified).AddTicks(8404), false },
                    { 51L, 81L, "Est enim illum magnam.", new DateTime(2023, 6, 18, 8, 51, 53, 813, DateTimeKind.Unspecified).AddTicks(1204), true },
                    { 52L, 180L, "Minus in inventore sint et.", new DateTime(2023, 7, 7, 23, 37, 50, 356, DateTimeKind.Unspecified).AddTicks(5544), false },
                    { 53L, 9L, "Provident corrupti quis sequi voluptas rem.\nVoluptas commodi unde optio dolorem architecto.\nVelit facilis qui.\nUt nihil quia eligendi veniam itaque quam occaecati atque.", new DateTime(2021, 11, 16, 8, 35, 17, 85, DateTimeKind.Unspecified).AddTicks(8273), true },
                    { 54L, 74L, "et", new DateTime(2023, 5, 23, 7, 40, 8, 864, DateTimeKind.Unspecified).AddTicks(7142), false },
                    { 55L, 133L, "maiores", new DateTime(2023, 7, 1, 2, 59, 13, 407, DateTimeKind.Unspecified).AddTicks(851), false },
                    { 56L, 46L, "Placeat aperiam voluptate maiores molestias accusamus aliquam magnam odit et. Quasi quo quia. Minus aut maiores iusto dolores.", new DateTime(2023, 1, 12, 8, 46, 33, 369, DateTimeKind.Unspecified).AddTicks(3152), true },
                    { 57L, 176L, "Beatae expedita et eos ut. Corporis minus provident ut perferendis sed aut quia. Rerum dolores dolor dolore voluptates.", new DateTime(2023, 5, 16, 20, 12, 24, 931, DateTimeKind.Unspecified).AddTicks(2311), false },
                    { 58L, 54L, "Ut rerum minus dignissimos est est rerum numquam autem mollitia. Dolore nobis voluptatum voluptas. Tempore ducimus quisquam.", new DateTime(2023, 8, 17, 7, 24, 35, 385, DateTimeKind.Unspecified).AddTicks(6407), true },
                    { 59L, 154L, "Atque omnis consectetur quam. Voluptatem dolores maxime voluptatem. Esse repellat sunt magni ea. Omnis eum omnis optio necessitatibus explicabo assumenda qui.", new DateTime(2023, 7, 19, 20, 9, 7, 298, DateTimeKind.Unspecified).AddTicks(8554), true },
                    { 60L, 187L, "nulla", new DateTime(2023, 5, 4, 14, 0, 20, 135, DateTimeKind.Unspecified).AddTicks(9721), true },
                    { 61L, 116L, "Quis inventore optio quibusdam et.", new DateTime(2023, 5, 22, 13, 2, 31, 906, DateTimeKind.Unspecified).AddTicks(6407), true },
                    { 62L, 157L, "Aut qui voluptatem voluptatem dolorum.\nDebitis voluptatibus facilis veniam iure.", new DateTime(2023, 6, 16, 22, 31, 52, 855, DateTimeKind.Unspecified).AddTicks(4553), true },
                    { 63L, 31L, "Eveniet sunt non nostrum est illum voluptas nisi tenetur delectus. Sed est eum et officia autem distinctio distinctio accusamus. Tempora soluta non qui maxime doloribus eveniet ad est ratione. Quod quia id sunt ut inventore quas voluptas. Aut libero veniam quia dolor repellat. A adipisci aliquam doloribus quaerat delectus ipsa tempore voluptate repellat.", new DateTime(2022, 10, 30, 3, 6, 48, 611, DateTimeKind.Unspecified).AddTicks(6057), false },
                    { 64L, 32L, "Illum ipsa praesentium non dolor. Et id nesciunt saepe qui voluptates natus in dicta. Maxime explicabo earum beatae qui.", new DateTime(2023, 8, 13, 17, 29, 12, 848, DateTimeKind.Unspecified).AddTicks(1657), true },
                    { 65L, 33L, "non", new DateTime(2023, 2, 1, 11, 32, 5, 593, DateTimeKind.Unspecified).AddTicks(6663), false },
                    { 66L, 169L, "Et commodi laudantium vitae voluptatem rem fugit.\nCulpa occaecati fugiat.\nSimilique magni fugit aut voluptates.\nSed minus consequatur asperiores voluptates distinctio qui soluta ducimus.\nOptio facilis eum sint hic eos consequatur adipisci recusandae.\nIpsa ad reiciendis.", new DateTime(2023, 8, 20, 14, 31, 14, 556, DateTimeKind.Unspecified).AddTicks(9496), true },
                    { 67L, 31L, "Quia hic illum.", new DateTime(2019, 7, 15, 20, 4, 42, 828, DateTimeKind.Unspecified).AddTicks(2602), true },
                    { 68L, 95L, "Voluptates blanditiis aut dolores quidem voluptatem ut.\nRecusandae eligendi ipsam velit impedit quia.\nBeatae et placeat voluptas facere nesciunt dolores aperiam suscipit dolores.", new DateTime(2022, 10, 10, 16, 32, 44, 641, DateTimeKind.Unspecified).AddTicks(3551), true },
                    { 69L, 105L, "Asperiores quod suscipit explicabo id consequuntur molestias ea.\nQuo dignissimos error sit aut.\nEt dolorem ut architecto nesciunt consequatur soluta blanditiis.\nEsse nihil totam alias dolorem.", new DateTime(2023, 7, 26, 2, 27, 48, 226, DateTimeKind.Unspecified).AddTicks(6687), true },
                    { 70L, 144L, "Voluptatem tempore quis doloremque dolor hic qui ut deserunt ipsa.", new DateTime(2023, 6, 6, 16, 42, 54, 948, DateTimeKind.Unspecified).AddTicks(1687), false },
                    { 71L, 136L, "Aut cum magni rem nihil nisi ipsam veniam ut.", new DateTime(2023, 8, 22, 22, 49, 53, 563, DateTimeKind.Unspecified).AddTicks(2052), true },
                    { 72L, 77L, "Voluptatum officia non sed est consequatur magni autem.\nConsequuntur omnis voluptatem dicta esse est atque in.\nSit consectetur pariatur aut.", new DateTime(2023, 8, 5, 19, 58, 31, 186, DateTimeKind.Unspecified).AddTicks(7620), false },
                    { 73L, 81L, "iure", new DateTime(2023, 7, 12, 10, 44, 16, 353, DateTimeKind.Unspecified).AddTicks(2758), true },
                    { 74L, 83L, "Aut et error consequuntur est est quidem vel nulla aut.", new DateTime(2023, 8, 10, 4, 42, 33, 155, DateTimeKind.Unspecified).AddTicks(3089), true },
                    { 75L, 104L, "Accusamus voluptatem adipisci quod.", new DateTime(2023, 5, 23, 2, 58, 57, 902, DateTimeKind.Unspecified).AddTicks(1689), true },
                    { 76L, 185L, "Minima natus nobis et. Dignissimos vero fugiat officiis voluptates modi pariatur cupiditate. Molestiae molestias consequatur ut delectus eligendi eaque ut voluptatem. Occaecati vitae nesciunt quia est natus et maiores consectetur.", new DateTime(2023, 6, 15, 9, 58, 32, 210, DateTimeKind.Unspecified).AddTicks(5442), true },
                    { 77L, 63L, "Odio iste excepturi. Voluptate consequatur sit quibusdam iusto vel aut sapiente optio. Soluta dolorem perferendis et et explicabo facilis quis minus veritatis.", new DateTime(2022, 12, 24, 19, 11, 26, 268, DateTimeKind.Unspecified).AddTicks(8580), false },
                    { 78L, 159L, "Voluptas omnis dolorem incidunt non.\nNon voluptatum voluptates est.\nQuis est enim omnis animi consequatur beatae.\nFacere molestiae nulla ab aut rem sequi.\nDucimus voluptatum error est ea velit fugit aut praesentium.", new DateTime(2023, 6, 6, 9, 44, 54, 239, DateTimeKind.Unspecified).AddTicks(5189), true },
                    { 79L, 103L, "Sit magni deserunt ea error quam ullam.\nVoluptatum nesciunt voluptatem nulla necessitatibus repellat quas veritatis.\nAutem ipsam beatae alias ut alias ratione dicta est.\nCorporis aut et eligendi delectus.\nSaepe excepturi et.", new DateTime(2023, 8, 2, 21, 6, 54, 679, DateTimeKind.Unspecified).AddTicks(614), true },
                    { 80L, 71L, "Possimus dicta et quia.", new DateTime(2023, 8, 23, 5, 0, 54, 666, DateTimeKind.Unspecified).AddTicks(7686), true },
                    { 81L, 103L, "Aut tempora natus provident maiores magni ducimus enim. Vitae repellat voluptates sunt laudantium amet minus repellat atque qui. Facilis repellendus repudiandae non dolore quaerat iure. Id vel commodi ut architecto velit nobis id omnis ea. Temporibus et voluptas harum voluptatem voluptatem nulla.", new DateTime(2023, 7, 5, 8, 40, 8, 425, DateTimeKind.Unspecified).AddTicks(8691), true },
                    { 82L, 159L, "Quis dolor veritatis modi ipsam harum.\nEst quod molestias provident in.\nEst quo autem dolor ducimus dolor rerum sapiente.", new DateTime(2023, 7, 29, 10, 33, 36, 244, DateTimeKind.Unspecified).AddTicks(5551), true },
                    { 83L, 157L, "mollitia", new DateTime(2023, 7, 5, 21, 32, 55, 99, DateTimeKind.Unspecified).AddTicks(8924), true },
                    { 84L, 24L, "sint", new DateTime(2023, 8, 16, 15, 43, 56, 293, DateTimeKind.Unspecified).AddTicks(5427), true }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "IsPublic" },
                values: new object[,]
                {
                    { 85L, 69L, "Praesentium quam et quasi. Quae iste nemo inventore mollitia quas aut eos quis. Odio deserunt non culpa eligendi quaerat architecto. Pariatur necessitatibus reiciendis molestias deserunt esse molestiae pariatur. Earum labore voluptatem accusantium quaerat similique nesciunt maxime. Quos explicabo repellat ad iure est et ut soluta iste.", new DateTime(2023, 4, 1, 22, 47, 17, 193, DateTimeKind.Unspecified).AddTicks(3676), true },
                    { 86L, 68L, "Quasi sit qui ut delectus saepe et maxime. Et eveniet illo perspiciatis dolor voluptatem quis fugiat omnis. Voluptatibus quisquam sunt et consequatur facilis et id officiis. Ad quod ea recusandae voluptas consectetur iure.", new DateTime(2023, 7, 30, 18, 19, 51, 970, DateTimeKind.Unspecified).AddTicks(161), true },
                    { 87L, 44L, "Dignissimos quia quo consequatur et.\nProvident aut error dignissimos fugit ea voluptatibus.\nSoluta blanditiis eveniet quisquam nesciunt possimus.\nNatus voluptas sed sed.", new DateTime(2023, 2, 19, 23, 53, 25, 83, DateTimeKind.Unspecified).AddTicks(1337), false },
                    { 88L, 159L, "harum", new DateTime(2023, 6, 23, 9, 5, 9, 556, DateTimeKind.Unspecified).AddTicks(4228), true },
                    { 89L, 47L, "Dolor expedita fugiat odio.", new DateTime(2023, 4, 7, 23, 47, 26, 599, DateTimeKind.Unspecified).AddTicks(8373), true },
                    { 90L, 74L, "Provident nisi eligendi nihil.\nNemo et odio impedit perferendis rerum asperiores quia eligendi qui.\nEveniet itaque non est hic rerum excepturi.", new DateTime(2023, 6, 19, 16, 39, 53, 509, DateTimeKind.Unspecified).AddTicks(535), true },
                    { 91L, 185L, "minima", new DateTime(2023, 7, 31, 22, 50, 38, 782, DateTimeKind.Unspecified).AddTicks(7151), true },
                    { 92L, 89L, "Officia officiis exercitationem non voluptatem. Unde est consequatur qui et. Deleniti eos vero est.", new DateTime(2023, 8, 8, 0, 21, 54, 222, DateTimeKind.Unspecified).AddTicks(7950), true },
                    { 93L, 46L, "Eum voluptas sed vitae et delectus sint nostrum.\nEaque sapiente aut odit quo.\nDelectus temporibus id aspernatur.", new DateTime(2022, 11, 12, 3, 30, 47, 418, DateTimeKind.Unspecified).AddTicks(6670), true },
                    { 94L, 64L, "voluptatem", new DateTime(2021, 12, 19, 7, 42, 24, 238, DateTimeKind.Unspecified).AddTicks(585), false },
                    { 95L, 22L, "aut", new DateTime(2023, 5, 6, 14, 33, 44, 173, DateTimeKind.Unspecified).AddTicks(5023), true },
                    { 96L, 135L, "Ut est quasi. Qui quia occaecati. Quia eius animi aperiam. Excepturi voluptatum consequatur quia. Et similique assumenda sed aut omnis voluptatem. Ipsam ipsam quia delectus culpa rerum neque.", new DateTime(2023, 7, 24, 9, 34, 58, 720, DateTimeKind.Unspecified).AddTicks(6516), true },
                    { 97L, 54L, "Voluptatem iste et sint aut quisquam necessitatibus.\nEst et ullam eveniet fugiat.\nAutem enim assumenda voluptas nemo voluptas quae necessitatibus sed recusandae.\nQuidem porro officiis rem.", new DateTime(2023, 8, 15, 21, 34, 7, 831, DateTimeKind.Unspecified).AddTicks(6163), true },
                    { 98L, 158L, "Aut pariatur quis.\nIpsa molestiae aliquam et vel et quasi maxime tenetur.", new DateTime(2023, 5, 11, 17, 10, 10, 755, DateTimeKind.Unspecified).AddTicks(9106), true },
                    { 99L, 93L, "Possimus totam magni aliquid maiores cum.", new DateTime(2018, 12, 22, 12, 18, 51, 322, DateTimeKind.Unspecified).AddTicks(1285), true },
                    { 100L, 8L, "Non dolore quibusdam aut commodi. Deleniti veritatis voluptatem laboriosam temporibus voluptatem. Doloremque dolorem necessitatibus omnis dicta quasi. Fugiat tempore saepe similique sint distinctio et est voluptatem.", new DateTime(2023, 3, 12, 11, 52, 23, 206, DateTimeKind.Unspecified).AddTicks(7778), true },
                    { 101L, 139L, "perspiciatis", new DateTime(2023, 8, 21, 22, 18, 4, 861, DateTimeKind.Unspecified).AddTicks(3530), false },
                    { 102L, 196L, "nihil", new DateTime(2023, 5, 14, 11, 10, 5, 697, DateTimeKind.Unspecified).AddTicks(947), false },
                    { 103L, 136L, "quam", new DateTime(2023, 8, 23, 7, 47, 15, 209, DateTimeKind.Unspecified).AddTicks(4873), false },
                    { 104L, 32L, "Et non quod et iusto sed aliquid. Delectus nihil iste accusamus. Tempora molestiae nisi inventore pariatur suscipit nisi earum. Nam explicabo quibusdam dolores cupiditate voluptatum saepe ab. Voluptates aspernatur maxime autem atque nihil in odit.", new DateTime(2023, 8, 11, 5, 13, 54, 258, DateTimeKind.Unspecified).AddTicks(2765), true },
                    { 105L, 85L, "quisquam", new DateTime(2021, 7, 5, 7, 4, 31, 976, DateTimeKind.Unspecified).AddTicks(1587), true },
                    { 106L, 48L, "Consequatur fugit dolorum dolorem et. Voluptatem est fugiat earum perferendis debitis suscipit. Consequatur est est repellat et odio rerum atque quod dolor. Modi officia earum tempore tempore ut id voluptatibus natus.", new DateTime(2020, 2, 19, 9, 32, 59, 975, DateTimeKind.Unspecified).AddTicks(886), true },
                    { 107L, 82L, "Modi inventore quod dolorem. Mollitia eum amet porro. Aliquid mollitia quos illo eligendi voluptas autem odio ullam.", new DateTime(2023, 5, 24, 7, 42, 43, 755, DateTimeKind.Unspecified).AddTicks(9263), false },
                    { 108L, 62L, "Velit eveniet omnis. Quam ea voluptas aut consectetur eius culpa quod. Eaque enim quo ea tempora eveniet voluptatem.", new DateTime(2023, 6, 28, 4, 37, 44, 475, DateTimeKind.Unspecified).AddTicks(5534), true },
                    { 109L, 162L, "Pariatur harum impedit ad. Vitae culpa magni minus cumque est quas ullam velit excepturi. Ullam fugiat fugit officia et ea accusantium sunt. Explicabo beatae quo qui ullam ut voluptates. Quia excepturi quia quia repudiandae voluptatem et nesciunt odio. Sunt tempora eveniet non atque.", new DateTime(2023, 2, 14, 5, 2, 52, 363, DateTimeKind.Unspecified).AddTicks(7585), true },
                    { 110L, 65L, "facere", new DateTime(2022, 8, 9, 3, 27, 59, 807, DateTimeKind.Unspecified).AddTicks(8184), true },
                    { 111L, 77L, "Consequatur alias quod ea iusto qui optio minus.\nUt corporis ut.", new DateTime(2023, 8, 4, 13, 10, 9, 516, DateTimeKind.Unspecified).AddTicks(1285), true },
                    { 112L, 119L, "Aspernatur qui nisi nam neque.", new DateTime(2023, 5, 29, 7, 26, 56, 428, DateTimeKind.Unspecified).AddTicks(4834), true },
                    { 113L, 8L, "Nesciunt ducimus quibusdam veritatis animi eaque sed excepturi dolores esse.", new DateTime(2023, 7, 7, 23, 58, 41, 867, DateTimeKind.Unspecified).AddTicks(8959), false },
                    { 114L, 143L, "Qui quas illo molestiae in eos saepe quae ut.\nAutem quae facilis velit.", new DateTime(2023, 8, 19, 14, 38, 55, 861, DateTimeKind.Unspecified).AddTicks(1206), true },
                    { 115L, 49L, "Exercitationem quo nihil et sit. Sed aut quia. Est vel et voluptas. Non beatae inventore. Sit omnis placeat porro ducimus.", new DateTime(2023, 8, 18, 2, 54, 56, 358, DateTimeKind.Unspecified).AddTicks(2210), true },
                    { 116L, 155L, "nihil", new DateTime(2023, 8, 16, 17, 42, 0, 757, DateTimeKind.Unspecified).AddTicks(876), false },
                    { 117L, 199L, "Maxime et omnis dolore sunt voluptatem rerum. Fugit ut voluptatibus unde ipsam ea amet consectetur. Omnis cupiditate id unde sed aliquam quaerat doloremque eos aperiam. Omnis ipsam dolorum qui fuga. Voluptatem qui cupiditate vel qui repellat libero voluptatem id. Quaerat est omnis soluta occaecati culpa accusantium odio totam qui.", new DateTime(2023, 2, 16, 20, 32, 5, 118, DateTimeKind.Unspecified).AddTicks(7599), true },
                    { 118L, 160L, "Iusto doloribus in quia.", new DateTime(2022, 12, 31, 23, 4, 53, 956, DateTimeKind.Unspecified).AddTicks(5329), false },
                    { 119L, 197L, "Praesentium nam vitae qui. Quasi non sint aliquid repellat nihil qui. Temporibus ut nostrum sit ex. Quibusdam rerum sit incidunt mollitia exercitationem. Sunt pariatur aut.", new DateTime(2023, 5, 15, 9, 53, 49, 99, DateTimeKind.Unspecified).AddTicks(1923), true },
                    { 120L, 13L, "ut", new DateTime(2023, 8, 19, 21, 26, 45, 914, DateTimeKind.Unspecified).AddTicks(5293), false },
                    { 121L, 59L, "Laudantium odit adipisci.\nAutem pariatur quidem temporibus sed.\nQuod aut odio minus et ad iusto.\nNon occaecati reiciendis cum quo commodi.\nId error consequatur est illo ut error esse velit sit.\nDoloribus recusandae et dignissimos quis corporis est.", new DateTime(2023, 1, 4, 10, 3, 16, 623, DateTimeKind.Unspecified).AddTicks(1558), true },
                    { 122L, 9L, "quis", new DateTime(2022, 7, 31, 1, 37, 36, 639, DateTimeKind.Unspecified).AddTicks(9360), false },
                    { 123L, 80L, "Nihil explicabo temporibus.", new DateTime(2021, 9, 30, 12, 51, 13, 471, DateTimeKind.Unspecified).AddTicks(6152), false },
                    { 124L, 166L, "veniam", new DateTime(2022, 12, 2, 7, 38, 48, 6, DateTimeKind.Unspecified).AddTicks(6005), true },
                    { 125L, 79L, "quia", new DateTime(2023, 3, 7, 22, 57, 11, 392, DateTimeKind.Unspecified).AddTicks(7876), true },
                    { 126L, 15L, "Nobis vitae ratione cum doloremque esse quia. Quos minima assumenda earum in necessitatibus voluptatum. Voluptatem ut dolores nesciunt provident maxime neque perspiciatis et et. Et et eius aut.", new DateTime(2023, 8, 12, 5, 42, 52, 384, DateTimeKind.Unspecified).AddTicks(8605), true }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "IsPublic" },
                values: new object[,]
                {
                    { 127L, 106L, "Quam omnis reiciendis nihil et. Consequatur inventore quia sunt enim cumque in. Eos fugiat consequuntur aut earum et animi iusto.", new DateTime(2023, 8, 1, 21, 55, 3, 806, DateTimeKind.Unspecified).AddTicks(2819), true },
                    { 128L, 1L, "Eligendi odio animi sed totam porro.\nDolor sequi qui qui dolor sequi corrupti sed non vero.\nMolestias molestias sit labore autem.", new DateTime(2022, 8, 5, 6, 26, 10, 408, DateTimeKind.Unspecified).AddTicks(800), false },
                    { 129L, 192L, "Eligendi est aut exercitationem.\nCommodi soluta ut sequi ut nobis consequatur.\nCum tempore et.\nVoluptas fugit ipsam animi molestiae eligendi sit omnis vel.\nVeritatis animi nostrum vel ipsa sint.\nLaudantium et dolorum rerum perspiciatis quia iusto.", new DateTime(2022, 12, 21, 22, 30, 8, 604, DateTimeKind.Unspecified).AddTicks(5202), false },
                    { 130L, 40L, "Natus cumque possimus et quia natus libero harum voluptatem a. Provident incidunt voluptates dolorum quis eos at facilis saepe provident. Accusamus fuga aut modi. Debitis rerum quisquam natus ea veritatis odio saepe commodi voluptas. Inventore deleniti dolore repudiandae.", new DateTime(2022, 7, 9, 8, 22, 19, 428, DateTimeKind.Unspecified).AddTicks(3278), false },
                    { 131L, 37L, "Numquam illum officia voluptas ad.", new DateTime(2023, 1, 10, 10, 1, 2, 128, DateTimeKind.Unspecified).AddTicks(4427), false },
                    { 132L, 94L, "Dolores amet aspernatur similique autem asperiores ut in similique.", new DateTime(2022, 10, 6, 20, 11, 19, 896, DateTimeKind.Unspecified).AddTicks(8304), false },
                    { 133L, 187L, "Quidem quibusdam neque est dolorum sit accusantium.", new DateTime(2023, 8, 11, 23, 51, 8, 617, DateTimeKind.Unspecified).AddTicks(472), true },
                    { 134L, 13L, "Aut veniam dolor. Eaque unde non impedit eaque. Repudiandae blanditiis sint expedita dignissimos quia aut occaecati velit natus.", new DateTime(2023, 7, 22, 18, 7, 47, 348, DateTimeKind.Unspecified).AddTicks(163), true },
                    { 135L, 157L, "nesciunt", new DateTime(2023, 7, 16, 19, 19, 29, 338, DateTimeKind.Unspecified).AddTicks(6617), true },
                    { 136L, 38L, "expedita", new DateTime(2022, 9, 12, 15, 54, 30, 440, DateTimeKind.Unspecified).AddTicks(6902), false },
                    { 137L, 167L, "Reprehenderit numquam facere. Qui illum mollitia quo magnam consectetur. Ea qui consequatur facilis iure culpa et doloribus. Aut nesciunt aspernatur aliquam eius est excepturi eum. Quia est aut asperiores voluptas qui libero assumenda minus.", new DateTime(2023, 7, 15, 3, 3, 43, 907, DateTimeKind.Unspecified).AddTicks(721), true },
                    { 138L, 25L, "Vitae ut eius reprehenderit perferendis et quia ut a maiores.\nUt fugit dolores dolore alias.\nNumquam quasi magni totam est.\nAliquam beatae aut dolorum pariatur.\nQuod et neque reprehenderit magni quia magnam quas.", new DateTime(2023, 8, 22, 16, 25, 29, 726, DateTimeKind.Unspecified).AddTicks(7554), true },
                    { 139L, 198L, "Aut sit dolores. Ad atque fugiat itaque reprehenderit sunt quidem. Ex est delectus enim eaque dolor. Similique numquam sint voluptatem voluptas.", new DateTime(2023, 8, 22, 20, 47, 38, 152, DateTimeKind.Unspecified).AddTicks(7922), true },
                    { 140L, 142L, "Nulla aspernatur numquam reiciendis.", new DateTime(2021, 11, 11, 0, 0, 59, 965, DateTimeKind.Unspecified).AddTicks(92), true },
                    { 141L, 124L, "Commodi eum aut cum officia.\nHarum qui facilis ut consequatur sit temporibus iste et.\nSunt accusamus expedita similique tenetur corrupti suscipit facere unde.\nQuam occaecati est magnam qui est.", new DateTime(2023, 8, 21, 14, 39, 3, 670, DateTimeKind.Unspecified).AddTicks(6220), false },
                    { 142L, 79L, "Natus vitae ex dolores.\nA autem sint enim distinctio.\nUt voluptatem consequatur.\nPariatur reprehenderit debitis quos ab consequuntur fugit suscipit aut quia.", new DateTime(2022, 12, 7, 7, 44, 24, 226, DateTimeKind.Unspecified).AddTicks(3524), false },
                    { 143L, 87L, "Sit qui nulla nemo sunt numquam blanditiis.\nVel vel aperiam neque.\nPraesentium maxime doloribus commodi et assumenda dignissimos sed dolore.\nSed ducimus placeat et quia.\nVoluptatem nostrum et ex aspernatur debitis molestias quam inventore aliquid.\nRecusandae id fugit tempore explicabo tenetur in et.", new DateTime(2023, 5, 19, 12, 12, 11, 764, DateTimeKind.Unspecified).AddTicks(6510), true },
                    { 144L, 46L, "Excepturi dignissimos recusandae aperiam qui eos dolorem aut dolores quia.", new DateTime(2023, 1, 2, 9, 19, 50, 289, DateTimeKind.Unspecified).AddTicks(4974), true },
                    { 145L, 28L, "Ut similique nemo ducimus magni excepturi vel. Est voluptatem dolores quia. Saepe natus nihil consequatur eos nulla et. Voluptatum eligendi adipisci non nam quibusdam error rerum qui et. Voluptates quasi adipisci fugiat.", new DateTime(2023, 8, 11, 10, 59, 52, 874, DateTimeKind.Unspecified).AddTicks(8148), false },
                    { 146L, 161L, "et", new DateTime(2023, 6, 7, 7, 24, 34, 815, DateTimeKind.Unspecified).AddTicks(5925), true },
                    { 147L, 128L, "Vel et et cupiditate vitae quis sapiente aut.", new DateTime(2023, 7, 7, 23, 49, 48, 204, DateTimeKind.Unspecified).AddTicks(3137), false },
                    { 148L, 94L, "sint", new DateTime(2023, 6, 24, 17, 21, 23, 475, DateTimeKind.Unspecified).AddTicks(1760), false },
                    { 149L, 32L, "odit", new DateTime(2023, 7, 22, 6, 15, 26, 256, DateTimeKind.Unspecified).AddTicks(8809), true },
                    { 150L, 24L, "Similique ipsum ab nulla officia eos magni maiores.\nDebitis veniam iste rerum commodi et quos amet ut.\nIusto tenetur accusantium sint nisi quis.\nIste ut unde sit.\nEos unde necessitatibus tenetur voluptates voluptatem.", new DateTime(2023, 7, 28, 5, 34, 30, 41, DateTimeKind.Unspecified).AddTicks(5430), true },
                    { 151L, 24L, "Ipsa amet sequi accusamus rerum.\nNam neque ea explicabo quaerat est ut.\nImpedit iste laboriosam culpa saepe.\nConsequatur corrupti nihil aut inventore voluptate.\nQuia quasi deleniti non consequatur veritatis maxime.\nNesciunt dolores vel tempore harum aut vero accusantium assumenda quis.", new DateTime(2023, 8, 5, 12, 24, 38, 308, DateTimeKind.Unspecified).AddTicks(4139), true },
                    { 152L, 112L, "Et minus qui.\nOmnis omnis ratione vel voluptatum sit.\nSunt aut dolorem ducimus impedit quibusdam.\nUnde nihil sapiente et voluptatem.", new DateTime(2023, 5, 15, 18, 29, 18, 582, DateTimeKind.Unspecified).AddTicks(3797), false },
                    { 153L, 32L, "Asperiores non natus molestias qui consequatur beatae est enim voluptas.\nMaiores error adipisci laborum iure voluptas.\nId voluptas voluptate et.\nVeritatis eos quia perferendis totam.\nOccaecati sunt odit molestiae officiis atque dicta recusandae qui corrupti.", new DateTime(2023, 7, 15, 6, 23, 11, 146, DateTimeKind.Unspecified).AddTicks(7932), true },
                    { 154L, 107L, "Iusto qui quo est.\nAmet ipsam illo debitis.", new DateTime(2023, 7, 8, 9, 32, 13, 80, DateTimeKind.Unspecified).AddTicks(9808), true },
                    { 155L, 48L, "Enim asperiores est porro facere.", new DateTime(2021, 6, 22, 7, 35, 30, 418, DateTimeKind.Unspecified).AddTicks(3658), true },
                    { 156L, 122L, "Blanditiis sit distinctio dignissimos rem corporis explicabo.\nVoluptates nihil est corporis.\nEst suscipit est ab unde laboriosam aut odio iusto.\nNumquam neque omnis iure.\nConsequatur eos officiis impedit repellat quia quo alias expedita.", new DateTime(2023, 4, 28, 14, 41, 54, 276, DateTimeKind.Unspecified).AddTicks(8681), true },
                    { 157L, 83L, "Qui nam unde eligendi temporibus doloribus.", new DateTime(2023, 7, 24, 15, 43, 2, 614, DateTimeKind.Unspecified).AddTicks(1447), true },
                    { 158L, 122L, "ut", new DateTime(2023, 3, 28, 3, 19, 10, 753, DateTimeKind.Unspecified).AddTicks(8784), true },
                    { 159L, 66L, "Impedit sint quia et ab. Sit corporis optio aut suscipit fugit dignissimos eos fugit. Aperiam pariatur omnis libero rem aut qui ex nisi. Eos ea iure aperiam eligendi aperiam non.", new DateTime(2023, 3, 30, 14, 38, 6, 32, DateTimeKind.Unspecified).AddTicks(248), false },
                    { 160L, 158L, "Fugiat non iure explicabo voluptatibus vitae ut. Debitis ut temporibus illo ipsum esse omnis consequatur id. Delectus dicta molestiae ut distinctio repudiandae distinctio. Ullam ut fugit iusto et. Inventore ipsam porro eos vitae debitis esse ad asperiores. Maiores quia animi voluptatibus cupiditate dolorum iusto occaecati delectus.", new DateTime(2023, 8, 1, 13, 8, 43, 261, DateTimeKind.Unspecified).AddTicks(6683), false },
                    { 161L, 174L, "et", new DateTime(2023, 6, 18, 20, 47, 23, 75, DateTimeKind.Unspecified).AddTicks(8222), true },
                    { 162L, 133L, "Nobis odio et recusandae asperiores vero.\nQuidem est vero odit est explicabo id voluptatibus.\nIpsam soluta autem cum totam mollitia rem.\nVero dolorem sed.\nEnim est ducimus facere quos unde qui perspiciatis est.", new DateTime(2022, 12, 6, 10, 39, 6, 604, DateTimeKind.Unspecified).AddTicks(2433), false },
                    { 163L, 55L, "Aut cum enim quibusdam molestias aut sit nesciunt facere. Odit reiciendis dicta ut esse beatae dolorem et pariatur. Fugit voluptate ex adipisci perspiciatis. Odio nulla et eligendi consequuntur possimus. Et commodi laboriosam perspiciatis quis optio delectus earum. Optio rerum iure similique illo sunt.", new DateTime(2023, 7, 6, 8, 6, 5, 861, DateTimeKind.Unspecified).AddTicks(3689), true },
                    { 164L, 88L, "quasi", new DateTime(2022, 1, 3, 10, 0, 47, 612, DateTimeKind.Unspecified).AddTicks(4845), true },
                    { 165L, 97L, "Magnam quae dignissimos.", new DateTime(2022, 10, 9, 16, 14, 36, 954, DateTimeKind.Unspecified).AddTicks(8358), true },
                    { 166L, 46L, "Quis est beatae provident blanditiis.\nAut quam distinctio quo rem consequatur aut voluptate et sunt.\nProvident aut nobis.", new DateTime(2023, 5, 13, 2, 51, 27, 691, DateTimeKind.Unspecified).AddTicks(5417), true },
                    { 167L, 24L, "et", new DateTime(2023, 7, 29, 9, 1, 35, 555, DateTimeKind.Unspecified).AddTicks(2737), true },
                    { 168L, 38L, "Quidem qui eaque aliquam voluptas delectus velit illo impedit inventore.", new DateTime(2020, 3, 7, 14, 18, 56, 3, DateTimeKind.Unspecified).AddTicks(5100), true }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "IsPublic" },
                values: new object[,]
                {
                    { 169L, 169L, "Ad quidem in repudiandae dignissimos. Et nam dicta dolorem rerum veritatis aut. Nemo ea sapiente porro architecto. Assumenda quisquam facilis eveniet quis. Qui illo dolores. Odit cum dolorem quia.", new DateTime(2023, 8, 22, 3, 45, 24, 928, DateTimeKind.Unspecified).AddTicks(911), true },
                    { 170L, 180L, "Excepturi quis ipsum.\nSit eos tenetur quis placeat eum illo.\nRepudiandae occaecati sed iste asperiores.\nUt et nihil in ipsum officiis veritatis enim.", new DateTime(2023, 1, 24, 7, 15, 33, 603, DateTimeKind.Unspecified).AddTicks(5453), false },
                    { 171L, 9L, "Quam numquam delectus illum in unde.", new DateTime(2022, 1, 31, 5, 6, 16, 896, DateTimeKind.Unspecified).AddTicks(5478), false },
                    { 172L, 62L, "qui", new DateTime(2021, 11, 14, 3, 19, 4, 390, DateTimeKind.Unspecified).AddTicks(3271), true },
                    { 173L, 144L, "Qui quis sit ut consequatur quasi voluptate itaque. Ullam ut placeat et. Aut blanditiis esse harum dicta hic nihil eos aut tenetur. Corporis autem aliquam enim quas quo aliquam molestias magnam. Quia minima ratione esse qui iste. Adipisci magnam quas magni asperiores vitae similique pariatur magnam cupiditate.", new DateTime(2023, 7, 22, 7, 26, 8, 617, DateTimeKind.Unspecified).AddTicks(4347), false },
                    { 174L, 134L, "Et totam cumque optio voluptatem.", new DateTime(2023, 5, 27, 16, 41, 39, 94, DateTimeKind.Unspecified).AddTicks(2828), true },
                    { 175L, 54L, "Doloribus culpa cum quia.", new DateTime(2023, 8, 22, 22, 2, 24, 553, DateTimeKind.Unspecified).AddTicks(1328), true },
                    { 176L, 38L, "Rerum possimus ducimus libero nemo nostrum nobis quam magnam.", new DateTime(2022, 7, 26, 18, 57, 16, 516, DateTimeKind.Unspecified).AddTicks(8053), true },
                    { 177L, 178L, "Molestiae non soluta quo dignissimos voluptate quia dolores nam eius.", new DateTime(2023, 4, 14, 7, 6, 52, 639, DateTimeKind.Unspecified).AddTicks(3331), true },
                    { 178L, 120L, "Nemo est nihil aut et occaecati et quibusdam reprehenderit voluptate. Magnam ducimus in placeat unde cum. Placeat sapiente qui quas et maiores dolorum ducimus. Incidunt dolor corporis. Autem quod ut debitis omnis enim quia qui voluptate.", new DateTime(2022, 11, 3, 21, 45, 11, 116, DateTimeKind.Unspecified).AddTicks(8323), false },
                    { 179L, 192L, "itaque", new DateTime(2023, 1, 28, 13, 18, 42, 781, DateTimeKind.Unspecified).AddTicks(3401), true },
                    { 180L, 161L, "Sit officiis qui quo in.", new DateTime(2023, 3, 29, 15, 39, 21, 410, DateTimeKind.Unspecified).AddTicks(6572), true },
                    { 181L, 19L, "Nihil eum sit.", new DateTime(2022, 2, 17, 14, 42, 38, 131, DateTimeKind.Unspecified).AddTicks(7079), true },
                    { 182L, 167L, "Maiores ad rem dolor laboriosam consequatur nihil.\nLaudantium quae nam qui.", new DateTime(2023, 6, 28, 0, 8, 56, 68, DateTimeKind.Unspecified).AddTicks(6739), false },
                    { 183L, 11L, "Doloremque et architecto corrupti fugiat porro in voluptatibus. Eos incidunt velit voluptatem. Accusamus maxime atque quasi eos optio. Nisi optio dolorum consequatur qui qui expedita deserunt fuga. Sed quo accusantium deleniti ipsam dignissimos dolores. Facere dolor ea sequi voluptas tenetur.", new DateTime(2023, 1, 10, 4, 40, 57, 249, DateTimeKind.Unspecified).AddTicks(8594), false },
                    { 184L, 149L, "Consequatur aut numquam nulla nobis.\nBlanditiis soluta odio eveniet.", new DateTime(2023, 5, 19, 23, 0, 23, 37, DateTimeKind.Unspecified).AddTicks(1263), true },
                    { 185L, 111L, "Cumque labore ut.", new DateTime(2023, 8, 22, 4, 18, 55, 122, DateTimeKind.Unspecified).AddTicks(3515), true },
                    { 186L, 30L, "Dignissimos amet vero nam possimus laborum id consequuntur molestias ut.\nConsequatur dolores sit autem.", new DateTime(2023, 6, 1, 1, 22, 48, 814, DateTimeKind.Unspecified).AddTicks(1645), false },
                    { 187L, 8L, "vero", new DateTime(2023, 4, 17, 18, 18, 45, 142, DateTimeKind.Unspecified).AddTicks(2210), false },
                    { 188L, 12L, "Perspiciatis magnam aut repellendus quis.\nAlias corporis in dolores enim temporibus molestiae dolorem.\nEt aut labore et aut.\nIllo dolor voluptate ipsam.\nFuga magnam officiis voluptatum.\nExercitationem dolorem voluptate quasi aliquid sequi est.", new DateTime(2023, 3, 7, 7, 52, 17, 87, DateTimeKind.Unspecified).AddTicks(443), true },
                    { 189L, 59L, "dolor", new DateTime(2022, 12, 2, 1, 14, 28, 613, DateTimeKind.Unspecified).AddTicks(7837), false },
                    { 190L, 176L, "Nihil dicta voluptas dolores id ratione corrupti. Similique totam fugit. Facere molestiae et.", new DateTime(2023, 8, 14, 12, 57, 32, 479, DateTimeKind.Unspecified).AddTicks(206), true },
                    { 191L, 38L, "Praesentium nesciunt sit deserunt aut aut enim aut sunt sed.\nDucimus est qui reprehenderit nostrum.\nDicta voluptatem culpa minima officia aliquam rerum ex magnam.\nEos esse illum tempora autem nihil dolorum sapiente molestiae.\nEt quidem dolores numquam.", new DateTime(2021, 5, 10, 16, 20, 10, 562, DateTimeKind.Unspecified).AddTicks(4686), false },
                    { 192L, 120L, "Aut non qui. Aut aliquam quia distinctio. Et ut ut pariatur et velit totam possimus necessitatibus. Voluptatem quasi corrupti totam ratione saepe ducimus consequuntur consequatur sunt. Ut fugit nobis consectetur autem sit fugiat.", new DateTime(2022, 8, 8, 20, 0, 29, 106, DateTimeKind.Unspecified).AddTicks(9358), true },
                    { 193L, 18L, "sapiente", new DateTime(2023, 7, 31, 9, 2, 37, 796, DateTimeKind.Unspecified).AddTicks(4970), true },
                    { 194L, 45L, "Aut quisquam labore praesentium et est asperiores corrupti veritatis odio.\nIusto magni consequatur similique minima.\nSed omnis distinctio.\nBeatae quidem nesciunt perspiciatis temporibus omnis.\nQui ducimus ut.", new DateTime(2023, 5, 19, 5, 9, 38, 64, DateTimeKind.Unspecified).AddTicks(7918), true },
                    { 195L, 146L, "Dignissimos consectetur aperiam adipisci corporis.\nReprehenderit enim voluptates doloribus odio.\nConsequatur perferendis autem sed magni dignissimos.", new DateTime(2022, 12, 20, 22, 51, 45, 886, DateTimeKind.Unspecified).AddTicks(7858), true },
                    { 196L, 106L, "Rerum sunt laborum sed aut omnis eveniet dolore velit. Natus molestiae sint laudantium qui consequatur et rerum harum et. Quo officia et dignissimos aut.", new DateTime(2023, 8, 19, 14, 26, 27, 118, DateTimeKind.Unspecified).AddTicks(796), false },
                    { 197L, 132L, "Cupiditate inventore neque enim numquam.", new DateTime(2021, 9, 25, 17, 54, 54, 5, DateTimeKind.Unspecified).AddTicks(9687), true },
                    { 198L, 39L, "sunt", new DateTime(2023, 8, 14, 12, 50, 39, 110, DateTimeKind.Unspecified).AddTicks(6001), true },
                    { 199L, 36L, "Id libero corporis sint nulla adipisci veniam suscipit ut.", new DateTime(2022, 9, 12, 8, 5, 29, 987, DateTimeKind.Unspecified).AddTicks(626), true },
                    { 200L, 88L, "Aut velit sint est aperiam. Ex sequi non voluptatem illo porro quas impedit qui. Cumque reiciendis in dolores eos atque sint.", new DateTime(2019, 7, 11, 13, 24, 54, 127, DateTimeKind.Unspecified).AddTicks(3257), true }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "Output", "SubmittedAt", "UserId" },
                values: new object[,]
                {
                    { 1L, 164L, "Vitae earum pariatur animi saepe explicabo asperiores molestiae et nihil. Esse provident id saepe nesciunt enim. Neque nemo dolore cupiditate temporibus vitae. Ut est voluptates qui minima dolor totam reprehenderit. Dolores non blanditiis facere numquam et facilis. Saepe sequi adipisci labore nesciunt.", new DateTime(2023, 1, 30, 6, 33, 36, 96, DateTimeKind.Unspecified).AddTicks(6947), "Tempora minus et in facilis natus voluptatem voluptas non. Dignissimos dicta dolor delectus molestiae alias accusantium voluptatem. Delectus cumque iste. Ea nam aut et. Necessitatibus molestiae odit quibusdam ullam ad ab quae.", new DateTime(2023, 8, 10, 12, 1, 46, 559, DateTimeKind.Unspecified).AddTicks(9338), 33L },
                    { 2L, 57L, "Ea iste quos non incidunt consectetur numquam.\nQuod facilis dolorem libero.\nNostrum voluptates tempore non sint debitis et.\nFacilis temporibus molestias repudiandae aut amet non.\nIpsum amet perferendis id.\nAlias aut deleniti optio ea optio numquam.", new DateTime(2023, 8, 22, 3, 40, 8, 321, DateTimeKind.Unspecified).AddTicks(1501), "Aut vel dolores cupiditate et consectetur consequatur voluptatem. Voluptatem quasi quo assumenda maiores sit aliquid consequatur alias. Sunt praesentium voluptatem recusandae hic nostrum et consectetur ut aut.", new DateTime(2023, 8, 22, 20, 54, 38, 359, DateTimeKind.Unspecified).AddTicks(2476), 8L },
                    { 3L, 98L, "Eum distinctio corporis ut dolorem et velit.", new DateTime(2023, 3, 31, 20, 51, 58, 687, DateTimeKind.Unspecified).AddTicks(8135), "Quis laboriosam dolores soluta illo est numquam.", new DateTime(2023, 8, 17, 10, 49, 45, 466, DateTimeKind.Unspecified).AddTicks(5961), 40L },
                    { 4L, 187L, "Repellat est sequi.\nEaque cupiditate consequuntur harum deserunt atque delectus nisi.\nAut voluptate ut tenetur sint quam consequatur praesentium.", new DateTime(2023, 5, 4, 23, 24, 15, 264, DateTimeKind.Unspecified).AddTicks(423), "Corrupti quasi omnis.\nRerum iusto dicta.\nMolestiae velit ut reprehenderit assumenda similique vel consequatur neque.\nUt velit sunt ut sint maiores beatae et.", new DateTime(2023, 5, 30, 6, 43, 3, 70, DateTimeKind.Unspecified).AddTicks(3175), 1L },
                    { 5L, 80L, "Aspernatur qui delectus ut.", new DateTime(2020, 11, 24, 2, 32, 9, 707, DateTimeKind.Unspecified).AddTicks(9170), "nobis", new DateTime(2023, 5, 31, 6, 26, 17, 278, DateTimeKind.Unspecified).AddTicks(1860), 7L },
                    { 6L, 192L, "perferendis", new DateTime(2023, 3, 16, 3, 47, 10, 435, DateTimeKind.Unspecified).AddTicks(6489), "Esse voluptas facere autem. Delectus qui iste error voluptatem. Molestiae sequi impedit velit iste. Ipsum tempore molestiae esse aperiam eos accusantium placeat.", new DateTime(2023, 3, 19, 1, 31, 49, 307, DateTimeKind.Unspecified).AddTicks(1100), 33L },
                    { 7L, 61L, "aut", new DateTime(2023, 2, 27, 2, 34, 38, 252, DateTimeKind.Unspecified).AddTicks(9774), "Iure saepe quas accusamus magni repellat velit ea.\nReprehenderit est labore.\nPorro earum consequatur nulla aspernatur a.\nVel nihil qui quae unde aut quo sed.\nA velit aut commodi asperiores vel nam.", null, 7L },
                    { 8L, 21L, "Voluptatem error provident quo beatae culpa modi repellendus.\nQuasi suscipit soluta neque praesentium voluptatem sed quis.", new DateTime(2023, 4, 27, 22, 57, 59, 519, DateTimeKind.Unspecified).AddTicks(1894), "Reiciendis sint debitis. Et ad sed perspiciatis omnis non. Placeat error explicabo accusantium maiores deleniti repellat praesentium. Id et eos. Expedita magni et impedit voluptatibus. Qui consequuntur nulla explicabo expedita aut.", new DateTime(2023, 7, 30, 21, 18, 38, 100, DateTimeKind.Unspecified).AddTicks(9767), 28L },
                    { 9L, 76L, "Ut officia fugit quasi.\nSit rerum quis esse placeat nemo.\nDolor qui est est omnis.", new DateTime(2020, 9, 15, 20, 33, 48, 150, DateTimeKind.Unspecified).AddTicks(6913), "Consequuntur iure deserunt ut rem iusto et.", new DateTime(2022, 8, 23, 11, 17, 42, 580, DateTimeKind.Unspecified).AddTicks(536), 12L },
                    { 10L, 4L, "qui", new DateTime(2023, 6, 28, 7, 12, 29, 120, DateTimeKind.Unspecified).AddTicks(8193), "earum", new DateTime(2023, 7, 13, 16, 3, 59, 14, DateTimeKind.Unspecified).AddTicks(3522), 3L }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "Output", "SubmittedAt", "UserId" },
                values: new object[,]
                {
                    { 11L, 147L, "Explicabo repellendus enim quia aut voluptas aperiam voluptatem. Sed aut placeat possimus nobis facilis quidem excepturi aperiam voluptatem. Possimus sunt magnam. Omnis rerum nihil possimus ut eius voluptates laboriosam provident aut. Nobis quia mollitia velit ab sequi quidem est earum. Aliquam amet vel quis temporibus.", new DateTime(2023, 1, 18, 1, 16, 34, 943, DateTimeKind.Unspecified).AddTicks(1249), "Omnis tenetur consequatur sed ea unde laudantium. Minima cum nam quia voluptas numquam officiis. A excepturi repudiandae quo non earum sed ipsam nemo distinctio. Qui voluptas iure iste praesentium nostrum vel. Molestiae et ratione voluptas ab id et debitis sapiente.", new DateTime(2023, 1, 26, 18, 4, 29, 40, DateTimeKind.Unspecified).AddTicks(3116), 5L },
                    { 12L, 56L, "Nulla dolor ipsam qui fugiat.\nTempora cumque doloremque aut exercitationem necessitatibus sed quia.\nHic dignissimos rerum beatae consequatur maxime et aut omnis veritatis.\nQuia in magni deleniti.", new DateTime(2023, 4, 21, 8, 41, 54, 765, DateTimeKind.Unspecified).AddTicks(364), "qui", new DateTime(2023, 6, 23, 18, 2, 58, 534, DateTimeKind.Unspecified).AddTicks(9595), 39L },
                    { 13L, 100L, "Et et sit. Eos maiores voluptas ut qui in mollitia consequatur. Animi provident reiciendis soluta sed possimus.", new DateTime(2023, 1, 19, 15, 47, 20, 232, DateTimeKind.Unspecified).AddTicks(9753), "Similique unde accusamus rem sint quo mollitia ea.\nQuos at ut necessitatibus soluta nulla.\nRerum beatae ipsam nemo possimus omnis.\nEst in autem placeat harum eum a adipisci quam et.", new DateTime(2023, 7, 23, 4, 36, 3, 764, DateTimeKind.Unspecified).AddTicks(3321), 11L },
                    { 14L, 62L, "alias", new DateTime(2023, 6, 5, 5, 48, 24, 514, DateTimeKind.Unspecified).AddTicks(5575), "Consequuntur aut excepturi blanditiis impedit at.", new DateTime(2023, 7, 28, 23, 4, 39, 694, DateTimeKind.Unspecified).AddTicks(8847), 6L },
                    { 15L, 15L, "eveniet", new DateTime(2023, 2, 5, 10, 21, 16, 645, DateTimeKind.Unspecified).AddTicks(5642), "nam", new DateTime(2023, 2, 23, 15, 33, 23, 575, DateTimeKind.Unspecified).AddTicks(8018), 4L },
                    { 16L, 127L, "Iusto laboriosam fuga dolor autem.\nAut consequatur ipsam alias laboriosam molestiae dolor.\nEarum nam eveniet quas cupiditate.\nSint inventore ducimus.", new DateTime(2023, 5, 25, 13, 9, 52, 914, DateTimeKind.Unspecified).AddTicks(4118), "Aut possimus mollitia non repudiandae nisi.", new DateTime(2023, 6, 1, 11, 54, 29, 283, DateTimeKind.Unspecified).AddTicks(5604), 34L },
                    { 17L, 37L, "tempore", new DateTime(2022, 8, 20, 20, 53, 58, 357, DateTimeKind.Unspecified).AddTicks(3696), "Tempore quae quia iste qui rerum voluptas consequuntur debitis adipisci. Ab et dolor autem necessitatibus magnam. Sunt omnis vel deleniti in expedita dolores quibusdam. Sit eum in modi placeat id eos nulla perferendis ad. Ut sint sint totam est porro rerum autem velit. Cumque modi fugiat.", new DateTime(2023, 3, 8, 1, 35, 54, 580, DateTimeKind.Unspecified).AddTicks(2500), 40L },
                    { 18L, 189L, "Repellendus repudiandae distinctio.\nUllam aut impedit enim nostrum.\nCommodi et odio temporibus expedita nulla repudiandae eum nobis assumenda.\nMollitia hic deleniti id maxime et similique quo.", new DateTime(2021, 11, 18, 11, 9, 19, 94, DateTimeKind.Unspecified).AddTicks(9605), "Facere facere sed consequatur quaerat.\nUt maxime dolor atque.\nSunt laboriosam id qui consectetur cupiditate dolor et ea a.\nEa amet delectus dolor eligendi iste qui qui mollitia.\nVeniam doloribus et nobis tempore et officia placeat.", new DateTime(2022, 4, 6, 14, 28, 58, 379, DateTimeKind.Unspecified).AddTicks(3001), 20L },
                    { 19L, 162L, "Ut illo quae. Ut nostrum velit repellat qui non ipsa. Rem temporibus sit.", new DateTime(2021, 10, 29, 21, 50, 17, 167, DateTimeKind.Unspecified).AddTicks(9680), "necessitatibus", new DateTime(2023, 3, 3, 3, 23, 16, 271, DateTimeKind.Unspecified).AddTicks(4073), 9L },
                    { 20L, 99L, "Aut debitis sit nesciunt qui et odit.\nEligendi quia tempore.\nInventore est doloribus.\nEt nostrum quod laborum excepturi ad eligendi.\nIste voluptas rem ab autem voluptatem rerum sed ipsum hic.\nVelit qui voluptas.", new DateTime(2023, 8, 23, 4, 33, 41, 476, DateTimeKind.Unspecified).AddTicks(5377), "Recusandae eaque dolor qui nisi itaque.", new DateTime(2023, 8, 23, 7, 57, 4, 903, DateTimeKind.Unspecified).AddTicks(9403), 34L },
                    { 21L, 28L, "Voluptatem beatae est amet explicabo id illum doloremque inventore.", new DateTime(2023, 8, 18, 16, 4, 36, 588, DateTimeKind.Unspecified).AddTicks(6257), "et", new DateTime(2023, 8, 19, 4, 30, 42, 71, DateTimeKind.Unspecified).AddTicks(2744), 23L },
                    { 22L, 45L, "Ipsa enim cum.\nQuos odit culpa et dolores reiciendis.", new DateTime(2023, 7, 24, 13, 21, 29, 330, DateTimeKind.Unspecified).AddTicks(848), "voluptatem", new DateTime(2023, 8, 20, 16, 52, 45, 845, DateTimeKind.Unspecified).AddTicks(5593), 16L },
                    { 23L, 60L, "Corporis ut iusto in.", new DateTime(2020, 10, 6, 11, 37, 18, 112, DateTimeKind.Unspecified).AddTicks(4936), "Perferendis quia perferendis quisquam eos. Officia nulla vel laudantium. Est fugit beatae excepturi maiores voluptatem ab. Modi ipsa ut autem perferendis labore voluptatem aliquid aut. Id repudiandae et cum qui explicabo autem id omnis. Doloribus iusto perspiciatis.", new DateTime(2021, 7, 10, 21, 7, 35, 394, DateTimeKind.Unspecified).AddTicks(1619), 34L },
                    { 24L, 133L, "autem", new DateTime(2023, 4, 15, 18, 47, 52, 439, DateTimeKind.Unspecified).AddTicks(8548), "Ut ab sunt.", new DateTime(2023, 8, 23, 4, 3, 47, 161, DateTimeKind.Unspecified).AddTicks(2858), 13L },
                    { 25L, 97L, "Illo est omnis repellendus non ut maiores eos.\nUt recusandae quo repellendus dolores molestias.\nEst aut dolor.\nSunt ut corrupti error.\nAut fugiat et ut est exercitationem voluptate explicabo.\nQuos quasi placeat ut sit in neque et.", new DateTime(2023, 2, 5, 1, 56, 58, 962, DateTimeKind.Unspecified).AddTicks(8700), "Non repellendus vel nesciunt omnis enim. Molestiae nobis dolorum excepturi veniam maiores aperiam. Dolores omnis mollitia est dolore non quod inventore alias. Voluptas ratione rerum eum quae iusto. Repudiandae voluptatem sed ipsam voluptatem ad dolor exercitationem.", new DateTime(2023, 2, 26, 17, 12, 12, 466, DateTimeKind.Unspecified).AddTicks(16), 32L },
                    { 26L, 146L, "Quas voluptatem est illo aspernatur voluptas rerum. Qui consequatur quisquam iusto neque eos. Rerum sit voluptas quis quo dolores excepturi. Minima illum voluptatum. Quae sit hic accusantium et error. Eos sed iusto vel sunt qui voluptatem et.", new DateTime(2023, 3, 23, 7, 42, 40, 233, DateTimeKind.Unspecified).AddTicks(2221), "Ut dolores molestiae itaque assumenda molestiae dolores.\nEt aut asperiores voluptatem voluptas labore.\nOfficiis voluptas eos omnis repellendus et accusamus.", new DateTime(2023, 4, 23, 16, 41, 51, 179, DateTimeKind.Unspecified).AddTicks(6155), 21L },
                    { 27L, 69L, "In molestiae et et est rem nisi non aut.", new DateTime(2023, 6, 9, 3, 23, 37, 963, DateTimeKind.Unspecified).AddTicks(5104), "Labore facilis et qui ut aut qui tenetur impedit quam.\nConsequatur nihil corrupti voluptatum est sed molestias natus sed et.", new DateTime(2023, 6, 14, 11, 26, 58, 830, DateTimeKind.Unspecified).AddTicks(7212), 26L },
                    { 28L, 116L, "Ut minus sunt facere eveniet.\nModi eveniet qui praesentium explicabo nam ipsam architecto nesciunt.\nAut atque labore repellat minus voluptas.\nAlias voluptates voluptatem est ullam quae architecto.\nMolestias vel cum commodi nobis ea inventore non.", new DateTime(2023, 7, 6, 16, 23, 2, 968, DateTimeKind.Unspecified).AddTicks(215), "Dolorum ab totam blanditiis omnis omnis amet vitae.\nOmnis commodi assumenda perspiciatis voluptatem dolores similique voluptas officiis eius.\nPariatur excepturi id officia quis rerum quo rem qui illo.", new DateTime(2023, 7, 7, 12, 46, 10, 184, DateTimeKind.Unspecified).AddTicks(6246), 39L },
                    { 29L, 33L, "Rem illo fugit sapiente fugit sapiente.\nLaborum magni nisi omnis.\nNumquam et odio voluptas et aut ipsam debitis dolorem.\nVoluptas quo earum et consequatur repellendus voluptatem non ipsam qui.", new DateTime(2022, 7, 3, 7, 12, 18, 207, DateTimeKind.Unspecified).AddTicks(8659), "iure", new DateTime(2023, 7, 7, 5, 50, 47, 722, DateTimeKind.Unspecified).AddTicks(993), 17L },
                    { 30L, 143L, "Excepturi consequatur sint aliquid quo ullam eos esse. Mollitia incidunt expedita quis. Numquam in voluptatem quia sequi ex officia. Doloremque delectus possimus eum magnam ad sint.", new DateTime(2023, 8, 22, 0, 26, 24, 309, DateTimeKind.Unspecified).AddTicks(3842), "Iusto quos qui voluptatum autem deserunt quasi. Facilis id autem porro ex autem aut. Hic voluptate et consectetur dolorum dicta dicta repudiandae suscipit. Deserunt aut ab et ut quia rerum est modi autem. Id est et dolores.", new DateTime(2023, 8, 22, 7, 46, 19, 513, DateTimeKind.Unspecified).AddTicks(851), 26L },
                    { 31L, 5L, "Esse voluptas aut aut cupiditate et ut voluptate.\nEos voluptas repellat veritatis praesentium dolor.\nVelit eum nam voluptatem enim libero non et.", new DateTime(2022, 12, 31, 6, 51, 2, 14, DateTimeKind.Unspecified).AddTicks(2126), "Aut autem odit.", new DateTime(2023, 2, 18, 20, 49, 45, 579, DateTimeKind.Unspecified).AddTicks(9559), 28L },
                    { 32L, 178L, "Veritatis commodi assumenda debitis eum nobis animi voluptas et.\nConsectetur non ad.\nAtque hic incidunt.\nMaxime fugit nemo cum totam hic.", new DateTime(2022, 12, 6, 6, 28, 31, 997, DateTimeKind.Unspecified).AddTicks(9676), "Fugit et repellendus omnis dolorem et repudiandae dolores totam. Ad molestiae maiores laborum eaque alias voluptatibus dolor dignissimos eum. Ut reprehenderit reiciendis officiis rerum nihil atque iure. Illum et vitae rerum atque voluptatem facilis exercitationem commodi est.", new DateTime(2022, 12, 19, 9, 13, 26, 481, DateTimeKind.Unspecified).AddTicks(3063), 15L },
                    { 33L, 188L, "Quas enim tempore atque dolorem cupiditate rem dolores in.", new DateTime(2023, 7, 31, 1, 28, 59, 98, DateTimeKind.Unspecified).AddTicks(343), "aut", new DateTime(2023, 8, 10, 3, 21, 18, 134, DateTimeKind.Unspecified).AddTicks(4442), 37L },
                    { 34L, 144L, "Voluptas aspernatur consequuntur est ea.\nQuam facere totam est cupiditate nisi voluptatem iure.", new DateTime(2022, 10, 23, 13, 46, 48, 858, DateTimeKind.Unspecified).AddTicks(6172), "et", new DateTime(2023, 5, 8, 14, 19, 19, 97, DateTimeKind.Unspecified).AddTicks(5496), 9L },
                    { 35L, 123L, "Sequi quo reprehenderit nihil officiis non qui dignissimos ut officia.\nNam autem dolores ipsam quibusdam placeat assumenda alias.\nIllo voluptas repellendus sint vel.\nEius aperiam nesciunt et maiores incidunt ut eius dolorum occaecati.\nAsperiores aut ut harum beatae.", new DateTime(2023, 5, 6, 20, 24, 25, 712, DateTimeKind.Unspecified).AddTicks(8645), "Maxime praesentium unde porro in laborum.", new DateTime(2023, 6, 17, 21, 35, 12, 582, DateTimeKind.Unspecified).AddTicks(8075), 36L },
                    { 36L, 70L, "Officiis laborum reiciendis.", new DateTime(2021, 12, 15, 12, 53, 15, 724, DateTimeKind.Unspecified).AddTicks(5578), "Sed id velit voluptatem nesciunt.\nQuibusdam et possimus necessitatibus laudantium minus aut qui aliquid assumenda.", new DateTime(2023, 1, 9, 9, 22, 16, 475, DateTimeKind.Unspecified).AddTicks(6268), 15L },
                    { 37L, 37L, "A commodi incidunt laudantium nihil vel et.\nCupiditate autem fugiat eum suscipit qui iure quo id.\nQui quisquam ratione.", new DateTime(2023, 4, 21, 18, 43, 19, 189, DateTimeKind.Unspecified).AddTicks(8700), "Nihil odit quaerat et sed voluptatum quod alias tempora temporibus.\nAutem est sit beatae autem.\nHarum non sit natus cupiditate iusto quia sapiente libero doloremque.\nReprehenderit et voluptatum corporis atque ut.\nIpsam quia minima et ab illo fugiat animi unde.\nMollitia amet enim aperiam voluptas quod sint dignissimos optio.", new DateTime(2023, 4, 27, 23, 23, 2, 710, DateTimeKind.Unspecified).AddTicks(8984), 18L },
                    { 38L, 26L, "Laborum sunt enim illo enim.\nSunt omnis aliquam nihil alias neque.\nQui et rerum nihil.\nDeleniti possimus in et repudiandae.", new DateTime(2023, 7, 16, 1, 24, 41, 531, DateTimeKind.Unspecified).AddTicks(7552), "Et culpa facilis architecto laborum sunt id placeat eius. Ut minus veniam. Optio enim excepturi eaque excepturi minima error impedit quaerat. Et corporis illo est et voluptatibus distinctio ut consectetur. Est asperiores fugit sit explicabo voluptates natus. Molestias necessitatibus et eligendi vitae nihil.", new DateTime(2023, 8, 18, 16, 21, 37, 387, DateTimeKind.Unspecified).AddTicks(8036), 3L },
                    { 39L, 187L, "Voluptatem eos ducimus.\nEaque sint voluptas labore consequatur.\nUt omnis dolorem nihil sequi sit rerum animi quisquam sit.", new DateTime(2023, 5, 16, 13, 8, 12, 686, DateTimeKind.Unspecified).AddTicks(4340), "consequatur", new DateTime(2023, 6, 20, 8, 9, 31, 854, DateTimeKind.Unspecified).AddTicks(7413), 6L },
                    { 40L, 39L, "Eveniet laborum ullam sint tempore aliquam id dolor officiis. Ut ut occaecati voluptas sequi quia sed ex. Repellendus recusandae pariatur vero ipsa saepe hic qui excepturi sunt. Quis et quis officia doloribus molestiae praesentium et. Ut mollitia neque. Beatae rerum recusandae nulla consequatur dolor eveniet vel.", new DateTime(2023, 7, 4, 18, 22, 21, 709, DateTimeKind.Unspecified).AddTicks(9480), "Beatae pariatur quae facere quaerat dolorum est non modi.", new DateTime(2023, 7, 28, 9, 29, 31, 574, DateTimeKind.Unspecified).AddTicks(2993), 28L },
                    { 41L, 195L, "Eos rerum quia quasi. Est quia omnis ea. Aut ea minus adipisci accusamus perferendis quaerat nostrum quod earum. Sed doloremque nemo quis. Totam sed est neque aperiam. Deserunt omnis aperiam non hic minus necessitatibus architecto et aut.", new DateTime(2023, 6, 15, 11, 28, 16, 848, DateTimeKind.Unspecified).AddTicks(575), "Ipsum quos et voluptatem laboriosam eius id. Fugiat illo distinctio vero. Cumque qui corporis. Illo labore molestiae consectetur voluptas dolor nesciunt. Veritatis cupiditate ea nam sit velit ut quis nobis sed.", new DateTime(2023, 7, 12, 0, 18, 15, 560, DateTimeKind.Unspecified).AddTicks(4398), 36L },
                    { 42L, 163L, "Omnis et autem architecto recusandae aperiam quasi est.", new DateTime(2023, 7, 1, 4, 59, 21, 95, DateTimeKind.Unspecified).AddTicks(8959), "Et minus et ea ipsam laboriosam vel ad eligendi sed.", new DateTime(2023, 7, 17, 20, 14, 4, 865, DateTimeKind.Unspecified).AddTicks(7196), 22L },
                    { 43L, 98L, "Earum suscipit autem libero exercitationem dolores.", new DateTime(2023, 4, 26, 14, 7, 59, 116, DateTimeKind.Unspecified).AddTicks(8418), "Cum repellendus accusamus.", new DateTime(2023, 8, 10, 13, 44, 41, 453, DateTimeKind.Unspecified).AddTicks(7142), 6L },
                    { 44L, 130L, "Rerum aliquam quibusdam error et fugiat aut magnam.", new DateTime(2022, 8, 2, 13, 14, 58, 950, DateTimeKind.Unspecified).AddTicks(6300), "amet", new DateTime(2023, 3, 17, 21, 10, 16, 788, DateTimeKind.Unspecified).AddTicks(7175), 38L },
                    { 45L, 85L, "Sapiente magnam quia ut a in.\nIste excepturi ratione quia et rerum magni sunt.", new DateTime(2022, 1, 9, 16, 9, 28, 530, DateTimeKind.Unspecified).AddTicks(9171), "Cumque autem nihil.\nNatus ipsa ut quis veritatis doloremque quisquam.\nCupiditate tenetur quia blanditiis est.\nVoluptate voluptate exercitationem.\nMolestiae architecto quia sapiente quae commodi.\nVel architecto deleniti maxime provident fugiat facere.", new DateTime(2022, 6, 24, 7, 16, 30, 952, DateTimeKind.Unspecified).AddTicks(1250), 30L },
                    { 46L, 63L, "Fugiat ut fuga magnam distinctio sit voluptate.\nQuia iusto dolor corporis ducimus et numquam.\nAsperiores et id dolore a et provident.", new DateTime(2023, 6, 5, 10, 41, 25, 989, DateTimeKind.Unspecified).AddTicks(1822), "Quisquam corporis suscipit magni odio dolorum. Voluptatem et sunt. Autem cumque commodi voluptate non.", new DateTime(2023, 7, 17, 3, 32, 30, 328, DateTimeKind.Unspecified).AddTicks(1763), 13L },
                    { 47L, 187L, "quia", new DateTime(2023, 4, 30, 15, 57, 4, 119, DateTimeKind.Unspecified).AddTicks(7939), "quis", new DateTime(2023, 7, 14, 11, 28, 15, 304, DateTimeKind.Unspecified).AddTicks(6541), 3L },
                    { 48L, 76L, "Non laudantium aut non.\nAsperiores nesciunt dolore.\nIure consequuntur voluptatem velit.\nAutem quo molestiae recusandae.\nEt deserunt ratione laborum.", new DateTime(2022, 7, 5, 10, 7, 15, 550, DateTimeKind.Unspecified).AddTicks(6212), "et", new DateTime(2023, 8, 8, 17, 15, 50, 195, DateTimeKind.Unspecified).AddTicks(3952), 34L },
                    { 49L, 123L, "Distinctio quos eveniet corporis voluptatem voluptatem ipsam deserunt.\nDolor quisquam beatae eum dicta.\nNatus quaerat modi expedita deleniti reprehenderit ut veritatis at.", new DateTime(2023, 3, 29, 20, 55, 10, 673, DateTimeKind.Unspecified).AddTicks(9475), "delectus", new DateTime(2023, 5, 10, 5, 40, 27, 97, DateTimeKind.Unspecified).AddTicks(8917), 9L },
                    { 50L, 198L, "Sed impedit voluptatum provident aut tempore et.\nEnim delectus saepe sit esse possimus occaecati consequuntur.\nDignissimos asperiores voluptates enim quia molestiae quae ullam.\nVeritatis cumque sed repellat porro.\nLaboriosam ut unde voluptatem vitae est aut maiores in quod.", new DateTime(2023, 7, 1, 0, 50, 36, 858, DateTimeKind.Unspecified).AddTicks(2979), "explicabo", null, 39L },
                    { 51L, 41L, "Sit quod eum aliquam esse minima et.", new DateTime(2022, 12, 4, 12, 39, 26, 509, DateTimeKind.Unspecified).AddTicks(3576), "omnis", new DateTime(2023, 2, 23, 21, 23, 21, 689, DateTimeKind.Unspecified).AddTicks(7948), 25L },
                    { 52L, 137L, "Non quis quae voluptatibus. Aut sit similique necessitatibus suscipit. Enim et dolorum. Omnis nihil optio et molestias perferendis magni. Est quos aliquid autem quis quia et nulla ab.", new DateTime(2023, 6, 25, 8, 35, 16, 655, DateTimeKind.Unspecified).AddTicks(6380), "Incidunt quisquam exercitationem deserunt nobis qui.", new DateTime(2023, 8, 20, 5, 15, 37, 475, DateTimeKind.Unspecified).AddTicks(6437), 20L }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "Output", "SubmittedAt", "UserId" },
                values: new object[,]
                {
                    { 53L, 108L, "Deserunt facere rerum omnis nam ipsum eos vitae quas in. Voluptatibus quidem sapiente ea ut corrupti. Consequatur in iure. Deleniti eum aut sint perferendis voluptas id et corporis sunt. Iure dolor blanditiis aperiam nostrum iure. Voluptatem voluptatem eius eveniet.", new DateTime(2023, 7, 30, 3, 23, 37, 494, DateTimeKind.Unspecified).AddTicks(3796), "nihil", new DateTime(2023, 8, 12, 14, 50, 36, 306, DateTimeKind.Unspecified).AddTicks(5318), 4L },
                    { 54L, 132L, "Natus animi nihil ad inventore perspiciatis ratione nesciunt consequatur voluptatum.", new DateTime(2023, 4, 4, 12, 13, 16, 520, DateTimeKind.Unspecified).AddTicks(754), "Officia magnam dolor et itaque velit est accusamus dolores labore.\nQui est nemo nihil voluptatum alias ab laudantium.", null, 40L },
                    { 55L, 152L, "reiciendis", new DateTime(2022, 9, 16, 10, 27, 59, 680, DateTimeKind.Unspecified).AddTicks(9484), "Qui cum quidem aut amet sed voluptas ex quam dolorum.\nDistinctio quae nihil ea aperiam.\nSit labore est soluta consequatur molestiae sed aut.", new DateTime(2022, 10, 22, 19, 51, 55, 722, DateTimeKind.Unspecified).AddTicks(4270), 11L },
                    { 56L, 182L, "Necessitatibus soluta error aperiam omnis sed. Culpa quia qui molestiae. Suscipit est voluptate nihil. Corrupti facilis excepturi.", new DateTime(2022, 12, 12, 8, 32, 5, 578, DateTimeKind.Unspecified).AddTicks(6731), "Magnam occaecati nihil molestiae commodi vel dolore eligendi.\nAut magnam sequi quod quibusdam repellat repudiandae autem.\nQui natus modi.", new DateTime(2023, 5, 27, 8, 50, 5, 198, DateTimeKind.Unspecified).AddTicks(7858), 40L },
                    { 57L, 179L, "et", new DateTime(2023, 2, 27, 23, 36, 43, 8, DateTimeKind.Unspecified).AddTicks(2855), "enim", new DateTime(2023, 3, 6, 6, 40, 33, 223, DateTimeKind.Unspecified).AddTicks(742), 38L },
                    { 58L, 70L, "Dolorem sed officiis saepe voluptas ea vitae.\nNam et eaque sunt pariatur praesentium.", new DateTime(2023, 3, 5, 2, 11, 29, 25, DateTimeKind.Unspecified).AddTicks(786), "Nihil magnam laborum itaque ad perferendis laboriosam sit.", new DateTime(2023, 5, 5, 4, 19, 2, 604, DateTimeKind.Unspecified).AddTicks(3937), 19L },
                    { 59L, 134L, "Quo amet modi itaque est sit.\nQuas nobis sed nobis.\nDoloremque nam praesentium atque occaecati vero.\nVeritatis et eos suscipit vel et eligendi.", new DateTime(2023, 3, 14, 10, 52, 6, 644, DateTimeKind.Unspecified).AddTicks(3577), "Ut est necessitatibus a qui iste.", null, 30L },
                    { 60L, 66L, "voluptatem", new DateTime(2023, 8, 8, 4, 54, 56, 571, DateTimeKind.Unspecified).AddTicks(1981), "magnam", new DateTime(2023, 8, 10, 12, 18, 39, 69, DateTimeKind.Unspecified).AddTicks(7896), 3L },
                    { 61L, 196L, "Nihil explicabo quam in cumque pariatur velit architecto repellat. Vel sapiente a enim est ut rem non quibusdam dolore. Consequatur occaecati ipsa. Rerum voluptatem atque itaque ut et non neque necessitatibus.", new DateTime(2023, 3, 29, 17, 52, 35, 720, DateTimeKind.Unspecified).AddTicks(6176), "et", new DateTime(2023, 7, 27, 11, 8, 39, 913, DateTimeKind.Unspecified).AddTicks(7160), 29L },
                    { 62L, 156L, "Velit quia qui.", new DateTime(2023, 7, 17, 18, 25, 18, 359, DateTimeKind.Unspecified).AddTicks(9265), "Id distinctio soluta vero sunt dolores facere saepe sunt.", new DateTime(2023, 8, 8, 4, 24, 11, 752, DateTimeKind.Unspecified).AddTicks(7137), 16L },
                    { 63L, 14L, "praesentium", new DateTime(2022, 11, 11, 9, 38, 11, 503, DateTimeKind.Unspecified).AddTicks(1958), "veniam", new DateTime(2023, 7, 15, 5, 35, 26, 579, DateTimeKind.Unspecified).AddTicks(2432), 33L },
                    { 64L, 179L, "Reiciendis nihil est possimus voluptatem fugiat expedita deserunt quas debitis.", new DateTime(2022, 9, 18, 17, 7, 41, 582, DateTimeKind.Unspecified).AddTicks(2124), "Autem odio doloremque eos exercitationem nostrum nisi sed modi.", new DateTime(2023, 4, 7, 7, 57, 47, 283, DateTimeKind.Unspecified).AddTicks(7590), 10L },
                    { 65L, 199L, "Rerum quod sed sit. Fugit impedit accusantium dolores magnam perspiciatis sed modi vitae ab. Animi dignissimos nulla est non eum sunt velit nostrum. Placeat provident quas dolorem ea voluptates ipsam commodi.", new DateTime(2023, 2, 5, 7, 57, 35, 108, DateTimeKind.Unspecified).AddTicks(3050), "Cum eum voluptas voluptatem. Nesciunt eaque et. Alias voluptatem voluptas.", new DateTime(2023, 2, 21, 8, 6, 22, 630, DateTimeKind.Unspecified).AddTicks(5871), 15L },
                    { 66L, 160L, "Dolorem sint necessitatibus ullam commodi dolor cupiditate ut saepe.", new DateTime(2022, 12, 1, 17, 35, 4, 439, DateTimeKind.Unspecified).AddTicks(5773), "Eius repudiandae nihil molestiae et occaecati blanditiis illum libero.\nIn non libero animi est ratione quia.\nEum placeat veritatis illo ut et repellendus non sapiente.\nQui consectetur qui dolorem.\nQui non non et quasi.\nNatus fugit deleniti qui harum sint soluta harum voluptas corrupti.", null, 16L },
                    { 67L, 72L, "Laudantium eos sunt iste enim incidunt voluptatum reprehenderit ut non. Libero possimus quos aut rerum ut quidem. Voluptates laboriosam est aut eveniet adipisci et.", new DateTime(2023, 6, 3, 11, 47, 15, 401, DateTimeKind.Unspecified).AddTicks(3753), "qui", new DateTime(2023, 7, 1, 6, 58, 28, 759, DateTimeKind.Unspecified).AddTicks(8044), 4L },
                    { 68L, 164L, "Consequatur consequatur et dolore nam et veniam placeat aut aspernatur. Rerum eligendi odit ut esse numquam aliquam id. Eaque consectetur commodi distinctio accusantium beatae ullam officiis.", new DateTime(2022, 11, 13, 17, 17, 29, 768, DateTimeKind.Unspecified).AddTicks(3679), "Assumenda corporis quia dolores voluptatem fugiat suscipit dolore explicabo odio.\nAutem aspernatur et voluptatem nihil.", new DateTime(2022, 12, 20, 5, 21, 23, 504, DateTimeKind.Unspecified).AddTicks(4329), 40L },
                    { 69L, 172L, "Saepe dolorum rerum qui modi qui.", new DateTime(2022, 10, 25, 2, 6, 57, 670, DateTimeKind.Unspecified).AddTicks(8685), "Et adipisci sapiente. Sint ut ad culpa aut consequatur molestias. Nobis qui voluptatem id impedit. Enim illo necessitatibus illo reprehenderit.", new DateTime(2023, 3, 30, 12, 41, 41, 215, DateTimeKind.Unspecified).AddTicks(3629), 16L },
                    { 70L, 30L, "Sequi aperiam nemo officiis et sapiente id amet.\nPerspiciatis incidunt dolore.", new DateTime(2022, 5, 31, 6, 19, 4, 64, DateTimeKind.Unspecified).AddTicks(1004), "Quia modi vel ea.\nNon harum aliquid sequi accusamus et in.\nUt qui expedita necessitatibus assumenda ut ex ut.\nCupiditate ea est ut amet exercitationem.\nDistinctio aut necessitatibus quas nihil architecto exercitationem.\nQuis mollitia ducimus occaecati.", new DateTime(2022, 7, 16, 22, 14, 40, 858, DateTimeKind.Unspecified).AddTicks(8566), 28L },
                    { 71L, 168L, "hic", new DateTime(2023, 4, 11, 22, 54, 32, 421, DateTimeKind.Unspecified).AddTicks(8577), "Deleniti sequi cupiditate aut eum.\nVoluptatem et perspiciatis voluptatem suscipit voluptas dolores veritatis.\nArchitecto voluptatem neque nesciunt velit animi ipsum eveniet fugiat officia.\nSint aliquam reprehenderit sapiente.\nQui dolorum voluptatem quia.\nVoluptatibus dolorem dolore mollitia modi expedita ab molestiae.", new DateTime(2023, 8, 15, 14, 23, 14, 524, DateTimeKind.Unspecified).AddTicks(4681), 8L },
                    { 72L, 116L, "Temporibus voluptate voluptatum quod nemo quaerat est exercitationem mollitia sit.", new DateTime(2023, 3, 1, 9, 22, 14, 213, DateTimeKind.Unspecified).AddTicks(7455), "Repellendus est eius dolor id dolor sunt. Sint error consectetur earum. Rem est placeat.", new DateTime(2023, 3, 15, 12, 19, 44, 15, DateTimeKind.Unspecified).AddTicks(9509), 24L },
                    { 73L, 54L, "Ratione in sit voluptatum nostrum.", new DateTime(2023, 8, 16, 9, 54, 40, 785, DateTimeKind.Unspecified).AddTicks(5661), "Blanditiis quam totam rerum in et.\nSed perferendis eius temporibus officiis nulla.\nEt amet repellendus ipsa perspiciatis.\nId nihil nesciunt.\nLaboriosam quis architecto id quisquam nihil quibusdam.", new DateTime(2023, 8, 21, 12, 48, 9, 74, DateTimeKind.Unspecified).AddTicks(7621), 27L },
                    { 74L, 85L, "Dolores aut quis.\nEos sit in.\nEos est eum est magnam maiores.\nAut facere quaerat eos ullam quis perspiciatis officiis.\nNemo quam quia id optio unde.\nSed tenetur ut velit et.", new DateTime(2022, 5, 26, 5, 59, 22, 49, DateTimeKind.Unspecified).AddTicks(777), "et", new DateTime(2023, 5, 30, 17, 29, 18, 667, DateTimeKind.Unspecified).AddTicks(8350), 12L },
                    { 75L, 152L, "Perspiciatis soluta facilis. Voluptatibus voluptatem temporibus provident repellendus. Tempora saepe quod odio veritatis aut dolor. Dolores nostrum minus veniam in. In aspernatur delectus odio sed voluptatum sit ipsa. Nostrum debitis dignissimos sapiente aliquid error sit.", new DateTime(2021, 12, 2, 0, 41, 16, 760, DateTimeKind.Unspecified).AddTicks(6218), "Qui eligendi laboriosam repudiandae.\nCommodi temporibus aperiam ut suscipit id veniam quaerat aut.\nAssumenda rerum ullam aliquid asperiores nemo quaerat sit nemo ducimus.\nEt aut molestiae maxime deleniti perspiciatis enim.", new DateTime(2022, 4, 28, 10, 51, 32, 325, DateTimeKind.Unspecified).AddTicks(7015), 5L },
                    { 76L, 39L, "architecto", new DateTime(2023, 6, 28, 16, 26, 38, 818, DateTimeKind.Unspecified).AddTicks(1625), "Impedit maiores aut et laboriosam voluptatem.\nSoluta porro qui molestiae officiis error molestias.\nLaudantium exercitationem maxime.\nEst sequi at inventore ut nesciunt ut non sed.", new DateTime(2023, 7, 12, 10, 47, 10, 700, DateTimeKind.Unspecified).AddTicks(5753), 28L },
                    { 77L, 106L, "Iusto hic minima doloribus nulla. Omnis ratione rerum. Consectetur et velit quisquam. Sit ut fugiat ad vero molestiae ipsa blanditiis doloribus.", new DateTime(2023, 8, 3, 9, 38, 36, 965, DateTimeKind.Unspecified).AddTicks(2128), "quae", null, 40L },
                    { 78L, 160L, "Accusantium ut laudantium temporibus omnis sunt explicabo repudiandae.\nRecusandae sequi molestiae.", new DateTime(2022, 12, 10, 23, 42, 57, 1, DateTimeKind.Unspecified).AddTicks(1921), "Vel rerum minima aperiam iste dolorum qui qui quos nostrum.", null, 36L },
                    { 79L, 172L, "Totam atque optio laudantium et sit.\nSit omnis perferendis.\nOccaecati fugiat nam quo alias ratione dolor ut ut dolor.", new DateTime(2023, 7, 7, 6, 31, 32, 8, DateTimeKind.Unspecified).AddTicks(2148), "Et at quia necessitatibus delectus.", new DateTime(2023, 7, 25, 5, 23, 18, 657, DateTimeKind.Unspecified).AddTicks(2086), 1L },
                    { 80L, 122L, "Veniam repudiandae beatae aspernatur delectus quis vero eum odio.\nBlanditiis ut vitae vitae dicta pariatur et dolore veniam illo.\nEt laborum est nostrum.\nQuia ut quia.\nAut dolores nihil eos quisquam ut aspernatur.\nConsequatur aut iste recusandae consectetur aut porro expedita aut.", new DateTime(2023, 6, 24, 12, 18, 19, 96, DateTimeKind.Unspecified).AddTicks(4023), "Culpa totam esse. Nobis eius corporis iure aut vero velit tenetur quaerat et. Voluptatem non modi ea. Placeat repellat labore voluptatum dolores ut officiis qui ut. Modi magnam magni vitae asperiores laboriosam quisquam et. Quas non quo repellat.", new DateTime(2023, 8, 3, 21, 15, 51, 488, DateTimeKind.Unspecified).AddTicks(7429), 6L },
                    { 81L, 68L, "Distinctio error sint nostrum.\nTempora itaque velit ducimus nisi sunt esse.\nQuidem rerum qui quia.", new DateTime(2022, 5, 1, 2, 31, 37, 774, DateTimeKind.Unspecified).AddTicks(3002), "Qui ipsa vero et eaque repellat sunt. Necessitatibus natus omnis perferendis sunt molestias error nobis non. Esse aut dolor iure qui neque ea exercitationem eum. Distinctio dolor et blanditiis rerum quibusdam in. Impedit repellat aliquam qui dolores quasi occaecati. Temporibus iste voluptas distinctio quasi quaerat est eum blanditiis quisquam.", new DateTime(2023, 3, 30, 21, 55, 18, 992, DateTimeKind.Unspecified).AddTicks(4849), 33L },
                    { 82L, 34L, "Quia aut veritatis explicabo magni omnis odit.\nReiciendis numquam sed eum aut quo accusamus quo quis et.", new DateTime(2023, 8, 20, 11, 45, 29, 658, DateTimeKind.Unspecified).AddTicks(2226), "Dignissimos in quia fugit.", new DateTime(2023, 8, 20, 16, 4, 22, 965, DateTimeKind.Unspecified).AddTicks(2191), 40L },
                    { 83L, 160L, "et", new DateTime(2022, 11, 29, 18, 45, 42, 939, DateTimeKind.Unspecified).AddTicks(4452), "Eos velit eum optio molestiae et iste.\nVeniam reprehenderit nulla.\nMaxime aut totam voluptatum voluptas omnis nostrum alias.\nConsequatur itaque rerum aspernatur.", new DateTime(2023, 5, 20, 5, 57, 49, 713, DateTimeKind.Unspecified).AddTicks(1793), 39L },
                    { 84L, 96L, "Quam at praesentium consequatur cum quis. Laborum voluptatem sed dolor ut autem. Debitis deserunt eum nobis libero eius.", new DateTime(2022, 3, 12, 2, 11, 24, 346, DateTimeKind.Unspecified).AddTicks(6412), "Ab voluptatum rerum animi totam enim.", new DateTime(2023, 1, 29, 0, 28, 45, 815, DateTimeKind.Unspecified).AddTicks(1326), 21L },
                    { 85L, 131L, "quia", new DateTime(2022, 11, 28, 9, 55, 41, 950, DateTimeKind.Unspecified).AddTicks(7509), "aut", new DateTime(2023, 7, 28, 16, 22, 38, 702, DateTimeKind.Unspecified).AddTicks(1707), 19L },
                    { 86L, 70L, "Soluta quisquam ut et. Vel veniam fugit aut alias repellat. Voluptatibus quia architecto et sed aspernatur voluptas et ipsum. Neque aspernatur fuga qui commodi aperiam. Ipsam voluptatem id commodi voluptatem.", new DateTime(2020, 6, 12, 21, 13, 59, 397, DateTimeKind.Unspecified).AddTicks(4058), "debitis", null, 38L },
                    { 87L, 97L, "Non quia ducimus.", new DateTime(2023, 6, 12, 13, 33, 9, 501, DateTimeKind.Unspecified).AddTicks(1708), "nisi", new DateTime(2023, 7, 3, 10, 47, 39, 864, DateTimeKind.Unspecified).AddTicks(7285), 24L },
                    { 88L, 73L, "Natus odio exercitationem accusamus. Magnam fugiat quos reiciendis qui odio. Sint velit reiciendis assumenda eaque quia assumenda tempore. Tenetur est dolor iste voluptatem blanditiis. Non minus et rem sit aut ipsam corrupti illo. Eius repellendus distinctio occaecati.", new DateTime(2022, 8, 23, 22, 58, 59, 41, DateTimeKind.Unspecified).AddTicks(1117), "molestiae", new DateTime(2023, 1, 7, 19, 32, 18, 420, DateTimeKind.Unspecified).AddTicks(5741), 1L },
                    { 89L, 197L, "magnam", new DateTime(2022, 10, 13, 17, 57, 22, 116, DateTimeKind.Unspecified).AddTicks(3278), "Autem id nam fugit enim. Autem ipsa sapiente et assumenda delectus. Earum aut quos quo nulla.", new DateTime(2023, 7, 27, 6, 56, 30, 332, DateTimeKind.Unspecified).AddTicks(8673), 39L },
                    { 90L, 61L, "Mollitia vitae quis molestias. Dolorem aliquid sit dolor impedit qui. Aut autem asperiores dolorum natus doloribus nesciunt eaque doloremque deleniti.", new DateTime(2023, 7, 8, 6, 49, 42, 37, DateTimeKind.Unspecified).AddTicks(8164), "Nemo voluptate pariatur.", new DateTime(2023, 8, 18, 1, 44, 40, 869, DateTimeKind.Unspecified).AddTicks(655), 6L },
                    { 91L, 43L, "Impedit facere qui voluptas earum et ipsam voluptas ipsum. Est sapiente neque doloribus reprehenderit aliquid minus est. Dolorem sed officia ad.", new DateTime(2022, 10, 22, 23, 14, 4, 212, DateTimeKind.Unspecified).AddTicks(6032), "quasi", new DateTime(2023, 1, 21, 17, 7, 51, 297, DateTimeKind.Unspecified).AddTicks(9289), 40L },
                    { 92L, 135L, "asperiores", new DateTime(2023, 8, 8, 14, 10, 34, 802, DateTimeKind.Unspecified).AddTicks(3859), "Accusamus aut modi numquam nihil. Porro voluptatem nisi provident dignissimos nobis ratione repudiandae. Voluptatem magni vel tenetur quo quia deleniti. Eligendi delectus ea animi. Ut libero dolor velit velit impedit. Et molestias rem impedit qui in enim.", null, 38L },
                    { 93L, 109L, "Officiis sit consequatur magnam neque reprehenderit eos provident. Sit fugit magnam aut cum. Dolore corrupti odio reprehenderit veniam facilis expedita odit et. Pariatur unde in et tempore. Quibusdam optio tempore autem animi. Rerum unde magni eum reiciendis modi.", new DateTime(2023, 6, 21, 3, 15, 58, 779, DateTimeKind.Unspecified).AddTicks(4318), "Exercitationem aliquam sint vel.\nFuga velit atque doloremque numquam architecto enim earum enim.\nVeniam laudantium culpa cum ipsam omnis ullam aut sequi.", new DateTime(2023, 7, 7, 16, 19, 0, 54, DateTimeKind.Unspecified).AddTicks(5227), 35L },
                    { 94L, 126L, "Neque nesciunt iste nostrum expedita nobis.\nPorro iure non facilis culpa cupiditate beatae consequatur ut.\nAspernatur excepturi rerum aut sit.\nRepellat autem voluptas cupiditate ut qui ratione.", new DateTime(2023, 6, 24, 18, 51, 52, 264, DateTimeKind.Unspecified).AddTicks(8637), "Expedita ratione dolor possimus omnis fuga omnis quo sapiente.\nNisi expedita corporis et dolor sed expedita aut et sequi.\nVoluptate qui error iste sint saepe neque animi maiores.", new DateTime(2023, 8, 11, 12, 26, 48, 401, DateTimeKind.Unspecified).AddTicks(235), 10L }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "Output", "SubmittedAt", "UserId" },
                values: new object[,]
                {
                    { 95L, 169L, "Id rem minus molestiae ab sunt. Laboriosam architecto dolores maxime qui. Quia dolor quia.", new DateTime(2023, 8, 18, 1, 43, 2, 299, DateTimeKind.Unspecified).AddTicks(6776), "Eius velit quidem. Et fugit aut est porro autem et omnis. Ipsam dolor labore sit nihil accusamus ea illo enim.", new DateTime(2023, 8, 20, 7, 4, 19, 822, DateTimeKind.Unspecified).AddTicks(4505), 9L },
                    { 96L, 175L, "Architecto illum dolorum non consequatur veniam aut quod sed. Architecto in sed delectus sunt quis eveniet velit saepe. Qui repellendus fugit rerum rerum voluptates voluptatibus temporibus ut adipisci.", new DateTime(2023, 3, 28, 8, 41, 59, 240, DateTimeKind.Unspecified).AddTicks(8956), "inventore", new DateTime(2023, 7, 7, 7, 49, 56, 736, DateTimeKind.Unspecified).AddTicks(9571), 26L },
                    { 97L, 117L, "Eos officia nemo illo quis expedita est magnam enim reprehenderit. Praesentium voluptatem magni qui nostrum nihil minus. Aspernatur corporis enim assumenda et sunt perferendis est libero libero. Incidunt reiciendis aut repellat quibusdam eos voluptatum veritatis animi nostrum.", new DateTime(2023, 4, 19, 7, 47, 50, 13, DateTimeKind.Unspecified).AddTicks(886), "qui", null, 21L },
                    { 98L, 27L, "Consequatur reiciendis voluptate recusandae numquam deserunt.", new DateTime(2023, 5, 26, 1, 26, 49, 52, DateTimeKind.Unspecified).AddTicks(4713), "Deleniti enim aut odit qui vel. Perspiciatis ex voluptatem sit. Vel facilis magni est sapiente sunt temporibus. Dolore temporibus aut ad. Distinctio repudiandae qui quae. Ea aut ipsa sunt culpa voluptas velit doloremque ratione eos.", new DateTime(2023, 5, 27, 14, 45, 0, 249, DateTimeKind.Unspecified).AddTicks(9732), 17L },
                    { 99L, 194L, "Ad dolore magnam sit eaque. Eos est ullam id repudiandae et totam laboriosam. Laudantium et ea quos est veritatis.", new DateTime(2023, 8, 21, 22, 13, 11, 160, DateTimeKind.Unspecified).AddTicks(7687), "Molestiae est assumenda sed commodi a aut dolore rem in. Et rerum iure recusandae velit tenetur necessitatibus. Aut fugit modi. Vitae harum sapiente in consequatur qui totam ad.", new DateTime(2023, 8, 22, 18, 45, 20, 773, DateTimeKind.Unspecified).AddTicks(3585), 19L },
                    { 100L, 110L, "Laboriosam dolores nam ducimus saepe. Cumque dolorem incidunt nihil beatae assumenda quia est rem. Sed reiciendis nobis atque in iste ullam autem consequatur.", new DateTime(2023, 4, 27, 8, 50, 30, 504, DateTimeKind.Unspecified).AddTicks(9057), "Fugiat voluptatem autem.", new DateTime(2023, 7, 2, 18, 5, 10, 135, DateTimeKind.Unspecified).AddTicks(608), 22L },
                    { 101L, 82L, "Omnis dolor quis non eos ipsum.", new DateTime(2023, 5, 5, 3, 46, 33, 557, DateTimeKind.Unspecified).AddTicks(6930), "Optio aut optio dolores quas.", new DateTime(2023, 7, 3, 7, 21, 38, 16, DateTimeKind.Unspecified).AddTicks(8739), 16L },
                    { 102L, 182L, "Dignissimos officia quisquam et quas iusto officiis provident voluptas. Vitae nesciunt commodi molestiae velit in iste. Eum repudiandae quam nemo sed.", new DateTime(2021, 1, 5, 10, 12, 42, 289, DateTimeKind.Unspecified).AddTicks(5699), "Illum voluptate eos quis reprehenderit.", new DateTime(2022, 7, 15, 3, 46, 50, 740, DateTimeKind.Unspecified).AddTicks(9747), 26L },
                    { 103L, 103L, "error", new DateTime(2023, 8, 15, 10, 37, 54, 376, DateTimeKind.Unspecified).AddTicks(9847), "harum", new DateTime(2023, 8, 22, 5, 25, 39, 935, DateTimeKind.Unspecified).AddTicks(5310), 30L },
                    { 104L, 162L, "Sapiente non omnis voluptatibus.\nIn minima qui dolores iure ut provident est.\nMinus neque ducimus.", new DateTime(2021, 6, 16, 6, 46, 1, 301, DateTimeKind.Unspecified).AddTicks(722), "Repellendus explicabo consequatur. Quos et est in culpa qui quo possimus repellat. Ducimus non deserunt velit ut molestias quo consequuntur.", new DateTime(2022, 8, 15, 17, 1, 0, 427, DateTimeKind.Unspecified).AddTicks(5356), 8L },
                    { 105L, 76L, "Voluptate sint dignissimos ullam aliquid et quia earum.\nEaque placeat aut accusamus soluta tempore.\nProvident perferendis culpa aut similique aperiam consequatur.\nSed expedita saepe velit fuga a nobis earum.\nUt quae velit ipsam cumque quia culpa.", new DateTime(2020, 4, 5, 16, 13, 0, 980, DateTimeKind.Unspecified).AddTicks(2407), "Non omnis a quaerat sint dolores fuga alias non consequuntur.\nAut quis molestias omnis aspernatur eligendi ut consequatur voluptatem provident.\nConsequatur quaerat ut quidem voluptatum.\nEum est alias beatae sint.\nArchitecto ut et.", new DateTime(2023, 8, 21, 20, 4, 44, 310, DateTimeKind.Unspecified).AddTicks(2332), 17L },
                    { 106L, 107L, "Autem tempore est sed id et est quisquam. Iure culpa tenetur optio quis. Expedita ut ipsum labore consequuntur eveniet consectetur quaerat iusto officiis. Exercitationem deserunt itaque voluptatem in deserunt asperiores et dolor. Temporibus id modi inventore reprehenderit ea qui est quos hic. Fugit dolores velit est repellendus sint est.", new DateTime(2023, 4, 25, 13, 31, 1, 373, DateTimeKind.Unspecified).AddTicks(4103), "Aliquam nam placeat suscipit perferendis dolor.\nVel maiores a.\nOdit et accusamus.\nRerum sit minus ut est provident earum.\nEnim dolor aspernatur non libero autem beatae nemo officiis in.", new DateTime(2023, 6, 21, 8, 27, 33, 440, DateTimeKind.Unspecified).AddTicks(1726), 22L },
                    { 107L, 93L, "Error repudiandae molestias doloribus laudantium consequatur sunt.", new DateTime(2020, 8, 4, 21, 18, 22, 634, DateTimeKind.Unspecified).AddTicks(4955), "Suscipit tenetur quia asperiores rerum ipsam id odio nesciunt.\nAliquam ut voluptatem voluptates et quia non autem suscipit sed.", null, 19L },
                    { 108L, 180L, "Nulla ipsum cupiditate maiores et tenetur maxime ex libero qui.\nEius suscipit aperiam error laudantium voluptatem eius saepe.\nLaboriosam aliquam voluptatum velit quia quas commodi.\nMollitia et hic enim aut aut deserunt maiores iure.", new DateTime(2023, 7, 10, 5, 59, 17, 273, DateTimeKind.Unspecified).AddTicks(2786), "Et neque ullam ut rerum porro sed velit.", new DateTime(2023, 8, 7, 12, 35, 50, 228, DateTimeKind.Unspecified).AddTicks(9750), 18L },
                    { 109L, 33L, "Officia eligendi voluptas dolor quia officia officiis.\nNihil quidem iure suscipit provident odio in architecto ab.\nDolorem iusto ipsa porro provident atque.\nNemo molestiae aut.\nId quia unde quae quia consequatur nostrum veritatis.\nMollitia deleniti nostrum ut fugit enim.", new DateTime(2022, 9, 19, 20, 3, 1, 466, DateTimeKind.Unspecified).AddTicks(6756), "Nam alias quia qui deserunt sit saepe in iste.", new DateTime(2023, 5, 12, 1, 54, 58, 342, DateTimeKind.Unspecified).AddTicks(6415), 35L },
                    { 110L, 36L, "Qui excepturi voluptas.\nQuia iusto veniam perferendis natus.\nUt qui quas id modi sequi corporis rerum molestiae et.\nPerferendis autem et facilis et dolores magni numquam quibusdam dolor.\nReprehenderit deleniti nostrum quibusdam atque quos laboriosam similique eaque.\nDoloremque et unde quaerat illo ut itaque est reprehenderit.", new DateTime(2023, 6, 4, 5, 21, 6, 217, DateTimeKind.Unspecified).AddTicks(8786), "id", new DateTime(2023, 7, 31, 16, 31, 38, 591, DateTimeKind.Unspecified).AddTicks(763), 10L },
                    { 111L, 134L, "Voluptatem quibusdam omnis sed provident.\nVoluptatem enim nihil libero consequatur ullam ea laborum.\nVoluptatibus commodi odit.\nAnimi et consectetur cupiditate voluptate id.\nRatione nemo atque.", new DateTime(2023, 3, 20, 20, 57, 52, 253, DateTimeKind.Unspecified).AddTicks(5395), "ullam", null, 35L },
                    { 112L, 76L, "Perferendis molestias doloremque a sint.", new DateTime(2022, 4, 25, 23, 51, 30, 112, DateTimeKind.Unspecified).AddTicks(8147), "culpa", new DateTime(2022, 6, 13, 0, 49, 46, 128, DateTimeKind.Unspecified).AddTicks(5442), 36L },
                    { 113L, 44L, "Aliquam architecto iusto.", new DateTime(2023, 1, 31, 3, 7, 32, 391, DateTimeKind.Unspecified).AddTicks(1292), "Sint blanditiis animi porro eum. Quis a et explicabo est. Quo ab sunt. Similique voluptates cum quas dolorem est optio excepturi quia expedita.", new DateTime(2023, 6, 1, 14, 35, 11, 996, DateTimeKind.Unspecified).AddTicks(4356), 30L },
                    { 114L, 156L, "Quibusdam natus voluptates ipsam consequuntur ipsum est fuga dolore quis. Doloremque fugit corporis doloribus autem molestias cupiditate veniam assumenda provident. Possimus sunt molestias ipsum et sequi ea aperiam voluptatem. Sit et aliquam provident ut magnam dolor quas at. Voluptatum velit id quia.", new DateTime(2023, 8, 6, 9, 0, 37, 743, DateTimeKind.Unspecified).AddTicks(8531), "Eius sunt nemo facilis.\nVel consequatur aut illum aut tenetur iste dolores voluptatem non.\nAut cumque enim.\nPraesentium voluptate aliquam.", new DateTime(2023, 8, 11, 23, 46, 31, 845, DateTimeKind.Unspecified).AddTicks(8207), 30L },
                    { 115L, 66L, "Suscipit harum amet non qui rerum.", new DateTime(2023, 4, 12, 1, 43, 4, 915, DateTimeKind.Unspecified).AddTicks(3922), "Nihil magnam est voluptatem dignissimos. Rerum ea earum voluptatem iure dolores rem incidunt vel. Vel fugiat error et illo ab est praesentium sit.", new DateTime(2023, 6, 26, 14, 33, 25, 617, DateTimeKind.Unspecified).AddTicks(8274), 19L },
                    { 116L, 117L, "Tenetur laboriosam rerum.", new DateTime(2022, 8, 14, 6, 23, 0, 472, DateTimeKind.Unspecified).AddTicks(7163), "Consequatur sint eum omnis reprehenderit. A doloribus eos. Consequatur neque voluptas fugit reprehenderit nostrum. Autem natus voluptatem qui aut. Culpa autem illum repellat ipsam ut dolores.", null, 14L },
                    { 117L, 168L, "Expedita quidem quas nisi laborum molestiae natus.\nAutem sequi soluta nam doloremque excepturi.", new DateTime(2023, 1, 9, 20, 22, 10, 617, DateTimeKind.Unspecified).AddTicks(2614), "rem", new DateTime(2023, 3, 7, 10, 57, 55, 332, DateTimeKind.Unspecified).AddTicks(764), 18L },
                    { 118L, 70L, "Ducimus est illo tempora magni assumenda dicta quod.\nAut porro molestiae omnis voluptatum.", new DateTime(2022, 2, 22, 2, 34, 14, 838, DateTimeKind.Unspecified).AddTicks(7873), "Sit iure accusantium nulla quidem debitis aut.", new DateTime(2022, 5, 1, 1, 21, 0, 904, DateTimeKind.Unspecified).AddTicks(231), 34L },
                    { 119L, 63L, "repellendus", new DateTime(2023, 5, 24, 7, 41, 24, 94, DateTimeKind.Unspecified).AddTicks(2310), "Vero saepe rerum accusamus sit ad accusantium.\nItaque voluptate tempora.", new DateTime(2023, 8, 19, 13, 38, 40, 274, DateTimeKind.Unspecified).AddTicks(2835), 32L },
                    { 120L, 27L, "Perspiciatis quia aut similique fuga. Debitis similique facilis eveniet. Totam veritatis harum laboriosam ut qui deleniti.", new DateTime(2023, 6, 13, 5, 10, 46, 134, DateTimeKind.Unspecified).AddTicks(3348), "Alias dolor optio.\nDebitis ipsa eaque pariatur dolorem porro.\nOmnis quis ut vel pariatur quia.\nEst blanditiis nihil vel dolorem.\nEarum neque nesciunt ut consequatur autem.", new DateTime(2023, 7, 1, 15, 10, 28, 106, DateTimeKind.Unspecified).AddTicks(289), 40L },
                    { 121L, 11L, "Aspernatur maxime dolor voluptas quisquam.", new DateTime(2023, 1, 21, 9, 5, 23, 473, DateTimeKind.Unspecified).AddTicks(4483), "Fugit repudiandae eligendi sunt.", null, 39L },
                    { 122L, 60L, "voluptate", new DateTime(2022, 9, 2, 19, 0, 1, 962, DateTimeKind.Unspecified).AddTicks(8236), "Non porro aut et eaque.\nQuisquam voluptatem aut aut asperiores hic ut modi sint.\nEt maiores ut maiores enim accusantium.\nQuasi aut possimus sed omnis beatae.\nAt molestiae vel ipsa sunt.", new DateTime(2023, 5, 2, 17, 50, 39, 358, DateTimeKind.Unspecified).AddTicks(3926), 2L },
                    { 123L, 38L, "Et culpa aspernatur aut excepturi aperiam cumque qui et.", new DateTime(2022, 7, 31, 15, 22, 57, 787, DateTimeKind.Unspecified).AddTicks(9633), "Et a quas dolore vel inventore veniam tempore.", null, 38L },
                    { 124L, 143L, "et", new DateTime(2023, 7, 9, 1, 55, 16, 239, DateTimeKind.Unspecified).AddTicks(303), "Voluptas corporis numquam non.\nSed necessitatibus ut repellat et dicta.\nQuos eligendi molestiae.\nAmet vitae et dolor.", new DateTime(2023, 7, 9, 19, 25, 38, 894, DateTimeKind.Unspecified).AddTicks(1580), 20L },
                    { 125L, 26L, "Doloremque officiis perferendis vel non.\nOmnis quia et aspernatur dolores iure.\nVoluptas veritatis eaque qui accusamus.", new DateTime(2023, 7, 20, 22, 4, 53, 571, DateTimeKind.Unspecified).AddTicks(6042), "Vero tenetur esse officia impedit eligendi consequuntur ut velit.\nAutem voluptates sunt.", new DateTime(2023, 8, 13, 13, 29, 17, 636, DateTimeKind.Unspecified).AddTicks(5056), 38L },
                    { 126L, 195L, "sint", new DateTime(2023, 6, 14, 9, 23, 28, 288, DateTimeKind.Unspecified).AddTicks(2551), "Dicta officia soluta nihil rerum et commodi et.", new DateTime(2023, 7, 18, 12, 10, 55, 455, DateTimeKind.Unspecified).AddTicks(2177), 26L },
                    { 127L, 20L, "Et quisquam est eius ullam dicta cumque voluptatum repellendus. Recusandae consequatur debitis alias et dicta cupiditate ratione et eum. Veniam ab voluptatum ut assumenda consequatur dolorem impedit vitae assumenda. Et repudiandae consequatur ea. Dicta velit repellat rerum quia.", new DateTime(2022, 8, 29, 9, 23, 31, 562, DateTimeKind.Unspecified).AddTicks(42), "Omnis omnis facilis ex fugit sapiente doloremque illo.\nRerum numquam libero quia soluta provident porro debitis voluptas.\nDolores qui sit delectus harum aliquam illum iusto.\nAccusamus earum cumque rerum enim possimus doloribus eius.\nTotam mollitia quia quod sequi vero doloremque voluptatem.", new DateTime(2023, 7, 10, 17, 0, 36, 393, DateTimeKind.Unspecified).AddTicks(8010), 28L },
                    { 128L, 74L, "odio", new DateTime(2023, 1, 8, 18, 6, 54, 773, DateTimeKind.Unspecified).AddTicks(7527), "Quis qui aut aspernatur exercitationem non exercitationem amet eum amet. Ea esse eligendi enim asperiores velit ipsum. Reprehenderit in quia recusandae atque similique est. Vero qui recusandae. Cumque cumque assumenda et harum.", new DateTime(2023, 5, 23, 1, 48, 7, 445, DateTimeKind.Unspecified).AddTicks(8062), 29L },
                    { 129L, 141L, "In voluptas soluta porro error nostrum mollitia enim commodi. Velit quae est non. Sunt et iusto animi saepe molestiae officiis.", new DateTime(2023, 4, 18, 16, 10, 37, 285, DateTimeKind.Unspecified).AddTicks(3538), "Soluta minima ipsa.\nMaiores rerum est exercitationem explicabo et labore ipsa enim.\nExercitationem suscipit doloribus suscipit corrupti.\nSunt voluptatibus amet quo qui.\nAut consequatur magni.", new DateTime(2023, 4, 22, 15, 10, 46, 506, DateTimeKind.Unspecified).AddTicks(4119), 37L },
                    { 130L, 41L, "In vel ut aut placeat iste fuga. Non consectetur ratione corporis natus. Ut ipsum exercitationem quas optio sunt quia qui saepe itaque.", new DateTime(2022, 12, 24, 14, 29, 56, 995, DateTimeKind.Unspecified).AddTicks(8497), "dolorem", new DateTime(2022, 12, 27, 11, 58, 49, 327, DateTimeKind.Unspecified).AddTicks(8993), 8L },
                    { 131L, 55L, "Dolor deserunt a modi unde.", new DateTime(2023, 7, 27, 9, 2, 54, 628, DateTimeKind.Unspecified).AddTicks(2252), "Ut velit ut eos et sunt voluptatibus. Quas id qui amet. Aliquid aliquam atque voluptas similique qui eum quam est sint. Id sit dolor nisi culpa rerum maxime.", new DateTime(2023, 8, 14, 6, 56, 2, 55, DateTimeKind.Unspecified).AddTicks(5294), 28L },
                    { 132L, 199L, "Deserunt adipisci eaque et. Non eius commodi molestiae laboriosam. Saepe voluptatibus labore ipsa qui illum.", new DateTime(2023, 2, 6, 5, 0, 28, 646, DateTimeKind.Unspecified).AddTicks(9406), "Quae autem quidem.\nIste doloribus praesentium repudiandae reprehenderit est nemo.\nMagnam reprehenderit asperiores amet vel distinctio.", new DateTime(2023, 6, 16, 6, 45, 41, 153, DateTimeKind.Unspecified).AddTicks(2272), 10L },
                    { 133L, 47L, "odit", new DateTime(2023, 2, 23, 1, 28, 34, 238, DateTimeKind.Unspecified).AddTicks(3039), "voluptas", new DateTime(2023, 7, 26, 19, 24, 8, 906, DateTimeKind.Unspecified).AddTicks(1879), 18L },
                    { 134L, 10L, "Quibusdam iste praesentium molestias.\nEt nemo ut quod doloremque.\nFacilis officia dolore vero omnis sequi odio iure est iure.\nHarum rem quas modi voluptatem soluta.\nVoluptas quae rerum.\nVoluptatem adipisci et et voluptatem.", new DateTime(2023, 8, 11, 13, 29, 2, 767, DateTimeKind.Unspecified).AddTicks(1881), "Nobis laborum aut consequuntur. Dolor adipisci autem fuga eligendi dolorem. Nisi quod ex molestiae. Consequatur veritatis quae et delectus ut maiores explicabo laboriosam quia. Tempora quo alias. Praesentium qui nihil fugiat expedita nisi.", new DateTime(2023, 8, 15, 4, 8, 5, 638, DateTimeKind.Unspecified).AddTicks(1492), 4L },
                    { 135L, 32L, "modi", new DateTime(2023, 8, 5, 15, 17, 22, 896, DateTimeKind.Unspecified).AddTicks(8879), "Voluptas nihil itaque ratione saepe rerum qui.\nImpedit doloribus aperiam et at qui voluptatem repellendus.\nLaboriosam omnis rerum aperiam occaecati ut rerum voluptates.\nEius quia officia.\nVoluptas molestiae eum et numquam occaecati ut at officia.\nVel maiores quia libero enim doloremque consectetur.", new DateTime(2023, 8, 13, 17, 4, 1, 56, DateTimeKind.Unspecified).AddTicks(8036), 28L },
                    { 136L, 12L, "Voluptatem iusto exercitationem labore debitis nam. Magni tenetur modi est nobis. Non et rerum.", new DateTime(2023, 3, 29, 7, 20, 53, 923, DateTimeKind.Unspecified).AddTicks(2663), "Dolores ab in mollitia. Debitis dolorem provident dolorem asperiores. Aut cupiditate quis enim saepe. Id et impedit. Omnis vero dolorem dignissimos nihil nisi dolores possimus non impedit. Magni porro debitis odio sint voluptas delectus.", new DateTime(2023, 4, 12, 11, 14, 26, 415, DateTimeKind.Unspecified).AddTicks(1793), 15L }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "Output", "SubmittedAt", "UserId" },
                values: new object[,]
                {
                    { 137L, 69L, "Enim maxime aperiam.\nMinima eius eaque minima culpa adipisci incidunt.\nFuga sed est omnis.", new DateTime(2023, 7, 22, 23, 22, 25, 207, DateTimeKind.Unspecified).AddTicks(6578), "Facere consequatur dolores officiis reiciendis et rerum aliquam.\nEst blanditiis quisquam excepturi odit dolorum aperiam reprehenderit.\nMaiores et in sunt iusto exercitationem et nobis.", new DateTime(2023, 8, 3, 12, 39, 30, 861, DateTimeKind.Unspecified).AddTicks(3031), 28L },
                    { 138L, 131L, "Reiciendis officia ad vel accusamus illo ullam rerum sapiente.", new DateTime(2023, 6, 21, 3, 36, 58, 883, DateTimeKind.Unspecified).AddTicks(6212), "Consequuntur rem quisquam quae consequatur et exercitationem.", new DateTime(2023, 7, 8, 20, 15, 22, 127, DateTimeKind.Unspecified).AddTicks(3093), 3L },
                    { 139L, 44L, "Et nostrum iste ullam.", new DateTime(2022, 12, 24, 0, 18, 32, 991, DateTimeKind.Unspecified).AddTicks(1011), "Quam repellat officiis sed sint.", new DateTime(2023, 6, 3, 14, 16, 28, 214, DateTimeKind.Unspecified).AddTicks(4613), 14L },
                    { 140L, 193L, "Non ipsum assumenda delectus rerum suscipit quia architecto. Aut doloribus optio non ut. Et voluptas maxime nisi provident aspernatur dicta. Animi amet provident expedita.", new DateTime(2021, 9, 17, 13, 4, 58, 324, DateTimeKind.Unspecified).AddTicks(1261), "Iure ut et nulla tenetur dignissimos accusantium vero voluptas.", new DateTime(2022, 2, 15, 1, 35, 20, 54, DateTimeKind.Unspecified).AddTicks(1713), 37L },
                    { 141L, 188L, "aut", new DateTime(2023, 5, 31, 21, 29, 14, 747, DateTimeKind.Unspecified).AddTicks(246), "Id minima ut itaque ducimus et. Voluptas ipsa ipsum dolor aut cum ipsa. Voluptates quo molestiae at reiciendis. Officia eum odio fugiat vel molestiae. Delectus itaque quisquam ut rerum non cum quos corrupti doloremque.", new DateTime(2023, 7, 21, 5, 25, 49, 343, DateTimeKind.Unspecified).AddTicks(3278), 25L },
                    { 142L, 171L, "Quis veritatis repudiandae quia aliquid tenetur maiores est asperiores.\nSaepe laudantium odit.\nVoluptatum quisquam officiis.\nQui et dolorem.", new DateTime(2023, 2, 10, 14, 8, 38, 116, DateTimeKind.Unspecified).AddTicks(1163), "Aut nihil consequatur enim repudiandae.", new DateTime(2023, 6, 25, 10, 33, 19, 60, DateTimeKind.Unspecified).AddTicks(8833), 26L },
                    { 143L, 93L, "explicabo", new DateTime(2021, 11, 8, 14, 29, 34, 161, DateTimeKind.Unspecified).AddTicks(9257), "Omnis officia voluptas commodi suscipit eius nam animi voluptatem molestiae.", new DateTime(2023, 2, 26, 13, 19, 43, 748, DateTimeKind.Unspecified).AddTicks(1102), 22L },
                    { 144L, 181L, "fugit", new DateTime(2022, 5, 10, 15, 9, 24, 692, DateTimeKind.Unspecified).AddTicks(8340), "Odit dolor perspiciatis facilis quasi reiciendis qui velit.\nSimilique architecto aut aut.\nFugit occaecati nobis et eum dolore cumque quia in.\nVoluptas qui consequatur quia est blanditiis omnis qui ad libero.\nReiciendis ipsa quia exercitationem ex beatae magnam in qui.\nSunt aliquid officiis laborum ea iste ab aut sunt.", new DateTime(2023, 3, 15, 23, 11, 1, 843, DateTimeKind.Unspecified).AddTicks(6358), 40L },
                    { 145L, 197L, "Nobis quod autem.\nCumque dignissimos rerum eos voluptatum natus est voluptatum.\nDucimus consequatur rerum aperiam.\nAut dolores excepturi consequatur.\nQui officia cumque tempore delectus mollitia eum et tempore eum.\nSimilique expedita distinctio.", new DateTime(2023, 3, 8, 19, 27, 45, 409, DateTimeKind.Unspecified).AddTicks(9641), "accusamus", new DateTime(2023, 8, 3, 15, 58, 6, 824, DateTimeKind.Unspecified).AddTicks(172), 37L },
                    { 146L, 175L, "In perspiciatis explicabo et fuga.", new DateTime(2023, 2, 27, 12, 4, 5, 256, DateTimeKind.Unspecified).AddTicks(9542), "Quas ipsam quo et sunt repellat est et perspiciatis.\nVoluptatem aspernatur sunt.\nAut voluptatem quis.\nQuia adipisci voluptatem ipsa corrupti voluptates ducimus quaerat corporis.", new DateTime(2023, 7, 12, 2, 59, 30, 842, DateTimeKind.Unspecified).AddTicks(3601), 6L },
                    { 147L, 11L, "unde", new DateTime(2023, 2, 26, 17, 23, 54, 645, DateTimeKind.Unspecified).AddTicks(1068), "Deserunt vitae officiis dolores veritatis molestiae autem tempore dolor.\nNostrum nam earum ratione.\nCommodi quia nobis laudantium eum non et fugiat optio.", new DateTime(2023, 4, 26, 4, 13, 3, 777, DateTimeKind.Unspecified).AddTicks(6544), 26L },
                    { 148L, 27L, "Et sit eligendi dolor qui inventore sunt. Eligendi ut enim. Aut laudantium non. Alias adipisci eum. Sunt nihil necessitatibus reiciendis magnam quia quos aut perspiciatis.", new DateTime(2023, 7, 6, 10, 56, 2, 489, DateTimeKind.Unspecified).AddTicks(5669), "Labore optio minus aperiam laborum qui reiciendis repudiandae ut deserunt.", new DateTime(2023, 7, 23, 1, 23, 21, 275, DateTimeKind.Unspecified).AddTicks(3221), 15L },
                    { 149L, 56L, "Consequatur voluptas error.\nSoluta totam sed.", new DateTime(2023, 2, 21, 10, 34, 14, 117, DateTimeKind.Unspecified).AddTicks(5833), "Provident ad similique vitae sunt incidunt voluptatem aperiam.", new DateTime(2023, 4, 20, 3, 11, 0, 624, DateTimeKind.Unspecified).AddTicks(8699), 13L },
                    { 150L, 100L, "veniam", new DateTime(2022, 12, 24, 18, 44, 43, 511, DateTimeKind.Unspecified).AddTicks(4164), "Nostrum velit harum iusto quos enim rerum quia.\nAliquid consequuntur sit voluptatem.\nQuia id ducimus quidem optio excepturi dolor ut quis.", new DateTime(2023, 6, 24, 10, 31, 14, 686, DateTimeKind.Unspecified).AddTicks(2848), 13L },
                    { 151L, 96L, "Unde velit qui repudiandae et. Aspernatur dolor quaerat. Qui aspernatur ut et. Perferendis mollitia qui dolorem in.", new DateTime(2022, 12, 19, 22, 13, 53, 408, DateTimeKind.Unspecified).AddTicks(7036), "A iure dolorem voluptatem earum dicta natus architecto consequatur.\nQuasi culpa id sed sint recusandae et ut at.\nIpsam eum aut in voluptate adipisci.\nSequi nam voluptatibus minus quidem soluta.\nAssumenda non esse assumenda nesciunt optio optio quia.\nEnim ut voluptas.", new DateTime(2023, 2, 9, 17, 55, 4, 725, DateTimeKind.Unspecified).AddTicks(7252), 28L },
                    { 152L, 82L, "temporibus", new DateTime(2023, 6, 2, 0, 43, 14, 736, DateTimeKind.Unspecified).AddTicks(8635), "In culpa nihil voluptates maxime eligendi.", new DateTime(2023, 6, 9, 22, 36, 38, 336, DateTimeKind.Unspecified).AddTicks(8804), 17L },
                    { 153L, 27L, "Iure sint rerum consectetur nesciunt quod adipisci ex sed. Beatae et repudiandae rem blanditiis consequatur quas. Aliquam numquam consectetur rerum doloribus vero velit consequatur exercitationem. Facilis quia laudantium et maxime impedit nostrum eligendi. Aperiam harum soluta dolore modi. Molestiae fugiat dolore.", new DateTime(2023, 7, 31, 0, 50, 7, 884, DateTimeKind.Unspecified).AddTicks(9816), "In deserunt deserunt rerum minus in dignissimos cupiditate doloremque dolor. Ducimus atque quo commodi. Est facere sed. Omnis cupiditate totam non. Ut ut et et accusantium neque tempora. Possimus et culpa officiis temporibus.", new DateTime(2023, 8, 3, 23, 26, 5, 986, DateTimeKind.Unspecified).AddTicks(8511), 1L },
                    { 154L, 108L, "Ut omnis molestias soluta necessitatibus sit.", new DateTime(2023, 8, 3, 22, 27, 13, 572, DateTimeKind.Unspecified).AddTicks(775), "Facere consectetur ab quia eum et voluptas.", new DateTime(2023, 8, 3, 23, 50, 37, 324, DateTimeKind.Unspecified).AddTicks(540), 25L },
                    { 155L, 63L, "Facilis dolor neque eos quod quasi sit deserunt. Numquam qui laboriosam quia praesentium. Dolor voluptas libero et.", new DateTime(2023, 1, 8, 11, 37, 10, 553, DateTimeKind.Unspecified).AddTicks(8548), "Praesentium quos quisquam.\nNon enim impedit aliquam.\nIste ratione aperiam et eveniet qui quia facere.\nNihil mollitia repellendus voluptates expedita qui iste.", new DateTime(2023, 2, 13, 20, 44, 55, 870, DateTimeKind.Unspecified).AddTicks(9969), 6L },
                    { 156L, 199L, "Nesciunt et quia libero eos quos.", new DateTime(2023, 4, 18, 12, 33, 26, 332, DateTimeKind.Unspecified).AddTicks(1602), "Aut sunt ipsum adipisci ipsum mollitia voluptas qui occaecati repudiandae.\nAmet ut incidunt unde.", new DateTime(2023, 6, 6, 9, 54, 5, 634, DateTimeKind.Unspecified).AddTicks(3881), 34L },
                    { 157L, 32L, "Est quis libero.", new DateTime(2023, 7, 11, 16, 22, 48, 543, DateTimeKind.Unspecified).AddTicks(929), "Inventore sit quaerat sapiente ea porro est. Atque sed eum unde maiores. Rerum aperiam quia nostrum consectetur qui omnis fugiat ratione.", new DateTime(2023, 7, 30, 23, 52, 23, 402, DateTimeKind.Unspecified).AddTicks(1379), 33L },
                    { 158L, 83L, "Exercitationem ea possimus reprehenderit laboriosam et amet. Aliquam blanditiis non aliquid praesentium nemo quo perferendis animi. Expedita dolorem vel nobis voluptas autem. Aperiam praesentium consequatur iure. Vero qui id aut dicta. Tempora iusto corporis eum.", new DateTime(2023, 7, 30, 20, 47, 3, 473, DateTimeKind.Unspecified).AddTicks(1536), "Itaque error deleniti est quos voluptatem consequatur at praesentium incidunt. Qui laborum sint sapiente dolorem corporis adipisci vel. Doloribus mollitia omnis placeat ducimus modi. Repellendus neque sequi enim incidunt accusamus maxime ut. Maxime ut delectus quos.", new DateTime(2023, 8, 5, 2, 9, 33, 996, DateTimeKind.Unspecified).AddTicks(5397), 16L },
                    { 159L, 84L, "Ut enim repellat amet iste fugit hic nisi. Minus et enim tempore modi est nemo a corrupti. Et laborum minus nihil tenetur. Rerum perferendis culpa velit.", new DateTime(2023, 2, 22, 2, 57, 50, 329, DateTimeKind.Unspecified).AddTicks(4235), "Placeat aut sint saepe sequi vitae tempore.\nQuibusdam natus nihil aut odit eligendi qui nesciunt quisquam.\nVoluptatem qui deserunt.\nInventore sed nulla ipsa a tempore aut.\nQui ut accusamus nam cupiditate.\nNihil quibusdam sequi officiis illum occaecati quasi illo.", null, 13L },
                    { 160L, 74L, "Enim laudantium maiores. Repudiandae voluptatibus quae aut. Alias et molestiae. Nesciunt eos dignissimos dolorem quia qui. Itaque reprehenderit culpa architecto ut consequatur tempora et adipisci nihil. Dolore excepturi eaque asperiores voluptate soluta eum.", new DateTime(2022, 10, 28, 3, 23, 59, 387, DateTimeKind.Unspecified).AddTicks(784), "Ipsa placeat illum et rerum quidem voluptatem minima. Consequatur rerum ea non dolorem aut. Voluptates animi et possimus et sint cumque qui voluptate sint. Neque minus voluptas repellendus suscipit minus. Eveniet rerum voluptas quia.", new DateTime(2022, 12, 12, 20, 26, 37, 252, DateTimeKind.Unspecified).AddTicks(3689), 36L },
                    { 161L, 119L, "expedita", new DateTime(2023, 6, 19, 3, 47, 31, 334, DateTimeKind.Unspecified).AddTicks(281), "Fugit occaecati assumenda repellendus debitis delectus magni consequuntur ab. Praesentium quisquam quaerat doloribus perspiciatis facilis. Laborum libero facere enim labore quia nihil. Ut soluta laudantium dolores facilis quod error suscipit. Ab non asperiores alias blanditiis assumenda quae.", new DateTime(2023, 8, 6, 20, 1, 57, 29, DateTimeKind.Unspecified).AddTicks(5290), 31L },
                    { 162L, 199L, "dicta", new DateTime(2022, 12, 20, 20, 53, 42, 83, DateTimeKind.Unspecified).AddTicks(6899), "Quae quia dolorem mollitia officiis in.\nVitae laboriosam veniam.", new DateTime(2023, 6, 5, 17, 36, 37, 4, DateTimeKind.Unspecified).AddTicks(6001), 27L },
                    { 163L, 168L, "Earum suscipit et qui sequi ut nihil et est.", new DateTime(2023, 5, 24, 8, 38, 16, 555, DateTimeKind.Unspecified).AddTicks(787), "Et mollitia vero asperiores quia eligendi reprehenderit. Repudiandae quia vel non sint fugit atque. Omnis consectetur nam pariatur temporibus ex. Ad corrupti rerum necessitatibus. Quia explicabo modi dolorum aut. Voluptates est consequatur repellat tempora maiores molestias.", new DateTime(2023, 7, 10, 19, 56, 32, 725, DateTimeKind.Unspecified).AddTicks(2294), 36L },
                    { 164L, 156L, "Quia est praesentium fugit odit id.\nQui qui quas.", new DateTime(2023, 8, 15, 22, 49, 3, 228, DateTimeKind.Unspecified).AddTicks(225), "Sed iure illum tenetur consectetur illum commodi quia quibusdam.", new DateTime(2023, 8, 20, 23, 44, 20, 196, DateTimeKind.Unspecified).AddTicks(5573), 23L },
                    { 165L, 199L, "Facere voluptas eius at at quibusdam. Voluptas molestias alias illum fugiat. Modi dolores itaque sit. Corrupti sit vel sit et ullam. Dolorum placeat rerum dolores iusto voluptas qui iste quasi.", new DateTime(2022, 10, 29, 6, 16, 17, 592, DateTimeKind.Unspecified).AddTicks(1574), "Hic ut officia. Amet soluta illum unde autem natus. Veniam voluptatem dolores a molestiae. Similique quam eos et voluptatem incidunt. Molestiae enim architecto.", new DateTime(2022, 12, 18, 14, 14, 15, 886, DateTimeKind.Unspecified).AddTicks(6729), 10L },
                    { 166L, 191L, "Sed eveniet sunt et. Dicta facere qui veritatis in distinctio rem itaque. Qui inventore et voluptate debitis voluptatem molestiae eaque ut. Repudiandae est in. Aut reprehenderit tenetur non sequi voluptatem voluptas. Non earum est est dolorem similique dolorem.", new DateTime(2023, 8, 22, 4, 56, 26, 951, DateTimeKind.Unspecified).AddTicks(8988), "Dolores et mollitia eius libero maiores debitis quisquam corporis.\nEx unde quo.\nMolestias sed aliquid.\nDignissimos magni voluptatem tempore delectus accusamus consequuntur iste.\nAut voluptatibus ea officiis necessitatibus aliquam fugit rem.", new DateTime(2023, 8, 23, 1, 7, 20, 49, DateTimeKind.Unspecified).AddTicks(2339), 6L },
                    { 167L, 5L, "Voluptas ipsum vel incidunt qui ut delectus numquam dolores quia.\nDeleniti laudantium totam qui sunt fugit ut omnis.\nRerum sed totam nostrum mollitia sunt commodi dolore.\nTenetur rem atque rerum quo velit.", new DateTime(2023, 4, 29, 13, 56, 23, 121, DateTimeKind.Unspecified).AddTicks(7846), "Voluptates quo sit qui vel.\nDolorum quidem aut cum tempora autem id fuga.\nOptio perferendis natus cumque sunt quidem nesciunt ut porro.\nPerspiciatis id voluptatem mollitia placeat enim doloremque nisi.\nIusto itaque quisquam aut dolorem temporibus libero a natus.", new DateTime(2023, 6, 8, 18, 27, 25, 827, DateTimeKind.Unspecified).AddTicks(8315), 28L },
                    { 168L, 32L, "Rerum repellat expedita est facere itaque corporis qui.\nEarum rem eaque quaerat ea adipisci qui vel amet.", new DateTime(2023, 8, 11, 11, 16, 25, 585, DateTimeKind.Unspecified).AddTicks(5486), "Minus repudiandae quam cum. Non eligendi architecto adipisci necessitatibus perspiciatis voluptate. Et aperiam nobis. Nobis repellat quam. Doloribus nulla velit et corporis veniam. Modi provident distinctio tempore numquam quos et vitae labore.", new DateTime(2023, 8, 18, 16, 40, 50, 969, DateTimeKind.Unspecified).AddTicks(2867), 1L },
                    { 169L, 112L, "Harum non omnis neque voluptas impedit quas itaque iste quibusdam.\nQuasi eius possimus exercitationem molestiae accusamus pariatur distinctio.", new DateTime(2023, 7, 3, 6, 17, 29, 979, DateTimeKind.Unspecified).AddTicks(6252), "officiis", new DateTime(2023, 8, 20, 22, 49, 55, 230, DateTimeKind.Unspecified).AddTicks(2285), 8L },
                    { 170L, 32L, "non", new DateTime(2023, 8, 11, 17, 59, 28, 409, DateTimeKind.Unspecified).AddTicks(2586), "Sunt ut temporibus enim nostrum sunt molestias nam praesentium.", new DateTime(2023, 8, 19, 10, 0, 40, 633, DateTimeKind.Unspecified).AddTicks(8810), 33L },
                    { 171L, 160L, "aut", new DateTime(2023, 6, 11, 14, 18, 8, 229, DateTimeKind.Unspecified).AddTicks(1983), "aliquam", new DateTime(2023, 7, 15, 23, 59, 37, 144, DateTimeKind.Unspecified).AddTicks(1366), 35L },
                    { 172L, 193L, "Est illo non ipsam et aut. Quod impedit qui minima rerum laudantium sed quam. Iure quo quasi eos.", new DateTime(2023, 2, 5, 11, 51, 19, 561, DateTimeKind.Unspecified).AddTicks(6439), "Earum molestiae quo libero rem architecto et.\nDelectus eius pariatur dignissimos blanditiis.\nQui non amet et sint maiores.\nQui quasi temporibus distinctio vel sed dicta qui facere.\nEt dolor corrupti ut necessitatibus omnis corporis consectetur libero sunt.\nIpsam qui laborum.", new DateTime(2023, 3, 26, 7, 40, 0, 961, DateTimeKind.Unspecified).AddTicks(1582), 31L },
                    { 173L, 83L, "Aut quibusdam non ea quae consequatur explicabo. Provident tempora non corporis rerum distinctio delectus. Aliquam et aut debitis.", new DateTime(2023, 7, 28, 16, 19, 5, 161, DateTimeKind.Unspecified).AddTicks(4596), "saepe", new DateTime(2023, 8, 2, 4, 36, 27, 924, DateTimeKind.Unspecified).AddTicks(3180), 30L },
                    { 174L, 22L, "Quo sint accusamus voluptas quis ut eligendi illo non.", new DateTime(2023, 6, 27, 18, 36, 2, 913, DateTimeKind.Unspecified).AddTicks(1251), "Magni iste et.\nNihil libero aspernatur.\nNatus doloribus adipisci consequatur adipisci consequatur doloribus veritatis quibusdam perferendis.", new DateTime(2023, 8, 9, 4, 36, 29, 579, DateTimeKind.Unspecified).AddTicks(5201), 35L },
                    { 175L, 3L, "Expedita omnis ad magni est cumque.\nDolor fugit suscipit itaque enim sint molestias.\nEsse tempora pariatur voluptatem eos est sint voluptates harum.", new DateTime(2022, 8, 23, 10, 41, 48, 910, DateTimeKind.Unspecified).AddTicks(6763), "Vero consectetur quam eum eos sunt omnis.", new DateTime(2023, 5, 14, 10, 41, 22, 752, DateTimeKind.Unspecified).AddTicks(764), 39L },
                    { 176L, 53L, "Nihil esse aliquam et quia corrupti.", new DateTime(2023, 3, 1, 11, 23, 26, 761, DateTimeKind.Unspecified).AddTicks(4485), "commodi", new DateTime(2023, 7, 27, 9, 31, 12, 793, DateTimeKind.Unspecified).AddTicks(5008), 13L },
                    { 177L, 134L, "Id pariatur facilis officiis non voluptas reprehenderit commodi minus.", new DateTime(2023, 3, 19, 7, 21, 23, 544, DateTimeKind.Unspecified).AddTicks(7042), "Unde a dolores praesentium eligendi et qui qui odio.", new DateTime(2023, 6, 7, 2, 12, 49, 170, DateTimeKind.Unspecified).AddTicks(4626), 10L },
                    { 178L, 16L, "Rerum sequi eos sit optio minima.", new DateTime(2023, 6, 16, 22, 9, 50, 12, DateTimeKind.Unspecified).AddTicks(1292), "enim", new DateTime(2023, 6, 20, 14, 57, 0, 823, DateTimeKind.Unspecified).AddTicks(5431), 20L }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "Output", "SubmittedAt", "UserId" },
                values: new object[,]
                {
                    { 179L, 70L, "ab", new DateTime(2021, 12, 15, 11, 37, 44, 321, DateTimeKind.Unspecified).AddTicks(3637), "Itaque eos accusamus voluptas similique.\nVoluptatem similique ipsa culpa architecto deserunt dolores aut.", new DateTime(2022, 4, 21, 18, 45, 37, 176, DateTimeKind.Unspecified).AddTicks(4668), 32L },
                    { 180L, 91L, "Enim consequatur modi ut.", new DateTime(2022, 9, 1, 8, 34, 21, 592, DateTimeKind.Unspecified).AddTicks(2905), "Dolorem velit sit qui beatae incidunt fugiat.\nEt ipsa officia qui facere.\nLabore error velit ut.", new DateTime(2022, 12, 19, 18, 26, 28, 536, DateTimeKind.Unspecified).AddTicks(8466), 38L },
                    { 181L, 197L, "Consequuntur libero voluptas facilis officiis tenetur rem minus. Harum in non excepturi ut ut. Quisquam praesentium et qui cumque voluptatem doloremque. Voluptatem quasi libero quibusdam. Eos rerum suscipit dolores ea.", new DateTime(2022, 12, 3, 17, 56, 54, 613, DateTimeKind.Unspecified).AddTicks(9316), "dolorem", new DateTime(2023, 5, 19, 8, 35, 57, 562, DateTimeKind.Unspecified).AddTicks(6263), 39L },
                    { 182L, 128L, "qui", new DateTime(2022, 9, 7, 2, 59, 34, 833, DateTimeKind.Unspecified).AddTicks(9176), "Iure ipsa sit facere officia.\nTempora et voluptatem.", new DateTime(2023, 4, 12, 4, 54, 25, 313, DateTimeKind.Unspecified).AddTicks(9837), 5L },
                    { 183L, 68L, "Totam ut placeat veritatis et sequi quibusdam aut.", new DateTime(2023, 4, 13, 22, 52, 29, 624, DateTimeKind.Unspecified).AddTicks(3719), "Maiores illo soluta exercitationem nihil.\nFacere soluta et.\nExcepturi ad illum aut sunt laboriosam alias.\nOfficiis commodi quis aliquid repellat omnis amet.\nAut quo ut et vitae adipisci pariatur omnis et.", new DateTime(2023, 5, 11, 19, 2, 8, 206, DateTimeKind.Unspecified).AddTicks(582), 35L },
                    { 184L, 200L, "Inventore a ut non tenetur eos vel quibusdam. Nobis autem sint harum illo magni odit. Voluptatibus repudiandae ducimus eum non ipsam nihil.", new DateTime(2023, 5, 17, 19, 1, 4, 660, DateTimeKind.Unspecified).AddTicks(9505), "accusamus", new DateTime(2023, 6, 17, 22, 50, 46, 947, DateTimeKind.Unspecified).AddTicks(1184), 29L },
                    { 185L, 90L, "Eligendi earum mollitia et non.", new DateTime(2023, 8, 21, 5, 25, 9, 16, DateTimeKind.Unspecified).AddTicks(2928), "reiciendis", new DateTime(2023, 8, 22, 7, 45, 3, 714, DateTimeKind.Unspecified).AddTicks(2690), 17L },
                    { 186L, 119L, "Non nihil est sit a tempore enim non rerum. Necessitatibus dicta nesciunt illum id magnam vel aut nam. Fugit sed sit harum fugiat recusandae accusantium itaque perferendis aut. Sit quaerat saepe temporibus atque tempore at ut culpa nihil. Tenetur vitae ipsa veritatis qui id.", new DateTime(2023, 7, 31, 17, 26, 15, 460, DateTimeKind.Unspecified).AddTicks(7387), "Deserunt adipisci libero optio cum cupiditate perferendis sit. Est suscipit excepturi. Necessitatibus impedit dolorem voluptatem doloremque quia culpa a laboriosam. Sint nihil culpa.", new DateTime(2023, 8, 3, 7, 29, 47, 604, DateTimeKind.Unspecified).AddTicks(1388), 5L },
                    { 187L, 119L, "facere", new DateTime(2023, 6, 4, 13, 3, 57, 114, DateTimeKind.Unspecified).AddTicks(6986), "ex", new DateTime(2023, 6, 13, 11, 1, 21, 573, DateTimeKind.Unspecified).AddTicks(9033), 40L },
                    { 188L, 33L, "Recusandae sunt eveniet sed adipisci sit ut.\nIn quisquam nobis quod aliquam odit sequi.\nExplicabo quam quam velit et tempora labore omnis qui provident.\nUt et sint neque et quis dolorem sequi.\nConsequatur laudantium voluptates quaerat sed iste.", new DateTime(2022, 11, 23, 10, 8, 10, 531, DateTimeKind.Unspecified).AddTicks(1818), "Commodi aut debitis. Quia sit ut ut quaerat laborum. Pariatur dolores iure distinctio laborum repellat quos distinctio. Voluptas blanditiis molestiae tenetur est sit harum.", new DateTime(2023, 2, 26, 22, 37, 37, 823, DateTimeKind.Unspecified).AddTicks(7940), 21L },
                    { 189L, 129L, "Molestiae voluptas quibusdam eos ut. Nobis accusantium numquam dignissimos in tempore architecto. Est sed et amet. Corporis et tempore et quo voluptatem eum accusantium architecto. Quaerat voluptas maiores odio voluptatem ut.", new DateTime(2023, 8, 15, 9, 7, 3, 22, DateTimeKind.Unspecified).AddTicks(8289), "Possimus itaque beatae et numquam excepturi ratione excepturi. Ut excepturi laboriosam veniam consectetur quae reprehenderit. Facere sint dicta voluptas sint deserunt.", new DateTime(2023, 8, 16, 7, 33, 34, 37, DateTimeKind.Unspecified).AddTicks(3220), 25L },
                    { 190L, 88L, "illo", new DateTime(2020, 7, 14, 23, 45, 16, 540, DateTimeKind.Unspecified).AddTicks(8926), "debitis", new DateTime(2023, 4, 8, 10, 23, 38, 732, DateTimeKind.Unspecified).AddTicks(8090), 14L },
                    { 191L, 188L, "Velit error excepturi dolorem omnis natus.", new DateTime(2023, 4, 23, 19, 43, 33, 499, DateTimeKind.Unspecified).AddTicks(1034), "reiciendis", new DateTime(2023, 7, 1, 1, 15, 59, 517, DateTimeKind.Unspecified).AddTicks(563), 6L },
                    { 192L, 6L, "Labore nisi totam temporibus voluptatem reprehenderit iste minima quas. Harum alias nulla voluptas dolorem. Maiores exercitationem quas occaecati.", new DateTime(2023, 5, 28, 17, 27, 41, 330, DateTimeKind.Unspecified).AddTicks(9026), "Fugiat ab mollitia aut voluptatibus et amet quos.", new DateTime(2023, 7, 23, 19, 32, 11, 489, DateTimeKind.Unspecified).AddTicks(3931), 22L },
                    { 193L, 62L, "Adipisci sit aut incidunt quia quas molestiae quae.\nQuis est debitis in.\nNisi deserunt praesentium omnis.\nEsse adipisci nostrum velit ut explicabo aut.\nId dolor velit in harum velit ullam aut.", new DateTime(2023, 6, 19, 21, 3, 58, 983, DateTimeKind.Unspecified).AddTicks(1401), "Explicabo commodi voluptas consequuntur omnis nulla est.", new DateTime(2023, 7, 12, 6, 52, 44, 59, DateTimeKind.Unspecified).AddTicks(3361), 36L },
                    { 194L, 37L, "Accusantium nisi quos et est odit eos ipsam.\nVoluptatem voluptatem recusandae quibusdam eos totam minima vitae vero.", new DateTime(2022, 11, 28, 21, 51, 32, 904, DateTimeKind.Unspecified).AddTicks(1377), "consequatur", new DateTime(2023, 5, 19, 17, 14, 4, 104, DateTimeKind.Unspecified).AddTicks(395), 8L },
                    { 195L, 45L, "Explicabo autem et voluptatem perferendis itaque est quasi aut. Debitis ea tenetur ab. Aut quis repudiandae vel quod voluptas quidem.", new DateTime(2023, 6, 10, 5, 10, 40, 659, DateTimeKind.Unspecified).AddTicks(5892), "Unde illum qui nulla illo pariatur praesentium aut dicta.", new DateTime(2023, 7, 9, 22, 13, 12, 334, DateTimeKind.Unspecified).AddTicks(6141), 15L },
                    { 196L, 82L, "In voluptatum rerum reiciendis cum velit dolores. Atque ex provident maiores minima rerum blanditiis aut. Id adipisci atque. Sit tenetur quod architecto voluptatem animi dolorem eos ea. Asperiores tenetur non dignissimos. Vel pariatur officiis voluptate.", new DateTime(2023, 7, 23, 5, 31, 25, 33, DateTimeKind.Unspecified).AddTicks(2806), "Similique dolores molestiae illum.", new DateTime(2023, 8, 1, 12, 19, 26, 169, DateTimeKind.Unspecified).AddTicks(9595), 33L },
                    { 197L, 89L, "Assumenda vel occaecati ratione et.\nConsequatur enim et vitae sit.\nAperiam et quas nostrum qui et minus.\nDolorem iste ducimus praesentium vel aliquam molestias adipisci inventore.\nAspernatur nam enim culpa odio veritatis facilis ut earum.", new DateTime(2023, 7, 29, 22, 59, 31, 563, DateTimeKind.Unspecified).AddTicks(9952), "Impedit corrupti enim.\nRepellendus quod ut voluptatum similique veritatis.\nItaque quia numquam recusandae veritatis sit et pariatur laborum.\nDistinctio maiores occaecati enim qui.", new DateTime(2023, 8, 11, 1, 8, 50, 209, DateTimeKind.Unspecified).AddTicks(3134), 26L },
                    { 198L, 30L, "amet", new DateTime(2022, 12, 8, 2, 48, 24, 303, DateTimeKind.Unspecified).AddTicks(4339), "nulla", new DateTime(2023, 4, 8, 3, 57, 4, 427, DateTimeKind.Unspecified).AddTicks(6429), 39L },
                    { 199L, 152L, "Enim aperiam rerum sit autem tempora consequuntur.", new DateTime(2022, 3, 31, 12, 34, 6, 501, DateTimeKind.Unspecified).AddTicks(2625), "Libero maiores possimus ab quas.\nFugit sit fugit praesentium dolorem architecto omnis error facere.\nConsequatur aut repudiandae.\nSit vitae quia libero iure hic harum itaque beatae in.\nEt deserunt perferendis unde sed.\nQuibusdam blanditiis ex enim dolores est.", new DateTime(2022, 8, 17, 10, 8, 41, 783, DateTimeKind.Unspecified).AddTicks(2450), 34L },
                    { 200L, 183L, "Sequi libero alias odit officia distinctio dicta distinctio omnis.\nDolor aliquam porro qui.\nDeleniti placeat perferendis omnis rerum sunt sint iste deserunt.", new DateTime(2022, 12, 19, 22, 15, 22, 229, DateTimeKind.Unspecified).AddTicks(7242), "et", new DateTime(2023, 6, 5, 3, 29, 45, 118, DateTimeKind.Unspecified).AddTicks(190), 20L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Challenges_AuthorId",
                table: "Challenges",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Challenges_LevelId",
                table: "Challenges",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_ChallengeTag_TagsId",
                table: "ChallengeTag",
                column: "TagsId");

            migrationBuilder.CreateIndex(
                name: "IX_ChallengeVersionLanguageVersion_LanguageVersionId",
                table: "ChallengeVersionLanguageVersion",
                column: "LanguageVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_ChallengeVersions_ChallengeId",
                table: "ChallengeVersions",
                column: "ChallengeId");

            migrationBuilder.CreateIndex(
                name: "IX_ChallengeVersions_LanguageId",
                table: "ChallengeVersions",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageVersions_LanguageId",
                table: "LanguageVersions",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_PreferredLanguages_UsersId",
                table: "PreferredLanguages",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_TypeId",
                table: "Subscriptions",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_UserId",
                table: "Subscriptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_ChallengeVersionId",
                table: "Tests",
                column: "ChallengeVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLanguageLevels_LanguageId",
                table: "UserLanguageLevels",
                column: "LanguageId");

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
                name: "IX_UserSolutions_UserId",
                table: "UserSolutions",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChallengeTag");

            migrationBuilder.DropTable(
                name: "ChallengeVersionLanguageVersion");

            migrationBuilder.DropTable(
                name: "PreferredLanguages");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "UserLanguageLevels");

            migrationBuilder.DropTable(
                name: "UserSolutions");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "LanguageVersions");

            migrationBuilder.DropTable(
                name: "SubscriptionTypes");

            migrationBuilder.DropTable(
                name: "ChallengeVersions");

            migrationBuilder.DropTable(
                name: "Challenges");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "ChallengeLevels");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
