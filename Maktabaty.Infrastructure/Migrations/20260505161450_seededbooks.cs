using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maktabaty.Migrations
{
    /// <inheritdoc />
    public partial class seededbooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Hall", "ImageUrl", "IsAvailableForRental", "Publisher", "PublishingDate", "Title" },
                values: new object[,]
                {
                    { 1, 1, "The first novel in A Song of Ice and Fire, introducing the struggle for the Iron Throne in Westeros.", "A1", "https://covers.openlibrary.org/b/isbn/9780553103540-L.jpg", true, "Bantam Spectra", new DateTime(1996, 8, 6, 0, 0, 0, 0, DateTimeKind.Utc), "A Game of Thrones" },
                    { 2, 1, "The Seven Kingdoms fracture as rival kings clash, while the threat beyond the Wall grows.", "A1", "https://covers.openlibrary.org/b/isbn/9780553108033-L.jpg", true, "Bantam Spectra", new DateTime(1998, 11, 16, 0, 0, 0, 0, DateTimeKind.Utc), "A Clash of Kings" },
                    { 3, 2, "Harry discovers he is a wizard and begins his first year at Hogwarts School of Witchcraft and Wizardry.", "B2", "https://covers.openlibrary.org/b/isbn/9780747532699-L.jpg", true, "Bloomsbury", new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Harry Potter and the Philosopher's Stone" },
                    { 4, 2, "A mysterious force petrifies students at Hogwarts, and Harry uncovers a hidden chamber.", "B2", "https://covers.openlibrary.org/b/isbn/9780747538493-L.jpg", true, "Bloomsbury", new DateTime(1998, 7, 2, 0, 0, 0, 0, DateTimeKind.Utc), "Harry Potter and the Chamber of Secrets" },
                    { 5, 3, "A family becomes caretakers of an isolated hotel where supernatural forces drive the father toward madness.", "C3", "https://covers.openlibrary.org/b/isbn/9780385121675-L.jpg", true, "Doubleday", new DateTime(1977, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), "The Shining" },
                    { 6, 3, "In Derry, Maine, a group of friends confronts a shape-shifting evil that resurfaces every 27 years.", "C3", "https://covers.openlibrary.org/b/isbn/9780670813025-L.jpg", true, "Viking", new DateTime(1986, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), "It" },
                    { 7, 4, "Hari Seldon creates the Foundation to preserve knowledge as the Galactic Empire falls.", "D4", "https://covers.openlibrary.org/b/isbn/9780553293357-L.jpg", true, "Gnome Press", new DateTime(1951, 6, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Foundation" },
                    { 8, 4, "A collection of stories that introduced the Three Laws of Robotics.", "D4", "https://covers.openlibrary.org/b/isbn/9780553382563-L.jpg", true, "Gnome Press", new DateTime(1950, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), "I, Robot" },
                    { 9, 5, "In a post-apocalyptic future, bounty hunter Rick Deckard tracks rogue androids.", "D4", "https://covers.openlibrary.org/b/isbn/9780345404473-L.jpg", true, "Doubleday", new DateTime(1968, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Do Androids Dream of Electric Sheep?" },
                    { 10, 5, "An alternate history where the Axis powers won World War II and divided the United States.", "D4", "https://covers.openlibrary.org/b/isbn/9780547572482-L.jpg", true, "Putnam", new DateTime(1962, 10, 1, 0, 0, 0, 0, DateTimeKind.Utc), "The Man in the High Castle" },
                    { 11, 6, "Detective Hercule Poirot investigates a murder aboard the famous train.", "E5", "https://covers.openlibrary.org/b/isbn/9780062693662-L.jpg", true, "Collins Crime Club", new DateTime(1934, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Murder on the Orient Express" },
                    { 12, 6, "Ten strangers on an isolated island are accused of crimes and eliminated one by one.", "E5", "https://covers.openlibrary.org/b/isbn/9780062073488-L.jpg", true, "Collins Crime Club", new DateTime(1939, 11, 6, 0, 0, 0, 0, DateTimeKind.Utc), "And Then There Were None" },
                    { 13, 7, "Elizabeth Bennet navigates manners, upbringing, and marriage in Regency England.", "F6", "https://covers.openlibrary.org/b/isbn/9780141439518-L.jpg", true, "T. Egerton", new DateTime(1813, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Pride and Prejudice" },
                    { 14, 7, "The Dashwood sisters cope with love, loss, and society after a change in fortune.", "F6", "https://covers.openlibrary.org/b/isbn/9780141439662-L.jpg", true, "Thomas Egerton", new DateTime(1811, 10, 30, 0, 0, 0, 0, DateTimeKind.Utc), "Sense and Sensibility" },
                    { 15, 8, "Pip's coming-of-age story unfolds with ambition, love, and the consequences of secrets.", "G7", "https://covers.openlibrary.org/b/isbn/9780141439563-L.jpg", true, "Chapman & Hall", new DateTime(1861, 8, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Great Expectations" },
                    { 16, 8, "A sweeping historical novel set in London and Paris during the French Revolution.", "G7", "https://covers.openlibrary.org/b/isbn/9780141439600-L.jpg", true, "Chapman & Hall", new DateTime(1859, 4, 30, 0, 0, 0, 0, DateTimeKind.Utc), "A Tale of Two Cities" },
                    { 17, 9, "An epic portrayal of Russian society during the Napoleonic Wars.", "H8", "https://covers.openlibrary.org/b/isbn/9780140447934-L.jpg", true, "The Russian Messenger", new DateTime(1869, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "War and Peace" },
                    { 18, 9, "A tragic story of love, society, and morality in imperial Russia.", "H8", "https://covers.openlibrary.org/b/isbn/9780143035008-L.jpg", true, "The Russian Messenger", new DateTime(1878, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Anna Karenina" },
                    { 19, 10, "Symbologist Robert Langdon unravels a mystery that spans art, history, and secret societies.", "I9", "https://covers.openlibrary.org/b/isbn/9780385504201-L.jpg", true, "Doubleday", new DateTime(2003, 3, 18, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code" },
                    { 20, 10, "Robert Langdon investigates a conspiracy involving the Illuminati and the Vatican.", "I9", "https://covers.openlibrary.org/b/isbn/9780671027360-L.jpg", true, "Pocket Books", new DateTime(2000, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Angels & Demons" }
                });

            migrationBuilder.InsertData(
                table: "BookCategories",
                columns: new[] { "BookId", "CategoryId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 3 },
                    { 2, 1 },
                    { 2, 3 },
                    { 3, 1 },
                    { 3, 3 },
                    { 4, 1 },
                    { 4, 3 },
                    { 5, 1 },
                    { 5, 6 },
                    { 6, 1 },
                    { 6, 6 },
                    { 7, 1 },
                    { 7, 2 },
                    { 8, 1 },
                    { 8, 2 },
                    { 9, 1 },
                    { 9, 2 },
                    { 10, 2 },
                    { 10, 7 },
                    { 11, 4 },
                    { 11, 6 },
                    { 12, 4 },
                    { 12, 6 },
                    { 13, 1 },
                    { 13, 5 },
                    { 14, 1 },
                    { 14, 5 },
                    { 15, 1 },
                    { 15, 7 },
                    { 16, 1 },
                    { 16, 7 },
                    { 17, 1 },
                    { 17, 7 },
                    { 18, 1 },
                    { 18, 7 },
                    { 19, 4 },
                    { 19, 6 },
                    { 20, 4 },
                    { 20, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 13, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 15, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 16, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 17, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 18, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 19, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 19, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 20, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 20, 6 });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
