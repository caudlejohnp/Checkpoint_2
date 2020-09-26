using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace capstone.Data.Migrations
{
    public partial class JusticeLeagueData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "JusticeLeagueMembers",
                columns: new[] { "Id", "Age", "Alias", "IsActiveMember", "MemberSince", "Name", "UserId" },
                values: new object[] { 1, 45, "Clark Kent", true, new DateTime(1950, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Superman", "56bdddab-0486-48db-9aa8-9e95dd50d60b" });

            migrationBuilder.InsertData(
                table: "JusticeLeagueMembers",
                columns: new[] { "Id", "Age", "Alias", "IsActiveMember", "MemberSince", "Name", "UserId" },
                values: new object[] { 2, 43, "Bruce Wayne", true, new DateTime(1950, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman", "56bdddab-0486-48db-9aa8-9e95dd50d60b" });

            migrationBuilder.InsertData(
                table: "JusticeLeagueMembers",
                columns: new[] { "Id", "Age", "Alias", "IsActiveMember", "MemberSince", "Name", "UserId" },
                values: new object[] { 3, 38, "Diana Prince", true, new DateTime(1950, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wonder Woman", "56bdddab-0486-48db-9aa8-9e95dd50d60b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JusticeLeagueMembers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JusticeLeagueMembers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JusticeLeagueMembers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
