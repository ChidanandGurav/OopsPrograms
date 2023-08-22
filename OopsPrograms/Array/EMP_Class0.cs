using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Array
{
    public class Employee
    {
        public int Emp_Id { get; set; }
        public string Emp_Name { get; set; }
        public double Salary { get; set; }
    }
    public class EMP_Class0
    {
        static void Main(string[] args)
        {
           Employee[] List = new Employee[3]
           {
             new Employee{Emp_Id = 1, Emp_Name = "Om", Salary = 25000},
             new Employee{Emp_Id = 2, Emp_Name = "Ram", Salary = 20000},
             new Employee{Emp_Id = 3, Emp_Name = "Lucky", Salary = 12000}
           };

            foreach(Employee E in List)
            {
                Console.WriteLine($"{E.Emp_Id} {E.Emp_Name} {E.Salary}");
            }
        }
    }
}
