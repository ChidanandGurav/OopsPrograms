using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Exception_Handling
{

    //1.If number is negative then throw negative number exception.

    public class NagativeValue
    {
        static void Main(string[] args)
        {
            try
            {


                Console.WriteLine("Enter a Number");
                int Number = Convert.ToInt32(Console.ReadLine());


                if (Number < 0)
                {
                    throw new Exception("Nagative Number");
                }
                Console.WriteLine(Number);

            }
            catch(Exception ex)
              {
                Console.WriteLine(ex.Message);
              }
        }
    }
}
