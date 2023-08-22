using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class DefaultOptional_Car
    {
        private string modelname , companyname;
        private int cost;

        public DefaultOptional_Car(string modelname, int cost , string companyname = "Hundai")
        {
            this.modelname = modelname;
            this.companyname = companyname;
            this.cost = cost;
        }

        public string Print()
        {
            return $" {modelname} , {cost} , {companyname}";
        }
    }
}
