using System;

namespace logical_exercise.DataStructuresBook
{

    public class NodeOWC
    {
        public string data;
        public NodeOWC next;
        public NodeOWC(string data)
        {
            this.data = data;
        }
    }
    public class OneWayCircularList
    {
        private static NodeOWC head;
        private static NodeOWC tail;
        public void Run()
        {
            Init();
            //Insert(2, new NodeOWC("E"));
            Remove(2);
            Print();
        }

        public static void Init()
        {
            Add("A");
            Add("B");
            Add("C");
            Add("D");
            // head = new NodeOWC("A");
            // head.next = null;

            // NodeOWC nodeB = new NodeOWC("B");
            // nodeB.next = null;
            // head.next = nodeB;

            // NodeOWC nodeC = new NodeOWC("C");
            // nodeC.next = null;
            // nodeB.next = nodeC;

            // // The last node call tail node
            // tail = new NodeOWC("D");
            // tail.next = head;
            // nodeC.next = tail;
        }

        public static void Add(string data) 
        {
            NodeOWC newNode = new NodeOWC(data);
            if (head == null)
            {
                head = newNode;
                return;
            }
            NodeOWC lastNode = GetLastNode();
            lastNode.next = newNode;
            tail = newNode;
        }

        private static NodeOWC GetLastNode()
        {
            NodeOWC p = head;
            while (p.next != null)
            {
                p = p.next;
            }
            return p;
        }

        public static void Print()
        {
            NodeOWC p = head;
            do
            {
                Console.WriteLine($"-> {p.data}");
                p = p.next;
            } while (p.next != null);
            Console.WriteLine($"{p.data}");
        }

        public static void Insert(int insertPosition, NodeOWC newNode) {
            NodeOWC p = head;
            int i = 0;
            while (p.next != null && i < (insertPosition - 1) )
            {
                p = p.next;
                i++;
            }
            newNode.next = p.next;
            p.next = newNode;
        }

        public static void Remove(int removePosition){
            NodeOWC p = head;
            int i = 0;
            while (p.next != null && i < (removePosition - 1))
            {
                p = p.next;
                i++;
            }
            NodeOWC temp = p.next;
            p.next = p.next.next;
            temp.next = null;
        }
    }
}