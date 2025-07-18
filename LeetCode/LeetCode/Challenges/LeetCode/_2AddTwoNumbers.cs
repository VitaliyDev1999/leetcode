namespace LeetCode.Challenges.LeetCode
{
    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    //ref https://leetcode.com/problems/add-two-numbers/
    public class _2AddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode current = dummyHead;
            int leftover = 0;

            while (l1 != null || l2 != null || leftover > 0)
            {
                int val1 = l1?.val ?? 0;
                int val2 = l2?.val ?? 0;

                var sum = val1 + val2 + leftover;
                leftover = sum / 10;

                current.next = new ListNode(sum % 10);
                current = current.next;

                l1 = l1?.next;
                l2 = l2?.next;
            }

            return dummyHead.next;
        }
    }
}
