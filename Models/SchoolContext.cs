using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace lab12cuba2.Models
{
    public class SchoolContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\CubitaChan; Database=apisem12; Integrated Security=True;Trust Server Certificate=True ");
        }
    }
}
