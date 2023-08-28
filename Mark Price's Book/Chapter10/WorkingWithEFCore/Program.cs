using Packt.Shared;
using static System.Console;

namespace WorkingWithEFCore;

public class Program
{
    public static void Main()
    {
        WriteLine($"Using {ProjectConstants.DatabaseProvider} database provider.");
        var db = new Northwind();
    }
}
