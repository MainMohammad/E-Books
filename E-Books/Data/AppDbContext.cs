﻿using Microsoft.EntityFrameworkCore;

namespace E_Books.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }
    }
}
