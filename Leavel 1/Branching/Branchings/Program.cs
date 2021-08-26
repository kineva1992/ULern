using System;

namespace Branchings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Task.MiddleOf(5, 0, 100)); // => 5
            Console.WriteLine(Task.MiddleOf(12, 12, 11)); // => 12
            Console.WriteLine(Task.MiddleOf(1, 1, 1)); // => 1
            Console.WriteLine(Task.MiddleOf(2, 3, 2));
            Console.WriteLine(Task.MiddleOf(8, 8, 8));
            Console.WriteLine(Task.MiddleOf(5, 0, 1));
        }
    }
}
