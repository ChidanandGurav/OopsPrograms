using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Array
{
    internal class CountNagativeNo
    {

        //  WAP to print all negative elements in an array and also count the total number of negative elements in an array.
        static void Main(string[] args)
        {
            int count = 0;
            int[] Nag_No = new int[10];

            for (int i = 0; i < Nag_No.Length; i++)
            {

                Console.WriteLine($"Enter the Value at {i}");
                Nag_No[i] = Convert.ToInt32(Console.ReadLine());

            }

            for(int i = 0; i<Nag_No.Length; i++)
            {
                if (Nag_No[i] < 0)
                {
                    count++;
                    Console.WriteLine(Nag_No[i]);
                }
            }
            Console.WriteLine("Total No = "+count);
        }
    }
}
