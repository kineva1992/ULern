using System;

namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Task.GetMinPowerOfTwoLargerThan(2)); // => 4
            Console.WriteLine(Task.GetMinPowerOfTwoLargerThan(15)); // => 16
            Console.WriteLine(Task.GetMinPowerOfTwoLargerThan(-2)); // => 1
            Console.WriteLine(Task.GetMinPowerOfTwoLargerThan(-100));
            Console.WriteLine(Task.GetMinPowerOfTwoLargerThan(100));
        }
    }
}
