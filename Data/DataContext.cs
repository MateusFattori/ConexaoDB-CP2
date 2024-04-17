using cp2.Models;
using Microsoft.EntityFrameworkCore;

namespace cp2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }

        public DbSet<User> MVC_Users { get; set; }
    }
}
