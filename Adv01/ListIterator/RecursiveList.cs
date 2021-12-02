using System;

namespace Adv01.ListIterator
{
    public class RecursiveList<T> : ListItem<T>
    {
         ListItem<T> _first;

         public int Count()
         {
             if (_first == default)
                 return 0;
             else
                 return _first.Count();
         }

         public void Add(T item)
         {
             var listItem = new ListItem<T>(item);
             if (_first != default)
                 _first.Add(listItem);
             else
                 listItem._parent = this;
             _first = listItem;
         }

         public void Remove(T item)
         {
             if (_first != default)
                 _first.Remove(item);
         }

         public T Get(int index)
         {
             if (_first == default)
                 throw new IndexOutOfRangeException();
             return _first.Get(index, 0);
         }

        
    }
}