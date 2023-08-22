using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class Product
    {
        private int id;
        private string Prodname;
        private double price;

        public Product(int id, string prodname, double price)
        {
            this.id = id;
            Prodname = prodname;
            this.price = price;
        }

        public string Discount(int disamt)
        {
            price = price- ((price / 100 ) * disamt);
            return $" Product id = {id} / Product Name = {Prodname} / Price = {price}";
        }
    }
}
