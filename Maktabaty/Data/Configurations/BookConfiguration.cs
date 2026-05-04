using Maktabaty.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Maktabaty.Data.Configurations
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
        }
    }
}
