namespace SixthTask;

public class Fruits : Product
{
    public string Vitamins { get; set; }

    public Fruits(string name, decimal price, DateTime expiationDate, string vitamins)
        : base(name, price, expiationDate)
    {
        Vitamins = vitamins;
    }

    public override void Description()
    {
        base.Description();
        Console.WriteLine($"Витамины: {Vitamins}");
    }

    public bool IsSweet()
    {
        return Name.Contains("apple");
    }
}
