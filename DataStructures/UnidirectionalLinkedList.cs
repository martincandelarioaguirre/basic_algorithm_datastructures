using System;

namespace logical_exercise.DataStructuresBook
{
    public class Node
    {
        public string data;
        public Node next;

        public Node(string data, Node next)
        {
            this.data = data;
            this.next = next;
        }
    }

    public class UnidirectionalLinkedList
    {
        private static Node head;
        private static Node tail;

        public void Run()
        {
            Init();
            // Console.WriteLine($"Append a new node name: Walnut to the end: ");
            // Add(new Node("Walnut", null));
            // Console.WriteLine($"Insert a new node Walnut at index = 2 \n");
            // Insert(2, new Node("Walnut", null));
            //Remove(2);
            Print(head);
        }

        public static Node Init()
        {
            // The first node called head node.
            head = new Node("San Francisco", null);
            Node nodeOakland = new Node("Oackland", null);
            head.next = nodeOakland;
            Node nodeBerkeley = new Node("Berkeley", null);
            nodeOakland.next = nodeBerkeley;
            // The last node called tail node
            tail = new Node("Fremont", null);
            nodeBerkeley.next = tail;
            return head;
        }

        public static void Print(Node node)
        {
            Node p = node;
            while (p != null) // From the beginning to the end
            {
                Console.WriteLine($"{p.data} ->");
                p = p.next;
            }
            Console.WriteLine("End");
        }

        public static void Add(Node newNode)
        {
            tail.next = newNode;
            tail = newNode;
        }

        public static void Insert(int insertPosition, Node newNode)
        {
            Node p = head;
            int i = 0;
            while (p.next != null && i < insertPosition - 1)
            {
                p = p.next;
                i++;
            }
            // newNode next point to next node
            newNode.next = p.next;
            // current next point to newNode
            p.next = newNode;
        }

        public static void Remove(int removePosition)
        {
            Node p = head;
            int i = 0;
            // Mode the node to the previous node position that was deleted
            while (p.next != null && i < removePosition - 1)
            {
                p = p.next;
                i++;
            }
            // Save the node you want to delete
            Node temp = p.next;
            //Previous node next points to next of delete the node
            p.next = p.next.next;
            temp.next = null;
        }

    }
}