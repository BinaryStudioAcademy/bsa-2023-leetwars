using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeetWars.Core.DAL.Migrations
{
    public partial class AddBadges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Icon",
                value: "/static/images/badges/2023-01.png");

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Icon",
                value: "/static/images/badges/2023-02.png");

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Icon",
                value: "/static/images/badges/2023-03.png");

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Icon",
                value: "/static/images/badges/2023-04.png");

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Icon",
                value: "/static/images/badges/2023-05.png");

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Icon",
                value: "/static/images/badges/2023-06.png");

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Icon",
                value: "/static/images/badges/2023-07.png");

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Icon",
                value: "/static/images/badges/2023-08.png");

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Icon",
                value: "/static/images/badges/2023-09.png");

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Icon",
                value: "/static/images/badges/2023-10.png");

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Icon",
                value: "/static/images/badges/2023-11.png");

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: 12L,
                column: "Icon",
                value: "/static/images/badges/2023-12.png");

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 29, 4, 53, 29, 192, DateTimeKind.Utc).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 7, 20, 52, 983, DateTimeKind.Utc).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2021, 12, 29, 11, 9, 58, 719, DateTimeKind.Utc).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 8, 26, 8, 200, DateTimeKind.Utc).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 29, 12, 40, 51, 74, DateTimeKind.Utc).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 6, 0, 14, 50, 997, DateTimeKind.Utc).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 6, 20, 18, 4, 358, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 12, 15, 7, 460, DateTimeKind.Utc).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 20, 23, 2, 10, 839, DateTimeKind.Utc).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 15, 10, 42, 24, 24, DateTimeKind.Utc).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 24, 21, 20, 19, 669, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 11, 9, 19, 52, 848, DateTimeKind.Utc).AddTicks(332));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 1, 19, 29, 33, 748, DateTimeKind.Utc).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 4, 16, 50, 4, 102, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 13, 0, 11, 11, 770, DateTimeKind.Utc).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 8, 3, 48, 4, 350, DateTimeKind.Utc).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 6, 21, 50, 50, 318, DateTimeKind.Utc).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 22, 16, 7, 15, 437, DateTimeKind.Utc).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 15, 8, 30, 23, 753, DateTimeKind.Utc).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 1, 21, 52, 9, 968, DateTimeKind.Utc).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 1, 17, 43, 29, 920, DateTimeKind.Utc).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 8, 7, 14, 7, 965, DateTimeKind.Utc).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 4, 53, 38, 798, DateTimeKind.Utc).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 11, 19, 24, 57, 972, DateTimeKind.Utc).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 17, 41, 36, 604, DateTimeKind.Utc).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 10, 22, 25, 56, 568, DateTimeKind.Utc).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 29, 22, 5, 11, 736, DateTimeKind.Utc).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 2, 16, 37, 56, 261, DateTimeKind.Utc).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 19, 5, 2, 53, 19, DateTimeKind.Utc).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 6, 18, 56, 59, 828, DateTimeKind.Utc).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 1, 19, 12, 10, 254, DateTimeKind.Utc).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 4, 13, 24, 7, 819, DateTimeKind.Utc).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 18, 17, 50, 33, 136, DateTimeKind.Utc).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 22, 27, 2, 950, DateTimeKind.Utc).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 23, 21, 28, 56, 24, DateTimeKind.Utc).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 6, 3, 35, 20, 41, DateTimeKind.Utc).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 2, 7, 39, 17, 883, DateTimeKind.Utc).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 11, 22, 16, 24, 75, DateTimeKind.Utc).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 12, 48, 31, 17, DateTimeKind.Utc).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedAt",
                value: new DateTime(2022, 2, 4, 12, 43, 51, 570, DateTimeKind.Utc).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 9, 5, 30, 38, 188, DateTimeKind.Utc).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 25, 10, 7, 9, 24, DateTimeKind.Utc).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 19, 1, 24, 51, 15, DateTimeKind.Utc).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 15, 7, 40, 13, 295, DateTimeKind.Utc).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 7, 7, 0, 3, 125, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 2, 20, 59, 39, 197, DateTimeKind.Utc).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 23, 26, 22, 132, DateTimeKind.Utc).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 48L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 23, 6, 21, 239, DateTimeKind.Utc).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 18, 5, 31, 53, 257, DateTimeKind.Utc).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 28, 0, 35, 15, 531, DateTimeKind.Utc).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 1, 16, 19, 36, 342, DateTimeKind.Utc).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedAt",
                value: new DateTime(2018, 9, 18, 20, 4, 0, 922, DateTimeKind.Utc).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 1, 3, 47, 46, 438, DateTimeKind.Utc).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 16, 11, 44, 31, 70, DateTimeKind.Utc).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 10, 11, 9, 459, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 56L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 26, 9, 46, 46, 802, DateTimeKind.Utc).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 29, 18, 46, 36, 315, DateTimeKind.Utc).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 3, 2, 9, 45, 659, DateTimeKind.Utc).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 19, 12, 31, 49, 533, DateTimeKind.Utc).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 26, 3, 49, 46, 278, DateTimeKind.Utc).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 24, 16, 56, 22, 997, DateTimeKind.Utc).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 13, 18, 59, 13, 790, DateTimeKind.Utc).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 10, 19, 25, 17, 628, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 64L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 5, 1, 40, 16, 404, DateTimeKind.Utc).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 29, 18, 50, 1, 696, DateTimeKind.Utc).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 2, 8, 7, 33, 347, DateTimeKind.Utc).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 22, 20, 23, 22, 499, DateTimeKind.Utc).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 15, 13, 57, 6, 413, DateTimeKind.Utc).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 19, 16, 33, 27, 837, DateTimeKind.Utc).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 20, 11, 7, 51, 489, DateTimeKind.Utc).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 9, 39, 6, 978, DateTimeKind.Utc).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 72L,
                column: "CreatedAt",
                value: new DateTime(2020, 3, 21, 15, 17, 1, 402, DateTimeKind.Utc).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 24, 5, 18, 4, 210, DateTimeKind.Utc).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 23, 0, 53, 39, 403, DateTimeKind.Utc).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 5, 15, 48, 20, 428, DateTimeKind.Utc).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 18, 50, 32, 839, DateTimeKind.Utc).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedAt",
                value: new DateTime(2019, 4, 21, 2, 10, 28, 364, DateTimeKind.Utc).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 8, 15, 9, 57, 450, DateTimeKind.Utc).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 3, 13, 48, 802, DateTimeKind.Utc).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 80L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 20, 5, 15, 20, 910, DateTimeKind.Utc).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 4, 40, 15, 843, DateTimeKind.Utc).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 15, 4, 5, 56, 939, DateTimeKind.Utc).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 26, 20, 46, 45, 681, DateTimeKind.Utc).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 15, 3, 2, 24, 979, DateTimeKind.Utc).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 2, 17, 44, 48, 602, DateTimeKind.Utc).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 1, 18, 5, 54, 370, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 18, 20, 13, 49, 643, DateTimeKind.Utc).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 88L,
                column: "CreatedAt",
                value: new DateTime(2018, 10, 16, 8, 50, 30, 317, DateTimeKind.Utc).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedAt",
                value: new DateTime(2022, 1, 28, 23, 54, 34, 976, DateTimeKind.Utc).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 11, 20, 9, 1, 895, DateTimeKind.Utc).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 31, 6, 28, 34, 806, DateTimeKind.Utc).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 6, 12, 3, 11, 381, DateTimeKind.Utc).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 2, 19, 23, 1, 270, DateTimeKind.Utc).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 24, 13, 20, 18, 892, DateTimeKind.Utc).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 1, 8, 23, 19, 226, DateTimeKind.Utc).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 96L,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 2, 23, 3, 4, 343, DateTimeKind.Utc).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 26, 11, 57, 43, 274, DateTimeKind.Utc).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 0, 23, 59, 818, DateTimeKind.Utc).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 20, 21, 36, 33, 790, DateTimeKind.Utc).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 19, 5, 23, 20, 174, DateTimeKind.Utc).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 18, 14, 59, 37, 767, DateTimeKind.Utc).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 25, 9, 3, 4, 546, DateTimeKind.Utc).AddTicks(1744));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 12, 7, 35, 57, 489, DateTimeKind.Utc).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 104L,
                column: "CreatedAt",
                value: new DateTime(2019, 6, 5, 1, 32, 31, 64, DateTimeKind.Utc).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedAt",
                value: new DateTime(2022, 2, 20, 9, 43, 32, 283, DateTimeKind.Utc).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 2, 2, 0, 53, 617, DateTimeKind.Utc).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedAt",
                value: new DateTime(2020, 2, 17, 1, 16, 19, 440, DateTimeKind.Utc).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 8, 28, 53, 939, DateTimeKind.Utc).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 31, 12, 4, 39, 700, DateTimeKind.Utc).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 30, 6, 1, 1, 442, DateTimeKind.Utc).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedAt",
                value: new DateTime(2018, 2, 21, 12, 34, 50, 440, DateTimeKind.Utc).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 112L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 7, 4, 1, 17, 585, DateTimeKind.Utc).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 7, 46, 16, 328, DateTimeKind.Utc).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 6, 2, 23, 35, 663, DateTimeKind.Utc).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 19, 1, 50, 7, 55, DateTimeKind.Utc).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 1, 7, 48, 55, 455, DateTimeKind.Utc).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 16, 1, 58, 5, 723, DateTimeKind.Utc).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedAt",
                value: new DateTime(2022, 2, 28, 0, 21, 23, 551, DateTimeKind.Utc).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 17, 22, 49, 0, 293, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 120L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 14, 18, 49, 53, 246, DateTimeKind.Utc).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 14, 3, 14, 51, 903, DateTimeKind.Utc).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 14, 11, 9, 15, 962, DateTimeKind.Utc).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 29, 9, 26, 10, 966, DateTimeKind.Utc).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 23, 18, 11, 2, 500, DateTimeKind.Utc).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 10, 51, 27, 2, DateTimeKind.Utc).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 30, 5, 48, 10, 517, DateTimeKind.Utc).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 31, 10, 17, 56, 867, DateTimeKind.Utc).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 128L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 24, 4, 19, 43, 837, DateTimeKind.Utc).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 19, 3, 33, 10, 625, DateTimeKind.Utc).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 4, 17, 19, 52, 498, DateTimeKind.Utc).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 5, 23, 6, 24, 537, DateTimeKind.Utc).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 13, 23, 50, 58, 793, DateTimeKind.Utc).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 4, 11, 28, 54, 396, DateTimeKind.Utc).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 30, 9, 22, 29, 476, DateTimeKind.Utc).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedAt",
                value: new DateTime(2021, 6, 13, 16, 37, 59, 66, DateTimeKind.Utc).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 136L,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 1, 7, 45, 44, 890, DateTimeKind.Utc).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedAt",
                value: new DateTime(2022, 2, 21, 18, 33, 43, 435, DateTimeKind.Utc).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 7, 42, 2, 850, DateTimeKind.Utc).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 1, 21, 12, 23, 969, DateTimeKind.Utc).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 28, 9, 4, 17, 628, DateTimeKind.Utc).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedAt",
                value: new DateTime(2022, 2, 19, 18, 11, 57, 94, DateTimeKind.Utc).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 26, 2, 7, 22, 442, DateTimeKind.Utc).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 8, 27, 6, 786, DateTimeKind.Utc).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 144L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 12, 0, 12, 16, 278, DateTimeKind.Utc).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 9, 1, 13, 34, 655, DateTimeKind.Utc).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 21, 21, 41, 12, 102, DateTimeKind.Utc).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 30, 5, 52, 55, 552, DateTimeKind.Utc).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 20, 52, 16, 785, DateTimeKind.Utc).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 20, 21, 55, 15, 418, DateTimeKind.Utc).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 30, 0, 42, 33, 999, DateTimeKind.Utc).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 10, 6, 24, 59, 566, DateTimeKind.Utc).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 152L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 1, 12, 29, 9, 131, DateTimeKind.Utc).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 2, 37, 24, 256, DateTimeKind.Utc).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 13, 11, 4, 49, 831, DateTimeKind.Utc).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 29, 4, 23, 17, 76, DateTimeKind.Utc).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 30, 14, 39, 28, 408, DateTimeKind.Utc).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 20, 41, 47, 443, DateTimeKind.Utc).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 28, 17, 47, 7, 993, DateTimeKind.Utc).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedAt",
                value: new DateTime(2021, 6, 12, 3, 45, 21, 352, DateTimeKind.Utc).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 160L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 24, 6, 59, 13, 917, DateTimeKind.Utc).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedAt",
                value: new DateTime(2022, 2, 26, 10, 25, 7, 602, DateTimeKind.Utc).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 18, 0, 41, 8, 225, DateTimeKind.Utc).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 16, 12, 40, 31, 253, DateTimeKind.Utc).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 52, 40, 751, DateTimeKind.Utc).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 2, 12, 1, 19, 729, DateTimeKind.Utc).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 1, 8, 18, 44, 689, DateTimeKind.Utc).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedAt",
                value: new DateTime(2018, 12, 5, 0, 10, 14, 393, DateTimeKind.Utc).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 168L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 10, 10, 50, 864, DateTimeKind.Utc).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 4, 11, 10, 576, DateTimeKind.Utc).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 4, 3, 55, 29, 741, DateTimeKind.Utc).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 29, 5, 47, 43, 930, DateTimeKind.Utc).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 2, 55, 13, 537, DateTimeKind.Utc).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 9, 16, 51, 45, 186, DateTimeKind.Utc).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 17, 6, 57, 30, 30, DateTimeKind.Utc).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 16, 38, 22, 614, DateTimeKind.Utc).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 176L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 17, 8, 46, 15, 492, DateTimeKind.Utc).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 26, 21, 45, 9, 343, DateTimeKind.Utc).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 4, 3, 13, 46, 152, DateTimeKind.Utc).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 6, 9, 40, 52, 883, DateTimeKind.Utc).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 31, 14, 1, 41, 757, DateTimeKind.Utc).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 25, 1, 51, 8, 764, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 22, 1, 58, 2, 208, DateTimeKind.Utc).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 6, 46, 43, 633, DateTimeKind.Utc).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 184L,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 5, 0, 59, 47, 108, DateTimeKind.Utc).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedAt",
                value: new DateTime(2020, 2, 28, 1, 11, 30, 560, DateTimeKind.Utc).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 9, 1, 25, 44, 573, DateTimeKind.Utc).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 13, 9, 45, 21, 359, DateTimeKind.Utc).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 22, 20, 26, 177, DateTimeKind.Utc).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedAt",
                value: new DateTime(2022, 1, 15, 10, 30, 8, 791, DateTimeKind.Utc).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 27, 20, 3, 40, 782, DateTimeKind.Utc).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 5, 1, 55, 23, 980, DateTimeKind.Utc).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 192L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 12, 16, 30, 8, 622, DateTimeKind.Utc).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 0, 20, 30, 14, DateTimeKind.Utc).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 2, 12, 41, 40, 14, DateTimeKind.Utc).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 26, 10, 40, 59, 293, DateTimeKind.Utc).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 1, 23, 45, 30, 23, DateTimeKind.Utc).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 5, 19, 19, 112, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 4, 26, 35, 660, DateTimeKind.Utc).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 6, 48, 0, 904, DateTimeKind.Utc).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 200L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 1, 21, 55, 18, 507, DateTimeKind.Utc).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 26, 17, 8, 53, 507, DateTimeKind.Utc).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2018, 3, 16, 11, 8, 25, 108, DateTimeKind.Utc).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 22, 11, 36, 37, 512, DateTimeKind.Utc).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 6, 10, 42, 56, 775, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 23, 22, 17, 17, 807, DateTimeKind.Utc).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 23, 7, 22, 19, 684, DateTimeKind.Utc).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 8, 2, 33, 59, 454, DateTimeKind.Utc).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2017, 1, 15, 22, 59, 37, 781, DateTimeKind.Utc).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 6, 20, 12, 40, 128, DateTimeKind.Utc).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 3, 10, 22, 44, 258, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2018, 1, 13, 20, 50, 57, 834, DateTimeKind.Utc).AddTicks(788));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 12, 13, 47, 59, 69, DateTimeKind.Utc).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2017, 10, 23, 8, 43, 38, 634, DateTimeKind.Utc).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 16, 6, 56, 30, 301, DateTimeKind.Utc).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2018, 7, 14, 16, 3, 48, 80, DateTimeKind.Utc).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 20, 2, 54, 13, 972, DateTimeKind.Utc).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 19, 22, 30, 3, 506, DateTimeKind.Utc).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 19, 6, 3, 33, 196, DateTimeKind.Utc).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 25, 18, 8, 2, 142, DateTimeKind.Utc).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 4, 10, 58, 51, 113, DateTimeKind.Utc).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 30, 3, 22, 59, 781, DateTimeKind.Utc).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 28, 19, 13, 0, 156, DateTimeKind.Utc).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 24, 14, 19, 43, 836, DateTimeKind.Utc).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 12, 8, 30, 8, 413, DateTimeKind.Utc).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 7, 7, 37, 52, 77, DateTimeKind.Utc).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 7, 3, 42, 51, 313, DateTimeKind.Utc).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 14, 6, 25, 36, 388, DateTimeKind.Utc).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2022, 2, 14, 1, 26, 7, 647, DateTimeKind.Utc).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 27, 6, 5, 32, 148, DateTimeKind.Utc).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2017, 7, 1, 18, 6, 57, 394, DateTimeKind.Utc).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 12, 4, 33, 41, 184, DateTimeKind.Utc).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 9, 11, 48, 20, 18, DateTimeKind.Utc).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 5, 5, 35, 515, DateTimeKind.Utc).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 22, 20, 22, 14, 242, DateTimeKind.Utc).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 12, 23, 24, 46, 27, DateTimeKind.Utc).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedAt",
                value: new DateTime(2021, 6, 2, 0, 44, 49, 668, DateTimeKind.Utc).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 28, 19, 49, 34, 808, DateTimeKind.Utc).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 20, 20, 49, 57, 936, DateTimeKind.Utc).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedAt",
                value: new DateTime(2022, 2, 14, 3, 30, 38, 472, DateTimeKind.Utc).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 16, 10, 55, 46, 179, DateTimeKind.Utc).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedAt",
                value: new DateTime(2021, 12, 2, 20, 27, 53, 957, DateTimeKind.Utc).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 6, 20, 29, 10, 764, DateTimeKind.Utc).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 24, 4, 58, 36, 621, DateTimeKind.Utc).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedAt",
                value: new DateTime(2019, 2, 8, 8, 6, 33, 349, DateTimeKind.Utc).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 8, 3, 53, 10, 471, DateTimeKind.Utc).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 29, 14, 27, 10, 23, DateTimeKind.Utc).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 8, 15, 54, 30, 832, DateTimeKind.Utc).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 48L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 5, 4, 1, 12, 544, DateTimeKind.Utc).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 0, 58, 31, 249, DateTimeKind.Utc).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 24, 12, 16, 8, 306, DateTimeKind.Utc).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 21, 23, 31, 39, 914, DateTimeKind.Utc).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedAt",
                value: new DateTime(2022, 1, 31, 13, 49, 23, 162, DateTimeKind.Utc).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedAt",
                value: new DateTime(2019, 4, 12, 18, 13, 18, 373, DateTimeKind.Utc).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedAt",
                value: new DateTime(2022, 1, 27, 3, 56, 25, 379, DateTimeKind.Utc).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 1, 18, 32, 229, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 56L,
                column: "CreatedAt",
                value: new DateTime(2018, 4, 23, 1, 5, 16, 298, DateTimeKind.Utc).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 8, 4, 27, 56, 862, DateTimeKind.Utc).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 20, 3, 29, 38, 543, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 18, 16, 7, 13, 817, DateTimeKind.Utc).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedAt",
                value: new DateTime(2019, 2, 25, 13, 25, 53, 11, DateTimeKind.Utc).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 18, 13, 21, 212, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 5, 7, 32, 55, 419, DateTimeKind.Utc).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 16, 19, 37, 14, 261, DateTimeKind.Utc).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 64L,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 21, 17, 39, 6, 150, DateTimeKind.Utc).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 20, 0, 18, 2, 24, DateTimeKind.Utc).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedAt",
                value: new DateTime(2021, 12, 1, 2, 56, 28, 370, DateTimeKind.Utc).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 8, 16, 11, 26, 670, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 14, 16, 53, 59, 995, DateTimeKind.Utc).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 26, 19, 57, 47, 762, DateTimeKind.Utc).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 25, 13, 56, 54, 997, DateTimeKind.Utc).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 21, 21, 54, 11, 867, DateTimeKind.Utc).AddTicks(9023), new DateTime(2023, 7, 20, 6, 44, 45, 108, DateTimeKind.Utc).AddTicks(8106), new DateTime(2022, 8, 15, 14, 18, 18, 192, DateTimeKind.Utc).AddTicks(3686), new DateTime(2023, 7, 22, 14, 19, 5, 878, DateTimeKind.Utc).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 19, 1, 41, 20, 481, DateTimeKind.Utc).AddTicks(7587), new DateTime(2023, 7, 31, 16, 19, 25, 357, DateTimeKind.Utc).AddTicks(3535), new DateTime(2023, 1, 23, 7, 20, 39, 173, DateTimeKind.Utc).AddTicks(7215), new DateTime(2023, 2, 8, 2, 39, 51, 756, DateTimeKind.Utc).AddTicks(9572) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 10, 16, 48, 31, 316, DateTimeKind.Utc).AddTicks(7222), new DateTime(2023, 7, 29, 11, 55, 58, 550, DateTimeKind.Utc).AddTicks(6457), new DateTime(2023, 5, 11, 23, 0, 27, 178, DateTimeKind.Utc).AddTicks(5193), new DateTime(2023, 7, 22, 20, 49, 5, 454, DateTimeKind.Utc).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 1, 14, 23, 24, 1, 733, DateTimeKind.Utc).AddTicks(4415), new DateTime(2022, 6, 2, 11, 20, 23, 270, DateTimeKind.Utc).AddTicks(7559), new DateTime(2021, 8, 2, 19, 41, 20, 8, DateTimeKind.Utc).AddTicks(6725), new DateTime(2022, 8, 14, 3, 8, 36, 54, DateTimeKind.Utc).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 13, 12, 29, 49, 222, DateTimeKind.Utc).AddTicks(2952), new DateTime(2023, 5, 8, 11, 35, 22, 415, DateTimeKind.Utc).AddTicks(1488), new DateTime(2022, 10, 31, 9, 33, 2, 955, DateTimeKind.Utc).AddTicks(9433), new DateTime(2023, 8, 16, 9, 45, 16, 978, DateTimeKind.Utc).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 19, 22, 19, 248, DateTimeKind.Utc).AddTicks(1301), new DateTime(2021, 4, 12, 2, 34, 8, 1, DateTimeKind.Utc).AddTicks(6773), new DateTime(2018, 12, 17, 4, 14, 46, 490, DateTimeKind.Utc).AddTicks(4739), new DateTime(2019, 12, 30, 5, 57, 24, 925, DateTimeKind.Utc).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 2, 23, 20, 29, 4, 795, DateTimeKind.Utc).AddTicks(9771), new DateTime(2023, 1, 31, 7, 54, 35, 75, DateTimeKind.Utc).AddTicks(3376), new DateTime(2020, 4, 23, 15, 54, 6, 444, DateTimeKind.Utc).AddTicks(1856), new DateTime(2021, 1, 24, 17, 2, 8, 462, DateTimeKind.Utc).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 10, 18, 15, 27, 47, 741, DateTimeKind.Utc).AddTicks(1486), new DateTime(2022, 8, 27, 9, 28, 52, 398, DateTimeKind.Utc).AddTicks(8446), new DateTime(2021, 5, 7, 17, 53, 13, 9, DateTimeKind.Utc).AddTicks(6852), new DateTime(2021, 7, 19, 1, 6, 55, 68, DateTimeKind.Utc).AddTicks(2246) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 27, 12, 57, 35, 926, DateTimeKind.Utc).AddTicks(8196), new DateTime(2023, 5, 28, 11, 57, 53, 289, DateTimeKind.Utc).AddTicks(1190), new DateTime(2021, 6, 3, 5, 49, 39, 304, DateTimeKind.Utc).AddTicks(9154), new DateTime(2022, 5, 3, 1, 9, 10, 835, DateTimeKind.Utc).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 7, 3, 9, 13, 484, DateTimeKind.Utc).AddTicks(6115), new DateTime(2022, 3, 22, 7, 34, 51, 914, DateTimeKind.Utc).AddTicks(3620), new DateTime(2021, 3, 14, 17, 39, 57, 895, DateTimeKind.Utc).AddTicks(9930), new DateTime(2022, 12, 6, 1, 8, 3, 169, DateTimeKind.Utc).AddTicks(6661) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 17, 27, 38, 624, DateTimeKind.Utc).AddTicks(2660), new DateTime(2023, 4, 11, 11, 31, 43, 302, DateTimeKind.Utc).AddTicks(9530), new DateTime(2023, 1, 14, 9, 16, 1, 106, DateTimeKind.Utc).AddTicks(3348), new DateTime(2023, 2, 17, 22, 4, 2, 287, DateTimeKind.Utc).AddTicks(7492) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 19, 16, 56, 7, 57, DateTimeKind.Utc).AddTicks(7456), new DateTime(2022, 12, 17, 22, 14, 3, 148, DateTimeKind.Utc).AddTicks(8533), new DateTime(2022, 9, 22, 22, 17, 3, 515, DateTimeKind.Utc).AddTicks(2994), new DateTime(2023, 8, 13, 18, 39, 34, 510, DateTimeKind.Utc).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 19, 23, 58, 57, 940, DateTimeKind.Utc).AddTicks(9243), new DateTime(2023, 9, 11, 2, 24, 59, 627, DateTimeKind.Utc).AddTicks(5023), new DateTime(2023, 4, 19, 20, 45, 37, 280, DateTimeKind.Utc).AddTicks(5647), new DateTime(2023, 9, 1, 19, 49, 58, 729, DateTimeKind.Utc).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 5, 26, 2, 43, 51, 678, DateTimeKind.Utc).AddTicks(9241), new DateTime(2020, 7, 28, 11, 51, 45, 261, DateTimeKind.Utc).AddTicks(4039), new DateTime(2019, 11, 13, 12, 0, 2, 263, DateTimeKind.Utc).AddTicks(5513), new DateTime(2022, 10, 26, 13, 11, 32, 289, DateTimeKind.Utc).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 9, 5, 0, 23, 32, 196, DateTimeKind.Utc).AddTicks(3031), new DateTime(2022, 8, 15, 9, 27, 25, 26, DateTimeKind.Utc).AddTicks(2363), new DateTime(2021, 4, 2, 3, 28, 23, 923, DateTimeKind.Utc).AddTicks(5701), new DateTime(2023, 7, 9, 10, 59, 27, 219, DateTimeKind.Utc).AddTicks(9819) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 11, 4, 0, 56, 741, DateTimeKind.Utc).AddTicks(5619), new DateTime(2023, 8, 21, 20, 8, 27, 363, DateTimeKind.Utc).AddTicks(2311), new DateTime(2023, 2, 19, 12, 59, 54, 287, DateTimeKind.Utc).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 1, 25, 22, 3, 18, 728, DateTimeKind.Utc).AddTicks(5877), new DateTime(2020, 12, 5, 20, 39, 9, 962, DateTimeKind.Utc).AddTicks(2465), new DateTime(2019, 1, 19, 7, 18, 19, 877, DateTimeKind.Utc).AddTicks(9290), new DateTime(2020, 8, 21, 13, 51, 15, 622, DateTimeKind.Utc).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 23, 16, 38, 15, 760, DateTimeKind.Utc).AddTicks(679), new DateTime(2023, 8, 4, 2, 1, 8, 297, DateTimeKind.Utc).AddTicks(4388), new DateTime(2020, 12, 26, 5, 1, 53, 738, DateTimeKind.Utc).AddTicks(3215), new DateTime(2021, 12, 2, 12, 58, 54, 268, DateTimeKind.Utc).AddTicks(136) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 7, 7, 14, 22, 523, DateTimeKind.Utc).AddTicks(1609), new DateTime(2023, 7, 6, 8, 39, 24, 938, DateTimeKind.Utc).AddTicks(5372), new DateTime(2023, 6, 25, 16, 3, 23, 817, DateTimeKind.Utc).AddTicks(4195), new DateTime(2023, 7, 22, 2, 43, 11, 96, DateTimeKind.Utc).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 3, 26, 22, 28, 7, 839, DateTimeKind.Utc).AddTicks(8887), new DateTime(2020, 2, 27, 12, 25, 42, 350, DateTimeKind.Utc).AddTicks(6322), new DateTime(2019, 11, 27, 13, 26, 42, 732, DateTimeKind.Utc).AddTicks(4692), new DateTime(2022, 3, 12, 5, 44, 37, 693, DateTimeKind.Utc).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 7, 11, 9, 57, 465, DateTimeKind.Utc).AddTicks(5866), new DateTime(2023, 5, 31, 13, 22, 53, 467, DateTimeKind.Utc).AddTicks(8320), new DateTime(2022, 3, 4, 11, 1, 10, 865, DateTimeKind.Utc).AddTicks(876), new DateTime(2023, 6, 17, 15, 26, 9, 481, DateTimeKind.Utc).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 11, 23, 14, 24, 210, DateTimeKind.Utc).AddTicks(7641), new DateTime(2023, 5, 4, 3, 57, 23, 544, DateTimeKind.Utc).AddTicks(2234), new DateTime(2019, 12, 15, 14, 48, 35, 507, DateTimeKind.Utc).AddTicks(9800), new DateTime(2022, 5, 15, 0, 50, 1, 195, DateTimeKind.Utc).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 3, 27, 4, 1, 50, 389, DateTimeKind.Utc).AddTicks(2812), new DateTime(2020, 3, 21, 17, 38, 28, 455, DateTimeKind.Utc).AddTicks(5416), new DateTime(2017, 7, 19, 21, 27, 13, 399, DateTimeKind.Utc).AddTicks(2121), new DateTime(2023, 9, 1, 2, 38, 58, 833, DateTimeKind.Utc).AddTicks(5416) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 5, 24, 0, 50, 0, 57, DateTimeKind.Utc).AddTicks(1453), new DateTime(2019, 8, 2, 13, 20, 45, 68, DateTimeKind.Utc).AddTicks(2009), new DateTime(2019, 3, 31, 12, 37, 51, 293, DateTimeKind.Utc).AddTicks(5818), new DateTime(2020, 9, 19, 6, 16, 40, 758, DateTimeKind.Utc).AddTicks(7572) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 9, 16, 6, 300, DateTimeKind.Utc).AddTicks(6803), new DateTime(2023, 4, 5, 7, 53, 21, 695, DateTimeKind.Utc).AddTicks(2587), new DateTime(2021, 4, 12, 18, 27, 4, 495, DateTimeKind.Utc).AddTicks(3155), new DateTime(2022, 4, 10, 3, 0, 4, 499, DateTimeKind.Utc).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 26, 10, 15, 55, 781, DateTimeKind.Utc).AddTicks(5311), new DateTime(2023, 5, 16, 6, 7, 56, 800, DateTimeKind.Utc).AddTicks(1082), new DateTime(2023, 2, 13, 17, 12, 30, 599, DateTimeKind.Utc).AddTicks(8430), new DateTime(2023, 4, 3, 18, 54, 5, 41, DateTimeKind.Utc).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2023, 2, 21, 23, 30, 10, 742, DateTimeKind.Utc).AddTicks(6636), new DateTime(2022, 12, 26, 9, 42, 25, 987, DateTimeKind.Utc).AddTicks(6433), new DateTime(2022, 7, 5, 12, 15, 20, 271, DateTimeKind.Utc).AddTicks(6491) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 2, 25, 31, 619, DateTimeKind.Utc).AddTicks(5976), new DateTime(2023, 5, 27, 20, 33, 0, 279, DateTimeKind.Utc).AddTicks(4354), new DateTime(2023, 3, 26, 20, 32, 22, 452, DateTimeKind.Utc).AddTicks(4402), new DateTime(2023, 8, 14, 4, 14, 5, 451, DateTimeKind.Utc).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 23, 6, 59, 18, 598, DateTimeKind.Utc).AddTicks(5191), new DateTime(2023, 4, 4, 19, 44, 4, 18, DateTimeKind.Utc).AddTicks(6155), new DateTime(2023, 2, 26, 2, 6, 26, 243, DateTimeKind.Utc).AddTicks(9650), new DateTime(2023, 7, 16, 9, 50, 14, 954, DateTimeKind.Utc).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 12, 13, 25, 49, 672, DateTimeKind.Utc).AddTicks(3186), new DateTime(2023, 7, 21, 14, 7, 44, 873, DateTimeKind.Utc).AddTicks(4026), new DateTime(2021, 8, 6, 1, 36, 1, 850, DateTimeKind.Utc).AddTicks(86), new DateTime(2022, 6, 24, 9, 42, 32, 476, DateTimeKind.Utc).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 8, 9, 9, 41, 42, 490, DateTimeKind.Utc).AddTicks(3293), new DateTime(2023, 8, 21, 14, 53, 26, 116, DateTimeKind.Utc).AddTicks(8306), new DateTime(2023, 8, 17, 14, 13, 49, 76, DateTimeKind.Utc).AddTicks(4842), new DateTime(2023, 8, 30, 5, 39, 22, 399, DateTimeKind.Utc).AddTicks(811) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 11, 17, 8, 39, 965, DateTimeKind.Utc).AddTicks(8467), new DateTime(2022, 4, 2, 19, 30, 59, 473, DateTimeKind.Utc).AddTicks(9878), new DateTime(2022, 2, 10, 2, 14, 46, 454, DateTimeKind.Utc).AddTicks(8167), new DateTime(2023, 7, 3, 0, 35, 30, 807, DateTimeKind.Utc).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 9, 3, 8, 48, 0, 447, DateTimeKind.Utc).AddTicks(324), new DateTime(2022, 6, 24, 3, 20, 8, 672, DateTimeKind.Utc).AddTicks(2917), new DateTime(2019, 6, 15, 10, 51, 20, 635, DateTimeKind.Utc).AddTicks(1620), new DateTime(2019, 8, 24, 10, 17, 57, 573, DateTimeKind.Utc).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 19, 20, 39, 42, 849, DateTimeKind.Utc).AddTicks(2597), new DateTime(2023, 9, 2, 23, 56, 5, 413, DateTimeKind.Utc).AddTicks(7205), new DateTime(2022, 8, 18, 18, 27, 39, 794, DateTimeKind.Utc).AddTicks(6373), new DateTime(2022, 9, 16, 11, 8, 13, 193, DateTimeKind.Utc).AddTicks(5504) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2019, 12, 2, 21, 37, 45, 493, DateTimeKind.Utc).AddTicks(4397), new DateTime(2019, 10, 28, 11, 6, 50, 888, DateTimeKind.Utc).AddTicks(5684), new DateTime(2018, 8, 4, 8, 20, 41, 241, DateTimeKind.Utc).AddTicks(6573), new DateTime(2021, 3, 20, 4, 11, 45, 111, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 12, 18, 18, 32, 24, 988, DateTimeKind.Utc).AddTicks(601), new DateTime(2021, 11, 24, 2, 12, 41, 938, DateTimeKind.Utc).AddTicks(4582), new DateTime(2021, 4, 10, 6, 0, 58, 222, DateTimeKind.Utc).AddTicks(6804), new DateTime(2021, 12, 8, 13, 42, 22, 195, DateTimeKind.Utc).AddTicks(3543) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 0, 56, 46, 423, DateTimeKind.Utc).AddTicks(6263), new DateTime(2023, 4, 7, 13, 54, 8, 19, DateTimeKind.Utc).AddTicks(9474), new DateTime(2022, 7, 10, 3, 29, 18, 329, DateTimeKind.Utc).AddTicks(1176), new DateTime(2023, 4, 20, 7, 45, 37, 384, DateTimeKind.Utc).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 15, 2, 14, 784, DateTimeKind.Utc).AddTicks(9777), new DateTime(2023, 8, 19, 2, 49, 32, 112, DateTimeKind.Utc).AddTicks(3288), new DateTime(2023, 6, 28, 3, 49, 58, 390, DateTimeKind.Utc).AddTicks(2160), new DateTime(2023, 8, 24, 22, 9, 4, 227, DateTimeKind.Utc).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 25, 17, 56, 54, 396, DateTimeKind.Utc).AddTicks(4210), new DateTime(2023, 6, 29, 11, 49, 15, 748, DateTimeKind.Utc).AddTicks(2044), new DateTime(2023, 5, 24, 12, 8, 13, 762, DateTimeKind.Utc).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 2, 32, 35, 894, DateTimeKind.Utc).AddTicks(6084), new DateTime(2022, 7, 10, 16, 44, 34, 462, DateTimeKind.Utc).AddTicks(5847), new DateTime(2020, 12, 18, 14, 36, 48, 53, DateTimeKind.Utc).AddTicks(1797), new DateTime(2022, 8, 8, 16, 40, 10, 139, DateTimeKind.Utc).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 20, 23, 4, 144, DateTimeKind.Utc).AddTicks(3966), new DateTime(2020, 1, 26, 5, 34, 26, 147, DateTimeKind.Utc).AddTicks(697), new DateTime(2019, 11, 29, 19, 50, 9, 414, DateTimeKind.Utc).AddTicks(3493), new DateTime(2023, 6, 13, 14, 9, 4, 855, DateTimeKind.Utc).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 17, 9, 15, 244, DateTimeKind.Utc).AddTicks(2119), new DateTime(2023, 7, 17, 4, 35, 53, 845, DateTimeKind.Utc).AddTicks(6319), new DateTime(2020, 6, 7, 10, 36, 54, 416, DateTimeKind.Utc).AddTicks(5414), new DateTime(2020, 11, 4, 0, 33, 13, 634, DateTimeKind.Utc).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 26, 13, 27, 1, 541, DateTimeKind.Utc).AddTicks(4511), new DateTime(2023, 8, 21, 16, 2, 13, 701, DateTimeKind.Utc).AddTicks(6881), new DateTime(2023, 8, 7, 8, 11, 47, 616, DateTimeKind.Utc).AddTicks(1034), new DateTime(2023, 9, 5, 18, 0, 34, 28, DateTimeKind.Utc).AddTicks(4651) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 4, 21, 16, 150, DateTimeKind.Utc).AddTicks(3343), new DateTime(2023, 8, 16, 22, 24, 48, 984, DateTimeKind.Utc).AddTicks(9374), new DateTime(2023, 7, 2, 18, 27, 25, 980, DateTimeKind.Utc).AddTicks(7177), new DateTime(2023, 7, 27, 14, 59, 53, 835, DateTimeKind.Utc).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 11, 18, 9, 991, DateTimeKind.Utc).AddTicks(1755), new DateTime(2023, 4, 25, 23, 28, 27, 704, DateTimeKind.Utc).AddTicks(6428), new DateTime(2022, 9, 17, 12, 54, 45, 184, DateTimeKind.Utc).AddTicks(2592), new DateTime(2023, 3, 22, 11, 57, 1, 783, DateTimeKind.Utc).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 19, 8, 54, 30, 786, DateTimeKind.Utc).AddTicks(8022), new DateTime(2022, 2, 15, 2, 48, 16, 804, DateTimeKind.Utc).AddTicks(3505), new DateTime(2020, 6, 14, 12, 33, 2, 467, DateTimeKind.Utc).AddTicks(1966), new DateTime(2021, 11, 23, 15, 49, 6, 564, DateTimeKind.Utc).AddTicks(9302) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 22, 18, 28, 17, 258, DateTimeKind.Utc).AddTicks(9770), new DateTime(2023, 8, 30, 6, 38, 21, 291, DateTimeKind.Utc).AddTicks(6495), new DateTime(2023, 4, 16, 17, 47, 43, 490, DateTimeKind.Utc).AddTicks(8886), new DateTime(2023, 8, 12, 20, 57, 23, 749, DateTimeKind.Utc).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 7, 4, 12, 49, 1, 67, DateTimeKind.Utc).AddTicks(3409), new DateTime(2021, 12, 13, 12, 26, 35, 306, DateTimeKind.Utc).AddTicks(8264), new DateTime(2020, 1, 4, 23, 5, 50, 41, DateTimeKind.Utc).AddTicks(471), new DateTime(2021, 2, 23, 4, 51, 47, 177, DateTimeKind.Utc).AddTicks(959) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 6, 21, 3, 31, 13, 990, DateTimeKind.Utc).AddTicks(2728), new DateTime(2023, 8, 30, 6, 32, 6, 349, DateTimeKind.Utc).AddTicks(1168), new DateTime(2023, 4, 5, 0, 11, 11, 541, DateTimeKind.Utc).AddTicks(6126), new DateTime(2023, 8, 26, 17, 34, 54, 585, DateTimeKind.Utc).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2021, 8, 14, 4, 2, 34, 400, DateTimeKind.Utc).AddTicks(9372), new DateTime(2021, 7, 1, 4, 58, 38, 565, DateTimeKind.Utc).AddTicks(2703), new DateTime(2020, 3, 6, 14, 54, 42, 726, DateTimeKind.Utc).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 4, 29, 15, 1, 11, 126, DateTimeKind.Utc).AddTicks(2686), new DateTime(2021, 5, 13, 8, 34, 35, 817, DateTimeKind.Utc).AddTicks(4294), new DateTime(2019, 10, 31, 2, 6, 37, 354, DateTimeKind.Utc).AddTicks(5589), new DateTime(2023, 2, 17, 6, 14, 27, 525, DateTimeKind.Utc).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 18, 18, 3, 49, 980, DateTimeKind.Utc).AddTicks(7956), new DateTime(2023, 8, 8, 3, 50, 54, 199, DateTimeKind.Utc).AddTicks(7721), new DateTime(2023, 7, 7, 3, 53, 33, 284, DateTimeKind.Utc).AddTicks(6686), new DateTime(2023, 8, 2, 12, 32, 17, 463, DateTimeKind.Utc).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 42, 5, 269, DateTimeKind.Utc).AddTicks(9634), new DateTime(2023, 8, 6, 8, 23, 11, 767, DateTimeKind.Utc).AddTicks(4022), new DateTime(2022, 3, 24, 22, 45, 32, 876, DateTimeKind.Utc).AddTicks(2953), new DateTime(2022, 4, 13, 5, 7, 43, 373, DateTimeKind.Utc).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 12, 39, 512, DateTimeKind.Utc).AddTicks(6838), new DateTime(2022, 9, 11, 1, 4, 41, 986, DateTimeKind.Utc).AddTicks(8287), new DateTime(2021, 10, 21, 7, 32, 45, 939, DateTimeKind.Utc).AddTicks(328), new DateTime(2022, 4, 13, 12, 59, 0, 273, DateTimeKind.Utc).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 1, 20, 2, 53, 12, 303, DateTimeKind.Utc).AddTicks(5088), new DateTime(2022, 9, 23, 2, 20, 33, 386, DateTimeKind.Utc).AddTicks(6739), new DateTime(2022, 8, 8, 5, 15, 53, 683, DateTimeKind.Utc).AddTicks(8305), new DateTime(2023, 8, 4, 20, 39, 27, 677, DateTimeKind.Utc).AddTicks(7742) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 5, 7, 15, 8, 166, DateTimeKind.Utc).AddTicks(4367), new DateTime(2023, 9, 10, 20, 31, 35, 925, DateTimeKind.Utc).AddTicks(1595), new DateTime(2023, 7, 8, 21, 14, 16, 544, DateTimeKind.Utc).AddTicks(1287), new DateTime(2023, 7, 16, 8, 44, 35, 509, DateTimeKind.Utc).AddTicks(6617) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 3, 19, 16, 55, 886, DateTimeKind.Utc).AddTicks(5413), new DateTime(2022, 9, 18, 23, 46, 44, 39, DateTimeKind.Utc).AddTicks(8217), new DateTime(2022, 6, 9, 16, 2, 41, 590, DateTimeKind.Utc).AddTicks(7116), new DateTime(2022, 12, 12, 16, 17, 48, 530, DateTimeKind.Utc).AddTicks(4117) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 30, 10, 14, 16, 728, DateTimeKind.Utc).AddTicks(3140), new DateTime(2023, 3, 14, 5, 40, 8, 885, DateTimeKind.Utc).AddTicks(2330), new DateTime(2023, 2, 18, 12, 45, 2, 422, DateTimeKind.Utc).AddTicks(4190), new DateTime(2023, 5, 5, 0, 10, 6, 100, DateTimeKind.Utc).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 11, 8, 53, 13, 572, DateTimeKind.Utc).AddTicks(578), new DateTime(2022, 12, 2, 0, 21, 57, 549, DateTimeKind.Utc).AddTicks(535), new DateTime(2017, 4, 19, 8, 24, 42, 710, DateTimeKind.Utc).AddTicks(3861), new DateTime(2023, 7, 15, 10, 37, 53, 584, DateTimeKind.Utc).AddTicks(7971) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 23, 0, 40, 52, 810, DateTimeKind.Utc).AddTicks(8985), new DateTime(2023, 1, 15, 10, 29, 1, 623, DateTimeKind.Utc).AddTicks(69), new DateTime(2022, 11, 1, 6, 19, 38, 67, DateTimeKind.Utc).AddTicks(2104), new DateTime(2023, 3, 15, 3, 6, 56, 895, DateTimeKind.Utc).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 3, 22, 23, 16, 56, DateTimeKind.Utc).AddTicks(1062), new DateTime(2022, 8, 22, 17, 6, 22, 183, DateTimeKind.Utc).AddTicks(6915), new DateTime(2021, 10, 11, 10, 31, 46, 186, DateTimeKind.Utc).AddTicks(9888), new DateTime(2023, 4, 4, 14, 59, 34, 573, DateTimeKind.Utc).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 9, 11, 14, 30, 40, DateTimeKind.Utc).AddTicks(2503), new DateTime(2023, 3, 30, 12, 14, 22, 518, DateTimeKind.Utc).AddTicks(2918), new DateTime(2019, 11, 4, 21, 1, 39, 428, DateTimeKind.Utc).AddTicks(195), new DateTime(2020, 8, 26, 21, 24, 7, 657, DateTimeKind.Utc).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 12, 8, 40, 48, 957, DateTimeKind.Utc).AddTicks(3199), new DateTime(2023, 5, 15, 18, 17, 56, 69, DateTimeKind.Utc).AddTicks(5771), new DateTime(2022, 3, 2, 14, 23, 27, 561, DateTimeKind.Utc).AddTicks(9110), new DateTime(2022, 7, 13, 20, 0, 27, 228, DateTimeKind.Utc).AddTicks(3210) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 27, 11, 35, 28, 323, DateTimeKind.Utc).AddTicks(3105), new DateTime(2022, 10, 28, 17, 4, 0, 187, DateTimeKind.Utc).AddTicks(7151), new DateTime(2022, 6, 2, 10, 42, 0, 65, DateTimeKind.Utc).AddTicks(8700), new DateTime(2023, 4, 11, 19, 38, 28, 220, DateTimeKind.Utc).AddTicks(348) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 6, 7, 18, 3, 20, 852, DateTimeKind.Utc).AddTicks(7879), new DateTime(2021, 8, 10, 2, 57, 52, 115, DateTimeKind.Utc).AddTicks(1371), new DateTime(2021, 6, 23, 10, 49, 28, 603, DateTimeKind.Utc).AddTicks(7265), new DateTime(2022, 4, 6, 0, 39, 27, 592, DateTimeKind.Utc).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 10, 21, 33, 33, 31, DateTimeKind.Utc).AddTicks(669), new DateTime(2023, 9, 3, 20, 26, 34, 155, DateTimeKind.Utc).AddTicks(8610), new DateTime(2019, 3, 25, 15, 50, 45, 177, DateTimeKind.Utc).AddTicks(6630), new DateTime(2020, 11, 15, 18, 56, 7, 745, DateTimeKind.Utc).AddTicks(714) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 3, 8, 53, 18, 875, DateTimeKind.Utc).AddTicks(20), new DateTime(2022, 10, 25, 6, 34, 33, 290, DateTimeKind.Utc).AddTicks(217), new DateTime(2022, 6, 16, 5, 2, 50, 332, DateTimeKind.Utc).AddTicks(1618), new DateTime(2022, 12, 21, 14, 3, 41, 790, DateTimeKind.Utc).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2018, 4, 5, 8, 30, 3, 275, DateTimeKind.Utc).AddTicks(8075), new DateTime(2018, 3, 19, 6, 45, 5, 753, DateTimeKind.Utc).AddTicks(6963), new DateTime(2017, 9, 19, 20, 50, 33, 396, DateTimeKind.Utc).AddTicks(1010), new DateTime(2019, 7, 11, 18, 58, 49, 772, DateTimeKind.Utc).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 8, 2, 0, 29, 10, 808, DateTimeKind.Utc).AddTicks(495), new DateTime(2023, 8, 6, 11, 42, 42, 825, DateTimeKind.Utc).AddTicks(5240), new DateTime(2023, 7, 5, 6, 15, 45, 354, DateTimeKind.Utc).AddTicks(5658), new DateTime(2023, 7, 10, 23, 48, 19, 297, DateTimeKind.Utc).AddTicks(2915) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 1, 23, 36, 375, DateTimeKind.Utc).AddTicks(7924), new DateTime(2023, 1, 23, 3, 39, 48, 138, DateTimeKind.Utc).AddTicks(4727), new DateTime(2021, 7, 6, 8, 42, 40, 459, DateTimeKind.Utc).AddTicks(6102), new DateTime(2022, 11, 3, 8, 19, 13, 286, DateTimeKind.Utc).AddTicks(9966) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 3, 21, 15, 6, 33, 721, DateTimeKind.Utc).AddTicks(8598), new DateTime(2022, 2, 25, 12, 32, 15, 962, DateTimeKind.Utc).AddTicks(922), new DateTime(2021, 10, 31, 2, 30, 21, 75, DateTimeKind.Utc).AddTicks(9204), new DateTime(2023, 2, 6, 20, 8, 55, 468, DateTimeKind.Utc).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 12, 39, 50, 804, DateTimeKind.Utc).AddTicks(6044), new DateTime(2023, 4, 28, 4, 25, 43, 235, DateTimeKind.Utc).AddTicks(5273), new DateTime(2022, 10, 12, 22, 42, 18, 242, DateTimeKind.Utc).AddTicks(8118), new DateTime(2023, 8, 25, 4, 42, 16, 757, DateTimeKind.Utc).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 1, 23, 44, 446, DateTimeKind.Utc).AddTicks(8099), new DateTime(2023, 8, 17, 6, 11, 43, 449, DateTimeKind.Utc).AddTicks(4144), new DateTime(2022, 3, 11, 5, 48, 16, 973, DateTimeKind.Utc).AddTicks(2387), new DateTime(2022, 8, 25, 13, 20, 34, 102, DateTimeKind.Utc).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 5, 17, 4, 785, DateTimeKind.Utc).AddTicks(5432), new DateTime(2023, 6, 25, 18, 7, 8, 570, DateTimeKind.Utc).AddTicks(3986), new DateTime(2021, 7, 8, 7, 42, 15, 453, DateTimeKind.Utc).AddTicks(4775), new DateTime(2021, 12, 12, 3, 38, 5, 220, DateTimeKind.Utc).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 4, 7, 22, 53, 158, DateTimeKind.Utc).AddTicks(2447), new DateTime(2023, 8, 17, 16, 19, 19, 985, DateTimeKind.Utc).AddTicks(5274), new DateTime(2023, 7, 4, 17, 52, 17, 683, DateTimeKind.Utc).AddTicks(5162), new DateTime(2023, 9, 5, 12, 34, 13, 632, DateTimeKind.Utc).AddTicks(3482) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 8, 12, 22, 4, 435, DateTimeKind.Utc).AddTicks(1187), new DateTime(2023, 5, 13, 9, 49, 46, 508, DateTimeKind.Utc).AddTicks(5776), new DateTime(2023, 3, 23, 11, 39, 31, 225, DateTimeKind.Utc).AddTicks(429), new DateTime(2023, 3, 29, 2, 22, 0, 521, DateTimeKind.Utc).AddTicks(2474) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 19, 5, 40, 3, 517, DateTimeKind.Utc).AddTicks(2613), new DateTime(2022, 12, 31, 22, 57, 36, 935, DateTimeKind.Utc).AddTicks(460), new DateTime(2022, 2, 21, 4, 3, 10, 831, DateTimeKind.Utc).AddTicks(9383), new DateTime(2022, 7, 18, 11, 29, 30, 25, DateTimeKind.Utc).AddTicks(2851) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 3, 20, 56, 29, 948, DateTimeKind.Utc).AddTicks(3107), new DateTime(2023, 6, 4, 9, 48, 4, 415, DateTimeKind.Utc).AddTicks(8768), new DateTime(2022, 1, 8, 23, 56, 41, 776, DateTimeKind.Utc).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 4, 16, 37, 52, 693, DateTimeKind.Utc).AddTicks(1020), new DateTime(2022, 12, 29, 17, 40, 17, 700, DateTimeKind.Utc).AddTicks(2298), new DateTime(2022, 11, 10, 13, 40, 29, 305, DateTimeKind.Utc).AddTicks(9669), new DateTime(2023, 9, 4, 5, 43, 38, 486, DateTimeKind.Utc).AddTicks(3696) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 20, 49, 44, 626, DateTimeKind.Utc).AddTicks(7193), new DateTime(2018, 11, 23, 12, 19, 11, 206, DateTimeKind.Utc).AddTicks(3405), new DateTime(2017, 4, 11, 18, 33, 53, 408, DateTimeKind.Utc).AddTicks(7372), new DateTime(2017, 12, 27, 15, 31, 31, 319, DateTimeKind.Utc).AddTicks(3532) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 6, 21, 50, 9, 797, DateTimeKind.Utc).AddTicks(6594), new DateTime(2022, 9, 27, 17, 18, 25, 102, DateTimeKind.Utc).AddTicks(7862), new DateTime(2021, 11, 1, 3, 2, 9, 24, DateTimeKind.Utc).AddTicks(4985), new DateTime(2022, 8, 6, 7, 36, 31, 28, DateTimeKind.Utc).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 12, 14, 15, 28, 540, DateTimeKind.Utc).AddTicks(2153), new DateTime(2023, 9, 8, 15, 35, 18, 755, DateTimeKind.Utc).AddTicks(1525), new DateTime(2023, 9, 6, 16, 3, 54, 78, DateTimeKind.Utc).AddTicks(6324), new DateTime(2023, 9, 8, 20, 6, 10, 228, DateTimeKind.Utc).AddTicks(2903) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 10, 23, 1, 47, 57, 626, DateTimeKind.Utc).AddTicks(4711), new DateTime(2021, 11, 24, 6, 40, 41, 279, DateTimeKind.Utc).AddTicks(5937), new DateTime(2018, 4, 20, 18, 10, 22, 531, DateTimeKind.Utc).AddTicks(7775), new DateTime(2019, 7, 12, 10, 29, 4, 367, DateTimeKind.Utc).AddTicks(3628) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 5, 50, 1, 856, DateTimeKind.Utc).AddTicks(706), new DateTime(2023, 9, 8, 10, 59, 8, 369, DateTimeKind.Utc).AddTicks(8453), new DateTime(2023, 8, 31, 21, 33, 31, 911, DateTimeKind.Utc).AddTicks(2449), new DateTime(2023, 9, 4, 17, 19, 22, 693, DateTimeKind.Utc).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 6, 7, 5, 2, 8, 291, DateTimeKind.Utc).AddTicks(4339), new DateTime(2023, 4, 9, 13, 0, 44, 385, DateTimeKind.Utc).AddTicks(9814), new DateTime(2016, 11, 13, 17, 54, 34, 478, DateTimeKind.Utc).AddTicks(4627), new DateTime(2020, 9, 27, 18, 27, 57, 280, DateTimeKind.Utc).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 11, 7, 28, 25, 24, DateTimeKind.Utc).AddTicks(7499), new DateTime(2023, 4, 7, 9, 52, 18, 795, DateTimeKind.Utc).AddTicks(4656), new DateTime(2022, 9, 3, 19, 44, 39, 726, DateTimeKind.Utc).AddTicks(6240), new DateTime(2023, 8, 20, 6, 58, 16, 836, DateTimeKind.Utc).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 4, 23, 23, 55, 112, DateTimeKind.Utc).AddTicks(1962), new DateTime(2023, 4, 10, 8, 17, 11, 181, DateTimeKind.Utc).AddTicks(8331), new DateTime(2023, 4, 5, 5, 8, 14, 836, DateTimeKind.Utc).AddTicks(3214), new DateTime(2023, 8, 6, 18, 10, 8, 979, DateTimeKind.Utc).AddTicks(3517) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 2, 11, 18, 29, 25, 336, DateTimeKind.Utc).AddTicks(9802), new DateTime(2021, 1, 29, 1, 27, 9, 588, DateTimeKind.Utc).AddTicks(4088), new DateTime(2019, 6, 24, 7, 19, 38, 133, DateTimeKind.Utc).AddTicks(4831), new DateTime(2022, 10, 3, 20, 9, 12, 145, DateTimeKind.Utc).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 22, 5, 13, 45, 920, DateTimeKind.Utc).AddTicks(9436), new DateTime(2023, 5, 7, 23, 34, 18, 465, DateTimeKind.Utc).AddTicks(7675), new DateTime(2022, 9, 26, 19, 15, 26, 573, DateTimeKind.Utc).AddTicks(9646), new DateTime(2023, 1, 13, 12, 40, 39, 847, DateTimeKind.Utc).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 23, 6, 54, 248, DateTimeKind.Utc).AddTicks(9938), new DateTime(2023, 6, 3, 15, 18, 1, 94, DateTimeKind.Utc).AddTicks(6361), new DateTime(2019, 4, 6, 10, 4, 56, 167, DateTimeKind.Utc).AddTicks(9433) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 9, 26, 3, 49, 59, 304, DateTimeKind.Utc).AddTicks(9731), new DateTime(2021, 9, 29, 20, 59, 37, 359, DateTimeKind.Utc).AddTicks(9366), new DateTime(2021, 4, 4, 4, 47, 16, 765, DateTimeKind.Utc).AddTicks(4923), new DateTime(2023, 6, 3, 14, 59, 47, 260, DateTimeKind.Utc).AddTicks(8016) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 6, 0, 32, 6, 380, DateTimeKind.Utc).AddTicks(2130), new DateTime(2023, 8, 1, 0, 39, 55, 602, DateTimeKind.Utc).AddTicks(1702), new DateTime(2023, 7, 19, 18, 35, 8, 803, DateTimeKind.Utc).AddTicks(696), new DateTime(2023, 8, 18, 1, 40, 53, 638, DateTimeKind.Utc).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 29, 2, 13, 47, 247, DateTimeKind.Utc).AddTicks(9231), new DateTime(2023, 6, 10, 13, 15, 3, 668, DateTimeKind.Utc).AddTicks(5825), new DateTime(2023, 1, 17, 8, 15, 40, 568, DateTimeKind.Utc).AddTicks(5967), new DateTime(2023, 3, 23, 6, 39, 29, 440, DateTimeKind.Utc).AddTicks(5751) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 21, 7, 18, 39, 863, DateTimeKind.Utc).AddTicks(8878), new DateTime(2023, 2, 3, 16, 39, 57, 270, DateTimeKind.Utc).AddTicks(8553), new DateTime(2022, 5, 27, 21, 13, 27, 389, DateTimeKind.Utc).AddTicks(7977), new DateTime(2023, 3, 4, 23, 43, 9, 315, DateTimeKind.Utc).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 5, 18, 10, 16, 7, 885, DateTimeKind.Utc).AddTicks(9436), new DateTime(2020, 6, 25, 0, 48, 26, 103, DateTimeKind.Utc).AddTicks(8329), new DateTime(2017, 10, 11, 21, 41, 33, 204, DateTimeKind.Utc).AddTicks(2335), new DateTime(2018, 6, 1, 4, 55, 50, 160, DateTimeKind.Utc).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 3, 14, 11, 31, 463, DateTimeKind.Utc).AddTicks(666), new DateTime(2023, 7, 23, 6, 35, 41, 444, DateTimeKind.Utc).AddTicks(5943), new DateTime(2021, 5, 19, 3, 43, 30, 808, DateTimeKind.Utc).AddTicks(7334), new DateTime(2021, 10, 11, 6, 26, 32, 972, DateTimeKind.Utc).AddTicks(661) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 20, 6, 30, 18, 341, DateTimeKind.Utc).AddTicks(4667), new DateTime(2023, 2, 25, 17, 11, 35, 89, DateTimeKind.Utc).AddTicks(7753), new DateTime(2022, 12, 17, 2, 58, 22, 48, DateTimeKind.Utc).AddTicks(7265), new DateTime(2023, 2, 10, 11, 53, 4, 751, DateTimeKind.Utc).AddTicks(6232) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 7, 18, 58, 46, 640, DateTimeKind.Utc).AddTicks(3555), new DateTime(2023, 8, 1, 15, 15, 34, 775, DateTimeKind.Utc).AddTicks(1480), new DateTime(2022, 12, 30, 19, 56, 48, 174, DateTimeKind.Utc).AddTicks(7254), new DateTime(2023, 8, 6, 16, 54, 39, 688, DateTimeKind.Utc).AddTicks(156) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 8, 26, 6, 5, 4, 69, DateTimeKind.Utc).AddTicks(6840), new DateTime(2022, 5, 24, 9, 1, 30, 687, DateTimeKind.Utc).AddTicks(3018), new DateTime(2021, 7, 5, 18, 57, 0, 732, DateTimeKind.Utc).AddTicks(9747), new DateTime(2022, 1, 27, 14, 17, 42, 97, DateTimeKind.Utc).AddTicks(1515) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 22, 55, 24, 798, DateTimeKind.Utc).AddTicks(7457), new DateTime(2023, 9, 1, 4, 26, 54, 178, DateTimeKind.Utc).AddTicks(7033), new DateTime(2023, 6, 14, 20, 3, 25, 59, DateTimeKind.Utc).AddTicks(19), new DateTime(2023, 7, 29, 1, 21, 6, 955, DateTimeKind.Utc).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 28, 9, 2, 11, 637, DateTimeKind.Utc).AddTicks(6265), new DateTime(2023, 8, 29, 21, 1, 50, 922, DateTimeKind.Utc).AddTicks(8927), new DateTime(2023, 8, 11, 1, 23, 50, 690, DateTimeKind.Utc).AddTicks(4726), new DateTime(2023, 8, 26, 3, 22, 56, 820, DateTimeKind.Utc).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 4, 3, 18, 49, 31, 103, DateTimeKind.Utc).AddTicks(2357), new DateTime(2020, 12, 12, 19, 53, 45, 502, DateTimeKind.Utc).AddTicks(9305), new DateTime(2019, 10, 9, 18, 37, 33, 679, DateTimeKind.Utc).AddTicks(8245), new DateTime(2023, 7, 30, 13, 13, 22, 304, DateTimeKind.Utc).AddTicks(925) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 20, 49, 12, 841, DateTimeKind.Utc).AddTicks(1722), new DateTime(2023, 4, 19, 14, 49, 13, 50, DateTimeKind.Utc).AddTicks(2135), new DateTime(2022, 11, 16, 16, 42, 30, 934, DateTimeKind.Utc).AddTicks(6028), new DateTime(2023, 1, 19, 19, 42, 30, 19, DateTimeKind.Utc).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 1, 5, 1, 57, 9, 336, DateTimeKind.Utc).AddTicks(2158), new DateTime(2022, 9, 3, 9, 6, 30, 79, DateTimeKind.Utc).AddTicks(9442), new DateTime(2022, 8, 22, 10, 55, 35, 279, DateTimeKind.Utc).AddTicks(5363), new DateTime(2023, 1, 28, 13, 49, 0, 189, DateTimeKind.Utc).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 10, 24, 22, 6, 11, 353, DateTimeKind.Utc).AddTicks(8514), new DateTime(2019, 11, 16, 2, 37, 40, 459, DateTimeKind.Utc).AddTicks(7929), new DateTime(2017, 6, 28, 8, 32, 32, 120, DateTimeKind.Utc).AddTicks(8243), new DateTime(2018, 8, 8, 16, 20, 34, 49, DateTimeKind.Utc).AddTicks(2003) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 29, 4, 48, 9, 679, DateTimeKind.Utc).AddTicks(8844), new DateTime(2023, 7, 25, 16, 29, 13, 693, DateTimeKind.Utc).AddTicks(9514), new DateTime(2023, 7, 1, 1, 44, 29, 627, DateTimeKind.Utc).AddTicks(8154), new DateTime(2023, 7, 15, 20, 32, 46, 730, DateTimeKind.Utc).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 22, 21, 51, 27, 923, DateTimeKind.Utc).AddTicks(685), new DateTime(2022, 11, 26, 11, 4, 32, 206, DateTimeKind.Utc).AddTicks(2906), new DateTime(2022, 5, 12, 20, 56, 12, 566, DateTimeKind.Utc).AddTicks(5958), new DateTime(2023, 1, 9, 2, 24, 50, 389, DateTimeKind.Utc).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 1, 5, 8, 30, 28, 364, DateTimeKind.Utc).AddTicks(3), new DateTime(2020, 5, 1, 10, 24, 31, 374, DateTimeKind.Utc).AddTicks(6839), new DateTime(2019, 8, 30, 12, 48, 29, 886, DateTimeKind.Utc).AddTicks(8999), new DateTime(2020, 12, 2, 14, 37, 32, 801, DateTimeKind.Utc).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 7, 23, 59, 27, 805, DateTimeKind.Utc).AddTicks(4725), new DateTime(2023, 8, 10, 14, 27, 44, 898, DateTimeKind.Utc).AddTicks(9001), new DateTime(2023, 5, 2, 1, 13, 43, 263, DateTimeKind.Utc).AddTicks(7144), new DateTime(2023, 8, 27, 21, 8, 52, 66, DateTimeKind.Utc).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 22, 18, 7, 4, 64, DateTimeKind.Utc).AddTicks(1614), new DateTime(2022, 8, 18, 12, 7, 59, 429, DateTimeKind.Utc).AddTicks(7332), new DateTime(2022, 6, 18, 21, 12, 58, 415, DateTimeKind.Utc).AddTicks(7930), new DateTime(2022, 10, 9, 23, 30, 25, 875, DateTimeKind.Utc).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 10, 21, 24, 43, 925, DateTimeKind.Utc).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 30, 4, 44, 12, 468, DateTimeKind.Utc).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 20, 18, 11, 4, 334, DateTimeKind.Utc).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 21, 53, 23, 548, DateTimeKind.Utc).AddTicks(3126));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 23, 19, 27, 39, 949, DateTimeKind.Utc).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 19, 8, 32, 52, 190, DateTimeKind.Utc).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 18, 0, 59, 48, 577, DateTimeKind.Utc).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 7, 59, 4, 582, DateTimeKind.Utc).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 3, 7, 13, 46, 616, DateTimeKind.Utc).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 21, 9, 29, 1, 196, DateTimeKind.Utc).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 18, 6, 53, 27, 580, DateTimeKind.Utc).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 14, 22, 25, 44, 573, DateTimeKind.Utc).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 2, 11, 48, 25, 605, DateTimeKind.Utc).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 17, 4, 19, 605, DateTimeKind.Utc).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 1, 18, 4, 23, 761, DateTimeKind.Utc).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 14, 20, 10, 16, 238, DateTimeKind.Utc).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 8, 20, 30, 45, 384, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 12, 15, 46, 27, 98, DateTimeKind.Utc).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 13, 1, 37, 29, 732, DateTimeKind.Utc).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 3, 17, 57, 13, 121, DateTimeKind.Utc).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 26, 11, 30, 45, 190, DateTimeKind.Utc).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 11, 2, 58, 42, 925, DateTimeKind.Utc).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 30, 13, 30, 34, 972, DateTimeKind.Utc).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 15, 18, 22, 47, 75, DateTimeKind.Utc).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 22, 12, 37, 55, 555, DateTimeKind.Utc).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 7, 23, 7, 3, 828, DateTimeKind.Utc).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 19, 4, 23, 23, 953, DateTimeKind.Utc).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 25, 17, 2, 19, 861, DateTimeKind.Utc).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 15, 3, 16, 46, 137, DateTimeKind.Utc).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 5, 45, 51, 91, DateTimeKind.Utc).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 26, 14, 21, 49, 412, DateTimeKind.Utc).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 20, 21, 3, 952, DateTimeKind.Utc).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 6, 6, 48, 41, 21, DateTimeKind.Utc).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 0, 47, 47, 546, DateTimeKind.Utc).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedAt",
                value: new DateTime(2020, 3, 27, 5, 1, 9, 388, DateTimeKind.Utc).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 8, 21, 24, 546, DateTimeKind.Utc).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 22, 28, 26, 210, DateTimeKind.Utc).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 2, 2, 28, 31, 286, DateTimeKind.Utc).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 11, 7, 24, 37, 393, DateTimeKind.Utc).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 15, 9, 37, 24, 147, DateTimeKind.Utc).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 24, 12, 28, 4, 586, DateTimeKind.Utc).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 6, 46, 31, 582, DateTimeKind.Utc).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 9, 32, 24, 614, DateTimeKind.Utc).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 27, 3, 48, 42, 734, DateTimeKind.Utc).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 10, 14, 7, 51, 173, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 22, 17, 29, 790, DateTimeKind.Utc).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedAt",
                value: new DateTime(2021, 6, 6, 14, 1, 53, 587, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 48L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 15, 1, 24, 0, 426, DateTimeKind.Utc).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 11, 17, 55, 329, DateTimeKind.Utc).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 7, 5, 58, 859, DateTimeKind.Utc).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 7, 46, 10, 665, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 10, 46, 1, 368, DateTimeKind.Utc).AddTicks(4528));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 15, 14, 38, 45, 65, DateTimeKind.Utc).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 20, 16, 49, 14, 661, DateTimeKind.Utc).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 2, 39, 48, 631, DateTimeKind.Utc).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 56L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 12, 20, 28, 53, 580, DateTimeKind.Utc).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 5, 29, 38, 134, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 25, 21, 58, 55, 549, DateTimeKind.Utc).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 7, 1, 59, 18, 454, DateTimeKind.Utc).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 16, 4, 21, 23, 481, DateTimeKind.Utc).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 25, 18, 21, 0, 606, DateTimeKind.Utc).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 4, 19, 58, 907, DateTimeKind.Utc).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 14, 44, 19, 975, DateTimeKind.Utc).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 64L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 20, 14, 11, 29, 693, DateTimeKind.Utc).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 3, 11, 28, 57, 327, DateTimeKind.Utc).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 18, 54, 5, 904, DateTimeKind.Utc).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 14, 12, 42, 23, 831, DateTimeKind.Utc).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 25, 11, 1, 22, 921, DateTimeKind.Utc).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 22, 24, 41, 377, DateTimeKind.Utc).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 30, 13, 45, 17, 754, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 8, 15, 14, 6, 610, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 72L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 19, 3, 59, 20, 748, DateTimeKind.Utc).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 28, 4, 15, 29, 193, DateTimeKind.Utc).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 17, 57, 24, 138, DateTimeKind.Utc).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 13, 6, 15, 28, 503, DateTimeKind.Utc).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 31, 14, 28, 25, 290, DateTimeKind.Utc).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 1, 11, 9, 50, 690, DateTimeKind.Utc).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 13, 47, 56, 201, DateTimeKind.Utc).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 21, 15, 10, 7, 969, DateTimeKind.Utc).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 80L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 7, 0, 28, 153, DateTimeKind.Utc).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 25, 16, 41, 18, 169, DateTimeKind.Utc).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 20, 42, 54, 85, DateTimeKind.Utc).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 19, 31, 50, 38, DateTimeKind.Utc).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedAt",
                value: new DateTime(2020, 2, 3, 17, 25, 51, 348, DateTimeKind.Utc).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 11, 5, 43, 25, 695, DateTimeKind.Utc).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 4, 37, 39, 814, DateTimeKind.Utc).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 15, 8, 5, 26, 669, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 88L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 28, 3, 13, 55, 164, DateTimeKind.Utc).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 24, 19, 37, 24, 259, DateTimeKind.Utc).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 29, 15, 2, 27, 283, DateTimeKind.Utc).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 20, 18, 27, 29, 582, DateTimeKind.Utc).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 10, 5, 52, 48, 507, DateTimeKind.Utc).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 12, 12, 34, 13, 299, DateTimeKind.Utc).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 26, 5, 8, 48, 652, DateTimeKind.Utc).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 30, 2, 38, 36, 488, DateTimeKind.Utc).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 96L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 8, 5, 15, 17, 822, DateTimeKind.Utc).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 20, 34, 3, 735, DateTimeKind.Utc).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 14, 8, 23, 11, 851, DateTimeKind.Utc).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 18, 5, 52, 50, 13, DateTimeKind.Utc).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 23, 16, 6, 37, 92, DateTimeKind.Utc).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 23, 52, 24, 189, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 7, 4, 23, 33, 422, DateTimeKind.Utc).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 3, 11, 56, 50, 132, DateTimeKind.Utc).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 104L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 7, 0, 32, 29, 38, DateTimeKind.Utc).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 22, 17, 49, 57, 484, DateTimeKind.Utc).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedAt",
                value: new DateTime(2021, 12, 12, 15, 21, 13, 513, DateTimeKind.Utc).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 4, 17, 36, 46, 803, DateTimeKind.Utc).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 30, 11, 49, 59, 517, DateTimeKind.Utc).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 29, 18, 4, 41, 855, DateTimeKind.Utc).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 28, 16, 58, 3, 779, DateTimeKind.Utc).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 2, 22, 39, 44, 613, DateTimeKind.Utc).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 112L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 8, 10, 43, 932, DateTimeKind.Utc).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 22, 17, 16, 18, 424, DateTimeKind.Utc).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 3, 15, 29, 15, 775, DateTimeKind.Utc).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 7, 4, 22, 50, 472, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 7, 21, 38, 9, 95, DateTimeKind.Utc).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedAt",
                value: new DateTime(2022, 1, 2, 17, 7, 44, 173, DateTimeKind.Utc).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedAt",
                value: new DateTime(2022, 1, 27, 11, 14, 56, 645, DateTimeKind.Utc).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 11, 43, 2, 864, DateTimeKind.Utc).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 120L,
                column: "CreatedAt",
                value: new DateTime(2022, 1, 9, 12, 46, 38, 747, DateTimeKind.Utc).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 18, 17, 31, 750, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 10, 10, 7, 50, 771, DateTimeKind.Utc).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 20, 22, 31, 59, 599, DateTimeKind.Utc).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 2, 21, 15, 49, 404, DateTimeKind.Utc).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 7, 9, 0, 27, 440, DateTimeKind.Utc).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 20, 5, 22, 16, 842, DateTimeKind.Utc).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 0, 20, 1, 384, DateTimeKind.Utc).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 128L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 18, 31, 19, 948, DateTimeKind.Utc).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 16, 53, 51, 209, DateTimeKind.Utc).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 1, 33, 43, 922, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 5, 9, 4, 468, DateTimeKind.Utc).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 22, 35, 13, 996, DateTimeKind.Utc).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 24, 1, 48, 2, 543, DateTimeKind.Utc).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 31, 4, 23, 44, 849, DateTimeKind.Utc).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 11, 27, 2, 894, DateTimeKind.Utc).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 136L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 10, 6, 34, 43, 733, DateTimeKind.Utc).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 21, 5, 44, 54, 527, DateTimeKind.Utc).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 10, 4, 29, 13, 933, DateTimeKind.Utc).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 20, 20, 33, 356, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 5, 21, 8, 16, 445, DateTimeKind.Utc).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 12, 30, 31, 265, DateTimeKind.Utc).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 23, 5, 1, 11, 581, DateTimeKind.Utc).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 7, 18, 45, 58, 78, DateTimeKind.Utc).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 144L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 10, 18, 29, 18, 30, DateTimeKind.Utc).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 18, 7, 34, 427, DateTimeKind.Utc).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedAt",
                value: new DateTime(2021, 12, 14, 21, 50, 54, 682, DateTimeKind.Utc).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 6, 17, 34, 50, 269, DateTimeKind.Utc).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 4, 3, 19, 46, 342, DateTimeKind.Utc).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 26, 6, 57, 42, 503, DateTimeKind.Utc).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 7, 12, 53, 31, 25, DateTimeKind.Utc).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 8, 42, 53, 450, DateTimeKind.Utc).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 152L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 19, 17, 55, 31, 704, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 18, 4, 55, 57, 557, DateTimeKind.Utc).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 11, 7, 1, 13, 988, DateTimeKind.Utc).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 31, 22, 45, 17, 730, DateTimeKind.Utc).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 16, 15, 33, 34, 568, DateTimeKind.Utc).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 29, 8, 55, 9, 499, DateTimeKind.Utc).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 8, 0, 49, 13, 4, DateTimeKind.Utc).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 26, 21, 43, 6, 264, DateTimeKind.Utc).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 160L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 24, 21, 20, 46, 377, DateTimeKind.Utc).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 7, 3, 43, 30, 437, DateTimeKind.Utc).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 13, 16, 52, 33, 273, DateTimeKind.Utc).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 26, 21, 5, 41, 633, DateTimeKind.Utc).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 20, 42, 54, 506, DateTimeKind.Utc).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 12, 2, 6, 31, 351, DateTimeKind.Utc).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 11, 58, 46, 596, DateTimeKind.Utc).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 7, 21, 32, 3, 935, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 168L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 16, 53, 14, 526, DateTimeKind.Utc).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 30, 7, 38, 53, 665, DateTimeKind.Utc).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 20, 11, 57, 732, DateTimeKind.Utc).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 12, 15, 58, 16, 904, DateTimeKind.Utc).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 7, 0, 24, 40, 494, DateTimeKind.Utc).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 11, 14, 19, 35, 334, DateTimeKind.Utc).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 5, 10, 24, 18, 80, DateTimeKind.Utc).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 11, 11, 32, 48, 420, DateTimeKind.Utc).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 176L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 12, 3, 28, 49, 843, DateTimeKind.Utc).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 5, 7, 23, 24, 561, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 14, 18, 55, 59, 317, DateTimeKind.Utc).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 8, 19, 37, 56, 511, DateTimeKind.Utc).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 2, 7, 5, 35, 730, DateTimeKind.Utc).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 14, 23, 2, 8, 485, DateTimeKind.Utc).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 30, 11, 53, 23, 880, DateTimeKind.Utc).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 2, 5, 5, 980, DateTimeKind.Utc).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 184L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 9, 35, 9, 136, DateTimeKind.Utc).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 2, 9, 10, 12, 487, DateTimeKind.Utc).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 19, 11, 45, 0, 57, DateTimeKind.Utc).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 20, 19, 28, 44, DateTimeKind.Utc).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 17, 21, 11, 205, DateTimeKind.Utc).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 0, 48, 33, 511, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 28, 8, 50, 8, 370, DateTimeKind.Utc).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 16, 2, 13, 0, 838, DateTimeKind.Utc).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 192L,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 14, 11, 38, 5, 705, DateTimeKind.Utc).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 9, 15, 56, 19, 866, DateTimeKind.Utc).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 26, 20, 7, 12, 193, DateTimeKind.Utc).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 5, 1, 17, 43, 627, DateTimeKind.Utc).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 2, 0, 4, 50, 349, DateTimeKind.Utc).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 4, 53, 22, 509, DateTimeKind.Utc).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 11, 13, 17, 51, 125, DateTimeKind.Utc).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 19, 9, 52, 7, 828, DateTimeKind.Utc).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 200L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 6, 11, 9, 49, 16, DateTimeKind.Utc).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(5916), 18L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6258), 32L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6284), 34L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6297), 3L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6309), 10L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6323), 32L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6335), 21L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6347), 18L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BadgeId", "CreatedAt" },
                values: new object[] { 12L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6359) });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6371), 16L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6383), 14L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6395), 3L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6407), 13L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6419), 23L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6432), 27L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6444), 18L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6456), 40L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6467), 27L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6479), 23L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6492), 30L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6504), 38L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6517), 7L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6528), 38L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6540), 28L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6551), 18L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "BadgeId", "CreatedAt" },
                values: new object[] { 12L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6577), 19L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6705), 31L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6729), 39L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6742), 2L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6753), 7L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6764), 24L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6774), 24L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6785), 28L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6796), 27L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6807), 4L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6817), 4L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6829), 15L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6840), 36L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6852), 31L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6864), 31L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6876), 28L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6888), 40L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 11L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6900), 14L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6912), 24L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6923), 27L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6935), 9L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 12L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6947), 20L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6959), 20L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6971), 18L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 11L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6982), 6L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(6994), 26L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(7006), 21L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(7018), 32L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(7029), 39L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(7093), 10L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(7109), 5L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "BadgeId", "CreatedAt" },
                values: new object[] { 2L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(7134), 40L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(7146), 20L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(7157), 16L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(7169), 2L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 11L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(7181), 37L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 11L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(7194), 25L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(7207), 36L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(7218), 10L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(7230), 20L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(7242), 35L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(7255), 11L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(7270), 7L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 11L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(7300), 36L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(7331), 39L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(7349), 35L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(7361), 13L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(7372), 20L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 12L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(7383), 4L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(7395), 21L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(7407), 40L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 12L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(7419), 31L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2023, 9, 11, 15, 9, 29, 963, DateTimeKind.Local).AddTicks(7431), 29L });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 24, 14, 51, 53, 71, DateTimeKind.Utc).AddTicks(9990), new DateTime(2023, 9, 8, 13, 19, 59, 799, DateTimeKind.Utc).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 5, 19, 15, 36, 839, DateTimeKind.Utc).AddTicks(9537), new DateTime(2023, 9, 9, 5, 35, 59, 643, DateTimeKind.Utc).AddTicks(899) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 21, 21, 32, 1, 47, DateTimeKind.Utc).AddTicks(5630), new DateTime(2023, 9, 10, 18, 45, 50, 537, DateTimeKind.Utc).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 12, 6, 9, 56, 653, DateTimeKind.Utc).AddTicks(2095), new DateTime(2023, 4, 23, 6, 55, 49, 132, DateTimeKind.Utc).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 2, 4, 25, 35, 779, DateTimeKind.Utc).AddTicks(732), new DateTime(2023, 8, 18, 20, 18, 27, 734, DateTimeKind.Utc).AddTicks(6141) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 30, 9, 22, 34, 619, DateTimeKind.Utc).AddTicks(7311), new DateTime(2023, 6, 1, 6, 45, 13, 709, DateTimeKind.Utc).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 15, 56, 6, 399, DateTimeKind.Utc).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 26, 37, 588, DateTimeKind.Utc).AddTicks(3056), new DateTime(2023, 8, 29, 11, 11, 7, 928, DateTimeKind.Utc).AddTicks(1762) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 10, 2, 18, 55, 26, 571, DateTimeKind.Utc).AddTicks(922), new DateTime(2023, 5, 17, 12, 52, 35, 749, DateTimeKind.Utc).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 24, 21, 19, 51, 774, DateTimeKind.Utc).AddTicks(1709), new DateTime(2023, 8, 7, 5, 58, 9, 300, DateTimeKind.Utc).AddTicks(5182) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 14, 1, 10, 28, 97, DateTimeKind.Utc).AddTicks(2033), new DateTime(2023, 5, 18, 21, 1, 43, 117, DateTimeKind.Utc).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 16, 23, 7, 38, 172, DateTimeKind.Utc).AddTicks(8606), new DateTime(2023, 7, 1, 10, 41, 54, 484, DateTimeKind.Utc).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 13, 18, 56, 47, 713, DateTimeKind.Utc).AddTicks(9515), new DateTime(2023, 9, 7, 11, 5, 56, 28, DateTimeKind.Utc).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 23, 22, 35, 34, 752, DateTimeKind.Utc).AddTicks(5231), new DateTime(2023, 9, 5, 15, 6, 29, 912, DateTimeKind.Utc).AddTicks(1450) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 14, 21, 9, 15, 36, DateTimeKind.Utc).AddTicks(761), new DateTime(2023, 8, 17, 10, 8, 20, 122, DateTimeKind.Utc).AddTicks(9844) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 9, 11, 5, 16, 337, DateTimeKind.Utc).AddTicks(3305), new DateTime(2023, 9, 9, 15, 6, 55, 215, DateTimeKind.Utc).AddTicks(5852) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 20, 51, 15, 753, DateTimeKind.Utc).AddTicks(4916), new DateTime(2023, 3, 14, 9, 10, 36, 531, DateTimeKind.Utc).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 8, 2, 13, 32, 954, DateTimeKind.Utc).AddTicks(3411), new DateTime(2023, 3, 2, 10, 46, 17, 873, DateTimeKind.Utc).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 15, 17, 245, DateTimeKind.Utc).AddTicks(5133), new DateTime(2023, 9, 7, 10, 30, 25, 767, DateTimeKind.Utc).AddTicks(7577) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 28, 9, 32, 41, 217, DateTimeKind.Utc).AddTicks(6010), new DateTime(2023, 8, 11, 7, 32, 46, 671, DateTimeKind.Utc).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 14, 15, 21, 54, 146, DateTimeKind.Utc).AddTicks(3835), new DateTime(2023, 8, 17, 17, 21, 56, 74, DateTimeKind.Utc).AddTicks(7146) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 10, 14, 22, 26, 274, DateTimeKind.Utc).AddTicks(1966), new DateTime(2023, 9, 11, 12, 56, 19, 802, DateTimeKind.Utc).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 10, 15, 30, 46, 250, DateTimeKind.Utc).AddTicks(7458), new DateTime(2023, 5, 21, 7, 1, 37, 468, DateTimeKind.Utc).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 5, 23, 43, 26, 186, DateTimeKind.Utc).AddTicks(4626), new DateTime(2023, 9, 11, 5, 45, 23, 525, DateTimeKind.Utc).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 29, 21, 38, 29, 443, DateTimeKind.Utc).AddTicks(510), new DateTime(2023, 5, 14, 12, 40, 43, 411, DateTimeKind.Utc).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 12, 23, 29, 0, 614, DateTimeKind.Utc).AddTicks(7060), new DateTime(2023, 8, 19, 1, 22, 15, 500, DateTimeKind.Utc).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 7, 13, 2, 30, 294, DateTimeKind.Utc).AddTicks(8493), new DateTime(2023, 8, 10, 0, 46, 0, 852, DateTimeKind.Utc).AddTicks(7136) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 8, 21, 57, 1, 425, DateTimeKind.Utc).AddTicks(9724), new DateTime(2023, 7, 10, 1, 36, 48, 785, DateTimeKind.Utc).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 12, 19, 56, 780, DateTimeKind.Utc).AddTicks(8287), new DateTime(2023, 8, 30, 22, 49, 38, 669, DateTimeKind.Utc).AddTicks(2097) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 11, 7, 42, 53, 326, DateTimeKind.Utc).AddTicks(7749), new DateTime(2023, 9, 11, 9, 23, 34, 347, DateTimeKind.Utc).AddTicks(9313) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 2, 23, 43, 23, 541, DateTimeKind.Utc).AddTicks(9257), new DateTime(2023, 9, 4, 19, 28, 24, 150, DateTimeKind.Utc).AddTicks(4728) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 6, 18, 45, 8, 371, DateTimeKind.Utc).AddTicks(4372), new DateTime(2023, 4, 14, 17, 45, 54, 413, DateTimeKind.Utc).AddTicks(9082) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 26, 0, 53, 46, 335, DateTimeKind.Utc).AddTicks(8460), new DateTime(2023, 7, 29, 13, 58, 51, 797, DateTimeKind.Utc).AddTicks(1236) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 8, 10, 54, 549, DateTimeKind.Utc).AddTicks(3366), new DateTime(2023, 8, 29, 21, 2, 6, 415, DateTimeKind.Utc).AddTicks(3769) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 21, 40, 576, DateTimeKind.Utc).AddTicks(9275), new DateTime(2023, 8, 24, 19, 44, 4, 715, DateTimeKind.Utc).AddTicks(7107) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 18, 8, 39, 37, 250, DateTimeKind.Utc).AddTicks(1402), new DateTime(2023, 7, 19, 22, 58, 14, 931, DateTimeKind.Utc).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 49, 14, 743, DateTimeKind.Utc).AddTicks(3692), new DateTime(2023, 5, 8, 4, 54, 52, 504, DateTimeKind.Utc).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 9, 30, 1, 59, 16, 925, DateTimeKind.Utc).AddTicks(1259), new DateTime(2023, 5, 2, 19, 17, 31, 665, DateTimeKind.Utc).AddTicks(6675) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 31, 11, 29, 14, 961, DateTimeKind.Utc).AddTicks(9794), new DateTime(2023, 5, 28, 6, 28, 57, 697, DateTimeKind.Utc).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 53, 24, 724, DateTimeKind.Utc).AddTicks(5480), new DateTime(2023, 4, 26, 0, 10, 16, 887, DateTimeKind.Utc).AddTicks(2922) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 10, 28, 15, 950, DateTimeKind.Utc).AddTicks(9678), new DateTime(2023, 5, 24, 10, 51, 22, 635, DateTimeKind.Utc).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 7, 19, 17, 43, 238, DateTimeKind.Utc).AddTicks(6758), new DateTime(2023, 9, 9, 0, 2, 19, 613, DateTimeKind.Utc).AddTicks(2731) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 25, 14, 6, 10, 819, DateTimeKind.Utc).AddTicks(6857), new DateTime(2023, 9, 9, 19, 4, 36, 3, DateTimeKind.Utc).AddTicks(1658) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 19, 58, 11, 361, DateTimeKind.Utc).AddTicks(1472), new DateTime(2023, 8, 4, 12, 15, 10, 653, DateTimeKind.Utc).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 23, 16, 33, 40, 991, DateTimeKind.Utc).AddTicks(6007), new DateTime(2023, 8, 6, 16, 38, 34, 764, DateTimeKind.Utc).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 4, 17, 42, 41, 544, DateTimeKind.Utc).AddTicks(487), new DateTime(2023, 7, 12, 8, 50, 4, 911, DateTimeKind.Utc).AddTicks(4019) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 5, 2, 19, 37, 962, DateTimeKind.Utc).AddTicks(5159), new DateTime(2023, 7, 7, 8, 44, 11, 281, DateTimeKind.Utc).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 1, 19, 7, 43, 165, DateTimeKind.Utc).AddTicks(6789), new DateTime(2023, 9, 6, 22, 18, 0, 689, DateTimeKind.Utc).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 3, 9, 9, 39, 605, DateTimeKind.Utc).AddTicks(4661), new DateTime(2023, 8, 14, 11, 8, 1, 869, DateTimeKind.Utc).AddTicks(6829) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 19, 23, 16, 9, 887, DateTimeKind.Utc).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 16, 21, 18, 478, DateTimeKind.Utc).AddTicks(3046), new DateTime(2023, 6, 24, 9, 36, 8, 202, DateTimeKind.Utc).AddTicks(2965) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 1, 29, 69, DateTimeKind.Utc).AddTicks(8647), new DateTime(2023, 8, 28, 6, 24, 35, 464, DateTimeKind.Utc).AddTicks(8672) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 25, 12, 10, 53, 588, DateTimeKind.Utc).AddTicks(7609), new DateTime(2023, 6, 1, 22, 31, 48, 915, DateTimeKind.Utc).AddTicks(6130) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 23, 51, 9, 740, DateTimeKind.Utc).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 30, 13, 48, 25, 91, DateTimeKind.Utc).AddTicks(7005), new DateTime(2023, 6, 10, 16, 22, 26, 442, DateTimeKind.Utc).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 16, 9, 13, 0, 603, DateTimeKind.Utc).AddTicks(2503), new DateTime(2023, 9, 2, 12, 54, 46, 581, DateTimeKind.Utc).AddTicks(9596) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 26, 22, 0, 7, 575, DateTimeKind.Utc).AddTicks(9748), new DateTime(2023, 6, 29, 15, 42, 8, 553, DateTimeKind.Utc).AddTicks(6727) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 1, 22, 47, 9, 720, DateTimeKind.Utc).AddTicks(6500), new DateTime(2023, 8, 16, 11, 0, 49, 594, DateTimeKind.Utc).AddTicks(1827) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 3, 12, 21, 40, 921, DateTimeKind.Utc).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 10, 23, 8, 12, 410, DateTimeKind.Utc).AddTicks(252), new DateTime(2023, 9, 11, 1, 34, 28, 890, DateTimeKind.Utc).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 3, 11, 43, 51, 119, DateTimeKind.Utc).AddTicks(2039), new DateTime(2023, 9, 4, 10, 45, 20, 369, DateTimeKind.Utc).AddTicks(239) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 20, 8, 45, 57, 979, DateTimeKind.Utc).AddTicks(4464), new DateTime(2023, 8, 20, 12, 40, 34, 27, DateTimeKind.Utc).AddTicks(9841) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 5, 13, 14, 55, 579, DateTimeKind.Utc).AddTicks(9667), new DateTime(2023, 9, 10, 19, 7, 4, 213, DateTimeKind.Utc).AddTicks(4923) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 17, 8, 13, 30, 444, DateTimeKind.Utc).AddTicks(7980), new DateTime(2023, 7, 13, 14, 16, 42, 365, DateTimeKind.Utc).AddTicks(4148) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 4, 4, 50, 58, 42, DateTimeKind.Utc).AddTicks(3722), new DateTime(2023, 9, 4, 19, 11, 17, 899, DateTimeKind.Utc).AddTicks(6229) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 6, 14, 19, 10, 765, DateTimeKind.Utc).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 1, 4, 16, 59, 44, 357, DateTimeKind.Utc).AddTicks(8342), new DateTime(2021, 12, 7, 12, 14, 54, 997, DateTimeKind.Utc).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 6, 2, 4, 56, 585, DateTimeKind.Utc).AddTicks(7452), new DateTime(2023, 7, 14, 19, 25, 59, 833, DateTimeKind.Utc).AddTicks(1486) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 9, 19, 53, 4, 589, DateTimeKind.Utc).AddTicks(2697), new DateTime(2023, 9, 10, 18, 16, 47, 711, DateTimeKind.Utc).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 7, 20, 19, 32, 461, DateTimeKind.Utc).AddTicks(6712), new DateTime(2023, 3, 2, 6, 25, 7, 350, DateTimeKind.Utc).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 9, 19, 52, 21, 831, DateTimeKind.Utc).AddTicks(811), new DateTime(2023, 9, 11, 12, 38, 10, 233, DateTimeKind.Utc).AddTicks(6893) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 17, 4, 15, 33, 350, DateTimeKind.Utc).AddTicks(261), new DateTime(2023, 2, 5, 8, 13, 47, 411, DateTimeKind.Utc).AddTicks(8101) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 11, 11, 19, 45, 31, 573, DateTimeKind.Utc).AddTicks(8651), new DateTime(2023, 3, 18, 19, 55, 12, 462, DateTimeKind.Utc).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 4, 5, 41, 24, 110, DateTimeKind.Utc).AddTicks(8453), new DateTime(2023, 9, 4, 11, 24, 16, 489, DateTimeKind.Utc).AddTicks(1805) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 3, 13, 14, 5, 967, DateTimeKind.Utc).AddTicks(5368), new DateTime(2023, 4, 17, 13, 6, 28, 289, DateTimeKind.Utc).AddTicks(4737) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 11, 10, 52, 775, DateTimeKind.Utc).AddTicks(7990), new DateTime(2023, 1, 30, 21, 57, 50, 903, DateTimeKind.Utc).AddTicks(9763) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 3, 5, 51, 33, 64, DateTimeKind.Utc).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 15, 6, 30, 45, 10, DateTimeKind.Utc).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 11, 8, 24, 55, 752, DateTimeKind.Utc).AddTicks(350), new DateTime(2023, 9, 11, 10, 59, 7, 793, DateTimeKind.Utc).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 26, 2, 9, 39, 488, DateTimeKind.Utc).AddTicks(5226), new DateTime(2023, 8, 27, 3, 42, 38, 377, DateTimeKind.Utc).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 31, 7, 11, 21, 726, DateTimeKind.Utc).AddTicks(7300), new DateTime(2023, 7, 23, 18, 8, 45, 378, DateTimeKind.Utc).AddTicks(6891) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 11, 13, 50, 51, 316, DateTimeKind.Utc).AddTicks(3040), new DateTime(2023, 9, 11, 13, 55, 45, 515, DateTimeKind.Utc).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 4, 18, 26, 6, 260, DateTimeKind.Utc).AddTicks(3861), new DateTime(2023, 6, 14, 11, 24, 49, 983, DateTimeKind.Utc).AddTicks(2115) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 6, 5, 4, 58, 29, 905, DateTimeKind.Utc).AddTicks(7292), new DateTime(2023, 3, 14, 22, 54, 20, 561, DateTimeKind.Utc).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 8, 4, 16, 14, 660, DateTimeKind.Utc).AddTicks(3693), new DateTime(2023, 9, 11, 7, 12, 40, 828, DateTimeKind.Utc).AddTicks(7011) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 8, 13, 44, 12, 137, DateTimeKind.Utc).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 25, 2, 3, 38, 964, DateTimeKind.Utc).AddTicks(4002), new DateTime(2023, 8, 8, 4, 55, 16, 263, DateTimeKind.Utc).AddTicks(2789) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 5, 12, 20, 54, 46, 988, DateTimeKind.Utc).AddTicks(8400), new DateTime(2022, 3, 28, 18, 0, 15, 109, DateTimeKind.Utc).AddTicks(7593) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 3, 8, 9, 8, 24, 747, DateTimeKind.Utc).AddTicks(9808), new DateTime(2023, 7, 25, 22, 33, 37, 680, DateTimeKind.Utc).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 22, 8, 38, 33, 692, DateTimeKind.Utc).AddTicks(2072), new DateTime(2023, 9, 9, 7, 12, 11, 872, DateTimeKind.Utc).AddTicks(9977) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 15, 9, 11, 10, 430, DateTimeKind.Utc).AddTicks(9060), new DateTime(2023, 8, 1, 17, 55, 58, 585, DateTimeKind.Utc).AddTicks(2049) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 9, 2, 24, 37, 727, DateTimeKind.Utc).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 25, 4, 24, 24, 942, DateTimeKind.Utc).AddTicks(8955), new DateTime(2023, 8, 29, 17, 57, 28, 963, DateTimeKind.Utc).AddTicks(1986) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 3, 27, 15, 35, 56, 40, DateTimeKind.Utc).AddTicks(6890), new DateTime(2023, 5, 28, 14, 17, 33, 983, DateTimeKind.Utc).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 4, 14, 4, 13, 189, DateTimeKind.Utc).AddTicks(4984), new DateTime(2023, 9, 7, 12, 58, 11, 276, DateTimeKind.Utc).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 30, 17, 50, 6, 427, DateTimeKind.Utc).AddTicks(5700), new DateTime(2023, 9, 7, 20, 27, 53, 347, DateTimeKind.Utc).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 15, 1, 3, 18, 372, DateTimeKind.Utc).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 17, 14, 39, 37, 640, DateTimeKind.Utc).AddTicks(5465), new DateTime(2023, 8, 18, 1, 6, 38, 804, DateTimeKind.Utc).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 20, 12, 19, 35, 403, DateTimeKind.Utc).AddTicks(4541), new DateTime(2023, 6, 7, 21, 28, 50, 809, DateTimeKind.Utc).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 4, 8, 0, 55, 457, DateTimeKind.Utc).AddTicks(4939), new DateTime(2023, 9, 8, 10, 32, 39, 57, DateTimeKind.Utc).AddTicks(6627) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 7, 15, 11, 45, 1, 133, DateTimeKind.Utc).AddTicks(1018), new DateTime(2023, 2, 27, 13, 49, 19, 913, DateTimeKind.Utc).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 10, 34, 24, 242, DateTimeKind.Utc).AddTicks(2224), new DateTime(2023, 7, 31, 20, 44, 20, 548, DateTimeKind.Utc).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 28, 3, 52, 7, 683, DateTimeKind.Utc).AddTicks(285), new DateTime(2023, 9, 9, 12, 54, 56, 62, DateTimeKind.Utc).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 23, 7, 27, 8, 802, DateTimeKind.Utc).AddTicks(8063), new DateTime(2023, 9, 2, 14, 38, 0, 298, DateTimeKind.Utc).AddTicks(2155) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 10, 11, 33, 375, DateTimeKind.Utc).AddTicks(3454), new DateTime(2023, 9, 11, 3, 19, 20, 626, DateTimeKind.Utc).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 5, 24, 14, 55, 43, 679, DateTimeKind.Utc).AddTicks(3672), new DateTime(2021, 12, 16, 18, 55, 26, 625, DateTimeKind.Utc).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 22, 14, 27, 35, 848, DateTimeKind.Utc).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 7, 3, 55, 26, 21, DateTimeKind.Utc).AddTicks(867), new DateTime(2023, 9, 10, 0, 38, 29, 508, DateTimeKind.Utc).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 19, 23, 27, 50, 856, DateTimeKind.Utc).AddTicks(3838), new DateTime(2023, 8, 17, 0, 45, 44, 419, DateTimeKind.Utc).AddTicks(108) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 26, 4, 23, 47, 511, DateTimeKind.Utc).AddTicks(7250), new DateTime(2023, 7, 25, 16, 9, 3, 754, DateTimeKind.Utc).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 15, 21, 23, 42, 962, DateTimeKind.Utc).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 9, 4, 44, 1, 664, DateTimeKind.Utc).AddTicks(3469), new DateTime(2023, 4, 24, 14, 42, 54, 444, DateTimeKind.Utc).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 7, 0, 37, 26, 246, DateTimeKind.Utc).AddTicks(9663), new DateTime(2023, 8, 28, 4, 52, 28, 213, DateTimeKind.Utc).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 17, 21, 32, 2, 302, DateTimeKind.Utc).AddTicks(8998), new DateTime(2023, 8, 26, 1, 38, 4, 701, DateTimeKind.Utc).AddTicks(1068) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 5, 18, 21, 40, 355, DateTimeKind.Utc).AddTicks(3900), new DateTime(2023, 9, 9, 2, 8, 35, 924, DateTimeKind.Utc).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 21, 17, 53, 47, 215, DateTimeKind.Utc).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 8, 13, 59, 25, 823, DateTimeKind.Utc).AddTicks(7224), new DateTime(2023, 9, 9, 8, 21, 21, 953, DateTimeKind.Utc).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 4, 15, 32, 8, 500, DateTimeKind.Utc).AddTicks(3309), new DateTime(2023, 5, 20, 18, 52, 16, 315, DateTimeKind.Utc).AddTicks(629) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 14, 18, 48, 19, 734, DateTimeKind.Utc).AddTicks(3155), new DateTime(2023, 9, 5, 8, 52, 23, 194, DateTimeKind.Utc).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 22, 16, 43, 45, 308, DateTimeKind.Utc).AddTicks(9286), new DateTime(2023, 8, 27, 20, 33, 8, 841, DateTimeKind.Utc).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 15, 3, 50, 8, 474, DateTimeKind.Utc).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 21, 16, 12, 22, 361, DateTimeKind.Utc).AddTicks(9016), new DateTime(2023, 8, 26, 3, 4, 27, 633, DateTimeKind.Utc).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 13, 48, 20, 163, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 1, 6, 22, 8, 518, DateTimeKind.Utc).AddTicks(5625), new DateTime(2023, 9, 1, 10, 22, 32, 396, DateTimeKind.Utc).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 2, 13, 16, 7, 55, 821, DateTimeKind.Utc).AddTicks(8826), new DateTime(2022, 12, 9, 22, 52, 58, 249, DateTimeKind.Utc).AddTicks(5011) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 13, 14, 38, 14, 369, DateTimeKind.Utc).AddTicks(3175), new DateTime(2023, 6, 10, 8, 17, 24, 208, DateTimeKind.Utc).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 5, 21, 5, 6, 425, DateTimeKind.Utc).AddTicks(3652), new DateTime(2023, 9, 10, 22, 21, 49, 744, DateTimeKind.Utc).AddTicks(3471) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 24, 3, 1, 50, 448, DateTimeKind.Utc).AddTicks(9965), new DateTime(2023, 7, 16, 9, 44, 28, 871, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 8, 11, 17, 59, 29, DateTimeKind.Utc).AddTicks(6627), new DateTime(2023, 3, 14, 7, 38, 16, 89, DateTimeKind.Utc).AddTicks(1537) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 11, 52, 59, 308, DateTimeKind.Utc).AddTicks(8195), new DateTime(2023, 5, 29, 18, 23, 7, 120, DateTimeKind.Utc).AddTicks(7874) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 16, 3, 27, 17, 712, DateTimeKind.Utc).AddTicks(5340), new DateTime(2023, 6, 23, 9, 4, 44, 477, DateTimeKind.Utc).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 4, 5, 38, 6, 405, DateTimeKind.Utc).AddTicks(2567), new DateTime(2023, 9, 9, 2, 9, 33, 384, DateTimeKind.Utc).AddTicks(1185) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 20, 1, 37, 52, 772, DateTimeKind.Utc).AddTicks(2669), new DateTime(2023, 8, 6, 23, 17, 45, 392, DateTimeKind.Utc).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 1, 12, 47, 52, 84, DateTimeKind.Utc).AddTicks(6530), new DateTime(2023, 9, 4, 14, 52, 47, 700, DateTimeKind.Utc).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 18, 17, 44, 31, 203, DateTimeKind.Utc).AddTicks(4794), new DateTime(2023, 6, 7, 6, 21, 43, 289, DateTimeKind.Utc).AddTicks(2555) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 11, 10, 6, 19, 910, DateTimeKind.Utc).AddTicks(883), new DateTime(2023, 9, 11, 10, 35, 31, 562, DateTimeKind.Utc).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 27, 23, 41, 4, 418, DateTimeKind.Utc).AddTicks(2568), new DateTime(2023, 9, 2, 9, 0, 36, 329, DateTimeKind.Utc).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 10, 19, 36, 6, 178, DateTimeKind.Utc).AddTicks(4543), new DateTime(2023, 9, 11, 1, 4, 29, 152, DateTimeKind.Utc).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 31, 9, 8, 40, 389, DateTimeKind.Utc).AddTicks(2257), new DateTime(2023, 8, 28, 13, 11, 16, 425, DateTimeKind.Utc).AddTicks(3171) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 41, 24, 907, DateTimeKind.Utc).AddTicks(2170), new DateTime(2023, 7, 16, 22, 14, 38, 264, DateTimeKind.Utc).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 7, 18, 28, 22, 65, DateTimeKind.Utc).AddTicks(2022), new DateTime(2023, 5, 24, 7, 10, 51, 775, DateTimeKind.Utc).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 14, 10, 48, 23, 971, DateTimeKind.Utc).AddTicks(8719), new DateTime(2023, 8, 15, 12, 14, 3, 213, DateTimeKind.Utc).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 20, 8, 50, 37, 642, DateTimeKind.Utc).AddTicks(6654), new DateTime(2023, 8, 19, 22, 48, 22, 450, DateTimeKind.Utc).AddTicks(7608) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 11, 11, 14, 7, 14, 885, DateTimeKind.Utc).AddTicks(9826), new DateTime(2023, 1, 26, 4, 0, 4, 266, DateTimeKind.Utc).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 20, 13, 51, 7, 654, DateTimeKind.Utc).AddTicks(2876), new DateTime(2023, 8, 7, 22, 16, 48, 634, DateTimeKind.Utc).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 28, 10, 12, 6, 803, DateTimeKind.Utc).AddTicks(9071), new DateTime(2023, 9, 8, 5, 42, 52, 571, DateTimeKind.Utc).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 25, 2, 11, 5, 18, DateTimeKind.Utc).AddTicks(8796), new DateTime(2023, 8, 10, 1, 29, 24, 421, DateTimeKind.Utc).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 29, 4, 58, 55, 382, DateTimeKind.Utc).AddTicks(9065), new DateTime(2023, 9, 2, 20, 36, 27, 912, DateTimeKind.Utc).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 5, 19, 14, 0, 773, DateTimeKind.Utc).AddTicks(8030), new DateTime(2023, 4, 15, 11, 58, 54, 490, DateTimeKind.Utc).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 10, 7, 54, 36, 878, DateTimeKind.Utc).AddTicks(5136), new DateTime(2023, 9, 3, 14, 49, 55, 289, DateTimeKind.Utc).AddTicks(1056) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 7, 20, 23, 20, 731, DateTimeKind.Utc).AddTicks(9919), new DateTime(2023, 3, 25, 5, 19, 30, 920, DateTimeKind.Utc).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 10, 30, 11, 57, 51, 841, DateTimeKind.Utc).AddTicks(1203), new DateTime(2022, 11, 29, 20, 59, 24, 128, DateTimeKind.Utc).AddTicks(967) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 5, 2, 14, 26, 503, DateTimeKind.Utc).AddTicks(7554), new DateTime(2023, 9, 6, 4, 44, 32, 551, DateTimeKind.Utc).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 11, 20, 7, 15, 734, DateTimeKind.Utc).AddTicks(5081), new DateTime(2023, 3, 12, 9, 15, 48, 252, DateTimeKind.Utc).AddTicks(5798) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 9, 3, 5, 38, 5, 445, DateTimeKind.Utc).AddTicks(7720), new DateTime(2022, 11, 2, 2, 33, 47, 304, DateTimeKind.Utc).AddTicks(9296) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 6, 21, 31, 16, 593, DateTimeKind.Utc).AddTicks(9967), new DateTime(2023, 9, 8, 17, 19, 5, 237, DateTimeKind.Utc).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 7, 12, 20, 34, 18, 851, DateTimeKind.Utc).AddTicks(8163), new DateTime(2023, 1, 21, 11, 10, 39, 131, DateTimeKind.Utc).AddTicks(3763) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 8, 20, 18, 31, 516, DateTimeKind.Utc).AddTicks(9709), new DateTime(2023, 7, 23, 5, 50, 11, 537, DateTimeKind.Utc).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 15, 14, 45, 26, 569, DateTimeKind.Utc).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 10, 2, 32, 1, 398, DateTimeKind.Utc).AddTicks(3304), new DateTime(2023, 4, 7, 10, 42, 33, 686, DateTimeKind.Utc).AddTicks(8502) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 9, 14, 37, 18, 110, DateTimeKind.Utc).AddTicks(8678), new DateTime(2023, 7, 3, 15, 9, 42, 783, DateTimeKind.Utc).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 162L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 2, 11, 13, 40, 736, DateTimeKind.Utc).AddTicks(7378), new DateTime(2023, 9, 8, 16, 42, 36, 88, DateTimeKind.Utc).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 163L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 10, 9, 37, 49, 661, DateTimeKind.Utc).AddTicks(6912), new DateTime(2023, 9, 11, 1, 1, 53, 971, DateTimeKind.Utc).AddTicks(1399) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 164L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 31, 19, 55, 59, 520, DateTimeKind.Utc).AddTicks(3715), new DateTime(2023, 9, 8, 3, 53, 22, 399, DateTimeKind.Utc).AddTicks(3549) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 165L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 31, 12, 5, 55, 159, DateTimeKind.Utc).AddTicks(5065), new DateTime(2023, 9, 2, 9, 11, 16, 141, DateTimeKind.Utc).AddTicks(4578) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 8, 22, 51, 24, 927, DateTimeKind.Utc).AddTicks(9977), new DateTime(2023, 8, 24, 12, 48, 25, 433, DateTimeKind.Utc).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 7, 8, 59, 10, 46, DateTimeKind.Utc).AddTicks(2680), new DateTime(2023, 9, 8, 20, 26, 49, 534, DateTimeKind.Utc).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 15, 21, 51, 37, 979, DateTimeKind.Utc).AddTicks(1987), new DateTime(2023, 7, 26, 23, 19, 12, 261, DateTimeKind.Utc).AddTicks(1407) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 18, 10, 23, 19, 276, DateTimeKind.Utc).AddTicks(3297), new DateTime(2023, 9, 7, 14, 15, 28, 633, DateTimeKind.Utc).AddTicks(4473) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 51, 23, 181, DateTimeKind.Utc).AddTicks(8408), new DateTime(2023, 8, 3, 4, 9, 49, 931, DateTimeKind.Utc).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 10, 5, 52, 383, DateTimeKind.Utc).AddTicks(433), new DateTime(2023, 8, 6, 15, 58, 41, 843, DateTimeKind.Utc).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 22, 6, 52, 36, 734, DateTimeKind.Utc).AddTicks(3165), new DateTime(2023, 8, 27, 6, 45, 4, 867, DateTimeKind.Utc).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 2, 19, 42, 52, 105, DateTimeKind.Utc).AddTicks(5524), new DateTime(2023, 7, 15, 6, 9, 19, 739, DateTimeKind.Utc).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 2, 1, 46, 13, 770, DateTimeKind.Utc).AddTicks(5452), new DateTime(2023, 9, 1, 11, 15, 48, 982, DateTimeKind.Utc).AddTicks(179) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 7, 28, 14, 27, 56, 109, DateTimeKind.Utc).AddTicks(2838), new DateTime(2023, 5, 21, 5, 31, 5, 153, DateTimeKind.Utc).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 28, 6, 47, 12, 230, DateTimeKind.Utc).AddTicks(4712), new DateTime(2023, 8, 21, 14, 25, 13, 383, DateTimeKind.Utc).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 12, 20, 54, 9, 53, DateTimeKind.Utc).AddTicks(2515), new DateTime(2023, 4, 15, 15, 57, 42, 421, DateTimeKind.Utc).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 31, 0, 7, 53, 945, DateTimeKind.Utc).AddTicks(5545), new DateTime(2023, 4, 9, 0, 50, 1, 440, DateTimeKind.Utc).AddTicks(7457) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 18, 8, 21, 40, 973, DateTimeKind.Utc).AddTicks(6030), new DateTime(2023, 5, 18, 14, 0, 9, 459, DateTimeKind.Utc).AddTicks(203) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 13, 14, 19, 32, 898, DateTimeKind.Utc).AddTicks(3000), new DateTime(2023, 6, 19, 19, 2, 28, 108, DateTimeKind.Utc).AddTicks(6141) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 6, 6, 4, 25, 17, 108, DateTimeKind.Utc).AddTicks(2838), new DateTime(2023, 3, 26, 13, 29, 32, 317, DateTimeKind.Utc).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 3, 10, 41, 553, DateTimeKind.Utc).AddTicks(6396), new DateTime(2023, 8, 4, 0, 58, 4, 351, DateTimeKind.Utc).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 28, 13, 40, 50, 766, DateTimeKind.Utc).AddTicks(7560), new DateTime(2023, 8, 7, 2, 46, 49, 835, DateTimeKind.Utc).AddTicks(3551) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 3, 18, 10, 29, 227, DateTimeKind.Utc).AddTicks(3648), new DateTime(2023, 9, 6, 6, 31, 15, 181, DateTimeKind.Utc).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 5, 26, 19, 59, DateTimeKind.Utc).AddTicks(8676), new DateTime(2023, 6, 2, 4, 21, 47, 931, DateTimeKind.Utc).AddTicks(2863) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 7, 18, 42, 13, 581, DateTimeKind.Utc).AddTicks(8733), new DateTime(2023, 6, 18, 17, 21, 58, 287, DateTimeKind.Utc).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 10, 8, 18, 11, 4, 72, DateTimeKind.Utc).AddTicks(539), new DateTime(2022, 11, 15, 11, 44, 58, 950, DateTimeKind.Utc).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 23, 37, 49, 834, DateTimeKind.Utc).AddTicks(1756), new DateTime(2023, 7, 29, 15, 47, 28, 536, DateTimeKind.Utc).AddTicks(3974) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 3, 4, 31, 28, 949, DateTimeKind.Utc).AddTicks(9546), new DateTime(2023, 9, 4, 4, 13, 43, 20, DateTimeKind.Utc).AddTicks(6538) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 11, 23, 1, 25, 22, 848, DateTimeKind.Utc).AddTicks(538), new DateTime(2023, 5, 11, 4, 31, 56, 550, DateTimeKind.Utc).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 8, 3, 0, 57, 52, 941, DateTimeKind.Utc).AddTicks(9916), new DateTime(2023, 3, 18, 3, 36, 48, 894, DateTimeKind.Utc).AddTicks(741) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 17, 0, 28, 9, 284, DateTimeKind.Utc).AddTicks(9272), new DateTime(2023, 7, 21, 13, 40, 30, 21, DateTimeKind.Utc).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 27, 9, 33, 27, 539, DateTimeKind.Utc).AddTicks(1825), new DateTime(2023, 9, 1, 16, 35, 4, 573, DateTimeKind.Utc).AddTicks(5166) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 27, 14, 26, 29, 786, DateTimeKind.Utc).AddTicks(9487), new DateTime(2023, 5, 31, 14, 53, 38, 143, DateTimeKind.Utc).AddTicks(107) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 9, 1, 31, 1, 255, DateTimeKind.Utc).AddTicks(8715), new DateTime(2023, 9, 10, 2, 12, 45, 383, DateTimeKind.Utc).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 15, 1, 35, 12, 335, DateTimeKind.Utc).AddTicks(8646), new DateTime(2023, 6, 19, 16, 57, 43, 814, DateTimeKind.Utc).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 9, 14, 3, 38, DateTimeKind.Utc).AddTicks(3520), new DateTime(2023, 5, 30, 0, 10, 15, 716, DateTimeKind.Utc).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 10, 13, 7, 13, 378, DateTimeKind.Utc).AddTicks(7038), new DateTime(2023, 7, 7, 16, 57, 34, 915, DateTimeKind.Utc).AddTicks(6611) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 9, 0, 31, 50, 963, DateTimeKind.Utc).AddTicks(3042), new DateTime(2023, 5, 21, 9, 57, 36, 386, DateTimeKind.Utc).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 14, 19, 2, 58, 458, DateTimeKind.Utc).AddTicks(4966), new DateTime(2023, 9, 2, 16, 22, 26, 16, DateTimeKind.Utc).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "RegisteredAt",
                value: new DateTime(2016, 5, 19, 20, 8, 26, 486, DateTimeKind.Utc).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "RegisteredAt",
                value: new DateTime(2016, 4, 10, 16, 7, 26, 711, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                column: "RegisteredAt",
                value: new DateTime(2017, 11, 10, 13, 14, 39, 186, DateTimeKind.Utc).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                column: "RegisteredAt",
                value: new DateTime(2018, 7, 26, 6, 36, 16, 368, DateTimeKind.Utc).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                column: "RegisteredAt",
                value: new DateTime(2017, 8, 16, 4, 19, 10, 588, DateTimeKind.Utc).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                column: "RegisteredAt",
                value: new DateTime(2022, 3, 7, 3, 10, 54, 967, DateTimeKind.Utc).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                column: "RegisteredAt",
                value: new DateTime(2020, 9, 18, 8, 54, 32, 664, DateTimeKind.Utc).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                column: "RegisteredAt",
                value: new DateTime(2022, 6, 1, 12, 13, 31, 349, DateTimeKind.Utc).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                column: "RegisteredAt",
                value: new DateTime(2021, 12, 7, 11, 46, 53, 6, DateTimeKind.Utc).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                column: "RegisteredAt",
                value: new DateTime(2018, 7, 20, 11, 58, 31, 772, DateTimeKind.Utc).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11L,
                column: "RegisteredAt",
                value: new DateTime(2022, 3, 28, 17, 9, 43, 293, DateTimeKind.Utc).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12L,
                column: "RegisteredAt",
                value: new DateTime(2019, 9, 17, 7, 22, 36, 335, DateTimeKind.Utc).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13L,
                column: "RegisteredAt",
                value: new DateTime(2021, 3, 13, 5, 30, 8, 14, DateTimeKind.Utc).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14L,
                column: "RegisteredAt",
                value: new DateTime(2016, 6, 10, 1, 8, 41, 148, DateTimeKind.Utc).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15L,
                column: "RegisteredAt",
                value: new DateTime(2022, 3, 17, 1, 34, 29, 632, DateTimeKind.Utc).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16L,
                column: "RegisteredAt",
                value: new DateTime(2017, 6, 23, 7, 39, 9, 259, DateTimeKind.Utc).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17L,
                column: "RegisteredAt",
                value: new DateTime(2016, 1, 19, 22, 55, 51, 67, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18L,
                column: "RegisteredAt",
                value: new DateTime(2022, 12, 30, 18, 9, 20, 728, DateTimeKind.Utc).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19L,
                column: "RegisteredAt",
                value: new DateTime(2022, 4, 18, 2, 30, 7, 400, DateTimeKind.Utc).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20L,
                column: "RegisteredAt",
                value: new DateTime(2020, 12, 18, 21, 56, 24, 97, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21L,
                column: "RegisteredAt",
                value: new DateTime(2017, 1, 24, 19, 2, 38, 147, DateTimeKind.Utc).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22L,
                column: "RegisteredAt",
                value: new DateTime(2018, 5, 5, 0, 38, 7, 937, DateTimeKind.Utc).AddTicks(2885));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23L,
                column: "RegisteredAt",
                value: new DateTime(2021, 11, 10, 13, 0, 3, 658, DateTimeKind.Utc).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24L,
                column: "RegisteredAt",
                value: new DateTime(2021, 4, 29, 17, 12, 41, 936, DateTimeKind.Utc).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25L,
                column: "RegisteredAt",
                value: new DateTime(2019, 2, 23, 6, 24, 7, 1, DateTimeKind.Utc).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26L,
                column: "RegisteredAt",
                value: new DateTime(2016, 6, 21, 20, 22, 52, 278, DateTimeKind.Utc).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27L,
                column: "RegisteredAt",
                value: new DateTime(2021, 12, 15, 9, 52, 56, 660, DateTimeKind.Utc).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28L,
                column: "RegisteredAt",
                value: new DateTime(2016, 7, 18, 11, 18, 30, 252, DateTimeKind.Utc).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29L,
                column: "RegisteredAt",
                value: new DateTime(2017, 8, 4, 15, 49, 4, 939, DateTimeKind.Utc).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30L,
                column: "RegisteredAt",
                value: new DateTime(2020, 8, 24, 14, 49, 40, 428, DateTimeKind.Utc).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31L,
                column: "RegisteredAt",
                value: new DateTime(2016, 12, 17, 1, 59, 55, 137, DateTimeKind.Utc).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32L,
                column: "RegisteredAt",
                value: new DateTime(2016, 12, 25, 3, 54, 32, 65, DateTimeKind.Utc).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33L,
                column: "RegisteredAt",
                value: new DateTime(2021, 11, 30, 15, 58, 53, 822, DateTimeKind.Utc).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34L,
                column: "RegisteredAt",
                value: new DateTime(2023, 3, 16, 23, 34, 33, 747, DateTimeKind.Utc).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35L,
                column: "RegisteredAt",
                value: new DateTime(2022, 2, 20, 4, 4, 23, 832, DateTimeKind.Utc).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36L,
                column: "RegisteredAt",
                value: new DateTime(2020, 4, 10, 10, 0, 15, 966, DateTimeKind.Utc).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37L,
                column: "RegisteredAt",
                value: new DateTime(2016, 5, 7, 12, 26, 26, 136, DateTimeKind.Utc).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38L,
                column: "RegisteredAt",
                value: new DateTime(2018, 12, 22, 20, 39, 45, 468, DateTimeKind.Utc).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39L,
                column: "RegisteredAt",
                value: new DateTime(2016, 7, 25, 0, 59, 3, 710, DateTimeKind.Utc).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40L,
                column: "RegisteredAt",
                value: new DateTime(2017, 10, 21, 18, 42, 49, 944, DateTimeKind.Utc).AddTicks(7560));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Icon",
                value: "/static/images/2023-01.png");

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Icon",
                value: "/static/images/2023-02.png");

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Icon",
                value: "/static/images/2023-03.png");

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Icon",
                value: "/static/images/2023-04.png");

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Icon",
                value: "/static/images/2023-05.png");

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Icon",
                value: "/static/images/2023-06.png");

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Icon",
                value: "/static/images/2023-07.png");

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Icon",
                value: "/static/images/2023-08.png");

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Icon",
                value: "/static/images/2023-09.png");

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Icon",
                value: "/static/images/2023-10.png");

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Icon",
                value: "/static/images/2023-11.png");

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: 12L,
                column: "Icon",
                value: "/static/images/2023-12.png");

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 29, 4, 42, 11, 535, DateTimeKind.Utc).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 7, 9, 54, 439, DateTimeKind.Utc).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2021, 12, 29, 11, 1, 8, 294, DateTimeKind.Utc).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 8, 15, 7, 949, DateTimeKind.Utc).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 29, 12, 29, 33, 337, DateTimeKind.Utc).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 6, 0, 4, 16, 23, DateTimeKind.Utc).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 6, 20, 7, 21, 673, DateTimeKind.Utc).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 12, 9, 13, 148, DateTimeKind.Utc).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 20, 22, 51, 54, 47, DateTimeKind.Utc).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 15, 10, 31, 17, 208, DateTimeKind.Utc).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 24, 21, 9, 17, 835, DateTimeKind.Utc).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 11, 9, 8, 31, 996, DateTimeKind.Utc).AddTicks(3113));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 1, 19, 18, 45, 14, DateTimeKind.Utc).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 4, 16, 38, 44, 869, DateTimeKind.Utc).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 13, 0, 0, 5, 546, DateTimeKind.Utc).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 8, 3, 38, 12, 707, DateTimeKind.Utc).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 6, 21, 40, 21, 911, DateTimeKind.Utc).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 22, 15, 59, 18, 501, DateTimeKind.Utc).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 15, 8, 21, 44, 13, DateTimeKind.Utc).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 1, 21, 40, 51, 412, DateTimeKind.Utc).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 1, 17, 33, 32, 563, DateTimeKind.Utc).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 8, 7, 3, 17, 659, DateTimeKind.Utc).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 4, 43, 28, 730, DateTimeKind.Utc).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 11, 19, 14, 35, 888, DateTimeKind.Utc).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 17, 31, 36, 341, DateTimeKind.Utc).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 10, 22, 19, 30, 902, DateTimeKind.Utc).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 29, 21, 54, 1, 415, DateTimeKind.Utc).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 2, 16, 28, 5, 940, DateTimeKind.Utc).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 19, 4, 52, 7, 338, DateTimeKind.Utc).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 6, 18, 46, 31, 449, DateTimeKind.Utc).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 1, 19, 2, 5, 372, DateTimeKind.Utc).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 4, 13, 14, 32, 68, DateTimeKind.Utc).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 18, 17, 41, 23, 504, DateTimeKind.Utc).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 22, 15, 42, 693, DateTimeKind.Utc).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 23, 21, 17, 39, 652, DateTimeKind.Utc).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 6, 3, 27, 34, 375, DateTimeKind.Utc).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 2, 7, 29, 35, 163, DateTimeKind.Utc).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 11, 22, 5, 40, 158, DateTimeKind.Utc).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 12, 38, 49, 457, DateTimeKind.Utc).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedAt",
                value: new DateTime(2022, 2, 4, 12, 34, 52, 163, DateTimeKind.Utc).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 9, 5, 20, 16, 728, DateTimeKind.Utc).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 25, 9, 56, 21, 837, DateTimeKind.Utc).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 19, 1, 14, 19, 663, DateTimeKind.Utc).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 15, 7, 29, 13, 778, DateTimeKind.Utc).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 7, 6, 48, 43, 266, DateTimeKind.Utc).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 2, 20, 54, 21, 863, DateTimeKind.Utc).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 23, 16, 33, 923, DateTimeKind.Utc).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 48L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 22, 55, 13, 813, DateTimeKind.Utc).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 18, 5, 21, 7, 813, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 28, 0, 24, 20, 447, DateTimeKind.Utc).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 1, 16, 8, 17, 841, DateTimeKind.Utc).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedAt",
                value: new DateTime(2018, 9, 18, 20, 0, 0, 637, DateTimeKind.Utc).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 1, 3, 37, 34, 443, DateTimeKind.Utc).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 16, 11, 36, 20, 853, DateTimeKind.Utc).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 10, 1, 51, 183, DateTimeKind.Utc).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 56L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 26, 9, 36, 58, 247, DateTimeKind.Utc).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 29, 18, 35, 18, 517, DateTimeKind.Utc).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 3, 1, 58, 26, 817, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 19, 12, 21, 55, 137, DateTimeKind.Utc).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 26, 3, 39, 20, 717, DateTimeKind.Utc).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 24, 16, 45, 43, 493, DateTimeKind.Utc).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 13, 18, 48, 36, 931, DateTimeKind.Utc).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 10, 19, 16, 2, 407, DateTimeKind.Utc).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 64L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 5, 1, 28, 57, 83, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 29, 18, 38, 58, 675, DateTimeKind.Utc).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 2, 7, 56, 14, 688, DateTimeKind.Utc).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 22, 20, 12, 35, 936, DateTimeKind.Utc).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 15, 13, 46, 43, 414, DateTimeKind.Utc).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 19, 16, 22, 27, 261, DateTimeKind.Utc).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 20, 10, 57, 42, 85, DateTimeKind.Utc).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 9, 27, 49, 514, DateTimeKind.Utc).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 72L,
                column: "CreatedAt",
                value: new DateTime(2020, 3, 21, 15, 10, 47, 921, DateTimeKind.Utc).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 24, 5, 12, 41, 705, DateTimeKind.Utc).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 23, 0, 43, 7, 87, DateTimeKind.Utc).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 5, 15, 38, 36, 899, DateTimeKind.Utc).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 18, 40, 54, 851, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedAt",
                value: new DateTime(2019, 4, 21, 2, 5, 36, 173, DateTimeKind.Utc).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 8, 14, 58, 52, 286, DateTimeKind.Utc).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 3, 2, 41, 820, DateTimeKind.Utc).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 80L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 20, 5, 5, 19, 76, DateTimeKind.Utc).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 4, 28, 56, 249, DateTimeKind.Utc).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 15, 3, 56, 40, 662, DateTimeKind.Utc).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 26, 20, 35, 50, 877, DateTimeKind.Utc).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 15, 2, 51, 47, 798, DateTimeKind.Utc).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 2, 17, 34, 6, 911, DateTimeKind.Utc).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 1, 17, 55, 27, 211, DateTimeKind.Utc).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 18, 20, 3, 11, 561, DateTimeKind.Utc).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 88L,
                column: "CreatedAt",
                value: new DateTime(2018, 10, 16, 8, 46, 23, 362, DateTimeKind.Utc).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedAt",
                value: new DateTime(2022, 1, 28, 23, 45, 37, 154, DateTimeKind.Utc).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 11, 19, 59, 24, 378, DateTimeKind.Utc).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 31, 6, 17, 53, 713, DateTimeKind.Utc).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 6, 11, 51, 59, 223, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 2, 19, 12, 33, 856, DateTimeKind.Utc).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 24, 13, 10, 1, 230, DateTimeKind.Utc).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 1, 8, 12, 59, 676, DateTimeKind.Utc).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 96L,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 2, 22, 54, 27, 605, DateTimeKind.Utc).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 26, 11, 47, 17, 631, DateTimeKind.Utc).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 0, 12, 45, 113, DateTimeKind.Utc).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 20, 21, 28, 14, 995, DateTimeKind.Utc).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 19, 5, 12, 12, 444, DateTimeKind.Utc).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 18, 14, 51, 12, 13, DateTimeKind.Utc).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 25, 8, 51, 55, 325, DateTimeKind.Utc).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 12, 7, 24, 58, 699, DateTimeKind.Utc).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 104L,
                column: "CreatedAt",
                value: new DateTime(2019, 6, 5, 1, 27, 27, 978, DateTimeKind.Utc).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedAt",
                value: new DateTime(2022, 2, 20, 9, 34, 29, 32, DateTimeKind.Utc).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 2, 1, 49, 35, 19, DateTimeKind.Utc).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedAt",
                value: new DateTime(2020, 2, 17, 1, 10, 14, 96, DateTimeKind.Utc).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 8, 18, 55, 221, DateTimeKind.Utc).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 31, 11, 53, 58, 550, DateTimeKind.Utc).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 30, 5, 50, 5, 818, DateTimeKind.Utc).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedAt",
                value: new DateTime(2018, 2, 21, 12, 31, 40, 863, DateTimeKind.Utc).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 112L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 7, 3, 51, 11, 402, DateTimeKind.Utc).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 7, 35, 26, 259, DateTimeKind.Utc).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 6, 2, 13, 14, 962, DateTimeKind.Utc).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 19, 1, 39, 50, 721, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 1, 7, 38, 35, 909, DateTimeKind.Utc).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 16, 1, 47, 28, 310, DateTimeKind.Utc).AddTicks(142));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedAt",
                value: new DateTime(2022, 2, 28, 0, 12, 18, 455, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 17, 22, 39, 21, 296, DateTimeKind.Utc).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 120L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 14, 18, 39, 22, 930, DateTimeKind.Utc).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 14, 3, 4, 44, 33, DateTimeKind.Utc).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 14, 10, 58, 24, 162, DateTimeKind.Utc).AddTicks(1813));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 29, 9, 15, 8, 40, DateTimeKind.Utc).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 23, 18, 4, 40, 994, DateTimeKind.Utc).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 10, 40, 7, 346, DateTimeKind.Utc).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 30, 5, 39, 49, 459, DateTimeKind.Utc).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 31, 10, 6, 38, 671, DateTimeKind.Utc).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 128L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 24, 4, 8, 49, 684, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 19, 3, 22, 32, 468, DateTimeKind.Utc).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 4, 17, 8, 55, 548, DateTimeKind.Utc).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 5, 22, 55, 4, 999, DateTimeKind.Utc).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 13, 23, 40, 43, 690, DateTimeKind.Utc).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 4, 11, 23, 36, 674, DateTimeKind.Utc).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 30, 9, 12, 47, 466, DateTimeKind.Utc).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedAt",
                value: new DateTime(2021, 6, 13, 16, 29, 56, 795, DateTimeKind.Utc).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 136L,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 1, 7, 38, 51, 754, DateTimeKind.Utc).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedAt",
                value: new DateTime(2022, 2, 21, 18, 24, 39, 852, DateTimeKind.Utc).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 7, 31, 1, 394, DateTimeKind.Utc).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 1, 21, 1, 35, 218, DateTimeKind.Utc).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 28, 8, 55, 42, 243, DateTimeKind.Utc).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedAt",
                value: new DateTime(2022, 2, 19, 18, 2, 53, 999, DateTimeKind.Utc).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 26, 1, 56, 20, 317, DateTimeKind.Utc).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 8, 15, 50, 59, DateTimeKind.Utc).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 144L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 12, 0, 1, 10, 295, DateTimeKind.Utc).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 9, 1, 3, 57, 815, DateTimeKind.Utc).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 21, 21, 30, 3, 722, DateTimeKind.Utc).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 30, 5, 42, 36, 511, DateTimeKind.Utc).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 20, 40, 56, 302, DateTimeKind.Utc).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 20, 21, 44, 7, 278, DateTimeKind.Utc).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 30, 0, 31, 16, 140, DateTimeKind.Utc).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 10, 6, 14, 1, 274, DateTimeKind.Utc).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 152L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 1, 12, 18, 35, 245, DateTimeKind.Utc).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 2, 26, 32, 299, DateTimeKind.Utc).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 13, 10, 54, 5, 542, DateTimeKind.Utc).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 29, 4, 15, 3, 785, DateTimeKind.Utc).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 30, 14, 29, 16, 545, DateTimeKind.Utc).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 20, 32, 5, 803, DateTimeKind.Utc).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 28, 17, 36, 49, 317, DateTimeKind.Utc).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedAt",
                value: new DateTime(2021, 6, 12, 3, 37, 19, 454, DateTimeKind.Utc).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 160L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 24, 6, 48, 56, 319, DateTimeKind.Utc).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedAt",
                value: new DateTime(2022, 2, 26, 10, 16, 2, 891, DateTimeKind.Utc).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 18, 0, 29, 53, 274, DateTimeKind.Utc).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 16, 12, 29, 16, 666, DateTimeKind.Utc).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 42, 46, 744, DateTimeKind.Utc).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 2, 11, 51, 22, 188, DateTimeKind.Utc).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 1, 8, 8, 17, 629, DateTimeKind.Utc).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedAt",
                value: new DateTime(2018, 12, 5, 0, 5, 55, 412, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 168L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 9, 59, 31, 215, DateTimeKind.Utc).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 3, 59, 56, 801, DateTimeKind.Utc).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 4, 3, 44, 10, 639, DateTimeKind.Utc).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 29, 5, 37, 17, 621, DateTimeKind.Utc).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 2, 43, 53, 235, DateTimeKind.Utc).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 9, 16, 41, 53, 168, DateTimeKind.Utc).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 17, 6, 49, 34, 398, DateTimeKind.Utc).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 16, 27, 5, 807, DateTimeKind.Utc).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 176L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 17, 8, 35, 37, 768, DateTimeKind.Utc).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 26, 21, 33, 59, 752, DateTimeKind.Utc).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 4, 3, 3, 4, 123, DateTimeKind.Utc).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 6, 9, 30, 17, 813, DateTimeKind.Utc).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 31, 13, 50, 31, 33, DateTimeKind.Utc).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 25, 1, 44, 9, 872, DateTimeKind.Utc).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 22, 1, 47, 8, 563, DateTimeKind.Utc).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 6, 35, 31, 43, DateTimeKind.Utc).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 184L,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 5, 0, 53, 15, 359, DateTimeKind.Utc).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedAt",
                value: new DateTime(2020, 2, 28, 1, 5, 22, 550, DateTimeKind.Utc).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 9, 1, 15, 15, 645, DateTimeKind.Utc).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 13, 9, 34, 51, 377, DateTimeKind.Utc).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 13, 22, 10, 48, 155, DateTimeKind.Utc).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedAt",
                value: new DateTime(2022, 1, 15, 10, 21, 14, 253, DateTimeKind.Utc).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 27, 19, 53, 14, 814, DateTimeKind.Utc).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 5, 1, 46, 17, 657, DateTimeKind.Utc).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 192L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 12, 16, 19, 32, 31, DateTimeKind.Utc).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 0, 9, 28, 634, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 2, 12, 31, 42, 466, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 26, 10, 30, 33, 662, DateTimeKind.Utc).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 1, 23, 34, 18, 959, DateTimeKind.Utc).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 5, 10, 13, 483, DateTimeKind.Utc).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 4, 15, 26, 970, DateTimeKind.Utc).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 6, 36, 43, 710, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 200L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 1, 21, 43, 59, 951, DateTimeKind.Utc).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 26, 16, 58, 50, 98, DateTimeKind.Utc).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2018, 3, 16, 11, 5, 9, 974, DateTimeKind.Utc).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 22, 11, 25, 36, 259, DateTimeKind.Utc).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 6, 10, 33, 50, 121, DateTimeKind.Utc).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 23, 22, 6, 38, 492, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 23, 7, 11, 33, 9, DateTimeKind.Utc).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 8, 2, 28, 3, 786, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2017, 1, 15, 22, 58, 5, 489, DateTimeKind.Utc).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 6, 20, 6, 52, 276, DateTimeKind.Utc).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 3, 10, 13, 16, 46, DateTimeKind.Utc).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2018, 1, 13, 20, 47, 57, 622, DateTimeKind.Utc).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 12, 13, 38, 13, 864, DateTimeKind.Utc).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2017, 10, 23, 8, 40, 58, 410, DateTimeKind.Utc).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 16, 6, 46, 29, 418, DateTimeKind.Utc).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2018, 7, 14, 16, 0, 3, 825, DateTimeKind.Utc).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 20, 2, 45, 4, 5, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 19, 22, 19, 39, 452, DateTimeKind.Utc).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 19, 5, 57, 12, 782, DateTimeKind.Utc).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 25, 17, 58, 21, 254, DateTimeKind.Utc).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 4, 10, 49, 37, 431, DateTimeKind.Utc).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 30, 3, 12, 48, 33, DateTimeKind.Utc).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 28, 19, 3, 3, 510, DateTimeKind.Utc).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 24, 14, 8, 27, 292, DateTimeKind.Utc).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 12, 8, 21, 51, 688, DateTimeKind.Utc).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 7, 7, 27, 45, 857, DateTimeKind.Utc).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 7, 3, 32, 30, 355, DateTimeKind.Utc).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 14, 6, 16, 13, 61, DateTimeKind.Utc).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2022, 2, 14, 1, 17, 5, 932, DateTimeKind.Utc).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 27, 5, 58, 47, 749, DateTimeKind.Utc).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2017, 7, 1, 18, 4, 44, 693, DateTimeKind.Utc).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 12, 4, 23, 19, 6, DateTimeKind.Utc).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 9, 11, 37, 7, 133, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 4, 55, 42, 403, DateTimeKind.Utc).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 22, 20, 12, 19, 38, DateTimeKind.Utc).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 12, 23, 13, 54, 587, DateTimeKind.Utc).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedAt",
                value: new DateTime(2021, 6, 2, 0, 36, 50, 222, DateTimeKind.Utc).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 28, 19, 41, 6, 582, DateTimeKind.Utc).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 20, 20, 40, 25, 500, DateTimeKind.Utc).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedAt",
                value: new DateTime(2022, 2, 14, 3, 21, 36, 736, DateTimeKind.Utc).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 16, 10, 45, 22, 968, DateTimeKind.Utc).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedAt",
                value: new DateTime(2021, 12, 2, 20, 19, 9, 977, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 6, 20, 18, 42, 369, DateTimeKind.Utc).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 24, 4, 47, 20, 171, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedAt",
                value: new DateTime(2019, 2, 8, 8, 1, 58, 540, DateTimeKind.Utc).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 8, 3, 42, 56, 779, DateTimeKind.Utc).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 29, 14, 17, 42, 981, DateTimeKind.Utc).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 8, 15, 47, 21, 138, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 48L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 5, 3, 50, 52, 67, DateTimeKind.Utc).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 0, 47, 31, 556, DateTimeKind.Utc).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 24, 12, 5, 28, 849, DateTimeKind.Utc).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 21, 23, 21, 52, 430, DateTimeKind.Utc).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedAt",
                value: new DateTime(2022, 1, 31, 13, 40, 24, 714, DateTimeKind.Utc).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedAt",
                value: new DateTime(2019, 4, 12, 18, 8, 28, 199, DateTimeKind.Utc).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedAt",
                value: new DateTime(2022, 1, 27, 3, 47, 28, 0, DateTimeKind.Utc).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 1, 8, 36, 975, DateTimeKind.Utc).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 56L,
                column: "CreatedAt",
                value: new DateTime(2018, 4, 23, 1, 1, 52, 59, DateTimeKind.Utc).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 8, 4, 18, 27, 499, DateTimeKind.Utc).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 20, 3, 24, 24, 534, DateTimeKind.Utc).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 18, 15, 56, 50, 69, DateTimeKind.Utc).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedAt",
                value: new DateTime(2019, 2, 25, 13, 21, 14, 30, DateTimeKind.Utc).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 18, 2, 33, 216, DateTimeKind.Utc).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 5, 7, 22, 57, 195, DateTimeKind.Utc).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 16, 19, 30, 10, 102, DateTimeKind.Utc).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 64L,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 21, 17, 33, 14, 690, DateTimeKind.Utc).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 20, 0, 10, 5, 731, DateTimeKind.Utc).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedAt",
                value: new DateTime(2021, 12, 1, 2, 47, 44, 809, DateTimeKind.Utc).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 8, 16, 1, 12, 854, DateTimeKind.Utc).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 14, 16, 43, 37, 208, DateTimeKind.Utc).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 26, 19, 47, 51, 593, DateTimeKind.Utc).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 25, 13, 46, 59, 131, DateTimeKind.Utc).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 21, 21, 43, 3, 879, DateTimeKind.Utc).AddTicks(9790), new DateTime(2023, 7, 20, 6, 33, 37, 120, DateTimeKind.Utc).AddTicks(8873), new DateTime(2022, 8, 15, 14, 8, 32, 255, DateTimeKind.Utc).AddTicks(5253), new DateTime(2023, 7, 22, 14, 7, 57, 329, DateTimeKind.Utc).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 19, 1, 30, 9, 732, DateTimeKind.Utc).AddTicks(2569), new DateTime(2023, 7, 31, 16, 8, 14, 607, DateTimeKind.Utc).AddTicks(8517), new DateTime(2023, 1, 23, 7, 10, 14, 302, DateTimeKind.Utc).AddTicks(6604), new DateTime(2023, 2, 8, 2, 29, 23, 56, DateTimeKind.Utc).AddTicks(9201) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 10, 16, 37, 21, 96, DateTimeKind.Utc).AddTicks(799), new DateTime(2023, 7, 29, 11, 44, 48, 330, DateTimeKind.Utc).AddTicks(34), new DateTime(2023, 5, 11, 22, 49, 35, 984, DateTimeKind.Utc).AddTicks(9155), new DateTime(2023, 7, 22, 20, 37, 56, 839, DateTimeKind.Utc).AddTicks(6699) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 1, 14, 23, 14, 33, 753, DateTimeKind.Utc).AddTicks(9061), new DateTime(2022, 6, 2, 11, 10, 55, 291, DateTimeKind.Utc).AddTicks(2205), new DateTime(2021, 8, 2, 19, 33, 5, 592, DateTimeKind.Utc).AddTicks(9113), new DateTime(2022, 8, 14, 2, 58, 50, 472, DateTimeKind.Utc).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 13, 12, 18, 58, 870, DateTimeKind.Utc).AddTicks(7097), new DateTime(2023, 5, 8, 11, 24, 32, 63, DateTimeKind.Utc).AddTicks(5633), new DateTime(2022, 10, 31, 9, 22, 58, 412, DateTimeKind.Utc).AddTicks(7068), new DateTime(2023, 8, 16, 9, 34, 2, 419, DateTimeKind.Utc).AddTicks(212) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 19, 14, 32, 138, DateTimeKind.Utc).AddTicks(6669), new DateTime(2021, 4, 12, 2, 26, 20, 892, DateTimeKind.Utc).AddTicks(2141), new DateTime(2018, 12, 17, 4, 10, 24, 561, DateTimeKind.Utc).AddTicks(1048), new DateTime(2019, 12, 30, 5, 51, 31, 403, DateTimeKind.Utc).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 2, 23, 20, 18, 37, 981, DateTimeKind.Utc).AddTicks(801), new DateTime(2023, 1, 31, 7, 44, 8, 260, DateTimeKind.Utc).AddTicks(4406), new DateTime(2020, 4, 23, 15, 47, 44, 961, DateTimeKind.Utc).AddTicks(3669), new DateTime(2021, 1, 24, 16, 54, 40, 104, DateTimeKind.Utc).AddTicks(335) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 10, 18, 15, 17, 58, 945, DateTimeKind.Utc).AddTicks(7595), new DateTime(2022, 8, 27, 9, 19, 3, 603, DateTimeKind.Utc).AddTicks(4555), new DateTime(2021, 5, 7, 17, 45, 19, 689, DateTimeKind.Utc).AddTicks(857), new DateTime(2021, 7, 19, 0, 58, 44, 231, DateTimeKind.Utc).AddTicks(6954) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 27, 12, 46, 40, 726, DateTimeKind.Utc).AddTicks(1786), new DateTime(2023, 5, 28, 11, 46, 58, 88, DateTimeKind.Utc).AddTicks(4780), new DateTime(2021, 6, 3, 5, 41, 39, 564, DateTimeKind.Utc).AddTicks(8284), new DateTime(2022, 5, 3, 0, 59, 50, 226, DateTimeKind.Utc).AddTicks(3402) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 7, 3, 0, 2, 985, DateTimeKind.Utc).AddTicks(9815), new DateTime(2022, 3, 22, 7, 25, 41, 415, DateTimeKind.Utc).AddTicks(7320), new DateTime(2021, 3, 14, 17, 32, 17, 659, DateTimeKind.Utc).AddTicks(7734), new DateTime(2022, 12, 6, 0, 57, 49, 989, DateTimeKind.Utc).AddTicks(9191) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 17, 16, 54, 814, DateTimeKind.Utc).AddTicks(4462), new DateTime(2023, 4, 11, 11, 20, 59, 493, DateTimeKind.Utc).AddTicks(1332), new DateTime(2023, 1, 14, 9, 5, 38, 396, DateTimeKind.Utc).AddTicks(2656), new DateTime(2023, 2, 17, 21, 53, 31, 211, DateTimeKind.Utc).AddTicks(5123) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 19, 16, 45, 51, 0, DateTimeKind.Utc).AddTicks(1284), new DateTime(2022, 12, 17, 22, 3, 47, 91, DateTimeKind.Utc).AddTicks(2361), new DateTime(2022, 9, 22, 22, 7, 8, 291, DateTimeKind.Utc).AddTicks(8227), new DateTime(2023, 8, 13, 18, 28, 20, 587, DateTimeKind.Utc).AddTicks(5802) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 19, 23, 47, 37, 156, DateTimeKind.Utc).AddTicks(7735), new DateTime(2023, 9, 11, 2, 13, 38, 843, DateTimeKind.Utc).AddTicks(3515), new DateTime(2023, 4, 19, 20, 34, 51, 439, DateTimeKind.Utc).AddTicks(4209), new DateTime(2023, 9, 1, 19, 38, 40, 191, DateTimeKind.Utc).AddTicks(8397) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 5, 26, 2, 37, 6, 979, DateTimeKind.Utc).AddTicks(5776), new DateTime(2020, 7, 28, 11, 45, 0, 562, DateTimeKind.Utc).AddTicks(574), new DateTime(2019, 11, 13, 11, 54, 20, 66, DateTimeKind.Utc).AddTicks(7408), new DateTime(2022, 10, 26, 13, 1, 28, 920, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 9, 5, 0, 13, 46, 308, DateTimeKind.Utc).AddTicks(2981), new DateTime(2022, 8, 15, 9, 17, 39, 138, DateTimeKind.Utc).AddTicks(2313), new DateTime(2021, 4, 2, 3, 20, 39, 227, DateTimeKind.Utc).AddTicks(6118), new DateTime(2023, 7, 9, 10, 48, 21, 854, DateTimeKind.Utc).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 11, 3, 49, 40, 866, DateTimeKind.Utc).AddTicks(395), new DateTime(2023, 8, 21, 19, 57, 11, 487, DateTimeKind.Utc).AddTicks(7087), new DateTime(2023, 2, 19, 12, 49, 22, 818, DateTimeKind.Utc).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 1, 25, 21, 56, 2, 446, DateTimeKind.Utc).AddTicks(2617), new DateTime(2020, 12, 5, 20, 31, 53, 679, DateTimeKind.Utc).AddTicks(9205), new DateTime(2019, 1, 19, 7, 13, 49, 922, DateTimeKind.Utc).AddTicks(9307), new DateTime(2020, 8, 21, 13, 44, 25, 88, DateTimeKind.Utc).AddTicks(5382) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 23, 16, 27, 4, 185, DateTimeKind.Utc).AddTicks(9572), new DateTime(2023, 8, 4, 1, 49, 56, 723, DateTimeKind.Utc).AddTicks(3281), new DateTime(2020, 12, 26, 4, 54, 32, 526, DateTimeKind.Utc).AddTicks(3327), new DateTime(2021, 12, 2, 12, 50, 10, 363, DateTimeKind.Utc).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 7, 7, 3, 17, 907, DateTimeKind.Utc).AddTicks(6825), new DateTime(2023, 7, 6, 8, 28, 20, 323, DateTimeKind.Utc).AddTicks(588), new DateTime(2023, 6, 25, 15, 52, 21, 792, DateTimeKind.Utc).AddTicks(1442), new DateTime(2023, 7, 22, 2, 32, 2, 665, DateTimeKind.Utc).AddTicks(1169) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 3, 26, 22, 21, 59, 958, DateTimeKind.Utc).AddTicks(8478), new DateTime(2020, 2, 27, 12, 19, 34, 469, DateTimeKind.Utc).AddTicks(5913), new DateTime(2019, 11, 27, 13, 20, 57, 129, DateTimeKind.Utc).AddTicks(3863), new DateTime(2022, 3, 12, 5, 35, 29, 635, DateTimeKind.Utc).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 7, 10, 59, 1, 523, DateTimeKind.Utc).AddTicks(9050), new DateTime(2023, 5, 31, 13, 11, 57, 526, DateTimeKind.Utc).AddTicks(1504), new DateTime(2022, 3, 4, 10, 52, 4, 692, DateTimeKind.Utc).AddTicks(5829), new DateTime(2023, 6, 17, 15, 15, 9, 400, DateTimeKind.Utc).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 11, 23, 3, 34, 905, DateTimeKind.Utc).AddTicks(3144), new DateTime(2023, 5, 4, 3, 46, 34, 238, DateTimeKind.Utc).AddTicks(7737), new DateTime(2019, 12, 15, 14, 42, 45, 530, DateTimeKind.Utc).AddTicks(3686), new DateTime(2022, 5, 15, 0, 40, 37, 682, DateTimeKind.Utc).AddTicks(5785) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 3, 27, 3, 55, 36, 883, DateTimeKind.Utc).AddTicks(5600), new DateTime(2020, 3, 21, 17, 32, 14, 949, DateTimeKind.Utc).AddTicks(8204), new DateTime(2017, 7, 19, 21, 24, 56, 303, DateTimeKind.Utc).AddTicks(9515), new DateTime(2023, 9, 1, 2, 27, 40, 469, DateTimeKind.Utc).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 5, 24, 0, 44, 42, 799, DateTimeKind.Utc).AddTicks(9306), new DateTime(2019, 8, 2, 13, 15, 27, 810, DateTimeKind.Utc).AddTicks(9862), new DateTime(2019, 3, 31, 12, 33, 4, 84, DateTimeKind.Utc).AddTicks(2341), new DateTime(2020, 9, 19, 6, 9, 43, 275, DateTimeKind.Utc).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 9, 5, 23, 981, DateTimeKind.Utc).AddTicks(1969), new DateTime(2023, 4, 5, 7, 42, 39, 375, DateTimeKind.Utc).AddTicks(7753), new DateTime(2021, 4, 12, 18, 19, 17, 225, DateTimeKind.Utc).AddTicks(6475), new DateTime(2022, 4, 10, 2, 50, 49, 443, DateTimeKind.Utc).AddTicks(9665) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 26, 10, 5, 3, 547, DateTimeKind.Utc).AddTicks(76), new DateTime(2023, 5, 16, 5, 57, 4, 565, DateTimeKind.Utc).AddTicks(5847), new DateTime(2023, 2, 13, 17, 2, 0, 541, DateTimeKind.Utc).AddTicks(7612), new DateTime(2023, 4, 3, 18, 43, 23, 95, DateTimeKind.Utc).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2023, 2, 21, 23, 19, 52, 631, DateTimeKind.Utc).AddTicks(2147), new DateTime(2022, 12, 26, 9, 32, 7, 876, DateTimeKind.Utc).AddTicks(1944), new DateTime(2022, 7, 5, 12, 5, 44, 288, DateTimeKind.Utc).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 2, 14, 36, 574, DateTimeKind.Utc).AddTicks(6588), new DateTime(2023, 5, 27, 20, 22, 5, 234, DateTimeKind.Utc).AddTicks(4966), new DateTime(2023, 3, 26, 20, 21, 42, 427, DateTimeKind.Utc).AddTicks(9561), new DateTime(2023, 8, 14, 4, 2, 51, 431, DateTimeKind.Utc).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 23, 6, 48, 36, 401, DateTimeKind.Utc).AddTicks(7776), new DateTime(2023, 4, 4, 19, 33, 21, 821, DateTimeKind.Utc).AddTicks(8740), new DateTime(2023, 2, 26, 1, 55, 53, 188, DateTimeKind.Utc).AddTicks(9094), new DateTime(2023, 7, 16, 9, 39, 7, 904, DateTimeKind.Utc).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 12, 13, 14, 41, 367, DateTimeKind.Utc).AddTicks(6872), new DateTime(2023, 7, 21, 13, 56, 36, 568, DateTimeKind.Utc).AddTicks(7712), new DateTime(2021, 8, 6, 1, 27, 46, 647, DateTimeKind.Utc).AddTicks(8907), new DateTime(2022, 6, 24, 9, 32, 59, 183, DateTimeKind.Utc).AddTicks(8591) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 8, 9, 9, 30, 26, 667, DateTimeKind.Utc).AddTicks(8562), new DateTime(2023, 8, 21, 14, 42, 10, 294, DateTimeKind.Utc).AddTicks(3575), new DateTime(2023, 8, 17, 14, 2, 34, 229, DateTimeKind.Utc).AddTicks(7318), new DateTime(2023, 8, 30, 5, 28, 4, 489, DateTimeKind.Utc).AddTicks(4476) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 11, 16, 59, 26, 682, DateTimeKind.Utc).AddTicks(134), new DateTime(2022, 4, 2, 19, 21, 46, 190, DateTimeKind.Utc).AddTicks(1545), new DateTime(2022, 2, 10, 2, 5, 45, 700, DateTimeKind.Utc).AddTicks(7547), new DateTime(2023, 7, 3, 0, 24, 27, 0, DateTimeKind.Utc).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 9, 3, 8, 38, 27, 218, DateTimeKind.Utc).AddTicks(5585), new DateTime(2022, 6, 24, 3, 10, 35, 443, DateTimeKind.Utc).AddTicks(8178), new DateTime(2019, 6, 15, 10, 46, 15, 31, DateTimeKind.Utc).AddTicks(7121), new DateTime(2019, 8, 24, 10, 12, 35, 16, DateTimeKind.Utc).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 19, 20, 28, 24, 28, DateTimeKind.Utc).AddTicks(3271), new DateTime(2023, 9, 2, 23, 44, 46, 592, DateTimeKind.Utc).AddTicks(7879), new DateTime(2022, 8, 18, 18, 17, 53, 89, DateTimeKind.Utc).AddTicks(1540), new DateTime(2022, 9, 16, 10, 58, 19, 536, DateTimeKind.Utc).AddTicks(3521) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2019, 12, 2, 21, 32, 7, 181, DateTimeKind.Utc).AddTicks(7966), new DateTime(2019, 10, 28, 11, 1, 12, 576, DateTimeKind.Utc).AddTicks(9253), new DateTime(2018, 8, 4, 8, 16, 51, 976, DateTimeKind.Utc).AddTicks(4290), new DateTime(2021, 3, 20, 4, 4, 3, 557, DateTimeKind.Utc).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 12, 18, 18, 23, 43, 130, DateTimeKind.Utc).AddTicks(7941), new DateTime(2021, 11, 24, 2, 4, 0, 81, DateTimeKind.Utc).AddTicks(1922), new DateTime(2021, 4, 10, 5, 53, 11, 563, DateTimeKind.Utc).AddTicks(473), new DateTime(2021, 12, 8, 13, 33, 36, 830, DateTimeKind.Utc).AddTicks(3727) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 0, 46, 3, 559, DateTimeKind.Utc).AddTicks(49), new DateTime(2023, 4, 7, 13, 43, 25, 155, DateTimeKind.Utc).AddTicks(3260), new DateTime(2022, 7, 10, 3, 19, 41, 223, DateTimeKind.Utc).AddTicks(564), new DateTime(2023, 4, 20, 7, 34, 51, 432, DateTimeKind.Utc).AddTicks(2946) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 50, 59, 568, DateTimeKind.Utc).AddTicks(8416), new DateTime(2023, 8, 19, 2, 38, 16, 896, DateTimeKind.Utc).AddTicks(1927), new DateTime(2023, 6, 28, 3, 38, 55, 761, DateTimeKind.Utc).AddTicks(6199), new DateTime(2023, 8, 24, 21, 57, 47, 604, DateTimeKind.Utc).AddTicks(4764) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 25, 17, 45, 51, 444, DateTimeKind.Utc).AddTicks(9184), new DateTime(2023, 6, 29, 11, 38, 12, 796, DateTimeKind.Utc).AddTicks(7018), new DateTime(2023, 5, 24, 11, 57, 19, 529, DateTimeKind.Utc).AddTicks(3086) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 2, 22, 58, 654, DateTimeKind.Utc).AddTicks(5925), new DateTime(2022, 7, 10, 16, 34, 57, 222, DateTimeKind.Utc).AddTicks(5688), new DateTime(2020, 12, 18, 14, 29, 28, 682, DateTimeKind.Utc).AddTicks(4407), new DateTime(2022, 8, 8, 16, 30, 25, 874, DateTimeKind.Utc).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 20, 17, 4, 84, DateTimeKind.Utc).AddTicks(9918), new DateTime(2020, 1, 26, 5, 28, 26, 87, DateTimeKind.Utc).AddTicks(6649), new DateTime(2019, 11, 29, 19, 44, 23, 262, DateTimeKind.Utc).AddTicks(2470), new DateTime(2023, 6, 13, 13, 58, 5, 756, DateTimeKind.Utc).AddTicks(9079) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 16, 58, 8, 4, DateTimeKind.Utc).AddTicks(8806), new DateTime(2023, 7, 17, 4, 24, 46, 606, DateTimeKind.Utc).AddTicks(3006), new DateTime(2020, 6, 7, 10, 30, 22, 85, DateTimeKind.Utc).AddTicks(2362), new DateTime(2020, 11, 4, 0, 26, 5, 65, DateTimeKind.Utc).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 26, 13, 15, 45, 707, DateTimeKind.Utc).AddTicks(4462), new DateTime(2023, 8, 21, 15, 50, 57, 867, DateTimeKind.Utc).AddTicks(6832), new DateTime(2023, 8, 7, 8, 0, 35, 252, DateTimeKind.Utc).AddTicks(9288), new DateTime(2023, 9, 5, 17, 49, 14, 540, DateTimeKind.Utc).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 4, 10, 1, 463, DateTimeKind.Utc).AddTicks(2863), new DateTime(2023, 8, 16, 22, 13, 34, 297, DateTimeKind.Utc).AddTicks(8894), new DateTime(2023, 7, 2, 18, 16, 22, 235, DateTimeKind.Utc).AddTicks(4611), new DateTime(2023, 7, 27, 14, 48, 44, 68, DateTimeKind.Utc).AddTicks(1187) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 11, 7, 22, 669, DateTimeKind.Utc).AddTicks(2039), new DateTime(2023, 4, 25, 23, 17, 40, 382, DateTimeKind.Utc).AddTicks(6712), new DateTime(2022, 9, 17, 12, 44, 51, 266, DateTimeKind.Utc).AddTicks(8753), new DateTime(2023, 3, 22, 11, 46, 22, 814, DateTimeKind.Utc).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 19, 8, 45, 28, 815, DateTimeKind.Utc).AddTicks(7168), new DateTime(2022, 2, 15, 2, 39, 14, 833, DateTimeKind.Utc).AddTicks(2651), new DateTime(2020, 6, 14, 12, 26, 28, 420, DateTimeKind.Utc).AddTicks(6004), new DateTime(2021, 11, 23, 15, 40, 24, 812, DateTimeKind.Utc).AddTicks(5956) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 22, 18, 16, 59, 339, DateTimeKind.Utc).AddTicks(5034), new DateTime(2023, 8, 30, 6, 27, 3, 372, DateTimeKind.Utc).AddTicks(1759), new DateTime(2023, 4, 16, 17, 36, 58, 406, DateTimeKind.Utc).AddTicks(6121), new DateTime(2023, 8, 12, 20, 46, 10, 46, DateTimeKind.Utc).AddTicks(2045) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 7, 4, 12, 40, 14, 503, DateTimeKind.Utc).AddTicks(8181), new DateTime(2021, 12, 13, 12, 17, 48, 743, DateTimeKind.Utc).AddTicks(3036), new DateTime(2020, 1, 4, 22, 59, 55, 134, DateTimeKind.Utc).AddTicks(6190), new DateTime(2021, 2, 23, 4, 44, 11, 673, DateTimeKind.Utc).AddTicks(2167) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 6, 21, 3, 19, 56, 71, DateTimeKind.Utc).AddTicks(8582), new DateTime(2023, 8, 30, 6, 20, 48, 430, DateTimeKind.Utc).AddTicks(7022), new DateTime(2023, 4, 5, 0, 0, 29, 299, DateTimeKind.Utc).AddTicks(9985), new DateTime(2023, 8, 26, 17, 23, 37, 524, DateTimeKind.Utc).AddTicks(9661) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2021, 8, 14, 3, 54, 27, 886, DateTimeKind.Utc).AddTicks(2394), new DateTime(2021, 7, 1, 4, 50, 32, 50, DateTimeKind.Utc).AddTicks(5725), new DateTime(2020, 3, 6, 14, 48, 32, 882, DateTimeKind.Utc).AddTicks(7871) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 4, 29, 14, 53, 16, 446, DateTimeKind.Utc).AddTicks(1524), new DateTime(2021, 5, 13, 8, 26, 41, 137, DateTimeKind.Utc).AddTicks(3132), new DateTime(2019, 10, 31, 2, 0, 58, 407, DateTimeKind.Utc).AddTicks(894), new DateTime(2023, 2, 17, 6, 3, 56, 609, DateTimeKind.Utc).AddTicks(1121) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 18, 17, 52, 37, 419, DateTimeKind.Utc).AddTicks(4132), new DateTime(2023, 8, 8, 3, 39, 41, 638, DateTimeKind.Utc).AddTicks(3897), new DateTime(2023, 7, 7, 3, 42, 28, 475, DateTimeKind.Utc).AddTicks(2636), new DateTime(2023, 8, 2, 12, 21, 6, 268, DateTimeKind.Utc).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 30, 53, 147, DateTimeKind.Utc).AddTicks(3030), new DateTime(2023, 8, 6, 8, 11, 59, 644, DateTimeKind.Utc).AddTicks(7418), new DateTime(2022, 3, 24, 22, 36, 21, 740, DateTimeKind.Utc).AddTicks(1467), new DateTime(2022, 4, 13, 4, 58, 27, 569, DateTimeKind.Utc).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 2, 47, 168, DateTimeKind.Utc).AddTicks(3940), new DateTime(2022, 9, 11, 0, 54, 49, 642, DateTimeKind.Utc).AddTicks(5389), new DateTime(2021, 10, 21, 7, 24, 12, 264, DateTimeKind.Utc).AddTicks(9789), new DateTime(2022, 4, 13, 12, 49, 44, 390, DateTimeKind.Utc).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 1, 20, 2, 43, 17, 39, DateTimeKind.Utc).AddTicks(3284), new DateTime(2022, 9, 23, 2, 10, 38, 122, DateTimeKind.Utc).AddTicks(4935), new DateTime(2022, 8, 8, 5, 6, 9, 534, DateTimeKind.Utc).AddTicks(2589), new DateTime(2023, 8, 4, 20, 28, 15, 915, DateTimeKind.Utc).AddTicks(8071) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 5, 7, 3, 47, 442, DateTimeKind.Utc).AddTicks(586), new DateTime(2023, 9, 10, 20, 20, 15, 200, DateTimeKind.Utc).AddTicks(7814), new DateTime(2023, 7, 8, 21, 3, 11, 317, DateTimeKind.Utc).AddTicks(4100), new DateTime(2023, 7, 16, 8, 33, 28, 470, DateTimeKind.Utc).AddTicks(9637) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 3, 19, 7, 1, 617, DateTimeKind.Utc).AddTicks(2772), new DateTime(2022, 9, 18, 23, 36, 49, 770, DateTimeKind.Utc).AddTicks(5576), new DateTime(2022, 6, 9, 15, 53, 11, 868, DateTimeKind.Utc).AddTicks(926), new DateTime(2022, 12, 12, 16, 7, 33, 744, DateTimeKind.Utc).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 30, 10, 3, 39, 761, DateTimeKind.Utc).AddTicks(2826), new DateTime(2023, 3, 14, 5, 29, 31, 918, DateTimeKind.Utc).AddTicks(2016), new DateTime(2023, 2, 18, 12, 34, 31, 198, DateTimeKind.Utc).AddTicks(2188), new DateTime(2023, 5, 4, 23, 59, 16, 591, DateTimeKind.Utc).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 11, 8, 43, 1, 369, DateTimeKind.Utc).AddTicks(4095), new DateTime(2022, 12, 2, 0, 11, 45, 346, DateTimeKind.Utc).AddTicks(4052), new DateTime(2017, 4, 19, 8, 22, 47, 792, DateTimeKind.Utc).AddTicks(7409), new DateTime(2023, 7, 15, 10, 26, 46, 769, DateTimeKind.Utc).AddTicks(3196) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 23, 0, 30, 29, 846, DateTimeKind.Utc).AddTicks(5465), new DateTime(2023, 1, 15, 10, 18, 38, 658, DateTimeKind.Utc).AddTicks(6549), new DateTime(2022, 11, 1, 6, 9, 33, 314, DateTimeKind.Utc).AddTicks(5453), new DateTime(2023, 3, 15, 2, 56, 19, 711, DateTimeKind.Utc).AddTicks(7406) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 3, 22, 13, 28, 395, DateTimeKind.Utc).AddTicks(3445), new DateTime(2022, 8, 22, 16, 56, 34, 522, DateTimeKind.Utc).AddTicks(9298), new DateTime(2021, 10, 11, 10, 23, 14, 905, DateTimeKind.Utc).AddTicks(4954), new DateTime(2023, 4, 4, 14, 48, 52, 424, DateTimeKind.Utc).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 9, 11, 3, 49, 130, DateTimeKind.Utc).AddTicks(6743), new DateTime(2023, 3, 30, 12, 3, 41, 608, DateTimeKind.Utc).AddTicks(7158), new DateTime(2019, 11, 4, 20, 55, 59, 320, DateTimeKind.Utc).AddTicks(5715), new DateTime(2020, 8, 26, 21, 17, 15, 836, DateTimeKind.Utc).AddTicks(739) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 12, 8, 29, 56, 842, DateTimeKind.Utc).AddTicks(4781), new DateTime(2023, 5, 15, 18, 7, 3, 954, DateTimeKind.Utc).AddTicks(7353), new DateTime(2022, 3, 2, 14, 14, 21, 840, DateTimeKind.Utc).AddTicks(470), new DateTime(2022, 7, 13, 19, 50, 49, 228, DateTimeKind.Utc).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 27, 11, 25, 24, 431, DateTimeKind.Utc).AddTicks(2688), new DateTime(2022, 10, 28, 16, 53, 56, 295, DateTimeKind.Utc).AddTicks(6734), new DateTime(2022, 6, 2, 10, 32, 32, 93, DateTimeKind.Utc).AddTicks(385), new DateTime(2023, 4, 11, 19, 27, 44, 328, DateTimeKind.Utc).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 6, 7, 17, 55, 4, 667, DateTimeKind.Utc).AddTicks(9430), new DateTime(2021, 8, 10, 2, 49, 35, 930, DateTimeKind.Utc).AddTicks(2922), new DateTime(2021, 6, 23, 10, 41, 23, 968, DateTimeKind.Utc).AddTicks(1699), new DateTime(2022, 4, 6, 0, 30, 13, 529, DateTimeKind.Utc).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 10, 21, 22, 14, 3, DateTimeKind.Utc).AddTicks(4268), new DateTime(2023, 9, 3, 20, 15, 15, 128, DateTimeKind.Utc).AddTicks(2209), new DateTime(2019, 3, 25, 15, 45, 59, 389, DateTimeKind.Utc).AddTicks(4473), new DateTime(2020, 11, 15, 18, 48, 56, 325, DateTimeKind.Utc).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 3, 8, 43, 15, 815, DateTimeKind.Utc).AddTicks(6927), new DateTime(2022, 10, 25, 6, 24, 30, 230, DateTimeKind.Utc).AddTicks(7124), new DateTime(2022, 6, 16, 4, 53, 19, 24, DateTimeKind.Utc).AddTicks(7447), new DateTime(2022, 12, 21, 13, 53, 24, 846, DateTimeKind.Utc).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2018, 4, 5, 8, 26, 47, 459, DateTimeKind.Utc).AddTicks(475), new DateTime(2018, 3, 19, 6, 41, 49, 936, DateTimeKind.Utc).AddTicks(9363), new DateTime(2017, 9, 19, 20, 48, 1, 286, DateTimeKind.Utc).AddTicks(7264), new DateTime(2019, 7, 11, 18, 53, 37, 788, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 8, 2, 0, 17, 58, 651, DateTimeKind.Utc).AddTicks(9334), new DateTime(2023, 8, 6, 11, 31, 30, 669, DateTimeKind.Utc).AddTicks(4079), new DateTime(2023, 7, 5, 6, 4, 41, 5, DateTimeKind.Utc).AddTicks(8724), new DateTime(2023, 7, 10, 23, 37, 13, 560, DateTimeKind.Utc).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 1, 13, 11, 542, DateTimeKind.Utc).AddTicks(2253), new DateTime(2023, 1, 23, 3, 29, 23, 304, DateTimeKind.Utc).AddTicks(9056), new DateTime(2021, 7, 6, 8, 34, 32, 695, DateTimeKind.Utc).AddTicks(9766), new DateTime(2022, 11, 3, 8, 9, 8, 29, DateTimeKind.Utc).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 3, 21, 14, 57, 29, 230, DateTimeKind.Utc).AddTicks(839), new DateTime(2022, 2, 25, 12, 23, 11, 470, DateTimeKind.Utc).AddTicks(3163), new DateTime(2021, 10, 31, 2, 21, 45, 30, DateTimeKind.Utc).AddTicks(1934), new DateTime(2023, 2, 6, 19, 58, 27, 76, DateTimeKind.Utc).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 12, 29, 2, 948, DateTimeKind.Utc).AddTicks(4196), new DateTime(2023, 4, 28, 4, 14, 55, 379, DateTimeKind.Utc).AddTicks(3425), new DateTime(2022, 10, 12, 22, 32, 18, 170, DateTimeKind.Utc).AddTicks(2258), new DateTime(2023, 8, 25, 4, 31, 0, 69, DateTimeKind.Utc).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 1, 12, 29, 681, DateTimeKind.Utc).AddTicks(6051), new DateTime(2023, 8, 17, 6, 0, 28, 684, DateTimeKind.Utc).AddTicks(2096), new DateTime(2022, 3, 11, 5, 39, 9, 157, DateTimeKind.Utc).AddTicks(7179), new DateTime(2022, 8, 25, 13, 10, 45, 753, DateTimeKind.Utc).AddTicks(1399) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 5, 6, 2, 739, DateTimeKind.Utc).AddTicks(9223), new DateTime(2023, 6, 25, 17, 56, 6, 524, DateTimeKind.Utc).AddTicks(7777), new DateTime(2021, 7, 8, 7, 34, 7, 215, DateTimeKind.Utc).AddTicks(5184), new DateTime(2021, 12, 12, 3, 29, 18, 988, DateTimeKind.Utc).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 4, 7, 11, 38, 290, DateTimeKind.Utc).AddTicks(7813), new DateTime(2023, 8, 17, 16, 8, 5, 118, DateTimeKind.Utc).AddTicks(640), new DateTime(2023, 7, 4, 17, 41, 13, 459, DateTimeKind.Utc).AddTicks(9828), new DateTime(2023, 9, 5, 12, 22, 54, 199, DateTimeKind.Utc).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 8, 12, 11, 12, 890, DateTimeKind.Utc).AddTicks(4341), new DateTime(2023, 5, 13, 9, 38, 54, 963, DateTimeKind.Utc).AddTicks(8930), new DateTime(2023, 3, 23, 11, 28, 52, 17, DateTimeKind.Utc).AddTicks(3012), new DateTime(2023, 3, 29, 2, 11, 19, 953, DateTimeKind.Utc).AddTicks(7232) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 19, 5, 29, 44, 61, DateTimeKind.Utc).AddTicks(162), new DateTime(2022, 12, 31, 22, 47, 17, 478, DateTimeKind.Utc).AddTicks(8009), new DateTime(2022, 2, 21, 3, 54, 7, 394, DateTimeKind.Utc).AddTicks(8441), new DateTime(2022, 7, 18, 11, 19, 50, 900, DateTimeKind.Utc).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 3, 20, 45, 33, 74, DateTimeKind.Utc).AddTicks(1817), new DateTime(2023, 6, 4, 9, 37, 7, 541, DateTimeKind.Utc).AddTicks(7478), new DateTime(2022, 1, 8, 23, 47, 48, 797, DateTimeKind.Utc).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 4, 16, 27, 33, 774, DateTimeKind.Utc).AddTicks(7685), new DateTime(2022, 12, 29, 17, 29, 58, 781, DateTimeKind.Utc).AddTicks(8963), new DateTime(2022, 11, 10, 13, 30, 22, 298, DateTimeKind.Utc).AddTicks(8531), new DateTime(2023, 9, 4, 5, 32, 19, 365, DateTimeKind.Utc).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 20, 45, 28, 430, DateTimeKind.Utc).AddTicks(2929), new DateTime(2018, 11, 23, 12, 14, 55, 9, DateTimeKind.Utc).AddTicks(9141), new DateTime(2017, 4, 11, 18, 32, 0, 326, DateTimeKind.Utc).AddTicks(7385), new DateTime(2017, 12, 27, 15, 28, 35, 279, DateTimeKind.Utc).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 6, 21, 40, 13, 413, DateTimeKind.Utc).AddTicks(5042), new DateTime(2022, 9, 27, 17, 8, 28, 718, DateTimeKind.Utc).AddTicks(6310), new DateTime(2021, 11, 1, 2, 53, 32, 731, DateTimeKind.Utc).AddTicks(1756), new DateTime(2022, 8, 6, 7, 26, 47, 339, DateTimeKind.Utc).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 12, 14, 4, 8, 350, DateTimeKind.Utc).AddTicks(4256), new DateTime(2023, 9, 8, 15, 23, 58, 565, DateTimeKind.Utc).AddTicks(3628), new DateTime(2023, 9, 6, 15, 52, 34, 368, DateTimeKind.Utc).AddTicks(5559), new DateTime(2023, 9, 8, 19, 54, 49, 992, DateTimeKind.Utc).AddTicks(9326) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 10, 23, 1, 39, 15, 724, DateTimeKind.Utc).AddTicks(4179), new DateTime(2021, 11, 24, 6, 31, 59, 377, DateTimeKind.Utc).AddTicks(5405), new DateTime(2018, 4, 20, 18, 6, 58, 847, DateTimeKind.Utc).AddTicks(3517), new DateTime(2019, 7, 12, 10, 23, 52, 226, DateTimeKind.Utc).AddTicks(6955) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 5, 38, 41, 712, DateTimeKind.Utc).AddTicks(8181), new DateTime(2023, 9, 8, 10, 47, 48, 226, DateTimeKind.Utc).AddTicks(5928), new DateTime(2023, 8, 31, 21, 22, 13, 599, DateTimeKind.Utc).AddTicks(3558), new DateTime(2023, 9, 4, 17, 8, 3, 455, DateTimeKind.Utc).AddTicks(3009) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 6, 7, 4, 51, 24, 951, DateTimeKind.Utc).AddTicks(7410), new DateTime(2023, 4, 9, 12, 50, 1, 46, DateTimeKind.Utc).AddTicks(2885), new DateTime(2016, 11, 13, 17, 53, 17, 500, DateTimeKind.Utc).AddTicks(2957), new DateTime(2020, 9, 27, 18, 20, 57, 736, DateTimeKind.Utc).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 11, 7, 17, 42, 201, DateTimeKind.Utc).AddTicks(2528), new DateTime(2023, 4, 7, 9, 41, 35, 971, DateTimeKind.Utc).AddTicks(9685), new DateTime(2022, 9, 3, 19, 34, 49, 132, DateTimeKind.Utc).AddTicks(2315), new DateTime(2023, 8, 20, 6, 47, 1, 336, DateTimeKind.Utc).AddTicks(4443) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 4, 23, 13, 11, 577, DateTimeKind.Utc).AddTicks(8886), new DateTime(2023, 4, 10, 8, 6, 27, 647, DateTimeKind.Utc).AddTicks(5255), new DateTime(2023, 4, 5, 4, 57, 32, 545, DateTimeKind.Utc).AddTicks(1134), new DateTime(2023, 8, 6, 17, 58, 56, 758, DateTimeKind.Utc).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 2, 11, 18, 21, 55, 924, DateTimeKind.Utc).AddTicks(3711), new DateTime(2021, 1, 29, 1, 19, 40, 175, DateTimeKind.Utc).AddTicks(7997), new DateTime(2019, 6, 24, 7, 14, 30, 385, DateTimeKind.Utc).AddTicks(4173), new DateTime(2022, 10, 3, 19, 59, 14, 279, DateTimeKind.Utc).AddTicks(5774) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 22, 5, 2, 55, 691, DateTimeKind.Utc).AddTicks(3187), new DateTime(2023, 5, 7, 23, 23, 28, 236, DateTimeKind.Utc).AddTicks(1426), new DateTime(2022, 9, 26, 19, 5, 30, 412, DateTimeKind.Utc).AddTicks(5425), new DateTime(2023, 1, 13, 12, 30, 17, 345, DateTimeKind.Utc).AddTicks(7987) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 22, 55, 57, 561, DateTimeKind.Utc).AddTicks(7675), new DateTime(2023, 6, 3, 15, 7, 4, 407, DateTimeKind.Utc).AddTicks(4098), new DateTime(2019, 4, 6, 10, 0, 7, 530, DateTimeKind.Utc).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 9, 26, 3, 41, 30, 825, DateTimeKind.Utc).AddTicks(1225), new DateTime(2021, 9, 29, 20, 51, 8, 880, DateTimeKind.Utc).AddTicks(860), new DateTime(2021, 4, 4, 4, 39, 31, 572, DateTimeKind.Utc).AddTicks(66), new DateTime(2023, 6, 3, 14, 48, 50, 576, DateTimeKind.Utc).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 6, 0, 20, 55, 547, DateTimeKind.Utc).AddTicks(2905), new DateTime(2023, 8, 1, 0, 28, 44, 769, DateTimeKind.Utc).AddTicks(2477), new DateTime(2023, 7, 19, 18, 24, 0, 938, DateTimeKind.Utc).AddTicks(6677), new DateTime(2023, 8, 18, 1, 29, 38, 677, DateTimeKind.Utc).AddTicks(858) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 29, 2, 2, 48, 885, DateTimeKind.Utc).AddTicks(5882), new DateTime(2023, 6, 10, 13, 4, 5, 306, DateTimeKind.Utc).AddTicks(2476), new DateTime(2023, 1, 17, 8, 5, 17, 142, DateTimeKind.Utc).AddTicks(3937), new DateTime(2023, 3, 23, 6, 28, 50, 283, DateTimeKind.Utc).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 21, 7, 8, 12, 234, DateTimeKind.Utc).AddTicks(4920), new DateTime(2023, 2, 3, 16, 29, 29, 641, DateTimeKind.Utc).AddTicks(4595), new DateTime(2022, 5, 27, 21, 4, 0, 764, DateTimeKind.Utc).AddTicks(5890), new DateTime(2023, 3, 4, 23, 32, 34, 589, DateTimeKind.Utc).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 5, 18, 10, 9, 31, 293, DateTimeKind.Utc).AddTicks(3018), new DateTime(2020, 6, 25, 0, 41, 49, 511, DateTimeKind.Utc).AddTicks(1911), new DateTime(2017, 10, 11, 21, 38, 55, 756, DateTimeKind.Utc).AddTicks(5817), new DateTime(2018, 6, 1, 4, 52, 16, 434, DateTimeKind.Utc).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 3, 14, 0, 22, 750, DateTimeKind.Utc).AddTicks(6938), new DateTime(2023, 7, 23, 6, 24, 32, 732, DateTimeKind.Utc).AddTicks(2215), new DateTime(2021, 5, 19, 3, 35, 34, 724, DateTimeKind.Utc).AddTicks(3553), new DateTime(2021, 10, 11, 6, 18, 1, 732, DateTimeKind.Utc).AddTicks(1345) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 20, 6, 19, 45, 376, DateTimeKind.Utc).AddTicks(8910), new DateTime(2023, 2, 25, 17, 1, 2, 125, DateTimeKind.Utc).AddTicks(1996), new DateTime(2022, 12, 17, 2, 48, 6, 186, DateTimeKind.Utc).AddTicks(411), new DateTime(2023, 2, 10, 11, 42, 35, 474, DateTimeKind.Utc).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 7, 18, 47, 35, 660, DateTimeKind.Utc).AddTicks(1524), new DateTime(2023, 8, 1, 15, 4, 23, 794, DateTimeKind.Utc).AddTicks(9449), new DateTime(2022, 12, 30, 19, 46, 28, 991, DateTimeKind.Utc).AddTicks(2917), new DateTime(2023, 8, 6, 16, 43, 27, 479, DateTimeKind.Utc).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 8, 26, 5, 55, 38, 294, DateTimeKind.Utc).AddTicks(3686), new DateTime(2022, 5, 24, 8, 52, 4, 911, DateTimeKind.Utc).AddTicks(9864), new DateTime(2021, 7, 5, 18, 48, 53, 108, DateTimeKind.Utc).AddTicks(2676), new DateTime(2022, 1, 27, 14, 8, 44, 613, DateTimeKind.Utc).AddTicks(3558) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 22, 44, 6, 417, DateTimeKind.Utc).AddTicks(5576), new DateTime(2023, 9, 1, 4, 15, 35, 797, DateTimeKind.Utc).AddTicks(5152), new DateTime(2023, 6, 14, 19, 52, 25, 658, DateTimeKind.Utc).AddTicks(9668), new DateTime(2023, 7, 29, 1, 9, 56, 842, DateTimeKind.Utc).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 28, 8, 50, 53, 815, DateTimeKind.Utc).AddTicks(8407), new DateTime(2023, 8, 29, 20, 50, 33, 101, DateTimeKind.Utc).AddTicks(1069), new DateTime(2023, 8, 11, 1, 12, 37, 427, DateTimeKind.Utc).AddTicks(5882), new DateTime(2023, 8, 26, 3, 11, 39, 903, DateTimeKind.Utc).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 4, 3, 18, 42, 13, 133, DateTimeKind.Utc).AddTicks(1803), new DateTime(2020, 12, 12, 19, 46, 27, 532, DateTimeKind.Utc).AddTicks(8751), new DateTime(2019, 10, 9, 18, 31, 59, 895, DateTimeKind.Utc).AddTicks(6312), new DateTime(2023, 7, 30, 13, 2, 11, 829, DateTimeKind.Utc).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 20, 38, 27, 60, DateTimeKind.Utc).AddTicks(7643), new DateTime(2023, 4, 19, 14, 38, 27, 269, DateTimeKind.Utc).AddTicks(8056), new DateTime(2022, 11, 16, 16, 32, 22, 443, DateTimeKind.Utc).AddTicks(5698), new DateTime(2023, 1, 19, 19, 32, 5, 993, DateTimeKind.Utc).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 1, 5, 1, 47, 18, 849, DateTimeKind.Utc).AddTicks(1197), new DateTime(2022, 9, 3, 8, 56, 39, 592, DateTimeKind.Utc).AddTicks(8481), new DateTime(2022, 8, 22, 10, 45, 47, 681, DateTimeKind.Utc).AddTicks(2314), new DateTime(2023, 1, 28, 13, 38, 34, 42, DateTimeKind.Utc).AddTicks(7446) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 10, 24, 22, 0, 28, 525, DateTimeKind.Utc).AddTicks(2435), new DateTime(2019, 11, 16, 2, 31, 57, 631, DateTimeKind.Utc).AddTicks(1850), new DateTime(2017, 6, 28, 8, 30, 20, 243, DateTimeKind.Utc).AddTicks(5273), new DateTime(2018, 8, 8, 16, 16, 43, 734, DateTimeKind.Utc).AddTicks(4129) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 29, 4, 37, 0, 383, DateTimeKind.Utc).AddTicks(2022), new DateTime(2023, 7, 25, 16, 18, 4, 397, DateTimeKind.Utc).AddTicks(2692), new DateTime(2023, 7, 1, 1, 33, 26, 294, DateTimeKind.Utc).AddTicks(2831), new DateTime(2023, 7, 15, 20, 21, 39, 815, DateTimeKind.Utc).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 22, 21, 41, 17, 66, DateTimeKind.Utc).AddTicks(1707), new DateTime(2022, 11, 26, 10, 54, 21, 349, DateTimeKind.Utc).AddTicks(3928), new DateTime(2022, 5, 12, 20, 46, 49, 578, DateTimeKind.Utc).AddTicks(625), new DateTime(2023, 1, 9, 2, 14, 28, 960, DateTimeKind.Utc).AddTicks(626) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 1, 5, 8, 24, 4, 998, DateTimeKind.Utc).AddTicks(8424), new DateTime(2020, 5, 1, 10, 18, 8, 9, DateTimeKind.Utc).AddTicks(5260), new DateTime(2019, 8, 30, 12, 43, 5, 851, DateTimeKind.Utc).AddTicks(9156), new DateTime(2020, 12, 2, 14, 30, 17, 307, DateTimeKind.Utc).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 7, 23, 48, 14, 653, DateTimeKind.Utc).AddTicks(457), new DateTime(2023, 8, 10, 14, 16, 31, 746, DateTimeKind.Utc).AddTicks(4733), new DateTime(2023, 5, 2, 1, 2, 54, 471, DateTimeKind.Utc).AddTicks(731), new DateTime(2023, 8, 27, 20, 57, 34, 727, DateTimeKind.Utc).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 22, 17, 57, 17, 423, DateTimeKind.Utc).AddTicks(1437), new DateTime(2022, 8, 18, 11, 58, 12, 788, DateTimeKind.Utc).AddTicks(7155), new DateTime(2022, 6, 18, 21, 3, 26, 461, DateTimeKind.Utc).AddTicks(1258), new DateTime(2022, 10, 9, 23, 20, 26, 522, DateTimeKind.Utc).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 10, 21, 13, 23, 194, DateTimeKind.Utc).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 30, 4, 34, 15, 485, DateTimeKind.Utc).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 20, 18, 0, 40, 82, DateTimeKind.Utc).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 21, 42, 3, 781, DateTimeKind.Utc).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 23, 19, 19, 12, 939, DateTimeKind.Utc).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 19, 8, 22, 20, 767, DateTimeKind.Utc).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 18, 0, 48, 33, 623, DateTimeKind.Utc).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 7, 47, 47, 862, DateTimeKind.Utc).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 3, 7, 2, 27, 724, DateTimeKind.Utc).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 21, 9, 18, 59, 77, DateTimeKind.Utc).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 18, 6, 42, 12, 567, DateTimeKind.Utc).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 14, 22, 15, 21, 732, DateTimeKind.Utc).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 2, 11, 37, 51, 483, DateTimeKind.Utc).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 16, 55, 8, 527, DateTimeKind.Utc).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 1, 17, 54, 4, 112, DateTimeKind.Utc).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 14, 19, 59, 24, 348, DateTimeKind.Utc).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 8, 20, 20, 2, 211, DateTimeKind.Utc).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 12, 15, 35, 13, 449, DateTimeKind.Utc).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 13, 1, 27, 14, 854, DateTimeKind.Utc).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 3, 17, 46, 16, 408, DateTimeKind.Utc).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 26, 11, 19, 50, 481, DateTimeKind.Utc).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 11, 2, 47, 29, 647, DateTimeKind.Utc).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 30, 13, 19, 39, 273, DateTimeKind.Utc).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 15, 18, 11, 47, 451, DateTimeKind.Utc).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 22, 12, 26, 39, 514, DateTimeKind.Utc).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 7, 22, 55, 43, 806, DateTimeKind.Utc).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 19, 4, 12, 31, 10, DateTimeKind.Utc).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 25, 16, 54, 22, 189, DateTimeKind.Utc).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 15, 3, 5, 31, 888, DateTimeKind.Utc).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 5, 34, 30, 760, DateTimeKind.Utc).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 26, 14, 10, 47, 163, DateTimeKind.Utc).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 20, 9, 55, 102, DateTimeKind.Utc).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 6, 6, 37, 36, 426, DateTimeKind.Utc).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 0, 36, 57, 547, DateTimeKind.Utc).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedAt",
                value: new DateTime(2020, 3, 27, 4, 54, 54, 557, DateTimeKind.Utc).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 8, 10, 4, 430, DateTimeKind.Utc).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 22, 17, 11, 282, DateTimeKind.Utc).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 2, 2, 17, 20, 193, DateTimeKind.Utc).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 11, 7, 13, 16, 561, DateTimeKind.Utc).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 15, 9, 27, 8, 703, DateTimeKind.Utc).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 24, 12, 17, 2, 840, DateTimeKind.Utc).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 6, 35, 32, 317, DateTimeKind.Utc).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 9, 21, 7, 151, DateTimeKind.Utc).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 27, 3, 38, 16, 930, DateTimeKind.Utc).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 10, 13, 57, 0, 313, DateTimeKind.Utc).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 22, 6, 9, 534, DateTimeKind.Utc).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedAt",
                value: new DateTime(2021, 6, 6, 13, 53, 53, 39, DateTimeKind.Utc).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 48L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 15, 1, 13, 37, 554, DateTimeKind.Utc).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 11, 6, 40, 514, DateTimeKind.Utc).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 6, 54, 38, 756, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 7, 35, 12, 117, DateTimeKind.Utc).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 10, 34, 44, 135, DateTimeKind.Utc).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 15, 14, 28, 14, 549, DateTimeKind.Utc).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 20, 16, 37, 59, 63, DateTimeKind.Utc).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 2, 28, 28, 573, DateTimeKind.Utc).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 56L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 12, 20, 17, 39, 883, DateTimeKind.Utc).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 5, 18, 21, 440, DateTimeKind.Utc).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 25, 21, 48, 15, 754, DateTimeKind.Utc).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 7, 1, 47, 58, 645, DateTimeKind.Utc).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 16, 4, 11, 15, 116, DateTimeKind.Utc).AddTicks(4269));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 25, 18, 11, 4, 697, DateTimeKind.Utc).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 4, 9, 0, 393, DateTimeKind.Utc).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 14, 33, 8, 275, DateTimeKind.Utc).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 64L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 20, 14, 0, 14, 122, DateTimeKind.Utc).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 3, 11, 18, 8, 190, DateTimeKind.Utc).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 18, 42, 55, 857, DateTimeKind.Utc).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 14, 12, 31, 9, 729, DateTimeKind.Utc).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 25, 10, 51, 5, 40, DateTimeKind.Utc).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 22, 13, 41, 954, DateTimeKind.Utc).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 30, 13, 34, 36, 831, DateTimeKind.Utc).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 8, 15, 4, 14, 851, DateTimeKind.Utc).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 72L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 19, 3, 48, 5, 522, DateTimeKind.Utc).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 28, 4, 4, 34, 71, DateTimeKind.Utc).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 17, 46, 3, 926, DateTimeKind.Utc).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 13, 6, 4, 29, 485, DateTimeKind.Utc).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 31, 14, 17, 44, 117, DateTimeKind.Utc).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 1, 10, 59, 16, 818, DateTimeKind.Utc).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 13, 36, 38, 696, DateTimeKind.Utc).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 21, 14, 59, 35, 995, DateTimeKind.Utc).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 80L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 6, 49, 8, 51, DateTimeKind.Utc).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 25, 16, 31, 29, 788, DateTimeKind.Utc).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 20, 31, 33, 603, DateTimeKind.Utc).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 19, 20, 52, 98, DateTimeKind.Utc).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedAt",
                value: new DateTime(2020, 2, 3, 17, 19, 49, 232, DateTimeKind.Utc).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 11, 5, 32, 4, 880, DateTimeKind.Utc).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 4, 26, 24, 96, DateTimeKind.Utc).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 15, 7, 54, 19, 881, DateTimeKind.Utc).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 88L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 28, 3, 2, 52, 542, DateTimeKind.Utc).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 24, 19, 26, 59, 23, DateTimeKind.Utc).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 29, 14, 51, 9, 523, DateTimeKind.Utc).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 20, 18, 16, 57, 817, DateTimeKind.Utc).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 10, 5, 42, 4, 998, DateTimeKind.Utc).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 12, 12, 23, 21, 970, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 26, 4, 58, 1, 274, DateTimeKind.Utc).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 30, 2, 27, 18, 611, DateTimeKind.Utc).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 96L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 8, 5, 5, 18, 896, DateTimeKind.Utc).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 20, 22, 51, 976, DateTimeKind.Utc).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 14, 8, 12, 5, 301, DateTimeKind.Utc).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 18, 5, 41, 35, 10, DateTimeKind.Utc).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 23, 15, 55, 57, 840, DateTimeKind.Utc).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 23, 41, 4, 402, DateTimeKind.Utc).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 7, 4, 12, 13, 588, DateTimeKind.Utc).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 3, 11, 46, 0, 990, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 104L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 7, 0, 22, 0, 603, DateTimeKind.Utc).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 22, 17, 39, 3, 679, DateTimeKind.Utc).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedAt",
                value: new DateTime(2021, 12, 12, 15, 12, 27, 163, DateTimeKind.Utc).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 4, 17, 26, 12, 139, DateTimeKind.Utc).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 30, 11, 38, 49, 57, DateTimeKind.Utc).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 29, 17, 55, 22, 46, DateTimeKind.Utc).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 28, 16, 47, 30, 91, DateTimeKind.Utc).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 2, 22, 29, 54, 233, DateTimeKind.Utc).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 112L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 7, 59, 31, 328, DateTimeKind.Utc).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 22, 17, 5, 9, 848, DateTimeKind.Utc).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 3, 15, 17, 56, 799, DateTimeKind.Utc).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 7, 4, 11, 30, 639, DateTimeKind.Utc).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 7, 21, 28, 2, 734, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedAt",
                value: new DateTime(2022, 1, 2, 16, 58, 52, 718, DateTimeKind.Utc).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedAt",
                value: new DateTime(2022, 1, 27, 11, 5, 59, 193, DateTimeKind.Utc).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 11, 31, 50, 225, DateTimeKind.Utc).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 120L,
                column: "CreatedAt",
                value: new DateTime(2022, 1, 9, 12, 37, 45, 640, DateTimeKind.Utc).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 18, 6, 39, 152, DateTimeKind.Utc).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 10, 9, 57, 7, 219, DateTimeKind.Utc).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 20, 22, 20, 51, 454, DateTimeKind.Utc).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 2, 21, 4, 38, 122, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 7, 8, 49, 7, 560, DateTimeKind.Utc).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 20, 5, 12, 0, 229, DateTimeKind.Utc).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 0, 8, 48, 375, DateTimeKind.Utc).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 128L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 18, 20, 12, 570, DateTimeKind.Utc).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 16, 42, 36, 337, DateTimeKind.Utc).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 1, 22, 32, 354, DateTimeKind.Utc).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 4, 57, 49, 715, DateTimeKind.Utc).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 22, 24, 17, 479, DateTimeKind.Utc).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 24, 1, 39, 35, 469, DateTimeKind.Utc).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 31, 4, 12, 34, 222, DateTimeKind.Utc).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 11, 15, 45, 411, DateTimeKind.Utc).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 136L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 10, 6, 23, 23, 151, DateTimeKind.Utc).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 21, 5, 33, 46, 308, DateTimeKind.Utc).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 10, 4, 17, 53, 373, DateTimeKind.Utc).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 20, 10, 23, 134, DateTimeKind.Utc).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 5, 20, 56, 56, 927, DateTimeKind.Utc).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 12, 19, 11, 592, DateTimeKind.Utc).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 23, 4, 49, 55, 375, DateTimeKind.Utc).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 7, 18, 35, 29, 458, DateTimeKind.Utc).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 144L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 10, 18, 19, 10, 975, DateTimeKind.Utc).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 17, 56, 22, 692, DateTimeKind.Utc).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedAt",
                value: new DateTime(2021, 12, 14, 21, 42, 7, 781, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 6, 17, 24, 29, 415, DateTimeKind.Utc).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 4, 3, 8, 27, 246, DateTimeKind.Utc).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 26, 6, 47, 2, 616, DateTimeKind.Utc).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 7, 12, 42, 18, 616, DateTimeKind.Utc).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 8, 31, 35, 996, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 152L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 19, 17, 44, 16, 337, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 18, 4, 46, 10, 989, DateTimeKind.Utc).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 11, 6, 49, 53, 159, DateTimeKind.Utc).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 31, 22, 35, 13, 55, DateTimeKind.Utc).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 16, 15, 22, 42, 240, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 29, 8, 43, 59, 311, DateTimeKind.Utc).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 8, 0, 38, 7, 985, DateTimeKind.Utc).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 26, 21, 32, 3, 941, DateTimeKind.Utc).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 160L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 24, 21, 10, 6, 830, DateTimeKind.Utc).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 7, 3, 33, 24, 259, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 13, 16, 42, 47, 795, DateTimeKind.Utc).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 26, 20, 55, 52, 963, DateTimeKind.Utc).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 20, 31, 34, 24, DateTimeKind.Utc).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 12, 1, 55, 25, 350, DateTimeKind.Utc).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 11, 47, 29, 836, DateTimeKind.Utc).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 7, 21, 20, 43, 929, DateTimeKind.Utc).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 168L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 16, 42, 21, 216, DateTimeKind.Utc).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 30, 7, 28, 5, 292, DateTimeKind.Utc).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 20, 1, 4, 387, DateTimeKind.Utc).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 12, 15, 47, 3, 253, DateTimeKind.Utc).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 7, 0, 14, 5, 277, DateTimeKind.Utc).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 11, 14, 8, 59, 8, DateTimeKind.Utc).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 5, 10, 13, 6, 181, DateTimeKind.Utc).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 11, 11, 21, 35, 55, DateTimeKind.Utc).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 176L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 12, 3, 18, 5, 873, DateTimeKind.Utc).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 5, 7, 12, 20, 202, DateTimeKind.Utc).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 14, 18, 44, 45, 151, DateTimeKind.Utc).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 8, 19, 26, 51, 303, DateTimeKind.Utc).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 2, 6, 54, 24, 592, DateTimeKind.Utc).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 14, 22, 50, 54, 278, DateTimeKind.Utc).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 30, 11, 42, 5, 910, DateTimeKind.Utc).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 1, 54, 6, 762, DateTimeKind.Utc).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 184L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 9, 24, 0, 395, DateTimeKind.Utc).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 2, 8, 59, 8, 837, DateTimeKind.Utc).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 19, 11, 36, 19, 316, DateTimeKind.Utc).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 20, 8, 7, 566, DateTimeKind.Utc).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 17, 9, 50, 757, DateTimeKind.Utc).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 0, 37, 23, 647, DateTimeKind.Utc).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 28, 8, 39, 27, 980, DateTimeKind.Utc).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 16, 2, 2, 45, 226, DateTimeKind.Utc).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 192L,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 14, 11, 29, 26, 176, DateTimeKind.Utc).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 9, 15, 45, 36, 498, DateTimeKind.Utc).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 26, 19, 57, 16, 24, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 5, 1, 7, 37, 957, DateTimeKind.Utc).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 1, 23, 54, 16, 346, DateTimeKind.Utc).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 4, 42, 12, 604, DateTimeKind.Utc).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 11, 13, 6, 30, 233, DateTimeKind.Utc).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 19, 9, 45, 40, 108, DateTimeKind.Utc).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 200L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 6, 10, 58, 51, 644, DateTimeKind.Utc).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BadgeId", "CreatedAt" },
                values: new object[] { 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 11L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 11L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 11L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 34L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "BadgeId", "CreatedAt" },
                values: new object[] { 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 11L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 12L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 11L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "BadgeId", "CreatedAt" },
                values: new object[] { 11L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 12L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 12L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 12L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40L });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 24, 14, 40, 44, 34, DateTimeKind.Utc).AddTicks(2785), new DateTime(2023, 9, 8, 13, 8, 39, 633, DateTimeKind.Utc).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 5, 19, 4, 17, 340, DateTimeKind.Utc).AddTicks(9116), new DateTime(2023, 9, 9, 5, 24, 39, 312, DateTimeKind.Utc).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 21, 21, 20, 45, 159, DateTimeKind.Utc).AddTicks(8545), new DateTime(2023, 9, 10, 18, 34, 29, 831, DateTimeKind.Utc).AddTicks(9637) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 12, 5, 59, 20, 166, DateTimeKind.Utc).AddTicks(6480), new DateTime(2023, 4, 23, 6, 45, 2, 462, DateTimeKind.Utc).AddTicks(6587) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 2, 4, 15, 23, 535, DateTimeKind.Utc).AddTicks(7282), new DateTime(2023, 8, 18, 20, 7, 12, 585, DateTimeKind.Utc).AddTicks(2653) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 30, 9, 11, 38, 961, DateTimeKind.Utc).AddTicks(7910), new DateTime(2023, 6, 1, 6, 34, 17, 593, DateTimeKind.Utc).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 15, 45, 4, 376, DateTimeKind.Utc).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 15, 32, 622, DateTimeKind.Utc).AddTicks(8132), new DateTime(2023, 8, 29, 10, 59, 50, 206, DateTimeKind.Utc).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 10, 2, 18, 45, 28, 959, DateTimeKind.Utc).AddTicks(3565), new DateTime(2023, 5, 17, 12, 41, 43, 205, DateTimeKind.Utc).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 24, 21, 8, 42, 671, DateTimeKind.Utc).AddTicks(3447), new DateTime(2023, 8, 7, 5, 46, 56, 960, DateTimeKind.Utc).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 14, 0, 59, 36, 397, DateTimeKind.Utc).AddTicks(9759), new DateTime(2023, 5, 18, 20, 50, 50, 249, DateTimeKind.Utc).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 16, 22, 56, 53, 35, DateTimeKind.Utc).AddTicks(4531), new DateTime(2023, 7, 1, 10, 30, 51, 60, DateTimeKind.Utc).AddTicks(4874) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 13, 18, 45, 33, 789, DateTimeKind.Utc).AddTicks(9922), new DateTime(2023, 9, 7, 10, 54, 36, 126, DateTimeKind.Utc).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 23, 22, 24, 18, 368, DateTimeKind.Utc).AddTicks(6933), new DateTime(2023, 9, 5, 14, 55, 10, 454, DateTimeKind.Utc).AddTicks(4445) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 14, 20, 58, 0, 847, DateTimeKind.Utc).AddTicks(5409), new DateTime(2023, 8, 17, 9, 57, 5, 318, DateTimeKind.Utc).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 9, 10, 53, 55, 951, DateTimeKind.Utc).AddTicks(3663), new DateTime(2023, 9, 9, 14, 55, 34, 788, DateTimeKind.Utc).AddTicks(9491) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 20, 41, 30, 719, DateTimeKind.Utc).AddTicks(9062), new DateTime(2023, 3, 14, 8, 59, 59, 529, DateTimeKind.Utc).AddTicks(5573) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 8, 2, 3, 11, 769, DateTimeKind.Utc).AddTicks(5689), new DateTime(2023, 3, 2, 10, 35, 43, 762, DateTimeKind.Utc).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 4, 0, 219, DateTimeKind.Utc).AddTicks(4452), new DateTime(2023, 9, 7, 10, 19, 5, 872, DateTimeKind.Utc).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 28, 9, 21, 53, 310, DateTimeKind.Utc).AddTicks(2477), new DateTime(2023, 8, 11, 7, 21, 33, 346, DateTimeKind.Utc).AddTicks(1384) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 14, 15, 10, 40, 15, DateTimeKind.Utc).AddTicks(7841), new DateTime(2023, 8, 17, 17, 10, 41, 197, DateTimeKind.Utc).AddTicks(1315) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 10, 14, 11, 5, 612, DateTimeKind.Utc).AddTicks(7615), new DateTime(2023, 9, 11, 12, 44, 58, 912, DateTimeKind.Utc).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 10, 15, 20, 2, 643, DateTimeKind.Utc).AddTicks(9753), new DateTime(2023, 5, 21, 6, 50, 44, 14, DateTimeKind.Utc).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 5, 23, 33, 5, 511, DateTimeKind.Utc).AddTicks(5985), new DateTime(2023, 9, 11, 5, 34, 2, 708, DateTimeKind.Utc).AddTicks(3043) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 29, 21, 27, 41, 171, DateTimeKind.Utc).AddTicks(1490), new DateTime(2023, 5, 14, 12, 29, 51, 595, DateTimeKind.Utc).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 12, 23, 17, 46, 886, DateTimeKind.Utc).AddTicks(9367), new DateTime(2023, 8, 19, 1, 11, 0, 299, DateTimeKind.Utc).AddTicks(5399) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 7, 12, 51, 17, 883, DateTimeKind.Utc).AddTicks(7794), new DateTime(2023, 8, 10, 0, 34, 47, 838, DateTimeKind.Utc).AddTicks(7365) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 8, 21, 45, 56, 192, DateTimeKind.Utc).AddTicks(4966), new DateTime(2023, 7, 10, 1, 25, 43, 273, DateTimeKind.Utc).AddTicks(1236) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 12, 9, 0, 850, DateTimeKind.Utc).AddTicks(4171), new DateTime(2023, 8, 30, 22, 38, 20, 586, DateTimeKind.Utc).AddTicks(9334) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 11, 7, 31, 32, 489, DateTimeKind.Utc).AddTicks(8581), new DateTime(2023, 9, 11, 9, 12, 13, 494, DateTimeKind.Utc).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 2, 23, 32, 4, 723, DateTimeKind.Utc).AddTicks(7235), new DateTime(2023, 9, 4, 19, 17, 4, 890, DateTimeKind.Utc).AddTicks(6567) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 6, 18, 34, 25, 701, DateTimeKind.Utc).AddTicks(1579), new DateTime(2023, 4, 14, 17, 35, 9, 815, DateTimeKind.Utc).AddTicks(4636) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 26, 0, 42, 44, 222, DateTimeKind.Utc).AddTicks(1598), new DateTime(2023, 7, 29, 13, 47, 41, 556, DateTimeKind.Utc).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 7, 59, 42, 429, DateTimeKind.Utc).AddTicks(1804), new DateTime(2023, 8, 29, 20, 50, 48, 593, DateTimeKind.Utc).AddTicks(4109) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 10, 26, 708, DateTimeKind.Utc).AddTicks(9608), new DateTime(2023, 8, 24, 19, 32, 48, 118, DateTimeKind.Utc).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 18, 8, 28, 51, 774, DateTimeKind.Utc).AddTicks(165), new DateTime(2023, 7, 19, 22, 47, 7, 22, DateTimeKind.Utc).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 38, 26, 75, DateTimeKind.Utc).AddTicks(7864), new DateTime(2023, 5, 8, 4, 44, 2, 220, DateTimeKind.Utc).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 9, 30, 1, 52, 16, 821, DateTimeKind.Utc).AddTicks(5264), new DateTime(2023, 5, 2, 19, 6, 42, 690, DateTimeKind.Utc).AddTicks(5858) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 31, 11, 18, 33, 818, DateTimeKind.Utc).AddTicks(5701), new DateTime(2023, 5, 28, 6, 18, 2, 552, DateTimeKind.Utc).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 43, 7, 944, DateTimeKind.Utc).AddTicks(4059), new DateTime(2023, 4, 25, 23, 59, 29, 558, DateTimeKind.Utc).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 10, 17, 38, 451, DateTimeKind.Utc).AddTicks(2914), new DateTime(2023, 5, 24, 10, 40, 28, 416, DateTimeKind.Utc).AddTicks(1785) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 7, 19, 6, 23, 253, DateTimeKind.Utc).AddTicks(8936), new DateTime(2023, 9, 8, 23, 50, 59, 338, DateTimeKind.Utc).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 25, 13, 54, 54, 37, DateTimeKind.Utc).AddTicks(5961), new DateTime(2023, 9, 9, 18, 53, 15, 536, DateTimeKind.Utc).AddTicks(212) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 19, 47, 12, 931, DateTimeKind.Utc).AddTicks(2230), new DateTime(2023, 8, 4, 12, 3, 58, 976, DateTimeKind.Utc).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 23, 16, 22, 32, 178, DateTimeKind.Utc).AddTicks(4300), new DateTime(2023, 8, 6, 16, 27, 22, 559, DateTimeKind.Utc).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 4, 17, 31, 52, 100, DateTimeKind.Utc).AddTicks(3083), new DateTime(2023, 7, 12, 8, 38, 58, 841, DateTimeKind.Utc).AddTicks(590) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 5, 2, 9, 3, 210, DateTimeKind.Utc).AddTicks(4891), new DateTime(2023, 7, 7, 8, 33, 6, 424, DateTimeKind.Utc).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 1, 18, 56, 54, 434, DateTimeKind.Utc).AddTicks(2827), new DateTime(2023, 9, 6, 22, 6, 40, 916, DateTimeKind.Utc).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 3, 8, 58, 28, 202, DateTimeKind.Utc).AddTicks(5367), new DateTime(2023, 8, 14, 10, 56, 47, 781, DateTimeKind.Utc).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 19, 23, 4, 54, 465, DateTimeKind.Utc).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 16, 10, 25, 414, DateTimeKind.Utc).AddTicks(2354), new DateTime(2023, 6, 24, 9, 25, 6, 484, DateTimeKind.Utc).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 16, 20, 51, 13, 266, DateTimeKind.Utc).AddTicks(9935), new DateTime(2023, 8, 28, 6, 13, 18, 32, DateTimeKind.Utc).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 25, 12, 0, 28, 185, DateTimeKind.Utc).AddTicks(707), new DateTime(2023, 6, 1, 22, 20, 52, 639, DateTimeKind.Utc).AddTicks(8371) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 23, 39, 59, 885, DateTimeKind.Utc).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 30, 13, 37, 29, 388, DateTimeKind.Utc).AddTicks(5085), new DateTime(2023, 6, 10, 16, 11, 28, 48, DateTimeKind.Utc).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 16, 9, 1, 46, 49, DateTimeKind.Utc).AddTicks(8475), new DateTime(2023, 9, 2, 12, 43, 27, 872, DateTimeKind.Utc).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 26, 21, 49, 5, 248, DateTimeKind.Utc).AddTicks(8154), new DateTime(2023, 6, 29, 15, 31, 5, 563, DateTimeKind.Utc).AddTicks(3122) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 1, 22, 35, 58, 664, DateTimeKind.Utc).AddTicks(439), new DateTime(2023, 8, 16, 10, 49, 35, 22, DateTimeKind.Utc).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 3, 12, 11, 35, 623, DateTimeKind.Utc).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 10, 22, 56, 51, 659, DateTimeKind.Utc).AddTicks(4251), new DateTime(2023, 9, 11, 1, 23, 8, 114, DateTimeKind.Utc).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 3, 11, 32, 39, 691, DateTimeKind.Utc).AddTicks(3540), new DateTime(2023, 9, 4, 10, 34, 1, 197, DateTimeKind.Utc).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 20, 8, 34, 49, 971, DateTimeKind.Utc).AddTicks(4557), new DateTime(2023, 8, 20, 12, 29, 18, 470, DateTimeKind.Utc).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 5, 13, 3, 36, 141, DateTimeKind.Utc).AddTicks(3025), new DateTime(2023, 9, 10, 18, 55, 43, 503, DateTimeKind.Utc).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 17, 8, 2, 45, 215, DateTimeKind.Utc).AddTicks(1925), new DateTime(2023, 7, 13, 14, 5, 35, 997, DateTimeKind.Utc).AddTicks(6878) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 4, 4, 39, 38, 929, DateTimeKind.Utc).AddTicks(8130), new DateTime(2023, 9, 4, 18, 59, 58, 642, DateTimeKind.Utc).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 6, 14, 8, 49, 944, DateTimeKind.Utc).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 1, 4, 16, 52, 20, 845, DateTimeKind.Utc).AddTicks(2892), new DateTime(2021, 12, 7, 12, 6, 9, 889, DateTimeKind.Utc).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 6, 1, 53, 52, 36, DateTimeKind.Utc).AddTicks(9771), new DateTime(2023, 7, 14, 19, 14, 53, 171, DateTimeKind.Utc).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 9, 19, 41, 44, 114, DateTimeKind.Utc).AddTicks(8246), new DateTime(2023, 9, 10, 18, 5, 27, 10, DateTimeKind.Utc).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 7, 20, 9, 3, 826, DateTimeKind.Utc).AddTicks(6152), new DateTime(2023, 3, 2, 6, 14, 33, 283, DateTimeKind.Utc).AddTicks(9533) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 9, 19, 41, 1, 356, DateTimeKind.Utc).AddTicks(930), new DateTime(2023, 9, 11, 12, 26, 49, 346, DateTimeKind.Utc).AddTicks(5578) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 17, 4, 5, 9, 964, DateTimeKind.Utc).AddTicks(2972), new DateTime(2023, 2, 5, 8, 3, 19, 382, DateTimeKind.Utc).AddTicks(9587) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 11, 11, 19, 36, 52, 688, DateTimeKind.Utc).AddTicks(9317), new DateTime(2023, 3, 18, 19, 44, 34, 382, DateTimeKind.Utc).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 4, 5, 30, 12, 499, DateTimeKind.Utc).AddTicks(9169), new DateTime(2023, 9, 4, 11, 12, 57, 310, DateTimeKind.Utc).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 3, 13, 3, 31, 589, DateTimeKind.Utc).AddTicks(4437), new DateTime(2023, 4, 17, 12, 55, 43, 10, DateTimeKind.Utc).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 11, 0, 43, 856, DateTimeKind.Utc).AddTicks(597), new DateTime(2023, 1, 30, 21, 47, 24, 190, DateTimeKind.Utc).AddTicks(136) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 3, 5, 40, 14, 185, DateTimeKind.Utc).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 15, 6, 20, 22, 87, DateTimeKind.Utc).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 11, 8, 13, 34, 907, DateTimeKind.Utc).AddTicks(5501), new DateTime(2023, 9, 11, 10, 47, 46, 922, DateTimeKind.Utc).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 26, 1, 58, 30, 93, DateTimeKind.Utc).AddTicks(3827), new DateTime(2023, 8, 27, 3, 31, 21, 213, DateTimeKind.Utc).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 31, 7, 0, 40, 626, DateTimeKind.Utc).AddTicks(18), new DateTime(2023, 7, 23, 17, 57, 36, 549, DateTimeKind.Utc).AddTicks(74) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 11, 13, 39, 30, 416, DateTimeKind.Utc).AddTicks(7220), new DateTime(2023, 9, 11, 13, 44, 24, 614, DateTimeKind.Utc).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 4, 18, 15, 45, 881, DateTimeKind.Utc).AddTicks(5737), new DateTime(2023, 6, 14, 11, 13, 50, 670, DateTimeKind.Utc).AddTicks(389) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 6, 5, 4, 49, 1, 263, DateTimeKind.Utc).AddTicks(7027), new DateTime(2023, 3, 14, 22, 43, 43, 419, DateTimeKind.Utc).AddTicks(6769) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 8, 4, 4, 54, 585, DateTimeKind.Utc).AddTicks(1465), new DateTime(2023, 9, 11, 7, 1, 19, 996, DateTimeKind.Utc).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 8, 13, 33, 58, 346, DateTimeKind.Utc).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 25, 1, 52, 29, 812, DateTimeKind.Utc).AddTicks(5179), new DateTime(2023, 8, 8, 4, 44, 3, 690, DateTimeKind.Utc).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 5, 12, 20, 46, 52, 426, DateTimeKind.Utc).AddTicks(5091), new DateTime(2022, 3, 28, 17, 51, 3, 52, DateTimeKind.Utc).AddTicks(3963) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 3, 8, 8, 59, 17, 626, DateTimeKind.Utc).AddTicks(5804), new DateTime(2023, 7, 25, 22, 22, 28, 322, DateTimeKind.Utc).AddTicks(935) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 22, 8, 27, 17, 690, DateTimeKind.Utc).AddTicks(3200), new DateTime(2023, 9, 9, 7, 0, 51, 524, DateTimeKind.Utc).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 15, 9, 0, 3, 629, DateTimeKind.Utc).AddTicks(6565), new DateTime(2023, 8, 1, 17, 44, 47, 577, DateTimeKind.Utc).AddTicks(1384) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 9, 2, 14, 31, 75, DateTimeKind.Utc).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 25, 4, 13, 8, 256, DateTimeKind.Utc).AddTicks(9628), new DateTime(2023, 8, 29, 17, 46, 11, 171, DateTimeKind.Utc).AddTicks(4006) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 3, 27, 15, 26, 44, 250, DateTimeKind.Utc).AddTicks(4226), new DateTime(2023, 5, 28, 14, 6, 38, 758, DateTimeKind.Utc).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 4, 13, 52, 53, 983, DateTimeKind.Utc).AddTicks(7909), new DateTime(2023, 9, 7, 12, 46, 51, 355, DateTimeKind.Utc).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 30, 17, 38, 48, 396, DateTimeKind.Utc).AddTicks(2917), new DateTime(2023, 9, 7, 20, 16, 33, 350, DateTimeKind.Utc).AddTicks(4932) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 15, 0, 52, 11, 653, DateTimeKind.Utc).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 17, 14, 28, 22, 790, DateTimeKind.Utc).AddTicks(4990), new DateTime(2023, 8, 18, 0, 55, 23, 849, DateTimeKind.Utc).AddTicks(4090) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 20, 12, 9, 11, 209, DateTimeKind.Utc).AddTicks(3869), new DateTime(2023, 6, 7, 21, 17, 53, 89, DateTimeKind.Utc).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 4, 7, 49, 36, 312, DateTimeKind.Utc).AddTicks(4654), new DateTime(2023, 9, 8, 10, 21, 18, 917, DateTimeKind.Utc).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 7, 15, 11, 35, 22, 732, DateTimeKind.Utc).AddTicks(9378), new DateTime(2023, 2, 27, 13, 38, 46, 498, DateTimeKind.Utc).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 10, 23, 27, 360, DateTimeKind.Utc).AddTicks(8071), new DateTime(2023, 7, 31, 20, 33, 9, 754, DateTimeKind.Utc).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 28, 3, 40, 50, 275, DateTimeKind.Utc).AddTicks(7714), new DateTime(2023, 9, 9, 12, 43, 35, 656, DateTimeKind.Utc).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 23, 7, 15, 52, 572, DateTimeKind.Utc).AddTicks(108), new DateTime(2023, 9, 2, 14, 26, 41, 571, DateTimeKind.Utc).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 10, 1, 48, 449, DateTimeKind.Utc).AddTicks(2514), new DateTime(2023, 9, 11, 3, 7, 59, 833, DateTimeKind.Utc).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 5, 24, 14, 49, 14, 696, DateTimeKind.Utc).AddTicks(8874), new DateTime(2021, 12, 16, 18, 46, 39, 270, DateTimeKind.Utc).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 22, 14, 16, 49, 344, DateTimeKind.Utc).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 7, 3, 44, 6, 190, DateTimeKind.Utc).AddTicks(5958), new DateTime(2023, 9, 10, 0, 27, 8, 984, DateTimeKind.Utc).AddTicks(3944) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 19, 23, 16, 50, 209, DateTimeKind.Utc).AddTicks(5614), new DateTime(2023, 8, 17, 0, 34, 29, 707, DateTimeKind.Utc).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 26, 4, 13, 7, 649, DateTimeKind.Utc).AddTicks(8714), new DateTime(2023, 7, 25, 15, 57, 54, 459, DateTimeKind.Utc).AddTicks(8028) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 15, 21, 13, 34, 666, DateTimeKind.Utc).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 9, 4, 33, 18, 407, DateTimeKind.Utc).AddTicks(3999), new DateTime(2023, 4, 24, 14, 32, 7, 452, DateTimeKind.Utc).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 7, 0, 26, 13, 960, DateTimeKind.Utc).AddTicks(3906), new DateTime(2023, 8, 28, 4, 41, 10, 796, DateTimeKind.Utc).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 17, 21, 20, 47, 381, DateTimeKind.Utc).AddTicks(9688), new DateTime(2023, 8, 26, 1, 26, 47, 800, DateTimeKind.Utc).AddTicks(6644) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 5, 18, 10, 20, 865, DateTimeKind.Utc).AddTicks(489), new DateTime(2023, 9, 9, 1, 57, 15, 628, DateTimeKind.Utc).AddTicks(102) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 21, 17, 43, 8, 429, DateTimeKind.Utc).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 8, 13, 48, 5, 650, DateTimeKind.Utc).AddTicks(6564), new DateTime(2023, 9, 9, 8, 10, 1, 594, DateTimeKind.Utc).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 4, 15, 21, 19, 78, DateTimeKind.Utc).AddTicks(143), new DateTime(2023, 5, 20, 18, 41, 22, 982, DateTimeKind.Utc).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 14, 18, 37, 35, 124, DateTimeKind.Utc).AddTicks(1917), new DateTime(2023, 9, 5, 8, 41, 3, 798, DateTimeKind.Utc).AddTicks(7523) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 22, 16, 32, 29, 226, DateTimeKind.Utc).AddTicks(3340), new DateTime(2023, 8, 27, 20, 21, 51, 508, DateTimeKind.Utc).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 15, 3, 39, 1, 728, DateTimeKind.Utc).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 21, 16, 1, 14, 36, DateTimeKind.Utc).AddTicks(1746), new DateTime(2023, 8, 26, 2, 53, 10, 718, DateTimeKind.Utc).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 13, 37, 10, 408, DateTimeKind.Utc).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 1, 6, 10, 50, 117, DateTimeKind.Utc).AddTicks(277), new DateTime(2023, 9, 1, 10, 11, 13, 954, DateTimeKind.Utc).AddTicks(4153) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 2, 13, 16, 0, 22, 627, DateTimeKind.Utc).AddTicks(4225), new DateTime(2022, 12, 9, 22, 42, 44, 123, DateTimeKind.Utc).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 13, 14, 27, 37, 554, DateTimeKind.Utc).AddTicks(1785), new DateTime(2023, 6, 10, 8, 6, 25, 895, DateTimeKind.Utc).AddTicks(4671) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 53, 46, 907, DateTimeKind.Utc).AddTicks(4422), new DateTime(2023, 9, 10, 22, 10, 29, 0, DateTimeKind.Utc).AddTicks(8645) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 24, 2, 51, 3, 575, DateTimeKind.Utc).AddTicks(6788), new DateTime(2023, 7, 16, 9, 33, 21, 822, DateTimeKind.Utc).AddTicks(4400) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 8, 11, 7, 23, 459, DateTimeKind.Utc).AddTicks(2442), new DateTime(2023, 3, 14, 7, 27, 39, 102, DateTimeKind.Utc).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 11, 42, 4, 109, DateTimeKind.Utc).AddTicks(1343), new DateTime(2023, 5, 29, 18, 12, 11, 613, DateTimeKind.Utc).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 16, 3, 16, 54, 577, DateTimeKind.Utc).AddTicks(2914), new DateTime(2023, 6, 23, 8, 53, 43, 7, DateTimeKind.Utc).AddTicks(1191) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 4, 5, 26, 47, 284, DateTimeKind.Utc).AddTicks(7074), new DateTime(2023, 9, 9, 1, 58, 13, 87, DateTimeKind.Utc).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 1, 20, 1, 27, 28, 686, DateTimeKind.Utc).AddTicks(1630), new DateTime(2023, 8, 6, 23, 6, 33, 119, DateTimeKind.Utc).AddTicks(8244) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 1, 12, 36, 33, 619, DateTimeKind.Utc).AddTicks(318), new DateTime(2023, 9, 4, 14, 41, 28, 487, DateTimeKind.Utc).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 18, 17, 33, 53, 146, DateTimeKind.Utc).AddTicks(3938), new DateTime(2023, 6, 7, 6, 10, 45, 723, DateTimeKind.Utc).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 11, 9, 54, 59, 50, DateTimeKind.Utc).AddTicks(3763), new DateTime(2023, 9, 11, 10, 24, 10, 697, DateTimeKind.Utc).AddTicks(7799) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 27, 23, 29, 47, 54, DateTimeKind.Utc).AddTicks(4463), new DateTime(2023, 9, 2, 8, 49, 17, 660, DateTimeKind.Utc).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 10, 19, 24, 45, 464, DateTimeKind.Utc).AddTicks(2178), new DateTime(2023, 9, 11, 0, 53, 8, 383, DateTimeKind.Utc).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 31, 8, 57, 29, 713, DateTimeKind.Utc).AddTicks(4462), new DateTime(2023, 8, 28, 12, 59, 58, 925, DateTimeKind.Utc).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 30, 21, 463, DateTimeKind.Utc).AddTicks(9480), new DateTime(2023, 7, 16, 22, 3, 31, 91, DateTimeKind.Utc).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 7, 18, 18, 8, 469, DateTimeKind.Utc).AddTicks(6379), new DateTime(2023, 5, 24, 6, 59, 57, 593, DateTimeKind.Utc).AddTicks(8424) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 14, 10, 37, 24, 665, DateTimeKind.Utc).AddTicks(6329), new DateTime(2023, 8, 15, 12, 2, 48, 872, DateTimeKind.Utc).AddTicks(8603) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 20, 8, 39, 36, 902, DateTimeKind.Utc).AddTicks(7737), new DateTime(2023, 8, 19, 22, 37, 7, 34, DateTimeKind.Utc).AddTicks(4988) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2021, 11, 11, 13, 58, 36, 58, DateTimeKind.Utc).AddTicks(9135), new DateTime(2023, 1, 26, 3, 49, 38, 704, DateTimeKind.Utc).AddTicks(6698) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 20, 13, 40, 58, 224, DateTimeKind.Utc).AddTicks(3420), new DateTime(2023, 8, 7, 22, 5, 36, 131, DateTimeKind.Utc).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 28, 10, 0, 49, 335, DateTimeKind.Utc).AddTicks(255), new DateTime(2023, 9, 8, 5, 31, 32, 483, DateTimeKind.Utc).AddTicks(7489) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 25, 1, 59, 55, 868, DateTimeKind.Utc).AddTicks(240), new DateTime(2023, 8, 10, 1, 18, 11, 402, DateTimeKind.Utc).AddTicks(1312) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 29, 4, 47, 37, 725, DateTimeKind.Utc).AddTicks(763), new DateTime(2023, 9, 2, 20, 25, 9, 128, DateTimeKind.Utc).AddTicks(1172) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 5, 19, 3, 32, 634, DateTimeKind.Utc).AddTicks(9729), new DateTime(2023, 4, 15, 11, 48, 9, 708, DateTimeKind.Utc).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 10, 7, 43, 23, 793, DateTimeKind.Utc).AddTicks(7029), new DateTime(2023, 9, 3, 14, 38, 36, 320, DateTimeKind.Utc).AddTicks(7414) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 7, 20, 12, 52, 97, DateTimeKind.Utc).AddTicks(5394), new DateTime(2023, 3, 25, 5, 8, 51, 293, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 10, 30, 11, 47, 47, 517, DateTimeKind.Utc).AddTicks(7040), new DateTime(2022, 11, 29, 20, 49, 12, 445, DateTimeKind.Utc).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 5, 2, 3, 7, 178, DateTimeKind.Utc).AddTicks(252), new DateTime(2023, 9, 6, 4, 33, 12, 957, DateTimeKind.Utc).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 11, 19, 56, 39, 350, DateTimeKind.Utc).AddTicks(503), new DateTime(2023, 3, 12, 9, 5, 11, 735, DateTimeKind.Utc).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 9, 3, 5, 28, 14, 994, DateTimeKind.Utc).AddTicks(8225), new DateTime(2022, 11, 2, 2, 23, 42, 349, DateTimeKind.Utc).AddTicks(4668) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 6, 21, 19, 56, 830, DateTimeKind.Utc).AddTicks(6329), new DateTime(2023, 9, 8, 17, 7, 45, 32, DateTimeKind.Utc).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 7, 12, 20, 24, 41, 90, DateTimeKind.Utc).AddTicks(2411), new DateTime(2023, 1, 21, 11, 0, 14, 708, DateTimeKind.Utc).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 8, 20, 7, 26, 301, DateTimeKind.Utc).AddTicks(6135), new DateTime(2023, 7, 23, 5, 39, 2, 834, DateTimeKind.Utc).AddTicks(5804) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 15, 14, 34, 12, 204, DateTimeKind.Utc).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 10, 2, 21, 25, 432, DateTimeKind.Utc).AddTicks(3267), new DateTime(2023, 4, 7, 10, 31, 50, 855, DateTimeKind.Utc).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 12, 9, 14, 27, 4, 69, DateTimeKind.Utc).AddTicks(4606), new DateTime(2023, 7, 3, 14, 58, 38, 831, DateTimeKind.Utc).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 162L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 2, 11, 2, 22, 45, DateTimeKind.Utc).AddTicks(4514), new DateTime(2023, 9, 8, 16, 31, 15, 889, DateTimeKind.Utc).AddTicks(8493) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 163L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 10, 9, 26, 29, 49, DateTimeKind.Utc).AddTicks(8191), new DateTime(2023, 9, 11, 0, 50, 33, 203, DateTimeKind.Utc).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 164L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 31, 19, 44, 41, 227, DateTimeKind.Utc).AddTicks(2105), new DateTime(2023, 9, 8, 3, 42, 2, 330, DateTimeKind.Utc).AddTicks(1059) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 165L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 31, 11, 54, 36, 943, DateTimeKind.Utc).AddTicks(5956), new DateTime(2023, 9, 2, 8, 59, 57, 470, DateTimeKind.Utc).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 8, 22, 40, 19, 687, DateTimeKind.Utc).AddTicks(3701), new DateTime(2023, 8, 24, 12, 37, 8, 907, DateTimeKind.Utc).AddTicks(8244) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 7, 8, 47, 50, 167, DateTimeKind.Utc).AddTicks(1827), new DateTime(2023, 9, 8, 20, 15, 29, 298, DateTimeKind.Utc).AddTicks(803) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 15, 21, 40, 45, 830, DateTimeKind.Utc).AddTicks(8388), new DateTime(2023, 7, 26, 23, 8, 2, 655, DateTimeKind.Utc).AddTicks(3384) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 18, 10, 12, 19, 6, DateTimeKind.Utc).AddTicks(4522), new DateTime(2023, 9, 7, 14, 4, 8, 701, DateTimeKind.Utc).AddTicks(9277) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 40, 30, 357, DateTimeKind.Utc).AddTicks(2138), new DateTime(2023, 8, 3, 3, 58, 38, 581, DateTimeKind.Utc).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 9, 54, 47, 997, DateTimeKind.Utc).AddTicks(9113), new DateTime(2023, 8, 6, 15, 47, 29, 646, DateTimeKind.Utc).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 22, 6, 41, 20, 753, DateTimeKind.Utc).AddTicks(1810), new DateTime(2023, 8, 27, 6, 33, 47, 676, DateTimeKind.Utc).AddTicks(4259) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 2, 19, 31, 48, 349, DateTimeKind.Utc).AddTicks(6846), new DateTime(2023, 7, 15, 5, 58, 12, 970, DateTimeKind.Utc).AddTicks(9581) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 2, 1, 35, 2, 686, DateTimeKind.Utc).AddTicks(2302), new DateTime(2023, 9, 1, 11, 4, 30, 534, DateTimeKind.Utc).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 7, 28, 14, 18, 14, 533, DateTimeKind.Utc).AddTicks(5984), new DateTime(2023, 5, 21, 5, 20, 11, 716, DateTimeKind.Utc).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 28, 6, 36, 24, 351, DateTimeKind.Utc).AddTicks(8734), new DateTime(2023, 8, 21, 14, 13, 57, 568, DateTimeKind.Utc).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 12, 20, 44, 1, 490, DateTimeKind.Utc).AddTicks(748), new DateTime(2023, 4, 15, 15, 46, 57, 599, DateTimeKind.Utc).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 3, 30, 23, 57, 12, 917, DateTimeKind.Utc).AddTicks(9899), new DateTime(2023, 4, 9, 0, 39, 18, 225, DateTimeKind.Utc).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 18, 8, 10, 55, 501, DateTimeKind.Utc).AddTicks(7496), new DateTime(2023, 5, 18, 13, 49, 16, 662, DateTimeKind.Utc).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 13, 14, 8, 41, 309, DateTimeKind.Utc).AddTicks(1505), new DateTime(2023, 6, 19, 18, 51, 27, 508, DateTimeKind.Utc).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 6, 6, 4, 15, 48, 231, DateTimeKind.Utc).AddTicks(1604), new DateTime(2023, 3, 26, 13, 18, 52, 366, DateTimeKind.Utc).AddTicks(6268) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 59, 45, 231, DateTimeKind.Utc).AddTicks(9986), new DateTime(2023, 8, 4, 0, 46, 52, 790, DateTimeKind.Utc).AddTicks(1051) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 28, 13, 29, 40, 773, DateTimeKind.Utc).AddTicks(4769), new DateTime(2023, 8, 7, 2, 35, 37, 529, DateTimeKind.Utc).AddTicks(5764) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 3, 17, 59, 10, 224, DateTimeKind.Utc).AddTicks(1209), new DateTime(2023, 9, 6, 6, 19, 55, 569, DateTimeKind.Utc).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 5, 15, 48, 395, DateTimeKind.Utc).AddTicks(5063), new DateTime(2023, 6, 2, 4, 10, 51, 598, DateTimeKind.Utc).AddTicks(6151) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 6, 7, 18, 31, 15, 893, DateTimeKind.Utc).AddTicks(1842), new DateTime(2023, 6, 18, 17, 10, 57, 946, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 10, 8, 18, 1, 5, 14, DateTimeKind.Utc).AddTicks(6407), new DateTime(2022, 11, 15, 11, 34, 50, 752, DateTimeKind.Utc).AddTicks(6658) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 23, 26, 45, 312, DateTimeKind.Utc).AddTicks(7185), new DateTime(2023, 7, 29, 15, 36, 18, 279, DateTimeKind.Utc).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 3, 4, 20, 10, 85, DateTimeKind.Utc).AddTicks(7482), new DateTime(2023, 9, 4, 4, 2, 23, 917, DateTimeKind.Utc).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2020, 11, 23, 1, 18, 9, 668, DateTimeKind.Utc).AddTicks(7053), new DateTime(2023, 5, 11, 4, 21, 5, 546, DateTimeKind.Utc).AddTicks(5528) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 8, 3, 0, 48, 10, 48, DateTimeKind.Utc).AddTicks(4758), new DateTime(2023, 3, 18, 3, 26, 10, 980, DateTimeKind.Utc).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 17, 0, 17, 24, 134, DateTimeKind.Utc).AddTicks(2666), new DateTime(2023, 7, 21, 13, 29, 21, 723, DateTimeKind.Utc).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 27, 9, 22, 10, 319, DateTimeKind.Utc).AddTicks(9634), new DateTime(2023, 9, 1, 16, 23, 46, 72, DateTimeKind.Utc).AddTicks(1155) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2022, 11, 27, 14, 16, 18, 654, DateTimeKind.Utc).AddTicks(4735), new DateTime(2023, 5, 31, 14, 42, 42, 188, DateTimeKind.Utc).AddTicks(5652) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 9, 9, 1, 19, 40, 967, DateTimeKind.Utc).AddTicks(8607), new DateTime(2023, 9, 10, 2, 1, 24, 846, DateTimeKind.Utc).AddTicks(7981) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 15, 1, 24, 20, 392, DateTimeKind.Utc).AddTicks(1649), new DateTime(2023, 6, 19, 16, 46, 43, 236, DateTimeKind.Utc).AddTicks(8627) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 9, 3, 32, 336, DateTimeKind.Utc).AddTicks(3296), new DateTime(2023, 5, 29, 23, 59, 20, 153, DateTimeKind.Utc).AddTicks(3825) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 56, 22, 529, DateTimeKind.Utc).AddTicks(1025), new DateTime(2023, 7, 7, 16, 46, 29, 976, DateTimeKind.Utc).AddTicks(6233) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 4, 9, 0, 21, 7, 750, DateTimeKind.Utc).AddTicks(2058), new DateTime(2023, 5, 21, 9, 46, 42, 904, DateTimeKind.Utc).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreatedAt", "SubmittedAt" },
                values: new object[] { new DateTime(2023, 8, 14, 18, 51, 44, 291, DateTimeKind.Utc).AddTicks(4943), new DateTime(2023, 9, 2, 16, 11, 7, 274, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "RegisteredAt",
                value: new DateTime(2016, 5, 19, 20, 7, 52, 608, DateTimeKind.Utc).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "RegisteredAt",
                value: new DateTime(2016, 4, 10, 16, 7, 2, 322, DateTimeKind.Utc).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                column: "RegisteredAt",
                value: new DateTime(2017, 11, 10, 13, 11, 54, 556, DateTimeKind.Utc).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                column: "RegisteredAt",
                value: new DateTime(2018, 7, 26, 6, 32, 29, 301, DateTimeKind.Utc).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                column: "RegisteredAt",
                value: new DateTime(2017, 8, 16, 4, 16, 46, 882, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                column: "RegisteredAt",
                value: new DateTime(2022, 3, 7, 3, 1, 48, 147, DateTimeKind.Utc).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                column: "RegisteredAt",
                value: new DateTime(2020, 9, 18, 8, 47, 35, 397, DateTimeKind.Utc).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                column: "RegisteredAt",
                value: new DateTime(2022, 6, 1, 12, 4, 3, 603, DateTimeKind.Utc).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                column: "RegisteredAt",
                value: new DateTime(2021, 12, 7, 11, 38, 7, 903, DateTimeKind.Utc).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                column: "RegisteredAt",
                value: new DateTime(2018, 7, 20, 11, 54, 46, 104, DateTimeKind.Utc).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11L,
                column: "RegisteredAt",
                value: new DateTime(2022, 3, 28, 17, 0, 31, 244, DateTimeKind.Utc).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12L,
                column: "RegisteredAt",
                value: new DateTime(2019, 9, 17, 7, 17, 7, 994, DateTimeKind.Utc).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13L,
                column: "RegisteredAt",
                value: new DateTime(2021, 3, 13, 5, 22, 28, 143, DateTimeKind.Utc).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14L,
                column: "RegisteredAt",
                value: new DateTime(2016, 6, 10, 1, 8, 2, 132, DateTimeKind.Utc).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15L,
                column: "RegisteredAt",
                value: new DateTime(2022, 3, 17, 1, 25, 20, 405, DateTimeKind.Utc).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16L,
                column: "RegisteredAt",
                value: new DateTime(2017, 6, 23, 7, 36, 58, 601, DateTimeKind.Utc).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17L,
                column: "RegisteredAt",
                value: new DateTime(2016, 1, 19, 22, 55, 46, 475, DateTimeKind.Utc).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18L,
                column: "RegisteredAt",
                value: new DateTime(2022, 12, 30, 17, 59, 1, 562, DateTimeKind.Utc).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19L,
                column: "RegisteredAt",
                value: new DateTime(2022, 4, 18, 2, 20, 50, 412, DateTimeKind.Utc).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20L,
                column: "RegisteredAt",
                value: new DateTime(2020, 12, 18, 21, 49, 4, 653, DateTimeKind.Utc).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21L,
                column: "RegisteredAt",
                value: new DateTime(2017, 1, 24, 19, 1, 3, 715, DateTimeKind.Utc).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22L,
                column: "RegisteredAt",
                value: new DateTime(2018, 5, 5, 0, 34, 40, 795, DateTimeKind.Utc).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23L,
                column: "RegisteredAt",
                value: new DateTime(2021, 11, 10, 12, 51, 25, 84, DateTimeKind.Utc).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24L,
                column: "RegisteredAt",
                value: new DateTime(2021, 4, 29, 17, 4, 50, 561, DateTimeKind.Utc).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25L,
                column: "RegisteredAt",
                value: new DateTime(2019, 2, 23, 6, 19, 28, 576, DateTimeKind.Utc).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26L,
                column: "RegisteredAt",
                value: new DateTime(2016, 6, 21, 20, 22, 10, 403, DateTimeKind.Utc).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27L,
                column: "RegisteredAt",
                value: new DateTime(2021, 12, 15, 9, 44, 9, 637, DateTimeKind.Utc).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28L,
                column: "RegisteredAt",
                value: new DateTime(2016, 7, 18, 11, 17, 41, 927, DateTimeKind.Utc).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29L,
                column: "RegisteredAt",
                value: new DateTime(2017, 8, 4, 15, 46, 44, 25, DateTimeKind.Utc).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30L,
                column: "RegisteredAt",
                value: new DateTime(2020, 8, 24, 14, 42, 49, 158, DateTimeKind.Utc).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31L,
                column: "RegisteredAt",
                value: new DateTime(2016, 12, 17, 1, 58, 30, 82, DateTimeKind.Utc).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32L,
                column: "RegisteredAt",
                value: new DateTime(2016, 12, 25, 3, 53, 5, 53, DateTimeKind.Utc).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33L,
                column: "RegisteredAt",
                value: new DateTime(2021, 11, 30, 15, 50, 10, 372, DateTimeKind.Utc).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34L,
                column: "RegisteredAt",
                value: new DateTime(2023, 3, 16, 23, 23, 56, 115, DateTimeKind.Utc).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35L,
                column: "RegisteredAt",
                value: new DateTime(2022, 2, 20, 3, 55, 20, 637, DateTimeKind.Utc).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36L,
                column: "RegisteredAt",
                value: new DateTime(2020, 4, 10, 9, 53, 57, 692, DateTimeKind.Utc).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37L,
                column: "RegisteredAt",
                value: new DateTime(2016, 5, 7, 12, 25, 55, 243, DateTimeKind.Utc).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38L,
                column: "RegisteredAt",
                value: new DateTime(2018, 12, 22, 20, 35, 22, 161, DateTimeKind.Utc).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39L,
                column: "RegisteredAt",
                value: new DateTime(2016, 7, 25, 0, 58, 13, 794, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40L,
                column: "RegisteredAt",
                value: new DateTime(2017, 10, 21, 18, 40, 10, 104, DateTimeKind.Utc).AddTicks(4314));
        }
    }
}
