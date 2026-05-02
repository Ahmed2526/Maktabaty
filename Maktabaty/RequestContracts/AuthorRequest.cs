using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Maktabaty.RequestContracts
{
    public class AuthorRequest
    {
        public int? Id { get; set; }

        [Required]
        [MaxLength(250)]
        [Remote(action: "CheckUnique", controller: "Authors", AdditionalFields = "Id", ErrorMessage = "This name is already taken.")]
        public string Name { get; set; }
    }
}
