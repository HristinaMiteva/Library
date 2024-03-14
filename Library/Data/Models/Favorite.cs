using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Data.Models
{
    public class Favorite
    {
        [ForeignKey(nameof(Book))]
        public Guid? BookId { get; set; }
        public Book? Book { get; set; }
        [ForeignKey(nameof(User))]
        public string? UserId { get; set; }
        public User? User { get; set; }
    }
}
