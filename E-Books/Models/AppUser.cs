using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace E_Books.Models
{
    public class AppUser: IdentityUser
    {
        [Required(ErrorMessage = "Name if Required!")]
        public string FullName { get; set; }
    }
}
