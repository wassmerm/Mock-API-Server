using Microsoft.EntityFrameworkCore;
using Mock_API_Server.Models;

namespace Mock_API_Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Stock> Stocks { get; set; }
    }
}