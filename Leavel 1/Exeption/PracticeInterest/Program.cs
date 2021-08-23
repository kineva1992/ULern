using System;
using System.Globalization;
using System.Linq;

namespace PracticeInterest
{
    class Program
    {
        /*
        В этой задаче вам нужно самостоятельно создать с нуля консольное приложение, которое рассчитывает банковские проценты.

        Пользователь должен ввести исходные данные с консоли — три числа через пробел: исходную сумму, процентную ставку (в процентах) и срок вклада в месяцах.

        Программа должна вывести накопившуюся сумму на момент окончания вклада.

        Вот порядок действий:

        Создайте новый проект с типом Console Application.
        В методе Main напишите ввод с помощью Console.ReadLine() и вывод с помощью Console.WriteLine().
        Все вычисление вынесите во вспомогательный метод Calculate. Код этого метода и нужно сдать в этой задаче.
        Детали:

        В конце каждого месяца происходит капитализация — к сумме прибавляется накопившийся за месяц процент. Далее процент вычисляется от этой увеличенной суммы.
        Процентная ставка — годовая (то есть в конце месяца сумма на счете увеличивается на одну двенадцатую ставки)
        Считайте, что вклад открыт в первый день месяца, а срок вклада — это целое количество месяцев.
        Код, решающий основную задачу нужно оформить в виде метода Calculate, принимающего строку, введенную пользователем. В этой задаче гарантируется, что ввод корректный.
        Решите эту задачу без использования циклов!
         */
        public static class Calculator
        {
           public static double Calculate(string inputNumber)
            {
                string[] inputNumberArraySplit = inputNumber.Split(' ');
                double amount = double.Parse(inputNumberArraySplit[0], CultureInfo.InvariantCulture);
                double percent = double.Parse(inputNumberArraySplit[1], CultureInfo.InvariantCulture);
                int mounths = int.Parse(inputNumberArraySplit[2]);

                if (amount <= 0 || percent <= 0 || mounths < 0) throw new ArgumentException(" This number is not equel zero");
                if (mounths == 0) return amount;

                double deposite = Calculate(amount,percent, mounths);
                return deposite;
               }

            private static double Calculate(double amount, double percent, int mounths)
            {
                amount += amount * ((double)1 / 12) * (percent / 100);
                if (mounths != 1)
                {
                    amount = Calculate(amount, percent, mounths);
                    return amount;
                }

                else return amount;

            }
            // Версия с циклом
            public static double Calculators(string inputUserText)
            {
                double[] splitTextUserInput = inputUserText.Split(' ').Select(double.Parse).ToArray();
                double sum = splitTextUserInput[0] ,
                       amount = splitTextUserInput[0],
                       parcent = splitTextUserInput[1],
                       mounts = splitTextUserInput[2];
                for (int i = 0; i < mounts; i++)
                {
                    sum += sum * ((parcent / 12) / 100);
                }

                return sum;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Calculate("100.00 12 1"));  
        }
    }
}
