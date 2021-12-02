using System;

namespace Adv01.ListIterator
{
    public class ListItem<T>
    {
        protected internal ListItem<T> _parent;
        private ListItem<T> _child;
        private T _item;

        protected ListItem() {}

        protected internal ListItem(T item)
        {
            _item = item;
        }

        protected internal void Add(ListItem<T> listItem)
        {
            if (_child != default)
                _child.Add(listItem);
            else
            {
                listItem._parent = this;
                _child = listItem;
            }
        }

        protected internal void Remove(T item)
        {
            if ((_item == null && item == null) || (_item != null && _item.Equals(item)))
                _parent._child = _child;
            else if (_child != default)
                _child.Remove(item);
        }
        
        protected internal T Get(int wantedIndex, int myIndex)
        {
            if (wantedIndex==myIndex)
            {
                return _item;
            }
            if (_child != default)
            {
                _child.Get(wantedIndex, myIndex);
            }
            throw new IndexOutOfRangeException();
        }
        
        protected internal int Count()
        {
            if (_child != default)
                return 1 + _child.Count();
            else
                return 1;
        }
        
    }
}