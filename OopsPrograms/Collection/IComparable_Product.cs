using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Collection
{
    public class IComparable_Product
    {
        static void Main(string[] args)
        {
            Product pen = new Product("Pen", 20);
            Product Book = new Product("Book", 50);

            int result = pen.CompareTo(Book);
            if(result == 1)
            {
                Console.WriteLine("Pen price is more runs than Book");
            }
            else if(result == -1)
            {
                Console.WriteLine("Pen price is less runs than Book");
            }
            else
            {
                Console.WriteLine("Pen and Book are Equal");
            }
        }
    }

//_______________________________________________________________________________________________________________________________

    public class Product: IComparable
    {
        private string Prod_Name;
        private int Prod_Price;

        public Product(string prod_Name, int prod_Price)
        {
            Prod_Name = prod_Name;
            Prod_Price = prod_Price;
        }

        public int CompareTo(object obj)
        {
            // convert object to Product class
            Product P = (Product)obj;

            if(this.Prod_Price > P.Prod_Price)
            {
                return 1;
            }
            else if (this.Prod_Price < P.Prod_Price)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }

        public override string ToString()
        {
            return $"{Prod_Price} --> {Prod_Name}";
        }
    }
}
