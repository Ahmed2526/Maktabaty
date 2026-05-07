using Maktabaty.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maktabaty.Domain.Entities
{
    public class BookCopy
    {
        public int Id { get; set; }
        public string EditionNumber { get; set; }
        public int SerialNumber { get; set; }
        public bool IsAvailableForRental { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }


        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
