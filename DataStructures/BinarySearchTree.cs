using System;

namespace logical_exercise.DataStructuresBook
{
    public class NodeBT {
        public int data;
        public NodeBT left;
        public NodeBT right;
        public NodeBT(int data, NodeBT left, NodeBT right){
            this.data = data;
            this.left = left;
            this.right = right;
        }
    }

    public class BinarySearchTree {
        private static NodeBT root;
        public static NodeBT GetRoot() {
            return root;
        }
        // In-order transversal binary search tree
        public static void InOrder(NodeBT root){
            if (root == null)
            {
                return;
            }
            InOrder(root.left); // Transversing the left subtree
            Console.WriteLine($"{root.data},");
            InOrder(root.right); // Transversing the right subtree
        }

        // Preorder trasversal binary search tree
        public static void PreOrder(NodeBT root){
            if (root == null)
            {
                return;
            }
            Console.WriteLine($"{root.data},");
            // Recursive Transversing the left subtree
            PreOrder(root.left);
            // Recursive Transversing the right subtree
            PreOrder(root.right);
        }

        //Post-order transversal binary search tree
        public static void PostOrder(NodeBT root){
            if (root == null)
            {
                return;
            }
            PostOrder(root.left);
            PostOrder(root.right);
            Console.WriteLine($"{root.data},");
        }

        public static void Insert(NodeBT node, int newData) {
            if (root == null)
            {
                root = new NodeBT(newData, null, null);
                return;
            }
            int compareValue = newData - node.data;
            // Recursive left subtree, continue to find the insertion position
            if (compareValue < 0)
            {
                if (node.left == null)
                {
                    node.left = new NodeBT(newData, null, null);
                }
                else
                {
                    Insert(node.left, newData);
                }
            }
            else if (compareValue > 0)
            {
                // Recursive right subtree, continue to find the insertion position
                if (node.right == null)
                {
                    node.right = new NodeBT(newData, null,null);
                }
                else
                {
                    Insert(node.right, newData);
                }
            }
        }

        public static NodeBT SearchMinValue(NodeBT node){
            if (node == null || node.data == 0)
            {
                return null;
            }
            if (node.left == null)
            {
                return node;
            }
            // Recursively find minimum from thje left subtree
            return SearchMinValue(node.left);
        }

        // Maximum value
        public static NodeBT SearchMaxValue(NodeBT node){
            if (node == null || node.data == 0)
            {
                return null;
            }
            if (node.right == null)
            {
                return node;
            }
            // Recursively find minimum from the right subtree
            return SearchMaxValue(node.right);
        }

        public static NodeBT Remove(NodeBT node, int newData){
            if (node == null)
            {
                return node;
            }
            int compareValue = newData - node.data;
            if (compareValue > 0)
            {
                node.right = Remove(node.right, newData);
            }
            else if (compareValue < 0)
            {
                node.left = Remove(node.left, newData);
            }
            else if (node.left != null && node.right != null)
            {
                // Find the minimum node of the right subtree to replace the current node
                node.data = SearchMinValue(node.right).data;
                node.right = Remove(node.right, node.data);
            }
            else
            {
                node = (node.left != null) ? node.left : node.right;
            }
            return node;
        }



        public void Run(){
            Insert(GetRoot(), 100);
            Insert(GetRoot(), 60);
            Insert(GetRoot(), 40);
            Insert(GetRoot(), 20);
            Insert(GetRoot(), 3);
            Insert(GetRoot(), 30);
            Insert(GetRoot(), 50);
            Insert(GetRoot(), 80);
            Insert(GetRoot(), 70);
            Insert(GetRoot(), 90);
            Console.WriteLine("In-order tranversal binary search tree");
            InOrder(GetRoot());
            Console.WriteLine("Pre-Order transversal binary search tree");
            PreOrder(GetRoot());   
            Console.WriteLine("Post-order traversal binary search tree");
            PostOrder(GetRoot());
            Console.WriteLine($"Minimum value: {SearchMinValue(GetRoot()).data}");
            Console.WriteLine($"Maximum value: {SearchMaxValue(GetRoot()).data}");
            Console.WriteLine("Remove node with value 20");
            Remove(GetRoot(), 20);
            InOrder(GetRoot());
        }


    }

}