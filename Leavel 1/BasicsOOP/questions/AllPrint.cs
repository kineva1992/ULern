using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOOP.questions
{
    class AllPrint
    {
       public static void PrintArray(params object[] argument)
        {
            for (var i = 0; i < argument.Length; i++)
            {
                Console.Write(argument[i]);
                if (i < argument.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }

        static void Print(Array array)
        {
            if (array == null)
            {
                Console.WriteLine("null");
                return;
            }
            for (int i = 0; i < array.Length; i++)
                Console.Write("{0} ", array.GetValue(i));
            Console.WriteLine();
        }

        static int FullLengthOfArray(Array[] arrays)
        {
            var count = 0;
            foreach (var array in arrays)
            {
                count += array.Length;
            }
            return count;
        }

        static Array Combine(params Array[] arrays)
        {
            if (arrays.GetLength(0) == 0) return null;
            var arrayType = arrays[0].GetType().GetElementType();
            var newArrayLength = FullLengthOfArray(arrays);
            var newArray = Array.CreateInstance(arrayType, newArrayLength);
            for (int i = 0; i < arrays.GetLength(0); i++)
            {
                if (arrays[i].GetType().GetElementType() != arrayType) return null;
                arrays[i].CopyTo(newArray, i * arrays[i].Length);
            }

            return newArray;
        }
    }
}
