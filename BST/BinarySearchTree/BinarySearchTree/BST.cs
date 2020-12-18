using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class BST<T> where T: IComparable<T>
    {
        public T NodeData { get; set; }
        public BST<T> LeftTree { get; set; }
        public BST<T> RightTree { get; set; }
        public BST(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }

        public int LeftCount = 0, RightCount = 0;
        bool result = false;

        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.LeftTree == null)
                    this.LeftTree = new BST<T>(item);
                else
                    this.LeftTree.Insert(item);
            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree = new BST<T>(item);
                else
                    this.RightTree.Insert(item);
            }
        }

        /// <summary>
        /// Get size of Binary Search Tree
        /// </summary>
        public void GetSize()
        {
            Console.WriteLine("\nSize " + (1 + this.LeftCount + this.RightCount));
        }

        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.LeftCount++;
                this.LeftTree.Display();
            }
            Console.Write(this.NodeData.ToString()+"-->");
            if (this.RightTree != null)
            {
                this.RightCount++;
                this.RightTree.Display();
            }
        }
    }
}
