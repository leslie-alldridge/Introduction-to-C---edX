﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a simple for loop that displays the values of the counter
            // The WriteLine method here demonstrates the use of string interpolation in C#
            // as a way of outputting literal string values with variable values.
            // It is the recommended way to deal with this method of string output
            for (int counter = 1; counter <=10; counter++)
            {
                Console.WriteLine($"Counter is at {counter}");
            }

            // create a nested for loop to find prime numbers less than 100

            int outer;
            int inner;

            for (outer = 2; outer < 100; outer++)
            {
                for (inner = 2; inner <= (outer/inner); inner++)
                    if ((outer % inner) == 0) break; // because self divisible not a prime number we break out of the second for loop
                if (inner > (outer / inner))
                    Console.WriteLine("{0} is a prime number.", outer);
            }
        }
    }
}
