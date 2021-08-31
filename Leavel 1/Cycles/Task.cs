using System;
using System.Collections.Generic;
using System.Text;

namespace Cycles
{
    static class Task
    {
    /*
    Найдите минимальную степень двойки, превосходящую заданное число.

    Более формально: для заданного числа nn найдите x > nx>n, такой, что x = 2^kx=2 
    k для некоторого натурального kk.

    Решите эту задачу с помощью цикла while.
    */
        public static int GetMinPowerOfTwoLargerThan(int number)
        {
            int result = 1;
            while (number >= result)
            {
                result *= 2;
            }

            return result;
        }
        
        /*
        Враги вставили в начало каждого полезного текста целую кучу бесполезных пробельных символов!

        Вася смог справиться с ситуацией, когда такой пробел был один, но продвинуться дальше ему не удается. Помогите ему с помощью цикла while.
        */
        public static string RemoveStartSpaces(sting inputText)
        {
        
        
        
        }

    }

}

