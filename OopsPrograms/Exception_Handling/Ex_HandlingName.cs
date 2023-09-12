using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Exception_Handling
{
    public class Ex_HandlingName
    {
        static void Main(string[] args)
        {

            try
            {
               
                string str = null;
                if(string.IsNullOrEmpty(str))
                {
                    throw new Exception("Name is Required");
                }

                Console.WriteLine(str);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Inside the Finally Block");
            }
        }
    }
}
