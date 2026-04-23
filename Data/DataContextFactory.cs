using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Data;

public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
{
    public DataContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<DataContext>();

        optionsBuilder.UseNpgsql(
            "Host=localhost;Port=5432;Database=pdv;Username=postgres;Password=LuxannaftJinx;"
        );

        return new DataContext(optionsBuilder.Options);
    }
}