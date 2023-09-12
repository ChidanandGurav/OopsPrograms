using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String
{

    //11.	Write a C# program to find highest frequency character in a string.
    public class Frequency
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();

            string[] array= str.Split(' ');
            int count = 0;
            string str1="";
            int max=0;
            for(int i=0;i<array.Length;i++)
            {
                count = array[i].Length;
                if(count>max)
                {
                    max = count;
                    str1 = array[i];
                }
            
            }
            Console.WriteLine($"Count:{max}{str1}");

        }
    }
}
