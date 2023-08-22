using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Enum
{

    public enum Department { HR = 1 , Admin , Sales , Marketing , Develop , Testing}

    public enum Designation { Engg = 101 , SrEngg , Trainee , Employee , Manager , CEO}
    public class EnumEmp
    {
        private int id;
        private string name;
        private Department Department;
        private Designation Designation;

        public EnumEmp(int id, string name, Department department, Designation designation)
        {
            this.id = id;
            this.name = name;
            Department = department;
            Designation = designation;
        }

        public override string ToString()
        {
            return $"Id = {id} , Name = {name} , Department = {Department} , Designation = {Designation}";
        }
    }

    public class Emp
    {
        static void Main(string[] args)
        {
            EnumEmp e1 = new EnumEmp (1,"Omakr",Department.Admin,Designation.Engg);
            Console.WriteLine(e1);

            EnumEmp e2 = new EnumEmp(2, "Lucky", Department.Develop, Designation.Trainee);
            Console.WriteLine(e2.ToString());
        }
    }
}
