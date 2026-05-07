using System;
using System.Collections.Generic;
using System.Text;

namespace Maktabaty.Application.ResponseContracts
{
    public class BookCopiesResponse
    {
        public int Id { get; set; }
        public string EditionNumber { get; set; }
        public int SerialNumber { get; set; }
        public bool IsAvailableForRental { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
