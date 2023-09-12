using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String
{

    //9.	Write a C# program to count total number of vowels and consonants in a string.
    public class CntVowelsAndConst
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Alphabates");
            string str = Console.ReadLine();
            int count = 0;
            int count1 = 0;

            char[] ch = str.ToCharArray();
             
            for(int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'a' || ch[i] == 'e' || ch[i] == 'i' || ch[i] == 'o' || ch[i] == 'u')
                {
                     count++;
                }
                else if (ch[i] != ' ')
                {
                     count1++;
                }
            }
            Console.WriteLine("Vowels Count :" + count);
            Console.WriteLine("Consonant Count :" + count1);

        }
    }
}
