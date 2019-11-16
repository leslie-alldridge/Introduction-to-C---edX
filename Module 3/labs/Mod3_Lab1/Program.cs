using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sum() method that takes two integer arguments and sums them
            // The method returns no value which is why we use void
            // We also need to use static in the method signature because Main is static
            // and you cannot call a non-static method from a static method
            int result = Sum(20, 40);
            int secondResult = Sum(10, 50, 80);
            double doubleResult = Sum(20.5, 30.6);
            Console.WriteLine(result);
            Console.WriteLine(secondResult);
            Console.WriteLine(doubleResult);
        }
        static int Sum(int first, int second) => first + second;

        static int Sum(int first, int second, int third) => first + second + third;

        static double Sum(double first, double second) => first + second;
    }
}
