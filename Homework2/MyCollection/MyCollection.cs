using Homework1.MyDictionary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Homework2.MyCollection
{
    public class MyCollection<T> : IEnumerable
    {
        private List<T> Collection = new();

        public void Add(T item)
        {
            Collection.Add(item);
        }

        public void Remove(T item)
        {
            if (Collection.Count>5)
            {
                Collection.Remove(item);
            }
            else
            {
                Console.WriteLine("Can't delete need more items");
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new MyCollEnumerator<T>(Collection);
        }
    }

    public class MyCollEnumerator<T> : IEnumerator
    {
        private List<T> _myColl;
        private int _currPos = -1;

        public MyCollEnumerator(List<T> myColl)
        {
            _myColl = myColl;
        }

        public object Current => _myColl[_currPos];

        public bool MoveNext()
        {
            _currPos++;
            return _currPos<_myColl.Count;
        }

        public void Reset()
        {
            _currPos = -1;
        }
    }
}
