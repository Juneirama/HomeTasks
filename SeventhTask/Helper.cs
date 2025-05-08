using System.Data;
using System.Text;

namespace SeventhTask;

public static class Helper
{
    public static List<Lavka> FillLavkasFromFile(string filePath)
    {
        List<Lavka> marketList = new List<Lavka>();
        if (File.Exists((filePath)))
        {
            StreamReader streamReader = File.OpenText(filePath);
            streamReader.ReadLine();
            while (!streamReader.EndOfStream)
            {
                var data = streamReader.ReadLine().Split(',');

                Lavka lavka = new Lavka();
                lavka.Name = data[0];
                lavka.Warehouse =  Int32.Parse(data[1]);

                
                int appleCount = Int32.Parse(data[4]) + Int32.Parse(data[5]);
                for (int i = 0; i < appleCount; i++)
                {
                    Product apple = new Product();
                    apple.Price = Int32.Parse(data[2]);
                    apple.Type = ProductType.Apples;
                    apple.StorageDate = DateTime.Now;
                    if (i < Int32.Parse(data[5]))
                    {
                        apple.SoldDate = DateTime.Now;
                    }
                
                    lavka.Products.Add(apple); 
                }
                
                int orangeCount = Int32.Parse(data[6]) + Int32.Parse(data[7]);
                for (int i = 0; i < orangeCount; i++)
                {
                    Product orange = new Product();
                    orange.Price = Int32.Parse(data[2]);
                    orange.Type = ProductType.Oranges;
                    orange.StorageDate = DateTime.Now;
                    if (i < Int32.Parse(data[7]))
                    {
                        orange.SoldDate = DateTime.Now;
                    }

                    lavka.Products.Add(orange); 
                }
                
                marketList.Add(lavka);
            }
        }

        return marketList;
    }

    public static void WriteToFile(string filePath, List<Lavka> marketList)
    {
        var csvContent = new StringBuilder();
        csvContent.AppendLine(
            "Название,Размер склада,Яблоки,Апельсины,Яблоки - Слад,Яблоки - Продано,Апельсины - Слад,Апельсины - Продано");
        foreach (var market in marketList)
        {
            string name = market.Name;
            int storage = market.Warehouse;
            
            int apllePrice = (int)market.Products.Average(x => x.Price);
            int orangePrice = (int)market.Products.Average(x => x.Price);
            
            List<Product> allAplles = market.Products.Where(x => x.Type == ProductType.Apples).ToList();
            int soldAplles = allAplles.Where(x => x.SoldDate != null).Count();
            int storageAplles = allAplles.Count() - soldAplles;
            
            List<Product> allOranges = market.Products.Where(x => x.Type == ProductType.Oranges).ToList();
            int soldOranges = allOranges.Where(x => x.SoldDate != null).Count();
            int storageOranges = allOranges.Count() - soldOranges;
            
            csvContent.AppendLine($"{name},{storage},{apllePrice},{orangePrice},{storageAplles},{soldAplles},{storageOranges},{soldOranges}");
        }
        File.WriteAllText(filePath, csvContent.ToString());
    }
    public static Lavka SelectLavka(List<Lavka> lavkas)
    {
        Console.WriteLine("Доступные магазины:");
        for (int i = 0; i < lavkas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {lavkas[i].Name}");
        }

        Console.Write("Выберите магазин (введите номер): ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= lavkas.Count)
        {
            return lavkas[choice - 1];
        }
        throw new ArgumentException("Некорректный выбор магазина");
    }
    public static ProductType SelectProductType()
    {
        Console.WriteLine("\nДоступные типы продуктов:");
        var productTypes = Enum.GetValues(typeof(ProductType));
        for (int i = 0; i < productTypes.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {productTypes.GetValue(i)}");
        }

        Console.Write("Выберите тип продукта (введите номер): ");
        if (int.TryParse(Console.ReadLine(), out int typeChoice) && typeChoice > 0 && typeChoice <= productTypes.Length)
        {
            return (ProductType)productTypes.GetValue(typeChoice - 1);
        }
        throw new ArgumentException("Некорректный выбор типа продукта");
    }
    public static int ReadInt(string prompt)
    {
        Console.Write(prompt);
        if (int.TryParse(Console.ReadLine(), out int value))
        {
            return value;
        }
        throw new ArgumentException("Некорректное числовое значение");
    }
    public static Product CreateProduct()
    {
        ProductType type = SelectProductType();
        int price = ReadInt("Введите цену продукта: ");
        return new Product
        {
            Type = type,
            Price = price,
        };
    }
    public static void AddProductToLavka(Lavka lavka, Product product)
    {
        lavka.Products.Add(product);
        Console.WriteLine($"\nПродукт типа '{product.Type}' добавлен в магазин '{lavka.Name}'");
    }

    public static void ShowProducts(Lavka lavka)
    {
        Console.WriteLine("\nСписок продуктов в магазине:");
        foreach (var product in lavka.Products)
        {
            Console.WriteLine($"{product.Type} - Цена: {product.Price} руб.");
        }
    }
}