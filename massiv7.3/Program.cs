using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massiv7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[15];
            Random r = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = r.Next(1, 50);
                Console.Write(mas[i]+" ");
            }
            Console.WriteLine();
            int max = mas[0];
            int min = mas[0];
            int ras = 0;
            int sred = 0;
            int sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
            }
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] >= max)
                {
                    max = mas[i];
                }
                else if (mas[i] <= min)
                {
                    min = mas[i];
                }
            }
            ras = max - min;
            sred = sum / mas.Length;
            Console.WriteLine($"Максимальный элемент массива: {max}");
            Console.WriteLine($"Минимальный элемент массива: {min}");
            Console.WriteLine($"Разница между максимальным и минимальным числом: {ras}");
            Console.WriteLine($"Все элементы массива, которые больше среднего значения({sred}):");
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > sred)
                {
                    Console.Write(mas[i]+" ");
                }
            }
        }
    }
}
