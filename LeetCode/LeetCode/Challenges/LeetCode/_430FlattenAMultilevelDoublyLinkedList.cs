namespace LeetCode.Challenges.LeetCode
{
    // Definition for a Node.
    public class Node
    {
        public int val;
        public Node prev;
        public Node next;
        public Node child;

        public Node(int val)
        {
            this.val = val;
        }
    }

    //ref https://leetcode.com/problems/flatten-a-multilevel-doubly-linked-list
    public class _430FlattenAMultilevelDoublyLinkedList
    {
        //Algo:DFS 
        /*
        Обьявляем Stack<Node> stack = new Stack<Node>(); и ложим туда head stack.Push(head)
        Создаем dummy спомогательный узел
        Создаем переменную prev = dummy;
        В цикле while Node curr = stack.Pop();
        Дальше соединяем prev <-> curr
        Если есть next — сначала его в стек
        Если есть child — кладём поверх next и очищаем child ссылку
        В конце цыкла prev = curr;
        Убираем ссылку с dummy dummy.next.prev = null; и возращаем dummy next
        */
        public Node Flatten(Node head)
        {
            if (head == null) return null;

            Stack<Node> stack = new Stack<Node>();
            stack.Push(head);

            Node dummy = new Node(0); // Вспомогательный узел
            Node prev = dummy;

            while (stack.Count > 0)
            {
                Node curr = stack.Pop();

                // Соединяем prev <-> curr
                prev.next = curr;
                curr.prev = prev;

                // Если есть next — сначала его в стек
                if (curr.next != null)
                {
                    stack.Push(curr.next);
                }

                // Если есть child — кладём поверх next
                if (curr.child != null)
                {
                    stack.Push(curr.child);
                    curr.child = null; // очищаем ссылку
                }

                prev = curr;
            }

            // Убираем ссылку с dummy
            dummy.next.prev = null;
            return dummy.next;
        }

        #region TestData
        public Node BuildSample1()
        {
            // Level 1
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);

            n1.next = n2; n2.prev = n1;
            n2.next = n3; n3.prev = n2;
            n3.next = n4; n4.prev = n3;
            n4.next = n5; n5.prev = n4;
            n5.next = n6; n6.prev = n5;

            // Level 2 (child of 3)
            Node n7 = new Node(7);
            Node n8 = new Node(8);
            Node n9 = new Node(9);
            Node n10 = new Node(10);

            n7.next = n8; n8.prev = n7;
            n8.next = n9; n9.prev = n8;
            n9.next = n10; n10.prev = n9;

            n3.child = n7;

            // Level 3 (child of 8)
            Node n11 = new Node(11);
            Node n12 = new Node(12);

            n11.next = n12; n12.prev = n11;

            n8.child = n11;

            return n1;
        }

        public Node BuildSample2()
        {
            // Level 1
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            n1.next = n2; n2.prev = n1;

            // Level 2 (child of 1)
            Node n3 = new Node(3);
            n1.child = n3;

            return n1;
        }
        #endregion
    }
}
