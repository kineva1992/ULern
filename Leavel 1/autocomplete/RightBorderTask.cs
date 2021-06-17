using System;
using System.Collections.Generic;
using System.Linq;

namespace Autocomplete
{
    public class RightBorderTask
    {
        /// <returns>
        /// Возвращает индекс правой границы. 
        /// То есть индекс минимального элемента, который не начинается с prefix и большего prefix.
        /// Если такого нет, то возвращает items.Length
        /// </returns>
        /// <remarks>
        /// Функция должна быть НЕ рекурсивной
        /// и работать за O(log(items.Length)*L), где L — ограничение сверху на длину фразы
        /// </remarks>
        public static int GetRightBorderIndex(IReadOnlyList<string> phrases, string prefix, int left, int right)
        {

            while (right - left > 1)
            {

                var midle = (right - left) / 2 + left;

                if (string.Compare(prefix, phrases[midle], StringComparison.OrdinalIgnoreCase) >= 0
                    || phrases[midle].StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                {
                    left = midle;
                }

                else
                {
                    right = midle;
                }

            }

            return right;
        }
    }
}