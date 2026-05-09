using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maktabaty.Migrations
{
    /// <inheritdoc />
    public partial class seededRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "47E6F49D-3B9D-4B8F-9A7D-2F96D6E2C3B4", "a8d9c5aa-2c5e-4a8f-9c59-2d0d4f2b5e9f", "User", "USER" },
                    { "8D0D35E0-2C8B-4B7F-9F0B-0D13B930D701", "8c6e7308-2a0c-4bb2-9a5e-7a0c0e07ce7e", "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47E6F49D-3B9D-4B8F-9A7D-2F96D6E2C3B4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8D0D35E0-2C8B-4B7F-9F0B-0D13B930D701");
        }
    }
}
