using E_Books.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Books.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Implementing the deposite key
            modelBuilder.Entity<Author_Book>().HasKey(ab => new
            {
                ab.AuthorId,
                ab.BookId
            });
            //Implementing the join table
            modelBuilder.Entity<Author_Book>().HasOne(b => b.Book).WithMany(ab => ab.Authors_Books).HasForeignKey(b => b.BookId);
            modelBuilder.Entity<Author_Book>().HasOne(b => b.Author).WithMany(ab => ab.Authors_Books).HasForeignKey(b => b.AuthorId);

            //Implementing the deposite key
            modelBuilder.Entity<BookStore_Book>().HasKey(bb => new
            {
                bb.BookStoreId,
                bb.BookId
            });
            //Implementing the join table
            modelBuilder.Entity<BookStore_Book>().HasOne(b => b.Book).WithMany(bb => bb.BookStores_Books).HasForeignKey(b => b.BookId);
            modelBuilder.Entity<BookStore_Book>().HasOne(b => b.BookStore).WithMany(bb => bb.BookStores_Books).HasForeignKey(b => b.BookStoreId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<BookStore> BookStores { get; set; }
        public DbSet<Author_Book> Authors_Books { get; set; }
        public DbSet<BookStore_Book> BookStores_Books { get; set; }

        //Order related stuff
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
