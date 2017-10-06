using System;

namespace HelperFunctions
{
    public static class ConsoleDisplay
    {
        public static void DisplayOneDimensionArray(int[] array)
        {
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
        }

        public static void DisplayTwoDimensionArray(int[][] twoDimensionArray)
        {
            foreach (int[] array in twoDimensionArray)
            {
                DisplayOneDimensionArray(array);
                Console.WriteLine();
            }
        }

        public static void DisplayThreeDimensionArray(int[][][] threeDimensionArray)
        {
            foreach (int[][] twoDimensionArray in threeDimensionArray)
            {
                DisplayTwoDimensionArray(twoDimensionArray);
                Console.WriteLine();
            }
        }
    }
}
