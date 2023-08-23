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
                    { 1L, new DateTime(1993, 2, 24, 9, 18, 32, 656, DateTimeKind.Unspecified).AddTicks(2617), 26, "Josue41@hotmail.com", "Grayson", "/wymtrpbcdupodqfwhkxtmnyngfjrqv.jpg", false, true, "Tremblay", "j5xii6spbrvfvasc6b42i4qkxc0xih8e", new DateTime(2016, 9, 22, 8, 44, 7, 675, DateTimeKind.Unspecified).AddTicks(5796), 1, 0, -1, 60915L, "Emmalee_West0" },
                    { 2L, new DateTime(1988, 2, 12, 22, 44, 58, 841, DateTimeKind.Unspecified).AddTicks(3506), 25, "Mitchel4@yahoo.com", "Kristopher", "/ooilkjpddwfvomzpbjspeczybqrwsj.jpg", false, true, "Blanda", "7mg6vwys190zw8d8ke20ld5fvglddroq", new DateTime(2020, 11, 15, 8, 27, 13, 727, DateTimeKind.Unspecified).AddTicks(7940), 3, 2, 2, 34838L, "Blake631" },
                    { 3L, new DateTime(1991, 9, 27, 20, 32, 48, 50, DateTimeKind.Unspecified).AddTicks(2864), 7, "Kay29@hotmail.com", "Deja", "/uruwlaikhplhphodpuwfuzkjbswrhw.jpg", false, false, "Haley", "tjpdyqzs4d07s1t1uan24qztisafsq5n", new DateTime(2016, 12, 8, 9, 36, 14, 596, DateTimeKind.Unspecified).AddTicks(8392), 1, 3, 10, 23246L, "Jacquelyn182" },
                    { 4L, new DateTime(1993, 1, 5, 19, 57, 27, 174, DateTimeKind.Unspecified).AddTicks(9656), 28, "Kara_Ankunding3@yahoo.com", "Rachel", "/ftbpxwdlozkfjcjhymqzvyibmqypyw.jpg", false, true, "Pagac", "swlmxpoand6djta9thu2lj8l69e03awj", new DateTime(2020, 7, 12, 4, 0, 51, 37, DateTimeKind.Unspecified).AddTicks(1058), 2, 0, 0, 76727L, "Jayda.Doyle3" },
                    { 5L, new DateTime(1980, 9, 23, 6, 52, 56, 292, DateTimeKind.Unspecified).AddTicks(167), 22, "Orval.Erdman74@yahoo.com", "Loma", "/xhgrzkqhrfjmqxwpuqbifmzszvswxf.jpg", false, true, "Schultz", "vhfskfyumcicwffr5ljwzkq4jfaio5ps", new DateTime(2020, 11, 1, 4, 1, 58, 807, DateTimeKind.Unspecified).AddTicks(9607), 1, 1, 10, 82585L, "Deangelo.Sch4" },
                    { 6L, new DateTime(1981, 3, 5, 1, 59, 53, 769, DateTimeKind.Unspecified).AddTicks(7548), 23, "Damon33@gmail.com", "Vernice", "/zghthgddlemqszlbosihchaoaiswsg.jpg", false, true, "Armstrong", "gikge714qk6b6sj23v3hqhbu8p7rqzk9", new DateTime(2016, 3, 20, 16, 33, 10, 251, DateTimeKind.Unspecified).AddTicks(1102), 0, 2, 12, 28021L, "Merlin_Schul5" },
                    { 7L, new DateTime(1988, 10, 5, 3, 59, 54, 595, DateTimeKind.Unspecified).AddTicks(4360), 32, "Ursula_Ferry23@gmail.com", "Helene", "/nyetfrahktaxxzcpauiwmimoslqztu.jpg", false, true, "Abbott", "qqh5orrb2v8q09r7w35exfiwr7gm0s20", new DateTime(2022, 3, 7, 13, 56, 33, 665, DateTimeKind.Unspecified).AddTicks(6302), 2, 3, -6, 73975L, "Norwood.Buck6" },
                    { 8L, new DateTime(1985, 9, 28, 21, 8, 34, 884, DateTimeKind.Unspecified).AddTicks(7502), 3, "Jordyn_Lindgren@hotmail.com", "Maybell", "/iwigpkmhdhhvffkgmuduvpfrchbxfv.jpg", false, true, "Roberts", "h8j77ro0ucs1neglfjvyapdp0qmm5bcl", new DateTime(2020, 6, 5, 12, 54, 31, 670, DateTimeKind.Unspecified).AddTicks(5355), 1, 3, -12, 652L, "Henriette.Ni7" },
                    { 9L, new DateTime(1983, 10, 27, 19, 37, 38, 966, DateTimeKind.Unspecified).AddTicks(8052), 20, "Jaunita.Spencer@gmail.com", "Janie", "/gnuwvemdbwnafziplilofkvtpsguuk.jpg", false, true, "Wilkinson", "ogtjst16gthiilfsssm8s5eytvo094yp", new DateTime(2020, 4, 7, 3, 23, 6, 879, DateTimeKind.Unspecified).AddTicks(8138), 2, 0, -11, 66960L, "Providenci_A8" },
                    { 10L, new DateTime(1987, 9, 8, 2, 6, 58, 381, DateTimeKind.Unspecified).AddTicks(1715), 40, "Patricia.Walker@yahoo.com", "Donald", "/oqnbwsydaxiwuewkjpdqcrngvxdzlr.jpg", false, false, "Torphy", "h6iks1o0by8djdjq9j0uz6st1v398ylx", new DateTime(2021, 7, 21, 13, 30, 40, 242, DateTimeKind.Unspecified).AddTicks(9708), 1, 1, -9, 21532L, "Leanne_Bedna9" },
                    { 11L, new DateTime(1986, 10, 30, 13, 4, 23, 299, DateTimeKind.Unspecified).AddTicks(430), 57, "Asa_Nicolas@hotmail.com", "Eunice", "/priksnyykujihsezkjbefcqwqlhszo.jpg", false, true, "Greenholt", "5b0y2o3roofvbkxu20z6aqkfri1fr987", new DateTime(2022, 8, 7, 19, 15, 44, 659, DateTimeKind.Unspecified).AddTicks(3853), 3, 2, -11, 33445L, "Chandler.Hom10" },
                    { 12L, new DateTime(1990, 5, 6, 18, 6, 2, 959, DateTimeKind.Unspecified).AddTicks(5583), 50, "Verda.Schinner@gmail.com", "Madilyn", "/tugltpfoqrzklfxmywntjmhqafslsy.jpg", false, true, "Pollich", "gywyh6k7aq42u6naxifb52alw8hmejvr", new DateTime(2022, 11, 24, 18, 15, 26, 670, DateTimeKind.Unspecified).AddTicks(7129), 2, 0, -12, 50225L, "Gavin_Reinge11" },
                    { 13L, new DateTime(1990, 5, 3, 11, 10, 44, 617, DateTimeKind.Unspecified).AddTicks(9801), 37, "Willard18@gmail.com", "Mohamed", "/zkukribgryvtwjfdzqulusklmnzppj.jpg", false, true, "McClure", "nm9prgxtd6gh1ywtx83i5cyueazcw5bg", new DateTime(2017, 7, 15, 18, 57, 39, 166, DateTimeKind.Unspecified).AddTicks(6441), 1, 1, -8, 15042L, "Ole6512" },
                    { 14L, new DateTime(1993, 5, 20, 23, 4, 4, 892, DateTimeKind.Unspecified).AddTicks(7492), 48, "Jovany_Pacocha@yahoo.com", "Celestine", "/mbfhrkhmloxfwzwtqtiuqiizcjwcqo.jpg", true, true, "Gibson", "t8kkzk20i2u5bm92rzgxssct55q96bj7", new DateTime(2021, 1, 5, 20, 10, 5, 484, DateTimeKind.Unspecified).AddTicks(8055), 3, 2, 4, 28772L, "Leopold6513" },
                    { 15L, new DateTime(1989, 5, 9, 11, 50, 28, 465, DateTimeKind.Unspecified).AddTicks(1597), 40, "Maxwell_Bauch@hotmail.com", "Lonny", "/qstbwtlvvvvenqikwpkmzegeocxrdb.jpg", false, true, "Feeney", "k5qnk35pswu6gus1qa5mt3m4xggkhsur", new DateTime(2017, 10, 31, 12, 31, 33, 371, DateTimeKind.Unspecified).AddTicks(8770), 3, 1, 5, 87680L, "Deonte.Waelc14" },
                    { 16L, new DateTime(1997, 11, 14, 20, 7, 26, 876, DateTimeKind.Unspecified).AddTicks(4806), 37, "Joanne_Hilll@yahoo.com", "Chloe", "/nglnpscrpfzbcnspdpwfyjqhcndtaf.jpg", false, true, "Schowalter", "zf785is5u5zjnytgi90u9wifk5m5f3kc", new DateTime(2021, 12, 3, 16, 51, 56, 744, DateTimeKind.Unspecified).AddTicks(1032), 1, 0, 2, 86138L, "Juanita_Mona15" },
                    { 17L, new DateTime(1993, 9, 6, 15, 13, 11, 647, DateTimeKind.Unspecified).AddTicks(3510), 34, "Jaylan88@yahoo.com", "Vince", "/teycxuraxqstoqygsgpqxvbhdvfely.jpg", true, true, "Russel", "os3plgg5o27c94814kghx80czw3ny3kh", new DateTime(2022, 2, 15, 8, 1, 47, 155, DateTimeKind.Unspecified).AddTicks(3309), 3, 3, 11, 86419L, "Maybell_DuBu16" },
                    { 18L, new DateTime(1993, 2, 5, 1, 11, 38, 546, DateTimeKind.Unspecified).AddTicks(688), 10, "Amber_Botsford72@hotmail.com", "Kendall", "/yalusssjufpnsuieijhnzrjrmxliep.jpg", false, true, "Marks", "vewqmyi5x5b40dz0qr8rqpe5q9mratae", new DateTime(2021, 1, 8, 16, 12, 55, 671, DateTimeKind.Unspecified).AddTicks(8462), 0, 1, -8, 98054L, "Kamille_Kirl17" },
                    { 19L, new DateTime(1992, 8, 30, 14, 11, 30, 71, DateTimeKind.Unspecified).AddTicks(9329), 40, "Jadon.Dibbert40@hotmail.com", "Carli", "/wdatzjitwcwyyvavktqwcpghyxppcv.jpg", false, false, "Koch", "mmbsb65vzr1waca9wtzu2f17aawqs3rp", new DateTime(2021, 2, 7, 14, 40, 56, 278, DateTimeKind.Unspecified).AddTicks(6556), 0, 1, -7, 17124L, "Breanne_Dool18" },
                    { 20L, new DateTime(1980, 3, 2, 13, 30, 17, 557, DateTimeKind.Unspecified).AddTicks(4008), 18, "Zion_Osinski62@hotmail.com", "Joyce", "/fueodmahlcwaifgxbrthdenrfjczzt.jpg", false, false, "Rowe", "43z3g99nhpij8fvuhz10y09hg18idrd1", new DateTime(2020, 9, 7, 23, 2, 0, 912, DateTimeKind.Unspecified).AddTicks(6655), 2, 3, 7, 24724L, "Rosalind2919" },
                    { 21L, new DateTime(1980, 10, 16, 19, 14, 19, 862, DateTimeKind.Unspecified).AddTicks(216), 52, "Rachelle.Hickle94@gmail.com", "Gordon", "/zudvnqlathsimfomcvggbkoufswcds.jpg", false, true, "Dietrich", "0w92cwtxhmbyu4hpaeelpjmvwk8bmtrc", new DateTime(2021, 1, 19, 2, 42, 6, 5, DateTimeKind.Unspecified).AddTicks(7986), 0, 1, 8, 40527L, "Alfred_Saway20" },
                    { 22L, new DateTime(1985, 1, 13, 10, 52, 46, 135, DateTimeKind.Unspecified).AddTicks(4769), 43, "Emmy.Lakin@yahoo.com", "Cayla", "/rozmgketrnirwzbuvrrxnuyneayuau.jpg", false, true, "Heaney", "04fbnc2sjm74y5uorx0slntixwlga9ge", new DateTime(2021, 5, 15, 5, 9, 11, 754, DateTimeKind.Unspecified).AddTicks(6580), 3, 2, -7, 53546L, "Liliane5521" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Country", "Email", "FirstName", "ImagePath", "IsBanned", "IsSubscribed", "LastName", "OAuthToken", "RegisteredAt", "Sex", "Status", "Timezone", "TotalScore", "UserName" },
                values: new object[,]
                {
                    { 23L, new DateTime(1985, 8, 1, 11, 42, 11, 968, DateTimeKind.Unspecified).AddTicks(9187), 38, "Marion1@hotmail.com", "Amber", "/tgfihyjttpnhevkcqqlgqhbootvocv.jpg", false, false, "Brown", "rr0gmho5wb5kz3jtwuzq4130eh6osi3t", new DateTime(2019, 3, 2, 18, 20, 42, 362, DateTimeKind.Unspecified).AddTicks(4049), 3, 3, 6, 71204L, "Andre_Pacoch22" },
                    { 24L, new DateTime(1981, 12, 15, 1, 48, 9, 700, DateTimeKind.Unspecified).AddTicks(1476), 8, "Aaliyah_Rempel56@hotmail.com", "Jazmyn", "/jrtrabdizjkfixbguoeqciqhzyieer.jpg", false, true, "Robel", "2n49a9328n2le4cwq59q76ocg10gp3pz", new DateTime(2017, 3, 21, 18, 44, 43, 672, DateTimeKind.Unspecified).AddTicks(624), 1, 1, 6, 7810L, "Bobbie3023" },
                    { 25L, new DateTime(1985, 11, 24, 0, 20, 19, 826, DateTimeKind.Unspecified).AddTicks(4962), 4, "Tobin17@yahoo.com", "Mozelle", "/xlmxzuuggqieyblcvqvrompmwetzem.jpg", false, true, "Haag", "jnvj2oveqbadjje5li2tqa8jmgvz0t0t", new DateTime(2017, 9, 6, 11, 53, 7, 46, DateTimeKind.Unspecified).AddTicks(8574), 3, 0, 4, 38713L, "Juliet_McClu24" },
                    { 26L, new DateTime(1993, 11, 24, 21, 15, 2, 804, DateTimeKind.Unspecified).AddTicks(8752), 5, "Armand.Rempel@gmail.com", "Grayson", "/xitgliyqvwkyhlhulswfnhpiktelnv.jpg", false, true, "Torp", "wa9rxq0u8xgdxc0y6wv4ldvcqlqfto5h", new DateTime(2021, 12, 7, 1, 26, 28, 368, DateTimeKind.Unspecified).AddTicks(8794), 0, 3, -10, 54533L, "Jess9125" },
                    { 27L, new DateTime(1988, 10, 31, 8, 24, 19, 549, DateTimeKind.Unspecified).AddTicks(3428), 5, "Emilia.Kling@gmail.com", "Kristian", "/okfolxaizpaouzgxkxhqjijaxypofn.jpg", false, true, "Konopelski", "3d5wxosenri7j6jw5rwgue5wv726nhag", new DateTime(2016, 12, 2, 17, 8, 16, 257, DateTimeKind.Unspecified).AddTicks(5212), 1, 1, 4, 87203L, "Thad3726" },
                    { 28L, new DateTime(1980, 6, 15, 22, 55, 6, 657, DateTimeKind.Unspecified).AddTicks(6478), 43, "Javon_Ziemann68@gmail.com", "Wayne", "/uqsfgasqptelbcbswmhriiwdpuslxs.jpg", false, true, "Funk", "nofrburg6udyi72222qflij5dfrklgaa", new DateTime(2023, 3, 31, 9, 0, 15, 128, DateTimeKind.Unspecified).AddTicks(3258), 3, 0, 0, 30201L, "Kariane7927" },
                    { 29L, new DateTime(1999, 3, 13, 16, 23, 36, 572, DateTimeKind.Unspecified).AddTicks(126), 0, "Arely_Lehner68@hotmail.com", "Herta", "/lcddhkwcfwsocfpcobtgomefcvaqcm.jpg", false, false, "Gutkowski", "2rnlaszcqww3qklv858ligye5yxx1fd9", new DateTime(2016, 10, 24, 22, 7, 15, 266, DateTimeKind.Unspecified).AddTicks(6653), 2, 3, 12, 49377L, "Haylie_Hane28" },
                    { 30L, new DateTime(1990, 2, 22, 7, 30, 2, 825, DateTimeKind.Unspecified).AddTicks(3845), 6, "Linnie_Friesen@yahoo.com", "Dagmar", "/kmzpugliwbhinqcauqytflmhecbsfi.jpg", false, true, "Hahn", "astjvjq65n1mx2wzbpcqs0aumy0ogp7q", new DateTime(2018, 1, 22, 22, 25, 25, 861, DateTimeKind.Unspecified).AddTicks(221), 2, 2, 0, 99608L, "Rosetta_Herm29" },
                    { 31L, new DateTime(1992, 7, 5, 16, 55, 47, 144, DateTimeKind.Unspecified).AddTicks(6842), 56, "Gayle.Cronin36@yahoo.com", "Lexi", "/mnhmzxxnbtllinkiknixumeoaeamoh.jpg", false, true, "Kohler", "axvdnzg0i3v17v0td324zngfl0crhtwf", new DateTime(2022, 8, 8, 10, 32, 47, 121, DateTimeKind.Unspecified).AddTicks(9560), 3, 1, 1, 95248L, "Earnestine.P30" },
                    { 32L, new DateTime(1989, 6, 11, 1, 21, 54, 551, DateTimeKind.Unspecified).AddTicks(7804), 26, "Clementina.Sanford45@yahoo.com", "Gerhard", "/iqmluqqrnremcllmflgrgpqfkvtbgh.jpg", true, true, "Adams", "1z0ift2568r6ub1jotv1ycnq7q080xvl", new DateTime(2019, 3, 23, 1, 51, 46, 57, DateTimeKind.Unspecified).AddTicks(2950), 1, 2, -8, 57424L, "Daryl.Bailey31" },
                    { 33L, new DateTime(1989, 6, 10, 17, 32, 33, 414, DateTimeKind.Unspecified).AddTicks(6334), 41, "Charlene93@gmail.com", "Anibal", "/efirihhruvdgietprwccugqxcqvdzr.jpg", false, true, "Gaylord", "26syf9xyu59btlx0orc5nbq25ykelph6", new DateTime(2021, 1, 29, 9, 38, 34, 960, DateTimeKind.Unspecified).AddTicks(5936), 0, 3, 12, 38702L, "Ahmad7432" },
                    { 34L, new DateTime(1985, 9, 18, 12, 7, 8, 669, DateTimeKind.Unspecified).AddTicks(692), 7, "Wilford.Bernier77@gmail.com", "Mellie", "/watlsvmrnjercqsvyohawmyiufrool.jpg", false, true, "Zemlak", "iqeeu30jqk9s5cu9rtp60ho1wd2emh4x", new DateTime(2022, 5, 13, 23, 0, 37, 125, DateTimeKind.Unspecified).AddTicks(5594), 0, 3, -2, 67055L, "Uriah.Sipes33" },
                    { 35L, new DateTime(1984, 8, 23, 0, 30, 52, 491, DateTimeKind.Unspecified).AddTicks(9846), 26, "Jerrold_Lehner@yahoo.com", "Heath", "/wjkabjnmapxglirbnkzcbcipryhvam.jpg", false, false, "Sporer", "w3092qnsdw6al8il9fe923jetr1td32n", new DateTime(2019, 1, 31, 2, 10, 18, 315, DateTimeKind.Unspecified).AddTicks(5016), 2, 2, 8, 18771L, "Merle3334" },
                    { 36L, new DateTime(1986, 1, 3, 18, 49, 34, 512, DateTimeKind.Unspecified).AddTicks(6), 7, "Alvera.Prosacco76@gmail.com", "Michaela", "/kvoplirwlgwnwboskbelwjalmcgysi.jpg", false, true, "Beatty", "e67o4v8lqx9jas8evgkenmp0w1s34d2r", new DateTime(2019, 5, 30, 13, 11, 41, 762, DateTimeKind.Unspecified).AddTicks(4542), 0, 3, 4, 18001L, "Armando_Veum35" },
                    { 37L, new DateTime(1984, 4, 10, 16, 56, 4, 423, DateTimeKind.Unspecified).AddTicks(4479), 8, "Dangelo79@gmail.com", "Otha", "/jirtmfucbdmjvmleyodsoxywhlupyo.jpg", false, true, "Harris", "v15aesf362etlbayepvwbnyi8hdsg1e6", new DateTime(2021, 10, 18, 18, 29, 55, 896, DateTimeKind.Unspecified).AddTicks(1462), 2, 1, -2, 56163L, "Dena736" },
                    { 38L, new DateTime(1987, 7, 10, 12, 45, 18, 739, DateTimeKind.Unspecified).AddTicks(5295), 41, "Eva71@yahoo.com", "Reyes", "/bffcrbxlqqdrfrbbwtvpgdmhxfnesf.jpg", false, true, "Hudson", "40bg2b1bji66469d227lok7igxpy7gjq", new DateTime(2016, 3, 5, 4, 9, 6, 407, DateTimeKind.Unspecified).AddTicks(7564), 1, 2, -9, 76635L, "Amie.Greenfe37" },
                    { 39L, new DateTime(1996, 9, 28, 0, 46, 10, 761, DateTimeKind.Unspecified).AddTicks(2751), 12, "Adan44@gmail.com", "Kendrick", "/zdoovuadpccczmmsrdahlmodjwckyk.jpg", false, false, "Emmerich", "ypa2rkuzbkrg5yg4bxlamvhuzhkf6xpm", new DateTime(2022, 8, 15, 9, 38, 26, 248, DateTimeKind.Unspecified).AddTicks(6385), 0, 0, -2, 91228L, "Enid038" },
                    { 40L, new DateTime(1986, 5, 3, 0, 9, 9, 628, DateTimeKind.Unspecified).AddTicks(9643), 4, "Dejuan78@hotmail.com", "Mathilde", "/qubflcgalujwdgyvbikgskybaizeyt.jpg", false, true, "Shields", "xejtjf26ctgvfvgmeqetmx4x38t17433", new DateTime(2021, 10, 14, 5, 28, 58, 83, DateTimeKind.Unspecified).AddTicks(4830), 2, 3, 12, 31229L, "Jaqueline.Le39" }
                });

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Instructions", "LevelId", "Title" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 1, 20, 19, 33, 46, 582, DateTimeKind.Unspecified).AddTicks(3100), 19L, "Perspiciatis cum et et laudantium.", 1, "We need to input the online SCSI firewall!" },
                    { 2L, new DateTime(2022, 7, 21, 11, 10, 23, 148, DateTimeKind.Unspecified).AddTicks(2059), 17L, "quis", 2, "Use the open-source SMS driver, then you can input" },
                    { 3L, new DateTime(2023, 1, 23, 14, 10, 44, 48, DateTimeKind.Unspecified).AddTicks(1578), 34L, "Aut rerum consectetur veniam distinctio officiis praesentium.\nAperiam quis qui animi omnis.\nMolestiae laboriosam exercitationem similique amet dolores quibusdam aspernatur consequatur quia.\nSuscipit consequuntur eos laborum facilis culpa.", 1, "If we back up the application, we can get to the G" },
                    { 4L, new DateTime(2021, 12, 31, 6, 30, 1, 454, DateTimeKind.Unspecified).AddTicks(6594), 20L, "Suscipit quia modi nobis ad eos voluptatum est.", 2, "Use the haptic JBOD transmitter, then you can hack" },
                    { 5L, new DateTime(2022, 12, 19, 5, 15, 43, 313, DateTimeKind.Unspecified).AddTicks(6459), 33L, "Voluptatem possimus iure impedit enim provident incidunt molestiae earum.", 2, "I'll transmit the wireless USB driver, that should" },
                    { 6L, new DateTime(2023, 8, 15, 15, 48, 40, 745, DateTimeKind.Unspecified).AddTicks(9916), 28L, "Distinctio rerum voluptatem aut iure nesciunt aut eos voluptatem molestias. Molestias reprehenderit tenetur hic. Esse repudiandae voluptatem quae impedit sed voluptates ratione minus in.", 3, "If we parse the feed, we can get to the SSL feed t" },
                    { 7L, new DateTime(2022, 6, 26, 3, 21, 29, 366, DateTimeKind.Unspecified).AddTicks(4336), 40L, "Molestiae quis nihil similique autem nemo numquam. Et ut ratione vel. Aperiam harum perferendis ad consequuntur.", 1, "We need to calculate the auxiliary HTTP applicatio" },
                    { 8L, new DateTime(2022, 1, 25, 7, 50, 18, 386, DateTimeKind.Unspecified).AddTicks(9186), 26L, "et", 2, "I'll index the back-end RSS driver, that should dr" },
                    { 9L, new DateTime(2019, 4, 26, 13, 21, 9, 235, DateTimeKind.Unspecified).AddTicks(1315), 3L, "Quas maxime esse et dolores accusamus doloremque in magnam quos.\nSaepe incidunt modi recusandae saepe ut et.\nAccusamus sed maiores doloremque aut et aut praesentium quae.\nQui magni eum autem architecto accusamus dolore inventore expedita.\nEos velit optio asperiores dolores voluptas amet voluptatum deserunt.", 4, "The SAS pixel is down, hack the mobile pixel so we" },
                    { 10L, new DateTime(2017, 5, 27, 7, 23, 25, 669, DateTimeKind.Unspecified).AddTicks(8634), 6L, "Doloremque velit maiores unde at commodi.", 3, "You can't synthesize the firewall without transmit" },
                    { 11L, new DateTime(2021, 11, 9, 17, 54, 55, 988, DateTimeKind.Unspecified).AddTicks(4478), 40L, "Doloribus eveniet non aut fuga et.", 4, "Try to calculate the SMTP bus, maybe it will calcu" },
                    { 12L, new DateTime(2023, 4, 20, 22, 19, 47, 542, DateTimeKind.Unspecified).AddTicks(2186), 40L, "Est molestiae voluptatem eos assumenda et libero voluptatem et.\nAb maxime fuga nemo ad.\nNon illum ut iste ea perspiciatis.", 3, "The ADP array is down, generate the bluetooth arra" },
                    { 13L, new DateTime(2020, 12, 2, 16, 42, 19, 452, DateTimeKind.Unspecified).AddTicks(5224), 5L, "iure", 4, "The SMS driver is down, hack the optical driver so" },
                    { 14L, new DateTime(2021, 12, 26, 11, 8, 3, 410, DateTimeKind.Unspecified).AddTicks(8065), 30L, "Nostrum sit quia consequatur eos dolorem quo vel libero ut.\nIusto error quia ab.\nAutem quam et quia eum ea molestias eum dolore consequuntur.\nEligendi rerum nisi aspernatur et commodi libero cupiditate.\nMollitia molestias eaque quia dignissimos voluptas porro voluptas.", 3, "Try to copy the IB program, maybe it will copy the" },
                    { 15L, new DateTime(2021, 4, 3, 21, 51, 14, 479, DateTimeKind.Unspecified).AddTicks(927), 5L, "Recusandae molestias id.", 3, "Use the wireless SDD circuit, then you can navigat" },
                    { 16L, new DateTime(2020, 1, 10, 14, 48, 42, 302, DateTimeKind.Unspecified).AddTicks(4769), 13L, "Corporis veniam vel et voluptas. Rerum quod facilis est nihil qui et rerum et non. Rerum culpa deserunt adipisci vero iure corporis. Quam odit reprehenderit. Atque cupiditate aut minus minus reprehenderit eos. Ipsam et aut nostrum assumenda explicabo rem.", 1, "If we bypass the port, we can get to the USB port " },
                    { 17L, new DateTime(2021, 3, 25, 10, 31, 6, 539, DateTimeKind.Unspecified).AddTicks(5670), 18L, "ratione", 4, "calculating the panel won't do anything, we need t" },
                    { 18L, new DateTime(2022, 12, 20, 6, 50, 3, 469, DateTimeKind.Unspecified).AddTicks(4350), 17L, "et", 4, "If we hack the program, we can get to the PCI prog" },
                    { 19L, new DateTime(2022, 6, 2, 7, 46, 43, 730, DateTimeKind.Unspecified).AddTicks(3017), 20L, "Sint doloribus sit aut ipsam maiores voluptatum voluptas in.", 3, "compressing the sensor won't do anything, we need " },
                    { 20L, new DateTime(2021, 5, 14, 14, 4, 29, 778, DateTimeKind.Unspecified).AddTicks(7264), 38L, "perspiciatis", 2, "I'll override the redundant AGP card, that should " },
                    { 21L, new DateTime(2021, 9, 26, 0, 45, 55, 368, DateTimeKind.Unspecified).AddTicks(6693), 23L, "Quisquam cum aut sunt sit suscipit similique voluptatem maxime qui. Quia aut exercitationem est provident enim rerum maiores. Voluptatem aut fugiat sunt exercitationem. Corrupti vitae ea eos enim similique. Fuga et enim ad laboriosam quaerat ut et. Et sed dolorum sunt quisquam incidunt et explicabo et.", 4, "Use the open-source EXE array, then you can connec" },
                    { 22L, new DateTime(2023, 4, 15, 17, 29, 22, 904, DateTimeKind.Unspecified).AddTicks(350), 2L, "Id consequuntur nesciunt laudantium quaerat et suscipit quaerat recusandae nobis. Id corrupti vitae. Hic quisquam cumque aliquam qui. Quasi porro quisquam dicta voluptatibus.", 2, "The IB transmitter is down, quantify the optical t" },
                    { 23L, new DateTime(2023, 7, 1, 16, 16, 46, 194, DateTimeKind.Unspecified).AddTicks(160), 35L, "Odit laudantium quibusdam nostrum fugiat dolores.", 4, "Use the back-end SMTP bus, then you can override t" },
                    { 24L, new DateTime(2021, 5, 22, 1, 12, 28, 497, DateTimeKind.Unspecified).AddTicks(9754), 20L, "Sed voluptate iusto vel ad ea voluptates iure.\nAccusantium saepe iusto dolorum necessitatibus necessitatibus.", 3, "We need to reboot the haptic USB protocol!" },
                    { 25L, new DateTime(2023, 1, 14, 20, 14, 7, 873, DateTimeKind.Unspecified).AddTicks(7353), 11L, "eum", 4, "You can't reboot the bus without parsing the redun" },
                    { 26L, new DateTime(2021, 2, 5, 10, 47, 46, 10, DateTimeKind.Unspecified).AddTicks(8098), 18L, "Amet qui vel dignissimos maxime quo recusandae provident. Accusamus expedita delectus praesentium nam dolores accusamus. Mollitia iste unde voluptatem.", 1, "You can't calculate the program without hacking th" },
                    { 27L, new DateTime(2021, 3, 27, 0, 30, 0, 592, DateTimeKind.Unspecified).AddTicks(7547), 19L, "necessitatibus", 4, "I'll index the open-source JSON card, that should " },
                    { 28L, new DateTime(2019, 10, 21, 18, 57, 47, 263, DateTimeKind.Unspecified).AddTicks(8457), 23L, "Modi blanditiis aut sunt qui ut.\nVeritatis dignissimos deleniti.\nQuod ut aliquid voluptatum dolorem error.", 1, "If we parse the driver, we can get to the PNG driv" },
                    { 29L, new DateTime(2023, 1, 8, 22, 30, 14, 450, DateTimeKind.Unspecified).AddTicks(1220), 17L, "numquam", 3, "The PNG pixel is down, bypass the haptic pixel so " },
                    { 30L, new DateTime(2021, 5, 1, 4, 6, 52, 449, DateTimeKind.Unspecified).AddTicks(4301), 2L, "ut", 2, "The GB firewall is down, reboot the 1080p firewall" },
                    { 31L, new DateTime(2022, 6, 10, 4, 52, 25, 863, DateTimeKind.Unspecified).AddTicks(6812), 19L, "Eum ea sequi voluptas praesentium hic.\nVoluptatum voluptatem dolor consequatur distinctio et.\nAutem officia ut unde delectus repudiandae eum animi consectetur omnis.", 2, "You can't index the transmitter without compressin" },
                    { 32L, new DateTime(2023, 6, 3, 12, 39, 42, 244, DateTimeKind.Unspecified).AddTicks(6268), 13L, "quia", 4, "We need to back up the virtual SQL feed!" },
                    { 33L, new DateTime(2021, 9, 27, 11, 45, 38, 921, DateTimeKind.Unspecified).AddTicks(8978), 9L, "Sunt et est aliquam aut unde blanditiis.\nRepellendus dolorem autem.\nEos nihil veniam quia ipsa.\nOdit fuga illum nobis voluptatum deserunt in.", 2, "Try to program the COM alarm, maybe it will progra" },
                    { 34L, new DateTime(2023, 3, 2, 22, 30, 18, 362, DateTimeKind.Unspecified).AddTicks(5858), 7L, "Culpa voluptatem est sequi in sit quam.", 3, "The XSS matrix is down, transmit the cross-platfor" },
                    { 35L, new DateTime(2022, 10, 9, 19, 12, 52, 721, DateTimeKind.Unspecified).AddTicks(3265), 34L, "Quisquam voluptate sequi magni soluta soluta qui voluptatem reprehenderit quo.", 1, "We need to navigate the digital RAM pixel!" },
                    { 36L, new DateTime(2022, 4, 5, 15, 14, 43, 986, DateTimeKind.Unspecified).AddTicks(7205), 4L, "Voluptatem quia ut ut doloribus ut et ratione suscipit. Est sunt veritatis. Quis ducimus laboriosam.", 1, "Try to input the JBOD driver, maybe it will input " },
                    { 37L, new DateTime(2020, 7, 21, 17, 12, 23, 859, DateTimeKind.Unspecified).AddTicks(3490), 38L, "iusto", 3, "The COM array is down, program the virtual array s" },
                    { 38L, new DateTime(2017, 8, 20, 17, 34, 17, 902, DateTimeKind.Unspecified).AddTicks(7640), 6L, "Omnis et et eum eum tempora nostrum a iure voluptatem. Expedita itaque quos quia soluta repellat quas perspiciatis. Sed consequatur numquam maxime. Enim quaerat ratione rerum sed quis. Ea dolores dolor eum vitae dolores vitae.", 3, "Use the solid state IB transmitter, then you can h" },
                    { 39L, new DateTime(2019, 10, 19, 14, 9, 28, 931, DateTimeKind.Unspecified).AddTicks(2740), 13L, "Expedita labore omnis omnis delectus doloremque possimus esse fugit.\nQui quasi pariatur et sed aliquam aut quo temporibus animi.\nNihil esse similique molestiae voluptas molestiae eum.\nImpedit et in nihil nihil et.", 4, "If we navigate the hard drive, we can get to the P" },
                    { 40L, new DateTime(2021, 2, 14, 2, 2, 11, 909, DateTimeKind.Unspecified).AddTicks(9240), 27L, "Adipisci sint quibusdam.", 4, "bypassing the matrix won't do anything, we need to" },
                    { 41L, new DateTime(2019, 4, 26, 4, 39, 42, 589, DateTimeKind.Unspecified).AddTicks(2548), 23L, "Non non ea ab maxime est ratione. Et voluptate iusto ut. Minima nihil qui quaerat ratione aut.", 3, "I'll parse the virtual SCSI transmitter, that shou" },
                    { 42L, new DateTime(2022, 3, 12, 15, 54, 48, 818, DateTimeKind.Unspecified).AddTicks(4769), 23L, "Eos provident laborum placeat reprehenderit voluptatem.", 1, "indexing the hard drive won't do anything, we need" }
                });

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Instructions", "LevelId", "Title" },
                values: new object[,]
                {
                    { 43L, new DateTime(2023, 7, 9, 13, 35, 44, 760, DateTimeKind.Unspecified).AddTicks(6183), 23L, "Et dolor error quo doloremque harum explicabo.\nSed qui facere corporis sunt omnis voluptas corporis perspiciatis ut.\nEst rerum ad necessitatibus voluptatem.\nLaboriosam cupiditate dolorem eaque perspiciatis et.", 4, "You can't copy the port without parsing the wirele" },
                    { 44L, new DateTime(2021, 11, 6, 4, 25, 40, 884, DateTimeKind.Unspecified).AddTicks(4851), 21L, "Aut ex quis.\nEnim nulla eligendi est quam iusto.\nCumque harum saepe velit consequatur eligendi odit ut vero.\nDolorem sit vel sed nemo modi consequatur.", 2, "You can't parse the firewall without backing up th" },
                    { 45L, new DateTime(2021, 6, 1, 14, 39, 36, 794, DateTimeKind.Unspecified).AddTicks(5958), 35L, "Ut qui non dolores sunt enim fugiat quisquam cupiditate distinctio. Officiis reprehenderit quidem qui quis quia asperiores quaerat sapiente. Quia quia voluptatem magni et enim iure. Dolorum ut minus.", 2, "If we bypass the transmitter, we can get to the AI" },
                    { 46L, new DateTime(2023, 1, 4, 21, 41, 15, 217, DateTimeKind.Unspecified).AddTicks(2439), 7L, "Officia iusto rerum placeat temporibus corrupti et aut cumque.\nCommodi voluptatem laborum amet consequatur.\nA ducimus est ut reprehenderit.\nSit odit consequuntur.\nTempore magni nihil velit quos sed deleniti aliquid.\nEligendi nesciunt error mollitia et consequatur.", 1, "compressing the bus won't do anything, we need to " },
                    { 47L, new DateTime(2022, 6, 28, 11, 48, 27, 257, DateTimeKind.Unspecified).AddTicks(3003), 10L, "Earum laudantium molestias quam sed fuga explicabo vel corrupti in. Quibusdam et ut voluptatem facere. Magni qui pariatur reiciendis eveniet.", 1, "I'll parse the back-end XML protocol, that should " },
                    { 48L, new DateTime(2020, 12, 22, 15, 32, 12, 413, DateTimeKind.Unspecified).AddTicks(4204), 15L, "Sed rerum molestiae ad.\nItaque quas vel sint voluptas maxime assumenda.\nHic debitis tempore minus et quos quia repudiandae.\nUt laudantium ut.", 4, "We need to synthesize the haptic THX bandwidth!" },
                    { 49L, new DateTime(2023, 1, 6, 18, 20, 17, 710, DateTimeKind.Unspecified).AddTicks(2967), 34L, "vel", 1, "Use the wireless AI card, then you can back up the" },
                    { 50L, new DateTime(2022, 6, 2, 14, 54, 10, 590, DateTimeKind.Unspecified).AddTicks(3614), 34L, "Cum in ex nulla doloremque nostrum nemo quos.\nLaudantium corporis ut hic sapiente dolore sed architecto.\nIusto expedita rerum et pariatur optio ex aperiam dolorem placeat.\nAssumenda nesciunt nostrum pariatur corporis et doloribus quae.", 3, "You can't copy the sensor without navigating the d" },
                    { 51L, new DateTime(2021, 12, 21, 8, 7, 43, 980, DateTimeKind.Unspecified).AddTicks(490), 38L, "Voluptatem iure quia labore pariatur id quia qui expedita quos.\nLaudantium natus dolorem rerum nemo perferendis quam est explicabo aliquam.\nIncidunt et qui.", 2, "The XML monitor is down, compress the 1080p monito" },
                    { 52L, new DateTime(2023, 3, 13, 23, 17, 12, 382, DateTimeKind.Unspecified).AddTicks(7542), 16L, "Fugiat illo alias error eligendi voluptatem.", 2, "You can't transmit the system without connecting t" },
                    { 53L, new DateTime(2018, 9, 14, 3, 56, 32, 538, DateTimeKind.Unspecified).AddTicks(9685), 29L, "Distinctio adipisci sequi vitae nulla. Corporis in labore nobis vel laudantium accusantium minus nihil quas. Sapiente quam vitae ea asperiores cum. Et illum temporibus placeat itaque et aliquam nostrum tempore ratione. Quia modi facere quia. Quaerat nostrum voluptatem.", 4, "Use the wireless GB protocol, then you can synthes" },
                    { 54L, new DateTime(2021, 4, 22, 5, 7, 37, 892, DateTimeKind.Unspecified).AddTicks(8009), 33L, "Necessitatibus libero sint ad culpa accusantium sed omnis praesentium.", 2, "Use the open-source ADP pixel, then you can input " },
                    { 55L, new DateTime(2023, 6, 29, 21, 1, 11, 279, DateTimeKind.Unspecified).AddTicks(4988), 31L, "Aut ut ut voluptates tempora ut commodi quos id. Dolores rerum eveniet quaerat dolores eligendi hic ipsum sit. Impedit fugiat numquam ad rerum atque tempore vero ipsa ab. Consequatur vitae hic omnis cumque perspiciatis consequatur ex omnis.", 1, "overriding the port won't do anything, we need to " },
                    { 56L, new DateTime(2022, 5, 14, 17, 14, 47, 513, DateTimeKind.Unspecified).AddTicks(1584), 26L, "Sunt ut fugit minima facere optio accusantium.\nDeserunt molestias ducimus omnis voluptatibus quos aut rerum.\nQuibusdam ratione qui illum quam modi.", 4, "I'll bypass the digital XSS pixel, that should pix" },
                    { 57L, new DateTime(2018, 9, 21, 0, 15, 8, 344, DateTimeKind.Unspecified).AddTicks(4583), 15L, "Minus quo dolores rerum pariatur nisi.\nDolorem dolore laborum corporis reiciendis dignissimos in.\nEos enim vel placeat minus voluptatem consequuntur totam corporis et.", 2, "Try to generate the SMTP application, maybe it wil" },
                    { 58L, new DateTime(2022, 5, 2, 21, 51, 28, 108, DateTimeKind.Unspecified).AddTicks(7228), 40L, "aut", 4, "Use the solid state SMS alarm, then you can bypass" },
                    { 59L, new DateTime(2022, 1, 7, 11, 56, 9, 157, DateTimeKind.Unspecified).AddTicks(1537), 8L, "Veniam rerum repudiandae sint eos delectus qui veniam id consequatur.", 2, "We need to synthesize the open-source CSS driver!" },
                    { 60L, new DateTime(2021, 9, 18, 2, 45, 40, 217, DateTimeKind.Unspecified).AddTicks(5811), 22L, "Quia fugiat voluptatem nihil vitae molestias.", 4, "I'll connect the bluetooth RSS feed, that should f" },
                    { 61L, new DateTime(2023, 7, 3, 19, 35, 39, 55, DateTimeKind.Unspecified).AddTicks(8203), 2L, "Accusamus beatae omnis totam maxime autem in et et.\nEt ducimus ea quia a excepturi a aut.\nExplicabo illo blanditiis illo eum qui itaque natus modi.", 4, "You can't generate the protocol without indexing t" },
                    { 62L, new DateTime(2021, 5, 11, 9, 43, 37, 746, DateTimeKind.Unspecified).AddTicks(1893), 13L, "Voluptatem veniam ut autem enim. Architecto nihil ut rerum aut nihil eos aut. Esse voluptatem reprehenderit perferendis aut ut dolor voluptas.", 4, "If we quantify the program, we can get to the FTP " },
                    { 63L, new DateTime(2022, 12, 15, 14, 52, 15, 292, DateTimeKind.Unspecified).AddTicks(5512), 26L, "Est consectetur voluptatem.\nPlaceat et eos.\nSunt quo et qui eius qui dolor numquam numquam nulla.\nSed nulla sint delectus alias.", 3, "If we bypass the circuit, we can get to the RSS ci" },
                    { 64L, new DateTime(2022, 2, 17, 9, 6, 24, 570, DateTimeKind.Unspecified).AddTicks(6300), 10L, "ut", 4, "parsing the matrix won't do anything, we need to c" },
                    { 65L, new DateTime(2017, 5, 15, 19, 46, 42, 807, DateTimeKind.Unspecified).AddTicks(536), 24L, "Suscipit iusto quas est quaerat molestiae nostrum tempora aliquam tempora.\nRem dolorem ut voluptas voluptate.\nQuo magnam eligendi.\nIpsum tenetur praesentium earum.", 2, "Try to connect the XSS feed, maybe it will connect" },
                    { 66L, new DateTime(2021, 1, 30, 1, 25, 39, 330, DateTimeKind.Unspecified).AddTicks(5279), 33L, "Quae aliquid quod error nesciunt.", 3, "Use the online IB panel, then you can synthesize t" },
                    { 67L, new DateTime(2023, 7, 14, 20, 9, 0, 389, DateTimeKind.Unspecified).AddTicks(9266), 39L, "Autem est neque deleniti quae.\nCum vitae ut id voluptate est aut enim.\nAlias tenetur commodi cumque explicabo est.\nCommodi blanditiis tenetur sapiente dolores atque tempore.\nAut modi officiis neque consequatur.", 1, "You can't transmit the application without quantif" },
                    { 68L, new DateTime(2022, 6, 14, 18, 12, 32, 670, DateTimeKind.Unspecified).AddTicks(7372), 19L, "Est dolores id tempore vel.", 4, "If we override the circuit, we can get to the HDD " },
                    { 69L, new DateTime(2023, 3, 4, 21, 24, 20, 610, DateTimeKind.Unspecified).AddTicks(4181), 7L, "Aut quibusdam amet at facilis rerum.\nUt veritatis commodi aspernatur doloremque quia quidem.", 1, "Use the cross-platform AGP firewall, then you can " },
                    { 70L, new DateTime(2023, 5, 27, 8, 43, 39, 443, DateTimeKind.Unspecified).AddTicks(5284), 37L, "Natus aut officia qui consequatur.", 4, "Try to navigate the THX system, maybe it will navi" }
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
                    { 1L, 151.37m, new DateTime(2023, 5, 2, 17, 13, 6, 220, DateTimeKind.Unspecified).AddTicks(6915), false, "2umhqjy0f1gdzhf2", new DateTime(2023, 1, 29, 8, 12, 2, 649, DateTimeKind.Unspecified).AddTicks(4662), new DateTime(2019, 6, 30, 11, 55, 46, 804, DateTimeKind.Unspecified).AddTicks(6644), 2, new DateTime(2023, 2, 7, 6, 57, 35, 316, DateTimeKind.Unspecified).AddTicks(2970), 27L },
                    { 2L, 136.02m, new DateTime(2024, 1, 27, 11, 11, 36, 828, DateTimeKind.Unspecified).AddTicks(9357), true, "6iotvwd2kcauexpx", new DateTime(2023, 7, 9, 1, 49, 41, 704, DateTimeKind.Unspecified).AddTicks(5305), new DateTime(2022, 12, 15, 23, 6, 58, 296, DateTimeKind.Unspecified).AddTicks(8669), 1, new DateTime(2023, 1, 2, 1, 57, 41, 749, DateTimeKind.Unspecified).AddTicks(8948), 20L },
                    { 3L, 151.37m, new DateTime(2023, 5, 18, 3, 51, 5, 467, DateTimeKind.Unspecified).AddTicks(4405), false, "uo2s583680b8v54j", new DateTime(2023, 3, 5, 22, 58, 32, 701, DateTimeKind.Unspecified).AddTicks(3640), new DateTime(2022, 5, 6, 10, 42, 7, 646, DateTimeKind.Unspecified).AddTicks(9616), 2, new DateTime(2023, 2, 8, 8, 4, 42, 722, DateTimeKind.Unspecified).AddTicks(5622), 27L },
                    { 4L, 136.02m, new DateTime(2023, 9, 29, 18, 0, 28, 249, DateTimeKind.Unspecified).AddTicks(2000), true, "nfd23s23e9y7ukxb", new DateTime(2023, 2, 15, 5, 56, 49, 786, DateTimeKind.Unspecified).AddTicks(5144), new DateTime(2022, 10, 14, 23, 4, 12, 682, DateTimeKind.Unspecified).AddTicks(4498), 1, new DateTime(2023, 3, 16, 17, 57, 11, 191, DateTimeKind.Unspecified).AddTicks(6539), 10L },
                    { 5L, 136.02m, new DateTime(2023, 4, 11, 18, 42, 49, 895, DateTimeKind.Unspecified).AddTicks(6723), true, "28569h790c5pv13g", new DateTime(2023, 2, 4, 22, 8, 12, 342, DateTimeKind.Unspecified).AddTicks(973), new DateTime(2022, 4, 11, 18, 4, 29, 390, DateTimeKind.Unspecified).AddTicks(9480), 1, new DateTime(2023, 7, 13, 0, 30, 5, 537, DateTimeKind.Unspecified).AddTicks(842), 38L }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "Cost", "EndDate", "IsActive", "PaymentSubscriptionId", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate", "UserId" },
                values: new object[,]
                {
                    { 6L, 91.86m, new DateTime(2021, 4, 16, 23, 38, 36, 428, DateTimeKind.Unspecified).AddTicks(333), true, "fhe3z935d1zvmvux", new DateTime(2020, 11, 12, 6, 50, 25, 181, DateTimeKind.Unspecified).AddTicks(5805), new DateTime(2018, 3, 14, 23, 5, 39, 308, DateTimeKind.Unspecified).AddTicks(1050), 3, new DateTime(2019, 5, 23, 10, 55, 52, 162, DateTimeKind.Unspecified).AddTicks(1970), 3L },
                    { 7L, 136.02m, new DateTime(2023, 6, 17, 10, 32, 26, 912, DateTimeKind.Unspecified).AddTicks(2490), true, "04gfoh55j2qr239q", new DateTime(2023, 5, 24, 20, 25, 8, 781, DateTimeKind.Unspecified).AddTicks(4160), new DateTime(2022, 4, 8, 16, 41, 21, 761, DateTimeKind.Unspecified).AddTicks(1987), 1, new DateTime(2022, 7, 29, 18, 34, 34, 314, DateTimeKind.Unspecified).AddTicks(9157), 10L },
                    { 8L, 91.86m, new DateTime(2022, 7, 1, 4, 51, 2, 68, DateTimeKind.Unspecified).AddTicks(8129), false, "cvjhq7n8273vtohw", new DateTime(2022, 5, 9, 22, 52, 6, 726, DateTimeKind.Unspecified).AddTicks(5089), new DateTime(2020, 9, 27, 1, 48, 37, 948, DateTimeKind.Unspecified).AddTicks(3354), 3, new DateTime(2020, 12, 25, 13, 14, 26, 88, DateTimeKind.Unspecified).AddTicks(2079), 36L },
                    { 9L, 151.37m, new DateTime(2024, 8, 1, 11, 41, 19, 970, DateTimeKind.Unspecified).AddTicks(4398), false, "ff9fvm4sae2sxofc", new DateTime(2023, 8, 2, 10, 41, 37, 332, DateTimeKind.Unspecified).AddTicks(7392), new DateTime(2023, 3, 11, 16, 8, 26, 835, DateTimeKind.Unspecified).AddTicks(8746), 2, new DateTime(2023, 5, 16, 22, 28, 49, 635, DateTimeKind.Unspecified).AddTicks(259), 17L },
                    { 10L, 136.02m, new DateTime(2022, 7, 30, 16, 16, 2, 525, DateTimeKind.Unspecified).AddTicks(2993), true, "igx8w9w90k1ay8cf", new DateTime(2021, 12, 12, 20, 41, 40, 955, DateTimeKind.Unspecified).AddTicks(498), new DateTime(2020, 10, 10, 16, 19, 19, 790, DateTimeKind.Unspecified).AddTicks(7514), 1, new DateTime(2022, 10, 6, 4, 56, 16, 925, DateTimeKind.Unspecified).AddTicks(7318), 3L },
                    { 11L, 91.86m, new DateTime(2023, 10, 28, 21, 9, 43, 623, DateTimeKind.Unspecified).AddTicks(2283), true, "dy4mdzy1ipwfpvv0", new DateTime(2023, 3, 10, 15, 13, 48, 301, DateTimeKind.Unspecified).AddTicks(9153), new DateTime(2022, 12, 6, 7, 14, 49, 291, DateTimeKind.Unspecified).AddTicks(2071), 3, new DateTime(2023, 1, 12, 16, 55, 43, 766, DateTimeKind.Unspecified).AddTicks(8157), 20L },
                    { 12L, 136.02m, new DateTime(2023, 1, 7, 11, 57, 3, 237, DateTimeKind.Unspecified).AddTicks(4506), true, "69sotjwthpvx4aw1", new DateTime(2022, 9, 6, 17, 14, 59, 328, DateTimeKind.Unspecified).AddTicks(5583), new DateTime(2022, 5, 17, 0, 41, 29, 439, DateTimeKind.Unspecified).AddTicks(8588), 1, new DateTime(2023, 7, 16, 16, 54, 15, 718, DateTimeKind.Unspecified).AddTicks(1407), 25L },
                    { 13L, 136.02m, new DateTime(2023, 9, 1, 1, 30, 56, 639, DateTimeKind.Unspecified).AddTicks(6264), true, "gjxuxll8kyg46a7z", new DateTime(2023, 8, 23, 3, 56, 58, 326, DateTimeKind.Unspecified).AddTicks(2044), new DateTime(2023, 5, 20, 4, 14, 41, 940, DateTimeKind.Unspecified).AddTicks(8218), 1, new DateTime(2023, 8, 17, 1, 21, 54, 477, DateTimeKind.Unspecified).AddTicks(728), 32L },
                    { 14L, 151.37m, new DateTime(2023, 1, 9, 22, 27, 50, 590, DateTimeKind.Unspecified).AddTicks(5520), true, "wprmc5u9im89l2ww", new DateTime(2022, 3, 14, 7, 35, 44, 173, DateTimeKind.Unspecified).AddTicks(318), new DateTime(2021, 11, 15, 0, 29, 17, 993, DateTimeKind.Unspecified).AddTicks(1267), 2, new DateTime(2023, 3, 28, 12, 12, 42, 5, DateTimeKind.Unspecified).AddTicks(9646), 5L },
                    { 15L, 136.02m, new DateTime(2023, 3, 15, 18, 23, 42, 998, DateTimeKind.Unspecified).AddTicks(4239), false, "stg9zq5iopx7uyvf", new DateTime(2023, 2, 23, 3, 27, 35, 828, DateTimeKind.Unspecified).AddTicks(3571), new DateTime(2022, 7, 6, 19, 54, 42, 866, DateTimeKind.Unspecified).AddTicks(8171), 1, new DateTime(2023, 7, 24, 20, 10, 11, 9, DateTimeKind.Unspecified).AddTicks(5360), 5L },
                    { 16L, 91.86m, new DateTime(2023, 9, 5, 3, 58, 53, 534, DateTimeKind.Unspecified).AddTicks(9206), true, "61vekpd4uftjpk9r", new DateTime(2023, 7, 16, 20, 6, 24, 156, DateTimeKind.Unspecified).AddTicks(5898), new DateTime(2022, 8, 18, 16, 43, 56, 764, DateTimeKind.Unspecified).AddTicks(9356), 3, null, 19L },
                    { 17L, 91.86m, new DateTime(2022, 10, 12, 20, 3, 17, 783, DateTimeKind.Unspecified).AddTicks(4252), false, "qy2m6a9vgq3xvryz", new DateTime(2022, 8, 22, 18, 39, 9, 17, DateTimeKind.Unspecified).AddTicks(840), new DateTime(2021, 12, 17, 2, 35, 28, 7, DateTimeKind.Unspecified).AddTicks(9388), 3, new DateTime(2022, 7, 15, 6, 45, 30, 757, DateTimeKind.Unspecified).AddTicks(3868), 14L },
                    { 18L, 91.86m, new DateTime(2024, 1, 24, 5, 3, 29, 890, DateTimeKind.Unspecified).AddTicks(3503), false, "xt3cbgkhzqommryk", new DateTime(2023, 8, 4, 14, 26, 22, 427, DateTimeKind.Unspecified).AddTicks(7212), new DateTime(2022, 4, 25, 1, 46, 38, 229, DateTimeKind.Unspecified).AddTicks(9199), 3, new DateTime(2022, 10, 9, 12, 59, 39, 234, DateTimeKind.Unspecified).AddTicks(9910), 7L },
                    { 19L, 151.37m, new DateTime(2023, 8, 22, 10, 48, 1, 758, DateTimeKind.Unspecified).AddTicks(5058), false, "rmkbbn0e8joc7xjz", new DateTime(2023, 7, 21, 12, 13, 4, 173, DateTimeKind.Unspecified).AddTicks(8821), new DateTime(2023, 7, 16, 6, 19, 19, 204, DateTimeKind.Unspecified).AddTicks(8295), 2, new DateTime(2023, 7, 29, 5, 42, 24, 511, DateTimeKind.Unspecified).AddTicks(9094), 7L },
                    { 20L, 136.02m, new DateTime(2019, 10, 6, 10, 6, 28, 747, DateTimeKind.Unspecified).AddTicks(7676), true, "us879r2lwdkpw85c", new DateTime(2019, 9, 8, 0, 4, 3, 258, DateTimeKind.Unspecified).AddTicks(5111), new DateTime(2019, 5, 28, 3, 4, 29, 623, DateTimeKind.Unspecified).AddTicks(6832), 1, new DateTime(2021, 12, 18, 0, 25, 28, 390, DateTimeKind.Unspecified).AddTicks(5889), 29L },
                    { 21L, 136.02m, new DateTime(2023, 9, 9, 18, 45, 11, 371, DateTimeKind.Unspecified).AddTicks(1207), false, "e3suermf9zhiet5h", new DateTime(2023, 5, 3, 20, 58, 7, 373, DateTimeKind.Unspecified).AddTicks(3661), new DateTime(2021, 12, 29, 2, 50, 25, 95, DateTimeKind.Unspecified).AddTicks(7601), 1, new DateTime(2023, 5, 22, 9, 6, 9, 815, DateTimeKind.Unspecified).AddTicks(1558), 20L },
                    { 22L, 136.02m, new DateTime(2024, 5, 13, 3, 45, 31, 210, DateTimeKind.Unspecified).AddTicks(8507), false, "gkftyah9gzs5y764", new DateTime(2023, 8, 3, 8, 28, 30, 544, DateTimeKind.Unspecified).AddTicks(3100), new DateTime(2023, 1, 24, 10, 9, 54, 792, DateTimeKind.Unspecified).AddTicks(6130), 1, new DateTime(2023, 6, 9, 15, 6, 11, 29, DateTimeKind.Unspecified).AddTicks(695), 31L },
                    { 23L, 136.02m, new DateTime(2022, 4, 19, 21, 14, 32, 973, DateTimeKind.Unspecified).AddTicks(1089), true, "4wkz5jwj0veuctgy", new DateTime(2022, 4, 14, 10, 51, 11, 39, DateTimeKind.Unspecified).AddTicks(3693), new DateTime(2021, 3, 28, 22, 58, 22, 377, DateTimeKind.Unspecified).AddTicks(880), 1, new DateTime(2023, 8, 19, 9, 37, 30, 316, DateTimeKind.Unspecified).AddTicks(5129), 21L },
                    { 24L, 136.02m, new DateTime(2021, 12, 14, 20, 33, 40, 879, DateTimeKind.Unspecified).AddTicks(3212), false, "xb17e65tmjo2pi3w", new DateTime(2021, 2, 23, 4, 26, 58, 226, DateTimeKind.Unspecified).AddTicks(4122), new DateTime(2020, 12, 9, 21, 14, 4, 562, DateTimeKind.Unspecified).AddTicks(1794), 1, new DateTime(2021, 11, 1, 8, 28, 30, 771, DateTimeKind.Unspecified).AddTicks(801), 4L },
                    { 25L, 151.37m, new DateTime(2022, 12, 19, 16, 7, 16, 472, DateTimeKind.Unspecified).AddTicks(4702), false, "ohejkiv4da2uho5t", new DateTime(2022, 11, 4, 17, 41, 48, 382, DateTimeKind.Unspecified).AddTicks(3639), new DateTime(2019, 3, 22, 7, 22, 13, 86, DateTimeKind.Unspecified).AddTicks(1953), 2, new DateTime(2021, 1, 13, 23, 50, 42, 440, DateTimeKind.Unspecified).AddTicks(8156), 30L },
                    { 26L, 151.37m, new DateTime(2022, 11, 1, 18, 39, 37, 409, DateTimeKind.Unspecified).AddTicks(7979), true, "46crvfhli3jxsl84", new DateTime(2022, 5, 23, 1, 13, 37, 769, DateTimeKind.Unspecified).AddTicks(8543), new DateTime(2021, 6, 3, 7, 14, 18, 523, DateTimeKind.Unspecified).AddTicks(2540), 2, new DateTime(2021, 12, 9, 22, 25, 11, 561, DateTimeKind.Unspecified).AddTicks(4865), 27L },
                    { 27L, 151.37m, new DateTime(2022, 10, 11, 17, 41, 53, 356, DateTimeKind.Unspecified).AddTicks(4256), true, "3ab74yu98efe549y", new DateTime(2022, 8, 15, 3, 54, 8, 601, DateTimeKind.Unspecified).AddTicks(4053), new DateTime(2021, 12, 7, 17, 5, 35, 409, DateTimeKind.Unspecified).AddTicks(5911), 2, null, 33L },
                    { 28L, 136.02m, new DateTime(2023, 8, 8, 8, 3, 57, 941, DateTimeKind.Unspecified).AddTicks(3449), false, "c26kqtjwrynk39gj", new DateTime(2023, 6, 8, 2, 11, 26, 601, DateTimeKind.Unspecified).AddTicks(1827), new DateTime(2023, 4, 24, 17, 10, 6, 934, DateTimeKind.Unspecified).AddTicks(8121), 1, new DateTime(2023, 8, 3, 3, 32, 53, 69, DateTimeKind.Unspecified).AddTicks(3084), 11L },
                    { 29L, 151.37m, new DateTime(2022, 10, 30, 7, 42, 11, 567, DateTimeKind.Unspecified).AddTicks(6656), false, "aqmyw08v96v1s9if", new DateTime(2022, 5, 12, 7, 41, 34, 896, DateTimeKind.Unspecified).AddTicks(4503), new DateTime(2022, 1, 21, 18, 28, 32, 254, DateTimeKind.Unspecified).AddTicks(3137), 2, new DateTime(2023, 3, 8, 20, 55, 13, 457, DateTimeKind.Unspecified).AddTicks(1256), 35L },
                    { 30L, 91.86m, new DateTime(2023, 10, 11, 3, 56, 17, 977, DateTimeKind.Unspecified).AddTicks(6902), false, "0s5wjozi3ma06kzq", new DateTime(2023, 5, 20, 4, 38, 13, 178, DateTimeKind.Unspecified).AddTicks(7742), new DateTime(2019, 10, 19, 11, 38, 26, 709, DateTimeKind.Unspecified).AddTicks(6143), 3, new DateTime(2021, 5, 31, 20, 59, 5, 520, DateTimeKind.Unspecified).AddTicks(1010), 30L },
                    { 31L, 151.37m, new DateTime(2024, 6, 19, 11, 48, 51, 975, DateTimeKind.Unspecified).AddTicks(5361), true, "q9hn6s2kv3y4vcck", new DateTime(2023, 7, 1, 17, 0, 35, 602, DateTimeKind.Unspecified).AddTicks(374), new DateTime(2023, 6, 21, 14, 4, 56, 126, DateTimeKind.Unspecified).AddTicks(5767), 2, new DateTime(2023, 7, 23, 8, 39, 19, 463, DateTimeKind.Unspecified).AddTicks(5514), 8L },
                    { 32L, 91.86m, new DateTime(2020, 9, 25, 19, 13, 27, 847, DateTimeKind.Unspecified).AddTicks(7198), true, "iwgpew5l055a6ccb", new DateTime(2020, 2, 15, 6, 56, 23, 902, DateTimeKind.Unspecified).AddTicks(4585), new DateTime(2019, 10, 12, 2, 44, 22, 979, DateTimeKind.Unspecified).AddTicks(1430), 3, new DateTime(2023, 3, 4, 6, 16, 48, 717, DateTimeKind.Unspecified).AddTicks(8802), 23L },
                    { 33L, 151.37m, new DateTime(2021, 11, 29, 11, 13, 48, 761, DateTimeKind.Unspecified).AddTicks(4052), false, "fqq1hl08z749bd6z", new DateTime(2021, 9, 19, 5, 45, 56, 986, DateTimeKind.Unspecified).AddTicks(6645), new DateTime(2016, 12, 6, 9, 51, 14, 776, DateTimeKind.Unspecified).AddTicks(796), 2, new DateTime(2017, 3, 27, 3, 3, 40, 540, DateTimeKind.Unspecified).AddTicks(984), 38L },
                    { 34L, 91.86m, new DateTime(2023, 9, 28, 1, 47, 34, 95, DateTimeKind.Unspecified).AddTicks(5266), true, "0ml8d5on129n534f", new DateTime(2023, 7, 12, 5, 3, 56, 659, DateTimeKind.Unspecified).AddTicks(9874), new DateTime(2018, 6, 5, 7, 31, 52, 540, DateTimeKind.Unspecified).AddTicks(4549), 3, new DateTime(2018, 10, 23, 21, 38, 39, 792, DateTimeKind.Unspecified).AddTicks(5214), 6L },
                    { 35L, 151.37m, new DateTime(2022, 3, 24, 0, 1, 21, 708, DateTimeKind.Unspecified).AddTicks(8068), false, "k558r56ddw1u0svt", new DateTime(2022, 2, 16, 15, 49, 52, 826, DateTimeKind.Unspecified).AddTicks(8996), new DateTime(2021, 8, 24, 16, 36, 1, 250, DateTimeKind.Unspecified).AddTicks(1936), 2, new DateTime(2022, 9, 3, 12, 50, 44, 236, DateTimeKind.Unspecified).AddTicks(6645), 21L },
                    { 36L, 91.86m, new DateTime(2021, 6, 26, 16, 40, 35, 37, DateTimeKind.Unspecified).AddTicks(8487), true, "9olaqemxndo70gvv", new DateTime(2021, 6, 2, 0, 20, 51, 988, DateTimeKind.Unspecified).AddTicks(2468), new DateTime(2020, 8, 24, 1, 11, 17, 343, DateTimeKind.Unspecified).AddTicks(9594), 3, new DateTime(2021, 6, 19, 22, 23, 21, 303, DateTimeKind.Unspecified).AddTicks(7518), 36L },
                    { 37L, 136.02m, new DateTime(2023, 6, 11, 13, 35, 37, 937, DateTimeKind.Unspecified).AddTicks(2027), true, "1ggquq41cbz3kwmy", new DateTime(2023, 5, 3, 2, 32, 59, 533, DateTimeKind.Unspecified).AddTicks(5238), new DateTime(2022, 10, 20, 19, 57, 6, 624, DateTimeKind.Unspecified).AddTicks(6790), 1, new DateTime(2023, 5, 12, 5, 27, 48, 417, DateTimeKind.Unspecified).AddTicks(1594), 11L },
                    { 38L, 151.37m, new DateTime(2024, 1, 27, 4, 38, 22, 362, DateTimeKind.Unspecified).AddTicks(4138), false, "mcc78krz988ayw3w", new DateTime(2023, 8, 6, 16, 25, 39, 689, DateTimeKind.Unspecified).AddTicks(7649), new DateTime(2023, 6, 30, 11, 54, 38, 133, DateTimeKind.Unspecified).AddTicks(1845), 2, new DateTime(2023, 8, 10, 20, 8, 52, 720, DateTimeKind.Unspecified).AddTicks(3961), 11L },
                    { 39L, 91.86m, new DateTime(2023, 10, 22, 5, 46, 50, 888, DateTimeKind.Unspecified).AddTicks(4554), true, "8czy2s8dnd3hewts", new DateTime(2023, 2, 23, 15, 28, 24, 313, DateTimeKind.Unspecified).AddTicks(482), new DateTime(2022, 11, 27, 20, 25, 55, 601, DateTimeKind.Unspecified).AddTicks(5897), 3, null, 23L },
                    { 40L, 91.86m, new DateTime(2023, 5, 4, 3, 56, 27, 253, DateTimeKind.Unspecified).AddTicks(530), true, "0adhs4lu1czvkswh", new DateTime(2022, 7, 14, 18, 8, 25, 821, DateTimeKind.Unspecified).AddTicks(293), new DateTime(2021, 1, 22, 11, 41, 40, 802, DateTimeKind.Unspecified).AddTicks(554), 3, new DateTime(2022, 8, 11, 4, 22, 39, 960, DateTimeKind.Unspecified).AddTicks(9300), 1L },
                    { 41L, 136.02m, new DateTime(2022, 3, 6, 0, 19, 57, 123, DateTimeKind.Unspecified).AddTicks(6707), false, "t24hxzbvbmyserki", new DateTime(2021, 4, 3, 7, 39, 38, 902, DateTimeKind.Unspecified).AddTicks(2927), new DateTime(2021, 2, 24, 12, 20, 21, 40, DateTimeKind.Unspecified).AddTicks(4389), 1, new DateTime(2023, 6, 25, 5, 11, 25, 185, DateTimeKind.Unspecified).AddTicks(1086), 32L },
                    { 42L, 136.02m, new DateTime(2024, 6, 8, 23, 28, 20, 482, DateTimeKind.Unspecified).AddTicks(4671), true, "2cbsqfkes0nq04x2", new DateTime(2023, 8, 2, 10, 54, 59, 83, DateTimeKind.Unspecified).AddTicks(8871), new DateTime(2022, 6, 5, 1, 9, 13, 811, DateTimeKind.Unspecified).AddTicks(8828), 1, new DateTime(2022, 7, 30, 20, 39, 38, 131, DateTimeKind.Unspecified).AddTicks(7660), 2L },
                    { 43L, 151.37m, new DateTime(2023, 9, 4, 7, 32, 56, 191, DateTimeKind.Unspecified).AddTicks(3821), false, "a3sk5gfvudeknj5w", new DateTime(2023, 7, 30, 10, 8, 8, 351, DateTimeKind.Unspecified).AddTicks(6191), new DateTime(2023, 7, 13, 22, 58, 53, 787, DateTimeKind.Unspecified).AddTicks(5338), 2, new DateTime(2023, 8, 16, 18, 7, 38, 437, DateTimeKind.Unspecified).AddTicks(5185), 3L },
                    { 44L, 91.86m, new DateTime(2024, 3, 5, 1, 40, 21, 250, DateTimeKind.Unspecified).AddTicks(5547), true, "bc0td9wya1hmn09c", new DateTime(2023, 6, 21, 19, 43, 54, 85, DateTimeKind.Unspecified).AddTicks(1578), new DateTime(2023, 3, 3, 15, 18, 50, 622, DateTimeKind.Unspecified).AddTicks(5031), 3, new DateTime(2023, 5, 3, 6, 38, 3, 651, DateTimeKind.Unspecified).AddTicks(2925), 23L },
                    { 45L, 151.37m, new DateTime(2022, 12, 29, 17, 21, 31, 38, DateTimeKind.Unspecified).AddTicks(7077), true, "xowb5o5gk48tfmik", new DateTime(2022, 12, 15, 6, 28, 50, 15, DateTimeKind.Unspecified).AddTicks(2530), new DateTime(2021, 11, 10, 19, 49, 42, 915, DateTimeKind.Unspecified).AddTicks(3606), 2, new DateTime(2022, 10, 13, 18, 58, 59, 626, DateTimeKind.Unspecified).AddTicks(2349), 19L },
                    { 46L, 136.02m, new DateTime(2022, 6, 17, 0, 22, 59, 71, DateTimeKind.Unspecified).AddTicks(4211), false, "anubxvyyxivpdltm", new DateTime(2021, 9, 12, 18, 16, 45, 88, DateTimeKind.Unspecified).AddTicks(9694), new DateTime(2019, 8, 19, 2, 55, 20, 713, DateTimeKind.Unspecified).AddTicks(3150), 1, new DateTime(2021, 6, 1, 11, 29, 8, 631, DateTimeKind.Unspecified).AddTicks(6462), 36L },
                    { 47L, 136.02m, new DateTime(2024, 5, 9, 22, 41, 30, 395, DateTimeKind.Unspecified).AddTicks(9809), false, "ab681sgffu1ituio", new DateTime(2023, 8, 17, 10, 51, 34, 428, DateTimeKind.Unspecified).AddTicks(6534), new DateTime(2023, 6, 11, 22, 54, 59, 820, DateTimeKind.Unspecified).AddTicks(1127), 1, new DateTime(2023, 8, 8, 21, 55, 54, 847, DateTimeKind.Unspecified).AddTicks(186), 7L }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "Cost", "EndDate", "IsActive", "PaymentSubscriptionId", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate", "UserId" },
                values: new object[,]
                {
                    { 48L, 151.37m, new DateTime(2023, 2, 20, 17, 27, 28, 857, DateTimeKind.Unspecified).AddTicks(8526), true, "noq0gqauqw1mppw5", new DateTime(2022, 8, 1, 17, 5, 3, 97, DateTimeKind.Unspecified).AddTicks(3381), new DateTime(2021, 5, 28, 12, 50, 44, 911, DateTimeKind.Unspecified).AddTicks(7081), 2, new DateTime(2022, 2, 4, 15, 14, 2, 77, DateTimeKind.Unspecified).AddTicks(7387), 4L },
                    { 49L, 136.02m, new DateTime(2024, 5, 15, 5, 41, 5, 388, DateTimeKind.Unspecified).AddTicks(8327), true, "icchkz7h4bld2gyo", new DateTime(2023, 7, 24, 8, 41, 57, 747, DateTimeKind.Unspecified).AddTicks(6767), new DateTime(2022, 7, 30, 2, 18, 37, 424, DateTimeKind.Unspecified).AddTicks(785), 1, new DateTime(2023, 7, 15, 17, 26, 51, 249, DateTimeKind.Unspecified).AddTicks(6705), 23L },
                    { 50L, 151.37m, new DateTime(2023, 8, 22, 23, 50, 52, 889, DateTimeKind.Unspecified).AddTicks(894), false, "dqu9ioacwoh3dt9r", new DateTime(2023, 7, 9, 21, 53, 30, 927, DateTimeKind.Unspecified).AddTicks(8454), new DateTime(2023, 6, 13, 3, 26, 49, 792, DateTimeKind.Unspecified).AddTicks(2683), 2, null, 28L },
                    { 51L, 136.02m, new DateTime(2022, 5, 26, 14, 39, 42, 400, DateTimeKind.Unspecified).AddTicks(9090), false, "hlzcjv8mdw4u5yyf", new DateTime(2021, 6, 9, 8, 13, 7, 92, DateTimeKind.Unspecified).AddTicks(698), new DateTime(2019, 12, 27, 9, 58, 23, 16, DateTimeKind.Unspecified).AddTicks(2629), 1, new DateTime(2023, 2, 9, 7, 39, 31, 251, DateTimeKind.Unspecified).AddTicks(9653), 1L },
                    { 52L, 91.86m, new DateTime(2023, 12, 26, 16, 42, 48, 54, DateTimeKind.Unspecified).AddTicks(6663), false, "y089embtn7rxpys0", new DateTime(2023, 4, 16, 2, 29, 52, 273, DateTimeKind.Unspecified).AddTicks(6428), new DateTime(2022, 12, 16, 23, 28, 44, 572, DateTimeKind.Unspecified).AddTicks(4850), 3, new DateTime(2023, 3, 25, 22, 31, 24, 563, DateTimeKind.Unspecified).AddTicks(361), 18L },
                    { 53L, 136.02m, new DateTime(2023, 8, 1, 7, 19, 22, 184, DateTimeKind.Unspecified).AddTicks(2281), true, "l2cv2onna8ejmz8r", new DateTime(2023, 5, 27, 0, 0, 28, 681, DateTimeKind.Unspecified).AddTicks(6669), new DateTime(2020, 1, 24, 15, 53, 51, 56, DateTimeKind.Unspecified).AddTicks(8822), 1, new DateTime(2020, 3, 11, 15, 53, 36, 1, DateTimeKind.Unspecified).AddTicks(3102), 23L },
                    { 54L, 136.02m, new DateTime(2023, 10, 4, 8, 8, 46, 665, DateTimeKind.Unspecified).AddTicks(2431), true, "gfy34t1jeinb9gqz", new DateTime(2023, 3, 21, 7, 5, 33, 858, DateTimeKind.Unspecified).AddTicks(4953), new DateTime(2022, 11, 3, 10, 9, 36, 85, DateTimeKind.Unspecified).AddTicks(3572), 1, new DateTime(2023, 1, 16, 9, 29, 25, 537, DateTimeKind.Unspecified).AddTicks(2679), 22L },
                    { 55L, 91.86m, new DateTime(2021, 7, 15, 0, 45, 31, 671, DateTimeKind.Unspecified).AddTicks(3046), true, "nzwe7ojkc9empkjg", new DateTime(2021, 3, 18, 0, 12, 52, 754, DateTimeKind.Unspecified).AddTicks(4697), new DateTime(2020, 11, 22, 16, 58, 29, 531, DateTimeKind.Unspecified).AddTicks(3848), 3, new DateTime(2023, 5, 20, 14, 6, 50, 509, DateTimeKind.Unspecified).AddTicks(444), 8L },
                    { 56L, 136.02m, new DateTime(2023, 9, 16, 20, 23, 50, 392, DateTimeKind.Unspecified).AddTicks(4965), false, "j7d2e9j71hg4xncp", new DateTime(2023, 8, 23, 9, 40, 18, 151, DateTimeKind.Unspecified).AddTicks(2193), new DateTime(2023, 8, 14, 5, 44, 19, 354, DateTimeKind.Unspecified).AddTicks(1871), 1, new DateTime(2023, 8, 15, 7, 27, 11, 437, DateTimeKind.Unspecified).AddTicks(6294), 39L },
                    { 57L, 136.02m, new DateTime(2021, 12, 22, 6, 39, 2, 881, DateTimeKind.Unspecified).AddTicks(8475), false, "l7ao3a4qisuzah62", new DateTime(2021, 11, 6, 11, 8, 51, 35, DateTimeKind.Unspecified).AddTicks(1279), new DateTime(2021, 5, 4, 21, 13, 7, 563, DateTimeKind.Unspecified).AddTicks(5955), 1, new DateTime(2022, 4, 10, 13, 52, 40, 207, DateTimeKind.Unspecified).AddTicks(512), 30L },
                    { 58L, 91.86m, new DateTime(2022, 7, 1, 18, 30, 30, 471, DateTimeKind.Unspecified).AddTicks(9217), true, "if58xh1fxeg6zu3r", new DateTime(2021, 9, 14, 9, 2, 2, 650, DateTimeKind.Unspecified).AddTicks(2699), new DateTime(2021, 6, 13, 20, 4, 11, 442, DateTimeKind.Unspecified).AddTicks(5634), 3, new DateTime(2022, 4, 4, 11, 32, 49, 42, DateTimeKind.Unspecified).AddTicks(8417), 15L },
                    { 59L, 151.37m, new DateTime(2023, 7, 20, 1, 37, 16, 497, DateTimeKind.Unspecified).AddTicks(9973), false, "xw8vj1u6nq6o4wt0", new DateTime(2023, 7, 10, 16, 29, 6, 20, DateTimeKind.Unspecified).AddTicks(1354), new DateTime(2022, 8, 27, 11, 42, 39, 355, DateTimeKind.Unspecified).AddTicks(9865), 2, new DateTime(2023, 8, 14, 12, 32, 6, 62, DateTimeKind.Unspecified).AddTicks(7692), 31L },
                    { 60L, 136.02m, new DateTime(2022, 9, 24, 13, 36, 4, 681, DateTimeKind.Unspecified).AddTicks(7924), true, "2tufsfq40oa185wv", new DateTime(2022, 1, 16, 23, 24, 13, 493, DateTimeKind.Unspecified).AddTicks(9008), new DateTime(2021, 7, 17, 13, 59, 14, 667, DateTimeKind.Unspecified).AddTicks(9897), 1, new DateTime(2022, 6, 9, 3, 53, 57, 590, DateTimeKind.Unspecified).AddTicks(4951), 23L },
                    { 61L, 136.02m, new DateTime(2023, 12, 4, 23, 4, 59, 77, DateTimeKind.Unspecified).AddTicks(8522), false, "wmcdbjgysdsp6fe8", new DateTime(2023, 4, 24, 3, 3, 29, 550, DateTimeKind.Unspecified).AddTicks(9925), new DateTime(2023, 1, 14, 16, 53, 12, 624, DateTimeKind.Unspecified).AddTicks(7139), 1, new DateTime(2023, 7, 4, 1, 19, 6, 539, DateTimeKind.Unspecified).AddTicks(1756), 40L },
                    { 62L, 151.37m, new DateTime(2023, 10, 27, 10, 20, 54, 570, DateTimeKind.Unspecified).AddTicks(9256), true, "i6bqfv7n7ei52dtg", new DateTime(2023, 6, 17, 11, 20, 47, 48, DateTimeKind.Unspecified).AddTicks(9671), new DateTime(2022, 1, 29, 8, 29, 43, 613, DateTimeKind.Unspecified).AddTicks(3201), 2, new DateTime(2022, 5, 29, 12, 57, 35, 721, DateTimeKind.Unspecified).AddTicks(9114), 10L },
                    { 63L, 136.02m, new DateTime(2024, 5, 23, 19, 1, 24, 677, DateTimeKind.Unspecified).AddTicks(5645), false, "va8nr6u4vqv58pix", new DateTime(2023, 6, 26, 4, 38, 31, 789, DateTimeKind.Unspecified).AddTicks(8217), new DateTime(2022, 11, 22, 17, 26, 47, 647, DateTimeKind.Unspecified).AddTicks(9982), 1, new DateTime(2023, 1, 27, 2, 17, 36, 104, DateTimeKind.Unspecified).AddTicks(4742), 7L },
                    { 64L, 151.37m, new DateTime(2022, 1, 5, 16, 30, 37, 826, DateTimeKind.Unspecified).AddTicks(7944), false, "7779iv8ah6v5mjw1", new DateTime(2021, 7, 8, 21, 59, 9, 691, DateTimeKind.Unspecified).AddTicks(1990), new DateTime(2020, 7, 12, 5, 0, 8, 776, DateTimeKind.Unspecified).AddTicks(6990), 2, new DateTime(2022, 8, 15, 17, 4, 26, 252, DateTimeKind.Unspecified).AddTicks(1640), 23L },
                    { 65L, 151.37m, new DateTime(2023, 8, 27, 1, 9, 37, 648, DateTimeKind.Unspecified).AddTicks(1565), false, "tbp7qw8m3mfjyklz", new DateTime(2022, 10, 29, 10, 4, 8, 910, DateTimeKind.Unspecified).AddTicks(5057), new DateTime(2022, 10, 10, 18, 46, 46, 165, DateTimeKind.Unspecified).AddTicks(2416), 2, new DateTime(2023, 1, 30, 19, 35, 49, 980, DateTimeKind.Unspecified).AddTicks(9814), 21L },
                    { 66L, 136.02m, new DateTime(2023, 9, 17, 6, 2, 12, 378, DateTimeKind.Unspecified).AddTicks(4010), true, "8g7ixv4jzog650kl", new DateTime(2023, 8, 11, 4, 55, 13, 503, DateTimeKind.Unspecified).AddTicks(1951), new DateTime(2016, 7, 29, 23, 59, 23, 471, DateTimeKind.Unspecified).AddTicks(8007), 1, new DateTime(2019, 3, 8, 2, 27, 28, 885, DateTimeKind.Unspecified).AddTicks(7404), 38L },
                    { 67L, 91.86m, new DateTime(2022, 10, 18, 13, 4, 45, 935, DateTimeKind.Unspecified).AddTicks(4420), true, "sbtx06pg02z9opp8", new DateTime(2022, 9, 9, 10, 46, 0, 350, DateTimeKind.Unspecified).AddTicks(4617), new DateTime(2022, 4, 20, 11, 48, 49, 521, DateTimeKind.Unspecified).AddTicks(974), 3, new DateTime(2022, 11, 10, 12, 34, 7, 924, DateTimeKind.Unspecified).AddTicks(2157), 20L },
                    { 68L, 91.86m, new DateTime(2022, 11, 26, 17, 55, 9, 496, DateTimeKind.Unspecified).AddTicks(4840), true, "z24labjvd7qm17jt", new DateTime(2022, 11, 9, 16, 10, 11, 974, DateTimeKind.Unspecified).AddTicks(3728), new DateTime(2022, 10, 14, 19, 54, 8, 562, DateTimeKind.Unspecified).AddTicks(3982), 3, new DateTime(2023, 1, 17, 8, 44, 43, 614, DateTimeKind.Unspecified).AddTicks(2541), 39L },
                    { 69L, 136.02m, new DateTime(2024, 5, 22, 20, 53, 41, 231, DateTimeKind.Unspecified).AddTicks(272), true, "jti7tswdhcxx146p", new DateTime(2023, 5, 27, 8, 7, 13, 248, DateTimeKind.Unspecified).AddTicks(5017), new DateTime(2023, 3, 9, 17, 12, 54, 501, DateTimeKind.Unspecified).AddTicks(7457), 1, new DateTime(2023, 3, 23, 16, 45, 50, 972, DateTimeKind.Unspecified).AddTicks(9166), 23L },
                    { 70L, 151.37m, new DateTime(2022, 5, 18, 17, 34, 50, 485, DateTimeKind.Unspecified).AddTicks(1043), false, "dqb49qfp6v2htb1l", new DateTime(2022, 2, 3, 19, 51, 2, 247, DateTimeKind.Unspecified).AddTicks(7846), new DateTime(2018, 4, 23, 3, 40, 36, 906, DateTimeKind.Unspecified).AddTicks(7985), 2, new DateTime(2021, 7, 21, 8, 29, 38, 739, DateTimeKind.Unspecified).AddTicks(9144), 13L },
                    { 71L, 136.02m, new DateTime(2023, 4, 28, 6, 54, 26, 452, DateTimeKind.Unspecified).AddTicks(901), true, "tfjxef8gm7u3gr4q", new DateTime(2023, 4, 4, 2, 45, 2, 232, DateTimeKind.Unspecified).AddTicks(7067), new DateTime(2023, 3, 5, 15, 7, 42, 391, DateTimeKind.Unspecified).AddTicks(3766), 1, new DateTime(2023, 6, 30, 1, 50, 18, 614, DateTimeKind.Unspecified).AddTicks(1720), 37L },
                    { 72L, 151.37m, new DateTime(2024, 1, 18, 13, 20, 4, 617, DateTimeKind.Unspecified).AddTicks(473), false, "2b5myh0ryhbt7haq", new DateTime(2023, 7, 22, 5, 5, 57, 47, DateTimeKind.Unspecified).AddTicks(9702), new DateTime(2023, 6, 5, 12, 27, 48, 211, DateTimeKind.Unspecified).AddTicks(3023), 2, new DateTime(2023, 8, 19, 9, 16, 41, 893, DateTimeKind.Unspecified).AddTicks(1535), 26L },
                    { 73L, 136.02m, new DateTime(2023, 12, 23, 15, 42, 42, 452, DateTimeKind.Unspecified).AddTicks(3803), true, "8ds2vlr4ibv39lh4", new DateTime(2023, 7, 5, 20, 30, 41, 454, DateTimeKind.Unspecified).AddTicks(9848), new DateTime(2020, 10, 3, 22, 19, 57, 688, DateTimeKind.Unspecified).AddTicks(3343), 1, new DateTime(2021, 8, 20, 19, 4, 7, 644, DateTimeKind.Unspecified).AddTicks(9818), 9L },
                    { 74L, 136.02m, new DateTime(2023, 11, 15, 8, 12, 4, 81, DateTimeKind.Unspecified).AddTicks(2567), true, "xzjgtbq46mekoxwc", new DateTime(2023, 4, 2, 21, 2, 7, 866, DateTimeKind.Unspecified).AddTicks(1121), new DateTime(2019, 8, 27, 20, 2, 12, 631, DateTimeKind.Unspecified).AddTicks(7173), 1, new DateTime(2020, 6, 10, 1, 59, 50, 372, DateTimeKind.Unspecified).AddTicks(4004), 30L },
                    { 75L, 91.86m, new DateTime(2023, 9, 3, 11, 17, 50, 933, DateTimeKind.Unspecified).AddTicks(1073), true, "4qdes62xud4v2bb7", new DateTime(2023, 6, 16, 20, 14, 17, 760, DateTimeKind.Unspecified).AddTicks(3900), new DateTime(2023, 2, 17, 16, 27, 51, 507, DateTimeKind.Unspecified).AddTicks(2696), 3, new DateTime(2023, 8, 6, 22, 46, 48, 38, DateTimeKind.Unspecified).AddTicks(5478), 24L },
                    { 76L, 151.37m, new DateTime(2023, 8, 27, 1, 36, 28, 777, DateTimeKind.Unspecified).AddTicks(3874), true, "6s7a0msqiic2ybbz", new DateTime(2022, 10, 31, 18, 44, 55, 489, DateTimeKind.Unspecified).AddTicks(9899), new DateTime(2022, 6, 29, 13, 8, 35, 787, DateTimeKind.Unspecified).AddTicks(5704), 2, new DateTime(2022, 7, 13, 5, 46, 37, 25, DateTimeKind.Unspecified).AddTicks(4992), 23L },
                    { 77L, 151.37m, new DateTime(2022, 9, 21, 19, 15, 19, 861, DateTimeKind.Unspecified).AddTicks(230), true, "u2bu9ut7a380yrw7", new DateTime(2021, 10, 4, 12, 32, 53, 278, DateTimeKind.Unspecified).AddTicks(8077), new DateTime(2019, 6, 6, 11, 59, 10, 133, DateTimeKind.Unspecified).AddTicks(9970), 2, new DateTime(2020, 7, 10, 0, 26, 38, 109, DateTimeKind.Unspecified).AddTicks(7711), 24L },
                    { 78L, 136.02m, new DateTime(2023, 9, 16, 11, 6, 55, 969, DateTimeKind.Unspecified).AddTicks(1696), false, "gx2r65g5hsfxbxgo", new DateTime(2023, 8, 17, 23, 58, 30, 436, DateTimeKind.Unspecified).AddTicks(7357), new DateTime(2023, 7, 20, 13, 44, 37, 570, DateTimeKind.Unspecified).AddTicks(6301), 1, null, 28L },
                    { 79L, 136.02m, new DateTime(2021, 4, 12, 13, 35, 30, 450, DateTimeKind.Unspecified).AddTicks(8065), false, "jjpfoqglt2ecr215", new DateTime(2020, 12, 7, 14, 37, 55, 457, DateTimeKind.Unspecified).AddTicks(9343), new DateTime(2020, 5, 31, 14, 32, 50, 529, DateTimeKind.Unspecified).AddTicks(3083), 1, new DateTime(2023, 7, 25, 22, 39, 38, 581, DateTimeKind.Unspecified).AddTicks(2299), 27L },
                    { 80L, 91.86m, new DateTime(2022, 6, 5, 21, 25, 47, 119, DateTimeKind.Unspecified).AddTicks(133), false, "xnuthf65wa7mg0gr", new DateTime(2021, 11, 26, 12, 55, 13, 698, DateTimeKind.Unspecified).AddTicks(6345), new DateTime(2021, 4, 26, 13, 46, 0, 111, DateTimeKind.Unspecified).AddTicks(5489), 3, new DateTime(2021, 7, 29, 16, 46, 51, 654, DateTimeKind.Unspecified).AddTicks(7610), 14L },
                    { 81L, 136.02m, new DateTime(2023, 4, 26, 21, 49, 7, 655, DateTimeKind.Unspecified).AddTicks(1617), false, "3m6zsvfkn1i0vm3e", new DateTime(2022, 6, 17, 17, 17, 22, 960, DateTimeKind.Unspecified).AddTicks(2885), new DateTime(2021, 5, 4, 14, 14, 26, 609, DateTimeKind.Unspecified).AddTicks(6659), 1, new DateTime(2022, 4, 13, 20, 49, 35, 117, DateTimeKind.Unspecified).AddTicks(5880), 36L },
                    { 82L, 151.37m, new DateTime(2024, 2, 17, 16, 6, 1, 754, DateTimeKind.Unspecified).AddTicks(8078), false, "mrtium4tr7pv86d0", new DateTime(2023, 8, 15, 17, 25, 51, 969, DateTimeKind.Unspecified).AddTicks(7450), new DateTime(2023, 8, 10, 13, 19, 11, 995, DateTimeKind.Unspecified).AddTicks(506), 2, new DateTime(2023, 8, 16, 5, 13, 13, 864, DateTimeKind.Unspecified).AddTicks(2172), 34L },
                    { 83L, 91.86m, new DateTime(2024, 2, 8, 9, 48, 59, 3, DateTimeKind.Unspecified).AddTicks(9573), false, "qpd9nfspxjd01xp0", new DateTime(2023, 3, 11, 16, 48, 45, 571, DateTimeKind.Unspecified).AddTicks(1981), new DateTime(2022, 4, 15, 20, 50, 55, 340, DateTimeKind.Unspecified).AddTicks(6865), 3, new DateTime(2022, 8, 6, 6, 48, 0, 441, DateTimeKind.Unspecified).AddTicks(3534), 37L },
                    { 84L, 136.02m, new DateTime(2024, 6, 6, 9, 13, 32, 94, DateTimeKind.Unspecified).AddTicks(1417), false, "wfn8fa46w4r59v5c", new DateTime(2023, 8, 11, 14, 22, 38, 607, DateTimeKind.Unspecified).AddTicks(9164), new DateTime(2023, 7, 14, 5, 16, 28, 495, DateTimeKind.Unspecified).AddTicks(8108), 1, new DateTime(2023, 7, 28, 13, 46, 13, 810, DateTimeKind.Unspecified).AddTicks(6541), 18L },
                    { 85L, 136.02m, new DateTime(2023, 9, 20, 9, 28, 31, 853, DateTimeKind.Unspecified).AddTicks(9938), true, "wyht67sijod7rj9m", new DateTime(2023, 7, 23, 17, 27, 7, 948, DateTimeKind.Unspecified).AddTicks(5413), new DateTime(2022, 4, 15, 15, 33, 3, 624, DateTimeKind.Unspecified).AddTicks(1287), 1, new DateTime(2023, 1, 21, 8, 20, 43, 203, DateTimeKind.Unspecified).AddTicks(3296), 17L },
                    { 86L, 136.02m, new DateTime(2023, 2, 6, 16, 32, 55, 173, DateTimeKind.Unspecified).AddTicks(4513), false, "jx8v9gvjgqbhtb0p", new DateTime(2022, 8, 4, 7, 12, 9, 616, DateTimeKind.Unspecified).AddTicks(9247), new DateTime(2021, 2, 23, 10, 41, 46, 783, DateTimeKind.Unspecified).AddTicks(9324), 1, new DateTime(2023, 6, 29, 22, 0, 35, 96, DateTimeKind.Unspecified).AddTicks(8045), 13L },
                    { 87L, 91.86m, new DateTime(2023, 4, 8, 16, 46, 50, 91, DateTimeKind.Unspecified).AddTicks(1583), true, "rcan81qc7fa8yw83", new DateTime(2023, 1, 13, 7, 17, 0, 379, DateTimeKind.Unspecified).AddTicks(1842), new DateTime(2023, 1, 5, 21, 55, 5, 678, DateTimeKind.Unspecified).AddTicks(838), 3, new DateTime(2023, 7, 2, 20, 18, 7, 243, DateTimeKind.Unspecified).AddTicks(9037), 33L },
                    { 88L, 91.86m, new DateTime(2022, 11, 8, 21, 4, 42, 672, DateTimeKind.Unspecified).AddTicks(6686), true, "5emwz6jldc4x58af", new DateTime(2022, 10, 26, 4, 2, 26, 924, DateTimeKind.Unspecified).AddTicks(972), new DateTime(2022, 4, 24, 18, 17, 2, 401, DateTimeKind.Unspecified).AddTicks(8096), 3, new DateTime(2023, 5, 7, 9, 53, 55, 741, DateTimeKind.Unspecified).AddTicks(7489), 40L },
                    { 89L, 91.86m, new DateTime(2024, 5, 7, 22, 44, 33, 674, DateTimeKind.Unspecified).AddTicks(8260), false, "1hro6jnzj7hueud0", new DateTime(2023, 7, 22, 17, 5, 6, 219, DateTimeKind.Unspecified).AddTicks(6499), new DateTime(2023, 5, 27, 16, 5, 13, 948, DateTimeKind.Unspecified).AddTicks(4457), 3, new DateTime(2023, 6, 23, 23, 19, 33, 456, DateTimeKind.Unspecified).AddTicks(6269), 37L }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "Cost", "EndDate", "IsActive", "PaymentSubscriptionId", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate", "UserId" },
                values: new object[,]
                {
                    { 90L, 136.02m, new DateTime(2024, 5, 20, 6, 45, 41, 504, DateTimeKind.Unspecified).AddTicks(9248), true, "jb19he1dn7vheueu", new DateTime(2023, 8, 17, 22, 56, 48, 350, DateTimeKind.Unspecified).AddTicks(5671), new DateTime(2023, 5, 25, 12, 16, 56, 958, DateTimeKind.Unspecified).AddTicks(3147), 1, null, 28L },
                    { 91L, 136.02m, new DateTime(2023, 9, 4, 14, 9, 24, 519, DateTimeKind.Unspecified).AddTicks(2787), true, "l9hcw3mpj65vhei4", new DateTime(2022, 9, 8, 7, 19, 2, 574, DateTimeKind.Unspecified).AddTicks(2422), new DateTime(2022, 6, 12, 15, 23, 41, 193, DateTimeKind.Unspecified).AddTicks(4990), 1, new DateTime(2023, 7, 5, 10, 44, 57, 80, DateTimeKind.Unspecified).AddTicks(1071), 7L },
                    { 92L, 136.02m, new DateTime(2024, 1, 6, 16, 11, 57, 864, DateTimeKind.Unspecified).AddTicks(6227), true, "a0yox0t3avo8xphk", new DateTime(2023, 5, 2, 16, 19, 47, 86, DateTimeKind.Unspecified).AddTicks(5799), new DateTime(2023, 3, 30, 10, 45, 24, 245, DateTimeKind.Unspecified).AddTicks(2960), 1, new DateTime(2023, 6, 17, 21, 37, 18, 265, DateTimeKind.Unspecified).AddTicks(2585), 24L },
                    { 93L, 136.02m, new DateTime(2023, 5, 14, 23, 13, 51, 567, DateTimeKind.Unspecified).AddTicks(6392), true, "m8rn9t5pne2v4ysj", new DateTime(2022, 8, 25, 3, 32, 0, 894, DateTimeKind.Unspecified).AddTicks(2531), new DateTime(2021, 2, 8, 4, 23, 53, 167, DateTimeKind.Unspecified).AddTicks(219), 1, new DateTime(2021, 10, 19, 16, 7, 25, 143, DateTimeKind.Unspecified).AddTicks(7533), 15L },
                    { 94L, 91.86m, new DateTime(2023, 3, 3, 6, 58, 32, 790, DateTimeKind.Unspecified).AddTicks(7492), false, "mmluyddqoo1o85th", new DateTime(2022, 7, 16, 16, 19, 50, 197, DateTimeKind.Unspecified).AddTicks(7167), new DateTime(2021, 4, 11, 11, 15, 2, 112, DateTimeKind.Unspecified).AddTicks(7701), 3, new DateTime(2022, 9, 8, 8, 1, 58, 508, DateTimeKind.Unspecified).AddTicks(9248), 30L },
                    { 95L, 136.02m, new DateTime(2023, 5, 5, 0, 8, 49, 789, DateTimeKind.Unspecified).AddTicks(7924), true, "cevlzqkc2a1n7br9", new DateTime(2022, 6, 11, 14, 41, 8, 7, DateTimeKind.Unspecified).AddTicks(6817), new DateTime(2021, 6, 8, 6, 51, 59, 507, DateTimeKind.Unspecified).AddTicks(1877), 1, new DateTime(2021, 9, 2, 23, 8, 38, 885, DateTimeKind.Unspecified).AddTicks(9496), 2L },
                    { 96L, 91.86m, new DateTime(2023, 9, 11, 13, 6, 0, 361, DateTimeKind.Unspecified).AddTicks(999), true, "93vrpnu06yhjisrx", new DateTime(2023, 7, 31, 5, 30, 10, 342, DateTimeKind.Unspecified).AddTicks(6276), new DateTime(2022, 7, 28, 13, 36, 49, 773, DateTimeKind.Unspecified).AddTicks(6737), 3, new DateTime(2022, 10, 3, 16, 1, 0, 623, DateTimeKind.Unspecified).AddTicks(6067), 5L },
                    { 97L, 136.02m, new DateTime(2023, 6, 23, 10, 34, 38, 995, DateTimeKind.Unspecified).AddTicks(8512), true, "7biaezr83ocwvtne", new DateTime(2022, 8, 29, 21, 15, 55, 744, DateTimeKind.Unspecified).AddTicks(1598), new DateTime(2022, 4, 23, 23, 17, 20, 450, DateTimeKind.Unspecified).AddTicks(1388), 1, new DateTime(2022, 8, 2, 7, 18, 57, 538, DateTimeKind.Unspecified).AddTicks(251), 19L },
                    { 98L, 136.02m, new DateTime(2023, 10, 18, 15, 18, 59, 298, DateTimeKind.Unspecified).AddTicks(267), true, "k9c7hc23tgje5jm7", new DateTime(2023, 5, 12, 11, 35, 47, 432, DateTimeKind.Unspecified).AddTicks(8192), new DateTime(2021, 11, 21, 3, 31, 41, 17, DateTimeKind.Unspecified).AddTicks(191), 1, new DateTime(2023, 5, 25, 5, 19, 55, 90, DateTimeKind.Unspecified).AddTicks(4797), 8L },
                    { 99L, 136.02m, new DateTime(2020, 5, 15, 17, 0, 59, 908, DateTimeKind.Unspecified).AddTicks(5147), false, "17h3p0lzj9p4mkrq", new DateTime(2020, 2, 11, 13, 47, 4, 571, DateTimeKind.Unspecified).AddTicks(6602), new DateTime(2017, 9, 19, 16, 30, 53, 730, DateTimeKind.Unspecified).AddTicks(288), 1, new DateTime(2019, 3, 31, 20, 30, 15, 954, DateTimeKind.Unspecified).AddTicks(2437), 24L },
                    { 100L, 151.37m, new DateTime(2024, 5, 20, 16, 18, 38, 125, DateTimeKind.Unspecified).AddTicks(3279), false, "ea2krxtp615avzdt", new DateTime(2023, 7, 23, 21, 50, 7, 505, DateTimeKind.Unspecified).AddTicks(2855), new DateTime(2022, 12, 6, 8, 50, 58, 312, DateTimeKind.Unspecified).AddTicks(6902), 2, new DateTime(2023, 4, 14, 22, 7, 37, 846, DateTimeKind.Unspecified).AddTicks(2726), 35L },
                    { 101L, 136.02m, new DateTime(2023, 12, 29, 21, 38, 4, 329, DateTimeKind.Unspecified).AddTicks(8285), false, "hp86so1sykofx18m", new DateTime(2023, 7, 31, 9, 37, 43, 615, DateTimeKind.Unspecified).AddTicks(947), new DateTime(2023, 6, 27, 7, 15, 21, 316, DateTimeKind.Unspecified).AddTicks(2714), 1, new DateTime(2023, 7, 24, 15, 11, 0, 29, DateTimeKind.Unspecified).AddTicks(4851), 19L },
                    { 102L, 151.37m, new DateTime(2023, 1, 31, 5, 29, 43, 225, DateTimeKind.Unspecified).AddTicks(9237), false, "v9jped3wpf21omxi", new DateTime(2022, 10, 11, 6, 33, 57, 625, DateTimeKind.Unspecified).AddTicks(6185), new DateTime(2022, 5, 28, 15, 41, 0, 212, DateTimeKind.Unspecified).AddTicks(5852), 2, new DateTime(2023, 8, 9, 22, 16, 55, 772, DateTimeKind.Unspecified).AddTicks(7794), 40L },
                    { 103L, 91.86m, new DateTime(2024, 3, 5, 16, 45, 8, 198, DateTimeKind.Unspecified).AddTicks(5552), false, "a7ftky80unai4cdk", new DateTime(2023, 3, 19, 10, 45, 8, 407, DateTimeKind.Unspecified).AddTicks(5965), new DateTime(2022, 10, 3, 17, 37, 24, 848, DateTimeKind.Unspecified).AddTicks(5672), 3, new DateTime(2022, 12, 12, 4, 31, 45, 668, DateTimeKind.Unspecified).AddTicks(2289), 20L },
                    { 104L, 136.02m, new DateTime(2021, 5, 31, 3, 43, 18, 136, DateTimeKind.Unspecified).AddTicks(4231), false, "2fl25kawdqe7y9cr", new DateTime(2021, 1, 27, 10, 52, 38, 880, DateTimeKind.Unspecified).AddTicks(1515), new DateTime(2020, 12, 28, 11, 38, 31, 923, DateTimeKind.Unspecified).AddTicks(4105), 1, new DateTime(2022, 2, 1, 9, 18, 59, 211, DateTimeKind.Unspecified).AddTicks(4049), 8L },
                    { 105L, 151.37m, new DateTime(2023, 3, 13, 22, 20, 42, 410, DateTimeKind.Unspecified).AddTicks(7758), true, "yrti9du39mr5c5va", new DateTime(2022, 4, 5, 1, 24, 53, 568, DateTimeKind.Unspecified).AddTicks(3404), new DateTime(2021, 5, 24, 16, 10, 15, 966, DateTimeKind.Unspecified).AddTicks(7061), 2, new DateTime(2021, 10, 18, 20, 15, 11, 747, DateTimeKind.Unspecified).AddTicks(8045), 14L },
                    { 106L, 136.02m, new DateTime(2023, 12, 29, 16, 38, 39, 698, DateTimeKind.Unspecified).AddTicks(2257), true, "fybw1xhn0y3drrm0", new DateTime(2023, 6, 25, 4, 19, 43, 712, DateTimeKind.Unspecified).AddTicks(2927), new DateTime(2023, 5, 25, 17, 15, 8, 58, DateTimeKind.Unspecified).AddTicks(6806), 1, new DateTime(2023, 6, 13, 0, 20, 25, 759, DateTimeKind.Unspecified).AddTicks(6844), 36L },
                    { 107L, 136.02m, new DateTime(2019, 11, 2, 6, 28, 39, 553, DateTimeKind.Unspecified).AddTicks(7775), false, "6voy90ps5l3b1y1b", new DateTime(2019, 10, 6, 17, 57, 22, 972, DateTimeKind.Unspecified).AddTicks(221), new DateTime(2017, 2, 10, 16, 13, 25, 631, DateTimeKind.Unspecified).AddTicks(9026), 1, new DateTime(2020, 5, 7, 13, 18, 27, 586, DateTimeKind.Unspecified).AddTicks(3376), 6L },
                    { 108L, 136.02m, new DateTime(2022, 12, 16, 18, 30, 45, 629, DateTimeKind.Unspecified).AddTicks(1595), false, "r4im89p8kap58jd0", new DateTime(2022, 4, 11, 20, 24, 48, 639, DateTimeKind.Unspecified).AddTicks(8431), new DateTime(2022, 1, 2, 10, 2, 4, 516, DateTimeKind.Unspecified).AddTicks(6418), 1, new DateTime(2022, 7, 8, 5, 8, 59, 693, DateTimeKind.Unspecified).AddTicks(5008), 10L },
                    { 109L, 91.86m, new DateTime(2023, 8, 19, 1, 49, 11, 335, DateTimeKind.Unspecified).AddTicks(4472), false, "9l7e2zypb364i3jv", new DateTime(2023, 5, 21, 16, 17, 28, 428, DateTimeKind.Unspecified).AddTicks(8748), new DateTime(2022, 7, 31, 2, 14, 10, 235, DateTimeKind.Unspecified).AddTicks(1516), 3, new DateTime(2023, 7, 11, 7, 11, 43, 859, DateTimeKind.Unspecified).AddTicks(1628), 35L },
                    { 110L, 136.02m, new DateTime(2023, 8, 9, 4, 3, 3, 308, DateTimeKind.Unspecified).AddTicks(754), true, "p45radwg6kdm2a5k", new DateTime(2023, 4, 4, 13, 45, 53, 893, DateTimeKind.Unspecified).AddTicks(8268), new DateTime(2023, 3, 13, 14, 47, 49, 324, DateTimeKind.Unspecified).AddTicks(6213), 1, new DateTime(2023, 4, 23, 13, 54, 27, 561, DateTimeKind.Unspecified).AddTicks(7283), 14L }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[,]
                {
                    { 1L, 59L, "Doloribus modi voluptatum facere eius rerum provident nemo soluta quidem.", new DateTime(2023, 7, 20, 18, 24, 58, 702, DateTimeKind.Unspecified).AddTicks(6724), 12L, "Eos quae aliquid qui est sit quidem doloribus.", 2, 1 },
                    { 2L, 38L, "Est aut repellendus qui fugit.", new DateTime(2022, 5, 28, 4, 9, 15, 141, DateTimeKind.Unspecified).AddTicks(1544), 4L, "Iusto aut nesciunt modi et quibusdam.", 3, 0 },
                    { 3L, 8L, "Omnis inventore velit.\nMaxime fuga fugiat eos.\nAdipisci id dolores et fugit vero vitae.", new DateTime(2023, 3, 29, 11, 6, 15, 818, DateTimeKind.Unspecified).AddTicks(5643), 8L, "Consequuntur alias ipsam quo alias et quisquam voluptates.", 1, 0 },
                    { 4L, 21L, "Nam omnis est magnam rerum eum repudiandae minima tenetur quis. Reprehenderit accusamus dolore est ratione maiores. Et perspiciatis sequi minima pariatur dignissimos eum. Dolorum qui cum voluptatibus quibusdam corporis saepe dolores. Error magni eum dolore minima amet. Temporibus esse magni nihil est officiis ducimus aut dolorem sit.", new DateTime(2023, 1, 27, 11, 9, 37, 841, DateTimeKind.Unspecified).AddTicks(2566), 16L, "Et vel voluptatum quia quia nesciunt sequi impedit.", 1, 3 },
                    { 5L, 43L, "Et id nulla nesciunt. Nesciunt minima cupiditate. Dolore corrupti iusto ipsam sapiente. Maxime alias nam.", new DateTime(2023, 7, 22, 13, 8, 31, 923, DateTimeKind.Unspecified).AddTicks(7060), 24L, "Accusamus magnam quia laudantium id.", 4, 0 },
                    { 6L, 59L, "Corporis illum molestiae hic et officiis accusantium nostrum. Aut et error itaque animi eveniet ut delectus voluptates dolorem. Laudantium itaque sequi officiis sapiente et.", new DateTime(2022, 5, 3, 22, 56, 41, 543, DateTimeKind.Unspecified).AddTicks(5702), 7L, "Et pariatur sapiente.", 2, 1 },
                    { 7L, 57L, "Non porro impedit.", new DateTime(2021, 12, 15, 13, 4, 21, 420, DateTimeKind.Unspecified).AddTicks(6358), 27L, "Blanditiis quidem earum tempore molestias.", 3, 2 },
                    { 8L, 53L, "Sit molestiae adipisci repellat eum vel dolorum aut ullam distinctio.\nOmnis animi officiis tenetur.", new DateTime(2019, 7, 7, 8, 18, 46, 36, DateTimeKind.Unspecified).AddTicks(6560), 15L, "Fugit mollitia aut ab eum est quaerat consequatur.", 3, 1 },
                    { 9L, 27L, "qui", new DateTime(2022, 4, 30, 22, 6, 39, 61, DateTimeKind.Unspecified).AddTicks(8227), 1L, "Dolore possimus quisquam optio veniam.", 4, 2 },
                    { 10L, 3L, "unde", new DateTime(2023, 3, 24, 13, 24, 23, 482, DateTimeKind.Unspecified).AddTicks(8040), 34L, "Sit repellendus cupiditate quo quo doloribus.", 2, 3 },
                    { 11L, 16L, "Soluta est libero voluptatum ullam unde libero dolorem voluptatem et.", new DateTime(2023, 2, 12, 2, 0, 34, 58, DateTimeKind.Unspecified).AddTicks(9517), 9L, "Officiis eos molestias explicabo.", 1, 1 },
                    { 12L, 51L, "omnis", new DateTime(2023, 8, 23, 3, 7, 16, 775, DateTimeKind.Unspecified).AddTicks(2907), 35L, "Modi eaque iusto commodi.", 4, 3 },
                    { 13L, 38L, "Voluptatem et veniam iusto rerum.", new DateTime(2021, 11, 10, 18, 37, 33, 931, DateTimeKind.Unspecified).AddTicks(3898), 14L, "Culpa maiores officiis deleniti cumque similique optio et sed ab.", 3, 0 },
                    { 14L, 43L, "Nihil officia minima quae id occaecati quod.", new DateTime(2023, 8, 6, 14, 34, 38, 798, DateTimeKind.Unspecified).AddTicks(105), 7L, "Totam expedita hic vel sint rerum earum facilis.", 3, 0 },
                    { 15L, 51L, "Itaque quidem debitis nisi voluptate. Placeat facere omnis ea quia ea voluptatibus id laborum. Consequatur iure nisi voluptatem temporibus.", new DateTime(2023, 5, 19, 14, 17, 30, 643, DateTimeKind.Unspecified).AddTicks(1258), 19L, "Ipsa sequi voluptatum qui.", 3, 2 },
                    { 16L, 65L, "Recusandae rerum dolor assumenda maiores placeat magnam debitis.\nFacilis velit et qui totam et iusto consequatur ut.", new DateTime(2020, 11, 27, 4, 17, 7, 808, DateTimeKind.Unspecified).AddTicks(1258), 35L, "Et expedita dignissimos et neque atque aut.", 2, 0 },
                    { 17L, 28L, "Perspiciatis dolorum architecto placeat. Eum aut repellendus laudantium est cumque velit. Voluptatum fugiat aut. Est voluptatum natus sed qui. Inventore beatae totam et necessitatibus velit. Et pariatur voluptas veniam rerum.", new DateTime(2022, 3, 12, 19, 14, 1, 759, DateTimeKind.Unspecified).AddTicks(207), 35L, "Nulla explicabo suscipit molestiae perferendis.", 1, 1 },
                    { 18L, 7L, "Quis dignissimos ipsam et in dolores perferendis.", new DateTime(2022, 11, 30, 23, 54, 51, 68, DateTimeKind.Unspecified).AddTicks(950), 37L, "Dolorum praesentium blanditiis quia commodi non quis voluptatem.", 3, 1 },
                    { 19L, 24L, "Ab at at dolorem qui nobis doloremque.\nQuo aliquam omnis et illo voluptas culpa ea ducimus ea.\nEt eum est est neque qui.\nVoluptatem unde voluptatem non.\nDolor et dolor molestias et officia.", new DateTime(2021, 9, 1, 22, 42, 10, 758, DateTimeKind.Unspecified).AddTicks(5446), 5L, "Et at iusto illum.", 2, 2 },
                    { 20L, 67L, "Vitae eligendi consequatur laboriosam commodi atque.\nDolor eos est repellat enim aliquam ratione.", new DateTime(2023, 8, 22, 2, 55, 17, 973, DateTimeKind.Unspecified).AddTicks(4117), 31L, "Voluptas et quis voluptatem autem voluptas ducimus maiores praesentium odit.", 4, 0 },
                    { 21L, 29L, "Rerum recusandae cum et officia odit aliquid saepe corrupti. Aliquid dolorum iste quia voluptatibus dolores nostrum ab quia dolor. Doloremque odio suscipit animi recusandae quo voluptatem odio.", new DateTime(2023, 6, 16, 1, 10, 32, 164, DateTimeKind.Unspecified).AddTicks(1551), 11L, "Est recusandae aliquam provident molestiae.", 2, 1 },
                    { 22L, 58L, "Cumque sint tenetur sed et.", new DateTime(2023, 7, 14, 16, 12, 11, 815, DateTimeKind.Unspecified).AddTicks(2477), 10L, "Non aspernatur recusandae soluta ratione quibusdam et totam voluptatem.", 4, 0 },
                    { 23L, 25L, "qui", new DateTime(2023, 1, 26, 5, 7, 8, 458, DateTimeKind.Unspecified).AddTicks(3782), 14L, "Laboriosam totam expedita reprehenderit sed blanditiis.", 4, 3 },
                    { 24L, 38L, "Natus esse sint magnam incidunt velit adipisci voluptatem.", new DateTime(2020, 5, 20, 19, 46, 49, 163, DateTimeKind.Unspecified).AddTicks(6640), 10L, "Ea consequatur aut.", 1, 2 },
                    { 25L, 24L, "Ut vitae aut molestias. Expedita provident ex beatae nihil numquam nihil adipisci consequatur. Dolor quae sit consequuntur. Esse et veniam saepe nisi eius. Labore aut aut molestiae quaerat iure voluptatem exercitationem ut. Doloremque facere similique molestiae error.", new DateTime(2022, 8, 27, 22, 52, 21, 702, DateTimeKind.Unspecified).AddTicks(6973), 25L, "Iusto possimus laudantium accusantium possimus mollitia totam blanditiis odio corrupti.", 2, 0 },
                    { 26L, 13L, "Doloribus dolorem et accusamus nostrum aliquam aut repellat tenetur.", new DateTime(2022, 2, 5, 23, 46, 32, 279, DateTimeKind.Unspecified).AddTicks(9831), 37L, "Voluptas tempore reprehenderit nesciunt et dignissimos omnis.", 1, 2 },
                    { 27L, 60L, "Facilis quod expedita adipisci voluptates molestiae qui ut qui rerum. Perferendis iusto ea et quia. Harum nemo aliquam suscipit exercitationem error iure rerum. Et autem culpa nemo delectus voluptates.", new DateTime(2023, 8, 4, 22, 55, 54, 993, DateTimeKind.Unspecified).AddTicks(7981), 17L, "In iste voluptatum.", 1, 1 },
                    { 28L, 39L, "Sequi blanditiis vero.", new DateTime(2021, 2, 20, 16, 26, 23, 931, DateTimeKind.Unspecified).AddTicks(328), 25L, "Vel dolorem occaecati minus natus explicabo repudiandae optio.", 4, 0 },
                    { 29L, 69L, "nobis", new DateTime(2023, 6, 13, 3, 59, 15, 882, DateTimeKind.Unspecified).AddTicks(4065), 40L, "Ut enim atque amet.", 1, 1 },
                    { 30L, 12L, "Minus id minus rem voluptatum amet.", new DateTime(2023, 6, 16, 3, 9, 29, 726, DateTimeKind.Unspecified).AddTicks(7132), 6L, "Odio ratione voluptatem.", 4, 0 },
                    { 31L, 37L, "Consequatur eveniet quidem enim quae voluptatum fugit error. Aut veritatis quo nemo fugiat deserunt veritatis ad. Et nihil autem.", new DateTime(2022, 4, 13, 23, 19, 8, 29, DateTimeKind.Unspecified).AddTicks(1533), 40L, "Commodi perferendis ut.", 1, 0 },
                    { 32L, 44L, "Quam iste aliquam ex repudiandae atque beatae odit excepturi.", new DateTime(2023, 3, 6, 19, 37, 36, 3, DateTimeKind.Unspecified).AddTicks(3353), 13L, "At maiores aut aliquid perferendis adipisci odio expedita.", 4, 2 },
                    { 33L, 37L, "Voluptas corrupti voluptas quaerat in minus provident.", new DateTime(2021, 4, 18, 3, 23, 45, 267, DateTimeKind.Unspecified).AddTicks(5996), 8L, "Vel ut repudiandae et.", 1, 3 },
                    { 34L, 43L, "Repudiandae voluptatum quod sit voluptas nobis. Magni harum expedita non. Voluptatibus tempora explicabo quasi esse aspernatur. Facere perspiciatis inventore asperiores hic. Nostrum dicta rerum omnis voluptatem consectetur.", new DateTime(2023, 8, 16, 22, 28, 49, 656, DateTimeKind.Unspecified).AddTicks(2717), 29L, "At praesentium ea ut.", 1, 3 },
                    { 35L, 35L, "Omnis iure rerum magnam perspiciatis necessitatibus et vero deleniti autem. Eaque animi ut consequatur laborum laudantium quos. Inventore cupiditate labore voluptas officia neque ducimus aliquam eos. Dolores est tempore doloremque aspernatur consequuntur autem beatae.", new DateTime(2023, 7, 5, 13, 58, 45, 67, DateTimeKind.Unspecified).AddTicks(2011), 1L, "Dolorem recusandae necessitatibus dolores ea velit vero laboriosam.", 4, 2 },
                    { 36L, 60L, "et", new DateTime(2022, 8, 11, 6, 54, 11, 887, DateTimeKind.Unspecified).AddTicks(8435), 8L, "Hic dolore eveniet nostrum voluptatem.", 2, 3 },
                    { 37L, 38L, "Et consequatur et eius.", new DateTime(2018, 3, 16, 17, 12, 36, 641, DateTimeKind.Unspecified).AddTicks(3078), 1L, "Veritatis ex sunt aspernatur quidem voluptas non.", 4, 2 },
                    { 38L, 51L, "Sequi aut aut nulla quod.", new DateTime(2022, 12, 24, 21, 46, 41, 825, DateTimeKind.Unspecified).AddTicks(351), 26L, "Cum et autem.", 4, 3 },
                    { 39L, 66L, "Laboriosam saepe temporibus non ipsa ut accusamus voluptas eos.\nRepellendus expedita est perferendis.", new DateTime(2022, 1, 9, 20, 54, 25, 268, DateTimeKind.Unspecified).AddTicks(6305), 27L, "Quisquam at reprehenderit beatae magnam.", 4, 2 },
                    { 40L, 52L, "Temporibus quae fugiat.\nConsequatur quis commodi ipsum veritatis in officiis.\nAt cum nulla rerum fuga impedit doloremque qui unde deserunt.\nEt aliquid ratione quisquam molestiae.\nCommodi qui velit incidunt nulla.", new DateTime(2023, 3, 15, 1, 31, 12, 631, DateTimeKind.Unspecified).AddTicks(7857), 4L, "Quam consectetur ipsum et et soluta vel.", 2, 3 },
                    { 41L, 14L, "Sit libero inventore odit facilis nesciunt.", new DateTime(2022, 5, 31, 0, 56, 50, 735, DateTimeKind.Unspecified).AddTicks(9651), 17L, "In ea animi autem qui dolores.", 2, 3 },
                    { 42L, 50L, "quia", new DateTime(2022, 8, 24, 22, 58, 33, 548, DateTimeKind.Unspecified).AddTicks(2156), 35L, "Est odio vero optio consequuntur tempore est consequatur nemo.", 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[,]
                {
                    { 43L, 68L, "autem", new DateTime(2022, 8, 17, 19, 44, 29, 217, DateTimeKind.Unspecified).AddTicks(7951), 33L, "Rem cumque at consequatur tempora et facilis corporis ut iste.", 1, 1 },
                    { 44L, 48L, "Et veniam veniam quia nemo cumque.\nAb nihil sed non qui omnis.\nEt harum dolores.\nOptio quisquam omnis est.", new DateTime(2022, 9, 12, 18, 12, 28, 407, DateTimeKind.Unspecified).AddTicks(5596), 33L, "Dolores quas ut nam illo consequatur sit amet repudiandae.", 3, 0 },
                    { 45L, 35L, "autem", new DateTime(2023, 8, 12, 4, 19, 33, 731, DateTimeKind.Unspecified).AddTicks(8985), 4L, "Deleniti eaque doloribus.", 4, 3 },
                    { 46L, 13L, "Ab est pariatur autem pariatur nostrum unde animi. Et illo ea. Iure unde fugit animi quo et dolorem.", new DateTime(2021, 9, 28, 13, 35, 52, 884, DateTimeKind.Unspecified).AddTicks(1915), 40L, "Quisquam quam aspernatur vel animi nostrum molestias necessitatibus.", 3, 1 },
                    { 47L, 4L, "Eius dolore repellat sunt velit labore dolores nulla nesciunt libero. Cupiditate doloribus ab. Et ab enim consequatur. Debitis quis officiis quos. Saepe voluptate quia ut culpa ut. Autem in sit accusamus animi maxime molestiae.", new DateTime(2022, 7, 5, 1, 21, 51, 850, DateTimeKind.Unspecified).AddTicks(1601), 13L, "Qui eos reprehenderit culpa sint impedit.", 3, 1 },
                    { 48L, 49L, "Atque dolorum odit non quis molestias.\nCorporis fugiat quis nemo culpa voluptatem omnis minus.\nQuisquam nemo corporis corporis rerum dolor sed.\nSapiente error dolore praesentium quos quia asperiores.\nImpedit tenetur voluptatem ipsum nostrum in dolores explicabo quae.\nFacere possimus sit maxime.", new DateTime(2023, 3, 31, 3, 8, 36, 453, DateTimeKind.Unspecified).AddTicks(8089), 33L, "Recusandae ea dicta numquam.", 4, 0 },
                    { 49L, 22L, "Odio officiis consequatur non natus. Voluptatem vel non quaerat omnis. Ea provident eius. Iste quaerat cum a dicta et ratione. Ipsam libero id iusto nobis fugiat.", new DateTime(2023, 6, 29, 21, 18, 28, 985, DateTimeKind.Unspecified).AddTicks(769), 19L, "Consequatur error molestias nihil quas omnis delectus consequatur quaerat labore.", 4, 0 },
                    { 50L, 27L, "Maxime ut cumque.\nDolores unde non earum qui et non saepe natus rerum.", new DateTime(2023, 2, 11, 8, 8, 10, 372, DateTimeKind.Unspecified).AddTicks(9053), 18L, "Fuga neque quidem excepturi ipsa explicabo nesciunt nemo placeat.", 1, 1 },
                    { 51L, 23L, "Porro est qui magni eum dolor optio.\nQuidem qui cumque hic maxime.\nNesciunt delectus omnis vero corporis eveniet et et in quis.\nEa ut quidem eius animi.\nTempora in consequatur voluptas velit cum dolore dolorum ut vitae.", new DateTime(2023, 7, 25, 8, 38, 7, 883, DateTimeKind.Unspecified).AddTicks(5120), 10L, "Tenetur ut hic qui dolorum dolorem repudiandae doloribus laboriosam quo.", 3, 0 },
                    { 52L, 15L, "dolorem", new DateTime(2021, 5, 4, 12, 8, 39, 790, DateTimeKind.Unspecified).AddTicks(2379), 2L, "Non possimus voluptatem natus voluptatibus iure quod veniam et nostrum.", 2, 0 },
                    { 53L, 34L, "Ut eaque vel animi placeat adipisci eaque.", new DateTime(2023, 4, 5, 22, 37, 54, 114, DateTimeKind.Unspecified).AddTicks(8270), 36L, "Rem autem vel aut sapiente.", 4, 3 },
                    { 54L, 36L, "consectetur", new DateTime(2022, 5, 2, 15, 2, 11, 372, DateTimeKind.Unspecified).AddTicks(8776), 7L, "Voluptates voluptas fugiat.", 4, 1 },
                    { 55L, 8L, "Aut quibusdam minus doloremque maxime aliquid. Nobis ut explicabo consequuntur delectus maiores blanditiis sit quo asperiores. Harum ut ullam et ab.", new DateTime(2023, 4, 25, 16, 15, 34, 515, DateTimeKind.Unspecified).AddTicks(451), 40L, "Laborum veniam hic.", 4, 0 },
                    { 56L, 10L, "In quis vel iure blanditiis dolorem mollitia quo est quis.", new DateTime(2018, 7, 12, 17, 41, 10, 520, DateTimeKind.Unspecified).AddTicks(6663), 8L, "Totam dolore voluptatem repellendus doloribus et beatae laudantium aut neque.", 3, 2 },
                    { 57L, 55L, "Et aut autem maiores sit qui et eveniet harum labore. Est sint iure tenetur numquam dolor. Quia dolore temporibus rem suscipit excepturi dicta quas.", new DateTime(2023, 8, 21, 12, 41, 11, 156, DateTimeKind.Unspecified).AddTicks(9084), 35L, "Tenetur molestiae distinctio commodi dolores optio iusto pariatur.", 1, 2 },
                    { 58L, 38L, "Unde molestias natus ad quod. Dolor atque quaerat quia quod recusandae quia voluptas assumenda et. Soluta sit at velit repellendus ad accusamus autem facere deserunt. Illum aut modi quia. Quos molestiae dolorem hic consequatur. Voluptatem mollitia eius deserunt possimus repellendus laboriosam a laudantium.", new DateTime(2023, 7, 12, 15, 58, 51, 198, DateTimeKind.Unspecified).AddTicks(7660), 30L, "Ad dolorem autem minus in ullam quam.", 4, 1 },
                    { 59L, 2L, "Eum sapiente libero vel voluptatibus et deserunt porro ea earum.\nSunt sint accusamus aliquam reiciendis consectetur sint dicta eaque autem.\nAliquam minima atque atque.\nQuis reprehenderit neque mollitia.\nRepudiandae est assumenda harum omnis.\nOmnis dolorem placeat et.", new DateTime(2023, 6, 13, 14, 58, 23, 274, DateTimeKind.Unspecified).AddTicks(8279), 13L, "Aut omnis incidunt.", 1, 2 },
                    { 60L, 46L, "Adipisci aliquam impedit iure saepe dolores voluptatum corporis voluptas.\nUt expedita dolor qui.\nDolorum molestiae reiciendis.\nSint quis omnis et incidunt distinctio dolor distinctio.\nQuos ut deserunt.", new DateTime(2023, 5, 3, 10, 3, 17, 369, DateTimeKind.Unspecified).AddTicks(7367), 24L, "Quibusdam quia sunt.", 4, 0 },
                    { 61L, 5L, "Eligendi mollitia aut est.\nRerum amet voluptatum qui porro fugiat dignissimos.", new DateTime(2022, 12, 20, 8, 7, 29, 101, DateTimeKind.Unspecified).AddTicks(9706), 19L, "Neque voluptatem minima eligendi ducimus repudiandae dolorem tempore delectus consequuntur.", 4, 2 },
                    { 62L, 70L, "Voluptas quidem labore iste.\nIllo maiores sit ipsam sunt repellat et delectus.\nItaque voluptas ducimus iusto id dignissimos.\nHarum vero dolor sed.", new DateTime(2023, 7, 8, 20, 28, 30, 383, DateTimeKind.Unspecified).AddTicks(2353), 17L, "Error officia optio ut.", 4, 0 },
                    { 63L, 36L, "Pariatur nihil et atque est error ipsa facilis. Voluptatem dolore eum illo voluptatem reiciendis quia. Inventore ex minus illo accusamus mollitia fugiat ratione veritatis.", new DateTime(2022, 10, 12, 12, 40, 36, 800, DateTimeKind.Unspecified).AddTicks(159), 38L, "Itaque excepturi praesentium qui alias hic.", 2, 2 },
                    { 64L, 7L, "Corrupti neque ut mollitia aut.\nDeleniti cupiditate modi necessitatibus error corporis.\nVoluptatibus eum libero laboriosam officia dolorem sed.\nEst rerum porro et fugit molestiae sequi quasi velit cupiditate.\nVel cumque vel iusto mollitia unde dolor et.\nTempora porro atque.", new DateTime(2023, 8, 21, 10, 40, 33, 979, DateTimeKind.Unspecified).AddTicks(9806), 25L, "In itaque deserunt dolorem dolores quis provident.", 4, 1 },
                    { 65L, 35L, "Dolorem voluptas veritatis voluptas qui vel consequatur.", new DateTime(2023, 2, 11, 15, 47, 14, 678, DateTimeKind.Unspecified).AddTicks(3300), 24L, "Aperiam rerum rem eum blanditiis et.", 4, 3 },
                    { 66L, 47L, "In possimus sit temporibus vel nesciunt id autem culpa et.\nEt in nesciunt beatae vel velit.\nOptio omnis et sed aut est esse perferendis animi.\nLabore sed quia accusamus temporibus eum.\nOmnis fugiat reiciendis dolore dolorem pariatur iusto repellendus laborum.", new DateTime(2023, 8, 19, 17, 47, 12, 499, DateTimeKind.Unspecified).AddTicks(6964), 10L, "Autem voluptate voluptatem.", 1, 0 },
                    { 67L, 21L, "Et natus sed dolores ipsa.\nIste blanditiis placeat.\nVoluptatem perspiciatis iusto mollitia provident.\nRem sit et unde placeat doloribus consequatur voluptate eum perspiciatis.\nIllo eveniet omnis deserunt sed aut est dignissimos id.", new DateTime(2022, 9, 11, 14, 57, 12, 957, DateTimeKind.Unspecified).AddTicks(7617), 24L, "Asperiores quam illum necessitatibus et veniam.", 3, 2 },
                    { 68L, 1L, "Sapiente mollitia hic ratione quia.\nConsequatur consectetur quibusdam nemo et et et.\nMaiores eligendi velit iusto eum voluptatem molestiae.\nIpsum officia et quae sed.\nNihil minus sapiente voluptatibus delectus est recusandae neque.\nAut recusandae maiores harum esse nulla doloribus dolore.", new DateTime(2022, 6, 16, 8, 21, 19, 866, DateTimeKind.Unspecified).AddTicks(7257), 12L, "Enim rerum tempore et.", 2, 2 },
                    { 69L, 25L, "Magni dicta explicabo assumenda.", new DateTime(2023, 6, 24, 10, 25, 9, 562, DateTimeKind.Unspecified).AddTicks(5600), 12L, "Et qui tempore ex cum molestiae.", 1, 2 },
                    { 70L, 12L, "Laboriosam officia ipsa debitis.", new DateTime(2023, 5, 22, 10, 20, 40, 440, DateTimeKind.Unspecified).AddTicks(3047), 22L, "Qui illo tempora et nulla sint molestias.", 2, 1 },
                    { 71L, 38L, "Est repellendus est qui illo ad aperiam. Velit et non rerum sequi nulla. Dolore voluptatem quidem dicta. Distinctio mollitia et consequatur. Maiores enim commodi dicta omnis. Optio earum reiciendis eos et provident.", new DateTime(2023, 6, 14, 19, 9, 26, 386, DateTimeKind.Unspecified).AddTicks(2816), 34L, "Quam quaerat id ad placeat.", 3, 3 },
                    { 72L, 30L, "Maiores quo totam.\nDelectus tempore vel.\nVoluptas incidunt earum dolor maiores qui.\nVelit aut voluptatem ea eligendi et repellendus sed.\nNulla id laboriosam deserunt cupiditate commodi voluptatibus magnam explicabo consequatur.\nOptio ratione praesentium aut ipsum officia unde magnam.", new DateTime(2022, 5, 7, 0, 24, 0, 527, DateTimeKind.Unspecified).AddTicks(5954), 24L, "Sit id consequatur eos sunt voluptatem quos aliquam fugit porro.", 2, 3 },
                    { 73L, 56L, "tempora", new DateTime(2022, 9, 7, 6, 52, 43, 209, DateTimeKind.Unspecified).AddTicks(9046), 17L, "Voluptas perferendis qui sit amet nihil sed harum similique.", 2, 3 },
                    { 74L, 59L, "beatae", new DateTime(2022, 4, 6, 9, 4, 58, 264, DateTimeKind.Unspecified).AddTicks(388), 36L, "Vitae quia repudiandae perferendis ut rerum sint amet.", 3, 1 },
                    { 75L, 57L, "in", new DateTime(2019, 5, 7, 6, 39, 38, 495, DateTimeKind.Unspecified).AddTicks(2741), 34L, "Consequatur soluta aliquid qui sint et iure totam veritatis in.", 4, 2 },
                    { 76L, 57L, "nisi", new DateTime(2019, 2, 6, 23, 35, 54, 451, DateTimeKind.Unspecified).AddTicks(3386), 14L, "Aut velit cupiditate voluptas in quis aut qui.", 3, 0 },
                    { 77L, 8L, "Est ea itaque ut ullam molestiae nobis cumque maxime repellat. Autem quae aut reiciendis nihil est qui ipsa. Quaerat atque necessitatibus et voluptate eum iusto autem laudantium. Impedit fuga beatae illum necessitatibus ut earum autem temporibus repudiandae.", new DateTime(2022, 8, 8, 15, 56, 5, 744, DateTimeKind.Unspecified).AddTicks(6421), 14L, "Aut numquam illo distinctio omnis quia.", 4, 1 },
                    { 78L, 69L, "Maxime est eligendi quia sint. Earum totam asperiores saepe labore temporibus. Fugit ullam incidunt numquam consequatur.", new DateTime(2023, 7, 22, 14, 57, 41, 740, DateTimeKind.Unspecified).AddTicks(1577), 6L, "Non fugit beatae.", 4, 0 },
                    { 79L, 6L, "Molestias hic ex debitis molestiae quia nobis qui. At voluptatem sint sunt et natus inventore. Possimus cumque eveniet quasi. Accusantium voluptatem et fugiat.", new DateTime(2023, 8, 20, 7, 38, 19, 167, DateTimeKind.Unspecified).AddTicks(908), 12L, "Magni ut nesciunt aliquid.", 3, 3 },
                    { 80L, 19L, "provident", new DateTime(2022, 9, 3, 23, 21, 49, 541, DateTimeKind.Unspecified).AddTicks(8845), 29L, "Tempore quia qui voluptas non ut accusamus.", 3, 0 },
                    { 81L, 10L, "Eaque quaerat deserunt deserunt est voluptatum modi quaerat placeat et.", new DateTime(2023, 7, 27, 21, 1, 43, 692, DateTimeKind.Unspecified).AddTicks(9679), 6L, "Exercitationem sunt deleniti recusandae deserunt velit nihil facilis.", 4, 2 },
                    { 82L, 63L, "Alias quis magnam provident quam.", new DateTime(2023, 4, 23, 17, 21, 56, 161, DateTimeKind.Unspecified).AddTicks(2797), 12L, "Mollitia consequatur sint itaque ut animi voluptate fugit labore quas.", 4, 3 },
                    { 83L, 10L, "Magni autem sit.\nAt deleniti aliquid odit voluptatibus debitis.\nAutem asperiores eum quo quibusdam.\nAut est vitae ducimus.\nUt eaque harum dignissimos nemo architecto.", new DateTime(2022, 3, 13, 12, 34, 56, 267, DateTimeKind.Unspecified).AddTicks(2493), 12L, "Beatae aperiam et ut delectus aut neque at aliquid rerum.", 3, 1 },
                    { 84L, 57L, "et", new DateTime(2021, 9, 17, 20, 27, 48, 516, DateTimeKind.Unspecified).AddTicks(6011), 7L, "In ipsa ut qui.", 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[,]
                {
                    { 85L, 31L, "Voluptatum voluptatibus aut voluptate ipsum minima blanditiis voluptas.\nA est quibusdam voluptatibus tempore saepe.\nRerum consequatur sint harum nisi maxime et ipsa rem.\nEt mollitia accusantium laudantium sed dolore officia impedit similique et.\nPorro et rerum ea aliquam cum est maiores.", new DateTime(2022, 11, 3, 3, 51, 43, 364, DateTimeKind.Unspecified).AddTicks(3128), 7L, "Ut quam ducimus illo fugit recusandae explicabo.", 1, 3 },
                    { 86L, 26L, "Omnis voluptas itaque quis est vero illum sit.", new DateTime(2021, 5, 12, 13, 17, 4, 182, DateTimeKind.Unspecified).AddTicks(8927), 11L, "Veniam id aut.", 4, 0 },
                    { 87L, 55L, "Iusto eligendi esse sint facilis laborum ea quo quis.", new DateTime(2023, 7, 27, 4, 40, 47, 187, DateTimeKind.Unspecified).AddTicks(2800), 10L, "Eos ipsum sit aperiam ad dicta quasi dolor inventore ullam.", 4, 1 },
                    { 88L, 8L, "adipisci", new DateTime(2022, 6, 25, 11, 2, 55, 537, DateTimeKind.Unspecified).AddTicks(3031), 29L, "Distinctio saepe dolorum delectus neque tempore.", 4, 2 },
                    { 89L, 29L, "Repudiandae ut animi quaerat reprehenderit voluptas et. Est voluptate rerum iusto sit veniam dolor magnam et. Illum architecto repudiandae explicabo quia id ipsum. Et et beatae ipsam. Inventore ut quis.", new DateTime(2023, 4, 28, 6, 23, 30, 692, DateTimeKind.Unspecified).AddTicks(7547), 38L, "Assumenda impedit quidem quo et quam quia animi.", 1, 2 },
                    { 90L, 46L, "Iste fuga ipsum fuga inventore.", new DateTime(2023, 1, 26, 2, 48, 47, 736, DateTimeKind.Unspecified).AddTicks(2367), 33L, "Voluptas molestiae laborum magnam aut.", 1, 2 },
                    { 91L, 40L, "assumenda", new DateTime(2021, 11, 26, 8, 9, 36, 472, DateTimeKind.Unspecified).AddTicks(227), 23L, "Dicta magnam laboriosam consequatur optio suscipit aliquid eum provident sapiente.", 3, 0 },
                    { 92L, 31L, "quaerat", new DateTime(2023, 6, 19, 1, 7, 15, 427, DateTimeKind.Unspecified).AddTicks(3353), 24L, "Atque et quisquam eveniet quo rerum consequatur et est repellat.", 3, 1 },
                    { 93L, 45L, "Nisi occaecati at molestias veritatis alias laudantium suscipit. Suscipit ipsum minima consectetur esse reprehenderit natus temporibus. Aliquid autem ad ut est blanditiis architecto impedit.", new DateTime(2021, 11, 14, 13, 34, 55, 744, DateTimeKind.Unspecified).AddTicks(753), 31L, "Et qui incidunt minima.", 4, 3 },
                    { 94L, 37L, "In fuga repellat sunt et alias sunt ratione enim distinctio.", new DateTime(2022, 7, 6, 10, 35, 32, 808, DateTimeKind.Unspecified).AddTicks(7313), 18L, "Libero sequi quos.", 4, 3 },
                    { 95L, 66L, "eum", new DateTime(2022, 8, 23, 17, 23, 57, 131, DateTimeKind.Unspecified).AddTicks(2551), 7L, "Quaerat totam beatae voluptates in et ex.", 2, 0 },
                    { 96L, 37L, "Aliquid modi aliquid.", new DateTime(2020, 9, 15, 7, 21, 9, 905, DateTimeKind.Unspecified).AddTicks(6543), 31L, "Molestiae sapiente animi.", 2, 1 },
                    { 97L, 22L, "Nobis velit sint natus delectus enim.\nQuod quas et a asperiores cumque fuga necessitatibus error.\nAb et velit aperiam.\nConsequatur qui dicta.", new DateTime(2023, 5, 30, 9, 23, 29, 414, DateTimeKind.Unspecified).AddTicks(1745), 29L, "Odit beatae ipsam.", 3, 0 },
                    { 98L, 39L, "Non atque nulla sed iste ipsam veritatis nihil.", new DateTime(2023, 6, 21, 21, 59, 50, 556, DateTimeKind.Unspecified).AddTicks(1485), 11L, "Error nobis velit aliquid excepturi ducimus ipsa.", 1, 3 },
                    { 99L, 44L, "Nam sit nesciunt ducimus qui enim et enim autem sed.", new DateTime(2022, 11, 2, 15, 11, 1, 301, DateTimeKind.Unspecified).AddTicks(6267), 27L, "Autem error animi quia rem.", 1, 3 },
                    { 100L, 25L, "dolor", new DateTime(2023, 7, 15, 13, 45, 18, 244, DateTimeKind.Unspecified).AddTicks(8364), 17L, "Est voluptas est id debitis.", 3, 2 },
                    { 101L, 11L, "consequatur", new DateTime(2023, 1, 7, 12, 13, 3, 883, DateTimeKind.Unspecified).AddTicks(3118), 18L, "Voluptates quia sunt consequuntur omnis eos laudantium est facere.", 3, 3 },
                    { 102L, 46L, "harum", new DateTime(2023, 7, 30, 20, 8, 18, 972, DateTimeKind.Unspecified).AddTicks(2316), 32L, "Dicta animi dolorem exercitationem asperiores veniam cumque est.", 4, 0 },
                    { 103L, 5L, "Voluptas ipsa est veniam facere at quo occaecati.\nRepellat quos sint ipsa officiis odio est incidunt dolorum.\nExpedita quis aut.\nLibero quis harum aperiam qui asperiores temporibus id impedit dolores.\nRecusandae facilis commodi aliquid sunt aut eum.\nVitae cum doloribus perspiciatis placeat.", new DateTime(2023, 4, 13, 23, 57, 0, 664, DateTimeKind.Unspecified).AddTicks(1830), 24L, "Atque laudantium autem et dolores sunt consequatur sunt.", 3, 1 },
                    { 104L, 30L, "Voluptatem voluptatem dolor dolor odio earum autem. Aut non tempora ad aspernatur. Quia soluta quod. Quis vitae deserunt non ut nesciunt itaque nostrum minima corrupti. Ex aut voluptatibus consequatur maxime.", new DateTime(2022, 1, 18, 14, 18, 5, 760, DateTimeKind.Unspecified).AddTicks(3486), 31L, "Velit enim expedita nesciunt illo asperiores sed.", 1, 0 },
                    { 105L, 44L, "Ut provident corrupti non consequatur.", new DateTime(2023, 1, 13, 8, 55, 38, 680, DateTimeKind.Unspecified).AddTicks(65), 6L, "Ut beatae cumque itaque quia et non et tenetur.", 4, 3 },
                    { 106L, 6L, "Temporibus rem reiciendis sunt atque vel sint excepturi voluptas quo.", new DateTime(2023, 8, 22, 23, 36, 14, 393, DateTimeKind.Unspecified).AddTicks(775), 22L, "Perferendis cupiditate iste et laudantium.", 1, 2 },
                    { 107L, 11L, "Qui et neque qui sapiente veritatis. Vel beatae praesentium vero. Neque et minima nam quae cum esse ullam. Repellendus eum et perferendis assumenda vitae molestiae qui.", new DateTime(2022, 7, 8, 17, 41, 32, 888, DateTimeKind.Unspecified).AddTicks(1795), 29L, "Id qui voluptatem.", 4, 2 },
                    { 108L, 4L, "Qui quasi ea. In tenetur facere et sunt explicabo magni consectetur. Maxime natus veniam ipsam ipsam hic autem sit eius aliquam. Qui sapiente a porro accusantium ad voluptas doloremque.", new DateTime(2022, 8, 21, 0, 55, 38, 745, DateTimeKind.Unspecified).AddTicks(1813), 30L, "Inventore voluptate nisi at qui laboriosam hic omnis iste tempora.", 2, 2 },
                    { 109L, 42L, "distinctio", new DateTime(2022, 7, 19, 2, 34, 5, 858, DateTimeKind.Unspecified).AddTicks(810), 20L, "Qui omnis et dicta delectus ipsam.", 2, 1 },
                    { 110L, 25L, "Aut autem et qui vel. Illum ipsum consectetur dolor recusandae aliquam earum quos neque corrupti. Sit omnis doloremque recusandae repellat. Quae alias recusandae est tempore impedit voluptas in enim. Veritatis aut accusamus omnis. In in molestiae id voluptas in.", new DateTime(2023, 6, 9, 19, 19, 18, 817, DateTimeKind.Unspecified).AddTicks(1591), 9L, "Doloremque in aut animi illum cumque dolorem iusto asperiores eaque.", 1, 3 },
                    { 111L, 30L, "qui", new DateTime(2021, 7, 27, 18, 29, 28, 728, DateTimeKind.Unspecified).AddTicks(6788), 25L, "Harum nihil modi repellendus voluptatem aut ut officiis eos debitis.", 2, 2 },
                    { 112L, 34L, "Deleniti perferendis possimus. Officiis dicta commodi quod. Eveniet cum enim. Consequatur quis enim quam et blanditiis et asperiores. Consequatur perferendis quisquam hic magnam sit consequuntur hic unde.", new DateTime(2023, 3, 25, 4, 8, 21, 606, DateTimeKind.Unspecified).AddTicks(7235), 30L, "Eum exercitationem recusandae repudiandae possimus aut id adipisci sequi nihil.", 4, 3 },
                    { 113L, 55L, "Ipsam et id dolorum sint velit et.\nFacilis quod esse et quo sit et inventore.", new DateTime(2023, 8, 3, 20, 11, 26, 929, DateTimeKind.Unspecified).AddTicks(442), 36L, "Quis qui provident quod eos autem qui aliquam.", 2, 3 },
                    { 114L, 28L, "Aut omnis sed necessitatibus est et.\nNon molestiae iure architecto.\nArchitecto atque delectus officiis aut optio natus cupiditate ipsam.\nDeleniti est sit.\nNesciunt ex id unde mollitia et quia quia tempore voluptatibus.\nDoloremque amet ipsam velit nulla.", new DateTime(2021, 12, 25, 4, 42, 46, 609, DateTimeKind.Unspecified).AddTicks(3275), 5L, "Error magni quasi et.", 2, 3 },
                    { 115L, 56L, "Impedit nobis impedit pariatur est.", new DateTime(2023, 6, 21, 9, 52, 24, 719, DateTimeKind.Unspecified).AddTicks(8923), 22L, "Animi quaerat ut modi rerum sit magni non.", 2, 0 },
                    { 116L, 34L, "veritatis", new DateTime(2023, 4, 21, 5, 37, 56, 587, DateTimeKind.Unspecified).AddTicks(4611), 14L, "Voluptatibus in omnis molestias et fugit rem dolorum sunt.", 2, 3 },
                    { 117L, 48L, "Est natus labore quae mollitia qui sunt. Eos et nobis corrupti porro cumque eius distinctio. Amet quia facilis quis modi. Ut explicabo quam.", new DateTime(2021, 9, 21, 13, 58, 14, 27, DateTimeKind.Unspecified).AddTicks(551), 3L, "Sapiente debitis beatae quod nihil.", 1, 3 },
                    { 118L, 37L, "Dolorum qui expedita autem expedita quaerat expedita esse.", new DateTime(2021, 3, 19, 12, 13, 17, 180, DateTimeKind.Unspecified).AddTicks(5995), 28L, "Blanditiis consequatur quidem omnis incidunt sunt dolores odio.", 2, 2 },
                    { 119L, 38L, "Inventore aperiam impedit et libero. Quod eligendi rerum voluptatem mollitia id. Est ullam voluptas hic sit quis rerum voluptas repellat est. Magnam vitae voluptatem et ipsam veritatis deserunt omnis dolorem. Animi omnis hic adipisci maiores maiores eligendi dolorem quod. Et dolor sint commodi expedita esse molestiae.", new DateTime(2017, 12, 31, 10, 6, 59, 752, DateTimeKind.Unspecified).AddTicks(6954), 23L, "Totam ut tenetur dolor autem ut.", 4, 0 },
                    { 120L, 67L, "Natus illum omnis ratione aut sed illum possimus doloremque.", new DateTime(2023, 7, 24, 14, 18, 55, 689, DateTimeKind.Unspecified).AddTicks(472), 11L, "Repudiandae vel qui dolorem quia.", 2, 3 },
                    { 121L, 27L, "Ut tempore ut ut et aperiam vel ea. Similique ducimus et ut et consequatur consequatur aliquid sed. Libero at sequi quia harum aut perferendis. Nisi sit ut dolorem rem sit at culpa. Repudiandae rem eaque.", new DateTime(2022, 2, 23, 4, 39, 36, 715, DateTimeKind.Unspecified).AddTicks(4069), 23L, "Rem similique ut a.", 4, 2 },
                    { 122L, 35L, "At vitae laudantium animi minus atque exercitationem aperiam iure iste. Reiciendis id sed eius ut blanditiis. Vitae vel exercitationem incidunt officia eum ratione totam id commodi. Illum porro voluptas dolorem numquam repellat et rerum ipsam id.", new DateTime(2022, 10, 13, 16, 33, 23, 540, DateTimeKind.Unspecified).AddTicks(5704), 10L, "Suscipit ad autem laudantium velit unde.", 3, 1 },
                    { 123L, 48L, "Blanditiis ut maxime recusandae sequi similique quo beatae.\nOccaecati sed quisquam quaerat eos qui cupiditate voluptas hic.\nIn at harum officiis in quia enim architecto ab similique.\nPerspiciatis autem consequatur consequatur eos rem consequatur iste.", new DateTime(2022, 11, 6, 16, 47, 27, 419, DateTimeKind.Unspecified).AddTicks(9881), 36L, "Excepturi mollitia nesciunt nesciunt error maxime libero possimus quos tempore.", 1, 0 },
                    { 124L, 7L, "Neque quisquam harum sint.\nQui reprehenderit dolorem qui voluptas quos temporibus excepturi magni.\nQuod porro aliquam minima libero porro est voluptas ipsam in.\nNon quibusdam sed assumenda consequatur rem occaecati suscipit sint qui.", new DateTime(2022, 7, 29, 18, 33, 3, 359, DateTimeKind.Unspecified).AddTicks(9835), 2L, "Ipsa iusto corporis.", 3, 0 },
                    { 125L, 13L, "Vero sint reprehenderit a voluptatem.\nDolorem necessitatibus mollitia harum a fugiat voluptatem.", new DateTime(2023, 8, 21, 2, 51, 51, 219, DateTimeKind.Unspecified).AddTicks(4749), 7L, "Eum nisi dolor iure iure similique aspernatur corporis.", 2, 2 },
                    { 126L, 7L, "Incidunt quae a ratione nam illum quia eos.\nSimilique qui voluptatem atque consequatur accusamus.\nNesciunt sed non tenetur earum corporis sunt.", new DateTime(2023, 1, 1, 9, 30, 59, 876, DateTimeKind.Unspecified).AddTicks(9000), 18L, "Aperiam labore officia architecto rerum quam dolores perferendis.", 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[,]
                {
                    { 127L, 66L, "Ea dolores nostrum sunt veritatis quidem dicta. Et architecto repudiandae. Saepe ea voluptate possimus molestiae a earum veritatis qui autem. Voluptas et et eos dolorum qui id a. Veniam sint at blanditiis est minus doloremque vel. Nesciunt quis quis fuga sed est eveniet sed qui voluptatum.", new DateTime(2023, 8, 7, 9, 6, 59, 653, DateTimeKind.Unspecified).AddTicks(1326), 9L, "Sit quas aliquam non eveniet in voluptates.", 4, 3 },
                    { 128L, 22L, "Hic odit adipisci non natus veritatis labore.\nCorporis cumque ipsa.\nEt quas odio magni consequatur optio.", new DateTime(2023, 7, 13, 7, 14, 30, 992, DateTimeKind.Unspecified).AddTicks(3017), 26L, "Delectus voluptas repellat dolores laudantium cupiditate praesentium sed veniam.", 2, 3 },
                    { 129L, 68L, "Incidunt reprehenderit ipsum eaque minima voluptatem autem.", new DateTime(2022, 10, 7, 17, 18, 1, 939, DateTimeKind.Unspecified).AddTicks(1782), 21L, "Doloremque rerum provident harum voluptates aliquam.", 4, 3 },
                    { 130L, 5L, "qui", new DateTime(2023, 4, 3, 1, 26, 19, 732, DateTimeKind.Unspecified).AddTicks(861), 13L, "Ut aliquam sapiente dicta sit.", 1, 2 },
                    { 131L, 23L, "At voluptatibus quia porro nisi necessitatibus. Quam fugit quos. Similique unde culpa qui possimus minima dolorem facere. Laborum corrupti consequuntur optio modi commodi necessitatibus totam et.", new DateTime(2023, 8, 6, 21, 45, 1, 506, DateTimeKind.Unspecified).AddTicks(3080), 26L, "Eveniet cum non id sunt ab ea provident modi.", 4, 1 },
                    { 132L, 4L, "cum", new DateTime(2022, 11, 2, 7, 12, 47, 937, DateTimeKind.Unspecified).AddTicks(5834), 3L, "Magni voluptatem molestias quisquam placeat consectetur.", 2, 3 },
                    { 133L, 11L, "Excepturi ea quia tempora earum eos aut perferendis. Est dignissimos alias nam est vel. Est voluptatem enim vel error corporis et quaerat.", new DateTime(2022, 5, 7, 17, 54, 18, 872, DateTimeKind.Unspecified).AddTicks(4514), 5L, "Animi aliquam inventore aspernatur deleniti repellendus commodi at fuga dolores.", 2, 3 },
                    { 134L, 63L, "consectetur", new DateTime(2023, 5, 18, 20, 52, 1, 782, DateTimeKind.Unspecified).AddTicks(3453), 20L, "Perferendis quod placeat sed quos ipsam ut qui.", 2, 0 },
                    { 135L, 47L, "aut", new DateTime(2022, 9, 24, 14, 36, 52, 390, DateTimeKind.Unspecified).AddTicks(3901), 4L, "Vel dolor omnis.", 1, 2 },
                    { 136L, 9L, "Fugit dolores atque eum.", new DateTime(2020, 3, 1, 6, 5, 48, 339, DateTimeKind.Unspecified).AddTicks(4553), 27L, "Sint et temporibus sapiente doloribus quod at possimus cumque.", 1, 3 },
                    { 137L, 39L, "Nam omnis quasi consequuntur.\nVeniam blanditiis voluptatem ut incidunt incidunt.\nVoluptatem magnam est repudiandae voluptas nobis.\nIllo est ratione.", new DateTime(2019, 11, 7, 5, 29, 53, 10, DateTimeKind.Unspecified).AddTicks(5135), 17L, "Facilis quia suscipit.", 4, 2 },
                    { 138L, 3L, "nobis", new DateTime(2023, 1, 25, 18, 38, 46, 884, DateTimeKind.Unspecified).AddTicks(1547), 38L, "Enim quo qui et molestiae animi consectetur voluptatibus et.", 4, 0 },
                    { 139L, 9L, "Voluptatum voluptatem enim laborum quae consectetur dolor.\nDoloribus unde veritatis quod veniam porro repellat ut perferendis atque.\nVoluptatibus nam explicabo saepe.\nUnde perspiciatis ut.\nOfficia sint fugit tempore velit aut est nam natus.", new DateTime(2023, 3, 23, 22, 55, 46, 946, DateTimeKind.Unspecified).AddTicks(6755), 10L, "Iste cupiditate earum exercitationem qui consequatur et expedita molestias corrupti.", 2, 2 },
                    { 140L, 9L, "Exercitationem quibusdam at.", new DateTime(2021, 6, 29, 7, 3, 56, 135, DateTimeKind.Unspecified).AddTicks(9618), 3L, "Reiciendis aut omnis ducimus est et quam.", 2, 0 },
                    { 141L, 18L, "Atque facere omnis non sint.\nAsperiores explicabo optio voluptatem.\nNihil odit autem in.\nVoluptatem sed ea commodi dolorum.", new DateTime(2023, 5, 2, 14, 4, 20, 245, DateTimeKind.Unspecified).AddTicks(384), 20L, "Reiciendis qui quasi iusto reprehenderit ut ipsum quasi suscipit.", 4, 2 },
                    { 142L, 25L, "Sunt at non.\nQuasi voluptate ratione.\nTempora est voluptas perferendis eos repudiandae aut et enim.\nQuod deserunt et aliquam.\nAutem cumque voluptatibus.\nSed fugiat quam sint laudantium error ex dolorem voluptate.", new DateTime(2023, 6, 29, 0, 19, 52, 983, DateTimeKind.Unspecified).AddTicks(7341), 9L, "Aut ad culpa ipsam placeat et.", 2, 1 },
                    { 143L, 23L, "Soluta ut eius perspiciatis quo qui. Nemo sunt officia accusantium repellat aut magni et qui. Placeat qui voluptatum sapiente recusandae provident voluptas vitae ut. Neque tempora aut blanditiis. Quia maiores fugiat natus nisi.", new DateTime(2023, 7, 3, 21, 22, 28, 573, DateTimeKind.Unspecified).AddTicks(3984), 20L, "Veniam nulla numquam rem accusamus commodi.", 4, 2 },
                    { 144L, 49L, "Dicta laborum eum.\nRem placeat quis.\nLaudantium accusamus harum libero beatae reiciendis.", new DateTime(2023, 3, 15, 13, 56, 46, 325, DateTimeKind.Unspecified).AddTicks(1832), 33L, "Dolorum quisquam nihil voluptatum.", 1, 2 },
                    { 145L, 27L, "Quia expedita dolores voluptatum illum quia accusantium nulla a quis. Dicta consectetur delectus ut blanditiis a dolorem. Modi corrupti aperiam facere et quam ipsa repudiandae aut amet. Ab omnis perferendis praesentium aliquam aut autem. At officiis hic nostrum.", new DateTime(2021, 7, 6, 2, 26, 37, 878, DateTimeKind.Unspecified).AddTicks(5192), 9L, "Odit aut nihil aut maiores.", 3, 1 },
                    { 146L, 6L, "Dicta et voluptas illo est nostrum. Expedita eum labore a architecto qui impedit ut vitae et. Dicta enim velit nemo consequatur nisi non non est corrupti. Qui rerum deserunt quas. Ipsum ut provident.", new DateTime(2023, 8, 20, 15, 20, 4, 693, DateTimeKind.Unspecified).AddTicks(9936), 2L, "Fuga delectus nulla neque.", 1, 2 },
                    { 147L, 14L, "aut", new DateTime(2022, 5, 12, 18, 2, 50, 366, DateTimeKind.Unspecified).AddTicks(3938), 10L, "Qui aliquid eos eum et.", 1, 3 },
                    { 148L, 40L, "Optio ut rerum omnis cumque necessitatibus quas.", new DateTime(2023, 8, 16, 16, 55, 23, 238, DateTimeKind.Unspecified).AddTicks(4264), 9L, "Sed dolores nulla nulla occaecati molestiae et et aliquid.", 1, 3 },
                    { 149L, 5L, "Optio quisquam ut consequatur reprehenderit commodi eaque aliquam.", new DateTime(2023, 6, 8, 14, 5, 2, 231, DateTimeKind.Unspecified).AddTicks(4284), 9L, "Perspiciatis laboriosam ea.", 1, 2 },
                    { 150L, 23L, "nam", new DateTime(2023, 7, 17, 14, 15, 20, 742, DateTimeKind.Unspecified).AddTicks(7782), 31L, "Maiores similique est saepe dignissimos sit ut ullam consequatur.", 4, 2 },
                    { 151L, 62L, "Ratione minima excepturi dignissimos expedita dignissimos fuga commodi enim et.\nQuas vero ducimus.\nConsequatur laboriosam in ex ut qui culpa quae provident deleniti.", new DateTime(2023, 1, 7, 8, 25, 38, 856, DateTimeKind.Unspecified).AddTicks(5532), 5L, "Accusantium explicabo delectus expedita.", 4, 2 },
                    { 152L, 45L, "illum", new DateTime(2022, 1, 31, 19, 49, 13, 35, DateTimeKind.Unspecified).AddTicks(3887), 16L, "Nisi ut et maxime.", 4, 3 },
                    { 153L, 35L, "Aperiam maxime similique incidunt voluptatibus.\nEst error ipsa quaerat perspiciatis ullam nam ut inventore nihil.\nAmet iusto possimus iusto necessitatibus nulla aperiam dolorem aperiam.", new DateTime(2022, 10, 15, 8, 57, 17, 536, DateTimeKind.Unspecified).AddTicks(3351), 21L, "Aut dolores enim dignissimos minus et sunt.", 1, 0 },
                    { 154L, 59L, "quia", new DateTime(2022, 8, 8, 14, 13, 5, 807, DateTimeKind.Unspecified).AddTicks(4717), 37L, "Debitis inventore ut.", 4, 3 },
                    { 155L, 60L, "Enim ut consectetur.", new DateTime(2022, 9, 28, 16, 52, 39, 444, DateTimeKind.Unspecified).AddTicks(3870), 36L, "Ipsa repellat qui fugiat aperiam.", 3, 0 },
                    { 156L, 25L, "Labore ducimus quam est alias alias non.", new DateTime(2023, 1, 31, 12, 21, 3, 191, DateTimeKind.Unspecified).AddTicks(8233), 34L, "Rerum facere ut.", 4, 1 },
                    { 157L, 27L, "fugit", new DateTime(2021, 8, 11, 0, 0, 35, 24, DateTimeKind.Unspecified).AddTicks(8288), 4L, "Et eaque culpa sed quia aspernatur sed.", 4, 0 },
                    { 158L, 28L, "tempora", new DateTime(2021, 12, 4, 19, 18, 39, 154, DateTimeKind.Unspecified).AddTicks(5934), 17L, "Accusamus saepe consectetur soluta rerum vel aut omnis.", 1, 2 },
                    { 159L, 9L, "exercitationem", new DateTime(2021, 1, 21, 10, 41, 10, 809, DateTimeKind.Unspecified).AddTicks(6789), 2L, "Distinctio omnis officia aspernatur dolores atque maxime in.", 2, 2 },
                    { 160L, 28L, "Eos quo dolorum eum error non porro molestiae et inventore.", new DateTime(2021, 11, 23, 22, 45, 57, 43, DateTimeKind.Unspecified).AddTicks(5867), 25L, "Nulla rerum maiores blanditiis nemo nesciunt magni maxime repellat corrupti.", 1, 0 },
                    { 161L, 8L, "Iure quas est.", new DateTime(2023, 4, 12, 10, 8, 36, 629, DateTimeKind.Unspecified).AddTicks(5103), 3L, "Provident soluta perferendis quia dolorem consequuntur perspiciatis et.", 4, 0 },
                    { 162L, 49L, "Quod animi nemo optio laborum voluptatum non ipsam rem. Voluptatem perferendis ipsum alias ea. Dolorem non dolor expedita tenetur eos. Vel quia quia reiciendis vitae.", new DateTime(2023, 6, 20, 6, 16, 43, 241, DateTimeKind.Unspecified).AddTicks(8140), 35L, "Nihil tempore ducimus natus voluptas voluptas.", 1, 3 },
                    { 163L, 3L, "Aliquam libero ipsa explicabo et fugit. Facere fugiat animi ad. Occaecati quos dolores consequuntur adipisci repellendus et ullam exercitationem esse. In cum magni voluptatem. Voluptatem dolorem animi unde voluptas facere et.", new DateTime(2023, 6, 16, 8, 14, 6, 938, DateTimeKind.Unspecified).AddTicks(7140), 8L, "Debitis dolorem temporibus eligendi necessitatibus ipsum quidem repellendus sed.", 2, 0 },
                    { 164L, 41L, "Enim ipsam magni voluptas ut laudantium quam consequatur quibusdam.\nQui libero repellat est neque assumenda et.\nDicta ipsum mollitia qui.\nVoluptas dolores at accusantium consequatur a et itaque.", new DateTime(2021, 3, 31, 9, 9, 33, 635, DateTimeKind.Unspecified).AddTicks(3626), 12L, "Delectus sint ad omnis et quia in tempore.", 3, 3 },
                    { 165L, 58L, "magnam", new DateTime(2023, 5, 6, 23, 45, 57, 658, DateTimeKind.Unspecified).AddTicks(8178), 17L, "Accusantium voluptas in id qui aut beatae.", 2, 2 },
                    { 166L, 51L, "Odio laborum voluptate officiis rerum numquam sunt voluptatem.", new DateTime(2022, 9, 5, 19, 34, 28, 321, DateTimeKind.Unspecified).AddTicks(9788), 25L, "Quam quam nesciunt ducimus tempore aut.", 2, 0 },
                    { 167L, 11L, "odit", new DateTime(2022, 2, 20, 6, 44, 45, 381, DateTimeKind.Unspecified).AddTicks(7095), 4L, "Error omnis itaque error sunt et in.", 3, 1 },
                    { 168L, 12L, "iusto", new DateTime(2023, 8, 21, 20, 55, 41, 592, DateTimeKind.Unspecified).AddTicks(5928), 16L, "Eum est illum nobis beatae eos asperiores velit.", 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[,]
                {
                    { 169L, 5L, "Aspernatur aut ut quas vero est sit quia.\nBlanditiis dolorum rerum voluptas sint ut autem similique consequatur non.", new DateTime(2023, 7, 12, 2, 7, 29, 964, DateTimeKind.Unspecified).AddTicks(8405), 19L, "Ipsum inventore et vero vel.", 1, 0 },
                    { 170L, 23L, "corporis", new DateTime(2023, 8, 1, 15, 14, 25, 329, DateTimeKind.Unspecified).AddTicks(5369), 5L, "Nostrum reiciendis in.", 2, 2 },
                    { 171L, 55L, "Provident quis perferendis culpa voluptatibus facilis perferendis expedita. Eum error placeat repellendus recusandae harum. Ullam veniam tempora sit. Rem beatae vel facilis officiis ipsum.", new DateTime(2023, 7, 19, 16, 25, 48, 808, DateTimeKind.Unspecified).AddTicks(8731), 4L, "Ut quos omnis veniam magnam eveniet incidunt libero possimus ipsa.", 4, 0 },
                    { 172L, 32L, "Odit doloribus provident totam sapiente animi.", new DateTime(2023, 8, 17, 9, 7, 54, 50, DateTimeKind.Unspecified).AddTicks(2021), 29L, "Nobis et perferendis exercitationem id soluta blanditiis sunt.", 3, 3 },
                    { 173L, 8L, "Officiis suscipit nemo sed.", new DateTime(2023, 5, 28, 15, 35, 11, 496, DateTimeKind.Unspecified).AddTicks(9948), 25L, "Inventore non sed recusandae odit.", 1, 1 },
                    { 174L, 18L, "voluptate", new DateTime(2023, 3, 8, 7, 22, 21, 328, DateTimeKind.Unspecified).AddTicks(8579), 25L, "Id est omnis quasi aut ut qui.", 1, 1 },
                    { 175L, 48L, "Neque quibusdam temporibus quas commodi soluta.", new DateTime(2023, 6, 18, 9, 21, 30, 558, DateTimeKind.Unspecified).AddTicks(7563), 7L, "Quibusdam aliquid mollitia aut explicabo aut sunt reiciendis.", 4, 3 },
                    { 176L, 57L, "Et est porro doloribus perspiciatis. Facere nobis vel possimus. Doloremque autem aliquid harum consequatur quia aperiam est ipsa. Enim officia quisquam nesciunt qui harum dicta. Error quo voluptatibus officiis impedit quas dolorem.", new DateTime(2021, 9, 26, 14, 13, 9, 463, DateTimeKind.Unspecified).AddTicks(4357), 11L, "Ut dicta labore vel.", 2, 0 },
                    { 177L, 45L, "expedita", new DateTime(2023, 4, 8, 14, 57, 23, 448, DateTimeKind.Unspecified).AddTicks(2637), 40L, "Dolorem sint dolores consequuntur eos vel harum ad et ut.", 3, 0 },
                    { 178L, 62L, "Temporibus sit et non odit. Qui aperiam officia illum qui ut et consequatur. Eius delectus accusamus aut ducimus aut et tempore rerum. Sint debitis ea delectus inventore delectus eum voluptates cumque.", new DateTime(2022, 7, 27, 7, 1, 0, 382, DateTimeKind.Unspecified).AddTicks(5925), 9L, "Animi libero dolor dolore ipsa omnis nesciunt vitae pariatur.", 3, 0 },
                    { 179L, 59L, "Consequatur earum sed voluptatibus repellat sint reprehenderit ea. Atque impedit amet quibusdam modi et non at. Voluptas et consequatur rerum asperiores placeat laboriosam. Aperiam dolor sed saepe qui debitis. Velit aliquid accusantium itaque.", new DateTime(2022, 5, 4, 22, 39, 14, 901, DateTimeKind.Unspecified).AddTicks(8750), 13L, "Velit quibusdam tempora dolor numquam.", 4, 3 },
                    { 180L, 65L, "minus", new DateTime(2023, 5, 1, 11, 28, 50, 397, DateTimeKind.Unspecified).AddTicks(1642), 25L, "Id quas nisi iste.", 3, 2 },
                    { 181L, 18L, "Mollitia accusamus eaque. Accusamus temporibus suscipit quos laborum nam aliquam. Asperiores ut nulla dignissimos. Delectus dolores voluptatem eius suscipit incidunt beatae. Nisi quis odit explicabo ipsa blanditiis voluptatibus. Voluptas a voluptatem eligendi odit veritatis aut ad.", new DateTime(2023, 1, 20, 19, 31, 7, 748, DateTimeKind.Unspecified).AddTicks(4622), 28L, "Quia hic quis facilis perspiciatis aut numquam sequi voluptas.", 2, 1 },
                    { 182L, 40L, "Sapiente voluptatem cupiditate quas incidunt in sunt quia.", new DateTime(2022, 6, 14, 13, 37, 2, 480, DateTimeKind.Unspecified).AddTicks(6748), 38L, "Rerum eaque assumenda et et fuga similique quibusdam.", 2, 2 },
                    { 183L, 3L, "Quia iure et.\nAut provident cumque soluta qui.\nSed corporis quae.\nSoluta magnam quam.\nMaiores cumque molestias sit quaerat eveniet exercitationem.", new DateTime(2023, 5, 25, 19, 24, 50, 815, DateTimeKind.Unspecified).AddTicks(8906), 35L, "Qui ut voluptas maiores omnis dicta est eum odio.", 3, 0 },
                    { 184L, 2L, "Labore pariatur voluptatem nemo.", new DateTime(2022, 12, 29, 13, 45, 0, 602, DateTimeKind.Unspecified).AddTicks(7392), 29L, "Fugiat vero nesciunt architecto sit omnis repudiandae.", 2, 3 },
                    { 185L, 64L, "Dolores non vel sequi quas cumque dignissimos. Voluptatibus et cumque molestias sunt pariatur praesentium distinctio asperiores hic. Enim facilis suscipit assumenda nisi laborum optio.", new DateTime(2022, 3, 17, 2, 46, 49, 864, DateTimeKind.Unspecified).AddTicks(5898), 31L, "Sapiente aut impedit rerum error nemo magni.", 1, 2 },
                    { 186L, 58L, "quisquam", new DateTime(2023, 6, 16, 20, 20, 19, 3, DateTimeKind.Unspecified).AddTicks(66), 32L, "At hic quidem quo aperiam accusamus aut nam culpa.", 4, 1 },
                    { 187L, 38L, "omnis", new DateTime(2020, 10, 27, 12, 47, 31, 988, DateTimeKind.Unspecified).AddTicks(3085), 24L, "Ut enim sit modi temporibus debitis.", 2, 3 },
                    { 188L, 9L, "placeat", new DateTime(2022, 4, 22, 10, 23, 7, 773, DateTimeKind.Unspecified).AddTicks(7828), 35L, "Numquam ducimus ut expedita eos.", 3, 0 },
                    { 189L, 41L, "Sunt veritatis architecto voluptatum tenetur error voluptas repellat dicta.\nPossimus quas blanditiis.\nEt et facilis id ad amet eaque ea aspernatur veniam.\nEveniet rerum eum ut ipsam aut animi.", new DateTime(2019, 8, 10, 12, 34, 21, 20, DateTimeKind.Unspecified).AddTicks(858), 24L, "Laborum eos cupiditate nesciunt et ut molestiae.", 4, 1 },
                    { 190L, 68L, "Ex magnam dolorum eligendi quam enim eum.", new DateTime(2022, 7, 8, 13, 17, 26, 75, DateTimeKind.Unspecified).AddTicks(4375), 38L, "Quibusdam veritatis et voluptatem omnis rerum fugiat aut.", 1, 3 },
                    { 191L, 52L, "Et earum non iure necessitatibus culpa praesentium.\nOdio quos nisi accusantium et eligendi.\nSit corrupti placeat fugit harum minima.", new DateTime(2023, 3, 22, 22, 54, 48, 803, DateTimeKind.Unspecified).AddTicks(8585), 35L, "Earum explicabo est hic sequi placeat debitis.", 4, 1 },
                    { 192L, 69L, "Nam quo facere quia.\nEarum harum quas laboriosam corrupti natus ad sint dignissimos beatae.", new DateTime(2023, 5, 25, 18, 9, 10, 713, DateTimeKind.Unspecified).AddTicks(4746), 6L, "Eligendi soluta commodi.", 3, 1 },
                    { 193L, 70L, "Delectus sit officiis. Voluptatibus et aut animi consequatur atque magni earum quia dolor. Itaque laborum non voluptatem. Aut in provident culpa ex dolorum omnis odio. Aut inventore id similique velit. Rerum ipsa blanditiis aspernatur rerum repellat distinctio.", new DateTime(2023, 8, 3, 6, 29, 54, 267, DateTimeKind.Unspecified).AddTicks(5059), 15L, "Nemo explicabo velit assumenda non fugiat sunt.", 2, 1 },
                    { 194L, 52L, "Aut error quibusdam.\nEt ea aspernatur sed dolore.\nNihil reprehenderit autem repudiandae qui modi eveniet nesciunt.\nVoluptatem quo odio vitae ut eos doloribus pariatur sed.\nVoluptas necessitatibus velit quia molestias iusto doloremque ratione placeat.", new DateTime(2023, 5, 20, 9, 37, 34, 885, DateTimeKind.Unspecified).AddTicks(5041), 19L, "Animi deserunt eius.", 4, 3 },
                    { 195L, 25L, "illum", new DateTime(2023, 3, 13, 4, 37, 56, 451, DateTimeKind.Unspecified).AddTicks(8889), 20L, "Sunt ab doloribus vero iusto autem eligendi.", 2, 2 },
                    { 196L, 18L, "Aut enim et voluptatum omnis beatae ratione suscipit explicabo.", new DateTime(2023, 8, 15, 10, 42, 45, 671, DateTimeKind.Unspecified).AddTicks(8373), 19L, "Rerum excepturi error optio.", 2, 0 },
                    { 197L, 64L, "Eum mollitia assumenda.", new DateTime(2023, 1, 8, 19, 1, 42, 133, DateTimeKind.Unspecified).AddTicks(990), 36L, "Alias doloribus aspernatur.", 1, 2 },
                    { 198L, 12L, "Consequuntur vel rerum ullam unde qui est debitis aspernatur. Voluptatem nostrum quasi quidem occaecati totam labore. Reiciendis esse quas impedit sunt alias. Natus voluptatem accusamus aliquam. Sunt est voluptate enim debitis est.", new DateTime(2023, 8, 7, 14, 32, 0, 612, DateTimeKind.Unspecified).AddTicks(2757), 5L, "Modi modi omnis recusandae.", 1, 2 },
                    { 199L, 43L, "Esse consequatur aut odit maiores. At dolorum laborum esse quis rerum omnis. Voluptates aliquam architecto rerum debitis perspiciatis laborum et dolor.", new DateTime(2023, 7, 17, 1, 41, 42, 721, DateTimeKind.Unspecified).AddTicks(6655), 25L, "Inventore qui non deserunt occaecati unde cumque facere cupiditate cupiditate.", 2, 0 },
                    { 200L, 32L, "Sed cupiditate sit.", new DateTime(2023, 7, 30, 18, 21, 30, 745, DateTimeKind.Unspecified).AddTicks(4606), 7L, "Delectus error vel voluptatem eaque praesentium et.", 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "IsPublic" },
                values: new object[,]
                {
                    { 1L, 14L, "Fuga molestiae laborum architecto minus aut quisquam explicabo corporis.\nVeniam omnis et dolores temporibus voluptatem ea.\nIste odio quis delectus.\nDeleniti qui et consequatur.\nMinus illo quibusdam distinctio cumque nihil voluptate occaecati molestiae fuga.\nEx eos quibusdam ipsa nobis veritatis hic eaque.", new DateTime(2023, 8, 21, 17, 2, 50, 432, DateTimeKind.Unspecified).AddTicks(4869), 30L, false },
                    { 2L, 90L, "odit", new DateTime(2023, 3, 6, 13, 2, 8, 329, DateTimeKind.Unspecified).AddTicks(4239), 27L, true },
                    { 3L, 173L, "soluta", new DateTime(2023, 6, 29, 3, 33, 21, 871, DateTimeKind.Unspecified).AddTicks(9929), 29L, false },
                    { 4L, 125L, "dolorem", new DateTime(2023, 8, 21, 7, 57, 56, 88, DateTimeKind.Unspecified).AddTicks(183), 32L, true },
                    { 5L, 185L, "Id quam velit corporis sunt.", new DateTime(2022, 11, 5, 1, 40, 52, 446, DateTimeKind.Unspecified).AddTicks(2223), 17L, true },
                    { 6L, 47L, "Repellat neque temporibus iste magnam. Placeat sit temporibus rerum aut. Esse iusto autem vero odio necessitatibus et. Voluptatum in nesciunt officia voluptates ratione quo id harum quo.", new DateTime(2023, 1, 14, 6, 16, 30, 83, DateTimeKind.Unspecified).AddTicks(540), 18L, true },
                    { 7L, 100L, "Eaque et consequatur.", new DateTime(2023, 8, 5, 21, 56, 28, 59, DateTimeKind.Unspecified).AddTicks(1963), 38L, true },
                    { 8L, 10L, "Rerum dolores consequuntur cumque reiciendis iste qui. Omnis animi alias sed facilis. Blanditiis perferendis cumque. Quo nulla consectetur. Quasi impedit qui quis vitae maxime quidem ut pariatur quis.", new DateTime(2023, 7, 9, 8, 5, 4, 670, DateTimeKind.Unspecified).AddTicks(7067), 11L, true },
                    { 9L, 61L, "Soluta ducimus odit est assumenda vitae quo quam.\nIpsa voluptas ut rem architecto eligendi eum itaque.\nQuam debitis id.\nVoluptas est labore placeat harum voluptatem.\nPariatur facere ea assumenda laboriosam.\nQui dicta voluptatem.", new DateTime(2023, 8, 11, 12, 23, 37, 62, DateTimeKind.Unspecified).AddTicks(4131), 40L, true },
                    { 10L, 39L, "Nemo corporis vel exercitationem ea hic quia quidem.", new DateTime(2022, 5, 12, 2, 13, 33, 950, DateTimeKind.Unspecified).AddTicks(7197), 6L, true },
                    { 11L, 42L, "Sit qui nobis aut at nostrum.\nTotam magni ipsa exercitationem ullam tempore voluptas autem saepe expedita.\nEos vel itaque.\nLaboriosam autem commodi non sed.", new DateTime(2023, 6, 20, 22, 29, 4, 73, DateTimeKind.Unspecified).AddTicks(6533), 9L, false },
                    { 12L, 115L, "Veniam quia corporis voluptas cupiditate velit eum quo dolore. Veritatis et est officiis in. Voluptatum aut totam aperiam. Est fugit necessitatibus maxime voluptas quia porro. Et eius quas fuga vero deleniti dolorum deserunt vel.", new DateTime(2023, 6, 27, 18, 28, 16, 56, DateTimeKind.Unspecified).AddTicks(1712), 40L, false },
                    { 13L, 147L, "dicta", new DateTime(2022, 9, 3, 18, 17, 55, 347, DateTimeKind.Unspecified).AddTicks(9650), 36L, false },
                    { 14L, 181L, "Quo voluptatem rerum corporis quidem veritatis velit explicabo. Labore nam vitae voluptas. Iste accusantium temporibus. Omnis similique distinctio ut quod aperiam. Cupiditate accusantium nesciunt aperiam ducimus non.", new DateTime(2023, 5, 9, 3, 4, 10, 576, DateTimeKind.Unspecified).AddTicks(9769), 8L, true },
                    { 15L, 112L, "maiores", new DateTime(2023, 4, 21, 10, 39, 54, 724, DateTimeKind.Unspecified).AddTicks(4164), 23L, false },
                    { 16L, 178L, "Sit sit quibusdam ab quia nobis.\nPariatur aperiam voluptatibus.\nQuia culpa id.", new DateTime(2022, 11, 3, 18, 27, 42, 747, DateTimeKind.Unspecified).AddTicks(9912), 2L, true },
                    { 17L, 62L, "placeat", new DateTime(2023, 7, 15, 9, 32, 51, 842, DateTimeKind.Unspecified).AddTicks(4464), 36L, false },
                    { 18L, 134L, "Incidunt unde eius.\nRerum dolorem magnam nihil reprehenderit qui.\nVoluptatibus ut ea beatae accusamus eius odit sit id eum.", new DateTime(2023, 8, 16, 10, 2, 15, 632, DateTimeKind.Unspecified).AddTicks(5596), 21L, false },
                    { 19L, 101L, "Similique eos et cupiditate.\nEst vero corporis illum deserunt magni aut sit ut.\nVel veritatis enim quo iure incidunt.\nNam aperiam velit voluptas expedita error consequatur optio laudantium quis.\nEt dolores aliquam architecto qui dolor cumque.", new DateTime(2023, 5, 29, 13, 25, 25, 408, DateTimeKind.Unspecified).AddTicks(398), 3L, false },
                    { 20L, 3L, "Atque ipsum ex laudantium expedita. Et tenetur cum voluptatum et quia eaque doloribus nostrum dolores. Magni voluptas rem. Assumenda et nemo est sunt.", new DateTime(2023, 7, 30, 20, 50, 22, 678, DateTimeKind.Unspecified).AddTicks(699), 19L, false },
                    { 21L, 176L, "inventore", new DateTime(2022, 6, 27, 7, 21, 57, 689, DateTimeKind.Unspecified).AddTicks(2563), 7L, true },
                    { 22L, 92L, "Aut ut exercitationem aut.", new DateTime(2023, 6, 27, 10, 7, 15, 805, DateTimeKind.Unspecified).AddTicks(8610), 19L, false },
                    { 23L, 43L, "impedit", new DateTime(2023, 2, 15, 22, 31, 43, 580, DateTimeKind.Unspecified).AddTicks(4079), 38L, true },
                    { 24L, 2L, "pariatur", new DateTime(2022, 6, 19, 0, 32, 50, 950, DateTimeKind.Unspecified).AddTicks(998), 38L, false },
                    { 25L, 48L, "Ea et quo iusto natus ducimus perspiciatis illum eveniet eaque. Voluptas dolores dolor voluptatem enim praesentium pariatur deleniti hic corporis. Quia et unde et accusantium deleniti praesentium laudantium. Autem labore esse recusandae laborum dolorum. Eveniet soluta mollitia necessitatibus ipsam.", new DateTime(2023, 7, 2, 0, 11, 19, 314, DateTimeKind.Unspecified).AddTicks(594), 7L, true },
                    { 26L, 125L, "Totam velit autem et fuga est.\nNon rerum quidem quam et.\nIusto harum excepturi dicta beatae.\nUt eligendi fugit tenetur.\nAliquid velit ex itaque eos eum veniam ex fuga.\nRepellat non alias.", new DateTime(2023, 8, 21, 19, 37, 51, 243, DateTimeKind.Unspecified).AddTicks(4662), 10L, false },
                    { 27L, 85L, "Voluptatem provident provident aut est.\nVitae natus et voluptatem quo aliquid et.\nVoluptatem non suscipit eum quasi et aliquid.\nOdio nemo odio.", new DateTime(2023, 1, 26, 7, 37, 40, 359, DateTimeKind.Unspecified).AddTicks(2507), 19L, true },
                    { 28L, 181L, "Et optio sed. Aut voluptatum sit voluptas corporis est molestiae corporis nisi. Delectus molestiae ea culpa voluptates et et sapiente.", new DateTime(2023, 3, 9, 23, 29, 16, 375, DateTimeKind.Unspecified).AddTicks(6572), 4L, true },
                    { 29L, 15L, "Voluptatem dolorum ad et.", new DateTime(2023, 7, 11, 0, 17, 1, 593, DateTimeKind.Unspecified).AddTicks(1356), 28L, false },
                    { 30L, 66L, "dignissimos", new DateTime(2023, 8, 22, 13, 2, 16, 805, DateTimeKind.Unspecified).AddTicks(8983), 3L, false },
                    { 31L, 28L, "et", new DateTime(2023, 2, 16, 6, 15, 57, 488, DateTimeKind.Unspecified).AddTicks(1145), 39L, true },
                    { 32L, 68L, "Aut nihil dicta.", new DateTime(2023, 5, 25, 7, 18, 54, 988, DateTimeKind.Unspecified).AddTicks(1198), 28L, true },
                    { 33L, 128L, "Distinctio aperiam ratione corporis soluta qui quos incidunt.", new DateTime(2023, 7, 29, 9, 14, 10, 976, DateTimeKind.Unspecified).AddTicks(3555), 17L, false },
                    { 34L, 139L, "At officiis omnis. Inventore tenetur voluptatem est est. Occaecati similique ut minus voluptatem consequatur facere optio porro libero. Et odio occaecati dolor facilis et voluptas pariatur eaque.", new DateTime(2023, 3, 29, 20, 57, 49, 233, DateTimeKind.Unspecified).AddTicks(5219), 19L, true },
                    { 35L, 73L, "Non sint minima est in eum nihil.", new DateTime(2022, 10, 28, 10, 2, 37, 279, DateTimeKind.Unspecified).AddTicks(1312), 36L, true },
                    { 36L, 45L, "Itaque nam eligendi velit culpa.", new DateTime(2023, 8, 14, 22, 32, 41, 745, DateTimeKind.Unspecified).AddTicks(716), 18L, false },
                    { 37L, 11L, "esse", new DateTime(2023, 6, 24, 3, 56, 30, 115, DateTimeKind.Unspecified).AddTicks(2469), 32L, false },
                    { 38L, 48L, "Aut nemo dolore aut beatae.", new DateTime(2023, 5, 9, 16, 6, 32, 435, DateTimeKind.Unspecified).AddTicks(5163), 38L, true },
                    { 39L, 183L, "Beatae ex exercitationem et ea aut.", new DateTime(2023, 8, 22, 16, 6, 23, 212, DateTimeKind.Unspecified).AddTicks(4055), 40L, true },
                    { 40L, 8L, "Beatae est quam et quisquam laudantium officia. Aut fugiat est quo magnam sint eos molestiae. Aliquam enim omnis totam ea. Aut repudiandae est molestiae rerum enim magnam laboriosam labore corrupti. Est iure qui omnis modi consequatur vero maxime. Cupiditate occaecati distinctio voluptatem quos illo rerum est id error.", new DateTime(2022, 10, 25, 4, 51, 13, 162, DateTimeKind.Unspecified).AddTicks(3496), 29L, true },
                    { 41L, 122L, "Sed cumque nihil.\nQuos sed ut perspiciatis autem rem id est aperiam.\nEt quisquam reprehenderit commodi veniam magnam dolores.\nFugiat commodi non id tempore ducimus.\nAlias officia quia animi ratione enim sequi voluptatem.\nAperiam maiores enim.", new DateTime(2023, 1, 28, 21, 46, 25, 824, DateTimeKind.Unspecified).AddTicks(8873), 24L, false },
                    { 42L, 13L, "nihil", new DateTime(2022, 6, 11, 18, 6, 25, 286, DateTimeKind.Unspecified).AddTicks(6642), 15L, true }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "IsPublic" },
                values: new object[,]
                {
                    { 43L, 67L, "Cumque culpa aut et inventore.", new DateTime(2023, 7, 19, 18, 55, 47, 447, DateTimeKind.Unspecified).AddTicks(2785), 35L, false },
                    { 44L, 23L, "In quia rerum tempora voluptas in quis sit ullam earum. Minus magnam voluptatem non ut laborum sit veniam cum sequi. Ut similique ipsum quis voluptatem est qui quia velit. Repudiandae cumque earum debitis illum fugiat aliquid hic. Odit doloremque possimus. Quis et aperiam aut doloribus magnam similique fuga.", new DateTime(2023, 3, 13, 16, 53, 31, 172, DateTimeKind.Unspecified).AddTicks(8024), 22L, false },
                    { 45L, 38L, "Deleniti eos sint.", new DateTime(2023, 2, 8, 6, 6, 10, 741, DateTimeKind.Unspecified).AddTicks(662), 22L, true },
                    { 46L, 58L, "Et vitae omnis. Suscipit quidem ab voluptas qui officiis et tempore tempora ut. Officiis nulla architecto et. Esse expedita et omnis officiis consequatur cupiditate sint vero incidunt. Omnis et tenetur voluptatem et rem qui.", new DateTime(2023, 8, 10, 6, 31, 53, 155, DateTimeKind.Unspecified).AddTicks(1584), 28L, true },
                    { 47L, 52L, "dignissimos", new DateTime(2022, 8, 6, 2, 8, 8, 85, DateTimeKind.Unspecified).AddTicks(6511), 37L, false },
                    { 48L, 137L, "corporis", new DateTime(2022, 1, 15, 1, 6, 39, 878, DateTimeKind.Unspecified).AddTicks(1733), 1L, true },
                    { 49L, 2L, "Alias aut cupiditate fugit magni maiores repudiandae.\nDolore est enim illum magnam.\nQuaerat repellendus quia exercitationem minus in.\nSint et eveniet.\nNecessitatibus omnis perspiciatis reprehenderit provident corrupti quis sequi voluptas rem.\nVoluptas commodi unde optio dolorem architecto.", new DateTime(2023, 4, 22, 5, 46, 42, 498, DateTimeKind.Unspecified).AddTicks(1944), 26L, true },
                    { 50L, 20L, "Quia eligendi veniam itaque quam occaecati. Ipsa et dolores et et consequatur. Porro quia maiores distinctio et recusandae dolor voluptatem sapiente placeat. Voluptate maiores molestias. Aliquam magnam odit et quia quasi quo quia aliquid. Aut maiores iusto dolores tempora corporis voluptatem quibusdam.", new DateTime(2023, 8, 23, 0, 52, 19, 851, DateTimeKind.Unspecified).AddTicks(9436), 4L, true },
                    { 51L, 194L, "eos", new DateTime(2023, 7, 28, 23, 59, 13, 880, DateTimeKind.Unspecified).AddTicks(3338), 13L, true },
                    { 52L, 35L, "Sed aut quia.\nRerum dolores dolor dolore voluptates.\nSint quidem non fugit rerum ut rerum minus dignissimos est.\nRerum numquam autem mollitia amet dolore nobis.\nVoluptas odit tempore ducimus quisquam enim.\nQuaerat omnis nisi.", new DateTime(2023, 7, 14, 20, 42, 23, 899, DateTimeKind.Unspecified).AddTicks(4988), 23L, true },
                    { 53L, 60L, "Voluptatem dolores maxime voluptatem.", new DateTime(2023, 5, 13, 10, 51, 50, 642, DateTimeKind.Unspecified).AddTicks(9851), 40L, true },
                    { 54L, 130L, "ea", new DateTime(2023, 7, 22, 22, 17, 0, 926, DateTimeKind.Unspecified).AddTicks(3193), 16L, false },
                    { 55L, 51L, "Assumenda qui assumenda.\nAmet quia nulla recusandae.\nConsequuntur reprehenderit ad.\nInventore optio quibusdam et in.\nQuas distinctio dolor.\nAut qui voluptatem voluptatem dolorum.", new DateTime(2023, 8, 13, 4, 47, 46, 122, DateTimeKind.Unspecified).AddTicks(7349), 40L, false },
                    { 56L, 180L, "Repellendus quae est sint fugiat non.", new DateTime(2023, 6, 3, 18, 4, 1, 74, DateTimeKind.Unspecified).AddTicks(11), 9L, true },
                    { 57L, 31L, "Nisi tenetur delectus facere sed est eum et officia.\nDistinctio distinctio accusamus rerum tempora soluta non qui maxime.\nEveniet ad est ratione quo quod quia id sunt ut.\nQuas voluptas voluptatum.\nLibero veniam quia dolor repellat eveniet a adipisci aliquam doloribus.\nDelectus ipsa tempore voluptate repellat.", new DateTime(2023, 7, 26, 23, 30, 51, 272, DateTimeKind.Unspecified).AddTicks(1056), 34L, false },
                    { 58L, 164L, "corporis", new DateTime(2022, 7, 5, 11, 25, 44, 281, DateTimeKind.Unspecified).AddTicks(666), 19L, true },
                    { 59L, 1L, "Id nesciunt saepe qui voluptates natus in. Ea maxime explicabo. Beatae qui nesciunt blanditiis omnis beatae non neque aut et. Earum provident et commodi laudantium vitae voluptatem rem. Aspernatur culpa occaecati. Commodi similique magni fugit aut voluptates temporibus sed minus.", new DateTime(2023, 8, 12, 1, 58, 26, 106, DateTimeKind.Unspecified).AddTicks(4857), 37L, false },
                    { 60L, 184L, "Pariatur optio facilis eum sint hic.\nConsequatur adipisci recusandae consequatur ipsa ad reiciendis nulla et.\nVoluptas sunt quia hic illum voluptatem veritatis sed cupiditate non.\nVoluptates blanditiis aut dolores quidem voluptatem ut.\nRecusandae eligendi ipsam velit impedit quia.", new DateTime(2023, 6, 25, 1, 40, 42, 346, DateTimeKind.Unspecified).AddTicks(2880), 37L, true },
                    { 61L, 197L, "Dolores aperiam suscipit dolores. Et doloremque perspiciatis culpa impedit asperiores. Suscipit explicabo id consequuntur molestias ea magnam quo. Error sit aut cum et dolorem. Architecto nesciunt consequatur soluta blanditiis consequatur esse nihil totam alias. Cupiditate ut at ex.", new DateTime(2023, 4, 3, 1, 23, 16, 126, DateTimeKind.Unspecified).AddTicks(2958), 27L, true },
                    { 62L, 190L, "dolor", new DateTime(2023, 3, 8, 23, 45, 53, 41, DateTimeKind.Unspecified).AddTicks(2440), 14L, true },
                    { 63L, 187L, "porro", new DateTime(2023, 2, 18, 6, 0, 50, 838, DateTimeKind.Unspecified).AddTicks(325), 14L, false },
                    { 64L, 29L, "Rem nihil nisi ipsam. Ut cum ipsam distinctio molestias. Est voluptatum officia non. Est consequatur magni autem. Consequuntur omnis voluptatem dicta esse est atque in.", new DateTime(2023, 8, 12, 16, 48, 49, 507, DateTimeKind.Unspecified).AddTicks(7598), 8L, true },
                    { 65L, 186L, "eum", new DateTime(2023, 7, 13, 3, 41, 59, 284, DateTimeKind.Unspecified).AddTicks(5671), 1L, true },
                    { 66L, 113L, "Et nostrum rerum aut et.", new DateTime(2023, 8, 16, 14, 1, 35, 232, DateTimeKind.Unspecified).AddTicks(5999), 29L, true },
                    { 67L, 198L, "Aut velit ut nam voluptatem tempora accusamus voluptatem adipisci.\nSint voluptas quae debitis autem quia minima natus.\nEt est dignissimos vero fugiat officiis voluptates modi.\nCupiditate omnis molestiae molestias consequatur ut delectus eligendi eaque.\nVoluptatem dolor occaecati vitae nesciunt.\nEst natus et.", new DateTime(2023, 8, 14, 15, 38, 52, 97, DateTimeKind.Unspecified).AddTicks(6444), 37L, true },
                    { 68L, 40L, "tenetur", new DateTime(2023, 6, 12, 14, 24, 18, 222, DateTimeKind.Unspecified).AddTicks(6493), 18L, true },
                    { 69L, 151L, "Consequatur sit quibusdam iusto vel aut.\nOptio voluptates soluta dolorem perferendis et et explicabo facilis quis.\nVeritatis ipsam nulla ut distinctio animi voluptatem voluptas.\nDolorem incidunt non eos non voluptatum voluptates.\nQuas quis est enim omnis animi consequatur beatae molestias.", new DateTime(2023, 1, 18, 18, 7, 12, 501, DateTimeKind.Unspecified).AddTicks(748), 34L, true },
                    { 70L, 31L, "rem", new DateTime(2022, 12, 5, 8, 37, 42, 10, DateTimeKind.Unspecified).AddTicks(9628), 18L, false },
                    { 71L, 16L, "Velit fugit aut praesentium autem.\nEum perspiciatis rerum sed sit magni.\nEa error quam ullam porro voluptatum nesciunt.\nNulla necessitatibus repellat quas.\nPossimus autem ipsam.", new DateTime(2020, 11, 28, 11, 17, 43, 909, DateTimeKind.Unspecified).AddTicks(1366), 14L, true },
                    { 72L, 122L, "dicta", new DateTime(2023, 6, 23, 5, 35, 1, 252, DateTimeKind.Unspecified).AddTicks(1535), 13L, true },
                    { 73L, 147L, "Fugit saepe excepturi et excepturi fugit deserunt ea ratione possimus. Et quia aliquid. Aut tenetur qui nihil. Tempora natus provident. Magni ducimus enim a vitae repellat voluptates sunt laudantium amet.", new DateTime(2023, 2, 9, 12, 49, 21, 256, DateTimeKind.Unspecified).AddTicks(9934), 20L, false },
                    { 74L, 127L, "Repudiandae non dolore quaerat iure itaque id vel commodi.\nArchitecto velit nobis id omnis.\nCupiditate temporibus et voluptas harum.\nVoluptatem nulla excepturi voluptatem voluptatem.\nIncidunt corrupti quis dolor veritatis modi ipsam.", new DateTime(2023, 8, 19, 8, 40, 23, 448, DateTimeKind.Unspecified).AddTicks(6441), 30L, true },
                    { 75L, 62L, "Quisquam est quo autem dolor ducimus dolor.\nSapiente autem corrupti et voluptatem mollitia dolor in.\nUt sint sed ratione officiis reiciendis saepe eos.\nQuam et quasi et quae iste.", new DateTime(2023, 7, 31, 19, 43, 7, 622, DateTimeKind.Unspecified).AddTicks(3794), 24L, true },
                    { 76L, 75L, "eos", new DateTime(2021, 11, 21, 4, 10, 14, 125, DateTimeKind.Unspecified).AddTicks(7999), 18L, true },
                    { 77L, 70L, "Quaerat architecto quisquam pariatur necessitatibus reiciendis molestias deserunt.\nMolestiae pariatur tempore earum labore voluptatem.\nQuaerat similique nesciunt.\nNon quos explicabo repellat ad iure est et.", new DateTime(2023, 6, 23, 6, 46, 47, 572, DateTimeKind.Unspecified).AddTicks(612), 23L, true },
                    { 78L, 37L, "Debitis eum cumque quasi.", new DateTime(2023, 6, 15, 15, 28, 30, 915, DateTimeKind.Unspecified).AddTicks(272), 22L, false },
                    { 79L, 195L, "Fugiat et eveniet illo perspiciatis dolor voluptatem quis. Omnis voluptas voluptatibus quisquam sunt et consequatur facilis et. Officiis molestias ad quod ea recusandae voluptas consectetur. Suscipit sed delectus animi laudantium aliquam. Quia quo consequatur et et provident.", new DateTime(2023, 3, 31, 22, 27, 43, 141, DateTimeKind.Unspecified).AddTicks(2854), 18L, true },
                    { 80L, 108L, "Dolores soluta blanditiis eveniet quisquam nesciunt possimus labore natus voluptas.", new DateTime(2023, 8, 19, 21, 31, 44, 171, DateTimeKind.Unspecified).AddTicks(9368), 9L, true },
                    { 81L, 107L, "Autem neque sint totam magni dolor expedita fugiat.\nUt laboriosam sed impedit exercitationem dolore.", new DateTime(2023, 4, 25, 1, 37, 55, 732, DateTimeKind.Unspecified).AddTicks(1332), 28L, true },
                    { 82L, 66L, "Odio impedit perferendis rerum. Quia eligendi qui excepturi eveniet itaque non est hic rerum. Consequatur quas et et minima molestiae esse. Pariatur doloremque nostrum officia officiis exercitationem non voluptatem.", new DateTime(2023, 8, 22, 19, 6, 29, 611, DateTimeKind.Unspecified).AddTicks(4945), 29L, true },
                    { 83L, 145L, "Sit deleniti eos vero.", new DateTime(2023, 3, 4, 16, 50, 13, 259, DateTimeKind.Unspecified).AddTicks(6190), 24L, true },
                    { 84L, 46L, "Eum voluptas sed vitae et delectus sint nostrum.\nEaque sapiente aut odit quo.\nDelectus temporibus id aspernatur.", new DateTime(2021, 12, 23, 0, 59, 57, 891, DateTimeKind.Unspecified).AddTicks(1899), 3L, true }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "IsPublic" },
                values: new object[,]
                {
                    { 85L, 14L, "Molestiae nihil velit aut odit.", new DateTime(2023, 8, 22, 13, 19, 27, 513, DateTimeKind.Unspecified).AddTicks(7157), 40L, true },
                    { 86L, 146L, "ut", new DateTime(2023, 8, 22, 7, 44, 27, 625, DateTimeKind.Unspecified).AddTicks(1282), 4L, true },
                    { 87L, 29L, "occaecati", new DateTime(2023, 7, 25, 21, 54, 58, 66, DateTimeKind.Unspecified).AddTicks(5427), 9L, true },
                    { 88L, 103L, "qui", new DateTime(2023, 5, 6, 18, 42, 56, 734, DateTimeKind.Unspecified).AddTicks(4209), 33L, true },
                    { 89L, 135L, "Assumenda sed aut omnis voluptatem ut ipsam.\nQuia delectus culpa rerum neque.", new DateTime(2023, 5, 22, 4, 57, 53, 666, DateTimeKind.Unspecified).AddTicks(5293), 10L, true },
                    { 90L, 175L, "Iste et sint.\nQuisquam necessitatibus veniam.\nEt ullam eveniet fugiat non autem enim assumenda.\nNemo voluptas quae necessitatibus sed recusandae labore quidem porro.", new DateTime(2023, 7, 3, 17, 53, 8, 320, DateTimeKind.Unspecified).AddTicks(6821), 11L, true },
                    { 91L, 8L, "est", new DateTime(2023, 1, 8, 13, 38, 11, 380, DateTimeKind.Unspecified).AddTicks(4071), 1L, true },
                    { 92L, 158L, "Ipsa molestiae aliquam et vel et quasi maxime tenetur.", new DateTime(2022, 8, 11, 20, 57, 8, 17, DateTimeKind.Unspecified).AddTicks(780), 20L, true },
                    { 93L, 85L, "Totam magni aliquid maiores cum laudantium consequatur perferendis consequatur.", new DateTime(2023, 1, 14, 6, 1, 48, 230, DateTimeKind.Unspecified).AddTicks(9782), 9L, true },
                    { 94L, 192L, "Quam deleniti veritatis voluptatem laboriosam. Voluptatem reprehenderit doloremque dolorem necessitatibus omnis dicta quasi autem. Tempore saepe similique sint distinctio et est voluptatem eaque. Dignissimos quia perspiciatis eligendi dolorem hic. Nihil reiciendis asperiores. Voluptatem quam cum accusamus sapiente.", new DateTime(2023, 6, 16, 14, 27, 43, 423, DateTimeKind.Unspecified).AddTicks(6969), 23L, true },
                    { 95L, 85L, "Iusto sed aliquid tempora delectus nihil iste accusamus. Tempora molestiae nisi inventore pariatur suscipit nisi earum. Nam explicabo quibusdam dolores cupiditate voluptatum saepe ab. Voluptates aspernatur maxime autem atque nihil in odit. Rem quisquam aut quisquam.", new DateTime(2023, 7, 31, 19, 47, 56, 677, DateTimeKind.Unspecified).AddTicks(155), 24L, true },
                    { 96L, 111L, "Consequatur fugit dolorum dolorem et.", new DateTime(2023, 4, 19, 5, 49, 51, 249, DateTimeKind.Unspecified).AddTicks(4520), 26L, true },
                    { 97L, 49L, "Suscipit sint consequatur est est repellat et odio rerum atque. Dolor accusamus modi officia earum tempore tempore ut. Voluptatibus natus labore qui quis recusandae fugit.", new DateTime(2023, 8, 9, 10, 3, 58, 890, DateTimeKind.Unspecified).AddTicks(306), 3L, true },
                    { 98L, 120L, "qui", new DateTime(2023, 8, 15, 0, 31, 33, 625, DateTimeKind.Unspecified).AddTicks(5167), 8L, true },
                    { 99L, 62L, "Quos illo eligendi voluptas autem odio ullam. Delectus voluptatem reiciendis nesciunt eaque velit. Omnis soluta quam ea voluptas aut consectetur eius culpa quod. Eaque enim quo ea tempora eveniet voluptatem.", new DateTime(2023, 8, 17, 9, 22, 28, 208, DateTimeKind.Unspecified).AddTicks(8443), 38L, true },
                    { 100L, 6L, "Harum impedit ad ut vitae culpa magni minus cumque. Quas ullam velit excepturi quo ullam fugiat. Officia et ea.", new DateTime(2022, 6, 17, 8, 12, 4, 428, DateTimeKind.Unspecified).AddTicks(8161), 23L, true },
                    { 101L, 146L, "quo", new DateTime(2023, 8, 23, 6, 9, 18, 208, DateTimeKind.Unspecified).AddTicks(2466), 39L, true },
                    { 102L, 143L, "Quia quia repudiandae voluptatem et nesciunt odio. Sunt tempora eveniet non atque. Mollitia vel sunt facere quia velit ducimus id eos.", new DateTime(2023, 8, 10, 11, 32, 56, 676, DateTimeKind.Unspecified).AddTicks(7002), 1L, false },
                    { 103L, 108L, "Qui optio minus sunt ut corporis.", new DateTime(2023, 4, 3, 11, 33, 55, 561, DateTimeKind.Unspecified).AddTicks(3244), 21L, true },
                    { 104L, 119L, "Aspernatur qui nisi nam neque.", new DateTime(2020, 9, 26, 6, 7, 47, 177, DateTimeKind.Unspecified).AddTicks(3196), 6L, true },
                    { 105L, 31L, "Quibusdam veritatis animi eaque sed excepturi. Esse eaque accusamus voluptas provident neque. Qui quas illo molestiae in eos saepe quae ut.", new DateTime(2023, 2, 27, 11, 37, 55, 274, DateTimeKind.Unspecified).AddTicks(1333), 2L, false },
                    { 106L, 101L, "Ut hic at ut quis exercitationem quo nihil.", new DateTime(2023, 2, 3, 7, 39, 32, 810, DateTimeKind.Unspecified).AddTicks(937), 1L, true },
                    { 107L, 47L, "quia", new DateTime(2023, 1, 28, 18, 1, 25, 935, DateTimeKind.Unspecified).AddTicks(7611), 33L, true },
                    { 108L, 61L, "Non beatae inventore.", new DateTime(2023, 6, 22, 9, 12, 53, 374, DateTimeKind.Unspecified).AddTicks(8367), 23L, true },
                    { 109L, 105L, "Sequi accusamus vitae nihil.\nSint doloribus doloribus debitis ut maxime et omnis dolore.\nVoluptatem rerum est fugit ut voluptatibus unde.\nEa amet consectetur saepe omnis.", new DateTime(2023, 2, 9, 2, 12, 22, 768, DateTimeKind.Unspecified).AddTicks(5923), 22L, false },
                    { 110L, 63L, "Doloremque eos aperiam nemo omnis.", new DateTime(2023, 4, 27, 4, 7, 50, 316, DateTimeKind.Unspecified).AddTicks(2766), 33L, true },
                    { 111L, 32L, "Cupiditate vel qui repellat libero voluptatem id et. Est omnis soluta occaecati culpa. Odio totam qui. Fuga perspiciatis exercitationem numquam iusto doloribus in quia et et.", new DateTime(2023, 3, 30, 10, 11, 59, 884, DateTimeKind.Unspecified).AddTicks(6259), 22L, false },
                    { 112L, 85L, "Vitae qui non quasi non sint aliquid repellat.", new DateTime(2023, 6, 22, 9, 4, 40, 867, DateTimeKind.Unspecified).AddTicks(6073), 15L, true },
                    { 113L, 13L, "Ex atque quibusdam rerum. Incidunt mollitia exercitationem consequatur. Pariatur aut maiores. Nobis voluptatem ut.", new DateTime(2022, 12, 17, 1, 48, 16, 714, DateTimeKind.Unspecified).AddTicks(1349), 38L, false },
                    { 114L, 180L, "Odit adipisci exercitationem autem pariatur quidem. Sed excepturi quod aut odio minus et ad iusto. Non occaecati reiciendis cum quo commodi.", new DateTime(2023, 8, 1, 20, 30, 40, 251, DateTimeKind.Unspecified).AddTicks(1855), 23L, false },
                    { 115L, 58L, "Error esse velit sit provident.\nRecusandae et dignissimos quis corporis est exercitationem et ullam dolore.", new DateTime(2023, 8, 1, 17, 11, 31, 914, DateTimeKind.Unspecified).AddTicks(1229), 32L, true },
                    { 116L, 80L, "Nihil explicabo temporibus.", new DateTime(2022, 9, 24, 5, 0, 31, 1, DateTimeKind.Unspecified).AddTicks(481), 17L, false },
                    { 117L, 101L, "Veritatis ratione neque quia reprehenderit accusantium ea ut quis.", new DateTime(2023, 2, 9, 23, 9, 31, 517, DateTimeKind.Unspecified).AddTicks(4711), 4L, true },
                    { 118L, 107L, "Quia animi quos minima assumenda earum.\nNecessitatibus voluptatum doloribus voluptatem ut dolores nesciunt.", new DateTime(2023, 2, 17, 18, 31, 6, 871, DateTimeKind.Unspecified).AddTicks(9888), 7L, false },
                    { 119L, 27L, "et", new DateTime(2023, 8, 9, 0, 25, 38, 226, DateTimeKind.Unspecified).AddTicks(6017), 37L, true },
                    { 120L, 185L, "Aut assumenda consequatur ad quam omnis reiciendis. Et error consequatur inventore quia sunt enim cumque. Impedit eos fugiat consequuntur aut earum.", new DateTime(2022, 12, 18, 19, 21, 6, 639, DateTimeKind.Unspecified).AddTicks(2749), 18L, true },
                    { 121L, 139L, "Eligendi enim qui.", new DateTime(2023, 4, 11, 4, 53, 13, 50, DateTimeKind.Unspecified).AddTicks(4558), 25L, true },
                    { 122L, 24L, "Ut dolor sequi qui qui dolor sequi corrupti.", new DateTime(2021, 7, 28, 23, 27, 0, 77, DateTimeKind.Unspecified).AddTicks(1388), 35L, false },
                    { 123L, 86L, "Labore autem alias.\nDicta cum voluptatibus incidunt eligendi est aut exercitationem est.\nSoluta ut sequi ut nobis.\nVitae cum tempore et voluptas voluptas fugit ipsam animi.", new DateTime(2023, 2, 6, 16, 45, 9, 131, DateTimeKind.Unspecified).AddTicks(1067), 8L, true },
                    { 124L, 110L, "Veritatis animi nostrum vel ipsa sint.", new DateTime(2023, 7, 26, 1, 36, 15, 795, DateTimeKind.Unspecified).AddTicks(1779), 33L, true },
                    { 125L, 199L, "Iusto a nihil. Dolorem cumque itaque natus. Possimus et quia natus libero harum voluptatem a. Provident incidunt voluptates dolorum quis eos at facilis saepe provident. Accusamus fuga aut modi.", new DateTime(2023, 8, 13, 3, 8, 2, 816, DateTimeKind.Unspecified).AddTicks(5679), 26L, false },
                    { 126L, 37L, "Odio saepe commodi.\nTempora inventore deleniti dolore repudiandae velit voluptas eligendi aliquid.\nNumquam illum officia voluptas ad.", new DateTime(2020, 1, 31, 4, 4, 30, 183, DateTimeKind.Unspecified).AddTicks(1106), 17L, false }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "IsPublic" },
                values: new object[,]
                {
                    { 127L, 183L, "Aspernatur similique autem asperiores. In similique totam temporibus perferendis aliquam non. Quibusdam neque est dolorum sit accusantium recusandae non.", new DateTime(2023, 5, 30, 7, 56, 16, 134, DateTimeKind.Unspecified).AddTicks(4634), 3L, false },
                    { 128L, 43L, "Aliquam eaque unde non. Eaque a repudiandae blanditiis sint expedita dignissimos quia. Occaecati velit natus veritatis quia deleniti sit nesciunt dolor voluptas. Velit expedita consectetur temporibus minus rerum distinctio fugit reprehenderit.", new DateTime(2023, 5, 14, 7, 4, 8, 694, DateTimeKind.Unspecified).AddTicks(1532), 19L, false },
                    { 129L, 50L, "Magnam consectetur cumque ea qui consequatur facilis iure culpa. Doloribus cum aut nesciunt aspernatur aliquam. Est excepturi eum assumenda. Est aut asperiores. Qui libero assumenda minus fugiat.", new DateTime(2023, 7, 9, 8, 16, 29, 357, DateTimeKind.Unspecified).AddTicks(2687), 26L, true },
                    { 130L, 73L, "Eius reprehenderit perferendis et quia ut a maiores enim ut. Dolores dolore alias. Numquam quasi magni totam est.", new DateTime(2023, 8, 14, 9, 13, 12, 642, DateTimeKind.Unspecified).AddTicks(7552), 4L, true },
                    { 131L, 198L, "Quod et neque reprehenderit magni quia magnam quas.\nQuis ut repudiandae.\nSit aut sit dolores iste ad.\nFugiat itaque reprehenderit sunt quidem et.\nEst delectus enim eaque dolor.\nSimilique numquam sint voluptatem voluptas.", new DateTime(2023, 8, 15, 11, 58, 15, 75, DateTimeKind.Unspecified).AddTicks(2585), 40L, true },
                    { 132L, 21L, "nulla", new DateTime(2023, 8, 3, 12, 37, 25, 489, DateTimeKind.Unspecified).AddTicks(2689), 40L, true },
                    { 133L, 167L, "Qui quam ut commodi.", new DateTime(2023, 1, 9, 5, 28, 6, 904, DateTimeKind.Unspecified).AddTicks(8475), 27L, false },
                    { 134L, 53L, "Facilis ut consequatur sit temporibus iste et aut sunt. Expedita similique tenetur corrupti suscipit facere unde rem quam. Est magnam qui est dolorum fugiat asperiores. Velit et natus vitae ex dolores aliquid a. Sint enim distinctio inventore ut.", new DateTime(2023, 8, 2, 16, 30, 18, 781, DateTimeKind.Unspecified).AddTicks(7781), 38L, true },
                    { 135L, 143L, "Quos ab consequuntur fugit suscipit aut quia reprehenderit consequatur vitae.", new DateTime(2023, 7, 13, 1, 5, 56, 618, DateTimeKind.Unspecified).AddTicks(9953), 23L, false },
                    { 136L, 153L, "Nemo sunt numquam blanditiis eos vel vel aperiam neque.", new DateTime(2023, 8, 19, 23, 15, 25, 217, DateTimeKind.Unspecified).AddTicks(7776), 30L, true },
                    { 137L, 65L, "Assumenda dignissimos sed dolore ea sed ducimus placeat et.", new DateTime(2023, 4, 8, 16, 31, 27, 225, DateTimeKind.Unspecified).AddTicks(8734), 6L, false },
                    { 138L, 146L, "Debitis molestias quam. Aliquid quidem recusandae. Fugit tempore explicabo tenetur in et et ea. Veniam earum excepturi dignissimos recusandae aperiam.", new DateTime(2023, 8, 23, 10, 24, 48, 848, DateTimeKind.Unspecified).AddTicks(381), 33L, false },
                    { 139L, 46L, "quia", new DateTime(2023, 4, 10, 14, 14, 58, 929, DateTimeKind.Unspecified).AddTicks(2409), 10L, true },
                    { 140L, 183L, "Similique nemo ducimus magni.\nVel magni est voluptatem dolores quia deserunt.\nNatus nihil consequatur eos nulla et earum voluptatum eligendi adipisci.\nNam quibusdam error rerum qui et ratione.", new DateTime(2023, 8, 8, 11, 53, 25, 632, DateTimeKind.Unspecified).AddTicks(9062), 8L, true },
                    { 141L, 163L, "quo", new DateTime(2023, 8, 10, 4, 1, 56, 507, DateTimeKind.Unspecified).AddTicks(3878), 3L, true },
                    { 142L, 193L, "Consequatur et vel et et cupiditate vitae quis.", new DateTime(2023, 8, 18, 15, 17, 27, 579, DateTimeKind.Unspecified).AddTicks(5173), 26L, true },
                    { 143L, 86L, "Totam quo illum dolore odit nesciunt ut voluptatem occaecati optio. Similique ipsum ab nulla officia eos magni maiores. Debitis veniam iste rerum commodi et quos amet ut.", new DateTime(2021, 6, 4, 4, 23, 17, 727, DateTimeKind.Unspecified).AddTicks(2739), 39L, true },
                    { 144L, 19L, "Dolore iste ut unde sit. Eos unde necessitatibus tenetur voluptates voluptatem. Nihil et et. Veniam ipsa amet sequi accusamus rerum id nam neque ea.", new DateTime(2022, 9, 27, 7, 35, 0, 287, DateTimeKind.Unspecified).AddTicks(4991), 31L, true },
                    { 145L, 2L, "Iste laboriosam culpa saepe odio consequatur corrupti nihil.", new DateTime(2023, 2, 18, 22, 36, 36, 589, DateTimeKind.Unspecified).AddTicks(9422), 17L, true },
                    { 146L, 96L, "quasi", new DateTime(2020, 11, 20, 16, 18, 8, 537, DateTimeKind.Unspecified).AddTicks(2401), 33L, false },
                    { 147L, 16L, "Dolores vel tempore harum.\nVero accusantium assumenda quis sed velit distinctio laborum natus vitae.\nMinus qui rem omnis omnis ratione vel voluptatum sit quos.\nAut dolorem ducimus.\nQuibusdam autem unde nihil sapiente et voluptatem natus.\nPraesentium expedita quisquam itaque asperiores non natus molestias qui consequatur.", new DateTime(2021, 10, 20, 4, 30, 0, 809, DateTimeKind.Unspecified).AddTicks(7643), 11L, true },
                    { 148L, 58L, "Error adipisci laborum iure voluptas ratione id voluptas voluptate et.", new DateTime(2023, 7, 17, 19, 17, 2, 50, DateTimeKind.Unspecified).AddTicks(2681), 6L, true },
                    { 149L, 179L, "totam", new DateTime(2022, 6, 23, 22, 9, 36, 984, DateTimeKind.Unspecified).AddTicks(1571), 4L, true },
                    { 150L, 10L, "Atque dicta recusandae qui corrupti nesciunt quis aut cupiditate.", new DateTime(2023, 5, 23, 20, 42, 4, 873, DateTimeKind.Unspecified).AddTicks(6065), 18L, true },
                    { 151L, 146L, "Amet ipsam illo debitis.\nVel facilis dolores consequatur enim asperiores est.\nFacere labore nostrum natus est quo non blanditiis.\nDistinctio dignissimos rem corporis.\nLabore voluptates nihil.", new DateTime(2023, 8, 22, 17, 18, 22, 739, DateTimeKind.Unspecified).AddTicks(5390), 33L, true },
                    { 152L, 153L, "Ab unde laboriosam aut odio iusto numquam numquam neque.", new DateTime(2023, 6, 24, 17, 58, 46, 320, DateTimeKind.Unspecified).AddTicks(6303), 31L, true },
                    { 153L, 72L, "Repellat quia quo alias expedita est voluptate tempora. Voluptate qui nam unde eligendi. Doloribus esse laudantium labore perferendis ut est dicta voluptatem. Dignissimos minima impedit sint quia et ab eum sit corporis. Aut suscipit fugit dignissimos eos fugit illum aperiam. Omnis libero rem aut qui ex nisi dolorum eos.", new DateTime(2023, 3, 31, 5, 0, 6, 957, DateTimeKind.Unspecified).AddTicks(1075), 2L, true },
                    { 154L, 66L, "non", new DateTime(2023, 8, 23, 9, 2, 12, 109, DateTimeKind.Unspecified).AddTicks(8396), 13L, false },
                    { 155L, 197L, "Non iure explicabo voluptatibus vitae ut quibusdam debitis ut. Illo ipsum esse omnis consequatur id cupiditate delectus dicta. Ut distinctio repudiandae distinctio voluptatem ullam. Fugit iusto et vero inventore ipsam porro eos vitae debitis. Ad asperiores dolorem maiores quia animi.", new DateTime(2023, 4, 17, 17, 58, 15, 429, DateTimeKind.Unspecified).AddTicks(9772), 25L, true },
                    { 156L, 133L, "Repellat necessitatibus aut et accusamus rem et distinctio dolor.\nNobis odio et recusandae asperiores vero.\nQuidem est vero odit est explicabo id voluptatibus.\nIpsam soluta autem cum totam mollitia rem.\nVero dolorem sed.\nEnim est ducimus facere quos unde qui perspiciatis est.", new DateTime(2023, 7, 17, 7, 22, 36, 606, DateTimeKind.Unspecified).AddTicks(3391), 27L, false },
                    { 157L, 177L, "Cum enim quibusdam. Aut sit nesciunt facere accusamus odit reiciendis. Ut esse beatae. Et pariatur commodi fugit voluptate ex adipisci perspiciatis praesentium. Nulla et eligendi consequuntur possimus nam. Commodi laboriosam perspiciatis quis optio delectus earum qui optio.", new DateTime(2023, 4, 15, 20, 17, 50, 360, DateTimeKind.Unspecified).AddTicks(4885), 23L, true },
                    { 158L, 122L, "Neque perferendis quasi iusto soluta cumque quia.\nMagnam quae dignissimos.\nMolestias inventore quod aliquid enim quis.", new DateTime(2023, 3, 5, 4, 50, 36, 131, DateTimeKind.Unspecified).AddTicks(2416), 22L, true },
                    { 159L, 62L, "Distinctio quo rem consequatur aut voluptate. Sunt et provident aut nobis tempora quia distinctio sit. Sed est cupiditate blanditiis rerum quidem. Eaque aliquam voluptas delectus. Illo impedit inventore consectetur. Sit maiores pariatur.", new DateTime(2023, 8, 4, 5, 56, 44, 816, DateTimeKind.Unspecified).AddTicks(5402), 26L, true },
                    { 160L, 43L, "Et nam dicta dolorem rerum veritatis aut. Nemo ea sapiente porro architecto. Assumenda quisquam facilis eveniet quis. Qui illo dolores.", new DateTime(2022, 10, 18, 2, 59, 9, 398, DateTimeKind.Unspecified).AddTicks(7655), 28L, true },
                    { 161L, 3L, "voluptas", new DateTime(2023, 6, 11, 11, 41, 33, 89, DateTimeKind.Unspecified).AddTicks(2121), 22L, false },
                    { 162L, 75L, "excepturi", new DateTime(2019, 6, 7, 16, 22, 30, 632, DateTimeKind.Unspecified).AddTicks(1013), 25L, true },
                    { 163L, 75L, "tenetur", new DateTime(2019, 7, 29, 2, 50, 31, 795, DateTimeKind.Unspecified).AddTicks(9058), 34L, false },
                    { 164L, 175L, "Occaecati sed iste asperiores cum ut et nihil in ipsum.", new DateTime(2023, 8, 16, 14, 38, 58, 321, DateTimeKind.Unspecified).AddTicks(640), 11L, true },
                    { 165L, 41L, "Esse quam numquam delectus illum. Unde ipsa debitis ut inventore qui. Nam nesciunt aut omnis facilis. Quis sit ut consequatur quasi voluptate itaque.", new DateTime(2023, 5, 2, 18, 59, 53, 133, DateTimeKind.Unspecified).AddTicks(6146), 22L, true },
                    { 166L, 177L, "aut", new DateTime(2023, 7, 4, 7, 42, 35, 214, DateTimeKind.Unspecified).AddTicks(1351), 17L, true },
                    { 167L, 142L, "hic", new DateTime(2023, 8, 20, 20, 11, 37, 388, DateTimeKind.Unspecified).AddTicks(2621), 1L, true },
                    { 168L, 56L, "Aliquam enim quas quo aliquam. Magnam qui quia minima ratione esse qui. Debitis adipisci magnam quas magni asperiores vitae. Pariatur magnam cupiditate porro vel itaque dignissimos.", new DateTime(2022, 2, 11, 7, 59, 50, 61, DateTimeKind.Unspecified).AddTicks(1120), 19L, true }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "IsPublic" },
                values: new object[,]
                {
                    { 169L, 152L, "Optio qui veniam labore doloribus culpa cum quia.\nEius rerum reprehenderit eum rerum.", new DateTime(2022, 7, 26, 0, 25, 4, 359, DateTimeKind.Unspecified).AddTicks(3892), 27L, true },
                    { 170L, 43L, "Quam magnam amet sed eligendi ipsam hic molestiae.", new DateTime(2023, 1, 29, 7, 45, 49, 96, DateTimeKind.Unspecified).AddTicks(2172), 29L, true },
                    { 171L, 2L, "Dolores nam eius necessitatibus.", new DateTime(2023, 3, 29, 16, 44, 28, 758, DateTimeKind.Unspecified).AddTicks(5601), 36L, true },
                    { 172L, 158L, "Nihil aut et occaecati et quibusdam reprehenderit voluptate totam. Ducimus in placeat unde cum. Placeat sapiente qui quas et maiores dolorum ducimus. Incidunt dolor corporis.", new DateTime(2022, 5, 20, 8, 53, 54, 677, DateTimeKind.Unspecified).AddTicks(5714), 30L, false },
                    { 173L, 80L, "Quia qui voluptate mollitia aut. Aperiam itaque a ab voluptatem. Nisi sit officiis qui quo in. Ad odio corrupti illo nihil eum sit sunt dolorum. Molestias sit occaecati maiores ad rem dolor laboriosam. Nihil sit laudantium quae nam.", new DateTime(2023, 2, 5, 4, 25, 35, 992, DateTimeKind.Unspecified).AddTicks(5319), 31L, false },
                    { 174L, 11L, "Doloremque et architecto corrupti fugiat porro in voluptatibus. Eos incidunt velit voluptatem. Accusamus maxime atque quasi eos optio. Nisi optio dolorum consequatur qui qui expedita deserunt fuga. Sed quo accusantium deleniti ipsam dignissimos dolores. Facere dolor ea sequi voluptas tenetur.", new DateTime(2023, 5, 24, 14, 38, 5, 265, DateTimeKind.Unspecified).AddTicks(9986), 9L, false },
                    { 175L, 74L, "ad", new DateTime(2023, 6, 6, 5, 26, 8, 639, DateTimeKind.Unspecified).AddTicks(1336), 9L, true },
                    { 176L, 61L, "Soluta odio eveniet quod reprehenderit officia.\nAut cumque labore ut omnis.", new DateTime(2023, 1, 15, 21, 29, 37, 155, DateTimeKind.Unspecified).AddTicks(7609), 26L, false },
                    { 177L, 80L, "Vero nam possimus laborum. Consequuntur molestias ut numquam consequatur dolores sit. Ratione maiores illum alias vero eaque delectus similique natus. Aliquid perspiciatis magnam aut repellendus quis quod alias corporis.", new DateTime(2023, 6, 10, 12, 17, 30, 58, DateTimeKind.Unspecified).AddTicks(6164), 13L, true },
                    { 178L, 100L, "Et aut labore et aut. Illo dolor voluptate ipsam. Fuga magnam officiis voluptatum. Exercitationem dolorem voluptate quasi aliquid sequi est. Voluptatum alias adipisci. Exercitationem fugiat adipisci saepe dolor natus nihil dicta voluptas.", new DateTime(2023, 8, 3, 14, 4, 5, 406, DateTimeKind.Unspecified).AddTicks(7084), 6L, false },
                    { 179L, 94L, "similique", new DateTime(2023, 5, 12, 23, 11, 43, 571, DateTimeKind.Unspecified).AddTicks(4836), 5L, true },
                    { 180L, 21L, "Debitis sit delectus sint possimus earum praesentium nesciunt sit deserunt.", new DateTime(2023, 8, 15, 12, 10, 7, 508, DateTimeKind.Unspecified).AddTicks(4481), 11L, true },
                    { 181L, 154L, "Ducimus est qui reprehenderit nostrum.\nDicta voluptatem culpa minima officia aliquam rerum ex magnam.", new DateTime(2023, 6, 14, 23, 15, 39, 286, DateTimeKind.Unspecified).AddTicks(4202), 17L, false },
                    { 182L, 85L, "autem", new DateTime(2023, 8, 1, 12, 33, 14, 400, DateTimeKind.Unspecified).AddTicks(1138), 39L, true },
                    { 183L, 128L, "et", new DateTime(2023, 7, 21, 2, 27, 40, 421, DateTimeKind.Unspecified).AddTicks(4269), 9L, true },
                    { 184L, 24L, "Tempore veritatis aut non qui eius aut aliquam quia. Officiis et ut ut pariatur et velit totam. Necessitatibus voluptates voluptatem quasi corrupti totam ratione saepe ducimus. Consequatur sunt deserunt ut.", new DateTime(2022, 12, 20, 9, 44, 3, 169, DateTimeKind.Unspecified).AddTicks(7853), 8L, true },
                    { 185L, 158L, "Animi ut sed dolore sapiente sunt sit voluptates tempore.", new DateTime(2023, 3, 2, 16, 39, 26, 331, DateTimeKind.Unspecified).AddTicks(921), 33L, false },
                    { 186L, 185L, "praesentium", new DateTime(2022, 11, 28, 1, 58, 31, 681, DateTimeKind.Unspecified).AddTicks(6582), 40L, true },
                    { 187L, 66L, "odio", new DateTime(2023, 8, 22, 18, 56, 58, 742, DateTimeKind.Unspecified).AddTicks(1820), 6L, true },
                    { 188L, 45L, "Sed omnis distinctio.\nBeatae quidem nesciunt perspiciatis temporibus omnis.\nQui ducimus ut.", new DateTime(2023, 8, 18, 12, 43, 1, 671, DateTimeKind.Unspecified).AddTicks(7406), 10L, true },
                    { 189L, 55L, "Dignissimos consectetur aperiam adipisci corporis.", new DateTime(2023, 8, 12, 17, 16, 13, 957, DateTimeKind.Unspecified).AddTicks(9042), 11L, true },
                    { 190L, 93L, "Consequatur perferendis autem sed magni dignissimos. Dicta vitae sint dolores officiis rerum sunt laborum. Aut omnis eveniet dolore. Molestiae natus molestiae sint.", new DateTime(2022, 4, 20, 11, 34, 22, 575, DateTimeKind.Unspecified).AddTicks(3170), 33L, true },
                    { 191L, 40L, "Suscipit quo officia et dignissimos aut non temporibus fugiat. Ad cupiditate inventore neque enim. Expedita consectetur ipsum magni. Adipisci adipisci rerum. Et id libero corporis sint nulla.", new DateTime(2023, 6, 10, 0, 15, 59, 781, DateTimeKind.Unspecified).AddTicks(6018), 14L, true },
                    { 192L, 36L, "quas", new DateTime(2022, 11, 13, 16, 27, 2, 779, DateTimeKind.Unspecified).AddTicks(2596), 1L, false },
                    { 193L, 184L, "velit", new DateTime(2023, 7, 23, 18, 1, 59, 364, DateTimeKind.Unspecified).AddTicks(7726), 2L, true },
                    { 194L, 101L, "Non voluptatem illo porro.", new DateTime(2023, 5, 5, 4, 54, 30, 125, DateTimeKind.Unspecified).AddTicks(3951), 6L, false },
                    { 195L, 135L, "Dolores eos atque sint iusto beatae et.\nFuga dolores quo deleniti molestiae dolorem aut voluptatibus.\nMinima ut quam asperiores magnam sint quis voluptas temporibus.\nDolor fuga qui distinctio et velit.\nQuas iure fuga dolores.\nSunt autem ratione qui sit eius.", new DateTime(2023, 4, 19, 9, 58, 46, 678, DateTimeKind.Unspecified).AddTicks(9644), 22L, true },
                    { 196L, 56L, "Totam natus qui dolore.\nAut voluptatem facilis mollitia laudantium.\nTempora voluptatum voluptates.", new DateTime(2021, 1, 16, 20, 21, 9, 225, DateTimeKind.Unspecified).AddTicks(1670), 27L, true },
                    { 197L, 100L, "Quibusdam distinctio fuga pariatur occaecati.", new DateTime(2023, 7, 21, 23, 59, 47, 613, DateTimeKind.Unspecified).AddTicks(1476), 4L, true },
                    { 198L, 148L, "Aperiam quam sit quidem animi quaerat ipsa excepturi nisi fugiat. Voluptas ab quas ut nemo qui eum necessitatibus magni consequatur. Odio aut recusandae.", new DateTime(2023, 8, 23, 5, 8, 59, 97, DateTimeKind.Unspecified).AddTicks(6381), 35L, false },
                    { 199L, 133L, "deleniti", new DateTime(2022, 8, 6, 20, 42, 40, 767, DateTimeKind.Unspecified).AddTicks(611), 8L, true },
                    { 200L, 129L, "culpa", new DateTime(2023, 2, 28, 10, 41, 54, 461, DateTimeKind.Unspecified).AddTicks(6586), 17L, true }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "Output", "SubmittedAt" },
                values: new object[,]
                {
                    { 1L, 164L, "Vitae earum pariatur animi saepe explicabo asperiores molestiae et nihil. Esse provident id saepe nesciunt enim. Neque nemo dolore cupiditate temporibus vitae. Ut est voluptates qui minima dolor totam reprehenderit. Dolores non blanditiis facere numquam et facilis. Saepe sequi adipisci labore nesciunt.", new DateTime(2023, 4, 25, 22, 39, 27, 10, DateTimeKind.Unspecified).AddTicks(2167), 33L, "Tempora minus et in facilis natus voluptatem voluptas non. Dignissimos dicta dolor delectus molestiae alias accusantium voluptatem. Delectus cumque iste. Ea nam aut et. Necessitatibus molestiae odit quibusdam ullam ad ab quae.", new DateTime(2023, 8, 16, 0, 14, 14, 351, DateTimeKind.Unspecified).AddTicks(6276) },
                    { 2L, 57L, "Ea iste quos non incidunt consectetur numquam.\nQuod facilis dolorem libero.\nNostrum voluptates tempore non sint debitis et.\nFacilis temporibus molestias repudiandae aut amet non.\nIpsum amet perferendis id.\nAlias aut deleniti optio ea optio numquam.", new DateTime(2023, 8, 22, 14, 43, 20, 54, DateTimeKind.Unspecified).AddTicks(356), 8L, "Aut vel dolores cupiditate et consectetur consequatur voluptatem. Voluptatem quasi quo assumenda maiores sit aliquid consequatur alias. Sunt praesentium voluptatem recusandae hic nostrum et consectetur ut aut.", new DateTime(2023, 8, 23, 3, 26, 46, 362, DateTimeKind.Unspecified).AddTicks(5987) },
                    { 3L, 98L, "Eum distinctio corporis ut dolorem et velit.", new DateTime(2023, 7, 3, 20, 14, 52, 982, DateTimeKind.Unspecified).AddTicks(5803), 40L, "Quis laboriosam dolores soluta illo est numquam.", new DateTime(2023, 8, 21, 10, 30, 4, 642, DateTimeKind.Unspecified).AddTicks(9299) },
                    { 4L, 187L, "Repellat est sequi.\nEaque cupiditate consequuntur harum deserunt atque delectus nisi.\nAut voluptate ut tenetur sint quam consequatur praesentium.", new DateTime(2021, 3, 8, 2, 1, 36, 848, DateTimeKind.Unspecified).AddTicks(3994), 1L, "Corrupti quasi omnis.\nRerum iusto dicta.\nMolestiae velit ut reprehenderit assumenda similique vel consequatur neque.\nUt velit sunt ut sint maiores beatae et.", new DateTime(2021, 9, 30, 0, 23, 19, 960, DateTimeKind.Unspecified).AddTicks(259) },
                    { 5L, 80L, "Aspernatur qui delectus ut.", new DateTime(2022, 10, 20, 12, 14, 6, 29, DateTimeKind.Unspecified).AddTicks(623), 7L, "nobis", new DateTime(2023, 7, 28, 18, 2, 48, 505, DateTimeKind.Unspecified).AddTicks(3476) },
                    { 6L, 192L, "perferendis", new DateTime(2023, 7, 3, 8, 53, 28, 589, DateTimeKind.Unspecified).AddTicks(2975), 33L, "Esse voluptas facere autem. Delectus qui iste error voluptatem. Molestiae sequi impedit velit iste. Ipsum tempore molestiae esse aperiam eos accusantium placeat.", new DateTime(2023, 7, 4, 7, 9, 17, 468, DateTimeKind.Unspecified).AddTicks(2785) },
                    { 7L, 61L, "aut", new DateTime(2023, 5, 3, 5, 18, 48, 569, DateTimeKind.Unspecified).AddTicks(7687), 7L, "Iure saepe quas accusamus magni repellat velit ea.\nReprehenderit est labore.\nPorro earum consequatur nulla aspernatur a.\nVel nihil qui quae unde aut quo sed.\nA velit aut commodi asperiores vel nam.", null },
                    { 8L, 21L, "Voluptatem error provident quo beatae culpa modi repellendus.\nQuasi suscipit soluta neque praesentium voluptatem sed quis.", new DateTime(2023, 8, 10, 10, 44, 57, 618, DateTimeKind.Unspecified).AddTicks(9569), 28L, "Reiciendis sint debitis. Et ad sed perspiciatis omnis non. Placeat error explicabo accusantium maiores deleniti repellat praesentium. Id et eos. Expedita magni et impedit voluptatibus. Qui consequuntur nulla explicabo expedita aut.", new DateTime(2023, 8, 20, 21, 36, 59, 482, DateTimeKind.Unspecified).AddTicks(8015) },
                    { 9L, 76L, "Ut officia fugit quasi.\nSit rerum quis esse placeat nemo.\nDolor qui est est omnis.", new DateTime(2019, 12, 20, 4, 58, 25, 162, DateTimeKind.Unspecified).AddTicks(5030), 12L, "Consequuntur iure deserunt ut rem iusto et.", new DateTime(2022, 5, 23, 9, 27, 45, 20, DateTimeKind.Unspecified).AddTicks(6523) },
                    { 10L, 4L, "qui", new DateTime(2023, 4, 26, 14, 25, 57, 688, DateTimeKind.Unspecified).AddTicks(8284), 3L, "earum", new DateTime(2023, 5, 29, 4, 39, 39, 395, DateTimeKind.Unspecified).AddTicks(8568) }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "Output", "SubmittedAt" },
                values: new object[,]
                {
                    { 11L, 147L, "Explicabo repellendus enim quia aut voluptas aperiam voluptatem. Sed aut placeat possimus nobis facilis quidem excepturi aperiam voluptatem. Possimus sunt magnam. Omnis rerum nihil possimus ut eius voluptates laboriosam provident aut. Nobis quia mollitia velit ab sequi quidem est earum. Aliquam amet vel quis temporibus.", new DateTime(2023, 1, 14, 15, 45, 42, 836, DateTimeKind.Unspecified).AddTicks(97), 5L, "Omnis tenetur consequatur sed ea unde laudantium. Minima cum nam quia voluptas numquam officiis. A excepturi repudiandae quo non earum sed ipsam nemo distinctio. Qui voluptas iure iste praesentium nostrum vel. Molestiae et ratione voluptas ab id et debitis sapiente.", new DateTime(2023, 1, 23, 11, 57, 31, 393, DateTimeKind.Unspecified).AddTicks(1361) },
                    { 12L, 56L, "Nulla dolor ipsam qui fugiat.\nTempora cumque doloremque aut exercitationem necessitatibus sed quia.\nHic dignissimos rerum beatae consequatur maxime et aut omnis veritatis.\nQuia in magni deleniti.", new DateTime(2021, 8, 30, 0, 38, 30, 873, DateTimeKind.Unspecified).AddTicks(8427), 39L, "qui", new DateTime(2022, 9, 3, 20, 17, 28, 313, DateTimeKind.Unspecified).AddTicks(2030) },
                    { 13L, 100L, "Et et sit. Eos maiores voluptas ut qui in mollitia consequatur. Animi provident reiciendis soluta sed possimus.", new DateTime(2023, 8, 2, 20, 54, 0, 487, DateTimeKind.Unspecified).AddTicks(3174), 11L, "Similique unde accusamus rem sint quo mollitia ea.\nQuos at ut necessitatibus soluta nulla.\nRerum beatae ipsam nemo possimus omnis.\nEst in autem placeat harum eum a adipisci quam et.", new DateTime(2023, 8, 20, 12, 43, 28, 697, DateTimeKind.Unspecified).AddTicks(7114) },
                    { 14L, 62L, "alias", new DateTime(2023, 8, 18, 19, 42, 13, 285, DateTimeKind.Unspecified).AddTicks(2637), 6L, "Consequuntur aut excepturi blanditiis impedit at.", new DateTime(2023, 8, 22, 0, 10, 8, 544, DateTimeKind.Unspecified).AddTicks(5572) },
                    { 15L, 15L, "eveniet", new DateTime(2023, 7, 10, 14, 35, 32, 448, DateTimeKind.Unspecified).AddTicks(6860), 4L, "nam", new DateTime(2023, 7, 14, 15, 4, 55, 573, DateTimeKind.Unspecified).AddTicks(9307) },
                    { 16L, 127L, "Iusto laboriosam fuga dolor autem.\nAut consequatur ipsam alias laboriosam molestiae dolor.\nEarum nam eveniet quas cupiditate.\nSint inventore ducimus.", new DateTime(2023, 8, 20, 9, 20, 46, 764, DateTimeKind.Unspecified).AddTicks(9281), 34L, "Aut possimus mollitia non repudiandae nisi.", new DateTime(2023, 8, 20, 15, 8, 48, 758, DateTimeKind.Unspecified).AddTicks(8378) },
                    { 17L, 37L, "tempore", new DateTime(2018, 5, 2, 12, 9, 16, 149, DateTimeKind.Unspecified).AddTicks(4948), 40L, "Tempore quae quia iste qui rerum voluptas consequuntur debitis adipisci. Ab et dolor autem necessitatibus magnam. Sunt omnis vel deleniti in expedita dolores quibusdam. Sit eum in modi placeat id eos nulla perferendis ad. Ut sint sint totam est porro rerum autem velit. Cumque modi fugiat.", new DateTime(2021, 3, 18, 11, 57, 5, 842, DateTimeKind.Unspecified).AddTicks(6414) },
                    { 18L, 189L, "Repellendus repudiandae distinctio.\nUllam aut impedit enim nostrum.\nCommodi et odio temporibus expedita nulla repudiandae eum nobis assumenda.\nMollitia hic deleniti id maxime et similique quo.", new DateTime(2021, 12, 30, 1, 24, 18, 731, DateTimeKind.Unspecified).AddTicks(8648), 20L, "Facere facere sed consequatur quaerat.\nUt maxime dolor atque.\nSunt laboriosam id qui consectetur cupiditate dolor et ea a.\nEa amet delectus dolor eligendi iste qui qui mollitia.\nVeniam doloribus et nobis tempore et officia placeat.", new DateTime(2022, 5, 9, 5, 25, 19, 20, DateTimeKind.Unspecified).AddTicks(8550) },
                    { 19L, 162L, "Ut illo quae. Ut nostrum velit repellat qui non ipsa. Rem temporibus sit.", new DateTime(2023, 7, 12, 15, 8, 14, 638, DateTimeKind.Unspecified).AddTicks(5499), 9L, "necessitatibus", new DateTime(2023, 8, 12, 13, 28, 58, 656, DateTimeKind.Unspecified).AddTicks(4054) },
                    { 20L, 99L, "Aut debitis sit nesciunt qui et odit.\nEligendi quia tempore.\nInventore est doloribus.\nEt nostrum quod laborum excepturi ad eligendi.\nIste voluptas rem ab autem voluptatem rerum sed ipsum hic.\nVelit qui voluptas.", new DateTime(2023, 7, 1, 6, 7, 8, 838, DateTimeKind.Unspecified).AddTicks(8932), 34L, "Recusandae eaque dolor qui nisi itaque.", new DateTime(2023, 8, 11, 6, 30, 20, 816, DateTimeKind.Unspecified).AddTicks(5097) },
                    { 21L, 28L, "Voluptatem beatae est amet explicabo id illum doloremque inventore.", new DateTime(2023, 6, 16, 2, 36, 56, 715, DateTimeKind.Unspecified).AddTicks(1356), 23L, "et", new DateTime(2023, 6, 23, 15, 27, 28, 383, DateTimeKind.Unspecified).AddTicks(5771) },
                    { 22L, 45L, "Ipsa enim cum.\nQuos odit culpa et dolores reiciendis.", new DateTime(2023, 8, 20, 19, 36, 52, 563, DateTimeKind.Unspecified).AddTicks(1770), 16L, "voluptatem", new DateTime(2023, 8, 23, 6, 32, 39, 777, DateTimeKind.Unspecified).AddTicks(6529) },
                    { 23L, 60L, "Corporis ut iusto in.", new DateTime(2023, 6, 8, 23, 8, 45, 572, DateTimeKind.Unspecified).AddTicks(7631), 34L, "Perferendis quia perferendis quisquam eos. Officia nulla vel laudantium. Est fugit beatae excepturi maiores voluptatem ab. Modi ipsa ut autem perferendis labore voluptatem aliquid aut. Id repudiandae et cum qui explicabo autem id omnis. Doloribus iusto perspiciatis.", new DateTime(2023, 6, 28, 21, 45, 45, 327, DateTimeKind.Unspecified).AddTicks(3616) },
                    { 24L, 133L, "autem", new DateTime(2023, 6, 6, 2, 28, 11, 101, DateTimeKind.Unspecified).AddTicks(2052), 13L, "Ut ab sunt.", new DateTime(2023, 8, 23, 9, 22, 32, 935, DateTimeKind.Unspecified).AddTicks(4537) },
                    { 25L, 97L, "Illo est omnis repellendus non ut maiores eos.\nUt recusandae quo repellendus dolores molestias.\nEst aut dolor.\nSunt ut corrupti error.\nAut fugiat et ut est exercitationem voluptate explicabo.\nQuos quasi placeat ut sit in neque et.", new DateTime(2023, 7, 4, 5, 49, 29, 871, DateTimeKind.Unspecified).AddTicks(3101), 32L, "Non repellendus vel nesciunt omnis enim. Molestiae nobis dolorum excepturi veniam maiores aperiam. Dolores omnis mollitia est dolore non quod inventore alias. Voluptas ratione rerum eum quae iusto. Repudiandae voluptatem sed ipsam voluptatem ad dolor exercitationem.", new DateTime(2023, 7, 9, 16, 48, 24, 441, DateTimeKind.Unspecified).AddTicks(7626) },
                    { 26L, 146L, "Quas voluptatem est illo aspernatur voluptas rerum. Qui consequatur quisquam iusto neque eos. Rerum sit voluptas quis quo dolores excepturi. Minima illum voluptatum. Quae sit hic accusantium et error. Eos sed iusto vel sunt qui voluptatem et.", new DateTime(2023, 8, 21, 20, 46, 58, 516, DateTimeKind.Unspecified).AddTicks(6099), 21L, "Ut dolores molestiae itaque assumenda molestiae dolores.\nEt aut asperiores voluptatem voluptas labore.\nOfficiis voluptas eos omnis repellendus et accusamus.", new DateTime(2023, 8, 22, 4, 53, 31, 6, DateTimeKind.Unspecified).AddTicks(8377) },
                    { 27L, 69L, "In molestiae et et est rem nisi non aut.", new DateTime(2023, 7, 29, 9, 36, 28, 447, DateTimeKind.Unspecified).AddTicks(2561), 26L, "Labore facilis et qui ut aut qui tenetur impedit quam.\nConsequatur nihil corrupti voluptatum est sed molestias natus sed et.", new DateTime(2023, 7, 31, 4, 21, 19, 163, DateTimeKind.Unspecified).AddTicks(970) },
                    { 28L, 116L, "Ut minus sunt facere eveniet.\nModi eveniet qui praesentium explicabo nam ipsam architecto nesciunt.\nAut atque labore repellat minus voluptas.\nAlias voluptates voluptatem est ullam quae architecto.\nMolestias vel cum commodi nobis ea inventore non.", new DateTime(2023, 7, 22, 18, 17, 24, 876, DateTimeKind.Unspecified).AddTicks(9406), 39L, "Dolorum ab totam blanditiis omnis omnis amet vitae.\nOmnis commodi assumenda perspiciatis voluptatem dolores similique voluptas officiis eius.\nPariatur excepturi id officia quis rerum quo rem qui illo.", new DateTime(2023, 7, 23, 7, 51, 45, 428, DateTimeKind.Unspecified).AddTicks(7493) },
                    { 29L, 33L, "Rem illo fugit sapiente fugit sapiente.\nLaborum magni nisi omnis.\nNumquam et odio voluptas et aut ipsam debitis dolorem.\nVoluptas quo earum et consequatur repellendus voluptatem non ipsam qui.", new DateTime(2023, 3, 13, 8, 41, 1, 482, DateTimeKind.Unspecified).AddTicks(854), 17L, "iure", new DateTime(2023, 8, 5, 0, 48, 9, 291, DateTimeKind.Unspecified).AddTicks(186) },
                    { 30L, 143L, "Excepturi consequatur sint aliquid quo ullam eos esse. Mollitia incidunt expedita quis. Numquam in voluptatem quia sequi ex officia. Doloremque delectus possimus eum magnam ad sint.", new DateTime(2023, 8, 22, 14, 32, 0, 510, DateTimeKind.Unspecified).AddTicks(7090), 26L, "Iusto quos qui voluptatum autem deserunt quasi. Facilis id autem porro ex autem aut. Hic voluptate et consectetur dolorum dicta dicta repudiandae suscipit. Deserunt aut ab et ut quia rerum est modi autem. Id est et dolores.", new DateTime(2023, 8, 22, 19, 26, 58, 900, DateTimeKind.Unspecified).AddTicks(3510) },
                    { 31L, 5L, "Esse voluptas aut aut cupiditate et ut voluptate.\nEos voluptas repellat veritatis praesentium dolor.\nVelit eum nam voluptatem enim libero non et.", new DateTime(2023, 8, 2, 10, 16, 56, 949, DateTimeKind.Unspecified).AddTicks(1296), 28L, "Aut autem odit.", new DateTime(2023, 8, 6, 21, 0, 55, 84, DateTimeKind.Unspecified).AddTicks(9325) },
                    { 32L, 178L, "Veritatis commodi assumenda debitis eum nobis animi voluptas et.\nConsectetur non ad.\nAtque hic incidunt.\nMaxime fugit nemo cum totam hic.", new DateTime(2022, 8, 2, 18, 15, 12, 817, DateTimeKind.Unspecified).AddTicks(6330), 15L, "Fugit et repellendus omnis dolorem et repudiandae dolores totam. Ad molestiae maiores laborum eaque alias voluptatibus dolor dignissimos eum. Ut reprehenderit reiciendis officiis rerum nihil atque iure. Illum et vitae rerum atque voluptatem facilis exercitationem commodi est.", new DateTime(2022, 8, 22, 5, 2, 58, 694, DateTimeKind.Unspecified).AddTicks(9147) },
                    { 33L, 188L, "Quas enim tempore atque dolorem cupiditate rem dolores in.", new DateTime(2023, 5, 26, 8, 9, 42, 7, DateTimeKind.Unspecified).AddTicks(3197), 37L, "aut", new DateTime(2023, 7, 3, 21, 23, 39, 602, DateTimeKind.Unspecified).AddTicks(106) },
                    { 34L, 144L, "Voluptas aspernatur consequuntur est ea.\nQuam facere totam est cupiditate nisi voluptatem iure.", new DateTime(2023, 5, 20, 17, 43, 21, 973, DateTimeKind.Unspecified).AddTicks(9085), 9L, "et", new DateTime(2023, 7, 21, 4, 52, 40, 436, DateTimeKind.Unspecified).AddTicks(6842) },
                    { 35L, 123L, "Sequi quo reprehenderit nihil officiis non qui dignissimos ut officia.\nNam autem dolores ipsam quibusdam placeat assumenda alias.\nIllo voluptas repellendus sint vel.\nEius aperiam nesciunt et maiores incidunt ut eius dolorum occaecati.\nAsperiores aut ut harum beatae.", new DateTime(2023, 5, 2, 0, 15, 20, 431, DateTimeKind.Unspecified).AddTicks(4064), 36L, "Maxime praesentium unde porro in laborum.", new DateTime(2023, 6, 14, 23, 44, 56, 61, DateTimeKind.Unspecified).AddTicks(8941) },
                    { 36L, 70L, "Officiis laborum reiciendis.", new DateTime(2023, 7, 8, 9, 16, 52, 825, DateTimeKind.Unspecified).AddTicks(7019), 15L, "Sed id velit voluptatem nesciunt.\nQuibusdam et possimus necessitatibus laudantium minus aut qui aliquid assumenda.", new DateTime(2023, 8, 6, 14, 6, 7, 373, DateTimeKind.Unspecified).AddTicks(6349) },
                    { 37L, 37L, "A commodi incidunt laudantium nihil vel et.\nCupiditate autem fugiat eum suscipit qui iure quo id.\nQui quisquam ratione.", new DateTime(2021, 11, 9, 9, 56, 14, 692, DateTimeKind.Unspecified).AddTicks(5420), 18L, "Nihil odit quaerat et sed voluptatum quod alias tempora temporibus.\nAutem est sit beatae autem.\nHarum non sit natus cupiditate iusto quia sapiente libero doloremque.\nReprehenderit et voluptatum corporis atque ut.\nIpsam quia minima et ab illo fugiat animi unde.\nMollitia amet enim aperiam voluptas quod sint dignissimos optio.", new DateTime(2021, 12, 12, 2, 18, 15, 806, DateTimeKind.Unspecified).AddTicks(1981) },
                    { 38L, 26L, "Laborum sunt enim illo enim.\nSunt omnis aliquam nihil alias neque.\nQui et rerum nihil.\nDeleniti possimus in et repudiandae.", new DateTime(2022, 4, 12, 17, 16, 25, 63, DateTimeKind.Unspecified).AddTicks(5887), 3L, "Et culpa facilis architecto laborum sunt id placeat eius. Ut minus veniam. Optio enim excepturi eaque excepturi minima error impedit quaerat. Et corporis illo est et voluptatibus distinctio ut consectetur. Est asperiores fugit sit explicabo voluptates natus. Molestias necessitatibus et eligendi vitae nihil.", new DateTime(2023, 6, 23, 13, 22, 26, 245, DateTimeKind.Unspecified).AddTicks(8079) },
                    { 39L, 187L, "Voluptatem eos ducimus.\nEaque sint voluptas labore consequatur.\nUt omnis dolorem nihil sequi sit rerum animi quisquam sit.", new DateTime(2021, 6, 10, 6, 14, 10, 356, DateTimeKind.Unspecified).AddTicks(6127), 6L, "consequatur", new DateTime(2022, 3, 20, 9, 42, 32, 826, DateTimeKind.Unspecified).AddTicks(5123) },
                    { 40L, 39L, "Eveniet laborum ullam sint tempore aliquam id dolor officiis. Ut ut occaecati voluptas sequi quia sed ex. Repellendus recusandae pariatur vero ipsa saepe hic qui excepturi sunt. Quis et quis officia doloribus molestiae praesentium et. Ut mollitia neque. Beatae rerum recusandae nulla consequatur dolor eveniet vel.", new DateTime(2022, 8, 7, 6, 3, 11, 45, DateTimeKind.Unspecified).AddTicks(1567), 28L, "Beatae pariatur quae facere quaerat dolorum est non modi.", new DateTime(2023, 2, 4, 20, 39, 4, 646, DateTimeKind.Unspecified).AddTicks(2456) },
                    { 41L, 195L, "Eos rerum quia quasi. Est quia omnis ea. Aut ea minus adipisci accusamus perferendis quaerat nostrum quod earum. Sed doloremque nemo quis. Totam sed est neque aperiam. Deserunt omnis aperiam non hic minus necessitatibus architecto et aut.", new DateTime(2023, 4, 17, 6, 11, 8, 439, DateTimeKind.Unspecified).AddTicks(4069), 36L, "Ipsum quos et voluptatem laboriosam eius id. Fugiat illo distinctio vero. Cumque qui corporis. Illo labore molestiae consectetur voluptas dolor nesciunt. Veritatis cupiditate ea nam sit velit ut quis nobis sed.", new DateTime(2023, 6, 5, 15, 43, 10, 437, DateTimeKind.Unspecified).AddTicks(2236) },
                    { 42L, 163L, "Omnis et autem architecto recusandae aperiam quasi est.", new DateTime(2023, 8, 13, 12, 26, 2, 191, DateTimeKind.Unspecified).AddTicks(9964), 22L, "Et minus et ea ipsam laboriosam vel ad eligendi sed.", new DateTime(2023, 8, 16, 15, 29, 58, 208, DateTimeKind.Unspecified).AddTicks(262) },
                    { 43L, 98L, "Earum suscipit autem libero exercitationem dolores.", new DateTime(2023, 7, 12, 20, 41, 36, 420, DateTimeKind.Unspecified).AddTicks(1185), 6L, "Cum repellendus accusamus.", new DateTime(2023, 8, 19, 0, 36, 51, 169, DateTimeKind.Unspecified).AddTicks(9565) },
                    { 44L, 130L, "Rerum aliquam quibusdam error et fugiat aut magnam.", new DateTime(2023, 4, 11, 20, 38, 5, 508, DateTimeKind.Unspecified).AddTicks(3494), 38L, "amet", new DateTime(2023, 6, 29, 14, 38, 57, 325, DateTimeKind.Unspecified).AddTicks(5575) },
                    { 45L, 85L, "Sapiente magnam quia ut a in.\nIste excepturi ratione quia et rerum magni sunt.", new DateTime(2023, 5, 25, 0, 26, 53, 541, DateTimeKind.Unspecified).AddTicks(5041), 30L, "Cumque autem nihil.\nNatus ipsa ut quis veritatis doloremque quisquam.\nCupiditate tenetur quia blanditiis est.\nVoluptate voluptate exercitationem.\nMolestiae architecto quia sapiente quae commodi.\nVel architecto deleniti maxime provident fugiat facere.", new DateTime(2023, 6, 19, 9, 26, 16, 268, DateTimeKind.Unspecified).AddTicks(8616) },
                    { 46L, 63L, "Fugiat ut fuga magnam distinctio sit voluptate.\nQuia iusto dolor corporis ducimus et numquam.\nAsperiores et id dolore a et provident.", new DateTime(2023, 6, 5, 15, 41, 6, 358, DateTimeKind.Unspecified).AddTicks(4387), 13L, "Quisquam corporis suscipit magni odio dolorum. Voluptatem et sunt. Autem cumque commodi voluptate non.", new DateTime(2023, 7, 17, 7, 40, 54, 973, DateTimeKind.Unspecified).AddTicks(8753) },
                    { 47L, 187L, "quia", new DateTime(2021, 2, 1, 0, 7, 3, 676, DateTimeKind.Unspecified).AddTicks(2561), 3L, "quis", new DateTime(2022, 10, 2, 20, 11, 42, 365, DateTimeKind.Unspecified).AddTicks(7843) },
                    { 48L, 76L, "Non laudantium aut non.\nAsperiores nesciunt dolore.\nIure consequuntur voluptatem velit.\nAutem quo molestiae recusandae.\nEt deserunt ratione laborum.", new DateTime(2022, 3, 22, 22, 47, 47, 746, DateTimeKind.Unspecified).AddTicks(7107), 34L, "et", new DateTime(2023, 8, 5, 3, 45, 40, 81, DateTimeKind.Unspecified).AddTicks(5333) },
                    { 49L, 123L, "Distinctio quos eveniet corporis voluptatem voluptatem ipsam deserunt.\nDolor quisquam beatae eum dicta.\nNatus quaerat modi expedita deleniti reprehenderit ut veritatis at.", new DateTime(2023, 3, 23, 6, 56, 16, 567, DateTimeKind.Unspecified).AddTicks(6865), 9L, "delectus", new DateTime(2023, 5, 5, 13, 15, 8, 121, DateTimeKind.Unspecified).AddTicks(8971) },
                    { 50L, 198L, "Sed impedit voluptatum provident aut tempore et.\nEnim delectus saepe sit esse possimus occaecati consequuntur.\nDignissimos asperiores voluptates enim quia molestiae quae ullam.\nVeritatis cumque sed repellat porro.\nLaboriosam ut unde voluptatem vitae est aut maiores in quod.", new DateTime(2023, 8, 16, 8, 49, 18, 9, DateTimeKind.Unspecified).AddTicks(1520), 39L, "explicabo", null },
                    { 51L, 41L, "Sit quod eum aliquam esse minima et.", new DateTime(2023, 1, 24, 23, 21, 24, 613, DateTimeKind.Unspecified).AddTicks(2802), 25L, "omnis", new DateTime(2023, 3, 31, 9, 28, 41, 779, DateTimeKind.Unspecified).AddTicks(6027) },
                    { 52L, 137L, "Non quis quae voluptatibus. Aut sit similique necessitatibus suscipit. Enim et dolorum. Omnis nihil optio et molestias perferendis magni. Est quos aliquid autem quis quia et nulla ab.", new DateTime(2021, 11, 4, 17, 32, 14, 336, DateTimeKind.Unspecified).AddTicks(5206), 20L, "Incidunt quisquam exercitationem deserunt nobis qui.", new DateTime(2023, 7, 19, 9, 50, 46, 274, DateTimeKind.Unspecified).AddTicks(5662) }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "Output", "SubmittedAt" },
                values: new object[,]
                {
                    { 53L, 108L, "Deserunt facere rerum omnis nam ipsum eos vitae quas in. Voluptatibus quidem sapiente ea ut corrupti. Consequatur in iure. Deleniti eum aut sint perferendis voluptas id et corporis sunt. Iure dolor blanditiis aperiam nostrum iure. Voluptatem voluptatem eius eveniet.", new DateTime(2022, 12, 18, 8, 20, 41, 397, DateTimeKind.Unspecified).AddTicks(8732), 4L, "nihil", new DateTime(2023, 5, 5, 8, 52, 20, 765, DateTimeKind.Unspecified).AddTicks(66) },
                    { 54L, 132L, "Natus animi nihil ad inventore perspiciatis ratione nesciunt consequatur voluptatum.", new DateTime(2023, 7, 5, 2, 0, 15, 957, DateTimeKind.Unspecified).AddTicks(4210), 40L, "Officia magnam dolor et itaque velit est accusamus dolores labore.\nQui est nemo nihil voluptatum alias ab laudantium.", null },
                    { 55L, 152L, "reiciendis", new DateTime(2022, 10, 22, 15, 50, 46, 739, DateTimeKind.Unspecified).AddTicks(8855), 11L, "Qui cum quidem aut amet sed voluptas ex quam dolorum.\nDistinctio quae nihil ea aperiam.\nSit labore est soluta consequatur molestiae sed aut.", new DateTime(2022, 11, 24, 4, 48, 29, 605, DateTimeKind.Unspecified).AddTicks(3359) },
                    { 56L, 182L, "Necessitatibus soluta error aperiam omnis sed. Culpa quia qui molestiae. Suscipit est voluptate nihil. Corrupti facilis excepturi.", new DateTime(2023, 5, 14, 1, 56, 19, 368, DateTimeKind.Unspecified).AddTicks(4081), 40L, "Magnam occaecati nihil molestiae commodi vel dolore eligendi.\nAut magnam sequi quod quibusdam repellat repudiandae autem.\nQui natus modi.", new DateTime(2023, 7, 19, 8, 56, 1, 791, DateTimeKind.Unspecified).AddTicks(1595) },
                    { 57L, 179L, "et", new DateTime(2023, 2, 11, 17, 7, 40, 808, DateTimeKind.Unspecified).AddTicks(2557), 38L, "enim", new DateTime(2023, 2, 18, 14, 14, 47, 760, DateTimeKind.Unspecified).AddTicks(8101) },
                    { 58L, 70L, "Dolorem sed officiis saepe voluptas ea vitae.\nNam et eaque sunt pariatur praesentium.", new DateTime(2023, 8, 10, 16, 26, 6, 348, DateTimeKind.Unspecified).AddTicks(7566), 19L, "Nihil magnam laborum itaque ad perferendis laboriosam sit.", new DateTime(2023, 8, 15, 6, 15, 3, 895, DateTimeKind.Unspecified).AddTicks(712) },
                    { 59L, 134L, "Quo amet modi itaque est sit.\nQuas nobis sed nobis.\nDoloremque nam praesentium atque occaecati vero.\nVeritatis et eos suscipit vel et eligendi.", new DateTime(2023, 6, 10, 15, 0, 37, 827, DateTimeKind.Unspecified).AddTicks(4580), 30L, "Ut est necessitatibus a qui iste.", null },
                    { 60L, 66L, "voluptatem", new DateTime(2023, 8, 23, 5, 50, 8, 836, DateTimeKind.Unspecified).AddTicks(7160), 3L, "magnam", new DateTime(2023, 8, 23, 6, 49, 32, 196, DateTimeKind.Unspecified).AddTicks(9095) },
                    { 61L, 196L, "Nihil explicabo quam in cumque pariatur velit architecto repellat. Vel sapiente a enim est ut rem non quibusdam dolore. Consequatur occaecati ipsa. Rerum voluptatem atque itaque ut et non neque necessitatibus.", new DateTime(2023, 8, 15, 17, 51, 13, 119, DateTimeKind.Unspecified).AddTicks(6445), 29L, "et", new DateTime(2023, 8, 22, 2, 7, 0, 600, DateTimeKind.Unspecified).AddTicks(6495) },
                    { 62L, 156L, "Velit quia qui.", new DateTime(2023, 7, 16, 9, 20, 59, 575, DateTimeKind.Unspecified).AddTicks(8441), 16L, "Id distinctio soluta vero sunt dolores facere saepe sunt.", new DateTime(2023, 8, 7, 16, 39, 20, 601, DateTimeKind.Unspecified).AddTicks(5604) },
                    { 63L, 14L, "praesentium", new DateTime(2023, 8, 8, 16, 22, 48, 442, DateTimeKind.Unspecified).AddTicks(7032), 33L, "veniam", new DateTime(2023, 8, 21, 11, 27, 0, 45, DateTimeKind.Unspecified).AddTicks(7590) },
                    { 64L, 179L, "Reiciendis nihil est possimus voluptatem fugiat expedita deserunt quas debitis.", new DateTime(2022, 8, 18, 8, 18, 37, 15, DateTimeKind.Unspecified).AddTicks(6448), 10L, "Autem odio doloremque eos exercitationem nostrum nisi sed modi.", new DateTime(2023, 3, 25, 15, 6, 23, 726, DateTimeKind.Unspecified).AddTicks(1473) },
                    { 65L, 199L, "Rerum quod sed sit. Fugit impedit accusantium dolores magnam perspiciatis sed modi vitae ab. Animi dignissimos nulla est non eum sunt velit nostrum. Placeat provident quas dolorem ea voluptates ipsam commodi.", new DateTime(2023, 8, 5, 9, 20, 19, 753, DateTimeKind.Unspecified).AddTicks(5662), 15L, "Cum eum voluptas voluptatem. Nesciunt eaque et. Alias voluptatem voluptas.", new DateTime(2023, 8, 6, 20, 19, 11, 443, DateTimeKind.Unspecified).AddTicks(1243) },
                    { 66L, 160L, "Dolorem sint necessitatibus ullam commodi dolor cupiditate ut saepe.", new DateTime(2021, 12, 26, 9, 48, 30, 989, DateTimeKind.Unspecified).AddTicks(614), 16L, "Eius repudiandae nihil molestiae et occaecati blanditiis illum libero.\nIn non libero animi est ratione quia.\nEum placeat veritatis illo ut et repellendus non sapiente.\nQui consectetur qui dolorem.\nQui non non et quasi.\nNatus fugit deleniti qui harum sint soluta harum voluptas corrupti.", null },
                    { 67L, 72L, "Laudantium eos sunt iste enim incidunt voluptatum reprehenderit ut non. Libero possimus quos aut rerum ut quidem. Voluptates laboriosam est aut eveniet adipisci et.", new DateTime(2022, 8, 22, 21, 3, 17, 835, DateTimeKind.Unspecified).AddTicks(3915), 4L, "qui", new DateTime(2022, 12, 26, 13, 8, 35, 631, DateTimeKind.Unspecified).AddTicks(2232) },
                    { 68L, 164L, "Consequatur consequatur et dolore nam et veniam placeat aut aspernatur. Rerum eligendi odit ut esse numquam aliquam id. Eaque consectetur commodi distinctio accusantium beatae ullam officiis.", new DateTime(2023, 3, 11, 17, 34, 2, 785, DateTimeKind.Unspecified).AddTicks(2569), 40L, "Assumenda corporis quia dolores voluptatem fugiat suscipit dolore explicabo odio.\nAutem aspernatur et voluptatem nihil.", new DateTime(2023, 4, 2, 0, 17, 57, 987, DateTimeKind.Unspecified).AddTicks(8048) },
                    { 69L, 172L, "Saepe dolorum rerum qui modi qui.", new DateTime(2023, 8, 19, 2, 35, 19, 168, DateTimeKind.Unspecified).AddTicks(4045), 16L, "Et adipisci sapiente. Sint ut ad culpa aut consequatur molestias. Nobis qui voluptatem id impedit. Enim illo necessitatibus illo reprehenderit.", new DateTime(2023, 8, 21, 9, 19, 5, 534, DateTimeKind.Unspecified).AddTicks(8657) },
                    { 70L, 30L, "Sequi aperiam nemo officiis et sapiente id amet.\nPerspiciatis incidunt dolore.", new DateTime(2023, 6, 16, 11, 9, 38, 400, DateTimeKind.Unspecified).AddTicks(4486), 28L, "Quia modi vel ea.\nNon harum aliquid sequi accusamus et in.\nUt qui expedita necessitatibus assumenda ut ex ut.\nCupiditate ea est ut amet exercitationem.\nDistinctio aut necessitatibus quas nihil architecto exercitationem.\nQuis mollitia ducimus occaecati.", new DateTime(2023, 6, 23, 12, 51, 7, 51, DateTimeKind.Unspecified).AddTicks(9657) },
                    { 71L, 168L, "hic", new DateTime(2023, 8, 22, 22, 41, 25, 179, DateTimeKind.Unspecified).AddTicks(2587), 8L, "Deleniti sequi cupiditate aut eum.\nVoluptatem et perspiciatis voluptatem suscipit voluptas dolores veritatis.\nArchitecto voluptatem neque nesciunt velit animi ipsum eveniet fugiat officia.\nSint aliquam reprehenderit sapiente.\nQui dolorum voluptatem quia.\nVoluptatibus dolorem dolore mollitia modi expedita ab molestiae.", new DateTime(2023, 8, 23, 11, 32, 43, 286, DateTimeKind.Unspecified).AddTicks(2444) },
                    { 72L, 116L, "Temporibus voluptate voluptatum quod nemo quaerat est exercitationem mollitia sit.", new DateTime(2023, 4, 29, 0, 17, 22, 477, DateTimeKind.Unspecified).AddTicks(4365), 24L, "Repellendus est eius dolor id dolor sunt. Sint error consectetur earum. Rem est placeat.", new DateTime(2023, 5, 8, 9, 57, 53, 871, DateTimeKind.Unspecified).AddTicks(4429) },
                    { 73L, 54L, "Ratione in sit voluptatum nostrum.", new DateTime(2022, 7, 13, 11, 15, 34, 595, DateTimeKind.Unspecified).AddTicks(2047), 27L, "Blanditiis quam totam rerum in et.\nSed perferendis eius temporibus officiis nulla.\nEt amet repellendus ipsa perspiciatis.\nId nihil nesciunt.\nLaboriosam quis architecto id quisquam nihil quibusdam.", new DateTime(2023, 5, 8, 4, 11, 51, 879, DateTimeKind.Unspecified).AddTicks(805) },
                    { 74L, 85L, "Dolores aut quis.\nEos sit in.\nEos est eum est magnam maiores.\nAut facere quaerat eos ullam quis perspiciatis officiis.\nNemo quam quia id optio unde.\nSed tenetur ut velit et.", new DateTime(2023, 6, 14, 22, 36, 48, 147, DateTimeKind.Unspecified).AddTicks(3181), 12L, "et", new DateTime(2023, 8, 10, 13, 7, 4, 641, DateTimeKind.Unspecified).AddTicks(8138) },
                    { 75L, 152L, "Perspiciatis soluta facilis. Voluptatibus voluptatem temporibus provident repellendus. Tempora saepe quod odio veritatis aut dolor. Dolores nostrum minus veniam in. In aspernatur delectus odio sed voluptatum sit ipsa. Nostrum debitis dignissimos sapiente aliquid error sit.", new DateTime(2022, 2, 6, 18, 38, 26, 407, DateTimeKind.Unspecified).AddTicks(9906), 5L, "Qui eligendi laboriosam repudiandae.\nCommodi temporibus aperiam ut suscipit id veniam quaerat aut.\nAssumenda rerum ullam aliquid asperiores nemo quaerat sit nemo ducimus.\nEt aut molestiae maxime deleniti perspiciatis enim.", new DateTime(2022, 6, 18, 14, 20, 45, 627, DateTimeKind.Unspecified).AddTicks(9385) },
                    { 76L, 39L, "architecto", new DateTime(2022, 6, 21, 12, 31, 6, 377, DateTimeKind.Unspecified).AddTicks(1747), 28L, "Impedit maiores aut et laboriosam voluptatem.\nSoluta porro qui molestiae officiis error molestias.\nLaudantium exercitationem maxime.\nEst sequi at inventore ut nesciunt ut non sed.", new DateTime(2022, 10, 5, 7, 21, 52, 249, DateTimeKind.Unspecified).AddTicks(197) },
                    { 77L, 106L, "Iusto hic minima doloribus nulla. Omnis ratione rerum. Consectetur et velit quisquam. Sit ut fugiat ad vero molestiae ipsa blanditiis doloribus.", new DateTime(2023, 8, 23, 1, 9, 6, 114, DateTimeKind.Unspecified).AddTicks(1676), 40L, "quae", null },
                    { 78L, 160L, "Accusantium ut laudantium temporibus omnis sunt explicabo repudiandae.\nRecusandae sequi molestiae.", new DateTime(2022, 1, 16, 13, 42, 55, 501, DateTimeKind.Unspecified).AddTicks(9168), 36L, "Vel rerum minima aperiam iste dolorum qui qui quos nostrum.", null },
                    { 79L, 172L, "Totam atque optio laudantium et sit.\nSit omnis perferendis.\nOccaecati fugiat nam quo alias ratione dolor ut ut dolor.", new DateTime(2023, 8, 22, 19, 51, 45, 463, DateTimeKind.Unspecified).AddTicks(7289), 1L, "Et at quia necessitatibus delectus.", new DateTime(2023, 8, 23, 2, 8, 35, 553, DateTimeKind.Unspecified).AddTicks(5646) },
                    { 80L, 122L, "Veniam repudiandae beatae aspernatur delectus quis vero eum odio.\nBlanditiis ut vitae vitae dicta pariatur et dolore veniam illo.\nEt laborum est nostrum.\nQuia ut quia.\nAut dolores nihil eos quisquam ut aspernatur.\nConsequatur aut iste recusandae consectetur aut porro expedita aut.", new DateTime(2023, 4, 21, 8, 32, 37, 823, DateTimeKind.Unspecified).AddTicks(915), 6L, "Culpa totam esse. Nobis eius corporis iure aut vero velit tenetur quaerat et. Voluptatem non modi ea. Placeat repellat labore voluptatum dolores ut officiis qui ut. Modi magnam magni vitae asperiores laboriosam quisquam et. Quas non quo repellat.", new DateTime(2023, 7, 14, 2, 16, 42, 136, DateTimeKind.Unspecified).AddTicks(4488) },
                    { 81L, 68L, "Distinctio error sint nostrum.\nTempora itaque velit ducimus nisi sunt esse.\nQuidem rerum qui quia.", new DateTime(2022, 10, 29, 17, 45, 15, 166, DateTimeKind.Unspecified).AddTicks(6078), 33L, "Qui ipsa vero et eaque repellat sunt. Necessitatibus natus omnis perferendis sunt molestias error nobis non. Esse aut dolor iure qui neque ea exercitationem eum. Distinctio dolor et blanditiis rerum quibusdam in. Impedit repellat aliquam qui dolores quasi occaecati. Temporibus iste voluptas distinctio quasi quaerat est eum blanditiis quisquam.", new DateTime(2023, 5, 25, 3, 19, 10, 55, DateTimeKind.Unspecified).AddTicks(4262) },
                    { 82L, 34L, "Quia aut veritatis explicabo magni omnis odit.\nReiciendis numquam sed eum aut quo accusamus quo quis et.", new DateTime(2023, 8, 23, 9, 8, 35, 54, DateTimeKind.Unspecified).AddTicks(2076), 40L, "Dignissimos in quia fugit.", new DateTime(2023, 8, 23, 9, 20, 32, 781, DateTimeKind.Unspecified).AddTicks(898) },
                    { 83L, 160L, "et", new DateTime(2021, 12, 21, 22, 44, 52, 336, DateTimeKind.Unspecified).AddTicks(4506), 39L, "Eos velit eum optio molestiae et iste.\nVeniam reprehenderit nulla.\nMaxime aut totam voluptatum voluptas omnis nostrum alias.\nConsequatur itaque rerum aspernatur.", new DateTime(2023, 1, 18, 0, 13, 29, 661, DateTimeKind.Unspecified).AddTicks(154) },
                    { 84L, 96L, "Quam at praesentium consequatur cum quis. Laborum voluptatem sed dolor ut autem. Debitis deserunt eum nobis libero eius.", new DateTime(2021, 8, 20, 6, 52, 42, 666, DateTimeKind.Unspecified).AddTicks(1553), 21L, "Ab voluptatum rerum animi totam enim.", new DateTime(2022, 11, 10, 15, 32, 37, 661, DateTimeKind.Unspecified).AddTicks(3654) },
                    { 85L, 131L, "quia", new DateTime(2023, 8, 13, 9, 30, 17, 456, DateTimeKind.Unspecified).AddTicks(9993), 19L, "aut", new DateTime(2023, 8, 22, 13, 3, 30, 429, DateTimeKind.Unspecified).AddTicks(7842) },
                    { 86L, 70L, "Soluta quisquam ut et. Vel veniam fugit aut alias repellat. Voluptatibus quia architecto et sed aspernatur voluptas et ipsum. Neque aspernatur fuga qui commodi aperiam. Ipsam voluptatem id commodi voluptatem.", new DateTime(2023, 5, 28, 3, 24, 1, 579, DateTimeKind.Unspecified).AddTicks(8083), 38L, "debitis", null },
                    { 87L, 97L, "Non quia ducimus.", new DateTime(2023, 8, 5, 9, 36, 36, 700, DateTimeKind.Unspecified).AddTicks(8850), 24L, "nisi", new DateTime(2023, 8, 10, 16, 2, 54, 581, DateTimeKind.Unspecified).AddTicks(1843) },
                    { 88L, 73L, "Natus odio exercitationem accusamus. Magnam fugiat quos reiciendis qui odio. Sint velit reiciendis assumenda eaque quia assumenda tempore. Tenetur est dolor iste voluptatem blanditiis. Non minus et rem sit aut ipsam corrupti illo. Eius repellendus distinctio occaecati.", new DateTime(2023, 2, 2, 20, 57, 20, 173, DateTimeKind.Unspecified).AddTicks(4512), 1L, "molestiae", new DateTime(2023, 4, 19, 14, 23, 17, 137, DateTimeKind.Unspecified).AddTicks(7224) },
                    { 89L, 197L, "magnam", new DateTime(2023, 1, 11, 7, 2, 39, 884, DateTimeKind.Unspecified).AddTicks(3023), 39L, "Autem id nam fugit enim. Autem ipsa sapiente et assumenda delectus. Earum aut quos quo nulla.", new DateTime(2023, 8, 4, 3, 37, 11, 128, DateTimeKind.Unspecified).AddTicks(2319) },
                    { 90L, 61L, "Mollitia vitae quis molestias. Dolorem aliquid sit dolor impedit qui. Aut autem asperiores dolorum natus doloribus nesciunt eaque doloremque deleniti.", new DateTime(2023, 7, 25, 7, 38, 13, 613, DateTimeKind.Unspecified).AddTicks(2503), 6L, "Nemo voluptate pariatur.", new DateTime(2023, 8, 20, 3, 45, 5, 652, DateTimeKind.Unspecified).AddTicks(2487) },
                    { 91L, 43L, "Impedit facere qui voluptas earum et ipsam voluptas ipsum. Est sapiente neque doloribus reprehenderit aliquid minus est. Dolorem sed officia ad.", new DateTime(2023, 5, 9, 23, 10, 28, 636, DateTimeKind.Unspecified).AddTicks(1026), 40L, "quasi", new DateTime(2023, 6, 10, 10, 19, 54, 433, DateTimeKind.Unspecified).AddTicks(115) },
                    { 92L, 135L, "asperiores", new DateTime(2023, 4, 21, 1, 24, 34, 355, DateTimeKind.Unspecified).AddTicks(4812), 38L, "Accusamus aut modi numquam nihil. Porro voluptatem nisi provident dignissimos nobis ratione repudiandae. Voluptatem magni vel tenetur quo quia deleniti. Eligendi delectus ea animi. Ut libero dolor velit velit impedit. Et molestias rem impedit qui in enim.", null },
                    { 93L, 109L, "Officiis sit consequatur magnam neque reprehenderit eos provident. Sit fugit magnam aut cum. Dolore corrupti odio reprehenderit veniam facilis expedita odit et. Pariatur unde in et tempore. Quibusdam optio tempore autem animi. Rerum unde magni eum reiciendis modi.", new DateTime(2023, 7, 11, 22, 45, 20, 719, DateTimeKind.Unspecified).AddTicks(6226), 35L, "Exercitationem aliquam sint vel.\nFuga velit atque doloremque numquam architecto enim earum enim.\nVeniam laudantium culpa cum ipsam omnis ullam aut sequi.", new DateTime(2023, 7, 23, 2, 0, 59, 108, DateTimeKind.Unspecified).AddTicks(6942) },
                    { 94L, 126L, "Neque nesciunt iste nostrum expedita nobis.\nPorro iure non facilis culpa cupiditate beatae consequatur ut.\nAspernatur excepturi rerum aut sit.\nRepellat autem voluptas cupiditate ut qui ratione.", new DateTime(2023, 3, 8, 10, 26, 7, 966, DateTimeKind.Unspecified).AddTicks(9545), 10L, "Expedita ratione dolor possimus omnis fuga omnis quo sapiente.\nNisi expedita corporis et dolor sed expedita aut et sequi.\nVoluptate qui error iste sint saepe neque animi maiores.", new DateTime(2023, 7, 21, 1, 48, 0, 320, DateTimeKind.Unspecified).AddTicks(7906) }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "Output", "SubmittedAt" },
                values: new object[,]
                {
                    { 95L, 169L, "Id rem minus molestiae ab sunt. Laboriosam architecto dolores maxime qui. Quia dolor quia.", new DateTime(2023, 8, 13, 8, 48, 42, 962, DateTimeKind.Unspecified).AddTicks(2356), 9L, "Eius velit quidem. Et fugit aut est porro autem et omnis. Ipsam dolor labore sit nihil accusamus ea illo enim.", new DateTime(2023, 8, 17, 14, 55, 29, 345, DateTimeKind.Unspecified).AddTicks(7554) },
                    { 96L, 175L, "Architecto illum dolorum non consequatur veniam aut quod sed. Architecto in sed delectus sunt quis eveniet velit saepe. Qui repellendus fugit rerum rerum voluptates voluptatibus temporibus ut adipisci.", new DateTime(2023, 7, 8, 2, 29, 8, 965, DateTimeKind.Unspecified).AddTicks(8246), 26L, "inventore", new DateTime(2023, 8, 8, 18, 17, 17, 512, DateTimeKind.Unspecified).AddTicks(7960) },
                    { 97L, 117L, "Eos officia nemo illo quis expedita est magnam enim reprehenderit. Praesentium voluptatem magni qui nostrum nihil minus. Aspernatur corporis enim assumenda et sunt perferendis est libero libero. Incidunt reiciendis aut repellat quibusdam eos voluptatum veritatis animi nostrum.", new DateTime(2023, 1, 6, 19, 8, 41, 69, DateTimeKind.Unspecified).AddTicks(9284), 21L, "qui", null },
                    { 98L, 27L, "Consequatur reiciendis voluptate recusandae numquam deserunt.", new DateTime(2023, 8, 12, 21, 23, 5, 394, DateTimeKind.Unspecified).AddTicks(1179), 17L, "Deleniti enim aut odit qui vel. Perspiciatis ex voluptatem sit. Vel facilis magni est sapiente sunt temporibus. Dolore temporibus aut ad. Distinctio repudiandae qui quae. Ea aut ipsa sunt culpa voluptas velit doloremque ratione eos.", new DateTime(2023, 8, 13, 1, 49, 18, 369, DateTimeKind.Unspecified).AddTicks(9300) },
                    { 99L, 194L, "Ad dolore magnam sit eaque. Eos est ullam id repudiandae et totam laboriosam. Laudantium et ea quos est veritatis.", new DateTime(2023, 6, 19, 19, 14, 40, 618, DateTimeKind.Unspecified).AddTicks(339), 19L, "Molestiae est assumenda sed commodi a aut dolore rem in. Et rerum iure recusandae velit tenetur necessitatibus. Aut fugit modi. Vitae harum sapiente in consequatur qui totam ad.", new DateTime(2023, 7, 28, 1, 14, 30, 497, DateTimeKind.Unspecified).AddTicks(3414) },
                    { 100L, 110L, "Laboriosam dolores nam ducimus saepe. Cumque dolorem incidunt nihil beatae assumenda quia est rem. Sed reiciendis nobis atque in iste ullam autem consequatur.", new DateTime(2023, 8, 18, 6, 59, 4, 949, DateTimeKind.Unspecified).AddTicks(7687), 22L, "Fugiat voluptatem autem.", new DateTime(2023, 8, 21, 5, 30, 18, 952, DateTimeKind.Unspecified).AddTicks(4658) },
                    { 101L, 82L, "Omnis dolor quis non eos ipsum.", new DateTime(2023, 5, 15, 8, 12, 18, 316, DateTimeKind.Unspecified).AddTicks(8554), 16L, "Optio aut optio dolores quas.", new DateTime(2023, 7, 8, 2, 25, 30, 871, DateTimeKind.Unspecified).AddTicks(5225) },
                    { 102L, 182L, "Dignissimos officia quisquam et quas iusto officiis provident voluptas. Vitae nesciunt commodi molestiae velit in iste. Eum repudiandae quam nemo sed.", new DateTime(2022, 8, 5, 4, 35, 46, 388, DateTimeKind.Unspecified).AddTicks(1211), 26L, "Illum voluptate eos quis reprehenderit.", new DateTime(2023, 3, 15, 2, 30, 8, 409, DateTimeKind.Unspecified).AddTicks(7046) },
                    { 103L, 103L, "error", new DateTime(2023, 8, 2, 16, 9, 26, 531, DateTimeKind.Unspecified).AddTicks(5367), 30L, "harum", new DateTime(2023, 8, 20, 11, 58, 43, 203, DateTimeKind.Unspecified).AddTicks(6719) },
                    { 104L, 162L, "Sapiente non omnis voluptatibus.\nIn minima qui dolores iure ut provident est.\nMinus neque ducimus.", new DateTime(2023, 7, 4, 1, 20, 21, 806, DateTimeKind.Unspecified).AddTicks(6590), 8L, "Repellendus explicabo consequatur. Quos et est in culpa qui quo possimus repellat. Ducimus non deserunt velit ut molestias quo consequuntur.", new DateTime(2023, 7, 30, 22, 52, 13, 170, DateTimeKind.Unspecified).AddTicks(4349) },
                    { 105L, 76L, "Voluptate sint dignissimos ullam aliquid et quia earum.\nEaque placeat aut accusamus soluta tempore.\nProvident perferendis culpa aut similique aperiam consequatur.\nSed expedita saepe velit fuga a nobis earum.\nUt quae velit ipsam cumque quia culpa.", new DateTime(2019, 5, 29, 18, 54, 1, 923, DateTimeKind.Unspecified).AddTicks(9700), 17L, "Non omnis a quaerat sint dolores fuga alias non consequuntur.\nAut quis molestias omnis aspernatur eligendi ut consequatur voluptatem provident.\nConsequatur quaerat ut quidem voluptatum.\nEum est alias beatae sint.\nArchitecto ut et.", new DateTime(2023, 8, 21, 14, 8, 6, 810, DateTimeKind.Unspecified).AddTicks(7423) },
                    { 106L, 107L, "Autem tempore est sed id et est quisquam. Iure culpa tenetur optio quis. Expedita ut ipsum labore consequuntur eveniet consectetur quaerat iusto officiis. Exercitationem deserunt itaque voluptatem in deserunt asperiores et dolor. Temporibus id modi inventore reprehenderit ea qui est quos hic. Fugit dolores velit est repellendus sint est.", new DateTime(2022, 8, 8, 12, 8, 59, 394, DateTimeKind.Unspecified).AddTicks(8433), 22L, "Aliquam nam placeat suscipit perferendis dolor.\nVel maiores a.\nOdit et accusamus.\nRerum sit minus ut est provident earum.\nEnim dolor aspernatur non libero autem beatae nemo officiis in.", new DateTime(2023, 2, 4, 15, 3, 33, 436, DateTimeKind.Unspecified).AddTicks(5758) },
                    { 107L, 93L, "Error repudiandae molestias doloribus laudantium consequatur sunt.", new DateTime(2022, 7, 3, 9, 52, 17, 240, DateTimeKind.Unspecified).AddTicks(5595), 19L, "Suscipit tenetur quia asperiores rerum ipsam id odio nesciunt.\nAliquam ut voluptatem voluptates et quia non autem suscipit sed.", null },
                    { 108L, 180L, "Nulla ipsum cupiditate maiores et tenetur maxime ex libero qui.\nEius suscipit aperiam error laudantium voluptatem eius saepe.\nLaboriosam aliquam voluptatum velit quia quas commodi.\nMollitia et hic enim aut aut deserunt maiores iure.", new DateTime(2023, 8, 11, 9, 30, 37, 474, DateTimeKind.Unspecified).AddTicks(1175), 18L, "Et neque ullam ut rerum porro sed velit.", new DateTime(2023, 8, 19, 3, 52, 45, 849, DateTimeKind.Unspecified).AddTicks(2834) },
                    { 109L, 33L, "Officia eligendi voluptas dolor quia officia officiis.\nNihil quidem iure suscipit provident odio in architecto ab.\nDolorem iusto ipsa porro provident atque.\nNemo molestiae aut.\nId quia unde quae quia consequatur nostrum veritatis.\nMollitia deleniti nostrum ut fugit enim.", new DateTime(2023, 4, 13, 3, 46, 37, 693, DateTimeKind.Unspecified).AddTicks(3230), 35L, "Nam alias quia qui deserunt sit saepe in iste.", new DateTime(2023, 7, 14, 0, 14, 47, 463, DateTimeKind.Unspecified).AddTicks(5926) },
                    { 110L, 36L, "Qui excepturi voluptas.\nQuia iusto veniam perferendis natus.\nUt qui quas id modi sequi corporis rerum molestiae et.\nPerferendis autem et facilis et dolores magni numquam quibusdam dolor.\nReprehenderit deleniti nostrum quibusdam atque quos laboriosam similique eaque.\nDoloremque et unde quaerat illo ut itaque est reprehenderit.", new DateTime(2023, 6, 12, 13, 41, 54, 955, DateTimeKind.Unspecified).AddTicks(4706), 10L, "id", new DateTime(2023, 8, 3, 3, 39, 9, 858, DateTimeKind.Unspecified).AddTicks(1504) },
                    { 111L, 134L, "Voluptatem quibusdam omnis sed provident.\nVoluptatem enim nihil libero consequatur ullam ea laborum.\nVoluptatibus commodi odit.\nAnimi et consectetur cupiditate voluptate id.\nRatione nemo atque.", new DateTime(2023, 6, 13, 13, 19, 43, 268, DateTimeKind.Unspecified).AddTicks(3025), 35L, "ullam", null },
                    { 112L, 76L, "Perferendis molestias doloremque a sint.", new DateTime(2021, 12, 24, 17, 22, 34, 142, DateTimeKind.Unspecified).AddTicks(7157), 36L, "culpa", new DateTime(2022, 2, 22, 21, 43, 20, 928, DateTimeKind.Unspecified).AddTicks(6561) },
                    { 113L, 44L, "Aliquam architecto iusto.", new DateTime(2023, 4, 6, 12, 22, 44, 208, DateTimeKind.Unspecified).AddTicks(9920), 30L, "Sint blanditiis animi porro eum. Quis a et explicabo est. Quo ab sunt. Similique voluptates cum quas dolorem est optio excepturi quia expedita.", new DateTime(2023, 6, 28, 4, 30, 20, 128, DateTimeKind.Unspecified).AddTicks(5874) },
                    { 114L, 156L, "Quibusdam natus voluptates ipsam consequuntur ipsum est fuga dolore quis. Doloremque fugit corporis doloribus autem molestias cupiditate veniam assumenda provident. Possimus sunt molestias ipsum et sequi ea aperiam voluptatem. Sit et aliquam provident ut magnam dolor quas at. Voluptatum velit id quia.", new DateTime(2023, 8, 5, 19, 27, 45, 501, DateTimeKind.Unspecified).AddTicks(4901), 30L, "Eius sunt nemo facilis.\nVel consequatur aut illum aut tenetur iste dolores voluptatem non.\nAut cumque enim.\nPraesentium voluptate aliquam.", new DateTime(2023, 8, 11, 15, 49, 7, 939, DateTimeKind.Unspecified).AddTicks(3379) },
                    { 115L, 66L, "Suscipit harum amet non qui rerum.", new DateTime(2023, 8, 21, 3, 10, 31, 270, DateTimeKind.Unspecified).AddTicks(3505), 19L, "Nihil magnam est voluptatem dignissimos. Rerum ea earum voluptatem iure dolores rem incidunt vel. Vel fugiat error et illo ab est praesentium sit.", new DateTime(2023, 8, 22, 11, 34, 4, 367, DateTimeKind.Unspecified).AddTicks(490) },
                    { 116L, 117L, "Tenetur laboriosam rerum.", new DateTime(2021, 10, 13, 16, 36, 42, 829, DateTimeKind.Unspecified).AddTicks(3197), 14L, "Consequatur sint eum omnis reprehenderit. A doloribus eos. Consequatur neque voluptas fugit reprehenderit nostrum. Autem natus voluptatem qui aut. Culpa autem illum repellat ipsam ut dolores.", null },
                    { 117L, 168L, "Expedita quidem quas nisi laborum molestiae natus.\nAutem sequi soluta nam doloremque excepturi.", new DateTime(2023, 8, 22, 13, 16, 0, 353, DateTimeKind.Unspecified).AddTicks(6073), 18L, "rem", new DateTime(2023, 8, 22, 19, 3, 30, 524, DateTimeKind.Unspecified).AddTicks(7468) },
                    { 118L, 70L, "Ducimus est illo tempora magni assumenda dicta quod.\nAut porro molestiae omnis voluptatum.", new DateTime(2023, 7, 13, 12, 32, 47, 535, DateTimeKind.Unspecified).AddTicks(5923), 34L, "Sit iure accusantium nulla quidem debitis aut.", new DateTime(2023, 7, 18, 14, 41, 43, 515, DateTimeKind.Unspecified).AddTicks(9210) },
                    { 119L, 63L, "repellendus", new DateTime(2023, 5, 24, 12, 55, 58, 740, DateTimeKind.Unspecified).AddTicks(3416), 32L, "Vero saepe rerum accusamus sit ad accusantium.\nItaque voluptate tempora.", new DateTime(2023, 8, 19, 17, 5, 59, 973, DateTimeKind.Unspecified).AddTicks(357) },
                    { 120L, 27L, "Perspiciatis quia aut similique fuga. Debitis similique facilis eveniet. Totam veritatis harum laboriosam ut qui deleniti.", new DateTime(2023, 8, 15, 1, 12, 43, 536, DateTimeKind.Unspecified).AddTicks(5769), 40L, "Alias dolor optio.\nDebitis ipsa eaque pariatur dolorem porro.\nOmnis quis ut vel pariatur quia.\nEst blanditiis nihil vel dolorem.\nEarum neque nesciunt ut consequatur autem.", new DateTime(2023, 8, 17, 5, 47, 3, 232, DateTimeKind.Unspecified).AddTicks(888) },
                    { 121L, 11L, "Aspernatur maxime dolor voluptas quisquam.", new DateTime(2023, 4, 2, 14, 54, 29, 48, DateTimeKind.Unspecified).AddTicks(3608), 39L, "Fugit repudiandae eligendi sunt.", null },
                    { 122L, 60L, "voluptate", new DateTime(2023, 7, 29, 0, 32, 54, 784, DateTimeKind.Unspecified).AddTicks(7836), 2L, "Non porro aut et eaque.\nQuisquam voluptatem aut aut asperiores hic ut modi sint.\nEt maiores ut maiores enim accusantium.\nQuasi aut possimus sed omnis beatae.\nAt molestiae vel ipsa sunt.", new DateTime(2023, 8, 15, 10, 0, 36, 103, DateTimeKind.Unspecified).AddTicks(7271) },
                    { 123L, 38L, "Et culpa aspernatur aut excepturi aperiam cumque qui et.", new DateTime(2023, 6, 11, 15, 27, 26, 108, DateTimeKind.Unspecified).AddTicks(28), 38L, "Et a quas dolore vel inventore veniam tempore.", null },
                    { 124L, 143L, "et", new DateTime(2023, 7, 24, 3, 27, 44, 440, DateTimeKind.Unspecified).AddTicks(7390), 20L, "Voluptas corporis numquam non.\nSed necessitatibus ut repellat et dicta.\nQuos eligendi molestiae.\nAmet vitae et dolor.", new DateTime(2023, 7, 24, 15, 12, 2, 99, DateTimeKind.Unspecified).AddTicks(3556) },
                    { 125L, 26L, "Doloremque officiis perferendis vel non.\nOmnis quia et aspernatur dolores iure.\nVoluptas veritatis eaque qui accusamus.", new DateTime(2022, 6, 14, 21, 4, 56, 451, DateTimeKind.Unspecified).AddTicks(9192), 38L, "Vero tenetur esse officia impedit eligendi consequuntur ut velit.\nAutem voluptates sunt.", new DateTime(2023, 4, 18, 0, 59, 7, 110, DateTimeKind.Unspecified).AddTicks(3005) },
                    { 126L, 195L, "sint", new DateTime(2023, 4, 15, 5, 38, 4, 667, DateTimeKind.Unspecified).AddTicks(9248), 26L, "Dicta officia soluta nihil rerum et commodi et.", new DateTime(2023, 6, 17, 17, 54, 10, 650, DateTimeKind.Unspecified).AddTicks(5850) },
                    { 127L, 20L, "Et quisquam est eius ullam dicta cumque voluptatum repellendus. Recusandae consequatur debitis alias et dicta cupiditate ratione et eum. Veniam ab voluptatum ut assumenda consequatur dolorem impedit vitae assumenda. Et repudiandae consequatur ea. Dicta velit repellat rerum quia.", new DateTime(2023, 8, 22, 16, 33, 41, 348, DateTimeKind.Unspecified).AddTicks(7119), 28L, "Omnis omnis facilis ex fugit sapiente doloremque illo.\nRerum numquam libero quia soluta provident porro debitis voluptas.\nDolores qui sit delectus harum aliquam illum iusto.\nAccusamus earum cumque rerum enim possimus doloribus eius.\nTotam mollitia quia quod sequi vero doloremque voluptatem.", new DateTime(2023, 8, 23, 9, 56, 5, 599, DateTimeKind.Unspecified).AddTicks(3020) },
                    { 128L, 74L, "odio", new DateTime(2022, 9, 4, 9, 28, 29, 569, DateTimeKind.Unspecified).AddTicks(3871), 29L, "Quis qui aut aspernatur exercitationem non exercitationem amet eum amet. Ea esse eligendi enim asperiores velit ipsum. Reprehenderit in quia recusandae atque similique est. Vero qui recusandae. Cumque cumque assumenda et harum.", new DateTime(2023, 4, 1, 16, 39, 18, 322, DateTimeKind.Unspecified).AddTicks(7978) },
                    { 129L, 141L, "In voluptas soluta porro error nostrum mollitia enim commodi. Velit quae est non. Sunt et iusto animi saepe molestiae officiis.", new DateTime(2023, 7, 17, 8, 39, 19, 656, DateTimeKind.Unspecified).AddTicks(150), 37L, "Soluta minima ipsa.\nMaiores rerum est exercitationem explicabo et labore ipsa enim.\nExercitationem suscipit doloribus suscipit corrupti.\nSunt voluptatibus amet quo qui.\nAut consequatur magni.", new DateTime(2023, 7, 18, 12, 30, 51, 17, DateTimeKind.Unspecified).AddTicks(447) },
                    { 130L, 41L, "In vel ut aut placeat iste fuga. Non consectetur ratione corporis natus. Ut ipsum exercitationem quas optio sunt quia qui saepe itaque.", new DateTime(2023, 2, 10, 2, 47, 18, 485, DateTimeKind.Unspecified).AddTicks(2510), 8L, "dolorem", new DateTime(2023, 2, 12, 10, 39, 20, 880, DateTimeKind.Unspecified).AddTicks(5756) },
                    { 131L, 55L, "Dolor deserunt a modi unde.", new DateTime(2023, 6, 28, 1, 20, 33, 191, DateTimeKind.Unspecified).AddTicks(6286), 28L, "Ut velit ut eos et sunt voluptatibus. Quas id qui amet. Aliquid aliquam atque voluptas similique qui eum quam est sint. Id sit dolor nisi culpa rerum maxime.", new DateTime(2023, 8, 4, 12, 22, 16, 585, DateTimeKind.Unspecified).AddTicks(1219) },
                    { 132L, 199L, "Deserunt adipisci eaque et. Non eius commodi molestiae laboriosam. Saepe voluptatibus labore ipsa qui illum.", new DateTime(2023, 8, 5, 11, 15, 19, 818, DateTimeKind.Unspecified).AddTicks(8962), 10L, "Quae autem quidem.\nIste doloribus praesentium repudiandae reprehenderit est nemo.\nMagnam reprehenderit asperiores amet vel distinctio.", new DateTime(2023, 8, 17, 7, 31, 39, 323, DateTimeKind.Unspecified).AddTicks(314) },
                    { 133L, 47L, "odit", new DateTime(2022, 12, 12, 10, 56, 40, 545, DateTimeKind.Unspecified).AddTicks(8393), 18L, "voluptas", new DateTime(2023, 7, 15, 21, 20, 51, 937, DateTimeKind.Unspecified).AddTicks(2580) },
                    { 134L, 10L, "Quibusdam iste praesentium molestias.\nEt nemo ut quod doloremque.\nFacilis officia dolore vero omnis sequi odio iure est iure.\nHarum rem quas modi voluptatem soluta.\nVoluptas quae rerum.\nVoluptatem adipisci et et voluptatem.", new DateTime(2023, 7, 28, 3, 23, 55, 505, DateTimeKind.Unspecified).AddTicks(5650), 4L, "Nobis laborum aut consequuntur. Dolor adipisci autem fuga eligendi dolorem. Nisi quod ex molestiae. Consequatur veritatis quae et delectus ut maiores explicabo laboriosam quia. Tempora quo alias. Praesentium qui nihil fugiat expedita nisi.", new DateTime(2023, 8, 5, 4, 52, 10, 344, DateTimeKind.Unspecified).AddTicks(4506) },
                    { 135L, 32L, "modi", new DateTime(2023, 6, 15, 8, 38, 20, 805, DateTimeKind.Unspecified).AddTicks(3013), 28L, "Voluptas nihil itaque ratione saepe rerum qui.\nImpedit doloribus aperiam et at qui voluptatem repellendus.\nLaboriosam omnis rerum aperiam occaecati ut rerum voluptates.\nEius quia officia.\nVoluptas molestiae eum et numquam occaecati ut at officia.\nVel maiores quia libero enim doloremque consectetur.", new DateTime(2023, 7, 16, 20, 10, 36, 951, DateTimeKind.Unspecified).AddTicks(7045) },
                    { 136L, 12L, "Voluptatem iusto exercitationem labore debitis nam. Magni tenetur modi est nobis. Non et rerum.", new DateTime(2023, 8, 23, 4, 20, 46, 448, DateTimeKind.Unspecified).AddTicks(8829), 15L, "Dolores ab in mollitia. Debitis dolorem provident dolorem asperiores. Aut cupiditate quis enim saepe. Id et impedit. Omnis vero dolorem dignissimos nihil nisi dolores possimus non impedit. Magni porro debitis odio sint voluptas delectus.", new DateTime(2023, 8, 23, 5, 6, 57, 903, DateTimeKind.Unspecified).AddTicks(2987) }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "Output", "SubmittedAt" },
                values: new object[,]
                {
                    { 137L, 69L, "Enim maxime aperiam.\nMinima eius eaque minima culpa adipisci incidunt.\nFuga sed est omnis.", new DateTime(2023, 8, 13, 0, 46, 42, 388, DateTimeKind.Unspecified).AddTicks(6207), 28L, "Facere consequatur dolores officiis reiciendis et rerum aliquam.\nEst blanditiis quisquam excepturi odit dolorum aperiam reprehenderit.\nMaiores et in sunt iusto exercitationem et nobis.", new DateTime(2023, 8, 16, 21, 20, 28, 790, DateTimeKind.Unspecified).AddTicks(9836) },
                    { 138L, 131L, "Reiciendis officia ad vel accusamus illo ullam rerum sapiente.", new DateTime(2023, 8, 21, 3, 2, 44, 571, DateTimeKind.Unspecified).AddTicks(4709), 3L, "Consequuntur rem quisquam quae consequatur et exercitationem.", new DateTime(2023, 8, 21, 19, 4, 48, 407, DateTimeKind.Unspecified).AddTicks(4491) },
                    { 139L, 44L, "Et nostrum iste ullam.", new DateTime(2023, 3, 11, 13, 47, 51, 168, DateTimeKind.Unspecified).AddTicks(5334), 14L, "Quam repellat officiis sed sint.", new DateTime(2023, 6, 29, 12, 57, 34, 947, DateTimeKind.Unspecified).AddTicks(6295) },
                    { 140L, 193L, "Non ipsum assumenda delectus rerum suscipit quia architecto. Aut doloribus optio non ut. Et voluptas maxime nisi provident aspernatur dicta. Animi amet provident expedita.", new DateTime(2023, 8, 5, 9, 48, 40, 961, DateTimeKind.Unspecified).AddTicks(6170), 37L, "Iure ut et nulla tenetur dignissimos accusantium vero voluptas.", new DateTime(2023, 8, 9, 6, 36, 29, 516, DateTimeKind.Unspecified).AddTicks(5618) },
                    { 141L, 188L, "aut", new DateTime(2022, 10, 8, 4, 26, 44, 983, DateTimeKind.Unspecified).AddTicks(3674), 25L, "Id minima ut itaque ducimus et. Voluptas ipsa ipsum dolor aut cum ipsa. Voluptates quo molestiae at reiciendis. Officia eum odio fugiat vel molestiae. Delectus itaque quisquam ut rerum non cum quos corrupti doloremque.", new DateTime(2023, 4, 18, 17, 11, 21, 688, DateTimeKind.Unspecified).AddTicks(1150) },
                    { 142L, 171L, "Quis veritatis repudiandae quia aliquid tenetur maiores est asperiores.\nSaepe laudantium odit.\nVoluptatum quisquam officiis.\nQui et dolorem.", new DateTime(2023, 8, 9, 17, 35, 29, 497, DateTimeKind.Unspecified).AddTicks(3552), 26L, "Aut nihil consequatur enim repudiandae.", new DateTime(2023, 8, 19, 7, 45, 11, 630, DateTimeKind.Unspecified).AddTicks(8668) },
                    { 143L, 93L, "explicabo", new DateTime(2022, 12, 22, 13, 52, 31, 143, DateTimeKind.Unspecified).AddTicks(8406), 22L, "Omnis officia voluptas commodi suscipit eius nam animi voluptatem molestiae.", new DateTime(2023, 6, 18, 1, 33, 5, 475, DateTimeKind.Unspecified).AddTicks(1424) },
                    { 144L, 181L, "fugit", new DateTime(2023, 4, 12, 16, 50, 6, 904, DateTimeKind.Unspecified).AddTicks(6360), 40L, "Odit dolor perspiciatis facilis quasi reiciendis qui velit.\nSimilique architecto aut aut.\nFugit occaecati nobis et eum dolore cumque quia in.\nVoluptas qui consequatur quia est blanditiis omnis qui ad libero.\nReiciendis ipsa quia exercitationem ex beatae magnam in qui.\nSunt aliquid officiis laborum ea iste ab aut sunt.", new DateTime(2023, 7, 9, 3, 52, 16, 925, DateTimeKind.Unspecified).AddTicks(8788) },
                    { 145L, 197L, "Nobis quod autem.\nCumque dignissimos rerum eos voluptatum natus est voluptatum.\nDucimus consequatur rerum aperiam.\nAut dolores excepturi consequatur.\nQui officia cumque tempore delectus mollitia eum et tempore eum.\nSimilique expedita distinctio.", new DateTime(2023, 4, 25, 17, 14, 32, 208, DateTimeKind.Unspecified).AddTicks(581), 37L, "accusamus", new DateTime(2023, 8, 9, 10, 10, 54, 622, DateTimeKind.Unspecified).AddTicks(5925) },
                    { 146L, 175L, "In perspiciatis explicabo et fuga.", new DateTime(2023, 6, 29, 1, 18, 10, 216, DateTimeKind.Unspecified).AddTicks(8476), 6L, "Quas ipsam quo et sunt repellat est et perspiciatis.\nVoluptatem aspernatur sunt.\nAut voluptatem quis.\nQuia adipisci voluptatem ipsa corrupti voluptates ducimus quaerat corporis.", new DateTime(2023, 8, 10, 6, 23, 52, 208, DateTimeKind.Unspecified).AddTicks(5805) },
                    { 147L, 11L, "unde", new DateTime(2023, 4, 26, 21, 23, 3, 234, DateTimeKind.Unspecified).AddTicks(3187), 26L, "Deserunt vitae officiis dolores veritatis molestiae autem tempore dolor.\nNostrum nam earum ratione.\nCommodi quia nobis laudantium eum non et fugiat optio.", new DateTime(2023, 6, 4, 22, 6, 14, 325, DateTimeKind.Unspecified).AddTicks(6760) },
                    { 148L, 27L, "Et sit eligendi dolor qui inventore sunt. Eligendi ut enim. Aut laudantium non. Alias adipisci eum. Sunt nihil necessitatibus reiciendis magnam quia quos aut perspiciatis.", new DateTime(2023, 8, 17, 19, 33, 10, 801, DateTimeKind.Unspecified).AddTicks(4588), 15L, "Labore optio minus aperiam laborum qui reiciendis repudiandae ut deserunt.", new DateTime(2023, 8, 19, 18, 56, 47, 18, DateTimeKind.Unspecified).AddTicks(113) },
                    { 149L, 56L, "Consequatur voluptas error.\nSoluta totam sed.", new DateTime(2020, 9, 20, 6, 32, 17, 793, DateTimeKind.Unspecified).AddTicks(6770), 13L, "Provident ad similique vitae sunt incidunt voluptatem aperiam.", new DateTime(2021, 8, 22, 20, 26, 58, 121, DateTimeKind.Unspecified).AddTicks(2970) },
                    { 150L, 100L, "veniam", new DateTime(2023, 7, 31, 9, 28, 5, 38, DateTimeKind.Unspecified).AddTicks(9523), 13L, "Nostrum velit harum iusto quos enim rerum quia.\nAliquid consequuntur sit voluptatem.\nQuia id ducimus quidem optio excepturi dolor ut quis.", new DateTime(2023, 8, 17, 18, 41, 9, 422, DateTimeKind.Unspecified).AddTicks(9791) },
                    { 151L, 96L, "Unde velit qui repudiandae et. Aspernatur dolor quaerat. Qui aspernatur ut et. Perferendis mollitia qui dolorem in.", new DateTime(2022, 9, 16, 2, 31, 5, 744, DateTimeKind.Unspecified).AddTicks(9933), 28L, "A iure dolorem voluptatem earum dicta natus architecto consequatur.\nQuasi culpa id sed sint recusandae et ut at.\nIpsam eum aut in voluptate adipisci.\nSequi nam voluptatibus minus quidem soluta.\nAssumenda non esse assumenda nesciunt optio optio quia.\nEnim ut voluptas.", new DateTime(2022, 11, 26, 21, 25, 39, 180, DateTimeKind.Unspecified).AddTicks(7119) },
                    { 152L, 82L, "temporibus", new DateTime(2023, 6, 9, 16, 11, 24, 65, DateTimeKind.Unspecified).AddTicks(2479), 17L, "In culpa nihil voluptates maxime eligendi.", new DateTime(2023, 6, 16, 20, 46, 31, 988, DateTimeKind.Unspecified).AddTicks(3828) },
                    { 153L, 27L, "Iure sint rerum consectetur nesciunt quod adipisci ex sed. Beatae et repudiandae rem blanditiis consequatur quas. Aliquam numquam consectetur rerum doloribus vero velit consequatur exercitationem. Facilis quia laudantium et maxime impedit nostrum eligendi. Aperiam harum soluta dolore modi. Molestiae fugiat dolore.", new DateTime(2023, 8, 20, 17, 43, 3, 206, DateTimeKind.Unspecified).AddTicks(4543), 1L, "In deserunt deserunt rerum minus in dignissimos cupiditate doloremque dolor. Ducimus atque quo commodi. Est facere sed. Omnis cupiditate totam non. Ut ut et et accusantium neque tempora. Possimus et culpa officiis temporibus.", new DateTime(2023, 8, 21, 4, 58, 10, 152, DateTimeKind.Unspecified).AddTicks(7498) },
                    { 154L, 108L, "Ut omnis molestias soluta necessitatibus sit.", new DateTime(2023, 2, 5, 10, 42, 10, 95, DateTimeKind.Unspecified).AddTicks(3215), 25L, "Facere consectetur ab quia eum et voluptas.", new DateTime(2023, 2, 6, 0, 56, 14, 749, DateTimeKind.Unspecified).AddTicks(6434) },
                    { 155L, 63L, "Facilis dolor neque eos quod quasi sit deserunt. Numquam qui laboriosam quia praesentium. Dolor voluptas libero et.", new DateTime(2023, 1, 8, 19, 38, 43, 746, DateTimeKind.Unspecified).AddTicks(9935), 6L, "Praesentium quos quisquam.\nNon enim impedit aliquam.\nIste ratione aperiam et eveniet qui quia facere.\nNihil mollitia repellendus voluptates expedita qui iste.", new DateTime(2023, 2, 14, 4, 1, 45, 844, DateTimeKind.Unspecified).AddTicks(318) },
                    { 156L, 199L, "Nesciunt et quia libero eos quos.", new DateTime(2023, 8, 11, 23, 6, 43, 372, DateTimeKind.Unspecified).AddTicks(5095), 34L, "Aut sunt ipsum adipisci ipsum mollitia voluptas qui occaecati repudiandae.\nAmet ut incidunt unde.", new DateTime(2023, 8, 16, 9, 57, 31, 445, DateTimeKind.Unspecified).AddTicks(2868) },
                    { 157L, 32L, "Est quis libero.", new DateTime(2023, 3, 10, 1, 29, 24, 53, DateTimeKind.Unspecified).AddTicks(6324), 33L, "Inventore sit quaerat sapiente ea porro est. Atque sed eum unde maiores. Rerum aperiam quia nostrum consectetur qui omnis fugiat ratione.", new DateTime(2023, 5, 24, 8, 38, 59, 631, DateTimeKind.Unspecified).AddTicks(4677) },
                    { 158L, 83L, "Exercitationem ea possimus reprehenderit laboriosam et amet. Aliquam blanditiis non aliquid praesentium nemo quo perferendis animi. Expedita dolorem vel nobis voluptas autem. Aperiam praesentium consequatur iure. Vero qui id aut dicta. Tempora iusto corporis eum.", new DateTime(2022, 10, 10, 2, 28, 43, 330, DateTimeKind.Unspecified).AddTicks(97), 16L, "Itaque error deleniti est quos voluptatem consequatur at praesentium incidunt. Qui laborum sint sapiente dolorem corporis adipisci vel. Doloribus mollitia omnis placeat ducimus modi. Repellendus neque sequi enim incidunt accusamus maxime ut. Maxime ut delectus quos.", new DateTime(2022, 12, 19, 15, 21, 52, 739, DateTimeKind.Unspecified).AddTicks(6901) },
                    { 159L, 84L, "Ut enim repellat amet iste fugit hic nisi. Minus et enim tempore modi est nemo a corrupti. Et laborum minus nihil tenetur. Rerum perferendis culpa velit.", new DateTime(2023, 5, 10, 1, 5, 23, 876, DateTimeKind.Unspecified).AddTicks(4747), 13L, "Placeat aut sint saepe sequi vitae tempore.\nQuibusdam natus nihil aut odit eligendi qui nesciunt quisquam.\nVoluptatem qui deserunt.\nInventore sed nulla ipsa a tempore aut.\nQui ut accusamus nam cupiditate.\nNihil quibusdam sequi officiis illum occaecati quasi illo.", null },
                    { 160L, 74L, "Enim laudantium maiores. Repudiandae voluptatibus quae aut. Alias et molestiae. Nesciunt eos dignissimos dolorem quia qui. Itaque reprehenderit culpa architecto ut consequatur tempora et adipisci nihil. Dolore excepturi eaque asperiores voluptate soluta eum.", new DateTime(2022, 5, 14, 5, 57, 31, 741, DateTimeKind.Unspecified).AddTicks(5309), 36L, "Ipsa placeat illum et rerum quidem voluptatem minima. Consequatur rerum ea non dolorem aut. Voluptates animi et possimus et sint cumque qui voluptate sint. Neque minus voluptas repellendus suscipit minus. Eveniet rerum voluptas quia.", new DateTime(2022, 7, 24, 11, 22, 59, 579, DateTimeKind.Unspecified).AddTicks(6531) },
                    { 161L, 119L, "expedita", new DateTime(2019, 12, 10, 3, 56, 57, 728, DateTimeKind.Unspecified).AddTicks(5642), 31L, "Fugit occaecati assumenda repellendus debitis delectus magni consequuntur ab. Praesentium quisquam quaerat doloribus perspiciatis facilis. Laborum libero facere enim labore quia nihil. Ut soluta laudantium dolores facilis quod error suscipit. Ab non asperiores alias blanditiis assumenda quae.", new DateTime(2022, 9, 14, 13, 19, 53, 534, DateTimeKind.Unspecified).AddTicks(4329) },
                    { 162L, 199L, "dicta", new DateTime(2023, 8, 1, 3, 47, 56, 991, DateTimeKind.Unspecified).AddTicks(2788), 27L, "Quae quia dolorem mollitia officiis in.\nVitae laboriosam veniam.", new DateTime(2023, 8, 16, 8, 28, 30, 803, DateTimeKind.Unspecified).AddTicks(1668) },
                    { 163L, 168L, "Earum suscipit et qui sequi ut nihil et est.", new DateTime(2023, 8, 23, 3, 1, 44, 117, DateTimeKind.Unspecified).AddTicks(5128), 36L, "Et mollitia vero asperiores quia eligendi reprehenderit. Repudiandae quia vel non sint fugit atque. Omnis consectetur nam pariatur temporibus ex. Ad corrupti rerum necessitatibus. Quia explicabo modi dolorum aut. Voluptates est consequatur repellat tempora maiores molestias.", new DateTime(2023, 8, 23, 7, 53, 8, 857, DateTimeKind.Unspecified).AddTicks(6399) },
                    { 164L, 156L, "Quia est praesentium fugit odit id.\nQui qui quas.", new DateTime(2023, 8, 15, 18, 48, 14, 683, DateTimeKind.Unspecified).AddTicks(1620), 23L, "Sed iure illum tenetur consectetur illum commodi quia quibusdam.", new DateTime(2023, 8, 21, 0, 44, 32, 317, DateTimeKind.Unspecified).AddTicks(6189) },
                    { 165L, 199L, "Facere voluptas eius at at quibusdam. Voluptas molestias alias illum fugiat. Modi dolores itaque sit. Corrupti sit vel sit et ullam. Dolorum placeat rerum dolores iusto voluptas qui iste quasi.", new DateTime(2023, 7, 27, 8, 49, 21, 225, DateTimeKind.Unspecified).AddTicks(2341), 10L, "Hic ut officia. Amet soluta illum unde autem natus. Veniam voluptatem dolores a molestiae. Similique quam eos et voluptatem incidunt. Molestiae enim architecto.", new DateTime(2023, 7, 31, 22, 49, 19, 132, DateTimeKind.Unspecified).AddTicks(8001) },
                    { 166L, 191L, "Sed eveniet sunt et. Dicta facere qui veritatis in distinctio rem itaque. Qui inventore et voluptate debitis voluptatem molestiae eaque ut. Repudiandae est in. Aut reprehenderit tenetur non sequi voluptatem voluptas. Non earum est est dolorem similique dolorem.", new DateTime(2023, 8, 5, 15, 16, 13, 932, DateTimeKind.Unspecified).AddTicks(5849), 6L, "Dolores et mollitia eius libero maiores debitis quisquam corporis.\nEx unde quo.\nMolestias sed aliquid.\nDignissimos magni voluptatem tempore delectus accusamus consequuntur iste.\nAut voluptatibus ea officiis necessitatibus aliquam fugit rem.", new DateTime(2023, 8, 18, 12, 16, 55, 571, DateTimeKind.Unspecified).AddTicks(2103) },
                    { 167L, 5L, "Voluptas ipsum vel incidunt qui ut delectus numquam dolores quia.\nDeleniti laudantium totam qui sunt fugit ut omnis.\nRerum sed totam nostrum mollitia sunt commodi dolore.\nTenetur rem atque rerum quo velit.", new DateTime(2023, 8, 13, 3, 4, 53, 995, DateTimeKind.Unspecified).AddTicks(9226), 28L, "Voluptates quo sit qui vel.\nDolorum quidem aut cum tempora autem id fuga.\nOptio perferendis natus cumque sunt quidem nesciunt ut porro.\nPerspiciatis id voluptatem mollitia placeat enim doloremque nisi.\nIusto itaque quisquam aut dolorem temporibus libero a natus.", new DateTime(2023, 8, 16, 17, 35, 31, 800, DateTimeKind.Unspecified).AddTicks(5107) },
                    { 168L, 32L, "Rerum repellat expedita est facere itaque corporis qui.\nEarum rem eaque quaerat ea adipisci qui vel amet.", new DateTime(2023, 7, 8, 2, 26, 14, 12, DateTimeKind.Unspecified).AddTicks(9101), 1L, "Minus repudiandae quam cum. Non eligendi architecto adipisci necessitatibus perspiciatis voluptate. Et aperiam nobis. Nobis repellat quam. Doloribus nulla velit et corporis veniam. Modi provident distinctio tempore numquam quos et vitae labore.", new DateTime(2023, 8, 5, 6, 33, 5, 568, DateTimeKind.Unspecified).AddTicks(241) },
                    { 169L, 112L, "Harum non omnis neque voluptas impedit quas itaque iste quibusdam.\nQuasi eius possimus exercitationem molestiae accusamus pariatur distinctio.", new DateTime(2023, 7, 12, 17, 6, 55, 65, DateTimeKind.Unspecified).AddTicks(2023), 8L, "officiis", new DateTime(2023, 8, 21, 12, 47, 54, 600, DateTimeKind.Unspecified).AddTicks(5659) },
                    { 170L, 32L, "non", new DateTime(2023, 7, 9, 4, 37, 42, 874, DateTimeKind.Unspecified).AddTicks(4510), 33L, "Sunt ut temporibus enim nostrum sunt molestias nam praesentium.", new DateTime(2023, 8, 8, 2, 7, 22, 952, DateTimeKind.Unspecified).AddTicks(5942) },
                    { 171L, 160L, "aut", new DateTime(2023, 3, 10, 2, 34, 18, 70, DateTimeKind.Unspecified).AddTicks(3534), 35L, "aliquam", new DateTime(2023, 5, 27, 18, 31, 43, 43, DateTimeKind.Unspecified).AddTicks(475) },
                    { 172L, 193L, "Est illo non ipsam et aut. Quod impedit qui minima rerum laudantium sed quam. Iure quo quasi eos.", new DateTime(2023, 8, 18, 9, 43, 50, 776, DateTimeKind.Unspecified).AddTicks(6756), 31L, "Earum molestiae quo libero rem architecto et.\nDelectus eius pariatur dignissimos blanditiis.\nQui non amet et sint maiores.\nQui quasi temporibus distinctio vel sed dicta qui facere.\nEt dolor corrupti ut necessitatibus omnis corporis consectetur libero sunt.\nIpsam qui laborum.", new DateTime(2023, 8, 19, 15, 49, 54, 713, DateTimeKind.Unspecified).AddTicks(1170) },
                    { 173L, 83L, "Aut quibusdam non ea quae consequatur explicabo. Provident tempora non corporis rerum distinctio delectus. Aliquam et aut debitis.", new DateTime(2022, 9, 10, 14, 3, 1, 803, DateTimeKind.Unspecified).AddTicks(4493), 30L, "saepe", new DateTime(2022, 11, 10, 12, 14, 18, 728, DateTimeKind.Unspecified).AddTicks(8004) },
                    { 174L, 22L, "Quo sint accusamus voluptas quis ut eligendi illo non.", new DateTime(2023, 8, 10, 17, 22, 34, 558, DateTimeKind.Unspecified).AddTicks(2228), 35L, "Magni iste et.\nNihil libero aspernatur.\nNatus doloribus adipisci consequatur adipisci consequatur doloribus veritatis quibusdam perferendis.", new DateTime(2023, 8, 20, 7, 25, 36, 757, DateTimeKind.Unspecified).AddTicks(5592) },
                    { 175L, 3L, "Expedita omnis ad magni est cumque.\nDolor fugit suscipit itaque enim sint molestias.\nEsse tempora pariatur voluptatem eos est sint voluptates harum.", new DateTime(2023, 5, 18, 10, 42, 32, 607, DateTimeKind.Unspecified).AddTicks(7884), 39L, "Vero consectetur quam eum eos sunt omnis.", new DateTime(2023, 7, 27, 16, 2, 4, 344, DateTimeKind.Unspecified).AddTicks(2301) },
                    { 176L, 53L, "Nihil esse aliquam et quia corrupti.", new DateTime(2023, 6, 17, 14, 49, 0, 770, DateTimeKind.Unspecified).AddTicks(1446), 13L, "commodi", new DateTime(2023, 8, 13, 4, 42, 4, 72, DateTimeKind.Unspecified).AddTicks(1790) },
                    { 177L, 134L, "Id pariatur facilis officiis non voluptas reprehenderit commodi minus.", new DateTime(2023, 6, 12, 20, 10, 1, 734, DateTimeKind.Unspecified).AddTicks(9976), 10L, "Unde a dolores praesentium eligendi et qui qui odio.", new DateTime(2023, 7, 19, 5, 58, 5, 861, DateTimeKind.Unspecified).AddTicks(5342) },
                    { 178L, 16L, "Rerum sequi eos sit optio minima.", new DateTime(2022, 6, 3, 0, 46, 2, 548, DateTimeKind.Unspecified).AddTicks(342), 20L, "enim", new DateTime(2022, 6, 27, 12, 29, 5, 128, DateTimeKind.Unspecified).AddTicks(2695) }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "Output", "SubmittedAt" },
                values: new object[,]
                {
                    { 179L, 70L, "ab", new DateTime(2023, 7, 8, 9, 11, 13, 415, DateTimeKind.Unspecified).AddTicks(975), 32L, "Itaque eos accusamus voluptas similique.\nVoluptatem similique ipsa culpa architecto deserunt dolores aut.", new DateTime(2023, 7, 17, 22, 1, 22, 648, DateTimeKind.Unspecified).AddTicks(3784) },
                    { 180L, 91L, "Enim consequatur modi ut.", new DateTime(2022, 5, 12, 18, 38, 49, 519, DateTimeKind.Unspecified).AddTicks(7739), 38L, "Dolorem velit sit qui beatae incidunt fugiat.\nEt ipsa officia qui facere.\nLabore error velit ut.", new DateTime(2022, 10, 3, 12, 32, 8, 839, DateTimeKind.Unspecified).AddTicks(581) },
                    { 181L, 197L, "Consequuntur libero voluptas facilis officiis tenetur rem minus. Harum in non excepturi ut ut. Quisquam praesentium et qui cumque voluptatem doloremque. Voluptatem quasi libero quibusdam. Eos rerum suscipit dolores ea.", new DateTime(2023, 2, 16, 18, 6, 55, 475, DateTimeKind.Unspecified).AddTicks(3130), 39L, "dolorem", new DateTime(2023, 6, 15, 20, 52, 40, 182, DateTimeKind.Unspecified).AddTicks(9283) },
                    { 182L, 128L, "qui", new DateTime(2023, 7, 16, 15, 24, 29, 749, DateTimeKind.Unspecified).AddTicks(618), 5L, "Iure ipsa sit facere officia.\nTempora et voluptatem.", new DateTime(2023, 8, 9, 2, 45, 11, 206, DateTimeKind.Unspecified).AddTicks(6205) },
                    { 183L, 68L, "Totam ut placeat veritatis et sequi quibusdam aut.", new DateTime(2023, 6, 2, 20, 40, 18, 958, DateTimeKind.Unspecified).AddTicks(5549), 35L, "Maiores illo soluta exercitationem nihil.\nFacere soluta et.\nExcepturi ad illum aut sunt laboriosam alias.\nOfficiis commodi quis aliquid repellat omnis amet.\nAut quo ut et vitae adipisci pariatur omnis et.", new DateTime(2023, 6, 20, 3, 48, 26, 392, DateTimeKind.Unspecified).AddTicks(8249) },
                    { 184L, 200L, "Inventore a ut non tenetur eos vel quibusdam. Nobis autem sint harum illo magni odit. Voluptatibus repudiandae ducimus eum non ipsam nihil.", new DateTime(2023, 8, 4, 6, 30, 13, 461, DateTimeKind.Unspecified).AddTicks(483), 29L, "accusamus", new DateTime(2023, 8, 10, 9, 58, 38, 4, DateTimeKind.Unspecified).AddTicks(700) },
                    { 185L, 90L, "Eligendi earum mollitia et non.", new DateTime(2023, 5, 13, 18, 7, 18, 653, DateTimeKind.Unspecified).AddTicks(5407), 17L, "reiciendis", new DateTime(2023, 7, 4, 17, 45, 25, 652, DateTimeKind.Unspecified).AddTicks(6855) },
                    { 186L, 119L, "Non nihil est sit a tempore enim non rerum. Necessitatibus dicta nesciunt illum id magnam vel aut nam. Fugit sed sit harum fugiat recusandae accusantium itaque perferendis aut. Sit quaerat saepe temporibus atque tempore at ut culpa nihil. Tenetur vitae ipsa veritatis qui id.", new DateTime(2022, 5, 10, 21, 26, 46, 566, DateTimeKind.Unspecified).AddTicks(2545), 5L, "Deserunt adipisci libero optio cum cupiditate perferendis sit. Est suscipit excepturi. Necessitatibus impedit dolorem voluptatem doloremque quia culpa a laboriosam. Sint nihil culpa.", new DateTime(2022, 7, 3, 12, 20, 23, 772, DateTimeKind.Unspecified).AddTicks(3492) },
                    { 187L, 119L, "facere", new DateTime(2019, 2, 10, 3, 4, 1, 107, DateTimeKind.Unspecified).AddTicks(1667), 40L, "ex", new DateTime(2019, 8, 13, 23, 48, 43, 227, DateTimeKind.Unspecified).AddTicks(5336) },
                    { 188L, 33L, "Recusandae sunt eveniet sed adipisci sit ut.\nIn quisquam nobis quod aliquam odit sequi.\nExplicabo quam quam velit et tempora labore omnis qui provident.\nUt et sint neque et quis dolorem sequi.\nConsequatur laudantium voluptates quaerat sed iste.", new DateTime(2023, 5, 8, 11, 36, 11, 674, DateTimeKind.Unspecified).AddTicks(8992), 21L, "Commodi aut debitis. Quia sit ut ut quaerat laborum. Pariatur dolores iure distinctio laborum repellat quos distinctio. Voluptas blanditiis molestiae tenetur est sit harum.", new DateTime(2023, 6, 14, 22, 32, 39, 507, DateTimeKind.Unspecified).AddTicks(7050) },
                    { 189L, 129L, "Molestiae voluptas quibusdam eos ut. Nobis accusantium numquam dignissimos in tempore architecto. Est sed et amet. Corporis et tempore et quo voluptatem eum accusantium architecto. Quaerat voluptas maiores odio voluptatem ut.", new DateTime(2023, 8, 8, 5, 9, 45, 819, DateTimeKind.Unspecified).AddTicks(7580), 25L, "Possimus itaque beatae et numquam excepturi ratione excepturi. Ut excepturi laboriosam veniam consectetur quae reprehenderit. Facere sint dicta voluptas sint deserunt.", new DateTime(2023, 8, 10, 0, 6, 53, 639, DateTimeKind.Unspecified).AddTicks(2153) },
                    { 190L, 88L, "illo", new DateTime(2022, 12, 24, 10, 27, 53, 265, DateTimeKind.Unspecified).AddTicks(6195), 14L, "debitis", new DateTime(2023, 7, 25, 6, 59, 5, 642, DateTimeKind.Unspecified).AddTicks(3207) },
                    { 191L, 188L, "Velit error excepturi dolorem omnis natus.", new DateTime(2022, 5, 15, 13, 2, 4, 515, DateTimeKind.Unspecified).AddTicks(2429), 6L, "reiciendis", new DateTime(2023, 1, 31, 13, 7, 3, 588, DateTimeKind.Unspecified).AddTicks(5133) },
                    { 192L, 6L, "Labore nisi totam temporibus voluptatem reprehenderit iste minima quas. Harum alias nulla voluptas dolorem. Maiores exercitationem quas occaecati.", new DateTime(2022, 8, 17, 12, 49, 5, 268, DateTimeKind.Unspecified).AddTicks(2470), 22L, "Fugiat ab mollitia aut voluptatibus et amet quos.", new DateTime(2023, 4, 14, 16, 7, 35, 108, DateTimeKind.Unspecified).AddTicks(458) },
                    { 193L, 62L, "Adipisci sit aut incidunt quia quas molestiae quae.\nQuis est debitis in.\nNisi deserunt praesentium omnis.\nEsse adipisci nostrum velit ut explicabo aut.\nId dolor velit in harum velit ullam aut.", new DateTime(2023, 8, 19, 16, 32, 11, 545, DateTimeKind.Unspecified).AddTicks(8618), 36L, "Explicabo commodi voluptas consequuntur omnis nulla est.", new DateTime(2023, 8, 21, 0, 26, 1, 162, DateTimeKind.Unspecified).AddTicks(5240) },
                    { 194L, 37L, "Accusantium nisi quos et est odit eos ipsam.\nVoluptatem voluptatem recusandae quibusdam eos totam minima vitae vero.", new DateTime(2019, 10, 12, 8, 2, 2, 14, DateTimeKind.Unspecified).AddTicks(4135), 8L, "consequatur", new DateTime(2022, 4, 5, 19, 40, 39, 268, DateTimeKind.Unspecified).AddTicks(7756) },
                    { 195L, 45L, "Explicabo autem et voluptatem perferendis itaque est quasi aut. Debitis ea tenetur ab. Aut quis repudiandae vel quod voluptas quidem.", new DateTime(2023, 8, 16, 19, 21, 36, 68, DateTimeKind.Unspecified).AddTicks(922), 15L, "Unde illum qui nulla illo pariatur praesentium aut dicta.", new DateTime(2023, 8, 19, 11, 51, 15, 604, DateTimeKind.Unspecified).AddTicks(721) },
                    { 196L, 82L, "In voluptatum rerum reiciendis cum velit dolores. Atque ex provident maiores minima rerum blanditiis aut. Id adipisci atque. Sit tenetur quod architecto voluptatem animi dolorem eos ea. Asperiores tenetur non dignissimos. Vel pariatur officiis voluptate.", new DateTime(2023, 7, 26, 5, 0, 50, 707, DateTimeKind.Unspecified).AddTicks(3662), 33L, "Similique dolores molestiae illum.", new DateTime(2023, 8, 3, 15, 30, 39, 503, DateTimeKind.Unspecified).AddTicks(2172) },
                    { 197L, 89L, "Assumenda vel occaecati ratione et.\nConsequatur enim et vitae sit.\nAperiam et quas nostrum qui et minus.\nDolorem iste ducimus praesentium vel aliquam molestias adipisci inventore.\nAspernatur nam enim culpa odio veritatis facilis ut earum.", new DateTime(2023, 7, 13, 8, 57, 35, 775, DateTimeKind.Unspecified).AddTicks(3172), 26L, "Impedit corrupti enim.\nRepellendus quod ut voluptatum similique veritatis.\nItaque quia numquam recusandae veritatis sit et pariatur laborum.\nDistinctio maiores occaecati enim qui.", new DateTime(2023, 8, 2, 17, 52, 51, 798, DateTimeKind.Unspecified).AddTicks(5606) },
                    { 198L, 30L, "amet", new DateTime(2023, 7, 15, 9, 11, 46, 432, DateTimeKind.Unspecified).AddTicks(1885), 39L, "nulla", new DateTime(2023, 8, 2, 17, 23, 1, 122, DateTimeKind.Unspecified).AddTicks(5134) },
                    { 199L, 152L, "Enim aperiam rerum sit autem tempora consequuntur.", new DateTime(2022, 5, 24, 14, 59, 46, 775, DateTimeKind.Unspecified).AddTicks(7721), 34L, "Libero maiores possimus ab quas.\nFugit sit fugit praesentium dolorem architecto omnis error facere.\nConsequatur aut repudiandae.\nSit vitae quia libero iure hic harum itaque beatae in.\nEt deserunt perferendis unde sed.\nQuibusdam blanditiis ex enim dolores est.", new DateTime(2022, 9, 25, 19, 45, 38, 145, DateTimeKind.Unspecified).AddTicks(5880) },
                    { 200L, 183L, "Sequi libero alias odit officia distinctio dicta distinctio omnis.\nDolor aliquam porro qui.\nDeleniti placeat perferendis omnis rerum sunt sint iste deserunt.", new DateTime(2023, 6, 11, 19, 31, 35, 548, DateTimeKind.Unspecified).AddTicks(7007), 20L, "et", new DateTime(2023, 7, 31, 3, 24, 56, 536, DateTimeKind.Unspecified).AddTicks(8244) }
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
