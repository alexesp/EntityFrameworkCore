using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EntityFrameworkCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeededTeams : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamId", "CreateDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 3, 23, 38, 5, 295, DateTimeKind.Unspecified).AddTicks(3313), "Real Madrid F.C" },
                    { 2, new DateTime(2025, 3, 3, 23, 38, 5, 295, DateTimeKind.Unspecified).AddTicks(3610), "Tivoli Gardens F.C" },
                    { 3, new DateTime(2025, 3, 3, 23, 38, 5, 295, DateTimeKind.Unspecified).AddTicks(3613), "Waterhouse F.C" },
                    { 4, new DateTime(2025, 3, 3, 23, 38, 5, 295, DateTimeKind.Unspecified).AddTicks(3614), "Humble Lions F.C" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 4);
        }
    }
}
