using System;

namespace logical_exercise.DataStructuresBook
{
    public class NodeTWC
    {
        public NodeTWC next;
        public NodeTWC previous;
        public string data;
        public NodeTWC(string data)
        {
            this.data = data;
        }
    }

    public class TwoWayCircularList
    {
        public static NodeTWC head;
        public static NodeTWC tail;
        public void Run()
        {
            Init();
            // Insert(2, new NodeTWC("E"));
            Remove(2);
            Print();
        }

        public static void Init()
        {
            head = new NodeTWC("A");
            head.next = null;
            head.previous = null;

            NodeTWC nodeB = new NodeTWC("B");
            nodeB.previous = head;
            nodeB.next = null;
            head.next = nodeB;

            NodeTWC nodeC = new NodeTWC("C");
            nodeC.next = null;
            nodeC.previous = nodeB;
            nodeB.next = nodeC;

            // The last node call tail node
            tail = new NodeTWC("D");
            tail.next = head;
            tail.previous = nodeC;
            nodeC.next = tail;
            head.previous = tail;
        }

        public static void Print()
        {
            NodeTWC p = head;
            do
            {
                Console.WriteLine($"->{p.data}");
                p = p.next;
            } while (p != head);
            Console.WriteLine($"{p.data} END");

            p = tail;
            do
            {
                Console.WriteLine($"->{p.data}");
                p = p.previous;
            } while (p != tail);
            Console.WriteLine($"{p.data} END");
        }

        public static void Insert(int insertPosition, NodeTWC newNode)
        {
            NodeTWC p = head;
            int i = 0;
            while (p.next != null && i < (insertPosition - 1))
            {
                p = p.next;
                i++;
            }
            newNode.next = p.next;
            p.next = newNode;
            newNode.previous = p;
            newNode.next.previous = newNode;
        }

        public static void Remove(int removePosition)
        {
            NodeTWC p = head;
            int i = 0;
            while (p.next != null && i < (removePosition - 1))
            {
                p = p.next;
                i++;
            }
            NodeTWC temp = p.next;
            p.next = p.next.next;
            p.next.previous = p;
            temp.next = null;
            temp.previous = null;
        }

    }
}