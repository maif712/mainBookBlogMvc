using mainBookBlogMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace mainBookBlogMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
