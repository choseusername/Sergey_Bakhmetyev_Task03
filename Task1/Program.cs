using System;
//using System.Linq;
using Algorithms;
using HelperFunctions;

namespace Task1
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] array = GetRandom.OneDimensionalArray(-1000, 1000, 10);

            Console.WriteLine("Исходный массив:");
            ConsoleDisplay.DisplayOneDimensionArray(array);

            var sorter = new QuickSort<int>(array);
            sorter.Sort();

            int min = array[0];
            int max = array[array.Length - 1];
            
            Console.WriteLine("\nМинимальный элемент {0}, максимальный элемент {1}\n", min, max);

            Console.WriteLine("Массив после сортировки:");
            ConsoleDisplay.DisplayOneDimensionArray(array);

            Console.ReadKey();
        }
    }
}
