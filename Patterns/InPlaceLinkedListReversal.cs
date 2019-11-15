using CodingPatterns.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns.Patterns
{
    class InPlaceLinkedListReversal
    {
        public static void RunTests()
        {
            int k;
            string name;
            ListNode head, reverse;
            string testPattern = "INPLACELINKEDLISTREVERSAL";
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
            head = new ListNode(3);
            head.Next = new ListNode(2);
            head.Next.Next = new ListNode(1);
            head.Next.Next.Next = new ListNode(6);
            head.Next.Next.Next.Next = new ListNode(5);
            head.Next.Next.Next.Next.Next = new ListNode(4);
            head.Next.Next.Next.Next.Next.Next = new ListNode(9);
            head.Next.Next.Next.Next.Next.Next.Next = new ListNode(8);
            head.Next.Next.Next.Next.Next.Next.Next.Next = new ListNode(7);
            Helpers.PrintLinkedList(head);
            reverse = ReverseSublist(head, 1, 9);
            Helpers.PrintLinkedList(reverse);

            name = "ReverseKSublists";
            Helpers.PrintStartFunctionTest(name);
            head = new ListNode(3);
            head.Next = new ListNode(2);
            head.Next.Next = new ListNode(1);
            head.Next.Next.Next = new ListNode(6);
            head.Next.Next.Next.Next = new ListNode(5);
            head.Next.Next.Next.Next.Next = new ListNode(4);
            head.Next.Next.Next.Next.Next.Next = new ListNode(9);
            head.Next.Next.Next.Next.Next.Next.Next = new ListNode(8);
            head.Next.Next.Next.Next.Next.Next.Next.Next = new ListNode(7);
            k = 3;
            Helpers.PrintLinkedList(head);
            reverse = ReverseKSublists(head, k);
            Helpers.PrintLinkedList(reverse);
            head = new ListNode(3);
            head.Next = new ListNode(2);
            head.Next.Next = new ListNode(1);
            head.Next.Next.Next = new ListNode(6);
            head.Next.Next.Next.Next = new ListNode(5);
            head.Next.Next.Next.Next.Next = new ListNode(4);
            head.Next.Next.Next.Next.Next.Next = new ListNode(9);
            head.Next.Next.Next.Next.Next.Next.Next = new ListNode(8);
            head.Next.Next.Next.Next.Next.Next.Next.Next = new ListNode(7);
            head.Next.Next.Next.Next.Next.Next.Next.Next.Next = new ListNode(11);
            head.Next.Next.Next.Next.Next.Next.Next.Next.Next.Next = new ListNode(10);
            k = 3;
            Helpers.PrintLinkedList(head);
            reverse = ReverseKSublists(head, k);
            Helpers.PrintLinkedList(reverse);
            head = new ListNode(3);
            head.Next = new ListNode(2);
            head.Next.Next = new ListNode(1);
            k = 4;
            Helpers.PrintLinkedList(head);
            reverse = ReverseKSublists(head, k);
            Helpers.PrintLinkedList(reverse); 
            head = new ListNode(1);
            head.Next = new ListNode(2);
            head.Next.Next = new ListNode(3);
            head.Next.Next.Next = new ListNode(4);
            head.Next.Next.Next.Next = new ListNode(5);
            head.Next.Next.Next.Next.Next = new ListNode(6);
            head.Next.Next.Next.Next.Next.Next = new ListNode(7);
            head.Next.Next.Next.Next.Next.Next.Next = new ListNode(8);
            k = 3;
            Helpers.PrintLinkedList(head);
            reverse = ReverseKSublists(head, k);
            Helpers.PrintLinkedList(reverse);

            name = "ReverseAltKSublists";
            Helpers.PrintStartFunctionTest(name);
            head = new ListNode(2);
            head.Next = new ListNode(1);
            head.Next.Next = new ListNode(3);
            head.Next.Next.Next = new ListNode(4);
            head.Next.Next.Next.Next = new ListNode(6);
            head.Next.Next.Next.Next.Next = new ListNode(5);
            head.Next.Next.Next.Next.Next.Next = new ListNode(7);
            head.Next.Next.Next.Next.Next.Next.Next = new ListNode(8);
            head.Next.Next.Next.Next.Next.Next.Next.Next = new ListNode(9);
            k = 2;
            Helpers.PrintLinkedList(head);
            reverse = ReverseAltKSublists(head, k);
            Helpers.PrintLinkedList(reverse);
            head = new ListNode(3);
            head.Next = new ListNode(2);
            head.Next.Next = new ListNode(1);
            head.Next.Next.Next = new ListNode(4);
            head.Next.Next.Next.Next = new ListNode(5);
            head.Next.Next.Next.Next.Next = new ListNode(6);
            head.Next.Next.Next.Next.Next.Next = new ListNode(9);
            head.Next.Next.Next.Next.Next.Next.Next = new ListNode(8);
            head.Next.Next.Next.Next.Next.Next.Next.Next = new ListNode(7);
            head.Next.Next.Next.Next.Next.Next.Next.Next.Next = new ListNode(10);
            head.Next.Next.Next.Next.Next.Next.Next.Next.Next.Next = new ListNode(11);
            k = 3;
            Helpers.PrintLinkedList(head);
            reverse = ReverseAltKSublists(head, k);
            Helpers.PrintLinkedList(reverse);
            head = new ListNode(3);
            head.Next = new ListNode(2);
            head.Next.Next = new ListNode(1);
            head.Next.Next.Next = new ListNode(4);
            head.Next.Next.Next.Next = new ListNode(5);
            head.Next.Next.Next.Next.Next = new ListNode(6);
            head.Next.Next.Next.Next.Next.Next = new ListNode(8);
            head.Next.Next.Next.Next.Next.Next.Next = new ListNode(7);
            k = 3;
            Helpers.PrintLinkedList(head);
            reverse = ReverseAltKSublists(head, k);
            Helpers.PrintLinkedList(reverse);
            head = new ListNode(4);
            head.Next = new ListNode(3);
            head.Next.Next = new ListNode(2);
            head.Next.Next.Next = new ListNode(1);
            head.Next.Next.Next.Next = new ListNode(5);
            head.Next.Next.Next.Next.Next = new ListNode(6);
            head.Next.Next.Next.Next.Next.Next = new ListNode(7);
            head.Next.Next.Next.Next.Next.Next.Next = new ListNode(8);
            head.Next.Next.Next.Next.Next.Next.Next.Next = new ListNode(11);
            head.Next.Next.Next.Next.Next.Next.Next.Next.Next = new ListNode(10);
            head.Next.Next.Next.Next.Next.Next.Next.Next.Next.Next = new ListNode(9);
            k = 4;
            Helpers.PrintLinkedList(head);
            reverse = ReverseAltKSublists(head, k);
            Helpers.PrintLinkedList(reverse);


            Helpers.PrintEndTests(testPattern);
        }

        public static ListNode ReverseAltKSublists(ListNode head, int k)
        {
            ListNode curNode = head, prev = null, next = null;
            ListNode subPrev = null, subTail = null;

            if (head == null || k <= 1)
            {
                return head;
            }

            while (curNode != null)
            {
                subPrev = prev;
                subTail = curNode;

                for (int i = 0; curNode != null && i < k; i++)
                {
                    next = curNode.Next;
                    curNode.Next = prev;
                    prev = curNode;
                    curNode = next;
                }

                if (subPrev != null)
                {
                    subPrev.Next = prev;
                }
                else
                {
                    head = prev;
                }

                subTail.Next = curNode;

                for (int i = 0; curNode != null && i < k; i++)
                {
                    prev = curNode;
                    curNode = curNode.Next;
                }
            }

            return head;
        }

        public static ListNode ReverseKSublists(ListNode head, int k)
        {
            ListNode curNode = head, prev = null, next = null;
            ListNode subTail = null, subHeadPrev = null;

            if (head == null || k <= 1)
            {
                return head;
            }

            while (curNode != null)
            {
                subHeadPrev = prev;
                subTail = curNode;

                for (int i = 0; curNode != null && i < k; i++)
                {
                    next = curNode.Next;
                    curNode.Next = prev;
                    prev = curNode;
                    curNode = next;
                }

                if (subHeadPrev != null)
                {
                    subHeadPrev.Next = prev;
                }
                else
                {
                    head = prev;
                }

                subTail.Next = curNode;
                prev = subTail;
            }

            return head;
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

            if (subHeadPrev != null)
            {
                subHeadPrev.Next = prev;
            }
            else
            {
                head = prev;
            }
            
            
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
