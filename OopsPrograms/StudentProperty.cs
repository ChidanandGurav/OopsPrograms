using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class StudentProperty
    {
        private int rollno;
        private string name;
        private Double percentage;

        public int RollNo // Property 
        {
            get { return rollno; }
            set { rollno = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Double Percentage
        {
            get { return percentage; }
            set { percentage = value; }
        }

        // Auto Implemented Property (OR)

       // public int RollNo { get; set; }

       // public string Name { get; set; }

       // public Double Percentage { get; set; }

        public string Print()
        {
            return $"Student {rollno} , {name} , {percentage}";
        }
    }
}
