using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns
{
    class MaxHeap<T> : Heap<T>
    {
        public MaxHeap(Comparison<T> comparison = default, int size = 50) : base(comparison, size) { }

        public override void Heapify(int index)
        {
            int parent = (int)Math.Ceiling((index - 2) / 2d);
            int left = (index * 2) + 1;
            int right = left + 1;

            if (parent >= 0 && Compare(_heap[index], _heap[parent]) > 0)
            {
                Helpers.Swap(_heap, index, parent);
                Heapify(parent);
            }
            else if (left < _end && Compare(_heap[index], _heap[parent]) < 0)
            {
                Helpers.Swap(_heap, index, left);
                Heapify(left);
            }
            else if (right < _end && Compare(_heap[index], _heap[parent]) < 0)
            {
                Helpers.Swap(_heap, index, right);
                Heapify(right);
            }
        }

    }
}
