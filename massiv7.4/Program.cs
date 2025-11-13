using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massiv7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите размерность массива:");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[a];
            Random r = new Random();
            for (int i = 0; i < a; i++)
            {
                mas[i] = r.Next(0, 11);
                Console.Write(mas[i]+" ");
            }
            Console.WriteLine();
            int b = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] != 0)
                {
                    b++;
                }
            }
            int[] masik = new int[b];
            int s = 0;
            for (int i = 0; i < a; i++)
            {
                if (mas[i] != 0)
                {
                    masik[s] = mas[i];
                    s++;
                }
            } 
            for (int i = 0; i < b; i++)
            {
                Console.Write(masik[i]+" ");
            }
        }
    }
}
