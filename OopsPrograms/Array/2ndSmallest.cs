using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Array
{
    public class _2ndSmallest
    {
        //8.	WAP to find the second smallest element in an array.
        static void Main(string[] args)
        {
            int[] num = new int[5];

            
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("Enter five numbers:");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            int  small = int.MaxValue;
            int small2 = int.MaxValue;
            for(int i = 0; i <num.Length; i++)
            {
                if (num[i] < small)
                {
                    small2 = small;
                    small = num[i];
                }
               
                if (num[i] > small && num[i]< small2)
                {
                    small2 = num[i];    
                }
            }

            Console.WriteLine($"Second Smallest Elements {small2}");
        }
    }
}
