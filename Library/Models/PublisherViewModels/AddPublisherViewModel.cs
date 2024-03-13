using System.ComponentModel.DataAnnotations;

namespace Library.Models.PublisherViewModels
{
    public class AddPublisherViewModel
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }
  
        public string City { get; set; }

    }
}
