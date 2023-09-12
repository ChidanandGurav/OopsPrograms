using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Collection
{
    public class GDictionary
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> dic = new Dictionary<int,string>();

            dic.Add(91 , "India");
            dic.Add(036 , "Australia");
            dic.Add(031 , "Azerbaijan");

            foreach(KeyValuePair<int,string> Item in dic)
            {
                Console.WriteLine($"{Item.Key} , {Item.Value}");
            }

            dic.Remove(031);
            Console.WriteLine("After Remove");
            foreach (KeyValuePair<int, string> Item in dic)
            {
                Console.WriteLine($"{Item.Key} , {Item.Value}");
            }
        }
    }
}
