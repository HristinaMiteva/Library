using System.ComponentModel.DataAnnotations;

namespace Library.Models.BookViewModels
{
    public class BooksViewModel
    {
        public Guid? Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Title { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 10)]
        public string Author { get; set; }
        public int? Pages { get; set; }
        [Required]
        [StringLength(30)]
        public string ISBN { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public int PublishingYear { get; set; }
        public string PublisherName { get; set; }
    }
}
