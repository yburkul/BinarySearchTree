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
            }
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
    }
}