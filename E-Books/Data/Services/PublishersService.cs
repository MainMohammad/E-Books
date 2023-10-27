using E_Books.Data.Base;
using E_Books.Models;

namespace E_Books.Data.Services
{
    public class PublishersService : EntityBaseRepository<Publisher>, IPublishersServices
    {
        public PublishersService(AppDbContext context) : base(context) { }
    }
}
