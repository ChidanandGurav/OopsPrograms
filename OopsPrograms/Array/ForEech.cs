using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Array
{
    public class ForEech
    {
        static void Main(string[] args)
        { 
            //1D
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (var a in arr)
            {
                Console.WriteLine(a);
            }

            //2D
            int[,] Arra = new int[4, 5]
            {
                {10,20,30,40,50},
                {60,70,80,90,100},
                {110,120,130,140,150},
                {160,170,180,190,200}
            };

            foreach (var name in Arra)
            {
                Console.WriteLine(name);
            }

            //Name
            string[] Name = { "Ram", "Lucky","Om","Sham","Shubham" };

            foreach(var nam in Name)
            {
                Console.WriteLine(nam);
            }
        }
    }
}
