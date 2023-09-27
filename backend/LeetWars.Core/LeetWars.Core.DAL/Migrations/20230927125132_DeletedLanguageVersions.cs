using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeetWars.Core.DAL.Migrations
{
    public partial class DeletedLanguageVersions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChallengeStars_Challenges_ChallengeId",
                table: "ChallengeStars");

            migrationBuilder.DropTable(
                name: "ChallengeVersionLanguageVersion");

            migrationBuilder.DropTable(
                name: "LanguageVersions");

            migrationBuilder.AddForeignKey(
                name: "FK_ChallengeStars_Challenges_ChallengeId",
                table: "ChallengeStars",
                column: "ChallengeId",
                principalTable: "Challenges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChallengeStars_Challenges_ChallengeId",
                table: "ChallengeStars");

            migrationBuilder.CreateTable(
                name: "LanguageVersions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageId = table.Column<long>(type: "bigint", nullable: false),
                    Version = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageVersion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LanguageVersion_Language_LanguageId",
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
                    LanguageVersionId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChallengesVersionLanguagesVersion", x => new { x.ChallengeVersionId, x.LanguageVersionId });
                    table.ForeignKey(
                        name: "FK_ChallengeVersionLanguageVersion_ChallengeVersions_ChallengeVersionId",
                        column: x => x.ChallengeVersionId,
                        principalTable: "ChallengeVersions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChallengeVersionLanguageVersion_LanguageVersion_LanguageVersionId",
                        column: x => x.LanguageVersionId,
                        principalTable: "LanguageVersions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChallengeVersionLanguageVersion_LanguageVersionId",
                table: "ChallengeVersionLanguageVersion",
                column: "LanguageVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageVersions_LanguageId",
                table: "LanguageVersions",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChallengeStars_Challenges_ChallengeId",
                table: "ChallengeStars",
                column: "ChallengeId",
                principalTable: "Challenges",
                principalColumn: "Id");
        }
    }
}
