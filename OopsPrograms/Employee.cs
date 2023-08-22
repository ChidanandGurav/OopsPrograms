using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class Employee
    {
        protected int Emp_id, Age;
        protected string Name;
        protected double Salary, hra, da, ta, pf, gross;
        private static int count;

        //Constructor

        public Employee() // parameter less Constructor
        {
            // assign default value
            Emp_id = 0;
            Name = "";
            Age = 0;
            Salary = 0.0;
        }

        public Employee( string Name , int Age , Double Salary) // parametric Constructor
        {
            count++;  // Static Variable
            this.Emp_id = count;
            this.Name = Name;
            this.Age = Age;
            this.Salary = Salary;
        }
        public static int GetempCount() // Static Method
        {
            return count;
        }

        public void AcceptEmployee(int id, string name, int ag, double salary)
        {
            Emp_id = id;
            Name = name;
            Age = ag;
            Salary = salary;
        }
        public string PrintEmployee()
        {
            return $" Employee : {Emp_id} / {Name} / {Age} / {Salary}";
        }

        public virtual void CalculatSalary()
        {
            hra = Salary * 0.40;
            da = Salary * 0.20;
            ta = Salary * 0.10;
            pf = Salary * 0.12;
            gross = (Salary + hra + da + ta) - pf;
        }
        public virtual string Print()
        {
            return $"Emp_id = {Emp_id} , Name = {Name} , Basic Salary = {Salary} , gross = {gross}";
        }
    }

    public class Manager : Employee
    {
        private double Foodallownce;

        public Manager(double foodallownce , string Name, int Age, Double Salary) :base(Name , Age , Salary)
        {
            Foodallownce = foodallownce;
        }

        public override void CalculatSalary()
        {
            hra = Salary * 0.40;
            da = Salary * 0.20;
            ta = Salary * 0.10;
            pf = Salary * 0.12;
            gross = (Salary + hra + da + ta + Foodallownce) - pf;
        }

        public override string Print()
        {
            return $" Name = {Name} , Age = {Age} , Basic Salary = {Salary} , Gross Salary = {gross}";
        }
    }
}

