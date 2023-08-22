using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Partial_Class
{
    public partial class Calc
    {
        //Developer 1

        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        partial void Squareroot(int a);

    }
}
