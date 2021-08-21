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

        static int Reverce(int myInt)
        {
            char[] myChar = myInt.ToString().ToCharArray();
            Array.Reverse(myChar);
            return int.Parse(new string(myChar));
        }

        static void Main(string[] args)
        {
            int myInt = 123456789;
            Console.WriteLine(Reverce(myInt));
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
