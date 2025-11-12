using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massiv7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[10];
            Random r = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = r.Next(1, 11);
                Console.Write(mas[i]+" ");
            }
            Console.WriteLine();
            int sum = 0;
            int sred = 0;
            int kol = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
            }
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] % 2 == 0)
                {
                    kol++;
                }
            }
            sred = sum / mas.Length;
            Console.WriteLine($"Сумма всех элементов массива: {sum}");
            Console.WriteLine($"Среднее арифметическое: {sred}");
            Console.WriteLine($"Количество четных элементов: {kol}"); 
        }
    }
}
