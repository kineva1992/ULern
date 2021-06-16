using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAndSearch
{
    class Sorting
    {
        public void BubleSort(int[] array) {

            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < array.Length - 1; j++)
                    if (array[j] > array[j + 1])
                    {
                        int t = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = t;
                    }
        }

        public static void BubbleSortRange(int[] array, int left, int right)
        {
            for (int i = left; i < right; i++)
                for (int j = left; j < right; j++)
                    if (array[j] > array[j + 1])
                    {
                        var t = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = t;
                    }
        }

    }
}
