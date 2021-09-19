using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class Task
    {
        public static int[] GetFirstEvenNumbers(int count)
        {
            int[] resultNums = new int[count];
            for (int i = 0; i < count; i++)
            {
                resultNums[i] = (i + 1) * 2;
            }

            return resultNums;
        }
    }
}
