using System.ComponentModel.DataAnnotations;

namespace E_Books.Data.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is required!")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        //The anotation bellow hides the input value in the ui of the app for password
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
