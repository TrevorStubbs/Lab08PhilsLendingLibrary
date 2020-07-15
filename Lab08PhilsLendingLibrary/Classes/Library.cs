﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lab08PhilsLendingLibrary.Classes
{
    class Library<T> : IEnumerable<T>
    {
        T[] items = new T[10];
        int count;

        public void Add(T item)
        {
            if(count == items.Length)
            {
                Array.Resize(ref items, items.Length * 2);
            }

            items[count++] = item;
        }

        public void Remove(T item)
        {
            // TODO implemtn this
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
