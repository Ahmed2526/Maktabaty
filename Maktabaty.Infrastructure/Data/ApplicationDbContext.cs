using Maktabaty.Domain.Entities;
using Maktabaty.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Maktabaty.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<BookCopy> BookCopies { get; set; }
    public DbSet<BookCategory> BookCategories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Define a sequence for generating unique serial numbers for BookCopy entities
        modelBuilder.HasSequence<int>("SerialNumber")
            .StartsAt(661120)
            .IncrementsBy(5);

        // Apply all entity configurations
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}

