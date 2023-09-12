using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Exception_Handling
{
    public class Alphabetstring
    {

        //2.WAP to check String content only alphabets if any digit or symbol is present then throw custom exception

        static void Main(string[] args)
        {
            try
            {
                string str = "Chidanand";
                char[] ch = str.ToCharArray();

                for (int i = 0; i < ch.Length; i++)
                {
                    if ((ch[i] >= 65 && ch[i] <= 90) || (ch[i] >= 97 && ch[i] <= 122))
                    {
                        throw new Exception(" ");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            { 

            }
    }   }
}
