using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStudentInformation();
            GetTeacherInformation();
            GetCourseInformation();
            GetProgramInformation();
            GetDegreeInformation();
        }
        static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthday");
            DateTime birthday = Convert.ToDateTime(Console.ReadLine());
            ValidateBirthday(birthday);
            PrintStudentDetails(firstName, lastName, birthday);
        }

        static void GetTeacherInformation()
        {
            Console.WriteLine("Enter the teacher's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's subject");
            string subject = Console.ReadLine();
            PrintTeacherDetails(firstName, lastName, subject);
        }

        // Obtain course information
        static void GetCourseInformation()
        {
            Console.WriteLine("Enter the course name: ");
            string course = Console.ReadLine();
            Console.WriteLine("Enter the points required for this course");
            double coursePoints = Convert.ToInt32(Console.ReadLine());
            PrintCourseDetails(course, coursePoints);
        }

        // Obtain program information
        static void GetProgramInformation()
        {
            Console.WriteLine("Enter the program: ");
            string program = Console.ReadLine();
            Console.WriteLine("Enter the points required for this program");
            double programPoints = Convert.ToInt32(Console.ReadLine());
            PrintProgramDetails(program, programPoints);
        }

        // Obtain degree information
        static void GetDegreeInformation()
        {
            Console.WriteLine("Enter the degree: ");
            string degree = Console.ReadLine();
            Console.WriteLine("Enter the points required for this degree");
            double degreePoints = Convert.ToInt32(Console.ReadLine());
            PrintDegreeDetails(degree, degreePoints);
        }

        static void PrintStudentDetails(string first, string last, DateTime birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }

        static void PrintTeacherDetails(string first, string last, string subject)
        {
            Console.WriteLine("{0} {1} teaches this subject: {2}", first, last, subject);
        }

        static void PrintCourseDetails(string course, double coursePoints)
        {
            Console.WriteLine("{0} course requires {1} points", course, coursePoints);
        }

        static void PrintProgramDetails(string program, double programPoints)
        {
            Console.WriteLine("{0} program requires points: {1}", program, programPoints);
        }

        static void PrintDegreeDetails(string degree, double degreePoints)
        {
            Console.WriteLine("{0} degree requires points: {1}", degree, degreePoints);
        }

        static void ValidateBirthday(DateTime birthday)
        {
            Convert.ToString(birthday);
            throw new NotImplementedException("We are still developing this feature");
        }
    }
}
