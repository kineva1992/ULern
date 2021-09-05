using System;
using System.Collections.Generic;
using System.Text;

namespace Cycles
{
    static class Task
    {
        public static int GetMinPowerOfTwoLargerThan(int number)
        {
            
            int result = 1;
            while (number >= result)
            {
                result *= 2;
            }

            return result;
            

        }

    }

}

