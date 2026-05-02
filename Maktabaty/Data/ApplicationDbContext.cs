using Maktabaty.Models;
using Microsoft.EntityFrameworkCore;

namespace Maktabaty.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Author> Authors { get; set; }
}
