using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3_C
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStudentInfo();
        }
        static void GetStudentInfo()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthday");
            string birthday = Console.ReadLine();
            switch (validDate(ref birthday))
            {
                case 1:
                    Console.WriteLine("OK!You are older than 18!");
                    PrintStudentDetails(firstName, lastName, birthday);
                    break;
                case 0:
                    Console.WriteLine("You have an error birthday less than 18-year-old!");
                    break;
            }
        }
        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
            GetTeacherInfo();
        }
        static void GetTeacherInfo()
        {
            Console.WriteLine("Enter the teacher's name: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the student's field");
            string field = Console.ReadLine();
            PrintStudentDetails(Name, field);
        }
        static void PrintStudentDetails(string Name, string field)
        {
            Console.WriteLine("Prof. {1} is good at {0}", field, Name);
        }
        static int validDate(ref string birthday)
        {
            try
            {
                DateTime dt = Convert.ToDateTime(birthday);
                DateTime now = DateTime.Now;
                if(dt.AddYears(18)<=now) return 1;
                return 0;
            }
            catch (FormatException e) {
                Console.WriteLine("Error Format about birthday!!");
                Console.WriteLine("Re-enter the student's birthday");
                birthday = Console.ReadLine();
                return validDate(ref birthday);
            }
        }
    }
}
