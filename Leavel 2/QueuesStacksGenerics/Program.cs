using QueuesStacksGenerics.Queues;
using System;

namespace QueuesStacksGenerics
{
  

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //var queue = new Queue();
            //for (int i = 0; i < 3; i++)
            //{
            //    queue.Enque(i);
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}

            Console.Write(MaxInArray.Max(new int[0]));
            Console.Write(MaxInArray.Max(new[] { 3 }));
            Console.Write(MaxInArray.Max(new[] { 3, 1, 2 }));
            Console.Write(MaxInArray.Max(new[] { "A", "B", "C" }));
        }
    }
}
