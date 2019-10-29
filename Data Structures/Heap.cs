using System;
using System.Collections.Generic;
using System.Linq;
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
                comparison = default;
            }

            _comparison = comparison;
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
                return default;
            }

            return _heap[0];
        }

        public void Add(T nums)
        {
            _heap[_end] = nums;
            Heapify(_end);
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
            
            Heapify(0);

            return root;
        }

        public abstract void Heapify(int index);

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

    static class HeapTest
    {
        public static void RunTests()
        {
            MaxHeap<int[]> maxHeap;
            MinHeap<int[]> minHeap;
            int[] nums;
            
            maxHeap = new MaxHeap<int[]>((x, y) => x[0].CompareTo(y[0]));
            minHeap = new MinHeap<int[]>((x, y) => x[1].CompareTo(y[1]));
            Console.WriteLine(maxHeap.ToString());
            Console.WriteLine(minHeap.ToString());
            nums = new int[] { 4, 5 };
            maxHeap.Add(nums);
            minHeap.Add(nums);
            Console.WriteLine(maxHeap.ToString());
            Console.WriteLine(minHeap.ToString());
            nums = new int[] { 2, 3 };
            maxHeap.Add(nums);
            minHeap.Add(nums);
            Console.WriteLine(maxHeap.ToString());
            Console.WriteLine(minHeap.ToString());
            nums = new int[] { 2, 4 };
            maxHeap.Add(nums);
            minHeap.Add(nums);
            Console.WriteLine(maxHeap.ToString());
            Console.WriteLine(minHeap.ToString());
            nums = new int[] { 3, 5 };
            maxHeap.Add(nums);
            minHeap.Add(nums);
            Console.WriteLine(maxHeap.ToString());
            Console.WriteLine(minHeap.ToString());
            //maxHeap.Add(9);
            //minHeap.Add(9);
            //Console.WriteLine(maxHeap.ToString());
            //Console.WriteLine(minHeap.ToString());
            //maxHeap.Add(4);
            //minHeap.Add(4);
            //Console.WriteLine(maxHeap.ToString());
            //Console.WriteLine(minHeap.ToString());
            //maxHeap.Add(25);
            //minHeap.Add(25);
            //Console.WriteLine(maxHeap.ToString());
            //Console.WriteLine(minHeap.ToString());
            //maxHeap.Add(8);
            //minHeap.Add(8);
            //Console.WriteLine(maxHeap.ToString());
            //Console.WriteLine(minHeap.ToString());
            //maxHeap.Add(6);
            //minHeap.Add(6);
            //Console.WriteLine(maxHeap.ToString());
            //Console.WriteLine(minHeap.ToString());
            //maxHeap.Add(3);
            //minHeap.Add(3);
            //Console.WriteLine(maxHeap.ToString());
            //Console.WriteLine(minHeap.ToString());
            //maxHeap.Add(12);
            //minHeap.Add(12);
            //Console.WriteLine(maxHeap.ToString());
            //Console.WriteLine(minHeap.ToString());
            //maxHeap.Add(7);
            //minHeap.Add(7);
            //Console.WriteLine(maxHeap.ToString());
            //Console.WriteLine(minHeap.ToString());
            //maxHeap.Add(0);
            //minHeap.Add(0);
            //Console.WriteLine(maxHeap.ToString());
            //Console.WriteLine(minHeap.ToString());
        }

    }
}
