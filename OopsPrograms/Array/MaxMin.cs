using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Array
{
    public class MaxMin
    {

       // WAP to find the maximum and minimum value in an array.

        static void Main(string[] args)
        {
            int[] num = new int[10];
            int max = 0;
            int min = 0;
            for (int i = 1; i < num.Length; i++)
            {
                Console.WriteLine("Enter Numbers");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            max = num[0];
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > max)
                {
                    max = num[i];
                }
            }
            Console.WriteLine(max);

            min = num[0];
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] <  min)
                {
                    min = num[i];
                }
            }
            Console.WriteLine(min);
        }
    }
}
