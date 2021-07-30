using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApplication
{
    public class LimitedSizeStack<T>
    {
        private readonly int amount;
        private LinkedList<T> newLinkedList = new LinkedList<T>();
        public LimitedSizeStack(int limit)
        {
            amount = limit;
        }

        public void Push(T item)
        {
            newLinkedList.AddLast(item);
            if (newLinkedList.Count > amount)
                newLinkedList.RemoveFirst();
        }

        public T Pop()
        {

            if (newLinkedList.Count == 0)
                throw new InvalidCastException();
            var last = newLinkedList.Last.Value;
            newLinkedList.RemoveLast();
            return last;
        }

        public int Count
        {
            get
            {
                return newLinkedList.Count();
            }
        }
    }
}
