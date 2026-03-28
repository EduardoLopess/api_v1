using api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data; // Use file-scoped namespace para limpar o código

public class DataContext : DbContext
{

    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Table> Tables { get; set; }
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<Additional> Additionals { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<Addons> Addons { get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql();
    }
}