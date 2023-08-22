using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Array
{
    public class ArrangePositiveNagetive
    {

        //15.	WAP to arrange the elements of an given array of integers
        //where all negative integers appear before all the positive integers

        public static void ArrangeElementes(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > 0)
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static void Main(string[] args)
        {
            int[] array = new int[] { -1, 2, -3, -4, -5, 6, 7 };
            ArrangeElementes(array);

        }
    }
}
