using System;
using YieldsAndReturn.Classes;

namespace YieldsAndReturn
{
    class Program
    {
        static void Main(string[] args)
        {
           
            foreach (var number in GeneratingSequence.GenerateCycle(4))
            {
                Console.WriteLine(number);
            }
        }
    }
}
