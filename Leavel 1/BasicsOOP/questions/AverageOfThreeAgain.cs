using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOOP.questions
{
    class AverageOfThreeAgain
    {
        static IComparable MiddleOfThree(IComparable a, IComparable b, IComparable c)
        {
            if ((b.CompareTo(a) <= 0 && a.CompareTo(c) <= 0) || (c.CompareTo(a) <= 0 && a.CompareTo(b) <= 0))
                return a;
            else if ((a.CompareTo(b) <= 0 && b.CompareTo(c) <= 0) || (c.CompareTo(b) <= 0 && b.CompareTo(a) <= 0))
                return b;
            else
                return c;
        }


        public static object Min(Array arr)
        {
            Array.Sort(arr);
            return arr.GetValue(0);
        }
    }
}
