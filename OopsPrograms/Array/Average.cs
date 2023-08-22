using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Array
{

    //  * Write two methods that return the average of an array with following headers.
    //  i. 	 public static int average(int[] array)
    //  ii.  public static double average(double[] array).
    //  iii. Write main and invoke the 2 methods.

    internal class Average
    {
        static void Main(string[] args)
        {

            int[] array1 = new int[5];
            Console.WriteLine(Average1(array1));
            double[] array2 = new double[3];
            Console.WriteLine(Average1(array2));

        }
        
        public static int Average1(int[] array)
        {
            int count = 0;
            int sum = 0;
            int avg;

            for(int i = 0; i<array.Length; i++)
            {
                Console.WriteLine("Enter NUmber");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0;  i<array.Length; i++)
            {
                sum = sum + array[i];
                count++;
            }
            avg = sum / count;
            return avg;
        }

        public static double Average1(double[] array)
        {
            int count= 0;
            double sum = 0;
            double avg;
            for(int i=0; i<array.Length; i++)
            {
                Console.WriteLine("ENter Number");
                array[i]= Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                sum = (double)sum + array[i];
                count++;
            }
            avg = (double)sum / count;
            return avg;
        }

    }
}
