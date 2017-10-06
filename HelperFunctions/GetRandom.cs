using System;
using System.Linq;

namespace HelperFunctions
{
    public static class GetRandom
    {
        public static Random rand = new Random();
        public static int[] OneDimensionalArray(int minValue, int maxValue, int count)
        {
            return Enumerable
                .Repeat(0, count)
                .Select(x => rand.Next(minValue, maxValue))
                .ToArray();
        }
    }
}
