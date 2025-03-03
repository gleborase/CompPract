using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{/// <summary>
/// Задача 2. Заполнить одномерный массив случайным образом и выполнить сортировку по возрастанию (через вложенный цикл, с использованием метода Sort()).
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] omas = new int[Input()];
            Vvod(omas);
            Vivod(omas);
            Array.Sort(omas);
            Vivod(omas);
            //Sort(omas);
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
        //static void Sort(int[] omas)
        //{
        //    for (int i = 0; i < omas.Length; i++)
        //    {
        //        for (int j = i + 1; j < omas.Length; j++)
        //        {
        //            if (omas[i] > omas[j])
        //            {
        //                int temp = omas[i];
        //                omas[i] = omas[j];
        //                omas[j] = temp;

        //            }
        //        }
        //    }
           
        //    for (int i = 0; i < omas.Length; i++)
        //    {
        //        Console.Write($"{omas[i]}");
        //    }
        //}
    }
}
