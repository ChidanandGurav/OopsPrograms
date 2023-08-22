using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Partial_Class
{

    //Developer 2

    public partial class Calc
    {
        public int Square(int a)
        {
            Squareroot(a);
            return a * a;
        }

        partial void Squareroot(int a)
        {
            Console.WriteLine("SquareRoot is :" +Math.Sqrt(a));
        }

    }
}
