using Domain.Table;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<Table> Tables { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Table>(builder =>
        {
            builder.ToTable("Mesas");
            builder.HasKey(i => i.Id);

            builder.OwnsOne(l => l.LockStatus, vo =>
            {
                vo.Property(s => s.IdUser).HasColumnName("IdUsuario");
                vo.Property(s => s.TimeLock).HasColumnName("TempoBloqueio");
                vo.Property(s => s.StatusLock).HasColumnName("StatusBloqueio");
            });

            builder.Navigation(t => t.LockStatus).IsRequired();

        });




    }

}