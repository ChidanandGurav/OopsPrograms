using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String
{
    //16.	Write a C# program to reverse a given string with preserving the position of spaces
    public class ReversStr1
    {
        static void Main(string[] args)
        {
            string str1 = "Hello All Good Morning";
            Console.WriteLine("Original string: " + str1);
            string[] str2 = str1.Split();
            string str3 = " ";

            for (int i = str2.Length - 1; i >= 0; i--)
            {

                str3 = str3 + " " + str2[i];

            }
            Console.WriteLine(" ");
            Console.WriteLine("string after reverse world: " + str3);


        }
    }
}
