using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Collection
{
    public  class GStack
    {
        static void Main(string[] args)
        {
            Stack<int> st1 = new Stack<int>();
            st1.Push(1);
            st1.Push(2);
            st1.Push(3);
            st1.Push(4);
            Console.WriteLine("After push: ");

            foreach (var item in st1)
            {
                Console.WriteLine(item);
            }

            st1.Pop();
            Console.WriteLine("After pop: ");
            foreach (var item in st1)
            {
                Console.WriteLine(item);
            }

            st1.Peek();
            Console.WriteLine("After Peek: ");
            foreach (var item in st1)
            {
                Console.WriteLine(item);
            }
            st1.Clear();
            Console.WriteLine("After clear: ");
            foreach (var item in st1)
            {
                Console.WriteLine(item);
            }


        }
    }
}
