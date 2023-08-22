using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Array
{
    public class JaggedArray2
    {
        static void Main(string[] args)
        {
            int[][] jarr = new int[4][];

            jarr[0] = new int[4];
            jarr[1] = new int[3];
            jarr[2] = new int[2];
            jarr[3] = new int[1];
            Console.WriteLine("enter array elements");

            for (int row = 0; row < jarr.Length; row++)
            {
                for (int col = 0; col < jarr[row].Length; col++)
                {
                    jarr[row][col] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("\n");
            }
           /* for (int row = 0; row < jarr.Length; row++)
            {
                for (int col = 0; col < jarr[row].Length; col++)
                {
                    Console.WriteLine("elements in jagged array:" + jarr[row][col]);
                }
            }*/

        }
    }
}
