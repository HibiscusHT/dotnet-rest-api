using Microsoft.EntityFrameworkCore;
using VoucherEntity; 
using VoucherConfigEntity; 
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace VoucherOrm {
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
   modelBuilder.Entity<Voucher>()
        .HasOne(v => v.ketentuan) 
        .WithOne()
        .HasForeignKey<VoucherConfig>("id_config")
        .IsRequired();  
}
public DbSet<Voucher> Vouchers {get; set;} 

} 

}