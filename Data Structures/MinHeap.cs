using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns.DataStructures
{
    class MinHeap<T> : Heap<T>
    {
        public MinHeap(Comparison<T> comparison = default, int size = 50) : base(comparison, size) { }

        public override void HeapifyUp()
        {
            int index = _end;

            while (HasParent(index) && Compare(_heap[index], Parent(index)) < 0)
            {
                Helpers.Swap(_heap, index, GetParentIndex(index));
                index = GetParentIndex(index);
            }
        }

        public override void HeapifyDown()
        {
            int index = 0;

            while (HasLeftChild(index))
            {
                int smallerChildIndex = GetLeftChildIndex(index);

                if (HasRightChild(index) && Compare(RightChild(index), LeftChild(index)) < 0)
                {
                    smallerChildIndex = GetRightChildIndex(index);
                }

                if (Compare(_heap[index], _heap[smallerChildIndex]) < 0)
                {
                    break;
                }
                else
                {
                    Helpers.Swap(_heap, index, smallerChildIndex);
                    index = smallerChildIndex;
                }
            }
        }
    }
}
