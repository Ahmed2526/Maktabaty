using Maktabaty.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Maktabaty.Infrastructure.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(c => c.IsDeleted)
                .HasDefaultValue(false);

            builder.Property(c => c.CreatedOn)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property(c => c.UpdatedOn)
                .IsRequired(false);

            // Relationships
            builder.HasMany(c => c.BookCategories)
                .WithOne(bc => bc.Category)
                .HasForeignKey(bc => bc.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            // Seed data
            builder.HasData(
                new Category { Id = 1, Name = "Fiction", IsDeleted = false, CreatedOn = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                new Category { Id = 2, Name = "Science Fiction", IsDeleted = false, CreatedOn = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                new Category { Id = 3, Name = "Fantasy", IsDeleted = false, CreatedOn = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                new Category { Id = 4, Name = "Mystery", IsDeleted = false, CreatedOn = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                new Category { Id = 5, Name = "Romance", IsDeleted = false, CreatedOn = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                new Category { Id = 6, Name = "Thriller", IsDeleted = false, CreatedOn = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                new Category { Id = 7, Name = "Historical", IsDeleted = false, CreatedOn = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                new Category { Id = 8, Name = "Non-Fiction", IsDeleted = false, CreatedOn = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                new Category { Id = 9, Name = "Biography", IsDeleted = false, CreatedOn = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                new Category { Id = 10, Name = "Self-Help", IsDeleted = false, CreatedOn = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc) }
            );
        }
    }
}

