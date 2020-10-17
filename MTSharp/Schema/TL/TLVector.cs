using MTSharp.Attributes;
using System.Collections;
using System.Collections.Generic;

namespace MTSharp.Schema.TL
{
    public class TLVector<T> : MTObject, IList<T>
    {
        [MTObject(0x1cb5c415)]
        private List<T> lists;

        public TLVector(IEnumerable<T> collection)
        {
            lists = new List<T>(collection);
        }

        public TLVector()
        {
            lists = new List<T>();
        }

        public T this[int index]
        {
            get { return lists[index]; }
            set { lists[index] = value; }
        }

        public override uint Constructor
        {
            get
            {
                return 0x1cb5c415;
            }
        }

        public int Count => lists.Count;

        public bool IsReadOnly => ((IList<T>)lists).IsReadOnly;

        public void Add(T item)
        {
            lists.Add(item);
        }

        public void Clear()
        {
            lists.Clear();
        }

        public bool Contains(T item)
        {
            return lists.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            lists.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return lists.GetEnumerator();
        }

        public int IndexOf(T item)
        {
            return lists.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            lists.Insert(index, item);
        }

        public bool Remove(T item)
        {
            return lists.Remove(item);
        }

        public void RemoveAt(int index)
        {
            lists.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return lists.GetEnumerator();
        }
    }
}
