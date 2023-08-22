using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class Date
    {
        // Member of a class
        // Decleration of data member

        private int day, year;
        private string month;
        public void AcceptDate(int dd, string mm, int yy)//dd,mm,yy can be accessible in the method

        {
            day = dd;
            month = mm;
            year = yy;
        }
        public string PrintDate()
        {
            return $"Date: {day} / {month} / {year}";
        }


    }
}
