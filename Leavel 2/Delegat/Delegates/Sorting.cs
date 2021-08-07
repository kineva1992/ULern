using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Delegates
{
    public class Comparer
    {
        public bool Descending { get; set; }
        public int CompareStrings(string x, string y)
        {
            return x.CompareTo(y) * (Descending ? -1 : 1);
        }

    }

    public class Sorting
    {

        public delegate int StringComparer(string x, string y);
        public void Sort(string[] array, StringComparer copmare)
        {

            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    var element1 = array[j - 1];
                    var element2 = array[j];
                    if (copmare(element1, element2) > 0)
                    {
                        var tempory = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = tempory;
                    }
                }

            }

        }
    }

    public class CompareStringLength : IComparer<string>
    {
        public int Compare( string x, string y)
        {
            return x.Length.CompareTo(y.Length);
        }
    }

    //class StringCompare : IComparer<string>
    //{
    //    public int Compare(string x, string y)
    //    {
    //        return x.CompareTo(y);
    //    }
    //}
}
