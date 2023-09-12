using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Collection
{
    public class GList
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            List<int> list = new List<int>();
            list.Add(6);
            list.Add(7);
            list.Add(8);

            list.Insert(1, 6);
            list.AddRange(arr); // Add multiple value at a time
            list.Remove(6);
            list.RemoveAt(3); //remove the element based on index
            list.RemoveRange(4, 6); // remove multiple elements in once
            list.Clear();  // remove all the element

            list.Sort();
            list.Reverse();
            Console.WriteLine("Count Total Element = " + list.Count);
            Console.WriteLine("Capacity =" + list.Capacity);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
