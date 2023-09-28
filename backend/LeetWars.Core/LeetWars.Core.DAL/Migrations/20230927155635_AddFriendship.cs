using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeetWars.Core.DAL.Migrations
{
    public partial class AddFriendship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Friendships",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friendships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserFriendships",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    FriendshipId = table.Column<long>(type: "bigint", nullable: false),
                    IsSender = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFriendships", x => new { x.FriendshipId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserFriendships_Friendships_FriendshipId",
                        column: x => x.FriendshipId,
                        principalTable: "Friendships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFriendships_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Friendships",
                columns: new[] { "Id", "CreatedAt", "Status" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 3, 6, 21, 33, 18, 580, DateTimeKind.Utc).AddTicks(4249), 2 },
                    { 2L, new DateTime(2022, 10, 7, 20, 5, 51, 959, DateTimeKind.Utc).AddTicks(1922), 0 },
                    { 3L, new DateTime(2023, 4, 3, 12, 8, 17, 175, DateTimeKind.Utc).AddTicks(5574), 0 },
                    { 4L, new DateTime(2023, 4, 9, 4, 6, 49, 80, DateTimeKind.Utc).AddTicks(4542), 0 },
                    { 5L, new DateTime(2022, 11, 15, 1, 58, 25, 96, DateTimeKind.Utc).AddTicks(7697), 0 },
                    { 6L, new DateTime(2022, 12, 21, 22, 38, 20, 532, DateTimeKind.Utc).AddTicks(3462), 0 },
                    { 7L, new DateTime(2022, 8, 27, 15, 57, 21, 652, DateTimeKind.Utc).AddTicks(8939), 1 },
                    { 8L, new DateTime(2022, 12, 7, 0, 34, 27, 472, DateTimeKind.Utc).AddTicks(297), 1 },
                    { 9L, new DateTime(2022, 11, 16, 23, 29, 34, 322, DateTimeKind.Utc).AddTicks(5149), 2 },
                    { 10L, new DateTime(2023, 1, 29, 13, 56, 13, 709, DateTimeKind.Utc).AddTicks(3310), 2 },
                    { 11L, new DateTime(2023, 3, 27, 14, 2, 17, 323, DateTimeKind.Utc).AddTicks(2511), 0 },
                    { 12L, new DateTime(2023, 2, 24, 18, 42, 41, 601, DateTimeKind.Utc).AddTicks(8683), 1 },
                    { 13L, new DateTime(2022, 9, 22, 6, 59, 19, 736, DateTimeKind.Utc).AddTicks(5675), 0 },
                    { 14L, new DateTime(2023, 5, 19, 7, 16, 59, 668, DateTimeKind.Utc).AddTicks(4974), 2 },
                    { 15L, new DateTime(2023, 3, 2, 17, 47, 34, 879, DateTimeKind.Utc).AddTicks(3480), 1 },
                    { 16L, new DateTime(2023, 1, 3, 1, 33, 46, 258, DateTimeKind.Utc).AddTicks(7231), 1 },
                    { 17L, new DateTime(2023, 3, 3, 5, 5, 48, 364, DateTimeKind.Utc).AddTicks(548), 2 },
                    { 18L, new DateTime(2023, 2, 12, 18, 51, 10, 593, DateTimeKind.Utc).AddTicks(6763), 0 },
                    { 19L, new DateTime(2023, 3, 20, 20, 54, 52, 409, DateTimeKind.Utc).AddTicks(9513), 2 },
                    { 20L, new DateTime(2022, 12, 5, 15, 12, 1, 783, DateTimeKind.Utc).AddTicks(347), 1 },
                    { 21L, new DateTime(2022, 8, 19, 4, 21, 19, 502, DateTimeKind.Utc).AddTicks(4081), 1 },
                    { 22L, new DateTime(2022, 8, 23, 18, 3, 33, 380, DateTimeKind.Utc).AddTicks(839), 1 },
                    { 23L, new DateTime(2023, 1, 24, 12, 34, 33, 785, DateTimeKind.Utc).AddTicks(7553), 0 },
                    { 24L, new DateTime(2022, 8, 9, 19, 49, 24, 251, DateTimeKind.Utc).AddTicks(3727), 2 },
                    { 25L, new DateTime(2022, 11, 17, 4, 52, 30, 276, DateTimeKind.Utc).AddTicks(75), 1 },
                    { 26L, new DateTime(2022, 12, 24, 10, 37, 41, 9, DateTimeKind.Utc).AddTicks(9896), 2 },
                    { 27L, new DateTime(2023, 5, 13, 1, 29, 17, 953, DateTimeKind.Utc).AddTicks(3587), 0 },
                    { 28L, new DateTime(2022, 8, 17, 12, 52, 25, 687, DateTimeKind.Utc).AddTicks(8878), 2 },
                    { 29L, new DateTime(2022, 12, 16, 22, 54, 58, 641, DateTimeKind.Utc).AddTicks(5577), 0 },
                    { 30L, new DateTime(2023, 5, 23, 17, 20, 21, 649, DateTimeKind.Utc).AddTicks(992), 0 }
                });

            migrationBuilder.InsertData(
                table: "UserFriendships",
                columns: new[] { "FriendshipId", "UserId", "IsSender" },
                values: new object[,]
                {
                    { 1L, 25L, true },
                    { 1L, 31L, false },
                    { 2L, 11L, true },
                    { 2L, 13L, false },
                    { 3L, 26L, false },
                    { 3L, 36L, true },
                    { 4L, 14L, false },
                    { 4L, 36L, true },
                    { 5L, 34L, false },
                    { 5L, 38L, true },
                    { 6L, 11L, true },
                    { 6L, 22L, false },
                    { 7L, 7L, true },
                    { 7L, 31L, false },
                    { 8L, 4L, true },
                    { 8L, 35L, false },
                    { 9L, 15L, false },
                    { 9L, 28L, true },
                    { 10L, 12L, true },
                    { 10L, 38L, false },
                    { 11L, 23L, true },
                    { 11L, 33L, false },
                    { 12L, 14L, true },
                    { 12L, 15L, false },
                    { 13L, 13L, false },
                    { 13L, 17L, true },
                    { 14L, 14L, false },
                    { 14L, 28L, true },
                    { 15L, 14L, true },
                    { 15L, 18L, false },
                    { 16L, 2L, true },
                    { 16L, 18L, false },
                    { 17L, 3L, false },
                    { 17L, 38L, true },
                    { 18L, 16L, false },
                    { 18L, 34L, true },
                    { 19L, 4L, true },
                    { 19L, 15L, false },
                    { 20L, 9L, false },
                    { 20L, 13L, true },
                    { 21L, 8L, true },
                    { 21L, 9L, false }
                });

            migrationBuilder.InsertData(
                table: "UserFriendships",
                columns: new[] { "FriendshipId", "UserId", "IsSender" },
                values: new object[,]
                {
                    { 22L, 3L, false },
                    { 22L, 29L, true },
                    { 23L, 29L, true },
                    { 23L, 35L, false },
                    { 24L, 17L, true },
                    { 24L, 25L, false },
                    { 25L, 1L, false },
                    { 25L, 21L, true },
                    { 26L, 14L, true },
                    { 26L, 34L, false },
                    { 27L, 24L, true },
                    { 27L, 36L, false },
                    { 28L, 17L, true },
                    { 28L, 39L, false },
                    { 29L, 29L, true },
                    { 29L, 30L, false },
                    { 30L, 12L, true },
                    { 30L, 29L, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserFriendships_UserId",
                table: "UserFriendships",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserFriendships");

            migrationBuilder.DropTable(
                name: "Friendships");
        }
    }
}
