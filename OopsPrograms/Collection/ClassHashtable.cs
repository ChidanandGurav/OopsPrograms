using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Collection
{
    public   class ClassHashtable
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("91", "INDIA");
            ht.Add("036", "Australia");
            ht.Add("031", "Azerbaijan");
            ht.Add("044", "Bahamas (the)");

            ht.Remove("044");

            foreach(DictionaryEntry Item in ht)
            {
                Console.WriteLine($"{Item.Key} --> {Item.Value}");
            }
        }
    }
}
