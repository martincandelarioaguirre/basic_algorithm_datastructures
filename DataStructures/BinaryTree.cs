using System;

namespace logical_exercise.DataStructures {

    public class Node {
        public Node LeftNode { set; get; }
        public Node RightNode { set; get; }
        public int Data { set; get; }
    }
    class BinaryTree {
        private Node Root { get; set; }

        private bool Add (int value) {
            Node before = null, after = this.Root;

            while (after != null) {
                before = after;
                if (value < after.Data) //Is new node in left tree? 
                    after = after.LeftNode;
                else if (value > after.Data) //Is new node in right tree?
                    after = after.RightNode;
                else {
                    //Exist same value
                    return false;
                }
            }

            Node newNode = new Node ();
            newNode.Data = value;

            if (this.Root == null) //Tree ise empty
                this.Root = newNode;
            else {
                if (value < before.Data)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }

            return true;
        }

        private Node Find (int value) {
            return this.Find (value, this.Root);
        }

        private void Remove (int value) {
            this.Root = Remove (this.Root, value);
        }

        private Node Remove (Node parent, int key) {
            if (parent == null) return parent;

            if (key < parent.Data) parent.LeftNode = Remove (parent.LeftNode, key);
            else if (key > parent.Data)
                parent.RightNode = Remove (parent.RightNode, key);

            // if value is same as parent's value, then this is the node to be deleted  
            else {
                // node with only one child or no child  
                if (parent.LeftNode == null)
                    return parent.RightNode;
                else if (parent.RightNode == null)
                    return parent.LeftNode;

                // node with two children: Get the inorder successor (smallest in the right subtree)  
                parent.Data = MinValue (parent.RightNode);

                // Delete the inorder successor  
                parent.RightNode = Remove (parent.RightNode, parent.Data);
            }

            return parent;
        }

        private int MinValue (Node node) {
            int minv = node.Data;

            while (node.LeftNode != null) {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }

            return minv;
        }

        private Node Find (int value, Node parent) {
            if (parent != null) {
                if (value == parent.Data) return parent;
                if (value < parent.Data)
                    return Find (value, parent.LeftNode);
                else
                    return Find (value, parent.RightNode);
            }

            return null;
        }

        private int GetTreeDepth () {
            return this.GetTreeDepth (this.Root);
        }

        private int GetTreeDepth (Node parent) {
            return parent == null ? 0 : Math.Max (GetTreeDepth (parent.LeftNode), GetTreeDepth (parent.RightNode)) + 1;
        }

        public void TraversePreOrder (Node parent) {
            if (parent != null) {
                Console.Write (parent.Data + " ");
                TraversePreOrder (parent.LeftNode);
                TraversePreOrder (parent.RightNode);
            }
        }

        public void TraverseInOrder (Node parent) {
            if (parent != null) {
                TraverseInOrder (parent.LeftNode);
                Console.Write (parent.Data + " ");
                TraverseInOrder (parent.RightNode);
            }
        }

        public void TraversePostOrder (Node parent) {
            if (parent != null) {
                TraversePostOrder (parent.LeftNode);
                TraversePostOrder (parent.RightNode);
                Console.Write (parent.Data + " ");
            }
        }

        public void Run () {
            BinaryTree binaryTree = new BinaryTree ();
            binaryTree.Add (1);
            binaryTree.Add (2);
            binaryTree.Add (7);
            binaryTree.Add (3);
            binaryTree.Add (10);
            binaryTree.Add (5);
            binaryTree.Add (8);

            Node node = binaryTree.Find (5);
            int depth = binaryTree.GetTreeDepth ();
            ConsoleUtility.WriteLine (depth.ToString());

            ConsoleUtility.WriteLine ("PreOrder Traversal:");
            binaryTree.TraversePreOrder (binaryTree.Root);

            ConsoleUtility.WriteLine ("InOrder Traversal:");
            binaryTree.TraverseInOrder (binaryTree.Root);

            ConsoleUtility.WriteLine ("PostOrder Traversal:");
            binaryTree.TraversePostOrder (binaryTree.Root);

            binaryTree.Remove (7);
            binaryTree.Remove (8);

            ConsoleUtility.WriteLine ("PreOrder Traversal After Removing Operation:");
            binaryTree.TraversePreOrder (binaryTree.Root);
        }
    }
}