using Maktabaty.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Maktabaty.Infrastructure.Data.Configurations
{
    public class BookCategoryConfiguration : IEntityTypeConfiguration<BookCategory>
    {
        public void Configure(EntityTypeBuilder<BookCategory> builder)
        {
            builder.HasKey(bc => new { bc.BookId, bc.CategoryId });

            builder.HasOne(bc => bc.Book)
                .WithMany(b => b.BookCategories)
                .HasForeignKey(bc => bc.BookId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(bc => bc.Category)
                .WithMany(c => c.BookCategories)
                .HasForeignKey(bc => bc.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new BookCategory { BookId = 1, CategoryId = 3 },
                new BookCategory { BookId = 1, CategoryId = 1 },
                new BookCategory { BookId = 2, CategoryId = 3 },
                new BookCategory { BookId = 2, CategoryId = 1 },
                new BookCategory { BookId = 3, CategoryId = 3 },
                new BookCategory { BookId = 3, CategoryId = 1 },
                new BookCategory { BookId = 4, CategoryId = 3 },
                new BookCategory { BookId = 4, CategoryId = 1 },
                new BookCategory { BookId = 5, CategoryId = 6 },
                new BookCategory { BookId = 5, CategoryId = 1 },
                new BookCategory { BookId = 6, CategoryId = 6 },
                new BookCategory { BookId = 6, CategoryId = 1 },
                new BookCategory { BookId = 7, CategoryId = 2 },
                new BookCategory { BookId = 7, CategoryId = 1 },
                new BookCategory { BookId = 8, CategoryId = 2 },
                new BookCategory { BookId = 8, CategoryId = 1 },
                new BookCategory { BookId = 9, CategoryId = 2 },
                new BookCategory { BookId = 9, CategoryId = 1 },
                new BookCategory { BookId = 10, CategoryId = 2 },
                new BookCategory { BookId = 10, CategoryId = 7 },
                new BookCategory { BookId = 11, CategoryId = 4 },
                new BookCategory { BookId = 11, CategoryId = 6 },
                new BookCategory { BookId = 12, CategoryId = 4 },
                new BookCategory { BookId = 12, CategoryId = 6 },
                new BookCategory { BookId = 13, CategoryId = 5 },
                new BookCategory { BookId = 13, CategoryId = 1 },
                new BookCategory { BookId = 14, CategoryId = 5 },
                new BookCategory { BookId = 14, CategoryId = 1 },
                new BookCategory { BookId = 15, CategoryId = 7 },
                new BookCategory { BookId = 15, CategoryId = 1 },
                new BookCategory { BookId = 16, CategoryId = 7 },
                new BookCategory { BookId = 16, CategoryId = 1 },
                new BookCategory { BookId = 17, CategoryId = 7 },
                new BookCategory { BookId = 17, CategoryId = 1 },
                new BookCategory { BookId = 18, CategoryId = 7 },
                new BookCategory { BookId = 18, CategoryId = 1 },
                new BookCategory { BookId = 19, CategoryId = 6 },
                new BookCategory { BookId = 19, CategoryId = 4 },
                new BookCategory { BookId = 20, CategoryId = 6 },
                new BookCategory { BookId = 20, CategoryId = 4 }
            );
        }
    }
}

