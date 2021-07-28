using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QueuesStacksGenerics.Queues
{
   public class Stacks
    {
        public static bool IsCorrectString(string str)
        {
            var stask = new Stack<char>();
            foreach (var item in str)
            {
                switch (item)
                {
                    case '[':
                    case '(':
                        stask.Push(item);
                        break;
                    case ']':
                        if (stask.Count == 0) return false;
                        if (stask.Pop() != '[') return false;
                        break;
                    case ')':
                        if (stask.Count == 0) return false;
                        if (stask.Pop() != '(') return false;
                        break;
                    default:
                        return false;
                }


            }
            return stask.Count == 0;
        }

        public static bool IsCorrectStringDict(string str)
        {
            var pairs = new Dictionary<char, char>();
            pairs.Add('(',')');
            pairs.Add('[', ']');
            var stack = new Stack<char>();
            foreach (var e in str)
            {
                if (pairs.ContainsKey(e)) stack.Push(e);
                else if (pairs.ContainsKey(e))
                {
                    if (stack.Count == 0 || pairs[stack.Pop()] != e) return false;
                }
                else return false;
            }
            return stack.Count == 0;
        }
    }
}