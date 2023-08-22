using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Inheritance
{
    public class Area_Overload
    {
        private double result;
        public void area (double r )
        {
            result = 3.14 * r * r;
        }

        public void area (int side)
        {
            result = side * side;
        }

        public void area (double len , double wid)
        {
            result = len* wid;
        }
        public void area (float  hight  , int bas)
        {
            result = 0.5 * hight * bas;
        }

        public string Display()
        {
            return $"{result}";
        }
    }
}
