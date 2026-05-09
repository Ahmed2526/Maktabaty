using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Maktabaty.Application.ResponseContracts
{
    public class CreateUserResponse
    {
        public string? Id { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [MinLength(3, ErrorMessage = "Username must be at least 3 characters long")]
        [Remote("CheckUniqueUserName", controller: "Users", AdditionalFields = "Id", ErrorMessage = "username is taken")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Remote("CheckUniqueEmail", controller: "Users", AdditionalFields = "Id", ErrorMessage = "email already registered")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression("^01[0,1,2,5][0-9]{8}$", ErrorMessage = "Invalid Egypt phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [RegularExpression("^(?=.{6,}$)(?=.*[A-Z])(?=.*[^A-Za-z0-9]).+$",
          ErrorMessage = "Password must be at least 6 chars, contain an uppercase letter and a special character.")]
        public string Password { get; set; }

        public List<string> Roles { get; set; }
        public IEnumerable<SelectListItem>? SelectRoles { get; set; }
    }
}
