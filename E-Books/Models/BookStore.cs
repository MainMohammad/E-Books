using System.ComponentModel.DataAnnotations;

namespace E_Books.Models
{
    public class BookStore
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }

    }
}
