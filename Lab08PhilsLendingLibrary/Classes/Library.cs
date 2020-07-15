using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lab08PhilsLendingLibrary.Classes
{
    public class Library<T> : IEnumerable<T>
    {
        T[] Items = new T[10];
        int count;

        public void Add(T item)
        {
            if (count == Items.Length)
            {
                Array.Resize(ref Items, Items.Length * 2);
            }

            Items[count++] = item;
        }

        public void Remove(T item)
        {
            // TODO implemtn this
        }

        public int Count()
        {
            int counter = 0;
            foreach (T item in Items)
            {
                if (item != null)
                    counter++;
            }
            return counter;
        }

        public T[] GetItems()
        {
            return Items;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return Items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
