using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in Binary Search tree Problem");
            BST<int> bST = new BST<int>(56);
            bST.Insert(30);
            bST.Insert(70);
            bST.Display();
        }
    }
}
