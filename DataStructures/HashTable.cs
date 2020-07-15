using System;

namespace logical_exercise.DataStructuresBook
{
    public class NodeHT {
        public Object key;
        public Object value;
        public int hash;
        public NodeHT next;
        public NodeHT(Object key, Object value, int hash, NodeHT next){
            this.key = key;
            this.value = value;
            this.hash = hash;
            this.next = next;
        }
    }

    public class HashTable{
        private NodeHT[] table;
        private int capacity = 16;
        private int size;
        public HashTable(){
            table = new NodeHT[capacity];
        }

        public HashTable(int capacity){
            table = new NodeHT[capacity];
            size = 0;
            this.capacity = capacity;
        }

        private int HashCode(Object key){
            int num = 0;
            char[] chs = key.ToString().ToCharArray();
            for (int i = 0; i < chs.Length; i++)
            {
                num += (int)chs[i];
            }
            // Hash strategy is to take the square in the middle
            double avg = num * (Math.Pow(5, 0.5) - 1)/2;
            double numeric = avg - Math.Floor(avg);
            var v = (int)Math.Floor(numeric * capacity);
            return v;
        }

        public int Size() {
            return size;
        }

        public bool IsEmpty(){
            return size == 0 ? true: false;
        }

        public void Put(Object key, Object value){
            int hash = HashCode(key);
            NodeHT newNode = new NodeHT(key,value, hash, null);
            NodeHT node = table[hash];
            while (node != null)
            {
                if (node.key.Equals(key))
                {
                    node.value = value;
                    return;
                }
                node = node.next;
            }
            newNode.next = table[hash];
            table[hash] = newNode;
            size++;
        }

        public Object Get(Object key){
            if (key == null)
            {
                return null;
            }
            int hash = HashCode(key);
            NodeHT node = table[hash];
            while (node != null)
            {
                if (node.key.Equals(key))
                {
                    return node.value;
                }
                node = node.next;
            }
            return null;
        }

        public void Run(){
            HashTable table = new HashTable();
            table.Put("david", "Good boy keep going");
            table.Put("grace", "Cute girl keep going");
            Console.WriteLine($"david=> {table.Get("david")}");
            Console.WriteLine($"grace=> {table.Get("grace")}");
        }

    }

}