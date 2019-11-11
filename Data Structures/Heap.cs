using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns
{
    abstract class Heap<T>: IComparer<T>
    {
        protected int _end;
        protected T[] _heap;
        protected static int _minSize = 50;

        protected Comparison<T> _comparison;

        public int Count { get { return _end; } }

        public Heap(Comparison<T> comparison = default, int size = 50)
        {
            if (comparison == null)
            {
                _comparison = default;
            }
            else
            {
                _comparison = comparison;

            }

            _heap = new T[(size < _minSize ? _minSize : size)];
            _end = 0;
        }

        public int Compare(T x, T y)
        {
            return _comparison(x, y);
        }

        public T Peek()
        {
            if (_end == 0)
            {
                throw new NullReferenceException("Heap is empty.");
            }

            return _heap[0];
        }

        public void Add(T nums)
        {
            _heap[_end] = nums;
            HeapifyUp();
            _end++;

            if (_end == _heap.Length)
            {
                Grow();
            }
        }

        public T Remove()
        {
            T root = _heap[0];

            if (_end == 0)
            {
                return default;
            }

            _end--;
            _heap[0] = _heap[_end];
            
            HeapifyDown();

            return root;
        }

        public abstract void HeapifyUp();
        public abstract void HeapifyDown();

        private void Grow()
        {
            T[] tempHeap = new T[(_heap.Length * 2) + 1];

            Array.Copy(_heap, 0, tempHeap, 0, _heap.Length);
            _heap = tempHeap;
        }

        protected string GetString(T item, string delimiter)
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (item.GetType() == typeof(int[]))
            {
                var array = (item as int[]);

                for (int i = 0; i < array.Length; i++)
                {
                    stringBuilder.Append(array[i]);

                    if (i != array.Length - 1)
                    {
                        stringBuilder.Append(delimiter);
                    }
                }
            }
            else
            {
                stringBuilder.Append(item.ToString());
            }

            return stringBuilder.ToString();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("  [");

            for (int i = 0; i < _end; i++)
            {
                string str;

                if (_heap is IEnumerable<T>)
                {
                    str = GetString(_heap[i], ",");
                }
                else
                {
                    str = String.Join(",", _heap[i]);
                }

                stringBuilder.Append($"[{str}]");

                if (i != _end - 1)
                {
                    stringBuilder.Append(", ");
                }
            }

            stringBuilder.Append("]");

            return stringBuilder.ToString();
        }
    }    
}
