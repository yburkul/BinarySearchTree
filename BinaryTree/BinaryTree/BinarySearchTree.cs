using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinarySearchTree<T> where T : IComparable
    {
        public T NodeData { get; set; }
        public BinarySearchTree<T> LeftTree { get; set; }
        public BinarySearchTree<T> RightTree { get; set; }
        public BinarySearchTree(T Nodedata)
        {
            this.NodeData = Nodedata;
            this.LeftTree = null;
            this.RightTree = null;
        }
        int LeftCount = 0;
        int RightCount = 0;
        public void Insert(T item)
        {
            T currentNode = NodeData;
            if (currentNode.CompareTo(item) > 0)
            {
                if (LeftTree == null)
                {
                    LeftTree = new BinarySearchTree<T>(item);
                }
                else
                {
                    LeftTree.Insert(item);
                }
                LeftCount++;
            }
            else
            {
                if (RightTree == null)
                {
                    RightTree = new BinarySearchTree<T>(item);
                }
                else
                {
                    RightTree.Insert(item);
                }
                RightCount++;
            }
        }
        public void Getsize()
        {
            Console.WriteLine("The Binary Tree Size is:" + (RightCount + LeftCount + 1));
        }
        public void Display()
        {
            if (LeftTree != null)
            {
               LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (RightTree != null)
            {
               RightTree.Display();
            }
        }
        public bool Search(T element, BinarySearchTree<T> node)
        {
            bool result = false;
            if (node == null)
            {
                return false;
            }
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Founded Node is :" + node.NodeData);
                result = true;
            }
            else
            {
                Console.WriteLine("Current Node is :" + node.NodeData);
            }
            if (element.CompareTo(node.NodeData) < 0)
            {
                Search(element, node.LeftTree);
            }
            if (element.CompareTo(node.NodeData) > 0)
            {
                Search(element, node.RightTree);
            }
            return result;
        }
    }
}