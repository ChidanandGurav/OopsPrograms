using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String
{
    public class LongestWord
    {

        //17.	WAP to find longest word in the given sentence.
        static void Main(string[] args)
        {
            /*string Sen = "My name is Chidanand";
            string[] words = Sen.Split();
            string word = "";
            int cnt = 0;
            foreach (string s in words)
            {
                if(s.Length > cnt)
                {
                     word = s;
                    cnt = s.Length;
                }
            }
            Console.WriteLine(word);*/

            string Sen = "My name is Chidanand";
            Console.WriteLine(Sen);

            string[] str = Sen.Split(' ');
            string LongestWord = "";
            int max = 0;
            

            for(int i = 0; i<str.Length; i++)
            {
                int a = str[i].Length;
                if(a > max)
                {
                    max= a;
                    LongestWord= str[i];
                    
                }
            }
            Console.WriteLine(LongestWord);
        }
    }
}
