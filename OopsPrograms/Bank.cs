using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class Bank
    {
        private int Accno;
        private string Accname;
        private double Balance;

        public Bank(int accno, string accname, double balance)
        {
            Accno = accno;
            Accname = accname;
            Balance = balance;
        }

        public void Creadit(double crd_amt)
        {
            Balance = Balance + crd_amt;
        }
        public string Debit(double debit_amt)
        {
            string msg = "";
            if (debit_amt  <=  Balance)
            {
                Balance = Balance - debit_amt;
                msg = "Done Transaction";
            } 
            else
            {
                msg = "Insufficient Balance";
            }
            return msg;
        }
        public string PrintBalance()
        {
            return $"Acc No = {Accno} / Acc Name = {Accname} / Balance = {Balance}";
        }
    }
}
