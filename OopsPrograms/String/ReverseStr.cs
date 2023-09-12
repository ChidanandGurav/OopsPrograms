using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String
{
    public class ReverseStr
    {
        static void Main(string[] args)
        {
            string str = "India is the best";
            string[] st = str.Split();
            
            for(int i =0; i<st.Length; i++)
            {
                string word = st[i];
                string rev = " ";

                for(int j=word.Length-1; j>=0; j--)
                {
                    rev = rev + word[j];
                }
                str = str + rev;
            }
            Console.WriteLine(str);
            
        }
    }
}
