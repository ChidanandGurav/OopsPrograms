using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Array
{
    // 14.	WAP to replace all negative value with its immediate left elements square.
    // Means arr[] = [12, 3, -19, 29, 5, -61, 44, 7, -9] Output array will be[12, 3, 9, 29, 5, 25, 44, 7, 49].

    public class ReplaceNagativewithSquare
    {
        public static void NagativeSqure(int[]Array)
        {
            int temp = Array[1];
            if (Array[0] < 0)
            {
                Array[0]= Array[Array.Length - 1] * Array[Array.Length - 1];

            }
            for(int i = 0; i <Array.Length; i++)
            {
                if (Array[i] < 0)
                {
                    Array[i] = temp * temp;
                    temp = Array[i];
                }
                else
                {
                    temp = Array[i];
                }
            }
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }

        }

        public static void Main(string[] args)
        {
            int[] Array = new int[] { 12, 3, -19, 29, 5, -61, 44, 7, -9 };
            NagativeSqure(Array);

            /*int[] Array1 = new int[] { -12, 3, -19, 29, -5, 61, 44, -7, 9 };
            NagativeSqure(Array1);*/

        }
    }
}
