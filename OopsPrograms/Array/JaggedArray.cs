using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Array
{
    public class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] Jarr = new int[4][];

            Jarr[0] = new int[] { 1, 2, 3,4,5 };
            Jarr[1] = new int[] { 6, 7, 8, 9 };
            Jarr[2] = new int[] { 10, 11 };
            Jarr[3] = new int[] { 12 };

            // OR
            //jarray[0] = new int[5] ;
            //jarray[1] = new int[3] ;
            //jarray[2] = new int[2] ;
            //jarray[3] = new int[1] ;

            for (int row = 0; row < Jarr.Length; row++)
            {
                for(int col=0; col < Jarr[row].Length; col++)
                {
                    Console.Write(Jarr[row][col]+" ");
                }

                Console.WriteLine("\n");
            }
        }
    }
}
