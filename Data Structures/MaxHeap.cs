using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns
{
    class MaxHeap : Heap
    {
        public MaxHeap(int size = 50) : base(size) { }

        public override void Heapify(int index)
        {
            int parent = (int)Math.Ceiling((index - 2) / 2d);
            int left = (index * 2) + 1;
            int right = left + 1;

            if (parent >= 0 && _heap[index][0] > _heap[parent][0])
            {
                Helpers.Swap(_heap, index, parent);
                Heapify(parent);
            }
            else if (left <= _end && _heap[index][0] < _heap[left][0])
            {
                Helpers.Swap(_heap, index, left);
                Heapify(left);
            }
            else if (right <= _end && _heap[index][0] < _heap[right][0])
            {
                Helpers.Swap(_heap, index, right);
                Heapify(right);
            }
        }

    }
}
