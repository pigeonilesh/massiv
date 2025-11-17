using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas7._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[30];
            Random r = new Random();
            for (int t = 0; t < mas.Length; t++)
            {
                mas[t] = r.Next(-35, 41);
            }
            for (int t = 0; t < mas.Length; t++)
            {
                Console.Write(mas[t] + " ");
                if ((t + 1) % 7 == 0) Console.WriteLine(); 
            }
            Console.WriteLine();
            int hotw = -1000; 
            int coldw = 1000;  
            int hotned = 1;  
            int coldned = 1;  
            for (int week = 0; week < 4; week++)
            {
                int sumt = 0;
                for (int day = 0; day < 7; day++)
                {
                    int dayi = week * 7 + day;
                    if (dayi < mas.Length)
                    {
                        sumt += mas[dayi];
                    }
                }
                Console.WriteLine($"Неделя {week + 1} имеет среднею температуру {sumt / 7.0:F2}");
                if (sumt > hotw)
                {
                    hotw = sumt;
                    hotned = week + 1;
                }
                if (sumt < coldw)
                {
                    coldw = sumt;
                    coldned = week + 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"{hotned} самая теплая неделя, средняя температура: {hotw / 7.0:F2}");
            Console.WriteLine($"{coldned} самая холодная нелделя, средняя температура:{coldw / 7.0:F2}");
            int sumtm = 0;
            for (int t = 0; t < mas.Length; t++)
            {
                sumtm += mas[t];
            }
            double sredt = sumtm / 30.0;
            Console.WriteLine($"Средняя температура за месяц: {sredt:F2}");
            Console.WriteLine();
            Console.WriteLine("Все значение температур, которые превышают среднее значение за месяц:");
            for (int day = 0; day < mas.Length; day++)
            {
                if (mas[day] > sredt)
                {
                    Console.Write(mas[day] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Группировка температур по диапазонам(мороз, холодно, тепло, жарко)");
            Console.WriteLine("Мороз: ");
            for (int day = 0; day < mas.Length; day++)
            {
                if (mas[day] < 0)
                {
                    Console.Write(mas[day] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Холодно: ");
            for (int day = 0; day < mas.Length; day++)
            {
                if (mas[day] >= 0 && mas[day] <= 15)
                {
                    Console.Write(mas[day] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Тепло: ");
            for (int day = 0; day < mas.Length; day++)
            {
                if (mas[day] >= 16 && mas[day] <= 25)
                {
                    Console.Write(mas[day] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Жарко: ");
            for (int day = 0; day < mas.Length; day++)
            {
                if (mas[day] > 25)
                {
                    Console.Write(mas[day] + " ");
                }
            }
        }
    }
}
