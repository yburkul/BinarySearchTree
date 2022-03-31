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
            binarySearchTree.Insert(45);
            binarySearchTree.Insert(85);
            binarySearchTree.Insert(77);
            binarySearchTree.Insert(25);
            binarySearchTree.Insert(64);
            binarySearchTree.Insert(10);
            binarySearchTree.Insert(63);
            binarySearchTree.Insert(89);

            binarySearchTree.Display();
            binarySearchTree.Getsize();
            binarySearchTree.Search(63, binarySearchTree);
        }
    }
}