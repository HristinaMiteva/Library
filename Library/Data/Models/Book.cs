using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Library.Data.Models
{
    public class Book
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        public int? Pages { get; set; }
        public string? ISBN { get; set; }
        
        public double Price { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public int PublishingYear { get; set; }

        [Required]
        [ForeignKey(nameof(Publisher))]
        public Guid? PublisherId { get; set; }
        public Publisher? Publisher { get; set; }
        public HashSet<UserBook> UserBooks { get; set; } = new HashSet<UserBook>();
        public HashSet<Favorite> Favorites { get; set; } = new HashSet<Favorite>();
    }
}
