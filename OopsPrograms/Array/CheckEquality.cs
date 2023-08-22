using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Array
{
    public class CheckEquality
    {
        public static void CheckEuqalarray(int[] array1, int[] array2)
        {

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = i + 1; j < array1.Length; j++)
                {
                    int temp;
                    temp = array1[i];
                    array1[i] = array1[j];
                    array1[j] = temp;
                }
            }


            for (int i = 0; i < array2.Length; i++)
            {
                for (int j = i + 1; j < array2.Length; j++)
                {
                    int temp;
                    temp = array2[i];
                    array2[i] = array2[j];
                    array2[j] = temp;
                }
            }
            bool flag = false;
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        flag = true;
                    }
                }
            }

            if (flag)
            {
                Console.WriteLine("Equal!!!");
            }




        }

        public static void Main(string[] args)
        {
            int[] array1 = new int[] { 12, 22, 32, 42, 52, 62 };
            int[] array2 = new int[] { 52, 22, 62, 12, 42, 22 };
            CheckEuqalarray(array1, array2);
        }
    }
}
