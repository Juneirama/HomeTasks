namespace SeventhTask;

public class Lavka
{
    public string Name { get; set; } // Наименование товара

    public int Warehouse { get; set; } // Остаток на складе
    
    public int? Revenue { get; set; } // Выручка от продажи

    public List<Product>  Products { get; set; } = new List<Product>();
}