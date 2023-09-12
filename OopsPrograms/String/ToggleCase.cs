using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String
{
    public class ToggleCase
    {

        //7.	Write a C# program to toggle case of each character of a string.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str = Convert.ToString(Console.ReadLine());

            char[] ch = str.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] >= 'A' && ch[i] <= 'Z')
                {
                    ch[i] = (char)(ch[i] + 32);
                    Console.WriteLine(ch[i]);
                }
                else if (ch[i] >= 'a' && ch[i] <= 'z')
                {
                    ch[i] = (char)(ch[i] - 32);
                    Console.WriteLine(ch[i]);
                }
            }
           

        }
    }
}
