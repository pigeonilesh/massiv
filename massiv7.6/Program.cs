using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace massiv7._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] mas = new int[5][];
            mas[0] = new int[7];
            mas[1] = new int[7];
            mas[2] = new int[7];
            mas[3] = new int[7];
            mas[4] = new int[2];
            Random r = new Random();
            foreach (int[] week in mas)
            {
                for (int day = 0; day < week.Length; day++)
                {
                    week[day] = r.Next(-35, 41);
                    Console.Write(week[day] + " ");
                }
                Console.WriteLine();
            }
            int alldays = 0;
            double sredt = 0;
            int ned = 1;
            double hotw = double.MinValue;
            double coldw = double.MaxValue;
            int hotned = 0;
            int coldned = 0;
            foreach (int[] week in mas)
            {
                int sumt = 0;
                for (int t = 0; t < week.Length; t++)
                {
                    sumt += week[t];
                }
                double sredw = (double)sumt / week.Length;
                Console.WriteLine($"Неделя {ned} имеет среднею температуру {sredw:F2}");
                if (sredw > hotw)
                {
                    hotw = sredw;
                    hotned = ned;
                }
                if (sredw < coldw)
                {
                    coldw = sredw;
                    coldned = ned;
                }
                sredt += sredw;
                alldays += week.Length;
                ned++;
            }
            Console.WriteLine();
            double sredall = sredt / mas.Length;
            Console.WriteLine($"Средняя температура за месяц: {sredall:F2}");
            Console.WriteLine($"{hotned} самая теплая неделя, средняя температура: {hotw:F2}");
            Console.WriteLine($"{coldned} самая холодная неделя, средняя температура: {coldw:F2}");
            ned = 1;
            foreach (int[] week in mas)
            {
                Console.WriteLine($"Все значение температуры за {ned} неделю, которые превышают среднее значение:");
                int sumt = 0;
                for (int t = 0; t < week.Length; t++)
                {
                    sumt += week[t];
                }
                double sredw = (double)sumt / week.Length;
                for (int t = 0; t < week.Length; t++)
                {
                    if (week[t] >= sredw)
                    {
                        Console.Write(week[t] +" ");
                    }
                }
                Console.WriteLine();
                ned++;
            }
            Console.WriteLine($"Все значение температур, которые превышают среднее значение за месяц: ");
            foreach (int[] week in mas)
            {
                int sumt = 0;
                for (int t = 0; t < week.Length; t++)
                {
                    sumt += week[t];
                }
                double sredw = (double)sumt / week.Length;
                for (int t = 0; t < week.Length; t++)
                {
                    if (week[t] >= sredall)
                    {
                        Console.Write(week[t] + " ");
                    }
                }
            }
            List<int> frost = new List<int>();
            List<int> cold = new List<int>();
            List<int> warm = new List<int>();
            List<int> hot = new List<int>();
            foreach (int[] week in mas)
            {
                for (int t = 0; t < week.Length; t++)
                {
                    if (week[t] < 0)
                    {
                        frost.Add(week[t]);
                    }
                    else if (week[t] >= 0 && week[t] <= 15)
                    {
                        cold.Add(week[t]);
                    }
                    else if (week[t] >= 16 && week[t] <= 25)
                    {
                        warm.Add(week[t]);
                    }
                    else if (week[t] > 25)
                    {
                        hot.Add(week[t]);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Группировка температур по диапазонам(мороз, холодно, тепло, жарко)");
            Console.WriteLine("Мороз: ");
            foreach (int a in frost)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Холодно: ");
            foreach (int a in cold)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Тепло: ");
            foreach (int a in warm)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Жарко: ");
            foreach (int a in hot)
            {
                Console.Write(a + " ");
            }
        }
    }
}
