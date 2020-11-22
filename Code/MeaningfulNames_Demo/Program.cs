using System;
using System.Collections.Generic;
using System.Linq;

namespace MeaningfulNames_Demo
{
    class Program
    {
        public static double GetAverageOptimized(List<int> numbers)
        {
            if (numbers.Count > 0)
            {
                return numbers.Average();
            }
            return 0;
        }

        public static double GetAverage(List<int> numbers)
        {
            double sum = 0;
            int count = 0;
            foreach (int number in numbers)
            {
                sum += number;
                count++;
            }
            if (count == 0)
            {
                return 0;
            }
            else
            {
                return sum / count;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetAverageOptimized(new List<int>()));
            Console.WriteLine(GetAverageOptimized(new List<int> { 1, 2, 3, 4, 5 }));
            Console.WriteLine(GetAverageOptimized(new List<int> { 10, -2, -13, 4, 9 }));
        }
    }
}
