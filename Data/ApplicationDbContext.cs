using Microsoft.EntityFrameworkCore;
using PizzaPlayground.Models;

namespace PizzaPlayground.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<PizzaOrder> PizzaOrders { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base()
    {
        
    }
}
