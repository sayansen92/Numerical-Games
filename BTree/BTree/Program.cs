using System;
using System.Runtime.InteropServices;

namespace BTree
{
   
    class Program
    {
         class Node
        {
            public Nullable <long> data=null;

            public Node rightNode = null;
            public Node leftNode = null;
           
            
           

            internal void insert(long num)
            {
                if (num >= this.data)
                {
                    if (this.rightNode == null)
                    {
                        this.rightNode = new Node();
                        this.rightNode.data = num;
                        right_sum = right_sum + num;

                    }
                    else
                        this.rightNode.insert(num);
                }
                else
                {
                    if (this.leftNode == null)
                    {
                        this.leftNode = new Node();
                        this.leftNode.data = num;
                        left_sum = left_sum + num;

                    }
                    else this.leftNode.insert(num);

                }
            }
        }

         class Tree
        {
            public Node root=null;
            public Tree()
            {
                this.root = new Node();
            }
            public void insert(long num)
            {
                if (this.root == null)
                    this.root.data = num;
                else
                     this.root.insert(num);
                    
            }

            internal void PrintInorder()
            {
                if (this.root != null) {
                    InOrderTraverse(this.root);
                }
            }

            private void InOrderTraverse(Node node)
            {
                //first go to left child its children will be null so we print its data
                if (node.leftNode != null)
                    InOrderTraverse(node.leftNode);
                //Then we print the root node 
                Console.Write(node.data + " ");

                //Then we go to the right node which will print itself as both its children are null
                if (node.rightNode != null)
                    InOrderTraverse(node.rightNode);
            }
        }


        public static long left_sum = 0, right_sum = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter all the elements in the tree with space separation: ");

            long[] arr = Array.ConvertAll(Console.ReadLine().Split(" "), long.Parse);   //{3,6,2,9,-1,10 };
            
            Tree tree = new Tree();
            foreach (long num in arr) {
                tree.insert(num);
            }

            tree.PrintInorder();
            Console.WriteLine(left_sum);
            Console.WriteLine(right_sum-arr[0]);


        }
    }
}
