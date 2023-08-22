using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class Account
    {
        private int Acc_No;
        private string Acc_Type;
        private double Balance;

        public void AcceptAccount(int Acc_No, string Acc_Type, double Balance)
        {
            this.Acc_No = Acc_No;
            this.Acc_Type = Acc_Type;
            this.Balance = Balance;
        }
        public string show()
        {
            return $"Account Number = {Acc_No} / Account Type = {Acc_Type} / Balance = {Balance}";
        }
        public void Withdrow()
        {
            Console.WriteLine("Enter Ammount to Withdrow");
            int Wi_Amt = Convert.ToInt32(Console.ReadLine());

            if (Wi_Amt < Balance)
            {
                 Balance = Balance - Wi_Amt;
                Console.WriteLine("Current Bal : " + Balance);
            }
            else
                Console.WriteLine("No Balance");
                 
            
        }
        public void Diposite()
        {
            Console.WriteLine("Enter Diposite Amount");
            Double Dis_Amt = Convert.ToInt32(Console.ReadLine());

            if (Dis_Amt > 0)
            {
                Balance = Balance + Dis_Amt;
                Console.WriteLine(Balance);
            }
        }
    }
}
