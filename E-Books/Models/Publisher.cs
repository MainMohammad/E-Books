using System.ComponentModel.DataAnnotations;

namespace E_Books.Models
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Address is required!")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Logo is required!")]
        [Display(Name = "Logo")]
        public string LogoURL { get; set; }

        //Relations
        //This below is the implementation of a one to many relationship (Each publisher can have many books)
        public List<Book>? Books { get; set; }
    }
}
