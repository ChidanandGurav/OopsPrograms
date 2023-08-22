using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OopsPrograms.Inheritance
{
    public class EmployeeOverriding
    {
        protected int id;
        protected string name;
        protected double salary, hra, da, ta, pf, gross;

        public EmployeeOverriding(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public virtual void Cal_Salary()
        {
            hra = salary * 0.40;
            da = salary * 0.20;
            ta = salary * 0.10;
            pf = salary * 0.12;
            gross = (salary + hra + da + ta) - pf;
        }

        public virtual string Print()
        {
            return $"Emp_id = {id} , Name = {name} , Basic Salary = {salary} , gross = {gross}";
        }
    }

    public class SalesEmployee : EmployeeOverriding
    {
        private double bonus;
        private double Comm;

        public SalesEmployee(int id, string name, double bonus, double Comm , double salary ) : base(id ,name , salary)
        {
            this.bonus = bonus;
            this.Comm = Comm;
        }
        public override void Cal_Salary()
        {
            hra = salary * 0.40;
            da = salary * 0.20;
            ta = salary * 0.10;
            pf = salary * 0.12;
            gross = (salary + hra + da + ta + bonus + Comm) - pf;
        }

        public override string Print()
        {
            return $" SalesEmp =  {id} , {name} , {salary} , {bonus} , {Comm} , {gross}";
        }

    }
}
