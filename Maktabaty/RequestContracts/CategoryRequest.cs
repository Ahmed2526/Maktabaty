using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Maktabaty.RequestContracts
{
    public class CategoryRequest
    {
        public int? Id { get; set; }

        [Required]
        [MaxLength(250)]
        [Remote(action: "CheckUnique", controller: "Categories", AdditionalFields = "Id", ErrorMessage = "This name is already taken.")]
        public string Name { get; set; }
    }
}
