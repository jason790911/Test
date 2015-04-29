using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStudentInfo();
            GetTeacherInfo();
        }
        static void GetStudentInfo()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthday");
            string birthday = Console.ReadLine();
            PrintStudentDetails(firstName, lastName, birthday);
        }
        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }
        static void GetTeacherInfo() {
            Console.WriteLine("Enter the teacher's name: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the student's field");
            string field = Console.ReadLine();
            PrintStudentDetails(Name,field);
        }
        static void PrintStudentDetails(string Name,string field) {
            Console.WriteLine("Prof. {1} is good at {0}",field,Name);
        }
    }
}
