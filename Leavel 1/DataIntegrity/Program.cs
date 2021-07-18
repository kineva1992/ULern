using DataIntegrity.Data;
using System;

namespace DataIntegrity
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadOnlyVector vector = new ReadOnlyVector(3, 4);

            Console.WriteLine($"X = {vector.X}; Y = {vector.Y}");
            Console.WriteLine($"Vector = {vector.Add(vector).X}; {vector.Add(vector).Y}");
            Console.WriteLine(new string('-', 30));

            ReadOnlyVector vector1 = vector.WithX(5);
            Console.WriteLine($"X = {vector1.X}; Y = {vector1.Y}");
            Console.WriteLine($"New vector = {vector.Add(vector1).X}; {vector.Add(vector1).Y}");
            Console.WriteLine(new string('-', 30));
        }
    }
}
