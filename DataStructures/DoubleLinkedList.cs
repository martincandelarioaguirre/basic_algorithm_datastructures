using System;

namespace logical_exercise.DataStructures {
    public class DoubleLinkedList {
        private class Node {
            public Node next;
            public Node prev;
            public int data;
            public Node (int new_data) {
                data = new_data;
                prev = null;
                next = null;
            }
        }

        private Node node;
        private void InsertTop (int new_data) {
            Node new_node = new Node (new_data);
            new_node.next = node;
            new_node.prev = null;
            if (node != null) {
                node.prev = new_node;
            }
            node = new_node;
        }

        private void InsertFirst (int data) {
            Node new_node = new Node (data);
            if (node == null) {
                new_node.prev = null;
                node = new_node;
                return;
            }
            Node lastNode = GetLastNode ();
            lastNode.next = new_node;
            new_node.prev = lastNode;
        }

        private Node GetLastNode () {
            Node temp = node;
            while (temp.next != null) {
                temp = temp.next;
            }
            return temp;
        }

        private void printAllNodes () {
            Node current = node;
            while (current != null) {
                ConsoleUtility.WriteLine ($"Data contained: {current.data}");
                current = current.next;
            }
        }

        private void ReverseDoubleLinkedList () {
            Node tempPrev = null;
            Node tempNext = null;
            Node current = node;
            while (current != null) {
                tempNext = current.next;
                tempPrev = current.prev;
                current.next = tempPrev;
                current.prev = tempNext;
                tempPrev = current;
                current = tempNext;

            }
            node = tempPrev;
        }

        public void Run () {
            DoubleLinkedList doubleLinkedList = new DoubleLinkedList ();
            doubleLinkedList.InsertTop (1);
            doubleLinkedList.InsertTop (2);
            doubleLinkedList.InsertTop (3);
            doubleLinkedList.InsertTop (4);
            doubleLinkedList.InsertTop (5);
            doubleLinkedList.printAllNodes ();
            doubleLinkedList.ReverseDoubleLinkedList ();
            doubleLinkedList.printAllNodes ();
        }

    }
}