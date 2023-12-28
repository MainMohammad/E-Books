using E_Books.Data;
using E_Books.Models;
using E_Books.Data.Cart;
using E_Books.Data.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;



namespace E_Books.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection DbConnectionSetUp(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            return services;
        }

        public static IServiceCollection AddModelRelatedServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthorsServices, AuthorsService>();
            services.AddScoped<IBookStoresServices, BookStoresService>();
            services.AddScoped<IPublishersServices, PublishersService>();
            services.AddScoped<IBooksServices, BooksService>();
            services.AddScoped<IOrdersService, OrdersService>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sc => ShoppingCart.GetShoppingCart(sc));
            return services;
        }

        public static IServiceCollection AddIdentityRelatedServices(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>();
            services.AddMemoryCache();
            services.AddSession();
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            });
            return services;
        }
    }
}