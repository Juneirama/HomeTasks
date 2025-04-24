namespace SixthTask;

public class Dairy : Product
{
    public double FatContent{ get; set; }

    public Dairy(string name, decimal price, DateTime expiationDate,  double fatcontent)
        : base(name, price, expiationDate)
    {
        FatContent = fatcontent;
    }

    public override void Description()
    {
        base.Description();
        Console.WriteLine($"Процент жирности: {FatContent}");
    }

    public bool IsLowFat()
    {
        return FatContent < 2.5;
    }
}
