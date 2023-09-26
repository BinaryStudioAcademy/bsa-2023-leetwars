using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeetWars.Core.DAL.Migrations
{
    public partial class WeeklyChallenge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsWeekly",
                table: "Challenges",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Badges",
                columns: new[] { "Id", "Icon", "IconGif", "Name" },
                values: new object[] { 13L, "weekly.png", "weekly.gif", "Weekly LeetWars Challenge Badge" });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 6L,
                column: "BadgeId",
                value: 12L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 9L,
                column: "BadgeId",
                value: 7L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 11L,
                column: "BadgeId",
                value: 9L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 12L,
                column: "BadgeId",
                value: 7L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 13L,
                column: "BadgeId",
                value: 8L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 14L,
                column: "BadgeId",
                value: 12L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 15L,
                column: "BadgeId",
                value: 8L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 21L,
                column: "BadgeId",
                value: 12L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 23L,
                column: "BadgeId",
                value: 4L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 24L,
                column: "BadgeId",
                value: 7L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 26L,
                column: "BadgeId",
                value: 11L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 29L,
                column: "BadgeId",
                value: 7L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 31L,
                column: "BadgeId",
                value: 5L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 33L,
                column: "BadgeId",
                value: 8L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 34L,
                column: "BadgeId",
                value: 12L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 35L,
                column: "BadgeId",
                value: 9L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 39L,
                column: "BadgeId",
                value: 7L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 43L,
                column: "BadgeId",
                value: 10L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 44L,
                column: "BadgeId",
                value: 7L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 47L,
                column: "BadgeId",
                value: 10L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 50L,
                column: "BadgeId",
                value: 11L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 52L,
                column: "BadgeId",
                value: 11L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 54L,
                column: "BadgeId",
                value: 6L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 55L,
                column: "BadgeId",
                value: 10L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 56L,
                column: "BadgeId",
                value: 7L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 57L,
                column: "BadgeId",
                value: 12L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 59L,
                column: "BadgeId",
                value: 8L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 60L,
                column: "BadgeId",
                value: 11L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 61L,
                column: "BadgeId",
                value: 5L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 62L,
                column: "BadgeId",
                value: 7L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 65L,
                column: "BadgeId",
                value: 3L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 68L,
                column: "BadgeId",
                value: 9L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 69L,
                column: "BadgeId",
                value: 10L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 72L,
                column: "BadgeId",
                value: 8L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 80L,
                column: "BadgeId",
                value: 4L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 8L,
                column: "BadgeId",
                value: 13L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 17L,
                column: "BadgeId",
                value: 13L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 58L,
                column: "BadgeId",
                value: 13L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 64L,
                column: "BadgeId",
                value: 13L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 75L,
                column: "BadgeId",
                value: 13L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DropColumn(
                name: "IsWeekly",
                table: "Challenges");

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 6L,
                column: "BadgeId",
                value: 11L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 8L,
                column: "BadgeId",
                value: 12L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 9L,
                column: "BadgeId",
                value: 6L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 11L,
                column: "BadgeId",
                value: 8L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 12L,
                column: "BadgeId",
                value: 6L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 13L,
                column: "BadgeId",
                value: 7L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 14L,
                column: "BadgeId",
                value: 11L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 15L,
                column: "BadgeId",
                value: 7L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 17L,
                column: "BadgeId",
                value: 12L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 21L,
                column: "BadgeId",
                value: 11L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 23L,
                column: "BadgeId",
                value: 3L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 24L,
                column: "BadgeId",
                value: 6L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 26L,
                column: "BadgeId",
                value: 10L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 29L,
                column: "BadgeId",
                value: 6L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 31L,
                column: "BadgeId",
                value: 4L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 33L,
                column: "BadgeId",
                value: 7L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 34L,
                column: "BadgeId",
                value: 11L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 35L,
                column: "BadgeId",
                value: 8L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 39L,
                column: "BadgeId",
                value: 6L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 43L,
                column: "BadgeId",
                value: 9L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 44L,
                column: "BadgeId",
                value: 6L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 47L,
                column: "BadgeId",
                value: 9L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 50L,
                column: "BadgeId",
                value: 10L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 52L,
                column: "BadgeId",
                value: 10L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 54L,
                column: "BadgeId",
                value: 5L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 55L,
                column: "BadgeId",
                value: 9L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 56L,
                column: "BadgeId",
                value: 6L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 57L,
                column: "BadgeId",
                value: 11L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 58L,
                column: "BadgeId",
                value: 12L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 59L,
                column: "BadgeId",
                value: 7L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 60L,
                column: "BadgeId",
                value: 10L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 61L,
                column: "BadgeId",
                value: 4L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 62L,
                column: "BadgeId",
                value: 6L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 64L,
                column: "BadgeId",
                value: 12L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 65L,
                column: "BadgeId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 68L,
                column: "BadgeId",
                value: 8L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 69L,
                column: "BadgeId",
                value: 9L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 72L,
                column: "BadgeId",
                value: 7L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 75L,
                column: "BadgeId",
                value: 12L);

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 80L,
                column: "BadgeId",
                value: 3L);
        }
    }
}
