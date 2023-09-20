using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeetWars.Core.DAL.Migrations
{
    public partial class UnifiedTagsAndLanguagesInChallenges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 1L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 1L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 2L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 2L, 4L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 2L, 9L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 3L, 7L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 4L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 5L, 3L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 6L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 6L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 7L, 3L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 7L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 7L, 7L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 7L, 8L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 8L, 4L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 9L, 3L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 9L, 4L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 9L, 9L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 10L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 12L, 4L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 13L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 13L, 5L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 13L, 9L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 14L, 1L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 14L, 4L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 14L, 9L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 15L, 3L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 15L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 15L, 7L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 15L, 8L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 16L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 16L, 7L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 17L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 17L, 4L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 17L, 5L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 17L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 17L, 7L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 18L, 8L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 19L, 5L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 20L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 20L, 7L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 21L, 3L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 21L, 7L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 21L, 8L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 23L, 5L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 24L, 1L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 24L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 24L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 24L, 8L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 24L, 9L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 25L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 27L, 3L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 27L, 5L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 27L, 8L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 28L, 3L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 29L, 1L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 29L, 4L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 29L, 7L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 30L, 3L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 30L, 4L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 31L, 1L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 31L, 4L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 31L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 31L, 9L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 32L, 5L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 32L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 33L, 1L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 33L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 34L, 1L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 34L, 9L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 35L, 1L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 36L, 1L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 36L, 9L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 37L, 3L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 37L, 5L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 37L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 38L, 3L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 38L, 5L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 39L, 1L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 39L, 4L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 39L, 8L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 40L, 3L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 40L, 4L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 41L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 41L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 41L, 7L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 41L, 8L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 41L, 9L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 42L, 5L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 42L, 7L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 43L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 43L, 7L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 44L, 1L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 44L, 5L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 44L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 44L, 7L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 44L, 8L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 44L, 9L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 45L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 46L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 46L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 47L, 5L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 47L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 47L, 9L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 48L, 1L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 48L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 48L, 9L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 49L, 9L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 50L, 5L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 50L, 8L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 52L, 1L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 53L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 53L, 4L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 53L, 9L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 54L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 54L, 7L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 54L, 8L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 54L, 9L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 55L, 4L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 55L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 56L, 8L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 57L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 57L, 8L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 58L, 5L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 58L, 7L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 59L, 1L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 59L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 59L, 3L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 59L, 5L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 60L, 3L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 60L, 5L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 63L, 5L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 65L, 1L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 65L, 5L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 65L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 65L, 9L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 66L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 67L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 68L, 5L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 68L, 7L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 69L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 70L, 1L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 70L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 70L, 7L });

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 165L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 166L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 171L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 191L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 200L);

            migrationBuilder.InsertData(
                table: "ChallengeTags",
                columns: new[] { "ChallengeId", "TagId" },
                values: new object[,]
                {
                    { 1L, 5L },
                    { 1L, 9L },
                    { 2L, 5L },
                    { 3L, 5L },
                    { 4L, 9L },
                    { 5L, 4L },
                    { 6L, 3L },
                    { 6L, 5L },
                    { 7L, 4L },
                    { 8L, 5L },
                    { 9L, 6L },
                    { 10L, 5L },
                    { 10L, 9L },
                    { 11L, 5L },
                    { 12L, 6L },
                    { 13L, 6L },
                    { 14L, 2L },
                    { 15L, 4L },
                    { 16L, 1L },
                    { 16L, 6L },
                    { 17L, 9L },
                    { 18L, 5L },
                    { 18L, 7L },
                    { 19L, 2L },
                    { 19L, 3L },
                    { 20L, 6L },
                    { 21L, 6L },
                    { 22L, 4L },
                    { 22L, 9L },
                    { 24L, 3L },
                    { 25L, 2L },
                    { 26L, 3L },
                    { 26L, 4L },
                    { 28L, 1L },
                    { 28L, 5L },
                    { 29L, 6L },
                    { 30L, 1L },
                    { 30L, 2L },
                    { 31L, 3L },
                    { 32L, 8L },
                    { 33L, 5L },
                    { 33L, 8L }
                });

            migrationBuilder.InsertData(
                table: "ChallengeTags",
                columns: new[] { "ChallengeId", "TagId" },
                values: new object[,]
                {
                    { 34L, 3L },
                    { 34L, 6L },
                    { 35L, 2L },
                    { 35L, 3L },
                    { 36L, 2L },
                    { 37L, 1L },
                    { 38L, 7L },
                    { 39L, 3L },
                    { 39L, 7L },
                    { 40L, 2L },
                    { 40L, 8L },
                    { 41L, 3L },
                    { 42L, 1L },
                    { 42L, 4L },
                    { 43L, 1L },
                    { 43L, 6L },
                    { 44L, 4L },
                    { 45L, 8L },
                    { 46L, 1L },
                    { 46L, 7L },
                    { 47L, 2L },
                    { 47L, 3L },
                    { 48L, 3L },
                    { 48L, 4L },
                    { 49L, 3L },
                    { 49L, 5L },
                    { 50L, 2L },
                    { 50L, 6L },
                    { 51L, 7L },
                    { 54L, 2L },
                    { 54L, 4L },
                    { 55L, 1L },
                    { 56L, 6L },
                    { 56L, 9L },
                    { 57L, 2L },
                    { 58L, 2L },
                    { 59L, 4L },
                    { 60L, 4L },
                    { 60L, 9L },
                    { 61L, 9L },
                    { 62L, 1L },
                    { 62L, 8L }
                });

            migrationBuilder.InsertData(
                table: "ChallengeTags",
                columns: new[] { "ChallengeId", "TagId" },
                values: new object[,]
                {
                    { 63L, 8L },
                    { 64L, 3L },
                    { 64L, 6L },
                    { 65L, 2L },
                    { 66L, 4L },
                    { 66L, 7L },
                    { 67L, 6L },
                    { 67L, 7L },
                    { 68L, 3L },
                    { 69L, 4L },
                    { 69L, 8L },
                    { 70L, 6L }
                });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ChallengeId", "CreatedAt", "CreatedBy", "Status" },
                values: new object[] { 2L, new DateTime(2019, 4, 10, 16, 57, 40, 688, DateTimeKind.Utc).AddTicks(5147), 21L, 0 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 3L, "maxime", new DateTime(2023, 9, 7, 12, 35, 45, 717, DateTimeKind.Utc).AddTicks(7994), 30L, "Cum voluptatibus quibusdam corporis saepe dolores.\nError magni eum dolore minima amet.\nTemporibus esse magni nihil est officiis ducimus aut dolorem sit.\nUllam nulla iure.\nMinima accusamus magnam quia laudantium id ut corrupti.", "Dolores et fugit vero vitae adipisci odit aspernatur.", 1, "Voluptatum quia quia nesciunt sequi impedit necessitatibus voluptas repellat.\nOmnis est magnam rerum eum repudiandae minima tenetur.\nAtque reprehenderit accusamus dolore est.\nMaiores non et perspiciatis.\nMinima pariatur dignissimos eum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 4L, "Corrupti iusto ipsam sapiente.", new DateTime(2023, 2, 7, 3, 17, 50, 864, DateTimeKind.Utc).AddTicks(8163), 9L, "nam", "Perferendis nesciunt minima cupiditate.", 2L, 2, "maxime" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 5L, "quisquam", new DateTime(2023, 8, 19, 2, 27, 31, 295, DateTimeKind.Utc).AddTicks(2770), 34L, "Eveniet ut delectus voluptates dolorem laudantium laudantium.\nSequi officiis sapiente et ducimus fugiat exercitationem dolorem adipisci veniam.\nQuidem earum tempore molestias commodi eaque.\nPorro impedit libero aut.\nExpedita expedita est fugit mollitia aut ab eum.\nQuaerat consequatur distinctio illo maiores sit molestiae.", "Perferendis et pariatur sapiente repellat.", 1L, 3, "Molestiae hic et officiis accusantium nostrum repellat aut et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 6L, "Enim aliquid neque nemo dolore possimus quisquam optio veniam. Qui nulla vel in. Blanditiis vel sit. Cupiditate quo quo doloribus sunt unde ex doloremque necessitatibus. Veniam dolor officiis eos molestias explicabo enim necessitatibus soluta.", new DateTime(2023, 7, 31, 12, 47, 5, 686, DateTimeKind.Utc).AddTicks(6117), 38L, "Tempore provident inventore voluptas nihil rerum totam expedita hic vel.", "Aut ullam distinctio tempora omnis animi officiis.", 2L, 3, "Ullam unde libero dolorem voluptatem et. Eius nemo modi. Ipsum modi eaque iusto commodi architecto omnis necessitatibus est. Eos repellat delectus culpa maiores officiis deleniti cumque similique. Et sed ab esse quis voluptatem et veniam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "TestCases" },
                values: new object[] { 7L, "Laborum illo ipsum fuga ratione ipsa sequi.\nQui dolor nesciunt sit itaque quidem.\nNisi voluptate qui placeat facere omnis ea quia ea voluptatibus.\nLaborum sit consequatur iure nisi voluptatem temporibus sed.\nEst totam voluptas excepturi et expedita dignissimos et.", new DateTime(2022, 5, 24, 18, 18, 4, 414, DateTimeKind.Utc).AddTicks(9647), 38L, "est", "Unde nihil officia minima quae id.", "atque" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 8L, "Iusto consequatur ut. Et tempora officiis error enim nulla. Suscipit molestiae perferendis. Debitis consequuntur perspiciatis dolorum architecto placeat error eum aut repellendus.", new DateTime(2018, 6, 17, 21, 0, 42, 879, DateTimeKind.Utc).AddTicks(6139), 15L, "Atque inventore beatae totam.\nNecessitatibus velit quia et pariatur voluptas veniam rerum sed qui.\nAccusamus fuga id dolorum praesentium.", "Assumenda maiores placeat magnam debitis assumenda facilis velit et.", 1L, 0, "Cumque velit aspernatur voluptatum fugiat aut consequatur est voluptatum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 9L, "In dolores perferendis libero aspernatur praesentium sint quis eos et.", new DateTime(2021, 6, 5, 15, 50, 28, 189, DateTimeKind.Utc).AddTicks(897), 38L, "voluptatem", "Voluptatem ea natus quis dignissimos.", 2L, 1, "Officia harum in ab at at dolorem qui nobis. Rerum quo aliquam. Et illo voluptas culpa ea ducimus ea. Et eum est est neque qui." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 10L, "a", new DateTime(2022, 6, 21, 8, 35, 36, 477, DateTimeKind.Utc).AddTicks(3183), 19L, "Aliquid dolorum iste quia voluptatibus dolores nostrum ab quia dolor. Doloremque odio suscipit animi recusandae quo voluptatem odio. Esse quam ut optio quo non. Recusandae soluta ratione.", "Et dolor molestias et officia quos laboriosam porro aut.", 2L, 3, "Voluptatem autem voluptas ducimus maiores. Odit error adipisci ea vitae eligendi. Laboriosam commodi atque. Dolor eos est repellat enim aliquam ratione. A voluptatem assumenda delectus quaerat est recusandae aliquam provident. Rerum eius accusamus rerum recusandae cum et officia odit aliquid." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "TestCases" },
                values: new object[] { 11L, "Labore sint dolores. Totam expedita reprehenderit sed blanditiis. Qui non aliquid. Suscipit ab eaque ea consequatur aut eum impedit natus. Sint magnam incidunt velit adipisci voluptatem. Sed animi tempora blanditiis.", new DateTime(2022, 7, 3, 8, 23, 21, 667, DateTimeKind.Utc).AddTicks(1745), 9L, "In esse et veniam.", "Ut cumque sint tenetur sed et.", "Laudantium accusantium possimus mollitia totam blanditiis odio corrupti asperiores. Dolor ut vitae aut molestias pariatur expedita provident ex. Nihil numquam nihil. Consequatur eos dolor quae." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 12L, "Exercitationem ut ut.", new DateTime(2023, 2, 5, 14, 20, 15, 394, DateTimeKind.Utc).AddTicks(6321), 37L, "Ex sit magnam animi natus deserunt voluptas.\nReprehenderit nesciunt et dignissimos omnis veniam et doloribus.\nEt accusamus nostrum aliquam.\nRepellat tenetur eaque.\nImpedit ut et sit.\nIste voluptatum at quaerat hic facilis quod.", "Aut aut molestiae quaerat.", 2L, 0, "facere" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 13L, "Harum nemo aliquam suscipit exercitationem error iure rerum. Et autem culpa nemo delectus voluptates. Pariatur ut nihil.", new DateTime(2023, 8, 18, 7, 48, 51, 104, DateTimeKind.Utc).AddTicks(6178), 1L, "Voluptatum amet a dolorem modi consequuntur.\nQuia commodi perferendis ut repellat dolore.\nConsequatur eveniet quidem enim quae voluptatum fugit error.\nAut veritatis quo nemo fugiat deserunt veritatis ad.\nEt nihil autem.", "Ut qui rerum quaerat perferendis iusto ea.", 1L, 2, "Dolorem occaecati minus natus explicabo repudiandae. Totam architecto sequi blanditiis vero nulla perspiciatis consequatur. Ut dolor ut enim atque amet quia. Dicta reiciendis aliquid doloribus qui perferendis odio ratione. Magnam atque minus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 14L, "Ex nulla quam iste aliquam ex repudiandae atque.", new DateTime(2023, 4, 21, 16, 40, 55, 5, DateTimeKind.Utc).AddTicks(5443), 31L, "Non corporis quod eius vel ut repudiandae.\nQuis et voluptas corrupti.\nQuaerat in minus provident quae sint et dolor labore.\nAt praesentium ea ut.\nRerum ducimus repudiandae voluptatum quod sit voluptas nobis ut magni.\nExpedita non velit voluptatibus tempora explicabo quasi esse.", "Harum at maiores aut aliquid perferendis adipisci.", 1, "odit" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 15L, "Rerum omnis voluptatem.", new DateTime(2023, 6, 18, 18, 20, 50, 296, DateTimeKind.Utc).AddTicks(1636), 15L, "At maxime dolorem recusandae necessitatibus dolores ea velit.\nLaboriosam voluptas quaerat doloribus omnis iure rerum magnam perspiciatis.\nEt vero deleniti autem culpa eaque animi ut consequatur laborum.\nQuos consequatur inventore cupiditate labore voluptas.\nNeque ducimus aliquam eos facilis dolores est.\nDoloremque aspernatur consequuntur autem beatae earum quos quo.", "Asperiores hic odio.", 1L, 3, "aperiam" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 16L, "A velit laudantium cupiditate veritatis ex sunt aspernatur quidem. Non nisi sit et consequatur et eius asperiores sed. Alias explicabo ipsa cum et autem nisi. Sequi aut aut nulla quod.", new DateTime(2022, 5, 9, 9, 30, 45, 215, DateTimeKind.Utc).AddTicks(1412), 33L, "Perferendis temporibus quae fugiat est consequatur quis. Ipsum veritatis in officiis et. Cum nulla rerum fuga impedit doloremque qui unde deserunt. Et aliquid ratione quisquam molestiae. Commodi qui velit incidunt nulla.", "Eveniet nostrum voluptatem eaque.", 1L, 2, "Harum id enim quisquam at reprehenderit beatae magnam harum. Assumenda laboriosam saepe. Non ipsa ut accusamus voluptas eos nesciunt repellendus expedita. Perferendis dolorem earum provident distinctio consequatur animi quam. Ipsum et et soluta." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 17L, "Dolores laboriosam dolores sit libero inventore odit facilis.\nTotam velit omnis ea.\nVero est odio vero optio.\nTempore est consequatur.\nOdit quia perspiciatis cumque in.", new DateTime(2023, 4, 30, 5, 13, 1, 250, DateTimeKind.Utc).AddTicks(6319), 9L, "Sit amet repudiandae unde excepturi ea et veniam veniam.\nNemo cumque ea ab.", "Qui in ea.", 1L, 2, "Rem cumque at consequatur tempora et facilis corporis ut iste. Autem ipsum sapiente. Qui ratione et dolores quas ut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "TestCases" },
                values: new object[] { 18L, "Consequatur facilis quae.\nEaque doloribus aspernatur autem earum quos.\nExplicabo delectus expedita quisquam quam aspernatur vel animi nostrum.\nNecessitatibus itaque adipisci optio ab est pariatur.\nPariatur nostrum unde animi sed et illo ea sunt.", new DateTime(2023, 9, 19, 7, 36, 45, 772, DateTimeKind.Utc).AddTicks(1982), 10L, "Corporis blanditiis qui eos reprehenderit culpa sint impedit at dolor.", "Sed et harum dolores qui optio quisquam omnis est.", 2L, "Fugit animi quo et dolorem sed ipsum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 19L, "Inventore cupiditate doloribus ab quia et ab enim. Nesciunt debitis quis officiis quos. Saepe voluptate quia ut culpa ut.", new DateTime(2022, 11, 17, 17, 37, 31, 200, DateTimeKind.Utc).AddTicks(3396), 33L, "Corporis corporis rerum dolor sed.\nSapiente error dolore praesentium quos quia asperiores.\nImpedit tenetur voluptatem ipsum nostrum in dolores explicabo quae.\nFacere possimus sit maxime.\nEst velit vel commodi et consequatur error molestias nihil quas.", "Velit labore dolores.", 2L, 3, "Sit accusamus animi maxime molestiae qui.\nVoluptas quia enim.\nRecusandae ea dicta numquam.\nAccusamus qui atque dolorum odit non quis molestias.\nCorporis fugiat quis nemo culpa voluptatem omnis minus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 20L, "Natus ullam voluptatem vel non quaerat omnis. Ea provident eius. Iste quaerat cum a dicta et ratione. Ipsam libero id iusto nobis fugiat.", new DateTime(2022, 12, 4, 9, 58, 23, 218, DateTimeKind.Utc).AddTicks(8094), 28L, "Non earum qui et non saepe natus. Consequuntur vel ducimus ducimus dolor eveniet tenetur ut hic qui. Dolorem repudiandae doloribus laboriosam quo eligendi quidem.", "Vel molestias exercitationem odio.", 2L, 2, "Laudantium culpa accusamus fuga. Quidem excepturi ipsa explicabo. Nemo placeat soluta qui. Maxime ut cumque." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 21L, "Hic maxime tenetur nesciunt delectus omnis vero corporis.\nEt et in quis nemo ea ut quidem eius animi.", new DateTime(2023, 2, 26, 15, 10, 49, 360, DateTimeKind.Utc).AddTicks(3600), 30L, "natus", "Eum dolor optio magnam.", 2L, 1, "Consequatur voluptas velit cum dolore dolorum ut. Facilis voluptatem sed. Ducimus officiis non possimus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 22L, "Autem vel aut sapiente nostrum provident.", new DateTime(2022, 11, 4, 12, 10, 33, 447, DateTimeKind.Utc).AddTicks(1989), 5L, "Adipisci eaque vero atque possimus debitis adipisci eaque. Voluptas fugiat vitae consectetur voluptates excepturi nihil voluptatem illo voluptatem. Veniam hic est architecto dolores aut quibusdam. Doloremque maxime aliquid molestiae nobis ut explicabo consequuntur. Maiores blanditiis sit quo asperiores ut harum ut ullam et.", "Nostrum neque dolorem totam non veritatis aperiam aperiam.", 3, "eaque" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 23L, "neque", new DateTime(2023, 9, 3, 17, 48, 7, 456, DateTimeKind.Utc).AddTicks(3884), 33L, "Velit dolor maxime tenetur molestiae distinctio commodi.\nOptio iusto pariatur eos.", "Autem maiores totam dolore voluptatem repellendus doloribus et beatae laudantium.", 1L, 3, "In quis vel iure blanditiis dolorem mollitia quo est quis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 24L, "Est sint iure tenetur numquam dolor.\nQuia dolore temporibus rem suscipit excepturi dicta quas.\nOmnis cumque pariatur sapiente.", new DateTime(2023, 3, 28, 10, 18, 13, 450, DateTimeKind.Utc).AddTicks(6272), 14L, "quod", "Maiores sit qui et eveniet.", 2L, 0, "Autem minus in ullam.\nRepellat et ullam unde molestias natus.\nQuod reiciendis dolor atque quaerat." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 25L, "Illum aut modi quia. Quos molestiae dolorem hic consequatur. Voluptatem mollitia eius deserunt possimus repellendus laboriosam a laudantium. Sed qui quod voluptatibus illo aut omnis incidunt eligendi eveniet. Eum sapiente libero vel voluptatibus et deserunt porro ea earum.", new DateTime(2023, 5, 4, 17, 3, 6, 267, DateTimeKind.Utc).AddTicks(4666), 12L, "Numquam omnis dolorem placeat et veritatis voluptatem. Corporis qui aut quibusdam quia sunt porro. Eos adipisci aliquam impedit iure saepe dolores. Corporis voluptas labore ut expedita dolor. Aut dolorum molestiae reiciendis.", "Ut soluta sit at velit repellendus ad accusamus autem.", 3, "Accusamus aliquam reiciendis consectetur sint dicta eaque autem magni aliquam. Atque atque qui quis reprehenderit. Mollitia quaerat repudiandae est." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 26L, "Ut deserunt debitis et illo culpa.\nMolestiae neque voluptatem minima eligendi ducimus repudiandae.", new DateTime(2023, 7, 15, 17, 9, 10, 96, DateTimeKind.Utc).AddTicks(5040), 15L, "Deleniti itaque voluptas ducimus iusto id dignissimos dolore harum vero. Sed sapiente repellat fugit. Atque molestiae itaque excepturi praesentium qui. Hic sint aperiam. Pariatur nihil et atque est error ipsa facilis. Voluptatem dolore eum illo voluptatem reiciendis quia.", "Incidunt distinctio dolor.", 0, "Consequuntur cum aut dolor eligendi mollitia aut est sunt rerum. Voluptatum qui porro fugiat. Vel inventore facilis totam consequatur consequuntur. Officia optio ut expedita laudantium tempora voluptas. Labore iste eligendi illo maiores sit ipsam sunt." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 27L, "veritatis", new DateTime(2022, 11, 2, 5, 32, 43, 349, DateTimeKind.Utc).AddTicks(2782), 27L, "Provident rerum et aliquid corrupti. Ut mollitia aut corrupti. Cupiditate modi necessitatibus error corporis laborum.", "Accusamus mollitia fugiat.", 2L, 3, "Placeat itaque autem non in itaque deserunt." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 28L, "molestiae", new DateTime(2022, 7, 1, 20, 39, 28, 425, DateTimeKind.Utc).AddTicks(5585), 1L, "Quo vel cumque vel iusto mollitia unde.", "Dolorem sed eveniet est rerum porro et.", 3, "quasi" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 29L, "Blanditiis et ad sint dolorem voluptas. Voluptas qui vel. At corrupti voluptates animi reprehenderit. Autem voluptate voluptatem.", new DateTime(2021, 11, 15, 10, 52, 27, 169, DateTimeKind.Utc).AddTicks(1898), 40L, "libero", "Atque sapiente aspernatur voluptas laborum asperiores totam aperiam.", 0, "In possimus sit temporibus vel nesciunt id autem culpa et.\nEt in nesciunt beatae vel velit.\nOptio omnis et sed aut est esse perferendis animi.\nLabore sed quia accusamus temporibus eum.\nOmnis fugiat reiciendis dolore dolorem pariatur iusto repellendus laborum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 30L, "dolores", new DateTime(2018, 10, 31, 2, 44, 6, 62, DateTimeKind.Utc).AddTicks(9101), 21L, "Quis voluptatem perspiciatis iusto mollitia provident non rem.\nEt unde placeat doloribus consequatur.\nEum perspiciatis temporibus illo eveniet omnis.\nSed aut est dignissimos id facilis ullam.", "Quam illum necessitatibus et veniam facilis est quis et natus.", 2, "aperiam" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 31L, "Mollitia hic ratione quia dolorum consequatur consectetur quibusdam nemo et.", new DateTime(2023, 7, 15, 17, 53, 10, 37, DateTimeKind.Utc).AddTicks(9340), 12L, "Velit iusto eum voluptatem molestiae quis ipsum officia.\nQuae sed porro nihil minus sapiente voluptatibus delectus est recusandae.\nRerum aut recusandae maiores.\nEsse nulla doloribus dolore suscipit alias expedita quis.\nRem et qui tempore ex.\nMolestiae commodi modi magni dicta explicabo assumenda veritatis.", "Rerum tempore et natus dolorem.", 2, "et" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 32L, "Laboriosam officia ipsa debitis.", new DateTime(2023, 9, 8, 5, 24, 32, 212, DateTimeKind.Utc).AddTicks(7434), 32L, "Id ad placeat aut ut.", "Qui illo tempora et nulla sint molestias.", 2L, 2, "Voluptatem provident magnam exercitationem." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 33L, "nulla", new DateTime(2023, 4, 26, 21, 51, 1, 463, DateTimeKind.Utc).AddTicks(9892), 27L, "quidem", "Illo ad aperiam laudantium velit et non rerum.", 0, "dolore" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 34L, "Et provident laborum provident assumenda nulla ut ut sit. Consequatur eos sunt voluptatem quos aliquam fugit. Eligendi aut ab maiores quo totam quasi delectus. Vel nihil voluptas incidunt earum dolor maiores qui. Velit aut voluptatem ea eligendi et repellendus sed. Nulla id laboriosam deserunt cupiditate commodi voluptatibus magnam explicabo consequatur.", new DateTime(2022, 11, 5, 12, 12, 40, 405, DateTimeKind.Utc).AddTicks(6941), 8L, "ut", "Consequatur voluptatem maiores enim commodi dicta omnis deleniti optio.", 2, "Praesentium aut ipsum officia.\nMagnam autem nihil sapiente officia odio dolor.\nPerferendis qui sit amet nihil sed harum similique tempora.\nSit repellendus eveniet ea.\nEligendi vitae quia repudiandae." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 35L, "Consequatur soluta aliquid qui sint et iure totam veritatis in. In voluptas aut est. Consequuntur qui aut velit cupiditate voluptas in quis aut.", new DateTime(2023, 8, 25, 4, 24, 53, 782, DateTimeKind.Utc).AddTicks(4732), 7L, "Aut explicabo ut beatae et aut numquam illo.", "Provident eum rem.", 3, "dicta" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 36L, "Cumque maxime repellat id autem quae aut reiciendis.", new DateTime(2021, 7, 6, 12, 46, 49, 866, DateTimeKind.Utc).AddTicks(7649), 40L, "Totam asperiores saepe labore temporibus quis fugit ullam incidunt numquam.", "Hic est ea itaque ut ullam.", 3, "Ipsa quibusdam quaerat atque necessitatibus et voluptate eum iusto.\nLaudantium tenetur impedit fuga beatae illum necessitatibus ut earum.\nTemporibus repudiandae voluptatibus aut aliquid ut laboriosam inventore non.\nBeatae a consequatur.\nMaxime est eligendi quia sint." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "TestCases" },
                values: new object[] { 37L, "aliquid", new DateTime(2023, 3, 5, 5, 13, 0, 729, DateTimeKind.Utc).AddTicks(1372), 9L, "Minima deserunt similique tempore quia qui voluptas non ut accusamus.\nProvident iste quaerat.", "Vel nesciunt magni ut.", 1L, "Molestias hic ex debitis molestiae quia nobis qui. At voluptatem sint sunt et natus inventore. Possimus cumque eveniet quasi. Accusantium voluptatem et fugiat." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 38L, "Enim et eaque quaerat deserunt deserunt est voluptatum.", new DateTime(2023, 8, 15, 7, 33, 37, 179, DateTimeKind.Utc).AddTicks(9544), 21L, "Dolores porro consequuntur doloribus rerum mollitia consequatur sint itaque ut.\nVoluptate fugit labore quas dolores nisi alias.\nMagnam provident quam et necessitatibus.", "Sunt deleniti recusandae deserunt velit.", 2L, 1, "quaerat" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 39L, "At aliquid rerum nihil. Illo magni autem sit odio at deleniti. Odit voluptatibus debitis quaerat autem. Eum quo quibusdam ut aut est vitae ducimus iusto ut. Harum dignissimos nemo. Et qui in.", new DateTime(2022, 10, 21, 12, 20, 27, 53, DateTimeKind.Utc).AddTicks(6590), 39L, "sequi", "Aperiam et ut.", 2L, 2, "Adipisci in ipsa ut qui quia et neque vel." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 40L, "Aut voluptate ipsum minima blanditiis voluptas deleniti a est quibusdam.\nTempore saepe repellendus rerum consequatur sint harum nisi maxime et.\nRem rerum et.\nAccusantium laudantium sed dolore officia impedit similique.", new DateTime(2023, 3, 20, 19, 8, 0, 584, DateTimeKind.Utc).AddTicks(9612), 14L, "Iusto eligendi esse sint facilis laborum ea quo quis.", "Illo fugit recusandae explicabo cupiditate est.", 2L, 3, "Et rerum ea aliquam cum est maiores quia. Omnis nesciunt sit quae veniam id. Aliquid qui omnis voluptas itaque quis est vero illum sit. Commodi quia ad aut aut eos ipsum sit aperiam. Dicta quasi dolor inventore ullam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 41L, "Debitis aut similique cumque.\nDistinctio assumenda impedit quidem quo.", new DateTime(2022, 1, 16, 10, 36, 7, 22, DateTimeKind.Utc).AddTicks(8639), 13L, "et", "Odio distinctio saepe dolorum delectus neque.", 1L, 0, "Animi quo quisquam. Repudiandae ut animi quaerat reprehenderit voluptas et. Est voluptate rerum iusto sit veniam dolor magnam et. Illum architecto repudiandae explicabo quia id ipsum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "TestCases" },
                values: new object[] { 42L, "Itaque atque quaerat voluptas molestiae laborum magnam.", new DateTime(2023, 4, 15, 22, 47, 36, 558, DateTimeKind.Utc).AddTicks(2067), 7L, "Assumenda nam natus.\nIste enim maiores.\nEt quisquam eveniet quo rerum consequatur.\nEst repellat aperiam quaerat eligendi molestiae ipsam officia pariatur incidunt.\nQui incidunt minima ut ab quod nisi occaecati at molestias.\nAlias laudantium suscipit.", "Ut quis dolore.", 2L, "Iste fuga ipsum fuga inventore. Facilis soluta qui. Repellat dicta magnam. Consequatur optio suscipit aliquid eum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 43L, "Ad ut est blanditiis architecto impedit eum quidem repudiandae.\nSed sit libero sequi quos molestiae a in fuga.\nSunt et alias sunt ratione enim distinctio vel non quo.", new DateTime(2023, 9, 4, 6, 17, 46, 910, DateTimeKind.Utc).AddTicks(7444), 6L, "eum", "Esse reprehenderit natus temporibus.", 3, "Omnis quaerat totam beatae voluptates in et ex." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "TestCases" },
                values: new object[] { 44L, "aliquid", new DateTime(2022, 6, 8, 21, 31, 32, 727, DateTimeKind.Utc).AddTicks(901), 7L, "Nobis velit sint natus delectus enim.\nQuod quas et a asperiores cumque fuga necessitatibus error.\nAb et velit aperiam.\nConsequatur qui dicta.", "Eaque molestiae sapiente animi reprehenderit sit aliquid.", "Enim voluptas ab perferendis odit beatae ipsam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 45L, "Nihil maxime non.\nNulla sed iste ipsam veritatis nihil.\nPerspiciatis voluptas ut tenetur.\nAutem error animi quia rem.", new DateTime(2023, 3, 1, 5, 9, 10, 241, DateTimeKind.Utc).AddTicks(5273), 23L, "fuga", "Et error nobis velit aliquid.", 2L, 2, "Nam sit nesciunt ducimus qui enim et enim autem sed." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 46L, "Velit dolorem temporibus voluptates quia sunt consequuntur.", new DateTime(2022, 7, 3, 13, 30, 40, 286, DateTimeKind.Utc).AddTicks(6339), 30L, "Aperiam expedita quis aut rerum libero quis.\nAperiam qui asperiores temporibus id impedit dolores animi.\nFacilis commodi aliquid sunt aut eum enim vitae cum doloribus.", "Voluptas est id debitis aperiam dolor quas.", 2L, 3, "Est facere nesciunt consequatur natus sequi. Molestiae est rerum dicta animi dolorem exercitationem asperiores veniam. Est sunt harum voluptas expedita explicabo temporibus eveniet. Atque laudantium autem et dolores sunt consequatur sunt. Vero soluta voluptas ipsa est veniam facere. Quo occaecati vel repellat quos sint ipsa officiis odio." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 47L, "illo", new DateTime(2021, 2, 2, 18, 45, 4, 995, DateTimeKind.Utc).AddTicks(5033), 11L, "Deserunt non ut. Itaque nostrum minima corrupti. Ex aut voluptatibus consequatur maxime. Esse quia voluptas.", "Culpa totam omnis velit enim expedita.", 1L, 3, "Sunt cupiditate voluptatem voluptatem dolor dolor odio earum autem. Aut non tempora ad aspernatur. Quia soluta quod." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 48L, "provident", new DateTime(2023, 5, 10, 15, 34, 30, 247, DateTimeKind.Utc).AddTicks(1919), 32L, "laudantium", "Itaque quia et non et tenetur autem aliquam.", 1L, 3, "Consequatur asperiores fuga nulla ratione distinctio corporis perferendis cupiditate iste." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 49L, "Id qui voluptatem.\nMagnam quam qui et neque qui sapiente veritatis quia.\nBeatae praesentium vero nam neque et.\nNam quae cum esse ullam.\nRepellendus eum et perferendis assumenda vitae molestiae qui.\nQui ut quo quis rerum inventore voluptate nisi at.", new DateTime(2023, 8, 29, 9, 37, 21, 920, DateTimeKind.Utc).AddTicks(6484), 39L, "Qui quasi ea.", "Sunt atque vel sint excepturi voluptas quo perferendis vitae est.", 1, "Hic omnis iste tempora voluptatibus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 50L, "Autem sit eius aliquam nihil qui sapiente a porro accusantium.", new DateTime(2023, 5, 14, 15, 26, 17, 132, DateTimeKind.Utc).AddTicks(8743), 33L, "Ipsam non distinctio voluptatum deserunt iure voluptatum et voluptates doloremque.\nAut animi illum cumque dolorem iusto asperiores.", "Sunt explicabo magni consectetur reiciendis maxime natus veniam ipsam.", 3, "Doloremque in illo id placeat iure et qui omnis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 51L, "Ipsum consectetur dolor recusandae aliquam earum quos neque corrupti. Sit omnis doloremque recusandae repellat. Quae alias recusandae est tempore impedit voluptas in enim. Veritatis aut accusamus omnis. In in molestiae id voluptas in. Ut officiis quia.", new DateTime(2022, 10, 16, 23, 2, 50, 332, DateTimeKind.Utc).AddTicks(9149), 8L, "quisquam", "Autem et qui.", 1, "Nihil modi repellendus voluptatem aut ut officiis eos.\nNon qui laudantium nihil animi dolorum aut aut eum exercitationem.\nRepudiandae possimus aut id adipisci sequi nihil ut et inventore.\nPerferendis possimus dolores officiis dicta commodi.\nConsequatur eveniet cum enim optio consequatur quis enim.\nEt blanditiis et asperiores dolorem consequatur." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 52L, "Qui aliquam animi inventore id ipsam.\nId dolorum sint velit et expedita facilis quod esse et.", new DateTime(2023, 3, 10, 4, 54, 57, 112, DateTimeKind.Utc).AddTicks(3934), 9L, "Delectus officiis aut optio natus cupiditate. Ipsa deleniti est sit sapiente. Ex id unde mollitia.", "Unde ut atque qui qui consequuntur impedit quis qui provident.", 2L, 0, "Inventore aliquid est dolorem debitis rerum nesciunt. Magni quasi et quas vero ducimus aut. Sed necessitatibus est et quia non molestiae iure architecto." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 53L, "Quaerat ut modi rerum sit magni non.\nUt impedit nobis impedit pariatur.\nAutem temporibus dolorem unde et vel voluptatibus.\nOmnis molestias et fugit rem dolorum sunt.\nVeritatis qui atque.", new DateTime(2022, 4, 7, 0, 57, 0, 247, DateTimeKind.Utc).AddTicks(5248), 9L, "ut", "Exercitationem doloremque amet ipsam velit nulla nihil iure facere sed.", 1L, 1, "Quis sapiente debitis beatae quod. Hic quia quas est natus labore quae mollitia. Sunt nihil eos et nobis corrupti porro. Eius distinctio enim amet quia facilis quis modi." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 54L, "Quos eligendi dolorum qui expedita autem.", new DateTime(2023, 1, 16, 2, 36, 6, 421, DateTimeKind.Utc).AddTicks(2046), 33L, "Mollitia id tenetur est.\nVoluptas hic sit quis rerum.\nRepellat est autem magnam vitae voluptatem et ipsam veritatis.\nOmnis dolorem aut animi omnis hic adipisci.\nMaiores eligendi dolorem quod non et dolor sint commodi expedita.\nMolestiae rerum ut sequi sunt veritatis.", "Quasi minima fuga blanditiis consequatur quidem omnis incidunt sunt.", 1L, 3, "Esse et sint et soluta numquam eum totam.\nTenetur dolor autem ut repudiandae autem suscipit inventore aperiam impedit.\nLibero molestiae quod." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 55L, "Aut sed illum possimus. Iure rerum itaque. Dolore quia rem similique ut. Ut quidem impedit ut tempore ut ut et aperiam vel. Qui similique ducimus et ut et. Consequatur aliquid sed.", new DateTime(2023, 1, 23, 19, 58, 53, 496, DateTimeKind.Utc).AddTicks(3102), 29L, "Animi minus atque exercitationem aperiam iure. Ea reiciendis id sed eius ut blanditiis. Vitae vel exercitationem incidunt officia eum ratione totam id commodi.", "Quia autem qui natus.", 3, "Sequi quia harum aut perferendis id nisi sit ut.\nRem sit at culpa.\nRepudiandae rem eaque.\nAutem fuga similique vel corrupti suscipit ad autem laudantium.\nUnde quo corporis delectus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 56L, "Iste corrupti nisi labore perferendis aut excepturi mollitia.", new DateTime(2023, 3, 1, 15, 7, 38, 926, DateTimeKind.Utc).AddTicks(3451), 8L, "Possimus quos tempore fuga dolores quidem blanditiis ut.\nRecusandae sequi similique quo beatae consequatur occaecati sed.\nQuaerat eos qui cupiditate voluptas hic doloribus in.\nHarum officiis in quia enim architecto ab similique cum.\nAutem consequatur consequatur eos rem consequatur iste.", "Numquam repellat et rerum.", 1L, 2, "nesciunt" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 57L, "Dolor qui reprehenderit dolorem qui voluptas quos temporibus excepturi magni.\nQuod porro aliquam minima libero porro est voluptas ipsam in.\nNon quibusdam sed assumenda consequatur rem occaecati suscipit sint qui.\nDicta modi ipsa beatae rerum eum nisi dolor.\nIure similique aspernatur corporis quisquam ab.", new DateTime(2023, 1, 4, 21, 45, 6, 451, DateTimeKind.Utc).AddTicks(4227), 11L, "Ut quia et. Repellat et aperiam labore. Architecto rerum quam dolores perferendis similique ea. Incidunt quae a ratione nam illum quia eos. Similique qui voluptatem atque consequatur accusamus. Nesciunt sed non tenetur earum corporis sunt.", "Architecto ipsa iusto corporis id non ut neque.", 0, "Sint reprehenderit a voluptatem sint dolorem necessitatibus mollitia harum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 58L, "Debitis officiis id ea dolores nostrum sunt veritatis quidem dicta.", new DateTime(2021, 4, 4, 12, 35, 0, 366, DateTimeKind.Utc).AddTicks(1115), 15L, "repudiandae", "Sed sit quas aliquam non eveniet.", 3, "et" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "TestCases" },
                values: new object[] { 59L, "eos", new DateTime(2023, 6, 26, 5, 39, 5, 536, DateTimeKind.Utc).AddTicks(1881), 35L, "Cupiditate praesentium sed veniam optio vel. Hic odit adipisci non natus veritatis labore. Corporis cumque ipsa. Et quas odio magni consequatur optio.", "Molestiae a earum veritatis qui autem cum voluptas et.", "A harum veniam sint at blanditiis est.\nDoloremque vel repellat nesciunt quis quis fuga sed.\nEveniet sed qui voluptatum tenetur recusandae vel.\nVoluptatibus illum delectus voluptas." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 60L, "Ipsum eaque minima voluptatem autem facere.\nReiciendis sint voluptatem quis ut aliquam sapiente dicta sit aut.\nTempora et rerum ipsam nihil autem eveniet.", new DateTime(2019, 3, 5, 2, 36, 23, 266, DateTimeKind.Utc).AddTicks(6271), 18L, "Consequuntur optio modi commodi necessitatibus totam. Facere ipsam ea et nobis voluptatum magni voluptatem molestias quisquam. Consectetur consequatur cum voluptate quae sapiente illo molestias. Animi aliquam inventore aspernatur deleniti repellendus commodi at fuga dolores. Alias expedita excepturi ea quia tempora earum eos aut perferendis.", "Ea doloremque rerum provident harum voluptates aliquam nisi.", 3, "Sunt ab ea provident modi pariatur suscipit.\nAt voluptatibus quia porro nisi necessitatibus.\nQuam fugit quos.\nSimilique unde culpa qui possimus minima dolorem facere." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "TestCases" },
                values: new object[] { 61L, "Quaerat corporis voluptatem eveniet fugit ad rerum.", new DateTime(2023, 8, 6, 10, 50, 1, 854, DateTimeKind.Utc).AddTicks(8756), 39L, "Ipsam ut qui sit consectetur voluptate.\nOdit atque et explicabo vel dolor omnis dolores aut ut.\nDolorum explicabo non eos sint et temporibus sapiente.\nQuod at possimus cumque aliquam consequuntur fugit dolores atque eum.", "Est vel quisquam est voluptatem enim vel error.", 1L, "quod" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 62L, "Nam omnis quasi consequuntur.\nVeniam blanditiis voluptatem ut incidunt incidunt.\nVoluptatem magnam est repudiandae voluptas nobis.\nIllo est ratione.", new DateTime(2023, 3, 26, 23, 22, 35, 292, DateTimeKind.Utc).AddTicks(4342), 1L, "Dolor maiores doloribus unde.\nQuod veniam porro.", "Sit facilis quia suscipit.", 2L, 0, "Quam perferendis voluptas enim quo qui et molestiae. Consectetur voluptatibus et consequuntur nobis eum ipsa. Molestiae aut necessitatibus iste. Earum exercitationem qui consequatur et expedita molestias. Sint dolor occaecati voluptatum voluptatem enim." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 63L, "unde", new DateTime(2022, 1, 27, 13, 35, 50, 604, DateTimeKind.Utc).AddTicks(6384), 3L, "Voluptatibus nam explicabo saepe.", 1, "Officia sint fugit tempore velit aut est nam natus.\nQuia id incidunt ut error reiciendis.\nOmnis ducimus est et quam dolores consequatur exercitationem quibusdam at." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "TestCases" },
                values: new object[] { 64L, "Facere omnis non sint consectetur asperiores.", new DateTime(2021, 6, 24, 21, 35, 28, 873, DateTimeKind.Utc).AddTicks(6215), 16L, "dolorem", "Ut ipsum quasi suscipit tempore officia.", 1L, "optio" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 65L, "Quos ut corrupti aut ad culpa ipsam. Et facilis vel quae sunt at non aut. Voluptate ratione eum. Est voluptas perferendis eos.", new DateTime(2022, 4, 24, 19, 41, 28, 242, DateTimeKind.Utc).AddTicks(8783), 30L, "et", "Voluptatem sed ea commodi dolorum.", 1L, 3, "Enim tempora quod deserunt et aliquam aperiam autem cumque. Illum sed fugiat quam sint laudantium error ex dolorem voluptate. Aliquid nostrum non placeat quam. Nulla numquam rem accusamus commodi. Excepturi iusto soluta ut eius perspiciatis quo qui fugiat. Sunt officia accusantium repellat aut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 66L, "neque", new DateTime(2022, 10, 24, 7, 47, 35, 383, DateTimeKind.Utc).AddTicks(6280), 24L, "Quia maiores fugiat natus nisi.", "Sapiente recusandae provident voluptas vitae ut.", 1, "aut" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 67L, "Porro ut voluptatem dicta laborum eum.", new DateTime(2023, 1, 18, 22, 29, 37, 507, DateTimeKind.Utc).AddTicks(8792), 37L, "Laudantium accusamus harum libero beatae reiciendis.\nNobis tempore qui exercitationem.\nOdit aut nihil aut maiores.", "Sed dolorum quisquam.", 2L, 2, "rem" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 68L, "Delectus ut blanditiis a.\nSapiente modi corrupti aperiam facere et quam ipsa repudiandae.", new DateTime(2023, 9, 10, 1, 44, 42, 867, DateTimeKind.Utc).AddTicks(4485), 7L, "Perferendis praesentium aliquam aut autem nesciunt at.\nHic nostrum est eum enim non fugit qui fuga.", "Dolores voluptatum illum quia accusantium nulla a quis.", 3, "amet" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 69L, "Labore a architecto qui impedit ut. Et ut dicta. Velit nemo consequatur nisi non. Est corrupti modi qui rerum deserunt quas aperiam ipsum ut. Aut beatae culpa eaque harum nisi qui.", new DateTime(2023, 7, 3, 22, 47, 9, 338, DateTimeKind.Utc).AddTicks(2440), 10L, "consectetur", "Nihil dicta et voluptas illo est nostrum.", 2L, 0, "Eum et vitae aut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 70L, "Similique optio ut rerum omnis.", new DateTime(2022, 11, 9, 3, 56, 46, 703, DateTimeKind.Utc).AddTicks(9985), 24L, "Dolor accusantium explicabo delectus expedita.\nUllam necessitatibus ratione minima excepturi dignissimos expedita dignissimos.\nCommodi enim et consequatur quas vero ducimus a.\nLaboriosam in ex.\nQui culpa quae provident deleniti.", "Dolores nulla nulla occaecati molestiae et et.", 3, "Ut error delectus modi asperiores quasi perspiciatis.\nEa laboriosam nobis optio quisquam.\nConsequatur reprehenderit commodi eaque aliquam.\nVeritatis est velit eligendi.\nMaiores similique est saepe dignissimos sit ut ullam consequatur.\nNam vel ipsam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 1L, "Ullam perspiciatis aut dolores enim dignissimos.\nEt sunt et quaerat quis aperiam maxime similique.\nVoluptatibus sapiente est error.\nQuaerat perspiciatis ullam.\nUt inventore nihil autem amet iusto possimus iusto.\nNulla aperiam dolorem aperiam non corrupti voluptatem sint sit aspernatur.", new DateTime(2023, 1, 7, 18, 35, 38, 917, DateTimeKind.Utc).AddTicks(9192), 16L, "Rerum facere ut. Cupiditate labore ducimus quam est alias. Non vero ut. Quo architecto iste et eaque culpa. Quia aspernatur sed et.", "Dolores nisi ut et maxime dolorem illum ut.", 3, "Illo quia recusandae quo. Sint ea suscipit ipsa repellat qui fugiat aperiam iure doloremque. Ut consectetur et at qui." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 3L, "Eos quo dolorum eum error non porro molestiae et inventore.", new DateTime(2023, 8, 24, 22, 37, 24, 119, DateTimeKind.Utc).AddTicks(2256), 22L, "laborum", "Nemo nesciunt magni maxime repellat corrupti.", 2, "iure" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 4L, "Aspernatur iure quas est nulla aut.\nEt assumenda iusto.\nTempore ducimus natus voluptas voluptas aut.\nTemporibus quod animi nemo optio laborum.\nNon ipsam rem exercitationem voluptatem perferendis.", new DateTime(2022, 5, 19, 3, 12, 7, 478, DateTimeKind.Utc).AddTicks(6870), 8L, "Dolorem non dolor expedita tenetur eos.", "Quia dolorem consequuntur.", 1L, 1, "alias" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 5L, "Quidem repellendus sed est.\nNihil aliquam libero ipsa explicabo et fugit.\nFacere fugiat animi ad.\nOccaecati quos dolores consequuntur adipisci repellendus et ullam exercitationem esse.\nIn cum magni voluptatem.\nVoluptatem dolorem animi unde voluptas facere et.", new DateTime(2023, 8, 30, 19, 21, 10, 135, DateTimeKind.Utc).AddTicks(169), 33L, "Ad omnis et quia in tempore molestias officia facere enim.\nMagni voluptas ut laudantium quam.\nQuibusdam culpa qui libero repellat.\nNeque assumenda et consectetur dicta ipsum mollitia qui.\nVoluptas dolores at accusantium consequatur a et itaque.\nIn pariatur minima ducimus dolorum accusantium voluptas.", "Vitae sed est autem pariatur quisquam facere debitis dolorem temporibus.", 2, "Accusantium amet cum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 6L, "Est atque quam quam nesciunt ducimus. Aut nisi est odio laborum voluptate officiis rerum. Sunt voluptatem ducimus porro. Animi nihil excepturi error. Itaque error sunt et in sed odit omnis ratione.", new DateTime(2023, 8, 26, 15, 8, 9, 256, DateTimeKind.Utc).AddTicks(9654), 19L, "Beatae eos asperiores velit aut iusto voluptatem neque. Autem maiores quaerat ipsum. Et vero vel. Aut porro aspernatur aut ut quas vero. Sit quia recusandae blanditiis dolorum rerum voluptas sint. Autem similique consequatur non consequuntur.", "Labore magnam ad.", 0, "Nesciunt eligendi eum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "TestCases" },
                values: new object[] { 7L, "corporis", new DateTime(2021, 12, 29, 2, 43, 29, 447, DateTimeKind.Utc).AddTicks(1454), 29L, "Veniam magnam eveniet incidunt libero possimus ipsa.", "Nostrum reiciendis in.", "Distinctio aut qui delectus ut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 8L, "Error placeat repellendus recusandae harum ratione.\nVeniam tempora sit vel rem.\nVel facilis officiis.\nAt repellendus quasi beatae.", new DateTime(2021, 9, 27, 0, 1, 3, 535, DateTimeKind.Utc).AddTicks(1633), 31L, "Odit doloribus provident totam sapiente animi.", "Perferendis culpa voluptatibus facilis perferendis.", 1, "Nobis et perferendis exercitationem id soluta blanditiis sunt." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 10L, "Autem aliquid harum. Quia aperiam est ipsa cupiditate enim officia quisquam nesciunt. Harum dicta molestias error quo voluptatibus officiis impedit. Dolorem dignissimos aut dolore ad laborum asperiores. Sint dolores consequuntur eos. Harum ad et ut numquam expedita maxime harum voluptatem.", new DateTime(2023, 7, 28, 16, 57, 19, 368, DateTimeKind.Utc).AddTicks(3686), 33L, "Modi numquam non aliquid velit quibusdam tempora dolor numquam earum.\nCum consequatur earum sed voluptatibus repellat sint reprehenderit.\nDistinctio atque impedit amet quibusdam.\nEt non at dolorum.", "Porro doloribus perspiciatis incidunt facere nobis vel.", 1L, 3, "Animi libero dolor dolore ipsa omnis nesciunt vitae pariatur. Consequatur consequatur temporibus sit et non odit tempore qui. Officia illum qui. Et consequatur assumenda eius. Accusamus aut ducimus aut et tempore rerum illum sint debitis. Delectus inventore delectus eum voluptates." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 12L, "Odit explicabo ipsa blanditiis voluptatibus.", new DateTime(2023, 5, 16, 7, 54, 34, 420, DateTimeKind.Utc).AddTicks(2186), 3L, "In sunt quia enim.\nNam earum non facere qui ut voluptas.\nOmnis dicta est eum odio eligendi facilis quasi quia iure.\nEa aut provident cumque soluta qui dicta sed.", "Suscipit incidunt beatae similique.", 1L, 0, "Voluptatem eligendi odit veritatis aut ad praesentium magnam praesentium eligendi.\nEst rerum eaque assumenda.\nEt fuga similique quibusdam quaerat rerum sapiente voluptatem." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "TestCases" },
                values: new object[] { 14L, "Aut culpa provident exercitationem numquam ducimus ut.", new DateTime(2023, 5, 8, 15, 50, 51, 336, DateTimeKind.Utc).AddTicks(4355), 14L, "Sunt veritatis architecto voluptatum tenetur error voluptas repellat dicta.\nPossimus quas blanditiis.\nEt et facilis id ad amet eaque ea aspernatur veniam.\nEveniet rerum eum ut ipsam aut animi.", "Temporibus debitis neque omnis.", 2L, "Placeat et consequuntur ratione.\nEligendi deserunt laborum eos cupiditate nesciunt et ut molestiae." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "TestCases" },
                values: new object[] { 15L, "Rerum fugiat aut ea id ex magnam dolorum eligendi. Enim eum numquam sapiente temporibus molestiae. Dolorum earum explicabo.", new DateTime(2023, 7, 16, 23, 5, 14, 926, DateTimeKind.Utc).AddTicks(6196), 4L, "Earum harum quas laboriosam corrupti natus ad sint dignissimos beatae. Aut quaerat consequuntur voluptatum sunt nemo explicabo. Assumenda non fugiat sunt.", "Id quibusdam veritatis.", "Placeat debitis deserunt quia. Et earum non iure necessitatibus culpa praesentium. Odio quos nisi accusantium et eligendi. Sit corrupti placeat fugit harum minima. Quod dignissimos vero illo consequatur eligendi soluta commodi non. Voluptatem nam quo." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 17L, "Officia amet modi modi omnis recusandae vel natus omnis consequuntur. Rerum ullam unde qui est debitis. Molestias voluptatem nostrum. Quidem occaecati totam. Voluptate reiciendis esse quas.", new DateTime(2023, 2, 5, 2, 12, 13, 554, DateTimeKind.Utc).AddTicks(4204), 11L, "Facere cupiditate cupiditate fugiat ratione ad esse consequatur.\nOdit maiores culpa at dolorum laborum esse quis rerum omnis.\nVoluptates aliquam architecto rerum debitis perspiciatis laborum et dolor.\nAnimi ipsa animi dolorem et delectus.", "Dicta alias doloribus aspernatur praesentium quasi eum mollitia assumenda sequi.", 2L, 3, "Adipisci natus voluptatem.\nAliquam corrupti sunt est voluptate enim debitis est numquam.\nCupiditate aut officiis necessitatibus.\nQui non deserunt." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 20L, "Totam possimus aut adipisci adipisci voluptate veritatis est consequatur aliquam.\nEligendi nihil sunt harum dolore.\nInventore voluptatem id voluptas itaque non iure.\nAperiam tempore non.\nSed soluta rerum maxime qui a sed et aut quia.\nAutem commodi et voluptate.", new DateTime(2022, 4, 18, 21, 41, 57, 759, DateTimeKind.Utc).AddTicks(6276), 8L, "Sapiente voluptate cupiditate non odit quo autem libero.\nVoluptates consectetur aut soluta ex dignissimos voluptas tempore reprehenderit.\nEos est qui aut non.", "Et nihil delectus aliquid.", 1L, 3, "Eaque nostrum blanditiis eum nostrum ducimus sed voluptatem. Eum quam quia neque id at fugiat. Sunt ducimus hic quo magni aspernatur ducimus cumque. Consequatur commodi deleniti eos occaecati natus ea laboriosam harum et. Id reprehenderit iusto perspiciatis iusto molestiae." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 21L, "Doloremque nobis sit id atque est qui nihil illo eaque.\nNihil omnis eaque qui occaecati recusandae qui nemo deserunt magni.\nExpedita commodi quaerat qui.\nQuibusdam earum est vel.\nAlias quisquam ea fuga cum aperiam suscipit vel sed.\nUt qui voluptatem nihil rerum nam asperiores perspiciatis inventore fugiat.", new DateTime(2023, 6, 26, 21, 14, 41, 379, DateTimeKind.Utc).AddTicks(3458), 6L, "Sint non atque.", "Ea cumque reprehenderit et asperiores aut.", 1L, 2, "Illum aut accusantium qui." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 22L, "Reprehenderit nesciunt dolore excepturi laboriosam iste consequatur perspiciatis aut qui. Perspiciatis omnis facere ut deleniti mollitia vero natus. Et enim corrupti sed atque. Repellat animi maiores modi cumque nesciunt doloremque commodi vero. Harum sint deleniti sint modi ut consequuntur dicta. Fugit mollitia hic eos velit quia maiores laboriosam.", new DateTime(2023, 1, 20, 2, 37, 30, 723, DateTimeKind.Utc).AddTicks(5959), 22L, "Et nulla vitae vel rerum vitae saepe ratione ea aut.\nMinima ab praesentium repellendus ab.", "Cum est voluptas.", 3, "Libero impedit accusantium.\nIste non natus culpa eligendi voluptatum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "TestCases" },
                values: new object[] { 23L, "Mollitia voluptate illo eveniet ex.", new DateTime(2023, 9, 3, 20, 54, 12, 345, DateTimeKind.Utc).AddTicks(963), 39L, "Ut ut et expedita.\nMolestias facere est non.\nExpedita maiores rerum sequi dolore et mollitia consequatur minima architecto.\nMollitia aut unde omnis officiis repellat.", "Asperiores et corrupti perferendis ea aut velit unde.", 2L, "id" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 24L, "Eum at quaerat quidem sit quam mollitia laborum cupiditate.\nEst iusto dolores labore quam ut nobis autem aliquam ex.", new DateTime(2023, 3, 2, 12, 56, 34, 347, DateTimeKind.Utc).AddTicks(954), "nostrum", "Aut eos assumenda.", 2, "Consectetur nisi similique et ut officiis maxime. Occaecati ut voluptas sed nihil vel. In officia tenetur dolorem aliquid aut repudiandae asperiores laudantium. Cumque voluptas qui qui rem nam hic sint ut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "TestCases" },
                values: new object[] { 25L, "Sapiente voluptate ad ut aut asperiores voluptas aut.\nAsperiores ab labore vel voluptatem.\nMaxime omnis consequuntur.\nSaepe molestiae in.", new DateTime(2022, 12, 6, 4, 42, 30, 45, DateTimeKind.Utc).AddTicks(9389), 19L, "Qui tenetur est omnis voluptatum cum. Sunt beatae cumque quia illum corrupti autem ducimus sit. Quia facere hic dolorem consequuntur ullam inventore voluptatibus minus dicta. Aut sed quo enim laboriosam non est fugiat tempore. Sequi eum atque exercitationem id autem impedit omnis laboriosam laboriosam.", "Molestias magni provident qui nihil asperiores provident quo quibusdam.", 1L, "Minus dolorem impedit ut et animi.\nVoluptatem ut omnis itaque autem rerum aliquid natus eius.\nAtque sint vitae nostrum sint soluta repudiandae repellendus.\nLibero et molestias quis iure.\nQuos rerum consequatur dolorem magni officiis cum qui et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "TestCases" },
                values: new object[] { 26L, "Deserunt ab quis a et eos deleniti ad.\nEt expedita aperiam.\nEt laudantium officiis.\nMolestias aliquid molestiae reprehenderit placeat voluptas.\nEt assumenda dicta impedit voluptates facere.", new DateTime(2023, 7, 26, 6, 17, 11, 417, DateTimeKind.Utc).AddTicks(5872), 1L, "voluptate", "Et ullam sit et.", 1L, "quia" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 27L, "Ratione velit consequatur aliquid nulla est dolorem nemo.", new DateTime(2022, 6, 24, 9, 57, 31, 627, DateTimeKind.Utc).AddTicks(6095), 34L, "Iusto sed recusandae laborum nobis. Et laborum culpa. Ex voluptas et sint omnis eius quisquam. Ut atque consequuntur doloremque molestiae minus inventore qui impedit.", "Nulla architecto et ipsam consequatur nobis et quae corporis dolorem.", 1L, 1, "omnis" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 29L, "Fuga quisquam veniam dolorem.\nEt fugit laudantium incidunt quisquam aperiam.\nEt dolores vel qui beatae architecto qui et delectus perspiciatis.", new DateTime(2022, 3, 21, 20, 42, 20, 272, DateTimeKind.Utc).AddTicks(9185), 20L, "Explicabo qui eum a accusantium.", "Nostrum voluptatem soluta ratione placeat iusto illo.", 1, "Voluptas qui debitis accusamus illum quaerat a qui accusantium quasi." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 31L, "Aperiam rerum qui voluptas.\nMolestiae consectetur ipsum voluptatem incidunt enim ipsa quisquam asperiores quos.\nNecessitatibus aut aut dolorum voluptas fuga sint ut.\nQuia tempora est provident soluta beatae nostrum aspernatur iusto.", new DateTime(2023, 4, 21, 18, 56, 28, 622, DateTimeKind.Utc).AddTicks(7499), 6L, "Suscipit minus et omnis eum vitae quaerat officia repellendus.\nVoluptate ut vel cupiditate est velit.\nRerum totam voluptatem reiciendis earum quis.", "Qui dolores quae molestias ut ut.", 0, "Perspiciatis excepturi aut in occaecati illum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 32L, "cumque", new DateTime(2023, 9, 12, 3, 17, 48, 824, DateTimeKind.Utc).AddTicks(4433), 22L, "Quibusdam eligendi aut eveniet nihil est harum qui perspiciatis asperiores.\nMolestiae aut et possimus ut.", "Sed aut hic itaque sint ut laudantium dignissimos qui.", 3, "Ipsam ut perferendis ducimus dolorem maiores laboriosam autem.\nQuia eius dolore.\nReprehenderit ducimus non deleniti eligendi cumque qui illo soluta.\nRem qui quo inventore voluptas rem exercitationem.\nAccusamus sit minima et ipsam iste et ut reprehenderit cupiditate.\nAb omnis porro enim." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 36L, "Quia nam voluptatem voluptatem minima corrupti quia et non. Corporis alias omnis distinctio sed eum omnis molestiae perferendis eos. Minus perferendis minus ut totam laboriosam eum.", new DateTime(2022, 12, 1, 20, 0, 21, 800, DateTimeKind.Utc).AddTicks(7202), 18L, "Natus et temporibus eveniet rerum quis. Vitae dolor similique culpa vitae eum facere aliquam quod dolorem. Aliquid voluptas a sit deserunt est quam nostrum. Ratione earum voluptatum eius itaque nihil laborum doloribus esse. Corrupti quia quidem illo illo.", "Excepturi eum eum corporis repudiandae vero quia dolores ad.", 2L, 0, "asperiores" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 37L, "Est eos voluptatum aliquid voluptatum.", new DateTime(2023, 5, 25, 17, 11, 2, 280, DateTimeKind.Utc).AddTicks(9990), 40L, "Aut est neque labore.\nCupiditate vel temporibus enim qui a dolore ut doloribus est.\nUt non perferendis eius molestiae nihil est eum facere voluptas.\nReprehenderit ut et qui.\nQuasi numquam voluptas voluptas.", "Porro dicta rerum voluptas quaerat facilis possimus.", 2, "Aliquid facilis autem assumenda omnis. Voluptate laboriosam laborum quo repellendus ut ea molestiae numquam. Nihil explicabo veritatis ullam ratione a exercitationem rerum amet." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "TestCases" },
                values: new object[] { "Maiores blanditiis molestiae. Occaecati hic accusantium porro omnis veritatis repudiandae. Velit maiores expedita rerum quia quidem. Et et maiores. Fugit nihil rerum voluptas explicabo ea non. Exercitationem consequatur suscipit blanditiis eum enim ad.", new DateTime(2023, 2, 12, 20, 35, 58, 0, DateTimeKind.Utc).AddTicks(2681), 21L, "Repellat et vel sed in sit non.", "Dolor id et non voluptas dolore itaque.", 1L, "Explicabo animi ea et impedit ea sint omnis.\nMolestiae ullam id." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 40L, "Voluptatibus ut et.", new DateTime(2023, 7, 22, 4, 32, 0, 783, DateTimeKind.Utc).AddTicks(4767), 35L, "animi", "Eos non enim.", 2, "Adipisci atque quo ut magnam ut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "TestCases" },
                values: new object[] { 41L, "Aut est ut maiores veniam autem debitis ipsam voluptas.\nDolor laborum impedit sit ea aperiam non reprehenderit.\nFacilis ut veritatis.", new DateTime(2022, 1, 31, 0, 13, 42, 482, DateTimeKind.Utc).AddTicks(9717), 37L, "temporibus", "Deleniti et sequi beatae necessitatibus cumque.", "fugit" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 46L, "Tempore fuga molestias ea.\nMinus sequi laboriosam.\nIn officiis molestiae neque quia voluptatum repellendus ipsam.\nAliquam qui inventore eveniet maxime repellat consequuntur.", new DateTime(2022, 7, 9, 12, 34, 54, 742, DateTimeKind.Utc).AddTicks(3500), 32L, "In voluptas quia nesciunt quo et expedita ut non. Similique tempore exercitationem hic. Omnis aut excepturi.", "Autem qui deserunt nobis doloremque rerum adipisci.", 2, "Vitae illo cumque eos quo ex sint minima ipsum praesentium." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "TestCases" },
                values: new object[] { 47L, "corporis", new DateTime(2022, 4, 10, 19, 14, 51, 527, DateTimeKind.Utc).AddTicks(530), 39L, "Nobis officiis vel magni totam perspiciatis voluptate fugiat.", "Recusandae voluptatem aperiam sunt et.", "Et atque consequatur minus quisquam qui quis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 48L, "Tempora voluptates sint voluptatem et consequatur.", new DateTime(2023, 3, 9, 23, 17, 35, 713, DateTimeKind.Utc).AddTicks(700), 5L, "blanditiis", "Doloribus quas ipsa et eveniet cum.", 2L, 3, "Exercitationem modi sit. Aspernatur velit rem. Quibusdam corrupti neque voluptate ut perferendis autem illo aperiam. Et eligendi deleniti nobis laborum delectus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 53L, "Minus officiis dolorem aut praesentium facere.", new DateTime(2022, 9, 12, 20, 42, 39, 625, DateTimeKind.Utc).AddTicks(7206), 15L, "Et dolores consequatur.", "Enim qui rerum ut molestiae.", 2L, 3, "Aut et rerum repellat odio.\nSit sapiente eos quidem quos odio aut iste non.\nVero iure culpa labore ipsum odit aut reiciendis.\nLibero ducimus nostrum architecto voluptate tempore eum blanditiis.\nQuam non vitae est eveniet nihil sapiente maiores.\nNostrum et voluptatem at voluptatem tenetur molestiae animi." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 57L, "Quaerat cupiditate ad illo facilis ex numquam.\nLaudantium iure rerum aut eos qui velit iste.\nNulla aut omnis laudantium numquam vitae.\nEligendi aperiam quis.\nVel cumque deleniti vitae molestiae impedit consequatur molestiae.", new DateTime(2022, 8, 3, 23, 32, 52, 510, DateTimeKind.Utc).AddTicks(7890), 21L, "amet", "Laboriosam ab veritatis quasi iusto corrupti non doloremque.", 2, "Optio molestiae blanditiis accusantium laboriosam qui ipsum molestiae.\nAccusantium recusandae quae sit distinctio.\nAut ipsa dignissimos dolore commodi est maiores cupiditate et voluptas.\nAut a molestiae commodi voluptatibus doloremque ab aspernatur enim ut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 59L, "Totam quis animi modi rerum facere eaque.", new DateTime(2023, 8, 16, 4, 28, 23, 130, DateTimeKind.Utc).AddTicks(533), 29L, "Et alias qui ea nemo sed enim sunt quo sequi.\nVoluptatem nulla voluptate illum omnis quos distinctio ab recusandae.\nSunt quo est.\nSit exercitationem voluptas.\nUt at est placeat nulla autem animi.\nEsse a quisquam commodi consequatur sit maiores magnam.", "Enim molestiae nemo est quae dolorum voluptatibus expedita quia architecto.", 3, "Ut aliquam cum itaque quae qui aut magni maxime.\nTempore non iure placeat." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 60L, "Aut voluptas reiciendis et. Aperiam vel corporis quasi similique alias. Eius beatae beatae cumque sit similique maxime. Pariatur qui voluptatem et. Maiores eum consequatur voluptas quia temporibus ipsa.", new DateTime(2022, 10, 31, 8, 35, 21, 543, DateTimeKind.Utc).AddTicks(4548), 26L, "Deleniti saepe sit occaecati nobis sit et eveniet odit harum. Vel iure voluptatem. Illo et ipsam velit veritatis unde.", "Saepe sunt deleniti a.", 1, "et" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 63L, "Sapiente quae excepturi rerum inventore. Aut nulla deleniti est consequatur. Repellendus eveniet deleniti id aut qui non repudiandae.", new DateTime(2021, 1, 11, 8, 5, 41, 370, DateTimeKind.Utc).AddTicks(704), 9L, "Quidem odit similique possimus qui et aut dolores.", "Dolores perspiciatis qui sed provident accusamus totam quas.", 1L, 1, "Dolores reprehenderit recusandae hic dolores deleniti est quis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 67L, "Occaecati sed impedit quia laborum perspiciatis qui.", new DateTime(2023, 8, 31, 8, 7, 22, 461, DateTimeKind.Utc).AddTicks(4137), 10L, "Et iure consectetur.\nAd quia aut quia id quidem animi quia inventore.\nCorrupti tempore sed architecto necessitatibus corrupti.\nVeritatis illo quo.", "Accusamus libero sed rerum assumenda voluptatum temporibus sint blanditiis voluptate.", 1L, 3, "qui" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 68L, "consectetur", new DateTime(2023, 8, 9, 13, 33, 26, 737, DateTimeKind.Utc).AddTicks(2679), 35L, "Exercitationem architecto sit dicta impedit similique.", "Saepe et incidunt.", 1L, 0, "Repellat labore magni exercitationem illo.\nRerum recusandae iure voluptatem non illo voluptatem ut maxime placeat.\nDoloribus consequatur sit." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 69L, "Aut ipsum ut alias fugiat eaque officiis delectus molestiae quia. Illo velit similique ab recusandae deserunt. Inventore fugit delectus labore ipsam error sit veniam eum tenetur.", new DateTime(2023, 8, 15, 16, 10, 57, 293, DateTimeKind.Utc).AddTicks(6496), 5L, "cum", "Eum sed quo.", 2, "Asperiores officiis voluptatem saepe neque qui ea laudantium eaque nemo. Repellendus dolore necessitatibus. Nam quaerat illo qui. Necessitatibus cumque beatae alias accusamus at suscipit. Unde expedita et sed nesciunt velit corrupti sit dolor. Necessitatibus atque amet deleniti sit aut nulla blanditiis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "TestCases" },
                values: new object[] { 1L, "Est est occaecati eos id cupiditate blanditiis aut.\nPariatur commodi aperiam et iusto quia culpa voluptas non culpa.\nDolorem nulla quae at incidunt qui unde.", new DateTime(2023, 8, 16, 5, 5, 25, 834, DateTimeKind.Utc).AddTicks(682), 3L, "Inventore voluptates autem.", "Enim et magni ut.", "Et asperiores quis sed ad temporibus officia et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 2L, "Et voluptas error libero et voluptatem aut et.\nAmet at beatae.", new DateTime(2021, 10, 11, 3, 28, 58, 845, DateTimeKind.Utc).AddTicks(6848), 12L, "Voluptatem aliquam quibusdam.\nQuis placeat voluptatem incidunt repellat.\nMagni autem quis accusantium voluptatem velit.\nDoloremque vitae nulla nihil qui itaque reiciendis qui.\nVoluptatem ducimus est omnis minus et illo debitis et.", "Quibusdam et corrupti aut.", 3, "Est et quo accusantium aut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 9L, "Est ut consequatur id illum omnis consequatur eum.\nLabore et perferendis dolores inventore aut sunt.", new DateTime(2021, 1, 20, 14, 36, 9, 992, DateTimeKind.Utc).AddTicks(7874), 27L, "Accusantium deserunt harum et voluptas.\nNesciunt velit non et ratione exercitationem.", "Aperiam quia sint repellendus non.", 1, "Earum amet dicta similique qui voluptatem sit.\nVoluptatem ex aut est velit ipsum repellat ut.\nNatus odit provident minima cum facere.\nAd quibusdam qui quibusdam aut consequatur.\nEt provident a vitae sed est sit ex quo." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 11L, "Perferendis eaque cumque.\nDolore nisi optio.\nDolorem iste dolorum placeat eaque rerum.\nVoluptas eaque magnam sunt itaque.\nAt et est quasi dicta repudiandae eligendi ut.\nEst culpa ad ex velit voluptatem quas nemo est eos.", new DateTime(2021, 2, 28, 7, 14, 23, 388, DateTimeKind.Utc).AddTicks(9712), 8L, "Eos error esse quaerat dolorem quae.", "Facilis non iste ullam illum a exercitationem vel iure.", 1, "Dicta nemo consequatur voluptatem accusamus est ut est eos sunt.\nIn nesciunt iure aut sit neque et alias voluptatem officiis.\nIpsa rem soluta placeat voluptas qui qui animi tempora." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 16L, "Dolorem voluptas mollitia natus provident enim.", new DateTime(2023, 8, 30, 6, 14, 20, 405, DateTimeKind.Utc).AddTicks(5534), 18L, "ab", "Quis vero at voluptate dolores facere ea.", 0, "Laboriosam et impedit debitis dignissimos nostrum.\nRepellendus impedit sint aspernatur nam.\nPerferendis eius aut dolor." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 18L, "Et voluptate tempore.\nMollitia quae ex ut neque id enim.", new DateTime(2023, 4, 14, 10, 37, 28, 281, DateTimeKind.Utc).AddTicks(1703), 1L, "Laudantium totam dolores perspiciatis repellendus quia neque.", "Laborum quidem tenetur quia.", 3, "Recusandae qui ipsam nobis quod exercitationem sapiente perferendis aliquid animi.\nAliquam sit adipisci." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 28L, "blanditiis", new DateTime(2023, 5, 25, 23, 14, 19, 897, DateTimeKind.Utc).AddTicks(1318), 40L, "placeat", "Modi magnam maiores eos.", 1, "alias" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 30L, "Et distinctio quibusdam.\nQuos unde veniam iusto ut libero aspernatur et quia.\nDolores laudantium ipsa commodi.\nAperiam fuga quaerat beatae inventore.\nQui consequatur vel repellat.\nSint temporibus earum nam tempore velit quia.", new DateTime(2018, 2, 28, 4, 51, 17, 464, DateTimeKind.Utc).AddTicks(1862), 36L, "Perferendis minima ullam eum iusto odit. Iste et cum est dolorem vel minima ut necessitatibus. Quo velit sequi qui eligendi officiis. Deleniti et in aperiam. Eaque odio vel et et optio ut consectetur aliquam at. Qui est voluptas fugiat sint.", "Laudantium mollitia ut.", 1L, 0, "Aut fugit illo.\nQuia doloribus dignissimos vel occaecati alias iste est iure molestiae.\nQuis qui id culpa ipsa perspiciatis.\nIusto commodi voluptatem nemo impedit perspiciatis quos dicta nostrum ex.\nDolore incidunt excepturi quia aut itaque.\nConsequatur fuga eos repellat." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "TestCases" },
                values: new object[] { 33L, "Et dolores vitae possimus placeat qui earum sit itaque et.\nIn sed consequuntur placeat voluptas in.\nVoluptas dolorem unde illum perspiciatis.\nMolestiae sit praesentium in autem.\nEt aliquid repellat dicta qui aut.\nEst omnis atque voluptate et pariatur maiores voluptate optio non.", new DateTime(2023, 1, 12, 13, 12, 27, 203, DateTimeKind.Utc).AddTicks(4826), 27L, "Itaque perspiciatis a ut vel accusantium. Ducimus qui id reprehenderit quo facere voluptas. Recusandae delectus iste voluptates qui et architecto voluptas rerum. Magni voluptatibus labore est rerum inventore ipsum ex dolores.", "Repellendus esse repellendus enim et excepturi eum inventore ut autem.", "Minus similique corrupti consequatur omnis in sunt tenetur." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 34L, "Id non alias totam quia qui at animi et. Dolor ipsam impedit nobis quae laboriosam omnis possimus cum. Ex et exercitationem necessitatibus. Expedita iure non laborum quisquam.", new DateTime(2023, 3, 20, 19, 36, 16, 790, DateTimeKind.Utc).AddTicks(8334), 25L, "Reprehenderit qui ut eius sint nam ipsam possimus occaecati est.", "Vel sed vitae maiores.", 1L, 1, "eos" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "TestCases" },
                values: new object[] { 38L, "Dolor illum quis cupiditate vero assumenda repudiandae eaque ratione est.", new DateTime(2022, 12, 3, 9, 31, 29, 834, DateTimeKind.Utc).AddTicks(3109), 13L, "Fugiat quaerat ut ratione.", "Nisi ipsum deserunt odio neque voluptatem perferendis explicabo id.", 1L, "illo" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 42L, "In quibusdam temporibus autem quod soluta aut cum hic. Accusantium cum atque vitae. Magnam quia nemo dolorum non maiores iste nostrum voluptas. Officiis maxime eius. Odio adipisci commodi voluptatem temporibus iusto animi.", new DateTime(2023, 5, 2, 13, 33, 42, 290, DateTimeKind.Utc).AddTicks(6444), 23L, "Neque velit delectus voluptatum quidem libero possimus pariatur repudiandae culpa.", "Facilis dolorum vitae voluptatem.", 0, "Nihil error excepturi sint. Consequatur dolorem sapiente neque repellendus quis officiis. Quia dolores officiis sit molestias accusantium est accusamus itaque. Illo molestias ipsa distinctio velit eligendi est quaerat." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 45L, "Soluta et totam necessitatibus.", new DateTime(2023, 7, 16, 6, 18, 32, 505, DateTimeKind.Utc).AddTicks(9248), 19L, "Omnis sed eligendi fuga sequi.\nUnde et nesciunt aut et at eos aut sint.\nId consequatur quo consequatur et neque debitis aut voluptatem.", "Quaerat fuga similique.", 0, "Quis commodi officia voluptatum autem esse.\nVel sequi maxime.\nEum enim nostrum ipsam officia nemo perferendis quo quia.\nAdipisci et dolorem rerum similique." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 54L, "quis", new DateTime(2023, 2, 5, 1, 57, 27, 655, DateTimeKind.Utc).AddTicks(5584), 8L, "Voluptate incidunt quidem.\nOdit eius possimus dolor veritatis dolorum dolor.\nQuae aut dolore nobis velit velit sequi ut.\nRem dolorem id assumenda quia.", "Tenetur vel dolore necessitatibus animi qui sed.", 2L, 3, "Aliquam dolor quia laborum qui eum.\nAccusamus ex in in inventore enim qui." });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 3, 2, 1, 13, 970, DateTimeKind.Utc).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2018, 3, 18, 20, 20, 18, 565, DateTimeKind.Utc).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 30, 13, 26, 18, 311, DateTimeKind.Utc).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 13, 2, 57, 7, 626, DateTimeKind.Utc).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 31, 17, 41, 8, 586, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 1, 4, 55, 36, 594, DateTimeKind.Utc).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 12, 10, 49, 14, 685, DateTimeKind.Utc).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2017, 1, 17, 2, 2, 48, 76, DateTimeKind.Utc).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 11, 2, 10, 27, 0, DateTimeKind.Utc).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 10, 8, 56, 3, 989, DateTimeKind.Utc).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2018, 1, 16, 1, 40, 24, 677, DateTimeKind.Utc).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 19, 17, 20, 10, 436, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2017, 10, 25, 7, 41, 33, 408, DateTimeKind.Utc).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 23, 15, 4, 25, 589, DateTimeKind.Utc).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2018, 7, 17, 9, 47, 51, 461, DateTimeKind.Utc).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 26, 20, 6, 40, 651, DateTimeKind.Utc).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 27, 13, 25, 30, 872, DateTimeKind.Utc).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 23, 21, 34, 1, 493, DateTimeKind.Utc).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 1, 20, 24, 18, 54, DateTimeKind.Utc).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 5, 16, 38, 513, DateTimeKind.Utc).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 7, 14, 42, 1, 222, DateTimeKind.Utc).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 6, 2, 6, 24, 573, DateTimeKind.Utc).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 1, 20, 38, 19, 269, DateTimeKind.Utc).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 18, 10, 6, 12, 672, DateTimeKind.Utc).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 14, 17, 19, 38, 914, DateTimeKind.Utc).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 14, 17, 43, 50, 816, DateTimeKind.Utc).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 21, 3, 33, 1, 107, DateTimeKind.Utc).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2022, 2, 20, 16, 13, 26, 731, DateTimeKind.Utc).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 1, 4, 37, 49, 722, DateTimeKind.Utc).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2017, 7, 3, 9, 0, 48, 563, DateTimeKind.Utc).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 19, 18, 56, 7, 939, DateTimeKind.Utc).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 17, 17, 2, 33, 888, DateTimeKind.Utc).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 10, 56, 50, 450, DateTimeKind.Utc).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 30, 2, 50, 17, 76, DateTimeKind.Utc).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 22, 21, 51, 69, DateTimeKind.Utc).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedAt",
                value: new DateTime(2021, 6, 7, 21, 17, 0, 474, DateTimeKind.Utc).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 5, 0, 47, 55, 37, DateTimeKind.Utc).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 27, 20, 37, 34, 997, DateTimeKind.Utc).AddTicks(2898));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedAt",
                value: new DateTime(2022, 2, 20, 18, 18, 19, 661, DateTimeKind.Utc).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 24, 1, 36, 23, 349, DateTimeKind.Utc).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedAt",
                value: new DateTime(2021, 12, 9, 6, 3, 17, 960, DateTimeKind.Utc).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 14, 12, 40, 58, 292, DateTimeKind.Utc).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 1, 11, 15, 32, 438, DateTimeKind.Utc).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedAt",
                value: new DateTime(2019, 2, 11, 16, 39, 41, 956, DateTimeKind.Utc).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 15, 15, 46, 22, 434, DateTimeKind.Utc).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 5, 12, 39, 54, 919, DateTimeKind.Utc).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 13, 21, 51, 40, 121, DateTimeKind.Utc).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 48L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 12, 17, 53, 44, 13, DateTimeKind.Utc).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 24, 2, 20, 44, 889, DateTimeKind.Utc).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 1, 7, 42, 28, 6, DateTimeKind.Utc).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 29, 3, 43, 55, 715, DateTimeKind.Utc).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedAt",
                value: new DateTime(2022, 2, 7, 3, 39, 15, 158, DateTimeKind.Utc).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedAt",
                value: new DateTime(2019, 4, 16, 7, 16, 40, 376, DateTimeKind.Utc).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedAt",
                value: new DateTime(2022, 2, 2, 17, 27, 29, 523, DateTimeKind.Utc).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 30, 7, 47, 27, 666, DateTimeKind.Utc).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 56L,
                column: "CreatedAt",
                value: new DateTime(2018, 4, 25, 12, 57, 17, 214, DateTimeKind.Utc).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 15, 3, 21, 31, 835, DateTimeKind.Utc).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 23, 23, 32, 12, 593, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 26, 6, 57, 17, 573, DateTimeKind.Utc).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedAt",
                value: new DateTime(2019, 2, 28, 23, 12, 24, 286, DateTimeKind.Utc).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 6, 16, 9, 51, 929, DateTimeKind.Utc).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 14, 54, 5, 70, DateTimeKind.Utc).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 21, 23, 57, 3, 239, DateTimeKind.Utc).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 64L,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 26, 0, 40, 20, 444, DateTimeKind.Utc).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 25, 19, 54, 44, 679, DateTimeKind.Utc).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedAt",
                value: new DateTime(2021, 12, 7, 12, 24, 30, 65, DateTimeKind.Utc).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 16, 4, 6, 49, 699, DateTimeKind.Utc).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 22, 7, 27, 9, 471, DateTimeKind.Utc).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 4, 2, 42, 48, 840, DateTimeKind.Utc).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 2, 20, 36, 36, 361, DateTimeKind.Utc).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 1, 42, 18, 928, DateTimeKind.Utc).AddTicks(1000), new DateTime(2023, 7, 28, 10, 32, 52, 169, DateTimeKind.Utc).AddTicks(83), new DateTime(2022, 8, 22, 18, 3, 21, 879, DateTimeKind.Utc).AddTicks(7817), new DateTime(2023, 7, 30, 18, 17, 4, 890, DateTimeKind.Utc).AddTicks(7469) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 27, 6, 18, 1, 666, DateTimeKind.Utc).AddTicks(9097), new DateTime(2023, 8, 8, 20, 56, 6, 542, DateTimeKind.Utc).AddTicks(5045), new DateTime(2023, 1, 30, 22, 30, 27, 672, DateTimeKind.Utc).AddTicks(4917), new DateTime(2023, 2, 15, 18, 57, 0, 737, DateTimeKind.Utc).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 18, 21, 15, 54, 440, DateTimeKind.Utc).AddTicks(3586), new DateTime(2023, 8, 6, 16, 23, 21, 674, DateTimeKind.Utc).AddTicks(2821), new DateTime(2023, 5, 19, 21, 53, 12, 257, DateTimeKind.Utc).AddTicks(5774), new DateTime(2023, 7, 31, 0, 48, 13, 702, DateTimeKind.Utc).AddTicks(7305) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 1, 21, 21, 53, 16, 52, DateTimeKind.Utc).AddTicks(3872), new DateTime(2022, 6, 9, 9, 49, 37, 589, DateTimeKind.Utc).AddTicks(7016), new DateTime(2021, 8, 8, 20, 36, 46, 967, DateTimeKind.Utc).AddTicks(7037), new DateTime(2022, 8, 21, 6, 47, 25, 201, DateTimeKind.Utc).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 7, 45, 740, DateTimeKind.Utc).AddTicks(6602), new DateTime(2023, 5, 16, 10, 13, 18, 933, DateTimeKind.Utc).AddTicks(5138), new DateTime(2022, 11, 7, 18, 45, 20, 720, DateTimeKind.Utc).AddTicks(374), new DateTime(2023, 8, 24, 15, 28, 58, 522, DateTimeKind.Utc).AddTicks(4812) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 9, 20, 12, 17, 31, 527, DateTimeKind.Utc).AddTicks(7171), new DateTime(2021, 4, 17, 19, 29, 20, 281, DateTimeKind.Utc).AddTicks(2643), new DateTime(2018, 12, 20, 9, 1, 24, 726, DateTimeKind.Utc).AddTicks(6998), new DateTime(2020, 1, 3, 13, 34, 55, 459, DateTimeKind.Utc).AddTicks(3705) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 3, 3, 12, 13, 4, 484, DateTimeKind.Utc).AddTicks(1115), new DateTime(2023, 2, 7, 23, 38, 34, 763, DateTimeKind.Utc).AddTicks(4720), new DateTime(2020, 4, 28, 7, 43, 22, 165, DateTimeKind.Utc).AddTicks(8570), new DateTime(2021, 1, 30, 4, 27, 34, 476, DateTimeKind.Utc).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 10, 25, 20, 3, 7, 793, DateTimeKind.Utc).AddTicks(3763), new DateTime(2022, 9, 3, 14, 4, 12, 451, DateTimeKind.Utc).AddTicks(723), new DateTime(2021, 5, 13, 12, 37, 39, 598, DateTimeKind.Utc).AddTicks(8861), new DateTime(2021, 7, 25, 0, 59, 25, 143, DateTimeKind.Utc).AddTicks(6805) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 0, 49, 356, DateTimeKind.Utc).AddTicks(2543), new DateTime(2023, 6, 5, 12, 1, 6, 718, DateTimeKind.Utc).AddTicks(5537), new DateTime(2021, 6, 9, 2, 26, 59, 872, DateTimeKind.Utc).AddTicks(1663), new DateTime(2022, 5, 9, 21, 28, 47, 274, DateTimeKind.Utc).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 13, 20, 31, 1, 275, DateTimeKind.Utc).AddTicks(4731), new DateTime(2022, 3, 29, 0, 56, 39, 705, DateTimeKind.Utc).AddTicks(2236), new DateTime(2021, 3, 20, 8, 34, 17, 264, DateTimeKind.Utc).AddTicks(464), new DateTime(2022, 12, 13, 12, 52, 14, 526, DateTimeKind.Utc).AddTicks(1177) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 7, 14, 10, 32, 60, DateTimeKind.Utc).AddTicks(4788), new DateTime(2023, 4, 19, 8, 14, 36, 739, DateTimeKind.Utc).AddTicks(1658), new DateTime(2023, 1, 21, 23, 47, 49, 274, DateTimeKind.Utc).AddTicks(8443), new DateTime(2023, 2, 25, 15, 2, 58, 757, DateTimeKind.Utc).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 27, 5, 30, 55, 272, DateTimeKind.Utc).AddTicks(1176), new DateTime(2022, 12, 25, 10, 48, 51, 363, DateTimeKind.Utc).AddTicks(2253), new DateTime(2022, 9, 30, 4, 45, 26, 732, DateTimeKind.Utc).AddTicks(9176), new DateTime(2023, 8, 22, 0, 12, 3, 970, DateTimeKind.Utc).AddTicks(8396) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 28, 7, 32, 8, 107, DateTimeKind.Utc).AddTicks(9575), new DateTime(2023, 9, 19, 9, 58, 9, 794, DateTimeKind.Utc).AddTicks(5355), new DateTime(2023, 4, 27, 18, 4, 14, 216, DateTimeKind.Utc).AddTicks(9699), new DateTime(2023, 9, 10, 2, 43, 37, 957, DateTimeKind.Utc).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 5, 31, 1, 21, 26, 362, DateTimeKind.Utc).AddTicks(5137), new DateTime(2020, 8, 2, 10, 29, 19, 944, DateTimeKind.Utc).AddTicks(9935), new DateTime(2019, 11, 17, 16, 18, 21, 826, DateTimeKind.Utc).AddTicks(3255), new DateTime(2022, 11, 2, 22, 3, 10, 613, DateTimeKind.Utc).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 9, 12, 4, 7, 44, 241, DateTimeKind.Utc).AddTicks(3024), new DateTime(2022, 8, 22, 13, 11, 37, 71, DateTimeKind.Utc).AddTicks(2356), new DateTime(2021, 4, 7, 19, 41, 9, 379, DateTimeKind.Utc).AddTicks(9076), new DateTime(2023, 7, 17, 14, 1, 27, 394, DateTimeKind.Utc).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 19, 10, 7, 47, 147, DateTimeKind.Utc).AddTicks(2004), new DateTime(2023, 8, 30, 2, 15, 17, 768, DateTimeKind.Utc).AddTicks(8696), new DateTime(2023, 2, 27, 6, 5, 45, 448, DateTimeKind.Utc).AddTicks(8511) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 1, 31, 5, 56, 20, 985, DateTimeKind.Utc).AddTicks(7202), new DateTime(2020, 12, 11, 4, 32, 12, 219, DateTimeKind.Utc).AddTicks(3790), new DateTime(2019, 1, 22, 14, 26, 7, 9, DateTimeKind.Utc).AddTicks(1039), new DateTime(2020, 8, 26, 14, 11, 27, 18, DateTimeKind.Utc).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 31, 21, 29, 27, 155, DateTimeKind.Utc).AddTicks(3155), new DateTime(2023, 8, 12, 6, 52, 19, 692, DateTimeKind.Utc).AddTicks(6864), new DateTime(2020, 12, 31, 14, 21, 38, 161, DateTimeKind.Utc).AddTicks(1214), new DateTime(2021, 12, 8, 22, 32, 58, 559, DateTimeKind.Utc).AddTicks(4058) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 15, 10, 3, 10, 899, DateTimeKind.Utc).AddTicks(9160), new DateTime(2023, 7, 14, 11, 28, 13, 315, DateTimeKind.Utc).AddTicks(2923), new DateTime(2023, 7, 3, 18, 6, 38, 912, DateTimeKind.Utc).AddTicks(2268), new DateTime(2023, 7, 30, 6, 39, 6, 562, DateTimeKind.Utc).AddTicks(6117) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 3, 31, 8, 26, 21, 809, DateTimeKind.Utc).AddTicks(8325), new DateTime(2020, 3, 3, 0, 15, 44, 914, DateTimeKind.Utc).AddTicks(8089), new DateTime(2019, 12, 1, 18, 44, 56, 722, DateTimeKind.Utc).AddTicks(5337), new DateTime(2022, 3, 18, 22, 23, 29, 456, DateTimeKind.Utc).AddTicks(3737) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 26, 12, 922, DateTimeKind.Utc).AddTicks(9778), new DateTime(2023, 6, 8, 13, 39, 8, 925, DateTimeKind.Utc).AddTicks(2232), new DateTime(2022, 3, 11, 3, 6, 53, 661, DateTimeKind.Utc).AddTicks(4983), new DateTime(2023, 6, 25, 16, 55, 12, 799, DateTimeKind.Utc).AddTicks(1180) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 19, 21, 33, 56, 840, DateTimeKind.Utc).AddTicks(749), new DateTime(2023, 5, 12, 2, 16, 56, 173, DateTimeKind.Utc).AddTicks(5342), new DateTime(2019, 12, 19, 21, 23, 45, 656, DateTimeKind.Utc).AddTicks(8077), new DateTime(2022, 5, 21, 22, 0, 41, 981, DateTimeKind.Utc).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 3, 31, 17, 30, 48, 330, DateTimeKind.Utc).AddTicks(8579), new DateTime(2020, 3, 26, 7, 7, 26, 397, DateTimeKind.Utc).AddTicks(1183), new DateTime(2017, 7, 21, 13, 38, 21, 744, DateTimeKind.Utc).AddTicks(7869), new DateTime(2023, 9, 9, 9, 29, 35, 26, DateTimeKind.Utc).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 5, 27, 21, 49, 42, 441, DateTimeKind.Utc).AddTicks(9737), new DateTime(2019, 8, 6, 10, 20, 27, 453, DateTimeKind.Utc).AddTicks(293), new DateTime(2019, 4, 4, 0, 49, 5, 995, DateTimeKind.Utc).AddTicks(8151), new DateTime(2020, 9, 24, 8, 39, 5, 178, DateTimeKind.Utc).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 28, 5, 32, 47, 96, DateTimeKind.Utc).AddTicks(7761), new DateTime(2023, 4, 13, 4, 10, 2, 491, DateTimeKind.Utc).AddTicks(3545), new DateTime(2021, 4, 18, 11, 25, 5, 953, DateTimeKind.Utc).AddTicks(215), new DateTime(2022, 4, 16, 21, 42, 0, 774, DateTimeKind.Utc).AddTicks(9473) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 3, 9, 26, 59, 337, DateTimeKind.Utc).AddTicks(830), new DateTime(2023, 5, 24, 5, 19, 0, 355, DateTimeKind.Utc).AddTicks(6601), new DateTime(2023, 2, 21, 9, 53, 32, 732, DateTimeKind.Utc).AddTicks(114), new DateTime(2023, 4, 11, 15, 4, 11, 845, DateTimeKind.Utc).AddTicks(3874) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2023, 3, 1, 12, 41, 6, 332, DateTimeKind.Utc).AddTicks(5454), new DateTime(2023, 1, 2, 22, 53, 21, 577, DateTimeKind.Utc).AddTicks(5251), new DateTime(2022, 7, 12, 13, 5, 20, 655, DateTimeKind.Utc).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 5, 2, 26, 0, 853, DateTimeKind.Utc).AddTicks(1846), new DateTime(2023, 6, 4, 20, 33, 29, 513, DateTimeKind.Utc).AddTicks(224), new DateTime(2023, 4, 3, 16, 8, 41, 540, DateTimeKind.Utc).AddTicks(7037), new DateTime(2023, 8, 22, 9, 48, 16, 906, DateTimeKind.Utc).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 1, 3, 13, 49, 921, DateTimeKind.Utc).AddTicks(9556), new DateTime(2023, 4, 12, 15, 58, 35, 342, DateTimeKind.Utc).AddTicks(520), new DateTime(2023, 3, 5, 19, 40, 10, 913, DateTimeKind.Utc).AddTicks(6731), new DateTime(2023, 7, 24, 13, 21, 52, 363, DateTimeKind.Utc).AddTicks(9009) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 20, 17, 19, 31, 23, DateTimeKind.Utc).AddTicks(9905), new DateTime(2023, 7, 29, 18, 1, 26, 225, DateTimeKind.Utc).AddTicks(745), new DateTime(2021, 8, 12, 2, 45, 18, 716, DateTimeKind.Utc).AddTicks(7446), new DateTime(2022, 7, 1, 9, 45, 13, 630, DateTimeKind.Utc).AddTicks(4889) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 47, 36, 969, DateTimeKind.Utc).AddTicks(7839), new DateTime(2023, 8, 29, 20, 59, 20, 596, DateTimeKind.Utc).AddTicks(2852), new DateTime(2023, 8, 25, 20, 2, 33, 939, DateTimeKind.Utc).AddTicks(8069), new DateTime(2023, 9, 7, 12, 21, 59, 326, DateTimeKind.Utc).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 18, 11, 19, 26, 995, DateTimeKind.Utc).AddTicks(6303), new DateTime(2022, 4, 9, 13, 41, 46, 503, DateTimeKind.Utc).AddTicks(7714), new DateTime(2022, 2, 16, 16, 45, 11, 592, DateTimeKind.Utc).AddTicks(4562), new DateTime(2023, 7, 11, 3, 10, 6, 339, DateTimeKind.Utc).AddTicks(3839) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 9, 10, 8, 49, 33, 713, DateTimeKind.Utc).AddTicks(369), new DateTime(2022, 7, 1, 3, 21, 41, 938, DateTimeKind.Utc).AddTicks(2962), new DateTime(2019, 6, 19, 4, 26, 5, 501, DateTimeKind.Utc).AddTicks(8342), new DateTime(2019, 8, 28, 8, 50, 51, 712, DateTimeKind.Utc).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 28, 3, 38, 21, 415, DateTimeKind.Utc).AddTicks(5743), new DateTime(2023, 9, 11, 6, 54, 43, 980, DateTimeKind.Utc).AddTicks(351), new DateTime(2022, 8, 25, 22, 26, 14, 688, DateTimeKind.Utc).AddTicks(7069), new DateTime(2022, 9, 23, 17, 9, 3, 797, DateTimeKind.Utc).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2019, 12, 7, 0, 47, 45, 281, DateTimeKind.Utc).AddTicks(9996), new DateTime(2019, 11, 1, 14, 16, 50, 677, DateTimeKind.Utc).AddTicks(1283), new DateTime(2018, 8, 7, 3, 32, 50, 965, DateTimeKind.Utc).AddTicks(135), new DateTime(2021, 3, 25, 19, 29, 14, 870, DateTimeKind.Utc).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 12, 25, 3, 30, 29, 391, DateTimeKind.Utc).AddTicks(6491), new DateTime(2021, 11, 30, 11, 10, 46, 342, DateTimeKind.Utc).AddTicks(472), new DateTime(2021, 4, 15, 22, 48, 15, 931, DateTimeKind.Utc).AddTicks(5627), new DateTime(2021, 12, 14, 23, 42, 8, 77, DateTimeKind.Utc).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 23, 2, 559, DateTimeKind.Utc).AddTicks(9517), new DateTime(2023, 4, 15, 10, 20, 24, 156, DateTimeKind.Utc).AddTicks(2728), new DateTime(2022, 7, 17, 4, 39, 3, 553, DateTimeKind.Utc).AddTicks(9196), new DateTime(2023, 4, 28, 5, 6, 11, 492, DateTimeKind.Utc).AddTicks(4447) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 20, 57, 29, 457, DateTimeKind.Utc).AddTicks(7766), new DateTime(2023, 8, 27, 8, 44, 46, 785, DateTimeKind.Utc).AddTicks(1277), new DateTime(2023, 7, 6, 6, 3, 50, 216, DateTimeKind.Utc).AddTicks(2736), new DateTime(2023, 9, 2, 4, 29, 2, 982, DateTimeKind.Utc).AddTicks(6126) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 4, 20, 16, 26, 957, DateTimeKind.Utc).AddTicks(1746), new DateTime(2023, 7, 7, 14, 8, 48, 308, DateTimeKind.Utc).AddTicks(9580), new DateTime(2023, 6, 1, 11, 54, 26, 445, DateTimeKind.Utc).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 3, 44, 42, 303, DateTimeKind.Utc).AddTicks(5062), new DateTime(2022, 7, 17, 17, 56, 40, 871, DateTimeKind.Utc).AddTicks(4825), new DateTime(2020, 12, 23, 23, 24, 9, 373, DateTimeKind.Utc).AddTicks(1246), new DateTime(2022, 8, 15, 19, 55, 49, 491, DateTimeKind.Utc).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 5, 55, 33, 32, DateTimeKind.Utc).AddTicks(4733), new DateTime(2020, 1, 30, 15, 6, 55, 35, DateTimeKind.Utc).AddTicks(1464), new DateTime(2019, 12, 4, 1, 18, 2, 769, DateTimeKind.Utc).AddTicks(3042), new DateTime(2023, 6, 21, 15, 20, 51, 907, DateTimeKind.Utc).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 44, 12, 491, DateTimeKind.Utc).AddTicks(4017), new DateTime(2023, 7, 25, 8, 10, 51, 92, DateTimeKind.Utc).AddTicks(8217), new DateTime(2020, 6, 12, 5, 36, 57, 881, DateTimeKind.Utc).AddTicks(2685), new DateTime(2020, 11, 9, 6, 10, 36, 782, DateTimeKind.Utc).AddTicks(4711) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 4, 19, 33, 8, 233, DateTimeKind.Utc).AddTicks(7803), new DateTime(2023, 8, 29, 22, 8, 20, 394, DateTimeKind.Utc).AddTicks(173), new DateTime(2023, 8, 15, 13, 16, 51, 751, DateTimeKind.Utc).AddTicks(4906), new DateTime(2023, 9, 14, 1, 10, 56, 415, DateTimeKind.Utc).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 7, 12, 535, DateTimeKind.Utc).AddTicks(7207), new DateTime(2023, 8, 25, 4, 10, 45, 370, DateTimeKind.Utc).AddTicks(3238), new DateTime(2023, 7, 10, 21, 0, 56, 166, DateTimeKind.Utc).AddTicks(4787), new DateTime(2023, 8, 4, 19, 19, 18, 319, DateTimeKind.Utc).AddTicks(1431) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 18, 9, 2, 49, 711, DateTimeKind.Utc).AddTicks(5636), new DateTime(2023, 5, 3, 21, 13, 7, 425, DateTimeKind.Utc).AddTicks(309), new DateTime(2022, 9, 24, 19, 0, 10, 347, DateTimeKind.Utc).AddTicks(2706), new DateTime(2023, 3, 30, 7, 14, 46, 798, DateTimeKind.Utc).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 25, 23, 46, 20, 100, DateTimeKind.Utc).AddTicks(4533), new DateTime(2022, 2, 21, 17, 40, 6, 118, DateTimeKind.Utc).AddTicks(16), new DateTime(2020, 6, 19, 8, 3, 16, 70, DateTimeKind.Utc).AddTicks(3872), new DateTime(2021, 11, 30, 0, 45, 20, 261, DateTimeKind.Utc).AddTicks(5782) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 31, 1, 11, 4, 657, DateTimeKind.Utc).AddTicks(1988), new DateTime(2023, 9, 7, 13, 21, 8, 689, DateTimeKind.Utc).AddTicks(8713), new DateTime(2023, 4, 24, 14, 53, 1, 908, DateTimeKind.Utc).AddTicks(558), new DateTime(2023, 8, 21, 2, 26, 2, 32, DateTimeKind.Utc).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 7, 10, 23, 9, 51, 723, DateTimeKind.Utc).AddTicks(8049), new DateTime(2021, 12, 19, 22, 47, 25, 963, DateTimeKind.Utc).AddTicks(2904), new DateTime(2020, 1, 9, 7, 7, 41, 380, DateTimeKind.Utc).AddTicks(5902), new DateTime(2021, 2, 28, 18, 22, 52, 900, DateTimeKind.Utc).AddTicks(8134) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 6, 29, 10, 14, 0, 279, DateTimeKind.Utc).AddTicks(963), new DateTime(2023, 9, 7, 13, 14, 52, 637, DateTimeKind.Utc).AddTicks(9403), new DateTime(2023, 4, 12, 20, 26, 30, 288, DateTimeKind.Utc).AddTicks(1875), new DateTime(2023, 9, 4, 0, 2, 35, 960, DateTimeKind.Utc).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2021, 8, 20, 2, 39, 3, 991, DateTimeKind.Utc).AddTicks(5800), new DateTime(2021, 7, 7, 3, 35, 8, 155, DateTimeKind.Utc).AddTicks(9131), new DateTime(2020, 3, 11, 3, 19, 16, 909, DateTimeKind.Utc).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 5, 5, 10, 9, 32, 416, DateTimeKind.Utc).AddTicks(1686), new DateTime(2021, 5, 19, 3, 42, 57, 107, DateTimeKind.Utc).AddTicks(3294), new DateTime(2019, 11, 4, 5, 27, 48, 172, DateTimeKind.Utc).AddTicks(9225), new DateTime(2023, 2, 24, 23, 10, 35, 414, DateTimeKind.Utc).AddTicks(8552) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 26, 23, 12, 23, 445, DateTimeKind.Utc).AddTicks(8121), new DateTime(2023, 8, 16, 8, 59, 27, 664, DateTimeKind.Utc).AddTicks(7886), new DateTime(2023, 7, 15, 6, 45, 46, 558, DateTimeKind.Utc).AddTicks(1307), new DateTime(2023, 8, 10, 17, 16, 49, 617, DateTimeKind.Utc).AddTicks(4294) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 19, 20, 42, 55, 784, DateTimeKind.Utc).AddTicks(168), new DateTime(2023, 8, 14, 13, 24, 2, 281, DateTimeKind.Utc).AddTicks(4556), new DateTime(2022, 3, 31, 16, 18, 33, 634, DateTimeKind.Utc).AddTicks(7570), new DateTime(2022, 4, 20, 0, 2, 49, 248, DateTimeKind.Utc).AddTicks(1455) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 2, 18, 50, 24, 743, DateTimeKind.Utc).AddTicks(3979), new DateTime(2022, 9, 18, 6, 42, 27, 217, DateTimeKind.Utc).AddTicks(5428), new DateTime(2021, 10, 27, 14, 6, 55, 210, DateTimeKind.Utc).AddTicks(3207), new DateTime(2022, 4, 20, 7, 55, 29, 814, DateTimeKind.Utc).AddTicks(9496) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 1, 27, 9, 22, 18, 750, DateTimeKind.Utc).AddTicks(8713), new DateTime(2022, 9, 30, 8, 49, 39, 834, DateTimeKind.Utc).AddTicks(364), new DateTime(2022, 8, 15, 8, 29, 31, 557, DateTimeKind.Utc).AddTicks(1335), new DateTime(2023, 8, 13, 1, 33, 57, 610, DateTimeKind.Utc).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 13, 14, 47, 15, 594, DateTimeKind.Utc).AddTicks(5957), new DateTime(2023, 9, 19, 4, 3, 43, 353, DateTimeKind.Utc).AddTicks(3185), new DateTime(2023, 7, 17, 0, 13, 50, 223, DateTimeKind.Utc).AddTicks(8057), new DateTime(2023, 7, 24, 12, 16, 1, 262, DateTimeKind.Utc).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 11, 1, 28, 32, 441, DateTimeKind.Utc).AddTicks(7590), new DateTime(2022, 9, 26, 5, 58, 20, 595, DateTimeKind.Utc).AddTicks(394), new DateTime(2022, 6, 16, 15, 2, 35, 548, DateTimeKind.Utc).AddTicks(470), new DateTime(2022, 12, 20, 4, 30, 15, 271, DateTimeKind.Utc).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 7, 4, 56, 49, 669, DateTimeKind.Utc).AddTicks(6804), new DateTime(2023, 3, 22, 0, 22, 41, 826, DateTimeKind.Utc).AddTicks(5994), new DateTime(2023, 2, 26, 5, 46, 35, 298, DateTimeKind.Utc).AddTicks(8490), new DateTime(2023, 5, 12, 22, 33, 14, 24, DateTimeKind.Utc).AddTicks(8677) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 18, 20, 20, 14, 162, DateTimeKind.Utc).AddTicks(5240), new DateTime(2022, 12, 9, 11, 48, 58, 139, DateTimeKind.Utc).AddTicks(5197), new DateTime(2017, 4, 20, 18, 5, 48, 376, DateTimeKind.Utc).AddTicks(3193), new DateTime(2023, 7, 23, 14, 5, 23, 806, DateTimeKind.Utc).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 30, 15, 17, 9, 586, DateTimeKind.Utc).AddTicks(6673), new DateTime(2023, 1, 23, 1, 5, 18, 398, DateTimeKind.Utc).AddTicks(7757), new DateTime(2022, 11, 8, 15, 35, 37, 140, DateTimeKind.Utc).AddTicks(3177), new DateTime(2023, 3, 22, 21, 53, 18, 284, DateTimeKind.Utc).AddTicks(3384) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 11, 2, 38, 39, 99, DateTimeKind.Utc).AddTicks(6574), new DateTime(2022, 8, 29, 21, 21, 45, 227, DateTimeKind.Utc).AddTicks(2427), new DateTime(2021, 10, 17, 16, 23, 50, 780, DateTimeKind.Utc).AddTicks(879), new DateTime(2023, 4, 12, 11, 13, 15, 389, DateTimeKind.Utc).AddTicks(9408) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 17, 7, 6, 23, 300, DateTimeKind.Utc).AddTicks(1471), new DateTime(2023, 4, 7, 8, 6, 15, 778, DateTimeKind.Utc).AddTicks(1886), new DateTime(2019, 11, 9, 0, 43, 14, 334, DateTimeKind.Utc).AddTicks(3156), new DateTime(2020, 8, 31, 22, 6, 57, 680, DateTimeKind.Utc).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 20, 7, 49, 46, 462, DateTimeKind.Utc).AddTicks(9394), new DateTime(2023, 5, 23, 17, 26, 53, 575, DateTimeKind.Utc).AddTicks(1966), new DateTime(2022, 3, 9, 6, 21, 14, 977, DateTimeKind.Utc).AddTicks(6119), new DateTime(2022, 7, 20, 21, 25, 55, 349, DateTimeKind.Utc).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 4, 20, 36, 19, 209, DateTimeKind.Utc).AddTicks(4710), new DateTime(2022, 11, 5, 2, 4, 51, 73, DateTimeKind.Utc).AddTicks(8756), new DateTime(2022, 6, 9, 9, 11, 7, 570, DateTimeKind.Utc).AddTicks(8410), new DateTime(2023, 4, 19, 16, 22, 48, 69, DateTimeKind.Utc).AddTicks(6442) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 19, 29, 54, 830, DateTimeKind.Utc).AddTicks(3115), new DateTime(2021, 8, 16, 4, 24, 26, 92, DateTimeKind.Utc).AddTicks(6607), new DateTime(2021, 6, 29, 8, 52, 55, 312, DateTimeKind.Utc).AddTicks(9169), new DateTime(2022, 4, 12, 19, 3, 56, 320, DateTimeKind.Utc).AddTicks(6398) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 19, 4, 35, 50, 46, DateTimeKind.Utc).AddTicks(3506), new DateTime(2023, 9, 12, 3, 28, 51, 171, DateTimeKind.Utc).AddTicks(1447), new DateTime(2019, 3, 29, 3, 37, 0, 251, DateTimeKind.Utc).AddTicks(3122), new DateTime(2020, 11, 21, 1, 23, 38, 796, DateTimeKind.Utc).AddTicks(1904) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 17, 39, 31, 76, DateTimeKind.Utc).AddTicks(6677), new DateTime(2022, 11, 1, 15, 20, 45, 491, DateTimeKind.Utc).AddTicks(6874), new DateTime(2022, 6, 23, 4, 30, 36, 664, DateTimeKind.Utc).AddTicks(3997), new DateTime(2022, 12, 29, 2, 54, 5, 534, DateTimeKind.Utc).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2018, 4, 7, 17, 53, 56, 921, DateTimeKind.Utc).AddTicks(4723), new DateTime(2018, 3, 21, 16, 8, 59, 399, DateTimeKind.Utc).AddTicks(3611), new DateTime(2017, 9, 21, 17, 25, 45, 265, DateTimeKind.Utc).AddTicks(6105), new DateTime(2019, 7, 15, 14, 25, 47, 971, DateTimeKind.Utc).AddTicks(4157) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 5, 30, 36, 742, DateTimeKind.Utc).AddTicks(7457), new DateTime(2023, 8, 14, 16, 44, 8, 760, DateTimeKind.Utc).AddTicks(2202), new DateTime(2023, 7, 13, 8, 59, 52, 581, DateTimeKind.Utc).AddTicks(4447), new DateTime(2023, 7, 19, 2, 56, 51, 616, DateTimeKind.Utc).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 16, 32, 45, 666, DateTimeKind.Utc).AddTicks(5473), new DateTime(2023, 1, 30, 18, 48, 57, 429, DateTimeKind.Utc).AddTicks(2276), new DateTime(2021, 7, 12, 7, 41, 8, 52, DateTimeKind.Utc).AddTicks(6852), new DateTime(2022, 11, 10, 17, 44, 4, 881, DateTimeKind.Utc).AddTicks(6935) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 3, 28, 6, 42, 43, 168, DateTimeKind.Utc).AddTicks(162), new DateTime(2022, 3, 4, 4, 8, 25, 408, DateTimeKind.Utc).AddTicks(2486), new DateTime(2021, 11, 6, 9, 46, 13, 115, DateTimeKind.Utc).AddTicks(8339), new DateTime(2023, 2, 14, 12, 20, 39, 398, DateTimeKind.Utc).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 33, 54, 588, DateTimeKind.Utc).AddTicks(7457), new DateTime(2023, 5, 6, 2, 19, 47, 19, DateTimeKind.Utc).AddTicks(6686), new DateTime(2022, 10, 20, 6, 35, 58, 856, DateTimeKind.Utc).AddTicks(1009), new DateTime(2023, 9, 2, 11, 3, 25, 320, DateTimeKind.Utc).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 7, 11, 3, 723, DateTimeKind.Utc).AddTicks(616), new DateTime(2023, 8, 25, 11, 59, 2, 725, DateTimeKind.Utc).AddTicks(6661), new DateTime(2022, 3, 17, 22, 22, 53, 740, DateTimeKind.Utc).AddTicks(8587), new DateTime(2022, 9, 1, 17, 48, 3, 997, DateTimeKind.Utc).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 15, 7, 20, 41, 849, DateTimeKind.Utc).AddTicks(712), new DateTime(2023, 7, 3, 20, 10, 45, 633, DateTimeKind.Utc).AddTicks(9266), new DateTime(2021, 7, 14, 6, 49, 3, 611, DateTimeKind.Utc).AddTicks(6916), new DateTime(2021, 12, 18, 13, 53, 6, 406, DateTimeKind.Utc).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 12, 13, 12, 0, 304, DateTimeKind.Utc).AddTicks(2924), new DateTime(2023, 8, 25, 22, 8, 27, 131, DateTimeKind.Utc).AddTicks(5751), new DateTime(2023, 7, 12, 20, 34, 12, 922, DateTimeKind.Utc).AddTicks(3438), new DateTime(2023, 9, 13, 19, 43, 38, 83, DateTimeKind.Utc).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 16, 11, 21, 0, 435, DateTimeKind.Utc).AddTicks(240), new DateTime(2023, 5, 21, 8, 48, 42, 508, DateTimeKind.Utc).AddTicks(4829), new DateTime(2023, 3, 31, 7, 1, 28, 777, DateTimeKind.Utc).AddTicks(4854), new DateTime(2023, 4, 5, 22, 7, 52, 971, DateTimeKind.Utc).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 26, 19, 14, 38, 505, DateTimeKind.Utc).AddTicks(4762), new DateTime(2023, 1, 8, 12, 32, 11, 923, DateTimeKind.Utc).AddTicks(2609), new DateTime(2022, 2, 27, 19, 20, 47, 317, DateTimeKind.Utc).AddTicks(3958), new DateTime(2022, 7, 25, 13, 14, 45, 664, DateTimeKind.Utc).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 11, 21, 29, 9, 851, DateTimeKind.Utc).AddTicks(3084), new DateTime(2023, 6, 12, 10, 20, 44, 318, DateTimeKind.Utc).AddTicks(8745), new DateTime(2022, 1, 15, 12, 10, 21, 736, DateTimeKind.Utc).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 6, 3, 0, 55, DateTimeKind.Utc).AddTicks(6702), new DateTime(2023, 1, 6, 7, 5, 25, 62, DateTimeKind.Utc).AddTicks(7980), new DateTime(2022, 11, 17, 23, 36, 7, 455, DateTimeKind.Utc).AddTicks(9346), new DateTime(2023, 9, 12, 12, 47, 34, 399, DateTimeKind.Utc).AddTicks(6053) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2019, 6, 5, 23, 55, 33, 364, DateTimeKind.Utc).AddTicks(1554), new DateTime(2018, 11, 26, 15, 24, 59, 943, DateTimeKind.Utc).AddTicks(7766), new DateTime(2017, 4, 13, 3, 42, 42, 57, DateTimeKind.Utc).AddTicks(3764), new DateTime(2017, 12, 29, 19, 7, 35, 474, DateTimeKind.Utc).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 14, 4, 38, 58, 225, DateTimeKind.Utc).AddTicks(6716), new DateTime(2022, 10, 5, 0, 7, 13, 530, DateTimeKind.Utc).AddTicks(7984), new DateTime(2021, 11, 7, 10, 22, 22, 356, DateTimeKind.Utc).AddTicks(550), new DateTime(2022, 8, 13, 10, 42, 2, 573, DateTimeKind.Utc).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 20, 21, 38, 12, 76, DateTimeKind.Utc).AddTicks(6564), new DateTime(2023, 9, 16, 22, 58, 2, 291, DateTimeKind.Utc).AddTicks(5936), new DateTime(2023, 9, 14, 23, 18, 11, 399, DateTimeKind.Utc).AddTicks(962), new DateTime(2023, 9, 17, 3, 29, 41, 850, DateTimeKind.Utc).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 10, 29, 10, 46, 49, 605, DateTimeKind.Utc).AddTicks(9150), new DateTime(2021, 11, 30, 15, 39, 33, 259, DateTimeKind.Utc).AddTicks(376), new DateTime(2018, 4, 23, 5, 52, 38, 498, DateTimeKind.Utc).AddTicks(7594), new DateTime(2019, 7, 16, 5, 58, 47, 713, DateTimeKind.Utc).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 7, 12, 13, 11, 56, 363, DateTimeKind.Utc).AddTicks(162), new DateTime(2023, 9, 16, 18, 21, 2, 876, DateTimeKind.Utc).AddTicks(7909), new DateTime(2023, 9, 9, 4, 23, 13, 877, DateTimeKind.Utc).AddTicks(4034), new DateTime(2023, 9, 13, 0, 25, 22, 122, DateTimeKind.Utc).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 6, 15, 1, 36, 46, 239, DateTimeKind.Utc).AddTicks(3830), new DateTime(2023, 4, 17, 9, 35, 22, 333, DateTimeKind.Utc).AddTicks(9305), new DateTime(2016, 11, 14, 16, 28, 24, 937, DateTimeKind.Utc).AddTicks(4783), new DateTime(2020, 10, 2, 21, 26, 36, 689, DateTimeKind.Utc).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 19, 3, 53, 58, 229, DateTimeKind.Utc).AddTicks(8710), new DateTime(2023, 4, 15, 6, 17, 52, 0, DateTimeKind.Utc).AddTicks(5867), new DateTime(2022, 9, 11, 0, 51, 38, 620, DateTimeKind.Utc).AddTicks(9501), new DateTime(2023, 8, 28, 12, 58, 31, 314, DateTimeKind.Utc).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 12, 20, 1, 58, 366, DateTimeKind.Utc).AddTicks(5190), new DateTime(2023, 4, 18, 4, 55, 14, 436, DateTimeKind.Utc).AddTicks(1559), new DateTime(2023, 4, 13, 1, 24, 26, 319, DateTimeKind.Utc).AddTicks(4565), new DateTime(2023, 8, 14, 23, 12, 43, 696, DateTimeKind.Utc).AddTicks(1391) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 2, 17, 6, 13, 23, 590, DateTimeKind.Utc).AddTicks(1822), new DateTime(2021, 2, 3, 13, 11, 7, 841, DateTimeKind.Utc).AddTicks(6108), new DateTime(2019, 6, 28, 1, 32, 6, 226, DateTimeKind.Utc).AddTicks(1162), new DateTime(2022, 10, 11, 3, 24, 4, 767, DateTimeKind.Utc).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 1, 3, 49, 34, 427, DateTimeKind.Utc).AddTicks(145), new DateTime(2023, 5, 15, 22, 10, 6, 971, DateTimeKind.Utc).AddTicks(8384), new DateTime(2022, 10, 4, 2, 0, 20, 131, DateTimeKind.Utc).AddTicks(5123), new DateTime(2023, 1, 21, 3, 8, 48, 700, DateTimeKind.Utc).AddTicks(8971) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 36, 17, 81, DateTimeKind.Utc).AddTicks(9100), new DateTime(2023, 6, 11, 15, 47, 23, 927, DateTimeKind.Utc).AddTicks(5523), new DateTime(2019, 4, 9, 22, 41, 17, 595, DateTimeKind.Utc).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 10, 2, 8, 52, 47, 614, DateTimeKind.Utc).AddTicks(1106), new DateTime(2021, 10, 6, 2, 2, 25, 669, DateTimeKind.Utc).AddTicks(741), new DateTime(2021, 4, 9, 21, 8, 47, 517, DateTimeKind.Utc).AddTicks(9165), new DateTime(2023, 6, 11, 15, 29, 6, 857, DateTimeKind.Utc).AddTicks(3381) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 14, 5, 10, 16, 420, DateTimeKind.Utc).AddTicks(5653), new DateTime(2023, 8, 9, 5, 18, 5, 642, DateTimeKind.Utc).AddTicks(5225), new DateTime(2023, 7, 27, 22, 21, 6, 334, DateTimeKind.Utc).AddTicks(9813), new DateTime(2023, 8, 26, 7, 31, 40, 479, DateTimeKind.Utc).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 8, 3, 12, 37, 772, DateTimeKind.Utc).AddTicks(2750), new DateTime(2023, 6, 18, 14, 13, 54, 192, DateTimeKind.Utc).AddTicks(9344), new DateTime(2023, 1, 24, 23, 0, 4, 961, DateTimeKind.Utc).AddTicks(8400), new DateTime(2023, 3, 31, 2, 0, 33, 728, DateTimeKind.Utc).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 28, 23, 16, 59, 758, DateTimeKind.Utc).AddTicks(9687), new DateTime(2023, 2, 11, 8, 38, 17, 165, DateTimeKind.Utc).AddTicks(9362), new DateTime(2022, 6, 3, 19, 18, 53, 123, DateTimeKind.Utc).AddTicks(2719), new DateTime(2023, 3, 12, 17, 46, 18, 67, DateTimeKind.Utc).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 5, 23, 6, 31, 8, 500, DateTimeKind.Utc).AddTicks(7956), new DateTime(2020, 6, 29, 21, 3, 26, 718, DateTimeKind.Utc).AddTicks(6849), new DateTime(2017, 10, 13, 19, 50, 38, 332, DateTimeKind.Utc).AddTicks(6830), new DateTime(2018, 6, 3, 19, 34, 42, 190, DateTimeKind.Utc).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 11, 18, 12, 23, 851, DateTimeKind.Utc).AddTicks(4331), new DateTime(2023, 7, 31, 10, 36, 33, 832, DateTimeKind.Utc).AddTicks(9608), new DateTime(2021, 5, 24, 23, 16, 34, 296, DateTimeKind.Utc).AddTicks(3450), new DateTime(2021, 10, 17, 12, 17, 54, 30, DateTimeKind.Utc).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 28, 19, 36, 22, 916, DateTimeKind.Utc).AddTicks(709), new DateTime(2023, 3, 5, 10, 43, 44, 806, DateTimeKind.Utc).AddTicks(1557), new DateTime(2022, 12, 24, 15, 29, 45, 92, DateTimeKind.Utc).AddTicks(9799), new DateTime(2023, 2, 18, 4, 20, 23, 237, DateTimeKind.Utc).AddTicks(6517) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 39, 32, 136, DateTimeKind.Utc).AddTicks(9778), new DateTime(2023, 8, 9, 19, 56, 20, 271, DateTimeKind.Utc).AddTicks(7703), new DateTime(2023, 1, 7, 9, 26, 35, 417, DateTimeKind.Utc).AddTicks(8231), new DateTime(2023, 8, 14, 21, 57, 1, 3, DateTimeKind.Utc).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 9, 2, 3, 55, 32, 922, DateTimeKind.Utc).AddTicks(8590), new DateTime(2022, 5, 31, 6, 51, 59, 540, DateTimeKind.Utc).AddTicks(4768), new DateTime(2021, 7, 11, 17, 53, 1, 744, DateTimeKind.Utc).AddTicks(9021), new DateTime(2022, 2, 3, 3, 50, 36, 537, DateTimeKind.Utc).AddTicks(590) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 7, 7, 5, 46, 20, 151, DateTimeKind.Utc).AddTicks(3360), new DateTime(2023, 9, 9, 11, 17, 49, 531, DateTimeKind.Utc).AddTicks(2936), new DateTime(2023, 6, 22, 21, 20, 30, 662, DateTimeKind.Utc).AddTicks(3656), new DateTime(2023, 8, 6, 5, 46, 37, 371, DateTimeKind.Utc).AddTicks(4392) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 5, 15, 43, 16, 687, DateTimeKind.Utc).AddTicks(5690), new DateTime(2023, 9, 7, 3, 42, 55, 972, DateTimeKind.Utc).AddTicks(8352), new DateTime(2023, 8, 19, 6, 44, 44, 984, DateTimeKind.Utc).AddTicks(7506), new DateTime(2023, 9, 3, 9, 48, 6, 944, DateTimeKind.Utc).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 4, 9, 3, 12, 14, 819, DateTimeKind.Utc).AddTicks(633), new DateTime(2020, 12, 18, 4, 16, 29, 218, DateTimeKind.Utc).AddTicks(7581), new DateTime(2019, 10, 13, 20, 27, 56, 216, DateTimeKind.Utc).AddTicks(74), new DateTime(2023, 8, 7, 17, 45, 14, 813, DateTimeKind.Utc).AddTicks(3724) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 13, 18, 6, 46, 504, DateTimeKind.Utc).AddTicks(5975), new DateTime(2023, 4, 27, 12, 6, 46, 713, DateTimeKind.Utc).AddTicks(6388), new DateTime(2022, 11, 24, 3, 4, 15, 273, DateTimeKind.Utc).AddTicks(9715), new DateTime(2023, 1, 27, 10, 37, 27, 636, DateTimeKind.Utc).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 1, 12, 7, 2, 14, 937, DateTimeKind.Utc).AddTicks(6604), new DateTime(2022, 9, 10, 14, 11, 35, 681, DateTimeKind.Utc).AddTicks(3888), new DateTime(2022, 8, 29, 15, 9, 52, 498, DateTimeKind.Utc).AddTicks(9368), new DateTime(2023, 2, 5, 5, 21, 15, 862, DateTimeKind.Utc).AddTicks(1165) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 10, 29, 2, 35, 38, 16, DateTimeKind.Utc).AddTicks(678), new DateTime(2019, 11, 20, 7, 7, 7, 122, DateTimeKind.Utc).AddTicks(93), new DateTime(2017, 6, 29, 23, 11, 54, 374, DateTimeKind.Utc).AddTicks(7378), new DateTime(2018, 8, 11, 11, 51, 11, 549, DateTimeKind.Utc).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 8, 59, 18, 731, DateTimeKind.Utc).AddTicks(4244), new DateTime(2023, 8, 2, 20, 40, 22, 745, DateTimeKind.Utc).AddTicks(4914), new DateTime(2023, 7, 9, 4, 10, 46, 114, DateTimeKind.Utc).AddTicks(620), new DateTime(2023, 7, 24, 0, 2, 2, 563, DateTimeKind.Utc).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 30, 8, 54, 48, 718, DateTimeKind.Utc).AddTicks(469), new DateTime(2022, 12, 3, 22, 7, 53, 1, DateTimeKind.Utc).AddTicks(2690), new DateTime(2022, 5, 19, 17, 57, 40, 553, DateTimeKind.Utc).AddTicks(6996), new DateTime(2023, 1, 16, 16, 34, 7, 332, DateTimeKind.Utc).AddTicks(1276) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 52, 50, 739, DateTimeKind.Utc).AddTicks(5164), new DateTime(2020, 5, 6, 2, 46, 53, 750, DateTimeKind.Utc).AddTicks(2000), new DateTime(2019, 9, 3, 11, 47, 24, 625, DateTimeKind.Utc).AddTicks(4137), new DateTime(2020, 12, 7, 22, 16, 43, 922, DateTimeKind.Utc).AddTicks(7608) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 16, 5, 18, 25, 621, DateTimeKind.Utc).AddTicks(7765), new DateTime(2023, 8, 18, 19, 46, 42, 715, DateTimeKind.Utc).AddTicks(2041), new DateTime(2023, 5, 9, 23, 24, 15, 544, DateTimeKind.Utc).AddTicks(9791), new DateTime(2023, 9, 5, 3, 41, 27, 70, DateTimeKind.Utc).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 29, 22, 4, 31, 552, DateTimeKind.Utc).AddTicks(9128), new DateTime(2022, 8, 25, 16, 5, 26, 918, DateTimeKind.Utc).AddTicks(4846), new DateTime(2022, 6, 25, 20, 52, 8, 268, DateTimeKind.Utc).AddTicks(4528), new DateTime(2022, 10, 17, 7, 11, 28, 95, DateTimeKind.Utc).AddTicks(9280) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 8L, new DateTime(2023, 6, 22, 17, 15, 35, 429, DateTimeKind.Utc).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 55L, new DateTime(2023, 4, 8, 17, 21, 33, 845, DateTimeKind.Utc).AddTicks(2541) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 136L, new DateTime(2023, 9, 7, 10, 46, 49, 354, DateTimeKind.Utc).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 77L, new DateTime(2021, 11, 30, 3, 59, 21, 920, DateTimeKind.Utc).AddTicks(6059) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 155L, new DateTime(2023, 9, 8, 10, 48, 15, 307, DateTimeKind.Utc).AddTicks(2775) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 29L, new DateTime(2021, 2, 9, 3, 17, 32, 583, DateTimeKind.Utc).AddTicks(1753) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 61L, new DateTime(2023, 7, 1, 23, 5, 13, 315, DateTimeKind.Utc).AddTicks(5111) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 7L, new DateTime(2022, 2, 26, 2, 21, 48, 183, DateTimeKind.Utc).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 37L, new DateTime(2023, 9, 18, 5, 4, 11, 124, DateTimeKind.Utc).AddTicks(4645) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 24L, new DateTime(2023, 6, 2, 7, 34, 55, 208, DateTimeKind.Utc).AddTicks(5008) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 26L, new DateTime(2023, 7, 25, 16, 29, 46, 372, DateTimeKind.Utc).AddTicks(3552) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 70L, new DateTime(2023, 2, 2, 11, 39, 48, 529, DateTimeKind.Utc).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 98L, new DateTime(2022, 8, 2, 4, 58, 9, 475, DateTimeKind.Utc).AddTicks(8471) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 148L, new DateTime(2022, 5, 26, 3, 28, 18, 38, DateTimeKind.Utc).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 69L, new DateTime(2023, 1, 4, 21, 19, 41, 976, DateTimeKind.Utc).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 140L, new DateTime(2023, 8, 25, 0, 31, 34, 648, DateTimeKind.Utc).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 38L, new DateTime(2022, 12, 8, 7, 20, 31, 583, DateTimeKind.Utc).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 89L, new DateTime(2023, 8, 12, 20, 6, 46, 919, DateTimeKind.Utc).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 62L, new DateTime(2023, 2, 5, 14, 41, 30, 890, DateTimeKind.Utc).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 2L, new DateTime(2023, 9, 17, 22, 48, 21, 174, DateTimeKind.Utc).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 137L, new DateTime(2023, 8, 25, 20, 11, 29, 924, DateTimeKind.Utc).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 56L, new DateTime(2023, 2, 6, 21, 59, 53, 135, DateTimeKind.Utc).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 26L, new DateTime(2023, 4, 9, 6, 52, 31, 871, DateTimeKind.Utc).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 8, 2, 59, 52, 431, DateTimeKind.Utc).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 30L, new DateTime(2023, 8, 27, 0, 55, 5, 241, DateTimeKind.Utc).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 79L, new DateTime(2023, 8, 13, 5, 42, 18, 37, DateTimeKind.Utc).AddTicks(3081) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 52L, new DateTime(2022, 9, 6, 8, 18, 18, 676, DateTimeKind.Utc).AddTicks(4459) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 148L, new DateTime(2021, 8, 26, 17, 45, 56, 992, DateTimeKind.Utc).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 9L, new DateTime(2023, 2, 25, 7, 44, 23, 703, DateTimeKind.Utc).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 41L, new DateTime(2023, 8, 10, 13, 7, 14, 88, DateTimeKind.Utc).AddTicks(6198) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 17L, new DateTime(2023, 9, 19, 19, 37, 50, 631, DateTimeKind.Utc).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 42L, new DateTime(2023, 9, 16, 16, 21, 1, 395, DateTimeKind.Utc).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 81L, new DateTime(2023, 7, 4, 17, 48, 44, 660, DateTimeKind.Utc).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 92L, new DateTime(2023, 9, 4, 11, 52, 16, 314, DateTimeKind.Utc).AddTicks(7492) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 45L, new DateTime(2022, 9, 6, 7, 5, 26, 941, DateTimeKind.Utc).AddTicks(9354) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 27L, new DateTime(2022, 10, 18, 5, 5, 30, 446, DateTimeKind.Utc).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 7L, new DateTime(2022, 1, 25, 18, 36, 52, 795, DateTimeKind.Utc).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 30L, new DateTime(2023, 8, 2, 18, 0, 46, 865, DateTimeKind.Utc).AddTicks(9714) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 150L, new DateTime(2023, 9, 11, 4, 9, 6, 627, DateTimeKind.Utc).AddTicks(8951) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 5L, new DateTime(2023, 9, 9, 20, 12, 42, 479, DateTimeKind.Utc).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 76L, new DateTime(2022, 8, 1, 7, 4, 50, 852, DateTimeKind.Utc).AddTicks(8150) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 8L, new DateTime(2022, 3, 6, 8, 47, 45, 551, DateTimeKind.Utc).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 41L, new DateTime(2023, 9, 4, 4, 28, 5, 117, DateTimeKind.Utc).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 14L, new DateTime(2023, 7, 9, 11, 6, 12, 524, DateTimeKind.Utc).AddTicks(5043) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 23L, new DateTime(2023, 4, 30, 8, 55, 55, 631, DateTimeKind.Utc).AddTicks(7537) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 36L, new DateTime(2023, 7, 19, 1, 31, 37, 912, DateTimeKind.Utc).AddTicks(2082) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 32L, new DateTime(2023, 7, 15, 12, 59, 35, 513, DateTimeKind.Utc).AddTicks(5077) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 91L, new DateTime(2023, 6, 9, 7, 35, 18, 675, DateTimeKind.Utc).AddTicks(6578) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 13, 29, 43, 74, DateTimeKind.Utc).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 12L, new DateTime(2023, 9, 8, 18, 3, 58, 228, DateTimeKind.Utc).AddTicks(6962) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 177L, new DateTime(2023, 7, 4, 0, 8, 4, 44, DateTimeKind.Utc).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 21L, new DateTime(2023, 1, 4, 2, 12, 19, 413, DateTimeKind.Utc).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 37L, new DateTime(2023, 8, 18, 12, 6, 31, 710, DateTimeKind.Utc).AddTicks(9489) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 84L, new DateTime(2023, 9, 5, 12, 55, 56, 715, DateTimeKind.Utc).AddTicks(8512) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 31L, new DateTime(2023, 9, 15, 19, 12, 54, 933, DateTimeKind.Utc).AddTicks(5437) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 141L, new DateTime(2022, 5, 5, 23, 11, 13, 993, DateTimeKind.Utc).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 19L, new DateTime(2023, 9, 3, 21, 25, 23, 235, DateTimeKind.Utc).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 117L, new DateTime(2023, 6, 20, 4, 11, 5, 404, DateTimeKind.Utc).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 19, 1, 33, 42, 997, DateTimeKind.Utc).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 150L, new DateTime(2023, 1, 28, 17, 6, 42, 341, DateTimeKind.Utc).AddTicks(1378) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 181L, new DateTime(2023, 6, 23, 17, 46, 45, 806, DateTimeKind.Utc).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 169L, new DateTime(2021, 6, 14, 13, 0, 21, 851, DateTimeKind.Utc).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 157L, new DateTime(2023, 8, 22, 6, 48, 15, 534, DateTimeKind.Utc).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 18L, new DateTime(2023, 8, 4, 12, 54, 13, 811, DateTimeKind.Utc).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 157L, new DateTime(2023, 6, 15, 1, 32, 56, 334, DateTimeKind.Utc).AddTicks(5038) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 69L, new DateTime(2023, 6, 1, 1, 34, 41, 299, DateTimeKind.Utc).AddTicks(5669) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 184L, new DateTime(2023, 8, 14, 8, 33, 47, 791, DateTimeKind.Utc).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 25L, new DateTime(2023, 8, 21, 10, 42, 20, 173, DateTimeKind.Utc).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 105L, new DateTime(2022, 12, 16, 10, 24, 40, 843, DateTimeKind.Utc).AddTicks(5122) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 19L, new DateTime(2023, 4, 20, 16, 3, 59, 865, DateTimeKind.Utc).AddTicks(292) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 10L, new DateTime(2022, 7, 3, 22, 9, 16, 175, DateTimeKind.Utc).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 75L, new DateTime(2023, 9, 15, 4, 47, 5, 159, DateTimeKind.Utc).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 98L, new DateTime(2023, 2, 3, 21, 40, 48, 331, DateTimeKind.Utc).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 79L, new DateTime(2023, 9, 6, 5, 51, 28, 202, DateTimeKind.Utc).AddTicks(4098) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 38L, new DateTime(2023, 4, 7, 5, 43, 19, 136, DateTimeKind.Utc).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 46L, new DateTime(2022, 8, 24, 13, 14, 32, 315, DateTimeKind.Utc).AddTicks(4742) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 43L, new DateTime(2022, 11, 16, 1, 20, 33, 904, DateTimeKind.Utc).AddTicks(799) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 23L, new DateTime(2023, 9, 13, 20, 39, 25, 595, DateTimeKind.Utc).AddTicks(4084) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 177L, new DateTime(2023, 1, 5, 17, 46, 44, 648, DateTimeKind.Utc).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 66L, new DateTime(2023, 9, 17, 13, 6, 15, 93, DateTimeKind.Utc).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 65L, new DateTime(2023, 6, 15, 0, 5, 48, 348, DateTimeKind.Utc).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 40L, new DateTime(2023, 5, 26, 13, 51, 46, 191, DateTimeKind.Utc).AddTicks(3691) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 96L, new DateTime(2023, 6, 12, 1, 32, 4, 783, DateTimeKind.Utc).AddTicks(8144) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 28L, new DateTime(2022, 2, 6, 9, 48, 51, 483, DateTimeKind.Utc).AddTicks(2611) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 9L, new DateTime(2023, 8, 25, 2, 31, 20, 490, DateTimeKind.Utc).AddTicks(968) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 96L, new DateTime(2023, 3, 16, 9, 28, 15, 496, DateTimeKind.Utc).AddTicks(8687) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 18L, new DateTime(2023, 5, 20, 4, 43, 58, 481, DateTimeKind.Utc).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 63L, new DateTime(2021, 11, 13, 10, 23, 11, 607, DateTimeKind.Utc).AddTicks(5698) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 89L, new DateTime(2023, 4, 27, 11, 15, 46, 998, DateTimeKind.Utc).AddTicks(6871) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 137L, new DateTime(2023, 8, 19, 4, 11, 42, 625, DateTimeKind.Utc).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 5L, new DateTime(2023, 9, 12, 8, 40, 33, 413, DateTimeKind.Utc).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 109L, new DateTime(2023, 8, 15, 0, 48, 40, 466, DateTimeKind.Utc).AddTicks(5123) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 52L, new DateTime(2022, 8, 15, 12, 11, 36, 652, DateTimeKind.Utc).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 172L, new DateTime(2023, 3, 14, 11, 52, 24, 658, DateTimeKind.Utc).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 52L, new DateTime(2023, 8, 9, 21, 14, 31, 71, DateTimeKind.Utc).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 68L, new DateTime(2023, 9, 6, 22, 23, 26, 436, DateTimeKind.Utc).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 30L, new DateTime(2023, 9, 2, 20, 47, 18, 237, DateTimeKind.Utc).AddTicks(9682) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 74L, new DateTime(2023, 9, 14, 5, 32, 4, 889, DateTimeKind.Utc).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 38L, new DateTime(2023, 8, 6, 5, 32, 53, 413, DateTimeKind.Utc).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 4L, new DateTime(2023, 8, 22, 1, 38, 35, 381, DateTimeKind.Utc).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 96L, new DateTime(2023, 8, 10, 9, 11, 33, 802, DateTimeKind.Utc).AddTicks(6196) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 94L, new DateTime(2023, 7, 7, 20, 47, 47, 519, DateTimeKind.Utc).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 66L, new DateTime(2023, 6, 17, 15, 15, 30, 257, DateTimeKind.Utc).AddTicks(7953) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 74L, new DateTime(2023, 9, 9, 13, 50, 51, 791, DateTimeKind.Utc).AddTicks(4529) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 19L, new DateTime(2023, 6, 8, 17, 20, 27, 423, DateTimeKind.Utc).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 62L, new DateTime(2022, 4, 8, 3, 54, 7, 812, DateTimeKind.Utc).AddTicks(2460) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 29L, new DateTime(2021, 4, 12, 12, 51, 1, 557, DateTimeKind.Utc).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 37L, new DateTime(2023, 9, 10, 22, 54, 53, 526, DateTimeKind.Utc).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 64L, new DateTime(2022, 6, 25, 12, 59, 4, 101, DateTimeKind.Utc).AddTicks(8234) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 39L, new DateTime(2023, 7, 13, 3, 17, 25, 267, DateTimeKind.Utc).AddTicks(3554) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 20L, new DateTime(2023, 3, 27, 4, 40, 34, 544, DateTimeKind.Utc).AddTicks(2663) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 52L, new DateTime(2023, 5, 30, 11, 52, 27, 122, DateTimeKind.Utc).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 8L, new DateTime(2022, 11, 3, 9, 13, 40, 791, DateTimeKind.Utc).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 141L, new DateTime(2023, 5, 8, 7, 41, 20, 378, DateTimeKind.Utc).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 35L, new DateTime(2022, 7, 27, 10, 12, 5, 587, DateTimeKind.Utc).AddTicks(5040) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 49L, new DateTime(2023, 5, 21, 23, 41, 6, 193, DateTimeKind.Utc).AddTicks(6961) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 62L, new DateTime(2022, 4, 25, 15, 53, 43, 358, DateTimeKind.Utc).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 65L, new DateTime(2023, 4, 22, 15, 27, 11, 66, DateTimeKind.Utc).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 16L, new DateTime(2023, 5, 31, 11, 1, 48, 847, DateTimeKind.Utc).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 155L, new DateTime(2023, 9, 10, 4, 12, 52, 378, DateTimeKind.Utc).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 92L, new DateTime(2023, 9, 5, 19, 3, 21, 861, DateTimeKind.Utc).AddTicks(8187) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 15L, new DateTime(2022, 11, 7, 7, 58, 46, 58, DateTimeKind.Utc).AddTicks(1175) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 53L, new DateTime(2023, 7, 23, 7, 50, 56, 989, DateTimeKind.Utc).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 67L, new DateTime(2023, 9, 16, 4, 30, 13, 864, DateTimeKind.Utc).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 193L, new DateTime(2023, 7, 19, 0, 50, 3, 391, DateTimeKind.Utc).AddTicks(4242) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 23L, new DateTime(2023, 5, 28, 0, 20, 43, 726, DateTimeKind.Utc).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 150L, new DateTime(2021, 4, 16, 8, 44, 48, 745, DateTimeKind.Utc).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 26L, new DateTime(2023, 6, 24, 2, 25, 34, 740, DateTimeKind.Utc).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 30L, new DateTime(2023, 9, 4, 11, 13, 52, 219, DateTimeKind.Utc).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 45L, new DateTime(2023, 9, 8, 9, 20, 39, 266, DateTimeKind.Utc).AddTicks(1116) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 184L, new DateTime(2023, 8, 17, 20, 28, 29, 633, DateTimeKind.Utc).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 13L, new DateTime(2023, 8, 6, 18, 57, 43, 293, DateTimeKind.Utc).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 126L, new DateTime(2023, 4, 3, 5, 10, 50, 665, DateTimeKind.Utc).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 33L, new DateTime(2023, 8, 3, 10, 20, 52, 33, DateTimeKind.Utc).AddTicks(8661) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 94L, new DateTime(2023, 1, 27, 5, 39, 12, 426, DateTimeKind.Utc).AddTicks(5054) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 105L, new DateTime(2023, 9, 16, 15, 7, 26, 551, DateTimeKind.Utc).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 40L, new DateTime(2022, 7, 13, 2, 28, 23, 251, DateTimeKind.Utc).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 96L, new DateTime(2023, 9, 7, 7, 26, 5, 485, DateTimeKind.Utc).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 28L, new DateTime(2023, 5, 12, 0, 5, 40, 653, DateTimeKind.Utc).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 150L, new DateTime(2023, 4, 16, 15, 12, 27, 589, DateTimeKind.Utc).AddTicks(2676) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 116L, new DateTime(2023, 6, 8, 17, 54, 9, 318, DateTimeKind.Utc).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 173L, new DateTime(2023, 8, 6, 19, 51, 54, 853, DateTimeKind.Utc).AddTicks(4706) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 53L, new DateTime(2023, 1, 22, 19, 32, 42, 300, DateTimeKind.Utc).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 12L, new DateTime(2023, 9, 4, 23, 58, 17, 56, DateTimeKind.Utc).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 14, 20, 25, 55, 927, DateTimeKind.Utc).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 59L, new DateTime(2019, 6, 15, 20, 35, 2, 56, DateTimeKind.Utc).AddTicks(5652) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 10L, new DateTime(2022, 11, 25, 12, 9, 31, 150, DateTimeKind.Utc).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 35L, new DateTime(2021, 10, 13, 9, 52, 39, 173, DateTimeKind.Utc).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 141L, new DateTime(2021, 12, 24, 15, 15, 33, 313, DateTimeKind.Utc).AddTicks(4618) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 6L, new DateTime(2022, 12, 2, 12, 22, 48, 180, DateTimeKind.Utc).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 96L, new DateTime(2023, 5, 18, 2, 56, 38, 543, DateTimeKind.Utc).AddTicks(4135) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 105L, new DateTime(2023, 7, 26, 0, 24, 55, 614, DateTimeKind.Utc).AddTicks(9166) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 44L, new DateTime(2023, 7, 19, 17, 36, 23, 141, DateTimeKind.Utc).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 41L, new DateTime(2023, 9, 14, 5, 16, 3, 790, DateTimeKind.Utc).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 181L, new DateTime(2023, 7, 2, 20, 5, 38, 785, DateTimeKind.Utc).AddTicks(8197) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 89L, new DateTime(2023, 8, 10, 2, 22, 46, 865, DateTimeKind.Utc).AddTicks(3502) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 138L, new DateTime(2023, 8, 17, 12, 50, 54, 356, DateTimeKind.Utc).AddTicks(1959) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 76L, new DateTime(2022, 10, 11, 3, 7, 9, 564, DateTimeKind.Utc).AddTicks(5361) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 38L, new DateTime(2023, 5, 2, 6, 10, 23, 975, DateTimeKind.Utc).AddTicks(1921) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 26L, new DateTime(2022, 12, 25, 10, 24, 46, 193, DateTimeKind.Utc).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 2L, new DateTime(2023, 9, 13, 18, 41, 1, 217, DateTimeKind.Utc).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 162L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 46L, new DateTime(2021, 2, 21, 23, 26, 42, 960, DateTimeKind.Utc).AddTicks(2108) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 163L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 46L, new DateTime(2021, 3, 25, 9, 59, 24, 444, DateTimeKind.Utc).AddTicks(5532) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 164L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 137L, new DateTime(2023, 9, 15, 15, 3, 11, 682, DateTimeKind.Utc).AddTicks(7822) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 165L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 25L, new DateTime(2023, 9, 3, 8, 5, 53, 305, DateTimeKind.Utc).AddTicks(902) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 138L, new DateTime(2023, 9, 7, 0, 20, 37, 586, DateTimeKind.Utc).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 94L, new DateTime(2023, 9, 6, 2, 10, 1, 892, DateTimeKind.Utc).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 34L, new DateTime(2023, 9, 12, 5, 57, 40, 202, DateTimeKind.Utc).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 105L, new DateTime(2023, 3, 1, 19, 45, 11, 305, DateTimeKind.Utc).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 26L, new DateTime(2023, 3, 24, 23, 57, 54, 98, DateTimeKind.Utc).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 1L, new DateTime(2022, 4, 11, 2, 11, 41, 295, DateTimeKind.Utc).AddTicks(635) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 109L, new DateTime(2023, 8, 7, 1, 43, 3, 522, DateTimeKind.Utc).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 49L, new DateTime(2023, 7, 9, 14, 36, 10, 582, DateTimeKind.Utc).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 7L, new DateTime(2021, 3, 26, 21, 40, 26, 473, DateTimeKind.Utc).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 45L, new DateTime(2023, 7, 13, 2, 15, 40, 184, DateTimeKind.Utc).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 37L, new DateTime(2023, 8, 19, 3, 49, 0, 117, DateTimeKind.Utc).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 49L, new DateTime(2023, 8, 24, 2, 11, 49, 467, DateTimeKind.Utc).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 61L, new DateTime(2023, 6, 21, 9, 9, 48, 712, DateTimeKind.Utc).AddTicks(514) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 58L, new DateTime(2023, 8, 29, 16, 3, 45, 189, DateTimeKind.Utc).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 13L, new DateTime(2023, 9, 2, 6, 12, 14, 715, DateTimeKind.Utc).AddTicks(2249) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 106L, new DateTime(2023, 8, 29, 11, 43, 24, 524, DateTimeKind.Utc).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 52L, new DateTime(2023, 8, 11, 3, 33, 53, 574, DateTimeKind.Utc).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 81L, new DateTime(2023, 6, 9, 7, 6, 33, 316, DateTimeKind.Utc).AddTicks(5694) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 15L, new DateTime(2023, 6, 8, 19, 31, 34, 505, DateTimeKind.Utc).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 110L, new DateTime(2023, 4, 7, 9, 14, 13, 871, DateTimeKind.Utc).AddTicks(1001) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 155L, new DateTime(2023, 9, 9, 8, 35, 33, 634, DateTimeKind.Utc).AddTicks(5424) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 40L, new DateTime(2023, 5, 25, 12, 9, 44, 747, DateTimeKind.Utc).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 28L, new DateTime(2022, 11, 27, 18, 22, 46, 617, DateTimeKind.Utc).AddTicks(7559) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 33L, new DateTime(2023, 8, 22, 6, 19, 41, 491, DateTimeKind.Utc).AddTicks(9781) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 57L, new DateTime(2021, 11, 8, 10, 27, 9, 438, DateTimeKind.Utc).AddTicks(2322) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 24L, new DateTime(2023, 7, 18, 3, 45, 53, 373, DateTimeKind.Utc).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 22L, new DateTime(2023, 9, 7, 19, 7, 57, 967, DateTimeKind.Utc).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 150L, new DateTime(2023, 5, 21, 17, 30, 46, 458, DateTimeKind.Utc).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 62L, new DateTime(2022, 12, 3, 11, 33, 2, 333, DateTimeKind.Utc).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 90L, new DateTime(2023, 8, 18, 17, 27, 53, 27, DateTimeKind.Utc).AddTicks(4513) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 35L, new DateTime(2022, 8, 6, 20, 49, 45, 235, DateTimeKind.Utc).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 61L, new DateTime(2023, 4, 25, 4, 21, 4, 764, DateTimeKind.Utc).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 98L, new DateTime(2023, 8, 26, 20, 58, 41, 141, DateTimeKind.Utc).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 89L, new DateTime(2022, 7, 27, 22, 33, 17, 396, DateTimeKind.Utc).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 83L, new DateTime(2023, 7, 8, 0, 19, 4, 938, DateTimeKind.Utc).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(1721), 18L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(1916), 14L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(1928), 20L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(1936), 40L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(1943), 23L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(1949), 40L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(1956), 32L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(1962), 9L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(1969), 2L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(1975), 6L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(1982), 32L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(1988), 2L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(1994), 13L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 11L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2000), 18L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2006), 9L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2013), 17L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2068), 12L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2077), 38L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2083), 14L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 12L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2089), 26L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2095), 29L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2101), 25L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2107), 26L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2114), 1L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2121), 22L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2127), 35L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2133), 14L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2139), 38L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2145), 22L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2151), 2L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2157), 13L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2163), 30L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2169), 37L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2175), 35L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2182), 31L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2188), 17L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2194), 38L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2200), 12L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 12L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2206), 19L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2212), 37L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2218), 26L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2224), 6L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2230), 40L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2236), 8L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2268), 35L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2276), 16L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2283), 15L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2289), 9L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2295), 18L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2301), 12L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2307), 17L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2313), 6L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2319), 13L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2325), 15L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 11L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2331), 9L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2337), 32L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2343), 15L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2349), 16L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2356), 4L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2362), 18L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 11L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2368), 32L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2374), 6L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2380), 4L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2386), 34L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2392), 18L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2398), 40L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 11L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2404), 34L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2410), 35L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2416), 35L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2422), 17L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2428), 28L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2434), 12L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2481), 39L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2489), 14L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2495), 38L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 12L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2501), 22L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2507), 29L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2513), 18L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2519), 10L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2023, 9, 19, 22, 44, 55, 850, DateTimeKind.Local).AddTicks(2525), 9L });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 117L, new DateTime(2023, 8, 24, 10, 40, 11, 407, DateTimeKind.Utc).AddTicks(2394), new DateTime(2023, 9, 18, 6, 49, 41, 28, DateTimeKind.Utc).AddTicks(2459) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 35L, new DateTime(2022, 9, 19, 13, 39, 33, 162, DateTimeKind.Utc).AddTicks(2620), new DateTime(2023, 4, 22, 14, 52, 22, 489, DateTimeKind.Utc).AddTicks(729) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 60L, new DateTime(2023, 8, 14, 22, 18, 36, 823, DateTimeKind.Utc).AddTicks(5202), new DateTime(2023, 9, 18, 11, 19, 16, 799, DateTimeKind.Utc).AddTicks(9349) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 157L, new DateTime(2023, 5, 4, 16, 29, 44, 99, DateTimeKind.Utc).AddTicks(3631), new DateTime(2023, 6, 5, 9, 4, 56, 157, DateTimeKind.Utc).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 49L, new DateTime(2023, 5, 31, 12, 45, 55, 766, DateTimeKind.Utc).AddTicks(4687), new DateTime(2023, 9, 10, 14, 21, 42, 388, DateTimeKind.Utc).AddTicks(7825) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 172L, new DateTime(2023, 4, 30, 6, 31, 51, 538, DateTimeKind.Utc).AddTicks(829), new DateTime(2023, 5, 2, 20, 38, 23, 3, DateTimeKind.Utc).AddTicks(6337) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 37L, new DateTime(2023, 9, 3, 16, 39, 19, 427, DateTimeKind.Utc).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 13L, new DateTime(2023, 8, 22, 1, 57, 55, 140, DateTimeKind.Utc).AddTicks(706), new DateTime(2023, 9, 14, 4, 10, 44, 537, DateTimeKind.Utc).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 47L, new DateTime(2023, 6, 4, 20, 58, 11, 629, DateTimeKind.Utc).AddTicks(631), new DateTime(2023, 8, 14, 11, 36, 56, 924, DateTimeKind.Utc).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 2L, new DateTime(2023, 9, 12, 20, 20, 10, 566, DateTimeKind.Utc).AddTicks(7942), new DateTime(2023, 9, 14, 19, 2, 40, 875, DateTimeKind.Utc).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 98L, new DateTime(2023, 1, 4, 15, 18, 0, 823, DateTimeKind.Utc).AddTicks(8300), new DateTime(2023, 1, 14, 23, 28, 52, 651, DateTimeKind.Utc).AddTicks(8031) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 35L, new DateTime(2022, 11, 11, 23, 14, 41, 960, DateTimeKind.Utc).AddTicks(864), new DateTime(2023, 4, 20, 10, 33, 59, 455, DateTimeKind.Utc).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 61L, new DateTime(2023, 6, 18, 3, 8, 26, 478, DateTimeKind.Utc).AddTicks(4741), new DateTime(2023, 9, 6, 9, 16, 41, 441, DateTimeKind.Utc).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 38L, new DateTime(2023, 8, 16, 16, 13, 56, 420, DateTimeKind.Utc).AddTicks(8804), new DateTime(2023, 9, 8, 22, 36, 36, 137, DateTimeKind.Utc).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 9L, new DateTime(2023, 2, 23, 9, 42, 29, 3, DateTimeKind.Utc).AddTicks(2230), new DateTime(2023, 3, 14, 12, 0, 36, 807, DateTimeKind.Utc).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 81L, new DateTime(2023, 8, 26, 10, 12, 40, 701, DateTimeKind.Utc).AddTicks(3282), new DateTime(2023, 8, 28, 7, 43, 57, 415, DateTimeKind.Utc).AddTicks(7474) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 22L, new DateTime(2023, 9, 4, 2, 57, 59, 162, DateTimeKind.Utc).AddTicks(7551), new DateTime(2023, 9, 12, 16, 49, 5, 396, DateTimeKind.Utc).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 167L, new DateTime(2023, 8, 3, 5, 9, 21, 738, DateTimeKind.Utc).AddTicks(8390), new DateTime(2023, 8, 13, 13, 5, 9, 127, DateTimeKind.Utc).AddTicks(8854) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 116L, new DateTime(2022, 10, 11, 7, 47, 3, 286, DateTimeKind.Utc).AddTicks(3), new DateTime(2023, 6, 22, 2, 11, 28, 999, DateTimeKind.Utc).AddTicks(7180) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 61L, new DateTime(2023, 8, 18, 21, 0, 38, 960, DateTimeKind.Utc).AddTicks(6549), new DateTime(2023, 9, 12, 13, 48, 10, 998, DateTimeKind.Utc).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 17L, new DateTime(2023, 9, 19, 21, 36, 56, 960, DateTimeKind.Utc).AddTicks(4548), new DateTime(2023, 9, 19, 21, 44, 26, 264, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 27L, new DateTime(2023, 6, 6, 0, 56, 9, 910, DateTimeKind.Utc).AddTicks(7468), new DateTime(2023, 9, 10, 11, 7, 28, 614, DateTimeKind.Utc).AddTicks(6493) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 37L, new DateTime(2023, 8, 26, 22, 22, 12, 754, DateTimeKind.Utc).AddTicks(6065), new DateTime(2023, 9, 2, 6, 30, 46, 552, DateTimeKind.Utc).AddTicks(2114) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 89L, new DateTime(2023, 6, 25, 20, 40, 34, 345, DateTimeKind.Utc).AddTicks(1731), new DateTime(2023, 9, 19, 19, 29, 37, 379, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 59L, new DateTime(2021, 1, 12, 16, 29, 56, 474, DateTimeKind.Utc).AddTicks(9740), new DateTime(2021, 4, 29, 2, 33, 24, 948, DateTimeKind.Utc).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 96L, new DateTime(2023, 1, 3, 12, 47, 25, 375, DateTimeKind.Utc).AddTicks(5479), new DateTime(2023, 2, 25, 17, 3, 37, 874, DateTimeKind.Utc).AddTicks(7825) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 42L, new DateTime(2023, 9, 13, 9, 23, 21, 51, DateTimeKind.Utc).AddTicks(9538), new DateTime(2023, 9, 13, 20, 32, 58, 374, DateTimeKind.Utc).AddTicks(7684) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 72L, new DateTime(2023, 9, 13, 7, 17, 28, 953, DateTimeKind.Utc).AddTicks(9907), new DateTime(2023, 9, 13, 10, 7, 52, 922, DateTimeKind.Utc).AddTicks(2062) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 20L, new DateTime(2023, 8, 11, 21, 3, 54, 150, DateTimeKind.Utc).AddTicks(7529), new DateTime(2023, 9, 15, 12, 32, 4, 572, DateTimeKind.Utc).AddTicks(6812) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 94L, new DateTime(2023, 9, 14, 18, 47, 35, 843, DateTimeKind.Utc).AddTicks(8039), new DateTime(2023, 9, 15, 22, 44, 16, 10, DateTimeKind.Utc).AddTicks(9658) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 3L, new DateTime(2023, 4, 24, 15, 48, 35, 949, DateTimeKind.Utc).AddTicks(8035), new DateTime(2023, 5, 25, 22, 25, 34, 601, DateTimeKind.Utc).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 140L, new DateTime(2023, 8, 16, 18, 50, 18, 658, DateTimeKind.Utc).AddTicks(6510), new DateTime(2023, 8, 18, 12, 10, 43, 281, DateTimeKind.Utc).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 167L, new DateTime(2023, 8, 29, 13, 48, 26, 347, DateTimeKind.Utc).AddTicks(4533), new DateTime(2023, 9, 7, 19, 33, 35, 681, DateTimeKind.Utc).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 95L, new DateTime(2023, 8, 18, 3, 41, 15, 179, DateTimeKind.Utc).AddTicks(470), new DateTime(2023, 9, 8, 10, 7, 9, 923, DateTimeKind.Utc).AddTicks(8291) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 76L, new DateTime(2023, 1, 16, 6, 40, 47, 210, DateTimeKind.Utc).AddTicks(4834), new DateTime(2023, 4, 21, 20, 30, 41, 550, DateTimeKind.Utc).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 43L, new DateTime(2023, 1, 31, 0, 6, 43, 598, DateTimeKind.Utc).AddTicks(4488), new DateTime(2023, 6, 26, 20, 3, 18, 728, DateTimeKind.Utc).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 23L, new DateTime(2023, 7, 24, 7, 27, 26, 844, DateTimeKind.Utc).AddTicks(3093), new DateTime(2023, 7, 27, 4, 47, 6, 936, DateTimeKind.Utc).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 16L, new DateTime(2023, 5, 16, 20, 46, 9, 133, DateTimeKind.Utc).AddTicks(1338), new DateTime(2023, 9, 4, 12, 12, 19, 360, DateTimeKind.Utc).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 157L, new DateTime(2023, 5, 19, 4, 19, 19, 960, DateTimeKind.Utc).AddTicks(1386), new DateTime(2023, 7, 1, 18, 5, 11, 794, DateTimeKind.Utc).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 24L, new DateTime(2023, 6, 22, 17, 9, 53, 227, DateTimeKind.Utc).AddTicks(2969), new DateTime(2023, 8, 4, 5, 16, 31, 10, DateTimeKind.Utc).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 177L, new DateTime(2023, 2, 3, 18, 39, 42, 422, DateTimeKind.Utc).AddTicks(9327), new DateTime(2023, 5, 2, 15, 44, 43, 900, DateTimeKind.Utc).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 117L, new DateTime(2023, 8, 22, 12, 6, 22, 232, DateTimeKind.Utc).AddTicks(342), new DateTime(2023, 8, 31, 9, 42, 5, 184, DateTimeKind.Utc).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 60L, new DateTime(2023, 8, 21, 8, 10, 0, 217, DateTimeKind.Utc).AddTicks(7855), new DateTime(2023, 9, 16, 18, 10, 23, 875, DateTimeKind.Utc).AddTicks(6134) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 83L, new DateTime(2023, 5, 16, 22, 56, 9, 890, DateTimeKind.Utc).AddTicks(3825), new DateTime(2023, 7, 30, 4, 35, 55, 331, DateTimeKind.Utc).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 52L, new DateTime(2023, 4, 9, 4, 4, 34, 39, DateTimeKind.Utc).AddTicks(2944), new DateTime(2023, 5, 25, 2, 13, 13, 559, DateTimeKind.Utc).AddTicks(7237) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 38L, new DateTime(2023, 6, 28, 11, 14, 48, 196, DateTimeKind.Utc).AddTicks(5477), new DateTime(2023, 8, 11, 13, 48, 36, 69, DateTimeKind.Utc).AddTicks(9381) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 167L, new DateTime(2023, 6, 5, 22, 12, 2, 726, DateTimeKind.Utc).AddTicks(9791), new DateTime(2023, 8, 14, 1, 45, 35, 715, DateTimeKind.Utc).AddTicks(7422) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 47L, new DateTime(2023, 8, 9, 13, 59, 0, 903, DateTimeKind.Utc).AddTicks(5983), new DateTime(2023, 9, 18, 11, 36, 15, 734, DateTimeKind.Utc).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 76L, new DateTime(2022, 10, 21, 22, 53, 56, 670, DateTimeKind.Utc).AddTicks(4242), new DateTime(2023, 1, 23, 23, 23, 49, 478, DateTimeKind.Utc).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 184L, new DateTime(2023, 8, 21, 10, 33, 56, 180, DateTimeKind.Utc).AddTicks(3871) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 25L, new DateTime(2023, 8, 19, 22, 9, 25, 833, DateTimeKind.Utc).AddTicks(7418), new DateTime(2023, 8, 29, 13, 31, 31, 35, DateTimeKind.Utc).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 91L, new DateTime(2023, 5, 27, 19, 33, 7, 580, DateTimeKind.Utc).AddTicks(7034), new DateTime(2023, 9, 13, 19, 3, 38, 756, DateTimeKind.Utc).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 66L, new DateTime(2023, 4, 8, 3, 51, 22, 927, DateTimeKind.Utc).AddTicks(8592), new DateTime(2023, 7, 8, 19, 26, 11, 552, DateTimeKind.Utc).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 84L, new DateTime(2023, 9, 9, 0, 42, 39, 460, DateTimeKind.Utc).AddTicks(1157) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 105L, new DateTime(2023, 4, 16, 8, 32, 5, 482, DateTimeKind.Utc).AddTicks(7676), new DateTime(2023, 5, 3, 1, 41, 10, 516, DateTimeKind.Utc).AddTicks(2352) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 148L, new DateTime(2023, 2, 5, 4, 33, 16, 277, DateTimeKind.Utc).AddTicks(8214), new DateTime(2023, 7, 3, 9, 16, 55, 263, DateTimeKind.Utc).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 141L, new DateTime(2022, 12, 6, 14, 13, 35, 26, DateTimeKind.Utc).AddTicks(7969), new DateTime(2022, 12, 16, 20, 19, 24, 962, DateTimeKind.Utc).AddTicks(9326) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 43L, new DateTime(2023, 7, 17, 10, 30, 14, 966, DateTimeKind.Utc).AddTicks(982), new DateTime(2023, 8, 9, 10, 41, 34, 318, DateTimeKind.Utc).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 89L, new DateTime(2022, 8, 19, 2, 50, 12, 394, DateTimeKind.Utc).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 41L, new DateTime(2023, 9, 8, 16, 4, 39, 451, DateTimeKind.Utc).AddTicks(4227), new DateTime(2023, 9, 10, 9, 15, 51, 122, DateTimeKind.Utc).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 181L, new DateTime(2023, 5, 7, 17, 48, 59, 728, DateTimeKind.Utc).AddTicks(1686), new DateTime(2023, 8, 26, 3, 14, 33, 187, DateTimeKind.Utc).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 108L, new DateTime(2023, 8, 10, 0, 4, 31, 896, DateTimeKind.Utc).AddTicks(5618), new DateTime(2023, 9, 2, 22, 58, 41, 839, DateTimeKind.Utc).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 9L, new DateTime(2022, 8, 16, 6, 37, 57, 523, DateTimeKind.Utc).AddTicks(2466), new DateTime(2023, 7, 27, 1, 17, 3, 623, DateTimeKind.Utc).AddTicks(3662) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 140L, new DateTime(2023, 8, 23, 21, 51, 25, 867, DateTimeKind.Utc).AddTicks(6491), new DateTime(2023, 9, 8, 22, 15, 11, 9, DateTimeKind.Utc).AddTicks(54) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 193L, new DateTime(2023, 6, 2, 3, 7, 18, 82, DateTimeKind.Utc).AddTicks(9783), new DateTime(2023, 6, 10, 23, 4, 3, 879, DateTimeKind.Utc).AddTicks(8575) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 110L, new DateTime(2022, 3, 2, 9, 37, 43, 257, DateTimeKind.Utc).AddTicks(4559) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 44L, new DateTime(2023, 4, 16, 9, 30, 49, 819, DateTimeKind.Utc).AddTicks(1450), new DateTime(2023, 6, 9, 4, 53, 6, 603, DateTimeKind.Utc).AddTicks(8813) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 122L, new DateTime(2023, 7, 11, 21, 16, 34, 293, DateTimeKind.Utc).AddTicks(3750), new DateTime(2023, 7, 20, 22, 25, 36, 907, DateTimeKind.Utc).AddTicks(8156) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 132L, new DateTime(2021, 10, 14, 18, 40, 37, 933, DateTimeKind.Utc).AddTicks(4503), new DateTime(2022, 10, 14, 17, 20, 23, 873, DateTimeKind.Utc).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 19L, new DateTime(2022, 12, 5, 19, 51, 19, 303, DateTimeKind.Utc).AddTicks(6465), new DateTime(2023, 1, 4, 18, 19, 45, 252, DateTimeKind.Utc).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 128L, new DateTime(2023, 9, 7, 21, 47, 59, 804, DateTimeKind.Utc).AddTicks(4976), new DateTime(2023, 9, 19, 5, 54, 45, 8, DateTimeKind.Utc).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 72L, new DateTime(2023, 8, 26, 13, 40, 51, 575, DateTimeKind.Utc).AddTicks(4991), new DateTime(2023, 8, 28, 12, 54, 11, 144, DateTimeKind.Utc).AddTicks(5429) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 33L, new DateTime(2022, 12, 23, 9, 8, 32, 273, DateTimeKind.Utc).AddTicks(5597), new DateTime(2023, 7, 10, 10, 8, 36, 369, DateTimeKind.Utc).AddTicks(4308) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 52L, new DateTime(2023, 5, 17, 0, 53, 25, 424, DateTimeKind.Utc).AddTicks(4410), new DateTime(2023, 8, 27, 11, 30, 1, 789, DateTimeKind.Utc).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 105L, new DateTime(2022, 12, 4, 21, 22, 3, 471, DateTimeKind.Utc).AddTicks(2754), new DateTime(2023, 2, 10, 14, 26, 47, 987, DateTimeKind.Utc).AddTicks(1313) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 24L, new DateTime(2023, 6, 11, 18, 40, 28, 567, DateTimeKind.Utc).AddTicks(443), new DateTime(2023, 7, 6, 12, 52, 48, 772, DateTimeKind.Utc).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 65L, new DateTime(2022, 12, 3, 12, 0, 24, 423, DateTimeKind.Utc).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 115L, new DateTime(2022, 8, 15, 7, 32, 14, 962, DateTimeKind.Utc).AddTicks(3424) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 132L, new DateTime(2023, 6, 2, 1, 40, 10, 105, DateTimeKind.Utc).AddTicks(5486), new DateTime(2023, 7, 13, 22, 47, 4, 22, DateTimeKind.Utc).AddTicks(2086) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 76L, new DateTime(2023, 1, 13, 18, 24, 7, 438, DateTimeKind.Utc).AddTicks(2534), new DateTime(2023, 6, 30, 19, 52, 5, 12, DateTimeKind.Utc).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 42L, new DateTime(2023, 9, 9, 3, 57, 41, 119, DateTimeKind.Utc).AddTicks(9734), new DateTime(2023, 9, 16, 16, 12, 20, 501, DateTimeKind.Utc).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 21L, new DateTime(2023, 9, 13, 11, 27, 9, 268, DateTimeKind.Utc).AddTicks(1939), new DateTime(2023, 9, 13, 21, 8, 6, 77, DateTimeKind.Utc).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 115L, new DateTime(2022, 7, 28, 17, 37, 4, 961, DateTimeKind.Utc).AddTicks(1421), new DateTime(2023, 4, 23, 17, 18, 37, 679, DateTimeKind.Utc).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 59L, new DateTime(2020, 8, 10, 20, 52, 2, 287, DateTimeKind.Utc).AddTicks(7945), new DateTime(2022, 7, 4, 9, 50, 29, 36, DateTimeKind.Utc).AddTicks(7041) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 84L, new DateTime(2023, 8, 11, 8, 32, 44, 741, DateTimeKind.Utc).AddTicks(6823), new DateTime(2023, 9, 16, 3, 38, 47, 759, DateTimeKind.Utc).AddTicks(4407) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 43L, new DateTime(2022, 7, 7, 14, 41, 6, 130, DateTimeKind.Utc).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 60L, new DateTime(2023, 9, 10, 11, 30, 4, 570, DateTimeKind.Utc).AddTicks(4671), new DateTime(2023, 9, 13, 5, 35, 40, 627, DateTimeKind.Utc).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 45L, new DateTime(2023, 1, 7, 16, 7, 54, 434, DateTimeKind.Utc).AddTicks(4883), new DateTime(2023, 4, 13, 12, 59, 4, 568, DateTimeKind.Utc).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 181L, new DateTime(2023, 5, 4, 2, 43, 22, 331, DateTimeKind.Utc).AddTicks(963), new DateTime(2023, 9, 7, 22, 59, 59, 630, DateTimeKind.Utc).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 37L, new DateTime(2023, 9, 15, 17, 19, 30, 183, DateTimeKind.Utc).AddTicks(4732), new DateTime(2023, 9, 19, 11, 5, 2, 98, DateTimeKind.Utc).AddTicks(4732) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 26L, new DateTime(2023, 6, 20, 8, 15, 29, 249, DateTimeKind.Utc).AddTicks(9869), new DateTime(2023, 7, 17, 15, 38, 45, 126, DateTimeKind.Utc).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 89L, new DateTime(2023, 3, 9, 21, 43, 28, 87, DateTimeKind.Utc).AddTicks(6187) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 67L, new DateTime(2023, 9, 18, 21, 33, 13, 432, DateTimeKind.Utc).AddTicks(6811), new DateTime(2023, 9, 19, 4, 8, 42, 430, DateTimeKind.Utc).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 79L, new DateTime(2023, 8, 12, 17, 23, 11, 380, DateTimeKind.Utc).AddTicks(6397), new DateTime(2023, 9, 12, 8, 14, 26, 507, DateTimeKind.Utc).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 128L, new DateTime(2023, 9, 11, 15, 12, 48, 99, DateTimeKind.Utc).AddTicks(1075), new DateTime(2023, 9, 15, 2, 52, 46, 637, DateTimeKind.Utc).AddTicks(713) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 137L, new DateTime(2023, 8, 21, 21, 39, 28, 23, DateTimeKind.Utc).AddTicks(7458), new DateTime(2023, 9, 10, 17, 10, 11, 444, DateTimeKind.Utc).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 72L, new DateTime(2023, 9, 11, 11, 5, 40, 568, DateTimeKind.Utc).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 16L, new DateTime(2023, 6, 30, 5, 56, 39, 683, DateTimeKind.Utc).AddTicks(4783), new DateTime(2023, 7, 1, 16, 4, 3, 997, DateTimeKind.Utc).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 173L, new DateTime(2023, 5, 18, 8, 24, 48, 791, DateTimeKind.Utc).AddTicks(4259), new DateTime(2023, 7, 30, 23, 55, 39, 799, DateTimeKind.Utc).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 67L, new DateTime(2023, 9, 19, 6, 10, 44, 835, DateTimeKind.Utc).AddTicks(7447), new DateTime(2023, 9, 19, 15, 30, 2, 237, DateTimeKind.Utc).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 50L, new DateTime(2022, 12, 15, 22, 54, 21, 520, DateTimeKind.Utc).AddTicks(94), new DateTime(2023, 5, 14, 3, 27, 48, 848, DateTimeKind.Utc).AddTicks(1312) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 148L, new DateTime(2021, 5, 16, 0, 23, 6, 439, DateTimeKind.Utc).AddTicks(9031), new DateTime(2022, 9, 24, 2, 38, 31, 579, DateTimeKind.Utc).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 63L, new DateTime(2023, 5, 13, 11, 20, 48, 601, DateTimeKind.Utc).AddTicks(127), new DateTime(2023, 9, 1, 5, 11, 51, 552, DateTimeKind.Utc).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 116L, new DateTime(2022, 8, 1, 23, 21, 38, 810, DateTimeKind.Utc).AddTicks(6559), new DateTime(2023, 3, 10, 15, 28, 26, 768, DateTimeKind.Utc).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 47L, new DateTime(2023, 5, 19, 13, 37, 7, 212, DateTimeKind.Utc).AddTicks(1974), new DateTime(2023, 9, 19, 19, 3, 47, 130, DateTimeKind.Utc).AddTicks(3196) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 65L, new DateTime(2022, 11, 18, 2, 9, 26, 87, DateTimeKind.Utc).AddTicks(8223), new DateTime(2023, 4, 12, 1, 32, 54, 753, DateTimeKind.Utc).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 57L, new DateTime(2022, 2, 19, 2, 26, 19, 586, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 141L, new DateTime(2023, 7, 6, 15, 3, 35, 303, DateTimeKind.Utc).AddTicks(6929), new DateTime(2023, 8, 23, 21, 27, 27, 125, DateTimeKind.Utc).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 20L, new DateTime(2023, 8, 19, 6, 3, 21, 620, DateTimeKind.Utc).AddTicks(4930), new DateTime(2023, 9, 10, 5, 57, 39, 927, DateTimeKind.Utc).AddTicks(86) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 22L, new DateTime(2023, 9, 16, 20, 34, 12, 658, DateTimeKind.Utc).AddTicks(2241), new DateTime(2023, 9, 19, 1, 45, 15, 159, DateTimeKind.Utc).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 89L, new DateTime(2022, 9, 3, 20, 29, 24, 543, DateTimeKind.Utc).AddTicks(884) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 47L, new DateTime(2023, 8, 2, 13, 4, 46, 713, DateTimeKind.Utc).AddTicks(3868), new DateTime(2023, 8, 7, 8, 17, 35, 938, DateTimeKind.Utc).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 27L, new DateTime(2023, 3, 24, 11, 56, 50, 677, DateTimeKind.Utc).AddTicks(3932), new DateTime(2023, 7, 9, 5, 29, 57, 765, DateTimeKind.Utc).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 108L, new DateTime(2023, 8, 31, 22, 26, 32, 76, DateTimeKind.Utc).AddTicks(9756), new DateTime(2023, 9, 7, 5, 10, 50, 585, DateTimeKind.Utc).AddTicks(6176) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 40L, new DateTime(2022, 8, 29, 21, 54, 37, 149, DateTimeKind.Utc).AddTicks(4794), new DateTime(2023, 4, 5, 15, 47, 34, 253, DateTimeKind.Utc).AddTicks(1846) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 73L, new DateTime(2022, 6, 3, 13, 15, 34, 345, DateTimeKind.Utc).AddTicks(5387) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 126L, new DateTime(2023, 1, 21, 18, 18, 32, 443, DateTimeKind.Utc).AddTicks(9409), new DateTime(2023, 3, 23, 7, 14, 40, 506, DateTimeKind.Utc).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 43L, new DateTime(2023, 2, 25, 19, 55, 39, 407, DateTimeKind.Utc).AddTicks(3611), new DateTime(2023, 3, 23, 10, 7, 47, 806, DateTimeKind.Utc).AddTicks(6444) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 38L, new DateTime(2023, 6, 15, 15, 27, 58, 423, DateTimeKind.Utc).AddTicks(4655), new DateTime(2023, 9, 15, 22, 9, 51, 990, DateTimeKind.Utc).AddTicks(5579) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 17L, new DateTime(2023, 9, 19, 15, 50, 45, 653, DateTimeKind.Utc).AddTicks(4919), new DateTime(2023, 9, 19, 17, 37, 57, 182, DateTimeKind.Utc).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 7L, new DateTime(2019, 10, 25, 3, 50, 57, 490, DateTimeKind.Utc).AddTicks(1991) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 37L, new DateTime(2023, 9, 11, 20, 16, 20, 96, DateTimeKind.Utc).AddTicks(5623), new DateTime(2023, 9, 17, 8, 58, 29, 895, DateTimeKind.Utc).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 23L, new DateTime(2023, 7, 29, 0, 14, 54, 558, DateTimeKind.Utc).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 95L, new DateTime(2023, 8, 17, 12, 58, 58, 294, DateTimeKind.Utc).AddTicks(5984), new DateTime(2023, 8, 18, 1, 53, 41, 705, DateTimeKind.Utc).AddTicks(1415) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 16L, new DateTime(2023, 6, 1, 20, 41, 47, 747, DateTimeKind.Utc).AddTicks(6492), new DateTime(2023, 8, 18, 15, 52, 6, 679, DateTimeKind.Utc).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 177L, new DateTime(2023, 1, 31, 4, 17, 19, 298, DateTimeKind.Utc).AddTicks(2102), new DateTime(2023, 5, 24, 3, 59, 11, 122, DateTimeKind.Utc).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 12L, new DateTime(2023, 8, 31, 15, 21, 54, 92, DateTimeKind.Utc).AddTicks(852), new DateTime(2023, 9, 17, 14, 23, 6, 925, DateTimeKind.Utc).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 45L, new DateTime(2022, 11, 13, 9, 8, 46, 1, DateTimeKind.Utc).AddTicks(7846), new DateTime(2023, 5, 16, 11, 0, 30, 25, DateTimeKind.Utc).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 93L, new DateTime(2023, 7, 15, 16, 24, 51, 395, DateTimeKind.Utc).AddTicks(5988), new DateTime(2023, 7, 17, 18, 6, 2, 599, DateTimeKind.Utc).AddTicks(7433) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 25L, new DateTime(2023, 8, 22, 7, 14, 52, 338, DateTimeKind.Utc).AddTicks(2719), new DateTime(2023, 8, 22, 15, 28, 49, 96, DateTimeKind.Utc).AddTicks(1505) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 34L, new DateTime(2023, 9, 7, 19, 26, 7, 180, DateTimeKind.Utc).AddTicks(4255), new DateTime(2023, 9, 15, 20, 43, 8, 920, DateTimeKind.Utc).AddTicks(8527) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 193L, new DateTime(2023, 6, 2, 14, 44, 4, 792, DateTimeKind.Utc).AddTicks(8440), new DateTime(2023, 8, 13, 9, 6, 24, 916, DateTimeKind.Utc).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 29L, new DateTime(2020, 9, 20, 20, 42, 16, 325, DateTimeKind.Utc).AddTicks(5487), new DateTime(2023, 4, 6, 14, 42, 47, 623, DateTimeKind.Utc).AddTicks(1289) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 6L, new DateTime(2023, 6, 28, 2, 7, 57, 858, DateTimeKind.Utc).AddTicks(9778), new DateTime(2023, 7, 23, 17, 19, 38, 56, DateTimeKind.Utc).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 20L, new DateTime(2023, 6, 28, 6, 40, 45, 227, DateTimeKind.Utc).AddTicks(2998), new DateTime(2023, 8, 5, 8, 48, 10, 441, DateTimeKind.Utc).AddTicks(6403) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 7L, new DateTime(2019, 2, 27, 23, 31, 34, 518, DateTimeKind.Utc).AddTicks(2656), new DateTime(2019, 8, 7, 7, 29, 28, 330, DateTimeKind.Utc).AddTicks(8485) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 42L, new DateTime(2023, 9, 17, 5, 4, 18, 206, DateTimeKind.Utc).AddTicks(3461), new DateTime(2023, 9, 18, 5, 14, 15, 948, DateTimeKind.Utc).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 84L, new DateTime(2023, 9, 10, 14, 33, 24, 37, DateTimeKind.Utc).AddTicks(4635), new DateTime(2023, 9, 13, 5, 17, 54, 144, DateTimeKind.Utc).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 27L, new DateTime(2023, 2, 19, 0, 10, 51, 127, DateTimeKind.Utc).AddTicks(2260), new DateTime(2023, 7, 10, 23, 23, 54, 135, DateTimeKind.Utc).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 173L, new DateTime(2023, 4, 9, 3, 48, 16, 25, DateTimeKind.Utc).AddTicks(985), new DateTime(2023, 5, 14, 3, 17, 7, 668, DateTimeKind.Utc).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 167L, new DateTime(2023, 7, 5, 9, 55, 33, 333, DateTimeKind.Utc).AddTicks(1585), new DateTime(2023, 8, 20, 13, 23, 23, 694, DateTimeKind.Utc).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 129L, new DateTime(2023, 5, 14, 21, 52, 14, 671, DateTimeKind.Utc).AddTicks(8730), new DateTime(2023, 8, 12, 0, 13, 28, 767, DateTimeKind.Utc).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 57L, new DateTime(2022, 10, 16, 4, 35, 38, 366, DateTimeKind.Utc).AddTicks(2204), new DateTime(2023, 6, 19, 16, 2, 56, 645, DateTimeKind.Utc).AddTicks(4083) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 141L, new DateTime(2022, 7, 8, 11, 40, 45, 664, DateTimeKind.Utc).AddTicks(9220), new DateTime(2023, 4, 23, 5, 19, 51, 955, DateTimeKind.Utc).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 184L, new DateTime(2023, 8, 16, 5, 47, 3, 880, DateTimeKind.Utc).AddTicks(6017), new DateTime(2023, 9, 15, 20, 46, 42, 675, DateTimeKind.Utc).AddTicks(4419) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 137L, new DateTime(2023, 8, 16, 5, 44, 12, 277, DateTimeKind.Utc).AddTicks(9254), new DateTime(2023, 9, 11, 15, 46, 6, 871, DateTimeKind.Utc).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 7L, new DateTime(2020, 6, 23, 7, 47, 59, 723, DateTimeKind.Utc).AddTicks(4443), new DateTime(2021, 7, 17, 18, 23, 42, 512, DateTimeKind.Utc).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 17L, new DateTime(2023, 9, 19, 18, 6, 1, 616, DateTimeKind.Utc).AddTicks(2018), new DateTime(2023, 9, 19, 19, 42, 39, 592, DateTimeKind.Utc).AddTicks(4798) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 35L, new DateTime(2022, 6, 16, 17, 40, 7, 412, DateTimeKind.Utc).AddTicks(3948), new DateTime(2022, 11, 8, 20, 59, 34, 319, DateTimeKind.Utc).AddTicks(4084) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 61L, new DateTime(2023, 6, 6, 21, 2, 32, 98, DateTimeKind.Utc).AddTicks(2214), new DateTime(2023, 8, 24, 21, 9, 17, 696, DateTimeKind.Utc).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 59L, new DateTime(2022, 4, 9, 10, 14, 28, 909, DateTimeKind.Utc).AddTicks(7352), new DateTime(2022, 7, 29, 13, 24, 13, 789, DateTimeKind.Utc).AddTicks(6379) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 50L, new DateTime(2023, 2, 24, 6, 9, 24, 594, DateTimeKind.Utc).AddTicks(2145), new DateTime(2023, 3, 16, 5, 6, 28, 784, DateTimeKind.Utc).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 17L, new DateTime(2023, 9, 19, 20, 29, 5, 353, DateTimeKind.Utc).AddTicks(5130), new DateTime(2023, 9, 19, 20, 52, 1, 883, DateTimeKind.Utc).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 66L, new DateTime(2023, 5, 10, 18, 18, 29, 23, DateTimeKind.Utc).AddTicks(8240), new DateTime(2023, 5, 11, 3, 45, 36, 431, DateTimeKind.Utc).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 39L, new DateTime(2023, 5, 11, 3, 13, 17, 281, DateTimeKind.Utc).AddTicks(9388), new DateTime(2023, 6, 1, 6, 28, 29, 19, DateTimeKind.Utc).AddTicks(2748) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 193L, new DateTime(2023, 7, 11, 23, 3, 6, 284, DateTimeKind.Utc).AddTicks(6135), new DateTime(2023, 8, 7, 22, 25, 25, 247, DateTimeKind.Utc).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 19L, new DateTime(2022, 12, 9, 22, 49, 18, 688, DateTimeKind.Utc).AddTicks(1491), new DateTime(2023, 4, 17, 10, 9, 30, 796, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 51L, new DateTime(2023, 5, 26, 11, 24, 56, 594, DateTimeKind.Utc).AddTicks(6321), new DateTime(2023, 6, 21, 8, 36, 39, 711, DateTimeKind.Utc).AddTicks(955) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 51L, new DateTime(2023, 8, 21, 22, 47, 40, 451, DateTimeKind.Utc).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 45L, new DateTime(2022, 8, 5, 20, 51, 47, 238, DateTimeKind.Utc).AddTicks(8248), new DateTime(2022, 10, 7, 12, 17, 36, 432, DateTimeKind.Utc).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 74L, new DateTime(2023, 9, 6, 17, 34, 37, 409, DateTimeKind.Utc).AddTicks(5160), new DateTime(2023, 9, 16, 14, 18, 48, 287, DateTimeKind.Utc).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 162L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 193L, new DateTime(2023, 5, 7, 11, 54, 16, 22, DateTimeKind.Utc).AddTicks(5034), new DateTime(2023, 8, 7, 13, 26, 6, 903, DateTimeKind.Utc).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 163L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 128L, new DateTime(2023, 9, 11, 17, 38, 18, 179, DateTimeKind.Utc).AddTicks(3579), new DateTime(2023, 9, 16, 0, 26, 51, 466, DateTimeKind.Utc).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 164L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 109L, new DateTime(2023, 9, 17, 16, 23, 54, 39, DateTimeKind.Utc).AddTicks(5761), new DateTime(2023, 9, 19, 5, 17, 25, 4, DateTimeKind.Utc).AddTicks(9717) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 165L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 193L, new DateTime(2023, 4, 8, 11, 16, 27, 431, DateTimeKind.Utc).AddTicks(6304), new DateTime(2023, 5, 6, 5, 44, 53, 754, DateTimeKind.Utc).AddTicks(361) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 172L, new DateTime(2023, 8, 21, 19, 5, 50, 48, DateTimeKind.Utc).AddTicks(3874), new DateTime(2023, 9, 11, 18, 58, 42, 659, DateTimeKind.Utc).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 3L, new DateTime(2023, 7, 8, 21, 47, 34, 663, DateTimeKind.Utc).AddTicks(781), new DateTime(2023, 8, 3, 6, 11, 32, 865, DateTimeKind.Utc).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 19L, new DateTime(2023, 7, 2, 18, 13, 51, 695, DateTimeKind.Utc).AddTicks(5400), new DateTime(2023, 8, 19, 19, 48, 9, 16, DateTimeKind.Utc).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 69L, new DateTime(2023, 6, 25, 0, 5, 19, 141, DateTimeKind.Utc).AddTicks(5643), new DateTime(2023, 9, 15, 19, 51, 47, 917, DateTimeKind.Utc).AddTicks(6714) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 20L, new DateTime(2023, 7, 27, 2, 43, 41, 228, DateTimeKind.Utc).AddTicks(9218), new DateTime(2023, 9, 1, 6, 49, 23, 574, DateTimeKind.Utc).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 115L, new DateTime(2023, 5, 28, 18, 41, 14, 902, DateTimeKind.Utc).AddTicks(775), new DateTime(2023, 7, 21, 17, 59, 4, 834, DateTimeKind.Utc).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 173L, new DateTime(2023, 8, 4, 17, 33, 53, 990, DateTimeKind.Utc).AddTicks(3630), new DateTime(2023, 8, 16, 1, 52, 22, 3, DateTimeKind.Utc).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 51L, new DateTime(2023, 5, 15, 15, 27, 42, 613, DateTimeKind.Utc).AddTicks(5604), new DateTime(2023, 6, 7, 0, 0, 13, 681, DateTimeKind.Utc).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 13L, new DateTime(2023, 8, 2, 9, 19, 44, 438, DateTimeKind.Utc).AddTicks(7655), new DateTime(2023, 9, 7, 18, 44, 17, 38, DateTimeKind.Utc).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 2L, new DateTime(2023, 9, 11, 17, 56, 22, 667, DateTimeKind.Utc).AddTicks(9645), new DateTime(2023, 9, 17, 16, 19, 2, 370, DateTimeKind.Utc).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 32L, new DateTime(2023, 7, 11, 22, 50, 32, 377, DateTimeKind.Utc).AddTicks(2150), new DateTime(2023, 9, 9, 3, 38, 10, 662, DateTimeKind.Utc).AddTicks(7004) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 89L, new DateTime(2022, 8, 31, 0, 19, 18, 383, DateTimeKind.Utc).AddTicks(5425), new DateTime(2023, 3, 14, 13, 11, 24, 432, DateTimeKind.Utc).AddTicks(4932) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 10L, new DateTime(2023, 3, 5, 18, 10, 42, 560, DateTimeKind.Utc).AddTicks(4950), new DateTime(2023, 3, 16, 15, 3, 44, 101, DateTimeKind.Utc).AddTicks(9422) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 43L, new DateTime(2023, 1, 30, 23, 38, 16, 931, DateTimeKind.Utc).AddTicks(6776), new DateTime(2023, 3, 19, 22, 17, 44, 335, DateTimeKind.Utc).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 56L, new DateTime(2023, 3, 13, 22, 16, 29, 828, DateTimeKind.Utc).AddTicks(6835), new DateTime(2023, 5, 11, 7, 48, 11, 716, DateTimeKind.Utc).AddTicks(4295) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 181L, new DateTime(2023, 5, 26, 16, 33, 18, 31, DateTimeKind.Utc).AddTicks(132), new DateTime(2023, 8, 8, 10, 39, 43, 468, DateTimeKind.Utc).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 81L, new DateTime(2023, 5, 26, 14, 12, 25, 446, DateTimeKind.Utc).AddTicks(2644), new DateTime(2023, 8, 6, 16, 59, 20, 922, DateTimeKind.Utc).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 42L, new DateTime(2023, 9, 16, 23, 47, 11, 858, DateTimeKind.Utc).AddTicks(1195), new DateTime(2023, 9, 17, 14, 49, 9, 240, DateTimeKind.Utc).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 193L, new DateTime(2023, 3, 20, 3, 1, 17, 668, DateTimeKind.Utc).AddTicks(5302), new DateTime(2023, 5, 17, 19, 46, 17, 96, DateTimeKind.Utc).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 55L, new DateTime(2023, 6, 13, 15, 5, 52, 768, DateTimeKind.Utc).AddTicks(4593), new DateTime(2023, 8, 2, 20, 33, 8, 828, DateTimeKind.Utc).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 74L, new DateTime(2023, 9, 15, 8, 36, 24, 881, DateTimeKind.Utc).AddTicks(5887), new DateTime(2023, 9, 15, 21, 10, 57, 903, DateTimeKind.Utc).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 74L, new DateTime(2023, 9, 3, 18, 30, 16, 826, DateTimeKind.Utc).AddTicks(4609), new DateTime(2023, 9, 5, 13, 51, 41, 870, DateTimeKind.Utc).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 20L, new DateTime(2023, 8, 25, 7, 36, 44, 441, DateTimeKind.Utc).AddTicks(3434), new DateTime(2023, 9, 3, 6, 52, 55, 519, DateTimeKind.Utc).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 83L, new DateTime(2023, 9, 13, 12, 33, 48, 731, DateTimeKind.Utc).AddTicks(3259), new DateTime(2023, 9, 14, 6, 36, 0, 12, DateTimeKind.Utc).AddTicks(5308) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 54L, new DateTime(2023, 5, 6, 10, 40, 41, 991, DateTimeKind.Utc).AddTicks(9358), new DateTime(2023, 9, 3, 11, 16, 6, 963, DateTimeKind.Utc).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 167L, new DateTime(2023, 5, 31, 12, 10, 22, 280, DateTimeKind.Utc).AddTicks(7988), new DateTime(2023, 8, 2, 1, 29, 59, 23, DateTimeKind.Utc).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 4L, new DateTime(2023, 8, 26, 3, 46, 54, 158, DateTimeKind.Utc).AddTicks(7691), new DateTime(2023, 9, 11, 4, 54, 28, 155, DateTimeKind.Utc).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 38L, new DateTime(2023, 8, 23, 0, 21, 40, 886, DateTimeKind.Utc).AddTicks(4084), new DateTime(2023, 9, 1, 17, 17, 8, 366, DateTimeKind.Utc).AddTicks(7558) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 23L, new DateTime(2023, 5, 18, 5, 13, 57, 214, DateTimeKind.Utc).AddTicks(5545), new DateTime(2023, 8, 6, 8, 8, 51, 50, DateTimeKind.Utc).AddTicks(936) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 28L, new DateTime(2022, 8, 17, 8, 49, 27, 193, DateTimeKind.Utc).AddTicks(9569), new DateTime(2023, 1, 24, 1, 15, 25, 83, DateTimeKind.Utc).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 50L, new DateTime(2023, 7, 3, 9, 30, 49, 866, DateTimeKind.Utc).AddTicks(643), new DateTime(2023, 7, 26, 19, 28, 24, 891, DateTimeKind.Utc).AddTicks(6181) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 55L, new DateTime(2023, 7, 10, 22, 58, 11, 77, DateTimeKind.Utc).AddTicks(2418), new DateTime(2023, 8, 15, 2, 37, 46, 716, DateTimeKind.Utc).AddTicks(7244) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 19L, new DateTime(2023, 4, 7, 6, 24, 20, 886, DateTimeKind.Utc).AddTicks(250), new DateTime(2023, 6, 23, 22, 9, 42, 338, DateTimeKind.Utc).AddTicks(3111) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 105L, new DateTime(2023, 1, 28, 18, 34, 58, 20, DateTimeKind.Utc).AddTicks(5318), new DateTime(2023, 4, 2, 13, 41, 30, 189, DateTimeKind.Utc).AddTicks(985) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 150L, new DateTime(2021, 8, 24, 6, 50, 43, 51, DateTimeKind.Utc).AddTicks(4691), new DateTime(2023, 1, 19, 16, 40, 49, 973, DateTimeKind.Utc).AddTicks(9265) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "RegisteredAt",
                value: new DateTime(2016, 5, 20, 6, 4, 15, 776, DateTimeKind.Utc).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "RegisteredAt",
                value: new DateTime(2016, 4, 10, 23, 16, 23, 34, DateTimeKind.Utc).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                column: "RegisteredAt",
                value: new DateTime(2017, 11, 12, 13, 30, 3, 695, DateTimeKind.Utc).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                column: "RegisteredAt",
                value: new DateTime(2018, 7, 29, 1, 9, 46, 744, DateTimeKind.Utc).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                column: "RegisteredAt",
                value: new DateTime(2017, 8, 17, 22, 26, 34, 502, DateTimeKind.Utc).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                column: "RegisteredAt",
                value: new DateTime(2022, 3, 13, 19, 28, 1, 215, DateTimeKind.Utc).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                column: "RegisteredAt",
                value: new DateTime(2020, 9, 23, 11, 13, 9, 464, DateTimeKind.Utc).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                column: "RegisteredAt",
                value: new DateTime(2022, 6, 8, 10, 38, 39, 457, DateTimeKind.Utc).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                column: "RegisteredAt",
                value: new DateTime(2021, 12, 13, 21, 42, 2, 741, DateTimeKind.Utc).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                column: "RegisteredAt",
                value: new DateTime(2018, 7, 23, 6, 7, 25, 484, DateTimeKind.Utc).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11L,
                column: "RegisteredAt",
                value: new DateTime(2022, 4, 4, 10, 58, 47, 15, DateTimeKind.Utc).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12L,
                column: "RegisteredAt",
                value: new DateTime(2019, 9, 21, 7, 37, 14, 840, DateTimeKind.Utc).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13L,
                column: "RegisteredAt",
                value: new DateTime(2021, 3, 18, 20, 18, 2, 169, DateTimeKind.Utc).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14L,
                column: "RegisteredAt",
                value: new DateTime(2016, 6, 10, 12, 34, 52, 300, DateTimeKind.Utc).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15L,
                column: "RegisteredAt",
                value: new DateTime(2022, 3, 23, 18, 33, 55, 218, DateTimeKind.Utc).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16L,
                column: "RegisteredAt",
                value: new DateTime(2017, 6, 24, 21, 57, 3, 807, DateTimeKind.Utc).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17L,
                column: "RegisteredAt",
                value: new DateTime(2016, 1, 20, 0, 16, 36, 947, DateTimeKind.Utc).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18L,
                column: "RegisteredAt",
                value: new DateTime(2023, 1, 7, 7, 38, 48, 894, DateTimeKind.Utc).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19L,
                column: "RegisteredAt",
                value: new DateTime(2022, 4, 24, 21, 46, 3, 525, DateTimeKind.Utc).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20L,
                column: "RegisteredAt",
                value: new DateTime(2020, 12, 24, 6, 45, 3, 462, DateTimeKind.Utc).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21L,
                column: "RegisteredAt",
                value: new DateTime(2017, 1, 25, 22, 43, 27, 180, DateTimeKind.Utc).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22L,
                column: "RegisteredAt",
                value: new DateTime(2018, 5, 7, 13, 21, 11, 783, DateTimeKind.Utc).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23L,
                column: "RegisteredAt",
                value: new DateTime(2021, 11, 16, 21, 0, 23, 950, DateTimeKind.Utc).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24L,
                column: "RegisteredAt",
                value: new DateTime(2021, 5, 5, 11, 22, 56, 167, DateTimeKind.Utc).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25L,
                column: "RegisteredAt",
                value: new DateTime(2019, 2, 26, 16, 0, 52, 108, DateTimeKind.Utc).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26L,
                column: "RegisteredAt",
                value: new DateTime(2016, 6, 22, 8, 39, 20, 437, DateTimeKind.Utc).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27L,
                column: "RegisteredAt",
                value: new DateTime(2021, 12, 21, 20, 21, 51, 332, DateTimeKind.Utc).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28L,
                column: "RegisteredAt",
                value: new DateTime(2016, 7, 19, 1, 28, 24, 203, DateTimeKind.Utc).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29L,
                column: "RegisteredAt",
                value: new DateTime(2017, 8, 6, 9, 7, 23, 586, DateTimeKind.Utc).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30L,
                column: "RegisteredAt",
                value: new DateTime(2020, 8, 29, 15, 22, 49, 133, DateTimeKind.Utc).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31L,
                column: "RegisteredAt",
                value: new DateTime(2016, 12, 18, 2, 55, 48, 68, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32L,
                column: "RegisteredAt",
                value: new DateTime(2016, 12, 26, 5, 24, 50, 510, DateTimeKind.Utc).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33L,
                column: "RegisteredAt",
                value: new DateTime(2021, 12, 7, 1, 24, 58, 777, DateTimeKind.Utc).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34L,
                column: "RegisteredAt",
                value: new DateTime(2023, 3, 24, 18, 28, 48, 724, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35L,
                column: "RegisteredAt",
                value: new DateTime(2022, 2, 26, 19, 17, 44, 889, DateTimeKind.Utc).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36L,
                column: "RegisteredAt",
                value: new DateTime(2020, 4, 15, 0, 53, 5, 476, DateTimeKind.Utc).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37L,
                column: "RegisteredAt",
                value: new DateTime(2016, 5, 7, 21, 29, 45, 657, DateTimeKind.Utc).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38L,
                column: "RegisteredAt",
                value: new DateTime(2018, 12, 26, 1, 50, 36, 798, DateTimeKind.Utc).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39L,
                column: "RegisteredAt",
                value: new DateTime(2016, 7, 25, 15, 36, 57, 210, DateTimeKind.Utc).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40L,
                column: "RegisteredAt",
                value: new DateTime(2017, 10, 23, 17, 33, 59, 802, DateTimeKind.Utc).AddTicks(368));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 1L, 5L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 1L, 9L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 2L, 5L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 3L, 5L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 4L, 9L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 5L, 4L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 6L, 3L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 6L, 5L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 7L, 4L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 8L, 5L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 9L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 10L, 5L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 10L, 9L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 11L, 5L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 12L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 13L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 14L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 15L, 4L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 16L, 1L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 16L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 17L, 9L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 18L, 5L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 18L, 7L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 19L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 19L, 3L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 20L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 21L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 22L, 4L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 22L, 9L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 24L, 3L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 25L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 26L, 3L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 26L, 4L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 28L, 1L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 28L, 5L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 29L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 30L, 1L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 30L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 31L, 3L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 32L, 8L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 33L, 5L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 33L, 8L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 34L, 3L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 34L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 35L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 35L, 3L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 36L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 37L, 1L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 38L, 7L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 39L, 3L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 39L, 7L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 40L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 40L, 8L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 41L, 3L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 42L, 1L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 42L, 4L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 43L, 1L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 43L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 44L, 4L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 45L, 8L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 46L, 1L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 46L, 7L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 47L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 47L, 3L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 48L, 3L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 48L, 4L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 49L, 3L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 49L, 5L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 50L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 50L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 51L, 7L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 54L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 54L, 4L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 55L, 1L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 56L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 56L, 9L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 57L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 58L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 59L, 4L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 60L, 4L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 60L, 9L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 61L, 9L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 62L, 1L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 62L, 8L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 63L, 8L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 64L, 3L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 64L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 65L, 2L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 66L, 4L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 66L, 7L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 67L, 6L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 67L, 7L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 68L, 3L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 69L, 4L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 69L, 8L });

            migrationBuilder.DeleteData(
                table: "ChallengeTags",
                keyColumns: new[] { "ChallengeId", "TagId" },
                keyValues: new object[] { 70L, 6L });

            migrationBuilder.InsertData(
                table: "ChallengeTags",
                columns: new[] { "ChallengeId", "TagId" },
                values: new object[,]
                {
                    { 1L, 2L },
                    { 1L, 6L },
                    { 2L, 2L },
                    { 2L, 4L },
                    { 2L, 9L },
                    { 3L, 7L },
                    { 4L, 2L },
                    { 5L, 3L },
                    { 6L, 2L },
                    { 6L, 6L },
                    { 7L, 3L },
                    { 7L, 6L },
                    { 7L, 7L },
                    { 7L, 8L },
                    { 8L, 4L },
                    { 9L, 3L },
                    { 9L, 4L },
                    { 9L, 9L },
                    { 10L, 6L },
                    { 12L, 4L },
                    { 13L, 2L },
                    { 13L, 5L },
                    { 13L, 9L },
                    { 14L, 1L },
                    { 14L, 4L },
                    { 14L, 9L },
                    { 15L, 3L },
                    { 15L, 6L },
                    { 15L, 7L },
                    { 15L, 8L },
                    { 16L, 2L },
                    { 16L, 7L },
                    { 17L, 2L },
                    { 17L, 4L },
                    { 17L, 5L },
                    { 17L, 6L },
                    { 17L, 7L },
                    { 18L, 8L },
                    { 19L, 5L },
                    { 20L, 2L },
                    { 20L, 7L },
                    { 21L, 3L }
                });

            migrationBuilder.InsertData(
                table: "ChallengeTags",
                columns: new[] { "ChallengeId", "TagId" },
                values: new object[,]
                {
                    { 21L, 7L },
                    { 21L, 8L },
                    { 23L, 5L },
                    { 24L, 1L },
                    { 24L, 2L },
                    { 24L, 6L },
                    { 24L, 8L },
                    { 24L, 9L },
                    { 25L, 6L },
                    { 27L, 3L },
                    { 27L, 5L },
                    { 27L, 8L },
                    { 28L, 3L },
                    { 29L, 1L },
                    { 29L, 4L },
                    { 29L, 7L },
                    { 30L, 3L },
                    { 30L, 4L },
                    { 31L, 1L },
                    { 31L, 4L },
                    { 31L, 6L },
                    { 31L, 9L },
                    { 32L, 5L },
                    { 32L, 6L },
                    { 33L, 1L },
                    { 33L, 6L },
                    { 34L, 1L },
                    { 34L, 9L },
                    { 35L, 1L },
                    { 36L, 1L },
                    { 36L, 9L },
                    { 37L, 3L },
                    { 37L, 5L },
                    { 37L, 6L },
                    { 38L, 3L },
                    { 38L, 5L },
                    { 39L, 1L },
                    { 39L, 4L },
                    { 39L, 8L },
                    { 40L, 3L },
                    { 40L, 4L },
                    { 41L, 2L }
                });

            migrationBuilder.InsertData(
                table: "ChallengeTags",
                columns: new[] { "ChallengeId", "TagId" },
                values: new object[,]
                {
                    { 41L, 6L },
                    { 41L, 7L },
                    { 41L, 8L },
                    { 41L, 9L },
                    { 42L, 5L },
                    { 42L, 7L },
                    { 43L, 2L },
                    { 43L, 7L },
                    { 44L, 1L },
                    { 44L, 5L },
                    { 44L, 6L },
                    { 44L, 7L },
                    { 44L, 8L },
                    { 44L, 9L },
                    { 45L, 2L },
                    { 46L, 2L },
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
                    { 52L, 1L },
                    { 53L, 2L },
                    { 53L, 4L },
                    { 53L, 9L },
                    { 54L, 6L },
                    { 54L, 7L },
                    { 54L, 8L },
                    { 54L, 9L },
                    { 55L, 4L },
                    { 55L, 6L },
                    { 56L, 8L },
                    { 57L, 6L },
                    { 57L, 8L },
                    { 58L, 5L },
                    { 58L, 7L },
                    { 59L, 1L }
                });

            migrationBuilder.InsertData(
                table: "ChallengeTags",
                columns: new[] { "ChallengeId", "TagId" },
                values: new object[,]
                {
                    { 59L, 2L },
                    { 59L, 3L },
                    { 59L, 5L },
                    { 60L, 3L },
                    { 60L, 5L },
                    { 63L, 5L },
                    { 65L, 1L },
                    { 65L, 5L },
                    { 65L, 6L },
                    { 65L, 9L },
                    { 66L, 2L },
                    { 67L, 2L },
                    { 68L, 5L },
                    { 68L, 7L },
                    { 69L, 2L },
                    { 70L, 1L },
                    { 70L, 2L },
                    { 70L, 7L }
                });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ChallengeId", "CreatedAt", "CreatedBy", "Status" },
                values: new object[] { 10L, new DateTime(2023, 5, 12, 14, 48, 59, 866, DateTimeKind.Utc).AddTicks(6974), 8L, 2 });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 40L, "odit", new DateTime(2023, 3, 17, 17, 36, 14, 953, DateTimeKind.Utc).AddTicks(1126), 34L, "Vel voluptatum quia quia nesciunt sequi impedit.\nVoluptas repellat nam omnis est magnam rerum eum repudiandae minima.\nQuis atque reprehenderit accusamus dolore est ratione maiores non et.\nSequi minima pariatur dignissimos eum eligendi dolorum.\nCum voluptatibus quibusdam corporis saepe dolores.", "Et fugit vero vitae.", 0, "amet" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 47L, "Officiis ducimus aut dolorem sit dicta ullam.", new DateTime(2021, 6, 23, 5, 6, 5, 198, DateTimeKind.Utc).AddTicks(1884), 25L, "maxime", "Amet voluptates temporibus esse magni.", 1L, 3, "Minima accusamus magnam quia laudantium id ut corrupti. Et id nulla nesciunt. Nesciunt minima cupiditate. Dolore corrupti iusto ipsam sapiente." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 57L, "Molestiae hic et officiis accusantium nostrum repellat aut et.\nItaque animi eveniet ut delectus voluptates dolorem.\nLaudantium itaque sequi officiis sapiente et.", new DateTime(2023, 4, 7, 20, 1, 24, 692, DateTimeKind.Utc).AddTicks(4914), 27L, "Non porro impedit.", "Quis perferendis et pariatur sapiente repellat quasi.", 2L, 2, "Exercitationem dolorem adipisci veniam blanditiis quidem earum tempore molestias." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 60L, "Sit molestiae adipisci repellat eum vel dolorum aut ullam distinctio.\nOmnis animi officiis tenetur.", new DateTime(2019, 5, 2, 8, 43, 20, 183, DateTimeKind.Utc).AddTicks(1775), 9L, "Libero dolorem voluptatem et vitae eius nemo.", "Fugit mollitia aut ab eum est quaerat consequatur.", 1L, 0, "Aliquid neque nemo dolore possimus.\nOptio veniam ratione qui nulla vel in aut.\nVel sit repellendus cupiditate quo quo.\nSunt unde ex doloremque necessitatibus quo veniam dolor officiis eos.\nExplicabo enim necessitatibus soluta est libero voluptatum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "TestCases" },
                values: new object[] { 69L, "Culpa maiores officiis deleniti cumque similique optio et sed ab. Quis voluptatem et veniam iusto rerum. Provident inventore voluptas nihil rerum totam expedita hic. Sint rerum earum facilis iusto unde nihil officia minima. Id occaecati quod. Laborum illo ipsum fuga ratione ipsa sequi.", new DateTime(2023, 1, 21, 22, 5, 47, 324, DateTimeKind.Utc).AddTicks(2928), 25L, "Qui placeat facere omnis ea quia.", "Commodi architecto omnis necessitatibus est eum.", "Dolor nesciunt sit itaque quidem debitis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 63L, "Est totam voluptas excepturi et expedita dignissimos et. Atque aut est et. Recusandae rerum dolor assumenda maiores placeat magnam debitis. Facilis velit et qui totam et iusto consequatur ut. Et tempora officiis error enim nulla.", new DateTime(2023, 4, 22, 22, 39, 23, 159, DateTimeKind.Utc).AddTicks(2507), 13L, "Debitis consequuntur perspiciatis dolorum architecto placeat error eum aut repellendus. Est cumque velit aspernatur voluptatum fugiat. Consequatur est voluptatum natus sed qui atque inventore beatae totam.", "Iure nisi voluptatem.", 2L, 1, "suscipit" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 55L, "Quia commodi non quis voluptatem ea.\nQuis dignissimos ipsam et in dolores perferendis.\nAspernatur praesentium sint quis eos et at iusto.\nOfficia harum in ab at at dolorem qui nobis.", new DateTime(2023, 3, 23, 6, 26, 58, 321, DateTimeKind.Utc).AddTicks(9173), 32L, "Et illo voluptas culpa ea ducimus ea.\nEt eum est est neque qui.\nVoluptatem unde voluptatem non.", "Voluptas veniam rerum sed qui ipsam accusamus fuga id.", 1L, 2, "rerum" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 66L, "Quis voluptatem autem voluptas ducimus maiores praesentium odit error adipisci. Vitae eligendi consequatur laboriosam commodi atque. Dolor eos est repellat enim aliquam ratione. A voluptatem assumenda delectus quaerat est recusandae aliquam provident. Rerum eius accusamus rerum recusandae cum et officia odit aliquid. Corrupti repellat aliquid dolorum iste quia voluptatibus dolores nostrum ab.", new DateTime(2023, 5, 4, 5, 8, 39, 464, DateTimeKind.Utc).AddTicks(4415), 6L, "Suscipit animi recusandae quo voluptatem odio.\nEsse quam ut optio quo non.", "Officia quos laboriosam porro aut consequuntur.", 1L, 2, "dolor" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "TestCases" },
                values: new object[] { 16L, "Sint dolores laboriosam totam. Reprehenderit sed blanditiis perferendis qui non aliquid vero. Ab eaque ea consequatur aut.", new DateTime(2022, 11, 10, 21, 6, 14, 672, DateTimeKind.Utc).AddTicks(3216), 37L, "sed", "Totam voluptatem quam ut cumque sint tenetur sed et debitis.", "Natus esse sint magnam incidunt velit adipisci voluptatem." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 2L, "Vitae aut molestias pariatur expedita provident ex beatae nihil numquam. Adipisci consequatur eos dolor quae sit. In esse et veniam.", new DateTime(2020, 10, 27, 0, 40, 36, 963, DateTimeKind.Utc).AddTicks(6078), 23L, "Et dignissimos omnis veniam.\nDoloribus dolorem et accusamus nostrum aliquam aut repellat tenetur.\nQuia impedit ut.", "Laudantium accusantium possimus mollitia totam blanditiis odio corrupti asperiores.", 1L, 2, "Repellendus labore aut aut. Quaerat iure voluptatem exercitationem ut ut. Facere similique molestiae. Ex sit magnam animi natus deserunt voluptas." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 48L, "Rerum quaerat perferendis iusto ea et.", new DateTime(2023, 5, 15, 21, 25, 47, 50, DateTimeKind.Utc).AddTicks(7132), 34L, "Suscipit exercitationem error iure rerum.\nEt autem culpa nemo delectus voluptates.\nPariatur ut nihil.", "Quaerat hic facilis quod expedita adipisci voluptates molestiae qui.", 2L, 1, "cumque" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 63L, "Consequatur et ut dolor ut enim atque. Quia nobis dicta reiciendis. Doloribus qui perferendis odio ratione. Magnam atque minus. Minus rem voluptatum amet a dolorem modi. Qui quia commodi perferendis.", new DateTime(2020, 12, 5, 13, 40, 28, 257, DateTimeKind.Utc).AddTicks(3981), 13L, "nihil", "Natus explicabo repudiandae optio totam architecto sequi blanditiis.", 2, "repellat" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 52L, "Deserunt veritatis ad perferendis et nihil autem quia cupiditate.", new DateTime(2022, 12, 1, 12, 52, 8, 872, DateTimeKind.Utc).AddTicks(1522), 2L, "Maiores aut aliquid perferendis adipisci odio expedita ex nulla.\nIste aliquam ex repudiandae atque beatae.\nExcepturi illum et.\nCorporis quod eius vel ut repudiandae et.\nEt voluptas corrupti voluptas quaerat.", "Fugit error nihil aut veritatis quo.", 2L, 2, "maiores" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 34L, "Voluptatum quod sit voluptas nobis ut magni harum expedita non.", new DateTime(2022, 10, 6, 16, 0, 34, 313, DateTimeKind.Utc).AddTicks(8834), 24L, "Dicta rerum omnis voluptatem consectetur. Id et nihil. Maxime dolorem recusandae necessitatibus dolores ea velit vero laboriosam. Quaerat doloribus omnis iure rerum magnam perspiciatis necessitatibus et.", "Dolor labore numquam at praesentium ea ut aut rerum.", 2L, 3, "Tempora explicabo quasi esse aspernatur suscipit facere perspiciatis inventore asperiores." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 15L, "Officia neque ducimus aliquam eos.\nDolores est tempore doloremque aspernatur consequuntur autem beatae.\nQuos quo sit nulla autem hic dolore eveniet nostrum voluptatem.", new DateTime(2023, 3, 21, 23, 49, 48, 860, DateTimeKind.Utc).AddTicks(9974), 8L, "A velit laudantium cupiditate veritatis ex sunt aspernatur quidem.", "Ut consequatur laborum laudantium quos consequatur inventore.", 2L, 1, "et" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "TestCases" },
                values: new object[] { 14L, "Explicabo ipsa cum.\nAutem nisi voluptatem sequi aut aut nulla quod voluptas.\nFugiat harum id enim quisquam at reprehenderit beatae.\nHarum doloremque assumenda laboriosam saepe.", new DateTime(2023, 2, 15, 23, 19, 16, 92, DateTimeKind.Utc).AddTicks(4800), 34L, "Aliquid ratione quisquam molestiae ipsam commodi.", "Et eius asperiores.", 1L, "Ut accusamus voluptas. Nesciunt repellendus expedita est perferendis dolorem earum provident distinctio. Animi quam consectetur ipsum et. Soluta vel tempore est perferendis temporibus quae. Est consequatur quis commodi ipsum veritatis in officiis et. Cum nulla rerum fuga impedit doloremque qui unde deserunt." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 38L, "Dolores sit libero inventore odit.\nNesciunt totam velit omnis ea quaerat vero est.\nVero optio consequuntur tempore est consequatur.\nOdit quia perspiciatis cumque in.", new DateTime(2023, 6, 5, 14, 54, 51, 778, DateTimeKind.Utc).AddTicks(2364), 16L, "Sit amet repudiandae unde excepturi ea et veniam veniam.\nNemo cumque ea ab.", "Dolorem vitae consequatur qui in ea animi autem.", 1L, 0, "Rem cumque at consequatur tempora et facilis corporis ut iste. Autem ipsum sapiente. Qui ratione et dolores quas ut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 26L, "optio", new DateTime(2023, 3, 20, 8, 41, 27, 639, DateTimeKind.Utc).AddTicks(4019), 36L, "Unde animi sed et illo. Sunt iure unde fugit animi. Et dolorem sed ipsum atque reiciendis corporis blanditiis qui. Reprehenderit culpa sint impedit. Dolor maiores eius dolore repellat sunt velit labore dolores. Nesciunt libero inventore cupiditate doloribus ab quia et ab.", "Et harum dolores.", 1L, 0, "Id nobis dicta consequatur facilis quae deleniti eaque doloribus.\nAutem earum quos.\nExplicabo delectus expedita quisquam quam aspernatur vel animi nostrum.\nNecessitatibus itaque adipisci optio ab est pariatur." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 35L, "Accusamus animi maxime molestiae qui. Voluptas quia enim. Recusandae ea dicta numquam. Accusamus qui atque dolorum odit non quis molestias.", new DateTime(2023, 5, 29, 5, 8, 57, 332, DateTimeKind.Utc).AddTicks(8857), 2L, "nostrum", "Quos reprehenderit saepe voluptate quia ut culpa ut molestias.", 1L, 0, "Quis nemo culpa voluptatem omnis minus deserunt quisquam nemo.\nCorporis rerum dolor sed omnis.\nError dolore praesentium quos quia asperiores et impedit tenetur voluptatem." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 23L, "Molestias nihil quas omnis delectus consequatur quaerat.", new DateTime(2023, 9, 2, 11, 31, 48, 168, DateTimeKind.Utc).AddTicks(4013), 30L, "Officiis consequatur non natus ullam voluptatem.\nNon quaerat omnis accusantium ea provident eius sunt iste.\nCum a dicta et ratione.", "Possimus sit maxime doloribus est velit vel commodi et.", 2, "vel" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 65L, "quidem", new DateTime(2022, 9, 6, 3, 25, 16, 83, DateTimeKind.Utc).AddTicks(1492), 36L, "earum", "Fugiat consequatur ipsam dolore laudantium culpa accusamus fuga.", 2L, 0, "Nesciunt nemo placeat.\nQui voluptatem maxime ut cumque reiciendis dolores unde." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 68L, "Doloribus laboriosam quo eligendi quidem non porro est qui magni.\nDolor optio magnam quidem qui cumque hic maxime tenetur.", new DateTime(2023, 3, 13, 6, 37, 11, 430, DateTimeKind.Utc).AddTicks(3169), 22L, "Eveniet et et in quis. Ea ut quidem eius animi. Tempora in consequatur voluptas velit cum dolore dolorum ut vitae. Voluptatem sed dolore ducimus officiis non possimus voluptatem. Voluptatibus iure quod veniam et nostrum neque. Totam non veritatis aperiam aperiam aliquam rem autem vel.", "Consequuntur vel ducimus ducimus dolor eveniet tenetur ut hic qui.", 1L, 1, "delectus" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 55L, "eaque", new DateTime(2022, 11, 13, 1, 17, 9, 694, DateTimeKind.Utc).AddTicks(5574), 25L, "Ut ullam et ab omnis odit vitae maiores. Maiores totam dolore voluptatem repellendus doloribus et beatae laudantium. Neque quos voluptates. Quis vel iure blanditiis dolorem mollitia.", "Vel animi placeat.", 1, "Debitis adipisci eaque voluptates voluptas fugiat vitae consectetur voluptates. Nihil voluptatem illo voluptatem laborum veniam hic. Architecto dolores aut quibusdam minus doloremque maxime aliquid molestiae. Ut explicabo consequuntur delectus maiores blanditiis sit quo." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 61L, "optio", new DateTime(2023, 5, 2, 3, 53, 21, 762, DateTimeKind.Utc).AddTicks(3130), 28L, "Labore reprehenderit est sint iure tenetur numquam dolor.\nQuia dolore temporibus rem suscipit excepturi dicta quas.\nOmnis cumque pariatur sapiente.\nAd dolorem autem minus in ullam quam.\nEt ullam unde molestias natus ad quod reiciendis dolor atque.\nQuia quod recusandae quia voluptas.", "Velit dolor maxime tenetur molestiae distinctio commodi.", 3, "Eos sit repellat et aut autem maiores sit qui." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 25L, "Nisi quos molestiae. Hic consequatur omnis voluptatem mollitia eius deserunt possimus repellendus. A laudantium delectus sed qui.", new DateTime(2022, 12, 22, 15, 12, 26, 404, DateTimeKind.Utc).AddTicks(8272), 8L, "Et veritatis voluptatem dolorum corporis qui aut quibusdam. Sunt porro id. Adipisci aliquam impedit iure saepe dolores voluptatum corporis voluptas.", "Velit repellendus ad accusamus autem facere deserunt eius illum.", 1L, 2, "Aut omnis incidunt.\nEveniet doloribus eum sapiente libero vel voluptatibus et.\nPorro ea earum repudiandae sunt sint accusamus.\nReiciendis consectetur sint dicta eaque.\nMagni aliquam minima atque atque qui quis reprehenderit neque.\nQuaerat repudiandae est assumenda harum omnis numquam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 5L, "Omnis et incidunt distinctio dolor.\nDoloremque quos ut deserunt debitis et illo culpa.\nMolestiae neque voluptatem minima eligendi ducimus repudiandae.\nTempore delectus consequuntur cum aut dolor eligendi mollitia aut.\nSunt rerum amet voluptatum qui porro fugiat dignissimos.\nInventore facilis totam consequatur consequuntur error officia optio ut.", new DateTime(2023, 7, 31, 17, 13, 19, 273, DateTimeKind.Utc).AddTicks(2467), 21L, "Nihil atque molestiae. Excepturi praesentium qui alias hic sint aperiam nam pariatur nihil. Atque est error ipsa facilis fuga. Dolore eum illo voluptatem reiciendis. Dolor inventore ex minus. Accusamus mollitia fugiat.", "Dolorum molestiae reiciendis.", 1, "Voluptas quidem labore iste.\nIllo maiores sit ipsam sunt repellat et delectus.\nItaque voluptas ducimus iusto id dignissimos.\nHarum vero dolor sed." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 60L, "Neque ut mollitia aut corrupti deleniti. Modi necessitatibus error corporis laborum voluptatibus eum. Laboriosam officia dolorem sed eveniet est rerum porro. Fugit molestiae sequi quasi velit cupiditate.", new DateTime(2023, 4, 6, 14, 14, 4, 647, DateTimeKind.Utc).AddTicks(7127), 32L, "In nesciunt beatae vel.", "Autem non in itaque deserunt dolorem dolores quis provident rerum.", 2, "Vel iusto mollitia unde dolor et voluptatem tempora.\nAtque sapiente aspernatur voluptas laborum asperiores totam aperiam.\nRem eum blanditiis et ad sint dolorem voluptas veritatis voluptas.\nVel consequatur at corrupti voluptates animi.\nQuasi autem voluptate voluptatem excepturi libero.\nIn possimus sit temporibus vel nesciunt id autem culpa et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 33L, "animi", new DateTime(2023, 4, 1, 22, 30, 15, 432, DateTimeKind.Utc).AddTicks(7041), 20L, "Fugiat reiciendis dolore dolorem pariatur iusto repellendus laborum veritatis. Voluptatem ut doloribus velit asperiores quam illum necessitatibus. Veniam facilis est. Et natus sed dolores ipsa. Iste blanditiis placeat. Voluptatem perspiciatis iusto mollitia provident.", "Aut est esse.", 1, "Sed quia accusamus temporibus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 37L, "Aut est dignissimos. Facilis ullam maxime in quas numquam enim. Tempore et natus dolorem veniam sapiente mollitia hic ratione quia. Consequatur consectetur quibusdam nemo et et et. Maiores eligendi velit iusto eum voluptatem molestiae.", new DateTime(2022, 12, 16, 23, 26, 26, 839, DateTimeKind.Utc).AddTicks(9194), 30L, "Sapiente voluptatibus delectus est recusandae neque rerum aut.\nMaiores harum esse nulla doloribus dolore suscipit alias expedita quis.\nRem et qui tempore ex.\nMolestiae commodi modi magni dicta explicabo assumenda veritatis.", "Doloribus consequatur voluptate eum perspiciatis temporibus illo eveniet.", 1, "Officia et quae sed." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 69L, "Et ipsum voluptatem provident magnam exercitationem quam quaerat id ad.\nAut ut ut est repellendus est qui illo.", new DateTime(2022, 10, 22, 13, 23, 11, 8, DateTimeKind.Utc).AddTicks(3697), 19L, "Nulla labore dolore voluptatem. Dicta quia distinctio mollitia et consequatur voluptatem maiores. Commodi dicta omnis deleniti optio. Reiciendis eos et provident laborum provident assumenda nulla ut ut. Id consequatur eos. Voluptatem quos aliquam fugit porro eligendi aut.", "Illo tempora et nulla sint molestias odio sit laboriosam.", 1L, 3, "Laudantium velit et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 56L, "Voluptatem ea eligendi.", new DateTime(2019, 8, 24, 17, 12, 18, 832, DateTimeKind.Utc).AddTicks(5408), 17L, "tempora", "Tempore vel nihil voluptas incidunt earum dolor maiores qui quo.", 3, "Eveniet nulla id laboriosam.\nCupiditate commodi voluptatibus magnam explicabo consequatur libero.\nRatione praesentium aut ipsum officia unde magnam autem.\nSapiente officia odio dolor voluptas perferendis.\nSit amet nihil sed harum similique." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 58L, "beatae", new DateTime(2020, 8, 17, 7, 15, 15, 72, DateTimeKind.Utc).AddTicks(7413), 32L, "Distinctio omnis quia. Ducimus hic est ea itaque ut ullam molestiae nobis. Maxime repellat id autem quae aut reiciendis nihil.", "Vitae quia repudiandae perferendis ut rerum sint amet.", 0, "Aut voluptatem ut consequatur soluta aliquid.\nSint et iure totam veritatis in ut.\nVoluptas aut est nulla consequuntur qui aut.\nCupiditate voluptas in quis aut qui.\nNisi libero aut.\nUt beatae et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 67L, "Impedit fuga beatae illum necessitatibus ut earum autem temporibus repudiandae.", new DateTime(2023, 4, 7, 2, 38, 59, 493, DateTimeKind.Utc).AddTicks(9910), 36L, "Quis fugit ullam incidunt numquam consequatur omnis reiciendis aperiam. Vel nesciunt magni ut. Aliquid eveniet voluptatem porro.", "Necessitatibus et voluptate eum iusto autem.", 1, "Ut laboriosam inventore non fugit. A consequatur aliquid. Est eligendi quia sint odio earum totam asperiores." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 40L, "Sunt et natus inventore tempora possimus cumque eveniet quasi adipisci. Voluptatem et fugiat. Architecto aut minima deserunt similique tempore quia. Voluptas non ut accusamus odit provident iste quaerat.", new DateTime(2023, 6, 7, 6, 12, 11, 30, DateTimeKind.Utc).AddTicks(73), 38L, "quisquam", "Nobis qui quas.", 1, "porro" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "TestCases" },
                values: new object[] { 27L, "quaerat", new DateTime(2022, 9, 7, 1, 6, 42, 617, DateTimeKind.Utc).AddTicks(6425), 32L, "Et beatae aperiam et ut delectus aut. At aliquid rerum nihil. Illo magni autem sit odio at deleniti. Odit voluptatibus debitis quaerat autem.", "Nihil facilis enim et.", 2L, "Voluptatum modi quaerat placeat et sint dolores.\nConsequuntur doloribus rerum mollitia consequatur sint itaque ut.\nVoluptate fugit labore quas dolores nisi alias.\nMagnam provident quam et necessitatibus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 9L, "Eaque harum dignissimos nemo architecto et qui in ullam assumenda.", new DateTime(2022, 12, 31, 3, 15, 57, 837, DateTimeKind.Utc).AddTicks(7447), 7L, "ut", "Est vitae ducimus.", 1L, 3, "in" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 32L, "Illo fugit recusandae explicabo cupiditate est. Voluptatum voluptatibus aut voluptate ipsum minima blanditiis voluptas. A est quibusdam voluptatibus tempore saepe. Rerum consequatur sint harum nisi maxime et ipsa rem.", new DateTime(2023, 9, 2, 11, 52, 40, 876, DateTimeKind.Utc).AddTicks(6272), 18L, "Quasi dolor inventore.", "Sequi est deserunt.", 1L, 3, "Accusantium laudantium sed dolore officia impedit similique. Facilis porro et rerum ea aliquam cum est maiores quia. Omnis nesciunt sit quae veniam id. Aliquid qui omnis voluptas itaque quis est vero illum sit. Commodi quia ad aut aut eos ipsum sit aperiam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 6L, "Ut et odio distinctio saepe. Delectus neque tempore amet adipisci debitis aut. Cumque voluptatem distinctio assumenda impedit quidem quo. Quam quia animi quo quisquam deserunt repudiandae ut animi. Reprehenderit voluptas et est est. Rerum iusto sit veniam dolor magnam.", new DateTime(2023, 5, 2, 7, 45, 59, 807, DateTimeKind.Utc).AddTicks(9056), 3L, "et", "Sint facilis laborum ea quo quis.", 1L, 1, "Illum architecto repudiandae explicabo quia id ipsum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 31L, "Ad nemo iste fuga ipsum fuga inventore voluptatem facilis soluta.", new DateTime(2023, 8, 7, 12, 51, 48, 71, DateTimeKind.Utc).AddTicks(7725), 24L, "Quisquam eveniet quo rerum consequatur et est repellat aperiam quaerat.", "Quis dolore voluptate officia itaque atque quaerat voluptas molestiae laborum.", 2L, 1, "Dicta magnam laboriosam consequatur optio suscipit aliquid eum provident sapiente. Assumenda nam natus. Iste enim maiores." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "TestCases" },
                values: new object[] { 57L, "Nisi occaecati at molestias veritatis alias laudantium suscipit. Suscipit ipsum minima consectetur esse reprehenderit natus temporibus. Aliquid autem ad ut est blanditiis architecto impedit.", new DateTime(2023, 4, 13, 8, 4, 42, 751, DateTimeKind.Utc).AddTicks(6031), 4L, "Sit aliquid modi aliquid ut sint. Voluptas ab perferendis odit beatae. Sunt totam velit nobis velit. Natus delectus enim dolorem quod quas et. Asperiores cumque fuga necessitatibus error ut ab et velit aperiam.", "Et qui incidunt minima.", 1L, "Possimus sed sit libero sequi quos molestiae a in fuga. Sunt et alias sunt ratione enim distinctio vel non quo. Harum omnis quaerat totam beatae voluptates. Et ex quia eum quam recusandae. Voluptatem est eaque molestiae." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 36L, "Excepturi ducimus ipsa nihil maxime.\nAtque nulla sed iste ipsam veritatis nihil.", new DateTime(2022, 5, 12, 9, 47, 58, 749, DateTimeKind.Utc).AddTicks(6072), 25L, "Enim autem error animi quia rem exercitationem ut nam sit. Ducimus qui enim et. Autem sed consectetur fuga accusamus. Omnis enim est voluptas est id debitis aperiam.", "Nesciunt quisquam nisi et error.", 1, "perspiciatis" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "TestCases" },
                values: new object[] { 46L, "Natus sequi placeat. Est rerum dicta animi dolorem exercitationem. Veniam cumque est sunt harum voluptas expedita explicabo temporibus eveniet.", new DateTime(2022, 7, 12, 4, 49, 6, 272, DateTimeKind.Utc).AddTicks(3951), 14L, "Aperiam qui asperiores temporibus id impedit dolores animi.", "Temporibus voluptates quia sunt consequuntur omnis eos laudantium est.", "Autem et dolores sunt consequatur sunt.\nVero soluta voluptas ipsa est veniam facere.\nQuo occaecati vel repellat quos sint ipsa officiis odio.\nIncidunt dolorum aperiam expedita quis aut rerum libero." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 57L, "Totam omnis velit enim expedita nesciunt illo.", new DateTime(2023, 4, 26, 22, 46, 11, 437, DateTimeKind.Utc).AddTicks(2439), 4L, "Deserunt non ut. Itaque nostrum minima corrupti. Ex aut voluptatibus consequatur maxime. Esse quia voluptas.", "Eum enim vitae cum doloribus perspiciatis placeat maxime inventore.", 1L, 1, "Sunt cupiditate voluptatem voluptatem dolor dolor odio earum autem. Aut non tempora ad aspernatur. Quia soluta quod." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 47L, "Fuga nulla ratione distinctio corporis perferendis cupiditate iste et laudantium. Delectus temporibus rem reiciendis sunt. Vel sint excepturi voluptas quo perferendis. Est provident recusandae. Id qui voluptatem. Magnam quam qui et neque qui sapiente veritatis quia.", new DateTime(2022, 1, 14, 13, 38, 10, 121, DateTimeKind.Utc).AddTicks(8767), 27L, "et", "Quia et non et tenetur autem aliquam ut provident corrupti.", 1L, 0, "Praesentium vero nam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 53L, "Qui autem qui ut quo quis. Inventore voluptate nisi at qui laboriosam hic omnis iste tempora. Quis accusantium qui quasi ea facilis in tenetur facere et.", new DateTime(2020, 8, 31, 3, 19, 2, 591, DateTimeKind.Utc).AddTicks(2806), 12L, "consectetur", "Nam repellendus eum et perferendis.", 2L, 2, "explicabo" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 49L, "A porro accusantium ad voluptas doloremque in illo id placeat.\nEt qui omnis et dicta delectus.\nNon distinctio voluptatum deserunt iure.\nEt voluptates doloremque in aut animi.\nCumque dolorem iusto asperiores eaque est illum magnam aut.\nEt qui vel eveniet illum ipsum consectetur dolor recusandae.", new DateTime(2023, 8, 23, 5, 57, 39, 233, DateTimeKind.Utc).AddTicks(8842), 29L, "alias", "Hic autem sit eius aliquam.", 2L, 2, "Quos neque corrupti commodi sit omnis doloremque recusandae repellat qui." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 22L, "Id voluptas in architecto ut officiis.\nDistinctio hic harum nihil.\nRepellendus voluptatem aut ut.\nEos debitis non qui laudantium nihil animi dolorum aut.", new DateTime(2023, 1, 7, 7, 55, 11, 713, DateTimeKind.Utc).AddTicks(6226), 15L, "eveniet", "Enim voluptatem veritatis aut accusamus omnis qui.", 2, "Recusandae repudiandae possimus aut id. Sequi nihil ut et. Deleniti perferendis possimus. Officiis dicta commodi quod." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 3L, "Quisquam hic magnam. Consequuntur hic unde ut. Qui qui consequuntur impedit quis qui. Quod eos autem qui aliquam animi inventore.", new DateTime(2023, 7, 26, 19, 17, 57, 195, DateTimeKind.Utc).AddTicks(9859), 13L, "Est et quia non molestiae iure architecto possimus architecto atque. Officiis aut optio natus cupiditate ipsam ipsa deleniti est sit. Nesciunt ex id unde mollitia et quia quia tempore voluptatibus.", "Quam et blanditiis et asperiores.", 0, "Id dolorum sint velit et expedita facilis quod esse et.\nSit et inventore aliquid est dolorem debitis rerum nesciunt.\nMagni quasi et quas vero ducimus aut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 41L, "rerum", new DateTime(2023, 6, 16, 4, 15, 4, 397, DateTimeKind.Utc).AddTicks(3861), 29L, "Est autem temporibus dolorem unde et vel voluptatibus in.\nMolestias et fugit rem dolorum sunt voluptatem veritatis qui.\nPossimus nisi veniam quis sapiente debitis.\nQuod nihil hic.\nQuas est natus labore quae.", "Nihil iure facere sed similique cum animi quaerat ut.", 2, "Non minima ut impedit." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 37L, "quia", new DateTime(2022, 2, 28, 20, 28, 35, 961, DateTimeKind.Utc).AddTicks(1340), 28L, "Dolorum qui expedita autem expedita quaerat expedita esse.", "Nobis corrupti porro cumque eius distinctio enim.", 1L, 2, "Explicabo ut explicabo quam.\nTempore temporibus quasi minima.\nBlanditiis consequatur quidem omnis incidunt sunt dolores odio." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 27L, "Inventore aperiam impedit et libero. Quod eligendi rerum voluptatem mollitia id. Est ullam voluptas hic sit quis rerum voluptas repellat est. Magnam vitae voluptatem et ipsam veritatis deserunt omnis dolorem. Animi omnis hic adipisci maiores maiores eligendi dolorem quod. Et dolor sint commodi expedita esse molestiae.", new DateTime(2022, 11, 15, 1, 41, 5, 911, DateTimeKind.Utc).AddTicks(4846), 23L, "Impedit ut tempore ut ut et aperiam vel. Qui similique ducimus et ut et. Consequatur aliquid sed. Libero at sequi quia harum aut perferendis. Nisi sit ut dolorem rem sit at culpa. Repudiandae rem eaque.", "Totam ut tenetur dolor autem ut.", 2L, 2, "Sunt veritatis quaerat repudiandae. Qui dolorem quia autem qui natus illum omnis ratione. Sed illum possimus. Iure rerum itaque. Dolore quia rem similique ut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 27L, "At vitae laudantium animi minus atque exercitationem aperiam iure iste. Reiciendis id sed eius ut blanditiis. Vitae vel exercitationem incidunt officia eum ratione totam id commodi. Illum porro voluptas dolorem numquam repellat et rerum ipsam id.", new DateTime(2023, 7, 7, 4, 42, 21, 380, DateTimeKind.Utc).AddTicks(9249), 1L, "Quaerat eos qui cupiditate voluptas hic doloribus in.\nHarum officiis in quia enim architecto ab similique cum.", "Suscipit ad autem laudantium velit unde.", 2L, 0, "Labore perferendis aut excepturi mollitia.\nNesciunt error maxime libero.\nQuos tempore fuga dolores quidem blanditiis ut maxime recusandae.\nSimilique quo beatae consequatur." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 7L, "Iusto corporis id.\nUt neque quisquam harum sint dolor qui.", new DateTime(2020, 4, 24, 8, 15, 57, 51, DateTimeKind.Utc).AddTicks(2548), 2L, "Quod porro aliquam minima libero porro est voluptas ipsam in.\nNon quibusdam sed assumenda consequatur rem occaecati suscipit sint qui.", "Consequatur iste amet tempore quia eveniet.", 0, "Qui voluptas quos temporibus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 6L, "Vero sint reprehenderit a voluptatem.\nDolorem necessitatibus mollitia harum a fugiat voluptatem.", new DateTime(2023, 5, 13, 14, 26, 33, 347, DateTimeKind.Utc).AddTicks(304), 17L, "labore", "Eum nisi dolor iure iure similique aspernatur corporis.", 2L, 3, "Et sequi repellat et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 32L, "quae", new DateTime(2023, 8, 27, 5, 15, 57, 435, DateTimeKind.Utc).AddTicks(8679), 8L, "Sit dicta ut.", "Similique ea optio.", 2, "Illum quia eos nihil similique qui voluptatem atque. Accusamus molestias nesciunt. Non tenetur earum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 40L, "Dolores nostrum sunt veritatis quidem. Odit et architecto. Reiciendis saepe ea voluptate possimus molestiae a earum veritatis qui. Cum voluptas et et eos dolorum. Id a harum veniam sint at blanditiis.", new DateTime(2023, 1, 18, 2, 46, 11, 555, DateTimeKind.Utc).AddTicks(4503), 10L, "adipisci", "Non eveniet in voluptates debitis.", 0, "Vel repellat nesciunt.\nQuis fuga sed est eveniet.\nQui voluptatum tenetur.\nVel quia voluptatibus illum delectus voluptas repellat dolores laudantium cupiditate.\nSed veniam optio vel molestias hic." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "TestCases" },
                values: new object[] { 9L, "Consequatur optio totam enim.", new DateTime(2022, 1, 29, 4, 7, 25, 643, DateTimeKind.Utc).AddTicks(5764), 26L, "Ea provident modi.\nSuscipit in at voluptatibus quia porro nisi necessitatibus quia.", "Cumque ipsa blanditiis et quas.", "Ea doloremque rerum provident harum voluptates aliquam nisi. Incidunt reprehenderit ipsum eaque minima voluptatem autem. Delectus reiciendis sint voluptatem quis ut aliquam sapiente dicta. Aut qui tempora et rerum. Nihil autem eveniet cum non." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 40L, "Optio modi commodi necessitatibus.\nEt facere ipsam ea et nobis.\nMagni voluptatem molestias quisquam placeat consectetur.\nCum voluptate quae.", new DateTime(2023, 3, 19, 20, 2, 11, 577, DateTimeKind.Utc).AddTicks(8136), 21L, "Dignissimos alias nam est vel quisquam est voluptatem enim.", "Culpa qui possimus minima dolorem facere at.", 1, "Et animi aliquam inventore aspernatur deleniti repellendus. At fuga dolores reiciendis alias. Excepturi ea quia tempora earum eos aut perferendis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "TestCases" },
                values: new object[] { 48L, "quod", new DateTime(2023, 6, 15, 13, 59, 48, 398, DateTimeKind.Utc).AddTicks(5556), 1L, "sed", "Voluptatem eveniet fugit ad rerum.", 2L, "Ipsam ut qui sit consectetur voluptate.\nOdit atque et explicabo vel dolor omnis dolores aut ut.\nDolorum explicabo non eos sint et temporibus sapiente.\nQuod at possimus cumque aliquam consequuntur fugit dolores atque eum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 37L, "Consequuntur dignissimos veniam.\nVoluptatem ut incidunt incidunt esse voluptatem.\nEst repudiandae voluptas nobis et.\nEst ratione asperiores.\nEst quam perferendis voluptas enim quo qui.", new DateTime(2022, 9, 5, 4, 50, 31, 497, DateTimeKind.Utc).AddTicks(2011), 21L, "Et consequuntur nobis eum ipsa dolorem molestiae aut necessitatibus iste.\nEarum exercitationem qui consequatur et expedita molestias.", "Suscipit quisquam error eos.", 1L, 3, "molestiae" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 28L, "dolor", new DateTime(2022, 9, 27, 16, 26, 4, 957, DateTimeKind.Utc).AddTicks(3640), 18L, "Enim laborum quae.", 0, "Veritatis quod veniam porro repellat ut perferendis. Modi voluptatibus nam explicabo saepe quasi. Perspiciatis ut et officia sint fugit tempore. Aut est nam natus. Quia id incidunt ut error reiciendis. Omnis ducimus est et quam dolores consequatur exercitationem quibusdam at." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "TestCases" },
                values: new object[] { 22L, "Sint consectetur asperiores explicabo optio voluptatem dolorem. Odit autem in quaerat voluptatem sed. Commodi dolorum saepe magnam molestias. Ut corrupti aut ad culpa ipsam. Et facilis vel quae sunt at non aut. Voluptate ratione eum.", new DateTime(2023, 4, 23, 10, 42, 13, 161, DateTimeKind.Utc).AddTicks(7741), 30L, "Eos repudiandae aut.", "Ipsum quasi suscipit tempore officia ea atque.", 2L, "est" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 58L, "Laudantium error ex dolorem voluptate quia aliquid. Non placeat quam veniam nulla. Rem accusamus commodi omnis. Iusto soluta ut eius perspiciatis quo qui.", new DateTime(2019, 12, 31, 1, 7, 46, 245, DateTimeKind.Utc).AddTicks(5685), 13L, "Quos ipsa sed dolorum quisquam nihil voluptatum. Ut voluptatem dicta laborum eum aperiam rem placeat. Vel laudantium accusamus harum libero. Reiciendis dolores nobis.", "Aliquam aperiam autem cumque voluptatibus illum sed.", 2L, 1, "Officia accusantium repellat. Magni et qui repellendus placeat qui voluptatum sapiente recusandae. Voluptas vitae ut consectetur neque tempora aut. Nisi quia maiores fugiat natus nisi." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 3L, "Nulla a quis. Dicta consectetur delectus ut blanditiis a dolorem. Modi corrupti aperiam facere et quam ipsa repudiandae aut amet.", new DateTime(2023, 7, 5, 4, 14, 25, 718, DateTimeKind.Utc).AddTicks(264), 14L, "A molestias nihil dicta. Voluptas illo est nostrum repudiandae expedita eum labore a architecto. Impedit ut vitae et ut dicta enim velit. Consequatur nisi non non est. Modi qui rerum deserunt quas aperiam. Ut provident aut beatae.", "Nihil aut maiores et minus voluptates quia expedita dolores voluptatum.", 2, "Perferendis praesentium aliquam aut autem nesciunt at.\nHic nostrum est eum enim non fugit qui fuga." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 47L, "consectetur", new DateTime(2022, 4, 16, 1, 13, 7, 69, DateTimeKind.Utc).AddTicks(636), 13L, "Laboriosam ea laboriosam nobis optio quisquam ut. Reprehenderit commodi eaque aliquam ut veritatis est velit eligendi. Maiores similique est saepe dignissimos sit ut ullam consequatur.", "Eos eum et vitae aut.", 1L, 3, "Omnis sed dolores nulla. Occaecati molestiae et et aliquid commodi similique optio ut. Omnis cumque necessitatibus quas ut error delectus modi." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 4L, "minima", new DateTime(2022, 6, 12, 9, 19, 3, 82, DateTimeKind.Utc).AddTicks(4022), 3L, "Et autem ullam perspiciatis aut dolores enim dignissimos. Et sunt et quaerat quis aperiam maxime similique. Voluptatibus sapiente est error. Quaerat perspiciatis ullam. Ut inventore nihil autem amet iusto possimus iusto. Nulla aperiam dolorem aperiam non corrupti voluptatem sint sit aspernatur.", "Corporis dolor accusantium explicabo delectus expedita facilis ullam necessitatibus.", 0, "Dignissimos fuga commodi enim et consequatur quas vero.\nA consequatur laboriosam in ex ut.\nCulpa quae provident deleniti.\nAut qui odit est dolores nisi ut et maxime dolorem." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 51L, "Enim ut consectetur.", new DateTime(2022, 9, 13, 16, 15, 35, 283, DateTimeKind.Utc).AddTicks(3229), 21L, "Dolorem tempora aperiam iure et esse omnis. Distinctio omnis officia aspernatur dolores atque maxime in. Exercitationem minima quia sed. Ea voluptates nulla. Maiores blanditiis nemo nesciunt magni maxime repellat corrupti esse aut. Quo dolorum eum error.", "Quo earum sint ea suscipit ipsa repellat qui fugiat aperiam.", 1L, 1, "Ut provident veritatis rerum.\nUt velit cupiditate labore ducimus quam est alias alias.\nVero ut dolores quo architecto iste et.\nCulpa sed quia.\nSed et fugit.\nAutem sed sunt sequi rerum accusamus saepe consectetur soluta rerum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 6L, "Perferendis quia dolorem consequuntur perspiciatis et molestiae aspernatur.\nQuas est nulla aut aut et.\nIusto nihil tempore ducimus natus voluptas voluptas aut voluptate.\nQuod animi nemo optio laborum voluptatum non ipsam rem.", new DateTime(2023, 8, 14, 13, 49, 56, 744, DateTimeKind.Utc).AddTicks(8311), 28L, "Non dolor expedita tenetur eos quia vel quia quia.", "Iure voluptatem laborum perspiciatis.", 0, "Perferendis ipsum alias ea." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 32L, "Et nihil aliquam libero ipsa explicabo et fugit consectetur. Fugiat animi ad molestiae occaecati quos dolores consequuntur adipisci. Et ullam exercitationem esse consequuntur in cum magni voluptatem. Voluptatem dolorem animi unde voluptas facere et. Ipsa accusantium amet cum expedita.", new DateTime(2023, 9, 2, 11, 40, 35, 426, DateTimeKind.Utc).AddTicks(9108), 7L, "Beatae labore magnam ad dolorem nihil voluptate est atque quam.\nNesciunt ducimus tempore aut nisi est.\nLaborum voluptate officiis rerum numquam sunt.\nDucimus porro ratione animi.\nExcepturi error omnis itaque error sunt.\nIn sed odit omnis.", "Quisquam facere debitis dolorem temporibus eligendi necessitatibus ipsum quidem.", 0, "Omnis et quia in tempore. Officia facere enim ipsam magni voluptas ut. Quam consequatur quibusdam culpa qui libero. Est neque assumenda et consectetur dicta ipsum mollitia qui rerum. Dolores at accusantium consequatur a. Itaque sint in pariatur minima ducimus dolorum accusantium voluptas in." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 6L, "Aut qui delectus ut quos omnis veniam magnam.", new DateTime(2023, 8, 4, 5, 5, 56, 247, DateTimeKind.Utc).AddTicks(950), 15L, "Beatae vel facilis officiis ipsum at.", "Reiciendis in amet corporis enim.", 0, "Possimus ipsa non aliquam quo provident quis perferendis. Voluptatibus facilis perferendis expedita ea eum error. Repellendus recusandae harum ratione ullam veniam tempora sit." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 43L, "Doloribus provident totam.", new DateTime(2023, 9, 4, 5, 49, 5, 70, DateTimeKind.Utc).AddTicks(6736), 40L, "Aut explicabo aut sunt reiciendis voluptate iusto. Quibusdam temporibus quas commodi. Voluptatibus tempore saepe nesciunt recusandae neque ut dicta. Vel qui cumque enim.", "Et perferendis exercitationem id soluta blanditiis sunt enim.", 2L, 2, "Blanditiis omnis nihil molestiae suscipit inventore non. Recusandae odit voluptatum neque. Suscipit nemo sed doloremque aut minima et pariatur natus. Est omnis quasi aut ut qui aut. Quia aliquam voluptatem et ipsam distinctio." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 57L, "Aliquid harum consequatur quia aperiam est ipsa cupiditate enim. Quisquam nesciunt qui harum dicta molestias error. Voluptatibus officiis impedit quas dolorem dignissimos aut dolore.", new DateTime(2023, 6, 7, 12, 32, 50, 40, DateTimeKind.Utc).AddTicks(7340), 15L, "Ut numquam expedita.\nHarum voluptatem repellat fugiat vel animi libero dolor.\nIpsa omnis nesciunt vitae.", "Facere nobis vel possimus.", 1, "Asperiores dolorem sint dolores consequuntur eos vel." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 66L, "officia", new DateTime(2021, 12, 6, 22, 27, 37, 970, DateTimeKind.Utc).AddTicks(1400), 27L, "dolor", "Et non odit tempore qui.", 2, "Et consequatur assumenda eius. Accusamus aut ducimus aut et tempore rerum illum sint debitis. Delectus inventore delectus eum voluptates. Iste aut modi numquam non aliquid velit quibusdam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "TestCases" },
                values: new object[] { 17L, "Non at dolorum. Et consequatur rerum asperiores placeat. Blanditiis aperiam dolor sed saepe.", new DateTime(2023, 3, 10, 10, 59, 27, 670, DateTimeKind.Utc).AddTicks(3862), 23L, "Dignissimos quas delectus dolores voluptatem eius suscipit incidunt beatae. Nisi quis odit explicabo ipsa blanditiis voluptatibus. Voluptas a voluptatem eligendi odit veritatis aut ad. Magnam praesentium eligendi consequuntur est rerum. Assumenda et et. Similique quibusdam quaerat rerum sapiente voluptatem cupiditate.", "Sed voluptatibus repellat sint reprehenderit ea distinctio atque impedit amet.", "Velit aliquid accusantium itaque.\nEum doloribus nemo velit modi id quas nisi iste consectetur.\nOptio non mollitia laborum hic et quia hic.\nFacilis perspiciatis aut numquam sequi.\nPossimus fugiat perferendis mollitia accusamus eaque deserunt accusamus temporibus.\nQuos laborum nam aliquam et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 41L, "Voluptas maiores omnis dicta est eum odio eligendi facilis quasi.", new DateTime(2022, 3, 15, 20, 17, 16, 461, DateTimeKind.Utc).AddTicks(453), 35L, "Corporis quae inventore soluta magnam quam iste.\nCumque molestias sit quaerat eveniet exercitationem qui aperiam quia et.", "Sunt nam earum non facere.", 3, "Et ea aut provident cumque soluta." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 67L, "ducimus", new DateTime(2023, 8, 9, 14, 3, 13, 683, DateTimeKind.Utc).AddTicks(9955), 30L, "Facilis id ad amet eaque ea aspernatur veniam. Eveniet rerum eum ut ipsam aut animi. Culpa voluptas mollitia et id quibusdam veritatis et voluptatem. Rerum fugiat aut ea id ex magnam dolorum eligendi. Enim eum numquam sapiente temporibus molestiae. Dolorum earum explicabo.", "Debitis neque omnis totam ut aut culpa provident exercitationem.", 2L, 0, "Numquam placeat et consequuntur. Et eligendi deserunt laborum. Cupiditate nesciunt et ut molestiae eligendi blanditiis accusamus sunt. Architecto voluptatum tenetur. Voluptas repellat dicta ab possimus quas blanditiis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 7L, "Aut error quibusdam.\nEt ea aspernatur sed dolore.\nNihil reprehenderit autem repudiandae qui modi eveniet nesciunt.\nVoluptatem quo odio vitae ut eos doloribus pariatur sed.\nVoluptas necessitatibus velit quia molestias iusto doloremque ratione placeat.", new DateTime(2021, 2, 4, 16, 41, 36, 977, DateTimeKind.Utc).AddTicks(1270), 1L, "Quasi eum mollitia assumenda sequi ut. Rerum officia amet modi modi omnis recusandae. Natus omnis consequuntur vel rerum ullam unde qui est.", "Animi deserunt eius.", 2L, 2, "Praesentium esse dolorum sunt ab doloribus vero iusto autem. Veritatis illum aliquid aliquid provident atque quaerat nesciunt. Excepturi error optio deleniti consequatur aut enim et. Omnis beatae ratione suscipit explicabo voluptatum. Accusantium praesentium delectus dicta alias." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "TestCases" },
                values: new object[] { 65L, "Architecto rerum debitis perspiciatis laborum. Dolor voluptatum animi ipsa animi dolorem et delectus. Vel voluptatem eaque praesentium et sit illo. Cupiditate sit enim ducimus voluptatibus sequi nihil. Repellendus temporibus et ducimus rerum a animi distinctio omnis. Voluptate quas rerum reiciendis est sed facilis pariatur.", new DateTime(2022, 3, 12, 0, 19, 22, 144, DateTimeKind.Utc).AddTicks(8752), 39L, "Iusto dicta laborum distinctio nesciunt enim sed.", "At dolorum laborum esse quis rerum omnis.", 1L, "Corporis aut et sit ut aliquid cupiditate nisi.\nAdipisci voluptatem saepe veniam.\nAutem alias sint molestiae at distinctio autem cumque ipsum.\nOmnis deserunt unde sit voluptatem et dolores mollitia vitae doloremque.\nSoluta culpa molestiae nostrum id beatae." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "TestCases" },
                values: new object[] { 32L, "Est consequatur aliquam.", new DateTime(2023, 8, 14, 20, 7, 8, 17, DateTimeKind.Utc).AddTicks(9447), 34L, "Iure sit aperiam tempore non necessitatibus sed soluta rerum maxime. A sed et aut quia qui autem. Et voluptate dolorem et eligendi. Nostrum blanditiis eum. Ducimus sed voluptatem non eum. Quia neque id at fugiat eligendi.", "Itaque asperiores totam possimus aut adipisci adipisci.", "Nihil sunt harum dolore qui inventore voluptatem id." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 47L, "Occaecati recusandae qui nemo deserunt magni. Expedita commodi quaerat qui. Quibusdam earum est vel.", new DateTime(2020, 12, 22, 4, 47, 39, 260, DateTimeKind.Utc).AddTicks(5129), 29L, "Sint non atque.", "Atque est qui nihil illo eaque asperiores nihil.", 1L, 0, "Ea fuga cum aperiam suscipit vel sed aut. Qui voluptatem nihil rerum nam asperiores perspiciatis inventore fugiat nostrum. Illum aut accusantium qui." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 67L, "Dolore et mollitia consequatur. Architecto atque mollitia aut unde. Officiis repellat error molestiae sapiente aut sed aut eos. Qui sit eum eum at quaerat quidem sit quam. Laborum cupiditate eveniet est iusto dolores labore. Ut nobis autem aliquam ex aut.", new DateTime(2023, 1, 6, 18, 0, 32, 411, DateTimeKind.Utc).AddTicks(1919), 15L, "Ut voluptas sed nihil vel nulla in.", "Ut et expedita amet molestias facere est non aut expedita.", 2L, 0, "Consectetur nisi similique et ut officiis maxime." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 10L, "Nostrum qui omnis.\nId omnis molestias.\nProvident qui nihil asperiores.", new DateTime(2022, 12, 5, 6, 27, 41, 64, DateTimeKind.Utc).AddTicks(8673), 28L, "Et molestias quis iure vel quos rerum consequatur.", "Asperiores laudantium accusamus cumque voluptas qui qui rem nam hic.", 2L, 3, "Nam ea porro sapiente voluptate ad ut aut asperiores.\nAut nostrum asperiores ab labore vel voluptatem beatae maxime.\nConsequuntur eaque saepe molestiae in deserunt dolor.\nMinus dolorem impedit ut et animi.\nVoluptatem ut omnis itaque autem rerum aliquid natus eius.\nAtque sint vitae nostrum sint soluta repudiandae repellendus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 56L, "Voluptatum cum et sunt beatae cumque quia illum corrupti. Ducimus sit non quia facere hic dolorem consequuntur ullam. Voluptatibus minus dicta. Aut sed quo enim laboriosam non est fugiat tempore. Sequi eum atque exercitationem id autem impedit omnis laboriosam laboriosam.", new DateTime(2018, 7, 30, 21, 36, 2, 956, DateTimeKind.Utc).AddTicks(8719), 24L, "et", "Reiciendis culpa totam qui.", 2, "Totam quasi tempora et ullam." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "TestCases" },
                values: new object[] { 17L, "et", new DateTime(2023, 7, 22, 0, 7, 44, 486, DateTimeKind.Utc).AddTicks(9727), 1L, "Assumenda dicta impedit voluptates facere dolor quia aspernatur.", "A et eos deleniti ad.", 1L, "Et laudantium officiis.\nMolestias aliquid molestiae reprehenderit placeat voluptas." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 33L, "Ratione velit consequatur aliquid nulla est dolorem nemo.", new DateTime(2023, 1, 2, 21, 6, 36, 346, DateTimeKind.Utc).AddTicks(9940), "Iusto sed recusandae laborum nobis. Et laborum culpa. Ex voluptas et sint omnis eius quisquam. Ut atque consequuntur doloremque molestiae minus inventore qui impedit.", "Nulla architecto et ipsam consequatur nobis et quae corporis dolorem.", 3, "omnis" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "TestCases" },
                values: new object[] { 8L, "similique", new DateTime(2021, 11, 7, 8, 25, 3, 821, DateTimeKind.Utc).AddTicks(2965), 10L, "Est sed iste nostrum voluptatem soluta. Placeat iusto illo fuga. Qui fuga quisquam veniam dolorem ea.", "Quae quis voluptatem et iusto et eos natus.", 2L, "Velit non quae.\nVel doloribus incidunt." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "TestCases" },
                values: new object[] { 27L, "Beatae architecto qui et delectus perspiciatis.", new DateTime(2022, 10, 11, 3, 12, 53, 458, DateTimeKind.Utc).AddTicks(9033), 21L, "Explicabo qui eum a accusantium.", "Voluptatibus et dolores.", 2L, "Voluptas qui debitis accusamus illum quaerat a qui accusantium quasi." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 4L, "Voluptas culpa quae dolore facilis aut.", new DateTime(2023, 4, 5, 23, 11, 9, 473, DateTimeKind.Utc).AddTicks(3772), 24L, "sint", "Unde voluptas ullam ex voluptatibus aut voluptatum quia vitae.", 2L, 3, "Et quo aut ea quaerat dolore et aut voluptatem dolorem. Ex voluptatem alias sit aut occaecati et reiciendis deserunt. Saepe laboriosam rerum est voluptatibus dolore repudiandae. Ullam ea quo rerum aliquid iure fugiat possimus itaque. Minus itaque mollitia." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 6L, "Quo veritatis consequatur impedit maiores.", new DateTime(2023, 8, 24, 5, 27, 27, 611, DateTimeKind.Utc).AddTicks(9858), 16L, "Aut dolorum voluptas fuga sint ut et quia tempora est.\nSoluta beatae nostrum aspernatur iusto nihil quam.\nExcepturi aut in occaecati illum est in.\nSuscipit minus et omnis eum vitae quaerat officia repellendus.\nVoluptate ut vel cupiditate est velit.\nRerum totam voluptatem reiciendis earum quis.", "Assumenda ipsa est enim doloribus quas libero blanditiis.", 0, "Autem qui dolores. Molestias ut ut. Voluptate incidunt aperiam rerum qui voluptas hic molestiae. Ipsum voluptatem incidunt enim. Quisquam asperiores quos." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 30L, "Nesciunt ab omnis porro enim quo architecto.", new DateTime(2021, 2, 22, 0, 2, 28, 297, DateTimeKind.Utc).AddTicks(2580), 12L, "nemo", "Et ipsam iste et ut.", 3, "Aut eveniet nihil est harum qui perspiciatis asperiores. Molestiae aut et possimus ut. Repudiandae unde voluptas magni autem. Quisquam enim officiis eveniet et quod facere sit quia. Sit cum animi non ut et harum asperiores eos aut. Rerum totam sint aliquam exercitationem ut consequatur ex." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 8L, "Nemo vel consequatur sint.\nUt consequatur eius beatae voluptas ea rerum suscipit sed.\nDolorem sapiente soluta laudantium aliquam omnis.", new DateTime(2019, 10, 10, 15, 9, 30, 196, DateTimeKind.Utc).AddTicks(3930), 21L, "maxime", "Facere alias quo autem vel quia itaque.", 2, "Debitis doloribus voluptatem numquam qui.\nNon fugiat accusantium eos incidunt maiores.\nEt sed animi illo fuga." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 45L, "Quo et nihil dolores aut dolores vel veritatis nesciunt nemo.\nAut expedita animi unde ut.\nConsequuntur omnis atque architecto consequatur.\nOdio voluptas labore vel dolor sit.", new DateTime(2023, 5, 1, 6, 19, 8, 244, DateTimeKind.Utc).AddTicks(8464), 17L, "Expedita quasi harum explicabo animi.", "Quasi numquam voluptas voluptas.", 1L, 2, "Nihil perspiciatis dolor id et non.\nDolore itaque dolor repellat dicta maiores blanditiis molestiae ut.\nHic accusantium porro omnis veritatis repudiandae rem.\nMaiores expedita rerum quia.\nIpsa et et maiores omnis fugit nihil rerum.\nExplicabo ea non unde exercitationem consequatur suscipit blanditiis eum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 6L, "In sit non. Dolore sint dolorum aut eos. Enim voluptas quae voluptatibus ut et voluptate. Adipisci atque quo ut magnam ut. Animi magnam iste officiis. Praesentium deleniti et sequi beatae necessitatibus cumque id.", new DateTime(2023, 4, 28, 13, 14, 55, 816, DateTimeKind.Utc).AddTicks(9780), 27L, "Impedit sit ea aperiam non reprehenderit quia.\nUt veritatis tempora fugit quasi temporibus eum saepe.", "Quia molestiae ullam id dolores qui repellat.", 0, "Aut est ut maiores veniam autem debitis ipsam voluptas." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "TestCases" },
                values: new object[] { "Ut maiores ut modi sit.\nQui eos quia at illo voluptatem est cupiditate.\nSunt ut voluptas voluptatum id occaecati aut omnis.\nVoluptatem velit enim.\nConsequatur exercitationem dolor itaque temporibus dolore.\nQui rerum eligendi voluptatum corporis nulla omnis natus.", new DateTime(2022, 2, 16, 0, 15, 26, 923, DateTimeKind.Utc).AddTicks(3863), 25L, "necessitatibus", "Culpa ea vero corporis eaque nam dolores.", 2L, "Officia suscipit in laudantium voluptatem.\nSed amet vel sequi non.\nSapiente est ut eligendi at dolorem.\nSed provident cupiditate nulla sit nobis expedita quis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 28L, "voluptate", new DateTime(2023, 8, 16, 21, 10, 46, 814, DateTimeKind.Utc).AddTicks(1411), 3L, "qui", "Reiciendis officiis ut reiciendis aut id animi et cupiditate.", 3, "Sequi cumque id itaque suscipit qui veritatis quos dolore dolor.\nVitae accusantium exercitationem pariatur est quae et a.\nQuis qui enim pariatur accusamus eum non explicabo voluptatem.\nAd molestiae quam eius.\nVoluptatem vel tempora ad enim possimus corrupti fuga.\nIpsam est impedit nemo qui sint eos perspiciatis assumenda." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "TestCases" },
                values: new object[] { 7L, "Nobis doloremque rerum adipisci omnis provident ratione. Fuga molestias ea aut minus sequi laboriosam harum. Officiis molestiae neque quia voluptatum repellendus. Cupiditate aliquam qui inventore eveniet. Repellat consequuntur voluptatem hic vitae illo cumque eos. Ex sint minima ipsum praesentium assumenda sunt est in.", new DateTime(2021, 11, 23, 18, 26, 0, 44, DateTimeKind.Utc).AddTicks(4519), 36L, "Et similique tempore exercitationem.", "Ut ipsum aut quas minus nam consequatur natus qui.", "Nesciunt quo et expedita." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 29L, "Velit sint accusantium nobis.", new DateTime(2021, 2, 13, 6, 13, 3, 452, DateTimeKind.Utc).AddTicks(8856), 19L, "Unde blanditiis exercitationem nostrum aliquid optio dolor dignissimos dolor. Ut maiores enim. Et sapiente assumenda aut. Voluptatum odio ut quam omnis ut voluptatem sunt voluptas ipsum. Dolores est inventore repudiandae placeat sint sunt id. Laudantium est pariatur vel fugit est eaque autem.", "Eum eveniet inventore neque ut.", 1, "Quis tempora voluptatibus." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "TestCases" },
                values: new object[] { 70L, "Rerum ut molestiae qui.", new DateTime(2022, 11, 29, 10, 25, 41, 475, DateTimeKind.Utc).AddTicks(9615), 34L, "et", "Nihil quam enim aperiam provident reprehenderit doloremque est suscipit.", "Officiis dolorem aut praesentium facere deserunt at corporis." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 1L, "Odit aut reiciendis et.\nDucimus nostrum architecto voluptate tempore eum blanditiis minus.\nNon vitae est eveniet nihil sapiente.", new DateTime(2023, 1, 2, 3, 37, 29, 28, DateTimeKind.Utc).AddTicks(2665), 6L, "Omnis fugit labore magni accusantium quasi. Tempora sit et. Nihil amet ut. Ex debitis vero laboriosam hic in recusandae ut omnis. Ut unde labore est expedita nulla qui omnis porro voluptates.", "Eos quidem quos odio aut iste non tempore vero iure.", 1L, 1, "Et voluptatem at voluptatem tenetur. Animi consequatur perferendis et dolores consequatur. Ut quis assumenda in necessitatibus rerum blanditiis sapiente distinctio. Voluptatem dolores nobis officia dolore corrupti sequi minima sit molestiae. Quasi est vel magni laboriosam est aut nemo illum." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 1L, "Ipsum molestiae nisi accusantium recusandae quae.", new DateTime(2023, 4, 29, 12, 48, 25, 343, DateTimeKind.Utc).AddTicks(9851), 30L, "Dignissimos dolore commodi. Maiores cupiditate et voluptas et aut a. Commodi voluptatibus doloremque ab aspernatur enim.", "Impedit consequatur molestiae cupiditate et placeat optio molestiae blanditiis accusantium.", 1L, 0, "distinctio" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 1L, "provident", new DateTime(2023, 4, 22, 4, 33, 37, 757, DateTimeKind.Utc).AddTicks(3066), 36L, "Deleniti voluptatem et. Voluptate nobis quo ratione quia totam itaque dolorum pariatur. Qui libero ullam quo facilis impedit voluptatem sed quae perferendis. Dolores laboriosam laborum neque. Autem aut quibusdam libero nihil ut quis ipsa ut.", "Amet doloribus quisquam pariatur cum velit quisquam dolorem non.", 0, "Nemo adipisci autem inventore in." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 67L, "Labore molestiae minima fugiat sapiente atque.", new DateTime(2023, 5, 27, 16, 23, 10, 217, DateTimeKind.Utc).AddTicks(5691), 20L, "Accusamus amet ut sapiente quae excepturi rerum. Exercitationem aut nulla. Est consequatur tempore repellendus eveniet deleniti. Aut qui non repudiandae nisi id dolores reprehenderit.", "Eum et aperiam commodi praesentium harum voluptatem quia ut sint.", 0, "Nihil eos cupiditate voluptatum in suscipit perferendis deleniti. Et excepturi dolorem blanditiis provident et aspernatur hic aperiam. Suscipit corporis est est dolores perspiciatis qui sed provident." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 70L, "Aut dolores quia. Quia beatae quia accusamus nam corporis. Magni blanditiis illo. Ad consequatur tempora voluptates quia tenetur aut nesciunt. Ut consectetur nostrum dolorem eaque cum voluptas.", new DateTime(2023, 9, 6, 3, 33, 44, 368, DateTimeKind.Utc).AddTicks(542), 13L, "Laudantium aut et suscipit autem tempora perferendis repellendus sequi.", "Ea rerum quidem odit similique.", 3, "Deleniti porro officia aut non inventore et veritatis quis eum.\nVoluptatum eum corporis voluptatibus commodi aut." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 25L, "Inventore fugit delectus labore ipsam error sit veniam eum tenetur. Voluptas voluptates asperiores officiis voluptatem saepe neque qui ea. Eaque nemo sed repellendus dolore necessitatibus. Nam quaerat illo qui. Necessitatibus cumque beatae alias accusamus at suscipit.", new DateTime(2023, 5, 15, 4, 55, 37, 656, DateTimeKind.Utc).AddTicks(7339), 25L, "Neque ut nihil velit soluta enim nesciunt. Repellendus distinctio dolor non provident voluptatem. Consequatur qui adipisci iure nesciunt et culpa consequatur animi error. Quam molestiae eum ut enim et magni ut.", "Deleniti illo velit similique ab.", 2L, 2, "Et sed nesciunt velit corrupti sit dolor cum. Atque amet deleniti sit aut nulla blanditiis quasi cum aperiam. Quia eveniet ipsam sequi sit nostrum autem. Voluptatem nemo fugit. Repudiandae vel iure sint fuga fugiat ea." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 13L, "dignissimos", new DateTime(2018, 7, 19, 0, 52, 4, 948, DateTimeKind.Utc).AddTicks(1198), 3L, "Molestiae delectus architecto dignissimos velit animi.\nQuasi aut eos quaerat dicta perspiciatis.\nAt sed dolorem inventore consequuntur odio provident.\nIpsum ut recusandae ut.\nCupiditate eaque nihil eius velit.", "Rerum necessitatibus porro veniam ipsa ut incidunt.", 2L, 2, "quidem" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 37L, "Est cum quis labore quasi in laudantium veniam saepe eius.\nIpsum excepturi quia dolore itaque aperiam omnis sint veritatis.", new DateTime(2023, 5, 5, 5, 50, 34, 629, DateTimeKind.Utc).AddTicks(2980), 10L, "Sapiente in ipsam voluptas similique nesciunt voluptatem officiis. Repudiandae labore et. Exercitationem non fuga sunt. Ut sed ad voluptas nemo explicabo corrupti unde consequuntur.", "Ex quo quasi officiis repudiandae.", 2L, 3, "Et beatae consequatur cumque velit consequatur expedita exercitationem officia debitis.\nUnde cum sequi quibusdam aliquid rerum minus magnam minima nihil.\nTenetur nulla sit laudantium dolores." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 3L, "Et quae expedita.", new DateTime(2023, 7, 2, 8, 6, 13, 77, DateTimeKind.Utc).AddTicks(1351), 15L, "ad", "Non repudiandae qui incidunt repudiandae officia rerum sunt voluptas cum.", 1, "Saepe aliquid est neque eum harum explicabo." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "TestCases" },
                values: new object[] { 45L, "est", new DateTime(2023, 4, 26, 3, 57, 25, 661, DateTimeKind.Utc).AddTicks(4357), 34L, "Quo harum architecto ut accusantium.", "Sint repellendus non non.", "Id illum omnis consequatur eum animi labore et perferendis. Inventore aut sunt ut cum sunt. Amet dicta similique qui voluptatem sit nihil voluptatem ex aut. Velit ipsum repellat ut qui natus odit. Minima cum facere velit ad quibusdam qui. Aut consequatur dolorem et provident a vitae sed est." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 63L, "Iusto tempore exercitationem expedita fuga.", new DateTime(2022, 11, 28, 16, 13, 16, 156, DateTimeKind.Utc).AddTicks(1952), 14L, "sed", "Velit non et ratione.", 0, "Et non voluptas architecto et sunt praesentium non." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 40L, "occaecati", new DateTime(2023, 7, 25, 22, 51, 43, 612, DateTimeKind.Utc).AddTicks(5367), 12L, "quia", "Et vel et maiores soluta esse excepturi ut.", 0, "Harum officia eos debitis et neque. Et qui ut enim nihil. Odit ut a impedit." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 56L, "non", new DateTime(2021, 5, 28, 12, 51, 39, 159, DateTimeKind.Utc).AddTicks(8836), 28L, "Accusamus accusantium sunt. Impedit ab ut possimus asperiores qui. Qui neque praesentium et reprehenderit vel et facere fuga laudantium. Quasi dolore repellendus occaecati. Nihil ut voluptatem. Quia voluptate aut aut.", "Non et sapiente tempora qui voluptatem blanditiis.", 0, "Corporis impedit et deserunt eum quos esse. Et quo ipsa dignissimos dolorem facere sint. Vel cum placeat veritatis natus qui veniam et ut. Id nihil fugiat qui quaerat aut. Sint ea sed qui fuga illo quis eum corrupti atque. Iure occaecati inventore iure aut et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 8L, "Perferendis sapiente voluptate.\nMolestiae eum qui cumque.\nSed laborum debitis ea laborum.", new DateTime(2018, 9, 27, 0, 13, 6, 305, DateTimeKind.Utc).AddTicks(8336), 12L, "Natus eligendi reiciendis eum at consequuntur praesentium. Voluptas et et. Quaerat recusandae dicta omnis modi illum enim. Sit maiores voluptas deleniti eaque debitis vero asperiores. Maiores est et repellat dolorem libero et aperiam culpa.", "Labore corrupti id qui qui nesciunt qui laborum nihil.", 1, "cum" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 24L, "Amet aut omnis sunt natus et. Labore voluptatibus repudiandae necessitatibus suscipit inventore unde. Veritatis ipsam sed qui similique eos ullam minus dolores accusamus. Eum laboriosam itaque placeat incidunt blanditiis suscipit sapiente earum. Iusto accusantium illo tempore aut consequuntur.", new DateTime(2023, 5, 1, 9, 57, 37, 137, DateTimeKind.Utc).AddTicks(3263), 28L, "Et eum porro ab alias nesciunt.", "Recusandae eveniet et fugit velit error voluptatem.", 1, "Animi quo autem incidunt ut magnam qui expedita. Dolore necessitatibus autem minima nihil porro et minima corporis ut. Et repellat explicabo est quas fuga nostrum voluptatem. Mollitia perferendis voluptatem qui et enim. Aut odit deserunt." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 7L, "Deserunt illum est et. Eos est consequuntur consequatur saepe voluptatum id. Commodi eligendi ut temporibus. Corporis veritatis unde recusandae tempore facilis incidunt iure tempore. Debitis eaque voluptas rerum est est dolor neque id similique.", new DateTime(2022, 1, 7, 0, 2, 16, 269, DateTimeKind.Utc).AddTicks(7096), 28L, "Illo deserunt sint qui qui provident provident modi ab magnam.\nSed dolore recusandae molestias est nulla culpa sed cupiditate.\nQuaerat incidunt quia quasi quia sit est dolorem harum eos.", "Laborum amet quo blanditiis nesciunt dolorum officiis et.", 2, "Ut est quod dolores. Perspiciatis sunt laudantium aliquid dicta culpa expedita. Cumque expedita ratione magni in dolorem consectetur." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 55L, "Inventore officiis accusantium sit aut veniam est illum ab. Eum quo quia est. Quo et ut dolor eum facilis nobis quasi. Quo a dolorem perferendis accusamus.", new DateTime(2023, 3, 27, 21, 40, 58, 99, DateTimeKind.Utc).AddTicks(6576), 15L, "Magni eos autem non et et vel voluptas nisi. Deserunt odio neque voluptatem. Explicabo id suscipit.", "Qui soluta id.", 2L, 3, "Et debitis impedit. Excepturi nostrum numquam rerum blanditiis porro amet similique sint. Laborum asperiores quam molestiae laborum reprehenderit ipsa cupiditate eos. Aut qui rem nulla sed. Hic ad provident est modi ducimus itaque." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "TestCases" },
                values: new object[] { 3L, "rerum", new DateTime(2023, 7, 13, 14, 11, 26, 5, DateTimeKind.Utc).AddTicks(4358), 18L, "et", "Molestiae et perferendis in nihil.", "dignissimos" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 30L, "Soluta aut cum hic labore accusantium cum atque. Vero magnam quia. Dolorum non maiores iste nostrum. Sit officiis maxime eius dolorum odio adipisci commodi voluptatem. Iusto animi repudiandae voluptatem ratione nihil error excepturi sint. Consequatur dolorem sapiente neque repellendus quis officiis.", new DateTime(2020, 7, 15, 8, 49, 21, 845, DateTimeKind.Utc).AddTicks(2064), 36L, "magni", "Dolorum vitae voluptatem rerum distinctio eos in quibusdam.", 2L, 0, "Officiis sit molestias accusantium. Accusamus itaque distinctio illo molestias ipsa distinctio velit eligendi. Quaerat suscipit earum neque velit delectus voluptatum quidem. Possimus pariatur repudiandae culpa iusto magnam error ex." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "TestCases" },
                values: new object[] { 70L, "Incidunt dolorem cum aspernatur qui rem unde laboriosam.", new DateTime(2023, 7, 28, 12, 5, 24, 874, DateTimeKind.Utc).AddTicks(2200), 1L, "Ut et qui consequuntur et voluptas. Sunt repudiandae quos velit nesciunt nemo rerum ducimus quo. Consequatur eveniet ullam doloremque et quia ut quos magni provident. Quia officia enim inventore ut temporibus ad quam occaecati.", "Libero dicta impedit quo autem numquam.", 2L, "Qui et impedit esse esse velit. Culpa necessitatibus temporibus qui voluptates voluptatem sequi. Doloribus in esse. Optio omnis quia et dolorum quas. Alias molestiae enim dolore nisi odit tenetur et aliquam dolorem. Tempore exercitationem excepturi quia harum deserunt earum velit repudiandae et." });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 31L, "et", new DateTime(2023, 3, 5, 16, 26, 54, 572, DateTimeKind.Utc).AddTicks(5136), 35L, "quo", "Fugiat non aut velit temporibus.", 2, "beatae" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "Status", "TestCases" },
                values: new object[] { 35L, "debitis", new DateTime(2023, 8, 16, 13, 3, 32, 602, DateTimeKind.Utc).AddTicks(7382), 10L, "Ipsum perspiciatis veniam.", "Quod molestias ad occaecati cum temporibus.", 1, "ab" });

            migrationBuilder.UpdateData(
                table: "ChallengeVersions",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "Status", "TestCases" },
                values: new object[] { 50L, "Quo nobis dolorum quibusdam. Aut quas nostrum. Minus aut laboriosam iusto id consequatur deleniti nobis odit eum.", new DateTime(2023, 6, 21, 7, 57, 28, 267, DateTimeKind.Utc).AddTicks(8375), 11L, "Natus occaecati quia omnis qui.\nTempore repellendus voluptatem.\nUt neque dolorem perspiciatis enim fuga nostrum hic quidem officia.", "Molestiae quia optio.", 1L, 2, "Laudantium ipsum odio est porro et culpa est." });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[,]
                {
                    { 71L, 6L, "neque", new DateTime(2023, 5, 11, 4, 3, 0, 271, DateTimeKind.Utc).AddTicks(6821), 34L, "Inventore et vero vel. Aut porro aspernatur aut ut quas vero. Sit quia recusandae blanditiis dolorum rerum voluptas sint. Autem similique consequatur non consequuntur.", "Est illum nobis beatae eos asperiores velit aut iusto.", 1L, "", 1, "autem" },
                    { 78L, 64L, "Labore pariatur voluptatem nemo.", new DateTime(2020, 10, 22, 18, 27, 42, 723, DateTimeKind.Utc).AddTicks(6244), 8L, "Impedit rerum error nemo magni possimus veritatis occaecati dolores non.\nSequi quas cumque dignissimos necessitatibus voluptatibus et cumque molestias.\nPariatur praesentium distinctio.\nHic provident enim facilis suscipit assumenda nisi laborum optio quia.\nMollitia assumenda ab quibusdam at hic quidem quo aperiam accusamus.\nNam culpa ab quisquam et qui blanditiis autem vero.", "Sit omnis repudiandae.", 1L, "", 1, "Earum cumque ea." },
                    { 80L, 70L, "Odio quos nisi accusantium et eligendi.\nSit corrupti placeat fugit harum minima.\nQuod dignissimos vero illo consequatur eligendi soluta commodi non.\nVoluptatem nam quo.", new DateTime(2023, 6, 24, 0, 45, 14, 549, DateTimeKind.Utc).AddTicks(1634), 15L, "Delectus sit officiis. Voluptatibus et aut animi consequatur atque magni earum quia dolor. Itaque laborum non voluptatem. Aut in provident culpa ex dolorum omnis odio. Aut inventore id similique velit. Rerum ipsa blanditiis aspernatur rerum repellat distinctio.", "Quia officia et earum non iure necessitatibus.", 1L, "", 1, "Earum harum quas laboriosam corrupti natus ad sint dignissimos beatae. Aut quaerat consequuntur voluptatum sunt nemo explicabo. Assumenda non fugiat sunt." },
                    { 82L, 57L, "voluptate", new DateTime(2023, 9, 6, 19, 58, 24, 681, DateTimeKind.Utc).AddTicks(439), 5L, "ad", "Quidem occaecati totam.", 1L, "", 3, "Impedit sunt alias adipisci natus voluptatem accusamus. Corrupti sunt est voluptate enim. Est numquam neque cupiditate aut officiis necessitatibus inventore qui non. Occaecati unde cumque facere cupiditate cupiditate fugiat." },
                    { 85L, 67L, "commodi", new DateTime(2023, 1, 29, 3, 6, 26, 680, DateTimeKind.Utc).AddTicks(3930), 28L, "Id reprehenderit iusto perspiciatis iusto molestiae.\nVel impedit sapiente voluptate cupiditate non odit quo.\nLibero at voluptates consectetur aut soluta.\nDignissimos voluptas tempore reprehenderit nemo.\nEst qui aut non in a dolor perferendis voluptate.\nCumque reprehenderit et asperiores aut mollitia.", "Ducimus cumque itaque.", 2L, "", 0, "Occaecati natus ea laboriosam." },
                    { 87L, 8L, "Consequatur perspiciatis aut qui harum perspiciatis omnis.\nUt deleniti mollitia vero natus corporis et enim corrupti.\nAtque officiis repellat animi maiores modi cumque.", new DateTime(2017, 12, 19, 15, 37, 35, 991, DateTimeKind.Utc).AddTicks(4165), 38L, "Distinctio harum sint deleniti sint modi ut consequuntur dicta.", "Est voluptas ut aut molestiae reprehenderit nesciunt dolore.", 2L, "", 2, "doloremque" },
                    { 88L, 43L, "sed", new DateTime(2023, 8, 28, 7, 44, 18, 836, DateTimeKind.Utc).AddTicks(9356), 17L, "Qui aliquam mollitia voluptate illo eveniet ex.", "Quia maiores laboriosam et.", 1L, "", 2, "Totam iste non.\nCulpa eligendi voluptatum sint amet eveniet et.\nVitae vel rerum vitae saepe ratione ea aut quis.\nAb praesentium repellendus ab porro.\nNon corporis quod asperiores et corrupti perferendis ea aut." },
                    { 97L, 39L, "Autem veritatis tempore minima repellat tenetur aspernatur.", new DateTime(2023, 2, 11, 7, 29, 57, 937, DateTimeKind.Utc).AddTicks(5416), 8L, "Non et perspiciatis quaerat unde reprehenderit qui et hic est.\nSed sit facere.", "Consequuntur et temporibus ipsa.", 1L, "", 1, "Rem libero et.\nNisi culpa consequatur et et tenetur.\nNihil laboriosam quidem nesciunt libero velit quidem quia.\nMolestiae voluptas rerum nulla praesentium.\nUt illum id maiores dolores et sequi quas." },
                    { 99L, 21L, "Animi qui cumque ipsam ut perferendis ducimus dolorem.\nLaboriosam autem illo quia eius dolore eum reprehenderit ducimus non.", new DateTime(2023, 3, 5, 16, 39, 59, 882, DateTimeKind.Utc).AddTicks(5869), 35L, "voluptas", "Aut hic itaque sint ut laudantium dignissimos.", 1L, "", 3, "Cumque qui illo soluta sint rem qui quo." },
                    { 102L, 10L, "sequi", new DateTime(2022, 8, 19, 12, 9, 0, 811, DateTimeKind.Utc).AddTicks(8242), 26L, "eos", "Dolore quaerat eius aut qui libero repellat et ipsa dolor.", 1L, "", 1, "Ipsam cupiditate et velit ut qui voluptatum porro." },
                    { 103L, 54L, "Sed possimus deleniti eveniet modi similique molestiae libero.\nTotam perspiciatis perferendis excepturi non sed.\nEst aliquam labore ea corrupti.\nBlanditiis deleniti ut error qui.\nEt similique qui.\nVoluptate omnis excepturi eum eum corporis.", new DateTime(2023, 2, 16, 19, 49, 23, 652, DateTimeKind.Utc).AddTicks(6558), 15L, "Vitae eum facere aliquam quod dolorem minus. Voluptas a sit deserunt est. Nostrum consequatur ratione earum voluptatum eius. Nihil laborum doloribus esse sit corrupti quia quidem illo illo. Neque et est officia porro dicta rerum voluptas quaerat.", "Quia quidem aut fugiat consectetur ut et ab maxime.", 2L, "", 1, "Dolores ad vero explicabo. Quia nam voluptatem voluptatem minima corrupti quia et non. Corporis alias omnis distinctio sed eum omnis molestiae perferendis eos. Minus perferendis minus ut totam laboriosam eum. Asperiores asperiores animi iure. Et temporibus eveniet rerum quis sapiente vitae." },
                    { 104L, 28L, "corporis", new DateTime(2023, 1, 15, 18, 36, 42, 92, DateTimeKind.Utc).AddTicks(8794), 18L, "Molestiae numquam assumenda nihil explicabo. Ullam ratione a. Rerum amet et assumenda consectetur. Est neque labore. Cupiditate vel temporibus enim qui a dolore ut doloribus est. Ut non perferendis eius molestiae nihil est eum facere voluptas.", "Voluptatum aliquid voluptatum vel.", 1L, "", 1, "Autem assumenda omnis quo voluptate laboriosam laborum quo." },
                    { 107L, 70L, "Recusandae autem et sunt nulla assumenda ipsum placeat.", new DateTime(2023, 3, 9, 3, 12, 31, 107, DateTimeKind.Utc).AddTicks(1835), 28L, "Impedit culpa hic vel molestiae sint dolores.", "Rem aut repellat voluptatem quaerat.", 2L, "", 1, "sapiente" },
                    { 111L, 64L, "Sunt et ipsa.", new DateTime(2020, 11, 14, 10, 51, 9, 872, DateTimeKind.Utc).AddTicks(1140), 1L, "Quaerat distinctio nobis officiis vel.\nTotam perspiciatis voluptate fugiat.\nNostrum hic quos in doloribus quas ipsa.\nEveniet cum exercitationem esse.", "Eligendi dolor quasi veniam recusandae.", 1L, "", 3, "Perspiciatis et atque consequatur minus." },
                    { 112L, 66L, "Quibusdam corrupti neque voluptate ut perferendis autem illo aperiam.", new DateTime(2023, 1, 24, 13, 29, 54, 852, DateTimeKind.Utc).AddTicks(3278), 1L, "Modi minus laudantium. Qui asperiores qui voluptatum consequatur necessitatibus. Similique dignissimos aut amet magni. Est eveniet perspiciatis. Quia ipsam odio distinctio in laborum laborum ab autem rerum. In eligendi sunt possimus.", "Earum ex illo exercitationem modi sit aperiam aspernatur velit.", 2L, "", 0, "Eligendi deleniti nobis laborum delectus et blanditiis." },
                    { 113L, 7L, "Quasi ex eos sit esse accusantium vel debitis eum. Nihil sunt magnam. Asperiores placeat provident.", new DateTime(2020, 6, 28, 10, 24, 24, 162, DateTimeKind.Utc).AddTicks(3523), 6L, "Ut accusantium amet numquam iste accusamus dolorem.\nOmnis iste laboriosam tempore.\nNon quidem non.", "Libero id adipisci quia eaque qui nihil.", 1L, "", 1, "Architecto animi debitis eveniet reprehenderit ut." },
                    { 114L, 37L, "blanditiis", new DateTime(2022, 4, 28, 16, 0, 31, 139, DateTimeKind.Utc).AddTicks(184), 31L, "Rerum architecto aut modi ex sunt architecto. Est velit dolor hic vitae quas accusantium ut nam eos. Vel minus in. Soluta non consequatur reprehenderit eveniet praesentium et.", "Ab asperiores ea nesciunt ipsum.", 1L, "", 3, "Dolor ad laboriosam ex non quia sit vel.\nEst velit reiciendis sunt possimus a iure et quis labore.\nEa sed velit magnam reiciendis adipisci.\nIn cumque aut assumenda aut vitae harum necessitatibus voluptas." },
                    { 118L, 31L, "Architecto consequatur qui molestiae a et facilis voluptas voluptas numquam.\nQuia possimus occaecati eos in cum.", new DateTime(2023, 8, 16, 11, 52, 29, 910, DateTimeKind.Utc).AddTicks(1739), 10L, "Velit nulla quia.", "Sed corrupti dolorem.", 1L, "", 0, "Voluptatem totam ex commodi nisi occaecati minus magni et autem." },
                    { 119L, 56L, "et", new DateTime(2020, 2, 29, 10, 46, 41, 176, DateTimeKind.Utc).AddTicks(9298), 32L, "Explicabo ipsam distinctio enim consequuntur velit libero consequuntur aliquam vero. Facilis quibusdam magnam consequatur repudiandae voluptate porro rerum molestiae nisi. In et molestiae qui quisquam. Corrupti placeat dignissimos qui veniam dignissimos veniam magni pariatur. Sed dolor dolorum reiciendis iste voluptatum nihil quibusdam voluptas dolores. Id quia dolorem sapiente sit.", "Et debitis et voluptatem provident amet quis est.", 2L, "", 2, "Sapiente voluptatum porro dignissimos odit voluptates tempora quis. Totam in eos minima voluptas et ipsa molestiae autem. Excepturi quaerat et deserunt quis aut. Suscipit ea dignissimos rerum maxime et est provident rerum." },
                    { 120L, 16L, "quam", new DateTime(2022, 10, 16, 6, 35, 50, 239, DateTimeKind.Utc).AddTicks(5524), 19L, "facilis", "Est eveniet quidem molestias velit aliquid ea ex ut ut.", 1L, "", 2, "Consequatur quod aspernatur odio consequuntur corporis tempora molestias facere.\nAd fuga hic et corrupti reprehenderit illo facilis.\nQuos est laboriosam ab.\nQuasi iusto corrupti.\nDoloremque tempore cumque similique quaerat cupiditate ad." },
                    { 121L, 57L, "vitae", new DateTime(2022, 7, 16, 10, 32, 38, 579, DateTimeKind.Utc).AddTicks(4677), 20L, "quis", "Aut eos qui velit iste deleniti nulla aut omnis laudantium.", 2L, "", 2, "eligendi" },
                    { 123L, 53L, "Maiores ad et eos quo. Officia voluptatem et est numquam et reiciendis quae ut asperiores. Ut in explicabo. Optio tempore voluptas et a eos maiores aut laborum. A qui ipsa repellat possimus voluptatibus.", new DateTime(2023, 5, 21, 8, 21, 20, 689, DateTimeKind.Utc).AddTicks(1955), 27L, "aut", "Odit accusantium nam aut et exercitationem quam.", 1L, "", 0, "Nihil molestiae enim molestiae nemo est. Dolorum voluptatibus expedita. Architecto nihil excepturi totam. Animi modi rerum facere eaque. Voluptatem illum ut aliquam cum itaque quae." },
                    { 124L, 34L, "Nemo sed enim sunt quo sequi.", new DateTime(2023, 3, 26, 18, 22, 43, 913, DateTimeKind.Utc).AddTicks(4146), 14L, "Saepe sunt deleniti a.\nTempore dolorem aut voluptas reiciendis et rem aperiam vel.\nQuasi similique alias laborum eius.\nBeatae cumque sit.\nMaxime labore pariatur qui voluptatem et sunt.\nEum consequatur voluptas quia temporibus ipsa quia et necessitatibus dicta.", "Placeat provident necessitatibus voluptates et alias.", 2L, "", 3, "Voluptate illum omnis quos distinctio ab recusandae aut sunt. Est beatae sit exercitationem voluptas ut ut at est. Nulla autem animi optio esse a quisquam commodi. Sit maiores magnam vel eveniet." },
                    { 125L, 61L, "reprehenderit", new DateTime(2023, 7, 5, 5, 28, 41, 555, DateTimeKind.Utc).AddTicks(2069), 39L, "Veritatis unde libero atque est aut.", "Sit et eveniet odit harum beatae vel iure.", 2L, "", 3, "et" },
                    { 127L, 31L, "Delectus minima reiciendis quam id ad nisi aut voluptatibus cupiditate.", new DateTime(2023, 4, 28, 14, 1, 3, 637, DateTimeKind.Utc).AddTicks(143), 35L, "At eum quaerat ducimus. Nihil dolores ipsam quos quam ea et et et praesentium. Est et consequatur.", "Nulla quas quam quis nihil possimus nobis.", 2L, "", 3, "delectus" },
                    { 130L, 35L, "Aspernatur possimus ea maiores amet. Sunt doloribus aut est fugiat et vel autem. Excepturi enim voluptates tempora ullam vero aut dolores. Qui eaque soluta voluptatibus rerum. Voluptate eius ipsa consequatur optio totam et quibusdam ut neque. Maiores odio exercitationem soluta sapiente error.", new DateTime(2023, 5, 20, 14, 7, 56, 267, DateTimeKind.Utc).AddTicks(1181), 3L, "Sed rerum assumenda voluptatum temporibus sint blanditiis voluptate. Omnis occaecati sed impedit quia. Perspiciatis qui ipsum qui rerum unde aut. Iure consectetur autem. Quia aut quia id quidem. Quia inventore ea corrupti tempore sed architecto.", "In earum nobis quia optio at inventore.", 2L, "", 0, "Qui ratione nam occaecati. Doloribus quaerat ipsa aliquam ratione asperiores. Ut saepe veniam laborum sunt quis aspernatur. Eos rem earum veritatis." },
                    { 131L, 3L, "sunt", new DateTime(2023, 9, 6, 13, 32, 52, 660, DateTimeKind.Utc).AddTicks(89), 39L, "Iure voluptatem non illo voluptatem ut maxime placeat veritatis doloribus. Sit aliquid ea. Architecto sit dicta impedit similique. Sed et eum aut eum. Quo possimus consectetur ut. Ipsum ut alias.", "Iure voluptatibus dolore non sed saepe et incidunt sed.", 2L, "", 3, "Repellat labore magni exercitationem illo." },
                    { 133L, 3L, "Et iusto quia.", new DateTime(2023, 8, 27, 8, 23, 3, 529, DateTimeKind.Utc).AddTicks(460), 11L, "Non quibusdam et corrupti aut laborum sequi maxime et voluptas. Libero et voluptatem aut et sunt amet. Beatae dolores laboriosam est et quo accusantium aut cupiditate.", "Eos id cupiditate blanditiis aut maiores pariatur.", 2L, "", 1, "Culpa animi dolorem nulla quae at incidunt qui unde iure.\nEt asperiores quis sed ad temporibus officia et.\nAb inventore voluptates autem culpa." }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[,]
                {
                    { 134L, 50L, "Autem quis accusantium voluptatem.", new DateTime(2023, 9, 8, 20, 47, 22, 14, DateTimeKind.Utc).AddTicks(5147), 38L, "vitae", "Quis placeat voluptatem incidunt repellat.", 2L, "", 1, "tempore" },
                    { 135L, 14L, "Et enim accusamus quis est tempora maxime eos consectetur rem.\nNihil ut fuga mollitia sint ex at dignissimos nulla quia.", new DateTime(2023, 1, 29, 19, 19, 22, 954, DateTimeKind.Utc).AddTicks(2049), 31L, "Aut amet quia omnis harum asperiores. Nisi ratione fuga. Ea ut dolorem dignissimos delectus voluptatum aspernatur rerum sit. Rem qui placeat deleniti distinctio vero temporibus aliquam animi quasi.", "Accusamus voluptatem ducimus est omnis minus.", 1L, "", 3, "Rerum et animi officiis blanditiis eius est quas id. Cupiditate impedit sit eum vel vero. Nulla quia laudantium. Est ut non." },
                    { 139L, 61L, "Et ut illo maiores quas rem facilis.\nAb rerum non est unde minima corrupti aut quidem similique.", new DateTime(2023, 5, 4, 9, 28, 23, 368, DateTimeKind.Utc).AddTicks(2467), 12L, "Autem illum qui velit est.\nExercitationem consequatur voluptas ut illo ipsa dolores perferendis.", "Quam doloribus minima vel rerum reprehenderit distinctio adipisci.", 2L, "", 1, "Similique expedita dolorum excepturi voluptas ad.\nDolorem ut sequi perferendis ab.\nVoluptatibus quia dolorem nostrum excepturi error et qui inventore.\nNon eius minus aut blanditiis eum voluptatem et maiores.\nAspernatur vitae ipsam et voluptatum." },
                    { 142L, 19L, "Perferendis eaque cumque.\nDolore nisi optio.\nDolorem iste dolorum placeat eaque rerum.\nVoluptas eaque magnam sunt itaque.\nAt et est quasi dicta repudiandae eligendi ut.\nEst culpa ad ex velit voluptatem quas nemo est eos.", new DateTime(2022, 7, 29, 4, 7, 48, 667, DateTimeKind.Utc).AddTicks(3890), 22L, "Eos error esse quaerat dolorem quae.", "Facilis non iste ullam illum a exercitationem vel iure.", 1L, "", 0, "Dicta nemo consequatur voluptatem accusamus est ut est eos sunt.\nIn nesciunt iure aut sit neque et alias voluptatem officiis.\nIpsa rem soluta placeat voluptas qui qui animi tempora." },
                    { 143L, 25L, "Ut quia eius ut suscipit culpa sed veniam.", new DateTime(2023, 1, 22, 2, 16, 32, 51, DateTimeKind.Utc).AddTicks(1473), 38L, "Molestiae exercitationem qui iste possimus laboriosam iure.\nAlias eligendi voluptatem aperiam architecto est impedit eligendi nostrum odio.\nEt cum et.", "A ipsa quidem provident nostrum corrupti.", 2L, "", 0, "ipsa" },
                    { 144L, 24L, "Impedit ut molestiae.\nIncidunt voluptatem vero velit deserunt eos id molestiae unde necessitatibus.", new DateTime(2021, 9, 23, 11, 31, 17, 715, DateTimeKind.Utc).AddTicks(8427), 29L, "Et eligendi sapiente debitis voluptatem et.\nPossimus ut non enim qui sint nam iure excepturi non.\nProvident qui fugit earum id.", "Et aut eos aut distinctio eum doloremque maxime vel aut.", 1L, "", 2, "Voluptatum voluptate fugiat explicabo laudantium fugit necessitatibus." },
                    { 145L, 22L, "Ut optio totam temporibus et saepe dolore accusantium.", new DateTime(2023, 4, 5, 2, 21, 4, 356, DateTimeKind.Utc).AddTicks(5399), 32L, "est", "Deserunt vitae officiis officia vero sit neque.", 1L, "", 0, "Impedit hic et quidem." },
                    { 146L, 65L, "veritatis", new DateTime(2023, 7, 20, 14, 12, 29, 825, DateTimeKind.Utc).AddTicks(4001), 25L, "Est ducimus at eos deserunt porro beatae tempore.\nTemporibus quos natus est.\nDucimus consequatur neque molestiae cupiditate corrupti necessitatibus.", "Quia et dolor autem ducimus iusto eos veritatis facilis.", 1L, "", 0, "Quo sed voluptas sit quo earum ipsam quasi." },
                    { 147L, 27L, "Repellat qui repellat totam molestiae qui iure quia.\nNisi iste porro voluptatum voluptatem magni voluptatem facilis aut vero.\nVeniam cupiditate libero aliquam expedita iusto cumque voluptas.\nOdit qui repellat inventore vero ducimus tempora dolorem sapiente mollitia.", new DateTime(2023, 2, 10, 8, 18, 6, 207, DateTimeKind.Utc).AddTicks(907), 21L, "Distinctio nihil vel.\nVoluptatum sint quod consequatur quos odio.", "Autem fugiat modi soluta tempore.", 2L, "", 3, "Vitae alias nulla ab eius aut fugit." },
                    { 149L, 62L, "Explicabo ut quis vero at voluptate dolores facere ea ut.\nDolorem voluptas mollitia natus provident enim.\nMinima quos laboriosam et impedit debitis dignissimos.", new DateTime(2022, 10, 23, 8, 10, 7, 36, DateTimeKind.Utc).AddTicks(1270), 10L, "perferendis", "Ex et adipisci.", 1L, "", 3, "Repellendus impedit sint aspernatur nam." },
                    { 151L, 68L, "Et modi laborum quidem. Quia rerum consectetur doloremque et voluptate tempore non mollitia quae. Ut neque id enim maxime. Sint recusandae qui ipsam. Quod exercitationem sapiente perferendis aliquid animi alias aliquam.", new DateTime(2023, 7, 4, 14, 59, 21, 422, DateTimeKind.Utc).AddTicks(6787), 35L, "Laudantium totam dolores perspiciatis repellendus quia neque.", "Provident quo possimus error quae tempora inventore voluptate.", 1L, "", 0, "adipisci" },
                    { 152L, 6L, "Et rerum rerum ut eveniet et voluptates illo.", new DateTime(2023, 6, 22, 20, 53, 31, 711, DateTimeKind.Utc).AddTicks(4183), 30L, "Nesciunt officiis fuga eos et dolore harum dolores consequatur.", "Reprehenderit qui blanditiis necessitatibus.", 1L, "", 2, "cupiditate" },
                    { 153L, 1L, "Eveniet dolorem similique animi. Officiis et sunt impedit fuga eos. Fugiat dolorum aliquam est non aliquam quia accusamus. Iste et neque. Consequatur eos explicabo et aut aut.", new DateTime(2023, 2, 17, 4, 19, 20, 189, DateTimeKind.Utc).AddTicks(4971), 21L, "Sit dolorem error assumenda iure doloribus iure nihil quidem. Minima alias quam iure voluptate dolorem occaecati corrupti cupiditate. Ut rerum ducimus dignissimos quidem ut quaerat assumenda vitae.", "Assumenda sapiente voluptatem unde consequatur.", 2L, "", 3, "Qui ipsam incidunt est sequi quaerat quod eos. Aspernatur animi impedit nihil voluptatem. Et laboriosam aut nihil facilis modi laboriosam et. Consequuntur libero id ut ipsum minus. Nesciunt quasi consectetur saepe itaque quam error aut." },
                    { 154L, 47L, "Explicabo dolor debitis quasi assumenda quas provident deserunt.\nLaborum reprehenderit ea.\nPerspiciatis autem quia magni sequi minus dolorum laboriosam eos vero.\nAtque quasi incidunt voluptas voluptatibus neque.", new DateTime(2022, 3, 5, 10, 24, 22, 404, DateTimeKind.Utc).AddTicks(3317), 23L, "modi", "Vitae nulla ea minima.", 2L, "", 2, "omnis" },
                    { 156L, 42L, "Rerum eos nobis sapiente quis sunt non et ut. Ut laudantium enim laboriosam nulla repellat fuga sunt ut et. Facilis quaerat quia minima saepe minus soluta qui. Cupiditate sint cum non ipsa voluptates.", new DateTime(2023, 5, 28, 17, 8, 48, 882, DateTimeKind.Utc).AddTicks(8589), 39L, "Aliquid temporibus vel ullam recusandae quasi.\nUllam ipsum ratione consectetur voluptate soluta consequatur.\nRepudiandae illum dignissimos nesciunt quas.\nLabore perferendis aut quod nemo.\nUt ipsam aliquam quaerat vero ut.\nCorrupti numquam mollitia et.", "Distinctio culpa aliquid.", 1L, "", 1, "Explicabo quas sed ut culpa quo alias reiciendis repudiandae. Distinctio tenetur voluptatem cum. Consequuntur corporis animi deleniti nobis deleniti voluptas dolore." },
                    { 158L, 40L, "Ut sunt ut esse et.\nIncidunt quia impedit id enim et et vel.", new DateTime(2023, 3, 8, 15, 13, 37, 877, DateTimeKind.Utc).AddTicks(3146), 15L, "aut", "Voluptates velit animi quod voluptas qui quisquam a.", 2L, "", 3, "Ut vel ipsa ut consectetur sunt.\nLibero libero voluptatem et.\nOfficiis ut quod laborum accusantium deleniti.\nVoluptas quod rerum fuga velit occaecati." },
                    { 159L, 57L, "Alias alias placeat.", new DateTime(2022, 12, 9, 21, 35, 1, 127, DateTimeKind.Utc).AddTicks(5327), 23L, "Voluptas asperiores quia quia non quisquam.", "Magnam maiores eos ratione.", 1L, "", 0, "Quibusdam quo adipisci provident perferendis officia eveniet beatae id qui. Amet voluptas eum. Error mollitia aspernatur. Ut aperiam sequi dolorum omnis aut totam sunt." },
                    { 160L, 37L, "ut", new DateTime(2023, 1, 15, 5, 46, 58, 538, DateTimeKind.Utc).AddTicks(2232), 38L, "Sit laudantium mollitia ut minus sapiente aut.\nDistinctio quibusdam facere quos unde veniam iusto ut.\nAspernatur et quia dolorem dolores laudantium ipsa commodi.\nAperiam fuga quaerat beatae inventore.\nQui consequatur vel repellat.", "Dolores corrupti cupiditate ut tempore corporis.", 2L, "", 3, "Est dicta unde tenetur facilis eius." },
                    { 161L, 1L, "Dignissimos vel occaecati alias iste est iure molestiae eum quis. Id culpa ipsa perspiciatis ut iusto commodi. Nemo impedit perspiciatis quos.", new DateTime(2023, 9, 11, 17, 52, 27, 301, DateTimeKind.Utc).AddTicks(8622), 35L, "Dolore incidunt excepturi quia aut itaque.", "Velit quia nobis voluptates aspernatur aut fugit illo.", 1L, "", 2, "nostrum" },
                    { 162L, 25L, "Dolorem vel minima ut necessitatibus iusto quo velit. Qui eligendi officiis dolorem. Et in aperiam et eaque odio. Et et optio ut consectetur aliquam. Magnam qui est voluptas fugiat sint ad consequuntur eveniet.", new DateTime(2023, 7, 23, 7, 53, 57, 747, DateTimeKind.Utc).AddTicks(8298), 29L, "Dolor facere quaerat voluptatem ea.", "Voluptates in perferendis minima ullam eum iusto odit accusamus iste.", 1L, "", 2, "minus" },
                    { 163L, 64L, "vero", new DateTime(2020, 4, 10, 15, 55, 34, 99, DateTimeKind.Utc).AddTicks(1204), 11L, "sapiente", "Et ut nemo culpa et qui quidem optio.", 1L, "", 1, "Consequatur eaque et sed tempore et. Amet laborum sequi animi corrupti est autem eos inventore et. Perspiciatis facere illo praesentium. Quia optio eius ipsam rem eaque et. Fugiat amet aut tenetur commodi atque." },
                    { 164L, 39L, "Odio dignissimos molestias blanditiis amet praesentium ratione consequatur qui voluptas. Voluptas nihil et sunt omnis. Nisi pariatur id non sint. Id a odit cumque in ut.", new DateTime(2023, 2, 3, 14, 8, 50, 19, DateTimeKind.Utc).AddTicks(1306), 17L, "Et autem in sed consequuntur placeat voluptas in corporis voluptas. Unde illum perspiciatis voluptatem. Sit praesentium in autem in et. Repellat dicta qui aut recusandae.", "Sunt quaerat non est rerum ad rerum ea.", 2L, "", 1, "Voluptate quae et eaque quidem. Sit ducimus corporis aut aliquid rerum repellendus. Repellendus enim et excepturi eum inventore. Autem optio molestiae hic et dolores vitae possimus placeat qui." },
                    { 165L, 9L, "In sunt tenetur voluptas sit esse itaque perspiciatis a.", new DateTime(2020, 8, 25, 20, 41, 9, 319, DateTimeKind.Utc).AddTicks(6997), 5L, "Ipsam impedit nobis quae laboriosam omnis possimus cum eius.\nEt exercitationem necessitatibus ad expedita.\nNon laborum quisquam sunt eos ullam.\nReprehenderit qui ut eius sint nam ipsam possimus occaecati est.\nLaboriosam animi atque.\nOmnis voluptatem tempora modi quia.", "Maiores voluptate optio non eum quidem minus similique corrupti.", 2L, "", 0, "In ducimus qui.\nReprehenderit quo facere voluptas possimus recusandae delectus iste.\nQui et architecto voluptas rerum eum magni voluptatibus labore est.\nInventore ipsum ex dolores unde et expedita enim.\nVel sed vitae maiores.\nNisi vero id non alias totam quia qui at animi." },
                    { 166L, 64L, "id", new DateTime(2022, 7, 19, 10, 39, 21, 748, DateTimeKind.Utc).AddTicks(3640), 19L, "Illo et adipisci fugiat in eos rerum quia rem enim.\nQuia doloremque quae expedita.\nVoluptas fuga repudiandae ipsum quia et consectetur id cum dolor.\nQuia eius eveniet voluptatem et nemo aliquam esse aut magni.\nDolores voluptates ad nulla.\nVoluptatem autem voluptatibus excepturi adipisci.", "Consequatur quia doloribus saepe est sint.", 1L, "", 3, "Aut ut et perferendis et animi aspernatur." },
                    { 168L, 53L, "Numquam fuga facere quia est architecto.", new DateTime(2022, 2, 10, 4, 54, 39, 81, DateTimeKind.Utc).AddTicks(3846), 38L, "Id nihil sunt. Eum quas sunt quo aut maiores esse enim. Ut consequatur nihil saepe dolor. Qui quae quam eveniet aut sed aut qui reprehenderit aut. Distinctio assumenda et ut rem voluptatem molestiae et sed labore.", "Ratione molestias recusandae qui eos provident ea tempore.", 2L, "", 2, "Commodi quod voluptas laudantium excepturi et illo esse reprehenderit.\nOdit non dolore delectus." },
                    { 170L, 37L, "Ratione quia officiis nemo aliquid et et rerum alias molestias. Ut possimus consequuntur. Id maiores quam a omnis et sint neque. Praesentium incidunt adipisci dolor sed aut non.", new DateTime(2022, 9, 24, 4, 58, 36, 856, DateTimeKind.Utc).AddTicks(2136), 18L, "Molestiae consectetur accusamus in at quaerat quibusdam assumenda.", "Assumenda repudiandae eaque ratione est dolorem illo quos incidunt.", 1L, "", 1, "Aut rerum provident." },
                    { 171L, 61L, "Ut ullam temporibus ut facilis sit dolor ratione ut.", new DateTime(2023, 6, 15, 20, 15, 42, 105, DateTimeKind.Utc).AddTicks(7805), 21L, "Nobis aut ut nostrum impedit rerum omnis.\nAut suscipit ducimus commodi.\nCulpa nisi ut in nisi ut.\nHarum doloremque repellat hic officia et inventore tempore.\nSint rem qui sit animi dolores aspernatur quaerat.\nVoluptatem adipisci est ut ipsum nihil voluptatem quibusdam eos voluptatem.", "Officiis dolores quis harum quae nostrum nulla quia et.", 2L, "", 0, "Eaque distinctio et temporibus est nulla cum est libero animi. Qui quas dolorem ipsam corrupti ipsum. Nemo possimus unde placeat tenetur a aut quas quod. Minima corporis sequi illum odit. Dolore ut qui et nesciunt ad possimus. Nesciunt corporis eveniet suscipit omnis qui et." },
                    { 174L, 29L, "Ut sint cupiditate aperiam non cum consequuntur dolorem in.", new DateTime(2020, 10, 9, 14, 43, 13, 663, DateTimeKind.Utc).AddTicks(8453), 26L, "Incidunt neque ducimus qui rerum quo veritatis sit tempora.", "Atque ut blanditiis velit in.", 1L, "", 0, "Ut et a ex modi aut earum est fuga." },
                    { 175L, 7L, "Soluta et totam necessitatibus.", new DateTime(2022, 3, 12, 9, 6, 17, 537, DateTimeKind.Utc).AddTicks(3025), 31L, "Omnis sed eligendi fuga sequi.\nUnde et nesciunt aut et at eos aut sint.\nId consequatur quo consequatur et neque debitis aut voluptatem.", "Numquam quidem cum repudiandae sapiente sint aperiam quaerat fuga similique.", 1L, "", 1, "Quis commodi officia voluptatum autem esse.\nVel sequi maxime.\nEum enim nostrum ipsam officia nemo perferendis quo quia.\nAdipisci et dolorem rerum similique." },
                    { 176L, 8L, "Nesciunt excepturi voluptas sapiente.\nMagni numquam totam quia.", new DateTime(2021, 10, 1, 23, 31, 9, 299, DateTimeKind.Utc).AddTicks(3565), 3L, "Rem molestiae est sunt eos error expedita nam.\nQuia quos aut id.\nPariatur voluptas animi aut perferendis maxime autem.", "Fugiat est perferendis reprehenderit.", 2L, "", 3, "Inventore voluptatem natus maxime perferendis corporis." },
                    { 178L, 13L, "neque", new DateTime(2021, 4, 4, 18, 27, 48, 481, DateTimeKind.Utc).AddTicks(1354), 33L, "Aut voluptas eius eos amet occaecati consequatur accusantium consectetur consequuntur.\nAut quis neque voluptatem voluptatem.\nDignissimos aut culpa ea molestias harum voluptatibus.\nConsequatur laboriosam numquam.\nQuo adipisci voluptatum consequuntur ab maiores et.", "Aut ipsam ab quia hic dolores optio a quis.", 2L, "", 3, "Et nobis quidem." },
                    { 179L, 14L, "Adipisci porro eius. Autem eligendi labore consequuntur vel sit sequi. Ex recusandae saepe nulla labore dolor. Id velit culpa alias asperiores necessitatibus alias aut.", new DateTime(2023, 5, 7, 4, 40, 53, 940, DateTimeKind.Utc).AddTicks(3458), 28L, "Qui quod alias possimus voluptates. Laborum id ut ab deleniti dolorum. Veritatis sequi saepe accusantium tempora quidem.", "Molestias eum et quasi officiis nostrum.", 1L, "", 2, "earum" },
                    { 180L, 61L, "Recusandae eos recusandae temporibus error voluptatibus reprehenderit. Aut eum natus dolorem pariatur. Eaque quo ullam itaque odit in ab iure eaque nobis. Labore pariatur ipsum accusamus aperiam corrupti culpa quibusdam.", new DateTime(2023, 8, 27, 23, 12, 21, 815, DateTimeKind.Utc).AddTicks(4840), 16L, "vero", "Tempora impedit quis necessitatibus quia sit ducimus dolores.", 2L, "", 0, "Nostrum pariatur unde non aliquid voluptas molestias sit nam aut.\nReiciendis eos totam voluptatem velit maxime et.\nPerspiciatis aspernatur magnam quae voluptas dolores eius.\nQuasi saepe voluptatibus doloremque enim tenetur.\nQuam ducimus iure eveniet.\nQuisquam aut nihil." },
                    { 182L, 7L, "Voluptas nam reprehenderit ut consectetur laborum voluptatem amet sunt. Id ratione aspernatur suscipit. Ea eum est ipsum qui repudiandae rerum. Ut sit alias quas nulla quae. Amet atque maiores aut dolores. Qui aut est est vel rerum placeat aliquam.", new DateTime(2020, 2, 10, 9, 48, 6, 244, DateTimeKind.Utc).AddTicks(6137), 4L, "Nobis dolores nulla tenetur sed quia.\nEnim et quam dolores qui aut aut.\nQuo vel assumenda tempore eligendi.", "Doloribus quae cumque.", 2L, "", 0, "Officiis corrupti et nam ab quidem doloremque et a. Quia ut amet aut. Eos id repellat quia neque doloribus. Autem sapiente in eaque. Consequatur delectus dolores amet et autem dolore." },
                    { 183L, 33L, "Repellendus doloremque enim est.", new DateTime(2023, 9, 1, 21, 47, 8, 444, DateTimeKind.Utc).AddTicks(4338), 16L, "Aut esse omnis optio odit aut.", "Qui eaque eligendi odit earum atque veritatis quisquam illo et.", 2L, "", 2, "Est neque consequuntur.\nPorro esse deleniti a nam facere mollitia quia assumenda non.\nEx atque culpa quibusdam deleniti.\nSuscipit vitae a.\nIusto quia voluptatibus facilis nihil aut." },
                    { 185L, 55L, "Aut perferendis corrupti itaque fugit et est.\nEveniet praesentium delectus harum et ut magnam sapiente eos optio.\nError eligendi ducimus delectus numquam sequi adipisci.", new DateTime(2023, 1, 21, 8, 29, 9, 368, DateTimeKind.Utc).AddTicks(1383), 23L, "velit", "Minus possimus sint corrupti.", 2L, "", 0, "Facere possimus aperiam." },
                    { 186L, 23L, "Magni vel sint et quae ad dolor sint modi. Quia eos nihil hic modi commodi assumenda consequuntur. Et minus vero libero suscipit odit. Accusamus omnis veniam rerum non tenetur vel dolore necessitatibus animi.", new DateTime(2023, 8, 28, 7, 47, 22, 592, DateTimeKind.Utc).AddTicks(145), 35L, "In in inventore enim qui.\nUnde fugit voluptate incidunt quidem qui odit.\nPossimus dolor veritatis dolorum.\nEst quae aut dolore nobis velit velit sequi ut.\nRem dolorem id assumenda quia.\nAut consectetur et praesentium consequatur similique sapiente.", "Libero saepe ex nisi aperiam ut id voluptates quidem deleniti.", 2L, "", 1, "Quis iste quae.\nAliquam dolor quia laborum qui eum." },
                    { 187L, 30L, "Est autem recusandae et eveniet vel. Nam tenetur doloribus dignissimos nesciunt est beatae dicta incidunt et. Omnis voluptatem velit blanditiis necessitatibus. Ea ut omnis accusamus. Voluptatum illum omnis qui qui.", new DateTime(2020, 5, 17, 0, 46, 58, 203, DateTimeKind.Utc).AddTicks(1068), 10L, "Veritatis reprehenderit deleniti ipsum soluta.\nConsectetur nesciunt sint quis distinctio omnis.\nQuae ut sapiente dignissimos et quibusdam.\nEsse est eius veritatis porro qui ut ea qui voluptatem.\nMollitia qui autem nesciunt.\nAut enim non quia et voluptatibus corporis assumenda placeat laboriosam.", "Ducimus et suscipit voluptas voluptas eius nemo quis sit quis.", 2L, "", 1, "Quaerat excepturi ab eius exercitationem quos dignissimos saepe id asperiores. Eius illo velit aspernatur. Laudantium tempora adipisci et quibusdam." },
                    { 188L, 50L, "dolorem", new DateTime(2023, 4, 6, 6, 45, 45, 877, DateTimeKind.Utc).AddTicks(1453), 21L, "Maxime qui mollitia illum voluptatibus aut ut unde est et.\nNeque aspernatur non quia minima exercitationem cupiditate labore.\nVelit et est aut beatae culpa voluptatem quibusdam recusandae.\nUnde sit ut omnis qui enim ex ex ab.\nNon rerum optio dolorem fuga numquam unde.", "Et hic nulla velit quia esse blanditiis.", 1L, "", 0, "Eos veritatis dolor impedit necessitatibus alias hic ipsum. Fuga dolor iusto. Qui ipsam autem facilis nulla. Dolores quibusdam deserunt." },
                    { 189L, 15L, "Ipsum et temporibus beatae ex dolorum suscipit iure.", new DateTime(2020, 1, 14, 7, 27, 15, 946, DateTimeKind.Utc).AddTicks(4653), 27L, "Natus non consequatur ut voluptatum eos aperiam. Dicta porro ex. Quo tempore incidunt praesentium enim eos. Est non eaque enim et maxime enim.", "Et provident soluta alias quos id.", 2L, "", 3, "molestiae" },
                    { 190L, 13L, "Dicta eveniet iusto mollitia occaecati rerum odit molestiae. Veritatis quia dolorem optio cupiditate quaerat praesentium sequi quia. Dolorem architecto nihil molestiae temporibus. Ut consequatur modi ratione ipsum nulla quod veniam et tenetur.", new DateTime(2022, 11, 6, 7, 49, 40, 351, DateTimeKind.Utc).AddTicks(5725), 30L, "et", "Mollitia accusamus nemo consequatur ipsam aut sit.", 2L, "", 3, "Ratione facere est aut alias aut." },
                    { 191L, 61L, "Eius culpa perspiciatis qui similique aut maiores. Blanditiis dolorum quisquam. Ut velit unde. Autem qui voluptatum. Modi aperiam dolores quod et. Et dolorem iusto sed et.", new DateTime(2023, 6, 16, 22, 54, 30, 862, DateTimeKind.Utc).AddTicks(677), 38L, "Distinctio tempora quisquam.", "Consequatur id ut laborum distinctio totam facilis quo unde culpa.", 1L, "", 3, "tempora" }
                });

            migrationBuilder.InsertData(
                table: "ChallengeVersions",
                columns: new[] { "Id", "ChallengeId", "CompleteSolution", "CreatedAt", "CreatedBy", "ExampleTestCases", "InitialSolution", "LanguageId", "PreloadedCode", "Status", "TestCases" },
                values: new object[,]
                {
                    { 192L, 66L, "Dignissimos aut qui minima.", new DateTime(2022, 7, 26, 19, 17, 3, 250, DateTimeKind.Utc).AddTicks(3410), 29L, "nihil", "Qui ut quia ut aspernatur animi possimus asperiores voluptate corrupti.", 2L, "", 3, "Aliquam iste et nulla ut consectetur necessitatibus. Quasi quis est nihil quis soluta sequi sint dicta ipsum. Qui fugiat dignissimos architecto vel id rerum dolorem." },
                    { 194L, 54L, "Autem dolor sint et ab.\nLibero iusto animi.\nFacere et consequatur.", new DateTime(2022, 6, 21, 6, 21, 56, 127, DateTimeKind.Utc).AddTicks(6881), 1L, "qui", "Architecto ut dolor molestiae.", 1L, "", 1, "Exercitationem quis est a et nulla.\nVoluptatibus accusamus dolore enim earum quia id qui aliquid." },
                    { 195L, 69L, "Sit ut hic molestiae recusandae placeat et possimus est. Asperiores et in. Amet qui velit sunt quis ipsa at maiores. Ut adipisci velit perspiciatis quod cumque quae nihil. Possimus natus repudiandae minima beatae quo quam voluptatem.", new DateTime(2022, 12, 8, 9, 57, 23, 702, DateTimeKind.Utc).AddTicks(1947), 30L, "Voluptatem voluptatibus atque consequatur animi deserunt itaque ut.", "Ut voluptatem officiis distinctio repellendus voluptas quas similique eveniet ut.", 2L, "", 2, "Et eaque debitis consequatur." },
                    { 196L, 27L, "Quo omnis et molestias sunt tempore accusantium animi eligendi quod.", new DateTime(2022, 10, 30, 10, 21, 2, 823, DateTimeKind.Utc).AddTicks(8742), 23L, "nobis", "Illo soluta eligendi.", 1L, "", 0, "Vel necessitatibus nihil quisquam.\nLaborum quia dolorem dolorum similique iure aspernatur." },
                    { 197L, 66L, "Id minima rerum perspiciatis.\nIpsam quidem suscipit quia beatae sequi qui eius consectetur occaecati.\nTotam maiores delectus eius qui dolor.\nQuos beatae voluptatem repellat aut.\nEst voluptatum unde quia.\nDelectus odit numquam natus omnis.", new DateTime(2022, 11, 17, 10, 3, 41, 993, DateTimeKind.Utc).AddTicks(9431), 29L, "Id repellat ipsa optio recusandae exercitationem sed sit sed.", "Aut unde saepe velit rem repudiandae eos.", 1L, "", 1, "Dignissimos ut ducimus vel voluptas cumque necessitatibus et dignissimos.\nId assumenda distinctio nihil.\nQui totam expedita.\nEt dicta rem id est.\nNulla tempora velit adipisci voluptates modi tempora." },
                    { 198L, 14L, "Est ut distinctio.", new DateTime(2023, 5, 4, 11, 22, 56, 899, DateTimeKind.Utc).AddTicks(7761), 24L, "Voluptatem eum ea est repellendus optio. Quia tempore ut temporibus nesciunt dolores. Vel culpa recusandae est et soluta sequi eveniet.", "Illum explicabo odit.", 1L, "", 3, "Voluptatum deleniti accusamus sed non vel. Pariatur est sit ex est. Voluptatem molestias ut enim veniam nam sequi dolores. Voluptatem autem vel sed et ea consequuntur assumenda. Velit officiis qui qui rerum. Libero reprehenderit natus aut eos." },
                    { 199L, 15L, "Sapiente voluptatem sed.", new DateTime(2019, 1, 10, 12, 20, 17, 811, DateTimeKind.Utc).AddTicks(3544), 8L, "Rerum in voluptatibus quia eos non in enim quam.", "Odit ipsa enim quo et voluptates dolores id in facere.", 1L, "", 2, "aperiam" },
                    { 200L, 61L, "beatae", new DateTime(2023, 8, 22, 10, 36, 55, 904, DateTimeKind.Utc).AddTicks(2273), 37L, "Quisquam magni optio dolorem dolorem reprehenderit omnis expedita ipsam.", "Quasi et beatae hic sint qui.", 1L, "", 0, "dolor" }
                });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 25, 14, 513, DateTimeKind.Utc).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2018, 3, 16, 18, 20, 34, 587, DateTimeKind.Utc).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 12, 1, 4, 971, DateTimeKind.Utc).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 7, 6, 53, 36, 232, DateTimeKind.Utc).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 24, 21, 53, 10, 120, DateTimeKind.Utc).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 24, 7, 14, 29, 939, DateTimeKind.Utc).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 8, 15, 41, 40, 708, DateTimeKind.Utc).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2017, 1, 16, 2, 24, 1, 572, DateTimeKind.Utc).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 7, 9, 3, 2, 714, DateTimeKind.Utc).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 4, 7, 21, 8, 349, DateTimeKind.Utc).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2018, 1, 14, 3, 30, 4, 433, DateTimeKind.Utc).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 13, 11, 24, 1, 186, DateTimeKind.Utc).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2017, 10, 23, 14, 38, 29, 233, DateTimeKind.Utc).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 17, 5, 7, 15, 697, DateTimeKind.Utc).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2018, 7, 15, 0, 20, 27, 198, DateTimeKind.Utc).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 20, 23, 12, 13, 639, DateTimeKind.Utc).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 20, 21, 32, 8, 10, DateTimeKind.Utc).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 19, 20, 6, 2, 716, DateTimeKind.Utc).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 26, 15, 34, 30, 617, DateTimeKind.Utc).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 5, 7, 25, 4, 493, DateTimeKind.Utc).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 1, 1, 57, 49, 43, DateTimeKind.Utc).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 29, 17, 14, 22, 561, DateTimeKind.Utc).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 15, 18, 3, 35, DateTimeKind.Utc).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 2, 50, 13, 355, DateTimeKind.Utc).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 8, 6, 0, 26, 621, DateTimeKind.Utc).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 8, 2, 38, 4, 313, DateTimeKind.Utc).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 15, 3, 13, 11, 338, DateTimeKind.Utc).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2022, 2, 14, 21, 25, 50, 817, DateTimeKind.Utc).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 27, 21, 1, 8, 718, DateTimeKind.Utc).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2017, 7, 1, 23, 0, 50, 701, DateTimeKind.Utc).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 13, 3, 31, 36, 281, DateTimeKind.Utc).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 12, 38, 32, 953, DateTimeKind.Utc).AddTicks(1657));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 2, 59, 8, 288, DateTimeKind.Utc).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 20, 25, 43, DateTimeKind.Utc).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 13, 23, 27, 29, 446, DateTimeKind.Utc).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedAt",
                value: new DateTime(2021, 6, 2, 18, 26, 38, 579, DateTimeKind.Utc).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 29, 14, 35, 7, 962, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 21, 17, 57, 43, 312, DateTimeKind.Utc).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedAt",
                value: new DateTime(2022, 2, 14, 23, 30, 24, 426, DateTimeKind.Utc).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 17, 9, 55, 58, 586, DateTimeKind.Utc).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedAt",
                value: new DateTime(2021, 12, 3, 15, 48, 20, 446, DateTimeKind.Utc).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 7, 19, 40, 52, 21, DateTimeKind.Utc).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 5, 56, 43, 276, DateTimeKind.Utc).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedAt",
                value: new DateTime(2019, 2, 8, 18, 15, 9, 919, DateTimeKind.Utc).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 9, 2, 32, 17, 943, DateTimeKind.Utc).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 30, 11, 22, 58, 618, DateTimeKind.Utc).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 7, 46, 8, 533, DateTimeKind.Utc).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 48L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 6, 2, 55, 21, 571, DateTimeKind.Utc).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 17, 1, 19, 31, 290, DateTimeKind.Utc).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 25, 11, 52, 19, 371, DateTimeKind.Utc).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 22, 21, 12, 44, 807, DateTimeKind.Utc).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedAt",
                value: new DateTime(2022, 2, 1, 9, 41, 52, 260, DateTimeKind.Utc).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedAt",
                value: new DateTime(2019, 4, 13, 4, 55, 56, 602, DateTimeKind.Utc).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedAt",
                value: new DateTime(2022, 1, 27, 23, 46, 32, 454, DateTimeKind.Utc).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 23, 16, 49, 655, DateTimeKind.Utc).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 56L,
                column: "CreatedAt",
                value: new DateTime(2018, 4, 23, 8, 37, 35, 588, DateTimeKind.Utc).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 9, 1, 28, 53, 981, DateTimeKind.Utc).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 20, 15, 5, 4, 22, DateTimeKind.Utc).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 19, 15, 8, 37, 571, DateTimeKind.Utc).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedAt",
                value: new DateTime(2019, 2, 25, 23, 43, 43, 984, DateTimeKind.Utc).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 29, 18, 8, 26, 982, DateTimeKind.Utc).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 6, 5, 37, 47, 518, DateTimeKind.Utc).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 17, 11, 16, 36, 526, DateTimeKind.Utc).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 64L,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 22, 6, 37, 28, 182, DateTimeKind.Utc).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 20, 17, 52, 51, 839, DateTimeKind.Utc).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedAt",
                value: new DateTime(2021, 12, 1, 22, 15, 59, 161, DateTimeKind.Utc).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 9, 14, 50, 50, 646, DateTimeKind.Utc).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 15, 15, 53, 16, 26, DateTimeKind.Utc).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 27, 17, 58, 6, 785, DateTimeKind.Utc).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 26, 11, 56, 33, 760, DateTimeKind.Utc).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 22, 22, 33, 34, 176, DateTimeKind.Utc).AddTicks(3860), new DateTime(2023, 7, 21, 7, 24, 7, 417, DateTimeKind.Utc).AddTicks(2943), new DateTime(2022, 8, 16, 11, 55, 57, 562, DateTimeKind.Utc).AddTicks(9341), new DateTime(2023, 7, 23, 14, 59, 42, 727, DateTimeKind.Utc).AddTicks(8574) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 20, 2, 26, 49, 748, DateTimeKind.Utc).AddTicks(9391), new DateTime(2023, 8, 1, 17, 4, 54, 624, DateTimeKind.Utc).AddTicks(5339), new DateTime(2023, 1, 24, 6, 24, 32, 114, DateTimeKind.Utc).AddTicks(2835), new DateTime(2023, 2, 9, 1, 52, 13, 491, DateTimeKind.Utc).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 11, 17, 32, 50, 310, DateTimeKind.Utc).AddTicks(4944), new DateTime(2023, 7, 30, 12, 40, 17, 544, DateTimeKind.Utc).AddTicks(4179), new DateTime(2023, 5, 12, 23, 2, 37, 861, DateTimeKind.Utc).AddTicks(5263), new DateTime(2023, 7, 23, 21, 29, 51, 22, DateTimeKind.Utc).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 1, 15, 20, 21, 54, 920, DateTimeKind.Utc).AddTicks(5094), new DateTime(2022, 6, 3, 8, 18, 16, 457, DateTimeKind.Utc).AddTicks(8238), new DateTime(2021, 8, 3, 13, 56, 18, 35, DateTimeKind.Utc).AddTicks(9575), new DateTime(2022, 8, 15, 0, 45, 28, 260, DateTimeKind.Utc).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 14, 12, 30, 8, 13, DateTimeKind.Utc).AddTicks(9721), new DateTime(2023, 5, 9, 11, 35, 41, 206, DateTimeKind.Utc).AddTicks(8257), new DateTime(2022, 11, 1, 7, 51, 54, 730, DateTimeKind.Utc).AddTicks(7930), new DateTime(2023, 8, 17, 10, 39, 12, 505, DateTimeKind.Utc).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 9, 15, 12, 36, 48, 811, DateTimeKind.Utc).AddTicks(1971), new DateTime(2021, 4, 12, 19, 48, 37, 564, DateTimeKind.Utc).AddTicks(7443), new DateTime(2018, 12, 17, 13, 54, 51, 705, DateTimeKind.Utc).AddTicks(3345), new DateTime(2019, 12, 30, 19, 0, 20, 999, DateTimeKind.Utc).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 2, 24, 19, 37, 16, 30, DateTimeKind.Utc).AddTicks(8137), new DateTime(2023, 2, 1, 7, 2, 46, 310, DateTimeKind.Utc).AddTicks(1742), new DateTime(2020, 4, 24, 5, 58, 57, 934, DateTimeKind.Utc).AddTicks(27), new DateTime(2021, 1, 25, 9, 35, 6, 457, DateTimeKind.Utc).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 10, 19, 13, 11, 46, 944, DateTimeKind.Utc).AddTicks(7629), new DateTime(2022, 8, 28, 7, 12, 51, 602, DateTimeKind.Utc).AddTicks(4589), new DateTime(2021, 5, 8, 11, 21, 27, 918, DateTimeKind.Utc).AddTicks(8669), new DateTime(2021, 7, 19, 19, 13, 57, 494, DateTimeKind.Utc).AddTicks(8046) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 28, 13, 8, 39, 61, DateTimeKind.Utc).AddTicks(2699), new DateTime(2023, 5, 29, 12, 8, 56, 423, DateTimeKind.Utc).AddTicks(5693), new DateTime(2021, 6, 3, 23, 32, 7, 221, DateTimeKind.Utc).AddTicks(3609), new DateTime(2022, 5, 3, 21, 50, 44, 599, DateTimeKind.Utc).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 7, 23, 28, 23, 808, DateTimeKind.Utc).AddTicks(2561), new DateTime(2022, 3, 23, 3, 54, 2, 238, DateTimeKind.Utc).AddTicks(66), new DateTime(2021, 3, 15, 10, 39, 14, 142, DateTimeKind.Utc).AddTicks(3481), new DateTime(2022, 12, 6, 23, 46, 2, 566, DateTimeKind.Utc).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 30, 17, 13, 28, 151, DateTimeKind.Utc).AddTicks(2812), new DateTime(2023, 4, 12, 11, 17, 32, 829, DateTimeKind.Utc).AddTicks(9682), new DateTime(2023, 1, 15, 8, 15, 6, 898, DateTimeKind.Utc).AddTicks(3210), new DateTime(2023, 2, 18, 21, 21, 39, 776, DateTimeKind.Utc).AddTicks(1745) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 20, 15, 40, 28, 867, DateTimeKind.Utc).AddTicks(8880), new DateTime(2022, 12, 18, 20, 58, 24, 958, DateTimeKind.Utc).AddTicks(9957), new DateTime(2022, 9, 23, 20, 15, 16, 883, DateTimeKind.Utc).AddTicks(2782), new DateTime(2023, 8, 14, 19, 32, 5, 406, DateTimeKind.Utc).AddTicks(1195) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 21, 1, 6, 40, 616, DateTimeKind.Utc).AddTicks(8277), new DateTime(2023, 9, 12, 3, 32, 42, 303, DateTimeKind.Utc).AddTicks(4057), new DateTime(2023, 4, 20, 20, 35, 56, 726, DateTimeKind.Utc).AddTicks(11), new DateTime(2023, 9, 2, 20, 52, 42, 846, DateTimeKind.Utc).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 5, 26, 17, 40, 8, 179, DateTimeKind.Utc).AddTicks(8375), new DateTime(2020, 7, 29, 2, 48, 1, 762, DateTimeKind.Utc).AddTicks(3173), new DateTime(2019, 11, 14, 0, 37, 53, 421, DateTimeKind.Utc).AddTicks(5118), new DateTime(2022, 10, 27, 11, 27, 47, 989, DateTimeKind.Utc).AddTicks(1238) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 9, 5, 22, 1, 5, 63, DateTimeKind.Utc).AddTicks(6729), new DateTime(2022, 8, 16, 7, 4, 57, 893, DateTimeKind.Utc).AddTicks(6061), new DateTime(2021, 4, 2, 20, 37, 32, 780, DateTimeKind.Utc).AddTicks(1391), new DateTime(2023, 7, 10, 11, 33, 1, 110, DateTimeKind.Utc).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 4, 57, 47, 160, DateTimeKind.Utc).AddTicks(4122), new DateTime(2023, 8, 22, 21, 5, 17, 782, DateTimeKind.Utc).AddTicks(814), new DateTime(2023, 2, 20, 12, 18, 23, 995, DateTimeKind.Utc).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 1, 26, 14, 9, 31, 976, DateTimeKind.Utc).AddTicks(598), new DateTime(2020, 12, 6, 12, 45, 23, 209, DateTimeKind.Utc).AddTicks(7186), new DateTime(2019, 1, 19, 17, 16, 11, 531, DateTimeKind.Utc).AddTicks(1934), new DateTime(2020, 8, 22, 5, 0, 27, 402, DateTimeKind.Utc).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 24, 17, 25, 34, 607, DateTimeKind.Utc).AddTicks(8618), new DateTime(2023, 8, 5, 2, 48, 27, 145, DateTimeKind.Utc).AddTicks(2327), new DateTime(2020, 12, 26, 21, 19, 2, 64, DateTimeKind.Utc).AddTicks(3459), new DateTime(2021, 12, 3, 8, 19, 10, 719, DateTimeKind.Utc).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 8, 7, 46, 16, 707, DateTimeKind.Utc).AddTicks(5554), new DateTime(2023, 7, 7, 9, 11, 19, 122, DateTimeKind.Utc).AddTicks(9317), new DateTime(2023, 6, 26, 16, 29, 33, 815, DateTimeKind.Utc).AddTicks(5923), new DateTime(2023, 7, 23, 3, 23, 32, 389, DateTimeKind.Utc).AddTicks(529) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 3, 27, 12, 2, 51, 920, DateTimeKind.Utc).AddTicks(4527), new DateTime(2020, 2, 28, 2, 0, 26, 431, DateTimeKind.Utc).AddTicks(1962), new DateTime(2019, 11, 28, 2, 12, 6, 515, DateTimeKind.Utc).AddTicks(6680), new DateTime(2022, 3, 13, 1, 58, 23, 632, DateTimeKind.Utc).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 22, 39, 76, DateTimeKind.Utc).AddTicks(3494), new DateTime(2023, 6, 1, 13, 35, 35, 78, DateTimeKind.Utc).AddTicks(5948), new DateTime(2022, 3, 5, 7, 10, 46, 345, DateTimeKind.Utc).AddTicks(8342), new DateTime(2023, 6, 18, 15, 48, 1, 110, DateTimeKind.Utc).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 23, 12, 23, 996, DateTimeKind.Utc).AddTicks(2824), new DateTime(2023, 5, 5, 3, 55, 23, 329, DateTimeKind.Utc).AddTicks(7417), new DateTime(2019, 12, 16, 3, 43, 40, 577, DateTimeKind.Utc).AddTicks(513), new DateTime(2022, 5, 15, 21, 38, 0, 834, DateTimeKind.Utc).AddTicks(7967) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 3, 27, 17, 49, 1, 877, DateTimeKind.Utc).AddTicks(2176), new DateTime(2020, 3, 22, 7, 25, 39, 943, DateTimeKind.Utc).AddTicks(4780), new DateTime(2017, 7, 20, 2, 30, 50, 638, DateTimeKind.Utc).AddTicks(6829), new DateTime(2023, 9, 2, 3, 41, 19, 902, DateTimeKind.Utc).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 5, 24, 12, 32, 37, 246, DateTimeKind.Utc).AddTicks(7390), new DateTime(2019, 8, 3, 1, 3, 22, 257, DateTimeKind.Utc).AddTicks(7946), new DateTime(2019, 3, 31, 23, 13, 55, 719, DateTimeKind.Utc).AddTicks(9943), new DateTime(2020, 9, 19, 21, 41, 15, 943, DateTimeKind.Utc).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 8, 58, 37, 794, DateTimeKind.Utc).AddTicks(3642), new DateTime(2023, 4, 6, 7, 35, 53, 188, DateTimeKind.Utc).AddTicks(9426), new DateTime(2021, 4, 13, 11, 41, 55, 362, DateTimeKind.Utc).AddTicks(2750), new DateTime(2022, 4, 10, 23, 29, 20, 327, DateTimeKind.Utc).AddTicks(4845) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 27, 10, 20, 24, 789, DateTimeKind.Utc).AddTicks(4046), new DateTime(2023, 5, 17, 6, 12, 25, 807, DateTimeKind.Utc).AddTicks(9817), new DateTime(2023, 2, 14, 16, 27, 52, 803, DateTimeKind.Utc).AddTicks(2632), new DateTime(2023, 4, 4, 18, 35, 46, 921, DateTimeKind.Utc).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 22, 19, 5, 477, DateTimeKind.Utc).AddTicks(9026), new DateTime(2022, 12, 27, 8, 31, 20, 722, DateTimeKind.Utc).AddTicks(8823), new DateTime(2022, 7, 6, 9, 30, 57, 22, DateTimeKind.Utc).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 2, 36, 14, 77, DateTimeKind.Utc).AddTicks(9806), new DateTime(2023, 5, 28, 20, 43, 42, 737, DateTimeKind.Utc).AddTicks(8184), new DateTime(2023, 3, 27, 20, 9, 48, 994, DateTimeKind.Utc).AddTicks(6784), new DateTime(2023, 8, 15, 5, 6, 49, 190, DateTimeKind.Utc).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 6, 41, 33, 788, DateTimeKind.Utc).AddTicks(5386), new DateTime(2023, 4, 5, 19, 26, 19, 208, DateTimeKind.Utc).AddTicks(6350), new DateTime(2023, 2, 27, 1, 28, 26, 687, DateTimeKind.Utc).AddTicks(2730), new DateTime(2023, 7, 17, 10, 27, 32, 642, DateTimeKind.Utc).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 13, 14, 5, 54, 76, DateTimeKind.Utc).AddTicks(3234), new DateTime(2023, 7, 22, 14, 47, 49, 277, DateTimeKind.Utc).AddTicks(4074), new DateTime(2021, 8, 6, 19, 52, 44, 382, DateTimeKind.Utc).AddTicks(9672), new DateTime(2022, 6, 25, 6, 52, 11, 699, DateTimeKind.Utc).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 8, 10, 10, 38, 25, 866, DateTimeKind.Utc).AddTicks(7646), new DateTime(2023, 8, 22, 15, 50, 9, 493, DateTimeKind.Utc).AddTicks(2659), new DateTime(2023, 8, 18, 15, 8, 22, 799, DateTimeKind.Utc).AddTicks(3788), new DateTime(2023, 8, 31, 6, 40, 43, 116, DateTimeKind.Utc).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 12, 13, 34, 0, 410, DateTimeKind.Utc).AddTicks(9695), new DateTime(2022, 4, 3, 15, 56, 19, 919, DateTimeKind.Utc).AddTicks(1106), new DateTime(2022, 2, 10, 22, 12, 21, 944, DateTimeKind.Utc).AddTicks(3460), new DateTime(2023, 7, 4, 1, 5, 37, 598, DateTimeKind.Utc).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 9, 4, 5, 57, 31, 121, DateTimeKind.Utc).AddTicks(4989), new DateTime(2022, 6, 25, 0, 29, 39, 346, DateTimeKind.Utc).AddTicks(7582), new DateTime(2019, 6, 15, 22, 8, 9, 270, DateTimeKind.Utc).AddTicks(2072), new DateTime(2019, 8, 24, 22, 12, 18, 899, DateTimeKind.Utc).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 20, 21, 43, 4, 660, DateTimeKind.Utc).AddTicks(6655), new DateTime(2023, 9, 4, 0, 59, 27, 225, DateTimeKind.Utc).AddTicks(1263), new DateTime(2022, 8, 19, 16, 7, 1, 315, DateTimeKind.Utc).AddTicks(7971), new DateTime(2022, 9, 17, 9, 2, 58, 457, DateTimeKind.Utc).AddTicks(8103) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2019, 12, 3, 10, 7, 0, 390, DateTimeKind.Utc).AddTicks(7956), new DateTime(2019, 10, 28, 23, 36, 5, 785, DateTimeKind.Utc).AddTicks(9243), new DateTime(2018, 8, 4, 16, 48, 26, 38, DateTimeKind.Utc).AddTicks(998), new DateTime(2021, 3, 20, 21, 13, 56, 441, DateTimeKind.Utc).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 12, 19, 13, 48, 9, 457, DateTimeKind.Utc).AddTicks(3296), new DateTime(2021, 11, 24, 21, 28, 26, 407, DateTimeKind.Utc).AddTicks(7277), new DateTime(2021, 4, 10, 23, 14, 28, 26, DateTimeKind.Utc).AddTicks(818), new DateTime(2021, 12, 9, 9, 5, 52, 770, DateTimeKind.Utc).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 18, 0, 40, 30, 366, DateTimeKind.Utc).AddTicks(6256), new DateTime(2023, 4, 8, 13, 37, 51, 962, DateTimeKind.Utc).AddTicks(9467), new DateTime(2022, 7, 11, 0, 47, 24, 280, DateTimeKind.Utc).AddTicks(2567), new DateTime(2023, 4, 21, 7, 36, 11, 584, DateTimeKind.Utc).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 57, 37, 594, DateTimeKind.Utc).AddTicks(3257), new DateTime(2023, 8, 20, 3, 44, 54, 921, DateTimeKind.Utc).AddTicks(6768), new DateTime(2023, 6, 29, 4, 17, 28, 568, DateTimeKind.Utc).AddTicks(3181), new DateTime(2023, 8, 25, 23, 7, 33, 918, DateTimeKind.Utc).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 26, 18, 25, 7, 481, DateTimeKind.Utc).AddTicks(2458), new DateTime(2023, 6, 30, 12, 17, 28, 833, DateTimeKind.Utc).AddTicks(292), new DateTime(2023, 5, 25, 12, 17, 8, 360, DateTimeKind.Utc).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 23, 50, 59, 624, DateTimeKind.Utc).AddTicks(23), new DateTime(2022, 7, 11, 14, 2, 58, 191, DateTimeKind.Utc).AddTicks(9786), new DateTime(2020, 12, 19, 6, 49, 51, 695, DateTimeKind.Utc).AddTicks(4327), new DateTime(2022, 8, 9, 14, 14, 7, 337, DateTimeKind.Utc).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 12, 29, 9, 40, 28, 887, DateTimeKind.Utc).AddTicks(7632), new DateTime(2020, 1, 26, 18, 51, 50, 890, DateTimeKind.Utc).AddTicks(4363), new DateTime(2019, 11, 30, 8, 36, 46, 153, DateTimeKind.Utc).AddTicks(5839), new DateTime(2023, 6, 14, 14, 28, 45, 994, DateTimeKind.Utc).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 17, 46, 58, 96, DateTimeKind.Utc).AddTicks(3353), new DateTime(2023, 7, 18, 5, 13, 36, 697, DateTimeKind.Utc).AddTicks(7553), new DateTime(2020, 6, 8, 1, 5, 47, 453, DateTimeKind.Utc).AddTicks(7353), new DateTime(2020, 11, 4, 16, 22, 21, 971, DateTimeKind.Utc).AddTicks(6243) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 27, 14, 23, 46, 455, DateTimeKind.Utc).AddTicks(8085), new DateTime(2023, 8, 22, 16, 58, 58, 616, DateTimeKind.Utc).AddTicks(455), new DateTime(2023, 8, 8, 9, 0, 51, 326, DateTimeKind.Utc).AddTicks(668), new DateTime(2023, 9, 6, 19, 5, 24, 467, DateTimeKind.Utc).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 1, 5, 15, 28, 657, DateTimeKind.Utc).AddTicks(8261), new DateTime(2023, 8, 17, 23, 19, 1, 492, DateTimeKind.Utc).AddTicks(4292), new DateTime(2023, 7, 3, 18, 57, 24, 542, DateTimeKind.Utc).AddTicks(7771), new DateTime(2023, 7, 28, 15, 43, 12, 556, DateTimeKind.Utc).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 11, 11, 46, 229, DateTimeKind.Utc).AddTicks(438), new DateTime(2023, 4, 26, 23, 22, 3, 942, DateTimeKind.Utc).AddTicks(5111), new DateTime(2022, 9, 18, 10, 50, 5, 22, DateTimeKind.Utc).AddTicks(1264), new DateTime(2023, 3, 23, 11, 32, 8, 37, DateTimeKind.Utc).AddTicks(431) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 20, 4, 54, 47, 984, DateTimeKind.Utc).AddTicks(9763), new DateTime(2022, 2, 15, 22, 48, 34, 2, DateTimeKind.Utc).AddTicks(5246), new DateTime(2020, 6, 15, 3, 5, 43, 444, DateTimeKind.Utc).AddTicks(7651), new DateTime(2021, 11, 24, 11, 4, 37, 93, DateTimeKind.Utc).AddTicks(5391) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 19, 29, 39, 295, DateTimeKind.Utc).AddTicks(3841), new DateTime(2023, 8, 31, 7, 39, 43, 328, DateTimeKind.Utc).AddTicks(566), new DateTime(2023, 4, 17, 17, 36, 22, 383, DateTimeKind.Utc).AddTicks(5983), new DateTime(2023, 8, 13, 21, 49, 25, 534, DateTimeKind.Utc).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 7, 5, 8, 15, 10, 907, DateTimeKind.Utc).AddTicks(7595), new DateTime(2021, 12, 14, 7, 52, 45, 147, DateTimeKind.Utc).AddTicks(2450), new DateTime(2020, 1, 5, 12, 11, 50, 65, DateTimeKind.Utc).AddTicks(7682), new DateTime(2021, 2, 23, 21, 40, 34, 603, DateTimeKind.Utc).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 6, 22, 4, 32, 35, 886, DateTimeKind.Utc).AddTicks(9798), new DateTime(2023, 8, 31, 7, 33, 28, 245, DateTimeKind.Utc).AddTicks(8238), new DateTime(2023, 4, 5, 23, 53, 32, 703, DateTimeKind.Utc).AddTicks(3701), new DateTime(2023, 8, 27, 18, 34, 22, 532, DateTimeKind.Utc).AddTicks(40) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2021, 8, 14, 22, 0, 2, 552, DateTimeKind.Utc).AddTicks(2435), new DateTime(2021, 7, 1, 22, 56, 6, 716, DateTimeKind.Utc).AddTicks(5766), new DateTime(2020, 3, 7, 4, 33, 47, 674, DateTimeKind.Utc).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 4, 30, 8, 32, 26, 698, DateTimeKind.Utc).AddTicks(8335), new DateTime(2021, 5, 14, 2, 5, 51, 389, DateTimeKind.Utc).AddTicks(9943), new DateTime(2019, 10, 31, 14, 37, 16, 750, DateTimeKind.Utc).AddTicks(7751), new DateTime(2023, 2, 18, 5, 31, 43, 785, DateTimeKind.Utc).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 19, 18, 53, 20, 50, DateTimeKind.Utc).AddTicks(4722), new DateTime(2023, 8, 9, 4, 40, 24, 269, DateTimeKind.Utc).AddTicks(4487), new DateTime(2023, 7, 8, 4, 25, 53, 270, DateTimeKind.Utc).AddTicks(6585), new DateTime(2023, 8, 3, 13, 18, 46, 37, DateTimeKind.Utc).AddTicks(4921) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 30, 37, 42, DateTimeKind.Utc).AddTicks(9202), new DateTime(2023, 8, 7, 9, 11, 43, 540, DateTimeKind.Utc).AddTicks(3590), new DateTime(2022, 3, 25, 19, 6, 7, 943, DateTimeKind.Utc).AddTicks(1309), new DateTime(2022, 4, 14, 1, 38, 38, 631, DateTimeKind.Utc).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 3, 27, 11, 4, 30, 324, DateTimeKind.Utc).AddTicks(8290), new DateTime(2022, 9, 11, 22, 56, 32, 798, DateTimeKind.Utc).AddTicks(9739), new DateTime(2021, 10, 22, 2, 30, 23, 36, DateTimeKind.Utc).AddTicks(5035), new DateTime(2022, 4, 14, 9, 30, 6, 67, DateTimeKind.Utc).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 1, 21, 0, 51, 31, 115, DateTimeKind.Utc).AddTicks(4451), new DateTime(2022, 9, 24, 0, 18, 52, 198, DateTimeKind.Utc).AddTicks(6102), new DateTime(2022, 8, 9, 2, 49, 35, 584, DateTimeKind.Utc).AddTicks(9939), new DateTime(2023, 8, 5, 21, 27, 11, 526, DateTimeKind.Utc).AddTicks(4129) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 6, 8, 22, 42, 942, DateTimeKind.Utc).AddTicks(1439), new DateTime(2023, 9, 11, 21, 39, 10, 700, DateTimeKind.Utc).AddTicks(8667), new DateTime(2023, 7, 9, 21, 47, 31, 987, DateTimeKind.Utc).AddTicks(8479), new DateTime(2023, 7, 17, 9, 21, 51, 729, DateTimeKind.Utc).AddTicks(5533) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 11, 4, 17, 13, 2, 491, DateTimeKind.Utc).AddTicks(5720), new DateTime(2022, 9, 19, 21, 42, 50, 644, DateTimeKind.Utc).AddTicks(8524), new DateTime(2022, 6, 10, 13, 4, 26, 432, DateTimeKind.Utc).AddTicks(9648), new DateTime(2022, 12, 13, 14, 59, 21, 416, DateTimeKind.Utc).AddTicks(8695) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 9, 44, 57, 20, DateTimeKind.Utc).AddTicks(7933), new DateTime(2023, 3, 15, 5, 10, 49, 177, DateTimeKind.Utc).AddTicks(7123), new DateTime(2023, 2, 19, 12, 2, 59, 606, DateTimeKind.Utc).AddTicks(3418), new DateTime(2023, 5, 6, 0, 8, 32, 997, DateTimeKind.Utc).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 7, 29, 3, 170, DateTimeKind.Utc).AddTicks(2083), new DateTime(2022, 12, 2, 22, 57, 47, 147, DateTimeKind.Utc).AddTicks(2040), new DateTime(2017, 4, 19, 12, 39, 12, 987, DateTimeKind.Utc).AddTicks(1633), new DateTime(2023, 7, 16, 11, 14, 40, 145, DateTimeKind.Utc).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 23, 23, 40, 32, 427, DateTimeKind.Utc).AddTicks(1959), new DateTime(2023, 1, 16, 9, 28, 41, 239, DateTimeKind.Utc).AddTicks(3043), new DateTime(2022, 11, 2, 4, 38, 57, 710, DateTimeKind.Utc).AddTicks(5325), new DateTime(2023, 3, 16, 2, 38, 5, 954, DateTimeKind.Utc).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 4, 20, 4, 44, 527, DateTimeKind.Utc).AddTicks(5127), new DateTime(2022, 8, 23, 14, 47, 50, 655, DateTimeKind.Utc).AddTicks(980), new DateTime(2021, 10, 12, 5, 24, 5, 366, DateTimeKind.Utc).AddTicks(4930), new DateTime(2023, 4, 5, 14, 41, 43, 403, DateTimeKind.Utc).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 10, 10, 53, 54, 217, DateTimeKind.Utc).AddTicks(2221), new DateTime(2023, 3, 31, 11, 53, 46, 695, DateTimeKind.Utc).AddTicks(2636), new DateTime(2019, 11, 5, 9, 34, 52, 966, DateTimeKind.Utc).AddTicks(5495), new DateTime(2020, 8, 27, 12, 36, 10, 521, DateTimeKind.Utc).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 13, 8, 45, 2, 92, DateTimeKind.Utc).AddTicks(4760), new DateTime(2023, 5, 16, 18, 22, 9, 204, DateTimeKind.Utc).AddTicks(7332), new DateTime(2022, 3, 3, 10, 32, 3, 180, DateTimeKind.Utc).AddTicks(7476), new DateTime(2022, 7, 14, 17, 20, 31, 912, DateTimeKind.Utc).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 4, 28, 9, 52, 53, 603, DateTimeKind.Utc).AddTicks(9360), new DateTime(2022, 10, 29, 15, 21, 25, 468, DateTimeKind.Utc).AddTicks(3406), new DateTime(2022, 6, 3, 7, 39, 52, 395, DateTimeKind.Utc).AddTicks(2440), new DateTime(2023, 4, 12, 19, 24, 28, 628, DateTimeKind.Utc).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 6, 8, 12, 22, 13, 982, DateTimeKind.Utc).AddTicks(9143), new DateTime(2021, 8, 10, 21, 16, 45, 245, DateTimeKind.Utc).AddTicks(2635), new DateTime(2021, 6, 24, 4, 42, 47, 62, DateTimeKind.Utc).AddTicks(3657), new DateTime(2022, 4, 6, 21, 6, 31, 508, DateTimeKind.Utc).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 11, 22, 37, 22, 350, DateTimeKind.Utc).AddTicks(5154), new DateTime(2023, 9, 4, 21, 30, 23, 475, DateTimeKind.Utc).AddTicks(3095), new DateTime(2019, 3, 26, 2, 23, 40, 764, DateTimeKind.Utc).AddTicks(6656), new DateTime(2020, 11, 16, 10, 51, 34, 849, DateTimeKind.Utc).AddTicks(8987) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 7, 8, 53, 507, DateTimeKind.Utc).AddTicks(9694), new DateTime(2022, 10, 26, 4, 50, 7, 922, DateTimeKind.Utc).AddTicks(9891), new DateTime(2022, 6, 17, 2, 8, 5, 766, DateTimeKind.Utc).AddTicks(8052), new DateTime(2022, 12, 22, 12, 50, 1, 406, DateTimeKind.Utc).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2018, 4, 5, 15, 43, 43, 443, DateTimeKind.Utc).AddTicks(4237), new DateTime(2018, 3, 19, 13, 58, 45, 921, DateTimeKind.Utc).AddTicks(3125), new DateTime(2017, 9, 20, 2, 27, 25, 717, DateTimeKind.Utc).AddTicks(9475), new DateTime(2019, 7, 12, 6, 29, 46, 297, DateTimeKind.Utc).AddTicks(43) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 8, 3, 1, 17, 47, 41, DateTimeKind.Utc).AddTicks(3125), new DateTime(2023, 8, 7, 12, 31, 19, 58, DateTimeKind.Utc).AddTicks(7870), new DateTime(2023, 7, 6, 6, 47, 4, 135, DateTimeKind.Utc).AddTicks(5070), new DateTime(2023, 7, 12, 0, 22, 42, 568, DateTimeKind.Utc).AddTicks(7457) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 0, 27, 24, 379, DateTimeKind.Utc).AddTicks(3200), new DateTime(2023, 1, 24, 2, 43, 36, 142, DateTimeKind.Utc).AddTicks(3), new DateTime(2021, 7, 7, 2, 42, 54, 579, DateTimeKind.Utc).AddTicks(4632), new DateTime(2022, 11, 4, 6, 39, 39, 987, DateTimeKind.Utc).AddTicks(5873) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 3, 22, 11, 12, 25, 894, DateTimeKind.Utc).AddTicks(8904), new DateTime(2022, 2, 26, 8, 38, 8, 135, DateTimeKind.Utc).AddTicks(1228), new DateTime(2021, 10, 31, 21, 33, 13, 332, DateTimeKind.Utc).AddTicks(3814), new DateTime(2023, 2, 7, 19, 20, 36, 271, DateTimeKind.Utc).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 26, 12, 34, 38, 71, DateTimeKind.Utc).AddTicks(6733), new DateTime(2023, 4, 29, 4, 20, 30, 502, DateTimeKind.Utc).AddTicks(5962), new DateTime(2022, 10, 13, 20, 51, 16, 14, DateTimeKind.Utc).AddTicks(6095), new DateTime(2023, 8, 26, 5, 40, 55, 239, DateTimeKind.Utc).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 5, 2, 18, 7, 392, DateTimeKind.Utc).AddTicks(2974), new DateTime(2023, 8, 18, 7, 6, 6, 394, DateTimeKind.Utc).AddTicks(9019), new DateTime(2022, 3, 12, 2, 1, 30, 802, DateTimeKind.Utc).AddTicks(9815), new DateTime(2022, 8, 26, 11, 3, 34, 102, DateTimeKind.Utc).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 5, 43, 17, 550, DateTimeKind.Utc).AddTicks(2256), new DateTime(2023, 6, 26, 18, 33, 21, 335, DateTimeKind.Utc).AddTicks(810), new DateTime(2021, 7, 9, 1, 43, 32, 606, DateTimeKind.Utc).AddTicks(5464), new DateTime(2021, 12, 12, 23, 3, 31, 54, DateTimeKind.Utc).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 5, 8, 17, 29, 687, DateTimeKind.Utc).AddTicks(1094), new DateTime(2023, 8, 18, 17, 13, 56, 514, DateTimeKind.Utc).AddTicks(3921), new DateTime(2023, 7, 5, 18, 23, 19, 843, DateTimeKind.Utc).AddTicks(9490), new DateTime(2023, 9, 6, 13, 38, 56, 776, DateTimeKind.Utc).AddTicks(2627) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 9, 12, 25, 1, 826, DateTimeKind.Utc).AddTicks(2024), new DateTime(2023, 5, 14, 9, 52, 43, 899, DateTimeKind.Utc).AddTicks(6613), new DateTime(2023, 3, 24, 11, 15, 9, 279, DateTimeKind.Utc).AddTicks(1296), new DateTime(2023, 3, 30, 2, 0, 39, 263, DateTimeKind.Utc).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 20, 4, 31, 56, 989, DateTimeKind.Utc).AddTicks(255), new DateTime(2023, 1, 1, 21, 49, 30, 406, DateTimeKind.Utc).AddTicks(8102), new DateTime(2022, 2, 22, 0, 6, 42, 856, DateTimeKind.Utc).AddTicks(4822), new DateTime(2022, 7, 19, 8, 52, 4, 247, DateTimeKind.Utc).AddTicks(18) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 11, 15, 524, DateTimeKind.Utc).AddTicks(5971), new DateTime(2023, 6, 5, 10, 2, 49, 992, DateTimeKind.Utc).AddTicks(1632), new DateTime(2022, 1, 9, 19, 37, 4, 35, DateTimeKind.Utc).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 5, 5, 15, 28, 34, 687, DateTimeKind.Utc).AddTicks(1337), new DateTime(2022, 12, 30, 16, 30, 59, 694, DateTimeKind.Utc).AddTicks(2615), new DateTime(2022, 11, 11, 12, 4, 48, 532, DateTimeKind.Utc).AddTicks(5250), new DateTime(2023, 9, 5, 6, 47, 40, 259, DateTimeKind.Utc).AddTicks(4519) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2019, 6, 3, 6, 17, 8, 63, DateTimeKind.Utc).AddTicks(5271), new DateTime(2018, 11, 23, 21, 46, 34, 643, DateTimeKind.Utc).AddTicks(1483), new DateTime(2017, 4, 11, 22, 44, 19, 768, DateTimeKind.Utc).AddTicks(2130), new DateTime(2017, 12, 27, 22, 1, 23, 513, DateTimeKind.Utc).AddTicks(9841) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 50, 57, 449, DateTimeKind.Utc).AddTicks(3326), new DateTime(2022, 9, 28, 15, 19, 12, 754, DateTimeKind.Utc).AddTicks(4594), new DateTime(2021, 11, 1, 22, 5, 34, 183, DateTimeKind.Utc).AddTicks(9827), new DateTime(2022, 8, 7, 5, 9, 11, 688, DateTimeKind.Utc).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 13, 15, 21, 52, 308, DateTimeKind.Utc).AddTicks(2817), new DateTime(2023, 9, 9, 16, 41, 42, 523, DateTimeKind.Utc).AddTicks(2189), new DateTime(2023, 9, 7, 17, 9, 14, 101, DateTimeKind.Utc).AddTicks(8832), new DateTime(2023, 9, 9, 21, 12, 40, 51, DateTimeKind.Utc).AddTicks(5289) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 10, 23, 21, 3, 48, 86, DateTimeKind.Utc).AddTicks(5729), new DateTime(2021, 11, 25, 1, 56, 31, 739, DateTimeKind.Utc).AddTicks(6955), new DateTime(2018, 4, 21, 1, 41, 28, 162, DateTimeKind.Utc).AddTicks(1857), new DateTime(2019, 7, 12, 22, 0, 21, 687, DateTimeKind.Utc).AddTicks(4732) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 7, 5, 6, 56, 19, 450, DateTimeKind.Utc).AddTicks(1361), new DateTime(2023, 9, 9, 12, 5, 25, 963, DateTimeKind.Utc).AddTicks(9108), new DateTime(2023, 9, 1, 22, 35, 46, 151, DateTimeKind.Utc).AddTicks(7511), new DateTime(2023, 9, 5, 18, 23, 40, 20, DateTimeKind.Utc).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 4, 46, 55, 424, DateTimeKind.Utc).AddTicks(5534), new DateTime(2023, 4, 10, 12, 45, 31, 519, DateTimeKind.Utc).AddTicks(1009), new DateTime(2016, 11, 13, 20, 45, 3, 355, DateTimeKind.Utc).AddTicks(5174), new DateTime(2020, 9, 28, 9, 57, 6, 348, DateTimeKind.Utc).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 7, 12, 3, 561, DateTimeKind.Utc).AddTicks(6325), new DateTime(2023, 4, 8, 9, 35, 57, 332, DateTimeKind.Utc).AddTicks(3482), new DateTime(2022, 9, 4, 17, 32, 38, 40, DateTimeKind.Utc).AddTicks(4571), new DateTime(2023, 8, 21, 7, 54, 17, 398, DateTimeKind.Utc).AddTicks(2551) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 7, 5, 23, 9, 8, 98, DateTimeKind.Utc).AddTicks(4272), new DateTime(2023, 4, 11, 8, 2, 24, 168, DateTimeKind.Utc).AddTicks(641), new DateTime(2023, 4, 6, 4, 50, 42, 638, DateTimeKind.Utc).AddTicks(8743), new DateTime(2023, 8, 7, 18, 58, 53, 873, DateTimeKind.Utc).AddTicks(9078) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 2, 12, 11, 4, 43, 389, DateTimeKind.Utc).AddTicks(1524), new DateTime(2021, 1, 29, 18, 2, 27, 640, DateTimeKind.Utc).AddTicks(5810), new DateTime(2019, 6, 24, 18, 41, 11, 763, DateTimeKind.Utc).AddTicks(2737), new DateTime(2022, 10, 4, 18, 13, 16, 767, DateTimeKind.Utc).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 2, 23, 5, 13, 48, 592, DateTimeKind.Utc).AddTicks(9663), new DateTime(2023, 5, 8, 23, 34, 21, 137, DateTimeKind.Utc).AddTicks(7902), new DateTime(2022, 9, 27, 17, 15, 44, 649, DateTimeKind.Utc).AddTicks(7087), new DateTime(2023, 1, 14, 11, 39, 18, 22, DateTimeKind.Utc).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 23, 21, 15, 9, DateTimeKind.Utc).AddTicks(3785), new DateTime(2023, 6, 4, 15, 32, 21, 855, DateTimeKind.Utc).AddTicks(208), new DateTime(2019, 4, 6, 20, 44, 10, 327, DateTimeKind.Utc).AddTicks(4292) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 9, 26, 22, 36, 6, 216, DateTimeKind.Utc).AddTicks(9760), new DateTime(2021, 9, 30, 15, 45, 44, 271, DateTimeKind.Utc).AddTicks(9395), new DateTime(2021, 4, 4, 21, 57, 31, 769, DateTimeKind.Utc).AddTicks(7206), new DateTime(2023, 6, 4, 15, 14, 7, 613, DateTimeKind.Utc).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 1, 17, 46, 836, DateTimeKind.Utc).AddTicks(6187), new DateTime(2023, 8, 2, 1, 25, 36, 58, DateTimeKind.Utc).AddTicks(5759), new DateTime(2023, 7, 20, 19, 14, 14, 800, DateTimeKind.Utc).AddTicks(9954), new DateTime(2023, 8, 19, 2, 35, 42, 721, DateTimeKind.Utc).AddTicks(5642) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 3, 1, 2, 31, 50, 603, DateTimeKind.Utc).AddTicks(4120), new DateTime(2023, 6, 11, 13, 33, 7, 24, DateTimeKind.Utc).AddTicks(714), new DateTime(2023, 1, 18, 7, 16, 21, 587, DateTimeKind.Utc).AddTicks(6929), new DateTime(2023, 3, 24, 6, 15, 0, 787, DateTimeKind.Utc).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 22, 6, 28, 39, 419, DateTimeKind.Utc).AddTicks(7330), new DateTime(2023, 2, 4, 15, 49, 56, 826, DateTimeKind.Utc).AddTicks(7005), new DateTime(2022, 5, 28, 18, 8, 20, 683, DateTimeKind.Utc).AddTicks(6855), new DateTime(2023, 3, 5, 23, 8, 51, 899, DateTimeKind.Utc).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 5, 19, 0, 54, 27, 222, DateTimeKind.Utc).AddTicks(9685), new DateTime(2020, 6, 25, 15, 26, 45, 440, DateTimeKind.Utc).AddTicks(8578), new DateTime(2017, 10, 12, 3, 30, 14, 889, DateTimeKind.Utc).AddTicks(4412), new DateTime(2018, 6, 1, 12, 49, 10, 91, DateTimeKind.Utc).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 9, 4, 14, 52, 30, 145, DateTimeKind.Utc).AddTicks(216), new DateTime(2023, 7, 24, 7, 16, 40, 126, DateTimeKind.Utc).AddTicks(5493), new DateTime(2021, 5, 19, 21, 17, 53, 25, DateTimeKind.Utc).AddTicks(7987), new DateTime(2021, 10, 12, 1, 18, 46, 669, DateTimeKind.Utc).AddTicks(4711) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 12, 21, 5, 52, 6, 827, DateTimeKind.Utc).AddTicks(8724), new DateTime(2023, 2, 26, 16, 33, 23, 576, DateTimeKind.Utc).AddTicks(1810), new DateTime(2022, 12, 18, 1, 42, 18, 23, DateTimeKind.Utc).AddTicks(2027), new DateTime(2023, 2, 11, 11, 6, 43, 238, DateTimeKind.Utc).AddTicks(1368) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 19, 44, 46, 672, DateTimeKind.Utc).AddTicks(4747), new DateTime(2023, 8, 2, 16, 1, 34, 807, DateTimeKind.Utc).AddTicks(2672), new DateTime(2022, 12, 31, 18, 48, 5, 412, DateTimeKind.Utc).AddTicks(5022), new DateTime(2023, 8, 7, 17, 43, 22, 895, DateTimeKind.Utc).AddTicks(51) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 8, 27, 2, 58, 4, 424, DateTimeKind.Utc).AddTicks(7184), new DateTime(2022, 5, 25, 5, 54, 31, 42, DateTimeKind.Utc).AddTicks(3362), new DateTime(2021, 7, 6, 12, 56, 56, 394, DateTimeKind.Utc).AddTicks(7463), new DateTime(2022, 1, 28, 10, 8, 3, 60, DateTimeKind.Utc).AddTicks(4081) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 6, 29, 23, 57, 48, 280, DateTimeKind.Utc).AddTicks(3696), new DateTime(2023, 9, 2, 5, 29, 17, 660, DateTimeKind.Utc).AddTicks(3272), new DateTime(2023, 6, 15, 20, 23, 46, 311, DateTimeKind.Utc).AddTicks(3918), new DateTime(2023, 7, 30, 2, 5, 11, 757, DateTimeKind.Utc).AddTicks(701) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 29, 10, 3, 20, 785, DateTimeKind.Utc).AddTicks(8878), new DateTime(2023, 8, 30, 22, 3, 0, 71, DateTimeKind.Utc).AddTicks(1540), new DateTime(2023, 8, 12, 2, 14, 54, 48, DateTimeKind.Utc).AddTicks(3943), new DateTime(2023, 8, 27, 4, 22, 5, 720, DateTimeKind.Utc).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 4, 4, 10, 59, 28, 679, DateTimeKind.Utc).AddTicks(4722), new DateTime(2020, 12, 13, 12, 3, 43, 79, DateTimeKind.Utc).AddTicks(1670), new DateTime(2019, 10, 10, 6, 56, 47, 5, DateTimeKind.Utc).AddTicks(7450), new DateTime(2023, 7, 31, 13, 58, 15, 220, DateTimeKind.Utc).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 4, 6, 20, 39, 24, 319, DateTimeKind.Utc).AddTicks(1283), new DateTime(2023, 4, 20, 14, 39, 24, 528, DateTimeKind.Utc).AddTicks(1696), new DateTime(2022, 11, 17, 15, 10, 7, 382, DateTimeKind.Utc).AddTicks(1486), new DateTime(2023, 1, 20, 18, 44, 30, 776, DateTimeKind.Utc).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 1, 5, 23, 44, 53, 383, DateTimeKind.Utc).AddTicks(8808), new DateTime(2022, 9, 4, 6, 54, 14, 127, DateTimeKind.Utc).AddTicks(6092), new DateTime(2022, 8, 23, 8, 36, 55, 462, DateTimeKind.Utc).AddTicks(2709), new DateTime(2023, 1, 29, 12, 55, 42, 772, DateTimeKind.Utc).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2020, 10, 25, 10, 45, 26, 515, DateTimeKind.Utc).AddTicks(7365), new DateTime(2019, 11, 16, 15, 16, 55, 621, DateTimeKind.Utc).AddTicks(6780), new DateTime(2017, 6, 28, 13, 24, 36, 10, DateTimeKind.Utc).AddTicks(3159), new DateTime(2018, 8, 9, 0, 50, 38, 341, DateTimeKind.Utc).AddTicks(4486) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2024, 1, 30, 5, 30, 26, 14, DateTimeKind.Utc).AddTicks(6353), new DateTime(2023, 7, 26, 17, 11, 30, 28, DateTimeKind.Utc).AddTicks(7023), new DateTime(2023, 7, 2, 2, 13, 33, 576, DateTimeKind.Utc).AddTicks(5928), new DateTime(2023, 7, 16, 21, 9, 46, 590, DateTimeKind.Utc).AddTicks(5658) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 23, 20, 24, 18, 734, DateTimeKind.Utc).AddTicks(7597), new DateTime(2022, 11, 27, 9, 37, 23, 17, DateTimeKind.Utc).AddTicks(9818), new DateTime(2022, 5, 13, 17, 43, 2, 595, DateTimeKind.Utc).AddTicks(6568), new DateTime(2023, 1, 10, 1, 21, 6, 29, DateTimeKind.Utc).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2021, 1, 5, 22, 39, 30, 21, DateTimeKind.Utc).AddTicks(5808), new DateTime(2020, 5, 2, 0, 33, 33, 32, DateTimeKind.Utc).AddTicks(2644), new DateTime(2019, 8, 31, 0, 46, 7, 730, DateTimeKind.Utc).AddTicks(6021), new DateTime(2020, 12, 3, 6, 42, 1, 388, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2023, 11, 9, 0, 50, 16, 496, DateTimeKind.Utc).AddTicks(48), new DateTime(2023, 8, 11, 15, 18, 33, 589, DateTimeKind.Utc).AddTicks(4324), new DateTime(2023, 5, 3, 1, 10, 35, 6, DateTimeKind.Utc).AddTicks(4838), new DateTime(2023, 8, 28, 22, 8, 56, 987, DateTimeKind.Utc).AddTicks(2461) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "EndDate", "StartDate", "SubscribedDate", "UnsubscribedDate" },
                values: new object[] { new DateTime(2022, 12, 23, 15, 46, 17, 97, DateTimeKind.Utc).AddTicks(1628), new DateTime(2022, 8, 19, 9, 47, 12, 462, DateTimeKind.Utc).AddTicks(7346), new DateTime(2022, 6, 19, 18, 19, 39, 922, DateTimeKind.Utc).AddTicks(388), new DateTime(2022, 10, 10, 21, 37, 48, 147, DateTimeKind.Utc).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 14L, new DateTime(2023, 8, 13, 6, 7, 28, 611, DateTimeKind.Utc).AddTicks(2697) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 90L, new DateTime(2023, 1, 27, 6, 5, 38, 962, DateTimeKind.Utc).AddTicks(9438) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 173L, new DateTime(2021, 9, 6, 22, 36, 4, 233, DateTimeKind.Utc).AddTicks(9134) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 125L, new DateTime(2023, 7, 11, 9, 25, 1, 69, DateTimeKind.Utc).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 185L, new DateTime(2023, 5, 5, 10, 45, 24, 670, DateTimeKind.Utc).AddTicks(4595) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 47L, new DateTime(2023, 9, 1, 18, 32, 5, 423, DateTimeKind.Utc).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 100L, new DateTime(2022, 7, 18, 3, 24, 12, 847, DateTimeKind.Utc).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 10L, new DateTime(2023, 6, 13, 18, 18, 20, 662, DateTimeKind.Utc).AddTicks(4584) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 61L, new DateTime(2023, 8, 25, 12, 36, 43, 517, DateTimeKind.Utc).AddTicks(1460) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 39L, new DateTime(2023, 5, 29, 22, 3, 1, 707, DateTimeKind.Utc).AddTicks(7971) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 42L, new DateTime(2023, 6, 19, 7, 0, 33, 925, DateTimeKind.Utc).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 115L, new DateTime(2021, 5, 19, 2, 47, 40, 940, DateTimeKind.Utc).AddTicks(9537) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 147L, new DateTime(2023, 4, 3, 14, 4, 37, 287, DateTimeKind.Utc).AddTicks(2141) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 181L, new DateTime(2023, 6, 10, 0, 57, 17, 104, DateTimeKind.Utc).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 112L, new DateTime(2023, 3, 7, 5, 2, 7, 871, DateTimeKind.Utc).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 178L, new DateTime(2021, 11, 16, 17, 24, 31, 519, DateTimeKind.Utc).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 62L, new DateTime(2022, 11, 16, 20, 24, 11, 222, DateTimeKind.Utc).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 134L, new DateTime(2023, 9, 12, 9, 34, 23, 568, DateTimeKind.Utc).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 101L, new DateTime(2022, 3, 21, 10, 32, 29, 193, DateTimeKind.Utc).AddTicks(731) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 3L, new DateTime(2023, 5, 5, 4, 40, 53, 720, DateTimeKind.Utc).AddTicks(965) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 176L, new DateTime(2022, 7, 8, 12, 9, 16, 114, DateTimeKind.Utc).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 92L, new DateTime(2023, 7, 28, 17, 50, 54, 529, DateTimeKind.Utc).AddTicks(5549) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 43L, new DateTime(2023, 2, 7, 5, 10, 6, 726, DateTimeKind.Utc).AddTicks(7063) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 26, 9, 3, 11, 417, DateTimeKind.Utc).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 48L, new DateTime(2023, 6, 14, 23, 39, 17, 212, DateTimeKind.Utc).AddTicks(8608) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 125L, new DateTime(2023, 7, 25, 11, 42, 36, 751, DateTimeKind.Utc).AddTicks(3985) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 85L, new DateTime(2023, 4, 4, 2, 55, 17, 900, DateTimeKind.Utc).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 181L, new DateTime(2023, 4, 17, 12, 46, 28, 217, DateTimeKind.Utc).AddTicks(43) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 15L, new DateTime(2023, 4, 11, 0, 26, 35, 269, DateTimeKind.Utc).AddTicks(9431) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 66L, new DateTime(2023, 5, 3, 5, 55, 24, 238, DateTimeKind.Utc).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 28L, new DateTime(2023, 8, 10, 21, 45, 13, 993, DateTimeKind.Utc).AddTicks(4626) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 68L, new DateTime(2023, 6, 28, 20, 57, 40, 529, DateTimeKind.Utc).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 128L, new DateTime(2023, 7, 8, 19, 52, 25, 284, DateTimeKind.Utc).AddTicks(8623) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 139L, new DateTime(2023, 5, 9, 11, 42, 0, 529, DateTimeKind.Utc).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 73L, new DateTime(2023, 9, 5, 11, 22, 42, 336, DateTimeKind.Utc).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 45L, new DateTime(2022, 6, 11, 2, 51, 15, 974, DateTimeKind.Utc).AddTicks(9733) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 11L, new DateTime(2022, 10, 18, 4, 10, 53, 583, DateTimeKind.Utc).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 48L, new DateTime(2023, 3, 15, 20, 58, 36, 623, DateTimeKind.Utc).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 183L, new DateTime(2023, 9, 12, 13, 51, 43, 274, DateTimeKind.Utc).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 8L, new DateTime(2023, 8, 8, 22, 3, 4, 40, DateTimeKind.Utc).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 122L, new DateTime(2023, 6, 15, 1, 8, 9, 102, DateTimeKind.Utc).AddTicks(139) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 13L, new DateTime(2021, 11, 1, 11, 49, 55, 486, DateTimeKind.Utc).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 67L, new DateTime(2023, 7, 28, 18, 28, 5, 369, DateTimeKind.Utc).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 23L, new DateTime(2023, 4, 23, 0, 19, 56, 232, DateTimeKind.Utc).AddTicks(7556) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 38L, new DateTime(2023, 9, 4, 9, 45, 6, 77, DateTimeKind.Utc).AddTicks(6435) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 58L, new DateTime(2023, 3, 9, 12, 12, 8, 91, DateTimeKind.Utc).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 52L, new DateTime(2023, 4, 28, 12, 44, 7, 419, DateTimeKind.Utc).AddTicks(3959) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 137L, new DateTime(2023, 7, 19, 13, 15, 32, 792, DateTimeKind.Utc).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 25, 21, 53, 23, 269, DateTimeKind.Utc).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 20L, new DateTime(2023, 8, 7, 3, 26, 1, 131, DateTimeKind.Utc).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 194L, new DateTime(2023, 5, 15, 9, 19, 56, 212, DateTimeKind.Utc).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 35L, new DateTime(2023, 6, 25, 17, 38, 27, 730, DateTimeKind.Utc).AddTicks(9272) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 60L, new DateTime(2023, 6, 23, 13, 23, 48, 975, DateTimeKind.Utc).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 130L, new DateTime(2023, 8, 18, 3, 51, 3, 313, DateTimeKind.Utc).AddTicks(1199) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 51L, new DateTime(2023, 2, 26, 6, 25, 22, 451, DateTimeKind.Utc).AddTicks(6141) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 180L, new DateTime(2023, 9, 1, 13, 14, 8, 5, DateTimeKind.Utc).AddTicks(7175) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 31L, new DateTime(2023, 8, 25, 15, 36, 8, 659, DateTimeKind.Utc).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 164L, new DateTime(2023, 5, 31, 1, 52, 37, 995, DateTimeKind.Utc).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 1, 23, 47, 2, 496, DateTimeKind.Utc).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 184L, new DateTime(2023, 9, 5, 20, 54, 33, 23, DateTimeKind.Utc).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 197L, new DateTime(2023, 3, 8, 15, 27, 49, 462, DateTimeKind.Utc).AddTicks(1775) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 190L, new DateTime(2023, 5, 9, 3, 59, 53, 356, DateTimeKind.Utc).AddTicks(8503) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 187L, new DateTime(2023, 2, 5, 4, 49, 18, 118, DateTimeKind.Utc).AddTicks(7475) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 29L, new DateTime(2023, 8, 18, 20, 41, 12, 81, DateTimeKind.Utc).AddTicks(8348) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 186L, new DateTime(2023, 9, 3, 7, 3, 5, 917, DateTimeKind.Utc).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 113L, new DateTime(2022, 7, 27, 2, 36, 58, 398, DateTimeKind.Utc).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 198L, new DateTime(2023, 7, 1, 14, 7, 56, 278, DateTimeKind.Utc).AddTicks(1959) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 40L, new DateTime(2023, 8, 27, 13, 55, 7, 579, DateTimeKind.Utc).AddTicks(8482) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 151L, new DateTime(2023, 7, 8, 3, 1, 22, 5, DateTimeKind.Utc).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 31L, new DateTime(2023, 3, 25, 16, 22, 59, 596, DateTimeKind.Utc).AddTicks(1138) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 16L, new DateTime(2023, 3, 22, 5, 15, 3, 77, DateTimeKind.Utc).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 122L, new DateTime(2023, 8, 17, 2, 14, 19, 666, DateTimeKind.Utc).AddTicks(9091) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 147L, new DateTime(2023, 6, 15, 8, 5, 37, 524, DateTimeKind.Utc).AddTicks(4737) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 127L, new DateTime(2023, 8, 8, 9, 24, 31, 57, DateTimeKind.Utc).AddTicks(6409) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 62L, new DateTime(2023, 3, 22, 17, 44, 27, 854, DateTimeKind.Utc).AddTicks(7602) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 75L, new DateTime(2022, 12, 23, 14, 3, 45, 712, DateTimeKind.Utc).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 70L, new DateTime(2023, 9, 5, 23, 22, 46, 590, DateTimeKind.Utc).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 37L, new DateTime(2023, 9, 3, 19, 35, 32, 55, DateTimeKind.Utc).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 195L, new DateTime(2023, 1, 9, 8, 22, 8, 245, DateTimeKind.Utc).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 108L, new DateTime(2023, 9, 7, 0, 46, 9, 203, DateTimeKind.Utc).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 107L, new DateTime(2023, 7, 19, 16, 30, 15, 315, DateTimeKind.Utc).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 66L, new DateTime(2023, 6, 6, 17, 52, 10, 424, DateTimeKind.Utc).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 145L, new DateTime(2023, 8, 8, 5, 38, 33, 210, DateTimeKind.Utc).AddTicks(584) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 46L, new DateTime(2021, 1, 14, 13, 21, 16, 568, DateTimeKind.Utc).AddTicks(6454) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 14L, new DateTime(2023, 8, 27, 12, 6, 24, 786, DateTimeKind.Utc).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 146L, new DateTime(2023, 8, 21, 6, 17, 53, 386, DateTimeKind.Utc).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 29L, new DateTime(2023, 7, 9, 0, 58, 20, 288, DateTimeKind.Utc).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 103L, new DateTime(2023, 3, 24, 19, 57, 1, 392, DateTimeKind.Utc).AddTicks(159) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 135L, new DateTime(2023, 7, 11, 8, 53, 31, 545, DateTimeKind.Utc).AddTicks(1526) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 175L, new DateTime(2022, 7, 17, 22, 29, 20, 530, DateTimeKind.Utc).AddTicks(7706) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 8L, new DateTime(2023, 8, 17, 14, 1, 33, 998, DateTimeKind.Utc).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 158L, new DateTime(2023, 5, 22, 16, 1, 15, 705, DateTimeKind.Utc).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 85L, new DateTime(2023, 3, 25, 19, 16, 21, 177, DateTimeKind.Utc).AddTicks(2863) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 192L, new DateTime(2022, 11, 4, 7, 2, 37, 124, DateTimeKind.Utc).AddTicks(9233) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 85L, new DateTime(2023, 8, 26, 3, 45, 20, 875, DateTimeKind.Utc).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 111L, new DateTime(2023, 3, 24, 10, 33, 48, 37, DateTimeKind.Utc).AddTicks(8276) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 49L, new DateTime(2023, 8, 31, 7, 49, 37, 451, DateTimeKind.Utc).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 120L, new DateTime(2023, 6, 10, 14, 35, 57, 904, DateTimeKind.Utc).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 62L, new DateTime(2023, 7, 27, 17, 47, 20, 965, DateTimeKind.Utc).AddTicks(2432) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 6L, new DateTime(2023, 2, 12, 16, 37, 8, 112, DateTimeKind.Utc).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 146L, new DateTime(2023, 9, 7, 19, 55, 55, 240, DateTimeKind.Utc).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 143L, new DateTime(2023, 7, 14, 13, 1, 44, 789, DateTimeKind.Utc).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 108L, new DateTime(2023, 2, 2, 22, 50, 2, 102, DateTimeKind.Utc).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 119L, new DateTime(2021, 11, 16, 19, 45, 30, 322, DateTimeKind.Utc).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 31L, new DateTime(2023, 5, 19, 18, 21, 56, 603, DateTimeKind.Utc).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 101L, new DateTime(2020, 3, 27, 3, 17, 10, 277, DateTimeKind.Utc).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 47L, new DateTime(2023, 9, 2, 11, 40, 36, 937, DateTimeKind.Utc).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 61L, new DateTime(2023, 6, 10, 16, 8, 15, 552, DateTimeKind.Utc).AddTicks(1182) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 105L, new DateTime(2023, 5, 17, 10, 20, 56, 186, DateTimeKind.Utc).AddTicks(6209) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 63L, new DateTime(2023, 7, 21, 5, 47, 11, 621, DateTimeKind.Utc).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 32L, new DateTime(2020, 3, 17, 14, 25, 21, 812, DateTimeKind.Utc).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 85L, new DateTime(2023, 7, 26, 16, 37, 37, 182, DateTimeKind.Utc).AddTicks(2959) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 13L, new DateTime(2022, 8, 21, 2, 29, 1, 868, DateTimeKind.Utc).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 180L, new DateTime(2023, 9, 9, 16, 40, 9, 455, DateTimeKind.Utc).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 58L, new DateTime(2022, 11, 8, 13, 49, 33, 369, DateTimeKind.Utc).AddTicks(3357) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 80L, new DateTime(2023, 6, 28, 15, 32, 10, 225, DateTimeKind.Utc).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 101L, new DateTime(2020, 5, 7, 21, 45, 57, 320, DateTimeKind.Utc).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 107L, new DateTime(2023, 6, 19, 10, 3, 44, 843, DateTimeKind.Utc).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 27L, new DateTime(2023, 8, 10, 2, 54, 44, 656, DateTimeKind.Utc).AddTicks(1207) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 185L, new DateTime(2023, 5, 24, 23, 47, 52, 201, DateTimeKind.Utc).AddTicks(6399) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 139L, new DateTime(2023, 5, 20, 2, 21, 22, 372, DateTimeKind.Utc).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 24L, new DateTime(2023, 3, 3, 20, 31, 43, 820, DateTimeKind.Utc).AddTicks(7797) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 86L, new DateTime(2023, 1, 19, 12, 6, 15, 873, DateTimeKind.Utc).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 110L, new DateTime(2023, 1, 5, 3, 54, 42, 742, DateTimeKind.Utc).AddTicks(5855) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 199L, new DateTime(2022, 5, 27, 12, 52, 3, 940, DateTimeKind.Utc).AddTicks(3919) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 37L, new DateTime(2023, 3, 29, 8, 14, 57, 12, DateTimeKind.Utc).AddTicks(8404) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 183L, new DateTime(2023, 9, 2, 10, 48, 58, 758, DateTimeKind.Utc).AddTicks(5699) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 43L, new DateTime(2023, 5, 18, 22, 52, 43, 545, DateTimeKind.Utc).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 50L, new DateTime(2023, 8, 22, 23, 38, 7, 372, DateTimeKind.Utc).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 73L, new DateTime(2023, 9, 12, 11, 0, 48, 30, DateTimeKind.Utc).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 198L, new DateTime(2023, 7, 8, 13, 44, 39, 120, DateTimeKind.Utc).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 21L, new DateTime(2023, 9, 9, 16, 50, 3, 166, DateTimeKind.Utc).AddTicks(3952) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 167L, new DateTime(2023, 1, 2, 20, 11, 22, 174, DateTimeKind.Utc).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 53L, new DateTime(2023, 9, 2, 14, 37, 15, 308, DateTimeKind.Utc).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 143L, new DateTime(2023, 3, 5, 8, 6, 48, 841, DateTimeKind.Utc).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 153L, new DateTime(2023, 9, 10, 7, 43, 52, 968, DateTimeKind.Utc).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 65L, new DateTime(2023, 7, 25, 8, 51, 37, 901, DateTimeKind.Utc).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 146L, new DateTime(2023, 9, 11, 4, 2, 22, 36, DateTimeKind.Utc).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 46L, new DateTime(2023, 2, 9, 8, 17, 50, 515, DateTimeKind.Utc).AddTicks(603) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 183L, new DateTime(2023, 9, 10, 21, 0, 41, 949, DateTimeKind.Utc).AddTicks(8039) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 163L, new DateTime(2023, 1, 10, 22, 58, 24, 23, DateTimeKind.Utc).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 193L, new DateTime(2023, 8, 23, 14, 22, 7, 301, DateTimeKind.Utc).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 86L, new DateTime(2021, 1, 18, 5, 12, 38, 100, DateTimeKind.Utc).AddTicks(8093) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 19L, new DateTime(2023, 6, 23, 21, 10, 24, 209, DateTimeKind.Utc).AddTicks(5465) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 1, 6, 24, 14, 265, DateTimeKind.Utc).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 96L, new DateTime(2023, 4, 15, 20, 28, 0, 377, DateTimeKind.Utc).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 16L, new DateTime(2023, 5, 18, 3, 42, 50, 550, DateTimeKind.Utc).AddTicks(6306) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 58L, new DateTime(2022, 4, 11, 18, 57, 20, 150, DateTimeKind.Utc).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 179L, new DateTime(2023, 5, 20, 16, 44, 58, 251, DateTimeKind.Utc).AddTicks(4967) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 10L, new DateTime(2023, 3, 12, 5, 40, 43, 435, DateTimeKind.Utc).AddTicks(2347) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 146L, new DateTime(2023, 8, 28, 18, 13, 57, 131, DateTimeKind.Utc).AddTicks(3122) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 153L, new DateTime(2023, 8, 3, 22, 47, 11, 298, DateTimeKind.Utc).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 72L, new DateTime(2023, 8, 31, 13, 37, 9, 799, DateTimeKind.Utc).AddTicks(9609) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 66L, new DateTime(2023, 8, 24, 21, 38, 19, 846, DateTimeKind.Utc).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 197L, new DateTime(2023, 3, 28, 0, 51, 14, 3, DateTimeKind.Utc).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 133L, new DateTime(2023, 9, 11, 9, 26, 54, 623, DateTimeKind.Utc).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 177L, new DateTime(2023, 7, 30, 22, 33, 36, 986, DateTimeKind.Utc).AddTicks(6553) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 122L, new DateTime(2023, 6, 30, 8, 37, 0, 230, DateTimeKind.Utc).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 62L, new DateTime(2023, 4, 18, 0, 0, 52, 300, DateTimeKind.Utc).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 43L, new DateTime(2022, 9, 20, 21, 26, 36, 546, DateTimeKind.Utc).AddTicks(3901) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 3L, new DateTime(2022, 8, 5, 16, 44, 58, 904, DateTimeKind.Utc).AddTicks(6222) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 162L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 75L, new DateTime(2021, 12, 19, 20, 8, 5, 82, DateTimeKind.Utc).AddTicks(3669) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 163L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 75L, new DateTime(2022, 1, 9, 23, 19, 58, 344, DateTimeKind.Utc).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 164L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 175L, new DateTime(2023, 7, 17, 7, 52, 54, 226, DateTimeKind.Utc).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 165L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 41L, new DateTime(2023, 8, 5, 11, 21, 33, 541, DateTimeKind.Utc).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 177L, new DateTime(2023, 8, 26, 17, 57, 16, 2, DateTimeKind.Utc).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 142L, new DateTime(2023, 8, 23, 21, 49, 49, 472, DateTimeKind.Utc).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 56L, new DateTime(2023, 9, 7, 18, 14, 20, 684, DateTimeKind.Utc).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 152L, new DateTime(2023, 7, 18, 1, 44, 30, 918, DateTimeKind.Utc).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 43L, new DateTime(2023, 1, 17, 21, 38, 23, 375, DateTimeKind.Utc).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 2L, new DateTime(2023, 7, 16, 14, 21, 43, 700, DateTimeKind.Utc).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 158L, new DateTime(2023, 4, 27, 14, 42, 15, 346, DateTimeKind.Utc).AddTicks(3729) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 80L, new DateTime(2023, 7, 29, 5, 0, 58, 847, DateTimeKind.Utc).AddTicks(5393) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 11L, new DateTime(2022, 5, 4, 8, 24, 4, 95, DateTimeKind.Utc).AddTicks(5081) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 74L, new DateTime(2023, 8, 28, 14, 11, 34, 230, DateTimeKind.Utc).AddTicks(137) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 61L, new DateTime(2022, 10, 15, 9, 12, 56, 223, DateTimeKind.Utc).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 80L, new DateTime(2023, 8, 26, 19, 9, 3, 154, DateTimeKind.Utc).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 100L, new DateTime(2022, 5, 23, 9, 11, 27, 486, DateTimeKind.Utc).AddTicks(4483) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 94L, new DateTime(2023, 3, 29, 6, 33, 5, 1, DateTimeKind.Utc).AddTicks(6341) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 21L, new DateTime(2023, 9, 11, 11, 39, 58, 169, DateTimeKind.Utc).AddTicks(8304) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 154L, new DateTime(2023, 6, 2, 20, 35, 2, 709, DateTimeKind.Utc).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 85L, new DateTime(2023, 8, 26, 16, 41, 42, 731, DateTimeKind.Utc).AddTicks(6190) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 128L, new DateTime(2023, 6, 17, 2, 59, 20, 463, DateTimeKind.Utc).AddTicks(4747) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 24L, new DateTime(2023, 7, 11, 20, 50, 40, 140, DateTimeKind.Utc).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 158L, new DateTime(2023, 7, 22, 12, 34, 37, 339, DateTimeKind.Utc).AddTicks(5586) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 185L, new DateTime(2023, 5, 15, 17, 32, 50, 106, DateTimeKind.Utc).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 66L, new DateTime(2023, 6, 5, 20, 14, 26, 724, DateTimeKind.Utc).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 45L, new DateTime(2022, 12, 20, 3, 7, 30, 177, DateTimeKind.Utc).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 55L, new DateTime(2023, 9, 1, 16, 22, 41, 260, DateTimeKind.Utc).AddTicks(5485) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 93L, new DateTime(2023, 3, 5, 4, 41, 43, 407, DateTimeKind.Utc).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 40L, new DateTime(2023, 8, 27, 0, 0, 29, 817, DateTimeKind.Utc).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 36L, new DateTime(2022, 12, 8, 19, 3, 23, 901, DateTimeKind.Utc).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 184L, new DateTime(2023, 9, 9, 3, 44, 24, 226, DateTimeKind.Utc).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 101L, new DateTime(2021, 10, 19, 8, 46, 21, 632, DateTimeKind.Utc).AddTicks(3428) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 135L, new DateTime(2023, 6, 19, 2, 55, 42, 826, DateTimeKind.Utc).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 56L, new DateTime(2023, 9, 4, 7, 39, 12, 224, DateTimeKind.Utc).AddTicks(5044) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 100L, new DateTime(2021, 7, 25, 22, 16, 38, 493, DateTimeKind.Utc).AddTicks(2078) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 148L, new DateTime(2023, 9, 10, 12, 49, 56, 430, DateTimeKind.Utc).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 133L, new DateTime(2023, 8, 30, 11, 55, 0, 711, DateTimeKind.Utc).AddTicks(6683) });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 129L, new DateTime(2023, 9, 9, 2, 0, 4, 507, DateTimeKind.Utc).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(800), 27L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1041), 28L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1053), 37L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1062), 21L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1070), 14L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1078), 31L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 11L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1086), 29L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1094), 6L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1102), 34L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1109), 16L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 11L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1117), 7L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1124), 16L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1132), 24L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1140), 15L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1147), 21L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1206), 1L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1215), 23L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1222), 27L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 11L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1230), 19L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1237), 2L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1249), 9L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1256), 37L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1263), 37L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1270), 39L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1277), 23L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1284), 15L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1292), 34L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1299), 16L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1306), 21L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1313), 15L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 11L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1320), 26L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1327), 28L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1335), 27L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1342), 12L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1349), 34L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1357), 10L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 12L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1364), 12L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1371), 21L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1378), 23L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1385), 39L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1392), 27L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1400), 32L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1441), 18L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1450), 1L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 12L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1457), 32L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1465), 19L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1472), 18L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 12L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1479), 24L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1486), 16L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1493), 13L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1501), 35L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1508), 32L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1515), 2L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 11L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1522), 13L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1529), 25L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1536), 40L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1543), 36L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1550), 6L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 11L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1558), 6L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1565), 2L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1572), 13L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1579), 14L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1586), 12L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 12L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1593), 23L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1600), 13L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 11L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1608), 20L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1615), 14L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1622), 20L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1629), 12L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1636), 31L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1679), 1L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1687), 34L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1695), 23L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1702), 8L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1708), 31L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1715), 32L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1723), 33L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1730), 37L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1737), 29L });

            migrationBuilder.UpdateData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "BadgeId", "CreatedAt", "UserId" },
                values: new object[] { 12L, new DateTime(2023, 9, 12, 16, 17, 29, 730, DateTimeKind.Local).AddTicks(1744), 23L });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 57L, new DateTime(2023, 5, 27, 21, 46, 53, 988, DateTimeKind.Utc).AddTicks(7308), new DateTime(2023, 7, 30, 8, 7, 15, 754, DateTimeKind.Utc).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 98L, new DateTime(2023, 8, 27, 22, 24, 23, 17, DateTimeKind.Utc).AddTicks(7976), new DateTime(2023, 9, 12, 0, 48, 16, 641, DateTimeKind.Utc).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 61L, new DateTime(2023, 3, 26, 18, 34, 11, 955, DateTimeKind.Utc).AddTicks(5778) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 21L, new DateTime(2023, 9, 10, 17, 34, 47, 435, DateTimeKind.Utc).AddTicks(8161), new DateTime(2023, 9, 12, 6, 56, 54, 86, DateTimeKind.Utc).AddTicks(2127) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 76L, new DateTime(2023, 4, 14, 23, 7, 50, 387, DateTimeKind.Utc).AddTicks(8386), new DateTime(2023, 7, 23, 8, 28, 29, 57, DateTimeKind.Utc).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 4L, new DateTime(2023, 6, 14, 11, 3, 52, 480, DateTimeKind.Utc).AddTicks(6280), new DateTime(2023, 7, 9, 4, 31, 55, 569, DateTimeKind.Utc).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 56L, new DateTime(2023, 9, 6, 7, 16, 39, 287, DateTimeKind.Utc).AddTicks(5730), new DateTime(2023, 9, 9, 13, 29, 32, 662, DateTimeKind.Utc).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 100L, new DateTime(2022, 5, 6, 5, 59, 58, 567, DateTimeKind.Utc).AddTicks(5181), new DateTime(2023, 7, 3, 5, 0, 55, 255, DateTimeKind.Utc).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 62L, new DateTime(2023, 8, 7, 16, 55, 25, 845, DateTimeKind.Utc).AddTicks(8721), new DateTime(2023, 9, 1, 3, 2, 2, 478, DateTimeKind.Utc).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 15L, new DateTime(2023, 4, 9, 13, 59, 16, 806, DateTimeKind.Utc).AddTicks(1735), new DateTime(2023, 4, 23, 21, 1, 47, 901, DateTimeKind.Utc).AddTicks(647) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 37L, new DateTime(2023, 1, 6, 3, 46, 20, 629, DateTimeKind.Utc).AddTicks(8700), new DateTime(2023, 5, 21, 9, 42, 7, 875, DateTimeKind.Utc).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 28L, new DateTime(2023, 8, 31, 18, 29, 19, 505, DateTimeKind.Utc).AddTicks(7355), new DateTime(2023, 9, 2, 1, 58, 15, 601, DateTimeKind.Utc).AddTicks(1689) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 45L, new DateTime(2023, 4, 21, 10, 54, 8, 545, DateTimeKind.Utc).AddTicks(4821), new DateTime(2023, 8, 30, 18, 19, 3, 55, DateTimeKind.Utc).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 60L, new DateTime(2023, 7, 14, 15, 7, 37, 39, DateTimeKind.Utc).AddTicks(5928), new DateTime(2023, 7, 30, 11, 32, 28, 733, DateTimeKind.Utc).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 69L, new DateTime(2023, 8, 31, 12, 19, 51, 496, DateTimeKind.Utc).AddTicks(5905), new DateTime(2023, 9, 1, 9, 2, 15, 351, DateTimeKind.Utc).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 116L, new DateTime(2023, 7, 1, 6, 58, 56, 213, DateTimeKind.Utc).AddTicks(9327), new DateTime(2023, 7, 2, 14, 21, 6, 454, DateTimeKind.Utc).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 33L, new DateTime(2023, 2, 11, 6, 55, 4, 595, DateTimeKind.Utc).AddTicks(2326), new DateTime(2023, 8, 19, 12, 10, 41, 932, DateTimeKind.Utc).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 5L, new DateTime(2020, 10, 26, 0, 56, 17, 789, DateTimeKind.Utc).AddTicks(5111), new DateTime(2021, 6, 4, 20, 10, 25, 711, DateTimeKind.Utc).AddTicks(785) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 70L, new DateTime(2023, 9, 7, 15, 4, 20, 287, DateTimeKind.Utc).AddTicks(7415), new DateTime(2023, 9, 10, 19, 48, 35, 343, DateTimeKind.Utc).AddTicks(5988) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 37L, new DateTime(2023, 6, 20, 18, 18, 57, 794, DateTimeKind.Utc).AddTicks(5807), new DateTime(2023, 6, 24, 23, 15, 8, 956, DateTimeKind.Utc).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 26L, new DateTime(2023, 1, 22, 10, 21, 41, 155, DateTimeKind.Utc).AddTicks(8715), new DateTime(2023, 8, 15, 2, 48, 8, 496, DateTimeKind.Utc).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 39L, new DateTime(2023, 6, 18, 14, 20, 33, 42, DateTimeKind.Utc).AddTicks(6861), new DateTime(2023, 7, 29, 14, 25, 31, 624, DateTimeKind.Utc).AddTicks(4484) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 98L, new DateTime(2023, 8, 30, 17, 39, 50, 487, DateTimeKind.Utc).AddTicks(7044), new DateTime(2023, 9, 11, 6, 49, 1, 44, DateTimeKind.Utc).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 63L, new DateTime(2023, 8, 8, 1, 39, 26, 999, DateTimeKind.Utc).AddTicks(8085), new DateTime(2023, 8, 26, 21, 12, 32, 205, DateTimeKind.Utc).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 76L, new DateTime(2023, 7, 16, 10, 53, 54, 84, DateTimeKind.Utc).AddTicks(8423), new DateTime(2023, 9, 10, 14, 49, 22, 966, DateTimeKind.Utc).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 41L, new DateTime(2023, 7, 3, 7, 39, 50, 984, DateTimeKind.Utc).AddTicks(7357), new DateTime(2023, 7, 25, 11, 49, 53, 434, DateTimeKind.Utc).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 137L, new DateTime(2023, 7, 12, 20, 6, 4, 95, DateTimeKind.Utc).AddTicks(627), new DateTime(2023, 9, 9, 8, 57, 51, 51, DateTimeKind.Utc).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 108L, new DateTime(2022, 8, 21, 6, 21, 14, 302, DateTimeKind.Utc).AddTicks(2424), new DateTime(2023, 3, 24, 17, 33, 31, 832, DateTimeKind.Utc).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 132L, new DateTime(2023, 8, 23, 10, 30, 53, 888, DateTimeKind.Utc).AddTicks(4023) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 70L, new DateTime(2023, 9, 11, 6, 34, 37, 43, DateTimeKind.Utc).AddTicks(6831), new DateTime(2023, 9, 11, 18, 36, 5, 178, DateTimeKind.Utc).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 66L, new DateTime(2023, 8, 6, 17, 3, 6, 407, DateTimeKind.Utc).AddTicks(7773), new DateTime(2023, 8, 12, 8, 3, 29, 741, DateTimeKind.Utc).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 14L, new DateTime(2023, 1, 5, 12, 49, 7, 966, DateTimeKind.Utc).AddTicks(7058), new DateTime(2023, 8, 9, 7, 43, 21, 119, DateTimeKind.Utc).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 72L, new DateTime(2023, 8, 13, 4, 51, 54, 720, DateTimeKind.Utc).AddTicks(9480), new DateTime(2023, 8, 23, 16, 15, 29, 989, DateTimeKind.Utc).AddTicks(7918) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 172L, new DateTime(2023, 7, 30, 19, 4, 24, 856, DateTimeKind.Utc).AddTicks(3485), new DateTime(2023, 8, 22, 12, 8, 32, 115, DateTimeKind.Utc).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 30L, new DateTime(2022, 12, 18, 7, 0, 8, 725, DateTimeKind.Utc).AddTicks(1535), new DateTime(2023, 1, 15, 4, 16, 3, 660, DateTimeKind.Utc).AddTicks(7856) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 116L, new DateTime(2022, 12, 17, 9, 50, 40, 377, DateTimeKind.Utc).AddTicks(284), new DateTime(2023, 1, 8, 3, 26, 33, 882, DateTimeKind.Utc).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 54L, new DateTime(2020, 10, 27, 4, 58, 18, 174, DateTimeKind.Utc).AddTicks(7935), new DateTime(2022, 12, 8, 23, 35, 58, 254, DateTimeKind.Utc).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 39L, new DateTime(2023, 6, 8, 1, 7, 21, 989, DateTimeKind.Utc).AddTicks(8417), new DateTime(2023, 7, 1, 22, 20, 33, 523, DateTimeKind.Utc).AddTicks(6664) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 106L, new DateTime(2023, 5, 15, 5, 9, 31, 874, DateTimeKind.Utc).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 172L, new DateTime(2023, 9, 5, 20, 10, 51, 573, DateTimeKind.Utc).AddTicks(9085), new DateTime(2023, 9, 8, 10, 43, 52, 536, DateTimeKind.Utc).AddTicks(1901) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 122L, new DateTime(2023, 7, 20, 19, 34, 40, 549, DateTimeKind.Utc).AddTicks(4892), new DateTime(2023, 8, 26, 3, 27, 11, 595, DateTimeKind.Utc).AddTicks(3685) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 68L, new DateTime(2023, 1, 5, 10, 49, 7, 440, DateTimeKind.Utc).AddTicks(9790), new DateTime(2023, 6, 28, 17, 36, 12, 477, DateTimeKind.Utc).AddTicks(92) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 34L, new DateTime(2023, 9, 9, 11, 12, 12, 361, DateTimeKind.Utc).AddTicks(3627), new DateTime(2023, 9, 9, 16, 0, 35, 76, DateTimeKind.Utc).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 96L, new DateTime(2023, 5, 26, 11, 1, 42, 626, DateTimeKind.Utc).AddTicks(8240), new DateTime(2023, 8, 1, 2, 19, 43, 241, DateTimeKind.Utc).AddTicks(4891) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 70L, new DateTime(2023, 9, 3, 2, 41, 1, 195, DateTimeKind.Utc).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 73L, new DateTime(2023, 9, 7, 19, 43, 8, 43, DateTimeKind.Utc).AddTicks(7299), new DateTime(2023, 9, 9, 15, 29, 52, 110, DateTimeKind.Utc).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 61L, new DateTime(2023, 7, 30, 12, 5, 21, 176, DateTimeKind.Utc).AddTicks(7890), new DateTime(2023, 9, 7, 14, 21, 21, 22, DateTimeKind.Utc).AddTicks(2031) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 43L, new DateTime(2023, 5, 13, 23, 4, 7, 192, DateTimeKind.Utc).AddTicks(9736), new DateTime(2023, 6, 19, 5, 54, 31, 261, DateTimeKind.Utc).AddTicks(8845) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 109L, new DateTime(2023, 9, 9, 19, 55, 27, 715, DateTimeKind.Utc).AddTicks(3599), new DateTime(2023, 9, 10, 13, 48, 36, 614, DateTimeKind.Utc).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 126L, new DateTime(2023, 6, 1, 15, 56, 39, 342, DateTimeKind.Utc).AddTicks(6764), new DateTime(2023, 8, 23, 4, 25, 15, 697, DateTimeKind.Utc).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 169L, new DateTime(2023, 8, 3, 7, 29, 56, 308, DateTimeKind.Utc).AddTicks(8851), new DateTime(2023, 8, 20, 5, 43, 7, 415, DateTimeKind.Utc).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 117L, new DateTime(2023, 6, 21, 22, 50, 39, 551, DateTimeKind.Utc).AddTicks(7976) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 27L, new DateTime(2023, 8, 19, 2, 5, 53, 944, DateTimeKind.Utc).AddTicks(5447), new DateTime(2023, 8, 19, 12, 22, 9, 526, DateTimeKind.Utc).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 110L, new DateTime(2023, 7, 28, 16, 22, 8, 682, DateTimeKind.Utc).AddTicks(4521), new DateTime(2023, 8, 23, 13, 23, 38, 808, DateTimeKind.Utc).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 76L, new DateTime(2023, 3, 23, 0, 16, 25, 686, DateTimeKind.Utc).AddTicks(5114), new DateTime(2023, 9, 12, 11, 6, 12, 989, DateTimeKind.Utc).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 93L, new DateTime(2023, 4, 3, 2, 0, 50, 510, DateTimeKind.Utc).AddTicks(6383) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 33L, new DateTime(2023, 3, 23, 13, 35, 39, 837, DateTimeKind.Utc).AddTicks(172), new DateTime(2023, 7, 21, 16, 52, 5, 691, DateTimeKind.Utc).AddTicks(4967) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 36L, new DateTime(2023, 7, 3, 23, 49, 54, 645, DateTimeKind.Utc).AddTicks(3804), new DateTime(2023, 8, 23, 16, 8, 45, 801, DateTimeKind.Utc).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 76L, new DateTime(2023, 7, 6, 13, 9, 11, 185, DateTimeKind.Utc).AddTicks(2858), new DateTime(2023, 7, 13, 7, 19, 30, 675, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 44L, new DateTime(2023, 7, 18, 17, 53, 46, 526, DateTimeKind.Utc).AddTicks(6898), new DateTime(2023, 8, 21, 0, 18, 40, 978, DateTimeKind.Utc).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 66L, new DateTime(2022, 10, 22, 19, 14, 18, 574, DateTimeKind.Utc).AddTicks(6882), new DateTime(2023, 4, 24, 21, 24, 23, 268, DateTimeKind.Utc).AddTicks(9309) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 117L, new DateTime(2023, 1, 10, 3, 33, 29, 490, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 70L, new DateTime(2023, 9, 8, 4, 34, 9, 940, DateTimeKind.Utc).AddTicks(461), new DateTime(2023, 9, 8, 17, 56, 39, 554, DateTimeKind.Utc).AddTicks(2009) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 63L, new DateTime(2023, 8, 2, 14, 22, 3, 167, DateTimeKind.Utc).AddTicks(1544), new DateTime(2023, 9, 10, 23, 5, 29, 659, DateTimeKind.Utc).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 27L, new DateTime(2023, 8, 24, 2, 4, 20, 654, DateTimeKind.Utc).AddTicks(4067), new DateTime(2023, 8, 29, 3, 46, 14, 847, DateTimeKind.Utc).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 11L, new DateTime(2021, 7, 24, 11, 56, 28, 642, DateTimeKind.Utc).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 60L, new DateTime(2023, 8, 23, 10, 1, 35, 496, DateTimeKind.Utc).AddTicks(4791), new DateTime(2023, 9, 6, 5, 50, 0, 717, DateTimeKind.Utc).AddTicks(5513) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 38L, new DateTime(2023, 9, 9, 14, 34, 29, 627, DateTimeKind.Utc).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 26L, new DateTime(2023, 2, 21, 0, 36, 37, 218, DateTimeKind.Utc).AddTicks(1034), new DateTime(2023, 7, 14, 22, 47, 48, 618, DateTimeKind.Utc).AddTicks(9717) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 20L, new DateTime(2023, 7, 11, 16, 1, 3, 783, DateTimeKind.Utc).AddTicks(6331), new DateTime(2023, 9, 5, 0, 20, 47, 362, DateTimeKind.Utc).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 74L, new DateTime(2023, 7, 6, 15, 1, 57, 683, DateTimeKind.Utc).AddTicks(4176), new DateTime(2023, 8, 15, 23, 5, 23, 127, DateTimeKind.Utc).AddTicks(6519) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 141L, new DateTime(2023, 6, 9, 22, 12, 9, 643, DateTimeKind.Utc).AddTicks(665), new DateTime(2023, 6, 12, 21, 15, 5, 395, DateTimeKind.Utc).AddTicks(9888) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 41L, new DateTime(2023, 7, 8, 18, 58, 40, 324, DateTimeKind.Utc).AddTicks(1199), new DateTime(2023, 7, 9, 13, 54, 47, 517, DateTimeKind.Utc).AddTicks(5533) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 55L, new DateTime(2023, 7, 17, 3, 57, 43, 19, DateTimeKind.Utc).AddTicks(7705), new DateTime(2023, 8, 24, 7, 47, 52, 294, DateTimeKind.Utc).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 47L, new DateTime(2023, 8, 31, 3, 43, 25, 763, DateTimeKind.Utc).AddTicks(3680), new DateTime(2023, 9, 10, 18, 35, 45, 547, DateTimeKind.Utc).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 10L, new DateTime(2023, 7, 21, 14, 32, 32, 254, DateTimeKind.Utc).AddTicks(9716), new DateTime(2023, 8, 6, 19, 53, 17, 15, DateTimeKind.Utc).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 32L, new DateTime(2022, 1, 17, 13, 38, 52, 229, DateTimeKind.Utc).AddTicks(4492), new DateTime(2022, 10, 19, 2, 52, 7, 806, DateTimeKind.Utc).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 12L, new DateTime(2023, 5, 31, 19, 23, 23, 261, DateTimeKind.Utc).AddTicks(7604), new DateTime(2023, 6, 10, 19, 26, 58, 158, DateTimeKind.Utc).AddTicks(4854) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 69L, new DateTime(2023, 9, 7, 14, 26, 10, 94, DateTimeKind.Utc).AddTicks(241), new DateTime(2023, 9, 9, 11, 16, 23, 214, DateTimeKind.Utc).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 44L, new DateTime(2023, 7, 8, 7, 22, 7, 311, DateTimeKind.Utc).AddTicks(3653), new DateTime(2023, 8, 21, 13, 22, 15, 460, DateTimeKind.Utc).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 193L, new DateTime(2023, 6, 30, 3, 13, 34, 30, DateTimeKind.Utc).AddTicks(1498), new DateTime(2023, 7, 16, 1, 17, 37, 391, DateTimeKind.Utc).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 93L, new DateTime(2023, 6, 9, 8, 37, 16, 701, DateTimeKind.Utc).AddTicks(5745), new DateTime(2023, 8, 17, 17, 7, 2, 551, DateTimeKind.Utc).AddTicks(8482) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 181L, new DateTime(2023, 5, 17, 12, 45, 11, 68, DateTimeKind.Utc).AddTicks(9280), new DateTime(2023, 8, 3, 8, 0, 42, 856, DateTimeKind.Utc).AddTicks(8594) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 11L, new DateTime(2021, 12, 4, 0, 12, 4, 841, DateTimeKind.Utc).AddTicks(4118), new DateTime(2022, 7, 5, 2, 35, 42, 31, DateTimeKind.Utc).AddTicks(1284) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 27L, new DateTime(2023, 8, 30, 11, 38, 38, 8, DateTimeKind.Utc).AddTicks(6849), new DateTime(2023, 9, 4, 1, 21, 14, 715, DateTimeKind.Utc).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 56L, new DateTime(2023, 9, 3, 6, 34, 30, 884, DateTimeKind.Utc).AddTicks(3274), new DateTime(2023, 9, 6, 5, 45, 36, 612, DateTimeKind.Utc).AddTicks(4957) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 100L, new DateTime(2022, 3, 7, 22, 32, 34, 85, DateTimeKind.Utc).AddTicks(6443), new DateTime(2023, 4, 28, 7, 19, 24, 599, DateTimeKind.Utc).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 96L, new DateTime(2023, 7, 23, 19, 45, 55, 270, DateTimeKind.Utc).AddTicks(8105), new DateTime(2023, 8, 3, 12, 24, 16, 367, DateTimeKind.Utc).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 27L, new DateTime(2023, 9, 6, 6, 4, 0, 62, DateTimeKind.Utc).AddTicks(1253), new DateTime(2023, 9, 7, 8, 6, 48, 933, DateTimeKind.Utc).AddTicks(8182) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 108L, new DateTime(2022, 11, 5, 21, 53, 42, 56, DateTimeKind.Utc).AddTicks(7936), new DateTime(2022, 11, 6, 20, 7, 0, 365, DateTimeKind.Utc).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 63L, new DateTime(2023, 6, 2, 7, 31, 48, 55, DateTimeKind.Utc).AddTicks(9182), new DateTime(2023, 6, 18, 17, 27, 26, 927, DateTimeKind.Utc).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 32L, new DateTime(2019, 9, 22, 0, 16, 10, 516, DateTimeKind.Utc).AddTicks(8360), new DateTime(2021, 7, 9, 16, 55, 52, 63, DateTimeKind.Utc).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 83L, new DateTime(2022, 10, 17, 5, 41, 43, 772, DateTimeKind.Utc).AddTicks(2335), new DateTime(2022, 12, 29, 16, 4, 44, 532, DateTimeKind.Utc).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 84L, new DateTime(2023, 9, 8, 8, 41, 31, 390, DateTimeKind.Utc).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 74L, new DateTime(2023, 6, 14, 19, 42, 14, 256, DateTimeKind.Utc).AddTicks(6004), new DateTime(2023, 6, 28, 13, 8, 26, 706, DateTimeKind.Utc).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 5L, new DateTime(2022, 4, 12, 16, 38, 39, 197, DateTimeKind.Utc).AddTicks(8009), new DateTime(2022, 10, 9, 11, 18, 13, 993, DateTimeKind.Utc).AddTicks(4546) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 32L, new DateTime(2022, 8, 3, 21, 40, 48, 347, DateTimeKind.Utc).AddTicks(518), new DateTime(2023, 4, 6, 14, 13, 49, 79, DateTimeKind.Utc).AddTicks(1180) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 32L, new DateTime(2022, 8, 13, 10, 6, 3, 432, DateTimeKind.Utc).AddTicks(6898), new DateTime(2023, 5, 1, 3, 32, 13, 292, DateTimeKind.Utc).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 193L, new DateTime(2023, 8, 22, 15, 28, 33, 134, DateTimeKind.Utc).AddTicks(4887), new DateTime(2023, 8, 27, 19, 24, 34, 423, DateTimeKind.Utc).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 83L, new DateTime(2022, 9, 16, 12, 11, 3, 751, DateTimeKind.Utc).AddTicks(8554), new DateTime(2022, 11, 18, 22, 23, 57, 219, DateTimeKind.Utc).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 22L, new DateTime(2023, 5, 16, 9, 33, 45, 410, DateTimeKind.Utc).AddTicks(4780), new DateTime(2023, 8, 13, 18, 59, 54, 209, DateTimeKind.Utc).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 3L, new DateTime(2022, 3, 26, 0, 48, 49, 194, DateTimeKind.Utc).AddTicks(8875), new DateTime(2023, 4, 17, 12, 51, 8, 201, DateTimeKind.Utc).AddTicks(2628) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 53L, new DateTime(2023, 8, 11, 8, 1, 12, 608, DateTimeKind.Utc).AddTicks(7211), new DateTime(2023, 9, 7, 16, 33, 27, 881, DateTimeKind.Utc).AddTicks(5178) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 16L, new DateTime(2023, 6, 26, 15, 11, 15, 720, DateTimeKind.Utc).AddTicks(9902), new DateTime(2023, 6, 30, 21, 55, 18, 794, DateTimeKind.Utc).AddTicks(2838) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 70L, new DateTime(2023, 9, 7, 15, 3, 43, 124, DateTimeKind.Utc).AddTicks(7872), new DateTime(2023, 9, 8, 16, 7, 7, 471, DateTimeKind.Utc).AddTicks(3708) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 91L, new DateTime(2019, 12, 5, 18, 55, 31, 277, DateTimeKind.Utc).AddTicks(3589), new DateTime(2021, 1, 31, 22, 27, 8, 688, DateTimeKind.Utc).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 128L, new DateTime(2023, 6, 5, 10, 27, 35, 100, DateTimeKind.Utc).AddTicks(8851), new DateTime(2023, 8, 5, 22, 41, 20, 407, DateTimeKind.Utc).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 68L, new DateTime(2023, 7, 6, 1, 31, 41, 148, DateTimeKind.Utc).AddTicks(8261), new DateTime(2023, 7, 20, 14, 22, 39, 969, DateTimeKind.Utc).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 90L, new DateTime(2023, 4, 28, 22, 10, 55, 413, DateTimeKind.Utc).AddTicks(3557), new DateTime(2023, 7, 7, 18, 53, 6, 73, DateTimeKind.Utc).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 33L, new DateTime(2023, 4, 25, 16, 35, 0, 576, DateTimeKind.Utc).AddTicks(3142), new DateTime(2023, 6, 13, 16, 19, 41, 614, DateTimeKind.Utc).AddTicks(7121) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 129L, new DateTime(2023, 9, 12, 8, 47, 36, 886, DateTimeKind.Utc).AddTicks(6771), new DateTime(2023, 9, 12, 9, 40, 14, 486, DateTimeKind.Utc).AddTicks(3945) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 6L, new DateTime(2023, 3, 14, 16, 59, 42, 302, DateTimeKind.Utc).AddTicks(6506), new DateTime(2023, 7, 10, 11, 58, 28, 616, DateTimeKind.Utc).AddTicks(6261) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 62L, new DateTime(2023, 8, 14, 8, 36, 30, 703, DateTimeKind.Utc).AddTicks(7005), new DateTime(2023, 8, 24, 13, 6, 4, 624, DateTimeKind.Utc).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 37L, new DateTime(2023, 3, 15, 1, 56, 28, 316, DateTimeKind.Utc).AddTicks(3982), new DateTime(2023, 7, 9, 17, 34, 15, 284, DateTimeKind.Utc).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 45L, new DateTime(2022, 9, 18, 23, 27, 5, 936, DateTimeKind.Utc).AddTicks(1819), new DateTime(2023, 2, 9, 16, 26, 38, 115, DateTimeKind.Utc).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 89L, new DateTime(2023, 6, 17, 7, 59, 15, 821, DateTimeKind.Utc).AddTicks(465), new DateTime(2023, 7, 30, 14, 0, 50, 477, DateTimeKind.Utc).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 30L, new DateTime(2023, 4, 11, 8, 17, 24, 565, DateTimeKind.Utc).AddTicks(8660), new DateTime(2023, 6, 22, 16, 23, 47, 728, DateTimeKind.Utc).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "RegisteredAt",
                value: new DateTime(2016, 5, 19, 21, 23, 28, 185, DateTimeKind.Utc).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "RegisteredAt",
                value: new DateTime(2016, 4, 10, 17, 1, 27, 536, DateTimeKind.Utc).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                column: "RegisteredAt",
                value: new DateTime(2017, 11, 10, 19, 19, 15, 299, DateTimeKind.Utc).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                column: "RegisteredAt",
                value: new DateTime(2018, 7, 26, 14, 59, 9, 103, DateTimeKind.Utc).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                column: "RegisteredAt",
                value: new DateTime(2017, 8, 16, 9, 37, 26, 220, DateTimeKind.Utc).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                column: "RegisteredAt",
                value: new DateTime(2022, 3, 7, 23, 21, 56, 511, DateTimeKind.Utc).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                column: "RegisteredAt",
                value: new DateTime(2020, 9, 19, 0, 18, 39, 186, DateTimeKind.Utc).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                column: "RegisteredAt",
                value: new DateTime(2022, 6, 2, 9, 10, 53, 533, DateTimeKind.Utc).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                column: "RegisteredAt",
                value: new DateTime(2021, 12, 8, 7, 9, 48, 807, DateTimeKind.Utc).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                column: "RegisteredAt",
                value: new DateTime(2018, 7, 20, 20, 18, 18, 559, DateTimeKind.Utc).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11L,
                column: "RegisteredAt",
                value: new DateTime(2022, 3, 29, 13, 32, 19, 620, DateTimeKind.Utc).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12L,
                column: "RegisteredAt",
                value: new DateTime(2019, 9, 17, 19, 29, 46, 349, DateTimeKind.Utc).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13L,
                column: "RegisteredAt",
                value: new DateTime(2021, 3, 13, 22, 28, 35, 753, DateTimeKind.Utc).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14L,
                column: "RegisteredAt",
                value: new DateTime(2016, 6, 10, 2, 35, 5, 590, DateTimeKind.Utc).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15L,
                column: "RegisteredAt",
                value: new DateTime(2022, 3, 17, 21, 50, 50, 940, DateTimeKind.Utc).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16L,
                column: "RegisteredAt",
                value: new DateTime(2017, 6, 23, 12, 28, 30, 995, DateTimeKind.Utc).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17L,
                column: "RegisteredAt",
                value: new DateTime(2016, 1, 19, 23, 6, 1, 281, DateTimeKind.Utc).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18L,
                column: "RegisteredAt",
                value: new DateTime(2022, 12, 31, 17, 0, 35, 563, DateTimeKind.Utc).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19L,
                column: "RegisteredAt",
                value: new DateTime(2022, 4, 18, 23, 3, 40, 95, DateTimeKind.Utc).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20L,
                column: "RegisteredAt",
                value: new DateTime(2020, 12, 19, 14, 9, 37, 568, DateTimeKind.Utc).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21L,
                column: "RegisteredAt",
                value: new DateTime(2017, 1, 24, 22, 31, 46, 368, DateTimeKind.Utc).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22L,
                column: "RegisteredAt",
                value: new DateTime(2018, 5, 5, 8, 16, 52, 923, DateTimeKind.Utc).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23L,
                column: "RegisteredAt",
                value: new DateTime(2021, 11, 11, 8, 8, 31, 912, DateTimeKind.Utc).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24L,
                column: "RegisteredAt",
                value: new DateTime(2021, 4, 30, 10, 36, 38, 404, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25L,
                column: "RegisteredAt",
                value: new DateTime(2019, 2, 23, 16, 40, 44, 161, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26L,
                column: "RegisteredAt",
                value: new DateTime(2016, 6, 21, 21, 55, 36, 635, DateTimeKind.Utc).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27L,
                column: "RegisteredAt",
                value: new DateTime(2021, 12, 16, 5, 20, 7, 450, DateTimeKind.Utc).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28L,
                column: "RegisteredAt",
                value: new DateTime(2016, 7, 18, 13, 5, 31, 622, DateTimeKind.Utc).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29L,
                column: "RegisteredAt",
                value: new DateTime(2017, 8, 4, 21, 1, 9, 691, DateTimeKind.Utc).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30L,
                column: "RegisteredAt",
                value: new DateTime(2020, 8, 25, 6, 0, 30, 90, DateTimeKind.Utc).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31L,
                column: "RegisteredAt",
                value: new DateTime(2016, 12, 17, 5, 8, 17, 199, DateTimeKind.Utc).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32L,
                column: "RegisteredAt",
                value: new DateTime(2016, 12, 25, 7, 7, 14, 225, DateTimeKind.Utc).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33L,
                column: "RegisteredAt",
                value: new DateTime(2021, 12, 1, 11, 18, 9, 914, DateTimeKind.Utc).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34L,
                column: "RegisteredAt",
                value: new DateTime(2023, 3, 17, 23, 6, 42, 443, DateTimeKind.Utc).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35L,
                column: "RegisteredAt",
                value: new DateTime(2022, 2, 21, 0, 7, 23, 692, DateTimeKind.Utc).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36L,
                column: "RegisteredAt",
                value: new DateTime(2020, 4, 10, 23, 58, 1, 50, DateTimeKind.Utc).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37L,
                column: "RegisteredAt",
                value: new DateTime(2016, 5, 7, 13, 34, 51, 203, DateTimeKind.Utc).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38L,
                column: "RegisteredAt",
                value: new DateTime(2018, 12, 23, 6, 22, 53, 662, DateTimeKind.Utc).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39L,
                column: "RegisteredAt",
                value: new DateTime(2016, 7, 25, 2, 49, 36, 576, DateTimeKind.Utc).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40L,
                column: "RegisteredAt",
                value: new DateTime(2017, 10, 22, 0, 36, 49, 554, DateTimeKind.Utc).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 164L, new DateTime(2023, 8, 13, 11, 18, 30, 231, DateTimeKind.Utc).AddTicks(9511), new DateTime(2023, 9, 10, 18, 47, 28, 17, DateTimeKind.Utc).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 187L, new DateTime(2020, 10, 19, 1, 0, 42, 550, DateTimeKind.Utc).AddTicks(2375), new DateTime(2021, 6, 18, 16, 41, 23, 476, DateTimeKind.Utc).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 80L, new DateTime(2023, 7, 4, 15, 31, 38, 705, DateTimeKind.Utc).AddTicks(4336), new DateTime(2023, 9, 6, 19, 15, 1, 499, DateTimeKind.Utc).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 192L, new DateTime(2023, 1, 20, 10, 10, 12, 498, DateTimeKind.Utc).AddTicks(9292), new DateTime(2023, 1, 24, 16, 34, 47, 805, DateTimeKind.Utc).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 147L, new DateTime(2023, 6, 3, 11, 31, 5, 166, DateTimeKind.Utc).AddTicks(984), new DateTime(2023, 6, 7, 12, 44, 55, 23, DateTimeKind.Utc).AddTicks(901) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 127L, new DateTime(2023, 8, 17, 3, 3, 29, 690, DateTimeKind.Utc).AddTicks(7044), new DateTime(2023, 8, 19, 4, 20, 45, 621, DateTimeKind.Utc).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 189L, new DateTime(2022, 3, 15, 23, 18, 37, 27, DateTimeKind.Utc).AddTicks(8586), new DateTime(2022, 7, 12, 1, 45, 58, 455, DateTimeKind.Utc).AddTicks(6717) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 162L, new DateTime(2023, 8, 10, 4, 56, 54, 910, DateTimeKind.Utc).AddTicks(7387), new DateTime(2023, 9, 3, 22, 13, 10, 961, DateTimeKind.Utc).AddTicks(7446) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 99L, new DateTime(2023, 8, 9, 1, 36, 56, 23, DateTimeKind.Utc).AddTicks(2343), new DateTime(2023, 9, 4, 17, 20, 14, 986, DateTimeKind.Utc).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 133L, new DateTime(2023, 9, 9, 23, 17, 29, 526, DateTimeKind.Utc).AddTicks(3480), new DateTime(2023, 9, 12, 16, 11, 21, 53, DateTimeKind.Utc).AddTicks(5296) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 97L, new DateTime(2023, 5, 9, 16, 4, 37, 857, DateTimeKind.Utc).AddTicks(7937), new DateTime(2023, 5, 23, 8, 23, 31, 554, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 146L, new DateTime(2023, 8, 12, 16, 9, 50, 662, DateTimeKind.Utc).AddTicks(9257), new DateTime(2023, 8, 19, 0, 42, 14, 677, DateTimeKind.Utc).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 143L, new DateTime(2023, 9, 8, 11, 40, 11, 970, DateTimeKind.Utc).AddTicks(2912), new DateTime(2023, 9, 9, 10, 21, 14, 704, DateTimeKind.Utc).AddTicks(3521) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 178L, new DateTime(2021, 4, 19, 11, 4, 29, 891, DateTimeKind.Utc).AddTicks(6879), new DateTime(2021, 6, 2, 15, 22, 32, 221, DateTimeKind.Utc).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 188L, new DateTime(2023, 8, 14, 13, 21, 16, 521, DateTimeKind.Utc).AddTicks(944), new DateTime(2023, 8, 27, 3, 30, 57, 295, DateTimeKind.Utc).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 144L, new DateTime(2022, 7, 16, 3, 11, 0, 982, DateTimeKind.Utc).AddTicks(1346), new DateTime(2023, 4, 16, 19, 32, 53, 927, DateTimeKind.Utc).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 123L, new DateTime(2023, 7, 29, 21, 39, 4, 373, DateTimeKind.Utc).AddTicks(9794), new DateTime(2023, 8, 16, 6, 2, 20, 265, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 187L, new DateTime(2021, 2, 7, 0, 15, 32, 184, DateTimeKind.Utc).AddTicks(9318), new DateTime(2022, 1, 6, 15, 29, 32, 737, DateTimeKind.Utc).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 195L, new DateTime(2023, 2, 6, 3, 46, 52, 956, DateTimeKind.Utc).AddTicks(1444), new DateTime(2023, 5, 1, 7, 40, 28, 618, DateTimeKind.Utc).AddTicks(3688) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 163L, new DateTime(2023, 3, 13, 9, 15, 10, 192, DateTimeKind.Utc).AddTicks(3017), new DateTime(2023, 5, 9, 17, 41, 19, 268, DateTimeKind.Utc).AddTicks(3823) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 130L, new DateTime(2023, 5, 27, 16, 45, 33, 627, DateTimeKind.Utc).AddTicks(536), new DateTime(2023, 7, 30, 7, 43, 3, 677, DateTimeKind.Utc).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 85L, new DateTime(2023, 7, 4, 18, 59, 37, 506, DateTimeKind.Utc).AddTicks(1380), new DateTime(2023, 7, 24, 9, 18, 3, 964, DateTimeKind.Utc).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 187L, new DateTime(2020, 9, 7, 16, 58, 27, 709, DateTimeKind.Utc).AddTicks(3163), new DateTime(2022, 8, 26, 2, 39, 35, 626, DateTimeKind.Utc).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 123L, new DateTime(2023, 7, 14, 5, 34, 16, 604, DateTimeKind.Utc).AddTicks(7729), new DateTime(2023, 7, 31, 7, 10, 55, 262, DateTimeKind.Utc).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 198L, new DateTime(2023, 7, 15, 17, 42, 31, 614, DateTimeKind.Utc).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 152L, new DateTime(2023, 7, 30, 19, 46, 54, 557, DateTimeKind.Utc).AddTicks(1739), new DateTime(2023, 8, 4, 12, 7, 35, 804, DateTimeKind.Utc).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 182L, new DateTime(2022, 11, 11, 2, 41, 37, 777, DateTimeKind.Utc).AddTicks(9495), new DateTime(2023, 5, 29, 19, 32, 29, 667, DateTimeKind.Utc).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 179L, new DateTime(2023, 7, 22, 14, 10, 4, 702, DateTimeKind.Utc).AddTicks(8228), new DateTime(2023, 7, 24, 10, 46, 39, 690, DateTimeKind.Utc).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 134L, new DateTime(2023, 9, 9, 18, 20, 4, 368, DateTimeKind.Utc).AddTicks(1589) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 196L, new DateTime(2022, 11, 11, 3, 9, 4, 199, DateTimeKind.Utc).AddTicks(9513), new DateTime(2023, 7, 18, 14, 31, 19, 58, DateTimeKind.Utc).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 156L, new DateTime(2023, 8, 23, 16, 31, 43, 574, DateTimeKind.Utc).AddTicks(9459), new DateTime(2023, 9, 4, 9, 12, 32, 390, DateTimeKind.Utc).AddTicks(8985) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 179L, new DateTime(2023, 6, 4, 16, 6, 47, 301, DateTimeKind.Utc).AddTicks(9046), new DateTime(2023, 8, 2, 21, 57, 3, 373, DateTimeKind.Utc).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 199L, new DateTime(2021, 6, 8, 18, 51, 47, 792, DateTimeKind.Utc).AddTicks(8586), new DateTime(2021, 8, 14, 4, 49, 9, 132, DateTimeKind.Utc).AddTicks(7331) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 160L, new DateTime(2023, 1, 27, 11, 34, 28, 25, DateTimeKind.Utc).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 164L, new DateTime(2023, 8, 2, 1, 10, 34, 964, DateTimeKind.Utc).AddTicks(7679), new DateTime(2023, 8, 7, 10, 12, 19, 62, DateTimeKind.Utc).AddTicks(2369) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 168L, new DateTime(2023, 2, 23, 23, 30, 43, 431, DateTimeKind.Utc).AddTicks(8813), new DateTime(2023, 8, 31, 23, 37, 46, 773, DateTimeKind.Utc).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 85L, new DateTime(2023, 7, 20, 22, 48, 11, 700, DateTimeKind.Utc).AddTicks(1039), new DateTime(2023, 9, 2, 15, 56, 31, 512, DateTimeKind.Utc).AddTicks(1214) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 152L, new DateTime(2023, 6, 23, 17, 26, 14, 926, DateTimeKind.Utc).AddTicks(1277), new DateTime(2023, 7, 12, 16, 33, 1, 259, DateTimeKind.Utc).AddTicks(7486) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 160L, new DateTime(2023, 2, 4, 11, 6, 56, 22, DateTimeKind.Utc).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 160L, new DateTime(2023, 1, 25, 19, 11, 59, 478, DateTimeKind.Utc).AddTicks(9808), new DateTime(2023, 6, 22, 15, 41, 19, 543, DateTimeKind.Utc).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 131L, new DateTime(2023, 9, 8, 22, 53, 23, 901, DateTimeKind.Utc).AddTicks(9653), new DateTime(2023, 9, 12, 7, 43, 12, 240, DateTimeKind.Utc).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 97L, new DateTime(2023, 7, 29, 6, 36, 34, 998, DateTimeKind.Utc).AddTicks(960), new DateTime(2023, 8, 11, 11, 32, 9, 530, DateTimeKind.Utc).AddTicks(91) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 197L, new DateTime(2022, 11, 20, 17, 16, 46, 218, DateTimeKind.Utc).AddTicks(4278), new DateTime(2023, 8, 18, 2, 53, 8, 626, DateTimeKind.Utc).AddTicks(2391) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 135L, new DateTime(2023, 6, 20, 5, 40, 53, 248, DateTimeKind.Utc).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 175L, new DateTime(2022, 8, 23, 3, 24, 39, 513, DateTimeKind.Utc).AddTicks(1336), new DateTime(2023, 5, 13, 3, 8, 57, 289, DateTimeKind.Utc).AddTicks(609) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 194L, new DateTime(2022, 11, 11, 14, 10, 22, 624, DateTimeKind.Utc).AddTicks(3998), new DateTime(2023, 5, 10, 22, 5, 54, 512, DateTimeKind.Utc).AddTicks(845) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 82L, new DateTime(2023, 9, 7, 20, 52, 49, 896, DateTimeKind.Utc).AddTicks(9674), new DateTime(2023, 9, 10, 10, 49, 4, 191, DateTimeKind.Utc).AddTicks(4371) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 182L, new DateTime(2020, 7, 14, 22, 12, 21, 804, DateTimeKind.Utc).AddTicks(8897), new DateTime(2022, 5, 14, 10, 24, 51, 834, DateTimeKind.Utc).AddTicks(5205) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 103L, new DateTime(2023, 8, 10, 17, 47, 4, 463, DateTimeKind.Utc).AddTicks(5241), new DateTime(2023, 9, 7, 21, 55, 41, 123, DateTimeKind.Utc).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 162L, new DateTime(2023, 8, 3, 8, 28, 40, 767, DateTimeKind.Utc).AddTicks(5069), new DateTime(2023, 8, 24, 20, 22, 34, 895, DateTimeKind.Utc).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 107L, new DateTime(2023, 3, 23, 4, 21, 36, 432, DateTimeKind.Utc).AddTicks(4463), new DateTime(2023, 6, 13, 10, 2, 8, 781, DateTimeKind.Utc).AddTicks(6144) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 180L, new DateTime(2023, 9, 11, 0, 13, 15, 195, DateTimeKind.Utc).AddTicks(5531), new DateTime(2023, 9, 12, 1, 53, 55, 940, DateTimeKind.Utc).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "ChallengeVersionId", "CreatedAt" },
                values: new object[] { 134L, new DateTime(2023, 9, 9, 21, 6, 30, 837, DateTimeKind.Utc).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 156L, new DateTime(2023, 9, 3, 9, 30, 45, 462, DateTimeKind.Utc).AddTicks(1191), new DateTime(2023, 9, 6, 11, 6, 23, 332, DateTimeKind.Utc).AddTicks(1487) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 168L, new DateTime(2022, 10, 8, 10, 14, 47, 83, DateTimeKind.Utc).AddTicks(6614), new DateTime(2023, 1, 1, 13, 57, 7, 350, DateTimeKind.Utc).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 143L, new DateTime(2023, 4, 25, 13, 8, 57, 623, DateTimeKind.Utc).AddTicks(7584), new DateTime(2023, 4, 27, 19, 18, 40, 105, DateTimeKind.Utc).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 195L, new DateTime(2023, 2, 2, 17, 3, 39, 226, DateTimeKind.Utc).AddTicks(15), new DateTime(2023, 5, 21, 22, 5, 3, 594, DateTimeKind.Utc).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 199L, new DateTime(2021, 6, 12, 10, 11, 58, 232, DateTimeKind.Utc).AddTicks(9597), new DateTime(2022, 12, 4, 3, 25, 37, 297, DateTimeKind.Utc).AddTicks(8525) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 131L, new DateTime(2023, 9, 11, 19, 11, 52, 998, DateTimeKind.Utc).AddTicks(5004), new DateTime(2023, 9, 12, 1, 6, 4, 406, DateTimeKind.Utc).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 188L, new DateTime(2023, 5, 31, 9, 25, 34, 972, DateTimeKind.Utc).AddTicks(2761), new DateTime(2023, 8, 2, 6, 27, 46, 879, DateTimeKind.Utc).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 171L, new DateTime(2023, 8, 8, 12, 41, 59, 485, DateTimeKind.Utc).AddTicks(5396), new DateTime(2023, 9, 1, 23, 44, 18, 8, DateTimeKind.Utc).AddTicks(1006) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 197L, new DateTime(2023, 4, 7, 13, 19, 17, 83, DateTimeKind.Utc).AddTicks(8288), new DateTime(2023, 8, 25, 1, 56, 26, 318, DateTimeKind.Utc).AddTicks(7209) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 175L, new DateTime(2022, 6, 8, 23, 15, 17, 195, DateTimeKind.Utc).AddTicks(7729), new DateTime(2023, 5, 25, 15, 6, 53, 481, DateTimeKind.Utc).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 82L, new DateTime(2023, 9, 9, 2, 4, 1, 121, DateTimeKind.Utc).AddTicks(4223), new DateTime(2023, 9, 9, 10, 21, 7, 145, DateTimeKind.Utc).AddTicks(8338) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 199L, new DateTime(2022, 4, 4, 8, 0, 20, 614, DateTimeKind.Utc).AddTicks(2792), new DateTime(2022, 10, 24, 4, 36, 50, 680, DateTimeKind.Utc).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 119L, new DateTime(2021, 5, 18, 11, 4, 6, 84, DateTimeKind.Utc).AddTicks(3642), new DateTime(2023, 2, 9, 19, 44, 36, 101, DateTimeKind.Utc).AddTicks(6397) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 162L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 199L, new DateTime(2020, 11, 28, 0, 4, 36, 42, DateTimeKind.Utc).AddTicks(4052), new DateTime(2022, 10, 21, 9, 0, 57, 368, DateTimeKind.Utc).AddTicks(7392) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 163L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 168L, new DateTime(2023, 4, 28, 18, 27, 33, 272, DateTimeKind.Utc).AddTicks(2343), new DateTime(2023, 7, 9, 4, 17, 23, 504, DateTimeKind.Utc).AddTicks(6812) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 164L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 156L, new DateTime(2023, 9, 8, 15, 0, 28, 828, DateTimeKind.Utc).AddTicks(1552), new DateTime(2023, 9, 11, 9, 2, 31, 131, DateTimeKind.Utc).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 165L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 199L, new DateTime(2020, 4, 23, 17, 1, 5, 439, DateTimeKind.Utc).AddTicks(9823), new DateTime(2020, 11, 18, 13, 17, 5, 499, DateTimeKind.Utc).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 191L, new DateTime(2023, 9, 2, 11, 10, 32, 188, DateTimeKind.Utc).AddTicks(9380), new DateTime(2023, 9, 9, 19, 42, 19, 451, DateTimeKind.Utc).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 112L, new DateTime(2023, 7, 10, 20, 14, 59, 756, DateTimeKind.Utc).AddTicks(7339), new DateTime(2023, 9, 9, 15, 41, 20, 703, DateTimeKind.Utc).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 160L, new DateTime(2023, 7, 11, 22, 10, 1, 43, DateTimeKind.Utc).AddTicks(1542), new DateTime(2023, 8, 10, 14, 9, 2, 352, DateTimeKind.Utc).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 134L, new DateTime(2023, 9, 9, 20, 25, 53, 584, DateTimeKind.Utc).AddTicks(9573), new DateTime(2023, 9, 11, 6, 54, 9, 345, DateTimeKind.Utc).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 197L, new DateTime(2023, 1, 7, 20, 19, 28, 527, DateTimeKind.Utc).AddTicks(7208), new DateTime(2023, 6, 14, 1, 43, 55, 604, DateTimeKind.Utc).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 200L, new DateTime(2023, 8, 26, 11, 19, 6, 900, DateTimeKind.Utc).AddTicks(3777), new DateTime(2023, 8, 31, 23, 11, 19, 866, DateTimeKind.Utc).AddTicks(1741) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 119L, new DateTime(2022, 11, 22, 11, 19, 16, 899, DateTimeKind.Utc).AddTicks(573), new DateTime(2022, 12, 26, 1, 31, 56, 110, DateTimeKind.Utc).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 119L, new DateTime(2020, 11, 9, 14, 45, 56, 621, DateTimeKind.Utc).AddTicks(1265), new DateTime(2021, 3, 5, 10, 17, 23, 958, DateTimeKind.Utc).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 88L, new DateTime(2023, 9, 3, 21, 53, 49, 139, DateTimeKind.Utc).AddTicks(8770), new DateTime(2023, 9, 11, 14, 53, 35, 529, DateTimeKind.Utc).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 188L, new DateTime(2023, 4, 13, 19, 53, 57, 664, DateTimeKind.Utc).AddTicks(1124), new DateTime(2023, 7, 8, 1, 36, 56, 754, DateTimeKind.Utc).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 82L, new DateTime(2023, 9, 11, 7, 40, 49, 313, DateTimeKind.Utc).AddTicks(8470), new DateTime(2023, 9, 11, 17, 24, 4, 582, DateTimeKind.Utc).AddTicks(4479) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 152L, new DateTime(2023, 7, 9, 2, 19, 52, 583, DateTimeKind.Utc).AddTicks(4886), new DateTime(2023, 7, 26, 23, 7, 38, 170, DateTimeKind.Utc).AddTicks(6703) });

            migrationBuilder.UpdateData(
                table: "UserSolutions",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "ChallengeVersionId", "CreatedAt", "SubmittedAt" },
                values: new object[] { 183L, new DateTime(2023, 9, 3, 22, 47, 18, 595, DateTimeKind.Utc).AddTicks(3718), new DateTime(2023, 9, 9, 20, 56, 24, 998, DateTimeKind.Utc).AddTicks(5945) });
        }
    }
}
