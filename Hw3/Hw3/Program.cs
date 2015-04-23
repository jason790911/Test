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
            int first;
            string sValue;
            ReturnMultiOut(out first, out sValue);
            Console.WriteLine("{0}, {1}", first.ToString(), sValue);

        
        }
        static void ReturnMultiOut(out int i, out string s)
        {
            i = 25;
            s = "using out";
        }
    }
}
