using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Collection
{
    public class GQueue
    {
        static void Main(string[] args)
        {
            
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(11);
            queue.Enqueue(21);
            queue.Enqueue(31);
            queue.Enqueue(41);

            Console.WriteLine("After enque: ");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            queue.Dequeue();
            Console.WriteLine("After dequeue: ");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

        }
    }
}
