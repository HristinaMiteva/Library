using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Library.Data.Models
{
    public class UserBook
    {
       

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
