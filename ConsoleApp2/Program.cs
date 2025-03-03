using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{  /// <summary>
   /// Задача 3. В одномерном массиве, заполненном с использованием явной инициализации, найти:
   ///1. максимальный элемент и его индекс;
   ///2. минимальный элемент и его индекс;
   ///3. поменять местами максимальный и минимальный элементы, вывести одномерный массив;
   ///4. количество элементов между максимальным и минимальным элементами.
   /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] omas = { 6, 5, 9, 0, 3, 7, 4, 1 };
            Task3_1(omas);
            Task3_2(omas);
            Task3_3(omas, 2, 3);
            Task3_4(omas, 2, 3);
            Console.ReadKey();
        }
        static void Task3_1(int[] omas)
        {
            int max = omas[0];
            int maxIndex = 0;

            for (int i = 1; i < omas.Length; i++)
            {
                if (omas[i] > max)
                {
                    max = omas[i];
                    maxIndex = i;
                }
            }
            Console.WriteLine($"Максимальный элемент: {max}, индекс: {maxIndex}");
        }
        static void Task3_2(int[] omas)
        {
            int min = omas[0];
            int minIndex = 0;

            for (int i = 1; i < omas.Length; i++)
            {

                if (omas[i] < min)
                {
                    min = omas[i];
                    minIndex = i;
                }
            }
            Console.WriteLine($"Минимальный элемент: {min}, индекс: {minIndex}");
        }
        static void Task3_3(int[] omas, int maxIndex, int minIndex)
        {
            (omas[maxIndex], omas[minIndex]) = (omas[minIndex], omas[maxIndex]);
            Console.WriteLine("Массив после замены:");
            foreach (int num in omas)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        static void Task3_4(int[] omas, int maxIndex, int minIndex)
        {
            int elementsBetween = (maxIndex > minIndex) ? (maxIndex - minIndex - 1) : (minIndex - maxIndex - 1);
            Console.WriteLine($"Количество элементов между ними: {elementsBetween}");
        }
    }
}
