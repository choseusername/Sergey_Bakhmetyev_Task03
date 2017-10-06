using System;
using HelperFunctions;

namespace Task2
{
    class Program
    {
        private static int[][][] GetThreeDimensionArray()
        {

            int[][][] threeDimensionArray = new int[5][][];
            
            for (int i = 0; i < threeDimensionArray.Length; ++i)
            {
                threeDimensionArray[i] = new int[5][];
                for (int j = 0; j < threeDimensionArray[i].Length; ++j)
                {
                    threeDimensionArray[i][j] = GetRandom.OneDimensionalArray(-100, 100, 5);
                }
            }
            return threeDimensionArray;
        }

        private static void ReplaceGreaterZeroToZero(int[][][] threeDimensionArray)
        {
            for (int i = 0; i < threeDimensionArray.Length; ++i)
            {
                for (int j = 0; j < threeDimensionArray[i].Length; ++j)
                {
                    for (int k = 0; k < threeDimensionArray[j].Length; ++k)
                    {
                        if (threeDimensionArray[i][j][k] > 0)
                            threeDimensionArray[i][j][k] = 0;
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            int[][][] threeDimensionArray = GetThreeDimensionArray();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Трехмерный массив:");
            Console.ForegroundColor = ConsoleColor.Gray;
            ConsoleDisplay.DisplayThreeDimensionArray(threeDimensionArray);

            ReplaceGreaterZeroToZero(threeDimensionArray);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Послез замены всех положительных элементов в трёхмерном массиве на нули:");
            Console.ForegroundColor = ConsoleColor.Gray;
            ConsoleDisplay.DisplayThreeDimensionArray(threeDimensionArray);
            Console.ReadKey();
        }
    }
}
