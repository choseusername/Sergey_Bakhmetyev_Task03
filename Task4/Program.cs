using System;
using HelperFunctions;

namespace Task4
{
    class Program
    {
        public static bool IsEven(int value)
        {
            return value % 2 == 0;

        }

        private static int SumElementsArrayOnEvenPositions(int[][] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                for (int j = 0; j < array[i].Length; ++j)
                {
                    if (IsEven(i + j))
                        sum += array[i][j];
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int[][] twoDimensionArray = new int[10][];

            for(int i = 0; i < twoDimensionArray.Length; ++i)
                twoDimensionArray[i] = GetRandom.OneDimensionalArray(-100, 999, 10);

            Console.WriteLine("Двумерный массив:");
            ConsoleDisplay.DisplayTwoDimensionArray(twoDimensionArray);

            Console.WriteLine("Сумма элементов массива, стоящих на чётных позициях равна {0}",
                SumElementsArrayOnEvenPositions(twoDimensionArray));
            Console.ReadKey();
        }
    }
}
