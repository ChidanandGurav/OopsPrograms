using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String
{
    public class Reverse
    {
        static void Main(string[]args)
        {
            string str = "India is the best";

            char[] ch = str.ToCharArray();

            for (int i = ch.Length - 1; i >= 0; i--)
            {
                Console.Write(ch[i]);
            }
            Console.WriteLine();


        }
    }
}
