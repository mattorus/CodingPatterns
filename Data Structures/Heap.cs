﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns
{
    abstract class Heap
    {
        protected int _end;
        protected int[] _heap;
        protected static int _minSize = 5;

        public int Count { get { return _end; } }

        public Heap(int size = 5)
        {
            _heap = new int[(size < _minSize ? _minSize : size)];
            _end = 0;
        }

        public void Add(int num)
        {
            _heap[_end] = num;
            Heapify(_end);
            _end++;

            if (_end == _heap.Length)
            {
                Grow();
            }
        }

        public int Remove()
        {
            int root = _heap[0];
            if (_end == 0)
            {
                return Int32.MinValue;
            }

            _heap[0] = _heap[--_end];
            Heapify(0);

            return root;
        }

        public abstract void Heapify(int index);

        private void Grow()
        {
            int[] tempHeap = new int[(_heap.Length * 2) + 1];

            Array.Copy(_heap, 0, tempHeap, 0, _heap.Length);
            _heap = tempHeap;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("  [");
            for (int i = 0; i < _end; i++)
            {
                stringBuilder.Append(_heap[i]);
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
            MaxHeap maxHeap = new MaxHeap(0);
            MinHeap minHeap = new MinHeap(0);
            Console.WriteLine(maxHeap.ToString());
            Console.WriteLine(minHeap.ToString());
            maxHeap.Add(3);
            minHeap.Add(3);
            Console.WriteLine(maxHeap.ToString());
            Console.WriteLine(minHeap.ToString());
            maxHeap.Add(1);
            minHeap.Add(1);
            Console.WriteLine(maxHeap.ToString());
            Console.WriteLine(minHeap.ToString());
            maxHeap.Add(2);
            minHeap.Add(2);
            Console.WriteLine(maxHeap.ToString());
            Console.WriteLine(minHeap.ToString());
            maxHeap.Add(5);
            minHeap.Add(5);
            Console.WriteLine(maxHeap.ToString());
            Console.WriteLine(minHeap.ToString());
            maxHeap.Add(9);
            minHeap.Add(9);
            Console.WriteLine(maxHeap.ToString());
            Console.WriteLine(minHeap.ToString());
            maxHeap.Add(4);
            minHeap.Add(4);
            Console.WriteLine(maxHeap.ToString());
            Console.WriteLine(minHeap.ToString());
            maxHeap.Add(25);
            minHeap.Add(25);
            Console.WriteLine(maxHeap.ToString());
            Console.WriteLine(minHeap.ToString());
            maxHeap.Add(8);
            minHeap.Add(8);
            Console.WriteLine(maxHeap.ToString());
            Console.WriteLine(minHeap.ToString());
            maxHeap.Add(6);
            minHeap.Add(6);
            Console.WriteLine(maxHeap.ToString());
            Console.WriteLine(minHeap.ToString());
            maxHeap.Add(3);
            minHeap.Add(3);
            Console.WriteLine(maxHeap.ToString());
            Console.WriteLine(minHeap.ToString());
            maxHeap.Add(12);
            minHeap.Add(12);
            Console.WriteLine(maxHeap.ToString());
            Console.WriteLine(minHeap.ToString());
            maxHeap.Add(7);
            minHeap.Add(7);
            Console.WriteLine(maxHeap.ToString());
            Console.WriteLine(minHeap.ToString());
            maxHeap.Add(0);
            minHeap.Add(0);
            Console.WriteLine(maxHeap.ToString());
            Console.WriteLine(minHeap.ToString());
        }

    }
}
