using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Array
{
    internal class Array
    {
        static void Main(string[] args)
        {
            int[] RainFalls = new int[7];
             
            for (int i = 0; i < RainFalls.Length; i++ )
            {
                RainFalls[i]=Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Print All value");

            for (int i = 0; i < RainFalls.Length; i++ )
            {
                Console.WriteLine($"Rainfalls[{i}] = {RainFalls[i]}");
            }
        }
    }
}
