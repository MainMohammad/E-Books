using E_Books.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Books.Data.ViewModels
{
    public class NewBookVM
    {
        public int Id { get; set; }

        [Display(Name = "Book Title")]
        [Required(ErrorMessage = "Title is required!")]
        public string Title { get; set; }

        [Display(Name = "Book publish Date")]
        [Required(ErrorMessage = "Date is required!")]
        public DateTime PublishDate { get; set; }

        [Display(Name = "Price in $")]
        [Column(TypeName = "decimal(18,2)")]
        [Required(ErrorMessage = "Price is required!")]
        public decimal Price { get; set; }

        [Display(Name = "Book Summary")]
        [Required(ErrorMessage = " Summary is required!")]
        public string Summary { get; set; }

        [Required(ErrorMessage = "Cover is required!")]
        [Display(Name = "Book Cover")]
        public string BookCover { get; set; }

        [Required(ErrorMessage = "Genre is required!")]
        [Display(Name = "Select a Genre")]
        public BookGenre Genre { get; set; }

        [Required(ErrorMessage = "Book Authors are required!")]
        [Display(Name = "Select Authors")]
        public List<int> AuthorIds { get; set; }

        [Required(ErrorMessage = "Book Bookstores are required!")]
        [Display(Name = "Select Bookstores")]
        public List<int> BookStoreIds { get; set; }

        [Required(ErrorMessage = "publisher is required!")]
        [Display(Name = "Select a publisher")]
        public int PublisherId { get; set; }
    }
}
