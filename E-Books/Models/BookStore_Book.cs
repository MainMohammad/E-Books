namespace E_Books.Models
{
    public class BookStore_Book
    {
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int BookStoreId { get; set; }
        public BookStore BookStore { get; set; }
    }
}
