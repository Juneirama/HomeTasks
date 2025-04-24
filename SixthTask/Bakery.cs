namespace SixthTask;

public class Bakery : Product
{
    public string IsGlutenFree { get; set; }

    public Bakery(string name, decimal price, DateTime expiationDate, string isglutenfree)
        : base(name, price, expiationDate)
    {
        IsGlutenFree = isglutenfree;
    }

    public override void Description()
    {
        base.Description();
        Console.WriteLine($"Безглютеновый: {IsGlutenFree}");
    }

    public bool IsFresh()
    {
        return !IsExpired() && (DateTime.Now - ExpiationDate).TotalDays > 1;
    }
}
