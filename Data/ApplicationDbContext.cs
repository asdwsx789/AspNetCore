using System;
using Microsoft.EntityFrameworkCore;
using Pizza.Model;

namespace Pizza.Data
{
    public partial class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrder> PizzzaOrders { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
