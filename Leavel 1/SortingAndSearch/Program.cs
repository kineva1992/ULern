using System;

namespace SortingAndSearch
{
    class Program
    {
        private static readonly Random random = new Random();

        private static int[] GenerateArray(int length)
        {
            var array = new int[length];
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next();
            return array;
        }

        static void Main(string[] args)
        {
            Sorting sotring = new Sorting();

            var array = GenerateArray(10);
            Sorting.HoareSort(array);
            foreach (var e in array)
                Console.WriteLine(e);
        }
    }
}
