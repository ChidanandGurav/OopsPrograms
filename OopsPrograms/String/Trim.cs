using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String
{
    //4.	Write a C# program to trim leading white space characters in a string.
    internal class Trim
    {
        static void Main(string[] args)
        {
            string str = "  Chidanand Gurav  ";
            Console.WriteLine(str);
            Console.WriteLine(str.Trim());
        }
    }
}
