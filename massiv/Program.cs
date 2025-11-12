using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = i + 1;
            }
            Console.WriteLine("Массив: ");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            }
            Console.WriteLine();
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            Console.WriteLine($"Сумма всех элементов массива: {sum}");
            int pro = 1;
            for (int i = 0; i < num.Length; i++)
            {
                pro *= num[i];
            }
            Console.WriteLine($"Произведение всех элементов массива: {pro}");           
            double sred = sum / num.Length;
            Console.WriteLine($"Среднее арифметическое всех элементов массива: {sred}");
        }
    }
}
