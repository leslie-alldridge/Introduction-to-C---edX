﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 9;
            int second = 0;
            Console.WriteLine("Enter your first number: ");
            first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            second = int.Parse(Console.ReadLine());
            int result = Divide(first, second);
            if (result != 0)
            {
                Console.WriteLine($"The result of dividing {first} by {second} is {result}");
            }
        }
        // Method Divide() accepts two integer arguments and returns the result
        // of dividing first by second
        // We do no validation of the the arguments so a user may pass in a zero
        // in place of the second parameter.   This is an illegal operation in math
        // If we don't validate input or catch the error, the application will crash
        static int Divide(int first, int second)
        {
            int result = 0;
            try
            {
                result = first / second;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero, please provide a non-zero value for your second value.");
            }
            return result;
        }
    }
}
