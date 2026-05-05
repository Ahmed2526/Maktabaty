namespace Maktabaty.Domain.Entities.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public string Publisher { get; set; }
        public DateTime PublishingDate { get; set; }
        public string? ImageUrl { get; set; }
        public string Hall { get; set; }
        public bool IsAvailableForRental { get; set; }
        public string Description { get; set; }

        // Many-to-many relationship with Category
        public ICollection<BookCategory> BookCategories { get; set; } = new List<BookCategory>();
    }
}

