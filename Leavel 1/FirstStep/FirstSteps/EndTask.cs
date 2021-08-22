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
        static int f(int a, int n)
        {
            return (n - 1) / a;
        }

        //Task 5

        static int LeapYearBetween(int start, int end)
        {
            System.Diagnostics.Debug.Assert(start < end);
            return LeapYearBefore(end) - LeapYearBefore(start + 1);

        }

        static int LeapYearBefore(int year)
        {
            System.Diagnostics.Debug.Assert(year > 0);
            year--;
            return (year / 4) - (year / 100) + (year / 400);
        }

        static int IsLeapYear(int year)
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 == 0))
                return year;
            else
                return year;
        }

        

    }
    //Task 6
    class Point
    { 
    public double PointX { get; set; }
    public double PointY { get; set; }
    }

    static class Length
    {
        private static double GetLength(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow((p1.PointX - p2.PointX), 2) + Math.Pow((p1.PointY - p2.PointY), 2));
        }

        public static double GetPointLength(Point p1, Point p2, Point point)
        {
            return Math.Abs((p2.PointY - p1.PointY) * point.PointX - (p2.PointX - p1.PointX) * p2.PointY + p1.PointY - p2.PointY * p1.PointX)
                / GetLength(p1, p2);

        }

        //Task 7

        public class Vector
        {
        public double A { get; set; }
        public double B { get; set; }

            public Vector(double a, double b)
            {
                A = a;
                B = b;
            }

            public void PrintVector(string s)
            {
                Console.WriteLine("{0} - {1}, {2}", s, A, B);
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Уравнение прямой задано Аx + By + C = 0.");
                Console.WriteLine("Введите коэффициент А:");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите коэффициент B:");
                double b = double.Parse(Console.ReadLine());
                if (a == 0 && b == 0)
                {
                    Console.WriteLine("Нулевые векторы");
                    return;
                }
                Vector v = new Vector(-b, a);
                // можно учесть ситуацию, когда А или В = 0, тогда вектор будет иметь координаты (1;0) и (0;1) соот-но
                v.PrintVector("Направляющий вектор прямой");
                Vector vv = new Vector(a, b);
                vv.PrintVector("Нормальный вектор прямой");
            }
        }


    }
}
