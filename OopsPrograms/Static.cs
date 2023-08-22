using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class Static
    {
        static void Main(string[] args)
        {
            Student.Display();
        }

        public static class Student // class 
        {
            static int id;
            static string name; // veriable
            static double per;

            static Student() // Constructor
            {
                id = 1;
                name = "Rushi";
                per = 85.3;
            }

            public static void Display() // method
            {
                Console.WriteLine($"Id = {id} , Name={name} , Percentage = {per}");
            }



        }
    }
}
