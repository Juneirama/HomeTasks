using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace SixthTask;

class Program
{
    static void Main(string[] args)
    {
        var mango = new Fruits("mango", 135.45m, new DateTime(2025, 05, 01), "a, c");
        var bread = new Bakery("bread", 30, new DateTime(2025, 05, 03), "безглютеновый");
        var yogurt = new Dairy("yogurt", 80.49m, new DateTime(2025, 04, 28), 1);
        
        mango.Description();
        Console.WriteLine($"Сладкий этот фрукт: {mango.IsSweet()}");
        
        bread.Description();
        Console.WriteLine($"Свежий этот хлеб: {bread.IsFresh()}");
        
        yogurt.Description();
        Console.WriteLine($"Жирный этот йогурт: {yogurt.IsLowFat()}");
    }
}
