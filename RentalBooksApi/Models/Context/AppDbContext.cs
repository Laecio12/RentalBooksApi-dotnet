using Microsoft.EntityFrameworkCore;

namespace RentalBooksApi.Models.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {}
        
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}