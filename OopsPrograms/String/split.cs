using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String
{
    //1.	WAP to split string into 2 tokens where string is “HELLO$WORLD”
    internal class split
    {
        static void Main(string[] args)
        {
            string Message = "HELLO$WORLD";
            Console.WriteLine(Message);
            for (int i = 0; i < Message.Length; i++)
            {
                Console.WriteLine(Message[i]);
            }

            string[] str = Message.Split('$');
            Console.WriteLine(str[0]);
            Console.WriteLine(str[1]);

        }
    }
}
