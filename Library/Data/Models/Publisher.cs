using System.ComponentModel.DataAnnotations;

namespace Library.Data.Models
{
    public class Publisher
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string City { get; set; }
        public HashSet<Book> Books { get; set; } = new HashSet<Book>();
    }
}
