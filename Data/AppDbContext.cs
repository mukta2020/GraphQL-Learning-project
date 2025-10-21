using GraphQLCRUDDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLCRUDDemo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Customer> Customers => Set<Customer>();
    }
}
