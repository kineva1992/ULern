using System;
using System.Collections.Generic;
using System.Text;

namespace FirstSteps
{
    class EndTask
    {
        // Task 1 ;
        class Program
        {
            static void Main(string[] args)
            {
                int a = 1, b = 2;

                (a, b) = (b, a);

                Console.WriteLine(a);
                Console.WriteLine(b);
            }
        }


        //Task 2

        static int Reverce(int myInt)
        {
            char[] myChar = myInt.ToString().ToCharArray();
            Array.Reverse(myChar);
            return int.Parse(new string(myChar));
        }
        // Task 3
        static double TimeAngle(double hours)
        {
            const int zeroHourAngel = 0;
            const int stepHourAngle = 360 / 12;

            if (hours > 12 || hours < 0)
                throw new Exception("It's not real time!");
            if (hours == 12 || hours == 24)
                hours = zeroHourAngel;
            if (hours > 12 && hours < 24)
                hours -= 12;
            if (hours > 6 && hours < 12)
                hours = 6 - (hours - 6);
            return hours * stepHourAngle;
        }

        //Task 4
        static int GetCountParts(int n, int x, int y)
        {
            int count = 0;
            for (int i = 1; i < n; i++)
                if (i % x == 0 || i % y == 0)
                    count++;
            return count;
        }

        static int[] GetArrParts(int n, int x, int y)
        {
            int[] arrParts = new int[GetCountParts(n, x, y)];
            for (int i = 1, j = 0; i < n; i++)
                if (i % x == 0 || i % y == 0)
                    arrParts[j++] = i;
            return arrParts;
        }
    }
}
