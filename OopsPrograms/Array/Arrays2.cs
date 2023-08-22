using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Array
{
    internal class _2Arrays
    {  

        //1.WAP to put even and odd elements of array in two separate arrays.

        static void Main(string[] args)
        {

            int[] Num = new int[5];
            int[] even= new int[5];
            int[] odd= new int[5];

            for(int i = 0; i < Num.Length; i++)
            {
                Console.WriteLine("Enter No");
                Num[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i =0; i < Num.Length; i++)
            {
                if (Num[i] % 2 == 0)
                {
                    even[i] = Num[i];
                }
                else
                {
                    odd[i] = Num[i];
                }
            }

            for(int i=0; i<even.Length; i++)
            {
                if (even[i] > 0)
                {
                    Console.WriteLine("Even Number = " + even[i]);
                }
            }

            for(int i = 0; i < odd.Length; i++)
            {
                if (odd[i] > 0)
                {
                    Console.WriteLine("Odd Number = " + odd[i]);
                }
            }

        }
    }
}
