using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIgnat20._03._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Задание 1
           
            Console.Write("Введите количество элементов массива: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите элемент массива [{i}]: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int max = array[0];
            int maxIndex = 0;

            for (int i = 1; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }
            }

            Console.WriteLine($"Максимальный элемент массива: {max}");
            Console.WriteLine($"Индекс максимального элемента: {maxIndex}");
        }
    }
}
