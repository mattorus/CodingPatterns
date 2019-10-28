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

            name = "ReverseSublist";
            Helpers.PrintStartFunctionTest(name);
            head = new ListNode(1);
            head.Next = new ListNode(2);
            head.Next.Next = new ListNode(3);
            head.Next.Next.Next = new ListNode(4);
            head.Next.Next.Next.Next = new ListNode(5);
            Helpers.PrintLinkedList(head);
            reverse = ReverseSublist(head, 2, 4);
            Helpers.PrintLinkedList(reverse);


            Helpers.PrintEndTests(testPattern);
        }

        public static ListNode ReverseSublist(ListNode head, int p, int q)
        {
            ListNode curNode = head, prev = null, next = null;
            ListNode subTail = head, subHeadPrev = null;
            int pos = 1;

            if (head == null || p == q)
            {
                return head;
            }

            while (curNode != null && pos < p)
            {
                prev = curNode;
                curNode = curNode.Next;
                pos++;
            }

            subHeadPrev = prev;
            subTail = curNode;

            while (curNode != null && pos <= q)
            {
                next = curNode.Next;
                curNode.Next = prev;
                prev = curNode;
                curNode = next;
                pos++;
            }            

            if (subHeadPrev == null)
            {
                subHeadPrev = head;
            }
             
            subHeadPrev.Next = prev;
            subTail.Next = curNode;            

            return head;
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
