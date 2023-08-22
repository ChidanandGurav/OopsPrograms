using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String
{

    //2.	Write a C# program to find first occurrence of a character in a given string.
    internal class Index
    {
        static void Main(string[] args)
        {
            string str = "Chidanand";
            Console.WriteLine(str);
            Console.WriteLine("Index of d ;" + str.IndexOf('d'));
        }
    }
}
