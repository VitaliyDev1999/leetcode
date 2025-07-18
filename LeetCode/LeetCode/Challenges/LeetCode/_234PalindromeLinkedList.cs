namespace LeetCode.Challenges.LeetCode
{
    //ref https://leetcode.com/problems/palindrome-linked-list/description/
    public static class _234PalindromeLinkedList
    {
        public static bool IsPalindrome(ListNode head)
        {
            Stack<int> stack = new Stack<int>();

            ListNode curr  = head;
            while (curr != null)
            {
                stack.Push(curr.val);
                curr = curr.next;
            }

            curr = head;
            while (curr != null)
            {
                if(curr.val != stack.Pop())
                {
                    return false;
                }
                curr = curr.next;
            }
             
            return true;
        }

        #region Fast and Slow
        public static bool IsPalindromeFastAndSlow(ListNode head)
        {
            if (head == null || head.next == null) return true;

            // 1. Fast & Slow указатели
            ListNode slow = head, fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            // 2. Reverse вторая половина
            ListNode secondHalf = Reverse(slow);

            // 3. Сравнение
            ListNode p1 = head, p2 = secondHalf;
            while (p2 != null)
            {
                if (p1.val != p2.val) return false;
                p1 = p1.next;
                p2 = p2.next;
            }

            return true;
        }

        private static ListNode Reverse(ListNode head)
        {
            ListNode prev = null;
            while (head != null)
            {
                ListNode next = head.next;
                head.next = prev;
                prev = head;
                head = next;
            }
            return prev;
        }
        #endregion

        #region Recursively
        static ListNode frontPointer;
        public static bool IsPalindromeRecursively(ListNode head)
        {
            frontPointer = head;
            return RecursivelyCheck(head);
        }

        private static bool RecursivelyCheck(ListNode current)
        {
            if (current == null) return true;

            // Проходим до конца
            if (!RecursivelyCheck(current.next))
                return false;

            // Сравниваем симметричные элементы
            if (frontPointer.val != current.val)
                return false;

            frontPointer = frontPointer.next;
            return true;
        }
        #endregion
    }
}
