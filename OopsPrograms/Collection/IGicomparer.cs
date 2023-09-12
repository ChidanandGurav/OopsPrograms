using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Collection
{
    public class IGicomparer
    {
        public class Employee01
        {
            public string Name { get; set; }
            public int Salary { get; set; }
        }

        public class CheckSalary : IComparer<Employee01>
        {
            public int Compare(Employee01 x, Employee01 y) // x=e1 and y=e2
            {
                if(x.Salary < y.Salary)
                {
                    return 1;
                }
                else if (x.Salary > y.Salary)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
        static void Main(string[] args)
        {
            Employee01 e1 = new Employee01 { Name = "Sandesh", Salary = 21000 };
            Employee01 e2 = new Employee01 { Name = "Shubham", Salary = 20000 };

            CheckSalary c = new CheckSalary();
            int result = c.Compare(e1, e2);

            if(result == 1)
            {
                Console.WriteLine("Sandesh salary less than Shubham");
            }
            else if(result == -1)
            {
                Console.WriteLine("Sandesh Salary is Greater than Shubham");
            }
            else
            {
                Console.WriteLine("Sandesh and Shubham  salary is Equal");
            }
        }
    }
}
