using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 8; ++i) {
                for (int j = 0; j < 8; ++j) { 
                    Console.Write((i+j)%2==0?"X":"O");
                }
                Console.WriteLine();
            }
            Console.Write("\nPress any key to continue... ");
            Console.ReadLine();
        }
    }
}
