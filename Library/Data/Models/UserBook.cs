using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Library.Data.Models
{
    public class UserBook
    {
        public bool IsFavorite { get; set; }

        [Required]
        public Guid BookId { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey(nameof(BookId))]
        public Book? Book { get; set; }

        [ForeignKey(nameof(UserId))]
        public User? User { get; set; }
    }
}
