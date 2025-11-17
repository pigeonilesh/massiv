using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas7._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mas = {
            "Иванов Иван Васильевич, Директор",
            "Петров Генадий Генадьевич, Секретарь",
            "Степанов Степан Степанович, Менеджер продаж",
            "Григорьев Григорий Григорьевич, Менеджер рекламы",
            "Александров Александр Александрович, Бухгалтер",
            "Гулкин Миша Иванович, Рабочий"
            };
            Console.WriteLine("Все сотрудники:");
            for (int s = 0; s < mas.Length; s++)
            {
                Console.WriteLine(mas[s]);
            }
            Console.WriteLine();
            Console.WriteLine($"Введите должность сотрудников, которых хотите найти:");
            string a = Console.ReadLine();
            for (int s = 0; s < mas.Length; s++)
            {
                string[] r = mas[s].Split(',');
                string name = r[0];
                string dol = r[1].TrimStart();
                if (dol.ToLower() == a.ToLower())
                {
                    Console.WriteLine(name);
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Введите букву (Фамилии) по которой хотите найти сотрудников: ");
            string b = Console.ReadLine();
            for (int s = 0; s < mas.Length; s++)
            {
                string[] r = mas[s].Split(',');
                string name = r[0];
                if (name.ToLower()[0] == b.ToLower()[0])
                {
                    Console.WriteLine(mas[s]);
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Хотите отсортировать список по алфавиту?");
            string c = Console.ReadLine();
            switch (c.ToLower())
            {
                case "да":
                    Console.WriteLine("Отсортированный список сотрудников:");
                    Array.Sort(mas);
                    for (int s = 0; s < mas.Length; s++)
                    {
                        Console.WriteLine(mas[s]);
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
