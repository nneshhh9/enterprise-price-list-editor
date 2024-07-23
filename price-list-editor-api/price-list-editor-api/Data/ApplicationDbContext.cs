using Microsoft.EntityFrameworkCore;
using price_list_editor_api.Models;

namespace price_list_editor_api.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<PriceList> PriceLists { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Column> Columns { get; set; }
    public DbSet<ProductColumnValue> ProductColumnValues { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=my_host;Database=my_db;Username=my_user;Password=my_pw");
}