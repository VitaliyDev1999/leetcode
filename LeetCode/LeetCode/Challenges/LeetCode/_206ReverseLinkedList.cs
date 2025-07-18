namespace LeetCode.Challenges.LeetCode
{
    //ref https://leetcode.com/problems/reverse-linked-list
    public static class _206ReverseLinkedList
    {
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null)
                return head;

            Stack<ListNode> stack = new Stack<ListNode>();
            ListNode current = head;

            // Пушим все узлы в стек
            while (current != null)
            {
                stack.Push(current);
                current = current.next;
            }

            ListNode newHead = stack.Pop();
            current = newHead;

            while (stack.Count > 0) { 
                current.next = stack.Pop();
                current = current.next;
            }

            current.next = null; // Важно! последний элемент должен указывать на null
            return newHead;
        }

        public static ListNode ReverseListSimplified(ListNode head)
        {
            ListNode prev = null;
            ListNode current = head;

            while (current != null)
            {
                ListNode next = current.next; // сохранить следующий узел
                current.next = prev;          // реверс связи
                prev = current;               // сдвиг prev
                current = next;               // сдвиг current
            }

            return prev; // prev теперь — новый head
        }
    }
}
