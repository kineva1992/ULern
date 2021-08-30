using System;
using System.Collections.Generic;
using System.Text;

namespace Cycles
{
    class Task
    {
        public static int GetMinPowerOfTwoLargerThan(int number)
        {
            if (number < 0) throw new ArgumentNullException();

            else { 
            int result = 1;
            while (Math.Pow(2, result) <= number)
            {
                result++;
            }

            result = (int)Math.Pow(2,result);
                return result;    
            }
            }
            
        }

    }

