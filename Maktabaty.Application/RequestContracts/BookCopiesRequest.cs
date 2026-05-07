using System;
using System.Collections.Generic;
using System.Text;

namespace Maktabaty.Application.RequestContracts
{
    public class BookCopiesRequest
    {
        public int BookId { get; set; }
        public string EditionNumber { get; set; }
        public bool IsAvailableForRental { get; set; }
    }
}
