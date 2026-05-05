using Maktabaty.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Maktabaty.Infrastructure.Data.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(a => a.IsDeleted)
                .HasDefaultValue(false);

            builder.Property(a => a.CreatedOn)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property(a => a.UpdatedOn)
                .IsRequired(false);

            // Seed data
            builder.HasData(
                new Author { Id = 1, Name = "George R. R. Martin", IsDeleted = false, CreatedOn = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                new Author { Id = 2, Name = "J.K. Rowling", IsDeleted = false, CreatedOn = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                new Author { Id = 3, Name = "Stephen King", IsDeleted = false, CreatedOn = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                new Author { Id = 4, Name = "Isaac Asimov", IsDeleted = false, CreatedOn = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                new Author { Id = 5, Name = "Philip K. Dick", IsDeleted = false, CreatedOn = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                new Author { Id = 6, Name = "Agatha Christie", IsDeleted = false, CreatedOn = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                new Author { Id = 7, Name = "Jane Austen", IsDeleted = false, CreatedOn = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                new Author { Id = 8, Name = "Charles Dickens", IsDeleted = false, CreatedOn = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                new Author { Id = 9, Name = "Leo Tolstoy", IsDeleted = false, CreatedOn = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                new Author { Id = 10, Name = "Dan Brown", IsDeleted = false, CreatedOn = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc) }
            );
        }
    }
}

