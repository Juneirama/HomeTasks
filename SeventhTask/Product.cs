namespace SeventhTask;

public class Product
{
    public ProductType Type { get; set; }
    
    public DateTime? SoldDate { get; set; } // Дата продажи
    
    public int Price { get; set; } // Цена продукта
    
    public DateTime StorageDate { get; set; } 
}
