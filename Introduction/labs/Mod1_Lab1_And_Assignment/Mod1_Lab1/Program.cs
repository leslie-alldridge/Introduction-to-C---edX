using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create variables of different data types
            // initialize with a default value
            string firstName = "";
            string lastName = "";
            int age = 0;
            string street = "";
            string city = "";
            string country = "";
            DateTime birthDate;

            // assign some values
            firstName = "Leslie";
            lastName = "Alldridge";
            age = 18;
            street = "102 Young Street";
            city = "New Plymouth";
            country = "New Zealand";
            birthDate = new DateTime(1992, 6, 9);

            // output to console window

            // use simple output with just variable name
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            // use placeholder style
            Console.WriteLine(street + ", " + city + ", " + country);

            // use string interpolation
            Console.WriteLine($"Born on {birthDate} and is {age} years old");
        }
    }
}
