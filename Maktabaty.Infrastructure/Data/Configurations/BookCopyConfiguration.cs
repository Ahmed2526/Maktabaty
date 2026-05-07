using Maktabaty.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace Maktabaty.Infrastructure.Data.Configurations
{
    public class BookCopyConfiguration : IEntityTypeConfiguration<BookCopy>
    {
        public void Configure(EntityTypeBuilder<BookCopy> builder)
        {
            builder.HasKey(bc => bc.Id);

            builder.Property(bc => bc.SerialNumber)
                .IsRequired()
                .HasDefaultValueSql("NEXT VALUE FOR SerialNumber");

            builder.Property(bc => bc.IsAvailableForRental)
                .HasDefaultValue(false);

            builder.Property(bc => bc.IsDeleted)
                .HasDefaultValue(false);

            builder.Property(bc => bc.CreatedOn)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property(bc => bc.UpdatedOn)
                .IsRequired(false);

            builder.HasOne(bc => bc.Book)
                .WithMany(b => b.BookCopies)
                .HasForeignKey(bc => bc.BookId)
                .OnDelete(DeleteBehavior.Cascade);

            var bookCopies = new List<BookCopy>();
            var serialNumber = 661120;
            var copyId = 1;

            for (var bookId = 1; bookId <= 100; bookId++)
            {
                for (var copyIndex = 1; copyIndex <= 2; copyIndex++)
                {
                    bookCopies.Add(new BookCopy
                    {
                        Id = copyId++,
                        BookId = bookId,
                        EditionNumber = $"ED-{bookId:D3}-{copyIndex}",
                        SerialNumber = serialNumber,
                        IsAvailableForRental = copyIndex % 2 == 0,
                        CreatedOn = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                        UpdatedOn = null,
                        IsDeleted = false
                    });

                    serialNumber += 5;
                }
            }

            builder.HasData(bookCopies);
        }
    }
}
