using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massiv3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[20];
            Random r = new Random();
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = r.Next(1, 101);
                Console.Write(num[i] + " ");
            }
            int min = num[0];
            int max = num[0];
            int max2 = num[0];
            int mini = 0;
            int maxi = 0;
            int kol = 0;
            int dub = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] >= max)
                {
                    max = num[i];
                    maxi = i;
                }
                else if (num[i] <= min)
                {
                    min = num[i];
                    mini = i;
                }
            }   
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > max2 && num[i] != max)
                {
                    max2 = num[i];
                }
            }
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length; j++)
                {
                    if (num[j] == num[i] && j != i)
                    {
                        kol++;
                        dub = num[j];
                    }
                }
            }    
            Console.WriteLine();
            Console.WriteLine($"Максимальное значение: {max}, индекс максимального значения: {maxi+1}");
            Console.WriteLine($"Минимальное значение: {min}, индекс минимального значения: {mini+1}");
            Console.WriteLine($"Второе по величине число: {max2}");
            if (kol == 0)
            {
                Console.WriteLine($"В массиве нет дубликатов");
            }
            else
            {
                Console.WriteLine($"В массиве есть дубликаты");
                Console.WriteLine($"Повторяющееся число в массиве: {dub}");
            }
        }
    }
}
