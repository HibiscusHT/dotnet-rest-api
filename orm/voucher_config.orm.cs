using Microsoft.EntityFrameworkCore; 
using VoucherConfigEntity;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace VoucherConfigOrm {
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

public DbSet<VoucherConfig> VoucherConfigs {get; set;}

} 

}