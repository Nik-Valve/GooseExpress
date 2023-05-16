using GooseExpress2Api.Models;
using Microsoft.EntityFrameworkCore;

namespace GooseExpress2Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {
            
        }
        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<FeedBacks> FeedBacks { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Recipient> Recipient { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                
        }
    }
}
