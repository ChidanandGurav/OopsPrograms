using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Exception_Handling
{
    public class NameException : Exception
    {

        public NameException(string error) : base (error)
        {
           
        }

    }

    public class Student
    {
        public Student(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new NameException("Cannot print the name");
            }
            else
            {
                Console.WriteLine(name);
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student st = new Student("Om");
            }
            catch (NameException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
