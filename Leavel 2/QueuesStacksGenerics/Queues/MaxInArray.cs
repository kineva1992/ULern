using System;
using System.Collections.Generic;
using System.Text;

namespace QueuesStacksGenerics.Queues
{
   public static class MaxInArray
    {

       public static T Max<T>(T[] array)
            where T:IComparable
        {
            if (array.Length == 0) return default(T);
            T max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max.CompareTo(array[i]) < 0)
                    max = array[i];
            }
            return max;
        }
    }
}
