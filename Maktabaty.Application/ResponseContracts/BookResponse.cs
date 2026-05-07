using Maktabaty.Domain.Entities.Models;

namespace Maktabaty.Application.ResponseContracts
{
    public class BookResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime PublishingDate { get; set; }
        public string ImageUrl { get; set; }
        public string Hall { get; set; }
        public bool IsAvailableForRental { get; set; }
        public string Description { get; set; }

        public IEnumerable<string> Categories { get; set; }
        public IEnumerable<BookCopiesResponse> Copies { get; set; }
    }
}

