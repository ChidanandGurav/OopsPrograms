using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Collection
{
    public class Classqueue
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();
            que.Enqueue(10);
            que.Enqueue(20);
            que.Enqueue(30);
            que.Enqueue(40);

            que.Dequeue();

            Console.WriteLine("First Element in the Queue :" +que.Peek());

            foreach(var item in que)
            {
                Console.WriteLine(item);
            }
        }
    }
}
