using System.ComponentModel.DataAnnotations;

namespace Maktabaty.Models
{
    public class Author
    {
        public int Id { get; set; }

        [MaxLength(250)]
        public string Name { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
