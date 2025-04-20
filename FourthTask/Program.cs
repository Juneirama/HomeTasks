using System.Collections.Concurrent;
using System.Globalization;

namespace FourthTask
{
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите цифры для массива через запятую");
                string[] arrayStringNumber = Console.ReadLine().Split(',');
                int[] arrayNumber = ArrayHelper.ConvertStringArrayToIntArray(arrayStringNumber);
                
                // Инициализация массива
                ArrayHelper.SetArray(arrayNumber);
                Console.WriteLine("Наш массив:" + string.Join(",", ArrayHelper.MyArray));
                
                // Получение размера массива (свойство)
                Console.WriteLine("Длинна массива " + ArrayHelper.ArrayLength);
                
                // Получение элемента по индексу
                Console.WriteLine("Введите номер элемента массива для вывода");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(index + "-й элемент массива: " + ArrayHelper.GetByIndex(index - 1));
                
                // Добавление элемента в конец массива
                Console.WriteLine("Введите цифру для добавления в массив");
                int newNumber = Convert.ToInt32(Console.ReadLine());
                ArrayHelper.AddLastElement(newNumber);
                Console.WriteLine("Обновленный массив " + string.Join(",", ArrayHelper.MyArray));
                
                // Сортировка массива по возрастанию
                ArrayHelper.SortingAsc();
                Console.WriteLine("Отсортированный массив: " + string.Join(",", ArrayHelper.MyArray));
                
                
                // Сортировка массива по убыванию
                ArrayHelper.SortingDesc();
                Console.WriteLine("Отсортированный массив: " + string.Join(",", ArrayHelper.MyArray));
                
                // Вставка элемента по индексу
                Console.WriteLine("Введите цифру для вставки");
                int element = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Укажите место массива для вставки в диапазоне от 0 до " + ArrayHelper.ArrayLength);
                int newIndex = Convert.ToInt32(Console.ReadLine());
                ArrayHelper.AddElementByIndex(element, newIndex); 
                Console.WriteLine("Массив с новым вставленным индексом: " );
            }

        }
        
}
