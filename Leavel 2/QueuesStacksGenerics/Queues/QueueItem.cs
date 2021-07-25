using System;
using System.Collections.Generic;
using System.Text;

namespace QueuesStacksGenerics.Queues
{
    public class QueueItem
    {
        public int Value { get; set; }
        public QueueItem Next { get; set; }

    }

    public class Queue
    {
        QueueItem head;
        QueueItem tail;

        public void Enque(int value)
        {
            if (head == null)
            {
                tail = head = new QueueItem { Value = value, Next = null };
            }

            else
            {
                var item = new QueueItem { Value = value, Next = null };
                tail.Next = item;
                tail = item;
            }
        }

        public int Dequeue()
        {
            if (head == null) throw new InvalidOperationException();
            var result = head.Value;
            head = head.Next;
            if (head == null)
                tail = null;
            return result;

        }
    }
}
