using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Add(50);
            binaryTree.Add(23);
            binaryTree.Add(67);
            binaryTree.Add(10);
            binaryTree.Add(99);
            binaryTree.Add(38);
            Console.ReadLine();
        }
    }
}
