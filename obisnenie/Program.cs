using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace obisnenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mas =
            {
                "ВойнаИМир-Толстой-1869-4,8",
                "ПреступлениеИНакаание-Достоевский-1866-4,7",
                "1984-Оруэлл-1949-4,6",
                "МастерИМаргарита-Булгаков-1967-4,9",
                "ВластелинКолец-Толкин-1954-4,8",
                "ГарриПоттер-Роулинг-1997-4,5",
                "ВишневыйСад-Чехов-1904-4,3",
                "НоваяКнига-Автор-2020-4,2"
            };
            Console.WriteLine("=== Анализ библиотеи ===");
            Console.WriteLine();
            Console.WriteLine("Книга с рейтингом больше 4.5");
            var reit = mas.Where(m => Convert.ToDouble(m.Split('-')[3]) > 4.5);
            foreach (var a in reit)
            {
                Console.WriteLine($"  - {a.Split('-')[0]}");
            }
            Console.WriteLine();
            Console.WriteLine("Книги, которые были выпущенны после 2015 года:");
            var age = mas.Where(m => Convert.ToInt32(m.Split('-')[2]) > 2015);
            foreach (var a in age)
            {
                Console.WriteLine($"  - {a.Split('-')[0]} - {a.Split('-')[2]}");
            }
            Console.WriteLine();
            Console.WriteLine($"Топ три книги");
            var top3 = mas.OrderByDescending(m => Convert.ToDouble(m.Split('-')[3])).Take(3);
            foreach (var a in top3)
            {
                Console.WriteLine($" -- {a.Split('-')[0]} - {a.Split('-')[3]} --");
            }
            Console.WriteLine();
            Console.WriteLine($"Книги, которые начинаются с буквы В:");
            var b = mas.Where(m => m.StartsWith("В"));
            foreach (var a in b)
            {
                Console.WriteLine($"  - {a.Split('-')[0]}");
            }    
        }
    }
}
