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
            int i = 0;
            if(inputText != " "){
              while(char.IsWhiteSpace(inputText[i]))
              {
              if(i == inputText.Length - 1) return "";
              i++;              
              }
              
              return inputText.Substring(i++);
              }
              
              else throw new ArgumentExeption("String is null");
        }
        
        public static string RemoveStartSpacesVer2(string text)
        {
            while(text != string.Empty && char.IsWhiteSpace(text[0])){
                text = text.Remove(0,1);
            }

            return text;
        }
        
        /*
        Вы решили помочь Васе с разработкой его игры и взяли на себя красивый вывод сообщений в игре.

        Напишите функцию, которая принимает на вход строку текста и печатает ее на экран в рамочке из символов +, - и |. Для красоты текст должен отделяться от рамки слева и справа пробелом.

        Например, текст Hello world должен выводиться так:
        */
        
        private static void OutPutBorder(string inputText)
        {
        Console.Write("+-");
        for(int i = 0; i < inputText.Length; i++)
            Console.Write("-");
        Console.Write("-+\n");
        }
        
        public static void WriteTextWithBorder()
        {
        Console.WriteLine("Ведите пожалуйста желаемый текст для вывода: ");
        string inputText = Console.ReadLine();
        
        OutPutBorder(inputText);
        Console.WriteLine("|" + inputText + "|");
        OutPutBorder(inputText);
        }
        
        /*
        Стали известны подробности про новую игру Васи. Оказывается ее действия разворачиваются на шахматных досках нестандартного размера.

        У Васи уже написан код, генерирующий стандартную шахматную доску размера 8х8. Помогите Васе переделать этот код так, чтобы он умел выводить доску любого заданного размера.

        Например, доска размера пять должна выводиться так:
        */
        
        public static vodi WriteBoard(int size)
        {
        for(int i = 0; i < size; i++)
        {
            for(int j = 0; j < size; i++)
            {
                if((i + j) % 2 != 0)
                    Console.Write(".");
                else 
                    Console.Write("#");
            }
            Console.WriteLine();
        }
            Console.WriteLine();
        }
        
        
 
    }

}

