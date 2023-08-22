using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String
{
    //5.	Write a C# program to count total number of words in a string. 
    internal class Totalcountofword
    {
        //5.	Write a C# program to count total number of words in a string. 
        static void Main(string[] args)
        {
            string str = "Good Morning Have a nice Day";
            Console.WriteLine(str);

            string[] str1 = str.Split(' ');
            char[] ch = str.ToCharArray();

            int count = 0;

            for (int i = 0; i<str1.Length; i++)
            {
                count++;
            }

            Console.WriteLine("Total Word of Count :"+count);
        }
    }
}
