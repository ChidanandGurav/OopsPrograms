using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Array

    // Declare an array of size 10 Accept the value and print only even numbers.
{
    internal class ArrayEvenNoPrint
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];

            Console.WriteLine("Enter Numbers");

            for(int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Print Even Numbers");

            for (int i = 0; i < num.Length;i++)

                if(num[i] % 2 == 0)
                {
                    Console.WriteLine($"Even No. is = {num[i]}");
                }

            Console.WriteLine("Print Odd Numbers");

            for (int i = 0; i < num.Length; i++)

                if (num[i] % 2 != 0)
                {
                    Console.WriteLine($"Odd No. is = {num[i]}");
                }


        }
    }
}
