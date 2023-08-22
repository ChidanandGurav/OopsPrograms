using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Array
{
    public class AsendingOrder
    {
        static void Main(string[] args)
        {
            int[] asc = { 50, 60, 90, 70, 80 };

           // Asending Order

            for (int i = 0; i < asc.Length; i++)
            {
                for(int j = 0; j<asc.Length; j++)
                {
                    if (asc[i] < asc[j])
                    {
                        int temp = asc[i];
                        asc[i] = asc[j];
                        asc[j] = temp;
                    }
                }
            }

            foreach(int Ans in asc)
            {
                Console.WriteLine($"Asending : {Ans}");
            }
            

            //Desending order
            for (int i = 0; i < asc.Length; i++)
            {
                for (int j = 0; j < asc.Length; j++)
                {
                    if (asc[i] > asc[j])
                    {
                        int temp = asc[i];
                        asc[i] = asc[j];
                        asc[j] = temp;
                    }
                }
            }

            foreach (int Ans in asc)
            {
                Console.WriteLine($"Desending : {Ans}");
            }
        }
    }
}
