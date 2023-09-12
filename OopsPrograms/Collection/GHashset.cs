using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Collection
{
    public class GHashset
    {
        static void Main(string[] args)
        { 
            //Example 1
           /* HashSet<string> list1 = new HashSet<string>();
            list1.Add("Pune");
            list1.Add("Mumbai");
            list1.Add("Pune");
            list1.Add("Belgaum");
            list1.Add("Kolhapur");
            list1.Add("Pune");

            list1.Remove("Pune");//Remove Only Given Parameter.
            list1.Clear();//Remove all.

            foreach(string s in list1)
            {
                Console.WriteLine(s);
            }*/

            HashSet<string> list2 = new HashSet<string>();

            list2.Add("C");
            list2.Add("C++");
            list2.Add("C#");
            list2.Add("Java");

            HashSet<string> list3 = new HashSet<string>();

            list3.Add("Python");
            list3.Add("C++");
            list3.Add("C#");
            list3.Add("Angular");

            list2.UnionWith(list3); // combine the result & display unique elements
            list2.IntersectWith(list3); // first list matched with second & only matched elements will be displayed
            list2.ExceptWith(list3);// compare first list with second & only unique elemetns from list1 get accepted


            foreach (string item in list2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
