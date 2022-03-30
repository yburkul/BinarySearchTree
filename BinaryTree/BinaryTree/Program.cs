using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree");
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>(56);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);

            binarySearchTree.Display();
        }
    }
}