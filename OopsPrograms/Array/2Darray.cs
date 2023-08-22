using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Array
{
    public class _2Darray
    {
        static void Main(string[] args)
        {
            //Initialize

            int[,] Arra = new int[4, 5]
            {
                {10,20,30,40,50},
                {60,70,80,90,100},
                {110,120,130,140,150},
                {160,170,180,190,200}
            };

            // nested for loop to display the 2D array

            for(int row = 0; row < Arra.GetLength(0); row++) //Row-->0
            {
                for(int col = 0; col < Arra.GetLength(1); col++) //Column-->1
                {
                    Console.Write($"Arr[{row},{col}] = {Arra[row,col]} ");
                }

                Console.WriteLine("\n");
            }

        }
    }
}
