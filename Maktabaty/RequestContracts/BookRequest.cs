using Maktabaty.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Maktabaty.RequestContracts
{
    public class BookRequest
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(500, ErrorMessage = "Title cannot exceed 500 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Author is required")]
        public int AuthorId { get; set; }
        public SelectList? Authors { get; set; }

        [Required(ErrorMessage = "Publisher is required")]
        [StringLength(250, ErrorMessage = "Publisher cannot exceed 250 characters")]
        public string Publisher { get; set; }

        [Required(ErrorMessage = "Publishing Date is required")]
        public DateTime PublishingDate { get; set; }

        [Display(Name = "Image")]
        public IFormFile? ImageUrl { get; set; }

        public string? ExistingImageUrl { get; set; }

        [Required(ErrorMessage = "Hall is required")]
        [StringLength(100, ErrorMessage = "Hall cannot exceed 100 characters")]
        public string Hall { get; set; }

        public bool IsAvailableForRental { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(2000, ErrorMessage = "Description cannot exceed 2000 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "At least one category must be selected")]
        public List<int> CategoryIds { get; set; }
        public SelectList? Categories { get; set; }
    }
}
