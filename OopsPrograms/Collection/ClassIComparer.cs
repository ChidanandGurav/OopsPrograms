using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Collection
{
    public class ClassIComparer
    {
        static void Main(string[] args)
        {
            Product1 P1 = new Product1("Pen", 20);
            Product1 P2 = new Product1("Book", 20);

            CheckPrice c = new CheckPrice();
            int result = c.Compare(P1, P2);

            if (result == 1)
            {
                Console.WriteLine("Pen price is more runs than Book");
            }
            else if (result == -1)
            {
                Console.WriteLine("Pen price is less runs than Book");
            }
            else
            {
                Console.WriteLine("Pen and Book are Equal");
            }

        }
    }

    public class Product1
    {
        private string Prod_Name;
        private int Prod_Price;

        public Product1(string prod_Name, int prod_Price)
        {
            Prod_Name = prod_Name;
            Prod_Price = prod_Price;
        }

        public int Prod_Prices
        {
            get { return Prod_Price; }
        }

        public override string ToString()
        {
            return $"{Prod_Name} {Prod_Price}";
        }
    }

    public class CheckPrice : IComparer
    {
        public int Compare(object x, object y)
        {
            Product1 P1 = (Product1)x;
            Product1 P2 = (Product1)y;

            if(P1.Prod_Prices > P2.Prod_Prices)
            {
                return 1;
            }
            else if (P1.Prod_Prices < P2.Prod_Prices)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
