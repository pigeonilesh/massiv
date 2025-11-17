using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas7._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mas = {
            "Банан,20,Продукты",
            "Клавиатура,1500,Техника",
            "Парацетамол,500,Лекарства",
            "Наушники,600,Техника",
            "Нурафен,700,Лекарства",
            "Яблоко,15,Продукты",
            "Апельсин,40,Продукты",
            "Ручка,70,Канцелярия",
            "Степлер,250,Канцелярия",
            "Киви,100,Продукты"
            };
            for (int t = 0; t < mas.Length; t++)
            {
                string[] tov = mas[t].Split(',');
                Console.WriteLine($"{tov[0]} - {tov[1]} руб. ({tov[2]})");
            }
            Console.WriteLine();
            Console.WriteLine($"Введите категорию товаров, которые хотите найти:");
            string kat = Console.ReadLine();
            for (int t = 0; t < mas.Length; t++)
            {
                string[] tov = mas[t].Split(',');
                string name = tov[0];
                string price = tov[1];
                string katt = tov[2];
                if (katt.ToLower() == kat.ToLower())
                {
                    Console.WriteLine($"{name} - {price} руб. ({katt})");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Введите ценовой диапозон для поиска товаров.");
            Console.WriteLine($"Введите минимум:");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите максимум:");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Товары в диапазоне от {min} до {max} руб.:");
            for (int t = 0; t < mas.Length; t++)
            {
                string[] tov = mas[t].Split(',');
                string name = tov[0];
                int price = int.Parse(tov[1]);
                string katt = tov[2];
                if (price >= min && price <= max)
                {
                    Console.WriteLine($"{name} - {price} руб. ({katt})");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Отсортированный список по цене:");
            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    string[] tov1 = mas[i].Split(',');
                    string[] tov2 = mas[j].Split(',');

                    int price1 = int.Parse(tov1[1]);
                    int price2 = int.Parse(tov2[1]);

                    if (price1 > price2)
                    {
                        string temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            for (int t = 0; t < mas.Length; t++)
            {
                string[] tov = mas[t].Split(',');
                Console.WriteLine($"{tov[0]} - {tov[1]} руб. ({tov[2]})");
            }
        }
    }
}
