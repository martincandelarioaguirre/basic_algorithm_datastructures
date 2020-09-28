using System;
using System.Collections.Generic;

namespace logical_exercise.DataStructures
{
    /// <summary>
    /// LinkedList is a linear data structure which consist of a group of node in sequenece
    /// </summary>
    /// <typeparam name="T">We provide T datatype</typeparam>
    public class LinkedList<T>
    {
        /// <summary>
        /// Node class contains two parts.
        /// Data - Each node of a linked list can store a data.
        /// Address - Each node of a linked list contains an address to the next node, called "Next"
        /// </summary>
        public class Node
        {
            public Node next;
            public T data;
            public Node(T new_data)
            {
                this.data = new_data;
                next = null;
            }
        }
        private Node node;

        /// <summary>
        /// Insert at the top of the linked list (Example: N1 -> N2 -> N3 -> [New-Node] )
        /// </summary>
        /// <param name="new_data">Data which will contains the node Added</param>
        public void InsertTop(T new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = node;
            node = new_node;
        }

        /// <summary>
        /// Insert at the beginning of the linked list every (Example: [New-Node] -> N1 -> N2 -> N3 )
        /// </summary>
        /// <param name="new_data">Data which will contains the node added</param>
        public void InsertFirst(T new_data)
        {
            Node new_node = new Node(new_data);
            if (node == null)
            {
                node = new_node;
                return;
            }
            Node lastNode = GetLastNode();
            lastNode.next = new_node;
        }

        /// <summary>
        /// Return the first node added to the linked list 
        /// </summary>
        /// <returns>Return the reference to the first node added to the linked list</returns>
        public Node GetLastNode()
        {
            Node temp = node;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        /// <summary>
        /// Print the data of each node contains
        /// </summary>
        public void printAllNodes()
        {
            Node current = node;
            while (current != null)
            {
                Console.WriteLine($"Data contained: {current.data}");
                current = current.next;
            }
        }
        /// <summary>
        /// Reverse the entire linked list and change the next reference of each node
        /// </summary>
        public void ReverseLinkedList()
        {
            Node prev = null;
            Node current = node;
            Node temp = null;
            while (current != null)
            {
                temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            node = prev;

        }

        /// <summary>
        /// Validate if an element exist in the linkedt list by validate each node with T key provide it
        /// </summary>
        /// <param name="key">Value to by find in the linked list</param>
        /// <returns>Value if exist or not the item in the list</returns>
        public bool ExistValue(T key)
        {
            bool exist = false;
            Node temp = node;
            var obj1 = Convert.ChangeType(key, temp.data.GetType());

            while (temp != null)
            {
                var obj2 = Convert.ChangeType(temp.data, temp.data.GetType());
                if (obj1.Equals( obj2))
                {
                    exist = true;
                }
                temp = temp.next;
            }
            return exist;
        }

        /// <summary>
        /// Remove node by Key value the first node that comes in the linked list
        /// </summary>
        /// <param name="key">Key value needed to perform the search in the linked list</param>
        public void DeleteNodeByKey(T key) {
            Node temp = node;
            Node prev = null;
            var objKey = Convert.ChangeType(key, temp.data.GetType());
            if (temp != null && Convert.ChangeType(temp.data, temp.data.GetType()).Equals(objKey)) {
                node = temp.next;
                return;
            }
            while (temp != null && !Convert.ChangeType(temp.data, temp.data.GetType()).Equals(objKey)) {
                prev = temp;
                temp = temp.next;
            }

            if (temp == null) {
                return;
            }

            prev.next = temp.next;

        }

        /// <summary>
        /// Get how many node there are in the Linked List
        /// </summary>
        /// <returns>return an intiger of total of nodes in the linked list</returns>
        public int GetCount() {
            int count = 0;
            Node temp = node;
            while (temp != null)
            {
                count ++;
                temp = temp.next;
            }
            return count;
        }

        public void Run() {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.InsertFirst(5);
            linkedList.InsertFirst(4);
            linkedList.InsertFirst(3);
            linkedList.InsertFirst(2);
            linkedList.InsertFirst(1);
            linkedList.printAllNodes();
            linkedList.InsertTop(1);
            linkedList.InsertTop(2);
            linkedList.InsertTop(3);
            linkedList.InsertTop(4);
            linkedList.InsertTop(5);
            linkedList.printAllNodes();
            linkedList.ReverseLinkedList();
            linkedList.printAllNodes();
            ConsoleUtility.WriteLine($"Data {linkedList.ExistValue(4)}");
            linkedList.DeleteNodeByKey(4);
            ConsoleUtility.WriteLine($"Data {linkedList.ExistValue(4)}");
            linkedList.printAllNodes();
            linkedList.InsertTop(10);
            linkedList.printAllNodes();
            ConsoleUtility.WriteLine($"Total of elements of the linked list {linkedList.GetCount()}");
        }

    }
}
