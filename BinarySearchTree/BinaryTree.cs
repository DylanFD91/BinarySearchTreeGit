using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree
    {
        public Node root;

        public BinaryTree()
        {
            root = null;
        }


        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (root == null)
            {
                root = newNode;
                return;
            }
            else
            {
                Node temp = root;
                while (true)
                {
                    if (temp.data > data)
                    {
                        if (temp.nodeLeft == null)
                        {
                            temp.nodeLeft = newNode;
                            return;
                        }
                        else
                        {
                            temp = temp.nodeLeft;
                        }
                    }
                    else if (data < temp.data)
                    {
                        if (temp.nodeRight == null)
                        {
                            temp.nodeRight = newNode;
                            return;
                        }
                        else
                        {
                            temp = temp.nodeRight;
                        }
                    }
                }
            }
        }

        public void Search(int data)
        {
            Node tempNode = root;
            if (data == root.data)
            {
                Console.WriteLine("number there");
                return;
            }
            while (true)
            {
                if (data == tempNode.data)
                {
                    Console.WriteLine("your number is there");
                    return;
                }
                else if (data < tempNode.data)
                {
                    if (tempNode.nodeLeft == null)
                    {
                        Console.WriteLine("number not there");
                    }
                    else
                    {
                        tempNode = tempNode.nodeLeft;
                    }
                }
                else if (data > tempNode.data)
                {
                    if (tempNode.nodeRight == null)
                    {
                        Console.WriteLine("number not there");
                    }
                    else
                    {
                        tempNode = tempNode.nodeRight;
                    }
                }

            }
        }
    }
}
