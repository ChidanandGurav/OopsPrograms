using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String
{
    public class STR
    {
        static void Main(string[] args)
        {
            string massege = "Hello to all";
            string massege1 = "Good Morning";
            Console.WriteLine(massege1.GetHashCode());

            massege = massege + " " +" Have a Good Day ";
            Console.WriteLine(massege);

            string str = string.Concat(massege.Trim( ), " " ,massege1.Trim());
            Console.WriteLine(str);

            Console.WriteLine(massege.ToLower());
            Console.WriteLine(massege1.ToUpper());
            Console.WriteLine("Index of :" + massege1.IndexOf('o'));

            // convert string to string array
            string[] str1 = massege.Split(' ');
            // convert string to char array
            char[] ch = massege.ToCharArray();
            // convert char array to a string
            string str2 = new string(ch);
            Console.WriteLine(str2);

            foreach (char c in ch)
            {
                Console.WriteLine(c);
            }


            for (int i = 0; i < massege1.Length; i++)
            {
                Console.WriteLine(massege1[i]);
            }




        }
    }
}
