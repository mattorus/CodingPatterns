using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns
{
    class ListNode
    {
        public int Val { get; set; }
        public ListNode Next { get; set; }

        public ListNode(int val = -1, ListNode next = null)
        {
            Val = val;
            Next = next;
        }
    }
}
