using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns
{
    class MaxHeap<T> : Heap<T>
    {
        public MaxHeap(Comparison<T> comparison = default, int size = 50) : base(comparison, size) { }

        public override void HeapifyUp()
        {
            int index = _end;
            int parent = (int)Math.Ceiling((index - 2) / 2d);

            while (parent >= 0 && Compare(_heap[index], _heap[parent]) > 0)
            {
                Helpers.Swap(_heap, index, parent);
                index = parent;
                parent = (int)Math.Ceiling((index - 2) / 2d);
            }
        }

        public override void HeapifyDown()
        {
            int index = 0;

            while (true)
            {
                int left = (index * 2) + 1;
                int right = left + 1;

                if (left <= _end && Compare(_heap[index], _heap[left]) < 0)
                {
                    Helpers.Swap(_heap, index, left);
                    index = left;
                }
                else if (right <= _end && Compare(_heap[index], _heap[right]) < 0)
                {
                    Helpers.Swap(_heap, index, right);
                    index = right;
                }
                else
                {
                    break;
                }
            }
        }

    }
}
