using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        //member variables (has a)
        public int data;
        public Node nodeLeft;
        public Node nodeRight;

        //constructor (is a)
        public Node(int data)
        {
            this.data = data;
        }

        //methods (can do)
        public void DisplayNode()
        {
            Console.WriteLine("(" + data + ")");
        }
    }
}
