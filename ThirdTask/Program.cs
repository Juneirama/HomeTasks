namespace ThirdTask;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите римское или арабское число");
        string input = Console.ReadLine().ToUpper();

        // Проверяем строка или число
        bool isNumber = true;
        foreach (var symbol in input)
        {
            if (!char.IsDigit(symbol))
            {
                isNumber = false;
                break;
            }

            if (isNumber)
            {
                int number = int.Parse(input);
                if (number < 1 || number > 1000)
                {
                    Console.WriteLine($"Неверное число");
                }
                else
                {
                    string result = ArabicToRoman(number);
                    Console.WriteLine(result);
                }
            }
            else
            {
                int result = RomanToArabic(input);
                Console.WriteLine(result);
                if (result >= 0)
                {
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine($"Неверное число");
                }
            }
        }
    }

    private static string ArabicToRoman(int number)
    {
        string roman = "";

        // Конвертируем тысячи
        while (number >= 1000)
        {
            roman += "M";
            number -= 1000;
        }

        // Конвертируем сотни
        if (number >= 900)
        {
            roman += "CM";
            number -= 900;
        }
        else if (number >= 500)
        {
            roman += "D";
            number -= 500;
        }
        else if (number >= 400)
        {
            roman += "CD";
            number -= 400;
        }

        while (number >= 100)
        {
            roman += "C";
            number -= 100;
        }

        // Конвертируем десятки
        if (number >= 90)
        {
            roman += "XC";
            number -= 90;
        }
        else if (number >= 50)
        {
            roman += "L";
            number -= 50;
        }
        else if (number >= 40)
        {
            roman += "XL";
            number -= 40;
        }

        while (number >= 10)
        {
            roman += "X";
            number -= 10;
        }

        // Конвертируем единицы 
        if (number >= 9)
        {
            roman += "IX";
            number -= 9;
        }
        else if (number >= 5)
        {
            roman += "V";
            number -= 5;
        }
        else if (number >= 4)
        {
            roman += "IV";
            number -= 4;
        }

        while (number >= 1)
        {
            roman += "I";
            number -= 1;
        }

        return roman;
    }

    private static int RomanToArabic(string roman)
    {
        int result = 0;
        int prevValue = 0;

        for (int i = roman.Length - 1; i >= 0; i--)
        {
            int currentValue = 0;
            switch (roman[i])
            {
                case 'I':
                    currentValue = 1;
                    break;
                case 'V':
                    currentValue = 5;
                    break;
                case 'X':
                    currentValue = 10;
                    break;
                case 'L':
                    currentValue = 50;
                    break;
                case 'C':
                    currentValue = 100;
                    break;
                case 'D':
                    currentValue = 500;
                    break;
                case 'M':
                    currentValue = 1000;
                    break;
                default: return -1;
            }

            if (currentValue < prevValue)
            {
                result -= currentValue;
            }
            else
            {
                result += currentValue;
            }

            prevValue = currentValue;
        }

        return result;
    }

}