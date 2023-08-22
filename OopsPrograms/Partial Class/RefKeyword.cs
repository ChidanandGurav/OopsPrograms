using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Partial_Class
{
    public class RefKeyword
    {
        static void Swap(ref int a , ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int a = 50, b = 100;
            Swap(ref a, ref b);
            Console.WriteLine($"a = {a} , b = {b}");

        }
    }
}
