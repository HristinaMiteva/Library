using System.ComponentModel.DataAnnotations;

namespace Library.Models.PublisherViewModels
{
    public class AddPublisherViewModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }

    }
}
