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
        /*
        Чтобы освоиться с массивами, вы с Васей решили потренироваться на простых алгоритмах. Вася написал метод поиска минимума в массиве:
        А вам выпала задача посложнее — написать метод поиска индекса максимального элемента. 
        То есть такого числа i, что array[i] — это максимальное из чисел в массиве.
        Если в массиве максимальный элемент встречается несколько раз, вывести нужно минимальный индекс.
        Если массив пуст, вывести нужно -1.
         */

        public static double MaxInArray(double[] array)
        {
            var max = double.MinValue;
            int index = 0;

            if (array.Length == 0) return -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    index = i;
                }
            }

            return index;
        }

        public static int GetElementCount(int[] items, int itemToCount)
        {
            int CountInArray = 0;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == itemToCount)
                {
                    CountInArray++;
                }
            }

            return CountInArray;
        }

        public static int GetElementCountVer2(int[] items, int itemToCount)
        {
            int CountInArray = 0;

            foreach (var item in items)
            {
                if (item == itemToCount)
                    CountInArray++;
            }

            return CountInArray;
        }

        private static bool ContainsAtIndex(int[] array, int[] subArray, int index)
        {
            foreach (var item in subArray)
            {
                if (array[index] != item)
                    return false;
                else index++;
            }
            return true;
        }
        /*
        Вася нашел в интернете сайт, предсказывающий будущее на картах Таро. Он решил перенести сайт в Россию и заработать на доверчивых людях. Для этого сайт необходимо русифицировать.
        Вася справился с проблемой русификации мастей. Но решение длинное, а русифицировать нужно еще много чего. Кажется, что эту задачу можно решить немного веселее, с помощью массивов. Возможно даже всего в одну строчку кода.
        Сделайте это!
         */
        private static string GetSuit(Suits suit)
        {
            return (new[] { "Жезлов", "Монет", "Кубков", "Мечей" })[(int)suit];
        }

        public static bool CheckFirstElement(int[] array)
        {
            return array != null & array.Length != 0 & array[0] == 0;
        }
        /*
        Помогите Васе написать метод, который принимает массив int[], возводит все его элементы в заданную степень и возвращает массив с результатом этой операции.
        Исходный массив при этом должен остаться неизменным.
         */
        public static int[] GetPoweredArray(int[] arr, int power)
        {
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                result[i] = (int)Math.Pow(arr[i], power);
            return result;
        }
    }
    enum Suits
    {
        Wands,
        Coins,
        Cups,
        Swords
    }
}
