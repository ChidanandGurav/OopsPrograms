using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace OopsPrograms.Collection
{
    public class ClassStack
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);


            stack.Pop(); // remove the top element
            Console.WriteLine("Top element " + stack.Peek()); //  // Peek() -- returns the top element in the stack
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }


    }
}
