 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massiv7._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] mas = new string[10][];
            mas[0] = new string[] {"Банан", "20", "Продукты"};
            mas[1] = new string[] {"Клавиатура", "1500", "Техника"};
            mas[2] = new string[] {"Парацетамол", "500", "Лекарства"};
            mas[3] = new string[] {"Наушники", "600", "Техника"};
            mas[4] = new string[] {"Нурафен", "700", "Лекарства"};
            mas[5] = new string[] {"Яблоко", "15", "Продукты"};
            mas[6] = new string[] {"Апельсин", "40", "Продукты"};
            mas[7] = new string[] {"Ручка", "70", "Канцелярия"};
            mas[8] = new string[] {"Степлер", "250", "Канцелярия"};
            mas[9] = new string[] {"Киви", "100", "Продукты"};
            foreach (string[] tovar in mas) 
            {
                Console.WriteLine($"{tovar[0]} - {tovar[1]} руб. ({tovar[2]})");
            }
            Console.WriteLine();
            Console.WriteLine($"Введите категорию товаров, которые хотите найти:");
            string kat = Console.ReadLine();
            foreach (string[] tovar in mas)
            {
                if (tovar[2].ToLower() == kat.ToLower())
                {
                    Console.WriteLine($"{tovar[0]} - {tovar[1]} руб. ({tovar[2]})");
                }
            }
            Console.WriteLine();
            Array.Sort(mas, (x, y) => string.Compare(x[2], y[2]));
            Console.WriteLine("Отсортированный список по категориям:");
            foreach (string[] tovar in mas)
            {
                Console.WriteLine($"{tovar[0]} - {tovar[1]} руб. ({tovar[2]})");
            }
            Console.WriteLine();
            Console.WriteLine($"Введите ценовой диапозон для поиска товаров.");
            Console.WriteLine($"Введите минимум:");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите максимум:");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Товары в диапазоне от {min} до {max} руб.:");
            foreach (string[] tovar in mas)
            {
                int price = Convert.ToInt32(tovar[1]);
                if (price >= min && price <= max)
                {
                    Console.WriteLine($"{tovar[0]} - {tovar[1]} руб. ({tovar[2]})");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Отсортированный список по цене:");
            Array.Sort(mas, (x, y) => { int pricex = Convert.ToInt32(x[1]), pricey = Convert.ToInt32(y[1]); return pricex.CompareTo(pricey); });
            foreach (string[] tovar in mas)
            {
                Console.WriteLine($"{tovar[0]} - {tovar[1]} руб. ({tovar[2]})");
            }
        }
    }
}
