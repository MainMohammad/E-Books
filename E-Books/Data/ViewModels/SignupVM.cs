using System.ComponentModel.DataAnnotations;

namespace E_Books.Data.ViewModels
{
    public class SignupVM
    {
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required!")]
        public string FullName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is required!")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Repeat your Password.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match!")]
        public string ConfirmedPassword { get; set; }
    }
}
