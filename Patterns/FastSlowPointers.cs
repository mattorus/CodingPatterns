using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns.Patterns
{
    class FastSlowPointers
    {

        public static void RunTests()
        {
            int[] arr;
            int num;
            ListNode result;
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

            name = "LinkedListMiddle";
            Helpers.PrintStartFunctionTest(name);
            head.Next.Next.Next.Next.Next.Next = new ListNode(6);
            result = LinkedListMiddle(head);
            Console.WriteLine($"middleNode: {(result != null ? "" + result.Val : "no middle...?")}");
            head.Next.Next.Next.Next.Next.Next.Next = new ListNode(5);
            result = LinkedListMiddle(head);
            Console.WriteLine($"middleNode: {(result != null ? "" + result.Val : "no middle...?")}");
            head.Next.Next.Next.Next.Next.Next.Next.Next = new ListNode(4);
            result = LinkedListMiddle(head);
            Console.WriteLine($"middleNode: {(result != null ? "" + result.Val : "no middle...?")}");
            head.Next.Next.Next.Next.Next.Next.Next.Next.Next = new ListNode(3);
            result = LinkedListMiddle(head);
            Console.WriteLine($"middleNode: {(result != null ? "" + result.Val : "no middle...?")}");
            head.Next.Next.Next.Next.Next.Next.Next.Next.Next.Next = new ListNode(2);
            result = LinkedListMiddle(head);
            Console.WriteLine($"middleNode: {(result != null ? "" + result.Val : "no middle...?")}");
            head.Next.Next.Next.Next.Next.Next.Next.Next.Next.Next.Next = new ListNode(1);
            result = LinkedListMiddle(head);
            Console.WriteLine($"middleNode: {(result != null ? "" + result.Val : "no middle...?")}");

            name = "IsPalindrome";
            Helpers.PrintStartFunctionTest(name);
            Helpers.PrintLinkedList(head);
            Console.WriteLine(IsPalindrome(head));
            Helpers.PrintLinkedList(head);
            head = new ListNode(2);
            head.Next = new ListNode(4);
            head.Next.Next = new ListNode(6);
            head.Next.Next.Next = new ListNode(4);
            head.Next.Next.Next.Next = new ListNode(2);
            Helpers.PrintLinkedList(head);
            Console.WriteLine(IsPalindrome(head));
            Helpers.PrintLinkedList(head);
            head.Next.Next.Next.Next.Next = new ListNode(2);
            Helpers.PrintLinkedList(head);
            Console.WriteLine(IsPalindrome(head));
            Helpers.PrintLinkedList(head);
            head = new ListNode(2);
            head.Next = new ListNode(4);
            head.Next.Next = new ListNode(6);
            head.Next.Next.Next = new ListNode(6);
            head.Next.Next.Next.Next = new ListNode(4);
            Helpers.PrintLinkedList(head);
            Console.WriteLine(IsPalindrome(head));
            Helpers.PrintLinkedList(head);
            head.Next.Next.Next.Next.Next = new ListNode(2);
            Helpers.PrintLinkedList(head);
            Console.WriteLine(IsPalindrome(head));
            Helpers.PrintLinkedList(head);

            name = "IsPalindrome";
            Helpers.PrintStartFunctionTest(name);
            head = new ListNode(1);
            head.Next = new ListNode(2);
            head.Next.Next = new ListNode(3);
            Helpers.PrintLinkedList(head);
            Console.WriteLine(IsPalindrome(head));
            Helpers.PrintLinkedList(head);
            head = new ListNode(1);
            head.Next = new ListNode(2);
            head.Next.Next = new ListNode(1);
            Helpers.PrintLinkedList(head);
            Console.WriteLine(IsPalindrome(head));
            Helpers.PrintLinkedList(head);

            name = "RearrangeLinkedList";
            Helpers.PrintStartFunctionTest(name);
            head = new ListNode(1);
            head.Next = new ListNode(3);
            head.Next.Next = new ListNode(4);
            head.Next.Next.Next = new ListNode(2);
            Helpers.PrintLinkedList(head);
            RearrangeLinkedList(head);
            Helpers.PrintLinkedList(head);
            head = new ListNode(1);
            head.Next = new ListNode(3);
            head.Next.Next = new ListNode(5);
            head.Next.Next.Next = new ListNode(4);
            head.Next.Next.Next.Next = new ListNode(2);
            Helpers.PrintLinkedList(head);
            RearrangeLinkedList(head);
            Helpers.PrintLinkedList(head);
            head = new ListNode(1);
            head.Next = new ListNode(3);
            head.Next.Next = new ListNode(5);
            head.Next.Next.Next = new ListNode(6);
            head.Next.Next.Next.Next = new ListNode(4);
            head.Next.Next.Next.Next.Next = new ListNode(2);
            Helpers.PrintLinkedList(head);
            RearrangeLinkedList(head);
            Helpers.PrintLinkedList(head);
            head = new ListNode(2);
            head.Next = new ListNode(4);
            head.Next.Next = new ListNode(6);
            head.Next.Next.Next = new ListNode(8);
            head.Next.Next.Next.Next = new ListNode(10);
            head.Next.Next.Next.Next.Next = new ListNode(12);
            Helpers.PrintLinkedList(head);
            RearrangeLinkedList(head);
            Helpers.PrintLinkedList(head);

            name = "RearrangeLinkedList";
            Helpers.PrintStartFunctionTest(name);
            arr = new int[] { 1, 2, -1, 2, 2 };
            Helpers.PrintArray(arr);
            Console.WriteLine($"->{HasCycle(arr)}");
            arr = new int[] { 2, 2, -1, 2 };
            Helpers.PrintArray(arr);
            Console.WriteLine($"->{HasCycle(arr)}");
            arr = new int[] { 2, 1, -1, -2 };
            Helpers.PrintArray(arr);
            Console.WriteLine($"->{HasCycle(arr)}");


            Helpers.PrintEndTests(testPattern);
        }

        public static bool HasCycle(int[] arr)
        {
            int fast = 0, slow = 0, posCount = 0, negCount = 0;

            if (arr == null)
            {
                return false;
            }

            // Use fast (+1 step) & slow (+2 steps) pointers and find where they meet
            do
            {
                // Array is circular, so forward & backward movements need wraparound logic: arr[0] <-> arr[arr.Length - 1]                
                slow = CircularArrayMove(slow + arr[slow], arr.Length);
                fast = CircularArrayMove(fast + arr[fast], arr.Length);
                fast = CircularArrayMove(fast + arr[fast], arr.Length);

            } while (fast != slow);

            // Move from meeting point until arrive back at meeting point, keeping track of positive & negative moves
            do
            {
                if (arr[slow] > 0)
                {
                    posCount++;
                }
                else
                {
                    negCount++;
                }

                slow = CircularArrayMove(slow + arr[slow], arr.Length);

            } while (fast != slow);
            
            return !(posCount > 0 && negCount > 0);
        }

        private static int CircularArrayMove(int num, int length)
        {
            if (num < 0)
            {
                return length + num;
            }
            else if (num >= length)
            {
                return num - length;
            }
            else
            {
                return num;
            }
        }

        public static void RearrangeLinkedList(ListNode head)
        {
            ListNode slow = head, fast = head;

            if (head == null)
            {
                return;
            }

            // Find the middle of the linked list
            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            // Reverse from the middle
            Reverse(ref slow);

            // Rearrange head -> middle -> head.next -> middle.next -> ... |
            fast = head;
            while (fast.Next != slow && fast != slow) 
            {
                ListNode fastTemp = fast.Next, slowTemp = slow.Next;
                fast.Next = slow;
                fast = fast.Next;
                fast.Next = fastTemp;
                fast = fast.Next;
                slow = slowTemp;
            }
        }

        private static void Reverse(ref ListNode head)
        {
            ListNode prev = null;

            while (head != null)
            {
                ListNode next = head.Next;
                head.Next = prev;
                prev = head;
                head = next;
            }

            head = prev;
        }

        public static bool IsPalindrome(ListNode head)
        {
            ListNode slow = head, fast = head, temp = null;
            bool isPal = true;

            if (head == null || head.Next == null)
            {
                return true;
            }

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            Reverse(ref slow);
            temp = slow;
            fast = head;

            while (slow.Next != null)
            {
                isPal = isPal && (fast.Val == slow.Val);
                slow = slow.Next;
                fast = fast.Next;
            }

            Reverse(ref temp);

            return isPal;
        }

        public static ListNode LinkedListMiddle(ListNode head)
        {
            ListNode slow = head, fast = head;

            if (head == null)
            {
                return null;
            }

            while (fast != null && fast.Next != null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;
            }

            return slow;
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
