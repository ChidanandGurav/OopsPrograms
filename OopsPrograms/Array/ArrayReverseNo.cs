using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 12.	WAP to reverse the array itself, don’t print array in reverse – I want current array reverse. 
Means e.g. arr[] = [3, 90, 45, 29, 37, 78]
so your same array must be [78, 37, 29, 45, 90, 3] without using temporary array.
 */

namespace Array
{
    public class ReverseNumber
    {
        public static void ReverseArray(int[] array)
        {

            int last = array.Length - 1;
            for (int i = 0; i < array.Length / 2; i++)
            {


                int temp = array[i];
                array[i] = array[last];
                array[last] = temp;
                last--;


            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }


        }

        public static void Main(string[] args)
        {


             int[] array = new int[] { 3, 90, 45, 29, 37, 78 };
             ReverseArray(array);
        }
    }
}