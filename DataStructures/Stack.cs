using System;

namespace logical_exercise.DataStructuresBook
{

    public class NodeS {
        public string data;
        public NodeS next;
        public NodeS(string data) {
            this.data = data;
        }
    }

    /// <summary>
    /// FILO (First In Last Out) Sequence
    /// </summary>
    public class Stack 
    {
        private static NodeS top;
        private static int size;

        public void Push(string element) {
            if (top == null)
            {
                top = new NodeS(element);
            }
            else
            {
                NodeS newNode = new NodeS(element);
                newNode.next = top;
                top = newNode;
            }
            size++;
        }

        public NodeS Pop () {
            if (top == null)
            {
                return null;
            }
            NodeS p = top;
            top = top.next;
            p.next = null;
            size--;
            return p;
        }

        public int Size() {
            return size;
        }

        public void Print(Stack stack) {
            Console.WriteLine("Top");
            NodeS node = null;
            while ((node = stack.Pop()) != null)
            {
                Console.WriteLine($"{node.data}->");
            }
            Console.WriteLine("End");
        }

        public void Run() {
            Stack stack = new Stack();
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            stack.Push("D");
            stack.Push("E");
            stack.Print(stack);
        }

    }
}