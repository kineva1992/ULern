using System;
using System.Collections.Generic;

namespace TodoApplication
{
    internal class Action<TItem>
    {
        internal ActionType ActionType { get; }
        internal TItem Item { get; }
        internal int Index { get; }
        internal Action(ActionType action, TItem item, int index)
        {
            ActionType = action;
            Item = item;
            Index = index;
        }
    }
    internal enum ActionType
    { 
    AddItem,
    RemoveItem
    }


    public class ListModel<TItem>
    {
        public List<TItem> Items { get; }
        public int Limit;
        private LimitedSizeStack<Action<TItem>> actionStack; 

        public ListModel(int limit)
        {
            Items = new List<TItem>();
            Limit = limit;
            actionStack = new LimitedSizeStack<Action<TItem>>(limit);
        }

        public void AddItem(TItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(int index)
        {
            Items.RemoveAt(index);
        }

        public bool CanUndo()
        {
            return actionStack.Count > 0;
        }

        public void Undo()
        {
            var action = actionStack.Pop();
            if(action.ActionType == ActionType.AddItem)
            {
                Items.RemoveAt(action.Index);
                return;
            }
            Items.Insert(action.Index, action.Item);
        }
    }
}
