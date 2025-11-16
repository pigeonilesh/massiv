using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massiv7._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] mas = new string[6][];
            mas[0] = new string[] {"Иванов Иван Васильевич", "Директор"};
            mas[1] = new string[] {"Петров Генадий Генадьевич", "Секретарь"};
            mas[2] = new string[] {"Степанов Степан Степанович", "Менеджер продаж"};
            mas[3] = new string[] {"Григорьев Григорий Григорьевич", "Менеджер рекламы"};
            mas[4] = new string[] {"Александров Александр Александрович", "Бухгалтер"};
            mas[5] = new string[] {"Гулкин Миша Иванович", "Рабочий"};
            foreach (string[] s1 in mas)  
            {
                foreach (string s2 in s1)
                {
                    Console.WriteLine($"{s2}");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Введите должность сотрудников, которых хотите найти:");
            string a = Console.ReadLine();
            foreach (string[] s1 in mas)
            {
                if (s1[1].ToLower() == a.ToLower())
                {
                    Console.WriteLine($"{s1[0]}");
                }
            }
            Console.WriteLine($"Введите букву (Фамилии) по которой хотите найти сотрудников: ");
            string b = Console.ReadLine();
            foreach (string[] s1 in mas)
            {
                if (s1[0].ToLower()[0] == b.ToLower()[0])
                {
                    Console.WriteLine($"{s1[0]} ({s1[1]})");
                } 
            }
            Console.WriteLine($"Хотите отсортировать список по алфавиту?");
            string c = Console.ReadLine();
            switch (c.ToLower())
            {
                case "да":
                    Console.WriteLine("Отсортированный список сотрудников:");
                    Array.Sort(mas, (x, y) => string.Compare(x[0], y[0]));
                    foreach (string[] s1 in mas)
                    {
                        Console.WriteLine($"{s1[0]} - {s1[1]}");
                    }
                    break;
                case "нет":
                    Console.WriteLine("Сортировка не выполнена.");
                    break;
                default:
                    Console.WriteLine($"Неверный ответ");
                    break;
            }
        }
    }
}
