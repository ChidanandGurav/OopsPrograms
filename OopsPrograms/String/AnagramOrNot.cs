using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String
{
    //15.	Write a C# program to check whether two strings are anagram or not?
    public class AnagramOrNot
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string str1 = Console.ReadLine();

            str = str.ToLower();
            str1= str1.ToLower();

            char[] ch = str.ToCharArray();
            char[] ch1 = str1.ToCharArray();

            /*Array.Sort(ch);
            Array.Sort(ch1);*/

            string str2 = new string(ch);
            string str3 = new string(ch1);

                if (str2==str3)
                {
                   Console.WriteLine("String is Anagram");
                }
                else
                {
                   Console.WriteLine("String is not Anagram");
                }
        }
    }
}
