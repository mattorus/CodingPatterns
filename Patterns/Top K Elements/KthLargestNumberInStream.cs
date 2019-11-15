using CodingPatterns.DataStructures;
using System;

namespace CodingPatterns.Patterns.TopKElements
{
    public class KthLargestNumberInStream
    {
        private MinHeap<int> _heap;
        private int _k;

        public KthLargestNumberInStream(int[] nums, int k)
        {
            _k = k;
            _heap = new MinHeap<int>(Constants.CompareInt);

            InitHeap(nums);
        }

        public int Add(int num)
        {
            _heap.Add(num);

            if (_heap.Count > _k)
            {
                _heap.Remove();
            }

            return _heap.Peek();
        }

        private void InitHeap(int[] nums)
        {
            if (nums == null)
            {
                throw new ArgumentNullException("Array cannot be null.");
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Add(nums[i]);
            }
        }
    }
}
