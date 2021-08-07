using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorting SortingClass = new Sorting();
            CompareStringLength compareStringLength = new CompareStringLength();


            var strings = new[] { "A", "B", "AA" };

            var lengthComperers = new Sorting.StringComparer(compareStringLength.Compare);

            SortingClass.Sort(strings, lengthComperers);

            var obj = new Comparer { Descending = true };

            var simpleComparer =
                new Sorting.StringComparer(obj.CompareStrings);
            SortingClass.Sort(strings, simpleComparer);
        }
    }
}
