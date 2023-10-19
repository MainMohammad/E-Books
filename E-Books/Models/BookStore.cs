using System.ComponentModel.DataAnnotations;

namespace E_Books.Models
{
    public class BookStore
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is required!")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Telephone is required!")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "Logo is required!")]
        [Display(Name = "Logo")]
        public string LogoURL { get; set; }

        //Relations
        public List<BookStore_Book>? BookStores_Books { get; set; }

    }
}
