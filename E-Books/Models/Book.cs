using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Books.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required!")]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "Date is required!")]
        public DateTime PublishDate { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Required(ErrorMessage = "Price is required!")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = " Summary is required!")]
        public string Summary { get; set; }

        //Relations
        // Many to manies
        public List<Author_Book>? Authors_Books { get; set; }
        public List<BookStore_Book>? BookStores_Books { get; set; }

        //One to many of publisher and book from this side
        public int PublisherId { get; set; }
        [ForeignKey("PublisherId")]
        public Publisher Publisher { get; set; }
    }
}
