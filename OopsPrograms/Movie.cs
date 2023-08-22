using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class Movie
    {
        private int mid;
        private string mname;
        private double tprice;
        private string type;
        private int noofticket = 15;
        private int avilable_tic;
        private double totalcost;
        private int num;

        public Movie(int mid, string mname, double tprice, int noofticket)
        {
            this.mid = mid;
            this.mname = mname;
            this.tprice = tprice;
            this.noofticket = noofticket;
        }

        public void Dispaly()
        {
            Console.WriteLine(mid + " ", mname + " " + tprice + " " + noofticket);
        }
        public void FindAvailable()
        {
            Console.WriteLine("Enter No Of Ticket to Book");
            num = int.Parse(Console.ReadLine());

            if (noofticket > num)
            {
                avilable_tic = noofticket - num;

                this.ticcost();

            }
            else
            {
                Console.WriteLine("Insfficient Ticket");
            }
        }
        public void ticcost()
        {
            Console.WriteLine("1.Silver");
            Console.WriteLine("2.Gold");
            Console.WriteLine("3.Platinum");
            Console.WriteLine("Enter Type");

            int Choice = int.Parse(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    type = "Silver";
                    tprice = 100;
                    break;
                case 2:
                    type = "Gold";
                    tprice = 200;
                    break;
                case 3:
                    type = "Platinum";
                    tprice = 300;
                    break;

            }

        }

        public void Details()
        {
            totalcost = num * tprice;
            Console.WriteLine("Movie Name" + mname + "Type" + type + "Booking Ticket" + num + "Total Cost" + totalcost);
        }
    }

}
