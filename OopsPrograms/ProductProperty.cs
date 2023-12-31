﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class ProductProperty
    {
        private int code;
        private string name;
        private Double price;

        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        public string Name
        { get { return name; } 
            set { name = value; }
        }
        public Double Price
        { 
            get { return price; }
            set { price = value; }
        }

        public string Print()
        {
            return $"Product {code} , {name} , {price}";
        }
    }
}
