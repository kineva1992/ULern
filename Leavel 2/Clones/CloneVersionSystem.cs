using System;
using System.Collections.Generic;

namespace Clones
{
    public class CloneVersionSystem : ICloneVersionSystem
    {
        private readonly List<Clone> cloneList;

        public CloneVersionSystem()
        {
            cloneList = new List<Clone> { new Clone() };
        }

        public string Execute(string query)
        {
            var commands = query.Split(' ');
            var cloneNumber = int.Parse(commands[1]) - 1;
            switch (commands[0])
            {
                case "check":
                    return cloneList[cloneNumber].Check();
                case "learn":
                    var programNumber = int.Parse(commands[2]);
                    cloneList[cloneNumber].Learn(programNumber);
                    return null;
                case "rollback":
                    cloneList[cloneNumber].RollBack();
                    return null;
                case "relearn":
                    cloneList[cloneNumber].Relearn();
                    return null;
                case "clone":
                    cloneList.Add(new Clone(cloneList[cloneNumber]));
                    return null;
            }
            return null;
        }
    }

    public class Clone
    {
        private readonly Stack learnedProgramms;
        private readonly Stack rollBackHistory;

        public Clone()
        {
            learnedProgramms = new Stack();
            rollBackHistory = new Stack();
        }

        public Clone(Clone anotherClone)
        {
            learnedProgramms = new Stack(anotherClone.learnedProgramms);
            rollBackHistory = new Stack(anotherClone.rollBackHistory);
        }

        public void Learn(int commandNumber)
        {
            rollBackHistory.Clear();
            learnedProgramms.Push(commandNumber);
        }

        public void RollBack()
        {
            rollBackHistory.Push(learnedProgramms.Pop());
        }

        public void Relearn()
        {
            learnedProgramms.Push(rollBackHistory.Pop());
        }

        public string Check()
        {
            return learnedProgramms.IsEmpty() ? "basic" : learnedProgramms.Peek().ToString();
        }
    }

    public class Stack
    {
        private StackItem last;
        public Stack() { }

        public Stack(Stack stack)
        {
            last = stack.last;
        }

        public void Push(int value)
        {
            last = new StackItem(value, last);
        }

        public int Peek()
        {
            return last.Value;
        }

        public int Pop()
        {
            var value = last.Value;
            last = last.Previous;
            return value;
        }

        public bool IsEmpty()
        {
            return last == null;
        }

        public void Clear()
        {
            last = null;
        }
    }

    public class StackItem
    {
        public readonly int Value;
        public readonly StackItem Previous;

        public StackItem(int value, StackItem previous)
        {
            Value = value;
            Previous = previous;
        }
    }
}