using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Delegates
{
    class Sorting
    {
        public static void Sort(string[] array, IComparer<string> copmare)
        {

            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    var element1 = array[j - 1];
                    var element2 = array[j];
                    if (copmare.Compare(element1, element2) > 0)
                    {
                        var tempory = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = tempory;
                    }
                }

            }

        }
    }

    class StringLengthComparer : IComparer<string>
    {
        public int Compare( string x, string y)
        {
            return x.Length.CompareTo(y.Length);
        }
    }

    class StringCompare : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return x.CompareTo(y);
        }
    }
}
