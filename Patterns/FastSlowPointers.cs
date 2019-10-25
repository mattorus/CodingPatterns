using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns.Patterns
{
    class FastSlowPointers
    {

        public static void RunTests()
        {
            int num;
            string testPattern = "FASTSLOWPOINTERS";
            Helpers.PrintStartTests(testPattern);

            string name = "IsCyclicLinkedList";
            Helpers.PrintStartFunctionTest(name);
            ListNode head = new ListNode(10);
            head.Next = new ListNode(8);
            head.Next.Next = new ListNode(7);
            head.Next.Next.Next = new ListNode(6);
            head.Next.Next.Next = head;
            Console.WriteLine(IsCyclicLinkedList(head));
            head.Next.Next.Next = new ListNode(5);
            Console.WriteLine(IsCyclicLinkedList(head));
            head.Next.Next.Next.Next = new ListNode(4);
            Console.WriteLine(IsCyclicLinkedList(head));
            head.Next.Next.Next = head.Next;
            Console.WriteLine(IsCyclicLinkedList(head));
            head = new ListNode(1);
            head.Next = new ListNode(2);
            head.Next.Next = new ListNode(3);
            head.Next.Next.Next = new ListNode(4);
            head.Next.Next.Next.Next = new ListNode(5);
            head.Next.Next.Next.Next.Next = new ListNode(6);
            Console.WriteLine(IsCyclicLinkedList(head));
            head.Next.Next.Next.Next.Next.Next = head.Next.Next;
            Console.WriteLine(IsCyclicLinkedList(head));
            head.Next.Next.Next.Next.Next.Next = head.Next.Next.Next;
            Console.WriteLine(IsCyclicLinkedList(head));

            name = "LinkedListCycleStart";
            Helpers.PrintStartFunctionTest(name);
            ListNode cycleNode = LinkedListCycleStart(head);
            Console.WriteLine($"cycleNode: {(cycleNode != null ? "" + cycleNode.Val : "no cycle")}");
            head.Next.Next.Next.Next.Next.Next = head.Next.Next;
            cycleNode = LinkedListCycleStart(head);
            Console.WriteLine($"cycleNode: {(cycleNode != null ? "" + cycleNode.Val : "no cycle")}");

            name = "IsHappyNumber";
            Helpers.PrintStartFunctionTest(name);
            num = 23;
            Console.WriteLine($"Is {num} happy? {IsHappyNumber(num)}");
            num = 12;
            Console.WriteLine($"Is {num} happy? {IsHappyNumber(num)}");
            num = 50;
            Console.WriteLine($"Is {num} happy? {IsHappyNumber(num)}");
            num = 100;
            Console.WriteLine($"Is {num} happy? {IsHappyNumber(num)}");
            num = 89496481;
            Console.WriteLine($"Is {num} happy? {IsHappyNumber(num)}");
            num = 2;
            Console.WriteLine($"Is {num} happy? {IsHappyNumber(num)}");
            num = 9;
            Console.WriteLine($"Is {num} happy? {IsHappyNumber(num)}");
            num = 15;
            Console.WriteLine($"Is {num} happy? {IsHappyNumber(num)}");
            num = 8654;
            Console.WriteLine($"Is {num} happy? {IsHappyNumber(num)}");
            num = 59412;
            Console.WriteLine($"Is {num} happy? {IsHappyNumber(num)}");


            Helpers.PrintEndTests(testPattern);
        }

        public static bool IsHappyNumber(int n)
        {
            int squareSum = n, squareSumFast = n;
            HashSet<int> squaredSums = new HashSet<int>();

            do
            {
                squareSum = SquareDigitSum(squareSum);
                squareSumFast = SquareDigitSum(SquareDigitSum(squareSumFast));
            } while (squareSum != squareSumFast);
            
            return squareSum == 1;
        }

        private static int SquareDigitSum(int n)
        {
            int sum = 0;

            while (n > 0)
            {
                int r = n % 10;
                sum += r * r;
                n /= 10;
            }

            return sum;
        }

        public static ListNode LinkedListCycleStart(ListNode head)
        {
            // Tun fast & slow algorithm until meet at stopNode. 
            // Then set curNode to head & loop until finding curNode or stopNode.
            // If curNode, return curNode
            // If stopNode, curNode = curNode.Next, and loop again

            ListNode curNode = head;
            ListNode stopNode = FindCycle(head);
            ListNode runner = head;

            if (stopNode == null)
            {
                return null; // No cycle found
            }

            runner = stopNode;
            while (true)
            {
                runner = runner.Next;
                if (runner == curNode)
                {
                    return curNode;
                }

                if (runner == stopNode)
                {
                    curNode = curNode.Next;
                }
            }
        }

        private static ListNode FindCycle(ListNode head)
        {
            ListNode slow = head, fast = head;

            while (fast != null && fast.Next != null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;

                if (slow == fast)
                {
                    return slow;
                }
            }

            return null;
        }
    
        public static bool IsCyclicLinkedList(ListNode head)
        {
            ListNode slow = head, fast = head;

            while (fast != null && fast.Next != null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;

                if (slow == fast)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
