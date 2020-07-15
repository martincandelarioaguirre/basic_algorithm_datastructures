using System;

namespace logical_exercise.DataStructures
{
    public class DoubleLinkedList<T>
    {
        public class Node
        {
            public Node next;
            public Node prev;
            public T data;
            public Node(T new_data)
            {
                data = new_data;
                prev = null;
                next = null;
            }
        }

        private Node node;
        public void InsertTop(T new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = node;
            new_node.prev = null;
            if (node != null)
            {
                node.prev = new_node;
            }
            node = new_node;
        }

        public void InsertFirst(T data)
        {
            Node new_node = new Node(data);
            if (node == null)
            {
                new_node.prev = null;
                node = new_node;
                return;
            }
            Node lastNode = GetLastNode();
            lastNode.next = new_node;
            new_node.prev = lastNode;
        }

        public Node GetLastNode()
        {
            Node temp = node;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public void printAllNodes()
        {
            Node current = node;
            while (current != null)
            {
                Console.WriteLine($"Data contained: {current.data}");
                current = current.next;
            }
        }

        public void ReverseDoubleLinkedList()
        {
            Node tempPrev = null;
            Node tempNext = null;
            Node current = node;
            while (current != null)
            {
                tempNext = current.next;
                tempPrev = current.prev;
                current.next = tempPrev;
                current.prev = tempNext;
                tempPrev = current;
                current = tempNext;

            }
            node = tempPrev;
        }
    }
}