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
                value: new DateTime(2023, 8, 13, 3, 39, 5, 912, DateTimeKind.Utc).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 27, 3, 47, 50, 59, DateTimeKind.Utc).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 6, 20, 45, 19, 218, DateTimeKind.Utc).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 11, 6, 58, 23, 564, DateTimeKind.Utc).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 5, 8, 22, 21, 450, DateTimeKind.Utc).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 1, 16, 2, 40, 251, DateTimeKind.Utc).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 18, 1, 16, 42, 88, DateTimeKind.Utc).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 13, 15, 53, 11, 598, DateTimeKind.Utc).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 10, 7, 41, 541, DateTimeKind.Utc).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 19, 38, 40, 158, DateTimeKind.Utc).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 19, 4, 35, 7, 162, DateTimeKind.Utc).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 19, 1, 2, 50, 673, DateTimeKind.Utc).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 3, 11, 43, 16, 55, DateTimeKind.Utc).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 9, 22, 32, 19, 956, DateTimeKind.Utc).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 7, 2, 42, 14, 270, DateTimeKind.Utc).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 16, 15, 29, 59, 928, DateTimeKind.Utc).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 16, 18, 10, 10, 879, DateTimeKind.Utc).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 12, 7, 4, 24, 381, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 21, 8, 31, 18, 397, DateTimeKind.Utc).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 5, 2, 17, 51, 310, DateTimeKind.Utc).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 8, 10, 2, 16, 198, DateTimeKind.Utc).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 15, 23, 21, 482, DateTimeKind.Utc).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 7, 2, 51, 42, 735, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 26, 6, 42, 16, 462, DateTimeKind.Utc).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 21, 14, 4, 234, DateTimeKind.Utc).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 25, 9, 15, 14, 126, DateTimeKind.Utc).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 4, 0, 33, 54, 954, DateTimeKind.Utc).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 10, 24, 22, 345, DateTimeKind.Utc).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 10, 22, 4, 50, 248, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 3, 3, 32, 28, 65, DateTimeKind.Utc).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 16, 58, 813, DateTimeKind.Utc).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 28, 18, 31, 43, 96, DateTimeKind.Utc).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 8, 17, 25, 55, 987, DateTimeKind.Utc).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 9, 9, 18, 44, 379, DateTimeKind.Utc).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 5, 8, 53, 5, 314, DateTimeKind.Utc).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 11, 0, 45, 43, 725, DateTimeKind.Utc).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 18, 1, 58, 28, 232, DateTimeKind.Utc).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 15, 18, 38, 15, 289, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 12, 11, 21, 43, 515, DateTimeKind.Utc).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 19, 34, 55, 222, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 22, 42, 55, 925, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 1, 9, 56, 12, 653, DateTimeKind.Utc).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 16, 0, 32, 239, DateTimeKind.Utc).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 22, 21, 57, 32, 814, DateTimeKind.Utc).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 4, 7, 15, 32, 474, DateTimeKind.Utc).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 9, 9, 52, 7, 133, DateTimeKind.Utc).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 10, 21, 26, 342, DateTimeKind.Utc).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 48L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 19, 10, 48, 29, 166, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 25, 19, 25, 59, 286, DateTimeKind.Utc).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 7, 0, 57, 57, 997, DateTimeKind.Utc).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 6, 56, 21, 172, DateTimeKind.Utc).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 15, 12, 40, 343, DateTimeKind.Utc).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 10, 58, 8, 556, DateTimeKind.Utc).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 18, 1, 22, 24, 913, DateTimeKind.Utc).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 26, 4, 5, 57, 475, DateTimeKind.Utc).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 56L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 1, 10, 44, 43, 540, DateTimeKind.Utc).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 13, 7, 6, 285, DateTimeKind.Utc).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 30, 23, 28, 12, 735, DateTimeKind.Utc).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 1, 21, 19, 15, 853, DateTimeKind.Utc).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 5, 18, 24, 54, 730, DateTimeKind.Utc).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 8, 13, 7, 51, 270, DateTimeKind.Utc).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 9, 1, 36, 38, 234, DateTimeKind.Utc).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 5, 2, 31, 0, 576, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 64L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 18, 18, 12, 31, 436, DateTimeKind.Utc).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 3, 4, 33, 35, 875, DateTimeKind.Utc).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 27, 0, 28, 58, 936, DateTimeKind.Utc).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 1, 11, 41, 50, 153, DateTimeKind.Utc).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 11, 25, 59, 28, DateTimeKind.Utc).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 8, 0, 34, 54, 955, DateTimeKind.Utc).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 25, 14, 2, 6, 865, DateTimeKind.Utc).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 22, 2, 54, 21, 433, DateTimeKind.Utc).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 72L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 16, 23, 45, 44, 682, DateTimeKind.Utc).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 15, 5, 40, 23, 420, DateTimeKind.Utc).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 6, 56, 23, 925, DateTimeKind.Utc).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 22, 15, 23, 44, 545, DateTimeKind.Utc).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 23, 11, 47, 47, 780, DateTimeKind.Utc).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 5, 20, 53, 7, 968, DateTimeKind.Utc).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 3, 17, 6, 0, 340, DateTimeKind.Utc).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 9, 6, 5, 16, 655, DateTimeKind.Utc).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 80L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 22, 16, 27, 195, DateTimeKind.Utc).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 19, 14, 3, 11, 256, DateTimeKind.Utc).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 6, 15, 27, 23, 824, DateTimeKind.Utc).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 3, 10, 26, 580, DateTimeKind.Utc).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 14, 11, 43, 5, 13, DateTimeKind.Utc).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 9, 37, 16, 476, DateTimeKind.Utc).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 3, 49, 5, 56, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 8, 22, 31, 50, 311, DateTimeKind.Utc).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 88L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 24, 17, 36, 11, 386, DateTimeKind.Utc).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 11, 6, 26, 54, 109, DateTimeKind.Utc).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 17, 20, 21, 50, 427, DateTimeKind.Utc).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 11, 32, 57, 442, DateTimeKind.Utc).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 22, 13, 37, 17, 366, DateTimeKind.Utc).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 25, 16, 55, 28, 61, DateTimeKind.Utc).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 4, 4, 49, 16, 975, DateTimeKind.Utc).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 26, 1, 16, 16, 880, DateTimeKind.Utc).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 96L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 24, 8, 12, 59, 284, DateTimeKind.Utc).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 31, 5, 20, 16, 908, DateTimeKind.Utc).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 10, 12, 10, 58, 937, DateTimeKind.Utc).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 15, 19, 51, 127, DateTimeKind.Utc).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 12, 14, 18, 26, 589, DateTimeKind.Utc).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 7, 17, 26, 10, 675, DateTimeKind.Utc).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 14, 10, 34, 57, 199, DateTimeKind.Utc).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 2, 20, 31, 51, 760, DateTimeKind.Utc).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 104L,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 16, 17, 50, 58, 417, DateTimeKind.Utc).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 19, 15, 58, 7, 555, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedAt",
                value: new DateTime(2020, 3, 27, 1, 54, 37, 947, DateTimeKind.Utc).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 2, 9, 11, 9, 478, DateTimeKind.Utc).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 10, 13, 43, 16, 379, DateTimeKind.Utc).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 7, 57, 14, 609, DateTimeKind.Utc).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 21, 3, 20, 2, 590, DateTimeKind.Utc).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedAt",
                value: new DateTime(2020, 3, 17, 13, 3, 20, 6, DateTimeKind.Utc).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 112L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 26, 14, 10, 10, 700, DateTimeKind.Utc).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 21, 0, 19, 42, 400, DateTimeKind.Utc).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 14, 10, 18, 925, DateTimeKind.Utc).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 8, 11, 35, 59, 511, DateTimeKind.Utc).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 28, 13, 6, 13, 516, DateTimeKind.Utc).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 7, 20, 21, 11, 285, DateTimeKind.Utc).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 19, 7, 38, 17, 672, DateTimeKind.Utc).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 0, 26, 31, 988, DateTimeKind.Utc).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 120L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 24, 21, 23, 46, 424, DateTimeKind.Utc).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 19, 23, 57, 32, 258, DateTimeKind.Utc).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 3, 18, 12, 0, 958, DateTimeKind.Utc).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 19, 9, 48, 51, 776, DateTimeKind.Utc).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 5, 1, 38, 4, 551, DateTimeKind.Utc).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 27, 10, 47, 18, 369, DateTimeKind.Utc).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 29, 5, 53, 52, 563, DateTimeKind.Utc).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 2, 8, 19, 31, 414, DateTimeKind.Utc).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 128L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 18, 20, 28, 57, 96, DateTimeKind.Utc).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 22, 21, 9, 13, 529, DateTimeKind.Utc).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 12, 8, 30, 48, 651, DateTimeKind.Utc).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 8, 11, 18, 10, 640, DateTimeKind.Utc).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 14, 20, 12, 613, DateTimeKind.Utc).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 2, 17, 54, 51, 414, DateTimeKind.Utc).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 2, 12, 7, 47, 457, DateTimeKind.Utc).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 5, 5, 47, 1, 233, DateTimeKind.Utc).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 136L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 10, 5, 14, 0, 429, DateTimeKind.Utc).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 25, 6, 24, 15, 655, DateTimeKind.Utc).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 11, 1, 32, 26, 788, DateTimeKind.Utc).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 9, 5, 59, 19, 705, DateTimeKind.Utc).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 10, 18, 30, 47, 638, DateTimeKind.Utc).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 10, 20, 41, 27, 285, DateTimeKind.Utc).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 23, 11, 53, 11, 493, DateTimeKind.Utc).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 18, 3, 34, 14, 827, DateTimeKind.Utc).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 144L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 18, 44, 42, 752, DateTimeKind.Utc).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 1, 3, 58, 9, 171, DateTimeKind.Utc).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 15, 18, 5, 59, 881, DateTimeKind.Utc).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 18, 1, 19, 6, 657, DateTimeKind.Utc).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 16, 55, 1, 11, DateTimeKind.Utc).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 14, 21, 6, 217, DateTimeKind.Utc).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 12, 3, 20, 33, 744, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 15, 44, 44, 803, DateTimeKind.Utc).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 152L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 20, 19, 18, 387, DateTimeKind.Utc).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 31, 11, 7, 48, 484, DateTimeKind.Utc).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 24, 19, 9, 19, 868, DateTimeKind.Utc).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 27, 22, 30, 13, 740, DateTimeKind.Utc).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 11, 6, 56, 58, 654, DateTimeKind.Utc).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 30, 20, 5, 56, 909, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 30, 6, 10, 58, 41, DateTimeKind.Utc).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 21, 38, 44, 929, DateTimeKind.Utc).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 160L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 19, 15, 38, 519, DateTimeKind.Utc).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 5, 14, 36, 28, 748, DateTimeKind.Utc).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedAt",
                value: new DateTime(2021, 12, 19, 18, 11, 47, 495, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedAt",
                value: new DateTime(2022, 1, 9, 21, 22, 33, 110, DateTimeKind.Utc).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 25, 57, 719, DateTimeKind.Utc).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 5, 8, 53, 35, 752, DateTimeKind.Utc).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 26, 15, 28, 10, 113, DateTimeKind.Utc).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 23, 19, 20, 52, 669, DateTimeKind.Utc).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 168L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 7, 15, 44, 36, 345, DateTimeKind.Utc).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 23, 17, 32, 29, DateTimeKind.Utc).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 17, 19, 21, 4, 408, DateTimeKind.Utc).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 11, 54, 49, 530, DateTimeKind.Utc).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 27, 12, 19, 37, 207, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 29, 2, 33, 24, 311, DateTimeKind.Utc).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 4, 6, 20, 32, 742, DateTimeKind.Utc).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 11, 42, 22, 440, DateTimeKind.Utc).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 176L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 7, 0, 39, 804, DateTimeKind.Utc).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 26, 16, 39, 57, 105, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 23, 7, 6, 55, 209, DateTimeKind.Utc).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 29, 4, 12, 0, 778, DateTimeKind.Utc).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 11, 9, 10, 1, 904, DateTimeKind.Utc).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 18, 10, 28, 551, DateTimeKind.Utc).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 26, 14, 12, 37, 10, DateTimeKind.Utc).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 17, 0, 34, 0, 638, DateTimeKind.Utc).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 184L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 11, 18, 24, 1, 110, DateTimeKind.Utc).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 22, 10, 7, 24, 201, DateTimeKind.Utc).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 15, 9, 13, 971, DateTimeKind.Utc).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 17, 49, 43, 9, DateTimeKind.Utc).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 20, 0, 51, 43, 306, DateTimeKind.Utc).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 1, 13, 53, 16, 376, DateTimeKind.Utc).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 5, 2, 21, 56, 255, DateTimeKind.Utc).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 26, 21, 31, 23, 121, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 192L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 8, 16, 48, 13, 317, DateTimeKind.Utc).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 1, 14, 35, 420, DateTimeKind.Utc).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 19, 6, 53, 20, 819, DateTimeKind.Utc).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 19, 0, 30, 16, 606, DateTimeKind.Utc).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 4, 5, 9, 38, 900, DateTimeKind.Utc).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 25, 20, 28, 11, 162, DateTimeKind.Utc).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 10, 10, 20, 3, 210, DateTimeKind.Utc).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 30, 9, 25, 42, 824, DateTimeKind.Utc).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 200L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 23, 30, 15, 933, DateTimeKind.Utc).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 13, 8, 50, 6, 841, DateTimeKind.Utc).AddTicks(9490), new DateTime(2023, 9, 10, 16, 17, 34, 2, DateTimeKind.Utc).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 27, 19, 22, 38, 877, DateTimeKind.Utc).AddTicks(120), new DateTime(2023, 7, 30, 5, 39, 37, 603, DateTimeKind.Utc).AddTicks(5004) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 27, 19, 55, 13, 334, DateTimeKind.Utc).AddTicks(1067), new DateTime(2023, 9, 11, 22, 18, 18, 623, DateTimeKind.Utc).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 10, 18, 23, 27, 11, 124, DateTimeKind.Utc).AddTicks(8387), new DateTime(2021, 6, 18, 14, 54, 55, 326, DateTimeKind.Utc).AddTicks(6411) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 13, 5, 22, 791, DateTimeKind.Utc).AddTicks(2876), new DateTime(2023, 9, 6, 16, 45, 20, 227, DateTimeKind.Utc).AddTicks(2847) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 20, 7, 52, 45, 458, DateTimeKind.Utc).AddTicks(3071), new DateTime(2023, 1, 24, 14, 17, 7, 105, DateTimeKind.Utc).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 26, 16, 13, 15, 732, DateTimeKind.Utc).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 10, 15, 4, 53, 582, DateTimeKind.Utc).AddTicks(3232), new DateTime(2023, 9, 12, 4, 26, 55, 248, DateTimeKind.Utc).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 14, 20, 45, 52, 737, DateTimeKind.Utc).AddTicks(5372), new DateTime(2023, 7, 23, 6, 1, 13, 265, DateTimeKind.Utc).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 14, 8, 38, 41, 180, DateTimeKind.Utc).AddTicks(8342), new DateTime(2023, 7, 9, 2, 5, 25, 116, DateTimeKind.Utc).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 9, 6, 29, 16, DateTimeKind.Utc).AddTicks(5264), new DateTime(2023, 6, 7, 10, 20, 5, 905, DateTimeKind.Utc).AddTicks(5447) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 6, 4, 46, 59, 611, DateTimeKind.Utc).AddTicks(9924), new DateTime(2023, 9, 9, 10, 59, 42, 555, DateTimeKind.Utc).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 5, 6, 3, 56, 21, 132, DateTimeKind.Utc).AddTicks(9981), new DateTime(2023, 7, 3, 2, 34, 43, 944, DateTimeKind.Utc).AddTicks(6131) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 7, 14, 27, 20, 912, DateTimeKind.Utc).AddTicks(6719), new DateTime(2023, 9, 1, 0, 32, 39, 373, DateTimeKind.Utc).AddTicks(6004) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 9, 11, 37, 36, 380, DateTimeKind.Utc).AddTicks(2145), new DateTime(2023, 4, 23, 18, 39, 21, 722, DateTimeKind.Utc).AddTicks(3978) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 17, 0, 34, 54, 597, DateTimeKind.Utc).AddTicks(1653), new DateTime(2023, 8, 19, 1, 52, 3, 954, DateTimeKind.Utc).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 29, 39, 256, DateTimeKind.Utc).AddTicks(1358), new DateTime(2023, 5, 21, 7, 18, 13, 580, DateTimeKind.Utc).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 3, 15, 21, 17, 43, 734, DateTimeKind.Utc).AddTicks(6730), new DateTime(2022, 7, 11, 23, 38, 47, 121, DateTimeKind.Utc).AddTicks(1393) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 10, 2, 28, 41, 971, DateTimeKind.Utc).AddTicks(8286), new DateTime(2023, 9, 3, 19, 43, 38, 896, DateTimeKind.Utc).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 8, 23, 8, 46, 729, DateTimeKind.Utc).AddTicks(7925), new DateTime(2023, 9, 4, 14, 50, 40, 371, DateTimeKind.Utc).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 31, 15, 59, 57, 540, DateTimeKind.Utc).AddTicks(6496), new DateTime(2023, 9, 1, 23, 28, 49, 437, DateTimeKind.Utc).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 31, 50, 119, DateTimeKind.Utc).AddTicks(5077), new DateTime(2023, 8, 30, 15, 49, 44, 314, DateTimeKind.Utc).AddTicks(382) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 14, 12, 40, 49, 169, DateTimeKind.Utc).AddTicks(1520), new DateTime(2023, 7, 30, 9, 4, 50, 125, DateTimeKind.Utc).AddTicks(4466) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 9, 20, 47, 38, 112, DateTimeKind.Utc).AddTicks(234), new DateTime(2023, 9, 12, 13, 41, 20, 983, DateTimeKind.Utc).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 41, 21, 124, DateTimeKind.Utc).AddTicks(2709), new DateTime(2023, 5, 23, 5, 59, 31, 32, DateTimeKind.Utc).AddTicks(99) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 12, 13, 41, 29, 826, DateTimeKind.Utc).AddTicks(2389), new DateTime(2023, 8, 18, 22, 13, 33, 496, DateTimeKind.Utc).AddTicks(999) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 31, 9, 50, 30, 352, DateTimeKind.Utc).AddTicks(8010), new DateTime(2023, 9, 1, 6, 32, 51, 445, DateTimeKind.Utc).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 1, 4, 32, 51, 42, DateTimeKind.Utc).AddTicks(3221), new DateTime(2023, 7, 2, 11, 54, 57, 98, DateTimeKind.Utc).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 11, 4, 36, 27, 567, DateTimeKind.Utc).AddTicks(1770), new DateTime(2023, 8, 19, 9, 41, 59, 220, DateTimeKind.Utc).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 8, 9, 10, 25, 306, DateTimeKind.Utc).AddTicks(8546), new DateTime(2023, 9, 9, 7, 51, 25, 15, DateTimeKind.Utc).AddTicks(4578) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 10, 25, 23, 22, 23, 967, DateTimeKind.Utc).AddTicks(414), new DateTime(2021, 6, 4, 18, 24, 41, 909, DateTimeKind.Utc).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 4, 19, 9, 21, 14, 548, DateTimeKind.Utc).AddTicks(6099), new DateTime(2021, 6, 2, 13, 36, 55, 462, DateTimeKind.Utc).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 14, 10, 52, 49, 657, DateTimeKind.Utc).AddTicks(138), new DateTime(2023, 8, 27, 1, 1, 50, 131, DateTimeKind.Utc).AddTicks(852) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 7, 16, 1, 3, 36, 654, DateTimeKind.Utc).AddTicks(5472), new DateTime(2023, 4, 16, 17, 10, 50, 353, DateTimeKind.Utc).AddTicks(4629) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 29, 19, 11, 27, 618, DateTimeKind.Utc).AddTicks(8640), new DateTime(2023, 8, 16, 3, 33, 47, 975, DateTimeKind.Utc).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 7, 12, 34, 36, 371, DateTimeKind.Utc).AddTicks(5095), new DateTime(2023, 9, 10, 17, 18, 41, 192, DateTimeKind.Utc).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 20, 15, 53, 26, 321, DateTimeKind.Utc).AddTicks(8782), new DateTime(2023, 6, 24, 20, 49, 24, 21, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 22, 8, 4, 7, 687, DateTimeKind.Utc).AddTicks(7191), new DateTime(2023, 8, 15, 0, 19, 39, 838, DateTimeKind.Utc).AddTicks(5547) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 36, 5, 552, DateTimeKind.Utc).AddTicks(8644), new DateTime(2022, 1, 6, 13, 32, 18, 152, DateTimeKind.Utc).AddTicks(6954) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 18, 11, 55, 8, 501, DateTimeKind.Utc).AddTicks(8740), new DateTime(2023, 7, 29, 11, 57, 55, 833, DateTimeKind.Utc).AddTicks(114) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 6, 1, 28, 32, 351, DateTimeKind.Utc).AddTicks(2365), new DateTime(2023, 5, 1, 5, 17, 38, 613, DateTimeKind.Utc).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 13, 6, 54, 56, 823, DateTimeKind.Utc).AddTicks(8133), new DateTime(2023, 5, 9, 15, 18, 2, 319, DateTimeKind.Utc).AddTicks(8029) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 30, 15, 10, 31, 833, DateTimeKind.Utc).AddTicks(5600), new DateTime(2023, 9, 11, 4, 19, 5, 425, DateTimeKind.Utc).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 27, 14, 21, 19, 184, DateTimeKind.Utc).AddTicks(9681), new DateTime(2023, 7, 30, 5, 15, 25, 580, DateTimeKind.Utc).AddTicks(1128) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 16, 33, 21, 129, DateTimeKind.Utc).AddTicks(5278), new DateTime(2023, 7, 24, 6, 50, 44, 861, DateTimeKind.Utc).AddTicks(5004) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 7, 23, 11, 20, 901, DateTimeKind.Utc).AddTicks(5949), new DateTime(2023, 8, 26, 18, 43, 25, 881, DateTimeKind.Utc).AddTicks(8413) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 9, 7, 15, 27, 8, 595, DateTimeKind.Utc).AddTicks(4120), new DateTime(2022, 8, 26, 0, 30, 0, 129, DateTimeKind.Utc).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 8, 27, 0, 376, DateTimeKind.Utc).AddTicks(2529), new DateTime(2023, 9, 10, 12, 19, 29, 480, DateTimeKind.Utc).AddTicks(175) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 14, 3, 7, 30, 8, DateTimeKind.Utc).AddTicks(7373), new DateTime(2023, 7, 31, 4, 43, 14, 34, DateTimeKind.Utc).AddTicks(9675) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 15, 15, 15, 40, 198, DateTimeKind.Utc).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 3, 5, 13, 39, 320, DateTimeKind.Utc).AddTicks(1166), new DateTime(2023, 7, 25, 9, 22, 30, 792, DateTimeKind.Utc).AddTicks(8006) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 12, 17, 39, 21, 963, DateTimeKind.Utc).AddTicks(239), new DateTime(2023, 9, 9, 6, 28, 1, 547, DateTimeKind.Utc).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 8, 21, 4, 11, 54, 317, DateTimeKind.Utc).AddTicks(507), new DateTime(2023, 3, 24, 15, 12, 42, 145, DateTimeKind.Utc).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 23, 8, 1, 58, 594, DateTimeKind.Utc).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 30, 17, 19, 14, 850, DateTimeKind.Utc).AddTicks(3459), new DateTime(2023, 8, 4, 9, 39, 41, 114, DateTimeKind.Utc).AddTicks(2802) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 11, 0, 27, 55, 801, DateTimeKind.Utc).AddTicks(7802), new DateTime(2023, 5, 29, 17, 8, 8, 452, DateTimeKind.Utc).AddTicks(4083) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 22, 11, 42, 51, 352, DateTimeKind.Utc).AddTicks(4033), new DateTime(2023, 7, 24, 8, 19, 20, 390, DateTimeKind.Utc).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 11, 4, 4, 41, 456, DateTimeKind.Utc).AddTicks(4323), new DateTime(2023, 9, 11, 16, 6, 7, 987, DateTimeKind.Utc).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 15, 50, 13, 614, DateTimeKind.Utc).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 14, 35, 4, 658, DateTimeKind.Utc).AddTicks(1515), new DateTime(2023, 8, 12, 5, 35, 9, 986, DateTimeKind.Utc).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 11, 0, 55, 22, 162, DateTimeKind.Utc).AddTicks(8803), new DateTime(2023, 7, 18, 12, 4, 18, 464, DateTimeKind.Utc).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 23, 14, 2, 47, 478, DateTimeKind.Utc).AddTicks(7174), new DateTime(2023, 9, 4, 6, 42, 58, 859, DateTimeKind.Utc).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 5, 10, 32, 28, 587, DateTimeKind.Utc).AddTicks(1884), new DateTime(2023, 8, 9, 5, 15, 11, 11, DateTimeKind.Utc).AddTicks(4167) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 13, 42, 7, 338, DateTimeKind.Utc).AddTicks(4586), new DateTime(2023, 8, 2, 19, 29, 13, 774, DateTimeKind.Utc).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 6, 8, 17, 5, 51, 362, DateTimeKind.Utc).AddTicks(5898), new DateTime(2021, 8, 14, 2, 59, 40, 110, DateTimeKind.Utc).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 27, 9, 16, 38, 391, DateTimeKind.Utc).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 13, 2, 23, 32, 190, DateTimeKind.Utc).AddTicks(1797), new DateTime(2023, 8, 23, 13, 46, 33, 929, DateTimeKind.Utc).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 1, 22, 42, 48, 136, DateTimeKind.Utc).AddTicks(3794), new DateTime(2023, 8, 7, 7, 44, 15, 24, DateTimeKind.Utc).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 30, 16, 36, 45, 243, DateTimeKind.Utc).AddTicks(9322), new DateTime(2023, 8, 22, 9, 39, 39, 805, DateTimeKind.Utc).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 18, 4, 44, 27, 738, DateTimeKind.Utc).AddTicks(8843), new DateTime(2023, 1, 15, 1, 58, 53, 412, DateTimeKind.Utc).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 23, 21, 11, 25, 778, DateTimeKind.Utc).AddTicks(8599), new DateTime(2023, 8, 31, 21, 8, 24, 122, DateTimeKind.Utc).AddTicks(3725) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 17, 7, 35, 2, 212, DateTimeKind.Utc).AddTicks(6938), new DateTime(2023, 1, 8, 1, 9, 46, 150, DateTimeKind.Utc).AddTicks(4027) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 10, 27, 3, 24, 20, 613, DateTimeKind.Utc).AddTicks(3870), new DateTime(2022, 12, 8, 21, 20, 47, 64, DateTimeKind.Utc).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 20, 20, 21, 3, 599, DateTimeKind.Utc).AddTicks(8258), new DateTime(2023, 9, 2, 13, 27, 3, 484, DateTimeKind.Utc).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 23, 15, 0, 33, 967, DateTimeKind.Utc).AddTicks(7776), new DateTime(2023, 7, 12, 14, 6, 19, 601, DateTimeKind.Utc).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 7, 22, 42, 31, 221, DateTimeKind.Utc).AddTicks(7844), new DateTime(2023, 7, 1, 19, 54, 26, 303, DateTimeKind.Utc).AddTicks(2084) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 2, 45, 57, 390, DateTimeKind.Utc).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 4, 8, 48, 40, 841, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 5, 17, 41, 13, 377, DateTimeKind.Utc).AddTicks(9741), new DateTime(2023, 9, 8, 8, 14, 5, 997, DateTimeKind.Utc).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 20, 17, 7, 32, 879, DateTimeKind.Utc).AddTicks(4075), new DateTime(2023, 8, 26, 0, 58, 7, 640, DateTimeKind.Utc).AddTicks(1340) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 5, 8, 32, 28, 328, DateTimeKind.Utc).AddTicks(2555), new DateTime(2023, 6, 28, 15, 10, 15, 491, DateTimeKind.Utc).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 9, 8, 42, 22, 558, DateTimeKind.Utc).AddTicks(9394), new DateTime(2023, 9, 9, 13, 30, 44, 633, DateTimeKind.Utc).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 25, 16, 54, 15, 229, DateTimeKind.Utc).AddTicks(2798), new DateTime(2023, 6, 22, 13, 15, 42, 19, DateTimeKind.Utc).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 26, 8, 37, 32, 150, DateTimeKind.Utc).AddTicks(1666), new DateTime(2023, 7, 31, 23, 51, 59, 460, DateTimeKind.Utc).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 8, 20, 23, 35, 742, DateTimeKind.Utc).AddTicks(470), new DateTime(2023, 9, 12, 5, 13, 13, 299, DateTimeKind.Utc).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 3, 0, 11, 31, 735, DateTimeKind.Utc).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 29, 4, 9, 0, 248, DateTimeKind.Utc).AddTicks(9022), new DateTime(2023, 8, 11, 9, 3, 52, 511, DateTimeKind.Utc).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 7, 17, 13, 23, 507, DateTimeKind.Utc).AddTicks(6830), new DateTime(2023, 9, 9, 13, 0, 1, 735, DateTimeKind.Utc).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 20, 15, 2, 33, 488, DateTimeKind.Utc).AddTicks(3461), new DateTime(2023, 8, 18, 0, 24, 30, 354, DateTimeKind.Utc).AddTicks(3858) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 30, 9, 37, 42, 495, DateTimeKind.Utc).AddTicks(7803), new DateTime(2023, 9, 7, 11, 51, 37, 201, DateTimeKind.Utc).AddTicks(2442) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 40, 36, 722, DateTimeKind.Utc).AddTicks(8530), new DateTime(2023, 6, 19, 3, 29, 4, 644, DateTimeKind.Utc).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 20, 3, 15, 23, 460, DateTimeKind.Utc).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 9, 17, 25, 36, 749, DateTimeKind.Utc).AddTicks(8067), new DateTime(2023, 9, 10, 11, 18, 43, 263, DateTimeKind.Utc).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 32, 9, 4, DateTimeKind.Utc).AddTicks(5737), new DateTime(2023, 8, 23, 1, 56, 21, 216, DateTimeKind.Utc).AddTicks(886) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 3, 5, 2, 5, 436, DateTimeKind.Utc).AddTicks(2813), new DateTime(2023, 8, 20, 3, 14, 22, 363, DateTimeKind.Utc).AddTicks(5589) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 8, 23, 1, 15, 13, 518, DateTimeKind.Utc).AddTicks(6232), new DateTime(2023, 5, 13, 0, 45, 29, 475, DateTimeKind.Utc).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 20, 25, 4, 273, DateTimeKind.Utc).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 18, 23, 37, 12, 576, DateTimeKind.Utc).AddTicks(8688), new DateTime(2023, 8, 19, 9, 53, 26, 789, DateTimeKind.Utc).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 11, 11, 56, 39, 117, DateTimeKind.Utc).AddTicks(2303), new DateTime(2023, 5, 10, 19, 42, 33, 774, DateTimeKind.Utc).AddTicks(2155) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 28, 13, 54, 35, 832, DateTimeKind.Utc).AddTicks(5310), new DateTime(2023, 8, 23, 10, 54, 43, 130, DateTimeKind.Utc).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 7, 18, 23, 5, 206, DateTimeKind.Utc).AddTicks(1066), new DateTime(2023, 9, 10, 8, 19, 11, 239, DateTimeKind.Utc).AddTicks(6053) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 7, 14, 20, 43, 58, 46, DateTimeKind.Utc).AddTicks(1358), new DateTime(2022, 5, 14, 8, 20, 48, 203, DateTimeKind.Utc).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 18, 49, 812, DateTimeKind.Utc).AddTicks(2893), new DateTime(2023, 9, 7, 19, 25, 56, 292, DateTimeKind.Utc).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 3, 6, 0, 49, 764, DateTimeKind.Utc).AddTicks(5413), new DateTime(2023, 8, 24, 17, 53, 35, 85, DateTimeKind.Utc).AddTicks(3758) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 22, 21, 55, 41, 505, DateTimeKind.Utc).AddTicks(8680), new DateTime(2023, 9, 12, 8, 36, 13, 597, DateTimeKind.Utc).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 23, 2, 0, 51, 707, DateTimeKind.Utc).AddTicks(129), new DateTime(2023, 6, 13, 7, 37, 0, 819, DateTimeKind.Utc).AddTicks(9285) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 2, 23, 39, 30, 887, DateTimeKind.Utc).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 10, 21, 43, 20, 455, DateTimeKind.Utc).AddTicks(9140), new DateTime(2023, 9, 11, 23, 23, 57, 775, DateTimeKind.Utc).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 23, 11, 14, 53, 879, DateTimeKind.Utc).AddTicks(5805), new DateTime(2023, 7, 21, 14, 24, 55, 181, DateTimeKind.Utc).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 3, 21, 23, 40, 824, DateTimeKind.Utc).AddTicks(1578), new DateTime(2023, 8, 23, 13, 39, 49, 756, DateTimeKind.Utc).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 18, 36, 39, 713, DateTimeKind.Utc).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 6, 10, 42, 49, 185, DateTimeKind.Utc).AddTicks(4723), new DateTime(2023, 7, 13, 4, 52, 47, 46, DateTimeKind.Utc).AddTicks(4023) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 18, 15, 26, 45, 482, DateTimeKind.Utc).AddTicks(7687), new DateTime(2023, 8, 20, 21, 49, 53, 446, DateTimeKind.Utc).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 3, 7, 1, 15, 90, DateTimeKind.Utc).AddTicks(8979), new DateTime(2023, 9, 6, 8, 36, 43, 145, DateTimeKind.Utc).AddTicks(4443) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 10, 22, 17, 1, 38, 411, DateTimeKind.Utc).AddTicks(2679), new DateTime(2023, 4, 24, 19, 1, 53, 838, DateTimeKind.Utc).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 10, 1, 16, 35, 340, DateTimeKind.Utc).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 10, 8, 8, 2, 52, 933, DateTimeKind.Utc).AddTicks(488), new DateTime(2023, 1, 1, 11, 40, 40, 624, DateTimeKind.Utc).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 8, 2, 4, 24, 223, DateTimeKind.Utc).AddTicks(4683), new DateTime(2023, 9, 8, 15, 26, 52, 53, DateTimeKind.Utc).AddTicks(7403) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 2, 11, 54, 14, 579, DateTimeKind.Utc).AddTicks(3684), new DateTime(2023, 9, 10, 20, 35, 35, 70, DateTimeKind.Utc).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 23, 23, 35, 23, 285, DateTimeKind.Utc).AddTicks(2782), new DateTime(2023, 8, 29, 1, 17, 1, 247, DateTimeKind.Utc).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 24, 10, 8, 5, 891, DateTimeKind.Utc).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 23, 7, 32, 40, 267, DateTimeKind.Utc).AddTicks(3773), new DateTime(2023, 9, 6, 3, 20, 21, 234, DateTimeKind.Utc).AddTicks(1146) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 12, 4, 39, 375, DateTimeKind.Utc).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 25, 10, 46, 26, 93, DateTimeKind.Utc).AddTicks(9955), new DateTime(2023, 4, 27, 16, 56, 1, 352, DateTimeKind.Utc).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 20, 22, 17, 29, 21, DateTimeKind.Utc).AddTicks(4853), new DateTime(2023, 7, 14, 20, 20, 59, 725, DateTimeKind.Utc).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 2, 14, 45, 29, 653, DateTimeKind.Utc).AddTicks(7491), new DateTime(2023, 5, 21, 19, 41, 7, 648, DateTimeKind.Utc).AddTicks(1359) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 11, 13, 34, 25, 396, DateTimeKind.Utc).AddTicks(9569), new DateTime(2023, 9, 4, 21, 51, 11, 811, DateTimeKind.Utc).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 6, 12, 35, 35, 433, DateTimeKind.Utc).AddTicks(1358), new DateTime(2023, 8, 15, 20, 36, 51, 764, DateTimeKind.Utc).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 9, 19, 47, 12, 862, DateTimeKind.Utc).AddTicks(3793), new DateTime(2023, 6, 12, 18, 49, 59, 139, DateTimeKind.Utc).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 8, 16, 32, 11, 145, DateTimeKind.Utc).AddTicks(5898), new DateTime(2023, 7, 9, 11, 28, 15, 813, DateTimeKind.Utc).AddTicks(5492) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 17, 1, 30, 47, 35, DateTimeKind.Utc).AddTicks(2981), new DateTime(2023, 8, 24, 5, 18, 54, 161, DateTimeKind.Utc).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 8, 25, 50, 154, DateTimeKind.Utc).AddTicks(2819), new DateTime(2022, 12, 4, 1, 10, 41, 601, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 31, 1, 14, 5, 767, DateTimeKind.Utc).AddTicks(3462), new DateTime(2023, 9, 10, 16, 5, 51, 557, DateTimeKind.Utc).AddTicks(5735) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 5, 22, 55, DateTimeKind.Utc).AddTicks(3592), new DateTime(2023, 8, 6, 17, 25, 14, 886, DateTimeKind.Utc).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 1, 17, 11, 41, 2, 679, DateTimeKind.Utc).AddTicks(6555), new DateTime(2022, 10, 19, 0, 39, 39, 428, DateTimeKind.Utc).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 58, 55, 664, DateTimeKind.Utc).AddTicks(9915), new DateTime(2023, 6, 10, 17, 1, 58, 544, DateTimeKind.Utc).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 56, 26, 262, DateTimeKind.Utc).AddTicks(2709), new DateTime(2023, 9, 9, 8, 46, 33, 402, DateTimeKind.Utc).AddTicks(1949) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 11, 16, 41, 55, 727, DateTimeKind.Utc).AddTicks(7447), new DateTime(2023, 9, 11, 22, 36, 6, 347, DateTimeKind.Utc).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 8, 4, 55, 39, 681, DateTimeKind.Utc).AddTicks(1635), new DateTime(2023, 8, 21, 10, 53, 26, 187, DateTimeKind.Utc).AddTicks(4889) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 30, 0, 47, 32, 560, DateTimeKind.Utc).AddTicks(2972), new DateTime(2023, 7, 15, 22, 50, 44, 964, DateTimeKind.Utc).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 7, 1, 8, 704, DateTimeKind.Utc).AddTicks(1848), new DateTime(2023, 8, 2, 3, 59, 59, 345, DateTimeKind.Utc).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 8, 10, 13, 51, 914, DateTimeKind.Utc).AddTicks(3757), new DateTime(2023, 9, 1, 21, 14, 52, 141, DateTimeKind.Utc).AddTicks(3767) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 9, 6, 12, 21, 732, DateTimeKind.Utc).AddTicks(1739), new DateTime(2023, 8, 17, 14, 38, 25, 582, DateTimeKind.Utc).AddTicks(6121) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 17, 10, 21, 29, 170, DateTimeKind.Utc).AddTicks(7553), new DateTime(2023, 8, 3, 5, 32, 51, 915, DateTimeKind.Utc).AddTicks(5983) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 7, 10, 57, 43, 148, DateTimeKind.Utc).AddTicks(3502), new DateTime(2023, 8, 24, 23, 27, 25, 765, DateTimeKind.Utc).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 6, 8, 21, 9, 51, 827, DateTimeKind.Utc).AddTicks(9222), new DateTime(2023, 5, 25, 12, 42, 45, 660, DateTimeKind.Utc).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 12, 3, 22, 16, 37, 927, DateTimeKind.Utc).AddTicks(4184), new DateTime(2022, 7, 5, 0, 28, 52, 992, DateTimeKind.Utc).AddTicks(3768) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 30, 9, 9, 20, 157, DateTimeKind.Utc).AddTicks(179), new DateTime(2023, 9, 3, 22, 51, 42, 231, DateTimeKind.Utc).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 3, 4, 5, 0, 905, DateTimeKind.Utc).AddTicks(157), new DateTime(2023, 9, 6, 3, 15, 57, 138, DateTimeKind.Utc).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 3, 7, 20, 32, 6, 502, DateTimeKind.Utc).AddTicks(2798), new DateTime(2023, 4, 28, 4, 56, 44, 243, DateTimeKind.Utc).AddTicks(8182) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 23, 17, 18, 37, 972, DateTimeKind.Utc).AddTicks(6191), new DateTime(2023, 8, 3, 9, 56, 24, 840, DateTimeKind.Utc).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 8, 23, 34, 12, 537, DateTimeKind.Utc).AddTicks(6532), new DateTime(2023, 9, 9, 7, 51, 17, 457, DateTimeKind.Utc).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 6, 3, 34, 20, 547, DateTimeKind.Utc).AddTicks(4082), new DateTime(2023, 9, 7, 5, 37, 5, 945, DateTimeKind.Utc).AddTicks(1179) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 5, 19, 40, 16, 725, DateTimeKind.Utc).AddTicks(3334), new DateTime(2022, 11, 6, 17, 53, 32, 70, DateTimeKind.Utc).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 5, 7, 15, 639, DateTimeKind.Utc).AddTicks(401), new DateTime(2023, 6, 18, 15, 2, 1, 971, DateTimeKind.Utc).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 4, 4, 5, 58, 25, 342, DateTimeKind.Utc).AddTicks(5102), new DateTime(2022, 10, 24, 2, 24, 6, 65, DateTimeKind.Utc).AddTicks(288) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2019, 9, 21, 23, 3, 37, 169, DateTimeKind.Utc).AddTicks(3719), new DateTime(2021, 7, 9, 15, 8, 16, 661, DateTimeKind.Utc).AddTicks(3683) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 10, 17, 3, 29, 21, 419, DateTimeKind.Utc).AddTicks(7256), new DateTime(2022, 12, 29, 13, 48, 27, 125, DateTimeKind.Utc).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 6, 11, 45, 123, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 14, 17, 17, 1, 804, DateTimeKind.Utc).AddTicks(5979), new DateTime(2023, 6, 28, 10, 42, 30, 316, DateTimeKind.Utc).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 5, 18, 9, 19, 17, 913, DateTimeKind.Utc).AddTicks(9507), new DateTime(2023, 2, 9, 17, 26, 3, 764, DateTimeKind.Utc).AddTicks(4003) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 162L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 11, 27, 22, 28, 56, 702, DateTimeKind.Utc).AddTicks(8078), new DateTime(2022, 10, 21, 6, 48, 21, 769, DateTimeKind.Utc).AddTicks(2985) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 163L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 28, 16, 4, 51, 431, DateTimeKind.Utc).AddTicks(939), new DateTime(2023, 7, 9, 1, 50, 53, 83, DateTimeKind.Utc).AddTicks(8387) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 164L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 8, 12, 30, 41, 718, DateTimeKind.Utc).AddTicks(9114), new DateTime(2023, 9, 11, 6, 32, 35, 214, DateTimeKind.Utc).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 165L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 4, 23, 15, 37, 4, 852, DateTimeKind.Utc).AddTicks(1094), new DateTime(2020, 11, 18, 11, 41, 56, 408, DateTimeKind.Utc).AddTicks(1589) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 2, 8, 41, 4, 796, DateTimeKind.Utc).AddTicks(6840), new DateTime(2023, 9, 9, 17, 12, 28, 514, DateTimeKind.Utc).AddTicks(3402) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 4, 12, 14, 36, 17, 166, DateTimeKind.Utc).AddTicks(1774), new DateTime(2022, 10, 9, 9, 6, 16, 500, DateTimeKind.Utc).AddTicks(4416) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 8, 3, 19, 32, 23, 934, DateTimeKind.Utc).AddTicks(7912), new DateTime(2023, 4, 6, 11, 52, 18, 223, DateTimeKind.Utc).AddTicks(1173) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 10, 17, 48, 24, 6, DateTimeKind.Utc).AddTicks(3657), new DateTime(2023, 9, 9, 13, 11, 30, 302, DateTimeKind.Utc).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 7, 57, 8, 555, DateTimeKind.Utc).AddTicks(1301), new DateTime(2023, 5, 1, 1, 9, 23, 838, DateTimeKind.Utc).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 11, 19, 43, 21, 836, DateTimeKind.Utc).AddTicks(1510), new DateTime(2023, 8, 10, 11, 40, 48, 186, DateTimeKind.Utc).AddTicks(641) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 59, 40, 379, DateTimeKind.Utc).AddTicks(3523), new DateTime(2023, 8, 27, 16, 55, 25, 138, DateTimeKind.Utc).AddTicks(6493) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 9, 16, 10, 0, 19, 763, DateTimeKind.Utc).AddTicks(8259), new DateTime(2022, 11, 18, 20, 9, 50, 208, DateTimeKind.Utc).AddTicks(4497) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 16, 7, 10, 7, 138, DateTimeKind.Utc).AddTicks(5254), new DateTime(2023, 8, 13, 16, 31, 29, 793, DateTimeKind.Utc).AddTicks(4623) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 3, 25, 22, 47, 23, 691, DateTimeKind.Utc).AddTicks(2298), new DateTime(2023, 4, 17, 10, 29, 2, 318, DateTimeKind.Utc).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 11, 5, 32, 56, 58, DateTimeKind.Utc).AddTicks(7729), new DateTime(2023, 9, 7, 14, 3, 43, 766, DateTimeKind.Utc).AddTicks(5658) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 9, 17, 56, 2, 551, DateTimeKind.Utc).AddTicks(9272), new DateTime(2023, 9, 11, 4, 24, 13, 714, DateTimeKind.Utc).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 26, 12, 45, 25, 459, DateTimeKind.Utc).AddTicks(3289), new DateTime(2023, 6, 30, 19, 29, 14, 830, DateTimeKind.Utc).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 7, 12, 33, 59, 209, DateTimeKind.Utc).AddTicks(6405), new DateTime(2023, 9, 8, 13, 37, 20, 214, DateTimeKind.Utc).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2019, 12, 5, 17, 38, 58, 570, DateTimeKind.Utc).AddTicks(1643), new DateTime(2021, 1, 31, 20, 48, 1, 503, DateTimeKind.Utc).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 7, 18, 2, 41, 745, DateTimeKind.Utc).AddTicks(1217), new DateTime(2023, 6, 13, 23, 18, 45, 548, DateTimeKind.Utc).AddTicks(6962) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 8, 2, 52, 690, DateTimeKind.Utc).AddTicks(5314), new DateTime(2023, 8, 5, 20, 13, 21, 106, DateTimeKind.Utc).AddTicks(4054) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 23, 5, 20, 699, DateTimeKind.Utc).AddTicks(2557), new DateTime(2023, 7, 20, 11, 55, 32, 993, DateTimeKind.Utc).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 26, 8, 50, 1, 896, DateTimeKind.Utc).AddTicks(2446), new DateTime(2023, 8, 31, 20, 41, 57, 273, DateTimeKind.Utc).AddTicks(8672) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 28, 19, 48, 13, 75, DateTimeKind.Utc).AddTicks(8080), new DateTime(2023, 7, 7, 16, 26, 40, 108, DateTimeKind.Utc).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 22, 9, 4, 58, 561, DateTimeKind.Utc).AddTicks(3022), new DateTime(2022, 12, 25, 23, 15, 50, 245, DateTimeKind.Utc).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 11, 9, 13, 11, 16, 140, DateTimeKind.Utc).AddTicks(9067), new DateTime(2021, 3, 5, 8, 36, 32, 762, DateTimeKind.Utc).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 25, 14, 12, 28, 588, DateTimeKind.Utc).AddTicks(1428), new DateTime(2023, 6, 13, 13, 54, 32, 813, DateTimeKind.Utc).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 12, 6, 17, 37, 802, DateTimeKind.Utc).AddTicks(4161), new DateTime(2023, 9, 12, 7, 10, 15, 285, DateTimeKind.Utc).AddTicks(1458) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 3, 19, 24, 17, 117, DateTimeKind.Utc).AddTicks(121), new DateTime(2023, 9, 11, 12, 23, 38, 833, DateTimeKind.Utc).AddTicks(1450) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 13, 17, 32, 3, 645, DateTimeKind.Utc).AddTicks(5614), new DateTime(2023, 7, 7, 23, 10, 29, 891, DateTimeKind.Utc).AddTicks(7895) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 14, 39, 24, 700, DateTimeKind.Utc).AddTicks(4832), new DateTime(2023, 7, 10, 9, 31, 53, 969, DateTimeKind.Utc).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 14, 6, 8, 4, 472, DateTimeKind.Utc).AddTicks(1040), new DateTime(2023, 8, 24, 10, 37, 5, 784, DateTimeKind.Utc).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 23, 36, 9, 521, DateTimeKind.Utc).AddTicks(1056), new DateTime(2023, 7, 9, 15, 7, 43, 92, DateTimeKind.Utc).AddTicks(4146) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 9, 18, 21, 16, 14, 43, DateTimeKind.Utc).AddTicks(4970), new DateTime(2023, 2, 9, 14, 8, 6, 218, DateTimeKind.Utc).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 11, 5, 10, 53, 579, DateTimeKind.Utc).AddTicks(1624), new DateTime(2023, 9, 11, 14, 54, 7, 551, DateTimeKind.Utc).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 17, 5, 33, 55, 328, DateTimeKind.Utc).AddTicks(3881), new DateTime(2023, 7, 30, 11, 33, 11, 539, DateTimeKind.Utc).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 11, 5, 55, 38, 497, DateTimeKind.Utc).AddTicks(6180), new DateTime(2023, 6, 22, 13, 58, 10, 109, DateTimeKind.Utc).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 8, 23, 53, 22, 424, DateTimeKind.Utc).AddTicks(3399), new DateTime(2023, 7, 26, 20, 40, 10, 821, DateTimeKind.Utc).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 3, 20, 17, 46, 453, DateTimeKind.Utc).AddTicks(8426), new DateTime(2023, 9, 9, 18, 26, 33, 897, DateTimeKind.Utc).AddTicks(3496) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "RegisteredAt",
                value: new DateTime(2016, 5, 19, 21, 16, 0, 398, DateTimeKind.Utc).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "RegisteredAt",
                value: new DateTime(2016, 4, 10, 16, 56, 5, 169, DateTimeKind.Utc).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                column: "RegisteredAt",
                value: new DateTime(2017, 11, 10, 18, 42, 59, 267, DateTimeKind.Utc).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                column: "RegisteredAt",
                value: new DateTime(2018, 7, 26, 14, 9, 7, 801, DateTimeKind.Utc).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                column: "RegisteredAt",
                value: new DateTime(2017, 8, 16, 9, 5, 46, 764, DateTimeKind.Utc).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                column: "RegisteredAt",
                value: new DateTime(2022, 3, 7, 21, 21, 28, 818, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                column: "RegisteredAt",
                value: new DateTime(2020, 9, 18, 22, 46, 43, 883, DateTimeKind.Utc).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                column: "RegisteredAt",
                value: new DateTime(2022, 6, 2, 7, 5, 49, 248, DateTimeKind.Utc).AddTicks(2533));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                column: "RegisteredAt",
                value: new DateTime(2021, 12, 8, 5, 14, 8, 161, DateTimeKind.Utc).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                column: "RegisteredAt",
                value: new DateTime(2018, 7, 20, 19, 28, 35, 753, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11L,
                column: "RegisteredAt",
                value: new DateTime(2022, 3, 29, 11, 30, 42, 816, DateTimeKind.Utc).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12L,
                column: "RegisteredAt",
                value: new DateTime(2019, 9, 17, 18, 17, 26, 442, DateTimeKind.Utc).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13L,
                column: "RegisteredAt",
                value: new DateTime(2021, 3, 13, 20, 47, 17, 324, DateTimeKind.Utc).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14L,
                column: "RegisteredAt",
                value: new DateTime(2016, 6, 10, 2, 26, 29, 890, DateTimeKind.Utc).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15L,
                column: "RegisteredAt",
                value: new DateTime(2022, 3, 17, 19, 49, 51, 439, DateTimeKind.Utc).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16L,
                column: "RegisteredAt",
                value: new DateTime(2017, 6, 23, 11, 59, 44, 11, DateTimeKind.Utc).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17L,
                column: "RegisteredAt",
                value: new DateTime(2016, 1, 19, 23, 5, 0, 582, DateTimeKind.Utc).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18L,
                column: "RegisteredAt",
                value: new DateTime(2022, 12, 31, 14, 44, 11, 630, DateTimeKind.Utc).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19L,
                column: "RegisteredAt",
                value: new DateTime(2022, 4, 18, 21, 0, 58, 2, DateTimeKind.Utc).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20L,
                column: "RegisteredAt",
                value: new DateTime(2020, 12, 19, 12, 32, 49, 129, DateTimeKind.Utc).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21L,
                column: "RegisteredAt",
                value: new DateTime(2017, 1, 24, 22, 10, 58, 188, DateTimeKind.Utc).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22L,
                column: "RegisteredAt",
                value: new DateTime(2018, 5, 5, 7, 31, 14, 994, DateTimeKind.Utc).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23L,
                column: "RegisteredAt",
                value: new DateTime(2021, 11, 11, 6, 14, 17, 561, DateTimeKind.Utc).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24L,
                column: "RegisteredAt",
                value: new DateTime(2021, 4, 30, 8, 52, 47, 912, DateTimeKind.Utc).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25L,
                column: "RegisteredAt",
                value: new DateTime(2019, 2, 23, 15, 39, 24, 29, DateTimeKind.Utc).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26L,
                column: "RegisteredAt",
                value: new DateTime(2016, 6, 21, 21, 46, 23, 144, DateTimeKind.Utc).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27L,
                column: "RegisteredAt",
                value: new DateTime(2021, 12, 16, 3, 24, 1, 439, DateTimeKind.Utc).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28L,
                column: "RegisteredAt",
                value: new DateTime(2016, 7, 18, 12, 54, 52, 884, DateTimeKind.Utc).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29L,
                column: "RegisteredAt",
                value: new DateTime(2017, 8, 4, 20, 30, 7, 127, DateTimeKind.Utc).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30L,
                column: "RegisteredAt",
                value: new DateTime(2020, 8, 25, 4, 29, 54, 51, DateTimeKind.Utc).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31L,
                column: "RegisteredAt",
                value: new DateTime(2016, 12, 17, 4, 49, 32, 975, DateTimeKind.Utc).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32L,
                column: "RegisteredAt",
                value: new DateTime(2016, 12, 25, 6, 48, 4, 129, DateTimeKind.Utc).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33L,
                column: "RegisteredAt",
                value: new DateTime(2021, 12, 1, 9, 22, 51, 122, DateTimeKind.Utc).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34L,
                column: "RegisteredAt",
                value: new DateTime(2023, 3, 17, 20, 46, 14, 422, DateTimeKind.Utc).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35L,
                column: "RegisteredAt",
                value: new DateTime(2022, 2, 20, 22, 7, 43, 913, DateTimeKind.Utc).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36L,
                column: "RegisteredAt",
                value: new DateTime(2020, 4, 10, 22, 34, 41, 148, DateTimeKind.Utc).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37L,
                column: "RegisteredAt",
                value: new DateTime(2016, 5, 7, 13, 28, 2, 870, DateTimeKind.Utc).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38L,
                column: "RegisteredAt",
                value: new DateTime(2018, 12, 23, 5, 24, 53, 363, DateTimeKind.Utc).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39L,
                column: "RegisteredAt",
                value: new DateTime(2016, 7, 25, 2, 38, 36, 800, DateTimeKind.Utc).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40L,
                column: "RegisteredAt",
                value: new DateTime(2017, 10, 22, 0, 1, 36, 835, DateTimeKind.Utc).AddTicks(9865));

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
                values: new object[] { 10L, new DateTime(2023, 5, 12, 12, 25, 33, 698, DateTimeKind.Utc).AddTicks(1861), 8L, "Est aut repellendus qui fugit. Sed fugit explicabo autem cum consequuntur alias. Quo alias et quisquam voluptates. Nisi voluptatem omnis inventore velit ipsum maxime fuga.", 2L, "", 2, "Dolores nostrum earum deleniti iusto aut nesciunt modi et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 40L, "odit", new DateTime(2023, 3, 17, 15, 15, 47, 666, DateTimeKind.Utc).AddTicks(8944), 34L, "Vel voluptatum quia quia nesciunt sequi impedit.\nVoluptas repellat nam omnis est magnam rerum eum repudiandae minima.\nQuis atque reprehenderit accusamus dolore est ratione maiores non et.\nSequi minima pariatur dignissimos eum eligendi dolorum.\nCum voluptatibus quibusdam corporis saepe dolores.", "Et fugit vero vitae.", 1L, "", "amet" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 47L, "Officiis ducimus aut dolorem sit dicta ullam.", new DateTime(2021, 6, 23, 3, 19, 22, 589, DateTimeKind.Utc).AddTicks(213), 25L, "maxime", "Amet voluptates temporibus esse magni.", 1L, "", 3, "Minima accusamus magnam quia laudantium id ut corrupti. Et id nulla nesciunt. Nesciunt minima cupiditate. Dolore corrupti iusto ipsam sapiente." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 57L, "Molestiae hic et officiis accusantium nostrum repellat aut et.\nItaque animi eveniet ut delectus voluptates dolorem.\nLaudantium itaque sequi officiis sapiente et.", new DateTime(2023, 4, 7, 17, 39, 49, 863, DateTimeKind.Utc).AddTicks(2684), 27L, "Non porro impedit.", "Quis perferendis et pariatur sapiente repellat quasi.", 2L, "", 2, "Exercitationem dolorem adipisci veniam blanditiis quidem earum tempore molestias." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 60L, "Sit molestiae adipisci repellat eum vel dolorum aut ullam distinctio.\nOmnis animi officiis tenetur.", new DateTime(2019, 5, 2, 7, 38, 23, 446, DateTimeKind.Utc).AddTicks(1664), 9L, "Libero dolorem voluptatem et vitae eius nemo.", "Fugit mollitia aut ab eum est quaerat consequatur.", 1L, "", "Aliquid neque nemo dolore possimus.\nOptio veniam ratione qui nulla vel in aut.\nVel sit repellendus cupiditate quo quo.\nSunt unde ex doloremque necessitatibus quo veniam dolor officiis eos.\nExplicabo enim necessitatibus soluta est libero voluptatum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 69L, "Culpa maiores officiis deleniti cumque similique optio et sed ab. Quis voluptatem et veniam iusto rerum. Provident inventore voluptas nihil rerum totam expedita hic. Sint rerum earum facilis iusto unde nihil officia minima. Id occaecati quod. Laborum illo ipsum fuga ratione ipsa sequi.", new DateTime(2023, 1, 21, 19, 48, 15, 492, DateTimeKind.Utc).AddTicks(168), 25L, "Qui placeat facere omnis ea quia.", "Commodi architecto omnis necessitatibus est eum.", 1L, "", 2, "Dolor nesciunt sit itaque quidem debitis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 63L, "Est totam voluptas excepturi et expedita dignissimos et. Atque aut est et. Recusandae rerum dolor assumenda maiores placeat magnam debitis. Facilis velit et qui totam et iusto consequatur ut. Et tempora officiis error enim nulla.", new DateTime(2023, 4, 22, 20, 16, 59, 964, DateTimeKind.Utc).AddTicks(4388), 13L, "Debitis consequuntur perspiciatis dolorum architecto placeat error eum aut repellendus. Est cumque velit aspernatur voluptatum fugiat. Consequatur est voluptatum natus sed qui atque inventore beatae totam.", "Iure nisi voluptatem.", 2L, "", 1, "suscipit" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 55L, "Quia commodi non quis voluptatem ea.\nQuis dignissimos ipsam et in dolores perferendis.\nAspernatur praesentium sint quis eos et at iusto.\nOfficia harum in ab at at dolorem qui nobis.", new DateTime(2023, 3, 23, 4, 6, 13, 317, DateTimeKind.Utc).AddTicks(6872), 32L, "Et illo voluptas culpa ea ducimus ea.\nEt eum est est neque qui.\nVoluptatem unde voluptatem non.", "Voluptas veniam rerum sed qui ipsam accusamus fuga id.", 1L, "", 2, "rerum" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 66L, "Quis voluptatem autem voluptas ducimus maiores praesentium odit error adipisci. Vitae eligendi consequatur laboriosam commodi atque. Dolor eos est repellat enim aliquam ratione. A voluptatem assumenda delectus quaerat est recusandae aliquam provident. Rerum eius accusamus rerum recusandae cum et officia odit aliquid. Corrupti repellat aliquid dolorum iste quia voluptatibus dolores nostrum ab.", new DateTime(2023, 5, 4, 2, 45, 40, 193, DateTimeKind.Utc).AddTicks(6683), 6L, "Suscipit animi recusandae quo voluptatem odio.\nEsse quam ut optio quo non.", "Officia quos laboriosam porro aut consequuntur.", 1L, "", "dolor" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 16L, "Sint dolores laboriosam totam. Reprehenderit sed blanditiis perferendis qui non aliquid vero. Ab eaque ea consequatur aut.", new DateTime(2022, 11, 10, 18, 52, 33, 441, DateTimeKind.Utc).AddTicks(7566), 37L, "sed", "Totam voluptatem quam ut cumque sint tenetur sed et debitis.", 2L, "", 1, "Natus esse sint magnam incidunt velit adipisci voluptatem." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 2L, "Vitae aut molestias pariatur expedita provident ex beatae nihil numquam. Adipisci consequatur eos dolor quae sit. In esse et veniam.", new DateTime(2020, 10, 26, 23, 6, 39, 975, DateTimeKind.Utc).AddTicks(60), 23L, "Et dignissimos omnis veniam.\nDoloribus dolorem et accusamus nostrum aliquam aut repellat tenetur.\nQuia impedit ut.", "Laudantium accusantium possimus mollitia totam blanditiis odio corrupti asperiores.", 1L, "", 2, "Repellendus labore aut aut. Quaerat iure voluptatem exercitationem ut ut. Facere similique molestiae. Ex sit magnam animi natus deserunt voluptas." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 48L, "Rerum quaerat perferendis iusto ea et.", new DateTime(2023, 5, 15, 19, 2, 10, 397, DateTimeKind.Utc).AddTicks(3433), 34L, "Suscipit exercitationem error iure rerum.\nEt autem culpa nemo delectus voluptates.\nPariatur ut nihil.", "Quaerat hic facilis quod expedita adipisci voluptates molestiae qui.", 2L, "", 1, "cumque" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 63L, "Consequatur et ut dolor ut enim atque. Quia nobis dicta reiciendis. Doloribus qui perferendis odio ratione. Magnam atque minus. Minus rem voluptatum amet a dolorem modi. Qui quia commodi perferendis.", new DateTime(2020, 12, 5, 12, 4, 24, 697, DateTimeKind.Utc).AddTicks(7710), 13L, "nihil", "Natus explicabo repudiandae optio totam architecto sequi blanditiis.", 1L, "", 2, "repellat" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 52L, "Deserunt veritatis ad perferendis et nihil autem quia cupiditate.", new DateTime(2022, 12, 1, 10, 37, 21, 519, DateTimeKind.Utc).AddTicks(7086), 2L, "Maiores aut aliquid perferendis adipisci odio expedita ex nulla.\nIste aliquam ex repudiandae atque beatae.\nExcepturi illum et.\nCorporis quod eius vel ut repudiandae et.\nEt voluptas corrupti voluptas quaerat.", "Fugit error nihil aut veritatis quo.", 2L, "", 2, "maiores" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 34L, "Voluptatum quod sit voluptas nobis ut magni harum expedita non.", new DateTime(2022, 10, 6, 13, 48, 45, 796, DateTimeKind.Utc).AddTicks(6410), 24L, "Dicta rerum omnis voluptatem consectetur. Id et nihil. Maxime dolorem recusandae necessitatibus dolores ea velit vero laboriosam. Quaerat doloribus omnis iure rerum magnam perspiciatis necessitatibus et.", "Dolor labore numquam at praesentium ea ut aut rerum.", 2L, "", 3, "Tempora explicabo quasi esse aspernatur suscipit facere perspiciatis inventore asperiores." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 15L, "Officia neque ducimus aliquam eos.\nDolores est tempore doloremque aspernatur consequuntur autem beatae.\nQuos quo sit nulla autem hic dolore eveniet nostrum voluptatem.", new DateTime(2023, 3, 21, 21, 29, 7, 940, DateTimeKind.Utc).AddTicks(4644), 8L, "A velit laudantium cupiditate veritatis ex sunt aspernatur quidem.", "Ut consequatur laborum laudantium quos consequatur inventore.", 2L, "", 1, "et" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 14L, "Explicabo ipsa cum.\nAutem nisi voluptatem sequi aut aut nulla quod voluptas.\nFugiat harum id enim quisquam at reprehenderit beatae.\nHarum doloremque assumenda laboriosam saepe.", new DateTime(2023, 2, 15, 21, 0, 24, 72, DateTimeKind.Utc).AddTicks(7116), 34L, "Aliquid ratione quisquam molestiae ipsam commodi.", "Et eius asperiores.", 1L, "", 0, "Ut accusamus voluptas. Nesciunt repellendus expedita est perferendis dolorem earum provident distinctio. Animi quam consectetur ipsum et. Soluta vel tempore est perferendis temporibus quae. Est consequatur quis commodi ipsum veritatis in officiis et. Cum nulla rerum fuga impedit doloremque qui unde deserunt." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 38L, "Dolores sit libero inventore odit.\nNesciunt totam velit omnis ea quaerat vero est.\nVero optio consequuntur tempore est consequatur.\nOdit quia perspiciatis cumque in.", new DateTime(2023, 6, 5, 12, 30, 8, 773, DateTimeKind.Utc).AddTicks(5510), 16L, "Sit amet repudiandae unde excepturi ea et veniam veniam.\nNemo cumque ea ab.", "Dolorem vitae consequatur qui in ea animi autem.", 1L, "", 0, "Rem cumque at consequatur tempora et facilis corporis ut iste. Autem ipsum sapiente. Qui ratione et dolores quas ut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 26L, "optio", new DateTime(2023, 3, 20, 6, 20, 51, 938, DateTimeKind.Utc).AddTicks(9662), 36L, "Unde animi sed et illo. Sunt iure unde fugit animi. Et dolorem sed ipsum atque reiciendis corporis blanditiis qui. Reprehenderit culpa sint impedit. Dolor maiores eius dolore repellat sunt velit labore dolores. Nesciunt libero inventore cupiditate doloribus ab quia et ab.", "Et harum dolores.", 1L, "", 0, "Id nobis dicta consequatur facilis quae deleniti eaque doloribus.\nAutem earum quos.\nExplicabo delectus expedita quisquam quam aspernatur vel animi nostrum.\nNecessitatibus itaque adipisci optio ab est pariatur." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 35L, "Accusamus animi maxime molestiae qui. Voluptas quia enim. Recusandae ea dicta numquam. Accusamus qui atque dolorum odit non quis molestias.", new DateTime(2023, 5, 29, 2, 44, 38, 37, DateTimeKind.Utc).AddTicks(3297), 2L, "nostrum", "Quos reprehenderit saepe voluptate quia ut culpa ut molestias.", 1L, "", "Quis nemo culpa voluptatem omnis minus deserunt quisquam nemo.\nCorporis rerum dolor sed omnis.\nError dolore praesentium quos quia asperiores et impedit tenetur voluptatem." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 23L, "Molestias nihil quas omnis delectus consequatur quaerat.", new DateTime(2023, 9, 2, 9, 2, 20, 729, DateTimeKind.Utc).AddTicks(3736), 30L, "Officiis consequatur non natus ullam voluptatem.\nNon quaerat omnis accusantium ea provident eius sunt iste.\nCum a dicta et ratione.", "Possimus sit maxime doloribus est velit vel commodi et.", 1L, "", 2, "vel" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 65L, "quidem", new DateTime(2022, 9, 6, 1, 15, 5, 273, DateTimeKind.Utc).AddTicks(6489), 36L, "earum", "Fugiat consequatur ipsam dolore laudantium culpa accusamus fuga.", 2L, "", "Nesciunt nemo placeat.\nQui voluptatem maxime ut cumque reiciendis dolores unde." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 68L, "Doloribus laboriosam quo eligendi quidem non porro est qui magni.\nDolor optio magnam quidem qui cumque hic maxime tenetur.", new DateTime(2023, 3, 13, 4, 16, 58, 412, DateTimeKind.Utc).AddTicks(9993), 22L, "Eveniet et et in quis. Ea ut quidem eius animi. Tempora in consequatur voluptas velit cum dolore dolorum ut vitae. Voluptatem sed dolore ducimus officiis non possimus voluptatem. Voluptatibus iure quod veniam et nostrum neque. Totam non veritatis aperiam aperiam aliquam rem autem vel.", "Consequuntur vel ducimus ducimus dolor eveniet tenetur ut hic qui.", 1L, "", 1, "delectus" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 55L, "eaque", new DateTime(2022, 11, 12, 23, 3, 21, 504, DateTimeKind.Utc).AddTicks(4544), 25L, "Ut ullam et ab omnis odit vitae maiores. Maiores totam dolore voluptatem repellendus doloribus et beatae laudantium. Neque quos voluptates. Quis vel iure blanditiis dolorem mollitia.", "Vel animi placeat.", 2L, "", 1, "Debitis adipisci eaque voluptates voluptas fugiat vitae consectetur voluptates. Nihil voluptatem illo voluptatem laborum veniam hic. Architecto dolores aut quibusdam minus doloremque maxime aliquid molestiae. Ut explicabo consequuntur delectus maiores blanditiis sit quo." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 61L, "optio", new DateTime(2023, 5, 2, 1, 30, 29, 61, DateTimeKind.Utc).AddTicks(975), 28L, "Labore reprehenderit est sint iure tenetur numquam dolor.\nQuia dolore temporibus rem suscipit excepturi dicta quas.\nOmnis cumque pariatur sapiente.\nAd dolorem autem minus in ullam quam.\nEt ullam unde molestias natus ad quod reiciendis dolor atque.\nQuia quod recusandae quia voluptas.", "Velit dolor maxime tenetur molestiae distinctio commodi.", 2L, "", 3, "Eos sit repellat et aut autem maiores sit qui." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 25L, "Nisi quos molestiae. Hic consequatur omnis voluptatem mollitia eius deserunt possimus repellendus. A laudantium delectus sed qui.", new DateTime(2022, 12, 22, 12, 56, 31, 520, DateTimeKind.Utc).AddTicks(2526), 8L, "Et veritatis voluptatem dolorum corporis qui aut quibusdam. Sunt porro id. Adipisci aliquam impedit iure saepe dolores voluptatum corporis voluptas.", "Velit repellendus ad accusamus autem facere deserunt eius illum.", 1L, "", "Aut omnis incidunt.\nEveniet doloribus eum sapiente libero vel voluptatibus et.\nPorro ea earum repudiandae sunt sint accusamus.\nReiciendis consectetur sint dicta eaque.\nMagni aliquam minima atque atque qui quis reprehenderit neque.\nQuaerat repudiandae est assumenda harum omnis numquam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 5L, "Omnis et incidunt distinctio dolor.\nDoloremque quos ut deserunt debitis et illo culpa.\nMolestiae neque voluptatem minima eligendi ducimus repudiandae.\nTempore delectus consequuntur cum aut dolor eligendi mollitia aut.\nSunt rerum amet voluptatum qui porro fugiat dignissimos.\nInventore facilis totam consequatur consequuntur error officia optio ut.", new DateTime(2023, 7, 31, 14, 45, 36, 706, DateTimeKind.Utc).AddTicks(9000), 21L, "Nihil atque molestiae. Excepturi praesentium qui alias hic sint aperiam nam pariatur nihil. Atque est error ipsa facilis fuga. Dolore eum illo voluptatem reiciendis. Dolor inventore ex minus. Accusamus mollitia fugiat.", "Dolorum molestiae reiciendis.", 1L, "", "Voluptas quidem labore iste.\nIllo maiores sit ipsam sunt repellat et delectus.\nItaque voluptas ducimus iusto id dignissimos.\nHarum vero dolor sed." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 60L, "Neque ut mollitia aut corrupti deleniti. Modi necessitatibus error corporis laborum voluptatibus eum. Laboriosam officia dolorem sed eveniet est rerum porro. Fugit molestiae sequi quasi velit cupiditate.", new DateTime(2023, 4, 6, 11, 52, 33, 791, DateTimeKind.Utc).AddTicks(6877), 32L, "In nesciunt beatae vel.", "Autem non in itaque deserunt dolorem dolores quis provident rerum.", 1L, "", 2, "Vel iusto mollitia unde dolor et voluptatem tempora.\nAtque sapiente aspernatur voluptas laborum asperiores totam aperiam.\nRem eum blanditiis et ad sint dolorem voluptas veritatis voluptas.\nVel consequatur at corrupti voluptates animi.\nQuasi autem voluptate voluptatem excepturi libero.\nIn possimus sit temporibus vel nesciunt id autem culpa et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 33L, "animi", new DateTime(2023, 4, 1, 20, 8, 59, 478, DateTimeKind.Utc).AddTicks(5702), 20L, "Fugiat reiciendis dolore dolorem pariatur iusto repellendus laborum veritatis. Voluptatem ut doloribus velit asperiores quam illum necessitatibus. Veniam facilis est. Et natus sed dolores ipsa. Iste blanditiis placeat. Voluptatem perspiciatis iusto mollitia provident.", "Aut est esse.", 2L, "", "Sed quia accusamus temporibus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 37L, "Aut est dignissimos. Facilis ullam maxime in quas numquam enim. Tempore et natus dolorem veniam sapiente mollitia hic ratione quia. Consequatur consectetur quibusdam nemo et et et. Maiores eligendi velit iusto eum voluptatem molestiae.", new DateTime(2022, 12, 16, 21, 10, 50, 63, DateTimeKind.Utc).AddTicks(1379), 30L, "Sapiente voluptatibus delectus est recusandae neque rerum aut.\nMaiores harum esse nulla doloribus dolore suscipit alias expedita quis.\nRem et qui tempore ex.\nMolestiae commodi modi magni dicta explicabo assumenda veritatis.", "Doloribus consequatur voluptate eum perspiciatis temporibus illo eveniet.", 1L, "", 1, "Officia et quae sed." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 69L, "Et ipsum voluptatem provident magnam exercitationem quam quaerat id ad.\nAut ut ut est repellendus est qui illo.", new DateTime(2022, 10, 22, 11, 10, 31, 625, DateTimeKind.Utc).AddTicks(6134), 19L, "Nulla labore dolore voluptatem. Dicta quia distinctio mollitia et consequatur voluptatem maiores. Commodi dicta omnis deleniti optio. Reiciendis eos et provident laborum provident assumenda nulla ut ut. Id consequatur eos. Voluptatem quos aliquam fugit porro eligendi aut.", "Illo tempora et nulla sint molestias odio sit laboriosam.", 1L, "", 3, "Laudantium velit et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 56L, "Voluptatem ea eligendi.", new DateTime(2019, 8, 24, 16, 1, 16, 54, DateTimeKind.Utc).AddTicks(2898), 17L, "tempora", "Tempore vel nihil voluptas incidunt earum dolor maiores qui quo.", 1L, "", 3, "Eveniet nulla id laboriosam.\nCupiditate commodi voluptatibus magnam explicabo consequatur libero.\nRatione praesentium aut ipsum officia unde magnam autem.\nSapiente officia odio dolor voluptas perferendis.\nSit amet nihil sed harum similique." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 58L, "beatae", new DateTime(2020, 8, 17, 5, 45, 4, 475, DateTimeKind.Utc).AddTicks(4635), 32L, "Distinctio omnis quia. Ducimus hic est ea itaque ut ullam molestiae nobis. Maxime repellat id autem quae aut reiciendis nihil.", "Vitae quia repudiandae perferendis ut rerum sint amet.", 2L, "", 0, "Aut voluptatem ut consequatur soluta aliquid.\nSint et iure totam veritatis in ut.\nVoluptas aut est nulla consequuntur qui aut.\nCupiditate voluptas in quis aut qui.\nNisi libero aut.\nUt beatae et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 67L, "Impedit fuga beatae illum necessitatibus ut earum autem temporibus repudiandae.", new DateTime(2023, 4, 7, 0, 17, 26, 982, DateTimeKind.Utc).AddTicks(2223), 36L, "Quis fugit ullam incidunt numquam consequatur omnis reiciendis aperiam. Vel nesciunt magni ut. Aliquid eveniet voluptatem porro.", "Necessitatibus et voluptate eum iusto autem.", 2L, "", 1, "Ut laboriosam inventore non fugit. A consequatur aliquid. Est eligendi quia sint odio earum totam asperiores." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 40L, "Sunt et natus inventore tempora possimus cumque eveniet quasi adipisci. Voluptatem et fugiat. Architecto aut minima deserunt similique tempore quia. Voluptas non ut accusamus odit provident iste quaerat.", new DateTime(2023, 6, 7, 3, 47, 22, 785, DateTimeKind.Utc).AddTicks(4544), 38L, "quisquam", "Nobis qui quas.", 1L, "", 1, "porro" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 27L, "quaerat", new DateTime(2022, 9, 6, 22, 56, 28, 915, DateTimeKind.Utc).AddTicks(2380), 32L, "Et beatae aperiam et ut delectus aut. At aliquid rerum nihil. Illo magni autem sit odio at deleniti. Odit voluptatibus debitis quaerat autem.", "Nihil facilis enim et.", 2L, "", 2, "Voluptatum modi quaerat placeat et sint dolores.\nConsequuntur doloribus rerum mollitia consequatur sint itaque ut.\nVoluptate fugit labore quas dolores nisi alias.\nMagnam provident quam et necessitatibus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 9L, "Eaque harum dignissimos nemo architecto et qui in ullam assumenda.", new DateTime(2022, 12, 31, 0, 59, 35, 737, DateTimeKind.Utc).AddTicks(3274), 7L, "ut", "Est vitae ducimus.", 1L, "", 3, "in" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 32L, "Illo fugit recusandae explicabo cupiditate est. Voluptatum voluptatibus aut voluptate ipsum minima blanditiis voluptas. A est quibusdam voluptatibus tempore saepe. Rerum consequatur sint harum nisi maxime et ipsa rem.", new DateTime(2023, 9, 2, 9, 23, 13, 391, DateTimeKind.Utc).AddTicks(3259), 18L, "Quasi dolor inventore.", "Sequi est deserunt.", 1L, "", "Accusantium laudantium sed dolore officia impedit similique. Facilis porro et rerum ea aliquam cum est maiores quia. Omnis nesciunt sit quae veniam id. Aliquid qui omnis voluptas itaque quis est vero illum sit. Commodi quia ad aut aut eos ipsum sit aperiam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 6L, "Ut et odio distinctio saepe. Delectus neque tempore amet adipisci debitis aut. Cumque voluptatem distinctio assumenda impedit quidem quo. Quam quia animi quo quisquam deserunt repudiandae ut animi. Reprehenderit voluptas et est est. Rerum iusto sit veniam dolor magnam.", new DateTime(2023, 5, 2, 5, 23, 6, 589, DateTimeKind.Utc).AddTicks(4970), 3L, "et", "Sint facilis laborum ea quo quis.", 1L, "", 1, "Illum architecto repudiandae explicabo quia id ipsum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 31L, "Ad nemo iste fuga ipsum fuga inventore voluptatem facilis soluta.", new DateTime(2023, 8, 7, 10, 23, 43, 680, DateTimeKind.Utc).AddTicks(1274), 24L, "Quisquam eveniet quo rerum consequatur et est repellat aperiam quaerat.", "Quis dolore voluptate officia itaque atque quaerat voluptas molestiae laborum.", 2L, "", 1, "Dicta magnam laboriosam consequatur optio suscipit aliquid eum provident sapiente. Assumenda nam natus. Iste enim maiores." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 57L, "Nisi occaecati at molestias veritatis alias laudantium suscipit. Suscipit ipsum minima consectetur esse reprehenderit natus temporibus. Aliquid autem ad ut est blanditiis architecto impedit.", new DateTime(2023, 4, 13, 5, 42, 50, 309, DateTimeKind.Utc).AddTicks(9308), 4L, "Sit aliquid modi aliquid ut sint. Voluptas ab perferendis odit beatae. Sunt totam velit nobis velit. Natus delectus enim dolorem quod quas et. Asperiores cumque fuga necessitatibus error ut ab et velit aperiam.", "Et qui incidunt minima.", 1L, "", 1, "Possimus sed sit libero sequi quos molestiae a in fuga. Sunt et alias sunt ratione enim distinctio vel non quo. Harum omnis quaerat totam beatae voluptates. Et ex quia eum quam recusandae. Voluptatem est eaque molestiae." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 36L, "Excepturi ducimus ipsa nihil maxime.\nAtque nulla sed iste ipsam veritatis nihil.", new DateTime(2022, 5, 12, 7, 44, 1, 602, DateTimeKind.Utc).AddTicks(4194), 25L, "Enim autem error animi quia rem exercitationem ut nam sit. Ducimus qui enim et. Autem sed consectetur fuga accusamus. Omnis enim est voluptas est id debitis aperiam.", "Nesciunt quisquam nisi et error.", 1L, "", 1, "perspiciatis" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 46L, "Natus sequi placeat. Est rerum dicta animi dolorem exercitationem. Veniam cumque est sunt harum voluptas expedita explicabo temporibus eveniet.", new DateTime(2022, 7, 12, 2, 41, 54, 530, DateTimeKind.Utc).AddTicks(7000), 14L, "Aperiam qui asperiores temporibus id impedit dolores animi.", "Temporibus voluptates quia sunt consequuntur omnis eos laudantium est.", 2L, "", "Autem et dolores sunt consequatur sunt.\nVero soluta voluptas ipsa est veniam facere.\nQuo occaecati vel repellat quos sint ipsa officiis odio.\nIncidunt dolorum aperiam expedita quis aut rerum libero." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 57L, "Totam omnis velit enim expedita nesciunt illo.", new DateTime(2023, 4, 26, 20, 23, 35, 423, DateTimeKind.Utc).AddTicks(6108), 4L, "Deserunt non ut. Itaque nostrum minima corrupti. Ex aut voluptatibus consequatur maxime. Esse quia voluptas.", "Eum enim vitae cum doloribus perspiciatis placeat maxime inventore.", 1L, "", 1, "Sunt cupiditate voluptatem voluptatem dolor dolor odio earum autem. Aut non tempora ad aspernatur. Quia soluta quod." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 47L, "Fuga nulla ratione distinctio corporis perferendis cupiditate iste et laudantium. Delectus temporibus rem reiciendis sunt. Vel sint excepturi voluptas quo perferendis. Est provident recusandae. Id qui voluptatem. Magnam quam qui et neque qui sapiente veritatis quia.", new DateTime(2022, 1, 14, 11, 40, 30, 176, DateTimeKind.Utc).AddTicks(8007), 27L, "et", "Quia et non et tenetur autem aliquam ut provident corrupti.", 1L, "", 0, "Praesentium vero nam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 53L, "Qui autem qui ut quo quis. Inventore voluptate nisi at qui laboriosam hic omnis iste tempora. Quis accusantium qui quasi ea facilis in tenetur facere et.", new DateTime(2020, 8, 31, 1, 48, 7, 705, DateTimeKind.Utc).AddTicks(5756), 12L, "consectetur", "Nam repellendus eum et perferendis.", 2L, "", 2, "explicabo" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 49L, "A porro accusantium ad voluptas doloremque in illo id placeat.\nEt qui omnis et dicta delectus.\nNon distinctio voluptatum deserunt iure.\nEt voluptates doloremque in aut animi.\nCumque dolorem iusto asperiores eaque est illum magnam aut.\nEt qui vel eveniet illum ipsum consectetur dolor recusandae.", new DateTime(2023, 8, 23, 3, 28, 44, 547, DateTimeKind.Utc).AddTicks(3911), 29L, "alias", "Hic autem sit eius aliquam.", 2L, "", 2, "Quos neque corrupti commodi sit omnis doloremque recusandae repellat qui." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 22L, "Id voluptas in architecto ut officiis.\nDistinctio hic harum nihil.\nRepellendus voluptatem aut ut.\nEos debitis non qui laudantium nihil animi dolorum aut.", new DateTime(2023, 1, 7, 5, 38, 26, 585, DateTimeKind.Utc).AddTicks(7180), 15L, "eveniet", "Enim voluptatem veritatis aut accusamus omnis qui.", 2L, "", 2, "Recusandae repudiandae possimus aut id. Sequi nihil ut et. Deleniti perferendis possimus. Officiis dicta commodi quod." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 3L, "Quisquam hic magnam. Consequuntur hic unde ut. Qui qui consequuntur impedit quis qui. Quod eos autem qui aliquam animi inventore.", new DateTime(2023, 7, 26, 16, 50, 30, 357, DateTimeKind.Utc).AddTicks(4246), 13L, "Est et quia non molestiae iure architecto possimus architecto atque. Officiis aut optio natus cupiditate ipsam ipsa deleniti est sit. Nesciunt ex id unde mollitia et quia quia tempore voluptatibus.", "Quam et blanditiis et asperiores.", 1L, "", "Id dolorum sint velit et expedita facilis quod esse et.\nSit et inventore aliquid est dolorem debitis rerum nesciunt.\nMagni quasi et quas vero ducimus aut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 41L, "rerum", new DateTime(2023, 6, 16, 1, 49, 47, 604, DateTimeKind.Utc).AddTicks(4800), 29L, "Est autem temporibus dolorem unde et vel voluptatibus in.\nMolestias et fugit rem dolorum sunt voluptatem veritatis qui.\nPossimus nisi veniam quis sapiente debitis.\nQuod nihil hic.\nQuas est natus labore quae.", "Nihil iure facere sed similique cum animi quaerat ut.", 2L, "", 2, "Non minima ut impedit." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 37L, "quia", new DateTime(2022, 2, 28, 18, 28, 31, 60, DateTimeKind.Utc).AddTicks(2682), 28L, "Dolorum qui expedita autem expedita quaerat expedita esse.", "Nobis corrupti porro cumque eius distinctio enim.", 1L, "", 2, "Explicabo ut explicabo quam.\nTempore temporibus quasi minima.\nBlanditiis consequatur quidem omnis incidunt sunt dolores odio." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 27L, "Inventore aperiam impedit et libero. Quod eligendi rerum voluptatem mollitia id. Est ullam voluptas hic sit quis rerum voluptas repellat est. Magnam vitae voluptatem et ipsam veritatis deserunt omnis dolorem. Animi omnis hic adipisci maiores maiores eligendi dolorem quod. Et dolor sint commodi expedita esse molestiae.", new DateTime(2022, 11, 14, 23, 27, 11, 266, DateTimeKind.Utc).AddTicks(1262), 23L, "Impedit ut tempore ut ut et aperiam vel. Qui similique ducimus et ut et. Consequatur aliquid sed. Libero at sequi quia harum aut perferendis. Nisi sit ut dolorem rem sit at culpa. Repudiandae rem eaque.", "Totam ut tenetur dolor autem ut.", 2L, "", 2, "Sunt veritatis quaerat repudiandae. Qui dolorem quia autem qui natus illum omnis ratione. Sed illum possimus. Iure rerum itaque. Dolore quia rem similique ut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 27L, "At vitae laudantium animi minus atque exercitationem aperiam iure iste. Reiciendis id sed eius ut blanditiis. Vitae vel exercitationem incidunt officia eum ratione totam id commodi. Illum porro voluptas dolorem numquam repellat et rerum ipsam id.", new DateTime(2023, 7, 7, 2, 15, 57, 307, DateTimeKind.Utc).AddTicks(1193), 1L, "Quaerat eos qui cupiditate voluptas hic doloribus in.\nHarum officiis in quia enim architecto ab similique cum.", "Suscipit ad autem laudantium velit unde.", 2L, "", 0, "Labore perferendis aut excepturi mollitia.\nNesciunt error maxime libero.\nQuos tempore fuga dolores quidem blanditiis ut maxime recusandae.\nSimilique quo beatae consequatur." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 7L, "Iusto corporis id.\nUt neque quisquam harum sint dolor qui.", new DateTime(2020, 4, 24, 6, 51, 54, 429, DateTimeKind.Utc).AddTicks(9050), 2L, "Quod porro aliquam minima libero porro est voluptas ipsam in.\nNon quibusdam sed assumenda consequatur rem occaecati suscipit sint qui.", "Consequatur iste amet tempore quia eveniet.", 2L, "", 0, "Qui voluptas quos temporibus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 6L, "Vero sint reprehenderit a voluptatem.\nDolorem necessitatibus mollitia harum a fugiat voluptatem.", new DateTime(2023, 5, 13, 12, 3, 4, 27, DateTimeKind.Utc).AddTicks(6191), 17L, "labore", "Eum nisi dolor iure iure similique aspernatur corporis.", 2L, "", 3, "Et sequi repellat et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 32L, "quae", new DateTime(2023, 8, 27, 2, 46, 50, 38, DateTimeKind.Utc).AddTicks(1957), "Sit dicta ut.", "Similique ea optio.", 1L, "", "Illum quia eos nihil similique qui voluptatem atque. Accusamus molestias nesciunt. Non tenetur earum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 40L, "Dolores nostrum sunt veritatis quidem. Odit et architecto. Reiciendis saepe ea voluptate possimus molestiae a earum veritatis qui. Cum voluptas et et eos dolorum. Id a harum veniam sint at blanditiis.", new DateTime(2023, 1, 18, 0, 28, 51, 903, DateTimeKind.Utc).AddTicks(6907), 10L, "adipisci", "Non eveniet in voluptates debitis.", 2L, "", 0, "Vel repellat nesciunt.\nQuis fuga sed est eveniet.\nQui voluptatum tenetur.\nVel quia voluptatibus illum delectus voluptas repellat dolores laudantium cupiditate.\nSed veniam optio vel molestias hic." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 9L, "Consequatur optio totam enim.", new DateTime(2022, 1, 29, 2, 8, 58, 952, DateTimeKind.Utc).AddTicks(7313), 26L, "Ea provident modi.\nSuscipit in at voluptatibus quia porro nisi necessitatibus quia.", "Cumque ipsa blanditiis et quas.", 1L, "", "Ea doloremque rerum provident harum voluptates aliquam nisi. Incidunt reprehenderit ipsum eaque minima voluptatem autem. Delectus reiciendis sint voluptatem quis ut aliquam sapiente dicta. Aut qui tempora et rerum. Nihil autem eveniet cum non." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 40L, "Optio modi commodi necessitatibus.\nEt facere ipsam ea et nobis.\nMagni voluptatem molestias quisquam placeat consectetur.\nCum voluptate quae.", new DateTime(2023, 3, 19, 17, 41, 37, 565, DateTimeKind.Utc).AddTicks(3150), 21L, "Dignissimos alias nam est vel quisquam est voluptatem enim.", "Culpa qui possimus minima dolorem facere at.", 1L, "", 1, "Et animi aliquam inventore aspernatur deleniti repellendus. At fuga dolores reiciendis alias. Excepturi ea quia tempora earum eos aut perferendis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 48L, "quod", new DateTime(2023, 6, 15, 11, 34, 33, 506, DateTimeKind.Utc).AddTicks(8074), 1L, "sed", "Voluptatem eveniet fugit ad rerum.", 2L, "", "Ipsam ut qui sit consectetur voluptate.\nOdit atque et explicabo vel dolor omnis dolores aut ut.\nDolorum explicabo non eos sint et temporibus sapiente.\nQuod at possimus cumque aliquam consequuntur fugit dolores atque eum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 37L, "Consequuntur dignissimos veniam.\nVoluptatem ut incidunt incidunt esse voluptatem.\nEst repudiandae voluptas nobis et.\nEst ratione asperiores.\nEst quam perferendis voluptas enim quo qui.", new DateTime(2022, 9, 5, 2, 40, 23, 699, DateTimeKind.Utc).AddTicks(3519), 21L, "Et consequuntur nobis eum ipsa dolorem molestiae aut necessitatibus iste.\nEarum exercitationem qui consequatur et expedita molestias.", "Suscipit quisquam error eos.", 1L, "", 3, "molestiae" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 28L, "dolor", new DateTime(2022, 9, 27, 14, 14, 45, 192, DateTimeKind.Utc).AddTicks(522), 18L, "Velit et quas voluptas.", "Enim laborum quae.", 2L, "", "Veritatis quod veniam porro repellat ut perferendis. Modi voluptatibus nam explicabo saepe quasi. Perspiciatis ut et officia sint fugit tempore. Aut est nam natus. Quia id incidunt ut error reiciendis. Omnis ducimus est et quam dolores consequatur exercitationem quibusdam at." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 22L, "Sint consectetur asperiores explicabo optio voluptatem dolorem. Odit autem in quaerat voluptatem sed. Commodi dolorum saepe magnam molestias. Ut corrupti aut ad culpa ipsam. Et facilis vel quae sunt at non aut. Voluptate ratione eum.", new DateTime(2023, 4, 23, 8, 19, 48, 360, DateTimeKind.Utc).AddTicks(3925), 30L, "Eos repudiandae aut.", "Ipsum quasi suscipit tempore officia ea atque.", 2L, "", 0, "est" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 58L, "Laudantium error ex dolorem voluptate quia aliquid. Non placeat quam veniam nulla. Rem accusamus commodi omnis. Iusto soluta ut eius perspiciatis quo qui.", new DateTime(2019, 12, 30, 23, 49, 52, 686, DateTimeKind.Utc).AddTicks(9392), 13L, "Quos ipsa sed dolorum quisquam nihil voluptatum. Ut voluptatem dicta laborum eum aperiam rem placeat. Vel laudantium accusamus harum libero. Reiciendis dolores nobis.", "Aliquam aperiam autem cumque voluptatibus illum sed.", 2L, "", "Officia accusantium repellat. Magni et qui repellendus placeat qui voluptatum sapiente recusandae. Voluptas vitae ut consectetur neque tempora aut. Nisi quia maiores fugiat natus nisi." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 3L, "Nulla a quis. Dicta consectetur delectus ut blanditiis a dolorem. Modi corrupti aperiam facere et quam ipsa repudiandae aut amet.", new DateTime(2023, 7, 5, 1, 48, 8, 108, DateTimeKind.Utc).AddTicks(885), 14L, "A molestias nihil dicta. Voluptas illo est nostrum repudiandae expedita eum labore a architecto. Impedit ut vitae et ut dicta enim velit. Consequatur nisi non non est. Modi qui rerum deserunt quas aperiam. Ut provident aut beatae.", "Nihil aut maiores et minus voluptates quia expedita dolores voluptatum.", 2L, "", 2, "Perferendis praesentium aliquam aut autem nesciunt at.\nHic nostrum est eum enim non fugit qui fuga." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { "consectetur", new DateTime(2022, 4, 15, 23, 10, 34, 291, DateTimeKind.Utc).AddTicks(4414), 13L, "Laboriosam ea laboriosam nobis optio quisquam ut. Reprehenderit commodi eaque aliquam ut veritatis est velit eligendi. Maiores similique est saepe dignissimos sit ut ullam consequatur.", "Eos eum et vitae aut.", 1L, "", 3, "Omnis sed dolores nulla. Occaecati molestiae et et aliquid commodi similique optio ut. Omnis cumque necessitatibus quas ut error delectus modi." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 4L, "minima", new DateTime(2022, 6, 12, 7, 13, 26, 769, DateTimeKind.Utc).AddTicks(5281), 3L, "Et autem ullam perspiciatis aut dolores enim dignissimos. Et sunt et quaerat quis aperiam maxime similique. Voluptatibus sapiente est error. Quaerat perspiciatis ullam. Ut inventore nihil autem amet iusto possimus iusto. Nulla aperiam dolorem aperiam non corrupti voluptatem sint sit aspernatur.", "Corporis dolor accusantium explicabo delectus expedita facilis ullam necessitatibus.", 2L, "", 0, "Dignissimos fuga commodi enim et consequatur quas vero.\nA consequatur laboriosam in ex ut.\nCulpa quae provident deleniti.\nAut qui odit est dolores nisi ut et maxime dolorem." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 51L, "Enim ut consectetur.", new DateTime(2022, 9, 13, 14, 5, 0, 354, DateTimeKind.Utc).AddTicks(9372), 21L, "Dolorem tempora aperiam iure et esse omnis. Distinctio omnis officia aspernatur dolores atque maxime in. Exercitationem minima quia sed. Ea voluptates nulla. Maiores blanditiis nemo nesciunt magni maxime repellat corrupti esse aut. Quo dolorum eum error.", "Quo earum sint ea suscipit ipsa repellat qui fugiat aperiam.", 1L, "", 1, "Ut provident veritatis rerum.\nUt velit cupiditate labore ducimus quam est alias alias.\nVero ut dolores quo architecto iste et.\nCulpa sed quia.\nSed et fugit.\nAutem sed sunt sequi rerum accusamus saepe consectetur soluta rerum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 6L, "Perferendis quia dolorem consequuntur perspiciatis et molestiae aspernatur.\nQuas est nulla aut aut et.\nIusto nihil tempore ducimus natus voluptas voluptas aut voluptate.\nQuod animi nemo optio laborum voluptatum non ipsam rem.", new DateTime(2023, 8, 14, 11, 21, 29, 817, DateTimeKind.Utc).AddTicks(1924), 28L, "Non dolor expedita tenetur eos quia vel quia quia.", "Iure voluptatem laborum perspiciatis.", 2L, "", 0, "Perferendis ipsum alias ea." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 32L, "Et nihil aliquam libero ipsa explicabo et fugit consectetur. Fugiat animi ad molestiae occaecati quos dolores consequuntur adipisci. Et ullam exercitationem esse consequuntur in cum magni voluptatem. Voluptatem dolorem animi unde voluptas facere et. Ipsa accusantium amet cum expedita.", new DateTime(2023, 9, 2, 9, 11, 7, 968, DateTimeKind.Utc).AddTicks(4923), 7L, "Beatae labore magnam ad dolorem nihil voluptate est atque quam.\nNesciunt ducimus tempore aut nisi est.\nLaborum voluptate officiis rerum numquam sunt.\nDucimus porro ratione animi.\nExcepturi error omnis itaque error sunt.\nIn sed odit omnis.", "Quisquam facere debitis dolorem temporibus eligendi necessitatibus ipsum quidem.", 1L, "", 0, "Omnis et quia in tempore. Officia facere enim ipsam magni voluptas ut. Quam consequatur quibusdam culpa qui libero. Est neque assumenda et consectetur dicta ipsum mollitia qui rerum. Dolores at accusantium consequatur a. Itaque sint in pariatur minima ducimus dolorum accusantium voluptas in." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 6L, "neque", new DateTime(2023, 5, 11, 1, 39, 38, 740, DateTimeKind.Utc).AddTicks(2898), "Inventore et vero vel. Aut porro aspernatur aut ut quas vero. Sit quia recusandae blanditiis dolorum rerum voluptas sint. Autem similique consequatur non consequuntur.", "Est illum nobis beatae eos asperiores velit aut iusto.", 1L, "", 1, "autem" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 6L, "Aut qui delectus ut quos omnis veniam magnam.", new DateTime(2023, 8, 4, 2, 38, 2, 493, DateTimeKind.Utc).AddTicks(9106), 15L, "Beatae vel facilis officiis ipsum at.", "Reiciendis in amet corporis enim.", 2L, "", 0, "Possimus ipsa non aliquam quo provident quis perferendis. Voluptatibus facilis perferendis expedita ea eum error. Repellendus recusandae harum ratione ullam veniam tempora sit." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 43L, "Doloribus provident totam.", new DateTime(2023, 9, 4, 3, 19, 31, 991, DateTimeKind.Utc).AddTicks(6752), 40L, "Aut explicabo aut sunt reiciendis voluptate iusto. Quibusdam temporibus quas commodi. Voluptatibus tempore saepe nesciunt recusandae neque ut dicta. Vel qui cumque enim.", "Et perferendis exercitationem id soluta blanditiis sunt enim.", 2L, "", 2, "Blanditiis omnis nihil molestiae suscipit inventore non. Recusandae odit voluptatum neque. Suscipit nemo sed doloremque aut minima et pariatur natus. Est omnis quasi aut ut qui aut. Quia aliquam voluptatem et ipsam distinctio." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 57L, "Aliquid harum consequatur quia aperiam est ipsa cupiditate enim. Quisquam nesciunt qui harum dicta molestias error. Voluptatibus officiis impedit quas dolorem dignissimos aut dolore.", new DateTime(2023, 6, 7, 10, 8, 0, 950, DateTimeKind.Utc).AddTicks(519), 15L, "Ut numquam expedita.\nHarum voluptatem repellat fugiat vel animi libero dolor.\nIpsa omnis nesciunt vitae.", "Facere nobis vel possimus.", 2L, "", "Asperiores dolorem sint dolores consequuntur eos vel." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 66L, "officia", new DateTime(2021, 12, 6, 20, 32, 1, 685, DateTimeKind.Utc).AddTicks(4547), 27L, "dolor", "Et non odit tempore qui.", 1L, "", "Et consequatur assumenda eius. Accusamus aut ducimus aut et tempore rerum illum sint debitis. Delectus inventore delectus eum voluptates. Iste aut modi numquam non aliquid velit quibusdam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 17L, "Non at dolorum. Et consequatur rerum asperiores placeat. Blanditiis aperiam dolor sed saepe.", new DateTime(2023, 3, 10, 8, 39, 23, 672, DateTimeKind.Utc).AddTicks(8984), 23L, "Dignissimos quas delectus dolores voluptatem eius suscipit incidunt beatae. Nisi quis odit explicabo ipsa blanditiis voluptatibus. Voluptas a voluptatem eligendi odit veritatis aut ad. Magnam praesentium eligendi consequuntur est rerum. Assumenda et et. Similique quibusdam quaerat rerum sapiente voluptatem cupiditate.", "Sed voluptatibus repellat sint reprehenderit ea distinctio atque impedit amet.", 2L, "", 1, "Velit aliquid accusantium itaque.\nEum doloribus nemo velit modi id quas nisi iste consectetur.\nOptio non mollitia laborum hic et quia hic.\nFacilis perspiciatis aut numquam sequi.\nPossimus fugiat perferendis mollitia accusamus eaque deserunt accusamus temporibus.\nQuos laborum nam aliquam et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 41L, "Voluptas maiores omnis dicta est eum odio eligendi facilis quasi.", new DateTime(2022, 3, 15, 18, 16, 23, 570, DateTimeKind.Utc).AddTicks(7456), 35L, "Corporis quae inventore soluta magnam quam iste.\nCumque molestias sit quaerat eveniet exercitationem qui aperiam quia et.", "Sunt nam earum non facere.", 2L, "", 3, "Et ea aut provident cumque soluta." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 64L, "Labore pariatur voluptatem nemo.", new DateTime(2020, 10, 22, 16, 53, 59, 367, DateTimeKind.Utc).AddTicks(8916), 8L, "Impedit rerum error nemo magni possimus veritatis occaecati dolores non.\nSequi quas cumque dignissimos necessitatibus voluptatibus et cumque molestias.\nPariatur praesentium distinctio.\nHic provident enim facilis suscipit assumenda nisi laborum optio quia.\nMollitia assumenda ab quibusdam at hic quidem quo aperiam accusamus.\nNam culpa ab quisquam et qui blanditiis autem vero.", "Sit omnis repudiandae.", 1L, "", 1, "Earum cumque ea." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 67L, "ducimus", new DateTime(2023, 8, 9, 11, 35, 2, 731, DateTimeKind.Utc).AddTicks(6732), 30L, "Facilis id ad amet eaque ea aspernatur veniam. Eveniet rerum eum ut ipsam aut animi. Culpa voluptas mollitia et id quibusdam veritatis et voluptatem. Rerum fugiat aut ea id ex magnam dolorum eligendi. Enim eum numquam sapiente temporibus molestiae. Dolorum earum explicabo.", "Debitis neque omnis totam ut aut culpa provident exercitationem.", 2L, "", 0, "Numquam placeat et consequuntur. Et eligendi deserunt laborum. Cupiditate nesciunt et ut molestiae eligendi blanditiis accusamus sunt. Architecto voluptatum tenetur. Voluptas repellat dicta ab possimus quas blanditiis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 70L, "Odio quos nisi accusantium et eligendi.\nSit corrupti placeat fugit harum minima.\nQuod dignissimos vero illo consequatur eligendi soluta commodi non.\nVoluptatem nam quo.", new DateTime(2023, 6, 23, 22, 19, 32, 615, DateTimeKind.Utc).AddTicks(349), 15L, "Delectus sit officiis. Voluptatibus et aut animi consequatur atque magni earum quia dolor. Itaque laborum non voluptatem. Aut in provident culpa ex dolorum omnis odio. Aut inventore id similique velit. Rerum ipsa blanditiis aspernatur rerum repellat distinctio.", "Quia officia et earum non iure necessitatibus.", 1L, "", 1, "Earum harum quas laboriosam corrupti natus ad sint dignissimos beatae. Aut quaerat consequuntur voluptatum sunt nemo explicabo. Assumenda non fugiat sunt." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 7L, "Aut error quibusdam.\nEt ea aspernatur sed dolore.\nNihil reprehenderit autem repudiandae qui modi eveniet nesciunt.\nVoluptatem quo odio vitae ut eos doloribus pariatur sed.\nVoluptas necessitatibus velit quia molestias iusto doloremque ratione placeat.", new DateTime(2021, 2, 4, 15, 2, 17, 755, DateTimeKind.Utc).AddTicks(9686), 1L, "Quasi eum mollitia assumenda sequi ut. Rerum officia amet modi modi omnis recusandae. Natus omnis consequuntur vel rerum ullam unde qui est.", "Animi deserunt eius.", 2L, "", "Praesentium esse dolorum sunt ab doloribus vero iusto autem. Veritatis illum aliquid aliquid provident atque quaerat nesciunt. Excepturi error optio deleniti consequatur aut enim et. Omnis beatae ratione suscipit explicabo voluptatum. Accusantium praesentium delectus dicta alias." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 57L, "voluptate", new DateTime(2023, 9, 6, 17, 28, 43, 312, DateTimeKind.Utc).AddTicks(1883), 5L, "ad", "Quidem occaecati totam.", 1L, "", "Impedit sunt alias adipisci natus voluptatem accusamus. Corrupti sunt est voluptate enim. Est numquam neque cupiditate aut officiis necessitatibus inventore qui non. Occaecati unde cumque facere cupiditate cupiditate fugiat." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 65L, "Architecto rerum debitis perspiciatis laborum. Dolor voluptatum animi ipsa animi dolorem et delectus. Vel voluptatem eaque praesentium et sit illo. Cupiditate sit enim ducimus voluptatibus sequi nihil. Repellendus temporibus et ducimus rerum a animi distinctio omnis. Voluptate quas rerum reiciendis est sed facilis pariatur.", new DateTime(2022, 3, 11, 22, 18, 41, 520, DateTimeKind.Utc).AddTicks(3567), 39L, "Iusto dicta laborum distinctio nesciunt enim sed.", "At dolorum laborum esse quis rerum omnis.", 1L, "", 2, "Corporis aut et sit ut aliquid cupiditate nisi.\nAdipisci voluptatem saepe veniam.\nAutem alias sint molestiae at distinctio autem cumque ipsum.\nOmnis deserunt unde sit voluptatem et dolores mollitia vitae doloremque.\nSoluta culpa molestiae nostrum id beatae." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 32L, "Est consequatur aliquam.", new DateTime(2023, 8, 14, 17, 38, 40, 251, DateTimeKind.Utc).AddTicks(8041), 34L, "Iure sit aperiam tempore non necessitatibus sed soluta rerum maxime. A sed et aut quia qui autem. Et voluptate dolorem et eligendi. Nostrum blanditiis eum. Ducimus sed voluptatem non eum. Quia neque id at fugiat eligendi.", "Itaque asperiores totam possimus aut adipisci adipisci.", 2L, "", 3, "Nihil sunt harum dolore qui inventore voluptatem id." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 67L, "commodi", new DateTime(2023, 1, 29, 0, 48, 31, 773, DateTimeKind.Utc).AddTicks(1670), 28L, "Id reprehenderit iusto perspiciatis iusto molestiae.\nVel impedit sapiente voluptate cupiditate non odit quo.\nLibero at voluptates consectetur aut soluta.\nDignissimos voluptas tempore reprehenderit nemo.\nEst qui aut non in a dolor perferendis voluptate.\nCumque reprehenderit et asperiores aut mollitia.", "Ducimus cumque itaque.", 2L, "", 0, "Occaecati natus ea laboriosam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 47L, "Occaecati recusandae qui nemo deserunt magni. Expedita commodi quaerat qui. Quibusdam earum est vel.", new DateTime(2020, 12, 22, 3, 10, 42, 468, DateTimeKind.Utc).AddTicks(8365), 29L, "Sint non atque.", "Atque est qui nihil illo eaque asperiores nihil.", 1L, "", "Ea fuga cum aperiam suscipit vel sed aut. Qui voluptatem nihil rerum nam asperiores perspiciatis inventore fugiat nostrum. Illum aut accusantium qui." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 8L, "Consequatur perspiciatis aut qui harum perspiciatis omnis.\nUt deleniti mollitia vero natus corporis et enim corrupti.\nAtque officiis repellat animi maiores modi cumque.", new DateTime(2017, 12, 19, 14, 59, 15, 614, DateTimeKind.Utc).AddTicks(8274), 38L, "Distinctio harum sint deleniti sint modi ut consequuntur dicta.", "Est voluptas ut aut molestiae reprehenderit nesciunt dolore.", 2L, "", 2, "doloremque" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 43L, "sed", new DateTime(2023, 8, 28, 5, 15, 7, 908, DateTimeKind.Utc).AddTicks(5161), 17L, "Qui aliquam mollitia voluptate illo eveniet ex.", "Quia maiores laboriosam et.", 1L, "", "Totam iste non.\nCulpa eligendi voluptatum sint amet eveniet et.\nVitae vel rerum vitae saepe ratione ea aut quis.\nAb praesentium repellendus ab porro.\nNon corporis quod asperiores et corrupti perferendis ea aut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 67L, "Dolore et mollitia consequatur. Architecto atque mollitia aut unde. Officiis repellat error molestiae sapiente aut sed aut eos. Qui sit eum eum at quaerat quidem sit quam. Laborum cupiditate eveniet est iusto dolores labore. Ut nobis autem aliquam ex aut.", new DateTime(2023, 1, 6, 15, 43, 49, 138, DateTimeKind.Utc).AddTicks(6659), 15L, "Ut voluptas sed nihil vel nulla in.", "Ut et expedita amet molestias facere est non aut expedita.", 2L, "", 0, "Consectetur nisi similique et ut officiis maxime." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 10L, "Nostrum qui omnis.\nId omnis molestias.\nProvident qui nihil asperiores.", new DateTime(2022, 12, 5, 4, 12, 41, 763, DateTimeKind.Utc).AddTicks(2241), 28L, "Et molestias quis iure vel quos rerum consequatur.", "Asperiores laudantium accusamus cumque voluptas qui qui rem nam hic.", 2L, "", 3, "Nam ea porro sapiente voluptate ad ut aut asperiores.\nAut nostrum asperiores ab labore vel voluptatem beatae maxime.\nConsequuntur eaque saepe molestiae in deserunt dolor.\nMinus dolorem impedit ut et animi.\nVoluptatem ut omnis itaque autem rerum aliquid natus eius.\nAtque sint vitae nostrum sint soluta repudiandae repellendus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 56L, "Voluptatum cum et sunt beatae cumque quia illum corrupti. Ducimus sit non quia facere hic dolorem consequuntur ullam. Voluptatibus minus dicta. Aut sed quo enim laboriosam non est fugiat tempore. Sequi eum atque exercitationem id autem impedit omnis laboriosam laboriosam.", new DateTime(2018, 7, 30, 20, 45, 47, 968, DateTimeKind.Utc).AddTicks(4445), 24L, "et", "Reiciendis culpa totam qui.", 2L, "", 2, "Totam quasi tempora et ullam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 17L, "et", new DateTime(2023, 7, 21, 21, 40, 33, 9, DateTimeKind.Utc).AddTicks(1438), 1L, "Assumenda dicta impedit voluptates facere dolor quia aspernatur.", "A et eos deleniti ad.", 1L, "", "Et laudantium officiis.\nMolestias aliquid molestiae reprehenderit placeat voluptas." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 33L, "Ratione velit consequatur aliquid nulla est dolorem nemo.", new DateTime(2023, 1, 2, 18, 50, 5, 464, DateTimeKind.Utc).AddTicks(6144), 3L, "Iusto sed recusandae laborum nobis. Et laborum culpa. Ex voluptas et sint omnis eius quisquam. Ut atque consequuntur doloremque molestiae minus inventore qui impedit.", "Nulla architecto et ipsam consequatur nobis et quae corporis dolorem.", 1L, "", "omnis" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 8L, "similique", new DateTime(2021, 11, 7, 6, 31, 2, 237, DateTimeKind.Utc).AddTicks(8404), 10L, "Est sed iste nostrum voluptatem soluta. Placeat iusto illo fuga. Qui fuga quisquam veniam dolorem ea.", "Quae quis voluptatem et iusto et eos natus.", 2L, "", 1, "Velit non quae.\nVel doloribus incidunt." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 27L, "Beatae architecto qui et delectus perspiciatis.", new DateTime(2022, 10, 11, 1, 0, 50, 643, DateTimeKind.Utc).AddTicks(2473), 21L, "Explicabo qui eum a accusantium.", "Voluptatibus et dolores.", 2L, "", 1, "Voluptas qui debitis accusamus illum quaerat a qui accusantium quasi." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 4L, "Voluptas culpa quae dolore facilis aut.", new DateTime(2023, 4, 5, 20, 49, 40, 624, DateTimeKind.Utc).AddTicks(5253), 24L, "sint", "Unde voluptas ullam ex voluptatibus aut voluptatum quia vitae.", 2L, "", 3, "Et quo aut ea quaerat dolore et aut voluptatem dolorem. Ex voluptatem alias sit aut occaecati et reiciendis deserunt. Saepe laboriosam rerum est voluptatibus dolore repudiandae. Ullam ea quo rerum aliquid iure fugiat possimus itaque. Minus itaque mollitia." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 39L, "Autem veritatis tempore minima repellat tenetur aspernatur.", new DateTime(2023, 2, 11, 5, 11, 20, 831, DateTimeKind.Utc).AddTicks(9521), 8L, "Non et perspiciatis quaerat unde reprehenderit qui et hic est.\nSed sit facere.", "Consequuntur et temporibus ipsa.", 1L, "", 1, "Rem libero et.\nNisi culpa consequatur et et tenetur.\nNihil laboriosam quidem nesciunt libero velit quidem quia.\nMolestiae voluptas rerum nulla praesentium.\nUt illum id maiores dolores et sequi quas." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 6L, "Quo veritatis consequatur impedit maiores.", new DateTime(2023, 8, 24, 2, 58, 29, 791, DateTimeKind.Utc).AddTicks(6933), 16L, "Aut dolorum voluptas fuga sint ut et quia tempora est.\nSoluta beatae nostrum aspernatur iusto nihil quam.\nExcepturi aut in occaecati illum est in.\nSuscipit minus et omnis eum vitae quaerat officia repellendus.\nVoluptate ut vel cupiditate est velit.\nRerum totam voluptatem reiciendis earum quis.", "Assumenda ipsa est enim doloribus quas libero blanditiis.", 2L, "", 0, "Autem qui dolores. Molestias ut ut. Voluptate incidunt aperiam rerum qui voluptas hic molestiae. Ipsum voluptatem incidunt enim. Quisquam asperiores quos." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 21L, "Animi qui cumque ipsam ut perferendis ducimus dolorem.\nLaboriosam autem illo quia eius dolore eum reprehenderit ducimus non.", new DateTime(2023, 3, 5, 14, 20, 11, 133, DateTimeKind.Utc).AddTicks(734), 35L, "voluptas", "Aut hic itaque sint ut laudantium dignissimos.", 1L, "", "Cumque qui illo soluta sint rem qui quo." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 30L, "Nesciunt ab omnis porro enim quo architecto.", new DateTime(2021, 2, 21, 22, 22, 13, 679, DateTimeKind.Utc).AddTicks(8064), 12L, "nemo", "Et ipsam iste et ut.", 2L, "", 3, "Aut eveniet nihil est harum qui perspiciatis asperiores. Molestiae aut et possimus ut. Repudiandae unde voluptas magni autem. Quisquam enim officiis eveniet et quod facere sit quia. Sit cum animi non ut et harum asperiores eos aut. Rerum totam sint aliquam exercitationem ut consequatur ex." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 8L, "Nemo vel consequatur sint.\nUt consequatur eius beatae voluptas ea rerum suscipit sed.\nDolorem sapiente soluta laudantium aliquam omnis.", new DateTime(2019, 10, 10, 13, 55, 57, 245, DateTimeKind.Utc).AddTicks(8210), 21L, "maxime", "Facere alias quo autem vel quia itaque.", 1L, "", 2, "Debitis doloribus voluptatem numquam qui.\nNon fugiat accusantium eos incidunt maiores.\nEt sed animi illo fuga." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 10L, "sequi", new DateTime(2022, 8, 19, 9, 59, 46, 455, DateTimeKind.Utc).AddTicks(5326), 26L, "eos", "Dolore quaerat eius aut qui libero repellat et ipsa dolor.", 1L, "", 1, "Ipsam cupiditate et velit ut qui voluptatum porro." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 54L, "Sed possimus deleniti eveniet modi similique molestiae libero.\nTotam perspiciatis perferendis excepturi non sed.\nEst aliquam labore ea corrupti.\nBlanditiis deleniti ut error qui.\nEt similique qui.\nVoluptate omnis excepturi eum eum corporis.", new DateTime(2023, 2, 16, 17, 30, 28, 898, DateTimeKind.Utc).AddTicks(5427), 15L, "Vitae eum facere aliquam quod dolorem minus. Voluptas a sit deserunt est. Nostrum consequatur ratione earum voluptatum eius. Nihil laborum doloribus esse sit corrupti quia quidem illo illo. Neque et est officia porro dicta rerum voluptas quaerat.", "Quia quidem aut fugiat consectetur ut et ab maxime.", 2L, "", "Dolores ad vero explicabo. Quia nam voluptatem voluptatem minima corrupti quia et non. Corporis alias omnis distinctio sed eum omnis molestiae perferendis eos. Minus perferendis minus ut totam laboriosam eum. Asperiores asperiores animi iure. Et temporibus eveniet rerum quis sapiente vitae." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 28L, "corporis", new DateTime(2023, 1, 15, 16, 19, 29, 931, DateTimeKind.Utc).AddTicks(2051), 18L, "Molestiae numquam assumenda nihil explicabo. Ullam ratione a. Rerum amet et assumenda consectetur. Est neque labore. Cupiditate vel temporibus enim qui a dolore ut doloribus est. Ut non perferendis eius molestiae nihil est eum facere voluptas.", "Voluptatum aliquid voluptatum vel.", 1L, "", 1, "Autem assumenda omnis quo voluptate laboriosam laborum quo." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 45L, "Quo et nihil dolores aut dolores vel veritatis nesciunt nemo.\nAut expedita animi unde ut.\nConsequuntur omnis atque architecto consequatur.\nOdio voluptas labore vel dolor sit.", new DateTime(2023, 5, 1, 3, 56, 18, 420, DateTimeKind.Utc).AddTicks(4943), 17L, "Expedita quasi harum explicabo animi.", "Quasi numquam voluptas voluptas.", 1L, "", 2, "Nihil perspiciatis dolor id et non.\nDolore itaque dolor repellat dicta maiores blanditiis molestiae ut.\nHic accusantium porro omnis veritatis repudiandae rem.\nMaiores expedita rerum quia.\nIpsa et et maiores omnis fugit nihil rerum.\nExplicabo ea non unde exercitationem consequatur suscipit blanditiis eum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { "In sit non. Dolore sint dolorum aut eos. Enim voluptas quae voluptatibus ut et voluptate. Adipisci atque quo ut magnam ut. Animi magnam iste officiis. Praesentium deleniti et sequi beatae necessitatibus cumque id.", new DateTime(2023, 4, 28, 10, 52, 14, 671, DateTimeKind.Utc).AddTicks(2411), 27L, "Impedit sit ea aperiam non reprehenderit quia.\nUt veritatis tempora fugit quasi temporibus eum saepe.", "Quia molestiae ullam id dolores qui repellat.", 2L, "", 0, "Aut est ut maiores veniam autem debitis ipsam voluptas." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 70L, "Recusandae autem et sunt nulla assumenda ipsum placeat.", new DateTime(2023, 3, 9, 0, 52, 31, 348, DateTimeKind.Utc).AddTicks(8607), 28L, "Impedit culpa hic vel molestiae sint dolores.", "Rem aut repellat voluptatem quaerat.", 2L, "", 1, "sapiente" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 39L, "Ut maiores ut modi sit.\nQui eos quia at illo voluptatem est cupiditate.\nSunt ut voluptas voluptatum id occaecati aut omnis.\nVoluptatem velit enim.\nConsequatur exercitationem dolor itaque temporibus dolore.\nQui rerum eligendi voluptatum corporis nulla omnis natus.", new DateTime(2022, 2, 15, 22, 16, 3, 130, DateTimeKind.Utc).AddTicks(7121), 25L, "necessitatibus", "Culpa ea vero corporis eaque nam dolores.", 2L, "", 0, "Officia suscipit in laudantium voluptatem.\nSed amet vel sequi non.\nSapiente est ut eligendi at dolorem.\nSed provident cupiditate nulla sit nobis expedita quis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 28L, "voluptate", new DateTime(2023, 8, 16, 18, 42, 12, 504, DateTimeKind.Utc).AddTicks(6733), 3L, "qui", "Reiciendis officiis ut reiciendis aut id animi et cupiditate.", 1L, "", 3, "Sequi cumque id itaque suscipit qui veritatis quos dolore dolor.\nVitae accusantium exercitationem pariatur est quae et a.\nQuis qui enim pariatur accusamus eum non explicabo voluptatem.\nAd molestiae quam eius.\nVoluptatem vel tempora ad enim possimus corrupti fuga.\nIpsam est impedit nemo qui sint eos perspiciatis assumenda." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 7L, "Nobis doloremque rerum adipisci omnis provident ratione. Fuga molestias ea aut minus sequi laboriosam harum. Officiis molestiae neque quia voluptatum repellendus. Cupiditate aliquam qui inventore eveniet. Repellat consequuntur voluptatem hic vitae illo cumque eos. Ex sint minima ipsum praesentium assumenda sunt est in.", new DateTime(2021, 11, 23, 16, 31, 5, 909, DateTimeKind.Utc).AddTicks(7088), 36L, "Et similique tempore exercitationem.", "Ut ipsum aut quas minus nam consequatur natus qui.", 2L, "", "Nesciunt quo et expedita." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 64L, "Sunt et ipsa.", new DateTime(2020, 11, 14, 9, 16, 13, 909, DateTimeKind.Utc).AddTicks(612), 1L, "Quaerat distinctio nobis officiis vel.\nTotam perspiciatis voluptate fugiat.\nNostrum hic quos in doloribus quas ipsa.\nEveniet cum exercitationem esse.", "Eligendi dolor quasi veniam recusandae.", 1L, "", 3, "Perspiciatis et atque consequatur minus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 66L, "Quibusdam corrupti neque voluptate ut perferendis autem illo aperiam.", new DateTime(2023, 1, 24, 11, 12, 14, 563, DateTimeKind.Utc).AddTicks(9277), 1L, "Modi minus laudantium. Qui asperiores qui voluptatum consequatur necessitatibus. Similique dignissimos aut amet magni. Est eveniet perspiciatis. Quia ipsam odio distinctio in laborum laborum ab autem rerum. In eligendi sunt possimus.", "Earum ex illo exercitationem modi sit aperiam aspernatur velit.", 2L, "", 0, "Eligendi deleniti nobis laborum delectus et blanditiis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 7L, "Quasi ex eos sit esse accusantium vel debitis eum. Nihil sunt magnam. Asperiores placeat provident.", new DateTime(2020, 6, 28, 8, 56, 53, 192, DateTimeKind.Utc).AddTicks(7972), 6L, "Ut accusantium amet numquam iste accusamus dolorem.\nOmnis iste laboriosam tempore.\nNon quidem non.", "Libero id adipisci quia eaque qui nihil.", 1L, "", 1, "Architecto animi debitis eveniet reprehenderit ut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 37L, "blanditiis", new DateTime(2022, 4, 28, 13, 57, 17, 977, DateTimeKind.Utc).AddTicks(1933), 31L, "Rerum architecto aut modi ex sunt architecto. Est velit dolor hic vitae quas accusantium ut nam eos. Vel minus in. Soluta non consequatur reprehenderit eveniet praesentium et.", "Ab asperiores ea nesciunt ipsum.", 1L, "", "Dolor ad laboriosam ex non quia sit vel.\nEst velit reiciendis sunt possimus a iure et quis labore.\nEa sed velit magnam reiciendis adipisci.\nIn cumque aut assumenda aut vitae harum necessitatibus voluptas." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 29L, "Velit sint accusantium nobis.", new DateTime(2021, 2, 13, 4, 33, 16, 820, DateTimeKind.Utc).AddTicks(3060), 19L, "Unde blanditiis exercitationem nostrum aliquid optio dolor dignissimos dolor. Ut maiores enim. Et sapiente assumenda aut. Voluptatum odio ut quam omnis ut voluptatem sunt voluptas ipsum. Dolores est inventore repudiandae placeat sint sunt id. Laudantium est pariatur vel fugit est eaque autem.", "Eum eveniet inventore neque ut.", 1L, "", 1, "Quis tempora voluptatibus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 70L, "Rerum ut molestiae qui.", new DateTime(2022, 11, 29, 8, 11, 0, 851, DateTimeKind.Utc).AddTicks(1666), 34L, "et", "Nihil quam enim aperiam provident reprehenderit doloremque est suscipit.", 2L, "", 1, "Officiis dolorem aut praesentium facere deserunt at corporis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 1L, "Odit aut reiciendis et.\nDucimus nostrum architecto voluptate tempore eum blanditiis minus.\nNon vitae est eveniet nihil sapiente.", new DateTime(2023, 1, 2, 1, 21, 0, 477, DateTimeKind.Utc).AddTicks(9247), 6L, "Omnis fugit labore magni accusantium quasi. Tempora sit et. Nihil amet ut. Ex debitis vero laboriosam hic in recusandae ut omnis. Ut unde labore est expedita nulla qui omnis porro voluptates.", "Eos quidem quos odio aut iste non tempore vero iure.", 1L, "", 1, "Et voluptatem at voluptatem tenetur. Animi consequatur perferendis et dolores consequatur. Ut quis assumenda in necessitatibus rerum blanditiis sapiente distinctio. Voluptatem dolores nobis officia dolore corrupti sequi minima sit molestiae. Quasi est vel magni laboriosam est aut nemo illum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 31L, "Architecto consequatur qui molestiae a et facilis voluptas voluptas numquam.\nQuia possimus occaecati eos in cum.", new DateTime(2023, 8, 16, 9, 23, 56, 841, DateTimeKind.Utc).AddTicks(6973), 10L, "Velit nulla quia.", "Sed corrupti dolorem.", 1L, "", 0, "Voluptatem totam ex commodi nisi occaecati minus magni et autem." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 56L, "et", new DateTime(2020, 2, 29, 9, 25, 34, 273, DateTimeKind.Utc).AddTicks(6389), 32L, "Explicabo ipsam distinctio enim consequuntur velit libero consequuntur aliquam vero. Facilis quibusdam magnam consequatur repudiandae voluptate porro rerum molestiae nisi. In et molestiae qui quisquam. Corrupti placeat dignissimos qui veniam dignissimos veniam magni pariatur. Sed dolor dolorum reiciendis iste voluptatum nihil quibusdam voluptas dolores. Id quia dolorem sapiente sit.", "Et debitis et voluptatem provident amet quis est.", 2L, "", 2, "Sapiente voluptatum porro dignissimos odit voluptates tempora quis. Totam in eos minima voluptas et ipsa molestiae autem. Excepturi quaerat et deserunt quis aut. Suscipit ea dignissimos rerum maxime et est provident rerum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 16L, "quam", new DateTime(2022, 10, 16, 4, 23, 30, 968, DateTimeKind.Utc).AddTicks(335), 19L, "facilis", "Est eveniet quidem molestias velit aliquid ea ex ut ut.", 1L, "", 2, "Consequatur quod aspernatur odio consequuntur corporis tempora molestias facere.\nAd fuga hic et corrupti reprehenderit illo facilis.\nQuos est laboriosam ab.\nQuasi iusto corrupti.\nDoloremque tempore cumque similique quaerat cupiditate ad." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 57L, "vitae", new DateTime(2022, 7, 16, 8, 25, 13, 270, DateTimeKind.Utc).AddTicks(1427), 20L, "quis", "Aut eos qui velit iste deleniti nulla aut omnis laudantium.", 2L, "", "eligendi" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 1L, "Ipsum molestiae nisi accusantium recusandae quae.", new DateTime(2023, 4, 29, 10, 25, 41, 56, DateTimeKind.Utc).AddTicks(2212), 30L, "Dignissimos dolore commodi. Maiores cupiditate et voluptas et aut a. Commodi voluptatibus doloremque ab aspernatur enim.", "Impedit consequatur molestiae cupiditate et placeat optio molestiae blanditiis accusantium.", 1L, "", 0, "distinctio" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 53L, "Maiores ad et eos quo. Officia voluptatem et est numquam et reiciendis quae ut asperiores. Ut in explicabo. Optio tempore voluptas et a eos maiores aut laborum. A qui ipsa repellat possimus voluptatibus.", new DateTime(2023, 5, 21, 5, 57, 26, 573, DateTimeKind.Utc).AddTicks(9921), 27L, "aut", "Odit accusantium nam aut et exercitationem quam.", 1L, "", "Nihil molestiae enim molestiae nemo est. Dolorum voluptatibus expedita. Architecto nihil excepturi totam. Animi modi rerum facere eaque. Voluptatem illum ut aliquam cum itaque quae." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 34L, "Nemo sed enim sunt quo sequi.", new DateTime(2023, 3, 26, 16, 1, 47, 715, DateTimeKind.Utc).AddTicks(3420), 14L, "Saepe sunt deleniti a.\nTempore dolorem aut voluptas reiciendis et rem aperiam vel.\nQuasi similique alias laborum eius.\nBeatae cumque sit.\nMaxime labore pariatur qui voluptatem et sunt.\nEum consequatur voluptas quia temporibus ipsa quia et necessitatibus dicta.", "Placeat provident necessitatibus voluptates et alias.", 2L, "", 3, "Voluptate illum omnis quos distinctio ab recusandae aut sunt. Est beatae sit exercitationem voluptas ut ut at est. Nulla autem animi optio esse a quisquam commodi. Sit maiores magnam vel eveniet." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 61L, "reprehenderit", new DateTime(2023, 7, 5, 3, 2, 23, 780, DateTimeKind.Utc).AddTicks(3854), 39L, "Veritatis unde libero atque est aut.", "Sit et eveniet odit harum beatae vel iure.", 2L, "", 3, "et" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 1L, "provident", new DateTime(2023, 4, 22, 2, 11, 16, 976, DateTimeKind.Utc).AddTicks(1578), 36L, "Deleniti voluptatem et. Voluptate nobis quo ratione quia totam itaque dolorum pariatur. Qui libero ullam quo facilis impedit voluptatem sed quae perferendis. Dolores laboriosam laborum neque. Autem aut quibusdam libero nihil ut quis ipsa ut.", "Amet doloribus quisquam pariatur cum velit quisquam dolorem non.", 2L, "", 0, "Nemo adipisci autem inventore in." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 31L, "Delectus minima reiciendis quam id ad nisi aut voluptatibus cupiditate.", new DateTime(2023, 4, 28, 11, 38, 22, 388, DateTimeKind.Utc).AddTicks(7387), 35L, "At eum quaerat ducimus. Nihil dolores ipsam quos quam ea et et et praesentium. Est et consequatur.", "Nulla quas quam quis nihil possimus nobis.", 2L, "", "delectus" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 67L, "Labore molestiae minima fugiat sapiente atque.", new DateTime(2023, 5, 27, 13, 58, 55, 825, DateTimeKind.Utc).AddTicks(5284), 20L, "Accusamus amet ut sapiente quae excepturi rerum. Exercitationem aut nulla. Est consequatur tempore repellendus eveniet deleniti. Aut qui non repudiandae nisi id dolores reprehenderit.", "Eum et aperiam commodi praesentium harum voluptatem quia ut sint.", 2L, "", 0, "Nihil eos cupiditate voluptatum in suscipit perferendis deleniti. Et excepturi dolorem blanditiis provident et aspernatur hic aperiam. Suscipit corporis est est dolores perspiciatis qui sed provident." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 70L, "Aut dolores quia. Quia beatae quia accusamus nam corporis. Magni blanditiis illo. Ad consequatur tempora voluptates quia tenetur aut nesciunt. Ut consectetur nostrum dolorem eaque cum voluptas.", new DateTime(2023, 9, 6, 1, 4, 5, 188, DateTimeKind.Utc).AddTicks(235), 13L, "Laudantium aut et suscipit autem tempora perferendis repellendus sequi.", "Ea rerum quidem odit similique.", 2L, "", "Deleniti porro officia aut non inventore et veritatis quis eum.\nVoluptatum eum corporis voluptatibus commodi aut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 35L, "Aspernatur possimus ea maiores amet. Sunt doloribus aut est fugiat et vel autem. Excepturi enim voluptates tempora ullam vero aut dolores. Qui eaque soluta voluptatibus rerum. Voluptate eius ipsa consequatur optio totam et quibusdam ut neque. Maiores odio exercitationem soluta sapiente error.", new DateTime(2023, 5, 20, 11, 44, 4, 582, DateTimeKind.Utc).AddTicks(1553), 3L, "Sed rerum assumenda voluptatum temporibus sint blanditiis voluptate. Omnis occaecati sed impedit quia. Perspiciatis qui ipsum qui rerum unde aut. Iure consectetur autem. Quia aut quia id quidem. Quia inventore ea corrupti tempore sed architecto.", "In earum nobis quia optio at inventore.", 2L, "", 0, "Qui ratione nam occaecati. Doloribus quaerat ipsa aliquam ratione asperiores. Ut saepe veniam laborum sunt quis aspernatur. Eos rem earum veritatis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 3L, "sunt", new DateTime(2023, 9, 6, 11, 3, 12, 148, DateTimeKind.Utc).AddTicks(1476), 39L, "Iure voluptatem non illo voluptatem ut maxime placeat veritatis doloribus. Sit aliquid ea. Architecto sit dicta impedit similique. Sed et eum aut eum. Quo possimus consectetur ut. Ipsum ut alias.", "Iure voluptatibus dolore non sed saepe et incidunt sed.", 2L, "", 3, "Repellat labore magni exercitationem illo." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 25L, "Inventore fugit delectus labore ipsam error sit veniam eum tenetur. Voluptas voluptates asperiores officiis voluptatem saepe neque qui ea. Eaque nemo sed repellendus dolore necessitatibus. Nam quaerat illo qui. Necessitatibus cumque beatae alias accusamus at suscipit.", new DateTime(2023, 5, 15, 2, 32, 3, 204, DateTimeKind.Utc).AddTicks(5369), 25L, "Neque ut nihil velit soluta enim nesciunt. Repellendus distinctio dolor non provident voluptatem. Consequatur qui adipisci iure nesciunt et culpa consequatur animi error. Quam molestiae eum ut enim et magni ut.", "Deleniti illo velit similique ab.", 2L, "", 2, "Et sed nesciunt velit corrupti sit dolor cum. Atque amet deleniti sit aut nulla blanditiis quasi cum aperiam. Quia eveniet ipsam sequi sit nostrum autem. Voluptatem nemo fugit. Repudiandae vel iure sint fuga fugiat ea." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 3L, "Et iusto quia.", new DateTime(2023, 8, 27, 5, 53, 55, 715, DateTimeKind.Utc).AddTicks(4934), 11L, "Non quibusdam et corrupti aut laborum sequi maxime et voluptas. Libero et voluptatem aut et sunt amet. Beatae dolores laboriosam est et quo accusantium aut cupiditate.", "Eos id cupiditate blanditiis aut maiores pariatur.", 2L, "", 1, "Culpa animi dolorem nulla quae at incidunt qui unde iure.\nEt asperiores quis sed ad temporibus officia et.\nAb inventore voluptates autem culpa." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 50L, "Autem quis accusantium voluptatem.", new DateTime(2023, 9, 8, 18, 17, 34, 134, DateTimeKind.Utc).AddTicks(9134), 38L, "vitae", "Quis placeat voluptatem incidunt repellat.", 2L, "", 1, "tempore" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 14L, "Et enim accusamus quis est tempora maxime eos consectetur rem.\nNihil ut fuga mollitia sint ex at dignissimos nulla quia.", new DateTime(2023, 1, 29, 17, 1, 25, 884, DateTimeKind.Utc).AddTicks(1703), 31L, "Aut amet quia omnis harum asperiores. Nisi ratione fuga. Ea ut dolorem dignissimos delectus voluptatum aspernatur rerum sit. Rem qui placeat deleniti distinctio vero temporibus aliquam animi quasi.", "Accusamus voluptatem ducimus est omnis minus.", 1L, "", 3, "Rerum et animi officiis blanditiis eius est quas id. Cupiditate impedit sit eum vel vero. Nulla quia laudantium. Est ut non." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 13L, "dignissimos", new DateTime(2018, 7, 19, 0, 2, 27, 935, DateTimeKind.Utc).AddTicks(4692), 3L, "Molestiae delectus architecto dignissimos velit animi.\nQuasi aut eos quaerat dicta perspiciatis.\nAt sed dolorem inventore consequuntur odio provident.\nIpsum ut recusandae ut.\nCupiditate eaque nihil eius velit.", "Rerum necessitatibus porro veniam ipsa ut incidunt.", 2L, "", 2, "quidem" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 37L, "Est cum quis labore quasi in laudantium veniam saepe eius.\nIpsum excepturi quia dolore itaque aperiam omnis sint veritatis.", new DateTime(2023, 5, 5, 3, 27, 32, 64, DateTimeKind.Utc).AddTicks(6508), 10L, "Sapiente in ipsam voluptas similique nesciunt voluptatem officiis. Repudiandae labore et. Exercitationem non fuga sunt. Ut sed ad voluptas nemo explicabo corrupti unde consequuntur.", "Ex quo quasi officiis repudiandae.", 2L, "", 3, "Et beatae consequatur cumque velit consequatur expedita exercitationem officia debitis.\nUnde cum sequi quibusdam aliquid rerum minus magnam minima nihil.\nTenetur nulla sit laudantium dolores." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { "Et quae expedita.", new DateTime(2023, 7, 2, 5, 40, 4, 554, DateTimeKind.Utc).AddTicks(8404), 15L, "ad", "Non repudiandae qui incidunt repudiandae officia rerum sunt voluptas cum.", 1L, "", 1, "Saepe aliquid est neque eum harum explicabo." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 61L, "Et ut illo maiores quas rem facilis.\nAb rerum non est unde minima corrupti aut quidem similique.", new DateTime(2023, 5, 4, 7, 5, 23, 520, DateTimeKind.Utc).AddTicks(3794), 12L, "Autem illum qui velit est.\nExercitationem consequatur voluptas ut illo ipsa dolores perferendis.", "Quam doloribus minima vel rerum reprehenderit distinctio adipisci.", 2L, "", 1, "Similique expedita dolorum excepturi voluptas ad.\nDolorem ut sequi perferendis ab.\nVoluptatibus quia dolorem nostrum excepturi error et qui inventore.\nNon eius minus aut blanditiis eum voluptatem et maiores.\nAspernatur vitae ipsam et voluptatum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 45L, "est", new DateTime(2023, 4, 26, 1, 34, 52, 156, DateTimeKind.Utc).AddTicks(9033), 34L, "Quo harum architecto ut accusantium.", "Sint repellendus non non.", 2L, "", 3, "Id illum omnis consequatur eum animi labore et perferendis. Inventore aut sunt ut cum sunt. Amet dicta similique qui voluptatem sit nihil voluptatem ex aut. Velit ipsum repellat ut qui natus odit. Minima cum facere velit ad quibusdam qui. Aut consequatur dolorem et provident a vitae sed est." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 63L, "Iusto tempore exercitationem expedita fuga.", new DateTime(2022, 11, 28, 13, 58, 37, 959, DateTimeKind.Utc).AddTicks(7491), 14L, "sed", "Velit non et ratione.", 1L, "", 0, "Et non voluptas architecto et sunt praesentium non." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 19L, "Perferendis eaque cumque.\nDolore nisi optio.\nDolorem iste dolorum placeat eaque rerum.\nVoluptas eaque magnam sunt itaque.\nAt et est quasi dicta repudiandae eligendi ut.\nEst culpa ad ex velit voluptatem quas nemo est eos.", new DateTime(2022, 7, 29, 1, 59, 42, 601, DateTimeKind.Utc).AddTicks(490), 22L, "Eos error esse quaerat dolorem quae.", "Facilis non iste ullam illum a exercitationem vel iure.", 1L, "", 0, "Dicta nemo consequatur voluptatem accusamus est ut est eos sunt.\nIn nesciunt iure aut sit neque et alias voluptatem officiis.\nIpsa rem soluta placeat voluptas qui qui animi tempora." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 25L, "Ut quia eius ut suscipit culpa sed veniam.", new DateTime(2023, 1, 21, 23, 58, 59, 661, DateTimeKind.Utc).AddTicks(4908), 38L, "Molestiae exercitationem qui iste possimus laboriosam iure.\nAlias eligendi voluptatem aperiam architecto est impedit eligendi nostrum odio.\nEt cum et.", "A ipsa quidem provident nostrum corrupti.", 2L, "", 0, "ipsa" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 24L, "Impedit ut molestiae.\nIncidunt voluptatem vero velit deserunt eos id molestiae unde necessitatibus.", new DateTime(2021, 9, 23, 9, 39, 39, 761, DateTimeKind.Utc).AddTicks(6131), 29L, "Et eligendi sapiente debitis voluptatem et.\nPossimus ut non enim qui sint nam iure excepturi non.\nProvident qui fugit earum id.", "Et aut eos aut distinctio eum doloremque maxime vel aut.", 1L, "", "Voluptatum voluptate fugiat explicabo laudantium fugit necessitatibus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 22L, "Ut optio totam temporibus et saepe dolore accusantium.", new DateTime(2023, 4, 4, 23, 59, 38, 286, DateTimeKind.Utc).AddTicks(5185), 32L, "est", "Deserunt vitae officiis officia vero sit neque.", 1L, "", 0, "Impedit hic et quidem." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 65L, "veritatis", new DateTime(2023, 7, 20, 11, 45, 22, 871, DateTimeKind.Utc).AddTicks(7576), 25L, "Est ducimus at eos deserunt porro beatae tempore.\nTemporibus quos natus est.\nDucimus consequatur neque molestiae cupiditate corrupti necessitatibus.", "Quia et dolor autem ducimus iusto eos veritatis facilis.", 1L, "", 0, "Quo sed voluptas sit quo earum ipsam quasi." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 27L, "Repellat qui repellat totam molestiae qui iure quia.\nNisi iste porro voluptatum voluptatem magni voluptatem facilis aut vero.\nVeniam cupiditate libero aliquam expedita iusto cumque voluptas.\nOdit qui repellat inventore vero ducimus tempora dolorem sapiente mollitia.", new DateTime(2023, 2, 10, 5, 59, 32, 195, DateTimeKind.Utc).AddTicks(4083), 21L, "Distinctio nihil vel.\nVoluptatum sint quod consequatur quos odio.", "Autem fugiat modi soluta tempore.", 2L, "", "Vitae alias nulla ab eius aut fugit." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { "occaecati", new DateTime(2023, 7, 25, 20, 24, 19, 499, DateTimeKind.Utc).AddTicks(8614), 12L, "quia", "Et vel et maiores soluta esse excepturi ut.", 1L, "", 0, "Harum officia eos debitis et neque. Et qui ut enim nihil. Odit ut a impedit." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 62L, "Explicabo ut quis vero at voluptate dolores facere ea ut.\nDolorem voluptas mollitia natus provident enim.\nMinima quos laboriosam et impedit debitis dignissimos.", new DateTime(2022, 10, 23, 5, 57, 25, 148, DateTimeKind.Utc).AddTicks(2866), 10L, "perferendis", "Ex et adipisci.", 1L, "", 3, "Repellendus impedit sint aspernatur nam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 56L, "non", new DateTime(2021, 5, 28, 11, 6, 18, 741, DateTimeKind.Utc).AddTicks(173), 28L, "Accusamus accusantium sunt. Impedit ab ut possimus asperiores qui. Qui neque praesentium et reprehenderit vel et facere fuga laudantium. Quasi dolore repellendus occaecati. Nihil ut voluptatem. Quia voluptate aut aut.", "Non et sapiente tempora qui voluptatem blanditiis.", 1L, "", 0, "Corporis impedit et deserunt eum quos esse. Et quo ipsa dignissimos dolorem facere sint. Vel cum placeat veritatis natus qui veniam et ut. Id nihil fugiat qui quaerat aut. Sint ea sed qui fuga illo quis eum corrupti atque. Iure occaecati inventore iure aut et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 68L, "Et modi laborum quidem. Quia rerum consectetur doloremque et voluptate tempore non mollitia quae. Ut neque id enim maxime. Sint recusandae qui ipsam. Quod exercitationem sapiente perferendis aliquid animi alias aliquam.", new DateTime(2023, 7, 4, 12, 33, 5, 580, DateTimeKind.Utc).AddTicks(2769), 35L, "Laudantium totam dolores perspiciatis repellendus quia neque.", "Provident quo possimus error quae tempora inventore voluptate.", 1L, "", 0, "adipisci" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 6L, "Et rerum rerum ut eveniet et voluptates illo.", new DateTime(2023, 6, 22, 18, 27, 53, 493, DateTimeKind.Utc).AddTicks(2755), 30L, "Nesciunt officiis fuga eos et dolore harum dolores consequatur.", "Reprehenderit qui blanditiis necessitatibus.", 1L, "", 2, "cupiditate" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 1L, "Eveniet dolorem similique animi. Officiis et sunt impedit fuga eos. Fugiat dolorum aliquam est non aliquam quia accusamus. Iste et neque. Consequatur eos explicabo et aut aut.", new DateTime(2023, 2, 17, 2, 0, 24, 301, DateTimeKind.Utc).AddTicks(7942), "Sit dolorem error assumenda iure doloribus iure nihil quidem. Minima alias quam iure voluptate dolorem occaecati corrupti cupiditate. Ut rerum ducimus dignissimos quidem ut quaerat assumenda vitae.", "Assumenda sapiente voluptatem unde consequatur.", 2L, "", 3, "Qui ipsam incidunt est sequi quaerat quod eos. Aspernatur animi impedit nihil voluptatem. Et laboriosam aut nihil facilis modi laboriosam et. Consequuntur libero id ut ipsum minus. Nesciunt quasi consectetur saepe itaque quam error aut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 47L, "Explicabo dolor debitis quasi assumenda quas provident deserunt.\nLaborum reprehenderit ea.\nPerspiciatis autem quia magni sequi minus dolorum laboriosam eos vero.\nAtque quasi incidunt voluptas voluptatibus neque.", new DateTime(2022, 3, 5, 8, 24, 2, 841, DateTimeKind.Utc).AddTicks(8355), 23L, "modi", "Vitae nulla ea minima.", 2L, "", 2, "omnis" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 8L, "Perferendis sapiente voluptate.\nMolestiae eum qui cumque.\nSed laborum debitis ea laborum.", new DateTime(2018, 9, 26, 23, 19, 45, 312, DateTimeKind.Utc).AddTicks(3640), 12L, "Natus eligendi reiciendis eum at consequuntur praesentium. Voluptas et et. Quaerat recusandae dicta omnis modi illum enim. Sit maiores voluptas deleniti eaque debitis vero asperiores. Maiores est et repellat dolorem libero et aperiam culpa.", "Labore corrupti id qui qui nesciunt qui laborum nihil.", 2L, "", 1, "cum" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 42L, "Rerum eos nobis sapiente quis sunt non et ut. Ut laudantium enim laboriosam nulla repellat fuga sunt ut et. Facilis quaerat quia minima saepe minus soluta qui. Cupiditate sint cum non ipsa voluptates.", new DateTime(2023, 5, 28, 14, 44, 31, 188, DateTimeKind.Utc).AddTicks(3311), 39L, "Aliquid temporibus vel ullam recusandae quasi.\nUllam ipsum ratione consectetur voluptate soluta consequatur.\nRepudiandae illum dignissimos nesciunt quas.\nLabore perferendis aut quod nemo.\nUt ipsam aliquam quaerat vero ut.\nCorrupti numquam mollitia et.", "Distinctio culpa aliquid.", 1L, "", "Explicabo quas sed ut culpa quo alias reiciendis repudiandae. Distinctio tenetur voluptatem cum. Consequuntur corporis animi deleniti nobis deleniti voluptas dolore." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 24L, "Amet aut omnis sunt natus et. Labore voluptatibus repudiandae necessitatibus suscipit inventore unde. Veritatis ipsam sed qui similique eos ullam minus dolores accusamus. Eum laboriosam itaque placeat incidunt blanditiis suscipit sapiente earum. Iusto accusantium illo tempore aut consequuntur.", new DateTime(2023, 5, 1, 7, 34, 46, 827, DateTimeKind.Utc).AddTicks(3811), 28L, "Et eum porro ab alias nesciunt.", "Recusandae eveniet et fugit velit error voluptatem.", 1L, "", 1, "Animi quo autem incidunt ut magnam qui expedita. Dolore necessitatibus autem minima nihil porro et minima corporis ut. Et repellat explicabo est quas fuga nostrum voluptatem. Mollitia perferendis voluptatem qui et enim. Aut odit deserunt." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 40L, "Ut sunt ut esse et.\nIncidunt quia impedit id enim et et vel.", new DateTime(2023, 3, 8, 12, 53, 39, 716, DateTimeKind.Utc).AddTicks(8693), 15L, "aut", "Voluptates velit animi quod voluptas qui quisquam a.", 2L, "", 3, "Ut vel ipsa ut consectetur sunt.\nLibero libero voluptatem et.\nOfficiis ut quod laborum accusantium deleniti.\nVoluptas quod rerum fuga velit occaecati." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 57L, "Alias alias placeat.", new DateTime(2022, 12, 9, 19, 19, 47, 5, DateTimeKind.Utc).AddTicks(1168), 23L, "Voluptas asperiores quia quia non quisquam.", "Magnam maiores eos ratione.", 1L, "", 0, "Quibusdam quo adipisci provident perferendis officia eveniet beatae id qui. Amet voluptas eum. Error mollitia aspernatur. Ut aperiam sequi dolorum omnis aut totam sunt." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 37L, "ut", new DateTime(2023, 1, 15, 3, 29, 48, 87, DateTimeKind.Utc).AddTicks(6439), 38L, "Sit laudantium mollitia ut minus sapiente aut.\nDistinctio quibusdam facere quos unde veniam iusto ut.\nAspernatur et quia dolorem dolores laudantium ipsa commodi.\nAperiam fuga quaerat beatae inventore.\nQui consequatur vel repellat.", "Dolores corrupti cupiditate ut tempore corporis.", 2L, "", 3, "Est dicta unde tenetur facilis eius." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 1L, "Dignissimos vel occaecati alias iste est iure molestiae eum quis. Id culpa ipsa perspiciatis ut iusto commodi. Nemo impedit perspiciatis quos.", new DateTime(2023, 9, 11, 15, 22, 30, 208, DateTimeKind.Utc).AddTicks(1977), 35L, "Dolore incidunt excepturi quia aut itaque.", "Velit quia nobis voluptates aspernatur aut fugit illo.", 1L, "", 2, "nostrum" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 162L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 25L, "Dolorem vel minima ut necessitatibus iusto quo velit. Qui eligendi officiis dolorem. Et in aperiam et eaque odio. Et et optio ut consectetur aliquam. Magnam qui est voluptas fugiat sint ad consequuntur eveniet.", new DateTime(2023, 7, 23, 5, 26, 42, 32, DateTimeKind.Utc).AddTicks(7309), 29L, "Dolor facere quaerat voluptatem ea.", "Voluptates in perferendis minima ullam eum iusto odit accusamus iste.", 1L, "", 2, "minus" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 163L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 64L, "vero", new DateTime(2020, 4, 10, 14, 32, 15, 269, DateTimeKind.Utc).AddTicks(6165), 11L, "sapiente", "Et ut nemo culpa et qui quidem optio.", 1L, "", 1, "Consequatur eaque et sed tempore et. Amet laborum sequi animi corrupti est autem eos inventore et. Perspiciatis facere illo praesentium. Quia optio eius ipsam rem eaque et. Fugiat amet aut tenetur commodi atque." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 164L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 39L, "Odio dignissimos molestias blanditiis amet praesentium ratione consequatur qui voluptas. Voluptas nihil et sunt omnis. Nisi pariatur id non sint. Id a odit cumque in ut.", new DateTime(2023, 2, 3, 11, 50, 37, 634, DateTimeKind.Utc).AddTicks(6235), 17L, "Et autem in sed consequuntur placeat voluptas in corporis voluptas. Unde illum perspiciatis voluptatem. Sit praesentium in autem in et. Repellat dicta qui aut recusandae.", "Sunt quaerat non est rerum ad rerum ea.", 2L, "", 1, "Voluptate quae et eaque quidem. Sit ducimus corporis aut aliquid rerum repellendus. Repellendus enim et excepturi eum inventore. Autem optio molestiae hic et dolores vitae possimus placeat qui." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 165L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 9L, "In sunt tenetur voluptas sit esse itaque perspiciatis a.", new DateTime(2020, 8, 25, 19, 10, 31, 323, DateTimeKind.Utc).AddTicks(2704), 5L, "Ipsam impedit nobis quae laboriosam omnis possimus cum eius.\nEt exercitationem necessitatibus ad expedita.\nNon laborum quisquam sunt eos ullam.\nReprehenderit qui ut eius sint nam ipsam possimus occaecati est.\nLaboriosam animi atque.\nOmnis voluptatem tempora modi quia.", "Maiores voluptate optio non eum quidem minus similique corrupti.", 2L, "", 0, "In ducimus qui.\nReprehenderit quo facere voluptas possimus recusandae delectus iste.\nQui et architecto voluptas rerum eum magni voluptatibus labore est.\nInventore ipsum ex dolores unde et expedita enim.\nVel sed vitae maiores.\nNisi vero id non alias totam quia qui at animi." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 64L, "id", new DateTime(2022, 7, 19, 8, 31, 46, 821, DateTimeKind.Utc).AddTicks(4303), 19L, "Illo et adipisci fugiat in eos rerum quia rem enim.\nQuia doloremque quae expedita.\nVoluptas fuga repudiandae ipsum quia et consectetur id cum dolor.\nQuia eius eveniet voluptatem et nemo aliquam esse aut magni.\nDolores voluptates ad nulla.\nVoluptatem autem voluptatibus excepturi adipisci.", "Consequatur quia doloribus saepe est sint.", 1L, "", 3, "Aut ut et perferendis et animi aspernatur." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 7L, "Deserunt illum est et. Eos est consequuntur consequatur saepe voluptatum id. Commodi eligendi ut temporibus. Corporis veritatis unde recusandae tempore facilis incidunt iure tempore. Debitis eaque voluptas rerum est est dolor neque id similique.", new DateTime(2022, 1, 6, 22, 5, 0, 545, DateTimeKind.Utc).AddTicks(505), 28L, "Illo deserunt sint qui qui provident provident modi ab magnam.\nSed dolore recusandae molestias est nulla culpa sed cupiditate.\nQuaerat incidunt quia quasi quia sit est dolorem harum eos.", "Laborum amet quo blanditiis nesciunt dolorum officiis et.", 2L, "", 2, "Ut est quod dolores. Perspiciatis sunt laudantium aliquid dicta culpa expedita. Cumque expedita ratione magni in dolorem consectetur." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 53L, "Numquam fuga facere quia est architecto.", new DateTime(2022, 2, 10, 2, 55, 33, 874, DateTimeKind.Utc).AddTicks(340), 38L, "Id nihil sunt. Eum quas sunt quo aut maiores esse enim. Ut consequatur nihil saepe dolor. Qui quae quam eveniet aut sed aut qui reprehenderit aut. Distinctio assumenda et ut rem voluptatem molestiae et sed labore.", "Ratione molestias recusandae qui eos provident ea tempore.", 2L, "", 2, "Commodi quod voluptas laudantium excepturi et illo esse reprehenderit.\nOdit non dolore delectus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 55L, "Inventore officiis accusantium sit aut veniam est illum ab. Eum quo quia est. Quo et ut dolor eum facilis nobis quasi. Quo a dolorem perferendis accusamus.", new DateTime(2023, 3, 27, 19, 19, 58, 260, DateTimeKind.Utc).AddTicks(87), 15L, "Magni eos autem non et et vel voluptas nisi. Deserunt odio neque voluptatem. Explicabo id suscipit.", "Qui soluta id.", 2L, "", 3, "Et debitis impedit. Excepturi nostrum numquam rerum blanditiis porro amet similique sint. Laborum asperiores quam molestiae laborum reprehenderit ipsa cupiditate eos. Aut qui rem nulla sed. Hic ad provident est modi ducimus itaque." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 37L, "Ratione quia officiis nemo aliquid et et rerum alias molestias. Ut possimus consequuntur. Id maiores quam a omnis et sint neque. Praesentium incidunt adipisci dolor sed aut non.", new DateTime(2022, 9, 24, 2, 47, 28, 222, DateTimeKind.Utc).AddTicks(811), 18L, "Molestiae consectetur accusamus in at quaerat quibusdam assumenda.", "Assumenda repudiandae eaque ratione est dolorem illo quos incidunt.", 1L, "", 1, "Aut rerum provident." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 61L, "Ut ullam temporibus ut facilis sit dolor ratione ut.", new DateTime(2023, 6, 15, 17, 50, 26, 378, DateTimeKind.Utc).AddTicks(5238), 21L, "Nobis aut ut nostrum impedit rerum omnis.\nAut suscipit ducimus commodi.\nCulpa nisi ut in nisi ut.\nHarum doloremque repellat hic officia et inventore tempore.\nSint rem qui sit animi dolores aspernatur quaerat.\nVoluptatem adipisci est ut ipsum nihil voluptatem quibusdam eos voluptatem.", "Officiis dolores quis harum quae nostrum nulla quia et.", 2L, "", "Eaque distinctio et temporibus est nulla cum est libero animi. Qui quas dolorem ipsam corrupti ipsum. Nemo possimus unde placeat tenetur a aut quas quod. Minima corporis sequi illum odit. Dolore ut qui et nesciunt ad possimus. Nesciunt corporis eveniet suscipit omnis qui et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 3L, "rerum", new DateTime(2023, 7, 13, 11, 44, 41, 460, DateTimeKind.Utc).AddTicks(7382), 18L, "et", "Molestiae et perferendis in nihil.", 2L, "", "dignissimos" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 30L, "Soluta aut cum hic labore accusantium cum atque. Vero magnam quia. Dolorum non maiores iste nostrum. Sit officiis maxime eius dolorum odio adipisci commodi voluptatem. Iusto animi repudiandae voluptatem ratione nihil error excepturi sint. Consequatur dolorem sapiente neque repellendus quis officiis.", new DateTime(2020, 7, 15, 7, 20, 56, 670, DateTimeKind.Utc).AddTicks(6136), 36L, "magni", "Dolorum vitae voluptatem rerum distinctio eos in quibusdam.", 2L, "", 0, "Officiis sit molestias accusantium. Accusamus itaque distinctio illo molestias ipsa distinctio velit eligendi. Quaerat suscipit earum neque velit delectus voluptatum quidem. Possimus pariatur repudiandae culpa iusto magnam error ex." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 29L, "Ut sint cupiditate aperiam non cum consequuntur dolorem in.", new DateTime(2020, 10, 9, 13, 10, 12, 419, DateTimeKind.Utc).AddTicks(6746), 26L, "Incidunt neque ducimus qui rerum quo veritatis sit tempora.", "Atque ut blanditiis velit in.", 1L, "", 0, "Ut et a ex modi aut earum est fuga." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 7L, "Soluta et totam necessitatibus.", new DateTime(2022, 3, 12, 7, 5, 35, 741, DateTimeKind.Utc).AddTicks(6398), 31L, "Omnis sed eligendi fuga sequi.\nUnde et nesciunt aut et at eos aut sint.\nId consequatur quo consequatur et neque debitis aut voluptatem.", "Numquam quidem cum repudiandae sapiente sint aperiam quaerat fuga similique.", 1L, "", 1, "Quis commodi officia voluptatum autem esse.\nVel sequi maxime.\nEum enim nostrum ipsam officia nemo perferendis quo quia.\nAdipisci et dolorem rerum similique." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 8L, "Nesciunt excepturi voluptas sapiente.\nMagni numquam totam quia.", new DateTime(2021, 10, 1, 21, 39, 4, 137, DateTimeKind.Utc).AddTicks(4556), 3L, "Rem molestiae est sunt eos error expedita nam.\nQuia quos aut id.\nPariatur voluptas animi aut perferendis maxime autem.", "Fugiat est perferendis reprehenderit.", 2L, "", 3, "Inventore voluptatem natus maxime perferendis corporis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 70L, "Incidunt dolorem cum aspernatur qui rem unde laboriosam.", new DateTime(2023, 7, 28, 9, 37, 52, 595, DateTimeKind.Utc).AddTicks(3841), 1L, "Ut et qui consequuntur et voluptas. Sunt repudiandae quos velit nesciunt nemo rerum ducimus quo. Consequatur eveniet ullam doloremque et quia ut quos magni provident. Quia officia enim inventore ut temporibus ad quam occaecati.", "Libero dicta impedit quo autem numquam.", 2L, "", 3, "Qui et impedit esse esse velit. Culpa necessitatibus temporibus qui voluptates voluptatem sequi. Doloribus in esse. Optio omnis quia et dolorum quas. Alias molestiae enim dolore nisi odit tenetur et aliquam dolorem. Tempore exercitationem excepturi quia harum deserunt earum velit repudiandae et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 13L, "neque", new DateTime(2021, 4, 4, 16, 45, 20, 167, DateTimeKind.Utc).AddTicks(949), 33L, "Aut voluptas eius eos amet occaecati consequatur accusantium consectetur consequuntur.\nAut quis neque voluptatem voluptatem.\nDignissimos aut culpa ea molestias harum voluptatibus.\nConsequatur laboriosam numquam.\nQuo adipisci voluptatum consequuntur ab maiores et.", "Aut ipsam ab quia hic dolores optio a quis.", 2L, "", 3, "Et nobis quidem." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 14L, "Adipisci porro eius. Autem eligendi labore consequuntur vel sit sequi. Ex recusandae saepe nulla labore dolor. Id velit culpa alias asperiores necessitatibus alias aut.", new DateTime(2023, 5, 7, 2, 17, 45, 128, DateTimeKind.Utc).AddTicks(6331), 28L, "Qui quod alias possimus voluptates. Laborum id ut ab deleniti dolorum. Veritatis sequi saepe accusantium tempora quidem.", "Molestias eum et quasi officiis nostrum.", 1L, "", 2, "earum" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 61L, "Recusandae eos recusandae temporibus error voluptatibus reprehenderit. Aut eum natus dolorem pariatur. Eaque quo ullam itaque odit in ab iure eaque nobis. Labore pariatur ipsum accusamus aperiam corrupti culpa quibusdam.", new DateTime(2023, 8, 27, 20, 43, 12, 25, DateTimeKind.Utc).AddTicks(1598), 16L, "vero", "Tempora impedit quis necessitatibus quia sit ducimus dolores.", 2L, "", 0, "Nostrum pariatur unde non aliquid voluptas molestias sit nam aut.\nReiciendis eos totam voluptatem velit maxime et.\nPerspiciatis aspernatur magnam quae voluptas dolores eius.\nQuasi saepe voluptatibus doloremque enim tenetur.\nQuam ducimus iure eveniet.\nQuisquam aut nihil." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 31L, "et", new DateTime(2023, 3, 5, 14, 7, 5, 852, DateTimeKind.Utc).AddTicks(692), 35L, "quo", "Fugiat non aut velit temporibus.", 1L, "", 2, "beatae" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 7L, "Voluptas nam reprehenderit ut consectetur laborum voluptatem amet sunt. Id ratione aspernatur suscipit. Ea eum est ipsum qui repudiandae rerum. Ut sit alias quas nulla quae. Amet atque maiores aut dolores. Qui aut est est vel rerum placeat aliquam.", new DateTime(2020, 2, 10, 8, 28, 0, 289, DateTimeKind.Utc).AddTicks(7745), 4L, "Nobis dolores nulla tenetur sed quia.\nEnim et quam dolores qui aut aut.\nQuo vel assumenda tempore eligendi.", "Doloribus quae cumque.", 2L, "", 0, "Officiis corrupti et nam ab quidem doloremque et a. Quia ut amet aut. Eos id repellat quia neque doloribus. Autem sapiente in eaque. Consequatur delectus dolores amet et autem dolore." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 33L, "Repellendus doloremque enim est.", new DateTime(2023, 9, 1, 19, 17, 42, 838, DateTimeKind.Utc).AddTicks(7323), 16L, "Aut esse omnis optio odit aut.", "Qui eaque eligendi odit earum atque veritatis quisquam illo et.", 2L, "", 2, "Est neque consequuntur.\nPorro esse deleniti a nam facere mollitia quia assumenda non.\nEx atque culpa quibusdam deleniti.\nSuscipit vitae a.\nIusto quia voluptatibus facilis nihil aut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 35L, "debitis", new DateTime(2023, 8, 16, 10, 34, 59, 376, DateTimeKind.Utc).AddTicks(2945), 10L, "Ipsum perspiciatis veniam.", "Quod molestias ad occaecati cum temporibus.", 1L, "", 1, "ab" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 55L, "Aut perferendis corrupti itaque fugit et est.\nEveniet praesentium delectus harum et ut magnam sapiente eos optio.\nError eligendi ducimus delectus numquam sequi adipisci.", new DateTime(2023, 1, 21, 6, 11, 39, 351, DateTimeKind.Utc).AddTicks(2711), 23L, "velit", "Minus possimus sint corrupti.", 2L, "", 0, "Facere possimus aperiam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 23L, "Magni vel sint et quae ad dolor sint modi. Quia eos nihil hic modi commodi assumenda consequuntur. Et minus vero libero suscipit odit. Accusamus omnis veniam rerum non tenetur vel dolore necessitatibus animi.", new DateTime(2023, 8, 28, 5, 18, 11, 656, DateTimeKind.Utc).AddTicks(7839), 35L, "In in inventore enim qui.\nUnde fugit voluptate incidunt quidem qui odit.\nPossimus dolor veritatis dolorum.\nEst quae aut dolore nobis velit velit sequi ut.\nRem dolorem id assumenda quia.\nAut consectetur et praesentium consequatur similique sapiente.", "Libero saepe ex nisi aperiam ut id voluptates quidem deleniti.", 2L, "", "Quis iste quae.\nAliquam dolor quia laborum qui eum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 30L, "Est autem recusandae et eveniet vel. Nam tenetur doloribus dignissimos nesciunt est beatae dicta incidunt et. Omnis voluptatem velit blanditiis necessitatibus. Ea ut omnis accusamus. Voluptatum illum omnis qui qui.", new DateTime(2020, 5, 16, 23, 21, 42, 957, DateTimeKind.Utc).AddTicks(7159), 10L, "Veritatis reprehenderit deleniti ipsum soluta.\nConsectetur nesciunt sint quis distinctio omnis.\nQuae ut sapiente dignissimos et quibusdam.\nEsse est eius veritatis porro qui ut ea qui voluptatem.\nMollitia qui autem nesciunt.\nAut enim non quia et voluptatibus corporis assumenda placeat laboriosam.", "Ducimus et suscipit voluptas voluptas eius nemo quis sit quis.", 2L, "", 1, "Quaerat excepturi ab eius exercitationem quos dignissimos saepe id asperiores. Eius illo velit aspernatur. Laudantium tempora adipisci et quibusdam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 50L, "dolorem", new DateTime(2023, 4, 6, 4, 24, 16, 17, DateTimeKind.Utc).AddTicks(4391), 21L, "Maxime qui mollitia illum voluptatibus aut ut unde est et.\nNeque aspernatur non quia minima exercitationem cupiditate labore.\nVelit et est aut beatae culpa voluptatem quibusdam recusandae.\nUnde sit ut omnis qui enim ex ex ab.\nNon rerum optio dolorem fuga numquam unde.", "Et hic nulla velit quia esse blanditiis.", 1L, "", "Eos veritatis dolor impedit necessitatibus alias hic ipsum. Fuga dolor iusto. Qui ipsam autem facilis nulla. Dolores quibusdam deserunt." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 15L, "Ipsum et temporibus beatae ex dolorum suscipit iure.", new DateTime(2020, 1, 14, 6, 8, 36, 730, DateTimeKind.Utc).AddTicks(7940), 27L, "Natus non consequatur ut voluptatum eos aperiam. Dicta porro ex. Quo tempore incidunt praesentium enim eos. Est non eaque enim et maxime enim.", "Et provident soluta alias quos id.", 2L, "", 3, "molestiae" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 13L, "Dicta eveniet iusto mollitia occaecati rerum odit molestiae. Veritatis quia dolorem optio cupiditate quaerat praesentium sequi quia. Dolorem architecto nihil molestiae temporibus. Ut consequatur modi ratione ipsum nulla quod veniam et tenetur.", new DateTime(2022, 11, 6, 5, 36, 13, 695, DateTimeKind.Utc).AddTicks(7966), 30L, "et", "Mollitia accusamus nemo consequatur ipsam aut sit.", 2L, "", "Ratione facere est aut alias aut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 61L, "Eius culpa perspiciatis qui similique aut maiores. Blanditiis dolorum quisquam. Ut velit unde. Autem qui voluptatum. Modi aperiam dolores quod et. Et dolorem iusto sed et.", new DateTime(2023, 6, 16, 20, 29, 11, 580, DateTimeKind.Utc).AddTicks(8244), 38L, "Distinctio tempora quisquam.", "Consequatur id ut laborum distinctio totam facilis quo unde culpa.", 1L, "", 3, "tempora" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 66L, "Dignissimos aut qui minima.", new DateTime(2022, 7, 26, 17, 9, 4, 765, DateTimeKind.Utc).AddTicks(6948), 29L, "nihil", "Qui ut quia ut aspernatur animi possimus asperiores voluptate corrupti.", 2L, "", 3, "Aliquam iste et nulla ut consectetur necessitatibus. Quasi quis est nihil quis soluta sequi sint dicta ipsum. Qui fugiat dignissimos architecto vel id rerum dolorem." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 50L, "Quo nobis dolorum quibusdam. Aut quas nostrum. Minus aut laboriosam iusto id consequatur deleniti nobis odit eum.", new DateTime(2023, 6, 21, 5, 31, 54, 975, DateTimeKind.Utc).AddTicks(6210), 11L, "Natus occaecati quia omnis qui.\nTempore repellendus voluptatem.\nUt neque dolorem perspiciatis enim fuga nostrum hic quidem officia.", "Molestiae quia optio.", 1L, "", 2, "Laudantium ipsum odio est porro et culpa est." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 54L, "Autem dolor sint et ab.\nLibero iusto animi.\nFacere et consequatur.", new DateTime(2022, 6, 21, 4, 15, 51, 399, DateTimeKind.Utc).AddTicks(7647), 1L, "qui", "Architecto ut dolor molestiae.", 1L, "", 1, "Exercitationem quis est a et nulla.\nVoluptatibus accusamus dolore enim earum quia id qui aliquid." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 69L, "Sit ut hic molestiae recusandae placeat et possimus est. Asperiores et in. Amet qui velit sunt quis ipsa at maiores. Ut adipisci velit perspiciatis quod cumque quae nihil. Possimus natus repudiandae minima beatae quo quam voluptatem.", new DateTime(2022, 12, 8, 7, 42, 14, 331, DateTimeKind.Utc).AddTicks(5630), 30L, "Voluptatem voluptatibus atque consequatur animi deserunt itaque ut.", "Ut voluptatem officiis distinctio repellendus voluptas quas similique eveniet ut.", 2L, "", "Et eaque debitis consequatur." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "TestCases" },
                values: new object[] { 27L, "Quo omnis et molestias sunt tempore accusantium animi eligendi quod.", new DateTime(2022, 10, 30, 8, 7, 58, 238, DateTimeKind.Utc).AddTicks(1431), 23L, "nobis", "Illo soluta eligendi.", 1L, "", "Vel necessitatibus nihil quisquam.\nLaborum quia dolorem dolorum similique iure aspernatur." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 66L, "Id minima rerum perspiciatis.\nIpsam quidem suscipit quia beatae sequi qui eius consectetur occaecati.\nTotam maiores delectus eius qui dolor.\nQuos beatae voluptatem repellat aut.\nEst voluptatum unde quia.\nDelectus odit numquam natus omnis.", new DateTime(2022, 11, 17, 7, 49, 39, 829, DateTimeKind.Utc).AddTicks(4254), 29L, "Id repellat ipsa optio recusandae exercitationem sed sit sed.", "Aut unde saepe velit rem repudiandae eos.", 1L, "", 1, "Dignissimos ut ducimus vel voluptas cumque necessitatibus et dignissimos.\nId assumenda distinctio nihil.\nQui totam expedita.\nEt dicta rem id est.\nNulla tempora velit adipisci voluptates modi tempora." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 14L, "Est ut distinctio.", new DateTime(2023, 5, 4, 8, 59, 56, 797, DateTimeKind.Utc).AddTicks(1776), 24L, "Voluptatem eum ea est repellendus optio. Quia tempore ut temporibus nesciunt dolores. Vel culpa recusandae est et soluta sequi eveniet.", "Illum explicabo odit.", 1L, "", 3, "Voluptatum deleniti accusamus sed non vel. Pariatur est sit ex est. Voluptatem molestias ut enim veniam nam sequi dolores. Voluptatem autem vel sed et ea consequuntur assumenda. Velit officiis qui qui rerum. Libero reprehenderit natus aut eos." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 15L, "Sapiente voluptatem sed.", new DateTime(2019, 1, 10, 11, 21, 19, 100, DateTimeKind.Utc).AddTicks(1078), 8L, "Rerum in voluptatibus quia eos non in enim quam.", "Odit ipsa enim quo et voluptates dolores id in facere.", 1L, "", 2, "aperiam" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[] { 61L, "beatae", new DateTime(2023, 8, 22, 8, 8, 3, 797, DateTimeKind.Utc).AddTicks(8472), 37L, "Quisquam magni optio dolorem dolorem reprehenderit omnis expedita ipsam.", "Quasi et beatae hic sint qui.", 1L, "", 0, "dolor" });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 10, 27, 13, 12, 18, 854, DateTimeKind.Utc).AddTicks(1700), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2018, 3, 16, 17, 37, 35, 364, DateTimeKind.Utc).AddTicks(6319), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 6, 23, 9, 35, 24, 736, DateTimeKind.Utc).AddTicks(1715), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 3, 7, 4, 53, 10, 736, DateTimeKind.Utc).AddTicks(9057), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 3, 24, 19, 32, 19, 855, DateTimeKind.Utc).AddTicks(9971), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 4, 24, 4, 52, 2, 399, DateTimeKind.Utc).AddTicks(2652), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2020, 1, 8, 14, 23, 19, 599, DateTimeKind.Utc).AddTicks(8724), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2017, 1, 16, 2, 3, 41, 684, DateTimeKind.Utc).AddTicks(7392), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2019, 12, 7, 7, 46, 24, 922, DateTimeKind.Utc).AddTicks(7714), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 6, 4, 5, 15, 57, 906, DateTimeKind.Utc).AddTicks(893), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2018, 1, 14, 2, 50, 22, 449, DateTimeKind.Utc).AddTicks(975), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 8, 13, 9, 15, 6, 135, DateTimeKind.Utc).AddTicks(8811), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2017, 10, 23, 14, 3, 11, 443, DateTimeKind.Utc).AddTicks(1077), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 10, 17, 2, 54, 53, 421, DateTimeKind.Utc).AddTicks(9478), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2018, 7, 14, 23, 31, 3, 60, DateTimeKind.Utc).AddTicks(4694), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 3, 20, 21, 11, 4, 355, DateTimeKind.Utc).AddTicks(1192), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 14, 39, 453, DateTimeKind.Utc).AddTicks(6652), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2020, 4, 19, 18, 42, 14, 521, DateTimeKind.Utc).AddTicks(8171), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 7, 26, 13, 26, 32, 627, DateTimeKind.Utc).AddTicks(4386), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 4, 5, 5, 23, 6, 99, DateTimeKind.Utc).AddTicks(4707), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 11, 30, 23, 43, 3, 145, DateTimeKind.Utc).AddTicks(7924), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 9, 29, 15, 2, 56, 287, DateTimeKind.Utc).AddTicks(3549), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 8, 25, 12, 49, 0, 701, DateTimeKind.Utc).AddTicks(1910), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2021, 8, 13, 1, 0, 47, 799, DateTimeKind.Utc).AddTicks(5021), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 11, 8, 3, 46, 53, 806, DateTimeKind.Utc).AddTicks(3290), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 21, 16, 689, DateTimeKind.Utc).AddTicks(4870), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 5, 15, 1, 9, 5, 466, DateTimeKind.Utc).AddTicks(1024), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 2, 14, 19, 26, 30, 602, DateTimeKind.Utc).AddTicks(8257), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2020, 7, 27, 19, 32, 3, 505, DateTimeKind.Utc).AddTicks(1351), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2017, 7, 1, 22, 31, 36, 704, DateTimeKind.Utc).AddTicks(459), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 1, 13, 1, 14, 32, 533, DateTimeKind.Utc).AddTicks(4211), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 8, 10, 10, 10, 18, 988, DateTimeKind.Utc).AddTicks(250), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 9, 15, 0, 48, 28, 728, DateTimeKind.Utc).AddTicks(8011), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 9, 23, 16, 9, 17, 828, DateTimeKind.Utc).AddTicks(1651), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 3, 58, 924, DateTimeKind.Utc).AddTicks(948), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2021, 6, 2, 16, 41, 1, 410, DateTimeKind.Utc).AddTicks(7717), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2021, 9, 29, 12, 43, 10, 394, DateTimeKind.Utc).AddTicks(915), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 6, 21, 15, 51, 37, 37, DateTimeKind.Utc).AddTicks(9192), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 2, 14, 21, 31, 3, 934, DateTimeKind.Utc).AddTicks(4330), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 1, 17, 7, 38, 41, 180, DateTimeKind.Utc).AddTicks(1055), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2021, 12, 3, 13, 52, 54, 652, DateTimeKind.Utc).AddTicks(3115), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 2, 7, 17, 22, 26, 94, DateTimeKind.Utc).AddTicks(7092), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 8, 25, 3, 27, 42, 189, DateTimeKind.Utc).AddTicks(7980), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2019, 2, 8, 17, 14, 37, 591, DateTimeKind.Utc).AddTicks(9070), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 12, 9, 0, 17, 6, 361, DateTimeKind.Utc).AddTicks(639), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 5, 30, 9, 18, 3, 643, DateTimeKind.Utc).AddTicks(1014), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2020, 11, 9, 6, 11, 28, 986, DateTimeKind.Utc).AddTicks(565), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 1, 6, 0, 38, 40, 310, DateTimeKind.Utc).AddTicks(7186), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 6, 16, 22, 54, 11, 687, DateTimeKind.Utc).AddTicks(1404), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 3, 25, 9, 31, 27, 241, DateTimeKind.Utc).AddTicks(5950), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 8, 22, 19, 3, 19, 639, DateTimeKind.Utc).AddTicks(7539), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 2, 1, 7, 43, 15, 223, DateTimeKind.Utc).AddTicks(5925), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2019, 4, 13, 3, 52, 1, 189, DateTimeKind.Utc).AddTicks(545), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 1, 27, 21, 48, 9, 544, DateTimeKind.Utc).AddTicks(2198), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 9, 23, 21, 5, 41, 780, DateTimeKind.Utc).AddTicks(7288), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2018, 4, 23, 7, 52, 36, 24, DateTimeKind.Utc).AddTicks(8829), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 6, 8, 23, 23, 28, 316, DateTimeKind.Utc).AddTicks(7320), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2019, 7, 20, 13, 55, 53, 561, DateTimeKind.Utc).AddTicks(1261), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 1, 19, 12, 51, 13, 67, DateTimeKind.Utc).AddTicks(9897), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2019, 2, 25, 22, 42, 16, 509, DateTimeKind.Utc).AddTicks(4499), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 4, 29, 15, 45, 41, 983, DateTimeKind.Utc).AddTicks(2454), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 10, 6, 3, 26, 0, 385, DateTimeKind.Utc).AddTicks(6746), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2020, 10, 17, 9, 43, 10, 133, DateTimeKind.Utc).AddTicks(4306), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2019, 12, 22, 5, 20, 2, 700, DateTimeKind.Utc).AddTicks(1282), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2021, 5, 20, 16, 7, 56, 358, DateTimeKind.Utc).AddTicks(9924), 2L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 20, 38, 908, DateTimeKind.Utc).AddTicks(105), 3L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 12, 9, 12, 35, 37, 422, DateTimeKind.Utc).AddTicks(8985), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 1, 15, 13, 36, 4, 227, DateTimeKind.Utc).AddTicks(9965), 4L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 9, 27, 15, 46, 46, 815, DateTimeKind.Utc).AddTicks(8062), 1L });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 9, 26, 9, 45, 17, 795, DateTimeKind.Utc).AddTicks(7075), 4L });

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
                values: new object[] { new DateTime(2023, 10, 22, 20, 6, 24, 929, DateTimeKind.Utc).AddTicks(6111), new DateTime(2023, 7, 21, 4, 56, 58, 170, DateTimeKind.Utc).AddTicks(5194), new DateTime(2022, 8, 16, 9, 46, 52, 838, DateTimeKind.Utc).AddTicks(5750), 2L, new DateTime(2023, 7, 23, 12, 32, 26, 66, DateTimeKind.Utc).AddTicks(4337) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 19, 23, 59, 4, 0, DateTimeKind.Utc).AddTicks(5519), new DateTime(2023, 8, 1, 14, 37, 8, 876, DateTimeKind.Utc).AddTicks(1467), new DateTime(2023, 1, 24, 4, 6, 52, 771, DateTimeKind.Utc).AddTicks(5719), 1L, new DateTime(2023, 2, 8, 23, 33, 43, 538, DateTimeKind.Utc).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 5, 11, 552, DateTimeKind.Utc).AddTicks(2381), new DateTime(2023, 7, 30, 10, 12, 38, 786, DateTimeKind.Utc).AddTicks(1616), new DateTime(2023, 5, 12, 20, 39, 10, 596, DateTimeKind.Utc).AddTicks(72), 2L, new DateTime(2023, 7, 23, 19, 2, 33, 493, DateTimeKind.Utc).AddTicks(5612) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 1, 15, 18, 16, 47, 551, DateTimeKind.Utc).AddTicks(6119), new DateTime(2022, 6, 3, 6, 13, 9, 88, DateTimeKind.Utc).AddTicks(9263), new DateTime(2021, 8, 3, 12, 7, 23, 8, DateTimeKind.Utc).AddTicks(7851), 1L, new DateTime(2022, 8, 14, 22, 36, 28, 228, DateTimeKind.Utc).AddTicks(1310) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 14, 10, 6, 51, 878, DateTimeKind.Utc).AddTicks(4094), new DateTime(2023, 5, 9, 9, 12, 25, 71, DateTimeKind.Utc).AddTicks(2630), new DateTime(2022, 11, 1, 5, 38, 44, 74, DateTimeKind.Utc).AddTicks(8842), 1L, new DateTime(2023, 8, 17, 8, 10, 36, 399, DateTimeKind.Utc).AddTicks(4611) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 9, 15, 10, 53, 54, 709, DateTimeKind.Utc).AddTicks(8235), new DateTime(2021, 4, 12, 18, 5, 43, 463, DateTimeKind.Utc).AddTicks(3707), new DateTime(2018, 12, 17, 12, 57, 9, 607, DateTimeKind.Utc).AddTicks(498), 3L, new DateTime(2019, 12, 30, 17, 42, 28, 257, DateTimeKind.Utc).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 2, 24, 17, 19, 10, 995, DateTimeKind.Utc).AddTicks(3939), new DateTime(2023, 2, 1, 4, 44, 41, 274, DateTimeKind.Utc).AddTicks(7544), new DateTime(2020, 4, 24, 4, 34, 55, 617, DateTimeKind.Utc).AddTicks(1968), 1L, new DateTime(2021, 1, 25, 7, 56, 20, 193, DateTimeKind.Utc).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 10, 19, 11, 2, 4, 438, DateTimeKind.Utc).AddTicks(2385), new DateTime(2022, 8, 28, 5, 3, 9, 95, DateTimeKind.Utc).AddTicks(9345), new DateTime(2021, 5, 8, 9, 37, 11, 719, DateTimeKind.Utc).AddTicks(6008), 3L, new DateTime(2021, 7, 19, 17, 25, 49, 775, DateTimeKind.Utc).AddTicks(8219) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 28, 10, 44, 18, 832, DateTimeKind.Utc).AddTicks(4348), new DateTime(2023, 5, 29, 9, 44, 36, 194, DateTimeKind.Utc).AddTicks(7342), new DateTime(2021, 6, 3, 21, 46, 26, 173, DateTimeKind.Utc).AddTicks(213), 2L, new DateTime(2022, 5, 3, 19, 47, 14, 654, DateTimeKind.Utc).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 7, 21, 27, 7, 496, DateTimeKind.Utc).AddTicks(917), new DateTime(2022, 3, 23, 1, 52, 45, 925, DateTimeKind.Utc).AddTicks(8422), new DateTime(2021, 3, 15, 8, 57, 50, 889, DateTimeKind.Utc).AddTicks(1545), 1L, new DateTime(2022, 12, 6, 21, 30, 57, 755, DateTimeKind.Utc).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 30, 14, 51, 38, 481, DateTimeKind.Utc).AddTicks(9508), new DateTime(2023, 4, 12, 8, 55, 43, 160, DateTimeKind.Utc).AddTicks(6378), new DateTime(2023, 1, 15, 5, 57, 56, 118, DateTimeKind.Utc).AddTicks(3932), 3L, new DateTime(2023, 2, 18, 19, 2, 38, 415, DateTimeKind.Utc).AddTicks(567) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 20, 13, 24, 46, 18, DateTimeKind.Utc).AddTicks(2567), new DateTime(2022, 12, 18, 18, 42, 42, 109, DateTimeKind.Utc).AddTicks(3644), new DateTime(2022, 9, 23, 18, 4, 9, 412, DateTimeKind.Utc).AddTicks(4547), 1L, new DateTime(2023, 8, 14, 17, 3, 37, 717, DateTimeKind.Utc).AddTicks(9283) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 20, 22, 36, 42, 233, DateTimeKind.Utc).AddTicks(2649), new DateTime(2023, 9, 12, 1, 2, 43, 919, DateTimeKind.Utc).AddTicks(8429), new DateTime(2023, 4, 20, 18, 13, 40, 207, DateTimeKind.Utc).AddTicks(7138), 1L, new DateTime(2023, 9, 2, 18, 23, 14, 160, DateTimeKind.Utc).AddTicks(8237) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 5, 26, 16, 10, 58, 994, DateTimeKind.Utc).AddTicks(8884), new DateTime(2020, 7, 29, 1, 18, 52, 577, DateTimeKind.Utc).AddTicks(3682), new DateTime(2019, 11, 13, 23, 22, 30, 374, DateTimeKind.Utc).AddTicks(6400), 2L, new DateTime(2022, 10, 27, 9, 14, 52, 858, DateTimeKind.Utc).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 9, 5, 19, 52, 0, 986, DateTimeKind.Utc).AddTicks(2753), new DateTime(2022, 8, 16, 4, 55, 53, 816, DateTimeKind.Utc).AddTicks(2085), new DateTime(2021, 4, 2, 18, 55, 10, 579, DateTimeKind.Utc).AddTicks(5818), 1L, new DateTime(2023, 7, 10, 9, 6, 26, 521, DateTimeKind.Utc).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId" },
                values: new object[] { new DateTime(2023, 10, 12, 2, 28, 53, 657, DateTimeKind.Utc).AddTicks(2748), new DateTime(2023, 8, 22, 18, 36, 24, 278, DateTimeKind.Utc).AddTicks(9440), new DateTime(2023, 2, 20, 9, 59, 17, 440, DateTimeKind.Utc).AddTicks(3591), 3L });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 1, 26, 12, 33, 25, 337, DateTimeKind.Utc).AddTicks(9019), new DateTime(2020, 12, 6, 11, 9, 16, 571, DateTimeKind.Utc).AddTicks(5607), new DateTime(2019, 1, 19, 16, 16, 43, 353, DateTimeKind.Utc).AddTicks(5626), 3L, new DateTime(2020, 8, 22, 3, 30, 1, 99, DateTimeKind.Utc).AddTicks(6336) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 24, 14, 57, 37, 959, DateTimeKind.Utc).AddTicks(2863), new DateTime(2023, 8, 5, 0, 20, 30, 496, DateTimeKind.Utc).AddTicks(6572), new DateTime(2020, 12, 26, 19, 41, 50, 264, DateTimeKind.Utc).AddTicks(9790), 3L, new DateTime(2021, 12, 3, 6, 23, 45, 923, DateTimeKind.Utc).AddTicks(7318) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 8, 5, 19, 52, 35, DateTimeKind.Utc).AddTicks(8634), new DateTime(2023, 7, 7, 6, 44, 54, 451, DateTimeKind.Utc).AddTicks(2397), new DateTime(2023, 6, 26, 14, 3, 43, 380, DateTimeKind.Utc).AddTicks(3356), 2L, new DateTime(2023, 7, 23, 0, 56, 17, 275, DateTimeKind.Utc).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 3, 27, 10, 41, 49, 387, DateTimeKind.Utc).AddTicks(8422), new DateTime(2020, 2, 28, 0, 39, 23, 898, DateTimeKind.Utc).AddTicks(5857), new DateTime(2019, 11, 28, 0, 55, 58, 445, DateTimeKind.Utc).AddTicks(8373), 1L, new DateTime(2022, 3, 12, 23, 57, 39, 587, DateTimeKind.Utc).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 8, 8, 58, 9, 51, DateTimeKind.Utc).AddTicks(9225), new DateTime(2023, 6, 1, 11, 11, 5, 54, DateTimeKind.Utc).AddTicks(1679), new DateTime(2022, 3, 5, 5, 10, 27, 213, DateTimeKind.Utc).AddTicks(5591), 1L, new DateTime(2023, 6, 18, 13, 22, 36, 375, DateTimeKind.Utc).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 20, 49, 21, 687, DateTimeKind.Utc).AddTicks(6219), new DateTime(2023, 5, 5, 1, 32, 21, 21, DateTimeKind.Utc).AddTicks(812), new DateTime(2019, 12, 16, 2, 26, 34, 686, DateTimeKind.Utc).AddTicks(3374), 1L, new DateTime(2022, 5, 15, 19, 33, 52, 506, DateTimeKind.Utc).AddTicks(3723) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 3, 27, 16, 26, 44, 999, DateTimeKind.Utc).AddTicks(5036), new DateTime(2020, 3, 22, 6, 3, 23, 65, DateTimeKind.Utc).AddTicks(7640), new DateTime(2017, 7, 20, 2, 0, 38, 557, DateTimeKind.Utc).AddTicks(5113), 1L, new DateTime(2023, 9, 2, 1, 11, 53, 509, DateTimeKind.Utc).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 5, 24, 11, 22, 43, 842, DateTimeKind.Utc).AddTicks(5094), new DateTime(2019, 8, 2, 23, 53, 28, 853, DateTimeKind.Utc).AddTicks(5650), new DateTime(2019, 3, 31, 22, 10, 39, 478, DateTimeKind.Utc).AddTicks(6164), 1L, new DateTime(2020, 9, 19, 20, 9, 17, 789, DateTimeKind.Utc).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 6, 37, 7, 823, DateTimeKind.Utc).AddTicks(4937), new DateTime(2023, 4, 6, 5, 14, 23, 218, DateTimeKind.Utc).AddTicks(721), new DateTime(2021, 4, 13, 9, 58, 59, 141, DateTimeKind.Utc).AddTicks(5793), 2L, new DateTime(2022, 4, 10, 21, 27, 3, 785, DateTimeKind.Utc).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 27, 7, 56, 43, 764, DateTimeKind.Utc).AddTicks(4887), new DateTime(2023, 5, 17, 3, 48, 44, 783, DateTimeKind.Utc).AddTicks(658), new DateTime(2023, 2, 14, 14, 9, 4, 898, DateTimeKind.Utc).AddTicks(9507), 2L, new DateTime(2023, 4, 4, 16, 14, 21, 886, DateTimeKind.Utc).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId" },
                values: new object[] { new DateTime(2023, 2, 22, 20, 2, 55, 480, DateTimeKind.Utc).AddTicks(1094), new DateTime(2022, 12, 27, 6, 15, 10, 725, DateTimeKind.Utc).AddTicks(891), new DateTime(2022, 7, 6, 7, 24, 3, 860, DateTimeKind.Utc).AddTicks(323), 2L });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 0, 11, 55, 905, DateTimeKind.Utc).AddTicks(6961), new DateTime(2023, 5, 28, 18, 19, 24, 565, DateTimeKind.Utc).AddTicks(5339), new DateTime(2023, 3, 27, 17, 48, 49, 357, DateTimeKind.Utc).AddTicks(5067), 1L, new DateTime(2023, 8, 15, 2, 38, 20, 224, DateTimeKind.Utc).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 4, 20, 5, 439, DateTimeKind.Utc).AddTicks(3607), new DateTime(2023, 4, 5, 17, 4, 50, 859, DateTimeKind.Utc).AddTicks(4571), new DateTime(2023, 2, 26, 23, 8, 59, 169, DateTimeKind.Utc).AddTicks(7583), 2L, new DateTime(2023, 7, 17, 8, 0, 35, 791, DateTimeKind.Utc).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 13, 11, 38, 40, 642, DateTimeKind.Utc).AddTicks(1395), new DateTime(2023, 7, 22, 12, 20, 35, 843, DateTimeKind.Utc).AddTicks(2235), new DateTime(2021, 8, 6, 18, 3, 38, 960, DateTimeKind.Utc).AddTicks(3589), 3L, new DateTime(2022, 6, 25, 4, 45, 54, 100, DateTimeKind.Utc).AddTicks(9077) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 8, 9, 33, 64, DateTimeKind.Utc).AddTicks(1157), new DateTime(2023, 8, 22, 13, 21, 16, 690, DateTimeKind.Utc).AddTicks(6170), new DateTime(2023, 8, 18, 12, 39, 42, 893, DateTimeKind.Utc).AddTicks(4550), 2L, new DateTime(2023, 8, 31, 4, 11, 22, 726, DateTimeKind.Utc).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 12, 11, 32, 7, 282, DateTimeKind.Utc).AddTicks(3828), new DateTime(2022, 4, 3, 13, 54, 26, 790, DateTimeKind.Utc).AddTicks(5239), new DateTime(2022, 2, 10, 20, 13, 14, 430, DateTimeKind.Utc).AddTicks(58), 3L, new DateTime(2023, 7, 3, 22, 39, 23, 609, DateTimeKind.Utc).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 9, 4, 3, 51, 14, 372, DateTimeKind.Utc).AddTicks(9133), new DateTime(2022, 6, 24, 22, 23, 22, 598, DateTimeKind.Utc).AddTicks(1726), new DateTime(2019, 6, 15, 21, 0, 49, 901, DateTimeKind.Utc).AddTicks(6899), 2L, new DateTime(2019, 8, 24, 21, 1, 15, 454, DateTimeKind.Utc).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 20, 19, 13, 32, 225, DateTimeKind.Utc).AddTicks(4135), new DateTime(2023, 9, 3, 22, 29, 54, 789, DateTimeKind.Utc).AddTicks(8743), new DateTime(2022, 8, 19, 13, 57, 46, 430, DateTimeKind.Utc).AddTicks(4166), 3L, new DateTime(2022, 9, 17, 6, 52, 11, 687, DateTimeKind.Utc).AddTicks(848) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2019, 12, 3, 8, 52, 28, 696, DateTimeKind.Utc).AddTicks(7007), new DateTime(2019, 10, 28, 22, 21, 34, 91, DateTimeKind.Utc).AddTicks(8294), new DateTime(2018, 8, 4, 15, 57, 55, 684, DateTimeKind.Utc).AddTicks(1474), 2L, new DateTime(2021, 3, 20, 19, 32, 15, 772, DateTimeKind.Utc).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 12, 19, 11, 53, 11, 715, DateTimeKind.Utc).AddTicks(9443), new DateTime(2021, 11, 24, 19, 33, 28, 666, DateTimeKind.Utc).AddTicks(3424), new DateTime(2021, 4, 10, 21, 31, 39, 868, DateTimeKind.Utc).AddTicks(8492), 3L, new DateTime(2021, 12, 9, 7, 10, 8, 664, DateTimeKind.Utc).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 22, 18, 53, 189, DateTimeKind.Utc).AddTicks(1381), new DateTime(2023, 4, 8, 11, 16, 14, 785, DateTimeKind.Utc).AddTicks(4592), new DateTime(2022, 7, 10, 22, 40, 16, 276, DateTimeKind.Utc).AddTicks(6660), 1L, new DateTime(2023, 4, 21, 5, 13, 53, 598, DateTimeKind.Utc).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 9, 13, 28, 52, 805, DateTimeKind.Utc).AddTicks(7153), new DateTime(2023, 8, 20, 1, 16, 10, 133, DateTimeKind.Utc).AddTicks(664), new DateTime(2023, 6, 29, 1, 51, 30, 157, DateTimeKind.Utc).AddTicks(4582), 2L, new DateTime(2023, 8, 25, 20, 38, 30, 540, DateTimeKind.Utc).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId" },
                values: new object[] { new DateTime(2024, 2, 26, 15, 59, 4, 802, DateTimeKind.Utc).AddTicks(4235), new DateTime(2023, 6, 30, 9, 51, 26, 154, DateTimeKind.Utc).AddTicks(2069), new DateTime(2023, 5, 25, 9, 53, 0, 917, DateTimeKind.Utc).AddTicks(1203), 3L });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 21, 43, 49, 852, DateTimeKind.Utc).AddTicks(926), new DateTime(2022, 7, 11, 11, 55, 48, 420, DateTimeKind.Utc).AddTicks(689), new DateTime(2020, 12, 19, 5, 13, 4, 234, DateTimeKind.Utc).AddTicks(9964), 3L, new DateTime(2022, 8, 9, 12, 5, 24, 712, DateTimeKind.Utc).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 12, 29, 8, 21, 9, 738, DateTimeKind.Utc).AddTicks(7213), new DateTime(2020, 1, 26, 17, 32, 31, 741, DateTimeKind.Utc).AddTicks(3944), new DateTime(2019, 11, 30, 7, 20, 30, 826, DateTimeKind.Utc).AddTicks(7639), 1L, new DateTime(2023, 6, 14, 12, 3, 34, 239, DateTimeKind.Utc).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 15, 19, 58, 742, DateTimeKind.Utc).AddTicks(3881), new DateTime(2023, 7, 18, 2, 46, 37, 343, DateTimeKind.Utc).AddTicks(8081), new DateTime(2020, 6, 7, 23, 39, 21, 745, DateTimeKind.Utc).AddTicks(2167), 1L, new DateTime(2020, 11, 4, 14, 47, 57, 281, DateTimeKind.Utc).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 27, 11, 54, 53, 500, DateTimeKind.Utc).AddTicks(1560), new DateTime(2023, 8, 22, 14, 30, 5, 660, DateTimeKind.Utc).AddTicks(3930), new DateTime(2023, 8, 8, 6, 32, 44, 246, DateTimeKind.Utc).AddTicks(7276), 2L, new DateTime(2023, 9, 6, 16, 35, 43, 216, DateTimeKind.Utc).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 1, 2, 46, 50, 862, DateTimeKind.Utc).AddTicks(1741), new DateTime(2023, 8, 17, 20, 50, 23, 696, DateTimeKind.Utc).AddTicks(7772), new DateTime(2023, 7, 3, 16, 31, 11, 372, DateTimeKind.Utc).AddTicks(522), 3L, new DateTime(2023, 7, 28, 13, 15, 39, 793, DateTimeKind.Utc).AddTicks(6124) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 8, 49, 10, 135, DateTimeKind.Utc).AddTicks(5622), new DateTime(2023, 4, 26, 20, 59, 27, 849, DateTimeKind.Utc).AddTicks(295), new DateTime(2022, 9, 18, 8, 39, 14, 812, DateTimeKind.Utc).AddTicks(3051), 2L, new DateTime(2023, 3, 23, 9, 11, 22, 354, DateTimeKind.Utc).AddTicks(4396) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 20, 2, 55, 24, 385, DateTimeKind.Utc).AddTicks(4293), new DateTime(2022, 2, 15, 20, 49, 10, 402, DateTimeKind.Utc).AddTicks(9776), new DateTime(2020, 6, 15, 1, 38, 55, 62, DateTimeKind.Utc).AddTicks(7334), 1L, new DateTime(2021, 11, 24, 9, 9, 40, 738, DateTimeKind.Utc).AddTicks(8249) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 17, 0, 18, 774, DateTimeKind.Utc).AddTicks(1980), new DateTime(2023, 8, 31, 5, 10, 22, 806, DateTimeKind.Utc).AddTicks(8705), new DateTime(2023, 4, 17, 15, 14, 15, 867, DateTimeKind.Utc).AddTicks(2624), 1L, new DateTime(2023, 8, 13, 19, 21, 0, 742, DateTimeKind.Utc).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 7, 5, 6, 19, 10, 960, DateTimeKind.Utc).AddTicks(3197), new DateTime(2021, 12, 14, 5, 56, 45, 199, DateTimeKind.Utc).AddTicks(8052), new DateTime(2020, 1, 5, 10, 53, 39, 26, DateTimeKind.Utc).AddTicks(1314), 2L, new DateTime(2021, 2, 23, 20, 0, 13, 899, DateTimeKind.Utc).AddTicks(151) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 6, 22, 2, 3, 15, 379, DateTimeKind.Utc).AddTicks(6863), new DateTime(2023, 8, 31, 5, 4, 7, 738, DateTimeKind.Utc).AddTicks(5303), new DateTime(2023, 4, 5, 21, 32, 3, 760, DateTimeKind.Utc).AddTicks(1621), 1L, new DateTime(2023, 8, 27, 16, 5, 13, 359, DateTimeKind.Utc).AddTicks(4469) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId" },
                values: new object[] { new DateTime(2021, 8, 14, 20, 12, 51, 956, DateTimeKind.Utc).AddTicks(8280), new DateTime(2021, 7, 1, 21, 8, 56, 121, DateTimeKind.Utc).AddTicks(1611), new DateTime(2020, 3, 7, 3, 12, 19, 193, DateTimeKind.Utc).AddTicks(1065), 2L });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 4, 30, 6, 47, 52, 528, DateTimeKind.Utc).AddTicks(8926), new DateTime(2021, 5, 14, 0, 21, 17, 220, DateTimeKind.Utc).AddTicks(534), new DateTime(2019, 10, 31, 13, 22, 36, 651, DateTimeKind.Utc).AddTicks(5146), 1L, new DateTime(2023, 2, 18, 3, 12, 44, 535, DateTimeKind.Utc).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 19, 16, 25, 10, 349, DateTimeKind.Utc).AddTicks(709), new DateTime(2023, 8, 9, 2, 12, 14, 568, DateTimeKind.Utc).AddTicks(474), new DateTime(2023, 7, 8, 1, 59, 26, 32, DateTimeKind.Utc).AddTicks(3633), 3L, new DateTime(2023, 8, 3, 10, 50, 54, 389, DateTimeKind.Utc).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 14, 2, 33, 140, DateTimeKind.Utc).AddTicks(3304), new DateTime(2023, 8, 7, 6, 43, 39, 637, DateTimeKind.Utc).AddTicks(7692), new DateTime(2022, 3, 25, 17, 4, 43, 201, DateTimeKind.Utc).AddTicks(3003), 1L, new DateTime(2022, 4, 13, 23, 36, 12, 198, DateTimeKind.Utc).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 3, 27, 8, 54, 0, 906, DateTimeKind.Utc).AddTicks(9922), new DateTime(2022, 9, 11, 20, 46, 3, 381, DateTimeKind.Utc).AddTicks(1371), new DateTime(2021, 10, 22, 0, 37, 13, 456, DateTimeKind.Utc).AddTicks(7408), 1L, new DateTime(2022, 4, 14, 7, 27, 38, 586, DateTimeKind.Utc).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 1, 20, 22, 40, 23, 102, DateTimeKind.Utc).AddTicks(9491), new DateTime(2022, 9, 23, 22, 7, 44, 186, DateTimeKind.Utc).AddTicks(1142), new DateTime(2022, 8, 9, 0, 40, 54, 481, DateTimeKind.Utc).AddTicks(8048), 3L, new DateTime(2023, 8, 5, 18, 59, 12, 390, DateTimeKind.Utc).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 6, 5, 52, 45, 344, DateTimeKind.Utc).AddTicks(2948), new DateTime(2023, 9, 11, 19, 9, 13, 103, DateTimeKind.Utc).AddTicks(176), new DateTime(2023, 7, 9, 19, 20, 59, 233, DateTimeKind.Utc).AddTicks(1474), 1L, new DateTime(2023, 7, 17, 6, 54, 55, 24, DateTimeKind.Utc).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 4, 15, 2, 7, 629, DateTimeKind.Utc).AddTicks(8078), new DateTime(2022, 9, 19, 19, 31, 55, 783, DateTimeKind.Utc).AddTicks(882), new DateTime(2022, 6, 10, 10, 58, 56, 20, DateTimeKind.Utc).AddTicks(9444), 1L, new DateTime(2022, 12, 13, 12, 43, 55, 370, DateTimeKind.Utc).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 7, 24, 37, 793, DateTimeKind.Utc).AddTicks(4943), new DateTime(2023, 3, 15, 2, 50, 29, 950, DateTimeKind.Utc).AddTicks(4133), new DateTime(2023, 2, 19, 9, 43, 56, 285, DateTimeKind.Utc).AddTicks(9637), 3L, new DateTime(2023, 5, 5, 21, 45, 27, 991, DateTimeKind.Utc).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 5, 14, 11, 270, DateTimeKind.Utc).AddTicks(5349), new DateTime(2022, 12, 2, 20, 42, 55, 247, DateTimeKind.Utc).AddTicks(5306), new DateTime(2017, 4, 19, 12, 13, 54, 42, DateTimeKind.Utc).AddTicks(3594), 2L, new DateTime(2023, 7, 16, 8, 47, 46, 390, DateTimeKind.Utc).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 23, 21, 23, 18, 282, DateTimeKind.Utc).AddTicks(6081), new DateTime(2023, 1, 16, 7, 11, 27, 94, DateTimeKind.Utc).AddTicks(7165), new DateTime(2022, 11, 2, 2, 25, 44, 282, DateTimeKind.Utc).AddTicks(2841), 1L, new DateTime(2023, 3, 16, 0, 17, 43, 866, DateTimeKind.Utc).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 4, 17, 55, 17, 14, DateTimeKind.Utc).AddTicks(3182), new DateTime(2022, 8, 23, 12, 38, 23, 141, DateTimeKind.Utc).AddTicks(9035), new DateTime(2021, 10, 12, 3, 31, 27, 410, DateTimeKind.Utc).AddTicks(2370), 1L, new DateTime(2023, 4, 5, 12, 20, 15, 686, DateTimeKind.Utc).AddTicks(5426) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 10, 8, 32, 42, 878, DateTimeKind.Utc).AddTicks(7963), new DateTime(2023, 3, 31, 9, 32, 35, 356, DateTimeKind.Utc).AddTicks(8378), new DateTime(2019, 11, 5, 8, 19, 57, 534, DateTimeKind.Utc).AddTicks(6113), 2L, new DateTime(2020, 8, 27, 11, 5, 27, 200, DateTimeKind.Utc).AddTicks(6519) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 13, 6, 21, 22, 646, DateTimeKind.Utc).AddTicks(3661), new DateTime(2023, 5, 16, 15, 58, 29, 758, DateTimeKind.Utc).AddTicks(6233), new DateTime(2022, 3, 3, 8, 31, 50, 2, DateTimeKind.Utc).AddTicks(9544), 1L, new DateTime(2022, 7, 14, 15, 13, 12, 98, DateTimeKind.Utc).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 28, 7, 39, 51, 551, DateTimeKind.Utc).AddTicks(4143), new DateTime(2022, 10, 29, 13, 8, 23, 415, DateTimeKind.Utc).AddTicks(8189), new DateTime(2022, 6, 3, 5, 34, 45, 111, DateTimeKind.Utc).AddTicks(3966), 2L, new DateTime(2023, 4, 12, 17, 2, 37, 876, DateTimeKind.Utc).AddTicks(8322) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 6, 8, 10, 32, 55, 569, DateTimeKind.Utc).AddTicks(7491), new DateTime(2021, 8, 10, 19, 27, 26, 832, DateTimeKind.Utc).AddTicks(983), new DateTime(2021, 6, 24, 2, 56, 1, 304, DateTimeKind.Utc).AddTicks(136), 2L, new DateTime(2022, 4, 6, 19, 4, 28, 87, DateTimeKind.Utc).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 11, 20, 7, 47, 178, DateTimeKind.Utc).AddTicks(9281), new DateTime(2023, 9, 4, 19, 0, 48, 303, DateTimeKind.Utc).AddTicks(7222), new DateTime(2019, 3, 26, 1, 20, 43, 307, DateTimeKind.Utc).AddTicks(2094), 1L, new DateTime(2020, 11, 16, 9, 16, 32, 483, DateTimeKind.Utc).AddTicks(8675) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 4, 56, 2, 461, DateTimeKind.Utc).AddTicks(6638), new DateTime(2022, 10, 26, 2, 37, 16, 876, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 6, 17, 0, 2, 14, 407, DateTimeKind.Utc).AddTicks(71), 3L, new DateTime(2022, 12, 22, 10, 34, 6, 838, DateTimeKind.Utc).AddTicks(7153) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2018, 4, 5, 15, 0, 35, 199, DateTimeKind.Utc).AddTicks(6957), new DateTime(2018, 3, 19, 13, 15, 37, 677, DateTimeKind.Utc).AddTicks(5845), new DateTime(2017, 9, 20, 1, 53, 55, 184, DateTimeKind.Utc).AddTicks(5758), 3L, new DateTime(2019, 7, 12, 5, 21, 2, 588, DateTimeKind.Utc).AddTicks(4355) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 8, 2, 22, 49, 42, 695, DateTimeKind.Utc).AddTicks(143), new DateTime(2023, 8, 7, 10, 3, 14, 712, DateTimeKind.Utc).AddTicks(4888), new DateTime(2023, 7, 6, 4, 20, 42, 985, DateTimeKind.Utc).AddTicks(2903), 1L, new DateTime(2023, 7, 11, 21, 56, 3, 67, DateTimeKind.Utc).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 22, 9, 45, 527, DateTimeKind.Utc).AddTicks(4852), new DateTime(2023, 1, 24, 0, 25, 57, 290, DateTimeKind.Utc).AddTicks(1655), new DateTime(2021, 7, 7, 0, 55, 27, 474, DateTimeKind.Utc).AddTicks(9499), 2L, new DateTime(2022, 11, 4, 4, 26, 19, 889, DateTimeKind.Utc).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 3, 22, 9, 12, 28, 975, DateTimeKind.Utc).AddTicks(1687), new DateTime(2022, 2, 26, 6, 38, 11, 215, DateTimeKind.Utc).AddTicks(4011), new DateTime(2021, 10, 31, 19, 39, 32, 403, DateTimeKind.Utc).AddTicks(5241), 1L, new DateTime(2023, 2, 7, 17, 2, 10, 389, DateTimeKind.Utc).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 26, 10, 11, 54, 912, DateTimeKind.Utc).AddTicks(8324), new DateTime(2023, 4, 29, 1, 57, 47, 343, DateTimeKind.Utc).AddTicks(7553), new DateTime(2022, 10, 13, 18, 39, 4, 444, DateTimeKind.Utc).AddTicks(3691), 2L, new DateTime(2023, 8, 26, 3, 11, 50, 986, DateTimeKind.Utc).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 23, 49, 28, 558, DateTimeKind.Utc).AddTicks(2903), new DateTime(2023, 8, 18, 4, 37, 27, 560, DateTimeKind.Utc).AddTicks(8948), new DateTime(2022, 3, 12, 0, 0, 49, 951, DateTimeKind.Utc).AddTicks(3282), 1L, new DateTime(2022, 8, 26, 8, 53, 57, 484, DateTimeKind.Utc).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 3, 17, 26, 839, DateTimeKind.Utc).AddTicks(6398), new DateTime(2023, 6, 26, 16, 7, 30, 624, DateTimeKind.Utc).AddTicks(4952), new DateTime(2021, 7, 8, 23, 55, 59, 232, DateTimeKind.Utc).AddTicks(596), 1L, new DateTime(2021, 12, 12, 21, 7, 35, 484, DateTimeKind.Utc).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 5, 5, 48, 49, 501, DateTimeKind.Utc).AddTicks(9435), new DateTime(2023, 8, 18, 14, 45, 16, 329, DateTimeKind.Utc).AddTicks(2262), new DateTime(2023, 7, 5, 15, 57, 0, 346, DateTimeKind.Utc).AddTicks(9670), 3L, new DateTime(2023, 9, 6, 11, 9, 16, 250, DateTimeKind.Utc).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 9, 10, 1, 29, 914, DateTimeKind.Utc).AddTicks(3624), new DateTime(2023, 5, 14, 7, 29, 11, 987, DateTimeKind.Utc).AddTicks(8213), new DateTime(2023, 3, 24, 8, 54, 20, 433, DateTimeKind.Utc).AddTicks(2469), 2L, new DateTime(2023, 3, 29, 23, 39, 32, 444, DateTimeKind.Utc).AddTicks(6009) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 20, 2, 15, 29, 212, DateTimeKind.Utc).AddTicks(1269), new DateTime(2023, 1, 1, 19, 33, 2, 629, DateTimeKind.Utc).AddTicks(9116), new DateTime(2022, 2, 21, 22, 6, 59, 877, DateTimeKind.Utc).AddTicks(3660), 2L, new DateTime(2022, 7, 19, 6, 44, 29, 558, DateTimeKind.Utc).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId" },
                values: new object[] { new DateTime(2023, 7, 4, 18, 46, 33, 169, DateTimeKind.Utc).AddTicks(1093), new DateTime(2023, 6, 5, 7, 38, 7, 636, DateTimeKind.Utc).AddTicks(6754), new DateTime(2022, 1, 9, 17, 39, 39, 297, DateTimeKind.Utc).AddTicks(2889), 1L });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 5, 13, 12, 14, 20, DateTimeKind.Utc).AddTicks(1534), new DateTime(2022, 12, 30, 14, 14, 39, 27, DateTimeKind.Utc).AddTicks(2812), new DateTime(2022, 11, 11, 9, 51, 5, 304, DateTimeKind.Utc).AddTicks(4910), 1L, new DateTime(2023, 9, 5, 4, 18, 3, 849, DateTimeKind.Utc).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2019, 6, 3, 5, 20, 41, 739, DateTimeKind.Utc).AddTicks(7699), new DateTime(2018, 11, 23, 20, 50, 8, 319, DateTimeKind.Utc).AddTicks(3911), new DateTime(2017, 4, 11, 22, 19, 25, 86, DateTimeKind.Utc).AddTicks(381), 3L, new DateTime(2017, 12, 27, 21, 22, 36, 676, DateTimeKind.Utc).AddTicks(5114) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 7, 17, 39, 34, 631, DateTimeKind.Utc).AddTicks(6351), new DateTime(2022, 9, 28, 13, 7, 49, 936, DateTimeKind.Utc).AddTicks(7619), new DateTime(2021, 11, 1, 20, 11, 49, 982, DateTimeKind.Utc).AddTicks(1825), 1L, new DateTime(2022, 8, 7, 3, 0, 36, 677, DateTimeKind.Utc).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 52, 1, 773, DateTimeKind.Utc).AddTicks(5519), new DateTime(2023, 9, 9, 14, 11, 51, 988, DateTimeKind.Utc).AddTicks(4891), new DateTime(2023, 9, 7, 14, 39, 29, 907, DateTimeKind.Utc).AddTicks(8920), 2L, new DateTime(2023, 9, 9, 18, 42, 48, 914, DateTimeKind.Utc).AddTicks(4872) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 10, 23, 19, 8, 49, 749, DateTimeKind.Utc).AddTicks(2567), new DateTime(2021, 11, 25, 0, 1, 33, 402, DateTimeKind.Utc).AddTicks(3793), new DateTime(2018, 4, 21, 0, 56, 35, 925, DateTimeKind.Utc).AddTicks(5623), 3L, new DateTime(2019, 7, 12, 20, 51, 35, 910, DateTimeKind.Utc).AddTicks(2992) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 7, 5, 4, 26, 29, 529, DateTimeKind.Utc).AddTicks(5409), new DateTime(2023, 9, 9, 9, 35, 36, 43, DateTimeKind.Utc).AddTicks(3156), new DateTime(2023, 9, 1, 20, 6, 20, 437, DateTimeKind.Utc).AddTicks(6978), 1L, new DateTime(2023, 9, 5, 15, 54, 2, 62, DateTimeKind.Utc).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 2, 25, 11, 961, DateTimeKind.Utc).AddTicks(4274), new DateTime(2023, 4, 10, 10, 23, 48, 55, DateTimeKind.Utc).AddTicks(9749), new DateTime(2016, 11, 13, 20, 28, 5, 882, DateTimeKind.Utc).AddTicks(1770), 1L, new DateTime(2020, 9, 28, 8, 24, 40, 950, DateTimeKind.Utc).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 4, 50, 26, 921, DateTimeKind.Utc).AddTicks(8144), new DateTime(2023, 4, 8, 7, 14, 20, 692, DateTimeKind.Utc).AddTicks(5301), new DateTime(2022, 9, 4, 15, 22, 31, 749, DateTimeKind.Utc).AddTicks(3213), 1L, new DateTime(2023, 8, 21, 5, 25, 28, 854, DateTimeKind.Utc).AddTicks(2491) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 47, 22, 63, DateTimeKind.Utc).AddTicks(6478), new DateTime(2023, 4, 11, 5, 40, 38, 133, DateTimeKind.Utc).AddTicks(2847), new DateTime(2023, 4, 6, 2, 29, 13, 35, DateTimeKind.Utc).AddTicks(266), 3L, new DateTime(2023, 8, 7, 16, 30, 48, 666, DateTimeKind.Utc).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 2, 12, 9, 25, 43, 193, DateTimeKind.Utc).AddTicks(9717), new DateTime(2021, 1, 29, 16, 23, 27, 445, DateTimeKind.Utc).AddTicks(4003), new DateTime(2019, 6, 24, 17, 33, 24, 46, DateTimeKind.Utc).AddTicks(1485), 3L, new DateTime(2022, 10, 4, 16, 1, 34, 356, DateTimeKind.Utc).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 23, 2, 50, 34, 60, DateTimeKind.Utc).AddTicks(5617), new DateTime(2023, 5, 8, 21, 11, 6, 605, DateTimeKind.Utc).AddTicks(3856), new DateTime(2022, 9, 27, 15, 4, 24, 773, DateTimeKind.Utc).AddTicks(9696), 3L, new DateTime(2023, 1, 14, 9, 22, 9, 989, DateTimeKind.Utc).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId" },
                values: new object[] { new DateTime(2024, 3, 6, 20, 56, 35, 122, DateTimeKind.Utc).AddTicks(3429), new DateTime(2023, 6, 4, 13, 7, 41, 967, DateTimeKind.Utc).AddTicks(9852), new DateTime(2019, 4, 6, 19, 40, 35, 213, DateTimeKind.Utc).AddTicks(1586), 1L });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 9, 26, 20, 44, 5, 290, DateTimeKind.Utc).AddTicks(3879), new DateTime(2021, 9, 30, 13, 53, 43, 345, DateTimeKind.Utc).AddTicks(3514), new DateTime(2021, 4, 4, 20, 15, 2, 989, DateTimeKind.Utc).AddTicks(2978), 1L, new DateTime(2023, 6, 4, 12, 49, 27, 767, DateTimeKind.Utc).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 6, 22, 49, 59, 974, DateTimeKind.Utc).AddTicks(9452), new DateTime(2023, 8, 1, 22, 57, 49, 196, DateTimeKind.Utc).AddTicks(9024), new DateTime(2023, 7, 20, 16, 47, 7, 176, DateTimeKind.Utc).AddTicks(3734), 1L, new DateTime(2023, 8, 19, 0, 7, 1, 287, DateTimeKind.Utc).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 1, 0, 6, 48, 574, DateTimeKind.Utc).AddTicks(6810), new DateTime(2023, 6, 11, 11, 8, 4, 995, DateTimeKind.Utc).AddTicks(3404), new DateTime(2023, 1, 18, 4, 59, 1, 335, DateTimeKind.Utc).AddTicks(2964), 1L, new DateTime(2023, 3, 24, 3, 54, 12, 608, DateTimeKind.Utc).AddTicks(6521) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 22, 4, 10, 23, 609, DateTimeKind.Utc).AddTicks(3174), new DateTime(2023, 2, 4, 13, 31, 41, 16, DateTimeKind.Utc).AddTicks(2849), new DateTime(2022, 5, 28, 16, 3, 31, 208, DateTimeKind.Utc).AddTicks(6274), 3L, new DateTime(2023, 3, 5, 20, 49, 2, 285, DateTimeKind.Utc).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 5, 18, 23, 27, 5, 184, DateTimeKind.Utc).AddTicks(1625), new DateTime(2020, 6, 25, 13, 59, 23, 402, DateTimeKind.Utc).AddTicks(518), new DateTime(2017, 10, 12, 2, 55, 33, 795, DateTimeKind.Utc).AddTicks(2190), 1L, new DateTime(2018, 6, 1, 12, 2, 5, 130, DateTimeKind.Utc).AddTicks(8294) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 4, 12, 25, 11, 311, DateTimeKind.Utc).AddTicks(6456), new DateTime(2023, 7, 24, 4, 49, 21, 293, DateTimeKind.Utc).AddTicks(1733), new DateTime(2021, 5, 19, 19, 33, 0, 290, DateTimeKind.Utc).AddTicks(1471), 3L, new DateTime(2021, 10, 11, 23, 26, 9, 258, DateTimeKind.Utc).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 21, 3, 32, 40, 499, DateTimeKind.Utc).AddTicks(6505), new DateTime(2023, 2, 26, 14, 13, 57, 247, DateTimeKind.Utc).AddTicks(9591), new DateTime(2022, 12, 17, 23, 26, 37, 743, DateTimeKind.Utc).AddTicks(2768), 1L, new DateTime(2023, 2, 11, 8, 48, 5, 650, DateTimeKind.Utc).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 17, 16, 57, 863, DateTimeKind.Utc).AddTicks(5936), new DateTime(2023, 8, 2, 13, 33, 45, 998, DateTimeKind.Utc).AddTicks(3861), new DateTime(2022, 12, 31, 16, 31, 41, 239, DateTimeKind.Utc).AddTicks(8255), 1L, new DateTime(2023, 8, 7, 15, 15, 17, 855, DateTimeKind.Utc).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 8, 27, 0, 53, 26, 183, DateTimeKind.Utc).AddTicks(7621), new DateTime(2022, 5, 25, 3, 49, 52, 801, DateTimeKind.Utc).AddTicks(3799), new DateTime(2021, 7, 6, 11, 9, 31, 126, DateTimeKind.Utc).AddTicks(2476), 1L, new DateTime(2022, 1, 28, 8, 9, 38, 768, DateTimeKind.Utc).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 6, 29, 21, 28, 21, 647, DateTimeKind.Utc).AddTicks(972), new DateTime(2023, 9, 2, 2, 59, 51, 27, DateTimeKind.Utc).AddTicks(548), new DateTime(2023, 6, 15, 17, 58, 30, 565, DateTimeKind.Utc).AddTicks(9569), 2L, new DateTime(2023, 7, 29, 23, 37, 34, 410, DateTimeKind.Utc).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 29, 7, 34, 1, 546, DateTimeKind.Utc).AddTicks(6069), new DateTime(2023, 8, 30, 19, 33, 40, 831, DateTimeKind.Utc).AddTicks(8731), new DateTime(2023, 8, 11, 23, 46, 35, 67, DateTimeKind.Utc).AddTicks(4874), 1L, new DateTime(2023, 8, 27, 1, 52, 58, 442, DateTimeKind.Utc).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 4, 4, 9, 22, 59, 727, DateTimeKind.Utc).AddTicks(661), new DateTime(2020, 12, 13, 10, 27, 14, 126, DateTimeKind.Utc).AddTicks(7609), new DateTime(2019, 10, 10, 5, 43, 15, 150, DateTimeKind.Utc).AddTicks(3019), 2L, new DateTime(2023, 7, 31, 11, 30, 33, 87, DateTimeKind.Utc).AddTicks(3979) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 6, 18, 17, 8, 593, DateTimeKind.Utc).AddTicks(1940), new DateTime(2023, 4, 20, 12, 17, 8, 802, DateTimeKind.Utc).AddTicks(2353), new DateTime(2022, 11, 17, 12, 56, 4, 536, DateTimeKind.Utc).AddTicks(4405), 3L, new DateTime(2023, 1, 20, 16, 27, 2, 592, DateTimeKind.Utc).AddTicks(9298) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 1, 5, 21, 34, 48, 511, DateTimeKind.Utc).AddTicks(8013), new DateTime(2022, 9, 4, 4, 44, 9, 255, DateTimeKind.Utc).AddTicks(5297), new DateTime(2022, 8, 23, 6, 27, 28, 773, DateTimeKind.Utc).AddTicks(4955), 1L, new DateTime(2023, 1, 29, 10, 37, 46, 555, DateTimeKind.Utc).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 10, 25, 9, 29, 55, 112, DateTimeKind.Utc).AddTicks(8776), new DateTime(2019, 11, 16, 14, 1, 24, 218, DateTimeKind.Utc).AddTicks(8191), new DateTime(2017, 6, 28, 12, 55, 32, 897, DateTimeKind.Utc).AddTicks(1364), 2L, new DateTime(2018, 8, 8, 23, 59, 54, 111, DateTimeKind.Utc).AddTicks(7341) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 30, 3, 2, 59, 457, DateTimeKind.Utc).AddTicks(820), new DateTime(2023, 7, 26, 14, 44, 3, 471, DateTimeKind.Utc).AddTicks(1490), new DateTime(2023, 7, 1, 23, 47, 25, 838, DateTimeKind.Utc).AddTicks(2083), 1L, new DateTime(2023, 7, 16, 18, 42, 51, 512, DateTimeKind.Utc).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 23, 18, 9, 44, 619, DateTimeKind.Utc).AddTicks(420), new DateTime(2022, 11, 27, 7, 22, 48, 902, DateTimeKind.Utc).AddTicks(2641), new DateTime(2022, 5, 13, 15, 39, 1, 191, DateTimeKind.Utc).AddTicks(2922), 1L, new DateTime(2023, 1, 9, 23, 4, 12, 174, DateTimeKind.Utc).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 1, 5, 21, 15, 2, 820, DateTimeKind.Utc).AddTicks(3341), new DateTime(2020, 5, 1, 23, 9, 5, 831, DateTimeKind.Utc).AddTicks(177), new DateTime(2019, 8, 30, 23, 34, 44, 737, DateTimeKind.Utc).AddTicks(6679), 1L, new DateTime(2020, 12, 3, 5, 6, 5, 161, DateTimeKind.Utc).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 8, 22, 21, 58, 974, DateTimeKind.Utc).AddTicks(730), new DateTime(2023, 8, 11, 12, 50, 16, 67, DateTimeKind.Utc).AddTicks(5006), new DateTime(2023, 5, 2, 22, 47, 39, 465, DateTimeKind.Utc).AddTicks(9212), 3L, new DateTime(2023, 8, 28, 19, 39, 44, 136, DateTimeKind.Utc).AddTicks(6721) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 23, 13, 37, 3, 56, DateTimeKind.Utc).AddTicks(899), new DateTime(2022, 8, 19, 7, 37, 58, 421, DateTimeKind.Utc).AddTicks(6617), new DateTime(2022, 6, 19, 16, 13, 40, 0, DateTimeKind.Utc).AddTicks(6559), 1L, new DateTime(2022, 10, 10, 19, 25, 46, 76, DateTimeKind.Utc).AddTicks(6708) });

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
                value: new DateTime(2023, 9, 10, 18, 59, 40, 766, DateTimeKind.Utc).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 30, 2, 37, 0, 37, DateTimeKind.Utc).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 20, 15, 58, 3, 268, DateTimeKind.Utc).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 19, 28, 32, 715, DateTimeKind.Utc).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 23, 17, 39, 37, 825, DateTimeKind.Utc).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 19, 6, 18, 19, 447, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 22, 35, 59, 290, DateTimeKind.Utc).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 5, 34, 52, 712, DateTimeKind.Utc).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 3, 4, 49, 6, 968, DateTimeKind.Utc).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 21, 7, 20, 43, 108, DateTimeKind.Utc).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 18, 4, 29, 37, 532, DateTimeKind.Utc).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 14, 20, 13, 1, 543, DateTimeKind.Utc).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 2, 9, 33, 18, 370, DateTimeKind.Utc).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 6, 54, 76, DateTimeKind.Utc).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 1, 15, 52, 21, 557, DateTimeKind.Utc).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 14, 17, 51, 21, 820, DateTimeKind.Utc).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 8, 18, 13, 42, 425, DateTimeKind.Utc).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 12, 13, 22, 54, 488, DateTimeKind.Utc).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 12, 23, 26, 28, 502, DateTimeKind.Utc).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 3, 15, 37, 17, 43, DateTimeKind.Utc).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 26, 9, 11, 14, 721, DateTimeKind.Utc).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 11, 0, 35, 15, 63, DateTimeKind.Utc).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 30, 11, 10, 51, 856, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 15, 16, 2, 13, 773, DateTimeKind.Utc).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 22, 10, 13, 52, 376, DateTimeKind.Utc).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 7, 20, 42, 9, 740, DateTimeKind.Utc).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 19, 2, 4, 16, 84, DateTimeKind.Utc).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 25, 15, 20, 32, 826, DateTimeKind.Utc).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 15, 0, 53, 5, 848, DateTimeKind.Utc).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 3, 20, 53, 48, DateTimeKind.Utc).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 26, 12, 0, 42, 558, DateTimeKind.Utc).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 17, 58, 32, 698, DateTimeKind.Utc).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 6, 4, 27, 4, 169, DateTimeKind.Utc).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 6, 22, 29, 17, 309, DateTimeKind.Utc).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedAt",
                value: new DateTime(2020, 3, 27, 3, 41, 17, 172, DateTimeKind.Utc).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 5, 56, 29, 264, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 20, 4, 37, 249, DateTimeKind.Utc).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 2, 0, 5, 31, 364, DateTimeKind.Utc).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 11, 4, 59, 32, 943, DateTimeKind.Utc).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 15, 7, 26, 15, 690, DateTimeKind.Utc).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 24, 10, 7, 4, 170, DateTimeKind.Utc).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 4, 26, 2, 874, DateTimeKind.Utc).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 7, 8, 3, 251, DateTimeKind.Utc).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 27, 1, 35, 21, 839, DateTimeKind.Utc).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 10, 11, 49, 9, 923, DateTimeKind.Utc).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 19, 52, 32, 711, DateTimeKind.Utc).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedAt",
                value: new DateTime(2021, 6, 6, 12, 19, 29, 773, DateTimeKind.Utc).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 48L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 14, 23, 11, 17, 12, DateTimeKind.Utc).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 8, 54, 7, 810, DateTimeKind.Utc).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 4, 41, 3, 740, DateTimeKind.Utc).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 5, 25, 51, 122, DateTimeKind.Utc).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 8, 21, 42, 943, DateTimeKind.Utc).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 15, 12, 24, 23, 924, DateTimeKind.Utc).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 20, 14, 25, 17, 137, DateTimeKind.Utc).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 0, 14, 54, 85, DateTimeKind.Utc).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 56L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 12, 18, 5, 20, 362, DateTimeKind.Utc).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 3, 5, 26, 586, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 25, 19, 42, 35, 763, DateTimeKind.Utc).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 23, 34, 27, 92, DateTimeKind.Utc).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 16, 2, 11, 45, 526, DateTimeKind.Utc).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 25, 16, 14, 1, 906, DateTimeKind.Utc).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 1, 59, 39, 807, DateTimeKind.Utc).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 12, 21, 12, 277, DateTimeKind.Utc).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 64L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 20, 11, 47, 32, 509, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 3, 9, 10, 38, 101, DateTimeKind.Utc).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 16, 31, 19, 350, DateTimeKind.Utc).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 14, 10, 18, 45, 422, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 25, 8, 49, 43, 310, DateTimeKind.Utc).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 20, 4, 10, 652, DateTimeKind.Utc).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 30, 11, 28, 43, 544, DateTimeKind.Utc).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 8, 13, 8, 0, 965, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 72L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 19, 1, 35, 27, 978, DateTimeKind.Utc).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 28, 1, 55, 53, 465, DateTimeKind.Utc).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 15, 32, 27, 618, DateTimeKind.Utc).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 13, 3, 55, 2, 961, DateTimeKind.Utc).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 31, 12, 11, 47, 889, DateTimeKind.Utc).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 1, 8, 54, 46, 636, DateTimeKind.Utc).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 11, 23, 34, 289, DateTimeKind.Utc).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 21, 12, 55, 28, 176, DateTimeKind.Utc).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 80L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 4, 35, 33, 47, DateTimeKind.Utc).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 25, 14, 35, 55, 701, DateTimeKind.Utc).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 18, 17, 54, 113, DateTimeKind.Utc).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 17, 11, 38, 270, DateTimeKind.Utc).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedAt",
                value: new DateTime(2020, 2, 3, 16, 8, 41, 689, DateTimeKind.Utc).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 11, 3, 18, 21, 463, DateTimeKind.Utc).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 2, 13, 40, 766, DateTimeKind.Utc).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 15, 5, 43, 21, 776, DateTimeKind.Utc).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 88L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 28, 0, 52, 43, 551, DateTimeKind.Utc).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 24, 17, 24, 10, 618, DateTimeKind.Utc).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 29, 12, 38, 2, 113, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 20, 16, 12, 52, 464, DateTimeKind.Utc).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 10, 3, 35, 41, 242, DateTimeKind.Utc).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 12, 10, 15, 26, 56, DateTimeKind.Utc).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 26, 2, 50, 51, 925, DateTimeKind.Utc).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 30, 0, 14, 9, 821, DateTimeKind.Utc).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 96L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 8, 3, 7, 40, 548, DateTimeKind.Utc).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 18, 10, 55, 285, DateTimeKind.Utc).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 14, 6, 1, 10, 16, DateTimeKind.Utc).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 18, 3, 29, 0, 96, DateTimeKind.Utc).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 23, 13, 50, 24, 258, DateTimeKind.Utc).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 21, 27, 33, 101, DateTimeKind.Utc).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 7, 1, 58, 41, 750, DateTimeKind.Utc).AddTicks(2825));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 3, 9, 38, 30, 846, DateTimeKind.Utc).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 104L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 6, 22, 18, 34, 496, DateTimeKind.Utc).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 22, 15, 30, 38, 589, DateTimeKind.Utc).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedAt",
                value: new DateTime(2021, 12, 12, 13, 29, 4, 132, DateTimeKind.Utc).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 4, 15, 21, 32, 624, DateTimeKind.Utc).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 30, 9, 27, 7, 681, DateTimeKind.Utc).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 29, 16, 5, 24, 691, DateTimeKind.Utc).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 28, 14, 43, 2, 74, DateTimeKind.Utc).AddTicks(1594));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 2, 20, 33, 56, 595, DateTimeKind.Utc).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 112L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 5, 47, 24, 691, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 22, 14, 53, 50, 665, DateTimeKind.Utc).AddTicks(1171));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 3, 13, 4, 35, 61, DateTimeKind.Utc).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 7, 1, 57, 58, 801, DateTimeKind.Utc).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 7, 19, 28, 56, 784, DateTimeKind.Utc).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedAt",
                value: new DateTime(2022, 1, 2, 15, 14, 29, 519, DateTimeKind.Utc).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedAt",
                value: new DateTime(2022, 1, 27, 9, 20, 25, 318, DateTimeKind.Utc).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 9, 19, 43, 166, DateTimeKind.Utc).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 120L,
                column: "CreatedAt",
                value: new DateTime(2022, 1, 9, 10, 53, 2, 974, DateTimeKind.Utc).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 15, 58, 28, 282, DateTimeKind.Utc).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 10, 7, 50, 42, 956, DateTimeKind.Utc).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 20, 20, 9, 37, 355, DateTimeKind.Utc).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 2, 18, 52, 47, 59, DateTimeKind.Utc).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 7, 6, 35, 35, 172, DateTimeKind.Utc).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 20, 3, 10, 53, 445, DateTimeKind.Utc).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 9, 21, 56, 36, 960, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 128L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 16, 9, 7, 514, DateTimeKind.Utc).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 14, 30, 2, 967, DateTimeKind.Utc).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 3, 23, 10, 37, 925, DateTimeKind.Utc).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 2, 45, 17, 743, DateTimeKind.Utc).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 20, 15, 20, 417, DateTimeKind.Utc).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 23, 23, 59, 59, 601, DateTimeKind.Utc).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 31, 2, 0, 50, 875, DateTimeKind.Utc).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 9, 2, 41, 283, DateTimeKind.Utc).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 136L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 10, 4, 9, 42, 487, DateTimeKind.Utc).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 21, 3, 22, 31, 351, DateTimeKind.Utc).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 10, 2, 4, 12, 958, DateTimeKind.Utc).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 18, 10, 31, 657, DateTimeKind.Utc).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 5, 18, 43, 28, 807, DateTimeKind.Utc).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 10, 5, 41, 643, DateTimeKind.Utc).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 23, 2, 37, 6, 288, DateTimeKind.Utc).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 7, 16, 32, 1, 181, DateTimeKind.Utc).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 144L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 10, 16, 19, 56, 834, DateTimeKind.Utc).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 15, 44, 26, 291, DateTimeKind.Utc).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedAt",
                value: new DateTime(2021, 12, 14, 19, 58, 38, 268, DateTimeKind.Utc).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 6, 15, 22, 32, 643, DateTimeKind.Utc).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 4, 0, 55, 4, 98, DateTimeKind.Utc).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 26, 4, 41, 21, 557, DateTimeKind.Utc).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 7, 10, 30, 14, 273, DateTimeKind.Utc).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 6, 18, 32, 194, DateTimeKind.Utc).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 152L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 19, 15, 31, 37, 135, DateTimeKind.Utc).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 18, 2, 50, 58, 287, DateTimeKind.Utc).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 11, 4, 36, 9, 588, DateTimeKind.Utc).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 31, 20, 36, 26, 957, DateTimeKind.Utc).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 16, 13, 14, 34, 551, DateTimeKind.Utc).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 29, 6, 32, 21, 136, DateTimeKind.Utc).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 7, 22, 27, 30, 729, DateTimeKind.Utc).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 26, 19, 21, 58, 461, DateTimeKind.Utc).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 160L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 24, 19, 4, 29, 770, DateTimeKind.Utc).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 7, 1, 34, 20, 439, DateTimeKind.Utc).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 13, 14, 47, 47, 946, DateTimeKind.Utc).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 26, 19, 0, 15, 496, DateTimeKind.Utc).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 18, 17, 54, 534, DateTimeKind.Utc).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 11, 23, 44, 36, 521, DateTimeKind.Utc).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 9, 34, 34, 210, DateTimeKind.Utc).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 7, 19, 7, 10, 51, DateTimeKind.Utc).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 168L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 14, 34, 1, 948, DateTimeKind.Utc).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 30, 5, 20, 44, 225, DateTimeKind.Utc).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 17, 52, 44, 725, DateTimeKind.Utc).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 12, 13, 34, 44, 268, DateTimeKind.Utc).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 6, 22, 9, 19, 244, DateTimeKind.Utc).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 11, 12, 3, 59, 899, DateTimeKind.Utc).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 5, 8, 1, 7, 844, DateTimeKind.Utc).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 11, 9, 9, 19, 452, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 176L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 12, 1, 11, 36, 692, DateTimeKind.Utc).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 5, 5, 1, 50, 731, DateTimeKind.Utc).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 14, 16, 32, 20, 104, DateTimeKind.Utc).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 8, 17, 16, 11, 810, DateTimeKind.Utc).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 2, 4, 42, 35, 214, DateTimeKind.Utc).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 14, 20, 38, 28, 744, DateTimeKind.Utc).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 30, 9, 28, 56, 20, DateTimeKind.Utc).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 13, 23, 44, 37, 878, DateTimeKind.Utc).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 184L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 7, 12, 39, 271, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 2, 6, 48, 47, 720, DateTimeKind.Utc).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 19, 9, 54, 2, 381, DateTimeKind.Utc).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 17, 54, 28, 122, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 14, 56, 11, 666, DateTimeKind.Utc).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 22, 25, 49, 292, DateTimeKind.Utc).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 28, 6, 33, 40, 988, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 16, 0, 1, 50, 239, DateTimeKind.Utc).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 192L,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 14, 9, 47, 23, 529, DateTimeKind.Utc).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 9, 13, 39, 14, 401, DateTimeKind.Utc).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 26, 18, 0, 10, 167, DateTimeKind.Utc).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 4, 23, 8, 40, 137, DateTimeKind.Utc).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 1, 21, 49, 44, 627, DateTimeKind.Utc).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 2, 30, 37, 763, DateTimeKind.Utc).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 11, 10, 52, 45, 915, DateTimeKind.Utc).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 19, 8, 29, 30, 827, DateTimeKind.Utc).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 200L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 6, 8, 49, 44, 521, DateTimeKind.Utc).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 24, 12, 29, 19, 427, DateTimeKind.Utc).AddTicks(9254), new DateTime(2023, 9, 8, 10, 55, 3, 876, DateTimeKind.Utc).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 5, 16, 50, 49, 443, DateTimeKind.Utc).AddTicks(4004), new DateTime(2023, 9, 9, 3, 11, 1, 620, DateTimeKind.Utc).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 21, 19, 7, 59, 817, DateTimeKind.Utc).AddTicks(6158), new DateTime(2023, 9, 10, 16, 20, 47, 718, DateTimeKind.Utc).AddTicks(7538) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 12, 3, 54, 19, 173, DateTimeKind.Utc).AddTicks(411), new DateTime(2023, 4, 23, 4, 38, 1, 465, DateTimeKind.Utc).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 2, 2, 15, 8, 256, DateTimeKind.Utc).AddTicks(162), new DateTime(2023, 8, 18, 17, 54, 35, 954, DateTimeKind.Utc).AddTicks(9163) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 30, 7, 2, 52, 36, DateTimeKind.Utc).AddTicks(8796), new DateTime(2023, 6, 1, 4, 25, 25, 270, DateTimeKind.Utc).AddTicks(1245) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 13, 35, 2, 439, DateTimeKind.Utc).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 4, 56, 7, DateTimeKind.Utc).AddTicks(8873), new DateTime(2023, 8, 29, 8, 46, 43, 255, DateTimeKind.Utc).AddTicks(1499) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 10, 2, 16, 48, 6, 113, DateTimeKind.Utc).AddTicks(2594), new DateTime(2023, 5, 17, 10, 33, 32, 980, DateTimeKind.Utc).AddTicks(2363) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 24, 18, 57, 17, 295, DateTimeKind.Utc).AddTicks(2292), new DateTime(2023, 8, 7, 3, 34, 53, 441, DateTimeKind.Utc).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 13, 22, 51, 36, 129, DateTimeKind.Utc).AddTicks(8534), new DateTime(2023, 5, 18, 18, 42, 36, 198, DateTimeKind.Utc).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 16, 20, 50, 10, 97, DateTimeKind.Utc).AddTicks(2083), new DateTime(2023, 7, 1, 8, 20, 32, 616, DateTimeKind.Utc).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 13, 16, 33, 11, 596, DateTimeKind.Utc).AddTicks(3430), new DateTime(2023, 9, 7, 8, 41, 3, 490, DateTimeKind.Utc).AddTicks(6105) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 23, 20, 11, 27, 191, DateTimeKind.Utc).AddTicks(1744), new DateTime(2023, 9, 5, 12, 41, 43, 51, DateTimeKind.Utc).AddTicks(4871) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 14, 18, 45, 35, 536, DateTimeKind.Utc).AddTicks(2553), new DateTime(2023, 8, 17, 7, 44, 32, 752, DateTimeKind.Utc).AddTicks(7683) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 9, 8, 40, 17, 606, DateTimeKind.Utc).AddTicks(2403), new DateTime(2023, 9, 9, 12, 41, 55, 964, DateTimeKind.Utc).AddTicks(7259) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 18, 46, 36, 107, DateTimeKind.Utc).AddTicks(3514), new DateTime(2023, 3, 14, 6, 54, 52, 467, DateTimeKind.Utc).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 1, 11, 114, DateTimeKind.Utc).AddTicks(1704), new DateTime(2023, 3, 2, 8, 31, 10, 771, DateTimeKind.Utc).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 26, 11, 51, 1, 468, DateTimeKind.Utc).AddTicks(916), new DateTime(2023, 9, 7, 8, 5, 33, 306, DateTimeKind.Utc).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 28, 7, 14, 37, 727, DateTimeKind.Utc).AddTicks(6623), new DateTime(2023, 8, 11, 5, 9, 18, 219, DateTimeKind.Utc).AddTicks(4533) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 14, 12, 58, 15, 393, DateTimeKind.Utc).AddTicks(7020), new DateTime(2023, 8, 17, 14, 58, 7, 771, DateTimeKind.Utc).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 10, 11, 57, 24, 21, DateTimeKind.Utc).AddTicks(5258), new DateTime(2023, 9, 11, 10, 31, 14, 637, DateTimeKind.Utc).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 13, 37, 741, DateTimeKind.Utc).AddTicks(9956), new DateTime(2023, 5, 21, 4, 42, 23, 64, DateTimeKind.Utc).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 5, 21, 31, 10, 864, DateTimeKind.Utc).AddTicks(7439), new DateTime(2023, 9, 11, 3, 20, 19, 287, DateTimeKind.Utc).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 29, 19, 20, 21, 294, DateTimeKind.Utc).AddTicks(3259), new DateTime(2023, 5, 14, 10, 21, 49, 959, DateTimeKind.Utc).AddTicks(3188) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 5, 27, 8, DateTimeKind.Utc).AddTicks(9482), new DateTime(2023, 8, 18, 22, 58, 23, 66, DateTimeKind.Utc).AddTicks(6926) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 7, 10, 39, 13, 523, DateTimeKind.Utc).AddTicks(694), new DateTime(2023, 8, 9, 22, 22, 36, 373, DateTimeKind.Utc).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 35, 16, 424, DateTimeKind.Utc).AddTicks(3700), new DateTime(2023, 7, 9, 23, 15, 0, 214, DateTimeKind.Utc).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 10, 0, 10, 719, DateTimeKind.Utc).AddTicks(222), new DateTime(2023, 8, 30, 20, 25, 9, 396, DateTimeKind.Utc).AddTicks(1494) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 11, 5, 17, 48, 836, DateTimeKind.Utc).AddTicks(1038), new DateTime(2023, 9, 11, 6, 58, 29, 640, DateTimeKind.Utc).AddTicks(7004) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 2, 21, 18, 44, 860, DateTimeKind.Utc).AddTicks(9052), new DateTime(2023, 9, 4, 17, 3, 39, 823, DateTimeKind.Utc).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 28, 11, 834, DateTimeKind.Utc).AddTicks(822), new DateTime(2023, 4, 14, 15, 28, 33, 225, DateTimeKind.Utc).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 25, 22, 32, 41, 219, DateTimeKind.Utc).AddTicks(5101), new DateTime(2023, 7, 29, 11, 36, 2, 780, DateTimeKind.Utc).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 5, 47, 41, 501, DateTimeKind.Utc).AddTicks(5242), new DateTime(2023, 8, 29, 18, 37, 40, 470, DateTimeKind.Utc).AddTicks(6527) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 13, 10, 58, 5, 179, DateTimeKind.Utc).AddTicks(9880), new DateTime(2023, 8, 24, 17, 19, 54, 425, DateTimeKind.Utc).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 18, 6, 22, 4, 847, DateTimeKind.Utc).AddTicks(1670), new DateTime(2023, 7, 19, 20, 35, 55, 727, DateTimeKind.Utc).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 31, 1, 537, DateTimeKind.Utc).AddTicks(7619), new DateTime(2023, 5, 8, 2, 36, 18, 637, DateTimeKind.Utc).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 9, 30, 0, 29, 45, 899, DateTimeKind.Utc).AddTicks(3434), new DateTime(2023, 5, 2, 16, 59, 14, 528, DateTimeKind.Utc).AddTicks(1805) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 31, 9, 12, 37, 945, DateTimeKind.Utc).AddTicks(7532), new DateTime(2023, 5, 28, 4, 9, 21, 681, DateTimeKind.Utc).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 20, 19, 41, 59, 195, DateTimeKind.Utc).AddTicks(5160), new DateTime(2023, 4, 25, 21, 52, 20, 800, DateTimeKind.Utc).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 8, 12, 25, 525, DateTimeKind.Utc).AddTicks(4475), new DateTime(2023, 5, 24, 8, 31, 58, 445, DateTimeKind.Utc).AddTicks(3431) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 52, 49, 642, DateTimeKind.Utc).AddTicks(6021), new DateTime(2023, 9, 8, 21, 37, 22, 307, DateTimeKind.Utc).AddTicks(7065) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 25, 11, 41, 58, 159, DateTimeKind.Utc).AddTicks(2253), new DateTime(2023, 9, 9, 16, 39, 36, 240, DateTimeKind.Utc).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 17, 37, 53, 339, DateTimeKind.Utc).AddTicks(9436), new DateTime(2023, 8, 4, 9, 52, 3, 275, DateTimeKind.Utc).AddTicks(542) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 23, 14, 11, 10, 225, DateTimeKind.Utc).AddTicks(2013), new DateTime(2023, 8, 6, 14, 15, 20, 625, DateTimeKind.Utc).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 4, 15, 24, 18, 415, DateTimeKind.Utc).AddTicks(7282), new DateTime(2023, 7, 12, 6, 28, 9, 213, DateTimeKind.Utc).AddTicks(183) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 5, 0, 4, 22, 658, DateTimeKind.Utc).AddTicks(9386), new DateTime(2023, 7, 7, 6, 22, 31, 82, DateTimeKind.Utc).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 49, 29, 145, DateTimeKind.Utc).AddTicks(8959), new DateTime(2023, 9, 6, 19, 53, 9, 803, DateTimeKind.Utc).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 3, 6, 46, 35, 723, DateTimeKind.Utc).AddTicks(7715), new DateTime(2023, 8, 14, 8, 44, 23, 662, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 19, 20, 52, 14, 627, DateTimeKind.Utc).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 14, 2, 9, 64, DateTimeKind.Utc).AddTicks(8140), new DateTime(2023, 6, 24, 7, 15, 8, 156, DateTimeKind.Utc).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 16, 18, 50, 16, 42, DateTimeKind.Utc).AddTicks(617), new DateTime(2023, 8, 28, 4, 0, 14, 504, DateTimeKind.Utc).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 25, 9, 57, 37, 809, DateTimeKind.Utc).AddTicks(3046), new DateTime(2023, 6, 1, 20, 11, 58, 440, DateTimeKind.Utc).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 21, 28, 25, 644, DateTimeKind.Utc).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 28, 41, 936, DateTimeKind.Utc).AddTicks(3315), new DateTime(2023, 6, 10, 14, 2, 8, 885, DateTimeKind.Utc).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 16, 6, 49, 16, 448, DateTimeKind.Utc).AddTicks(9257), new DateTime(2023, 9, 2, 10, 30, 9, 296, DateTimeKind.Utc).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 26, 19, 38, 59, 735, DateTimeKind.Utc).AddTicks(695), new DateTime(2023, 6, 29, 13, 20, 52, 233, DateTimeKind.Utc).AddTicks(8066) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 1, 20, 24, 10, 275, DateTimeKind.Utc).AddTicks(406), new DateTime(2023, 8, 16, 8, 37, 5, 207, DateTimeKind.Utc).AddTicks(9202) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 3, 10, 12, 42, 197, DateTimeKind.Utc).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 10, 20, 43, 9, 26, DateTimeKind.Utc).AddTicks(207), new DateTime(2023, 9, 10, 23, 9, 25, 191, DateTimeKind.Utc).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 3, 9, 20, 46, 906, DateTimeKind.Utc).AddTicks(5672), new DateTime(2023, 9, 4, 8, 20, 37, 166, DateTimeKind.Utc).AddTicks(9689) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 20, 6, 23, 37, 510, DateTimeKind.Utc).AddTicks(8734), new DateTime(2023, 8, 20, 10, 16, 37, 37, DateTimeKind.Utc).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 50, 8, 958, DateTimeKind.Utc).AddTicks(7866), new DateTime(2023, 9, 10, 16, 42, 1, 348, DateTimeKind.Utc).AddTicks(1178) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 17, 5, 56, 1, 194, DateTimeKind.Utc).AddTicks(5851), new DateTime(2023, 7, 13, 11, 54, 42, 866, DateTimeKind.Utc).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 4, 2, 26, 15, 602, DateTimeKind.Utc).AddTicks(3212), new DateTime(2023, 9, 4, 16, 46, 33, 609, DateTimeKind.Utc).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 6, 12, 6, 53, 559, DateTimeKind.Utc).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 1, 4, 15, 25, 14, 51, DateTimeKind.Utc).AddTicks(8655), new DateTime(2021, 12, 7, 10, 23, 1, 504, DateTimeKind.Utc).AddTicks(1184) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 23, 43, 20, 342, DateTimeKind.Utc).AddTicks(4060), new DateTime(2023, 7, 14, 17, 3, 56, 571, DateTimeKind.Utc).AddTicks(9654) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 9, 17, 28, 4, 722, DateTimeKind.Utc).AddTicks(8892), new DateTime(2023, 9, 10, 15, 51, 44, 954, DateTimeKind.Utc).AddTicks(3119) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 7, 18, 5, 35, 366, DateTimeKind.Utc).AddTicks(1141), new DateTime(2023, 3, 2, 4, 10, 0, 811, DateTimeKind.Utc).AddTicks(4088) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 9, 17, 27, 21, 965, DateTimeKind.Utc).AddTicks(8681), new DateTime(2023, 9, 11, 10, 13, 5, 107, DateTimeKind.Utc).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 17, 2, 2, 43, 371, DateTimeKind.Utc).AddTicks(5971), new DateTime(2023, 2, 5, 5, 59, 58, 71, DateTimeKind.Utc).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 11, 11, 17, 54, 57, 641, DateTimeKind.Utc).AddTicks(2618), new DateTime(2023, 3, 18, 17, 39, 14, 623, DateTimeKind.Utc).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 4, 3, 18, 17, 579, DateTimeKind.Utc).AddTicks(2742), new DateTime(2023, 9, 4, 8, 59, 33, 203, DateTimeKind.Utc).AddTicks(108) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 3, 10, 58, 55, 450, DateTimeKind.Utc).AddTicks(6477), new DateTime(2023, 4, 17, 10, 48, 58, 409, DateTimeKind.Utc).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 1, 7, 743, DateTimeKind.Utc).AddTicks(758), new DateTime(2023, 1, 30, 19, 44, 18, 374, DateTimeKind.Utc).AddTicks(8416) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 3, 3, 26, 53, 592, DateTimeKind.Utc).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 15, 4, 18, 0, 936, DateTimeKind.Utc).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 11, 5, 59, 51, 170, DateTimeKind.Utc).AddTicks(3722), new DateTime(2023, 9, 11, 8, 34, 2, 879, DateTimeKind.Utc).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 25, 23, 47, 1, 287, DateTimeKind.Utc).AddTicks(6625), new DateTime(2023, 8, 27, 1, 18, 20, 862, DateTimeKind.Utc).AddTicks(1329) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 31, 4, 54, 45, 264, DateTimeKind.Utc).AddTicks(5184), new DateTime(2023, 7, 23, 15, 46, 14, 407, DateTimeKind.Utc).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 11, 11, 25, 46, 33, DateTimeKind.Utc).AddTicks(4112), new DateTime(2023, 9, 11, 11, 30, 40, 221, DateTimeKind.Utc).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 4, 16, 13, 54, 717, DateTimeKind.Utc).AddTicks(7419), new DateTime(2023, 6, 14, 9, 4, 20, 676, DateTimeKind.Utc).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 6, 5, 2, 57, 19, 831, DateTimeKind.Utc).AddTicks(1772), new DateTime(2023, 3, 14, 20, 38, 34, 725, DateTimeKind.Utc).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 8, 1, 51, 19, 905, DateTimeKind.Utc).AddTicks(8928), new DateTime(2023, 9, 11, 4, 47, 36, 402, DateTimeKind.Utc).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 8, 11, 33, 24, 828, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 41, 3, 874, DateTimeKind.Utc).AddTicks(4755), new DateTime(2023, 8, 8, 2, 31, 57, 441, DateTimeKind.Utc).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 5, 12, 19, 13, 39, 718, DateTimeKind.Utc).AddTicks(8610), new DateTime(2022, 3, 28, 16, 2, 37, 69, DateTimeKind.Utc).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 3, 8, 7, 11, 49, 798, DateTimeKind.Utc).AddTicks(9903), new DateTime(2023, 7, 25, 20, 10, 59, 945, DateTimeKind.Utc).AddTicks(4148) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 22, 6, 14, 31, 27, DateTimeKind.Utc).AddTicks(4321), new DateTime(2023, 9, 9, 4, 47, 13, 642, DateTimeKind.Utc).AddTicks(1114) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 15, 6, 49, 5, 394, DateTimeKind.Utc).AddTicks(3988), new DateTime(2023, 8, 1, 15, 32, 59, 765, DateTimeKind.Utc).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 9, 0, 15, 21, 702, DateTimeKind.Utc).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 25, 2, 0, 13, 532, DateTimeKind.Utc).AddTicks(7775), new DateTime(2023, 8, 29, 15, 33, 3, 414, DateTimeKind.Utc).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 3, 27, 13, 38, 21, 408, DateTimeKind.Utc).AddTicks(5176), new DateTime(2023, 5, 28, 11, 57, 56, 959, DateTimeKind.Utc).AddTicks(6136) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 39, 29, 559, DateTimeKind.Utc).AddTicks(2319), new DateTime(2023, 9, 7, 10, 33, 18, 496, DateTimeKind.Utc).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 30, 15, 25, 37, 798, DateTimeKind.Utc).AddTicks(7836), new DateTime(2023, 9, 7, 18, 2, 59, 600, DateTimeKind.Utc).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 14, 22, 41, 14, 385, DateTimeKind.Utc).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 17, 12, 15, 49, 686, DateTimeKind.Utc).AddTicks(2566), new DateTime(2023, 8, 17, 22, 42, 49, 501, DateTimeKind.Utc).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 20, 10, 6, 35, 92, DateTimeKind.Utc).AddTicks(2371), new DateTime(2023, 6, 7, 19, 8, 41, 884, DateTimeKind.Utc).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 4, 5, 36, 12, 608, DateTimeKind.Utc).AddTicks(3455), new DateTime(2023, 9, 8, 8, 7, 43, 492, DateTimeKind.Utc).AddTicks(8221) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 7, 15, 9, 41, 46, 291, DateTimeKind.Utc).AddTicks(6099), new DateTime(2023, 2, 27, 11, 34, 21, 710, DateTimeKind.Utc).AddTicks(7112) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 8, 14, 26, 17, DateTimeKind.Utc).AddTicks(7679), new DateTime(2023, 7, 31, 18, 21, 24, 464, DateTimeKind.Utc).AddTicks(2368) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 28, 1, 27, 47, 50, DateTimeKind.Utc).AddTicks(3466), new DateTime(2023, 9, 9, 10, 29, 57, 94, DateTimeKind.Utc).AddTicks(1025) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 23, 5, 3, 3, 194, DateTimeKind.Utc).AddTicks(9454), new DateTime(2023, 9, 2, 12, 13, 22, 789, DateTimeKind.Utc).AddTicks(9269) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 8, 6, 55, 105, DateTimeKind.Utc).AddTicks(636), new DateTime(2023, 9, 11, 0, 54, 16, 701, DateTimeKind.Utc).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 5, 24, 13, 32, 50, 538, DateTimeKind.Utc).AddTicks(9084), new DateTime(2021, 12, 16, 17, 3, 4, 394, DateTimeKind.Utc).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 22, 12, 9, 50, 306, DateTimeKind.Utc).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 7, 1, 30, 34, 408, DateTimeKind.Utc).AddTicks(285), new DateTime(2023, 9, 9, 22, 13, 29, 27, DateTimeKind.Utc).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 19, 21, 7, 4, 507, DateTimeKind.Utc).AddTicks(7460), new DateTime(2023, 8, 16, 22, 21, 58, 257, DateTimeKind.Utc).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 26, 2, 7, 26, 896, DateTimeKind.Utc).AddTicks(8794), new DateTime(2023, 7, 25, 13, 46, 26, 845, DateTimeKind.Utc).AddTicks(6361) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 15, 19, 14, 5, 905, DateTimeKind.Utc).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 9, 2, 26, 57, 642, DateTimeKind.Utc).AddTicks(8258), new DateTime(2023, 4, 24, 12, 25, 2, 674, DateTimeKind.Utc).AddTicks(4732) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 22, 14, 11, 76, DateTimeKind.Utc).AddTicks(9348), new DateTime(2023, 8, 28, 2, 28, 7, 451, DateTimeKind.Utc).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 17, 19, 8, 13, 460, DateTimeKind.Utc).AddTicks(7433), new DateTime(2023, 8, 25, 23, 13, 50, 551, DateTimeKind.Utc).AddTicks(1189) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 5, 15, 56, 53, 74, DateTimeKind.Utc).AddTicks(2534), new DateTime(2023, 9, 8, 23, 43, 38, 346, DateTimeKind.Utc).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 21, 15, 37, 40, 345, DateTimeKind.Utc).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 8, 11, 34, 29, 814, DateTimeKind.Utc).AddTicks(9501), new DateTime(2023, 9, 9, 5, 56, 23, 573, DateTimeKind.Utc).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 4, 13, 13, 45, 652, DateTimeKind.Utc).AddTicks(1442), new DateTime(2023, 5, 20, 16, 33, 3, 479, DateTimeKind.Utc).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 14, 16, 30, 58, 410, DateTimeKind.Utc).AddTicks(6357), new DateTime(2023, 9, 5, 6, 27, 37, 137, DateTimeKind.Utc).AddTicks(4042) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 22, 14, 19, 41, 600, DateTimeKind.Utc).AddTicks(7336), new DateTime(2023, 8, 27, 18, 8, 49, 153, DateTimeKind.Utc).AddTicks(1324) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 15, 1, 28, 4, 129, DateTimeKind.Utc).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 49, 57, 835, DateTimeKind.Utc).AddTicks(2989), new DateTime(2023, 8, 26, 0, 40, 13, 297, DateTimeKind.Utc).AddTicks(4032) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 11, 25, 37, 362, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 1, 3, 57, 35, 173, DateTimeKind.Utc).AddTicks(8389), new DateTime(2023, 9, 1, 7, 57, 58, 534, DateTimeKind.Utc).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 2, 13, 14, 31, 21, 733, DateTimeKind.Utc).AddTicks(7007), new DateTime(2022, 12, 9, 20, 42, 6, 663, DateTimeKind.Utc).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 13, 12, 22, 32, 697, DateTimeKind.Utc).AddTicks(8517), new DateTime(2023, 6, 10, 5, 57, 7, 693, DateTimeKind.Utc).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 5, 18, 40, 18, 792, DateTimeKind.Utc).AddTicks(5563), new DateTime(2023, 9, 10, 19, 56, 46, 459, DateTimeKind.Utc).AddTicks(1497) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 24, 0, 44, 0, 187, DateTimeKind.Utc).AddTicks(4846), new DateTime(2023, 7, 16, 7, 22, 20, 665, DateTimeKind.Utc).AddTicks(8101) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 8, 9, 2, 33, 275, DateTimeKind.Utc).AddTicks(9420), new DateTime(2023, 3, 14, 5, 22, 32, 224, DateTimeKind.Utc).AddTicks(335) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 9, 33, 22, 595, DateTimeKind.Utc).AddTicks(8398), new DateTime(2023, 5, 29, 16, 3, 26, 471, DateTimeKind.Utc).AddTicks(3357) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 16, 1, 14, 30, 935, DateTimeKind.Utc).AddTicks(947), new DateTime(2023, 6, 23, 6, 43, 47, 595, DateTimeKind.Utc).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 4, 3, 13, 23, 863, DateTimeKind.Utc).AddTicks(2436), new DateTime(2023, 9, 8, 23, 44, 35, 803, DateTimeKind.Utc).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 19, 23, 24, 53, 840, DateTimeKind.Utc).AddTicks(3972), new DateTime(2023, 8, 6, 20, 54, 30, 393, DateTimeKind.Utc).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 1, 10, 23, 17, 909, DateTimeKind.Utc).AddTicks(7480), new DateTime(2023, 9, 4, 12, 28, 3, 965, DateTimeKind.Utc).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 18, 15, 28, 33, 645, DateTimeKind.Utc).AddTicks(81), new DateTime(2023, 6, 7, 4, 1, 36, 315, DateTimeKind.Utc).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 11, 7, 41, 15, 110, DateTimeKind.Utc).AddTicks(6654), new DateTime(2023, 9, 11, 8, 10, 26, 700, DateTimeKind.Utc).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 27, 21, 16, 44, 325, DateTimeKind.Utc).AddTicks(1271), new DateTime(2023, 9, 2, 6, 35, 59, 545, DateTimeKind.Utc).AddTicks(9802) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 10, 17, 11, 3, 249, DateTimeKind.Utc).AddTicks(6686), new DateTime(2023, 9, 10, 22, 39, 25, 517, DateTimeKind.Utc).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 31, 6, 45, 45, 800, DateTimeKind.Utc).AddTicks(6880), new DateTime(2023, 8, 28, 10, 46, 54, 589, DateTimeKind.Utc).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 1, 10, 20, 2, 782, DateTimeKind.Utc).AddTicks(2744), new DateTime(2023, 7, 16, 19, 52, 28, 446, DateTimeKind.Utc).AddTicks(6176) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 7, 16, 17, 37, 243, DateTimeKind.Utc).AddTicks(1858), new DateTime(2023, 5, 24, 4, 51, 28, 58, DateTimeKind.Utc).AddTicks(9458) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 14, 8, 27, 54, 743, DateTimeKind.Utc).AddTicks(4065), new DateTime(2023, 8, 15, 9, 50, 21, 766, DateTimeKind.Utc).AddTicks(1024) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 20, 6, 29, 50, 83, DateTimeKind.Utc).AddTicks(515), new DateTime(2023, 8, 19, 20, 24, 27, 249, DateTimeKind.Utc).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 11, 11, 12, 16, 41, 680, DateTimeKind.Utc).AddTicks(9429), new DateTime(2023, 1, 26, 1, 46, 46, 444, DateTimeKind.Utc).AddTicks(9913) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 20, 11, 41, 16, 82, DateTimeKind.Utc).AddTicks(8096), new DateTime(2023, 8, 7, 19, 53, 30, 669, DateTimeKind.Utc).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 28, 7, 47, 45, 354, DateTimeKind.Utc).AddTicks(9575), new DateTime(2023, 9, 8, 3, 17, 57, 629, DateTimeKind.Utc).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 48, 29, 912, DateTimeKind.Utc).AddTicks(8573), new DateTime(2023, 8, 9, 23, 5, 59, 848, DateTimeKind.Utc).AddTicks(225) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 29, 2, 34, 31, 508, DateTimeKind.Utc).AddTicks(9196), new DateTime(2023, 9, 2, 18, 11, 49, 632, DateTimeKind.Utc).AddTicks(5611) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 5, 17, 0, 10, 12, DateTimeKind.Utc).AddTicks(3913), new DateTime(2023, 4, 15, 9, 41, 30, 948, DateTimeKind.Utc).AddTicks(9037) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 10, 5, 31, 11, 476, DateTimeKind.Utc).AddTicks(3290), new DateTime(2023, 9, 3, 12, 25, 14, 656, DateTimeKind.Utc).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 7, 18, 9, 23, 627, DateTimeKind.Utc).AddTicks(1749), new DateTime(2023, 3, 25, 3, 3, 13, 282, DateTimeKind.Utc).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 10, 30, 9, 49, 5, 557, DateTimeKind.Utc).AddTicks(2592), new DateTime(2022, 11, 29, 18, 49, 3, 759, DateTimeKind.Utc).AddTicks(4485) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 4, 23, 49, 41, 301, DateTimeKind.Utc).AddTicks(8904), new DateTime(2023, 9, 6, 2, 19, 43, 929, DateTimeKind.Utc).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 11, 17, 51, 39, 549, DateTimeKind.Utc).AddTicks(9468), new DateTime(2023, 3, 12, 7, 0, 10, 371, DateTimeKind.Utc).AddTicks(9238) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 9, 3, 3, 32, 16, 526, DateTimeKind.Utc).AddTicks(3606), new DateTime(2022, 11, 2, 0, 24, 52, 942, DateTimeKind.Utc).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 6, 19, 6, 25, 806, DateTimeKind.Utc).AddTicks(6607), new DateTime(2023, 9, 8, 14, 54, 8, 797, DateTimeKind.Utc).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 31, 12, 163, DateTimeKind.Utc).AddTicks(8955), new DateTime(2023, 1, 21, 8, 57, 35, 870, DateTimeKind.Utc).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 8, 17, 56, 46, 726, DateTimeKind.Utc).AddTicks(3213), new DateTime(2023, 7, 23, 3, 27, 42, 154, DateTimeKind.Utc).AddTicks(5279) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 15, 12, 21, 44, 795, DateTimeKind.Utc).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 10, 0, 16, 30, 580, DateTimeKind.Utc).AddTicks(7201), new DateTime(2023, 4, 7, 8, 25, 35, 88, DateTimeKind.Utc).AddTicks(8258) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 9, 12, 26, 27, 589, DateTimeKind.Utc).AddTicks(5187), new DateTime(2023, 7, 3, 12, 48, 14, 142, DateTimeKind.Utc).AddTicks(6469) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 162L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 2, 8, 49, 3, 667, DateTimeKind.Utc).AddTicks(4757), new DateTime(2023, 9, 8, 14, 17, 39, 727, DateTimeKind.Utc).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 163L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 10, 7, 12, 48, 19, DateTimeKind.Utc).AddTicks(6296), new DateTime(2023, 9, 10, 22, 36, 50, 341, DateTimeKind.Utc).AddTicks(1337) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 164L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 31, 17, 31, 27, 521, DateTimeKind.Utc).AddTicks(3248), new DateTime(2023, 9, 8, 1, 28, 27, 692, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 165L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 31, 9, 41, 24, 172, DateTimeKind.Utc).AddTicks(7184), new DateTime(2023, 9, 2, 6, 46, 39, 335, DateTimeKind.Utc).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 8, 20, 29, 39, 807, DateTimeKind.Utc).AddTicks(5232), new DateTime(2023, 8, 24, 10, 24, 16, 35, DateTimeKind.Utc).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 7, 6, 34, 17, 779, DateTimeKind.Utc).AddTicks(1630), new DateTime(2023, 9, 8, 18, 1, 52, 691, DateTimeKind.Utc).AddTicks(1067) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 15, 19, 32, 40, 243, DateTimeKind.Utc).AddTicks(4266), new DateTime(2023, 7, 26, 20, 56, 31, 328, DateTimeKind.Utc).AddTicks(9605) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 18, 8, 2, 37, 711, DateTimeKind.Utc).AddTicks(6452), new DateTime(2023, 9, 7, 11, 50, 35, 685, DateTimeKind.Utc).AddTicks(4109) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 18, 14, 32, 16, 799, DateTimeKind.Utc).AddTicks(8636), new DateTime(2023, 8, 3, 1, 46, 46, 693, DateTimeKind.Utc).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 7, 44, 18, 201, DateTimeKind.Utc).AddTicks(3238), new DateTime(2023, 8, 6, 13, 35, 27, 787, DateTimeKind.Utc).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 22, 4, 28, 34, 296, DateTimeKind.Utc).AddTicks(7291), new DateTime(2023, 8, 27, 4, 20, 46, 959, DateTimeKind.Utc).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 2, 17, 21, 25, 975, DateTimeKind.Utc).AddTicks(5492), new DateTime(2023, 7, 15, 3, 47, 15, 93, DateTimeKind.Utc).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 1, 23, 23, 13, 938, DateTimeKind.Utc).AddTicks(5756), new DateTime(2023, 9, 1, 8, 51, 15, 4, DateTimeKind.Utc).AddTicks(4956) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 7, 28, 12, 24, 0, 651, DateTimeKind.Utc).AddTicks(5160), new DateTime(2023, 5, 21, 3, 11, 50, 942, DateTimeKind.Utc).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 28, 4, 29, 9, 94, DateTimeKind.Utc).AddTicks(6526), new DateTime(2023, 8, 21, 12, 1, 13, 68, DateTimeKind.Utc).AddTicks(9115) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 12, 18, 44, 41, 350, DateTimeKind.Utc).AddTicks(8979), new DateTime(2023, 4, 15, 13, 40, 18, 366, DateTimeKind.Utc).AddTicks(7456) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 30, 21, 51, 18, 393, DateTimeKind.Utc).AddTicks(7420), new DateTime(2023, 4, 8, 22, 32, 57, 922, DateTimeKind.Utc).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 18, 6, 4, 8, 608, DateTimeKind.Utc).AddTicks(519), new DateTime(2023, 5, 18, 11, 41, 3, 445, DateTimeKind.Utc).AddTicks(3812) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 13, 12, 0, 42, 329, DateTimeKind.Utc).AddTicks(9561), new DateTime(2023, 6, 19, 16, 41, 42, 330, DateTimeKind.Utc).AddTicks(2244) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 6, 6, 2, 24, 4, 8, DateTimeKind.Utc).AddTicks(2601), new DateTime(2023, 3, 26, 11, 13, 10, 528, DateTimeKind.Utc).AddTicks(1209) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 0, 50, 50, 478, DateTimeKind.Utc).AddTicks(5756), new DateTime(2023, 8, 3, 22, 34, 58, 428, DateTimeKind.Utc).AddTicks(734) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 28, 11, 18, 4, 883, DateTimeKind.Utc).AddTicks(6932), new DateTime(2023, 8, 7, 0, 23, 34, 385, DateTimeKind.Utc).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 3, 15, 45, 48, 165, DateTimeKind.Utc).AddTicks(726), new DateTime(2023, 9, 6, 4, 6, 26, 330, DateTimeKind.Utc).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 3, 11, 56, 8, DateTimeKind.Utc).AddTicks(2877), new DateTime(2023, 6, 2, 2, 1, 56, 701, DateTimeKind.Utc).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 7, 16, 22, 5, 14, DateTimeKind.Utc).AddTicks(2135), new DateTime(2023, 6, 18, 15, 1, 15, 821, DateTimeKind.Utc).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 10, 8, 16, 3, 25, 125, DateTimeKind.Utc).AddTicks(2275), new DateTime(2022, 11, 15, 9, 35, 23, 135, DateTimeKind.Utc).AddTicks(9466) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 21, 16, 13, 905, DateTimeKind.Utc).AddTicks(6097), new DateTime(2023, 7, 29, 13, 24, 39, 283, DateTimeKind.Utc).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 3, 2, 6, 49, 647, DateTimeKind.Utc).AddTicks(1758), new DateTime(2023, 9, 4, 1, 49, 0, 658, DateTimeKind.Utc).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 11, 22, 23, 53, 4, 638, DateTimeKind.Utc).AddTicks(6483), new DateTime(2023, 5, 11, 2, 13, 13, 439, DateTimeKind.Utc).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 8, 2, 22, 53, 40, 643, DateTimeKind.Utc).AddTicks(4675), new DateTime(2023, 3, 18, 1, 20, 53, 158, DateTimeKind.Utc).AddTicks(5486) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 16, 22, 10, 41, 35, DateTimeKind.Utc).AddTicks(921), new DateTime(2023, 7, 21, 11, 18, 5, 820, DateTimeKind.Utc).AddTicks(6319) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 27, 7, 9, 9, 268, DateTimeKind.Utc).AddTicks(2662), new DateTime(2023, 9, 1, 14, 10, 29, 909, DateTimeKind.Utc).AddTicks(207) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 27, 12, 16, 16, 456, DateTimeKind.Utc).AddTicks(6866), new DateTime(2023, 5, 31, 12, 33, 51, 748, DateTimeKind.Utc).AddTicks(2898) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 8, 23, 6, 3, 758, DateTimeKind.Utc).AddTicks(5293), new DateTime(2023, 9, 9, 23, 47, 44, 698, DateTimeKind.Utc).AddTicks(8083) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 14, 23, 16, 17, 216, DateTimeKind.Utc).AddTicks(2152), new DateTime(2023, 6, 19, 14, 36, 58, 304, DateTimeKind.Utc).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 6, 59, 39, 496, DateTimeKind.Utc).AddTicks(9898), new DateTime(2023, 5, 29, 21, 50, 34, 319, DateTimeKind.Utc).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 10, 10, 48, 32, 257, DateTimeKind.Utc).AddTicks(8288), new DateTime(2023, 7, 7, 14, 35, 53, 653, DateTimeKind.Utc).AddTicks(6344) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 8, 22, 14, 47, 484, DateTimeKind.Utc).AddTicks(4495), new DateTime(2023, 5, 21, 7, 38, 21, 602, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 14, 16, 39, 19, 229, DateTimeKind.Utc).AddTicks(3079), new DateTime(2023, 9, 2, 13, 57, 48, 281, DateTimeKind.Utc).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "RegisteredAt",
                value: new DateTime(2016, 5, 19, 20, 1, 13, 358, DateTimeKind.Utc).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "RegisteredAt",
                value: new DateTime(2016, 4, 10, 16, 2, 14, 897, DateTimeKind.Utc).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                column: "RegisteredAt",
                value: new DateTime(2017, 11, 10, 12, 39, 34, 390, DateTimeKind.Utc).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                column: "RegisteredAt",
                value: new DateTime(2018, 7, 26, 5, 47, 53, 317, DateTimeKind.Utc).AddTicks(9873));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                column: "RegisteredAt",
                value: new DateTime(2017, 8, 16, 3, 48, 33, 313, DateTimeKind.Utc).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                column: "RegisteredAt",
                value: new DateTime(2022, 3, 7, 1, 14, 23, 882, DateTimeKind.Utc).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                column: "RegisteredAt",
                value: new DateTime(2020, 9, 18, 7, 25, 37, 911, DateTimeKind.Utc).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                column: "RegisteredAt",
                value: new DateTime(2022, 6, 1, 10, 12, 32, 726, DateTimeKind.Utc).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                column: "RegisteredAt",
                value: new DateTime(2021, 12, 7, 9, 54, 59, 571, DateTimeKind.Utc).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                column: "RegisteredAt",
                value: new DateTime(2018, 7, 20, 11, 10, 26, 612, DateTimeKind.Utc).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11L,
                column: "RegisteredAt",
                value: new DateTime(2022, 3, 28, 15, 12, 5, 359, DateTimeKind.Utc).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12L,
                column: "RegisteredAt",
                value: new DateTime(2019, 9, 17, 6, 12, 38, 500, DateTimeKind.Utc).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13L,
                column: "RegisteredAt",
                value: new DateTime(2021, 3, 13, 3, 52, 8, 570, DateTimeKind.Utc).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14L,
                column: "RegisteredAt",
                value: new DateTime(2016, 6, 10, 1, 0, 22, 330, DateTimeKind.Utc).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15L,
                column: "RegisteredAt",
                value: new DateTime(2022, 3, 16, 23, 37, 27, 780, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16L,
                column: "RegisteredAt",
                value: new DateTime(2017, 6, 23, 7, 11, 18, 810, DateTimeKind.Utc).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17L,
                column: "RegisteredAt",
                value: new DateTime(2016, 1, 19, 22, 54, 52, 356, DateTimeKind.Utc).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18L,
                column: "RegisteredAt",
                value: new DateTime(2022, 12, 30, 15, 57, 24, 705, DateTimeKind.Utc).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19L,
                column: "RegisteredAt",
                value: new DateTime(2022, 4, 18, 0, 31, 26, 314, DateTimeKind.Utc).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20L,
                column: "RegisteredAt",
                value: new DateTime(2020, 12, 18, 20, 22, 45, 806, DateTimeKind.Utc).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21L,
                column: "RegisteredAt",
                value: new DateTime(2017, 1, 24, 18, 42, 30, 828, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22L,
                column: "RegisteredAt",
                value: new DateTime(2018, 5, 4, 23, 53, 59, 637, DateTimeKind.Utc).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23L,
                column: "RegisteredAt",
                value: new DateTime(2021, 11, 10, 11, 9, 33, 693, DateTimeKind.Utc).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24L,
                column: "RegisteredAt",
                value: new DateTime(2021, 4, 29, 15, 32, 15, 407, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25L,
                column: "RegisteredAt",
                value: new DateTime(2019, 2, 23, 5, 24, 47, 342, DateTimeKind.Utc).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26L,
                column: "RegisteredAt",
                value: new DateTime(2016, 6, 21, 20, 13, 56, 907, DateTimeKind.Utc).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27L,
                column: "RegisteredAt",
                value: new DateTime(2021, 12, 15, 8, 0, 38, 690, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28L,
                column: "RegisteredAt",
                value: new DateTime(2016, 7, 18, 11, 8, 12, 424, DateTimeKind.Utc).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29L,
                column: "RegisteredAt",
                value: new DateTime(2017, 8, 4, 15, 19, 3, 349, DateTimeKind.Utc).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30L,
                column: "RegisteredAt",
                value: new DateTime(2020, 8, 24, 13, 22, 2, 345, DateTimeKind.Utc).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31L,
                column: "RegisteredAt",
                value: new DateTime(2016, 12, 17, 1, 41, 47, 716, DateTimeKind.Utc).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32L,
                column: "RegisteredAt",
                value: new DateTime(2016, 12, 25, 3, 35, 59, 619, DateTimeKind.Utc).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33L,
                column: "RegisteredAt",
                value: new DateTime(2021, 11, 30, 14, 7, 21, 526, DateTimeKind.Utc).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34L,
                column: "RegisteredAt",
                value: new DateTime(2023, 3, 16, 21, 18, 41, 628, DateTimeKind.Utc).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35L,
                column: "RegisteredAt",
                value: new DateTime(2022, 2, 20, 2, 8, 39, 92, DateTimeKind.Utc).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36L,
                column: "RegisteredAt",
                value: new DateTime(2020, 4, 10, 8, 39, 39, 742, DateTimeKind.Utc).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37L,
                column: "RegisteredAt",
                value: new DateTime(2016, 5, 7, 12, 19, 51, 170, DateTimeKind.Utc).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38L,
                column: "RegisteredAt",
                value: new DateTime(2018, 12, 22, 19, 43, 39, 100, DateTimeKind.Utc).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39L,
                column: "RegisteredAt",
                value: new DateTime(2016, 7, 25, 0, 48, 25, 533, DateTimeKind.Utc).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40L,
                column: "RegisteredAt",
                value: new DateTime(2017, 10, 21, 18, 8, 46, 388, DateTimeKind.Utc).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ChallengeId", "CreatedAt", "CreatedBy", "LanguageId", "Status" },
                values: new object[] { 59L, new DateTime(2023, 8, 29, 2, 29, 5, 331, DateTimeKind.Utc).AddTicks(8160), 12L, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 38L, "Est aut repellendus qui fugit.", new DateTime(2023, 6, 11, 5, 0, 33, 494, DateTimeKind.Utc).AddTicks(87), 4L, "Iusto aut nesciunt modi et quibusdam.", 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 8L, "Omnis inventore velit.\nMaxime fuga fugiat eos.\nAdipisci id dolores et fugit vero vitae.", new DateTime(2021, 12, 29, 9, 16, 57, 224, DateTimeKind.Utc).AddTicks(6747), 8L, "Consequuntur alias ipsam quo alias et quisquam voluptates.", 1, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 21L, "Nam omnis est magnam rerum eum repudiandae minima tenetur quis. Reprehenderit accusamus dolore est ratione maiores. Et perspiciatis sequi minima pariatur dignissimos eum. Dolorum qui cum voluptatibus quibusdam corporis saepe dolores. Error magni eum dolore minima amet. Temporibus esse magni nihil est officiis ducimus aut dolorem sit.", new DateTime(2023, 6, 18, 6, 5, 26, 889, DateTimeKind.Utc).AddTicks(7355), 16L, "Et vel voluptatum quia quia nesciunt sequi impedit.", 1, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 43L, "Et id nulla nesciunt. Nesciunt minima cupiditate. Dolore corrupti iusto ipsam sapiente. Maxime alias nam.", new DateTime(2023, 8, 29, 10, 16, 26, 207, DateTimeKind.Utc).AddTicks(9745), 24L, "Accusamus magnam quia laudantium id.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 59L, "Corporis illum molestiae hic et officiis accusantium nostrum. Aut et error itaque animi eveniet ut delectus voluptates dolorem. Laudantium itaque sequi officiis sapiente et.", new DateTime(2023, 3, 5, 21, 59, 32, 864, DateTimeKind.Utc).AddTicks(6321), 7L, "Et pariatur sapiente.", 2, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 57L, "Non porro impedit.", new DateTime(2023, 4, 6, 18, 1, 7, 620, DateTimeKind.Utc).AddTicks(9785), 27L, "Blanditiis quidem earum tempore molestias.", 3, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 53L, "Sit molestiae adipisci repellat eum vel dolorum aut ullam distinctio.\nOmnis animi officiis tenetur.", new DateTime(2020, 1, 2, 10, 59, 37, 583, DateTimeKind.Utc).AddTicks(8223), 15L, "Fugit mollitia aut ab eum est quaerat consequatur.", 3, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 27L, "qui", new DateTime(2022, 12, 20, 20, 50, 45, 161, DateTimeKind.Utc).AddTicks(8660), 1L, "Dolore possimus quisquam optio veniam.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 3L, "unde", new DateTime(2023, 7, 15, 8, 20, 18, 791, DateTimeKind.Utc).AddTicks(4106), 34L, "Sit repellendus cupiditate quo quo doloribus.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 16L, "Soluta est libero voluptatum ullam unde libero dolorem voluptatem et.", new DateTime(2023, 6, 24, 18, 59, 18, 109, DateTimeKind.Utc).AddTicks(2976), 9L, "Officiis eos molestias explicabo.", 1, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 51L, "omnis", new DateTime(2023, 9, 11, 6, 54, 48, 148, DateTimeKind.Utc).AddTicks(7343), 35L, "Modi eaque iusto commodi.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 38L, "Voluptatem et veniam iusto rerum.", new DateTime(2023, 5, 1, 17, 11, 19, 681, DateTimeKind.Utc).AddTicks(5717), 14L, "Culpa maiores officiis deleniti cumque similique optio et sed ab.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 43L, "Nihil officia minima quae id occaecati quod.", new DateTime(2023, 9, 4, 14, 25, 20, 115, DateTimeKind.Utc).AddTicks(7975), 7L, "Totam expedita hic vel sint rerum earum facilis.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 51L, "Itaque quidem debitis nisi voluptate. Placeat facere omnis ea quia ea voluptatibus id laborum. Consequatur iure nisi voluptatem temporibus.", new DateTime(2023, 7, 12, 21, 49, 14, 91, DateTimeKind.Utc).AddTicks(4453), 19L, "Ipsa sequi voluptatum qui.", 3, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 65L, "Recusandae rerum dolor assumenda maiores placeat magnam debitis.\nFacilis velit et qui totam et iusto consequatur ut.", new DateTime(2022, 9, 8, 1, 42, 0, 181, DateTimeKind.Utc).AddTicks(4213), 35L, "Et expedita dignissimos et neque atque aut.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 28L, "Perspiciatis dolorum architecto placeat. Eum aut repellendus laudantium est cumque velit. Voluptatum fugiat aut. Est voluptatum natus sed qui. Inventore beatae totam et necessitatibus velit. Et pariatur voluptas veniam rerum.", new DateTime(2023, 2, 6, 19, 36, 56, 123, DateTimeKind.Utc).AddTicks(7297), 35L, "Nulla explicabo suscipit molestiae perferendis.", 1, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 7L, "Quis dignissimos ipsam et in dolores perferendis.", new DateTime(2021, 5, 22, 14, 25, 37, 812, DateTimeKind.Utc).AddTicks(1861), 37L, "Dolorum praesentium blanditiis quia commodi non quis voluptatem.", 3, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 24L, "Ab at at dolorem qui nobis doloremque.\nQuo aliquam omnis et illo voluptas culpa ea ducimus ea.\nEt eum est est neque qui.\nVoluptatem unde voluptatem non.\nDolor et dolor molestias et officia.", new DateTime(2021, 11, 15, 6, 39, 38, 883, DateTimeKind.Utc).AddTicks(284), 5L, "Et at iusto illum.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 67L, "Vitae eligendi consequatur laboriosam commodi atque.\nDolor eos est repellat enim aliquam ratione.", new DateTime(2023, 9, 1, 19, 27, 34, 624, DateTimeKind.Utc).AddTicks(1164), 31L, "Voluptas et quis voluptatem autem voluptas ducimus maiores praesentium odit.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 29L, "Rerum recusandae cum et officia odit aliquid saepe corrupti. Aliquid dolorum iste quia voluptatibus dolores nostrum ab quia dolor. Doloremque odio suscipit animi recusandae quo voluptatem odio.", new DateTime(2022, 10, 1, 15, 36, 12, 716, DateTimeKind.Utc).AddTicks(870), 11L, "Est recusandae aliquam provident molestiae.", 2, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 58L, "Cumque sint tenetur sed et.", new DateTime(2023, 5, 8, 4, 55, 33, 799, DateTimeKind.Utc).AddTicks(6483), 10L, "Non aspernatur recusandae soluta ratione quibusdam et totam voluptatem.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 25L, "qui", new DateTime(2022, 11, 23, 2, 43, 39, 90, DateTimeKind.Utc).AddTicks(1324), 14L, "Laboriosam totam expedita reprehenderit sed blanditiis.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 38L, "Natus esse sint magnam incidunt velit adipisci voluptatem.", new DateTime(2023, 1, 11, 17, 12, 24, 621, DateTimeKind.Utc).AddTicks(8680), 10L, "Ea consequatur aut.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 24L, "Ut vitae aut molestias. Expedita provident ex beatae nihil numquam nihil adipisci consequatur. Dolor quae sit consequuntur. Esse et veniam saepe nisi eius. Labore aut aut molestiae quaerat iure voluptatem exercitationem ut. Doloremque facere similique molestiae error.", new DateTime(2022, 10, 13, 15, 33, 42, 236, DateTimeKind.Utc).AddTicks(1623), 25L, "Iusto possimus laudantium accusantium possimus mollitia totam blanditiis odio corrupti.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 13L, "Doloribus dolorem et accusamus nostrum aliquam aut repellat tenetur.", new DateTime(2020, 5, 10, 21, 3, 45, 822, DateTimeKind.Utc).AddTicks(1512), 37L, "Voluptas tempore reprehenderit nesciunt et dignissimos omnis.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 60L, "Facilis quod expedita adipisci voluptates molestiae qui ut qui rerum. Perferendis iusto ea et quia. Harum nemo aliquam suscipit exercitationem error iure rerum. Et autem culpa nemo delectus voluptates.", new DateTime(2023, 7, 29, 19, 42, 21, 673, DateTimeKind.Utc).AddTicks(5616), 17L, "In iste voluptatum.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 39L, "Sequi blanditiis vero.", new DateTime(2022, 9, 2, 14, 32, 9, 19, DateTimeKind.Utc).AddTicks(5258), 25L, "Vel dolorem occaecati minus natus explicabo repudiandae optio.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 69L, "nobis", new DateTime(2023, 4, 19, 2, 45, 17, 985, DateTimeKind.Utc).AddTicks(3857), 40L, "Ut enim atque amet.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 12L, "Minus id minus rem voluptatum amet.", new DateTime(2023, 2, 6, 16, 43, 6, 7, DateTimeKind.Utc).AddTicks(6359), 6L, "Odio ratione voluptatem.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 37L, "Consequatur eveniet quidem enim quae voluptatum fugit error. Aut veritatis quo nemo fugiat deserunt veritatis ad. Et nihil autem.", new DateTime(2022, 11, 1, 17, 3, 16, 842, DateTimeKind.Utc).AddTicks(1509), 40L, "Commodi perferendis ut.", 1, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 44L, "Quam iste aliquam ex repudiandae atque beatae odit excepturi.", new DateTime(2022, 7, 4, 11, 21, 26, 835, DateTimeKind.Utc).AddTicks(9492), 13L, "At maiores aut aliquid perferendis adipisci odio expedita.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 37L, "Voluptas corrupti voluptas quaerat in minus provident.", new DateTime(2022, 3, 18, 15, 53, 26, 90, DateTimeKind.Utc).AddTicks(7337), 8L, "Vel ut repudiandae et.", 1, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 43L, "Repudiandae voluptatum quod sit voluptas nobis. Magni harum expedita non. Voluptatibus tempora explicabo quasi esse aspernatur. Facere perspiciatis inventore asperiores hic. Nostrum dicta rerum omnis voluptatem consectetur.", new DateTime(2023, 9, 8, 20, 2, 5, 850, DateTimeKind.Utc).AddTicks(1437), 29L, "At praesentium ea ut.", 1, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 35L, "Omnis iure rerum magnam perspiciatis necessitatibus et vero deleniti autem. Eaque animi ut consequatur laborum laudantium quos. Inventore cupiditate labore voluptas officia neque ducimus aliquam eos. Dolores est tempore doloremque aspernatur consequuntur autem beatae.", new DateTime(2023, 8, 23, 19, 4, 48, 605, DateTimeKind.Utc).AddTicks(8915), 1L, "Dolorem recusandae necessitatibus dolores ea velit vero laboriosam.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 60L, "et", new DateTime(2021, 4, 6, 1, 56, 6, 510, DateTimeKind.Utc).AddTicks(5812), 8L, "Hic dolore eveniet nostrum voluptatem.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 38L, "Et consequatur et eius.", new DateTime(2022, 8, 2, 5, 35, 7, 817, DateTimeKind.Utc).AddTicks(976), 1L, "Veritatis ex sunt aspernatur quidem voluptas non.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 51L, "Sequi aut aut nulla quod.", new DateTime(2023, 4, 11, 19, 59, 11, 597, DateTimeKind.Utc).AddTicks(2742), 26L, "Cum et autem.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 66L, "Laboriosam saepe temporibus non ipsa ut accusamus voluptas eos.\nRepellendus expedita est perferendis.", new DateTime(2022, 7, 28, 10, 44, 35, 772, DateTimeKind.Utc).AddTicks(6202), 27L, "Quisquam at reprehenderit beatae magnam.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 52L, "Temporibus quae fugiat.\nConsequatur quis commodi ipsum veritatis in officiis.\nAt cum nulla rerum fuga impedit doloremque qui unde deserunt.\nEt aliquid ratione quisquam molestiae.\nCommodi qui velit incidunt nulla.", new DateTime(2022, 2, 4, 10, 48, 55, 271, DateTimeKind.Utc).AddTicks(5941), 4L, "Quam consectetur ipsum et et soluta vel.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 14L, "Sit libero inventore odit facilis nesciunt.", new DateTime(2023, 1, 9, 3, 18, 12, 827, DateTimeKind.Utc).AddTicks(1692), 17L, "In ea animi autem qui dolores.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 50L, "quia", new DateTime(2023, 4, 25, 7, 49, 14, 749, DateTimeKind.Utc).AddTicks(6643), 35L, "Est odio vero optio consequuntur tempore est consequatur nemo.", 3, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 68L, "autem", new DateTime(2023, 2, 18, 23, 10, 19, 191, DateTimeKind.Utc).AddTicks(9288), 33L, "Rem cumque at consequatur tempora et facilis corporis ut iste.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 48L, "Et veniam veniam quia nemo cumque.\nAb nihil sed non qui omnis.\nEt harum dolores.\nOptio quisquam omnis est.", new DateTime(2023, 6, 15, 5, 19, 41, 374, DateTimeKind.Utc).AddTicks(4381), 33L, "Dolores quas ut nam illo consequatur sit amet repudiandae.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 35L, "autem", new DateTime(2023, 9, 7, 4, 35, 11, 115, DateTimeKind.Utc).AddTicks(9349), 4L, "Deleniti eaque doloribus.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 13L, "Ab est pariatur autem pariatur nostrum unde animi. Et illo ea. Iure unde fugit animi quo et dolorem.", new DateTime(2019, 8, 2, 19, 52, 2, 83, DateTimeKind.Utc).AddTicks(6754), 40L, "Quisquam quam aspernatur vel animi nostrum molestias necessitatibus.", 3, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 4L, "Eius dolore repellat sunt velit labore dolores nulla nesciunt libero. Cupiditate doloribus ab. Et ab enim consequatur. Debitis quis officiis quos. Saepe voluptate quia ut culpa ut. Autem in sit accusamus animi maxime molestiae.", new DateTime(2022, 8, 24, 21, 21, 1, 888, DateTimeKind.Utc).AddTicks(6373), 13L, "Qui eos reprehenderit culpa sint impedit.", 3, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 49L, "Atque dolorum odit non quis molestias.\nCorporis fugiat quis nemo culpa voluptatem omnis minus.\nQuisquam nemo corporis corporis rerum dolor sed.\nSapiente error dolore praesentium quos quia asperiores.\nImpedit tenetur voluptatem ipsum nostrum in dolores explicabo quae.\nFacere possimus sit maxime.", new DateTime(2023, 7, 17, 20, 44, 8, 211, DateTimeKind.Utc).AddTicks(4971), 33L, "Recusandae ea dicta numquam.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 22L, "Odio officiis consequatur non natus. Voluptatem vel non quaerat omnis. Ea provident eius. Iste quaerat cum a dicta et ratione. Ipsam libero id iusto nobis fugiat.", new DateTime(2023, 4, 18, 3, 14, 21, 258, DateTimeKind.Utc).AddTicks(5294), 19L, "Consequatur error molestias nihil quas omnis delectus consequatur quaerat labore.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 27L, "Maxime ut cumque.\nDolores unde non earum qui et non saepe natus rerum.", new DateTime(2023, 5, 27, 22, 15, 40, 276, DateTimeKind.Utc).AddTicks(6403), 18L, "Fuga neque quidem excepturi ipsa explicabo nesciunt nemo placeat.", 1, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 23L, "Porro est qui magni eum dolor optio.\nQuidem qui cumque hic maxime.\nNesciunt delectus omnis vero corporis eveniet et et in quis.\nEa ut quidem eius animi.\nTempora in consequatur voluptas velit cum dolore dolorum ut vitae.", new DateTime(2023, 9, 1, 13, 55, 1, 713, DateTimeKind.Utc).AddTicks(5687), 10L, "Tenetur ut hic qui dolorum dolorem repudiandae doloribus laboriosam quo.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 15L, "dolorem", new DateTime(2018, 9, 18, 19, 12, 48, 879, DateTimeKind.Utc).AddTicks(1716), 2L, "Non possimus voluptatem natus voluptatibus iure quod veniam et nostrum.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 34L, "Ut eaque vel animi placeat adipisci eaque.", new DateTime(2022, 12, 1, 1, 37, 22, 94, DateTimeKind.Utc).AddTicks(193), 36L, "Rem autem vel aut sapiente.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 36L, "consectetur", new DateTime(2021, 7, 16, 10, 0, 3, 657, DateTimeKind.Utc).AddTicks(2498), 7L, "Voluptates voluptas fugiat.", 4, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 8L, "Aut quibusdam minus doloremque maxime aliquid. Nobis ut explicabo consequuntur delectus maiores blanditiis sit quo asperiores. Harum ut ullam et ab.", new DateTime(2022, 4, 23, 8, 12, 11, 898, DateTimeKind.Utc).AddTicks(2094), 40L, "Laborum veniam hic.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "InitialSolution", "LanguageId" },
                values: new object[] { 10L, "In quis vel iure blanditiis dolorem mollitia quo est quis.", new DateTime(2022, 8, 26, 7, 41, 22, 125, DateTimeKind.Utc).AddTicks(8404), "Totam dolore voluptatem repellendus doloribus et beatae laudantium aut neque.", 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 55L, "Et aut autem maiores sit qui et eveniet harum labore. Est sint iure tenetur numquam dolor. Quia dolore temporibus rem suscipit excepturi dicta quas.", new DateTime(2023, 8, 29, 16, 22, 10, 662, DateTimeKind.Utc).AddTicks(3023), 35L, "Tenetur molestiae distinctio commodi dolores optio iusto pariatur.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 38L, "Unde molestias natus ad quod. Dolor atque quaerat quia quod recusandae quia voluptas assumenda et. Soluta sit at velit repellendus ad accusamus autem facere deserunt. Illum aut modi quia. Quos molestiae dolorem hic consequatur. Voluptatem mollitia eius deserunt possimus repellendus laboriosam a laudantium.", new DateTime(2023, 9, 2, 23, 45, 6, 663, DateTimeKind.Utc).AddTicks(6699), 30L, "Ad dolorem autem minus in ullam quam.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 2L, "Eum sapiente libero vel voluptatibus et deserunt porro ea earum.\nSunt sint accusamus aliquam reiciendis consectetur sint dicta eaque autem.\nAliquam minima atque atque.\nQuis reprehenderit neque mollitia.\nRepudiandae est assumenda harum omnis.\nOmnis dolorem placeat et.", new DateTime(2022, 9, 19, 10, 25, 10, 168, DateTimeKind.Utc).AddTicks(1343), 13L, "Aut omnis incidunt.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 46L, "Adipisci aliquam impedit iure saepe dolores voluptatum corporis voluptas.\nUt expedita dolor qui.\nDolorum molestiae reiciendis.\nSint quis omnis et incidunt distinctio dolor distinctio.\nQuos ut deserunt.", new DateTime(2023, 1, 26, 1, 36, 28, 479, DateTimeKind.Utc).AddTicks(6360), 24L, "Quibusdam quia sunt.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 5L, "Eligendi mollitia aut est.\nRerum amet voluptatum qui porro fugiat dignissimos.", new DateTime(2023, 3, 24, 14, 40, 6, 958, DateTimeKind.Utc).AddTicks(3429), 19L, "Neque voluptatem minima eligendi ducimus repudiandae dolorem tempore delectus consequuntur.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 70L, "Voluptas quidem labore iste.\nIllo maiores sit ipsam sunt repellat et delectus.\nItaque voluptas ducimus iusto id dignissimos.\nHarum vero dolor sed.", new DateTime(2023, 3, 13, 16, 43, 31, 558, DateTimeKind.Utc).AddTicks(3938), 17L, "Error officia optio ut.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 36L, "Pariatur nihil et atque est error ipsa facilis. Voluptatem dolore eum illo voluptatem reiciendis quia. Inventore ex minus illo accusamus mollitia fugiat ratione veritatis.", new DateTime(2022, 4, 10, 17, 26, 59, 139, DateTimeKind.Utc).AddTicks(8623), 38L, "Itaque excepturi praesentium qui alias hic.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 7L, "Corrupti neque ut mollitia aut.\nDeleniti cupiditate modi necessitatibus error corporis.\nVoluptatibus eum libero laboriosam officia dolorem sed.\nEst rerum porro et fugit molestiae sequi quasi velit cupiditate.\nVel cumque vel iusto mollitia unde dolor et.\nTempora porro atque.", new DateTime(2023, 9, 4, 23, 15, 31, 277, DateTimeKind.Utc).AddTicks(2763), 25L, "In itaque deserunt dolorem dolores quis provident.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 35L, "Dolorem voluptas veritatis voluptas qui vel consequatur.", new DateTime(2023, 6, 29, 16, 28, 44, 972, DateTimeKind.Utc).AddTicks(1584), 24L, "Aperiam rerum rem eum blanditiis et.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { "In possimus sit temporibus vel nesciunt id autem culpa et.\nEt in nesciunt beatae vel velit.\nOptio omnis et sed aut est esse perferendis animi.\nLabore sed quia accusamus temporibus eum.\nOmnis fugiat reiciendis dolore dolorem pariatur iusto repellendus laborum.", new DateTime(2023, 9, 2, 5, 42, 56, 679, DateTimeKind.Utc).AddTicks(9878), 10L, "Autem voluptate voluptatem.", 1, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 21L, "Et natus sed dolores ipsa.\nIste blanditiis placeat.\nVoluptatem perspiciatis iusto mollitia provident.\nRem sit et unde placeat doloribus consequatur voluptate eum perspiciatis.\nIllo eveniet omnis deserunt sed aut est dignissimos id.", new DateTime(2023, 4, 22, 18, 5, 36, 193, DateTimeKind.Utc).AddTicks(1442), 24L, "Asperiores quam illum necessitatibus et veniam.", 3, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 1L, "Sapiente mollitia hic ratione quia.\nConsequatur consectetur quibusdam nemo et et et.\nMaiores eligendi velit iusto eum voluptatem molestiae.\nIpsum officia et quae sed.\nNihil minus sapiente voluptatibus delectus est recusandae neque.\nAut recusandae maiores harum esse nulla doloribus dolore.", new DateTime(2023, 1, 15, 11, 44, 21, 378, DateTimeKind.Utc).AddTicks(2664), 12L, "Enim rerum tempore et.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 25L, "Magni dicta explicabo assumenda.", new DateTime(2023, 6, 19, 14, 12, 42, 380, DateTimeKind.Utc).AddTicks(3394), 12L, "Et qui tempore ex cum molestiae.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 12L, "Laboriosam officia ipsa debitis.", new DateTime(2022, 11, 20, 8, 58, 0, 269, DateTimeKind.Utc).AddTicks(7332), 22L, "Qui illo tempora et nulla sint molestias.", 2, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 38L, "Est repellendus est qui illo ad aperiam. Velit et non rerum sequi nulla. Dolore voluptatem quidem dicta. Distinctio mollitia et consequatur. Maiores enim commodi dicta omnis. Optio earum reiciendis eos et provident.", new DateTime(2023, 8, 28, 7, 14, 45, 600, DateTimeKind.Utc).AddTicks(20), "Quam quaerat id ad placeat.", 3, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 30L, "Maiores quo totam.\nDelectus tempore vel.\nVoluptas incidunt earum dolor maiores qui.\nVelit aut voluptatem ea eligendi et repellendus sed.\nNulla id laboriosam deserunt cupiditate commodi voluptatibus magnam explicabo consequatur.\nOptio ratione praesentium aut ipsum officia unde magnam.", new DateTime(2020, 3, 21, 13, 57, 26, 445, DateTimeKind.Utc).AddTicks(2149), 24L, "Sit id consequatur eos sunt voluptatem quos aliquam fugit porro.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 56L, "tempora", new DateTime(2019, 8, 24, 4, 9, 20, 981, DateTimeKind.Utc).AddTicks(845), 17L, "Voluptas perferendis qui sit amet nihil sed harum similique.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 59L, "beatae", new DateTime(2023, 2, 22, 22, 38, 55, 256, DateTimeKind.Utc).AddTicks(9607), 36L, "Vitae quia repudiandae perferendis ut rerum sint amet.", 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 57L, "in", new DateTime(2022, 8, 5, 13, 44, 0, 17, DateTimeKind.Utc).AddTicks(7187), 34L, "Consequatur soluta aliquid qui sint et iure totam veritatis in.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 57L, "nisi", new DateTime(2022, 7, 13, 16, 47, 23, 275, DateTimeKind.Utc).AddTicks(2412), 14L, "Aut velit cupiditate voluptas in quis aut qui.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 8L, "Est ea itaque ut ullam molestiae nobis cumque maxime repellat. Autem quae aut reiciendis nihil est qui ipsa. Quaerat atque necessitatibus et voluptate eum iusto autem laudantium. Impedit fuga beatae illum necessitatibus ut earum autem temporibus repudiandae.", new DateTime(2019, 4, 21, 1, 8, 12, 704, DateTimeKind.Utc).AddTicks(3062), 14L, "Aut numquam illo distinctio omnis quia.", 4, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 69L, "Maxime est eligendi quia sint. Earum totam asperiores saepe labore temporibus. Fugit ullam incidunt numquam consequatur.", new DateTime(2023, 7, 8, 12, 48, 13, 324, DateTimeKind.Utc).AddTicks(5862), 6L, "Non fugit beatae.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 6L, "Molestias hic ex debitis molestiae quia nobis qui. At voluptatem sint sunt et natus inventore. Possimus cumque eveniet quasi. Accusantium voluptatem et fugiat.", new DateTime(2023, 7, 16, 0, 51, 41, 438, DateTimeKind.Utc).AddTicks(5166), 12L, "Magni ut nesciunt aliquid.", 3, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 19L, "provident", new DateTime(2022, 10, 20, 3, 7, 6, 465, DateTimeKind.Utc).AddTicks(7866), 29L, "Tempore quia qui voluptas non ut accusamus.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 10L, "Eaque quaerat deserunt deserunt est voluptatum modi quaerat placeat et.", new DateTime(2023, 9, 6, 2, 15, 27, 232, DateTimeKind.Utc).AddTicks(2172), 6L, "Exercitationem sunt deleniti recusandae deserunt velit nihil facilis.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 63L, "Alias quis magnam provident quam.", new DateTime(2022, 4, 15, 2, 7, 24, 942, DateTimeKind.Utc).AddTicks(2520), 12L, "Mollitia consequatur sint itaque ut animi voluptate fugit labore quas.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 10L, "Magni autem sit.\nAt deleniti aliquid odit voluptatibus debitis.\nAutem asperiores eum quo quibusdam.\nAut est vitae ducimus.\nUt eaque harum dignissimos nemo architecto.", new DateTime(2023, 5, 26, 18, 27, 14, 15, DateTimeKind.Utc).AddTicks(5128), 12L, "Beatae aperiam et ut delectus aut neque at aliquid rerum.", 3, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 57L, "et", new DateTime(2023, 3, 15, 0, 46, 38, 610, DateTimeKind.Utc).AddTicks(8247), 7L, "In ipsa ut qui.", 1, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 31L, "Voluptatum voluptatibus aut voluptate ipsum minima blanditiis voluptas.\nA est quibusdam voluptatibus tempore saepe.\nRerum consequatur sint harum nisi maxime et ipsa rem.\nEt mollitia accusantium laudantium sed dolore officia impedit similique et.\nPorro et rerum ea aliquam cum est maiores.", new DateTime(2023, 4, 2, 15, 28, 4, 583, DateTimeKind.Utc).AddTicks(3624), 7L, "Ut quam ducimus illo fugit recusandae explicabo.", 1, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 26L, "Omnis voluptas itaque quis est vero illum sit.", new DateTime(2023, 2, 1, 15, 52, 16, 144, DateTimeKind.Utc).AddTicks(2561), 11L, "Veniam id aut.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 55L, "Iusto eligendi esse sint facilis laborum ea quo quis.", new DateTime(2023, 3, 18, 17, 57, 51, 764, DateTimeKind.Utc).AddTicks(6630), 10L, "Eos ipsum sit aperiam ad dicta quasi dolor inventore ullam.", 4, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 8L, "adipisci", new DateTime(2018, 10, 16, 7, 57, 52, 997, DateTimeKind.Utc).AddTicks(3483), 29L, "Distinctio saepe dolorum delectus neque tempore.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 29L, "Repudiandae ut animi quaerat reprehenderit voluptas et. Est voluptate rerum iusto sit veniam dolor magnam et. Illum architecto repudiandae explicabo quia id ipsum. Et et beatae ipsam. Inventore ut quis.", new DateTime(2022, 1, 28, 21, 59, 58, 917, DateTimeKind.Utc).AddTicks(5545), 38L, "Assumenda impedit quidem quo et quam quia animi.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 46L, "Iste fuga ipsum fuga inventore.", new DateTime(2022, 7, 11, 18, 5, 58, 357, DateTimeKind.Utc).AddTicks(9034), 33L, "Voluptas molestiae laborum magnam aut.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 40L, "assumenda", new DateTime(2023, 3, 31, 4, 11, 58, 437, DateTimeKind.Utc).AddTicks(1210), 23L, "Dicta magnam laboriosam consequatur optio suscipit aliquid eum provident sapiente.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 31L, "quaerat", new DateTime(2023, 8, 6, 9, 39, 57, 834, DateTimeKind.Utc).AddTicks(9566), 24L, "Atque et quisquam eveniet quo rerum consequatur et est repellat.", 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 45L, "Nisi occaecati at molestias veritatis alias laudantium suscipit. Suscipit ipsum minima consectetur esse reprehenderit natus temporibus. Aliquid autem ad ut est blanditiis architecto impedit.", new DateTime(2023, 2, 2, 17, 9, 19, 782, DateTimeKind.Utc).AddTicks(6092), 31L, "Et qui incidunt minima.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 37L, "In fuga repellat sunt et alias sunt ratione enim distinctio.", new DateTime(2022, 12, 24, 11, 8, 42, 78, DateTimeKind.Utc).AddTicks(8514), 18L, "Libero sequi quos.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 66L, "eum", new DateTime(2023, 1, 1, 6, 11, 18, 272, DateTimeKind.Utc).AddTicks(7035), 7L, "Quaerat totam beatae voluptates in et ex.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 37L, "Aliquid modi aliquid.", new DateTime(2021, 11, 2, 21, 12, 57, 861, DateTimeKind.Utc).AddTicks(4955), 31L, "Molestiae sapiente animi.", 2, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 22L, "Nobis velit sint natus delectus enim.\nQuod quas et a asperiores cumque fuga necessitatibus error.\nAb et velit aperiam.\nConsequatur qui dicta.", new DateTime(2023, 1, 26, 9, 44, 24, 426, DateTimeKind.Utc).AddTicks(8584), 29L, "Odit beatae ipsam.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 39L, "Non atque nulla sed iste ipsam veritatis nihil.", new DateTime(2023, 8, 16, 22, 0, 13, 704, DateTimeKind.Utc).AddTicks(9851), 11L, "Error nobis velit aliquid excepturi ducimus ipsa.", 1, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 44L, "Nam sit nesciunt ducimus qui enim et enim autem sed.", new DateTime(2021, 8, 20, 19, 50, 16, 697, DateTimeKind.Utc).AddTicks(9191), 27L, "Autem error animi quia rem.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 25L, "dolor", new DateTime(2023, 7, 19, 3, 1, 3, 240, DateTimeKind.Utc).AddTicks(1215), 17L, "Est voluptas est id debitis.", 3, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 11L, "consequatur", new DateTime(2021, 9, 18, 13, 11, 51, 706, DateTimeKind.Utc).AddTicks(1180), 18L, "Voluptates quia sunt consequuntur omnis eos laudantium est facere.", 3, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 46L, "harum", new DateTime(2023, 7, 25, 6, 40, 28, 554, DateTimeKind.Utc).AddTicks(9369), 32L, "Dicta animi dolorem exercitationem asperiores veniam cumque est.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 5L, "Voluptas ipsa est veniam facere at quo occaecati.\nRepellat quos sint ipsa officiis odio est incidunt dolorum.\nExpedita quis aut.\nLibero quis harum aperiam qui asperiores temporibus id impedit dolores.\nRecusandae facilis commodi aliquid sunt aut eum.\nVitae cum doloribus perspiciatis placeat.", new DateTime(2023, 6, 12, 5, 15, 34, 870, DateTimeKind.Utc).AddTicks(49), 24L, "Atque laudantium autem et dolores sunt consequatur sunt.", 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 30L, "Voluptatem voluptatem dolor dolor odio earum autem. Aut non tempora ad aspernatur. Quia soluta quod. Quis vitae deserunt non ut nesciunt itaque nostrum minima corrupti. Ex aut voluptatibus consequatur maxime.", new DateTime(2019, 6, 5, 0, 27, 56, 107, DateTimeKind.Utc).AddTicks(662), 31L, "Velit enim expedita nesciunt illo asperiores sed.", 1, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 44L, "Ut provident corrupti non consequatur.", new DateTime(2022, 2, 20, 7, 47, 46, 816, DateTimeKind.Utc).AddTicks(7735), 6L, "Ut beatae cumque itaque quia et non et tenetur.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { "Temporibus rem reiciendis sunt atque vel sint excepturi voluptas quo.", new DateTime(2023, 9, 1, 23, 36, 17, 738, DateTimeKind.Utc).AddTicks(4133), 22L, "Perferendis cupiditate iste et laudantium.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 11L, "Qui et neque qui sapiente veritatis. Vel beatae praesentium vero. Neque et minima nam quae cum esse ullam. Repellendus eum et perferendis assumenda vitae molestiae qui.", new DateTime(2020, 2, 16, 23, 58, 28, 503, DateTimeKind.Utc).AddTicks(9916), 29L, "Id qui voluptatem.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 4L, "Qui quasi ea. In tenetur facere et sunt explicabo magni consectetur. Maxime natus veniam ipsam ipsam hic autem sit eius aliquam. Qui sapiente a porro accusantium ad voluptas doloremque.", new DateTime(2022, 10, 7, 6, 21, 19, 343, DateTimeKind.Utc).AddTicks(617), 30L, "Inventore voluptate nisi at qui laboriosam hic omnis iste tempora.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 42L, "distinctio", new DateTime(2023, 3, 31, 9, 48, 2, 607, DateTimeKind.Utc).AddTicks(8528), 20L, "Qui omnis et dicta delectus ipsam.", 2, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 25L, "Aut autem et qui vel. Illum ipsum consectetur dolor recusandae aliquam earum quos neque corrupti. Sit omnis doloremque recusandae repellat. Quae alias recusandae est tempore impedit voluptas in enim. Veritatis aut accusamus omnis. In in molestiae id voluptas in.", new DateTime(2023, 5, 30, 3, 41, 19, 292, DateTimeKind.Utc).AddTicks(8358), 9L, "Doloremque in aut animi illum cumque dolorem iusto asperiores eaque.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 30L, "qui", new DateTime(2018, 2, 21, 11, 54, 26, 705, DateTimeKind.Utc).AddTicks(461), 25L, "Harum nihil modi repellendus voluptatem aut ut officiis eos debitis.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 34L, "Deleniti perferendis possimus. Officiis dicta commodi quod. Eveniet cum enim. Consequatur quis enim quam et blanditiis et asperiores. Consequatur perferendis quisquam hic magnam sit consequuntur hic unde.", new DateTime(2022, 11, 7, 1, 52, 7, 547, DateTimeKind.Utc).AddTicks(7760), 30L, "Eum exercitationem recusandae repudiandae possimus aut id adipisci sequi nihil.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 55L, "Ipsam et id dolorum sint velit et.\nFacilis quod esse et quo sit et inventore.", new DateTime(2023, 5, 7, 5, 27, 45, 191, DateTimeKind.Utc).AddTicks(8283), 36L, "Quis qui provident quod eos autem qui aliquam.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 28L, "Aut omnis sed necessitatibus est et.\nNon molestiae iure architecto.\nArchitecto atque delectus officiis aut optio natus cupiditate ipsam.\nDeleniti est sit.\nNesciunt ex id unde mollitia et quia quia tempore voluptatibus.\nDoloremque amet ipsam velit nulla.", new DateTime(2023, 1, 6, 0, 11, 19, 996, DateTimeKind.Utc).AddTicks(5048), 5L, "Error magni quasi et.", 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 56L, "Impedit nobis impedit pariatur est.", new DateTime(2022, 12, 18, 23, 38, 47, 213, DateTimeKind.Utc).AddTicks(8123), 22L, "Animi quaerat ut modi rerum sit magni non.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 34L, "veritatis", new DateTime(2023, 1, 1, 5, 36, 54, 575, DateTimeKind.Utc).AddTicks(755), 14L, "Voluptatibus in omnis molestias et fugit rem dolorum sunt.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 48L, "Est natus labore quae mollitia qui sunt. Eos et nobis corrupti porro cumque eius distinctio. Amet quia facilis quis modi. Ut explicabo quam.", new DateTime(2023, 3, 15, 23, 42, 16, 395, DateTimeKind.Utc).AddTicks(6380), 3L, "Sapiente debitis beatae quod nihil.", 1, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 37L, "Dolorum qui expedita autem expedita quaerat expedita esse.", new DateTime(2022, 2, 27, 22, 25, 14, 513, DateTimeKind.Utc).AddTicks(9097), 28L, "Blanditiis consequatur quidem omnis incidunt sunt dolores odio.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 38L, "Inventore aperiam impedit et libero. Quod eligendi rerum voluptatem mollitia id. Est ullam voluptas hic sit quis rerum voluptas repellat est. Magnam vitae voluptatem et ipsam veritatis deserunt omnis dolorem. Animi omnis hic adipisci maiores maiores eligendi dolorem quod. Et dolor sint commodi expedita esse molestiae.", new DateTime(2022, 7, 17, 20, 45, 37, 827, DateTimeKind.Utc).AddTicks(5161), 23L, "Totam ut tenetur dolor autem ut.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 67L, "Natus illum omnis ratione aut sed illum possimus doloremque.", new DateTime(2023, 2, 14, 16, 35, 34, 663, DateTimeKind.Utc).AddTicks(1226), 11L, "Repudiandae vel qui dolorem quia.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 27L, "Ut tempore ut ut et aperiam vel ea. Similique ducimus et ut et consequatur consequatur aliquid sed. Libero at sequi quia harum aut perferendis. Nisi sit ut dolorem rem sit at culpa. Repudiandae rem eaque.", new DateTime(2022, 11, 14, 1, 5, 20, 283, DateTimeKind.Utc).AddTicks(9346), 23L, "Rem similique ut a.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 35L, "At vitae laudantium animi minus atque exercitationem aperiam iure iste. Reiciendis id sed eius ut blanditiis. Vitae vel exercitationem incidunt officia eum ratione totam id commodi. Illum porro voluptas dolorem numquam repellat et rerum ipsam id.", new DateTime(2023, 5, 14, 8, 50, 22, 705, DateTimeKind.Utc).AddTicks(2120), 10L, "Suscipit ad autem laudantium velit unde.", 3, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 48L, "Blanditiis ut maxime recusandae sequi similique quo beatae.\nOccaecati sed quisquam quaerat eos qui cupiditate voluptas hic.\nIn at harum officiis in quia enim architecto ab similique.\nPerspiciatis autem consequatur consequatur eos rem consequatur iste.", new DateTime(2023, 6, 29, 7, 4, 55, 455, DateTimeKind.Utc).AddTicks(9627), 36L, "Excepturi mollitia nesciunt nesciunt error maxime libero possimus quos tempore.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 7L, "Neque quisquam harum sint.\nQui reprehenderit dolorem qui voluptas quos temporibus excepturi magni.\nQuod porro aliquam minima libero porro est voluptas ipsam in.\nNon quibusdam sed assumenda consequatur rem occaecati suscipit sint qui.", new DateTime(2020, 4, 23, 16, 49, 44, 956, DateTimeKind.Utc).AddTicks(5141), 2L, "Ipsa iusto corporis.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 13L, "Vero sint reprehenderit a voluptatem.\nDolorem necessitatibus mollitia harum a fugiat voluptatem.", new DateTime(2023, 9, 6, 8, 26, 37, 593, DateTimeKind.Utc).AddTicks(5150), 7L, "Eum nisi dolor iure iure similique aspernatur corporis.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 7L, "Incidunt quae a ratione nam illum quia eos.\nSimilique qui voluptatem atque consequatur accusamus.\nNesciunt sed non tenetur earum corporis sunt.", new DateTime(2021, 8, 30, 4, 1, 24, 491, DateTimeKind.Utc).AddTicks(8732), 18L, "Aperiam labore officia architecto rerum quam dolores perferendis.", 1, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 66L, "Ea dolores nostrum sunt veritatis quidem dicta. Et architecto repudiandae. Saepe ea voluptate possimus molestiae a earum veritatis qui autem. Voluptas et et eos dolorum qui id a. Veniam sint at blanditiis est minus doloremque vel. Nesciunt quis quis fuga sed est eveniet sed qui voluptatum.", new DateTime(2023, 8, 31, 7, 53, 26, 114, DateTimeKind.Utc).AddTicks(6552), 9L, "Sit quas aliquam non eveniet in voluptates.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 22L, "Hic odit adipisci non natus veritatis labore.\nCorporis cumque ipsa.\nEt quas odio magni consequatur optio.", new DateTime(2023, 5, 24, 2, 0, 20, 490, DateTimeKind.Utc).AddTicks(957), 26L, "Delectus voluptas repellat dolores laudantium cupiditate praesentium sed veniam.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 68L, "Incidunt reprehenderit ipsum eaque minima voluptatem autem.", new DateTime(2023, 3, 19, 1, 17, 11, 800, DateTimeKind.Utc).AddTicks(4908), 21L, "Doloremque rerum provident harum voluptates aliquam.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 5L, "qui", new DateTime(2023, 6, 4, 14, 59, 53, 401, DateTimeKind.Utc).AddTicks(7078), 13L, "Ut aliquam sapiente dicta sit.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 23L, "At voluptatibus quia porro nisi necessitatibus. Quam fugit quos. Similique unde culpa qui possimus minima dolorem facere. Laborum corrupti consequuntur optio modi commodi necessitatibus totam et.", new DateTime(2023, 9, 5, 20, 41, 36, 644, DateTimeKind.Utc).AddTicks(8573), 26L, "Eveniet cum non id sunt ab ea provident modi.", 4, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 4L, "cum", new DateTime(2022, 12, 13, 21, 39, 54, 693, DateTimeKind.Utc).AddTicks(8042), 3L, "Magni voluptatem molestias quisquam placeat consectetur.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 11L, "Excepturi ea quia tempora earum eos aut perferendis. Est dignissimos alias nam est vel. Est voluptatem enim vel error corporis et quaerat.", new DateTime(2019, 8, 4, 10, 21, 12, 316, DateTimeKind.Utc).AddTicks(1278), 5L, "Animi aliquam inventore aspernatur deleniti repellendus commodi at fuga dolores.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 63L, "consectetur", new DateTime(2022, 7, 30, 7, 18, 28, 482, DateTimeKind.Utc).AddTicks(792), 20L, "Perferendis quod placeat sed quos ipsam ut qui.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 47L, "aut", new DateTime(2021, 6, 13, 14, 55, 13, 234, DateTimeKind.Utc).AddTicks(5614), 4L, "Vel dolor omnis.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 9L, "Fugit dolores atque eum.", new DateTime(2020, 9, 1, 6, 17, 42, 942, DateTimeKind.Utc).AddTicks(1818), 27L, "Sint et temporibus sapiente doloribus quod at possimus cumque.", 1, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 39L, "Nam omnis quasi consequuntur.\nVeniam blanditiis voluptatem ut incidunt incidunt.\nVoluptatem magnam est repudiandae voluptas nobis.\nIllo est ratione.", new DateTime(2022, 2, 21, 16, 37, 53, 729, DateTimeKind.Utc).AddTicks(1401), 17L, "Facilis quia suscipit.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { "nobis", new DateTime(2023, 6, 23, 5, 21, 6, 145, DateTimeKind.Utc).AddTicks(8114), 38L, "Enim quo qui et molestiae animi consectetur voluptatibus et.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 9L, "Voluptatum voluptatem enim laborum quae consectetur dolor.\nDoloribus unde veritatis quod veniam porro repellat ut perferendis atque.\nVoluptatibus nam explicabo saepe.\nUnde perspiciatis ut.\nOfficia sint fugit tempore velit aut est nam natus.", new DateTime(2023, 5, 1, 18, 54, 9, 682, DateTimeKind.Utc).AddTicks(8044), 10L, "Iste cupiditate earum exercitationem qui consequatur et expedita molestias corrupti.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 9L, "Exercitationem quibusdam at.", new DateTime(2021, 10, 28, 7, 14, 28, 437, DateTimeKind.Utc).AddTicks(9924), 3L, "Reiciendis aut omnis ducimus est et quam.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 18L, "Atque facere omnis non sint.\nAsperiores explicabo optio voluptatem.\nNihil odit autem in.\nVoluptatem sed ea commodi dolorum.", new DateTime(2022, 2, 19, 16, 16, 13, 631, DateTimeKind.Utc).AddTicks(433), 20L, "Reiciendis qui quasi iusto reprehenderit ut ipsum quasi suscipit.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 25L, "Sunt at non.\nQuasi voluptate ratione.\nTempora est voluptas perferendis eos repudiandae aut et enim.\nQuod deserunt et aliquam.\nAutem cumque voluptatibus.\nSed fugiat quam sint laudantium error ex dolorem voluptate.", new DateTime(2023, 6, 25, 23, 46, 17, 167, DateTimeKind.Utc).AddTicks(5592), 9L, "Aut ad culpa ipsam placeat et.", 2, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 23L, "Soluta ut eius perspiciatis quo qui. Nemo sunt officia accusantium repellat aut magni et qui. Placeat qui voluptatum sapiente recusandae provident voluptas vitae ut. Neque tempora aut blanditiis. Quia maiores fugiat natus nisi.", new DateTime(2023, 8, 25, 6, 2, 54, 854, DateTimeKind.Utc).AddTicks(2583), 20L, "Veniam nulla numquam rem accusamus commodi.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 49L, "Dicta laborum eum.\nRem placeat quis.\nLaudantium accusamus harum libero beatae reiciendis.", new DateTime(2023, 7, 11, 21, 50, 21, 692, DateTimeKind.Utc).AddTicks(5229), 33L, "Dolorum quisquam nihil voluptatum.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 27L, "Quia expedita dolores voluptatum illum quia accusantium nulla a quis. Dicta consectetur delectus ut blanditiis a dolorem. Modi corrupti aperiam facere et quam ipsa repudiandae aut amet. Ab omnis perferendis praesentium aliquam aut autem. At officiis hic nostrum.", new DateTime(2022, 7, 8, 23, 10, 39, 754, DateTimeKind.Utc).AddTicks(4091), 9L, "Odit aut nihil aut maiores.", 3, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 6L, "Dicta et voluptas illo est nostrum. Expedita eum labore a architecto qui impedit ut vitae et. Dicta enim velit nemo consequatur nisi non non est corrupti. Qui rerum deserunt quas. Ipsum ut provident.", new DateTime(2023, 7, 21, 19, 18, 46, 869, DateTimeKind.Utc).AddTicks(6723), 2L, "Fuga delectus nulla neque.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 14L, "aut", new DateTime(2022, 12, 30, 3, 41, 1, 116, DateTimeKind.Utc).AddTicks(8197), 10L, "Qui aliquid eos eum et.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { "Optio ut rerum omnis cumque necessitatibus quas.", new DateTime(2023, 9, 9, 18, 27, 16, 792, DateTimeKind.Utc).AddTicks(4848), 9L, "Sed dolores nulla nulla occaecati molestiae et et aliquid.", 1, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 5L, "Optio quisquam ut consequatur reprehenderit commodi eaque aliquam.", new DateTime(2023, 7, 20, 19, 32, 53, 252, DateTimeKind.Utc).AddTicks(4369), 9L, "Perspiciatis laboriosam ea.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 23L, "nam", new DateTime(2023, 8, 29, 22, 18, 7, 580, DateTimeKind.Utc).AddTicks(7839), 31L, "Maiores similique est saepe dignissimos sit ut ullam consequatur.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 62L, "Ratione minima excepturi dignissimos expedita dignissimos fuga commodi enim et.\nQuas vero ducimus.\nConsequatur laboriosam in ex ut qui culpa quae provident deleniti.", new DateTime(2023, 6, 10, 4, 4, 43, 295, DateTimeKind.Utc).AddTicks(3871), 5L, "Accusantium explicabo delectus expedita.", 4, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 45L, "illum", new DateTime(2023, 3, 1, 10, 14, 4, 906, DateTimeKind.Utc).AddTicks(920), 16L, "Nisi ut et maxime.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 35L, "Aperiam maxime similique incidunt voluptatibus.\nEst error ipsa quaerat perspiciatis ullam nam ut inventore nihil.\nAmet iusto possimus iusto necessitatibus nulla aperiam dolorem aperiam.", new DateTime(2023, 5, 15, 0, 18, 29, 2, DateTimeKind.Utc).AddTicks(3877), "Aut dolores enim dignissimos minus et sunt.", 1, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 59L, "quia", new DateTime(2023, 4, 13, 8, 47, 32, 602, DateTimeKind.Utc).AddTicks(5473), 37L, "Debitis inventore ut.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 60L, "Enim ut consectetur.", new DateTime(2021, 7, 29, 2, 38, 10, 348, DateTimeKind.Utc).AddTicks(2386), 36L, "Ipsa repellat qui fugiat aperiam.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 25L, "Labore ducimus quam est alias alias non.", new DateTime(2022, 11, 30, 12, 29, 5, 758, DateTimeKind.Utc).AddTicks(5383), 34L, "Rerum facere ut.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 27L, "fugit", new DateTime(2022, 7, 28, 18, 37, 51, 180, DateTimeKind.Utc).AddTicks(3854), 4L, "Et eaque culpa sed quia aspernatur sed.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 28L, "tempora", new DateTime(2022, 12, 28, 15, 35, 18, 215, DateTimeKind.Utc).AddTicks(8689), 17L, "Accusamus saepe consectetur soluta rerum vel aut omnis.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 9L, "exercitationem", new DateTime(2021, 6, 12, 2, 2, 40, 280, DateTimeKind.Utc).AddTicks(882), 2L, "Distinctio omnis officia aspernatur dolores atque maxime in.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 28L, "Eos quo dolorum eum error non porro molestiae et inventore.", new DateTime(2022, 12, 24, 4, 47, 37, 922, DateTimeKind.Utc).AddTicks(8798), 25L, "Nulla rerum maiores blanditiis nemo nesciunt magni maxime repellat corrupti.", 1, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 8L, "Iure quas est.", new DateTime(2022, 2, 26, 8, 29, 3, 462, DateTimeKind.Utc).AddTicks(2678), 3L, "Provident soluta perferendis quia dolorem consequuntur perspiciatis et.", 4, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 162L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 49L, "Quod animi nemo optio laborum voluptatum non ipsam rem. Voluptatem perferendis ipsum alias ea. Dolorem non dolor expedita tenetur eos. Vel quia quia reiciendis vitae.", new DateTime(2023, 8, 17, 22, 17, 18, 977, DateTimeKind.Utc).AddTicks(5230), 35L, "Nihil tempore ducimus natus voluptas voluptas.", 1, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 163L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 3L, "Aliquam libero ipsa explicabo et fugit. Facere fugiat animi ad. Occaecati quos dolores consequuntur adipisci repellendus et ullam exercitationem esse. In cum magni voluptatem. Voluptatem dolorem animi unde voluptas facere et.", new DateTime(2023, 8, 16, 10, 16, 46, 652, DateTimeKind.Utc).AddTicks(9940), 8L, "Debitis dolorem temporibus eligendi necessitatibus ipsum quidem repellendus sed.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 164L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 41L, "Enim ipsam magni voluptas ut laudantium quam consequatur quibusdam.\nQui libero repellat est neque assumenda et.\nDicta ipsum mollitia qui.\nVoluptas dolores at accusantium consequatur a et itaque.", new DateTime(2022, 9, 17, 19, 46, 6, 372, DateTimeKind.Utc).AddTicks(8265), 12L, "Delectus sint ad omnis et quia in tempore.", 3, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 165L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 58L, "magnam", new DateTime(2022, 10, 2, 9, 54, 0, 164, DateTimeKind.Utc).AddTicks(4640), 17L, "Accusantium voluptas in id qui aut beatae.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 51L, "Odio laborum voluptate officiis rerum numquam sunt voluptatem.", new DateTime(2023, 2, 1, 6, 5, 7, 728, DateTimeKind.Utc).AddTicks(9497), 25L, "Quam quam nesciunt ducimus tempore aut.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 11L, "odit", new DateTime(2018, 12, 4, 23, 15, 3, 325, DateTimeKind.Utc).AddTicks(6694), 4L, "Error omnis itaque error sunt et in.", 3, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 12L, "iusto", new DateTime(2023, 9, 6, 7, 46, 1, 543, DateTimeKind.Utc).AddTicks(2427), 16L, "Eum est illum nobis beatae eos asperiores velit.", 1, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 5L, "Aspernatur aut ut quas vero est sit quia.\nBlanditiis dolorum rerum voluptas sint ut autem similique consequatur non.", new DateTime(2023, 8, 13, 1, 47, 36, 363, DateTimeKind.Utc).AddTicks(6874), 19L, "Ipsum inventore et vero vel.", 1, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 23L, "corporis", new DateTime(2023, 9, 4, 1, 30, 47, 421, DateTimeKind.Utc).AddTicks(272), 5L, "Nostrum reiciendis in.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 55L, "Provident quis perferendis culpa voluptatibus facilis perferendis expedita. Eum error placeat repellendus recusandae harum. Ullam veniam tempora sit. Rem beatae vel facilis officiis ipsum.", new DateTime(2023, 1, 29, 3, 34, 16, 586, DateTimeKind.Utc).AddTicks(782), 4L, "Ut quos omnis veniam magnam eveniet incidunt libero possimus ipsa.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 32L, "Odit doloribus provident totam sapiente animi.", new DateTime(2023, 9, 9, 0, 30, 15, 860, DateTimeKind.Utc).AddTicks(9686), 29L, "Nobis et perferendis exercitationem id soluta blanditiis sunt.", 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 8L, "Officiis suscipit nemo sed.", new DateTime(2022, 9, 9, 14, 45, 36, 235, DateTimeKind.Utc).AddTicks(739), 25L, "Inventore non sed recusandae odit.", 1, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 18L, "voluptate", new DateTime(2021, 5, 17, 5, 16, 9, 75, DateTimeKind.Utc).AddTicks(3654), 25L, "Id est omnis quasi aut ut qui.", 1, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 48L, "Neque quibusdam temporibus quas commodi soluta.", new DateTime(2023, 8, 25, 14, 14, 9, 627, DateTimeKind.Utc).AddTicks(4046), 7L, "Quibusdam aliquid mollitia aut explicabo aut sunt reiciendis.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 57L, "Et est porro doloribus perspiciatis. Facere nobis vel possimus. Doloremque autem aliquid harum consequatur quia aperiam est ipsa. Enim officia quisquam nesciunt qui harum dicta. Error quo voluptatibus officiis impedit quas dolorem.", new DateTime(2023, 3, 17, 6, 30, 22, 189, DateTimeKind.Utc).AddTicks(7844), 11L, "Ut dicta labore vel.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 45L, "expedita", new DateTime(2023, 7, 26, 19, 22, 28, 615, DateTimeKind.Utc).AddTicks(7908), 40L, "Dolorem sint dolores consequuntur eos vel harum ad et ut.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 62L, "Temporibus sit et non odit. Qui aperiam officia illum qui ut et consequatur. Eius delectus accusamus aut ducimus aut et tempore rerum. Sint debitis ea delectus inventore delectus eum voluptates cumque.", new DateTime(2023, 4, 4, 0, 56, 57, 813, DateTimeKind.Utc).AddTicks(3340), 9L, "Animi libero dolor dolore ipsa omnis nesciunt vitae pariatur.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 59L, "Consequatur earum sed voluptatibus repellat sint reprehenderit ea. Atque impedit amet quibusdam modi et non at. Voluptas et consequatur rerum asperiores placeat laboriosam. Aperiam dolor sed saepe qui debitis. Velit aliquid accusantium itaque.", new DateTime(2023, 3, 6, 7, 25, 33, 532, DateTimeKind.Utc).AddTicks(5635), 13L, "Velit quibusdam tempora dolor numquam.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 65L, "minus", new DateTime(2023, 7, 31, 11, 38, 46, 540, DateTimeKind.Utc).AddTicks(1455), 25L, "Id quas nisi iste.", 3, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 18L, "Mollitia accusamus eaque. Accusamus temporibus suscipit quos laborum nam aliquam. Asperiores ut nulla dignissimos. Delectus dolores voluptatem eius suscipit incidunt beatae. Nisi quis odit explicabo ipsa blanditiis voluptatibus. Voluptas a voluptatem eligendi odit veritatis aut ad.", new DateTime(2020, 9, 25, 0, 21, 53, 242, DateTimeKind.Utc).AddTicks(8217), 28L, "Quia hic quis facilis perspiciatis aut numquam sequi voluptas.", 2, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 40L, "Sapiente voluptatem cupiditate quas incidunt in sunt quia.", new DateTime(2023, 5, 21, 23, 38, 45, 359, DateTimeKind.Utc).AddTicks(7027), 38L, "Rerum eaque assumenda et et fuga similique quibusdam.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 3L, "Quia iure et.\nAut provident cumque soluta qui.\nSed corporis quae.\nSoluta magnam quam.\nMaiores cumque molestias sit quaerat eveniet exercitationem.", new DateTime(2023, 8, 8, 4, 23, 24, 572, DateTimeKind.Utc).AddTicks(4493), 35L, "Qui ut voluptas maiores omnis dicta est eum odio.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 2L, "Labore pariatur voluptatem nemo.", new DateTime(2020, 6, 4, 23, 36, 18, 598, DateTimeKind.Utc).AddTicks(5145), 29L, "Fugiat vero nesciunt architecto sit omnis repudiandae.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 64L, "Dolores non vel sequi quas cumque dignissimos. Voluptatibus et cumque molestias sunt pariatur praesentium distinctio asperiores hic. Enim facilis suscipit assumenda nisi laborum optio.", new DateTime(2020, 2, 27, 23, 53, 5, 562, DateTimeKind.Utc).AddTicks(3936), 31L, "Sapiente aut impedit rerum error nemo magni.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 58L, "quisquam", new DateTime(2023, 2, 8, 23, 11, 43, 722, DateTimeKind.Utc).AddTicks(9247), 32L, "At hic quidem quo aperiam accusamus aut nam culpa.", 4 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 38L, "omnis", new DateTime(2023, 2, 13, 7, 31, 7, 43, DateTimeKind.Utc).AddTicks(5078), 24L, "Ut enim sit modi temporibus debitis.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 9L, "placeat", new DateTime(2022, 7, 13, 20, 17, 16, 164, DateTimeKind.Utc).AddTicks(333), 35L, "Numquam ducimus ut expedita eos.", 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 41L, "Sunt veritatis architecto voluptatum tenetur error voluptas repellat dicta.\nPossimus quas blanditiis.\nEt et facilis id ad amet eaque ea aspernatur veniam.\nEveniet rerum eum ut ipsam aut animi.", new DateTime(2022, 1, 15, 8, 36, 14, 725, DateTimeKind.Utc).AddTicks(8577), 24L, "Laborum eos cupiditate nesciunt et ut molestiae.", 4, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 68L, "Ex magnam dolorum eligendi quam enim eum.", new DateTime(2023, 1, 27, 17, 50, 17, 790, DateTimeKind.Utc).AddTicks(5212), 38L, "Quibusdam veritatis et voluptatem omnis rerum fugiat aut.", 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 52L, "Et earum non iure necessitatibus culpa praesentium.\nOdio quos nisi accusantium et eligendi.\nSit corrupti placeat fugit harum minima.", new DateTime(2022, 3, 4, 23, 58, 59, 254, DateTimeKind.Utc).AddTicks(7804), 35L, "Earum explicabo est hic sequi placeat debitis.", 4, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 69L, "Nam quo facere quia.\nEarum harum quas laboriosam corrupti natus ad sint dignissimos beatae.", new DateTime(2023, 3, 12, 14, 14, 29, 809, DateTimeKind.Utc).AddTicks(1898), 6L, "Eligendi soluta commodi.", 3, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 70L, "Delectus sit officiis. Voluptatibus et aut animi consequatur atque magni earum quia dolor. Itaque laborum non voluptatem. Aut in provident culpa ex dolorum omnis odio. Aut inventore id similique velit. Rerum ipsa blanditiis aspernatur rerum repellat distinctio.", new DateTime(2023, 6, 22, 21, 59, 34, 262, DateTimeKind.Utc).AddTicks(4342), 15L, "Nemo explicabo velit assumenda non fugiat sunt.", 2, 1 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 52L, "Aut error quibusdam.\nEt ea aspernatur sed dolore.\nNihil reprehenderit autem repudiandae qui modi eveniet nesciunt.\nVoluptatem quo odio vitae ut eos doloribus pariatur sed.\nVoluptas necessitatibus velit quia molestias iusto doloremque ratione placeat.", new DateTime(2022, 10, 2, 10, 34, 20, 362, DateTimeKind.Utc).AddTicks(5892), 19L, "Animi deserunt eius.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 25L, "illum", new DateTime(2023, 1, 26, 8, 27, 40, 609, DateTimeKind.Utc).AddTicks(7563), 20L, "Sunt ab doloribus vero iusto autem eligendi.", 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId" },
                values: new object[] { 18L, "Aut enim et voluptatum omnis beatae ratione suscipit explicabo.", new DateTime(2023, 8, 1, 21, 22, 30, 453, DateTimeKind.Utc).AddTicks(5781), 19L, "Rerum excepturi error optio.", 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 64L, "Eum mollitia assumenda.", new DateTime(2022, 3, 2, 3, 23, 3, 240, DateTimeKind.Utc).AddTicks(6773), 36L, "Alias doloribus aspernatur.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 12L, "Consequuntur vel rerum ullam unde qui est debitis aspernatur. Voluptatem nostrum quasi quidem occaecati totam labore. Reiciendis esse quas impedit sunt alias. Natus voluptatem accusamus aliquam. Sunt est voluptate enim debitis est.", new DateTime(2023, 7, 23, 2, 4, 6, 458, DateTimeKind.Utc).AddTicks(3898), 5L, "Modi modi omnis recusandae.", 1, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 43L, "Esse consequatur aut odit maiores. At dolorum laborum esse quis rerum omnis. Voluptates aliquam architecto rerum debitis perspiciatis laborum et dolor.", new DateTime(2023, 8, 27, 4, 23, 42, 991, DateTimeKind.Utc).AddTicks(3396), 25L, "Inventore qui non deserunt occaecati unde cumque facere cupiditate cupiditate.", 2, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "LanguageId", "Status" },
                values: new object[] { 32L, "Sed cupiditate sit.", new DateTime(2023, 9, 1, 19, 30, 43, 157, DateTimeKind.Utc).AddTicks(1999), 7L, "Delectus error vel voluptatem eaque praesentium et.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 10, 26, 15, 0, 18, 942, DateTimeKind.Utc).AddTicks(1212), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2018, 3, 16, 10, 26, 50, 320, DateTimeKind.Utc).AddTicks(9211), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 6, 22, 9, 15, 43, 401, DateTimeKind.Utc).AddTicks(1735), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 3, 6, 8, 46, 27, 816, DateTimeKind.Utc).AddTicks(4745), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 3, 23, 20, 1, 4, 175, DateTimeKind.Utc).AddTicks(6268), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 4, 23, 5, 4, 31, 960, DateTimeKind.Utc).AddTicks(3735), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2020, 1, 8, 1, 18, 12, 243, DateTimeKind.Utc).AddTicks(3588), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2017, 1, 15, 22, 39, 57, 828, DateTimeKind.Utc).AddTicks(6169), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2019, 12, 6, 18, 58, 32, 851, DateTimeKind.Utc).AddTicks(6878), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 6, 3, 8, 21, 39, 679, DateTimeKind.Utc).AddTicks(5045), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2018, 1, 13, 20, 12, 33, 826, DateTimeKind.Utc).AddTicks(9239), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 8, 12, 11, 43, 17, 237, DateTimeKind.Utc).AddTicks(5391), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2017, 10, 23, 8, 9, 30, 173, DateTimeKind.Utc).AddTicks(3429), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 10, 16, 4, 48, 28, 27, DateTimeKind.Utc).AddTicks(8959), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2018, 7, 14, 15, 16, 0, 977, DateTimeKind.Utc).AddTicks(3137), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 3, 20, 0, 57, 2, 658, DateTimeKind.Utc).AddTicks(8458), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 1, 19, 20, 17, 4, 977, DateTimeKind.Utc).AddTicks(2153), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2020, 4, 19, 4, 42, 29, 607, DateTimeKind.Utc).AddTicks(5803), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 7, 25, 16, 4, 15, 502, DateTimeKind.Utc).AddTicks(4302), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 4, 4, 9, 0, 52, 298, DateTimeKind.Utc).AddTicks(1892), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 11, 30, 1, 12, 38, 587, DateTimeKind.Utc).AddTicks(5382), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 9, 28, 17, 5, 52, 51, DateTimeKind.Utc).AddTicks(2069), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 8, 24, 11, 55, 34, 242, DateTimeKind.Utc).AddTicks(9694), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2021, 8, 12, 6, 44, 17, 789, DateTimeKind.Utc).AddTicks(3349), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 11, 7, 5, 28, 41, 572, DateTimeKind.Utc).AddTicks(7389), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 1, 7, 1, 30, 32, 375, DateTimeKind.Utc).AddTicks(7962), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 5, 14, 4, 25, 34, 266, DateTimeKind.Utc).AddTicks(56), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 2, 13, 23, 30, 41, 831, DateTimeKind.Utc).AddTicks(9335), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2020, 7, 27, 4, 39, 21, 919, DateTimeKind.Utc).AddTicks(6911), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2017, 7, 1, 17, 38, 40, 816, DateTimeKind.Utc).AddTicks(8241), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 1, 12, 2, 21, 6, 652, DateTimeKind.Utc).AddTicks(7485), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 8, 9, 9, 24, 57, 210, DateTimeKind.Utc).AddTicks(5258), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 9, 14, 2, 59, 12, 594, DateTimeKind.Utc).AddTicks(1370), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 9, 22, 18, 15, 24, 571, DateTimeKind.Utc).AddTicks(6492), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 5, 12, 21, 5, 57, 382, DateTimeKind.Utc).AddTicks(953), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2021, 6, 1, 23, 2, 39, 957, DateTimeKind.Utc).AddTicks(1307), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2021, 9, 28, 18, 1, 17, 149, DateTimeKind.Utc).AddTicks(4214), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 6, 20, 18, 47, 59, 353, DateTimeKind.Utc).AddTicks(6625), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 2, 14, 1, 35, 12, 389, DateTimeKind.Utc).AddTicks(7068), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 1, 16, 8, 42, 58, 437, DateTimeKind.Utc).AddTicks(3152), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2021, 12, 2, 18, 36, 14, 887, DateTimeKind.Utc).AddTicks(9094), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 2, 6, 18, 15, 16, 744, DateTimeKind.Utc).AddTicks(9317), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 8, 24, 2, 34, 28, 235, DateTimeKind.Utc).AddTicks(202), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2019, 2, 8, 7, 7, 59, 930, DateTimeKind.Utc).AddTicks(6474), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 12, 8, 1, 42, 24, 433, DateTimeKind.Utc).AddTicks(1343), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 5, 29, 12, 26, 20, 406, DateTimeKind.Utc).AddTicks(8943), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2020, 11, 8, 14, 22, 57, 213, DateTimeKind.Utc).AddTicks(3513), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 1, 5, 1, 48, 59, 763, DateTimeKind.Utc).AddTicks(8560), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 37, 57, 93, DateTimeKind.Utc).AddTicks(7827), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 3, 24, 9, 59, 52, 867, DateTimeKind.Utc).AddTicks(7128), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 8, 21, 21, 26, 28, 951, DateTimeKind.Utc).AddTicks(2436), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 1, 31, 11, 54, 39, 112, DateTimeKind.Utc).AddTicks(6772), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2019, 4, 12, 17, 11, 28, 517, DateTimeKind.Utc).AddTicks(6486), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 1, 27, 2, 1, 54, 992, DateTimeKind.Utc).AddTicks(7809), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 9, 22, 23, 11, 41, 922, DateTimeKind.Utc).AddTicks(5203), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2018, 4, 23, 0, 21, 45, 109, DateTimeKind.Utc).AddTicks(5287), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 6, 8, 2, 26, 37, 560, DateTimeKind.Utc).AddTicks(1490), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2019, 7, 20, 2, 22, 43, 953, DateTimeKind.Utc).AddTicks(715), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 1, 18, 13, 54, 19, 210, DateTimeKind.Utc).AddTicks(4556), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2019, 2, 25, 12, 26, 26, 250, DateTimeKind.Utc).AddTicks(8330), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 4, 28, 15, 55, 16, 602, DateTimeKind.Utc).AddTicks(4186), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 10, 5, 5, 25, 27, 138, DateTimeKind.Utc).AddTicks(7419), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2020, 10, 16, 18, 6, 51, 402, DateTimeKind.Utc).AddTicks(6538), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2019, 12, 21, 16, 24, 12, 743, DateTimeKind.Utc).AddTicks(6915), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2021, 5, 19, 22, 36, 32, 633, DateTimeKind.Utc).AddTicks(7479), 2 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2021, 12, 1, 1, 4, 54, 659, DateTimeKind.Utc).AddTicks(3238), 3 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 12, 8, 14, 0, 39, 45, DateTimeKind.Utc).AddTicks(5965), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2023, 1, 14, 14, 41, 17, 677, DateTimeKind.Utc).AddTicks(155), 4 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 9, 26, 17, 50, 45, 755, DateTimeKind.Utc).AddTicks(5681), 1 });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedAt", "LevelId" },
                values: new object[] { new DateTime(2022, 9, 25, 11, 49, 56, 864, DateTimeKind.Utc).AddTicks(5896), 4 });

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
                values: new object[] { new DateTime(2023, 10, 21, 19, 31, 51, 660, DateTimeKind.Utc).AddTicks(5479), new DateTime(2023, 7, 20, 4, 22, 24, 901, DateTimeKind.Utc).AddTicks(4562), new DateTime(2022, 8, 15, 12, 13, 27, 2, DateTimeKind.Utc).AddTicks(5601), 2, new DateTime(2023, 7, 22, 11, 56, 38, 499, DateTimeKind.Utc).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 18, 23, 18, 24, 967, DateTimeKind.Utc).AddTicks(8529), new DateTime(2023, 7, 31, 13, 56, 29, 843, DateTimeKind.Utc).AddTicks(4477), new DateTime(2023, 1, 23, 5, 7, 30, 213, DateTimeKind.Utc).AddTicks(4396), 1, new DateTime(2023, 2, 8, 0, 25, 53, 843, DateTimeKind.Utc).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 25, 42, 564, DateTimeKind.Utc).AddTicks(343), new DateTime(2023, 7, 29, 9, 33, 9, 797, DateTimeKind.Utc).AddTicks(9578), new DateTime(2023, 5, 11, 20, 41, 41, 685, DateTimeKind.Utc).AddTicks(2518), 2, new DateTime(2023, 7, 22, 18, 26, 37, 236, DateTimeKind.Utc).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 1, 14, 21, 23, 0, 130, DateTimeKind.Utc).AddTicks(1208), new DateTime(2022, 6, 2, 9, 19, 21, 667, DateTimeKind.Utc).AddTicks(4352), new DateTime(2021, 8, 2, 17, 55, 58, 915, DateTimeKind.Utc).AddTicks(7339), 1, new DateTime(2022, 8, 14, 1, 3, 49, 403, DateTimeKind.Utc).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 13, 10, 11, 14, 495, DateTimeKind.Utc).AddTicks(148), new DateTime(2023, 5, 8, 9, 16, 47, 687, DateTimeKind.Utc).AddTicks(8684), new DateTime(2022, 10, 31, 7, 24, 13, 886, DateTimeKind.Utc).AddTicks(8313), 1, new DateTime(2023, 8, 16, 7, 21, 32, 755, DateTimeKind.Utc).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 17, 42, 47, 265, DateTimeKind.Utc).AddTicks(6223), new DateTime(2021, 4, 12, 0, 54, 36, 19, DateTimeKind.Utc).AddTicks(1695), new DateTime(2018, 12, 17, 3, 18, 57, 728, DateTimeKind.Utc).AddTicks(9640), 3, new DateTime(2019, 12, 30, 4, 42, 5, 152, DateTimeKind.Utc).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 2, 23, 18, 15, 30, 984, DateTimeKind.Utc).AddTicks(4886), new DateTime(2023, 1, 31, 5, 41, 1, 263, DateTimeKind.Utc).AddTicks(8491), new DateTime(2020, 4, 23, 14, 32, 49, 195, DateTimeKind.Utc).AddTicks(953), 1, new DateTime(2021, 1, 24, 15, 26, 36, 204, DateTimeKind.Utc).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 22, 20, 7, DateTimeKind.Utc).AddTicks(579), new DateTime(2022, 8, 27, 7, 23, 24, 664, DateTimeKind.Utc).AddTicks(7539), new DateTime(2021, 5, 7, 16, 12, 21, 616, DateTimeKind.Utc).AddTicks(329), 3, new DateTime(2021, 7, 18, 23, 22, 19, 734, DateTimeKind.Utc).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 27, 10, 37, 59, 204, DateTimeKind.Utc).AddTicks(6325), new DateTime(2023, 5, 28, 9, 38, 16, 566, DateTimeKind.Utc).AddTicks(9319), new DateTime(2021, 6, 3, 4, 7, 25, 841, DateTimeKind.Utc).AddTicks(787), 2, new DateTime(2022, 5, 2, 23, 9, 43, 466, DateTimeKind.Utc).AddTicks(6747) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 7, 1, 11, 55, 374, DateTimeKind.Utc).AddTicks(1621), new DateTime(2022, 3, 22, 5, 37, 33, 803, DateTimeKind.Utc).AddTicks(9126), new DateTime(2021, 3, 14, 16, 1, 53, 787, DateTimeKind.Utc).AddTicks(6511), 1, new DateTime(2022, 12, 5, 22, 57, 23, 683, DateTimeKind.Utc).AddTicks(698) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 15, 10, 27, 532, DateTimeKind.Utc).AddTicks(4838), new DateTime(2023, 4, 11, 9, 14, 32, 211, DateTimeKind.Utc).AddTicks(1708), new DateTime(2023, 1, 14, 7, 3, 19, 773, DateTimeKind.Utc).AddTicks(8723), 3, new DateTime(2023, 2, 17, 19, 49, 33, 994, DateTimeKind.Utc).AddTicks(2251) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 19, 14, 44, 50, 777, DateTimeKind.Utc).AddTicks(3353), new DateTime(2022, 12, 17, 20, 2, 46, 868, DateTimeKind.Utc).AddTicks(4430), new DateTime(2022, 9, 22, 20, 10, 13, 598, DateTimeKind.Utc).AddTicks(6543), 1, new DateTime(2023, 8, 13, 16, 15, 58, 429, DateTimeKind.Utc).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 19, 21, 33, 54, 134, DateTimeKind.Utc).AddTicks(1028), new DateTime(2023, 9, 10, 23, 59, 55, 820, DateTimeKind.Utc).AddTicks(6808), new DateTime(2023, 4, 19, 18, 28, 0, 219, DateTimeKind.Utc).AddTicks(799), 1, new DateTime(2023, 9, 1, 17, 25, 23, 647, DateTimeKind.Utc).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 5, 26, 1, 17, 37, 607, DateTimeKind.Utc).AddTicks(9095), new DateTime(2020, 7, 28, 10, 25, 31, 190, DateTimeKind.Utc).AddTicks(3893), new DateTime(2019, 11, 13, 10, 47, 7, 285, DateTimeKind.Utc).AddTicks(5577), 2, new DateTime(2022, 10, 26, 11, 2, 58, 237, DateTimeKind.Utc).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 9, 4, 22, 18, 41, 633, DateTimeKind.Utc).AddTicks(7831), new DateTime(2022, 8, 15, 7, 22, 34, 463, DateTimeKind.Utc).AddTicks(7163), new DateTime(2021, 4, 2, 1, 49, 22, 797, DateTimeKind.Utc).AddTicks(6853), 1, new DateTime(2023, 7, 9, 8, 37, 40, 535, DateTimeKind.Utc).AddTicks(6427) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId" },
                values: new object[] { new DateTime(2023, 10, 11, 1, 36, 55, 691, DateTimeKind.Utc).AddTicks(1125), new DateTime(2023, 8, 21, 17, 44, 26, 312, DateTimeKind.Utc).AddTicks(7817), new DateTime(2023, 2, 19, 10, 45, 20, 969, DateTimeKind.Utc).AddTicks(2546), 3 });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 1, 25, 20, 30, 20, 870, DateTimeKind.Utc).AddTicks(6675), new DateTime(2020, 12, 5, 19, 6, 12, 104, DateTimeKind.Utc).AddTicks(3263), new DateTime(2019, 1, 19, 6, 20, 48, 510, DateTimeKind.Utc).AddTicks(2941), 3, new DateTime(2020, 8, 21, 12, 23, 46, 958, DateTimeKind.Utc).AddTicks(6695) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 23, 14, 15, 9, 702, DateTimeKind.Utc).AddTicks(9967), new DateTime(2023, 8, 3, 23, 38, 2, 240, DateTimeKind.Utc).AddTicks(3676), new DateTime(2020, 12, 26, 3, 27, 52, 850, DateTimeKind.Utc).AddTicks(5889), 3, new DateTime(2021, 12, 2, 11, 7, 16, 165, DateTimeKind.Utc).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 7, 4, 52, 45, 431, DateTimeKind.Utc).AddTicks(9111), new DateTime(2023, 7, 6, 6, 17, 47, 847, DateTimeKind.Utc).AddTicks(2874), new DateTime(2023, 6, 25, 13, 42, 19, 841, DateTimeKind.Utc).AddTicks(7995), 2, new DateTime(2023, 7, 22, 0, 20, 45, 214, DateTimeKind.Utc).AddTicks(6215) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 3, 26, 21, 9, 44, 489, DateTimeKind.Utc).AddTicks(8338), new DateTime(2020, 2, 27, 11, 7, 19, 0, DateTimeKind.Utc).AddTicks(5773), new DateTime(2019, 11, 27, 12, 13, 4, 205, DateTimeKind.Utc).AddTicks(4457), 1, new DateTime(2022, 3, 12, 3, 47, 50, 793, DateTimeKind.Utc).AddTicks(1463) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 7, 8, 50, 11, 268, DateTimeKind.Utc).AddTicks(3568), new DateTime(2023, 5, 31, 11, 3, 7, 270, DateTimeKind.Utc).AddTicks(6022), new DateTime(2022, 3, 4, 9, 4, 48, 61, DateTimeKind.Utc).AddTicks(7062), 1, new DateTime(2023, 6, 17, 13, 5, 30, 364, DateTimeKind.Utc).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 56, 2, 857, DateTimeKind.Utc).AddTicks(9885), new DateTime(2023, 5, 4, 1, 39, 2, 191, DateTimeKind.Utc).AddTicks(4478), new DateTime(2019, 12, 15, 13, 34, 1, 53, DateTimeKind.Utc).AddTicks(1314), 1, new DateTime(2022, 5, 14, 22, 49, 56, 700, DateTimeKind.Utc).AddTicks(128) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 3, 27, 2, 42, 15, 128, DateTimeKind.Utc).AddTicks(910), new DateTime(2020, 3, 21, 16, 18, 53, 194, DateTimeKind.Utc).AddTicks(3514), new DateTime(2017, 7, 19, 20, 58, 0, 639, DateTimeKind.Utc).AddTicks(524), 1, new DateTime(2023, 9, 1, 0, 14, 25, 969, DateTimeKind.Utc).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 5, 23, 23, 42, 23, 929, DateTimeKind.Utc).AddTicks(9846), new DateTime(2019, 8, 2, 12, 13, 8, 941, DateTimeKind.Utc).AddTicks(402), new DateTime(2019, 3, 31, 11, 36, 39, 327, DateTimeKind.Utc).AddTicks(4250), 1, new DateTime(2020, 9, 19, 4, 47, 43, 249, DateTimeKind.Utc).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 6, 59, 14, 262, DateTimeKind.Utc).AddTicks(6084), new DateTime(2023, 4, 5, 5, 36, 29, 657, DateTimeKind.Utc).AddTicks(1868), new DateTime(2021, 4, 12, 16, 47, 30, 461, DateTimeKind.Utc).AddTicks(7243), 2, new DateTime(2022, 4, 10, 1, 1, 48, 129, DateTimeKind.Utc).AddTicks(8357) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 26, 7, 56, 56, 979, DateTimeKind.Utc).AddTicks(4939), new DateTime(2023, 5, 16, 3, 48, 57, 998, DateTimeKind.Utc).AddTicks(710), new DateTime(2023, 2, 13, 14, 58, 15, 322, DateTimeKind.Utc).AddTicks(2571), 2, new DateTime(2023, 4, 3, 16, 37, 17, 776, DateTimeKind.Utc).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId" },
                values: new object[] { new DateTime(2023, 2, 21, 21, 18, 28, 202, DateTimeKind.Utc).AddTicks(996), new DateTime(2022, 12, 26, 7, 30, 43, 447, DateTimeKind.Utc).AddTicks(793), new DateTime(2022, 7, 5, 10, 12, 36, 336, DateTimeKind.Utc).AddTicks(7198), 2 });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 0, 5, 56, 886, DateTimeKind.Utc).AddTicks(2174), new DateTime(2023, 5, 27, 18, 13, 25, 546, DateTimeKind.Utc).AddTicks(552), new DateTime(2023, 3, 26, 18, 15, 59, 754, DateTimeKind.Utc).AddTicks(4849), 1, new DateTime(2023, 8, 14, 1, 50, 28, 134, DateTimeKind.Utc).AddTicks(6293) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 23, 4, 42, 28, 128, DateTimeKind.Utc).AddTicks(6068), new DateTime(2023, 4, 4, 17, 27, 13, 548, DateTimeKind.Utc).AddTicks(7032), new DateTime(2023, 2, 25, 23, 51, 32, 649, DateTimeKind.Utc).AddTicks(9167), 2, new DateTime(2023, 7, 16, 7, 28, 6, 737, DateTimeKind.Utc).AddTicks(7907) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 3, 25, 414, DateTimeKind.Utc).AddTicks(9760), new DateTime(2023, 7, 21, 11, 45, 20, 616, DateTimeKind.Utc).AddTicks(600), new DateTime(2021, 8, 5, 23, 50, 30, 701, DateTimeKind.Utc).AddTicks(1456), 3, new DateTime(2022, 6, 24, 7, 40, 22, 941, DateTimeKind.Utc).AddTicks(9761) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 8, 9, 7, 17, 42, 117, DateTimeKind.Utc).AddTicks(4825), new DateTime(2023, 8, 21, 12, 29, 25, 743, DateTimeKind.Utc).AddTicks(9838), new DateTime(2023, 8, 17, 11, 50, 1, 178, DateTimeKind.Utc).AddTicks(1427), 2, new DateTime(2023, 8, 30, 3, 14, 55, 342, DateTimeKind.Utc).AddTicks(704) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 11, 15, 10, 46, 242, DateTimeKind.Utc).AddTicks(4923), new DateTime(2022, 4, 2, 17, 33, 5, 750, DateTimeKind.Utc).AddTicks(6334), new DateTime(2022, 2, 10, 0, 19, 32, 923, DateTimeKind.Utc).AddTicks(8571), 3, new DateTime(2023, 7, 2, 22, 14, 4, 49, DateTimeKind.Utc).AddTicks(1002) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 9, 3, 6, 45, 51, 735, DateTimeKind.Utc).AddTicks(3988), new DateTime(2022, 6, 24, 1, 17, 59, 960, DateTimeKind.Utc).AddTicks(6581), new DateTime(2019, 6, 15, 9, 46, 13, 500, DateTimeKind.Utc).AddTicks(8348), 2, new DateTime(2019, 8, 24, 9, 9, 13, 697, DateTimeKind.Utc).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 19, 18, 15, 4, 141, DateTimeKind.Utc).AddTicks(3444), new DateTime(2023, 9, 2, 21, 31, 26, 705, DateTimeKind.Utc).AddTicks(8052), new DateTime(2022, 8, 18, 16, 22, 38, 776, DateTimeKind.Utc).AddTicks(2532), 3, new DateTime(2022, 9, 16, 9, 1, 43, 297, DateTimeKind.Utc).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2019, 12, 2, 20, 25, 40, 187, DateTimeKind.Utc).AddTicks(3125), new DateTime(2019, 10, 28, 9, 54, 45, 582, DateTimeKind.Utc).AddTicks(4412), new DateTime(2018, 8, 4, 7, 31, 50, 90, DateTimeKind.Utc).AddTicks(9515), 2, new DateTime(2021, 3, 20, 2, 33, 24, 158, DateTimeKind.Utc).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 12, 18, 16, 41, 13, 54, DateTimeKind.Utc).AddTicks(5746), new DateTime(2021, 11, 24, 0, 21, 30, 4, DateTimeKind.Utc).AddTicks(9727), new DateTime(2021, 4, 10, 4, 21, 31, 988, DateTimeKind.Utc).AddTicks(8733), 3, new DateTime(2021, 12, 8, 11, 50, 25, 415, DateTimeKind.Utc).AddTicks(8554) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 22, 39, 47, 414, DateTimeKind.Utc).AddTicks(3797), new DateTime(2023, 4, 7, 11, 37, 9, 10, DateTimeKind.Utc).AddTicks(7008), new DateTime(2022, 7, 10, 1, 26, 20, 38, DateTimeKind.Utc).AddTicks(5398), 1, new DateTime(2023, 4, 20, 5, 27, 58, 902, DateTimeKind.Utc).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 12, 38, 22, 163, DateTimeKind.Utc).AddTicks(8548), new DateTime(2023, 8, 19, 0, 25, 39, 491, DateTimeKind.Utc).AddTicks(2059), new DateTime(2023, 6, 28, 1, 28, 46, 699, DateTimeKind.Utc).AddTicks(9267), 2, new DateTime(2023, 8, 24, 19, 44, 53, 625, DateTimeKind.Utc).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId" },
                values: new object[] { new DateTime(2024, 2, 25, 15, 35, 38, 577, DateTimeKind.Utc).AddTicks(9939), new DateTime(2023, 6, 29, 9, 27, 59, 929, DateTimeKind.Utc).AddTicks(7773), new DateTime(2023, 5, 24, 9, 48, 49, 406, DateTimeKind.Utc).AddTicks(9928), 3 });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 0, 29, 35, 895, DateTimeKind.Utc).AddTicks(7888), new DateTime(2022, 7, 10, 14, 41, 34, 463, DateTimeKind.Utc).AddTicks(7651), new DateTime(2020, 12, 18, 13, 3, 10, 709, DateTimeKind.Utc).AddTicks(4387), 3, new DateTime(2022, 8, 8, 14, 35, 40, 327, DateTimeKind.Utc).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 19, 6, 20, 793, DateTimeKind.Utc).AddTicks(6864), new DateTime(2020, 1, 26, 4, 17, 42, 796, DateTimeKind.Utc).AddTicks(3595), new DateTime(2019, 11, 29, 18, 36, 23, 868, DateTimeKind.Utc).AddTicks(1282), 1, new DateTime(2023, 6, 13, 11, 48, 38, 294, DateTimeKind.Utc).AddTicks(1272) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 14, 47, 4, 606, DateTimeKind.Utc).AddTicks(3099), new DateTime(2023, 7, 17, 2, 13, 43, 207, DateTimeKind.Utc).AddTicks(7299), new DateTime(2020, 6, 7, 9, 13, 18, 470, DateTimeKind.Utc).AddTicks(6622), 1, new DateTime(2020, 11, 3, 23, 1, 54, 387, DateTimeKind.Utc).AddTicks(7981) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 26, 11, 3, 1, 20, DateTimeKind.Utc).AddTicks(7795), new DateTime(2023, 8, 21, 13, 38, 13, 181, DateTimeKind.Utc).AddTicks(165), new DateTime(2023, 8, 7, 5, 48, 31, 469, DateTimeKind.Utc).AddTicks(9029), 2, new DateTime(2023, 9, 5, 15, 35, 46, 793, DateTimeKind.Utc).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 1, 57, 30, 293, DateTimeKind.Utc).AddTicks(2890), new DateTime(2023, 8, 16, 20, 1, 3, 127, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 7, 2, 16, 6, 0, 13, DateTimeKind.Utc).AddTicks(8887), 3, new DateTime(2023, 7, 27, 12, 37, 10, 881, DateTimeKind.Utc).AddTicks(4851) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 9, 0, 13, 994, DateTimeKind.Utc).AddTicks(7218), new DateTime(2023, 4, 25, 21, 10, 31, 708, DateTimeKind.Utc).AddTicks(1891), new DateTime(2022, 9, 17, 10, 48, 11, 961, DateTimeKind.Utc).AddTicks(9818), 2, new DateTime(2023, 3, 22, 9, 40, 52, 583, DateTimeKind.Utc).AddTicks(1929) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 19, 6, 59, 1, 698, DateTimeKind.Utc).AddTicks(6066), new DateTime(2022, 2, 15, 0, 52, 47, 716, DateTimeKind.Utc).AddTicks(1549), new DateTime(2020, 6, 14, 11, 9, 4, 588, DateTimeKind.Utc).AddTicks(3298), 1, new DateTime(2021, 11, 23, 13, 57, 55, 972, DateTimeKind.Utc).AddTicks(7419) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 22, 16, 3, 50, 75, DateTimeKind.Utc).AddTicks(1800), new DateTime(2023, 8, 30, 4, 13, 54, 107, DateTimeKind.Utc).AddTicks(8525), new DateTime(2023, 4, 16, 15, 30, 16, 103, DateTimeKind.Utc).AddTicks(8168), 1, new DateTime(2023, 8, 12, 18, 33, 50, 469, DateTimeKind.Utc).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 7, 4, 10, 56, 48, 964, DateTimeKind.Utc).AddTicks(8566), new DateTime(2021, 12, 13, 10, 34, 23, 204, DateTimeKind.Utc).AddTicks(3421), new DateTime(2020, 1, 4, 21, 50, 12, 569, DateTimeKind.Utc).AddTicks(5069), 2, new DateTime(2021, 2, 23, 3, 14, 43, 570, DateTimeKind.Utc).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 6, 21, 1, 6, 46, 819, DateTimeKind.Utc).AddTicks(8847), new DateTime(2023, 8, 30, 4, 7, 39, 178, DateTimeKind.Utc).AddTicks(7287), new DateTime(2023, 4, 4, 21, 54, 20, 497, DateTimeKind.Utc).AddTicks(3090), 1, new DateTime(2023, 8, 26, 15, 10, 38, 379, DateTimeKind.Utc).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId" },
                values: new object[] { new DateTime(2021, 8, 14, 2, 18, 54, 321, DateTimeKind.Utc).AddTicks(5734), new DateTime(2021, 7, 1, 3, 14, 58, 485, DateTimeKind.Utc).AddTicks(9065), new DateTime(2020, 3, 6, 13, 35, 54, 278, DateTimeKind.Utc).AddTicks(544), 2 });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 4, 29, 13, 20, 2, 351, DateTimeKind.Utc).AddTicks(5570), new DateTime(2021, 5, 13, 6, 53, 27, 42, DateTimeKind.Utc).AddTicks(7178), new DateTime(2019, 10, 31, 0, 54, 23, 918, DateTimeKind.Utc).AddTicks(6355), 1, new DateTime(2023, 2, 17, 4, 0, 1, 274, DateTimeKind.Utc).AddTicks(8529) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 40, 31, 297, DateTimeKind.Utc).AddTicks(9802), new DateTime(2023, 8, 8, 1, 27, 35, 516, DateTimeKind.Utc).AddTicks(9567), new DateTime(2023, 7, 7, 1, 31, 53, 710, DateTimeKind.Utc).AddTicks(2637), 3, new DateTime(2023, 8, 2, 10, 9, 16, 243, DateTimeKind.Utc).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 11, 13, 18, 52, 196, DateTimeKind.Utc).AddTicks(4307), new DateTime(2023, 8, 6, 5, 59, 58, 693, DateTimeKind.Utc).AddTicks(8695), new DateTime(2022, 3, 24, 20, 48, 6, 610, DateTimeKind.Utc).AddTicks(3943), 1, new DateTime(2022, 4, 13, 3, 9, 17, 436, DateTimeKind.Utc).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 3, 26, 11, 6, 26, 403, DateTimeKind.Utc).AddTicks(5552), new DateTime(2022, 9, 10, 22, 58, 28, 877, DateTimeKind.Utc).AddTicks(7001), new DateTime(2021, 10, 21, 5, 43, 18, 626, DateTimeKind.Utc).AddTicks(9901), 1, new DateTime(2022, 4, 13, 11, 0, 33, 324, DateTimeKind.Utc).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 1, 20, 0, 46, 21, 861, DateTimeKind.Utc).AddTicks(2051), new DateTime(2022, 9, 23, 0, 13, 42, 944, DateTimeKind.Utc).AddTicks(3702), new DateTime(2022, 8, 8, 3, 11, 25, 341, DateTimeKind.Utc).AddTicks(2332), 3, new DateTime(2023, 8, 4, 18, 16, 19, 215, DateTimeKind.Utc).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 5, 4, 50, 5, 119, DateTimeKind.Utc).AddTicks(7988), new DateTime(2023, 9, 10, 18, 6, 32, 878, DateTimeKind.Utc).AddTicks(5216), new DateTime(2023, 7, 8, 18, 52, 31, 634, DateTimeKind.Utc).AddTicks(7544), 1, new DateTime(2023, 7, 16, 6, 22, 27, 434, DateTimeKind.Utc).AddTicks(1674) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 10, 18, 165, DateTimeKind.Utc).AddTicks(9728), new DateTime(2022, 9, 18, 21, 40, 6, 319, DateTimeKind.Utc).AddTicks(2532), new DateTime(2022, 6, 9, 14, 1, 17, 698, DateTimeKind.Utc).AddTicks(3000), 1, new DateTime(2022, 12, 12, 14, 6, 48, 502, DateTimeKind.Utc).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 30, 7, 58, 33, 117, DateTimeKind.Utc).AddTicks(3816), new DateTime(2023, 3, 14, 3, 24, 25, 274, DateTimeKind.Utc).AddTicks(3006), new DateTime(2023, 2, 18, 10, 30, 32, 233, DateTimeKind.Utc).AddTicks(3467), 3, new DateTime(2023, 5, 4, 21, 51, 42, 138, DateTimeKind.Utc).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 11, 6, 42, 46, 574, DateTimeKind.Utc).AddTicks(345), new DateTime(2022, 12, 1, 22, 11, 30, 551, DateTimeKind.Utc).AddTicks(302), new DateTime(2017, 4, 19, 8, 0, 13, 490, DateTimeKind.Utc).AddTicks(3391), 2, new DateTime(2023, 7, 15, 8, 15, 48, 362, DateTimeKind.Utc).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 22, 22, 28, 8, 223, DateTimeKind.Utc).AddTicks(6882), new DateTime(2023, 1, 15, 8, 16, 17, 35, DateTimeKind.Utc).AddTicks(7966), new DateTime(2022, 11, 1, 4, 10, 46, 315, DateTimeKind.Utc).AddTicks(7946), 1, new DateTime(2023, 3, 15, 0, 51, 10, 516, DateTimeKind.Utc).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 3, 20, 18, 2, 825, DateTimeKind.Utc).AddTicks(1453), new DateTime(2022, 8, 22, 15, 1, 8, 952, DateTimeKind.Utc).AddTicks(7306), new DateTime(2021, 10, 11, 8, 42, 49, 463, DateTimeKind.Utc).AddTicks(3331), 1, new DateTime(2023, 4, 4, 12, 42, 44, 715, DateTimeKind.Utc).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 9, 8, 57, 56, 24, DateTimeKind.Utc).AddTicks(9312), new DateTime(2023, 3, 30, 9, 57, 48, 502, DateTimeKind.Utc).AddTicks(9727), new DateTime(2019, 11, 4, 19, 49, 11, 160, DateTimeKind.Utc).AddTicks(5989), 2, new DateTime(2020, 8, 26, 19, 56, 22, 532, DateTimeKind.Utc).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 12, 6, 21, 51, 682, DateTimeKind.Utc).AddTicks(7359), new DateTime(2023, 5, 15, 15, 58, 58, 794, DateTimeKind.Utc).AddTicks(9931), new DateTime(2022, 3, 2, 12, 27, 10, 518, DateTimeKind.Utc).AddTicks(2902), 1, new DateTime(2022, 7, 13, 17, 57, 17, 515, DateTimeKind.Utc).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 27, 9, 26, 47, 575, DateTimeKind.Utc).AddTicks(1772), new DateTime(2022, 10, 28, 14, 55, 19, 439, DateTimeKind.Utc).AddTicks(5818), new DateTime(2022, 6, 2, 8, 40, 58, 543, DateTimeKind.Utc).AddTicks(4980), 2, new DateTime(2023, 4, 11, 17, 21, 16, 81, DateTimeKind.Utc).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 6, 7, 16, 17, 37, 139, DateTimeKind.Utc).AddTicks(9287), new DateTime(2021, 8, 10, 1, 12, 8, 402, DateTimeKind.Utc).AddTicks(2779), new DateTime(2021, 6, 23, 9, 6, 12, 548, DateTimeKind.Utc).AddTicks(2642), 2, new DateTime(2022, 4, 5, 22, 41, 23, 915, DateTimeKind.Utc).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 10, 19, 8, 51, 676, DateTimeKind.Utc).AddTicks(5011), new DateTime(2023, 9, 3, 18, 1, 52, 801, DateTimeKind.Utc).AddTicks(2952), new DateTime(2019, 3, 25, 14, 49, 51, 380, DateTimeKind.Utc).AddTicks(2518), 1, new DateTime(2020, 11, 15, 17, 24, 12, 54, DateTimeKind.Utc).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 3, 6, 44, 48, 773, DateTimeKind.Utc).AddTicks(3127), new DateTime(2022, 10, 25, 4, 26, 3, 188, DateTimeKind.Utc).AddTicks(3324), new DateTime(2022, 6, 16, 3, 1, 6, 177, DateTimeKind.Utc).AddTicks(5577), 3, new DateTime(2022, 12, 21, 11, 52, 14, 175, DateTimeKind.Utc).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2018, 4, 5, 7, 48, 19, 762, DateTimeKind.Utc).AddTicks(3105), new DateTime(2018, 3, 19, 6, 3, 22, 240, DateTimeKind.Utc).AddTicks(1993), new DateTime(2017, 9, 19, 20, 18, 8, 680, DateTimeKind.Utc).AddTicks(6423), 3, new DateTime(2019, 7, 11, 17, 52, 21, 60, DateTimeKind.Utc).AddTicks(6271) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 8, 1, 22, 5, 57, 305, DateTimeKind.Utc).AddTicks(3295), new DateTime(2023, 8, 6, 9, 19, 29, 322, DateTimeKind.Utc).AddTicks(8040), new DateTime(2023, 7, 5, 3, 54, 11, 669, DateTimeKind.Utc).AddTicks(5068), 1, new DateTime(2023, 7, 10, 21, 26, 27, 861, DateTimeKind.Utc).AddTicks(6226) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 23, 10, 27, 890, DateTimeKind.Utc).AddTicks(4990), new DateTime(2023, 1, 23, 1, 26, 39, 653, DateTimeKind.Utc).AddTicks(1793), new DateTime(2021, 7, 6, 6, 58, 44, 409, DateTimeKind.Utc).AddTicks(6614), 2, new DateTime(2022, 11, 3, 6, 10, 15, 84, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 3, 21, 13, 10, 32, 405, DateTimeKind.Utc).AddTicks(1439), new DateTime(2022, 2, 25, 10, 36, 14, 645, DateTimeKind.Utc).AddTicks(3763), new DateTime(2021, 10, 31, 0, 40, 23, 441, DateTimeKind.Utc).AddTicks(3807), 1, new DateTime(2023, 2, 6, 17, 55, 1, 493, DateTimeKind.Utc).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 10, 21, 47, 974, DateTimeKind.Utc).AddTicks(8861), new DateTime(2023, 4, 28, 2, 7, 40, 405, DateTimeKind.Utc).AddTicks(8090), new DateTime(2022, 10, 12, 20, 34, 26, 325, DateTimeKind.Utc).AddTicks(5829), 2, new DateTime(2023, 8, 25, 2, 18, 5, 310, DateTimeKind.Utc).AddTicks(1310) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 59, 57, 585, DateTimeKind.Utc).AddTicks(4548), new DateTime(2023, 8, 17, 3, 47, 56, 588, DateTimeKind.Utc).AddTicks(593), new DateTime(2022, 3, 11, 3, 51, 33, 160, DateTimeKind.Utc).AddTicks(5426), 1, new DateTime(2022, 8, 25, 11, 15, 12, 63, DateTimeKind.Utc).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 2, 56, 0, 543, DateTimeKind.Utc).AddTicks(7868), new DateTime(2023, 6, 25, 15, 46, 4, 328, DateTimeKind.Utc).AddTicks(6422), new DateTime(2021, 7, 8, 5, 58, 13, 339, DateTimeKind.Utc).AddTicks(3772), 1, new DateTime(2021, 12, 12, 1, 45, 57, 351, DateTimeKind.Utc).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 4, 4, 59, 4, 989, DateTimeKind.Utc).AddTicks(9680), new DateTime(2023, 8, 17, 13, 55, 31, 817, DateTimeKind.Utc).AddTicks(2507), new DateTime(2023, 7, 4, 15, 30, 45, 597, DateTimeKind.Utc).AddTicks(6430), 3, new DateTime(2023, 9, 5, 10, 9, 27, 99, DateTimeKind.Utc).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 8, 10, 3, 14, 447, DateTimeKind.Utc).AddTicks(9265), new DateTime(2023, 5, 13, 7, 30, 56, 521, DateTimeKind.Utc).AddTicks(3854), new DateTime(2023, 3, 23, 9, 23, 18, 965, DateTimeKind.Utc).AddTicks(3757), 2, new DateTime(2023, 3, 29, 0, 5, 30, 876, DateTimeKind.Utc).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 19, 3, 28, 3, 780, DateTimeKind.Utc).AddTicks(303), new DateTime(2022, 12, 31, 20, 45, 37, 197, DateTimeKind.Utc).AddTicks(8150), new DateTime(2022, 2, 21, 2, 7, 22, 997, DateTimeKind.Utc).AddTicks(9134), 2, new DateTime(2022, 7, 18, 9, 26, 5, 924, DateTimeKind.Utc).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId" },
                values: new object[] { new DateTime(2023, 7, 3, 18, 36, 31, 824, DateTimeKind.Utc).AddTicks(328), new DateTime(2023, 6, 4, 7, 28, 6, 291, DateTimeKind.Utc).AddTicks(5989), new DateTime(2022, 1, 8, 22, 3, 7, 659, DateTimeKind.Utc).AddTicks(748), 1 });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 4, 14, 25, 59, 832, DateTimeKind.Utc).AddTicks(6742), new DateTime(2022, 12, 29, 15, 28, 24, 839, DateTimeKind.Utc).AddTicks(8020), new DateTime(2022, 11, 10, 11, 31, 8, 730, DateTimeKind.Utc).AddTicks(2569), 1, new DateTime(2023, 9, 4, 3, 18, 55, 933, DateTimeKind.Utc).AddTicks(5422) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 19, 55, 9, 159, DateTimeKind.Utc).AddTicks(7229), new DateTime(2018, 11, 23, 11, 24, 35, 739, DateTimeKind.Utc).AddTicks(3441), new DateTime(2017, 4, 11, 18, 9, 47, 657, DateTimeKind.Utc).AddTicks(2728), 3, new DateTime(2017, 12, 27, 14, 54, 0, 654, DateTimeKind.Utc).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 6, 19, 43, 5, 36, DateTimeKind.Utc).AddTicks(4460), new DateTime(2022, 9, 27, 15, 11, 20, 341, DateTimeKind.Utc).AddTicks(5728), new DateTime(2021, 11, 1, 1, 12, 8, 223, DateTimeKind.Utc).AddTicks(1478), 1, new DateTime(2022, 8, 6, 5, 32, 8, 579, DateTimeKind.Utc).AddTicks(6689) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 12, 11, 50, 32, 325, DateTimeKind.Utc).AddTicks(3851), new DateTime(2023, 9, 8, 13, 10, 22, 540, DateTimeKind.Utc).AddTicks(3223), new DateTime(2023, 9, 6, 13, 39, 3, 996, DateTimeKind.Utc).AddTicks(9309), 2, new DateTime(2023, 9, 8, 17, 41, 13, 430, DateTimeKind.Utc).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 10, 22, 23, 56, 45, 117, DateTimeKind.Utc).AddTicks(5448), new DateTime(2021, 11, 24, 4, 49, 28, 770, DateTimeKind.Utc).AddTicks(6674), new DateTime(2018, 4, 20, 17, 26, 58, 429, DateTimeKind.Utc).AddTicks(8384), 3, new DateTime(2019, 7, 12, 9, 22, 33, 654, DateTimeKind.Utc).AddTicks(2086) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 3, 25, 6, 235, DateTimeKind.Utc).AddTicks(2906), new DateTime(2023, 9, 8, 8, 34, 12, 749, DateTimeKind.Utc).AddTicks(653), new DateTime(2023, 8, 31, 19, 8, 59, 704, DateTimeKind.Utc).AddTicks(4718), 1, new DateTime(2023, 9, 4, 14, 54, 38, 644, DateTimeKind.Utc).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 6, 7, 2, 45, 3, 203, DateTimeKind.Utc).AddTicks(1759), new DateTime(2023, 4, 9, 10, 43, 39, 297, DateTimeKind.Utc).AddTicks(7234), new DateTime(2016, 11, 13, 17, 38, 10, 313, DateTimeKind.Utc).AddTicks(7668), 1, new DateTime(2020, 9, 27, 16, 58, 33, 420, DateTimeKind.Utc).AddTicks(2683) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 11, 5, 11, 26, 536, DateTimeKind.Utc).AddTicks(291), new DateTime(2023, 4, 7, 7, 35, 20, 306, DateTimeKind.Utc).AddTicks(7448), new DateTime(2022, 9, 3, 17, 38, 48, 986, DateTimeKind.Utc).AddTicks(3383), 1, new DateTime(2023, 8, 20, 4, 34, 20, 582, DateTimeKind.Utc).AddTicks(6657) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 6, 47, 535, DateTimeKind.Utc).AddTicks(8514), new DateTime(2023, 4, 10, 6, 0, 3, 605, DateTimeKind.Utc).AddTicks(4883), new DateTime(2023, 4, 5, 2, 51, 23, 152, DateTimeKind.Utc).AddTicks(9939), 3, new DateTime(2023, 8, 6, 15, 46, 54, 643, DateTimeKind.Utc).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 2, 11, 16, 53, 39, 603, DateTimeKind.Utc).AddTicks(5183), new DateTime(2021, 1, 28, 23, 51, 23, 854, DateTimeKind.Utc).AddTicks(9469), new DateTime(2019, 6, 24, 6, 14, 3, 579, DateTimeKind.Utc).AddTicks(2058), 3, new DateTime(2022, 10, 3, 18, 1, 48, 433, DateTimeKind.Utc).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 22, 2, 55, 12, 744, DateTimeKind.Utc).AddTicks(7080), new DateTime(2023, 5, 7, 21, 15, 45, 289, DateTimeKind.Utc).AddTicks(5319), new DateTime(2022, 9, 26, 17, 8, 24, 658, DateTimeKind.Utc).AddTicks(9183), 3, new DateTime(2023, 1, 13, 10, 28, 1, 172, DateTimeKind.Utc).AddTicks(6921) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 46, 58, 512, DateTimeKind.Utc).AddTicks(3555), new DateTime(2023, 6, 3, 12, 58, 5, 357, DateTimeKind.Utc).AddTicks(9978), new DateTime(2019, 4, 6, 9, 3, 25, 947, DateTimeKind.Utc).AddTicks(5755), 1 });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 9, 26, 2, 1, 38, 397, DateTimeKind.Utc).AddTicks(6153), new DateTime(2021, 9, 29, 19, 11, 16, 452, DateTimeKind.Utc).AddTicks(5788), new DateTime(2021, 4, 4, 3, 8, 9, 273, DateTimeKind.Utc).AddTicks(8062), 1, new DateTime(2023, 6, 3, 12, 39, 51, 563, DateTimeKind.Utc).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 22, 9, 9, 789, DateTimeKind.Utc).AddTicks(7540), new DateTime(2023, 7, 31, 22, 16, 59, 11, DateTimeKind.Utc).AddTicks(7112), new DateTime(2023, 7, 19, 16, 12, 50, 165, DateTimeKind.Utc).AddTicks(1387), 1, new DateTime(2023, 8, 17, 23, 17, 4, 262, DateTimeKind.Utc).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 28, 23, 53, 30, 93, DateTimeKind.Utc).AddTicks(9674), new DateTime(2023, 6, 10, 10, 54, 46, 514, DateTimeKind.Utc).AddTicks(6268), new DateTime(2023, 1, 17, 6, 2, 50, 73, DateTimeKind.Utc).AddTicks(2263), 1, new DateTime(2023, 3, 23, 4, 23, 17, 826, DateTimeKind.Utc).AddTicks(426) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 21, 5, 4, 55, 630, DateTimeKind.Utc).AddTicks(918), new DateTime(2023, 2, 3, 14, 26, 13, 37, DateTimeKind.Utc).AddTicks(593), new DateTime(2022, 5, 27, 19, 12, 43, 94, DateTimeKind.Utc).AddTicks(1748), 3, new DateTime(2023, 3, 4, 21, 27, 54, 348, DateTimeKind.Utc).AddTicks(6621) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 5, 18, 8, 51, 37, 453, DateTimeKind.Utc).AddTicks(8669), new DateTime(2020, 6, 24, 23, 23, 55, 671, DateTimeKind.Utc).AddTicks(7562), new DateTime(2017, 10, 11, 21, 8, 0, 237, DateTimeKind.Utc).AddTicks(9653), 1, new DateTime(2018, 6, 1, 4, 10, 17, 679, DateTimeKind.Utc).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 3, 11, 49, 1, 983, DateTimeKind.Utc).AddTicks(4608), new DateTime(2023, 7, 23, 4, 13, 11, 964, DateTimeKind.Utc).AddTicks(9885), new DateTime(2021, 5, 19, 2, 2, 4, 75, DateTimeKind.Utc).AddTicks(8850), 3, new DateTime(2021, 10, 11, 4, 37, 36, 775, DateTimeKind.Utc).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 20, 4, 15, 25, 897, DateTimeKind.Utc).AddTicks(6893), new DateTime(2023, 2, 25, 14, 56, 42, 645, DateTimeKind.Utc).AddTicks(9979), new DateTime(2022, 12, 17, 0, 47, 8, 252, DateTimeKind.Utc).AddTicks(7860), 1, new DateTime(2023, 2, 10, 9, 38, 59, 452, DateTimeKind.Utc).AddTicks(7761) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 7, 16, 35, 48, 166, DateTimeKind.Utc).AddTicks(3070), new DateTime(2023, 8, 1, 12, 52, 36, 301, DateTimeKind.Utc).AddTicks(995), new DateTime(2022, 12, 30, 17, 44, 51, 922, DateTimeKind.Utc).AddTicks(8723), 1, new DateTime(2023, 8, 6, 14, 31, 25, 514, DateTimeKind.Utc).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 8, 26, 4, 4, 30, 639, DateTimeKind.Utc).AddTicks(9617), new DateTime(2022, 5, 24, 7, 0, 57, 257, DateTimeKind.Utc).AddTicks(5795), new DateTime(2021, 7, 5, 17, 13, 6, 458, DateTimeKind.Utc).AddTicks(7605), 1, new DateTime(2022, 1, 27, 12, 23, 10, 374, DateTimeKind.Utc).AddTicks(5021) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 20, 30, 51, 702, DateTimeKind.Utc).AddTicks(9503), new DateTime(2023, 9, 1, 2, 2, 21, 82, DateTimeKind.Utc).AddTicks(9079), new DateTime(2023, 6, 14, 17, 42, 54, 637, DateTimeKind.Utc).AddTicks(4388), 2, new DateTime(2023, 7, 28, 22, 58, 19, 568, DateTimeKind.Utc).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 28, 6, 37, 45, 693, DateTimeKind.Utc).AddTicks(7481), new DateTime(2023, 8, 29, 18, 37, 24, 979, DateTimeKind.Utc).AddTicks(143), new DateTime(2023, 8, 10, 23, 0, 23, 32, DateTimeKind.Utc).AddTicks(2055), 1, new DateTime(2023, 8, 26, 0, 58, 42, 446, DateTimeKind.Utc).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 4, 3, 17, 16, 11, 661, DateTimeKind.Utc).AddTicks(3625), new DateTime(2020, 12, 12, 18, 20, 26, 61, DateTimeKind.Utc).AddTicks(573), new DateTime(2019, 10, 9, 17, 26, 26, 253, DateTimeKind.Utc).AddTicks(2121), 2, new DateTime(2023, 7, 30, 10, 50, 30, 287, DateTimeKind.Utc).AddTicks(8106) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 18, 31, 36, 545, DateTimeKind.Utc).AddTicks(9849), new DateTime(2023, 4, 19, 12, 31, 36, 755, DateTimeKind.Utc).AddTicks(262), new DateTime(2022, 11, 16, 14, 32, 51, 384, DateTimeKind.Utc).AddTicks(480), 3, new DateTime(2023, 1, 19, 17, 29, 31, 853, DateTimeKind.Utc).AddTicks(881) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 51, 19, 967, DateTimeKind.Utc).AddTicks(2034), new DateTime(2022, 9, 3, 7, 0, 40, 710, DateTimeKind.Utc).AddTicks(9318), new DateTime(2022, 8, 22, 8, 50, 22, 843, DateTimeKind.Utc).AddTicks(7610), 1, new DateTime(2023, 1, 28, 11, 35, 34, 906, DateTimeKind.Utc).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 10, 24, 20, 53, 8, 293, DateTimeKind.Utc).AddTicks(8375), new DateTime(2019, 11, 16, 1, 24, 37, 399, DateTimeKind.Utc).AddTicks(7790), new DateTime(2017, 6, 28, 8, 4, 26, 71, DateTimeKind.Utc).AddTicks(1612), 2, new DateTime(2018, 8, 8, 15, 31, 29, 477, DateTimeKind.Utc).AddTicks(2293) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 29, 2, 25, 32, 728, DateTimeKind.Utc).AddTicks(9173), new DateTime(2023, 7, 25, 14, 6, 36, 742, DateTimeKind.Utc).AddTicks(9843), new DateTime(2023, 6, 30, 23, 23, 8, 915, DateTimeKind.Utc).AddTicks(7038), 1, new DateTime(2023, 7, 15, 18, 10, 40, 229, DateTimeKind.Utc).AddTicks(2536) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 22, 19, 41, 18, 125, DateTimeKind.Utc).AddTicks(4066), new DateTime(2022, 11, 26, 8, 54, 22, 408, DateTimeKind.Utc).AddTicks(6287), new DateTime(2022, 5, 12, 18, 56, 14, 766, DateTimeKind.Utc).AddTicks(4482), 1, new DateTime(2023, 1, 9, 0, 12, 25, 426, DateTimeKind.Utc).AddTicks(9703) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 1, 5, 7, 8, 47, 45, DateTimeKind.Utc).AddTicks(2033), new DateTime(2020, 5, 1, 9, 2, 50, 55, DateTimeKind.Utc).AddTicks(8869), new DateTime(2019, 8, 30, 11, 39, 27, 103, DateTimeKind.Utc).AddTicks(9124), 1, new DateTime(2020, 12, 2, 13, 4, 45, 12, DateTimeKind.Utc).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 7, 21, 36, 1, 558, DateTimeKind.Utc).AddTicks(4564), new DateTime(2023, 8, 10, 12, 4, 18, 651, DateTimeKind.Utc).AddTicks(8840), new DateTime(2023, 5, 1, 22, 55, 28, 456, DateTimeKind.Utc).AddTicks(9882), 3, new DateTime(2023, 8, 27, 18, 44, 32, 301, DateTimeKind.Utc).AddTicks(7083) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "TypeId", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 22, 16, 2, 3, 864, DateTimeKind.Utc).AddTicks(3972), new DateTime(2022, 8, 18, 10, 2, 59, 229, DateTimeKind.Utc).AddTicks(9690), new DateTime(2022, 6, 18, 19, 11, 5, 980, DateTimeKind.Utc).AddTicks(8858), 1, new DateTime(2022, 10, 9, 21, 22, 43, 146, DateTimeKind.Utc).AddTicks(9666) });

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
