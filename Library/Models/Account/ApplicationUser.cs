using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Library.Models.Account
{
    public class ApplicationUser:IdentityUser
    {
       
        [StringLength(20)]
        public string? FirstName { get; set; }
        [StringLength(20)]
        public string? LastName { get; set; }

        public int Age { get; set; }
    }
}
