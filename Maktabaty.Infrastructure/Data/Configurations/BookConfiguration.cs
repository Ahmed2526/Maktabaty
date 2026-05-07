using Maktabaty.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace Maktabaty.Infrastructure.Data.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(b => b.Publisher)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(b => b.PublishingDate)
                .IsRequired();

            builder.Property(b => b.ImageUrl)
                .HasMaxLength(500)
                .IsRequired(false);

            builder.Property(b => b.Hall)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(b => b.IsAvailableForRental)
                .HasDefaultValue(true);

            builder.Property(b => b.Description)
                .IsRequired()
                .HasMaxLength(2000);

            // Relationships
            builder.HasOne(b => b.Author)
                .WithMany()
                .HasForeignKey(b => b.AuthorId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(b => b.BookCategories)
                .WithOne(bc => bc.Book)
                .HasForeignKey(bc => bc.BookId)
                .OnDelete(DeleteBehavior.Cascade);

            var books = new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Title = "A Game of Thrones",
                    AuthorId = 1,
                    Publisher = "Bantam Spectra",
                    PublishingDate = new DateTime(1996, 8, 6, 0, 0, 0, DateTimeKind.Utc),
                    ImageUrl = "https://covers.openlibrary.org/b/isbn/9780553103540-L.jpg",
                    Hall = "A1",
                    IsAvailableForRental = true,
                    Description = "The first novel in A Song of Ice and Fire, introducing the struggle for the Iron Throne in Westeros."
                },
                new Book
                {
                    Id = 2,
                    Title = "A Clash of Kings",
                    AuthorId = 1,
                    Publisher = "Bantam Spectra",
                    PublishingDate = new DateTime(1998, 11, 16, 0, 0, 0, DateTimeKind.Utc),
                    ImageUrl = "https://covers.openlibrary.org/b/isbn/9780553108033-L.jpg",
                    Hall = "A1",
                    IsAvailableForRental = true,
                    Description = "The Seven Kingdoms fracture as rival kings clash, while the threat beyond the Wall grows."
                },
                new Book
                {
                    Id = 3,
                    Title = "Harry Potter and the Philosopher's Stone",
                    AuthorId = 2,
                    Publisher = "Bloomsbury",
                    PublishingDate = new DateTime(1997, 6, 26, 0, 0, 0, DateTimeKind.Utc),
                    ImageUrl = "https://covers.openlibrary.org/b/isbn/9780747532699-L.jpg",
                    Hall = "B2",
                    IsAvailableForRental = true,
                    Description = "Harry discovers he is a wizard and begins his first year at Hogwarts School of Witchcraft and Wizardry."
                },
                new Book
                {
                    Id = 4,
                    Title = "Harry Potter and the Chamber of Secrets",
                    AuthorId = 2,
                    Publisher = "Bloomsbury",
                    PublishingDate = new DateTime(1998, 7, 2, 0, 0, 0, DateTimeKind.Utc),
                    ImageUrl = "https://covers.openlibrary.org/b/isbn/9780747538493-L.jpg",
                    Hall = "B2",
                    IsAvailableForRental = true,
                    Description = "A mysterious force petrifies students at Hogwarts, and Harry uncovers a hidden chamber."
                },
                new Book
                {
                    Id = 5,
                    Title = "The Shining",
                    AuthorId = 3,
                    Publisher = "Doubleday",
                    PublishingDate = new DateTime(1977, 1, 28, 0, 0, 0, DateTimeKind.Utc),
                    ImageUrl = "https://covers.openlibrary.org/b/isbn/9780385121675-L.jpg",
                    Hall = "C3",
                    IsAvailableForRental = true,
                    Description = "A family becomes caretakers of an isolated hotel where supernatural forces drive the father toward madness."
                },
                new Book
                {
                    Id = 6,
                    Title = "It",
                    AuthorId = 3,
                    Publisher = "Viking",
                    PublishingDate = new DateTime(1986, 9, 15, 0, 0, 0, DateTimeKind.Utc),
                    ImageUrl = "https://covers.openlibrary.org/b/isbn/9780670813025-L.jpg",
                    Hall = "C3",
                    IsAvailableForRental = true,
                    Description = "In Derry, Maine, a group of friends confronts a shape-shifting evil that resurfaces every 27 years."
                },
                new Book
                {
                    Id = 7,
                    Title = "Foundation",
                    AuthorId = 4,
                    Publisher = "Gnome Press",
                    PublishingDate = new DateTime(1951, 6, 1, 0, 0, 0, DateTimeKind.Utc),
                    ImageUrl = "https://covers.openlibrary.org/b/isbn/9780553293357-L.jpg",
                    Hall = "D4",
                    IsAvailableForRental = true,
                    Description = "Hari Seldon creates the Foundation to preserve knowledge as the Galactic Empire falls."
                },
                new Book
                {
                    Id = 8,
                    Title = "I, Robot",
                    AuthorId = 4,
                    Publisher = "Gnome Press",
                    PublishingDate = new DateTime(1950, 12, 2, 0, 0, 0, DateTimeKind.Utc),
                    ImageUrl = "https://covers.openlibrary.org/b/isbn/9780553382563-L.jpg",
                    Hall = "D4",
                    IsAvailableForRental = true,
                    Description = "A collection of stories that introduced the Three Laws of Robotics."
                },
                new Book
                {
                    Id = 9,
                    Title = "Do Androids Dream of Electric Sheep?",
                    AuthorId = 5,
                    Publisher = "Doubleday",
                    PublishingDate = new DateTime(1968, 3, 1, 0, 0, 0, DateTimeKind.Utc),
                    ImageUrl = "https://covers.openlibrary.org/b/isbn/9780345404473-L.jpg",
                    Hall = "D4",
                    IsAvailableForRental = true,
                    Description = "In a post-apocalyptic future, bounty hunter Rick Deckard tracks rogue androids."
                },
                new Book
                {
                    Id = 10,
                    Title = "The Man in the High Castle",
                    AuthorId = 5,
                    Publisher = "Putnam",
                    PublishingDate = new DateTime(1962, 10, 1, 0, 0, 0, DateTimeKind.Utc),
                    ImageUrl = "https://covers.openlibrary.org/b/isbn/9780547572482-L.jpg",
                    Hall = "D4",
                    IsAvailableForRental = true,
                    Description = "An alternate history where the Axis powers won World War II and divided the United States."
                },
                new Book
                {
                    Id = 11,
                    Title = "Murder on the Orient Express",
                    AuthorId = 6,
                    Publisher = "Collins Crime Club",
                    PublishingDate = new DateTime(1934, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    ImageUrl = "https://covers.openlibrary.org/b/isbn/9780062693662-L.jpg",
                    Hall = "E5",
                    IsAvailableForRental = true,
                    Description = "Detective Hercule Poirot investigates a murder aboard the famous train."
                },
                new Book
                {
                    Id = 12,
                    Title = "And Then There Were None",
                    AuthorId = 6,
                    Publisher = "Collins Crime Club",
                    PublishingDate = new DateTime(1939, 11, 6, 0, 0, 0, DateTimeKind.Utc),
                    ImageUrl = "https://covers.openlibrary.org/b/isbn/9780062073488-L.jpg",
                    Hall = "E5",
                    IsAvailableForRental = true,
                    Description = "Ten strangers on an isolated island are accused of crimes and eliminated one by one."
                },
                new Book
                {
                    Id = 13,
                    Title = "Pride and Prejudice",
                    AuthorId = 7,
                    Publisher = "T. Egerton",
                    PublishingDate = new DateTime(1813, 1, 28, 0, 0, 0, DateTimeKind.Utc),
                    ImageUrl = "https://covers.openlibrary.org/b/isbn/9780141439518-L.jpg",
                    Hall = "F6",
                    IsAvailableForRental = true,
                    Description = "Elizabeth Bennet navigates manners, upbringing, and marriage in Regency England."
                },
                new Book
                {
                    Id = 14,
                    Title = "Sense and Sensibility",
                    AuthorId = 7,
                    Publisher = "Thomas Egerton",
                    PublishingDate = new DateTime(1811, 10, 30, 0, 0, 0, DateTimeKind.Utc),
                    ImageUrl = "https://covers.openlibrary.org/b/isbn/9780141439662-L.jpg",
                    Hall = "F6",
                    IsAvailableForRental = true,
                    Description = "The Dashwood sisters cope with love, loss, and society after a change in fortune."
                },
                new Book
                {
                    Id = 15,
                    Title = "Great Expectations",
                    AuthorId = 8,
                    Publisher = "Chapman & Hall",
                    PublishingDate = new DateTime(1861, 8, 1, 0, 0, 0, DateTimeKind.Utc),
                    ImageUrl = "https://covers.openlibrary.org/b/isbn/9780141439563-L.jpg",
                    Hall = "G7",
                    IsAvailableForRental = true,
                    Description = "Pip's coming-of-age story unfolds with ambition, love, and the consequences of secrets."
                },
                new Book
                {
                    Id = 16,
                    Title = "A Tale of Two Cities",
                    AuthorId = 8,
                    Publisher = "Chapman & Hall",
                    PublishingDate = new DateTime(1859, 4, 30, 0, 0, 0, DateTimeKind.Utc),
                    ImageUrl = "https://covers.openlibrary.org/b/isbn/9780141439600-L.jpg",
                    Hall = "G7",
                    IsAvailableForRental = true,
                    Description = "A sweeping historical novel set in London and Paris during the French Revolution."
                },
                new Book
                {
                    Id = 17,
                    Title = "War and Peace",
                    AuthorId = 9,
                    Publisher = "The Russian Messenger",
                    PublishingDate = new DateTime(1869, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    ImageUrl = "https://covers.openlibrary.org/b/isbn/9780140447934-L.jpg",
                    Hall = "H8",
                    IsAvailableForRental = true,
                    Description = "An epic portrayal of Russian society during the Napoleonic Wars."
                },
                new Book
                {
                    Id = 18,
                    Title = "Anna Karenina",
                    AuthorId = 9,
                    Publisher = "The Russian Messenger",
                    PublishingDate = new DateTime(1878, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    ImageUrl = "https://covers.openlibrary.org/b/isbn/9780143035008-L.jpg",
                    Hall = "H8",
                    IsAvailableForRental = true,
                    Description = "A tragic story of love, society, and morality in imperial Russia."
                },
                new Book
                {
                    Id = 19,
                    Title = "The Da Vinci Code",
                    AuthorId = 10,
                    Publisher = "Doubleday",
                    PublishingDate = new DateTime(2003, 3, 18, 0, 0, 0, DateTimeKind.Utc),
                    ImageUrl = "https://covers.openlibrary.org/b/isbn/9780385504201-L.jpg",
                    Hall = "I9",
                    IsAvailableForRental = true,
                    Description = "Symbologist Robert Langdon unravels a mystery that spans art, history, and secret societies."
                },
                new Book
                {
                    Id = 20,
                    Title = "Angels & Demons",
                    AuthorId = 10,
                    Publisher = "Pocket Books",
                    PublishingDate = new DateTime(2000, 5, 1, 0, 0, 0, DateTimeKind.Utc),
                    ImageUrl = "https://covers.openlibrary.org/b/isbn/9780671027360-L.jpg",
                    Hall = "I9",
                    IsAvailableForRental = true,
                    Description = "Robert Langdon investigates a conspiracy involving the Illuminati and the Vatican."
                }
            };

            for (var i = 21; i <= 100; i++)
            {
                books.Add(new Book
                {
                    Id = i,
                    Title = $"Sample Book {i}",
                    AuthorId = (i - 1) % 10 + 1,
                    Publisher = $"Sample Publisher {(i - 1) % 5 + 1}",
                    PublishingDate = new DateTime(2000 + (i % 20), (i - 1) % 12 + 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    ImageUrl = $"https://covers.openlibrary.org/b/isbn/9780000000{i:D3}-L.jpg",
                    Hall = $"S{(i - 1) % 9 + 1}",
                    IsAvailableForRental = true,
                    Description = $"Sample description for book {i}."
                });
            }

            builder.HasData(books);
        }
    }
}

