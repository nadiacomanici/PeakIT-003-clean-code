﻿using System;
using System.Collections.Generic;

namespace MeaningfulNames_Begin
{
    class Program
    {
        public static double Compute(List<int> a)
        {
            double x = 0;
            int y = 0;
            foreach (int nr in a)
            {
                x += nr;
                y++;
            }
            if (y == 0)
            {
                return 0;
            }
            else
            {
                return x / y;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Average is: {Compute(new List<int>())}");
            Console.WriteLine($"Average is: {Compute(new List<int> { 1, 2, 3, 4, 5 })}");
            Console.WriteLine($"Average is: {Compute(new List<int> { 10, -2, -13, 4, 9 })}");
        }
    }
}
