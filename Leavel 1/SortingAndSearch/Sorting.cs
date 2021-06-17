using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAndSearch
{
    class Sorting
    {
        #region BubleSort
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

        #endregion

        #region Merge

        static int[] temploryArray;

        private static void Merge(int[] array, int start, int midle, int end)
        {
            var leftPtr = start;
            var rightPtr = midle + 1;
            var length = end - start - 1;

            for (int i = 0; i < length; i++)
            {
                if (rightPtr > end || (leftPtr <= midle && array[leftPtr] < array[rightPtr]))
                {
                    temploryArray[i] = array[leftPtr];
                    leftPtr++;
                }

                else
                {
                    temploryArray[i] = array[rightPtr];
                    rightPtr++;
                }
            }

            for (int i = 0; i < length; i++)
            {
                array[i + start] = temploryArray[i];
            }

        }

        private static void MergeSort(int[] array, int start, int end) 
        {
            if (start == end) return;
            var midle = (start + end) / 2;
            MergeSort(array, start, midle);
            MergeSort(array, midle + 1, end);
            Merge(array, start, midle, end);
            
        }

       public static void MergeSort(int[] array)
        {
            temploryArray = new int[array.Length];
            MergeSort(array, 0, array.Length);
        }


        #endregion

        #region Quick-Sort
        static void HoareSort(int[] array, int start, int end)
        {
            if (end == start) return;
            var pivot = array[end];
            var storeIndex = start;
            for (int i = start; i <= end - 1; i++)
            {
                if (array[i] <= pivot)
                { 
                var t = array[i];
                array[i] = array[storeIndex];
                array[storeIndex] = t;
                storeIndex++;
                }
            }

            var n = array[storeIndex];
            array[storeIndex] = array[end];
            array[end] = n;
            if (storeIndex > start) HoareSort(array, start, storeIndex - 1);
            if (storeIndex < end) HoareSort(array, storeIndex + 1, end);
        }

       public static void HoareSort(int[] array)
        {
            HoareSort(array, 0, array.Length - 1);
        }

        #endregion

    }
}
