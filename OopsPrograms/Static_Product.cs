using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class Static_Product
    {
        static void Main(string[] args)
        {
            Product.GetProduct_Details();
            Product.Discount();
        }

        public static class Product //class
        {
            public static int Prod_Id;
            public static string Prod_Name; //veriable
            public static double Prod_Price;

            static Product() // Constructor
            {
                Prod_Id = 1;
                Prod_Name = "Fan";
                Prod_Price = 1200;
            }

            public static void Discount()
            {
                double Discount_Amt = Prod_Price * 50 / 100;
                Console.WriteLine(Discount_Amt);
                Console.WriteLine(Prod_Price - Discount_Amt);
            }

            public static void GetProduct_Details() // method
            {
                Console.WriteLine($"Product Id = {Prod_Id} , Product Name={Prod_Name} , Price = {Prod_Price}");
            }
        }
    }
}
