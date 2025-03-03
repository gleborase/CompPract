using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{/// <summary>
/// Задача 1. Заполнить одномерный массив с клавиатуры и вывести его на экран в обратном порядке (с использованием for, Reverse()).
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] omas = new int[Input()];
            Vvod(omas);
            Vivod(omas);
            Array.Reverse(omas);
            Vivod(omas);
            Console.Read();
        }
        static int Input()
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }
        static void Vvod(int[] omas)
        {
            for (int i = 0; i < omas.Length; i++)
            {
                Console.Write($"arr[{i}]= ");
                omas[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void Vivod(int[] omas)
        {
            for (int i = 0; i < omas.Length; i++)
            {
                Console.WriteLine($"arr[{i}]={omas[i]}");
            }
        }
    }
}
