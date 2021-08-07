using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorting SortingClass = new Sorting();
            CompareStringLength compareStringLength = new CompareStringLength();
            Comparer comparer = new Comparer();


            var strings = new[] { "A", "B", "AA" };

            SortingClass.Sort(strings, compareStringLength.Compare);
            var obj = new Comparer { Descending = true };
            SortingClass.Sort(strings, comparer.CompareStrings);
        }
    }
}
