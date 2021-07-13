using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BasicsOOP.questions
{
    public class Point
    {
        public double X;
        public double Y;
    }
    public class ClockwiseComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var point1 = x as Point;
            var point2 = y as Point;

            if (point1.Y >= 0)
            {
                return point2.Y >= 0
                    ? point2.X.CompareTo(point1.X)
                    : -1;
            }
            return point2.Y >= 0
                ? 1
                : point2.X.CompareTo(point1.X);
        }
    }
}
