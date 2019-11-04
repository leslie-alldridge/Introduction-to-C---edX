using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student details: ");
            Console.WriteLine("Name: ");
            string studentName = Console.ReadLine();
            Console.WriteLine("Brithdate (yyyy mm dd): ");
            DateTime studentBirthdate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine($"{studentName} was born on {studentBirthdate}");
        }
    }
}
