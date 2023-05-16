using GooseExpressApi.Models;
using Microsoft.EntityFrameworkCore;

namespace GooseExpressApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { 
        
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
        }
    }
}
