using Microsoft.EntityFrameworkCore;
using MaterialWarehouseEntity;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace MaterialWarehouseOrm {
    public class LocationDbContext : DbContext
{
public LocationDbContext()
{
}
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(Global.ConnectionString).LogTo(Console.WriteLine, LogLevel.Information);
protected override void OnModelCreating(
ModelBuilder modelBuilder)
{
base.OnModelCreating(modelBuilder); 
}
public DbSet<MWarehouse> MWarehouses {get; set;}

} 

}