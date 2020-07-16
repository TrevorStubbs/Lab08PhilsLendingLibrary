using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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

        public T Remove(int position)
        {
            if(position > count)
            {
                throw new Exception("That book does not exist");
            }

            int newCounter = 0;
            T removedBook = Items[position - 1];
            for (int i = 0; i < position - 1; i++)
            {
                Items[i] = Items[i];
                newCounter++;
            }

            for (int i = position; i < Items.Length; i++)
            {
                if (Items[i] == null)
                {
                    Items[i - 1] = default(T);

                }
                else
                {
                    Items[i - 1] = Items[i];
                    newCounter++;
                }
            }

            if (newCounter < Items.Length / 2)
            {
                Array.Resize(ref Items, Items.Length / 2);
            }

            count = newCounter;
            return removedBook;
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
            T[] returnItems = new T[count];
            for (int i = 0; i < count; i++)
            {
                returnItems[i] = Items[i];
            }

            return returnItems;
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
