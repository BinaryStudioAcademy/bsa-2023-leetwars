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
                    { 1L, new DateTime(1993, 2, 24, 9, 18, 32, 656, DateTimeKind.Utc).AddTicks(2617), 26, "Josue41@hotmail.com", "Grayson", "wymtrpbcdupodqfwhkxtmnyngfjrqv.jpg", false, true, "Tremblay", "j5xii6spbrvfvasc6b42i4qkxc0xih8e", new DateTime(2016, 9, 22, 8, 49, 28, 873, DateTimeKind.Utc).AddTicks(5136), 1, 0, -1, 60915L, "Emmalee_West0" },
                    { 2L, new DateTime(1988, 2, 12, 22, 44, 58, 841, DateTimeKind.Utc).AddTicks(3506), 25, "Mitchel4@yahoo.com", "Kristopher", "ooilkjpddwfvomzpbjspeczybqrwsj.jpg", false, true, "Blanda", "7mg6vwys190zw8d8ke20ld5fvglddroq", new DateTime(2020, 11, 15, 9, 3, 8, 675, DateTimeKind.Utc).AddTicks(3749), 3, 2, 2, 34838L, "Blake631" },
                    { 3L, new DateTime(1991, 9, 27, 20, 32, 48, 50, DateTimeKind.Utc).AddTicks(2864), 7, "Kay29@hotmail.com", "Deja", "uruwlaikhplhphodpuwfuzkjbswrhw.jpg", false, false, "Haley", "tjpdyqzs4d07s1t1uan24qztisafsq5n", new DateTime(2016, 12, 8, 9, 43, 9, 39, DateTimeKind.Utc).AddTicks(7782), 1, 3, 10, 23246L, "Jacquelyn182" },
                    { 4L, new DateTime(1993, 1, 5, 19, 57, 27, 174, DateTimeKind.Utc).AddTicks(9656), 28, "Kara_Ankunding3@yahoo.com", "Rachel", "ftbpxwdlozkfjcjhymqzvyibmqypyw.jpg", false, true, "Pagac", "swlmxpoand6djta9thu2lj8l69e03awj", new DateTime(2020, 7, 12, 4, 34, 13, 249, DateTimeKind.Utc).AddTicks(7274), 2, 0, 0, 76727L, "Jayda.Doyle3" },
                    { 5L, new DateTime(1980, 9, 23, 6, 52, 56, 292, DateTimeKind.Utc).AddTicks(167), 22, "Orval.Erdman74@yahoo.com", "Loma", "xhgrzkqhrfjmqxwpuqbifmzszvswxf.jpg", false, true, "Schultz", "vhfskfyumcicwffr5ljwzkq4jfaio5ps", new DateTime(2020, 11, 1, 4, 37, 36, 586, DateTimeKind.Utc).AddTicks(9121), 1, 1, 10, 82585L, "Deangelo.Sch4" },
                    { 6L, new DateTime(1981, 3, 5, 1, 59, 53, 769, DateTimeKind.Utc).AddTicks(7548), 23, "Damon33@gmail.com", "Vernice", "zghthgddlemqszlbosihchaoaiswsg.jpg", false, true, "Armstrong", "gikge714qk6b6sj23v3hqhbu8p7rqzk9", new DateTime(2016, 3, 20, 16, 34, 46, 707, DateTimeKind.Utc).AddTicks(9385), 0, 2, 12, 28021L, "Merlin_Schul5" },
                    { 7L, new DateTime(1988, 10, 5, 3, 59, 54, 595, DateTimeKind.Utc).AddTicks(4360), 32, "Ursula_Ferry23@gmail.com", "Helene", "nyetfrahktaxxzcpauiwmimoslqztu.jpg", false, true, "Abbott", "qqh5orrb2v8q09r7w35exfiwr7gm0s20", new DateTime(2022, 3, 7, 14, 42, 6, 253, DateTimeKind.Utc).AddTicks(2973), 2, 3, -6, 73975L, "Norwood.Buck6" },
                    { 8L, new DateTime(1985, 9, 28, 21, 8, 34, 884, DateTimeKind.Utc).AddTicks(7502), 3, "Jordyn_Lindgren@hotmail.com", "Maybell", "iwigpkmhdhhvffkgmuduvpfrchbxfv.jpg", false, true, "Roberts", "h8j77ro0ucs1neglfjvyapdp0qmm5bcl", new DateTime(2020, 6, 5, 13, 27, 9, 546, DateTimeKind.Utc).AddTicks(7444), 1, 3, -12, 652L, "Henriette.Ni7" },
                    { 9L, new DateTime(1983, 10, 27, 19, 37, 38, 966, DateTimeKind.Utc).AddTicks(8052), 20, "Jaunita.Spencer@gmail.com", "Janie", "gnuwvemdbwnafziplilofkvtpsguuk.jpg", false, true, "Wilkinson", "ogtjst16gthiilfsssm8s5eytvo094yp", new DateTime(2020, 4, 7, 3, 54, 32, 861, DateTimeKind.Utc).AddTicks(8103), 2, 0, -11, 66960L, "Providenci_A8" },
                    { 10L, new DateTime(1987, 9, 8, 2, 6, 58, 381, DateTimeKind.Utc).AddTicks(1715), 40, "Patricia.Walker@yahoo.com", "Donald", "oqnbwsydaxiwuewkjpdqcrngvxdzlr.jpg", false, false, "Torphy", "h6iks1o0by8djdjq9j0uz6st1v398ylx", new DateTime(2021, 7, 21, 14, 11, 35, 626, DateTimeKind.Utc).AddTicks(875), 1, 1, -9, 21532L, "Leanne_Bedna9" },
                    { 11L, new DateTime(1986, 10, 30, 13, 4, 23, 299, DateTimeKind.Utc).AddTicks(430), 57, "Asa_Nicolas@hotmail.com", "Eunice", "priksnyykujihsezkjbefcqwqlhszo.jpg", false, true, "Greenholt", "5b0y2o3roofvbkxu20z6aqkfri1fr987", new DateTime(2022, 8, 7, 20, 4, 22, 707, DateTimeKind.Utc).AddTicks(3342), 3, 2, -11, 33445L, "Chandler.Hom10" },
                    { 12L, new DateTime(1990, 5, 6, 18, 6, 2, 959, DateTimeKind.Utc).AddTicks(5583), 50, "Verda.Schinner@gmail.com", "Madilyn", "tugltpfoqrzklfxmywntjmhqafslsy.jpg", false, true, "Pollich", "gywyh6k7aq42u6naxifb52alw8hmejvr", new DateTime(2022, 11, 24, 19, 6, 16, 602, DateTimeKind.Utc).AddTicks(1405), 2, 0, -12, 50225L, "Gavin_Reinge11" },
                    { 13L, new DateTime(1990, 5, 3, 11, 10, 44, 617, DateTimeKind.Utc).AddTicks(9801), 37, "Willard18@gmail.com", "Mohamed", "zkukribgryvtwjfdzqulusklmnzppj.jpg", false, true, "McClure", "nm9prgxtd6gh1ywtx83i5cyueazcw5bg", new DateTime(2017, 7, 15, 19, 8, 59, 160, DateTimeKind.Utc).AddTicks(2131), 1, 1, -8, 15042L, "Ole6512" },
                    { 14L, new DateTime(1993, 5, 20, 23, 4, 4, 892, DateTimeKind.Utc).AddTicks(7492), 48, "Jovany_Pacocha@yahoo.com", "Celestine", "mbfhrkhmloxfwzwtqtiuqiizcjwcqo.jpg", true, true, "Gibson", "t8kkzk20i2u5bm92rzgxssct55q96bj7", new DateTime(2021, 1, 5, 20, 47, 2, 753, DateTimeKind.Utc).AddTicks(8380), 3, 2, 4, 28772L, "Leopold6513" },
                    { 15L, new DateTime(1989, 5, 9, 11, 50, 28, 465, DateTimeKind.Utc).AddTicks(1597), 40, "Maxwell_Bauch@hotmail.com", "Lonny", "qstbwtlvvvvenqikwpkmzegeocxrdb.jpg", false, true, "Feeney", "k5qnk35pswu6gus1qa5mt3m4xggkhsur", new DateTime(2017, 10, 31, 12, 45, 3, 764, DateTimeKind.Utc).AddTicks(6678), 3, 1, 5, 87680L, "Deonte.Waelc14" },
                    { 16L, new DateTime(1997, 11, 14, 20, 7, 26, 876, DateTimeKind.Utc).AddTicks(4806), 37, "Joanne_Hilll@yahoo.com", "Chloe", "nglnpscrpfzbcnspdpwfyjqhcndtaf.jpg", false, true, "Schowalter", "zf785is5u5zjnytgi90u9wifk5m5f3kc", new DateTime(2021, 12, 3, 17, 35, 35, 701, DateTimeKind.Utc).AddTicks(1014), 1, 0, 2, 86138L, "Juanita_Mona15" },
                    { 17L, new DateTime(1993, 9, 6, 15, 13, 11, 647, DateTimeKind.Utc).AddTicks(3510), 34, "Jaylan88@yahoo.com", "Vince", "teycxuraxqstoqygsgpqxvbhdvfely.jpg", true, true, "Russel", "os3plgg5o27c94814kghx80czw3ny3kh", new DateTime(2022, 2, 15, 8, 46, 55, 236, DateTimeKind.Utc).AddTicks(6713), 3, 3, 11, 86419L, "Maybell_DuBu16" },
                    { 18L, new DateTime(1993, 2, 5, 1, 11, 38, 546, DateTimeKind.Utc).AddTicks(688), 10, "Amber_Botsford72@hotmail.com", "Kendall", "yalusssjufpnsuieijhnzrjrmxliep.jpg", false, true, "Marks", "vewqmyi5x5b40dz0qr8rqpe5q9mratae", new DateTime(2021, 1, 8, 16, 49, 56, 372, DateTimeKind.Utc).AddTicks(7349), 0, 1, -8, 98054L, "Kamille_Kirl17" },
                    { 19L, new DateTime(1992, 8, 30, 14, 11, 30, 71, DateTimeKind.Utc).AddTicks(9329), 40, "Jadon.Dibbert40@hotmail.com", "Carli", "wdatzjitwcwyyvavktqwcpghyxppcv.jpg", false, false, "Koch", "mmbsb65vzr1waca9wtzu2f17aawqs3rp", new DateTime(2021, 2, 7, 15, 18, 33, 214, DateTimeKind.Utc).AddTicks(3764), 0, 1, -7, 17124L, "Breanne_Dool18" },
                    { 20L, new DateTime(1980, 3, 2, 13, 30, 17, 557, DateTimeKind.Utc).AddTicks(4008), 18, "Zion_Osinski62@hotmail.com", "Joyce", "fueodmahlcwaifgxbrthdenrfjczzt.jpg", false, false, "Rowe", "43z3g99nhpij8fvuhz10y09hg18idrd1", new DateTime(2020, 9, 7, 23, 36, 33, 77, DateTimeKind.Utc).AddTicks(5794), 2, 3, 7, 24724L, "Rosalind2919" },
                    { 21L, new DateTime(1980, 10, 16, 19, 14, 19, 862, DateTimeKind.Utc).AddTicks(216), 52, "Rachelle.Hickle94@gmail.com", "Gordon", "zudvnqlathsimfomcvggbkoufswcds.jpg", false, true, "Dietrich", "0w92cwtxhmbyu4hpaeelpjmvwk8bmtrc", new DateTime(2021, 1, 19, 3, 19, 19, 339, DateTimeKind.Utc).AddTicks(5948), 0, 1, 8, 40527L, "Alfred_Saway20" },
                    { 22L, new DateTime(1985, 1, 13, 10, 52, 46, 135, DateTimeKind.Utc).AddTicks(4769), 43, "Emmy.Lakin@yahoo.com", "Cayla", "rozmgketrnirwzbuvrrxnuyneayuau.jpg", false, true, "Heaney", "04fbnc2sjm74y5uorx0slntixwlga9ge", new DateTime(2021, 5, 15, 5, 48, 45, 619, DateTimeKind.Utc).AddTicks(969), 3, 2, -7, 53546L, "Liliane5521" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Country", "Email", "FirstName", "ImagePath", "IsBanned", "IsSubscribed", "LastName", "OAuthToken", "RegisteredAt", "Sex", "Status", "Timezone", "TotalScore", "UserName" },
                values: new object[,]
                {
                    { 23L, new DateTime(1985, 8, 1, 11, 42, 11, 968, DateTimeKind.Utc).AddTicks(9187), 38, "Marion1@hotmail.com", "Amber", "tgfihyjttpnhevkcqqlgqhbootvocv.jpg", false, false, "Brown", "rr0gmho5wb5kz3jtwuzq4130eh6osi3t", new DateTime(2019, 3, 2, 18, 44, 2, 515, DateTimeKind.Utc).AddTicks(9916), 3, 3, 6, 71204L, "Andre_Pacoch22" },
                    { 24L, new DateTime(1981, 12, 15, 1, 48, 9, 700, DateTimeKind.Utc).AddTicks(1476), 8, "Aaliyah_Rempel56@hotmail.com", "Jazmyn", "jrtrabdizjkfixbguoeqciqhzyieer.jpg", false, true, "Robel", "2n49a9328n2le4cwq59q76ocg10gp3pz", new DateTime(2017, 3, 21, 18, 53, 43, 247, DateTimeKind.Utc).AddTicks(7641), 1, 1, 6, 7810L, "Bobbie3023" },
                    { 25L, new DateTime(1985, 11, 24, 0, 20, 19, 826, DateTimeKind.Utc).AddTicks(4962), 4, "Tobin17@yahoo.com", "Mozelle", "xlmxzuuggqieyblcvqvrompmwetzem.jpg", false, true, "Haag", "jnvj2oveqbadjje5li2tqa8jmgvz0t0t", new DateTime(2017, 9, 6, 12, 5, 30, 835, DateTimeKind.Utc).AddTicks(499), 3, 0, 4, 38713L, "Juliet_McClu24" },
                    { 26L, new DateTime(1993, 11, 24, 21, 15, 2, 804, DateTimeKind.Utc).AddTicks(8752), 5, "Armand.Rempel@gmail.com", "Grayson", "xitgliyqvwkyhlhulswfnhpiktelnv.jpg", false, true, "Torp", "wa9rxq0u8xgdxc0y6wv4ldvcqlqfto5h", new DateTime(2021, 12, 7, 2, 10, 11, 389, DateTimeKind.Utc).AddTicks(5713), 0, 3, -10, 54533L, "Jess9125" },
                    { 27L, new DateTime(1988, 10, 31, 8, 24, 19, 549, DateTimeKind.Utc).AddTicks(3428), 5, "Emilia.Kling@gmail.com", "Kristian", "okfolxaizpaouzgxkxhqjijaxypofn.jpg", false, true, "Konopelski", "3d5wxosenri7j6jw5rwgue5wv726nhag", new DateTime(2016, 12, 2, 17, 15, 3, 817, DateTimeKind.Utc).AddTicks(9813), 1, 1, 4, 87203L, "Thad3726" },
                    { 28L, new DateTime(1980, 6, 15, 22, 55, 6, 657, DateTimeKind.Utc).AddTicks(6478), 43, "Javon_Ziemann68@gmail.com", "Wayne", "uqsfgasqptelbcbswmhriiwdpuslxs.jpg", false, true, "Funk", "nofrburg6udyi72222qflij5dfrklgaa", new DateTime(2023, 3, 31, 9, 53, 38, 314, DateTimeKind.Utc).AddTicks(5222), 3, 0, 0, 30201L, "Kariane7927" },
                    { 29L, new DateTime(1999, 3, 13, 16, 23, 36, 572, DateTimeKind.Utc).AddTicks(126), 0, "Arely_Lehner68@hotmail.com", "Herta", "lcddhkwcfwsocfpcobtgomefcvaqcm.jpg", false, false, "Gutkowski", "2rnlaszcqww3qklv858ligye5yxx1fd9", new DateTime(2016, 10, 24, 22, 13, 15, 872, DateTimeKind.Utc).AddTicks(6366), 2, 3, 12, 49377L, "Haylie_Hane28" },
                    { 30L, new DateTime(1990, 2, 22, 7, 30, 2, 825, DateTimeKind.Utc).AddTicks(3845), 6, "Linnie_Friesen@yahoo.com", "Dagmar", "kmzpugliwbhinqcauqytflmhecbsfi.jpg", false, true, "Hahn", "astjvjq65n1mx2wzbpcqs0aumy0ogp7q", new DateTime(2018, 1, 22, 22, 40, 37, 216, DateTimeKind.Utc).AddTicks(6242), 2, 2, 0, 99608L, "Rosetta_Herm29" },
                    { 31L, new DateTime(1992, 7, 5, 16, 55, 47, 144, DateTimeKind.Utc).AddTicks(6842), 56, "Gayle.Cronin36@yahoo.com", "Lexi", "mnhmzxxnbtllinkiknixumeoaeamoh.jpg", false, true, "Kohler", "axvdnzg0i3v17v0td324zngfl0crhtwf", new DateTime(2022, 8, 8, 11, 21, 25, 940, DateTimeKind.Utc).AddTicks(7073), 3, 1, 1, 95248L, "Earnestine.P30" },
                    { 32L, new DateTime(1989, 6, 11, 1, 21, 54, 551, DateTimeKind.Utc).AddTicks(7804), 26, "Clementina.Sanford45@yahoo.com", "Gerhard", "iqmluqqrnremcllmflgrgpqfkvtbgh.jpg", true, true, "Adams", "1z0ift2568r6ub1jotv1ycnq7q080xvl", new DateTime(2019, 3, 23, 2, 15, 30, 798, DateTimeKind.Utc).AddTicks(1241), 1, 2, -8, 57424L, "Daryl.Bailey31" },
                    { 33L, new DateTime(1989, 6, 10, 17, 32, 33, 414, DateTimeKind.Utc).AddTicks(6334), 41, "Charlene93@gmail.com", "Anibal", "efirihhruvdgietprwccugqxcqvdzr.jpg", false, true, "Gaylord", "26syf9xyu59btlx0orc5nbq25ykelph6", new DateTime(2021, 1, 29, 10, 16, 0, 748, DateTimeKind.Utc).AddTicks(5117), 0, 3, 12, 38702L, "Ahmad7432" },
                    { 34L, new DateTime(1985, 9, 18, 12, 7, 8, 669, DateTimeKind.Utc).AddTicks(692), 7, "Wilford.Bernier77@gmail.com", "Mellie", "watlsvmrnjercqsvyohawmyiufrool.jpg", false, true, "Zemlak", "iqeeu30jqk9s5cu9rtp60ho1wd2emh4x", new DateTime(2022, 5, 13, 23, 47, 31, 267, DateTimeKind.Utc).AddTicks(6590), 0, 3, -2, 67055L, "Uriah.Sipes33" },
                    { 35L, new DateTime(1984, 8, 23, 0, 30, 52, 491, DateTimeKind.Utc).AddTicks(9846), 26, "Jerrold_Lehner@yahoo.com", "Heath", "wjkabjnmapxglirbnkzcbcipryhvam.jpg", false, false, "Sporer", "w3092qnsdw6al8il9fe923jetr1td32n", new DateTime(2019, 1, 31, 2, 33, 1, 341, DateTimeKind.Utc).AddTicks(2489), 2, 2, 8, 18771L, "Merle3334" },
                    { 36L, new DateTime(1986, 1, 3, 18, 49, 34, 512, DateTimeKind.Utc).AddTicks(6), 7, "Alvera.Prosacco76@gmail.com", "Michaela", "kvoplirwlgwnwboskbelwjalmcgysi.jpg", false, true, "Beatty", "e67o4v8lqx9jas8evgkenmp0w1s34d2r", new DateTime(2019, 5, 30, 13, 36, 49, 382, DateTimeKind.Utc).AddTicks(3541), 0, 3, 4, 18001L, "Armando_Veum35" },
                    { 37L, new DateTime(1984, 4, 10, 16, 56, 4, 423, DateTimeKind.Utc).AddTicks(4479), 8, "Dangelo79@gmail.com", "Otha", "jirtmfucbdmjvmleyodsoxywhlupyo.jpg", false, true, "Harris", "v15aesf362etlbayepvwbnyi8hdsg1e6", new DateTime(2021, 10, 18, 19, 12, 39, 256, DateTimeKind.Utc).AddTicks(8438), 2, 1, -2, 56163L, "Dena736" },
                    { 38L, new DateTime(1987, 7, 10, 12, 45, 18, 739, DateTimeKind.Utc).AddTicks(5295), 41, "Eva71@yahoo.com", "Reyes", "bffcrbxlqqdrfrbbwtvpgdmhxfnesf.jpg", false, true, "Hudson", "40bg2b1bji66469d227lok7igxpy7gjq", new DateTime(2016, 3, 5, 4, 10, 24, 83, DateTimeKind.Utc).AddTicks(760), 1, 2, -9, 76635L, "Amie.Greenfe37" },
                    { 39L, new DateTime(1996, 9, 28, 0, 46, 10, 761, DateTimeKind.Utc).AddTicks(2751), 12, "Adan44@gmail.com", "Kendrick", "zdoovuadpccczmmsrdahlmodjwckyk.jpg", false, false, "Emmerich", "ypa2rkuzbkrg5yg4bxlamvhuzhkf6xpm", new DateTime(2022, 8, 15, 10, 27, 13, 494, DateTimeKind.Utc).AddTicks(5377), 0, 0, -2, 91228L, "Enid038" },
                    { 40L, new DateTime(1986, 5, 3, 0, 9, 9, 628, DateTimeKind.Utc).AddTicks(9643), 4, "Dejuan78@hotmail.com", "Mathilde", "qubflcgalujwdgyvbikgskybaizeyt.jpg", false, true, "Shields", "xejtjf26ctgvfvgmeqetmx4x38t17433", new DateTime(2021, 10, 14, 6, 11, 35, 946, DateTimeKind.Utc).AddTicks(1132), 2, 3, 12, 31229L, "Jaqueline.Le39" }
                });

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Instructions", "LevelId", "Title" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 1, 20, 20, 18, 23, 774, DateTimeKind.Utc).AddTicks(3851), 19L, "Perspiciatis cum et et laudantium.", 1, "We need to input the online SCSI firewall!" },
                    { 2L, new DateTime(2022, 7, 21, 11, 58, 40, 210, DateTimeKind.Utc).AddTicks(9894), 17L, "quis", 2, "Use the open-source SMS driver, then you can input" },
                    { 3L, new DateTime(2023, 1, 23, 15, 2, 46, 397, DateTimeKind.Utc).AddTicks(6076), 34L, "Aut rerum consectetur veniam distinctio officiis praesentium.\nAperiam quis qui animi omnis.\nMolestiae laboriosam exercitationem similique amet dolores quibusdam aspernatur consequatur quia.\nSuscipit consequuntur eos laborum facilis culpa.", 1, "If we back up the application, we can get to the G" },
                    { 4L, new DateTime(2021, 12, 31, 7, 14, 13, 779, DateTimeKind.Utc).AddTicks(7595), 20L, "Suscipit quia modi nobis ad eos voluptatum est.", 2, "Use the haptic JBOD transmitter, then you can hack" },
                    { 5L, new DateTime(2022, 12, 19, 6, 7, 2, 849, DateTimeKind.Utc).AddTicks(70), 33L, "Voluptatem possimus iure impedit enim provident incidunt molestiae earum.", 2, "I'll transmit the wireless USB driver, that should" },
                    { 6L, new DateTime(2023, 8, 15, 16, 44, 50, 100, DateTimeKind.Utc).AddTicks(87), 28L, "Distinctio rerum voluptatem aut iure nesciunt aut eos voluptatem molestias. Molestias reprehenderit tenetur hic. Esse repudiandae voluptatem quae impedit sed voluptates ratione minus in.", 3, "If we parse the feed, we can get to the SSL feed t" },
                    { 7L, new DateTime(2022, 6, 26, 4, 9, 15, 774, DateTimeKind.Utc).AddTicks(8388), 40L, "Molestiae quis nihil similique autem nemo numquam. Et ut ratione vel. Aperiam harum perferendis ad consequuntur.", 1, "We need to calculate the auxiliary HTTP applicatio" },
                    { 8L, new DateTime(2022, 1, 25, 8, 35, 1, 40, DateTimeKind.Utc).AddTicks(157), 26L, "et", 2, "I'll index the back-end RSS driver, that should dr" },
                    { 9L, new DateTime(2019, 4, 26, 13, 45, 35, 708, DateTimeKind.Utc).AddTicks(8402), 3L, "Quas maxime esse et dolores accusamus doloremque in magnam quos.\nSaepe incidunt modi recusandae saepe ut et.\nAccusamus sed maiores doloremque aut et aut praesentium quae.\nQui magni eum autem architecto accusamus dolore inventore expedita.\nEos velit optio asperiores dolores voluptas amet voluptatum deserunt.", 4, "The SAS pixel is down, hack the mobile pixel so we" },
                    { 10L, new DateTime(2017, 5, 27, 7, 33, 45, 769, DateTimeKind.Utc).AddTicks(8714), 6L, "Doloremque velit maiores unde at commodi.", 3, "You can't synthesize the firewall without transmit" },
                    { 11L, new DateTime(2021, 11, 9, 18, 38, 5, 948, DateTimeKind.Utc).AddTicks(5997), 40L, "Doloribus eveniet non aut fuga et.", 4, "Try to calculate the SMTP bus, maybe it will calcu" },
                    { 12L, new DateTime(2023, 4, 20, 23, 13, 35, 607, DateTimeKind.Utc).AddTicks(7186), 40L, "Est molestiae voluptatem eos assumenda et libero voluptatem et.\nAb maxime fuga nemo ad.\nNon illum ut iste ea perspiciatis.", 3, "The ADP array is down, generate the bluetooth arra" },
                    { 13L, new DateTime(2020, 12, 2, 17, 18, 35, 393, DateTimeKind.Utc).AddTicks(1153), 5L, "iure", 4, "The SMS driver is down, hack the optical driver so" },
                    { 14L, new DateTime(2021, 12, 26, 11, 52, 9, 917, DateTimeKind.Utc).AddTicks(3124), 30L, "Nostrum sit quia consequatur eos dolorem quo vel libero ut.\nIusto error quia ab.\nAutem quam et quia eum ea molestias eum dolore consequuntur.\nEligendi rerum nisi aspernatur et commodi libero cupiditate.\nMollitia molestias eaque quia dignissimos voluptas porro voluptas.", 3, "Try to copy the IB program, maybe it will copy the" },
                    { 15L, new DateTime(2021, 4, 3, 22, 29, 58, 348, DateTimeKind.Utc).AddTicks(6517), 5L, "Recusandae molestias id.", 3, "Use the wireless SDD circuit, then you can navigat" },
                    { 16L, new DateTime(2020, 1, 10, 15, 18, 22, 344, DateTimeKind.Utc).AddTicks(6609), 13L, "Corporis veniam vel et voluptas. Rerum quod facilis est nihil qui et rerum et non. Rerum culpa deserunt adipisci vero iure corporis. Quam odit reprehenderit. Atque cupiditate aut minus minus reprehenderit eos. Ipsam et aut nostrum assumenda explicabo rem.", 1, "If we bypass the port, we can get to the USB port " },
                    { 17L, new DateTime(2021, 3, 25, 11, 9, 38, 943, DateTimeKind.Utc).AddTicks(8463), 18L, "ratione", 4, "calculating the panel won't do anything, we need t" },
                    { 18L, new DateTime(2022, 12, 20, 7, 41, 24, 294, DateTimeKind.Utc).AddTicks(6903), 17L, "et", 4, "If we hack the program, we can get to the PCI prog" },
                    { 19L, new DateTime(2022, 6, 2, 8, 34, 1, 311, DateTimeKind.Utc).AddTicks(7200), 20L, "Sint doloribus sit aut ipsam maiores voluptatum voluptas in.", 3, "compressing the sensor won't do anything, we need " },
                    { 20L, new DateTime(2021, 5, 14, 14, 44, 2, 881, DateTimeKind.Utc).AddTicks(9793), 38L, "perspiciatis", 2, "I'll override the redundant AGP card, that should " },
                    { 21L, new DateTime(2021, 9, 26, 1, 28, 11, 205, DateTimeKind.Utc).AddTicks(5006), 23L, "Quisquam cum aut sunt sit suscipit similique voluptatem maxime qui. Quia aut exercitationem est provident enim rerum maiores. Voluptatem aut fugiat sunt exercitationem. Corrupti vitae ea eos enim similique. Fuga et enim ad laboriosam quaerat ut et. Et sed dolorum sunt quisquam incidunt et explicabo et.", 4, "Use the open-source EXE array, then you can connec" },
                    { 22L, new DateTime(2023, 4, 15, 18, 23, 4, 673, DateTimeKind.Utc).AddTicks(3492), 2L, "Id consequuntur nesciunt laudantium quaerat et suscipit quaerat recusandae nobis. Id corrupti vitae. Hic quisquam cumque aliquam qui. Quasi porro quisquam dicta voluptatibus.", 2, "The IB transmitter is down, quantify the optical t" },
                    { 23L, new DateTime(2023, 7, 1, 17, 12, 1, 103, DateTimeKind.Utc).AddTicks(3898), 35L, "Odit laudantium quibusdam nostrum fugiat dolores.", 4, "Use the back-end SMTP bus, then you can override t" },
                    { 24L, new DateTime(2021, 5, 22, 1, 52, 10, 636, DateTimeKind.Utc).AddTicks(208), 20L, "Sed voluptate iusto vel ad ea voluptates iure.\nAccusantium saepe iusto dolorum necessitatibus necessitatibus.", 3, "We need to reboot the haptic USB protocol!" },
                    { 25L, new DateTime(2023, 1, 14, 21, 5, 59, 635, DateTimeKind.Utc).AddTicks(1370), 11L, "eum", 4, "You can't reboot the bus without parsing the redun" },
                    { 26L, new DateTime(2021, 2, 5, 11, 25, 20, 329, DateTimeKind.Utc).AddTicks(6954), 18L, "Amet qui vel dignissimos maxime quo recusandae provident. Accusamus expedita delectus praesentium nam dolores accusamus. Mollitia iste unde voluptatem.", 1, "You can't calculate the program without hacking th" },
                    { 27L, new DateTime(2021, 3, 27, 1, 8, 34, 912, DateTimeKind.Utc).AddTicks(6140), 19L, "necessitatibus", 4, "I'll index the open-source JSON card, that should " },
                    { 28L, new DateTime(2019, 10, 21, 19, 25, 49, 472, DateTimeKind.Utc).AddTicks(8553), 23L, "Modi blanditiis aut sunt qui ut.\nVeritatis dignissimos deleniti.\nQuod ut aliquid voluptatum dolorem error.", 1, "If we parse the driver, we can get to the PNG driv" },
                    { 29L, new DateTime(2023, 1, 8, 23, 21, 59, 63, DateTimeKind.Utc).AddTicks(3121), 17L, "numquam", 3, "The PNG pixel is down, bypass the haptic pixel so " },
                    { 30L, new DateTime(2021, 5, 1, 4, 46, 9, 315, DateTimeKind.Utc).AddTicks(6526), 2L, "ut", 2, "The GB firewall is down, reboot the 1080p firewall" },
                    { 31L, new DateTime(2022, 6, 10, 5, 39, 52, 981, DateTimeKind.Utc).AddTicks(8915), 19L, "Eum ea sequi voluptas praesentium hic.\nVoluptatum voluptatem dolor consequatur distinctio et.\nAutem officia ut unde delectus repudiandae eum animi consectetur omnis.", 2, "You can't index the transmitter without compressin" },
                    { 32L, new DateTime(2023, 6, 3, 13, 34, 23, 80, DateTimeKind.Utc).AddTicks(1965), 13L, "quia", 4, "We need to back up the virtual SQL feed!" },
                    { 33L, new DateTime(2021, 9, 27, 12, 27, 56, 523, DateTimeKind.Utc).AddTicks(8183), 9L, "Sunt et est aliquam aut unde blanditiis.\nRepellendus dolorem autem.\nEos nihil veniam quia ipsa.\nOdit fuga illum nobis voluptatum deserunt in.", 2, "Try to program the COM alarm, maybe it will progra" },
                    { 34L, new DateTime(2023, 3, 2, 23, 23, 7, 127, DateTimeKind.Utc).AddTicks(2199), 7L, "Culpa voluptatem est sequi in sit quam.", 3, "The XSS matrix is down, transmit the cross-platfor" },
                    { 35L, new DateTime(2022, 10, 9, 20, 2, 47, 22, DateTimeKind.Utc).AddTicks(321), 34L, "Quisquam voluptate sequi magni soluta soluta qui voluptatem reprehenderit quo.", 1, "We need to navigate the digital RAM pixel!" },
                    { 36L, new DateTime(2022, 4, 5, 16, 0, 51, 741, DateTimeKind.Utc).AddTicks(2491), 4L, "Voluptatem quia ut ut doloribus ut et ratione suscipit. Est sunt veritatis. Quis ducimus laboriosam.", 1, "Try to input the JBOD driver, maybe it will input " },
                    { 37L, new DateTime(2020, 7, 21, 17, 45, 57, 630, DateTimeKind.Utc).AddTicks(3190), 38L, "iusto", 3, "The COM array is down, program the virtual array s" },
                    { 38L, new DateTime(2017, 8, 20, 17, 46, 21, 400, DateTimeKind.Utc).AddTicks(6499), 6L, "Omnis et et eum eum tempora nostrum a iure voluptatem. Expedita itaque quos quia soluta repellat quas perspiciatis. Sed consequatur numquam maxime. Enim quaerat ratione rerum sed quis. Ea dolores dolor eum vitae dolores vitae.", 3, "Use the solid state IB transmitter, then you can h" },
                    { 39L, new DateTime(2019, 10, 19, 14, 37, 28, 476, DateTimeKind.Utc).AddTicks(8970), 13L, "Expedita labore omnis omnis delectus doloremque possimus esse fugit.\nQui quasi pariatur et sed aliquam aut quo temporibus animi.\nNihil esse similique molestiae voluptas molestiae eum.\nImpedit et in nihil nihil et.", 4, "If we navigate the hard drive, we can get to the P" },
                    { 40L, new DateTime(2021, 2, 14, 2, 39, 56, 680, DateTimeKind.Utc).AddTicks(535), 27L, "Adipisci sint quibusdam.", 4, "bypassing the matrix won't do anything, we need to" },
                    { 41L, new DateTime(2019, 4, 26, 5, 4, 8, 624, DateTimeKind.Utc).AddTicks(9949), 23L, "Non non ea ab maxime est ratione. Et voluptate iusto ut. Minima nihil qui quaerat ratione aut.", 3, "I'll parse the virtual SCSI transmitter, that shou" },
                    { 42L, new DateTime(2022, 3, 12, 16, 40, 27, 556, DateTimeKind.Utc).AddTicks(8364), 23L, "Eos provident laborum placeat reprehenderit voluptatem.", 1, "indexing the hard drive won't do anything, we need" }
                });

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Instructions", "LevelId", "Title" },
                values: new object[,]
                {
                    { 43L, new DateTime(2023, 7, 9, 14, 31, 9, 217, DateTimeKind.Utc).AddTicks(8732), 23L, "Et dolor error quo doloremque harum explicabo.\nSed qui facere corporis sunt omnis voluptas corporis perspiciatis ut.\nEst rerum ad necessitatibus voluptatem.\nLaboriosam cupiditate dolorem eaque perspiciatis et.", 4, "You can't copy the port without parsing the wirele" },
                    { 44L, new DateTime(2021, 11, 6, 5, 8, 46, 532, DateTimeKind.Utc).AddTicks(9276), 21L, "Aut ex quis.\nEnim nulla eligendi est quam iusto.\nCumque harum saepe velit consequatur eligendi odit ut vero.\nDolorem sit vel sed nemo modi consequatur.", 2, "You can't parse the firewall without backing up th" },
                    { 45L, new DateTime(2021, 6, 1, 15, 19, 31, 714, DateTimeKind.Utc).AddTicks(8490), 35L, "Ut qui non dolores sunt enim fugiat quisquam cupiditate distinctio. Officiis reprehenderit quidem qui quis quia asperiores quaerat sapiente. Quia quia voluptatem magni et enim iure. Dolorum ut minus.", 2, "If we bypass the transmitter, we can get to the AI" },
                    { 46L, new DateTime(2023, 1, 4, 22, 32, 54, 947, DateTimeKind.Utc).AddTicks(6710), 7L, "Officia iusto rerum placeat temporibus corrupti et aut cumque.\nCommodi voluptatem laborum amet consequatur.\nA ducimus est ut reprehenderit.\nSit odit consequuntur.\nTempore magni nihil velit quos sed deleniti aliquid.\nEligendi nesciunt error mollitia et consequatur.", 1, "compressing the bus won't do anything, we need to " },
                    { 47L, new DateTime(2022, 6, 28, 12, 36, 16, 512, DateTimeKind.Utc).AddTicks(5883), 10L, "Earum laudantium molestias quam sed fuga explicabo vel corrupti in. Quibusdam et ut voluptatem facere. Magni qui pariatur reiciendis eveniet.", 1, "I'll parse the back-end XML protocol, that should " },
                    { 48L, new DateTime(2020, 12, 22, 16, 8, 52, 502, DateTimeKind.Utc).AddTicks(6232), 15L, "Sed rerum molestiae ad.\nItaque quas vel sint voluptas maxime assumenda.\nHic debitis tempore minus et quos quia repudiandae.\nUt laudantium ut.", 4, "We need to synthesize the haptic THX bandwidth!" },
                    { 49L, new DateTime(2023, 1, 6, 19, 11, 59, 692, DateTimeKind.Utc).AddTicks(6666), 34L, "vel", 1, "Use the wireless AI card, then you can back up the" },
                    { 50L, new DateTime(2022, 6, 2, 15, 41, 28, 531, DateTimeKind.Utc).AddTicks(6370), 34L, "Cum in ex nulla doloremque nostrum nemo quos.\nLaudantium corporis ut hic sapiente dolore sed architecto.\nIusto expedita rerum et pariatur optio ex aperiam dolorem placeat.\nAssumenda nesciunt nostrum pariatur corporis et doloribus quae.", 3, "You can't copy the sensor without navigating the d" },
                    { 51L, new DateTime(2021, 12, 21, 8, 51, 44, 282, DateTimeKind.Utc).AddTicks(8782), 38L, "Voluptatem iure quia labore pariatur id quia qui expedita quos.\nLaudantium natus dolorem rerum nemo perferendis quam est explicabo aliquam.\nIncidunt et qui.", 2, "The XML monitor is down, compress the 1080p monito" },
                    { 52L, new DateTime(2023, 3, 14, 0, 10, 14, 501, DateTimeKind.Utc).AddTicks(2014), 16L, "Fugiat illo alias error eligendi voluptatem.", 2, "You can't transmit the system without connecting t" },
                    { 53L, new DateTime(2018, 9, 14, 4, 16, 27, 407, DateTimeKind.Utc).AddTicks(4090), 29L, "Distinctio adipisci sequi vitae nulla. Corporis in labore nobis vel laudantium accusantium minus nihil quas. Sapiente quam vitae ea asperiores cum. Et illum temporibus placeat itaque et aliquam nostrum tempore ratione. Quia modi facere quia. Quaerat nostrum voluptatem.", 4, "Use the wireless GB protocol, then you can synthes" },
                    { 54L, new DateTime(2021, 4, 22, 5, 46, 43, 916, DateTimeKind.Utc).AddTicks(5053), 33L, "Necessitatibus libero sint ad culpa accusantium sed omnis praesentium.", 2, "Use the open-source ADP pixel, then you can input " },
                    { 55L, new DateTime(2023, 6, 29, 21, 56, 24, 7, DateTimeKind.Utc).AddTicks(2448), 31L, "Aut ut ut voluptates tempora ut commodi quos id. Dolores rerum eveniet quaerat dolores eligendi hic ipsum sit. Impedit fugiat numquam ad rerum atque tempore vero ipsa ab. Consequatur vitae hic omnis cumque perspiciatis consequatur ex omnis.", 1, "overriding the port won't do anything, we need to " },
                    { 56L, new DateTime(2022, 5, 14, 18, 1, 42, 574, DateTimeKind.Utc).AddTicks(7173), 26L, "Sunt ut fugit minima facere optio accusantium.\nDeserunt molestias ducimus omnis voluptatibus quos aut rerum.\nQuibusdam ratione qui illum quam modi.", 4, "I'll bypass the digital XSS pixel, that should pix" },
                    { 57L, new DateTime(2018, 9, 21, 0, 35, 11, 499, DateTimeKind.Utc).AddTicks(7655), 15L, "Minus quo dolores rerum pariatur nisi.\nDolorem dolore laborum corporis reiciendis dignissimos in.\nEos enim vel placeat minus voluptatem consequuntur totam corporis et.", 2, "Try to generate the SMTP application, maybe it wil" },
                    { 58L, new DateTime(2022, 5, 2, 22, 38, 8, 877, DateTimeKind.Utc).AddTicks(9285), 40L, "aut", 4, "Use the solid state SMS alarm, then you can bypass" },
                    { 59L, new DateTime(2022, 1, 7, 12, 40, 30, 229, DateTimeKind.Utc).AddTicks(1714), 8L, "Veniam rerum repudiandae sint eos delectus qui veniam id consequatur.", 2, "We need to synthesize the open-source CSS driver!" },
                    { 60L, new DateTime(2021, 9, 18, 3, 27, 46, 472, DateTimeKind.Utc).AddTicks(2696), 22L, "Quia fugiat voluptatem nihil vitae molestias.", 4, "I'll connect the bluetooth RSS feed, that should f" },
                    { 61L, new DateTime(2023, 7, 3, 20, 30, 56, 553, DateTimeKind.Utc).AddTicks(1920), 2L, "Accusamus beatae omnis totam maxime autem in et et.\nEt ducimus ea quia a excepturi a aut.\nExplicabo illo blanditiis illo eum qui itaque natus modi.", 4, "You can't generate the protocol without indexing t" },
                    { 62L, new DateTime(2021, 5, 11, 10, 23, 6, 999, DateTimeKind.Utc).AddTicks(247), 13L, "Voluptatem veniam ut autem enim. Architecto nihil ut rerum aut nihil eos aut. Esse voluptatem reprehenderit perferendis aut ut dolor voluptas.", 4, "If we quantify the program, we can get to the FTP " },
                    { 63L, new DateTime(2022, 12, 15, 15, 43, 30, 471, DateTimeKind.Utc).AddTicks(476), 26L, "Est consectetur voluptatem.\nPlaceat et eos.\nSunt quo et qui eius qui dolor numquam numquam nulla.\nSed nulla sint delectus alias.", 3, "If we bypass the circuit, we can get to the RSS ci" },
                    { 64L, new DateTime(2022, 2, 17, 9, 51, 35, 126, DateTimeKind.Utc).AddTicks(8155), 10L, "ut", 4, "parsing the matrix won't do anything, we need to c" },
                    { 65L, new DateTime(2017, 5, 15, 19, 56, 49, 7, DateTimeKind.Utc).AddTicks(1175), 24L, "Suscipit iusto quas est quaerat molestiae nostrum tempora aliquam tempora.\nRem dolorem ut voluptas voluptate.\nQuo magnam eligendi.\nIpsum tenetur praesentium earum.", 2, "Try to connect the XSS feed, maybe it will connect" },
                    { 66L, new DateTime(2021, 1, 30, 2, 3, 5, 914, DateTimeKind.Utc).AddTicks(5160), 33L, "Quae aliquid quod error nesciunt.", 3, "Use the online IB panel, then you can synthesize t" },
                    { 67L, new DateTime(2023, 7, 14, 21, 4, 31, 229, DateTimeKind.Utc).AddTicks(8487), 39L, "Autem est neque deleniti quae.\nCum vitae ut id voluptate est aut enim.\nAlias tenetur commodi cumque explicabo est.\nCommodi blanditiis tenetur sapiente dolores atque tempore.\nAut modi officiis neque consequatur.", 1, "You can't transmit the application without quantif" },
                    { 68L, new DateTime(2022, 6, 14, 19, 0, 5, 303, DateTimeKind.Utc).AddTicks(1088), 19L, "Est dolores id tempore vel.", 4, "If we override the circuit, we can get to the HDD " },
                    { 69L, new DateTime(2023, 3, 4, 22, 17, 11, 740, DateTimeKind.Utc).AddTicks(4168), 7L, "Aut quibusdam amet at facilis rerum.\nUt veritatis commodi aspernatur doloremque quia quidem.", 1, "Use the cross-platform AGP firewall, then you can " },
                    { 70L, new DateTime(2023, 5, 27, 9, 38, 11, 607, DateTimeKind.Utc).AddTicks(9514), 37L, "Natus aut officia qui consequatur.", 4, "Try to navigate the THX system, maybe it will navi" }
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
                    { 1L, 151.37m, new DateTime(2023, 5, 2, 18, 5, 15, 528, DateTimeKind.Utc).AddTicks(1765), false, "2umhqjy0f1gdzhf2", new DateTime(2023, 1, 29, 9, 4, 11, 956, DateTimeKind.Utc).AddTicks(9512), new DateTime(2019, 6, 30, 12, 21, 31, 881, DateTimeKind.Utc).AddTicks(8661), 2, new DateTime(2023, 2, 7, 7, 49, 55, 454, DateTimeKind.Utc).AddTicks(8303), 27L },
                    { 2L, 136.02m, new DateTime(2024, 1, 27, 12, 7, 0, 690, DateTimeKind.Utc).AddTicks(942), true, "6iotvwd2kcauexpx", new DateTime(2023, 7, 9, 2, 45, 5, 565, DateTimeKind.Utc).AddTicks(6890), new DateTime(2022, 12, 15, 23, 58, 13, 888, DateTimeKind.Utc).AddTicks(9104), 1, new DateTime(2023, 1, 2, 2, 49, 18, 62, DateTimeKind.Utc).AddTicks(2697), 20L },
                    { 3L, 151.37m, new DateTime(2023, 5, 18, 4, 43, 57, 884, DateTimeKind.Utc).AddTicks(1954), false, "uo2s583680b8v54j", new DateTime(2023, 3, 5, 23, 51, 25, 118, DateTimeKind.Utc).AddTicks(1189), new DateTime(2022, 5, 6, 11, 28, 52, 692, DateTimeKind.Utc).AddTicks(4178), 2, new DateTime(2023, 2, 8, 8, 57, 4, 127, DateTimeKind.Utc).AddTicks(9080), 27L },
                    { 4L, 136.02m, new DateTime(2023, 9, 29, 18, 52, 58, 20, DateTimeKind.Utc).AddTicks(5329), true, "nfd23s23e9y7ukxb", new DateTime(2023, 2, 15, 6, 49, 19, 557, DateTimeKind.Utc).AddTicks(8473), new DateTime(2022, 10, 14, 23, 54, 13, 227, DateTimeKind.Utc).AddTicks(7337), 1, new DateTime(2023, 3, 16, 18, 50, 16, 670, DateTimeKind.Utc).AddTicks(914), 10L },
                    { 5L, 136.02m, new DateTime(2023, 4, 11, 19, 35, 7, 168, DateTimeKind.Utc).AddTicks(3781), true, "28569h790c5pv13g", new DateTime(2023, 2, 4, 23, 0, 29, 614, DateTimeKind.Utc).AddTicks(8031), new DateTime(2022, 4, 11, 18, 50, 44, 548, DateTimeKind.Utc).AddTicks(676), 1, new DateTime(2023, 7, 13, 1, 25, 34, 172, DateTimeKind.Utc).AddTicks(8505), 38L }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "Cost", "EndDate", "IsActive", "PaymentSubscriptionId", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate", "UserId" },
                values: new object[,]
                {
                    { 6L, 91.86m, new DateTime(2021, 4, 17, 0, 14, 27, 660, DateTimeKind.Utc).AddTicks(7759), true, "fhe3z935d1zvmvux", new DateTime(2020, 11, 12, 7, 26, 16, 414, DateTimeKind.Utc).AddTicks(3231), new DateTime(2018, 3, 14, 23, 21, 52, 427, DateTimeKind.Utc).AddTicks(4683), 3, new DateTime(2019, 5, 23, 11, 20, 51, 193, DateTimeKind.Utc).AddTicks(7056), 3L },
                    { 7L, 136.02m, new DateTime(2023, 6, 17, 11, 26, 56, 32, DateTimeKind.Utc).AddTicks(6663), true, "04gfoh55j2qr239q", new DateTime(2023, 5, 24, 21, 19, 37, 901, DateTimeKind.Utc).AddTicks(8333), new DateTime(2022, 4, 8, 17, 27, 33, 219, DateTimeKind.Utc).AddTicks(456), 1, new DateTime(2022, 7, 29, 19, 23, 1, 432, DateTimeKind.Utc).AddTicks(7397), 10L },
                    { 8L, 91.86m, new DateTime(2022, 7, 1, 5, 37, 51, 359, DateTimeKind.Utc).AddTicks(5014), false, "cvjhq7n8273vtohw", new DateTime(2022, 5, 9, 23, 38, 56, 17, DateTimeKind.Utc).AddTicks(1974), new DateTime(2020, 9, 27, 2, 23, 33, 249, DateTimeKind.Utc).AddTicks(7992), 3, new DateTime(2020, 12, 25, 13, 51, 9, 691, DateTimeKind.Utc).AddTicks(9693), 36L },
                    { 9L, 151.37m, new DateTime(2024, 8, 1, 12, 37, 13, 328, DateTimeKind.Utc).AddTicks(4235), false, "ff9fvm4sae2sxofc", new DateTime(2023, 8, 2, 11, 37, 30, 690, DateTimeKind.Utc).AddTicks(7229), new DateTime(2023, 3, 11, 17, 1, 26, 171, DateTimeKind.Utc).AddTicks(2178), 2, new DateTime(2023, 5, 16, 23, 23, 9, 176, DateTimeKind.Utc).AddTicks(3868), 17L },
                    { 10L, 136.02m, new DateTime(2022, 7, 30, 16, 59, 52, 566, DateTimeKind.Utc).AddTicks(1946), true, "igx8w9w90k1ay8cf", new DateTime(2021, 12, 12, 21, 25, 30, 995, DateTimeKind.Utc).AddTicks(9451), new DateTime(2020, 10, 10, 16, 54, 31, 558, DateTimeKind.Utc).AddTicks(3767), 1, new DateTime(2022, 10, 6, 5, 46, 6, 872, DateTimeKind.Utc).AddTicks(2405), 3L },
                    { 11L, 91.86m, new DateTime(2023, 10, 28, 22, 2, 41, 701, DateTimeKind.Utc).AddTicks(6882), true, "dy4mdzy1ipwfpvv0", new DateTime(2023, 3, 10, 16, 6, 46, 380, DateTimeKind.Utc).AddTicks(3752), new DateTime(2022, 12, 6, 8, 5, 53, 189, DateTimeKind.Utc).AddTicks(2996), 3, new DateTime(2023, 1, 12, 17, 47, 32, 938, DateTimeKind.Utc).AddTicks(551), 20L },
                    { 12L, 136.02m, new DateTime(2023, 1, 7, 12, 46, 17, 492, DateTimeKind.Utc).AddTicks(8443), true, "69sotjwthpvx4aw1", new DateTime(2022, 9, 6, 18, 4, 13, 583, DateTimeKind.Utc).AddTicks(9520), new DateTime(2022, 5, 17, 1, 28, 27, 294, DateTimeKind.Utc).AddTicks(9764), 1, new DateTime(2023, 7, 16, 17, 49, 48, 812, DateTimeKind.Utc).AddTicks(3836), 25L },
                    { 13L, 136.02m, new DateTime(2023, 9, 1, 2, 27, 15, 75, DateTimeKind.Utc).AddTicks(8424), true, "gjxuxll8kyg46a7z", new DateTime(2023, 8, 23, 4, 53, 16, 762, DateTimeKind.Utc).AddTicks(4204), new DateTime(2023, 5, 20, 5, 9, 5, 403, DateTimeKind.Utc).AddTicks(6708), 1, new DateTime(2023, 8, 17, 2, 18, 5, 520, DateTimeKind.Utc).AddTicks(5316), 32L },
                    { 14L, 151.37m, new DateTime(2023, 1, 9, 23, 13, 31, 329, DateTimeKind.Utc).AddTicks(937), true, "wprmc5u9im89l2ww", new DateTime(2022, 3, 14, 8, 21, 24, 911, DateTimeKind.Utc).AddTicks(5735), new DateTime(2021, 11, 15, 1, 12, 34, 335, DateTimeKind.Utc).AddTicks(4534), 2, new DateTime(2023, 3, 28, 13, 6, 1, 719, DateTimeKind.Utc).AddTicks(4553), 5L },
                    { 15L, 136.02m, new DateTime(2023, 3, 15, 19, 16, 22, 327, DateTimeKind.Utc).AddTicks(2888), false, "stg9zq5iopx7uyvf", new DateTime(2023, 2, 23, 4, 20, 15, 157, DateTimeKind.Utc).AddTicks(2220), new DateTime(2022, 7, 6, 20, 42, 42, 212, DateTimeKind.Utc).AddTicks(2761), 1, new DateTime(2023, 7, 24, 21, 5, 53, 951, DateTimeKind.Utc).AddTicks(7488), 5L },
                    { 16L, 91.86m, new DateTime(2023, 9, 5, 4, 54, 26, 790, DateTimeKind.Utc).AddTicks(7580), true, "61vekpd4uftjpk9r", new DateTime(2023, 7, 16, 21, 1, 57, 412, DateTimeKind.Utc).AddTicks(4272), new DateTime(2022, 8, 18, 17, 32, 47, 997, DateTimeKind.Utc).AddTicks(4438), 3, null, 19L },
                    { 17L, 91.86m, new DateTime(2022, 10, 12, 20, 52, 13, 954, DateTimeKind.Utc).AddTicks(3256), false, "qy2m6a9vgq3xvryz", new DateTime(2022, 8, 22, 19, 28, 5, 187, DateTimeKind.Utc).AddTicks(9844), new DateTime(2021, 12, 17, 3, 19, 23, 189, DateTimeKind.Utc).AddTicks(3129), 3, new DateTime(2022, 7, 15, 7, 33, 40, 333, DateTimeKind.Utc).AddTicks(1891), 14L },
                    { 18L, 91.86m, new DateTime(2024, 1, 24, 5, 59, 25, 858, DateTimeKind.Utc).AddTicks(523), false, "xt3cbgkhzqommryk", new DateTime(2023, 8, 4, 15, 22, 18, 395, DateTimeKind.Utc).AddTicks(4232), new DateTime(2022, 4, 25, 2, 33, 9, 513, DateTimeKind.Utc).AddTicks(5490), 3, new DateTime(2022, 10, 9, 13, 49, 33, 220, DateTimeKind.Utc).AddTicks(7950), 7L },
                    { 19L, 151.37m, new DateTime(2023, 8, 22, 11, 43, 40, 668, DateTimeKind.Utc).AddTicks(5861), false, "rmkbbn0e8joc7xjz", new DateTime(2023, 7, 21, 13, 8, 43, 83, DateTimeKind.Utc).AddTicks(9624), new DateTime(2023, 7, 16, 7, 14, 51, 765, DateTimeKind.Utc).AddTicks(5742), 2, new DateTime(2023, 7, 29, 6, 38, 12, 776, DateTimeKind.Utc).AddTicks(8021), 7L },
                    { 20L, 136.02m, new DateTime(2019, 10, 6, 10, 33, 37, 954, DateTimeKind.Utc).AddTicks(9358), true, "us879r2lwdkpw85c", new DateTime(2019, 9, 8, 0, 31, 12, 465, DateTimeKind.Utc).AddTicks(6793), new DateTime(2019, 5, 28, 3, 29, 34, 310, DateTimeKind.Utc).AddTicks(9458), 1, new DateTime(2021, 12, 18, 1, 9, 24, 671, DateTimeKind.Utc).AddTicks(5932), 29L },
                    { 21L, 136.02m, new DateTime(2023, 9, 9, 19, 39, 15, 100, DateTimeKind.Utc).AddTicks(6882), false, "e3suermf9zhiet5h", new DateTime(2023, 5, 3, 21, 52, 11, 102, DateTimeKind.Utc).AddTicks(9336), new DateTime(2021, 12, 29, 3, 34, 34, 814, DateTimeKind.Utc).AddTicks(2443), 1, new DateTime(2023, 5, 22, 10, 0, 35, 943, DateTimeKind.Utc).AddTicks(9124), 20L },
                    { 22L, 136.02m, new DateTime(2024, 5, 13, 4, 41, 25, 667, DateTimeKind.Utc).AddTicks(4070), false, "gkftyah9gzs5y764", new DateTime(2023, 8, 3, 9, 24, 25, 0, DateTimeKind.Utc).AddTicks(8663), new DateTime(2023, 1, 24, 11, 1, 58, 148, DateTimeKind.Utc).AddTicks(9249), 1, new DateTime(2023, 6, 9, 16, 0, 59, 248, DateTimeKind.Utc).AddTicks(1571), 31L },
                    { 23L, 136.02m, new DateTime(2022, 4, 19, 22, 0, 51, 398, DateTimeKind.Utc).AddTicks(5244), true, "4wkz5jwj0veuctgy", new DateTime(2022, 4, 14, 11, 37, 29, 464, DateTimeKind.Utc).AddTicks(7848), new DateTime(2021, 3, 28, 23, 36, 59, 40, DateTimeKind.Utc).AddTicks(5081), 1, new DateTime(2023, 8, 19, 10, 33, 44, 197, DateTimeKind.Utc).AddTicks(3623), 21L },
                    { 24L, 136.02m, new DateTime(2021, 12, 14, 21, 11, 36, 664, DateTimeKind.Utc).AddTicks(7065), false, "xb17e65tmjo2pi3w", new DateTime(2021, 2, 23, 5, 4, 54, 11, DateTimeKind.Utc).AddTicks(7975), new DateTime(2020, 12, 9, 21, 50, 29, 203, DateTimeKind.Utc).AddTicks(5568), 1, new DateTime(2021, 11, 1, 9, 11, 30, 570, DateTimeKind.Utc).AddTicks(3492), 4L },
                    { 25L, 151.37m, new DateTime(2022, 12, 19, 16, 57, 42, 164, DateTimeKind.Utc).AddTicks(2423), false, "ohejkiv4da2uho5t", new DateTime(2022, 11, 4, 18, 32, 14, 74, DateTimeKind.Utc).AddTicks(1360), new DateTime(2019, 3, 22, 7, 45, 56, 893, DateTimeKind.Utc).AddTicks(5958), 2, new DateTime(2021, 1, 14, 0, 27, 49, 576, DateTimeKind.Utc).AddTicks(4894), 30L },
                    { 26L, 151.37m, new DateTime(2022, 11, 1, 19, 26, 42, 554, DateTimeKind.Utc).AddTicks(2603), true, "46crvfhli3jxsl84", new DateTime(2022, 5, 23, 2, 0, 42, 914, DateTimeKind.Utc).AddTicks(3167), new DateTime(2021, 6, 3, 7, 54, 15, 488, DateTimeKind.Utc).AddTicks(65), 2, new DateTime(2021, 12, 9, 23, 8, 58, 58, DateTimeKind.Utc).AddTicks(1742), 27L },
                    { 27L, 151.37m, new DateTime(2022, 10, 11, 18, 30, 40, 310, DateTimeKind.Utc).AddTicks(6495), true, "3ab74yu98efe549y", new DateTime(2022, 8, 15, 4, 42, 55, 555, DateTimeKind.Utc).AddTicks(6292), new DateTime(2021, 12, 7, 17, 49, 19, 218, DateTimeKind.Utc).AddTicks(3913), 2, null, 33L },
                    { 28L, 136.02m, new DateTime(2023, 8, 8, 8, 58, 44, 298, DateTimeKind.Utc).AddTicks(8310), false, "c26kqtjwrynk39gj", new DateTime(2023, 6, 8, 3, 6, 12, 958, DateTimeKind.Utc).AddTicks(6688), new DateTime(2023, 4, 24, 18, 3, 59, 579, DateTimeKind.Utc).AddTicks(8981), 1, new DateTime(2023, 8, 3, 4, 28, 47, 277, DateTimeKind.Utc).AddTicks(3775), 11L },
                    { 29L, 151.37m, new DateTime(2022, 10, 30, 8, 29, 3, 724, DateTimeKind.Utc).AddTicks(1271), false, "aqmyw08v96v1s9if", new DateTime(2022, 5, 12, 8, 28, 27, 52, DateTimeKind.Utc).AddTicks(9118), new DateTime(2022, 1, 21, 19, 13, 10, 599, DateTimeKind.Utc).AddTicks(8583), 2, new DateTime(2023, 3, 8, 21, 48, 9, 401, DateTimeKind.Utc).AddTicks(5559), 35L },
                    { 30L, 91.86m, new DateTime(2023, 10, 11, 4, 50, 41, 460, DateTimeKind.Utc).AddTicks(2629), false, "0s5wjozi3ma06kzq", new DateTime(2023, 5, 20, 5, 32, 36, 661, DateTimeKind.Utc).AddTicks(3469), new DateTime(2019, 10, 19, 12, 6, 26, 127, DateTimeKind.Utc).AddTicks(4856), 3, new DateTime(2021, 5, 31, 21, 38, 59, 547, DateTimeKind.Utc).AddTicks(1780), 30L },
                    { 31L, 151.37m, new DateTime(2024, 6, 19, 12, 44, 6, 919, DateTimeKind.Utc).AddTicks(1289), true, "q9hn6s2kv3y4vcck", new DateTime(2023, 7, 1, 17, 55, 50, 545, DateTimeKind.Utc).AddTicks(6302), new DateTime(2023, 6, 21, 14, 59, 58, 818, DateTimeKind.Utc).AddTicks(4998), 2, new DateTime(2023, 7, 23, 9, 35, 0, 614, DateTimeKind.Utc).AddTicks(6413), 8L },
                    { 32L, 91.86m, new DateTime(2020, 9, 25, 19, 43, 51, 67, DateTimeKind.Utc).AddTicks(1014), true, "iwgpew5l055a6ccb", new DateTime(2020, 2, 15, 7, 26, 47, 121, DateTimeKind.Utc).AddTicks(8401), new DateTime(2019, 10, 12, 3, 12, 13, 475, DateTimeKind.Utc).AddTicks(9330), 3, new DateTime(2023, 3, 4, 7, 9, 39, 82, DateTimeKind.Utc).AddTicks(3506), 23L },
                    { 33L, 151.37m, new DateTime(2021, 11, 29, 11, 55, 56, 375, DateTimeKind.Utc).AddTicks(3684), false, "fqq1hl08z749bd6z", new DateTime(2021, 9, 19, 6, 28, 4, 600, DateTimeKind.Utc).AddTicks(6277), new DateTime(2016, 12, 6, 9, 58, 6, 810, DateTimeKind.Utc).AddTicks(4293), 2, new DateTime(2017, 3, 27, 3, 12, 46, 586, DateTimeKind.Utc).AddTicks(6803), 38L },
                    { 34L, 91.86m, new DateTime(2023, 9, 28, 2, 43, 1, 751, DateTimeKind.Utc).AddTicks(778), true, "0ml8d5on129n534f", new DateTime(2023, 7, 12, 5, 59, 24, 315, DateTimeKind.Utc).AddTicks(5386), new DateTime(2018, 6, 5, 7, 49, 45, 338, DateTimeKind.Utc).AddTicks(1330), 3, new DateTime(2018, 10, 23, 21, 59, 22, 758, DateTimeKind.Utc).AddTicks(5010), 6L },
                    { 35L, 151.37m, new DateTime(2022, 3, 24, 0, 46, 31, 392, DateTimeKind.Utc).AddTicks(4278), false, "k558r56ddw1u0svt", new DateTime(2022, 2, 16, 16, 35, 2, 510, DateTimeKind.Utc).AddTicks(5206), new DateTime(2021, 8, 24, 17, 17, 37, 941, DateTimeKind.Utc).AddTicks(9962), 2, new DateTime(2022, 9, 3, 13, 39, 54, 639, DateTimeKind.Utc).AddTicks(5340), 21L },
                    { 36L, 91.86m, new DateTime(2021, 6, 26, 17, 20, 30, 445, DateTimeKind.Utc).AddTicks(4128), true, "9olaqemxndo70gvv", new DateTime(2021, 6, 2, 1, 0, 47, 395, DateTimeKind.Utc).AddTicks(8109), new DateTime(2020, 8, 24, 1, 45, 31, 460, DateTimeKind.Utc).AddTicks(3418), 3, new DateTime(2021, 6, 19, 23, 3, 38, 399, DateTimeKind.Utc).AddTicks(7897), 36L },
                    { 37L, 136.02m, new DateTime(2023, 6, 11, 14, 29, 40, 738, DateTimeKind.Utc).AddTicks(5766), true, "1ggquq41cbz3kwmy", new DateTime(2023, 5, 3, 3, 27, 2, 334, DateTimeKind.Utc).AddTicks(8977), new DateTime(2022, 10, 20, 20, 47, 14, 276, DateTimeKind.Utc).AddTicks(6380), 1, new DateTime(2023, 5, 12, 6, 22, 2, 259, DateTimeKind.Utc).AddTicks(305), 11L },
                    { 38L, 151.37m, new DateTime(2024, 1, 27, 5, 34, 20, 851, DateTimeKind.Utc).AddTicks(2273), false, "mcc78krz988ayw3w", new DateTime(2023, 8, 6, 17, 21, 38, 178, DateTimeKind.Utc).AddTicks(5784), new DateTime(2023, 6, 30, 12, 49, 51, 609, DateTimeKind.Utc).AddTicks(5667), 2, new DateTime(2023, 8, 10, 21, 4, 56, 238, DateTimeKind.Utc).AddTicks(4159), 11L },
                    { 39L, 91.86m, new DateTime(2023, 10, 22, 6, 39, 30, 822, DateTimeKind.Utc).AddTicks(9455), true, "8czy2s8dnd3hewts", new DateTime(2023, 2, 23, 16, 21, 4, 247, DateTimeKind.Utc).AddTicks(5383), new DateTime(2022, 11, 27, 21, 16, 49, 270, DateTimeKind.Utc).AddTicks(7136), 3, null, 23L },
                    { 40L, 91.86m, new DateTime(2023, 5, 4, 4, 44, 36, 191, DateTimeKind.Utc).AddTicks(4849), true, "0adhs4lu1czvkswh", new DateTime(2022, 7, 14, 18, 56, 34, 759, DateTimeKind.Utc).AddTicks(4612), new DateTime(2021, 1, 22, 12, 18, 58, 218, DateTimeKind.Utc).AddTicks(2306), 3, new DateTime(2022, 8, 11, 5, 11, 22, 96, DateTimeKind.Utc).AddTicks(5616), 1L },
                    { 41L, 136.02m, new DateTime(2022, 3, 6, 0, 58, 40, 275, DateTimeKind.Utc).AddTicks(8029), false, "t24hxzbvbmyserki", new DateTime(2021, 4, 3, 8, 18, 22, 54, DateTimeKind.Utc).AddTicks(4249), new DateTime(2021, 2, 24, 12, 58, 18, 433, DateTimeKind.Utc).AddTicks(2105), 1, new DateTime(2023, 6, 25, 6, 6, 32, 270, DateTimeKind.Utc).AddTicks(1355), 32L },
                    { 42L, 136.02m, new DateTime(2024, 6, 9, 0, 24, 13, 851, DateTimeKind.Utc).AddTicks(6172), true, "2cbsqfkes0nq04x2", new DateTime(2023, 8, 2, 11, 50, 52, 453, DateTimeKind.Utc).AddTicks(372), new DateTime(2022, 6, 5, 1, 56, 34, 688, DateTimeKind.Utc).AddTicks(8869), 1, new DateTime(2022, 7, 30, 21, 28, 6, 564, DateTimeKind.Utc).AddTicks(6382), 2L },
                    { 43L, 151.37m, new DateTime(2023, 9, 4, 8, 28, 45, 889, DateTimeKind.Utc).AddTicks(8983), false, "a3sk5gfvudeknj5w", new DateTime(2023, 7, 30, 11, 3, 58, 50, DateTimeKind.Utc).AddTicks(1353), new DateTime(2023, 7, 13, 23, 54, 23, 557, DateTimeKind.Utc).AddTicks(547), 2, new DateTime(2023, 8, 16, 19, 3, 49, 115, DateTimeKind.Utc).AddTicks(9448), 3L },
                    { 44L, 91.86m, new DateTime(2024, 3, 5, 2, 35, 24, 227, DateTimeKind.Utc).AddTicks(3399), true, "bc0td9wya1hmn09c", new DateTime(2023, 6, 21, 20, 38, 57, 61, DateTimeKind.Utc).AddTicks(9430), new DateTime(2023, 3, 3, 16, 11, 40, 232, DateTimeKind.Utc).AddTicks(1794), 3, new DateTime(2023, 5, 3, 7, 32, 6, 657, DateTimeKind.Utc).AddTicks(7942), 23L },
                    { 45L, 151.37m, new DateTime(2022, 12, 29, 18, 12, 45, 791, DateTimeKind.Utc).AddTicks(9049), true, "xowb5o5gk48tfmik", new DateTime(2022, 12, 15, 7, 20, 4, 768, DateTimeKind.Utc).AddTicks(4502), new DateTime(2021, 11, 10, 20, 32, 54, 181, DateTimeKind.Utc).AddTicks(3192), 2, new DateTime(2022, 10, 13, 19, 48, 58, 754, DateTimeKind.Utc).AddTicks(7171), 19L },
                    { 46L, 136.02m, new DateTime(2022, 6, 17, 1, 4, 58, 844, DateTimeKind.Utc).AddTicks(4051), false, "anubxvyyxivpdltm", new DateTime(2021, 9, 12, 18, 58, 44, 861, DateTimeKind.Utc).AddTicks(9534), new DateTime(2019, 8, 19, 3, 22, 5, 857, DateTimeKind.Utc).AddTicks(7564), 1, new DateTime(2021, 6, 1, 12, 9, 3, 390, DateTimeKind.Utc).AddTicks(5332), 36L },
                    { 47L, 136.02m, new DateTime(2024, 5, 9, 23, 37, 41, 918, DateTimeKind.Utc).AddTicks(3054), false, "ab681sgffu1ituio", new DateTime(2023, 8, 17, 11, 47, 45, 950, DateTimeKind.Utc).AddTicks(9779), new DateTime(2023, 6, 11, 23, 49, 50, 853, DateTimeKind.Utc).AddTicks(8469), 1, new DateTime(2023, 8, 8, 22, 51, 56, 34, DateTimeKind.Utc).AddTicks(1750), 7L }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "Cost", "EndDate", "IsActive", "PaymentSubscriptionId", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate", "UserId" },
                values: new object[,]
                {
                    { 48L, 151.37m, new DateTime(2023, 2, 20, 18, 15, 59, 530, DateTimeKind.Utc).AddTicks(9949), true, "noq0gqauqw1mppw5", new DateTime(2022, 8, 1, 17, 53, 33, 770, DateTimeKind.Utc).AddTicks(4804), new DateTime(2021, 5, 28, 13, 30, 34, 898, DateTimeKind.Utc).AddTicks(3172), 2, new DateTime(2022, 2, 4, 15, 58, 57, 206, DateTimeKind.Utc).AddTicks(433), 4L },
                    { 49L, 136.02m, new DateTime(2024, 5, 15, 6, 36, 47, 752, DateTimeKind.Utc).AddTicks(5139), true, "icchkz7h4bld2gyo", new DateTime(2023, 7, 24, 9, 37, 40, 111, DateTimeKind.Utc).AddTicks(3579), new DateTime(2022, 7, 30, 3, 7, 4, 930, DateTimeKind.Utc).AddTicks(9210), 1, new DateTime(2023, 7, 15, 18, 22, 23, 160, DateTimeKind.Utc).AddTicks(9278), 23L },
                    { 50L, 151.37m, new DateTime(2023, 8, 23, 0, 46, 17, 763, DateTimeKind.Utc).AddTicks(1397), false, "dqu9ioacwoh3dt9r", new DateTime(2023, 7, 9, 22, 48, 55, 801, DateTimeKind.Utc).AddTicks(8957), new DateTime(2023, 6, 13, 4, 21, 42, 266, DateTimeKind.Utc).AddTicks(2515), 2, null, 28L },
                    { 51L, 136.02m, new DateTime(2022, 5, 26, 15, 19, 46, 677, DateTimeKind.Utc).AddTicks(4811), false, "hlzcjv8mdw4u5yyf", new DateTime(2021, 6, 9, 8, 53, 11, 368, DateTimeKind.Utc).AddTicks(6419), new DateTime(2019, 12, 27, 10, 27, 45, 867, DateTimeKind.Utc).AddTicks(3755), 1, new DateTime(2023, 2, 9, 8, 31, 53, 846, DateTimeKind.Utc).AddTicks(5311), 1L },
                    { 52L, 91.86m, new DateTime(2023, 12, 26, 17, 36, 30, 275, DateTimeKind.Utc).AddTicks(9156), false, "y089embtn7rxpys0", new DateTime(2023, 4, 16, 3, 23, 34, 494, DateTimeKind.Utc).AddTicks(8921), new DateTime(2022, 12, 17, 0, 20, 1, 393, DateTimeKind.Utc).AddTicks(3428), 3, new DateTime(2023, 3, 25, 23, 24, 41, 165, DateTimeKind.Utc).AddTicks(4197), 18L },
                    { 53L, 136.02m, new DateTime(2023, 8, 1, 8, 13, 53, 906, DateTimeKind.Utc).AddTicks(2067), true, "l2cv2onna8ejmz8r", new DateTime(2023, 5, 27, 0, 55, 0, 403, DateTimeKind.Utc).AddTicks(6455), new DateTime(2020, 1, 24, 16, 23, 48, 99, DateTimeKind.Utc).AddTicks(1609), 1, new DateTime(2020, 3, 11, 16, 24, 29, 932, DateTimeKind.Utc).AddTicks(3116), 23L },
                    { 54L, 136.02m, new DateTime(2023, 10, 4, 9, 1, 57, 647, DateTimeKind.Utc).AddTicks(8911), true, "gfy34t1jeinb9gqz", new DateTime(2023, 3, 21, 7, 58, 44, 841, DateTimeKind.Utc).AddTicks(1433), new DateTime(2022, 11, 3, 11, 0, 0, 187, DateTimeKind.Utc).AddTicks(4180), 1, new DateTime(2023, 1, 16, 10, 21, 19, 175, DateTimeKind.Utc).AddTicks(2020), 22L },
                    { 55L, 91.86m, new DateTime(2021, 7, 15, 1, 23, 55, 82, DateTimeKind.Utc).AddTicks(2534), true, "nzwe7ojkc9empkjg", new DateTime(2021, 3, 18, 0, 51, 16, 165, DateTimeKind.Utc).AddTicks(4185), new DateTime(2020, 11, 22, 17, 34, 33, 380, DateTimeKind.Utc).AddTicks(9858), 3, new DateTime(2023, 5, 20, 15, 1, 14, 469, DateTimeKind.Utc).AddTicks(7080), 8L },
                    { 56L, 136.02m, new DateTime(2023, 9, 16, 21, 20, 9, 117, DateTimeKind.Utc).AddTicks(3019), false, "j7d2e9j71hg4xncp", new DateTime(2023, 8, 23, 10, 36, 36, 876, DateTimeKind.Utc).AddTicks(247), new DateTime(2023, 8, 14, 6, 40, 26, 987, DateTimeKind.Utc).AddTicks(839), 1, new DateTime(2023, 8, 15, 8, 23, 20, 367, DateTimeKind.Utc).AddTicks(3872), 39L },
                    { 57L, 136.02m, new DateTime(2021, 12, 22, 7, 22, 8, 866, DateTimeKind.Utc).AddTicks(9173), false, "l7ao3a4qisuzah62", new DateTime(2021, 11, 6, 11, 51, 57, 20, DateTimeKind.Utc).AddTicks(1977), new DateTime(2021, 5, 4, 21, 52, 28, 921, DateTimeKind.Utc).AddTicks(5792), 1, new DateTime(2022, 4, 10, 14, 38, 53, 942, DateTimeKind.Utc).AddTicks(3329), 30L },
                    { 58L, 91.86m, new DateTime(2022, 7, 1, 19, 12, 32, 198, DateTimeKind.Utc).AddTicks(9781), true, "if58xh1fxeg6zu3r", new DateTime(2021, 9, 14, 9, 44, 4, 377, DateTimeKind.Utc).AddTicks(3263), new DateTime(2021, 6, 13, 20, 44, 21, 158, DateTimeKind.Utc).AddTicks(6784), 3, new DateTime(2022, 4, 4, 12, 18, 55, 398, DateTimeKind.Utc).AddTicks(1134), 15L },
                    { 59L, 151.37m, new DateTime(2023, 7, 20, 2, 32, 42, 309, DateTimeKind.Utc).AddTicks(305), false, "xw8vj1u6nq6o4wt0", new DateTime(2023, 7, 10, 17, 24, 31, 831, DateTimeKind.Utc).AddTicks(1686), new DateTime(2022, 8, 27, 12, 31, 41, 230, DateTimeKind.Utc).AddTicks(9761), 2, new DateTime(2023, 8, 14, 13, 28, 14, 38, DateTimeKind.Utc).AddTicks(4235), 31L },
                    { 60L, 136.02m, new DateTime(2022, 9, 24, 14, 20, 37, 223, DateTimeKind.Utc).AddTicks(8912), true, "2tufsfq40oa185wv", new DateTime(2022, 1, 17, 0, 8, 46, 35, DateTimeKind.Utc).AddTicks(9996), new DateTime(2021, 7, 17, 14, 40, 5, 231, DateTimeKind.Utc).AddTicks(4698), 1, new DateTime(2022, 6, 9, 4, 41, 23, 446, DateTimeKind.Utc).AddTicks(9280), 23L },
                    { 61L, 136.02m, new DateTime(2023, 12, 4, 23, 58, 51, 10, DateTimeKind.Utc).AddTicks(7672), false, "wmcdbjgysdsp6fe8", new DateTime(2023, 4, 24, 3, 57, 21, 483, DateTimeKind.Utc).AddTicks(9075), new DateTime(2023, 1, 14, 17, 45, 4, 215, DateTimeKind.Utc).AddTicks(948), 1, new DateTime(2023, 7, 4, 2, 14, 24, 322, DateTimeKind.Utc).AddTicks(7206), 40L },
                    { 62L, 151.37m, new DateTime(2023, 10, 27, 11, 15, 52, 283, DateTimeKind.Utc).AddTicks(3797), true, "i6bqfv7n7ei52dtg", new DateTime(2023, 6, 17, 12, 15, 44, 761, DateTimeKind.Utc).AddTicks(4212), new DateTime(2022, 1, 29, 9, 14, 31, 140, DateTimeKind.Utc).AddTicks(3083), 2, new DateTime(2022, 5, 29, 13, 44, 48, 722, DateTimeKind.Utc).AddTicks(776), 10L },
                    { 63L, 136.02m, new DateTime(2024, 5, 23, 19, 56, 32, 945, DateTimeKind.Utc).AddTicks(6286), false, "va8nr6u4vqv58pix", new DateTime(2023, 6, 26, 5, 33, 40, 57, DateTimeKind.Utc).AddTicks(8858), new DateTime(2022, 11, 22, 18, 17, 35, 115, DateTimeKind.Utc).AddTicks(8600), 1, new DateTime(2023, 1, 27, 3, 9, 42, 694, DateTimeKind.Utc).AddTicks(3791), 7L },
                    { 64L, 151.37m, new DateTime(2022, 1, 5, 17, 11, 17, 900, DateTimeKind.Utc).AddTicks(467), false, "7779iv8ah6v5mjw1", new DateTime(2021, 7, 8, 22, 39, 49, 764, DateTimeKind.Utc).AddTicks(4513), new DateTime(2020, 7, 12, 5, 33, 31, 37, DateTimeKind.Utc).AddTicks(9844), 2, new DateTime(2022, 8, 15, 17, 53, 13, 870, DateTimeKind.Utc).AddTicks(293), 23L },
                    { 65L, 151.37m, new DateTime(2023, 8, 27, 1, 59, 55, 693, DateTimeKind.Utc).AddTicks(4629), false, "tbp7qw8m3mfjyklz", new DateTime(2022, 10, 29, 10, 54, 26, 955, DateTimeKind.Utc).AddTicks(8121), new DateTime(2022, 10, 10, 19, 36, 41, 652, DateTimeKind.Utc).AddTicks(2185), 2, new DateTime(2023, 1, 30, 20, 28, 1, 74, DateTimeKind.Utc).AddTicks(1276), 21L },
                    { 66L, 136.02m, new DateTime(2023, 9, 17, 6, 58, 16, 338, DateTimeKind.Utc).AddTicks(7355), true, "8g7ixv4jzog650kl", new DateTime(2023, 8, 11, 5, 51, 17, 463, DateTimeKind.Utc).AddTicks(5296), new DateTime(2016, 7, 30, 0, 3, 38, 866, DateTimeKind.Utc).AddTicks(5748), 1, new DateTime(2019, 3, 8, 2, 50, 55, 498, DateTimeKind.Utc).AddTicks(9833), 38L },
                    { 67L, 91.86m, new DateTime(2022, 10, 18, 13, 54, 3, 495, DateTimeKind.Utc).AddTicks(7016), true, "sbtx06pg02z9opp8", new DateTime(2022, 9, 9, 11, 35, 17, 910, DateTimeKind.Utc).AddTicks(7213), new DateTime(2022, 4, 20, 12, 35, 15, 257, DateTimeKind.Utc).AddTicks(1270), 3, new DateTime(2022, 11, 10, 13, 24, 40, 620, DateTimeKind.Utc).AddTicks(2634), 20L },
                    { 68L, 91.86m, new DateTime(2022, 11, 26, 18, 45, 41, 165, DateTimeKind.Utc).AddTicks(6504), true, "z24labjvd7qm17jt", new DateTime(2022, 11, 9, 17, 0, 43, 643, DateTimeKind.Utc).AddTicks(5392), new DateTime(2022, 10, 14, 20, 44, 8, 949, DateTimeKind.Utc).AddTicks(5302), 3, new DateTime(2023, 1, 17, 9, 36, 38, 426, DateTimeKind.Utc).AddTicks(2330), 39L },
                    { 69L, 136.02m, new DateTime(2024, 5, 22, 21, 48, 13, 362, DateTimeKind.Utc).AddTicks(1407), true, "jti7tswdhcxx146p", new DateTime(2023, 5, 27, 9, 1, 45, 379, DateTimeKind.Utc).AddTicks(6152), new DateTime(2023, 3, 9, 18, 5, 51, 469, DateTimeKind.Utc).AddTicks(7165), 1, new DateTime(2023, 3, 23, 17, 39, 4, 863, DateTimeKind.Utc).AddTicks(7827), 23L },
                    { 70L, 151.37m, new DateTime(2022, 5, 18, 18, 19, 44, 634, DateTimeKind.Utc).AddTicks(9069), false, "dqb49qfp6v2htb1l", new DateTime(2022, 2, 3, 20, 35, 56, 397, DateTimeKind.Utc).AddTicks(5872), new DateTime(2018, 4, 23, 3, 57, 37, 463, DateTimeKind.Utc).AddTicks(3204), 2, new DateTime(2021, 7, 21, 9, 10, 33, 867, DateTimeKind.Utc).AddTicks(4857), 13L },
                    { 71L, 136.02m, new DateTime(2023, 4, 28, 7, 47, 54, 161, DateTimeKind.Utc).AddTicks(5060), true, "tfjxef8gm7u3gr4q", new DateTime(2023, 4, 4, 3, 38, 29, 942, DateTimeKind.Utc).AddTicks(1226), new DateTime(2023, 3, 5, 16, 0, 34, 413, DateTimeKind.Utc).AddTicks(609), 1, new DateTime(2023, 6, 30, 2, 45, 31, 582, DateTimeKind.Utc).AddTicks(3467), 37L },
                    { 72L, 151.37m, new DateTime(2024, 1, 18, 14, 15, 44, 378, DateTimeKind.Utc).AddTicks(4737), false, "2b5myh0ryhbt7haq", new DateTime(2023, 7, 22, 6, 1, 36, 809, DateTimeKind.Utc).AddTicks(3966), new DateTime(2023, 6, 5, 13, 22, 31, 455, DateTimeKind.Utc).AddTicks(3737), 2, new DateTime(2023, 8, 19, 10, 12, 55, 756, DateTimeKind.Utc).AddTicks(5208), 26L },
                    { 73L, 136.02m, new DateTime(2023, 12, 23, 16, 38, 2, 414, DateTimeKind.Utc).AddTicks(1711), true, "8ds2vlr4ibv39lh4", new DateTime(2023, 7, 5, 21, 26, 1, 416, DateTimeKind.Utc).AddTicks(7756), new DateTime(2020, 10, 3, 22, 55, 1, 287, DateTimeKind.Utc).AddTicks(8870), 1, new DateTime(2021, 8, 20, 19, 45, 39, 618, DateTimeKind.Utc).AddTicks(9911), 9L },
                    { 74L, 136.02m, new DateTime(2023, 11, 15, 9, 5, 30, 291, DateTimeKind.Utc).AddTicks(5044), true, "xzjgtbq46mekoxwc", new DateTime(2023, 4, 2, 21, 55, 34, 76, DateTimeKind.Utc).AddTicks(3598), new DateTime(2019, 8, 27, 20, 29, 8, 321, DateTimeKind.Utc).AddTicks(6571), 1, new DateTime(2020, 6, 10, 2, 32, 33, 748, DateTimeKind.Utc).AddTicks(6963), 30L },
                    { 75L, 91.86m, new DateTime(2023, 9, 3, 12, 12, 47, 883, DateTimeKind.Utc).AddTicks(3781), true, "4qdes62xud4v2bb7", new DateTime(2023, 6, 16, 21, 9, 14, 710, DateTimeKind.Utc).AddTicks(6608), new DateTime(2023, 2, 17, 17, 20, 24, 229, DateTimeKind.Utc).AddTicks(1843), 3, new DateTime(2023, 8, 6, 23, 42, 46, 847, DateTimeKind.Utc).AddTicks(5887), 24L },
                    { 76L, 151.37m, new DateTime(2023, 8, 27, 2, 26, 49, 680, DateTimeKind.Utc).AddTicks(7363), true, "6s7a0msqiic2ybbz", new DateTime(2022, 10, 31, 19, 35, 16, 393, DateTimeKind.Utc).AddTicks(3388), new DateTime(2022, 6, 29, 13, 56, 26, 318, DateTimeKind.Utc).AddTicks(2636), 2, new DateTime(2022, 7, 13, 6, 34, 44, 130, DateTimeKind.Utc).AddTicks(3231), 23L },
                    { 77L, 151.37m, new DateTime(2022, 9, 21, 19, 57, 45, 973, DateTimeKind.Utc).AddTicks(2542), true, "u2bu9ut7a380yrw7", new DateTime(2021, 10, 4, 13, 15, 19, 391, DateTimeKind.Utc).AddTicks(389), new DateTime(2019, 6, 6, 12, 24, 26, 164, DateTimeKind.Utc).AddTicks(4661), 2, new DateTime(2020, 7, 10, 0, 59, 57, 719, DateTimeKind.Utc).AddTicks(5445), 24L },
                    { 78L, 136.02m, new DateTime(2023, 9, 16, 12, 3, 8, 153, DateTimeKind.Utc).AddTicks(588), false, "gx2r65g5hsfxbxgo", new DateTime(2023, 8, 18, 0, 54, 42, 620, DateTimeKind.Utc).AddTicks(6249), new DateTime(2023, 7, 20, 14, 40, 15, 347, DateTimeKind.Utc).AddTicks(9168), 1, null, 28L },
                    { 79L, 136.02m, new DateTime(2021, 4, 12, 14, 11, 52, 336, DateTimeKind.Utc).AddTicks(5985), false, "jjpfoqglt2ecr215", new DateTime(2020, 12, 7, 15, 14, 17, 343, DateTimeKind.Utc).AddTicks(7263), new DateTime(2020, 5, 31, 15, 5, 22, 434, DateTimeKind.Utc).AddTicks(1407), 1, new DateTime(2023, 7, 25, 23, 35, 22, 859, DateTimeKind.Utc).AddTicks(4098), 27L },
                    { 80L, 91.86m, new DateTime(2022, 6, 5, 22, 9, 17, 402, DateTimeKind.Utc).AddTicks(9065), false, "xnuthf65wa7mg0gr", new DateTime(2021, 11, 26, 13, 38, 43, 982, DateTimeKind.Utc).AddTicks(5277), new DateTime(2021, 4, 26, 14, 25, 11, 412, DateTimeKind.Utc).AddTicks(2649), 3, new DateTime(2021, 7, 29, 17, 27, 56, 885, DateTimeKind.Utc).AddTicks(2114), 14L },
                    { 81L, 136.02m, new DateTime(2023, 4, 26, 22, 36, 43, 870, DateTimeKind.Utc).AddTicks(1964), false, "3m6zsvfkn1i0vm3e", new DateTime(2022, 6, 17, 18, 4, 59, 175, DateTimeKind.Utc).AddTicks(3232), new DateTime(2021, 5, 4, 14, 53, 47, 616, DateTimeKind.Utc).AddTicks(2205), 1, new DateTime(2022, 4, 13, 21, 35, 52, 834, DateTimeKind.Utc).AddTicks(8149), 36L },
                    { 82L, 151.37m, new DateTime(2024, 2, 17, 17, 2, 11, 187, DateTimeKind.Utc).AddTicks(7671), false, "mrtium4tr7pv86d0", new DateTime(2023, 8, 15, 18, 22, 1, 402, DateTimeKind.Utc).AddTicks(7043), new DateTime(2023, 8, 10, 14, 15, 15, 168, DateTimeKind.Utc).AddTicks(6886), 2, new DateTime(2023, 8, 16, 6, 9, 23, 891, DateTimeKind.Utc).AddTicks(7546), 34L },
                    { 83L, 91.86m, new DateTime(2024, 2, 8, 10, 41, 58, 372, DateTimeKind.Utc).AddTicks(9795), false, "qpd9nfspxjd01xp0", new DateTime(2023, 3, 11, 17, 41, 44, 940, DateTimeKind.Utc).AddTicks(2203), new DateTime(2022, 4, 15, 21, 37, 15, 481, DateTimeKind.Utc).AddTicks(4121), 3, new DateTime(2022, 8, 6, 7, 36, 36, 648, DateTimeKind.Utc).AddTicks(7103), 37L },
                    { 84L, 136.02m, new DateTime(2024, 6, 6, 10, 9, 36, 531, DateTimeKind.Utc).AddTicks(4550), false, "wfn8fa46w4r59v5c", new DateTime(2023, 8, 11, 15, 18, 43, 45, DateTimeKind.Utc).AddTicks(2297), new DateTime(2023, 7, 14, 6, 11, 58, 582, DateTimeKind.Utc).AddTicks(8053), 1, new DateTime(2023, 7, 28, 14, 42, 1, 271, DateTimeKind.Utc).AddTicks(7433), 18L },
                    { 85L, 136.02m, new DateTime(2023, 9, 20, 10, 24, 13, 448, DateTimeKind.Utc).AddTicks(8471), true, "wyht67sijod7rj9m", new DateTime(2023, 7, 23, 18, 22, 49, 543, DateTimeKind.Utc).AddTicks(3946), new DateTime(2022, 4, 15, 16, 19, 23, 498, DateTimeKind.Utc).AddTicks(2893), 1, new DateTime(2023, 1, 21, 9, 12, 42, 836, DateTimeKind.Utc).AddTicks(56), 17L },
                    { 86L, 136.02m, new DateTime(2023, 2, 6, 17, 21, 28, 978, DateTimeKind.Utc).AddTicks(8037), false, "jx8v9gvjgqbhtb0p", new DateTime(2022, 8, 4, 8, 0, 43, 422, DateTimeKind.Utc).AddTicks(2771), new DateTime(2021, 2, 23, 11, 19, 42, 882, DateTimeKind.Utc).AddTicks(8577), 1, new DateTime(2023, 6, 29, 22, 55, 47, 871, DateTimeKind.Utc).AddTicks(6682), 13L },
                    { 87L, 91.86m, new DateTime(2023, 4, 8, 17, 38, 39, 986, DateTimeKind.Utc).AddTicks(4671), true, "rcan81qc7fa8yw83", new DateTime(2023, 1, 13, 8, 8, 50, 274, DateTimeKind.Utc).AddTicks(4930), new DateTime(2023, 1, 5, 22, 46, 46, 628, DateTimeKind.Utc).AddTicks(2664), 3, new DateTime(2023, 7, 2, 21, 13, 23, 563, DateTimeKind.Utc).AddTicks(9722), 33L },
                    { 88L, 91.86m, new DateTime(2022, 11, 8, 21, 54, 56, 783, DateTimeKind.Utc).AddTicks(2151), true, "5emwz6jldc4x58af", new DateTime(2022, 10, 26, 4, 52, 41, 34, DateTimeKind.Utc).AddTicks(6437), new DateTime(2022, 4, 24, 19, 3, 33, 306, DateTimeKind.Utc).AddTicks(7656), 3, new DateTime(2023, 5, 7, 10, 48, 3, 754, DateTimeKind.Utc).AddTicks(8524), 40L },
                    { 89L, 91.86m, new DateTime(2024, 5, 7, 23, 40, 14, 40, DateTimeKind.Utc).AddTicks(7251), false, "1hro6jnzj7hueud0", new DateTime(2023, 7, 22, 18, 0, 46, 585, DateTimeKind.Utc).AddTicks(5490), new DateTime(2023, 5, 27, 16, 59, 46, 481, DateTimeKind.Utc).AddTicks(6455), 3, new DateTime(2023, 6, 24, 0, 14, 39, 35, DateTimeKind.Utc).AddTicks(6885), 37L }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "Cost", "EndDate", "IsActive", "PaymentSubscriptionId", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate", "UserId" },
                values: new object[,]
                {
                    { 90L, 136.02m, new DateTime(2024, 5, 20, 7, 41, 53, 636, DateTimeKind.Utc).AddTicks(9515), true, "jb19he1dn7vheueu", new DateTime(2023, 8, 17, 23, 53, 0, 482, DateTimeKind.Utc).AddTicks(5938), new DateTime(2023, 5, 25, 13, 11, 26, 880, DateTimeKind.Utc).AddTicks(6848), 1, null, 28L },
                    { 91L, 136.02m, new DateTime(2023, 9, 4, 14, 58, 40, 696, DateTimeKind.Utc).AddTicks(4418), true, "l9hcw3mpj65vhei4", new DateTime(2022, 9, 8, 8, 8, 18, 751, DateTimeKind.Utc).AddTicks(4053), new DateTime(2022, 6, 12, 16, 11, 11, 263, DateTimeKind.Utc).AddTicks(66), 1, new DateTime(2023, 7, 5, 11, 40, 16, 549, DateTimeKind.Utc).AddTicks(7500), 7L },
                    { 92L, 136.02m, new DateTime(2024, 1, 6, 17, 6, 0, 149, DateTimeKind.Utc).AddTicks(6136), true, "a0yox0t3avo8xphk", new DateTime(2023, 5, 2, 17, 13, 49, 371, DateTimeKind.Utc).AddTicks(5708), new DateTime(2023, 3, 30, 11, 38, 46, 305, DateTimeKind.Utc).AddTicks(9035), 1, new DateTime(2023, 6, 17, 22, 32, 16, 495, DateTimeKind.Utc).AddTicks(7064), 24L },
                    { 93L, 136.02m, new DateTime(2023, 5, 15, 0, 2, 50, 606, DateTimeKind.Utc).AddTicks(4509), true, "m8rn9t5pne2v4ysj", new DateTime(2022, 8, 25, 4, 20, 59, 933, DateTimeKind.Utc).AddTicks(648), new DateTime(2021, 2, 8, 5, 1, 30, 792, DateTimeKind.Utc).AddTicks(3342), 1, new DateTime(2021, 10, 19, 16, 50, 9, 592, DateTimeKind.Utc).AddTicks(4796), 15L },
                    { 94L, 91.86m, new DateTime(2023, 3, 3, 7, 46, 44, 58, DateTimeKind.Utc).AddTicks(8529), false, "mmluyddqoo1o85th", new DateTime(2022, 7, 16, 17, 8, 1, 465, DateTimeKind.Utc).AddTicks(8204), new DateTime(2021, 4, 11, 11, 53, 55, 128, DateTimeKind.Utc).AddTicks(7476), 3, new DateTime(2022, 9, 8, 8, 51, 14, 720, DateTimeKind.Utc).AddTicks(3256), 30L },
                    { 95L, 136.02m, new DateTime(2023, 5, 5, 0, 56, 18, 611, DateTimeKind.Utc).AddTicks(6552), true, "cevlzqkc2a1n7br9", new DateTime(2022, 6, 11, 15, 28, 36, 829, DateTimeKind.Utc).AddTicks(5445), new DateTime(2021, 6, 8, 7, 32, 2, 507, DateTimeKind.Utc).AddTicks(6), 1, new DateTime(2021, 9, 2, 23, 50, 26, 801, DateTimeKind.Utc).AddTicks(2165), 2L },
                    { 96L, 91.86m, new DateTime(2023, 9, 11, 14, 1, 51, 36, DateTimeKind.Utc).AddTicks(4227), true, "93vrpnu06yhjisrx", new DateTime(2023, 7, 31, 6, 26, 1, 17, DateTimeKind.Utc).AddTicks(9504), new DateTime(2022, 7, 28, 14, 25, 15, 430, DateTimeKind.Utc).AddTicks(3301), 3, new DateTime(2022, 10, 3, 16, 50, 47, 498, DateTimeKind.Utc).AddTicks(3516), 5L },
                    { 97L, 136.02m, new DateTime(2023, 6, 23, 11, 23, 43, 771, DateTimeKind.Utc).AddTicks(3876), true, "7biaezr83ocwvtne", new DateTime(2022, 8, 29, 22, 5, 0, 519, DateTimeKind.Utc).AddTicks(6962), new DateTime(2022, 4, 24, 0, 3, 50, 396, DateTimeKind.Utc).AddTicks(3927), 1, new DateTime(2022, 8, 2, 8, 7, 28, 929, DateTimeKind.Utc).AddTicks(2124), 19L },
                    { 98L, 136.02m, new DateTime(2023, 10, 18, 16, 13, 13, 448, DateTimeKind.Utc).AddTicks(5077), true, "k9c7hc23tgje5jm7", new DateTime(2023, 5, 12, 12, 30, 1, 583, DateTimeKind.Utc).AddTicks(3002), new DateTime(2021, 11, 21, 4, 15, 4, 774, DateTimeKind.Utc).AddTicks(7501), 1, new DateTime(2023, 5, 25, 6, 14, 24, 660, DateTimeKind.Utc).AddTicks(2434), 8L },
                    { 99L, 136.02m, new DateTime(2020, 5, 15, 17, 31, 18, 630, DateTimeKind.Utc).AddTicks(5731), false, "17h3p0lzj9p4mkrq", new DateTime(2020, 2, 11, 14, 17, 23, 293, DateTimeKind.Utc).AddTicks(7186), new DateTime(2017, 9, 19, 16, 43, 33, 486, DateTimeKind.Utc).AddTicks(6823), 1, new DateTime(2019, 3, 31, 20, 54, 11, 317, DateTimeKind.Utc).AddTicks(2817), 24L },
                    { 100L, 151.37m, new DateTime(2024, 5, 20, 17, 14, 19, 941, DateTimeKind.Utc).AddTicks(1005), false, "ea2krxtp615avzdt", new DateTime(2023, 7, 23, 22, 45, 49, 321, DateTimeKind.Utc).AddTicks(581), new DateTime(2022, 12, 6, 9, 42, 2, 291, DateTimeKind.Utc).AddTicks(2783), 2, new DateTime(2023, 4, 14, 23, 1, 18, 636, DateTimeKind.Utc).AddTicks(4709), 35L },
                    { 101L, 136.02m, new DateTime(2023, 12, 29, 22, 33, 55, 213, DateTimeKind.Utc).AddTicks(2435), false, "hp86so1sykofx18m", new DateTime(2023, 7, 31, 10, 33, 34, 498, DateTimeKind.Utc).AddTicks(5097), new DateTime(2023, 6, 27, 8, 10, 30, 926, DateTimeKind.Utc).AddTicks(3789), 1, new DateTime(2023, 7, 24, 16, 6, 42, 720, DateTimeKind.Utc).AddTicks(2278), 19L },
                    { 102L, 151.37m, new DateTime(2023, 1, 31, 6, 19, 39, 307, DateTimeKind.Utc).AddTicks(8308), false, "v9jped3wpf21omxi", new DateTime(2022, 10, 11, 7, 23, 53, 707, DateTimeKind.Utc).AddTicks(5256), new DateTime(2022, 5, 28, 16, 28, 12, 139, DateTimeKind.Utc).AddTicks(9697), 2, new DateTime(2023, 8, 9, 23, 12, 58, 187, DateTimeKind.Utc).AddTicks(9766), 40L },
                    { 103L, 91.86m, new DateTime(2024, 3, 5, 17, 38, 16, 944, DateTimeKind.Utc).AddTicks(8010), false, "a7ftky80unai4cdk", new DateTime(2023, 3, 19, 11, 38, 17, 153, DateTimeKind.Utc).AddTicks(8423), new DateTime(2022, 10, 3, 18, 27, 11, 804, DateTimeKind.Utc).AddTicks(2782), 3, new DateTime(2022, 12, 12, 5, 22, 56, 691, DateTimeKind.Utc).AddTicks(6690), 20L },
                    { 104L, 136.02m, new DateTime(2021, 5, 31, 4, 20, 41, 565, DateTimeKind.Utc).AddTicks(379), false, "2fl25kawdqe7y9cr", new DateTime(2021, 1, 27, 11, 30, 2, 308, DateTimeKind.Utc).AddTicks(7663), new DateTime(2020, 12, 28, 12, 15, 19, 78, DateTimeKind.Utc).AddTicks(5359), 1, new DateTime(2022, 2, 1, 10, 3, 50, 410, DateTimeKind.Utc).AddTicks(21), 8L },
                    { 105L, 151.37m, new DateTime(2023, 3, 13, 23, 6, 49, 466, DateTimeKind.Utc).AddTicks(5581), true, "yrti9du39mr5c5va", new DateTime(2022, 4, 5, 2, 11, 0, 624, DateTimeKind.Utc).AddTicks(1227), new DateTime(2021, 5, 24, 16, 50, 1, 279, DateTimeKind.Utc).AddTicks(9177), 2, new DateTime(2021, 10, 18, 20, 57, 55, 195, DateTimeKind.Utc).AddTicks(8687), 14L },
                    { 106L, 136.02m, new DateTime(2023, 12, 29, 17, 33, 46, 739, DateTimeKind.Utc).AddTicks(8090), true, "fybw1xhn0y3drrm0", new DateTime(2023, 6, 25, 5, 14, 50, 753, DateTimeKind.Utc).AddTicks(8760), new DateTime(2023, 5, 25, 18, 9, 38, 229, DateTimeKind.Utc).AddTicks(5529), 1, new DateTime(2023, 6, 13, 1, 15, 18, 75, DateTimeKind.Utc).AddTicks(2904), 36L },
                    { 107L, 136.02m, new DateTime(2019, 11, 2, 6, 56, 23, 554, DateTimeKind.Utc).AddTicks(2689), false, "6voy90ps5l3b1y1b", new DateTime(2019, 10, 6, 18, 25, 6, 972, DateTimeKind.Utc).AddTicks(5135), new DateTime(2017, 2, 10, 16, 21, 37, 874, DateTimeKind.Utc).AddTicks(1670), 1, new DateTime(2020, 5, 7, 13, 50, 30, 378, DateTimeKind.Utc).AddTicks(7840), 6L },
                    { 108L, 136.02m, new DateTime(2022, 12, 16, 19, 17, 0, 906, DateTimeKind.Utc).AddTicks(271), false, "r4im89p8kap58jd0", new DateTime(2022, 4, 11, 21, 11, 3, 916, DateTimeKind.Utc).AddTicks(7107), new DateTime(2022, 1, 2, 10, 46, 19, 440, DateTimeKind.Utc).AddTicks(4494), 1, new DateTime(2022, 7, 8, 5, 57, 0, 715, DateTimeKind.Utc).AddTicks(7887), 10L },
                    { 109L, 91.86m, new DateTime(2023, 8, 19, 2, 43, 36, 616, DateTimeKind.Utc).AddTicks(2253), false, "9l7e2zypb364i3jv", new DateTime(2023, 5, 21, 17, 11, 53, 709, DateTimeKind.Utc).AddTicks(6529), new DateTime(2022, 7, 31, 3, 2, 38, 948, DateTimeKind.Utc).AddTicks(6357), 3, new DateTime(2023, 7, 11, 8, 7, 10, 411, DateTimeKind.Utc).AddTicks(7599), 35L },
                    { 110L, 136.02m, new DateTime(2023, 8, 9, 4, 56, 31, 572, DateTimeKind.Utc).AddTicks(7488), true, "p45radwg6kdm2a5k", new DateTime(2023, 4, 4, 14, 39, 22, 158, DateTimeKind.Utc).AddTicks(5002), new DateTime(2023, 3, 13, 15, 40, 51, 12, DateTimeKind.Utc).AddTicks(5189), 1, new DateTime(2023, 4, 23, 14, 48, 18, 831, DateTimeKind.Utc).AddTicks(2204), 14L }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[,]
                {
                    { 1L, 59L, "Doloribus modi voluptatum facere eius rerum provident nemo soluta quidem.", new DateTime(2023, 7, 20, 19, 20, 36, 714, DateTimeKind.Utc).AddTicks(8335), 12L, "Eos quae aliquid qui est sit quidem doloribus.", 2, 1 },
                    { 2L, 38L, "Est aut repellendus qui fugit.", new DateTime(2022, 5, 28, 4, 56, 26, 485, DateTimeKind.Utc).AddTicks(2323), 4L, "Iusto aut nesciunt modi et quibusdam.", 3, 0 },
                    { 3L, 8L, "Omnis inventore velit.\nMaxime fuga fugiat eos.\nAdipisci id dolores et fugit vero vitae.", new DateTime(2023, 3, 29, 11, 59, 36, 686, DateTimeKind.Utc).AddTicks(9544), 8L, "Consequuntur alias ipsam quo alias et quisquam voluptates.", 1, 0 },
                    { 4L, 21L, "Nam omnis est magnam rerum eum repudiandae minima tenetur quis. Reprehenderit accusamus dolore est ratione maiores. Et perspiciatis sequi minima pariatur dignissimos eum. Dolorum qui cum voluptatibus quibusdam corporis saepe dolores. Error magni eum dolore minima amet. Temporibus esse magni nihil est officiis ducimus aut dolorem sit.", new DateTime(2023, 1, 27, 12, 1, 44, 877, DateTimeKind.Utc).AddTicks(7697), 16L, "Et vel voluptatum quia quia nesciunt sequi impedit.", 1, 3 },
                    { 5L, 43L, "Et id nulla nesciunt. Nesciunt minima cupiditate. Dolore corrupti iusto ipsam sapiente. Maxime alias nam.", new DateTime(2023, 7, 22, 14, 4, 12, 92, DateTimeKind.Utc).AddTicks(5266), 24L, "Accusamus magnam quia laudantium id.", 4, 0 },
                    { 6L, 59L, "Corporis illum molestiae hic et officiis accusantium nostrum. Aut et error itaque animi eveniet ut delectus voluptates dolorem. Laudantium itaque sequi officiis sapiente et.", new DateTime(2022, 5, 3, 23, 43, 23, 577, DateTimeKind.Utc).AddTicks(1481), 7L, "Et pariatur sapiente.", 2, 1 },
                    { 7L, 57L, "Non porro impedit.", new DateTime(2021, 12, 15, 13, 48, 14, 708, DateTimeKind.Utc).AddTicks(5706), 27L, "Blanditiis quidem earum tempore molestias.", 3, 2 },
                    { 8L, 53L, "Sit molestiae adipisci repellat eum vel dolorum aut ullam distinctio.\nOmnis animi officiis tenetur.", new DateTime(2019, 7, 7, 8, 44, 39, 404, DateTimeKind.Utc).AddTicks(8521), 15L, "Fugit mollitia aut ab eum est quaerat consequatur.", 3, 1 },
                    { 9L, 27L, "qui", new DateTime(2022, 4, 30, 22, 53, 17, 421, DateTimeKind.Utc).AddTicks(5044), 1L, "Dolore possimus quisquam optio veniam.", 4, 2 },
                    { 10L, 3L, "unde", new DateTime(2023, 3, 24, 14, 17, 38, 416, DateTimeKind.Utc).AddTicks(6735), 34L, "Sit repellendus cupiditate quo quo doloribus.", 2, 3 },
                    { 11L, 16L, "Soluta est libero voluptatum ullam unde libero dolorem voluptatem et.", new DateTime(2023, 2, 12, 2, 52, 59, 999, DateTimeKind.Utc).AddTicks(9501), 9L, "Officiis eos molestias explicabo.", 1, 1 },
                    { 12L, 51L, "omnis", new DateTime(2023, 8, 23, 4, 3, 35, 169, DateTimeKind.Utc).AddTicks(6552), 35L, "Modi eaque iusto commodi.", 4, 3 },
                    { 13L, 38L, "Voluptatem et veniam iusto rerum.", new DateTime(2021, 11, 10, 19, 20, 45, 135, DateTimeKind.Utc).AddTicks(404), 14L, "Culpa maiores officiis deleniti cumque similique optio et sed ab.", 3, 0 },
                    { 14L, 43L, "Nihil officia minima quae id occaecati quod.", new DateTime(2023, 8, 6, 15, 30, 37, 194, DateTimeKind.Utc).AddTicks(3343), 7L, "Totam expedita hic vel sint rerum earum facilis.", 3, 0 },
                    { 15L, 51L, "Itaque quidem debitis nisi voluptate. Placeat facere omnis ea quia ea voluptatibus id laborum. Consequatur iure nisi voluptatem temporibus.", new DateTime(2023, 5, 19, 15, 11, 53, 402, DateTimeKind.Utc).AddTicks(4440), 19L, "Ipsa sequi voluptatum qui.", 3, 2 },
                    { 16L, 65L, "Recusandae rerum dolor assumenda maiores placeat magnam debitis.\nFacilis velit et qui totam et iusto consequatur ut.", new DateTime(2020, 11, 27, 4, 53, 17, 68, DateTimeKind.Utc).AddTicks(1224), 35L, "Et expedita dignissimos et neque atque aut.", 2, 0 },
                    { 17L, 28L, "Perspiciatis dolorum architecto placeat. Eum aut repellendus laudantium est cumque velit. Voluptatum fugiat aut. Est voluptatum natus sed qui. Inventore beatae totam et necessitatibus velit. Et pariatur voluptas veniam rerum.", new DateTime(2022, 3, 12, 19, 59, 40, 663, DateTimeKind.Utc).AddTicks(688), 35L, "Nulla explicabo suscipit molestiae perferendis.", 1, 1 },
                    { 18L, 7L, "Quis dignissimos ipsam et in dolores perferendis.", new DateTime(2022, 12, 1, 0, 45, 48, 545, DateTimeKind.Utc).AddTicks(5261), 37L, "Dolorum praesentium blanditiis quia commodi non quis voluptatem.", 3, 1 },
                    { 19L, 24L, "Ab at at dolorem qui nobis doloremque.\nQuo aliquam omnis et illo voluptas culpa ea ducimus ea.\nEt eum est est neque qui.\nVoluptatem unde voluptatem non.\nDolor et dolor molestias et officia.", new DateTime(2021, 9, 1, 23, 23, 57, 441, DateTimeKind.Utc).AddTicks(5357), 5L, "Et at iusto illum.", 2, 2 },
                    { 20L, 67L, "Vitae eligendi consequatur laboriosam commodi atque.\nDolor eos est repellat enim aliquam ratione.", new DateTime(2023, 8, 22, 3, 51, 35, 147, DateTimeKind.Utc).AddTicks(4036), 31L, "Voluptas et quis voluptatem autem voluptas ducimus maiores praesentium odit.", 4, 0 },
                    { 21L, 29L, "Rerum recusandae cum et officia odit aliquid saepe corrupti. Aliquid dolorum iste quia voluptatibus dolores nostrum ab quia dolor. Doloremque odio suscipit animi recusandae quo voluptatem odio.", new DateTime(2023, 6, 16, 2, 5, 28, 153, DateTimeKind.Utc).AddTicks(8232), 11L, "Est recusandae aliquam provident molestiae.", 2, 1 },
                    { 22L, 58L, "Cumque sint tenetur sed et.", new DateTime(2023, 7, 14, 17, 7, 42, 453, DateTimeKind.Utc).AddTicks(4717), 10L, "Non aspernatur recusandae soluta ratione quibusdam et totam voluptatem.", 4, 0 },
                    { 23L, 25L, "qui", new DateTime(2023, 1, 26, 5, 59, 13, 982, DateTimeKind.Utc).AddTicks(852), 14L, "Laboriosam totam expedita reprehenderit sed blanditiis.", 4, 3 },
                    { 24L, 38L, "Natus esse sint magnam incidunt velit adipisci voluptatem.", new DateTime(2020, 5, 20, 20, 19, 8, 18, DateTimeKind.Utc).AddTicks(459), 10L, "Ea consequatur aut.", 1, 2 },
                    { 25L, 24L, "Ut vitae aut molestias. Expedita provident ex beatae nihil numquam nihil adipisci consequatur. Dolor quae sit consequuntur. Esse et veniam saepe nisi eius. Labore aut aut molestiae quaerat iure voluptatem exercitationem ut. Doloremque facere similique molestiae error.", new DateTime(2022, 8, 27, 23, 41, 24, 138, DateTimeKind.Utc).AddTicks(5126), 25L, "Iusto possimus laudantium accusantium possimus mollitia totam blanditiis odio corrupti.", 2, 0 },
                    { 26L, 13L, "Doloribus dolorem et accusamus nostrum aliquam aut repellat tenetur.", new DateTime(2022, 2, 6, 0, 31, 29, 49, DateTimeKind.Utc).AddTicks(6931), 37L, "Voluptas tempore reprehenderit nesciunt et dignissimos omnis.", 1, 2 },
                    { 27L, 60L, "Facilis quod expedita adipisci voluptates molestiae qui ut qui rerum. Perferendis iusto ea et quia. Harum nemo aliquam suscipit exercitationem error iure rerum. Et autem culpa nemo delectus voluptates.", new DateTime(2023, 8, 4, 23, 51, 51, 389, DateTimeKind.Utc).AddTicks(6702), 17L, "In iste voluptatum.", 1, 1 },
                    { 28L, 39L, "Sequi blanditiis vero.", new DateTime(2021, 2, 20, 17, 4, 16, 689, DateTimeKind.Utc).AddTicks(507), 25L, "Vel dolorem occaecati minus natus explicabo repudiandae optio.", 4, 0 },
                    { 29L, 69L, "nobis", new DateTime(2023, 6, 13, 4, 54, 8, 383, DateTimeKind.Utc).AddTicks(137), 40L, "Ut enim atque amet.", 1, 1 },
                    { 30L, 12L, "Minus id minus rem voluptatum amet.", new DateTime(2023, 6, 16, 4, 4, 25, 817, DateTimeKind.Utc).AddTicks(442), 6L, "Odio ratione voluptatem.", 4, 0 },
                    { 31L, 37L, "Consequatur eveniet quidem enim quae voluptatum fugit error. Aut veritatis quo nemo fugiat deserunt veritatis ad. Et nihil autem.", new DateTime(2022, 4, 14, 0, 5, 25, 872, DateTimeKind.Utc).AddTicks(2141), 40L, "Commodi perferendis ut.", 1, 0 },
                    { 32L, 44L, "Quam iste aliquam ex repudiandae atque beatae odit excepturi.", new DateTime(2023, 3, 6, 20, 30, 29, 462, DateTimeKind.Utc).AddTicks(1570), 13L, "At maiores aut aliquid perferendis adipisci odio expedita.", 4, 2 },
                    { 33L, 37L, "Voluptas corrupti voluptas quaerat in minus provident.", new DateTime(2021, 4, 18, 4, 2, 46, 361, DateTimeKind.Utc).AddTicks(610), 8L, "Vel ut repudiandae et.", 1, 3 },
                    { 34L, 43L, "Repudiandae voluptatum quod sit voluptas nobis. Magni harum expedita non. Voluptatibus tempora explicabo quasi esse aspernatur. Facere perspiciatis inventore asperiores hic. Nostrum dicta rerum omnis voluptatem consectetur.", new DateTime(2023, 8, 16, 23, 25, 0, 554, DateTimeKind.Utc).AddTicks(5573), 29L, "At praesentium ea ut.", 1, 3 },
                    { 35L, 35L, "Omnis iure rerum magnam perspiciatis necessitatibus et vero deleniti autem. Eaque animi ut consequatur laborum laudantium quos. Inventore cupiditate labore voluptas officia neque ducimus aliquam eos. Dolores est tempore doloremque aspernatur consequuntur autem beatae.", new DateTime(2023, 7, 5, 14, 54, 4, 699, DateTimeKind.Utc).AddTicks(8474), 1L, "Dolorem recusandae necessitatibus dolores ea velit vero laboriosam.", 4, 2 },
                    { 36L, 60L, "et", new DateTime(2022, 8, 11, 7, 42, 54, 152, DateTimeKind.Utc).AddTicks(1877), 8L, "Hic dolore eveniet nostrum voluptatem.", 2, 3 },
                    { 37L, 38L, "Et consequatur et eius.", new DateTime(2018, 3, 16, 17, 28, 51, 884, DateTimeKind.Utc).AddTicks(8889), 1L, "Veritatis ex sunt aspernatur quidem voluptas non.", 4, 2 },
                    { 38L, 51L, "Sequi aut aut nulla quod.", new DateTime(2022, 12, 24, 22, 38, 8, 243, DateTimeKind.Utc).AddTicks(4928), 26L, "Cum et autem.", 4, 3 },
                    { 39L, 66L, "Laboriosam saepe temporibus non ipsa ut accusamus voluptas eos.\nRepellendus expedita est perferendis.", new DateTime(2022, 1, 9, 21, 38, 49, 212, DateTimeKind.Utc).AddTicks(9794), 27L, "Quisquam at reprehenderit beatae magnam.", 4, 2 },
                    { 40L, 52L, "Temporibus quae fugiat.\nConsequatur quis commodi ipsum veritatis in officiis.\nAt cum nulla rerum fuga impedit doloremque qui unde deserunt.\nEt aliquid ratione quisquam molestiae.\nCommodi qui velit incidunt nulla.", new DateTime(2023, 3, 15, 2, 24, 16, 73, DateTimeKind.Utc).AddTicks(2555), 4L, "Quam consectetur ipsum et et soluta vel.", 2, 3 },
                    { 41L, 14L, "Sit libero inventore odit facilis nesciunt.", new DateTime(2022, 5, 31, 1, 44, 5, 551, DateTimeKind.Utc).AddTicks(1057), 17L, "In ea animi autem qui dolores.", 2, 3 },
                    { 42L, 50L, "quia", new DateTime(2022, 8, 24, 23, 47, 32, 359, DateTimeKind.Utc).AddTicks(5553), 35L, "Est odio vero optio consequuntur tempore est consequatur nemo.", 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[,]
                {
                    { 43L, 68L, "autem", new DateTime(2022, 8, 17, 20, 33, 19, 392, DateTimeKind.Utc).AddTicks(8885), 33L, "Rem cumque at consequatur tempora et facilis corporis ut iste.", 1, 1 },
                    { 44L, 48L, "Et veniam veniam quia nemo cumque.\nAb nihil sed non qui omnis.\nEt harum dolores.\nOptio quisquam omnis est.", new DateTime(2022, 9, 12, 19, 1, 49, 974, DateTimeKind.Utc).AddTicks(1763), 33L, "Dolores quas ut nam illo consequatur sit amet repudiandae.", 3, 0 },
                    { 45L, 35L, "autem", new DateTime(2023, 8, 12, 5, 15, 38, 872, DateTimeKind.Utc).AddTicks(6785), 4L, "Deleniti eaque doloribus.", 4, 3 },
                    { 46L, 13L, "Ab est pariatur autem pariatur nostrum unde animi. Et illo ea. Iure unde fugit animi quo et dolorem.", new DateTime(2021, 9, 28, 14, 18, 11, 788, DateTimeKind.Utc).AddTicks(4466), 40L, "Quisquam quam aspernatur vel animi nostrum molestias necessitatibus.", 3, 1 },
                    { 47L, 4L, "Eius dolore repellat sunt velit labore dolores nulla nesciunt libero. Cupiditate doloribus ab. Et ab enim consequatur. Debitis quis officiis quos. Saepe voluptate quia ut culpa ut. Autem in sit accusamus animi maxime molestiae.", new DateTime(2022, 7, 5, 2, 9, 49, 50, DateTimeKind.Utc).AddTicks(5294), 13L, "Qui eos reprehenderit culpa sint impedit.", 3, 1 },
                    { 48L, 49L, "Atque dolorum odit non quis molestias.\nCorporis fugiat quis nemo culpa voluptatem omnis minus.\nQuisquam nemo corporis corporis rerum dolor sed.\nSapiente error dolore praesentium quos quia asperiores.\nImpedit tenetur voluptatem ipsum nostrum in dolores explicabo quae.\nFacere possimus sit maxime.", new DateTime(2023, 3, 31, 4, 1, 59, 342, DateTimeKind.Utc).AddTicks(6573), 33L, "Recusandae ea dicta numquam.", 4, 0 },
                    { 49L, 22L, "Odio officiis consequatur non natus. Voluptatem vel non quaerat omnis. Ea provident eius. Iste quaerat cum a dicta et ratione. Ipsam libero id iusto nobis fugiat.", new DateTime(2023, 6, 29, 22, 13, 41, 725, DateTimeKind.Utc).AddTicks(6154), 19L, "Consequatur error molestias nihil quas omnis delectus consequatur quaerat labore.", 4, 0 },
                    { 50L, 27L, "Maxime ut cumque.\nDolores unde non earum qui et non saepe natus rerum.", new DateTime(2023, 2, 11, 9, 0, 35, 412, DateTimeKind.Utc).AddTicks(8132), 18L, "Fuga neque quidem excepturi ipsa explicabo nesciunt nemo placeat.", 1, 1 },
                    { 51L, 23L, "Porro est qui magni eum dolor optio.\nQuidem qui cumque hic maxime.\nNesciunt delectus omnis vero corporis eveniet et et in quis.\nEa ut quidem eius animi.\nTempora in consequatur voluptas velit cum dolore dolorum ut vitae.", new DateTime(2023, 7, 25, 9, 33, 51, 455, DateTimeKind.Utc).AddTicks(7999), 10L, "Tenetur ut hic qui dolorum dolorem repudiandae doloribus laboriosam quo.", 3, 0 },
                    { 52L, 15L, "dolorem", new DateTime(2021, 5, 4, 12, 48, 0, 692, DateTimeKind.Utc).AddTicks(5334), 2L, "Non possimus voluptatem natus voluptatibus iure quod veniam et nostrum.", 2, 0 },
                    { 53L, 34L, "Ut eaque vel animi placeat adipisci eaque.", new DateTime(2023, 4, 5, 23, 31, 24, 38, DateTimeKind.Utc).AddTicks(9944), 36L, "Rem autem vel aut sapiente.", 4, 3 },
                    { 54L, 36L, "consectetur", new DateTime(2022, 5, 2, 15, 48, 51, 797, DateTimeKind.Utc).AddTicks(6241), 7L, "Voluptates voluptas fugiat.", 4, 1 },
                    { 55L, 8L, "Aut quibusdam minus doloremque maxime aliquid. Nobis ut explicabo consequuntur delectus maiores blanditiis sit quo asperiores. Harum ut ullam et ab.", new DateTime(2023, 4, 25, 17, 9, 28, 324, DateTimeKind.Utc).AddTicks(1711), 40L, "Laborum veniam hic.", 4, 0 },
                    { 56L, 10L, "In quis vel iure blanditiis dolorem mollitia quo est quis.", new DateTime(2018, 7, 12, 17, 59, 48, 615, DateTimeKind.Utc).AddTicks(7768), 8L, "Totam dolore voluptatem repellendus doloribus et beatae laudantium aut neque.", 3, 2 },
                    { 57L, 55L, "Et aut autem maiores sit qui et eveniet harum labore. Est sint iure tenetur numquam dolor. Quia dolore temporibus rem suscipit excepturi dicta quas.", new DateTime(2023, 8, 21, 13, 37, 27, 612, DateTimeKind.Utc).AddTicks(9490), 35L, "Tenetur molestiae distinctio commodi dolores optio iusto pariatur.", 1, 2 },
                    { 58L, 38L, "Unde molestias natus ad quod. Dolor atque quaerat quia quod recusandae quia voluptas assumenda et. Soluta sit at velit repellendus ad accusamus autem facere deserunt. Illum aut modi quia. Quos molestiae dolorem hic consequatur. Voluptatem mollitia eius deserunt possimus repellendus laboriosam a laudantium.", new DateTime(2023, 7, 12, 16, 54, 19, 404, DateTimeKind.Utc).AddTicks(7126), 30L, "Ad dolorem autem minus in ullam quam.", 4, 1 },
                    { 59L, 2L, "Eum sapiente libero vel voluptatibus et deserunt porro ea earum.\nSunt sint accusamus aliquam reiciendis consectetur sint dicta eaque autem.\nAliquam minima atque atque.\nQuis reprehenderit neque mollitia.\nRepudiandae est assumenda harum omnis.\nOmnis dolorem placeat et.", new DateTime(2023, 6, 13, 15, 53, 16, 328, DateTimeKind.Utc).AddTicks(7739), 13L, "Aut omnis incidunt.", 1, 2 },
                    { 60L, 46L, "Adipisci aliquam impedit iure saepe dolores voluptatum corporis voluptas.\nUt expedita dolor qui.\nDolorum molestiae reiciendis.\nSint quis omnis et incidunt distinctio dolor distinctio.\nQuos ut deserunt.", new DateTime(2023, 5, 3, 10, 57, 20, 549, DateTimeKind.Utc).AddTicks(9921), 24L, "Quibusdam quia sunt.", 4, 0 },
                    { 61L, 5L, "Eligendi mollitia aut est.\nRerum amet voluptatum qui porro fugiat dignissimos.", new DateTime(2022, 12, 20, 8, 58, 49, 992, DateTimeKind.Utc).AddTicks(998), 19L, "Neque voluptatem minima eligendi ducimus repudiandae dolorem tempore delectus consequuntur.", 4, 2 },
                    { 62L, 70L, "Voluptas quidem labore iste.\nIllo maiores sit ipsam sunt repellat et delectus.\nItaque voluptas ducimus iusto id dignissimos.\nHarum vero dolor sed.", new DateTime(2023, 7, 8, 21, 23, 53, 975, DateTimeKind.Utc).AddTicks(6999), 17L, "Error officia optio ut.", 4, 0 },
                    { 63L, 36L, "Pariatur nihil et atque est error ipsa facilis. Voluptatem dolore eum illo voluptatem reiciendis quia. Inventore ex minus illo accusamus mollitia fugiat ratione veritatis.", new DateTime(2022, 10, 12, 13, 30, 34, 400, DateTimeKind.Utc).AddTicks(7235), 38L, "Itaque excepturi praesentium qui alias hic.", 2, 2 },
                    { 64L, 7L, "Corrupti neque ut mollitia aut.\nDeleniti cupiditate modi necessitatibus error corporis.\nVoluptatibus eum libero laboriosam officia dolorem sed.\nEst rerum porro et fugit molestiae sequi quasi velit cupiditate.\nVel cumque vel iusto mollitia unde dolor et.\nTempora porro atque.", new DateTime(2023, 8, 21, 11, 36, 50, 334, DateTimeKind.Utc).AddTicks(5329), 25L, "In itaque deserunt dolorem dolores quis provident.", 4, 1 },
                    { 65L, 35L, "Dolorem voluptas veritatis voluptas qui vel consequatur.", new DateTime(2023, 2, 11, 16, 39, 40, 105, DateTimeKind.Utc).AddTicks(4293), 24L, "Aperiam rerum rem eum blanditiis et.", 4, 3 },
                    { 66L, 47L, "In possimus sit temporibus vel nesciunt id autem culpa et.\nEt in nesciunt beatae vel velit.\nOptio omnis et sed aut est esse perferendis animi.\nLabore sed quia accusamus temporibus eum.\nOmnis fugiat reiciendis dolore dolorem pariatur iusto repellendus laborum.", new DateTime(2023, 8, 19, 18, 43, 26, 792, DateTimeKind.Utc).AddTicks(703), 10L, "Autem voluptate voluptatem.", 1, 0 },
                    { 67L, 21L, "Et natus sed dolores ipsa.\nIste blanditiis placeat.\nVoluptatem perspiciatis iusto mollitia provident.\nRem sit et unde placeat doloribus consequatur voluptate eum perspiciatis.\nIllo eveniet omnis deserunt sed aut est dignissimos id.", new DateTime(2022, 9, 11, 15, 46, 33, 150, DateTimeKind.Utc).AddTicks(2954), 24L, "Asperiores quam illum necessitatibus et veniam.", 3, 2 },
                    { 68L, 1L, "Sapiente mollitia hic ratione quia.\nConsequatur consectetur quibusdam nemo et et et.\nMaiores eligendi velit iusto eum voluptatem molestiae.\nIpsum officia et quae sed.\nNihil minus sapiente voluptatibus delectus est recusandae neque.\nAut recusandae maiores harum esse nulla doloribus dolore.", new DateTime(2022, 6, 16, 9, 8, 54, 422, DateTimeKind.Utc).AddTicks(2378), 12L, "Enim rerum tempore et.", 2, 2 },
                    { 69L, 25L, "Magni dicta explicabo assumenda.", new DateTime(2023, 6, 24, 11, 20, 15, 701, DateTimeKind.Utc).AddTicks(5934), 12L, "Et qui tempore ex cum molestiae.", 1, 2 },
                    { 70L, 12L, "Laboriosam officia ipsa debitis.", new DateTime(2023, 5, 22, 11, 15, 6, 633, DateTimeKind.Utc).AddTicks(5350), 22L, "Qui illo tempora et nulla sint molestias.", 2, 1 },
                    { 71L, 38L, "Est repellendus est qui illo ad aperiam. Velit et non rerum sequi nulla. Dolore voluptatem quidem dicta. Distinctio mollitia et consequatur. Maiores enim commodi dicta omnis. Optio earum reiciendis eos et provident.", new DateTime(2023, 6, 14, 20, 4, 20, 861, DateTimeKind.Utc).AddTicks(1220), 34L, "Quam quaerat id ad placeat.", 3, 3 },
                    { 72L, 30L, "Maiores quo totam.\nDelectus tempore vel.\nVoluptas incidunt earum dolor maiores qui.\nVelit aut voluptatem ea eligendi et repellendus sed.\nNulla id laboriosam deserunt cupiditate commodi voluptatibus magnam explicabo consequatur.\nOptio ratione praesentium aut ipsum officia unde magnam.", new DateTime(2022, 5, 7, 1, 10, 46, 265, DateTimeKind.Utc).AddTicks(1524), 24L, "Sit id consequatur eos sunt voluptatem quos aliquam fugit porro.", 2, 3 },
                    { 73L, 56L, "tempora", new DateTime(2022, 9, 7, 7, 41, 58, 154, DateTimeKind.Utc).AddTicks(6691), 17L, "Voluptas perferendis qui sit amet nihil sed harum similique.", 2, 3 },
                    { 74L, 59L, "beatae", new DateTime(2022, 4, 6, 9, 51, 6, 917, DateTimeKind.Utc).AddTicks(7184), 36L, "Vitae quia repudiandae perferendis ut rerum sint amet.", 3, 1 },
                    { 75L, 57L, "in", new DateTime(2019, 5, 7, 7, 4, 17, 945, DateTimeKind.Utc).AddTicks(6797), 34L, "Consequatur soluta aliquid qui sint et iure totam veritatis in.", 4, 2 },
                    { 76L, 57L, "nisi", new DateTime(2019, 2, 6, 23, 58, 45, 819, DateTimeKind.Utc).AddTicks(6973), 14L, "Aut velit cupiditate voluptas in quis aut qui.", 3, 0 },
                    { 77L, 8L, "Est ea itaque ut ullam molestiae nobis cumque maxime repellat. Autem quae aut reiciendis nihil est qui ipsa. Quaerat atque necessitatibus et voluptate eum iusto autem laudantium. Impedit fuga beatae illum necessitatibus ut earum autem temporibus repudiandae.", new DateTime(2022, 8, 8, 16, 44, 44, 833, DateTimeKind.Utc).AddTicks(7791), 14L, "Aut numquam illo distinctio omnis quia.", 4, 1 },
                    { 78L, 69L, "Maxime est eligendi quia sint. Earum totam asperiores saepe labore temporibus. Fugit ullam incidunt numquam consequatur.", new DateTime(2023, 7, 22, 15, 53, 21, 999, DateTimeKind.Utc).AddTicks(2673), 6L, "Non fugit beatae.", 4, 0 },
                    { 79L, 6L, "Molestias hic ex debitis molestiae quia nobis qui. At voluptatem sint sunt et natus inventore. Possimus cumque eveniet quasi. Accusantium voluptatem et fugiat.", new DateTime(2023, 8, 20, 8, 34, 34, 159, DateTimeKind.Utc).AddTicks(2225), 12L, "Magni ut nesciunt aliquid.", 3, 3 },
                    { 80L, 19L, "provident", new DateTime(2022, 9, 4, 0, 11, 0, 476, DateTimeKind.Utc).AddTicks(2960), 29L, "Tempore quia qui voluptas non ut accusamus.", 3, 0 },
                    { 81L, 10L, "Eaque quaerat deserunt deserunt est voluptatum modi quaerat placeat et.", new DateTime(2023, 7, 27, 21, 57, 30, 309, DateTimeKind.Utc).AddTicks(5424), 6L, "Exercitationem sunt deleniti recusandae deserunt velit nihil facilis.", 4, 2 },
                    { 82L, 63L, "Alias quis magnam provident quam.", new DateTime(2023, 4, 23, 18, 15, 47, 606, DateTimeKind.Utc).AddTicks(1667), 12L, "Mollitia consequatur sint itaque ut animi voluptate fugit labore quas.", 4, 3 },
                    { 83L, 10L, "Magni autem sit.\nAt deleniti aliquid odit voluptatibus debitis.\nAutem asperiores eum quo quibusdam.\nAut est vitae ducimus.\nUt eaque harum dignissimos nemo architecto.", new DateTime(2022, 3, 13, 13, 20, 36, 45, DateTimeKind.Utc).AddTicks(6710), 12L, "Beatae aperiam et ut delectus aut neque at aliquid rerum.", 3, 1 },
                    { 84L, 57L, "et", new DateTime(2021, 9, 17, 21, 9, 54, 451, DateTimeKind.Utc).AddTicks(3886), 7L, "In ipsa ut qui.", 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[,]
                {
                    { 85L, 31L, "Voluptatum voluptatibus aut voluptate ipsum minima blanditiis voluptas.\nA est quibusdam voluptatibus tempore saepe.\nRerum consequatur sint harum nisi maxime et ipsa rem.\nEt mollitia accusantium laudantium sed dolore officia impedit similique et.\nPorro et rerum ea aliquam cum est maiores.", new DateTime(2022, 11, 3, 4, 42, 7, 149, DateTimeKind.Utc).AddTicks(5322), 7L, "Ut quam ducimus illo fugit recusandae explicabo.", 1, 3 },
                    { 86L, 26L, "Omnis voluptas itaque quis est vero illum sit.", new DateTime(2021, 5, 12, 13, 56, 34, 825, DateTimeKind.Utc).AddTicks(7702), 11L, "Veniam id aut.", 4, 0 },
                    { 87L, 55L, "Iusto eligendi esse sint facilis laborum ea quo quis.", new DateTime(2023, 7, 27, 5, 36, 32, 980, DateTimeKind.Utc).AddTicks(7782), 10L, "Eos ipsum sit aperiam ad dicta quasi dolor inventore ullam.", 4, 1 },
                    { 88L, 8L, "adipisci", new DateTime(2022, 6, 25, 11, 50, 41, 122, DateTimeKind.Utc).AddTicks(4807), 29L, "Distinctio saepe dolorum delectus neque tempore.", 4, 2 },
                    { 89L, 29L, "Repudiandae ut animi quaerat reprehenderit voluptas et. Est voluptate rerum iusto sit veniam dolor magnam et. Illum architecto repudiandae explicabo quia id ipsum. Et et beatae ipsam. Inventore ut quis.", new DateTime(2023, 4, 28, 7, 17, 27, 636, DateTimeKind.Utc).AddTicks(3312), 38L, "Assumenda impedit quidem quo et quam quia animi.", 1, 2 },
                    { 90L, 46L, "Iste fuga ipsum fuga inventore.", new DateTime(2023, 1, 26, 3, 40, 53, 143, DateTimeKind.Utc).AddTicks(3735), 33L, "Voluptas molestiae laborum magnam aut.", 1, 2 },
                    { 91L, 40L, "assumenda", new DateTime(2021, 11, 26, 8, 53, 6, 515, DateTimeKind.Utc).AddTicks(4454), 23L, "Dicta magnam laboriosam consequatur optio suscipit aliquid eum provident sapiente.", 3, 0 },
                    { 92L, 31L, "quaerat", new DateTime(2023, 6, 19, 2, 2, 15, 44, DateTimeKind.Utc).AddTicks(9471), 24L, "Atque et quisquam eveniet quo rerum consequatur et est repellat.", 3, 1 },
                    { 93L, 45L, "Nisi occaecati at molestias veritatis alias laudantium suscipit. Suscipit ipsum minima consectetur esse reprehenderit natus temporibus. Aliquid autem ad ut est blanditiis architecto impedit.", new DateTime(2021, 11, 14, 14, 18, 11, 536, DateTimeKind.Utc).AddTicks(5267), 31L, "Et qui incidunt minima.", 4, 3 },
                    { 94L, 37L, "In fuga repellat sunt et alias sunt ratione enim distinctio.", new DateTime(2022, 7, 6, 11, 23, 31, 683, DateTimeKind.Utc).AddTicks(7317), 18L, "Libero sequi quos.", 4, 3 },
                    { 95L, 66L, "eum", new DateTime(2022, 8, 23, 18, 12, 54, 449, DateTimeKind.Utc).AddTicks(3102), 7L, "Quaerat totam beatae voluptates in et ex.", 2, 0 },
                    { 96L, 37L, "Aliquid modi aliquid.", new DateTime(2020, 9, 15, 7, 55, 50, 962, DateTimeKind.Utc).AddTicks(1851), 31L, "Molestiae sapiente animi.", 2, 1 },
                    { 97L, 22L, "Nobis velit sint natus delectus enim.\nQuod quas et a asperiores cumque fuga necessitatibus error.\nAb et velit aperiam.\nConsequatur qui dicta.", new DateTime(2023, 5, 30, 10, 18, 5, 242, DateTimeKind.Utc).AddTicks(2639), 29L, "Odit beatae ipsam.", 3, 0 },
                    { 98L, 39L, "Non atque nulla sed iste ipsam veritatis nihil.", new DateTime(2023, 6, 21, 22, 54, 53, 647, DateTimeKind.Utc).AddTicks(912), 11L, "Error nobis velit aliquid excepturi ducimus ipsa.", 1, 3 },
                    { 99L, 44L, "Nam sit nesciunt ducimus qui enim et enim autem sed.", new DateTime(2022, 11, 2, 16, 1, 24, 446, DateTimeKind.Utc).AddTicks(7953), 27L, "Autem error animi quia rem.", 1, 3 },
                    { 100L, 25L, "dolor", new DateTime(2023, 7, 15, 14, 40, 49, 970, DateTimeKind.Utc).AddTicks(2726), 17L, "Est voluptas est id debitis.", 3, 2 },
                    { 101L, 11L, "consequatur", new DateTime(2023, 1, 7, 13, 4, 46, 765, DateTimeKind.Utc).AddTicks(3771), 18L, "Voluptates quia sunt consequuntur omnis eos laudantium est facere.", 3, 3 },
                    { 102L, 46L, "harum", new DateTime(2023, 7, 30, 21, 4, 9, 175, DateTimeKind.Utc).AddTicks(4165), 32L, "Dicta animi dolorem exercitationem asperiores veniam cumque est.", 4, 0 },
                    { 103L, 5L, "Voluptas ipsa est veniam facere at quo occaecati.\nRepellat quos sint ipsa officiis odio est incidunt dolorum.\nExpedita quis aut.\nLibero quis harum aperiam qui asperiores temporibus id impedit dolores.\nRecusandae facilis commodi aliquid sunt aut eum.\nVitae cum doloribus perspiciatis placeat.", new DateTime(2023, 4, 14, 0, 50, 40, 337, DateTimeKind.Utc).AddTicks(1738), 24L, "Atque laudantium autem et dolores sunt consequatur sunt.", 3, 1 },
                    { 104L, 30L, "Voluptatem voluptatem dolor dolor odio earum autem. Aut non tempora ad aspernatur. Quia soluta quod. Quis vitae deserunt non ut nesciunt itaque nostrum minima corrupti. Ex aut voluptatibus consequatur maxime.", new DateTime(2022, 1, 18, 15, 2, 40, 265, DateTimeKind.Utc).AddTicks(3224), 31L, "Velit enim expedita nesciunt illo asperiores sed.", 1, 0 },
                    { 105L, 44L, "Ut provident corrupti non consequatur.", new DateTime(2023, 1, 13, 9, 47, 28, 658, DateTimeKind.Utc).AddTicks(4261), 6L, "Ut beatae cumque itaque quia et non et tenetur.", 4, 3 },
                    { 106L, 6L, "Temporibus rem reiciendis sunt atque vel sint excepturi voluptas quo.", new DateTime(2023, 8, 23, 0, 32, 32, 610, DateTimeKind.Utc).AddTicks(2087), 22L, "Perferendis cupiditate iste et laudantium.", 1, 2 },
                    { 107L, 11L, "Qui et neque qui sapiente veritatis. Vel beatae praesentium vero. Neque et minima nam quae cum esse ullam. Repellendus eum et perferendis assumenda vitae molestiae qui.", new DateTime(2022, 7, 8, 18, 29, 34, 543, DateTimeKind.Utc).AddTicks(2945), 29L, "Id qui voluptatem.", 4, 2 },
                    { 108L, 4L, "Qui quasi ea. In tenetur facere et sunt explicabo magni consectetur. Maxime natus veniam ipsam ipsam hic autem sit eius aliquam. Qui sapiente a porro accusantium ad voluptas doloremque.", new DateTime(2022, 8, 21, 1, 44, 32, 812, DateTimeKind.Utc).AddTicks(2798), 30L, "Inventore voluptate nisi at qui laboriosam hic omnis iste tempora.", 2, 2 },
                    { 109L, 42L, "distinctio", new DateTime(2022, 7, 19, 3, 22, 20, 64, DateTimeKind.Utc).AddTicks(8780), 20L, "Qui omnis et dicta delectus ipsam.", 2, 1 },
                    { 110L, 25L, "Aut autem et qui vel. Illum ipsum consectetur dolor recusandae aliquam earum quos neque corrupti. Sit omnis doloremque recusandae repellat. Quae alias recusandae est tempore impedit voluptas in enim. Veritatis aut accusamus omnis. In in molestiae id voluptas in.", new DateTime(2023, 6, 9, 20, 14, 7, 249, DateTimeKind.Utc).AddTicks(3294), 9L, "Doloremque in aut animi illum cumque dolorem iusto asperiores eaque.", 1, 3 },
                    { 111L, 30L, "qui", new DateTime(2021, 7, 27, 19, 10, 31, 624, DateTimeKind.Utc).AddTicks(8303), 25L, "Harum nihil modi repellendus voluptatem aut ut officiis eos debitis.", 2, 2 },
                    { 112L, 34L, "Deleniti perferendis possimus. Officiis dicta commodi quod. Eveniet cum enim. Consequatur quis enim quam et blanditiis et asperiores. Consequatur perferendis quisquam hic magnam sit consequuntur hic unde.", new DateTime(2023, 3, 25, 5, 1, 37, 284, DateTimeKind.Utc).AddTicks(137), 30L, "Eum exercitationem recusandae repudiandae possimus aut id adipisci sequi nihil.", 4, 3 },
                    { 113L, 55L, "Ipsam et id dolorum sint velit et.\nFacilis quod esse et quo sit et inventore.", new DateTime(2023, 8, 3, 21, 7, 21, 977, DateTimeKind.Utc).AddTicks(2280), 36L, "Quis qui provident quod eos autem qui aliquam.", 2, 3 },
                    { 114L, 28L, "Aut omnis sed necessitatibus est et.\nNon molestiae iure architecto.\nArchitecto atque delectus officiis aut optio natus cupiditate ipsam.\nDeleniti est sit.\nNesciunt ex id unde mollitia et quia quia tempore voluptatibus.\nDoloremque amet ipsam velit nulla.", new DateTime(2021, 12, 25, 5, 26, 51, 580, DateTimeKind.Utc).AddTicks(228), 5L, "Error magni quasi et.", 2, 3 },
                    { 115L, 56L, "Impedit nobis impedit pariatur est.", new DateTime(2023, 6, 21, 10, 47, 27, 199, DateTimeKind.Utc).AddTicks(7244), 22L, "Animi quaerat ut modi rerum sit magni non.", 2, 0 },
                    { 116L, 34L, "veritatis", new DateTime(2023, 4, 21, 6, 31, 45, 20, DateTimeKind.Utc).AddTicks(4893), 14L, "Voluptatibus in omnis molestias et fugit rem dolorum sunt.", 2, 3 },
                    { 117L, 48L, "Est natus labore quae mollitia qui sunt. Eos et nobis corrupti porro cumque eius distinctio. Amet quia facilis quis modi. Ut explicabo quam.", new DateTime(2021, 9, 21, 14, 40, 24, 476, DateTimeKind.Utc).AddTicks(9381), 3L, "Sapiente debitis beatae quod nihil.", 1, 3 },
                    { 118L, 37L, "Dolorum qui expedita autem expedita quaerat expedita esse.", new DateTime(2021, 3, 19, 12, 51, 42, 407, DateTimeKind.Utc).AddTicks(890), 28L, "Blanditiis consequatur quidem omnis incidunt sunt dolores odio.", 2, 2 },
                    { 119L, 38L, "Inventore aperiam impedit et libero. Quod eligendi rerum voluptatem mollitia id. Est ullam voluptas hic sit quis rerum voluptas repellat est. Magnam vitae voluptatem et ipsam veritatis deserunt omnis dolorem. Animi omnis hic adipisci maiores maiores eligendi dolorem quod. Et dolor sint commodi expedita esse molestiae.", new DateTime(2017, 12, 31, 10, 21, 43, 858, DateTimeKind.Utc).AddTicks(2594), 23L, "Totam ut tenetur dolor autem ut.", 4, 0 },
                    { 120L, 67L, "Natus illum omnis ratione aut sed illum possimus doloremque.", new DateTime(2023, 7, 24, 15, 14, 38, 338, DateTimeKind.Utc).AddTicks(259), 11L, "Repudiandae vel qui dolorem quia.", 2, 3 },
                    { 121L, 27L, "Ut tempore ut ut et aperiam vel ea. Similique ducimus et ut et consequatur consequatur aliquid sed. Libero at sequi quia harum aut perferendis. Nisi sit ut dolorem rem sit at culpa. Repudiandae rem eaque.", new DateTime(2022, 2, 23, 5, 24, 54, 308, DateTimeKind.Utc).AddTicks(5230), 23L, "Rem similique ut a.", 4, 2 },
                    { 122L, 35L, "At vitae laudantium animi minus atque exercitationem aperiam iure iste. Reiciendis id sed eius ut blanditiis. Vitae vel exercitationem incidunt officia eum ratione totam id commodi. Illum porro voluptas dolorem numquam repellat et rerum ipsam id.", new DateTime(2022, 10, 13, 17, 23, 22, 548, DateTimeKind.Utc).AddTicks(7950), 10L, "Suscipit ad autem laudantium velit unde.", 3, 1 },
                    { 123L, 48L, "Blanditiis ut maxime recusandae sequi similique quo beatae.\nOccaecati sed quisquam quaerat eos qui cupiditate voluptas hic.\nIn at harum officiis in quia enim architecto ab similique.\nPerspiciatis autem consequatur consequatur eos rem consequatur iste.", new DateTime(2022, 11, 6, 17, 37, 55, 487, DateTimeKind.Utc).AddTicks(2151), 36L, "Excepturi mollitia nesciunt nesciunt error maxime libero possimus quos tempore.", 1, 0 },
                    { 124L, 7L, "Neque quisquam harum sint.\nQui reprehenderit dolorem qui voluptas quos temporibus excepturi magni.\nQuod porro aliquam minima libero porro est voluptas ipsam in.\nNon quibusdam sed assumenda consequatur rem occaecati suscipit sint qui.", new DateTime(2022, 7, 29, 19, 21, 30, 477, DateTimeKind.Utc).AddTicks(7044), 2L, "Ipsa iusto corporis.", 3, 0 },
                    { 125L, 13L, "Vero sint reprehenderit a voluptatem.\nDolorem necessitatibus mollitia harum a fugiat voluptatem.", new DateTime(2023, 8, 21, 3, 48, 7, 180, DateTimeKind.Utc).AddTicks(248), 7L, "Eum nisi dolor iure iure similique aspernatur corporis.", 2, 2 },
                    { 126L, 7L, "Incidunt quae a ratione nam illum quia eos.\nSimilique qui voluptatem atque consequatur accusamus.\nNesciunt sed non tenetur earum corporis sunt.", new DateTime(2023, 1, 1, 10, 22, 35, 360, DateTimeKind.Utc).AddTicks(8978), 18L, "Aperiam labore officia architecto rerum quam dolores perferendis.", 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[,]
                {
                    { 127L, 66L, "Ea dolores nostrum sunt veritatis quidem dicta. Et architecto repudiandae. Saepe ea voluptate possimus molestiae a earum veritatis qui autem. Voluptas et et eos dolorum qui id a. Veniam sint at blanditiis est minus doloremque vel. Nesciunt quis quis fuga sed est eveniet sed qui voluptatum.", new DateTime(2023, 8, 7, 10, 2, 58, 983, DateTimeKind.Utc).AddTicks(3966), 9L, "Sit quas aliquam non eveniet in voluptates.", 4, 3 },
                    { 128L, 22L, "Hic odit adipisci non natus veritatis labore.\nCorporis cumque ipsa.\nEt quas odio magni consequatur optio.", new DateTime(2023, 7, 13, 8, 9, 59, 968, DateTimeKind.Utc).AddTicks(7840), 26L, "Delectus voluptas repellat dolores laudantium cupiditate praesentium sed veniam.", 2, 3 },
                    { 129L, 68L, "Incidunt reprehenderit ipsum eaque minima voluptatem autem.", new DateTime(2022, 10, 7, 18, 7, 53, 721, DateTimeKind.Utc).AddTicks(4314), 21L, "Doloremque rerum provident harum voluptates aliquam.", 4, 3 },
                    { 130L, 5L, "qui", new DateTime(2023, 4, 3, 2, 19, 46, 165, DateTimeKind.Utc).AddTicks(8336), 13L, "Ut aliquam sapiente dicta sit.", 1, 2 },
                    { 131L, 23L, "At voluptatibus quia porro nisi necessitatibus. Quam fugit quos. Similique unde culpa qui possimus minima dolorem facere. Laborum corrupti consequuntur optio modi commodi necessitatibus totam et.", new DateTime(2023, 8, 6, 22, 41, 0, 264, DateTimeKind.Utc).AddTicks(1862), 26L, "Eveniet cum non id sunt ab ea provident modi.", 4, 1 },
                    { 132L, 4L, "cum", new DateTime(2022, 11, 2, 8, 3, 10, 680, DateTimeKind.Utc).AddTicks(8538), 3L, "Magni voluptatem molestias quisquam placeat consectetur.", 2, 3 },
                    { 133L, 11L, "Excepturi ea quia tempora earum eos aut perferendis. Est dignissimos alias nam est vel. Est voluptatem enim vel error corporis et quaerat.", new DateTime(2022, 5, 7, 18, 41, 5, 493, DateTimeKind.Utc).AddTicks(5433), 5L, "Animi aliquam inventore aspernatur deleniti repellendus commodi at fuga dolores.", 2, 3 },
                    { 134L, 63L, "consectetur", new DateTime(2023, 5, 18, 21, 46, 23, 663, DateTimeKind.Utc).AddTicks(6198), 20L, "Perferendis quod placeat sed quos ipsam ut qui.", 2, 0 },
                    { 135L, 47L, "aut", new DateTime(2022, 9, 24, 15, 26, 28, 302, DateTimeKind.Utc).AddTicks(1732), 4L, "Vel dolor omnis.", 1, 2 },
                    { 136L, 9L, "Fugit dolores atque eum.", new DateTime(2020, 3, 1, 6, 36, 29, 672, DateTimeKind.Utc).AddTicks(1327), 27L, "Sint et temporibus sapiente doloribus quod at possimus cumque.", 1, 3 },
                    { 137L, 39L, "Nam omnis quasi consequuntur.\nVeniam blanditiis voluptatem ut incidunt incidunt.\nVoluptatem magnam est repudiandae voluptas nobis.\nIllo est ratione.", new DateTime(2019, 11, 7, 5, 58, 15, 117, DateTimeKind.Utc).AddTicks(343), 17L, "Facilis quia suscipit.", 4, 2 },
                    { 138L, 3L, "nobis", new DateTime(2023, 1, 25, 19, 30, 51, 879, DateTimeKind.Utc).AddTicks(6898), 38L, "Enim quo qui et molestiae animi consectetur voluptatibus et.", 4, 0 },
                    { 139L, 9L, "Voluptatum voluptatem enim laborum quae consectetur dolor.\nDoloribus unde veritatis quod veniam porro repellat ut perferendis atque.\nVoluptatibus nam explicabo saepe.\nUnde perspiciatis ut.\nOfficia sint fugit tempore velit aut est nam natus.", new DateTime(2023, 3, 23, 23, 49, 1, 148, DateTimeKind.Utc).AddTicks(3540), 10L, "Iste cupiditate earum exercitationem qui consequatur et expedita molestias corrupti.", 2, 2 },
                    { 140L, 9L, "Exercitationem quibusdam at.", new DateTime(2021, 6, 29, 7, 44, 24, 562, DateTimeKind.Utc).AddTicks(9155), 3L, "Reiciendis aut omnis ducimus est et quam.", 2, 0 },
                    { 141L, 18L, "Atque facere omnis non sint.\nAsperiores explicabo optio voluptatem.\nNihil odit autem in.\nVoluptatem sed ea commodi dolorum.", new DateTime(2023, 5, 2, 14, 58, 22, 417, DateTimeKind.Utc).AddTicks(4058), 20L, "Reiciendis qui quasi iusto reprehenderit ut ipsum quasi suscipit.", 4, 2 },
                    { 142L, 25L, "Sunt at non.\nQuasi voluptate ratione.\nTempora est voluptas perferendis eos repudiandae aut et enim.\nQuod deserunt et aliquam.\nAutem cumque voluptatibus.\nSed fugiat quam sint laudantium error ex dolorem voluptate.", new DateTime(2023, 6, 29, 1, 15, 4, 665, DateTimeKind.Utc).AddTicks(9415), 9L, "Aut ad culpa ipsam placeat et.", 2, 1 },
                    { 143L, 23L, "Soluta ut eius perspiciatis quo qui. Nemo sunt officia accusantium repellat aut magni et qui. Placeat qui voluptatum sapiente recusandae provident voluptas vitae ut. Neque tempora aut blanditiis. Quia maiores fugiat natus nisi.", new DateTime(2023, 7, 3, 22, 17, 46, 160, DateTimeKind.Utc).AddTicks(4247), 20L, "Veniam nulla numquam rem accusamus commodi.", 4, 2 },
                    { 144L, 49L, "Dicta laborum eum.\nRem placeat quis.\nLaudantium accusamus harum libero beatae reiciendis.", new DateTime(2023, 3, 15, 14, 49, 50, 392, DateTimeKind.Utc).AddTicks(5929), 33L, "Dolorum quisquam nihil voluptatum.", 1, 2 },
                    { 145L, 27L, "Quia expedita dolores voluptatum illum quia accusantium nulla a quis. Dicta consectetur delectus ut blanditiis a dolorem. Modi corrupti aperiam facere et quam ipsa repudiandae aut amet. Ab omnis perferendis praesentium aliquam aut autem. At officiis hic nostrum.", new DateTime(2021, 7, 6, 3, 7, 14, 546, DateTimeKind.Utc).AddTicks(8823), 9L, "Odit aut nihil aut maiores.", 3, 1 },
                    { 146L, 6L, "Dicta et voluptas illo est nostrum. Expedita eum labore a architecto qui impedit ut vitae et. Dicta enim velit nemo consequatur nisi non non est corrupti. Qui rerum deserunt quas. Ipsum ut provident.", new DateTime(2023, 8, 20, 16, 16, 20, 74, DateTimeKind.Utc).AddTicks(1345), 2L, "Fuga delectus nulla neque.", 1, 2 },
                    { 147L, 14L, "aut", new DateTime(2022, 5, 12, 18, 49, 43, 46, DateTimeKind.Utc).AddTicks(3331), 10L, "Qui aliquid eos eum et.", 1, 3 },
                    { 148L, 40L, "Optio ut rerum omnis cumque necessitatibus quas.", new DateTime(2023, 8, 16, 17, 51, 33, 856, DateTimeKind.Utc).AddTicks(85), 9L, "Sed dolores nulla nulla occaecati molestiae et et aliquid.", 1, 3 },
                    { 149L, 5L, "Optio quisquam ut consequatur reprehenderit commodi eaque aliquam.", new DateTime(2023, 6, 8, 14, 59, 49, 188, DateTimeKind.Utc).AddTicks(8092), 9L, "Perspiciatis laboriosam ea.", 1, 2 },
                    { 150L, 23L, "nam", new DateTime(2023, 7, 17, 15, 10, 54, 915, DateTimeKind.Utc).AddTicks(6928), 31L, "Maiores similique est saepe dignissimos sit ut ullam consequatur.", 4, 2 },
                    { 151L, 62L, "Ratione minima excepturi dignissimos expedita dignissimos fuga commodi enim et.\nQuas vero ducimus.\nConsequatur laboriosam in ex ut qui culpa quae provident deleniti.", new DateTime(2023, 1, 7, 9, 17, 21, 546, DateTimeKind.Utc).AddTicks(9976), 5L, "Accusantium explicabo delectus expedita.", 4, 2 },
                    { 152L, 45L, "illum", new DateTime(2022, 1, 31, 20, 34, 3, 553, DateTimeKind.Utc).AddTicks(7259), 16L, "Nisi ut et maxime.", 4, 3 },
                    { 153L, 35L, "Aperiam maxime similique incidunt voluptatibus.\nEst error ipsa quaerat perspiciatis ullam nam ut inventore nihil.\nAmet iusto possimus iusto necessitatibus nulla aperiam dolorem aperiam.", new DateTime(2022, 10, 15, 9, 47, 18, 581, DateTimeKind.Utc).AddTicks(9721), 21L, "Aut dolores enim dignissimos minus et sunt.", 1, 0 },
                    { 154L, 59L, "quia", new DateTime(2022, 8, 8, 15, 1, 44, 809, DateTimeKind.Utc).AddTicks(6735), 37L, "Debitis inventore ut.", 4, 3 },
                    { 155L, 60L, "Enim ut consectetur.", new DateTime(2022, 9, 28, 17, 42, 20, 310, DateTimeKind.Utc).AddTicks(9462), 36L, "Ipsa repellat qui fugiat aperiam.", 3, 0 },
                    { 156L, 25L, "Labore ducimus quam est alias alias non.", new DateTime(2023, 1, 31, 13, 13, 15, 132, DateTimeKind.Utc).AddTicks(1988), 34L, "Rerum facere ut.", 4, 1 },
                    { 157L, 27L, "fugit", new DateTime(2021, 8, 11, 0, 41, 55, 144, DateTimeKind.Utc).AddTicks(8580), 4L, "Et eaque culpa sed quia aspernatur sed.", 4, 0 },
                    { 158L, 28L, "tempora", new DateTime(2021, 12, 4, 20, 2, 19, 443, DateTimeKind.Utc).AddTicks(587), 17L, "Accusamus saepe consectetur soluta rerum vel aut omnis.", 1, 2 },
                    { 159L, 9L, "exercitationem", new DateTime(2021, 1, 21, 11, 18, 26, 965, DateTimeKind.Utc).AddTicks(2223), 2L, "Distinctio omnis officia aspernatur dolores atque maxime in.", 2, 2 },
                    { 160L, 28L, "Eos quo dolorum eum error non porro molestiae et inventore.", new DateTime(2021, 11, 23, 23, 29, 24, 191, DateTimeKind.Utc).AddTicks(9361), 25L, "Nulla rerum maiores blanditiis nemo nesciunt magni maxime repellat corrupti.", 1, 0 },
                    { 161L, 8L, "Iure quas est.", new DateTime(2023, 4, 12, 11, 2, 14, 395, DateTimeKind.Utc).AddTicks(805), 3L, "Provident soluta perferendis quia dolorem consequuntur perspiciatis et.", 4, 0 },
                    { 162L, 49L, "Quod animi nemo optio laborum voluptatum non ipsam rem. Voluptatem perferendis ipsum alias ea. Dolorem non dolor expedita tenetur eos. Vel quia quia reiciendis vitae.", new DateTime(2023, 6, 20, 7, 11, 44, 330, DateTimeKind.Utc).AddTicks(4795), 35L, "Nihil tempore ducimus natus voluptas voluptas.", 1, 3 },
                    { 163L, 3L, "Aliquam libero ipsa explicabo et fugit. Facere fugiat animi ad. Occaecati quos dolores consequuntur adipisci repellendus et ullam exercitationem esse. In cum magni voluptatem. Voluptatem dolorem animi unde voluptas facere et.", new DateTime(2023, 6, 16, 9, 9, 3, 284, DateTimeKind.Utc).AddTicks(5578), 8L, "Debitis dolorem temporibus eligendi necessitatibus ipsum quidem repellendus sed.", 2, 0 },
                    { 164L, 41L, "Enim ipsam magni voluptas ut laudantium quam consequatur quibusdam.\nQui libero repellat est neque assumenda et.\nDicta ipsum mollitia qui.\nVoluptas dolores at accusantium consequatur a et itaque.", new DateTime(2021, 3, 31, 9, 48, 13, 231, DateTimeKind.Utc).AddTicks(8893), 12L, "Delectus sint ad omnis et quia in tempore.", 3, 3 },
                    { 165L, 58L, "magnam", new DateTime(2023, 5, 7, 0, 40, 5, 161, DateTimeKind.Utc).AddTicks(745), 17L, "Accusantium voluptas in id qui aut beatae.", 2, 2 },
                    { 166L, 51L, "Odio laborum voluptate officiis rerum numquam sunt voluptatem.", new DateTime(2022, 9, 5, 20, 23, 41, 485, DateTimeKind.Utc).AddTicks(3197), 25L, "Quam quam nesciunt ducimus tempore aut.", 2, 0 },
                    { 167L, 11L, "odit", new DateTime(2022, 2, 20, 7, 29, 59, 449, DateTimeKind.Utc).AddTicks(6801), 4L, "Error omnis itaque error sunt et in.", 3, 1 },
                    { 168L, 12L, "iusto", new DateTime(2023, 8, 21, 21, 51, 58, 464, DateTimeKind.Utc).AddTicks(3293), 16L, "Eum est illum nobis beatae eos asperiores velit.", 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[,]
                {
                    { 169L, 5L, "Aspernatur aut ut quas vero est sit quia.\nBlanditiis dolorum rerum voluptas sint ut autem similique consequatur non.", new DateTime(2023, 7, 12, 3, 2, 57, 472, DateTimeKind.Utc).AddTicks(5375), 19L, "Ipsum inventore et vero vel.", 1, 0 },
                    { 170L, 23L, "corporis", new DateTime(2023, 8, 1, 16, 10, 17, 707, DateTimeKind.Utc).AddTicks(4282), 5L, "Nostrum reiciendis in.", 2, 2 },
                    { 171L, 55L, "Provident quis perferendis culpa voluptatibus facilis perferendis expedita. Eum error placeat repellendus recusandae harum. Ullam veniam tempora sit. Rem beatae vel facilis officiis ipsum.", new DateTime(2023, 7, 19, 17, 21, 25, 512, DateTimeKind.Utc).AddTicks(2011), 4L, "Ut quos omnis veniam magnam eveniet incidunt libero possimus ipsa.", 4, 0 },
                    { 172L, 32L, "Odit doloribus provident totam sapiente animi.", new DateTime(2023, 8, 17, 10, 4, 5, 485, DateTimeKind.Utc).AddTicks(5541), 29L, "Nobis et perferendis exercitationem id soluta blanditiis sunt.", 3, 3 },
                    { 173L, 8L, "Officiis suscipit nemo sed.", new DateTime(2023, 5, 28, 16, 29, 45, 215, DateTimeKind.Utc).AddTicks(4192), 25L, "Inventore non sed recusandae odit.", 1, 1 },
                    { 174L, 18L, "voluptate", new DateTime(2023, 3, 8, 8, 15, 16, 591, DateTimeKind.Utc).AddTicks(8437), 25L, "Id est omnis quasi aut ut qui.", 1, 1 },
                    { 175L, 48L, "Neque quibusdam temporibus quas commodi soluta.", new DateTime(2023, 6, 18, 10, 16, 29, 381, DateTimeKind.Utc).AddTicks(2447), 7L, "Quibusdam aliquid mollitia aut explicabo aut sunt reiciendis.", 4, 3 },
                    { 176L, 57L, "Et est porro doloribus perspiciatis. Facere nobis vel possimus. Doloremque autem aliquid harum consequatur quia aperiam est ipsa. Enim officia quisquam nesciunt qui harum dicta. Error quo voluptatibus officiis impedit quas dolorem.", new DateTime(2021, 9, 26, 14, 55, 25, 977, DateTimeKind.Utc).AddTicks(59), 11L, "Ut dicta labore vel.", 2, 0 },
                    { 177L, 45L, "expedita", new DateTime(2023, 4, 8, 15, 50, 56, 614, DateTimeKind.Utc).AddTicks(6427), 40L, "Dolorem sint dolores consequuntur eos vel harum ad et ut.", 3, 0 },
                    { 178L, 62L, "Temporibus sit et non odit. Qui aperiam officia illum qui ut et consequatur. Eius delectus accusamus aut ducimus aut et tempore rerum. Sint debitis ea delectus inventore delectus eum voluptates cumque.", new DateTime(2022, 7, 27, 7, 49, 24, 496, DateTimeKind.Utc).AddTicks(1530), 9L, "Animi libero dolor dolore ipsa omnis nesciunt vitae pariatur.", 3, 0 },
                    { 179L, 59L, "Consequatur earum sed voluptatibus repellat sint reprehenderit ea. Atque impedit amet quibusdam modi et non at. Voluptas et consequatur rerum asperiores placeat laboriosam. Aperiam dolor sed saepe qui debitis. Velit aliquid accusantium itaque.", new DateTime(2022, 5, 4, 23, 25, 58, 131, DateTimeKind.Utc).AddTicks(2066), 13L, "Velit quibusdam tempora dolor numquam.", 4, 3 },
                    { 180L, 65L, "minus", new DateTime(2023, 5, 1, 12, 22, 51, 227, DateTimeKind.Utc).AddTicks(2013), 25L, "Id quas nisi iste.", 3, 2 },
                    { 181L, 18L, "Mollitia accusamus eaque. Accusamus temporibus suscipit quos laborum nam aliquam. Asperiores ut nulla dignissimos. Delectus dolores voluptatem eius suscipit incidunt beatae. Nisi quis odit explicabo ipsa blanditiis voluptatibus. Voluptas a voluptatem eligendi odit veritatis aut ad.", new DateTime(2023, 1, 20, 20, 23, 6, 735, DateTimeKind.Utc).AddTicks(5907), 28L, "Quia hic quis facilis perspiciatis aut numquam sequi voluptas.", 2, 1 },
                    { 182L, 40L, "Sapiente voluptatem cupiditate quas incidunt in sunt quia.", new DateTime(2022, 6, 14, 14, 24, 34, 879, DateTimeKind.Utc).AddTicks(7104), 38L, "Rerum eaque assumenda et et fuga similique quibusdam.", 2, 2 },
                    { 183L, 3L, "Quia iure et.\nAut provident cumque soluta qui.\nSed corporis quae.\nSoluta magnam quam.\nMaiores cumque molestias sit quaerat eveniet exercitationem.", new DateTime(2023, 5, 25, 20, 19, 21, 96, DateTimeKind.Utc).AddTicks(9410), 35L, "Qui ut voluptas maiores omnis dicta est eum odio.", 3, 0 },
                    { 184L, 2L, "Labore pariatur voluptatem nemo.", new DateTime(2022, 12, 29, 14, 36, 32, 669, DateTimeKind.Utc).AddTicks(3035), 29L, "Fugiat vero nesciunt architecto sit omnis repudiandae.", 2, 3 },
                    { 185L, 64L, "Dolores non vel sequi quas cumque dignissimos. Voluptatibus et cumque molestias sunt pariatur praesentium distinctio asperiores hic. Enim facilis suscipit assumenda nisi laborum optio.", new DateTime(2022, 3, 17, 3, 32, 33, 992, DateTimeKind.Utc).AddTicks(8850), 31L, "Sapiente aut impedit rerum error nemo magni.", 1, 2 },
                    { 186L, 58L, "quisquam", new DateTime(2023, 6, 16, 21, 15, 15, 958, DateTimeKind.Utc).AddTicks(7247), 32L, "At hic quidem quo aperiam accusamus aut nam culpa.", 4, 1 },
                    { 187L, 38L, "omnis", new DateTime(2020, 10, 27, 13, 23, 4, 154, DateTimeKind.Utc).AddTicks(8588), 24L, "Ut enim sit modi temporibus debitis.", 2, 3 },
                    { 188L, 9L, "placeat", new DateTime(2022, 4, 22, 11, 9, 35, 857, DateTimeKind.Utc).AddTicks(9249), 35L, "Numquam ducimus ut expedita eos.", 3, 0 },
                    { 189L, 41L, "Sunt veritatis architecto voluptatum tenetur error voluptas repellat dicta.\nPossimus quas blanditiis.\nEt et facilis id ad amet eaque ea aspernatur veniam.\nEveniet rerum eum ut ipsam aut animi.", new DateTime(2019, 8, 10, 13, 0, 55, 757, DateTimeKind.Utc).AddTicks(4838), 24L, "Laborum eos cupiditate nesciunt et ut molestiae.", 4, 1 },
                    { 190L, 68L, "Ex magnam dolorum eligendi quam enim eum.", new DateTime(2022, 7, 8, 14, 5, 27, 509, DateTimeKind.Utc).AddTicks(2982), 38L, "Quibusdam veritatis et voluptatem omnis rerum fugiat aut.", 1, 3 },
                    { 191L, 52L, "Et earum non iure necessitatibus culpa praesentium.\nOdio quos nisi accusantium et eligendi.\nSit corrupti placeat fugit harum minima.", new DateTime(2023, 3, 22, 23, 48, 1, 796, DateTimeKind.Utc).AddTicks(9623), 35L, "Earum explicabo est hic sequi placeat debitis.", 4, 1 },
                    { 192L, 69L, "Nam quo facere quia.\nEarum harum quas laboriosam corrupti natus ad sint dignissimos beatae.", new DateTime(2023, 5, 25, 19, 3, 40, 931, DateTimeKind.Utc).AddTicks(1741), 6L, "Eligendi soluta commodi.", 3, 1 },
                    { 193L, 70L, "Delectus sit officiis. Voluptatibus et aut animi consequatur atque magni earum quia dolor. Itaque laborum non voluptatem. Aut in provident culpa ex dolorum omnis odio. Aut inventore id similique velit. Rerum ipsa blanditiis aspernatur rerum repellat distinctio.", new DateTime(2023, 8, 3, 7, 25, 48, 624, DateTimeKind.Utc).AddTicks(8310), 15L, "Nemo explicabo velit assumenda non fugiat sunt.", 2, 1 },
                    { 194L, 52L, "Aut error quibusdam.\nEt ea aspernatur sed dolore.\nNihil reprehenderit autem repudiandae qui modi eveniet nesciunt.\nVoluptatem quo odio vitae ut eos doloribus pariatur sed.\nVoluptas necessitatibus velit quia molestias iusto doloremque ratione placeat.", new DateTime(2023, 5, 20, 10, 31, 58, 621, DateTimeKind.Utc).AddTicks(3038), 19L, "Animi deserunt eius.", 4, 3 },
                    { 195L, 25L, "illum", new DateTime(2023, 3, 13, 5, 30, 57, 628, DateTimeKind.Utc).AddTicks(9920), 20L, "Sunt ab doloribus vero iusto autem eligendi.", 2, 2 },
                    { 196L, 18L, "Aut enim et voluptatum omnis beatae ratione suscipit explicabo.", new DateTime(2023, 8, 15, 11, 38, 54, 766, DateTimeKind.Utc).AddTicks(77), 19L, "Rerum excepturi error optio.", 2, 0 },
                    { 197L, 64L, "Eum mollitia assumenda.", new DateTime(2023, 1, 8, 19, 53, 26, 569, DateTimeKind.Utc).AddTicks(2677), 36L, "Alias doloribus aspernatur.", 1, 2 },
                    { 198L, 12L, "Consequuntur vel rerum ullam unde qui est debitis aspernatur. Voluptatem nostrum quasi quidem occaecati totam labore. Reiciendis esse quas impedit sunt alias. Natus voluptatem accusamus aliquam. Sunt est voluptate enim debitis est.", new DateTime(2023, 8, 7, 15, 28, 0, 216, DateTimeKind.Utc).AddTicks(1727), 5L, "Modi modi omnis recusandae.", 1, 2 },
                    { 199L, 43L, "Esse consequatur aut odit maiores. At dolorum laborum esse quis rerum omnis. Voluptates aliquam architecto rerum debitis perspiciatis laborum et dolor.", new DateTime(2023, 7, 17, 2, 37, 16, 261, DateTimeKind.Utc).AddTicks(5102), 25L, "Inventore qui non deserunt occaecati unde cumque facere cupiditate cupiditate.", 2, 0 },
                    { 200L, 32L, "Sed cupiditate sit.", new DateTime(2023, 7, 30, 19, 17, 20, 859, DateTimeKind.Utc).AddTicks(4669), 7L, "Delectus error vel voluptatem eaque praesentium et.", 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "IsPublic" },
                values: new object[,]
                {
                    { 1L, 14L, "Fuga molestiae laborum architecto minus aut quisquam explicabo corporis.\nVeniam omnis et dolores temporibus voluptatem ea.\nIste odio quis delectus.\nDeleniti qui et consequatur.\nMinus illo quibusdam distinctio cumque nihil voluptate occaecati molestiae fuga.\nEx eos quibusdam ipsa nobis veritatis hic eaque.", new DateTime(2023, 8, 21, 17, 59, 7, 108, DateTimeKind.Utc).AddTicks(5168), 30L, false },
                    { 2L, 90L, "odit", new DateTime(2023, 3, 6, 13, 55, 1, 457, DateTimeKind.Utc).AddTicks(3552), 27L, true },
                    { 3L, 173L, "soluta", new DateTime(2023, 6, 29, 4, 28, 33, 716, DateTimeKind.Utc).AddTicks(4191), 29L, false },
                    { 4L, 125L, "dolorem", new DateTime(2023, 8, 21, 8, 54, 12, 305, DateTimeKind.Utc).AddTicks(8530), 32L, true },
                    { 5L, 185L, "Id quam velit corporis sunt.", new DateTime(2022, 11, 5, 2, 31, 18, 541, DateTimeKind.Utc).AddTicks(9693), 17L, true },
                    { 6L, 47L, "Repellat neque temporibus iste magnam. Placeat sit temporibus rerum aut. Esse iusto autem vero odio necessitatibus et. Voluptatum in nesciunt officia voluptates ratione quo id harum quo.", new DateTime(2023, 1, 14, 7, 8, 21, 138, DateTimeKind.Utc).AddTicks(1956), 18L, true },
                    { 7L, 100L, "Eaque et consequatur.", new DateTime(2023, 8, 5, 22, 52, 25, 615, DateTimeKind.Utc).AddTicks(6908), 38L, true },
                    { 8L, 10L, "Rerum dolores consequuntur cumque reiciendis iste qui. Omnis animi alias sed facilis. Blanditiis perferendis cumque. Quo nulla consectetur. Quasi impedit qui quis vitae maxime quidem ut pariatur quis.", new DateTime(2023, 7, 9, 9, 0, 28, 847, DateTimeKind.Utc).AddTicks(8781), 11L, true },
                    { 9L, 61L, "Soluta ducimus odit est assumenda vitae quo quam.\nIpsa voluptas ut rem architecto eligendi eum itaque.\nQuam debitis id.\nVoluptas est labore placeat harum voluptatem.\nPariatur facere ea assumenda laboriosam.\nQui dicta voluptatem.", new DateTime(2023, 8, 11, 13, 19, 41, 399, DateTimeKind.Utc).AddTicks(7253), 40L, true },
                    { 10L, 39L, "Nemo corporis vel exercitationem ea hic quia quidem.", new DateTime(2022, 5, 12, 3, 0, 25, 832, DateTimeKind.Utc).AddTicks(2587), 6L, true },
                    { 11L, 42L, "Sit qui nobis aut at nostrum.\nTotam magni ipsa exercitationem ullam tempore voluptas autem saepe expedita.\nEos vel itaque.\nLaboriosam autem commodi non sed.", new DateTime(2023, 6, 20, 23, 24, 5, 979, DateTimeKind.Utc).AddTicks(2044), 9L, false },
                    { 12L, 115L, "Veniam quia corporis voluptas cupiditate velit eum quo dolore. Veritatis et est officiis in. Voluptatum aut totam aperiam. Est fugit necessitatibus maxime voluptas quia porro. Et eius quas fuga vero deleniti dolorum deserunt vel.", new DateTime(2023, 6, 27, 19, 23, 26, 231, DateTimeKind.Utc).AddTicks(9981), 40L, false },
                    { 13L, 147L, "dicta", new DateTime(2022, 9, 3, 19, 7, 6, 26, DateTimeKind.Utc).AddTicks(1874), 36L, false },
                    { 14L, 181L, "Quo voluptatem rerum corporis quidem veritatis velit explicabo. Labore nam vitae voluptas. Iste accusantium temporibus. Omnis similique distinctio ut quod aperiam. Cupiditate accusantium nesciunt aperiam ducimus non.", new DateTime(2023, 5, 9, 3, 58, 20, 667, DateTimeKind.Utc).AddTicks(2308), 8L, true },
                    { 15L, 112L, "maiores", new DateTime(2023, 4, 21, 11, 33, 43, 411, DateTimeKind.Utc).AddTicks(2753), 23L, false },
                    { 16L, 178L, "Sit sit quibusdam ab quia nobis.\nPariatur aperiam voluptatibus.\nQuia culpa id.", new DateTime(2022, 11, 3, 19, 18, 7, 268, DateTimeKind.Utc).AddTicks(4912), 2L, true },
                    { 17L, 62L, "placeat", new DateTime(2023, 7, 15, 10, 28, 23, 356, DateTimeKind.Utc).AddTicks(4261), 36L, false },
                    { 18L, 134L, "Incidunt unde eius.\nRerum dolorem magnam nihil reprehenderit qui.\nVoluptatibus ut ea beatae accusamus eius odit sit id eum.", new DateTime(2023, 8, 16, 10, 58, 25, 903, DateTimeKind.Utc).AddTicks(184), 21L, false },
                    { 19L, 101L, "Similique eos et cupiditate.\nEst vero corporis illum deserunt magni aut sit ut.\nVel veritatis enim quo iure incidunt.\nNam aperiam velit voluptas expedita error consequatur optio laudantium quis.\nEt dolores aliquam architecto qui dolor cumque.", new DateTime(2023, 5, 29, 14, 20, 0, 227, DateTimeKind.Utc).AddTicks(6583), 3L, false },
                    { 20L, 3L, "Atque ipsum ex laudantium expedita. Et tenetur cum voluptatum et quia eaque doloribus nostrum dolores. Magni voluptas rem. Assumenda et nemo est sunt.", new DateTime(2023, 7, 30, 21, 46, 12, 916, DateTimeKind.Utc).AddTicks(4854), 19L, false },
                    { 21L, 176L, "inventore", new DateTime(2022, 6, 27, 8, 9, 45, 507, DateTimeKind.Utc).AddTicks(6312), 7L, true },
                    { 22L, 92L, "Aut ut exercitationem aut.", new DateTime(2023, 6, 27, 11, 2, 25, 560, DateTimeKind.Utc).AddTicks(5648), 19L, false },
                    { 23L, 43L, "impedit", new DateTime(2023, 2, 15, 23, 24, 14, 188, DateTimeKind.Utc).AddTicks(4368), 38L, true },
                    { 24L, 2L, "pariatur", new DateTime(2022, 6, 19, 1, 20, 28, 741, DateTimeKind.Utc).AddTicks(1564), 38L, false },
                    { 25L, 48L, "Ea et quo iusto natus ducimus perspiciatis illum eveniet eaque. Voluptas dolores dolor voluptatem enim praesentium pariatur deleniti hic corporis. Quia et unde et accusantium deleniti praesentium laudantium. Autem labore esse recusandae laborum dolorum. Eveniet soluta mollitia necessitatibus ipsam.", new DateTime(2023, 7, 2, 1, 6, 34, 620, DateTimeKind.Utc).AddTicks(2340), 7L, true },
                    { 26L, 125L, "Totam velit autem et fuga est.\nNon rerum quidem quam et.\nIusto harum excepturi dicta beatae.\nUt eligendi fugit tenetur.\nAliquid velit ex itaque eos eum veniam ex fuga.\nRepellat non alias.", new DateTime(2023, 8, 21, 20, 34, 8, 49, DateTimeKind.Utc).AddTicks(6377), 10L, false },
                    { 27L, 85L, "Voluptatem provident provident aut est.\nVitae natus et voluptatem quo aliquid et.\nVoluptatem non suscipit eum quasi et aliquid.\nOdio nemo odio.", new DateTime(2023, 1, 26, 8, 29, 46, 7, DateTimeKind.Utc).AddTicks(8016), 19L, true },
                    { 28L, 181L, "Et optio sed. Aut voluptatum sit voluptas corporis est molestiae corporis nisi. Delectus molestiae ea culpa voluptates et et sapiente.", new DateTime(2023, 3, 10, 0, 22, 13, 661, DateTimeKind.Utc).AddTicks(7652), 4L, true },
                    { 29L, 15L, "Voluptatem dolorum ad et.", new DateTime(2023, 7, 11, 1, 12, 27, 797, DateTimeKind.Utc).AddTicks(2032), 28L, false },
                    { 30L, 66L, "dignissimos", new DateTime(2023, 8, 22, 13, 58, 34, 490, DateTimeKind.Utc).AddTicks(101), 3L, false },
                    { 31L, 28L, "et", new DateTime(2023, 2, 16, 7, 8, 28, 485, DateTimeKind.Utc).AddTicks(3922), 39L, true },
                    { 32L, 68L, "Aut nihil dicta.", new DateTime(2023, 5, 25, 8, 13, 24, 658, DateTimeKind.Utc).AddTicks(993), 28L, true },
                    { 33L, 128L, "Distinctio aperiam ratione corporis soluta qui quos incidunt.", new DateTime(2023, 7, 29, 10, 9, 59, 419, DateTimeKind.Utc).AddTicks(5616), 17L, false },
                    { 34L, 139L, "At officiis omnis. Inventore tenetur voluptatem est est. Occaecati similique ut minus voluptatem consequatur facere optio porro libero. Et odio occaecati dolor facilis et voluptas pariatur eaque.", new DateTime(2023, 3, 29, 21, 51, 10, 598, DateTimeKind.Utc).AddTicks(4670), 19L, true },
                    { 35L, 73L, "Non sint minima est in eum nihil.", new DateTime(2022, 10, 28, 10, 52, 54, 113, DateTimeKind.Utc).AddTicks(7904), 36L, true },
                    { 36L, 45L, "Itaque nam eligendi velit culpa.", new DateTime(2023, 8, 14, 23, 28, 50, 225, DateTimeKind.Utc).AddTicks(4843), 18L, false },
                    { 37L, 11L, "esse", new DateTime(2023, 6, 24, 4, 51, 35, 926, DateTimeKind.Utc).AddTicks(8519), 32L, false },
                    { 38L, 48L, "Aut nemo dolore aut beatae.", new DateTime(2023, 5, 9, 17, 0, 43, 183, DateTimeKind.Utc).AddTicks(4969), 38L, true },
                    { 39L, 183L, "Beatae ex exercitationem et ea aut.", new DateTime(2023, 8, 22, 17, 2, 41, 51, DateTimeKind.Utc).AddTicks(2922), 40L, true },
                    { 40L, 8L, "Beatae est quam et quisquam laudantium officia. Aut fugiat est quo magnam sint eos molestiae. Aliquam enim omnis totam ea. Aut repudiandae est molestiae rerum enim magnam laboriosam labore corrupti. Est iure qui omnis modi consequatur vero maxime. Cupiditate occaecati distinctio voluptatem quos illo rerum est id error.", new DateTime(2022, 10, 25, 5, 41, 26, 102, DateTimeKind.Utc).AddTicks(3452), 29L, true },
                    { 41L, 122L, "Sed cumque nihil.\nQuos sed ut perspiciatis autem rem id est aperiam.\nEt quisquam reprehenderit commodi veniam magnam dolores.\nFugiat commodi non id tempore ducimus.\nAlias officia quia animi ratione enim sequi voluptatem.\nAperiam maiores enim.", new DateTime(2023, 1, 28, 22, 38, 34, 608, DateTimeKind.Utc).AddTicks(4069), 24L, false },
                    { 42L, 13L, "nihil", new DateTime(2022, 6, 11, 18, 53, 54, 280, DateTimeKind.Utc).AddTicks(896), 15L, true }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "IsPublic" },
                values: new object[,]
                {
                    { 43L, 67L, "Cumque culpa aut et inventore.", new DateTime(2023, 7, 19, 19, 51, 24, 274, DateTimeKind.Utc).AddTicks(9297), 35L, false },
                    { 44L, 23L, "In quia rerum tempora voluptas in quis sit ullam earum. Minus magnam voluptatem non ut laborum sit veniam cum sequi. Ut similique ipsum quis voluptatem est qui quia velit. Repudiandae cumque earum debitis illum fugiat aliquid hic. Odit doloremque possimus. Quis et aperiam aut doloribus magnam similique fuga.", new DateTime(2023, 3, 13, 17, 46, 32, 968, DateTimeKind.Utc).AddTicks(1797), 22L, false },
                    { 45L, 38L, "Deleniti eos sint.", new DateTime(2023, 2, 8, 6, 58, 32, 47, DateTimeKind.Utc).AddTicks(3793), 22L, true },
                    { 46L, 58L, "Et vitae omnis. Suscipit quidem ab voluptas qui officiis et tempore tempora ut. Officiis nulla architecto et. Esse expedita et omnis officiis consequatur cupiditate sint vero incidunt. Omnis et tenetur voluptatem et rem qui.", new DateTime(2023, 8, 10, 7, 27, 55, 986, DateTimeKind.Utc).AddTicks(2738), 28L, true },
                    { 47L, 52L, "dignissimos", new DateTime(2022, 8, 6, 2, 56, 44, 57, DateTimeKind.Utc).AddTicks(1850), 37L, false },
                    { 48L, 137L, "corporis", new DateTime(2022, 1, 15, 1, 51, 10, 85, DateTimeKind.Utc).AddTicks(6041), 1L, true },
                    { 49L, 2L, "Alias aut cupiditate fugit magni maiores repudiandae.\nDolore est enim illum magnam.\nQuaerat repellendus quia exercitationem minus in.\nSint et eveniet.\nNecessitatibus omnis perspiciatis reprehenderit provident corrupti quis sequi voluptas rem.\nVoluptas commodi unde optio dolorem architecto.", new DateTime(2023, 4, 22, 6, 40, 32, 146, DateTimeKind.Utc).AddTicks(9600), 26L, true },
                    { 50L, 20L, "Quia eligendi veniam itaque quam occaecati. Ipsa et dolores et et consequatur. Porro quia maiores distinctio et recusandae dolor voluptatem sapiente placeat. Voluptate maiores molestias. Aliquam magnam odit et quia quasi quo quia aliquid. Aut maiores iusto dolores tempora corporis voluptatem quibusdam.", new DateTime(2023, 8, 23, 1, 48, 38, 132, DateTimeKind.Utc).AddTicks(9297), 4L, true },
                    { 51L, 194L, "eos", new DateTime(2023, 7, 29, 0, 55, 1, 857, DateTimeKind.Utc).AddTicks(220), 13L, true },
                    { 52L, 35L, "Sed aut quia.\nRerum dolores dolor dolore voluptates.\nSint quidem non fugit rerum ut rerum minus dignissimos est.\nRerum numquam autem mollitia amet dolore nobis.\nVoluptas odit tempore ducimus quisquam enim.\nQuaerat omnis nisi.", new DateTime(2023, 7, 14, 21, 37, 54, 764, DateTimeKind.Utc).AddTicks(9851), 23L, true },
                    { 53L, 60L, "Voluptatem dolores maxime voluptatem.", new DateTime(2023, 5, 13, 11, 46, 5, 967, DateTimeKind.Utc).AddTicks(9655), 40L, true },
                    { 54L, 130L, "ea", new DateTime(2023, 7, 22, 23, 12, 41, 554, DateTimeKind.Utc).AddTicks(5547), 16L, false },
                    { 55L, 51L, "Assumenda qui assumenda.\nAmet quia nulla recusandae.\nConsequuntur reprehenderit ad.\nInventore optio quibusdam et in.\nQuas distinctio dolor.\nAut qui voluptatem voluptatem dolorum.", new DateTime(2023, 8, 13, 5, 43, 52, 498, DateTimeKind.Utc).AddTicks(896), 40L, false },
                    { 56L, 180L, "Repellendus quae est sint fugiat non.", new DateTime(2023, 6, 3, 18, 58, 42, 179, DateTimeKind.Utc).AddTicks(5086), 9L, true },
                    { 57L, 31L, "Nisi tenetur delectus facere sed est eum et officia.\nDistinctio distinctio accusamus rerum tempora soluta non qui maxime.\nEveniet ad est ratione quo quod quia id sunt ut.\nQuas voluptas voluptatum.\nLibero veniam quia dolor repellat eveniet a adipisci aliquam doloribus.\nDelectus ipsa tempore voluptate repellat.", new DateTime(2023, 7, 27, 0, 26, 36, 803, DateTimeKind.Utc).AddTicks(7097), 34L, false },
                    { 58L, 164L, "corporis", new DateTime(2022, 7, 5, 12, 13, 41, 987, DateTimeKind.Utc).AddTicks(7093), 19L, true },
                    { 59L, 1L, "Id nesciunt saepe qui voluptates natus in. Ea maxime explicabo. Beatae qui nesciunt blanditiis omnis beatae non neque aut et. Earum provident et commodi laudantium vitae voluptatem rem. Aspernatur culpa occaecati. Commodi similique magni fugit aut voluptates temporibus sed minus.", new DateTime(2023, 8, 12, 2, 54, 31, 128, DateTimeKind.Utc).AddTicks(6022), 37L, false },
                    { 60L, 184L, "Pariatur optio facilis eum sint hic.\nConsequatur adipisci recusandae consequatur ipsa ad reiciendis nulla et.\nVoluptas sunt quia hic illum voluptatem veritatis sed cupiditate non.\nVoluptates blanditiis aut dolores quidem voluptatem ut.\nRecusandae eligendi ipsam velit impedit quia.", new DateTime(2023, 6, 25, 2, 35, 49, 254, DateTimeKind.Utc).AddTicks(5360), 37L, true },
                    { 61L, 197L, "Dolores aperiam suscipit dolores. Et doloremque perspiciatis culpa impedit asperiores. Suscipit explicabo id consequuntur molestias ea magnam quo. Error sit aut cum et dolorem. Architecto nesciunt consequatur soluta blanditiis consequatur esse nihil totam alias. Cupiditate ut at ex.", new DateTime(2023, 4, 3, 2, 16, 42, 556, DateTimeKind.Utc).AddTicks(6664), 27L, true },
                    { 62L, 190L, "dolor", new DateTime(2023, 3, 9, 0, 38, 49, 129, DateTimeKind.Utc).AddTicks(9552), 14L, true },
                    { 63L, 187L, "porro", new DateTime(2023, 2, 18, 6, 53, 24, 243, DateTimeKind.Utc).AddTicks(2654), 14L, false },
                    { 64L, 29L, "Rem nihil nisi ipsam. Ut cum ipsam distinctio molestias. Est voluptatum officia non. Est consequatur magni autem. Consequuntur omnis voluptatem dicta esse est atque in.", new DateTime(2023, 8, 12, 17, 44, 55, 278, DateTimeKind.Utc).AddTicks(4399), 8L, true },
                    { 65L, 186L, "eum", new DateTime(2023, 7, 13, 4, 37, 28, 81, DateTimeKind.Utc).AddTicks(8538), 1L, true },
                    { 66L, 113L, "Et nostrum rerum aut et.", new DateTime(2023, 8, 16, 14, 57, 45, 704, DateTimeKind.Utc).AddTicks(4936), 29L, true },
                    { 67L, 198L, "Aut velit ut nam voluptatem tempora accusamus voluptatem adipisci.\nSint voluptas quae debitis autem quia minima natus.\nEt est dignissimos vero fugiat officiis voluptates modi.\nCupiditate omnis molestiae molestias consequatur ut delectus eligendi eaque.\nVoluptatem dolor occaecati vitae nesciunt.\nEst natus et.", new DateTime(2023, 8, 14, 16, 35, 0, 230, DateTimeKind.Utc).AddTicks(3307), 37L, true },
                    { 68L, 40L, "tenetur", new DateTime(2023, 6, 12, 15, 19, 10, 38, DateTimeKind.Utc).AddTicks(2426), 18L, true },
                    { 69L, 151L, "Consequatur sit quibusdam iusto vel aut.\nOptio voluptates soluta dolorem perferendis et et explicabo facilis quis.\nVeritatis ipsam nulla ut distinctio animi voluptatem voluptas.\nDolorem incidunt non eos non voluptatum voluptates.\nQuas quis est enim omnis animi consequatur beatae molestias.", new DateTime(2023, 1, 18, 18, 59, 8, 994, DateTimeKind.Utc).AddTicks(7647), 34L, true },
                    { 70L, 31L, "rem", new DateTime(2022, 12, 5, 9, 28, 44, 768, DateTimeKind.Utc).AddTicks(218), 18L, false },
                    { 71L, 16L, "Velit fugit aut praesentium autem.\nEum perspiciatis rerum sed sit magni.\nEa error quam ullam porro voluptatum nesciunt.\nNulla necessitatibus repellat quas.\nPossimus autem ipsam.", new DateTime(2020, 11, 28, 11, 53, 54, 733, DateTimeKind.Utc).AddTicks(767), 14L, true },
                    { 72L, 122L, "dicta", new DateTime(2023, 6, 23, 6, 30, 5, 936, DateTimeKind.Utc).AddTicks(5917), 13L, true },
                    { 73L, 147L, "Fugit saepe excepturi et excepturi fugit deserunt ea ratione possimus. Et quia aliquid. Aut tenetur qui nihil. Tempora natus provident. Magni ducimus enim a vitae repellat voluptates sunt laudantium amet.", new DateTime(2023, 2, 9, 13, 41, 44, 112, DateTimeKind.Utc).AddTicks(5707), 20L, false },
                    { 74L, 127L, "Repudiandae non dolore quaerat iure itaque id vel commodi.\nArchitecto velit nobis id omnis.\nCupiditate temporibus et voluptas harum.\nVoluptatem nulla excepturi voluptatem voluptatem.\nIncidunt corrupti quis dolor veritatis modi ipsam.", new DateTime(2023, 8, 19, 9, 36, 37, 281, DateTimeKind.Utc).AddTicks(3200), 30L, true },
                    { 75L, 62L, "Quisquam est quo autem dolor ducimus dolor.\nSapiente autem corrupti et voluptatem mollitia dolor in.\nUt sint sed ratione officiis reiciendis saepe eos.\nQuam et quasi et quae iste.", new DateTime(2023, 7, 31, 20, 38, 59, 15, DateTimeKind.Utc).AddTicks(2022), 24L, true },
                    { 76L, 75L, "eos", new DateTime(2021, 11, 21, 4, 53, 37, 915, DateTimeKind.Utc).AddTicks(420), 18L, true },
                    { 77L, 70L, "Quaerat architecto quisquam pariatur necessitatibus reiciendis molestias deserunt.\nMolestiae pariatur tempore earum labore voluptatem.\nQuaerat similique nesciunt.\nNon quos explicabo repellat ad iure est et.", new DateTime(2023, 6, 23, 7, 41, 52, 317, DateTimeKind.Utc).AddTicks(6727), 23L, true },
                    { 78L, 37L, "Debitis eum cumque quasi.", new DateTime(2023, 6, 15, 16, 23, 26, 414, DateTimeKind.Utc).AddTicks(5084), 22L, false },
                    { 79L, 195L, "Fugiat et eveniet illo perspiciatis dolor voluptatem quis. Omnis voluptas voluptatibus quisquam sunt et consequatur facilis et. Officiis molestias ad quod ea recusandae voluptas consectetur. Suscipit sed delectus animi laudantium aliquam. Quia quo consequatur et et provident.", new DateTime(2023, 3, 31, 23, 21, 7, 4, DateTimeKind.Utc).AddTicks(5865), 18L, true },
                    { 80L, 108L, "Dolores soluta blanditiis eveniet quisquam nesciunt possimus labore natus voluptas.", new DateTime(2023, 8, 19, 22, 27, 58, 652, DateTimeKind.Utc).AddTicks(9647), 9L, true },
                    { 81L, 107L, "Autem neque sint totam magni dolor expedita fugiat.\nUt laboriosam sed impedit exercitationem dolore.", new DateTime(2023, 4, 25, 2, 31, 48, 803, DateTimeKind.Utc).AddTicks(4073), 28L, true },
                    { 82L, 66L, "Odio impedit perferendis rerum. Quia eligendi qui excepturi eveniet itaque non est hic rerum. Consequatur quas et et minima molestiae esse. Pariatur doloremque nostrum officia officiis exercitationem non voluptatem.", new DateTime(2023, 8, 22, 20, 2, 47, 601, DateTimeKind.Utc).AddTicks(6500), 29L, true },
                    { 83L, 145L, "Sit deleniti eos vero.", new DateTime(2023, 3, 4, 17, 43, 4, 156, DateTimeKind.Utc).AddTicks(6967), 24L, true },
                    { 84L, 46L, "Eum voluptas sed vitae et delectus sint nostrum.\nEaque sapiente aut odit quo.\nDelectus temporibus id aspernatur.", new DateTime(2021, 12, 23, 1, 44, 0, 254, DateTimeKind.Utc).AddTicks(5522), 3L, true }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "IsPublic" },
                values: new object[,]
                {
                    { 85L, 14L, "Molestiae nihil velit aut odit.", new DateTime(2023, 8, 22, 14, 15, 45, 212, DateTimeKind.Utc).AddTicks(2161), 40L, true },
                    { 86L, 146L, "ut", new DateTime(2023, 8, 22, 8, 40, 45, 42, DateTimeKind.Utc).AddTicks(4442), 4L, true },
                    { 87L, 29L, "occaecati", new DateTime(2023, 7, 25, 22, 50, 42, 307, DateTimeKind.Utc).AddTicks(5136), 9L, true },
                    { 88L, 103L, "qui", new DateTime(2023, 5, 6, 19, 37, 3, 982, DateTimeKind.Utc).AddTicks(4397), 33L, true },
                    { 89L, 135L, "Assumenda sed aut omnis voluptatem ut ipsam.\nQuia delectus culpa rerum neque.", new DateTime(2023, 5, 22, 5, 52, 19, 586, DateTimeKind.Utc).AddTicks(8720), 10L, true },
                    { 90L, 175L, "Iste et sint.\nQuisquam necessitatibus veniam.\nEt ullam eveniet fugiat non autem enim assumenda.\nNemo voluptas quae necessitatibus sed recusandae labore quidem porro.", new DateTime(2023, 7, 3, 18, 48, 25, 729, DateTimeKind.Utc).AddTicks(2081), 11L, true },
                    { 91L, 8L, "est", new DateTime(2023, 1, 8, 14, 29, 55, 543, DateTimeKind.Utc).AddTicks(4785), 1L, true },
                    { 92L, 158L, "Ipsa molestiae aliquam et vel et quasi maxime tenetur.", new DateTime(2022, 8, 11, 21, 45, 50, 988, DateTimeKind.Utc).AddTicks(9165), 20L, true },
                    { 93L, 85L, "Totam magni aliquid maiores cum laudantium consequatur perferendis consequatur.", new DateTime(2023, 1, 14, 6, 53, 39, 274, DateTimeKind.Utc).AddTicks(1412), 9L, true },
                    { 94L, 192L, "Quam deleniti veritatis voluptatem laboriosam. Voluptatem reprehenderit doloremque dolorem necessitatibus omnis dicta quasi autem. Tempore saepe similique sint distinctio et est voluptatem eaque. Dignissimos quia perspiciatis eligendi dolorem hic. Nihil reiciendis asperiores. Voluptatem quam cum accusamus sapiente.", new DateTime(2023, 6, 16, 15, 22, 40, 83, DateTimeKind.Utc).AddTicks(7248), 23L, true },
                    { 95L, 85L, "Iusto sed aliquid tempora delectus nihil iste accusamus. Tempora molestiae nisi inventore pariatur suscipit nisi earum. Nam explicabo quibusdam dolores cupiditate voluptatum saepe ab. Voluptates aspernatur maxime autem atque nihil in odit. Rem quisquam aut quisquam.", new DateTime(2023, 7, 31, 20, 43, 48, 73, DateTimeKind.Utc).AddTicks(2534), 24L, true },
                    { 96L, 111L, "Consequatur fugit dolorum dolorem et.", new DateTime(2023, 4, 19, 6, 43, 37, 269, DateTimeKind.Utc).AddTicks(8884), 26L, true },
                    { 97L, 49L, "Suscipit sint consequatur est est repellat et odio rerum atque. Dolor accusamus modi officia earum tempore tempore ut. Voluptatibus natus labore qui quis recusandae fugit.", new DateTime(2023, 8, 9, 11, 0, 0, 689, DateTimeKind.Utc).AddTicks(2265), 3L, true },
                    { 98L, 120L, "qui", new DateTime(2023, 8, 15, 1, 27, 42, 206, DateTimeKind.Utc).AddTicks(3007), 8L, true },
                    { 99L, 62L, "Quos illo eligendi voluptas autem odio ullam. Delectus voluptatem reiciendis nesciunt eaque velit. Omnis soluta quam ea voluptas aut consectetur eius culpa quod. Eaque enim quo ea tempora eveniet voluptatem.", new DateTime(2023, 8, 17, 10, 18, 39, 656, DateTimeKind.Utc).AddTicks(2612), 38L, true },
                    { 100L, 6L, "Harum impedit ad ut vitae culpa magni minus cumque. Quas ullam velit excepturi quo ullam fugiat. Officia et ea.", new DateTime(2022, 6, 17, 8, 59, 40, 186, DateTimeKind.Utc).AddTicks(7905), 23L, true },
                    { 101L, 146L, "quo", new DateTime(2023, 8, 23, 7, 5, 36, 755, DateTimeKind.Utc).AddTicks(6095), 39L, true },
                    { 102L, 143L, "Quia quia repudiandae voluptatem et nesciunt odio. Sunt tempora eveniet non atque. Mollitia vel sunt facere quia velit ducimus id eos.", new DateTime(2023, 8, 10, 12, 28, 59, 761, DateTimeKind.Utc).AddTicks(4684), 1L, false },
                    { 103L, 108L, "Qui optio minus sunt ut corporis.", new DateTime(2023, 4, 3, 12, 27, 22, 504, DateTimeKind.Utc).AddTicks(7595), 21L, true },
                    { 104L, 119L, "Aspernatur qui nisi nam neque.", new DateTime(2020, 9, 26, 6, 42, 41, 485, DateTimeKind.Utc).AddTicks(2552), 6L, true },
                    { 105L, 31L, "Quibusdam veritatis animi eaque sed excepturi. Esse eaque accusamus voluptas provident neque. Qui quas illo molestiae in eos saepe quae ut.", new DateTime(2023, 2, 27, 12, 30, 39, 856, DateTimeKind.Utc).AddTicks(4497), 2L, false },
                    { 106L, 101L, "Ut hic at ut quis exercitationem quo nihil.", new DateTime(2023, 2, 3, 8, 31, 48, 143, DateTimeKind.Utc).AddTicks(236), 1L, true },
                    { 107L, 47L, "quia", new DateTime(2023, 1, 28, 18, 53, 34, 528, DateTimeKind.Utc).AddTicks(9648), 33L, true },
                    { 108L, 61L, "Non beatae inventore.", new DateTime(2023, 6, 22, 10, 7, 57, 32, DateTimeKind.Utc).AddTicks(1004), 23L, true },
                    { 109L, 105L, "Sequi accusamus vitae nihil.\nSint doloribus doloribus debitis ut maxime et omnis dolore.\nVoluptatem rerum est fugit ut voluptatibus unde.\nEa amet consectetur saepe omnis.", new DateTime(2023, 2, 9, 3, 4, 45, 88, DateTimeKind.Utc).AddTicks(8285), 22L, false },
                    { 110L, 63L, "Doloremque eos aperiam nemo omnis.", new DateTime(2023, 4, 27, 5, 1, 45, 934, DateTimeKind.Utc).AddTicks(4394), 33L, true },
                    { 111L, 32L, "Cupiditate vel qui repellat libero voluptatem id et. Est omnis soluta occaecati culpa. Odio totam qui. Fuga perspiciatis exercitationem numquam iusto doloribus in quia et et.", new DateTime(2023, 3, 30, 11, 5, 21, 917, DateTimeKind.Utc).AddTicks(6081), 22L, false },
                    { 112L, 85L, "Vitae qui non quasi non sint aliquid repellat.", new DateTime(2023, 6, 22, 9, 59, 44, 517, DateTimeKind.Utc).AddTicks(6543), 15L, true },
                    { 113L, 13L, "Ex atque quibusdam rerum. Incidunt mollitia exercitationem consequatur. Pariatur aut maiores. Nobis voluptatem ut.", new DateTime(2022, 12, 17, 2, 39, 33, 651, DateTimeKind.Utc).AddTicks(5605), 38L, false },
                    { 114L, 180L, "Odit adipisci exercitationem autem pariatur quidem. Sed excepturi quod aut odio minus et ad iusto. Non occaecati reiciendis cum quo commodi.", new DateTime(2023, 8, 1, 21, 26, 32, 893, DateTimeKind.Utc).AddTicks(6341), 23L, false },
                    { 115L, 58L, "Error esse velit sit provident.\nRecusandae et dignissimos quis corporis est exercitationem et ullam dolore.", new DateTime(2023, 8, 1, 18, 7, 24, 389, DateTimeKind.Utc).AddTicks(1911), 32L, true },
                    { 116L, 80L, "Nihil explicabo temporibus.", new DateTime(2022, 9, 24, 5, 50, 6, 428, DateTimeKind.Utc).AddTicks(992), 17L, false },
                    { 117L, 101L, "Veritatis ratione neque quia reprehenderit accusantium ea ut quis.", new DateTime(2023, 2, 10, 0, 1, 54, 894, DateTimeKind.Utc).AddTicks(4925), 4L, true },
                    { 118L, 107L, "Quia animi quos minima assumenda earum.\nNecessitatibus voluptatum doloribus voluptatem ut dolores nesciunt.", new DateTime(2023, 2, 17, 19, 23, 39, 698, DateTimeKind.Utc).AddTicks(1584), 7L, false },
                    { 119L, 27L, "et", new DateTime(2023, 8, 9, 1, 21, 39, 539, DateTimeKind.Utc).AddTicks(4679), 37L, true },
                    { 120L, 185L, "Aut assumenda consequatur ad quam omnis reiciendis. Et error consequatur inventore quia sunt enim cumque. Impedit eos fugiat consequuntur aut earum.", new DateTime(2022, 12, 18, 20, 12, 25, 673, DateTimeKind.Utc).AddTicks(2837), 18L, true },
                    { 121L, 139L, "Eligendi enim qui.", new DateTime(2023, 4, 11, 5, 46, 49, 339, DateTimeKind.Utc).AddTicks(8245), 25L, true },
                    { 122L, 24L, "Ut dolor sequi qui qui dolor sequi corrupti.", new DateTime(2021, 7, 29, 0, 8, 4, 431, DateTimeKind.Utc).AddTicks(6732), 35L, false },
                    { 123L, 86L, "Labore autem alias.\nDicta cum voluptatibus incidunt eligendi est aut exercitationem est.\nSoluta ut sequi ut nobis.\nVitae cum tempore et voluptas voluptas fugit ipsam animi.", new DateTime(2023, 2, 6, 17, 37, 28, 553, DateTimeKind.Utc).AddTicks(4582), 8L, true },
                    { 124L, 110L, "Veritatis animi nostrum vel ipsa sint.", new DateTime(2023, 7, 26, 2, 32, 0, 222, DateTimeKind.Utc).AddTicks(626), 33L, true },
                    { 125L, 199L, "Iusto a nihil. Dolorem cumque itaque natus. Possimus et quia natus libero harum voluptatem a. Provident incidunt voluptates dolorum quis eos at facilis saepe provident. Accusamus fuga aut modi.", new DateTime(2023, 8, 13, 4, 4, 9, 108, DateTimeKind.Utc).AddTicks(1145), 26L, false },
                    { 126L, 37L, "Odio saepe commodi.\nTempora inventore deleniti dolore repudiandae velit voluptas eligendi aliquid.\nNumquam illum officia voluptas ad.", new DateTime(2020, 1, 31, 4, 34, 35, 100, DateTimeKind.Utc).AddTicks(9894), 17L, false }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "IsPublic" },
                values: new object[,]
                {
                    { 127L, 183L, "Aspernatur similique autem asperiores. In similique totam temporibus perferendis aliquam non. Quibusdam neque est dolorum sit accusantium recusandae non.", new DateTime(2023, 5, 30, 8, 50, 51, 888, DateTimeKind.Utc).AddTicks(6689), 3L, false },
                    { 128L, 43L, "Aliquam eaque unde non. Eaque a repudiandae blanditiis sint expedita dignissimos quia. Occaecati velit natus veritatis quia deleniti sit nesciunt dolor voluptas. Velit expedita consectetur temporibus minus rerum distinctio fugit reprehenderit.", new DateTime(2023, 5, 14, 7, 58, 25, 37, DateTimeKind.Utc).AddTicks(3601), 19L, false },
                    { 129L, 50L, "Magnam consectetur cumque ea qui consequatur facilis iure culpa. Doloribus cum aut nesciunt aspernatur aliquam. Est excepturi eum assumenda. Est aut asperiores. Qui libero assumenda minus fugiat.", new DateTime(2023, 7, 9, 9, 11, 53, 543, DateTimeKind.Utc).AddTicks(3861), 26L, true },
                    { 130L, 73L, "Eius reprehenderit perferendis et quia ut a maiores enim ut. Dolores dolore alias. Numquam quasi magni totam est.", new DateTime(2023, 8, 14, 10, 9, 20, 450, DateTimeKind.Utc).AddTicks(9826), 4L, true },
                    { 131L, 198L, "Quod et neque reprehenderit magni quia magnam quas.\nQuis ut repudiandae.\nSit aut sit dolores iste ad.\nFugiat itaque reprehenderit sunt quidem et.\nEst delectus enim eaque dolor.\nSimilique numquam sint voluptatem voluptas.", new DateTime(2023, 8, 15, 12, 54, 24, 232, DateTimeKind.Utc).AddTicks(8502), 40L, true },
                    { 132L, 21L, "nulla", new DateTime(2023, 8, 3, 13, 33, 20, 154, DateTimeKind.Utc).AddTicks(9506), 40L, true },
                    { 133L, 167L, "Qui quam ut commodi.", new DateTime(2023, 1, 9, 6, 19, 51, 867, DateTimeKind.Utc).AddTicks(2704), 27L, false },
                    { 134L, 53L, "Facilis ut consequatur sit temporibus iste et aut sunt. Expedita similique tenetur corrupti suscipit facere unde rem quam. Est magnam qui est dolorum fugiat asperiores. Velit et natus vitae ex dolores aliquid a. Sint enim distinctio inventore ut.", new DateTime(2023, 8, 2, 17, 26, 12, 432, DateTimeKind.Utc).AddTicks(3587), 38L, true },
                    { 135L, 143L, "Quos ab consequuntur fugit suscipit aut quia reprehenderit consequatur vitae.", new DateTime(2023, 7, 13, 2, 1, 25, 286, DateTimeKind.Utc).AddTicks(8694), 23L, false },
                    { 136L, 153L, "Nemo sunt numquam blanditiis eos vel vel aperiam neque.", new DateTime(2023, 8, 20, 0, 11, 39, 785, DateTimeKind.Utc).AddTicks(3127), 30L, true },
                    { 137L, 65L, "Assumenda dignissimos sed dolore ea sed ducimus placeat et.", new DateTime(2023, 4, 8, 17, 25, 0, 471, DateTimeKind.Utc).AddTicks(9777), 6L, false },
                    { 138L, 146L, "Debitis molestias quam. Aliquid quidem recusandae. Fugit tempore explicabo tenetur in et et ea. Veniam earum excepturi dignissimos recusandae aperiam.", new DateTime(2023, 8, 23, 11, 21, 7, 609, DateTimeKind.Utc).AddTicks(4548), 33L, false },
                    { 139L, 46L, "quia", new DateTime(2023, 4, 10, 15, 8, 34, 480, DateTimeKind.Utc).AddTicks(541), 10L, true },
                    { 140L, 183L, "Similique nemo ducimus magni.\nVel magni est voluptatem dolores quia deserunt.\nNatus nihil consequatur eos nulla et earum voluptatum eligendi adipisci.\nNam quibusdam error rerum qui et ratione.", new DateTime(2023, 8, 8, 12, 49, 26, 313, DateTimeKind.Utc).AddTicks(506), 8L, true },
                    { 141L, 163L, "quo", new DateTime(2023, 8, 10, 4, 57, 59, 212, DateTimeKind.Utc).AddTicks(292), 3L, true },
                    { 142L, 193L, "Consequatur et vel et et cupiditate vitae quis.", new DateTime(2023, 8, 18, 16, 13, 40, 535, DateTimeKind.Utc).AddTicks(2090), 26L, true },
                    { 143L, 86L, "Totam quo illum dolore odit nesciunt ut voluptatem occaecati optio. Similique ipsum ab nulla officia eos magni maiores. Debitis veniam iste rerum commodi et quos amet ut.", new DateTime(2021, 6, 4, 5, 3, 15, 760, DateTimeKind.Utc).AddTicks(6866), 39L, true },
                    { 144L, 19L, "Dolore iste ut unde sit. Eos unde necessitatibus tenetur voluptates voluptatem. Nihil et et. Veniam ipsa amet sequi accusamus rerum id nam neque ea.", new DateTime(2022, 9, 27, 8, 24, 39, 474, DateTimeKind.Utc).AddTicks(2353), 31L, true },
                    { 145L, 2L, "Iste laboriosam culpa saepe odio consequatur corrupti nihil.", new DateTime(2023, 2, 18, 23, 29, 10, 831, DateTimeKind.Utc).AddTicks(6912), 17L, true },
                    { 146L, 96L, "quasi", new DateTime(2020, 11, 20, 16, 54, 9, 931, DateTimeKind.Utc).AddTicks(6332), 33L, false },
                    { 147L, 16L, "Dolores vel tempore harum.\nVero accusantium assumenda quis sed velit distinctio laborum natus vitae.\nMinus qui rem omnis omnis ratione vel voluptatum sit quos.\nAut dolorem ducimus.\nQuibusdam autem unde nihil sapiente et voluptatem natus.\nPraesentium expedita quisquam itaque asperiores non natus molestias qui consequatur.", new DateTime(2021, 10, 20, 5, 12, 45, 882, DateTimeKind.Utc).AddTicks(2763), 11L, true },
                    { 148L, 58L, "Error adipisci laborum iure voluptas ratione id voluptas voluptate et.", new DateTime(2023, 7, 17, 20, 12, 36, 474, DateTimeKind.Utc).AddTicks(7224), 6L, true },
                    { 149L, 179L, "totam", new DateTime(2022, 6, 23, 22, 57, 20, 708, DateTimeKind.Utc).AddTicks(4726), 4L, true },
                    { 150L, 10L, "Atque dicta recusandae qui corrupti nesciunt quis aut cupiditate.", new DateTime(2023, 5, 23, 21, 36, 32, 798, DateTimeKind.Utc).AddTicks(4415), 18L, true },
                    { 151L, 146L, "Amet ipsam illo debitis.\nVel facilis dolores consequatur enim asperiores est.\nFacere labore nostrum natus est quo non blanditiis.\nDistinctio dignissimos rem corporis.\nLabore voluptates nihil.", new DateTime(2023, 8, 22, 18, 14, 40, 638, DateTimeKind.Utc).AddTicks(6207), 33L, true },
                    { 152L, 153L, "Ab unde laboriosam aut odio iusto numquam numquam neque.", new DateTime(2023, 6, 24, 18, 53, 52, 840, DateTimeKind.Utc).AddTicks(755), 31L, true },
                    { 153L, 72L, "Repellat quia quo alias expedita est voluptate tempora. Voluptate qui nam unde eligendi. Doloribus esse laudantium labore perferendis ut est dicta voluptatem. Dignissimos minima impedit sint quia et ab eum sit corporis. Aut suscipit fugit dignissimos eos fugit illum aperiam. Omnis libero rem aut qui ex nisi dolorum eos.", new DateTime(2023, 3, 31, 5, 53, 29, 937, DateTimeKind.Utc).AddTicks(6673), 2L, true },
                    { 154L, 66L, "non", new DateTime(2023, 8, 23, 9, 58, 30, 801, DateTimeKind.Utc).AddTicks(7896), 13L, false },
                    { 155L, 197L, "Non iure explicabo voluptatibus vitae ut quibusdam debitis ut. Illo ipsum esse omnis consequatur id cupiditate delectus dicta. Ut distinctio repudiandae distinctio voluptatem ullam. Fugit iusto et vero inventore ipsam porro eos vitae debitis. Ad asperiores dolorem maiores quia animi.", new DateTime(2023, 4, 17, 18, 51, 59, 641, DateTimeKind.Utc).AddTicks(7634), 25L, true },
                    { 156L, 133L, "Repellat necessitatibus aut et accusamus rem et distinctio dolor.\nNobis odio et recusandae asperiores vero.\nQuidem est vero odit est explicabo id voluptatibus.\nIpsam soluta autem cum totam mollitia rem.\nVero dolorem sed.\nEnim est ducimus facere quos unde qui perspiciatis est.", new DateTime(2023, 7, 17, 8, 18, 10, 429, DateTimeKind.Utc).AddTicks(4954), 27L, false },
                    { 157L, 177L, "Cum enim quibusdam. Aut sit nesciunt facere accusamus odit reiciendis. Ut esse beatae. Et pariatur commodi fugit voluptate ex adipisci perspiciatis praesentium. Nulla et eligendi consequuntur possimus nam. Commodi laboriosam perspiciatis quis optio delectus earum qui optio.", new DateTime(2023, 4, 15, 21, 11, 32, 268, DateTimeKind.Utc).AddTicks(9658), 23L, true },
                    { 158L, 122L, "Neque perferendis quasi iusto soluta cumque quia.\nMagnam quae dignissimos.\nMolestias inventore quod aliquid enim quis.", new DateTime(2023, 3, 5, 5, 43, 27, 634, DateTimeKind.Utc).AddTicks(5545), 22L, true },
                    { 159L, 62L, "Distinctio quo rem consequatur aut voluptate. Sunt et provident aut nobis tempora quia distinctio sit. Sed est cupiditate blanditiis rerum quidem. Eaque aliquam voluptas delectus. Illo impedit inventore consectetur. Sit maiores pariatur.", new DateTime(2023, 8, 4, 6, 52, 40, 355, DateTimeKind.Utc).AddTicks(6279), 26L, true },
                    { 160L, 43L, "Et nam dicta dolorem rerum veritatis aut. Nemo ea sapiente porro architecto. Assumenda quisquam facilis eveniet quis. Qui illo dolores.", new DateTime(2022, 10, 18, 3, 49, 13, 773, DateTimeKind.Utc).AddTicks(2795), 28L, true },
                    { 161L, 3L, "voluptas", new DateTime(2023, 6, 11, 12, 36, 23, 556, DateTimeKind.Utc).AddTicks(1742), 22L, false },
                    { 162L, 75L, "excepturi", new DateTime(2019, 6, 7, 16, 47, 48, 94, DateTimeKind.Utc).AddTicks(9147), 25L, true },
                    { 163L, 75L, "tenetur", new DateTime(2019, 7, 29, 3, 16, 51, 517, DateTimeKind.Utc).AddTicks(1259), 34L, false },
                    { 164L, 175L, "Occaecati sed iste asperiores cum ut et nihil in ipsum.", new DateTime(2023, 8, 16, 15, 35, 8, 822, DateTimeKind.Utc).AddTicks(9948), 11L, true },
                    { 165L, 41L, "Esse quam numquam delectus illum. Unde ipsa debitis ut inventore qui. Nam nesciunt aut omnis facilis. Quis sit ut consequatur quasi voluptate itaque.", new DateTime(2023, 5, 2, 19, 53, 55, 552, DateTimeKind.Utc).AddTicks(6346), 22L, true },
                    { 166L, 177L, "aut", new DateTime(2023, 7, 4, 8, 37, 53, 319, DateTimeKind.Utc).AddTicks(1515), 17L, true },
                    { 167L, 142L, "hic", new DateTime(2023, 8, 20, 21, 7, 53, 11, DateTimeKind.Utc).AddTicks(3705), 1L, true },
                    { 168L, 56L, "Aliquam enim quas quo aliquam. Magnam qui quia minima ratione esse qui. Debitis adipisci magnam quas magni asperiores vitae. Pariatur magnam cupiditate porro vel itaque dignissimos.", new DateTime(2022, 2, 11, 8, 44, 53, 295, DateTimeKind.Utc).AddTicks(3982), 19L, true }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "IsPublic" },
                values: new object[,]
                {
                    { 169L, 152L, "Optio qui veniam labore doloribus culpa cum quia.\nEius rerum reprehenderit eum rerum.", new DateTime(2022, 7, 26, 1, 13, 26, 929, DateTimeKind.Utc).AddTicks(4304), 27L, true },
                    { 170L, 43L, "Quam magnam amet sed eligendi ipsam hic molestiae.", new DateTime(2023, 1, 29, 8, 37, 58, 382, DateTimeKind.Utc).AddTicks(3079), 29L, true },
                    { 171L, 2L, "Dolores nam eius necessitatibus.", new DateTime(2023, 3, 29, 17, 37, 49, 909, DateTimeKind.Utc).AddTicks(7332), 36L, true },
                    { 172L, 158L, "Nihil aut et occaecati et quibusdam reprehenderit voluptate totam. Ducimus in placeat unde cum. Placeat sapiente qui quas et maiores dolorum ducimus. Incidunt dolor corporis.", new DateTime(2022, 5, 20, 9, 40, 56, 577, DateTimeKind.Utc).AddTicks(8227), 30L, false },
                    { 173L, 80L, "Quia qui voluptate mollitia aut. Aperiam itaque a ab voluptatem. Nisi sit officiis qui quo in. Ad odio corrupti illo nihil eum sit sunt dolorum. Molestias sit occaecati maiores ad rem dolor laboriosam. Nihil sit laudantium quae nam.", new DateTime(2023, 2, 5, 5, 17, 53, 583, DateTimeKind.Utc).AddTicks(493), 31L, false },
                    { 174L, 11L, "Doloremque et architecto corrupti fugiat porro in voluptatibus. Eos incidunt velit voluptatem. Accusamus maxime atque quasi eos optio. Nisi optio dolorum consequatur qui qui expedita deserunt fuga. Sed quo accusantium deleniti ipsam dignissimos dolores. Facere dolor ea sequi voluptas tenetur.", new DateTime(2023, 5, 24, 15, 32, 34, 93, DateTimeKind.Utc).AddTicks(7835), 9L, false },
                    { 175L, 74L, "ad", new DateTime(2023, 6, 6, 6, 20, 52, 738, DateTimeKind.Utc).AddTicks(840), 9L, true },
                    { 176L, 61L, "Soluta odio eveniet quod reprehenderit officia.\nAut cumque labore ut omnis.", new DateTime(2023, 1, 15, 22, 21, 30, 190, DateTimeKind.Utc).AddTicks(2068), 26L, false },
                    { 177L, 80L, "Vero nam possimus laborum. Consequuntur molestias ut numquam consequatur dolores sit. Ratione maiores illum alias vero eaque delectus similique natus. Aliquid perspiciatis magnam aut repellendus quis quod alias corporis.", new DateTime(2023, 6, 10, 13, 12, 19, 345, DateTimeKind.Utc).AddTicks(1157), 13L, true },
                    { 178L, 100L, "Et aut labore et aut. Illo dolor voluptate ipsam. Fuga magnam officiis voluptatum. Exercitationem dolorem voluptate quasi aliquid sequi est. Voluptatum alias adipisci. Exercitationem fugiat adipisci saepe dolor natus nihil dicta voluptas.", new DateTime(2023, 8, 3, 15, 0, 0, 144, DateTimeKind.Utc).AddTicks(7867), 6L, false },
                    { 179L, 94L, "similique", new DateTime(2023, 5, 13, 0, 5, 58, 305, DateTimeKind.Utc).AddTicks(9450), 5L, true },
                    { 180L, 21L, "Debitis sit delectus sint possimus earum praesentium nesciunt sit deserunt.", new DateTime(2023, 8, 15, 13, 6, 16, 674, DateTimeKind.Utc).AddTicks(9572), 11L, true },
                    { 181L, 154L, "Ducimus est qui reprehenderit nostrum.\nDicta voluptatem culpa minima officia aliquam rerum ex magnam.", new DateTime(2023, 6, 15, 0, 10, 33, 967, DateTimeKind.Utc).AddTicks(5793), 17L, false },
                    { 182L, 85L, "autem", new DateTime(2023, 8, 1, 13, 29, 6, 640, DateTimeKind.Utc).AddTicks(3817), 39L, true },
                    { 183L, 128L, "et", new DateTime(2023, 7, 21, 3, 23, 18, 839, DateTimeKind.Utc).AddTicks(6502), 9L, true },
                    { 184L, 24L, "Tempore veritatis aut non qui eius aut aliquam quia. Officiis et ut ut pariatur et velit totam. Necessitatibus voluptates voluptatem quasi corrupti totam ratione saepe ducimus. Consequatur sunt deserunt ut.", new DateTime(2022, 12, 20, 10, 35, 24, 137, DateTimeKind.Utc).AddTicks(4837), 8L, true },
                    { 185L, 158L, "Animi ut sed dolore sapiente sunt sit voluptates tempore.", new DateTime(2023, 3, 2, 17, 32, 14, 797, DateTimeKind.Utc).AddTicks(2444), 33L, false },
                    { 186L, 185L, "praesentium", new DateTime(2022, 11, 28, 2, 49, 25, 630, DateTimeKind.Utc).AddTicks(8367), 40L, true },
                    { 187L, 66L, "odio", new DateTime(2023, 8, 22, 19, 53, 16, 723, DateTimeKind.Utc).AddTicks(4838), 6L, true },
                    { 188L, 45L, "Sed omnis distinctio.\nBeatae quidem nesciunt perspiciatis temporibus omnis.\nQui ducimus ut.", new DateTime(2023, 8, 18, 13, 39, 14, 497, DateTimeKind.Utc).AddTicks(4313), 10L, true },
                    { 189L, 55L, "Dignissimos consectetur aperiam adipisci corporis.", new DateTime(2023, 8, 12, 18, 12, 19, 750, DateTimeKind.Utc).AddTicks(4229), 11L, true },
                    { 190L, 93L, "Consequatur perferendis autem sed magni dignissimos. Dicta vitae sint dolores officiis rerum sunt laborum. Aut omnis eveniet dolore. Molestiae natus molestiae sint.", new DateTime(2022, 4, 20, 12, 20, 48, 299, DateTimeKind.Utc).AddTicks(1233), 33L, true },
                    { 191L, 40L, "Suscipit quo officia et dignissimos aut non temporibus fugiat. Ad cupiditate inventore neque enim. Expedita consectetur ipsum magni. Adipisci adipisci rerum. Et id libero corporis sint nulla.", new DateTime(2023, 6, 10, 1, 10, 48, 462, DateTimeKind.Utc).AddTicks(8120), 14L, true },
                    { 192L, 36L, "quas", new DateTime(2022, 11, 13, 17, 17, 39, 302, DateTimeKind.Utc).AddTicks(4147), 1L, false },
                    { 193L, 184L, "velit", new DateTime(2023, 7, 23, 18, 57, 40, 987, DateTimeKind.Utc).AddTicks(9085), 2L, true },
                    { 194L, 101L, "Non voluptatem illo porro.", new DateTime(2023, 5, 5, 5, 48, 35, 465, DateTimeKind.Utc).AddTicks(3565), 6L, false },
                    { 195L, 135L, "Dolores eos atque sint iusto beatae et.\nFuga dolores quo deleniti molestiae dolorem aut voluptatibus.\nMinima ut quam asperiores magnam sint quis voluptas temporibus.\nDolor fuga qui distinctio et velit.\nQuas iure fuga dolores.\nSunt autem ratione qui sit eius.", new DateTime(2023, 4, 19, 10, 52, 32, 908, DateTimeKind.Utc).AddTicks(4684), 22L, true },
                    { 196L, 56L, "Totam natus qui dolore.\nAut voluptatem facilis mollitia laudantium.\nTempora voluptatum voluptates.", new DateTime(2021, 1, 16, 20, 58, 19, 815, DateTimeKind.Utc).AddTicks(333), 27L, true },
                    { 197L, 100L, "Quibusdam distinctio fuga pariatur occaecati.", new DateTime(2023, 7, 22, 0, 55, 27, 117, DateTimeKind.Utc).AddTicks(2435), 4L, true },
                    { 198L, 148L, "Aperiam quam sit quidem animi quaerat ipsa excepturi nisi fugiat. Voluptas ab quas ut nemo qui eum necessitatibus magni consequatur. Odio aut recusandae.", new DateTime(2023, 8, 23, 6, 5, 17, 593, DateTimeKind.Utc).AddTicks(1959), 35L, false },
                    { 199L, 133L, "deleniti", new DateTime(2022, 8, 6, 21, 31, 17, 675, DateTimeKind.Utc).AddTicks(7877), 8L, true },
                    { 200L, 129L, "culpa", new DateTime(2023, 2, 28, 11, 34, 40, 207, DateTimeKind.Utc).AddTicks(6756), 17L, true }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "Output", "SubmittedAt" },
                values: new object[,]
                {
                    { 1L, 164L, "Vitae earum pariatur animi saepe explicabo asperiores molestiae et nihil. Esse provident id saepe nesciunt enim. Neque nemo dolore cupiditate temporibus vitae. Ut est voluptates qui minima dolor totam reprehenderit. Dolores non blanditiis facere numquam et facilis. Saepe sequi adipisci labore nesciunt.", new DateTime(2023, 4, 25, 23, 33, 21, 140, DateTimeKind.Utc).AddTicks(6331), 33L, "Tempora minus et in facilis natus voluptatem voluptas non. Dignissimos dicta dolor delectus molestiae alias accusantium voluptatem. Delectus cumque iste. Ea nam aut et. Necessitatibus molestiae odit quibusdam ullam ad ab quae.", new DateTime(2023, 8, 16, 1, 10, 24, 126, DateTimeKind.Utc).AddTicks(6866) },
                    { 2L, 57L, "Ea iste quos non incidunt consectetur numquam.\nQuod facilis dolorem libero.\nNostrum voluptates tempore non sint debitis et.\nFacilis temporibus molestias repudiandae aut amet non.\nIpsum amet perferendis id.\nAlias aut deleniti optio ea optio numquam.", new DateTime(2023, 8, 22, 15, 39, 37, 822, DateTimeKind.Utc).AddTicks(5361), 8L, "Aut vel dolores cupiditate et consectetur consequatur voluptatem. Voluptatem quasi quo assumenda maiores sit aliquid consequatur alias. Sunt praesentium voluptatem recusandae hic nostrum et consectetur ut aut.", new DateTime(2023, 8, 23, 4, 23, 4, 772, DateTimeKind.Utc).AddTicks(5123) },
                    { 3L, 98L, "Eum distinctio corporis ut dolorem et velit.", new DateTime(2023, 7, 3, 21, 10, 10, 509, DateTimeKind.Utc).AddTicks(9384), 40L, "Quis laboriosam dolores soluta illo est numquam.", new DateTime(2023, 8, 21, 11, 26, 20, 987, DateTimeKind.Utc).AddTicks(6736) },
                    { 4L, 187L, "Repellat est sequi.\nEaque cupiditate consequuntur harum deserunt atque delectus nisi.\nAut voluptate ut tenetur sint quam consequatur praesentium.", new DateTime(2021, 3, 8, 2, 39, 48, 245, DateTimeKind.Utc).AddTicks(1387), 1L, "Corrupti quasi omnis.\nRerum iusto dicta.\nMolestiae velit ut reprehenderit assumenda similique vel consequatur neque.\nUt velit sunt ut sint maiores beatae et.", new DateTime(2021, 9, 30, 1, 5, 40, 617, DateTimeKind.Utc).AddTicks(549) },
                    { 5L, 80L, "Aspernatur qui delectus ut.", new DateTime(2022, 10, 20, 13, 4, 13, 290, DateTimeKind.Utc).AddTicks(7769), 7L, "nobis", new DateTime(2023, 7, 28, 18, 58, 36, 181, DateTimeKind.Utc).AddTicks(1396) },
                    { 6L, 192L, "perferendis", new DateTime(2023, 7, 3, 9, 48, 45, 544, DateTimeKind.Utc).AddTicks(5159), 33L, "Esse voluptas facere autem. Delectus qui iste error voluptatem. Molestiae sequi impedit velit iste. Ipsum tempore molestiae esse aperiam eos accusantium placeat.", new DateTime(2023, 7, 4, 8, 4, 35, 546, DateTimeKind.Utc).AddTicks(2998) },
                    { 7L, 61L, "aut", new DateTime(2023, 5, 3, 6, 12, 51, 510, DateTimeKind.Utc).AddTicks(1555), 7L, "Iure saepe quas accusamus magni repellat velit ea.\nReprehenderit est labore.\nPorro earum consequatur nulla aspernatur a.\nVel nihil qui quae unde aut quo sed.\nA velit aut commodi asperiores vel nam.", null },
                    { 8L, 21L, "Voluptatem error provident quo beatae culpa modi repellendus.\nQuasi suscipit soluta neque praesentium voluptatem sed quis.", new DateTime(2023, 8, 10, 11, 41, 0, 662, DateTimeKind.Utc).AddTicks(1019), 28L, "Reiciendis sint debitis. Et ad sed perspiciatis omnis non. Placeat error explicabo accusantium maiores deleniti repellat praesentium. Id et eos. Expedita magni et impedit voluptatibus. Qui consequuntur nulla explicabo expedita aut.", new DateTime(2023, 8, 20, 22, 33, 15, 177, DateTimeKind.Utc).AddTicks(7584) },
                    { 9L, 76L, "Ut officia fugit quasi.\nSit rerum quis esse placeat nemo.\nDolor qui est est omnis.", new DateTime(2019, 12, 20, 5, 27, 39, 289, DateTimeKind.Utc).AddTicks(1307), 12L, "Consequuntur iure deserunt ut rem iusto et.", new DateTime(2022, 5, 23, 10, 14, 50, 579, DateTimeKind.Utc).AddTicks(8505) },
                    { 10L, 4L, "qui", new DateTime(2023, 4, 26, 15, 19, 52, 615, DateTimeKind.Utc).AddTicks(5606), 3L, "earum", new DateTime(2023, 5, 29, 5, 34, 13, 772, DateTimeKind.Utc).AddTicks(8180) }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "Output", "SubmittedAt" },
                values: new object[,]
                {
                    { 11L, 147L, "Explicabo repellendus enim quia aut voluptas aperiam voluptatem. Sed aut placeat possimus nobis facilis quidem excepturi aperiam voluptatem. Possimus sunt magnam. Omnis rerum nihil possimus ut eius voluptates laboriosam provident aut. Nobis quia mollitia velit ab sequi quidem est earum. Aliquam amet vel quis temporibus.", new DateTime(2023, 1, 14, 16, 37, 34, 368, DateTimeKind.Utc).AddTicks(9316), 5L, "Omnis tenetur consequatur sed ea unde laudantium. Minima cum nam quia voluptas numquam officiis. A excepturi repudiandae quo non earum sed ipsam nemo distinctio. Qui voluptas iure iste praesentium nostrum vel. Molestiae et ratione voluptas ab id et debitis sapiente.", new DateTime(2023, 1, 23, 12, 49, 33, 627, DateTimeKind.Utc).AddTicks(8311) },
                    { 12L, 56L, "Nulla dolor ipsam qui fugiat.\nTempora cumque doloremque aut exercitationem necessitatibus sed quia.\nHic dignissimos rerum beatae consequatur maxime et aut omnis veritatis.\nQuia in magni deleniti.", new DateTime(2021, 8, 30, 1, 20, 14, 20, DateTimeKind.Utc).AddTicks(7601), 39L, "qui", new DateTime(2022, 9, 3, 21, 6, 39, 89, DateTimeKind.Utc).AddTicks(8015) },
                    { 13L, 100L, "Et et sit. Eos maiores voluptas ut qui in mollitia consequatur. Animi provident reiciendis soluta sed possimus.", new DateTime(2023, 8, 2, 21, 49, 54, 359, DateTimeKind.Utc).AddTicks(6346), 11L, "Similique unde accusamus rem sint quo mollitia ea.\nQuos at ut necessitatibus soluta nulla.\nRerum beatae ipsam nemo possimus omnis.\nEst in autem placeat harum eum a adipisci quam et.", new DateTime(2023, 8, 20, 13, 39, 43, 944, DateTimeKind.Utc).AddTicks(2658) },
                    { 14L, 62L, "alias", new DateTime(2023, 8, 18, 20, 38, 26, 463, DateTimeKind.Utc).AddTicks(1264), 6L, "Consequuntur aut excepturi blanditiis impedit at.", new DateTime(2023, 8, 22, 1, 6, 25, 578, DateTimeKind.Utc).AddTicks(6593) },
                    { 15L, 15L, "eveniet", new DateTime(2023, 7, 10, 15, 30, 58, 163, DateTimeKind.Utc).AddTicks(3994), 4L, "nam", new DateTime(2023, 7, 14, 16, 0, 26, 154, DateTimeKind.Utc).AddTicks(9008) },
                    { 16L, 127L, "Iusto laboriosam fuga dolor autem.\nAut consequatur ipsam alias laboriosam molestiae dolor.\nEarum nam eveniet quas cupiditate.\nSint inventore ducimus.", new DateTime(2023, 8, 20, 10, 17, 1, 841, DateTimeKind.Utc).AddTicks(1851), 34L, "Aut possimus mollitia non repudiandae nisi.", new DateTime(2023, 8, 20, 16, 5, 4, 127, DateTimeKind.Utc).AddTicks(6213) },
                    { 17L, 37L, "tempore", new DateTime(2018, 5, 2, 12, 26, 28, 27, DateTimeKind.Utc).AddTicks(392), 40L, "Tempore quae quia iste qui rerum voluptas consequuntur debitis adipisci. Ab et dolor autem necessitatibus magnam. Sunt omnis vel deleniti in expedita dolores quibusdam. Sit eum in modi placeat id eos nulla perferendis ad. Ut sint sint totam est porro rerum autem velit. Cumque modi fugiat.", new DateTime(2021, 3, 18, 12, 35, 29, 843, DateTimeKind.Utc).AddTicks(4697) },
                    { 18L, 189L, "Repellendus repudiandae distinctio.\nUllam aut impedit enim nostrum.\nCommodi et odio temporibus expedita nulla repudiandae eum nobis assumenda.\nMollitia hic deleniti id maxime et similique quo.", new DateTime(2021, 12, 30, 2, 8, 29, 587, DateTimeKind.Utc).AddTicks(196), 20L, "Facere facere sed consequatur quaerat.\nUt maxime dolor atque.\nSunt laboriosam id qui consectetur cupiditate dolor et ea a.\nEa amet delectus dolor eligendi iste qui qui mollitia.\nVeniam doloribus et nobis tempore et officia placeat.", new DateTime(2022, 5, 9, 6, 12, 7, 430, DateTimeKind.Utc).AddTicks(8504) },
                    { 19L, 162L, "Ut illo quae. Ut nostrum velit repellat qui non ipsa. Rem temporibus sit.", new DateTime(2023, 7, 12, 16, 3, 42, 802, DateTimeKind.Utc).AddTicks(1946), 9L, "necessitatibus", new DateTime(2023, 8, 12, 14, 25, 4, 258, DateTimeKind.Utc).AddTicks(1876) },
                    { 20L, 99L, "Aut debitis sit nesciunt qui et odit.\nEligendi quia tempore.\nInventore est doloribus.\nEt nostrum quod laborum excepturi ad eligendi.\nIste voluptas rem ab autem voluptatem rerum sed ipsum hic.\nVelit qui voluptas.", new DateTime(2023, 7, 1, 7, 2, 23, 232, DateTimeKind.Utc).AddTicks(4182), 34L, "Recusandae eaque dolor qui nisi itaque.", new DateTime(2023, 8, 11, 7, 26, 24, 855, DateTimeKind.Utc).AddTicks(7843) },
                    { 21L, 28L, "Voluptatem beatae est amet explicabo id illum doloremque inventore.", new DateTime(2023, 6, 16, 3, 31, 52, 775, DateTimeKind.Utc).AddTicks(6713), 23L, "et", new DateTime(2023, 6, 23, 16, 22, 33, 564, DateTimeKind.Utc).AddTicks(5960) },
                    { 22L, 45L, "Ipsa enim cum.\nQuos odit culpa et dolores reiciendis.", new DateTime(2023, 8, 20, 20, 33, 8, 157, DateTimeKind.Utc).AddTicks(3860), 16L, "voluptatem", new DateTime(2023, 8, 23, 7, 28, 58, 343, DateTimeKind.Utc).AddTicks(6529) },
                    { 23L, 60L, "Corporis ut iusto in.", new DateTime(2023, 6, 9, 0, 3, 32, 986, DateTimeKind.Utc).AddTicks(9863), 34L, "Perferendis quia perferendis quisquam eos. Officia nulla vel laudantium. Est fugit beatae excepturi maiores voluptatem ab. Modi ipsa ut autem perferendis labore voluptatem aliquid aut. Id repudiandae et cum qui explicabo autem id omnis. Doloribus iusto perspiciatis.", new DateTime(2023, 6, 28, 22, 40, 56, 879, DateTimeKind.Utc).AddTicks(4533) },
                    { 24L, 133L, "autem", new DateTime(2023, 6, 6, 3, 22, 55, 50, DateTimeKind.Utc).AddTicks(7086), 13L, "Ut ab sunt.", new DateTime(2023, 8, 23, 10, 18, 51, 644, DateTimeKind.Utc).AddTicks(2296) },
                    { 25L, 97L, "Illo est omnis repellendus non ut maiores eos.\nUt recusandae quo repellendus dolores molestias.\nEst aut dolor.\nSunt ut corrupti error.\nAut fugiat et ut est exercitationem voluptate explicabo.\nQuos quasi placeat ut sit in neque et.", new DateTime(2023, 7, 4, 6, 44, 47, 882, DateTimeKind.Utc).AddTicks(4943), 32L, "Non repellendus vel nesciunt omnis enim. Molestiae nobis dolorum excepturi veniam maiores aperiam. Dolores omnis mollitia est dolore non quod inventore alias. Voluptas ratione rerum eum quae iusto. Repudiandae voluptatem sed ipsam voluptatem ad dolor exercitationem.", new DateTime(2023, 7, 9, 17, 43, 49, 58, DateTimeKind.Utc).AddTicks(6351) },
                    { 26L, 146L, "Quas voluptatem est illo aspernatur voluptas rerum. Qui consequatur quisquam iusto neque eos. Rerum sit voluptas quis quo dolores excepturi. Minima illum voluptatum. Quae sit hic accusantium et error. Eos sed iusto vel sunt qui voluptatem et.", new DateTime(2023, 8, 21, 21, 43, 15, 381, DateTimeKind.Utc).AddTicks(545), 21L, "Ut dolores molestiae itaque assumenda molestiae dolores.\nEt aut asperiores voluptatem voluptas labore.\nOfficiis voluptas eos omnis repellendus et accusamus.", new DateTime(2023, 8, 22, 5, 49, 48, 280, DateTimeKind.Utc).AddTicks(74) },
                    { 27L, 69L, "In molestiae et et est rem nisi non aut.", new DateTime(2023, 7, 29, 10, 32, 16, 908, DateTimeKind.Utc).AddTicks(4177), 26L, "Labore facilis et qui ut aut qui tenetur impedit quam.\nConsequatur nihil corrupti voluptatum est sed molestias natus sed et.", new DateTime(2023, 7, 31, 5, 17, 9, 780, DateTimeKind.Utc).AddTicks(1052) },
                    { 28L, 116L, "Ut minus sunt facere eveniet.\nModi eveniet qui praesentium explicabo nam ipsam architecto nesciunt.\nAut atque labore repellat minus voluptas.\nAlias voluptates voluptatem est ullam quae architecto.\nMolestias vel cum commodi nobis ea inventore non.", new DateTime(2023, 7, 22, 19, 13, 5, 303, DateTimeKind.Utc).AddTicks(1763), 39L, "Dolorum ab totam blanditiis omnis omnis amet vitae.\nOmnis commodi assumenda perspiciatis voluptatem dolores similique voluptas officiis eius.\nPariatur excepturi id officia quis rerum quo rem qui illo.", new DateTime(2023, 7, 23, 8, 47, 26, 539, DateTimeKind.Utc).AddTicks(4731) },
                    { 29L, 33L, "Rem illo fugit sapiente fugit sapiente.\nLaborum magni nisi omnis.\nNumquam et odio voluptas et aut ipsam debitis dolorem.\nVoluptas quo earum et consequatur repellendus voluptatem non ipsam qui.", new DateTime(2023, 3, 13, 9, 34, 2, 860, DateTimeKind.Utc).AddTicks(5809), 17L, "iure", new DateTime(2023, 8, 5, 1, 44, 5, 780, DateTimeKind.Utc).AddTicks(1973) },
                    { 30L, 143L, "Excepturi consequatur sint aliquid quo ullam eos esse. Mollitia incidunt expedita quis. Numquam in voluptatem quia sequi ex officia. Doloremque delectus possimus eum magnam ad sint.", new DateTime(2023, 8, 22, 15, 28, 18, 269, DateTimeKind.Utc).AddTicks(2653), 26L, "Iusto quos qui voluptatum autem deserunt quasi. Facilis id autem porro ex autem aut. Hic voluptate et consectetur dolorum dicta dicta repudiandae suscipit. Deserunt aut ab et ut quia rerum est modi autem. Id est et dolores.", new DateTime(2023, 8, 22, 20, 23, 16, 906, DateTimeKind.Utc).AddTicks(8344) },
                    { 31L, 5L, "Esse voluptas aut aut cupiditate et ut voluptate.\nEos voluptas repellat veritatis praesentium dolor.\nVelit eum nam voluptatem enim libero non et.", new DateTime(2023, 8, 2, 11, 12, 50, 287, DateTimeKind.Utc).AddTicks(1401), 28L, "Aut autem odit.", new DateTime(2023, 8, 6, 21, 56, 53, 805, DateTimeKind.Utc).AddTicks(4320) },
                    { 32L, 178L, "Veritatis commodi assumenda debitis eum nobis animi voluptas et.\nConsectetur non ad.\nAtque hic incidunt.\nMaxime fugit nemo cum totam hic.", new DateTime(2022, 8, 2, 19, 3, 44, 760, DateTimeKind.Utc).AddTicks(2929), 15L, "Fugit et repellendus omnis dolorem et repudiandae dolores totam. Ad molestiae maiores laborum eaque alias voluptatibus dolor dignissimos eum. Ut reprehenderit reiciendis officiis rerum nihil atque iure. Illum et vitae rerum atque voluptatem facilis exercitationem commodi est.", new DateTime(2022, 8, 22, 5, 51, 54, 179, DateTimeKind.Utc).AddTicks(6289) },
                    { 33L, 188L, "Quas enim tempore atque dolorem cupiditate rem dolores in.", new DateTime(2023, 5, 26, 9, 4, 12, 929, DateTimeKind.Utc).AddTicks(1963), 37L, "aut", new DateTime(2023, 7, 3, 22, 18, 57, 186, DateTimeKind.Utc).AddTicks(4826) },
                    { 34L, 144L, "Voluptas aspernatur consequuntur est ea.\nQuam facere totam est cupiditate nisi voluptatem iure.", new DateTime(2023, 5, 20, 18, 37, 46, 117, DateTimeKind.Utc).AddTicks(1408), 9L, "et", new DateTime(2023, 7, 21, 5, 48, 18, 975, DateTimeKind.Utc).AddTicks(9382) },
                    { 35L, 123L, "Sequi quo reprehenderit nihil officiis non qui dignissimos ut officia.\nNam autem dolores ipsam quibusdam placeat assumenda alias.\nIllo voluptas repellendus sint vel.\nEius aperiam nesciunt et maiores incidunt ut eius dolorum occaecati.\nAsperiores aut ut harum beatae.", new DateTime(2023, 5, 2, 1, 9, 21, 905, DateTimeKind.Utc).AddTicks(2106), 36L, "Maxime praesentium unde porro in laborum.", new DateTime(2023, 6, 15, 0, 39, 50, 767, DateTimeKind.Utc).AddTicks(6670) },
                    { 36L, 70L, "Officiis laborum reiciendis.", new DateTime(2023, 7, 8, 10, 12, 15, 852, DateTimeKind.Utc).AddTicks(6986), 15L, "Sed id velit voluptatem nesciunt.\nQuibusdam et possimus necessitatibus laudantium minus aut qui aliquid assumenda.", new DateTime(2023, 8, 6, 15, 2, 5, 744, DateTimeKind.Utc).AddTicks(4780) },
                    { 37L, 37L, "A commodi incidunt laudantium nihil vel et.\nCupiditate autem fugiat eum suscipit qui iure quo id.\nQui quisquam ratione.", new DateTime(2021, 11, 9, 10, 39, 24, 246, DateTimeKind.Utc).AddTicks(8995), 18L, "Nihil odit quaerat et sed voluptatum quod alias tempora temporibus.\nAutem est sit beatae autem.\nHarum non sit natus cupiditate iusto quia sapiente libero doloremque.\nReprehenderit et voluptatum corporis atque ut.\nIpsam quia minima et ab illo fugiat animi unde.\nMollitia amet enim aperiam voluptas quod sint dignissimos optio.", new DateTime(2021, 12, 12, 3, 2, 4, 918, DateTimeKind.Utc).AddTicks(8940) },
                    { 38L, 26L, "Laborum sunt enim illo enim.\nSunt omnis aliquam nihil alias neque.\nQui et rerum nihil.\nDeleniti possimus in et repudiandae.", new DateTime(2022, 4, 12, 18, 2, 41, 391, DateTimeKind.Utc).AddTicks(7453), 3L, "Et culpa facilis architecto laborum sunt id placeat eius. Ut minus veniam. Optio enim excepturi eaque excepturi minima error impedit quaerat. Et corporis illo est et voluptatibus distinctio ut consectetur. Est asperiores fugit sit explicabo voluptates natus. Molestias necessitatibus et eligendi vitae nihil.", new DateTime(2023, 6, 23, 14, 17, 31, 321, DateTimeKind.Utc).AddTicks(8542) },
                    { 39L, 187L, "Voluptatem eos ducimus.\nEaque sint voluptas labore consequatur.\nUt omnis dolorem nihil sequi sit rerum animi quisquam sit.", new DateTime(2021, 6, 10, 6, 54, 15, 743, DateTimeKind.Utc).AddTicks(4747), 6L, "consequatur", new DateTime(2022, 3, 20, 10, 28, 20, 932, DateTimeKind.Utc).AddTicks(4185) },
                    { 40L, 39L, "Eveniet laborum ullam sint tempore aliquam id dolor officiis. Ut ut occaecati voluptas sequi quia sed ex. Repellendus recusandae pariatur vero ipsa saepe hic qui excepturi sunt. Quis et quis officia doloribus molestiae praesentium et. Ut mollitia neque. Beatae rerum recusandae nulla consequatur dolor eveniet vel.", new DateTime(2022, 8, 7, 6, 51, 48, 424, DateTimeKind.Utc).AddTicks(2230), 28L, "Beatae pariatur quae facere quaerat dolorum est non modi.", new DateTime(2023, 2, 4, 21, 31, 21, 843, DateTimeKind.Utc).AddTicks(8202) },
                    { 41L, 195L, "Eos rerum quia quasi. Est quia omnis ea. Aut ea minus adipisci accusamus perferendis quaerat nostrum quod earum. Sed doloremque nemo quis. Totam sed est neque aperiam. Deserunt omnis aperiam non hic minus necessitatibus architecto et aut.", new DateTime(2023, 4, 17, 7, 4, 52, 58, DateTimeKind.Utc).AddTicks(2573), 36L, "Ipsum quos et voluptatem laboriosam eius id. Fugiat illo distinctio vero. Cumque qui corporis. Illo labore molestiae consectetur voluptas dolor nesciunt. Veritatis cupiditate ea nam sit velit ut quis nobis sed.", new DateTime(2023, 6, 5, 16, 37, 53, 845, DateTimeKind.Utc).AddTicks(6652) },
                    { 42L, 163L, "Omnis et autem architecto recusandae aperiam quasi est.", new DateTime(2023, 8, 13, 13, 22, 8, 951, DateTimeKind.Utc).AddTicks(2645), 22L, "Et minus et ea ipsam laboriosam vel ad eligendi sed.", new DateTime(2023, 8, 16, 16, 26, 8, 753, DateTimeKind.Utc).AddTicks(185) },
                    { 43L, 98L, "Earum suscipit autem libero exercitationem dolores.", new DateTime(2023, 7, 12, 21, 37, 4, 863, DateTimeKind.Utc).AddTicks(4249), 6L, "Cum repellendus accusamus.", new DateTime(2023, 8, 19, 1, 33, 4, 595, DateTimeKind.Utc).AddTicks(3124) },
                    { 44L, 130L, "Rerum aliquam quibusdam error et fugiat aut magnam.", new DateTime(2023, 4, 11, 21, 31, 42, 593, DateTimeKind.Utc).AddTicks(2902), 38L, "amet", new DateTime(2023, 6, 29, 15, 34, 9, 729, DateTimeKind.Utc).AddTicks(837) },
                    { 45L, 85L, "Sapiente magnam quia ut a in.\nIste excepturi ratione quia et rerum magni sunt.", new DateTime(2023, 5, 25, 1, 21, 22, 864, DateTimeKind.Utc).AddTicks(5603), 30L, "Cumque autem nihil.\nNatus ipsa ut quis veritatis doloremque quisquam.\nCupiditate tenetur quia blanditiis est.\nVoluptate voluptate exercitationem.\nMolestiae architecto quia sapiente quae commodi.\nVel architecto deleniti maxime provident fugiat facere.", new DateTime(2023, 6, 19, 10, 21, 16, 305, DateTimeKind.Utc).AddTicks(1466) },
                    { 46L, 63L, "Fugiat ut fuga magnam distinctio sit voluptate.\nQuia iusto dolor corporis ducimus et numquam.\nAsperiores et id dolore a et provident.", new DateTime(2023, 6, 5, 16, 35, 49, 764, DateTimeKind.Utc).AddTicks(1733), 13L, "Quisquam corporis suscipit magni odio dolorum. Voluptatem et sunt. Autem cumque commodi voluptate non.", new DateTime(2023, 7, 17, 8, 36, 28, 812, DateTimeKind.Utc).AddTicks(5919) },
                    { 47L, 187L, "quia", new DateTime(2021, 2, 1, 0, 44, 32, 612, DateTimeKind.Utc).AddTicks(6240), 3L, "quis", new DateTime(2022, 10, 2, 21, 1, 28, 239, DateTimeKind.Utc).AddTicks(4151) },
                    { 48L, 76L, "Non laudantium aut non.\nAsperiores nesciunt dolore.\nIure consequuntur voluptatem velit.\nAutem quo molestiae recusandae.\nEt deserunt ratione laborum.", new DateTime(2022, 3, 22, 23, 33, 38, 933, DateTimeKind.Utc).AddTicks(4538), 34L, "et", new DateTime(2023, 8, 5, 4, 41, 36, 719, DateTimeKind.Utc).AddTicks(8943) },
                    { 49L, 123L, "Distinctio quos eveniet corporis voluptatem voluptatem ipsam deserunt.\nDolor quisquam beatae eum dicta.\nNatus quaerat modi expedita deleniti reprehenderit ut veritatis at.", new DateTime(2023, 3, 23, 7, 49, 29, 962, DateTimeKind.Utc).AddTicks(5655), 9L, "delectus", new DateTime(2023, 5, 5, 14, 9, 13, 882, DateTimeKind.Utc).AddTicks(3562) },
                    { 50L, 198L, "Sed impedit voluptatum provident aut tempore et.\nEnim delectus saepe sit esse possimus occaecati consequuntur.\nDignissimos asperiores voluptates enim quia molestiae quae ullam.\nVeritatis cumque sed repellat porro.\nLaboriosam ut unde voluptatem vitae est aut maiores in quod.", new DateTime(2023, 8, 16, 9, 45, 28, 217, DateTimeKind.Utc).AddTicks(8091), 39L, "explicabo", null },
                    { 51L, 41L, "Sit quod eum aliquam esse minima et.", new DateTime(2023, 1, 25, 0, 13, 28, 633, DateTimeKind.Utc).AddTicks(2500), 25L, "omnis", new DateTime(2023, 3, 31, 10, 22, 4, 985, DateTimeKind.Utc).AddTicks(8791) },
                    { 52L, 137L, "Non quis quae voluptatibus. Aut sit similique necessitatibus suscipit. Enim et dolorum. Omnis nihil optio et molestias perferendis magni. Est quos aliquid autem quis quia et nulla ab.", new DateTime(2021, 11, 4, 18, 15, 18, 222, DateTimeKind.Utc).AddTicks(8330), 20L, "Incidunt quisquam exercitationem deserunt nobis qui.", new DateTime(2023, 7, 19, 10, 46, 22, 642, DateTimeKind.Utc).AddTicks(9940) }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "Output", "SubmittedAt" },
                values: new object[,]
                {
                    { 53L, 108L, "Deserunt facere rerum omnis nam ipsum eos vitae quas in. Voluptatibus quidem sapiente ea ut corrupti. Consequatur in iure. Deleniti eum aut sint perferendis voluptas id et corporis sunt. Iure dolor blanditiis aperiam nostrum iure. Voluptatem voluptatem eius eveniet.", new DateTime(2022, 12, 18, 9, 11, 59, 876, DateTimeKind.Utc).AddTicks(2648), 4L, "nihil", new DateTime(2023, 5, 5, 9, 46, 26, 304, DateTimeKind.Utc).AddTicks(7543) },
                    { 54L, 132L, "Natus animi nihil ad inventore perspiciatis ratione nesciunt consequatur voluptatum.", new DateTime(2023, 7, 5, 2, 55, 34, 985, DateTimeKind.Utc).AddTicks(255), 40L, "Officia magnam dolor et itaque velit est accusamus dolores labore.\nQui est nemo nihil voluptatum alias ab laudantium.", null },
                    { 55L, 152L, "reiciendis", new DateTime(2022, 10, 22, 16, 40, 56, 603, DateTimeKind.Utc).AddTicks(2099), 11L, "Qui cum quidem aut amet sed voluptas ex quam dolorum.\nDistinctio quae nihil ea aperiam.\nSit labore est soluta consequatur molestiae sed aut.", new DateTime(2022, 11, 24, 5, 39, 18, 855, DateTimeKind.Utc).AddTicks(1487) },
                    { 56L, 182L, "Necessitatibus soluta error aperiam omnis sed. Culpa quia qui molestiae. Suscipit est voluptate nihil. Corrupti facilis excepturi.", new DateTime(2023, 5, 14, 2, 50, 35, 450, DateTimeKind.Utc).AddTicks(9694), 40L, "Magnam occaecati nihil molestiae commodi vel dolore eligendi.\nAut magnam sequi quod quibusdam repellat repudiandae autem.\nQui natus modi.", new DateTime(2023, 7, 19, 9, 51, 38, 112, DateTimeKind.Utc).AddTicks(6914) },
                    { 57L, 179L, "et", new DateTime(2023, 2, 11, 18, 0, 6, 300, DateTimeKind.Utc).AddTicks(6857), 38L, "enim", new DateTime(2023, 2, 18, 15, 7, 21, 580, DateTimeKind.Utc).AddTicks(6873) },
                    { 58L, 70L, "Dolorem sed officiis saepe voluptas ea vitae.\nNam et eaque sunt pariatur praesentium.", new DateTime(2023, 8, 10, 17, 22, 9, 677, DateTimeKind.Utc).AddTicks(8190), 19L, "Nihil magnam laborum itaque ad perferendis laboriosam sit.", new DateTime(2023, 8, 15, 7, 11, 12, 762, DateTimeKind.Utc).AddTicks(3296) },
                    { 59L, 134L, "Quo amet modi itaque est sit.\nQuas nobis sed nobis.\nDoloremque nam praesentium atque occaecati vero.\nVeritatis et eos suscipit vel et eligendi.", new DateTime(2023, 6, 10, 15, 55, 27, 251, DateTimeKind.Utc).AddTicks(8829), 30L, "Ut est necessitatibus a qui iste.", null },
                    { 60L, 66L, "voluptatem", new DateTime(2023, 8, 23, 6, 46, 27, 365, DateTimeKind.Utc).AddTicks(9754), 3L, "magnam", new DateTime(2023, 8, 23, 7, 45, 50, 776, DateTimeKind.Utc).AddTicks(655) },
                    { 61L, 196L, "Nihil explicabo quam in cumque pariatur velit architecto repellat. Vel sapiente a enim est ut rem non quibusdam dolore. Consequatur occaecati ipsa. Rerum voluptatem atque itaque ut et non neque necessitatibus.", new DateTime(2023, 8, 15, 18, 47, 22, 573, DateTimeKind.Utc).AddTicks(8721), 29L, "et", new DateTime(2023, 8, 22, 3, 3, 17, 732, DateTimeKind.Utc).AddTicks(2024) },
                    { 62L, 156L, "Velit quia qui.", new DateTime(2023, 7, 16, 10, 16, 32, 287, DateTimeKind.Utc).AddTicks(7781), 16L, "Id distinctio soluta vero sunt dolores facere saepe sunt.", new DateTime(2023, 8, 7, 17, 35, 20, 310, DateTimeKind.Utc).AddTicks(2829) },
                    { 63L, 14L, "praesentium", new DateTime(2023, 8, 8, 17, 18, 49, 350, DateTimeKind.Utc).AddTicks(3556), 33L, "veniam", new DateTime(2023, 8, 21, 12, 23, 16, 437, DateTimeKind.Utc).AddTicks(5866) },
                    { 64L, 179L, "Reiciendis nihil est possimus voluptatem fugiat expedita deserunt quas debitis.", new DateTime(2022, 8, 18, 9, 7, 27, 823, DateTimeKind.Utc).AddTicks(4310), 10L, "Autem odio doloremque eos exercitationem nostrum nisi sed modi.", new DateTime(2023, 3, 25, 15, 59, 39, 953, DateTimeKind.Utc).AddTicks(1772) },
                    { 65L, 199L, "Rerum quod sed sit. Fugit impedit accusantium dolores magnam perspiciatis sed modi vitae ab. Animi dignissimos nulla est non eum sunt velit nostrum. Placeat provident quas dolorem ea voluptates ipsam commodi.", new DateTime(2023, 8, 5, 10, 16, 16, 674, DateTimeKind.Utc).AddTicks(2520), 15L, "Cum eum voluptas voluptatem. Nesciunt eaque et. Alias voluptatem voluptas.", new DateTime(2023, 8, 6, 21, 15, 10, 127, DateTimeKind.Utc).AddTicks(8499) },
                    { 66L, 160L, "Dolorem sint necessitatibus ullam commodi dolor cupiditate ut saepe.", new DateTime(2021, 12, 26, 10, 32, 37, 427, DateTimeKind.Utc).AddTicks(1031), 16L, "Eius repudiandae nihil molestiae et occaecati blanditiis illum libero.\nIn non libero animi est ratione quia.\nEum placeat veritatis illo ut et repellendus non sapiente.\nQui consectetur qui dolorem.\nQui non non et quasi.\nNatus fugit deleniti qui harum sint soluta harum voluptas corrupti.", null },
                    { 67L, 72L, "Laudantium eos sunt iste enim incidunt voluptatum reprehenderit ut non. Libero possimus quos aut rerum ut quidem. Voluptates laboriosam est aut eveniet adipisci et.", new DateTime(2022, 8, 22, 21, 52, 14, 127, DateTimeKind.Utc).AddTicks(308), 4L, "qui", new DateTime(2022, 12, 26, 14, 0, 4, 33, DateTimeKind.Utc).AddTicks(7720) },
                    { 68L, 164L, "Consequatur consequatur et dolore nam et veniam placeat aut aspernatur. Rerum eligendi odit ut esse numquam aliquam id. Eaque consectetur commodi distinctio accusantium beatae ullam officiis.", new DateTime(2023, 3, 11, 18, 27, 2, 189, DateTimeKind.Utc).AddTicks(9877), 40L, "Assumenda corporis quia dolores voluptatem fugiat suscipit dolore explicabo odio.\nAutem aspernatur et voluptatem nihil.", new DateTime(2023, 4, 2, 1, 11, 23, 150, DateTimeKind.Utc).AddTicks(4576) },
                    { 69L, 172L, "Saepe dolorum rerum qui modi qui.", new DateTime(2023, 8, 19, 3, 31, 32, 693, DateTimeKind.Utc).AddTicks(8860), 16L, "Et adipisci sapiente. Sint ut ad culpa aut consequatur molestias. Nobis qui voluptatem id impedit. Enim illo necessitatibus illo reprehenderit.", new DateTime(2023, 8, 21, 10, 15, 21, 819, DateTimeKind.Utc).AddTicks(6376) },
                    { 70L, 30L, "Sequi aperiam nemo officiis et sapiente id amet.\nPerspiciatis incidunt dolore.", new DateTime(2023, 6, 16, 12, 4, 34, 894, DateTimeKind.Utc).AddTicks(3508), 28L, "Quia modi vel ea.\nNon harum aliquid sequi accusamus et in.\nUt qui expedita necessitatibus assumenda ut ex ut.\nCupiditate ea est ut amet exercitationem.\nDistinctio aut necessitatibus quas nihil architecto exercitationem.\nQuis mollitia ducimus occaecati.", new DateTime(2023, 6, 23, 13, 46, 12, 103, DateTimeKind.Utc).AddTicks(6053) },
                    { 71L, 168L, "hic", new DateTime(2023, 8, 22, 23, 37, 43, 348, DateTimeKind.Utc).AddTicks(7660), 8L, "Deleniti sequi cupiditate aut eum.\nVoluptatem et perspiciatis voluptatem suscipit voluptas dolores veritatis.\nArchitecto voluptatem neque nesciunt velit animi ipsum eveniet fugiat officia.\nSint aliquam reprehenderit sapiente.\nQui dolorum voluptatem quia.\nVoluptatibus dolorem dolore mollitia modi expedita ab molestiae.", new DateTime(2023, 8, 23, 12, 29, 2, 103, DateTimeKind.Utc).AddTicks(3261) },
                    { 72L, 116L, "Temporibus voluptate voluptatum quod nemo quaerat est exercitationem mollitia sit.", new DateTime(2023, 4, 29, 1, 11, 20, 323, DateTimeKind.Utc).AddTicks(9708), 24L, "Repellendus est eius dolor id dolor sunt. Sint error consectetur earum. Rem est placeat.", new DateTime(2023, 5, 8, 10, 52, 3, 99, DateTimeKind.Utc).AddTicks(2511) },
                    { 73L, 54L, "Ratione in sit voluptatum nostrum.", new DateTime(2022, 7, 13, 12, 3, 41, 977, DateTimeKind.Utc).AddTicks(8363), 27L, "Blanditiis quam totam rerum in et.\nSed perferendis eius temporibus officiis nulla.\nEt amet repellendus ipsa perspiciatis.\nId nihil nesciunt.\nLaboriosam quis architecto id quisquam nihil quibusdam.", new DateTime(2023, 5, 8, 5, 6, 0, 813, DateTimeKind.Utc).AddTicks(3532) },
                    { 74L, 85L, "Dolores aut quis.\nEos sit in.\nEos est eum est magnam maiores.\nAut facere quaerat eos ullam quis perspiciatis officiis.\nNemo quam quia id optio unde.\nSed tenetur ut velit et.", new DateTime(2023, 6, 14, 23, 31, 42, 795, DateTimeKind.Utc).AddTicks(1899), 12L, "et", new DateTime(2023, 8, 10, 14, 3, 7, 803, DateTimeKind.Utc).AddTicks(334) },
                    { 75L, 152L, "Perspiciatis soluta facilis. Voluptatibus voluptatem temporibus provident repellendus. Tempora saepe quod odio veritatis aut dolor. Dolores nostrum minus veniam in. In aspernatur delectus odio sed voluptatum sit ipsa. Nostrum debitis dignissimos sapiente aliquid error sit.", new DateTime(2022, 2, 6, 19, 23, 24, 129, DateTimeKind.Utc).AddTicks(2177), 5L, "Qui eligendi laboriosam repudiandae.\nCommodi temporibus aperiam ut suscipit id veniam quaerat aut.\nAssumenda rerum ullam aliquid asperiores nemo quaerat sit nemo ducimus.\nEt aut molestiae maxime deleniti perspiciatis enim.", new DateTime(2022, 6, 18, 15, 8, 22, 904, DateTimeKind.Utc).AddTicks(9696) },
                    { 76L, 39L, "architecto", new DateTime(2022, 6, 21, 13, 18, 47, 193, DateTimeKind.Utc).AddTicks(1798), 28L, "Impedit maiores aut et laboriosam voluptatem.\nSoluta porro qui molestiae officiis error molestias.\nLaudantium exercitationem maxime.\nEst sequi at inventore ut nesciunt ut non sed.", new DateTime(2022, 10, 5, 8, 11, 41, 107, DateTimeKind.Utc).AddTicks(1832) },
                    { 77L, 106L, "Iusto hic minima doloribus nulla. Omnis ratione rerum. Consectetur et velit quisquam. Sit ut fugiat ad vero molestiae ipsa blanditiis doloribus.", new DateTime(2023, 8, 23, 2, 5, 24, 409, DateTimeKind.Utc).AddTicks(498), 40L, "quae", null },
                    { 78L, 160L, "Accusantium ut laudantium temporibus omnis sunt explicabo repudiandae.\nRecusandae sequi molestiae.", new DateTime(2022, 1, 16, 14, 27, 27, 555, DateTimeKind.Utc).AddTicks(3558), 36L, "Vel rerum minima aperiam iste dolorum qui qui quos nostrum.", null },
                    { 79L, 172L, "Totam atque optio laudantium et sit.\nSit omnis perferendis.\nOccaecati fugiat nam quo alias ratione dolor ut ut dolor.", new DateTime(2023, 8, 22, 20, 48, 3, 489, DateTimeKind.Utc).AddTicks(9548), 1L, "Et at quia necessitatibus delectus.", new DateTime(2023, 8, 23, 3, 4, 53, 896, DateTimeKind.Utc).AddTicks(4295) },
                    { 80L, 122L, "Veniam repudiandae beatae aspernatur delectus quis vero eum odio.\nBlanditiis ut vitae vitae dicta pariatur et dolore veniam illo.\nEt laborum est nostrum.\nQuia ut quia.\nAut dolores nihil eos quisquam ut aspernatur.\nConsequatur aut iste recusandae consectetur aut porro expedita aut.", new DateTime(2023, 4, 21, 9, 26, 26, 400, DateTimeKind.Utc).AddTicks(6528), 6L, "Culpa totam esse. Nobis eius corporis iure aut vero velit tenetur quaerat et. Voluptatem non modi ea. Placeat repellat labore voluptatum dolores ut officiis qui ut. Modi magnam magni vitae asperiores laboriosam quisquam et. Quas non quo repellat.", new DateTime(2023, 7, 14, 3, 12, 12, 70, DateTimeKind.Utc).AddTicks(4931) },
                    { 81L, 68L, "Distinctio error sint nostrum.\nTempora itaque velit ducimus nisi sunt esse.\nQuidem rerum qui quia.", new DateTime(2022, 10, 29, 18, 35, 33, 599, DateTimeKind.Utc).AddTicks(2764), 33L, "Qui ipsa vero et eaque repellat sunt. Necessitatibus natus omnis perferendis sunt molestias error nobis non. Esse aut dolor iure qui neque ea exercitationem eum. Distinctio dolor et blanditiis rerum quibusdam in. Impedit repellat aliquam qui dolores quasi occaecati. Temporibus iste voluptas distinctio quasi quaerat est eum blanditiis quisquam.", new DateTime(2023, 5, 25, 4, 13, 39, 521, DateTimeKind.Utc).AddTicks(9986) },
                    { 82L, 34L, "Quia aut veritatis explicabo magni omnis odit.\nReiciendis numquam sed eum aut quo accusamus quo quis et.", new DateTime(2023, 8, 23, 10, 4, 53, 749, DateTimeKind.Utc).AddTicks(9716), 40L, "Dignissimos in quia fugit.", new DateTime(2023, 8, 23, 10, 16, 51, 486, DateTimeKind.Utc).AddTicks(9052) },
                    { 83L, 160L, "et", new DateTime(2021, 12, 21, 23, 28, 53, 375, DateTimeKind.Utc).AddTicks(584), 39L, "Eos velit eum optio molestiae et iste.\nVeniam reprehenderit nulla.\nMaxime aut totam voluptatum voluptas omnis nostrum alias.\nConsequatur itaque rerum aspernatur.", new DateTime(2023, 1, 18, 1, 5, 25, 250, DateTimeKind.Utc).AddTicks(4239) },
                    { 84L, 96L, "Quam at praesentium consequatur cum quis. Laborum voluptatem sed dolor ut autem. Debitis deserunt eum nobis libero eius.", new DateTime(2021, 8, 20, 7, 34, 14, 24, DateTimeKind.Utc).AddTicks(3961), 21L, "Ab voluptatum rerum animi totam enim.", new DateTime(2022, 11, 10, 16, 23, 10, 505, DateTimeKind.Utc).AddTicks(4609) },
                    { 85L, 131L, "quia", new DateTime(2023, 8, 13, 10, 26, 24, 68, DateTimeKind.Utc).AddTicks(8660), 19L, "aut", new DateTime(2023, 8, 22, 13, 59, 48, 112, DateTimeKind.Utc).AddTicks(7418) },
                    { 86L, 70L, "Soluta quisquam ut et. Vel veniam fugit aut alias repellat. Voluptatibus quia architecto et sed aspernatur voluptas et ipsum. Neque aspernatur fuga qui commodi aperiam. Ipsam voluptatem id commodi voluptatem.", new DateTime(2023, 5, 28, 4, 18, 34, 684, DateTimeKind.Utc).AddTicks(9699), 38L, "debitis", null },
                    { 87L, 97L, "Non quia ducimus.", new DateTime(2023, 8, 5, 10, 32, 33, 633, DateTimeKind.Utc).AddTicks(7711), 24L, "nisi", new DateTime(2023, 8, 10, 16, 58, 57, 890, DateTimeKind.Utc).AddTicks(5369) },
                    { 88L, 73L, "Natus odio exercitationem accusamus. Magnam fugiat quos reiciendis qui odio. Sint velit reiciendis assumenda eaque quia assumenda tempore. Tenetur est dolor iste voluptatem blanditiis. Non minus et rem sit aut ipsam corrupti illo. Eius repellendus distinctio occaecati.", new DateTime(2023, 2, 2, 21, 49, 34, 965, DateTimeKind.Utc).AddTicks(9802), 1L, "molestiae", new DateTime(2023, 4, 19, 15, 17, 3, 588, DateTimeKind.Utc).AddTicks(7254) },
                    { 89L, 197L, "magnam", new DateTime(2023, 1, 11, 7, 54, 27, 347, DateTimeKind.Utc).AddTicks(2501), 39L, "Autem id nam fugit enim. Autem ipsa sapiente et assumenda delectus. Earum aut quos quo nulla.", new DateTime(2023, 8, 4, 4, 33, 6, 548, DateTimeKind.Utc).AddTicks(124) },
                    { 90L, 61L, "Mollitia vitae quis molestias. Dolorem aliquid sit dolor impedit qui. Aut autem asperiores dolorum natus doloribus nesciunt eaque doloremque deleniti.", new DateTime(2023, 7, 25, 8, 33, 57, 131, DateTimeKind.Utc).AddTicks(9031), 6L, "Nemo voluptate pariatur.", new DateTime(2023, 8, 20, 4, 41, 20, 444, DateTimeKind.Utc).AddTicks(9021) },
                    { 91L, 43L, "Impedit facere qui voluptas earum et ipsam voluptas ipsum. Est sapiente neque doloribus reprehenderit aliquid minus est. Dolorem sed officia ad.", new DateTime(2023, 5, 10, 0, 4, 39, 738, DateTimeKind.Utc).AddTicks(1), 40L, "quasi", new DateTime(2023, 6, 10, 11, 14, 43, 619, DateTimeKind.Utc).AddTicks(7241) },
                    { 92L, 135L, "asperiores", new DateTime(2023, 4, 21, 2, 18, 22, 572, DateTimeKind.Utc).AddTicks(8062), 38L, "Accusamus aut modi numquam nihil. Porro voluptatem nisi provident dignissimos nobis ratione repudiandae. Voluptatem magni vel tenetur quo quia deleniti. Eligendi delectus ea animi. Ut libero dolor velit velit impedit. Et molestias rem impedit qui in enim.", null },
                    { 93L, 109L, "Officiis sit consequatur magnam neque reprehenderit eos provident. Sit fugit magnam aut cum. Dolore corrupti odio reprehenderit veniam facilis expedita odit et. Pariatur unde in et tempore. Quibusdam optio tempore autem animi. Rerum unde magni eum reiciendis modi.", new DateTime(2023, 7, 11, 23, 40, 48, 54, DateTimeKind.Utc).AddTicks(9484), 35L, "Exercitationem aliquam sint vel.\nFuga velit atque doloremque numquam architecto enim earum enim.\nVeniam laudantium culpa cum ipsam omnis ullam aut sequi.", new DateTime(2023, 7, 23, 2, 56, 39, 922, DateTimeKind.Utc).AddTicks(7917) },
                    { 94L, 126L, "Neque nesciunt iste nostrum expedita nobis.\nPorro iure non facilis culpa cupiditate beatae consequatur ut.\nAspernatur excepturi rerum aut sit.\nRepellat autem voluptas cupiditate ut qui ratione.", new DateTime(2023, 3, 8, 11, 19, 3, 382, DateTimeKind.Utc).AddTicks(8359), 10L, "Expedita ratione dolor possimus omnis fuga omnis quo sapiente.\nNisi expedita corporis et dolor sed expedita aut et sequi.\nVoluptate qui error iste sint saepe neque animi maiores.", new DateTime(2023, 7, 21, 2, 43, 38, 703, DateTimeKind.Utc).AddTicks(4030) }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "Output", "SubmittedAt" },
                values: new object[,]
                {
                    { 95L, 169L, "Id rem minus molestiae ab sunt. Laboriosam architecto dolores maxime qui. Quia dolor quia.", new DateTime(2023, 8, 13, 9, 44, 49, 537, DateTimeKind.Utc).AddTicks(8974), 9L, "Eius velit quidem. Et fugit aut est porro autem et omnis. Ipsam dolor labore sit nihil accusamus ea illo enim.", new DateTime(2023, 8, 17, 15, 51, 41, 71, DateTimeKind.Utc).AddTicks(362) },
                    { 96L, 175L, "Architecto illum dolorum non consequatur veniam aut quod sed. Architecto in sed delectus sunt quis eveniet velit saepe. Qui repellendus fugit rerum rerum voluptates voluptatibus temporibus ut adipisci.", new DateTime(2023, 7, 8, 3, 24, 31, 649, DateTimeKind.Utc).AddTicks(110), 26L, "inventore", new DateTime(2023, 8, 8, 19, 13, 18, 514, DateTimeKind.Utc).AddTicks(2399) },
                    { 97L, 117L, "Eos officia nemo illo quis expedita est magnam enim reprehenderit. Praesentium voluptatem magni qui nostrum nihil minus. Aspernatur corporis enim assumenda et sunt perferendis est libero libero. Incidunt reiciendis aut repellat quibusdam eos voluptatum veritatis animi nostrum.", new DateTime(2023, 1, 6, 20, 0, 23, 88, DateTimeKind.Utc).AddTicks(8156), 21L, "qui", null },
                    { 98L, 27L, "Consequatur reiciendis voluptate recusandae numquam deserunt.", new DateTime(2023, 8, 12, 22, 19, 11, 394, DateTimeKind.Utc).AddTicks(1612), 17L, "Deleniti enim aut odit qui vel. Perspiciatis ex voluptatem sit. Vel facilis magni est sapiente sunt temporibus. Dolore temporibus aut ad. Distinctio repudiandae qui quae. Ea aut ipsa sunt culpa voluptas velit doloremque ratione eos.", new DateTime(2023, 8, 13, 2, 45, 24, 593, DateTimeKind.Utc).AddTicks(7195) },
                    { 99L, 194L, "Ad dolore magnam sit eaque. Eos est ullam id repudiandae et totam laboriosam. Laudantium et ea quos est veritatis.", new DateTime(2023, 6, 19, 20, 9, 41, 149, DateTimeKind.Utc).AddTicks(7261), 19L, "Molestiae est assumenda sed commodi a aut dolore rem in. Et rerum iure recusandae velit tenetur necessitatibus. Aut fugit modi. Vitae harum sapiente in consequatur qui totam ad.", new DateTime(2023, 7, 28, 2, 10, 17, 325, DateTimeKind.Utc).AddTicks(1965) },
                    { 100L, 110L, "Laboriosam dolores nam ducimus saepe. Cumque dolorem incidunt nihil beatae assumenda quia est rem. Sed reiciendis nobis atque in iste ullam autem consequatur.", new DateTime(2023, 8, 18, 7, 55, 17, 484, DateTimeKind.Utc).AddTicks(8407), 22L, "Fugiat voluptatem autem.", new DateTime(2023, 8, 21, 6, 26, 35, 44, DateTimeKind.Utc).AddTicks(21) },
                    { 101L, 82L, "Omnis dolor quis non eos ipsum.", new DateTime(2023, 5, 15, 9, 6, 35, 927, DateTimeKind.Utc).AddTicks(9633), 16L, "Optio aut optio dolores quas.", new DateTime(2023, 7, 8, 3, 20, 53, 551, DateTimeKind.Utc).AddTicks(2814) },
                    { 102L, 182L, "Dignissimos officia quisquam et quas iusto officiis provident voluptas. Vitae nesciunt commodi molestiae velit in iste. Eum repudiandae quam nemo sed.", new DateTime(2022, 8, 5, 5, 24, 21, 272, DateTimeKind.Utc).AddTicks(7919), 26L, "Illum voluptate eos quis reprehenderit.", new DateTime(2023, 3, 15, 3, 23, 11, 896, DateTimeKind.Utc).AddTicks(7195) },
                    { 103L, 103L, "error", new DateTime(2023, 8, 2, 17, 5, 20, 163, DateTimeKind.Utc).AddTicks(1240), 30L, "harum", new DateTime(2023, 8, 20, 12, 54, 58, 411, DateTimeKind.Utc).AddTicks(2646) },
                    { 104L, 162L, "Sapiente non omnis voluptatibus.\nIn minima qui dolores iure ut provident est.\nMinus neque ducimus.", new DateTime(2023, 7, 4, 2, 15, 39, 591, DateTimeKind.Utc).AddTicks(1718), 8L, "Repellendus explicabo consequatur. Quos et est in culpa qui quo possimus repellat. Ducimus non deserunt velit ut molestias quo consequuntur.", new DateTime(2023, 7, 30, 23, 48, 3, 509, DateTimeKind.Utc).AddTicks(9609) },
                    { 105L, 76L, "Voluptate sint dignissimos ullam aliquid et quia earum.\nEaque placeat aut accusamus soluta tempore.\nProvident perferendis culpa aut similique aperiam consequatur.\nSed expedita saepe velit fuga a nobis earum.\nUt quae velit ipsam cumque quia culpa.", new DateTime(2019, 5, 29, 19, 19, 8, 620, DateTimeKind.Utc).AddTicks(3843), 17L, "Non omnis a quaerat sint dolores fuga alias non consequuntur.\nAut quis molestias omnis aspernatur eligendi ut consequatur voluptatem provident.\nConsequatur quaerat ut quidem voluptatum.\nEum est alias beatae sint.\nArchitecto ut et.", new DateTime(2023, 8, 21, 15, 4, 23, 337, DateTimeKind.Utc).AddTicks(4176) },
                    { 106L, 107L, "Autem tempore est sed id et est quisquam. Iure culpa tenetur optio quis. Expedita ut ipsum labore consequuntur eveniet consectetur quaerat iusto officiis. Exercitationem deserunt itaque voluptatem in deserunt asperiores et dolor. Temporibus id modi inventore reprehenderit ea qui est quos hic. Fugit dolores velit est repellendus sint est.", new DateTime(2022, 8, 8, 12, 57, 38, 292, DateTimeKind.Utc).AddTicks(6275), 22L, "Aliquam nam placeat suscipit perferendis dolor.\nVel maiores a.\nOdit et accusamus.\nRerum sit minus ut est provident earum.\nEnim dolor aspernatur non libero autem beatae nemo officiis in.", new DateTime(2023, 2, 4, 15, 55, 50, 351, DateTimeKind.Utc).AddTicks(9395) },
                    { 107L, 93L, "Error repudiandae molestias doloribus laudantium consequatur sunt.", new DateTime(2022, 7, 3, 10, 40, 12, 447, DateTimeKind.Utc).AddTicks(6739), 19L, "Suscipit tenetur quia asperiores rerum ipsam id odio nesciunt.\nAliquam ut voluptatem voluptates et quia non autem suscipit sed.", null },
                    { 108L, 180L, "Nulla ipsum cupiditate maiores et tenetur maxime ex libero qui.\nEius suscipit aperiam error laudantium voluptatem eius saepe.\nLaboriosam aliquam voluptatum velit quia quas commodi.\nMollitia et hic enim aut aut deserunt maiores iure.", new DateTime(2023, 8, 11, 10, 26, 41, 663, DateTimeKind.Utc).AddTicks(7686), 18L, "Et neque ullam ut rerum porro sed velit.", new DateTime(2023, 8, 19, 4, 48, 59, 438, DateTimeKind.Utc).AddTicks(54) },
                    { 109L, 33L, "Officia eligendi voluptas dolor quia officia officiis.\nNihil quidem iure suscipit provident odio in architecto ab.\nDolorem iusto ipsa porro provident atque.\nNemo molestiae aut.\nId quia unde quae quia consequatur nostrum veritatis.\nMollitia deleniti nostrum ut fugit enim.", new DateTime(2023, 4, 13, 4, 40, 16, 345, DateTimeKind.Utc).AddTicks(6717), 35L, "Nam alias quia qui deserunt sit saepe in iste.", new DateTime(2023, 7, 14, 1, 10, 17, 294, DateTimeKind.Utc).AddTicks(6373) },
                    { 110L, 36L, "Qui excepturi voluptas.\nQuia iusto veniam perferendis natus.\nUt qui quas id modi sequi corporis rerum molestiae et.\nPerferendis autem et facilis et dolores magni numquam quibusdam dolor.\nReprehenderit deleniti nostrum quibusdam atque quos laboriosam similique eaque.\nDoloremque et unde quaerat illo ut itaque est reprehenderit.", new DateTime(2023, 6, 12, 14, 36, 46, 732, DateTimeKind.Utc).AddTicks(5863), 10L, "id", new DateTime(2023, 8, 3, 4, 35, 4, 69, DateTimeKind.Utc).AddTicks(924) },
                    { 111L, 134L, "Voluptatem quibusdam omnis sed provident.\nVoluptatem enim nihil libero consequatur ullam ea laborum.\nVoluptatibus commodi odit.\nAnimi et consectetur cupiditate voluptate id.\nRatione nemo atque.", new DateTime(2023, 6, 13, 14, 14, 36, 238, DateTimeKind.Utc).AddTicks(9676), 35L, "ullam", null },
                    { 112L, 76L, "Perferendis molestias doloremque a sint.", new DateTime(2021, 12, 24, 18, 6, 38, 539, DateTimeKind.Utc).AddTicks(8274), 36L, "culpa", new DateTime(2022, 2, 22, 22, 28, 38, 169, DateTimeKind.Utc).AddTicks(686) },
                    { 113L, 44L, "Aliquam architecto iusto.", new DateTime(2023, 4, 6, 13, 16, 14, 822, DateTimeKind.Utc).AddTicks(9979), 30L, "Sint blanditiis animi porro eum. Quis a et explicabo est. Quo ab sunt. Similique voluptates cum quas dolorem est optio excepturi quia expedita.", new DateTime(2023, 6, 28, 5, 25, 30, 808, DateTimeKind.Utc).AddTicks(2968) },
                    { 114L, 156L, "Quibusdam natus voluptates ipsam consequuntur ipsum est fuga dolore quis. Doloremque fugit corporis doloribus autem molestias cupiditate veniam assumenda provident. Possimus sunt molestias ipsum et sequi ea aperiam voluptatem. Sit et aliquam provident ut magnam dolor quas at. Voluptatum velit id quia.", new DateTime(2023, 8, 5, 20, 23, 42, 930, DateTimeKind.Utc).AddTicks(8386), 30L, "Eius sunt nemo facilis.\nVel consequatur aut illum aut tenetur iste dolores voluptatem non.\nAut cumque enim.\nPraesentium voluptate aliquam.", new DateTime(2023, 8, 11, 16, 45, 12, 447, DateTimeKind.Utc).AddTicks(1905) },
                    { 115L, 66L, "Suscipit harum amet non qui rerum.", new DateTime(2023, 8, 21, 4, 6, 47, 245, DateTimeKind.Utc).AddTicks(7600), 19L, "Nihil magnam est voluptatem dignissimos. Rerum ea earum voluptatem iure dolores rem incidunt vel. Vel fugiat error et illo ab est praesentium sit.", new DateTime(2023, 8, 22, 12, 30, 21, 975, DateTimeKind.Utc).AddTicks(2871) },
                    { 116L, 117L, "Tenetur laboriosam rerum.", new DateTime(2021, 10, 13, 17, 19, 20, 41, DateTimeKind.Utc).AddTicks(1790), 14L, "Consequatur sint eum omnis reprehenderit. A doloribus eos. Consequatur neque voluptas fugit reprehenderit nostrum. Autem natus voluptatem qui aut. Culpa autem illum repellat ipsam ut dolores.", null },
                    { 117L, 168L, "Expedita quidem quas nisi laborum molestiae natus.\nAutem sequi soluta nam doloremque excepturi.", new DateTime(2023, 8, 22, 14, 12, 18, 48, DateTimeKind.Utc).AddTicks(3297), 18L, "rem", new DateTime(2023, 8, 22, 19, 59, 48, 511, DateTimeKind.Utc).AddTicks(2026) },
                    { 118L, 70L, "Ducimus est illo tempora magni assumenda dicta quod.\nAut porro molestiae omnis voluptatum.", new DateTime(2023, 7, 13, 13, 28, 16, 778, DateTimeKind.Utc).AddTicks(3658), 34L, "Sit iure accusantium nulla quidem debitis aut.", new DateTime(2023, 7, 18, 15, 37, 18, 918, DateTimeKind.Utc).AddTicks(8443) },
                    { 119L, 63L, "repellendus", new DateTime(2023, 5, 24, 13, 50, 27, 481, DateTimeKind.Utc).AddTicks(5898), 32L, "Vero saepe rerum accusamus sit ad accusantium.\nItaque voluptate tempora.", new DateTime(2023, 8, 19, 18, 2, 14, 228, DateTimeKind.Utc).AddTicks(4714) },
                    { 120L, 27L, "Perspiciatis quia aut similique fuga. Debitis similique facilis eveniet. Totam veritatis harum laboriosam ut qui deleniti.", new DateTime(2023, 8, 15, 2, 8, 52, 150, DateTimeKind.Utc).AddTicks(1688), 40L, "Alias dolor optio.\nDebitis ipsa eaque pariatur dolorem porro.\nOmnis quis ut vel pariatur quia.\nEst blanditiis nihil vel dolorem.\nEarum neque nesciunt ut consequatur autem.", new DateTime(2023, 8, 17, 6, 43, 14, 496, DateTimeKind.Utc).AddTicks(7920) },
                    { 121L, 11L, "Aspernatur maxime dolor voluptas quisquam.", new DateTime(2023, 4, 2, 15, 47, 54, 948, DateTimeKind.Utc).AddTicks(9996), 39L, "Fugit repudiandae eligendi sunt.", null },
                    { 122L, 60L, "voluptate", new DateTime(2023, 7, 29, 1, 28, 42, 787, DateTimeKind.Utc).AddTicks(8064), 2L, "Non porro aut et eaque.\nQuisquam voluptatem aut aut asperiores hic ut modi sint.\nEt maiores ut maiores enim accusantium.\nQuasi aut possimus sed omnis beatae.\nAt molestiae vel ipsa sunt.", new DateTime(2023, 8, 15, 10, 56, 45, 160, DateTimeKind.Utc).AddTicks(2017) },
                    { 123L, 38L, "Et culpa aspernatur aut excepturi aperiam cumque qui et.", new DateTime(2023, 6, 11, 16, 22, 16, 763, DateTimeKind.Utc).AddTicks(6535), 38L, "Et a quas dolore vel inventore veniam tempore.", null },
                    { 124L, 143L, "et", new DateTime(2023, 7, 24, 4, 23, 26, 540, DateTimeKind.Utc).AddTicks(8533), 20L, "Voluptas corporis numquam non.\nSed necessitatibus ut repellat et dicta.\nQuos eligendi molestiae.\nAmet vitae et dolor.", new DateTime(2023, 7, 24, 16, 7, 44, 791, DateTimeKind.Utc).AddTicks(4216) },
                    { 125L, 26L, "Doloremque officiis perferendis vel non.\nOmnis quia et aspernatur dolores iure.\nVoluptas veritatis eaque qui accusamus.", new DateTime(2022, 6, 14, 21, 52, 29, 227, DateTimeKind.Utc).AddTicks(243), 38L, "Vero tenetur esse officia impedit eligendi consequuntur ut velit.\nAutem voluptates sunt.", new DateTime(2023, 4, 18, 1, 52, 51, 674, DateTimeKind.Utc).AddTicks(1547) },
                    { 126L, 195L, "sint", new DateTime(2023, 4, 15, 6, 31, 45, 837, DateTimeKind.Utc).AddTicks(9496), 26L, "Dicta officia soluta nihil rerum et commodi et.", new DateTime(2023, 6, 17, 18, 49, 8, 692, DateTimeKind.Utc).AddTicks(9534) },
                    { 127L, 20L, "Et quisquam est eius ullam dicta cumque voluptatum repellendus. Recusandae consequatur debitis alias et dicta cupiditate ratione et eum. Veniam ab voluptatum ut assumenda consequatur dolorem impedit vitae assumenda. Et repudiandae consequatur ea. Dicta velit repellat rerum quia.", new DateTime(2023, 8, 22, 17, 29, 59, 209, DateTimeKind.Utc).AddTicks(6056), 28L, "Omnis omnis facilis ex fugit sapiente doloremque illo.\nRerum numquam libero quia soluta provident porro debitis voluptas.\nDolores qui sit delectus harum aliquam illum iusto.\nAccusamus earum cumque rerum enim possimus doloribus eius.\nTotam mollitia quia quod sequi vero doloremque voluptatem.", new DateTime(2023, 8, 23, 10, 52, 24, 335, DateTimeKind.Utc).AddTicks(1205) },
                    { 128L, 74L, "odio", new DateTime(2022, 9, 4, 10, 17, 41, 12, DateTimeKind.Utc).AddTicks(4567), 29L, "Quis qui aut aspernatur exercitationem non exercitationem amet eum amet. Ea esse eligendi enim asperiores velit ipsum. Reprehenderit in quia recusandae atque similique est. Vero qui recusandae. Cumque cumque assumenda et harum.", new DateTime(2023, 4, 1, 17, 32, 43, 100, DateTimeKind.Utc).AddTicks(5064) },
                    { 129L, 141L, "In voluptas soluta porro error nostrum mollitia enim commodi. Velit quae est non. Sunt et iusto animi saepe molestiae officiis.", new DateTime(2023, 7, 17, 9, 34, 53, 543, DateTimeKind.Utc).AddTicks(4047), 37L, "Soluta minima ipsa.\nMaiores rerum est exercitationem explicabo et labore ipsa enim.\nExercitationem suscipit doloribus suscipit corrupti.\nSunt voluptatibus amet quo qui.\nAut consequatur magni.", new DateTime(2023, 7, 18, 13, 26, 26, 309, DateTimeKind.Utc).AddTicks(4086) },
                    { 130L, 41L, "In vel ut aut placeat iste fuga. Non consectetur ratione corporis natus. Ut ipsum exercitationem quas optio sunt quia qui saepe itaque.", new DateTime(2023, 2, 10, 3, 39, 42, 43, DateTimeKind.Utc).AddTicks(8987), 8L, "dolorem", new DateTime(2023, 2, 12, 11, 31, 47, 256, DateTimeKind.Utc).AddTicks(7868) },
                    { 131L, 55L, "Dolor deserunt a modi unde.", new DateTime(2023, 6, 28, 2, 15, 43, 712, DateTimeKind.Utc).AddTicks(7124), 28L, "Ut velit ut eos et sunt voluptatibus. Quas id qui amet. Aliquid aliquam atque voluptas similique qui eum quam est sint. Id sit dolor nisi culpa rerum maxime.", new DateTime(2023, 8, 4, 13, 18, 12, 446, DateTimeKind.Utc).AddTicks(4368) },
                    { 132L, 199L, "Deserunt adipisci eaque et. Non eius commodi molestiae laboriosam. Saepe voluptatibus labore ipsa qui illum.", new DateTime(2023, 8, 5, 12, 11, 16, 836, DateTimeKind.Utc).AddTicks(1380), 10L, "Quae autem quidem.\nIste doloribus praesentium repudiandae reprehenderit est nemo.\nMagnam reprehenderit asperiores amet vel distinctio.", new DateTime(2023, 8, 17, 8, 27, 50, 675, DateTimeKind.Utc).AddTicks(6204) },
                    { 133L, 47L, "odit", new DateTime(2022, 12, 12, 11, 47, 51, 892, DateTimeKind.Utc).AddTicks(3769), 18L, "voluptas", new DateTime(2023, 7, 15, 22, 16, 24, 43, DateTimeKind.Utc).AddTicks(1285) },
                    { 134L, 10L, "Quibusdam iste praesentium molestias.\nEt nemo ut quod doloremque.\nFacilis officia dolore vero omnis sequi odio iure est iure.\nHarum rem quas modi voluptatem soluta.\nVoluptas quae rerum.\nVoluptatem adipisci et et voluptatem.", new DateTime(2023, 7, 28, 4, 19, 42, 441, DateTimeKind.Utc).AddTicks(8521), 4L, "Nobis laborum aut consequuntur. Dolor adipisci autem fuga eligendi dolorem. Nisi quod ex molestiae. Consequatur veritatis quae et delectus ut maiores explicabo laboriosam quia. Tempora quo alias. Praesentium qui nihil fugiat expedita nisi.", new DateTime(2023, 8, 5, 5, 48, 7, 37, DateTimeKind.Utc).AddTicks(9054) },
                    { 135L, 32L, "modi", new DateTime(2023, 6, 15, 9, 33, 15, 958, DateTimeKind.Utc).AddTicks(9675), 28L, "Voluptas nihil itaque ratione saepe rerum qui.\nImpedit doloribus aperiam et at qui voluptatem repellendus.\nLaboriosam omnis rerum aperiam occaecati ut rerum voluptates.\nEius quia officia.\nVoluptas molestiae eum et numquam occaecati ut at officia.\nVel maiores quia libero enim doloremque consectetur.", new DateTime(2023, 7, 16, 21, 6, 10, 209, DateTimeKind.Utc).AddTicks(2178) },
                    { 136L, 12L, "Voluptatem iusto exercitationem labore debitis nam. Magni tenetur modi est nobis. Non et rerum.", new DateTime(2023, 8, 23, 5, 17, 4, 904, DateTimeKind.Utc).AddTicks(7111), 15L, "Dolores ab in mollitia. Debitis dolorem provident dolorem asperiores. Aut cupiditate quis enim saepe. Id et impedit. Omnis vero dolorem dignissimos nihil nisi dolores possimus non impedit. Magni porro debitis odio sint voluptas delectus.", new DateTime(2023, 8, 23, 6, 3, 16, 397, DateTimeKind.Utc).AddTicks(7565) }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "Output", "SubmittedAt" },
                values: new object[,]
                {
                    { 137L, 69L, "Enim maxime aperiam.\nMinima eius eaque minima culpa adipisci incidunt.\nFuga sed est omnis.", new DateTime(2023, 8, 13, 1, 42, 48, 558, DateTimeKind.Utc).AddTicks(9827), 28L, "Facere consequatur dolores officiis reiciendis et rerum aliquam.\nEst blanditiis quisquam excepturi odit dolorum aperiam reprehenderit.\nMaiores et in sunt iusto exercitationem et nobis.", new DateTime(2023, 8, 16, 22, 16, 39, 629, DateTimeKind.Utc).AddTicks(4100) },
                    { 138L, 131L, "Reiciendis officia ad vel accusamus illo ullam rerum sapiente.", new DateTime(2023, 8, 21, 3, 59, 0, 539, DateTimeKind.Utc).AddTicks(3131), 3L, "Consequuntur rem quisquam quae consequatur et exercitationem.", new DateTime(2023, 8, 21, 20, 1, 5, 183, DateTimeKind.Utc).AddTicks(8328) },
                    { 139L, 44L, "Et nostrum iste ullam.", new DateTime(2023, 3, 11, 14, 40, 50, 383, DateTimeKind.Utc).AddTicks(8101), 14L, "Quam repellat officiis sed sint.", new DateTime(2023, 6, 29, 13, 52, 47, 264, DateTimeKind.Utc).AddTicks(936) },
                    { 140L, 193L, "Non ipsum assumenda delectus rerum suscipit quia architecto. Aut doloribus optio non ut. Et voluptas maxime nisi provident aspernatur dicta. Animi amet provident expedita.", new DateTime(2023, 8, 5, 10, 44, 37, 906, DateTimeKind.Utc).AddTicks(5089), 37L, "Iure ut et nulla tenetur dignissimos accusantium vero voluptas.", new DateTime(2023, 8, 9, 7, 32, 31, 140, DateTimeKind.Utc).AddTicks(9328) },
                    { 141L, 188L, "aut", new DateTime(2022, 10, 8, 5, 16, 37, 325, DateTimeKind.Utc).AddTicks(2126), 25L, "Id minima ut itaque ducimus et. Voluptas ipsa ipsum dolor aut cum ipsa. Voluptates quo molestiae at reiciendis. Officia eum odio fugiat vel molestiae. Delectus itaque quisquam ut rerum non cum quos corrupti doloremque.", new DateTime(2023, 4, 18, 18, 5, 7, 69, DateTimeKind.Utc).AddTicks(712) },
                    { 142L, 171L, "Quis veritatis repudiandae quia aliquid tenetur maiores est asperiores.\nSaepe laudantium odit.\nVoluptatum quisquam officiis.\nQui et dolorem.", new DateTime(2023, 8, 9, 18, 31, 31, 675, DateTimeKind.Utc).AddTicks(1660), 26L, "Aut nihil consequatur enim repudiandae.", new DateTime(2023, 8, 19, 8, 41, 25, 415, DateTimeKind.Utc).AddTicks(3671) },
                    { 143L, 93L, "explicabo", new DateTime(2022, 12, 22, 14, 43, 54, 741, DateTimeKind.Utc).AddTicks(2341), 22L, "Omnis officia voluptas commodi suscipit eius nam animi voluptatem molestiae.", new DateTime(2023, 6, 18, 2, 28, 3, 901, DateTimeKind.Utc).AddTicks(7463) },
                    { 144L, 181L, "fugit", new DateTime(2023, 4, 12, 17, 43, 45, 7, DateTimeKind.Utc).AddTicks(6420), 40L, "Odit dolor perspiciatis facilis quasi reiciendis qui velit.\nSimilique architecto aut aut.\nFugit occaecati nobis et eum dolore cumque quia in.\nVoluptas qui consequatur quia est blanditiis omnis qui ad libero.\nReiciendis ipsa quia exercitationem ex beatae magnam in qui.\nSunt aliquid officiis laborum ea iste ab aut sunt.", new DateTime(2023, 7, 9, 4, 47, 40, 888, DateTimeKind.Utc).AddTicks(5841) },
                    { 145L, 197L, "Nobis quod autem.\nCumque dignissimos rerum eos voluptatum natus est voluptatum.\nDucimus consequatur rerum aperiam.\nAut dolores excepturi consequatur.\nQui officia cumque tempore delectus mollitia eum et tempore eum.\nSimilique expedita distinctio.", new DateTime(2023, 4, 25, 18, 8, 26, 65, DateTimeKind.Utc).AddTicks(6650), 37L, "accusamus", new DateTime(2023, 8, 9, 11, 6, 56, 425, DateTimeKind.Utc).AddTicks(2491) },
                    { 146L, 175L, "In perspiciatis explicabo et fuga.", new DateTime(2023, 6, 29, 2, 13, 21, 947, DateTimeKind.Utc).AddTicks(876), 6L, "Quas ipsam quo et sunt repellat est et perspiciatis.\nVoluptatem aspernatur sunt.\nAut voluptatem quis.\nQuia adipisci voluptatem ipsa corrupti voluptates ducimus quaerat corporis.", new DateTime(2023, 8, 10, 7, 19, 55, 31, DateTimeKind.Utc).AddTicks(937) },
                    { 147L, 11L, "unde", new DateTime(2023, 4, 26, 22, 16, 58, 510, DateTimeKind.Utc).AddTicks(9338), 26L, "Deserunt vitae officiis dolores veritatis molestiae autem tempore dolor.\nNostrum nam earum ratione.\nCommodi quia nobis laudantium eum non et fugiat optio.", new DateTime(2023, 6, 4, 23, 0, 56, 843, DateTimeKind.Utc).AddTicks(8109) },
                    { 148L, 27L, "Et sit eligendi dolor qui inventore sunt. Eligendi ut enim. Aut laudantium non. Alias adipisci eum. Sunt nihil necessitatibus reiciendis magnam quia quos aut perspiciatis.", new DateTime(2023, 8, 17, 20, 29, 22, 760, DateTimeKind.Utc).AddTicks(4883), 15L, "Labore optio minus aperiam laborum qui reiciendis repudiandae ut deserunt.", new DateTime(2023, 8, 19, 19, 53, 1, 366, DateTimeKind.Utc).AddTicks(9972) },
                    { 149L, 56L, "Consequatur voluptas error.\nSoluta totam sed.", new DateTime(2020, 9, 20, 7, 7, 4, 858, DateTimeKind.Utc).AddTicks(7793), 13L, "Provident ad similique vitae sunt incidunt voluptatem aperiam.", new DateTime(2021, 8, 22, 21, 8, 32, 583, DateTimeKind.Utc).AddTicks(1535) },
                    { 150L, 100L, "veniam", new DateTime(2023, 7, 31, 10, 23, 55, 913, DateTimeKind.Utc).AddTicks(4678), 13L, "Nostrum velit harum iusto quos enim rerum quia.\nAliquid consequuntur sit voluptatem.\nQuia id ducimus quidem optio excepturi dolor ut quis.", new DateTime(2023, 8, 17, 19, 37, 21, 337, DateTimeKind.Utc).AddTicks(9604) },
                    { 151L, 96L, "Unde velit qui repudiandae et. Aspernatur dolor quaerat. Qui aspernatur ut et. Perferendis mollitia qui dolorem in.", new DateTime(2022, 9, 16, 3, 20, 31, 360, DateTimeKind.Utc).AddTicks(1568), 28L, "A iure dolorem voluptatem earum dicta natus architecto consequatur.\nQuasi culpa id sed sint recusandae et ut at.\nIpsam eum aut in voluptate adipisci.\nSequi nam voluptatibus minus quidem soluta.\nAssumenda non esse assumenda nesciunt optio optio quia.\nEnim ut voluptas.", new DateTime(2022, 11, 26, 22, 16, 31, 687, DateTimeKind.Utc).AddTicks(9389) },
                    { 152L, 82L, "temporibus", new DateTime(2023, 6, 9, 17, 6, 12, 338, DateTimeKind.Utc).AddTicks(3746), 17L, "In culpa nihil voluptates maxime eligendi.", new DateTime(2023, 6, 16, 21, 41, 28, 965, DateTimeKind.Utc).AddTicks(3785) },
                    { 153L, 27L, "Iure sint rerum consectetur nesciunt quod adipisci ex sed. Beatae et repudiandae rem blanditiis consequatur quas. Aliquam numquam consectetur rerum doloribus vero velit consequatur exercitationem. Facilis quia laudantium et maxime impedit nostrum eligendi. Aperiam harum soluta dolore modi. Molestiae fugiat dolore.", new DateTime(2023, 8, 20, 18, 39, 18, 703, DateTimeKind.Utc).AddTicks(7453), 1L, "In deserunt deserunt rerum minus in dignissimos cupiditate doloremque dolor. Ducimus atque quo commodi. Est facere sed. Omnis cupiditate totam non. Ut ut et et accusantium neque tempora. Possimus et culpa officiis temporibus.", new DateTime(2023, 8, 21, 5, 54, 26, 217, DateTimeKind.Utc).AddTicks(4536) },
                    { 154L, 108L, "Ut omnis molestias soluta necessitatibus sit.", new DateTime(2023, 2, 5, 11, 34, 28, 1, DateTimeKind.Utc).AddTicks(4597), 25L, "Facere consectetur ab quia eum et voluptas.", new DateTime(2023, 2, 6, 1, 48, 33, 373, DateTimeKind.Utc).AddTicks(6771) },
                    { 155L, 63L, "Facilis dolor neque eos quod quasi sit deserunt. Numquam qui laboriosam quia praesentium. Dolor voluptas libero et.", new DateTime(2023, 1, 8, 20, 30, 28, 213, DateTimeKind.Utc).AddTicks(5695), 6L, "Praesentium quos quisquam.\nNon enim impedit aliquam.\nIste ratione aperiam et eveniet qui quia facere.\nNihil mollitia repellendus voluptates expedita qui iste.", new DateTime(2023, 2, 14, 4, 54, 14, 307, DateTimeKind.Utc).AddTicks(5150) },
                    { 156L, 199L, "Nesciunt et quia libero eos quos.", new DateTime(2023, 8, 12, 0, 2, 48, 249, DateTimeKind.Utc).AddTicks(3189), 34L, "Aut sunt ipsum adipisci ipsum mollitia voluptas qui occaecati repudiandae.\nAmet ut incidunt unde.", new DateTime(2023, 8, 16, 10, 53, 41, 710, DateTimeKind.Utc).AddTicks(1877) },
                    { 157L, 32L, "Est quis libero.", new DateTime(2023, 3, 10, 2, 22, 21, 439, DateTimeKind.Utc).AddTicks(3164), 33L, "Inventore sit quaerat sapiente ea porro est. Atque sed eum unde maiores. Rerum aperiam quia nostrum consectetur qui omnis fugiat ratione.", new DateTime(2023, 5, 24, 9, 33, 28, 157, DateTimeKind.Utc).AddTicks(1834) },
                    { 158L, 83L, "Exercitationem ea possimus reprehenderit laboriosam et amet. Aliquam blanditiis non aliquid praesentium nemo quo perferendis animi. Expedita dolorem vel nobis voluptas autem. Aperiam praesentium consequatur iure. Vero qui id aut dicta. Tempora iusto corporis eum.", new DateTime(2022, 10, 10, 3, 18, 37, 993, DateTimeKind.Utc).AddTicks(855), 16L, "Itaque error deleniti est quos voluptatem consequatur at praesentium incidunt. Qui laborum sint sapiente dolorem corporis adipisci vel. Doloribus mollitia omnis placeat ducimus modi. Repellendus neque sequi enim incidunt accusamus maxime ut. Maxime ut delectus quos.", new DateTime(2022, 12, 19, 16, 13, 12, 780, DateTimeKind.Utc).AddTicks(5841) },
                    { 159L, 84L, "Ut enim repellat amet iste fugit hic nisi. Minus et enim tempore modi est nemo a corrupti. Et laborum minus nihil tenetur. Rerum perferendis culpa velit.", new DateTime(2023, 5, 10, 1, 59, 35, 74, DateTimeKind.Utc).AddTicks(529), 13L, "Placeat aut sint saepe sequi vitae tempore.\nQuibusdam natus nihil aut odit eligendi qui nesciunt quisquam.\nVoluptatem qui deserunt.\nInventore sed nulla ipsa a tempore aut.\nQui ut accusamus nam cupiditate.\nNihil quibusdam sequi officiis illum occaecati quasi illo.", null },
                    { 160L, 74L, "Enim laudantium maiores. Repudiandae voluptatibus quae aut. Alias et molestiae. Nesciunt eos dignissimos dolorem quia qui. Itaque reprehenderit culpa architecto ut consequatur tempora et adipisci nihil. Dolore excepturi eaque asperiores voluptate soluta eum.", new DateTime(2022, 5, 14, 6, 44, 26, 232, DateTimeKind.Utc).AddTicks(6584), 36L, "Ipsa placeat illum et rerum quidem voluptatem minima. Consequatur rerum ea non dolorem aut. Voluptates animi et possimus et sint cumque qui voluptate sint. Neque minus voluptas repellendus suscipit minus. Eveniet rerum voluptas quia.", new DateTime(2022, 7, 24, 12, 11, 20, 282, DateTimeKind.Utc).AddTicks(3813) },
                    { 161L, 119L, "expedita", new DateTime(2019, 12, 10, 4, 25, 59, 698, DateTimeKind.Utc).AddTicks(3562), 31L, "Fugit occaecati assumenda repellendus debitis delectus magni consequuntur ab. Praesentium quisquam quaerat doloribus perspiciatis facilis. Laborum libero facere enim labore quia nihil. Ut soluta laudantium dolores facilis quod error suscipit. Ab non asperiores alias blanditiis assumenda quae.", new DateTime(2022, 9, 14, 14, 9, 17, 273, DateTimeKind.Utc).AddTicks(3658) },
                    { 162L, 199L, "dicta", new DateTime(2023, 8, 1, 4, 43, 48, 791, DateTimeKind.Utc).AddTicks(3930), 27L, "Quae quia dolorem mollitia officiis in.\nVitae laboriosam veniam.", new DateTime(2023, 8, 16, 9, 24, 40, 993, DateTimeKind.Utc).AddTicks(2568) },
                    { 163L, 168L, "Earum suscipit et qui sequi ut nihil et est.", new DateTime(2023, 8, 23, 3, 58, 2, 505, DateTimeKind.Utc).AddTicks(4389), 36L, "Et mollitia vero asperiores quia eligendi reprehenderit. Repudiandae quia vel non sint fugit atque. Omnis consectetur nam pariatur temporibus ex. Ad corrupti rerum necessitatibus. Quia explicabo modi dolorum aut. Voluptates est consequatur repellat tempora maiores molestias.", new DateTime(2023, 8, 23, 8, 49, 27, 490, DateTimeKind.Utc).AddTicks(2095) },
                    { 164L, 156L, "Quia est praesentium fugit odit id.\nQui qui quas.", new DateTime(2023, 8, 15, 19, 44, 24, 183, DateTimeKind.Utc).AddTicks(680), 23L, "Sed iure illum tenetur consectetur illum commodi quia quibusdam.", new DateTime(2023, 8, 21, 1, 40, 48, 168, DateTimeKind.Utc).AddTicks(8941) },
                    { 165L, 199L, "Facere voluptas eius at at quibusdam. Voluptas molestias alias illum fugiat. Modi dolores itaque sit. Corrupti sit vel sit et ullam. Dolorum placeat rerum dolores iusto voluptas qui iste quasi.", new DateTime(2023, 7, 27, 9, 45, 7, 227, DateTimeKind.Utc).AddTicks(2796), 10L, "Hic ut officia. Amet soluta illum unde autem natus. Veniam voluptatem dolores a molestiae. Similique quam eos et voluptatem incidunt. Molestiae enim architecto.", new DateTime(2023, 7, 31, 23, 45, 10, 681, DateTimeKind.Utc).AddTicks(9240) },
                    { 166L, 191L, "Sed eveniet sunt et. Dicta facere qui veritatis in distinctio rem itaque. Qui inventore et voluptate debitis voluptatem molestiae eaque ut. Repudiandae est in. Aut reprehenderit tenetur non sequi voluptatem voluptas. Non earum est est dolorem similique dolorem.", new DateTime(2023, 8, 5, 16, 12, 11, 150, DateTimeKind.Utc).AddTicks(6379), 6L, "Dolores et mollitia eius libero maiores debitis quisquam corporis.\nEx unde quo.\nMolestias sed aliquid.\nDignissimos magni voluptatem tempore delectus accusamus consequuntur iste.\nAut voluptatibus ea officiis necessitatibus aliquam fugit rem.", new DateTime(2023, 8, 18, 13, 13, 8, 373, DateTimeKind.Utc).AddTicks(3683) },
                    { 167L, 5L, "Voluptas ipsum vel incidunt qui ut delectus numquam dolores quia.\nDeleniti laudantium totam qui sunt fugit ut omnis.\nRerum sed totam nostrum mollitia sunt commodi dolore.\nTenetur rem atque rerum quo velit.", new DateTime(2023, 8, 13, 4, 1, 0, 283, DateTimeKind.Utc).AddTicks(2996), 28L, "Voluptates quo sit qui vel.\nDolorum quidem aut cum tempora autem id fuga.\nOptio perferendis natus cumque sunt quidem nesciunt ut porro.\nPerspiciatis id voluptatem mollitia placeat enim doloremque nisi.\nIusto itaque quisquam aut dolorem temporibus libero a natus.", new DateTime(2023, 8, 16, 18, 31, 42, 450, DateTimeKind.Utc).AddTicks(4234) },
                    { 168L, 32L, "Rerum repellat expedita est facere itaque corporis qui.\nEarum rem eaque quaerat ea adipisci qui vel amet.", new DateTime(2023, 7, 8, 3, 21, 36, 692, DateTimeKind.Utc).AddTicks(6672), 1L, "Minus repudiandae quam cum. Non eligendi architecto adipisci necessitatibus perspiciatis voluptate. Et aperiam nobis. Nobis repellat quam. Doloribus nulla velit et corporis veniam. Modi provident distinctio tempore numquam quos et vitae labore.", new DateTime(2023, 8, 5, 7, 29, 2, 346, DateTimeKind.Utc).AddTicks(817) },
                    { 169L, 112L, "Harum non omnis neque voluptas impedit quas itaque iste quibusdam.\nQuasi eius possimus exercitationem molestiae accusamus pariatur distinctio.", new DateTime(2023, 7, 12, 18, 2, 23, 327, DateTimeKind.Utc).AddTicks(3673), 8L, "officiis", new DateTime(2023, 8, 21, 13, 44, 11, 59, DateTimeKind.Utc).AddTicks(8768) },
                    { 170L, 32L, "non", new DateTime(2023, 7, 9, 5, 33, 6, 875, DateTimeKind.Utc).AddTicks(1097), 33L, "Sunt ut temporibus enim nostrum sunt molestias nam praesentium.", new DateTime(2023, 8, 8, 3, 3, 23, 138, DateTimeKind.Utc).AddTicks(4676) },
                    { 171L, 160L, "aut", new DateTime(2023, 3, 10, 3, 27, 15, 508, DateTimeKind.Utc).AddTicks(4459), 35L, "aliquam", new DateTime(2023, 5, 27, 19, 26, 15, 697, DateTimeKind.Utc).AddTicks(16) },
                    { 172L, 193L, "Est illo non ipsam et aut. Quod impedit qui minima rerum laudantium sed quam. Iure quo quasi eos.", new DateTime(2023, 8, 18, 10, 40, 3, 450, DateTimeKind.Utc).AddTicks(7725), 31L, "Earum molestiae quo libero rem architecto et.\nDelectus eius pariatur dignissimos blanditiis.\nQui non amet et sint maiores.\nQui quasi temporibus distinctio vel sed dicta qui facere.\nEt dolor corrupti ut necessitatibus omnis corporis consectetur libero sunt.\nIpsam qui laborum.", new DateTime(2023, 8, 19, 16, 46, 8, 905, DateTimeKind.Utc).AddTicks(1262) },
                    { 173L, 83L, "Aut quibusdam non ea quae consequatur explicabo. Provident tempora non corporis rerum distinctio delectus. Aliquam et aut debitis.", new DateTime(2022, 9, 10, 14, 52, 20, 738, DateTimeKind.Utc).AddTicks(1556), 30L, "saepe", new DateTime(2022, 11, 10, 13, 4, 51, 406, DateTimeKind.Utc).AddTicks(4688) },
                    { 174L, 22L, "Quo sint accusamus voluptas quis ut eligendi illo non.", new DateTime(2023, 8, 10, 18, 18, 37, 934, DateTimeKind.Utc).AddTicks(7368), 35L, "Magni iste et.\nNihil libero aspernatur.\nNatus doloribus adipisci consequatur adipisci consequatur doloribus veritatis quibusdam perferendis.", new DateTime(2023, 8, 20, 8, 21, 51, 735, DateTimeKind.Utc).AddTicks(7015) },
                    { 175L, 3L, "Expedita omnis ad magni est cumque.\nDolor fugit suscipit itaque enim sint molestias.\nEsse tempora pariatur voluptatem eos est sint voluptates harum.", new DateTime(2023, 5, 18, 11, 36, 53, 975, DateTimeKind.Utc).AddTicks(3650), 39L, "Vero consectetur quam eum eos sunt omnis.", new DateTime(2023, 7, 27, 16, 57, 50, 707, DateTimeKind.Utc).AddTicks(1586) },
                    { 176L, 53L, "Nihil esse aliquam et quia corrupti.", new DateTime(2023, 6, 17, 15, 43, 58, 657, DateTimeKind.Utc).AddTicks(2017), 13L, "commodi", new DateTime(2023, 8, 13, 5, 38, 10, 440, DateTimeKind.Utc).AddTicks(1656) },
                    { 177L, 134L, "Id pariatur facilis officiis non voluptas reprehenderit commodi minus.", new DateTime(2023, 6, 12, 21, 4, 53, 840, DateTimeKind.Utc).AddTicks(1695), 10L, "Unde a dolores praesentium eligendi et qui qui odio.", new DateTime(2023, 7, 19, 6, 53, 42, 34, DateTimeKind.Utc).AddTicks(2462) },
                    { 178L, 16L, "Rerum sequi eos sit optio minima.", new DateTime(2022, 6, 3, 1, 33, 20, 982, DateTimeKind.Utc).AddTicks(4187), 20L, "enim", new DateTime(2022, 6, 27, 13, 16, 53, 203, DateTimeKind.Utc).AddTicks(2281) }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "CreatedBy", "Output", "SubmittedAt" },
                values: new object[,]
                {
                    { 179L, 70L, "ab", new DateTime(2023, 7, 8, 10, 6, 36, 436, DateTimeKind.Utc).AddTicks(6646), 32L, "Itaque eos accusamus voluptas similique.\nVoluptatem similique ipsa culpa architecto deserunt dolores aut.", new DateTime(2023, 7, 17, 22, 56, 57, 210, DateTimeKind.Utc).AddTicks(4789) },
                    { 180L, 91L, "Enim consequatur modi ut.", new DateTime(2022, 5, 12, 19, 25, 42, 228, DateTimeKind.Utc).AddTicks(5470), 38L, "Dolorem velit sit qui beatae incidunt fugiat.\nEt ipsa officia qui facere.\nLabore error velit ut.", new DateTime(2022, 10, 3, 13, 21, 55, 536, DateTimeKind.Utc).AddTicks(9244) },
                    { 181L, 197L, "Consequuntur libero voluptas facilis officiis tenetur rem minus. Harum in non excepturi ut ut. Quisquam praesentium et qui cumque voluptatem doloremque. Voluptatem quasi libero quibusdam. Eos rerum suscipit dolores ea.", new DateTime(2023, 2, 16, 18, 59, 27, 70, DateTimeKind.Utc).AddTicks(5704), 39L, "dolorem", new DateTime(2023, 6, 15, 21, 47, 35, 953, DateTimeKind.Utc).AddTicks(6739) },
                    { 182L, 128L, "qui", new DateTime(2023, 7, 16, 16, 20, 2, 768, DateTimeKind.Utc).AddTicks(3505), 5L, "Iure ipsa sit facere officia.\nTempora et voluptatem.", new DateTime(2023, 8, 9, 3, 41, 12, 635, DateTimeKind.Utc).AddTicks(5226) },
                    { 183L, 68L, "Totam ut placeat veritatis et sequi quibusdam aut.", new DateTime(2023, 6, 2, 21, 34, 58, 983, DateTimeKind.Utc).AddTicks(4074), 35L, "Maiores illo soluta exercitationem nihil.\nFacere soluta et.\nExcepturi ad illum aut sunt laboriosam alias.\nOfficiis commodi quis aliquid repellat omnis amet.\nAut quo ut et vitae adipisci pariatur omnis et.", new DateTime(2023, 6, 20, 4, 43, 27, 354, DateTimeKind.Utc).AddTicks(2302) },
                    { 184L, 200L, "Inventore a ut non tenetur eos vel quibusdam. Nobis autem sint harum illo magni odit. Voluptatibus repudiandae ducimus eum non ipsam nihil.", new DateTime(2023, 8, 4, 7, 26, 9, 28, DateTimeKind.Utc).AddTicks(5817), 29L, "accusamus", new DateTime(2023, 8, 10, 10, 54, 41, 8, DateTimeKind.Utc).AddTicks(3701) },
                    { 185L, 90L, "Eligendi earum mollitia et non.", new DateTime(2023, 5, 13, 19, 1, 34, 343, DateTimeKind.Utc).AddTicks(3447), 17L, "reiciendis", new DateTime(2023, 7, 4, 18, 40, 44, 263, DateTimeKind.Utc).AddTicks(8347) },
                    { 186L, 119L, "Non nihil est sit a tempore enim non rerum. Necessitatibus dicta nesciunt illum id magnam vel aut nam. Fugit sed sit harum fugiat recusandae accusantium itaque perferendis aut. Sit quaerat saepe temporibus atque tempore at ut culpa nihil. Tenetur vitae ipsa veritatis qui id.", new DateTime(2022, 5, 10, 22, 13, 36, 993, DateTimeKind.Utc).AddTicks(3434), 5L, "Deserunt adipisci libero optio cum cupiditate perferendis sit. Est suscipit excepturi. Necessitatibus impedit dolorem voluptatem doloremque quia culpa a laboriosam. Sint nihil culpa.", new DateTime(2022, 7, 3, 13, 8, 19, 101, DateTimeKind.Utc).AddTicks(9012) },
                    { 187L, 119L, "facere", new DateTime(2019, 2, 10, 3, 26, 56, 280, DateTimeKind.Utc).AddTicks(5459), 40L, "ex", new DateTime(2019, 8, 14, 0, 15, 22, 161, DateTimeKind.Utc).AddTicks(1874) },
                    { 188L, 33L, "Recusandae sunt eveniet sed adipisci sit ut.\nIn quisquam nobis quod aliquam odit sequi.\nExplicabo quam quam velit et tempora labore omnis qui provident.\nUt et sint neque et quis dolorem sequi.\nConsequatur laudantium voluptates quaerat sed iste.", new DateTime(2023, 5, 8, 12, 30, 20, 981, DateTimeKind.Utc).AddTicks(9238), 21L, "Commodi aut debitis. Quia sit ut ut quaerat laborum. Pariatur dolores iure distinctio laborum repellat quos distinctio. Voluptas blanditiis molestiae tenetur est sit harum.", new DateTime(2023, 6, 14, 23, 27, 34, 151, DateTimeKind.Utc).AddTicks(3061) },
                    { 189L, 129L, "Molestiae voluptas quibusdam eos ut. Nobis accusantium numquam dignissimos in tempore architecto. Est sed et amet. Corporis et tempore et quo voluptatem eum accusantium architecto. Quaerat voluptas maiores odio voluptatem ut.", new DateTime(2023, 8, 8, 6, 5, 46, 158, DateTimeKind.Utc).AddTicks(8709), 25L, "Possimus itaque beatae et numquam excepturi ratione excepturi. Ut excepturi laboriosam veniam consectetur quae reprehenderit. Facere sint dicta voluptas sint deserunt.", new DateTime(2023, 8, 10, 1, 2, 56, 144, DateTimeKind.Utc).AddTicks(5319) },
                    { 190L, 88L, "illo", new DateTime(2022, 12, 24, 11, 19, 19, 112, DateTimeKind.Utc).AddTicks(8749), 14L, "debitis", new DateTime(2023, 7, 25, 7, 54, 49, 127, DateTimeKind.Utc).AddTicks(7870) },
                    { 191L, 188L, "Velit error excepturi dolorem omnis natus.", new DateTime(2022, 5, 15, 13, 49, 0, 572, DateTimeKind.Utc).AddTicks(1416), 6L, "reiciendis", new DateTime(2023, 1, 31, 13, 59, 15, 563, DateTimeKind.Utc).AddTicks(4808) },
                    { 192L, 6L, "Labore nisi totam temporibus voluptatem reprehenderit iste minima quas. Harum alias nulla voluptas dolorem. Maiores exercitationem quas occaecati.", new DateTime(2022, 8, 17, 13, 37, 55, 92, DateTimeKind.Utc).AddTicks(9285), 22L, "Fugiat ab mollitia aut voluptatibus et amet quos.", new DateTime(2023, 4, 14, 17, 1, 15, 594, DateTimeKind.Utc).AddTicks(2771) },
                    { 193L, 62L, "Adipisci sit aut incidunt quia quas molestiae quae.\nQuis est debitis in.\nNisi deserunt praesentium omnis.\nEsse adipisci nostrum velit ut explicabo aut.\nId dolor velit in harum velit ullam aut.", new DateTime(2023, 8, 19, 17, 28, 25, 773, DateTimeKind.Utc).AddTicks(2542), 36L, "Explicabo commodi voluptas consequuntur omnis nulla est.", new DateTime(2023, 8, 21, 1, 22, 16, 998, DateTimeKind.Utc).AddTicks(4919) },
                    { 194L, 37L, "Accusantium nisi quos et est odit eos ipsam.\nVoluptatem voluptatem recusandae quibusdam eos totam minima vitae vero.", new DateTime(2019, 10, 12, 8, 29, 52, 776, DateTimeKind.Utc).AddTicks(5618), 8L, "consequatur", new DateTime(2022, 4, 5, 20, 26, 47, 242, DateTimeKind.Utc).AddTicks(6958) },
                    { 195L, 45L, "Explicabo autem et voluptatem perferendis itaque est quasi aut. Debitis ea tenetur ab. Aut quis repudiandae vel quod voluptas quidem.", new DateTime(2023, 8, 16, 20, 17, 46, 807, DateTimeKind.Utc).AddTicks(7505), 15L, "Unde illum qui nulla illo pariatur praesentium aut dicta.", new DateTime(2023, 8, 19, 12, 47, 29, 595, DateTimeKind.Utc).AddTicks(8503) },
                    { 196L, 82L, "In voluptatum rerum reiciendis cum velit dolores. Atque ex provident maiores minima rerum blanditiis aut. Id adipisci atque. Sit tenetur quod architecto voluptatem animi dolorem eos ea. Asperiores tenetur non dignissimos. Vel pariatur officiis voluptate.", new DateTime(2023, 7, 26, 5, 56, 35, 304, DateTimeKind.Utc).AddTicks(4955), 33L, "Similique dolores molestiae illum.", new DateTime(2023, 8, 3, 16, 26, 34, 312, DateTimeKind.Utc).AddTicks(7203) },
                    { 197L, 89L, "Assumenda vel occaecati ratione et.\nConsequatur enim et vitae sit.\nAperiam et quas nostrum qui et minus.\nDolorem iste ducimus praesentium vel aliquam molestias adipisci inventore.\nAspernatur nam enim culpa odio veritatis facilis ut earum.", new DateTime(2023, 7, 13, 9, 53, 4, 836, DateTimeKind.Utc).AddTicks(6746), 26L, "Impedit corrupti enim.\nRepellendus quod ut voluptatum similique veritatis.\nItaque quia numquam recusandae veritatis sit et pariatur laborum.\nDistinctio maiores occaecati enim qui.", new DateTime(2023, 8, 2, 18, 48, 45, 517, DateTimeKind.Utc).AddTicks(2680) },
                    { 198L, 30L, "amet", new DateTime(2023, 7, 15, 10, 7, 17, 927, DateTimeKind.Utc).AddTicks(1267), 39L, "nulla", new DateTime(2023, 8, 2, 18, 18, 54, 816, DateTimeKind.Utc).AddTicks(6248) },
                    { 199L, 152L, "Enim aperiam rerum sit autem tempora consequuntur.", new DateTime(2022, 5, 24, 15, 46, 53, 825, DateTimeKind.Utc).AddTicks(7028), 34L, "Libero maiores possimus ab quas.\nFugit sit fugit praesentium dolorem architecto omnis error facere.\nConsequatur aut repudiandae.\nSit vitae quia libero iure hic harum itaque beatae in.\nEt deserunt perferendis unde sed.\nQuibusdam blanditiis ex enim dolores est.", new DateTime(2022, 9, 25, 20, 35, 15, 525, DateTimeKind.Utc).AddTicks(465) },
                    { 200L, 183L, "Sequi libero alias odit officia distinctio dicta distinctio omnis.\nDolor aliquam porro qui.\nDeleniti placeat perferendis omnis rerum sunt sint iste deserunt.", new DateTime(2023, 6, 11, 20, 26, 26, 411, DateTimeKind.Utc).AddTicks(6150), 20L, "et", new DateTime(2023, 7, 31, 4, 20, 47, 105, DateTimeKind.Utc).AddTicks(4573) }
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
