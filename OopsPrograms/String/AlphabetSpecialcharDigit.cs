using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String
{
    public class AlphabetSpecialcharDigit
    {

        //12.	Write a C# program to find total number of alphabets, digits or special character in a string.
        static void Main(string[] args)
        {
            string str = "chidugurav6@gmail.com";
            int cnt = 0, cnt1 = 0, cnt2 = 0;
            char[] ch = str.ToCharArray();

            for(int i = 0; i<ch.Length; i++)
            {
                if ((ch[i] >=65 && ch[i] <=90) || (ch[i] >= 97 && ch[i] <= 122))
                {
                    cnt++;
                }
                else if (ch[i] >= '0' && ch[i] <='9')
                {
                    cnt1++;
                }
                else if (ch[i] !=' ')
                {
                    cnt2++;
                }
            }
            Console.WriteLine("Totel Number of Alphabet :" +cnt);
            Console.WriteLine("Totel Number of Digit :" + cnt1);
            Console.WriteLine("Totel Number of Special Symbol :" + cnt2);
        }
    }
}
