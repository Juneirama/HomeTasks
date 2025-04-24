using System.Threading.Channels;

namespace SixthTask;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public DateTime ExpiationDate { get; set; }

    public Product(string name, decimal price, DateTime expiationDate)
    {
        Name = name;
        Price = price;
        ExpiationDate = expiationDate;
    }

    public virtual void Description()
    {
        Console.WriteLine($"Продукт: {Name}, Цена: {Price} руб., Срок годности: {ExpiationDate}");
    }

    public bool IsExpired()
    {
        return DateTime.Now > ExpiationDate;
    }
} 