namespace SecondTask;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите сторону A");
        double sideA = Math.Pow(Convert.ToInt32(Console.ReadLine()), 2);

        Console.WriteLine("Введите сторону B");
        double sideB = Math.Pow(Convert.ToInt32(Console.ReadLine()), 2);

        Console.WriteLine("Введите сторону C");
        double sideC = Math.Pow(Convert.ToInt32(Console.ReadLine()), 2);

        double maxside = Math.Max(sideA, Math.Max(sideB, sideC));

        string result = "неопределен";
        
        // если А наибольшая сторона
        if (maxside == sideA)
        {
            if (sideB + sideC ==  sideA) 
            {
                result = "прямоугольный";
            }

            if (sideB - sideC > sideA) 
            {
                result = "остроугольный";
            }

            if (sideB + sideC < sideA)
            {
                result = "тупоугольный";
            }
        }
        // если B наибольшая сторона
        if (maxside == sideB)
        {
            if (sideA + sideC ==  sideB) 
            {
                result = "прямоугольный";
            }

            if (sideA - sideC > sideB) 
            {
                result = "остроугольный";
            }

            if (sideA + sideC < sideB)
            {
                result = "тупоугольный";
            }
        }
        
        // если C наибольшая сторона
        if (maxside == sideC)
        {
            if (sideB + sideA ==  sideC) 
            {
                result = "прямоугольный";
            }

            if (sideB - sideA > sideC) 
            {
                result = "остроугольный";
            }

            if (sideB + sideA < sideC)
            {
                result = "тупоугольный";
            }
        }
        
        Console.WriteLine("Тип треугольника " + result);

    }
}
    