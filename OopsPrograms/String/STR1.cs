using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String
{
    public class STR1
    {
        static void Main(string[] args)
        {
            string str = null;
            /*string str1 = "";*/

            if(string.IsNullOrEmpty(str))
            {
                Console.WriteLine("String is Empty");
            }

            Console.WriteLine("str");

            Console.WriteLine("Enter a Name");
            string name = Console.ReadLine();
            if(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name is Required");
            }
            else
            {
                Console.WriteLine("Hello " + name);
            }
        }
    }
}
