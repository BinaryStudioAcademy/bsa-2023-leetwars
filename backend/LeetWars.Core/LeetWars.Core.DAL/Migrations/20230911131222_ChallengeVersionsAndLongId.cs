using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeetWars.Core.DAL.Migrations
{
    public partial class ChallengeVersionsAndLongId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Challenges_ChallengeLevels_LevelId",
                table: "Challenges");

            migrationBuilder.DropForeignKey(
                name: "FK_ChallengeVersionLanguageVersion_LanguageVersions_LanguageVersionId",
                table: "ChallengeVersionLanguageVersion");

            migrationBuilder.DropForeignKey(
                name: "FK_ChallengeVersions_Languages_LanguageId",
                table: "ChallengeVersions");

            migrationBuilder.DropForeignKey(
                name: "FK_LanguageVersions_Languages_LanguageId",
                table: "LanguageVersions");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_SubscriptionTypes_TypeId",
                table: "Subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_ChallengeVersions_ChallengeVersionId",
                table: "Tests");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLanguageLevels_Languages_LanguageId",
                table: "UserLanguageLevels");

            migrationBuilder.DropTable(
                name: "ChallengeTag");

            migrationBuilder.DropTable(
                name: "PreferredLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLanguageLevels",
                table: "UserLanguageLevels");

            migrationBuilder.DropIndex(
                name: "IX_Tests_ChallengeVersionId",
                table: "Tests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubscriptionTypes",
                table: "SubscriptionTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LanguageVersions",
                table: "LanguageVersions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Languages",
                table: "Languages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChallengeVersionLanguageVersion",
                table: "ChallengeVersionLanguageVersion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChallengeLevels",
                table: "ChallengeLevels");

            migrationBuilder.DeleteData(
                table: "ChallengeLevels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ChallengeLevels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ChallengeLevels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ChallengeLevels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LanguageVersions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LanguageVersions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LanguageVersions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LanguageVersions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LanguageVersions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LanguageVersions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LanguageVersions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LanguageVersions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LanguageVersions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SubscriptionTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubscriptionTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SubscriptionTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<long>(
                name: "LanguageId",
                table: "UserLanguageLevels",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Tags",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "SubscriptionTypes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "TypeId",
                table: "Subscriptions",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "LanguageId",
                table: "LanguageVersions",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "LanguageVersions",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Languages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "LanguageId",
                table: "ChallengeVersions",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ExampleTestCases",
                table: "ChallengeVersions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PreloadedCode",
                table: "ChallengeVersions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TestCases",
                table: "ChallengeVersions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<long>(
                name: "LanguageVersionId",
                table: "ChallengeVersionLanguageVersion",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "LevelId",
                table: "Challenges",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "ChallengeLevels",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLanguageLevel",
                table: "UserLanguageLevels",
                columns: new[] { "UserId", "LanguageId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tag",
                table: "Tags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubscriptionType",
                table: "SubscriptionTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LanguageVersion",
                table: "LanguageVersions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Language",
                table: "Languages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChallengesVersionLanguagesVersion",
                table: "ChallengeVersionLanguageVersion",
                columns: new[] { "ChallengeVersionId", "LanguageVersionId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChallengeLevel",
                table: "ChallengeLevels",
                column: "Id");

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

            migrationBuilder.InsertData(
                table: "ChallengeLevels",
                columns: new[] { "Id", "Name", "Reward", "SkillLevel" },
                values: new object[,]
                {
                    { 1L, "Easy", 10, 0 },
                    { 2L, "Medium", 20, 0 },
                    { 3L, "Difficult", 30, 0 },
                    { 4L, "Extreme", 40, 0 }
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

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 12, 6, 17, 58, 436, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 26, 7, 57, 54, 881, DateTimeKind.Utc).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 6, 4, 49, 4, 979, DateTimeKind.Utc).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 10, 9, 52, 24, 340, DateTimeKind.Utc).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 11, 47, 12, 409, DateTimeKind.Utc).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 31, 18, 32, 33, 368, DateTimeKind.Utc).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 17, 6, 55, 44, 83, DateTimeKind.Utc).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 12, 18, 59, 55, 993, DateTimeKind.Utc).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 24, 12, 40, 54, 942, DateTimeKind.Utc).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 28, 22, 52, 14, 807, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 7, 39, 18, 740, DateTimeKind.Utc).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 18, 9, 57, 39, 389, DateTimeKind.Utc).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 2, 15, 22, 47, 596, DateTimeKind.Utc).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 9, 1, 40, 47, 246, DateTimeKind.Utc).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 6, 6, 34, 22, 442, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 15, 23, 1, 9, 392, DateTimeKind.Utc).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 15, 22, 53, 9, 138, DateTimeKind.Utc).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 11, 9, 29, 23, 803, DateTimeKind.Utc).AddTicks(1814));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 20, 15, 5, 1, 58, DateTimeKind.Utc).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 5, 42, 49, 265, DateTimeKind.Utc).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 7, 15, 45, 44, 493, DateTimeKind.Utc).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 18, 9, 22, 708, DateTimeKind.Utc).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 6, 6, 56, 44, 609, DateTimeKind.Utc).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 25, 10, 25, 34, 891, DateTimeKind.Utc).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 0, 20, 14, 832, DateTimeKind.Utc).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 12, 2, 45, 334, DateTimeKind.Utc).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 3, 4, 13, 11, 705, DateTimeKind.Utc).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 16, 13, 57, 28, 459, DateTimeKind.Utc).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 10, 1, 40, 56, 389, DateTimeKind.Utc).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 6, 58, 19, 865, DateTimeKind.Utc).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 9, 21, 56, 56, 252, DateTimeKind.Utc).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 27, 21, 31, 29, 869, DateTimeKind.Utc).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 7, 20, 21, 7, 635, DateTimeKind.Utc).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 8, 12, 41, 43, 702, DateTimeKind.Utc).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 4, 11, 21, 16, 121, DateTimeKind.Utc).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 10, 6, 41, 48, 947, DateTimeKind.Utc).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 17, 6, 55, 6, 664, DateTimeKind.Utc).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 14, 22, 26, 24, 1, DateTimeKind.Utc).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 11, 13, 46, 37, 998, DateTimeKind.Utc).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 7, 22, 15, 47, 594, DateTimeKind.Utc).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 1, 49, 4, 818, DateTimeKind.Utc).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 31, 17, 34, 23, 105, DateTimeKind.Utc).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 18, 46, 32, 752, DateTimeKind.Utc).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 22, 1, 28, 7, 430, DateTimeKind.Utc).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 3, 9, 44, 12, 792, DateTimeKind.Utc).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 8, 13, 43, 11, 776, DateTimeKind.Utc).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 27, 13, 49, 28, 486, DateTimeKind.Utc).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 48L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 18, 13, 38, 44, 417, DateTimeKind.Utc).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 22, 13, 18, 771, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 6, 3, 39, 39, 446, DateTimeKind.Utc).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 14, 10, 16, 37, 394, DateTimeKind.Utc).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 24, 18, 13, 53, 852, DateTimeKind.Utc).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 22, 14, 0, 22, 228, DateTimeKind.Utc).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 3, 59, 1, 866, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 25, 8, 2, 12, 788, DateTimeKind.Utc).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 56L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 31, 13, 14, 42, 759, DateTimeKind.Utc).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 24, 15, 40, 16, 242, DateTimeKind.Utc).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 30, 2, 41, 15, 339, DateTimeKind.Utc).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 1, 0, 3, 19, 694, DateTimeKind.Utc).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 4, 20, 52, 54, 562, DateTimeKind.Utc).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 7, 16, 59, 19, 795, DateTimeKind.Utc).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 8, 4, 59, 46, 425, DateTimeKind.Utc).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 4, 6, 36, 58, 124, DateTimeKind.Utc).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 64L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 20, 48, 49, 2, DateTimeKind.Utc).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 2, 7, 2, 46, 940, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 26, 6, 3, 53, 99, DateTimeKind.Utc).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 30, 14, 40, 21, 876, DateTimeKind.Utc).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 26, 13, 58, 15, 649, DateTimeKind.Utc).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 7, 3, 30, 26, 8, DateTimeKind.Utc).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 24, 17, 45, 44, 490, DateTimeKind.Utc).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 21, 6, 39, 34, 791, DateTimeKind.Utc).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 72L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 16, 2, 22, 51, 130, DateTimeKind.Utc).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 8, 46, 24, 300, DateTimeKind.Utc).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 7, 9, 37, 30, 856, DateTimeKind.Utc).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 21, 19, 8, 43, 520, DateTimeKind.Utc).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 22, 16, 13, 50, 745, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 4, 23, 21, 4, 955, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 2, 19, 34, 56, 963, DateTimeKind.Utc).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 8, 10, 23, 36, 336, DateTimeKind.Utc).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 80L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 0, 43, 54, 944, DateTimeKind.Utc).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 18, 16, 53, 22, 770, DateTimeKind.Utc).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 18, 37, 22, 186, DateTimeKind.Utc).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 7, 5, 51, 37, 848, DateTimeKind.Utc).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 13, 21, 35, 16, 280, DateTimeKind.Utc).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 26, 12, 9, 35, 183, DateTimeKind.Utc).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 20, 6, 24, 16, 279, DateTimeKind.Utc).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 8, 1, 26, 56, 87, DateTimeKind.Utc).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 88L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 23, 21, 20, 12, 541, DateTimeKind.Utc).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 10, 9, 20, 55, 490, DateTimeKind.Utc).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 17, 2, 0, 58, 82, DateTimeKind.Utc).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 16, 14, 9, 50, 316, DateTimeKind.Utc).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 21, 16, 54, 12, 422, DateTimeKind.Utc).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 24, 20, 39, 2, 359, DateTimeKind.Utc).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 3, 9, 38, 2, 270, DateTimeKind.Utc).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 3, 49, 12, 841, DateTimeKind.Utc).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 96L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 23, 11, 57, 11, 249, DateTimeKind.Utc).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 30, 7, 50, 49, 993, DateTimeKind.Utc).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 9, 15, 19, 10, 514, DateTimeKind.Utc).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 26, 18, 6, 20, 59, DateTimeKind.Utc).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 11, 18, 20, 57, 89, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 19, 53, 16, 357, DateTimeKind.Utc).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 13, 13, 27, 30, 903, DateTimeKind.Utc).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 2, 0, 38, 51, 479, DateTimeKind.Utc).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 104L,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 16, 1, 22, 5, 175, DateTimeKind.Utc).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 18, 19, 16, 22, 824, DateTimeKind.Utc).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedAt",
                value: new DateTime(2020, 3, 26, 14, 1, 58, 652, DateTimeKind.Utc).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 1, 11, 40, 42, 854, DateTimeKind.Utc).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 9, 16, 51, 26, 185, DateTimeKind.Utc).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 16, 11, 16, 34, 385, DateTimeKind.Utc).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 20, 6, 9, 31, 170, DateTimeKind.Utc).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedAt",
                value: new DateTime(2020, 3, 17, 1, 15, 4, 264, DateTimeKind.Utc).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 112L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 25, 16, 57, 8, 608, DateTimeKind.Utc).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 20, 5, 43, 5, 772, DateTimeKind.Utc).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 16, 36, 33, 88, DateTimeKind.Utc).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 7, 16, 22, 46, 445, DateTimeKind.Utc).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 27, 16, 6, 6, 535, DateTimeKind.Utc).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 7, 8, 9, 17, 564, DateTimeKind.Utc).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 10, 42, 25, 734, DateTimeKind.Utc).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 9, 3, 6, 51, 125, DateTimeKind.Utc).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 120L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 24, 0, 39, 37, 249, DateTimeKind.Utc).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 19, 3, 15, 38, 326, DateTimeKind.Utc).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 2, 22, 5, 41, 838, DateTimeKind.Utc).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 18, 14, 2, 30, 778, DateTimeKind.Utc).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 4, 5, 58, 19, 915, DateTimeKind.Utc).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 26, 16, 50, 6, 626, DateTimeKind.Utc).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 28, 9, 35, 49, 4, DateTimeKind.Utc).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 1, 10, 49, 5, 782, DateTimeKind.Utc).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 128L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 23, 47, 34, 806, DateTimeKind.Utc).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 23, 43, 37, 149, DateTimeKind.Utc).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 11, 10, 55, 46, 414, DateTimeKind.Utc).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 7, 14, 13, 29, 346, DateTimeKind.Utc).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 16, 46, 26, 586, DateTimeKind.Utc).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 1, 22, 16, 10, 947, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 1, 14, 37, 17, 443, DateTimeKind.Utc).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 4, 9, 40, 1, 135, DateTimeKind.Utc).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 136L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 7, 39, 57, 247, DateTimeKind.Utc).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 9, 11, 50, 145, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 10, 3, 58, 0, 220, DateTimeKind.Utc).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 8, 10, 3, 22, 700, DateTimeKind.Utc).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 20, 56, 29, 163, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 10, 0, 59, 2, 510, DateTimeKind.Utc).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 22, 14, 27, 18, 146, DateTimeKind.Utc).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 17, 13, 24, 44, 922, DateTimeKind.Utc).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 144L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 22, 21, 46, 47, 469, DateTimeKind.Utc).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 30, 6, 56, 49, 794, DateTimeKind.Utc).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 14, 21, 39, 52, 412, DateTimeKind.Utc).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 4, 38, 6, 436, DateTimeKind.Utc).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 10, 23, 18, 53, 591, DateTimeKind.Utc).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 19, 17, 38, 55, 710, DateTimeKind.Utc).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 11, 7, 10, 22, 986, DateTimeKind.Utc).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 18, 16, 28, 818, DateTimeKind.Utc).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 152L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 2, 23, 2, 28, 101, DateTimeKind.Utc).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 30, 13, 38, 14, 899, DateTimeKind.Utc).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 23, 21, 42, 50, 511, DateTimeKind.Utc).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 27, 2, 12, 46, 335, DateTimeKind.Utc).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 10, 9, 22, 25, 857, DateTimeKind.Utc).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 29, 22, 50, 57, 434, DateTimeKind.Utc).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 29, 9, 10, 3, 754, DateTimeKind.Utc).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 1, 11, 38, 99, DateTimeKind.Utc).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 160L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 0, 24, 50, 928, DateTimeKind.Utc).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 4, 20, 6, 57, 896, DateTimeKind.Utc).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedAt",
                value: new DateTime(2021, 12, 19, 1, 27, 41, 776, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedAt",
                value: new DateTime(2022, 1, 9, 4, 28, 43, 318, DateTimeKind.Utc).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 8, 17, 14, 437, DateTimeKind.Utc).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 11, 36, 3, 349, DateTimeKind.Utc).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 18, 0, 49, 724, DateTimeKind.Utc).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 22, 21, 54, 50, 729, DateTimeKind.Utc).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 168L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 18, 11, 43, 976, DateTimeKind.Utc).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 2, 8, 28, 180, DateTimeKind.Utc).AddTicks(4489));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 16, 23, 35, 27, 705, DateTimeKind.Utc).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 15, 14, 46, 26, 423, DateTimeKind.Utc).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 26, 15, 48, 4, 722, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 5, 19, 12, 676, DateTimeKind.Utc).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 3, 12, 34, 1, 809, DateTimeKind.Utc).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 14, 14, 11, 108, DateTimeKind.Utc).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 176L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 11, 58, 35, 352, DateTimeKind.Utc).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 19, 12, 35, 338, DateTimeKind.Utc).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 22, 13, 11, 38, 251, DateTimeKind.Utc).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 28, 7, 53, 59, 174, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 10, 11, 35, 26, 553, DateTimeKind.Utc).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 22, 14, 338, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 16, 45, 18, 71, DateTimeKind.Utc).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 3, 39, 12, 121, DateTimeKind.Utc).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 184L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 10, 21, 17, 48, 726, DateTimeKind.Utc).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 21, 12, 56, 17, 324, DateTimeKind.Utc).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 14, 18, 29, 20, 733, DateTimeKind.Utc).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 4, 21, 0, 6, 278, DateTimeKind.Utc).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 19, 5, 19, 21, 780, DateTimeKind.Utc).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 31, 16, 23, 11, 976, DateTimeKind.Utc).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 4, 6, 15, 0, 93, DateTimeKind.Utc).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 26, 0, 3, 55, 761, DateTimeKind.Utc).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 192L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 7, 21, 21, 5, 96, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 3, 41, 4, 472, DateTimeKind.Utc).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 18, 14, 37, 34, 84, DateTimeKind.Utc).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 3, 34, 32, 884, DateTimeKind.Utc).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 3, 7, 38, 21, 635, DateTimeKind.Utc).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 25, 4, 51, 45, 717, DateTimeKind.Utc).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 12, 45, 54, 154, DateTimeKind.Utc).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 29, 11, 56, 38, 837, DateTimeKind.Utc).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 200L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 1, 56, 46, 987, DateTimeKind.Utc).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 12, 11, 28, 53, 396, DateTimeKind.Utc).AddTicks(3398), new DateTime(2023, 9, 9, 18, 43, 18, 84, DateTimeKind.Utc).AddTicks(9888) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 26, 22, 37, 9, 110, DateTimeKind.Utc).AddTicks(8791), new DateTime(2023, 7, 29, 8, 24, 54, 756, DateTimeKind.Utc).AddTicks(886) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 26, 22, 27, 20, 180, DateTimeKind.Utc).AddTicks(8452), new DateTime(2023, 9, 11, 0, 43, 28, 143, DateTimeKind.Utc).AddTicks(2023) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 10, 18, 9, 59, 41, 84, DateTimeKind.Utc).AddTicks(6133), new DateTime(2021, 6, 17, 23, 35, 38, 910, DateTimeKind.Utc).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 3, 16, 2, 29, 995, DateTimeKind.Utc).AddTicks(490), new DateTime(2023, 9, 5, 19, 12, 54, 331, DateTimeKind.Utc).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 19, 12, 5, 59, 50, DateTimeKind.Utc).AddTicks(6475), new DateTime(2023, 1, 23, 18, 28, 22, 766, DateTimeKind.Utc).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 25, 19, 56, 23, 201, DateTimeKind.Utc).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 9, 17, 30, 39, 59, DateTimeKind.Utc).AddTicks(3471), new DateTime(2023, 9, 11, 6, 51, 57, 693, DateTimeKind.Utc).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 14, 0, 20, 9, 838, DateTimeKind.Utc).AddTicks(8774), new DateTime(2023, 7, 22, 8, 49, 43, 474, DateTimeKind.Utc).AddTicks(7107) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 13, 11, 45, 6, 277, DateTimeKind.Utc).AddTicks(7657), new DateTime(2023, 7, 8, 5, 0, 26, 793, DateTimeKind.Utc).AddTicks(9363) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 12, 17, 57, 605, DateTimeKind.Utc).AddTicks(7283), new DateTime(2023, 6, 6, 13, 29, 42, 526, DateTimeKind.Utc).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 5, 7, 14, 47, 503, DateTimeKind.Utc).AddTicks(6086), new DateTime(2023, 9, 8, 13, 26, 0, 377, DateTimeKind.Utc).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 5, 5, 10, 8, 57, 690, DateTimeKind.Utc).AddTicks(2763), new DateTime(2023, 7, 2, 5, 32, 30, 891, DateTimeKind.Utc).AddTicks(2617) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 17, 8, 46, 826, DateTimeKind.Utc).AddTicks(6221), new DateTime(2023, 8, 31, 3, 2, 50, 340, DateTimeKind.Utc).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 14, 22, 198, DateTimeKind.Utc).AddTicks(2675), new DateTime(2023, 4, 22, 22, 9, 32, 503, DateTimeKind.Utc).AddTicks(4106) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 16, 3, 12, 0, 101, DateTimeKind.Utc).AddTicks(4382), new DateTime(2023, 8, 18, 4, 28, 12, 700, DateTimeKind.Utc).AddTicks(6665) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 5, 5, 49, 27, 143, DateTimeKind.Utc).AddTicks(5926), new DateTime(2023, 5, 20, 10, 35, 43, 551, DateTimeKind.Utc).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 3, 15, 3, 53, 57, 517, DateTimeKind.Utc).AddTicks(4808), new DateTime(2022, 7, 11, 5, 20, 36, 827, DateTimeKind.Utc).AddTicks(9947) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 5, 8, 58, 763, DateTimeKind.Utc).AddTicks(2176), new DateTime(2023, 9, 2, 22, 12, 32, 493, DateTimeKind.Utc).AddTicks(8642) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 8, 1, 49, 34, 996, DateTimeKind.Utc).AddTicks(9545), new DateTime(2023, 9, 3, 17, 19, 11, 953, DateTimeKind.Utc).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 30, 18, 30, 18, 347, DateTimeKind.Utc).AddTicks(8614), new DateTime(2023, 9, 1, 1, 58, 33, 990, DateTimeKind.Utc).AddTicks(3651) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 20, 12, 3, 7, 838, DateTimeKind.Utc).AddTicks(4363), new DateTime(2023, 8, 29, 18, 20, 32, 956, DateTimeKind.Utc).AddTicks(1160) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 13, 15, 33, 20, 457, DateTimeKind.Utc).AddTicks(1298), new DateTime(2023, 7, 29, 11, 50, 3, 339, DateTimeKind.Utc).AddTicks(4085) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 8, 23, 13, 44, 649, DateTimeKind.Utc).AddTicks(2872), new DateTime(2023, 9, 11, 16, 6, 12, 786, DateTimeKind.Utc).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 8, 17, 4, 15, 405, DateTimeKind.Utc).AddTicks(6929), new DateTime(2023, 5, 22, 9, 16, 7, 235, DateTimeKind.Utc).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 20, 38, 426, DateTimeKind.Utc).AddTicks(7789), new DateTime(2023, 8, 18, 0, 49, 46, 436, DateTimeKind.Utc).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 30, 12, 20, 58, 251, DateTimeKind.Utc).AddTicks(2143), new DateTime(2023, 8, 31, 9, 2, 55, 499, DateTimeKind.Utc).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 30, 7, 31, 30, 999, DateTimeKind.Utc).AddTicks(3694), new DateTime(2023, 7, 1, 14, 53, 0, 931, DateTimeKind.Utc).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 10, 8, 39, 36, 875, DateTimeKind.Utc).AddTicks(2327), new DateTime(2023, 8, 18, 12, 17, 58, 946, DateTimeKind.Utc).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 37, 12, 864, DateTimeKind.Utc).AddTicks(7957), new DateTime(2023, 9, 8, 10, 17, 46, 451, DateTimeKind.Utc).AddTicks(645) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 10, 25, 9, 51, 40, 547, DateTimeKind.Utc).AddTicks(6477), new DateTime(2021, 6, 4, 3, 11, 48, 409, DateTimeKind.Utc).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 4, 18, 18, 29, 42, 859, DateTimeKind.Utc).AddTicks(9561), new DateTime(2021, 6, 1, 22, 25, 2, 763, DateTimeKind.Utc).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 31, 6, 217, DateTimeKind.Utc).AddTicks(4233), new DateTime(2023, 8, 26, 3, 34, 18, 731, DateTimeKind.Utc).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 7, 15, 6, 43, 34, 178, DateTimeKind.Utc).AddTicks(5926), new DateTime(2023, 4, 15, 20, 44, 16, 304, DateTimeKind.Utc).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 28, 21, 56, 56, 828, DateTimeKind.Utc).AddTicks(2121), new DateTime(2023, 8, 15, 6, 11, 17, 684, DateTimeKind.Utc).AddTicks(9227) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 6, 15, 1, 47, 649, DateTimeKind.Utc).AddTicks(2672), new DateTime(2023, 9, 9, 19, 44, 24, 101, DateTimeKind.Utc).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 19, 18, 56, 57, 241, DateTimeKind.Utc).AddTicks(8749), new DateTime(2023, 6, 23, 23, 50, 58, 706, DateTimeKind.Utc).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 21, 12, 16, 25, 784, DateTimeKind.Utc).AddTicks(5599), new DateTime(2023, 8, 14, 2, 57, 40, 912, DateTimeKind.Utc).AddTicks(8606) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 2, 6, 8, 17, 28, 595, DateTimeKind.Utc).AddTicks(7322), new DateTime(2022, 1, 5, 20, 40, 0, 301, DateTimeKind.Utc).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 17, 14, 59, 39, 273, DateTimeKind.Utc).AddTicks(2910), new DateTime(2023, 7, 28, 14, 43, 33, 363, DateTimeKind.Utc).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 5, 5, 34, 3, 459, DateTimeKind.Utc).AddTicks(9995), new DateTime(2023, 4, 30, 8, 44, 23, 672, DateTimeKind.Utc).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 12, 10, 44, 14, 312, DateTimeKind.Utc).AddTicks(2972), new DateTime(2023, 5, 8, 18, 40, 54, 745, DateTimeKind.Utc).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 29, 17, 41, 21, 228, DateTimeKind.Utc).AddTicks(3538), new DateTime(2023, 9, 10, 6, 44, 35, 659, DateTimeKind.Utc).AddTicks(2564) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 26, 17, 35, 55, 202, DateTimeKind.Utc).AddTicks(6523), new DateTime(2023, 7, 29, 8, 0, 43, 197, DateTimeKind.Utc).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 3, 19, 30, 24, 341, DateTimeKind.Utc).AddTicks(4650), new DateTime(2023, 7, 23, 9, 38, 46, 481, DateTimeKind.Utc).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 7, 1, 52, 36, 758, DateTimeKind.Utc).AddTicks(1584), new DateTime(2023, 8, 25, 21, 16, 1, 745, DateTimeKind.Utc).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 9, 7, 2, 18, 40, 956, DateTimeKind.Utc).AddTicks(2882), new DateTime(2022, 8, 25, 5, 51, 5, 110, DateTimeKind.Utc).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 15, 11, 18, 41, 258, DateTimeKind.Utc).AddTicks(3216), new DateTime(2023, 9, 9, 14, 45, 18, 131, DateTimeKind.Utc).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 13, 6, 0, 12, 300, DateTimeKind.Utc).AddTicks(6909), new DateTime(2023, 7, 30, 7, 28, 4, 631, DateTimeKind.Utc).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 14, 18, 7, 40, 875, DateTimeKind.Utc).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 2, 8, 11, 23, 216, DateTimeKind.Utc).AddTicks(5813), new DateTime(2023, 7, 24, 12, 10, 1, 860, DateTimeKind.Utc).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 11, 20, 32, 42, 798, DateTimeKind.Utc).AddTicks(2043), new DateTime(2023, 9, 8, 8, 54, 24, 583, DateTimeKind.Utc).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 8, 20, 9, 35, 13, 233, DateTimeKind.Utc).AddTicks(3133), new DateTime(2023, 3, 23, 18, 56, 46, 54, DateTimeKind.Utc).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 22, 10, 36, 9, 685, DateTimeKind.Utc).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 29, 20, 4, 18, 574, DateTimeKind.Utc).AddTicks(8442), new DateTime(2023, 8, 3, 12, 22, 35, 465, DateTimeKind.Utc).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 10, 5, 13, 32, 641, DateTimeKind.Utc).AddTicks(9486), new DateTime(2023, 5, 28, 20, 21, 45, 990, DateTimeKind.Utc).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 21, 14, 31, 42, 643, DateTimeKind.Utc).AddTicks(1205), new DateTime(2023, 7, 23, 11, 7, 20, 309, DateTimeKind.Utc).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 10, 6, 30, 11, 966, DateTimeKind.Utc).AddTicks(3189), new DateTime(2023, 9, 10, 18, 31, 24, 650, DateTimeKind.Utc).AddTicks(743) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 18, 16, 25, 860, DateTimeKind.Utc).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 5, 17, 16, 58, 62, DateTimeKind.Utc).AddTicks(4561), new DateTime(2023, 8, 11, 8, 14, 27, 920, DateTimeKind.Utc).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 10, 5, 40, 58, 476, DateTimeKind.Utc).AddTicks(7164), new DateTime(2023, 7, 17, 14, 54, 59, 898, DateTimeKind.Utc).AddTicks(6593) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 22, 16, 36, 51, 644, DateTimeKind.Utc).AddTicks(5745), new DateTime(2023, 9, 3, 9, 11, 39, 802, DateTimeKind.Utc).AddTicks(706) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 4, 14, 52, 33, 694, DateTimeKind.Utc).AddTicks(8385), new DateTime(2023, 8, 8, 7, 55, 52, 245, DateTimeKind.Utc).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 16, 53, 2, 998, DateTimeKind.Utc).AddTicks(5511), new DateTime(2023, 8, 1, 22, 12, 52, 88, DateTimeKind.Utc).AddTicks(2462) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 6, 8, 1, 51, 8, 820, DateTimeKind.Utc).AddTicks(3913), new DateTime(2021, 8, 13, 11, 14, 22, 16, DateTimeKind.Utc).AddTicks(773) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 26, 13, 26, 36, 902, DateTimeKind.Utc).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 12, 5, 2, 26, 164, DateTimeKind.Utc).AddTicks(5279), new DateTime(2023, 8, 22, 16, 20, 38, 407, DateTimeKind.Utc).AddTicks(1024) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 1, 1, 26, 50, 373, DateTimeKind.Utc).AddTicks(1445), new DateTime(2023, 8, 6, 10, 25, 48, 675, DateTimeKind.Utc).AddTicks(6611) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 29, 19, 21, 49, 784, DateTimeKind.Utc).AddTicks(1538), new DateTime(2023, 8, 21, 12, 14, 16, 660, DateTimeKind.Utc).AddTicks(6123) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 17, 9, 12, 57, 22, DateTimeKind.Utc).AddTicks(9731), new DateTime(2023, 1, 14, 6, 14, 31, 990, DateTimeKind.Utc).AddTicks(1382) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 23, 1, 8, 44, 325, DateTimeKind.Utc).AddTicks(3585), new DateTime(2023, 8, 30, 23, 38, 39, 9, DateTimeKind.Utc).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 16, 12, 3, 55, 861, DateTimeKind.Utc).AddTicks(6488), new DateTime(2023, 1, 7, 5, 28, 39, 142, DateTimeKind.Utc).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 10, 26, 13, 53, 4, 911, DateTimeKind.Utc).AddTicks(5827), new DateTime(2022, 12, 8, 1, 53, 33, 612, DateTimeKind.Utc).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 19, 23, 10, 40, 221, DateTimeKind.Utc).AddTicks(7565), new DateTime(2023, 9, 1, 15, 56, 31, 948, DateTimeKind.Utc).AddTicks(9365) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 22, 18, 2, 42, 986, DateTimeKind.Utc).AddTicks(7491), new DateTime(2023, 7, 11, 16, 59, 44, 525, DateTimeKind.Utc).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 7, 1, 51, 53, 593, DateTimeKind.Utc).AddTicks(6267), new DateTime(2023, 6, 30, 22, 52, 48, 571, DateTimeKind.Utc).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 14, 6, 6, 18, 419, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 3, 12, 54, 58, 779, DateTimeKind.Utc).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 4, 20, 9, 14, 48, DateTimeKind.Utc).AddTicks(325), new DateTime(2023, 9, 7, 10, 40, 54, 636, DateTimeKind.Utc).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 19, 19, 57, 13, 215, DateTimeKind.Utc).AddTicks(5694), new DateTime(2023, 8, 25, 3, 31, 3, 950, DateTimeKind.Utc).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 4, 12, 52, 35, 739, DateTimeKind.Utc).AddTicks(1291), new DateTime(2023, 6, 27, 18, 10, 6, 130, DateTimeKind.Utc).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 8, 11, 8, 43, 16, DateTimeKind.Utc).AddTicks(4605), new DateTime(2023, 9, 8, 15, 56, 59, 556, DateTimeKind.Utc).AddTicks(123) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 24, 21, 5, 0, 234, DateTimeKind.Utc).AddTicks(8670), new DateTime(2023, 6, 21, 16, 18, 20, 689, DateTimeKind.Utc).AddTicks(1627) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 11, 52, 42, 404, DateTimeKind.Utc).AddTicks(7395), new DateTime(2023, 7, 31, 2, 36, 28, 7, DateTimeKind.Utc).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 7, 22, 50, 10, 379, DateTimeKind.Utc).AddTicks(5512), new DateTime(2023, 9, 11, 7, 38, 14, 855, DateTimeKind.Utc).AddTicks(7903) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 2, 2, 40, 47, 830, DateTimeKind.Utc).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 28, 6, 54, 46, 779, DateTimeKind.Utc).AddTicks(5563), new DateTime(2023, 8, 10, 11, 43, 34, 78, DateTimeKind.Utc).AddTicks(9227) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 6, 19, 40, 29, 434, DateTimeKind.Utc).AddTicks(6017), new DateTime(2023, 9, 8, 15, 26, 17, 247, DateTimeKind.Utc).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 19, 19, 43, 44, 793, DateTimeKind.Utc).AddTicks(1368), new DateTime(2023, 8, 17, 3, 1, 8, 419, DateTimeKind.Utc).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 22, 55, 78, DateTimeKind.Utc).AddTicks(6845), new DateTime(2023, 9, 6, 14, 18, 49, 303, DateTimeKind.Utc).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 1, 32, 402, DateTimeKind.Utc).AddTicks(2510), new DateTime(2023, 6, 18, 6, 33, 17, 490, DateTimeKind.Utc).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 19, 6, 19, 8, 930, DateTimeKind.Utc).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 8, 19, 51, 47, 164, DateTimeKind.Utc).AddTicks(5794), new DateTime(2023, 9, 9, 13, 44, 33, 81, DateTimeKind.Utc).AddTicks(2685) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 44, 27, 772, DateTimeKind.Utc).AddTicks(2098), new DateTime(2023, 8, 22, 4, 30, 39, 324, DateTimeKind.Utc).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 2, 7, 45, 32, 754, DateTimeKind.Utc).AddTicks(4507), new DateTime(2023, 8, 19, 5, 50, 1, 891, DateTimeKind.Utc).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 8, 22, 6, 37, 40, 548, DateTimeKind.Utc).AddTicks(4853), new DateTime(2023, 5, 12, 4, 6, 48, 93, DateTimeKind.Utc).AddTicks(6232) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 20, 23, 28, 2, 341, DateTimeKind.Utc).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 18, 2, 13, 23, 911, DateTimeKind.Utc).AddTicks(3145), new DateTime(2023, 8, 18, 12, 29, 26, 295, DateTimeKind.Utc).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 10, 16, 42, 2, 738, DateTimeKind.Utc).AddTicks(5879), new DateTime(2023, 5, 9, 23, 4, 53, 483, DateTimeKind.Utc).AddTicks(9337) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 27, 16, 40, 38, 762, DateTimeKind.Utc).AddTicks(2360), new DateTime(2023, 8, 22, 13, 28, 50, 905, DateTimeKind.Utc).AddTicks(6152) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 6, 20, 50, 9, 795, DateTimeKind.Utc).AddTicks(3180), new DateTime(2023, 9, 9, 10, 45, 4, 503, DateTimeKind.Utc).AddTicks(5487) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 7, 14, 8, 0, 44, 455, DateTimeKind.Utc).AddTicks(5093), new DateTime(2022, 5, 13, 14, 29, 38, 574, DateTimeKind.Utc).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 17, 58, 51, 821, DateTimeKind.Utc).AddTicks(9801), new DateTime(2023, 9, 6, 21, 52, 59, 675, DateTimeKind.Utc).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 2, 8, 44, 15, 955, DateTimeKind.Utc).AddTicks(4606), new DateTime(2023, 8, 23, 20, 27, 7, 182, DateTimeKind.Utc).AddTicks(8085) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 22, 1, 40, 32, 957, DateTimeKind.Utc).AddTicks(7889), new DateTime(2023, 9, 11, 11, 1, 11, 256, DateTimeKind.Utc).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 22, 5, 45, 38, 453, DateTimeKind.Utc).AddTicks(1344), new DateTime(2023, 6, 12, 10, 43, 54, 739, DateTimeKind.Utc).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 2, 3, 19, 16, 320, DateTimeKind.Utc).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 10, 0, 8, 58, 285, DateTimeKind.Utc).AddTicks(2482), new DateTime(2023, 9, 11, 1, 49, 6, 35, DateTimeKind.Utc).AddTicks(225) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 22, 14, 59, 29, 991, DateTimeKind.Utc).AddTicks(5094), new DateTime(2023, 7, 20, 17, 14, 11, 0, DateTimeKind.Utc).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 3, 0, 21, 6, 102, DateTimeKind.Utc).AddTicks(3392), new DateTime(2023, 8, 22, 16, 13, 54, 362, DateTimeKind.Utc).AddTicks(8581) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 21, 2, 48, 765, DateTimeKind.Utc).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 13, 39, 3, 847, DateTimeKind.Utc).AddTicks(9860), new DateTime(2023, 7, 12, 7, 45, 54, 956, DateTimeKind.Utc).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 17, 18, 17, 23, 30, DateTimeKind.Utc).AddTicks(8431), new DateTime(2023, 8, 20, 0, 25, 11, 563, DateTimeKind.Utc).AddTicks(5492) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 2, 9, 30, 23, 321, DateTimeKind.Utc).AddTicks(6813), new DateTime(2023, 9, 5, 11, 4, 26, 627, DateTimeKind.Utc).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 10, 21, 21, 56, 8, 953, DateTimeKind.Utc).AddTicks(340), new DateTime(2023, 4, 23, 22, 31, 36, 548, DateTimeKind.Utc).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 9, 5, 34, 32, 924, DateTimeKind.Utc).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 10, 7, 13, 4, 0, 757, DateTimeKind.Utc).AddTicks(5183), new DateTime(2022, 12, 31, 16, 2, 34, 977, DateTimeKind.Utc).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 7, 4, 31, 19, 958, DateTimeKind.Utc).AddTicks(3208), new DateTime(2023, 9, 7, 17, 53, 32, 386, DateTimeKind.Utc).AddTicks(4455) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 1, 14, 38, 1, 625, DateTimeKind.Utc).AddTicks(5823), new DateTime(2023, 9, 9, 23, 1, 14, 200, DateTimeKind.Utc).AddTicks(2383) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 23, 2, 9, 16, 461, DateTimeKind.Utc).AddTicks(647), new DateTime(2023, 8, 28, 3, 48, 34, 278, DateTimeKind.Utc).AddTicks(7887) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 23, 18, 32, 19, 986, DateTimeKind.Utc).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 22, 10, 6, 51, 921, DateTimeKind.Utc).AddTicks(243), new DateTime(2023, 9, 5, 5, 48, 10, 788, DateTimeKind.Utc).AddTicks(5482) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 14, 30, 55, 950, DateTimeKind.Utc).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 24, 14, 15, 50, 674, DateTimeKind.Utc).AddTicks(7995), new DateTime(2023, 4, 26, 20, 24, 23, 561, DateTimeKind.Utc).AddTicks(7116) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 20, 2, 16, 9, 216, DateTimeKind.Utc).AddTicks(5699), new DateTime(2023, 7, 13, 23, 13, 22, 180, DateTimeKind.Utc).AddTicks(6662) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 1, 18, 52, 36, 20, DateTimeKind.Utc).AddTicks(9857), new DateTime(2023, 5, 20, 22, 58, 23, 359, DateTimeKind.Utc).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 10, 16, 28, 18, 572, DateTimeKind.Utc).AddTicks(3385), new DateTime(2023, 9, 4, 0, 19, 35, 322, DateTimeKind.Utc).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 31, 47, 931, DateTimeKind.Utc).AddTicks(1917), new DateTime(2023, 8, 14, 23, 14, 29, 475, DateTimeKind.Utc).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 8, 22, 55, 43, 321, DateTimeKind.Utc).AddTicks(3058), new DateTime(2023, 6, 11, 21, 57, 7, 780, DateTimeKind.Utc).AddTicks(4618) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 27, 23, 825, DateTimeKind.Utc).AddTicks(551), new DateTime(2023, 7, 8, 14, 23, 6, 687, DateTimeKind.Utc).AddTicks(6435) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 4, 22, 8, 267, DateTimeKind.Utc).AddTicks(4968), new DateTime(2023, 8, 23, 7, 52, 40, 744, DateTimeKind.Utc).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 17, 9, 27, 38, DateTimeKind.Utc).AddTicks(2524), new DateTime(2022, 12, 3, 5, 45, 41, 930, DateTimeKind.Utc).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 30, 3, 44, 43, 577, DateTimeKind.Utc).AddTicks(5556), new DateTime(2023, 9, 9, 18, 31, 35, 864, DateTimeKind.Utc).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 20, 14, 54, 40, 552, DateTimeKind.Utc).AddTicks(6535), new DateTime(2023, 8, 5, 20, 7, 5, 25, DateTimeKind.Utc).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 18, 43, 42, 937, DateTimeKind.Utc).AddTicks(9133), new DateTime(2022, 10, 18, 5, 35, 51, 734, DateTimeKind.Utc).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 30, 20, 11, 38, 102, DateTimeKind.Utc).AddTicks(6769), new DateTime(2023, 6, 9, 20, 10, 4, 536, DateTimeKind.Utc).AddTicks(651) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 6, 14, 23, 38, 272, DateTimeKind.Utc).AddTicks(5361), new DateTime(2023, 9, 8, 11, 12, 53, 779, DateTimeKind.Utc).AddTicks(5027) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 10, 19, 7, 11, 703, DateTimeKind.Utc).AddTicks(5528), new DateTime(2023, 9, 11, 1, 1, 15, 525, DateTimeKind.Utc).AddTicks(7993) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 7, 51, 5, 729, DateTimeKind.Utc).AddTicks(4192), new DateTime(2023, 8, 20, 13, 28, 29, 265, DateTimeKind.Utc).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 29, 3, 46, 44, 480, DateTimeKind.Utc).AddTicks(7959), new DateTime(2023, 7, 15, 1, 42, 36, 906, DateTimeKind.Utc).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 30, 10, 14, 2, 615, DateTimeKind.Utc).AddTicks(3977), new DateTime(2023, 8, 1, 6, 43, 55, 494, DateTimeKind.Utc).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 7, 12, 54, 55, 54, DateTimeKind.Utc).AddTicks(9726), new DateTime(2023, 8, 31, 23, 44, 39, 265, DateTimeKind.Utc).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 8, 9, 21, 7, 831, DateTimeKind.Utc).AddTicks(649), new DateTime(2023, 8, 16, 17, 15, 14, 896, DateTimeKind.Utc).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 16, 13, 40, 46, 178, DateTimeKind.Utc).AddTicks(6652), new DateTime(2023, 8, 2, 8, 16, 18, 643, DateTimeKind.Utc).AddTicks(1068) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 35, 25, 9, DateTimeKind.Utc).AddTicks(4176), new DateTime(2023, 8, 24, 2, 0, 51, 455, DateTimeKind.Utc).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 6, 8, 3, 6, 56, 470, DateTimeKind.Utc).AddTicks(9290), new DateTime(2023, 5, 24, 15, 58, 18, 847, DateTimeKind.Utc).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 12, 3, 5, 39, 49, 728, DateTimeKind.Utc).AddTicks(8527), new DateTime(2022, 7, 4, 6, 13, 55, 208, DateTimeKind.Utc).AddTicks(7507) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 29, 11, 40, 16, 484, DateTimeKind.Utc).AddTicks(3576), new DateTime(2023, 9, 3, 1, 20, 32, 219, DateTimeKind.Utc).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 2, 6, 34, 12, 518, DateTimeKind.Utc).AddTicks(5589), new DateTime(2023, 9, 5, 5, 43, 46, 777, DateTimeKind.Utc).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 3, 7, 3, 12, 2, 270, DateTimeKind.Utc).AddTicks(4690), new DateTime(2023, 4, 27, 8, 24, 52, 620, DateTimeKind.Utc).AddTicks(1994) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 22, 20, 6, 55, 179, DateTimeKind.Utc).AddTicks(8270), new DateTime(2023, 8, 2, 12, 39, 46, 509, DateTimeKind.Utc).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 8, 2, 0, 43, 516, DateTimeKind.Utc).AddTicks(5717), new DateTime(2023, 9, 8, 10, 17, 38, 895, DateTimeKind.Utc).AddTicks(1590) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 5, 6, 2, 9, 833, DateTimeKind.Utc).AddTicks(3921), new DateTime(2023, 9, 6, 8, 4, 25, 236, DateTimeKind.Utc).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 5, 0, 28, 17, 280, DateTimeKind.Utc).AddTicks(2959), new DateTime(2022, 11, 5, 22, 41, 7, 35, DateTimeKind.Utc).AddTicks(3687) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 19, 16, 458, DateTimeKind.Utc).AddTicks(5226), new DateTime(2023, 6, 17, 18, 6, 29, 155, DateTimeKind.Utc).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 4, 3, 12, 25, 43, 995, DateTimeKind.Utc).AddTicks(7251), new DateTime(2022, 10, 23, 7, 17, 58, 172, DateTimeKind.Utc).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2019, 9, 21, 12, 37, 9, 597, DateTimeKind.Utc).AddTicks(749), new DateTime(2021, 7, 8, 23, 39, 19, 575, DateTimeKind.Utc).AddTicks(6957) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 10, 16, 8, 26, 25, 745, DateTimeKind.Utc).AddTicks(7177), new DateTime(2022, 12, 28, 18, 11, 41, 942, DateTimeKind.Utc).AddTicks(1264) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 7, 8, 38, 36, 111, DateTimeKind.Utc).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 13, 20, 23, 16, 952, DateTimeKind.Utc).AddTicks(6508), new DateTime(2023, 6, 27, 13, 42, 26, 94, DateTimeKind.Utc).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 5, 17, 18, 14, 24, 739, DateTimeKind.Utc).AddTicks(7269), new DateTime(2023, 2, 8, 21, 29, 53, 578, DateTimeKind.Utc).AddTicks(4651) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 162L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 11, 27, 8, 43, 2, 231, DateTimeKind.Utc).AddTicks(7099), new DateTime(2022, 10, 20, 11, 43, 31, 720, DateTimeKind.Utc).AddTicks(6356) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 163L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 32, 46, 983, DateTimeKind.Utc).AddTicks(9163), new DateTime(2023, 7, 8, 4, 45, 55, 39, DateTimeKind.Utc).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 164L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 7, 14, 57, 25, 432, DateTimeKind.Utc).AddTicks(9082), new DateTime(2023, 9, 10, 8, 58, 2, 885, DateTimeKind.Utc).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 165L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 4, 23, 3, 31, 43, 526, DateTimeKind.Utc).AddTicks(3929), new DateTime(2020, 11, 17, 22, 0, 23, 103, DateTimeKind.Utc).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 1, 11, 10, 38, 750, DateTimeKind.Utc).AddTicks(1464), new DateTime(2023, 9, 8, 19, 38, 39, 181, DateTimeKind.Utc).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 4, 11, 20, 59, 44, 770, DateTimeKind.Utc).AddTicks(341), new DateTime(2022, 10, 8, 14, 6, 55, 469, DateTimeKind.Utc).AddTicks(3708) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 8, 3, 1, 3, 42, 680, DateTimeKind.Utc).AddTicks(1837), new DateTime(2023, 4, 5, 15, 30, 26, 675, DateTimeKind.Utc).AddTicks(635) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 9, 20, 42, 39, 945, DateTimeKind.Utc).AddTicks(5474), new DateTime(2023, 9, 8, 15, 37, 45, 594, DateTimeKind.Utc).AddTicks(3067) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 8, 12, 13, 24, 4, 257, DateTimeKind.Utc).AddTicks(7950), new DateTime(2023, 4, 30, 4, 36, 13, 662, DateTimeKind.Utc).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 10, 22, 37, 7, 930, DateTimeKind.Utc).AddTicks(439), new DateTime(2023, 8, 9, 14, 20, 54, 380, DateTimeKind.Utc).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 21, 15, 34, 13, 395, DateTimeKind.Utc).AddTicks(4365), new DateTime(2023, 8, 26, 19, 27, 35, 436, DateTimeKind.Utc).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 9, 15, 15, 11, 33, 385, DateTimeKind.Utc).AddTicks(9032), new DateTime(2022, 11, 18, 0, 51, 50, 892, DateTimeKind.Utc).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 15, 10, 29, 55, 458, DateTimeKind.Utc).AddTicks(531), new DateTime(2023, 8, 12, 19, 10, 7, 492, DateTimeKind.Utc).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 3, 25, 5, 18, 59, 366, DateTimeKind.Utc).AddTicks(73), new DateTime(2023, 4, 16, 14, 2, 8, 342, DateTimeKind.Utc).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 10, 8, 12, 41, 675, DateTimeKind.Utc).AddTicks(2502), new DateTime(2023, 9, 6, 16, 30, 53, 333, DateTimeKind.Utc).AddTicks(6301) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 8, 20, 22, 12, 382, DateTimeKind.Utc).AddTicks(8179), new DateTime(2023, 9, 10, 6, 49, 43, 849, DateTimeKind.Utc).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 25, 15, 46, 14, 155, DateTimeKind.Utc).AddTicks(8235), new DateTime(2023, 6, 29, 22, 28, 5, 221, DateTimeKind.Utc).AddTicks(4137) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 6, 15, 1, 10, 499, DateTimeKind.Utc).AddTicks(2959), new DateTime(2023, 9, 7, 16, 4, 2, 649, DateTimeKind.Utc).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2019, 12, 5, 6, 38, 4, 325, DateTimeKind.Utc).AddTicks(1440), new DateTime(2021, 1, 31, 6, 32, 12, 452, DateTimeKind.Utc).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 22, 21, 42, 933, DateTimeKind.Utc).AddTicks(9792), new DateTime(2023, 6, 13, 2, 25, 21, 392, DateTimeKind.Utc).AddTicks(4858) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 11, 13, 27, 223, DateTimeKind.Utc).AddTicks(2371), new DateTime(2023, 8, 4, 22, 55, 35, 656, DateTimeKind.Utc).AddTicks(8424) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 2, 1, 48, 748, DateTimeKind.Utc).AddTicks(7144), new DateTime(2023, 7, 19, 14, 45, 19, 317, DateTimeKind.Utc).AddTicks(4514) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 25, 11, 22, 49, 149, DateTimeKind.Utc).AddTicks(1158), new DateTime(2023, 8, 30, 23, 12, 12, 668, DateTimeKind.Utc).AddTicks(7473) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 27, 23, 16, 4, 341, DateTimeKind.Utc).AddTicks(6667), new DateTime(2023, 7, 6, 19, 22, 20, 532, DateTimeKind.Utc).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 45, 21, 451, DateTimeKind.Utc).AddTicks(6334), new DateTime(2022, 12, 25, 3, 40, 44, 727, DateTimeKind.Utc).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 11, 8, 23, 33, 49, 870, DateTimeKind.Utc).AddTicks(5282), new DateTime(2021, 3, 4, 18, 5, 45, 674, DateTimeKind.Utc).AddTicks(3873) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 24, 17, 41, 49, 214, DateTimeKind.Utc).AddTicks(781), new DateTime(2023, 6, 12, 17, 1, 19, 486, DateTimeKind.Utc).AddTicks(2498) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 11, 8, 42, 38, 122, DateTimeKind.Utc).AddTicks(42), new DateTime(2023, 9, 11, 9, 35, 14, 594, DateTimeKind.Utc).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 2, 21, 53, 11, 86, DateTimeKind.Utc).AddTicks(5511), new DateTime(2023, 9, 10, 14, 48, 59, 766, DateTimeKind.Utc).AddTicks(2948) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 12, 21, 6, 52, 105, DateTimeKind.Utc).AddTicks(8083), new DateTime(2023, 7, 7, 2, 6, 2, 565, DateTimeKind.Utc).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 13, 18, 28, 5, 635, DateTimeKind.Utc).AddTicks(8213), new DateTime(2023, 7, 9, 12, 26, 19, 438, DateTimeKind.Utc).AddTicks(7808) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 13, 8, 46, 26, 497, DateTimeKind.Utc).AddTicks(8914), new DateTime(2023, 8, 23, 13, 10, 46, 259, DateTimeKind.Utc).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 3, 24, 40, 154, DateTimeKind.Utc).AddTicks(1714), new DateTime(2023, 7, 8, 18, 2, 29, 754, DateTimeKind.Utc).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 9, 18, 2, 26, 19, 415, DateTimeKind.Utc).AddTicks(695), new DateTime(2023, 2, 8, 18, 11, 59, 831, DateTimeKind.Utc).AddTicks(6955) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 10, 7, 36, 22, 818, DateTimeKind.Utc).AddTicks(4165), new DateTime(2023, 9, 10, 17, 19, 25, 596, DateTimeKind.Utc).AddTicks(1287) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 8, 39, 1, 55, DateTimeKind.Utc).AddTicks(3440), new DateTime(2023, 7, 29, 14, 18, 21, 905, DateTimeKind.Utc).AddTicks(5987) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 10, 9, 31, 35, 601, DateTimeKind.Utc).AddTicks(7245), new DateTime(2023, 6, 21, 17, 0, 47, 964, DateTimeKind.Utc).AddTicks(3073) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 8, 2, 48, 26, 636, DateTimeKind.Utc).AddTicks(235), new DateTime(2023, 7, 25, 23, 27, 1, 244, DateTimeKind.Utc).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 2, 22, 46, 39, 396, DateTimeKind.Utc).AddTicks(7358), new DateTime(2023, 9, 8, 20, 52, 43, 142, DateTimeKind.Utc).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "RegisteredAt",
                value: new DateTime(2016, 5, 19, 20, 11, 34, 126, DateTimeKind.Utc).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "RegisteredAt",
                value: new DateTime(2016, 4, 10, 16, 9, 41, 795, DateTimeKind.Utc).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                column: "RegisteredAt",
                value: new DateTime(2017, 11, 10, 13, 29, 51, 24, DateTimeKind.Utc).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                column: "RegisteredAt",
                value: new DateTime(2018, 7, 26, 6, 57, 14, 26, DateTimeKind.Utc).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                column: "RegisteredAt",
                value: new DateTime(2017, 8, 16, 4, 32, 26, 530, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                column: "RegisteredAt",
                value: new DateTime(2022, 3, 7, 4, 1, 23, 639, DateTimeKind.Utc).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                column: "RegisteredAt",
                value: new DateTime(2020, 9, 18, 9, 33, 3, 780, DateTimeKind.Utc).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                column: "RegisteredAt",
                value: new DateTime(2022, 6, 1, 13, 5, 55, 923, DateTimeKind.Utc).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                column: "RegisteredAt",
                value: new DateTime(2021, 12, 7, 12, 35, 21, 395, DateTimeKind.Utc).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                column: "RegisteredAt",
                value: new DateTime(2018, 7, 20, 12, 19, 21, 679, DateTimeKind.Utc).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11L,
                column: "RegisteredAt",
                value: new DateTime(2022, 3, 28, 18, 0, 40, 924, DateTimeKind.Utc).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12L,
                column: "RegisteredAt",
                value: new DateTime(2019, 9, 17, 7, 52, 54, 917, DateTimeKind.Utc).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13L,
                column: "RegisteredAt",
                value: new DateTime(2021, 3, 13, 6, 12, 35, 101, DateTimeKind.Utc).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14L,
                column: "RegisteredAt",
                value: new DateTime(2016, 6, 10, 1, 12, 17, 245, DateTimeKind.Utc).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15L,
                column: "RegisteredAt",
                value: new DateTime(2022, 3, 17, 2, 25, 11, 632, DateTimeKind.Utc).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16L,
                column: "RegisteredAt",
                value: new DateTime(2017, 6, 23, 7, 51, 12, 929, DateTimeKind.Utc).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17L,
                column: "RegisteredAt",
                value: new DateTime(2016, 1, 19, 22, 56, 16, 502, DateTimeKind.Utc).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18L,
                column: "RegisteredAt",
                value: new DateTime(2022, 12, 30, 19, 6, 30, 100, DateTimeKind.Utc).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19L,
                column: "RegisteredAt",
                value: new DateTime(2022, 4, 18, 3, 21, 32, 390, DateTimeKind.Utc).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20L,
                column: "RegisteredAt",
                value: new DateTime(2020, 12, 18, 22, 36, 58, 49, DateTimeKind.Utc).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21L,
                column: "RegisteredAt",
                value: new DateTime(2017, 1, 24, 19, 11, 21, 181, DateTimeKind.Utc).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22L,
                column: "RegisteredAt",
                value: new DateTime(2018, 5, 5, 0, 57, 15, 231, DateTimeKind.Utc).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23L,
                column: "RegisteredAt",
                value: new DateTime(2021, 11, 10, 13, 47, 55, 886, DateTimeKind.Utc).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24L,
                column: "RegisteredAt",
                value: new DateTime(2021, 4, 29, 17, 56, 12, 744, DateTimeKind.Utc).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25L,
                column: "RegisteredAt",
                value: new DateTime(2019, 2, 23, 6, 49, 49, 113, DateTimeKind.Utc).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26L,
                column: "RegisteredAt",
                value: new DateTime(2016, 6, 21, 20, 26, 44, 211, DateTimeKind.Utc).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27L,
                column: "RegisteredAt",
                value: new DateTime(2021, 12, 15, 10, 41, 35, 676, DateTimeKind.Utc).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28L,
                column: "RegisteredAt",
                value: new DateTime(2016, 7, 18, 11, 22, 57, 907, DateTimeKind.Utc).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29L,
                column: "RegisteredAt",
                value: new DateTime(2017, 8, 4, 16, 2, 5, 423, DateTimeKind.Utc).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30L,
                column: "RegisteredAt",
                value: new DateTime(2020, 8, 24, 15, 27, 38, 331, DateTimeKind.Utc).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31L,
                column: "RegisteredAt",
                value: new DateTime(2016, 12, 17, 2, 7, 46, 228, DateTimeKind.Utc).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32L,
                column: "RegisteredAt",
                value: new DateTime(2016, 12, 25, 4, 2, 33, 998, DateTimeKind.Utc).AddTicks(77));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33L,
                column: "RegisteredAt",
                value: new DateTime(2021, 11, 30, 16, 47, 13, 53, DateTimeKind.Utc).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34L,
                column: "RegisteredAt",
                value: new DateTime(2023, 3, 17, 0, 33, 25, 401, DateTimeKind.Utc).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35L,
                column: "RegisteredAt",
                value: new DateTime(2022, 2, 20, 4, 54, 32, 427, DateTimeKind.Utc).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36L,
                column: "RegisteredAt",
                value: new DateTime(2020, 4, 10, 10, 35, 11, 111, DateTimeKind.Utc).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37L,
                column: "RegisteredAt",
                value: new DateTime(2016, 5, 7, 12, 29, 17, 243, DateTimeKind.Utc).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38L,
                column: "RegisteredAt",
                value: new DateTime(2018, 12, 22, 21, 4, 3, 842, DateTimeKind.Utc).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39L,
                column: "RegisteredAt",
                value: new DateTime(2016, 7, 25, 1, 3, 40, 181, DateTimeKind.Utc).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40L,
                column: "RegisteredAt",
                value: new DateTime(2017, 10, 21, 18, 57, 35, 252, DateTimeKind.Utc).AddTicks(1827));

            migrationBuilder.InsertData(
                table: "ChallengeTags",
                columns: new[] { "ChallengeId", "TagId" },
                values: new object[,]
                {
                    { 1L, 2L },
                    { 1L, 6L },
                    { 2L, 2L },
                    { 2L, 4L },
                    { 2L, 8L },
                    { 2L, 9L },
                    { 3L, 6L },
                    { 3L, 7L },
                    { 4L, 2L },
                    { 4L, 4L },
                    { 5L, 3L },
                    { 5L, 7L },
                    { 6L, 2L },
                    { 6L, 6L },
                    { 7L, 1L },
                    { 7L, 3L },
                    { 7L, 6L },
                    { 7L, 7L },
                    { 7L, 8L },
                    { 8L, 2L },
                    { 8L, 4L },
                    { 9L, 3L },
                    { 9L, 4L },
                    { 9L, 5L },
                    { 9L, 9L },
                    { 10L, 6L },
                    { 11L, 2L },
                    { 12L, 2L },
                    { 12L, 4L },
                    { 13L, 2L },
                    { 13L, 5L },
                    { 13L, 7L },
                    { 13L, 9L },
                    { 14L, 1L },
                    { 14L, 4L },
                    { 14L, 5L },
                    { 14L, 9L },
                    { 15L, 1L },
                    { 15L, 3L },
                    { 15L, 6L },
                    { 15L, 7L },
                    { 15L, 8L }
                });

            migrationBuilder.InsertData(
                table: "ChallengeTags",
                columns: new[] { "ChallengeId", "TagId" },
                values: new object[,]
                {
                    { 16L, 2L },
                    { 16L, 7L },
                    { 17L, 1L },
                    { 17L, 2L },
                    { 17L, 4L },
                    { 17L, 5L },
                    { 17L, 6L },
                    { 17L, 7L },
                    { 18L, 8L },
                    { 19L, 5L },
                    { 20L, 2L },
                    { 20L, 7L },
                    { 20L, 9L },
                    { 21L, 3L },
                    { 21L, 5L },
                    { 21L, 7L },
                    { 21L, 8L },
                    { 23L, 3L },
                    { 23L, 5L },
                    { 23L, 7L },
                    { 24L, 1L },
                    { 24L, 2L },
                    { 24L, 5L },
                    { 24L, 6L },
                    { 24L, 8L },
                    { 24L, 9L },
                    { 25L, 1L },
                    { 25L, 6L },
                    { 27L, 3L },
                    { 27L, 5L },
                    { 27L, 6L },
                    { 27L, 8L },
                    { 28L, 3L },
                    { 29L, 1L },
                    { 29L, 4L },
                    { 29L, 7L },
                    { 29L, 9L },
                    { 30L, 3L },
                    { 30L, 4L },
                    { 31L, 1L },
                    { 31L, 4L },
                    { 31L, 6L }
                });

            migrationBuilder.InsertData(
                table: "ChallengeTags",
                columns: new[] { "ChallengeId", "TagId" },
                values: new object[,]
                {
                    { 31L, 9L },
                    { 32L, 5L },
                    { 32L, 6L },
                    { 33L, 1L },
                    { 33L, 6L },
                    { 34L, 1L },
                    { 34L, 9L },
                    { 35L, 1L },
                    { 36L, 1L },
                    { 36L, 7L },
                    { 36L, 9L },
                    { 37L, 2L },
                    { 37L, 3L },
                    { 37L, 5L },
                    { 37L, 6L },
                    { 38L, 1L },
                    { 38L, 3L },
                    { 38L, 5L },
                    { 39L, 1L },
                    { 39L, 4L },
                    { 39L, 8L },
                    { 40L, 3L },
                    { 40L, 4L },
                    { 41L, 2L },
                    { 41L, 6L },
                    { 41L, 7L },
                    { 41L, 8L },
                    { 41L, 9L },
                    { 42L, 5L },
                    { 42L, 7L },
                    { 43L, 2L },
                    { 43L, 7L },
                    { 44L, 1L },
                    { 44L, 2L },
                    { 44L, 5L },
                    { 44L, 6L },
                    { 44L, 7L },
                    { 44L, 8L },
                    { 44L, 9L },
                    { 45L, 2L },
                    { 45L, 9L },
                    { 46L, 2L }
                });

            migrationBuilder.InsertData(
                table: "ChallengeTags",
                columns: new[] { "ChallengeId", "TagId" },
                values: new object[,]
                {
                    { 46L, 6L },
                    { 47L, 5L },
                    { 47L, 6L },
                    { 47L, 9L },
                    { 48L, 1L },
                    { 48L, 6L },
                    { 48L, 9L },
                    { 49L, 9L },
                    { 50L, 5L },
                    { 50L, 8L },
                    { 51L, 9L },
                    { 52L, 1L },
                    { 52L, 3L },
                    { 52L, 6L },
                    { 53L, 1L },
                    { 53L, 2L },
                    { 53L, 4L },
                    { 53L, 7L },
                    { 53L, 9L },
                    { 54L, 6L },
                    { 54L, 7L },
                    { 54L, 8L },
                    { 54L, 9L },
                    { 55L, 2L },
                    { 55L, 4L },
                    { 55L, 6L },
                    { 56L, 8L },
                    { 57L, 6L },
                    { 57L, 8L },
                    { 58L, 5L },
                    { 58L, 7L },
                    { 59L, 1L },
                    { 59L, 2L },
                    { 59L, 3L },
                    { 59L, 5L },
                    { 59L, 8L },
                    { 60L, 3L },
                    { 60L, 5L },
                    { 61L, 6L },
                    { 63L, 2L },
                    { 63L, 5L },
                    { 65L, 1L }
                });

            migrationBuilder.InsertData(
                table: "ChallengeTags",
                columns: new[] { "ChallengeId", "TagId" },
                values: new object[,]
                {
                    { 65L, 5L },
                    { 65L, 6L },
                    { 65L, 7L },
                    { 65L, 9L },
                    { 66L, 2L },
                    { 67L, 2L },
                    { 68L, 2L },
                    { 68L, 5L },
                    { 68L, 7L },
                    { 69L, 2L },
                    { 70L, 1L },
                    { 70L, 2L },
                    { 70L, 7L },
                    { 70L, 9L }
                });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ChallengeId", "CreatedAt", "CreatedBy", "ExampleTestCases", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 10L, new DateTime(2023, 5, 11, 15, 47, 6, 518, DateTimeKind.Utc).AddTicks(4108), 8L, "Est aut repellendus qui fugit. Sed fugit explicabo autem cum consequuntur alias. Quo alias et quisquam voluptates. Nisi voluptatem omnis inventore velit ipsum maxime fuga.", 2L, "", 2, "Dolores nostrum earum deleniti iusto aut nesciunt modi et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 40L, "odit", new DateTime(2023, 3, 16, 19, 3, 4, 987, DateTimeKind.Utc).AddTicks(8766), 34L, "Vel voluptatum quia quia nesciunt sequi impedit.\nVoluptas repellat nam omnis est magnam rerum eum repudiandae minima.\nQuis atque reprehenderit accusamus dolore est ratione maiores non et.\nSequi minima pariatur dignissimos eum eligendi dolorum.\nCum voluptatibus quibusdam corporis saepe dolores.", "Et fugit vero vitae.", 1L, "", "amet" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 47L, "Officiis ducimus aut dolorem sit dicta ullam.", new DateTime(2021, 6, 22, 11, 58, 1, 329, DateTimeKind.Utc).AddTicks(3968), 25L, "maxime", "Amet voluptates temporibus esse magni.", 1L, "", 3, "Minima accusamus magnam quia laudantium id ut corrupti. Et id nulla nesciunt. Nesciunt minima cupiditate. Dolore corrupti iusto ipsam sapiente." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 57L, "Molestiae hic et officiis accusantium nostrum repellat aut et.\nItaque animi eveniet ut delectus voluptates dolorem.\nLaudantium itaque sequi officiis sapiente et.", new DateTime(2023, 4, 6, 21, 17, 24, 6, DateTimeKind.Utc).AddTicks(6299), 27L, "Non porro impedit.", "Quis perferendis et pariatur sapiente repellat quasi.", 2L, "", 2, "Exercitationem dolorem adipisci veniam blanditiis quidem earum tempore molestias." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 60L, "Sit molestiae adipisci repellat eum vel dolorum aut ullam distinctio.\nOmnis animi officiis tenetur.", new DateTime(2019, 5, 1, 22, 17, 38, 330, DateTimeKind.Utc).AddTicks(1305), 9L, "Libero dolorem voluptatem et vitae eius nemo.", "Fugit mollitia aut ab eum est quaerat consequatur.", 1L, "", "Aliquid neque nemo dolore possimus.\nOptio veniam ratione qui nulla vel in aut.\nVel sit repellendus cupiditate quo quo.\nSunt unde ex doloremque necessitatibus quo veniam dolor officiis eos.\nExplicabo enim necessitatibus soluta est libero voluptatum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 69L, "Culpa maiores officiis deleniti cumque similique optio et sed ab. Quis voluptatem et veniam iusto rerum. Provident inventore voluptas nihil rerum totam expedita hic. Sint rerum earum facilis iusto unde nihil officia minima. Id occaecati quod. Laborum illo ipsum fuga ratione ipsa sequi.", new DateTime(2023, 1, 21, 0, 0, 47, 712, DateTimeKind.Utc).AddTicks(8452), 25L, "Qui placeat facere omnis ea quia.", "Commodi architecto omnis necessitatibus est eum.", 1L, "", 2, "Dolor nesciunt sit itaque quidem debitis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 63L, "Est totam voluptas excepturi et expedita dignissimos et. Atque aut est et. Recusandae rerum dolor assumenda maiores placeat magnam debitis. Facilis velit et qui totam et iusto consequatur ut. Et tempora officiis error enim nulla.", new DateTime(2023, 4, 21, 23, 47, 36, 510, DateTimeKind.Utc).AddTicks(4012), 13L, "Debitis consequuntur perspiciatis dolorum architecto placeat error eum aut repellendus. Est cumque velit aspernatur voluptatum fugiat. Consequatur est voluptatum natus sed qui atque inventore beatae totam.", "Iure nisi voluptatem.", 2L, "", 1, "suscipit" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 55L, "Quia commodi non quis voluptatem ea.\nQuis dignissimos ipsam et in dolores perferendis.\nAspernatur praesentium sint quis eos et at iusto.\nOfficia harum in ab at at dolorem qui nobis.", new DateTime(2023, 3, 22, 7, 50, 57, 657, DateTimeKind.Utc).AddTicks(8159), 32L, "Et illo voluptas culpa ea ducimus ea.\nEt eum est est neque qui.\nVoluptatem unde voluptatem non.", "Voluptas veniam rerum sed qui ipsam accusamus fuga id.", 1L, "", 2, "rerum" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 66L, "Quis voluptatem autem voluptas ducimus maiores praesentium odit error adipisci. Vitae eligendi consequatur laboriosam commodi atque. Dolor eos est repellat enim aliquam ratione. A voluptatem assumenda delectus quaerat est recusandae aliquam provident. Rerum eius accusamus rerum recusandae cum et officia odit aliquid. Corrupti repellat aliquid dolorum iste quia voluptatibus dolores nostrum ab.", new DateTime(2023, 5, 3, 6, 11, 5, 253, DateTimeKind.Utc).AddTicks(8018), 6L, "Suscipit animi recusandae quo voluptatem odio.\nEsse quam ut optio quo non.", "Officia quos laboriosam porro aut consequuntur.", 1L, "", "dolor" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 16L, "Sint dolores laboriosam totam. Reprehenderit sed blanditiis perferendis qui non aliquid vero. Ab eaque ea consequatur aut.", new DateTime(2022, 11, 9, 23, 38, 16, 719, DateTimeKind.Utc).AddTicks(2762), 37L, "sed", "Totam voluptatem quam ut cumque sint tenetur sed et debitis.", 2L, "", 1, "Natus esse sint magnam incidunt velit adipisci voluptatem." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 2L, "Vitae aut molestias pariatur expedita provident ex beatae nihil numquam. Adipisci consequatur eos dolor quae sit. In esse et veniam.", new DateTime(2020, 10, 26, 9, 35, 29, 219, DateTimeKind.Utc).AddTicks(40), 23L, "Et dignissimos omnis veniam.\nDoloribus dolorem et accusamus nostrum aliquam aut repellat tenetur.\nQuia impedit ut.", "Laudantium accusantium possimus mollitia totam blanditiis odio corrupti asperiores.", 1L, "", 2, "Repellendus labore aut aut. Quaerat iure voluptatem exercitationem ut ut. Facere similique molestiae. Ex sit magnam animi natus deserunt voluptas." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 48L, "Rerum quaerat perferendis iusto ea et.", new DateTime(2023, 5, 14, 22, 22, 12, 689, DateTimeKind.Utc).AddTicks(326), 34L, "Suscipit exercitationem error iure rerum.\nEt autem culpa nemo delectus voluptates.\nPariatur ut nihil.", "Quaerat hic facilis quod expedita adipisci voluptates molestiae qui.", 2L, "", 1, "cumque" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 63L, "Consequatur et ut dolor ut enim atque. Quia nobis dicta reiciendis. Doloribus qui perferendis odio ratione. Magnam atque minus. Minus rem voluptatum amet a dolorem modi. Qui quia commodi perferendis.", new DateTime(2020, 12, 4, 22, 15, 1, 104, DateTimeKind.Utc).AddTicks(1318), 13L, "nihil", "Natus explicabo repudiandae optio totam architecto sequi blanditiis.", 1L, "", 2, "repellat" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 52L, "Deserunt veritatis ad perferendis et nihil autem quia cupiditate.", new DateTime(2022, 11, 30, 15, 13, 33, 888, DateTimeKind.Utc).AddTicks(7820), 2L, "Maiores aut aliquid perferendis adipisci odio expedita ex nulla.\nIste aliquam ex repudiandae atque beatae.\nExcepturi illum et.\nCorporis quod eius vel ut repudiandae et.\nEt voluptas corrupti voluptas quaerat.", "Fugit error nihil aut veritatis quo.", 2L, "", 2, "maiores" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 34L, "Voluptatum quod sit voluptas nobis ut magni harum expedita non.", new DateTime(2022, 10, 5, 18, 50, 42, 260, DateTimeKind.Utc).AddTicks(1216), 24L, "Dicta rerum omnis voluptatem consectetur. Id et nihil. Maxime dolorem recusandae necessitatibus dolores ea velit vero laboriosam. Quaerat doloribus omnis iure rerum magnam perspiciatis necessitatibus et.", "Dolor labore numquam at praesentium ea ut aut rerum.", 2L, "", 3, "Tempora explicabo quasi esse aspernatur suscipit facere perspiciatis inventore asperiores." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 15L, "Officia neque ducimus aliquam eos.\nDolores est tempore doloremque aspernatur consequuntur autem beatae.\nQuos quo sit nulla autem hic dolore eveniet nostrum voluptatem.", new DateTime(2023, 3, 21, 1, 14, 27, 540, DateTimeKind.Utc).AddTicks(8757), 8L, "A velit laudantium cupiditate veritatis ex sunt aspernatur quidem.", "Ut consequatur laborum laudantium quos consequatur inventore.", 2L, "", 1, "et" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 14L, "Explicabo ipsa cum.\nAutem nisi voluptatem sequi aut aut nulla quod voluptas.\nFugiat harum id enim quisquam at reprehenderit beatae.\nHarum doloremque assumenda laboriosam saepe.", new DateTime(2023, 2, 15, 1, 1, 23, 940, DateTimeKind.Utc).AddTicks(9475), 34L, "Aliquid ratione quisquam molestiae ipsam commodi.", "Et eius asperiores.", 1L, "", 0, "Ut accusamus voluptas. Nesciunt repellendus expedita est perferendis dolorem earum provident distinctio. Animi quam consectetur ipsum et. Soluta vel tempore est perferendis temporibus quae. Est consequatur quis commodi ipsum veritatis in officiis et. Cum nulla rerum fuga impedit doloremque qui unde deserunt." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 38L, "Dolores sit libero inventore odit.\nNesciunt totam velit omnis ea quaerat vero est.\nVero optio consequuntur tempore est consequatur.\nOdit quia perspiciatis cumque in.", new DateTime(2023, 6, 4, 15, 40, 38, 176, DateTimeKind.Utc).AddTicks(5901), 16L, "Sit amet repudiandae unde excepturi ea et veniam veniam.\nNemo cumque ea ab.", "Dolorem vitae consequatur qui in ea animi autem.", 1L, "", 0, "Rem cumque at consequatur tempora et facilis corporis ut iste. Autem ipsum sapiente. Qui ratione et dolores quas ut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 26L, "optio", new DateTime(2023, 3, 19, 10, 6, 56, 611, DateTimeKind.Utc).AddTicks(333), 36L, "Unde animi sed et illo. Sunt iure unde fugit animi. Et dolorem sed ipsum atque reiciendis corporis blanditiis qui. Reprehenderit culpa sint impedit. Dolor maiores eius dolore repellat sunt velit labore dolores. Nesciunt libero inventore cupiditate doloribus ab quia et ab.", "Et harum dolores.", 1L, "", 0, "Id nobis dicta consequatur facilis quae deleniti eaque doloribus.\nAutem earum quos.\nExplicabo delectus expedita quisquam quam aspernatur vel animi nostrum.\nNecessitatibus itaque adipisci optio ab est pariatur." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 35L, "Accusamus animi maxime molestiae qui. Voluptas quia enim. Recusandae ea dicta numquam. Accusamus qui atque dolorum odit non quis molestias.", new DateTime(2023, 5, 28, 5, 58, 32, 149, DateTimeKind.Utc).AddTicks(4930), 2L, "nostrum", "Quos reprehenderit saepe voluptate quia ut culpa ut molestias.", 1L, "", "Quis nemo culpa voluptatem omnis minus deserunt quisquam nemo.\nCorporis rerum dolor sed omnis.\nError dolore praesentium quos quia asperiores et impedit tenetur voluptatem." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 23L, "Molestias nihil quas omnis delectus consequatur quaerat.", new DateTime(2023, 9, 1, 11, 31, 54, 275, DateTimeKind.Utc).AddTicks(634), 30L, "Officiis consequatur non natus ullam voluptatem.\nNon quaerat omnis accusantium ea provident eius sunt iste.\nCum a dicta et ratione.", "Possimus sit maxime doloribus est velit vel commodi et.", 1L, "", 2, "vel" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 65L, "quidem", new DateTime(2022, 9, 5, 6, 31, 5, 364, DateTimeKind.Utc).AddTicks(3469), 36L, "earum", "Fugiat consequatur ipsam dolore laudantium culpa accusamus fuga.", 2L, "", "Nesciunt nemo placeat.\nQui voluptatem maxime ut cumque reiciendis dolores unde." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 68L, "Doloribus laboriosam quo eligendi quidem non porro est qui magni.\nDolor optio magnam quidem qui cumque hic maxime tenetur.", new DateTime(2023, 3, 12, 8, 6, 18, 933, DateTimeKind.Utc).AddTicks(9726), 22L, "Eveniet et et in quis. Ea ut quidem eius animi. Tempora in consequatur voluptas velit cum dolore dolorum ut vitae. Voluptatem sed dolore ducimus officiis non possimus voluptatem. Voluptatibus iure quod veniam et nostrum neque. Totam non veritatis aperiam aperiam aliquam rem autem vel.", "Consequuntur vel ducimus ducimus dolor eveniet tenetur ut hic qui.", 1L, "", 1, "delectus" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 55L, "eaque", new DateTime(2022, 11, 12, 3, 48, 4, 690, DateTimeKind.Utc).AddTicks(7526), 25L, "Ut ullam et ab omnis odit vitae maiores. Maiores totam dolore voluptatem repellendus doloribus et beatae laudantium. Neque quos voluptates. Quis vel iure blanditiis dolorem mollitia.", "Vel animi placeat.", 2L, "", 1, "Debitis adipisci eaque voluptates voluptas fugiat vitae consectetur voluptates. Nihil voluptatem illo voluptatem laborum veniam hic. Architecto dolores aut quibusdam minus doloremque maxime aliquid molestiae. Ut explicabo consequuntur delectus maiores blanditiis sit quo." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 61L, "optio", new DateTime(2023, 5, 1, 4, 56, 50, 841, DateTimeKind.Utc).AddTicks(7302), 28L, "Labore reprehenderit est sint iure tenetur numquam dolor.\nQuia dolore temporibus rem suscipit excepturi dicta quas.\nOmnis cumque pariatur sapiente.\nAd dolorem autem minus in ullam quam.\nEt ullam unde molestias natus ad quod reiciendis dolor atque.\nQuia quod recusandae quia voluptas.", "Velit dolor maxime tenetur molestiae distinctio commodi.", 2L, "", 3, "Eos sit repellat et aut autem maiores sit qui." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 25L, "Nisi quos molestiae. Hic consequatur omnis voluptatem mollitia eius deserunt possimus repellendus. A laudantium delectus sed qui.", new DateTime(2022, 12, 21, 17, 23, 0, 805, DateTimeKind.Utc).AddTicks(2192), 8L, "Et veritatis voluptatem dolorum corporis qui aut quibusdam. Sunt porro id. Adipisci aliquam impedit iure saepe dolores voluptatum corporis voluptas.", "Velit repellendus ad accusamus autem facere deserunt eius illum.", 1L, "", "Aut omnis incidunt.\nEveniet doloribus eum sapiente libero vel voluptatibus et.\nPorro ea earum repudiandae sunt sint accusamus.\nReiciendis consectetur sint dicta eaque.\nMagni aliquam minima atque atque qui quis reprehenderit neque.\nQuaerat repudiandae est assumenda harum omnis numquam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 5L, "Omnis et incidunt distinctio dolor.\nDoloremque quos ut deserunt debitis et illo culpa.\nMolestiae neque voluptatem minima eligendi ducimus repudiandae.\nTempore delectus consequuntur cum aut dolor eligendi mollitia aut.\nSunt rerum amet voluptatum qui porro fugiat dignissimos.\nInventore facilis totam consequatur consequuntur error officia optio ut.", new DateTime(2023, 7, 30, 17, 30, 15, 741, DateTimeKind.Utc).AddTicks(6506), 21L, "Nihil atque molestiae. Excepturi praesentium qui alias hic sint aperiam nam pariatur nihil. Atque est error ipsa facilis fuga. Dolore eum illo voluptatem reiciendis. Dolor inventore ex minus. Accusamus mollitia fugiat.", "Dolorum molestiae reiciendis.", 1L, "", "Voluptas quidem labore iste.\nIllo maiores sit ipsam sunt repellat et delectus.\nItaque voluptas ducimus iusto id dignissimos.\nHarum vero dolor sed." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 60L, "Neque ut mollitia aut corrupti deleniti. Modi necessitatibus error corporis laborum voluptatibus eum. Laboriosam officia dolorem sed eveniet est rerum porro. Fugit molestiae sequi quasi velit cupiditate.", new DateTime(2023, 4, 5, 15, 30, 42, 238, DateTimeKind.Utc).AddTicks(9253), 32L, "In nesciunt beatae vel.", "Autem non in itaque deserunt dolorem dolores quis provident rerum.", 1L, "", 2, "Vel iusto mollitia unde dolor et voluptatem tempora.\nAtque sapiente aspernatur voluptas laborum asperiores totam aperiam.\nRem eum blanditiis et ad sint dolorem voluptas veritatis voluptas.\nVel consequatur at corrupti voluptates animi.\nQuasi autem voluptate voluptatem excepturi libero.\nIn possimus sit temporibus vel nesciunt id autem culpa et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 33L, "animi", new DateTime(2023, 3, 31, 23, 49, 16, 591, DateTimeKind.Utc).AddTicks(1911), 20L, "Fugiat reiciendis dolore dolorem pariatur iusto repellendus laborum veritatis. Voluptatem ut doloribus velit asperiores quam illum necessitatibus. Veniam facilis est. Et natus sed dolores ipsa. Iste blanditiis placeat. Voluptatem perspiciatis iusto mollitia provident.", "Aut est esse.", 2L, "", "Sed quia accusamus temporibus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 37L, "Aut est dignissimos. Facilis ullam maxime in quas numquam enim. Tempore et natus dolorem veniam sapiente mollitia hic ratione quia. Consequatur consectetur quibusdam nemo et et et. Maiores eligendi velit iusto eum voluptatem molestiae.", new DateTime(2022, 12, 16, 1, 39, 55, 692, DateTimeKind.Utc).AddTicks(6763), 30L, "Sapiente voluptatibus delectus est recusandae neque rerum aut.\nMaiores harum esse nulla doloribus dolore suscipit alias expedita quis.\nRem et qui tempore ex.\nMolestiae commodi modi magni dicta explicabo assumenda veritatis.", "Doloribus consequatur voluptate eum perspiciatis temporibus illo eveniet.", 1L, "", 1, "Officia et quae sed." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 69L, "Et ipsum voluptatem provident magnam exercitationem quam quaerat id ad.\nAut ut ut est repellendus est qui illo.", new DateTime(2022, 10, 21, 16, 5, 8, 906, DateTimeKind.Utc).AddTicks(7305), 19L, "Nulla labore dolore voluptatem. Dicta quia distinctio mollitia et consequatur voluptatem maiores. Commodi dicta omnis deleniti optio. Reiciendis eos et provident laborum provident assumenda nulla ut ut. Id consequatur eos. Voluptatem quos aliquam fugit porro eligendi aut.", "Illo tempora et nulla sint molestias odio sit laboriosam.", 1L, "", 3, "Laudantium velit et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 56L, "Voluptatem ea eligendi.", new DateTime(2019, 8, 24, 5, 47, 50, 472, DateTimeKind.Utc).AddTicks(4945), 17L, "tempora", "Tempore vel nihil voluptas incidunt earum dolor maiores qui quo.", 1L, "", 3, "Eveniet nulla id laboriosam.\nCupiditate commodi voluptatibus magnam explicabo consequatur libero.\nRatione praesentium aut ipsum officia unde magnam autem.\nSapiente officia odio dolor voluptas perferendis.\nSit amet nihil sed harum similique." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 58L, "beatae", new DateTime(2020, 8, 16, 16, 46, 28, 421, DateTimeKind.Utc).AddTicks(4044), 32L, "Distinctio omnis quia. Ducimus hic est ea itaque ut ullam molestiae nobis. Maxime repellat id autem quae aut reiciendis nihil.", "Vitae quia repudiandae perferendis ut rerum sint amet.", 2L, "", 0, "Aut voluptatem ut consequatur soluta aliquid.\nSint et iure totam veritatis in ut.\nVoluptas aut est nulla consequuntur qui aut.\nCupiditate voluptas in quis aut qui.\nNisi libero aut.\nUt beatae et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 67L, "Impedit fuga beatae illum necessitatibus ut earum autem temporibus repudiandae.", new DateTime(2023, 4, 6, 3, 55, 21, 132, DateTimeKind.Utc).AddTicks(4499), 36L, "Quis fugit ullam incidunt numquam consequatur omnis reiciendis aperiam. Vel nesciunt magni ut. Aliquid eveniet voluptatem porro.", "Necessitatibus et voluptate eum iusto autem.", 2L, "", 1, "Ut laboriosam inventore non fugit. A consequatur aliquid. Est eligendi quia sint odio earum totam asperiores." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 40L, "Sunt et natus inventore tempora possimus cumque eveniet quasi adipisci. Voluptatem et fugiat. Architecto aut minima deserunt similique tempore quia. Voluptas non ut accusamus odit provident iste quaerat.", new DateTime(2023, 6, 6, 6, 57, 6, 944, DateTimeKind.Utc).AddTicks(6451), 38L, "quisquam", "Nobis qui quas.", 1L, "", 1, "porro" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 27L, "quaerat", new DateTime(2022, 9, 6, 4, 12, 4, 27, DateTimeKind.Utc).AddTicks(5337), 32L, "Et beatae aperiam et ut delectus aut. At aliquid rerum nihil. Illo magni autem sit odio at deleniti. Odit voluptatibus debitis quaerat autem.", "Nihil facilis enim et.", 2L, "", 2, "Voluptatum modi quaerat placeat et sint dolores.\nConsequuntur doloribus rerum mollitia consequatur sint itaque ut.\nVoluptate fugit labore quas dolores nisi alias.\nMagnam provident quam et necessitatibus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 9L, "Eaque harum dignissimos nemo architecto et qui in ullam assumenda.", new DateTime(2022, 12, 30, 5, 22, 10, 34, DateTimeKind.Utc).AddTicks(207), 7L, "ut", "Est vitae ducimus.", 1L, "", 3, "in" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 32L, "Illo fugit recusandae explicabo cupiditate est. Voluptatum voluptatibus aut voluptate ipsum minima blanditiis voluptas. A est quibusdam voluptatibus tempore saepe. Rerum consequatur sint harum nisi maxime et ipsa rem.", new DateTime(2023, 9, 1, 11, 52, 46, 536, DateTimeKind.Utc).AddTicks(1158), 18L, "Quasi dolor inventore.", "Sequi est deserunt.", 1L, "", "Accusantium laudantium sed dolore officia impedit similique. Facilis porro et rerum ea aliquam cum est maiores quia. Omnis nesciunt sit quae veniam id. Aliquid qui omnis voluptas itaque quis est vero illum sit. Commodi quia ad aut aut eos ipsum sit aperiam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 6L, "Ut et odio distinctio saepe. Delectus neque tempore amet adipisci debitis aut. Cumque voluptatem distinctio assumenda impedit quidem quo. Quam quia animi quo quisquam deserunt repudiandae ut animi. Reprehenderit voluptas et est est. Rerum iusto sit veniam dolor magnam.", new DateTime(2023, 5, 1, 8, 49, 23, 905, DateTimeKind.Utc).AddTicks(2358), 3L, "et", "Sint facilis laborum ea quo quis.", 1L, "", 1, "Illum architecto repudiandae explicabo quia id ipsum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 31L, "Ad nemo iste fuga ipsum fuga inventore voluptatem facilis soluta.", new DateTime(2023, 8, 6, 13, 5, 14, 270, DateTimeKind.Utc).AddTicks(2097), 24L, "Quisquam eveniet quo rerum consequatur et est repellat aperiam quaerat.", "Quis dolore voluptate officia itaque atque quaerat voluptas molestiae laborum.", 2L, "", 1, "Dicta magnam laboriosam consequatur optio suscipit aliquid eum provident sapiente. Assumenda nam natus. Iste enim maiores." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 57L, "Nisi occaecati at molestias veritatis alias laudantium suscipit. Suscipit ipsum minima consectetur esse reprehenderit natus temporibus. Aliquid autem ad ut est blanditiis architecto impedit.", new DateTime(2023, 4, 12, 9, 17, 52, 382, DateTimeKind.Utc).AddTicks(4590), 4L, "Sit aliquid modi aliquid ut sint. Voluptas ab perferendis odit beatae. Sunt totam velit nobis velit. Natus delectus enim dolorem quod quas et. Asperiores cumque fuga necessitatibus error ut ab et velit aperiam.", "Et qui incidunt minima.", 1L, "", 1, "Possimus sed sit libero sequi quos molestiae a in fuga. Sunt et alias sunt ratione enim distinctio vel non quo. Harum omnis quaerat totam beatae voluptates. Et ex quia eum quam recusandae. Voluptatem est eaque molestiae." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 36L, "Excepturi ducimus ipsa nihil maxime.\nAtque nulla sed iste ipsam veritatis nihil.", new DateTime(2022, 5, 11, 13, 53, 47, 957, DateTimeKind.Utc).AddTicks(6898), 25L, "Enim autem error animi quia rem exercitationem ut nam sit. Ducimus qui enim et. Autem sed consectetur fuga accusamus. Omnis enim est voluptas est id debitis aperiam.", "Nesciunt quisquam nisi et error.", 1L, "", 1, "perspiciatis" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 46L, "Natus sequi placeat. Est rerum dicta animi dolorem exercitationem. Veniam cumque est sunt harum voluptas expedita explicabo temporibus eveniet.", new DateTime(2022, 7, 11, 8, 23, 40, 723, DateTimeKind.Utc).AddTicks(875), 14L, "Aperiam qui asperiores temporibus id impedit dolores animi.", "Temporibus voluptates quia sunt consequuntur omnis eos laudantium est.", 2L, "", "Autem et dolores sunt consequatur sunt.\nVero soluta voluptas ipsa est veniam facere.\nQuo occaecati vel repellat quos sint ipsa officiis odio.\nIncidunt dolorum aperiam expedita quis aut rerum libero." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 57L, "Totam omnis velit enim expedita nesciunt illo.", new DateTime(2023, 4, 25, 23, 52, 21, 288, DateTimeKind.Utc).AddTicks(576), 4L, "Deserunt non ut. Itaque nostrum minima corrupti. Ex aut voluptatibus consequatur maxime. Esse quia voluptas.", "Eum enim vitae cum doloribus perspiciatis placeat maxime inventore.", 1L, "", 1, "Sunt cupiditate voluptatem voluptatem dolor dolor odio earum autem. Aut non tempora ad aspernatur. Quia soluta quod." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 47L, "Fuga nulla ratione distinctio corporis perferendis cupiditate iste et laudantium. Delectus temporibus rem reiciendis sunt. Vel sint excepturi voluptas quo perferendis. Est provident recusandae. Id qui voluptatem. Magnam quam qui et neque qui sapiente veritatis quia.", new DateTime(2022, 1, 13, 18, 44, 33, 361, DateTimeKind.Utc).AddTicks(7970), 27L, "et", "Quia et non et tenetur autem aliquam ut provident corrupti.", 1L, "", 0, "Praesentium vero nam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 53L, "Qui autem qui ut quo quis. Inventore voluptate nisi at qui laboriosam hic omnis iste tempora. Quis accusantium qui quasi ea facilis in tenetur facere et.", new DateTime(2020, 8, 30, 12, 43, 9, 257, DateTimeKind.Utc).AddTicks(3103), 12L, "consectetur", "Nam repellendus eum et perferendis.", 2L, "", 2, "explicabo" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 49L, "A porro accusantium ad voluptas doloremque in illo id placeat.\nEt qui omnis et dicta delectus.\nNon distinctio voluptatum deserunt iure.\nEt voluptates doloremque in aut animi.\nCumque dolorem iusto asperiores eaque est illum magnam aut.\nEt qui vel eveniet illum ipsum consectetur dolor recusandae.", new DateTime(2023, 8, 22, 6, 3, 0, 883, DateTimeKind.Utc).AddTicks(896), 29L, "alias", "Hic autem sit eius aliquam.", 2L, "", 2, "Quos neque corrupti commodi sit omnis doloremque recusandae repellat qui." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 22L, "Id voluptas in architecto ut officiis.\nDistinctio hic harum nihil.\nRepellendus voluptatem aut ut.\nEos debitis non qui laudantium nihil animi dolorum aut.", new DateTime(2023, 1, 6, 9, 57, 42, 59, DateTimeKind.Utc).AddTicks(4576), 15L, "eveniet", "Enim voluptatem veritatis aut accusamus omnis qui.", 2L, "", 2, "Recusandae repudiandae possimus aut id. Sequi nihil ut et. Deleniti perferendis possimus. Officiis dicta commodi quod." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 3L, "Quisquam hic magnam. Consequuntur hic unde ut. Qui qui consequuntur impedit quis qui. Quod eos autem qui aliquam animi inventore.", new DateTime(2023, 7, 25, 19, 37, 25, 188, DateTimeKind.Utc).AddTicks(6163), 13L, "Est et quia non molestiae iure architecto possimus architecto atque. Officiis aut optio natus cupiditate ipsam ipsa deleniti est sit. Nesciunt ex id unde mollitia et quia quia tempore voluptatibus.", "Quam et blanditiis et asperiores.", 1L, "", "Id dolorum sint velit et expedita facilis quod esse et.\nSit et inventore aliquid est dolorem debitis rerum nesciunt.\nMagni quasi et quas vero ducimus aut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 41L, "rerum", new DateTime(2023, 6, 15, 4, 55, 25, 272, DateTimeKind.Utc).AddTicks(613), 29L, "Est autem temporibus dolorem unde et vel voluptatibus in.\nMolestias et fugit rem dolorum sunt voluptatem veritatis qui.\nPossimus nisi veniam quis sapiente debitis.\nQuod nihil hic.\nQuas est natus labore quae.", "Nihil iure facere sed similique cum animi quaerat ut.", 2L, "", 2, "Non minima ut impedit." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 37L, "quia", new DateTime(2022, 2, 28, 1, 11, 42, 671, DateTimeKind.Utc).AddTicks(8265), 28L, "Dolorum qui expedita autem expedita quaerat expedita esse.", "Nobis corrupti porro cumque eius distinctio enim.", 1L, "", 2, "Explicabo ut explicabo quam.\nTempore temporibus quasi minima.\nBlanditiis consequatur quidem omnis incidunt sunt dolores odio." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 27L, "Inventore aperiam impedit et libero. Quod eligendi rerum voluptatem mollitia id. Est ullam voluptas hic sit quis rerum voluptas repellat est. Magnam vitae voluptatem et ipsam veritatis deserunt omnis dolorem. Animi omnis hic adipisci maiores maiores eligendi dolorem quod. Et dolor sint commodi expedita esse molestiae.", new DateTime(2022, 11, 14, 4, 10, 58, 717, DateTimeKind.Utc).AddTicks(5887), 23L, "Impedit ut tempore ut ut et aperiam vel. Qui similique ducimus et ut et. Consequatur aliquid sed. Libero at sequi quia harum aut perferendis. Nisi sit ut dolorem rem sit at culpa. Repudiandae rem eaque.", "Totam ut tenetur dolor autem ut.", 2L, "", 2, "Sunt veritatis quaerat repudiandae. Qui dolorem quia autem qui natus illum omnis ratione. Sed illum possimus. Iure rerum itaque. Dolore quia rem similique ut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 27L, "At vitae laudantium animi minus atque exercitationem aperiam iure iste. Reiciendis id sed eius ut blanditiis. Vitae vel exercitationem incidunt officia eum ratione totam id commodi. Illum porro voluptas dolorem numquam repellat et rerum ipsam id.", new DateTime(2023, 7, 6, 5, 11, 54, 59, DateTimeKind.Utc).AddTicks(5254), 1L, "Quaerat eos qui cupiditate voluptas hic doloribus in.\nHarum officiis in quia enim architecto ab similique cum.", "Suscipit ad autem laudantium velit unde.", 2L, "", 0, "Labore perferendis aut excepturi mollitia.\nNesciunt error maxime libero.\nQuos tempore fuga dolores quidem blanditiis ut maxime recusandae.\nSimilique quo beatae consequatur." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 7L, "Iusto corporis id.\nUt neque quisquam harum sint dolor qui.", new DateTime(2020, 4, 23, 18, 46, 15, 545, DateTimeKind.Utc).AddTicks(5434), 2L, "Quod porro aliquam minima libero porro est voluptas ipsam in.\nNon quibusdam sed assumenda consequatur rem occaecati suscipit sint qui.", "Consequatur iste amet tempore quia eveniet.", 2L, "", 0, "Qui voluptas quos temporibus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 6L, "Vero sint reprehenderit a voluptatem.\nDolorem necessitatibus mollitia harum a fugiat voluptatem.", new DateTime(2023, 5, 12, 15, 24, 9, 640, DateTimeKind.Utc).AddTicks(8549), 17L, "labore", "Eum nisi dolor iure iure similique aspernatur corporis.", 2L, "", 3, "Et sequi repellat et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 32L, "quae", new DateTime(2023, 8, 26, 5, 19, 16, 623, DateTimeKind.Utc).AddTicks(4622), "Sit dicta ut.", "Similique ea optio.", 1L, "", "Illum quia eos nihil similique qui voluptatem atque. Accusamus molestias nesciunt. Non tenetur earum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 40L, "Dolores nostrum sunt veritatis quidem. Odit et architecto. Reiciendis saepe ea voluptate possimus molestiae a earum veritatis qui. Cum voluptas et et eos dolorum. Id a harum veniam sint at blanditiis.", new DateTime(2023, 1, 17, 4, 43, 9, 293, DateTimeKind.Utc).AddTicks(5636), 10L, "adipisci", "Non eveniet in voluptates debitis.", 2L, "", 0, "Vel repellat nesciunt.\nQuis fuga sed est eveniet.\nQui voluptatum tenetur.\nVel quia voluptatibus illum delectus voluptas repellat dolores laudantium cupiditate.\nSed veniam optio vel molestias hic." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 9L, "Consequatur optio totam enim.", new DateTime(2022, 1, 28, 9, 6, 18, 526, DateTimeKind.Utc).AddTicks(4525), 26L, "Ea provident modi.\nSuscipit in at voluptatibus quia porro nisi necessitatibus quia.", "Cumque ipsa blanditiis et quas.", 1L, "", "Ea doloremque rerum provident harum voluptates aliquam nisi. Incidunt reprehenderit ipsum eaque minima voluptatem autem. Delectus reiciendis sint voluptatem quis ut aliquam sapiente dicta. Aut qui tempora et rerum. Nihil autem eveniet cum non." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 40L, "Optio modi commodi necessitatibus.\nEt facere ipsam ea et nobis.\nMagni voluptatem molestias quisquam placeat consectetur.\nCum voluptate quae.", new DateTime(2023, 3, 18, 21, 27, 56, 809, DateTimeKind.Utc).AddTicks(7770), 21L, "Dignissimos alias nam est vel quisquam est voluptatem enim.", "Culpa qui possimus minima dolorem facere at.", 1L, "", 1, "Et animi aliquam inventore aspernatur deleniti repellendus. At fuga dolores reiciendis alias. Excepturi ea quia tempora earum eos aut perferendis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 48L, "quod", new DateTime(2023, 6, 14, 14, 40, 27, 589, DateTimeKind.Utc).AddTicks(4464), 1L, "sed", "Voluptatem eveniet fugit ad rerum.", 2L, "", "Ipsam ut qui sit consectetur voluptate.\nOdit atque et explicabo vel dolor omnis dolores aut ut.\nDolorum explicabo non eos sint et temporibus sapiente.\nQuod at possimus cumque aliquam consequuntur fugit dolores atque eum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 37L, "Consequuntur dignissimos veniam.\nVoluptatem ut incidunt incidunt esse voluptatem.\nEst repudiandae voluptas nobis et.\nEst ratione asperiores.\nEst quam perferendis voluptas enim quo qui.", new DateTime(2022, 9, 4, 7, 56, 49, 791, DateTimeKind.Utc).AddTicks(2715), 21L, "Et consequuntur nobis eum ipsa dolorem molestiae aut necessitatibus iste.\nEarum exercitationem qui consequatur et expedita molestias.", "Suscipit quisquam error eos.", 1L, "", 3, "molestiae" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 28L, "dolor", new DateTime(2022, 9, 26, 19, 20, 49, 905, DateTimeKind.Utc).AddTicks(674), 18L, "Velit et quas voluptas.", "Enim laborum quae.", 2L, "", "Veritatis quod veniam porro repellat ut perferendis. Modi voluptatibus nam explicabo saepe quasi. Perspiciatis ut et officia sint fugit tempore. Aut est nam natus. Quia id incidunt ut error reiciendis. Omnis ducimus est et quam dolores consequatur exercitationem quibusdam at." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 22L, "Sint consectetur asperiores explicabo optio voluptatem dolorem. Odit autem in quaerat voluptatem sed. Commodi dolorum saepe magnam molestias. Ut corrupti aut ad culpa ipsam. Et facilis vel quae sunt at non aut. Voluptate ratione eum.", new DateTime(2023, 4, 22, 11, 50, 11, 32, DateTimeKind.Utc).AddTicks(9838), 30L, "Eos repudiandae aut.", "Ipsum quasi suscipit tempore officia ea atque.", 2L, "", 0, "est" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 58L, "Laudantium error ex dolorem voluptate quia aliquid. Non placeat quam veniam nulla. Rem accusamus commodi omnis. Iusto soluta ut eius perspiciatis quo qui.", new DateTime(2019, 12, 30, 12, 37, 20, 355, DateTimeKind.Utc).AddTicks(1895), 13L, "Quos ipsa sed dolorum quisquam nihil voluptatum. Ut voluptatem dicta laborum eum aperiam rem placeat. Vel laudantium accusamus harum libero. Reiciendis dolores nobis.", "Aliquam aperiam autem cumque voluptatibus illum sed.", 2L, "", "Officia accusantium repellat. Magni et qui repellendus placeat qui voluptatum sapiente recusandae. Voluptas vitae ut consectetur neque tempora aut. Nisi quia maiores fugiat natus nisi." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 3L, "Nulla a quis. Dicta consectetur delectus ut blanditiis a dolorem. Modi corrupti aperiam facere et quam ipsa repudiandae aut amet.", new DateTime(2023, 7, 4, 4, 45, 0, 672, DateTimeKind.Utc).AddTicks(1138), 14L, "A molestias nihil dicta. Voluptas illo est nostrum repudiandae expedita eum labore a architecto. Impedit ut vitae et ut dicta enim velit. Consequatur nisi non non est. Modi qui rerum deserunt quas aperiam. Ut provident aut beatae.", "Nihil aut maiores et minus voluptates quia expedita dolores voluptatum.", 2L, "", 2, "Perferendis praesentium aliquam aut autem nesciunt at.\nHic nostrum est eum enim non fugit qui fuga." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { "consectetur", new DateTime(2022, 4, 15, 5, 32, 29, 108, DateTimeKind.Utc).AddTicks(3502), 13L, "Laboriosam ea laboriosam nobis optio quisquam ut. Reprehenderit commodi eaque aliquam ut veritatis est velit eligendi. Maiores similique est saepe dignissimos sit ut ullam consequatur.", "Eos eum et vitae aut.", 1L, "", 3, "Omnis sed dolores nulla. Occaecati molestiae et et aliquid commodi similique optio ut. Omnis cumque necessitatibus quas ut error delectus modi." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 4L, "minima", new DateTime(2022, 6, 11, 13, 8, 56, 911, DateTimeKind.Utc).AddTicks(6412), 3L, "Et autem ullam perspiciatis aut dolores enim dignissimos. Et sunt et quaerat quis aperiam maxime similique. Voluptatibus sapiente est error. Quaerat perspiciatis ullam. Ut inventore nihil autem amet iusto possimus iusto. Nulla aperiam dolorem aperiam non corrupti voluptatem sint sit aspernatur.", "Corporis dolor accusantium explicabo delectus expedita facilis ullam necessitatibus.", 2L, "", 0, "Dignissimos fuga commodi enim et consequatur quas vero.\nA consequatur laboriosam in ex ut.\nCulpa quae provident deleniti.\nAut qui odit est dolores nisi ut et maxime dolorem." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 51L, "Enim ut consectetur.", new DateTime(2022, 9, 12, 19, 17, 32, 197, DateTimeKind.Utc).AddTicks(1161), 21L, "Dolorem tempora aperiam iure et esse omnis. Distinctio omnis officia aspernatur dolores atque maxime in. Exercitationem minima quia sed. Ea voluptates nulla. Maiores blanditiis nemo nesciunt magni maxime repellat corrupti esse aut. Quo dolorum eum error.", "Quo earum sint ea suscipit ipsa repellat qui fugiat aperiam.", 1L, "", 1, "Ut provident veritatis rerum.\nUt velit cupiditate labore ducimus quam est alias alias.\nVero ut dolores quo architecto iste et.\nCulpa sed quia.\nSed et fugit.\nAutem sed sunt sequi rerum accusamus saepe consectetur soluta rerum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 6L, "Perferendis quia dolorem consequuntur perspiciatis et molestiae aspernatur.\nQuas est nulla aut aut et.\nIusto nihil tempore ducimus natus voluptas voluptas aut voluptate.\nQuod animi nemo optio laborum voluptatum non ipsam rem.", new DateTime(2023, 8, 13, 13, 59, 45, 827, DateTimeKind.Utc).AddTicks(4902), 28L, "Non dolor expedita tenetur eos quia vel quia quia.", "Iure voluptatem laborum perspiciatis.", 2L, "", 0, "Perferendis ipsum alias ea." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 32L, "Et nihil aliquam libero ipsa explicabo et fugit consectetur. Fugiat animi ad molestiae occaecati quos dolores consequuntur adipisci. Et ullam exercitationem esse consequuntur in cum magni voluptatem. Voluptatem dolorem animi unde voluptas facere et. Ipsa accusantium amet cum expedita.", new DateTime(2023, 9, 1, 11, 40, 41, 345, DateTimeKind.Utc).AddTicks(3496), 7L, "Beatae labore magnam ad dolorem nihil voluptate est atque quam.\nNesciunt ducimus tempore aut nisi est.\nLaborum voluptate officiis rerum numquam sunt.\nDucimus porro ratione animi.\nExcepturi error omnis itaque error sunt.\nIn sed odit omnis.", "Quisquam facere debitis dolorem temporibus eligendi necessitatibus ipsum quidem.", 1L, "", 0, "Omnis et quia in tempore. Officia facere enim ipsam magni voluptas ut. Quam consequatur quibusdam culpa qui libero. Est neque assumenda et consectetur dicta ipsum mollitia qui rerum. Dolores at accusantium consequatur a. Itaque sint in pariatur minima ducimus dolorum accusantium voluptas in." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 6L, "neque", new DateTime(2023, 5, 10, 5, 1, 51, 596, DateTimeKind.Utc).AddTicks(6347), "Inventore et vero vel. Aut porro aspernatur aut ut quas vero. Sit quia recusandae blanditiis dolorum rerum voluptas sint. Autem similique consequatur non consequuntur.", "Est illum nobis beatae eos asperiores velit aut iusto.", 1L, "", 1, "autem" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 6L, "Aut qui delectus ut quos omnis veniam magnam.", new DateTime(2023, 8, 3, 5, 21, 4, 938, DateTimeKind.Utc).AddTicks(3641), 15L, "Beatae vel facilis officiis ipsum at.", "Reiciendis in amet corporis enim.", 2L, "", 0, "Possimus ipsa non aliquam quo provident quis perferendis. Voluptatibus facilis perferendis expedita ea eum error. Repellendus recusandae harum ratione ullam veniam tempora sit." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 43L, "Doloribus provident totam.", new DateTime(2023, 9, 3, 5, 48, 16, 839, DateTimeKind.Utc).AddTicks(5847), 40L, "Aut explicabo aut sunt reiciendis voluptate iusto. Quibusdam temporibus quas commodi. Voluptatibus tempore saepe nesciunt recusandae neque ut dicta. Vel qui cumque enim.", "Et perferendis exercitationem id soluta blanditiis sunt enim.", 2L, "", 2, "Blanditiis omnis nihil molestiae suscipit inventore non. Recusandae odit voluptatum neque. Suscipit nemo sed doloremque aut minima et pariatur natus. Est omnis quasi aut ut qui aut. Quia aliquam voluptatem et ipsam distinctio." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 57L, "Aliquid harum consequatur quia aperiam est ipsa cupiditate enim. Quisquam nesciunt qui harum dicta molestias error. Voluptatibus officiis impedit quas dolorem dignissimos aut dolore.", new DateTime(2023, 6, 6, 13, 17, 37, 803, DateTimeKind.Utc).AddTicks(4469), 15L, "Ut numquam expedita.\nHarum voluptatem repellat fugiat vel animi libero dolor.\nIpsa omnis nesciunt vitae.", "Facere nobis vel possimus.", 2L, "", "Asperiores dolorem sint dolores consequuntur eos vel." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 66L, "officia", new DateTime(2021, 12, 6, 3, 53, 52, 578, DateTimeKind.Utc).AddTicks(7225), 27L, "dolor", "Et non odit tempore qui.", 1L, "", "Et consequatur assumenda eius. Accusamus aut ducimus aut et tempore rerum illum sint debitis. Delectus inventore delectus eum voluptates. Iste aut modi numquam non aliquid velit quibusdam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 17L, "Non at dolorum. Et consequatur rerum asperiores placeat. Blanditiis aperiam dolor sed saepe.", new DateTime(2023, 3, 9, 12, 30, 2, 73, DateTimeKind.Utc).AddTicks(2218), 23L, "Dignissimos quas delectus dolores voluptatem eius suscipit incidunt beatae. Nisi quis odit explicabo ipsa blanditiis voluptatibus. Voluptas a voluptatem eligendi odit veritatis aut ad. Magnam praesentium eligendi consequuntur est rerum. Assumenda et et. Similique quibusdam quaerat rerum sapiente voluptatem cupiditate.", "Sed voluptatibus repellat sint reprehenderit ea distinctio atque impedit amet.", 2L, "", 1, "Velit aliquid accusantium itaque.\nEum doloribus nemo velit modi id quas nisi iste consectetur.\nOptio non mollitia laborum hic et quia hic.\nFacilis perspiciatis aut numquam sequi.\nPossimus fugiat perferendis mollitia accusamus eaque deserunt accusamus temporibus.\nQuos laborum nam aliquam et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 41L, "Voluptas maiores omnis dicta est eum odio eligendi facilis quasi.", new DateTime(2022, 3, 15, 0, 52, 40, 834, DateTimeKind.Utc).AddTicks(3500), 35L, "Corporis quae inventore soluta magnam quam iste.\nCumque molestias sit quaerat eveniet exercitationem qui aperiam quia et.", "Sunt nam earum non facere.", 2L, "", 3, "Et ea aut provident cumque soluta." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 64L, "Labore pariatur voluptatem nemo.", new DateTime(2020, 10, 22, 3, 24, 46, 319, DateTimeKind.Utc).AddTicks(7153), 8L, "Impedit rerum error nemo magni possimus veritatis occaecati dolores non.\nSequi quas cumque dignissimos necessitatibus voluptatibus et cumque molestias.\nPariatur praesentium distinctio.\nHic provident enim facilis suscipit assumenda nisi laborum optio quia.\nMollitia assumenda ab quibusdam at hic quidem quo aperiam accusamus.\nNam culpa ab quisquam et qui blanditiis autem vero.", "Sit omnis repudiandae.", 1L, "", 1, "Earum cumque ea." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 67L, "ducimus", new DateTime(2023, 8, 8, 14, 15, 36, 675, DateTimeKind.Utc).AddTicks(4871), 30L, "Facilis id ad amet eaque ea aspernatur veniam. Eveniet rerum eum ut ipsam aut animi. Culpa voluptas mollitia et id quibusdam veritatis et voluptatem. Rerum fugiat aut ea id ex magnam dolorum eligendi. Enim eum numquam sapiente temporibus molestiae. Dolorum earum explicabo.", "Debitis neque omnis totam ut aut culpa provident exercitationem.", 2L, "", 0, "Numquam placeat et consequuntur. Et eligendi deserunt laborum. Cupiditate nesciunt et ut molestiae eligendi blanditiis accusamus sunt. Architecto voluptatum tenetur. Voluptas repellat dicta ab possimus quas blanditiis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 70L, "Odio quos nisi accusantium et eligendi.\nSit corrupti placeat fugit harum minima.\nQuod dignissimos vero illo consequatur eligendi soluta commodi non.\nVoluptatem nam quo.", new DateTime(2023, 6, 23, 1, 21, 33, 208, DateTimeKind.Utc).AddTicks(3401), 15L, "Delectus sit officiis. Voluptatibus et aut animi consequatur atque magni earum quia dolor. Itaque laborum non voluptatem. Aut in provident culpa ex dolorum omnis odio. Aut inventore id similique velit. Rerum ipsa blanditiis aspernatur rerum repellat distinctio.", "Quia officia et earum non iure necessitatibus.", 1L, "", 1, "Earum harum quas laboriosam corrupti natus ad sint dignissimos beatae. Aut quaerat consequuntur voluptatum sunt nemo explicabo. Assumenda non fugiat sunt." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 7L, "Aut error quibusdam.\nEt ea aspernatur sed dolore.\nNihil reprehenderit autem repudiandae qui modi eveniet nesciunt.\nVoluptatem quo odio vitae ut eos doloribus pariatur sed.\nVoluptas necessitatibus velit quia molestias iusto doloremque ratione placeat.", new DateTime(2021, 2, 4, 0, 44, 44, 786, DateTimeKind.Utc).AddTicks(3411), 1L, "Quasi eum mollitia assumenda sequi ut. Rerum officia amet modi modi omnis recusandae. Natus omnis consequuntur vel rerum ullam unde qui est.", "Animi deserunt eius.", 2L, "", "Praesentium esse dolorum sunt ab doloribus vero iusto autem. Veritatis illum aliquid aliquid provident atque quaerat nesciunt. Excepturi error optio deleniti consequatur aut enim et. Omnis beatae ratione suscipit explicabo voluptatum. Accusantium praesentium delectus dicta alias." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 57L, "voluptate", new DateTime(2023, 9, 5, 19, 56, 16, 583, DateTimeKind.Utc).AddTicks(6097), 5L, "ad", "Quidem occaecati totam.", 1L, "", "Impedit sunt alias adipisci natus voluptatem accusamus. Corrupti sunt est voluptate enim. Est numquam neque cupiditate aut officiis necessitatibus inventore qui non. Occaecati unde cumque facere cupiditate cupiditate fugiat." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 65L, "Architecto rerum debitis perspiciatis laborum. Dolor voluptatum animi ipsa animi dolorem et delectus. Vel voluptatem eaque praesentium et sit illo. Cupiditate sit enim ducimus voluptatibus sequi nihil. Repellendus temporibus et ducimus rerum a animi distinctio omnis. Voluptate quas rerum reiciendis est sed facilis pariatur.", new DateTime(2022, 3, 11, 4, 56, 44, 688, DateTimeKind.Utc).AddTicks(1778), 39L, "Iusto dicta laborum distinctio nesciunt enim sed.", "At dolorum laborum esse quis rerum omnis.", 1L, "", 2, "Corporis aut et sit ut aliquid cupiditate nisi.\nAdipisci voluptatem saepe veniam.\nAutem alias sint molestiae at distinctio autem cumque ipsum.\nOmnis deserunt unde sit voluptatem et dolores mollitia vitae doloremque.\nSoluta culpa molestiae nostrum id beatae." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 32L, "Est consequatur aliquam.", new DateTime(2023, 8, 13, 20, 16, 49, 22, DateTimeKind.Utc).AddTicks(9560), 34L, "Iure sit aperiam tempore non necessitatibus sed soluta rerum maxime. A sed et aut quia qui autem. Et voluptate dolorem et eligendi. Nostrum blanditiis eum. Ducimus sed voluptatem non eum. Quia neque id at fugiat eligendi.", "Itaque asperiores totam possimus aut adipisci adipisci.", 2L, "", 3, "Nihil sunt harum dolore qui inventore voluptatem id." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 67L, "commodi", new DateTime(2023, 1, 28, 4, 57, 44, 759, DateTimeKind.Utc).AddTicks(6554), 28L, "Id reprehenderit iusto perspiciatis iusto molestiae.\nVel impedit sapiente voluptate cupiditate non odit quo.\nLibero at voluptates consectetur aut soluta.\nDignissimos voluptas tempore reprehenderit nemo.\nEst qui aut non in a dolor perferendis voluptate.\nCumque reprehenderit et asperiores aut mollitia.", "Ducimus cumque itaque.", 2L, "", 0, "Occaecati natus ea laboriosam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 47L, "Occaecati recusandae qui nemo deserunt magni. Expedita commodi quaerat qui. Quibusdam earum est vel.", new DateTime(2020, 12, 21, 13, 13, 39, 260, DateTimeKind.Utc).AddTicks(7020), 29L, "Sint non atque.", "Atque est qui nihil illo eaque asperiores nihil.", 1L, "", "Ea fuga cum aperiam suscipit vel sed aut. Qui voluptatem nihil rerum nam asperiores perspiciatis inventore fugiat nostrum. Illum aut accusantium qui." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 8L, "Consequatur perspiciatis aut qui harum perspiciatis omnis.\nUt deleniti mollitia vero natus corporis et enim corrupti.\nAtque officiis repellat animi maiores modi cumque.", new DateTime(2017, 12, 19, 9, 28, 13, 756, DateTimeKind.Utc).AddTicks(3957), 38L, "Distinctio harum sint deleniti sint modi ut consequuntur dicta.", "Est voluptas ut aut molestiae reprehenderit nesciunt dolore.", 2L, "", 2, "doloremque" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 43L, "sed", new DateTime(2023, 8, 27, 7, 47, 4, 8, DateTimeKind.Utc).AddTicks(7943), 17L, "Qui aliquam mollitia voluptate illo eveniet ex.", "Quia maiores laboriosam et.", 1L, "", "Totam iste non.\nCulpa eligendi voluptatum sint amet eveniet et.\nVitae vel rerum vitae saepe ratione ea aut quis.\nAb praesentium repellendus ab porro.\nNon corporis quod asperiores et corrupti perferendis ea aut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 67L, "Dolore et mollitia consequatur. Architecto atque mollitia aut unde. Officiis repellat error molestiae sapiente aut sed aut eos. Qui sit eum eum at quaerat quidem sit quam. Laborum cupiditate eveniet est iusto dolores labore. Ut nobis autem aliquam ex aut.", new DateTime(2023, 1, 5, 20, 3, 20, 631, DateTimeKind.Utc).AddTicks(8654), 15L, "Ut voluptas sed nihil vel nulla in.", "Ut et expedita amet molestias facere est non aut expedita.", 2L, "", 0, "Consectetur nisi similique et ut officiis maxime." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 10L, "Nostrum qui omnis.\nId omnis molestias.\nProvident qui nihil asperiores.", new DateTime(2022, 12, 4, 8, 47, 10, 960, DateTimeKind.Utc).AddTicks(4412), 28L, "Et molestias quis iure vel quos rerum consequatur.", "Asperiores laudantium accusamus cumque voluptas qui qui rem nam hic.", 2L, "", 3, "Nam ea porro sapiente voluptate ad ut aut asperiores.\nAut nostrum asperiores ab labore vel voluptatem beatae maxime.\nConsequuntur eaque saepe molestiae in deserunt dolor.\nMinus dolorem impedit ut et animi.\nVoluptatem ut omnis itaque autem rerum aliquid natus eius.\nAtque sint vitae nostrum sint soluta repudiandae repellendus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 56L, "Voluptatum cum et sunt beatae cumque quia illum corrupti. Ducimus sit non quia facere hic dolorem consequuntur ullam. Voluptatibus minus dicta. Aut sed quo enim laboriosam non est fugiat tempore. Sequi eum atque exercitationem id autem impedit omnis laboriosam laboriosam.", new DateTime(2018, 7, 30, 13, 31, 56, 24, DateTimeKind.Utc).AddTicks(9427), 24L, "et", "Reiciendis culpa totam qui.", 2L, "", 2, "Totam quasi tempora et ullam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 17L, "et", new DateTime(2023, 7, 21, 0, 29, 40, 466, DateTimeKind.Utc).AddTicks(8596), 1L, "Assumenda dicta impedit voluptates facere dolor quia aspernatur.", "A et eos deleniti ad.", 1L, "", "Et laudantium officiis.\nMolestias aliquid molestiae reprehenderit placeat voluptas." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 33L, "Ratione velit consequatur aliquid nulla est dolorem nemo.", new DateTime(2023, 1, 1, 23, 11, 23, 937, DateTimeKind.Utc).AddTicks(4476), 3L, "Iusto sed recusandae laborum nobis. Et laborum culpa. Ex voluptas et sint omnis eius quisquam. Ut atque consequuntur doloremque molestiae minus inventore qui impedit.", "Nulla architecto et ipsam consequatur nobis et quae corporis dolorem.", 1L, "", "omnis" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 8L, "similique", new DateTime(2021, 11, 6, 14, 6, 30, 795, DateTimeKind.Utc).AddTicks(2461), 10L, "Est sed iste nostrum voluptatem soluta. Placeat iusto illo fuga. Qui fuga quisquam veniam dolorem ea.", "Quae quis voluptatem et iusto et eos natus.", 2L, "", 1, "Velit non quae.\nVel doloribus incidunt." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 27L, "Beatae architecto qui et delectus perspiciatis.", new DateTime(2022, 10, 10, 6, 0, 43, 652, DateTimeKind.Utc).AddTicks(2246), 21L, "Explicabo qui eum a accusantium.", "Voluptatibus et dolores.", 2L, "", 1, "Voluptas qui debitis accusamus illum quaerat a qui accusantium quasi." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 4L, "Voluptas culpa quae dolore facilis aut.", new DateTime(2023, 4, 5, 0, 28, 6, 401, DateTimeKind.Utc).AddTicks(3457), 24L, "sint", "Unde voluptas ullam ex voluptatibus aut voluptatum quia vitae.", 2L, "", 3, "Et quo aut ea quaerat dolore et aut voluptatem dolorem. Ex voluptatem alias sit aut occaecati et reiciendis deserunt. Saepe laboriosam rerum est voluptatibus dolore repudiandae. Ullam ea quo rerum aliquid iure fugiat possimus itaque. Minus itaque mollitia." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 39L, "Autem veritatis tempore minima repellat tenetur aspernatur.", new DateTime(2023, 2, 10, 9, 14, 29, 470, DateTimeKind.Utc).AddTicks(6497), 8L, "Non et perspiciatis quaerat unde reprehenderit qui et hic est.\nSed sit facere.", "Consequuntur et temporibus ipsa.", 1L, "", 1, "Rem libero et.\nNisi culpa consequatur et et tenetur.\nNihil laboriosam quidem nesciunt libero velit quidem quia.\nMolestiae voluptas rerum nulla praesentium.\nUt illum id maiores dolores et sequi quas." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 6L, "Quo veritatis consequatur impedit maiores.", new DateTime(2023, 8, 23, 5, 32, 19, 69, DateTimeKind.Utc).AddTicks(2119), 16L, "Aut dolorum voluptas fuga sint ut et quia tempora est.\nSoluta beatae nostrum aspernatur iusto nihil quam.\nExcepturi aut in occaecati illum est in.\nSuscipit minus et omnis eum vitae quaerat officia repellendus.\nVoluptate ut vel cupiditate est velit.\nRerum totam voluptatem reiciendis earum quis.", "Assumenda ipsa est enim doloribus quas libero blanditiis.", 2L, "", 0, "Autem qui dolores. Molestias ut ut. Voluptate incidunt aperiam rerum qui voluptas hic molestiae. Ipsum voluptatem incidunt enim. Quisquam asperiores quos." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 21L, "Animi qui cumque ipsam ut perferendis ducimus dolorem.\nLaboriosam autem illo quia eius dolore eum reprehenderit ducimus non.", new DateTime(2023, 3, 4, 18, 13, 1, 185, DateTimeKind.Utc).AddTicks(9168), 35L, "voluptas", "Aut hic itaque sint ut laudantium dignissimos.", 1L, "", "Cumque qui illo soluta sint rem qui quo." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 30L, "Nesciunt ab omnis porro enim quo architecto.", new DateTime(2021, 2, 21, 7, 56, 42, 408, DateTimeKind.Utc).AddTicks(714), 12L, "nemo", "Et ipsam iste et ut.", 2L, "", 3, "Aut eveniet nihil est harum qui perspiciatis asperiores. Molestiae aut et possimus ut. Repudiandae unde voluptas magni autem. Quisquam enim officiis eveniet et quod facere sit quia. Sit cum animi non ut et harum asperiores eos aut. Rerum totam sint aliquam exercitationem ut consequatur ex." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 8L, "Nemo vel consequatur sint.\nUt consequatur eius beatae voluptas ea rerum suscipit sed.\nDolorem sapiente soluta laudantium aliquam omnis.", new DateTime(2019, 10, 10, 3, 20, 55, 49, DateTimeKind.Utc).AddTicks(5459), 21L, "maxime", "Facere alias quo autem vel quia itaque.", 1L, "", 2, "Debitis doloribus voluptatem numquam qui.\nNon fugiat accusantium eos incidunt maiores.\nEt sed animi illo fuga." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 10L, "sequi", new DateTime(2022, 8, 18, 15, 23, 53, 972, DateTimeKind.Utc).AddTicks(5311), 26L, "eos", "Dolore quaerat eius aut qui libero repellat et ipsa dolor.", 1L, "", 1, "Ipsam cupiditate et velit ut qui voluptatum porro." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 54L, "Sed possimus deleniti eveniet modi similique molestiae libero.\nTotam perspiciatis perferendis excepturi non sed.\nEst aliquam labore ea corrupti.\nBlanditiis deleniti ut error qui.\nEt similique qui.\nVoluptate omnis excepturi eum eum corporis.", new DateTime(2023, 2, 15, 21, 31, 5, 157, DateTimeKind.Utc).AddTicks(497), 15L, "Vitae eum facere aliquam quod dolorem minus. Voluptas a sit deserunt est. Nostrum consequatur ratione earum voluptatum eius. Nihil laborum doloribus esse sit corrupti quia quidem illo illo. Neque et est officia porro dicta rerum voluptas quaerat.", "Quia quidem aut fugiat consectetur ut et ab maxime.", 2L, "", "Dolores ad vero explicabo. Quia nam voluptatem voluptatem minima corrupti quia et non. Corporis alias omnis distinctio sed eum omnis molestiae perferendis eos. Minus perferendis minus ut totam laboriosam eum. Asperiores asperiores animi iure. Et temporibus eveniet rerum quis sapiente vitae." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 28L, "corporis", new DateTime(2023, 1, 14, 20, 34, 51, 991, DateTimeKind.Utc).AddTicks(654), 18L, "Molestiae numquam assumenda nihil explicabo. Ullam ratione a. Rerum amet et assumenda consectetur. Est neque labore. Cupiditate vel temporibus enim qui a dolore ut doloribus est. Ut non perferendis eius molestiae nihil est eum facere voluptas.", "Voluptatum aliquid voluptatum vel.", 1L, "", 1, "Autem assumenda omnis quo voluptate laboriosam laborum quo." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 45L, "Quo et nihil dolores aut dolores vel veritatis nesciunt nemo.\nAut expedita animi unde ut.\nConsequuntur omnis atque architecto consequatur.\nOdio voluptas labore vel dolor sit.", new DateTime(2023, 4, 30, 7, 23, 5, 40, DateTimeKind.Utc).AddTicks(9089), 17L, "Expedita quasi harum explicabo animi.", "Quasi numquam voluptas voluptas.", 1L, "", 2, "Nihil perspiciatis dolor id et non.\nDolore itaque dolor repellat dicta maiores blanditiis molestiae ut.\nHic accusantium porro omnis veritatis repudiandae rem.\nMaiores expedita rerum quia.\nIpsa et et maiores omnis fugit nihil rerum.\nExplicabo ea non unde exercitationem consequatur suscipit blanditiis eum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { "In sit non. Dolore sint dolorum aut eos. Enim voluptas quae voluptatibus ut et voluptate. Adipisci atque quo ut magnam ut. Animi magnam iste officiis. Praesentium deleniti et sequi beatae necessitatibus cumque id.", new DateTime(2023, 4, 27, 14, 20, 16, 224, DateTimeKind.Utc).AddTicks(5910), 27L, "Impedit sit ea aperiam non reprehenderit quia.\nUt veritatis tempora fugit quasi temporibus eum saepe.", "Quia molestiae ullam id dolores qui repellat.", 2L, "", 0, "Aut est ut maiores veniam autem debitis ipsam voluptas." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 70L, "Recusandae autem et sunt nulla assumenda ipsum placeat.", new DateTime(2023, 3, 8, 4, 43, 46, 348, DateTimeKind.Utc).AddTicks(7133), 28L, "Impedit culpa hic vel molestiae sint dolores.", "Rem aut repellat voluptatem quaerat.", 2L, "", 1, "sapiente" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 39L, "Ut maiores ut modi sit.\nQui eos quia at illo voluptatem est cupiditate.\nSunt ut voluptas voluptatum id occaecati aut omnis.\nVoluptatem velit enim.\nConsequatur exercitationem dolor itaque temporibus dolore.\nQui rerum eligendi voluptatum corporis nulla omnis natus.", new DateTime(2022, 2, 15, 5, 5, 9, 678, DateTimeKind.Utc).AddTicks(4814), 25L, "necessitatibus", "Culpa ea vero corporis eaque nam dolores.", 2L, "", 0, "Officia suscipit in laudantium voluptatem.\nSed amet vel sequi non.\nSapiente est ut eligendi at dolorem.\nSed provident cupiditate nulla sit nobis expedita quis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 28L, "voluptate", new DateTime(2023, 8, 15, 21, 19, 24, 778, DateTimeKind.Utc).AddTicks(7262), 3L, "qui", "Reiciendis officiis ut reiciendis aut id animi et cupiditate.", 1L, "", 3, "Sequi cumque id itaque suscipit qui veritatis quos dolore dolor.\nVitae accusantium exercitationem pariatur est quae et a.\nQuis qui enim pariatur accusamus eum non explicabo voluptatem.\nAd molestiae quam eius.\nVoluptatem vel tempora ad enim possimus corrupti fuga.\nIpsam est impedit nemo qui sint eos perspiciatis assumenda." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 7L, "Nobis doloremque rerum adipisci omnis provident ratione. Fuga molestias ea aut minus sequi laboriosam harum. Officiis molestiae neque quia voluptatum repellendus. Cupiditate aliquam qui inventore eveniet. Repellat consequuntur voluptatem hic vitae illo cumque eos. Ex sint minima ipsum praesentium assumenda sunt est in.", new DateTime(2021, 11, 22, 23, 59, 0, 730, DateTimeKind.Utc).AddTicks(4025), 36L, "Et similique tempore exercitationem.", "Ut ipsum aut quas minus nam consequatur natus qui.", 2L, "", "Nesciunt quo et expedita." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 64L, "Sunt et ipsa.", new DateTime(2020, 11, 13, 19, 36, 33, 956, DateTimeKind.Utc).AddTicks(4078), 1L, "Quaerat distinctio nobis officiis vel.\nTotam perspiciatis voluptate fugiat.\nNostrum hic quos in doloribus quas ipsa.\nEveniet cum exercitationem esse.", "Eligendi dolor quasi veniam recusandae.", 1L, "", 3, "Perspiciatis et atque consequatur minus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 66L, "Quibusdam corrupti neque voluptate ut perferendis autem illo aperiam.", new DateTime(2023, 1, 23, 15, 23, 33, 772, DateTimeKind.Utc).AddTicks(6676), 1L, "Modi minus laudantium. Qui asperiores qui voluptatum consequatur necessitatibus. Similique dignissimos aut amet magni. Est eveniet perspiciatis. Quia ipsam odio distinctio in laborum laborum ab autem rerum. In eligendi sunt possimus.", "Earum ex illo exercitationem modi sit aperiam aspernatur velit.", 2L, "", 0, "Eligendi deleniti nobis laborum delectus et blanditiis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 7L, "Quasi ex eos sit esse accusantium vel debitis eum. Nihil sunt magnam. Asperiores placeat provident.", new DateTime(2020, 6, 27, 20, 21, 15, 393, DateTimeKind.Utc).AddTicks(602), 6L, "Ut accusantium amet numquam iste accusamus dolorem.\nOmnis iste laboriosam tempore.\nNon quidem non.", "Libero id adipisci quia eaque qui nihil.", 1L, "", 1, "Architecto animi debitis eveniet reprehenderit ut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 37L, "blanditiis", new DateTime(2022, 4, 27, 20, 13, 24, 110, DateTimeKind.Utc).AddTicks(1125), 31L, "Rerum architecto aut modi ex sunt architecto. Est velit dolor hic vitae quas accusantium ut nam eos. Vel minus in. Soluta non consequatur reprehenderit eveniet praesentium et.", "Ab asperiores ea nesciunt ipsum.", 1L, "", "Dolor ad laboriosam ex non quia sit vel.\nEst velit reiciendis sunt possimus a iure et quis labore.\nEa sed velit magnam reiciendis adipisci.\nIn cumque aut assumenda aut vitae harum necessitatibus voluptas." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 29L, "Velit sint accusantium nobis.", new DateTime(2021, 2, 12, 14, 11, 47, 175, DateTimeKind.Utc).AddTicks(2895), 19L, "Unde blanditiis exercitationem nostrum aliquid optio dolor dignissimos dolor. Ut maiores enim. Et sapiente assumenda aut. Voluptatum odio ut quam omnis ut voluptatem sunt voluptas ipsum. Dolores est inventore repudiandae placeat sint sunt id. Laudantium est pariatur vel fugit est eaque autem.", "Eum eveniet inventore neque ut.", 1L, "", 1, "Quis tempora voluptatibus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 70L, "Rerum ut molestiae qui.", new DateTime(2022, 11, 28, 12, 48, 11, 306, DateTimeKind.Utc).AddTicks(5103), 34L, "et", "Nihil quam enim aperiam provident reprehenderit doloremque est suscipit.", 2L, "", 1, "Officiis dolorem aut praesentium facere deserunt at corporis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 1L, "Odit aut reiciendis et.\nDucimus nostrum architecto voluptate tempore eum blanditiis minus.\nNon vitae est eveniet nihil sapiente.", new DateTime(2023, 1, 1, 5, 42, 39, 86, DateTimeKind.Utc).AddTicks(4375), 6L, "Omnis fugit labore magni accusantium quasi. Tempora sit et. Nihil amet ut. Ex debitis vero laboriosam hic in recusandae ut omnis. Ut unde labore est expedita nulla qui omnis porro voluptates.", "Eos quidem quos odio aut iste non tempore vero iure.", 1L, "", 1, "Et voluptatem at voluptatem tenetur. Animi consequatur perferendis et dolores consequatur. Ut quis assumenda in necessitatibus rerum blanditiis sapiente distinctio. Voluptatem dolores nobis officia dolore corrupti sequi minima sit molestiae. Quasi est vel magni laboriosam est aut nemo illum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 31L, "Architecto consequatur qui molestiae a et facilis voluptas voluptas numquam.\nQuia possimus occaecati eos in cum.", new DateTime(2023, 8, 15, 12, 1, 19, 830, DateTimeKind.Utc).AddTicks(7801), 10L, "Velit nulla quia.", "Sed corrupti dolorem.", 1L, "", 0, "Voluptatem totam ex commodi nisi occaecati minus magni et autem." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 56L, "et", new DateTime(2020, 2, 28, 21, 45, 12, 569, DateTimeKind.Utc).AddTicks(2514), 32L, "Explicabo ipsam distinctio enim consequuntur velit libero consequuntur aliquam vero. Facilis quibusdam magnam consequatur repudiandae voluptate porro rerum molestiae nisi. In et molestiae qui quisquam. Corrupti placeat dignissimos qui veniam dignissimos veniam magni pariatur. Sed dolor dolorum reiciendis iste voluptatum nihil quibusdam voluptas dolores. Id quia dolorem sapiente sit.", "Et debitis et voluptatem provident amet quis est.", 2L, "", 2, "Sapiente voluptatum porro dignissimos odit voluptates tempora quis. Totam in eos minima voluptas et ipsa molestiae autem. Excepturi quaerat et deserunt quis aut. Suscipit ea dignissimos rerum maxime et est provident rerum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 16L, "quam", new DateTime(2022, 10, 15, 9, 21, 1, 893, DateTimeKind.Utc).AddTicks(3846), 19L, "facilis", "Est eveniet quidem molestias velit aliquid ea ex ut ut.", 1L, "", 2, "Consequatur quod aspernatur odio consequuntur corporis tempora molestias facere.\nAd fuga hic et corrupti reprehenderit illo facilis.\nQuos est laboriosam ab.\nQuasi iusto corrupti.\nDoloremque tempore cumque similique quaerat cupiditate ad." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 57L, "vitae", new DateTime(2022, 7, 15, 14, 5, 2, 318, DateTimeKind.Utc).AddTicks(3356), 20L, "quis", "Aut eos qui velit iste deleniti nulla aut omnis laudantium.", 2L, "", "eligendi" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 1L, "Ipsum molestiae nisi accusantium recusandae quae.", new DateTime(2023, 4, 28, 13, 53, 15, 480, DateTimeKind.Utc).AddTicks(5373), 30L, "Dignissimos dolore commodi. Maiores cupiditate et voluptas et aut a. Commodi voluptatibus doloremque ab aspernatur enim.", "Impedit consequatur molestiae cupiditate et placeat optio molestiae blanditiis accusantium.", 1L, "", 0, "distinctio" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 53L, "Maiores ad et eos quo. Officia voluptatem et est numquam et reiciendis quae ut asperiores. Ut in explicabo. Optio tempore voluptas et a eos maiores aut laborum. A qui ipsa repellat possimus voluptatibus.", new DateTime(2023, 5, 20, 9, 14, 58, 94, DateTimeKind.Utc).AddTicks(9571), 27L, "aut", "Odit accusantium nam aut et exercitationem quam.", 1L, "", "Nihil molestiae enim molestiae nemo est. Dolorum voluptatibus expedita. Architecto nihil excepturi totam. Animi modi rerum facere eaque. Voluptatem illum ut aliquam cum itaque quae." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 34L, "Nemo sed enim sunt quo sequi.", new DateTime(2023, 3, 25, 19, 44, 55, 404, DateTimeKind.Utc).AddTicks(8469), 14L, "Saepe sunt deleniti a.\nTempore dolorem aut voluptas reiciendis et rem aperiam vel.\nQuasi similique alias laborum eius.\nBeatae cumque sit.\nMaxime labore pariatur qui voluptatem et sunt.\nEum consequatur voluptas quia temporibus ipsa quia et necessitatibus dicta.", "Placeat provident necessitatibus voluptates et alias.", 2L, "", 3, "Voluptate illum omnis quos distinctio ab recusandae aut sunt. Est beatae sit exercitationem voluptas ut ut at est. Nulla autem animi optio esse a quisquam commodi. Sit maiores magnam vel eveniet." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 61L, "reprehenderit", new DateTime(2023, 7, 4, 5, 59, 14, 918, DateTimeKind.Utc).AddTicks(9570), 39L, "Veritatis unde libero atque est aut.", "Sit et eveniet odit harum beatae vel iure.", 2L, "", 3, "et" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 1L, "provident", new DateTime(2023, 4, 21, 5, 42, 14, 360, DateTimeKind.Utc).AddTicks(8173), 36L, "Deleniti voluptatem et. Voluptate nobis quo ratione quia totam itaque dolorum pariatur. Qui libero ullam quo facilis impedit voluptatem sed quae perferendis. Dolores laboriosam laborum neque. Autem aut quibusdam libero nihil ut quis ipsa ut.", "Amet doloribus quisquam pariatur cum velit quisquam dolorem non.", 2L, "", 0, "Nemo adipisci autem inventore in." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 31L, "Delectus minima reiciendis quam id ad nisi aut voluptatibus cupiditate.", new DateTime(2023, 4, 27, 15, 6, 23, 56, DateTimeKind.Utc).AddTicks(6366), 35L, "At eum quaerat ducimus. Nihil dolores ipsam quos quam ea et et et praesentium. Est et consequatur.", "Nulla quas quam quis nihil possimus nobis.", 2L, "", "delectus" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 67L, "Labore molestiae minima fugiat sapiente atque.", new DateTime(2023, 5, 26, 17, 13, 32, 272, DateTimeKind.Utc).AddTicks(8003), 20L, "Accusamus amet ut sapiente quae excepturi rerum. Exercitationem aut nulla. Est consequatur tempore repellendus eveniet deleniti. Aut qui non repudiandae nisi id dolores reprehenderit.", "Eum et aperiam commodi praesentium harum voluptatem quia ut sint.", 2L, "", 0, "Nihil eos cupiditate voluptatum in suscipit perferendis deleniti. Et excepturi dolorem blanditiis provident et aspernatur hic aperiam. Suscipit corporis est est dolores perspiciatis qui sed provident." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 70L, "Aut dolores quia. Quia beatae quia accusamus nam corporis. Magni blanditiis illo. Ad consequatur tempora voluptates quia tenetur aut nesciunt. Ut consectetur nostrum dolorem eaque cum voluptas.", new DateTime(2023, 9, 5, 3, 31, 57, 358, DateTimeKind.Utc).AddTicks(1566), 13L, "Laudantium aut et suscipit autem tempora perferendis repellendus sequi.", "Ea rerum quidem odit similique.", 2L, "", "Deleniti porro officia aut non inventore et veritatis quis eum.\nVoluptatum eum corporis voluptatibus commodi aut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 35L, "Aspernatur possimus ea maiores amet. Sunt doloribus aut est fugiat et vel autem. Excepturi enim voluptates tempora ullam vero aut dolores. Qui eaque soluta voluptatibus rerum. Voluptate eius ipsa consequatur optio totam et quibusdam ut neque. Maiores odio exercitationem soluta sapiente error.", new DateTime(2023, 5, 19, 15, 1, 57, 88, DateTimeKind.Utc).AddTicks(9454), 3L, "Sed rerum assumenda voluptatum temporibus sint blanditiis voluptate. Omnis occaecati sed impedit quia. Perspiciatis qui ipsum qui rerum unde aut. Iure consectetur autem. Quia aut quia id quidem. Quia inventore ea corrupti tempore sed architecto.", "In earum nobis quia optio at inventore.", 2L, "", 0, "Qui ratione nam occaecati. Doloribus quaerat ipsa aliquam ratione asperiores. Ut saepe veniam laborum sunt quis aspernatur. Eos rem earum veritatis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 3L, "sunt", new DateTime(2023, 9, 5, 13, 30, 52, 819, DateTimeKind.Utc).AddTicks(1331), 39L, "Iure voluptatem non illo voluptatem ut maxime placeat veritatis doloribus. Sit aliquid ea. Architecto sit dicta impedit similique. Sed et eum aut eum. Quo possimus consectetur ut. Ipsum ut alias.", "Iure voluptatibus dolore non sed saepe et incidunt sed.", 2L, "", 3, "Repellat labore magni exercitationem illo." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 25L, "Inventore fugit delectus labore ipsam error sit veniam eum tenetur. Voluptas voluptates asperiores officiis voluptatem saepe neque qui ea. Eaque nemo sed repellendus dolore necessitatibus. Nam quaerat illo qui. Necessitatibus cumque beatae alias accusamus at suscipit.", new DateTime(2023, 5, 14, 5, 52, 24, 500, DateTimeKind.Utc).AddTicks(389), 25L, "Neque ut nihil velit soluta enim nesciunt. Repellendus distinctio dolor non provident voluptatem. Consequatur qui adipisci iure nesciunt et culpa consequatur animi error. Quam molestiae eum ut enim et magni ut.", "Deleniti illo velit similique ab.", 2L, "", 2, "Et sed nesciunt velit corrupti sit dolor cum. Atque amet deleniti sit aut nulla blanditiis quasi cum aperiam. Quia eveniet ipsam sequi sit nostrum autem. Voluptatem nemo fugit. Repudiandae vel iure sint fuga fugiat ea." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 3L, "Et iusto quia.", new DateTime(2023, 8, 26, 8, 26, 18, 709, DateTimeKind.Utc).AddTicks(7427), 11L, "Non quibusdam et corrupti aut laborum sequi maxime et voluptas. Libero et voluptatem aut et sunt amet. Beatae dolores laboriosam est et quo accusantium aut cupiditate.", "Eos id cupiditate blanditiis aut maiores pariatur.", 2L, "", 1, "Culpa animi dolorem nulla quae at incidunt qui unde iure.\nEt asperiores quis sed ad temporibus officia et.\nAb inventore voluptates autem culpa." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 50L, "Autem quis accusantium voluptatem.", new DateTime(2023, 9, 7, 20, 44, 11, 191, DateTimeKind.Utc).AddTicks(4190), 38L, "vitae", "Quis placeat voluptatem incidunt repellat.", 2L, "", 1, "tempore" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 14L, "Et enim accusamus quis est tempora maxime eos consectetur rem.\nNihil ut fuga mollitia sint ex at dignissimos nulla quia.", new DateTime(2023, 1, 28, 21, 10, 20, 197, DateTimeKind.Utc).AddTicks(2101), 31L, "Aut amet quia omnis harum asperiores. Nisi ratione fuga. Ea ut dolorem dignissimos delectus voluptatum aspernatur rerum sit. Rem qui placeat deleniti distinctio vero temporibus aliquam animi quasi.", "Accusamus voluptatem ducimus est omnis minus.", 1L, "", 3, "Rerum et animi officiis blanditiis eius est quas id. Cupiditate impedit sit eum vel vero. Nulla quia laudantium. Est ut non." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 13L, "dignissimos", new DateTime(2018, 7, 18, 16, 54, 3, 881, DateTimeKind.Utc).AddTicks(8491), 3L, "Molestiae delectus architecto dignissimos velit animi.\nQuasi aut eos quaerat dicta perspiciatis.\nAt sed dolorem inventore consequuntur odio provident.\nIpsum ut recusandae ut.\nCupiditate eaque nihil eius velit.", "Rerum necessitatibus porro veniam ipsa ut incidunt.", 2L, "", 2, "quidem" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 37L, "Est cum quis labore quasi in laudantium veniam saepe eius.\nIpsum excepturi quia dolore itaque aperiam omnis sint veritatis.", new DateTime(2023, 5, 4, 6, 52, 28, 682, DateTimeKind.Utc).AddTicks(3837), 10L, "Sapiente in ipsam voluptas similique nesciunt voluptatem officiis. Repudiandae labore et. Exercitationem non fuga sunt. Ut sed ad voluptas nemo explicabo corrupti unde consequuntur.", "Ex quo quasi officiis repudiandae.", 2L, "", 3, "Et beatae consequatur cumque velit consequatur expedita exercitationem officia debitis.\nUnde cum sequi quibusdam aliquid rerum minus magnam minima nihil.\nTenetur nulla sit laudantium dolores." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { "Et quae expedita.", new DateTime(2023, 7, 1, 8, 38, 15, 583, DateTimeKind.Utc).AddTicks(2669), 15L, "ad", "Non repudiandae qui incidunt repudiandae officia rerum sunt voluptas cum.", 1L, "", 1, "Saepe aliquid est neque eum harum explicabo." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 61L, "Et ut illo maiores quas rem facilis.\nAb rerum non est unde minima corrupti aut quidem similique.", new DateTime(2023, 5, 3, 10, 30, 43, 595, DateTimeKind.Utc).AddTicks(5058), 12L, "Autem illum qui velit est.\nExercitationem consequatur voluptas ut illo ipsa dolores perferendis.", "Quam doloribus minima vel rerum reprehenderit distinctio adipisci.", 2L, "", 1, "Similique expedita dolorum excepturi voluptas ad.\nDolorem ut sequi perferendis ab.\nVoluptatibus quia dolorem nostrum excepturi error et qui inventore.\nNon eius minus aut blanditiis eum voluptatem et maiores.\nAspernatur vitae ipsam et voluptatum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 45L, "est", new DateTime(2023, 4, 25, 5, 3, 59, 685, DateTimeKind.Utc).AddTicks(6115), 34L, "Quo harum architecto ut accusantium.", "Sint repellendus non non.", 2L, "", 3, "Id illum omnis consequatur eum animi labore et perferendis. Inventore aut sunt ut cum sunt. Amet dicta similique qui voluptatem sit nihil voluptatem ex aut. Velit ipsum repellat ut qui natus odit. Minima cum facere velit ad quibusdam qui. Aut consequatur dolorem et provident a vitae sed est." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 63L, "Iusto tempore exercitationem expedita fuga.", new DateTime(2022, 11, 27, 18, 36, 9, 381, DateTimeKind.Utc).AddTicks(6795), 14L, "sed", "Velit non et ratione.", 1L, "", 0, "Et non voluptas architecto et sunt praesentium non." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 19L, "Perferendis eaque cumque.\nDolore nisi optio.\nDolorem iste dolorum placeat eaque rerum.\nVoluptas eaque magnam sunt itaque.\nAt et est quasi dicta repudiandae eligendi ut.\nEst culpa ad ex velit voluptatem quas nemo est eos.", new DateTime(2022, 7, 28, 7, 33, 39, 745, DateTimeKind.Utc).AddTicks(2262), 22L, "Eos error esse quaerat dolorem quae.", "Facilis non iste ullam illum a exercitationem vel iure.", 1L, "", 0, "Dicta nemo consequatur voluptatem accusamus est ut est eos sunt.\nIn nesciunt iure aut sit neque et alias voluptatem officiis.\nIpsa rem soluta placeat voluptas qui qui animi tempora." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 25L, "Ut quia eius ut suscipit culpa sed veniam.", new DateTime(2023, 1, 21, 4, 11, 27, 69, DateTimeKind.Utc).AddTicks(7872), 38L, "Molestiae exercitationem qui iste possimus laboriosam iure.\nAlias eligendi voluptatem aperiam architecto est impedit eligendi nostrum odio.\nEt cum et.", "A ipsa quidem provident nostrum corrupti.", 2L, "", 0, "ipsa" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 24L, "Impedit ut molestiae.\nIncidunt voluptatem vero velit deserunt eos id molestiae unde necessitatibus.", new DateTime(2021, 9, 22, 17, 35, 48, 441, DateTimeKind.Utc).AddTicks(618), 29L, "Et eligendi sapiente debitis voluptatem et.\nPossimus ut non enim qui sint nam iure excepturi non.\nProvident qui fugit earum id.", "Et aut eos aut distinctio eum doloremque maxime vel aut.", 1L, "", "Voluptatum voluptate fugiat explicabo laudantium fugit necessitatibus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 22L, "Ut optio totam temporibus et saepe dolore accusantium.", new DateTime(2023, 4, 4, 3, 38, 28, 56, DateTimeKind.Utc).AddTicks(604), 32L, "est", "Deserunt vitae officiis officia vero sit neque.", 1L, "", 0, "Impedit hic et quidem." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 65L, "veritatis", new DateTime(2023, 7, 19, 14, 35, 9, 391, DateTimeKind.Utc).AddTicks(5751), 25L, "Est ducimus at eos deserunt porro beatae tempore.\nTemporibus quos natus est.\nDucimus consequatur neque molestiae cupiditate corrupti necessitatibus.", "Quia et dolor autem ducimus iusto eos veritatis facilis.", 1L, "", 0, "Quo sed voluptas sit quo earum ipsam quasi." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 27L, "Repellat qui repellat totam molestiae qui iure quia.\nNisi iste porro voluptatum voluptatem magni voluptatem facilis aut vero.\nVeniam cupiditate libero aliquam expedita iusto cumque voluptas.\nOdit qui repellat inventore vero ducimus tempora dolorem sapiente mollitia.", new DateTime(2023, 2, 9, 10, 3, 7, 547, DateTimeKind.Utc).AddTicks(9502), 21L, "Distinctio nihil vel.\nVoluptatum sint quod consequatur quos odio.", "Autem fugiat modi soluta tempore.", 2L, "", "Vitae alias nulla ab eius aut fugit." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { "occaecati", new DateTime(2023, 7, 24, 23, 11, 37, 865, DateTimeKind.Utc).AddTicks(7497), 12L, "quia", "Et vel et maiores soluta esse excepturi ut.", 1L, "", 0, "Harum officia eos debitis et neque. Et qui ut enim nihil. Odit ut a impedit." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 62L, "Explicabo ut quis vero at voluptate dolores facere ea ut.\nDolorem voluptas mollitia natus provident enim.\nMinima quos laboriosam et impedit debitis dignissimos.", new DateTime(2022, 10, 22, 10, 51, 40, 800, DateTimeKind.Utc).AddTicks(3559), 10L, "perferendis", "Ex et adipisci.", 1L, "", 3, "Repellendus impedit sint aspernatur nam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 56L, "non", new DateTime(2021, 5, 27, 19, 56, 47, 125, DateTimeKind.Utc).AddTicks(7467), 28L, "Accusamus accusantium sunt. Impedit ab ut possimus asperiores qui. Qui neque praesentium et reprehenderit vel et facere fuga laudantium. Quasi dolore repellendus occaecati. Nihil ut voluptatem. Quia voluptate aut aut.", "Non et sapiente tempora qui voluptatem blanditiis.", 1L, "", 0, "Corporis impedit et deserunt eum quos esse. Et quo ipsa dignissimos dolorem facere sint. Vel cum placeat veritatis natus qui veniam et ut. Id nihil fugiat qui quaerat aut. Sint ea sed qui fuga illo quis eum corrupti atque. Iure occaecati inventore iure aut et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 68L, "Et modi laborum quidem. Quia rerum consectetur doloremque et voluptate tempore non mollitia quae. Ut neque id enim maxime. Sint recusandae qui ipsam. Quod exercitationem sapiente perferendis aliquid animi alias aliquam.", new DateTime(2023, 7, 3, 15, 30, 13, 403, DateTimeKind.Utc).AddTicks(8491), 35L, "Laudantium totam dolores perspiciatis repellendus quia neque.", "Provident quo possimus error quae tempora inventore voluptate.", 1L, "", 0, "adipisci" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 6L, "Et rerum rerum ut eveniet et voluptates illo.", new DateTime(2023, 6, 21, 21, 30, 26, 171, DateTimeKind.Utc).AddTicks(6558), 30L, "Nesciunt officiis fuga eos et dolore harum dolores consequatur.", "Reprehenderit qui blanditiis necessitatibus.", 1L, "", 2, "cupiditate" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 1L, "Eveniet dolorem similique animi. Officiis et sunt impedit fuga eos. Fugiat dolorum aliquam est non aliquam quia accusamus. Iste et neque. Consequatur eos explicabo et aut aut.", new DateTime(2023, 2, 16, 6, 0, 50, 773, DateTimeKind.Utc).AddTicks(1494), "Sit dolorem error assumenda iure doloribus iure nihil quidem. Minima alias quam iure voluptate dolorem occaecati corrupti cupiditate. Ut rerum ducimus dignissimos quidem ut quaerat assumenda vitae.", "Assumenda sapiente voluptatem unde consequatur.", 2L, "", 3, "Qui ipsam incidunt est sequi quaerat quod eos. Aspernatur animi impedit nihil voluptatem. Et laboriosam aut nihil facilis modi laboriosam et. Consequuntur libero id ut ipsum minus. Nesciunt quasi consectetur saepe itaque quam error aut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 47L, "Explicabo dolor debitis quasi assumenda quas provident deserunt.\nLaborum reprehenderit ea.\nPerspiciatis autem quia magni sequi minus dolorum laboriosam eos vero.\nAtque quasi incidunt voluptas voluptatibus neque.", new DateTime(2022, 3, 4, 15, 5, 7, 861, DateTimeKind.Utc).AddTicks(7149), 23L, "modi", "Vitae nulla ea minima.", 2L, "", 2, "omnis" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 8L, "Perferendis sapiente voluptate.\nMolestiae eum qui cumque.\nSed laborum debitis ea laborum.", new DateTime(2018, 9, 26, 15, 39, 7, 368, DateTimeKind.Utc).AddTicks(3185), 12L, "Natus eligendi reiciendis eum at consequuntur praesentium. Voluptas et et. Quaerat recusandae dicta omnis modi illum enim. Sit maiores voluptas deleniti eaque debitis vero asperiores. Maiores est et repellat dolorem libero et aperiam culpa.", "Labore corrupti id qui qui nesciunt qui laborum nihil.", 2L, "", 1, "cum" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 42L, "Rerum eos nobis sapiente quis sunt non et ut. Ut laudantium enim laboriosam nulla repellat fuga sunt ut et. Facilis quaerat quia minima saepe minus soluta qui. Cupiditate sint cum non ipsa voluptates.", new DateTime(2023, 5, 27, 17, 58, 39, 121, DateTimeKind.Utc).AddTicks(9034), 39L, "Aliquid temporibus vel ullam recusandae quasi.\nUllam ipsum ratione consectetur voluptate soluta consequatur.\nRepudiandae illum dignissimos nesciunt quas.\nLabore perferendis aut quod nemo.\nUt ipsam aliquam quaerat vero ut.\nCorrupti numquam mollitia et.", "Distinctio culpa aliquid.", 1L, "", "Explicabo quas sed ut culpa quo alias reiciendis repudiandae. Distinctio tenetur voluptatem cum. Consequuntur corporis animi deleniti nobis deleniti voluptas dolore." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 24L, "Amet aut omnis sunt natus et. Labore voluptatibus repudiandae necessitatibus suscipit inventore unde. Veritatis ipsam sed qui similique eos ullam minus dolores accusamus. Eum laboriosam itaque placeat incidunt blanditiis suscipit sapiente earum. Iusto accusantium illo tempore aut consequuntur.", new DateTime(2023, 4, 30, 11, 1, 29, 254, DateTimeKind.Utc).AddTicks(4620), 28L, "Et eum porro ab alias nesciunt.", "Recusandae eveniet et fugit velit error voluptatem.", 1L, "", 1, "Animi quo autem incidunt ut magnam qui expedita. Dolore necessitatibus autem minima nihil porro et minima corporis ut. Et repellat explicabo est quas fuga nostrum voluptatem. Mollitia perferendis voluptatem qui et enim. Aut odit deserunt." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 40L, "Ut sunt ut esse et.\nIncidunt quia impedit id enim et et vel.", new DateTime(2023, 3, 7, 16, 45, 8, 514, DateTimeKind.Utc).AddTicks(2938), 15L, "aut", "Voluptates velit animi quod voluptas qui quisquam a.", 2L, "", 3, "Ut vel ipsa ut consectetur sunt.\nLibero libero voluptatem et.\nOfficiis ut quod laborum accusantium deleniti.\nVoluptas quod rerum fuga velit occaecati." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 57L, "Alias alias placeat.", new DateTime(2022, 12, 8, 23, 52, 8, 237, DateTimeKind.Utc).AddTicks(2510), 23L, "Voluptas asperiores quia quia non quisquam.", "Magnam maiores eos ratione.", 1L, "", 0, "Quibusdam quo adipisci provident perferendis officia eveniet beatae id qui. Amet voluptas eum. Error mollitia aspernatur. Ut aperiam sequi dolorum omnis aut totam sunt." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 37L, "ut", new DateTime(2023, 1, 14, 7, 45, 24, 920, DateTimeKind.Utc).AddTicks(7096), 38L, "Sit laudantium mollitia ut minus sapiente aut.\nDistinctio quibusdam facere quos unde veniam iusto ut.\nAspernatur et quia dolorem dolores laudantium ipsa commodi.\nAperiam fuga quaerat beatae inventore.\nQui consequatur vel repellat.", "Dolores corrupti cupiditate ut tempore corporis.", 2L, "", 3, "Est dicta unde tenetur facilis eius." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 1L, "Dignissimos vel occaecati alias iste est iure molestiae eum quis. Id culpa ipsa perspiciatis ut iusto commodi. Nemo impedit perspiciatis quos.", new DateTime(2023, 9, 10, 17, 47, 47, 708, DateTimeKind.Utc).AddTicks(6828), 35L, "Dolore incidunt excepturi quia aut itaque.", "Velit quia nobis voluptates aspernatur aut fugit illo.", 1L, "", 2, "nostrum" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 162L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 25L, "Dolorem vel minima ut necessitatibus iusto quo velit. Qui eligendi officiis dolorem. Et in aperiam et eaque odio. Et et optio ut consectetur aliquam. Magnam qui est voluptas fugiat sint ad consequuntur eveniet.", new DateTime(2023, 7, 22, 8, 15, 12, 904, DateTimeKind.Utc).AddTicks(6538), 29L, "Dolor facere quaerat voluptatem ea.", "Voluptates in perferendis minima ullam eum iusto odit accusamus iste.", 1L, "", 2, "minus" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 163L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 64L, "vero", new DateTime(2020, 4, 10, 2, 32, 54, 491, DateTimeKind.Utc).AddTicks(5912), 11L, "sapiente", "Et ut nemo culpa et qui quidem optio.", 1L, "", 1, "Consequatur eaque et sed tempore et. Amet laborum sequi animi corrupti est autem eos inventore et. Perspiciatis facere illo praesentium. Quia optio eius ipsam rem eaque et. Fugiat amet aut tenetur commodi atque." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 164L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 39L, "Odio dignissimos molestias blanditiis amet praesentium ratione consequatur qui voluptas. Voluptas nihil et sunt omnis. Nisi pariatur id non sint. Id a odit cumque in ut.", new DateTime(2023, 2, 2, 15, 57, 19, 719, DateTimeKind.Utc).AddTicks(4750), 17L, "Et autem in sed consequuntur placeat voluptas in corporis voluptas. Unde illum perspiciatis voluptatem. Sit praesentium in autem in et. Repellat dicta qui aut recusandae.", "Sunt quaerat non est rerum ad rerum ea.", 2L, "", 1, "Voluptate quae et eaque quidem. Sit ducimus corporis aut aliquid rerum repellendus. Repellendus enim et excepturi eum inventore. Autem optio molestiae hic et dolores vitae possimus placeat qui." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 165L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 9L, "In sunt tenetur voluptas sit esse itaque perspiciatis a.", new DateTime(2020, 8, 25, 6, 7, 58, 700, DateTimeKind.Utc).AddTicks(1167), 5L, "Ipsam impedit nobis quae laboriosam omnis possimus cum eius.\nEt exercitationem necessitatibus ad expedita.\nNon laborum quisquam sunt eos ullam.\nReprehenderit qui ut eius sint nam ipsam possimus occaecati est.\nLaboriosam animi atque.\nOmnis voluptatem tempora modi quia.", "Maiores voluptate optio non eum quidem minus similique corrupti.", 2L, "", 0, "In ducimus qui.\nReprehenderit quo facere voluptas possimus recusandae delectus iste.\nQui et architecto voluptas rerum eum magni voluptatibus labore est.\nInventore ipsum ex dolores unde et expedita enim.\nVel sed vitae maiores.\nNisi vero id non alias totam quia qui at animi." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 64L, "id", new DateTime(2022, 7, 18, 14, 10, 12, 827, DateTimeKind.Utc).AddTicks(4094), 19L, "Illo et adipisci fugiat in eos rerum quia rem enim.\nQuia doloremque quae expedita.\nVoluptas fuga repudiandae ipsum quia et consectetur id cum dolor.\nQuia eius eveniet voluptatem et nemo aliquam esse aut magni.\nDolores voluptates ad nulla.\nVoluptatem autem voluptatibus excepturi adipisci.", "Consequatur quia doloribus saepe est sint.", 1L, "", 3, "Aut ut et perferendis et animi aspernatur." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 7L, "Deserunt illum est et. Eos est consequuntur consequatur saepe voluptatum id. Commodi eligendi ut temporibus. Corporis veritatis unde recusandae tempore facilis incidunt iure tempore. Debitis eaque voluptas rerum est est dolor neque id similique.", new DateTime(2022, 1, 6, 5, 12, 32, 853, DateTimeKind.Utc).AddTicks(3020), 28L, "Illo deserunt sint qui qui provident provident modi ab magnam.\nSed dolore recusandae molestias est nulla culpa sed cupiditate.\nQuaerat incidunt quia quasi quia sit est dolorem harum eos.", "Laborum amet quo blanditiis nesciunt dolorum officiis et.", 2L, "", 2, "Ut est quod dolores. Perspiciatis sunt laudantium aliquid dicta culpa expedita. Cumque expedita ratione magni in dolorem consectetur." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 53L, "Numquam fuga facere quia est architecto.", new DateTime(2022, 2, 9, 9, 47, 20, 889, DateTimeKind.Utc).AddTicks(1129), 38L, "Id nihil sunt. Eum quas sunt quo aut maiores esse enim. Ut consequatur nihil saepe dolor. Qui quae quam eveniet aut sed aut qui reprehenderit aut. Distinctio assumenda et ut rem voluptatem molestiae et sed labore.", "Ratione molestias recusandae qui eos provident ea tempore.", 2L, "", 2, "Commodi quod voluptas laudantium excepturi et illo esse reprehenderit.\nOdit non dolore delectus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 55L, "Inventore officiis accusantium sit aut veniam est illum ab. Eum quo quia est. Quo et ut dolor eum facilis nobis quasi. Quo a dolorem perferendis accusamus.", new DateTime(2023, 3, 26, 23, 2, 34, 507, DateTimeKind.Utc).AddTicks(991), 15L, "Magni eos autem non et et vel voluptas nisi. Deserunt odio neque voluptatem. Explicabo id suscipit.", "Qui soluta id.", 2L, "", 3, "Et debitis impedit. Excepturi nostrum numquam rerum blanditiis porro amet similique sint. Laborum asperiores quam molestiae laborum reprehenderit ipsa cupiditate eos. Aut qui rem nulla sed. Hic ad provident est modi ducimus itaque." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 37L, "Ratione quia officiis nemo aliquid et et rerum alias molestias. Ut possimus consequuntur. Id maiores quam a omnis et sint neque. Praesentium incidunt adipisci dolor sed aut non.", new DateTime(2022, 9, 23, 7, 55, 9, 42, DateTimeKind.Utc).AddTicks(6230), 18L, "Molestiae consectetur accusamus in at quaerat quibusdam assumenda.", "Assumenda repudiandae eaque ratione est dolorem illo quos incidunt.", 1L, "", 1, "Aut rerum provident." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 61L, "Ut ullam temporibus ut facilis sit dolor ratione ut.", new DateTime(2023, 6, 14, 20, 56, 13, 246, DateTimeKind.Utc).AddTicks(7517), 21L, "Nobis aut ut nostrum impedit rerum omnis.\nAut suscipit ducimus commodi.\nCulpa nisi ut in nisi ut.\nHarum doloremque repellat hic officia et inventore tempore.\nSint rem qui sit animi dolores aspernatur quaerat.\nVoluptatem adipisci est ut ipsum nihil voluptatem quibusdam eos voluptatem.", "Officiis dolores quis harum quae nostrum nulla quia et.", 2L, "", "Eaque distinctio et temporibus est nulla cum est libero animi. Qui quas dolorem ipsam corrupti ipsum. Nemo possimus unde placeat tenetur a aut quas quod. Minima corporis sequi illum odit. Dolore ut qui et nesciunt ad possimus. Nesciunt corporis eveniet suscipit omnis qui et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 3L, "rerum", new DateTime(2023, 7, 12, 14, 37, 41, 464, DateTimeKind.Utc).AddTicks(9931), 18L, "et", "Molestiae et perferendis in nihil.", 2L, "", "dignissimos" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 30L, "Soluta aut cum hic labore accusantium cum atque. Vero magnam quia. Dolorum non maiores iste nostrum. Sit officiis maxime eius dolorum odio adipisci commodi voluptatem. Iusto animi repudiandae voluptatem ratione nihil error excepturi sint. Consequatur dolorem sapiente neque repellendus quis officiis.", new DateTime(2020, 7, 14, 18, 37, 30, 854, DateTimeKind.Utc).AddTicks(880), 36L, "magni", "Dolorum vitae voluptatem rerum distinctio eos in quibusdam.", 2L, "", 0, "Officiis sit molestias accusantium. Accusamus itaque distinctio illo molestias ipsa distinctio velit eligendi. Quaerat suscipit earum neque velit delectus voluptatum quidem. Possimus pariatur repudiandae culpa iusto magnam error ex." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 29L, "Ut sint cupiditate aperiam non cum consequuntur dolorem in.", new DateTime(2020, 10, 8, 23, 47, 2, 970, DateTimeKind.Utc).AddTicks(118), 26L, "Incidunt neque ducimus qui rerum quo veritatis sit tempora.", "Atque ut blanditiis velit in.", 1L, "", 0, "Ut et a ex modi aut earum est fuga." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 7L, "Soluta et totam necessitatibus.", new DateTime(2022, 3, 11, 13, 43, 28, 796, DateTimeKind.Utc).AddTicks(2552), 31L, "Omnis sed eligendi fuga sequi.\nUnde et nesciunt aut et at eos aut sint.\nId consequatur quo consequatur et neque debitis aut voluptatem.", "Numquam quidem cum repudiandae sapiente sint aperiam quaerat fuga similique.", 1L, "", 1, "Quis commodi officia voluptatum autem esse.\nVel sequi maxime.\nEum enim nostrum ipsam officia nemo perferendis quo quia.\nAdipisci et dolorem rerum similique." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 8L, "Nesciunt excepturi voluptas sapiente.\nMagni numquam totam quia.", new DateTime(2021, 10, 1, 5, 31, 17, 899, DateTimeKind.Utc).AddTicks(523), 3L, "Rem molestiae est sunt eos error expedita nam.\nQuia quos aut id.\nPariatur voluptas animi aut perferendis maxime autem.", "Fugiat est perferendis reprehenderit.", 2L, "", 3, "Inventore voluptatem natus maxime perferendis corporis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 70L, "Incidunt dolorem cum aspernatur qui rem unde laboriosam.", new DateTime(2023, 7, 27, 12, 24, 0, 452, DateTimeKind.Utc).AddTicks(7563), 1L, "Ut et qui consequuntur et voluptas. Sunt repudiandae quos velit nesciunt nemo rerum ducimus quo. Consequatur eveniet ullam doloremque et quia ut quos magni provident. Quia officia enim inventore ut temporibus ad quam occaecati.", "Libero dicta impedit quo autem numquam.", 2L, "", 3, "Qui et impedit esse esse velit. Culpa necessitatibus temporibus qui voluptates voluptatem sequi. Doloribus in esse. Optio omnis quia et dolorum quas. Alias molestiae enim dolore nisi odit tenetur et aliquam dolorem. Tempore exercitationem excepturi quia harum deserunt earum velit repudiandae et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 13L, "neque", new DateTime(2021, 4, 4, 2, 0, 34, 535, DateTimeKind.Utc).AddTicks(4589), 33L, "Aut voluptas eius eos amet occaecati consequatur accusantium consectetur consequuntur.\nAut quis neque voluptatem voluptatem.\nDignissimos aut culpa ea molestias harum voluptatibus.\nConsequatur laboriosam numquam.\nQuo adipisci voluptatum consequuntur ab maiores et.", "Aut ipsam ab quia hic dolores optio a quis.", 2L, "", 3, "Et nobis quidem." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 14L, "Adipisci porro eius. Autem eligendi labore consequuntur vel sit sequi. Ex recusandae saepe nulla labore dolor. Id velit culpa alias asperiores necessitatibus alias aut.", new DateTime(2023, 5, 6, 5, 41, 47, 808, DateTimeKind.Utc).AddTicks(3601), 28L, "Qui quod alias possimus voluptates. Laborum id ut ab deleniti dolorum. Veritatis sequi saepe accusantium tempora quidem.", "Molestias eum et quasi officiis nostrum.", 1L, "", 2, "earum" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 61L, "Recusandae eos recusandae temporibus error voluptatibus reprehenderit. Aut eum natus dolorem pariatur. Eaque quo ullam itaque odit in ab iure eaque nobis. Labore pariatur ipsum accusamus aperiam corrupti culpa quibusdam.", new DateTime(2023, 8, 26, 23, 15, 17, 951, DateTimeKind.Utc).AddTicks(1115), 16L, "vero", "Tempora impedit quis necessitatibus quia sit ducimus dolores.", 2L, "", 0, "Nostrum pariatur unde non aliquid voluptas molestias sit nam aut.\nReiciendis eos totam voluptatem velit maxime et.\nPerspiciatis aspernatur magnam quae voluptas dolores eius.\nQuasi saepe voluptatibus doloremque enim tenetur.\nQuam ducimus iure eveniet.\nQuisquam aut nihil." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 31L, "et", new DateTime(2023, 3, 4, 17, 59, 56, 156, DateTimeKind.Utc).AddTicks(1641), 35L, "quo", "Fugiat non aut velit temporibus.", 1L, "", 2, "beatae" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 7L, "Voluptas nam reprehenderit ut consectetur laborum voluptatem amet sunt. Id ratione aspernatur suscipit. Ea eum est ipsum qui repudiandae rerum. Ut sit alias quas nulla quae. Amet atque maiores aut dolores. Qui aut est est vel rerum placeat aliquam.", new DateTime(2020, 2, 9, 20, 56, 24, 825, DateTimeKind.Utc).AddTicks(9914), 4L, "Nobis dolores nulla tenetur sed quia.\nEnim et quam dolores qui aut aut.\nQuo vel assumenda tempore eligendi.", "Doloribus quae cumque.", 2L, "", 0, "Officiis corrupti et nam ab quidem doloremque et a. Quia ut amet aut. Eos id repellat quia neque doloribus. Autem sapiente in eaque. Consequatur delectus dolores amet et autem dolore." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 33L, "Repellendus doloremque enim est.", new DateTime(2023, 8, 31, 21, 47, 32, 211, DateTimeKind.Utc).AddTicks(8807), 16L, "Aut esse omnis optio odit aut.", "Qui eaque eligendi odit earum atque veritatis quisquam illo et.", 2L, "", 2, "Est neque consequuntur.\nPorro esse deleniti a nam facere mollitia quia assumenda non.\nEx atque culpa quibusdam deleniti.\nSuscipit vitae a.\nIusto quia voluptatibus facilis nihil aut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 35L, "debitis", new DateTime(2023, 8, 15, 13, 12, 21, 1, DateTimeKind.Utc).AddTicks(8876), 10L, "Ipsum perspiciatis veniam.", "Quod molestias ad occaecati cum temporibus.", 1L, "", 1, "ab" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 55L, "Aut perferendis corrupti itaque fugit et est.\nEveniet praesentium delectus harum et ut magnam sapiente eos optio.\nError eligendi ducimus delectus numquam sequi adipisci.", new DateTime(2023, 1, 20, 10, 24, 27, 245, DateTimeKind.Utc).AddTicks(5332), 23L, "velit", "Minus possimus sint corrupti.", 2L, "", 0, "Facere possimus aperiam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 23L, "Magni vel sint et quae ad dolor sint modi. Quia eos nihil hic modi commodi assumenda consequuntur. Et minus vero libero suscipit odit. Accusamus omnis veniam rerum non tenetur vel dolore necessitatibus animi.", new DateTime(2023, 8, 27, 7, 50, 7, 698, DateTimeKind.Utc).AddTicks(2906), 35L, "In in inventore enim qui.\nUnde fugit voluptate incidunt quidem qui odit.\nPossimus dolor veritatis dolorum.\nEst quae aut dolore nobis velit velit sequi ut.\nRem dolorem id assumenda quia.\nAut consectetur et praesentium consequatur similique sapiente.", "Libero saepe ex nisi aperiam ut id voluptates quidem deleniti.", 2L, "", "Quis iste quae.\nAliquam dolor quia laborum qui eum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 30L, "Est autem recusandae et eveniet vel. Nam tenetur doloribus dignissimos nesciunt est beatae dicta incidunt et. Omnis voluptatem velit blanditiis necessitatibus. Ea ut omnis accusamus. Voluptatum illum omnis qui qui.", new DateTime(2020, 5, 16, 11, 5, 37, 23, DateTimeKind.Utc).AddTicks(5662), 10L, "Veritatis reprehenderit deleniti ipsum soluta.\nConsectetur nesciunt sint quis distinctio omnis.\nQuae ut sapiente dignissimos et quibusdam.\nEsse est eius veritatis porro qui ut ea qui voluptatem.\nMollitia qui autem nesciunt.\nAut enim non quia et voluptatibus corporis assumenda placeat laboriosam.", "Ducimus et suscipit voluptas voluptas eius nemo quis sit quis.", 2L, "", 1, "Quaerat excepturi ab eius exercitationem quos dignissimos saepe id asperiores. Eius illo velit aspernatur. Laudantium tempora adipisci et quibusdam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 50L, "dolorem", new DateTime(2023, 4, 5, 8, 2, 33, 69, DateTimeKind.Utc).AddTicks(2878), 21L, "Maxime qui mollitia illum voluptatibus aut ut unde est et.\nNeque aspernatur non quia minima exercitationem cupiditate labore.\nVelit et est aut beatae culpa voluptatem quibusdam recusandae.\nUnde sit ut omnis qui enim ex ex ab.\nNon rerum optio dolorem fuga numquam unde.", "Et hic nulla velit quia esse blanditiis.", 1L, "", "Eos veritatis dolor impedit necessitatibus alias hic ipsum. Fuga dolor iusto. Qui ipsam autem facilis nulla. Dolores quibusdam deserunt." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 15L, "Ipsum et temporibus beatae ex dolorum suscipit iure.", new DateTime(2020, 1, 13, 18, 49, 30, 187, DateTimeKind.Utc).AddTicks(7417), 27L, "Natus non consequatur ut voluptatum eos aperiam. Dicta porro ex. Quo tempore incidunt praesentium enim eos. Est non eaque enim et maxime enim.", "Et provident soluta alias quos id.", 2L, "", 3, "molestiae" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 13L, "Dicta eveniet iusto mollitia occaecati rerum odit molestiae. Veritatis quia dolorem optio cupiditate quaerat praesentium sequi quia. Dolorem architecto nihil molestiae temporibus. Ut consequatur modi ratione ipsum nulla quod veniam et tenetur.", new DateTime(2022, 11, 5, 10, 24, 2, 812, DateTimeKind.Utc).AddTicks(4125), 30L, "et", "Mollitia accusamus nemo consequatur ipsam aut sit.", 2L, "", "Ratione facere est aut alias aut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 61L, "Eius culpa perspiciatis qui similique aut maiores. Blanditiis dolorum quisquam. Ut velit unde. Autem qui voluptatum. Modi aperiam dolores quod et. Et dolorem iusto sed et.", new DateTime(2023, 6, 15, 23, 34, 27, 763, DateTimeKind.Utc).AddTicks(2970), 38L, "Distinctio tempora quisquam.", "Consequatur id ut laborum distinctio totam facilis quo unde culpa.", 1L, "", 3, "tempora" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 66L, "Dignissimos aut qui minima.", new DateTime(2022, 7, 25, 22, 44, 7, 371, DateTimeKind.Utc).AddTicks(9641), 29L, "nihil", "Qui ut quia ut aspernatur animi possimus asperiores voluptate corrupti.", 2L, "", 3, "Aliquam iste et nulla ut consectetur necessitatibus. Quasi quis est nihil quis soluta sequi sint dicta ipsum. Qui fugiat dignissimos architecto vel id rerum dolorem." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 50L, "Quo nobis dolorum quibusdam. Aut quas nostrum. Minus aut laboriosam iusto id consequatur deleniti nobis odit eum.", new DateTime(2023, 6, 20, 8, 35, 10, 186, DateTimeKind.Utc).AddTicks(4717), 11L, "Natus occaecati quia omnis qui.\nTempore repellendus voluptatem.\nUt neque dolorem perspiciatis enim fuga nostrum hic quidem officia.", "Molestiae quia optio.", 1L, "", 2, "Laudantium ipsum odio est porro et culpa est." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 54L, "Autem dolor sint et ab.\nLibero iusto animi.\nFacere et consequatur.", new DateTime(2022, 6, 20, 10, 7, 16, 202, DateTimeKind.Utc).AddTicks(260), 1L, "qui", "Architecto ut dolor molestiae.", 1L, "", 1, "Exercitationem quis est a et nulla.\nVoluptatibus accusamus dolore enim earum quia id qui aliquid." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 69L, "Sit ut hic molestiae recusandae placeat et possimus est. Asperiores et in. Amet qui velit sunt quis ipsa at maiores. Ut adipisci velit perspiciatis quod cumque quae nihil. Possimus natus repudiandae minima beatae quo quam voluptatem.", new DateTime(2022, 12, 7, 12, 15, 16, 590, DateTimeKind.Utc).AddTicks(7825), 30L, "Voluptatem voluptatibus atque consequatur animi deserunt itaque ut.", "Ut voluptatem officiis distinctio repellendus voluptas quas similique eveniet ut.", 2L, "", "Et eaque debitis consequatur." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 27L, "Quo omnis et molestias sunt tempore accusantium animi eligendi quod.", new DateTime(2022, 10, 29, 12, 58, 57, 913, DateTimeKind.Utc).AddTicks(4381), 23L, "nobis", "Illo soluta eligendi.", 1L, "", "Vel necessitatibus nihil quisquam.\nLaborum quia dolorem dolorum similique iure aspernatur." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 66L, "Id minima rerum perspiciatis.\nIpsam quidem suscipit quia beatae sequi qui eius consectetur occaecati.\nTotam maiores delectus eius qui dolor.\nQuos beatae voluptatem repellat aut.\nEst voluptatum unde quia.\nDelectus odit numquam natus omnis.", new DateTime(2022, 11, 16, 12, 32, 22, 359, DateTimeKind.Utc).AddTicks(1500), 29L, "Id repellat ipsa optio recusandae exercitationem sed sit sed.", "Aut unde saepe velit rem repudiandae eos.", 1L, "", 1, "Dignissimos ut ducimus vel voluptas cumque necessitatibus et dignissimos.\nId assumenda distinctio nihil.\nQui totam expedita.\nEt dicta rem id est.\nNulla tempora velit adipisci voluptates modi tempora." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 14L, "Est ut distinctio.", new DateTime(2023, 5, 3, 12, 25, 14, 673, DateTimeKind.Utc).AddTicks(5175), 24L, "Voluptatem eum ea est repellendus optio. Quia tempore ut temporibus nesciunt dolores. Vel culpa recusandae est et soluta sequi eveniet.", "Illum explicabo odit.", 1L, "", 3, "Voluptatum deleniti accusamus sed non vel. Pariatur est sit ex est. Voluptatem molestias ut enim veniam nam sequi dolores. Voluptatem autem vel sed et ea consequuntur assumenda. Velit officiis qui qui rerum. Libero reprehenderit natus aut eos." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 15L, "Sapiente voluptatem sed.", new DateTime(2019, 1, 10, 2, 52, 5, 241, DateTimeKind.Utc).AddTicks(5186), 8L, "Rerum in voluptatibus quia eos non in enim quam.", "Odit ipsa enim quo et voluptates dolores id in facere.", 1L, "", 2, "aperiam" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 61L, "beatae", new DateTime(2023, 8, 21, 10, 42, 42, 411, DateTimeKind.Utc).AddTicks(1620), 37L, "Quisquam magni optio dolorem dolorem reprehenderit omnis expedita ipsam.", "Quasi et beatae hic sint qui.", 1L, "", 0, "dolor" });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 10, 26, 18, 4, 35, 604, DateTimeKind.Utc).AddTicks(2464), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2018, 3, 16, 11, 26, 25, 899, DateTimeKind.Utc).AddTicks(24), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 6, 22, 12, 37, 39, 996, DateTimeKind.Utc).AddTicks(1328), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 3, 6, 11, 33, 24, 526, DateTimeKind.Utc).AddTicks(7949), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 3, 23, 23, 16, 18, 782, DateTimeKind.Utc).AddTicks(1442), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 4, 23, 8, 22, 1, 421, DateTimeKind.Utc).AddTicks(928), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2020, 1, 8, 3, 6, 49, 393, DateTimeKind.Utc).AddTicks(8482), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2017, 1, 15, 23, 8, 8, 959, DateTimeKind.Utc).AddTicks(6391), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2019, 12, 6, 20, 44, 46, 773, DateTimeKind.Utc).AddTicks(8012), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 6, 3, 11, 15, 11, 412, DateTimeKind.Utc).AddTicks(8910), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2018, 1, 13, 21, 7, 35, 974, DateTimeKind.Utc).AddTicks(25), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 8, 12, 14, 42, 0, 342, DateTimeKind.Utc).AddTicks(5595), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2017, 10, 23, 8, 58, 26, 67, DateTimeKind.Utc).AddTicks(7355), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 10, 16, 7, 51, 58, 409, DateTimeKind.Utc).AddTicks(6917), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2018, 7, 14, 16, 24, 30, 164, DateTimeKind.Utc).AddTicks(6946), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 3, 20, 3, 45, 0, 72, DateTimeKind.Utc).AddTicks(4317), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 1, 19, 23, 27, 39, 958, DateTimeKind.Utc).AddTicks(2121), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2020, 4, 19, 6, 38, 40, 197, DateTimeKind.Utc).AddTicks(1810), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 7, 25, 19, 1, 39, 504, DateTimeKind.Utc).AddTicks(9859), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 4, 4, 11, 49, 57, 792, DateTimeKind.Utc).AddTicks(2145), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 11, 30, 4, 19, 28, 73, DateTimeKind.Utc).AddTicks(3635), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 9, 28, 20, 8, 4, 798, DateTimeKind.Utc).AddTicks(1461), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 8, 24, 15, 22, 11, 6, DateTimeKind.Utc).AddTicks(825), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2021, 8, 12, 9, 15, 59, 625, DateTimeKind.Utc).AddTicks(2209), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 11, 7, 8, 33, 49, 744, DateTimeKind.Utc).AddTicks(1579), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 1, 7, 4, 40, 10, 612, DateTimeKind.Utc).AddTicks(2144), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 5, 14, 7, 17, 36, 485, DateTimeKind.Utc).AddTicks(6332), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 2, 14, 2, 16, 8, 43, DateTimeKind.Utc).AddTicks(4509), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2020, 7, 27, 6, 42, 51, 991, DateTimeKind.Utc).AddTicks(4144), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2017, 7, 1, 18, 19, 12, 383, DateTimeKind.Utc).AddTicks(9196), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 1, 12, 5, 31, 7, 240, DateTimeKind.Utc).AddTicks(1791), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 8, 9, 12, 50, 26, 919, DateTimeKind.Utc).AddTicks(5879), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 9, 14, 6, 0, 20, 581, DateTimeKind.Utc).AddTicks(7884), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 9, 22, 21, 17, 10, 897, DateTimeKind.Utc).AddTicks(6164), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 24, 54, 155, DateTimeKind.Utc).AddTicks(3345), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2021, 6, 2, 1, 29, 5, 177, DateTimeKind.Utc).AddTicks(7371), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2021, 9, 28, 20, 36, 29, 718, DateTimeKind.Utc).AddTicks(9935), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 6, 20, 21, 42, 48, 486, DateTimeKind.Utc).AddTicks(1140), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 2, 14, 4, 20, 38, 984, DateTimeKind.Utc).AddTicks(3720), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 1, 16, 11, 53, 17, 958, DateTimeKind.Utc).AddTicks(8983), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2021, 12, 2, 21, 16, 16, 122, DateTimeKind.Utc).AddTicks(2017), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 2, 6, 21, 27, 11, 256, DateTimeKind.Utc).AddTicks(2405), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 8, 24, 6, 1, 3, 268, DateTimeKind.Utc).AddTicks(1983), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2019, 2, 8, 8, 31, 55, 429, DateTimeKind.Utc).AddTicks(3066), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 12, 8, 4, 49, 49, 525, DateTimeKind.Utc).AddTicks(3075), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 5, 29, 15, 19, 30, 696, DateTimeKind.Utc).AddTicks(7607), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2020, 11, 8, 16, 34, 10, 773, DateTimeKind.Utc).AddTicks(189), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 1, 5, 4, 58, 29, 176, DateTimeKind.Utc).AddTicks(9726), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 6, 16, 1, 59, 25, 86, DateTimeKind.Utc).AddTicks(6268), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 3, 24, 13, 15, 10, 62, DateTimeKind.Utc).AddTicks(482), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 8, 22, 0, 25, 53, 807, DateTimeKind.Utc).AddTicks(8616), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 1, 31, 14, 39, 5, 465, DateTimeKind.Utc).AddTicks(4466), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2019, 4, 12, 18, 40, 5, 553, DateTimeKind.Utc).AddTicks(4828), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 1, 27, 4, 46, 1, 763, DateTimeKind.Utc).AddTicks(25), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 9, 23, 2, 13, 29, 161, DateTimeKind.Utc).AddTicks(2054), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2018, 4, 23, 1, 24, 7, 516, DateTimeKind.Utc).AddTicks(409), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 6, 8, 5, 20, 30, 395, DateTimeKind.Utc).AddTicks(5485), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2019, 7, 20, 3, 58, 37, 740, DateTimeKind.Utc).AddTicks(8780), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 1, 18, 17, 4, 48, 570, DateTimeKind.Utc).AddTicks(7756), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2019, 2, 25, 13, 51, 38, 199, DateTimeKind.Utc).AddTicks(9482), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 4, 28, 19, 13, 10, 265, DateTimeKind.Utc).AddTicks(4064), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 10, 5, 8, 28, 8, 802, DateTimeKind.Utc).AddTicks(818), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2020, 10, 16, 20, 16, 23, 547, DateTimeKind.Utc).AddTicks(8478), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2019, 12, 21, 18, 11, 32, 779, DateTimeKind.Utc).AddTicks(7909), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2021, 5, 20, 1, 2, 0, 64, DateTimeKind.Utc).AddTicks(3419), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2021, 12, 1, 3, 44, 48, 213, DateTimeKind.Utc).AddTicks(2786), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 12, 8, 17, 8, 6, 412, DateTimeKind.Utc).AddTicks(3158), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 1, 14, 17, 51, 29, 424, DateTimeKind.Utc).AddTicks(7624), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 9, 26, 20, 52, 49, 762, DateTimeKind.Utc).AddTicks(5752), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 9, 25, 14, 51, 55, 319, DateTimeKind.Utc).AddTicks(3256), 4L });

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

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 21, 22, 55, 51, 649, DateTimeKind.Utc).AddTicks(7637), new DateTime(2023, 7, 20, 7, 46, 24, 890, DateTimeKind.Utc).AddTicks(6720), new DateTime(2022, 8, 15, 15, 12, 23, 519, DateTimeKind.Utc).AddTicks(2243), 2L, new DateTime(2023, 7, 22, 15, 20, 48, 767, DateTimeKind.Utc).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 19, 2, 43, 15, 559, DateTimeKind.Utc).AddTicks(1358), new DateTime(2023, 7, 31, 17, 21, 20, 434, DateTimeKind.Utc).AddTicks(7306), new DateTime(2023, 1, 23, 8, 18, 20, 144, DateTimeKind.Utc).AddTicks(6672), 1L, new DateTime(2023, 2, 8, 3, 37, 53, 935, DateTimeKind.Utc).AddTicks(4118) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 10, 17, 50, 23, 464, DateTimeKind.Utc).AddTicks(9816), new DateTime(2023, 7, 29, 12, 57, 50, 698, DateTimeKind.Utc).AddTicks(9051), new DateTime(2023, 5, 12, 0, 0, 33, 942, DateTimeKind.Utc).AddTicks(205), 2L, new DateTime(2023, 7, 22, 21, 50, 48, 706, DateTimeKind.Utc).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 1, 15, 0, 16, 27, 599, DateTimeKind.Utc).AddTicks(4572), new DateTime(2022, 6, 2, 12, 12, 49, 136, DateTimeKind.Utc).AddTicks(7716), new DateTime(2021, 8, 2, 20, 26, 58, 427, DateTimeKind.Utc).AddTicks(4647), 1L, new DateTime(2022, 8, 14, 4, 2, 39, 415, DateTimeKind.Utc).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 13, 13, 29, 51, 321, DateTimeKind.Utc).AddTicks(9013), new DateTime(2023, 5, 8, 12, 35, 24, 514, DateTimeKind.Utc).AddTicks(7549), new DateTime(2022, 10, 31, 10, 28, 51, 337, DateTimeKind.Utc).AddTicks(1299), 1L, new DateTime(2023, 8, 16, 10, 47, 33, 157, DateTimeKind.Utc).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 20, 5, 26, 425, DateTimeKind.Utc).AddTicks(6213), new DateTime(2021, 4, 12, 3, 17, 15, 179, DateTimeKind.Utc).AddTicks(1685), new DateTime(2018, 12, 17, 4, 38, 57, 238, DateTimeKind.Utc).AddTicks(1307), 3L, new DateTime(2019, 12, 30, 6, 30, 2, 977, DateTimeKind.Utc).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 2, 23, 21, 26, 56, 533, DateTimeKind.Utc).AddTicks(686), new DateTime(2023, 1, 31, 8, 52, 26, 812, DateTimeKind.Utc).AddTicks(4291), new DateTime(2020, 4, 23, 16, 29, 19, 361, DateTimeKind.Utc).AddTicks(9968), 1L, new DateTime(2021, 1, 24, 17, 43, 31, 787, DateTimeKind.Utc).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 10, 18, 16, 22, 8, 900, DateTimeKind.Utc).AddTicks(257), new DateTime(2022, 8, 27, 10, 23, 13, 557, DateTimeKind.Utc).AddTicks(7217), new DateTime(2021, 5, 7, 18, 36, 54, 589, DateTimeKind.Utc).AddTicks(2826), 3L, new DateTime(2021, 7, 19, 1, 52, 13, 663, DateTimeKind.Utc).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 27, 13, 58, 4, 883, DateTimeKind.Utc).AddTicks(8405), new DateTime(2023, 5, 28, 12, 58, 22, 246, DateTimeKind.Utc).AddTicks(1399), new DateTime(2021, 6, 3, 6, 33, 56, 439, DateTimeKind.Utc).AddTicks(3096), 2L, new DateTime(2022, 5, 3, 2, 0, 55, 876, DateTimeKind.Utc).AddTicks(9321) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 7, 4, 0, 2, 529, DateTimeKind.Utc).AddTicks(2519), new DateTime(2022, 3, 22, 8, 25, 40, 959, DateTimeKind.Utc).AddTicks(24), new DateTime(2021, 3, 14, 18, 22, 27, 4, DateTimeKind.Utc).AddTicks(7050), 1L, new DateTime(2022, 12, 6, 2, 4, 39, 385, DateTimeKind.Utc).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 27, 4, 491, DateTimeKind.Utc).AddTicks(2983), new DateTime(2023, 4, 11, 12, 31, 9, 169, DateTimeKind.Utc).AddTicks(9853), new DateTime(2023, 1, 14, 10, 13, 30, 108, DateTimeKind.Utc).AddTicks(3846), 3L, new DateTime(2023, 2, 17, 23, 2, 17, 627, DateTimeKind.Utc).AddTicks(4106) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 19, 17, 52, 59, 213, DateTimeKind.Utc).AddTicks(7107), new DateTime(2022, 12, 17, 23, 10, 55, 304, DateTimeKind.Utc).AddTicks(8184), new DateTime(2022, 9, 22, 23, 12, 0, 277, DateTimeKind.Utc).AddTicks(3397), 1L, new DateTime(2023, 8, 13, 19, 41, 47, 161, DateTimeKind.Utc).AddTicks(7123) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 20, 1, 1, 48, 597, DateTimeKind.Utc).AddTicks(2920), new DateTime(2023, 9, 11, 3, 27, 50, 283, DateTimeKind.Utc).AddTicks(8700), new DateTime(2023, 4, 19, 21, 45, 14, 398, DateTimeKind.Utc).AddTicks(2602), 1L, new DateTime(2023, 9, 1, 20, 52, 36, 941, DateTimeKind.Utc).AddTicks(462) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 5, 26, 3, 21, 13, 185, DateTimeKind.Utc).AddTicks(8073), new DateTime(2020, 7, 28, 12, 29, 6, 768, DateTimeKind.Utc).AddTicks(2871), new DateTime(2019, 11, 13, 12, 31, 37, 587, DateTimeKind.Utc).AddTicks(9587), 2L, new DateTime(2022, 10, 26, 14, 7, 14, 165, DateTimeKind.Utc).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 9, 5, 1, 17, 37, 251, DateTimeKind.Utc).AddTicks(8889), new DateTime(2022, 8, 15, 10, 21, 30, 81, DateTimeKind.Utc).AddTicks(8221), new DateTime(2021, 4, 2, 4, 11, 17, 733, DateTimeKind.Utc).AddTicks(3856), 1L, new DateTime(2023, 7, 9, 12, 0, 52, 479, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId" },
                values: new object[] { new DateTime(2023, 10, 11, 5, 3, 20, 210, DateTimeKind.Utc).AddTicks(6289), new DateTime(2023, 8, 21, 21, 10, 50, 832, DateTimeKind.Utc).AddTicks(2981), new DateTime(2023, 2, 19, 13, 58, 11, 804, DateTimeKind.Utc).AddTicks(1085), 3L });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 1, 25, 22, 43, 35, 163, DateTimeKind.Utc).AddTicks(8043), new DateTime(2020, 12, 5, 21, 19, 26, 397, DateTimeKind.Utc).AddTicks(4631), new DateTime(2019, 1, 19, 7, 43, 15, 76, DateTimeKind.Utc).AddTicks(6739), 3L, new DateTime(2020, 8, 21, 14, 29, 9, 444, DateTimeKind.Utc).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 23, 17, 40, 15, 404, DateTimeKind.Utc).AddTicks(9666), new DateTime(2023, 8, 4, 3, 3, 7, 942, DateTimeKind.Utc).AddTicks(3375), new DateTime(2020, 12, 26, 5, 42, 37, 478, DateTimeKind.Utc).AddTicks(7322), 3L, new DateTime(2021, 12, 2, 13, 47, 16, 14, DateTimeKind.Utc).AddTicks(2847) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 7, 8, 15, 43, 626, DateTimeKind.Utc).AddTicks(3350), new DateTime(2023, 7, 6, 9, 40, 46, 41, DateTimeKind.Utc).AddTicks(7113), new DateTime(2023, 6, 25, 17, 4, 30, 574, DateTimeKind.Utc).AddTicks(2605), 2L, new DateTime(2023, 7, 22, 3, 44, 53, 337, DateTimeKind.Utc).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 3, 26, 23, 2, 5, 421, DateTimeKind.Utc).AddTicks(3857), new DateTime(2020, 2, 27, 12, 59, 39, 932, DateTimeKind.Utc).AddTicks(1292), new DateTime(2019, 11, 27, 13, 58, 36, 923, DateTimeKind.Utc).AddTicks(1462), 1L, new DateTime(2022, 3, 12, 6, 35, 13, 216, DateTimeKind.Utc).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 10, 30, 527, DateTimeKind.Utc).AddTicks(3122), new DateTime(2023, 5, 31, 14, 23, 26, 529, DateTimeKind.Utc).AddTicks(5576), new DateTime(2022, 3, 4, 11, 51, 35, 949, DateTimeKind.Utc).AddTicks(3119), 1L, new DateTime(2023, 6, 17, 16, 27, 5, 468, DateTimeKind.Utc).AddTicks(5761) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 0, 14, 20, 516, DateTimeKind.Utc).AddTicks(3090), new DateTime(2023, 5, 4, 4, 57, 19, 849, DateTimeKind.Utc).AddTicks(7683), new DateTime(2019, 12, 15, 15, 20, 53, 927, DateTimeKind.Utc).AddTicks(7307), 1L, new DateTime(2022, 5, 15, 1, 42, 2, 321, DateTimeKind.Utc).AddTicks(955) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 3, 27, 4, 36, 19, 124, DateTimeKind.Utc).AddTicks(1194), new DateTime(2020, 3, 21, 18, 12, 57, 190, DateTimeKind.Utc).AddTicks(3798), new DateTime(2017, 7, 19, 21, 39, 52, 728, DateTimeKind.Utc).AddTicks(4575), 1L, new DateTime(2023, 9, 1, 3, 41, 36, 84, DateTimeKind.Utc).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 5, 24, 1, 19, 17, 249, DateTimeKind.Utc).AddTicks(1220), new DateTime(2019, 8, 2, 13, 50, 2, 260, DateTimeKind.Utc).AddTicks(1776), new DateTime(2019, 3, 31, 13, 4, 22, 59, DateTimeKind.Utc).AddTicks(6074), 1L, new DateTime(2020, 9, 19, 6, 55, 13, 70, DateTimeKind.Utc).AddTicks(545) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 10, 15, 23, 913, DateTimeKind.Utc).AddTicks(2924), new DateTime(2023, 4, 5, 8, 52, 39, 307, DateTimeKind.Utc).AddTicks(8708), new DateTime(2021, 4, 12, 19, 10, 12, 560, DateTimeKind.Utc).AddTicks(9484), 2L, new DateTime(2022, 4, 10, 3, 51, 18, 782, DateTimeKind.Utc).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 26, 11, 16, 8, 310, DateTimeKind.Utc).AddTicks(6669), new DateTime(2023, 5, 16, 7, 8, 9, 329, DateTimeKind.Utc).AddTicks(2440), new DateTime(2023, 2, 13, 18, 10, 40, 300, DateTimeKind.Utc).AddTicks(6161), 2L, new DateTime(2023, 4, 3, 19, 53, 20, 585, DateTimeKind.Utc).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId" },
                values: new object[] { new DateTime(2023, 2, 22, 0, 27, 14, 274, DateTimeKind.Utc).AddTicks(7662), new DateTime(2022, 12, 26, 10, 39, 29, 519, DateTimeKind.Utc).AddTicks(7459), new DateTime(2022, 7, 5, 13, 8, 30, 469, DateTimeKind.Utc).AddTicks(2134), 2L });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 3, 25, 59, 714, DateTimeKind.Utc).AddTicks(8779), new DateTime(2023, 5, 27, 21, 33, 28, 374, DateTimeKind.Utc).AddTicks(7157), new DateTime(2023, 3, 26, 21, 31, 27, 354, DateTimeKind.Utc).AddTicks(1875), 1L, new DateTime(2023, 8, 14, 5, 16, 18, 638, DateTimeKind.Utc).AddTicks(392) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 23, 7, 58, 35, 531, DateTimeKind.Utc).AddTicks(6273), new DateTime(2023, 4, 4, 20, 43, 20, 951, DateTimeKind.Utc).AddTicks(7237), new DateTime(2023, 2, 26, 3, 4, 52, 544, DateTimeKind.Utc).AddTicks(1435), 2L, new DateTime(2023, 7, 16, 10, 51, 49, 542, DateTimeKind.Utc).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 12, 14, 27, 31, 208, DateTimeKind.Utc).AddTicks(7775), new DateTime(2023, 7, 21, 15, 9, 26, 409, DateTimeKind.Utc).AddTicks(8615), new DateTime(2021, 8, 6, 2, 21, 44, 624, DateTimeKind.Utc).AddTicks(9119), 3L, new DateTime(2022, 6, 24, 10, 35, 27, 771, DateTimeKind.Utc).AddTicks(6417) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 8, 9, 10, 44, 5, 665, DateTimeKind.Utc).AddTicks(8650), new DateTime(2023, 8, 21, 15, 55, 49, 292, DateTimeKind.Utc).AddTicks(3663), new DateTime(2023, 8, 17, 15, 16, 6, 847, DateTimeKind.Utc).AddTicks(8180), 2L, new DateTime(2023, 8, 30, 6, 41, 57, 134, DateTimeKind.Utc).AddTicks(7233) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 11, 17, 59, 44, 438, DateTimeKind.Utc).AddTicks(947), new DateTime(2022, 4, 2, 20, 22, 3, 946, DateTimeKind.Utc).AddTicks(2358), new DateTime(2022, 2, 10, 3, 4, 41, 528, DateTimeKind.Utc).AddTicks(5765), 3L, new DateTime(2023, 7, 3, 1, 36, 47, 434, DateTimeKind.Utc).AddTicks(4752) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 9, 3, 9, 40, 55, 385, DateTimeKind.Utc).AddTicks(6469), new DateTime(2022, 6, 24, 4, 13, 3, 610, DateTimeKind.Utc).AddTicks(9062), new DateTime(2019, 6, 15, 11, 19, 33, 280, DateTimeKind.Utc).AddTicks(4536), 2L, new DateTime(2019, 8, 24, 10, 47, 44, 114, DateTimeKind.Utc).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 19, 21, 42, 22, 632, DateTimeKind.Utc).AddTicks(3083), new DateTime(2023, 9, 3, 0, 58, 45, 196, DateTimeKind.Utc).AddTicks(7691), new DateTime(2022, 8, 18, 19, 21, 49, 379, DateTimeKind.Utc).AddTicks(3947), 3L, new DateTime(2022, 9, 16, 12, 3, 1, 281, DateTimeKind.Utc).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2019, 12, 2, 22, 8, 59, 299, DateTimeKind.Utc).AddTicks(929), new DateTime(2019, 10, 28, 11, 38, 4, 694, DateTimeKind.Utc).AddTicks(2216), new DateTime(2018, 8, 4, 8, 41, 51, 72, DateTimeKind.Utc).AddTicks(3594), 2L, new DateTime(2021, 3, 20, 4, 54, 21, 518, DateTimeKind.Utc).AddTicks(2713) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 12, 18, 19, 20, 35, 397, DateTimeKind.Utc).AddTicks(5483), new DateTime(2021, 11, 24, 3, 0, 52, 347, DateTimeKind.Utc).AddTicks(9464), new DateTime(2021, 4, 10, 6, 44, 2, 909, DateTimeKind.Utc).AddTicks(3910), 3L, new DateTime(2021, 12, 8, 14, 30, 52, 33, DateTimeKind.Utc).AddTicks(47) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 1, 56, 7, 56, DateTimeKind.Utc).AddTicks(1500), new DateTime(2023, 4, 7, 14, 53, 28, 652, DateTimeKind.Utc).AddTicks(4711), new DateTime(2022, 7, 10, 4, 22, 34, 745, DateTimeKind.Utc).AddTicks(7287), 1L, new DateTime(2023, 4, 20, 8, 45, 15, 117, DateTimeKind.Utc).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 16, 4, 34, 602, DateTimeKind.Utc).AddTicks(3216), new DateTime(2023, 8, 19, 3, 51, 51, 929, DateTimeKind.Utc).AddTicks(6727), new DateTime(2023, 6, 28, 4, 51, 8, 489, DateTimeKind.Utc).AddTicks(1483), 2L, new DateTime(2023, 8, 24, 23, 11, 31, 833, DateTimeKind.Utc).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId" },
                values: new object[] { new DateTime(2024, 2, 25, 18, 58, 6, 283, DateTimeKind.Utc).AddTicks(7687), new DateTime(2023, 6, 29, 12, 50, 27, 635, DateTimeKind.Utc).AddTicks(5521), new DateTime(2023, 5, 24, 13, 8, 37, 361, DateTimeKind.Utc).AddTicks(9479), 3L });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 3, 25, 53, 51, DateTimeKind.Utc).AddTicks(9277), new DateTime(2022, 7, 10, 17, 37, 51, 619, DateTimeKind.Utc).AddTicks(9040), new DateTime(2020, 12, 18, 15, 17, 21, 594, DateTimeKind.Utc).AddTicks(4321), 3L, new DateTime(2022, 8, 8, 17, 34, 6, 205, DateTimeKind.Utc).AddTicks(6492) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 20, 56, 18, 404, DateTimeKind.Utc).AddTicks(3216), new DateTime(2020, 1, 26, 6, 7, 40, 406, DateTimeKind.Utc).AddTicks(9947), new DateTime(2019, 11, 29, 20, 22, 6, 645, DateTimeKind.Utc).AddTicks(9489), 1L, new DateTime(2023, 6, 13, 15, 9, 55, 404, DateTimeKind.Utc).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 18, 10, 50, 880, DateTimeKind.Utc).AddTicks(5097), new DateTime(2023, 7, 17, 5, 37, 29, 481, DateTimeKind.Utc).AddTicks(9297), new DateTime(2020, 6, 7, 11, 13, 7, 420, DateTimeKind.Utc).AddTicks(6879), 1L, new DateTime(2020, 11, 4, 1, 12, 47, 349, DateTimeKind.Utc).AddTicks(5747) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 26, 14, 29, 24, 781, DateTimeKind.Utc).AddTicks(762), new DateTime(2023, 8, 21, 17, 4, 36, 941, DateTimeKind.Utc).AddTicks(3132), new DateTime(2023, 8, 7, 9, 13, 51, 631, DateTimeKind.Utc).AddTicks(8530), 2L, new DateTime(2023, 9, 5, 19, 3, 17, 505, DateTimeKind.Utc).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 5, 23, 33, 37, DateTimeKind.Utc).AddTicks(3595), new DateTime(2023, 8, 16, 23, 27, 5, 871, DateTimeKind.Utc).AddTicks(9626), new DateTime(2023, 7, 2, 19, 28, 42, 264, DateTimeKind.Utc).AddTicks(5559), 3L, new DateTime(2023, 7, 27, 16, 1, 43, 471, DateTimeKind.Utc).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 17, 55, 311, DateTimeKind.Utc).AddTicks(6564), new DateTime(2023, 4, 26, 0, 28, 13, 25, DateTimeKind.Utc).AddTicks(1237), new DateTime(2022, 9, 17, 13, 49, 34, 713, DateTimeKind.Utc).AddTicks(4546), 2L, new DateTime(2023, 3, 22, 12, 56, 0, 837, DateTimeKind.Utc).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 19, 9, 44, 32, 600, DateTimeKind.Utc).AddTicks(6973), new DateTime(2022, 2, 15, 3, 38, 18, 618, DateTimeKind.Utc).AddTicks(2456), new DateTime(2020, 6, 14, 13, 9, 24, 972, DateTimeKind.Utc).AddTicks(5554), 1L, new DateTime(2021, 11, 23, 16, 37, 16, 393, DateTimeKind.Utc).AddTicks(3448) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 22, 19, 30, 52, 49, DateTimeKind.Utc).AddTicks(5758), new DateTime(2023, 8, 30, 7, 40, 56, 82, DateTimeKind.Utc).AddTicks(2483), new DateTime(2023, 4, 16, 18, 47, 16, 417, DateTimeKind.Utc).AddTicks(3990), 1L, new DateTime(2023, 8, 12, 21, 59, 35, 187, DateTimeKind.Utc).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 7, 4, 13, 37, 37, 543, DateTimeKind.Utc).AddTicks(4195), new DateTime(2021, 12, 13, 13, 15, 11, 782, DateTimeKind.Utc).AddTicks(9050), new DateTime(2020, 1, 4, 23, 38, 35, 760, DateTimeKind.Utc).AddTicks(6929), 2L, new DateTime(2021, 2, 23, 5, 33, 50, 75, DateTimeKind.Utc).AddTicks(4090) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 6, 21, 4, 33, 48, 775, DateTimeKind.Utc).AddTicks(465), new DateTime(2023, 8, 30, 7, 34, 41, 133, DateTimeKind.Utc).AddTicks(8905), new DateTime(2023, 4, 5, 1, 10, 28, 723, DateTimeKind.Utc).AddTicks(6157), 1L, new DateTime(2023, 8, 26, 18, 37, 24, 620, DateTimeKind.Utc).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId" },
                values: new object[] { new DateTime(2021, 8, 14, 4, 47, 29, 58, DateTimeKind.Utc).AddTicks(8338), new DateTime(2021, 7, 1, 5, 43, 33, 223, DateTimeKind.Utc).AddTicks(1669), new DateTime(2020, 3, 6, 15, 28, 51, 181, DateTimeKind.Utc).AddTicks(7992), 2L });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 4, 29, 15, 45, 0, 236, DateTimeKind.Utc).AddTicks(918), new DateTime(2021, 5, 13, 9, 18, 24, 927, DateTimeKind.Utc).AddTicks(2526), new DateTime(2019, 10, 31, 2, 37, 54, 682, DateTimeKind.Utc).AddTicks(2588), 1L, new DateTime(2023, 2, 17, 7, 12, 41, 980, DateTimeKind.Utc).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 18, 19, 5, 55, 95, DateTimeKind.Utc).AddTicks(3110), new DateTime(2023, 8, 8, 4, 52, 59, 314, DateTimeKind.Utc).AddTicks(2875), new DateTime(2023, 7, 7, 4, 54, 55, 463, DateTimeKind.Utc).AddTicks(3905), 3L, new DateTime(2023, 8, 2, 13, 34, 15, 13, DateTimeKind.Utc).AddTicks(1502) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 44, 7, 954, DateTimeKind.Utc).AddTicks(5224), new DateTime(2023, 8, 6, 9, 25, 14, 451, DateTimeKind.Utc).AddTicks(9612), new DateTime(2022, 3, 24, 23, 36, 25, 453, DateTimeKind.Utc).AddTicks(4370), 1L, new DateTime(2022, 4, 13, 5, 59, 1, 801, DateTimeKind.Utc).AddTicks(634) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 3, 26, 14, 7, 20, 329, DateTimeKind.Utc).AddTicks(464), new DateTime(2022, 9, 11, 1, 59, 22, 803, DateTimeKind.Utc).AddTicks(1913), new DateTime(2021, 10, 21, 8, 20, 11, 24, DateTimeKind.Utc).AddTicks(7113), 1L, new DateTime(2022, 4, 13, 13, 50, 19, 140, DateTimeKind.Utc).AddTicks(3796) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 1, 20, 3, 48, 9, 292, DateTimeKind.Utc).AddTicks(7362), new DateTime(2022, 9, 23, 3, 15, 30, 375, DateTimeKind.Utc).AddTicks(9013), new DateTime(2022, 8, 8, 6, 9, 49, 112, DateTimeKind.Utc).AddTicks(6500), 3L, new DateTime(2023, 8, 4, 21, 41, 28, 364, DateTimeKind.Utc).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 5, 8, 17, 58, 493, DateTimeKind.Utc).AddTicks(5052), new DateTime(2023, 9, 10, 21, 34, 26, 252, DateTimeKind.Utc).AddTicks(2280), new DateTime(2023, 7, 8, 22, 15, 41, 34, DateTimeKind.Utc).AddTicks(3247), 1L, new DateTime(2023, 7, 16, 9, 46, 10, 35, DateTimeKind.Utc).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 3, 20, 11, 47, 364, DateTimeKind.Utc).AddTicks(8984), new DateTime(2022, 9, 19, 0, 41, 35, 518, DateTimeKind.Utc).AddTicks(1788), new DateTime(2022, 6, 9, 16, 55, 17, 112, DateTimeKind.Utc).AddTicks(6184), 1L, new DateTime(2022, 12, 12, 17, 14, 33, 645, DateTimeKind.Utc).AddTicks(3422) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 30, 11, 13, 4, 696, DateTimeKind.Utc).AddTicks(7929), new DateTime(2023, 3, 14, 6, 38, 56, 853, DateTimeKind.Utc).AddTicks(7119), new DateTime(2023, 2, 18, 13, 43, 18, 583, DateTimeKind.Utc).AddTicks(988), 3L, new DateTime(2023, 5, 5, 1, 10, 3, 536, DateTimeKind.Utc).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 11, 9, 49, 44, 378, DateTimeKind.Utc).AddTicks(184), new DateTime(2022, 12, 2, 1, 18, 28, 355, DateTimeKind.Utc).AddTicks(141), new DateTime(2017, 4, 19, 8, 35, 19, 204, DateTimeKind.Utc).AddTicks(6160), 2L, new DateTime(2023, 7, 15, 11, 39, 26, 874, DateTimeKind.Utc).AddTicks(7582) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 23, 1, 38, 23, 222, DateTimeKind.Utc).AddTicks(8573), new DateTime(2023, 1, 15, 11, 26, 32, 34, DateTimeKind.Utc).AddTicks(9657), new DateTime(2022, 11, 1, 7, 15, 27, 610, DateTimeKind.Utc).AddTicks(1331), 1L, new DateTime(2023, 3, 15, 4, 5, 46, 62, DateTimeKind.Utc).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 3, 23, 17, 30, 932, DateTimeKind.Utc).AddTicks(1175), new DateTime(2022, 8, 22, 18, 0, 37, 59, DateTimeKind.Utc).AddTicks(7028), new DateTime(2021, 10, 11, 11, 18, 58, 21, DateTimeKind.Utc).AddTicks(2275), 1L, new DateTime(2023, 4, 4, 15, 58, 51, 241, DateTimeKind.Utc).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 9, 12, 13, 39, 845, DateTimeKind.Utc).AddTicks(673), new DateTime(2023, 3, 30, 13, 13, 32, 323, DateTimeKind.Utc).AddTicks(1088), new DateTime(2019, 11, 4, 21, 33, 3, 180, DateTimeKind.Utc).AddTicks(7642), 2L, new DateTime(2020, 8, 26, 22, 2, 8, 610, DateTimeKind.Utc).AddTicks(3055) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 12, 9, 41, 0, 824, DateTimeKind.Utc).AddTicks(7642), new DateTime(2023, 5, 15, 19, 18, 7, 937, DateTimeKind.Utc).AddTicks(214), new DateTime(2022, 3, 2, 15, 13, 50, 150, DateTimeKind.Utc).AddTicks(9410), 1L, new DateTime(2022, 7, 13, 20, 53, 48, 593, DateTimeKind.Utc).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 27, 12, 31, 13, 99, DateTimeKind.Utc).AddTicks(3482), new DateTime(2022, 10, 28, 17, 59, 44, 963, DateTimeKind.Utc).AddTicks(7528), new DateTime(2022, 6, 2, 11, 34, 25, 896, DateTimeKind.Utc).AddTicks(3146), 2L, new DateTime(2023, 4, 11, 20, 37, 54, 540, DateTimeKind.Utc).AddTicks(6159) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 6, 7, 18, 49, 9, 71, DateTimeKind.Utc).AddTicks(178), new DateTime(2021, 8, 10, 3, 43, 40, 333, DateTimeKind.Utc).AddTicks(3670), new DateTime(2021, 6, 23, 11, 34, 12, 853, DateTimeKind.Utc).AddTicks(9327), 2L, new DateTime(2022, 4, 6, 1, 30, 36, 376, DateTimeKind.Utc).AddTicks(8523) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 10, 22, 36, 13, 960, DateTimeKind.Utc).AddTicks(6386), new DateTime(2023, 9, 3, 21, 29, 15, 85, DateTimeKind.Utc).AddTicks(4327), new DateTime(2019, 3, 25, 16, 17, 8, 72, DateTimeKind.Utc).AddTicks(5098), 1L, new DateTime(2020, 11, 15, 19, 35, 57, 247, DateTimeKind.Utc).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 3, 9, 48, 59, 38, DateTimeKind.Utc).AddTicks(9580), new DateTime(2022, 10, 25, 7, 30, 13, 453, DateTimeKind.Utc).AddTicks(9777), new DateTime(2022, 6, 16, 5, 55, 34, 631, DateTimeKind.Utc).AddTicks(9546), 3L, new DateTime(2022, 12, 21, 15, 0, 38, 857, DateTimeKind.Utc).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2018, 4, 5, 8, 48, 7, 845, DateTimeKind.Utc).AddTicks(8886), new DateTime(2018, 3, 19, 7, 3, 10, 323, DateTimeKind.Utc).AddTicks(7774), new DateTime(2017, 9, 19, 21, 4, 35, 884, DateTimeKind.Utc).AddTicks(1318), 3L, new DateTime(2019, 7, 11, 19, 27, 37, 759, DateTimeKind.Utc).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 8, 2, 1, 31, 13, 678, DateTimeKind.Utc).AddTicks(4708), new DateTime(2023, 8, 6, 12, 44, 45, 695, DateTimeKind.Utc).AddTicks(9453), new DateTime(2023, 7, 5, 7, 17, 4, 982, DateTimeKind.Utc).AddTicks(212), 1L, new DateTime(2023, 7, 11, 0, 49, 46, 614, DateTimeKind.Utc).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 2, 21, 17, 140, DateTimeKind.Utc).AddTicks(9161), new DateTime(2023, 1, 23, 4, 37, 28, 903, DateTimeKind.Utc).AddTicks(5964), new DateTime(2021, 7, 6, 9, 27, 42, 35, DateTimeKind.Utc).AddTicks(6644), 2L, new DateTime(2022, 11, 3, 9, 15, 5, 624, DateTimeKind.Utc).AddTicks(9013) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 3, 21, 15, 56, 49, 497, DateTimeKind.Utc).AddTicks(9846), new DateTime(2022, 2, 25, 13, 22, 31, 738, DateTimeKind.Utc).AddTicks(2170), new DateTime(2021, 10, 31, 3, 17, 59, 297, DateTimeKind.Utc).AddTicks(9376), 1L, new DateTime(2023, 2, 6, 21, 6, 55, 940, DateTimeKind.Utc).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 13, 39, 39, 85, DateTimeKind.Utc).AddTicks(5603), new DateTime(2023, 4, 28, 5, 25, 31, 516, DateTimeKind.Utc).AddTicks(4832), new DateTime(2022, 10, 12, 23, 37, 41, 864, DateTimeKind.Utc).AddTicks(7359), 2L, new DateTime(2023, 8, 25, 5, 44, 44, 730, DateTimeKind.Utc).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 2, 26, 1, 768, DateTimeKind.Utc).AddTicks(8559), new DateTime(2023, 8, 17, 7, 14, 0, 771, DateTimeKind.Utc).AddTicks(4604), new DateTime(2022, 3, 11, 6, 38, 51, 158, DateTimeKind.Utc).AddTicks(8253), 1L, new DateTime(2022, 8, 25, 14, 14, 52, 793, DateTimeKind.Utc).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 6, 18, 11, 657, DateTimeKind.Utc).AddTicks(6445), new DateTime(2023, 6, 25, 19, 8, 15, 442, DateTimeKind.Utc).AddTicks(4999), new DateTime(2021, 7, 8, 8, 27, 19, 656, DateTimeKind.Utc).AddTicks(7773), 1L, new DateTime(2021, 12, 12, 4, 26, 39, 862, DateTimeKind.Utc).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 4, 8, 25, 11, 46, DateTimeKind.Utc).AddTicks(4187), new DateTime(2023, 8, 17, 17, 21, 37, 873, DateTimeKind.Utc).AddTicks(7014), new DateTime(2023, 7, 4, 18, 53, 36, 618, DateTimeKind.Utc).AddTicks(1462), 3L, new DateTime(2023, 9, 5, 13, 36, 56, 805, DateTimeKind.Utc).AddTicks(3818) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 8, 13, 22, 13, 145, DateTimeKind.Utc).AddTicks(4060), new DateTime(2023, 5, 13, 10, 49, 55, 218, DateTimeKind.Utc).AddTicks(8649), new DateTime(2023, 3, 23, 12, 38, 31, 604, DateTimeKind.Utc).AddTicks(6814), 2L, new DateTime(2023, 3, 29, 3, 21, 8, 432, DateTimeKind.Utc).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 19, 6, 37, 14, 499, DateTimeKind.Utc).AddTicks(3256), new DateTime(2022, 12, 31, 23, 54, 47, 917, DateTimeKind.Utc).AddTicks(1103), new DateTime(2022, 2, 21, 4, 53, 20, 766, DateTimeKind.Utc).AddTicks(6271), 2L, new DateTime(2022, 7, 18, 12, 22, 57, 623, DateTimeKind.Utc).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId" },
                values: new object[] { new DateTime(2023, 7, 3, 21, 57, 8, 177, DateTimeKind.Utc).AddTicks(297), new DateTime(2023, 6, 4, 10, 48, 42, 644, DateTimeKind.Utc).AddTicks(5958), new DateTime(2022, 1, 9, 0, 45, 53, 782, DateTimeKind.Utc).AddTicks(5756), 1L });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 4, 17, 35, 0, 695, DateTimeKind.Utc).AddTicks(8991), new DateTime(2022, 12, 29, 18, 37, 25, 703, DateTimeKind.Utc).AddTicks(269), new DateTime(2022, 11, 10, 14, 36, 31, 336, DateTimeKind.Utc).AddTicks(407), 1L, new DateTime(2023, 9, 4, 6, 46, 19, 934, DateTimeKind.Utc).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 21, 13, 23, 621, DateTimeKind.Utc).AddTicks(8918), new DateTime(2018, 11, 23, 12, 42, 50, 201, DateTimeKind.Utc).AddTicks(5130), new DateTime(2017, 4, 11, 18, 44, 19, 735, DateTimeKind.Utc).AddTicks(9890), 3L, new DateTime(2017, 12, 27, 15, 47, 46, 350, DateTimeKind.Utc).AddTicks(5116) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 6, 22, 45, 12, 990, DateTimeKind.Utc).AddTicks(4702), new DateTime(2022, 9, 27, 18, 13, 28, 295, DateTimeKind.Utc).AddTicks(5970), new DateTime(2021, 11, 1, 3, 49, 48, 618, DateTimeKind.Utc).AddTicks(945), 1L, new DateTime(2022, 8, 6, 8, 30, 23, 904, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 12, 15, 18, 15, 907, DateTimeKind.Utc).AddTicks(4395), new DateTime(2023, 9, 8, 16, 38, 6, 122, DateTimeKind.Utc).AddTicks(3767), new DateTime(2023, 9, 6, 17, 6, 38, 788, DateTimeKind.Utc).AddTicks(8575), 2L, new DateTime(2023, 9, 8, 21, 8, 57, 847, DateTimeKind.Utc).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 10, 23, 2, 36, 8, 285, DateTimeKind.Utc).AddTicks(4464), new DateTime(2021, 11, 24, 7, 28, 51, 938, DateTimeKind.Utc).AddTicks(5690), new DateTime(2018, 4, 20, 18, 29, 10, 678, DateTimeKind.Utc).AddTicks(7068), 3L, new DateTime(2019, 7, 12, 10, 57, 53, 220, DateTimeKind.Utc).AddTicks(9022) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 6, 52, 48, 965, DateTimeKind.Utc).AddTicks(9495), new DateTime(2023, 9, 8, 12, 1, 55, 479, DateTimeKind.Utc).AddTicks(7242), new DateTime(2023, 8, 31, 22, 36, 8, 877, DateTimeKind.Utc).AddTicks(7008), 1L, new DateTime(2023, 9, 4, 18, 22, 4, 790, DateTimeKind.Utc).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 6, 7, 6, 1, 31, 557, DateTimeKind.Utc).AddTicks(6033), new DateTime(2023, 4, 9, 14, 0, 7, 652, DateTimeKind.Utc).AddTicks(1508), new DateTime(2016, 11, 13, 18, 1, 40, 837, DateTimeKind.Utc).AddTicks(5009), 1L, new DateTime(2020, 9, 27, 19, 6, 41, 7, DateTimeKind.Utc).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 11, 8, 27, 45, 431, DateTimeKind.Utc).AddTicks(7685), new DateTime(2023, 4, 7, 10, 51, 39, 202, DateTimeKind.Utc).AddTicks(4842), new DateTime(2022, 9, 3, 20, 39, 10, 852, DateTimeKind.Utc).AddTicks(531), 1L, new DateTime(2023, 8, 20, 8, 0, 38, 226, DateTimeKind.Utc).AddTicks(9593) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 23, 19, 456, DateTimeKind.Utc).AddTicks(741), new DateTime(2023, 4, 10, 9, 16, 35, 525, DateTimeKind.Utc).AddTicks(7110), new DateTime(2023, 4, 5, 6, 7, 32, 295, DateTimeKind.Utc).AddTicks(331), 3L, new DateTime(2023, 8, 6, 19, 12, 12, 210, DateTimeKind.Utc).AddTicks(7321) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 2, 11, 19, 10, 54, 498, DateTimeKind.Utc).AddTicks(9409), new DateTime(2021, 1, 29, 2, 8, 38, 750, DateTimeKind.Utc).AddTicks(3695), new DateTime(2019, 6, 24, 7, 48, 2, 657, DateTimeKind.Utc).AddTicks(7816), 3L, new DateTime(2022, 10, 3, 21, 4, 23, 548, DateTimeKind.Utc).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 22, 6, 13, 47, 348, DateTimeKind.Utc).AddTicks(5130), new DateTime(2023, 5, 8, 0, 34, 19, 893, DateTimeKind.Utc).AddTicks(3369), new DateTime(2022, 9, 26, 20, 10, 28, 533, DateTimeKind.Utc).AddTicks(9098), 3L, new DateTime(2023, 1, 13, 13, 38, 7, 698, DateTimeKind.Utc).AddTicks(2024) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId" },
                values: new object[] { new DateTime(2024, 3, 6, 0, 7, 31, 443, DateTimeKind.Utc).AddTicks(3179), new DateTime(2023, 6, 3, 16, 18, 38, 288, DateTimeKind.Utc).AddTicks(9602), new DateTime(2019, 4, 6, 10, 31, 34, 842, DateTimeKind.Utc).AddTicks(2242), 1L });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 9, 26, 4, 36, 55, 622, DateTimeKind.Utc).AddTicks(5256), new DateTime(2021, 9, 29, 21, 46, 33, 677, DateTimeKind.Utc).AddTicks(4891), new DateTime(2021, 4, 4, 5, 30, 13, 332, DateTimeKind.Utc).AddTicks(6608), 1L, new DateTime(2023, 6, 3, 16, 0, 24, 438, DateTimeKind.Utc).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 6, 1, 34, 1, 923, DateTimeKind.Utc).AddTicks(8635), new DateTime(2023, 8, 1, 1, 41, 51, 145, DateTimeKind.Utc).AddTicks(8207), new DateTime(2023, 7, 19, 19, 36, 47, 904, DateTimeKind.Utc).AddTicks(9467), 1L, new DateTime(2023, 8, 18, 2, 43, 12, 50, DateTimeKind.Utc).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 29, 3, 14, 33, 720, DateTimeKind.Utc).AddTicks(5174), new DateTime(2023, 6, 10, 14, 15, 50, 141, DateTimeKind.Utc).AddTicks(1768), new DateTime(2023, 1, 17, 9, 13, 13, 539, DateTimeKind.Utc).AddTicks(9140), 1L, new DateTime(2023, 3, 23, 7, 38, 29, 540, DateTimeKind.Utc).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 21, 8, 16, 36, 115, DateTimeKind.Utc).AddTicks(9391), new DateTime(2023, 2, 3, 17, 37, 53, 522, DateTimeKind.Utc).AddTicks(9066), new DateTime(2022, 5, 27, 22, 5, 45, 757, DateTimeKind.Utc).AddTicks(5234), 3L, new DateTime(2023, 3, 5, 0, 41, 44, 874, DateTimeKind.Utc).AddTicks(4594) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 5, 18, 10, 52, 44, 494, DateTimeKind.Utc).AddTicks(4732), new DateTime(2020, 6, 25, 1, 25, 2, 712, DateTimeKind.Utc).AddTicks(3625), new DateTime(2017, 10, 11, 21, 56, 5, 259, DateTimeKind.Utc).AddTicks(8526), 1L, new DateTime(2018, 6, 1, 5, 15, 33, 923, DateTimeKind.Utc).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 3, 15, 13, 15, 261, DateTimeKind.Utc).AddTicks(8050), new DateTime(2023, 7, 23, 7, 37, 25, 243, DateTimeKind.Utc).AddTicks(3327), new DateTime(2021, 5, 19, 4, 27, 27, 698, DateTimeKind.Utc).AddTicks(2190), 3L, new DateTime(2021, 10, 11, 7, 13, 44, 577, DateTimeKind.Utc).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 20, 7, 28, 44, 143, DateTimeKind.Utc).AddTicks(2098), new DateTime(2023, 2, 25, 18, 10, 0, 891, DateTimeKind.Utc).AddTicks(5184), new DateTime(2022, 12, 17, 3, 55, 13, 127, DateTimeKind.Utc).AddTicks(9188), 1L, new DateTime(2023, 2, 10, 12, 51, 10, 129, DateTimeKind.Utc).AddTicks(2536) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 7, 20, 0, 42, 999, DateTimeKind.Utc).AddTicks(9872), new DateTime(2023, 8, 1, 16, 17, 31, 134, DateTimeKind.Utc).AddTicks(7797), new DateTime(2022, 12, 30, 20, 53, 57, 646, DateTimeKind.Utc).AddTicks(6455), 1L, new DateTime(2023, 8, 6, 17, 56, 42, 849, DateTimeKind.Utc).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 8, 26, 6, 57, 17, 729, DateTimeKind.Utc).AddTicks(9800), new DateTime(2022, 5, 24, 9, 53, 44, 347, DateTimeKind.Utc).AddTicks(5978), new DateTime(2021, 7, 5, 19, 42, 1, 539, DateTimeKind.Utc).AddTicks(6717), 1L, new DateTime(2022, 1, 27, 15, 7, 19, 58, DateTimeKind.Utc).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 23, 58, 2, 150, DateTimeKind.Utc).AddTicks(3795), new DateTime(2023, 9, 1, 5, 29, 31, 530, DateTimeKind.Utc).AddTicks(3371), new DateTime(2023, 6, 14, 21, 4, 17, 279, DateTimeKind.Utc).AddTicks(3906), 2L, new DateTime(2023, 7, 29, 2, 22, 58, 512, DateTimeKind.Utc).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 28, 10, 4, 45, 890, DateTimeKind.Utc).AddTicks(9087), new DateTime(2023, 8, 29, 22, 4, 25, 176, DateTimeKind.Utc).AddTicks(1749), new DateTime(2023, 8, 11, 2, 25, 59, 693, DateTimeKind.Utc).AddTicks(2796), 1L, new DateTime(2023, 8, 26, 4, 25, 26, 61, DateTimeKind.Utc).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 4, 3, 19, 29, 56, 888, DateTimeKind.Utc).AddTicks(8760), new DateTime(2020, 12, 12, 20, 34, 11, 288, DateTimeKind.Utc).AddTicks(5708), new DateTime(2019, 10, 9, 19, 8, 22, 410, DateTimeKind.Utc).AddTicks(8277), 2L, new DateTime(2023, 7, 30, 14, 15, 15, 866, DateTimeKind.Utc).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 21, 48, 49, 626, DateTimeKind.Utc).AddTicks(7108), new DateTime(2023, 4, 19, 15, 48, 49, 835, DateTimeKind.Utc).AddTicks(7521), new DateTime(2022, 11, 16, 17, 38, 41, 185, DateTimeKind.Utc).AddTicks(1146), 3L, new DateTime(2023, 1, 19, 20, 40, 6, 314, DateTimeKind.Utc).AddTicks(5298) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 1, 5, 2, 51, 39, 867, DateTimeKind.Utc).AddTicks(2568), new DateTime(2022, 9, 3, 10, 1, 0, 610, DateTimeKind.Utc).AddTicks(9852), new DateTime(2022, 8, 22, 11, 49, 49, 810, DateTimeKind.Utc).AddTicks(3707), 1L, new DateTime(2023, 1, 28, 14, 46, 48, 231, DateTimeKind.Utc).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 10, 24, 22, 37, 50, 179, DateTimeKind.Utc).AddTicks(5920), new DateTime(2019, 11, 16, 3, 9, 19, 285, DateTimeKind.Utc).AddTicks(5335), new DateTime(2017, 6, 28, 8, 44, 42, 549, DateTimeKind.Utc).AddTicks(8706), 2L, new DateTime(2018, 8, 8, 16, 41, 49, 694, DateTimeKind.Utc).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 29, 5, 49, 56, 715, DateTimeKind.Utc).AddTicks(3483), new DateTime(2023, 7, 25, 17, 31, 0, 729, DateTimeKind.Utc).AddTicks(4153), new DateTime(2023, 7, 1, 2, 45, 43, 635, DateTimeKind.Utc).AddTicks(1323), 1L, new DateTime(2023, 7, 15, 21, 34, 20, 574, DateTimeKind.Utc).AddTicks(9911) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 22, 22, 47, 51, 277, DateTimeKind.Utc).AddTicks(277), new DateTime(2022, 11, 26, 12, 0, 55, 560, DateTimeKind.Utc).AddTicks(2498), new DateTime(2022, 5, 12, 21, 48, 10, 791, DateTimeKind.Utc).AddTicks(2282), 1L, new DateTime(2023, 1, 9, 3, 22, 12, 298, DateTimeKind.Utc).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 1, 5, 9, 5, 51, 709, DateTimeKind.Utc).AddTicks(2371), new DateTime(2020, 5, 1, 10, 59, 54, 719, DateTimeKind.Utc).AddTicks(9207), new DateTime(2019, 8, 30, 13, 18, 24, 619, DateTimeKind.Utc).AddTicks(8183), 1L, new DateTime(2020, 12, 2, 15, 17, 44, 874, DateTimeKind.Utc).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 8, 1, 1, 36, 196, DateTimeKind.Utc).AddTicks(9168), new DateTime(2023, 8, 10, 15, 29, 53, 290, DateTimeKind.Utc).AddTicks(3444), new DateTime(2023, 5, 2, 2, 13, 36, 733, DateTimeKind.Utc).AddTicks(1035), 3L, new DateTime(2023, 8, 27, 22, 11, 23, 642, DateTimeKind.Utc).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 22, 19, 1, 13, 294, DateTimeKind.Utc).AddTicks(7323), new DateTime(2022, 8, 18, 13, 2, 8, 660, DateTimeKind.Utc).AddTicks(3041), new DateTime(2022, 6, 18, 22, 5, 46, 303, DateTimeKind.Utc).AddTicks(206), 1L, new DateTime(2022, 10, 10, 0, 25, 45, 516, DateTimeKind.Utc).AddTicks(9718) });

            migrationBuilder.CreateIndex(
                name: "IX_ChallengeTags_TagId",
                table: "ChallengeTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPreferredLanguage_UserId",
                table: "UserPreferredLanguage",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Challenge_ChallengeLevel_LevelId",
                table: "Challenges",
                column: "LevelId",
                principalTable: "ChallengeLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChallengeVersionLanguageVersion_LanguageVersion_LanguageVersionId",
                table: "ChallengeVersionLanguageVersion",
                column: "LanguageVersionId",
                principalTable: "LanguageVersions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChallengeVersion_Language_LanguageId",
                table: "ChallengeVersions",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LanguageVersion_Language_LanguageId",
                table: "LanguageVersions",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscription_SubscriptionTypes_TypeId",
                table: "Subscriptions",
                column: "TypeId",
                principalTable: "SubscriptionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLanguageLevel_Languages_LanguageId",
                table: "UserLanguageLevels",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Challenge_ChallengeLevel_LevelId",
                table: "Challenges");

            migrationBuilder.DropForeignKey(
                name: "FK_ChallengeVersionLanguageVersion_LanguageVersion_LanguageVersionId",
                table: "ChallengeVersionLanguageVersion");

            migrationBuilder.DropForeignKey(
                name: "FK_ChallengeVersion_Language_LanguageId",
                table: "ChallengeVersions");

            migrationBuilder.DropForeignKey(
                name: "FK_LanguageVersion_Language_LanguageId",
                table: "LanguageVersions");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscription_SubscriptionTypes_TypeId",
                table: "Subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLanguageLevel_Languages_LanguageId",
                table: "UserLanguageLevels");

            migrationBuilder.DropTable(
                name: "ChallengeTags");

            migrationBuilder.DropTable(
                name: "UserPreferredLanguage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLanguageLevel",
                table: "UserLanguageLevels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tag",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubscriptionType",
                table: "SubscriptionTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LanguageVersion",
                table: "LanguageVersions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Language",
                table: "Languages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChallengesVersionLanguagesVersion",
                table: "ChallengeVersionLanguageVersion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChallengeLevel",
                table: "ChallengeLevels");

            migrationBuilder.DeleteData(
                table: "ChallengeLevels",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ChallengeLevels",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "ChallengeLevels",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "ChallengeLevels",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "LanguageVersions",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "LanguageVersions",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "LanguageVersions",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "LanguageVersions",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "LanguageVersions",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "LanguageVersions",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "LanguageVersions",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "LanguageVersions",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "LanguageVersions",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "SubscriptionTypes",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "SubscriptionTypes",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "SubscriptionTypes",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DropColumn(
                name: "ExampleTestCases",
                table: "ChallengeVersions");

            migrationBuilder.DropColumn(
                name: "PreloadedCode",
                table: "ChallengeVersions");

            migrationBuilder.DropColumn(
                name: "TestCases",
                table: "ChallengeVersions");

            migrationBuilder.AlterColumn<int>(
                name: "LanguageId",
                table: "UserLanguageLevels",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Tags",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "SubscriptionTypes",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "Subscriptions",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "LanguageId",
                table: "LanguageVersions",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "LanguageVersions",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Languages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "LanguageId",
                table: "ChallengeVersions",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "LanguageVersionId",
                table: "ChallengeVersionLanguageVersion",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "LevelId",
                table: "Challenges",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ChallengeLevels",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLanguageLevels",
                table: "UserLanguageLevels",
                columns: new[] { "UserId", "LanguageId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubscriptionTypes",
                table: "SubscriptionTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LanguageVersions",
                table: "LanguageVersions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Languages",
                table: "Languages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChallengeVersionLanguageVersion",
                table: "ChallengeVersionLanguageVersion",
                columns: new[] { "ChallengeVersionId", "LanguageVersionId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChallengeLevels",
                table: "ChallengeLevels",
                column: "Id");

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

            migrationBuilder.InsertData(
                table: "ChallengeLevels",
                columns: new[] { "Id", "Name", "Reward", "SkillLevel" },
                values: new object[,]
                {
                    { 1, "Easy", 10, 0 },
                    { 2, "Medium", 20, 0 },
                    { 3, "Difficult", 30, 0 },
                    { 4, "Extreme", 40, 0 }
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

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 22, 8, 17, 181, DateTimeKind.Utc).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 26, 17, 11, 2, 624, DateTimeKind.Utc).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 17, 2, 48, 54, 923, DateTimeKind.Utc).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 2, 22, 45, 2, 630, DateTimeKind.Utc).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 20, 20, 30, 3, 33, DateTimeKind.Utc).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 15, 16, 10, 29, 871, DateTimeKind.Utc).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 14, 2, 31, 53, 138, DateTimeKind.Utc).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 9, 16, 19, 155, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 30, 8, 12, 46, 452, DateTimeKind.Utc).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 17, 21, 12, 43, 864, DateTimeKind.Utc).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 14, 8, 25, 2, 163, DateTimeKind.Utc).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 11, 7, 15, 25, 958, DateTimeKind.Utc).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 26, 19, 3, 24, 5, DateTimeKind.Utc).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 21, 11, 56, 39, 187, DateTimeKind.Utc).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 3, 20, 54, 133, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 0, 56, 1, 425, DateTimeKind.Utc).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 5, 2, 29, 43, 139, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 17, 29, 28, 885, DateTimeKind.Utc).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 9, 11, 34, 2, 976, DateTimeKind.Utc).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 30, 22, 2, 28, 305, DateTimeKind.Utc).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 22, 15, 52, 49, 646, DateTimeKind.Utc).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 7, 4, 44, 51, 855, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 26, 17, 44, 21, 15, DateTimeKind.Utc).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 22, 3, 35, 324, DateTimeKind.Utc).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 18, 14, 0, 52, 682, DateTimeKind.Utc).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 3, 23, 56, 34, 601, DateTimeKind.Utc).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 9, 0, 19, 83, DateTimeKind.Utc).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 22, 22, 11, 5, 11, DateTimeKind.Utc).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 11, 4, 54, 45, 280, DateTimeKind.Utc).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 5, 6, 32, 45, 997, DateTimeKind.Utc).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 22, 17, 40, 35, 382, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 19, 22, 44, 23, 741, DateTimeKind.Utc).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 2, 9, 47, 44, 762, DateTimeKind.Utc).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 3, 5, 49, 25, 719, DateTimeKind.Utc).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedAt",
                value: new DateTime(2020, 3, 25, 0, 33, 30, 815, DateTimeKind.Utc).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 4, 9, 10, 8, 329, DateTimeKind.Utc).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 14, 0, 0, 43, 602, DateTimeKind.Utc).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 29, 4, 33, 1, 352, DateTimeKind.Utc).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 7, 8, 7, 19, 798, DateTimeKind.Utc).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 11, 19, 29, 12, 583, DateTimeKind.Utc).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 20, 15, 51, 4, 327, DateTimeKind.Utc).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 10, 10, 30, 20, 914, DateTimeKind.Utc).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 24, 10, 43, 25, 83, DateTimeKind.Utc).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 23, 12, 13, 31, 975, DateTimeKind.Utc).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 6, 19, 2, 15, 337, DateTimeKind.Utc).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 4, 23, 5, 2, 701, DateTimeKind.Utc).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedAt",
                value: new DateTime(2021, 6, 3, 18, 46, 29, 264, DateTimeKind.Utc).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 48L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 11, 10, 13, 26, 701, DateTimeKind.Utc).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 51, 9, 558, DateTimeKind.Utc).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 4, 7, 54, 49, 36, DateTimeKind.Utc).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 7, 11, 36, 1, 132, DateTimeKind.Utc).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 23, 11, 58, 57, 661, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 11, 22, 23, 59, 987, DateTimeKind.Utc).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 16, 18, 15, 54, 613, DateTimeKind.Utc).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 4, 3, 29, 1, 370, DateTimeKind.Utc).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 56L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 22, 11, 31, 425, DateTimeKind.Utc).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 6, 47, 5, 374, DateTimeKind.Utc).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 22, 4, 26, 14, 726, DateTimeKind.Utc).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 3, 2, 50, 36, 690, DateTimeKind.Utc).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 12, 15, 12, 38, 561, DateTimeKind.Utc).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 22, 6, 56, 51, 843, DateTimeKind.Utc).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 7, 8, 10, 6, 854, DateTimeKind.Utc).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 31, 16, 43, 43, 540, DateTimeKind.Utc).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 64L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 16, 15, 38, 23, 17, DateTimeKind.Utc).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 29, 16, 37, 49, 408, DateTimeKind.Utc).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 21, 7, 22, 745, DateTimeKind.Utc).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 14, 21, 37, 92, DateTimeKind.Utc).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 21, 20, 32, 43, 599, DateTimeKind.Utc).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 2, 7, 11, 184, DateTimeKind.Utc).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 26, 20, 3, 8, 454, DateTimeKind.Utc).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 5, 4, 24, 48, 779, DateTimeKind.Utc).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 72L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 15, 5, 29, 8, 27, DateTimeKind.Utc).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 24, 8, 34, 6, 417, DateTimeKind.Utc).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 4, 18, 45, 19, 96, DateTimeKind.Utc).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 9, 10, 1, 22, 531, DateTimeKind.Utc).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 27, 20, 44, 10, 271, DateTimeKind.Utc).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 25, 18, 26, 54, 424, DateTimeKind.Utc).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 24, 14, 58, 35, 10, DateTimeKind.Utc).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 17, 22, 43, 7, 848, DateTimeKind.Utc).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 80L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 4, 7, 49, 18, 797, DateTimeKind.Utc).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 22, 6, 20, 21, 843, DateTimeKind.Utc).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 5, 21, 28, 32, 951, DateTimeKind.Utc).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 4, 23, 26, 46, 883, DateTimeKind.Utc).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedAt",
                value: new DateTime(2020, 2, 1, 14, 44, 59, 44, DateTimeKind.Utc).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 7, 6, 26, 16, 678, DateTimeKind.Utc).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 6, 3, 19, 715, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 11, 10, 46, 5, 327, DateTimeKind.Utc).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 88L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 24, 6, 29, 33, 622, DateTimeKind.Utc).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 21, 4, 6, 59, 274, DateTimeKind.Utc).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 16, 10, 57, 712, DateTimeKind.Utc).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 17, 2, 2, 14, 794, DateTimeKind.Utc).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 6, 11, 48, 56, 554, DateTimeKind.Utc).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 8, 17, 24, 41, 272, DateTimeKind.Utc).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 22, 10, 32, 27, 405, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 26, 3, 46, 7, 905, DateTimeKind.Utc).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 96L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 4, 17, 25, 48, 830, DateTimeKind.Utc).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 31, 22, 32, 57, 655, DateTimeKind.Utc).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 10, 11, 5, 51, 68, DateTimeKind.Utc).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 14, 7, 24, 29, 735, DateTimeKind.Utc).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 19, 22, 38, 30, 263, DateTimeKind.Utc).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 3, 0, 43, 53, 183, DateTimeKind.Utc).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 3, 5, 14, 39, 431, DateTimeKind.Utc).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 29, 17, 5, 39, 850, DateTimeKind.Utc).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 104L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 3, 8, 35, 12, 209, DateTimeKind.Utc).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 18, 22, 19, 38, 52, DateTimeKind.Utc).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedAt",
                value: new DateTime(2021, 12, 9, 13, 41, 12, 364, DateTimeKind.Utc).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 1, 0, 47, 11, 546, DateTimeKind.Utc).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 26, 13, 59, 48, 181, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 26, 11, 43, 42, 14, DateTimeKind.Utc).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 25, 0, 16, 40, 59, DateTimeKind.Utc).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 30, 12, 2, 1, 391, DateTimeKind.Utc).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 112L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 10, 2, 32, 605, DateTimeKind.Utc).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 18, 19, 41, 55, 939, DateTimeKind.Utc).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 30, 16, 27, 33, 610, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 3, 5, 13, 56, 541, DateTimeKind.Utc).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 4, 8, 46, 14, 869, DateTimeKind.Utc).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedAt",
                value: new DateTime(2021, 12, 30, 14, 44, 50, 651, DateTimeKind.Utc).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedAt",
                value: new DateTime(2022, 1, 24, 8, 1, 41, 428, DateTimeKind.Utc).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 13, 34, 33, 539, DateTimeKind.Utc).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 120L,
                column: "CreatedAt",
                value: new DateTime(2022, 1, 6, 10, 9, 52, 909, DateTimeKind.Utc).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 13, 22, 57, 20, 301, DateTimeKind.Utc).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 6, 16, 3, 37, 200, DateTimeKind.Utc).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 1, 1, 14, 483, DateTimeKind.Utc).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 29, 23, 18, 43, 912, DateTimeKind.Utc).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 3, 9, 51, 9, 977, DateTimeKind.Utc).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 16, 15, 4, 16, 585, DateTimeKind.Utc).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 6, 2, 8, 25, 831, DateTimeKind.Utc).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 128L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 13, 21, 7, 1, 424, DateTimeKind.Utc).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 18, 26, 36, 962, DateTimeKind.Utc).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 31, 3, 34, 14, 503, DateTimeKind.Utc).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 6, 42, 49, 964, DateTimeKind.Utc).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 30, 2, 42, 7, 678, DateTimeKind.Utc).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 21, 2, 49, 53, 383, DateTimeKind.Utc).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 6, 32, 9, 275, DateTimeKind.Utc).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 24, 12, 37, 53, 646, DateTimeKind.Utc).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 136L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 7, 19, 32, 431, DateTimeKind.Utc).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 8, 13, 32, 714, DateTimeKind.Utc).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 5, 14, 13, 269, DateTimeKind.Utc).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 20, 6, 56, 12, 682, DateTimeKind.Utc).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 1, 22, 2, 1, 415, DateTimeKind.Utc).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 2, 13, 22, 58, 60, DateTimeKind.Utc).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 19, 6, 22, 45, 360, DateTimeKind.Utc).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 4, 2, 47, 8, 558, DateTimeKind.Utc).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 144L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 7, 5, 31, 33, 620, DateTimeKind.Utc).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 31, 20, 6, 40, 763, DateTimeKind.Utc).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedAt",
                value: new DateTime(2021, 12, 11, 20, 6, 16, 374, DateTimeKind.Utc).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 3, 2, 41, 12, 826, DateTimeKind.Utc).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 31, 4, 17, 3, 949, DateTimeKind.Utc).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 22, 13, 24, 16, 10, DateTimeKind.Utc).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 14, 46, 57, 792, DateTimeKind.Utc).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 24, 9, 53, 58, 117, DateTimeKind.Utc).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 152L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 15, 19, 24, 8, 102, DateTimeKind.Utc).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 14, 18, 50, 15, 468, DateTimeKind.Utc).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 7, 7, 43, 58, 375, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 28, 10, 7, 32, 260, DateTimeKind.Utc).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 12, 20, 15, 39, 80, DateTimeKind.Utc).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 25, 11, 7, 15, 47, DateTimeKind.Utc).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 4, 3, 44, 43, 89, DateTimeKind.Utc).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 1, 1, 14, 828, DateTimeKind.Utc).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 160L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 21, 3, 50, 10, 853, DateTimeKind.Utc).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 3, 14, 53, 7, 304, DateTimeKind.Utc).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 10, 6, 56, 0, 763, DateTimeKind.Utc).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 23, 10, 42, 20, 833, DateTimeKind.Utc).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 5, 21, 28, 33, 371, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 8, 4, 53, 46, 625, DateTimeKind.Utc).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 13, 15, 40, 850, DateTimeKind.Utc).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 3, 22, 21, 42, 761, DateTimeKind.Utc).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 168L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 16, 21, 27, 4, 30, DateTimeKind.Utc).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 26, 12, 54, 11, 440, DateTimeKind.Utc).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 0, 45, 30, 391, DateTimeKind.Utc).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 17, 41, 17, 688, DateTimeKind.Utc).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 3, 7, 30, 26, 533, DateTimeKind.Utc).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 7, 21, 16, 2, 345, DateTimeKind.Utc).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 1, 12, 22, 1, 623, DateTimeKind.Utc).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 7, 13, 18, 13, 771, DateTimeKind.Utc).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 176L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 8, 9, 21, 5, 968, DateTimeKind.Utc).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 1, 10, 24, 27, 422, DateTimeKind.Utc).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 34, 40, 909, DateTimeKind.Utc).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 4, 22, 31, 50, 917, DateTimeKind.Utc).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 29, 9, 9, 42, 309, DateTimeKind.Utc).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 11, 0, 40, 29, 212, DateTimeKind.Utc).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 26, 13, 0, 8, 270, DateTimeKind.Utc).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 10, 5, 49, 19, 167, DateTimeKind.Utc).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 184L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 19, 11, 59, 23, 678, DateTimeKind.Utc).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 28, 12, 17, 12, 487, DateTimeKind.Utc).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 16, 10, 52, 4, 710, DateTimeKind.Utc).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 5, 21, 5, 8, 896, DateTimeKind.Utc).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 5, 18, 7, 7, 169, DateTimeKind.Utc).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 3, 3, 22, 369, DateTimeKind.Utc).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 24, 15, 12, 28, 219, DateTimeKind.Utc).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 12, 12, 3, 24, 879, DateTimeKind.Utc).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 192L,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 11, 10, 55, 21, 263, DateTimeKind.Utc).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 5, 21, 53, 38, 819, DateTimeKind.Utc).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 8, 40, 52, 364, DateTimeKind.Utc).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 1, 12, 31, 36, 979, DateTimeKind.Utc).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 26, 7, 20, 48, 390, DateTimeKind.Utc).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 7, 7, 50, 616, DateTimeKind.Utc).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 7, 14, 0, 3, 588, DateTimeKind.Utc).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 17, 3, 36, 15, 198, DateTimeKind.Utc).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 200L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 15, 9, 32, 542, DateTimeKind.Utc).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 20, 17, 13, 38, 699, DateTimeKind.Utc).AddTicks(8330), new DateTime(2023, 9, 4, 14, 8, 18, 271, DateTimeKind.Utc).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 1, 20, 9, 31, 359, DateTimeKind.Utc).AddTicks(4060), new DateTime(2023, 9, 5, 6, 22, 55, 382, DateTimeKind.Utc).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 17, 22, 56, 14, 965, DateTimeKind.Utc).AddTicks(4155), new DateTime(2023, 9, 6, 19, 29, 37, 260, DateTimeKind.Utc).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 8, 13, 5, 3, 105, DateTimeKind.Utc).AddTicks(1732), new DateTime(2023, 4, 19, 12, 25, 25, 5, DateTimeKind.Utc).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 28, 14, 44, 17, 478, DateTimeKind.Utc).AddTicks(6780), new DateTime(2023, 8, 14, 21, 48, 54, 78, DateTimeKind.Utc).AddTicks(7094) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 36, 41, 684, DateTimeKind.Utc).AddTicks(399), new DateTime(2023, 5, 28, 10, 55, 29, 983, DateTimeKind.Utc).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 19, 16, 46, 441, DateTimeKind.Utc).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 3, 22, 22, 35, 15, DateTimeKind.Utc).AddTicks(3900), new DateTime(2023, 8, 25, 12, 19, 57, 963, DateTimeKind.Utc).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 9, 29, 7, 17, 0, 442, DateTimeKind.Utc).AddTicks(6174), new DateTime(2023, 5, 13, 17, 32, 51, 843, DateTimeKind.Utc).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 20, 23, 41, 4, 514, DateTimeKind.Utc).AddTicks(9088), new DateTime(2023, 8, 3, 7, 52, 11, 274, DateTimeKind.Utc).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 10, 5, 57, 49, 900, DateTimeKind.Utc).AddTicks(1994), new DateTime(2023, 5, 15, 1, 39, 15, 686, DateTimeKind.Utc).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 13, 4, 50, 6, 116, DateTimeKind.Utc).AddTicks(5561), new DateTime(2023, 6, 27, 13, 50, 48, 774, DateTimeKind.Utc).AddTicks(5002) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 20, 37, 31, 301, DateTimeKind.Utc).AddTicks(4038), new DateTime(2023, 9, 3, 11, 56, 27, 927, DateTimeKind.Utc).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 19, 23, 55, 39, 153, DateTimeKind.Utc).AddTicks(4310), new DateTime(2023, 9, 1, 16, 0, 45, 547, DateTimeKind.Utc).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 10, 22, 47, 45, 331, DateTimeKind.Utc).AddTicks(4763), new DateTime(2023, 8, 13, 11, 41, 40, 249, DateTimeKind.Utc).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 5, 11, 51, 44, 164, DateTimeKind.Utc).AddTicks(9378), new DateTime(2023, 9, 5, 15, 53, 2, 559, DateTimeKind.Utc).AddTicks(4724) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 58, 27, 137, DateTimeKind.Utc).AddTicks(1323), new DateTime(2023, 3, 10, 16, 1, 23, 540, DateTimeKind.Utc).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 4, 11, 17, 9, 477, DateTimeKind.Utc).AddTicks(2766), new DateTime(2023, 2, 26, 18, 1, 21, 538, DateTimeKind.Utc).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 22, 15, 29, 57, 863, DateTimeKind.Utc).AddTicks(6246), new DateTime(2023, 9, 3, 11, 21, 0, 676, DateTimeKind.Utc).AddTicks(9577) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 24, 14, 51, 53, 472, DateTimeKind.Utc).AddTicks(4839), new DateTime(2023, 8, 7, 9, 18, 32, 367, DateTimeKind.Utc).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 10, 17, 0, 53, 884, DateTimeKind.Utc).AddTicks(7468), new DateTime(2023, 8, 13, 18, 54, 39, 446, DateTimeKind.Utc).AddTicks(2583) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 6, 15, 6, 35, 324, DateTimeKind.Utc).AddTicks(6547), new DateTime(2023, 9, 7, 13, 38, 34, 87, DateTimeKind.Utc).AddTicks(5154) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 6, 21, 26, 5, 305, DateTimeKind.Utc).AddTicks(6378), new DateTime(2023, 5, 17, 11, 34, 15, 57, DateTimeKind.Utc).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 2, 8, 51, 19, 560, DateTimeKind.Utc).AddTicks(7897), new DateTime(2023, 9, 7, 6, 28, 14, 339, DateTimeKind.Utc).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 26, 2, 54, 38, 110, DateTimeKind.Utc).AddTicks(9824), new DateTime(2023, 5, 10, 17, 27, 6, 703, DateTimeKind.Utc).AddTicks(4157) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 1, 11, 23, 191, DateTimeKind.Utc).AddTicks(6113), new DateTime(2023, 8, 15, 2, 52, 16, 92, DateTimeKind.Utc).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 3, 14, 55, 56, 298, DateTimeKind.Utc).AddTicks(2075), new DateTime(2023, 8, 6, 2, 34, 23, 93, DateTimeKind.Utc).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 50, 44, 40, DateTimeKind.Utc).AddTicks(4819), new DateTime(2023, 7, 6, 4, 28, 10, 705, DateTimeKind.Utc).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 27, 16, 31, 46, 744, DateTimeKind.Utc).AddTicks(9458), new DateTime(2023, 8, 26, 23, 55, 27, 429, DateTimeKind.Utc).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 7, 8, 25, 34, 181, DateTimeKind.Utc).AddTicks(2270), new DateTime(2023, 9, 7, 10, 6, 6, 667, DateTimeKind.Utc).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 30, 0, 43, 1, 555, DateTimeKind.Utc).AddTicks(6260), new DateTime(2023, 8, 31, 20, 24, 19, 650, DateTimeKind.Utc).AddTicks(3891) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 3, 0, 48, 19, 207, DateTimeKind.Utc).AddTicks(3570), new DateTime(2023, 4, 10, 23, 32, 53, 758, DateTimeKind.Utc).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 22, 4, 13, 40, 799, DateTimeKind.Utc).AddTicks(8796), new DateTime(2023, 7, 25, 16, 10, 31, 598, DateTimeKind.Utc).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 2, 10, 6, 47, 335, DateTimeKind.Utc).AddTicks(2754), new DateTime(2023, 8, 25, 22, 10, 6, 355, DateTimeKind.Utc).AddTicks(6267) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 15, 2, 52, 570, DateTimeKind.Utc).AddTicks(9573), new DateTime(2023, 8, 20, 21, 2, 21, 590, DateTimeKind.Utc).AddTicks(1432) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 14, 14, 19, 14, 644, DateTimeKind.Utc).AddTicks(2911), new DateTime(2023, 7, 16, 1, 29, 29, 651, DateTimeKind.Utc).AddTicks(1056) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 27, 18, 2, 4, 145, DateTimeKind.Utc).AddTicks(2022), new DateTime(2023, 5, 4, 9, 54, 7, 668, DateTimeKind.Utc).AddTicks(9381) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 9, 27, 15, 11, 27, 797, DateTimeKind.Utc).AddTicks(1102), new DateTime(2023, 4, 29, 0, 27, 46, 89, DateTimeKind.Utc).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 27, 17, 45, 15, 130, DateTimeKind.Utc).AddTicks(6924), new DateTime(2023, 5, 24, 10, 47, 23, 605, DateTimeKind.Utc).AddTicks(9291) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 17, 7, 34, 0, 451, DateTimeKind.Utc).AddTicks(1048), new DateTime(2023, 4, 22, 5, 34, 20, 943, DateTimeKind.Utc).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 12, 17, 14, 52, 249, DateTimeKind.Utc).AddTicks(7182), new DateTime(2023, 5, 20, 15, 17, 34, 556, DateTimeKind.Utc).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 3, 20, 7, 33, 450, DateTimeKind.Utc).AddTicks(7187), new DateTime(2023, 9, 5, 0, 49, 43, 636, DateTimeKind.Utc).AddTicks(357) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 21, 15, 22, 54, 273, DateTimeKind.Utc).AddTicks(1624), new DateTime(2023, 9, 5, 19, 50, 23, 199, DateTimeKind.Utc).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 6, 23, 49, 1, 843, DateTimeKind.Utc).AddTicks(3252), new DateTime(2023, 7, 31, 14, 14, 46, 860, DateTimeKind.Utc).AddTicks(4016) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 19, 18, 57, 20, 54, DateTimeKind.Utc).AddTicks(2032), new DateTime(2023, 8, 2, 18, 33, 44, 515, DateTimeKind.Utc).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 30, 22, 48, 59, 878, DateTimeKind.Utc).AddTicks(5153), new DateTime(2023, 7, 8, 11, 36, 45, 975, DateTimeKind.Utc).AddTicks(5013) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 1, 9, 29, 18, 385, DateTimeKind.Utc).AddTicks(4061), new DateTime(2023, 7, 3, 11, 41, 3, 166, DateTimeKind.Utc).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 20, 0, 485, DateTimeKind.Utc).AddTicks(3557), new DateTime(2023, 9, 2, 23, 9, 37, 682, DateTimeKind.Utc).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 30, 11, 11, 33, 602, DateTimeKind.Utc).AddTicks(5028), new DateTime(2023, 8, 10, 12, 47, 23, 128, DateTimeKind.Utc).AddTicks(1391) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 16, 0, 44, 19, 104, DateTimeKind.Utc).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 15, 20, 57, 12, 751, DateTimeKind.Utc).AddTicks(8765), new DateTime(2023, 6, 20, 12, 59, 22, 515, DateTimeKind.Utc).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 13, 6, 50, 17, 453, DateTimeKind.Utc).AddTicks(7763), new DateTime(2023, 8, 24, 7, 35, 51, 852, DateTimeKind.Utc).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 21, 20, 39, 4, 388, DateTimeKind.Utc).AddTicks(4661), new DateTime(2023, 5, 29, 2, 40, 44, 949, DateTimeKind.Utc).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 2, 6, 3, 463, DateTimeKind.Utc).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 26, 18, 2, 9, 621, DateTimeKind.Utc).AddTicks(2851), new DateTime(2023, 6, 6, 20, 13, 35, 211, DateTimeKind.Utc).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 12, 10, 48, 27, 483, DateTimeKind.Utc).AddTicks(2347), new DateTime(2023, 8, 29, 13, 55, 19, 574, DateTimeKind.Utc).AddTicks(6561) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 23, 1, 18, 14, 696, DateTimeKind.Utc).AddTicks(866), new DateTime(2023, 6, 25, 18, 54, 41, 522, DateTimeKind.Utc).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 29, 0, 51, 58, 547, DateTimeKind.Utc).AddTicks(7034), new DateTime(2023, 8, 12, 12, 36, 7, 334, DateTimeKind.Utc).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 30, 23, 38, 42, 119, DateTimeKind.Utc).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 6, 23, 51, 36, 891, DateTimeKind.Utc).AddTicks(9115), new DateTime(2023, 9, 7, 2, 17, 40, 972, DateTimeKind.Utc).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 30, 13, 45, 32, 46, DateTimeKind.Utc).AddTicks(8735), new DateTime(2023, 8, 31, 11, 42, 0, 205, DateTimeKind.Utc).AddTicks(7582) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 11, 16, 22, 880, DateTimeKind.Utc).AddTicks(4500), new DateTime(2023, 8, 16, 14, 7, 35, 57, DateTimeKind.Utc).AddTicks(4594) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 1, 14, 9, 20, 674, DateTimeKind.Utc).AddTicks(6242), new DateTime(2023, 9, 6, 19, 50, 49, 135, DateTimeKind.Utc).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 13, 13, 55, 12, 117, DateTimeKind.Utc).AddTicks(7333), new DateTime(2023, 7, 9, 17, 0, 53, 679, DateTimeKind.Utc).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 31, 5, 48, 7, 919, DateTimeKind.Utc).AddTicks(2952), new DateTime(2023, 8, 31, 20, 7, 14, 849, DateTimeKind.Utc).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 2, 23, 25, 49, 908, DateTimeKind.Utc).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 1, 2, 2, 55, 20, 754, DateTimeKind.Utc).AddTicks(2641), new DateTime(2021, 12, 4, 10, 45, 19, 960, DateTimeKind.Utc).AddTicks(7836) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 2, 5, 4, 24, 376, DateTimeKind.Utc).AddTicks(2846), new DateTime(2023, 7, 10, 22, 7, 42, 864, DateTimeKind.Utc).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 38, 47, 677, DateTimeKind.Utc).AddTicks(3998), new DateTime(2023, 9, 6, 19, 0, 36, 895, DateTimeKind.Utc).AddTicks(8275) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 4, 4, 20, 35, 8, DateTimeKind.Utc).AddTicks(6750), new DateTime(2023, 2, 26, 13, 40, 33, 155, DateTimeKind.Utc).AddTicks(7957) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 38, 4, 978, DateTimeKind.Utc).AddTicks(5255), new DateTime(2023, 9, 7, 13, 20, 26, 57, DateTimeKind.Utc).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 13, 13, 0, 40, 955, DateTimeKind.Utc).AddTicks(5922), new DateTime(2023, 2, 1, 16, 19, 55, 606, DateTimeKind.Utc).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 11, 8, 19, 8, 12, 6, DateTimeKind.Utc).AddTicks(8510), new DateTime(2023, 3, 15, 2, 36, 56, 573, DateTimeKind.Utc).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 31, 7, 41, 33, 696, DateTimeKind.Utc).AddTicks(2964), new DateTime(2023, 8, 31, 12, 20, 53, 24, DateTimeKind.Utc).AddTicks(9662) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 27, 20, 26, 55, 41, DateTimeKind.Utc).AddTicks(9101), new DateTime(2023, 4, 13, 18, 47, 45, 128, DateTimeKind.Utc).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 14, 21, 57, 29, 16, DateTimeKind.Utc).AddTicks(5554), new DateTime(2023, 1, 27, 6, 15, 1, 628, DateTimeKind.Utc).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 30, 6, 50, 39, 870, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 11, 15, 19, 45, 284, DateTimeKind.Utc).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 7, 33, 42, DateTimeKind.Utc).AddTicks(2519), new DateTime(2023, 9, 7, 11, 41, 32, 12, DateTimeKind.Utc).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 22, 4, 28, 25, 599, DateTimeKind.Utc).AddTicks(9583), new DateTime(2023, 8, 23, 4, 56, 10, 556, DateTimeKind.Utc).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 27, 13, 27, 43, 755, DateTimeKind.Utc).AddTicks(3796), new DateTime(2023, 7, 19, 20, 32, 16, 381, DateTimeKind.Utc).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 7, 14, 33, 0, 978, DateTimeKind.Utc).AddTicks(5031), new DateTime(2023, 9, 7, 14, 37, 54, 761, DateTimeKind.Utc).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 1, 3, 36, 28, 600, DateTimeKind.Utc).AddTicks(976), new DateTime(2023, 6, 10, 15, 8, 15, 722, DateTimeKind.Utc).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 21, 23, 20, 339, DateTimeKind.Utc).AddTicks(6241), new DateTime(2023, 3, 11, 5, 43, 57, 742, DateTimeKind.Utc).AddTicks(8724) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 4, 5, 5, 19, 224, DateTimeKind.Utc).AddTicks(3836), new DateTime(2023, 9, 7, 7, 55, 24, 242, DateTimeKind.Utc).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 23, 49, 54, 101, DateTimeKind.Utc).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 21, 4, 24, 27, 647, DateTimeKind.Utc).AddTicks(8743), new DateTime(2023, 8, 4, 6, 47, 21, 502, DateTimeKind.Utc).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 5, 10, 2, 29, 39, 265, DateTimeKind.Utc).AddTicks(8321), new DateTime(2022, 3, 25, 12, 44, 21, 692, DateTimeKind.Utc).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 3, 5, 4, 33, 57, 696, DateTimeKind.Utc).AddTicks(2121), new DateTime(2023, 7, 22, 0, 52, 42, 102, DateTimeKind.Utc).AddTicks(7563) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 18, 10, 1, 51, 107, DateTimeKind.Utc).AddTicks(3595), new DateTime(2023, 9, 5, 7, 58, 59, 456, DateTimeKind.Utc).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 11, 11, 51, 43, 515, DateTimeKind.Utc).AddTicks(2148), new DateTime(2023, 7, 28, 20, 1, 12, 94, DateTimeKind.Utc).AddTicks(9673) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 5, 13, 30, 17, 150, DateTimeKind.Utc).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 21, 5, 41, 57, 708, DateTimeKind.Utc).AddTicks(9105), new DateTime(2023, 8, 25, 19, 5, 44, 552, DateTimeKind.Utc).AddTicks(102) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 3, 24, 10, 22, 16, 922, DateTimeKind.Utc).AddTicks(5225), new DateTime(2023, 5, 24, 18, 35, 20, 167, DateTimeKind.Utc).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 31, 15, 0, 36, 167, DateTimeKind.Utc).AddTicks(5379), new DateTime(2023, 9, 3, 13, 48, 33, 659, DateTimeKind.Utc).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 26, 18, 56, 20, 579, DateTimeKind.Utc).AddTicks(4728), new DateTime(2023, 9, 3, 21, 17, 37, 611, DateTimeKind.Utc).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 11, 3, 44, 32, 811, DateTimeKind.Utc).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 13, 16, 12, 34, 770, DateTimeKind.Utc).AddTicks(3790), new DateTime(2023, 8, 14, 2, 38, 42, 784, DateTimeKind.Utc).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 16, 20, 57, 55, 785, DateTimeKind.Utc).AddTicks(6846), new DateTime(2023, 6, 4, 1, 25, 39, 795, DateTimeKind.Utc).AddTicks(9316) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 31, 8, 57, 49, 230, DateTimeKind.Utc).AddTicks(2380), new DateTime(2023, 9, 4, 11, 21, 11, 712, DateTimeKind.Utc).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 7, 12, 2, 47, 54, 546, DateTimeKind.Utc).AddTicks(4065), new DateTime(2023, 2, 23, 21, 10, 14, 254, DateTimeKind.Utc).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 14, 38, 14, 898, DateTimeKind.Utc).AddTicks(4297), new DateTime(2023, 7, 27, 22, 51, 21, 851, DateTimeKind.Utc).AddTicks(771) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 24, 5, 3, 36, 993, DateTimeKind.Utc).AddTicks(9115), new DateTime(2023, 9, 5, 13, 41, 14, 592, DateTimeKind.Utc).AddTicks(5057) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 19, 8, 48, 30, 209, DateTimeKind.Utc).AddTicks(7048), new DateTime(2023, 8, 29, 15, 38, 24, 540, DateTimeKind.Utc).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 8, 8, 0, 19, 38, 984, DateTimeKind.Utc).AddTicks(5489), new DateTime(2023, 9, 7, 4, 2, 23, 819, DateTimeKind.Utc).AddTicks(7032) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 5, 22, 8, 29, 14, 993, DateTimeKind.Utc).AddTicks(7576), new DateTime(2021, 12, 13, 17, 6, 59, 61, DateTimeKind.Utc).AddTicks(3948) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 18, 19, 58, 35, 489, DateTimeKind.Utc).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 3, 4, 46, 34, 411, DateTimeKind.Utc).AddTicks(1789), new DateTime(2023, 9, 6, 1, 23, 48, 400, DateTimeKind.Utc).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 3, 0, 4, 986, DateTimeKind.Utc).AddTicks(9562), new DateTime(2023, 8, 13, 2, 19, 52, 233, DateTimeKind.Utc).AddTicks(634) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 22, 10, 50, 34, 62, DateTimeKind.Utc).AddTicks(1477), new DateTime(2023, 7, 21, 18, 28, 40, 773, DateTimeKind.Utc).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 12, 8, 15, 33, 446, DateTimeKind.Utc).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 5, 10, 42, 17, 604, DateTimeKind.Utc).AddTicks(3471), new DateTime(2023, 4, 20, 20, 9, 48, 658, DateTimeKind.Utc).AddTicks(4476) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 3, 2, 31, 55, 406, DateTimeKind.Utc).AddTicks(3079), new DateTime(2023, 8, 24, 6, 3, 52, 409, DateTimeKind.Utc).AddTicks(4798) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 13, 23, 4, 24, 472, DateTimeKind.Utc).AddTicks(5802), new DateTime(2023, 8, 22, 2, 53, 49, 502, DateTimeKind.Utc).AddTicks(4578) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 1, 19, 15, 39, 446, DateTimeKind.Utc).AddTicks(7469), new DateTime(2023, 9, 5, 2, 55, 49, 242, DateTimeKind.Utc).AddTicks(9847) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 18, 0, 29, 35, 429, DateTimeKind.Utc).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 4, 14, 47, 40, 952, DateTimeKind.Utc).AddTicks(5152), new DateTime(2023, 9, 5, 9, 8, 3, 673, DateTimeKind.Utc).AddTicks(9299) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 30, 20, 38, 37, 901, DateTimeKind.Utc).AddTicks(1256), new DateTime(2023, 5, 16, 23, 25, 55, 726, DateTimeKind.Utc).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 11, 0, 35, 13, 784, DateTimeKind.Utc).AddTicks(7071), new DateTime(2023, 9, 1, 9, 47, 10, 540, DateTimeKind.Utc).AddTicks(7967) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 18, 18, 6, 21, 596, DateTimeKind.Utc).AddTicks(2194), new DateTime(2023, 8, 23, 21, 45, 15, 363, DateTimeKind.Utc).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 11, 6, 31, 8, 772, DateTimeKind.Utc).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 17, 18, 40, 7, 357, DateTimeKind.Utc).AddTicks(5715), new DateTime(2023, 8, 22, 4, 20, 5, 112, DateTimeKind.Utc).AddTicks(1199) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 16, 4, 4, 984, DateTimeKind.Utc).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 28, 7, 25, 16, 859, DateTimeKind.Utc).AddTicks(1083), new DateTime(2023, 8, 28, 11, 25, 20, 359, DateTimeKind.Utc).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 2, 11, 0, 42, 14, 48, DateTimeKind.Utc).AddTicks(9730), new DateTime(2022, 12, 6, 8, 55, 51, 628, DateTimeKind.Utc).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 9, 21, 30, 35, 670, DateTimeKind.Utc).AddTicks(4660), new DateTime(2023, 6, 6, 12, 9, 14, 91, DateTimeKind.Utc).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 1, 21, 58, 51, 662, DateTimeKind.Utc).AddTicks(7852), new DateTime(2023, 9, 6, 23, 5, 18, 156, DateTimeKind.Utc).AddTicks(4689) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 20, 8, 29, 44, 92, DateTimeKind.Utc).AddTicks(783), new DateTime(2023, 7, 12, 12, 22, 57, 68, DateTimeKind.Utc).AddTicks(2062) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 4, 18, 20, 47, 623, DateTimeKind.Utc).AddTicks(1363), new DateTime(2023, 3, 10, 14, 29, 10, 923, DateTimeKind.Utc).AddTicks(147) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 16, 10, 57, 749, DateTimeKind.Utc).AddTicks(8489), new DateTime(2023, 5, 25, 22, 38, 30, 427, DateTimeKind.Utc).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 12, 12, 14, 31, 470, DateTimeKind.Utc).AddTicks(1894), new DateTime(2023, 6, 19, 12, 30, 3, 513, DateTimeKind.Utc).AddTicks(9721) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 31, 6, 35, 12, 285, DateTimeKind.Utc).AddTicks(7111), new DateTime(2023, 9, 5, 2, 56, 46, 621, DateTimeKind.Utc).AddTicks(556) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 16, 10, 17, 7, 549, DateTimeKind.Utc).AddTicks(8845), new DateTime(2023, 8, 3, 1, 12, 21, 305, DateTimeKind.Utc).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 28, 13, 50, 27, 726, DateTimeKind.Utc).AddTicks(2708), new DateTime(2023, 8, 31, 15, 49, 6, 560, DateTimeKind.Utc).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 15, 0, 26, 26, 391, DateTimeKind.Utc).AddTicks(4234), new DateTime(2023, 6, 3, 10, 19, 49, 169, DateTimeKind.Utc).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 7, 10, 48, 48, 606, DateTimeKind.Utc).AddTicks(3933), new DateTime(2023, 9, 7, 11, 17, 57, 783, DateTimeKind.Utc).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 24, 0, 52, 55, 9, DateTimeKind.Utc).AddTicks(6933), new DateTime(2023, 8, 29, 10, 1, 29, 170, DateTimeKind.Utc).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 6, 20, 19, 48, 638, DateTimeKind.Utc).AddTicks(7977), new DateTime(2023, 9, 7, 1, 47, 43, 777, DateTimeKind.Utc).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 27, 11, 16, 40, 661, DateTimeKind.Utc).AddTicks(428), new DateTime(2023, 8, 24, 14, 21, 58, 338, DateTimeKind.Utc).AddTicks(7130) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 27, 15, 50, 9, 68, DateTimeKind.Utc).AddTicks(574), new DateTime(2023, 7, 13, 0, 52, 2, 874, DateTimeKind.Utc).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 4, 4, 35, 42, 3, DateTimeKind.Utc).AddTicks(8654), new DateTime(2023, 5, 20, 11, 37, 22, 386, DateTimeKind.Utc).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 14, 31, 52, 799, DateTimeKind.Utc).AddTicks(997), new DateTime(2023, 8, 11, 13, 51, 16, 809, DateTimeKind.Utc).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 12, 22, 4, 69, DateTimeKind.Utc).AddTicks(448), new DateTime(2023, 8, 16, 0, 16, 34, 21, DateTimeKind.Utc).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 11, 8, 13, 30, 23, 992, DateTimeKind.Utc).AddTicks(1050), new DateTime(2023, 1, 22, 12, 26, 54, 605, DateTimeKind.Utc).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 17, 0, 33, 26, 181, DateTimeKind.Utc).AddTicks(5898), new DateTime(2023, 8, 4, 0, 9, 27, 648, DateTimeKind.Utc).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 24, 11, 23, 3, 906, DateTimeKind.Utc).AddTicks(7718), new DateTime(2023, 9, 4, 6, 31, 49, 790, DateTimeKind.Utc).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 21, 4, 31, 53, 72, DateTimeKind.Utc).AddTicks(7870), new DateTime(2023, 8, 6, 3, 17, 42, 983, DateTimeKind.Utc).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 25, 6, 8, 16, 967, DateTimeKind.Utc).AddTicks(4999), new DateTime(2023, 8, 29, 21, 36, 21, 768, DateTimeKind.Utc).AddTicks(4007) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 2, 3, 19, 13, 2, DateTimeKind.Utc).AddTicks(2243), new DateTime(2023, 4, 11, 17, 44, 21, 182, DateTimeKind.Utc).AddTicks(2631) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 9, 42, 22, 788, DateTimeKind.Utc).AddTicks(377), new DateTime(2023, 8, 30, 15, 48, 16, 456, DateTimeKind.Utc).AddTicks(534) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 4, 4, 24, 22, 953, DateTimeKind.Utc).AddTicks(6033), new DateTime(2023, 3, 21, 11, 48, 14, 811, DateTimeKind.Utc).AddTicks(1041) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 10, 26, 23, 23, 3, 314, DateTimeKind.Utc).AddTicks(300), new DateTime(2022, 11, 26, 7, 22, 47, 775, DateTimeKind.Utc).AddTicks(6595) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 1, 3, 9, 47, 582, DateTimeKind.Utc).AddTicks(603), new DateTime(2023, 9, 2, 5, 37, 38, 841, DateTimeKind.Utc).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 8, 3, 3, 13, 271, DateTimeKind.Utc).AddTicks(6965), new DateTime(2023, 3, 8, 16, 10, 38, 947, DateTimeKind.Utc).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 8, 30, 18, 59, 46, 760, DateTimeKind.Utc).AddTicks(8355), new DateTime(2022, 10, 29, 13, 53, 40, 400, DateTimeKind.Utc).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 2, 22, 22, 57, 548, DateTimeKind.Utc).AddTicks(2363), new DateTime(2023, 9, 4, 18, 7, 3, 440, DateTimeKind.Utc).AddTicks(1795) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 7, 9, 11, 42, 33, 590, DateTimeKind.Utc).AddTicks(8225), new DateTime(2023, 1, 17, 19, 47, 3, 291, DateTimeKind.Utc).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 23, 12, 22, 480, DateTimeKind.Utc).AddTicks(4980), new DateTime(2023, 7, 19, 8, 14, 45, 145, DateTimeKind.Utc).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 11, 16, 22, 27, 332, DateTimeKind.Utc).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 6, 9, 31, 30, 451, DateTimeKind.Utc).AddTicks(1052), new DateTime(2023, 4, 3, 16, 44, 23, 364, DateTimeKind.Utc).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 6, 0, 40, 53, 509, DateTimeKind.Utc).AddTicks(1133), new DateTime(2023, 6, 29, 18, 14, 10, 242, DateTimeKind.Utc).AddTicks(3970) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 162L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 29, 12, 14, 22, 300, DateTimeKind.Utc).AddTicks(2168), new DateTime(2023, 9, 4, 17, 30, 37, 384, DateTimeKind.Utc).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 163L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 6, 10, 22, 22, 835, DateTimeKind.Utc).AddTicks(7531), new DateTime(2023, 9, 7, 1, 45, 8, 814, DateTimeKind.Utc).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 164L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 27, 21, 0, 0, 934, DateTimeKind.Utc).AddTicks(1098), new DateTime(2023, 9, 4, 4, 42, 28, 898, DateTimeKind.Utc).AddTicks(7392) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 165L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 27, 13, 10, 36, 423, DateTimeKind.Utc).AddTicks(4565), new DateTime(2023, 8, 29, 10, 12, 8, 81, DateTimeKind.Utc).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 1, 45, 2, 929, DateTimeKind.Utc).AddTicks(2775), new DateTime(2023, 8, 20, 14, 7, 17, 538, DateTimeKind.Utc).AddTicks(4425) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 3, 9, 49, 52, 690, DateTimeKind.Utc).AddTicks(681), new DateTime(2023, 9, 4, 21, 14, 31, 823, DateTimeKind.Utc).AddTicks(5214) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 12, 2, 35, 12, 505, DateTimeKind.Utc).AddTicks(8309), new DateTime(2023, 7, 23, 1, 36, 10, 754, DateTimeKind.Utc).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 14, 13, 58, 41, 972, DateTimeKind.Utc).AddTicks(4363), new DateTime(2023, 9, 3, 15, 5, 44, 463, DateTimeKind.Utc).AddTicks(599) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 14, 21, 29, 16, 967, DateTimeKind.Utc).AddTicks(2807), new DateTime(2023, 7, 30, 6, 12, 9, 341, DateTimeKind.Utc).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 1, 13, 6, 41, 469, DateTimeKind.Utc).AddTicks(6110), new DateTime(2023, 8, 2, 17, 53, 54, 972, DateTimeKind.Utc).AddTicks(6444) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 18, 8, 16, 3, 129, DateTimeKind.Utc).AddTicks(6156), new DateTime(2023, 8, 23, 7, 58, 21, 580, DateTimeKind.Utc).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 28, 22, 48, 58, 475, DateTimeKind.Utc).AddTicks(8697), new DateTime(2023, 7, 11, 8, 50, 8, 237, DateTimeKind.Utc).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 29, 3, 50, 47, 417, DateTimeKind.Utc).AddTicks(4806), new DateTime(2023, 8, 28, 12, 18, 32, 425, DateTimeKind.Utc).AddTicks(2359) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 7, 25, 5, 4, 8, 879, DateTimeKind.Utc).AddTicks(1185), new DateTime(2023, 5, 17, 10, 3, 50, 413, DateTimeKind.Utc).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 24, 12, 6, 38, 512, DateTimeKind.Utc).AddTicks(3801), new DateTime(2023, 8, 17, 15, 50, 3, 475, DateTimeKind.Utc).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 9, 7, 52, 8, 235, DateTimeKind.Utc).AddTicks(261), new DateTime(2023, 4, 11, 21, 42, 48, 870, DateTimeKind.Utc).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 27, 6, 24, 51, 867, DateTimeKind.Utc).AddTicks(4771), new DateTime(2023, 4, 5, 6, 48, 37, 215, DateTimeKind.Utc).AddTicks(5396) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 14, 14, 1, 19, 887, DateTimeKind.Utc).AddTicks(212), new DateTime(2023, 5, 14, 18, 38, 17, 759, DateTimeKind.Utc).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 9, 19, 7, 49, 877, DateTimeKind.Utc).AddTicks(5023), new DateTime(2023, 6, 15, 22, 35, 4, 735, DateTimeKind.Utc).AddTicks(4759) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 20, 48, 8, 293, DateTimeKind.Utc).AddTicks(3240), new DateTime(2023, 3, 22, 19, 55, 32, 606, DateTimeKind.Utc).AddTicks(3712) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 7, 19, 13, 949, DateTimeKind.Utc).AddTicks(3667), new DateTime(2023, 7, 31, 2, 58, 37, 952, DateTimeKind.Utc).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 24, 15, 54, 34, 157, DateTimeKind.Utc).AddTicks(8083), new DateTime(2023, 8, 3, 4, 41, 8, 24, DateTimeKind.Utc).AddTicks(6596) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 30, 19, 8, 33, 395, DateTimeKind.Utc).AddTicks(9850), new DateTime(2023, 9, 2, 7, 24, 12, 428, DateTimeKind.Utc).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 12, 13, 10, 18, 744, DateTimeKind.Utc).AddTicks(76), new DateTime(2023, 5, 29, 8, 30, 14, 296, DateTimeKind.Utc).AddTicks(5044) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 22, 39, 16, 691, DateTimeKind.Utc).AddTicks(4564), new DateTime(2023, 6, 14, 20, 56, 45, 495, DateTimeKind.Utc).AddTicks(962) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 10, 5, 6, 20, 29, 320, DateTimeKind.Utc).AddTicks(3687), new DateTime(2022, 11, 11, 22, 37, 38, 492, DateTimeKind.Utc).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 2, 2, 37, 30, 92, DateTimeKind.Utc).AddTicks(8549), new DateTime(2023, 7, 25, 17, 58, 59, 128, DateTimeKind.Utc).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 30, 5, 30, 42, 538, DateTimeKind.Utc).AddTicks(9110), new DateTime(2023, 8, 31, 5, 10, 56, 51, DateTimeKind.Utc).AddTicks(4749) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 11, 20, 12, 47, 45, 134, DateTimeKind.Utc).AddTicks(5664), new DateTime(2023, 5, 7, 9, 25, 7, 463, DateTimeKind.Utc).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 7, 30, 15, 23, 1, 994, DateTimeKind.Utc).AddTicks(9978), new DateTime(2023, 3, 14, 10, 19, 55, 938, DateTimeKind.Utc).AddTicks(8326) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 13, 6, 10, 30, 403, DateTimeKind.Utc).AddTicks(7054), new DateTime(2023, 7, 17, 16, 8, 27, 890, DateTimeKind.Utc).AddTicks(5422) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 23, 10, 46, 29, 978, DateTimeKind.Utc).AddTicks(8647), new DateTime(2023, 8, 28, 17, 37, 20, 953, DateTimeKind.Utc).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 0, 54, 30, 869, DateTimeKind.Utc).AddTicks(5486), new DateTime(2023, 5, 27, 19, 5, 15, 77, DateTimeKind.Utc).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 5, 2, 18, 17, 760, DateTimeKind.Utc).AddTicks(788), new DateTime(2023, 9, 6, 2, 57, 56, 285, DateTimeKind.Utc).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 11, 6, 20, 29, 974, DateTimeKind.Utc).AddTicks(6437), new DateTime(2023, 6, 15, 20, 30, 31, 13, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 12, 16, 57, 43, 417, DateTimeKind.Utc).AddTicks(116), new DateTime(2023, 5, 26, 4, 25, 9, 595, DateTimeKind.Utc).AddTicks(1770) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 6, 18, 1, 42, 679, DateTimeKind.Utc).AddTicks(4386), new DateTime(2023, 7, 3, 19, 53, 44, 974, DateTimeKind.Utc).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 5, 6, 30, 28, 281, DateTimeKind.Utc).AddTicks(565), new DateTime(2023, 5, 17, 14, 29, 59, 57, DateTimeKind.Utc).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 10, 20, 41, 39, 458, DateTimeKind.Utc).AddTicks(6727), new DateTime(2023, 8, 29, 17, 22, 41, 405, DateTimeKind.Utc).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "RegisteredAt",
                value: new DateTime(2016, 5, 19, 15, 23, 57, 151, DateTimeKind.Utc).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "RegisteredAt",
                value: new DateTime(2016, 4, 10, 12, 42, 38, 302, DateTimeKind.Utc).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                column: "RegisteredAt",
                value: new DateTime(2017, 11, 9, 14, 12, 10, 355, DateTimeKind.Utc).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                column: "RegisteredAt",
                value: new DateTime(2018, 7, 24, 22, 49, 28, 789, DateTimeKind.Utc).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                column: "RegisteredAt",
                value: new DateTime(2017, 8, 15, 8, 12, 24, 653, DateTimeKind.Utc).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                column: "RegisteredAt",
                value: new DateTime(2022, 3, 3, 22, 39, 0, 285, DateTimeKind.Utc).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                column: "RegisteredAt",
                value: new DateTime(2020, 9, 15, 22, 30, 33, 105, DateTimeKind.Utc).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                column: "RegisteredAt",
                value: new DateTime(2022, 5, 29, 4, 45, 53, 166, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                column: "RegisteredAt",
                value: new DateTime(2021, 12, 4, 10, 17, 20, 349, DateTimeKind.Utc).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                column: "RegisteredAt",
                value: new DateTime(2018, 7, 19, 4, 23, 29, 260, DateTimeKind.Utc).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11L,
                column: "RegisteredAt",
                value: new DateTime(2022, 3, 25, 11, 53, 54, 163, DateTimeKind.Utc).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12L,
                column: "RegisteredAt",
                value: new DateTime(2019, 9, 15, 9, 25, 22, 66, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13L,
                column: "RegisteredAt",
                value: new DateTime(2021, 3, 10, 13, 8, 22, 515, DateTimeKind.Utc).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14L,
                column: "RegisteredAt",
                value: new DateTime(2016, 6, 9, 19, 41, 3, 18, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15L,
                column: "RegisteredAt",
                value: new DateTime(2022, 3, 13, 20, 42, 22, 483, DateTimeKind.Utc).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16L,
                column: "RegisteredAt",
                value: new DateTime(2017, 6, 22, 13, 21, 57, 829, DateTimeKind.Utc).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17L,
                column: "RegisteredAt",
                value: new DateTime(2016, 1, 19, 22, 17, 17, 289, DateTimeKind.Utc).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18L,
                column: "RegisteredAt",
                value: new DateTime(2022, 12, 27, 3, 29, 54, 810, DateTimeKind.Utc).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19L,
                column: "RegisteredAt",
                value: new DateTime(2022, 4, 14, 20, 32, 49, 487, DateTimeKind.Utc).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20L,
                column: "RegisteredAt",
                value: new DateTime(2020, 12, 16, 8, 26, 10, 438, DateTimeKind.Utc).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21L,
                column: "RegisteredAt",
                value: new DateTime(2017, 1, 24, 5, 49, 38, 385, DateTimeKind.Utc).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22L,
                column: "RegisteredAt",
                value: new DateTime(2018, 5, 3, 19, 38, 39, 965, DateTimeKind.Utc).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23L,
                column: "RegisteredAt",
                value: new DateTime(2021, 11, 7, 12, 25, 20, 527, DateTimeKind.Utc).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24L,
                column: "RegisteredAt",
                value: new DateTime(2021, 4, 26, 23, 14, 19, 874, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25L,
                column: "RegisteredAt",
                value: new DateTime(2019, 2, 21, 15, 26, 2, 879, DateTimeKind.Utc).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26L,
                column: "RegisteredAt",
                value: new DateTime(2016, 6, 21, 14, 31, 13, 607, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27L,
                column: "RegisteredAt",
                value: new DateTime(2021, 12, 12, 8, 7, 17, 149, DateTimeKind.Utc).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28L,
                column: "RegisteredAt",
                value: new DateTime(2016, 7, 18, 4, 32, 41, 997, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29L,
                column: "RegisteredAt",
                value: new DateTime(2017, 8, 3, 20, 5, 45, 292, DateTimeKind.Utc).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30L,
                column: "RegisteredAt",
                value: new DateTime(2020, 8, 22, 5, 16, 2, 368, DateTimeKind.Utc).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31L,
                column: "RegisteredAt",
                value: new DateTime(2016, 12, 16, 14, 5, 40, 500, DateTimeKind.Utc).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32L,
                column: "RegisteredAt",
                value: new DateTime(2016, 12, 24, 15, 43, 51, 200, DateTimeKind.Utc).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33L,
                column: "RegisteredAt",
                value: new DateTime(2021, 11, 27, 14, 43, 14, 251, DateTimeKind.Utc).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34L,
                column: "RegisteredAt",
                value: new DateTime(2023, 3, 13, 6, 20, 3, 396, DateTimeKind.Utc).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35L,
                column: "RegisteredAt",
                value: new DateTime(2022, 2, 17, 0, 2, 55, 577, DateTimeKind.Utc).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36L,
                column: "RegisteredAt",
                value: new DateTime(2020, 4, 8, 5, 3, 43, 144, DateTimeKind.Utc).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37L,
                column: "RegisteredAt",
                value: new DateTime(2016, 5, 7, 8, 7, 0, 732, DateTimeKind.Utc).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38L,
                column: "RegisteredAt",
                value: new DateTime(2018, 12, 21, 7, 48, 38, 849, DateTimeKind.Utc).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39L,
                column: "RegisteredAt",
                value: new DateTime(2016, 7, 24, 17, 59, 53, 515, DateTimeKind.Utc).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40L,
                column: "RegisteredAt",
                value: new DateTime(2017, 10, 20, 20, 20, 34, 575, DateTimeKind.Utc).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ChallengeId", "CreatedAt", "CreatedBy", "LanguageId", "Status" },
                values: new object[] { 59L, new DateTime(2023, 8, 25, 6, 2, 51, 240, DateTimeKind.Utc).AddTicks(9348), 12L, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 38L, "Est aut repellendus qui fugit.", new DateTime(2023, 6, 7, 11, 10, 45, 595, DateTimeKind.Utc).AddTicks(5010), 4L, "Iusto aut nesciunt modi et quibusdam.", 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 8L, "Omnis inventore velit.\nMaxime fuga fugiat eos.\nAdipisci id dolores et fugit vero vitae.", new DateTime(2021, 12, 26, 8, 55, 43, 779, DateTimeKind.Utc).AddTicks(7978), 8L, "Consequuntur alias ipsam quo alias et quisquam voluptates.", 1, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 21L, "Nam omnis est magnam rerum eum repudiandae minima tenetur quis. Reprehenderit accusamus dolore est ratione maiores. Et perspiciatis sequi minima pariatur dignissimos eum. Dolorum qui cum voluptatibus quibusdam corporis saepe dolores. Error magni eum dolore minima amet. Temporibus esse magni nihil est officiis ducimus aut dolorem sit.", new DateTime(2023, 6, 14, 12, 1, 40, 833, DateTimeKind.Utc).AddTicks(5007), 16L, "Et vel voluptatum quia quia nesciunt sequi impedit.", 1, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 43L, "Et id nulla nesciunt. Nesciunt minima cupiditate. Dolore corrupti iusto ipsam sapiente. Maxime alias nam.", new DateTime(2023, 8, 25, 13, 49, 33, 506, DateTimeKind.Utc).AddTicks(9225), 24L, "Accusamus magnam quia laudantium id.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 59L, "Corporis illum molestiae hic et officiis accusantium nostrum. Aut et error itaque animi eveniet ut delectus voluptates dolorem. Laudantium itaque sequi officiis sapiente et.", new DateTime(2023, 3, 2, 7, 22, 39, 934, DateTimeKind.Utc).AddTicks(6945), 7L, "Et pariatur sapiente.", 2, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 57L, "Non porro impedit.", new DateTime(2023, 4, 3, 2, 21, 7, 316, DateTimeKind.Utc).AddTicks(9294), 27L, "Blanditiis quidem earum tempore molestias.", 3, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 53L, "Sit molestiae adipisci repellat eum vel dolorum aut ullam distinctio.\nOmnis animi officiis tenetur.", new DateTime(2019, 12, 31, 10, 39, 47, 544, DateTimeKind.Utc).AddTicks(9967), 15L, "Fugit mollitia aut ab eum est quaerat consequatur.", 3, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 27L, "qui", new DateTime(2022, 12, 17, 8, 42, 40, 737, DateTimeKind.Utc).AddTicks(4608), 1L, "Dolore possimus quisquam optio veniam.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 3L, "unde", new DateTime(2023, 7, 11, 13, 22, 49, 378, DateTimeKind.Utc).AddTicks(9366), 34L, "Sit repellendus cupiditate quo quo doloribus.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 16L, "Soluta est libero voluptatum ullam unde libero dolorem voluptatem et.", new DateTime(2023, 6, 21, 0, 42, 34, 291, DateTimeKind.Utc).AddTicks(9796), 9L, "Officiis eos molestias explicabo.", 1, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 51L, "omnis", new DateTime(2023, 9, 7, 10, 2, 25, 482, DateTimeKind.Utc).AddTicks(2893), 35L, "Modi eaque iusto commodi.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 38L, "Voluptatem et veniam iusto rerum.", new DateTime(2023, 4, 28, 0, 41, 49, 217, DateTimeKind.Utc).AddTicks(6134), 14L, "Culpa maiores officiis deleniti cumque similique optio et sed ab.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 43L, "Nihil officia minima quae id occaecati quod.", new DateTime(2023, 8, 31, 17, 46, 13, 24, DateTimeKind.Utc).AddTicks(5254), 7L, "Totam expedita hic vel sint rerum earum facilis.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 51L, "Itaque quidem debitis nisi voluptate. Placeat facere omnis ea quia ea voluptatibus id laborum. Consequatur iure nisi voluptatem temporibus.", new DateTime(2023, 7, 9, 2, 56, 34, 757, DateTimeKind.Utc).AddTicks(307), 19L, "Ipsa sequi voluptatum qui.", 3, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 65L, "Recusandae rerum dolor assumenda maiores placeat magnam debitis.\nFacilis velit et qui totam et iusto consequatur ut.", new DateTime(2022, 9, 4, 16, 59, 44, 673, DateTimeKind.Utc).AddTicks(1606), 35L, "Et expedita dignissimos et neque atque aut.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 28L, "Perspiciatis dolorum architecto placeat. Eum aut repellendus laudantium est cumque velit. Voluptatum fugiat aut. Est voluptatum natus sed qui. Inventore beatae totam et necessitatibus velit. Et pariatur voluptas veniam rerum.", new DateTime(2023, 2, 3, 5, 53, 47, 190, DateTimeKind.Utc).AddTicks(8417), 35L, "Nulla explicabo suscipit molestiae perferendis.", 1, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 7L, "Quis dignissimos ipsam et in dolores perferendis.", new DateTime(2021, 5, 19, 21, 22, 11, 448, DateTimeKind.Utc).AddTicks(177), 37L, "Dolorum praesentium blanditiis quia commodi non quis voluptatem.", 3, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 24L, "Ab at at dolorem qui nobis doloremque.\nQuo aliquam omnis et illo voluptas culpa ea ducimus ea.\nEt eum est est neque qui.\nVoluptatem unde voluptatem non.\nDolor et dolor molestias et officia.", new DateTime(2021, 11, 12, 7, 45, 53, 160, DateTimeKind.Utc).AddTicks(737), 5L, "Et at iusto illum.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 67L, "Vitae eligendi consequatur laboriosam commodi atque.\nDolor eos est repellat enim aliquam ratione.", new DateTime(2023, 8, 28, 22, 53, 59, 474, DateTimeKind.Utc).AddTicks(832), 31L, "Voluptas et quis voluptatem autem voluptas ducimus maiores praesentium odit.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 29L, "Rerum recusandae cum et officia odit aliquid saepe corrupti. Aliquid dolorum iste quia voluptatibus dolores nostrum ab quia dolor. Doloremque odio suscipit animi recusandae quo voluptatem odio.", new DateTime(2022, 9, 28, 6, 7, 11, 952, DateTimeKind.Utc).AddTicks(9242), 11L, "Est recusandae aliquam provident molestiae.", 2, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 58L, "Cumque sint tenetur sed et.", new DateTime(2023, 5, 4, 12, 13, 11, 325, DateTimeKind.Utc).AddTicks(6550), 10L, "Non aspernatur recusandae soluta ratione quibusdam et totam voluptatem.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 25L, "qui", new DateTime(2022, 11, 19, 15, 30, 36, 697, DateTimeKind.Utc).AddTicks(6054), 14L, "Laboriosam totam expedita reprehenderit sed blanditiis.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 38L, "Natus esse sint magnam incidunt velit adipisci voluptatem.", new DateTime(2023, 1, 8, 4, 21, 0, 875, DateTimeKind.Utc).AddTicks(2280), 10L, "Ea consequatur aut.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 24L, "Ut vitae aut molestias. Expedita provident ex beatae nihil numquam nihil adipisci consequatur. Dolor quae sit consequuntur. Esse et veniam saepe nisi eius. Labore aut aut molestiae quaerat iure voluptatem exercitationem ut. Doloremque facere similique molestiae error.", new DateTime(2022, 10, 10, 5, 40, 54, 29, DateTimeKind.Utc).AddTicks(9724), 25L, "Iusto possimus laudantium accusantium possimus mollitia totam blanditiis odio corrupti.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 13L, "Doloribus dolorem et accusamus nostrum aliquam aut repellat tenetur.", new DateTime(2020, 5, 8, 16, 27, 18, 616, DateTimeKind.Utc).AddTicks(65), 37L, "Voluptas tempore reprehenderit nesciunt et dignissimos omnis.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 60L, "Facilis quod expedita adipisci voluptates molestiae qui ut qui rerum. Perferendis iusto ea et quia. Harum nemo aliquam suscipit exercitationem error iure rerum. Et autem culpa nemo delectus voluptates.", new DateTime(2023, 7, 26, 0, 16, 10, 314, DateTimeKind.Utc).AddTicks(7149), 17L, "In iste voluptatum.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 39L, "Sequi blanditiis vero.", new DateTime(2022, 8, 30, 6, 0, 43, 708, DateTimeKind.Utc).AddTicks(8694), 25L, "Vel dolorem occaecati minus natus explicabo repudiandae optio.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 69L, "nobis", new DateTime(2023, 4, 15, 10, 40, 46, 722, DateTimeKind.Utc).AddTicks(8003), 40L, "Ut enim atque amet.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 12L, "Minus id minus rem voluptatum amet.", new DateTime(2023, 2, 3, 3, 0, 11, 436, DateTimeKind.Utc).AddTicks(3325), 6L, "Odio ratione voluptatem.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 37L, "Consequatur eveniet quidem enim quae voluptatum fugit error. Aut veritatis quo nemo fugiat deserunt veritatis ad. Et nihil autem.", new DateTime(2022, 10, 29, 6, 32, 40, 786, DateTimeKind.Utc).AddTicks(3919), 40L, "Commodi perferendis ut.", 1, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 44L, "Quam iste aliquam ex repudiandae atque beatae odit excepturi.", new DateTime(2022, 7, 1, 4, 49, 15, 536, DateTimeKind.Utc).AddTicks(4410), 13L, "At maiores aut aliquid perferendis adipisci odio expedita.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 37L, "Voluptas corrupti voluptas quaerat in minus provident.", new DateTime(2022, 3, 15, 12, 55, 1, 185, DateTimeKind.Utc).AddTicks(704), 8L, "Vel ut repudiandae et.", 1, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 43L, "Repudiandae voluptatum quod sit voluptas nobis. Magni harum expedita non. Voluptatibus tempora explicabo quasi esse aspernatur. Facere perspiciatis inventore asperiores hic. Nostrum dicta rerum omnis voluptatem consectetur.", new DateTime(2023, 9, 4, 23, 14, 35, 51, DateTimeKind.Utc).AddTicks(6686), 29L, "At praesentium ea ut.", 1, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 35L, "Omnis iure rerum magnam perspiciatis necessitatibus et vero deleniti autem. Eaque animi ut consequatur laborum laudantium quos. Inventore cupiditate labore voluptas officia neque ducimus aliquam eos. Dolores est tempore doloremque aspernatur consequuntur autem beatae.", new DateTime(2023, 8, 19, 22, 49, 6, 76, DateTimeKind.Utc).AddTicks(2141), 1L, "Dolorem recusandae necessitatibus dolores ea velit vero laboriosam.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 60L, "et", new DateTime(2021, 4, 3, 10, 24, 54, 734, DateTimeKind.Utc).AddTicks(9574), 8L, "Hic dolore eveniet nostrum voluptatem.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 38L, "Et consequatur et eius.", new DateTime(2022, 7, 29, 22, 5, 54, 976, DateTimeKind.Utc).AddTicks(162), 1L, "Veritatis ex sunt aspernatur quidem voluptas non.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 51L, "Sequi aut aut nulla quod.", new DateTime(2023, 4, 8, 4, 9, 6, 683, DateTimeKind.Utc).AddTicks(2066), 26L, "Cum et autem.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 66L, "Laboriosam saepe temporibus non ipsa ut accusamus voluptas eos.\nRepellendus expedita est perferendis.", new DateTime(2022, 7, 25, 3, 24, 52, 217, DateTimeKind.Utc).AddTicks(5817), 27L, "Quisquam at reprehenderit beatae magnam.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 52L, "Temporibus quae fugiat.\nConsequatur quis commodi ipsum veritatis in officiis.\nAt cum nulla rerum fuga impedit doloremque qui unde deserunt.\nEt aliquid ratione quisquam molestiae.\nCommodi qui velit incidunt nulla.", new DateTime(2022, 2, 1, 9, 14, 12, 304, DateTimeKind.Utc).AddTicks(8206), 4L, "Quam consectetur ipsum et et soluta vel.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 14L, "Sit libero inventore odit facilis nesciunt.", new DateTime(2023, 1, 5, 14, 31, 55, 942, DateTimeKind.Utc).AddTicks(3254), 17L, "In ea animi autem qui dolores.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 50L, "quia", new DateTime(2023, 4, 21, 15, 32, 24, 553, DateTimeKind.Utc).AddTicks(5567), 35L, "Est odio vero optio consequuntur tempore est consequatur nemo.", 3, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 68L, "autem", new DateTime(2023, 2, 15, 9, 3, 4, 979, DateTimeKind.Utc).AddTicks(2991), 33L, "Rem cumque at consequatur tempora et facilis corporis ut iste.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 48L, "Et veniam veniam quia nemo cumque.\nAb nihil sed non qui omnis.\nEt harum dolores.\nOptio quisquam omnis est.", new DateTime(2023, 6, 11, 11, 21, 56, 11, DateTimeKind.Utc).AddTicks(8805), 33L, "Dolores quas ut nam illo consequatur sit amet repudiandae.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 35L, "autem", new DateTime(2023, 9, 3, 7, 50, 55, 868, DateTimeKind.Utc).AddTicks(5552), 4L, "Deleniti eaque doloribus.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 13L, "Ab est pariatur autem pariatur nostrum unde animi. Et illo ea. Iure unde fugit animi quo et dolorem.", new DateTime(2019, 8, 1, 0, 34, 50, 614, DateTimeKind.Utc).AddTicks(4305), 40L, "Quisquam quam aspernatur vel animi nostrum molestias necessitatibus.", 3, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 4L, "Eius dolore repellat sunt velit labore dolores nulla nesciunt libero. Cupiditate doloribus ab. Et ab enim consequatur. Debitis quis officiis quos. Saepe voluptate quia ut culpa ut. Autem in sit accusamus animi maxime molestiae.", new DateTime(2022, 8, 21, 13, 6, 53, 535, DateTimeKind.Utc).AddTicks(4350), 13L, "Qui eos reprehenderit culpa sint impedit.", 3, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 49L, "Atque dolorum odit non quis molestias.\nCorporis fugiat quis nemo culpa voluptatem omnis minus.\nQuisquam nemo corporis corporis rerum dolor sed.\nSapiente error dolore praesentium quos quia asperiores.\nImpedit tenetur voluptatem ipsum nostrum in dolores explicabo quae.\nFacere possimus sit maxime.", new DateTime(2023, 7, 14, 1, 41, 39, 402, DateTimeKind.Utc).AddTicks(9510), 33L, "Recusandae ea dicta numquam.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 22L, "Odio officiis consequatur non natus. Voluptatem vel non quaerat omnis. Ea provident eius. Iste quaerat cum a dicta et ratione. Ipsam libero id iusto nobis fugiat.", new DateTime(2023, 4, 14, 11, 11, 46, 566, DateTimeKind.Utc).AddTicks(2680), 19L, "Consequatur error molestias nihil quas omnis delectus consequatur quaerat labore.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 27L, "Maxime ut cumque.\nDolores unde non earum qui et non saepe natus rerum.", new DateTime(2023, 5, 24, 4, 54, 11, 423, DateTimeKind.Utc).AddTicks(860), 18L, "Fuga neque quidem excepturi ipsa explicabo nesciunt nemo placeat.", 1, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 23L, "Porro est qui magni eum dolor optio.\nQuidem qui cumque hic maxime.\nNesciunt delectus omnis vero corporis eveniet et et in quis.\nEa ut quidem eius animi.\nTempora in consequatur voluptas velit cum dolore dolorum ut vitae.", new DateTime(2023, 8, 28, 17, 21, 54, 39, DateTimeKind.Utc).AddTicks(6286), 10L, "Tenetur ut hic qui dolorum dolorem repudiandae doloribus laboriosam quo.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 15L, "dolorem", new DateTime(2018, 9, 17, 10, 26, 13, 415, DateTimeKind.Utc).AddTicks(8458), 2L, "Non possimus voluptatem natus voluptatibus iure quod veniam et nostrum.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 34L, "Ut eaque vel animi placeat adipisci eaque.", new DateTime(2022, 11, 27, 14, 8, 33, 408, DateTimeKind.Utc).AddTicks(4591), 36L, "Rem autem vel aut sapiente.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 36L, "consectetur", new DateTime(2021, 7, 13, 15, 7, 55, 832, DateTimeKind.Utc).AddTicks(2552), 7L, "Voluptates voluptas fugiat.", 4, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 8L, "Aut quibusdam minus doloremque maxime aliquid. Nobis ut explicabo consequuntur delectus maiores blanditiis sit quo asperiores. Harum ut ullam et ab.", new DateTime(2022, 4, 20, 4, 3, 2, 143, DateTimeKind.Utc).AddTicks(756), 40L, "Laborum veniam hic.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "InitialSolution", "LanguageId" },
                values: new object[] { 10L, "In quis vel iure blanditiis dolorem mollitia quo est quis.", new DateTime(2022, 8, 22, 23, 24, 23, 551, DateTimeKind.Utc).AddTicks(7734), "Totam dolore voluptatem repellendus doloribus et beatae laudantium aut neque.", 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 55L, "Et aut autem maiores sit qui et eveniet harum labore. Est sint iure tenetur numquam dolor. Quia dolore temporibus rem suscipit excepturi dicta quas.", new DateTime(2023, 8, 25, 19, 54, 47, 742, DateTimeKind.Utc).AddTicks(6513), 35L, "Tenetur molestiae distinctio commodi dolores optio iusto pariatur.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 38L, "Unde molestias natus ad quod. Dolor atque quaerat quia quod recusandae quia voluptas assumenda et. Soluta sit at velit repellendus ad accusamus autem facere deserunt. Illum aut modi quia. Quos molestiae dolorem hic consequatur. Voluptatem mollitia eius deserunt possimus repellendus laboriosam a laudantium.", new DateTime(2023, 8, 30, 3, 9, 11, 265, DateTimeKind.Utc).AddTicks(6139), 30L, "Ad dolorem autem minus in ullam quam.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 2L, "Eum sapiente libero vel voluptatibus et deserunt porro ea earum.\nSunt sint accusamus aliquam reiciendis consectetur sint dicta eaque autem.\nAliquam minima atque atque.\nQuis reprehenderit neque mollitia.\nRepudiandae est assumenda harum omnis.\nOmnis dolorem placeat et.", new DateTime(2022, 9, 16, 1, 20, 22, 754, DateTimeKind.Utc).AddTicks(1475), 13L, "Aut omnis incidunt.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 46L, "Adipisci aliquam impedit iure saepe dolores voluptatum corporis voluptas.\nUt expedita dolor qui.\nDolorum molestiae reiciendis.\nSint quis omnis et incidunt distinctio dolor distinctio.\nQuos ut deserunt.", new DateTime(2023, 1, 22, 12, 16, 37, 493, DateTimeKind.Utc).AddTicks(2807), 24L, "Quibusdam quia sunt.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 5L, "Eligendi mollitia aut est.\nRerum amet voluptatum qui porro fugiat dignissimos.", new DateTime(2023, 3, 20, 23, 26, 9, 885, DateTimeKind.Utc).AddTicks(6665), 19L, "Neque voluptatem minima eligendi ducimus repudiandae dolorem tempore delectus consequuntur.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 70L, "Voluptas quidem labore iste.\nIllo maiores sit ipsam sunt repellat et delectus.\nItaque voluptas ducimus iusto id dignissimos.\nHarum vero dolor sed.", new DateTime(2023, 3, 10, 1, 51, 12, 967, DateTimeKind.Utc).AddTicks(8991), 17L, "Error officia optio ut.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 36L, "Pariatur nihil et atque est error ipsa facilis. Voluptatem dolore eum illo voluptatem reiciendis quia. Inventore ex minus illo accusamus mollitia fugiat ratione veritatis.", new DateTime(2022, 4, 7, 13, 42, 50, 172, DateTimeKind.Utc).AddTicks(6313), 38L, "Itaque excepturi praesentium qui alias hic.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 7L, "Corrupti neque ut mollitia aut.\nDeleniti cupiditate modi necessitatibus error corporis.\nVoluptatibus eum libero laboriosam officia dolorem sed.\nEst rerum porro et fugit molestiae sequi quasi velit cupiditate.\nVel cumque vel iusto mollitia unde dolor et.\nTempora porro atque.", new DateTime(2023, 9, 1, 2, 35, 40, 381, DateTimeKind.Utc).AddTicks(7925), 25L, "In itaque deserunt dolorem dolores quis provident.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 35L, "Dolorem voluptas veritatis voluptas qui vel consequatur.", new DateTime(2023, 6, 25, 22, 2, 18, 741, DateTimeKind.Utc).AddTicks(18), 24L, "Aperiam rerum rem eum blanditiis et.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { "In possimus sit temporibus vel nesciunt id autem culpa et.\nEt in nesciunt beatae vel velit.\nOptio omnis et sed aut est esse perferendis animi.\nLabore sed quia accusamus temporibus eum.\nOmnis fugiat reiciendis dolore dolorem pariatur iusto repellendus laborum.", new DateTime(2023, 8, 29, 9, 8, 30, 688, DateTimeKind.Utc).AddTicks(9542), 10L, "Autem voluptate voluptatem.", 1, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 21L, "Et natus sed dolores ipsa.\nIste blanditiis placeat.\nVoluptatem perspiciatis iusto mollitia provident.\nRem sit et unde placeat doloribus consequatur voluptate eum perspiciatis.\nIllo eveniet omnis deserunt sed aut est dignissimos id.", new DateTime(2023, 4, 19, 1, 53, 51, 984, DateTimeKind.Utc).AddTicks(169), 24L, "Asperiores quam illum necessitatibus et veniam.", 3, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 1L, "Sapiente mollitia hic ratione quia.\nConsequatur consectetur quibusdam nemo et et et.\nMaiores eligendi velit iusto eum voluptatem molestiae.\nIpsum officia et quae sed.\nNihil minus sapiente voluptatibus delectus est recusandae neque.\nAut recusandae maiores harum esse nulla doloribus dolore.", new DateTime(2023, 1, 11, 22, 45, 28, 851, DateTimeKind.Utc).AddTicks(8841), 12L, "Enim rerum tempore et.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 25L, "Magni dicta explicabo assumenda.", new DateTime(2023, 6, 15, 20, 6, 17, 96, DateTimeKind.Utc).AddTicks(5060), 12L, "Et qui tempore ex cum molestiae.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 12L, "Laboriosam officia ipsa debitis.", new DateTime(2022, 11, 16, 21, 50, 23, 859, DateTimeKind.Utc).AddTicks(2932), 22L, "Qui illo tempora et nulla sint molestias.", 2, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 38L, "Est repellendus est qui illo ad aperiam. Velit et non rerum sequi nulla. Dolore voluptatem quidem dicta. Distinctio mollitia et consequatur. Maiores enim commodi dicta omnis. Optio earum reiciendis eos et provident.", new DateTime(2023, 8, 24, 10, 50, 6, 878, DateTimeKind.Utc).AddTicks(1602), "Quam quaerat id ad placeat.", 3, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 30L, "Maiores quo totam.\nDelectus tempore vel.\nVoluptas incidunt earum dolor maiores qui.\nVelit aut voluptatem ea eligendi et repellendus sed.\nNulla id laboriosam deserunt cupiditate commodi voluptatibus magnam explicabo consequatur.\nOptio ratione praesentium aut ipsum officia unde magnam.", new DateTime(2020, 3, 19, 11, 0, 43, 8, DateTimeKind.Utc).AddTicks(7323), 24L, "Sit id consequatur eos sunt voluptatem quos aliquam fugit porro.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 56L, "tempora", new DateTime(2019, 8, 22, 8, 9, 50, 33, DateTimeKind.Utc).AddTicks(7397), 17L, "Voluptas perferendis qui sit amet nihil sed harum similique.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 59L, "beatae", new DateTime(2023, 2, 19, 8, 23, 47, 754, DateTimeKind.Utc).AddTicks(7760), 36L, "Vitae quia repudiandae perferendis ut rerum sint amet.", 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 57L, "in", new DateTime(2022, 8, 2, 6, 8, 9, 873, DateTimeKind.Utc).AddTicks(8654), 34L, "Consequatur soluta aliquid qui sint et iure totam veritatis in.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 57L, "nisi", new DateTime(2022, 7, 10, 9, 56, 54, 312, DateTimeKind.Utc).AddTicks(4557), 14L, "Aut velit cupiditate voluptas in quis aut qui.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 8L, "Est ea itaque ut ullam molestiae nobis cumque maxime repellat. Autem quae aut reiciendis nihil est qui ipsa. Quaerat atque necessitatibus et voluptate eum iusto autem laudantium. Impedit fuga beatae illum necessitatibus ut earum autem temporibus repudiandae.", new DateTime(2019, 4, 19, 9, 16, 48, 92, DateTimeKind.Utc).AddTicks(97), 14L, "Aut numquam illo distinctio omnis quia.", 4, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 69L, "Maxime est eligendi quia sint. Earum totam asperiores saepe labore temporibus. Fugit ullam incidunt numquam consequatur.", new DateTime(2023, 7, 4, 18, 4, 14, 571, DateTimeKind.Utc).AddTicks(8096), 6L, "Non fugit beatae.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 6L, "Molestias hic ex debitis molestiae quia nobis qui. At voluptatem sint sunt et natus inventore. Possimus cumque eveniet quasi. Accusantium voluptatem et fugiat.", new DateTime(2023, 7, 12, 5, 52, 50, 117, DateTimeKind.Utc).AddTicks(5369), 12L, "Magni ut nesciunt aliquid.", 3, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 19L, "provident", new DateTime(2022, 10, 16, 17, 1, 27, 146, DateTimeKind.Utc).AddTicks(5342), 29L, "Tempore quia qui voluptas non ut accusamus.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 10L, "Eaque quaerat deserunt deserunt est voluptatum modi quaerat placeat et.", new DateTime(2023, 9, 2, 5, 33, 22, 499, DateTimeKind.Utc).AddTicks(9005), 6L, "Exercitationem sunt deleniti recusandae deserunt velit nihil facilis.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 63L, "Alias quis magnam provident quam.", new DateTime(2022, 4, 11, 22, 14, 37, 93, DateTimeKind.Utc).AddTicks(779), 12L, "Mollitia consequatur sint itaque ut animi voluptate fugit labore quas.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 10L, "Magni autem sit.\nAt deleniti aliquid odit voluptatibus debitis.\nAutem asperiores eum quo quibusdam.\nAut est vitae ducimus.\nUt eaque harum dignissimos nemo architecto.", new DateTime(2023, 5, 23, 1, 8, 3, 5, DateTimeKind.Utc).AddTicks(9414), 12L, "Beatae aperiam et ut delectus aut neque at aliquid rerum.", 3, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 57L, "et", new DateTime(2023, 3, 11, 9, 51, 41, 135, DateTimeKind.Utc).AddTicks(7429), 7L, "In ipsa ut qui.", 1, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 31L, "Voluptatum voluptatibus aut voluptate ipsum minima blanditiis voluptas.\nA est quibusdam voluptatibus tempore saepe.\nRerum consequatur sint harum nisi maxime et ipsa rem.\nEt mollitia accusantium laudantium sed dolore officia impedit similique et.\nPorro et rerum ea aliquam cum est maiores.", new DateTime(2023, 3, 29, 23, 56, 12, 808, DateTimeKind.Utc).AddTicks(8534), 7L, "Ut quam ducimus illo fugit recusandae explicabo.", 1, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 26L, "Omnis voluptas itaque quis est vero illum sit.", new DateTime(2023, 1, 29, 2, 19, 20, 631, DateTimeKind.Utc).AddTicks(4040), 11L, "Veniam id aut.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 55L, "Iusto eligendi esse sint facilis laborum ea quo quis.", new DateTime(2023, 3, 15, 2, 55, 32, 177, DateTimeKind.Utc).AddTicks(7311), 10L, "Eos ipsum sit aperiam ad dicta quasi dolor inventore ullam.", 4, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 8L, "adipisci", new DateTime(2018, 10, 14, 22, 16, 42, 107, DateTimeKind.Utc).AddTicks(9716), 29L, "Distinctio saepe dolorum delectus neque tempore.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 29L, "Repudiandae ut animi quaerat reprehenderit voluptas et. Est voluptate rerum iusto sit veniam dolor magnam et. Illum architecto repudiandae explicabo quia id ipsum. Et et beatae ipsam. Inventore ut quis.", new DateTime(2022, 1, 25, 20, 38, 13, 304, DateTimeKind.Utc).AddTicks(235), 38L, "Assumenda impedit quidem quo et quam quia animi.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 46L, "Iste fuga ipsum fuga inventore.", new DateTime(2022, 7, 8, 11, 19, 20, 842, DateTimeKind.Utc).AddTicks(6866), 33L, "Voluptas molestiae laborum magnam aut.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 40L, "assumenda", new DateTime(2023, 3, 27, 12, 45, 0, 463, DateTimeKind.Utc).AddTicks(126), 23L, "Dicta magnam laboriosam consequatur optio suscipit aliquid eum provident sapiente.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 31L, "quaerat", new DateTime(2023, 8, 2, 13, 58, 44, 478, DateTimeKind.Utc).AddTicks(409), 24L, "Atque et quisquam eveniet quo rerum consequatur et est repellat.", 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 45L, "Nisi occaecati at molestias veritatis alias laudantium suscipit. Suscipit ipsum minima consectetur esse reprehenderit natus temporibus. Aliquid autem ad ut est blanditiis architecto impedit.", new DateTime(2023, 1, 30, 3, 34, 18, 929, DateTimeKind.Utc).AddTicks(7271), 31L, "Et qui incidunt minima.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 37L, "In fuga repellat sunt et alias sunt ratione enim distinctio.", new DateTime(2022, 12, 20, 22, 53, 29, 856, DateTimeKind.Utc).AddTicks(7997), 18L, "Libero sequi quos.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 66L, "eum", new DateTime(2022, 12, 28, 17, 40, 38, 854, DateTimeKind.Utc).AddTicks(6404), 7L, "Quaerat totam beatae voluptates in et ex.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 37L, "Aliquid modi aliquid.", new DateTime(2021, 10, 30, 22, 43, 46, 607, DateTimeKind.Utc).AddTicks(6414), 31L, "Molestiae sapiente animi.", 2, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 22L, "Nobis velit sint natus delectus enim.\nQuod quas et a asperiores cumque fuga necessitatibus error.\nAb et velit aperiam.\nConsequatur qui dicta.", new DateTime(2023, 1, 22, 20, 23, 53, 128, DateTimeKind.Utc).AddTicks(137), 29L, "Odit beatae ipsam.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 39L, "Non atque nulla sed iste ipsam veritatis nihil.", new DateTime(2023, 8, 13, 1, 58, 9, 478, DateTimeKind.Utc).AddTicks(3229), 11L, "Error nobis velit aliquid excepturi ducimus ipsa.", 1, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 44L, "Nam sit nesciunt ducimus qui enim et enim autem sed.", new DateTime(2021, 8, 17, 23, 47, 56, 124, DateTimeKind.Utc).AddTicks(6358), 27L, "Autem error animi quia rem.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 25L, "dolor", new DateTime(2023, 7, 15, 7, 56, 4, 318, DateTimeKind.Utc).AddTicks(558), 17L, "Est voluptas est id debitis.", 3, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 11L, "consequatur", new DateTime(2021, 9, 15, 16, 12, 33, 891, DateTimeKind.Utc).AddTicks(6148), 18L, "Voluptates quia sunt consequuntur omnis eos laudantium est facere.", 3, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 46L, "harum", new DateTime(2023, 7, 21, 11, 23, 17, 678, DateTimeKind.Utc).AddTicks(3112), 32L, "Dicta animi dolorem exercitationem asperiores veniam cumque est.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 5L, "Voluptas ipsa est veniam facere at quo occaecati.\nRepellat quos sint ipsa officiis odio est incidunt dolorum.\nExpedita quis aut.\nLibero quis harum aperiam qui asperiores temporibus id impedit dolores.\nRecusandae facilis commodi aliquid sunt aut eum.\nVitae cum doloribus perspiciatis placeat.", new DateTime(2023, 6, 8, 11, 23, 46, 760, DateTimeKind.Utc).AddTicks(732), 24L, "Atque laudantium autem et dolores sunt consequatur sunt.", 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 30L, "Voluptatem voluptatem dolor dolor odio earum autem. Aut non tempora ad aspernatur. Quia soluta quod. Quis vitae deserunt non ut nesciunt itaque nostrum minima corrupti. Ex aut voluptatibus consequatur maxime.", new DateTime(2019, 6, 3, 7, 7, 21, 129, DateTimeKind.Utc).AddTicks(1995), 31L, "Velit enim expedita nesciunt illo asperiores sed.", 1, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 44L, "Ut provident corrupti non consequatur.", new DateTime(2022, 2, 17, 5, 41, 35, 278, DateTimeKind.Utc).AddTicks(6289), 6L, "Ut beatae cumque itaque quia et non et tenetur.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { "Temporibus rem reiciendis sunt atque vel sint excepturi voluptas quo.", new DateTime(2023, 8, 29, 3, 2, 22, 39, DateTimeKind.Utc).AddTicks(4276), 22L, "Perferendis cupiditate iste et laudantium.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 11L, "Qui et neque qui sapiente veritatis. Vel beatae praesentium vero. Neque et minima nam quae cum esse ullam. Repellendus eum et perferendis assumenda vitae molestiae qui.", new DateTime(2020, 2, 14, 22, 8, 20, 424, DateTimeKind.Utc).AddTicks(943), 29L, "Id qui voluptatem.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 4L, "Qui quasi ea. In tenetur facere et sunt explicabo magni consectetur. Maxime natus veniam ipsam ipsam hic autem sit eius aliquam. Qui sapiente a porro accusantium ad voluptas doloremque.", new DateTime(2022, 10, 3, 20, 41, 10, 600, DateTimeKind.Utc).AddTicks(656), 30L, "Inventore voluptate nisi at qui laboriosam hic omnis iste tempora.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 42L, "distinctio", new DateTime(2023, 3, 27, 18, 20, 36, 868, DateTimeKind.Utc).AddTicks(1966), 20L, "Qui omnis et dicta delectus ipsam.", 2, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 25L, "Aut autem et qui vel. Illum ipsum consectetur dolor recusandae aliquam earum quos neque corrupti. Sit omnis doloremque recusandae repellat. Quae alias recusandae est tempore impedit voluptas in enim. Veritatis aut accusamus omnis. In in molestiae id voluptas in.", new DateTime(2023, 5, 26, 10, 15, 25, 592, DateTimeKind.Utc).AddTicks(5858), 9L, "Doloremque in aut animi illum cumque dolorem iusto asperiores eaque.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 30L, "qui", new DateTime(2018, 2, 20, 10, 2, 52, 388, DateTimeKind.Utc).AddTicks(7484), 25L, "Harum nihil modi repellendus voluptatem aut ut officiis eos debitis.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 34L, "Deleniti perferendis possimus. Officiis dicta commodi quod. Eveniet cum enim. Consequatur quis enim quam et blanditiis et asperiores. Consequatur perferendis quisquam hic magnam sit consequuntur hic unde.", new DateTime(2022, 11, 3, 15, 10, 52, 946, DateTimeKind.Utc).AddTicks(1452), 30L, "Eum exercitationem recusandae repudiandae possimus aut id adipisci sequi nihil.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 55L, "Ipsam et id dolorum sint velit et.\nFacilis quod esse et quo sit et inventore.", new DateTime(2023, 5, 3, 12, 47, 19, 29, DateTimeKind.Utc).AddTicks(6817), 36L, "Quis qui provident quod eos autem qui aliquam.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 28L, "Aut omnis sed necessitatibus est et.\nNon molestiae iure architecto.\nArchitecto atque delectus officiis aut optio natus cupiditate ipsam.\nDeleniti est sit.\nNesciunt ex id unde mollitia et quia quia tempore voluptatibus.\nDoloremque amet ipsam velit nulla.", new DateTime(2023, 1, 2, 11, 31, 15, 464, DateTimeKind.Utc).AddTicks(344), 5L, "Error magni quasi et.", 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 56L, "Impedit nobis impedit pariatur est.", new DateTime(2022, 12, 15, 11, 34, 26, 845, DateTimeKind.Utc).AddTicks(5351), 22L, "Animi quaerat ut modi rerum sit magni non.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 34L, "veritatis", new DateTime(2022, 12, 28, 17, 6, 17, 998, DateTimeKind.Utc).AddTicks(8264), 14L, "Voluptatibus in omnis molestias et fugit rem dolorum sunt.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 48L, "Est natus labore quae mollitia qui sunt. Eos et nobis corrupti porro cumque eius distinctio. Amet quia facilis quis modi. Ut explicabo quam.", new DateTime(2023, 3, 12, 8, 45, 25, 268, DateTimeKind.Utc).AddTicks(5531), 3L, "Sapiente debitis beatae quod nihil.", 1, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 37L, "Dolorum qui expedita autem expedita quaerat expedita esse.", new DateTime(2022, 2, 24, 20, 3, 57, 685, DateTimeKind.Utc).AddTicks(8788), 28L, "Blanditiis consequatur quidem omnis incidunt sunt dolores odio.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 38L, "Inventore aperiam impedit et libero. Quod eligendi rerum voluptatem mollitia id. Est ullam voluptas hic sit quis rerum voluptas repellat est. Magnam vitae voluptatem et ipsam veritatis deserunt omnis dolorem. Animi omnis hic adipisci maiores maiores eligendi dolorem quod. Et dolor sint commodi expedita esse molestiae.", new DateTime(2022, 7, 14, 13, 46, 53, 297, DateTimeKind.Utc).AddTicks(5693), 23L, "Totam ut tenetur dolor autem ut.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 67L, "Natus illum omnis ratione aut sed illum possimus doloremque.", new DateTime(2023, 2, 11, 2, 36, 48, 945, DateTimeKind.Utc).AddTicks(6267), 11L, "Repudiandae vel qui dolorem quia.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 27L, "Ut tempore ut ut et aperiam vel ea. Similique ducimus et ut et consequatur consequatur aliquid sed. Libero at sequi quia harum aut perferendis. Nisi sit ut dolorem rem sit at culpa. Repudiandae rem eaque.", new DateTime(2022, 11, 10, 14, 10, 16, 751, DateTimeKind.Utc).AddTicks(8279), 23L, "Rem similique ut a.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 35L, "At vitae laudantium animi minus atque exercitationem aperiam iure iste. Reiciendis id sed eius ut blanditiis. Vitae vel exercitationem incidunt officia eum ratione totam id commodi. Illum porro voluptas dolorem numquam repellat et rerum ipsam id.", new DateTime(2023, 5, 10, 15, 55, 47, 10, DateTimeKind.Utc).AddTicks(1643), 10L, "Suscipit ad autem laudantium velit unde.", 3, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 48L, "Blanditiis ut maxime recusandae sequi similique quo beatae.\nOccaecati sed quisquam quaerat eos qui cupiditate voluptas hic.\nIn at harum officiis in quia enim architecto ab similique.\nPerspiciatis autem consequatur consequatur eos rem consequatur iste.", new DateTime(2023, 6, 25, 12, 39, 15, 805, DateTimeKind.Utc).AddTicks(1939), 36L, "Excepturi mollitia nesciunt nesciunt error maxime libero possimus quos tempore.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 7L, "Neque quisquam harum sint.\nQui reprehenderit dolorem qui voluptas quos temporibus excepturi magni.\nQuod porro aliquam minima libero porro est voluptas ipsam in.\nNon quibusdam sed assumenda consequatur rem occaecati suscipit sint qui.", new DateTime(2020, 4, 21, 12, 47, 21, 243, DateTimeKind.Utc).AddTicks(9797), 2L, "Ipsa iusto corporis.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 13L, "Vero sint reprehenderit a voluptatem.\nDolorem necessitatibus mollitia harum a fugiat voluptatem.", new DateTime(2023, 9, 2, 11, 44, 2, 195, DateTimeKind.Utc).AddTicks(2339), 7L, "Eum nisi dolor iure iure similique aspernatur corporis.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 7L, "Incidunt quae a ratione nam illum quia eos.\nSimilique qui voluptatem atque consequatur accusamus.\nNesciunt sed non tenetur earum corporis sunt.", new DateTime(2021, 8, 27, 7, 40, 32, 603, DateTimeKind.Utc).AddTicks(9219), 18L, "Aperiam labore officia architecto rerum quam dolores perferendis.", 1, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 66L, "Ea dolores nostrum sunt veritatis quidem dicta. Et architecto repudiandae. Saepe ea voluptate possimus molestiae a earum veritatis qui autem. Voluptas et et eos dolorum qui id a. Veniam sint at blanditiis est minus doloremque vel. Nesciunt quis quis fuga sed est eveniet sed qui voluptatum.", new DateTime(2023, 8, 27, 11, 22, 47, 284, DateTimeKind.Utc).AddTicks(4419), 9L, "Sit quas aliquam non eveniet in voluptates.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 22L, "Hic odit adipisci non natus veritatis labore.\nCorporis cumque ipsa.\nEt quas odio magni consequatur optio.", new DateTime(2023, 5, 20, 8, 46, 28, 957, DateTimeKind.Utc).AddTicks(6940), 26L, "Delectus voluptas repellat dolores laudantium cupiditate praesentium sed veniam.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 68L, "Incidunt reprehenderit ipsum eaque minima voluptatem autem.", new DateTime(2023, 3, 15, 10, 14, 15, 918, DateTimeKind.Utc).AddTicks(884), 21L, "Doloremque rerum provident harum voluptates aliquam.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 5L, "qui", new DateTime(2023, 5, 31, 21, 23, 8, 784, DateTimeKind.Utc).AddTicks(7324), 13L, "Ut aliquam sapiente dicta sit.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 23L, "At voluptatibus quia porro nisi necessitatibus. Quam fugit quos. Similique unde culpa qui possimus minima dolorem facere. Laborum corrupti consequuntur optio modi commodi necessitatibus totam et.", new DateTime(2023, 9, 1, 23, 59, 59, 494, DateTimeKind.Utc).AddTicks(9453), 26L, "Eveniet cum non id sunt ab ea provident modi.", 4, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 4L, "cum", new DateTime(2022, 12, 10, 9, 45, 39, 3, DateTimeKind.Utc).AddTicks(3749), 3L, "Magni voluptatem molestias quisquam placeat consectetur.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 11L, "Excepturi ea quia tempora earum eos aut perferendis. Est dignissimos alias nam est vel. Est voluptatem enim vel error corporis et quaerat.", new DateTime(2019, 8, 2, 15, 0, 50, 66, DateTimeKind.Utc).AddTicks(2320), 5L, "Animi aliquam inventore aspernatur deleniti repellendus commodi at fuga dolores.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 63L, "consectetur", new DateTime(2022, 7, 26, 23, 55, 4, 11, DateTimeKind.Utc).AddTicks(6766), 20L, "Perferendis quod placeat sed quos ipsam ut qui.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 47L, "aut", new DateTime(2021, 6, 10, 21, 8, 7, 65, DateTimeKind.Utc).AddTicks(342), 4L, "Vel dolor omnis.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 9L, "Fugit dolores atque eum.", new DateTime(2020, 8, 29, 21, 56, 26, 251, DateTimeKind.Utc).AddTicks(5033), 27L, "Sint et temporibus sapiente doloribus quod at possimus cumque.", 1, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 39L, "Nam omnis quasi consequuntur.\nVeniam blanditiis voluptatem ut incidunt incidunt.\nVoluptatem magnam est repudiandae voluptas nobis.\nIllo est ratione.", new DateTime(2022, 2, 18, 14, 28, 59, 425, DateTimeKind.Utc).AddTicks(9830), 17L, "Facilis quia suscipit.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { "nobis", new DateTime(2023, 6, 19, 11, 7, 28, 901, DateTimeKind.Utc).AddTicks(7901), 38L, "Enim quo qui et molestiae animi consectetur voluptatibus et.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 9L, "Voluptatum voluptatem enim laborum quae consectetur dolor.\nDoloribus unde veritatis quod veniam porro repellat ut perferendis atque.\nVoluptatibus nam explicabo saepe.\nUnde perspiciatis ut.\nOfficia sint fugit tempore velit aut est nam natus.", new DateTime(2023, 4, 28, 2, 24, 30, 721, DateTimeKind.Utc).AddTicks(3803), 10L, "Iste cupiditate earum exercitationem qui consequatur et expedita molestias corrupti.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 9L, "Exercitationem quibusdam at.", new DateTime(2021, 10, 25, 8, 56, 21, 312, DateTimeKind.Utc).AddTicks(4412), 3L, "Reiciendis aut omnis ducimus est et quam.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 18L, "Atque facere omnis non sint.\nAsperiores explicabo optio voluptatem.\nNihil odit autem in.\nVoluptatem sed ea commodi dolorum.", new DateTime(2022, 2, 16, 14, 11, 19, 56, DateTimeKind.Utc).AddTicks(8178), 20L, "Reiciendis qui quasi iusto reprehenderit ut ipsum quasi suscipit.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 25L, "Sunt at non.\nQuasi voluptate ratione.\nTempora est voluptas perferendis eos repudiandae aut et enim.\nQuod deserunt et aliquam.\nAutem cumque voluptatibus.\nSed fugiat quam sint laudantium error ex dolorem voluptate.", new DateTime(2023, 6, 22, 5, 27, 10, 669, DateTimeKind.Utc).AddTicks(2974), 9L, "Aut ad culpa ipsam placeat et.", 2, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 23L, "Soluta ut eius perspiciatis quo qui. Nemo sunt officia accusantium repellat aut magni et qui. Placeat qui voluptatum sapiente recusandae provident voluptas vitae ut. Neque tempora aut blanditiis. Quia maiores fugiat natus nisi.", new DateTime(2023, 8, 21, 9, 44, 18, 983, DateTimeKind.Utc).AddTicks(5133), 20L, "Veniam nulla numquam rem accusamus commodi.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 49L, "Dicta laborum eum.\nRem placeat quis.\nLaudantium accusamus harum libero beatae reiciendis.", new DateTime(2023, 7, 8, 2, 59, 41, 238, DateTimeKind.Utc).AddTicks(5116), 33L, "Dolorum quisquam nihil voluptatum.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 27L, "Quia expedita dolores voluptatum illum quia accusantium nulla a quis. Dicta consectetur delectus ut blanditiis a dolorem. Modi corrupti aperiam facere et quam ipsa repudiandae aut amet. Ab omnis perferendis praesentium aliquam aut autem. At officiis hic nostrum.", new DateTime(2022, 7, 5, 16, 29, 33, 980, DateTimeKind.Utc).AddTicks(9296), 9L, "Odit aut nihil aut maiores.", 3, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 6L, "Dicta et voluptas illo est nostrum. Expedita eum labore a architecto qui impedit ut vitae et. Dicta enim velit nemo consequatur nisi non non est corrupti. Qui rerum deserunt quas. Ipsum ut provident.", new DateTime(2023, 7, 18, 0, 8, 29, 227, DateTimeKind.Utc).AddTicks(2775), 2L, "Fuga delectus nulla neque.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 14L, "aut", new DateTime(2022, 12, 26, 15, 14, 32, 57, DateTimeKind.Utc).AddTicks(4653), 10L, "Qui aliquid eos eum et.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { "Optio ut rerum omnis cumque necessitatibus quas.", new DateTime(2023, 9, 5, 21, 37, 54, 856, DateTimeKind.Utc).AddTicks(632), 9L, "Sed dolores nulla nulla occaecati molestiae et et aliquid.", 1, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 5L, "Optio quisquam ut consequatur reprehenderit commodi eaque aliquam.", new DateTime(2023, 7, 17, 0, 24, 33, 415, DateTimeKind.Utc).AddTicks(6247), 9L, "Perspiciatis laboriosam ea.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 23L, "nam", new DateTime(2023, 8, 26, 1, 50, 15, 254, DateTimeKind.Utc).AddTicks(6745), 31L, "Maiores similique est saepe dignissimos sit ut ullam consequatur.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 62L, "Ratione minima excepturi dignissimos expedita dignissimos fuga commodi enim et.\nQuas vero ducimus.\nConsequatur laboriosam in ex ut qui culpa quae provident deleniti.", new DateTime(2023, 6, 6, 10, 16, 58, 980, DateTimeKind.Utc).AddTicks(6281), 5L, "Accusantium explicabo delectus expedita.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 45L, "illum", new DateTime(2023, 2, 25, 19, 46, 6, 144, DateTimeKind.Utc).AddTicks(1409), 16L, "Nisi ut et maxime.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 35L, "Aperiam maxime similique incidunt voluptatibus.\nEst error ipsa quaerat perspiciatis ullam nam ut inventore nihil.\nAmet iusto possimus iusto necessitatibus nulla aperiam dolorem aperiam.", new DateTime(2023, 5, 11, 7, 22, 36, 628, DateTimeKind.Utc).AddTicks(4660), "Aut dolores enim dignissimos minus et sunt.", 1, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 59L, "quia", new DateTime(2023, 4, 9, 16, 54, 25, 238, DateTimeKind.Utc).AddTicks(8442), 37L, "Debitis inventore ut.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 60L, "Enim ut consectetur.", new DateTime(2021, 7, 26, 7, 20, 52, 407, DateTimeKind.Utc).AddTicks(6403), 36L, "Ipsa repellat qui fugiat aperiam.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 25L, "Labore ducimus quam est alias alias non.", new DateTime(2022, 11, 27, 1, 1, 22, 200, DateTimeKind.Utc).AddTicks(4960), 34L, "Rerum facere ut.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 27L, "fugit", new DateTime(2022, 7, 25, 11, 17, 28, 526, DateTimeKind.Utc).AddTicks(6658), 4L, "Et eaque culpa sed quia aspernatur sed.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 28L, "tempora", new DateTime(2022, 12, 25, 3, 11, 48, 84, DateTimeKind.Utc).AddTicks(8340), 17L, "Accusamus saepe consectetur soluta rerum vel aut omnis.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 9L, "exercitationem", new DateTime(2021, 6, 9, 8, 18, 36, 907, DateTimeKind.Utc).AddTicks(9043), 2L, "Distinctio omnis officia aspernatur dolores atque maxime in.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 28L, "Eos quo dolorum eum error non porro molestiae et inventore.", new DateTime(2022, 12, 20, 16, 32, 57, 185, DateTimeKind.Utc).AddTicks(5240), 25L, "Nulla rerum maiores blanditiis nemo nesciunt magni maxime repellat corrupti.", 1, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 8L, "Iure quas est.", new DateTime(2022, 2, 23, 6, 10, 54, 687, DateTimeKind.Utc).AddTicks(7016), 3L, "Provident soluta perferendis quia dolorem consequuntur perspiciatis et.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 162L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 49L, "Quod animi nemo optio laborum voluptatum non ipsam rem. Voluptatem perferendis ipsum alias ea. Dolorem non dolor expedita tenetur eos. Vel quia quia reiciendis vitae.", new DateTime(2023, 8, 14, 2, 13, 14, 369, DateTimeKind.Utc).AddTicks(1540), 35L, "Nihil tempore ducimus natus voluptas voluptas.", 1, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 163L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 3L, "Aliquam libero ipsa explicabo et fugit. Facere fugiat animi ad. Occaecati quos dolores consequuntur adipisci repellendus et ullam exercitationem esse. In cum magni voluptatem. Voluptatem dolorem animi unde voluptas facere et.", new DateTime(2023, 8, 12, 14, 15, 40, 545, DateTimeKind.Utc).AddTicks(7956), 8L, "Debitis dolorem temporibus eligendi necessitatibus ipsum quidem repellendus sed.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 164L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 41L, "Enim ipsam magni voluptas ut laudantium quam consequatur quibusdam.\nQui libero repellat est neque assumenda et.\nDicta ipsum mollitia qui.\nVoluptas dolores at accusantium consequatur a et itaque.", new DateTime(2022, 9, 14, 10, 44, 30, 559, DateTimeKind.Utc).AddTicks(3817), 12L, "Delectus sint ad omnis et quia in tempore.", 3, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 165L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 58L, "magnam", new DateTime(2022, 9, 29, 0, 23, 28, 702, DateTimeKind.Utc).AddTicks(9739), 17L, "Accusantium voluptas in id qui aut beatae.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 51L, "Odio laborum voluptate officiis rerum numquam sunt voluptatem.", new DateTime(2023, 1, 28, 16, 33, 0, 720, DateTimeKind.Utc).AddTicks(6949), 25L, "Quam quam nesciunt ducimus tempore aut.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 11L, "odit", new DateTime(2018, 12, 3, 11, 55, 27, 84, DateTimeKind.Utc).AddTicks(6336), 4L, "Error omnis itaque error sunt et in.", 3, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 12L, "iusto", new DateTime(2023, 9, 2, 11, 3, 29, 499, DateTimeKind.Utc).AddTicks(4005), 16L, "Eum est illum nobis beatae eos asperiores velit.", 1, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 5L, "Aspernatur aut ut quas vero est sit quia.\nBlanditiis dolorum rerum voluptas sint ut autem similique consequatur non.", new DateTime(2023, 8, 9, 5, 53, 9, 235, DateTimeKind.Utc).AddTicks(6260), 19L, "Ipsum inventore et vero vel.", 1, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 23L, "corporis", new DateTime(2023, 8, 31, 4, 52, 44, 321, DateTimeKind.Utc).AddTicks(7011), 5L, "Nostrum reiciendis in.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 55L, "Provident quis perferendis culpa voluptatibus facilis perferendis expedita. Eum error placeat repellendus recusandae harum. Ullam veniam tempora sit. Rem beatae vel facilis officiis ipsum.", new DateTime(2023, 1, 25, 14, 8, 18, 953, DateTimeKind.Utc).AddTicks(8819), 4L, "Ut quos omnis veniam magnam eveniet incidunt libero possimus ipsa.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 32L, "Odit doloribus provident totam sapiente animi.", new DateTime(2023, 9, 5, 3, 42, 22, 906, DateTimeKind.Utc).AddTicks(4962), 29L, "Nobis et perferendis exercitationem id soluta blanditiis sunt.", 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 8L, "Officiis suscipit nemo sed.", new DateTime(2022, 9, 6, 6, 0, 17, 13, DateTimeKind.Utc).AddTicks(6491), 25L, "Inventore non sed recusandae odit.", 1, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 18L, "voluptate", new DateTime(2021, 5, 14, 12, 23, 22, 962, DateTimeKind.Utc).AddTicks(9118), 25L, "Id est omnis quasi aut ut qui.", 1, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 48L, "Neque quibusdam temporibus quas commodi soluta.", new DateTime(2023, 8, 21, 17, 54, 53, 168, DateTimeKind.Utc).AddTicks(1534), 7L, "Quibusdam aliquid mollitia aut explicabo aut sunt reiciendis.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 57L, "Et est porro doloribus perspiciatis. Facere nobis vel possimus. Doloremque autem aliquid harum consequatur quia aperiam est ipsa. Enim officia quisquam nesciunt qui harum dicta. Error quo voluptatibus officiis impedit quas dolorem.", new DateTime(2023, 3, 13, 15, 30, 58, 374, DateTimeKind.Utc).AddTicks(5190), 11L, "Ut dicta labore vel.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 45L, "expedita", new DateTime(2023, 7, 23, 0, 2, 15, 813, DateTimeKind.Utc).AddTicks(271), 40L, "Dolorem sint dolores consequuntur eos vel harum ad et ut.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 62L, "Temporibus sit et non odit. Qui aperiam officia illum qui ut et consequatur. Eius delectus accusamus aut ducimus aut et tempore rerum. Sint debitis ea delectus inventore delectus eum voluptates cumque.", new DateTime(2023, 3, 31, 9, 22, 20, 65, DateTimeKind.Utc).AddTicks(9119), 9L, "Animi libero dolor dolore ipsa omnis nesciunt vitae pariatur.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 59L, "Consequatur earum sed voluptatibus repellat sint reprehenderit ea. Atque impedit amet quibusdam modi et non at. Voluptas et consequatur rerum asperiores placeat laboriosam. Aperiam dolor sed saepe qui debitis. Velit aliquid accusantium itaque.", new DateTime(2023, 3, 2, 16, 47, 53, 839, DateTimeKind.Utc).AddTicks(4746), 13L, "Velit quibusdam tempora dolor numquam.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 65L, "minus", new DateTime(2023, 7, 27, 16, 9, 17, 192, DateTimeKind.Utc).AddTicks(5762), 25L, "Id quas nisi iste.", 3, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 18L, "Mollitia accusamus eaque. Accusamus temporibus suscipit quos laborum nam aliquam. Asperiores ut nulla dignissimos. Delectus dolores voluptatem eius suscipit incidunt beatae. Nisi quis odit explicabo ipsa blanditiis voluptatibus. Voluptas a voluptatem eligendi odit veritatis aut ad.", new DateTime(2020, 9, 22, 15, 13, 30, 646, DateTimeKind.Utc).AddTicks(8908), 28L, "Quia hic quis facilis perspiciatis aut numquam sequi voluptas.", 2, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 40L, "Sapiente voluptatem cupiditate quas incidunt in sunt quia.", new DateTime(2023, 5, 18, 6, 29, 3, 467, DateTimeKind.Utc).AddTicks(8617), 38L, "Rerum eaque assumenda et et fuga similique quibusdam.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 3L, "Quia iure et.\nAut provident cumque soluta qui.\nSed corporis quae.\nSoluta magnam quam.\nMaiores cumque molestias sit quaerat eveniet exercitationem.", new DateTime(2023, 8, 4, 8, 38, 39, 428, DateTimeKind.Utc).AddTicks(2757), 35L, "Qui ut voluptas maiores omnis dicta est eum odio.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 2L, "Labore pariatur voluptatem nemo.", new DateTime(2020, 6, 2, 18, 10, 4, 514, DateTimeKind.Utc).AddTicks(7788), 29L, "Fugiat vero nesciunt architecto sit omnis repudiandae.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 64L, "Dolores non vel sequi quas cumque dignissimos. Voluptatibus et cumque molestias sunt pariatur praesentium distinctio asperiores hic. Enim facilis suscipit assumenda nisi laborum optio.", new DateTime(2020, 2, 25, 21, 41, 9, 247, DateTimeKind.Utc).AddTicks(7588), 31L, "Sapiente aut impedit rerum error nemo magni.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 58L, "quisquam", new DateTime(2023, 2, 5, 9, 24, 19, 100, DateTimeKind.Utc).AddTicks(5068), 32L, "At hic quidem quo aperiam accusamus aut nam culpa.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 38L, "omnis", new DateTime(2023, 2, 9, 17, 35, 5, 280, DateTimeKind.Utc).AddTicks(4603), 24L, "Ut enim sit modi temporibus debitis.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 9L, "placeat", new DateTime(2022, 7, 10, 13, 26, 29, 857, DateTimeKind.Utc).AddTicks(930), 35L, "Numquam ducimus ut expedita eos.", 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 41L, "Sunt veritatis architecto voluptatum tenetur error voluptas repellat dicta.\nPossimus quas blanditiis.\nEt et facilis id ad amet eaque ea aspernatur veniam.\nEveniet rerum eum ut ipsam aut animi.", new DateTime(2022, 1, 12, 7, 41, 22, 142, DateTimeKind.Utc).AddTicks(5367), 24L, "Laborum eos cupiditate nesciunt et ut molestiae.", 4, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 68L, "Ex magnam dolorum eligendi quam enim eum.", new DateTime(2023, 1, 24, 4, 27, 7, 379, DateTimeKind.Utc).AddTicks(2456), 38L, "Quibusdam veritatis et voluptatem omnis rerum fugiat aut.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 52L, "Et earum non iure necessitatibus culpa praesentium.\nOdio quos nisi accusantium et eligendi.\nSit corrupti placeat fugit harum minima.", new DateTime(2022, 3, 1, 21, 27, 39, 826, DateTimeKind.Utc).AddTicks(7677), 35L, "Earum explicabo est hic sequi placeat debitis.", 4, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 69L, "Nam quo facere quia.\nEarum harum quas laboriosam corrupti natus ad sint dignissimos beatae.", new DateTime(2023, 3, 8, 23, 24, 22, 502, DateTimeKind.Utc).AddTicks(7082), 6L, "Eligendi soluta commodi.", 3, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 70L, "Delectus sit officiis. Voluptatibus et aut animi consequatur atque magni earum quia dolor. Itaque laborum non voluptatem. Aut in provident culpa ex dolorum omnis odio. Aut inventore id similique velit. Rerum ipsa blanditiis aspernatur rerum repellat distinctio.", new DateTime(2023, 6, 19, 3, 46, 33, 493, DateTimeKind.Utc).AddTicks(2479), 15L, "Nemo explicabo velit assumenda non fugiat sunt.", 2, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 52L, "Aut error quibusdam.\nEt ea aspernatur sed dolore.\nNihil reprehenderit autem repudiandae qui modi eveniet nesciunt.\nVoluptatem quo odio vitae ut eos doloribus pariatur sed.\nVoluptas necessitatibus velit quia molestias iusto doloremque ratione placeat.", new DateTime(2022, 9, 29, 1, 3, 45, 569, DateTimeKind.Utc).AddTicks(4640), 19L, "Animi deserunt eius.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 25L, "illum", new DateTime(2023, 1, 22, 19, 7, 15, 652, DateTimeKind.Utc).AddTicks(52), 20L, "Sunt ab doloribus vero iusto autem eligendi.", 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 18L, "Aut enim et voluptatum omnis beatae ratione suscipit explicabo.", new DateTime(2023, 7, 29, 1, 50, 13, 907, DateTimeKind.Utc).AddTicks(8049), 19L, "Rerum excepturi error optio.", 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 64L, "Eum mollitia assumenda.", new DateTime(2022, 2, 27, 0, 57, 23, 864, DateTimeKind.Utc).AddTicks(8630), 36L, "Alias doloribus aspernatur.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 12L, "Consequuntur vel rerum ullam unde qui est debitis aspernatur. Voluptatem nostrum quasi quidem occaecati totam labore. Reiciendis esse quas impedit sunt alias. Natus voluptatem accusamus aliquam. Sunt est voluptate enim debitis est.", new DateTime(2023, 7, 19, 6, 51, 16, 357, DateTimeKind.Utc).AddTicks(479), 5L, "Modi modi omnis recusandae.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 43L, "Esse consequatur aut odit maiores. At dolorum laborum esse quis rerum omnis. Voluptates aliquam architecto rerum debitis perspiciatis laborum et dolor.", new DateTime(2023, 8, 23, 8, 1, 17, 373, DateTimeKind.Utc).AddTicks(8010), 25L, "Inventore qui non deserunt occaecati unde cumque facere cupiditate cupiditate.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 32L, "Sed cupiditate sit.", new DateTime(2023, 8, 28, 22, 57, 7, 748, DateTimeKind.Utc).AddTicks(1993), 7L, "Delectus error vel voluptatem eaque praesentium et.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 10, 23, 4, 41, 46, 874, DateTimeKind.Utc).AddTicks(6931), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2018, 3, 15, 7, 49, 46, 910, DateTimeKind.Utc).AddTicks(7641), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 6, 18, 15, 3, 45, 744, DateTimeKind.Utc).AddTicks(785), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 3, 3, 6, 12, 25, 839, DateTimeKind.Utc).AddTicks(8717), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 3, 20, 4, 48, 39, 557, DateTimeKind.Utc).AddTicks(1468), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 4, 19, 12, 51, 53, 312, DateTimeKind.Utc).AddTicks(897), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2020, 1, 6, 0, 47, 16, 415, DateTimeKind.Utc).AddTicks(7763), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2017, 1, 15, 10, 4, 36, 506, DateTimeKind.Utc).AddTicks(1528), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2019, 12, 4, 19, 31, 35, 461, DateTimeKind.Utc).AddTicks(5449), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 5, 31, 2, 51, 11, 337, DateTimeKind.Utc).AddTicks(9940), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2018, 1, 12, 19, 37, 38, 225, DateTimeKind.Utc).AddTicks(2210), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 8, 9, 3, 53, 44, 268, DateTimeKind.Utc).AddTicks(2269), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2017, 10, 22, 10, 18, 9, 928, DateTimeKind.Utc).AddTicks(5158), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 10, 12, 18, 50, 36, 218, DateTimeKind.Utc).AddTicks(7473), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2018, 7, 13, 8, 40, 37, 161, DateTimeKind.Utc).AddTicks(3415), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 3, 16, 21, 55, 53, 871, DateTimeKind.Utc).AddTicks(7547), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 1, 16, 7, 9, 34, 208, DateTimeKind.Utc).AddTicks(7169), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2020, 4, 17, 0, 49, 1, 863, DateTimeKind.Utc).AddTicks(4592), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 7, 22, 8, 50, 2, 450, DateTimeKind.Utc).AddTicks(1788), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 4, 1, 5, 29, 18, 972, DateTimeKind.Utc).AddTicks(3220), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 11, 26, 13, 45, 50, 916, DateTimeKind.Utc).AddTicks(9298), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 9, 25, 7, 42, 40, 795, DateTimeKind.Utc).AddTicks(4245), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 8, 20, 15, 38, 28, 207, DateTimeKind.Utc).AddTicks(2764), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2021, 8, 9, 10, 58, 53, 923, DateTimeKind.Utc).AddTicks(9641), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 11, 3, 18, 47, 9, 80, DateTimeKind.Utc).AddTicks(2699), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 1, 3, 12, 48, 22, 332, DateTimeKind.Utc).AddTicks(5617), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 5, 10, 23, 35, 4, 849, DateTimeKind.Utc).AddTicks(5676), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 2, 10, 21, 37, 5, 192, DateTimeKind.Utc).AddTicks(3800), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2020, 7, 24, 21, 29, 36, 309, DateTimeKind.Utc).AddTicks(545), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2017, 6, 30, 23, 32, 36, 235, DateTimeKind.Utc).AddTicks(8073), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 1, 8, 13, 28, 57, 574, DateTimeKind.Utc).AddTicks(4300), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 8, 5, 13, 37, 48, 182, DateTimeKind.Utc).AddTicks(9466), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 9, 10, 18, 4, 56, 883, DateTimeKind.Utc).AddTicks(3397), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 9, 19, 9, 4, 1, 396, DateTimeKind.Utc).AddTicks(9166), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 5, 9, 4, 14, 18, 856, DateTimeKind.Utc).AddTicks(5217), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2021, 5, 30, 5, 38, 41, 167, DateTimeKind.Utc).AddTicks(6053), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2021, 9, 25, 20, 41, 45, 715, DateTimeKind.Utc).AddTicks(5144), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 6, 17, 12, 42, 56, 759, DateTimeKind.Utc).AddTicks(2959), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 2, 10, 23, 41, 25, 462, DateTimeKind.Utc).AddTicks(3298), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 1, 12, 19, 42, 21, 925, DateTimeKind.Utc).AddTicks(6521), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2021, 11, 29, 19, 7, 47, 455, DateTimeKind.Utc).AddTicks(6937), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 2, 3, 4, 32, 14, 559, DateTimeKind.Utc).AddTicks(8129), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 8, 20, 6, 18, 8, 556, DateTimeKind.Utc).AddTicks(5179), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2019, 2, 6, 17, 38, 51, 503, DateTimeKind.Utc).AddTicks(2928), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 12, 4, 13, 59, 42, 535, DateTimeKind.Utc).AddTicks(9472), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 5, 26, 7, 5, 26, 703, DateTimeKind.Utc).AddTicks(2376), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2020, 11, 6, 3, 46, 10, 408, DateTimeKind.Utc).AddTicks(4084), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 1, 1, 13, 10, 46, 135, DateTimeKind.Utc).AddTicks(3623), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 6, 12, 4, 38, 45, 954, DateTimeKind.Utc).AddTicks(2378), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 3, 20, 18, 46, 18, 950, DateTimeKind.Utc).AddTicks(5216), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 8, 18, 13, 18, 17, 60, DateTimeKind.Utc).AddTicks(3426), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 1, 28, 10, 27, 46, 599, DateTimeKind.Utc).AddTicks(1690), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2019, 4, 11, 1, 36, 35, 61, DateTimeKind.Utc).AddTicks(6576), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 1, 24, 0, 43, 47, 337, DateTimeKind.Utc).AddTicks(1068), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 9, 19, 13, 59, 54, 267, DateTimeKind.Utc).AddTicks(7489), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2018, 4, 21, 20, 30, 10, 794, DateTimeKind.Utc).AddTicks(4736), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 6, 4, 20, 46, 43, 696, DateTimeKind.Utc).AddTicks(3863), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2019, 7, 18, 7, 32, 45, 799, DateTimeKind.Utc).AddTicks(87), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 1, 15, 0, 49, 19, 34, DateTimeKind.Utc).AddTicks(2978), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2019, 2, 23, 22, 23, 9, 8, DateTimeKind.Utc).AddTicks(8813), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 4, 24, 23, 31, 49, 335, DateTimeKind.Utc).AddTicks(1453), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 10, 1, 19, 49, 20, 954, DateTimeKind.Utc).AddTicks(4554), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2020, 10, 14, 8, 15, 22, 430, DateTimeKind.Utc).AddTicks(3340), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2019, 12, 19, 16, 27, 43, 540, DateTimeKind.Utc).AddTicks(3311), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2021, 5, 17, 5, 38, 22, 627, DateTimeKind.Utc).AddTicks(1722), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2021, 11, 28, 1, 39, 53, 58, DateTimeKind.Utc).AddTicks(3287), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 12, 5, 2, 16, 56, 153, DateTimeKind.Utc).AddTicks(7240), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 1, 11, 1, 44, 9, 503, DateTimeKind.Utc).AddTicks(5122), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 9, 23, 8, 31, 28, 733, DateTimeKind.Utc).AddTicks(197), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 9, 22, 2, 33, 8, 622, DateTimeKind.Utc).AddTicks(1500), 4 });

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

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 18, 0, 24, 47, 46, DateTimeKind.Utc).AddTicks(41), new DateTime(2023, 7, 16, 9, 15, 20, 286, DateTimeKind.Utc).AddTicks(9124), new DateTime(2022, 8, 12, 4, 17, 54, 629, DateTimeKind.Utc).AddTicks(4222), 2, new DateTime(2023, 7, 18, 16, 44, 58, 414, DateTimeKind.Utc).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 15, 3, 48, 44, 242, DateTimeKind.Utc).AddTicks(5579), new DateTime(2023, 7, 27, 18, 26, 49, 118, DateTimeKind.Utc).AddTicks(1527), new DateTime(2023, 1, 19, 15, 53, 18, 704, DateTimeKind.Utc).AddTicks(9891), 1, new DateTime(2023, 2, 4, 10, 40, 22, 65, DateTimeKind.Utc).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 6, 19, 0, 21, 537, DateTimeKind.Utc).AddTicks(1459), new DateTime(2023, 7, 25, 14, 7, 48, 771, DateTimeKind.Utc).AddTicks(694), new DateTime(2023, 5, 8, 3, 52, 4, 131, DateTimeKind.Utc).AddTicks(5179), 2, new DateTime(2023, 7, 18, 23, 14, 24, 932, DateTimeKind.Utc).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 1, 11, 15, 54, 25, 988, DateTimeKind.Utc).AddTicks(5092), new DateTime(2022, 5, 30, 3, 50, 47, 525, DateTimeKind.Utc).AddTicks(8236), new DateTime(2021, 7, 30, 22, 29, 29, 263, DateTimeKind.Utc).AddTicks(5057), 1, new DateTime(2022, 8, 10, 17, 11, 11, 322, DateTimeKind.Utc).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 17, 28, 30, 438, DateTimeKind.Utc).AddTicks(9589), new DateTime(2023, 5, 4, 16, 34, 3, 631, DateTimeKind.Utc).AddTicks(8125), new DateTime(2022, 10, 27, 20, 56, 24, 642, DateTimeKind.Utc).AddTicks(1706), 1, new DateTime(2023, 8, 12, 11, 20, 41, 124, DateTimeKind.Utc).AddTicks(6972) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 9, 12, 1, 59, 46, 745, DateTimeKind.Utc).AddTicks(8463), new DateTime(2021, 4, 9, 9, 11, 35, 499, DateTimeKind.Utc).AddTicks(3935), new DateTime(2018, 12, 15, 15, 35, 13, 685, DateTimeKind.Utc).AddTicks(2531), 3, new DateTime(2019, 12, 28, 4, 28, 43, 218, DateTimeKind.Utc).AddTicks(7636) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 2, 20, 4, 45, 24, 938, DateTimeKind.Utc).AddTicks(4935), new DateTime(2023, 1, 27, 16, 10, 55, 217, DateTimeKind.Utc).AddTicks(8540), new DateTime(2020, 4, 21, 10, 30, 36, 795, DateTimeKind.Utc).AddTicks(3551), 1, new DateTime(2021, 1, 22, 2, 17, 3, 376, DateTimeKind.Utc).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 10, 15, 5, 3, 23, 943, DateTimeKind.Utc).AddTicks(1296), new DateTime(2022, 8, 23, 23, 4, 28, 600, DateTimeKind.Utc).AddTicks(8256), new DateTime(2021, 5, 4, 23, 38, 30, 999, DateTimeKind.Utc).AddTicks(8594), 3, new DateTime(2021, 7, 16, 4, 25, 7, 685, DateTimeKind.Utc).AddTicks(2362) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 17, 15, 33, 954, DateTimeKind.Utc).AddTicks(4545), new DateTime(2023, 5, 24, 16, 15, 51, 316, DateTimeKind.Utc).AddTicks(7539), new DateTime(2021, 5, 31, 10, 41, 2, 899, DateTimeKind.Utc).AddTicks(4177), 2, new DateTime(2022, 4, 29, 18, 41, 28, 820, DateTimeKind.Utc).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 3, 22, 6, 25, 466, DateTimeKind.Utc).AddTicks(1144), new DateTime(2022, 3, 19, 2, 32, 3, 895, DateTimeKind.Utc).AddTicks(8649), new DateTime(2021, 3, 12, 1, 15, 8, 466, DateTimeKind.Utc).AddTicks(575), 1, new DateTime(2022, 12, 2, 11, 18, 53, 357, DateTimeKind.Utc).AddTicks(8251) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 21, 15, 879, DateTimeKind.Utc).AddTicks(3001), new DateTime(2023, 4, 7, 17, 25, 20, 557, DateTimeKind.Utc).AddTicks(9871), new DateTime(2023, 1, 10, 18, 6, 49, 434, DateTimeKind.Utc).AddTicks(6703), 3, new DateTime(2023, 2, 14, 5, 44, 35, 336, DateTimeKind.Utc).AddTicks(7485) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 2, 42, 47, 227, DateTimeKind.Utc).AddTicks(1404), new DateTime(2022, 12, 14, 8, 0, 43, 318, DateTimeKind.Utc).AddTicks(2481), new DateTime(2022, 9, 19, 10, 58, 40, 935, DateTimeKind.Utc).AddTicks(9467), 1, new DateTime(2023, 8, 9, 20, 20, 19, 558, DateTimeKind.Utc).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 16, 0, 42, 5, 744, DateTimeKind.Utc).AddTicks(4192), new DateTime(2023, 9, 7, 3, 8, 7, 430, DateTimeKind.Utc).AddTicks(9972), new DateTime(2023, 4, 16, 2, 22, 11, 70, DateTimeKind.Utc).AddTicks(9314), 1, new DateTime(2023, 8, 28, 20, 51, 58, 592, DateTimeKind.Utc).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 5, 23, 18, 5, 24, 427, DateTimeKind.Utc).AddTicks(148), new DateTime(2020, 7, 26, 3, 13, 18, 9, DateTimeKind.Utc).AddTicks(4946), new DateTime(2019, 11, 11, 12, 6, 26, 827, DateTimeKind.Utc).AddTicks(6012), 2, new DateTime(2022, 10, 23, 0, 44, 45, 775, DateTimeKind.Utc).AddTicks(2608) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 9, 1, 14, 23, 33, 289, DateTimeKind.Utc).AddTicks(6607), new DateTime(2022, 8, 11, 23, 27, 26, 119, DateTimeKind.Utc).AddTicks(5939), new DateTime(2021, 3, 30, 10, 26, 7, 461, DateTimeKind.Utc).AddTicks(5717), 1, new DateTime(2023, 7, 5, 13, 52, 3, 511, DateTimeKind.Utc).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId" },
                values: new object[] { new DateTime(2023, 10, 7, 5, 25, 17, 743, DateTimeKind.Utc).AddTicks(4640), new DateTime(2023, 8, 17, 21, 32, 48, 365, DateTimeKind.Utc).AddTicks(1332), new DateTime(2023, 2, 15, 20, 37, 9, 333, DateTimeKind.Utc).AddTicks(5720), 3 });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 1, 23, 8, 59, 38, 446, DateTimeKind.Utc).AddTicks(4587), new DateTime(2020, 12, 3, 7, 35, 29, 680, DateTimeKind.Utc).AddTicks(1175), new DateTime(2019, 1, 17, 17, 31, 23, 400, DateTimeKind.Utc).AddTicks(231), 3, new DateTime(2020, 8, 19, 4, 23, 48, 703, DateTimeKind.Utc).AddTicks(5049) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 18, 38, 44, 18, DateTimeKind.Utc).AddTicks(6584), new DateTime(2023, 7, 31, 4, 1, 36, 556, DateTimeKind.Utc).AddTicks(293), new DateTime(2020, 12, 23, 15, 16, 49, 562, DateTimeKind.Utc).AddTicks(4267), 3, new DateTime(2021, 11, 29, 11, 39, 25, 825, DateTimeKind.Utc).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 3, 10, 13, 16, 877, DateTimeKind.Utc).AddTicks(8275), new DateTime(2023, 7, 2, 11, 38, 19, 293, DateTimeKind.Utc).AddTicks(2038), new DateTime(2023, 6, 21, 19, 24, 3, 241, DateTimeKind.Utc).AddTicks(5364), 2, new DateTime(2023, 7, 18, 5, 10, 2, 623, DateTimeKind.Utc).AddTicks(6412) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 3, 24, 18, 58, 51, 441, DateTimeKind.Utc).AddTicks(6090), new DateTime(2020, 2, 25, 8, 56, 25, 952, DateTimeKind.Utc).AddTicks(3525), new DateTime(2019, 11, 25, 13, 4, 31, 53, DateTimeKind.Utc).AddTicks(607), 1, new DateTime(2022, 3, 9, 1, 2, 19, 659, DateTimeKind.Utc).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 3, 15, 21, 42, 95, DateTimeKind.Utc).AddTicks(8959), new DateTime(2023, 5, 27, 17, 34, 38, 98, DateTimeKind.Utc).AddTicks(1413), new DateTime(2022, 3, 1, 6, 34, 42, 511, DateTimeKind.Utc).AddTicks(660), 1, new DateTime(2023, 6, 13, 19, 3, 8, 573, DateTimeKind.Utc).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 4, 21, 52, 505, DateTimeKind.Utc).AddTicks(15), new DateTime(2023, 4, 30, 9, 4, 51, 838, DateTimeKind.Utc).AddTicks(4608), new DateTime(2019, 12, 13, 13, 49, 39, 735, DateTimeKind.Utc).AddTicks(3355), 1, new DateTime(2022, 5, 11, 17, 57, 56, 36, DateTimeKind.Utc).AddTicks(8335) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 3, 24, 23, 45, 20, 6, DateTimeKind.Utc).AddTicks(4), new DateTime(2020, 3, 19, 13, 21, 58, 72, DateTimeKind.Utc).AddTicks(2608), new DateTime(2017, 7, 19, 2, 15, 58, 112, DateTimeKind.Utc).AddTicks(6526), 1, new DateTime(2023, 8, 28, 3, 42, 26, 91, DateTimeKind.Utc).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 5, 22, 4, 25, 50, 374, DateTimeKind.Utc).AddTicks(1636), new DateTime(2019, 7, 31, 16, 56, 35, 385, DateTimeKind.Utc).AddTicks(2192), new DateTime(2019, 3, 29, 20, 26, 1, 185, DateTimeKind.Utc).AddTicks(7379), 1, new DateTime(2020, 9, 16, 19, 50, 52, 517, DateTimeKind.Utc).AddTicks(367) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 22, 14, 449, DateTimeKind.Utc).AddTicks(4743), new DateTime(2023, 4, 1, 13, 59, 29, 844, DateTimeKind.Utc).AddTicks(527), new DateTime(2021, 4, 10, 1, 3, 11, 216, DateTimeKind.Utc).AddTicks(2913), 2, new DateTime(2022, 4, 6, 21, 19, 0, 557, DateTimeKind.Utc).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 22, 14, 58, 48, 241, DateTimeKind.Utc).AddTicks(1873), new DateTime(2023, 5, 12, 10, 50, 49, 259, DateTimeKind.Utc).AddTicks(7644), new DateTime(2023, 2, 10, 1, 1, 36, 617, DateTimeKind.Utc).AddTicks(1151), 2, new DateTime(2023, 3, 31, 1, 3, 21, 311, DateTimeKind.Utc).AddTicks(1472) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId" },
                values: new object[] { new DateTime(2023, 2, 18, 8, 59, 36, 48, DateTimeKind.Utc).AddTicks(7366), new DateTime(2022, 12, 22, 19, 11, 51, 293, DateTimeKind.Utc).AddTicks(7163), new DateTime(2022, 7, 2, 3, 38, 31, 757, DateTimeKind.Utc).AddTicks(1038), 2 });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 6, 44, 48, 46, DateTimeKind.Utc).AddTicks(9578), new DateTime(2023, 5, 24, 0, 52, 16, 706, DateTimeKind.Utc).AddTicks(7956), new DateTime(2023, 3, 23, 2, 57, 46, 902, DateTimeKind.Utc).AddTicks(9453), 1, new DateTime(2023, 8, 10, 5, 54, 1, 799, DateTimeKind.Utc).AddTicks(4847) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 19, 13, 6, 28, 567, DateTimeKind.Utc).AddTicks(5516), new DateTime(2023, 4, 1, 1, 51, 13, 987, DateTimeKind.Utc).AddTicks(6480), new DateTime(2023, 2, 22, 9, 30, 22, 233, DateTimeKind.Utc).AddTicks(7519), 2, new DateTime(2023, 7, 12, 12, 28, 42, 665, DateTimeKind.Utc).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 8, 15, 53, 45, 234, DateTimeKind.Utc).AddTicks(9692), new DateTime(2023, 7, 17, 16, 35, 40, 436, DateTimeKind.Utc).AddTicks(532), new DateTime(2021, 8, 3, 4, 17, 34, 846, DateTimeKind.Utc).AddTicks(9574), 3, new DateTime(2022, 6, 21, 1, 28, 19, 617, DateTimeKind.Utc).AddTicks(7049) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 11, 6, 30, 195, DateTimeKind.Utc).AddTicks(5106), new DateTime(2023, 8, 17, 16, 18, 13, 822, DateTimeKind.Utc).AddTicks(119), new DateTime(2023, 8, 13, 15, 46, 48, 396, DateTimeKind.Utc).AddTicks(94), 2, new DateTime(2023, 8, 26, 6, 46, 38, 494, DateTimeKind.Utc).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 8, 11, 42, 28, 540, DateTimeKind.Utc).AddTicks(8488), new DateTime(2022, 3, 30, 14, 4, 48, 48, DateTimeKind.Utc).AddTicks(9899), new DateTime(2022, 2, 6, 22, 33, 48, 131, DateTimeKind.Utc).AddTicks(8442), 3, new DateTime(2023, 6, 29, 3, 41, 12, 373, DateTimeKind.Utc).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 8, 31, 0, 34, 20, 2, DateTimeKind.Utc).AddTicks(2384), new DateTime(2022, 6, 20, 19, 6, 28, 227, DateTimeKind.Utc).AddTicks(4977), new DateTime(2019, 6, 13, 16, 5, 2, 690, DateTimeKind.Utc).AddTicks(2302), 2, new DateTime(2019, 8, 22, 13, 9, 17, 976, DateTimeKind.Utc).AddTicks(4899) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 15, 21, 39, 19, 787, DateTimeKind.Utc).AddTicks(305), new DateTime(2023, 8, 30, 0, 55, 42, 351, DateTimeKind.Utc).AddTicks(4913), new DateTime(2022, 8, 15, 8, 20, 48, 902, DateTimeKind.Utc).AddTicks(4545), 3, new DateTime(2022, 9, 13, 0, 2, 59, 694, DateTimeKind.Utc).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2019, 11, 30, 22, 16, 47, 590, DateTimeKind.Utc).AddTicks(4223), new DateTime(2019, 10, 26, 11, 45, 52, 985, DateTimeKind.Utc).AddTicks(5510), new DateTime(2018, 8, 3, 0, 15, 26, 234, DateTimeKind.Utc).AddTicks(1537), 2, new DateTime(2021, 3, 17, 11, 35, 51, 807, DateTimeKind.Utc).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 17, 30, 7, 833, DateTimeKind.Utc).AddTicks(8672), new DateTime(2021, 11, 21, 1, 10, 24, 784, DateTimeKind.Utc).AddTicks(2653), new DateTime(2021, 4, 7, 12, 42, 12, 316, DateTimeKind.Utc).AddTicks(2828), 3, new DateTime(2021, 12, 5, 12, 10, 37, 683, DateTimeKind.Utc).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 6, 58, 19, 863, DateTimeKind.Utc).AddTicks(3293), new DateTime(2023, 4, 3, 19, 55, 41, 459, DateTimeKind.Utc).AddTicks(6504), new DateTime(2022, 7, 6, 18, 43, 4, 84, DateTimeKind.Utc).AddTicks(8838), 1, new DateTime(2023, 4, 16, 13, 21, 15, 229, DateTimeKind.Utc).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 32, 7, 980, DateTimeKind.Utc).AddTicks(8029), new DateTime(2023, 8, 15, 4, 19, 25, 308, DateTimeKind.Utc).AddTicks(1540), new DateTime(2023, 6, 24, 7, 5, 33, 792, DateTimeKind.Utc).AddTicks(3449), 2, new DateTime(2023, 8, 20, 23, 27, 8, 812, DateTimeKind.Utc).AddTicks(7369) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId" },
                values: new object[] { new DateTime(2024, 2, 21, 21, 9, 47, 106, DateTimeKind.Utc).AddTicks(6763), new DateTime(2023, 6, 25, 15, 2, 8, 458, DateTimeKind.Utc).AddTicks(4597), new DateTime(2023, 5, 20, 16, 34, 19, 169, DateTimeKind.Utc).AddTicks(9613), 3 });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 26, 17, 45, 14, 236, DateTimeKind.Utc).AddTicks(3532), new DateTime(2022, 7, 7, 7, 57, 12, 804, DateTimeKind.Utc).AddTicks(3295), new DateTime(2020, 12, 16, 1, 7, 11, 655, DateTimeKind.Utc).AddTicks(2270), 3, new DateTime(2022, 8, 5, 6, 53, 48, 998, DateTimeKind.Utc).AddTicks(755) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 59, 28, 656, DateTimeKind.Utc).AddTicks(7282), new DateTime(2020, 1, 24, 3, 10, 50, 659, DateTimeKind.Utc).AddTicks(4013), new DateTime(2019, 11, 27, 19, 23, 21, 103, DateTimeKind.Utc).AddTicks(4073), 1, new DateTime(2023, 6, 9, 17, 54, 18, 738, DateTimeKind.Utc).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 19, 19, 46, 7, 536, DateTimeKind.Utc).AddTicks(7443), new DateTime(2023, 7, 13, 7, 12, 46, 138, DateTimeKind.Utc).AddTicks(1643), new DateTime(2020, 6, 5, 3, 42, 18, 774, DateTimeKind.Utc).AddTicks(1424), 1, new DateTime(2020, 11, 1, 12, 34, 19, 560, DateTimeKind.Utc).AddTicks(5784) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 22, 14, 51, 43, 415, DateTimeKind.Utc).AddTicks(1707), new DateTime(2023, 8, 17, 17, 26, 55, 575, DateTimeKind.Utc).AddTicks(4077), new DateTime(2023, 8, 3, 10, 5, 38, 263, DateTimeKind.Utc).AddTicks(3497), 2, new DateTime(2023, 9, 1, 18, 54, 34, 910, DateTimeKind.Utc).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 26, 5, 55, 35, 913, DateTimeKind.Utc).AddTicks(5165), new DateTime(2023, 8, 12, 23, 59, 8, 748, DateTimeKind.Utc).AddTicks(1196), new DateTime(2023, 6, 28, 21, 33, 38, 747, DateTimeKind.Utc).AddTicks(2928), 3, new DateTime(2023, 7, 23, 17, 15, 32, 593, DateTimeKind.Utc).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 42, 17, 594, DateTimeKind.Utc).AddTicks(5065), new DateTime(2023, 4, 22, 4, 52, 35, 307, DateTimeKind.Utc).AddTicks(9738), new DateTime(2022, 9, 14, 1, 47, 20, 591, DateTimeKind.Utc).AddTicks(514), 2, new DateTime(2023, 3, 18, 18, 31, 18, 174, DateTimeKind.Utc).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 16, 5, 3, 19, 302, DateTimeKind.Utc).AddTicks(4727), new DateTime(2022, 2, 11, 22, 57, 5, 320, DateTimeKind.Utc).AddTicks(210), new DateTime(2020, 6, 12, 5, 24, 2, 533, DateTimeKind.Utc).AddTicks(6372), 1, new DateTime(2021, 11, 20, 14, 47, 42, 270, DateTimeKind.Utc).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 18, 19, 35, 28, 354, DateTimeKind.Utc).AddTicks(1794), new DateTime(2023, 8, 26, 7, 45, 32, 386, DateTimeKind.Utc).AddTicks(8519), new DateTime(2023, 4, 12, 23, 30, 38, 553, DateTimeKind.Utc).AddTicks(2097), 1, new DateTime(2023, 8, 8, 22, 39, 59, 179, DateTimeKind.Utc).AddTicks(590) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 7, 1, 11, 7, 12, 658, DateTimeKind.Utc).AddTicks(8770), new DateTime(2021, 12, 10, 10, 44, 46, 898, DateTimeKind.Utc).AddTicks(3625), new DateTime(2020, 1, 2, 21, 25, 30, 838, DateTimeKind.Utc).AddTicks(8185), 2, new DateTime(2021, 2, 20, 13, 6, 42, 79, DateTimeKind.Utc).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 6, 17, 4, 38, 25, 615, DateTimeKind.Utc).AddTicks(1950), new DateTime(2023, 8, 26, 7, 39, 17, 974, DateTimeKind.Utc).AddTicks(390), new DateTime(2023, 4, 1, 6, 17, 58, 867, DateTimeKind.Utc).AddTicks(1910), 1, new DateTime(2023, 8, 22, 18, 49, 18, 283, DateTimeKind.Utc).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId" },
                values: new object[] { new DateTime(2021, 8, 11, 7, 57, 4, 526, DateTimeKind.Utc).AddTicks(9528), new DateTime(2021, 6, 28, 8, 53, 8, 691, DateTimeKind.Utc).AddTicks(2859), new DateTime(2020, 3, 4, 11, 8, 57, 185, DateTimeKind.Utc).AddTicks(4467), 2 });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 4, 26, 20, 35, 4, 83, DateTimeKind.Utc).AddTicks(6981), new DateTime(2021, 5, 10, 14, 8, 28, 774, DateTimeKind.Utc).AddTicks(8589), new DateTime(2019, 10, 29, 2, 40, 19, 52, DateTimeKind.Utc).AddTicks(4500), 1, new DateTime(2023, 2, 13, 13, 56, 21, 66, DateTimeKind.Utc).AddTicks(7169) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 14, 19, 56, 0, 679, DateTimeKind.Utc).AddTicks(1142), new DateTime(2023, 8, 4, 5, 43, 4, 898, DateTimeKind.Utc).AddTicks(907), new DateTime(2023, 7, 3, 6, 50, 49, 807, DateTimeKind.Utc).AddTicks(2859), 3, new DateTime(2023, 7, 29, 14, 35, 56, 349, DateTimeKind.Utc).AddTicks(9233) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 7, 17, 37, 57, 14, DateTimeKind.Utc).AddTicks(7570), new DateTime(2023, 8, 2, 10, 19, 3, 512, DateTimeKind.Utc).AddTicks(1958), new DateTime(2022, 3, 21, 17, 37, 23, 535, DateTimeKind.Utc).AddTicks(6032), 1, new DateTime(2022, 4, 9, 23, 20, 22, 420, DateTimeKind.Utc).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 3, 23, 2, 18, 27, 491, DateTimeKind.Utc).AddTicks(1138), new DateTime(2022, 9, 7, 14, 10, 29, 965, DateTimeKind.Utc).AddTicks(2587), new DateTime(2021, 10, 18, 7, 39, 11, 830, DateTimeKind.Utc).AddTicks(1602), 1, new DateTime(2022, 4, 10, 7, 10, 59, 370, DateTimeKind.Utc).AddTicks(3863) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 1, 16, 15, 34, 29, 85, DateTimeKind.Utc).AddTicks(834), new DateTime(2022, 9, 19, 15, 1, 50, 168, DateTimeKind.Utc).AddTicks(2485), new DateTime(2022, 8, 4, 19, 30, 30, 547, DateTimeKind.Utc).AddTicks(8587), 3, new DateTime(2023, 7, 31, 22, 38, 21, 139, DateTimeKind.Utc).AddTicks(9304) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 1, 7, 58, 45, 926, DateTimeKind.Utc).AddTicks(227), new DateTime(2023, 9, 6, 21, 15, 13, 684, DateTimeKind.Utc).AddTicks(7455), new DateTime(2023, 7, 5, 0, 8, 2, 783, DateTimeKind.Utc).AddTicks(6341), 1, new DateTime(2023, 7, 12, 11, 23, 8, 785, DateTimeKind.Utc).AddTicks(1970) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 8, 6, 33, 962, DateTimeKind.Utc).AddTicks(390), new DateTime(2022, 9, 15, 12, 36, 22, 115, DateTimeKind.Utc).AddTicks(3194), new DateTime(2022, 6, 6, 8, 18, 27, 467, DateTimeKind.Utc).AddTicks(9225), 1, new DateTime(2022, 12, 9, 2, 15, 9, 217, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 26, 17, 5, 21, 578, DateTimeKind.Utc).AddTicks(1512), new DateTime(2023, 3, 10, 12, 31, 13, 735, DateTimeKind.Utc).AddTicks(702), new DateTime(2023, 2, 14, 20, 24, 20, 792, DateTimeKind.Utc).AddTicks(2027), 3, new DateTime(2023, 5, 1, 5, 15, 51, 598, DateTimeKind.Utc).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 7, 19, 12, 15, 923, DateTimeKind.Utc).AddTicks(4309), new DateTime(2022, 11, 28, 10, 40, 59, 900, DateTimeKind.Utc).AddTicks(4266), new DateTime(2017, 4, 18, 16, 19, 41, 580, DateTimeKind.Utc).AddTicks(8325), 2, new DateTime(2023, 7, 11, 13, 18, 19, 320, DateTimeKind.Utc).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 19, 9, 29, 32, 886, DateTimeKind.Utc).AddTicks(7857), new DateTime(2023, 1, 11, 19, 17, 41, 698, DateTimeKind.Utc).AddTicks(8941), new DateTime(2022, 10, 28, 17, 41, 14, 85, DateTimeKind.Utc).AddTicks(2646), 1, new DateTime(2023, 3, 11, 9, 56, 12, 667, DateTimeKind.Utc).AddTicks(1195) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 3, 31, 12, 8, 23, 797, DateTimeKind.Utc).AddTicks(3890), new DateTime(2022, 8, 19, 6, 51, 29, 924, DateTimeKind.Utc).AddTicks(9743), new DateTime(2021, 10, 8, 10, 58, 17, 544, DateTimeKind.Utc).AddTicks(6759), 1, new DateTime(2023, 3, 31, 21, 7, 8, 656, DateTimeKind.Utc).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 5, 17, 32, 28, 447, DateTimeKind.Utc).AddTicks(6848), new DateTime(2023, 3, 26, 18, 32, 20, 925, DateTimeKind.Utc).AddTicks(7263), new DateTime(2019, 11, 2, 21, 25, 36, 657, DateTimeKind.Utc).AddTicks(2787), 2, new DateTime(2020, 8, 24, 11, 45, 52, 30, DateTimeKind.Utc).AddTicks(6146) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 8, 13, 24, 41, 602, DateTimeKind.Utc).AddTicks(701), new DateTime(2023, 5, 11, 23, 1, 48, 714, DateTimeKind.Utc).AddTicks(3273), new DateTime(2022, 2, 27, 10, 0, 46, 189, DateTimeKind.Utc).AddTicks(3265), 1, new DateTime(2022, 7, 10, 11, 6, 42, 774, DateTimeKind.Utc).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 23, 23, 4, 17, 976, DateTimeKind.Utc).AddTicks(4394), new DateTime(2022, 10, 25, 4, 32, 49, 840, DateTimeKind.Utc).AddTicks(8440), new DateTime(2022, 5, 30, 3, 12, 27, 575, DateTimeKind.Utc).AddTicks(9730), 2, new DateTime(2023, 4, 8, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 6, 4, 20, 36, 38, 655, DateTimeKind.Utc).AddTicks(5003), new DateTime(2021, 8, 7, 5, 31, 9, 917, DateTimeKind.Utc).AddTicks(8495), new DateTime(2021, 6, 20, 14, 59, 45, 502, DateTimeKind.Utc).AddTicks(9151), 2, new DateTime(2022, 4, 2, 19, 6, 43, 825, DateTimeKind.Utc).AddTicks(5395) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 6, 22, 31, 25, 665, DateTimeKind.Utc).AddTicks(884), new DateTime(2023, 8, 30, 21, 24, 26, 789, DateTimeKind.Utc).AddTicks(8825), new DateTime(2019, 3, 23, 23, 50, 51, 102, DateTimeKind.Utc).AddTicks(7839), 1, new DateTime(2020, 11, 13, 6, 33, 17, 478, DateTimeKind.Utc).AddTicks(68) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 29, 20, 29, 8, 76, DateTimeKind.Utc).AddTicks(310), new DateTime(2022, 10, 21, 18, 10, 22, 491, DateTimeKind.Utc).AddTicks(507), new DateTime(2022, 6, 12, 21, 5, 17, 694, DateTimeKind.Utc).AddTicks(9530), 3, new DateTime(2022, 12, 17, 23, 42, 55, 270, DateTimeKind.Utc).AddTicks(576) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2018, 4, 4, 5, 5, 41, 206, DateTimeKind.Utc).AddTicks(3533), new DateTime(2018, 3, 18, 3, 20, 43, 684, DateTimeKind.Utc).AddTicks(2421), new DateTime(2017, 9, 18, 23, 33, 13, 248, DateTimeKind.Utc).AddTicks(97), 3, new DateTime(2019, 7, 9, 23, 18, 56, 840, DateTimeKind.Utc).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 7, 29, 2, 24, 45, 640, DateTimeKind.Utc).AddTicks(3316), new DateTime(2023, 8, 2, 13, 38, 17, 657, DateTimeKind.Utc).AddTicks(8061), new DateTime(2023, 7, 1, 9, 16, 53, 950, DateTimeKind.Utc).AddTicks(8300), 1, new DateTime(2023, 7, 7, 2, 37, 48, 350, DateTimeKind.Utc).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 3, 9, 56, 34, 627, DateTimeKind.Utc).AddTicks(8096), new DateTime(2023, 1, 19, 12, 12, 46, 390, DateTimeKind.Utc).AddTicks(4899), new DateTime(2021, 7, 3, 12, 26, 41, 276, DateTimeKind.Utc).AddTicks(5960), 2, new DateTime(2022, 10, 30, 19, 36, 35, 39, DateTimeKind.Utc).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 54, 12, 94, DateTimeKind.Utc).AddTicks(452), new DateTime(2022, 2, 22, 8, 19, 54, 334, DateTimeKind.Utc).AddTicks(2776), new DateTime(2021, 10, 28, 2, 16, 51, 961, DateTimeKind.Utc).AddTicks(1758), 1, new DateTime(2023, 2, 3, 4, 12, 0, 978, DateTimeKind.Utc).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 21, 17, 59, 29, 81, DateTimeKind.Utc).AddTicks(5935), new DateTime(2023, 4, 24, 9, 45, 21, 512, DateTimeKind.Utc).AddTicks(5164), new DateTime(2022, 10, 9, 10, 43, 12, 242, DateTimeKind.Utc).AddTicks(7189), 2, new DateTime(2023, 8, 21, 5, 59, 48, 12, DateTimeKind.Utc).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 31, 2, 57, 24, 631, DateTimeKind.Utc).AddTicks(6981), new DateTime(2023, 8, 13, 7, 45, 23, 634, DateTimeKind.Utc).AddTicks(3026), new DateTime(2022, 3, 8, 1, 8, 0, 695, DateTimeKind.Utc).AddTicks(1936), 1, new DateTime(2022, 8, 22, 2, 59, 54, 793, DateTimeKind.Utc).AddTicks(3928) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 8, 37, 33, 720, DateTimeKind.Utc).AddTicks(360), new DateTime(2023, 6, 21, 21, 27, 37, 504, DateTimeKind.Utc).AddTicks(8914), new DateTime(2021, 7, 5, 11, 22, 17, 263, DateTimeKind.Utc).AddTicks(2949), 1, new DateTime(2021, 12, 9, 1, 59, 3, 676, DateTimeKind.Utc).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 31, 8, 55, 41, 838, DateTimeKind.Utc).AddTicks(690), new DateTime(2023, 8, 13, 17, 52, 8, 665, DateTimeKind.Utc).AddTicks(3517), new DateTime(2023, 6, 30, 20, 54, 29, 300, DateTimeKind.Utc).AddTicks(4213), 3, new DateTime(2023, 9, 1, 13, 28, 42, 177, DateTimeKind.Utc).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 4, 17, 10, 44, 283, DateTimeKind.Utc).AddTicks(543), new DateTime(2023, 5, 9, 14, 38, 26, 356, DateTimeKind.Utc).AddTicks(5132), new DateTime(2023, 3, 19, 18, 11, 47, 35, DateTimeKind.Utc).AddTicks(5920), 2, new DateTime(2023, 3, 25, 8, 42, 51, 206, DateTimeKind.Utc).AddTicks(582) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 14, 58, 11, 97, DateTimeKind.Utc).AddTicks(8787), new DateTime(2022, 12, 28, 8, 15, 44, 515, DateTimeKind.Utc).AddTicks(6634), new DateTime(2022, 2, 17, 23, 59, 40, 614, DateTimeKind.Utc).AddTicks(8918), 2, new DateTime(2022, 7, 15, 2, 26, 18, 563, DateTimeKind.Utc).AddTicks(4064) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId" },
                values: new object[] { new DateTime(2023, 6, 30, 1, 0, 24, 531, DateTimeKind.Utc).AddTicks(5937), new DateTime(2023, 5, 31, 13, 51, 58, 999, DateTimeKind.Utc).AddTicks(1598), new DateTime(2022, 1, 5, 21, 21, 1, 204, DateTimeKind.Utc).AddTicks(6104), 1 });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 2, 0, 31, 300, DateTimeKind.Utc).AddTicks(2722), new DateTime(2022, 12, 26, 3, 2, 56, 307, DateTimeKind.Utc).AddTicks(4000), new DateTime(2022, 11, 7, 0, 43, 9, 378, DateTimeKind.Utc).AddTicks(587), 1, new DateTime(2023, 8, 31, 6, 40, 43, 899, DateTimeKind.Utc).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2019, 6, 1, 8, 58, 20, 295, DateTimeKind.Utc).AddTicks(5863), new DateTime(2018, 11, 22, 0, 27, 46, 875, DateTimeKind.Utc).AddTicks(2075), new DateTime(2017, 4, 11, 2, 44, 17, 153, DateTimeKind.Utc).AddTicks(1589), 3, new DateTime(2017, 12, 26, 14, 53, 13, 876, DateTimeKind.Utc).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 3, 10, 22, 2, 212, DateTimeKind.Utc).AddTicks(9741), new DateTime(2022, 9, 24, 5, 50, 17, 518, DateTimeKind.Utc).AddTicks(1009), new DateTime(2021, 10, 29, 2, 46, 35, 150, DateTimeKind.Utc).AddTicks(9646), 1, new DateTime(2022, 8, 2, 21, 55, 0, 98, DateTimeKind.Utc).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 8, 15, 3, 35, 542, DateTimeKind.Utc).AddTicks(9611), new DateTime(2023, 9, 4, 16, 23, 25, 757, DateTimeKind.Utc).AddTicks(8983), new DateTime(2023, 9, 2, 16, 56, 2, 786, DateTimeKind.Utc).AddTicks(821), 2, new DateTime(2023, 9, 4, 20, 53, 54, 271, DateTimeKind.Utc).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 10, 20, 0, 45, 17, 754, DateTimeKind.Utc).AddTicks(9005), new DateTime(2021, 11, 21, 5, 38, 1, 408, DateTimeKind.Utc).AddTicks(231), new DateTime(2018, 4, 19, 13, 39, 56, 324, DateTimeKind.Utc).AddTicks(6152), 3, new DateTime(2019, 7, 10, 14, 47, 52, 580, DateTimeKind.Utc).AddTicks(7572) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 6, 38, 32, 269, DateTimeKind.Utc).AddTicks(818), new DateTime(2023, 9, 4, 11, 47, 38, 782, DateTimeKind.Utc).AddTicks(8565), new DateTime(2023, 8, 27, 22, 37, 25, 61, DateTimeKind.Utc).AddTicks(1826), 1, new DateTime(2023, 8, 31, 18, 15, 29, 131, DateTimeKind.Utc).AddTicks(438) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 10, 59, 42, 128, DateTimeKind.Utc).AddTicks(3346), new DateTime(2023, 4, 5, 18, 58, 18, 222, DateTimeKind.Utc).AddTicks(8821), new DateTime(2016, 11, 13, 7, 8, 9, 94, DateTimeKind.Utc).AddTicks(9033), 1, new DateTime(2020, 9, 25, 7, 44, 50, 537, DateTimeKind.Utc).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 30, 18, 962, DateTimeKind.Utc).AddTicks(3104), new DateTime(2023, 4, 3, 15, 54, 12, 733, DateTimeKind.Utc).AddTicks(261), new DateTime(2022, 8, 31, 9, 5, 9, 282, DateTimeKind.Utc).AddTicks(2564), 1, new DateTime(2023, 8, 16, 8, 25, 46, 882, DateTimeKind.Utc).AddTicks(4191) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 1, 5, 19, 50, 921, DateTimeKind.Utc).AddTicks(4494), new DateTime(2023, 4, 6, 14, 13, 6, 991, DateTimeKind.Utc).AddTicks(863), new DateTime(2023, 4, 1, 11, 14, 36, 981, DateTimeKind.Utc).AddTicks(4488), 3, new DateTime(2023, 8, 2, 20, 5, 10, 969, DateTimeKind.Utc).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 2, 9, 3, 35, 29, 185, DateTimeKind.Utc).AddTicks(4300), new DateTime(2021, 1, 26, 10, 33, 13, 436, DateTimeKind.Utc).AddTicks(8586), new DateTime(2019, 6, 22, 12, 15, 19, 557, DateTimeKind.Utc).AddTicks(6508), 3, new DateTime(2022, 9, 30, 8, 28, 37, 699, DateTimeKind.Utc).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 18, 10, 13, 28, 259, DateTimeKind.Utc).AddTicks(7320), new DateTime(2023, 5, 4, 4, 34, 0, 804, DateTimeKind.Utc).AddTicks(5559), new DateTime(2022, 9, 23, 7, 49, 11, 133, DateTimeKind.Utc).AddTicks(1188), 3, new DateTime(2023, 1, 9, 21, 33, 12, 892, DateTimeKind.Utc).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId" },
                values: new object[] { new DateTime(2024, 3, 2, 3, 12, 22, 927, DateTimeKind.Utc).AddTicks(9661), new DateTime(2023, 5, 30, 19, 23, 29, 773, DateTimeKind.Utc).AddTicks(6084), new DateTime(2019, 4, 4, 17, 41, 6, 637, DateTimeKind.Utc).AddTicks(6511), 1 });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 9, 23, 4, 40, 2, 210, DateTimeKind.Utc).AddTicks(7728), new DateTime(2021, 9, 26, 21, 49, 40, 265, DateTimeKind.Utc).AddTicks(7363), new DateTime(2021, 4, 1, 11, 40, 49, 490, DateTimeKind.Utc).AddTicks(685), 1, new DateTime(2023, 5, 30, 19, 5, 17, 485, DateTimeKind.Utc).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 2, 2, 38, 47, 714, DateTimeKind.Utc).AddTicks(7939), new DateTime(2023, 7, 28, 2, 46, 36, 936, DateTimeKind.Utc).AddTicks(7511), new DateTime(2023, 7, 15, 21, 6, 45, 827, DateTimeKind.Utc).AddTicks(1488), 1, new DateTime(2023, 8, 14, 3, 12, 54, 716, DateTimeKind.Utc).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 25, 6, 5, 11, 901, DateTimeKind.Utc).AddTicks(7743), new DateTime(2023, 6, 6, 17, 6, 28, 322, DateTimeKind.Utc).AddTicks(4337), new DateTime(2023, 1, 13, 17, 0, 27, 820, DateTimeKind.Utc).AddTicks(2993), 1, new DateTime(2023, 3, 19, 13, 12, 10, 683, DateTimeKind.Utc).AddTicks(8057) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 17, 15, 28, 9, 280, DateTimeKind.Utc).AddTicks(5431), new DateTime(2023, 1, 31, 0, 49, 26, 687, DateTimeKind.Utc).AddTicks(5106), new DateTime(2022, 5, 24, 13, 55, 13, 756, DateTimeKind.Utc).AddTicks(8871), 3, new DateTime(2023, 3, 1, 6, 53, 3, 1, DateTimeKind.Utc).AddTicks(8268) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 5, 16, 2, 45, 44, 973, DateTimeKind.Utc).AddTicks(8562), new DateTime(2020, 6, 22, 17, 18, 3, 191, DateTimeKind.Utc).AddTicks(7455), new DateTime(2017, 10, 10, 23, 39, 23, 324, DateTimeKind.Utc).AddTicks(7057), 1, new DateTime(2018, 5, 30, 23, 1, 4, 614, DateTimeKind.Utc).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 30, 16, 36, 1, 216, DateTimeKind.Utc).AddTicks(8582), new DateTime(2023, 7, 19, 9, 0, 11, 198, DateTimeKind.Utc).AddTicks(3859), new DateTime(2021, 5, 16, 9, 5, 36, 56, DateTimeKind.Utc).AddTicks(3074), 3, new DateTime(2021, 10, 8, 6, 53, 25, 116, DateTimeKind.Utc).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 13, 54, 59, 668, DateTimeKind.Utc).AddTicks(9564), new DateTime(2023, 2, 22, 0, 36, 16, 417, DateTimeKind.Utc).AddTicks(2650), new DateTime(2022, 12, 13, 12, 46, 40, 182, DateTimeKind.Utc).AddTicks(5746), 1, new DateTime(2023, 2, 6, 19, 48, 44, 38, DateTimeKind.Utc).AddTicks(1983) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 3, 21, 4, 13, 748, DateTimeKind.Utc).AddTicks(8740), new DateTime(2023, 7, 28, 17, 21, 1, 883, DateTimeKind.Utc).AddTicks(6665), new DateTime(2022, 12, 27, 5, 17, 13, 146, DateTimeKind.Utc).AddTicks(9689), 1, new DateTime(2023, 8, 2, 18, 49, 48, 77, DateTimeKind.Utc).AddTicks(5488) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 8, 22, 22, 53, 58, 673, DateTimeKind.Utc).AddTicks(7480), new DateTime(2022, 5, 21, 1, 50, 25, 291, DateTimeKind.Utc).AddTicks(3658), new DateTime(2021, 7, 2, 22, 42, 11, 538, DateTimeKind.Utc).AddTicks(7113), 1, new DateTime(2022, 1, 24, 11, 4, 11, 389, DateTimeKind.Utc).AddTicks(8293) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 6, 24, 23, 58, 42, 908, DateTimeKind.Utc).AddTicks(5323), new DateTime(2023, 8, 28, 5, 30, 12, 288, DateTimeKind.Utc).AddTicks(4899), new DateTime(2023, 6, 10, 23, 46, 6, 841, DateTimeKind.Utc).AddTicks(7003), 2, new DateTime(2023, 7, 25, 3, 33, 50, 991, DateTimeKind.Utc).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 24, 10, 10, 11, 601, DateTimeKind.Utc).AddTicks(2566), new DateTime(2023, 8, 25, 22, 9, 50, 886, DateTimeKind.Utc).AddTicks(5228), new DateTime(2023, 8, 7, 3, 10, 7, 662, DateTimeKind.Utc).AddTicks(886), 1, new DateTime(2023, 8, 22, 4, 38, 32, 736, DateTimeKind.Utc).AddTicks(196) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 4, 1, 5, 31, 40, 222, DateTimeKind.Utc).AddTicks(1500), new DateTime(2020, 12, 10, 6, 35, 54, 621, DateTimeKind.Utc).AddTicks(8448), new DateTime(2019, 10, 7, 19, 54, 36, 787, DateTimeKind.Utc).AddTicks(9355), 2, new DateTime(2023, 7, 26, 15, 23, 3, 899, DateTimeKind.Utc).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 2, 2, 26, 16, 842, DateTimeKind.Utc).AddTicks(8191), new DateTime(2023, 4, 15, 20, 26, 17, 51, DateTimeKind.Utc).AddTicks(8604), new DateTime(2022, 11, 13, 3, 32, 43, 192, DateTimeKind.Utc).AddTicks(2369), 3, new DateTime(2023, 1, 16, 4, 22, 14, 922, DateTimeKind.Utc).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 1, 1, 15, 18, 32, 987, DateTimeKind.Utc).AddTicks(7319), new DateTime(2022, 8, 30, 22, 27, 53, 731, DateTimeKind.Utc).AddTicks(4603), new DateTime(2022, 8, 19, 0, 41, 14, 452, DateTimeKind.Utc).AddTicks(4792), 1, new DateTime(2023, 1, 24, 22, 10, 56, 482, DateTimeKind.Utc).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 10, 22, 22, 7, 17, 395, DateTimeKind.Utc).AddTicks(1714), new DateTime(2019, 11, 14, 2, 38, 46, 501, DateTimeKind.Utc).AddTicks(1129), new DateTime(2017, 6, 27, 14, 5, 5, 846, DateTimeKind.Utc).AddTicks(2615), 2, new DateTime(2018, 8, 7, 8, 6, 30, 107, DateTimeKind.Utc).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 7, 7, 44, 993, DateTimeKind.Utc).AddTicks(4763), new DateTime(2023, 7, 21, 18, 48, 49, 7, DateTimeKind.Utc).AddTicks(5433), new DateTime(2023, 6, 27, 4, 54, 9, 474, DateTimeKind.Utc).AddTicks(40), 1, new DateTime(2023, 7, 11, 23, 12, 22, 39, DateTimeKind.Utc).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 8, 21, 48, 190, DateTimeKind.Utc).AddTicks(4575), new DateTime(2022, 11, 22, 21, 34, 52, 473, DateTimeKind.Utc).AddTicks(6796), new DateTime(2022, 5, 9, 14, 8, 31, 357, DateTimeKind.Utc).AddTicks(3059), 1, new DateTime(2023, 1, 5, 11, 26, 23, 892, DateTimeKind.Utc).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 1, 3, 2, 51, 10, 140, DateTimeKind.Utc).AddTicks(7143), new DateTime(2020, 4, 29, 4, 45, 13, 151, DateTimeKind.Utc).AddTicks(3979), new DateTime(2019, 8, 28, 15, 27, 25, 145, DateTimeKind.Utc).AddTicks(1874), 1, new DateTime(2020, 11, 30, 1, 40, 29, 364, DateTimeKind.Utc).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 4, 1, 46, 40, 392, DateTimeKind.Utc).AddTicks(2066), new DateTime(2023, 8, 6, 16, 14, 57, 485, DateTimeKind.Utc).AddTicks(6342), new DateTime(2023, 4, 28, 6, 25, 29, 560, DateTimeKind.Utc).AddTicks(2342), 3, new DateTime(2023, 8, 23, 22, 20, 55, 562, DateTimeKind.Utc).AddTicks(7121) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 8, 0, 45, 353, DateTimeKind.Utc).AddTicks(9881), new DateTime(2022, 8, 15, 2, 1, 40, 719, DateTimeKind.Utc).AddTicks(5599), new DateTime(2022, 6, 15, 13, 9, 59, 414, DateTimeKind.Utc).AddTicks(6462), 1, new DateTime(2022, 10, 6, 11, 37, 21, 988, DateTimeKind.Utc).AddTicks(825) });

            migrationBuilder.CreateIndex(
                name: "IX_Tests_ChallengeVersionId",
                table: "Tests",
                column: "ChallengeVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_ChallengeTag_TagsId",
                table: "ChallengeTag",
                column: "TagsId");

            migrationBuilder.CreateIndex(
                name: "IX_PreferredLanguages_UsersId",
                table: "PreferredLanguages",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Challenges_ChallengeLevels_LevelId",
                table: "Challenges",
                column: "LevelId",
                principalTable: "ChallengeLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChallengeVersionLanguageVersion_LanguageVersions_LanguageVersionId",
                table: "ChallengeVersionLanguageVersion",
                column: "LanguageVersionId",
                principalTable: "LanguageVersions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChallengeVersions_Languages_LanguageId",
                table: "ChallengeVersions",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LanguageVersions_Languages_LanguageId",
                table: "LanguageVersions",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_SubscriptionTypes_TypeId",
                table: "Subscriptions",
                column: "TypeId",
                principalTable: "SubscriptionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_ChallengeVersions_ChallengeVersionId",
                table: "Tests",
                column: "ChallengeVersionId",
                principalTable: "ChallengeVersions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLanguageLevels_Languages_LanguageId",
                table: "UserLanguageLevels",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
