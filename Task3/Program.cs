using System;
using System.Linq;
using HelperFunctions;

namespace Task3
{
    class Program
    {
        private static int SumNonNegative(int[] array)
        {
            return array.Sum(x =>
            {
                if (x > 0)
                    return x;
                return 0;
            });
        }

        static void Main(string[] args)
        {

            int[] array = GetRandom.OneDimensionalArray(-1000, 1000, 5);

            Console.WriteLine("Одномерный массив:");
            foreach (var value in array)
                Console.WriteLine(value);

            Console.WriteLine("\nСумма неотрицательных элементов" +
                "в одномерном массиве равна {0}.", SumNonNegative(array));

            Console.ReadKey();
        }
    }
}
