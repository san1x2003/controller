using Microsoft.EntityFrameworkCore;
using Shop.Models;
using System.Collections.Generic;
using System.Numerics;

namespace Shop.Models
{
    public class ShopContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }

        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}