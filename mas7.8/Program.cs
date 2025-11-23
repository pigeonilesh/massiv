using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas7._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите количество результатов");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[a];
            Random r = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = r.Next(0, 101);
                Console.Write(mas[i]+" ");
            }
            Console.WriteLine();
            double med = 0;
            if (mas.Length % 2 == 0)
            {
                med = (mas[(mas.Length / 2) - 1] + mas[mas.Length / 2]) / 2.0;
            }
            else
                med = mas[mas.Length / 2];
            Console.WriteLine($"Медиана: {med}");
            Array.Sort(mas);
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            var sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
            }
            var sred = sum / mas.Length;
        }
    }
}
