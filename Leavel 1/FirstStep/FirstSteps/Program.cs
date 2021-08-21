using System;

namespace FirstSteps
{
    class Program
    {
        private static string GetGreetingMessage(string name, double salary)
        {
            return $"Hello, {name}, your salary is {salary}";
        }

        private static void Print(double getSquere)
        {
            Console.WriteLine(getSquere);
        }
        private static double GetSquare(double sqrt)
        {
            return Math.Pow(sqrt, 2);
        }

        private static string GetLastHalf(string text)
        {
            return text.Substring(text.Length / 2).Replace(" ", null);
        }


        static void Main(string[] args)
        {
            Console.WriteLine(GetGreetingMessage("Student", 10.01));
            Console.WriteLine(GetGreetingMessage("Bill Gates", 10000000.5));
            Console.WriteLine(GetGreetingMessage("Steve Jobs", 1));

            Print(GetSquare(42));

            Console.WriteLine(GetLastHalf("I love CSharp!"));
            Console.WriteLine(GetLastHalf("1234567890"));
            Console.WriteLine(GetLastHalf("до ре ми фа соль ля си"));
        }
    }
}
