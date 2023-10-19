using System.ComponentModel.DataAnnotations;

namespace E_Books.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Name is required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required!")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Bio is required!")]
        public string Biography { get; set; }

        [Required(ErrorMessage = "Profile is required!")]
        [Display(Name = "Profile")]
        public string ProfileURL { get; set; }
        
        //Relations
        public List<Author_Book>? Authors_Books { get; set; }
    }
}
