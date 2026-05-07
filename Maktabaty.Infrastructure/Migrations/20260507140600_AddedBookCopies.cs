using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maktabaty.Migrations
{
    /// <inheritdoc />
    public partial class AddedBookCopies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence<int>(
                name: "SerialNumber",
                startValue: 661120L,
                incrementBy: 5);

            migrationBuilder.CreateTable(
                name: "BookCopies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EditionNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SerialNumber = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR SerialNumber"),
                    IsAvailableForRental = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCopies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookCopies_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 1, 1, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-001-1", 661120, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 2, 1, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-001-2", true, 661125, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 3, 2, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-002-1", 661130, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 4, 2, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-002-2", true, 661135, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 5, 3, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-003-1", 661140, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 6, 3, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-003-2", true, 661145, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 7, 4, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-004-1", 661150, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 8, 4, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-004-2", true, 661155, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 9, 5, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-005-1", 661160, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 10, 5, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-005-2", true, 661165, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 11, 6, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-006-1", 661170, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 12, 6, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-006-2", true, 661175, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 13, 7, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-007-1", 661180, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 14, 7, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-007-2", true, 661185, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 15, 8, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-008-1", 661190, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 16, 8, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-008-2", true, 661195, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 17, 9, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-009-1", 661200, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 18, 9, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-009-2", true, 661205, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 19, 10, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-010-1", 661210, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 20, 10, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-010-2", true, 661215, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 21, 11, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-011-1", 661220, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 22, 11, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-011-2", true, 661225, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 23, 12, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-012-1", 661230, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 24, 12, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-012-2", true, 661235, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 25, 13, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-013-1", 661240, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 26, 13, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-013-2", true, 661245, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 27, 14, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-014-1", 661250, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 28, 14, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-014-2", true, 661255, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 29, 15, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-015-1", 661260, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 30, 15, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-015-2", true, 661265, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 31, 16, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-016-1", 661270, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 32, 16, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-016-2", true, 661275, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 33, 17, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-017-1", 661280, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 34, 17, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-017-2", true, 661285, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 35, 18, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-018-1", 661290, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 36, 18, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-018-2", true, 661295, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 37, 19, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-019-1", 661300, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 38, 19, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-019-2", true, 661305, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 39, 20, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-020-1", 661310, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 40, 20, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-020-2", true, 661315, null });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Hall", "ImageUrl", "IsAvailableForRental", "IsDeleted", "Publisher", "PublishingDate", "Title", "UpdatedOn" },
                values: new object[,]
                {
                    { 21, 1, "Sample description for book 21.", "S3", "https://covers.openlibrary.org/b/isbn/9780000000021-L.jpg", true, false, "Sample Publisher 1", new DateTime(2001, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 21", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 2, "Sample description for book 22.", "S4", "https://covers.openlibrary.org/b/isbn/9780000000022-L.jpg", true, false, "Sample Publisher 2", new DateTime(2002, 10, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 22", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 3, "Sample description for book 23.", "S5", "https://covers.openlibrary.org/b/isbn/9780000000023-L.jpg", true, false, "Sample Publisher 3", new DateTime(2003, 11, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 23", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 4, "Sample description for book 24.", "S6", "https://covers.openlibrary.org/b/isbn/9780000000024-L.jpg", true, false, "Sample Publisher 4", new DateTime(2004, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 24", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 5, "Sample description for book 25.", "S7", "https://covers.openlibrary.org/b/isbn/9780000000025-L.jpg", true, false, "Sample Publisher 5", new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 25", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 6, "Sample description for book 26.", "S8", "https://covers.openlibrary.org/b/isbn/9780000000026-L.jpg", true, false, "Sample Publisher 1", new DateTime(2006, 2, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 26", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 7, "Sample description for book 27.", "S9", "https://covers.openlibrary.org/b/isbn/9780000000027-L.jpg", true, false, "Sample Publisher 2", new DateTime(2007, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 27", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 8, "Sample description for book 28.", "S1", "https://covers.openlibrary.org/b/isbn/9780000000028-L.jpg", true, false, "Sample Publisher 3", new DateTime(2008, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 28", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 9, "Sample description for book 29.", "S2", "https://covers.openlibrary.org/b/isbn/9780000000029-L.jpg", true, false, "Sample Publisher 4", new DateTime(2009, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 29", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 10, "Sample description for book 30.", "S3", "https://covers.openlibrary.org/b/isbn/9780000000030-L.jpg", true, false, "Sample Publisher 5", new DateTime(2010, 6, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 30", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 1, "Sample description for book 31.", "S4", "https://covers.openlibrary.org/b/isbn/9780000000031-L.jpg", true, false, "Sample Publisher 1", new DateTime(2011, 7, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 31", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 2, "Sample description for book 32.", "S5", "https://covers.openlibrary.org/b/isbn/9780000000032-L.jpg", true, false, "Sample Publisher 2", new DateTime(2012, 8, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 32", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 3, "Sample description for book 33.", "S6", "https://covers.openlibrary.org/b/isbn/9780000000033-L.jpg", true, false, "Sample Publisher 3", new DateTime(2013, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 33", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 4, "Sample description for book 34.", "S7", "https://covers.openlibrary.org/b/isbn/9780000000034-L.jpg", true, false, "Sample Publisher 4", new DateTime(2014, 10, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 34", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 5, "Sample description for book 35.", "S8", "https://covers.openlibrary.org/b/isbn/9780000000035-L.jpg", true, false, "Sample Publisher 5", new DateTime(2015, 11, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 35", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, 6, "Sample description for book 36.", "S9", "https://covers.openlibrary.org/b/isbn/9780000000036-L.jpg", true, false, "Sample Publisher 1", new DateTime(2016, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 36", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, 7, "Sample description for book 37.", "S1", "https://covers.openlibrary.org/b/isbn/9780000000037-L.jpg", true, false, "Sample Publisher 2", new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 37", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, 8, "Sample description for book 38.", "S2", "https://covers.openlibrary.org/b/isbn/9780000000038-L.jpg", true, false, "Sample Publisher 3", new DateTime(2018, 2, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 38", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, 9, "Sample description for book 39.", "S3", "https://covers.openlibrary.org/b/isbn/9780000000039-L.jpg", true, false, "Sample Publisher 4", new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 39", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, 10, "Sample description for book 40.", "S4", "https://covers.openlibrary.org/b/isbn/9780000000040-L.jpg", true, false, "Sample Publisher 5", new DateTime(2000, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 40", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, 1, "Sample description for book 41.", "S5", "https://covers.openlibrary.org/b/isbn/9780000000041-L.jpg", true, false, "Sample Publisher 1", new DateTime(2001, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 41", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, 2, "Sample description for book 42.", "S6", "https://covers.openlibrary.org/b/isbn/9780000000042-L.jpg", true, false, "Sample Publisher 2", new DateTime(2002, 6, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 42", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, 3, "Sample description for book 43.", "S7", "https://covers.openlibrary.org/b/isbn/9780000000043-L.jpg", true, false, "Sample Publisher 3", new DateTime(2003, 7, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 43", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, 4, "Sample description for book 44.", "S8", "https://covers.openlibrary.org/b/isbn/9780000000044-L.jpg", true, false, "Sample Publisher 4", new DateTime(2004, 8, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 44", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, 5, "Sample description for book 45.", "S9", "https://covers.openlibrary.org/b/isbn/9780000000045-L.jpg", true, false, "Sample Publisher 5", new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 45", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, 6, "Sample description for book 46.", "S1", "https://covers.openlibrary.org/b/isbn/9780000000046-L.jpg", true, false, "Sample Publisher 1", new DateTime(2006, 10, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 46", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, 7, "Sample description for book 47.", "S2", "https://covers.openlibrary.org/b/isbn/9780000000047-L.jpg", true, false, "Sample Publisher 2", new DateTime(2007, 11, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 47", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, 8, "Sample description for book 48.", "S3", "https://covers.openlibrary.org/b/isbn/9780000000048-L.jpg", true, false, "Sample Publisher 3", new DateTime(2008, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 48", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, 9, "Sample description for book 49.", "S4", "https://covers.openlibrary.org/b/isbn/9780000000049-L.jpg", true, false, "Sample Publisher 4", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 49", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, 10, "Sample description for book 50.", "S5", "https://covers.openlibrary.org/b/isbn/9780000000050-L.jpg", true, false, "Sample Publisher 5", new DateTime(2010, 2, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 50", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, 1, "Sample description for book 51.", "S6", "https://covers.openlibrary.org/b/isbn/9780000000051-L.jpg", true, false, "Sample Publisher 1", new DateTime(2011, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 51", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, 2, "Sample description for book 52.", "S7", "https://covers.openlibrary.org/b/isbn/9780000000052-L.jpg", true, false, "Sample Publisher 2", new DateTime(2012, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 52", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, 3, "Sample description for book 53.", "S8", "https://covers.openlibrary.org/b/isbn/9780000000053-L.jpg", true, false, "Sample Publisher 3", new DateTime(2013, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 53", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, 4, "Sample description for book 54.", "S9", "https://covers.openlibrary.org/b/isbn/9780000000054-L.jpg", true, false, "Sample Publisher 4", new DateTime(2014, 6, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 54", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, 5, "Sample description for book 55.", "S1", "https://covers.openlibrary.org/b/isbn/9780000000055-L.jpg", true, false, "Sample Publisher 5", new DateTime(2015, 7, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 55", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, 6, "Sample description for book 56.", "S2", "https://covers.openlibrary.org/b/isbn/9780000000056-L.jpg", true, false, "Sample Publisher 1", new DateTime(2016, 8, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 56", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, 7, "Sample description for book 57.", "S3", "https://covers.openlibrary.org/b/isbn/9780000000057-L.jpg", true, false, "Sample Publisher 2", new DateTime(2017, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 57", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, 8, "Sample description for book 58.", "S4", "https://covers.openlibrary.org/b/isbn/9780000000058-L.jpg", true, false, "Sample Publisher 3", new DateTime(2018, 10, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 58", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, 9, "Sample description for book 59.", "S5", "https://covers.openlibrary.org/b/isbn/9780000000059-L.jpg", true, false, "Sample Publisher 4", new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 59", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, 10, "Sample description for book 60.", "S6", "https://covers.openlibrary.org/b/isbn/9780000000060-L.jpg", true, false, "Sample Publisher 5", new DateTime(2000, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 60", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61, 1, "Sample description for book 61.", "S7", "https://covers.openlibrary.org/b/isbn/9780000000061-L.jpg", true, false, "Sample Publisher 1", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 61", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, 2, "Sample description for book 62.", "S8", "https://covers.openlibrary.org/b/isbn/9780000000062-L.jpg", true, false, "Sample Publisher 2", new DateTime(2002, 2, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 62", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 63, 3, "Sample description for book 63.", "S9", "https://covers.openlibrary.org/b/isbn/9780000000063-L.jpg", true, false, "Sample Publisher 3", new DateTime(2003, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 63", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, 4, "Sample description for book 64.", "S1", "https://covers.openlibrary.org/b/isbn/9780000000064-L.jpg", true, false, "Sample Publisher 4", new DateTime(2004, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 64", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65, 5, "Sample description for book 65.", "S2", "https://covers.openlibrary.org/b/isbn/9780000000065-L.jpg", true, false, "Sample Publisher 5", new DateTime(2005, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 65", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 66, 6, "Sample description for book 66.", "S3", "https://covers.openlibrary.org/b/isbn/9780000000066-L.jpg", true, false, "Sample Publisher 1", new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 66", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 67, 7, "Sample description for book 67.", "S4", "https://covers.openlibrary.org/b/isbn/9780000000067-L.jpg", true, false, "Sample Publisher 2", new DateTime(2007, 7, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 67", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68, 8, "Sample description for book 68.", "S5", "https://covers.openlibrary.org/b/isbn/9780000000068-L.jpg", true, false, "Sample Publisher 3", new DateTime(2008, 8, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 68", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69, 9, "Sample description for book 69.", "S6", "https://covers.openlibrary.org/b/isbn/9780000000069-L.jpg", true, false, "Sample Publisher 4", new DateTime(2009, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 69", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70, 10, "Sample description for book 70.", "S7", "https://covers.openlibrary.org/b/isbn/9780000000070-L.jpg", true, false, "Sample Publisher 5", new DateTime(2010, 10, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 70", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 71, 1, "Sample description for book 71.", "S8", "https://covers.openlibrary.org/b/isbn/9780000000071-L.jpg", true, false, "Sample Publisher 1", new DateTime(2011, 11, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 71", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 72, 2, "Sample description for book 72.", "S9", "https://covers.openlibrary.org/b/isbn/9780000000072-L.jpg", true, false, "Sample Publisher 2", new DateTime(2012, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 72", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 73, 3, "Sample description for book 73.", "S1", "https://covers.openlibrary.org/b/isbn/9780000000073-L.jpg", true, false, "Sample Publisher 3", new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 73", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 74, 4, "Sample description for book 74.", "S2", "https://covers.openlibrary.org/b/isbn/9780000000074-L.jpg", true, false, "Sample Publisher 4", new DateTime(2014, 2, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 74", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 75, 5, "Sample description for book 75.", "S3", "https://covers.openlibrary.org/b/isbn/9780000000075-L.jpg", true, false, "Sample Publisher 5", new DateTime(2015, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 75", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 76, 6, "Sample description for book 76.", "S4", "https://covers.openlibrary.org/b/isbn/9780000000076-L.jpg", true, false, "Sample Publisher 1", new DateTime(2016, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 76", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 77, 7, "Sample description for book 77.", "S5", "https://covers.openlibrary.org/b/isbn/9780000000077-L.jpg", true, false, "Sample Publisher 2", new DateTime(2017, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 77", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 78, 8, "Sample description for book 78.", "S6", "https://covers.openlibrary.org/b/isbn/9780000000078-L.jpg", true, false, "Sample Publisher 3", new DateTime(2018, 6, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 78", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 79, 9, "Sample description for book 79.", "S7", "https://covers.openlibrary.org/b/isbn/9780000000079-L.jpg", true, false, "Sample Publisher 4", new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 79", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 80, 10, "Sample description for book 80.", "S8", "https://covers.openlibrary.org/b/isbn/9780000000080-L.jpg", true, false, "Sample Publisher 5", new DateTime(2000, 8, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 80", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 81, 1, "Sample description for book 81.", "S9", "https://covers.openlibrary.org/b/isbn/9780000000081-L.jpg", true, false, "Sample Publisher 1", new DateTime(2001, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 81", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 82, 2, "Sample description for book 82.", "S1", "https://covers.openlibrary.org/b/isbn/9780000000082-L.jpg", true, false, "Sample Publisher 2", new DateTime(2002, 10, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 82", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 83, 3, "Sample description for book 83.", "S2", "https://covers.openlibrary.org/b/isbn/9780000000083-L.jpg", true, false, "Sample Publisher 3", new DateTime(2003, 11, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 83", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 84, 4, "Sample description for book 84.", "S3", "https://covers.openlibrary.org/b/isbn/9780000000084-L.jpg", true, false, "Sample Publisher 4", new DateTime(2004, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 84", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 85, 5, "Sample description for book 85.", "S4", "https://covers.openlibrary.org/b/isbn/9780000000085-L.jpg", true, false, "Sample Publisher 5", new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 85", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 86, 6, "Sample description for book 86.", "S5", "https://covers.openlibrary.org/b/isbn/9780000000086-L.jpg", true, false, "Sample Publisher 1", new DateTime(2006, 2, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 86", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 87, 7, "Sample description for book 87.", "S6", "https://covers.openlibrary.org/b/isbn/9780000000087-L.jpg", true, false, "Sample Publisher 2", new DateTime(2007, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 87", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 88, 8, "Sample description for book 88.", "S7", "https://covers.openlibrary.org/b/isbn/9780000000088-L.jpg", true, false, "Sample Publisher 3", new DateTime(2008, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 88", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 89, 9, "Sample description for book 89.", "S8", "https://covers.openlibrary.org/b/isbn/9780000000089-L.jpg", true, false, "Sample Publisher 4", new DateTime(2009, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 89", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 90, 10, "Sample description for book 90.", "S9", "https://covers.openlibrary.org/b/isbn/9780000000090-L.jpg", true, false, "Sample Publisher 5", new DateTime(2010, 6, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 90", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 91, 1, "Sample description for book 91.", "S1", "https://covers.openlibrary.org/b/isbn/9780000000091-L.jpg", true, false, "Sample Publisher 1", new DateTime(2011, 7, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 91", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 92, 2, "Sample description for book 92.", "S2", "https://covers.openlibrary.org/b/isbn/9780000000092-L.jpg", true, false, "Sample Publisher 2", new DateTime(2012, 8, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 92", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 93, 3, "Sample description for book 93.", "S3", "https://covers.openlibrary.org/b/isbn/9780000000093-L.jpg", true, false, "Sample Publisher 3", new DateTime(2013, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 93", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 94, 4, "Sample description for book 94.", "S4", "https://covers.openlibrary.org/b/isbn/9780000000094-L.jpg", true, false, "Sample Publisher 4", new DateTime(2014, 10, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 94", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 95, 5, "Sample description for book 95.", "S5", "https://covers.openlibrary.org/b/isbn/9780000000095-L.jpg", true, false, "Sample Publisher 5", new DateTime(2015, 11, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 95", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 96, 6, "Sample description for book 96.", "S6", "https://covers.openlibrary.org/b/isbn/9780000000096-L.jpg", true, false, "Sample Publisher 1", new DateTime(2016, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 96", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 97, 7, "Sample description for book 97.", "S7", "https://covers.openlibrary.org/b/isbn/9780000000097-L.jpg", true, false, "Sample Publisher 2", new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 97", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 98, 8, "Sample description for book 98.", "S8", "https://covers.openlibrary.org/b/isbn/9780000000098-L.jpg", true, false, "Sample Publisher 3", new DateTime(2018, 2, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 98", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 99, 9, "Sample description for book 99.", "S9", "https://covers.openlibrary.org/b/isbn/9780000000099-L.jpg", true, false, "Sample Publisher 4", new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 99", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 100, 10, "Sample description for book 100.", "S1", "https://covers.openlibrary.org/b/isbn/9780000000100-L.jpg", true, false, "Sample Publisher 5", new DateTime(2000, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample Book 100", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "BookCategories",
                columns: new[] { "BookId", "CategoryId" },
                values: new object[,]
                {
                    { 21, 1 },
                    { 21, 2 },
                    { 22, 1 },
                    { 22, 2 },
                    { 23, 1 },
                    { 23, 3 },
                    { 24, 1 },
                    { 24, 4 },
                    { 25, 1 },
                    { 25, 5 },
                    { 26, 1 },
                    { 26, 6 },
                    { 27, 1 },
                    { 27, 7 },
                    { 28, 1 },
                    { 28, 8 },
                    { 29, 1 },
                    { 29, 9 },
                    { 30, 1 },
                    { 30, 10 },
                    { 31, 1 },
                    { 31, 2 },
                    { 32, 1 },
                    { 32, 2 },
                    { 33, 1 },
                    { 33, 3 },
                    { 34, 1 },
                    { 34, 4 },
                    { 35, 1 },
                    { 35, 5 },
                    { 36, 1 },
                    { 36, 6 },
                    { 37, 1 },
                    { 37, 7 },
                    { 38, 1 },
                    { 38, 8 },
                    { 39, 1 },
                    { 39, 9 },
                    { 40, 1 },
                    { 40, 10 },
                    { 41, 1 },
                    { 41, 2 },
                    { 42, 1 },
                    { 42, 2 },
                    { 43, 1 },
                    { 43, 3 },
                    { 44, 1 },
                    { 44, 4 },
                    { 45, 1 },
                    { 45, 5 },
                    { 46, 1 },
                    { 46, 6 },
                    { 47, 1 },
                    { 47, 7 },
                    { 48, 1 },
                    { 48, 8 },
                    { 49, 1 },
                    { 49, 9 },
                    { 50, 1 },
                    { 50, 10 },
                    { 51, 1 },
                    { 51, 2 },
                    { 52, 1 },
                    { 52, 2 },
                    { 53, 1 },
                    { 53, 3 },
                    { 54, 1 },
                    { 54, 4 },
                    { 55, 1 },
                    { 55, 5 },
                    { 56, 1 },
                    { 56, 6 },
                    { 57, 1 },
                    { 57, 7 },
                    { 58, 1 },
                    { 58, 8 },
                    { 59, 1 },
                    { 59, 9 },
                    { 60, 1 },
                    { 60, 10 },
                    { 61, 1 },
                    { 61, 2 },
                    { 62, 1 },
                    { 62, 2 },
                    { 63, 1 },
                    { 63, 3 },
                    { 64, 1 },
                    { 64, 4 },
                    { 65, 1 },
                    { 65, 5 },
                    { 66, 1 },
                    { 66, 6 },
                    { 67, 1 },
                    { 67, 7 },
                    { 68, 1 },
                    { 68, 8 },
                    { 69, 1 },
                    { 69, 9 },
                    { 70, 1 },
                    { 70, 10 },
                    { 71, 1 },
                    { 71, 2 },
                    { 72, 1 },
                    { 72, 2 },
                    { 73, 1 },
                    { 73, 3 },
                    { 74, 1 },
                    { 74, 4 },
                    { 75, 1 },
                    { 75, 5 },
                    { 76, 1 },
                    { 76, 6 },
                    { 77, 1 },
                    { 77, 7 },
                    { 78, 1 },
                    { 78, 8 },
                    { 79, 1 },
                    { 79, 9 },
                    { 80, 1 },
                    { 80, 10 },
                    { 81, 1 },
                    { 81, 2 },
                    { 82, 1 },
                    { 82, 2 },
                    { 83, 1 },
                    { 83, 3 },
                    { 84, 1 },
                    { 84, 4 },
                    { 85, 1 },
                    { 85, 5 },
                    { 86, 1 },
                    { 86, 6 },
                    { 87, 1 },
                    { 87, 7 },
                    { 88, 1 },
                    { 88, 8 },
                    { 89, 1 },
                    { 89, 9 },
                    { 90, 1 },
                    { 90, 10 },
                    { 91, 1 },
                    { 91, 2 },
                    { 92, 1 },
                    { 92, 2 },
                    { 93, 1 },
                    { 93, 3 },
                    { 94, 1 },
                    { 94, 4 },
                    { 95, 1 },
                    { 95, 5 },
                    { 96, 1 },
                    { 96, 6 },
                    { 97, 1 },
                    { 97, 7 },
                    { 98, 1 },
                    { 98, 8 },
                    { 99, 1 },
                    { 99, 9 },
                    { 100, 1 },
                    { 100, 10 }
                });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 41, 21, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-021-1", 661320, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 42, 21, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-021-2", true, 661325, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 43, 22, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-022-1", 661330, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 44, 22, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-022-2", true, 661335, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 45, 23, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-023-1", 661340, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 46, 23, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-023-2", true, 661345, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 47, 24, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-024-1", 661350, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 48, 24, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-024-2", true, 661355, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 49, 25, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-025-1", 661360, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 50, 25, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-025-2", true, 661365, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 51, 26, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-026-1", 661370, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 52, 26, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-026-2", true, 661375, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 53, 27, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-027-1", 661380, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 54, 27, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-027-2", true, 661385, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 55, 28, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-028-1", 661390, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 56, 28, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-028-2", true, 661395, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 57, 29, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-029-1", 661400, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 58, 29, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-029-2", true, 661405, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 59, 30, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-030-1", 661410, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 60, 30, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-030-2", true, 661415, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 61, 31, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-031-1", 661420, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 62, 31, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-031-2", true, 661425, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 63, 32, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-032-1", 661430, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 64, 32, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-032-2", true, 661435, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 65, 33, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-033-1", 661440, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 66, 33, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-033-2", true, 661445, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 67, 34, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-034-1", 661450, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 68, 34, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-034-2", true, 661455, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 69, 35, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-035-1", 661460, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 70, 35, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-035-2", true, 661465, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 71, 36, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-036-1", 661470, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 72, 36, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-036-2", true, 661475, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 73, 37, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-037-1", 661480, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 74, 37, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-037-2", true, 661485, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 75, 38, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-038-1", 661490, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 76, 38, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-038-2", true, 661495, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 77, 39, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-039-1", 661500, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 78, 39, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-039-2", true, 661505, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 79, 40, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-040-1", 661510, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 80, 40, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-040-2", true, 661515, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 81, 41, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-041-1", 661520, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 82, 41, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-041-2", true, 661525, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 83, 42, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-042-1", 661530, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 84, 42, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-042-2", true, 661535, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 85, 43, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-043-1", 661540, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 86, 43, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-043-2", true, 661545, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 87, 44, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-044-1", 661550, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 88, 44, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-044-2", true, 661555, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 89, 45, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-045-1", 661560, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 90, 45, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-045-2", true, 661565, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 91, 46, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-046-1", 661570, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 92, 46, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-046-2", true, 661575, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 93, 47, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-047-1", 661580, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 94, 47, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-047-2", true, 661585, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 95, 48, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-048-1", 661590, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 96, 48, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-048-2", true, 661595, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 97, 49, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-049-1", 661600, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 98, 49, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-049-2", true, 661605, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 99, 50, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-050-1", 661610, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 100, 50, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-050-2", true, 661615, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 101, 51, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-051-1", 661620, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 102, 51, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-051-2", true, 661625, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 103, 52, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-052-1", 661630, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 104, 52, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-052-2", true, 661635, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 105, 53, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-053-1", 661640, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 106, 53, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-053-2", true, 661645, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 107, 54, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-054-1", 661650, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 108, 54, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-054-2", true, 661655, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 109, 55, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-055-1", 661660, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 110, 55, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-055-2", true, 661665, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 111, 56, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-056-1", 661670, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 112, 56, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-056-2", true, 661675, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 113, 57, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-057-1", 661680, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 114, 57, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-057-2", true, 661685, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 115, 58, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-058-1", 661690, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 116, 58, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-058-2", true, 661695, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 117, 59, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-059-1", 661700, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 118, 59, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-059-2", true, 661705, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 119, 60, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-060-1", 661710, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 120, 60, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-060-2", true, 661715, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 121, 61, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-061-1", 661720, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 122, 61, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-061-2", true, 661725, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 123, 62, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-062-1", 661730, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 124, 62, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-062-2", true, 661735, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 125, 63, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-063-1", 661740, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 126, 63, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-063-2", true, 661745, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 127, 64, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-064-1", 661750, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 128, 64, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-064-2", true, 661755, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 129, 65, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-065-1", 661760, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 130, 65, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-065-2", true, 661765, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 131, 66, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-066-1", 661770, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 132, 66, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-066-2", true, 661775, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 133, 67, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-067-1", 661780, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 134, 67, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-067-2", true, 661785, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 135, 68, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-068-1", 661790, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 136, 68, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-068-2", true, 661795, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 137, 69, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-069-1", 661800, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 138, 69, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-069-2", true, 661805, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 139, 70, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-070-1", 661810, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 140, 70, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-070-2", true, 661815, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 141, 71, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-071-1", 661820, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 142, 71, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-071-2", true, 661825, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 143, 72, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-072-1", 661830, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 144, 72, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-072-2", true, 661835, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 145, 73, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-073-1", 661840, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 146, 73, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-073-2", true, 661845, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 147, 74, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-074-1", 661850, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 148, 74, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-074-2", true, 661855, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 149, 75, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-075-1", 661860, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 150, 75, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-075-2", true, 661865, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 151, 76, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-076-1", 661870, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 152, 76, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-076-2", true, 661875, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 153, 77, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-077-1", 661880, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 154, 77, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-077-2", true, 661885, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 155, 78, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-078-1", 661890, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 156, 78, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-078-2", true, 661895, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 157, 79, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-079-1", 661900, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 158, 79, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-079-2", true, 661905, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 159, 80, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-080-1", 661910, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 160, 80, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-080-2", true, 661915, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 161, 81, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-081-1", 661920, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 162, 81, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-081-2", true, 661925, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 163, 82, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-082-1", 661930, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 164, 82, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-082-2", true, 661935, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 165, 83, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-083-1", 661940, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 166, 83, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-083-2", true, 661945, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 167, 84, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-084-1", 661950, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 168, 84, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-084-2", true, 661955, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 169, 85, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-085-1", 661960, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 170, 85, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-085-2", true, 661965, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 171, 86, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-086-1", 661970, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 172, 86, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-086-2", true, 661975, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 173, 87, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-087-1", 661980, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 174, 87, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-087-2", true, 661985, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 175, 88, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-088-1", 661990, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 176, 88, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-088-2", true, 661995, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 177, 89, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-089-1", 662000, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 178, 89, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-089-2", true, 662005, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 179, 90, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-090-1", 662010, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 180, 90, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-090-2", true, 662015, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 181, 91, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-091-1", 662020, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 182, 91, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-091-2", true, 662025, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 183, 92, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-092-1", 662030, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 184, 92, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-092-2", true, 662035, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 185, 93, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-093-1", 662040, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 186, 93, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-093-2", true, 662045, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 187, 94, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-094-1", 662050, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 188, 94, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-094-2", true, 662055, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 189, 95, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-095-1", 662060, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 190, 95, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-095-2", true, 662065, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 191, 96, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-096-1", 662070, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 192, 96, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-096-2", true, 662075, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 193, 97, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-097-1", 662080, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 194, 97, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-097-2", true, 662085, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 195, 98, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-098-1", 662090, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 196, 98, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-098-2", true, 662095, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 197, 99, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-099-1", 662100, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 198, 99, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-099-2", true, 662105, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "SerialNumber", "UpdatedOn" },
                values: new object[] { 199, 100, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-100-1", 662110, null });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedOn", "EditionNumber", "IsAvailableForRental", "SerialNumber", "UpdatedOn" },
                values: new object[] { 200, 100, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ED-100-2", true, 662115, null });

            migrationBuilder.CreateIndex(
                name: "IX_BookCopies_BookId",
                table: "BookCopies",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookCopies");

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 21, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 22, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 23, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 24, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 25, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 26, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 26, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 27, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 27, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 28, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 28, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 29, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 29, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 30, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 30, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 31, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 31, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 32, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 32, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 33, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 33, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 34, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 34, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 35, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 35, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 36, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 36, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 37, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 37, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 38, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 38, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 39, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 39, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 40, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 40, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 41, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 41, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 42, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 42, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 43, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 43, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 44, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 44, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 45, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 45, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 46, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 46, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 47, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 47, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 48, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 48, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 49, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 49, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 50, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 50, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 51, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 51, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 52, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 52, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 53, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 53, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 54, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 54, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 55, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 55, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 56, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 56, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 57, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 57, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 58, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 58, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 59, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 59, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 60, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 60, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 61, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 61, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 62, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 62, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 63, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 63, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 64, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 64, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 65, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 65, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 66, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 66, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 67, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 67, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 68, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 68, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 69, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 69, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 70, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 70, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 71, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 71, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 72, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 72, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 73, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 73, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 74, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 74, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 75, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 75, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 76, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 76, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 77, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 77, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 78, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 78, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 79, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 79, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 80, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 80, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 81, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 81, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 82, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 82, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 83, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 83, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 84, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 84, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 85, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 85, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 86, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 86, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 87, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 87, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 88, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 88, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 89, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 89, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 90, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 90, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 91, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 91, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 92, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 92, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 93, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 93, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 94, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 94, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 95, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 95, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 96, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 96, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 97, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 97, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 98, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 98, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 99, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 99, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 100, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 100, 10 });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DropSequence(
                name: "SerialNumber");
        }
    }
}
