namespace FirstTask;

class Program
{
    static void Main(string[] args)
    {
        FirstTask();
        SecondTask();
        ThirdTask();
    }
    
    private static void FirstTask()
    {
        Random rnd = new Random();
        int price = rnd.Next(1, 10000);
        Console.WriteLine("Cтоимость товара: " + price);
        
        int sum = ReadIntFromConsole("Введите сумму имеющихся денежных средств");

        if (sum < price)
        {
            Console.WriteLine("Недостаточно денег"); 
            return;
        }

        int change = sum - price;
        Console.WriteLine("Ваша сдача " + change);
        
    }


    private static void SecondTask()
    {
        Console.WriteLine("Введите имя");
        string name = Console.ReadLine();

        Console.WriteLine("Введите фамилию");
        string surname = Console.ReadLine();

        int year = ReadIntFromConsole("Введите год рождения");
        
        int currentyear = DateTime.Today.Year;

        string age = Convert.ToString(currentyear - year);

        string sayHello = "Привет, " + name + ", " + surname + ", " + age;
        Console.WriteLine(sayHello);
    }

    private static void ThirdTask()
    {
        int a = ReadIntFromConsole("Введите переменную a");
        int b = ReadIntFromConsole("Введите переменную b");
        
        Console.WriteLine("Переменная a = " + a);
        Console.WriteLine("Переменная b = " + b);

        a = a + b;
        b = a - b;
        a = a - b;
        
        Console.WriteLine("Выполнено перемещение");
        Console.WriteLine("Переменная a = " + a);
        Console.WriteLine("Переменная b = " + b);
    }

    private static int ReadIntFromConsole(string message)
    {
        int converted = 0;
        while (converted <= 0)
        {
            Console.WriteLine(message);
            string result = Console.ReadLine();
            int.TryParse(result, out converted);
        }
        return converted;
    }
} 