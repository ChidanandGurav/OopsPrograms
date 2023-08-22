using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Array
{
    public class Array_Obj
    {
        static void Main(string[] args)
        {
            Object[] Arr_Obj = new Object[3];
            Arr_Obj[0] = 1;
            Arr_Obj[1] = "Laksh";
            Arr_Obj[2] = 25;

            foreach (var I in Arr_Obj)
            {
                Console.WriteLine(I);
            }
        }
    }
}
