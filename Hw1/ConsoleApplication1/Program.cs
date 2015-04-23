using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *In this program,we need to know how to assign the fixed value to the variable and ask user to type the
 *data into the variable;otherwise,we have to change the string to the data type which the variable requires.
 *--------By Wolf Wang
 */
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int once=0;
            while (once == 0)
            {
                int age = 0, creditsRequired = 128;
                string firstName, lastName, addressLine1, addressLine2, city, state, country, zip, fieldOfProfessor = "Arts";
                string degreeName = "Computer Science Engineering";
                DateTime birthDate;
                Console.WriteLine("---Please Input your data on the following fields---");
                Console.Write("First name:");
                firstName = Console.ReadLine();
                Console.Write("Last name:");
                lastName = Console.ReadLine();
                Console.Write("Age:");
                try
                {
                    age = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please type the input with integer.\n");
                    continue;
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("The integer you type is too big!\n");
                    continue;
                }
                Console.Write("Birthday(mm/dd/yyyy):");
                birthDate = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Address 1:");
                addressLine1 = Console.ReadLine();
                Console.Write("Address 2:");
                addressLine2 = Console.ReadLine();
                Console.Write("City:");
                city = Console.ReadLine();
                Console.Write("State:");
                state = Console.ReadLine();
                Console.Write("Country:");
                country = Console.ReadLine();
                Console.Write("Zip:");
                zip = Console.ReadLine(); ;
                Console.WriteLine("\n");
                Console.WriteLine("-------------Strudent Information-------------");
                Console.WriteLine("Degree name: " + degreeName + "\tCredits required: " + creditsRequired);
                Console.WriteLine("Name: " + firstName + " " + lastName);
                Console.WriteLine("Birthday: " + birthDate.Year + "年" + birthDate.Month + "月" + birthDate.Day + "日\tAge: " + age);
                Console.WriteLine("Field of Professor: " + fieldOfProfessor);
                Console.WriteLine("Address: " + addressLine1 + "," + addressLine2 + "," + city + "," + state + "," + country);
                Console.WriteLine("Zip: " + zip);
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadLine();
                ++once;
            }
        }
    }
}
