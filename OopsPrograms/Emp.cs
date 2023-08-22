using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    //use of base keyword in single code

    public class Emp
    {
        protected int id;
        protected string name;
        protected double Salary;

        public Emp(int id, string name, double Salary)
        {
            this.id = id;
            this.name = name;
            this.Salary = Salary;

        }

        public virtual string Print()
        {
            return $"Id = {id} , Name = {name} , Salary = {Salary}";
        }
    }

    public class Man : Emp
    { 

        public Man( int id, string name, double Salary) :base (id , name , Salary)
        {
          this.id = id;
          this.name = name;
          this.Salary = Salary;
        }

        public override string Print()
        {
           return base.Print();
        }
    }
}
