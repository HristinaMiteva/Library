﻿using System.ComponentModel.DataAnnotations;

namespace Library.Models.PublisherViewModels
{
    public class PublishersViewModel
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string City { get; set; }

    }
}
