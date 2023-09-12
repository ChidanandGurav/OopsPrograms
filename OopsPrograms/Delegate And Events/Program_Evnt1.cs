using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Delegate_And_Events
{
      /*Assessment on Event & Delegate

    1.Create a Bank a class, with Debit & Credit method
    2.You can assign a default balance using constructor
    3.Credit method will accept the amount that needs to be added in balance
    4.Debit method will accept the amount that needs to be deducted from the balance.
    5.If amount is greater than balance raise an event → insufficient balance
    6.If balance is low (< 3000) raise an event low balance
    7.If balance is zero then raise an event zero balance.
    8.Also use exception handling in the code*/

    public class Program_Evnt1
    {
        static void Main(string[] args)
        {
            try
            {
                bank b = new bank(4000);

                b.Insufficient_Balance += delegate () { Console.WriteLine("Balace is Insufficient"); };
                b.Low_Balance += delegate () { Console.WriteLine("Low Balance"); };
                b.No_Balance += delegate () { Console.WriteLine("Zero Balance"); };

                b.CreditMethod(10000);
                b.DebitMethod(12000);
                b.CheckBalance();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }



    public delegate void Mydeleget();
    public class bank
    {

        public event Mydeleget Insufficient_Balance;
        public event Mydeleget Low_Balance;
        public event Mydeleget No_Balance;

        int Balance;

        public bank(int Balance)
        {
            this.Balance = Balance;
        }
        public int CreditMethod(int C_Amt)
        {
            Balance = Balance + C_Amt;
            return Balance;
        }

        public int DebitMethod(int D_Amt)
        {

            if(Balance < D_Amt)
            {
                Insufficient_Balance();
            }
            else
            {
                Balance=Balance- D_Amt;
            }
            return Balance;
        }

        public void CheckBalance()
        {
            if(Balance == 0)
            {
                No_Balance();
            }
            if(Balance <= 3000)
            {
                Low_Balance();
            }
        }
    }
}
