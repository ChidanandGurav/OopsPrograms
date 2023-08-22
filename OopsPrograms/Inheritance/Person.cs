using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Inheritance
{
    public class Person
    {
        protected int AdharNo;
        protected string Name;
        protected string Address;

        public Person(int AdharNo, string Name, string address)
        {
            this.AdharNo = AdharNo;
            this.Name = Name;
            Address = address;      
        }

        public virtual string Print()
        {
            return $" {Name} , {AdharNo} , {Address}";
        }
    }

    public class Patient : Person
    {
        private string bloodgrp;
        private double bill;
        public Patient(string bloodprp,double bill, int AdharNo, string Name, string Address) : base(AdharNo, Name, Address)
        {
            this.bloodgrp = bloodprp;
            this.bill = bill;
        }

        public override string Print()
        {
            return $"{bloodgrp} , {AdharNo} , {Name} , {Address} {bill}";
        }
    }
}
