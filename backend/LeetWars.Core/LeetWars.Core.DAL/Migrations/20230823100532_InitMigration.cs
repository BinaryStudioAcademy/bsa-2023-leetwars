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
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Instructions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LevelId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true)
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
                        name: "FK_Challenges_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id");
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true)
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Tests_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id");
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
                    { 1L, new DateTime(1993, 2, 24, 9, 18, 32, 656, DateTimeKind.Unspecified).AddTicks(2617), 26, "Josue41@hotmail.com", "Grayson", "/wymtrpbcdupodqfwhkxtmnyngfjrqv.jpg", false, true, "Tremblay", "j5xii6spbrvfvasc6b42i4qkxc0xih8e", new DateTime(2016, 9, 22, 8, 48, 24, 869, DateTimeKind.Unspecified).AddTicks(9076), 1, 0, -1, 60915L, "Emmalee_West0" },
                    { 2L, new DateTime(1988, 2, 12, 22, 44, 58, 841, DateTimeKind.Unspecified).AddTicks(3506), 25, "Mitchel4@yahoo.com", "Kristopher", "/ooilkjpddwfvomzpbjspeczybqrwsj.jpg", false, true, "Blanda", "7mg6vwys190zw8d8ke20ld5fvglddroq", new DateTime(2020, 11, 15, 8, 55, 59, 269, DateTimeKind.Unspecified).AddTicks(771), 3, 2, 2, 34838L, "Blake631" },
                    { 3L, new DateTime(1991, 9, 27, 20, 32, 48, 50, DateTimeKind.Unspecified).AddTicks(2864), 7, "Kay29@hotmail.com", "Deja", "/uruwlaikhplhphodpuwfuzkjbswrhw.jpg", false, false, "Haley", "tjpdyqzs4d07s1t1uan24qztisafsq5n", new DateTime(2016, 12, 8, 9, 41, 46, 455, DateTimeKind.Unspecified).AddTicks(6775), 1, 3, 10, 23246L, "Jacquelyn182" },
                    { 4L, new DateTime(1993, 1, 5, 19, 57, 27, 174, DateTimeKind.Unspecified).AddTicks(9656), 28, "Kara_Ankunding3@yahoo.com", "Rachel", "/ftbpxwdlozkfjcjhymqzvyibmqypyw.jpg", false, true, "Pagac", "swlmxpoand6djta9thu2lj8l69e03awj", new DateTime(2020, 7, 12, 4, 27, 34, 278, DateTimeKind.Unspecified).AddTicks(2087), 2, 0, 0, 76727L, "Jayda.Doyle3" },
                    { 5L, new DateTime(1980, 9, 23, 6, 52, 56, 292, DateTimeKind.Unspecified).AddTicks(167), 22, "Orval.Erdman74@yahoo.com", "Loma", "/xhgrzkqhrfjmqxwpuqbifmzszvswxf.jpg", false, true, "Schultz", "vhfskfyumcicwffr5ljwzkq4jfaio5ps", new DateTime(2020, 11, 1, 4, 30, 30, 601, DateTimeKind.Unspecified).AddTicks(7269), 1, 1, 10, 82585L, "Deangelo.Sch4" },
                    { 6L, new DateTime(1981, 3, 5, 1, 59, 53, 769, DateTimeKind.Unspecified).AddTicks(7548), 23, "Damon33@gmail.com", "Vernice", "/zghthgddlemqszlbosihchaoaiswsg.jpg", false, true, "Armstrong", "gikge714qk6b6sj23v3hqhbu8p7rqzk9", new DateTime(2016, 3, 20, 16, 34, 27, 487, DateTimeKind.Unspecified).AddTicks(4387), 0, 2, 12, 28021L, "Merlin_Schul5" },
                    { 7L, new DateTime(1988, 10, 5, 3, 59, 54, 595, DateTimeKind.Unspecified).AddTicks(4360), 32, "Ursula_Ferry23@gmail.com", "Helene", "/nyetfrahktaxxzcpauiwmimoslqztu.jpg", false, true, "Abbott", "qqh5orrb2v8q09r7w35exfiwr7gm0s20", new DateTime(2022, 3, 7, 14, 33, 1, 743, DateTimeKind.Unspecified).AddTicks(3676), 2, 3, -6, 73975L, "Norwood.Buck6" },
                    { 8L, new DateTime(1985, 9, 28, 21, 8, 34, 884, DateTimeKind.Unspecified).AddTicks(7502), 3, "Jordyn_Lindgren@hotmail.com", "Maybell", "/iwigpkmhdhhvffkgmuduvpfrchbxfv.jpg", false, true, "Roberts", "h8j77ro0ucs1neglfjvyapdp0qmm5bcl", new DateTime(2020, 6, 5, 13, 20, 39, 409, DateTimeKind.Unspecified).AddTicks(9338), 1, 3, -12, 652L, "Henriette.Ni7" },
                    { 9L, new DateTime(1983, 10, 27, 19, 37, 38, 966, DateTimeKind.Unspecified).AddTicks(8052), 20, "Jaunita.Spencer@gmail.com", "Janie", "/gnuwvemdbwnafziplilofkvtpsguuk.jpg", false, true, "Wilkinson", "ogtjst16gthiilfsssm8s5eytvo094yp", new DateTime(2020, 4, 7, 3, 48, 17, 51, DateTimeKind.Unspecified).AddTicks(223), 2, 0, -11, 66960L, "Providenci_A8" },
                    { 10L, new DateTime(1987, 9, 8, 2, 6, 58, 381, DateTimeKind.Unspecified).AddTicks(1715), 40, "Patricia.Walker@yahoo.com", "Donald", "/oqnbwsydaxiwuewkjpdqcrngvxdzlr.jpg", false, false, "Torphy", "h6iks1o0by8djdjq9j0uz6st1v398ylx", new DateTime(2021, 7, 21, 14, 3, 26, 353, DateTimeKind.Unspecified).AddTicks(4086), 1, 1, -9, 21532L, "Leanne_Bedna9" },
                    { 11L, new DateTime(1986, 10, 30, 13, 4, 23, 299, DateTimeKind.Unspecified).AddTicks(430), 57, "Asa_Nicolas@hotmail.com", "Eunice", "/priksnyykujihsezkjbefcqwqlhszo.jpg", false, true, "Greenholt", "5b0y2o3roofvbkxu20z6aqkfri1fr987", new DateTime(2022, 8, 7, 19, 54, 41, 241, DateTimeKind.Unspecified).AddTicks(6042), 3, 2, -11, 33445L, "Chandler.Hom10" },
                    { 12L, new DateTime(1990, 5, 6, 18, 6, 2, 959, DateTimeKind.Unspecified).AddTicks(5583), 50, "Verda.Schinner@gmail.com", "Madilyn", "/tugltpfoqrzklfxmywntjmhqafslsy.jpg", false, true, "Pollich", "gywyh6k7aq42u6naxifb52alw8hmejvr", new DateTime(2022, 11, 24, 18, 56, 8, 856, DateTimeKind.Unspecified).AddTicks(6082), 2, 0, -12, 50225L, "Gavin_Reinge11" },
                    { 13L, new DateTime(1990, 5, 3, 11, 10, 44, 617, DateTimeKind.Unspecified).AddTicks(9801), 37, "Willard18@gmail.com", "Mohamed", "/zkukribgryvtwjfdzqulusklmnzppj.jpg", false, true, "McClure", "nm9prgxtd6gh1ywtx83i5cyueazcw5bg", new DateTime(2017, 7, 15, 19, 6, 43, 661, DateTimeKind.Unspecified).AddTicks(836), 1, 1, -8, 15042L, "Ole6512" },
                    { 14L, new DateTime(1993, 5, 20, 23, 4, 4, 892, DateTimeKind.Unspecified).AddTicks(7492), 48, "Jovany_Pacocha@yahoo.com", "Celestine", "/mbfhrkhmloxfwzwtqtiuqiizcjwcqo.jpg", true, true, "Gibson", "t8kkzk20i2u5bm92rzgxssct55q96bj7", new DateTime(2021, 1, 5, 20, 39, 40, 929, DateTimeKind.Unspecified).AddTicks(371), 3, 2, 4, 28772L, "Leopold6513" },
                    { 15L, new DateTime(1989, 5, 9, 11, 50, 28, 465, DateTimeKind.Unspecified).AddTicks(1597), 40, "Maxwell_Bauch@hotmail.com", "Lonny", "/qstbwtlvvvvenqikwpkmzegeocxrdb.jpg", false, true, "Feeney", "k5qnk35pswu6gus1qa5mt3m4xggkhsur", new DateTime(2017, 10, 31, 12, 42, 22, 281, DateTimeKind.Unspecified).AddTicks(4973), 3, 1, 5, 87680L, "Deonte.Waelc14" },
                    { 16L, new DateTime(1997, 11, 14, 20, 7, 26, 876, DateTimeKind.Unspecified).AddTicks(4806), 37, "Joanne_Hilll@yahoo.com", "Chloe", "/nglnpscrpfzbcnspdpwfyjqhcndtaf.jpg", false, true, "Schowalter", "zf785is5u5zjnytgi90u9wifk5m5f3kc", new DateTime(2021, 12, 3, 17, 26, 53, 833, DateTimeKind.Unspecified).AddTicks(8237), 1, 0, 2, 86138L, "Juanita_Mona15" },
                    { 17L, new DateTime(1993, 9, 6, 15, 13, 11, 647, DateTimeKind.Unspecified).AddTicks(3510), 34, "Jaylan88@yahoo.com", "Vince", "/teycxuraxqstoqygsgpqxvbhdvfely.jpg", true, true, "Russel", "os3plgg5o27c94814kghx80czw3ny3kh", new DateTime(2022, 2, 15, 8, 37, 55, 610, DateTimeKind.Unspecified).AddTicks(26), 3, 3, 11, 86419L, "Maybell_DuBu16" },
                    { 18L, new DateTime(1993, 2, 5, 1, 11, 38, 546, DateTimeKind.Unspecified).AddTicks(688), 10, "Amber_Botsford72@hotmail.com", "Kendall", "/yalusssjufpnsuieijhnzrjrmxliep.jpg", false, true, "Marks", "vewqmyi5x5b40dz0qr8rqpe5q9mratae", new DateTime(2021, 1, 8, 16, 42, 33, 864, DateTimeKind.Unspecified).AddTicks(828), 0, 1, -8, 98054L, "Kamille_Kirl17" },
                    { 19L, new DateTime(1992, 8, 30, 14, 11, 30, 71, DateTimeKind.Unspecified).AddTicks(9329), 40, "Jadon.Dibbert40@hotmail.com", "Carli", "/wdatzjitwcwyyvavktqwcpghyxppcv.jpg", false, false, "Koch", "mmbsb65vzr1waca9wtzu2f17aawqs3rp", new DateTime(2021, 2, 7, 15, 11, 3, 485, DateTimeKind.Unspecified).AddTicks(3790), 0, 1, -7, 17124L, "Breanne_Dool18" },
                    { 20L, new DateTime(1980, 3, 2, 13, 30, 17, 557, DateTimeKind.Unspecified).AddTicks(4008), 18, "Zion_Osinski62@hotmail.com", "Joyce", "/fueodmahlcwaifgxbrthdenrfjczzt.jpg", false, false, "Rowe", "43z3g99nhpij8fvuhz10y09hg18idrd1", new DateTime(2020, 9, 7, 23, 29, 40, 166, DateTimeKind.Unspecified).AddTicks(9946), 2, 3, 7, 24724L, "Rosalind2919" },
                    { 21L, new DateTime(1980, 10, 16, 19, 14, 19, 862, DateTimeKind.Unspecified).AddTicks(216), 52, "Rachelle.Hickle94@gmail.com", "Gordon", "/zudvnqlathsimfomcvggbkoufswcds.jpg", false, true, "Dietrich", "0w92cwtxhmbyu4hpaeelpjmvwk8bmtrc", new DateTime(2021, 1, 19, 3, 11, 54, 313, DateTimeKind.Unspecified).AddTicks(6427), 0, 1, 8, 40527L, "Alfred_Saway20" },
                    { 22L, new DateTime(1985, 1, 13, 10, 52, 46, 135, DateTimeKind.Unspecified).AddTicks(4769), 43, "Emmy.Lakin@yahoo.com", "Cayla", "/rozmgketrnirwzbuvrrxnuyneayuau.jpg", false, true, "Heaney", "04fbnc2sjm74y5uorx0slntixwlga9ge", new DateTime(2021, 5, 15, 5, 40, 52, 590, DateTimeKind.Unspecified).AddTicks(2726), 3, 2, -7, 53546L, "Liliane5521" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Country", "Email", "FirstName", "ImagePath", "IsBanned", "IsSubscribed", "LastName", "OAuthToken", "RegisteredAt", "Sex", "Status", "Timezone", "TotalScore", "UserName" },
                values: new object[,]
                {
                    { 23L, new DateTime(1985, 8, 1, 11, 42, 11, 968, DateTimeKind.Unspecified).AddTicks(9187), 38, "Marion1@hotmail.com", "Amber", "/tgfihyjttpnhevkcqqlgqhbootvocv.jpg", false, false, "Brown", "rr0gmho5wb5kz3jtwuzq4130eh6osi3t", new DateTime(2019, 3, 2, 18, 39, 23, 513, DateTimeKind.Unspecified).AddTicks(9586), 3, 3, 6, 71204L, "Andre_Pacoch22" },
                    { 24L, new DateTime(1981, 12, 15, 1, 48, 9, 700, DateTimeKind.Unspecified).AddTicks(1476), 8, "Aaliyah_Rempel56@hotmail.com", "Jazmyn", "/jrtrabdizjkfixbguoeqciqhzyieer.jpg", false, true, "Robel", "2n49a9328n2le4cwq59q76ocg10gp3pz", new DateTime(2017, 3, 21, 18, 51, 55, 729, DateTimeKind.Unspecified).AddTicks(468), 1, 1, 6, 7810L, "Bobbie3023" },
                    { 25L, new DateTime(1985, 11, 24, 0, 20, 19, 826, DateTimeKind.Unspecified).AddTicks(4962), 4, "Tobin17@yahoo.com", "Mozelle", "/xlmxzuuggqieyblcvqvrompmwetzem.jpg", false, true, "Haag", "jnvj2oveqbadjje5li2tqa8jmgvz0t0t", new DateTime(2017, 9, 6, 12, 3, 2, 623, DateTimeKind.Unspecified).AddTicks(8683), 3, 0, 4, 38713L, "Juliet_McClu24" },
                    { 26L, new DateTime(1993, 11, 24, 21, 15, 2, 804, DateTimeKind.Unspecified).AddTicks(8752), 5, "Armand.Rempel@gmail.com", "Grayson", "/xitgliyqvwkyhlhulswfnhpiktelnv.jpg", false, true, "Torp", "wa9rxq0u8xgdxc0y6wv4ldvcqlqfto5h", new DateTime(2021, 12, 7, 2, 1, 28, 712, DateTimeKind.Unspecified).AddTicks(5513), 0, 3, -10, 54533L, "Jess9125" },
                    { 27L, new DateTime(1988, 10, 31, 8, 24, 19, 549, DateTimeKind.Unspecified).AddTicks(3428), 5, "Emilia.Kling@gmail.com", "Kristian", "/okfolxaizpaouzgxkxhqjijaxypofn.jpg", false, true, "Konopelski", "3d5wxosenri7j6jw5rwgue5wv726nhag", new DateTime(2016, 12, 2, 17, 13, 42, 605, DateTimeKind.Unspecified).AddTicks(3216), 1, 1, 4, 87203L, "Thad3726" },
                    { 28L, new DateTime(1980, 6, 15, 22, 55, 6, 657, DateTimeKind.Unspecified).AddTicks(6478), 43, "Javon_Ziemann68@gmail.com", "Wayne", "/uqsfgasqptelbcbswmhriiwdpuslxs.jpg", false, true, "Funk", "nofrburg6udyi72222qflij5dfrklgaa", new DateTime(2023, 3, 31, 9, 43, 0, 30, DateTimeKind.Unspecified).AddTicks(6459), 3, 0, 0, 30201L, "Kariane7927" },
                    { 29L, new DateTime(1999, 3, 13, 16, 23, 36, 572, DateTimeKind.Unspecified).AddTicks(126), 0, "Arely_Lehner68@hotmail.com", "Herta", "/lcddhkwcfwsocfpcobtgomefcvaqcm.jpg", false, false, "Gutkowski", "2rnlaszcqww3qklv858ligye5yxx1fd9", new DateTime(2016, 10, 24, 22, 12, 4, 16, DateTimeKind.Unspecified).AddTicks(3775), 2, 3, 12, 49377L, "Haylie_Hane28" },
                    { 30L, new DateTime(1990, 2, 22, 7, 30, 2, 825, DateTimeKind.Unspecified).AddTicks(3845), 6, "Linnie_Friesen@yahoo.com", "Dagmar", "/kmzpugliwbhinqcauqytflmhecbsfi.jpg", false, true, "Hahn", "astjvjq65n1mx2wzbpcqs0aumy0ogp7q", new DateTime(2018, 1, 22, 22, 37, 35, 615, DateTimeKind.Unspecified).AddTicks(728), 2, 2, 0, 99608L, "Rosetta_Herm29" },
                    { 31L, new DateTime(1992, 7, 5, 16, 55, 47, 144, DateTimeKind.Unspecified).AddTicks(6842), 56, "Gayle.Cronin36@yahoo.com", "Lexi", "/mnhmzxxnbtllinkiknixumeoaeamoh.jpg", false, true, "Kohler", "axvdnzg0i3v17v0td324zngfl0crhtwf", new DateTime(2022, 8, 8, 11, 11, 44, 321, DateTimeKind.Unspecified).AddTicks(3997), 3, 1, 1, 95248L, "Earnestine.P30" },
                    { 32L, new DateTime(1989, 6, 11, 1, 21, 54, 551, DateTimeKind.Unspecified).AddTicks(7804), 26, "Clementina.Sanford45@yahoo.com", "Gerhard", "/iqmluqqrnremcllmflgrgpqfkvtbgh.jpg", true, true, "Adams", "1z0ift2568r6ub1jotv1ycnq7q080xvl", new DateTime(2019, 3, 23, 2, 10, 46, 896, DateTimeKind.Unspecified).AddTicks(7093), 1, 2, -8, 57424L, "Daryl.Bailey31" },
                    { 33L, new DateTime(1989, 6, 10, 17, 32, 33, 414, DateTimeKind.Unspecified).AddTicks(6334), 41, "Charlene93@gmail.com", "Anibal", "/efirihhruvdgietprwccugqxcqvdzr.jpg", false, true, "Gaylord", "26syf9xyu59btlx0orc5nbq25ykelph6", new DateTime(2021, 1, 29, 10, 8, 33, 240, DateTimeKind.Unspecified).AddTicks(9047), 0, 3, 12, 38702L, "Ahmad7432" },
                    { 34L, new DateTime(1985, 9, 18, 12, 7, 8, 669, DateTimeKind.Unspecified).AddTicks(692), 7, "Wilford.Bernier77@gmail.com", "Mellie", "/watlsvmrnjercqsvyohawmyiufrool.jpg", false, true, "Zemlak", "iqeeu30jqk9s5cu9rtp60ho1wd2emh4x", new DateTime(2022, 5, 13, 23, 38, 10, 506, DateTimeKind.Unspecified).AddTicks(7851), 0, 3, -2, 67055L, "Uriah.Sipes33" },
                    { 35L, new DateTime(1984, 8, 23, 0, 30, 52, 491, DateTimeKind.Unspecified).AddTicks(9846), 26, "Jerrold_Lehner@yahoo.com", "Heath", "/wjkabjnmapxglirbnkzcbcipryhvam.jpg", false, false, "Sporer", "w3092qnsdw6al8il9fe923jetr1td32n", new DateTime(2019, 1, 31, 2, 28, 29, 737, DateTimeKind.Unspecified).AddTicks(5124), 2, 2, 8, 18771L, "Merle3334" },
                    { 36L, new DateTime(1986, 1, 3, 18, 49, 34, 512, DateTimeKind.Unspecified).AddTicks(6), 7, "Alvera.Prosacco76@gmail.com", "Michaela", "/kvoplirwlgwnwboskbelwjalmcgysi.jpg", false, true, "Beatty", "e67o4v8lqx9jas8evgkenmp0w1s34d2r", new DateTime(2019, 5, 30, 13, 31, 48, 966, DateTimeKind.Unspecified).AddTicks(265), 0, 3, 4, 18001L, "Armando_Veum35" },
                    { 37L, new DateTime(1984, 4, 10, 16, 56, 4, 423, DateTimeKind.Unspecified).AddTicks(4479), 8, "Dangelo79@gmail.com", "Otha", "/jirtmfucbdmjvmleyodsoxywhlupyo.jpg", false, true, "Harris", "v15aesf362etlbayepvwbnyi8hdsg1e6", new DateTime(2021, 10, 18, 19, 4, 8, 468, DateTimeKind.Unspecified).AddTicks(118), 2, 1, -2, 56163L, "Dena736" },
                    { 38L, new DateTime(1987, 7, 10, 12, 45, 18, 739, DateTimeKind.Unspecified).AddTicks(5295), 41, "Eva71@yahoo.com", "Reyes", "/bffcrbxlqqdrfrbbwtvpgdmhxfnesf.jpg", false, true, "Hudson", "40bg2b1bji66469d227lok7igxpy7gjq", new DateTime(2016, 3, 5, 4, 10, 8, 605, DateTimeKind.Unspecified).AddTicks(803), 1, 2, -9, 76635L, "Amie.Greenfe37" },
                    { 39L, new DateTime(1996, 9, 28, 0, 46, 10, 761, DateTimeKind.Unspecified).AddTicks(2751), 12, "Adan44@gmail.com", "Kendrick", "/zdoovuadpccczmmsrdahlmodjwckyk.jpg", false, false, "Emmerich", "ypa2rkuzbkrg5yg4bxlamvhuzhkf6xpm", new DateTime(2022, 8, 15, 10, 17, 30, 196, DateTimeKind.Unspecified).AddTicks(132), 0, 0, -2, 91228L, "Enid038" },
                    { 40L, new DateTime(1986, 5, 3, 0, 9, 9, 628, DateTimeKind.Unspecified).AddTicks(9643), 4, "Dejuan78@hotmail.com", "Mathilde", "/qubflcgalujwdgyvbikgskybaizeyt.jpg", false, true, "Shields", "xejtjf26ctgvfvgmeqetmx4x38t17433", new DateTime(2021, 10, 14, 6, 3, 6, 252, DateTimeKind.Unspecified).AddTicks(8564), 2, 3, 12, 31229L, "Jaqueline.Le39" }
                });

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Instructions", "LevelId", "Title" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 1, 20, 20, 9, 30, 302, DateTimeKind.Unspecified).AddTicks(8748), 19L, "Perspiciatis cum et et laudantium.", 1, "We need to input the online SCSI firewall!" },
                    { 2L, new DateTime(2022, 7, 21, 11, 49, 2, 926, DateTimeKind.Unspecified).AddTicks(8755), 17L, "quis", 2, "Use the open-source SMS driver, then you can input" },
                    { 3L, new DateTime(2023, 1, 23, 14, 52, 24, 221, DateTimeKind.Unspecified).AddTicks(6865), 34L, "Aut rerum consectetur veniam distinctio officiis praesentium.\nAperiam quis qui animi omnis.\nMolestiae laboriosam exercitationem similique amet dolores quibusdam aspernatur consequatur quia.\nSuscipit consequuntur eos laborum facilis culpa.", 1, "If we back up the application, we can get to the G" },
                    { 4L, new DateTime(2021, 12, 31, 7, 5, 25, 263, DateTimeKind.Unspecified).AddTicks(3747), 20L, "Suscipit quia modi nobis ad eos voluptatum est.", 2, "Use the haptic JBOD transmitter, then you can hack" },
                    { 5L, new DateTime(2022, 12, 19, 5, 56, 49, 204, DateTimeKind.Unspecified).AddTicks(4426), 33L, "Voluptatem possimus iure impedit enim provident incidunt molestiae earum.", 2, "I'll transmit the wireless USB driver, that should" },
                    { 6L, new DateTime(2023, 8, 15, 16, 33, 38, 704, DateTimeKind.Unspecified).AddTicks(6328), 28L, "Distinctio rerum voluptatem aut iure nesciunt aut eos voluptatem molestias. Molestias reprehenderit tenetur hic. Esse repudiandae voluptatem quae impedit sed voluptates ratione minus in.", 3, "If we parse the feed, we can get to the SSL feed t" },
                    { 7L, new DateTime(2022, 6, 26, 3, 59, 44, 599, DateTimeKind.Unspecified).AddTicks(998), 40L, "Molestiae quis nihil similique autem nemo numquam. Et ut ratione vel. Aperiam harum perferendis ad consequuntur.", 1, "We need to calculate the auxiliary HTTP applicatio" },
                    { 8L, new DateTime(2022, 1, 25, 8, 26, 6, 480, DateTimeKind.Unspecified).AddTicks(3249), 26L, "et", 2, "I'll index the back-end RSS driver, that should dr" },
                    { 9L, new DateTime(2019, 4, 26, 13, 40, 43, 491, DateTimeKind.Unspecified).AddTicks(5011), 3L, "Quas maxime esse et dolores accusamus doloremque in magnam quos.\nSaepe incidunt modi recusandae saepe ut et.\nAccusamus sed maiores doloremque aut et aut praesentium quae.\nQui magni eum autem architecto accusamus dolore inventore expedita.\nEos velit optio asperiores dolores voluptas amet voluptatum deserunt.", 4, "The SAS pixel is down, hack the mobile pixel so we" },
                    { 10L, new DateTime(2017, 5, 27, 7, 31, 42, 205, DateTimeKind.Unspecified).AddTicks(4510), 6L, "Doloremque velit maiores unde at commodi.", 3, "You can't synthesize the firewall without transmit" },
                    { 11L, new DateTime(2021, 11, 9, 18, 29, 29, 859, DateTimeKind.Unspecified).AddTicks(4190), 40L, "Doloribus eveniet non aut fuga et.", 4, "Try to calculate the SMTP bus, maybe it will calcu" },
                    { 12L, new DateTime(2023, 4, 20, 23, 2, 52, 366, DateTimeKind.Unspecified).AddTicks(2525), 40L, "Est molestiae voluptatem eos assumenda et libero voluptatem et.\nAb maxime fuga nemo ad.\nNon illum ut iste ea perspiciatis.", 3, "The ADP array is down, generate the bluetooth arra" },
                    { 13L, new DateTime(2020, 12, 2, 17, 11, 21, 803, DateTimeKind.Unspecified).AddTicks(6388), 5L, "iure", 4, "The SMS driver is down, hack the optical driver so" },
                    { 14L, new DateTime(2021, 12, 26, 11, 43, 22, 560, DateTimeKind.Unspecified).AddTicks(3754), 30L, "Nostrum sit quia consequatur eos dolorem quo vel libero ut.\nIusto error quia ab.\nAutem quam et quia eum ea molestias eum dolore consequuntur.\nEligendi rerum nisi aspernatur et commodi libero cupiditate.\nMollitia molestias eaque quia dignissimos voluptas porro voluptas.", 3, "Try to copy the IB program, maybe it will copy the" },
                    { 15L, new DateTime(2021, 4, 3, 22, 22, 15, 282, DateTimeKind.Unspecified).AddTicks(636), 5L, "Recusandae molestias id.", 3, "Use the wireless SDD circuit, then you can navigat" },
                    { 16L, new DateTime(2020, 1, 10, 15, 12, 27, 644, DateTimeKind.Unspecified).AddTicks(27), 13L, "Corporis veniam vel et voluptas. Rerum quod facilis est nihil qui et rerum et non. Rerum culpa deserunt adipisci vero iure corporis. Quam odit reprehenderit. Atque cupiditate aut minus minus reprehenderit eos. Ipsam et aut nostrum assumenda explicabo rem.", 1, "If we bypass the port, we can get to the USB port " },
                    { 17L, new DateTime(2021, 3, 25, 11, 1, 58, 161, DateTimeKind.Unspecified).AddTicks(8899), 18L, "ratione", 4, "calculating the panel won't do anything, we need t" },
                    { 18L, new DateTime(2022, 12, 20, 7, 31, 10, 393, DateTimeKind.Unspecified).AddTicks(913), 17L, "et", 4, "If we hack the program, we can get to the PCI prog" },
                    { 19L, new DateTime(2022, 6, 2, 8, 24, 35, 880, DateTimeKind.Unspecified).AddTicks(1783), 20L, "Sint doloribus sit aut ipsam maiores voluptatum voluptas in.", 3, "compressing the sensor won't do anything, we need " },
                    { 20L, new DateTime(2021, 5, 14, 14, 36, 10, 4, DateTimeKind.Unspecified).AddTicks(8258), 38L, "perspiciatis", 2, "I'll override the redundant AGP card, that should " },
                    { 21L, new DateTime(2021, 9, 26, 1, 19, 45, 901, DateTimeKind.Unspecified).AddTicks(1924), 23L, "Quisquam cum aut sunt sit suscipit similique voluptatem maxime qui. Quia aut exercitationem est provident enim rerum maiores. Voluptatem aut fugiat sunt exercitationem. Corrupti vitae ea eos enim similique. Fuga et enim ad laboriosam quaerat ut et. Et sed dolorum sunt quisquam incidunt et explicabo et.", 4, "Use the open-source EXE array, then you can connec" },
                    { 22L, new DateTime(2023, 4, 15, 18, 12, 22, 686, DateTimeKind.Unspecified).AddTicks(4910), 2L, "Id consequuntur nesciunt laudantium quaerat et suscipit quaerat recusandae nobis. Id corrupti vitae. Hic quisquam cumque aliquam qui. Quasi porro quisquam dicta voluptatibus.", 2, "The IB transmitter is down, quantify the optical t" },
                    { 23L, new DateTime(2023, 7, 1, 17, 1, 0, 556, DateTimeKind.Unspecified).AddTicks(9494), 35L, "Odit laudantium quibusdam nostrum fugiat dolores.", 4, "Use the back-end SMTP bus, then you can override t" },
                    { 24L, new DateTime(2021, 5, 22, 1, 44, 15, 958, DateTimeKind.Unspecified).AddTicks(5445), 20L, "Sed voluptate iusto vel ad ea voluptates iure.\nAccusantium saepe iusto dolorum necessitatibus necessitatibus.", 3, "We need to reboot the haptic USB protocol!" },
                    { 25L, new DateTime(2023, 1, 14, 20, 55, 39, 569, DateTimeKind.Unspecified).AddTicks(368), 11L, "eum", 4, "You can't reboot the bus without parsing the redun" },
                    { 26L, new DateTime(2021, 2, 5, 11, 17, 51, 122, DateTimeKind.Unspecified).AddTicks(1428), 18L, "Amet qui vel dignissimos maxime quo recusandae provident. Accusamus expedita delectus praesentium nam dolores accusamus. Mollitia iste unde voluptatem.", 1, "You can't calculate the program without hacking th" },
                    { 27L, new DateTime(2021, 3, 27, 1, 0, 53, 748, DateTimeKind.Unspecified).AddTicks(9486), 19L, "necessitatibus", 4, "I'll index the open-source JSON card, that should " },
                    { 28L, new DateTime(2019, 10, 21, 19, 20, 14, 266, DateTimeKind.Unspecified).AddTicks(9605), 23L, "Modi blanditiis aut sunt qui ut.\nVeritatis dignissimos deleniti.\nQuod ut aliquid voluptatum dolorem error.", 1, "If we parse the driver, we can get to the PNG driv" },
                    { 29L, new DateTime(2023, 1, 8, 23, 11, 40, 421, DateTimeKind.Unspecified).AddTicks(6030), 17L, "numquam", 3, "The PNG pixel is down, bypass the haptic pixel so " },
                    { 30L, new DateTime(2021, 5, 1, 4, 38, 19, 673, DateTimeKind.Unspecified).AddTicks(9740), 2L, "ut", 2, "The GB firewall is down, reboot the 1080p firewall" },
                    { 31L, new DateTime(2022, 6, 10, 5, 30, 25, 649, DateTimeKind.Unspecified).AddTicks(9991), 19L, "Eum ea sequi voluptas praesentium hic.\nVoluptatum voluptatem dolor consequatur distinctio et.\nAutem officia ut unde delectus repudiandae eum animi consectetur omnis.", 2, "You can't index the transmitter without compressin" },
                    { 32L, new DateTime(2023, 6, 3, 13, 23, 29, 323, DateTimeKind.Unspecified).AddTicks(4796), 13L, "quia", 4, "We need to back up the virtual SQL feed!" },
                    { 33L, new DateTime(2021, 9, 27, 12, 19, 30, 867, DateTimeKind.Unspecified).AddTicks(7855), 9L, "Sunt et est aliquam aut unde blanditiis.\nRepellendus dolorem autem.\nEos nihil veniam quia ipsa.\nOdit fuga illum nobis voluptatum deserunt in.", 2, "Try to program the COM alarm, maybe it will progra" },
                    { 34L, new DateTime(2023, 3, 2, 23, 12, 35, 702, DateTimeKind.Unspecified).AddTicks(3523), 7L, "Culpa voluptatem est sequi in sit quam.", 3, "The XSS matrix is down, transmit the cross-platfor" },
                    { 35L, new DateTime(2022, 10, 9, 19, 52, 50, 361, DateTimeKind.Unspecified).AddTicks(7909), 34L, "Quisquam voluptate sequi magni soluta soluta qui voluptatem reprehenderit quo.", 1, "We need to navigate the digital RAM pixel!" },
                    { 36L, new DateTime(2022, 4, 5, 15, 51, 40, 223, DateTimeKind.Unspecified).AddTicks(7840), 4L, "Voluptatem quia ut ut doloribus ut et ratione suscipit. Est sunt veritatis. Quis ducimus laboriosam.", 1, "Try to input the JBOD driver, maybe it will input " },
                    { 37L, new DateTime(2020, 7, 21, 17, 39, 16, 355, DateTimeKind.Unspecified).AddTicks(6237), 38L, "iusto", 3, "The COM array is down, program the virtual array s" },
                    { 38L, new DateTime(2017, 8, 20, 17, 43, 57, 232, DateTimeKind.Unspecified).AddTicks(6196), 6L, "Omnis et et eum eum tempora nostrum a iure voluptatem. Expedita itaque quos quia soluta repellat quas perspiciatis. Sed consequatur numquam maxime. Enim quaerat ratione rerum sed quis. Ea dolores dolor eum vitae dolores vitae.", 3, "Use the solid state IB transmitter, then you can h" },
                    { 39L, new DateTime(2019, 10, 19, 14, 31, 53, 801, DateTimeKind.Unspecified).AddTicks(7171), 13L, "Expedita labore omnis omnis delectus doloremque possimus esse fugit.\nQui quasi pariatur et sed aliquam aut quo temporibus animi.\nNihil esse similique molestiae voluptas molestiae eum.\nImpedit et in nihil nihil et.", 4, "If we navigate the hard drive, we can get to the P" },
                    { 40L, new DateTime(2021, 2, 14, 2, 32, 25, 389, DateTimeKind.Unspecified).AddTicks(9330), 27L, "Adipisci sint quibusdam.", 4, "bypassing the matrix won't do anything, we need to" },
                    { 41L, new DateTime(2019, 4, 26, 4, 59, 16, 494, DateTimeKind.Unspecified).AddTicks(9339), 23L, "Non non ea ab maxime est ratione. Et voluptate iusto ut. Minima nihil qui quaerat ratione aut.", 3, "I'll parse the virtual SCSI transmitter, that shou" },
                    { 42L, new DateTime(2022, 3, 12, 16, 31, 21, 821, DateTimeKind.Unspecified).AddTicks(2910), 23L, "Eos provident laborum placeat reprehenderit voluptatem.", 1, "indexing the hard drive won't do anything, we need" }
                });

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Instructions", "LevelId", "Title" },
                values: new object[,]
                {
                    { 43L, new DateTime(2023, 7, 9, 14, 20, 6, 768, DateTimeKind.Unspecified).AddTicks(8697), 23L, "Et dolor error quo doloremque harum explicabo.\nSed qui facere corporis sunt omnis voluptas corporis perspiciatis ut.\nEst rerum ad necessitatibus voluptatem.\nLaboriosam cupiditate dolorem eaque perspiciatis et.", 4, "You can't copy the port without parsing the wirele" },
                    { 44L, new DateTime(2021, 11, 6, 5, 0, 11, 302, DateTimeKind.Unspecified).AddTicks(8878), 21L, "Aut ex quis.\nEnim nulla eligendi est quam iusto.\nCumque harum saepe velit consequatur eligendi odit ut vero.\nDolorem sit vel sed nemo modi consequatur.", 2, "You can't parse the firewall without backing up th" },
                    { 45L, new DateTime(2021, 6, 1, 15, 11, 34, 490, DateTimeKind.Unspecified).AddTicks(3269), 35L, "Ut qui non dolores sunt enim fugiat quisquam cupiditate distinctio. Officiis reprehenderit quidem qui quis quia asperiores quaerat sapiente. Quia quia voluptatem magni et enim iure. Dolorum ut minus.", 2, "If we bypass the transmitter, we can get to the AI" },
                    { 46L, new DateTime(2023, 1, 4, 22, 22, 37, 278, DateTimeKind.Unspecified).AddTicks(9249), 7L, "Officia iusto rerum placeat temporibus corrupti et aut cumque.\nCommodi voluptatem laborum amet consequatur.\nA ducimus est ut reprehenderit.\nSit odit consequuntur.\nTempore magni nihil velit quos sed deleniti aliquid.\nEligendi nesciunt error mollitia et consequatur.", 1, "compressing the bus won't do anything, we need to " },
                    { 47L, new DateTime(2022, 6, 28, 12, 26, 44, 769, DateTimeKind.Unspecified).AddTicks(5437), 10L, "Earum laudantium molestias quam sed fuga explicabo vel corrupti in. Quibusdam et ut voluptatem facere. Magni qui pariatur reiciendis eveniet.", 1, "I'll parse the back-end XML protocol, that should " },
                    { 48L, new DateTime(2020, 12, 22, 16, 1, 34, 101, DateTimeKind.Unspecified).AddTicks(1667), 15L, "Sed rerum molestiae ad.\nItaque quas vel sint voluptas maxime assumenda.\nHic debitis tempore minus et quos quia repudiandae.\nUt laudantium ut.", 4, "We need to synthesize the haptic THX bandwidth!" },
                    { 49L, new DateTime(2023, 1, 6, 19, 1, 41, 575, DateTimeKind.Unspecified).AddTicks(2003), 34L, "vel", 1, "Use the wireless AI card, then you can back up the" },
                    { 50L, new DateTime(2022, 6, 2, 15, 32, 3, 28, DateTimeKind.Unspecified).AddTicks(4120), 34L, "Cum in ex nulla doloremque nostrum nemo quos.\nLaudantium corporis ut hic sapiente dolore sed architecto.\nIusto expedita rerum et pariatur optio ex aperiam dolorem placeat.\nAssumenda nesciunt nostrum pariatur corporis et doloribus quae.", 3, "You can't copy the sensor without navigating the d" },
                    { 51L, new DateTime(2021, 12, 21, 8, 42, 58, 162, DateTimeKind.Unspecified).AddTicks(1184), 38L, "Voluptatem iure quia labore pariatur id quia qui expedita quos.\nLaudantium natus dolorem rerum nemo perferendis quam est explicabo aliquam.\nIncidunt et qui.", 2, "The XML monitor is down, compress the 1080p monito" },
                    { 52L, new DateTime(2023, 3, 13, 23, 59, 40, 415, DateTimeKind.Unspecified).AddTicks(3845), 16L, "Fugiat illo alias error eligendi voluptatem.", 2, "You can't transmit the system without connecting t" },
                    { 53L, new DateTime(2018, 9, 14, 4, 12, 29, 311, DateTimeKind.Unspecified).AddTicks(5807), 29L, "Distinctio adipisci sequi vitae nulla. Corporis in labore nobis vel laudantium accusantium minus nihil quas. Sapiente quam vitae ea asperiores cum. Et illum temporibus placeat itaque et aliquam nostrum tempore ratione. Quia modi facere quia. Quaerat nostrum voluptatem.", 4, "Use the wireless GB protocol, then you can synthes" },
                    { 54L, new DateTime(2021, 4, 22, 5, 38, 56, 435, DateTimeKind.Unspecified).AddTicks(3817), 33L, "Necessitatibus libero sint ad culpa accusantium sed omnis praesentium.", 2, "Use the open-source ADP pixel, then you can input " },
                    { 55L, new DateTime(2023, 6, 29, 21, 45, 23, 895, DateTimeKind.Unspecified).AddTicks(5258), 31L, "Aut ut ut voluptates tempora ut commodi quos id. Dolores rerum eveniet quaerat dolores eligendi hic ipsum sit. Impedit fugiat numquam ad rerum atque tempore vero ipsa ab. Consequatur vitae hic omnis cumque perspiciatis consequatur ex omnis.", 1, "overriding the port won't do anything, we need to " },
                    { 56L, new DateTime(2022, 5, 14, 17, 52, 21, 630, DateTimeKind.Unspecified).AddTicks(6123), 26L, "Sunt ut fugit minima facere optio accusantium.\nDeserunt molestias ducimus omnis voluptatibus quos aut rerum.\nQuibusdam ratione qui illum quam modi.", 4, "I'll bypass the digital XSS pixel, that should pix" },
                    { 57L, new DateTime(2018, 9, 21, 0, 31, 11, 752, DateTimeKind.Unspecified).AddTicks(6508), 15L, "Minus quo dolores rerum pariatur nisi.\nDolorem dolore laborum corporis reiciendis dignissimos in.\nEos enim vel placeat minus voluptatem consequuntur totam corporis et.", 2, "Try to generate the SMTP application, maybe it wil" },
                    { 58L, new DateTime(2022, 5, 2, 22, 28, 50, 781, DateTimeKind.Unspecified).AddTicks(8088), 40L, "aut", 4, "Use the solid state SMS alarm, then you can bypass" },
                    { 59L, new DateTime(2022, 1, 7, 12, 31, 39, 969, DateTimeKind.Unspecified).AddTicks(8320), 8L, "Veniam rerum repudiandae sint eos delectus qui veniam id consequatur.", 2, "We need to synthesize the open-source CSS driver!" },
                    { 60L, new DateTime(2021, 9, 18, 3, 19, 23, 77, DateTimeKind.Unspecified).AddTicks(3542), 22L, "Quia fugiat voluptatem nihil vitae molestias.", 4, "I'll connect the bluetooth RSS feed, that should f" },
                    { 61L, new DateTime(2023, 7, 3, 20, 19, 55, 491, DateTimeKind.Unspecified).AddTicks(535), 2L, "Accusamus beatae omnis totam maxime autem in et et.\nEt ducimus ea quia a excepturi a aut.\nExplicabo illo blanditiis illo eum qui itaque natus modi.", 4, "You can't generate the protocol without indexing t" },
                    { 62L, new DateTime(2021, 5, 11, 10, 15, 14, 889, DateTimeKind.Unspecified).AddTicks(1251), 13L, "Voluptatem veniam ut autem enim. Architecto nihil ut rerum aut nihil eos aut. Esse voluptatem reprehenderit perferendis aut ut dolor voluptas.", 4, "If we quantify the program, we can get to the FTP " },
                    { 63L, new DateTime(2022, 12, 15, 15, 33, 17, 694, DateTimeKind.Unspecified).AddTicks(6585), 26L, "Est consectetur voluptatem.\nPlaceat et eos.\nSunt quo et qui eius qui dolor numquam numquam nulla.\nSed nulla sint delectus alias.", 3, "If we bypass the circuit, we can get to the RSS ci" },
                    { 64L, new DateTime(2022, 2, 17, 9, 42, 35, 6, DateTimeKind.Unspecified).AddTicks(9969), 10L, "ut", 4, "parsing the matrix won't do anything, we need to c" },
                    { 65L, new DateTime(2017, 5, 15, 19, 54, 48, 212, DateTimeKind.Unspecified).AddTicks(4761), 24L, "Suscipit iusto quas est quaerat molestiae nostrum tempora aliquam tempora.\nRem dolorem ut voluptas voluptate.\nQuo magnam eligendi.\nIpsum tenetur praesentium earum.", 2, "Try to connect the XSS feed, maybe it will connect" },
                    { 66L, new DateTime(2021, 1, 30, 1, 55, 38, 248, DateTimeKind.Unspecified).AddTicks(2799), 33L, "Quae aliquid quod error nesciunt.", 3, "Use the online IB panel, then you can synthesize t" },
                    { 67L, new DateTime(2023, 7, 14, 20, 53, 27, 509, DateTimeKind.Unspecified).AddTicks(59), 39L, "Autem est neque deleniti quae.\nCum vitae ut id voluptate est aut enim.\nAlias tenetur commodi cumque explicabo est.\nCommodi blanditiis tenetur sapiente dolores atque tempore.\nAut modi officiis neque consequatur.", 1, "You can't transmit the application without quantif" },
                    { 68L, new DateTime(2022, 6, 14, 18, 50, 36, 872, DateTimeKind.Unspecified).AddTicks(4375), 19L, "Est dolores id tempore vel.", 4, "If we override the circuit, we can get to the HDD " },
                    { 69L, new DateTime(2023, 3, 4, 22, 6, 39, 844, DateTimeKind.Unspecified).AddTicks(2165), 7L, "Aut quibusdam amet at facilis rerum.\nUt veritatis commodi aspernatur doloremque quia quidem.", 1, "Use the cross-platform AGP firewall, then you can " },
                    { 70L, new DateTime(2023, 5, 27, 9, 27, 19, 579, DateTimeKind.Unspecified).AddTicks(1029), 37L, "Natus aut officia qui consequatur.", 4, "Try to navigate the THX system, maybe it will navi" }
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
                    { 1L, 151.37m, new DateTime(2023, 5, 2, 17, 54, 51, 965, DateTimeKind.Unspecified).AddTicks(5068), false, "2umhqjy0f1gdzhf2", new DateTime(2023, 1, 29, 8, 53, 48, 394, DateTimeKind.Unspecified).AddTicks(2815), new DateTime(2019, 6, 30, 12, 16, 24, 1, DateTimeKind.Unspecified).AddTicks(4781), 2, new DateTime(2023, 2, 7, 7, 39, 29, 733, DateTimeKind.Unspecified).AddTicks(9074), 27L },
                    { 2L, 136.02m, new DateTime(2024, 1, 27, 11, 55, 58, 359, DateTimeKind.Unspecified).AddTicks(6129), true, "6iotvwd2kcauexpx", new DateTime(2023, 7, 9, 2, 34, 3, 235, DateTimeKind.Unspecified).AddTicks(2077), new DateTime(2022, 12, 15, 23, 48, 1, 29, DateTimeKind.Unspecified).AddTicks(9021), 1, new DateTime(2023, 1, 2, 2, 39, 1, 74, DateTimeKind.Unspecified).AddTicks(4139), 20L },
                    { 3L, 151.37m, new DateTime(2023, 5, 18, 4, 33, 25, 731, DateTimeKind.Unspecified).AddTicks(3372), false, "uo2s583680b8v54j", new DateTime(2023, 3, 5, 23, 40, 52, 965, DateTimeKind.Unspecified).AddTicks(2607), new DateTime(2022, 5, 6, 11, 19, 33, 743, DateTimeKind.Unspecified).AddTicks(9488), 2, new DateTime(2023, 2, 8, 8, 46, 38, 154, DateTimeKind.Unspecified).AddTicks(5507), 27L },
                    { 4L, 136.02m, new DateTime(2023, 9, 29, 18, 42, 30, 380, DateTimeKind.Unspecified).AddTicks(1699), true, "nfd23s23e9y7ukxb", new DateTime(2023, 2, 15, 6, 38, 51, 917, DateTimeKind.Unspecified).AddTicks(4843), new DateTime(2022, 10, 14, 23, 44, 15, 322, DateTimeKind.Unspecified).AddTicks(9888), 1, new DateTime(2023, 3, 16, 18, 39, 41, 914, DateTimeKind.Unspecified).AddTicks(5309), 10L },
                    { 5L, 136.02m, new DateTime(2023, 4, 11, 19, 24, 42, 18, DateTimeKind.Unspecified).AddTicks(5116), true, "28569h790c5pv13g", new DateTime(2023, 2, 4, 22, 50, 4, 464, DateTimeKind.Unspecified).AddTicks(9366), new DateTime(2022, 4, 11, 18, 41, 31, 555, DateTimeKind.Unspecified).AddTicks(3051), 1, new DateTime(2023, 7, 13, 1, 14, 30, 890, DateTimeKind.Unspecified).AddTicks(9489), 38L }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "Cost", "EndDate", "IsActive", "PaymentSubscriptionId", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate", "UserId" },
                values: new object[,]
                {
                    { 6L, 91.86m, new DateTime(2021, 4, 17, 0, 7, 18, 994, DateTimeKind.Unspecified).AddTicks(5597), true, "fhe3z935d1zvmvux", new DateTime(2020, 11, 12, 7, 19, 7, 748, DateTimeKind.Unspecified).AddTicks(1069), new DateTime(2018, 3, 14, 23, 18, 38, 518, DateTimeKind.Unspecified).AddTicks(4863), 3, new DateTime(2019, 5, 23, 11, 15, 52, 488, DateTimeKind.Unspecified).AddTicks(6294), 3L },
                    { 7L, 136.02m, new DateTime(2023, 6, 17, 11, 16, 4, 610, DateTimeKind.Unspecified).AddTicks(1368), true, "04gfoh55j2qr239q", new DateTime(2023, 5, 24, 21, 8, 46, 479, DateTimeKind.Unspecified).AddTicks(3038), new DateTime(2022, 4, 8, 17, 18, 20, 963, DateTimeKind.Unspecified).AddTicks(5463), 1, new DateTime(2022, 7, 29, 19, 13, 22, 144, DateTimeKind.Unspecified).AddTicks(8738), 10L },
                    { 8L, 91.86m, new DateTime(2022, 7, 1, 5, 28, 31, 565, DateTimeKind.Unspecified).AddTicks(1410), false, "cvjhq7n8273vtohw", new DateTime(2022, 5, 9, 23, 29, 36, 222, DateTimeKind.Unspecified).AddTicks(8370), new DateTime(2020, 9, 27, 2, 16, 35, 728, DateTimeKind.Unspecified).AddTicks(8325), 3, new DateTime(2020, 12, 25, 13, 43, 50, 590, DateTimeKind.Unspecified).AddTicks(951), 36L },
                    { 9L, 151.37m, new DateTime(2024, 8, 1, 12, 26, 5, 120, DateTimeKind.Unspecified).AddTicks(2472), false, "ff9fvm4sae2sxofc", new DateTime(2023, 8, 2, 11, 26, 22, 482, DateTimeKind.Unspecified).AddTicks(5466), new DateTime(2023, 3, 11, 16, 50, 52, 639, DateTimeKind.Unspecified).AddTicks(7862), 2, new DateTime(2023, 5, 16, 23, 12, 19, 662, DateTimeKind.Unspecified).AddTicks(6463), 17L },
                    { 10L, 136.02m, new DateTime(2022, 7, 30, 16, 51, 8, 490, DateTimeKind.Unspecified).AddTicks(802), true, "igx8w9w90k1ay8cf", new DateTime(2021, 12, 12, 21, 16, 46, 919, DateTimeKind.Unspecified).AddTicks(8307), new DateTime(2020, 10, 10, 16, 47, 30, 756, DateTimeKind.Unspecified).AddTicks(1929), 1, new DateTime(2022, 10, 6, 5, 36, 11, 79, DateTimeKind.Unspecified).AddTicks(3899), 3L },
                    { 11L, 91.86m, new DateTime(2023, 10, 28, 21, 52, 8, 420, DateTimeKind.Unspecified).AddTicks(6720), true, "dy4mdzy1ipwfpvv0", new DateTime(2023, 3, 10, 15, 56, 13, 99, DateTimeKind.Unspecified).AddTicks(3590), new DateTime(2022, 12, 6, 7, 55, 42, 660, DateTimeKind.Unspecified).AddTicks(4930), 3, new DateTime(2023, 1, 12, 17, 37, 13, 387, DateTimeKind.Unspecified).AddTicks(8716), 20L },
                    { 12L, 136.02m, new DateTime(2023, 1, 7, 12, 36, 28, 812, DateTimeKind.Unspecified).AddTicks(34), true, "69sotjwthpvx4aw1", new DateTime(2022, 9, 6, 17, 54, 24, 903, DateTimeKind.Unspecified).AddTicks(1111), new DateTime(2022, 5, 17, 1, 19, 5, 793, DateTimeKind.Unspecified).AddTicks(9928), 1, new DateTime(2023, 7, 16, 17, 38, 44, 642, DateTimeKind.Unspecified).AddTicks(629), 25L },
                    { 13L, 136.02m, new DateTime(2023, 9, 1, 2, 16, 1, 870, DateTimeKind.Unspecified).AddTicks(4349), true, "gjxuxll8kyg46a7z", new DateTime(2023, 8, 23, 4, 42, 3, 557, DateTimeKind.Unspecified).AddTicks(129), new DateTime(2023, 5, 20, 4, 58, 15, 108, DateTimeKind.Unspecified).AddTicks(4830), 1, new DateTime(2023, 8, 17, 2, 6, 53, 788, DateTimeKind.Unspecified).AddTicks(2452), 32L },
                    { 14L, 151.37m, new DateTime(2023, 1, 9, 23, 4, 25, 194, DateTimeKind.Unspecified).AddTicks(8487), true, "wprmc5u9im89l2ww", new DateTime(2022, 3, 14, 8, 12, 18, 777, DateTimeKind.Unspecified).AddTicks(3285), new DateTime(2021, 11, 15, 1, 3, 56, 974, DateTimeKind.Unspecified).AddTicks(3961), 2, new DateTime(2023, 3, 28, 12, 55, 24, 127, DateTimeKind.Unspecified).AddTicks(3256), 5L },
                    { 15L, 136.02m, new DateTime(2023, 3, 15, 19, 5, 52, 782, DateTimeKind.Unspecified).AddTicks(4224), false, "stg9zq5iopx7uyvf", new DateTime(2023, 2, 23, 4, 9, 45, 612, DateTimeKind.Unspecified).AddTicks(3556), new DateTime(2022, 7, 6, 20, 33, 8, 458, DateTimeKind.Unspecified).AddTicks(4505), 1, new DateTime(2023, 7, 24, 20, 54, 47, 819, DateTimeKind.Unspecified).AddTicks(720), 5L },
                    { 16L, 91.86m, new DateTime(2023, 9, 5, 4, 43, 22, 588, DateTimeKind.Unspecified).AddTicks(2434), true, "61vekpd4uftjpk9r", new DateTime(2023, 7, 16, 20, 50, 53, 209, DateTimeKind.Unspecified).AddTicks(9126), new DateTime(2022, 8, 18, 17, 23, 3, 904, DateTimeKind.Unspecified).AddTicks(3280), 3, null, 19L },
                    { 17L, 91.86m, new DateTime(2022, 10, 12, 20, 42, 28, 877, DateTimeKind.Unspecified).AddTicks(1554), false, "qy2m6a9vgq3xvryz", new DateTime(2022, 8, 22, 19, 18, 20, 110, DateTimeKind.Unspecified).AddTicks(8142), new DateTime(2021, 12, 17, 3, 10, 38, 88, DateTimeKind.Unspecified).AddTicks(9833), 3, new DateTime(2022, 7, 15, 7, 24, 4, 540, DateTimeKind.Unspecified).AddTicks(8163), 14L },
                    { 18L, 91.86m, new DateTime(2024, 1, 24, 5, 48, 17, 129, DateTimeKind.Unspecified).AddTicks(8497), false, "xt3cbgkhzqommryk", new DateTime(2023, 8, 4, 15, 11, 9, 667, DateTimeKind.Unspecified).AddTicks(2206), new DateTime(2022, 4, 25, 2, 23, 53, 307, DateTimeKind.Unspecified).AddTicks(5260), 3, new DateTime(2022, 10, 9, 13, 39, 36, 623, DateTimeKind.Unspecified).AddTicks(1768), 7L },
                    { 19L, 151.37m, new DateTime(2023, 8, 22, 11, 32, 35, 339, DateTimeKind.Unspecified).AddTicks(3829), false, "rmkbbn0e8joc7xjz", new DateTime(2023, 7, 21, 12, 57, 37, 754, DateTimeKind.Unspecified).AddTicks(7592), new DateTime(2023, 7, 16, 7, 3, 47, 701, DateTimeKind.Unspecified).AddTicks(5759), 2, new DateTime(2023, 7, 29, 6, 27, 5, 583, DateTimeKind.Unspecified).AddTicks(5054), 7L },
                    { 20L, 136.02m, new DateTime(2019, 10, 6, 10, 28, 13, 310, DateTimeKind.Unspecified).AddTicks(3529), true, "us879r2lwdkpw85c", new DateTime(2019, 9, 8, 0, 25, 47, 821, DateTimeKind.Unspecified).AddTicks(964), new DateTime(2019, 5, 28, 3, 24, 34, 478, DateTimeKind.Unspecified).AddTicks(8716), 1, new DateTime(2021, 12, 18, 1, 0, 39, 352, DateTimeKind.Unspecified).AddTicks(403), 29L },
                    { 21L, 136.02m, new DateTime(2023, 9, 9, 19, 28, 28, 737, DateTimeKind.Unspecified).AddTicks(6700), false, "e3suermf9zhiet5h", new DateTime(2023, 5, 3, 21, 41, 24, 739, DateTimeKind.Unspecified).AddTicks(9154), new DateTime(2021, 12, 29, 3, 25, 46, 817, DateTimeKind.Unspecified).AddTicks(1502), 1, new DateTime(2023, 5, 22, 9, 49, 45, 117, DateTimeKind.Unspecified).AddTicks(5082), 20L },
                    { 22L, 136.02m, new DateTime(2024, 5, 13, 4, 30, 17, 240, DateTimeKind.Unspecified).AddTicks(3289), false, "gkftyah9gzs5y764", new DateTime(2023, 8, 3, 9, 13, 16, 573, DateTimeKind.Unspecified).AddTicks(7882), new DateTime(2023, 1, 24, 10, 51, 35, 772, DateTimeKind.Unspecified).AddTicks(2510), 1, new DateTime(2023, 6, 9, 15, 50, 4, 19, DateTimeKind.Unspecified).AddTicks(9496), 31L },
                    { 23L, 136.02m, new DateTime(2022, 4, 19, 21, 51, 37, 754, DateTimeKind.Unspecified).AddTicks(5950), true, "4wkz5jwj0veuctgy", new DateTime(2022, 4, 14, 11, 28, 15, 820, DateTimeKind.Unspecified).AddTicks(8554), new DateTime(2021, 3, 28, 23, 29, 17, 409, DateTimeKind.Unspecified).AddTicks(8333), 1, new DateTime(2023, 8, 19, 10, 22, 31, 899, DateTimeKind.Unspecified).AddTicks(6827), 21L },
                    { 24L, 136.02m, new DateTime(2021, 12, 14, 21, 4, 3, 179, DateTimeKind.Unspecified).AddTicks(5731), false, "xb17e65tmjo2pi3w", new DateTime(2021, 2, 23, 4, 57, 20, 526, DateTimeKind.Unspecified).AddTicks(6641), new DateTime(2020, 12, 9, 21, 43, 13, 880, DateTimeKind.Unspecified).AddTicks(2801), 1, new DateTime(2021, 11, 1, 9, 2, 56, 505, DateTimeKind.Unspecified).AddTicks(7359), 4L },
                    { 25L, 151.37m, new DateTime(2022, 12, 19, 16, 47, 39, 248, DateTimeKind.Unspecified).AddTicks(6051), false, "ohejkiv4da2uho5t", new DateTime(2022, 11, 4, 18, 22, 11, 158, DateTimeKind.Unspecified).AddTicks(4988), new DateTime(2019, 3, 22, 7, 41, 13, 178, DateTimeKind.Unspecified).AddTicks(1214), 2, new DateTime(2021, 1, 14, 0, 20, 25, 785, DateTimeKind.Unspecified).AddTicks(4688), 30L },
                    { 26L, 151.37m, new DateTime(2022, 11, 1, 19, 17, 19, 600, DateTimeKind.Unspecified).AddTicks(7562), true, "46crvfhli3jxsl84", new DateTime(2022, 5, 23, 1, 51, 19, 960, DateTimeKind.Unspecified).AddTicks(8126), new DateTime(2021, 6, 3, 7, 46, 17, 855, DateTimeKind.Unspecified).AddTicks(9038), 2, new DateTime(2021, 12, 9, 23, 0, 14, 688, DateTimeKind.Unspecified).AddTicks(2985), 27L },
                    { 27L, 151.37m, new DateTime(2022, 10, 11, 18, 20, 57, 70, DateTimeKind.Unspecified).AddTicks(554), true, "3ab74yu98efe549y", new DateTime(2022, 8, 15, 4, 33, 12, 315, DateTimeKind.Unspecified).AddTicks(351), new DateTime(2021, 12, 7, 17, 40, 36, 384, DateTimeKind.Unspecified).AddTicks(2406), 2, null, 33L },
                    { 28L, 136.02m, new DateTime(2023, 8, 8, 8, 47, 49, 441, DateTimeKind.Unspecified).AddTicks(5741), false, "c26kqtjwrynk39gj", new DateTime(2023, 6, 8, 2, 55, 18, 101, DateTimeKind.Unspecified).AddTicks(4119), new DateTime(2023, 4, 24, 17, 53, 15, 425, DateTimeKind.Unspecified).AddTicks(6903), 1, new DateTime(2023, 8, 3, 4, 17, 38, 899, DateTimeKind.Unspecified).AddTicks(8140), 11L },
                    { 29L, 151.37m, new DateTime(2022, 10, 30, 8, 19, 43, 358, DateTimeKind.Unspecified).AddTicks(7093), false, "aqmyw08v96v1s9if", new DateTime(2022, 5, 12, 8, 19, 6, 687, DateTimeKind.Unspecified).AddTicks(4940), new DateTime(2022, 1, 21, 19, 4, 16, 898, DateTimeKind.Unspecified).AddTicks(3328), 2, new DateTime(2023, 3, 8, 21, 37, 36, 545, DateTimeKind.Unspecified).AddTicks(7654), 35L },
                    { 30L, 91.86m, new DateTime(2023, 10, 11, 4, 39, 51, 161, DateTimeKind.Unspecified).AddTicks(1421), false, "0s5wjozi3ma06kzq", new DateTime(2023, 5, 20, 5, 21, 46, 362, DateTimeKind.Unspecified).AddTicks(2261), new DateTime(2019, 10, 19, 12, 0, 51, 477, DateTimeKind.Unspecified).AddTicks(6833), 3, new DateTime(2021, 5, 31, 21, 31, 2, 500, DateTimeKind.Unspecified).AddTicks(4719), 30L },
                    { 31L, 151.37m, new DateTime(2024, 6, 19, 12, 33, 6, 365, DateTimeKind.Unspecified).AddTicks(6111), true, "q9hn6s2kv3y4vcck", new DateTime(2023, 7, 1, 17, 44, 49, 992, DateTimeKind.Unspecified).AddTicks(1124), new DateTime(2023, 6, 21, 14, 49, 0, 706, DateTimeKind.Unspecified).AddTicks(3171), 2, new DateTime(2023, 7, 23, 9, 23, 54, 838, DateTimeKind.Unspecified).AddTicks(8736), 8L },
                    { 32L, 91.86m, new DateTime(2020, 9, 25, 19, 37, 47, 762, DateTimeKind.Unspecified).AddTicks(6734), true, "iwgpew5l055a6ccb", new DateTime(2020, 2, 15, 7, 20, 43, 817, DateTimeKind.Unspecified).AddTicks(4121), new DateTime(2019, 10, 12, 3, 6, 40, 603, DateTimeKind.Unspecified).AddTicks(8406), 3, new DateTime(2023, 3, 4, 6, 59, 7, 338, DateTimeKind.Unspecified).AddTicks(4534), 23L },
                    { 33L, 151.37m, new DateTime(2021, 11, 29, 11, 47, 32, 709, DateTimeKind.Unspecified).AddTicks(3904), false, "fqq1hl08z749bd6z", new DateTime(2021, 9, 19, 6, 19, 40, 934, DateTimeKind.Unspecified).AddTicks(6497), new DateTime(2016, 12, 6, 9, 56, 44, 706, DateTimeKind.Unspecified).AddTicks(2507), 2, new DateTime(2017, 3, 27, 3, 10, 57, 778, DateTimeKind.Unspecified).AddTicks(5018), 38L },
                    { 34L, 91.86m, new DateTime(2023, 9, 28, 2, 31, 58, 664, DateTimeKind.Unspecified).AddTicks(4998), true, "0ml8d5on129n534f", new DateTime(2023, 7, 12, 5, 48, 21, 228, DateTimeKind.Unspecified).AddTicks(9606), new DateTime(2018, 6, 5, 7, 46, 11, 566, DateTimeKind.Unspecified).AddTicks(6917), 3, new DateTime(2018, 10, 23, 21, 55, 15, 78, DateTimeKind.Unspecified).AddTicks(4065), 6L },
                    { 35L, 151.37m, new DateTime(2022, 3, 24, 0, 37, 31, 446, DateTimeKind.Unspecified).AddTicks(3698), false, "k558r56ddw1u0svt", new DateTime(2022, 2, 16, 16, 26, 2, 564, DateTimeKind.Unspecified).AddTicks(4626), new DateTime(2021, 8, 24, 17, 9, 20, 437, DateTimeKind.Unspecified).AddTicks(8683), 2, new DateTime(2022, 9, 3, 13, 30, 6, 726, DateTimeKind.Unspecified).AddTicks(4244), 21L },
                    { 36L, 91.86m, new DateTime(2021, 6, 26, 17, 12, 33, 123, DateTimeKind.Unspecified).AddTicks(6655), true, "9olaqemxndo70gvv", new DateTime(2021, 6, 2, 0, 52, 50, 74, DateTimeKind.Unspecified).AddTicks(636), new DateTime(2020, 8, 24, 1, 38, 42, 146, DateTimeKind.Unspecified).AddTicks(1397), 3, new DateTime(2021, 6, 19, 22, 55, 36, 756, DateTimeKind.Unspecified).AddTicks(2786), 36L },
                    { 37L, 136.02m, new DateTime(2023, 6, 11, 14, 18, 54, 560, DateTimeKind.Unspecified).AddTicks(5675), true, "1ggquq41cbz3kwmy", new DateTime(2023, 5, 3, 3, 16, 16, 156, DateTimeKind.Unspecified).AddTicks(8886), new DateTime(2022, 10, 20, 20, 37, 14, 955, DateTimeKind.Unspecified).AddTicks(8855), 1, new DateTime(2023, 5, 12, 6, 11, 13, 881, DateTimeKind.Unspecified).AddTicks(269), 11L },
                    { 38L, 151.37m, new DateTime(2024, 1, 27, 5, 23, 11, 620, DateTimeKind.Unspecified).AddTicks(6580), false, "mcc78krz988ayw3w", new DateTime(2023, 8, 6, 17, 10, 28, 948, DateTimeKind.Unspecified).AddTicks(91), new DateTime(2023, 6, 30, 12, 38, 51, 348, DateTimeKind.Unspecified).AddTicks(4395), 2, new DateTime(2023, 8, 10, 20, 53, 46, 5, DateTimeKind.Unspecified).AddTicks(6973), 11L },
                    { 39L, 91.86m, new DateTime(2023, 10, 22, 6, 29, 1, 157, DateTimeKind.Unspecified).AddTicks(3833), true, "8czy2s8dnd3hewts", new DateTime(2023, 2, 23, 16, 10, 34, 581, DateTimeKind.Unspecified).AddTicks(9761), new DateTime(2022, 11, 27, 21, 6, 40, 780, DateTimeKind.Unspecified).AddTicks(1672), 3, null, 23L },
                    { 40L, 91.86m, new DateTime(2023, 5, 4, 4, 35, 0, 526, DateTimeKind.Unspecified).AddTicks(489), true, "0adhs4lu1czvkswh", new DateTime(2022, 7, 14, 18, 46, 59, 94, DateTimeKind.Unspecified).AddTicks(252), new DateTime(2021, 1, 22, 12, 11, 32, 378, DateTimeKind.Unspecified).AddTicks(6358), 3, new DateTime(2022, 8, 11, 5, 1, 39, 816, DateTimeKind.Unspecified).AddTicks(724), 1L },
                    { 41L, 136.02m, new DateTime(2022, 3, 6, 0, 50, 57, 352, DateTimeKind.Unspecified).AddTicks(553), false, "t24hxzbvbmyserki", new DateTime(2021, 4, 3, 8, 10, 39, 130, DateTimeKind.Unspecified).AddTicks(6773), new DateTime(2021, 2, 24, 12, 50, 44, 627, DateTimeKind.Unspecified).AddTicks(7225), 1, new DateTime(2023, 6, 25, 5, 55, 33, 282, DateTimeKind.Unspecified).AddTicks(5566), 32L },
                    { 42L, 136.02m, new DateTime(2024, 6, 9, 0, 13, 5, 641, DateTimeKind.Unspecified).AddTicks(2137), true, "2cbsqfkes0nq04x2", new DateTime(2023, 8, 2, 11, 39, 44, 242, DateTimeKind.Unspecified).AddTicks(6337), new DateTime(2022, 6, 5, 1, 47, 8, 600, DateTimeKind.Unspecified).AddTicks(5010), 1, new DateTime(2022, 7, 30, 21, 18, 27, 14, DateTimeKind.Unspecified).AddTicks(6966), 2L },
                    { 43L, 151.37m, new DateTime(2023, 9, 4, 8, 17, 38, 410, DateTimeKind.Unspecified).AddTicks(9219), false, "a3sk5gfvudeknj5w", new DateTime(2023, 7, 30, 10, 52, 50, 571, DateTimeKind.Unspecified).AddTicks(1589), new DateTime(2023, 7, 13, 23, 43, 20, 49, DateTimeKind.Unspecified).AddTicks(2375), 2, new DateTime(2023, 8, 16, 18, 52, 37, 456, DateTimeKind.Unspecified).AddTicks(3982), 3L },
                    { 44L, 91.86m, new DateTime(2024, 3, 5, 2, 24, 26, 58, DateTimeKind.Unspecified).AddTicks(3914), true, "bc0td9wya1hmn09c", new DateTime(2023, 6, 21, 20, 27, 58, 892, DateTimeKind.Unspecified).AddTicks(9945), new DateTime(2023, 3, 3, 16, 1, 8, 638, DateTimeKind.Unspecified).AddTicks(6874), 3, new DateTime(2023, 5, 3, 7, 21, 20, 438, DateTimeKind.Unspecified).AddTicks(8510), 23L },
                    { 45L, 151.37m, new DateTime(2022, 12, 29, 18, 2, 33, 100, DateTimeKind.Unspecified).AddTicks(618), true, "xowb5o5gk48tfmik", new DateTime(2022, 12, 15, 7, 9, 52, 76, DateTimeKind.Unspecified).AddTicks(6071), new DateTime(2021, 11, 10, 20, 24, 17, 831, DateTimeKind.Unspecified).AddTicks(8245), 2, new DateTime(2022, 10, 13, 19, 39, 1, 132, DateTimeKind.Unspecified).AddTicks(2741), 19L },
                    { 46L, 136.02m, new DateTime(2022, 6, 17, 0, 56, 36, 740, DateTimeKind.Unspecified).AddTicks(9252), false, "anubxvyyxivpdltm", new DateTime(2021, 9, 12, 18, 50, 22, 758, DateTimeKind.Unspecified).AddTicks(4735), new DateTime(2019, 8, 19, 3, 16, 46, 8, DateTimeKind.Unspecified).AddTicks(1559), 1, new DateTime(2021, 6, 1, 12, 1, 6, 198, DateTimeKind.Unspecified).AddTicks(451), 36L },
                    { 47L, 136.02m, new DateTime(2024, 5, 9, 23, 26, 30, 90, DateTimeKind.Unspecified).AddTicks(6017), false, "ab681sgffu1ituio", new DateTime(2023, 8, 17, 11, 36, 34, 123, DateTimeKind.Unspecified).AddTicks(2742), new DateTime(2023, 6, 11, 23, 38, 55, 64, DateTimeKind.Unspecified).AddTicks(7599), 1, new DateTime(2023, 8, 8, 22, 40, 46, 265, DateTimeKind.Unspecified).AddTicks(9160), 7L }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "Cost", "EndDate", "IsActive", "PaymentSubscriptionId", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate", "UserId" },
                values: new object[,]
                {
                    { 48L, 151.37m, new DateTime(2023, 2, 20, 18, 6, 19, 534, DateTimeKind.Unspecified).AddTicks(6337), true, "noq0gqauqw1mppw5", new DateTime(2022, 8, 1, 17, 43, 53, 774, DateTimeKind.Unspecified).AddTicks(1192), new DateTime(2021, 5, 28, 13, 22, 38, 656, DateTimeKind.Unspecified).AddTicks(8199), 2, new DateTime(2022, 2, 4, 15, 50, 0, 160, DateTimeKind.Unspecified).AddTicks(3326), 4L },
                    { 49L, 136.02m, new DateTime(2024, 5, 15, 6, 25, 41, 735, DateTimeKind.Unspecified).AddTicks(1183), true, "icchkz7h4bld2gyo", new DateTime(2023, 7, 24, 9, 26, 34, 93, DateTimeKind.Unspecified).AddTicks(9623), new DateTime(2022, 7, 30, 2, 57, 25, 565, DateTimeKind.Unspecified).AddTicks(4678), 1, new DateTime(2023, 7, 15, 18, 11, 19, 226, DateTimeKind.Unspecified).AddTicks(3391), 23L },
                    { 50L, 151.37m, new DateTime(2023, 8, 23, 0, 35, 15, 230, DateTimeKind.Unspecified).AddTicks(9017), false, "dqu9ioacwoh3dt9r", new DateTime(2023, 7, 9, 22, 37, 53, 269, DateTimeKind.Unspecified).AddTicks(6577), new DateTime(2023, 6, 13, 4, 10, 46, 190, DateTimeKind.Unspecified).AddTicks(2745), 2, null, 28L },
                    { 51L, 136.02m, new DateTime(2022, 5, 26, 15, 11, 47, 588, DateTimeKind.Unspecified).AddTicks(3837), false, "hlzcjv8mdw4u5yyf", new DateTime(2021, 6, 9, 8, 45, 12, 279, DateTimeKind.Unspecified).AddTicks(5445), new DateTime(2019, 12, 27, 10, 21, 54, 592, DateTimeKind.Unspecified).AddTicks(1768), 1, new DateTime(2023, 2, 9, 8, 21, 27, 636, DateTimeKind.Unspecified).AddTicks(2056), 1L },
                    { 52L, 91.86m, new DateTime(2023, 12, 26, 17, 25, 48, 198, DateTimeKind.Unspecified).AddTicks(7694), false, "y089embtn7rxpys0", new DateTime(2023, 4, 16, 3, 12, 52, 417, DateTimeKind.Unspecified).AddTicks(7459), new DateTime(2022, 12, 17, 0, 9, 48, 289, DateTimeKind.Unspecified).AddTicks(4840), 3, new DateTime(2023, 3, 25, 23, 14, 4, 193, DateTimeKind.Unspecified).AddTicks(2307), 18L },
                    { 53L, 136.02m, new DateTime(2023, 8, 1, 8, 3, 1, 965, DateTimeKind.Unspecified).AddTicks(2616), true, "l2cv2onna8ejmz8r", new DateTime(2023, 5, 27, 0, 44, 8, 462, DateTimeKind.Unspecified).AddTicks(7004), new DateTime(2020, 1, 24, 16, 17, 50, 10, DateTimeKind.Unspecified).AddTicks(9254), 1, new DateTime(2020, 3, 11, 16, 18, 20, 508, DateTimeKind.Unspecified).AddTicks(1194), 23L },
                    { 54L, 136.02m, new DateTime(2023, 10, 4, 8, 51, 21, 795, DateTimeKind.Unspecified).AddTicks(5304), true, "gfy34t1jeinb9gqz", new DateTime(2023, 3, 21, 7, 48, 8, 988, DateTimeKind.Unspecified).AddTicks(7826), new DateTime(2022, 11, 3, 10, 49, 57, 588, DateTimeKind.Unspecified).AddTicks(6148), 1, new DateTime(2023, 1, 16, 10, 10, 58, 734, DateTimeKind.Unspecified).AddTicks(9808), 22L },
                    { 55L, 91.86m, new DateTime(2021, 7, 15, 1, 16, 16, 92, DateTimeKind.Unspecified).AddTicks(2915), true, "nzwe7ojkc9empkjg", new DateTime(2021, 3, 18, 0, 43, 37, 175, DateTimeKind.Unspecified).AddTicks(4566), new DateTime(2020, 11, 22, 17, 27, 22, 200, DateTimeKind.Unspecified).AddTicks(7851), 3, new DateTime(2023, 5, 20, 14, 50, 24, 75, DateTimeKind.Unspecified).AddTicks(3306), 8L },
                    { 56L, 136.02m, new DateTime(2023, 9, 16, 21, 8, 55, 854, DateTimeKind.Unspecified).AddTicks(3909), false, "j7d2e9j71hg4xncp", new DateTime(2023, 8, 23, 10, 25, 23, 613, DateTimeKind.Unspecified).AddTicks(1137), new DateTime(2023, 8, 14, 6, 29, 15, 934, DateTimeKind.Unspecified).AddTicks(4129), 1, new DateTime(2023, 8, 15, 8, 12, 9, 56, DateTimeKind.Unspecified).AddTicks(2959), 39L },
                    { 57L, 136.02m, new DateTime(2021, 12, 22, 7, 13, 33, 569, DateTimeKind.Unspecified).AddTicks(6223), false, "l7ao3a4qisuzah62", new DateTime(2021, 11, 6, 11, 43, 21, 722, DateTimeKind.Unspecified).AddTicks(9027), new DateTime(2021, 5, 4, 21, 44, 38, 384, DateTimeKind.Unspecified).AddTicks(6948), 1, new DateTime(2022, 4, 10, 14, 29, 41, 232, DateTimeKind.Unspecified).AddTicks(9131), 30L },
                    { 58L, 91.86m, new DateTime(2022, 7, 1, 19, 4, 9, 706, DateTimeKind.Unspecified).AddTicks(776), true, "if58xh1fxeg6zu3r", new DateTime(2021, 9, 14, 9, 35, 41, 884, DateTimeKind.Unspecified).AddTicks(4258), new DateTime(2021, 6, 13, 20, 36, 20, 985, DateTimeKind.Unspecified).AddTicks(6845), 3, new DateTime(2022, 4, 4, 12, 9, 44, 159, DateTimeKind.Unspecified).AddTicks(2705), 15L },
                    { 59L, 151.37m, new DateTime(2023, 7, 20, 2, 21, 39, 590, DateTimeKind.Unspecified).AddTicks(312), false, "xw8vj1u6nq6o4wt0", new DateTime(2023, 7, 10, 17, 13, 29, 112, DateTimeKind.Unspecified).AddTicks(1693), new DateTime(2022, 8, 27, 12, 21, 55, 17, DateTimeKind.Unspecified).AddTicks(3460), 2, new DateTime(2023, 8, 14, 13, 17, 2, 917, DateTimeKind.Unspecified).AddTicks(4522), 31L },
                    { 60L, 136.02m, new DateTime(2022, 9, 24, 14, 11, 44, 678, DateTimeKind.Unspecified).AddTicks(7929), true, "2tufsfq40oa185wv", new DateTime(2022, 1, 16, 23, 59, 53, 490, DateTimeKind.Unspecified).AddTicks(9013), new DateTime(2021, 7, 17, 14, 31, 56, 919, DateTimeKind.Unspecified).AddTicks(401), 1, new DateTime(2022, 6, 9, 4, 31, 56, 366, DateTimeKind.Unspecified).AddTicks(2715), 23L },
                    { 61L, 136.02m, new DateTime(2023, 12, 4, 23, 48, 6, 998, DateTimeKind.Unspecified).AddTicks(4413), false, "wmcdbjgysdsp6fe8", new DateTime(2023, 4, 24, 3, 46, 37, 471, DateTimeKind.Unspecified).AddTicks(5816), new DateTime(2023, 1, 14, 17, 34, 44, 182, DateTimeKind.Unspecified).AddTicks(9050), 1, new DateTime(2023, 7, 4, 2, 3, 23, 203, DateTimeKind.Unspecified).AddTicks(3112), 40L },
                    { 62L, 151.37m, new DateTime(2023, 10, 27, 11, 4, 55, 163, DateTimeKind.Unspecified).AddTicks(4434), true, "i6bqfv7n7ei52dtg", new DateTime(2023, 6, 17, 12, 4, 47, 641, DateTimeKind.Unspecified).AddTicks(4849), new DateTime(2022, 1, 29, 9, 5, 35, 609, DateTimeKind.Unspecified).AddTicks(3425), 2, new DateTime(2022, 5, 29, 13, 35, 24, 203, DateTimeKind.Unspecified).AddTicks(3123), 10L },
                    { 63L, 136.02m, new DateTime(2024, 5, 23, 19, 45, 33, 722, DateTimeKind.Unspecified).AddTicks(3310), false, "va8nr6u4vqv58pix", new DateTime(2023, 6, 26, 5, 22, 40, 834, DateTimeKind.Unspecified).AddTicks(5882), new DateTime(2022, 11, 22, 18, 7, 27, 861, DateTimeKind.Unspecified).AddTicks(1021), 1, new DateTime(2023, 1, 27, 2, 59, 19, 673, DateTimeKind.Unspecified).AddTicks(3105), 7L },
                    { 64L, 151.37m, new DateTime(2022, 1, 5, 17, 3, 11, 677, DateTimeKind.Unspecified).AddTicks(9568), false, "7779iv8ah6v5mjw1", new DateTime(2021, 7, 8, 22, 31, 43, 542, DateTimeKind.Unspecified).AddTicks(3614), new DateTime(2020, 7, 12, 5, 26, 52, 56, DateTimeKind.Unspecified).AddTicks(6918), 2, new DateTime(2022, 8, 15, 17, 43, 30, 497, DateTimeKind.Unspecified).AddTicks(1442), 23L },
                    { 65L, 151.37m, new DateTime(2023, 8, 27, 1, 49, 54, 301, DateTimeKind.Unspecified).AddTicks(5475), false, "tbp7qw8m3mfjyklz", new DateTime(2022, 10, 29, 10, 44, 25, 563, DateTimeKind.Unspecified).AddTicks(8967), new DateTime(2022, 10, 10, 19, 26, 44, 755, DateTimeKind.Unspecified).AddTicks(4008), 2, new DateTime(2023, 1, 30, 20, 17, 37, 155, DateTimeKind.Unspecified).AddTicks(6732), 21L },
                    { 66L, 136.02m, new DateTime(2023, 9, 17, 6, 47, 6, 17, DateTimeKind.Unspecified).AddTicks(8728), true, "8g7ixv4jzog650kl", new DateTime(2023, 8, 11, 5, 40, 7, 142, DateTimeKind.Unspecified).AddTicks(6669), new DateTime(2016, 7, 30, 0, 2, 47, 975, DateTimeKind.Unspecified).AddTicks(2426), 1, new DateTime(2019, 3, 8, 2, 46, 15, 209, DateTimeKind.Unspecified).AddTicks(6533), 38L },
                    { 67L, 91.86m, new DateTime(2022, 10, 18, 13, 44, 14, 156, DateTimeKind.Unspecified).AddTicks(3598), true, "sbtx06pg02z9opp8", new DateTime(2022, 9, 9, 11, 25, 28, 571, DateTimeKind.Unspecified).AddTicks(3795), new DateTime(2022, 4, 20, 12, 26, 0, 156, DateTimeKind.Unspecified).AddTicks(4284), 3, new DateTime(2022, 11, 10, 13, 14, 36, 308, DateTimeKind.Unspecified).AddTicks(9503), 20L },
                    { 68L, 91.86m, new DateTime(2022, 11, 26, 18, 35, 37, 59, DateTimeKind.Unspecified).AddTicks(1214), true, "z24labjvd7qm17jt", new DateTime(2022, 11, 9, 16, 50, 39, 537, DateTimeKind.Unspecified).AddTicks(102), new DateTime(2022, 10, 14, 20, 34, 11, 76, DateTimeKind.Unspecified).AddTicks(4464), 3, new DateTime(2023, 1, 17, 9, 26, 17, 752, DateTimeKind.Unspecified).AddTicks(1701), 39L },
                    { 69L, 136.02m, new DateTime(2024, 5, 22, 21, 37, 21, 339, DateTimeKind.Unspecified).AddTicks(6695), true, "jti7tswdhcxx146p", new DateTime(2023, 5, 27, 8, 50, 53, 357, DateTimeKind.Unspecified).AddTicks(1440), new DateTime(2023, 3, 9, 17, 55, 18, 409, DateTimeKind.Unspecified).AddTicks(9715), 1, new DateTime(2023, 3, 23, 17, 28, 28, 431, DateTimeKind.Unspecified).AddTicks(8894), 23L },
                    { 70L, 151.37m, new DateTime(2022, 5, 18, 18, 10, 47, 784, DateTimeKind.Unspecified).AddTicks(1132), false, "dqb49qfp6v2htb1l", new DateTime(2022, 2, 3, 20, 26, 59, 546, DateTimeKind.Unspecified).AddTicks(7935), new DateTime(2018, 4, 23, 3, 54, 14, 101, DateTimeKind.Unspecified).AddTicks(7751), 2, new DateTime(2021, 7, 21, 9, 2, 24, 645, DateTimeKind.Unspecified).AddTicks(5545), 13L },
                    { 71L, 136.02m, new DateTime(2023, 4, 28, 7, 37, 14, 976, DateTimeKind.Unspecified).AddTicks(919), true, "tfjxef8gm7u3gr4q", new DateTime(2023, 4, 4, 3, 27, 50, 756, DateTimeKind.Unspecified).AddTicks(7085), new DateTime(2023, 3, 5, 15, 50, 2, 338, DateTimeKind.Unspecified).AddTicks(9867), 1, new DateTime(2023, 6, 30, 2, 34, 31, 422, DateTimeKind.Unspecified).AddTicks(4753), 37L },
                    { 72L, 151.37m, new DateTime(2024, 1, 18, 14, 4, 38, 879, DateTimeKind.Unspecified).AddTicks(6272), false, "2b5myh0ryhbt7haq", new DateTime(2023, 7, 22, 5, 50, 31, 310, DateTimeKind.Unspecified).AddTicks(5501), new DateTime(2023, 6, 5, 13, 11, 37, 218, DateTimeKind.Unspecified).AddTicks(4961), 2, new DateTime(2023, 8, 19, 10, 1, 43, 462, DateTimeKind.Unspecified).AddTicks(3280), 26L },
                    { 73L, 136.02m, new DateTime(2023, 12, 23, 16, 27, 0, 860, DateTimeKind.Unspecified).AddTicks(7013), true, "8ds2vlr4ibv39lh4", new DateTime(2023, 7, 5, 21, 14, 59, 863, DateTimeKind.Unspecified).AddTicks(3058), new DateTime(2020, 10, 3, 22, 48, 2, 113, DateTimeKind.Unspecified).AddTicks(4307), 1, new DateTime(2021, 8, 20, 19, 37, 23, 54, DateTimeKind.Unspecified).AddTicks(9096), 9L },
                    { 74L, 136.02m, new DateTime(2023, 11, 15, 8, 54, 51, 404, DateTimeKind.Unspecified).AddTicks(7795), true, "xzjgtbq46mekoxwc", new DateTime(2023, 4, 2, 21, 44, 55, 189, DateTimeKind.Unspecified).AddTicks(6349), new DateTime(2019, 8, 27, 20, 23, 46, 370, DateTimeKind.Unspecified).AddTicks(6285), 1, new DateTime(2020, 6, 10, 2, 26, 2, 515, DateTimeKind.Unspecified).AddTicks(8001), 30L },
                    { 75L, 91.86m, new DateTime(2023, 9, 3, 12, 1, 50, 915, DateTimeKind.Unspecified).AddTicks(3033), true, "4qdes62xud4v2bb7", new DateTime(2023, 6, 16, 20, 58, 17, 742, DateTimeKind.Unspecified).AddTicks(5860), new DateTime(2023, 2, 17, 17, 9, 56, 0, DateTimeKind.Unspecified).AddTicks(8311), 3, new DateTime(2023, 8, 6, 23, 31, 37, 553, DateTimeKind.Unspecified).AddTicks(2011), 24L },
                    { 76L, 151.37m, new DateTime(2023, 8, 27, 2, 16, 47, 719, DateTimeKind.Unspecified).AddTicks(2780), true, "6s7a0msqiic2ybbz", new DateTime(2022, 10, 31, 19, 25, 14, 431, DateTimeKind.Unspecified).AddTicks(8805), new DateTime(2022, 6, 29, 13, 46, 54, 320, DateTimeKind.Unspecified).AddTicks(8797), 2, new DateTime(2022, 7, 13, 6, 25, 8, 830, DateTimeKind.Unspecified).AddTicks(2876), 23L },
                    { 77L, 151.37m, new DateTime(2022, 9, 21, 19, 49, 18, 621, DateTimeKind.Unspecified).AddTicks(2243), true, "u2bu9ut7a380yrw7", new DateTime(2021, 10, 4, 13, 6, 52, 39, DateTimeKind.Unspecified).AddTicks(90), new DateTime(2019, 6, 6, 12, 19, 24, 72, DateTimeKind.Unspecified).AddTicks(949), 2, new DateTime(2020, 7, 10, 0, 53, 19, 266, DateTimeKind.Unspecified).AddTicks(5478), 24L },
                    { 78L, 136.02m, new DateTime(2023, 9, 16, 11, 51, 56, 193, DateTimeKind.Unspecified).AddTicks(5365), false, "gx2r65g5hsfxbxgo", new DateTime(2023, 8, 18, 0, 43, 30, 661, DateTimeKind.Unspecified).AddTicks(1026), new DateTime(2023, 7, 20, 14, 29, 10, 244, DateTimeKind.Unspecified).AddTicks(4915), 1, null, 28L },
                    { 79L, 136.02m, new DateTime(2021, 4, 12, 14, 4, 37, 562, DateTimeKind.Unspecified).AddTicks(2923), false, "jjpfoqglt2ecr215", new DateTime(2020, 12, 7, 15, 7, 2, 569, DateTimeKind.Unspecified).AddTicks(4201), new DateTime(2020, 5, 31, 14, 58, 53, 487, DateTimeKind.Unspecified).AddTicks(823), 1, new DateTime(2023, 7, 25, 23, 24, 16, 460, DateTimeKind.Unspecified).AddTicks(5198), 27L },
                    { 80L, 91.86m, new DateTime(2022, 6, 5, 22, 0, 37, 263, DateTimeKind.Unspecified).AddTicks(7879), false, "xnuthf65wa7mg0gr", new DateTime(2021, 11, 26, 13, 30, 3, 843, DateTimeKind.Unspecified).AddTicks(4091), new DateTime(2021, 4, 26, 14, 17, 22, 879, DateTimeKind.Unspecified).AddTicks(5685), 3, new DateTime(2021, 7, 29, 17, 19, 45, 650, DateTimeKind.Unspecified).AddTicks(2451), 14L },
                    { 81L, 136.02m, new DateTime(2023, 4, 26, 22, 27, 14, 725, DateTimeKind.Unspecified).AddTicks(4365), false, "3m6zsvfkn1i0vm3e", new DateTime(2022, 6, 17, 17, 55, 30, 30, DateTimeKind.Unspecified).AddTicks(5633), new DateTime(2021, 5, 4, 14, 45, 57, 149, DateTimeKind.Unspecified).AddTicks(4071), 1, new DateTime(2022, 4, 13, 21, 26, 39, 331, DateTimeKind.Unspecified).AddTicks(9570), 36L },
                    { 82L, 151.37m, new DateTime(2024, 2, 17, 16, 50, 59, 776, DateTimeKind.Unspecified).AddTicks(4039), false, "mrtium4tr7pv86d0", new DateTime(2023, 8, 15, 18, 10, 49, 991, DateTimeKind.Unspecified).AddTicks(3411), new DateTime(2023, 8, 10, 14, 4, 5, 4, DateTimeKind.Unspecified).AddTicks(5941), 2, new DateTime(2023, 8, 16, 5, 58, 12, 361, DateTimeKind.Unspecified).AddTicks(9122), 34L },
                    { 83L, 91.86m, new DateTime(2024, 2, 8, 10, 31, 24, 834, DateTimeKind.Unspecified).AddTicks(8332), false, "qpd9nfspxjd01xp0", new DateTime(2023, 3, 11, 17, 31, 11, 402, DateTimeKind.Unspecified).AddTicks(740), new DateTime(2022, 4, 15, 21, 28, 1, 495, DateTimeKind.Unspecified).AddTicks(7616), 3, new DateTime(2022, 8, 6, 7, 26, 55, 549, DateTimeKind.Unspecified).AddTicks(6508), 37L },
                    { 84L, 136.02m, new DateTime(2024, 6, 6, 9, 58, 26, 115, DateTimeKind.Unspecified).AddTicks(5492), false, "wfn8fa46w4r59v5c", new DateTime(2023, 8, 11, 15, 7, 32, 629, DateTimeKind.Unspecified).AddTicks(3239), new DateTime(2023, 7, 14, 6, 0, 55, 11, DateTimeKind.Unspecified).AddTicks(7342), 1, new DateTime(2023, 7, 28, 14, 30, 54, 238, DateTimeKind.Unspecified).AddTicks(6139), 18L },
                    { 85L, 136.02m, new DateTime(2023, 9, 20, 10, 13, 7, 584, DateTimeKind.Unspecified).AddTicks(6626), true, "wyht67sijod7rj9m", new DateTime(2023, 7, 23, 18, 11, 43, 679, DateTimeKind.Unspecified).AddTicks(2101), new DateTime(2022, 4, 15, 16, 10, 9, 565, DateTimeKind.Unspecified).AddTicks(7738), 1, new DateTime(2023, 1, 21, 9, 2, 21, 201, DateTimeKind.Unspecified).AddTicks(2705), 17L },
                    { 86L, 136.02m, new DateTime(2023, 2, 6, 17, 11, 48, 358, DateTimeKind.Unspecified).AddTicks(2576), false, "jx8v9gvjgqbhtb0p", new DateTime(2022, 8, 4, 7, 51, 2, 801, DateTimeKind.Unspecified).AddTicks(7310), new DateTime(2021, 2, 23, 11, 12, 9, 335, DateTimeKind.Unspecified).AddTicks(1430), 1, new DateTime(2023, 6, 29, 22, 44, 47, 750, DateTimeKind.Unspecified).AddTicks(2997), 13L },
                    { 87L, 91.86m, new DateTime(2023, 4, 8, 17, 28, 20, 292, DateTimeKind.Unspecified).AddTicks(167), true, "rcan81qc7fa8yw83", new DateTime(2023, 1, 13, 7, 58, 30, 580, DateTimeKind.Unspecified).AddTicks(426), new DateTime(2023, 1, 5, 22, 36, 28, 716, DateTimeKind.Unspecified).AddTicks(2716), 3, new DateTime(2023, 7, 2, 21, 2, 22, 736, DateTimeKind.Unspecified).AddTicks(1765), 33L },
                    { 88L, 91.86m, new DateTime(2022, 11, 8, 21, 44, 56, 175, DateTimeKind.Unspecified).AddTicks(4102), true, "5emwz6jldc4x58af", new DateTime(2022, 10, 26, 4, 42, 40, 426, DateTimeKind.Unspecified).AddTicks(8388), new DateTime(2022, 4, 24, 18, 54, 17, 176, DateTimeKind.Unspecified).AddTicks(1729), 3, new DateTime(2023, 5, 7, 10, 37, 16, 538, DateTimeKind.Unspecified).AddTicks(2970), 40L },
                    { 89L, 91.86m, new DateTime(2024, 5, 7, 23, 29, 8, 421, DateTimeKind.Unspecified).AddTicks(4275), false, "1hro6jnzj7hueud0", new DateTime(2023, 7, 22, 17, 49, 40, 966, DateTimeKind.Unspecified).AddTicks(2514), new DateTime(2023, 5, 27, 16, 48, 54, 379, DateTimeKind.Unspecified).AddTicks(765), 3, new DateTime(2023, 6, 24, 0, 3, 40, 348, DateTimeKind.Unspecified).AddTicks(2136), 37L }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "Cost", "EndDate", "IsActive", "PaymentSubscriptionId", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate", "UserId" },
                values: new object[,]
                {
                    { 90L, 136.02m, new DateTime(2024, 5, 20, 7, 30, 41, 687, DateTimeKind.Unspecified).AddTicks(7638), true, "jb19he1dn7vheueu", new DateTime(2023, 8, 17, 23, 41, 48, 533, DateTimeKind.Unspecified).AddTicks(4061), new DateTime(2023, 5, 25, 13, 0, 35, 298, DateTimeKind.Unspecified).AddTicks(4982), 1, null, 28L },
                    { 91L, 136.02m, new DateTime(2023, 9, 4, 14, 48, 51, 632, DateTimeKind.Unspecified).AddTicks(7906), true, "l9hcw3mpj65vhei4", new DateTime(2022, 9, 8, 7, 58, 29, 687, DateTimeKind.Unspecified).AddTicks(7541), new DateTime(2022, 6, 12, 16, 1, 43, 342, DateTimeKind.Unspecified).AddTicks(9736), 1, new DateTime(2023, 7, 5, 11, 29, 15, 94, DateTimeKind.Unspecified).AddTicks(3621), 7L },
                    { 92L, 136.02m, new DateTime(2024, 1, 6, 16, 55, 14, 74, DateTimeKind.Unspecified).AddTicks(4379), true, "a0yox0t3avo8xphk", new DateTime(2023, 5, 2, 17, 3, 3, 296, DateTimeKind.Unspecified).AddTicks(3951), new DateTime(2023, 3, 30, 11, 28, 8, 246, DateTimeKind.Unspecified).AddTicks(558), 1, new DateTime(2023, 6, 17, 22, 21, 19, 272, DateTimeKind.Unspecified).AddTicks(5365), 24L },
                    { 93L, 136.02m, new DateTime(2023, 5, 14, 23, 53, 4, 957, DateTimeKind.Unspecified).AddTicks(7516), true, "m8rn9t5pne2v4ysj", new DateTime(2022, 8, 25, 4, 11, 14, 284, DateTimeKind.Unspecified).AddTicks(3655), new DateTime(2021, 2, 8, 4, 54, 0, 925, DateTimeKind.Unspecified).AddTicks(7774), 1, new DateTime(2021, 10, 19, 16, 41, 38, 586, DateTimeKind.Unspecified).AddTicks(6285), 15L },
                    { 94L, 91.86m, new DateTime(2023, 3, 3, 7, 37, 7, 929, DateTimeKind.Unspecified).AddTicks(2064), false, "mmluyddqoo1o85th", new DateTime(2022, 7, 16, 16, 58, 25, 336, DateTimeKind.Unspecified).AddTicks(1739), new DateTime(2021, 4, 11, 11, 46, 10, 239, DateTimeKind.Unspecified).AddTicks(4452), 3, new DateTime(2022, 9, 8, 8, 41, 25, 649, DateTimeKind.Unspecified).AddTicks(7258), 30L },
                    { 95L, 136.02m, new DateTime(2023, 5, 5, 0, 46, 50, 940, DateTimeKind.Unspecified).AddTicks(1331), true, "cevlzqkc2a1n7br9", new DateTime(2022, 6, 11, 15, 19, 9, 158, DateTimeKind.Unspecified).AddTicks(224), new DateTime(2021, 6, 8, 7, 24, 3, 672, DateTimeKind.Unspecified).AddTicks(4441), 1, new DateTime(2021, 9, 2, 23, 42, 7, 60, DateTimeKind.Unspecified).AddTicks(6268), 2L },
                    { 96L, 91.86m, new DateTime(2023, 9, 11, 13, 50, 43, 362, DateTimeKind.Unspecified).AddTicks(8068), true, "93vrpnu06yhjisrx", new DateTime(2023, 7, 31, 6, 14, 53, 344, DateTimeKind.Unspecified).AddTicks(3345), new DateTime(2022, 7, 28, 14, 15, 36, 433, DateTimeKind.Unspecified).AddTicks(5919), 3, new DateTime(2022, 10, 3, 16, 40, 52, 317, DateTimeKind.Unspecified).AddTicks(6484), 5L },
                    { 97L, 136.02m, new DateTime(2023, 6, 23, 11, 13, 56, 979, DateTimeKind.Unspecified).AddTicks(6144), true, "7biaezr83ocwvtne", new DateTime(2022, 8, 29, 21, 55, 13, 727, DateTimeKind.Unspecified).AddTicks(9230), new DateTime(2022, 4, 23, 23, 54, 34, 456, DateTimeKind.Unspecified).AddTicks(7609), 1, new DateTime(2022, 8, 2, 7, 57, 48, 789, DateTimeKind.Unspecified).AddTicks(7898), 19L },
                    { 98L, 136.02m, new DateTime(2023, 10, 18, 16, 2, 25, 8, DateTimeKind.Unspecified).AddTicks(9614), true, "k9c7hc23tgje5jm7", new DateTime(2023, 5, 12, 12, 19, 13, 143, DateTimeKind.Unspecified).AddTicks(7539), new DateTime(2021, 11, 21, 4, 6, 25, 936, DateTimeKind.Unspecified).AddTicks(377), 1, new DateTime(2023, 5, 25, 6, 3, 33, 148, DateTimeKind.Unspecified).AddTicks(1662), 8L },
                    { 99L, 136.02m, new DateTime(2020, 5, 15, 17, 25, 16, 222, DateTimeKind.Unspecified).AddTicks(2402), false, "17h3p0lzj9p4mkrq", new DateTime(2020, 2, 11, 14, 11, 20, 885, DateTimeKind.Unspecified).AddTicks(3857), new DateTime(2017, 9, 19, 16, 41, 2, 93, DateTimeKind.Unspecified).AddTicks(5187), 1, new DateTime(2019, 3, 31, 20, 49, 25, 299, DateTimeKind.Unspecified).AddTicks(1389), 24L },
                    { 100L, 151.37m, new DateTime(2024, 5, 20, 17, 3, 14, 32, DateTimeKind.Unspecified).AddTicks(8846), false, "ea2krxtp615avzdt", new DateTime(2023, 7, 23, 22, 34, 43, 412, DateTimeKind.Unspecified).AddTicks(8422), new DateTime(2022, 12, 6, 9, 31, 51, 746, DateTimeKind.Unspecified).AddTicks(4133), 2, new DateTime(2023, 4, 14, 22, 50, 36, 844, DateTimeKind.Unspecified).AddTicks(4703), 35L },
                    { 101L, 136.02m, new DateTime(2023, 12, 29, 22, 22, 47, 498, DateTimeKind.Unspecified).AddTicks(1622), false, "hp86so1sykofx18m", new DateTime(2023, 7, 31, 10, 22, 26, 783, DateTimeKind.Unspecified).AddTicks(4284), new DateTime(2023, 6, 27, 7, 59, 31, 435, DateTimeKind.Unspecified).AddTicks(6458), 1, new DateTime(2023, 7, 24, 15, 55, 36, 637, DateTimeKind.Unspecified).AddTicks(6638), 19L },
                    { 102L, 151.37m, new DateTime(2023, 1, 31, 6, 9, 42, 292, DateTimeKind.Unspecified).AddTicks(5147), false, "v9jped3wpf21omxi", new DateTime(2022, 10, 11, 7, 13, 56, 692, DateTimeKind.Unspecified).AddTicks(2095), new DateTime(2022, 5, 28, 16, 18, 47, 835, DateTimeKind.Unspecified).AddTicks(151), 2, new DateTime(2023, 8, 9, 23, 1, 48, 175, DateTimeKind.Unspecified).AddTicks(110), 40L },
                    { 103L, 91.86m, new DateTime(2024, 3, 5, 17, 27, 41, 538, DateTimeKind.Unspecified).AddTicks(653), false, "a7ftky80unai4cdk", new DateTime(2023, 3, 19, 11, 27, 41, 747, DateTimeKind.Unspecified).AddTicks(1066), new DateTime(2022, 10, 3, 18, 17, 16, 607, DateTimeKind.Unspecified).AddTicks(4367), 3, new DateTime(2022, 12, 12, 5, 12, 44, 743, DateTimeKind.Unspecified).AddTicks(284), 20L },
                    { 104L, 136.02m, new DateTime(2021, 5, 31, 4, 13, 14, 527, DateTimeKind.Unspecified).AddTicks(4856), false, "2fl25kawdqe7y9cr", new DateTime(2021, 1, 27, 11, 22, 35, 271, DateTimeKind.Unspecified).AddTicks(2140), new DateTime(2020, 12, 28, 12, 7, 59, 269, DateTimeKind.Unspecified).AddTicks(384), 1, new DateTime(2022, 2, 1, 9, 54, 54, 147, DateTimeKind.Unspecified).AddTicks(3422), 8L },
                    { 105L, 151.37m, new DateTime(2023, 3, 13, 22, 57, 38, 88, DateTimeKind.Unspecified).AddTicks(2045), true, "yrti9du39mr5c5va", new DateTime(2022, 4, 5, 2, 1, 49, 245, DateTimeKind.Unspecified).AddTicks(7691), new DateTime(2021, 5, 24, 16, 42, 5, 969, DateTimeKind.Unspecified).AddTicks(7030), 2, new DateTime(2021, 10, 18, 20, 49, 24, 389, DateTimeKind.Unspecified).AddTicks(5167), 14L },
                    { 106L, 136.02m, new DateTime(2023, 12, 29, 17, 22, 47, 760, DateTimeKind.Unspecified).AddTicks(8886), true, "fybw1xhn0y3drrm0", new DateTime(2023, 6, 25, 5, 3, 51, 774, DateTimeKind.Unspecified).AddTicks(9556), new DateTime(2023, 5, 25, 17, 58, 46, 597, DateTimeKind.Unspecified).AddTicks(6917), 1, new DateTime(2023, 6, 13, 1, 4, 22, 30, DateTimeKind.Unspecified).AddTicks(7486), 36L },
                    { 107L, 136.02m, new DateTime(2019, 11, 2, 6, 50, 51, 976, DateTimeKind.Unspecified).AddTicks(5684), false, "6voy90ps5l3b1y1b", new DateTime(2019, 10, 6, 18, 19, 35, 394, DateTimeKind.Unspecified).AddTicks(8130), new DateTime(2017, 2, 10, 16, 19, 59, 787, DateTimeKind.Unspecified).AddTicks(3276), 1, new DateTime(2020, 5, 7, 13, 44, 7, 232, DateTimeKind.Unspecified).AddTicks(8035), 6L },
                    { 108L, 136.02m, new DateTime(2022, 12, 16, 19, 7, 47, 889, DateTimeKind.Unspecified).AddTicks(5293), false, "r4im89p8kap58jd0", new DateTime(2022, 4, 11, 21, 1, 50, 900, DateTimeKind.Unspecified).AddTicks(2129), new DateTime(2022, 1, 2, 10, 37, 30, 406, DateTimeKind.Unspecified).AddTicks(1758), 1, new DateTime(2022, 7, 8, 5, 47, 26, 627, DateTimeKind.Unspecified).AddTicks(8667), 10L },
                    { 109L, 91.86m, new DateTime(2023, 8, 19, 2, 32, 45, 958, DateTimeKind.Unspecified).AddTicks(7894), false, "9l7e2zypb364i3jv", new DateTime(2023, 5, 21, 17, 1, 3, 52, DateTimeKind.Unspecified).AddTicks(2170), new DateTime(2022, 7, 31, 2, 52, 59, 342, DateTimeKind.Unspecified).AddTicks(7411), 3, new DateTime(2023, 7, 11, 7, 56, 7, 544, DateTimeKind.Unspecified).AddTicks(9676), 35L },
                    { 110L, 136.02m, new DateTime(2023, 8, 9, 4, 45, 52, 276, DateTimeKind.Unspecified).AddTicks(6681), true, "p45radwg6kdm2a5k", new DateTime(2023, 4, 4, 14, 28, 42, 862, DateTimeKind.Unspecified).AddTicks(4195), new DateTime(2023, 3, 13, 15, 30, 17, 12, DateTimeKind.Unspecified).AddTicks(2737), 1, new DateTime(2023, 4, 23, 14, 37, 34, 951, DateTimeKind.Unspecified).AddTicks(721), 14L }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[,]
                {
                    { 1L, 59L, "Doloribus modi voluptatum facere eius rerum provident nemo soluta quidem.", new DateTime(2023, 7, 20, 19, 9, 31, 564, DateTimeKind.Unspecified).AddTicks(5216), 12L, "Eos quae aliquid qui est sit quidem doloribus.", 2, 1 },
                    { 2L, 38L, "Est aut repellendus qui fugit.", new DateTime(2022, 5, 28, 4, 47, 2, 296, DateTimeKind.Unspecified).AddTicks(3373), 4L, "Iusto aut nesciunt modi et quibusdam.", 3, 0 },
                    { 3L, 8L, "Omnis inventore velit.\nMaxime fuga fugiat eos.\nAdipisci id dolores et fugit vero vitae.", new DateTime(2023, 3, 29, 11, 48, 58, 864, DateTimeKind.Unspecified).AddTicks(7004), 8L, "Consequuntur alias ipsam quo alias et quisquam voluptates.", 1, 0 },
                    { 4L, 21L, "Nam omnis est magnam rerum eum repudiandae minima tenetur quis. Reprehenderit accusamus dolore est ratione maiores. Et perspiciatis sequi minima pariatur dignissimos eum. Dolorum qui cum voluptatibus quibusdam corporis saepe dolores. Error magni eum dolore minima amet. Temporibus esse magni nihil est officiis ducimus aut dolorem sit.", new DateTime(2023, 1, 27, 11, 51, 21, 767, DateTimeKind.Unspecified).AddTicks(6593), 16L, "Et vel voluptatum quia quia nesciunt sequi impedit.", 1, 3 },
                    { 5L, 43L, "Et id nulla nesciunt. Nesciunt minima cupiditate. Dolore corrupti iusto ipsam sapiente. Maxime alias nam.", new DateTime(2023, 7, 22, 13, 53, 6, 512, DateTimeKind.Unspecified).AddTicks(6654), 24L, "Accusamus magnam quia laudantium id.", 4, 0 },
                    { 6L, 59L, "Corporis illum molestiae hic et officiis accusantium nostrum. Aut et error itaque animi eveniet ut delectus voluptates dolorem. Laudantium itaque sequi officiis sapiente et.", new DateTime(2022, 5, 3, 23, 34, 5, 229, DateTimeKind.Unspecified).AddTicks(2), 7L, "Et pariatur sapiente.", 2, 1 },
                    { 7L, 57L, "Non porro impedit.", new DateTime(2021, 12, 15, 13, 39, 29, 985, DateTimeKind.Unspecified).AddTicks(4360), 27L, "Blanditiis quidem earum tempore molestias.", 3, 2 },
                    { 8L, 53L, "Sit molestiae adipisci repellat eum vel dolorum aut ullam distinctio.\nOmnis animi officiis tenetur.", new DateTime(2019, 7, 7, 8, 39, 29, 872, DateTimeKind.Unspecified).AddTicks(4090), 15L, "Fugit mollitia aut ab eum est quaerat consequatur.", 3, 1 },
                    { 9L, 27L, "qui", new DateTime(2022, 4, 30, 22, 43, 59, 805, DateTimeKind.Unspecified).AddTicks(3571), 1L, "Dolore possimus quisquam optio veniam.", 4, 2 },
                    { 10L, 3L, "unde", new DateTime(2023, 3, 24, 14, 7, 1, 777, DateTimeKind.Unspecified).AddTicks(1074), 34L, "Sit repellendus cupiditate quo quo doloribus.", 2, 3 },
                    { 11L, 16L, "Soluta est libero voluptatum ullam unde libero dolorem voluptatem et.", new DateTime(2023, 2, 12, 2, 42, 33, 122, DateTimeKind.Unspecified).AddTicks(7841), 9L, "Officiis eos molestias explicabo.", 1, 1 },
                    { 12L, 51L, "omnis", new DateTime(2023, 8, 23, 3, 52, 21, 972, DateTimeKind.Unspecified).AddTicks(5535), 35L, "Modi eaque iusto commodi.", 4, 3 },
                    { 13L, 38L, "Voluptatem et veniam iusto rerum.", new DateTime(2021, 11, 10, 19, 12, 8, 797, DateTimeKind.Unspecified).AddTicks(8297), 14L, "Culpa maiores officiis deleniti cumque similique optio et sed ab.", 3, 0 },
                    { 14L, 43L, "Nihil officia minima quae id occaecati quod.", new DateTime(2023, 8, 6, 15, 19, 27, 982, DateTimeKind.Unspecified).AddTicks(2620), 7L, "Totam expedita hic vel sint rerum earum facilis.", 3, 0 },
                    { 15L, 51L, "Itaque quidem debitis nisi voluptate. Placeat facere omnis ea quia ea voluptatibus id laborum. Consequatur iure nisi voluptatem temporibus.", new DateTime(2023, 5, 19, 15, 1, 3, 247, DateTimeKind.Unspecified).AddTicks(4431), 19L, "Ipsa sequi voluptatum qui.", 3, 2 },
                    { 16L, 65L, "Recusandae rerum dolor assumenda maiores placeat magnam debitis.\nFacilis velit et qui totam et iusto consequatur ut.", new DateTime(2020, 11, 27, 4, 46, 4, 809, DateTimeKind.Unspecified).AddTicks(6876), 35L, "Et expedita dignissimos et neque atque aut.", 2, 0 },
                    { 17L, 28L, "Perspiciatis dolorum architecto placeat. Eum aut repellendus laudantium est cumque velit. Voluptatum fugiat aut. Est voluptatum natus sed qui. Inventore beatae totam et necessitatibus velit. Et pariatur voluptas veniam rerum.", new DateTime(2022, 3, 12, 19, 50, 34, 894, DateTimeKind.Unspecified).AddTicks(3185), 35L, "Nulla explicabo suscipit molestiae perferendis.", 1, 1 },
                    { 18L, 7L, "Quis dignissimos ipsam et in dolores perferendis.", new DateTime(2022, 12, 1, 0, 35, 39, 296, DateTimeKind.Unspecified).AddTicks(2383), 37L, "Dolorum praesentium blanditiis quia commodi non quis voluptatem.", 3, 1 },
                    { 19L, 24L, "Ab at at dolorem qui nobis doloremque.\nQuo aliquam omnis et illo voluptas culpa ea ducimus ea.\nEt eum est est neque qui.\nVoluptatem unde voluptatem non.\nDolor et dolor molestias et officia.", new DateTime(2021, 9, 1, 23, 15, 37, 946, DateTimeKind.Unspecified).AddTicks(5345), 5L, "Et at iusto illum.", 2, 2 },
                    { 20L, 67L, "Vitae eligendi consequatur laboriosam commodi atque.\nDolor eos est repellat enim aliquam ratione.", new DateTime(2023, 8, 22, 3, 40, 22, 193, DateTimeKind.Unspecified).AddTicks(4896), 31L, "Voluptas et quis voluptatem autem voluptas ducimus maiores praesentium odit.", 4, 0 },
                    { 21L, 29L, "Rerum recusandae cum et officia odit aliquid saepe corrupti. Aliquid dolorum iste quia voluptatibus dolores nostrum ab quia dolor. Doloremque odio suscipit animi recusandae quo voluptatem odio.", new DateTime(2023, 6, 16, 1, 54, 31, 377, DateTimeKind.Unspecified).AddTicks(2097), 11L, "Est recusandae aliquam provident molestiae.", 2, 1 },
                    { 22L, 58L, "Cumque sint tenetur sed et.", new DateTime(2023, 7, 14, 16, 56, 38, 772, DateTimeKind.Unspecified).AddTicks(5389), 10L, "Non aspernatur recusandae soluta ratione quibusdam et totam voluptatem.", 4, 0 },
                    { 23L, 25L, "qui", new DateTime(2023, 1, 26, 5, 48, 51, 173, DateTimeKind.Unspecified).AddTicks(6194), 14L, "Laboriosam totam expedita reprehenderit sed blanditiis.", 4, 3 },
                    { 24L, 38L, "Natus esse sint magnam incidunt velit adipisci voluptatem.", new DateTime(2020, 5, 20, 20, 12, 41, 671, DateTimeKind.Unspecified).AddTicks(4884), 10L, "Ea consequatur aut.", 1, 2 },
                    { 25L, 24L, "Ut vitae aut molestias. Expedita provident ex beatae nihil numquam nihil adipisci consequatur. Dolor quae sit consequuntur. Esse et veniam saepe nisi eius. Labore aut aut molestiae quaerat iure voluptatem exercitationem ut. Doloremque facere similique molestiae error.", new DateTime(2022, 8, 27, 23, 31, 37, 812, DateTimeKind.Unspecified).AddTicks(9565), 25L, "Iusto possimus laudantium accusantium possimus mollitia totam blanditiis odio corrupti.", 2, 0 },
                    { 26L, 13L, "Doloribus dolorem et accusamus nostrum aliquam aut repellat tenetur.", new DateTime(2022, 2, 6, 0, 22, 31, 676, DateTimeKind.Unspecified).AddTicks(9093), 37L, "Voluptas tempore reprehenderit nesciunt et dignissimos omnis.", 1, 2 },
                    { 27L, 60L, "Facilis quod expedita adipisci voluptates molestiae qui ut qui rerum. Perferendis iusto ea et quia. Harum nemo aliquam suscipit exercitationem error iure rerum. Et autem culpa nemo delectus voluptates.", new DateTime(2023, 8, 4, 23, 40, 42, 576, DateTimeKind.Unspecified).AddTicks(1103), 17L, "In iste voluptatum.", 1, 1 },
                    { 28L, 39L, "Sequi blanditiis vero.", new DateTime(2021, 2, 20, 16, 56, 43, 807, DateTimeKind.Unspecified).AddTicks(1131), 25L, "Vel dolorem occaecati minus natus explicabo repudiandae optio.", 4, 0 },
                    { 29L, 69L, "nobis", new DateTime(2023, 6, 13, 4, 43, 12, 301, DateTimeKind.Unspecified).AddTicks(6827), 40L, "Ut enim atque amet.", 1, 1 },
                    { 30L, 12L, "Minus id minus rem voluptatum amet.", new DateTime(2023, 6, 16, 3, 53, 29, 20, DateTimeKind.Unspecified).AddTicks(4490), 6L, "Odio ratione voluptatem.", 4, 0 },
                    { 31L, 37L, "Consequatur eveniet quidem enim quae voluptatum fugit error. Aut veritatis quo nemo fugiat deserunt veritatis ad. Et nihil autem.", new DateTime(2022, 4, 13, 23, 56, 12, 344, DateTimeKind.Unspecified).AddTicks(2858), 40L, "Commodi perferendis ut.", 1, 0 },
                    { 32L, 44L, "Quam iste aliquam ex repudiandae atque beatae odit excepturi.", new DateTime(2023, 3, 6, 20, 19, 57, 101, DateTimeKind.Unspecified).AddTicks(6754), 13L, "At maiores aut aliquid perferendis adipisci odio expedita.", 4, 2 },
                    { 33L, 37L, "Voluptas corrupti voluptas quaerat in minus provident.", new DateTime(2021, 4, 18, 3, 54, 59, 862, DateTimeKind.Unspecified).AddTicks(2747), 8L, "Vel ut repudiandae et.", 1, 3 },
                    { 34L, 43L, "Repudiandae voluptatum quod sit voluptas nobis. Magni harum expedita non. Voluptatibus tempora explicabo quasi esse aspernatur. Facere perspiciatis inventore asperiores hic. Nostrum dicta rerum omnis voluptatem consectetur.", new DateTime(2023, 8, 16, 23, 13, 48, 851, DateTimeKind.Unspecified).AddTicks(2061), 29L, "At praesentium ea ut.", 1, 3 },
                    { 35L, 35L, "Omnis iure rerum magnam perspiciatis necessitatibus et vero deleniti autem. Eaque animi ut consequatur laborum laudantium quos. Inventore cupiditate labore voluptas officia neque ducimus aliquam eos. Dolores est tempore doloremque aspernatur consequuntur autem beatae.", new DateTime(2023, 7, 5, 14, 43, 3, 211, DateTimeKind.Unspecified).AddTicks(9642), 1L, "Dolorem recusandae necessitatibus dolores ea velit vero laboriosam.", 4, 2 },
                    { 36L, 60L, "et", new DateTime(2022, 8, 11, 7, 33, 11, 846, DateTimeKind.Unspecified).AddTicks(1403), 8L, "Hic dolore eveniet nostrum voluptatem.", 2, 3 },
                    { 37L, 38L, "Et consequatur et eius.", new DateTime(2018, 3, 16, 17, 25, 37, 552, DateTimeKind.Unspecified).AddTicks(6457), 1L, "Veritatis ex sunt aspernatur quidem voluptas non.", 4, 2 },
                    { 38L, 51L, "Sequi aut aut nulla quod.", new DateTime(2022, 12, 24, 22, 27, 53, 227, DateTimeKind.Unspecified).AddTicks(1790), 26L, "Cum et autem.", 4, 3 },
                    { 39L, 66L, "Laboriosam saepe temporibus non ipsa ut accusamus voluptas eos.\nRepellendus expedita est perferendis.", new DateTime(2022, 1, 9, 21, 29, 58, 381, DateTimeKind.Unspecified).AddTicks(1825), 27L, "Quisquam at reprehenderit beatae magnam.", 4, 2 },
                    { 40L, 52L, "Temporibus quae fugiat.\nConsequatur quis commodi ipsum veritatis in officiis.\nAt cum nulla rerum fuga impedit doloremque qui unde deserunt.\nEt aliquid ratione quisquam molestiae.\nCommodi qui velit incidunt nulla.", new DateTime(2023, 3, 15, 2, 13, 41, 723, DateTimeKind.Unspecified).AddTicks(8040), 4L, "Quam consectetur ipsum et et soluta vel.", 2, 3 },
                    { 41L, 14L, "Sit libero inventore odit facilis nesciunt.", new DateTime(2022, 5, 31, 1, 34, 40, 670, DateTimeKind.Unspecified).AddTicks(7114), 17L, "In ea animi autem qui dolores.", 2, 3 },
                    { 42L, 50L, "quia", new DateTime(2022, 8, 24, 23, 37, 46, 756, DateTimeKind.Unspecified).AddTicks(3647), 35L, "Est odio vero optio consequuntur tempore est consequatur nemo.", 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[,]
                {
                    { 43L, 68L, "autem", new DateTime(2022, 8, 17, 20, 23, 35, 510, DateTimeKind.Unspecified).AddTicks(5974), 33L, "Rem cumque at consequatur tempora et facilis corporis ut iste.", 1, 1 },
                    { 44L, 48L, "Et veniam veniam quia nemo cumque.\nAb nihil sed non qui omnis.\nEt harum dolores.\nOptio quisquam omnis est.", new DateTime(2022, 9, 12, 18, 51, 59, 836, DateTimeKind.Unspecified).AddTicks(4895), 33L, "Dolores quas ut nam illo consequatur sit amet repudiandae.", 3, 0 },
                    { 45L, 35L, "autem", new DateTime(2023, 8, 12, 5, 4, 28, 316, DateTimeKind.Unspecified).AddTicks(5638), 4L, "Deleniti eaque doloribus.", 4, 3 },
                    { 46L, 13L, "Ab est pariatur autem pariatur nostrum unde animi. Et illo ea. Iure unde fugit animi quo et dolorem.", new DateTime(2021, 9, 28, 14, 9, 45, 872, DateTimeKind.Unspecified).AddTicks(8113), 40L, "Quisquam quam aspernatur vel animi nostrum molestias necessitatibus.", 3, 1 },
                    { 47L, 4L, "Eius dolore repellat sunt velit labore dolores nulla nesciunt libero. Cupiditate doloribus ab. Et ab enim consequatur. Debitis quis officiis quos. Saepe voluptate quia ut culpa ut. Autem in sit accusamus animi maxime molestiae.", new DateTime(2022, 7, 5, 2, 0, 15, 724, DateTimeKind.Unspecified).AddTicks(2096), 13L, "Qui eos reprehenderit culpa sint impedit.", 3, 1 },
                    { 48L, 49L, "Atque dolorum odit non quis molestias.\nCorporis fugiat quis nemo culpa voluptatem omnis minus.\nQuisquam nemo corporis corporis rerum dolor sed.\nSapiente error dolore praesentium quos quia asperiores.\nImpedit tenetur voluptatem ipsum nostrum in dolores explicabo quae.\nFacere possimus sit maxime.", new DateTime(2023, 3, 31, 3, 51, 21, 117, DateTimeKind.Unspecified).AddTicks(9134), 33L, "Recusandae ea dicta numquam.", 4, 0 },
                    { 49L, 22L, "Odio officiis consequatur non natus. Voluptatem vel non quaerat omnis. Ea provident eius. Iste quaerat cum a dicta et ratione. Ipsam libero id iusto nobis fugiat.", new DateTime(2023, 6, 29, 22, 2, 41, 611, DateTimeKind.Unspecified).AddTicks(1678), 19L, "Consequatur error molestias nihil quas omnis delectus consequatur quaerat labore.", 4, 0 },
                    { 50L, 27L, "Maxime ut cumque.\nDolores unde non earum qui et non saepe natus rerum.", new DateTime(2023, 2, 11, 8, 50, 8, 715, DateTimeKind.Unspecified).AddTicks(2199), 18L, "Fuga neque quidem excepturi ipsa explicabo nesciunt nemo placeat.", 1, 1 },
                    { 51L, 23L, "Porro est qui magni eum dolor optio.\nQuidem qui cumque hic maxime.\nNesciunt delectus omnis vero corporis eveniet et et in quis.\nEa ut quidem eius animi.\nTempora in consequatur voluptas velit cum dolore dolorum ut vitae.", new DateTime(2023, 7, 25, 9, 22, 45, 197, DateTimeKind.Unspecified).AddTicks(6951), 10L, "Tenetur ut hic qui dolorum dolorem repudiandae doloribus laboriosam quo.", 3, 0 },
                    { 52L, 15L, "dolorem", new DateTime(2021, 5, 4, 12, 40, 10, 246, DateTimeKind.Unspecified).AddTicks(5947), 2L, "Non possimus voluptatem natus voluptatibus iure quod veniam et nostrum.", 2, 0 },
                    { 53L, 34L, "Ut eaque vel animi placeat adipisci eaque.", new DateTime(2023, 4, 5, 23, 20, 44, 412, DateTimeKind.Unspecified).AddTicks(3994), 36L, "Rem autem vel aut sapiente.", 4, 3 },
                    { 54L, 36L, "consectetur", new DateTime(2022, 5, 2, 15, 39, 33, 770, DateTimeKind.Unspecified).AddTicks(1015), 7L, "Voluptates voluptas fugiat.", 4, 1 },
                    { 55L, 8L, "Aut quibusdam minus doloremque maxime aliquid. Nobis ut explicabo consequuntur delectus maiores blanditiis sit quo asperiores. Harum ut ullam et ab.", new DateTime(2023, 4, 25, 16, 58, 43, 937, DateTimeKind.Unspecified).AddTicks(9515), 40L, "Laborum veniam hic.", 4, 0 },
                    { 56L, 10L, "In quis vel iure blanditiis dolorem mollitia quo est quis.", new DateTime(2018, 7, 12, 17, 56, 5, 818, DateTimeKind.Unspecified).AddTicks(1524), 8L, "Totam dolore voluptatem repellendus doloribus et beatae laudantium aut neque.", 3, 2 },
                    { 57L, 55L, "Et aut autem maiores sit qui et eveniet harum labore. Est sint iure tenetur numquam dolor. Quia dolore temporibus rem suscipit excepturi dicta quas.", new DateTime(2023, 8, 21, 13, 26, 14, 802, DateTimeKind.Unspecified).AddTicks(926), 35L, "Tenetur molestiae distinctio commodi dolores optio iusto pariatur.", 1, 2 },
                    { 58L, 38L, "Unde molestias natus ad quod. Dolor atque quaerat quia quod recusandae quia voluptas assumenda et. Soluta sit at velit repellendus ad accusamus autem facere deserunt. Illum aut modi quia. Quos molestiae dolorem hic consequatur. Voluptatem mollitia eius deserunt possimus repellendus laboriosam a laudantium.", new DateTime(2023, 7, 12, 16, 43, 16, 208, DateTimeKind.Unspecified).AddTicks(4205), 30L, "Ad dolorem autem minus in ullam quam.", 4, 1 },
                    { 59L, 2L, "Eum sapiente libero vel voluptatibus et deserunt porro ea earum.\nSunt sint accusamus aliquam reiciendis consectetur sint dicta eaque autem.\nAliquam minima atque atque.\nQuis reprehenderit neque mollitia.\nRepudiandae est assumenda harum omnis.\nOmnis dolorem placeat et.", new DateTime(2023, 6, 13, 15, 42, 20, 137, DateTimeKind.Unspecified).AddTicks(1053), 13L, "Aut omnis incidunt.", 1, 2 },
                    { 60L, 46L, "Adipisci aliquam impedit iure saepe dolores voluptatum corporis voluptas.\nUt expedita dolor qui.\nDolorum molestiae reiciendis.\nSint quis omnis et incidunt distinctio dolor distinctio.\nQuos ut deserunt.", new DateTime(2023, 5, 3, 10, 46, 34, 296, DateTimeKind.Unspecified).AddTicks(5140), 24L, "Quibusdam quia sunt.", 4, 0 },
                    { 61L, 5L, "Eligendi mollitia aut est.\nRerum amet voluptatum qui porro fugiat dignissimos.", new DateTime(2022, 12, 20, 8, 48, 36, 77, DateTimeKind.Unspecified).AddTicks(5757), 19L, "Neque voluptatem minima eligendi ducimus repudiandae dolorem tempore delectus consequuntur.", 4, 2 },
                    { 62L, 70L, "Voluptas quidem labore iste.\nIllo maiores sit ipsam sunt repellat et delectus.\nItaque voluptas ducimus iusto id dignissimos.\nHarum vero dolor sed.", new DateTime(2023, 7, 8, 21, 12, 51, 698, DateTimeKind.Unspecified).AddTicks(8733), 17L, "Error officia optio ut.", 4, 0 },
                    { 63L, 36L, "Pariatur nihil et atque est error ipsa facilis. Voluptatem dolore eum illo voluptatem reiciendis quia. Inventore ex minus illo accusamus mollitia fugiat ratione veritatis.", new DateTime(2022, 10, 12, 13, 20, 37, 82, DateTimeKind.Unspecified).AddTicks(7722), 38L, "Itaque excepturi praesentium qui alias hic.", 2, 2 },
                    { 64L, 7L, "Corrupti neque ut mollitia aut.\nDeleniti cupiditate modi necessitatibus error corporis.\nVoluptatibus eum libero laboriosam officia dolorem sed.\nEst rerum porro et fugit molestiae sequi quasi velit cupiditate.\nVel cumque vel iusto mollitia unde dolor et.\nTempora porro atque.", new DateTime(2023, 8, 21, 11, 25, 37, 543, DateTimeKind.Unspecified).AddTicks(8883), 25L, "In itaque deserunt dolorem dolores quis provident.", 4, 1 },
                    { 65L, 35L, "Dolorem voluptas veritatis voluptas qui vel consequatur.", new DateTime(2023, 2, 11, 16, 29, 13, 330, DateTimeKind.Unspecified).AddTicks(8119), 24L, "Aperiam rerum rem eum blanditiis et.", 4, 3 },
                    { 66L, 47L, "In possimus sit temporibus vel nesciunt id autem culpa et.\nEt in nesciunt beatae vel velit.\nOptio omnis et sed aut est esse perferendis animi.\nLabore sed quia accusamus temporibus eum.\nOmnis fugiat reiciendis dolore dolorem pariatur iusto repellendus laborum.", new DateTime(2023, 8, 19, 18, 32, 14, 412, DateTimeKind.Unspecified).AddTicks(3475), 10L, "Autem voluptate voluptatem.", 1, 0 },
                    { 67L, 21L, "Et natus sed dolores ipsa.\nIste blanditiis placeat.\nVoluptatem perspiciatis iusto mollitia provident.\nRem sit et unde placeat doloribus consequatur voluptate eum perspiciatis.\nIllo eveniet omnis deserunt sed aut est dignissimos id.", new DateTime(2022, 9, 11, 15, 36, 43, 286, DateTimeKind.Unspecified).AddTicks(4584), 24L, "Asperiores quam illum necessitatibus et veniam.", 3, 2 },
                    { 68L, 1L, "Sapiente mollitia hic ratione quia.\nConsequatur consectetur quibusdam nemo et et et.\nMaiores eligendi velit iusto eum voluptatem molestiae.\nIpsum officia et quae sed.\nNihil minus sapiente voluptatibus delectus est recusandae neque.\nAut recusandae maiores harum esse nulla doloribus dolore.", new DateTime(2022, 6, 16, 8, 59, 25, 608, DateTimeKind.Unspecified).AddTicks(2693), 12L, "Enim rerum tempore et.", 2, 2 },
                    { 69L, 25L, "Magni dicta explicabo assumenda.", new DateTime(2023, 6, 24, 11, 9, 16, 902, DateTimeKind.Unspecified).AddTicks(5489), 12L, "Et qui tempore ex cum molestiae.", 1, 2 },
                    { 70L, 12L, "Laboriosam officia ipsa debitis.", new DateTime(2023, 5, 22, 11, 4, 15, 794, DateTimeKind.Unspecified).AddTicks(4550), 22L, "Qui illo tempora et nulla sint molestias.", 2, 1 },
                    { 71L, 38L, "Est repellendus est qui illo ad aperiam. Velit et non rerum sequi nulla. Dolore voluptatem quidem dicta. Distinctio mollitia et consequatur. Maiores enim commodi dicta omnis. Optio earum reiciendis eos et provident.", new DateTime(2023, 6, 14, 19, 53, 24, 386, DateTimeKind.Unspecified).AddTicks(2716), 34L, "Quam quaerat id ad placeat.", 3, 3 },
                    { 72L, 30L, "Maiores quo totam.\nDelectus tempore vel.\nVoluptas incidunt earum dolor maiores qui.\nVelit aut voluptatem ea eligendi et repellendus sed.\nNulla id laboriosam deserunt cupiditate commodi voluptatibus magnam explicabo consequatur.\nOptio ratione praesentium aut ipsum officia unde magnam.", new DateTime(2022, 5, 7, 1, 1, 27, 178, DateTimeKind.Unspecified).AddTicks(8521), 24L, "Sit id consequatur eos sunt voluptatem quos aliquam fugit porro.", 2, 3 },
                    { 73L, 56L, "tempora", new DateTime(2022, 9, 7, 7, 32, 9, 336, DateTimeKind.Unspecified).AddTicks(6145), 17L, "Voluptas perferendis qui sit amet nihil sed harum similique.", 2, 3 },
                    { 74L, 59L, "beatae", new DateTime(2022, 4, 6, 9, 41, 55, 221, DateTimeKind.Unspecified).AddTicks(392), 36L, "Vitae quia repudiandae perferendis ut rerum sint amet.", 3, 1 },
                    { 75L, 57L, "in", new DateTime(2019, 5, 7, 6, 59, 23, 142, DateTimeKind.Unspecified).AddTicks(4971), 34L, "Consequatur soluta aliquid qui sint et iure totam veritatis in.", 4, 2 },
                    { 76L, 57L, "nisi", new DateTime(2019, 2, 6, 23, 54, 12, 553, DateTimeKind.Unspecified).AddTicks(5327), 14L, "Aut velit cupiditate voluptas in quis aut qui.", 3, 0 },
                    { 77L, 8L, "Est ea itaque ut ullam molestiae nobis cumque maxime repellat. Autem quae aut reiciendis nihil est qui ipsa. Quaerat atque necessitatibus et voluptate eum iusto autem laudantium. Impedit fuga beatae illum necessitatibus ut earum autem temporibus repudiandae.", new DateTime(2022, 8, 8, 16, 35, 3, 160, DateTimeKind.Unspecified).AddTicks(4785), 14L, "Aut numquam illo distinctio omnis quia.", 4, 1 },
                    { 78L, 69L, "Maxime est eligendi quia sint. Earum totam asperiores saepe labore temporibus. Fugit ullam incidunt numquam consequatur.", new DateTime(2023, 7, 22, 15, 42, 16, 401, DateTimeKind.Unspecified).AddTicks(2480), 6L, "Non fugit beatae.", 4, 0 },
                    { 79L, 6L, "Molestias hic ex debitis molestiae quia nobis qui. At voluptatem sint sunt et natus inventore. Possimus cumque eveniet quasi. Accusantium voluptatem et fugiat.", new DateTime(2023, 8, 20, 8, 23, 21, 640, DateTimeKind.Unspecified).AddTicks(1837), 12L, "Magni ut nesciunt aliquid.", 3, 3 },
                    { 80L, 19L, "provident", new DateTime(2022, 9, 4, 0, 1, 12, 457, DateTimeKind.Unspecified).AddTicks(3702), 29L, "Tempore quia qui voluptas non ut accusamus.", 3, 0 },
                    { 81L, 10L, "Eaque quaerat deserunt deserunt est voluptatum modi quaerat placeat et.", new DateTime(2023, 7, 27, 21, 46, 23, 444, DateTimeKind.Unspecified).AddTicks(6462), 6L, "Exercitationem sunt deleniti recusandae deserunt velit nihil facilis.", 4, 2 },
                    { 82L, 63L, "Alias quis magnam provident quam.", new DateTime(2023, 4, 23, 18, 5, 3, 691, DateTimeKind.Unspecified).AddTicks(1435), 12L, "Mollitia consequatur sint itaque ut animi voluptate fugit labore quas.", 4, 3 },
                    { 83L, 10L, "Magni autem sit.\nAt deleniti aliquid odit voluptatibus debitis.\nAutem asperiores eum quo quibusdam.\nAut est vitae ducimus.\nUt eaque harum dignissimos nemo architecto.", new DateTime(2022, 3, 13, 13, 11, 30, 102, DateTimeKind.Unspecified).AddTicks(6360), 12L, "Beatae aperiam et ut delectus aut neque at aliquid rerum.", 3, 1 },
                    { 84L, 57L, "et", new DateTime(2021, 9, 17, 21, 1, 31, 120, DateTimeKind.Unspecified).AddTicks(216), 7L, "In ipsa ut qui.", 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[,]
                {
                    { 85L, 31L, "Voluptatum voluptatibus aut voluptate ipsum minima blanditiis voluptas.\nA est quibusdam voluptatibus tempore saepe.\nRerum consequatur sint harum nisi maxime et ipsa rem.\nEt mollitia accusantium laudantium sed dolore officia impedit similique et.\nPorro et rerum ea aliquam cum est maiores.", new DateTime(2022, 11, 3, 4, 32, 4, 613, DateTimeKind.Unspecified).AddTicks(9302), 7L, "Ut quam ducimus illo fugit recusandae explicabo.", 1, 3 },
                    { 86L, 26L, "Omnis voluptas itaque quis est vero illum sit.", new DateTime(2021, 5, 12, 13, 48, 42, 438, DateTimeKind.Unspecified).AddTicks(8493), 11L, "Veniam id aut.", 4, 0 },
                    { 87L, 55L, "Iusto eligendi esse sint facilis laborum ea quo quis.", new DateTime(2023, 7, 27, 5, 25, 26, 280, DateTimeKind.Unspecified).AddTicks(457), 10L, "Eos ipsum sit aperiam ad dicta quasi dolor inventore ullam.", 4, 1 },
                    { 88L, 8L, "adipisci", new DateTime(2022, 6, 25, 11, 41, 10, 110, DateTimeKind.Unspecified).AddTicks(6880), 29L, "Distinctio saepe dolorum delectus neque tempore.", 4, 2 },
                    { 89L, 29L, "Repudiandae ut animi quaerat reprehenderit voluptas et. Est voluptate rerum iusto sit veniam dolor magnam et. Illum architecto repudiandae explicabo quia id ipsum. Et et beatae ipsam. Inventore ut quis.", new DateTime(2023, 4, 28, 7, 6, 42, 625, DateTimeKind.Unspecified).AddTicks(6166), 38L, "Assumenda impedit quidem quo et quam quia animi.", 1, 2 },
                    { 90L, 46L, "Iste fuga ipsum fuga inventore.", new DateTime(2023, 1, 26, 3, 30, 30, 358, DateTimeKind.Unspecified).AddTicks(1214), 33L, "Voluptas molestiae laborum magnam aut.", 1, 2 },
                    { 91L, 40L, "assumenda", new DateTime(2021, 11, 26, 8, 44, 26, 424, DateTimeKind.Unspecified).AddTicks(2385), 23L, "Dicta magnam laboriosam consequatur optio suscipit aliquid eum provident sapiente.", 3, 0 },
                    { 92L, 31L, "quaerat", new DateTime(2023, 6, 19, 1, 51, 17, 545, DateTimeKind.Unspecified).AddTicks(3567), 24L, "Atque et quisquam eveniet quo rerum consequatur et est repellat.", 3, 1 },
                    { 93L, 45L, "Nisi occaecati at molestias veritatis alias laudantium suscipit. Suscipit ipsum minima consectetur esse reprehenderit natus temporibus. Aliquid autem ad ut est blanditiis architecto impedit.", new DateTime(2021, 11, 14, 14, 9, 34, 285, DateTimeKind.Unspecified).AddTicks(794), 31L, "Et qui incidunt minima.", 4, 3 },
                    { 94L, 37L, "In fuga repellat sunt et alias sunt ratione enim distinctio.", new DateTime(2022, 7, 6, 11, 13, 58, 23, DateTimeKind.Unspecified).AddTicks(6159), 18L, "Libero sequi quos.", 4, 3 },
                    { 95L, 66L, "eum", new DateTime(2022, 8, 23, 18, 3, 9, 143, DateTimeKind.Unspecified).AddTicks(5353), 7L, "Quaerat totam beatae voluptates in et ex.", 2, 0 },
                    { 96L, 37L, "Aliquid modi aliquid.", new DateTime(2020, 9, 15, 7, 48, 56, 279, DateTimeKind.Unspecified).AddTicks(7962), 31L, "Molestiae sapiente animi.", 2, 1 },
                    { 97L, 22L, "Nobis velit sint natus delectus enim.\nQuod quas et a asperiores cumque fuga necessitatibus error.\nAb et velit aperiam.\nConsequatur qui dicta.", new DateTime(2023, 5, 30, 10, 7, 12, 483, DateTimeKind.Unspecified).AddTicks(2585), 29L, "Odit beatae ipsam.", 3, 0 },
                    { 98L, 39L, "Non atque nulla sed iste ipsam veritatis nihil.", new DateTime(2023, 6, 21, 22, 43, 55, 455, DateTimeKind.Unspecified).AddTicks(3519), 11L, "Error nobis velit aliquid excepturi ducimus ipsa.", 1, 3 },
                    { 99L, 44L, "Nam sit nesciunt ducimus qui enim et enim autem sed.", new DateTime(2022, 11, 2, 15, 51, 22, 38, DateTimeKind.Unspecified).AddTicks(6628), 27L, "Autem error animi quia rem.", 1, 3 },
                    { 100L, 25L, "dolor", new DateTime(2023, 7, 15, 14, 29, 46, 72, DateTimeKind.Unspecified).AddTicks(7133), 17L, "Est voluptas est id debitis.", 3, 2 },
                    { 101L, 11L, "consequatur", new DateTime(2023, 1, 7, 12, 54, 28, 468, DateTimeKind.Unspecified).AddTicks(4284), 18L, "Voluptates quia sunt consequuntur omnis eos laudantium est facere.", 3, 3 },
                    { 102L, 46L, "harum", new DateTime(2023, 7, 30, 20, 53, 1, 595, DateTimeKind.Unspecified).AddTicks(8593), 32L, "Dicta animi dolorem exercitationem asperiores veniam cumque est.", 4, 0 },
                    { 103L, 5L, "Voluptas ipsa est veniam facere at quo occaecati.\nRepellat quos sint ipsa officiis odio est incidunt dolorum.\nExpedita quis aut.\nLibero quis harum aperiam qui asperiores temporibus id impedit dolores.\nRecusandae facilis commodi aliquid sunt aut eum.\nVitae cum doloribus perspiciatis placeat.", new DateTime(2023, 4, 14, 0, 39, 58, 767, DateTimeKind.Unspecified).AddTicks(8926), 24L, "Atque laudantium autem et dolores sunt consequatur sunt.", 3, 1 },
                    { 104L, 30L, "Voluptatem voluptatem dolor dolor odio earum autem. Aut non tempora ad aspernatur. Quia soluta quod. Quis vitae deserunt non ut nesciunt itaque nostrum minima corrupti. Ex aut voluptatibus consequatur maxime.", new DateTime(2022, 1, 18, 14, 53, 47, 329, DateTimeKind.Unspecified).AddTicks(1624), 31L, "Velit enim expedita nesciunt illo asperiores sed.", 1, 0 },
                    { 105L, 44L, "Ut provident corrupti non consequatur.", new DateTime(2023, 1, 13, 9, 37, 8, 947, DateTimeKind.Unspecified).AddTicks(4049), 6L, "Ut beatae cumque itaque quia et non et tenetur.", 4, 3 },
                    { 106L, 6L, "Temporibus rem reiciendis sunt atque vel sint excepturi voluptas quo.", new DateTime(2023, 8, 23, 0, 21, 19, 448, DateTimeKind.Unspecified).AddTicks(4329), 22L, "Perferendis cupiditate iste et laudantium.", 1, 2 },
                    { 107L, 11L, "Qui et neque qui sapiente veritatis. Vel beatae praesentium vero. Neque et minima nam quae cum esse ullam. Repellendus eum et perferendis assumenda vitae molestiae qui.", new DateTime(2022, 7, 8, 18, 20, 0, 329, DateTimeKind.Unspecified).AddTicks(2990), 29L, "Id qui voluptatem.", 4, 2 },
                    { 108L, 4L, "Qui quasi ea. In tenetur facere et sunt explicabo magni consectetur. Maxime natus veniam ipsam ipsam hic autem sit eius aliquam. Qui sapiente a porro accusantium ad voluptas doloremque.", new DateTime(2022, 8, 21, 1, 34, 48, 154, DateTimeKind.Unspecified).AddTicks(3675), 30L, "Inventore voluptate nisi at qui laboriosam hic omnis iste tempora.", 2, 2 },
                    { 109L, 42L, "distinctio", new DateTime(2022, 7, 19, 3, 12, 43, 349, DateTimeKind.Unspecified).AddTicks(7895), 20L, "Qui omnis et dicta delectus ipsam.", 2, 1 },
                    { 110L, 25L, "Aut autem et qui vel. Illum ipsum consectetur dolor recusandae aliquam earum quos neque corrupti. Sit omnis doloremque recusandae repellat. Quae alias recusandae est tempore impedit voluptas in enim. Veritatis aut accusamus omnis. In in molestiae id voluptas in.", new DateTime(2023, 6, 9, 20, 3, 11, 978, DateTimeKind.Unspecified).AddTicks(6665), 9L, "Doloremque in aut animi illum cumque dolorem iusto asperiores eaque.", 1, 3 },
                    { 111L, 30L, "qui", new DateTime(2021, 7, 27, 19, 2, 20, 855, DateTimeKind.Unspecified).AddTicks(326), 25L, "Harum nihil modi repellendus voluptatem aut ut officiis eos debitis.", 2, 2 },
                    { 112L, 34L, "Deleniti perferendis possimus. Officiis dicta commodi quod. Eveniet cum enim. Consequatur quis enim quam et blanditiis et asperiores. Consequatur perferendis quisquam hic magnam sit consequuntur hic unde.", new DateTime(2023, 3, 25, 4, 51, 0, 496, DateTimeKind.Unspecified).AddTicks(3472), 30L, "Eum exercitationem recusandae repudiandae possimus aut id adipisci sequi nihil.", 4, 3 },
                    { 113L, 55L, "Ipsam et id dolorum sint velit et.\nFacilis quod esse et quo sit et inventore.", new DateTime(2023, 8, 3, 20, 56, 13, 432, DateTimeKind.Unspecified).AddTicks(3121), 36L, "Quis qui provident quod eos autem qui aliquam.", 2, 3 },
                    { 114L, 28L, "Aut omnis sed necessitatibus est et.\nNon molestiae iure architecto.\nArchitecto atque delectus officiis aut optio natus cupiditate ipsam.\nDeleniti est sit.\nNesciunt ex id unde mollitia et quia quia tempore voluptatibus.\nDoloremque amet ipsam velit nulla.", new DateTime(2021, 12, 25, 5, 18, 4, 528, DateTimeKind.Unspecified).AddTicks(9417), 5L, "Error magni quasi et.", 2, 3 },
                    { 115L, 56L, "Impedit nobis impedit pariatur est.", new DateTime(2023, 6, 21, 10, 36, 29, 129, DateTimeKind.Unspecified).AddTicks(7874), 22L, "Animi quaerat ut modi rerum sit magni non.", 2, 0 },
                    { 116L, 34L, "veritatis", new DateTime(2023, 4, 21, 6, 21, 1, 705, DateTimeKind.Unspecified).AddTicks(6918), 14L, "Voluptatibus in omnis molestias et fugit rem dolorum sunt.", 2, 3 },
                    { 117L, 48L, "Est natus labore quae mollitia qui sunt. Eos et nobis corrupti porro cumque eius distinctio. Amet quia facilis quis modi. Ut explicabo quam.", new DateTime(2021, 9, 21, 14, 32, 0, 245, DateTimeKind.Unspecified).AddTicks(9702), 3L, "Sapiente debitis beatae quod nihil.", 1, 3 },
                    { 118L, 37L, "Dolorum qui expedita autem expedita quaerat expedita esse.", new DateTime(2021, 3, 19, 12, 44, 3, 55, DateTimeKind.Unspecified).AddTicks(3521), 28L, "Blanditiis consequatur quidem omnis incidunt sunt dolores odio.", 2, 2 },
                    { 119L, 38L, "Inventore aperiam impedit et libero. Quod eligendi rerum voluptatem mollitia id. Est ullam voluptas hic sit quis rerum voluptas repellat est. Magnam vitae voluptatem et ipsam veritatis deserunt omnis dolorem. Animi omnis hic adipisci maiores maiores eligendi dolorem quod. Et dolor sint commodi expedita esse molestiae.", new DateTime(2017, 12, 31, 10, 18, 47, 686, DateTimeKind.Unspecified).AddTicks(6714), 23L, "Totam ut tenetur dolor autem ut.", 4, 0 },
                    { 120L, 67L, "Natus illum omnis ratione aut sed illum possimus doloremque.", new DateTime(2023, 7, 24, 15, 3, 32, 263, DateTimeKind.Unspecified).AddTicks(9689), 11L, "Repudiandae vel qui dolorem quia.", 2, 3 },
                    { 121L, 27L, "Ut tempore ut ut et aperiam vel ea. Similique ducimus et ut et consequatur consequatur aliquid sed. Libero at sequi quia harum aut perferendis. Nisi sit ut dolorem rem sit at culpa. Repudiandae rem eaque.", new DateTime(2022, 2, 23, 5, 15, 52, 786, DateTimeKind.Unspecified).AddTicks(3681), 23L, "Rem similique ut a.", 4, 2 },
                    { 122L, 35L, "At vitae laudantium animi minus atque exercitationem aperiam iure iste. Reiciendis id sed eius ut blanditiis. Vitae vel exercitationem incidunt officia eum ratione totam id commodi. Illum porro voluptas dolorem numquam repellat et rerum ipsam id.", new DateTime(2022, 10, 13, 17, 13, 24, 950, DateTimeKind.Unspecified).AddTicks(5045), 10L, "Suscipit ad autem laudantium velit unde.", 3, 1 },
                    { 123L, 48L, "Blanditiis ut maxime recusandae sequi similique quo beatae.\nOccaecati sed quisquam quaerat eos qui cupiditate voluptas hic.\nIn at harum officiis in quia enim architecto ab similique.\nPerspiciatis autem consequatur consequatur eos rem consequatur iste.", new DateTime(2022, 11, 6, 17, 27, 52, 98, DateTimeKind.Unspecified).AddTicks(2385), 36L, "Excepturi mollitia nesciunt nesciunt error maxime libero possimus quos tempore.", 1, 0 },
                    { 124L, 7L, "Neque quisquam harum sint.\nQui reprehenderit dolorem qui voluptas quos temporibus excepturi magni.\nQuod porro aliquam minima libero porro est voluptas ipsam in.\nNon quibusdam sed assumenda consequatur rem occaecati suscipit sint qui.", new DateTime(2022, 7, 29, 19, 11, 51, 189, DateTimeKind.Unspecified).AddTicks(9842), 2L, "Ipsa iusto corporis.", 3, 0 },
                    { 125L, 13L, "Vero sint reprehenderit a voluptatem.\nDolorem necessitatibus mollitia harum a fugiat voluptatem.", new DateTime(2023, 8, 21, 3, 36, 54, 467, DateTimeKind.Unspecified).AddTicks(8836), 7L, "Eum nisi dolor iure iure similique aspernatur corporis.", 2, 2 },
                    { 126L, 7L, "Incidunt quae a ratione nam illum quia eos.\nSimilique qui voluptatem atque consequatur accusamus.\nNesciunt sed non tenetur earum corporis sunt.", new DateTime(2023, 1, 1, 10, 12, 18, 538, DateTimeKind.Unspecified).AddTicks(1893), 18L, "Aperiam labore officia architecto rerum quam dolores perferendis.", 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[,]
                {
                    { 127L, 66L, "Ea dolores nostrum sunt veritatis quidem dicta. Et architecto repudiandae. Saepe ea voluptate possimus molestiae a earum veritatis qui autem. Voluptas et et eos dolorum qui id a. Veniam sint at blanditiis est minus doloremque vel. Nesciunt quis quis fuga sed est eveniet sed qui voluptatum.", new DateTime(2023, 8, 7, 9, 51, 49, 585, DateTimeKind.Unspecified).AddTicks(994), 9L, "Sit quas aliquam non eveniet in voluptates.", 4, 3 },
                    { 128L, 22L, "Hic odit adipisci non natus veritatis labore.\nCorporis cumque ipsa.\nEt quas odio magni consequatur optio.", new DateTime(2023, 7, 13, 7, 58, 56, 619, DateTimeKind.Unspecified).AddTicks(381), 26L, "Delectus voluptas repellat dolores laudantium cupiditate praesentium sed veniam.", 2, 3 },
                    { 129L, 68L, "Incidunt reprehenderit ipsum eaque minima voluptatem autem.", new DateTime(2022, 10, 7, 17, 57, 57, 562, DateTimeKind.Unspecified).AddTicks(9314), 21L, "Doloremque rerum provident harum voluptates aliquam.", 4, 3 },
                    { 130L, 5L, "qui", new DateTime(2023, 4, 3, 2, 9, 7, 234, DateTimeKind.Unspecified).AddTicks(6868), 13L, "Ut aliquam sapiente dicta sit.", 1, 2 },
                    { 131L, 23L, "At voluptatibus quia porro nisi necessitatibus. Quam fugit quos. Similique unde culpa qui possimus minima dolorem facere. Laborum corrupti consequuntur optio modi commodi necessitatibus totam et.", new DateTime(2023, 8, 6, 22, 29, 50, 980, DateTimeKind.Unspecified).AddTicks(404), 26L, "Eveniet cum non id sunt ab ea provident modi.", 4, 1 },
                    { 132L, 4L, "cum", new DateTime(2022, 11, 2, 7, 53, 8, 352, DateTimeKind.Unspecified).AddTicks(8169), 3L, "Magni voluptatem molestias quisquam placeat consectetur.", 2, 3 },
                    { 133L, 11L, "Excepturi ea quia tempora earum eos aut perferendis. Est dignissimos alias nam est vel. Est voluptatem enim vel error corporis et quaerat.", new DateTime(2022, 5, 7, 18, 31, 46, 231, DateTimeKind.Unspecified).AddTicks(2575), 5L, "Animi aliquam inventore aspernatur deleniti repellendus commodi at fuga dolores.", 2, 3 },
                    { 134L, 63L, "consectetur", new DateTime(2023, 5, 18, 21, 35, 33, 683, DateTimeKind.Unspecified).AddTicks(6448), 20L, "Perferendis quod placeat sed quos ipsam ut qui.", 2, 0 },
                    { 135L, 47L, "aut", new DateTime(2022, 9, 24, 15, 16, 35, 306, DateTimeKind.Unspecified).AddTicks(1229), 4L, "Vel dolor omnis.", 1, 2 },
                    { 136L, 9L, "Fugit dolores atque eum.", new DateTime(2020, 3, 1, 6, 30, 22, 758, DateTimeKind.Unspecified).AddTicks(3431), 27L, "Sint et temporibus sapiente doloribus quod at possimus cumque.", 1, 3 },
                    { 137L, 39L, "Nam omnis quasi consequuntur.\nVeniam blanditiis voluptatem ut incidunt incidunt.\nVoluptatem magnam est repudiandae voluptas nobis.\nIllo est ratione.", new DateTime(2019, 11, 7, 5, 52, 35, 946, DateTimeKind.Unspecified).AddTicks(2459), 17L, "Facilis quia suscipit.", 4, 2 },
                    { 138L, 3L, "nobis", new DateTime(2023, 1, 25, 19, 20, 29, 176, DateTimeKind.Unspecified).AddTicks(4923), 38L, "Enim quo qui et molestiae animi consectetur voluptatibus et.", 4, 0 },
                    { 139L, 9L, "Voluptatum voluptatem enim laborum quae consectetur dolor.\nDoloribus unde veritatis quod veniam porro repellat ut perferendis atque.\nVoluptatibus nam explicabo saepe.\nUnde perspiciatis ut.\nOfficia sint fugit tempore velit aut est nam natus.", new DateTime(2023, 3, 23, 23, 38, 24, 654, DateTimeKind.Unspecified).AddTicks(4801), 10L, "Iste cupiditate earum exercitationem qui consequatur et expedita molestias corrupti.", 2, 2 },
                    { 140L, 9L, "Exercitationem quibusdam at.", new DateTime(2021, 6, 29, 7, 36, 20, 661, DateTimeKind.Unspecified).AddTicks(5060), 3L, "Reiciendis aut omnis ducimus est et quam.", 2, 0 },
                    { 141L, 18L, "Atque facere omnis non sint.\nAsperiores explicabo optio voluptatem.\nNihil odit autem in.\nVoluptatem sed ea commodi dolorum.", new DateTime(2023, 5, 2, 14, 47, 36, 364, DateTimeKind.Unspecified).AddTicks(7525), 20L, "Reiciendis qui quasi iusto reprehenderit ut ipsum quasi suscipit.", 4, 2 },
                    { 142L, 25L, "Sunt at non.\nQuasi voluptate ratione.\nTempora est voluptas perferendis eos repudiandae aut et enim.\nQuod deserunt et aliquam.\nAutem cumque voluptatibus.\nSed fugiat quam sint laudantium error ex dolorem voluptate.", new DateTime(2023, 6, 29, 1, 4, 4, 762, DateTimeKind.Unspecified).AddTicks(3227), 9L, "Aut ad culpa ipsam placeat et.", 2, 1 },
                    { 143L, 23L, "Soluta ut eius perspiciatis quo qui. Nemo sunt officia accusantium repellat aut magni et qui. Placeat qui voluptatum sapiente recusandae provident voluptas vitae ut. Neque tempora aut blanditiis. Quia maiores fugiat natus nisi.", new DateTime(2023, 7, 3, 22, 6, 45, 80, DateTimeKind.Unspecified).AddTicks(4076), 20L, "Veniam nulla numquam rem accusamus commodi.", 4, 2 },
                    { 144L, 49L, "Dicta laborum eum.\nRem placeat quis.\nLaudantium accusamus harum libero beatae reiciendis.", new DateTime(2023, 3, 15, 14, 39, 15, 918, DateTimeKind.Unspecified).AddTicks(3281), 33L, "Dolorum quisquam nihil voluptatum.", 1, 2 },
                    { 145L, 27L, "Quia expedita dolores voluptatum illum quia accusantium nulla a quis. Dicta consectetur delectus ut blanditiis a dolorem. Modi corrupti aperiam facere et quam ipsa repudiandae aut amet. Ab omnis perferendis praesentium aliquam aut autem. At officiis hic nostrum.", new DateTime(2021, 7, 6, 2, 59, 9, 3, DateTimeKind.Unspecified).AddTicks(3680), 9L, "Odit aut nihil aut maiores.", 3, 1 },
                    { 146L, 6L, "Dicta et voluptas illo est nostrum. Expedita eum labore a architecto qui impedit ut vitae et. Dicta enim velit nemo consequatur nisi non non est corrupti. Qui rerum deserunt quas. Ipsum ut provident.", new DateTime(2023, 8, 20, 16, 5, 7, 477, DateTimeKind.Unspecified).AddTicks(7621), 2L, "Fuga delectus nulla neque.", 1, 2 },
                    { 147L, 14L, "aut", new DateTime(2022, 5, 12, 18, 40, 22, 576, DateTimeKind.Unspecified).AddTicks(7229), 10L, "Qui aliquid eos eum et.", 1, 3 },
                    { 148L, 40L, "Optio ut rerum omnis cumque necessitatibus quas.", new DateTime(2023, 8, 16, 17, 40, 22, 208, DateTimeKind.Unspecified).AddTicks(5360), 9L, "Sed dolores nulla nulla occaecati molestiae et et aliquid.", 1, 3 },
                    { 149L, 5L, "Optio quisquam ut consequatur reprehenderit commodi eaque aliquam.", new DateTime(2023, 6, 8, 14, 48, 54, 212, DateTimeKind.Unspecified).AddTicks(89), 9L, "Perspiciatis laboriosam ea.", 1, 2 },
                    { 150L, 23L, "nam", new DateTime(2023, 7, 17, 14, 59, 50, 530, DateTimeKind.Unspecified).AddTicks(6002), 31L, "Maiores similique est saepe dignissimos sit ut ullam consequatur.", 4, 2 },
                    { 151L, 62L, "Ratione minima excepturi dignissimos expedita dignissimos fuga commodi enim et.\nQuas vero ducimus.\nConsequatur laboriosam in ex ut qui culpa quae provident deleniti.", new DateTime(2023, 1, 7, 9, 7, 3, 288, DateTimeKind.Unspecified).AddTicks(1938), 5L, "Accusantium explicabo delectus expedita.", 4, 2 },
                    { 152L, 45L, "illum", new DateTime(2022, 1, 31, 20, 25, 7, 426, DateTimeKind.Unspecified).AddTicks(6630), 16L, "Nisi ut et maxime.", 4, 3 },
                    { 153L, 35L, "Aperiam maxime similique incidunt voluptatibus.\nEst error ipsa quaerat perspiciatis ullam nam ut inventore nihil.\nAmet iusto possimus iusto necessitatibus nulla aperiam dolorem aperiam.", new DateTime(2022, 10, 15, 9, 37, 20, 577, DateTimeKind.Unspecified).AddTicks(6942), 21L, "Aut dolores enim dignissimos minus et sunt.", 1, 0 },
                    { 154L, 59L, "quia", new DateTime(2022, 8, 8, 14, 52, 3, 153, DateTimeKind.Unspecified).AddTicks(6813), 37L, "Debitis inventore ut.", 4, 3 },
                    { 155L, 60L, "Enim ut consectetur.", new DateTime(2022, 9, 28, 17, 32, 26, 327, DateTimeKind.Unspecified).AddTicks(4814), 36L, "Ipsa repellat qui fugiat aperiam.", 3, 0 },
                    { 156L, 25L, "Labore ducimus quam est alias alias non.", new DateTime(2023, 1, 31, 13, 2, 51, 45, DateTimeKind.Unspecified).AddTicks(1051), 34L, "Rerum facere ut.", 4, 1 },
                    { 157L, 27L, "fugit", new DateTime(2021, 8, 11, 0, 33, 40, 942, DateTimeKind.Unspecified).AddTicks(9210), 4L, "Et eaque culpa sed quia aspernatur sed.", 4, 0 },
                    { 158L, 28L, "tempora", new DateTime(2021, 12, 4, 19, 53, 37, 310, DateTimeKind.Unspecified).AddTicks(2914), 17L, "Accusamus saepe consectetur soluta rerum vel aut omnis.", 1, 2 },
                    { 159L, 9L, "exercitationem", new DateTime(2021, 1, 21, 11, 11, 1, 376, DateTimeKind.Unspecified).AddTicks(8292), 2L, "Distinctio omnis officia aspernatur dolores atque maxime in.", 2, 2 },
                    { 160L, 28L, "Eos quo dolorum eum error non porro molestiae et inventore.", new DateTime(2021, 11, 23, 23, 20, 44, 677, DateTimeKind.Unspecified).AddTicks(4882), 25L, "Nulla rerum maiores blanditiis nemo nesciunt magni maxime repellat corrupti.", 1, 0 },
                    { 161L, 8L, "Iure quas est.", new DateTime(2023, 4, 12, 10, 51, 33, 205, DateTimeKind.Unspecified).AddTicks(7100), 3L, "Provident soluta perferendis quia dolorem consequuntur perspiciatis et.", 4, 0 },
                    { 162L, 49L, "Quod animi nemo optio laborum voluptatum non ipsam rem. Voluptatem perferendis ipsum alias ea. Dolorem non dolor expedita tenetur eos. Vel quia quia reiciendis vitae.", new DateTime(2023, 6, 20, 7, 0, 46, 537, DateTimeKind.Unspecified).AddTicks(7279), 35L, "Nihil tempore ducimus natus voluptas voluptas.", 1, 3 },
                    { 163L, 3L, "Aliquam libero ipsa explicabo et fugit. Facere fugiat animi ad. Occaecati quos dolores consequuntur adipisci repellendus et ullam exercitationem esse. In cum magni voluptatem. Voluptatem dolorem animi unde voluptas facere et.", new DateTime(2023, 6, 16, 8, 58, 6, 436, DateTimeKind.Unspecified).AddTicks(9026), 8L, "Debitis dolorem temporibus eligendi necessitatibus ipsum quidem repellendus sed.", 2, 0 },
                    { 164L, 41L, "Enim ipsam magni voluptas ut laudantium quam consequatur quibusdam.\nQui libero repellat est neque assumenda et.\nDicta ipsum mollitia qui.\nVoluptas dolores at accusantium consequatur a et itaque.", new DateTime(2021, 3, 31, 9, 40, 31, 16, DateTimeKind.Unspecified).AddTicks(5857), 12L, "Delectus sint ad omnis et quia in tempore.", 3, 3 },
                    { 165L, 58L, "magnam", new DateTime(2023, 5, 7, 0, 29, 18, 46, DateTimeKind.Unspecified).AddTicks(2145), 17L, "Accusantium voluptas in id qui aut beatae.", 2, 2 },
                    { 166L, 51L, "Odio laborum voluptate officiis rerum numquam sunt voluptatem.", new DateTime(2022, 9, 5, 20, 13, 53, 22, DateTimeKind.Unspecified).AddTicks(1360), 25L, "Quam quam nesciunt ducimus tempore aut.", 2, 0 },
                    { 167L, 11L, "odit", new DateTime(2022, 2, 20, 7, 20, 58, 630, DateTimeKind.Unspecified).AddTicks(460), 4L, "Error omnis itaque error sunt et in.", 3, 1 },
                    { 168L, 12L, "iusto", new DateTime(2023, 8, 21, 21, 40, 45, 570, DateTimeKind.Unspecified).AddTicks(5252), 16L, "Eum est illum nobis beatae eos asperiores velit.", 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[,]
                {
                    { 169L, 5L, "Aspernatur aut ut quas vero est sit quia.\nBlanditiis dolorum rerum voluptas sint ut autem similique consequatur non.", new DateTime(2023, 7, 12, 2, 51, 54, 415, DateTimeKind.Unspecified).AddTicks(3414), 19L, "Ipsum inventore et vero vel.", 1, 0 },
                    { 170L, 23L, "corporis", new DateTime(2023, 8, 1, 15, 59, 9, 694, DateTimeKind.Unspecified).AddTicks(5667), 5L, "Nostrum reiciendis in.", 2, 2 },
                    { 171L, 55L, "Provident quis perferendis culpa voluptatibus facilis perferendis expedita. Eum error placeat repellendus recusandae harum. Ullam veniam tempora sit. Rem beatae vel facilis officiis ipsum.", new DateTime(2023, 7, 19, 17, 10, 20, 622, DateTimeKind.Unspecified).AddTicks(8290), 4L, "Ut quos omnis veniam magnam eveniet incidunt libero possimus ipsa.", 4, 0 },
                    { 172L, 32L, "Odit doloribus provident totam sapiente animi.", new DateTime(2023, 8, 17, 9, 52, 53, 675, DateTimeKind.Unspecified).AddTicks(496), 29L, "Nobis et perferendis exercitationem id soluta blanditiis sunt.", 3, 3 },
                    { 173L, 8L, "Officiis suscipit nemo sed.", new DateTime(2023, 5, 28, 16, 18, 52, 876, DateTimeKind.Unspecified).AddTicks(5421), 25L, "Inventore non sed recusandae odit.", 1, 1 },
                    { 174L, 18L, "voluptate", new DateTime(2023, 3, 8, 8, 4, 43, 871, DateTimeKind.Unspecified).AddTicks(9458), 25L, "Id est omnis quasi aut ut qui.", 1, 1 },
                    { 175L, 48L, "Neque quibusdam temporibus quas commodi soluta.", new DateTime(2023, 6, 18, 10, 5, 32, 39, DateTimeKind.Unspecified).AddTicks(9615), 7L, "Quibusdam aliquid mollitia aut explicabo aut sunt reiciendis.", 4, 3 },
                    { 176L, 57L, "Et est porro doloribus perspiciatis. Facere nobis vel possimus. Doloremque autem aliquid harum consequatur quia aperiam est ipsa. Enim officia quisquam nesciunt qui harum dicta. Error quo voluptatibus officiis impedit quas dolorem.", new DateTime(2021, 9, 26, 14, 47, 0, 537, DateTimeKind.Unspecified).AddTicks(5818), 11L, "Ut dicta labore vel.", 2, 0 },
                    { 177L, 45L, "expedita", new DateTime(2023, 4, 8, 15, 40, 16, 341, DateTimeKind.Unspecified).AddTicks(6943), 40L, "Dolorem sint dolores consequuntur eos vel harum ad et ut.", 3, 0 },
                    { 178L, 62L, "Temporibus sit et non odit. Qui aperiam officia illum qui ut et consequatur. Eius delectus accusamus aut ducimus aut et tempore rerum. Sint debitis ea delectus inventore delectus eum voluptates cumque.", new DateTime(2022, 7, 27, 7, 39, 45, 806, DateTimeKind.Unspecified).AddTicks(8387), 9L, "Animi libero dolor dolore ipsa omnis nesciunt vitae pariatur.", 3, 0 },
                    { 179L, 59L, "Consequatur earum sed voluptatibus repellat sint reprehenderit ea. Atque impedit amet quibusdam modi et non at. Voluptas et consequatur rerum asperiores placeat laboriosam. Aperiam dolor sed saepe qui debitis. Velit aliquid accusantium itaque.", new DateTime(2022, 5, 4, 23, 16, 39, 544, DateTimeKind.Unspecified).AddTicks(7613), 13L, "Velit quibusdam tempora dolor numquam.", 4, 3 },
                    { 180L, 65L, "minus", new DateTime(2023, 5, 1, 12, 12, 5, 441, DateTimeKind.Unspecified).AddTicks(7942), 25L, "Id quas nisi iste.", 3, 2 },
                    { 181L, 18L, "Mollitia accusamus eaque. Accusamus temporibus suscipit quos laborum nam aliquam. Asperiores ut nulla dignissimos. Delectus dolores voluptatem eius suscipit incidunt beatae. Nisi quis odit explicabo ipsa blanditiis voluptatibus. Voluptas a voluptatem eligendi odit veritatis aut ad.", new DateTime(2023, 1, 20, 20, 12, 45, 229, DateTimeKind.Unspecified).AddTicks(5995), 28L, "Quia hic quis facilis perspiciatis aut numquam sequi voluptas.", 2, 1 },
                    { 182L, 40L, "Sapiente voluptatem cupiditate quas incidunt in sunt quia.", new DateTime(2022, 6, 14, 14, 15, 6, 495, DateTimeKind.Unspecified).AddTicks(3078), 38L, "Rerum eaque assumenda et et fuga similique quibusdam.", 2, 2 },
                    { 183L, 3L, "Quia iure et.\nAut provident cumque soluta qui.\nSed corporis quae.\nSoluta magnam quam.\nMaiores cumque molestias sit quaerat eveniet exercitationem.", new DateTime(2023, 5, 25, 20, 8, 29, 443, DateTimeKind.Unspecified).AddTicks(1319), 35L, "Qui ut voluptas maiores omnis dicta est eum odio.", 3, 0 },
                    { 184L, 2L, "Labore pariatur voluptatem nemo.", new DateTime(2022, 12, 29, 14, 26, 16, 527, DateTimeKind.Unspecified).AddTicks(5282), 29L, "Fugiat vero nesciunt architecto sit omnis repudiandae.", 2, 3 },
                    { 185L, 64L, "Dolores non vel sequi quas cumque dignissimos. Voluptatibus et cumque molestias sunt pariatur praesentium distinctio asperiores hic. Enim facilis suscipit assumenda nisi laborum optio.", new DateTime(2022, 3, 17, 3, 23, 27, 183, DateTimeKind.Unspecified).AddTicks(2881), 31L, "Sapiente aut impedit rerum error nemo magni.", 1, 2 },
                    { 186L, 58L, "quisquam", new DateTime(2023, 6, 16, 21, 4, 18, 989, DateTimeKind.Unspecified).AddTicks(4587), 32L, "At hic quidem quo aperiam accusamus aut nam culpa.", 4, 1 },
                    { 187L, 38L, "omnis", new DateTime(2020, 10, 27, 13, 15, 59, 287, DateTimeKind.Unspecified).AddTicks(8040), 24L, "Ut enim sit modi temporibus debitis.", 2, 3 },
                    { 188L, 9L, "placeat", new DateTime(2022, 4, 22, 11, 0, 20, 289, DateTimeKind.Unspecified).AddTicks(1789), 35L, "Numquam ducimus ut expedita eos.", 3, 0 },
                    { 189L, 41L, "Sunt veritatis architecto voluptatum tenetur error voluptas repellat dicta.\nPossimus quas blanditiis.\nEt et facilis id ad amet eaque ea aspernatur veniam.\nEveniet rerum eum ut ipsam aut animi.", new DateTime(2019, 8, 10, 12, 55, 37, 981, DateTimeKind.Unspecified).AddTicks(6180), 24L, "Laborum eos cupiditate nesciunt et ut molestiae.", 4, 1 },
                    { 190L, 68L, "Ex magnam dolorum eligendi quam enim eum.", new DateTime(2022, 7, 8, 13, 55, 53, 339, DateTimeKind.Unspecified).AddTicks(4657), 38L, "Quibusdam veritatis et voluptatem omnis rerum fugiat aut.", 1, 3 },
                    { 191L, 52L, "Et earum non iure necessitatibus culpa praesentium.\nOdio quos nisi accusantium et eligendi.\nSit corrupti placeat fugit harum minima.", new DateTime(2023, 3, 22, 23, 37, 25, 544, DateTimeKind.Unspecified).AddTicks(1799), 35L, "Earum explicabo est hic sequi placeat debitis.", 4, 1 },
                    { 192L, 69L, "Nam quo facere quia.\nEarum harum quas laboriosam corrupti natus ad sint dignissimos beatae.", new DateTime(2023, 5, 25, 18, 52, 49, 290, DateTimeKind.Unspecified).AddTicks(280), 6L, "Eligendi soluta commodi.", 3, 1 },
                    { 193L, 70L, "Delectus sit officiis. Voluptatibus et aut animi consequatur atque magni earum quia dolor. Itaque laborum non voluptatem. Aut in provident culpa ex dolorum omnis odio. Aut inventore id similique velit. Rerum ipsa blanditiis aspernatur rerum repellat distinctio.", new DateTime(2023, 8, 3, 7, 14, 40, 217, DateTimeKind.Unspecified).AddTicks(4523), 15L, "Nemo explicabo velit assumenda non fugiat sunt.", 2, 1 },
                    { 194L, 52L, "Aut error quibusdam.\nEt ea aspernatur sed dolore.\nNihil reprehenderit autem repudiandae qui modi eveniet nesciunt.\nVoluptatem quo odio vitae ut eos doloribus pariatur sed.\nVoluptas necessitatibus velit quia molestias iusto doloremque ratione placeat.", new DateTime(2023, 5, 20, 10, 21, 8, 271, DateTimeKind.Unspecified).AddTicks(8021), 19L, "Animi deserunt eius.", 4, 3 },
                    { 195L, 25L, "illum", new DateTime(2023, 3, 13, 5, 20, 23, 730, DateTimeKind.Unspecified).AddTicks(6396), 20L, "Sunt ab doloribus vero iusto autem eligendi.", 2, 2 },
                    { 196L, 18L, "Aut enim et voluptatum omnis beatae ratione suscipit explicabo.", new DateTime(2023, 8, 15, 11, 27, 43, 422, DateTimeKind.Unspecified).AddTicks(8), 19L, "Rerum excepturi error optio.", 2, 0 },
                    { 197L, 64L, "Eum mollitia assumenda.", new DateTime(2023, 1, 8, 19, 43, 7, 962, DateTimeKind.Unspecified).AddTicks(5808), 36L, "Alias doloribus aspernatur.", 1, 2 },
                    { 198L, 12L, "Consequuntur vel rerum ullam unde qui est debitis aspernatur. Voluptatem nostrum quasi quidem occaecati totam labore. Reiciendis esse quas impedit sunt alias. Natus voluptatem accusamus aliquam. Sunt est voluptate enim debitis est.", new DateTime(2023, 8, 7, 15, 16, 50, 763, DateTimeKind.Unspecified).AddTicks(2892), 5L, "Modi modi omnis recusandae.", 1, 2 },
                    { 199L, 43L, "Esse consequatur aut odit maiores. At dolorum laborum esse quis rerum omnis. Voluptates aliquam architecto rerum debitis perspiciatis laborum et dolor.", new DateTime(2023, 7, 17, 2, 26, 12, 2, DateTimeKind.Unspecified).AddTicks(5902), 25L, "Inventore qui non deserunt occaecati unde cumque facere cupiditate cupiditate.", 2, 0 },
                    { 200L, 32L, "Sed cupiditate sit.", new DateTime(2023, 7, 30, 19, 6, 13, 297, DateTimeKind.Unspecified).AddTicks(6598), 7L, "Delectus error vel voluptatem eaque praesentium et.", 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "IsPublic" },
                values: new object[,]
                {
                    { 1L, 14L, "Fuga molestiae laborum architecto minus aut quisquam explicabo corporis.\nVeniam omnis et dolores temporibus voluptatem ea.\nIste odio quis delectus.\nDeleniti qui et consequatur.\nMinus illo quibusdam distinctio cumque nihil voluptate occaecati molestiae fuga.\nEx eos quibusdam ipsa nobis veritatis hic eaque.", new DateTime(2023, 8, 21, 17, 47, 54, 253, DateTimeKind.Unspecified).AddTicks(6845), 30L, false },
                    { 2L, 90L, "odit", new DateTime(2023, 3, 6, 13, 44, 29, 162, DateTimeKind.Unspecified).AddTicks(9221), 27L, true },
                    { 3L, 173L, "soluta", new DateTime(2023, 6, 29, 4, 17, 33, 780, DateTimeKind.Unspecified).AddTicks(3143), 29L, false },
                    { 4L, 125L, "dolorem", new DateTime(2023, 8, 21, 8, 42, 59, 542, DateTimeKind.Unspecified).AddTicks(4305), 32L, true },
                    { 5L, 185L, "Id quam velit corporis sunt.", new DateTime(2022, 11, 5, 2, 21, 15, 545, DateTimeKind.Unspecified).AddTicks(8436), 17L, true },
                    { 6L, 47L, "Repellat neque temporibus iste magnam. Placeat sit temporibus rerum aut. Esse iusto autem vero odio necessitatibus et. Voluptatum in nesciunt officia voluptates ratione quo id harum quo.", new DateTime(2023, 1, 14, 6, 58, 1, 212, DateTimeKind.Unspecified).AddTicks(5597), 18L, true },
                    { 7L, 100L, "Eaque et consequatur.", new DateTime(2023, 8, 5, 22, 41, 16, 570, DateTimeKind.Unspecified).AddTicks(7835), 38L, true },
                    { 8L, 10L, "Rerum dolores consequuntur cumque reiciendis iste qui. Omnis animi alias sed facilis. Blanditiis perferendis cumque. Quo nulla consectetur. Quasi impedit qui quis vitae maxime quidem ut pariatur quis.", new DateTime(2023, 7, 9, 8, 49, 26, 454, DateTimeKind.Unspecified).AddTicks(3330), 11L, true },
                    { 9L, 61L, "Soluta ducimus odit est assumenda vitae quo quam.\nIpsa voluptas ut rem architecto eligendi eum itaque.\nQuam debitis id.\nVoluptas est labore placeat harum voluptatem.\nPariatur facere ea assumenda laboriosam.\nQui dicta voluptatem.", new DateTime(2023, 8, 11, 13, 8, 31, 3, DateTimeKind.Unspecified).AddTicks(5648), 40L, true },
                    { 10L, 39L, "Nemo corporis vel exercitationem ea hic quia quidem.", new DateTime(2022, 5, 12, 2, 51, 5, 521, DateTimeKind.Unspecified).AddTicks(6361), 6L, true },
                    { 11L, 42L, "Sit qui nobis aut at nostrum.\nTotam magni ipsa exercitationem ullam tempore voluptas autem saepe expedita.\nEos vel itaque.\nLaboriosam autem commodi non sed.", new DateTime(2023, 6, 20, 23, 13, 8, 23, DateTimeKind.Unspecified).AddTicks(5801), 9L, false },
                    { 12L, 115L, "Veniam quia corporis voluptas cupiditate velit eum quo dolore. Veritatis et est officiis in. Voluptatum aut totam aperiam. Est fugit necessitatibus maxime voluptas quia porro. Et eius quas fuga vero deleniti dolorum deserunt vel.", new DateTime(2023, 6, 27, 19, 12, 26, 628, DateTimeKind.Unspecified).AddTicks(4965), 40L, false },
                    { 13L, 147L, "dicta", new DateTime(2022, 9, 3, 18, 57, 18, 58, DateTimeKind.Unspecified).AddTicks(2101), 36L, false },
                    { 14L, 181L, "Quo voluptatem rerum corporis quidem veritatis velit explicabo. Labore nam vitae voluptas. Iste accusantium temporibus. Omnis similique distinctio ut quod aperiam. Cupiditate accusantium nesciunt aperiam ducimus non.", new DateTime(2023, 5, 9, 3, 47, 33, 36, DateTimeKind.Unspecified).AddTicks(7269), 8L, true },
                    { 15L, 112L, "maiores", new DateTime(2023, 4, 21, 11, 23, 0, 45, DateTimeKind.Unspecified).AddTicks(8702), 23L, false },
                    { 16L, 178L, "Sit sit quibusdam ab quia nobis.\nPariatur aperiam voluptatibus.\nQuia culpa id.", new DateTime(2022, 11, 3, 19, 8, 4, 586, DateTimeKind.Unspecified).AddTicks(1897), 2L, true },
                    { 17L, 62L, "placeat", new DateTime(2023, 7, 15, 10, 17, 19, 501, DateTimeKind.Unspecified).AddTicks(702), 36L, false },
                    { 18L, 134L, "Incidunt unde eius.\nRerum dolorem magnam nihil reprehenderit qui.\nVoluptatibus ut ea beatae accusamus eius odit sit id eum.", new DateTime(2023, 8, 16, 10, 47, 14, 324, DateTimeKind.Unspecified).AddTicks(5844), 21L, false },
                    { 19L, 101L, "Similique eos et cupiditate.\nEst vero corporis illum deserunt magni aut sit ut.\nVel veritatis enim quo iure incidunt.\nNam aperiam velit voluptas expedita error consequatur optio laudantium quis.\nEt dolores aliquam architecto qui dolor cumque.", new DateTime(2023, 5, 29, 14, 9, 7, 669, DateTimeKind.Unspecified).AddTicks(3489), 3L, false },
                    { 20L, 3L, "Atque ipsum ex laudantium expedita. Et tenetur cum voluptatum et quia eaque doloribus nostrum dolores. Magni voluptas rem. Assumenda et nemo est sunt.", new DateTime(2023, 7, 30, 21, 35, 5, 329, DateTimeKind.Unspecified).AddTicks(7624), 19L, false },
                    { 21L, 176L, "inventore", new DateTime(2022, 6, 27, 8, 0, 14, 50, DateTimeKind.Unspecified).AddTicks(5719), 7L, true },
                    { 22L, 92L, "Aut ut exercitationem aut.", new DateTime(2023, 6, 27, 10, 51, 26, 40, DateTimeKind.Unspecified).AddTicks(9779), 19L, false },
                    { 23L, 43L, "impedit", new DateTime(2023, 2, 15, 23, 13, 46, 381, DateTimeKind.Unspecified).AddTicks(3007), 38L, true },
                    { 24L, 2L, "pariatur", new DateTime(2022, 6, 19, 1, 10, 59, 282, DateTimeKind.Unspecified).AddTicks(2850), 38L, false },
                    { 25L, 48L, "Ea et quo iusto natus ducimus perspiciatis illum eveniet eaque. Voluptas dolores dolor voluptatem enim praesentium pariatur deleniti hic corporis. Quia et unde et accusantium deleniti praesentium laudantium. Autem labore esse recusandae laborum dolorum. Eveniet soluta mollitia necessitatibus ipsam.", new DateTime(2023, 7, 2, 0, 55, 33, 994, DateTimeKind.Unspecified).AddTicks(3858), 7L, true },
                    { 26L, 125L, "Totam velit autem et fuga est.\nNon rerum quidem quam et.\nIusto harum excepturi dicta beatae.\nUt eligendi fugit tenetur.\nAliquid velit ex itaque eos eum veniam ex fuga.\nRepellat non alias.", new DateTime(2023, 8, 21, 20, 22, 55, 168, DateTimeKind.Unspecified).AddTicks(9496), 10L, false },
                    { 27L, 85L, "Voluptatem provident provident aut est.\nVitae natus et voluptatem quo aliquid et.\nVoluptatem non suscipit eum quasi et aliquid.\nOdio nemo odio.", new DateTime(2023, 1, 26, 8, 19, 23, 174, DateTimeKind.Unspecified).AddTicks(2672), 19L, true },
                    { 28L, 181L, "Et optio sed. Aut voluptatum sit voluptas corporis est molestiae corporis nisi. Delectus molestiae ea culpa voluptates et et sapiente.", new DateTime(2023, 3, 10, 0, 11, 40, 538, DateTimeKind.Unspecified).AddTicks(7175), 4L, true },
                    { 29L, 15L, "Voluptatem dolorum ad et.", new DateTime(2023, 7, 11, 1, 1, 24, 999, DateTimeKind.Unspecified).AddTicks(7489), 28L, false },
                    { 30L, 66L, "dignissimos", new DateTime(2023, 8, 22, 13, 47, 21, 434, DateTimeKind.Unspecified).AddTicks(3136), 3L, false },
                    { 31L, 28L, "et", new DateTime(2023, 2, 16, 6, 58, 0, 600, DateTimeKind.Unspecified).AddTicks(5511), 39L, true },
                    { 32L, 68L, "Aut nihil dicta.", new DateTime(2023, 5, 25, 8, 2, 33, 125, DateTimeKind.Unspecified).AddTicks(9120), 28L, true },
                    { 33L, 128L, "Distinctio aperiam ratione corporis soluta qui quos incidunt.", new DateTime(2023, 7, 29, 9, 58, 52, 190, DateTimeKind.Unspecified).AddTicks(6752), 17L, false },
                    { 34L, 139L, "At officiis omnis. Inventore tenetur voluptatem est est. Occaecati similique ut minus voluptatem consequatur facere optio porro libero. Et odio occaecati dolor facilis et voluptas pariatur eaque.", new DateTime(2023, 3, 29, 21, 40, 32, 677, DateTimeKind.Unspecified).AddTicks(1956), 19L, true },
                    { 35L, 73L, "Non sint minima est in eum nihil.", new DateTime(2022, 10, 28, 10, 42, 52, 963, DateTimeKind.Unspecified).AddTicks(1690), 36L, true },
                    { 36L, 45L, "Itaque nam eligendi velit culpa.", new DateTime(2023, 8, 14, 23, 17, 39, 3, DateTimeKind.Unspecified).AddTicks(8548), 18L, false },
                    { 37L, 11L, "esse", new DateTime(2023, 6, 24, 4, 40, 37, 192, DateTimeKind.Unspecified).AddTicks(8770), 32L, false },
                    { 38L, 48L, "Aut nemo dolore aut beatae.", new DateTime(2023, 5, 9, 16, 49, 55, 421, DateTimeKind.Unspecified).AddTicks(9900), 38L, true },
                    { 39L, 183L, "Beatae ex exercitationem et ea aut.", new DateTime(2023, 8, 22, 16, 51, 27, 964, DateTimeKind.Unspecified).AddTicks(7159), 40L, true },
                    { 40L, 8L, "Beatae est quam et quisquam laudantium officia. Aut fugiat est quo magnam sint eos molestiae. Aliquam enim omnis totam ea. Aut repudiandae est molestiae rerum enim magnam laboriosam labore corrupti. Est iure qui omnis modi consequatur vero maxime. Cupiditate occaecati distinctio voluptatem quos illo rerum est id error.", new DateTime(2022, 10, 25, 5, 31, 25, 727, DateTimeKind.Unspecified).AddTicks(5410), 29L, true },
                    { 41L, 122L, "Sed cumque nihil.\nQuos sed ut perspiciatis autem rem id est aperiam.\nEt quisquam reprehenderit commodi veniam magnam dolores.\nFugiat commodi non id tempore ducimus.\nAlias officia quia animi ratione enim sequi voluptatem.\nAperiam maiores enim.", new DateTime(2023, 1, 28, 22, 28, 11, 150, DateTimeKind.Unspecified).AddTicks(2384), 24L, false },
                    { 42L, 13L, "nihil", new DateTime(2022, 6, 11, 18, 44, 26, 574, DateTimeKind.Unspecified).AddTicks(2365), 15L, true }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "IsPublic" },
                values: new object[,]
                {
                    { 43L, 67L, "Cumque culpa aut et inventore.", new DateTime(2023, 7, 19, 19, 40, 19, 360, DateTimeKind.Unspecified).AddTicks(4990), 35L, false },
                    { 44L, 23L, "In quia rerum tempora voluptas in quis sit ullam earum. Minus magnam voluptatem non ut laborum sit veniam cum sequi. Ut similique ipsum quis voluptatem est qui quia velit. Repudiandae cumque earum debitis illum fugiat aliquid hic. Odit doloremque possimus. Quis et aperiam aut doloribus magnam similique fuga.", new DateTime(2023, 3, 13, 17, 35, 58, 946, DateTimeKind.Unspecified).AddTicks(6220), 22L, false },
                    { 45L, 38L, "Deleniti eos sint.", new DateTime(2023, 2, 8, 6, 48, 6, 93, DateTimeKind.Unspecified).AddTicks(7669), 22L, true },
                    { 46L, 58L, "Et vitae omnis. Suscipit quidem ab voluptas qui officiis et tempore tempora ut. Officiis nulla architecto et. Esse expedita et omnis officiis consequatur cupiditate sint vero incidunt. Omnis et tenetur voluptatem et rem qui.", new DateTime(2023, 8, 10, 7, 16, 45, 890, DateTimeKind.Unspecified).AddTicks(2750), 28L, true },
                    { 47L, 52L, "dignissimos", new DateTime(2022, 8, 6, 2, 47, 3, 4, DateTimeKind.Unspecified).AddTicks(9544), 37L, false },
                    { 48L, 137L, "corporis", new DateTime(2022, 1, 15, 1, 42, 18, 5, DateTimeKind.Unspecified).AddTicks(6217), 1L, true },
                    { 49L, 2L, "Alias aut cupiditate fugit magni maiores repudiandae.\nDolore est enim illum magnam.\nQuaerat repellendus quia exercitationem minus in.\nSint et eveniet.\nNecessitatibus omnis perspiciatis reprehenderit provident corrupti quis sequi voluptas rem.\nVoluptas commodi unde optio dolorem architecto.", new DateTime(2023, 4, 22, 6, 29, 48, 589, DateTimeKind.Unspecified).AddTicks(5936), 26L, true },
                    { 50L, 20L, "Quia eligendi veniam itaque quam occaecati. Ipsa et dolores et et consequatur. Porro quia maiores distinctio et recusandae dolor voluptatem sapiente placeat. Voluptate maiores molestias. Aliquam magnam odit et quia quasi quo quia aliquid. Aut maiores iusto dolores tempora corporis voluptatem quibusdam.", new DateTime(2023, 8, 23, 1, 37, 24, 958, DateTimeKind.Unspecified).AddTicks(3159), 4L, true },
                    { 51L, 194L, "eos", new DateTime(2023, 7, 29, 0, 43, 54, 721, DateTimeKind.Unspecified).AddTicks(215), 13L, true },
                    { 52L, 35L, "Sed aut quia.\nRerum dolores dolor dolore voluptates.\nSint quidem non fugit rerum ut rerum minus dignissimos est.\nRerum numquam autem mollitia amet dolore nobis.\nVoluptas odit tempore ducimus quisquam enim.\nQuaerat omnis nisi.", new DateTime(2023, 7, 14, 21, 26, 51, 38, DateTimeKind.Unspecified).AddTicks(7466), 23L, true },
                    { 53L, 60L, "Voluptatem dolores maxime voluptatem.", new DateTime(2023, 5, 13, 11, 35, 17, 294, DateTimeKind.Unspecified).AddTicks(4375), 40L, true },
                    { 54L, 130L, "ea", new DateTime(2023, 7, 22, 23, 1, 35, 882, DateTimeKind.Unspecified).AddTicks(8420), 16L, false },
                    { 55L, 51L, "Assumenda qui assumenda.\nAmet quia nulla recusandae.\nConsequuntur reprehenderit ad.\nInventore optio quibusdam et in.\nQuas distinctio dolor.\nAut qui voluptatem voluptatem dolorum.", new DateTime(2023, 8, 13, 5, 32, 41, 695, DateTimeKind.Unspecified).AddTicks(9120), 40L, false },
                    { 56L, 180L, "Repellendus quae est sint fugiat non.", new DateTime(2023, 6, 3, 18, 47, 48, 368, DateTimeKind.Unspecified).AddTicks(5799), 9L, true },
                    { 57L, 31L, "Nisi tenetur delectus facere sed est eum et officia.\nDistinctio distinctio accusamus rerum tempora soluta non qui maxime.\nEveniet ad est ratione quo quod quia id sunt ut.\nQuas voluptas voluptatum.\nLibero veniam quia dolor repellat eveniet a adipisci aliquam doloribus.\nDelectus ipsa tempore voluptate repellat.", new DateTime(2023, 7, 27, 0, 15, 30, 154, DateTimeKind.Unspecified).AddTicks(8671), 34L, false },
                    { 58L, 164L, "corporis", new DateTime(2022, 7, 5, 12, 4, 8, 560, DateTimeKind.Unspecified).AddTicks(2705), 19L, true },
                    { 59L, 1L, "Id nesciunt saepe qui voluptates natus in. Ea maxime explicabo. Beatae qui nesciunt blanditiis omnis beatae non neque aut et. Earum provident et commodi laudantium vitae voluptatem rem. Aspernatur culpa occaecati. Commodi similique magni fugit aut voluptates temporibus sed minus.", new DateTime(2023, 8, 12, 2, 43, 20, 596, DateTimeKind.Unspecified).AddTicks(221), 37L, false },
                    { 60L, 184L, "Pariatur optio facilis eum sint hic.\nConsequatur adipisci recusandae consequatur ipsa ad reiciendis nulla et.\nVoluptas sunt quia hic illum voluptatem veritatis sed cupiditate non.\nVoluptates blanditiis aut dolores quidem voluptatem ut.\nRecusandae eligendi ipsam velit impedit quia.", new DateTime(2023, 6, 25, 2, 24, 50, 302, DateTimeKind.Unspecified).AddTicks(458), 37L, true },
                    { 61L, 197L, "Dolores aperiam suscipit dolores. Et doloremque perspiciatis culpa impedit asperiores. Suscipit explicabo id consequuntur molestias ea magnam quo. Error sit aut cum et dolorem. Architecto nesciunt consequatur soluta blanditiis consequatur esse nihil totam alias. Cupiditate ut at ex.", new DateTime(2023, 4, 3, 2, 6, 3, 625, DateTimeKind.Unspecified).AddTicks(9933), 27L, true },
                    { 62L, 190L, "dolor", new DateTime(2023, 3, 9, 0, 28, 16, 245, DateTimeKind.Unspecified).AddTicks(3685), 14L, true },
                    { 63L, 187L, "porro", new DateTime(2023, 2, 18, 6, 42, 55, 878, DateTimeKind.Unspecified).AddTicks(5709), 14L, false },
                    { 64L, 29L, "Rem nihil nisi ipsam. Ut cum ipsam distinctio molestias. Est voluptatum officia non. Est consequatur magni autem. Consequuntur omnis voluptatem dicta esse est atque in.", new DateTime(2023, 8, 12, 17, 33, 44, 596, DateTimeKind.Unspecified).AddTicks(6791), 8L, true },
                    { 65L, 186L, "eum", new DateTime(2023, 7, 13, 4, 26, 24, 767, DateTimeKind.Unspecified).AddTicks(6274), 1L, true },
                    { 66L, 113L, "Et nostrum rerum aut et.", new DateTime(2023, 8, 16, 14, 46, 34, 85, DateTimeKind.Unspecified).AddTicks(9944), 29L, true },
                    { 67L, 198L, "Aut velit ut nam voluptatem tempora accusamus voluptatem adipisci.\nSint voluptas quae debitis autem quia minima natus.\nEt est dignissimos vero fugiat officiis voluptates modi.\nCupiditate omnis molestiae molestias consequatur ut delectus eligendi eaque.\nVoluptatem dolor occaecati vitae nesciunt.\nEst natus et.", new DateTime(2023, 8, 14, 16, 23, 49, 77, DateTimeKind.Unspecified).AddTicks(9033), 37L, true },
                    { 68L, 40L, "tenetur", new DateTime(2023, 6, 12, 15, 8, 14, 93, DateTimeKind.Unspecified).AddTicks(3162), 18L, true },
                    { 69L, 151L, "Consequatur sit quibusdam iusto vel aut.\nOptio voluptates soluta dolorem perferendis et et explicabo facilis quis.\nVeritatis ipsam nulla ut distinctio animi voluptatem voluptas.\nDolorem incidunt non eos non voluptatum voluptates.\nQuas quis est enim omnis animi consequatur beatae molestias.", new DateTime(2023, 1, 18, 18, 48, 47, 985, DateTimeKind.Unspecified).AddTicks(4400), 34L, true },
                    { 70L, 31L, "rem", new DateTime(2022, 12, 5, 9, 18, 34, 466, DateTimeKind.Unspecified).AddTicks(4656), 18L, false },
                    { 71L, 16L, "Velit fugit aut praesentium autem.\nEum perspiciatis rerum sed sit magni.\nEa error quam ullam porro voluptatum nesciunt.\nNulla necessitatibus repellat quas.\nPossimus autem ipsam.", new DateTime(2020, 11, 28, 11, 46, 42, 163, DateTimeKind.Unspecified).AddTicks(18), 14L, true },
                    { 72L, 122L, "dicta", new DateTime(2023, 6, 23, 6, 19, 7, 427, DateTimeKind.Unspecified).AddTicks(2311), 13L, true },
                    { 73L, 147L, "Fugit saepe excepturi et excepturi fugit deserunt ea ratione possimus. Et quia aliquid. Aut tenetur qui nihil. Tempora natus provident. Magni ducimus enim a vitae repellat voluptates sunt laudantium amet.", new DateTime(2023, 2, 9, 13, 31, 17, 850, DateTimeKind.Unspecified).AddTicks(1650), 20L, false },
                    { 74L, 127L, "Repudiandae non dolore quaerat iure itaque id vel commodi.\nArchitecto velit nobis id omnis.\nCupiditate temporibus et voluptas harum.\nVoluptatem nulla excepturi voluptatem voluptatem.\nIncidunt corrupti quis dolor veritatis modi ipsam.", new DateTime(2023, 8, 19, 9, 25, 24, 993, DateTimeKind.Unspecified).AddTicks(624), 30L, true },
                    { 75L, 62L, "Quisquam est quo autem dolor ducimus dolor.\nSapiente autem corrupti et voluptatem mollitia dolor in.\nUt sint sed ratione officiis reiciendis saepe eos.\nQuam et quasi et quae iste.", new DateTime(2023, 7, 31, 20, 27, 51, 198, DateTimeKind.Unspecified).AddTicks(5547), 24L, true },
                    { 76L, 75L, "eos", new DateTime(2021, 11, 21, 4, 44, 59, 69, DateTimeKind.Unspecified).AddTicks(8657), 18L, true },
                    { 77L, 70L, "Quaerat architecto quisquam pariatur necessitatibus reiciendis molestias deserunt.\nMolestiae pariatur tempore earum labore voluptatem.\nQuaerat similique nesciunt.\nNon quos explicabo repellat ad iure est et.", new DateTime(2023, 6, 23, 7, 30, 53, 796, DateTimeKind.Unspecified).AddTicks(2979), 23L, true },
                    { 78L, 37L, "Debitis eum cumque quasi.", new DateTime(2023, 6, 15, 16, 12, 29, 735, DateTimeKind.Unspecified).AddTicks(3088), 22L, false },
                    { 79L, 195L, "Fugiat et eveniet illo perspiciatis dolor voluptatem quis. Omnis voluptas voluptatibus quisquam sunt et consequatur facilis et. Officiis molestias ad quod ea recusandae voluptas consectetur. Suscipit sed delectus animi laudantium aliquam. Quia quo consequatur et et provident.", new DateTime(2023, 3, 31, 23, 10, 28, 585, DateTimeKind.Unspecified).AddTicks(6183), 18L, true },
                    { 80L, 108L, "Dolores soluta blanditiis eveniet quisquam nesciunt possimus labore natus voluptas.", new DateTime(2023, 8, 19, 22, 16, 46, 235, DateTimeKind.Unspecified).AddTicks(4700), 9L, true },
                    { 81L, 107L, "Autem neque sint totam magni dolor expedita fugiat.\nUt laboriosam sed impedit exercitationem dolore.", new DateTime(2023, 4, 25, 2, 21, 4, 564, DateTimeKind.Unspecified).AddTicks(831), 28L, true },
                    { 82L, 66L, "Odio impedit perferendis rerum. Quia eligendi qui excepturi eveniet itaque non est hic rerum. Consequatur quas et et minima molestiae esse. Pariatur doloremque nostrum officia officiis exercitationem non voluptatem.", new DateTime(2023, 8, 22, 19, 51, 34, 484, DateTimeKind.Unspecified).AddTicks(9394), 29L, true },
                    { 83L, 145L, "Sit deleniti eos vero.", new DateTime(2023, 3, 4, 17, 32, 32, 306, DateTimeKind.Unspecified).AddTicks(5173), 24L, true },
                    { 84L, 46L, "Eum voluptas sed vitae et delectus sint nostrum.\nEaque sapiente aut odit quo.\nDelectus temporibus id aspernatur.", new DateTime(2021, 12, 23, 1, 35, 13, 723, DateTimeKind.Unspecified).AddTicks(568), 3L, true }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "IsPublic" },
                values: new object[,]
                {
                    { 85L, 14L, "Molestiae nihil velit aut odit.", new DateTime(2023, 8, 22, 14, 4, 32, 153, DateTimeKind.Unspecified).AddTicks(6043), 40L, true },
                    { 86L, 146L, "ut", new DateTime(2023, 8, 22, 8, 29, 32, 39, DateTimeKind.Unspecified).AddTicks(9648), 4L, true },
                    { 87L, 29L, "occaecati", new DateTime(2023, 7, 25, 22, 39, 35, 915, DateTimeKind.Unspecified).AddTicks(9349), 9L, true },
                    { 88L, 103L, "qui", new DateTime(2023, 5, 6, 19, 26, 16, 918, DateTimeKind.Unspecified).AddTicks(3521), 33L, true },
                    { 89L, 135L, "Assumenda sed aut omnis voluptatem ut ipsam.\nQuia delectus culpa rerum neque.", new DateTime(2023, 5, 22, 5, 41, 28, 801, DateTimeKind.Unspecified).AddTicks(8701), 10L, true },
                    { 90L, 175L, "Iste et sint.\nQuisquam necessitatibus veniam.\nEt ullam eveniet fugiat non autem enim assumenda.\nNemo voluptas quae necessitatibus sed recusandae labore quidem porro.", new DateTime(2023, 7, 3, 18, 37, 24, 684, DateTimeKind.Unspecified).AddTicks(3504), 11L, true },
                    { 91L, 8L, "est", new DateTime(2023, 1, 8, 14, 19, 36, 991, DateTimeKind.Unspecified).AddTicks(365), 1L, true },
                    { 92L, 158L, "Ipsa molestiae aliquam et vel et quasi maxime tenetur.", new DateTime(2022, 8, 11, 21, 36, 8, 541, DateTimeKind.Unspecified).AddTicks(7262), 20L, true },
                    { 93L, 85L, "Totam magni aliquid maiores cum laudantium consequatur perferendis consequatur.", new DateTime(2023, 1, 14, 6, 43, 19, 350, DateTimeKind.Unspecified).AddTicks(9624), 9L, true },
                    { 94L, 192L, "Quam deleniti veritatis voluptatem laboriosam. Voluptatem reprehenderit doloremque dolorem necessitatibus omnis dicta quasi autem. Tempore saepe similique sint distinctio et est voluptatem eaque. Dignissimos quia perspiciatis eligendi dolorem hic. Nihil reiciendis asperiores. Voluptatem quam cum accusamus sapiente.", new DateTime(2023, 6, 16, 15, 11, 43, 173, DateTimeKind.Unspecified).AddTicks(4694), 23L, true },
                    { 95L, 85L, "Iusto sed aliquid tempora delectus nihil iste accusamus. Tempora molestiae nisi inventore pariatur suscipit nisi earum. Nam explicabo quibusdam dolores cupiditate voluptatum saepe ab. Voluptates aspernatur maxime autem atque nihil in odit. Rem quisquam aut quisquam.", new DateTime(2023, 7, 31, 20, 32, 40, 255, DateTimeKind.Unspecified).AddTicks(7811), 24L, true },
                    { 96L, 111L, "Consequatur fugit dolorum dolorem et.", new DateTime(2023, 4, 19, 6, 32, 54, 435, DateTimeKind.Unspecified).AddTicks(5108), 26L, true },
                    { 97L, 49L, "Suscipit sint consequatur est est repellat et odio rerum atque. Dolor accusamus modi officia earum tempore tempore ut. Voluptatibus natus labore qui quis recusandae fugit.", new DateTime(2023, 8, 9, 10, 48, 50, 798, DateTimeKind.Unspecified).AddTicks(8568), 3L, true },
                    { 98L, 120L, "qui", new DateTime(2023, 8, 15, 1, 16, 30, 964, DateTimeKind.Unspecified).AddTicks(6338), 8L, true },
                    { 99L, 62L, "Quos illo eligendi voluptas autem odio ullam. Delectus voluptatem reiciendis nesciunt eaque velit. Omnis soluta quam ea voluptas aut consectetur eius culpa quod. Eaque enim quo ea tempora eveniet voluptatem.", new DateTime(2023, 8, 17, 10, 7, 27, 843, DateTimeKind.Unspecified).AddTicks(3011), 38L, true },
                    { 100L, 6L, "Harum impedit ad ut vitae culpa magni minus cumque. Quas ullam velit excepturi quo ullam fugiat. Officia et ea.", new DateTime(2022, 6, 17, 8, 50, 11, 133, DateTimeKind.Unspecified).AddTicks(1937), 23L, true },
                    { 101L, 146L, "quo", new DateTime(2023, 8, 23, 6, 54, 23, 527, DateTimeKind.Unspecified).AddTicks(8562), 39L, true },
                    { 102L, 143L, "Quia quia repudiandae voluptatem et nesciunt odio. Sunt tempora eveniet non atque. Mollitia vel sunt facere quia velit ducimus id eos.", new DateTime(2023, 8, 10, 12, 17, 49, 614, DateTimeKind.Unspecified).AddTicks(9723), 1L, false },
                    { 103L, 108L, "Qui optio minus sunt ut corporis.", new DateTime(2023, 4, 3, 12, 16, 43, 471, DateTimeKind.Unspecified).AddTicks(8331), 21L, true },
                    { 104L, 119L, "Aspernatur qui nisi nam neque.", new DateTime(2020, 9, 26, 6, 35, 44, 162, DateTimeKind.Unspecified).AddTicks(873), 6L, true },
                    { 105L, 31L, "Quibusdam veritatis animi eaque sed excepturi. Esse eaque accusamus voluptas provident neque. Qui quas illo molestiae in eos saepe quae ut.", new DateTime(2023, 2, 27, 12, 20, 9, 264, DateTimeKind.Unspecified).AddTicks(5968), 2L, false },
                    { 106L, 101L, "Ut hic at ut quis exercitationem quo nihil.", new DateTime(2023, 2, 3, 8, 21, 23, 379, DateTimeKind.Unspecified).AddTicks(7082), 1L, true },
                    { 107L, 47L, "quia", new DateTime(2023, 1, 28, 18, 43, 11, 108, DateTimeKind.Unspecified).AddTicks(5762), 33L, true },
                    { 108L, 61L, "Non beatae inventore.", new DateTime(2023, 6, 22, 9, 56, 58, 727, DateTimeKind.Unspecified).AddTicks(4452), 23L, true },
                    { 109L, 105L, "Sequi accusamus vitae nihil.\nSint doloribus doloribus debitis ut maxime et omnis dolore.\nVoluptatem rerum est fugit ut voluptatibus unde.\nEa amet consectetur saepe omnis.", new DateTime(2023, 2, 9, 2, 54, 18, 933, DateTimeKind.Unspecified).AddTicks(1711), 22L, false },
                    { 110L, 63L, "Doloremque eos aperiam nemo omnis.", new DateTime(2023, 4, 27, 4, 51, 1, 187, DateTimeKind.Unspecified).AddTicks(6330), 33L, true },
                    { 111L, 32L, "Cupiditate vel qui repellat libero voluptatem id et. Est omnis soluta occaecati culpa. Odio totam qui. Fuga perspiciatis exercitationem numquam iusto doloribus in quia et et.", new DateTime(2023, 3, 30, 10, 54, 43, 863, DateTimeKind.Unspecified).AddTicks(2507), 22L, false },
                    { 112L, 85L, "Vitae qui non quasi non sint aliquid repellat.", new DateTime(2023, 6, 22, 9, 48, 46, 214, DateTimeKind.Unspecified).AddTicks(3953), 15L, true },
                    { 113L, 13L, "Ex atque quibusdam rerum. Incidunt mollitia exercitationem consequatur. Pariatur aut maiores. Nobis voluptatem ut.", new DateTime(2022, 12, 17, 2, 29, 20, 524, DateTimeKind.Unspecified).AddTicks(2868), 38L, false },
                    { 114L, 180L, "Odit adipisci exercitationem autem pariatur quidem. Sed excepturi quod aut odio minus et ad iusto. Non occaecati reiciendis cum quo commodi.", new DateTime(2023, 8, 1, 21, 15, 24, 827, DateTimeKind.Unspecified).AddTicks(8232), 23L, false },
                    { 115L, 58L, "Error esse velit sit provident.\nRecusandae et dignissimos quis corporis est exercitationem et ullam dolore.", new DateTime(2023, 8, 1, 17, 56, 16, 356, DateTimeKind.Unspecified).AddTicks(8150), 32L, true },
                    { 116L, 80L, "Nihil explicabo temporibus.", new DateTime(2022, 9, 24, 5, 40, 13, 528, DateTimeKind.Unspecified).AddTicks(6157), 17L, false },
                    { 117L, 101L, "Veritatis ratione neque quia reprehenderit accusantium ea ut quis.", new DateTime(2023, 2, 9, 23, 51, 28, 528, DateTimeKind.Unspecified).AddTicks(2601), 4L, true },
                    { 118L, 107L, "Quia animi quos minima assumenda earum.\nNecessitatibus voluptatum doloribus voluptatem ut dolores nesciunt.", new DateTime(2023, 2, 17, 19, 13, 11, 448, DateTimeKind.Unspecified).AddTicks(9635), 7L, false },
                    { 119L, 27L, "et", new DateTime(2023, 8, 9, 1, 10, 29, 746, DateTimeKind.Unspecified).AddTicks(791), 37L, true },
                    { 120L, 185L, "Aut assumenda consequatur ad quam omnis reiciendis. Et error consequatur inventore quia sunt enim cumque. Impedit eos fugiat consequuntur aut earum.", new DateTime(2022, 12, 18, 20, 2, 12, 128, DateTimeKind.Unspecified).AddTicks(3485), 18L, true },
                    { 121L, 139L, "Eligendi enim qui.", new DateTime(2023, 4, 11, 5, 36, 8, 444, DateTimeKind.Unspecified).AddTicks(6157), 25L, true },
                    { 122L, 24L, "Ut dolor sequi qui qui dolor sequi corrupti.", new DateTime(2021, 7, 28, 23, 59, 53, 371, DateTimeKind.Unspecified).AddTicks(364), 35L, false },
                    { 123L, 86L, "Labore autem alias.\nDicta cum voluptatibus incidunt eligendi est aut exercitationem est.\nSoluta ut sequi ut nobis.\nVitae cum tempore et voluptas voluptas fugit ipsam animi.", new DateTime(2023, 2, 6, 17, 27, 2, 975, DateTimeKind.Unspecified).AddTicks(1082), 8L, true },
                    { 124L, 110L, "Veritatis animi nostrum vel ipsa sint.", new DateTime(2023, 7, 26, 2, 20, 53, 793, DateTimeKind.Unspecified).AddTicks(4202), 33L, true },
                    { 125L, 199L, "Iusto a nihil. Dolorem cumque itaque natus. Possimus et quia natus libero harum voluptatem a. Provident incidunt voluptates dolorum quis eos at facilis saepe provident. Accusamus fuga aut modi.", new DateTime(2023, 8, 13, 3, 52, 58, 322, DateTimeKind.Unspecified).AddTicks(6122), 26L, false },
                    { 126L, 37L, "Odio saepe commodi.\nTempora inventore deleniti dolore repudiandae velit voluptas eligendi aliquid.\nNumquam illum officia voluptas ad.", new DateTime(2020, 1, 31, 4, 28, 35, 443, DateTimeKind.Unspecified).AddTicks(2784), 17L, false }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "IsPublic" },
                values: new object[,]
                {
                    { 127L, 183L, "Aspernatur similique autem asperiores. In similique totam temporibus perferendis aliquam non. Quibusdam neque est dolorum sit accusantium recusandae non.", new DateTime(2023, 5, 30, 8, 39, 59, 144, DateTimeKind.Unspecified).AddTicks(2369), 3L, false },
                    { 128L, 43L, "Aliquam eaque unde non. Eaque a repudiandae blanditiis sint expedita dignissimos quia. Occaecati velit natus veritatis quia deleniti sit nesciunt dolor voluptas. Velit expedita consectetur temporibus minus rerum distinctio fugit reprehenderit.", new DateTime(2023, 5, 14, 7, 47, 36, 160, DateTimeKind.Unspecified).AddTicks(7466), 19L, false },
                    { 129L, 50L, "Magnam consectetur cumque ea qui consequatur facilis iure culpa. Doloribus cum aut nesciunt aspernatur aliquam. Est excepturi eum assumenda. Est aut asperiores. Qui libero assumenda minus fugiat.", new DateTime(2023, 7, 9, 9, 0, 51, 147, DateTimeKind.Unspecified).AddTicks(9697), 26L, true },
                    { 130L, 73L, "Eius reprehenderit perferendis et quia ut a maiores enim ut. Dolores dolore alias. Numquam quasi magni totam est.", new DateTime(2023, 8, 14, 9, 58, 9, 363, DateTimeKind.Unspecified).AddTicks(1435), 4L, true },
                    { 131L, 198L, "Quod et neque reprehenderit magni quia magnam quas.\nQuis ut repudiandae.\nSit aut sit dolores iste ad.\nFugiat itaque reprehenderit sunt quidem et.\nEst delectus enim eaque dolor.\nSimilique numquam sint voluptatem voluptas.", new DateTime(2023, 8, 15, 12, 43, 12, 876, DateTimeKind.Unspecified).AddTicks(1830), 40L, true },
                    { 132L, 21L, "nulla", new DateTime(2023, 8, 3, 13, 22, 11, 686, DateTimeKind.Unspecified).AddTicks(379), 40L, true },
                    { 133L, 167L, "Qui quam ut commodi.", new DateTime(2023, 1, 9, 6, 9, 33, 155, DateTimeKind.Unspecified).AddTicks(6608), 27L, false },
                    { 134L, 53L, "Facilis ut consequatur sit temporibus iste et aut sunt. Expedita similique tenetur corrupti suscipit facere unde rem quam. Est magnam qui est dolorum fugiat asperiores. Velit et natus vitae ex dolores aliquid a. Sint enim distinctio inventore ut.", new DateTime(2023, 8, 2, 17, 15, 4, 165, DateTimeKind.Unspecified).AddTicks(5976), 38L, true },
                    { 135L, 143L, "Quos ab consequuntur fugit suscipit aut quia reprehenderit consequatur vitae.", new DateTime(2023, 7, 13, 1, 50, 21, 998, DateTimeKind.Unspecified).AddTicks(7128), 23L, false },
                    { 136L, 153L, "Nemo sunt numquam blanditiis eos vel vel aperiam neque.", new DateTime(2023, 8, 20, 0, 0, 27, 350, DateTimeKind.Unspecified).AddTicks(4508), 30L, true },
                    { 137L, 65L, "Assumenda dignissimos sed dolore ea sed ducimus placeat et.", new DateTime(2023, 4, 8, 17, 14, 20, 183, DateTimeKind.Unspecified).AddTicks(2365), 6L, false },
                    { 138L, 146L, "Debitis molestias quam. Aliquid quidem recusandae. Fugit tempore explicabo tenetur in et et ea. Veniam earum excepturi dignissimos recusandae aperiam.", new DateTime(2023, 8, 23, 11, 9, 54, 338, DateTimeKind.Unspecified).AddTicks(9022), 33L, false },
                    { 139L, 46L, "quia", new DateTime(2023, 4, 10, 14, 57, 53, 731, DateTimeKind.Unspecified).AddTicks(8045), 10L, true },
                    { 140L, 183L, "Similique nemo ducimus magni.\nVel magni est voluptatem dolores quia deserunt.\nNatus nihil consequatur eos nulla et earum voluptatum eligendi adipisci.\nNam quibusdam error rerum qui et ratione.", new DateTime(2023, 8, 8, 12, 38, 16, 645, DateTimeKind.Unspecified).AddTicks(5206), 8L, true },
                    { 141L, 163L, "quo", new DateTime(2023, 8, 10, 4, 46, 49, 141, DateTimeKind.Unspecified).AddTicks(908), 3L, true },
                    { 142L, 193L, "Consequatur et vel et et cupiditate vitae quis.", new DateTime(2023, 8, 18, 16, 2, 28, 421, DateTimeKind.Unspecified).AddTicks(5957), 26L, true },
                    { 143L, 86L, "Totam quo illum dolore odit nesciunt ut voluptatem occaecati optio. Similique ipsum ab nulla officia eos magni maiores. Debitis veniam iste rerum commodi et quos amet ut.", new DateTime(2021, 6, 4, 4, 55, 17, 915, DateTimeKind.Unspecified).AddTicks(7662), 39L, true },
                    { 144L, 19L, "Dolore iste ut unde sit. Eos unde necessitatibus tenetur voluptates voluptatem. Nihil et et. Veniam ipsa amet sequi accusamus rerum id nam neque ea.", new DateTime(2022, 9, 27, 8, 14, 45, 825, DateTimeKind.Unspecified).AddTicks(3119), 31L, true },
                    { 145L, 2L, "Iste laboriosam culpa saepe odio consequatur corrupti nihil.", new DateTime(2023, 2, 18, 23, 18, 42, 300, DateTimeKind.Unspecified).AddTicks(2654), 17L, true },
                    { 146L, 96L, "quasi", new DateTime(2020, 11, 20, 16, 46, 59, 240, DateTimeKind.Unspecified).AddTicks(6576), 33L, false },
                    { 147L, 16L, "Dolores vel tempore harum.\nVero accusantium assumenda quis sed velit distinctio laborum natus vitae.\nMinus qui rem omnis omnis ratione vel voluptatum sit quos.\nAut dolorem ducimus.\nQuibusdam autem unde nihil sapiente et voluptatem natus.\nPraesentium expedita quisquam itaque asperiores non natus molestias qui consequatur.", new DateTime(2021, 10, 20, 5, 4, 14, 751, DateTimeKind.Unspecified).AddTicks(9894), 11L, true },
                    { 148L, 58L, "Error adipisci laborum iure voluptas ratione id voluptas voluptate et.", new DateTime(2023, 7, 17, 20, 1, 32, 39, DateTimeKind.Unspecified).AddTicks(2581), 6L, true },
                    { 149L, 179L, "totam", new DateTime(2022, 6, 23, 22, 47, 50, 67, DateTimeKind.Unspecified).AddTicks(4188), 4L, true },
                    { 150L, 10L, "Atque dicta recusandae qui corrupti nesciunt quis aut cupiditate.", new DateTime(2023, 5, 23, 21, 25, 41, 614, DateTimeKind.Unspecified).AddTicks(919), 18L, true },
                    { 151L, 146L, "Amet ipsam illo debitis.\nVel facilis dolores consequatur enim asperiores est.\nFacere labore nostrum natus est quo non blanditiis.\nDistinctio dignissimos rem corporis.\nLabore voluptates nihil.", new DateTime(2023, 8, 22, 18, 3, 27, 540, DateTimeKind.Unspecified).AddTicks(62), 33L, true },
                    { 152L, 153L, "Ab unde laboriosam aut odio iusto numquam numquam neque.", new DateTime(2023, 6, 24, 18, 42, 53, 964, DateTimeKind.Unspecified).AddTicks(9518), 31L, true },
                    { 153L, 72L, "Repellat quia quo alias expedita est voluptate tempora. Voluptate qui nam unde eligendi. Doloribus esse laudantium labore perferendis ut est dicta voluptatem. Dignissimos minima impedit sint quia et ab eum sit corporis. Aut suscipit fugit dignissimos eos fugit illum aperiam. Omnis libero rem aut qui ex nisi dolorum eos.", new DateTime(2023, 3, 31, 5, 42, 51, 694, DateTimeKind.Unspecified).AddTicks(2793), 2L, true },
                    { 154L, 66L, "non", new DateTime(2023, 8, 23, 9, 47, 17, 545, DateTimeKind.Unspecified).AddTicks(788), 13L, false },
                    { 155L, 197L, "Non iure explicabo voluptatibus vitae ut quibusdam debitis ut. Illo ipsum esse omnis consequatur id cupiditate delectus dicta. Ut distinctio repudiandae distinctio voluptatem ullam. Fugit iusto et vero inventore ipsam porro eos vitae debitis. Ad asperiores dolorem maiores quia animi.", new DateTime(2023, 4, 17, 18, 41, 17, 167, DateTimeKind.Unspecified).AddTicks(7567), 25L, true },
                    { 156L, 133L, "Repellat necessitatibus aut et accusamus rem et distinctio dolor.\nNobis odio et recusandae asperiores vero.\nQuidem est vero odit est explicabo id voluptatibus.\nIpsam soluta autem cum totam mollitia rem.\nVero dolorem sed.\nEnim est ducimus facere quos unde qui perspiciatis est.", new DateTime(2023, 7, 17, 8, 7, 6, 113, DateTimeKind.Unspecified).AddTicks(5434), 27L, false },
                    { 157L, 177L, "Cum enim quibusdam. Aut sit nesciunt facere accusamus odit reiciendis. Ut esse beatae. Et pariatur commodi fugit voluptate ex adipisci perspiciatis praesentium. Nulla et eligendi consequuntur possimus nam. Commodi laboriosam perspiciatis quis optio delectus earum qui optio.", new DateTime(2023, 4, 15, 21, 0, 50, 254, DateTimeKind.Unspecified).AddTicks(23), 23L, true },
                    { 158L, 122L, "Neque perferendis quasi iusto soluta cumque quia.\nMagnam quae dignissimos.\nMolestias inventore quod aliquid enim quis.", new DateTime(2023, 3, 5, 5, 32, 55, 663, DateTimeKind.Unspecified).AddTicks(6532), 22L, true },
                    { 159L, 62L, "Distinctio quo rem consequatur aut voluptate. Sunt et provident aut nobis tempora quia distinctio sit. Sed est cupiditate blanditiis rerum quidem. Eaque aliquam voluptas delectus. Illo impedit inventore consectetur. Sit maiores pariatur.", new DateTime(2023, 8, 4, 6, 41, 31, 712, DateTimeKind.Unspecified).AddTicks(6265), 26L, true },
                    { 160L, 43L, "Et nam dicta dolorem rerum veritatis aut. Nemo ea sapiente porro architecto. Assumenda quisquam facilis eveniet quis. Qui illo dolores.", new DateTime(2022, 10, 18, 3, 39, 15, 105, DateTimeKind.Unspecified).AddTicks(5093), 28L, true },
                    { 161L, 3L, "voluptas", new DateTime(2023, 6, 11, 12, 25, 27, 879, DateTimeKind.Unspecified).AddTicks(7927), 22L, false },
                    { 162L, 75L, "excepturi", new DateTime(2019, 6, 7, 16, 42, 45, 717, DateTimeKind.Unspecified).AddTicks(1647), 25L, true },
                    { 163L, 75L, "tenetur", new DateTime(2019, 7, 29, 3, 11, 36, 733, DateTimeKind.Unspecified).AddTicks(4135), 34L, false },
                    { 164L, 175L, "Occaecati sed iste asperiores cum ut et nihil in ipsum.", new DateTime(2023, 8, 16, 15, 23, 57, 198, DateTimeKind.Unspecified).AddTicks(2152), 11L, true },
                    { 165L, 41L, "Esse quam numquam delectus illum. Unde ipsa debitis ut inventore qui. Nam nesciunt aut omnis facilis. Quis sit ut consequatur quasi voluptate itaque.", new DateTime(2023, 5, 2, 19, 43, 9, 450, DateTimeKind.Unspecified).AddTicks(4603), 22L, true },
                    { 166L, 177L, "aut", new DateTime(2023, 7, 4, 8, 26, 52, 135, DateTimeKind.Unspecified).AddTicks(3541), 17L, true },
                    { 167L, 142L, "hic", new DateTime(2023, 8, 20, 20, 56, 40, 366, DateTimeKind.Unspecified).AddTicks(1078), 1L, true },
                    { 168L, 56L, "Aliquam enim quas quo aliquam. Magnam qui quia minima ratione esse qui. Debitis adipisci magnam quas magni asperiores vitae. Pariatur magnam cupiditate porro vel itaque dignissimos.", new DateTime(2022, 2, 11, 8, 35, 54, 634, DateTimeKind.Unspecified).AddTicks(732), 19L, true }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "IsPublic" },
                values: new object[,]
                {
                    { 169L, 152L, "Optio qui veniam labore doloribus culpa cum quia.\nEius rerum reprehenderit eum rerum.", new DateTime(2022, 7, 26, 1, 3, 48, 547, DateTimeKind.Unspecified).AddTicks(6320), 27L, true },
                    { 170L, 43L, "Quam magnam amet sed eligendi ipsam hic molestiae.", new DateTime(2023, 1, 29, 8, 27, 34, 823, DateTimeKind.Unspecified).AddTicks(8107), 29L, true },
                    { 171L, 2L, "Dolores nam eius necessitatibus.", new DateTime(2023, 3, 29, 17, 27, 12, 30, DateTimeKind.Unspecified).AddTicks(8019), 36L, true },
                    { 172L, 158L, "Nihil aut et occaecati et quibusdam reprehenderit voluptate totam. Ducimus in placeat unde cum. Placeat sapiente qui quas et maiores dolorum ducimus. Incidunt dolor corporis.", new DateTime(2022, 5, 20, 9, 31, 34, 270, DateTimeKind.Unspecified).AddTicks(6807), 30L, false },
                    { 173L, 80L, "Quia qui voluptate mollitia aut. Aperiam itaque a ab voluptatem. Nisi sit officiis qui quo in. Ad odio corrupti illo nihil eum sit sunt dolorum. Molestias sit occaecati maiores ad rem dolor laboriosam. Nihil sit laudantium quae nam.", new DateTime(2023, 2, 5, 5, 7, 28, 369, DateTimeKind.Unspecified).AddTicks(7601), 31L, false },
                    { 174L, 11L, "Doloremque et architecto corrupti fugiat porro in voluptatibus. Eos incidunt velit voluptatem. Accusamus maxime atque quasi eos optio. Nisi optio dolorum consequatur qui qui expedita deserunt fuga. Sed quo accusantium deleniti ipsam dignissimos dolores. Facere dolor ea sequi voluptas tenetur.", new DateTime(2023, 5, 24, 15, 21, 42, 729, DateTimeKind.Unspecified).AddTicks(3107), 9L, false },
                    { 175L, 74L, "ad", new DateTime(2023, 6, 6, 6, 9, 58, 330, DateTimeKind.Unspecified).AddTicks(4904), 9L, true },
                    { 176L, 61L, "Soluta odio eveniet quod reprehenderit officia.\nAut cumque labore ut omnis.", new DateTime(2023, 1, 15, 22, 11, 9, 870, DateTimeKind.Unspecified).AddTicks(3597), 26L, false },
                    { 177L, 80L, "Vero nam possimus laborum. Consequuntur molestias ut numquam consequatur dolores sit. Ratione maiores illum alias vero eaque delectus similique natus. Aliquid perspiciatis magnam aut repellendus quis quod alias corporis.", new DateTime(2023, 6, 10, 13, 1, 23, 903, DateTimeKind.Unspecified).AddTicks(8552), 13L, true },
                    { 178L, 100L, "Et aut labore et aut. Illo dolor voluptate ipsam. Fuga magnam officiis voluptatum. Exercitationem dolorem voluptate quasi aliquid sequi est. Voluptatum alias adipisci. Exercitationem fugiat adipisci saepe dolor natus nihil dicta voluptas.", new DateTime(2023, 8, 3, 14, 48, 51, 661, DateTimeKind.Unspecified).AddTicks(3904), 6L, false },
                    { 179L, 94L, "similique", new DateTime(2023, 5, 12, 23, 55, 9, 749, DateTimeKind.Unspecified).AddTicks(6991), 5L, true },
                    { 180L, 21L, "Debitis sit delectus sint possimus earum praesentium nesciunt sit deserunt.", new DateTime(2023, 8, 15, 12, 55, 5, 316, DateTimeKind.Unspecified).AddTicks(3059), 11L, true },
                    { 181L, 154L, "Ducimus est qui reprehenderit nostrum.\nDicta voluptatem culpa minima officia aliquam rerum ex magnam.", new DateTime(2023, 6, 14, 23, 59, 37, 451, DateTimeKind.Unspecified).AddTicks(3247), 17L, false },
                    { 182L, 85L, "autem", new DateTime(2023, 8, 1, 13, 17, 58, 654, DateTimeKind.Unspecified).AddTicks(5310), 39L, true },
                    { 183L, 128L, "et", new DateTime(2023, 7, 21, 3, 12, 13, 608, DateTimeKind.Unspecified).AddTicks(4012), 9L, true },
                    { 184L, 24L, "Tempore veritatis aut non qui eius aut aliquam quia. Officiis et ut ut pariatur et velit totam. Necessitatibus voluptates voluptatem quasi corrupti totam ratione saepe ducimus. Consequatur sunt deserunt ut.", new DateTime(2022, 12, 20, 10, 25, 10, 206, DateTimeKind.Unspecified).AddTicks(9169), 8L, true },
                    { 185L, 158L, "Animi ut sed dolore sapiente sunt sit voluptates tempore.", new DateTime(2023, 3, 2, 17, 21, 43, 431, DateTimeKind.Unspecified).AddTicks(3009), 33L, false },
                    { 186L, 185L, "praesentium", new DateTime(2022, 11, 28, 2, 39, 17, 84, DateTimeKind.Unspecified).AddTicks(3547), 40L, true },
                    { 187L, 66L, "odio", new DateTime(2023, 8, 22, 19, 42, 3, 608, DateTimeKind.Unspecified).AddTicks(3685), 6L, true },
                    { 188L, 45L, "Sed omnis distinctio.\nBeatae quidem nesciunt perspiciatis temporibus omnis.\nQui ducimus ut.", new DateTime(2023, 8, 18, 13, 28, 2, 409, DateTimeKind.Unspecified).AddTicks(7536), 10L, true },
                    { 189L, 55L, "Dignissimos consectetur aperiam adipisci corporis.", new DateTime(2023, 8, 12, 18, 1, 9, 64, DateTimeKind.Unspecified).AddTicks(752), 11L, true },
                    { 190L, 93L, "Consequatur perferendis autem sed magni dignissimos. Dicta vitae sint dolores officiis rerum sunt laborum. Aut omnis eveniet dolore. Molestiae natus molestiae sint.", new DateTime(2022, 4, 20, 12, 11, 33, 200, DateTimeKind.Unspecified).AddTicks(7906), 33L, true },
                    { 191L, 40L, "Suscipit quo officia et dignissimos aut non temporibus fugiat. Ad cupiditate inventore neque enim. Expedita consectetur ipsum magni. Adipisci adipisci rerum. Et id libero corporis sint nulla.", new DateTime(2023, 6, 10, 0, 59, 53, 142, DateTimeKind.Unspecified).AddTicks(3547), 14L, true },
                    { 192L, 36L, "quas", new DateTime(2022, 11, 13, 17, 7, 34, 228, DateTimeKind.Unspecified).AddTicks(4093), 1L, false },
                    { 193L, 184L, "velit", new DateTime(2023, 7, 23, 18, 46, 35, 117, DateTimeKind.Unspecified).AddTicks(7077), 2L, true },
                    { 194L, 101L, "Non voluptatem illo porro.", new DateTime(2023, 5, 5, 5, 37, 48, 781, DateTimeKind.Unspecified).AddTicks(2292), 6L, false },
                    { 195L, 135L, "Dolores eos atque sint iusto beatae et.\nFuga dolores quo deleniti molestiae dolorem aut voluptatibus.\nMinima ut quam asperiores magnam sint quis voluptas temporibus.\nDolor fuga qui distinctio et velit.\nQuas iure fuga dolores.\nSunt autem ratione qui sit eius.", new DateTime(2023, 4, 19, 10, 41, 50, 32, DateTimeKind.Unspecified).AddTicks(3866), 22L, true },
                    { 196L, 56L, "Totam natus qui dolore.\nAut voluptatem facilis mollitia laudantium.\nTempora voluptatum voluptates.", new DateTime(2021, 1, 16, 20, 50, 55, 335, DateTimeKind.Unspecified).AddTicks(4796), 27L, true },
                    { 197L, 100L, "Quibusdam distinctio fuga pariatur occaecati.", new DateTime(2023, 7, 22, 0, 44, 21, 669, DateTimeKind.Unspecified).AddTicks(5943), 4L, true },
                    { 198L, 148L, "Aperiam quam sit quidem animi quaerat ipsa excepturi nisi fugiat. Voluptas ab quas ut nemo qui eum necessitatibus magni consequatur. Odio aut recusandae.", new DateTime(2023, 8, 23, 5, 54, 4, 375, DateTimeKind.Unspecified).AddTicks(5489), 35L, false },
                    { 199L, 133L, "deleniti", new DateTime(2022, 8, 6, 21, 21, 36, 436, DateTimeKind.Unspecified).AddTicks(8797), 8L, true },
                    { 200L, 129L, "culpa", new DateTime(2023, 2, 28, 11, 24, 9, 383, DateTimeKind.Unspecified).AddTicks(9547), 17L, true }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "Output", "SubmittedAt" },
                values: new object[,]
                {
                    { 1L, 164L, "Vitae earum pariatur animi saepe explicabo asperiores molestiae et nihil. Esse provident id saepe nesciunt enim. Neque nemo dolore cupiditate temporibus vitae. Ut est voluptates qui minima dolor totam reprehenderit. Dolores non blanditiis facere numquam et facilis. Saepe sequi adipisci labore nesciunt.", new DateTime(2023, 4, 25, 23, 22, 36, 690, DateTimeKind.Unspecified).AddTicks(186), 33L, "Tempora minus et in facilis natus voluptatem voluptas non. Dignissimos dicta dolor delectus molestiae alias accusantium voluptatem. Delectus cumque iste. Ea nam aut et. Necessitatibus molestiae odit quibusdam ullam ad ab quae.", new DateTime(2023, 8, 16, 0, 59, 12, 646, DateTimeKind.Unspecified).AddTicks(7374) },
                    { 2L, 57L, "Ea iste quos non incidunt consectetur numquam.\nQuod facilis dolorem libero.\nNostrum voluptates tempore non sint debitis et.\nFacilis temporibus molestias repudiandae aut amet non.\nIpsum amet perferendis id.\nAlias aut deleniti optio ea optio numquam.", new DateTime(2023, 8, 22, 15, 28, 24, 749, DateTimeKind.Unspecified).AddTicks(9425), 8L, "Aut vel dolores cupiditate et consectetur consequatur voluptatem. Voluptatem quasi quo assumenda maiores sit aliquid consequatur alias. Sunt praesentium voluptatem recusandae hic nostrum et consectetur ut aut.", new DateTime(2023, 8, 23, 4, 11, 51, 572, DateTimeKind.Unspecified).AddTicks(51) },
                    { 3L, 98L, "Eum distinctio corporis ut dolorem et velit.", new DateTime(2023, 7, 3, 20, 59, 9, 441, DateTimeKind.Unspecified).AddTicks(4497), 40L, "Quis laboriosam dolores soluta illo est numquam.", new DateTime(2023, 8, 21, 11, 15, 8, 198, DateTimeKind.Unspecified).AddTicks(6246) },
                    { 4L, 187L, "Repellat est sequi.\nEaque cupiditate consequuntur harum deserunt atque delectus nisi.\nAut voluptate ut tenetur sint quam consequatur praesentium.", new DateTime(2021, 3, 8, 2, 32, 11, 648, DateTimeKind.Unspecified).AddTicks(9732), 1L, "Corrupti quasi omnis.\nRerum iusto dicta.\nMolestiae velit ut reprehenderit assumenda similique vel consequatur neque.\nUt velit sunt ut sint maiores beatae et.", new DateTime(2021, 9, 30, 0, 57, 14, 351, DateTimeKind.Unspecified).AddTicks(8701) },
                    { 5L, 80L, "Aspernatur qui delectus ut.", new DateTime(2022, 10, 20, 12, 54, 14, 47, DateTimeKind.Unspecified).AddTicks(6929), 7L, "nobis", new DateTime(2023, 7, 28, 18, 47, 29, 104, DateTimeKind.Unspecified).AddTicks(8515) },
                    { 6L, 192L, "perferendis", new DateTime(2023, 7, 3, 9, 37, 44, 589, DateTimeKind.Unspecified).AddTicks(9991), 33L, "Esse voluptas facere autem. Delectus qui iste error voluptatem. Molestiae sequi impedit velit iste. Ipsum tempore molestiae esse aperiam eos accusantium placeat.", new DateTime(2023, 7, 4, 7, 53, 34, 368, DateTimeKind.Unspecified).AddTicks(424) },
                    { 7L, 61L, "aut", new DateTime(2023, 5, 3, 6, 2, 5, 304, DateTimeKind.Unspecified).AddTicks(2670), 7L, "Iure saepe quas accusamus magni repellat velit ea.\nReprehenderit est labore.\nPorro earum consequatur nulla aspernatur a.\nVel nihil qui quae unde aut quo sed.\nA velit aut commodi asperiores vel nam.", null },
                    { 8L, 21L, "Voluptatem error provident quo beatae culpa modi repellendus.\nQuasi suscipit soluta neque praesentium voluptatem sed quis.", new DateTime(2023, 8, 10, 11, 29, 50, 523, DateTimeKind.Unspecified).AddTicks(6798), 28L, "Reiciendis sint debitis. Et ad sed perspiciatis omnis non. Placeat error explicabo accusantium maiores deleniti repellat praesentium. Id et eos. Expedita magni et impedit voluptatibus. Qui consequuntur nulla explicabo expedita aut.", new DateTime(2023, 8, 20, 22, 22, 2, 518, DateTimeKind.Unspecified).AddTicks(1981) },
                    { 9L, 76L, "Ut officia fugit quasi.\nSit rerum quis esse placeat nemo.\nDolor qui est est omnis.", new DateTime(2019, 12, 20, 5, 21, 49, 752, DateTimeKind.Unspecified).AddTicks(3966), 12L, "Consequuntur iure deserunt ut rem iusto et.", new DateTime(2022, 5, 23, 10, 5, 27, 543, DateTimeKind.Unspecified).AddTicks(4250) },
                    { 10L, 4L, "qui", new DateTime(2023, 4, 26, 15, 9, 8, 6, DateTimeKind.Unspecified).AddTicks(4729), 3L, "earum", new DateTime(2023, 5, 29, 5, 23, 21, 302, DateTimeKind.Unspecified).AddTicks(5953) }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "Output", "SubmittedAt" },
                values: new object[,]
                {
                    { 11L, 147L, "Explicabo repellendus enim quia aut voluptas aperiam voluptatem. Sed aut placeat possimus nobis facilis quidem excepturi aperiam voluptatem. Possimus sunt magnam. Omnis rerum nihil possimus ut eius voluptates laboriosam provident aut. Nobis quia mollitia velit ab sequi quidem est earum. Aliquam amet vel quis temporibus.", new DateTime(2023, 1, 14, 16, 27, 14, 347, DateTimeKind.Unspecified).AddTicks(9701), 5L, "Omnis tenetur consequatur sed ea unde laudantium. Minima cum nam quia voluptas numquam officiis. A excepturi repudiandae quo non earum sed ipsam nemo distinctio. Qui voluptas iure iste praesentium nostrum vel. Molestiae et ratione voluptas ab id et debitis sapiente.", new DateTime(2023, 1, 23, 12, 39, 11, 474, DateTimeKind.Unspecified).AddTicks(3660) },
                    { 12L, 56L, "Nulla dolor ipsam qui fugiat.\nTempora cumque doloremque aut exercitationem necessitatibus sed quia.\nHic dignissimos rerum beatae consequatur maxime et aut omnis veritatis.\nQuia in magni deleniti.", new DateTime(2021, 8, 30, 1, 11, 55, 229, DateTimeKind.Unspecified).AddTicks(9791), 39L, "qui", new DateTime(2022, 9, 3, 20, 56, 51, 101, DateTimeKind.Unspecified).AddTicks(8308) },
                    { 13L, 100L, "Et et sit. Eos maiores voluptas ut qui in mollitia consequatur. Animi provident reiciendis soluta sed possimus.", new DateTime(2023, 8, 2, 21, 38, 46, 48, DateTimeKind.Unspecified).AddTicks(7746), 11L, "Similique unde accusamus rem sint quo mollitia ea.\nQuos at ut necessitatibus soluta nulla.\nRerum beatae ipsam nemo possimus omnis.\nEst in autem placeat harum eum a adipisci quam et.", new DateTime(2023, 8, 20, 13, 28, 31, 374, DateTimeKind.Unspecified).AddTicks(732) },
                    { 14L, 62L, "alias", new DateTime(2023, 8, 18, 20, 27, 14, 305, DateTimeKind.Unspecified).AddTicks(1748), 6L, "Consequuntur aut excepturi blanditiis impedit at.", new DateTime(2023, 8, 22, 0, 55, 12, 652, DateTimeKind.Unspecified).AddTicks(2560) },
                    { 15L, 15L, "eveniet", new DateTime(2023, 7, 10, 15, 19, 55, 463, DateTimeKind.Unspecified).AddTicks(3448), 4L, "nam", new DateTime(2023, 7, 14, 15, 49, 22, 485, DateTimeKind.Unspecified).AddTicks(1525) },
                    { 16L, 127L, "Iusto laboriosam fuga dolor autem.\nAut consequatur ipsam alias laboriosam molestiae dolor.\nEarum nam eveniet quas cupiditate.\nSint inventore ducimus.", new DateTime(2023, 8, 20, 10, 5, 49, 304, DateTimeKind.Unspecified).AddTicks(9659), 34L, "Aut possimus mollitia non repudiandae nisi.", new DateTime(2023, 8, 20, 15, 53, 51, 533, DateTimeKind.Unspecified).AddTicks(1063) },
                    { 17L, 37L, "tempore", new DateTime(2018, 5, 2, 12, 23, 2, 409, DateTimeKind.Unspecified).AddTicks(5966), 40L, "Tempore quae quia iste qui rerum voluptas consequuntur debitis adipisci. Ab et dolor autem necessitatibus magnam. Sunt omnis vel deleniti in expedita dolores quibusdam. Sit eum in modi placeat id eos nulla perferendis ad. Ut sint sint totam est porro rerum autem velit. Cumque modi fugiat.", new DateTime(2021, 3, 18, 12, 27, 50, 735, DateTimeKind.Unspecified).AddTicks(6458) },
                    { 18L, 189L, "Repellendus repudiandae distinctio.\nUllam aut impedit enim nostrum.\nCommodi et odio temporibus expedita nulla repudiandae eum nobis assumenda.\nMollitia hic deleniti id maxime et similique quo.", new DateTime(2021, 12, 30, 1, 59, 41, 363, DateTimeKind.Unspecified).AddTicks(1380), 20L, "Facere facere sed consequatur quaerat.\nUt maxime dolor atque.\nSunt laboriosam id qui consectetur cupiditate dolor et ea a.\nEa amet delectus dolor eligendi iste qui qui mollitia.\nVeniam doloribus et nobis tempore et officia placeat.", new DateTime(2022, 5, 9, 6, 2, 47, 811, DateTimeKind.Unspecified).AddTicks(6974) },
                    { 19L, 162L, "Ut illo quae. Ut nostrum velit repellat qui non ipsa. Rem temporibus sit.", new DateTime(2023, 7, 12, 15, 52, 39, 614, DateTimeKind.Unspecified).AddTicks(2079), 9L, "necessitatibus", new DateTime(2023, 8, 12, 14, 13, 53, 609, DateTimeKind.Unspecified).AddTicks(8978) },
                    { 20L, 99L, "Aut debitis sit nesciunt qui et odit.\nEligendi quia tempore.\nInventore est doloribus.\nEt nostrum quod laborum excepturi ad eligendi.\nIste voluptas rem ab autem voluptatem rerum sed ipsum hic.\nVelit qui voluptas.", new DateTime(2023, 7, 1, 6, 51, 22, 788, DateTimeKind.Unspecified).AddTicks(1704), 34L, "Recusandae eaque dolor qui nisi itaque.", new DateTime(2023, 8, 11, 7, 15, 14, 518, DateTimeKind.Unspecified).AddTicks(7887) },
                    { 21L, 28L, "Voluptatem beatae est amet explicabo id illum doloremque inventore.", new DateTime(2023, 6, 16, 3, 20, 55, 984, DateTimeKind.Unspecified).AddTicks(5020), 23L, "et", new DateTime(2023, 6, 23, 16, 11, 34, 956, DateTimeKind.Unspecified).AddTicks(260) },
                    { 22L, 45L, "Ipsa enim cum.\nQuos odit culpa et dolores reiciendis.", new DateTime(2023, 8, 20, 20, 21, 55, 517, DateTimeKind.Unspecified).AddTicks(9649), 16L, "voluptatem", new DateTime(2023, 8, 23, 7, 17, 45, 111, DateTimeKind.Unspecified).AddTicks(9715) },
                    { 23L, 60L, "Corporis ut iusto in.", new DateTime(2023, 6, 8, 23, 52, 37, 919, DateTimeKind.Unspecified).AddTicks(404), 34L, "Perferendis quia perferendis quisquam eos. Officia nulla vel laudantium. Est fugit beatae excepturi maiores voluptatem ab. Modi ipsa ut autem perferendis labore voluptatem aliquid aut. Id repudiandae et cum qui explicabo autem id omnis. Doloribus iusto perspiciatis.", new DateTime(2023, 6, 28, 22, 29, 57, 1, DateTimeKind.Unspecified).AddTicks(5733) },
                    { 24L, 133L, "autem", new DateTime(2023, 6, 6, 3, 12, 0, 672, DateTimeKind.Unspecified).AddTicks(9078), 13L, "Ut ab sunt.", new DateTime(2023, 8, 23, 10, 7, 38, 384, DateTimeKind.Unspecified).AddTicks(896) },
                    { 25L, 97L, "Illo est omnis repellendus non ut maiores eos.\nUt recusandae quo repellendus dolores molestias.\nEst aut dolor.\nSunt ut corrupti error.\nAut fugiat et ut est exercitationem voluptate explicabo.\nQuos quasi placeat ut sit in neque et.", new DateTime(2023, 7, 4, 6, 33, 46, 717, DateTimeKind.Unspecified).AddTicks(6231), 32L, "Non repellendus vel nesciunt omnis enim. Molestiae nobis dolorum excepturi veniam maiores aperiam. Dolores omnis mollitia est dolore non quod inventore alias. Voluptas ratione rerum eum quae iusto. Repudiandae voluptatem sed ipsam voluptatem ad dolor exercitationem.", new DateTime(2023, 7, 9, 17, 32, 46, 577, DateTimeKind.Unspecified).AddTicks(4421) },
                    { 26L, 146L, "Quas voluptatem est illo aspernatur voluptas rerum. Qui consequatur quisquam iusto neque eos. Rerum sit voluptas quis quo dolores excepturi. Minima illum voluptatum. Quae sit hic accusantium et error. Eos sed iusto vel sunt qui voluptatem et.", new DateTime(2023, 8, 21, 21, 32, 2, 488, DateTimeKind.Unspecified).AddTicks(7049), 21L, "Ut dolores molestiae itaque assumenda molestiae dolores.\nEt aut asperiores voluptatem voluptas labore.\nOfficiis voluptas eos omnis repellendus et accusamus.", new DateTime(2023, 8, 22, 5, 38, 35, 306, DateTimeKind.Unspecified).AddTicks(1561) },
                    { 27L, 69L, "In molestiae et et est rem nisi non aut.", new DateTime(2023, 7, 29, 10, 21, 9, 675, DateTimeKind.Unspecified).AddTicks(7726), 26L, "Labore facilis et qui ut aut qui tenetur impedit quam.\nConsequatur nihil corrupti voluptatum est sed molestias natus sed et.", new DateTime(2023, 7, 31, 5, 6, 2, 117, DateTimeKind.Unspecified).AddTicks(8610) },
                    { 28L, 116L, "Ut minus sunt facere eveniet.\nModi eveniet qui praesentium explicabo nam ipsam architecto nesciunt.\nAut atque labore repellat minus voluptas.\nAlias voluptates voluptatem est ullam quae architecto.\nMolestias vel cum commodi nobis ea inventore non.", new DateTime(2023, 7, 22, 19, 1, 59, 671, DateTimeKind.Unspecified).AddTicks(5734), 39L, "Dolorum ab totam blanditiis omnis omnis amet vitae.\nOmnis commodi assumenda perspiciatis voluptatem dolores similique voluptas officiis eius.\nPariatur excepturi id officia quis rerum quo rem qui illo.", new DateTime(2023, 7, 23, 8, 36, 20, 771, DateTimeKind.Unspecified).AddTicks(4728) },
                    { 29L, 33L, "Rem illo fugit sapiente fugit sapiente.\nLaborum magni nisi omnis.\nNumquam et odio voluptas et aut ipsam debitis dolorem.\nVoluptas quo earum et consequatur repellendus voluptatem non ipsam qui.", new DateTime(2023, 3, 13, 9, 23, 28, 921, DateTimeKind.Unspecified).AddTicks(6395), 17L, "iure", new DateTime(2023, 8, 5, 1, 32, 56, 947, DateTimeKind.Unspecified).AddTicks(6676) },
                    { 30L, 143L, "Excepturi consequatur sint aliquid quo ullam eos esse. Mollitia incidunt expedita quis. Numquam in voluptatem quia sequi ex officia. Doloremque delectus possimus eum magnam ad sint.", new DateTime(2023, 8, 22, 15, 17, 5, 198, DateTimeKind.Unspecified).AddTicks(4970), 26L, "Iusto quos qui voluptatum autem deserunt quasi. Facilis id autem porro ex autem aut. Hic voluptate et consectetur dolorum dicta dicta repudiandae suscipit. Deserunt aut ab et ut quia rerum est modi autem. Id est et dolores.", new DateTime(2023, 8, 22, 20, 12, 3, 786, DateTimeKind.Unspecified).AddTicks(6603) },
                    { 31L, 5L, "Esse voluptas aut aut cupiditate et ut voluptate.\nEos voluptas repellat veritatis praesentium dolor.\nVelit eum nam voluptatem enim libero non et.", new DateTime(2023, 8, 2, 11, 1, 42, 82, DateTimeKind.Unspecified).AddTicks(9162), 28L, "Aut autem odit.", new DateTime(2023, 8, 6, 21, 45, 44, 528, DateTimeKind.Unspecified).AddTicks(5830) },
                    { 32L, 178L, "Veritatis commodi assumenda debitis eum nobis animi voluptas et.\nConsectetur non ad.\nAtque hic incidunt.\nMaxime fugit nemo cum totam hic.", new DateTime(2022, 8, 2, 18, 54, 4, 510, DateTimeKind.Unspecified).AddTicks(9033), 15L, "Fugit et repellendus omnis dolorem et repudiandae dolores totam. Ad molestiae maiores laborum eaque alias voluptatibus dolor dignissimos eum. Ut reprehenderit reiciendis officiis rerum nihil atque iure. Illum et vitae rerum atque voluptatem facilis exercitationem commodi est.", new DateTime(2022, 8, 22, 5, 42, 9, 239, DateTimeKind.Unspecified).AddTicks(1024) },
                    { 33L, 188L, "Quas enim tempore atque dolorem cupiditate rem dolores in.", new DateTime(2023, 5, 26, 8, 53, 21, 147, DateTimeKind.Unspecified).AddTicks(3313), 37L, "aut", new DateTime(2023, 7, 3, 22, 7, 56, 106, DateTimeKind.Unspecified).AddTicks(3513) },
                    { 34L, 144L, "Voluptas aspernatur consequuntur est ea.\nQuam facere totam est cupiditate nisi voluptatem iure.", new DateTime(2023, 5, 20, 18, 26, 55, 686, DateTimeKind.Unspecified).AddTicks(3014), 9L, "et", new DateTime(2023, 7, 21, 5, 37, 13, 720, DateTimeKind.Unspecified).AddTicks(3286) },
                    { 35L, 123L, "Sequi quo reprehenderit nihil officiis non qui dignissimos ut officia.\nNam autem dolores ipsam quibusdam placeat assumenda alias.\nIllo voluptas repellendus sint vel.\nEius aperiam nesciunt et maiores incidunt ut eius dolorum occaecati.\nAsperiores aut ut harum beatae.", new DateTime(2023, 5, 2, 0, 58, 35, 991, DateTimeKind.Unspecified).AddTicks(4330), 36L, "Maxime praesentium unde porro in laborum.", new DateTime(2023, 6, 15, 0, 28, 54, 246, DateTimeKind.Unspecified).AddTicks(5364) },
                    { 36L, 70L, "Officiis laborum reiciendis.", new DateTime(2023, 7, 8, 10, 1, 13, 688, DateTimeKind.Unspecified).AddTicks(3190), 15L, "Sed id velit voluptatem nesciunt.\nQuibusdam et possimus necessitatibus laudantium minus aut qui aliquid assumenda.", new DateTime(2023, 8, 6, 14, 50, 56, 537, DateTimeKind.Unspecified).AddTicks(1085) },
                    { 37L, 37L, "A commodi incidunt laudantium nihil vel et.\nCupiditate autem fugiat eum suscipit qui iure quo id.\nQui quisquam ratione.", new DateTime(2021, 11, 9, 10, 30, 48, 238, DateTimeKind.Unspecified).AddTicks(881), 18L, "Nihil odit quaerat et sed voluptatum quod alias tempora temporibus.\nAutem est sit beatae autem.\nHarum non sit natus cupiditate iusto quia sapiente libero doloremque.\nReprehenderit et voluptatum corporis atque ut.\nIpsam quia minima et ab illo fugiat animi unde.\nMollitia amet enim aperiam voluptas quod sint dignissimos optio.", new DateTime(2021, 12, 12, 2, 53, 21, 27, DateTimeKind.Unspecified).AddTicks(4674) },
                    { 38L, 26L, "Laborum sunt enim illo enim.\nSunt omnis aliquam nihil alias neque.\nQui et rerum nihil.\nDeleniti possimus in et repudiandae.", new DateTime(2022, 4, 12, 17, 53, 28, 165, DateTimeKind.Unspecified).AddTicks(6602), 3L, "Et culpa facilis architecto laborum sunt id placeat eius. Ut minus veniam. Optio enim excepturi eaque excepturi minima error impedit quaerat. Et corporis illo est et voluptatibus distinctio ut consectetur. Est asperiores fugit sit explicabo voluptates natus. Molestias necessitatibus et eligendi vitae nihil.", new DateTime(2023, 6, 23, 14, 6, 32, 734, DateTimeKind.Unspecified).AddTicks(2396) },
                    { 39L, 187L, "Voluptatem eos ducimus.\nEaque sint voluptas labore consequatur.\nUt omnis dolorem nihil sequi sit rerum animi quisquam sit.", new DateTime(2021, 6, 10, 6, 46, 16, 432, DateTimeKind.Unspecified).AddTicks(9925), 6L, "consequatur", new DateTime(2022, 3, 20, 10, 19, 13, 329, DateTimeKind.Unspecified).AddTicks(7977) },
                    { 40L, 39L, "Eveniet laborum ullam sint tempore aliquam id dolor officiis. Ut ut occaecati voluptas sequi quia sed ex. Repellendus recusandae pariatur vero ipsa saepe hic qui excepturi sunt. Quis et quis officia doloribus molestiae praesentium et. Ut mollitia neque. Beatae rerum recusandae nulla consequatur dolor eveniet vel.", new DateTime(2022, 8, 7, 6, 42, 7, 91, DateTimeKind.Unspecified).AddTicks(4768), 28L, "Beatae pariatur quae facere quaerat dolorum est non modi.", new DateTime(2023, 2, 4, 21, 20, 56, 708, DateTimeKind.Unspecified).AddTicks(6959) },
                    { 41L, 195L, "Eos rerum quia quasi. Est quia omnis ea. Aut ea minus adipisci accusamus perferendis quaerat nostrum quod earum. Sed doloremque nemo quis. Totam sed est neque aperiam. Deserunt omnis aperiam non hic minus necessitatibus architecto et aut.", new DateTime(2023, 4, 17, 6, 54, 9, 702, DateTimeKind.Unspecified).AddTicks(6172), 36L, "Ipsum quos et voluptatem laboriosam eius id. Fugiat illo distinctio vero. Cumque qui corporis. Illo labore molestiae consectetur voluptas dolor nesciunt. Veritatis cupiditate ea nam sit velit ut quis nobis sed.", new DateTime(2023, 6, 5, 16, 26, 59, 575, DateTimeKind.Unspecified).AddTicks(8650) },
                    { 42L, 163L, "Omnis et autem architecto recusandae aperiam quasi est.", new DateTime(2023, 8, 13, 13, 10, 58, 72, DateTimeKind.Unspecified).AddTicks(3236), 22L, "Et minus et ea ipsam laboriosam vel ad eligendi sed.", new DateTime(2023, 8, 16, 16, 14, 57, 119, DateTimeKind.Unspecified).AddTicks(6963) },
                    { 43L, 98L, "Earum suscipit autem libero exercitationem dolores.", new DateTime(2023, 7, 12, 21, 26, 1, 619, DateTimeKind.Unspecified).AddTicks(7151), 6L, "Cum repellendus accusamus.", new DateTime(2023, 8, 19, 1, 21, 52, 388, DateTimeKind.Unspecified).AddTicks(206) },
                    { 44L, 130L, "Rerum aliquam quibusdam error et fugiat aut magnam.", new DateTime(2023, 4, 11, 21, 21, 1, 539, DateTimeKind.Unspecified).AddTicks(6969), 38L, "amet", new DateTime(2023, 6, 29, 15, 23, 9, 681, DateTimeKind.Unspecified).AddTicks(5064) },
                    { 45L, 85L, "Sapiente magnam quia ut a in.\nIste excepturi ratione quia et rerum magni sunt.", new DateTime(2023, 5, 25, 1, 10, 31, 401, DateTimeKind.Unspecified).AddTicks(3941), 30L, "Cumque autem nihil.\nNatus ipsa ut quis veritatis doloremque quisquam.\nCupiditate tenetur quia blanditiis est.\nVoluptate voluptate exercitationem.\nMolestiae architecto quia sapiente quae commodi.\nVel architecto deleniti maxime provident fugiat facere.", new DateTime(2023, 6, 19, 10, 10, 18, 721, DateTimeKind.Unspecified).AddTicks(8504) },
                    { 46L, 63L, "Fugiat ut fuga magnam distinctio sit voluptate.\nQuia iusto dolor corporis ducimus et numquam.\nAsperiores et id dolore a et provident.", new DateTime(2023, 6, 5, 16, 24, 55, 494, DateTimeKind.Unspecified).AddTicks(7816), 13L, "Quisquam corporis suscipit magni odio dolorum. Voluptatem et sunt. Autem cumque commodi voluptate non.", new DateTime(2023, 7, 17, 8, 25, 24, 493, DateTimeKind.Unspecified).AddTicks(5835) },
                    { 47L, 187L, "quia", new DateTime(2021, 2, 1, 0, 37, 4, 477, DateTimeKind.Unspecified).AddTicks(3538), 3L, "quis", new DateTime(2022, 10, 2, 20, 51, 33, 257, DateTimeKind.Unspecified).AddTicks(8515) },
                    { 48L, 76L, "Non laudantium aut non.\nAsperiores nesciunt dolore.\nIure consequuntur voluptatem velit.\nAutem quo molestiae recusandae.\nEt deserunt ratione laborum.", new DateTime(2022, 3, 22, 23, 24, 30, 716, DateTimeKind.Unspecified).AddTicks(9083), 34L, "et", new DateTime(2023, 8, 5, 4, 30, 27, 857, DateTimeKind.Unspecified).AddTicks(6501) },
                    { 49L, 123L, "Distinctio quos eveniet corporis voluptatem voluptatem ipsam deserunt.\nDolor quisquam beatae eum dicta.\nNatus quaerat modi expedita deleniti reprehenderit ut veritatis at.", new DateTime(2023, 3, 23, 7, 38, 53, 629, DateTimeKind.Unspecified).AddTicks(3132), 9L, "delectus", new DateTime(2023, 5, 5, 13, 58, 27, 114, DateTimeKind.Unspecified).AddTicks(3939) },
                    { 50L, 198L, "Sed impedit voluptatum provident aut tempore et.\nEnim delectus saepe sit esse possimus occaecati consequuntur.\nDignissimos asperiores voluptates enim quia molestiae quae ullam.\nVeritatis cumque sed repellat porro.\nLaboriosam ut unde voluptatem vitae est aut maiores in quod.", new DateTime(2023, 8, 16, 9, 34, 16, 651, DateTimeKind.Unspecified).AddTicks(6022), 39L, "explicabo", null },
                    { 51L, 41L, "Sit quod eum aliquam esse minima et.", new DateTime(2023, 1, 25, 0, 3, 6, 124, DateTimeKind.Unspecified).AddTicks(521), 25L, "omnis", new DateTime(2023, 3, 31, 10, 11, 26, 697, DateTimeKind.Unspecified).AddTicks(5114) },
                    { 52L, 137L, "Non quis quae voluptatibus. Aut sit similique necessitatibus suscipit. Enim et dolorum. Omnis nihil optio et molestias perferendis magni. Est quos aliquid autem quis quia et nulla ab.", new DateTime(2021, 11, 4, 18, 6, 43, 343, DateTimeKind.Unspecified).AddTicks(5736), 20L, "Incidunt quisquam exercitationem deserunt nobis qui.", new DateTime(2023, 7, 19, 10, 35, 17, 819, DateTimeKind.Unspecified).AddTicks(8562) }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "Output", "SubmittedAt" },
                values: new object[,]
                {
                    { 53L, 108L, "Deserunt facere rerum omnis nam ipsum eos vitae quas in. Voluptatibus quidem sapiente ea ut corrupti. Consequatur in iure. Deleniti eum aut sint perferendis voluptas id et corporis sunt. Iure dolor blanditiis aperiam nostrum iure. Voluptatem voluptatem eius eveniet.", new DateTime(2022, 12, 18, 9, 1, 46, 442, DateTimeKind.Unspecified).AddTicks(151), 4L, "nihil", new DateTime(2023, 5, 5, 9, 35, 39, 580, DateTimeKind.Unspecified).AddTicks(7677) },
                    { 54L, 132L, "Natus animi nihil ad inventore perspiciatis ratione nesciunt consequatur voluptatum.", new DateTime(2023, 7, 5, 2, 44, 33, 617, DateTimeKind.Unspecified).AddTicks(3806), 40L, "Officia magnam dolor et itaque velit est accusamus dolores labore.\nQui est nemo nihil voluptatum alias ab laudantium.", null },
                    { 55L, 152L, "reiciendis", new DateTime(2022, 10, 22, 16, 30, 56, 841, DateTimeKind.Unspecified).AddTicks(5039), 11L, "Qui cum quidem aut amet sed voluptas ex quam dolorum.\nDistinctio quae nihil ea aperiam.\nSit labore est soluta consequatur molestiae sed aut.", new DateTime(2022, 11, 24, 5, 29, 11, 245, DateTimeKind.Unspecified).AddTicks(492) },
                    { 56L, 182L, "Necessitatibus soluta error aperiam omnis sed. Culpa quia qui molestiae. Suscipit est voluptate nihil. Corrupti facilis excepturi.", new DateTime(2023, 5, 14, 2, 39, 46, 625, DateTimeKind.Unspecified).AddTicks(9445), 40L, "Magnam occaecati nihil molestiae commodi vel dolore eligendi.\nAut magnam sequi quod quibusdam repellat repudiandae autem.\nQui natus modi.", new DateTime(2023, 7, 19, 9, 40, 33, 298, DateTimeKind.Unspecified).AddTicks(7237) },
                    { 57L, 179L, "et", new DateTime(2023, 2, 11, 17, 49, 39, 512, DateTimeKind.Unspecified).AddTicks(6065), 38L, "enim", new DateTime(2023, 2, 18, 14, 56, 53, 133, DateTimeKind.Unspecified).AddTicks(2253) },
                    { 58L, 70L, "Dolorem sed officiis saepe voluptas ea vitae.\nNam et eaque sunt pariatur praesentium.", new DateTime(2023, 8, 10, 17, 10, 59, 482, DateTimeKind.Unspecified).AddTicks(2452), 19L, "Nihil magnam laborum itaque ad perferendis laboriosam sit.", new DateTime(2023, 8, 15, 7, 0, 1, 463, DateTimeKind.Unspecified).AddTicks(1460) },
                    { 59L, 134L, "Quo amet modi itaque est sit.\nQuas nobis sed nobis.\nDoloremque nam praesentium atque occaecati vero.\nVeritatis et eos suscipit vel et eligendi.", new DateTime(2023, 6, 10, 15, 44, 31, 783, DateTimeKind.Unspecified).AddTicks(3494), 30L, "Ut est necessitatibus a qui iste.", null },
                    { 60L, 66L, "voluptatem", new DateTime(2023, 8, 23, 6, 35, 14, 141, DateTimeKind.Unspecified).AddTicks(4481), 3L, "magnam", new DateTime(2023, 8, 23, 7, 34, 37, 541, DateTimeKind.Unspecified).AddTicks(5892) },
                    { 61L, 196L, "Nihil explicabo quam in cumque pariatur velit architecto repellat. Vel sapiente a enim est ut rem non quibusdam dolore. Consequatur occaecati ipsa. Rerum voluptatem atque itaque ut et non neque necessitatibus.", new DateTime(2023, 8, 15, 18, 36, 11, 158, DateTimeKind.Unspecified).AddTicks(1007), 29L, "et", new DateTime(2023, 8, 22, 2, 52, 4, 786, DateTimeKind.Unspecified).AddTicks(2319) },
                    { 62L, 156L, "Velit quia qui.", new DateTime(2023, 7, 16, 10, 5, 28, 193, DateTimeKind.Unspecified).AddTicks(1744), 16L, "Id distinctio soluta vero sunt dolores facere saepe sunt.", new DateTime(2023, 8, 7, 17, 24, 10, 836, DateTimeKind.Unspecified).AddTicks(612) },
                    { 63L, 14L, "praesentium", new DateTime(2023, 8, 8, 17, 7, 39, 637, DateTimeKind.Unspecified).AddTicks(7766), 33L, "veniam", new DateTime(2023, 8, 21, 12, 12, 3, 639, DateTimeKind.Unspecified).AddTicks(183) },
                    { 64L, 179L, "Reiciendis nihil est possimus voluptatem fugiat expedita deserunt quas debitis.", new DateTime(2022, 8, 18, 8, 57, 43, 814, DateTimeKind.Unspecified).AddTicks(8469), 10L, "Autem odio doloremque eos exercitationem nostrum nisi sed modi.", new DateTime(2023, 3, 25, 15, 49, 3, 55, DateTimeKind.Unspecified).AddTicks(3738) },
                    { 65L, 199L, "Rerum quod sed sit. Fugit impedit accusantium dolores magnam perspiciatis sed modi vitae ab. Animi dignissimos nulla est non eum sunt velit nostrum. Placeat provident quas dolorem ea voluptates ipsam commodi.", new DateTime(2023, 8, 5, 10, 5, 7, 755, DateTimeKind.Unspecified).AddTicks(9189), 15L, "Cum eum voluptas voluptatem. Nesciunt eaque et. Alias voluptatem voluptas.", new DateTime(2023, 8, 6, 21, 4, 0, 857, DateTimeKind.Unspecified).AddTicks(9730) },
                    { 66L, 160L, "Dolorem sint necessitatibus ullam commodi dolor cupiditate ut saepe.", new DateTime(2021, 12, 26, 10, 23, 50, 83, DateTimeKind.Unspecified).AddTicks(5487), 16L, "Eius repudiandae nihil molestiae et occaecati blanditiis illum libero.\nIn non libero animi est ratione quia.\nEum placeat veritatis illo ut et repellendus non sapiente.\nQui consectetur qui dolorem.\nQui non non et quasi.\nNatus fugit deleniti qui harum sint soluta harum voluptas corrupti.", null },
                    { 67L, 72L, "Laudantium eos sunt iste enim incidunt voluptatum reprehenderit ut non. Libero possimus quos aut rerum ut quidem. Voluptates laboriosam est aut eveniet adipisci et.", new DateTime(2022, 8, 22, 21, 42, 29, 25, DateTimeKind.Unspecified).AddTicks(6595), 4L, "qui", new DateTime(2022, 12, 26, 13, 49, 48, 621, DateTimeKind.Unspecified).AddTicks(7735) },
                    { 68L, 164L, "Consequatur consequatur et dolore nam et veniam placeat aut aspernatur. Rerum eligendi odit ut esse numquam aliquam id. Eaque consectetur commodi distinctio accusantium beatae ullam officiis.", new DateTime(2023, 3, 11, 18, 16, 28, 644, DateTimeKind.Unspecified).AddTicks(1631), 40L, "Assumenda corporis quia dolores voluptatem fugiat suscipit dolore explicabo odio.\nAutem aspernatur et voluptatem nihil.", new DateTime(2023, 4, 2, 1, 0, 44, 471, DateTimeKind.Unspecified).AddTicks(9555) },
                    { 69L, 172L, "Saepe dolorum rerum qui modi qui.", new DateTime(2023, 8, 19, 3, 20, 20, 466, DateTimeKind.Unspecified).AddTicks(7519), 16L, "Et adipisci sapiente. Sint ut ad culpa aut consequatur molestias. Nobis qui voluptatem id impedit. Enim illo necessitatibus illo reprehenderit.", new DateTime(2023, 8, 21, 10, 4, 9, 42, DateTimeKind.Unspecified).AddTicks(4888) },
                    { 70L, 30L, "Sequi aperiam nemo officiis et sapiente id amet.\nPerspiciatis incidunt dolore.", new DateTime(2023, 6, 16, 11, 53, 38, 17, DateTimeKind.Unspecified).AddTicks(3342), 28L, "Quia modi vel ea.\nNon harum aliquid sequi accusamus et in.\nUt qui expedita necessitatibus assumenda ut ex ut.\nCupiditate ea est ut amet exercitationem.\nDistinctio aut necessitatibus quas nihil architecto exercitationem.\nQuis mollitia ducimus occaecati.", new DateTime(2023, 6, 23, 13, 35, 13, 521, DateTimeKind.Unspecified).AddTicks(2502) },
                    { 71L, 168L, "hic", new DateTime(2023, 8, 22, 23, 26, 30, 196, DateTimeKind.Unspecified).AddTicks(473), 8L, "Deleniti sequi cupiditate aut eum.\nVoluptatem et perspiciatis voluptatem suscipit voluptas dolores veritatis.\nArchitecto voluptatem neque nesciunt velit animi ipsum eveniet fugiat officia.\nSint aliquam reprehenderit sapiente.\nQui dolorum voluptatem quia.\nVoluptatibus dolorem dolore mollitia modi expedita ab molestiae.", new DateTime(2023, 8, 23, 12, 17, 48, 821, DateTimeKind.Unspecified).AddTicks(4117) },
                    { 72L, 116L, "Temporibus voluptate voluptatum quod nemo quaerat est exercitationem mollitia sit.", new DateTime(2023, 4, 29, 1, 0, 35, 133, DateTimeKind.Unspecified).AddTicks(3379), 24L, "Repellendus est eius dolor id dolor sunt. Sint error consectetur earum. Rem est placeat.", new DateTime(2023, 5, 8, 10, 41, 15, 640, DateTimeKind.Unspecified).AddTicks(6645) },
                    { 73L, 54L, "Ratione in sit voluptatum nostrum.", new DateTime(2022, 7, 13, 11, 54, 6, 622, DateTimeKind.Unspecified).AddTicks(4912), 27L, "Blanditiis quam totam rerum in et.\nSed perferendis eius temporibus officiis nulla.\nEt amet repellendus ipsa perspiciatis.\nId nihil nesciunt.\nLaboriosam quis architecto id quisquam nihil quibusdam.", new DateTime(2023, 5, 8, 4, 55, 13, 412, DateTimeKind.Unspecified).AddTicks(7568) },
                    { 74L, 85L, "Dolores aut quis.\nEos sit in.\nEos est eum est magnam maiores.\nAut facere quaerat eos ullam quis perspiciatis officiis.\nNemo quam quia id optio unde.\nSed tenetur ut velit et.", new DateTime(2023, 6, 14, 23, 20, 46, 285, DateTimeKind.Unspecified).AddTicks(4482), 12L, "et", new DateTime(2023, 8, 10, 13, 51, 57, 640, DateTimeKind.Unspecified).AddTicks(8042) },
                    { 75L, 152L, "Perspiciatis soluta facilis. Voluptatibus voluptatem temporibus provident repellendus. Tempora saepe quod odio veritatis aut dolor. Dolores nostrum minus veniam in. In aspernatur delectus odio sed voluptatum sit ipsa. Nostrum debitis dignissimos sapiente aliquid error sit.", new DateTime(2022, 2, 6, 19, 14, 26, 566, DateTimeKind.Unspecified).AddTicks(8600), 5L, "Qui eligendi laboriosam repudiandae.\nCommodi temporibus aperiam ut suscipit id veniam quaerat aut.\nAssumenda rerum ullam aliquid asperiores nemo quaerat sit nemo ducimus.\nEt aut molestiae maxime deleniti perspiciatis enim.", new DateTime(2022, 6, 18, 14, 58, 53, 548, DateTimeKind.Unspecified).AddTicks(4828) },
                    { 76L, 39L, "architecto", new DateTime(2022, 6, 21, 13, 9, 17, 131, DateTimeKind.Unspecified).AddTicks(4648), 28L, "Impedit maiores aut et laboriosam voluptatem.\nSoluta porro qui molestiae officiis error molestias.\nLaudantium exercitationem maxime.\nEst sequi at inventore ut nesciunt ut non sed.", new DateTime(2022, 10, 5, 8, 1, 45, 530, DateTimeKind.Unspecified).AddTicks(9604) },
                    { 77L, 106L, "Iusto hic minima doloribus nulla. Omnis ratione rerum. Consectetur et velit quisquam. Sit ut fugiat ad vero molestiae ipsa blanditiis doloribus.", new DateTime(2023, 8, 23, 1, 54, 11, 231, DateTimeKind.Unspecified).AddTicks(7042), 40L, "quae", null },
                    { 78L, 160L, "Accusantium ut laudantium temporibus omnis sunt explicabo repudiandae.\nRecusandae sequi molestiae.", new DateTime(2022, 1, 16, 14, 18, 35, 107, DateTimeKind.Unspecified).AddTicks(5163), 36L, "Vel rerum minima aperiam iste dolorum qui qui quos nostrum.", null },
                    { 79L, 172L, "Totam atque optio laudantium et sit.\nSit omnis perferendis.\nOccaecati fugiat nam quo alias ratione dolor ut ut dolor.", new DateTime(2023, 8, 22, 20, 36, 50, 365, DateTimeKind.Unspecified).AddTicks(6480), 1L, "Et at quia necessitatibus delectus.", new DateTime(2023, 8, 23, 2, 53, 40, 709, DateTimeKind.Unspecified).AddTicks(50) },
                    { 80L, 122L, "Veniam repudiandae beatae aspernatur delectus quis vero eum odio.\nBlanditiis ut vitae vitae dicta pariatur et dolore veniam illo.\nEt laborum est nostrum.\nQuia ut quia.\nAut dolores nihil eos quisquam ut aspernatur.\nConsequatur aut iste recusandae consectetur aut porro expedita aut.", new DateTime(2023, 4, 21, 9, 15, 43, 56, DateTimeKind.Unspecified).AddTicks(5920), 6L, "Culpa totam esse. Nobis eius corporis iure aut vero velit tenetur quaerat et. Voluptatem non modi ea. Placeat repellat labore voluptatum dolores ut officiis qui ut. Modi magnam magni vitae asperiores laboriosam quisquam et. Quas non quo repellat.", new DateTime(2023, 7, 14, 3, 1, 8, 529, DateTimeKind.Unspecified).AddTicks(3517) },
                    { 81L, 68L, "Distinctio error sint nostrum.\nTempora itaque velit ducimus nisi sunt esse.\nQuidem rerum qui quia.", new DateTime(2022, 10, 29, 18, 25, 32, 130, DateTimeKind.Unspecified).AddTicks(123), 33L, "Qui ipsa vero et eaque repellat sunt. Necessitatibus natus omnis perferendis sunt molestias error nobis non. Esse aut dolor iure qui neque ea exercitationem eum. Distinctio dolor et blanditiis rerum quibusdam in. Impedit repellat aliquam qui dolores quasi occaecati. Temporibus iste voluptas distinctio quasi quaerat est eum blanditiis quisquam.", new DateTime(2023, 5, 25, 4, 2, 48, 29, DateTimeKind.Unspecified).AddTicks(9826) },
                    { 82L, 34L, "Quia aut veritatis explicabo magni omnis odit.\nReiciendis numquam sed eum aut quo accusamus quo quis et.", new DateTime(2023, 8, 23, 9, 53, 40, 492, DateTimeKind.Unspecified).AddTicks(2053), 40L, "Dignissimos in quia fugit.", new DateTime(2023, 8, 23, 10, 5, 38, 227, DateTimeKind.Unspecified).AddTicks(1351) },
                    { 83L, 160L, "et", new DateTime(2021, 12, 21, 23, 20, 7, 107, DateTimeKind.Unspecified).AddTicks(4271), 39L, "Eos velit eum optio molestiae et iste.\nVeniam reprehenderit nulla.\nMaxime aut totam voluptatum voluptas omnis nostrum alias.\nConsequatur itaque rerum aspernatur.", new DateTime(2023, 1, 18, 0, 55, 4, 420, DateTimeKind.Unspecified).AddTicks(8518) },
                    { 84L, 96L, "Quam at praesentium consequatur cum quis. Laborum voluptatem sed dolor ut autem. Debitis deserunt eum nobis libero eius.", new DateTime(2021, 8, 20, 7, 25, 57, 582, DateTimeKind.Unspecified).AddTicks(8233), 21L, "Ab voluptatum rerum animi totam enim.", new DateTime(2022, 11, 10, 16, 13, 6, 164, DateTimeKind.Unspecified).AddTicks(1632) },
                    { 85L, 131L, "quia", new DateTime(2023, 8, 13, 10, 15, 13, 219, DateTimeKind.Unspecified).AddTicks(4176), 19L, "aut", new DateTime(2023, 8, 22, 13, 48, 35, 56, DateTimeKind.Unspecified).AddTicks(8212) },
                    { 86L, 70L, "Soluta quisquam ut et. Vel veniam fugit aut alias repellat. Voluptatibus quia architecto et sed aspernatur voluptas et ipsum. Neque aspernatur fuga qui commodi aperiam. Ipsam voluptatem id commodi voluptatem.", new DateTime(2023, 5, 28, 4, 7, 42, 468, DateTimeKind.Unspecified).AddTicks(5298), 38L, "debitis", null },
                    { 87L, 97L, "Non quia ducimus.", new DateTime(2023, 8, 5, 10, 21, 24, 712, DateTimeKind.Unspecified).AddTicks(7523), 24L, "nisi", new DateTime(2023, 8, 10, 16, 47, 47, 698, DateTimeKind.Unspecified).AddTicks(8592) },
                    { 88L, 73L, "Natus odio exercitationem accusamus. Magnam fugiat quos reiciendis qui odio. Sint velit reiciendis assumenda eaque quia assumenda tempore. Tenetur est dolor iste voluptatem blanditiis. Non minus et rem sit aut ipsam corrupti illo. Eius repellendus distinctio occaecati.", new DateTime(2023, 2, 2, 21, 39, 10, 310, DateTimeKind.Unspecified).AddTicks(1447), 1L, "molestiae", new DateTime(2023, 4, 19, 15, 6, 20, 668, DateTimeKind.Unspecified).AddTicks(3520) },
                    { 89L, 197L, "magnam", new DateTime(2023, 1, 11, 7, 44, 8, 137, DateTimeKind.Unspecified).AddTicks(4238), 39L, "Autem id nam fugit enim. Autem ipsa sapiente et assumenda delectus. Earum aut quos quo nulla.", new DateTime(2023, 8, 4, 4, 21, 57, 928, DateTimeKind.Unspecified).AddTicks(3877) },
                    { 90L, 61L, "Mollitia vitae quis molestias. Dolorem aliquid sit dolor impedit qui. Aut autem asperiores dolorum natus doloribus nesciunt eaque doloremque deleniti.", new DateTime(2023, 7, 25, 8, 22, 50, 883, DateTimeKind.Unspecified).AddTicks(8128), 6L, "Nemo voluptate pariatur.", new DateTime(2023, 8, 20, 4, 30, 7, 964, DateTimeKind.Unspecified).AddTicks(8916) },
                    { 91L, 43L, "Impedit facere qui voluptas earum et ipsam voluptas ipsum. Est sapiente neque doloribus reprehenderit aliquid minus est. Dolorem sed officia ad.", new DateTime(2023, 5, 9, 23, 53, 51, 905, DateTimeKind.Unspecified).AddTicks(5034), 40L, "quasi", new DateTime(2023, 6, 10, 11, 3, 48, 198, DateTimeKind.Unspecified).AddTicks(1706) },
                    { 92L, 135L, "asperiores", new DateTime(2023, 4, 21, 2, 7, 39, 300, DateTimeKind.Unspecified).AddTicks(4805), 38L, "Accusamus aut modi numquam nihil. Porro voluptatem nisi provident dignissimos nobis ratione repudiandae. Voluptatem magni vel tenetur quo quia deleniti. Eligendi delectus ea animi. Ut libero dolor velit velit impedit. Et molestias rem impedit qui in enim.", null },
                    { 93L, 109L, "Officiis sit consequatur magnam neque reprehenderit eos provident. Sit fugit magnam aut cum. Dolore corrupti odio reprehenderit veniam facilis expedita odit et. Pariatur unde in et tempore. Quibusdam optio tempore autem animi. Rerum unde magni eum reiciendis modi.", new DateTime(2023, 7, 11, 23, 29, 45, 31, DateTimeKind.Unspecified).AddTicks(6152), 35L, "Exercitationem aliquam sint vel.\nFuga velit atque doloremque numquam architecto enim earum enim.\nVeniam laudantium culpa cum ipsam omnis ullam aut sequi.", new DateTime(2023, 7, 23, 2, 45, 34, 213, DateTimeKind.Unspecified).AddTicks(5834) },
                    { 94L, 126L, "Neque nesciunt iste nostrum expedita nobis.\nPorro iure non facilis culpa cupiditate beatae consequatur ut.\nAspernatur excepturi rerum aut sit.\nRepellat autem voluptas cupiditate ut qui ratione.", new DateTime(2023, 3, 8, 11, 8, 30, 632, DateTimeKind.Unspecified).AddTicks(2539), 10L, "Expedita ratione dolor possimus omnis fuga omnis quo sapiente.\nNisi expedita corporis et dolor sed expedita aut et sequi.\nVoluptate qui error iste sint saepe neque animi maiores.", new DateTime(2023, 7, 21, 2, 32, 33, 478, DateTimeKind.Unspecified).AddTicks(7523) }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "Output", "SubmittedAt" },
                values: new object[,]
                {
                    { 95L, 169L, "Id rem minus molestiae ab sunt. Laboriosam architecto dolores maxime qui. Quia dolor quia.", new DateTime(2023, 8, 13, 9, 33, 38, 695, DateTimeKind.Unspecified).AddTicks(3759), 9L, "Eius velit quidem. Et fugit aut est porro autem et omnis. Ipsam dolor labore sit nihil accusamus ea illo enim.", new DateTime(2023, 8, 17, 15, 40, 29, 202, DateTimeKind.Unspecified).AddTicks(3169) },
                    { 96L, 175L, "Architecto illum dolorum non consequatur veniam aut quod sed. Architecto in sed delectus sunt quis eveniet velit saepe. Qui repellendus fugit rerum rerum voluptates voluptatibus temporibus ut adipisci.", new DateTime(2023, 7, 8, 3, 13, 29, 552, DateTimeKind.Unspecified).AddTicks(9640), 26L, "inventore", new DateTime(2023, 8, 8, 19, 2, 8, 782, DateTimeKind.Unspecified).AddTicks(4454) },
                    { 97L, 117L, "Eos officia nemo illo quis expedita est magnam enim reprehenderit. Praesentium voluptatem magni qui nostrum nihil minus. Aspernatur corporis enim assumenda et sunt perferendis est libero libero. Incidunt reiciendis aut repellat quibusdam eos voluptatum veritatis animi nostrum.", new DateTime(2023, 1, 6, 19, 50, 4, 963, DateTimeKind.Unspecified).AddTicks(4155), 21L, "qui", null },
                    { 98L, 27L, "Consequatur reiciendis voluptate recusandae numquam deserunt.", new DateTime(2023, 8, 12, 22, 8, 0, 666, DateTimeKind.Unspecified).AddTicks(5587), 17L, "Deleniti enim aut odit qui vel. Perspiciatis ex voluptatem sit. Vel facilis magni est sapiente sunt temporibus. Dolore temporibus aut ad. Distinctio repudiandae qui quae. Ea aut ipsa sunt culpa voluptas velit doloremque ratione eos.", new DateTime(2023, 8, 13, 2, 34, 13, 821, DateTimeKind.Unspecified).AddTicks(5260) },
                    { 99L, 194L, "Ad dolore magnam sit eaque. Eos est ullam id repudiandae et totam laboriosam. Laudantium et ea quos est veritatis.", new DateTime(2023, 6, 19, 19, 58, 43, 467, DateTimeKind.Unspecified).AddTicks(8434), 19L, "Molestiae est assumenda sed commodi a aut dolore rem in. Et rerum iure recusandae velit tenetur necessitatibus. Aut fugit modi. Vitae harum sapiente in consequatur qui totam ad.", new DateTime(2023, 7, 28, 1, 59, 10, 417, DateTimeKind.Unspecified).AddTicks(7976) },
                    { 100L, 110L, "Laboriosam dolores nam ducimus saepe. Cumque dolorem incidunt nihil beatae assumenda quia est rem. Sed reiciendis nobis atque in iste ullam autem consequatur.", new DateTime(2023, 8, 18, 7, 44, 5, 454, DateTimeKind.Unspecified).AddTicks(7291), 22L, "Fugiat voluptatem autem.", new DateTime(2023, 8, 21, 6, 15, 22, 305, DateTimeKind.Unspecified).AddTicks(1827) },
                    { 101L, 82L, "Omnis dolor quis non eos ipsum.", new DateTime(2023, 5, 15, 8, 55, 46, 798, DateTimeKind.Unspecified).AddTicks(7854), 16L, "Optio aut optio dolores quas.", new DateTime(2023, 7, 8, 3, 9, 51, 455, DateTimeKind.Unspecified).AddTicks(8439) },
                    { 102L, 182L, "Dignissimos officia quisquam et quas iusto officiis provident voluptas. Vitae nesciunt commodi molestiae velit in iste. Eum repudiandae quam nemo sed.", new DateTime(2022, 8, 5, 5, 14, 40, 437, DateTimeKind.Unspecified).AddTicks(880), 26L, "Illum voluptate eos quis reprehenderit.", new DateTime(2023, 3, 15, 3, 12, 37, 537, DateTimeKind.Unspecified).AddTicks(5343) },
                    { 103L, 103L, "error", new DateTime(2023, 8, 2, 16, 54, 11, 899, DateTimeKind.Unspecified).AddTicks(8935), 30L, "harum", new DateTime(2023, 8, 20, 12, 43, 45, 848, DateTimeKind.Unspecified).AddTicks(5803) },
                    { 104L, 162L, "Sapiente non omnis voluptatibus.\nIn minima qui dolores iure ut provident est.\nMinus neque ducimus.", new DateTime(2023, 7, 4, 2, 4, 38, 471, DateTimeKind.Unspecified).AddTicks(3841), 8L, "Repellendus explicabo consequatur. Quos et est in culpa qui quo possimus repellat. Ducimus non deserunt velit ut molestias quo consequuntur.", new DateTime(2023, 7, 30, 23, 36, 55, 902, DateTimeKind.Unspecified).AddTicks(8291) },
                    { 105L, 76L, "Voluptate sint dignissimos ullam aliquid et quia earum.\nEaque placeat aut accusamus soluta tempore.\nProvident perferendis culpa aut similique aperiam consequatur.\nSed expedita saepe velit fuga a nobis earum.\nUt quae velit ipsam cumque quia culpa.", new DateTime(2019, 5, 29, 19, 14, 8, 387, DateTimeKind.Unspecified).AddTicks(9727), 17L, "Non omnis a quaerat sint dolores fuga alias non consequuntur.\nAut quis molestias omnis aspernatur eligendi ut consequatur voluptatem provident.\nConsequatur quaerat ut quidem voluptatum.\nEum est alias beatae sint.\nArchitecto ut et.", new DateTime(2023, 8, 21, 14, 53, 10, 511, DateTimeKind.Unspecified).AddTicks(8699) },
                    { 106L, 107L, "Autem tempore est sed id et est quisquam. Iure culpa tenetur optio quis. Expedita ut ipsum labore consequuntur eveniet consectetur quaerat iusto officiis. Exercitationem deserunt itaque voluptatem in deserunt asperiores et dolor. Temporibus id modi inventore reprehenderit ea qui est quos hic. Fugit dolores velit est repellendus sint est.", new DateTime(2022, 8, 8, 12, 47, 56, 657, DateTimeKind.Unspecified).AddTicks(3987), 22L, "Aliquam nam placeat suscipit perferendis dolor.\nVel maiores a.\nOdit et accusamus.\nRerum sit minus ut est provident earum.\nEnim dolor aspernatur non libero autem beatae nemo officiis in.", new DateTime(2023, 2, 4, 15, 45, 25, 273, DateTimeKind.Unspecified).AddTicks(113) },
                    { 107L, 93L, "Error repudiandae molestias doloribus laudantium consequatur sunt.", new DateTime(2022, 7, 3, 10, 30, 39, 518, DateTimeKind.Unspecified).AddTicks(2722), 19L, "Suscipit tenetur quia asperiores rerum ipsam id odio nesciunt.\nAliquam ut voluptatem voluptates et quia non autem suscipit sed.", null },
                    { 108L, 180L, "Nulla ipsum cupiditate maiores et tenetur maxime ex libero qui.\nEius suscipit aperiam error laudantium voluptatem eius saepe.\nLaboriosam aliquam voluptatum velit quia quas commodi.\nMollitia et hic enim aut aut deserunt maiores iure.", new DateTime(2023, 8, 11, 10, 15, 31, 296, DateTimeKind.Unspecified).AddTicks(6149), 18L, "Et neque ullam ut rerum porro sed velit.", new DateTime(2023, 8, 19, 4, 37, 47, 197, DateTimeKind.Unspecified).AddTicks(9083) },
                    { 109L, 33L, "Officia eligendi voluptas dolor quia officia officiis.\nNihil quidem iure suscipit provident odio in architecto ab.\nDolorem iusto ipsa porro provident atque.\nNemo molestiae aut.\nId quia unde quae quia consequatur nostrum veritatis.\nMollitia deleniti nostrum ut fugit enim.", new DateTime(2023, 4, 13, 4, 29, 34, 979, DateTimeKind.Unspecified).AddTicks(1299), 35L, "Nam alias quia qui deserunt sit saepe in iste.", new DateTime(2023, 7, 14, 0, 59, 13, 773, DateTimeKind.Unspecified).AddTicks(9479) },
                    { 110L, 36L, "Qui excepturi voluptas.\nQuia iusto veniam perferendis natus.\nUt qui quas id modi sequi corporis rerum molestiae et.\nPerferendis autem et facilis et dolores magni numquam quibusdam dolor.\nReprehenderit deleniti nostrum quibusdam atque quos laboriosam similique eaque.\nDoloremque et unde quaerat illo ut itaque est reprehenderit.", new DateTime(2023, 6, 12, 14, 25, 50, 794, DateTimeKind.Unspecified).AddTicks(8333), 10L, "id", new DateTime(2023, 8, 3, 4, 23, 55, 690, DateTimeKind.Unspecified).AddTicks(3376) },
                    { 111L, 134L, "Voluptatem quibusdam omnis sed provident.\nVoluptatem enim nihil libero consequatur ullam ea laborum.\nVoluptatibus commodi odit.\nAnimi et consectetur cupiditate voluptate id.\nRatione nemo atque.", new DateTime(2023, 6, 13, 14, 3, 40, 63, DateTimeKind.Unspecified).AddTicks(7636), 35L, "ullam", null },
                    { 112L, 76L, "Perferendis molestias doloremque a sint.", new DateTime(2021, 12, 24, 17, 57, 51, 602, DateTimeKind.Unspecified).AddTicks(6291), 36L, "culpa", new DateTime(2022, 2, 22, 22, 19, 36, 716, DateTimeKind.Unspecified).AddTicks(6951) },
                    { 113L, 44L, "Aliquam architecto iusto.", new DateTime(2023, 4, 6, 13, 5, 35, 58, DateTimeKind.Unspecified).AddTicks(3782), 30L, "Sint blanditiis animi porro eum. Quis a et explicabo est. Quo ab sunt. Similique voluptates cum quas dolorem est optio excepturi quia expedita.", new DateTime(2023, 6, 28, 5, 14, 31, 103, DateTimeKind.Unspecified).AddTicks(8818) },
                    { 114L, 156L, "Quibusdam natus voluptates ipsam consequuntur ipsum est fuga dolore quis. Doloremque fugit corporis doloribus autem molestias cupiditate veniam assumenda provident. Possimus sunt molestias ipsum et sequi ea aperiam voluptatem. Sit et aliquam provident ut magnam dolor quas at. Voluptatum velit id quia.", new DateTime(2023, 8, 5, 20, 12, 33, 910, DateTimeKind.Unspecified).AddTicks(8017), 30L, "Eius sunt nemo facilis.\nVel consequatur aut illum aut tenetur iste dolores voluptatem non.\nAut cumque enim.\nPraesentium voluptate aliquam.", new DateTime(2023, 8, 11, 16, 34, 2, 16, DateTimeKind.Unspecified).AddTicks(6277) },
                    { 115L, 66L, "Suscipit harum amet non qui rerum.", new DateTime(2023, 8, 21, 3, 55, 34, 530, DateTimeKind.Unspecified).AddTicks(4428), 19L, "Nihil magnam est voluptatem dignissimos. Rerum ea earum voluptatem iure dolores rem incidunt vel. Vel fugiat error et illo ab est praesentium sit.", new DateTime(2023, 8, 22, 12, 19, 8, 934, DateTimeKind.Unspecified).AddTicks(3867) },
                    { 116L, 117L, "Tenetur laboriosam rerum.", new DateTime(2021, 10, 13, 17, 10, 50, 477, DateTimeKind.Unspecified).AddTicks(4515), 14L, "Consequatur sint eum omnis reprehenderit. A doloribus eos. Consequatur neque voluptas fugit reprehenderit nostrum. Autem natus voluptatem qui aut. Culpa autem illum repellat ipsam ut dolores.", null },
                    { 117L, 168L, "Expedita quidem quas nisi laborum molestiae natus.\nAutem sequi soluta nam doloremque excepturi.", new DateTime(2023, 8, 22, 14, 1, 4, 990, DateTimeKind.Unspecified).AddTicks(3247), 18L, "rem", new DateTime(2023, 8, 22, 19, 48, 35, 394, DateTimeKind.Unspecified).AddTicks(9914) },
                    { 118L, 70L, "Ducimus est illo tempora magni assumenda dicta quod.\nAut porro molestiae omnis voluptatum.", new DateTime(2023, 7, 13, 13, 17, 13, 375, DateTimeKind.Unspecified).AddTicks(2289), 34L, "Sit iure accusantium nulla quidem debitis aut.", new DateTime(2023, 7, 18, 15, 26, 14, 288, DateTimeKind.Unspecified).AddTicks(1573) },
                    { 119L, 63L, "repellendus", new DateTime(2023, 5, 24, 13, 39, 36, 134, DateTimeKind.Unspecified).AddTicks(1686), 32L, "Vero saepe rerum accusamus sit ad accusantium.\nItaque voluptate tempora.", new DateTime(2023, 8, 19, 17, 51, 1, 855, DateTimeKind.Unspecified).AddTicks(5127) },
                    { 120L, 27L, "Perspiciatis quia aut similique fuga. Debitis similique facilis eveniet. Totam veritatis harum laboriosam ut qui deleniti.", new DateTime(2023, 8, 15, 1, 57, 40, 901, DateTimeKind.Unspecified).AddTicks(7057), 40L, "Alias dolor optio.\nDebitis ipsa eaque pariatur dolorem porro.\nOmnis quis ut vel pariatur quia.\nEst blanditiis nihil vel dolorem.\nEarum neque nesciunt ut consequatur autem.", new DateTime(2023, 8, 17, 6, 32, 2, 719, DateTimeKind.Unspecified).AddTicks(9816) },
                    { 121L, 11L, "Aspernatur maxime dolor voluptas quisquam.", new DateTime(2023, 4, 2, 15, 37, 16, 123, DateTimeKind.Unspecified).AddTicks(7888), 39L, "Fugit repudiandae eligendi sunt.", null },
                    { 122L, 60L, "voluptate", new DateTime(2023, 7, 29, 1, 17, 35, 646, DateTimeKind.Unspecified).AddTicks(2050), 2L, "Non porro aut et eaque.\nQuisquam voluptatem aut aut asperiores hic ut modi sint.\nEt maiores ut maiores enim accusantium.\nQuasi aut possimus sed omnis beatae.\nAt molestiae vel ipsa sunt.", new DateTime(2023, 8, 15, 10, 45, 33, 823, DateTimeKind.Unspecified).AddTicks(2608) },
                    { 123L, 38L, "Et culpa aspernatur aut excepturi aperiam cumque qui et.", new DateTime(2023, 6, 11, 16, 11, 21, 49, DateTimeKind.Unspecified).AddTicks(4432), 38L, "Et a quas dolore vel inventore veniam tempore.", null },
                    { 124L, 143L, "et", new DateTime(2023, 7, 24, 4, 12, 20, 575, DateTimeKind.Unspecified).AddTicks(8674), 20L, "Voluptas corporis numquam non.\nSed necessitatibus ut repellat et dicta.\nQuos eligendi molestiae.\nAmet vitae et dolor.", new DateTime(2023, 7, 24, 15, 56, 38, 708, DateTimeKind.Unspecified).AddTicks(4715) },
                    { 125L, 26L, "Doloremque officiis perferendis vel non.\nOmnis quia et aspernatur dolores iure.\nVoluptas veritatis eaque qui accusamus.", new DateTime(2022, 6, 14, 21, 43, 0, 767, DateTimeKind.Unspecified).AddTicks(5987), 38L, "Vero tenetur esse officia impedit eligendi consequuntur ut velit.\nAutem voluptates sunt.", new DateTime(2023, 4, 18, 1, 42, 9, 129, DateTimeKind.Unspecified).AddTicks(7037) },
                    { 126L, 195L, "sint", new DateTime(2023, 4, 15, 6, 21, 3, 970, DateTimeKind.Unspecified).AddTicks(2333), 26L, "Dicta officia soluta nihil rerum et commodi et.", new DateTime(2023, 6, 17, 18, 38, 11, 506, DateTimeKind.Unspecified).AddTicks(9343) },
                    { 127L, 20L, "Et quisquam est eius ullam dicta cumque voluptatum repellendus. Recusandae consequatur debitis alias et dicta cupiditate ratione et eum. Veniam ab voluptatum ut assumenda consequatur dolorem impedit vitae assumenda. Et repudiandae consequatur ea. Dicta velit repellat rerum quia.", new DateTime(2023, 8, 22, 17, 18, 46, 118, DateTimeKind.Unspecified).AddTicks(5631), 28L, "Omnis omnis facilis ex fugit sapiente doloremque illo.\nRerum numquam libero quia soluta provident porro debitis voluptas.\nDolores qui sit delectus harum aliquam illum iusto.\nAccusamus earum cumque rerum enim possimus doloribus eius.\nTotam mollitia quia quod sequi vero doloremque voluptatem.", new DateTime(2023, 8, 23, 10, 41, 11, 69, DateTimeKind.Unspecified).AddTicks(4138) },
                    { 128L, 74L, "odio", new DateTime(2022, 9, 4, 10, 7, 52, 891, DateTimeKind.Unspecified).AddTicks(9338), 29L, "Quis qui aut aspernatur exercitationem non exercitationem amet eum amet. Ea esse eligendi enim asperiores velit ipsum. Reprehenderit in quia recusandae atque similique est. Vero qui recusandae. Cumque cumque assumenda et harum.", new DateTime(2023, 4, 1, 17, 22, 4, 498, DateTimeKind.Unspecified).AddTicks(8188) },
                    { 129L, 141L, "In voluptas soluta porro error nostrum mollitia enim commodi. Velit quae est non. Sunt et iusto animi saepe molestiae officiis.", new DateTime(2023, 7, 17, 9, 23, 49, 214, DateTimeKind.Unspecified).AddTicks(6330), 37L, "Soluta minima ipsa.\nMaiores rerum est exercitationem explicabo et labore ipsa enim.\nExercitationem suscipit doloribus suscipit corrupti.\nSunt voluptatibus amet quo qui.\nAut consequatur magni.", new DateTime(2023, 7, 18, 13, 15, 21, 700, DateTimeKind.Unspecified).AddTicks(6667) },
                    { 130L, 41L, "In vel ut aut placeat iste fuga. Non consectetur ratione corporis natus. Ut ipsum exercitationem quas optio sunt quia qui saepe itaque.", new DateTime(2023, 2, 10, 3, 29, 15, 641, DateTimeKind.Unspecified).AddTicks(1604), 8L, "dolorem", new DateTime(2023, 2, 12, 11, 21, 20, 292, DateTimeKind.Unspecified).AddTicks(6016) },
                    { 131L, 55L, "Dolor deserunt a modi unde.", new DateTime(2023, 6, 28, 2, 4, 44, 40, DateTimeKind.Unspecified).AddTicks(1071), 28L, "Ut velit ut eos et sunt voluptatibus. Quas id qui amet. Aliquid aliquam atque voluptas similique qui eum quam est sint. Id sit dolor nisi culpa rerum maxime.", new DateTime(2023, 8, 4, 13, 7, 3, 738, DateTimeKind.Unspecified).AddTicks(8873) },
                    { 132L, 199L, "Deserunt adipisci eaque et. Non eius commodi molestiae laboriosam. Saepe voluptatibus labore ipsa qui illum.", new DateTime(2023, 8, 5, 12, 0, 7, 898, DateTimeKind.Unspecified).AddTicks(5515), 10L, "Quae autem quidem.\nIste doloribus praesentium repudiandae reprehenderit est nemo.\nMagnam reprehenderit asperiores amet vel distinctio.", new DateTime(2023, 8, 17, 8, 16, 38, 881, DateTimeKind.Unspecified).AddTicks(2306) },
                    { 133L, 47L, "odit", new DateTime(2022, 12, 12, 11, 37, 39, 879, DateTimeKind.Unspecified).AddTicks(1457), 18L, "voluptas", new DateTime(2023, 7, 15, 22, 5, 20, 69, DateTimeKind.Unspecified).AddTicks(1850) },
                    { 134L, 10L, "Quibusdam iste praesentium molestias.\nEt nemo ut quod doloremque.\nFacilis officia dolore vero omnis sequi odio iure est iure.\nHarum rem quas modi voluptatem soluta.\nVoluptas quae rerum.\nVoluptatem adipisci et et voluptatem.", new DateTime(2023, 7, 28, 4, 8, 35, 512, DateTimeKind.Unspecified).AddTicks(7895), 4L, "Nobis laborum aut consequuntur. Dolor adipisci autem fuga eligendi dolorem. Nisi quod ex molestiae. Consequatur veritatis quae et delectus ut maiores explicabo laboriosam quia. Tempora quo alias. Praesentium qui nihil fugiat expedita nisi.", new DateTime(2023, 8, 5, 5, 36, 58, 164, DateTimeKind.Unspecified).AddTicks(5337) },
                    { 135L, 32L, "modi", new DateTime(2023, 6, 15, 9, 22, 19, 348, DateTimeKind.Unspecified).AddTicks(5198), 28L, "Voluptas nihil itaque ratione saepe rerum qui.\nImpedit doloribus aperiam et at qui voluptatem repellendus.\nLaboriosam omnis rerum aperiam occaecati ut rerum voluptates.\nEius quia officia.\nVoluptas molestiae eum et numquam occaecati ut at officia.\nVel maiores quia libero enim doloremque consectetur.", new DateTime(2023, 7, 16, 20, 55, 6, 5, DateTimeKind.Unspecified).AddTicks(8684) },
                    { 136L, 12L, "Voluptatem iusto exercitationem labore debitis nam. Magni tenetur modi est nobis. Non et rerum.", new DateTime(2023, 8, 23, 5, 5, 51, 695, DateTimeKind.Unspecified).AddTicks(2810), 15L, "Dolores ab in mollitia. Debitis dolorem provident dolorem asperiores. Aut cupiditate quis enim saepe. Id et impedit. Omnis vero dolorem dignissimos nihil nisi dolores possimus non impedit. Magni porro debitis odio sint voluptas delectus.", new DateTime(2023, 8, 23, 5, 52, 3, 180, DateTimeKind.Unspecified).AddTicks(5781) }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "Output", "SubmittedAt" },
                values: new object[,]
                {
                    { 137L, 69L, "Enim maxime aperiam.\nMinima eius eaque minima culpa adipisci incidunt.\nFuga sed est omnis.", new DateTime(2023, 8, 13, 1, 31, 37, 797, DateTimeKind.Unspecified).AddTicks(2105), 28L, "Facere consequatur dolores officiis reiciendis et rerum aliquam.\nEst blanditiis quisquam excepturi odit dolorum aperiam reprehenderit.\nMaiores et in sunt iusto exercitationem et nobis.", new DateTime(2023, 8, 16, 22, 5, 27, 937, DateTimeKind.Unspecified).AddTicks(4104) },
                    { 138L, 131L, "Reiciendis officia ad vel accusamus illo ullam rerum sapiente.", new DateTime(2023, 8, 21, 3, 47, 47, 825, DateTimeKind.Unspecified).AddTicks(2227), 3L, "Consequuntur rem quisquam quae consequatur et exercitationem.", new DateTime(2023, 8, 21, 19, 49, 52, 308, DateTimeKind.Unspecified).AddTicks(6002) },
                    { 139L, 44L, "Et nostrum iste ullam.", new DateTime(2023, 3, 11, 14, 30, 16, 875, DateTimeKind.Unspecified).AddTicks(9228), 14L, "Quam repellat officiis sed sint.", new DateTime(2023, 6, 29, 13, 41, 47, 233, DateTimeKind.Unspecified).AddTicks(5290) },
                    { 140L, 193L, "Non ipsum assumenda delectus rerum suscipit quia architecto. Aut doloribus optio non ut. Et voluptas maxime nisi provident aspernatur dicta. Animi amet provident expedita.", new DateTime(2023, 8, 5, 10, 33, 28, 983, DateTimeKind.Unspecified).AddTicks(4562), 37L, "Iure ut et nulla tenetur dignissimos accusantium vero voluptas.", new DateTime(2023, 8, 9, 7, 21, 21, 285, DateTimeKind.Unspecified).AddTicks(3105) },
                    { 141L, 188L, "aut", new DateTime(2022, 10, 8, 5, 6, 41, 54, DateTimeKind.Unspecified).AddTicks(7789), 25L, "Id minima ut itaque ducimus et. Voluptas ipsa ipsum dolor aut cum ipsa. Voluptates quo molestiae at reiciendis. Officia eum odio fugiat vel molestiae. Delectus itaque quisquam ut rerum non cum quos corrupti doloremque.", new DateTime(2023, 4, 18, 17, 54, 24, 361, DateTimeKind.Unspecified).AddTicks(7837) },
                    { 142L, 171L, "Quis veritatis repudiandae quia aliquid tenetur maiores est asperiores.\nSaepe laudantium odit.\nVoluptatum quisquam officiis.\nQui et dolorem.", new DateTime(2023, 8, 9, 18, 20, 21, 709, DateTimeKind.Unspecified).AddTicks(1525), 26L, "Aut nihil consequatur enim repudiandae.", new DateTime(2023, 8, 19, 8, 30, 13, 136, DateTimeKind.Unspecified).AddTicks(3330) },
                    { 143L, 93L, "explicabo", new DateTime(2022, 12, 22, 14, 33, 40, 286, DateTimeKind.Unspecified).AddTicks(6532), 22L, "Omnis officia voluptas commodi suscipit eius nam animi voluptatem molestiae.", new DateTime(2023, 6, 18, 2, 17, 6, 638, DateTimeKind.Unspecified).AddTicks(9226) },
                    { 144L, 181L, "fugit", new DateTime(2023, 4, 12, 17, 33, 3, 750, DateTimeKind.Unspecified).AddTicks(9679), 40L, "Odit dolor perspiciatis facilis quasi reiciendis qui velit.\nSimilique architecto aut aut.\nFugit occaecati nobis et eum dolore cumque quia in.\nVoluptas qui consequatur quia est blanditiis omnis qui ad libero.\nReiciendis ipsa quia exercitationem ex beatae magnam in qui.\nSunt aliquid officiis laborum ea iste ab aut sunt.", new DateTime(2023, 7, 9, 4, 36, 38, 537, DateTimeKind.Unspecified).AddTicks(3951) },
                    { 145L, 197L, "Nobis quod autem.\nCumque dignissimos rerum eos voluptatum natus est voluptatum.\nDucimus consequatur rerum aperiam.\nAut dolores excepturi consequatur.\nQui officia cumque tempore delectus mollitia eum et tempore eum.\nSimilique expedita distinctio.", new DateTime(2023, 4, 25, 17, 57, 41, 669, DateTimeKind.Unspecified).AddTicks(4640), 37L, "accusamus", new DateTime(2023, 8, 9, 10, 55, 46, 533, DateTimeKind.Unspecified).AddTicks(7306) },
                    { 146L, 175L, "In perspiciatis explicabo et fuga.", new DateTime(2023, 6, 29, 2, 2, 22, 33, DateTimeKind.Unspecified).AddTicks(6545), 6L, "Quas ipsam quo et sunt repellat est et perspiciatis.\nVoluptatem aspernatur sunt.\nAut voluptatem quis.\nQuia adipisci voluptatem ipsa corrupti voluptates ducimus quaerat corporis.", new DateTime(2023, 8, 10, 7, 8, 44, 936, DateTimeKind.Unspecified).AddTicks(4151) },
                    { 147L, 11L, "unde", new DateTime(2023, 4, 26, 22, 6, 13, 832, DateTimeKind.Unspecified).AddTicks(279), 26L, "Deserunt vitae officiis dolores veritatis molestiae autem tempore dolor.\nNostrum nam earum ratione.\nCommodi quia nobis laudantium eum non et fugiat optio.", new DateTime(2023, 6, 4, 22, 50, 2, 751, DateTimeKind.Unspecified).AddTicks(1765) },
                    { 148L, 27L, "Et sit eligendi dolor qui inventore sunt. Eligendi ut enim. Aut laudantium non. Alias adipisci eum. Sunt nihil necessitatibus reiciendis magnam quia quos aut perspiciatis.", new DateTime(2023, 8, 17, 20, 18, 10, 845, DateTimeKind.Unspecified).AddTicks(3052), 15L, "Labore optio minus aperiam laborum qui reiciendis repudiandae ut deserunt.", new DateTime(2023, 8, 19, 19, 41, 48, 975, DateTimeKind.Unspecified).AddTicks(5133) },
                    { 149L, 56L, "Consequatur voluptas error.\nSoluta totam sed.", new DateTime(2020, 9, 20, 7, 0, 8, 978, DateTimeKind.Unspecified).AddTicks(6825), 13L, "Provident ad similique vitae sunt incidunt voluptatem aperiam.", new DateTime(2021, 8, 22, 21, 0, 15, 522, DateTimeKind.Unspecified).AddTicks(8621) },
                    { 150L, 100L, "veniam", new DateTime(2023, 7, 31, 10, 12, 48, 199, DateTimeKind.Unspecified).AddTicks(8959), 13L, "Nostrum velit harum iusto quos enim rerum quia.\nAliquid consequuntur sit voluptatem.\nQuia id ducimus quidem optio excepturi dolor ut quis.", new DateTime(2023, 8, 17, 19, 26, 9, 431, DateTimeKind.Unspecified).AddTicks(4621) },
                    { 151L, 96L, "Unde velit qui repudiandae et. Aspernatur dolor quaerat. Qui aspernatur ut et. Perferendis mollitia qui dolorem in.", new DateTime(2022, 9, 16, 3, 10, 40, 415, DateTimeKind.Unspecified).AddTicks(3069), 28L, "A iure dolorem voluptatem earum dicta natus architecto consequatur.\nQuasi culpa id sed sint recusandae et ut at.\nIpsam eum aut in voluptate adipisci.\nSequi nam voluptatibus minus quidem soluta.\nAssumenda non esse assumenda nesciunt optio optio quia.\nEnim ut voluptas.", new DateTime(2022, 11, 26, 22, 6, 23, 428, DateTimeKind.Unspecified).AddTicks(4550) },
                    { 152L, 82L, "temporibus", new DateTime(2023, 6, 9, 16, 55, 17, 99, DateTimeKind.Unspecified).AddTicks(1638), 17L, "In culpa nihil voluptates maxime eligendi.", new DateTime(2023, 6, 16, 21, 30, 31, 991, DateTimeKind.Unspecified).AddTicks(7440) },
                    { 153L, 27L, "Iure sint rerum consectetur nesciunt quod adipisci ex sed. Beatae et repudiandae rem blanditiis consequatur quas. Aliquam numquam consectetur rerum doloribus vero velit consequatur exercitationem. Facilis quia laudantium et maxime impedit nostrum eligendi. Aperiam harum soluta dolore modi. Molestiae fugiat dolore.", new DateTime(2023, 8, 20, 18, 28, 6, 83, DateTimeKind.Unspecified).AddTicks(4129), 1L, "In deserunt deserunt rerum minus in dignissimos cupiditate doloremque dolor. Ducimus atque quo commodi. Est facere sed. Omnis cupiditate totam non. Ut ut et et accusantium neque tempora. Possimus et culpa officiis temporibus.", new DateTime(2023, 8, 21, 5, 43, 13, 484, DateTimeKind.Unspecified).AddTicks(400) },
                    { 154L, 108L, "Ut omnis molestias soluta necessitatibus sit.", new DateTime(2023, 2, 5, 11, 24, 2, 725, DateTimeKind.Unspecified).AddTicks(1369), 25L, "Facere consectetur ab quia eum et voluptas.", new DateTime(2023, 2, 6, 1, 38, 7, 954, DateTimeKind.Unspecified).AddTicks(3014) },
                    { 155L, 63L, "Facilis dolor neque eos quod quasi sit deserunt. Numquam qui laboriosam quia praesentium. Dolor voluptas libero et.", new DateTime(2023, 1, 8, 20, 20, 9, 600, DateTimeKind.Unspecified).AddTicks(7354), 6L, "Praesentium quos quisquam.\nNon enim impedit aliquam.\nIste ratione aperiam et eveniet qui quia facere.\nNihil mollitia repellendus voluptates expedita qui iste.", new DateTime(2023, 2, 14, 4, 43, 46, 927, DateTimeKind.Unspecified).AddTicks(5320) },
                    { 156L, 199L, "Nesciunt et quia libero eos quos.", new DateTime(2023, 8, 11, 23, 51, 37, 745, DateTimeKind.Unspecified).AddTicks(4476), 34L, "Aut sunt ipsum adipisci ipsum mollitia voluptas qui occaecati repudiandae.\nAmet ut incidunt unde.", new DateTime(2023, 8, 16, 10, 42, 30, 132, DateTimeKind.Unspecified).AddTicks(5568) },
                    { 157L, 32L, "Est quis libero.", new DateTime(2023, 3, 10, 2, 11, 48, 296, DateTimeKind.Unspecified).AddTicks(3343), 33L, "Inventore sit quaerat sapiente ea porro est. Atque sed eum unde maiores. Rerum aperiam quia nostrum consectetur qui omnis fugiat ratione.", new DateTime(2023, 5, 24, 9, 22, 36, 852, DateTimeKind.Unspecified).AddTicks(8511) },
                    { 158L, 83L, "Exercitationem ea possimus reprehenderit laboriosam et amet. Aliquam blanditiis non aliquid praesentium nemo quo perferendis animi. Expedita dolorem vel nobis voluptas autem. Aperiam praesentium consequatur iure. Vero qui id aut dicta. Tempora iusto corporis eum.", new DateTime(2022, 10, 10, 3, 8, 41, 260, DateTimeKind.Unspecified).AddTicks(1132), 16L, "Itaque error deleniti est quos voluptatem consequatur at praesentium incidunt. Qui laborum sint sapiente dolorem corporis adipisci vel. Doloribus mollitia omnis placeat ducimus modi. Repellendus neque sequi enim incidunt accusamus maxime ut. Maxime ut delectus quos.", new DateTime(2022, 12, 19, 16, 2, 59, 34, DateTimeKind.Unspecified).AddTicks(6848) },
                    { 159L, 84L, "Ut enim repellat amet iste fugit hic nisi. Minus et enim tempore modi est nemo a corrupti. Et laborum minus nihil tenetur. Rerum perferendis culpa velit.", new DateTime(2023, 5, 10, 1, 48, 47, 222, DateTimeKind.Unspecified).AddTicks(3581), 13L, "Placeat aut sint saepe sequi vitae tempore.\nQuibusdam natus nihil aut odit eligendi qui nesciunt quisquam.\nVoluptatem qui deserunt.\nInventore sed nulla ipsa a tempore aut.\nQui ut accusamus nam cupiditate.\nNihil quibusdam sequi officiis illum occaecati quasi illo.", null },
                    { 160L, 74L, "Enim laudantium maiores. Repudiandae voluptatibus quae aut. Alias et molestiae. Nesciunt eos dignissimos dolorem quia qui. Itaque reprehenderit culpa architecto ut consequatur tempora et adipisci nihil. Dolore excepturi eaque asperiores voluptate soluta eum.", new DateTime(2022, 5, 14, 6, 35, 5, 402, DateTimeKind.Unspecified).AddTicks(1011), 36L, "Ipsa placeat illum et rerum quidem voluptatem minima. Consequatur rerum ea non dolorem aut. Voluptates animi et possimus et sint cumque qui voluptate sint. Neque minus voluptas repellendus suscipit minus. Eveniet rerum voluptas quia.", new DateTime(2022, 7, 24, 12, 1, 42, 272, DateTimeKind.Unspecified).AddTicks(7207) },
                    { 161L, 119L, "expedita", new DateTime(2019, 12, 10, 4, 20, 12, 583, DateTimeKind.Unspecified).AddTicks(8809), 31L, "Fugit occaecati assumenda repellendus debitis delectus magni consequuntur ab. Praesentium quisquam quaerat doloribus perspiciatis facilis. Laborum libero facere enim labore quia nihil. Ut soluta laudantium dolores facilis quod error suscipit. Ab non asperiores alias blanditiis assumenda quae.", new DateTime(2022, 9, 14, 13, 59, 26, 702, DateTimeKind.Unspecified).AddTicks(2483) },
                    { 162L, 199L, "dicta", new DateTime(2023, 8, 1, 4, 32, 40, 893, DateTimeKind.Unspecified).AddTicks(4966), 27L, "Quae quia dolorem mollitia officiis in.\nVitae laboriosam veniam.", new DateTime(2023, 8, 16, 9, 13, 29, 430, DateTimeKind.Unspecified).AddTicks(5358) },
                    { 163L, 168L, "Earum suscipit et qui sequi ut nihil et est.", new DateTime(2023, 8, 23, 3, 46, 49, 309, DateTimeKind.Unspecified).AddTicks(1306), 36L, "Et mollitia vero asperiores quia eligendi reprehenderit. Repudiandae quia vel non sint fugit atque. Omnis consectetur nam pariatur temporibus ex. Ad corrupti rerum necessitatibus. Quia explicabo modi dolorum aut. Voluptates est consequatur repellat tempora maiores molestias.", new DateTime(2023, 8, 23, 8, 38, 14, 245, DateTimeKind.Unspecified).AddTicks(909) },
                    { 164L, 156L, "Quia est praesentium fugit odit id.\nQui qui quas.", new DateTime(2023, 8, 15, 19, 33, 12, 757, DateTimeKind.Unspecified).AddTicks(7503), 23L, "Sed iure illum tenetur consectetur illum commodi quia quibusdam.", new DateTime(2023, 8, 21, 1, 29, 35, 477, DateTimeKind.Unspecified).AddTicks(9461) },
                    { 165L, 199L, "Facere voluptas eius at at quibusdam. Voluptas molestias alias illum fugiat. Modi dolores itaque sit. Corrupti sit vel sit et ullam. Dolorum placeat rerum dolores iusto voluptas qui iste quasi.", new DateTime(2023, 7, 27, 9, 34, 0, 484, DateTimeKind.Unspecified).AddTicks(8446), 10L, "Hic ut officia. Amet soluta illum unde autem natus. Veniam voluptatem dolores a molestiae. Similique quam eos et voluptatem incidunt. Molestiae enim architecto.", new DateTime(2023, 7, 31, 23, 34, 2, 834, DateTimeKind.Unspecified).AddTicks(460) },
                    { 166L, 191L, "Sed eveniet sunt et. Dicta facere qui veritatis in distinctio rem itaque. Qui inventore et voluptate debitis voluptatem molestiae eaque ut. Repudiandae est in. Aut reprehenderit tenetur non sequi voluptatem voluptas. Non earum est est dolorem similique dolorem.", new DateTime(2023, 8, 5, 16, 1, 2, 172, DateTimeKind.Unspecified).AddTicks(7373), 6L, "Dolores et mollitia eius libero maiores debitis quisquam corporis.\nEx unde quo.\nMolestias sed aliquid.\nDignissimos magni voluptatem tempore delectus accusamus consequuntur iste.\nAut voluptatibus ea officiis necessitatibus aliquam fugit rem.", new DateTime(2023, 8, 18, 13, 1, 56, 290, DateTimeKind.Unspecified).AddTicks(219) },
                    { 167L, 5L, "Voluptas ipsum vel incidunt qui ut delectus numquam dolores quia.\nDeleniti laudantium totam qui sunt fugit ut omnis.\nRerum sed totam nostrum mollitia sunt commodi dolore.\nTenetur rem atque rerum quo velit.", new DateTime(2023, 8, 13, 3, 49, 49, 498, DateTimeKind.Unspecified).AddTicks(3615), 28L, "Voluptates quo sit qui vel.\nDolorum quidem aut cum tempora autem id fuga.\nOptio perferendis natus cumque sunt quidem nesciunt ut porro.\nPerspiciatis id voluptatem mollitia placeat enim doloremque nisi.\nIusto itaque quisquam aut dolorem temporibus libero a natus.", new DateTime(2023, 8, 16, 18, 20, 30, 796, DateTimeKind.Unspecified).AddTicks(906) },
                    { 168L, 32L, "Rerum repellat expedita est facere itaque corporis qui.\nEarum rem eaque quaerat ea adipisci qui vel amet.", new DateTime(2023, 7, 8, 3, 10, 34, 597, DateTimeKind.Unspecified).AddTicks(1347), 1L, "Minus repudiandae quam cum. Non eligendi architecto adipisci necessitatibus perspiciatis voluptate. Et aperiam nobis. Nobis repellat quam. Doloribus nulla velit et corporis veniam. Modi provident distinctio tempore numquam quos et vitae labore.", new DateTime(2023, 8, 5, 7, 17, 53, 455, DateTimeKind.Unspecified).AddTicks(8277) },
                    { 169L, 112L, "Harum non omnis neque voluptas impedit quas itaque iste quibusdam.\nQuasi eius possimus exercitationem molestiae accusamus pariatur distinctio.", new DateTime(2023, 7, 12, 17, 51, 20, 119, DateTimeKind.Unspecified).AddTicks(5073), 8L, "officiis", new DateTime(2023, 8, 21, 13, 32, 58, 247, DateTimeKind.Unspecified).AddTicks(7696) },
                    { 170L, 32L, "non", new DateTime(2023, 7, 9, 5, 22, 4, 516, DateTimeKind.Unspecified).AddTicks(3632), 33L, "Sunt ut temporibus enim nostrum sunt molestias nam praesentium.", new DateTime(2023, 8, 8, 2, 52, 13, 569, DateTimeKind.Unspecified).AddTicks(1431) },
                    { 171L, 160L, "aut", new DateTime(2023, 3, 10, 3, 16, 42, 354, DateTimeKind.Unspecified).AddTicks(5308), 35L, "aliquam", new DateTime(2023, 5, 27, 19, 15, 23, 569, DateTimeKind.Unspecified).AddTicks(7841) },
                    { 172L, 193L, "Est illo non ipsam et aut. Quod impedit qui minima rerum laudantium sed quam. Iure quo quasi eos.", new DateTime(2023, 8, 18, 10, 28, 51, 393, DateTimeKind.Unspecified).AddTicks(630), 31L, "Earum molestiae quo libero rem architecto et.\nDelectus eius pariatur dignissimos blanditiis.\nQui non amet et sint maiores.\nQui quasi temporibus distinctio vel sed dicta qui facere.\nEt dolor corrupti ut necessitatibus omnis corporis consectetur libero sunt.\nIpsam qui laborum.", new DateTime(2023, 8, 19, 16, 34, 56, 544, DateTimeKind.Unspecified).AddTicks(9135) },
                    { 173L, 83L, "Aut quibusdam non ea quae consequatur explicabo. Provident tempora non corporis rerum distinctio delectus. Aliquam et aut debitis.", new DateTime(2022, 9, 10, 14, 42, 31, 124, DateTimeKind.Unspecified).AddTicks(6465), 30L, "saepe", new DateTime(2022, 11, 10, 12, 54, 47, 98, DateTimeKind.Unspecified).AddTicks(4684) },
                    { 174L, 22L, "Quo sint accusamus voluptas quis ut eligendi illo non.", new DateTime(2023, 8, 10, 18, 7, 27, 729, DateTimeKind.Unspecified).AddTicks(7693), 35L, "Magni iste et.\nNihil libero aspernatur.\nNatus doloribus adipisci consequatur adipisci consequatur doloribus veritatis quibusdam perferendis.", new DateTime(2023, 8, 20, 8, 10, 39, 218, DateTimeKind.Unspecified).AddTicks(7798) },
                    { 175L, 3L, "Expedita omnis ad magni est cumque.\nDolor fugit suscipit itaque enim sint molestias.\nEsse tempora pariatur voluptatem eos est sint voluptates harum.", new DateTime(2023, 5, 18, 11, 26, 4, 97, DateTimeKind.Unspecified).AddTicks(4892), 39L, "Vero consectetur quam eum eos sunt omnis.", new DateTime(2023, 7, 27, 16, 46, 43, 892, DateTimeKind.Unspecified).AddTicks(3307) },
                    { 176L, 53L, "Nihil esse aliquam et quia corrupti.", new DateTime(2023, 6, 17, 15, 33, 1, 502, DateTimeKind.Unspecified).AddTicks(2136), 13L, "commodi", new DateTime(2023, 8, 13, 5, 26, 59, 638, DateTimeKind.Unspecified).AddTicks(9608) },
                    { 177L, 134L, "Id pariatur facilis officiis non voluptas reprehenderit commodi minus.", new DateTime(2023, 6, 12, 20, 53, 57, 837, DateTimeKind.Unspecified).AddTicks(4355), 10L, "Unde a dolores praesentium eligendi et qui qui odio.", new DateTime(2023, 7, 19, 6, 42, 37, 250, DateTimeKind.Unspecified).AddTicks(1108) },
                    { 178L, 16L, "Rerum sequi eos sit optio minima.", new DateTime(2022, 6, 3, 1, 23, 55, 380, DateTimeKind.Unspecified).AddTicks(3339), 20L, "enim", new DateTime(2022, 6, 27, 13, 7, 21, 694, DateTimeKind.Unspecified).AddTicks(7870) }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "Output", "SubmittedAt" },
                values: new object[,]
                {
                    { 179L, 70L, "ab", new DateTime(2023, 7, 8, 9, 55, 34, 273, DateTimeKind.Unspecified).AddTicks(2483), 32L, "Itaque eos accusamus voluptas similique.\nVoluptatem similique ipsa culpa architecto deserunt dolores aut.", new DateTime(2023, 7, 17, 22, 45, 52, 747, DateTimeKind.Unspecified).AddTicks(3494) },
                    { 180L, 91L, "Enim consequatur modi ut.", new DateTime(2022, 5, 12, 19, 16, 21, 752, DateTimeKind.Unspecified).AddTicks(9524), 38L, "Dolorem velit sit qui beatae incidunt fugiat.\nEt ipsa officia qui facere.\nLabore error velit ut.", new DateTime(2022, 10, 3, 13, 12, 0, 391, DateTimeKind.Unspecified).AddTicks(1556) },
                    { 181L, 197L, "Consequuntur libero voluptas facilis officiis tenetur rem minus. Harum in non excepturi ut ut. Quisquam praesentium et qui cumque voluptatem doloremque. Voluptatem quasi libero quibusdam. Eos rerum suscipit dolores ea.", new DateTime(2023, 2, 16, 18, 48, 59, 66, DateTimeKind.Unspecified).AddTicks(6005), 39L, "dolorem", new DateTime(2023, 6, 15, 21, 36, 39, 220, DateTimeKind.Unspecified).AddTicks(1866) },
                    { 182L, 128L, "qui", new DateTime(2023, 7, 16, 16, 8, 58, 612, DateTimeKind.Unspecified).AddTicks(9575), 5L, "Iure ipsa sit facere officia.\nTempora et voluptatem.", new DateTime(2023, 8, 9, 3, 30, 2, 818, DateTimeKind.Unspecified).AddTicks(6856) },
                    { 183L, 68L, "Totam ut placeat veritatis et sequi quibusdam aut.", new DateTime(2023, 6, 2, 21, 24, 5, 387, DateTimeKind.Unspecified).AddTicks(4883), 35L, "Maiores illo soluta exercitationem nihil.\nFacere soluta et.\nExcepturi ad illum aut sunt laboriosam alias.\nOfficiis commodi quis aliquid repellat omnis amet.\nAut quo ut et vitae adipisci pariatur omnis et.", new DateTime(2023, 6, 20, 4, 32, 29, 586, DateTimeKind.Unspecified).AddTicks(3494) },
                    { 184L, 200L, "Inventore a ut non tenetur eos vel quibusdam. Nobis autem sint harum illo magni odit. Voluptatibus repudiandae ducimus eum non ipsam nihil.", new DateTime(2023, 8, 4, 7, 15, 0, 379, DateTimeKind.Unspecified).AddTicks(9611), 29L, "accusamus", new DateTime(2023, 8, 10, 10, 43, 30, 877, DateTimeKind.Unspecified).AddTicks(7034) },
                    { 185L, 90L, "Eligendi earum mollitia et non.", new DateTime(2023, 5, 13, 18, 50, 45, 596, DateTimeKind.Unspecified).AddTicks(8264), 17L, "reiciendis", new DateTime(2023, 7, 4, 18, 29, 42, 979, DateTimeKind.Unspecified).AddTicks(576) },
                    { 186L, 119L, "Non nihil est sit a tempore enim non rerum. Necessitatibus dicta nesciunt illum id magnam vel aut nam. Fugit sed sit harum fugiat recusandae accusantium itaque perferendis aut. Sit quaerat saepe temporibus atque tempore at ut culpa nihil. Tenetur vitae ipsa veritatis qui id.", new DateTime(2022, 5, 10, 22, 4, 16, 972, DateTimeKind.Unspecified).AddTicks(149), 5L, "Deserunt adipisci libero optio cum cupiditate perferendis sit. Est suscipit excepturi. Necessitatibus impedit dolorem voluptatem doloremque quia culpa a laboriosam. Sint nihil culpa.", new DateTime(2022, 7, 3, 12, 58, 46, 147, DateTimeKind.Unspecified).AddTicks(7402) },
                    { 187L, 119L, "facere", new DateTime(2019, 2, 10, 3, 22, 22, 256, DateTimeKind.Unspecified).AddTicks(29), 40L, "ex", new DateTime(2019, 8, 14, 0, 10, 3, 548, DateTimeKind.Unspecified).AddTicks(9044) },
                    { 188L, 33L, "Recusandae sunt eveniet sed adipisci sit ut.\nIn quisquam nobis quod aliquam odit sequi.\nExplicabo quam quam velit et tempora labore omnis qui provident.\nUt et sint neque et quis dolorem sequi.\nConsequatur laudantium voluptates quaerat sed iste.", new DateTime(2023, 5, 8, 12, 19, 33, 506, DateTimeKind.Unspecified).AddTicks(9507), 21L, "Commodi aut debitis. Quia sit ut ut quaerat laborum. Pariatur dolores iure distinctio laborum repellat quos distinctio. Voluptas blanditiis molestiae tenetur est sit harum.", new DateTime(2023, 6, 14, 23, 16, 37, 642, DateTimeKind.Unspecified).AddTicks(2896) },
                    { 189L, 129L, "Molestiae voluptas quibusdam eos ut. Nobis accusantium numquam dignissimos in tempore architecto. Est sed et amet. Corporis et tempore et quo voluptatem eum accusantium architecto. Quaerat voluptas maiores odio voluptatem ut.", new DateTime(2023, 8, 8, 5, 54, 36, 558, DateTimeKind.Unspecified).AddTicks(9855), 25L, "Possimus itaque beatae et numquam excepturi ratione excepturi. Ut excepturi laboriosam veniam consectetur quae reprehenderit. Facere sint dicta voluptas sint deserunt.", new DateTime(2023, 8, 10, 0, 51, 46, 112, DateTimeKind.Unspecified).AddTicks(9925) },
                    { 190L, 88L, "illo", new DateTime(2022, 12, 24, 11, 9, 4, 210, DateTimeKind.Unspecified).AddTicks(1316), 14L, "debitis", new DateTime(2023, 7, 25, 7, 43, 42, 886, DateTimeKind.Unspecified).AddTicks(2653) },
                    { 191L, 188L, "Velit error excepturi dolorem omnis natus.", new DateTime(2022, 5, 15, 13, 39, 39, 429, DateTimeKind.Unspecified).AddTicks(3663), 6L, "reiciendis", new DateTime(2023, 1, 31, 13, 48, 51, 468, DateTimeKind.Unspecified).AddTicks(8632) },
                    { 192L, 6L, "Labore nisi totam temporibus voluptatem reprehenderit iste minima quas. Harum alias nulla voluptas dolorem. Maiores exercitationem quas occaecati.", new DateTime(2022, 8, 17, 13, 28, 11, 280, DateTimeKind.Unspecified).AddTicks(2535), 22L, "Fugiat ab mollitia aut voluptatibus et amet quos.", new DateTime(2023, 4, 14, 16, 50, 33, 862, DateTimeKind.Unspecified).AddTicks(3986) },
                    { 193L, 62L, "Adipisci sit aut incidunt quia quas molestiae quae.\nQuis est debitis in.\nNisi deserunt praesentium omnis.\nEsse adipisci nostrum velit ut explicabo aut.\nId dolor velit in harum velit ullam aut.", new DateTime(2023, 8, 19, 17, 17, 13, 405, DateTimeKind.Unspecified).AddTicks(8570), 36L, "Explicabo commodi voluptas consequuntur omnis nulla est.", new DateTime(2023, 8, 21, 1, 11, 4, 310, DateTimeKind.Unspecified).AddTicks(5361) },
                    { 194L, 37L, "Accusantium nisi quos et est odit eos ipsam.\nVoluptatem voluptatem recusandae quibusdam eos totam minima vitae vero.", new DateTime(2019, 10, 12, 8, 24, 19, 851, DateTimeKind.Unspecified).AddTicks(3134), 8L, "consequatur", new DateTime(2022, 4, 5, 20, 17, 35, 680, DateTimeKind.Unspecified).AddTicks(7580) },
                    { 195L, 45L, "Explicabo autem et voluptatem perferendis itaque est quasi aut. Debitis ea tenetur ab. Aut quis repudiandae vel quod voluptas quidem.", new DateTime(2023, 8, 16, 20, 6, 35, 135, DateTimeKind.Unspecified).AddTicks(6824), 15L, "Unde illum qui nulla illo pariatur praesentium aut dicta.", new DateTime(2023, 8, 19, 12, 36, 17, 275, DateTimeKind.Unspecified).AddTicks(5784) },
                    { 196L, 82L, "In voluptatum rerum reiciendis cum velit dolores. Atque ex provident maiores minima rerum blanditiis aut. Id adipisci atque. Sit tenetur quod architecto voluptatem animi dolorem eos ea. Asperiores tenetur non dignissimos. Vel pariatur officiis voluptate.", new DateTime(2023, 7, 26, 5, 45, 28, 841, DateTimeKind.Unspecified).AddTicks(4993), 33L, "Similique dolores molestiae illum.", new DateTime(2023, 8, 3, 16, 15, 25, 814, DateTimeKind.Unspecified).AddTicks(6930) },
                    { 197L, 89L, "Assumenda vel occaecati ratione et.\nConsequatur enim et vitae sit.\nAperiam et quas nostrum qui et minus.\nDolorem iste ducimus praesentium vel aliquam molestias adipisci inventore.\nAspernatur nam enim culpa odio veritatis facilis ut earum.", new DateTime(2023, 7, 13, 9, 42, 1, 469, DateTimeKind.Unspecified).AddTicks(5187), 26L, "Impedit corrupti enim.\nRepellendus quod ut voluptatum similique veritatis.\nItaque quia numquam recusandae veritatis sit et pariatur laborum.\nDistinctio maiores occaecati enim qui.", new DateTime(2023, 8, 2, 18, 37, 37, 236, DateTimeKind.Unspecified).AddTicks(6068) },
                    { 198L, 30L, "amet", new DateTime(2023, 7, 15, 9, 56, 14, 75, DateTimeKind.Unspecified).AddTicks(2435), 39L, "nulla", new DateTime(2023, 8, 2, 18, 7, 46, 540, DateTimeKind.Unspecified).AddTicks(9794) },
                    { 199L, 152L, "Enim aperiam rerum sit autem tempora consequuntur.", new DateTime(2022, 5, 24, 15, 37, 30, 492, DateTimeKind.Unspecified).AddTicks(4452), 34L, "Libero maiores possimus ab quas.\nFugit sit fugit praesentium dolorem architecto omnis error facere.\nConsequatur aut repudiandae.\nSit vitae quia libero iure hic harum itaque beatae in.\nEt deserunt perferendis unde sed.\nQuibusdam blanditiis ex enim dolores est.", new DateTime(2022, 9, 25, 20, 25, 22, 236, DateTimeKind.Unspecified).AddTicks(1259) },
                    { 200L, 183L, "Sequi libero alias odit officia distinctio dicta distinctio omnis.\nDolor aliquam porro qui.\nDeleniti placeat perferendis omnis rerum sunt sint iste deserunt.", new DateTime(2023, 6, 11, 20, 15, 30, 656, DateTimeKind.Unspecified).AddTicks(4059), 20L, "et", new DateTime(2023, 7, 31, 4, 9, 39, 452, DateTimeKind.Unspecified).AddTicks(5388) }
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
                name: "IX_Tests_CreatedBy",
                table: "Tests",
                column: "CreatedBy");

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
                name: "IX_UserSolutions_CreatedBy",
                table: "UserSolutions",
                column: "CreatedBy");
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
