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
        }
    }
}
