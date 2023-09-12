using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String
{
    public class DuplicateWord
    {
        //14.	Write a C# program to find the duplicate words and their number of occurrences in a string
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string str = Convert.ToString(Console.ReadLine());
            string[] st = str.Split();

            for(int i = 0; i < st.Length; i++)
            {
                for(int j = i+1; j<str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        Console.WriteLine(str[i]);
                    }
                }
            }
        }
    }
}
