using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massiv7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mas = new string[5];
            for(int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine($"Хотите ввести значение сами? (да/нет)");
                string ot = Console.ReadLine();
                string yes = "да";
                string no = "нет";
                if( ot == yes )
                {
                    mas[i] = Console.ReadLine();
                }
                else if( ot == no)
                {
                    mas[i] = "null";
                }
            }
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i]+" ");
            }
            Console.WriteLine();
            int dlin = mas[0].Length;
            string dlins = "";
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i].Length >= dlin)
                {
                    dlin = mas[i].Length;
                    dlins = mas[i];
                }
            }
            Console.WriteLine($"Самая длинная строка: {dlins}, количенство элементов: {dlin}");
            Console.WriteLine($"Все строки которын вы ввели:");
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] != "null")
                {
                    Console.WriteLine(mas[i]);
                }
            }
            int si = 0;
            Console.WriteLine($"Введите слово которое хотите найти:");
            string slova = Console.ReadLine();
            for (int i = 0;i < slova.Length; i++)
            {
                if (mas[i] == slova)
                {
                    si = i;
                    Console.WriteLine($"Индекс вашего слова в массиве равен: {si}");
                    break;
                }
            } 
        }
    }
}
