using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String
{
    public class MailCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Mail Id");
            string str = Console.ReadLine();

            char[] ch = str.ToCharArray();
            int cnt = 0;

            for(int i =0; i < ch.Length; i++)
            {
                if (ch[i]=='@' || ch[i]=='.')
                {
                    cnt++;
                }
            }
            if(cnt == 2)
            {
                Console.WriteLine("Valid Mail Id");
            }
            else
            {
                Console.WriteLine("Invalid Mail Id");
            }
        }
    }
}
