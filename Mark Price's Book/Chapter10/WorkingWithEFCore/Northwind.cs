using Microsoft.EntityFrameworkCore;
using static System.Console;

namespace Packt.Shared;
public class Northwind : DbContext
{
    public Northwind()
    {
        OnConfiguring(new DbContextOptionsBuilder());
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connection = "DataSource=.;" +
            "Initial Catalog=Northwind;" +
            "Integrated Security=true;"; 
            //"MultipleActiveResultSets=true;";

        optionsBuilder.UseSqlServer(connection);

    }
}
