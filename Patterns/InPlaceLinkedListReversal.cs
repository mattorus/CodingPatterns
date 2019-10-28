using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns.Patterns
{
    class InPlaceLinkedListReversal
    {
        public static void RunTests()
        {
            string name;
            ListNode head, reverse;
            string testPattern = "RUNTESTS";
            Helpers.PrintStartTests(testPattern);

            name = "Reverse";
            Helpers.PrintStartFunctionTest(name);
            head = new ListNode(2);
            head.Next = new ListNode(4);
            head.Next.Next = new ListNode(6);
            head.Next.Next.Next = new ListNode(8);
            head.Next.Next.Next.Next = new ListNode(10);
            Helpers.PrintLinkedList(head);
            reverse = Reverse(head);
            Helpers.PrintLinkedList(reverse);
            Helpers.PrintLinkedList(head);


            Helpers.PrintEndTests(testPattern);
        }

        public static ListNode Reverse(ListNode head)
        {
            ListNode prev = null, next = null;

            while (head != null)
            {
                next = head.Next;
                head.Next = prev;
                prev = head;
                head = next;
            }

            return prev;
        }

    }
}
