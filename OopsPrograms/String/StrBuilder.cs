using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String
{
    public class StrBuilder
    {
        static void Main(string[] args)
        {
            string str = "Hello to all";
            Console.WriteLine(str);
            Console.WriteLine(str.GetHashCode());

            str = str + "Good Morning";
            Console.WriteLine(str);
            Console.WriteLine(str.GetHashCode());

            StringBuilder strB = new StringBuilder("Hello to all");
            Console.WriteLine(strB);

            strB.Append("Good Morning");
            Console.WriteLine(strB);

            /*strB.Remove(2 , 6);
            Console.WriteLine(strB);*/

           /* strB.Replace('l', 'L');
            Console.WriteLine(strB);*/

            strB.Replace("all", "Everyone");
            Console.WriteLine(strB);

            strB.Clear(); // Remove all letter.

            Console.WriteLine("Capacity = " +strB.Capacity);
        }
    }
}
