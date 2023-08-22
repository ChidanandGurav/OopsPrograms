using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Array
{
    public class _2DarrayUser
    {
        //Input from user

        static void Main(string[] args)
        {
            int[,] array = new int[4,5];

            //accept 2D data from user
         for(int row = 0; row< array.GetLength(0); row++)
            {
                for(int col = 0; col< array.GetLength(1); col++)
                {
                    Console.WriteLine("Enter No.");
                    array[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // nested for loop to display the 2D array

            for (int row = 0; row < array.GetLength(0); row++) //Row-->0
            {
                for (int col = 0; col < array.GetLength(1); col++) //Column-->1
                {
                    Console.Write($"Arr[{row},{col}] = {array[row, col]} ");
                }

                Console.WriteLine("\n");
            }
        }
    }
}
