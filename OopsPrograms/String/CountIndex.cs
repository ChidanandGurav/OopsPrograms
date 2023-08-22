using OopsPrograms.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String
{
    internal class CountIndex
    { 
        //3.	Write a C# program to count occurrences of a character in given string.
        static void Main(string[] args)
        {
            string str = "Chidanand";
            Console.WriteLine("Index of a :"+str.IndexOf('a'));

            char[] a = str.ToCharArray();
            int cnt = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 'a')
                {
                    cnt++;
                }
            }
            Console.WriteLine($"Occurance of a={cnt}");

        }
    }
}
