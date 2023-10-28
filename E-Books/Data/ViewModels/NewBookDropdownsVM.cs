using E_Books.Models;

namespace E_Books.Data.ViewModels
{
    public class NewBookDropdownsVM
    {
        public NewBookDropdownsVM()
        {
            Authors = new List<Author>();
            Publishers = new List<Publisher>();
            BookStores = new List<BookStore>();
        }
        public List<Author> Authors { get; set; }
        public List<Publisher> Publishers { get; set; }
        public List<BookStore> BookStores { get; set; }
    }
}
