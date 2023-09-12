using OopsPrograms.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static OopsPrograms.Delegate_And_Events.User;

namespace OopsPrograms.Delegate_And_Events
{

    //  Create a class User, create a method with name AccpetName(string name), convert the name in upper case & return.
    //   Create the delegate to hold AcceptName method reference & invoke using delegate
    public class Del_program
    {
        static void Main(string[] args)
        {
            /* User U = new User();
             MyDeleget md = new MyDeleget(U.AcceptName);


             string result = md.Invoke("chidanand");
             Console.WriteLine(result);*/

            User U = new User();
            MyDeleget md = new MyDeleget(U.AcceptName);
            md += new MyDeleget(U.UpperCase);
            md += new MyDeleget(U.LowerCase);

            Delegate [] list = md.GetInvocationList();

            foreach(Delegate D in list)
            {
                Console.WriteLine(D.Method);
                string res = Convert.ToString(D.DynamicInvoke("chidanand"));
                Console.WriteLine(res);
            }
        }
    }
    public class User
    {

        public delegate string MyDeleget(string name);

        public string AcceptName(string name)
        {
            return name;
        }

        public string UpperCase(string name)
        {
            return name.ToUpper();
        }

        public string LowerCase(string name)
        {
            return name.ToLower();
        }
    }

   
}
