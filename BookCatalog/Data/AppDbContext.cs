using Microsoft.EntityFrameworkCore;
using BookCatalog.Models;
namespace BookCatalog.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Books> Books { get; set; }
    }
}