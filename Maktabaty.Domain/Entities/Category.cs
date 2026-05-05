namespace Maktabaty.Domain.Entities.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        // Many-to-many relationship with Book
        public ICollection<BookCategory> BookCategories { get; set; } = new List<BookCategory>();
    }
}

