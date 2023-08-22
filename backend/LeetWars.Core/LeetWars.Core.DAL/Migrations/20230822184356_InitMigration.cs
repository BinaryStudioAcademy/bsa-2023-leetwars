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
                    { 1L, new DateTime(1994, 9, 19, 14, 43, 14, 805, DateTimeKind.Unspecified).AddTicks(1148), 30, "Josue41@hotmail.com", "Grayson", "/usr/share", false, false, "Tremblay", "ygqol224slj4n7vaewrhixj87comuj5x", new DateTime(2019, 5, 9, 3, 33, 56, 988, DateTimeKind.Unspecified).AddTicks(3596), 2, 0, 7, 31832L, "Emmalee_West0" },
                    { 2L, new DateTime(1983, 2, 14, 15, 21, 45, 373, DateTimeKind.Unspecified).AddTicks(3517), 23, "Aniya74@gmail.com", "Sherman", "/sbin", false, false, "Gottlieb", "xc0xih8ega8gml413k24v2mnqw01jkbf", new DateTime(2020, 2, 17, 11, 16, 58, 420, DateTimeKind.Unspecified).AddTicks(6981), 1, 2, -9, 85353L, "Quinton301" },
                    { 3L, new DateTime(1989, 2, 11, 0, 0, 21, 150, DateTimeKind.Unspecified).AddTicks(4385), 21, "Chad_Bode5@yahoo.com", "Jarvis", "/System", false, true, "Wunsch", "ovpd7mg6vwys190zw8d8ke20ld5fvgld", new DateTime(2018, 12, 14, 20, 44, 38, 289, DateTimeKind.Unspecified).AddTicks(9307), 3, 2, 6, 77452L, "Lee_Beatty2" },
                    { 4L, new DateTime(1987, 10, 1, 18, 4, 10, 927, DateTimeKind.Unspecified).AddTicks(136), 50, "Kian72@yahoo.com", "Faustino", "/sbin", false, false, "Moore", "t1asorug0bealf9laj4ltu8szec1pvo9", new DateTime(2022, 1, 23, 11, 57, 16, 418, DateTimeKind.Unspecified).AddTicks(2555), 3, 2, 5, 94934L, "Ashtyn313" },
                    { 5L, new DateTime(1998, 11, 11, 16, 55, 52, 121, DateTimeKind.Unspecified).AddTicks(5231), 12, "Rupert.Greenholt@gmail.com", "Breana", "/etc/mail", false, true, "Hickle", "qztisafsq5n4frvk8bs4toh7k7cj0uk1", new DateTime(2020, 5, 21, 18, 56, 31, 927, DateTimeKind.Unspecified).AddTicks(6252), 2, 0, 2, 85121L, "Alden.Ebert84" },
                    { 6L, new DateTime(1980, 2, 21, 11, 12, 39, 214, DateTimeKind.Unspecified).AddTicks(3411), 35, "Tomasa_Kreiger@gmail.com", "Zelda", "/usr/ports", false, false, "Howell", "xb2hmylyvswlmxpoand6djta9thu2lj8", new DateTime(2020, 3, 16, 23, 28, 3, 991, DateTimeKind.Unspecified).AddTicks(946), 0, 1, -2, 8764L, "Cordell345" },
                    { 7L, new DateTime(1998, 4, 18, 4, 6, 59, 68, DateTimeKind.Unspecified).AddTicks(1288), 42, "Luna_Medhurst@gmail.com", "Javonte", "/lib", false, false, "Pouros", "sheis7sgqw98nzfnao7dhmvulsn2b7gz", new DateTime(2019, 10, 3, 7, 17, 30, 951, DateTimeKind.Unspecified).AddTicks(4107), 3, 3, 5, 90217L, "Courtney_Kun6" },
                    { 8L, new DateTime(1986, 12, 26, 16, 27, 28, 421, DateTimeKind.Unspecified).AddTicks(4895), 16, "Johnathon.Hermiston43@yahoo.com", "Imelda", "/usr/libdata", false, true, "Schmitt", "5ljwzkq4jfaio5psdgcv1tbfmy0ptukk", new DateTime(2021, 10, 12, 20, 53, 51, 198, DateTimeKind.Unspecified).AddTicks(9022), 0, 2, -9, 98986L, "Kirstin_John7" },
                    { 9L, new DateTime(1997, 9, 9, 23, 56, 47, 65, DateTimeKind.Unspecified).AddTicks(577), 28, "Lowell.Rempel7@yahoo.com", "Elody", "/sbin", false, true, "Gerhold", "qca3a1j0bpvq8gikge714qk6b6sj23v3", new DateTime(2021, 9, 28, 2, 4, 22, 741, DateTimeKind.Unspecified).AddTicks(4232), 2, 1, -4, 22973L, "Bruce.Christ8" },
                    { 10L, new DateTime(1990, 5, 6, 19, 58, 45, 360, DateTimeKind.Unspecified).AddTicks(2184), 18, "Victoria57@hotmail.com", "Muhammad", "/lib", false, true, "Wyman", "1f0r4s380y8tr8iy6q7o0aeq0wwz3l0s", new DateTime(2020, 9, 29, 23, 48, 51, 840, DateTimeKind.Unspecified).AddTicks(2711), 3, 1, -5, 55951L, "Kelli.Gislas9" },
                    { 11L, new DateTime(1985, 12, 31, 9, 40, 6, 340, DateTimeKind.Unspecified).AddTicks(118), 43, "Nico6@hotmail.com", "Wilburn", "/usr/src", false, true, "Rohan", "8q09r7w35exfiwr7gm0s20jmz9fqabtp", new DateTime(2020, 2, 16, 15, 43, 28, 596, DateTimeKind.Unspecified).AddTicks(6204), 1, 2, 6, 23374L, "Otto.Rogahn110" },
                    { 12L, new DateTime(1989, 1, 25, 4, 26, 0, 71, DateTimeKind.Unspecified).AddTicks(3954), 38, "Gina15@yahoo.com", "Jovanny", "/mnt", false, false, "Simonis", "9t76e9hs5stl8o391w8th8j77ro0ucs1", new DateTime(2018, 4, 30, 22, 3, 22, 391, DateTimeKind.Unspecified).AddTicks(9956), 1, 1, 3, 53333L, "Esteban2311" },
                    { 13L, new DateTime(1986, 12, 24, 22, 46, 36, 200, DateTimeKind.Unspecified).AddTicks(5088), 57, "Elmore.Heaney@gmail.com", "Mireya", "/net", false, true, "Howell", "t190znkgys0ryt8hui19irut6h42vj07", new DateTime(2018, 12, 28, 10, 46, 33, 494, DateTimeKind.Unspecified).AddTicks(6088), 1, 2, -1, 42531L, "Mike_Ankundi12" },
                    { 14L, new DateTime(1991, 9, 21, 4, 2, 14, 275, DateTimeKind.Unspecified).AddTicks(7486), 10, "Green_Pacocha@hotmail.com", "Robbie", "/root", false, true, "Runolfsson", "st16gthiilfsssm8s5eytvo094ypcn72", new DateTime(2016, 6, 4, 6, 13, 39, 555, DateTimeKind.Unspecified).AddTicks(65), 2, 0, 0, 27050L, "Krystina7713" },
                    { 15L, new DateTime(1988, 2, 3, 23, 22, 38, 469, DateTimeKind.Unspecified).AddTicks(1276), 0, "Kassandra.Morissette@gmail.com", "May", "/usr/sbin", false, true, "Swift", "qx40wbvs6uecm4m4oi9tw4zgnh6iks1o", new DateTime(2021, 7, 21, 11, 8, 37, 137, DateTimeKind.Unspecified).AddTicks(6557), 1, 3, -6, 53331L, "Darryl_Heath14" },
                    { 16L, new DateTime(1986, 4, 16, 3, 40, 6, 406, DateTimeKind.Unspecified).AddTicks(3864), 23, "Alexandro26@hotmail.com", "Dorcas", "/lib", false, false, "Lemke", "ylxoce5d7dtqca6dq54p3mlzmobdpjxx", new DateTime(2019, 2, 22, 9, 50, 34, 936, DateTimeKind.Unspecified).AddTicks(8133), 3, 1, -4, 70612L, "Ahmed.Smitha15" },
                    { 17L, new DateTime(1980, 12, 15, 3, 10, 33, 897, DateTimeKind.Unspecified).AddTicks(2309), 13, "Lois71@hotmail.com", "Foster", "/var/tmp", false, true, "Beer", "k5b0y2o3roofvbkxu20z6aqkfri1fr98", new DateTime(2019, 9, 28, 18, 57, 17, 637, DateTimeKind.Unspecified).AddTicks(1782), 3, 3, 3, 32523L, "Caroline6416" },
                    { 18L, new DateTime(1984, 4, 17, 21, 41, 0, 882, DateTimeKind.Unspecified).AddTicks(3633), 55, "Verda.Schinner@gmail.com", "Salma", "/usr/lib", false, true, "O'Kon", "s9fql7knozeg7whxviqdhbn17pfpxgyw", new DateTime(2016, 7, 16, 15, 16, 56, 421, DateTimeKind.Unspecified).AddTicks(47), 1, 0, 2, 30333L, "Maryam.Hodki17" },
                    { 19L, new DateTime(1999, 12, 10, 20, 52, 0, 0, DateTimeKind.Unspecified).AddTicks(1038), 18, "Carmel60@gmail.com", "Roderick", "/usr/src", false, false, "Dibbert", "8hmejvrup71hiqqwqkrlbn4zr96zeseo", new DateTime(2018, 11, 17, 16, 41, 33, 469, DateTimeKind.Unspecified).AddTicks(1646), 0, 0, 5, 81476L, "Mae_Grady4318" },
                    { 20L, new DateTime(1986, 7, 12, 8, 36, 51, 874, DateTimeKind.Unspecified).AddTicks(5322), 9, "Gussie_Kemmer@hotmail.com", "Crystel", "/var/yp", false, true, "Cassin", "lldnm9prgxtd6gh1ywtx83i5cyueazcw", new DateTime(2017, 2, 23, 19, 43, 16, 898, DateTimeKind.Unspecified).AddTicks(6562), 1, 1, 4, 30368L, "Wilhelmine.M19" },
                    { 21L, new DateTime(2000, 6, 28, 7, 15, 24, 270, DateTimeKind.Unspecified).AddTicks(7851), 48, "Elise_OKon@hotmail.com", "Letha", "/usr", false, true, "Runolfsson", "lrh28aofaggkw7uzuqnqbrmbby3cv3mj", new DateTime(2019, 11, 2, 15, 0, 6, 11, DateTimeKind.Unspecified).AddTicks(5252), 0, 2, 2, 56827L, "Colleen6120" },
                    { 22L, new DateTime(1995, 7, 11, 23, 33, 0, 654, DateTimeKind.Unspecified).AddTicks(2464), 42, "Nikko_Wyman@gmail.com", "Antonia", "/usr/local/src", false, false, "Stanton", "sct55q96bj7twqoma0anm89xg0pp1lwn", new DateTime(2022, 4, 7, 3, 35, 44, 818, DateTimeKind.Unspecified).AddTicks(7289), 2, 0, 10, 42754L, "Caleigh.Hale21" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Country", "Email", "FirstName", "ImagePath", "IsBanned", "IsSubscribed", "LastName", "OAuthToken", "RegisteredAt", "Sex", "Status", "Timezone", "TotalScore", "UserName" },
                values: new object[,]
                {
                    { 23L, new DateTime(1990, 2, 22, 13, 46, 1, 853, DateTimeKind.Unspecified).AddTicks(3052), 54, "Lavada_Jones@hotmail.com", "Richmond", "/etc/ppp", false, true, "Dare", "96k3wo41k5qnk35pswu6gus1qa5mt3m4", new DateTime(2021, 3, 13, 10, 35, 34, 496, DateTimeKind.Unspecified).AddTicks(9276), 1, 1, 2, 79015L, "Julien4022" },
                    { 24L, new DateTime(1984, 3, 15, 11, 31, 27, 753, DateTimeKind.Unspecified).AddTicks(8651), 30, "Chloe_Schowalter@gmail.com", "Norberto", "/usr/libexec", false, true, "Gerlach", "pfdidmii8gilq3nl7z23ipk4lu7xdma3", new DateTime(2017, 11, 1, 12, 43, 9, 603, DateTimeKind.Unspecified).AddTicks(2374), 0, 3, -12, 97871L, "Marjory.Kilb23" },
                    { 25L, new DateTime(1999, 12, 5, 8, 6, 6, 642, DateTimeKind.Unspecified).AddTicks(6168), 0, "Luigi.Windler50@yahoo.com", "Carey", "/Library", false, true, "Leannon", "0u9wifk5m5f3kcme8kuvc6ryrp7dqnhm", new DateTime(2021, 1, 25, 7, 56, 15, 905, DateTimeKind.Unspecified).AddTicks(8945), 3, 2, -8, 8240L, "Prince.Crist24" },
                    { 26L, new DateTime(1982, 2, 28, 6, 20, 17, 944, DateTimeKind.Unspecified).AddTicks(9232), 1, "Delmer61@hotmail.com", "Abbie", "/tmp", false, true, "Turner", "wu2a4t86fyos3plgg5o27c94814kghx8", new DateTime(2020, 4, 1, 12, 49, 30, 392, DateTimeKind.Unspecified).AddTicks(5289), 1, 3, 10, 66024L, "Loyal_Reilly25" },
                    { 27L, new DateTime(1986, 10, 10, 14, 1, 59, 54, DateTimeKind.Unspecified).AddTicks(9936), 39, "Jason_Schmitt@gmail.com", "Jared", "/root", false, false, "Mayert", "gjkx13onqx0frqqpcs7kiqsb6bd9izod", new DateTime(2019, 2, 24, 8, 34, 16, 288, DateTimeKind.Unspecified).AddTicks(9632), 1, 3, -2, 16431L, "Velva_Will8626" },
                    { 28L, new DateTime(1983, 12, 1, 7, 0, 10, 396, DateTimeKind.Unspecified).AddTicks(3612), 39, "Bryana1@hotmail.com", "Sigmund", "/opt", false, true, "Roberts", "z0qr8rqpe5q9mratae66c5mz5dn5g47u", new DateTime(2022, 8, 25, 6, 57, 46, 549, DateTimeKind.Unspecified).AddTicks(4534), 0, 2, -1, 66677L, "Lorenza.Whit27" },
                    { 29L, new DateTime(1981, 3, 15, 11, 41, 10, 617, DateTimeKind.Unspecified).AddTicks(8131), 53, "Samson_Bradtke94@hotmail.com", "Caitlyn", "/usr/ports", true, true, "Abshire", "0teqmv3l99ywll2tmmbsb65vzr1waca9", new DateTime(2018, 4, 21, 20, 7, 44, 301, DateTimeKind.Unspecified).AddTicks(2908), 3, 3, 9, 44297L, "Nathan.Zieme28" },
                    { 30L, new DateTime(1983, 3, 21, 5, 11, 47, 419, DateTimeKind.Unspecified).AddTicks(5606), 2, "Marjolaine.Bashirian@hotmail.com", "Edmond", "/sys", false, true, "Towne", "6juoirut7awzozrm7r6k4h0af2v0c79w", new DateTime(2017, 7, 20, 9, 55, 34, 162, DateTimeKind.Unspecified).AddTicks(9532), 2, 2, -5, 18829L, "Moriah7729" },
                    { 31L, new DateTime(1996, 6, 14, 0, 11, 22, 542, DateTimeKind.Unspecified).AddTicks(9487), 36, "Astrid27@hotmail.com", "Franz", "/Users", false, true, "Boyer", "hpij8fvuhz10y09hg18idrd1bpyr08rz", new DateTime(2022, 3, 1, 3, 42, 27, 455, DateTimeKind.Unspecified).AddTicks(2090), 1, 0, -12, 61822L, "Zachary.Yund30" },
                    { 32L, new DateTime(1995, 2, 23, 13, 22, 54, 248, DateTimeKind.Unspecified).AddTicks(3185), 56, "Josh.Mueller@hotmail.com", "Frankie", "/usr/libexec", false, true, "Strosin", "apbh7jh3t882ejs8pu35p0w92cwtxhmb", new DateTime(2020, 8, 11, 20, 55, 33, 44, DateTimeKind.Unspecified).AddTicks(7826), 3, 0, 0, 30014L, "Beau_Wiegand31" },
                    { 33L, new DateTime(1994, 5, 9, 18, 8, 34, 386, DateTimeKind.Unspecified).AddTicks(2969), 4, "Lia.Senger88@gmail.com", "Megane", "/dev", false, true, "Lesch", "9t1evmn6cmw3jfbiegojzh9e6roibouz", new DateTime(2023, 3, 16, 1, 36, 43, 850, DateTimeKind.Unspecified).AddTicks(7066), 3, 3, 4, 89487L, "Linnie_Strac32" },
                    { 34L, new DateTime(1982, 4, 25, 10, 57, 10, 329, DateTimeKind.Unspecified).AddTicks(953), 18, "Bertha66@gmail.com", "Kailyn", "/Network", false, true, "Dicki", "2sjm74y5uorx0slntixwlga9geqvi78j", new DateTime(2022, 3, 14, 20, 18, 31, 954, DateTimeKind.Unspecified).AddTicks(6414), 2, 2, -11, 5835L, "Abigail.Whit33" },
                    { 35L, new DateTime(1981, 11, 1, 20, 35, 45, 653, DateTimeKind.Unspecified).AddTicks(3867), 18, "Cordie92@gmail.com", "Paris", "/opt/bin", false, false, "Parker", "rqmia5te2nnf8ma2jjrtk3trr0gmho5w", new DateTime(2022, 6, 14, 18, 25, 25, 41, DateTimeKind.Unspecified).AddTicks(1177), 0, 2, 12, 53974L, "Josephine7634" },
                    { 36L, new DateTime(1981, 2, 15, 11, 41, 33, 219, DateTimeKind.Unspecified).AddTicks(8229), 22, "Jany_Dach52@yahoo.com", "Zane", "/etc/defaults", false, true, "Rempel", "tnxuq9p7wehq422bz0qvzkdoqo015bzd", new DateTime(2017, 5, 30, 9, 40, 15, 786, DateTimeKind.Unspecified).AddTicks(6431), 0, 1, 10, 24918L, "Brock035" },
                    { 37L, new DateTime(1981, 8, 22, 0, 34, 40, 735, DateTimeKind.Unspecified).AddTicks(7276), 19, "Estella66@hotmail.com", "Louvenia", "/boot/defaults", false, true, "Bosco", "n49a9328n2le4cwq59q76ocg10gp3pz4", new DateTime(2021, 8, 8, 13, 46, 55, 366, DateTimeKind.Unspecified).AddTicks(2120), 1, 2, -10, 60999L, "Emely9636" },
                    { 38L, new DateTime(1986, 1, 13, 18, 57, 16, 684, DateTimeKind.Unspecified).AddTicks(1068), 51, "Cody.Daniel46@gmail.com", "Elmo", "/usr/src", false, true, "Legros", "zrs88mc5x2g3tmtnjgkgv5ry5hjnvj2o", new DateTime(2018, 12, 26, 16, 49, 7, 880, DateTimeKind.Unspecified).AddTicks(4212), 1, 2, -5, 37265L, "Krista_Lang937" },
                    { 39L, new DateTime(1986, 6, 5, 9, 59, 4, 567, DateTimeKind.Unspecified).AddTicks(9161), 48, "Kariane_Muller@gmail.com", "Brown", "/var/yp", false, true, "Medhurst", "0t0t3r3oadzr7evhd6w12qk9wcr8fcxm", new DateTime(2019, 5, 11, 3, 27, 27, 202, DateTimeKind.Unspecified).AddTicks(6211), 3, 1, 11, 45849L, "Johnny_Beer238" },
                    { 40L, new DateTime(1981, 12, 15, 20, 47, 3, 768, DateTimeKind.Unspecified).AddTicks(754), 28, "Harmony44@gmail.com", "Micah", "/root", false, true, "Stokes", "twa9rxq0u8xgdxc0y6wv4ldvcqlqfto5", new DateTime(2020, 3, 3, 23, 38, 15, 921, DateTimeKind.Unspecified).AddTicks(9276), 0, 0, 11, 66191L, "Consuelo5939" }
                });

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "Instructions", "LevelId", "Title" },
                values: new object[,]
                {
                    { 1L, 19L, new DateTime(2020, 8, 30, 4, 14, 32, 716, DateTimeKind.Unspecified).AddTicks(4815), "Perspiciatis cum et et laudantium.", 1, "We need to input the online SCSI firewall!" },
                    { 2L, 17L, new DateTime(2020, 11, 3, 0, 15, 42, 768, DateTimeKind.Unspecified).AddTicks(3025), "quis", 2, "Use the open-source SMS driver, then you can input" },
                    { 3L, 34L, new DateTime(2022, 12, 26, 22, 53, 16, 430, DateTimeKind.Unspecified).AddTicks(6995), "Aut rerum consectetur veniam distinctio officiis praesentium.\nAperiam quis qui animi omnis.\nMolestiae laboriosam exercitationem similique amet dolores quibusdam aspernatur consequatur quia.\nSuscipit consequuntur eos laborum facilis culpa.", 1, "If we back up the application, we can get to the G" },
                    { 4L, 20L, new DateTime(2020, 1, 12, 13, 24, 24, 824, DateTimeKind.Unspecified).AddTicks(9536), "Suscipit quia modi nobis ad eos voluptatum est.", 2, "Use the haptic JBOD transmitter, then you can hack" },
                    { 5L, 33L, new DateTime(2023, 7, 11, 16, 20, 8, 121, DateTimeKind.Unspecified).AddTicks(9044), "Voluptatem possimus iure impedit enim provident incidunt molestiae earum.", 2, "I'll transmit the wireless USB driver, that should" },
                    { 6L, 28L, new DateTime(2023, 8, 3, 6, 42, 36, 695, DateTimeKind.Unspecified).AddTicks(2251), "Distinctio rerum voluptatem aut iure nesciunt aut eos voluptatem molestias. Molestias reprehenderit tenetur hic. Esse repudiandae voluptatem quae impedit sed voluptates ratione minus in.", 3, "If we parse the feed, we can get to the SSL feed t" },
                    { 7L, 40L, new DateTime(2021, 6, 23, 2, 46, 19, 337, DateTimeKind.Unspecified).AddTicks(6137), "Molestiae quis nihil similique autem nemo numquam. Et ut ratione vel. Aperiam harum perferendis ad consequuntur.", 1, "We need to calculate the auxiliary HTTP applicatio" },
                    { 8L, 26L, new DateTime(2020, 7, 8, 5, 40, 3, 184, DateTimeKind.Unspecified).AddTicks(8220), "et", 2, "I'll index the back-end RSS driver, that should dr" },
                    { 9L, 3L, new DateTime(2020, 8, 13, 10, 38, 56, 626, DateTimeKind.Unspecified).AddTicks(9952), "Quas maxime esse et dolores accusamus doloremque in magnam quos.\nSaepe incidunt modi recusandae saepe ut et.\nAccusamus sed maiores doloremque aut et aut praesentium quae.\nQui magni eum autem architecto accusamus dolore inventore expedita.\nEos velit optio asperiores dolores voluptas amet voluptatum deserunt.", 4, "The SAS pixel is down, hack the mobile pixel so we" },
                    { 10L, 6L, new DateTime(2020, 10, 3, 0, 24, 55, 616, DateTimeKind.Unspecified).AddTicks(8806), "Doloremque velit maiores unde at commodi.", 3, "You can't synthesize the firewall without transmit" },
                    { 11L, 40L, new DateTime(2020, 4, 22, 12, 23, 3, 83, DateTimeKind.Unspecified).AddTicks(1558), "Doloribus eveniet non aut fuga et.", 4, "Try to calculate the SMTP bus, maybe it will calcu" },
                    { 12L, 40L, new DateTime(2023, 1, 2, 4, 54, 30, 215, DateTimeKind.Unspecified).AddTicks(6903), "Est molestiae voluptatem eos assumenda et libero voluptatem et.\nAb maxime fuga nemo ad.\nNon illum ut iste ea perspiciatis.", 3, "The ADP array is down, generate the bluetooth arra" },
                    { 13L, 5L, new DateTime(2020, 6, 27, 7, 44, 1, 258, DateTimeKind.Unspecified).AddTicks(4627), "iure", 4, "The SMS driver is down, hack the optical driver so" },
                    { 14L, 30L, new DateTime(2021, 10, 31, 16, 14, 15, 76, DateTimeKind.Unspecified).AddTicks(2736), "Nostrum sit quia consequatur eos dolorem quo vel libero ut.\nIusto error quia ab.\nAutem quam et quia eum ea molestias eum dolore consequuntur.\nEligendi rerum nisi aspernatur et commodi libero cupiditate.\nMollitia molestias eaque quia dignissimos voluptas porro voluptas.", 3, "Try to copy the IB program, maybe it will copy the" },
                    { 15L, 5L, new DateTime(2020, 11, 15, 22, 30, 33, 541, DateTimeKind.Unspecified).AddTicks(9668), "Recusandae molestias id.", 3, "Use the wireless SDD circuit, then you can navigat" },
                    { 16L, 13L, new DateTime(2020, 11, 19, 17, 36, 8, 848, DateTimeKind.Unspecified).AddTicks(4869), "Corporis veniam vel et voluptas. Rerum quod facilis est nihil qui et rerum et non. Rerum culpa deserunt adipisci vero iure corporis. Quam odit reprehenderit. Atque cupiditate aut minus minus reprehenderit eos. Ipsam et aut nostrum assumenda explicabo rem.", 1, "If we bypass the port, we can get to the USB port " },
                    { 17L, 18L, new DateTime(2017, 2, 6, 23, 19, 56, 992, DateTimeKind.Unspecified).AddTicks(9283), "ratione", 4, "calculating the panel won't do anything, we need t" },
                    { 18L, 17L, new DateTime(2021, 11, 28, 3, 38, 35, 866, DateTimeKind.Unspecified).AddTicks(2208), "et", 4, "If we hack the program, we can get to the PCI prog" },
                    { 19L, 20L, new DateTime(2020, 12, 13, 17, 13, 36, 51, DateTimeKind.Unspecified).AddTicks(9025), "Sint doloribus sit aut ipsam maiores voluptatum voluptas in.", 3, "compressing the sensor won't do anything, we need " },
                    { 20L, 38L, new DateTime(2022, 3, 22, 21, 52, 5, 991, DateTimeKind.Unspecified).AddTicks(7826), "perspiciatis", 2, "I'll override the redundant AGP card, that should " },
                    { 21L, 23L, new DateTime(2022, 8, 7, 16, 8, 42, 940, DateTimeKind.Unspecified).AddTicks(3692), "Quisquam cum aut sunt sit suscipit similique voluptatem maxime qui. Quia aut exercitationem est provident enim rerum maiores. Voluptatem aut fugiat sunt exercitationem. Corrupti vitae ea eos enim similique. Fuga et enim ad laboriosam quaerat ut et. Et sed dolorum sunt quisquam incidunt et explicabo et.", 4, "Use the open-source EXE array, then you can connec" },
                    { 22L, 2L, new DateTime(2023, 3, 11, 7, 13, 56, 112, DateTimeKind.Unspecified).AddTicks(9265), "Id consequuntur nesciunt laudantium quaerat et suscipit quaerat recusandae nobis. Id corrupti vitae. Hic quisquam cumque aliquam qui. Quasi porro quisquam dicta voluptatibus.", 2, "The IB transmitter is down, quantify the optical t" },
                    { 23L, 35L, new DateTime(2023, 8, 9, 3, 10, 39, 310, DateTimeKind.Unspecified).AddTicks(755), "Odit laudantium quibusdam nostrum fugiat dolores.", 4, "Use the back-end SMTP bus, then you can override t" },
                    { 24L, 20L, new DateTime(2018, 9, 9, 6, 53, 45, 701, DateTimeKind.Unspecified).AddTicks(3709), "Sed voluptate iusto vel ad ea voluptates iure.\nAccusantium saepe iusto dolorum necessitatibus necessitatibus.", 3, "We need to reboot the haptic USB protocol!" },
                    { 25L, 11L, new DateTime(2021, 8, 9, 2, 20, 55, 552, DateTimeKind.Unspecified).AddTicks(755), "eum", 4, "You can't reboot the bus without parsing the redun" },
                    { 26L, 18L, new DateTime(2016, 9, 29, 21, 52, 49, 774, DateTimeKind.Unspecified).AddTicks(4399), "Amet qui vel dignissimos maxime quo recusandae provident. Accusamus expedita delectus praesentium nam dolores accusamus. Mollitia iste unde voluptatem.", 1, "You can't calculate the program without hacking th" },
                    { 27L, 19L, new DateTime(2019, 2, 14, 15, 39, 27, 195, DateTimeKind.Unspecified).AddTicks(3643), "necessitatibus", 4, "I'll index the open-source JSON card, that should " },
                    { 28L, 23L, new DateTime(2021, 7, 18, 15, 47, 18, 778, DateTimeKind.Unspecified).AddTicks(5681), "Modi blanditiis aut sunt qui ut.\nVeritatis dignissimos deleniti.\nQuod ut aliquid voluptatum dolorem error.", 1, "If we parse the driver, we can get to the PNG driv" },
                    { 29L, 17L, new DateTime(2022, 1, 17, 15, 43, 38, 284, DateTimeKind.Unspecified).AddTicks(9168), "numquam", 3, "The PNG pixel is down, bypass the haptic pixel so " },
                    { 30L, 2L, new DateTime(2020, 9, 16, 1, 2, 29, 65, DateTimeKind.Unspecified).AddTicks(384), "ut", 2, "The GB firewall is down, reboot the 1080p firewall" },
                    { 31L, 19L, new DateTime(2021, 5, 20, 14, 18, 33, 401, DateTimeKind.Unspecified).AddTicks(9163), "Eum ea sequi voluptas praesentium hic.\nVoluptatum voluptatem dolor consequatur distinctio et.\nAutem officia ut unde delectus repudiandae eum animi consectetur omnis.", 2, "You can't index the transmitter without compressin" },
                    { 32L, 13L, new DateTime(2023, 6, 22, 5, 9, 57, 356, DateTimeKind.Unspecified).AddTicks(4680), "quia", 4, "We need to back up the virtual SQL feed!" },
                    { 33L, 9L, new DateTime(2022, 7, 27, 22, 16, 25, 831, DateTimeKind.Unspecified).AddTicks(3520), "Sunt et est aliquam aut unde blanditiis.\nRepellendus dolorem autem.\nEos nihil veniam quia ipsa.\nOdit fuga illum nobis voluptatum deserunt in.", 2, "Try to program the COM alarm, maybe it will progra" },
                    { 34L, 7L, new DateTime(2022, 5, 18, 9, 45, 53, 426, DateTimeKind.Unspecified).AddTicks(1524), "Culpa voluptatem est sequi in sit quam.", 3, "The XSS matrix is down, transmit the cross-platfor" },
                    { 35L, 34L, new DateTime(2022, 8, 29, 16, 6, 26, 879, DateTimeKind.Unspecified).AddTicks(7211), "Quisquam voluptate sequi magni soluta soluta qui voluptatem reprehenderit quo.", 1, "We need to navigate the digital RAM pixel!" },
                    { 36L, 4L, new DateTime(2022, 12, 10, 0, 47, 19, 32, DateTimeKind.Unspecified).AddTicks(3664), "Voluptatem quia ut ut doloribus ut et ratione suscipit. Est sunt veritatis. Quis ducimus laboriosam.", 1, "Try to input the JBOD driver, maybe it will input " },
                    { 37L, 38L, new DateTime(2021, 9, 18, 20, 16, 37, 631, DateTimeKind.Unspecified).AddTicks(2197), "iusto", 3, "The COM array is down, program the virtual array s" },
                    { 38L, 6L, new DateTime(2020, 11, 11, 12, 24, 14, 871, DateTimeKind.Unspecified).AddTicks(9582), "Omnis et et eum eum tempora nostrum a iure voluptatem. Expedita itaque quos quia soluta repellat quas perspiciatis. Sed consequatur numquam maxime. Enim quaerat ratione rerum sed quis. Ea dolores dolor eum vitae dolores vitae.", 3, "Use the solid state IB transmitter, then you can h" },
                    { 39L, 13L, new DateTime(2020, 9, 17, 11, 43, 49, 977, DateTimeKind.Unspecified).AddTicks(6826), "Expedita labore omnis omnis delectus doloremque possimus esse fugit.\nQui quasi pariatur et sed aliquam aut quo temporibus animi.\nNihil esse similique molestiae voluptas molestiae eum.\nImpedit et in nihil nihil et.", 4, "If we navigate the hard drive, we can get to the P" },
                    { 40L, 27L, new DateTime(2021, 12, 15, 18, 43, 58, 253, DateTimeKind.Unspecified).AddTicks(4999), "Adipisci sint quibusdam.", 4, "bypassing the matrix won't do anything, we need to" },
                    { 41L, 23L, new DateTime(2021, 4, 12, 3, 45, 16, 330, DateTimeKind.Unspecified).AddTicks(4669), "Non non ea ab maxime est ratione. Et voluptate iusto ut. Minima nihil qui quaerat ratione aut.", 3, "I'll parse the virtual SCSI transmitter, that shou" },
                    { 42L, 23L, new DateTime(2022, 11, 7, 4, 30, 54, 940, DateTimeKind.Unspecified).AddTicks(5621), "Eos provident laborum placeat reprehenderit voluptatem.", 1, "indexing the hard drive won't do anything, we need" }
                });

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "Instructions", "LevelId", "Title" },
                values: new object[,]
                {
                    { 43L, 23L, new DateTime(2023, 7, 29, 8, 48, 34, 161, DateTimeKind.Unspecified).AddTicks(7419), "Et dolor error quo doloremque harum explicabo.\nSed qui facere corporis sunt omnis voluptas corporis perspiciatis ut.\nEst rerum ad necessitatibus voluptatem.\nLaboriosam cupiditate dolorem eaque perspiciatis et.", 4, "You can't copy the port without parsing the wirele" },
                    { 44L, 21L, new DateTime(2021, 1, 2, 21, 46, 25, 389, DateTimeKind.Unspecified).AddTicks(4166), "Aut ex quis.\nEnim nulla eligendi est quam iusto.\nCumque harum saepe velit consequatur eligendi odit ut vero.\nDolorem sit vel sed nemo modi consequatur.", 2, "You can't parse the firewall without backing up th" },
                    { 45L, 35L, new DateTime(2023, 1, 23, 0, 0, 17, 347, DateTimeKind.Unspecified).AddTicks(1060), "Ut qui non dolores sunt enim fugiat quisquam cupiditate distinctio. Officiis reprehenderit quidem qui quis quia asperiores quaerat sapiente. Quia quia voluptatem magni et enim iure. Dolorum ut minus.", 2, "If we bypass the transmitter, we can get to the AI" },
                    { 46L, 7L, new DateTime(2021, 12, 17, 18, 24, 15, 38, DateTimeKind.Unspecified).AddTicks(1249), "Officia iusto rerum placeat temporibus corrupti et aut cumque.\nCommodi voluptatem laborum amet consequatur.\nA ducimus est ut reprehenderit.\nSit odit consequuntur.\nTempore magni nihil velit quos sed deleniti aliquid.\nEligendi nesciunt error mollitia et consequatur.", 1, "compressing the bus won't do anything, we need to " },
                    { 47L, 10L, new DateTime(2022, 1, 16, 15, 57, 48, 355, DateTimeKind.Unspecified).AddTicks(2933), "Earum laudantium molestias quam sed fuga explicabo vel corrupti in. Quibusdam et ut voluptatem facere. Magni qui pariatur reiciendis eveniet.", 1, "I'll parse the back-end XML protocol, that should " },
                    { 48L, 15L, new DateTime(2022, 9, 6, 23, 46, 50, 105, DateTimeKind.Unspecified).AddTicks(2679), "Sed rerum molestiae ad.\nItaque quas vel sint voluptas maxime assumenda.\nHic debitis tempore minus et quos quia repudiandae.\nUt laudantium ut.", 4, "We need to synthesize the haptic THX bandwidth!" },
                    { 49L, 34L, new DateTime(2022, 12, 7, 23, 32, 30, 987, DateTimeKind.Unspecified).AddTicks(3223), "vel", 1, "Use the wireless AI card, then you can back up the" },
                    { 50L, 34L, new DateTime(2022, 4, 6, 0, 23, 9, 861, DateTimeKind.Unspecified).AddTicks(9694), "Cum in ex nulla doloremque nostrum nemo quos.\nLaudantium corporis ut hic sapiente dolore sed architecto.\nIusto expedita rerum et pariatur optio ex aperiam dolorem placeat.\nAssumenda nesciunt nostrum pariatur corporis et doloribus quae.", 3, "You can't copy the sensor without navigating the d" },
                    { 51L, 38L, new DateTime(2022, 8, 7, 12, 38, 12, 194, DateTimeKind.Unspecified).AddTicks(7534), "Voluptatem iure quia labore pariatur id quia qui expedita quos.\nLaudantium natus dolorem rerum nemo perferendis quam est explicabo aliquam.\nIncidunt et qui.", 2, "The XML monitor is down, compress the 1080p monito" },
                    { 52L, 16L, new DateTime(2022, 6, 23, 15, 42, 4, 646, DateTimeKind.Unspecified).AddTicks(720), "Fugiat illo alias error eligendi voluptatem.", 2, "You can't transmit the system without connecting t" },
                    { 53L, 29L, new DateTime(2019, 10, 12, 13, 42, 48, 734, DateTimeKind.Unspecified).AddTicks(6632), "Distinctio adipisci sequi vitae nulla. Corporis in labore nobis vel laudantium accusantium minus nihil quas. Sapiente quam vitae ea asperiores cum. Et illum temporibus placeat itaque et aliquam nostrum tempore ratione. Quia modi facere quia. Quaerat nostrum voluptatem.", 4, "Use the wireless GB protocol, then you can synthes" },
                    { 54L, 33L, new DateTime(2023, 3, 30, 4, 58, 8, 485, DateTimeKind.Unspecified).AddTicks(3921), "Necessitatibus libero sint ad culpa accusantium sed omnis praesentium.", 2, "Use the open-source ADP pixel, then you can input " },
                    { 55L, 31L, new DateTime(2023, 6, 6, 7, 30, 5, 939, DateTimeKind.Unspecified).AddTicks(198), "Aut ut ut voluptates tempora ut commodi quos id. Dolores rerum eveniet quaerat dolores eligendi hic ipsum sit. Impedit fugiat numquam ad rerum atque tempore vero ipsa ab. Consequatur vitae hic omnis cumque perspiciatis consequatur ex omnis.", 1, "overriding the port won't do anything, we need to " },
                    { 56L, 26L, new DateTime(2021, 2, 10, 4, 10, 55, 417, DateTimeKind.Unspecified).AddTicks(9357), "Sunt ut fugit minima facere optio accusantium.\nDeserunt molestias ducimus omnis voluptatibus quos aut rerum.\nQuibusdam ratione qui illum quam modi.", 4, "I'll bypass the digital XSS pixel, that should pix" },
                    { 57L, 15L, new DateTime(2021, 11, 15, 1, 18, 29, 116, DateTimeKind.Unspecified).AddTicks(9136), "Minus quo dolores rerum pariatur nisi.\nDolorem dolore laborum corporis reiciendis dignissimos in.\nEos enim vel placeat minus voluptatem consequuntur totam corporis et.", 2, "Try to generate the SMTP application, maybe it wil" },
                    { 58L, 40L, new DateTime(2021, 3, 13, 19, 47, 39, 206, DateTimeKind.Unspecified).AddTicks(9483), "aut", 4, "Use the solid state SMS alarm, then you can bypass" },
                    { 59L, 8L, new DateTime(2022, 9, 13, 21, 37, 33, 411, DateTimeKind.Unspecified).AddTicks(4933), "Veniam rerum repudiandae sint eos delectus qui veniam id consequatur.", 2, "We need to synthesize the open-source CSS driver!" },
                    { 60L, 22L, new DateTime(2022, 6, 22, 9, 12, 48, 196, DateTimeKind.Unspecified).AddTicks(8734), "Quia fugiat voluptatem nihil vitae molestias.", 4, "I'll connect the bluetooth RSS feed, that should f" },
                    { 61L, 2L, new DateTime(2023, 6, 19, 14, 33, 29, 336, DateTimeKind.Unspecified).AddTicks(871), "Accusamus beatae omnis totam maxime autem in et et.\nEt ducimus ea quia a excepturi a aut.\nExplicabo illo blanditiis illo eum qui itaque natus modi.", 4, "You can't generate the protocol without indexing t" },
                    { 62L, 13L, new DateTime(2021, 11, 25, 12, 52, 31, 106, DateTimeKind.Unspecified).AddTicks(4647), "Voluptatem veniam ut autem enim. Architecto nihil ut rerum aut nihil eos aut. Esse voluptatem reprehenderit perferendis aut ut dolor voluptas.", 4, "If we quantify the program, we can get to the FTP " },
                    { 63L, 26L, new DateTime(2022, 4, 12, 8, 24, 0, 72, DateTimeKind.Unspecified).AddTicks(7537), "Est consectetur voluptatem.\nPlaceat et eos.\nSunt quo et qui eius qui dolor numquam numquam nulla.\nSed nulla sint delectus alias.", 3, "If we bypass the circuit, we can get to the RSS ci" },
                    { 64L, 10L, new DateTime(2021, 7, 19, 0, 51, 6, 49, DateTimeKind.Unspecified).AddTicks(6996), "ut", 4, "parsing the matrix won't do anything, we need to c" },
                    { 65L, 24L, new DateTime(2017, 12, 21, 6, 50, 20, 677, DateTimeKind.Unspecified).AddTicks(7482), "Suscipit iusto quas est quaerat molestiae nostrum tempora aliquam tempora.\nRem dolorem ut voluptas voluptate.\nQuo magnam eligendi.\nIpsum tenetur praesentium earum.", 2, "Try to connect the XSS feed, maybe it will connect" },
                    { 66L, 33L, new DateTime(2023, 3, 16, 4, 18, 26, 438, DateTimeKind.Unspecified).AddTicks(1741), "Quae aliquid quod error nesciunt.", 3, "Use the online IB panel, then you can synthesize t" },
                    { 67L, 39L, new DateTime(2023, 3, 9, 12, 25, 46, 22, DateTimeKind.Unspecified).AddTicks(8960), "Autem est neque deleniti quae.\nCum vitae ut id voluptate est aut enim.\nAlias tenetur commodi cumque explicabo est.\nCommodi blanditiis tenetur sapiente dolores atque tempore.\nAut modi officiis neque consequatur.", 1, "You can't transmit the application without quantif" },
                    { 68L, 19L, new DateTime(2021, 5, 29, 3, 27, 44, 581, DateTimeKind.Unspecified).AddTicks(8226), "Est dolores id tempore vel.", 4, "If we override the circuit, we can get to the HDD " },
                    { 69L, 7L, new DateTime(2022, 5, 23, 14, 27, 44, 852, DateTimeKind.Unspecified).AddTicks(6291), "Aut quibusdam amet at facilis rerum.\nUt veritatis commodi aspernatur doloremque quia quidem.", 1, "Use the cross-platform AGP firewall, then you can " },
                    { 70L, 37L, new DateTime(2023, 5, 17, 12, 28, 1, 363, DateTimeKind.Unspecified).AddTicks(499), "Natus aut officia qui consequatur.", 4, "Try to navigate the THX system, maybe it will navi" }
                });

            migrationBuilder.InsertData(
                table: "LanguageVersions",
                columns: new[] { "Id", "LanguageId", "Version" },
                values: new object[,]
                {
                    { 1, 4, "8.5.4.4" },
                    { 2, 3, "1.0.9.1" },
                    { 3, 2, "9.6.6.2" }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "Cost", "EndDate", "IsActive", "PaymentSubscriptionId", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate", "UserId" },
                values: new object[,]
                {
                    { 1L, 151.37m, new DateTime(2023, 7, 9, 18, 2, 11, 841, DateTimeKind.Unspecified).AddTicks(2647), false, "2umhqjy0f1gdzhf2", new DateTime(2023, 4, 7, 2, 52, 45, 82, DateTimeKind.Unspecified).AddTicks(1730), new DateTime(2020, 11, 13, 9, 59, 19, 183, DateTimeKind.Unspecified).AddTicks(9340), 2, new DateTime(2023, 4, 13, 2, 24, 11, 360, DateTimeKind.Unspecified).AddTicks(6906), 27L },
                    { 2L, 136.02m, new DateTime(2023, 12, 3, 11, 56, 45, 557, DateTimeKind.Unspecified).AddTicks(7630), true, "6iotvwd2kcauexpx", new DateTime(2023, 5, 15, 2, 34, 50, 433, DateTimeKind.Unspecified).AddTicks(3578), new DateTime(2022, 2, 18, 14, 33, 44, 215, DateTimeKind.Unspecified).AddTicks(3697), 1, new DateTime(2022, 3, 28, 4, 55, 27, 242, DateTimeKind.Unspecified).AddTicks(1782), 20L },
                    { 3L, 151.37m, new DateTime(2023, 7, 13, 3, 0, 10, 794, DateTimeKind.Unspecified).AddTicks(9513), false, "uo2s583680b8v54j", new DateTime(2023, 4, 30, 22, 7, 38, 28, DateTimeKind.Unspecified).AddTicks(8748), new DateTime(2022, 10, 10, 2, 1, 51, 549, DateTimeKind.Unspecified).AddTicks(9625), 2, new DateTime(2023, 4, 13, 19, 11, 24, 197, DateTimeKind.Unspecified).AddTicks(1544), 27L },
                    { 4L, 136.02m, new DateTime(2023, 7, 18, 5, 14, 0, 527, DateTimeKind.Unspecified).AddTicks(3061), true, "nfd23s23e9y7ukxb", new DateTime(2022, 12, 3, 17, 10, 22, 64, DateTimeKind.Unspecified).AddTicks(6205), new DateTime(2022, 6, 15, 22, 15, 9, 192, DateTimeKind.Unspecified).AddTicks(2251), 1, new DateTime(2023, 1, 13, 13, 58, 13, 995, DateTimeKind.Unspecified).AddTicks(3255), 10L },
                    { 5L, 136.02m, new DateTime(2023, 6, 25, 12, 27, 40, 268, DateTimeKind.Unspecified).AddTicks(614), true, "28569h790c5pv13g", new DateTime(2023, 4, 20, 11, 33, 13, 460, DateTimeKind.Unspecified).AddTicks(9150), new DateTime(2022, 10, 15, 23, 33, 18, 811, DateTimeKind.Unspecified).AddTicks(5864), 1, new DateTime(2023, 7, 28, 0, 55, 59, 560, DateTimeKind.Unspecified).AddTicks(3985), 38L },
                    { 6L, 91.86m, new DateTime(2022, 2, 15, 14, 43, 42, 782, DateTimeKind.Unspecified).AddTicks(3052), true, "fhe3z935d1zvmvux", new DateTime(2021, 9, 12, 21, 55, 31, 535, DateTimeKind.Unspecified).AddTicks(8524), new DateTime(2019, 11, 2, 12, 24, 33, 375, DateTimeKind.Unspecified).AddTicks(9152), 3, new DateTime(2020, 9, 1, 5, 56, 15, 423, DateTimeKind.Unspecified).AddTicks(6227), 3L },
                    { 7L, 136.02m, new DateTime(2023, 5, 12, 21, 33, 30, 459, DateTimeKind.Unspecified).AddTicks(2131), true, "04gfoh55j2qr239q", new DateTime(2023, 4, 19, 7, 26, 12, 328, DateTimeKind.Unspecified).AddTicks(3801), new DateTime(2021, 9, 26, 17, 42, 39, 173, DateTimeKind.Unspecified).AddTicks(8348), 1, new DateTime(2022, 3, 1, 0, 0, 0, 571, DateTimeKind.Unspecified).AddTicks(3683), 10L },
                    { 8L, 91.86m, new DateTime(2021, 11, 20, 12, 52, 13, 715, DateTimeKind.Unspecified).AddTicks(606), false, "cvjhq7n8273vtohw", new DateTime(2021, 9, 29, 6, 53, 18, 372, DateTimeKind.Unspecified).AddTicks(7566), new DateTime(2019, 5, 15, 1, 8, 14, 525, DateTimeKind.Unspecified).AddTicks(5054), 3, new DateTime(2019, 9, 23, 17, 56, 10, 375, DateTimeKind.Unspecified).AddTicks(4397), 36L },
                    { 9L, 151.37m, new DateTime(2024, 6, 28, 19, 19, 45, 636, DateTimeKind.Unspecified).AddTicks(3070), false, "ff9fvm4sae2sxofc", new DateTime(2023, 6, 29, 18, 20, 2, 998, DateTimeKind.Unspecified).AddTicks(6064), new DateTime(2022, 6, 25, 7, 11, 49, 801, DateTimeKind.Unspecified).AddTicks(1908), 2, new DateTime(2022, 12, 12, 14, 0, 31, 576, DateTimeKind.Unspecified).AddTicks(7859), 17L },
                    { 10L, 136.02m, new DateTime(2023, 2, 1, 6, 7, 49, 875, DateTimeKind.Unspecified).AddTicks(2235), true, "igx8w9w90k1ay8cf", new DateTime(2022, 6, 16, 10, 33, 28, 304, DateTimeKind.Unspecified).AddTicks(9740), new DateTime(2021, 8, 21, 2, 54, 35, 763, DateTimeKind.Unspecified).AddTicks(763), 1, new DateTime(2023, 1, 10, 7, 6, 49, 785, DateTimeKind.Unspecified).AddTicks(1991), 3L },
                    { 11L, 91.86m, new DateTime(2023, 4, 12, 4, 30, 23, 384, DateTimeKind.Unspecified).AddTicks(3758), true, "dy4mdzy1ipwfpvv0", new DateTime(2022, 8, 23, 13, 48, 13, 624, DateTimeKind.Unspecified).AddTicks(500), new DateTime(2022, 1, 28, 9, 17, 43, 812, DateTimeKind.Unspecified).AddTicks(1160), 3, new DateTime(2022, 4, 20, 12, 55, 21, 95, DateTimeKind.Unspecified).AddTicks(5657), 20L }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "Cost", "EndDate", "IsActive", "PaymentSubscriptionId", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate", "UserId" },
                values: new object[,]
                {
                    { 12L, 136.02m, new DateTime(2023, 7, 25, 14, 55, 46, 923, DateTimeKind.Unspecified).AddTicks(2896), true, "69sotjwthpvx4aw1", new DateTime(2023, 3, 24, 12, 9, 19, 661, DateTimeKind.Unspecified).AddTicks(2222), new DateTime(2023, 2, 3, 20, 54, 4, 226, DateTimeKind.Unspecified).AddTicks(2321), 1, new DateTime(2023, 8, 6, 14, 5, 37, 325, DateTimeKind.Unspecified).AddTicks(613), 25L },
                    { 13L, 136.02m, new DateTime(2023, 8, 31, 13, 32, 58, 619, DateTimeKind.Unspecified).AddTicks(8891), true, "gjxuxll8kyg46a7z", new DateTime(2023, 8, 22, 15, 59, 0, 306, DateTimeKind.Unspecified).AddTicks(4671), new DateTime(2023, 6, 18, 14, 10, 54, 129, DateTimeKind.Unspecified).AddTicks(4585), 1, new DateTime(2023, 8, 18, 11, 33, 35, 925, DateTimeKind.Unspecified).AddTicks(3863), 32L },
                    { 14L, 151.37m, new DateTime(2022, 10, 17, 15, 16, 36, 196, DateTimeKind.Unspecified).AddTicks(6850), true, "wprmc5u9im89l2ww", new DateTime(2021, 12, 20, 0, 24, 29, 779, DateTimeKind.Unspecified).AddTicks(1648), new DateTime(2021, 8, 3, 18, 47, 34, 83, DateTimeKind.Unspecified).AddTicks(9180), 2, new DateTime(2023, 3, 4, 9, 42, 54, 340, DateTimeKind.Unspecified).AddTicks(1179), 5L },
                    { 15L, 136.02m, new DateTime(2023, 2, 14, 8, 46, 55, 876, DateTimeKind.Unspecified).AddTicks(6432), false, "stg9zq5iopx7uyvf", new DateTime(2023, 1, 24, 17, 50, 48, 706, DateTimeKind.Unspecified).AddTicks(5764), new DateTime(2022, 5, 1, 17, 0, 36, 404, DateTimeKind.Unspecified).AddTicks(8795), 1, new DateTime(2023, 7, 19, 12, 30, 23, 375, DateTimeKind.Unspecified).AddTicks(7113), 5L },
                    { 16L, 91.86m, new DateTime(2023, 8, 2, 12, 55, 52, 576, DateTimeKind.Unspecified).AddTicks(6061), true, "61vekpd4uftjpk9r", new DateTime(2023, 6, 13, 5, 3, 23, 198, DateTimeKind.Unspecified).AddTicks(2753), new DateTime(2021, 9, 27, 23, 49, 32, 137, DateTimeKind.Unspecified).AddTicks(4359), 3, null, 19L },
                    { 17L, 91.86m, new DateTime(2021, 1, 11, 12, 6, 44, 203, DateTimeKind.Unspecified).AddTicks(2779), false, "qy2m6a9vgq3xvryz", new DateTime(2020, 11, 21, 10, 42, 35, 436, DateTimeKind.Unspecified).AddTicks(9367), new DateTime(2019, 1, 8, 12, 2, 24, 278, DateTimeKind.Unspecified).AddTicks(3750), 3, new DateTime(2020, 8, 7, 17, 19, 46, 712, DateTimeKind.Unspecified).AddTicks(5662), 14L },
                    { 18L, 91.86m, new DateTime(2023, 12, 23, 5, 32, 7, 811, DateTimeKind.Unspecified).AddTicks(8499), false, "xt3cbgkhzqommryk", new DateTime(2023, 7, 3, 14, 55, 0, 349, DateTimeKind.Unspecified).AddTicks(2208), new DateTime(2020, 2, 9, 5, 39, 5, 955, DateTimeKind.Unspecified).AddTicks(4470), 3, new DateTime(2021, 4, 29, 11, 47, 40, 940, DateTimeKind.Unspecified).AddTicks(8723), 7L },
                    { 19L, 151.37m, new DateTime(2023, 6, 28, 2, 14, 53, 430, DateTimeKind.Unspecified).AddTicks(2333), false, "rmkbbn0e8joc7xjz", new DateTime(2023, 5, 27, 3, 39, 55, 845, DateTimeKind.Unspecified).AddTicks(6096), new DateTime(2023, 5, 13, 4, 56, 18, 321, DateTimeKind.Unspecified).AddTicks(2862), 2, new DateTime(2023, 6, 16, 16, 50, 11, 950, DateTimeKind.Unspecified).AddTicks(8896), 7L },
                    { 20L, 136.02m, new DateTime(2020, 8, 16, 9, 23, 10, 368, DateTimeKind.Unspecified).AddTicks(5303), true, "us879r2lwdkpw85c", new DateTime(2020, 7, 19, 1, 12, 33, 473, DateTimeKind.Unspecified).AddTicks(5067), new DateTime(2020, 4, 29, 15, 22, 13, 637, DateTimeKind.Unspecified).AddTicks(9645), 1, new DateTime(2022, 4, 30, 9, 4, 37, 36, DateTimeKind.Unspecified).AddTicks(9032), 29L },
                    { 21L, 136.02m, new DateTime(2023, 4, 28, 6, 12, 50, 883, DateTimeKind.Unspecified).AddTicks(2934), false, "e3suermf9zhiet5h", new DateTime(2022, 12, 20, 16, 52, 57, 552, DateTimeKind.Unspecified).AddTicks(1993), new DateTime(2020, 1, 7, 19, 56, 34, 896, DateTimeKind.Unspecified).AddTicks(5058), 1, new DateTime(2023, 1, 30, 8, 21, 29, 423, DateTimeKind.Unspecified).AddTicks(1594), 20L },
                    { 22L, 136.02m, new DateTime(2024, 5, 4, 1, 52, 9, 935, DateTimeKind.Unspecified).AddTicks(155), false, "gkftyah9gzs5y764", new DateTime(2023, 7, 25, 6, 35, 9, 268, DateTimeKind.Unspecified).AddTicks(4748), new DateTime(2022, 10, 27, 3, 9, 53, 931, DateTimeKind.Unspecified).AddTicks(8939), 1, new DateTime(2023, 5, 8, 13, 26, 33, 120, DateTimeKind.Unspecified).AddTicks(6019), 31L },
                    { 23L, 136.02m, new DateTime(2021, 8, 30, 3, 19, 58, 981, DateTimeKind.Unspecified).AddTicks(1672), true, "4wkz5jwj0veuctgy", new DateTime(2021, 8, 24, 16, 56, 37, 47, DateTimeKind.Unspecified).AddTicks(4276), new DateTime(2020, 2, 11, 16, 28, 15, 415, DateTimeKind.Unspecified).AddTicks(6085), 1, new DateTime(2023, 8, 16, 20, 49, 17, 221, DateTimeKind.Unspecified).AddTicks(7837), 21L },
                    { 24L, 136.02m, new DateTime(2023, 3, 8, 17, 10, 12, 328, DateTimeKind.Unspecified).AddTicks(924), false, "xb17e65tmjo2pi3w", new DateTime(2022, 5, 18, 1, 3, 29, 675, DateTimeKind.Unspecified).AddTicks(1834), new DateTime(2022, 4, 9, 21, 9, 42, 393, DateTimeKind.Unspecified).AddTicks(5995), 1, new DateTime(2022, 9, 22, 8, 3, 41, 444, DateTimeKind.Unspecified).AddTicks(9463), 4L },
                    { 25L, 151.37m, new DateTime(2022, 11, 22, 10, 53, 37, 93, DateTimeKind.Unspecified).AddTicks(8185), false, "ohejkiv4da2uho5t", new DateTime(2022, 10, 8, 12, 28, 9, 3, DateTimeKind.Unspecified).AddTicks(7122), new DateTime(2018, 10, 25, 9, 31, 7, 802, DateTimeKind.Unspecified).AddTicks(2112), 2, new DateTime(2020, 10, 18, 14, 37, 12, 911, DateTimeKind.Unspecified).AddTicks(2248), 30L },
                    { 26L, 151.37m, new DateTime(2023, 4, 1, 21, 47, 57, 785, DateTimeKind.Unspecified).AddTicks(7956), true, "46crvfhli3jxsl84", new DateTime(2022, 10, 21, 4, 21, 58, 145, DateTimeKind.Unspecified).AddTicks(8520), new DateTime(2022, 2, 26, 18, 29, 16, 293, DateTimeKind.Unspecified).AddTicks(569), 2, new DateTime(2022, 7, 3, 12, 3, 8, 991, DateTimeKind.Unspecified).AddTicks(100), 27L },
                    { 27L, 151.37m, new DateTime(2023, 8, 16, 21, 20, 46, 275, DateTimeKind.Unspecified).AddTicks(3034), true, "3ab74yu98efe549y", new DateTime(2023, 6, 20, 3, 45, 52, 849, DateTimeKind.Unspecified).AddTicks(7214), new DateTime(2023, 5, 8, 9, 26, 14, 563, DateTimeKind.Unspecified).AddTicks(9514), 2, null, 33L },
                    { 28L, 136.02m, new DateTime(2023, 2, 7, 9, 17, 26, 716, DateTimeKind.Unspecified).AddTicks(6121), false, "c26kqtjwrynk39gj", new DateTime(2022, 12, 8, 7, 25, 53, 166, DateTimeKind.Unspecified).AddTicks(9968), new DateTime(2022, 7, 11, 17, 36, 4, 505, DateTimeKind.Unspecified).AddTicks(2691), 1, new DateTime(2023, 6, 15, 6, 10, 37, 378, DateTimeKind.Unspecified).AddTicks(6463), 11L },
                    { 29L, 151.37m, new DateTime(2023, 10, 11, 7, 50, 57, 235, DateTimeKind.Unspecified).AddTicks(1158), false, "aqmyw08v96v1s9if", new DateTime(2023, 4, 22, 20, 35, 42, 655, DateTimeKind.Unspecified).AddTicks(2122), new DateTime(2023, 3, 25, 0, 57, 43, 605, DateTimeKind.Unspecified).AddTicks(391), 2, new DateTime(2023, 7, 10, 4, 55, 6, 662, DateTimeKind.Unspecified).AddTicks(8486), 35L },
                    { 30L, 91.86m, new DateTime(2023, 10, 1, 20, 41, 54, 165, DateTimeKind.Unspecified).AddTicks(9734), false, "0s5wjozi3ma06kzq", new DateTime(2023, 5, 10, 21, 23, 49, 367, DateTimeKind.Unspecified).AddTicks(574), new DateTime(2019, 6, 12, 19, 59, 58, 356, DateTimeKind.Unspecified).AddTicks(4004), 3, new DateTime(2021, 3, 18, 1, 32, 35, 128, DateTimeKind.Unspecified).AddTicks(874), 30L },
                    { 31L, 151.37m, new DateTime(2024, 7, 11, 3, 30, 18, 423, DateTimeKind.Unspecified).AddTicks(9045), true, "q9hn6s2kv3y4vcck", new DateTime(2023, 7, 23, 8, 42, 2, 50, DateTimeKind.Unspecified).AddTicks(4058), new DateTime(2023, 7, 17, 12, 11, 23, 304, DateTimeKind.Unspecified).AddTicks(102), 2, new DateTime(2023, 8, 4, 21, 15, 59, 670, DateTimeKind.Unspecified).AddTicks(7913), 8L },
                    { 32L, 91.86m, new DateTime(2022, 5, 1, 3, 49, 58, 579, DateTimeKind.Unspecified).AddTicks(4765), true, "iwgpew5l055a6ccb", new DateTime(2021, 9, 20, 6, 12, 18, 87, DateTimeKind.Unspecified).AddTicks(6176), new DateTime(2021, 7, 13, 9, 0, 36, 318, DateTimeKind.Unspecified).AddTicks(5925), 3, new DateTime(2023, 5, 20, 20, 48, 41, 69, DateTimeKind.Unspecified).AddTicks(8304), 23L },
                    { 33L, 151.37m, new DateTime(2022, 8, 20, 17, 12, 55, 395, DateTimeKind.Unspecified).AddTicks(2936), false, "fqq1hl08z749bd6z", new DateTime(2022, 6, 10, 11, 45, 3, 620, DateTimeKind.Unspecified).AddTicks(5529), new DateTime(2019, 6, 16, 21, 43, 37, 861, DateTimeKind.Unspecified).AddTicks(8473), 2, new DateTime(2019, 8, 24, 22, 12, 39, 46, DateTimeKind.Unspecified).AddTicks(6645), 38L },
                    { 34L, 91.86m, new DateTime(2023, 10, 20, 5, 0, 12, 681, DateTimeKind.Unspecified).AddTicks(89), true, "0ml8d5on129n534f", new DateTime(2023, 8, 3, 8, 16, 35, 245, DateTimeKind.Unspecified).AddTicks(4697), new DateTime(2021, 3, 24, 22, 55, 0, 735, DateTimeKind.Unspecified).AddTicks(4143), 3, new DateTime(2021, 5, 28, 23, 4, 54, 982, DateTimeKind.Unspecified).AddTicks(6857), 6L },
                    { 35L, 151.37m, new DateTime(2021, 7, 7, 16, 16, 21, 343, DateTimeKind.Unspecified).AddTicks(9076), false, "k558r56ddw1u0svt", new DateTime(2021, 6, 2, 8, 4, 52, 462, DateTimeKind.Unspecified).AddTicks(4), new DateTime(2020, 9, 17, 0, 32, 38, 159, DateTimeKind.Unspecified).AddTicks(9652), 2, new DateTime(2022, 3, 21, 6, 40, 43, 780, DateTimeKind.Unspecified).AddTicks(2638), 21L },
                    { 36L, 91.86m, new DateTime(2020, 6, 7, 16, 3, 8, 102, DateTimeKind.Unspecified).AddTicks(1817), true, "9olaqemxndo70gvv", new DateTime(2020, 5, 13, 23, 43, 25, 52, DateTimeKind.Unspecified).AddTicks(5798), new DateTime(2019, 3, 25, 23, 9, 7, 831, DateTimeKind.Unspecified).AddTicks(4828), 3, new DateTime(2020, 6, 9, 8, 42, 3, 559, DateTimeKind.Unspecified).AddTicks(4517), 36L },
                    { 37L, 136.02m, new DateTime(2022, 9, 17, 8, 50, 45, 694, DateTimeKind.Unspecified).AddTicks(5014), true, "1ggquq41cbz3kwmy", new DateTime(2022, 8, 9, 0, 23, 22, 477, DateTimeKind.Unspecified).AddTicks(7178), new DateTime(2020, 10, 23, 4, 20, 42, 404, DateTimeKind.Unspecified).AddTicks(5884), 1, new DateTime(2022, 9, 8, 18, 16, 24, 146, DateTimeKind.Unspecified).AddTicks(7106), 11L },
                    { 38L, 151.37m, new DateTime(2023, 12, 17, 16, 29, 22, 8, DateTimeKind.Unspecified).AddTicks(7044), false, "mcc78krz988ayw3w", new DateTime(2023, 6, 27, 4, 16, 39, 336, DateTimeKind.Unspecified).AddTicks(555), new DateTime(2023, 2, 21, 19, 54, 13, 146, DateTimeKind.Unspecified).AddTicks(3619), 2, new DateTime(2023, 7, 11, 4, 24, 3, 692, DateTimeKind.Unspecified).AddTicks(3030), 11L },
                    { 39L, 91.86m, new DateTime(2024, 1, 12, 10, 2, 10, 75, DateTimeKind.Unspecified).AddTicks(5180), true, "8czy2s8dnd3hewts", new DateTime(2023, 5, 16, 3, 54, 31, 427, DateTimeKind.Unspecified).AddTicks(3014), new DateTime(2023, 3, 29, 5, 36, 18, 33, DateTimeKind.Unspecified).AddTicks(7756), 3, null, 23L },
                    { 40L, 91.86m, new DateTime(2023, 10, 4, 6, 38, 14, 146, DateTimeKind.Unspecified).AddTicks(6347), true, "0adhs4lu1czvkswh", new DateTime(2022, 12, 14, 20, 50, 12, 714, DateTimeKind.Unspecified).AddTicks(6110), new DateTime(2022, 1, 15, 0, 37, 10, 368, DateTimeKind.Unspecified).AddTicks(7926), 3, new DateTime(2022, 12, 31, 21, 5, 8, 386, DateTimeKind.Unspecified).AddTicks(6181), 1L },
                    { 41L, 136.02m, new DateTime(2022, 12, 5, 1, 38, 38, 585, DateTimeKind.Unspecified).AddTicks(2768), false, "t24hxzbvbmyserki", new DateTime(2022, 1, 2, 8, 58, 20, 363, DateTimeKind.Unspecified).AddTicks(8988), new DateTime(2021, 12, 7, 11, 22, 32, 797, DateTimeKind.Unspecified).AddTicks(775), 1, new DateTime(2023, 7, 13, 6, 44, 48, 125, DateTimeKind.Unspecified).AddTicks(3463), 32L },
                    { 42L, 136.02m, new DateTime(2024, 6, 2, 17, 16, 8, 678, DateTimeKind.Unspecified).AddTicks(8876), true, "2cbsqfkes0nq04x2", new DateTime(2023, 7, 27, 4, 42, 47, 280, DateTimeKind.Unspecified).AddTicks(3076), new DateTime(2022, 2, 5, 4, 45, 50, 178, DateTimeKind.Unspecified).AddTicks(1575), 1, new DateTime(2022, 4, 16, 23, 37, 55, 597, DateTimeKind.Unspecified).AddTicks(5569), 2L },
                    { 43L, 151.37m, new DateTime(2023, 9, 10, 22, 57, 14, 393, DateTimeKind.Unspecified).AddTicks(8794), false, "a3sk5gfvudeknj5w", new DateTime(2023, 8, 6, 1, 32, 26, 554, DateTimeKind.Unspecified).AddTicks(1164), new DateTime(2023, 7, 25, 13, 18, 36, 749, DateTimeKind.Unspecified).AddTicks(648), 2, new DateTime(2023, 8, 18, 4, 20, 15, 592, DateTimeKind.Unspecified).AddTicks(5141), 3L },
                    { 44L, 91.86m, new DateTime(2024, 4, 1, 22, 15, 25, 378, DateTimeKind.Unspecified).AddTicks(8602), true, "bc0td9wya1hmn09c", new DateTime(2023, 7, 19, 16, 18, 58, 213, DateTimeKind.Unspecified).AddTicks(4633), new DateTime(2023, 5, 20, 12, 38, 27, 230, DateTimeKind.Unspecified).AddTicks(9701), 3, new DateTime(2023, 6, 22, 15, 8, 54, 600, DateTimeKind.Unspecified).AddTicks(9286), 23L },
                    { 45L, 151.37m, new DateTime(2022, 5, 22, 22, 22, 26, 773, DateTimeKind.Unspecified).AddTicks(6349), true, "xowb5o5gk48tfmik", new DateTime(2022, 5, 8, 11, 29, 45, 750, DateTimeKind.Unspecified).AddTicks(1802), new DateTime(2020, 4, 18, 23, 24, 35, 868, DateTimeKind.Unspecified).AddTicks(4936), 2, new DateTime(2022, 1, 11, 5, 53, 14, 558, DateTimeKind.Unspecified).AddTicks(4602), 19L },
                    { 46L, 136.02m, new DateTime(2021, 7, 16, 11, 25, 40, 897, DateTimeKind.Unspecified).AddTicks(248), false, "anubxvyyxivpdltm", new DateTime(2020, 10, 12, 5, 19, 26, 914, DateTimeKind.Unspecified).AddTicks(5731), new DateTime(2017, 9, 25, 23, 55, 17, 231, DateTimeKind.Unspecified).AddTicks(83), 1, new DateTime(2020, 5, 13, 4, 47, 31, 215, DateTimeKind.Unspecified).AddTicks(8901), 36L },
                    { 47L, 136.02m, new DateTime(2024, 4, 29, 6, 45, 52, 160, DateTimeKind.Unspecified).AddTicks(5689), false, "ab681sgffu1ituio", new DateTime(2023, 8, 6, 18, 55, 56, 193, DateTimeKind.Unspecified).AddTicks(2414), new DateTime(2023, 2, 10, 23, 41, 56, 808, DateTimeKind.Unspecified).AddTicks(4298), 1, new DateTime(2023, 7, 15, 2, 4, 41, 903, DateTimeKind.Unspecified).AddTicks(5199), 7L },
                    { 48L, 151.37m, new DateTime(2023, 8, 29, 21, 21, 6, 454, DateTimeKind.Unspecified).AddTicks(338), true, "noq0gqauqw1mppw5", new DateTime(2023, 2, 7, 20, 58, 40, 693, DateTimeKind.Unspecified).AddTicks(5193), new DateTime(2022, 7, 4, 20, 39, 15, 224, DateTimeKind.Unspecified).AddTicks(4807), 2, new DateTime(2022, 11, 9, 14, 59, 26, 734, DateTimeKind.Unspecified).AddTicks(2376), 4L },
                    { 49L, 136.02m, new DateTime(2024, 5, 28, 7, 39, 28, 15, DateTimeKind.Unspecified).AddTicks(4528), true, "icchkz7h4bld2gyo", new DateTime(2023, 8, 6, 10, 40, 20, 374, DateTimeKind.Unspecified).AddTicks(2968), new DateTime(2023, 1, 22, 7, 25, 27, 344, DateTimeKind.Unspecified).AddTicks(616), 1, new DateTime(2023, 8, 1, 17, 31, 36, 95, DateTimeKind.Unspecified).AddTicks(9691), 23L },
                    { 50L, 151.37m, new DateTime(2023, 6, 16, 13, 16, 42, 833, DateTimeKind.Unspecified).AddTicks(2872), false, "dqu9ioacwoh3dt9r", new DateTime(2023, 5, 3, 11, 19, 20, 872, DateTimeKind.Unspecified).AddTicks(432), new DateTime(2023, 2, 25, 14, 14, 17, 700, DateTimeKind.Unspecified).AddTicks(9555), 2, null, 28L },
                    { 51L, 136.02m, new DateTime(2023, 3, 27, 19, 3, 35, 139, DateTimeKind.Unspecified).AddTicks(7302), false, "hlzcjv8mdw4u5yyf", new DateTime(2022, 4, 10, 12, 36, 59, 830, DateTimeKind.Unspecified).AddTicks(8910), new DateTime(2021, 5, 16, 20, 33, 59, 616, DateTimeKind.Unspecified).AddTicks(3349), 1, new DateTime(2023, 4, 23, 20, 13, 14, 939, DateTimeKind.Unspecified).AddTicks(7950), 1L },
                    { 52L, 91.86m, new DateTime(2023, 5, 18, 1, 39, 7, 59, DateTimeKind.Unspecified).AddTicks(7182), false, "y089embtn7rxpys0", new DateTime(2022, 9, 6, 4, 7, 51, 758, DateTimeKind.Unspecified).AddTicks(9707), new DateTime(2021, 10, 15, 14, 26, 17, 526, DateTimeKind.Unspecified).AddTicks(9765), 3, new DateTime(2022, 7, 10, 19, 23, 42, 316, DateTimeKind.Unspecified).AddTicks(6317), 18L },
                    { 53L, 136.02m, new DateTime(2023, 9, 9, 21, 18, 11, 885, DateTimeKind.Unspecified).AddTicks(6099), true, "l2cv2onna8ejmz8r", new DateTime(2023, 7, 5, 13, 59, 18, 383, DateTimeKind.Unspecified).AddTicks(487), new DateTime(2021, 9, 8, 10, 50, 33, 127, DateTimeKind.Unspecified).AddTicks(5740), 1, new DateTime(2021, 10, 4, 2, 39, 10, 285, DateTimeKind.Unspecified).AddTicks(3181), 23L }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "Cost", "EndDate", "IsActive", "PaymentSubscriptionId", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate", "UserId" },
                values: new object[,]
                {
                    { 54L, 136.02m, new DateTime(2023, 12, 3, 23, 6, 21, 949, DateTimeKind.Unspecified).AddTicks(4930), true, "gfy34t1jeinb9gqz", new DateTime(2023, 5, 20, 22, 3, 9, 142, DateTimeKind.Unspecified).AddTicks(7452), new DateTime(2023, 2, 26, 10, 27, 23, 500, DateTimeKind.Unspecified).AddTicks(9788), 1, new DateTime(2023, 4, 12, 5, 26, 20, 667, DateTimeKind.Unspecified).AddTicks(7629), 22L },
                    { 55L, 91.86m, new DateTime(2022, 7, 24, 0, 16, 37, 447, DateTimeKind.Unspecified).AddTicks(2634), true, "nzwe7ojkc9empkjg", new DateTime(2022, 3, 26, 23, 43, 58, 530, DateTimeKind.Unspecified).AddTicks(4285), new DateTime(2022, 1, 19, 7, 8, 42, 909, DateTimeKind.Unspecified).AddTicks(9446), 3, new DateTime(2023, 6, 28, 23, 59, 32, 976, DateTimeKind.Unspecified).AddTicks(6177), 8L },
                    { 56L, 136.02m, new DateTime(2023, 9, 15, 21, 15, 51, 843, DateTimeKind.Unspecified).AddTicks(7400), false, "j7d2e9j71hg4xncp", new DateTime(2023, 8, 22, 10, 32, 19, 602, DateTimeKind.Unspecified).AddTicks(4628), new DateTime(2023, 7, 15, 0, 10, 56, 848, DateTimeKind.Unspecified).AddTicks(7432), 1, new DateTime(2023, 7, 19, 12, 1, 26, 203, DateTimeKind.Unspecified).AddTicks(596), 39L },
                    { 57L, 136.02m, new DateTime(2021, 10, 22, 22, 19, 8, 534, DateTimeKind.Unspecified).AddTicks(6555), false, "l7ao3a4qisuzah62", new DateTime(2021, 9, 7, 2, 48, 56, 687, DateTimeKind.Unspecified).AddTicks(9359), new DateTime(2021, 2, 16, 14, 42, 9, 970, DateTimeKind.Unspecified).AddTicks(7286), 1, new DateTime(2022, 2, 23, 9, 2, 50, 354, DateTimeKind.Unspecified).AddTicks(7678), 30L },
                    { 58L, 91.86m, new DateTime(2023, 9, 27, 20, 43, 4, 392, DateTimeKind.Unspecified).AddTicks(7891), true, "if58xh1fxeg6zu3r", new DateTime(2022, 12, 11, 11, 14, 36, 571, DateTimeKind.Unspecified).AddTicks(1373), new DateTime(2022, 11, 8, 5, 14, 28, 499, DateTimeKind.Unspecified).AddTicks(5529), 3, new DateTime(2023, 2, 22, 2, 3, 15, 1, DateTimeKind.Unspecified).AddTicks(2052), 15L },
                    { 59L, 151.37m, new DateTime(2023, 7, 1, 1, 6, 32, 789, DateTimeKind.Unspecified).AddTicks(7160), false, "xw8vj1u6nq6o4wt0", new DateTime(2023, 6, 21, 15, 58, 22, 311, DateTimeKind.Unspecified).AddTicks(8541), new DateTime(2022, 3, 28, 4, 56, 6, 671, DateTimeKind.Unspecified).AddTicks(3125), 2, new DateTime(2023, 8, 10, 3, 15, 45, 200, DateTimeKind.Unspecified).AddTicks(1323), 31L },
                    { 60L, 136.02m, new DateTime(2023, 6, 15, 22, 10, 12, 666, DateTimeKind.Unspecified).AddTicks(9093), true, "2tufsfq40oa185wv", new DateTime(2022, 10, 8, 7, 58, 21, 479, DateTimeKind.Unspecified).AddTicks(177), new DateTime(2022, 6, 30, 5, 5, 36, 602, DateTimeKind.Unspecified).AddTicks(7595), 1, new DateTime(2022, 12, 25, 12, 4, 10, 295, DateTimeKind.Unspecified).AddTicks(3467), 23L },
                    { 61L, 136.02m, new DateTime(2023, 8, 20, 9, 30, 19, 74, DateTimeKind.Unspecified).AddTicks(8869), false, "wmcdbjgysdsp6fe8", new DateTime(2023, 1, 8, 4, 13, 25, 202, DateTimeKind.Unspecified).AddTicks(4722), new DateTime(2022, 7, 6, 11, 16, 3, 974, DateTimeKind.Unspecified).AddTicks(4040), 1, new DateTime(2023, 5, 20, 15, 45, 6, 439, DateTimeKind.Unspecified).AddTicks(1562), 40L },
                    { 62L, 151.37m, new DateTime(2023, 9, 30, 23, 48, 3, 335, DateTimeKind.Unspecified).AddTicks(2668), true, "i6bqfv7n7ei52dtg", new DateTime(2023, 5, 22, 0, 47, 55, 813, DateTimeKind.Unspecified).AddTicks(3083), new DateTime(2021, 6, 22, 16, 18, 35, 265, DateTimeKind.Unspecified).AddTicks(4524), 2, new DateTime(2021, 12, 6, 4, 8, 48, 142, DateTimeKind.Unspecified).AddTicks(6639), 10L },
                    { 63L, 136.02m, new DateTime(2024, 2, 16, 10, 38, 51, 73, DateTimeKind.Unspecified).AddTicks(7108), false, "va8nr6u4vqv58pix", new DateTime(2023, 3, 20, 20, 15, 58, 185, DateTimeKind.Unspecified).AddTicks(9680), new DateTime(2021, 8, 24, 23, 17, 7, 972, DateTimeKind.Unspecified).AddTicks(9613), 1, new DateTime(2022, 2, 14, 18, 28, 35, 312, DateTimeKind.Unspecified).AddTicks(5476), 7L },
                    { 64L, 151.37m, new DateTime(2022, 12, 23, 6, 3, 47, 270, DateTimeKind.Unspecified).AddTicks(9796), false, "7779iv8ah6v5mjw1", new DateTime(2022, 6, 25, 11, 32, 19, 135, DateTimeKind.Unspecified).AddTicks(3842), new DateTime(2021, 12, 10, 0, 18, 6, 641, DateTimeKind.Unspecified).AddTicks(7310), 2, new DateTime(2023, 1, 31, 9, 7, 21, 52, DateTimeKind.Unspecified).AddTicks(4682), 23L },
                    { 65L, 151.37m, new DateTime(2023, 4, 8, 22, 38, 1, 29, DateTimeKind.Unspecified).AddTicks(2765), false, "tbp7qw8m3mfjyklz", new DateTime(2022, 6, 11, 7, 32, 32, 291, DateTimeKind.Unspecified).AddTicks(6257), new DateTime(2022, 5, 14, 22, 56, 19, 155, DateTimeKind.Unspecified).AddTicks(2595), 2, new DateTime(2022, 10, 26, 10, 1, 3, 76, DateTimeKind.Unspecified).AddTicks(7660), 21L },
                    { 66L, 136.02m, new DateTime(2023, 9, 21, 6, 41, 8, 207, DateTimeKind.Unspecified).AddTicks(3138), true, "8g7ixv4jzog650kl", new DateTime(2023, 8, 15, 5, 34, 9, 332, DateTimeKind.Unspecified).AddTicks(1079), new DateTime(2019, 3, 28, 5, 33, 14, 197, DateTimeKind.Unspecified).AddTicks(8574), 1, new DateTime(2020, 11, 10, 3, 24, 30, 912, DateTimeKind.Unspecified).AddTicks(8559), 38L },
                    { 67L, 91.86m, new DateTime(2021, 8, 27, 12, 38, 20, 680, DateTimeKind.Unspecified).AddTicks(435), true, "sbtx06pg02z9opp8", new DateTime(2021, 7, 19, 10, 19, 35, 95, DateTimeKind.Unspecified).AddTicks(632), new DateTime(2020, 9, 10, 15, 27, 5, 385, DateTimeKind.Unspecified).AddTicks(6618), 3, new DateTime(2021, 12, 2, 18, 27, 33, 292, DateTimeKind.Unspecified).AddTicks(6889), 20L },
                    { 68L, 91.86m, new DateTime(2020, 5, 24, 0, 36, 18, 905, DateTimeKind.Unspecified).AddTicks(7923), true, "z24labjvd7qm17jt", new DateTime(2020, 5, 6, 22, 51, 21, 383, DateTimeKind.Unspecified).AddTicks(6811), new DateTime(2020, 1, 19, 13, 34, 26, 141, DateTimeKind.Unspecified).AddTicks(877), 3, new DateTime(2021, 2, 19, 0, 39, 41, 377, DateTimeKind.Unspecified).AddTicks(6985), 39L },
                    { 69L, 136.02m, new DateTime(2024, 7, 1, 7, 11, 30, 107, DateTimeKind.Unspecified).AddTicks(642), true, "jti7tswdhcxx146p", new DateTime(2023, 7, 5, 18, 25, 2, 124, DateTimeKind.Unspecified).AddTicks(5387), new DateTime(2023, 5, 23, 20, 17, 35, 281, DateTimeKind.Unspecified).AddTicks(8944), 1, new DateTime(2023, 5, 31, 11, 28, 49, 694, DateTimeKind.Unspecified).AddTicks(2899), 23L },
                    { 70L, 151.37m, new DateTime(2022, 9, 29, 21, 47, 21, 434, DateTimeKind.Unspecified).AddTicks(5405), false, "dqb49qfp6v2htb1l", new DateTime(2022, 6, 18, 0, 3, 33, 197, DateTimeKind.Unspecified).AddTicks(2208), new DateTime(2019, 7, 30, 18, 32, 55, 587, DateTimeKind.Unspecified).AddTicks(8019), 2, new DateTime(2022, 1, 18, 13, 55, 50, 276, DateTimeKind.Unspecified).AddTicks(7393), 13L },
                    { 71L, 136.02m, new DateTime(2023, 4, 12, 20, 45, 12, 968, DateTimeKind.Unspecified).AddTicks(9640), true, "tfjxef8gm7u3gr4q", new DateTime(2023, 3, 19, 16, 35, 48, 749, DateTimeKind.Unspecified).AddTicks(5806), new DateTime(2023, 2, 15, 2, 50, 14, 598, DateTimeKind.Unspecified).AddTicks(7934), 1, new DateTime(2023, 6, 23, 18, 20, 53, 402, DateTimeKind.Unspecified).AddTicks(8518), 37L },
                    { 72L, 151.37m, new DateTime(2023, 12, 17, 4, 33, 57, 807, DateTimeKind.Unspecified).AddTicks(2277), false, "2b5myh0ryhbt7haq", new DateTime(2023, 6, 19, 20, 19, 50, 238, DateTimeKind.Unspecified).AddTicks(1506), new DateTime(2023, 3, 19, 5, 58, 7, 978, DateTimeKind.Unspecified).AddTicks(9034), 2, new DateTime(2023, 8, 14, 17, 16, 43, 983, DateTimeKind.Unspecified).AddTicks(6505), 26L },
                    { 73L, 136.02m, new DateTime(2024, 1, 13, 7, 59, 3, 222, DateTimeKind.Unspecified).AddTicks(9253), true, "8ds2vlr4ibv39lh4", new DateTime(2023, 7, 26, 12, 47, 2, 225, DateTimeKind.Unspecified).AddTicks(5298), new DateTime(2022, 1, 7, 5, 23, 39, 957, DateTimeKind.Unspecified).AddTicks(116), 1, new DateTime(2022, 7, 6, 17, 21, 1, 75, DateTimeKind.Unspecified).AddTicks(3845), 9L },
                    { 74L, 136.02m, new DateTime(2023, 11, 1, 17, 23, 52, 504, DateTimeKind.Unspecified).AddTicks(2572), true, "xzjgtbq46mekoxwc", new DateTime(2023, 3, 20, 6, 13, 56, 289, DateTimeKind.Unspecified).AddTicks(1126), new DateTime(2019, 4, 16, 9, 9, 32, 209, DateTimeKind.Unspecified).AddTicks(1445), 1, new DateTime(2020, 2, 23, 19, 49, 36, 674, DateTimeKind.Unspecified).AddTicks(9168), 30L },
                    { 75L, 91.86m, new DateTime(2023, 9, 9, 8, 43, 6, 615, DateTimeKind.Unspecified).AddTicks(3454), true, "4qdes62xud4v2bb7", new DateTime(2023, 6, 22, 17, 39, 33, 442, DateTimeKind.Unspecified).AddTicks(6281), new DateTime(2023, 3, 7, 0, 37, 38, 988, DateTimeKind.Unspecified).AddTicks(1396), 3, new DateTime(2023, 8, 7, 22, 21, 56, 120, DateTimeKind.Unspecified).AddTicks(4386), 24L },
                    { 76L, 151.37m, new DateTime(2024, 1, 8, 13, 27, 34, 668, DateTimeKind.Unspecified).AddTicks(2937), true, "6s7a0msqiic2ybbz", new DateTime(2023, 3, 14, 10, 55, 16, 741, DateTimeKind.Unspecified).AddTicks(7526), new DateTime(2023, 1, 5, 15, 9, 50, 467, DateTimeKind.Unspecified).AddTicks(5474), 2, new DateTime(2023, 1, 13, 2, 34, 33, 746, DateTimeKind.Unspecified).AddTicks(5843), 23L },
                    { 77L, 151.37m, new DateTime(2022, 11, 26, 6, 57, 21, 957, DateTimeKind.Unspecified).AddTicks(1132), true, "u2bu9ut7a380yrw7", new DateTime(2021, 12, 9, 0, 14, 55, 374, DateTimeKind.Unspecified).AddTicks(8979), new DateTime(2019, 10, 31, 17, 54, 2, 511, DateTimeKind.Unspecified).AddTicks(1837), 2, new DateTime(2020, 10, 26, 21, 10, 58, 746, DateTimeKind.Unspecified).AddTicks(6114), 24L },
                    { 78L, 136.02m, new DateTime(2023, 9, 7, 14, 10, 13, 5, DateTimeKind.Unspecified).AddTicks(9404), false, "gx2r65g5hsfxbxgo", new DateTime(2023, 8, 9, 3, 1, 47, 473, DateTimeKind.Unspecified).AddTicks(5065), new DateTime(2023, 5, 30, 2, 32, 34, 96, DateTimeKind.Unspecified).AddTicks(4736), 1, null, 28L },
                    { 79L, 136.02m, new DateTime(2022, 3, 5, 23, 24, 5, 922, DateTimeKind.Unspecified).AddTicks(4482), false, "jjpfoqglt2ecr215", new DateTime(2021, 10, 31, 0, 26, 30, 929, DateTimeKind.Unspecified).AddTicks(5760), new DateTime(2021, 6, 26, 0, 55, 37, 882, DateTimeKind.Unspecified).AddTicks(743), 1, new DateTime(2023, 8, 3, 19, 29, 26, 385, DateTimeKind.Unspecified).AddTicks(2984), 27L },
                    { 80L, 91.86m, new DateTime(2019, 5, 23, 8, 44, 0, 500, DateTimeKind.Unspecified).AddTicks(2933), false, "xnuthf65wa7mg0gr", new DateTime(2018, 11, 13, 0, 13, 27, 79, DateTimeKind.Unspecified).AddTicks(9145), new DateTime(2017, 4, 4, 9, 2, 59, 795, DateTimeKind.Unspecified).AddTicks(8071), 3, new DateTime(2017, 12, 18, 21, 12, 5, 583, DateTimeKind.Unspecified).AddTicks(4396), 14L },
                    { 81L, 136.02m, new DateTime(2022, 10, 4, 12, 54, 10, 666, DateTimeKind.Unspecified).AddTicks(7817), false, "3m6zsvfkn1i0vm3e", new DateTime(2021, 11, 25, 8, 22, 25, 971, DateTimeKind.Unspecified).AddTicks(9085), new DateTime(2020, 4, 2, 3, 43, 52, 852, DateTimeKind.Unspecified).AddTicks(5915), 1, new DateTime(2021, 8, 21, 21, 25, 4, 976, DateTimeKind.Unspecified).AddTicks(2346), 36L },
                    { 82L, 151.37m, new DateTime(2024, 2, 16, 1, 39, 13, 271, DateTimeKind.Unspecified).AddTicks(6178), false, "mrtium4tr7pv86d0", new DateTime(2023, 8, 14, 2, 59, 3, 486, DateTimeKind.Unspecified).AddTicks(5550), new DateTime(2023, 8, 8, 7, 2, 39, 228, DateTimeKind.Unspecified).AddTicks(7381), 2, new DateTime(2023, 8, 14, 16, 16, 38, 364, DateTimeKind.Unspecified).AddTicks(6168), 34L },
                    { 83L, 91.86m, new DateTime(2024, 1, 20, 14, 54, 21, 934, DateTimeKind.Unspecified).AddTicks(6422), false, "qpd9nfspxjd01xp0", new DateTime(2023, 2, 21, 19, 47, 5, 587, DateTimeKind.Unspecified).AddTicks(7648), new DateTime(2022, 2, 22, 10, 28, 6, 170, DateTimeKind.Unspecified).AddTicks(8588), 3, new DateTime(2022, 6, 26, 15, 4, 59, 332, DateTimeKind.Unspecified).AddTicks(7640), 37L },
                    { 84L, 136.02m, new DateTime(2024, 5, 16, 9, 32, 56, 647, DateTimeKind.Unspecified).AddTicks(3167), false, "wfn8fa46w4r59v5c", new DateTime(2023, 7, 21, 14, 42, 3, 161, DateTimeKind.Unspecified).AddTicks(914), new DateTime(2023, 5, 5, 16, 44, 38, 714, DateTimeKind.Unspecified).AddTicks(304), 1, new DateTime(2023, 6, 13, 14, 24, 47, 145, DateTimeKind.Unspecified).AddTicks(2271), 18L },
                    { 85L, 136.02m, new DateTime(2023, 8, 2, 10, 58, 47, 366, DateTimeKind.Unspecified).AddTicks(3425), true, "wyht67sijod7rj9m", new DateTime(2023, 6, 4, 18, 57, 23, 460, DateTimeKind.Unspecified).AddTicks(8900), new DateTime(2020, 2, 28, 5, 4, 51, 792, DateTimeKind.Unspecified).AddTicks(8627), 1, new DateTime(2022, 2, 18, 13, 6, 42, 550, DateTimeKind.Unspecified).AddTicks(8361), 17L },
                    { 86L, 136.02m, new DateTime(2023, 5, 8, 15, 1, 28, 421, DateTimeKind.Unspecified).AddTicks(1422), false, "jx8v9gvjgqbhtb0p", new DateTime(2022, 11, 3, 5, 40, 42, 864, DateTimeKind.Unspecified).AddTicks(6156), new DateTime(2021, 9, 27, 21, 55, 45, 459, DateTimeKind.Unspecified).AddTicks(6600), 1, new DateTime(2023, 7, 12, 7, 36, 30, 939, DateTimeKind.Unspecified).AddTicks(8201), 13L },
                    { 87L, 91.86m, new DateTime(2023, 10, 9, 14, 14, 27, 996, DateTimeKind.Unspecified).AddTicks(2827), true, "rcan81qc7fa8yw83", new DateTime(2023, 7, 15, 23, 7, 44, 65, DateTimeKind.Unspecified).AddTicks(9196), new DateTime(2023, 7, 14, 16, 50, 39, 632, DateTimeKind.Unspecified).AddTicks(3964), 3, new DateTime(2023, 8, 14, 1, 59, 57, 544, DateTimeKind.Unspecified).AddTicks(3468), 33L },
                    { 88L, 91.86m, new DateTime(2022, 2, 19, 18, 4, 58, 815, DateTimeKind.Unspecified).AddTicks(6471), true, "5emwz6jldc4x58af", new DateTime(2022, 2, 6, 1, 2, 43, 67, DateTimeKind.Unspecified).AddTicks(757), new DateTime(2021, 2, 26, 14, 29, 46, 93, DateTimeKind.Unspecified).AddTicks(7134), 3, new DateTime(2023, 2, 1, 23, 45, 46, 235, DateTimeKind.Unspecified).AddTicks(7568), 40L },
                    { 89L, 91.86m, new DateTime(2024, 5, 4, 0, 10, 5, 114, DateTimeKind.Unspecified).AddTicks(8514), false, "1hro6jnzj7hueud0", new DateTime(2023, 7, 18, 18, 30, 37, 659, DateTimeKind.Unspecified).AddTicks(6753), new DateTime(2023, 5, 17, 20, 35, 51, 688, DateTimeKind.Unspecified).AddTicks(843), 3, new DateTime(2023, 6, 17, 0, 29, 8, 15, DateTimeKind.Unspecified).AddTicks(4865), 37L },
                    { 90L, 136.02m, new DateTime(2024, 5, 11, 8, 16, 31, 334, DateTimeKind.Unspecified).AddTicks(4447), true, "jb19he1dn7vheueu", new DateTime(2023, 8, 9, 0, 27, 38, 180, DateTimeKind.Unspecified).AddTicks(870), new DateTime(2023, 1, 10, 1, 2, 30, 718, DateTimeKind.Unspecified).AddTicks(157), 1, null, 28L },
                    { 91L, 136.02m, new DateTime(2022, 2, 1, 17, 25, 17, 342, DateTimeKind.Unspecified).AddTicks(1039), true, "l9hcw3mpj65vhei4", new DateTime(2021, 2, 5, 10, 34, 55, 397, DateTimeKind.Unspecified).AddTicks(674), new DateTime(2020, 6, 17, 8, 45, 5, 958, DateTimeKind.Unspecified).AddTicks(3921), 1, new DateTime(2023, 4, 14, 10, 47, 45, 522, DateTimeKind.Unspecified).AddTicks(8047), 7L },
                    { 92L, 136.02m, new DateTime(2024, 1, 16, 21, 45, 10, 500, DateTimeKind.Unspecified).AddTicks(5145), true, "a0yox0t3avo8xphk", new DateTime(2023, 5, 12, 21, 52, 59, 722, DateTimeKind.Unspecified).AddTicks(4717), new DateTime(2023, 4, 12, 20, 56, 2, 799, DateTimeKind.Unspecified).AddTicks(1682), 1, new DateTime(2023, 6, 23, 16, 36, 14, 904, DateTimeKind.Unspecified).AddTicks(7526), 24L },
                    { 93L, 136.02m, new DateTime(2024, 1, 2, 21, 17, 11, 170, DateTimeKind.Unspecified).AddTicks(2458), true, "m8rn9t5pne2v4ysj", new DateTime(2023, 4, 14, 8, 18, 27, 590, DateTimeKind.Unspecified).AddTicks(9052), new DateTime(2022, 9, 24, 1, 41, 49, 527, DateTimeKind.Unspecified).AddTicks(3874), 1, new DateTime(2022, 12, 24, 3, 36, 23, 454, DateTimeKind.Unspecified).AddTicks(165), 15L },
                    { 94L, 91.86m, new DateTime(2023, 1, 24, 22, 40, 30, 697, DateTimeKind.Unspecified).AddTicks(5496), false, "mmluyddqoo1o85th", new DateTime(2022, 6, 9, 8, 1, 48, 104, DateTimeKind.Unspecified).AddTicks(5171), new DateTime(2021, 1, 22, 1, 29, 5, 516, DateTimeKind.Unspecified).AddTicks(910), 3, new DateTime(2022, 8, 6, 21, 10, 0, 197, DateTimeKind.Unspecified).AddTicks(1806), 30L },
                    { 95L, 136.02m, new DateTime(2023, 1, 6, 22, 1, 10, 936, DateTimeKind.Unspecified).AddTicks(1482), true, "cevlzqkc2a1n7br9", new DateTime(2022, 2, 13, 12, 33, 29, 154, DateTimeKind.Unspecified).AddTicks(375), new DateTime(2020, 11, 3, 9, 12, 7, 304, DateTimeKind.Unspecified).AddTicks(9561), 1, new DateTime(2021, 2, 21, 7, 34, 27, 297, DateTimeKind.Unspecified).AddTicks(6524), 2L }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "Cost", "EndDate", "IsActive", "PaymentSubscriptionId", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate", "UserId" },
                values: new object[,]
                {
                    { 96L, 91.86m, new DateTime(2023, 9, 7, 5, 46, 40, 677, DateTimeKind.Unspecified).AddTicks(8995), true, "93vrpnu06yhjisrx", new DateTime(2023, 7, 26, 22, 10, 50, 659, DateTimeKind.Unspecified).AddTicks(4272), new DateTime(2022, 5, 26, 21, 31, 49, 345, DateTimeKind.Unspecified).AddTicks(5002), 3, new DateTime(2022, 8, 12, 15, 34, 45, 105, DateTimeKind.Unspecified).AddTicks(5356), 5L },
                    { 97L, 136.02m, new DateTime(2022, 8, 12, 13, 0, 15, 854, DateTimeKind.Unspecified).AddTicks(9512), true, "7biaezr83ocwvtne", new DateTime(2021, 10, 18, 23, 41, 32, 603, DateTimeKind.Unspecified).AddTicks(2598), new DateTime(2021, 2, 20, 23, 17, 13, 455, DateTimeKind.Unspecified).AddTicks(3843), 1, new DateTime(2021, 8, 28, 5, 37, 53, 723, DateTimeKind.Unspecified).AddTicks(9370), 19L },
                    { 98L, 136.02m, new DateTime(2023, 11, 30, 11, 12, 8, 583, DateTimeKind.Unspecified).AddTicks(8724), true, "k9c7hc23tgje5jm7", new DateTime(2023, 6, 24, 7, 28, 56, 718, DateTimeKind.Unspecified).AddTicks(6649), new DateTime(2022, 8, 17, 12, 19, 15, 680, DateTimeKind.Unspecified).AddTicks(8544), 1, new DateTime(2023, 7, 1, 16, 19, 17, 759, DateTimeKind.Unspecified).AddTicks(7929), 8L },
                    { 99L, 136.02m, new DateTime(2020, 9, 15, 16, 9, 28, 513, DateTimeKind.Unspecified).AddTicks(1663), false, "17h3p0lzj9p4mkrq", new DateTime(2020, 6, 13, 19, 5, 55, 130, DateTimeKind.Unspecified).AddTicks(7841), new DateTime(2018, 4, 14, 23, 3, 49, 326, DateTimeKind.Unspecified).AddTicks(251), 1, new DateTime(2019, 9, 1, 12, 4, 59, 695, DateTimeKind.Unspecified).AddTicks(8179), 24L },
                    { 100L, 151.37m, new DateTime(2024, 6, 11, 16, 44, 18, 894, DateTimeKind.Unspecified).AddTicks(5701), false, "ea2krxtp615avzdt", new DateTime(2023, 8, 14, 22, 15, 48, 274, DateTimeKind.Unspecified).AddTicks(5277), new DateTime(2023, 6, 16, 2, 11, 48, 613, DateTimeKind.Unspecified).AddTicks(3251), 2, new DateTime(2023, 7, 19, 20, 42, 51, 761, DateTimeKind.Unspecified).AddTicks(5803), 35L },
                    { 101L, 136.02m, new DateTime(2023, 12, 9, 0, 53, 39, 104, DateTimeKind.Unspecified).AddTicks(5108), false, "hp86so1sykofx18m", new DateTime(2023, 7, 10, 12, 53, 18, 389, DateTimeKind.Unspecified).AddTicks(7770), new DateTime(2023, 5, 7, 13, 19, 11, 536, DateTimeKind.Unspecified).AddTicks(3303), 1, new DateTime(2023, 6, 27, 20, 4, 51, 710, DateTimeKind.Unspecified).AddTicks(9363), 19L },
                    { 102L, 151.37m, new DateTime(2022, 5, 1, 4, 16, 24, 415, DateTimeKind.Unspecified).AddTicks(9252), false, "v9jped3wpf21omxi", new DateTime(2022, 1, 9, 5, 20, 38, 815, DateTimeKind.Unspecified).AddTicks(6200), new DateTime(2021, 4, 30, 21, 47, 8, 460, DateTimeKind.Unspecified).AddTicks(8414), 2, new DateTime(2023, 7, 28, 12, 42, 39, 797, DateTimeKind.Unspecified).AddTicks(3431), 40L },
                    { 103L, 91.86m, new DateTime(2023, 8, 29, 5, 16, 59, 204, DateTimeKind.Unspecified).AddTicks(7250), false, "a7ftky80unai4cdk", new DateTime(2022, 9, 11, 22, 22, 53, 511, DateTimeKind.Unspecified).AddTicks(5558), new DateTime(2021, 9, 10, 18, 29, 10, 677, DateTimeKind.Unspecified).AddTicks(5873), 3, new DateTime(2022, 2, 10, 7, 36, 5, 433, DateTimeKind.Unspecified).AddTicks(8819), 20L },
                    { 104L, 136.02m, new DateTime(2022, 6, 30, 0, 39, 27, 285, DateTimeKind.Unspecified).AddTicks(4649), false, "2fl25kawdqe7y9cr", new DateTime(2022, 2, 26, 7, 48, 48, 29, DateTimeKind.Unspecified).AddTicks(1933), new DateTime(2022, 2, 8, 23, 48, 12, 449, DateTimeKind.Unspecified).AddTicks(281), 1, new DateTime(2022, 9, 28, 7, 9, 15, 709, DateTimeKind.Unspecified).AddTicks(9032), 8L },
                    { 105L, 151.37m, new DateTime(2020, 10, 12, 12, 51, 40, 203, DateTimeKind.Unspecified).AddTicks(5568), true, "yrti9du39mr5c5va", new DateTime(2019, 11, 3, 17, 23, 9, 309, DateTimeKind.Unspecified).AddTicks(4983), new DateTime(2017, 6, 20, 13, 13, 57, 405, DateTimeKind.Unspecified).AddTicks(1503), 2, new DateTime(2018, 7, 29, 17, 44, 5, 106, DateTimeKind.Unspecified).AddTicks(6228), 14L },
                    { 106L, 136.02m, new DateTime(2023, 12, 1, 2, 2, 48, 535, DateTimeKind.Unspecified).AddTicks(2616), true, "fybw1xhn0y3drrm0", new DateTime(2023, 5, 27, 13, 43, 52, 549, DateTimeKind.Unspecified).AddTicks(3286), new DateTime(2023, 4, 12, 17, 39, 38, 974, DateTimeKind.Unspecified).AddTicks(8662), 1, new DateTime(2023, 5, 9, 15, 57, 14, 836, DateTimeKind.Unspecified).AddTicks(3790), 36L },
                    { 107L, 136.02m, new DateTime(2021, 12, 2, 6, 3, 43, 517, DateTimeKind.Unspecified).AddTicks(5545), false, "6voy90ps5l3b1y1b", new DateTime(2021, 11, 5, 19, 16, 47, 800, DateTimeKind.Unspecified).AddTicks(7766), new DateTime(2020, 8, 15, 4, 10, 22, 951, DateTimeKind.Unspecified).AddTicks(7978), 1, new DateTime(2022, 2, 12, 15, 58, 44, 399, DateTimeKind.Unspecified).AddTicks(2566), 6L },
                    { 108L, 136.02m, new DateTime(2022, 6, 7, 0, 42, 37, 363, DateTimeKind.Unspecified).AddTicks(8934), false, "r4im89p8kap58jd0", new DateTime(2021, 10, 1, 2, 36, 40, 374, DateTimeKind.Unspecified).AddTicks(5770), new DateTime(2021, 5, 16, 8, 46, 12, 699, DateTimeKind.Unspecified).AddTicks(9282), 1, new DateTime(2022, 1, 30, 3, 12, 41, 872, DateTimeKind.Unspecified).AddTicks(9741), 10L },
                    { 109L, 91.86m, new DateTime(2023, 10, 26, 20, 12, 10, 609, DateTimeKind.Unspecified).AddTicks(5012), false, "9l7e2zypb364i3jv", new DateTime(2023, 7, 29, 10, 40, 27, 702, DateTimeKind.Unspecified).AddTicks(9288), new DateTime(2023, 5, 13, 15, 40, 21, 991, DateTimeKind.Unspecified).AddTicks(8688), 3, new DateTime(2023, 8, 11, 15, 22, 19, 602, DateTimeKind.Unspecified).AddTicks(3500), 35L },
                    { 110L, 136.02m, new DateTime(2022, 12, 5, 1, 49, 7, 135, DateTimeKind.Unspecified).AddTicks(6870), true, "p45radwg6kdm2a5k", new DateTime(2022, 7, 31, 19, 50, 2, 501, DateTimeKind.Unspecified).AddTicks(2588), new DateTime(2022, 6, 1, 12, 34, 13, 903, DateTimeKind.Unspecified).AddTicks(656), 1, new DateTime(2022, 9, 22, 0, 34, 59, 615, DateTimeKind.Unspecified).AddTicks(9001), 14L }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "InitialSolution", "LanguageId", "Status" },
                values: new object[,]
                {
                    { 1L, 59L, "Doloribus modi voluptatum facere eius rerum provident nemo soluta quidem.", new DateTime(2022, 12, 23, 1, 41, 33, 245, DateTimeKind.Unspecified).AddTicks(4647), "Eos quae aliquid qui est sit quidem doloribus.", 2, 1 },
                    { 2L, 8L, "repellendus", new DateTime(2022, 3, 13, 6, 37, 41, 290, DateTimeKind.Unspecified).AddTicks(5772), "Deleniti iusto aut nesciunt modi et quibusdam corrupti nisi est.", 2, 2 },
                    { 3L, 59L, "alias", new DateTime(2022, 10, 7, 2, 56, 51, 162, DateTimeKind.Unspecified).AddTicks(3188), "Explicabo autem cum.", 2, 0 },
                    { 4L, 11L, "Eos molestias adipisci id dolores et fugit vero vitae.\nOdit aspernatur amet maxime.\nEt vel voluptatum quia quia nesciunt sequi impedit.\nVoluptas repellat nam omnis est magnam rerum eum repudiandae minima.\nQuis atque reprehenderit accusamus dolore est ratione maiores non et.", new DateTime(2023, 2, 20, 15, 39, 52, 0, DateTimeKind.Unspecified).AddTicks(437), "Voluptates facilis nisi voluptatem omnis inventore velit ipsum.", 3, 1 },
                    { 5L, 68L, "Dolores in error magni eum dolore minima amet voluptates temporibus. Magni nihil est officiis ducimus aut. Sit dicta ullam nulla. Cumque minima accusamus magnam quia laudantium.", new DateTime(2021, 10, 23, 3, 13, 11, 211, DateTimeKind.Unspecified).AddTicks(576), "Eum eligendi dolorum qui cum voluptatibus.", 3, 1 },
                    { 6L, 51L, "Corrupti iusto ipsam sapiente.\nMaxime alias nam.\nLaborum eius mollitia quis perferendis et pariatur sapiente repellat.", new DateTime(2023, 6, 14, 12, 22, 18, 557, DateTimeKind.Unspecified).AddTicks(913), "Id nulla nesciunt perferendis nesciunt minima.", 1, 1 },
                    { 7L, 70L, "Delectus voluptates dolorem laudantium laudantium.\nSequi officiis sapiente et ducimus fugiat exercitationem dolorem adipisci veniam.\nQuidem earum tempore molestias commodi eaque.\nPorro impedit libero aut.\nExpedita expedita est fugit mollitia aut ab eum.\nQuaerat consequatur distinctio illo maiores sit molestiae.", new DateTime(2023, 8, 4, 21, 31, 21, 899, DateTimeKind.Unspecified).AddTicks(6354), "Hic et officiis accusantium nostrum repellat aut et error itaque.", 1, 3 },
                    { 8L, 47L, "Enim aliquid neque nemo dolore possimus quisquam optio veniam. Qui nulla vel in. Blanditiis vel sit. Cupiditate quo quo doloribus sunt unde ex doloremque necessitatibus. Veniam dolor officiis eos molestias explicabo enim necessitatibus soluta.", new DateTime(2022, 7, 9, 9, 19, 12, 916, DateTimeKind.Unspecified).AddTicks(5478), "Aut ullam distinctio tempora omnis animi officiis.", 4, 1 },
                    { 9L, 16L, "at", new DateTime(2022, 2, 1, 0, 24, 8, 414, DateTimeKind.Unspecified).AddTicks(4513), "Libero dolorem voluptatem et vitae eius nemo.", 1, 0 },
                    { 10L, 32L, "Culpa maiores officiis deleniti cumque similique optio et sed ab. Quis voluptatem et veniam iusto rerum. Provident inventore voluptas nihil rerum totam expedita hic. Sint rerum earum facilis iusto unde nihil officia minima. Id occaecati quod. Laborum illo ipsum fuga ratione ipsa sequi.", new DateTime(2023, 7, 2, 1, 28, 28, 606, DateTimeKind.Unspecified).AddTicks(6585), "Architecto omnis necessitatibus est eum.", 2, 3 },
                    { 11L, 65L, "Omnis ea quia ea voluptatibus id laborum sit consequatur. Nisi voluptatem temporibus sed porro est. Voluptas excepturi et expedita dignissimos et. Atque aut est et. Recusandae rerum dolor assumenda maiores placeat magnam debitis. Facilis velit et qui totam et iusto consequatur ut.", new DateTime(2022, 12, 5, 9, 31, 39, 0, DateTimeKind.Unspecified).AddTicks(8110), "Itaque quidem debitis nisi voluptate.", 2, 0 },
                    { 12L, 63L, "Dolorum architecto placeat error eum aut repellendus. Est cumque velit aspernatur voluptatum fugiat. Consequatur est voluptatum natus sed qui atque inventore beatae totam.", new DateTime(2022, 9, 20, 13, 10, 18, 963, DateTimeKind.Unspecified).AddTicks(8791), "Enim nulla explicabo suscipit molestiae perferendis et.", 4, 1 },
                    { 13L, 3L, "Blanditiis quia commodi non quis voluptatem.\nNatus quis dignissimos ipsam et.\nDolores perferendis libero aspernatur praesentium sint.\nEos et at iusto illum.\nHarum in ab at at dolorem qui.", new DateTime(2023, 6, 15, 8, 3, 54, 400, DateTimeKind.Unspecified).AddTicks(6740), "Pariatur voluptas veniam rerum sed qui ipsam accusamus fuga.", 3, 3 },
                    { 14L, 58L, "Ea atque et eum est est.", new DateTime(2021, 12, 24, 3, 0, 12, 288, DateTimeKind.Unspecified).AddTicks(2169), "Omnis et illo voluptas culpa.", 1, 0 },
                    { 15L, 21L, "Quos laboriosam porro aut consequuntur a voluptas.", new DateTime(2022, 12, 28, 14, 57, 16, 522, DateTimeKind.Unspecified).AddTicks(4402), "Voluptatem non reprehenderit dolor et dolor molestias.", 4, 1 },
                    { 16L, 49L, "ea", new DateTime(2023, 3, 5, 16, 9, 12, 975, DateTimeKind.Unspecified).AddTicks(6903), "Ducimus maiores praesentium odit error.", 1, 0 },
                    { 17L, 3L, "Ratione illum a voluptatem assumenda. Quaerat est recusandae aliquam provident molestiae rerum eius accusamus rerum. Cum et officia odit aliquid saepe corrupti repellat aliquid dolorum. Quia voluptatibus dolores nostrum ab quia dolor.", new DateTime(2023, 3, 17, 1, 15, 25, 207, DateTimeKind.Unspecified).AddTicks(1571), "Atque similique dolor eos est.", 3, 1 },
                    { 18L, 2L, "Quo non aspernatur recusandae soluta ratione quibusdam et.", new DateTime(2021, 10, 23, 3, 18, 18, 931, DateTimeKind.Unspecified).AddTicks(6152), "Recusandae quo voluptatem odio rem esse quam.", 2, 1 },
                    { 19L, 38L, "Totam expedita reprehenderit sed blanditiis. Qui non aliquid. Suscipit ab eaque ea consequatur aut eum impedit natus. Sint magnam incidunt velit adipisci voluptatem.", new DateTime(2021, 6, 29, 3, 39, 6, 818, DateTimeKind.Unspecified).AddTicks(7252), "Sint tenetur sed et debitis qui eaque labore.", 1, 2 },
                    { 20L, 30L, "Odio corrupti asperiores nulla dolor ut.\nAut molestias pariatur.\nProvident ex beatae nihil numquam nihil adipisci consequatur.\nDolor quae sit consequuntur.", new DateTime(2021, 7, 14, 14, 35, 58, 753, DateTimeKind.Unspecified).AddTicks(4575), "Et iusto possimus laudantium accusantium possimus.", 2, 2 },
                    { 21L, 40L, "Ut doloremque facere similique.", new DateTime(2022, 7, 7, 17, 12, 17, 32, DateTimeKind.Unspecified).AddTicks(947), "Nisi eius repellendus labore aut aut molestiae quaerat iure voluptatem.", 4, 1 },
                    { 22L, 2L, "Et dignissimos omnis veniam.\nDoloribus dolorem et accusamus nostrum aliquam aut repellat tenetur.\nQuia impedit ut.", new DateTime(2022, 5, 26, 20, 21, 13, 834, DateTimeKind.Unspecified).AddTicks(2025), "Animi natus deserunt voluptas.", 2, 2 },
                    { 23L, 41L, "voluptates", new DateTime(2022, 3, 17, 21, 15, 0, 409, DateTimeKind.Unspecified).AddTicks(6511), "At quaerat hic facilis quod expedita.", 2, 1 },
                    { 24L, 41L, "Error iure rerum molestiae et.", new DateTime(2023, 7, 25, 6, 49, 58, 791, DateTimeKind.Unspecified).AddTicks(1084), "Quaerat perferendis iusto ea et quia cumque harum nemo aliquam.", 2, 1 },
                    { 25L, 48L, "Optio totam architecto sequi blanditiis vero nulla perspiciatis consequatur et.\nDolor ut enim atque amet.", new DateTime(2023, 8, 15, 0, 24, 23, 31, DateTimeKind.Unspecified).AddTicks(6608), "Voluptatem pariatur ut nihil aut cum vel dolorem occaecati minus.", 1, 0 },
                    { 26L, 52L, "magnam", new DateTime(2023, 5, 1, 10, 11, 4, 558, DateTimeKind.Unspecified).AddTicks(1406), "Doloribus qui perferendis odio ratione.", 2, 2 },
                    { 27L, 18L, "Commodi perferendis ut.", new DateTime(2022, 7, 17, 22, 8, 31, 285, DateTimeKind.Unspecified).AddTicks(7379), "Voluptatum amet a dolorem modi consequuntur.", 4, 2 },
                    { 28L, 69L, "Deserunt veritatis ad perferendis et nihil autem quia cupiditate.", new DateTime(2023, 3, 8, 19, 58, 3, 798, DateTimeKind.Unspecified).AddTicks(1790), "Quidem enim quae voluptatum fugit error nihil aut veritatis quo.", 1, 2 },
                    { 29L, 44L, "Aliquam ex repudiandae atque beatae odit excepturi.", new DateTime(2021, 10, 20, 20, 8, 14, 819, DateTimeKind.Unspecified).AddTicks(7643), "Maiores aut aliquid perferendis adipisci odio expedita ex nulla.", 4, 2 },
                    { 30L, 60L, "Quaerat in minus provident quae sint et dolor labore.", new DateTime(2022, 11, 22, 14, 49, 50, 618, DateTimeKind.Unspecified).AddTicks(8895), "Eius vel ut repudiandae et quis et voluptas.", 1, 1 },
                    { 31L, 53L, "Nobis ut magni harum expedita.\nVelit voluptatibus tempora explicabo quasi esse aspernatur.", new DateTime(2020, 1, 2, 11, 24, 15, 971, DateTimeKind.Unspecified).AddTicks(3970), "Aut rerum ducimus repudiandae voluptatum.", 2, 2 },
                    { 32L, 43L, "Maxime dolorem recusandae necessitatibus dolores ea velit vero laboriosam. Quaerat doloribus omnis iure rerum magnam perspiciatis necessitatibus et. Deleniti autem culpa eaque animi ut consequatur laborum laudantium. Consequatur inventore cupiditate labore voluptas officia. Ducimus aliquam eos facilis.", new DateTime(2023, 7, 30, 3, 26, 49, 890, DateTimeKind.Unspecified).AddTicks(9769), "Hic odio nostrum dicta rerum omnis voluptatem consectetur aperiam id.", 1, 2 },
                    { 33L, 38L, "Sit nulla autem hic dolore eveniet nostrum voluptatem. Et qui nulla. Velit laudantium cupiditate veritatis ex sunt aspernatur quidem voluptas non. Sit et consequatur et eius.", new DateTime(2020, 11, 14, 20, 11, 3, 252, DateTimeKind.Unspecified).AddTicks(4511), "Consequuntur autem beatae.", 4, 2 },
                    { 34L, 54L, "Voluptatem sequi aut aut nulla.", new DateTime(2023, 7, 29, 14, 21, 3, 548, DateTimeKind.Unspecified).AddTicks(5750), "Ipsa cum et.", 3, 2 },
                    { 35L, 63L, "assumenda", new DateTime(2023, 7, 19, 13, 20, 52, 358, DateTimeKind.Unspecified).AddTicks(8628), "Id enim quisquam at reprehenderit beatae magnam harum.", 2, 3 },
                    { 36L, 13L, "Expedita est perferendis dolorem earum provident distinctio consequatur animi. Consectetur ipsum et et soluta vel. Est perferendis temporibus quae fugiat est consequatur quis.", new DateTime(2022, 4, 22, 21, 46, 6, 377, DateTimeKind.Unspecified).AddTicks(8165), "Ut accusamus voluptas.", 2, 0 },
                    { 37L, 47L, "Et aliquid ratione quisquam molestiae.\nCommodi qui velit incidunt nulla.\nQuod dolorem vitae consequatur qui.\nEa animi autem qui dolores laboriosam dolores.", new DateTime(2022, 3, 19, 11, 51, 58, 11, DateTimeKind.Unspecified).AddTicks(3680), "Et at cum nulla rerum fuga impedit doloremque qui.", 1, 0 },
                    { 38L, 41L, "Optio consequuntur tempore est consequatur nemo odit quia perspiciatis.", new DateTime(2021, 9, 20, 0, 59, 33, 26, DateTimeKind.Unspecified).AddTicks(9021), "Nesciunt totam velit omnis ea quaerat vero est.", 3, 3 },
                    { 39L, 68L, "autem", new DateTime(2023, 3, 31, 16, 42, 49, 195, DateTimeKind.Unspecified).AddTicks(3250), "Rem cumque at consequatur tempora et facilis corporis ut iste.", 1, 1 },
                    { 40L, 38L, "Sit amet repudiandae unde excepturi ea et veniam veniam.\nNemo cumque ea ab.", new DateTime(2021, 12, 15, 19, 39, 52, 920, DateTimeKind.Unspecified).AddTicks(9213), "Et dolores quas ut.", 2, 0 },
                    { 41L, 39L, "Consequatur facilis quae.\nEaque doloribus aspernatur autem earum quos.\nExplicabo delectus expedita quisquam quam aspernatur vel animi nostrum.\nNecessitatibus itaque adipisci optio ab est pariatur.\nPariatur nostrum unde animi sed et illo ea sunt.", new DateTime(2022, 6, 23, 1, 43, 38, 567, DateTimeKind.Unspecified).AddTicks(5256), "Sed et harum dolores qui optio quisquam omnis est.", 2, 0 },
                    { 42L, 65L, "reprehenderit", new DateTime(2022, 10, 19, 21, 33, 38, 918, DateTimeKind.Unspecified).AddTicks(9912), "Et dolorem sed ipsum atque reiciendis corporis blanditiis qui.", 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "InitialSolution", "LanguageId", "Status" },
                values: new object[,]
                {
                    { 43L, 37L, "libero", new DateTime(2021, 10, 25, 9, 52, 26, 956, DateTimeKind.Unspecified).AddTicks(5970), "Maiores eius dolore repellat sunt velit labore dolores nulla.", 1, 3 },
                    { 44L, 62L, "debitis", new DateTime(2022, 8, 2, 0, 8, 33, 966, DateTimeKind.Unspecified).AddTicks(6750), "Et ab enim consequatur.", 2, 1 },
                    { 45L, 18L, "Qui ipsa voluptas quia enim et.\nEa dicta numquam tempore accusamus qui atque dolorum odit non.\nMolestias optio corporis fugiat quis.\nCulpa voluptatem omnis minus deserunt.\nNemo corporis corporis rerum dolor sed omnis sapiente.", new DateTime(2022, 10, 4, 21, 5, 53, 119, DateTimeKind.Unspecified).AddTicks(2745), "Voluptate quia ut culpa ut molestias autem in sit accusamus.", 3, 1 },
                    { 46L, 35L, "nostrum", new DateTime(2022, 9, 15, 12, 53, 14, 190, DateTimeKind.Unspecified).AddTicks(866), "Asperiores et impedit tenetur voluptatem.", 2, 0 },
                    { 47L, 40L, "Vel commodi et consequatur. Molestias nihil quas omnis delectus consequatur quaerat. Vel molestias exercitationem odio. Consequatur non natus ullam voluptatem vel non quaerat omnis. Ea provident eius.", new DateTime(2023, 2, 6, 5, 21, 19, 490, DateTimeKind.Unspecified).AddTicks(2729), "Facere possimus sit maxime.", 3, 1 },
                    { 48L, 10L, "Laudantium culpa accusamus fuga. Quidem excepturi ipsa explicabo. Nemo placeat soluta qui. Maxime ut cumque.", new DateTime(2021, 5, 11, 16, 54, 39, 961, DateTimeKind.Unspecified).AddTicks(3843), "Dicta et ratione dignissimos ipsam libero id iusto nobis fugiat.", 4, 2 },
                    { 49L, 23L, "Ut hic qui dolorum dolorem repudiandae doloribus laboriosam quo eligendi. Non porro est qui magni eum dolor optio. Quidem qui cumque hic maxime. Nesciunt delectus omnis vero corporis eveniet et et in quis. Ea ut quidem eius animi. Tempora in consequatur voluptas velit cum dolore dolorum ut vitae.", new DateTime(2023, 8, 12, 13, 2, 50, 841, DateTimeKind.Unspecified).AddTicks(4673), "Qui et non saepe natus rerum consequuntur vel ducimus ducimus.", 3, 0 },
                    { 50L, 3L, "Veniam et nostrum neque dolorem totam non veritatis.", new DateTime(2023, 4, 18, 23, 55, 34, 113, DateTimeKind.Unspecified).AddTicks(6612), "Officiis non possimus voluptatem natus voluptatibus.", 1, 1 },
                    { 51L, 42L, "eaque", new DateTime(2023, 1, 2, 8, 21, 31, 790, DateTimeKind.Unspecified).AddTicks(1078), "Vel aut sapiente nostrum provident.", 4, 2 },
                    { 52L, 6L, "Voluptates voluptas fugiat. Consectetur voluptates excepturi. Voluptatem illo voluptatem laborum veniam hic.", new DateTime(2023, 8, 5, 6, 25, 57, 826, DateTimeKind.Unspecified).AddTicks(6287), "Vero atque possimus.", 4, 1 },
                    { 53L, 47L, "Sit quo asperiores ut harum ut. Et ab omnis odit vitae. Autem maiores totam dolore voluptatem repellendus doloribus et beatae laudantium. Neque quos voluptates. Quis vel iure blanditiis dolorem mollitia. Est quis animi qui sed velit dolor maxime tenetur.", new DateTime(2022, 4, 4, 9, 9, 26, 420, DateTimeKind.Unspecified).AddTicks(2891), "Minus doloremque maxime aliquid molestiae nobis ut explicabo consequuntur.", 4, 1 },
                    { 54L, 55L, "Et eveniet harum labore. Est sint iure tenetur numquam dolor. Quia dolore temporibus rem suscipit excepturi dicta quas.", new DateTime(2023, 8, 11, 6, 30, 37, 212, DateTimeKind.Unspecified).AddTicks(1983), "Iusto pariatur eos sit repellat et aut autem.", 1, 2 },
                    { 55L, 15L, "Molestias natus ad quod reiciendis dolor atque.", new DateTime(2023, 6, 17, 12, 5, 26, 930, DateTimeKind.Unspecified).AddTicks(9250), "Cupiditate ad dolorem autem minus in ullam quam repellat et.", 2, 2 },
                    { 56L, 16L, "Velit repellendus ad accusamus autem facere deserunt eius illum.\nModi quia nisi quos molestiae dolorem hic consequatur omnis voluptatem.", new DateTime(2022, 12, 22, 0, 33, 59, 255, DateTimeKind.Unspecified).AddTicks(4815), "Voluptas assumenda et ut.", 3, 2 },
                    { 57L, 49L, "omnis", new DateTime(2023, 8, 19, 20, 55, 6, 954, DateTimeKind.Unspecified).AddTicks(672), "Laboriosam a laudantium delectus sed qui quod voluptatibus illo.", 1, 3 },
                    { 58L, 9L, "Repudiandae sunt sint accusamus aliquam reiciendis consectetur sint dicta eaque.\nMagni aliquam minima atque atque qui quis reprehenderit neque.\nQuaerat repudiandae est assumenda harum omnis numquam.\nDolorem placeat et veritatis voluptatem dolorum corporis qui aut.", new DateTime(2022, 10, 12, 10, 17, 12, 154, DateTimeKind.Unspecified).AddTicks(2477), "Sapiente libero vel voluptatibus et deserunt.", 4, 2 },
                    { 59L, 8L, "Voluptas labore ut expedita dolor.", new DateTime(2021, 11, 8, 20, 26, 6, 385, DateTimeKind.Unspecified).AddTicks(9798), "Eos adipisci aliquam impedit iure saepe dolores.", 1, 2 },
                    { 60L, 65L, "Deserunt debitis et illo culpa.", new DateTime(2019, 10, 13, 9, 34, 56, 328, DateTimeKind.Unspecified).AddTicks(7598), "Quod sint quis omnis et incidunt distinctio dolor distinctio doloremque.", 3, 0 },
                    { 61L, 42L, "Aut dolor eligendi mollitia aut est sunt rerum. Voluptatum qui porro fugiat. Vel inventore facilis totam consequatur consequuntur.", new DateTime(2023, 1, 22, 17, 41, 46, 502, DateTimeKind.Unspecified).AddTicks(8426), "Eligendi ducimus repudiandae dolorem tempore.", 3, 2 },
                    { 62L, 65L, "Sunt repellat et delectus deleniti. Voluptas ducimus iusto id dignissimos dolore harum vero dolor sed. Repellat fugit nihil atque molestiae itaque excepturi praesentium qui alias.", new DateTime(2021, 9, 25, 22, 47, 37, 911, DateTimeKind.Unspecified).AddTicks(3208), "Laudantium tempora voluptas quidem labore iste eligendi illo.", 4, 0 },
                    { 63L, 2L, "eum", new DateTime(2021, 6, 3, 17, 32, 9, 271, DateTimeKind.Unspecified).AddTicks(9738), "Nihil et atque est error ipsa facilis fuga voluptatem.", 1, 3 },
                    { 64L, 10L, "Placeat itaque autem non in itaque deserunt.", new DateTime(2022, 4, 17, 15, 23, 28, 418, DateTimeKind.Unspecified).AddTicks(8972), "Inventore ex minus illo accusamus mollitia fugiat ratione veritatis.", 4, 1 },
                    { 65L, 24L, "Modi necessitatibus error corporis laborum voluptatibus eum.", new DateTime(2019, 7, 11, 3, 25, 6, 901, DateTimeKind.Unspecified).AddTicks(3670), "Et aliquid corrupti neque ut mollitia aut corrupti.", 3, 2 },
                    { 66L, 37L, "quasi", new DateTime(2023, 4, 13, 6, 19, 36, 204, DateTimeKind.Unspecified).AddTicks(7825), "Eveniet est rerum porro et fugit molestiae.", 2, 2 },
                    { 67L, 41L, "Aspernatur voluptas laborum asperiores totam aperiam rerum rem eum blanditiis.\nAd sint dolorem voluptas veritatis voluptas qui vel consequatur.\nCorrupti voluptates animi reprehenderit quasi autem voluptate voluptatem excepturi.\nAut in possimus sit temporibus vel nesciunt id.", new DateTime(2022, 4, 16, 19, 3, 27, 845, DateTimeKind.Unspecified).AddTicks(9869), "Vel iusto mollitia unde dolor et voluptatem tempora.", 2, 0 },
                    { 68L, 17L, "Optio omnis et sed aut est esse perferendis animi.", new DateTime(2018, 6, 20, 6, 39, 28, 183, DateTimeKind.Unspecified).AddTicks(2529), "In nesciunt beatae vel.", 2, 2 },
                    { 69L, 63L, "Laborum veritatis libero voluptatem ut doloribus velit asperiores quam.", new DateTime(2022, 8, 30, 23, 14, 20, 420, DateTimeKind.Unspecified).AddTicks(4054), "Temporibus eum officiis omnis fugiat reiciendis dolore dolorem pariatur.", 4, 0 },
                    { 70L, 41L, "Quis voluptatem perspiciatis iusto mollitia provident non rem.\nEt unde placeat doloribus consequatur.\nEum perspiciatis temporibus illo eveniet omnis.\nSed aut est dignissimos id facilis ullam.", new DateTime(2021, 10, 13, 10, 9, 57, 291, DateTimeKind.Unspecified).AddTicks(8250), "Est quis et natus sed dolores ipsa aperiam.", 3, 2 },
                    { 71L, 36L, "Mollitia hic ratione quia dolorum consequatur consectetur quibusdam nemo et.", new DateTime(2023, 8, 19, 10, 58, 25, 754, DateTimeKind.Unspecified).AddTicks(5047), "Rerum tempore et natus dolorem.", 1, 2 },
                    { 72L, 52L, "Porro nihil minus sapiente voluptatibus delectus est. Neque rerum aut recusandae maiores harum esse nulla doloribus dolore. Alias expedita quis magnam rem.", new DateTime(2022, 11, 21, 20, 42, 34, 896, DateTimeKind.Unspecified).AddTicks(7979), "Velit iusto eum voluptatem molestiae quis ipsum officia.", 2, 2 },
                    { 73L, 37L, "Minima qui dolorum qui illo tempora et.", new DateTime(2022, 7, 24, 7, 26, 11, 759, DateTimeKind.Unspecified).AddTicks(7747), "Molestiae commodi modi magni dicta explicabo assumenda veritatis.", 4, 2 },
                    { 74L, 19L, "Voluptatem provident magnam exercitationem.", new DateTime(2021, 9, 11, 6, 31, 21, 354, DateTimeKind.Unspecified).AddTicks(2927), "Laboriosam officia ipsa debitis.", 2, 2 },
                    { 75L, 63L, "Laudantium velit et.", new DateTime(2023, 6, 7, 1, 28, 26, 185, DateTimeKind.Unspecified).AddTicks(7254), "Aut ut ut est repellendus est qui illo.", 4, 0 },
                    { 76L, 57L, "distinctio", new DateTime(2022, 5, 4, 4, 21, 18, 171, DateTimeKind.Unspecified).AddTicks(4540), "Dolore voluptatem quidem dicta.", 3, 3 },
                    { 77L, 54L, "Assumenda nulla ut ut sit id consequatur.\nSunt voluptatem quos aliquam.\nPorro eligendi aut.\nMaiores quo totam.\nDelectus tempore vel.", new DateTime(2023, 8, 14, 14, 8, 2, 346, DateTimeKind.Unspecified).AddTicks(6523), "Enim commodi dicta omnis deleniti optio earum reiciendis eos et.", 2, 0 },
                    { 78L, 49L, "voluptatem", new DateTime(2023, 6, 27, 23, 55, 6, 767, DateTimeKind.Unspecified).AddTicks(939), "Maiores qui quo velit.", 2, 2 },
                    { 79L, 16L, "Voluptatibus magnam explicabo consequatur libero.\nRatione praesentium aut ipsum officia unde magnam autem.\nSapiente officia odio dolor voluptas perferendis.\nSit amet nihil sed harum similique.", new DateTime(2023, 1, 19, 9, 51, 9, 7, DateTimeKind.Unspecified).AddTicks(8900), "Eveniet nulla id laboriosam.", 1, 1 },
                    { 80L, 38L, "aut", new DateTime(2022, 3, 7, 4, 30, 48, 33, DateTimeKind.Unspecified).AddTicks(838), "Ea dolore eligendi vitae quia repudiandae perferendis ut rerum sint.", 1, 3 },
                    { 81L, 41L, "in", new DateTime(2023, 3, 6, 17, 56, 52, 825, DateTimeKind.Unspecified).AddTicks(9035), "Voluptatem ut consequatur soluta aliquid qui sint et iure totam.", 1, 3 },
                    { 82L, 4L, "Qui dicta nisi libero aut explicabo ut beatae et aut.", new DateTime(2022, 11, 1, 13, 47, 43, 116, DateTimeKind.Unspecified).AddTicks(7913), "Nulla consequuntur qui aut velit cupiditate voluptas in.", 1, 2 },
                    { 83L, 69L, "Ut ullam molestiae nobis cumque maxime repellat id autem quae.", new DateTime(2023, 5, 10, 22, 26, 10, 238, DateTimeKind.Unspecified).AddTicks(4223), "Temporibus ducimus hic est.", 1, 2 },
                    { 84L, 9L, "Impedit fuga beatae illum necessitatibus ut earum autem temporibus repudiandae. Aut aliquid ut laboriosam inventore non fugit beatae a consequatur. Maxime est eligendi quia sint. Earum totam asperiores saepe labore temporibus.", new DateTime(2021, 4, 23, 16, 0, 38, 976, DateTimeKind.Unspecified).AddTicks(2224), "Ipsa quibusdam quaerat atque necessitatibus et voluptate eum iusto.", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "InitialSolution", "LanguageId", "Status" },
                values: new object[,]
                {
                    { 85L, 10L, "vel", new DateTime(2021, 3, 20, 10, 56, 39, 143, DateTimeKind.Unspecified).AddTicks(5960), "Consequatur omnis reiciendis aperiam.", 1, 2 },
                    { 86L, 5L, "Molestiae quia nobis qui quas at voluptatem sint sunt et.", new DateTime(2023, 8, 12, 16, 54, 1, 472, DateTimeKind.Unspecified).AddTicks(2620), "Eveniet voluptatem porro molestias hic.", 3, 0 },
                    { 87L, 42L, "aut", new DateTime(2023, 5, 20, 20, 6, 46, 944, DateTimeKind.Unspecified).AddTicks(7467), "Eveniet quasi adipisci accusantium voluptatem et fugiat provident.", 2, 2 },
                    { 88L, 10L, "Iste quaerat consequuntur porro non quisquam exercitationem. Deleniti recusandae deserunt velit nihil facilis enim. Eaque quaerat deserunt deserunt est voluptatum modi quaerat placeat et.", new DateTime(2021, 2, 15, 0, 38, 41, 314, DateTimeKind.Unspecified).AddTicks(9986), "Qui voluptas non ut.", 4, 2 },
                    { 89L, 8L, "Alias quis magnam provident quam.\nNecessitatibus reiciendis minima sint et beatae aperiam et ut delectus.\nNeque at aliquid rerum nihil id illo magni autem.\nOdio at deleniti.", new DateTime(2023, 4, 6, 21, 48, 42, 213, DateTimeKind.Unspecified).AddTicks(5516), "Rerum mollitia consequatur sint itaque ut animi voluptate fugit labore.", 2, 3 },
                    { 90L, 6L, "aut", new DateTime(2023, 8, 11, 20, 43, 25, 842, DateTimeKind.Unspecified).AddTicks(4586), "Autem asperiores eum quo quibusdam.", 3, 1 },
                    { 91L, 64L, "in", new DateTime(2021, 10, 22, 3, 16, 12, 683, DateTimeKind.Unspecified).AddTicks(8020), "Eaque harum dignissimos nemo architecto et qui in ullam assumenda.", 1, 1 },
                    { 92L, 7L, "fugit", new DateTime(2022, 10, 16, 15, 15, 34, 974, DateTimeKind.Unspecified).AddTicks(1064), "Neque vel explicabo sequi est deserunt ut quam ducimus.", 4, 2 },
                    { 93L, 53L, "Est quibusdam voluptatibus tempore saepe repellendus rerum consequatur sint harum.", new DateTime(2019, 12, 8, 15, 50, 18, 789, DateTimeKind.Unspecified).AddTicks(5021), "Voluptatum voluptatibus aut voluptate ipsum minima blanditiis voluptas.", 2, 1 },
                    { 94L, 40L, "officia", new DateTime(2023, 1, 17, 8, 4, 20, 637, DateTimeKind.Unspecified).AddTicks(7354), "Rerum et mollitia accusantium laudantium sed.", 3, 3 },
                    { 95L, 66L, "Nesciunt sit quae veniam id aut aliquid qui omnis.", new DateTime(2023, 6, 28, 1, 32, 5, 187, DateTimeKind.Unspecified).AddTicks(6375), "Et rerum ea aliquam cum est maiores quia.", 4, 1 },
                    { 96L, 20L, "sit", new DateTime(2022, 4, 27, 9, 21, 51, 398, DateTimeKind.Unspecified).AddTicks(5702), "Illum sit possimus commodi quia ad aut aut eos.", 1, 0 },
                    { 97L, 30L, "Quis aut omnis laboriosam ut et odio distinctio saepe.\nDelectus neque tempore amet adipisci debitis aut.\nCumque voluptatem distinctio assumenda impedit quidem quo.", new DateTime(2022, 6, 20, 21, 32, 48, 631, DateTimeKind.Unspecified).AddTicks(2125), "Inventore ullam ducimus pariatur iusto eligendi esse sint facilis.", 4, 0 },
                    { 98L, 18L, "Rerum iusto sit veniam dolor magnam. Ut illum architecto repudiandae explicabo quia. Ipsum qui et et beatae ipsam inventore. Ut quis dolore. Officia itaque atque quaerat voluptas molestiae.", new DateTime(2022, 5, 21, 3, 8, 51, 734, DateTimeKind.Unspecified).AddTicks(4182), "Quisquam deserunt repudiandae ut animi quaerat reprehenderit voluptas et.", 3, 3 },
                    { 99L, 58L, "facilis", new DateTime(2023, 8, 21, 0, 21, 48, 607, DateTimeKind.Unspecified).AddTicks(9972), "Iste fuga ipsum fuga inventore.", 3, 0 },
                    { 100L, 42L, "Eum provident sapiente aperiam assumenda.\nNatus inventore iste enim maiores atque et quisquam.\nQuo rerum consequatur et est repellat aperiam quaerat eligendi molestiae.", new DateTime(2023, 1, 12, 17, 50, 9, 770, DateTimeKind.Unspecified).AddTicks(1947), "Magnam laboriosam consequatur.", 2, 3 },
                    { 101L, 24L, "alias", new DateTime(2020, 5, 10, 12, 7, 59, 219, DateTimeKind.Unspecified).AddTicks(5662), "Qui incidunt minima ut ab quod nisi occaecati at molestias.", 2, 2 },
                    { 102L, 11L, "Aliquid autem ad ut est blanditiis architecto impedit.\nQuidem repudiandae possimus sed sit libero sequi quos molestiae.\nIn fuga repellat sunt et alias sunt ratione enim distinctio.\nNon quo odio harum omnis quaerat totam beatae voluptates.\nEt ex quia eum quam recusandae.", new DateTime(2020, 6, 6, 9, 13, 25, 811, DateTimeKind.Unspecified).AddTicks(7696), "Minima consectetur esse reprehenderit.", 1, 2 },
                    { 103L, 50L, "Odit beatae ipsam. Totam velit nobis velit sint natus delectus. Dolorem quod quas et a.", new DateTime(2023, 6, 27, 11, 23, 57, 812, DateTimeKind.Unspecified).AddTicks(5467), "Sapiente animi reprehenderit sit aliquid modi aliquid ut sint enim.", 4, 2 },
                    { 104L, 25L, "Libero corporis nesciunt.", new DateTime(2022, 10, 1, 7, 43, 36, 812, DateTimeKind.Unspecified).AddTicks(5224), "Ut ab et velit aperiam sed consequatur.", 3, 2 },
                    { 105L, 19L, "Sed iste ipsam veritatis nihil consequuntur perspiciatis voluptas ut.", new DateTime(2022, 6, 22, 0, 36, 32, 603, DateTimeKind.Unspecified).AddTicks(319), "Velit aliquid excepturi ducimus ipsa nihil maxime non.", 4, 1 },
                    { 106L, 61L, "Enim et enim autem sed consectetur.", new DateTime(2023, 7, 25, 1, 41, 53, 725, DateTimeKind.Unspecified).AddTicks(7721), "Quia rem exercitationem ut nam sit nesciunt.", 3, 2 },
                    { 107L, 25L, "dolor", new DateTime(2022, 6, 12, 8, 16, 33, 557, DateTimeKind.Unspecified).AddTicks(2337), "Est voluptas est id debitis.", 3, 2 },
                    { 108L, 34L, "Natus sequi placeat. Est rerum dicta animi dolorem exercitationem. Veniam cumque est sunt harum voluptas expedita explicabo temporibus eveniet.", new DateTime(2023, 5, 19, 11, 58, 50, 706, DateTimeKind.Unspecified).AddTicks(6211), "Temporibus voluptates quia sunt consequuntur omnis eos laudantium est.", 3, 1 },
                    { 109L, 66L, "Veniam facere at quo occaecati vel repellat quos. Ipsa officiis odio est incidunt dolorum aperiam expedita quis aut. Libero quis harum aperiam qui asperiores temporibus id impedit dolores.", new DateTime(2023, 5, 13, 7, 55, 47, 435, DateTimeKind.Unspecified).AddTicks(9383), "Dolores sunt consequatur sunt qui vero soluta.", 3, 2 },
                    { 110L, 57L, "Placeat maxime inventore ea culpa totam omnis.\nEnim expedita nesciunt illo.\nSed qui sunt cupiditate voluptatem voluptatem dolor dolor odio earum.\nQuia aut non tempora ad aspernatur accusantium quia soluta.\nAut quis vitae deserunt non ut nesciunt itaque.\nMinima corrupti nemo ex aut.", new DateTime(2021, 12, 24, 9, 56, 11, 170, DateTimeKind.Unspecified).AddTicks(42), "Sunt aut eum enim vitae.", 4, 2 },
                    { 111L, 52L, "Et non et tenetur autem.\nUt provident corrupti non consequatur.\nFuga nulla ratione distinctio corporis perferendis cupiditate iste et laudantium.\nDelectus temporibus rem reiciendis sunt.\nVel sint excepturi voluptas quo perferendis.\nEst provident recusandae.", new DateTime(2022, 11, 7, 3, 37, 2, 582, DateTimeKind.Unspecified).AddTicks(8827), "Quia voluptas enim aut ut beatae.", 1, 1 },
                    { 112L, 64L, "Praesentium vero nam.", new DateTime(2022, 12, 9, 13, 3, 17, 578, DateTimeKind.Unspecified).AddTicks(4091), "Magnam quam qui et neque qui sapiente veritatis quia.", 1, 1 },
                    { 113L, 23L, "Et perferendis assumenda vitae molestiae qui autem qui ut.\nQuis rerum inventore voluptate nisi at qui laboriosam.\nOmnis iste tempora voluptatibus quis accusantium qui quasi ea facilis.\nTenetur facere et sunt explicabo magni.\nReiciendis maxime natus veniam.", new DateTime(2023, 8, 20, 1, 19, 37, 938, DateTimeKind.Unspecified).AddTicks(3564), "Cum esse ullam.", 2, 3 },
                    { 114L, 66L, "Porro accusantium ad voluptas doloremque in illo id placeat iure. Qui omnis et dicta delectus ipsam. Distinctio voluptatum deserunt iure. Et voluptates doloremque in aut animi. Cumque dolorem iusto asperiores eaque est illum magnam aut. Et qui vel eveniet illum ipsum consectetur dolor recusandae.", new DateTime(2023, 4, 11, 1, 59, 8, 530, DateTimeKind.Unspecified).AddTicks(7540), "Eius aliquam nihil.", 2, 1 },
                    { 115L, 25L, "Recusandae est tempore. Voluptas in enim voluptatem veritatis aut accusamus omnis. In in molestiae id voluptas in.", new DateTime(2022, 1, 10, 1, 17, 3, 403, DateTimeKind.Unspecified).AddTicks(5959), "Commodi sit omnis doloremque recusandae repellat.", 1, 3 },
                    { 116L, 1L, "Non qui laudantium nihil animi dolorum aut aut eum exercitationem. Repudiandae possimus aut id adipisci sequi nihil ut et inventore. Perferendis possimus dolores officiis dicta commodi.", new DateTime(2022, 9, 6, 15, 16, 49, 96, DateTimeKind.Unspecified).AddTicks(2667), "Hic harum nihil modi repellendus voluptatem aut ut.", 3, 3 },
                    { 117L, 44L, "Asperiores dolorem consequatur perferendis. Hic magnam sit consequuntur hic unde ut atque. Qui consequuntur impedit quis qui provident quod eos autem. Aliquam animi inventore id ipsam et.", new DateTime(2022, 2, 1, 19, 32, 53, 698, DateTimeKind.Unspecified).AddTicks(7058), "Optio consequatur quis enim quam.", 3, 2 },
                    { 118L, 10L, "Quo sit et inventore aliquid est dolorem debitis rerum nesciunt.", new DateTime(2023, 6, 1, 7, 42, 23, 644, DateTimeKind.Unspecified).AddTicks(5511), "Expedita facilis quod.", 3, 0 },
                    { 119L, 25L, "Molestiae iure architecto possimus. Atque delectus officiis. Optio natus cupiditate ipsam ipsa deleniti est sit sapiente.", new DateTime(2022, 9, 21, 20, 46, 43, 898, DateTimeKind.Unspecified).AddTicks(4127), "Vero ducimus aut omnis sed necessitatibus est.", 1, 2 },
                    { 120L, 60L, "ipsam", new DateTime(2022, 12, 5, 3, 52, 35, 434, DateTimeKind.Unspecified).AddTicks(2257), "Et quia quia tempore voluptatibus exercitationem doloremque.", 2, 1 },
                    { 121L, 25L, "non", new DateTime(2022, 12, 31, 14, 53, 19, 259, DateTimeKind.Unspecified).AddTicks(4321), "Sed similique cum animi quaerat ut modi rerum sit.", 2, 2 },
                    { 122L, 50L, "Molestias et fugit rem dolorum sunt voluptatem veritatis qui. Possimus nisi veniam quis sapiente debitis. Quod nihil hic. Quas est natus labore quae. Qui sunt nihil eos et nobis corrupti.", new DateTime(2023, 3, 5, 7, 4, 17, 170, DateTimeKind.Unspecified).AddTicks(825), "Pariatur est autem temporibus dolorem unde et vel.", 3, 0 },
                    { 123L, 30L, "ut", new DateTime(2022, 9, 5, 10, 48, 29, 50, DateTimeKind.Unspecified).AddTicks(6624), "Amet quia facilis quis modi.", 1, 0 },
                    { 124L, 19L, "Quos eligendi dolorum qui expedita autem.", new DateTime(2022, 1, 25, 6, 2, 33, 44, DateTimeKind.Unspecified).AddTicks(7964), "Quasi minima fuga blanditiis consequatur quidem omnis incidunt sunt.", 3, 2 },
                    { 125L, 44L, "Autem ut repudiandae autem. Inventore aperiam impedit et libero. Quod eligendi rerum voluptatem mollitia id. Est ullam voluptas hic sit quis rerum voluptas repellat est. Magnam vitae voluptatem et ipsam veritatis deserunt omnis dolorem. Animi omnis hic adipisci maiores maiores eligendi dolorem quod.", new DateTime(2022, 5, 14, 6, 38, 29, 362, DateTimeKind.Unspecified).AddTicks(346), "Sint et soluta numquam eum totam.", 3, 3 },
                    { 126L, 19L, "sunt", new DateTime(2023, 2, 21, 14, 24, 37, 312, DateTimeKind.Unspecified).AddTicks(253), "Expedita esse molestiae rerum ut.", 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "InitialSolution", "LanguageId", "Status" },
                values: new object[,]
                {
                    { 127L, 58L, "aut", new DateTime(2021, 4, 8, 13, 32, 14, 996, DateTimeKind.Unspecified).AddTicks(6393), "Dolorem quia autem qui natus illum omnis.", 3, 3 },
                    { 128L, 27L, "Ut quidem impedit ut tempore ut ut et aperiam vel.\nQui similique ducimus et ut et.\nConsequatur aliquid sed.\nLibero at sequi quia harum aut perferendis.\nNisi sit ut dolorem rem sit at culpa.\nRepudiandae rem eaque.", new DateTime(2021, 9, 6, 17, 2, 56, 508, DateTimeKind.Unspecified).AddTicks(5225), "Rerum itaque aliquam dolore quia rem.", 4, 2 },
                    { 129L, 11L, "Delectus at vitae laudantium animi.\nAtque exercitationem aperiam iure iste ea reiciendis id.\nEius ut blanditiis.\nVitae vel exercitationem incidunt officia eum ratione totam id commodi.\nIllum porro voluptas dolorem numquam repellat et rerum ipsam id.\nCorrupti nisi labore perferendis aut excepturi mollitia.", new DateTime(2022, 10, 14, 19, 9, 54, 712, DateTimeKind.Unspecified).AddTicks(9740), "Corrupti suscipit ad autem laudantium velit.", 1, 2 },
                    { 130L, 65L, "Similique quo beatae consequatur.\nSed quisquam quaerat eos qui cupiditate voluptas.\nDoloribus in at harum officiis in quia enim architecto ab.\nCum perspiciatis autem consequatur consequatur eos rem.\nIste amet tempore quia eveniet cumque architecto ipsa iusto.\nId non ut neque quisquam.", new DateTime(2022, 8, 16, 4, 4, 15, 198, DateTimeKind.Unspecified).AddTicks(3006), "Possimus quos tempore fuga dolores quidem blanditiis ut.", 3, 3 },
                    { 131L, 51L, "reiciendis", new DateTime(2022, 11, 21, 16, 56, 12, 563, DateTimeKind.Unspecified).AddTicks(8597), "Dolorem qui voluptas quos temporibus excepturi.", 3, 1 },
                    { 132L, 13L, "Rem occaecati suscipit.\nQui quod dicta modi ipsa beatae rerum.\nNisi dolor iure iure similique aspernatur corporis quisquam ab.\nVero sint reprehenderit a voluptatem.\nDolorem necessitatibus mollitia harum a fugiat voluptatem.", new DateTime(2020, 12, 24, 7, 52, 42, 6, DateTimeKind.Unspecified).AddTicks(3775), "Porro est voluptas ipsam in a non quibusdam.", 2, 2 },
                    { 133L, 40L, "Incidunt quae a ratione nam illum quia eos.", new DateTime(2022, 3, 18, 16, 56, 19, 954, DateTimeKind.Unspecified).AddTicks(1264), "Et aperiam labore officia architecto rerum quam dolores perferendis similique.", 2, 1 },
                    { 134L, 18L, "Sunt sit dicta ut odio. Sed sit quas aliquam non eveniet. Voluptates debitis officiis id ea dolores. Sunt veritatis quidem dicta odit. Architecto repudiandae reiciendis. Ea voluptate possimus molestiae a earum veritatis qui autem cum.", new DateTime(2022, 2, 24, 15, 7, 35, 680, DateTimeKind.Unspecified).AddTicks(3931), "Consequatur accusamus molestias nesciunt sed non.", 2, 0 },
                    { 135L, 43L, "Minus doloremque vel repellat nesciunt quis quis fuga.", new DateTime(2023, 8, 1, 7, 36, 21, 182, DateTimeKind.Unspecified).AddTicks(7620), "Qui id a harum veniam sint at.", 1, 3 },
                    { 136L, 68L, "voluptatibus", new DateTime(2023, 8, 20, 13, 48, 49, 499, DateTimeKind.Unspecified).AddTicks(9824), "Voluptatum tenetur recusandae vel.", 4, 1 },
                    { 137L, 22L, "Hic odit adipisci non natus veritatis labore.", new DateTime(2023, 3, 18, 0, 40, 5, 143, DateTimeKind.Unspecified).AddTicks(5925), "Laudantium cupiditate praesentium sed veniam optio.", 1, 2 },
                    { 138L, 38L, "Accusamus quidem soluta ea doloremque.", new DateTime(2023, 5, 25, 3, 33, 54, 773, DateTimeKind.Unspecified).AddTicks(5957), "Et quas odio magni consequatur optio.", 4, 2 },
                    { 139L, 27L, "minima", new DateTime(2023, 6, 30, 14, 21, 29, 110, DateTimeKind.Unspecified).AddTicks(5945), "Nisi molestias incidunt reprehenderit ipsum.", 1, 3 },
                    { 140L, 22L, "et", new DateTime(2023, 7, 19, 13, 14, 55, 578, DateTimeKind.Unspecified).AddTicks(3309), "Sint voluptatem quis ut aliquam sapiente dicta sit aut qui.", 3, 1 },
                    { 141L, 40L, "Voluptatibus quia porro nisi necessitatibus quia quam fugit quos.", new DateTime(2022, 12, 8, 12, 40, 41, 294, DateTimeKind.Unspecified).AddTicks(33), "Cum non id sunt ab ea provident modi pariatur suscipit.", 3, 2 },
                    { 142L, 54L, "Consequuntur optio modi commodi necessitatibus totam. Facere ipsam ea et nobis voluptatum magni voluptatem molestias quisquam. Consectetur consequatur cum voluptate quae sapiente illo molestias. Animi aliquam inventore aspernatur deleniti repellendus commodi at fuga dolores. Alias expedita excepturi ea quia tempora earum eos aut perferendis.", new DateTime(2023, 3, 30, 13, 40, 20, 929, DateTimeKind.Unspecified).AddTicks(6959), "Possimus minima dolorem facere.", 2, 1 },
                    { 143L, 52L, "Quaerat corporis voluptatem eveniet fugit ad rerum.", new DateTime(2023, 2, 6, 8, 55, 31, 486, DateTimeKind.Unspecified).AddTicks(2227), "Est vel quisquam est voluptatem enim vel error.", 1, 2 },
                    { 144L, 9L, "Et explicabo vel dolor omnis dolores. Ut libero dolorum explicabo non eos sint et temporibus sapiente. Quod at possimus cumque aliquam consequuntur fugit dolores atque eum.", new DateTime(2022, 8, 27, 6, 36, 31, 738, DateTimeKind.Unspecified).AddTicks(8418), "Ipsam ut qui sit consectetur voluptate.", 1, 3 },
                    { 145L, 39L, "Nam omnis quasi consequuntur.\nVeniam blanditiis voluptatem ut incidunt incidunt.\nVoluptatem magnam est repudiandae voluptas nobis.\nIllo est ratione.", new DateTime(2021, 12, 10, 0, 38, 53, 996, DateTimeKind.Unspecified).AddTicks(400), "Sit facilis quia suscipit.", 4, 2 },
                    { 146L, 9L, "Molestiae animi consectetur voluptatibus.", new DateTime(2023, 2, 17, 6, 11, 46, 440, DateTimeKind.Unspecified).AddTicks(1822), "Voluptas enim quo.", 3, 2 },
                    { 147L, 8L, "Earum exercitationem qui consequatur et expedita molestias. Sint dolor occaecati voluptatum voluptatem enim. Quae consectetur dolor maiores doloribus unde veritatis. Veniam porro repellat ut perferendis atque modi voluptatibus. Explicabo saepe quasi unde perspiciatis ut et officia.", new DateTime(2021, 2, 21, 2, 2, 0, 835, DateTimeKind.Unspecified).AddTicks(8736), "Dolorem molestiae aut.", 4, 2 },
                    { 148L, 69L, "Id incidunt ut.", new DateTime(2023, 1, 31, 0, 44, 0, 886, DateTimeKind.Unspecified).AddTicks(8092), "Est nam natus.", 3, 3 },
                    { 149L, 36L, "Consequuntur velit et quas voluptas reiciendis. Quasi iusto reprehenderit ut ipsum quasi. Tempore officia ea atque facere. Non sint consectetur asperiores explicabo optio voluptatem dolorem nihil. Autem in quaerat. Sed ea commodi dolorum saepe.", new DateTime(2023, 4, 27, 13, 19, 12, 146, DateTimeKind.Unspecified).AddTicks(6974), "Est et quam dolores consequatur exercitationem.", 2, 1 },
                    { 150L, 25L, "Sunt at non.\nQuasi voluptate ratione.\nTempora est voluptas perferendis eos repudiandae aut et enim.\nQuod deserunt et aliquam.\nAutem cumque voluptatibus.\nSed fugiat quam sint laudantium error ex dolorem voluptate.", new DateTime(2022, 1, 12, 15, 51, 50, 129, DateTimeKind.Unspecified).AddTicks(3312), "Aut ad culpa ipsam placeat et.", 2, 1 },
                    { 151L, 23L, "Ut eius perspiciatis quo qui fugiat nemo sunt.\nAccusantium repellat aut magni et qui repellendus.\nQui voluptatum sapiente recusandae provident voluptas vitae ut.\nNeque tempora aut blanditiis.", new DateTime(2023, 8, 20, 14, 57, 51, 55, DateTimeKind.Unspecified).AddTicks(8063), "Quam veniam nulla numquam rem accusamus commodi omnis.", 2, 3 },
                    { 152L, 21L, "Voluptatum porro ut voluptatem dicta laborum.\nAperiam rem placeat quis vel laudantium.\nHarum libero beatae reiciendis dolores nobis tempore qui exercitationem.\nOdit aut nihil aut maiores.\nMinus voluptates quia expedita dolores voluptatum illum quia accusantium nulla.", new DateTime(2022, 9, 9, 16, 11, 17, 227, DateTimeKind.Unspecified).AddTicks(17), "Nisi consequatur voluptas officia quos ipsa sed.", 4, 2 },
                    { 153L, 52L, "Corrupti aperiam facere et. Ipsa repudiandae aut amet in ab. Perferendis praesentium aliquam aut autem nesciunt at. Hic nostrum est eum enim non fugit qui fuga. Nulla neque a molestias nihil dicta et voluptas illo est. Repudiandae expedita eum labore a.", new DateTime(2023, 2, 9, 2, 56, 20, 17, DateTimeKind.Unspecified).AddTicks(5531), "Delectus ut blanditiis a.", 1, 2 },
                    { 154L, 55L, "Nemo consequatur nisi non.", new DateTime(2023, 6, 23, 12, 55, 53, 50, DateTimeKind.Unspecified).AddTicks(17), "Et ut dicta.", 4, 1 },
                    { 155L, 45L, "culpa", new DateTime(2023, 2, 22, 11, 29, 27, 34, DateTimeKind.Unspecified).AddTicks(8951), "Rerum deserunt quas aperiam ipsum ut provident aut.", 1, 1 },
                    { 156L, 17L, "consectetur", new DateTime(2022, 3, 10, 0, 20, 36, 167, DateTimeKind.Unspecified).AddTicks(9672), "Eos eum et vitae aut.", 4, 0 },
                    { 157L, 63L, "Similique optio ut rerum omnis.", new DateTime(2022, 8, 7, 6, 22, 59, 931, DateTimeKind.Unspecified).AddTicks(8998), "Dolores nulla nulla occaecati molestiae et et.", 3, 2 },
                    { 158L, 5L, "Optio quisquam ut consequatur reprehenderit commodi eaque aliquam.", new DateTime(2023, 7, 20, 3, 31, 38, 618, DateTimeKind.Unspecified).AddTicks(827), "Delectus modi asperiores quasi perspiciatis laboriosam ea.", 1, 2 },
                    { 159L, 22L, "Alias nam vel ipsam quas.", new DateTime(2023, 3, 15, 13, 15, 59, 834, DateTimeKind.Unspecified).AddTicks(6034), "Temporibus maiores similique est saepe dignissimos sit ut.", 4, 0 },
                    { 160L, 36L, "Ratione minima excepturi dignissimos expedita dignissimos fuga commodi enim et.", new DateTime(2023, 4, 3, 14, 0, 35, 909, DateTimeKind.Unspecified).AddTicks(9640), "Delectus expedita facilis.", 1, 3 },
                    { 161L, 17L, "Odit est dolores nisi ut et maxime. Illum ut rerum et. Ullam perspiciatis aut dolores enim dignissimos. Et sunt et quaerat quis aperiam maxime similique. Voluptatibus sapiente est error. Quaerat perspiciatis ullam.", new DateTime(2021, 9, 13, 8, 11, 13, 199, DateTimeKind.Unspecified).AddTicks(6759), "Consequatur laboriosam in ex ut qui culpa quae provident deleniti.", 3, 0 },
                    { 162L, 37L, "corrupti", new DateTime(2021, 11, 27, 8, 5, 20, 151, DateTimeKind.Unspecified).AddTicks(4159), "Amet iusto possimus iusto necessitatibus nulla aperiam dolorem aperiam.", 1, 0 },
                    { 163L, 59L, "repellat", new DateTime(2023, 1, 25, 4, 17, 20, 750, DateTimeKind.Unspecified).AddTicks(697), "Inventore ut illo quia recusandae quo earum sint ea suscipit.", 3, 0 },
                    { 164L, 57L, "Ut provident veritatis rerum.\nUt velit cupiditate labore ducimus quam est alias alias.\nVero ut dolores quo architecto iste et.\nCulpa sed quia.\nSed et fugit.\nAutem sed sunt sequi rerum accusamus saepe consectetur soluta rerum.", new DateTime(2022, 3, 1, 12, 24, 48, 18, DateTimeKind.Unspecified).AddTicks(7508), "Enim ut consectetur.", 4, 2 },
                    { 165L, 28L, "Omnis officia aspernatur dolores atque maxime in dolores.\nMinima quia sed ipsa ea.\nNulla rerum maiores blanditiis nemo nesciunt magni maxime repellat corrupti.\nAut eos quo dolorum eum error.\nPorro molestiae et inventore.", new DateTime(2022, 10, 30, 9, 49, 59, 617, DateTimeKind.Unspecified).AddTicks(9436), "Aperiam iure et esse.", 1, 0 },
                    { 166L, 1L, "Aspernatur iure quas est nulla aut.\nEt assumenda iusto.\nTempore ducimus natus voluptas voluptas aut.\nTemporibus quod animi nemo optio laborum.\nNon ipsam rem exercitationem voluptatem perferendis.", new DateTime(2022, 1, 18, 20, 49, 23, 693, DateTimeKind.Unspecified).AddTicks(1535), "Et provident soluta perferendis quia dolorem consequuntur.", 1, 1 },
                    { 167L, 14L, "Est autem pariatur. Facere debitis dolorem temporibus eligendi necessitatibus ipsum quidem. Sed est et nihil aliquam libero ipsa explicabo et.", new DateTime(2023, 5, 5, 19, 21, 55, 336, DateTimeKind.Unspecified).AddTicks(7850), "Non dolor expedita tenetur eos quia vel quia quia.", 1, 3 },
                    { 168L, 42L, "Exercitationem esse consequuntur in cum. Voluptatem laborum voluptatem dolorem. Unde voluptas facere et nemo ipsa accusantium. Cum expedita delectus sint. Omnis et quia in tempore.", new DateTime(2023, 1, 24, 14, 12, 19, 569, DateTimeKind.Unspecified).AddTicks(2775), "Ad molestiae occaecati quos dolores consequuntur adipisci.", 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "InitialSolution", "LanguageId", "Status" },
                values: new object[,]
                {
                    { 169L, 12L, "Culpa qui libero repellat est neque assumenda et consectetur.", new DateTime(2023, 7, 12, 11, 56, 54, 54, DateTimeKind.Unspecified).AddTicks(9470), "Magni voluptas ut laudantium quam.", 1, 2 },
                    { 170L, 32L, "Minima ducimus dolorum accusantium voluptas in id qui aut.\nLabore magnam ad.\nNihil voluptate est atque quam quam nesciunt ducimus tempore.\nNisi est odio laborum voluptate officiis rerum numquam sunt.", new DateTime(2023, 7, 1, 5, 54, 29, 401, DateTimeKind.Unspecified).AddTicks(193), "Voluptas dolores at accusantium consequatur a et itaque.", 1, 2 },
                    { 171L, 8L, "in", new DateTime(2020, 12, 24, 14, 38, 28, 367, DateTimeKind.Unspecified).AddTicks(3243), "Nihil excepturi error omnis itaque error sunt.", 1, 2 },
                    { 172L, 19L, "Asperiores velit aut iusto.\nNeque consequuntur autem.", new DateTime(2021, 2, 9, 15, 51, 49, 207, DateTimeKind.Unspecified).AddTicks(8146), "Explicabo nesciunt eligendi eum est illum.", 4, 0 },
                    { 173L, 58L, "Recusandae blanditiis dolorum.\nVoluptas sint ut autem similique consequatur non consequuntur quasi vitae.", new DateTime(2021, 11, 30, 3, 9, 38, 872, DateTimeKind.Unspecified).AddTicks(1376), "Vero vel excepturi aut porro aspernatur aut ut quas vero.", 2, 0 },
                    { 174L, 18L, "Veniam magnam eveniet incidunt libero possimus ipsa.", new DateTime(2022, 10, 30, 22, 19, 20, 84, DateTimeKind.Unspecified).AddTicks(1549), "In amet corporis enim voluptatem distinctio aut qui delectus ut.", 4, 2 },
                    { 175L, 51L, "Error placeat repellendus recusandae harum ratione.\nVeniam tempora sit vel rem.\nVel facilis officiis.\nAt repellendus quasi beatae.", new DateTime(2023, 4, 13, 10, 29, 35, 676, DateTimeKind.Unspecified).AddTicks(220), "Perferendis culpa voluptatibus facilis perferendis.", 2, 2 },
                    { 176L, 37L, "Enim dolores odit doloribus provident totam sapiente.", new DateTime(2023, 3, 7, 4, 13, 42, 418, DateTimeKind.Unspecified).AddTicks(5887), "Exercitationem id soluta.", 3, 1 },
                    { 177L, 22L, "officiis", new DateTime(2023, 3, 15, 23, 52, 19, 912, DateTimeKind.Unspecified).AddTicks(2286), "Molestiae suscipit inventore non sed recusandae odit voluptatum.", 2, 0 },
                    { 178L, 27L, "Omnis quasi aut ut qui aut voluptate quia aliquam.\nEt ipsam distinctio quibusdam aliquid.\nAut explicabo aut sunt reiciendis voluptate iusto.\nQuibusdam temporibus quas commodi.\nVoluptatibus tempore saepe nesciunt recusandae neque ut dicta.", new DateTime(2022, 4, 13, 15, 31, 29, 223, DateTimeKind.Unspecified).AddTicks(711), "Minima et pariatur.", 1, 3 },
                    { 179L, 57L, "facere", new DateTime(2023, 3, 19, 13, 37, 30, 134, DateTimeKind.Unspecified).AddTicks(7537), "Et est porro doloribus perspiciatis.", 3, 3 },
                    { 180L, 62L, "Est ipsa cupiditate. Officia quisquam nesciunt qui harum. Molestias error quo.", new DateTime(2022, 10, 10, 14, 17, 52, 502, DateTimeKind.Unspecified).AddTicks(1259), "Autem aliquid harum.", 4, 2 },
                    { 181L, 45L, "eos", new DateTime(2023, 2, 5, 22, 40, 56, 837, DateTimeKind.Unspecified).AddTicks(8708), "Dignissimos aut dolore ad laborum asperiores dolorem sint dolores.", 4, 1 },
                    { 182L, 39L, "Animi libero dolor dolore ipsa omnis nesciunt vitae pariatur. Consequatur consequatur temporibus sit et non odit tempore qui. Officia illum qui. Et consequatur assumenda eius. Accusamus aut ducimus aut et tempore rerum illum sint debitis. Delectus inventore delectus eum voluptates.", new DateTime(2021, 5, 15, 3, 51, 30, 533, DateTimeKind.Unspecified).AddTicks(5622), "Numquam expedita maxime harum voluptatem.", 3, 3 },
                    { 183L, 66L, "dolor", new DateTime(2023, 7, 1, 23, 31, 51, 915, DateTimeKind.Unspecified).AddTicks(4527), "Non aliquid velit quibusdam.", 1, 2 },
                    { 184L, 42L, "Ea distinctio atque impedit amet quibusdam. Et non at dolorum. Et consequatur rerum asperiores placeat. Blanditiis aperiam dolor sed saepe. Debitis ipsum velit aliquid accusantium itaque maiores eum. Nemo velit modi id quas nisi iste consectetur minus optio.", new DateTime(2023, 8, 8, 12, 46, 47, 68, DateTimeKind.Unspecified).AddTicks(7671), "Earum sed voluptatibus.", 4, 2 },
                    { 185L, 18L, "Mollitia accusamus eaque. Accusamus temporibus suscipit quos laborum nam aliquam. Asperiores ut nulla dignissimos. Delectus dolores voluptatem eius suscipit incidunt beatae. Nisi quis odit explicabo ipsa blanditiis voluptatibus. Voluptas a voluptatem eligendi odit veritatis aut ad.", new DateTime(2023, 2, 10, 0, 46, 9, 12, DateTimeKind.Unspecified).AddTicks(2211), "Quia hic quis facilis perspiciatis aut numquam sequi voluptas.", 2, 1 },
                    { 186L, 48L, "Similique quibusdam quaerat rerum sapiente voluptatem cupiditate.\nIncidunt in sunt quia enim sunt nam.\nNon facere qui ut voluptas maiores omnis dicta est eum.\nEligendi facilis quasi quia iure et.\nAut provident cumque soluta qui.\nSed corporis quae.", new DateTime(2023, 2, 1, 9, 37, 5, 392, DateTimeKind.Unspecified).AddTicks(8822), "Est rerum eaque assumenda.", 1, 1 },
                    { 187L, 22L, "Et in culpa fugiat.\nNesciunt architecto sit omnis repudiandae totam dolores labore pariatur.", new DateTime(2023, 3, 15, 9, 7, 7, 533, DateTimeKind.Unspecified).AddTicks(3170), "Maiores cumque molestias sit quaerat eveniet exercitationem.", 1, 1 },
                    { 188L, 64L, "Dolores non vel sequi quas cumque dignissimos. Voluptatibus et cumque molestias sunt pariatur praesentium distinctio asperiores hic. Enim facilis suscipit assumenda nisi laborum optio.", new DateTime(2023, 2, 27, 3, 25, 13, 690, DateTimeKind.Unspecified).AddTicks(167), "Cumque ea occaecati sapiente aut impedit rerum error nemo magni.", 1, 2 },
                    { 189L, 53L, "Accusamus aut nam.\nAb quisquam et qui blanditiis autem vero.\nUt enim sit modi temporibus debitis.\nOmnis totam ut aut.\nProvident exercitationem numquam ducimus ut expedita eos.", new DateTime(2020, 4, 8, 7, 45, 23, 268, DateTimeKind.Unspecified).AddTicks(3328), "Quibusdam at hic.", 1, 2 },
                    { 190L, 41L, "Et ut molestiae eligendi. Accusamus sunt veritatis architecto voluptatum tenetur. Voluptas repellat dicta ab possimus quas blanditiis. Et et facilis id ad amet eaque ea aspernatur veniam. Eveniet rerum eum ut ipsam aut animi.", new DateTime(2022, 9, 7, 5, 22, 19, 104, DateTimeKind.Unspecified).AddTicks(9753), "Et eligendi deserunt laborum.", 4, 1 },
                    { 191L, 67L, "Rerum fugiat aut ea id ex magnam dolorum eligendi. Enim eum numquam sapiente temporibus molestiae. Dolorum earum explicabo.", new DateTime(2023, 7, 11, 20, 15, 30, 839, DateTimeKind.Unspecified).AddTicks(5570), "Id quibusdam veritatis.", 4, 0 },
                    { 192L, 35L, "Quos nisi accusantium et eligendi voluptate.", new DateTime(2022, 10, 9, 20, 20, 46, 23, DateTimeKind.Unspecified).AddTicks(6782), "Deserunt quia officia et earum non iure necessitatibus culpa praesentium.", 1, 3 },
                    { 193L, 54L, "Aut voluptatem nam quo facere quia rerum.\nHarum quas laboriosam corrupti natus ad sint dignissimos beatae ut.\nQuaerat consequuntur voluptatum sunt nemo explicabo velit assumenda non fugiat.", new DateTime(2023, 4, 10, 8, 9, 17, 967, DateTimeKind.Unspecified).AddTicks(7724), "Minima vel quod dignissimos vero illo consequatur eligendi.", 3, 3 },
                    { 194L, 47L, "Dolorem itaque laborum non. Impedit aut in provident. Ex dolorum omnis odio ex aut inventore. Similique velit mollitia rerum ipsa blanditiis aspernatur rerum.", new DateTime(2023, 8, 19, 22, 59, 16, 725, DateTimeKind.Unspecified).AddTicks(2165), "Sit officiis maiores voluptatibus et aut animi consequatur atque magni.", 4, 1 },
                    { 195L, 52L, "Aut error quibusdam.\nEt ea aspernatur sed dolore.\nNihil reprehenderit autem repudiandae qui modi eveniet nesciunt.\nVoluptatem quo odio vitae ut eos doloribus pariatur sed.\nVoluptas necessitatibus velit quia molestias iusto doloremque ratione placeat.", new DateTime(2023, 1, 5, 8, 52, 1, 118, DateTimeKind.Unspecified).AddTicks(1263), "Commodi assumenda sit animi deserunt eius.", 4, 3 },
                    { 196L, 36L, "Veritatis illum aliquid aliquid provident atque quaerat nesciunt.", new DateTime(2023, 6, 6, 17, 52, 23, 86, DateTimeKind.Unspecified).AddTicks(5477), "Dolorum sunt ab doloribus vero iusto.", 3, 2 },
                    { 197L, 7L, "ratione", new DateTime(2022, 1, 7, 13, 4, 8, 102, DateTimeKind.Unspecified).AddTicks(4733), "Consequatur aut enim et voluptatum omnis.", 2, 1 },
                    { 198L, 33L, "doloribus", new DateTime(2023, 6, 17, 2, 38, 57, 151, DateTimeKind.Unspecified).AddTicks(3971), "Praesentium delectus dicta.", 1, 0 },
                    { 199L, 66L, "modi", new DateTime(2023, 6, 13, 16, 37, 28, 275, DateTimeKind.Unspecified).AddTicks(543), "Assumenda sequi ut unde rerum officia amet.", 4, 3 },
                    { 200L, 40L, "Quasi quidem occaecati totam labore.\nReiciendis esse quas impedit sunt alias.", new DateTime(2023, 6, 3, 10, 0, 44, 799, DateTimeKind.Unspecified).AddTicks(3869), "Consequuntur vel rerum ullam unde qui est debitis aspernatur.", 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "IsPublic" },
                values: new object[,]
                {
                    { 1L, 14L, "Fuga molestiae laborum architecto minus aut quisquam explicabo corporis.\nVeniam omnis et dolores temporibus voluptatem ea.\nIste odio quis delectus.\nDeleniti qui et consequatur.\nMinus illo quibusdam distinctio cumque nihil voluptate occaecati molestiae fuga.\nEx eos quibusdam ipsa nobis veritatis hic eaque.", new DateTime(2023, 3, 16, 3, 48, 57, 821, DateTimeKind.Unspecified).AddTicks(503), false },
                    { 2L, 68L, "Ducimus velit expedita. Dolores soluta et minus. Commodi magnam dolorem dolorum veritatis autem sunt enim.", new DateTime(2020, 8, 20, 19, 2, 49, 399, DateTimeKind.Unspecified).AddTicks(8714), false },
                    { 3L, 115L, "corporis", new DateTime(2022, 12, 4, 10, 51, 24, 454, DateTimeKind.Unspecified).AddTicks(8958), false },
                    { 4L, 111L, "Eum corporis aliquam repellat neque temporibus.", new DateTime(2023, 1, 31, 6, 22, 33, 679, DateTimeKind.Unspecified).AddTicks(3509), true },
                    { 5L, 8L, "Rerum aut dolorum esse iusto autem vero odio necessitatibus.\nReiciendis voluptatum in nesciunt.\nVoluptates ratione quo id harum quo ut.", new DateTime(2023, 1, 16, 6, 57, 37, 938, DateTimeKind.Unspecified).AddTicks(4990), true },
                    { 6L, 100L, "Eaque et consequatur.", new DateTime(2023, 8, 8, 21, 21, 45, 670, DateTimeKind.Unspecified).AddTicks(8832), true },
                    { 7L, 123L, "In rerum dolores consequuntur cumque reiciendis iste.\nVoluptas omnis animi alias sed facilis odit.\nPerferendis cumque architecto quo nulla consectetur.\nQuasi impedit qui quis vitae maxime quidem ut pariatur quis.\nSuscipit quaerat cumque.", new DateTime(2023, 5, 21, 23, 52, 7, 6, DateTimeKind.Unspecified).AddTicks(5646), false },
                    { 8L, 154L, "Est assumenda vitae.\nQuam cumque ipsa voluptas ut rem architecto eligendi eum.\nEt quam debitis id rem voluptas est labore placeat harum.\nEnim pariatur facere ea.", new DateTime(2023, 6, 25, 11, 22, 15, 653, DateTimeKind.Unspecified).AddTicks(2867), true },
                    { 9L, 198L, "Voluptatem corporis fuga.", new DateTime(2023, 7, 12, 8, 41, 4, 739, DateTimeKind.Unspecified).AddTicks(1601), false },
                    { 10L, 27L, "Vel exercitationem ea hic quia.\nConsectetur illo magni quia est esse ducimus sit.\nNobis aut at nostrum molestiae totam.", new DateTime(2022, 11, 13, 3, 39, 57, 607, DateTimeKind.Unspecified).AddTicks(653), true },
                    { 11L, 75L, "Voluptas autem saepe expedita explicabo eos vel itaque.", new DateTime(2023, 8, 7, 2, 18, 38, 114, DateTimeKind.Unspecified).AddTicks(8488), true },
                    { 12L, 163L, "Sed non quo non dolorem temporibus tempore.", new DateTime(2023, 3, 2, 16, 14, 22, 347, DateTimeKind.Unspecified).AddTicks(5763), true },
                    { 13L, 175L, "Cupiditate velit eum quo dolore magnam veritatis et est.", new DateTime(2023, 5, 4, 15, 9, 40, 293, DateTimeKind.Unspecified).AddTicks(5341), true },
                    { 14L, 130L, "Totam aperiam excepturi.", new DateTime(2023, 7, 12, 20, 44, 42, 850, DateTimeKind.Unspecified).AddTicks(1572), true },
                    { 15L, 163L, "Porro facere et eius.\nFuga vero deleniti dolorum deserunt vel sunt.\nRepellat aut quia dicta minus quo debitis et.", new DateTime(2023, 6, 28, 16, 16, 28, 461, DateTimeKind.Unspecified).AddTicks(5494), true },
                    { 16L, 114L, "Corporis quidem veritatis velit explicabo adipisci labore nam.\nVoluptas aperiam iste.\nTemporibus reprehenderit omnis.", new DateTime(2023, 6, 22, 7, 54, 45, 408, DateTimeKind.Unspecified).AddTicks(8240), true },
                    { 17L, 76L, "Cupiditate accusantium nesciunt aperiam ducimus non.\nVelit sit quas amet maiores iste nulla natus dolor porro.", new DateTime(2022, 10, 9, 3, 49, 32, 172, DateTimeKind.Unspecified).AddTicks(7735), true },
                    { 18L, 11L, "quibusdam", new DateTime(2023, 6, 2, 3, 51, 19, 66, DateTimeKind.Unspecified).AddTicks(2549), true },
                    { 19L, 7L, "pariatur", new DateTime(2023, 8, 6, 6, 1, 37, 464, DateTimeKind.Unspecified).AddTicks(3699), false },
                    { 20L, 121L, "culpa", new DateTime(2023, 1, 26, 6, 46, 36, 740, DateTimeKind.Unspecified).AddTicks(8530), false },
                    { 21L, 13L, "aliquam", new DateTime(2023, 7, 6, 10, 19, 44, 572, DateTimeKind.Unspecified).AddTicks(5241), false },
                    { 22L, 181L, "Non quis eaque incidunt. Eius iure rerum dolorem magnam nihil reprehenderit. Aut voluptatibus ut ea beatae accusamus eius odit. Id eum libero id cupiditate. Expedita et sit similique eos et cupiditate aut est vero. Illum deserunt magni aut sit.", new DateTime(2023, 4, 22, 10, 27, 35, 891, DateTimeKind.Unspecified).AddTicks(280), true },
                    { 23L, 143L, "enim", new DateTime(2023, 3, 23, 14, 56, 56, 284, DateTimeKind.Unspecified).AddTicks(1725), true },
                    { 24L, 199L, "Velit voluptas expedita. Consequatur optio laudantium quis sed et dolores. Architecto qui dolor cumque quas. Illo fuga reiciendis quia ad atque ipsum ex laudantium. Earum et tenetur cum voluptatum et quia eaque.", new DateTime(2023, 7, 18, 10, 22, 54, 752, DateTimeKind.Unspecified).AddTicks(3082), true },
                    { 25L, 169L, "magni", new DateTime(2023, 7, 23, 10, 47, 17, 450, DateTimeKind.Unspecified).AddTicks(9785), true },
                    { 26L, 26L, "Est sunt perferendis aut blanditiis. Ipsa inventore debitis quos quia reprehenderit blanditiis incidunt aut. Exercitationem aut blanditiis dolor blanditiis.", new DateTime(2023, 7, 20, 21, 4, 55, 714, DateTimeKind.Unspecified).AddTicks(9092), true },
                    { 27L, 187L, "minima", new DateTime(2023, 4, 6, 0, 33, 1, 858, DateTimeKind.Unspecified).AddTicks(6064), true },
                    { 28L, 134L, "Non ab at error non ea et quo. Natus ducimus perspiciatis illum eveniet eaque. Voluptas dolores dolor voluptatem enim praesentium pariatur deleniti hic corporis.", new DateTime(2023, 7, 2, 16, 21, 46, 189, DateTimeKind.Unspecified).AddTicks(1564), true },
                    { 29L, 108L, "Deleniti praesentium laudantium.\nAutem labore esse recusandae laborum dolorum.\nEveniet soluta mollitia necessitatibus ipsam.\nQuae dolorem rerum tempore.\nEa totam velit autem et fuga est quia non.\nQuidem quam et ea iusto harum excepturi dicta beatae et.", new DateTime(2023, 5, 30, 11, 24, 23, 794, DateTimeKind.Unspecified).AddTicks(8170), true },
                    { 30L, 101L, "Velit ex itaque eos eum. Ex fuga illo repellat non. Fuga autem et. Est laudantium quaerat voluptatem provident. Aut est provident vitae natus et voluptatem. Aliquid et in voluptatem non suscipit eum quasi.", new DateTime(2020, 7, 25, 16, 53, 48, 450, DateTimeKind.Unspecified).AddTicks(3130), true },
                    { 31L, 200L, "Odio nihil molestias praesentium quis.", new DateTime(2023, 6, 3, 19, 52, 57, 371, DateTimeKind.Unspecified).AddTicks(5710), true },
                    { 32L, 11L, "Qui aut voluptatum sit voluptas corporis est.\nCorporis nisi facilis delectus molestiae ea culpa voluptates et et.\nEt velit sunt modi dignissimos sit voluptatem dolorum ad et.\nNihil cumque unde.\nDignissimos voluptas eos.", new DateTime(2023, 1, 26, 7, 22, 27, 138, DateTimeKind.Unspecified).AddTicks(2446), false },
                    { 33L, 78L, "Sapiente autem praesentium vitae.\nNihil dicta laboriosam.", new DateTime(2023, 8, 11, 6, 17, 29, 459, DateTimeKind.Unspecified).AddTicks(2818), true },
                    { 34L, 128L, "Distinctio aperiam ratione corporis soluta qui quos incidunt.", new DateTime(2022, 7, 3, 16, 55, 15, 548, DateTimeKind.Unspecified).AddTicks(8631), false },
                    { 35L, 145L, "Magnam ab at officiis omnis ad inventore tenetur voluptatem est.", new DateTime(2022, 10, 28, 3, 6, 15, 6, DateTimeKind.Unspecified).AddTicks(5702), false },
                    { 36L, 8L, "Voluptatem consequatur facere optio porro libero eum et.\nOccaecati dolor facilis et voluptas pariatur.\nEligendi amet blanditiis.", new DateTime(2023, 2, 5, 3, 34, 38, 748, DateTimeKind.Unspecified).AddTicks(4124), true },
                    { 37L, 16L, "Est in eum nihil commodi. Rerum ratione et voluptatem. Nam eligendi velit culpa modi hic iusto et aspernatur esse. Recusandae quibusdam nobis. Sit aut nemo dolore aut.", new DateTime(2023, 5, 15, 18, 19, 30, 858, DateTimeKind.Unspecified).AddTicks(733), true },
                    { 38L, 56L, "Deleniti beatae ex exercitationem et ea. Repudiandae autem repellat. Officiis illum ut beatae est quam et quisquam laudantium officia. Aut fugiat est quo magnam sint eos molestiae.", new DateTime(2023, 3, 7, 14, 53, 16, 215, DateTimeKind.Unspecified).AddTicks(7649), true },
                    { 39L, 148L, "Necessitatibus aut repudiandae est molestiae. Enim magnam laboriosam labore corrupti impedit est iure qui omnis. Consequatur vero maxime delectus. Occaecati distinctio voluptatem quos illo rerum est.", new DateTime(2023, 2, 8, 2, 34, 46, 339, DateTimeKind.Unspecified).AddTicks(249), true },
                    { 40L, 160L, "quisquam", new DateTime(2023, 8, 16, 2, 2, 33, 919, DateTimeKind.Unspecified).AddTicks(5644), true },
                    { 41L, 141L, "sed", new DateTime(2023, 7, 17, 20, 44, 3, 441, DateTimeKind.Unspecified).AddTicks(5956), true },
                    { 42L, 101L, "Ut perspiciatis autem rem id est aperiam.", new DateTime(2022, 9, 22, 13, 28, 12, 178, DateTimeKind.Unspecified).AddTicks(2011), false }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "IsPublic" },
                values: new object[,]
                {
                    { 43L, 74L, "Veniam magnam dolores et fugiat.", new DateTime(2022, 11, 14, 6, 47, 34, 548, DateTimeKind.Unspecified).AddTicks(8544), true },
                    { 44L, 21L, "Alias officia quia animi ratione enim sequi voluptatem.\nAperiam maiores enim.\nCumque culpa nisi alias nihil veritatis sed.\nVoluptas iusto sit cumque culpa.", new DateTime(2022, 8, 1, 2, 22, 0, 408, DateTimeKind.Unspecified).AddTicks(6967), false },
                    { 45L, 81L, "Eos ut voluptates temporibus aut in quia rerum tempora voluptas.", new DateTime(2023, 5, 1, 17, 57, 13, 733, DateTimeKind.Unspecified).AddTicks(7712), true },
                    { 46L, 31L, "Rerum minus magnam voluptatem non ut laborum sit veniam cum.", new DateTime(2023, 4, 13, 13, 13, 57, 494, DateTimeKind.Unspecified).AddTicks(7850), false },
                    { 47L, 8L, "Voluptatem est qui quia velit.\nRepudiandae cumque earum debitis illum fugiat aliquid hic.", new DateTime(2022, 7, 22, 9, 36, 20, 946, DateTimeKind.Unspecified).AddTicks(2016), true },
                    { 48L, 16L, "Et aperiam aut doloribus magnam. Fuga fugit est non modi voluptatem inventore. Eos sint amet quia non amet. Omnis vitae et vitae omnis voluptatibus suscipit quidem ab. Qui officiis et tempore tempora ut sequi officiis nulla.", new DateTime(2023, 8, 18, 10, 47, 54, 551, DateTimeKind.Unspecified).AddTicks(940), false },
                    { 49L, 102L, "Et omnis officiis consequatur cupiditate sint vero incidunt.", new DateTime(2020, 8, 20, 18, 44, 34, 74, DateTimeKind.Unspecified).AddTicks(5960), true },
                    { 50L, 27L, "Rem qui quis voluptatum cum nobis beatae dignissimos quaerat aut. Perspiciatis doloremque corporis nobis aut sit in libero repellat culpa. Aut cupiditate fugit.", new DateTime(2023, 7, 19, 2, 6, 12, 939, DateTimeKind.Unspecified).AddTicks(4027), false },
                    { 51L, 81L, "Est enim illum magnam.", new DateTime(2023, 7, 17, 20, 52, 36, 361, DateTimeKind.Unspecified).AddTicks(8036), true },
                    { 52L, 180L, "Minus in inventore sint et.", new DateTime(2023, 7, 18, 13, 37, 34, 386, DateTimeKind.Unspecified).AddTicks(4346), false },
                    { 53L, 9L, "Provident corrupti quis sequi voluptas rem.\nVoluptas commodi unde optio dolorem architecto.\nVelit facilis qui.\nUt nihil quia eligendi veniam itaque quam occaecati atque.", new DateTime(2022, 4, 18, 13, 12, 39, 348, DateTimeKind.Unspecified).AddTicks(7125), true },
                    { 54L, 74L, "et", new DateTime(2023, 2, 1, 17, 5, 44, 47, DateTimeKind.Unspecified).AddTicks(9275), false },
                    { 55L, 133L, "maiores", new DateTime(2023, 7, 18, 7, 36, 53, 197, DateTimeKind.Unspecified).AddTicks(836), false },
                    { 56L, 46L, "Placeat aperiam voluptate maiores molestias accusamus aliquam magnam odit et. Quasi quo quia. Minus aut maiores iusto dolores.", new DateTime(2022, 12, 14, 10, 37, 46, 782, DateTimeKind.Unspecified).AddTicks(8970), true },
                    { 57L, 176L, "Beatae expedita et eos ut. Corporis minus provident ut perferendis sed aut quia. Rerum dolores dolor dolore voluptates.", new DateTime(2023, 6, 22, 11, 29, 9, 257, DateTimeKind.Unspecified).AddTicks(4169), false },
                    { 58L, 54L, "Ut rerum minus dignissimos est est rerum numquam autem mollitia. Dolore nobis voluptatum voluptas. Tempore ducimus quisquam.", new DateTime(2023, 8, 14, 7, 1, 7, 444, DateTimeKind.Unspecified).AddTicks(844), true },
                    { 59L, 154L, "Atque omnis consectetur quam. Voluptatem dolores maxime voluptatem. Esse repellat sunt magni ea. Omnis eum omnis optio necessitatibus explicabo assumenda qui.", new DateTime(2023, 7, 4, 20, 39, 47, 146, DateTimeKind.Unspecified).AddTicks(4100), true },
                    { 60L, 187L, "nulla", new DateTime(2023, 4, 4, 9, 15, 44, 70, DateTimeKind.Unspecified).AddTicks(4394), true },
                    { 61L, 116L, "Quis inventore optio quibusdam et.", new DateTime(2023, 3, 1, 17, 7, 18, 800, DateTimeKind.Unspecified).AddTicks(8974), true },
                    { 62L, 157L, "Aut qui voluptatem voluptatem dolorum.\nDebitis voluptatibus facilis veniam iure.", new DateTime(2023, 4, 11, 4, 0, 58, 852, DateTimeKind.Unspecified).AddTicks(3137), true },
                    { 63L, 31L, "Eveniet sunt non nostrum est illum voluptas nisi tenetur delectus. Sed est eum et officia autem distinctio distinctio accusamus. Tempora soluta non qui maxime doloribus eveniet ad est ratione. Quod quia id sunt ut inventore quas voluptas. Aut libero veniam quia dolor repellat. A adipisci aliquam doloribus quaerat delectus ipsa tempore voluptate repellat.", new DateTime(2023, 1, 2, 13, 25, 11, 234, DateTimeKind.Unspecified).AddTicks(2926), false },
                    { 64L, 32L, "Illum ipsa praesentium non dolor. Et id nesciunt saepe qui voluptates natus in dicta. Maxime explicabo earum beatae qui.", new DateTime(2023, 8, 17, 15, 21, 18, 626, DateTimeKind.Unspecified).AddTicks(3507), true },
                    { 65L, 33L, "non", new DateTime(2023, 5, 21, 2, 1, 50, 933, DateTimeKind.Unspecified).AddTicks(186), false },
                    { 66L, 169L, "Et commodi laudantium vitae voluptatem rem fugit.\nCulpa occaecati fugiat.\nSimilique magni fugit aut voluptates.\nSed minus consequatur asperiores voluptates distinctio qui soluta ducimus.\nOptio facilis eum sint hic eos consequatur adipisci recusandae.\nIpsa ad reiciendis.", new DateTime(2023, 8, 17, 17, 37, 21, 953, DateTimeKind.Unspecified).AddTicks(7851), true },
                    { 67L, 31L, "Quia hic illum.", new DateTime(2020, 6, 6, 18, 19, 14, 179, DateTimeKind.Unspecified).AddTicks(5611), true },
                    { 68L, 95L, "Voluptates blanditiis aut dolores quidem voluptatem ut.\nRecusandae eligendi ipsam velit impedit quia.\nBeatae et placeat voluptas facere nesciunt dolores aperiam suscipit dolores.", new DateTime(2023, 6, 29, 19, 55, 7, 171, DateTimeKind.Unspecified).AddTicks(4382), true },
                    { 69L, 105L, "Asperiores quod suscipit explicabo id consequuntur molestias ea.\nQuo dignissimos error sit aut.\nEt dolorem ut architecto nesciunt consequatur soluta blanditiis.\nEsse nihil totam alias dolorem.", new DateTime(2023, 6, 21, 19, 25, 52, 358, DateTimeKind.Unspecified).AddTicks(1285), true },
                    { 70L, 144L, "Voluptatem tempore quis doloremque dolor hic qui ut deserunt ipsa.", new DateTime(2023, 6, 29, 14, 28, 22, 919, DateTimeKind.Unspecified).AddTicks(6868), false },
                    { 71L, 136L, "Aut cum magni rem nihil nisi ipsam veniam ut.", new DateTime(2023, 8, 22, 2, 43, 13, 599, DateTimeKind.Unspecified).AddTicks(2807), true },
                    { 72L, 77L, "Voluptatum officia non sed est consequatur magni autem.\nConsequuntur omnis voluptatem dicta esse est atque in.\nSit consectetur pariatur aut.", new DateTime(2023, 8, 19, 21, 50, 46, 36, DateTimeKind.Unspecified).AddTicks(4299), false },
                    { 73L, 81L, "iure", new DateTime(2023, 7, 31, 0, 22, 21, 598, DateTimeKind.Unspecified).AddTicks(915), true },
                    { 74L, 83L, "Aut et error consequuntur est est quidem vel nulla aut.", new DateTime(2023, 7, 18, 20, 50, 43, 734, DateTimeKind.Unspecified).AddTicks(1474), true },
                    { 75L, 104L, "Accusamus voluptatem adipisci quod.", new DateTime(2022, 10, 15, 22, 46, 29, 729, DateTimeKind.Unspecified).AddTicks(1847), true },
                    { 76L, 185L, "Minima natus nobis et. Dignissimos vero fugiat officiis voluptates modi pariatur cupiditate. Molestiae molestias consequatur ut delectus eligendi eaque ut voluptatem. Occaecati vitae nesciunt quia est natus et maiores consectetur.", new DateTime(2023, 2, 26, 16, 34, 32, 236, DateTimeKind.Unspecified).AddTicks(6427), true },
                    { 77L, 63L, "Odio iste excepturi. Voluptate consequatur sit quibusdam iusto vel aut sapiente optio. Soluta dolorem perferendis et et explicabo facilis quis minus veritatis.", new DateTime(2021, 12, 10, 2, 1, 21, 932, DateTimeKind.Unspecified).AddTicks(2038), false },
                    { 78L, 159L, "Voluptas omnis dolorem incidunt non.\nNon voluptatum voluptates est.\nQuis est enim omnis animi consequatur beatae.\nFacere molestiae nulla ab aut rem sequi.\nDucimus voluptatum error est ea velit fugit aut praesentium.", new DateTime(2023, 5, 16, 0, 23, 24, 725, DateTimeKind.Unspecified).AddTicks(7453), true },
                    { 79L, 103L, "Sit magni deserunt ea error quam ullam.\nVoluptatum nesciunt voluptatem nulla necessitatibus repellat quas veritatis.\nAutem ipsam beatae alias ut alias ratione dicta est.\nCorporis aut et eligendi delectus.\nSaepe excepturi et.", new DateTime(2023, 7, 30, 19, 7, 35, 410, DateTimeKind.Unspecified).AddTicks(1888), true },
                    { 80L, 71L, "Possimus dicta et quia.", new DateTime(2023, 8, 22, 19, 43, 52, 241, DateTimeKind.Unspecified).AddTicks(7233), true },
                    { 81L, 103L, "Aut tempora natus provident maiores magni ducimus enim. Vitae repellat voluptates sunt laudantium amet minus repellat atque qui. Facilis repellendus repudiandae non dolore quaerat iure. Id vel commodi ut architecto velit nobis id omnis ea. Temporibus et voluptas harum voluptatem voluptatem nulla.", new DateTime(2023, 6, 28, 15, 20, 52, 960, DateTimeKind.Unspecified).AddTicks(6464), true },
                    { 82L, 159L, "Quis dolor veritatis modi ipsam harum.\nEst quod molestias provident in.\nEst quo autem dolor ducimus dolor rerum sapiente.", new DateTime(2023, 7, 22, 6, 45, 6, 428, DateTimeKind.Unspecified).AddTicks(9841), true },
                    { 83L, 157L, "mollitia", new DateTime(2023, 5, 18, 18, 25, 6, 118, DateTimeKind.Unspecified).AddTicks(7413), true },
                    { 84L, 24L, "sint", new DateTime(2023, 8, 19, 5, 42, 23, 47, DateTimeKind.Unspecified).AddTicks(431), true }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "IsPublic" },
                values: new object[,]
                {
                    { 85L, 69L, "Praesentium quam et quasi. Quae iste nemo inventore mollitia quas aut eos quis. Odio deserunt non culpa eligendi quaerat architecto. Pariatur necessitatibus reiciendis molestias deserunt esse molestiae pariatur. Earum labore voluptatem accusantium quaerat similique nesciunt maxime. Quos explicabo repellat ad iure est et ut soluta iste.", new DateTime(2022, 11, 11, 11, 7, 18, 284, DateTimeKind.Unspecified).AddTicks(9932), true },
                    { 86L, 68L, "Quasi sit qui ut delectus saepe et maxime. Et eveniet illo perspiciatis dolor voluptatem quis fugiat omnis. Voluptatibus quisquam sunt et consequatur facilis et id officiis. Ad quod ea recusandae voluptas consectetur iure.", new DateTime(2023, 6, 19, 21, 56, 30, 412, DateTimeKind.Unspecified).AddTicks(6115), true },
                    { 87L, 44L, "Dignissimos quia quo consequatur et.\nProvident aut error dignissimos fugit ea voluptatibus.\nSoluta blanditiis eveniet quisquam nesciunt possimus.\nNatus voluptas sed sed.", new DateTime(2023, 4, 4, 10, 50, 2, 763, DateTimeKind.Unspecified).AddTicks(6256), false },
                    { 88L, 159L, "harum", new DateTime(2023, 6, 6, 13, 2, 2, 114, DateTimeKind.Unspecified).AddTicks(5658), true },
                    { 89L, 47L, "Dolor expedita fugiat odio.", new DateTime(2023, 5, 23, 2, 6, 48, 52, DateTimeKind.Unspecified).AddTicks(474), true },
                    { 90L, 74L, "Provident nisi eligendi nihil.\nNemo et odio impedit perferendis rerum asperiores quia eligendi qui.\nEveniet itaque non est hic rerum excepturi.", new DateTime(2023, 4, 2, 20, 9, 48, 737, DateTimeKind.Unspecified).AddTicks(3330), true },
                    { 91L, 185L, "minima", new DateTime(2023, 6, 26, 6, 49, 6, 895, DateTimeKind.Unspecified).AddTicks(5667), true },
                    { 92L, 89L, "Officia officiis exercitationem non voluptatem. Unde est consequatur qui et. Deleniti eos vero est.", new DateTime(2023, 7, 23, 10, 43, 7, 622, DateTimeKind.Unspecified).AddTicks(2852), true },
                    { 93L, 46L, "Eum voluptas sed vitae et delectus sint nostrum.\nEaque sapiente aut odit quo.\nDelectus temporibus id aspernatur.", new DateTime(2022, 10, 6, 9, 53, 43, 904, DateTimeKind.Unspecified).AddTicks(8284), true },
                    { 94L, 64L, "voluptatem", new DateTime(2022, 11, 12, 21, 11, 8, 342, DateTimeKind.Unspecified).AddTicks(6605), false },
                    { 95L, 22L, "aut", new DateTime(2022, 11, 16, 9, 15, 23, 847, DateTimeKind.Unspecified).AddTicks(6783), true },
                    { 96L, 135L, "Ut est quasi. Qui quia occaecati. Quia eius animi aperiam. Excepturi voluptatum consequatur quia. Et similique assumenda sed aut omnis voluptatem. Ipsam ipsam quia delectus culpa rerum neque.", new DateTime(2023, 8, 6, 12, 58, 43, 725, DateTimeKind.Unspecified).AddTicks(1941), true },
                    { 97L, 54L, "Voluptatem iste et sint aut quisquam necessitatibus.\nEst et ullam eveniet fugiat.\nAutem enim assumenda voluptas nemo voluptas quae necessitatibus sed recusandae.\nQuidem porro officiis rem.", new DateTime(2023, 8, 12, 6, 57, 29, 216, DateTimeKind.Unspecified).AddTicks(5857), true },
                    { 98L, 158L, "Aut pariatur quis.\nIpsa molestiae aliquam et vel et quasi maxime tenetur.", new DateTime(2023, 8, 5, 4, 55, 39, 275, DateTimeKind.Unspecified).AddTicks(1919), true },
                    { 99L, 93L, "Possimus totam magni aliquid maiores cum.", new DateTime(2019, 12, 29, 6, 26, 16, 109, DateTimeKind.Unspecified).AddTicks(9244), true },
                    { 100L, 8L, "Non dolore quibusdam aut commodi. Deleniti veritatis voluptatem laboriosam temporibus voluptatem. Doloremque dolorem necessitatibus omnis dicta quasi. Fugiat tempore saepe similique sint distinctio et est voluptatem.", new DateTime(2023, 1, 7, 20, 57, 49, 398, DateTimeKind.Unspecified).AddTicks(5904), true },
                    { 101L, 139L, "perspiciatis", new DateTime(2023, 8, 20, 4, 41, 25, 630, DateTimeKind.Unspecified).AddTicks(6711), false },
                    { 102L, 196L, "nihil", new DateTime(2023, 7, 2, 18, 18, 16, 690, DateTimeKind.Unspecified).AddTicks(8528), false },
                    { 103L, 136L, "quam", new DateTime(2023, 8, 22, 19, 31, 33, 838, DateTimeKind.Unspecified).AddTicks(7686), false },
                    { 104L, 32L, "Et non quod et iusto sed aliquid. Delectus nihil iste accusamus. Tempora molestiae nisi inventore pariatur suscipit nisi earum. Nam explicabo quibusdam dolores cupiditate voluptatum saepe ab. Voluptates aspernatur maxime autem atque nihil in odit.", new DateTime(2023, 8, 16, 6, 27, 29, 604, DateTimeKind.Unspecified).AddTicks(1690), true },
                    { 105L, 85L, "quisquam", new DateTime(2022, 8, 27, 15, 31, 50, 354, DateTimeKind.Unspecified).AddTicks(8592), true },
                    { 106L, 48L, "Consequatur fugit dolorum dolorem et. Voluptatem est fugiat earum perferendis debitis suscipit. Consequatur est est repellat et odio rerum atque quod dolor. Modi officia earum tempore tempore ut id voluptatibus natus.", new DateTime(2022, 1, 7, 13, 29, 15, 43, DateTimeKind.Unspecified).AddTicks(4346), true },
                    { 107L, 82L, "Modi inventore quod dolorem. Mollitia eum amet porro. Aliquid mollitia quos illo eligendi voluptas autem odio ullam.", new DateTime(2023, 2, 3, 21, 54, 18, 815, DateTimeKind.Unspecified).AddTicks(3542), false },
                    { 108L, 62L, "Velit eveniet omnis. Quam ea voluptas aut consectetur eius culpa quod. Eaque enim quo ea tempora eveniet voluptatem.", new DateTime(2023, 7, 3, 2, 52, 21, 727, DateTimeKind.Unspecified).AddTicks(5958), true },
                    { 109L, 162L, "Pariatur harum impedit ad. Vitae culpa magni minus cumque est quas ullam velit excepturi. Ullam fugiat fugit officia et ea accusantium sunt. Explicabo beatae quo qui ullam ut voluptates. Quia excepturi quia quia repudiandae voluptatem et nesciunt odio. Sunt tempora eveniet non atque.", new DateTime(2023, 4, 26, 8, 28, 37, 176, DateTimeKind.Unspecified).AddTicks(8146), true },
                    { 110L, 65L, "facere", new DateTime(2021, 5, 11, 22, 36, 56, 578, DateTimeKind.Unspecified).AddTicks(6634), true },
                    { 111L, 77L, "Consequatur alias quod ea iusto qui optio minus.\nUt corporis ut.", new DateTime(2023, 8, 19, 16, 35, 8, 960, DateTimeKind.Unspecified).AddTicks(5010), true },
                    { 112L, 119L, "Aspernatur qui nisi nam neque.", new DateTime(2022, 11, 5, 19, 13, 47, 295, DateTimeKind.Unspecified).AddTicks(4895), true },
                    { 113L, 8L, "Nesciunt ducimus quibusdam veritatis animi eaque sed excepturi dolores esse.", new DateTime(2023, 6, 19, 15, 50, 27, 336, DateTimeKind.Unspecified).AddTicks(9157), false },
                    { 114L, 143L, "Qui quas illo molestiae in eos saepe quae ut.\nAutem quae facilis velit.", new DateTime(2023, 8, 13, 1, 26, 15, 452, DateTimeKind.Unspecified).AddTicks(995), true },
                    { 115L, 49L, "Exercitationem quo nihil et sit. Sed aut quia. Est vel et voluptas. Non beatae inventore. Sit omnis placeat porro ducimus.", new DateTime(2023, 8, 21, 12, 52, 21, 966, DateTimeKind.Unspecified).AddTicks(3648), true },
                    { 116L, 155L, "nihil", new DateTime(2023, 8, 21, 4, 12, 49, 773, DateTimeKind.Unspecified).AddTicks(196), false },
                    { 117L, 199L, "Maxime et omnis dolore sunt voluptatem rerum. Fugit ut voluptatibus unde ipsam ea amet consectetur. Omnis cupiditate id unde sed aliquam quaerat doloremque eos aperiam. Omnis ipsam dolorum qui fuga. Voluptatem qui cupiditate vel qui repellat libero voluptatem id. Quaerat est omnis soluta occaecati culpa accusantium odio totam qui.", new DateTime(2023, 7, 21, 21, 15, 32, 381, DateTimeKind.Unspecified).AddTicks(9613), true },
                    { 118L, 160L, "Iusto doloribus in quia.", new DateTime(2023, 4, 26, 2, 23, 30, 361, DateTimeKind.Unspecified).AddTicks(4745), false },
                    { 119L, 197L, "Praesentium nam vitae qui. Quasi non sint aliquid repellat nihil qui. Temporibus ut nostrum sit ex. Quibusdam rerum sit incidunt mollitia exercitationem. Sunt pariatur aut.", new DateTime(2023, 2, 17, 4, 27, 53, 754, DateTimeKind.Unspecified).AddTicks(4350), true },
                    { 120L, 13L, "ut", new DateTime(2023, 8, 18, 23, 33, 30, 963, DateTimeKind.Unspecified).AddTicks(8841), false },
                    { 121L, 59L, "Laudantium odit adipisci.\nAutem pariatur quidem temporibus sed.\nQuod aut odio minus et ad iusto.\nNon occaecati reiciendis cum quo commodi.\nId error consequatur est illo ut error esse velit sit.\nDoloribus recusandae et dignissimos quis corporis est.", new DateTime(2022, 5, 21, 20, 53, 34, 560, DateTimeKind.Unspecified).AddTicks(3136), true },
                    { 122L, 9L, "quis", new DateTime(2022, 10, 31, 2, 31, 10, 904, DateTimeKind.Unspecified).AddTicks(3195), false },
                    { 123L, 80L, "Nihil explicabo temporibus.", new DateTime(2022, 10, 6, 23, 43, 37, 509, DateTimeKind.Unspecified).AddTicks(9776), false },
                    { 124L, 166L, "veniam", new DateTime(2022, 4, 14, 9, 59, 42, 962, DateTimeKind.Unspecified).AddTicks(4684), true },
                    { 125L, 79L, "quia", new DateTime(2023, 4, 16, 14, 38, 26, 828, DateTimeKind.Unspecified).AddTicks(8878), true },
                    { 126L, 15L, "Nobis vitae ratione cum doloremque esse quia. Quos minima assumenda earum in necessitatibus voluptatum. Voluptatem ut dolores nesciunt provident maxime neque perspiciatis et et. Et et eius aut.", new DateTime(2023, 8, 16, 19, 49, 29, 558, DateTimeKind.Unspecified).AddTicks(5165), true }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "IsPublic" },
                values: new object[,]
                {
                    { 127L, 106L, "Quam omnis reiciendis nihil et. Consequatur inventore quia sunt enim cumque in. Eos fugiat consequuntur aut earum et animi iusto.", new DateTime(2023, 7, 26, 16, 28, 40, 344, DateTimeKind.Unspecified).AddTicks(8294), true },
                    { 128L, 1L, "Eligendi odio animi sed totam porro.\nDolor sequi qui qui dolor sequi corrupti sed non vero.\nMolestias molestias sit labore autem.", new DateTime(2023, 1, 13, 7, 17, 45, 35, DateTimeKind.Unspecified).AddTicks(8878), false },
                    { 129L, 192L, "Eligendi est aut exercitationem.\nCommodi soluta ut sequi ut nobis consequatur.\nCum tempore et.\nVoluptas fugit ipsam animi molestiae eligendi sit omnis vel.\nVeritatis animi nostrum vel ipsa sint.\nLaudantium et dolorum rerum perspiciatis quia iusto.", new DateTime(2022, 11, 20, 6, 44, 13, 588, DateTimeKind.Unspecified).AddTicks(1782), false },
                    { 130L, 40L, "Natus cumque possimus et quia natus libero harum voluptatem a. Provident incidunt voluptates dolorum quis eos at facilis saepe provident. Accusamus fuga aut modi. Debitis rerum quisquam natus ea veritatis odio saepe commodi voluptas. Inventore deleniti dolore repudiandae.", new DateTime(2023, 2, 14, 7, 17, 9, 7, DateTimeKind.Unspecified).AddTicks(5812), false },
                    { 131L, 37L, "Numquam illum officia voluptas ad.", new DateTime(2022, 10, 15, 6, 13, 1, 877, DateTimeKind.Unspecified).AddTicks(1482), false },
                    { 132L, 94L, "Dolores amet aspernatur similique autem asperiores ut in similique.", new DateTime(2023, 1, 20, 16, 22, 29, 128, DateTimeKind.Unspecified).AddTicks(9951), false },
                    { 133L, 187L, "Quidem quibusdam neque est dolorum sit accusantium.", new DateTime(2023, 8, 8, 11, 20, 2, 337, DateTimeKind.Unspecified).AddTicks(7288), true },
                    { 134L, 13L, "Aut veniam dolor. Eaque unde non impedit eaque. Repudiandae blanditiis sint expedita dignissimos quia aut occaecati velit natus.", new DateTime(2023, 7, 18, 6, 4, 29, 971, DateTimeKind.Unspecified).AddTicks(1417), true },
                    { 135L, 157L, "nesciunt", new DateTime(2023, 6, 9, 9, 34, 46, 664, DateTimeKind.Unspecified).AddTicks(4040), true },
                    { 136L, 38L, "expedita", new DateTime(2023, 2, 15, 16, 58, 10, 218, DateTimeKind.Unspecified).AddTicks(9869), false },
                    { 137L, 167L, "Reprehenderit numquam facere. Qui illum mollitia quo magnam consectetur. Ea qui consequatur facilis iure culpa et doloribus. Aut nesciunt aspernatur aliquam eius est excepturi eum. Quia est aut asperiores voluptas qui libero assumenda minus.", new DateTime(2023, 7, 11, 1, 52, 51, 265, DateTimeKind.Unspecified).AddTicks(939), true },
                    { 138L, 25L, "Vitae ut eius reprehenderit perferendis et quia ut a maiores.\nUt fugit dolores dolore alias.\nNumquam quasi magni totam est.\nAliquam beatae aut dolorum pariatur.\nQuod et neque reprehenderit magni quia magnam quas.", new DateTime(2023, 8, 22, 15, 47, 22, 415, DateTimeKind.Unspecified).AddTicks(7183), true },
                    { 139L, 198L, "Aut sit dolores. Ad atque fugiat itaque reprehenderit sunt quidem. Ex est delectus enim eaque dolor. Similique numquam sint voluptatem voluptas.", new DateTime(2023, 8, 22, 14, 53, 10, 4, DateTimeKind.Unspecified).AddTicks(2598), true },
                    { 140L, 142L, "Nulla aspernatur numquam reiciendis.", new DateTime(2023, 5, 3, 20, 25, 4, 285, DateTimeKind.Unspecified).AddTicks(5325), true },
                    { 141L, 124L, "Commodi eum aut cum officia.\nHarum qui facilis ut consequatur sit temporibus iste et.\nSunt accusamus expedita similique tenetur corrupti suscipit facere unde.\nQuam occaecati est magnam qui est.", new DateTime(2023, 8, 19, 0, 47, 41, 629, DateTimeKind.Unspecified).AddTicks(3634), false },
                    { 142L, 79L, "Natus vitae ex dolores.\nA autem sint enim distinctio.\nUt voluptatem consequatur.\nPariatur reprehenderit debitis quos ab consequuntur fugit suscipit aut quia.", new DateTime(2023, 2, 6, 13, 37, 25, 192, DateTimeKind.Unspecified).AddTicks(8795), false },
                    { 143L, 87L, "Sit qui nulla nemo sunt numquam blanditiis.\nVel vel aperiam neque.\nPraesentium maxime doloribus commodi et assumenda dignissimos sed dolore.\nSed ducimus placeat et quia.\nVoluptatem nostrum et ex aspernatur debitis molestias quam inventore aliquid.\nRecusandae id fugit tempore explicabo tenetur in et.", new DateTime(2023, 7, 1, 13, 36, 27, 596, DateTimeKind.Unspecified).AddTicks(5585), true },
                    { 144L, 46L, "Excepturi dignissimos recusandae aperiam qui eos dolorem aut dolores quia.", new DateTime(2022, 12, 3, 4, 37, 55, 958, DateTimeKind.Unspecified).AddTicks(7272), true },
                    { 145L, 28L, "Ut similique nemo ducimus magni excepturi vel. Est voluptatem dolores quia. Saepe natus nihil consequatur eos nulla et. Voluptatum eligendi adipisci non nam quibusdam error rerum qui et. Voluptates quasi adipisci fugiat.", new DateTime(2023, 7, 22, 5, 22, 49, 59, DateTimeKind.Unspecified).AddTicks(6423), false },
                    { 146L, 161L, "et", new DateTime(2023, 1, 26, 0, 43, 57, 442, DateTimeKind.Unspecified).AddTicks(2205), true },
                    { 147L, 128L, "Vel et et cupiditate vitae quis sapiente aut.", new DateTime(2023, 5, 27, 20, 58, 46, 231, DateTimeKind.Unspecified).AddTicks(5212), false },
                    { 148L, 94L, "sint", new DateTime(2023, 7, 14, 0, 56, 16, 698, DateTimeKind.Unspecified).AddTicks(4001), false },
                    { 149L, 32L, "odit", new DateTime(2023, 8, 5, 8, 57, 25, 224, DateTimeKind.Unspecified).AddTicks(1244), true },
                    { 150L, 24L, "Similique ipsum ab nulla officia eos magni maiores.\nDebitis veniam iste rerum commodi et quos amet ut.\nIusto tenetur accusantium sint nisi quis.\nIste ut unde sit.\nEos unde necessitatibus tenetur voluptates voluptatem.", new DateTime(2023, 8, 8, 15, 12, 10, 251, DateTimeKind.Unspecified).AddTicks(8423), true },
                    { 151L, 24L, "Ipsa amet sequi accusamus rerum.\nNam neque ea explicabo quaerat est ut.\nImpedit iste laboriosam culpa saepe.\nConsequatur corrupti nihil aut inventore voluptate.\nQuia quasi deleniti non consequatur veritatis maxime.\nNesciunt dolores vel tempore harum aut vero accusantium assumenda quis.", new DateTime(2023, 8, 13, 3, 45, 33, 423, DateTimeKind.Unspecified).AddTicks(549), true },
                    { 152L, 112L, "Et minus qui.\nOmnis omnis ratione vel voluptatum sit.\nSunt aut dolorem ducimus impedit quibusdam.\nUnde nihil sapiente et voluptatem.", new DateTime(2023, 4, 6, 22, 3, 0, 997, DateTimeKind.Unspecified).AddTicks(7316), false },
                    { 153L, 32L, "Asperiores non natus molestias qui consequatur beatae est enim voluptas.\nMaiores error adipisci laborum iure voluptas.\nId voluptas voluptate et.\nVeritatis eos quia perferendis totam.\nOccaecati sunt odit molestiae officiis atque dicta recusandae qui corrupti.", new DateTime(2023, 8, 1, 13, 18, 22, 12, DateTimeKind.Unspecified).AddTicks(5715), true },
                    { 154L, 107L, "Iusto qui quo est.\nAmet ipsam illo debitis.", new DateTime(2023, 3, 20, 22, 16, 1, 658, DateTimeKind.Unspecified).AddTicks(9503), true },
                    { 155L, 48L, "Enim asperiores est porro facere.", new DateTime(2022, 8, 21, 15, 29, 44, 133, DateTimeKind.Unspecified).AddTicks(2681), true },
                    { 156L, 122L, "Blanditiis sit distinctio dignissimos rem corporis explicabo.\nVoluptates nihil est corporis.\nEst suscipit est ab unde laboriosam aut odio iusto.\nNumquam neque omnis iure.\nConsequatur eos officiis impedit repellat quia quo alias expedita.", new DateTime(2023, 4, 13, 5, 54, 39, 92, DateTimeKind.Unspecified).AddTicks(6837), true },
                    { 157L, 83L, "Qui nam unde eligendi temporibus doloribus.", new DateTime(2023, 6, 4, 21, 17, 7, 211, DateTimeKind.Unspecified).AddTicks(1451), true },
                    { 158L, 122L, "ut", new DateTime(2023, 3, 8, 18, 8, 56, 925, DateTimeKind.Unspecified).AddTicks(6541), true },
                    { 159L, 66L, "Impedit sint quia et ab. Sit corporis optio aut suscipit fugit dignissimos eos fugit. Aperiam pariatur omnis libero rem aut qui ex nisi. Eos ea iure aperiam eligendi aperiam non.", new DateTime(2023, 5, 24, 0, 47, 23, 170, DateTimeKind.Unspecified).AddTicks(600), false },
                    { 160L, 158L, "Fugiat non iure explicabo voluptatibus vitae ut. Debitis ut temporibus illo ipsum esse omnis consequatur id. Delectus dicta molestiae ut distinctio repudiandae distinctio. Ullam ut fugit iusto et. Inventore ipsam porro eos vitae debitis esse ad asperiores. Maiores quia animi voluptatibus cupiditate dolorum iusto occaecati delectus.", new DateTime(2023, 8, 19, 4, 17, 14, 392, DateTimeKind.Unspecified).AddTicks(9704), false },
                    { 161L, 174L, "et", new DateTime(2023, 3, 7, 13, 23, 59, 446, DateTimeKind.Unspecified).AddTicks(930), true },
                    { 162L, 133L, "Nobis odio et recusandae asperiores vero.\nQuidem est vero odit est explicabo id voluptatibus.\nIpsam soluta autem cum totam mollitia rem.\nVero dolorem sed.\nEnim est ducimus facere quos unde qui perspiciatis est.", new DateTime(2023, 3, 2, 4, 26, 40, 560, DateTimeKind.Unspecified).AddTicks(1729), false },
                    { 163L, 55L, "Aut cum enim quibusdam molestias aut sit nesciunt facere. Odit reiciendis dicta ut esse beatae dolorem et pariatur. Fugit voluptate ex adipisci perspiciatis. Odio nulla et eligendi consequuntur possimus. Et commodi laboriosam perspiciatis quis optio delectus earum. Optio rerum iure similique illo sunt.", new DateTime(2023, 6, 28, 5, 47, 25, 754, DateTimeKind.Unspecified).AddTicks(7421), true },
                    { 164L, 88L, "quasi", new DateTime(2022, 11, 19, 20, 43, 19, 27, DateTimeKind.Unspecified).AddTicks(95), true },
                    { 165L, 97L, "Magnam quae dignissimos.", new DateTime(2022, 7, 15, 22, 58, 24, 589, DateTimeKind.Unspecified).AddTicks(6398), true },
                    { 166L, 46L, "Quis est beatae provident blanditiis.\nAut quam distinctio quo rem consequatur aut voluptate et sunt.\nProvident aut nobis.", new DateTime(2023, 4, 29, 14, 29, 37, 358, DateTimeKind.Unspecified).AddTicks(7980), true },
                    { 167L, 24L, "et", new DateTime(2023, 8, 9, 6, 11, 25, 96, DateTimeKind.Unspecified).AddTicks(9724), true },
                    { 168L, 38L, "Quidem qui eaque aliquam voluptas delectus velit illo impedit inventore.", new DateTime(2021, 10, 1, 22, 23, 27, 593, DateTimeKind.Unspecified).AddTicks(712), true }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "IsPublic" },
                values: new object[,]
                {
                    { 169L, 169L, "Ad quidem in repudiandae dignissimos. Et nam dicta dolorem rerum veritatis aut. Nemo ea sapiente porro architecto. Assumenda quisquam facilis eveniet quis. Qui illo dolores. Odit cum dolorem quia.", new DateTime(2023, 8, 20, 15, 10, 37, 511, DateTimeKind.Unspecified).AddTicks(9605), true },
                    { 170L, 180L, "Excepturi quis ipsum.\nSit eos tenetur quis placeat eum illo.\nRepudiandae occaecati sed iste asperiores.\nUt et nihil in ipsum officiis veritatis enim.", new DateTime(2023, 3, 15, 2, 49, 8, 998, DateTimeKind.Unspecified).AddTicks(6001), false },
                    { 171L, 9L, "Quam numquam delectus illum in unde.", new DateTime(2022, 6, 15, 8, 1, 48, 311, DateTimeKind.Unspecified).AddTicks(7001), false },
                    { 172L, 62L, "qui", new DateTime(2022, 1, 14, 19, 42, 58, 363, DateTimeKind.Unspecified).AddTicks(5798), true },
                    { 173L, 144L, "Qui quis sit ut consequatur quasi voluptate itaque. Ullam ut placeat et. Aut blanditiis esse harum dicta hic nihil eos aut tenetur. Corporis autem aliquam enim quas quo aliquam molestias magnam. Quia minima ratione esse qui iste. Adipisci magnam quas magni asperiores vitae similique pariatur magnam cupiditate.", new DateTime(2023, 7, 31, 11, 46, 14, 147, DateTimeKind.Unspecified).AddTicks(1908), false },
                    { 174L, 134L, "Et totam cumque optio voluptatem.", new DateTime(2023, 1, 9, 13, 57, 58, 468, DateTimeKind.Unspecified).AddTicks(3116), true },
                    { 175L, 54L, "Doloribus culpa cum quia.", new DateTime(2023, 8, 22, 6, 13, 9, 563, DateTimeKind.Unspecified).AddTicks(8426), true },
                    { 176L, 38L, "Rerum possimus ducimus libero nemo nostrum nobis quam magnam.", new DateTime(2023, 1, 20, 13, 41, 9, 116, DateTimeKind.Unspecified).AddTicks(6990), true },
                    { 177L, 178L, "Molestiae non soluta quo dignissimos voluptate quia dolores nam eius.", new DateTime(2022, 12, 19, 22, 39, 54, 771, DateTimeKind.Unspecified).AddTicks(4360), true },
                    { 178L, 120L, "Nemo est nihil aut et occaecati et quibusdam reprehenderit voluptate. Magnam ducimus in placeat unde cum. Placeat sapiente qui quas et maiores dolorum ducimus. Incidunt dolor corporis. Autem quod ut debitis omnis enim quia qui voluptate.", new DateTime(2023, 2, 26, 19, 18, 25, 580, DateTimeKind.Unspecified).AddTicks(5309), false },
                    { 179L, 192L, "itaque", new DateTime(2023, 1, 1, 16, 44, 27, 822, DateTimeKind.Unspecified).AddTicks(8116), true },
                    { 180L, 161L, "Sit officiis qui quo in.", new DateTime(2022, 7, 21, 5, 38, 19, 726, DateTimeKind.Unspecified).AddTicks(2716), true },
                    { 181L, 19L, "Nihil eum sit.", new DateTime(2022, 12, 10, 18, 18, 11, 933, DateTimeKind.Unspecified).AddTicks(9254), true },
                    { 182L, 167L, "Maiores ad rem dolor laboriosam consequatur nihil.\nLaudantium quae nam qui.", new DateTime(2023, 6, 22, 9, 28, 15, 666, DateTimeKind.Unspecified).AddTicks(5513), false },
                    { 183L, 11L, "Doloremque et architecto corrupti fugiat porro in voluptatibus. Eos incidunt velit voluptatem. Accusamus maxime atque quasi eos optio. Nisi optio dolorum consequatur qui qui expedita deserunt fuga. Sed quo accusantium deleniti ipsam dignissimos dolores. Facere dolor ea sequi voluptas tenetur.", new DateTime(2023, 1, 31, 8, 24, 5, 71, DateTimeKind.Unspecified).AddTicks(3225), false },
                    { 184L, 149L, "Consequatur aut numquam nulla nobis.\nBlanditiis soluta odio eveniet.", new DateTime(2023, 7, 5, 13, 7, 24, 873, DateTimeKind.Unspecified).AddTicks(4898), true },
                    { 185L, 111L, "Cumque labore ut.", new DateTime(2023, 8, 19, 18, 46, 44, 520, DateTimeKind.Unspecified).AddTicks(737), true },
                    { 186L, 30L, "Dignissimos amet vero nam possimus laborum id consequuntur molestias ut.\nConsequatur dolores sit autem.", new DateTime(2023, 7, 3, 10, 54, 3, 912, DateTimeKind.Unspecified).AddTicks(6648), false },
                    { 187L, 8L, "vero", new DateTime(2023, 2, 27, 2, 50, 26, 566, DateTimeKind.Unspecified).AddTicks(9971), false },
                    { 188L, 12L, "Perspiciatis magnam aut repellendus quis.\nAlias corporis in dolores enim temporibus molestiae dolorem.\nEt aut labore et aut.\nIllo dolor voluptate ipsam.\nFuga magnam officiis voluptatum.\nExercitationem dolorem voluptate quasi aliquid sequi est.", new DateTime(2022, 9, 21, 15, 36, 11, 173, DateTimeKind.Unspecified).AddTicks(2467), true },
                    { 189L, 59L, "dolor", new DateTime(2022, 3, 16, 16, 41, 57, 419, DateTimeKind.Unspecified).AddTicks(4196), false },
                    { 190L, 176L, "Nihil dicta voluptas dolores id ratione corrupti. Similique totam fugit. Facere molestiae et.", new DateTime(2023, 8, 17, 9, 33, 48, 966, DateTimeKind.Unspecified).AddTicks(7197), true },
                    { 191L, 38L, "Praesentium nesciunt sit deserunt aut aut enim aut sunt sed.\nDucimus est qui reprehenderit nostrum.\nDicta voluptatem culpa minima officia aliquam rerum ex magnam.\nEos esse illum tempora autem nihil dolorum sapiente molestiae.\nEt quidem dolores numquam.", new DateTime(2022, 5, 24, 4, 42, 19, 546, DateTimeKind.Unspecified).AddTicks(1021), false },
                    { 192L, 120L, "Aut non qui. Aut aliquam quia distinctio. Et ut ut pariatur et velit totam possimus necessitatibus. Voluptatem quasi corrupti totam ratione saepe ducimus consequuntur consequatur sunt. Ut fugit nobis consectetur autem sit fugiat.", new DateTime(2023, 1, 5, 1, 52, 45, 65, DateTimeKind.Unspecified).AddTicks(7502), true },
                    { 193L, 18L, "sapiente", new DateTime(2023, 6, 24, 19, 21, 11, 610, DateTimeKind.Unspecified).AddTicks(1492), true },
                    { 194L, 45L, "Aut quisquam labore praesentium et est asperiores corrupti veritatis odio.\nIusto magni consequatur similique minima.\nSed omnis distinctio.\nBeatae quidem nesciunt perspiciatis temporibus omnis.\nQui ducimus ut.", new DateTime(2022, 12, 18, 18, 54, 16, 975, DateTimeKind.Unspecified).AddTicks(6899), true },
                    { 195L, 146L, "Dignissimos consectetur aperiam adipisci corporis.\nReprehenderit enim voluptates doloribus odio.\nConsequatur perferendis autem sed magni dignissimos.", new DateTime(2023, 3, 4, 8, 4, 43, 150, DateTimeKind.Unspecified).AddTicks(6380), true },
                    { 196L, 106L, "Rerum sunt laborum sed aut omnis eveniet dolore velit. Natus molestiae sint laudantium qui consequatur et rerum harum et. Quo officia et dignissimos aut.", new DateTime(2023, 8, 18, 2, 55, 7, 561, DateTimeKind.Unspecified).AddTicks(7678), false },
                    { 197L, 132L, "Cupiditate inventore neque enim numquam.", new DateTime(2021, 6, 6, 15, 37, 1, 827, DateTimeKind.Unspecified).AddTicks(7713), true },
                    { 198L, 39L, "sunt", new DateTime(2023, 8, 6, 7, 41, 55, 533, DateTimeKind.Unspecified).AddTicks(4484), true },
                    { 199L, 36L, "Id libero corporis sint nulla adipisci veniam suscipit ut.", new DateTime(2022, 7, 19, 1, 49, 3, 445, DateTimeKind.Unspecified).AddTicks(1657), true },
                    { 200L, 88L, "Aut velit sint est aperiam. Ex sequi non voluptatem illo porro quas impedit qui. Cumque reiciendis in dolores eos atque sint.", new DateTime(2021, 9, 26, 12, 25, 28, 579, DateTimeKind.Unspecified).AddTicks(4817), true }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "Output", "SubmittedAt", "UserId" },
                values: new object[,]
                {
                    { 1L, 164L, "Vitae earum pariatur animi saepe explicabo asperiores molestiae et nihil. Esse provident id saepe nesciunt enim. Neque nemo dolore cupiditate temporibus vitae. Ut est voluptates qui minima dolor totam reprehenderit. Dolores non blanditiis facere numquam et facilis. Saepe sequi adipisci labore nesciunt.", new DateTime(2023, 6, 10, 5, 0, 6, 462, DateTimeKind.Unspecified).AddTicks(9540), "Tempora minus et in facilis natus voluptatem voluptas non. Dignissimos dicta dolor delectus molestiae alias accusantium voluptatem. Delectus cumque iste. Ea nam aut et. Necessitatibus molestiae odit quibusdam ullam ad ab quae.", new DateTime(2023, 8, 18, 6, 43, 31, 201, DateTimeKind.Unspecified).AddTicks(9772), 33L },
                    { 2L, 57L, "Ea iste quos non incidunt consectetur numquam.\nQuod facilis dolorem libero.\nNostrum voluptates tempore non sint debitis et.\nFacilis temporibus molestias repudiandae aut amet non.\nIpsum amet perferendis id.\nAlias aut deleniti optio ea optio numquam.", new DateTime(2023, 8, 21, 12, 42, 0, 326, DateTimeKind.Unspecified).AddTicks(1115), "Aut vel dolores cupiditate et consectetur consequatur voluptatem. Voluptatem quasi quo assumenda maiores sit aliquid consequatur alias. Sunt praesentium voluptatem recusandae hic nostrum et consectetur ut aut.", new DateTime(2023, 8, 22, 8, 8, 30, 223, DateTimeKind.Unspecified).AddTicks(6915), 8L },
                    { 3L, 98L, "Eum distinctio corporis ut dolorem et velit.", new DateTime(2022, 8, 16, 13, 3, 42, 271, DateTimeKind.Unspecified).AddTicks(7542), "Quis laboriosam dolores soluta illo est numquam.", new DateTime(2023, 8, 7, 16, 27, 42, 662, DateTimeKind.Unspecified).AddTicks(6555), 40L },
                    { 4L, 187L, "Repellat est sequi.\nEaque cupiditate consequuntur harum deserunt atque delectus nisi.\nAut voluptate ut tenetur sint quam consequatur praesentium.", new DateTime(2023, 4, 4, 21, 10, 58, 613, DateTimeKind.Unspecified).AddTicks(2566), "Corrupti quasi omnis.\nRerum iusto dicta.\nMolestiae velit ut reprehenderit assumenda similique vel consequatur neque.\nUt velit sunt ut sint maiores beatae et.", new DateTime(2023, 5, 6, 23, 27, 51, 863, DateTimeKind.Unspecified).AddTicks(6729), 1L },
                    { 5L, 80L, "Aspernatur qui delectus ut.", new DateTime(2022, 5, 16, 10, 34, 52, 838, DateTimeKind.Unspecified).AddTicks(7908), "nobis", new DateTime(2023, 7, 15, 0, 20, 2, 210, DateTimeKind.Unspecified).AddTicks(7276), 7L },
                    { 6L, 192L, "perferendis", new DateTime(2023, 2, 23, 5, 55, 39, 876, DateTimeKind.Unspecified).AddTicks(797), "Esse voluptas facere autem. Delectus qui iste error voluptatem. Molestiae sequi impedit velit iste. Ipsum tempore molestiae esse aperiam eos accusantium placeat.", new DateTime(2023, 2, 26, 12, 34, 15, 290, DateTimeKind.Unspecified).AddTicks(5162), 33L },
                    { 7L, 61L, "aut", new DateTime(2023, 5, 18, 3, 0, 16, 890, DateTimeKind.Unspecified).AddTicks(2153), "Iure saepe quas accusamus magni repellat velit ea.\nReprehenderit est labore.\nPorro earum consequatur nulla aspernatur a.\nVel nihil qui quae unde aut quo sed.\nA velit aut commodi asperiores vel nam.", null, 7L },
                    { 8L, 21L, "Voluptatem error provident quo beatae culpa modi repellendus.\nQuasi suscipit soluta neque praesentium voluptatem sed quis.", new DateTime(2023, 6, 5, 10, 21, 49, 506, DateTimeKind.Unspecified).AddTicks(1761), "Reiciendis sint debitis. Et ad sed perspiciatis omnis non. Placeat error explicabo accusantium maiores deleniti repellat praesentium. Id et eos. Expedita magni et impedit voluptatibus. Qui consequuntur nulla explicabo expedita aut.", new DateTime(2023, 8, 7, 5, 1, 22, 238, DateTimeKind.Unspecified).AddTicks(6830), 28L },
                    { 9L, 76L, "Ut officia fugit quasi.\nSit rerum quis esse placeat nemo.\nDolor qui est est omnis.", new DateTime(2022, 8, 2, 21, 15, 1, 446, DateTimeKind.Unspecified).AddTicks(4138), "Consequuntur iure deserunt ut rem iusto et.", new DateTime(2023, 4, 13, 18, 54, 17, 54, DateTimeKind.Unspecified).AddTicks(9700), 12L },
                    { 10L, 4L, "qui", new DateTime(2023, 5, 10, 3, 58, 2, 365, DateTimeKind.Unspecified).AddTicks(4529), "earum", new DateTime(2023, 6, 7, 20, 57, 56, 333, DateTimeKind.Unspecified).AddTicks(3512), 3L }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "Output", "SubmittedAt", "UserId" },
                values: new object[,]
                {
                    { 11L, 147L, "Explicabo repellendus enim quia aut voluptas aperiam voluptatem. Sed aut placeat possimus nobis facilis quidem excepturi aperiam voluptatem. Possimus sunt magnam. Omnis rerum nihil possimus ut eius voluptates laboriosam provident aut. Nobis quia mollitia velit ab sequi quidem est earum. Aliquam amet vel quis temporibus.", new DateTime(2022, 6, 17, 21, 50, 51, 191, DateTimeKind.Unspecified).AddTicks(8184), "Omnis tenetur consequatur sed ea unde laudantium. Minima cum nam quia voluptas numquam officiis. A excepturi repudiandae quo non earum sed ipsam nemo distinctio. Qui voluptas iure iste praesentium nostrum vel. Molestiae et ratione voluptas ab id et debitis sapiente.", new DateTime(2022, 7, 5, 3, 56, 30, 637, DateTimeKind.Unspecified).AddTicks(993), 5L },
                    { 12L, 56L, "Nulla dolor ipsam qui fugiat.\nTempora cumque doloremque aut exercitationem necessitatibus sed quia.\nHic dignissimos rerum beatae consequatur maxime et aut omnis veritatis.\nQuia in magni deleniti.", new DateTime(2023, 5, 20, 10, 29, 46, 5, DateTimeKind.Unspecified).AddTicks(1822), "qui", new DateTime(2023, 7, 7, 17, 25, 9, 200, DateTimeKind.Unspecified).AddTicks(5761), 39L },
                    { 13L, 100L, "Et et sit. Eos maiores voluptas ut qui in mollitia consequatur. Animi provident reiciendis soluta sed possimus.", new DateTime(2023, 4, 27, 3, 11, 54, 739, DateTimeKind.Unspecified).AddTicks(9679), "Similique unde accusamus rem sint quo mollitia ea.\nQuos at ut necessitatibus soluta nulla.\nRerum beatae ipsam nemo possimus omnis.\nEst in autem placeat harum eum a adipisci quam et.", new DateTime(2023, 8, 5, 21, 9, 20, 947, DateTimeKind.Unspecified).AddTicks(6977), 11L },
                    { 14L, 62L, "alias", new DateTime(2023, 6, 12, 8, 56, 36, 914, DateTimeKind.Unspecified).AddTicks(8113), "Consequuntur aut excepturi blanditiis impedit at.", new DateTime(2023, 7, 30, 22, 24, 40, 724, DateTimeKind.Unspecified).AddTicks(6847), 6L },
                    { 15L, 15L, "eveniet", new DateTime(2023, 5, 6, 6, 59, 0, 844, DateTimeKind.Unspecified).AddTicks(1374), "nam", new DateTime(2023, 5, 16, 5, 40, 43, 67, DateTimeKind.Unspecified).AddTicks(7634), 4L },
                    { 16L, 127L, "Iusto laboriosam fuga dolor autem.\nAut consequatur ipsam alias laboriosam molestiae dolor.\nEarum nam eveniet quas cupiditate.\nSint inventore ducimus.", new DateTime(2023, 3, 8, 2, 52, 11, 737, DateTimeKind.Unspecified).AddTicks(698), "Aut possimus mollitia non repudiandae nisi.", new DateTime(2023, 3, 21, 2, 20, 0, 821, DateTimeKind.Unspecified).AddTicks(7088), 34L },
                    { 17L, 37L, "tempore", new DateTime(2022, 3, 31, 18, 43, 4, 52, DateTimeKind.Unspecified).AddTicks(7017), "Tempore quae quia iste qui rerum voluptas consequuntur debitis adipisci. Ab et dolor autem necessitatibus magnam. Sunt omnis vel deleniti in expedita dolores quibusdam. Sit eum in modi placeat id eos nulla perferendis ad. Ut sint sint totam est porro rerum autem velit. Cumque modi fugiat.", new DateTime(2023, 1, 1, 17, 44, 4, 208, DateTimeKind.Unspecified).AddTicks(5588), 40L },
                    { 18L, 189L, "Repellendus repudiandae distinctio.\nUllam aut impedit enim nostrum.\nCommodi et odio temporibus expedita nulla repudiandae eum nobis assumenda.\nMollitia hic deleniti id maxime et similique quo.", new DateTime(2022, 4, 7, 8, 43, 21, 849, DateTimeKind.Unspecified).AddTicks(8987), "Facere facere sed consequatur quaerat.\nUt maxime dolor atque.\nSunt laboriosam id qui consectetur cupiditate dolor et ea a.\nEa amet delectus dolor eligendi iste qui qui mollitia.\nVeniam doloribus et nobis tempore et officia placeat.", new DateTime(2022, 7, 25, 2, 58, 23, 71, DateTimeKind.Unspecified).AddTicks(7254), 20L },
                    { 19L, 162L, "Ut illo quae. Ut nostrum velit repellat qui non ipsa. Rem temporibus sit.", new DateTime(2022, 7, 5, 21, 49, 59, 539, DateTimeKind.Unspecified).AddTicks(1680), "necessitatibus", new DateTime(2023, 5, 6, 21, 47, 56, 963, DateTimeKind.Unspecified).AddTicks(1665), 9L },
                    { 20L, 99L, "Aut debitis sit nesciunt qui et odit.\nEligendi quia tempore.\nInventore est doloribus.\nEt nostrum quod laborum excepturi ad eligendi.\nIste voluptas rem ab autem voluptatem rerum sed ipsum hic.\nVelit qui voluptas.", new DateTime(2023, 8, 22, 13, 30, 36, 446, DateTimeKind.Unspecified).AddTicks(787), "Recusandae eaque dolor qui nisi itaque.", new DateTime(2023, 8, 22, 19, 50, 31, 488, DateTimeKind.Unspecified).AddTicks(8290), 34L },
                    { 21L, 28L, "Voluptatem beatae est amet explicabo id illum doloremque inventore.", new DateTime(2023, 8, 10, 9, 34, 44, 151, DateTimeKind.Unspecified).AddTicks(558), "et", new DateTime(2023, 8, 11, 18, 38, 30, 935, DateTimeKind.Unspecified).AddTicks(3344), 23L },
                    { 22L, 45L, "Ipsa enim cum.\nQuos odit culpa et dolores reiciendis.", new DateTime(2023, 6, 7, 6, 41, 49, 193, DateTimeKind.Unspecified).AddTicks(9516), "voluptatem", new DateTime(2023, 8, 16, 1, 2, 34, 798, DateTimeKind.Unspecified).AddTicks(1096), 16L },
                    { 23L, 60L, "Corporis ut iusto in.", new DateTime(2021, 1, 14, 22, 17, 16, 718, DateTimeKind.Unspecified).AddTicks(6547), "Perferendis quia perferendis quisquam eos. Officia nulla vel laudantium. Est fugit beatae excepturi maiores voluptatem ab. Modi ipsa ut autem perferendis labore voluptatem aliquid aut. Id repudiandae et cum qui explicabo autem id omnis. Doloribus iusto perspiciatis.", new DateTime(2021, 9, 22, 16, 30, 4, 28, DateTimeKind.Unspecified).AddTicks(4782), 34L },
                    { 24L, 133L, "autem", new DateTime(2023, 5, 28, 7, 5, 49, 60, DateTimeKind.Unspecified).AddTicks(1193), "Ut ab sunt.", new DateTime(2023, 8, 22, 18, 27, 25, 985, DateTimeKind.Unspecified).AddTicks(8532), 13L },
                    { 25L, 97L, "Illo est omnis repellendus non ut maiores eos.\nUt recusandae quo repellendus dolores molestias.\nEst aut dolor.\nSunt ut corrupti error.\nAut fugiat et ut est exercitationem voluptate explicabo.\nQuos quasi placeat ut sit in neque et.", new DateTime(2022, 12, 13, 3, 13, 52, 107, DateTimeKind.Unspecified).AddTicks(4965), "Non repellendus vel nesciunt omnis enim. Molestiae nobis dolorum excepturi veniam maiores aperiam. Dolores omnis mollitia est dolore non quod inventore alias. Voluptas ratione rerum eum quae iusto. Repudiandae voluptatem sed ipsam voluptatem ad dolor exercitationem.", new DateTime(2023, 1, 9, 13, 49, 22, 532, DateTimeKind.Unspecified).AddTicks(2843), 32L },
                    { 26L, 146L, "Quas voluptatem est illo aspernatur voluptas rerum. Qui consequatur quisquam iusto neque eos. Rerum sit voluptas quis quo dolores excepturi. Minima illum voluptatum. Quae sit hic accusantium et error. Eos sed iusto vel sunt qui voluptatem et.", new DateTime(2023, 5, 7, 21, 50, 1, 771, DateTimeKind.Unspecified).AddTicks(9133), "Ut dolores molestiae itaque assumenda molestiae dolores.\nEt aut asperiores voluptatem voluptas labore.\nOfficiis voluptas eos omnis repellendus et accusamus.", new DateTime(2023, 5, 29, 20, 13, 54, 488, DateTimeKind.Unspecified).AddTicks(390), 21L },
                    { 27L, 69L, "In molestiae et et est rem nisi non aut.", new DateTime(2023, 3, 26, 16, 52, 49, 775, DateTimeKind.Unspecified).AddTicks(8714), "Labore facilis et qui ut aut qui tenetur impedit quam.\nConsequatur nihil corrupti voluptatum est sed molestias natus sed et.", new DateTime(2023, 4, 6, 6, 50, 38, 578, DateTimeKind.Unspecified).AddTicks(5955), 26L },
                    { 28L, 116L, "Ut minus sunt facere eveniet.\nModi eveniet qui praesentium explicabo nam ipsam architecto nesciunt.\nAut atque labore repellat minus voluptas.\nAlias voluptates voluptatem est ullam quae architecto.\nMolestias vel cum commodi nobis ea inventore non.", new DateTime(2023, 5, 25, 9, 58, 20, 849, DateTimeKind.Unspecified).AddTicks(7667), "Dolorum ab totam blanditiis omnis omnis amet vitae.\nOmnis commodi assumenda perspiciatis voluptatem dolores similique voluptas officiis eius.\nPariatur excepturi id officia quis rerum quo rem qui illo.", new DateTime(2023, 5, 27, 0, 13, 29, 209, DateTimeKind.Unspecified).AddTicks(9743), 39L },
                    { 29L, 33L, "Rem illo fugit sapiente fugit sapiente.\nLaborum magni nisi omnis.\nNumquam et odio voluptas et aut ipsam debitis dolorem.\nVoluptas quo earum et consequatur repellendus voluptatem non ipsam qui.", new DateTime(2023, 2, 11, 12, 9, 29, 868, DateTimeKind.Unspecified).AddTicks(7468), "iure", new DateTime(2023, 8, 1, 2, 41, 8, 778, DateTimeKind.Unspecified).AddTicks(8913), 17L },
                    { 30L, 143L, "Excepturi consequatur sint aliquid quo ullam eos esse. Mollitia incidunt expedita quis. Numquam in voluptatem quia sequi ex officia. Doloremque delectus possimus eum magnam ad sint.", new DateTime(2023, 8, 19, 8, 38, 24, 225, DateTimeKind.Unspecified).AddTicks(9586), "Iusto quos qui voluptatum autem deserunt quasi. Facilis id autem porro ex autem aut. Hic voluptate et consectetur dolorum dicta dicta repudiandae suscipit. Deserunt aut ab et ut quia rerum est modi autem. Id est et dolores.", new DateTime(2023, 8, 20, 3, 49, 23, 471, DateTimeKind.Unspecified).AddTicks(8864), 26L },
                    { 31L, 5L, "Esse voluptas aut aut cupiditate et ut voluptate.\nEos voluptas repellat veritatis praesentium dolor.\nVelit eum nam voluptatem enim libero non et.", new DateTime(2022, 6, 7, 18, 31, 9, 485, DateTimeKind.Unspecified).AddTicks(6124), "Aut autem odit.", new DateTime(2022, 9, 8, 19, 28, 11, 425, DateTimeKind.Unspecified).AddTicks(7587), 28L },
                    { 32L, 178L, "Veritatis commodi assumenda debitis eum nobis animi voluptas et.\nConsectetur non ad.\nAtque hic incidunt.\nMaxime fugit nemo cum totam hic.", new DateTime(2022, 4, 21, 19, 56, 17, 219, DateTimeKind.Unspecified).AddTicks(9870), "Fugit et repellendus omnis dolorem et repudiandae dolores totam. Ad molestiae maiores laborum eaque alias voluptatibus dolor dignissimos eum. Ut reprehenderit reiciendis officiis rerum nihil atque iure. Illum et vitae rerum atque voluptatem facilis exercitationem commodi est.", new DateTime(2022, 5, 16, 10, 33, 6, 531, DateTimeKind.Unspecified).AddTicks(3350), 15L },
                    { 33L, 188L, "Quas enim tempore atque dolorem cupiditate rem dolores in.", new DateTime(2023, 7, 21, 14, 38, 51, 50, DateTimeKind.Unspecified).AddTicks(7520), "aut", new DateTime(2023, 8, 4, 13, 43, 43, 111, DateTimeKind.Unspecified).AddTicks(2054), 37L },
                    { 34L, 144L, "Voluptas aspernatur consequuntur est ea.\nQuam facere totam est cupiditate nisi voluptatem iure.", new DateTime(2023, 1, 22, 12, 36, 33, 859, DateTimeKind.Unspecified).AddTicks(3180), "et", new DateTime(2023, 6, 9, 6, 14, 24, 27, DateTimeKind.Unspecified).AddTicks(3126), 9L },
                    { 35L, 123L, "Sequi quo reprehenderit nihil officiis non qui dignissimos ut officia.\nNam autem dolores ipsam quibusdam placeat assumenda alias.\nIllo voluptas repellendus sint vel.\nEius aperiam nesciunt et maiores incidunt ut eius dolorum occaecati.\nAsperiores aut ut harum beatae.", new DateTime(2023, 4, 7, 6, 15, 43, 405, DateTimeKind.Unspecified).AddTicks(8533), "Maxime praesentium unde porro in laborum.", new DateTime(2023, 5, 30, 14, 14, 52, 443, DateTimeKind.Unspecified).AddTicks(8917), 36L },
                    { 36L, 70L, "Officiis laborum reiciendis.", new DateTime(2022, 9, 20, 16, 23, 31, 211, DateTimeKind.Unspecified).AddTicks(8796), "Sed id velit voluptatem nesciunt.\nQuibusdam et possimus necessitatibus laudantium minus aut qui aliquid assumenda.", new DateTime(2023, 4, 21, 12, 39, 50, 968, DateTimeKind.Unspecified).AddTicks(8331), 15L },
                    { 37L, 37L, "A commodi incidunt laudantium nihil vel et.\nCupiditate autem fugiat eum suscipit qui iure quo id.\nQui quisquam ratione.", new DateTime(2023, 3, 4, 16, 24, 11, 73, DateTimeKind.Unspecified).AddTicks(4992), "Nihil odit quaerat et sed voluptatum quod alias tempora temporibus.\nAutem est sit beatae autem.\nHarum non sit natus cupiditate iusto quia sapiente libero doloremque.\nReprehenderit et voluptatum corporis atque ut.\nIpsam quia minima et ab illo fugiat animi unde.\nMollitia amet enim aperiam voluptas quod sint dignissimos optio.", new DateTime(2023, 3, 13, 6, 21, 16, 7, DateTimeKind.Unspecified).AddTicks(2040), 18L },
                    { 38L, 26L, "Laborum sunt enim illo enim.\nSunt omnis aliquam nihil alias neque.\nQui et rerum nihil.\nDeleniti possimus in et repudiandae.", new DateTime(2023, 5, 14, 15, 51, 27, 788, DateTimeKind.Unspecified).AddTicks(7424), "Et culpa facilis architecto laborum sunt id placeat eius. Ut minus veniam. Optio enim excepturi eaque excepturi minima error impedit quaerat. Et corporis illo est et voluptatibus distinctio ut consectetur. Est asperiores fugit sit explicabo voluptates natus. Molestias necessitatibus et eligendi vitae nihil.", new DateTime(2023, 8, 10, 15, 7, 23, 49, DateTimeKind.Unspecified).AddTicks(1131), 3L },
                    { 39L, 187L, "Voluptatem eos ducimus.\nEaque sint voluptas labore consequatur.\nUt omnis dolorem nihil sequi sit rerum animi quisquam sit.", new DateTime(2023, 4, 19, 13, 26, 35, 263, DateTimeKind.Unspecified).AddTicks(4587), "consequatur", new DateTime(2023, 6, 2, 16, 32, 14, 296, DateTimeKind.Unspecified).AddTicks(2400), 6L },
                    { 40L, 39L, "Eveniet laborum ullam sint tempore aliquam id dolor officiis. Ut ut occaecati voluptas sequi quia sed ex. Repellendus recusandae pariatur vero ipsa saepe hic qui excepturi sunt. Quis et quis officia doloribus molestiae praesentium et. Ut mollitia neque. Beatae rerum recusandae nulla consequatur dolor eveniet vel.", new DateTime(2023, 5, 21, 19, 38, 1, 242, DateTimeKind.Unspecified).AddTicks(1120), "Beatae pariatur quae facere quaerat dolorum est non modi.", new DateTime(2023, 7, 5, 3, 48, 43, 127, DateTimeKind.Unspecified).AddTicks(9236), 28L },
                    { 41L, 195L, "Eos rerum quia quasi. Est quia omnis ea. Aut ea minus adipisci accusamus perferendis quaerat nostrum quod earum. Sed doloremque nemo quis. Totam sed est neque aperiam. Deserunt omnis aperiam non hic minus necessitatibus architecto et aut.", new DateTime(2023, 2, 23, 15, 36, 32, 398, DateTimeKind.Unspecified).AddTicks(4471), "Ipsum quos et voluptatem laboriosam eius id. Fugiat illo distinctio vero. Cumque qui corporis. Illo labore molestiae consectetur voluptas dolor nesciunt. Veritatis cupiditate ea nam sit velit ut quis nobis sed.", new DateTime(2023, 5, 4, 1, 47, 26, 478, DateTimeKind.Unspecified).AddTicks(8721), 36L },
                    { 42L, 163L, "Omnis et autem architecto recusandae aperiam quasi est.", new DateTime(2023, 7, 23, 3, 39, 50, 748, DateTimeKind.Unspecified).AddTicks(5463), "Et minus et ea ipsam laboriosam vel ad eligendi sed.", new DateTime(2023, 8, 1, 18, 36, 5, 998, DateTimeKind.Unspecified).AddTicks(1058), 22L },
                    { 43L, 98L, "Earum suscipit autem libero exercitationem dolores.", new DateTime(2022, 10, 21, 15, 22, 37, 576, DateTimeKind.Unspecified).AddTicks(1583), "Cum repellendus accusamus.", new DateTime(2023, 7, 21, 0, 12, 39, 383, DateTimeKind.Unspecified).AddTicks(7521), 6L },
                    { 44L, 130L, "Rerum aliquam quibusdam error et fugiat aut magnam.", new DateTime(2022, 9, 8, 3, 11, 21, 282, DateTimeKind.Unspecified).AddTicks(2140), "amet", new DateTime(2023, 4, 1, 15, 12, 7, 530, DateTimeKind.Unspecified).AddTicks(6178), 38L },
                    { 45L, 85L, "Sapiente magnam quia ut a in.\nIste excepturi ratione quia et rerum magni sunt.", new DateTime(2022, 11, 22, 18, 9, 4, 521, DateTimeKind.Unspecified).AddTicks(5583), "Cumque autem nihil.\nNatus ipsa ut quis veritatis doloremque quisquam.\nCupiditate tenetur quia blanditiis est.\nVoluptate voluptate exercitationem.\nMolestiae architecto quia sapiente quae commodi.\nVel architecto deleniti maxime provident fugiat facere.", new DateTime(2023, 2, 7, 8, 18, 32, 99, DateTimeKind.Unspecified).AddTicks(1284), 30L },
                    { 46L, 63L, "Fugiat ut fuga magnam distinctio sit voluptate.\nQuia iusto dolor corporis ducimus et numquam.\nAsperiores et id dolore a et provident.", new DateTime(2023, 2, 1, 1, 38, 10, 959, DateTimeKind.Unspecified).AddTicks(1370), "Quisquam corporis suscipit magni odio dolorum. Voluptatem et sunt. Autem cumque commodi voluptate non.", new DateTime(2023, 5, 19, 5, 43, 34, 466, DateTimeKind.Unspecified).AddTicks(7605), 13L },
                    { 47L, 187L, "quia", new DateTime(2023, 3, 30, 9, 58, 8, 232, DateTimeKind.Unspecified).AddTicks(6855), "quis", new DateTime(2023, 7, 3, 7, 18, 13, 61, DateTimeKind.Unspecified).AddTicks(5199), 3L },
                    { 48L, 76L, "Non laudantium aut non.\nAsperiores nesciunt dolore.\nIure consequuntur voluptatem velit.\nAutem quo molestiae recusandae.\nEt deserunt ratione laborum.", new DateTime(2023, 3, 27, 3, 55, 10, 343, DateTimeKind.Unspecified).AddTicks(9850), "et", new DateTime(2023, 8, 17, 15, 21, 31, 212, DateTimeKind.Unspecified).AddTicks(4864), 34L },
                    { 49L, 123L, "Distinctio quos eveniet corporis voluptatem voluptatem ipsam deserunt.\nDolor quisquam beatae eum dicta.\nNatus quaerat modi expedita deleniti reprehenderit ut veritatis at.", new DateTime(2023, 2, 18, 2, 11, 0, 188, DateTimeKind.Unspecified).AddTicks(6980), "delectus", new DateTime(2023, 4, 11, 13, 20, 11, 548, DateTimeKind.Unspecified).AddTicks(526), 9L },
                    { 50L, 198L, "Sed impedit voluptatum provident aut tempore et.\nEnim delectus saepe sit esse possimus occaecati consequuntur.\nDignissimos asperiores voluptates enim quia molestiae quae ullam.\nVeritatis cumque sed repellat porro.\nLaboriosam ut unde voluptatem vitae est aut maiores in quod.", new DateTime(2023, 7, 23, 21, 34, 48, 97, DateTimeKind.Unspecified).AddTicks(9913), "explicabo", null, 39L },
                    { 51L, 41L, "Sit quod eum aliquam esse minima et.", new DateTime(2023, 2, 4, 10, 31, 18, 918, DateTimeKind.Unspecified).AddTicks(2969), "omnis", new DateTime(2023, 4, 7, 10, 3, 32, 740, DateTimeKind.Unspecified).AddTicks(7990), 25L },
                    { 52L, 137L, "Non quis quae voluptatibus. Aut sit similique necessitatibus suscipit. Enim et dolorum. Omnis nihil optio et molestias perferendis magni. Est quos aliquid autem quis quia et nulla ab.", new DateTime(2023, 6, 9, 1, 16, 57, 746, DateTimeKind.Unspecified).AddTicks(4871), "Incidunt quisquam exercitationem deserunt nobis qui.", new DateTime(2023, 8, 18, 21, 42, 54, 105, DateTimeKind.Unspecified).AddTicks(6656), 20L }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "Output", "SubmittedAt", "UserId" },
                values: new object[,]
                {
                    { 53L, 108L, "Deserunt facere rerum omnis nam ipsum eos vitae quas in. Voluptatibus quidem sapiente ea ut corrupti. Consequatur in iure. Deleniti eum aut sint perferendis voluptas id et corporis sunt. Iure dolor blanditiis aperiam nostrum iure. Voluptatem voluptatem eius eveniet.", new DateTime(2023, 6, 19, 11, 23, 56, 885, DateTimeKind.Unspecified).AddTicks(696), "nihil", new DateTime(2023, 7, 25, 7, 25, 5, 965, DateTimeKind.Unspecified).AddTicks(5149), 4L },
                    { 54L, 132L, "Natus animi nihil ad inventore perspiciatis ratione nesciunt consequatur voluptatum.", new DateTime(2023, 3, 12, 16, 6, 42, 473, DateTimeKind.Unspecified).AddTicks(7254), "Officia magnam dolor et itaque velit est accusamus dolores labore.\nQui est nemo nihil voluptatum alias ab laudantium.", null, 40L },
                    { 55L, 152L, "reiciendis", new DateTime(2023, 2, 17, 18, 24, 38, 444, DateTimeKind.Unspecified).AddTicks(5553), "Qui cum quidem aut amet sed voluptas ex quam dolorum.\nDistinctio quae nihil ea aperiam.\nSit labore est soluta consequatur molestiae sed aut.", new DateTime(2023, 3, 9, 15, 15, 7, 704, DateTimeKind.Unspecified).AddTicks(8255), 11L },
                    { 56L, 182L, "Necessitatibus soluta error aperiam omnis sed. Culpa quia qui molestiae. Suscipit est voluptate nihil. Corrupti facilis excepturi.", new DateTime(2023, 2, 10, 9, 38, 30, 532, DateTimeKind.Unspecified).AddTicks(8066), "Magnam occaecati nihil molestiae commodi vel dolore eligendi.\nAut magnam sequi quod quibusdam repellat repudiandae autem.\nQui natus modi.", new DateTime(2023, 6, 16, 20, 46, 16, 214, DateTimeKind.Unspecified).AddTicks(2254), 40L },
                    { 57L, 179L, "et", new DateTime(2023, 6, 20, 12, 35, 37, 216, DateTimeKind.Unspecified).AddTicks(4102), "enim", new DateTime(2023, 6, 22, 18, 52, 27, 662, DateTimeKind.Unspecified).AddTicks(6927), 38L },
                    { 58L, 70L, "Dolorem sed officiis saepe voluptas ea vitae.\nNam et eaque sunt pariatur praesentium.", new DateTime(2023, 5, 21, 9, 24, 44, 447, DateTimeKind.Unspecified).AddTicks(6197), "Nihil magnam laborum itaque ad perferendis laboriosam sit.", new DateTime(2023, 6, 23, 17, 51, 34, 190, DateTimeKind.Unspecified).AddTicks(1454), 19L },
                    { 59L, 134L, "Quo amet modi itaque est sit.\nQuas nobis sed nobis.\nDoloremque nam praesentium atque occaecati vero.\nVeritatis et eos suscipit vel et eligendi.", new DateTime(2022, 7, 2, 18, 50, 53, 664, DateTimeKind.Unspecified).AddTicks(3752), "Ut est necessitatibus a qui iste.", null, 30L },
                    { 60L, 66L, "voluptatem", new DateTime(2023, 8, 13, 10, 46, 34, 62, DateTimeKind.Unspecified).AddTicks(6450), "magnam", new DateTime(2023, 8, 14, 21, 18, 38, 869, DateTimeKind.Unspecified).AddTicks(553), 3L },
                    { 61L, 196L, "Nihil explicabo quam in cumque pariatur velit architecto repellat. Vel sapiente a enim est ut rem non quibusdam dolore. Consequatur occaecati ipsa. Rerum voluptatem atque itaque ut et non neque necessitatibus.", new DateTime(2023, 6, 9, 14, 10, 9, 173, DateTimeKind.Unspecified).AddTicks(9699), "et", new DateTime(2023, 8, 9, 6, 24, 52, 889, DateTimeKind.Unspecified).AddTicks(304), 29L },
                    { 62L, 156L, "Velit quia qui.", new DateTime(2023, 5, 15, 16, 32, 52, 235, DateTimeKind.Unspecified).AddTicks(8552), "Id distinctio soluta vero sunt dolores facere saepe sunt.", new DateTime(2023, 7, 12, 17, 38, 5, 444, DateTimeKind.Unspecified).AddTicks(9065), 16L },
                    { 63L, 14L, "praesentium", new DateTime(2022, 3, 8, 14, 24, 26, 506, DateTimeKind.Unspecified).AddTicks(3595), "veniam", new DateTime(2023, 6, 10, 19, 3, 29, 286, DateTimeKind.Unspecified).AddTicks(9947), 33L },
                    { 64L, 179L, "Reiciendis nihil est possimus voluptatem fugiat expedita deserunt quas debitis.", new DateTime(2023, 4, 23, 5, 13, 4, 589, DateTimeKind.Unspecified).AddTicks(7490), "Autem odio doloremque eos exercitationem nostrum nisi sed modi.", new DateTime(2023, 7, 4, 7, 17, 47, 703, DateTimeKind.Unspecified).AddTicks(9099), 10L },
                    { 65L, 199L, "Rerum quod sed sit. Fugit impedit accusantium dolores magnam perspiciatis sed modi vitae ab. Animi dignissimos nulla est non eum sunt velit nostrum. Placeat provident quas dolorem ea voluptates ipsam commodi.", new DateTime(2023, 7, 19, 22, 1, 56, 200, DateTimeKind.Unspecified).AddTicks(7972), "Cum eum voluptas voluptatem. Nesciunt eaque et. Alias voluptatem voluptas.", new DateTime(2023, 7, 22, 15, 37, 38, 753, DateTimeKind.Unspecified).AddTicks(865), 15L },
                    { 66L, 160L, "Dolorem sint necessitatibus ullam commodi dolor cupiditate ut saepe.", new DateTime(2023, 4, 10, 18, 41, 28, 769, DateTimeKind.Unspecified).AddTicks(3162), "Eius repudiandae nihil molestiae et occaecati blanditiis illum libero.\nIn non libero animi est ratione quia.\nEum placeat veritatis illo ut et repellendus non sapiente.\nQui consectetur qui dolorem.\nQui non non et quasi.\nNatus fugit deleniti qui harum sint soluta harum voluptas corrupti.", null, 16L },
                    { 67L, 72L, "Laudantium eos sunt iste enim incidunt voluptatum reprehenderit ut non. Libero possimus quos aut rerum ut quidem. Voluptates laboriosam est aut eveniet adipisci et.", new DateTime(2023, 1, 23, 6, 55, 33, 500, DateTimeKind.Unspecified).AddTicks(5140), "qui", new DateTime(2023, 4, 6, 0, 31, 28, 941, DateTimeKind.Unspecified).AddTicks(8558), 4L },
                    { 68L, 164L, "Consequatur consequatur et dolore nam et veniam placeat aut aspernatur. Rerum eligendi odit ut esse numquam aliquam id. Eaque consectetur commodi distinctio accusantium beatae ullam officiis.", new DateTime(2023, 5, 13, 8, 12, 22, 47, DateTimeKind.Unspecified).AddTicks(4309), "Assumenda corporis quia dolores voluptatem fugiat suscipit dolore explicabo odio.\nAutem aspernatur et voluptatem nihil.", new DateTime(2023, 5, 26, 10, 59, 45, 550, DateTimeKind.Unspecified).AddTicks(6839), 40L },
                    { 69L, 172L, "Saepe dolorum rerum qui modi qui.", new DateTime(2021, 10, 27, 22, 42, 57, 737, DateTimeKind.Unspecified).AddTicks(1372), "Et adipisci sapiente. Sint ut ad culpa aut consequatur molestias. Nobis qui voluptatem id impedit. Enim illo necessitatibus illo reprehenderit.", new DateTime(2022, 10, 6, 13, 30, 57, 335, DateTimeKind.Unspecified).AddTicks(3212), 16L },
                    { 70L, 30L, "Sequi aperiam nemo officiis et sapiente id amet.\nPerspiciatis incidunt dolore.", new DateTime(2022, 11, 23, 22, 48, 43, 2, DateTimeKind.Unspecified).AddTicks(8213), "Quia modi vel ea.\nNon harum aliquid sequi accusamus et in.\nUt qui expedita necessitatibus assumenda ut ex ut.\nCupiditate ea est ut amet exercitationem.\nDistinctio aut necessitatibus quas nihil architecto exercitationem.\nQuis mollitia ducimus occaecati.", new DateTime(2022, 12, 22, 4, 58, 28, 101, DateTimeKind.Unspecified).AddTicks(3476), 28L },
                    { 71L, 168L, "hic", new DateTime(2023, 6, 11, 1, 32, 11, 162, DateTimeKind.Unspecified).AddTicks(7982), "Deleniti sequi cupiditate aut eum.\nVoluptatem et perspiciatis voluptatem suscipit voluptas dolores veritatis.\nArchitecto voluptatem neque nesciunt velit animi ipsum eveniet fugiat officia.\nSint aliquam reprehenderit sapiente.\nQui dolorum voluptatem quia.\nVoluptatibus dolorem dolore mollitia modi expedita ab molestiae.", new DateTime(2023, 8, 18, 15, 52, 8, 629, DateTimeKind.Unspecified).AddTicks(3939), 8L },
                    { 72L, 116L, "Temporibus voluptate voluptatum quod nemo quaerat est exercitationem mollitia sit.", new DateTime(2022, 9, 28, 13, 21, 14, 748, DateTimeKind.Unspecified).AddTicks(3404), "Repellendus est eius dolor id dolor sunt. Sint error consectetur earum. Rem est placeat.", new DateTime(2022, 10, 25, 1, 23, 47, 747, DateTimeKind.Unspecified).AddTicks(3078), 24L },
                    { 73L, 54L, "Ratione in sit voluptatum nostrum.", new DateTime(2023, 8, 13, 0, 29, 12, 436, DateTimeKind.Unspecified).AddTicks(3013), "Blanditiis quam totam rerum in et.\nSed perferendis eius temporibus officiis nulla.\nEt amet repellendus ipsa perspiciatis.\nId nihil nesciunt.\nLaboriosam quis architecto id quisquam nihil quibusdam.", new DateTime(2023, 8, 20, 7, 0, 56, 94, DateTimeKind.Unspecified).AddTicks(8502), 27L },
                    { 74L, 85L, "Dolores aut quis.\nEos sit in.\nEos est eum est magnam maiores.\nAut facere quaerat eos ullam quis perspiciatis officiis.\nNemo quam quia id optio unde.\nSed tenetur ut velit et.", new DateTime(2023, 1, 24, 21, 52, 22, 216, DateTimeKind.Unspecified).AddTicks(4922), "et", new DateTime(2023, 7, 14, 18, 20, 45, 22, DateTimeKind.Unspecified).AddTicks(659), 12L },
                    { 75L, 152L, "Perspiciatis soluta facilis. Voluptatibus voluptatem temporibus provident repellendus. Tempora saepe quod odio veritatis aut dolor. Dolores nostrum minus veniam in. In aspernatur delectus odio sed voluptatum sit ipsa. Nostrum debitis dignissimos sapiente aliquid error sit.", new DateTime(2022, 9, 13, 7, 23, 30, 138, DateTimeKind.Unspecified).AddTicks(7608), "Qui eligendi laboriosam repudiandae.\nCommodi temporibus aperiam ut suscipit id veniam quaerat aut.\nAssumenda rerum ullam aliquid asperiores nemo quaerat sit nemo ducimus.\nEt aut molestiae maxime deleniti perspiciatis enim.", new DateTime(2022, 12, 2, 19, 5, 38, 254, DateTimeKind.Unspecified).AddTicks(7279), 5L },
                    { 76L, 39L, "architecto", new DateTime(2023, 5, 10, 9, 48, 15, 4, DateTimeKind.Unspecified).AddTicks(2742), "Impedit maiores aut et laboriosam voluptatem.\nSoluta porro qui molestiae officiis error molestias.\nLaudantium exercitationem maxime.\nEst sequi at inventore ut nesciunt ut non sed.", new DateTime(2023, 6, 5, 5, 40, 44, 39, DateTimeKind.Unspecified).AddTicks(1376), 28L },
                    { 77L, 106L, "Iusto hic minima doloribus nulla. Omnis ratione rerum. Consectetur et velit quisquam. Sit ut fugiat ad vero molestiae ipsa blanditiis doloribus.", new DateTime(2023, 7, 28, 13, 47, 25, 925, DateTimeKind.Unspecified).AddTicks(7533), "quae", null, 40L },
                    { 78L, 160L, "Accusantium ut laudantium temporibus omnis sunt explicabo repudiandae.\nRecusandae sequi molestiae.", new DateTime(2023, 4, 15, 11, 16, 23, 234, DateTimeKind.Unspecified).AddTicks(9432), "Vel rerum minima aperiam iste dolorum qui qui quos nostrum.", null, 36L },
                    { 79L, 172L, "Totam atque optio laudantium et sit.\nSit omnis perferendis.\nOccaecati fugiat nam quo alias ratione dolor ut ut dolor.", new DateTime(2023, 5, 11, 10, 45, 56, 447, DateTimeKind.Unspecified).AddTicks(8342), "Et at quia necessitatibus delectus.", new DateTime(2023, 6, 19, 21, 8, 27, 519, DateTimeKind.Unspecified).AddTicks(9527), 1L },
                    { 80L, 122L, "Veniam repudiandae beatae aspernatur delectus quis vero eum odio.\nBlanditiis ut vitae vitae dicta pariatur et dolore veniam illo.\nEt laborum est nostrum.\nQuia ut quia.\nAut dolores nihil eos quisquam ut aspernatur.\nConsequatur aut iste recusandae consectetur aut porro expedita aut.", new DateTime(2023, 6, 16, 9, 45, 47, 144, DateTimeKind.Unspecified).AddTicks(9704), "Culpa totam esse. Nobis eius corporis iure aut vero velit tenetur quaerat et. Voluptatem non modi ea. Placeat repellat labore voluptatum dolores ut officiis qui ut. Modi magnam magni vitae asperiores laboriosam quisquam et. Quas non quo repellat.", new DateTime(2023, 7, 31, 22, 21, 24, 967, DateTimeKind.Unspecified).AddTicks(9926), 6L },
                    { 81L, 68L, "Distinctio error sint nostrum.\nTempora itaque velit ducimus nisi sunt esse.\nQuidem rerum qui quia.", new DateTime(2020, 1, 31, 21, 43, 6, 775, DateTimeKind.Unspecified).AddTicks(2111), "Qui ipsa vero et eaque repellat sunt. Necessitatibus natus omnis perferendis sunt molestias error nobis non. Esse aut dolor iure qui neque ea exercitationem eum. Distinctio dolor et blanditiis rerum quibusdam in. Impedit repellat aliquam qui dolores quasi occaecati. Temporibus iste voluptas distinctio quasi quaerat est eum blanditiis quisquam.", new DateTime(2022, 7, 24, 15, 40, 16, 560, DateTimeKind.Unspecified).AddTicks(549), 33L },
                    { 82L, 34L, "Quia aut veritatis explicabo magni omnis odit.\nReiciendis numquam sed eum aut quo accusamus quo quis et.", new DateTime(2023, 8, 22, 9, 54, 54, 24, DateTimeKind.Unspecified).AddTicks(951), "Dignissimos in quia fugit.", new DateTime(2023, 8, 22, 10, 39, 6, 422, DateTimeKind.Unspecified).AddTicks(5081), 40L },
                    { 83L, 160L, "et", new DateTime(2023, 4, 9, 18, 57, 37, 498, DateTimeKind.Unspecified).AddTicks(5723), "Eos velit eum optio molestiae et iste.\nVeniam reprehenderit nulla.\nMaxime aut totam voluptatum voluptas omnis nostrum alias.\nConsequatur itaque rerum aspernatur.", new DateTime(2023, 7, 5, 16, 38, 59, 168, DateTimeKind.Unspecified).AddTicks(8878), 39L },
                    { 84L, 96L, "Quam at praesentium consequatur cum quis. Laborum voluptatem sed dolor ut autem. Debitis deserunt eum nobis libero eius.", new DateTime(2022, 9, 26, 22, 30, 58, 700, DateTimeKind.Unspecified).AddTicks(1508), "Ab voluptatum rerum animi totam enim.", new DateTime(2023, 4, 16, 6, 14, 2, 423, DateTimeKind.Unspecified).AddTicks(1901), 21L },
                    { 85L, 131L, "quia", new DateTime(2023, 3, 8, 20, 28, 10, 289, DateTimeKind.Unspecified).AddTicks(4470), "aut", new DateTime(2023, 8, 6, 21, 20, 15, 537, DateTimeKind.Unspecified).AddTicks(8594), 19L },
                    { 86L, 70L, "Soluta quisquam ut et. Vel veniam fugit aut alias repellat. Voluptatibus quia architecto et sed aspernatur voluptas et ipsum. Neque aspernatur fuga qui commodi aperiam. Ipsam voluptatem id commodi voluptatem.", new DateTime(2021, 11, 24, 1, 9, 51, 167, DateTimeKind.Unspecified).AddTicks(7429), "debitis", null, 38L },
                    { 87L, 97L, "Non quia ducimus.", new DateTime(2023, 5, 23, 19, 51, 23, 946, DateTimeKind.Unspecified).AddTicks(5421), "nisi", new DateTime(2023, 6, 19, 7, 36, 11, 38, DateTimeKind.Unspecified).AddTicks(5638), 24L },
                    { 88L, 73L, "Natus odio exercitationem accusamus. Magnam fugiat quos reiciendis qui odio. Sint velit reiciendis assumenda eaque quia assumenda tempore. Tenetur est dolor iste voluptatem blanditiis. Non minus et rem sit aut ipsam corrupti illo. Eius repellendus distinctio occaecati.", new DateTime(2023, 1, 7, 17, 16, 36, 98, DateTimeKind.Unspecified).AddTicks(6133), "molestiae", new DateTime(2023, 4, 3, 0, 56, 52, 511, DateTimeKind.Unspecified).AddTicks(805), 1L },
                    { 89L, 197L, "magnam", new DateTime(2022, 1, 14, 1, 52, 28, 2, DateTimeKind.Unspecified).AddTicks(6585), "Autem id nam fugit enim. Autem ipsa sapiente et assumenda delectus. Earum aut quos quo nulla.", new DateTime(2023, 7, 3, 7, 32, 35, 319, DateTimeKind.Unspecified).AddTicks(479), 39L },
                    { 90L, 61L, "Mollitia vitae quis molestias. Dolorem aliquid sit dolor impedit qui. Aut autem asperiores dolorum natus doloribus nesciunt eaque doloremque deleniti.", new DateTime(2023, 7, 28, 17, 49, 33, 563, DateTimeKind.Unspecified).AddTicks(2643), "Nemo voluptate pariatur.", new DateTime(2023, 8, 20, 0, 16, 32, 972, DateTimeKind.Unspecified).AddTicks(3661), 6L },
                    { 91L, 43L, "Impedit facere qui voluptas earum et ipsam voluptas ipsum. Est sapiente neque doloribus reprehenderit aliquid minus est. Dolorem sed officia ad.", new DateTime(2023, 2, 14, 3, 9, 51, 321, DateTimeKind.Unspecified).AddTicks(1243), "quasi", new DateTime(2023, 4, 11, 16, 55, 3, 98, DateTimeKind.Unspecified).AddTicks(349), 40L },
                    { 92L, 135L, "asperiores", new DateTime(2023, 8, 14, 20, 1, 56, 826, DateTimeKind.Unspecified).AddTicks(166), "Accusamus aut modi numquam nihil. Porro voluptatem nisi provident dignissimos nobis ratione repudiandae. Voluptatem magni vel tenetur quo quia deleniti. Eligendi delectus ea animi. Ut libero dolor velit velit impedit. Et molestias rem impedit qui in enim.", null, 38L },
                    { 93L, 109L, "Officiis sit consequatur magnam neque reprehenderit eos provident. Sit fugit magnam aut cum. Dolore corrupti odio reprehenderit veniam facilis expedita odit et. Pariatur unde in et tempore. Quibusdam optio tempore autem animi. Rerum unde magni eum reiciendis modi.", new DateTime(2023, 8, 12, 2, 34, 37, 96, DateTimeKind.Unspecified).AddTicks(666), "Exercitationem aliquam sint vel.\nFuga velit atque doloremque numquam architecto enim earum enim.\nVeniam laudantium culpa cum ipsam omnis ullam aut sequi.", new DateTime(2023, 8, 14, 22, 22, 31, 884, DateTimeKind.Unspecified).AddTicks(5243), 35L },
                    { 94L, 126L, "Neque nesciunt iste nostrum expedita nobis.\nPorro iure non facilis culpa cupiditate beatae consequatur ut.\nAspernatur excepturi rerum aut sit.\nRepellat autem voluptas cupiditate ut qui ratione.", new DateTime(2023, 4, 14, 0, 34, 14, 776, DateTimeKind.Unspecified).AddTicks(3654), "Expedita ratione dolor possimus omnis fuga omnis quo sapiente.\nNisi expedita corporis et dolor sed expedita aut et sequi.\nVoluptate qui error iste sint saepe neque animi maiores.", new DateTime(2023, 7, 27, 20, 48, 6, 546, DateTimeKind.Unspecified).AddTicks(2675), 10L }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "Output", "SubmittedAt", "UserId" },
                values: new object[,]
                {
                    { 95L, 169L, "Id rem minus molestiae ab sunt. Laboriosam architecto dolores maxime qui. Quia dolor quia.", new DateTime(2023, 8, 13, 0, 2, 48, 417, DateTimeKind.Unspecified).AddTicks(1955), "Eius velit quidem. Et fugit aut est porro autem et omnis. Ipsam dolor labore sit nihil accusamus ea illo enim.", new DateTime(2023, 8, 17, 3, 42, 34, 134, DateTimeKind.Unspecified).AddTicks(6329), 9L },
                    { 96L, 175L, "Architecto illum dolorum non consequatur veniam aut quod sed. Architecto in sed delectus sunt quis eveniet velit saepe. Qui repellendus fugit rerum rerum voluptates voluptatibus temporibus ut adipisci.", new DateTime(2023, 5, 22, 15, 9, 54, 898, DateTimeKind.Unspecified).AddTicks(2553), "inventore", new DateTime(2023, 7, 24, 13, 48, 16, 964, DateTimeKind.Unspecified).AddTicks(951), 26L },
                    { 97L, 117L, "Eos officia nemo illo quis expedita est magnam enim reprehenderit. Praesentium voluptatem magni qui nostrum nihil minus. Aspernatur corporis enim assumenda et sunt perferendis est libero libero. Incidunt reiciendis aut repellat quibusdam eos voluptatum veritatis animi nostrum.", new DateTime(2023, 2, 18, 20, 41, 0, 26, DateTimeKind.Unspecified).AddTicks(2526), "qui", null, 21L },
                    { 98L, 27L, "Consequatur reiciendis voluptate recusandae numquam deserunt.", new DateTime(2023, 1, 5, 9, 6, 16, 857, DateTimeKind.Unspecified).AddTicks(3087), "Deleniti enim aut odit qui vel. Perspiciatis ex voluptatem sit. Vel facilis magni est sapiente sunt temporibus. Dolore temporibus aut ad. Distinctio repudiandae qui quae. Ea aut ipsa sunt culpa voluptas velit doloremque ratione eos.", new DateTime(2023, 1, 9, 8, 58, 12, 121, DateTimeKind.Unspecified).AddTicks(839), 17L },
                    { 99L, 194L, "Ad dolore magnam sit eaque. Eos est ullam id repudiandae et totam laboriosam. Laudantium et ea quos est veritatis.", new DateTime(2023, 8, 20, 21, 35, 59, 127, DateTimeKind.Unspecified).AddTicks(8798), "Molestiae est assumenda sed commodi a aut dolore rem in. Et rerum iure recusandae velit tenetur necessitatibus. Aut fugit modi. Vitae harum sapiente in consequatur qui totam ad.", new DateTime(2023, 8, 22, 2, 2, 58, 682, DateTimeKind.Unspecified).AddTicks(407), 19L },
                    { 100L, 110L, "Laboriosam dolores nam ducimus saepe. Cumque dolorem incidunt nihil beatae assumenda quia est rem. Sed reiciendis nobis atque in iste ullam autem consequatur.", new DateTime(2023, 7, 11, 12, 5, 13, 645, DateTimeKind.Unspecified).AddTicks(4972), "Fugiat voluptatem autem.", new DateTime(2023, 8, 4, 8, 34, 32, 536, DateTimeKind.Unspecified).AddTicks(273), 22L },
                    { 101L, 82L, "Omnis dolor quis non eos ipsum.", new DateTime(2022, 12, 23, 19, 40, 17, 946, DateTimeKind.Unspecified).AddTicks(5284), "Optio aut optio dolores quas.", new DateTime(2023, 5, 2, 17, 44, 20, 824, DateTimeKind.Unspecified).AddTicks(7697), 16L },
                    { 102L, 182L, "Dignissimos officia quisquam et quas iusto officiis provident voluptas. Vitae nesciunt commodi molestiae velit in iste. Eum repudiandae quam nemo sed.", new DateTime(2021, 8, 21, 15, 26, 56, 727, DateTimeKind.Unspecified).AddTicks(257), "Illum voluptate eos quis reprehenderit.", new DateTime(2022, 10, 18, 23, 38, 23, 715, DateTimeKind.Unspecified).AddTicks(4368), 26L },
                    { 103L, 103L, "error", new DateTime(2023, 8, 13, 23, 6, 54, 918, DateTimeKind.Unspecified).AddTicks(5847), "harum", new DateTime(2023, 8, 21, 14, 40, 59, 825, DateTimeKind.Unspecified).AddTicks(5920), 30L },
                    { 104L, 162L, "Sapiente non omnis voluptatibus.\nIn minima qui dolores iure ut provident est.\nMinus neque ducimus.", new DateTime(2022, 4, 12, 8, 32, 35, 558, DateTimeKind.Unspecified).AddTicks(5263), "Repellendus explicabo consequatur. Quos et est in culpa qui quo possimus repellat. Ducimus non deserunt velit ut molestias quo consequuntur.", new DateTime(2023, 1, 2, 13, 51, 35, 23, DateTimeKind.Unspecified).AddTicks(2566), 8L },
                    { 105L, 76L, "Voluptate sint dignissimos ullam aliquid et quia earum.\nEaque placeat aut accusamus soluta tempore.\nProvident perferendis culpa aut similique aperiam consequatur.\nSed expedita saepe velit fuga a nobis earum.\nUt quae velit ipsam cumque quia culpa.", new DateTime(2022, 6, 5, 6, 1, 8, 73, DateTimeKind.Unspecified).AddTicks(5981), "Non omnis a quaerat sint dolores fuga alias non consequuntur.\nAut quis molestias omnis aspernatur eligendi ut consequatur voluptatem provident.\nConsequatur quaerat ut quidem voluptatum.\nEum est alias beatae sint.\nArchitecto ut et.", new DateTime(2023, 8, 22, 8, 28, 43, 689, DateTimeKind.Unspecified).AddTicks(2242), 17L },
                    { 106L, 107L, "Autem tempore est sed id et est quisquam. Iure culpa tenetur optio quis. Expedita ut ipsum labore consequuntur eveniet consectetur quaerat iusto officiis. Exercitationem deserunt itaque voluptatem in deserunt asperiores et dolor. Temporibus id modi inventore reprehenderit ea qui est quos hic. Fugit dolores velit est repellendus sint est.", new DateTime(2022, 7, 15, 1, 5, 5, 502, DateTimeKind.Unspecified).AddTicks(7646), "Aliquam nam placeat suscipit perferendis dolor.\nVel maiores a.\nOdit et accusamus.\nRerum sit minus ut est provident earum.\nEnim dolor aspernatur non libero autem beatae nemo officiis in.", new DateTime(2023, 1, 22, 11, 20, 5, 316, DateTimeKind.Unspecified).AddTicks(3610), 22L },
                    { 107L, 93L, "Error repudiandae molestias doloribus laudantium consequatur sunt.", new DateTime(2021, 4, 4, 12, 39, 57, 706, DateTimeKind.Unspecified).AddTicks(1992), "Suscipit tenetur quia asperiores rerum ipsam id odio nesciunt.\nAliquam ut voluptatem voluptates et quia non autem suscipit sed.", null, 19L },
                    { 108L, 180L, "Nulla ipsum cupiditate maiores et tenetur maxime ex libero qui.\nEius suscipit aperiam error laudantium voluptatem eius saepe.\nLaboriosam aliquam voluptatum velit quia quas commodi.\nMollitia et hic enim aut aut deserunt maiores iure.", new DateTime(2023, 7, 20, 7, 2, 3, 262, DateTimeKind.Unspecified).AddTicks(4878), "Et neque ullam ut rerum porro sed velit.", new DateTime(2023, 8, 10, 19, 58, 47, 663, DateTimeKind.Unspecified).AddTicks(181), 18L },
                    { 109L, 33L, "Officia eligendi voluptas dolor quia officia officiis.\nNihil quidem iure suscipit provident odio in architecto ab.\nDolorem iusto ipsa porro provident atque.\nNemo molestiae aut.\nId quia unde quae quia consequatur nostrum veritatis.\nMollitia deleniti nostrum ut fugit enim.", new DateTime(2023, 3, 19, 19, 44, 27, 59, DateTimeKind.Unspecified).AddTicks(1259), "Nam alias quia qui deserunt sit saepe in iste.", new DateTime(2023, 7, 6, 3, 22, 52, 548, DateTimeKind.Unspecified).AddTicks(3927), 35L },
                    { 110L, 36L, "Qui excepturi voluptas.\nQuia iusto veniam perferendis natus.\nUt qui quas id modi sequi corporis rerum molestiae et.\nPerferendis autem et facilis et dolores magni numquam quibusdam dolor.\nReprehenderit deleniti nostrum quibusdam atque quos laboriosam similique eaque.\nDoloremque et unde quaerat illo ut itaque est reprehenderit.", new DateTime(2023, 5, 22, 0, 38, 30, 215, DateTimeKind.Unspecified).AddTicks(1358), "id", new DateTime(2023, 7, 27, 14, 50, 14, 49, DateTimeKind.Unspecified).AddTicks(9903), 10L },
                    { 111L, 134L, "Voluptatem quibusdam omnis sed provident.\nVoluptatem enim nihil libero consequatur ullam ea laborum.\nVoluptatibus commodi odit.\nAnimi et consectetur cupiditate voluptate id.\nRatione nemo atque.", new DateTime(2022, 7, 19, 6, 51, 35, 707, DateTimeKind.Unspecified).AddTicks(8633), "ullam", null, 35L },
                    { 112L, 76L, "Perferendis molestias doloremque a sint.", new DateTime(2023, 3, 1, 20, 34, 12, 381, DateTimeKind.Unspecified).AddTicks(5369), "culpa", new DateTime(2023, 3, 19, 2, 51, 30, 956, DateTimeKind.Unspecified).AddTicks(7827), 36L },
                    { 113L, 44L, "Aliquam architecto iusto.", new DateTime(2023, 3, 20, 7, 38, 52, 799, DateTimeKind.Unspecified).AddTicks(5851), "Sint blanditiis animi porro eum. Quis a et explicabo est. Quo ab sunt. Similique voluptates cum quas dolorem est optio excepturi quia expedita.", new DateTime(2023, 6, 20, 20, 33, 55, 719, DateTimeKind.Unspecified).AddTicks(4470), 30L },
                    { 114L, 156L, "Quibusdam natus voluptates ipsam consequuntur ipsum est fuga dolore quis. Doloremque fugit corporis doloribus autem molestias cupiditate veniam assumenda provident. Possimus sunt molestias ipsum et sequi ea aperiam voluptatem. Sit et aliquam provident ut magnam dolor quas at. Voluptatum velit id quia.", new DateTime(2023, 7, 7, 20, 1, 25, 562, DateTimeKind.Unspecified).AddTicks(5559), "Eius sunt nemo facilis.\nVel consequatur aut illum aut tenetur iste dolores voluptatem non.\nAut cumque enim.\nPraesentium voluptate aliquam.", new DateTime(2023, 7, 23, 1, 17, 19, 264, DateTimeKind.Unspecified).AddTicks(7586), 30L },
                    { 115L, 66L, "Suscipit harum amet non qui rerum.", new DateTime(2023, 5, 31, 19, 14, 43, 282, DateTimeKind.Unspecified).AddTicks(428), "Nihil magnam est voluptatem dignissimos. Rerum ea earum voluptatem iure dolores rem incidunt vel. Vel fugiat error et illo ab est praesentium sit.", new DateTime(2023, 7, 17, 21, 24, 47, 31, DateTimeKind.Unspecified).AddTicks(1819), 19L },
                    { 116L, 117L, "Tenetur laboriosam rerum.", new DateTime(2022, 2, 19, 16, 51, 54, 179, DateTimeKind.Unspecified).AddTicks(9054), "Consequatur sint eum omnis reprehenderit. A doloribus eos. Consequatur neque voluptas fugit reprehenderit nostrum. Autem natus voluptatem qui aut. Culpa autem illum repellat ipsam ut dolores.", null, 14L },
                    { 117L, 168L, "Expedita quidem quas nisi laborum molestiae natus.\nAutem sequi soluta nam doloremque excepturi.", new DateTime(2023, 4, 21, 18, 40, 7, 810, DateTimeKind.Unspecified).AddTicks(4310), "rem", new DateTime(2023, 5, 22, 16, 24, 31, 333, DateTimeKind.Unspecified).AddTicks(3273), 18L },
                    { 118L, 70L, "Ducimus est illo tempora magni assumenda dicta quod.\nAut porro molestiae omnis voluptatum.", new DateTime(2022, 10, 28, 2, 52, 12, 962, DateTimeKind.Unspecified).AddTicks(5519), "Sit iure accusantium nulla quidem debitis aut.", new DateTime(2022, 12, 4, 5, 12, 42, 257, DateTimeKind.Unspecified).AddTicks(7643), 34L },
                    { 119L, 63L, "repellendus", new DateTime(2022, 12, 31, 21, 47, 36, 387, DateTimeKind.Unspecified).AddTicks(9126), "Vero saepe rerum accusamus sit ad accusantium.\nItaque voluptate tempora.", new DateTime(2023, 8, 13, 3, 3, 7, 252, DateTimeKind.Unspecified).AddTicks(4570), 32L },
                    { 120L, 27L, "Perspiciatis quia aut similique fuga. Debitis similique facilis eveniet. Totam veritatis harum laboriosam ut qui deleniti.", new DateTime(2023, 2, 21, 0, 53, 40, 976, DateTimeKind.Unspecified).AddTicks(9569), "Alias dolor optio.\nDebitis ipsa eaque pariatur dolorem porro.\nOmnis quis ut vel pariatur quia.\nEst blanditiis nihil vel dolorem.\nEarum neque nesciunt ut consequatur autem.", new DateTime(2023, 4, 9, 8, 46, 43, 262, DateTimeKind.Unspecified).AddTicks(615), 40L },
                    { 121L, 11L, "Aspernatur maxime dolor voluptas quisquam.", new DateTime(2023, 2, 10, 11, 2, 4, 889, DateTimeKind.Unspecified).AddTicks(8750), "Fugit repudiandae eligendi sunt.", null, 39L },
                    { 122L, 60L, "voluptate", new DateTime(2022, 10, 6, 8, 56, 40, 997, DateTimeKind.Unspecified).AddTicks(7635), "Non porro aut et eaque.\nQuisquam voluptatem aut aut asperiores hic ut modi sint.\nEt maiores ut maiores enim accusantium.\nQuasi aut possimus sed omnis beatae.\nAt molestiae vel ipsa sunt.", new DateTime(2023, 5, 13, 2, 10, 55, 639, DateTimeKind.Unspecified).AddTicks(7728), 2L },
                    { 123L, 38L, "Et culpa aspernatur aut excepturi aperiam cumque qui et.", new DateTime(2023, 1, 23, 5, 15, 3, 772, DateTimeKind.Unspecified).AddTicks(4592), "Et a quas dolore vel inventore veniam tempore.", null, 38L },
                    { 124L, 143L, "et", new DateTime(2023, 4, 26, 9, 38, 36, 6, DateTimeKind.Unspecified).AddTicks(2892), "Voluptas corporis numquam non.\nSed necessitatibus ut repellat et dicta.\nQuos eligendi molestiae.\nAmet vitae et dolor.", new DateTime(2023, 4, 28, 7, 26, 45, 699, DateTimeKind.Unspecified).AddTicks(4482), 20L },
                    { 125L, 26L, "Doloremque officiis perferendis vel non.\nOmnis quia et aspernatur dolores iure.\nVoluptas veritatis eaque qui accusamus.", new DateTime(2023, 5, 27, 9, 6, 28, 750, DateTimeKind.Unspecified).AddTicks(4496), "Vero tenetur esse officia impedit eligendi consequuntur ut velit.\nAutem voluptates sunt.", new DateTime(2023, 7, 28, 5, 38, 44, 847, DateTimeKind.Unspecified).AddTicks(3317), 38L },
                    { 126L, 195L, "sint", new DateTime(2023, 2, 20, 19, 22, 26, 514, DateTimeKind.Unspecified).AddTicks(3730), "Dicta officia soluta nihil rerum et commodi et.", new DateTime(2023, 5, 21, 1, 37, 20, 458, DateTimeKind.Unspecified).AddTicks(3580), 26L },
                    { 127L, 20L, "Et quisquam est eius ullam dicta cumque voluptatum repellendus. Recusandae consequatur debitis alias et dicta cupiditate ratione et eum. Veniam ab voluptatum ut assumenda consequatur dolorem impedit vitae assumenda. Et repudiandae consequatur ea. Dicta velit repellat rerum quia.", new DateTime(2022, 5, 24, 14, 14, 2, 685, DateTimeKind.Unspecified).AddTicks(6689), "Omnis omnis facilis ex fugit sapiente doloremque illo.\nRerum numquam libero quia soluta provident porro debitis voluptas.\nDolores qui sit delectus harum aliquam illum iusto.\nAccusamus earum cumque rerum enim possimus doloribus eius.\nTotam mollitia quia quod sequi vero doloremque voluptatem.", new DateTime(2023, 6, 28, 12, 34, 5, 907, DateTimeKind.Unspecified).AddTicks(5949), 28L },
                    { 128L, 74L, "odio", new DateTime(2022, 4, 12, 3, 29, 39, 299, DateTimeKind.Unspecified).AddTicks(4568), "Quis qui aut aspernatur exercitationem non exercitationem amet eum amet. Ea esse eligendi enim asperiores velit ipsum. Reprehenderit in quia recusandae atque similique est. Vero qui recusandae. Cumque cumque assumenda et harum.", new DateTime(2023, 2, 1, 4, 12, 31, 592, DateTimeKind.Unspecified).AddTicks(7964), 29L },
                    { 129L, 141L, "In voluptas soluta porro error nostrum mollitia enim commodi. Velit quae est non. Sunt et iusto animi saepe molestiae officiis.", new DateTime(2023, 5, 30, 5, 27, 55, 876, DateTimeKind.Unspecified).AddTicks(4919), "Soluta minima ipsa.\nMaiores rerum est exercitationem explicabo et labore ipsa enim.\nExercitationem suscipit doloribus suscipit corrupti.\nSunt voluptatibus amet quo qui.\nAut consequatur magni.", new DateTime(2023, 6, 1, 20, 57, 32, 921, DateTimeKind.Unspecified).AddTicks(9880), 37L },
                    { 130L, 41L, "In vel ut aut placeat iste fuga. Non consectetur ratione corporis natus. Ut ipsum exercitationem quas optio sunt quia qui saepe itaque.", new DateTime(2023, 2, 19, 17, 34, 32, 400, DateTimeKind.Unspecified).AddTicks(4750), "dolorem", new DateTime(2023, 2, 21, 22, 30, 16, 286, DateTimeKind.Unspecified).AddTicks(2253), 8L },
                    { 131L, 55L, "Dolor deserunt a modi unde.", new DateTime(2023, 7, 22, 14, 55, 31, 457, DateTimeKind.Unspecified).AddTicks(6050), "Ut velit ut eos et sunt voluptatibus. Quas id qui amet. Aliquid aliquam atque voluptas similique qui eum quam est sint. Id sit dolor nisi culpa rerum maxime.", new DateTime(2023, 8, 12, 9, 4, 43, 348, DateTimeKind.Unspecified).AddTicks(7105), 28L },
                    { 132L, 199L, "Deserunt adipisci eaque et. Non eius commodi molestiae laboriosam. Saepe voluptatibus labore ipsa qui illum.", new DateTime(2023, 7, 20, 1, 37, 34, 953, DateTimeKind.Unspecified).AddTicks(4585), "Quae autem quidem.\nIste doloribus praesentium repudiandae reprehenderit est nemo.\nMagnam reprehenderit asperiores amet vel distinctio.", new DateTime(2023, 8, 11, 6, 40, 59, 207, DateTimeKind.Unspecified).AddTicks(9213), 10L },
                    { 133L, 47L, "odit", new DateTime(2023, 4, 23, 17, 28, 37, 460, DateTimeKind.Unspecified).AddTicks(8521), "voluptas", new DateTime(2023, 8, 4, 11, 35, 14, 417, DateTimeKind.Unspecified).AddTicks(2712), 18L },
                    { 134L, 10L, "Quibusdam iste praesentium molestias.\nEt nemo ut quod doloremque.\nFacilis officia dolore vero omnis sequi odio iure est iure.\nHarum rem quas modi voluptatem soluta.\nVoluptas quae rerum.\nVoluptatem adipisci et et voluptatem.", new DateTime(2023, 8, 13, 21, 47, 8, 161, DateTimeKind.Unspecified).AddTicks(6757), "Nobis laborum aut consequuntur. Dolor adipisci autem fuga eligendi dolorem. Nisi quod ex molestiae. Consequatur veritatis quae et delectus ut maiores explicabo laboriosam quia. Tempora quo alias. Praesentium qui nihil fugiat expedita nisi.", new DateTime(2023, 8, 16, 15, 47, 37, 605, DateTimeKind.Unspecified).AddTicks(377), 4L },
                    { 135L, 32L, "modi", new DateTime(2023, 8, 13, 5, 19, 52, 78, DateTimeKind.Unspecified).AddTicks(2097), "Voluptas nihil itaque ratione saepe rerum qui.\nImpedit doloribus aperiam et at qui voluptatem repellendus.\nLaboriosam omnis rerum aperiam occaecati ut rerum voluptates.\nEius quia officia.\nVoluptas molestiae eum et numquam occaecati ut at officia.\nVel maiores quia libero enim doloremque consectetur.", new DateTime(2023, 8, 17, 15, 7, 33, 248, DateTimeKind.Unspecified).AddTicks(6715), 28L },
                    { 136L, 12L, "Voluptatem iusto exercitationem labore debitis nam. Magni tenetur modi est nobis. Non et rerum.", new DateTime(2022, 11, 4, 5, 42, 31, 989, DateTimeKind.Unspecified).AddTicks(5769), "Dolores ab in mollitia. Debitis dolorem provident dolorem asperiores. Aut cupiditate quis enim saepe. Id et impedit. Omnis vero dolorem dignissimos nihil nisi dolores possimus non impedit. Magni porro debitis odio sint voluptas delectus.", new DateTime(2022, 12, 2, 7, 47, 31, 823, DateTimeKind.Unspecified).AddTicks(5443), 15L }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "Output", "SubmittedAt", "UserId" },
                values: new object[,]
                {
                    { 137L, 69L, "Enim maxime aperiam.\nMinima eius eaque minima culpa adipisci incidunt.\nFuga sed est omnis.", new DateTime(2023, 6, 21, 15, 11, 38, 143, DateTimeKind.Unspecified).AddTicks(4527), "Facere consequatur dolores officiis reiciendis et rerum aliquam.\nEst blanditiis quisquam excepturi odit dolorum aperiam reprehenderit.\nMaiores et in sunt iusto exercitationem et nobis.", new DateTime(2023, 7, 14, 13, 6, 44, 990, DateTimeKind.Unspecified).AddTicks(1992), 28L },
                    { 138L, 131L, "Reiciendis officia ad vel accusamus illo ullam rerum sapiente.", new DateTime(2023, 7, 14, 11, 46, 53, 145, DateTimeKind.Unspecified).AddTicks(8873), "Consequuntur rem quisquam quae consequatur et exercitationem.", new DateTime(2023, 7, 25, 12, 30, 43, 702, DateTimeKind.Unspecified).AddTicks(5159), 3L },
                    { 139L, 44L, "Et nostrum iste ullam.", new DateTime(2023, 2, 19, 6, 45, 58, 19, DateTimeKind.Unspecified).AddTicks(2383), "Quam repellat officiis sed sint.", new DateTime(2023, 6, 22, 8, 53, 33, 909, DateTimeKind.Unspecified).AddTicks(6002), 14L },
                    { 140L, 193L, "Non ipsum assumenda delectus rerum suscipit quia architecto. Aut doloribus optio non ut. Et voluptas maxime nisi provident aspernatur dicta. Animi amet provident expedita.", new DateTime(2023, 4, 24, 13, 15, 5, 964, DateTimeKind.Unspecified).AddTicks(3079), "Iure ut et nulla tenetur dignissimos accusantium vero voluptas.", new DateTime(2023, 5, 20, 6, 6, 25, 626, DateTimeKind.Unspecified).AddTicks(8971), 37L },
                    { 141L, 188L, "aut", new DateTime(2023, 4, 29, 6, 11, 7, 282, DateTimeKind.Unspecified).AddTicks(6835), "Id minima ut itaque ducimus et. Voluptas ipsa ipsum dolor aut cum ipsa. Voluptates quo molestiae at reiciendis. Officia eum odio fugiat vel molestiae. Delectus itaque quisquam ut rerum non cum quos corrupti doloremque.", new DateTime(2023, 7, 7, 23, 37, 41, 407, DateTimeKind.Unspecified).AddTicks(8290), 25L },
                    { 142L, 171L, "Quis veritatis repudiandae quia aliquid tenetur maiores est asperiores.\nSaepe laudantium odit.\nVoluptatum quisquam officiis.\nQui et dolorem.", new DateTime(2022, 8, 3, 14, 6, 26, 765, DateTimeKind.Unspecified).AddTicks(2466), "Aut nihil consequatur enim repudiandae.", new DateTime(2023, 4, 28, 0, 38, 30, 822, DateTimeKind.Unspecified).AddTicks(150), 26L },
                    { 143L, 93L, "explicabo", new DateTime(2022, 3, 30, 15, 43, 51, 259, DateTimeKind.Unspecified).AddTicks(2194), "Omnis officia voluptas commodi suscipit eius nam animi voluptatem molestiae.", new DateTime(2023, 4, 5, 21, 51, 9, 813, DateTimeKind.Unspecified).AddTicks(4890), 22L },
                    { 144L, 181L, "fugit", new DateTime(2023, 4, 22, 10, 45, 38, 189, DateTimeKind.Unspecified).AddTicks(4299), "Odit dolor perspiciatis facilis quasi reiciendis qui velit.\nSimilique architecto aut aut.\nFugit occaecati nobis et eum dolore cumque quia in.\nVoluptas qui consequatur quia est blanditiis omnis qui ad libero.\nReiciendis ipsa quia exercitationem ex beatae magnam in qui.\nSunt aliquid officiis laborum ea iste ab aut sunt.", new DateTime(2023, 7, 12, 2, 7, 55, 734, DateTimeKind.Unspecified).AddTicks(291), 40L },
                    { 145L, 197L, "Nobis quod autem.\nCumque dignissimos rerum eos voluptatum natus est voluptatum.\nDucimus consequatur rerum aperiam.\nAut dolores excepturi consequatur.\nQui officia cumque tempore delectus mollitia eum et tempore eum.\nSimilique expedita distinctio.", new DateTime(2022, 10, 13, 21, 53, 6, 180, DateTimeKind.Unspecified).AddTicks(2079), "accusamus", new DateTime(2023, 7, 17, 2, 12, 55, 81, DateTimeKind.Unspecified).AddTicks(8156), 37L },
                    { 146L, 175L, "In perspiciatis explicabo et fuga.", new DateTime(2023, 5, 4, 15, 21, 42, 939, DateTimeKind.Unspecified).AddTicks(9396), "Quas ipsam quo et sunt repellat est et perspiciatis.\nVoluptatem aspernatur sunt.\nAut voluptatem quis.\nQuia adipisci voluptatem ipsa corrupti voluptates ducimus quaerat corporis.", new DateTime(2023, 7, 27, 13, 35, 52, 483, DateTimeKind.Unspecified).AddTicks(3517), 6L },
                    { 147L, 11L, "unde", new DateTime(2023, 3, 15, 7, 34, 45, 435, DateTimeKind.Unspecified).AddTicks(8433), "Deserunt vitae officiis dolores veritatis molestiae autem tempore dolor.\nNostrum nam earum ratione.\nCommodi quia nobis laudantium eum non et fugiat optio.", new DateTime(2023, 5, 7, 3, 41, 30, 386, DateTimeKind.Unspecified).AddTicks(9003), 26L },
                    { 148L, 27L, "Et sit eligendi dolor qui inventore sunt. Eligendi ut enim. Aut laudantium non. Alias adipisci eum. Sunt nihil necessitatibus reiciendis magnam quia quos aut perspiciatis.", new DateTime(2023, 4, 21, 18, 16, 9, 932, DateTimeKind.Unspecified).AddTicks(5205), "Labore optio minus aperiam laborum qui reiciendis repudiandae ut deserunt.", new DateTime(2023, 6, 3, 10, 15, 37, 536, DateTimeKind.Unspecified).AddTicks(101), 15L },
                    { 149L, 56L, "Consequatur voluptas error.\nSoluta totam sed.", new DateTime(2023, 4, 5, 13, 15, 9, 302, DateTimeKind.Unspecified).AddTicks(2375), "Provident ad similique vitae sunt incidunt voluptatem aperiam.", new DateTime(2023, 5, 19, 12, 0, 44, 542, DateTimeKind.Unspecified).AddTicks(9099), 13L },
                    { 150L, 100L, "veniam", new DateTime(2023, 4, 13, 0, 7, 59, 470, DateTimeKind.Unspecified).AddTicks(7686), "Nostrum velit harum iusto quos enim rerum quia.\nAliquid consequuntur sit voluptatem.\nQuia id ducimus quidem optio excepturi dolor ut quis.", new DateTime(2023, 7, 21, 4, 23, 56, 783, DateTimeKind.Unspecified).AddTicks(3121), 13L },
                    { 151L, 96L, "Unde velit qui repudiandae et. Aspernatur dolor quaerat. Qui aspernatur ut et. Perferendis mollitia qui dolorem in.", new DateTime(2023, 3, 22, 6, 20, 43, 477, DateTimeKind.Unspecified).AddTicks(1994), "A iure dolorem voluptatem earum dicta natus architecto consequatur.\nQuasi culpa id sed sint recusandae et ut at.\nIpsam eum aut in voluptate adipisci.\nSequi nam voluptatibus minus quidem soluta.\nAssumenda non esse assumenda nesciunt optio optio quia.\nEnim ut voluptas.", new DateTime(2023, 4, 23, 13, 41, 22, 648, DateTimeKind.Unspecified).AddTicks(4852), 28L },
                    { 152L, 82L, "temporibus", new DateTime(2023, 2, 23, 0, 59, 6, 937, DateTimeKind.Unspecified).AddTicks(3363), "In culpa nihil voluptates maxime eligendi.", new DateTime(2023, 3, 12, 10, 4, 18, 144, DateTimeKind.Unspecified).AddTicks(8945), 17L },
                    { 153L, 27L, "Iure sint rerum consectetur nesciunt quod adipisci ex sed. Beatae et repudiandae rem blanditiis consequatur quas. Aliquam numquam consectetur rerum doloribus vero velit consequatur exercitationem. Facilis quia laudantium et maxime impedit nostrum eligendi. Aperiam harum soluta dolore modi. Molestiae fugiat dolore.", new DateTime(2023, 6, 23, 22, 15, 31, 220, DateTimeKind.Unspecified).AddTicks(3303), "In deserunt deserunt rerum minus in dignissimos cupiditate doloremque dolor. Ducimus atque quo commodi. Est facere sed. Omnis cupiditate totam non. Ut ut et et accusantium neque tempora. Possimus et culpa officiis temporibus.", new DateTime(2023, 7, 4, 1, 22, 12, 285, DateTimeKind.Unspecified).AddTicks(9330), 1L },
                    { 154L, 108L, "Ut omnis molestias soluta necessitatibus sit.", new DateTime(2023, 7, 2, 5, 19, 54, 555, DateTimeKind.Unspecified).AddTicks(1338), "Facere consectetur ab quia eum et voluptas.", new DateTime(2023, 7, 2, 9, 1, 39, 13, DateTimeKind.Unspecified).AddTicks(6465), 25L },
                    { 155L, 63L, "Facilis dolor neque eos quod quasi sit deserunt. Numquam qui laboriosam quia praesentium. Dolor voluptas libero et.", new DateTime(2022, 1, 16, 19, 43, 50, 848, DateTimeKind.Unspecified).AddTicks(8372), "Praesentium quos quisquam.\nNon enim impedit aliquam.\nIste ratione aperiam et eveniet qui quia facere.\nNihil mollitia repellendus voluptates expedita qui iste.", new DateTime(2022, 4, 20, 7, 35, 15, 770, DateTimeKind.Unspecified).AddTicks(438), 6L },
                    { 156L, 199L, "Nesciunt et quia libero eos quos.", new DateTime(2023, 8, 1, 5, 52, 58, 551, DateTimeKind.Unspecified).AddTicks(8015), "Aut sunt ipsum adipisci ipsum mollitia voluptas qui occaecati repudiandae.\nAmet ut incidunt unde.", new DateTime(2023, 8, 9, 14, 14, 16, 714, DateTimeKind.Unspecified).AddTicks(1305), 34L },
                    { 157L, 32L, "Est quis libero.", new DateTime(2023, 7, 30, 14, 21, 0, 243, DateTimeKind.Unspecified).AddTicks(3336), "Inventore sit quaerat sapiente ea porro est. Atque sed eum unde maiores. Rerum aperiam quia nostrum consectetur qui omnis fugiat ratione.", new DateTime(2023, 8, 10, 3, 23, 56, 519, DateTimeKind.Unspecified).AddTicks(3025), 33L },
                    { 158L, 83L, "Exercitationem ea possimus reprehenderit laboriosam et amet. Aliquam blanditiis non aliquid praesentium nemo quo perferendis animi. Expedita dolorem vel nobis voluptas autem. Aperiam praesentium consequatur iure. Vero qui id aut dicta. Tempora iusto corporis eum.", new DateTime(2023, 6, 21, 9, 38, 19, 700, DateTimeKind.Unspecified).AddTicks(5656), "Itaque error deleniti est quos voluptatem consequatur at praesentium incidunt. Qui laborum sint sapiente dolorem corporis adipisci vel. Doloribus mollitia omnis placeat ducimus modi. Repellendus neque sequi enim incidunt accusamus maxime ut. Maxime ut delectus quos.", new DateTime(2023, 7, 5, 6, 59, 54, 18, DateTimeKind.Unspecified).AddTicks(1413), 16L },
                    { 159L, 84L, "Ut enim repellat amet iste fugit hic nisi. Minus et enim tempore modi est nemo a corrupti. Et laborum minus nihil tenetur. Rerum perferendis culpa velit.", new DateTime(2023, 4, 17, 11, 57, 18, 835, DateTimeKind.Unspecified).AddTicks(7405), "Placeat aut sint saepe sequi vitae tempore.\nQuibusdam natus nihil aut odit eligendi qui nesciunt quisquam.\nVoluptatem qui deserunt.\nInventore sed nulla ipsa a tempore aut.\nQui ut accusamus nam cupiditate.\nNihil quibusdam sequi officiis illum occaecati quasi illo.", null, 13L },
                    { 160L, 74L, "Enim laudantium maiores. Repudiandae voluptatibus quae aut. Alias et molestiae. Nesciunt eos dignissimos dolorem quia qui. Itaque reprehenderit culpa architecto ut consequatur tempora et adipisci nihil. Dolore excepturi eaque asperiores voluptate soluta eum.", new DateTime(2021, 11, 3, 15, 40, 52, 837, DateTimeKind.Unspecified).AddTicks(4868), "Ipsa placeat illum et rerum quidem voluptatem minima. Consequatur rerum ea non dolorem aut. Voluptates animi et possimus et sint cumque qui voluptate sint. Neque minus voluptas repellendus suscipit minus. Eveniet rerum voluptas quia.", new DateTime(2022, 2, 12, 1, 17, 58, 158, DateTimeKind.Unspecified).AddTicks(3751), 36L },
                    { 161L, 119L, "expedita", new DateTime(2023, 1, 15, 1, 48, 8, 383, DateTimeKind.Unspecified).AddTicks(7676), "Fugit occaecati assumenda repellendus debitis delectus magni consequuntur ab. Praesentium quisquam quaerat doloribus perspiciatis facilis. Laborum libero facere enim labore quia nihil. Ut soluta laudantium dolores facilis quod error suscipit. Ab non asperiores alias blanditiis assumenda quae.", new DateTime(2023, 6, 28, 3, 44, 42, 829, DateTimeKind.Unspecified).AddTicks(9696), 31L },
                    { 162L, 199L, "dicta", new DateTime(2023, 7, 11, 23, 37, 43, 625, DateTimeKind.Unspecified).AddTicks(5540), "Quae quia dolorem mollitia officiis in.\nVitae laboriosam veniam.", new DateTime(2023, 8, 9, 11, 27, 22, 135, DateTimeKind.Unspecified).AddTicks(256), 27L },
                    { 163L, 168L, "Earum suscipit et qui sequi ut nihil et est.", new DateTime(2023, 7, 4, 5, 10, 35, 93, DateTimeKind.Unspecified).AddTicks(6139), "Et mollitia vero asperiores quia eligendi reprehenderit. Repudiandae quia vel non sint fugit atque. Omnis consectetur nam pariatur temporibus ex. Ad corrupti rerum necessitatibus. Quia explicabo modi dolorum aut. Voluptates est consequatur repellat tempora maiores molestias.", new DateTime(2023, 7, 30, 3, 11, 30, 748, DateTimeKind.Unspecified).AddTicks(9441), 36L },
                    { 164L, 156L, "Quia est praesentium fugit odit id.\nQui qui quas.", new DateTime(2023, 8, 2, 18, 53, 20, 745, DateTimeKind.Unspecified).AddTicks(4546), "Sed iure illum tenetur consectetur illum commodi quia quibusdam.", new DateTime(2023, 8, 16, 10, 37, 56, 700, DateTimeKind.Unspecified).AddTicks(4859), 23L },
                    { 165L, 199L, "Facere voluptas eius at at quibusdam. Voluptas molestias alias illum fugiat. Modi dolores itaque sit. Corrupti sit vel sit et ullam. Dolorum placeat rerum dolores iusto voluptas qui iste quasi.", new DateTime(2023, 7, 3, 0, 1, 43, 742, DateTimeKind.Unspecified).AddTicks(7394), "Hic ut officia. Amet soluta illum unde autem natus. Veniam voluptatem dolores a molestiae. Similique quam eos et voluptatem incidunt. Molestiae enim architecto.", new DateTime(2023, 7, 11, 14, 17, 44, 704, DateTimeKind.Unspecified).AddTicks(9950), 10L },
                    { 166L, 191L, "Sed eveniet sunt et. Dicta facere qui veritatis in distinctio rem itaque. Qui inventore et voluptate debitis voluptatem molestiae eaque ut. Repudiandae est in. Aut reprehenderit tenetur non sequi voluptatem voluptas. Non earum est est dolorem similique dolorem.", new DateTime(2023, 8, 18, 0, 12, 20, 631, DateTimeKind.Unspecified).AddTicks(5106), "Dolores et mollitia eius libero maiores debitis quisquam corporis.\nEx unde quo.\nMolestias sed aliquid.\nDignissimos magni voluptatem tempore delectus accusamus consequuntur iste.\nAut voluptatibus ea officiis necessitatibus aliquam fugit rem.", new DateTime(2023, 8, 21, 12, 50, 48, 982, DateTimeKind.Unspecified).AddTicks(3459), 6L },
                    { 167L, 5L, "Voluptas ipsum vel incidunt qui ut delectus numquam dolores quia.\nDeleniti laudantium totam qui sunt fugit ut omnis.\nRerum sed totam nostrum mollitia sunt commodi dolore.\nTenetur rem atque rerum quo velit.", new DateTime(2023, 1, 17, 14, 59, 55, 764, DateTimeKind.Unspecified).AddTicks(9648), "Voluptates quo sit qui vel.\nDolorum quidem aut cum tempora autem id fuga.\nOptio perferendis natus cumque sunt quidem nesciunt ut porro.\nPerspiciatis id voluptatem mollitia placeat enim doloremque nisi.\nIusto itaque quisquam aut dolorem temporibus libero a natus.", new DateTime(2023, 4, 3, 0, 52, 46, 535, DateTimeKind.Unspecified).AddTicks(9682), 28L },
                    { 168L, 32L, "Rerum repellat expedita est facere itaque corporis qui.\nEarum rem eaque quaerat ea adipisci qui vel amet.", new DateTime(2023, 8, 16, 9, 45, 24, 974, DateTimeKind.Unspecified).AddTicks(6893), "Minus repudiandae quam cum. Non eligendi architecto adipisci necessitatibus perspiciatis voluptate. Et aperiam nobis. Nobis repellat quam. Doloribus nulla velit et corporis veniam. Modi provident distinctio tempore numquam quos et vitae labore.", new DateTime(2023, 8, 20, 8, 25, 49, 332, DateTimeKind.Unspecified).AddTicks(3303), 1L },
                    { 169L, 112L, "Harum non omnis neque voluptas impedit quas itaque iste quibusdam.\nQuasi eius possimus exercitationem molestiae accusamus pariatur distinctio.", new DateTime(2023, 6, 13, 2, 20, 36, 68, DateTimeKind.Unspecified).AddTicks(8440), "officiis", new DateTime(2023, 8, 19, 13, 11, 56, 965, DateTimeKind.Unspecified).AddTicks(4145), 8L },
                    { 170L, 32L, "non", new DateTime(2023, 8, 16, 13, 25, 27, 845, DateTimeKind.Unspecified).AddTicks(7335), "Sunt ut temporibus enim nostrum sunt molestias nam praesentium.", new DateTime(2023, 8, 20, 17, 53, 31, 636, DateTimeKind.Unspecified).AddTicks(4641), 33L },
                    { 171L, 160L, "aut", new DateTime(2023, 7, 17, 0, 28, 47, 276, DateTimeKind.Unspecified).AddTicks(6225), "aliquam", new DateTime(2023, 8, 3, 10, 57, 40, 530, DateTimeKind.Unspecified).AddTicks(6309), 35L },
                    { 172L, 193L, "Est illo non ipsam et aut. Quod impedit qui minima rerum laudantium sed quam. Iure quo quasi eos.", new DateTime(2023, 7, 19, 22, 41, 50, 955, DateTimeKind.Unspecified).AddTicks(1230), "Earum molestiae quo libero rem architecto et.\nDelectus eius pariatur dignissimos blanditiis.\nQui non amet et sint maiores.\nQui quasi temporibus distinctio vel sed dicta qui facere.\nEt dolor corrupti ut necessitatibus omnis corporis consectetur libero sunt.\nIpsam qui laborum.", new DateTime(2023, 7, 28, 6, 47, 26, 904, DateTimeKind.Unspecified).AddTicks(7861), 31L },
                    { 173L, 83L, "Aut quibusdam non ea quae consequatur explicabo. Provident tempora non corporis rerum distinctio delectus. Aliquam et aut debitis.", new DateTime(2023, 6, 15, 14, 8, 11, 822, DateTimeKind.Unspecified).AddTicks(4830), "saepe", new DateTime(2023, 6, 27, 14, 4, 3, 372, DateTimeKind.Unspecified).AddTicks(1073), 30L },
                    { 174L, 22L, "Quo sint accusamus voluptas quis ut eligendi illo non.", new DateTime(2023, 3, 30, 10, 52, 24, 257, DateTimeKind.Unspecified).AddTicks(4203), "Magni iste et.\nNihil libero aspernatur.\nNatus doloribus adipisci consequatur adipisci consequatur doloribus veritatis quibusdam perferendis.", new DateTime(2023, 7, 17, 11, 3, 10, 913, DateTimeKind.Unspecified).AddTicks(8457), 35L },
                    { 175L, 3L, "Expedita omnis ad magni est cumque.\nDolor fugit suscipit itaque enim sint molestias.\nEsse tempora pariatur voluptatem eos est sint voluptates harum.", new DateTime(2023, 1, 23, 19, 38, 39, 488, DateTimeKind.Unspecified).AddTicks(5423), "Vero consectetur quam eum eos sunt omnis.", new DateTime(2023, 6, 25, 12, 36, 15, 526, DateTimeKind.Unspecified).AddTicks(3109), 39L },
                    { 176L, 53L, "Nihil esse aliquam et quia corrupti.", new DateTime(2022, 12, 23, 14, 33, 32, 152, DateTimeKind.Unspecified).AddTicks(4762), "commodi", new DateTime(2023, 7, 16, 12, 47, 12, 389, DateTimeKind.Unspecified).AddTicks(3874), 13L },
                    { 177L, 134L, "Id pariatur facilis officiis non voluptas reprehenderit commodi minus.", new DateTime(2022, 7, 15, 6, 12, 39, 946, DateTimeKind.Unspecified).AddTicks(8565), "Unde a dolores praesentium eligendi et qui qui odio.", new DateTime(2023, 2, 5, 7, 12, 24, 843, DateTimeKind.Unspecified).AddTicks(3074), 10L },
                    { 178L, 16L, "Rerum sequi eos sit optio minima.", new DateTime(2023, 6, 7, 20, 22, 52, 509, DateTimeKind.Unspecified).AddTicks(1482), "enim", new DateTime(2023, 6, 12, 0, 29, 46, 784, DateTimeKind.Unspecified).AddTicks(9827), 20L }
                });

            migrationBuilder.InsertData(
                table: "UserSolutions",
                columns: new[] { "Id", "ChallengeVersionId", "Code", "CreatedAt", "Output", "SubmittedAt", "UserId" },
                values: new object[,]
                {
                    { 179L, 70L, "ab", new DateTime(2022, 9, 20, 15, 42, 17, 244, DateTimeKind.Unspecified).AddTicks(1363), "Itaque eos accusamus voluptas similique.\nVoluptatem similique ipsa culpa architecto deserunt dolores aut.", new DateTime(2022, 11, 29, 3, 41, 11, 7, DateTimeKind.Unspecified).AddTicks(4709), 32L },
                    { 180L, 91L, "Enim consequatur modi ut.", new DateTime(2022, 4, 16, 16, 37, 33, 235, DateTimeKind.Unspecified).AddTicks(8208), "Dolorem velit sit qui beatae incidunt fugiat.\nEt ipsa officia qui facere.\nLabore error velit ut.", new DateTime(2022, 9, 15, 6, 24, 51, 777, DateTimeKind.Unspecified).AddTicks(5891), 38L },
                    { 181L, 197L, "Consequuntur libero voluptas facilis officiis tenetur rem minus. Harum in non excepturi ut ut. Quisquam praesentium et qui cumque voluptatem doloremque. Voluptatem quasi libero quibusdam. Eos rerum suscipit dolores ea.", new DateTime(2022, 4, 19, 8, 11, 45, 551, DateTimeKind.Unspecified).AddTicks(1957), "dolorem", new DateTime(2023, 2, 24, 13, 21, 41, 329, DateTimeKind.Unspecified).AddTicks(8773), 39L },
                    { 182L, 128L, "qui", new DateTime(2021, 11, 3, 16, 14, 39, 269, DateTimeKind.Unspecified).AddTicks(8863), "Iure ipsa sit facere officia.\nTempora et voluptatem.", new DateTime(2022, 12, 16, 0, 27, 9, 190, DateTimeKind.Unspecified).AddTicks(4418), 5L },
                    { 183L, 68L, "Totam ut placeat veritatis et sequi quibusdam aut.", new DateTime(2022, 8, 31, 16, 56, 34, 842, DateTimeKind.Unspecified).AddTicks(781), "Maiores illo soluta exercitationem nihil.\nFacere soluta et.\nExcepturi ad illum aut sunt laboriosam alias.\nOfficiis commodi quis aliquid repellat omnis amet.\nAut quo ut et vitae adipisci pariatur omnis et.", new DateTime(2022, 11, 15, 3, 54, 53, 407, DateTimeKind.Unspecified).AddTicks(1818), 35L },
                    { 184L, 200L, "Inventore a ut non tenetur eos vel quibusdam. Nobis autem sint harum illo magni odit. Voluptatibus repudiandae ducimus eum non ipsam nihil.", new DateTime(2023, 6, 18, 16, 31, 33, 665, DateTimeKind.Unspecified).AddTicks(4468), "accusamus", new DateTime(2023, 7, 9, 12, 19, 35, 775, DateTimeKind.Unspecified).AddTicks(7093), 29L },
                    { 185L, 90L, "Eligendi earum mollitia et non.", new DateTime(2023, 8, 17, 12, 56, 52, 780, DateTimeKind.Unspecified).AddTicks(9694), "reiciendis", new DateTime(2023, 8, 20, 6, 44, 19, 822, DateTimeKind.Unspecified).AddTicks(6453), 17L },
                    { 186L, 119L, "Non nihil est sit a tempore enim non rerum. Necessitatibus dicta nesciunt illum id magnam vel aut nam. Fugit sed sit harum fugiat recusandae accusantium itaque perferendis aut. Sit quaerat saepe temporibus atque tempore at ut culpa nihil. Tenetur vitae ipsa veritatis qui id.", new DateTime(2023, 6, 7, 13, 35, 54, 418, DateTimeKind.Unspecified).AddTicks(5613), "Deserunt adipisci libero optio cum cupiditate perferendis sit. Est suscipit excepturi. Necessitatibus impedit dolorem voluptatem doloremque quia culpa a laboriosam. Sint nihil culpa.", new DateTime(2023, 6, 16, 6, 47, 19, 323, DateTimeKind.Unspecified).AddTicks(6881), 5L },
                    { 187L, 119L, "facere", new DateTime(2022, 11, 26, 19, 33, 47, 387, DateTimeKind.Unspecified).AddTicks(5346), "ex", new DateTime(2022, 12, 26, 20, 46, 32, 413, DateTimeKind.Unspecified).AddTicks(4305), 40L },
                    { 188L, 33L, "Recusandae sunt eveniet sed adipisci sit ut.\nIn quisquam nobis quod aliquam odit sequi.\nExplicabo quam quam velit et tempora labore omnis qui provident.\nUt et sint neque et quis dolorem sequi.\nConsequatur laudantium voluptates quaerat sed iste.", new DateTime(2023, 4, 18, 16, 31, 30, 976, DateTimeKind.Unspecified).AddTicks(3709), "Commodi aut debitis. Quia sit ut ut quaerat laborum. Pariatur dolores iure distinctio laborum repellat quos distinctio. Voluptas blanditiis molestiae tenetur est sit harum.", new DateTime(2023, 6, 1, 20, 36, 34, 686, DateTimeKind.Unspecified).AddTicks(6222), 21L },
                    { 189L, 129L, "Molestiae voluptas quibusdam eos ut. Nobis accusantium numquam dignissimos in tempore architecto. Est sed et amet. Corporis et tempore et quo voluptatem eum accusantium architecto. Quaerat voluptas maiores odio voluptatem ut.", new DateTime(2023, 8, 7, 23, 22, 45, 961, DateTimeKind.Unspecified).AddTicks(7348), "Possimus itaque beatae et numquam excepturi ratione excepturi. Ut excepturi laboriosam veniam consectetur quae reprehenderit. Facere sint dicta voluptas sint deserunt.", new DateTime(2023, 8, 9, 17, 17, 57, 227, DateTimeKind.Unspecified).AddTicks(7999), 25L },
                    { 190L, 88L, "illo", new DateTime(2022, 3, 16, 8, 21, 41, 166, DateTimeKind.Unspecified).AddTicks(4459), "debitis", new DateTime(2023, 6, 20, 13, 58, 12, 569, DateTimeKind.Unspecified).AddTicks(5308), 14L },
                    { 191L, 188L, "Velit error excepturi dolorem omnis natus.", new DateTime(2023, 3, 7, 12, 17, 29, 420, DateTimeKind.Unspecified).AddTicks(7854), "reiciendis", new DateTime(2023, 6, 10, 0, 53, 2, 955, DateTimeKind.Unspecified).AddTicks(4331), 6L },
                    { 192L, 6L, "Labore nisi totam temporibus voluptatem reprehenderit iste minima quas. Harum alias nulla voluptas dolorem. Maiores exercitationem quas occaecati.", new DateTime(2023, 6, 29, 21, 19, 13, 764, DateTimeKind.Unspecified).AddTicks(5866), "Fugiat ab mollitia aut voluptatibus et amet quos.", new DateTime(2023, 8, 3, 20, 29, 46, 365, DateTimeKind.Unspecified).AddTicks(1729), 22L },
                    { 193L, 62L, "Adipisci sit aut incidunt quia quas molestiae quae.\nQuis est debitis in.\nNisi deserunt praesentium omnis.\nEsse adipisci nostrum velit ut explicabo aut.\nId dolor velit in harum velit ullam aut.", new DateTime(2023, 6, 25, 14, 28, 23, 556, DateTimeKind.Unspecified).AddTicks(9372), "Explicabo commodi voluptas consequuntur omnis nulla est.", new DateTime(2023, 7, 15, 20, 38, 30, 838, DateTimeKind.Unspecified).AddTicks(2897), 36L },
                    { 194L, 37L, "Accusantium nisi quos et est odit eos ipsam.\nVoluptatem voluptatem recusandae quibusdam eos totam minima vitae vero.", new DateTime(2022, 8, 17, 8, 55, 30, 164, DateTimeKind.Unspecified).AddTicks(6830), "consequatur", new DateTime(2023, 4, 12, 9, 18, 29, 204, DateTimeKind.Unspecified).AddTicks(7743), 8L },
                    { 195L, 45L, "Explicabo autem et voluptatem perferendis itaque est quasi aut. Debitis ea tenetur ab. Aut quis repudiandae vel quod voluptas quidem.", new DateTime(2023, 2, 13, 7, 51, 28, 219, DateTimeKind.Unspecified).AddTicks(5363), "Unde illum qui nulla illo pariatur praesentium aut dicta.", new DateTime(2023, 4, 30, 16, 18, 23, 355, DateTimeKind.Unspecified).AddTicks(6340), 15L },
                    { 196L, 82L, "In voluptatum rerum reiciendis cum velit dolores. Atque ex provident maiores minima rerum blanditiis aut. Id adipisci atque. Sit tenetur quod architecto voluptatem animi dolorem eos ea. Asperiores tenetur non dignissimos. Vel pariatur officiis voluptate.", new DateTime(2023, 6, 15, 12, 0, 26, 719, DateTimeKind.Unspecified).AddTicks(5891), "Similique dolores molestiae illum.", new DateTime(2023, 7, 5, 21, 22, 49, 659, DateTimeKind.Unspecified).AddTicks(5719), 33L },
                    { 197L, 89L, "Assumenda vel occaecati ratione et.\nConsequatur enim et vitae sit.\nAperiam et quas nostrum qui et minus.\nDolorem iste ducimus praesentium vel aliquam molestias adipisci inventore.\nAspernatur nam enim culpa odio veritatis facilis ut earum.", new DateTime(2023, 7, 5, 11, 37, 8, 847, DateTimeKind.Unspecified).AddTicks(7388), "Impedit corrupti enim.\nRepellendus quod ut voluptatum similique veritatis.\nItaque quia numquam recusandae veritatis sit et pariatur laborum.\nDistinctio maiores occaecati enim qui.", new DateTime(2023, 7, 29, 11, 3, 44, 477, DateTimeKind.Unspecified).AddTicks(4588), 26L },
                    { 198L, 30L, "amet", new DateTime(2023, 3, 19, 12, 29, 21, 865, DateTimeKind.Unspecified).AddTicks(5986), "nulla", new DateTime(2023, 5, 31, 19, 40, 32, 818, DateTimeKind.Unspecified).AddTicks(4595), 39L },
                    { 199L, 152L, "Enim aperiam rerum sit autem tempora consequuntur.", new DateTime(2022, 11, 17, 13, 8, 30, 105, DateTimeKind.Unspecified).AddTicks(6912), "Libero maiores possimus ab quas.\nFugit sit fugit praesentium dolorem architecto omnis error facere.\nConsequatur aut repudiandae.\nSit vitae quia libero iure hic harum itaque beatae in.\nEt deserunt perferendis unde sed.\nQuibusdam blanditiis ex enim dolores est.", new DateTime(2023, 2, 1, 9, 8, 36, 184, DateTimeKind.Unspecified).AddTicks(9327), 34L },
                    { 200L, 183L, "Sequi libero alias odit officia distinctio dicta distinctio omnis.\nDolor aliquam porro qui.\nDeleniti placeat perferendis omnis rerum sunt sint iste deserunt.", new DateTime(2023, 7, 11, 19, 45, 47, 72, DateTimeKind.Unspecified).AddTicks(1457), "et", new DateTime(2023, 8, 9, 9, 2, 45, 723, DateTimeKind.Unspecified).AddTicks(2689), 20L }
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
