using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public interface Iprintable
    {
        void Print(); // by default Public and Abstract
    }

    public class Employee1 : Iprintable
    {
         public void Print()
        {
            Console.WriteLine("employee"); ;
        }
    }
    public class Manager1 : Iprintable
    {
        public void Print()
        {
            Console.WriteLine("manager");
        }
    }
    public class Student1 : Iprintable
    {
         public void Print()
        {
            Console.WriteLine("student");
        }
    }
}
