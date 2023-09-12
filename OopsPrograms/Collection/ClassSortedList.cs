using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Collection
{
    public class ClassSortedList
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add("101", "HR");
            sl.Add("102", "Sales");
            sl.Add("103", "Testing");
            sl.Add("104", "Develop");
            sl.Add("105", "Admin");

            sl.Remove("102");

            foreach(DictionaryEntry Item in sl)
            {
                Console.WriteLine($"{Item.Key} --> {Item.Value}");
            }
        }
    }
}
