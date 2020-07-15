using System;

namespace logical_exercise.DataStructuresBook
{

    public class NodeD
    {
        public NodeD prev;
        public NodeD next;
        public string data;
        public NodeD(string data)
        {
            this.data = data;
        }
    }
    public class DoublyLinkedList
    {
        public static NodeD head;
        public static NodeD tail;

        public void Run()
        {
            Init();
            //Add(new NodeD("Walnut"));
            //Insert(2, new NodeD("Walnut"));
            Remove(2);
            Print(head);
        }

        public static void Init()
        {
            head = new NodeD("San Francisco");
            head.next = null;
            head.prev = null;

            NodeD nodeOakland = new NodeD("Oakland");
            nodeOakland.prev = head;
            nodeOakland.next = null;
            head.next = nodeOakland;

            NodeD nodeBerkeley = new NodeD("Berkeley");
            nodeBerkeley.prev = nodeOakland;
            nodeBerkeley.next = null;
            nodeOakland.next = nodeBerkeley;

            tail = new NodeD("Fremont");
            tail.prev = nodeBerkeley;
            tail.next = null;
            nodeBerkeley.next = tail;
        }

        public static void Print(NodeD node)
        {
            NodeD p = node;
            NodeD end = null;
            while (p != null)
            {
                Console.WriteLine($"{p.data}->");
                end = p;
                p = p.next;
            }
            Console.WriteLine("End");
            p = end;
            while (p != null)
            {
                Console.WriteLine($"{p.data}->");
                p = p.prev;
            }
            Console.WriteLine("Start");
        }

        public static void Add(NodeD newNode) {
            tail.next = newNode;
            newNode.prev = tail;
            tail = newNode;
        }

        public static void Insert(int insertPosition, NodeD newNode) {
            NodeD p = head;
            int i = 0;
            while (p.next != null && i < insertPosition - 1)
            {
                p = p.next;
                i++;
            }
            newNode.next = p.next;
            p.next = newNode;
            newNode.prev = p;
            newNode.next.prev = newNode;
        }

        public static void Remove(int deletePosition) {
            NodeD p = head;
            int i = 0;
            while (p.next != null && i < deletePosition - 1)
            {
                p = p.next;
                i++;
            }
            // Save the node you want to delete
            NodeD temp = p.next;
            p.next = p.next.next;
            p.next.prev = p;
            // set the delete node next to null
            temp.next = null;
            temp.prev = null;

        }



    }
}