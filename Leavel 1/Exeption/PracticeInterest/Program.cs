using System;
using System.Globalization;


namespace PracticeInterest
{
    class Program
    { 
        public static class Calculator
        {
           public static double Calculate(string inputNumber)
            {
                string[] inputNumberArraySplit = inputNumber.Split(' ');
                double amount = double.Parse(inputNumberArraySplit[0], CultureInfo.InvariantCulture);
                double percent = double.Parse(inputNumberArraySplit[1], CultureInfo.InvariantCulture);
                int mounths = int.Parse(inputNumberArraySplit[2]);

                if (amount <= 0 || percent <= 0 || mounths < 0) throw new ArgumentException(" This number is not equel zero");
                if (mounths == 0) return amount;

                double deposite = Calculate(amount,percent, mounths);
                return deposite;
               }

            private static double Calculate(double amount, double percent, int mounths)
            {
                amount += amount * ((double)1 / 12) * (percent / 100);
                if (mounths != 1)
                {
                    amount = Calculate(amount, percent, mounths);
                    return amount;
                }

                else return amount;

            }
        }
        static void Main(string[] args)
        {

            

            Console.WriteLine(Calculator.Calculate("100.00 12 1"));  
        }
    }
}
