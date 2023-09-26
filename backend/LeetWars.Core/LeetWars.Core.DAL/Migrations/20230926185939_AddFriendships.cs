using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeetWars.Core.DAL.Migrations
{
    public partial class AddFriendships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 1L, 11L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 1L, 29L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 2L, 27L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 2L, 38L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 3L, 26L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 3L, 35L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 4L, 6L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 4L, 13L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 5L, 12L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 5L, 17L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 6L, 13L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 6L, 40L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 7L, 20L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 7L, 35L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 8L, 10L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 8L, 27L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 9L, 32L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 9L, 33L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 10L, 20L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 10L, 35L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 11L, 11L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 11L, 29L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 12L, 21L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 12L, 40L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 13L, 18L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 13L, 32L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 14L, 2L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 14L, 22L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 15L, 2L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 15L, 39L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 16L, 2L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 16L, 22L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 17L, 14L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 18L, 4L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 18L, 17L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 19L, 31L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 19L, 34L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 20L, 12L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 20L, 40L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 21L, 20L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 21L, 33L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 22L, 23L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 22L, 37L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 23L, 2L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 23L, 37L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 24L, 9L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 24L, 27L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 25L, 27L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 25L, 38L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 26L, 5L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 26L, 27L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 27L, 3L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 27L, 37L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 28L, 9L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 28L, 23L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 29L, 8L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 29L, 12L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 30L, 18L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 30L, 27L });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 6, 21, 33, 18, 580, DateTimeKind.Utc).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2022, 10, 7, 20, 5, 51, 959, DateTimeKind.Utc).AddTicks(1922), 0 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 3, 12, 8, 17, 175, DateTimeKind.Utc).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2023, 4, 9, 4, 6, 49, 80, DateTimeKind.Utc).AddTicks(4542), 0 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2022, 11, 15, 1, 58, 25, 96, DateTimeKind.Utc).AddTicks(7697), 0 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2022, 12, 21, 22, 38, 20, 532, DateTimeKind.Utc).AddTicks(3462), 0 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 15, 57, 21, 652, DateTimeKind.Utc).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2022, 12, 7, 0, 34, 27, 472, DateTimeKind.Utc).AddTicks(297), 1 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 16, 23, 29, 34, 322, DateTimeKind.Utc).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 29, 13, 56, 13, 709, DateTimeKind.Utc).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 27, 14, 2, 17, 323, DateTimeKind.Utc).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2023, 2, 24, 18, 42, 41, 601, DateTimeKind.Utc).AddTicks(8683), 1 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 22, 6, 59, 19, 736, DateTimeKind.Utc).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 16, 59, 668, DateTimeKind.Utc).AddTicks(4974), 2 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2023, 3, 2, 17, 47, 34, 879, DateTimeKind.Utc).AddTicks(3480), 1 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2023, 1, 3, 1, 33, 46, 258, DateTimeKind.Utc).AddTicks(7231), 1 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 3, 5, 5, 48, 364, DateTimeKind.Utc).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 12, 18, 51, 10, 593, DateTimeKind.Utc).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2023, 3, 20, 20, 54, 52, 409, DateTimeKind.Utc).AddTicks(9513), 2 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 5, 15, 12, 1, 783, DateTimeKind.Utc).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2022, 8, 19, 4, 21, 19, 502, DateTimeKind.Utc).AddTicks(4081), 1 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2022, 8, 23, 18, 3, 33, 380, DateTimeKind.Utc).AddTicks(839), 1 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 24, 12, 34, 33, 785, DateTimeKind.Utc).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 9, 19, 49, 24, 251, DateTimeKind.Utc).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2022, 11, 17, 4, 52, 30, 276, DateTimeKind.Utc).AddTicks(75), 1 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 24, 10, 37, 41, 9, DateTimeKind.Utc).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2023, 5, 13, 1, 29, 17, 953, DateTimeKind.Utc).AddTicks(3587), 0 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2022, 8, 17, 12, 52, 25, 687, DateTimeKind.Utc).AddTicks(8878), 2 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2022, 12, 16, 22, 54, 58, 641, DateTimeKind.Utc).AddTicks(5577), 0 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 23, 17, 20, 21, 649, DateTimeKind.Utc).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 17L, 18L },
                column: "IsSender",
                value: false);

            migrationBuilder.InsertData(
                table: "UserFriendships",
                columns: new[] { "FriendshipId", "UserId", "IsSender" },
                values: new object[,]
                {
                    { 1L, 25L, false },
                    { 1L, 26L, true },
                    { 2L, 16L, false },
                    { 2L, 17L, true },
                    { 3L, 30L, true },
                    { 3L, 37L, false },
                    { 4L, 4L, true },
                    { 4L, 39L, false },
                    { 5L, 4L, false },
                    { 5L, 40L, true },
                    { 6L, 19L, false }
                });

            migrationBuilder.InsertData(
                table: "UserFriendships",
                columns: new[] { "FriendshipId", "UserId", "IsSender" },
                values: new object[,]
                {
                    { 6L, 34L, true },
                    { 7L, 6L, true },
                    { 7L, 7L, false },
                    { 8L, 9L, true },
                    { 8L, 32L, false },
                    { 9L, 11L, true },
                    { 9L, 38L, false },
                    { 10L, 4L, false },
                    { 10L, 21L, true },
                    { 11L, 17L, true },
                    { 11L, 25L, false },
                    { 12L, 22L, false },
                    { 12L, 35L, true },
                    { 13L, 22L, true },
                    { 13L, 40L, false },
                    { 14L, 20L, false },
                    { 14L, 37L, true },
                    { 15L, 7L, false },
                    { 15L, 26L, true },
                    { 16L, 23L, true },
                    { 16L, 40L, false },
                    { 17L, 16L, true },
                    { 18L, 10L, false },
                    { 18L, 24L, true },
                    { 19L, 4L, false },
                    { 19L, 25L, true },
                    { 20L, 6L, false },
                    { 20L, 15L, true },
                    { 21L, 27L, true },
                    { 21L, 34L, false },
                    { 22L, 10L, true },
                    { 22L, 19L, false },
                    { 23L, 1L, false },
                    { 23L, 25L, true },
                    { 24L, 5L, true },
                    { 24L, 16L, false },
                    { 25L, 17L, true },
                    { 25L, 26L, false },
                    { 26L, 2L, true },
                    { 26L, 18L, false },
                    { 27L, 16L, false },
                    { 27L, 35L, true }
                });

            migrationBuilder.InsertData(
                table: "UserFriendships",
                columns: new[] { "FriendshipId", "UserId", "IsSender" },
                values: new object[,]
                {
                    { 28L, 8L, false },
                    { 28L, 22L, true },
                    { 29L, 26L, false },
                    { 29L, 30L, true },
                    { 30L, 26L, true },
                    { 30L, 30L, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 1L, 25L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 1L, 26L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 2L, 16L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 2L, 17L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 3L, 30L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 3L, 37L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 4L, 4L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 4L, 39L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 5L, 4L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 5L, 40L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 6L, 19L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 6L, 34L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 7L, 6L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 7L, 7L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 8L, 9L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 8L, 32L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 9L, 11L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 9L, 38L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 10L, 4L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 10L, 21L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 11L, 17L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 11L, 25L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 12L, 22L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 12L, 35L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 13L, 22L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 13L, 40L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 14L, 20L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 14L, 37L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 15L, 7L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 15L, 26L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 16L, 23L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 16L, 40L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 17L, 16L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 18L, 10L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 18L, 24L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 19L, 4L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 19L, 25L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 20L, 6L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 20L, 15L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 21L, 27L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 21L, 34L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 22L, 10L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 22L, 19L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 23L, 1L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 23L, 25L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 24L, 5L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 24L, 16L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 25L, 17L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 25L, 26L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 26L, 2L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 26L, 18L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 27L, 16L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 27L, 35L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 28L, 8L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 28L, 22L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 29L, 26L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 29L, 30L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 30L, 26L });

            migrationBuilder.DeleteData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 30L, 30L });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 3, 58, 40, 588, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2023, 9, 9, 15, 35, 4, 989, DateTimeKind.Local).AddTicks(6127), 2 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 17, 0, 28, 4, 313, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2023, 9, 12, 17, 43, 56, 387, DateTimeKind.Local).AddTicks(7631), 2 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2023, 9, 17, 22, 43, 43, 210, DateTimeKind.Local).AddTicks(5168), 1 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2023, 9, 10, 14, 7, 26, 335, DateTimeKind.Local).AddTicks(3288), 1 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 17, 21, 3, 41, 977, DateTimeKind.Local).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2023, 9, 12, 23, 8, 42, 364, DateTimeKind.Local).AddTicks(7410), 0 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 12, 9, 16, 13, 343, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 3, 44, 16, 994, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 15, 14, 57, 26, 562, DateTimeKind.Local).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2023, 9, 17, 16, 29, 59, 104, DateTimeKind.Local).AddTicks(369), 2 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 15, 21, 55, 43, 180, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2023, 9, 13, 23, 53, 12, 452, DateTimeKind.Local).AddTicks(984), 0 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2023, 9, 10, 20, 58, 16, 813, DateTimeKind.Local).AddTicks(4098), 2 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2023, 9, 9, 6, 16, 13, 230, DateTimeKind.Local).AddTicks(2882), 2 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 18, 2, 38, 6, 294, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 6, 4, 46, 85, DateTimeKind.Local).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2023, 9, 16, 1, 46, 6, 411, DateTimeKind.Local).AddTicks(4170), 0 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 11, 3, 32, 56, 253, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2023, 9, 18, 1, 36, 46, 264, DateTimeKind.Local).AddTicks(7480), 0 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2023, 9, 16, 17, 11, 34, 190, DateTimeKind.Local).AddTicks(2458), 0 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 14, 10, 54, 59, 247, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 11, 7, 1, 49, 486, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2023, 9, 15, 9, 2, 27, 41, DateTimeKind.Local).AddTicks(2980), 0 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 9, 17, 15, 59, 165, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2023, 9, 13, 19, 35, 52, 87, DateTimeKind.Local).AddTicks(7274), 2 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2023, 9, 18, 19, 15, 58, 384, DateTimeKind.Local).AddTicks(5294), 1 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2023, 9, 17, 7, 55, 33, 861, DateTimeKind.Local).AddTicks(3360), 1 });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 17, 13, 21, 47, 801, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "UserFriendships",
                keyColumns: new[] { "FriendshipId", "UserId" },
                keyValues: new object[] { 17L, 18L },
                column: "IsSender",
                value: true);

            migrationBuilder.InsertData(
                table: "UserFriendships",
                columns: new[] { "FriendshipId", "UserId", "IsSender" },
                values: new object[,]
                {
                    { 1L, 11L, false },
                    { 1L, 29L, true },
                    { 2L, 27L, false },
                    { 2L, 38L, true },
                    { 3L, 26L, true },
                    { 3L, 35L, false },
                    { 4L, 6L, false },
                    { 4L, 13L, true },
                    { 5L, 12L, true },
                    { 5L, 17L, false },
                    { 6L, 13L, true }
                });

            migrationBuilder.InsertData(
                table: "UserFriendships",
                columns: new[] { "FriendshipId", "UserId", "IsSender" },
                values: new object[,]
                {
                    { 6L, 40L, false },
                    { 7L, 20L, true },
                    { 7L, 35L, false },
                    { 8L, 10L, true },
                    { 8L, 27L, false },
                    { 9L, 32L, true },
                    { 9L, 33L, false },
                    { 10L, 20L, true },
                    { 10L, 35L, false },
                    { 11L, 11L, false },
                    { 11L, 29L, true },
                    { 12L, 21L, false },
                    { 12L, 40L, true },
                    { 13L, 18L, true },
                    { 13L, 32L, false },
                    { 14L, 2L, false },
                    { 14L, 22L, true },
                    { 15L, 2L, true },
                    { 15L, 39L, false },
                    { 16L, 2L, false },
                    { 16L, 22L, true },
                    { 17L, 14L, false },
                    { 18L, 4L, true },
                    { 18L, 17L, false },
                    { 19L, 31L, true },
                    { 19L, 34L, false },
                    { 20L, 12L, false },
                    { 20L, 40L, true },
                    { 21L, 20L, false },
                    { 21L, 33L, true },
                    { 22L, 23L, true },
                    { 22L, 37L, false },
                    { 23L, 2L, false },
                    { 23L, 37L, true },
                    { 24L, 9L, false },
                    { 24L, 27L, true },
                    { 25L, 27L, false },
                    { 25L, 38L, true },
                    { 26L, 5L, false },
                    { 26L, 27L, true },
                    { 27L, 3L, true },
                    { 27L, 37L, false }
                });

            migrationBuilder.InsertData(
                table: "UserFriendships",
                columns: new[] { "FriendshipId", "UserId", "IsSender" },
                values: new object[,]
                {
                    { 28L, 9L, false },
                    { 28L, 23L, true },
                    { 29L, 8L, false },
                    { 29L, 12L, true },
                    { 30L, 18L, false },
                    { 30L, 27L, true }
                });
        }
    }
}
