﻿using System.ComponentModel.DataAnnotations;

namespace Library.Models.Account
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string UserName { get; set; } = null;
        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string FirstName { get; set; } = null;
        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string LastName { get; set; } = null;
        [Required]
        public int Age { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(60, MinimumLength = 10)]
        public string Email { get; set; } = null;
        [Required]
        [StringLength(20, MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null;

        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = null;
    }
}
