using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Array
{
    public class Product
    {
        public int id { get; set; }

        public string name { get; set; }

        public double price { get; set; }
    }
    public class Prod_Class2
    {
        static void Main(string[] args)
        {
            Product[] prd = new Product[2]
            {
                new Product { id = 1, name = "Pen", price = 20.5 },
                new Product { id = 2, name = "NoteBook", price = 148 }
            };

            foreach(Product P in prd)
            {
                Console.WriteLine($" Id = {P.id} , Name = {P.name} , Price = {P.price}");
            }
        }
    }
}
