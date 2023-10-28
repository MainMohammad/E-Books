namespace E_Books.Models
{
    //This file is a join table for many to many relation between Author and Book in order to break it into 2 one to many relationships
    public class Author_Book
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
