using System;

namespace logical_exercise.DataStructuresBook
{

    public class NodeQ
    {
        public string data;
        public NodeQ next;
        public NodeQ prev;
        public NodeQ(string data)
        {
            this.data = data;
        }
    }
    /// <summary>
    /// FIFO (First In First Out) sequence
    /// </summary>
    public class Queue
    {
        private static NodeQ head;
        private static NodeQ tail;
        private static int size = 0;

        public void Offer(string element)
        {
            if (head == null)
            {
                head = new NodeQ(element);
                tail = head;
            }
            else
            {
                NodeQ newNode = new NodeQ(element);
                newNode.next = tail;
                tail.prev = newNode;
                tail = newNode;
            }
            size++;
        }

        public NodeQ Poll()
        {
            NodeQ p = head;
            if (p == null)
            {
                return null;
            }
            head = head.prev;
            p.next = null;
            p.prev = null;
            size--;
            return p;
        }

        public int Size()
        {
            return size;
        }

        public void Print()
        {
            Queue queue = new Queue();
            Console.WriteLine("Head");
            NodeQ node = null;
            while ((node = queue.Poll()) != null)
            {
                Console.WriteLine($"{node.data}<-");
            }
            Console.WriteLine("Tail");
        }

        public void Run()
        {
            Queue queue = new Queue();
            queue.Offer("A");
            queue.Offer("B");
            queue.Offer("C");
            queue.Offer("D");
            queue.Print();
        }

    }
}