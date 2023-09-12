using OopsPrograms.String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Delegate_And_Events
{
    public class Program_Evnt
    {
        static void Main(string[] args)
        {
            try
            {
                Student std = new Student();
                Message msg = new Message();

                //Bind event and deleget

                std.Fail += new MyDeleget1(msg.FailMessage);
                std.Pass += new MyDeleget1(msg.PassMessage);

                //ANONYMOUS
                /*// bind event with delegate
                // this a method body / code    
                //{ Console.WriteLine("You are fail"); }
                std.Fail += delegate () { Console.WriteLine("You are fail"); };
                std.Pass += delegate () { Console.WriteLine("You are pass"); };*/

                std.AcceptPercentage(32);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    //-------------------------------------------------------------------------

    public delegate void MyDeleget1();
    public class Student
    {
        public event MyDeleget1 Fail;
        public event MyDeleget1 Pass;

        public void AcceptPercentage(double per)
        {
            if (per < 40)
            {
                Fail();
            }
            else
            {
                Pass();
            }
        }
    }

    public class Message
    {
        public void PassMessage()
        {
            Console.WriteLine("You are Pass in Exam");
        }
        public void FailMessage()
        {
            Console.WriteLine("You are Fail in Exam");
        }
    }
}
