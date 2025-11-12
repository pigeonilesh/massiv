using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massiv1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dip = new int[15];
            Random a = new Random();
            int kol1 = 0;
            int kol2 = 0;
            int kol3 = 0;
            int sum1 = 0;
            int sum2 = 0;
            
            for (int i = 0; i < dip.Length; i++)
            {
                dip[i] = a.Next(-10, 11);
            }
            Console.WriteLine($"Массив: ");
            for (int i = 0;i < dip.Length; i++)
            {
                Console.Write($"{dip[i]}  ");
            }
            for (int i = 0; i < dip.Length; i++)
            {
                if (dip[i] == 0)
                {
                    kol3++;
                }
                else if (dip[i] > 0)
                {
                    kol1++;
                    sum1 += dip[i];
                }
                else if (dip[i] < 0)
                {
                    kol2++;
                    sum2 += dip[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Количество нулей: {kol3}");
            Console.WriteLine($"Количество положительных чисел: {kol1}");
            Console.WriteLine($"Количество отрицательных чисел: {kol2}");
            Console.WriteLine($"Сумма положительных чисел: {sum1}");
            Console.WriteLine($"Сумма отрицательных чисел: {sum2}");
        }
    }
}
