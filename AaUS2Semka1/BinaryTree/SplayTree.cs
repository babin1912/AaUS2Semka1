using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace AaUS2Semka1.BinaryTree
{
    class SplayTree
    {
        private BSTTree bt;

        public SplayTree()
        {
            bt = new BSTTree();
        }

        public BSTNode Insert(IComparable data)
        { 
            BSTNode output = bt.Insert(data);
            if (data == bt.Root.Data)
            {
                return output;
            }

            
            ToStringAF();
            Console.WriteLine("insert" + data);
            Console.WriteLine();
            while (!bt.Root.Data.Equals(data))
            {
                Splay(output);

            }
            


            return output;
        }

        public BSTNode Splay(BSTNode node)
        {
            
            //BSTNode node = FindRecursive(data);
            //Console.WriteLine(node);
            //var node = bt.Find(data);
            //Console.WriteLine(node);
            

            //BSTNode node1 = null;
            if (node != null && !node.Equals(bt.Root))
            {
                if (node.Parent != null && node.Parent.Equals(bt.Root))
                {
                    if (node.Parent.LeftChild != null && node.IsLeftChild())
                    {
                        bt.RightRotation(node.Parent);
                    }
                    else
                    {
                        bt.LeftRotation(node.Parent);
                    }
                }
                else if (node.IsRightChild())
                {
                    if (node.Parent.IsRightChild())
                    {
                        bt.LeftRotation(node.Parent.Parent);
                        bt.LeftRotation(node.Parent);
                    }
                    else if (node.Parent.IsLeftChild())
                    {
                        bt.LeftRotation(node.Parent);
                        bt.RightRotation(node.Parent);
                    }
                    else
                    {
                        Console.WriteLine("hmnn to mi nevychadza1");
                    }
                }
                else if (node.IsLeftChild())
                {
                    if (node.Parent.IsLeftChild())
                    {
                        bt.RightRotation(node.Parent.Parent);
                        bt.RightRotation(node.Parent);
                    }
                    else if (node.Parent.IsRightChild())
                    {
                        bt.RightRotation(node.Parent);
                        bt.LeftRotation(node.Parent);
                    }
                    else
                    {
                        Console.WriteLine("hmnn to mi nevychadza2");
                    }

                }

            }

            return node;

        }

        public void ToStringAF()
        {
            //Console.Clear();
            bt.ToStringAF();
        }

        public BSTNode Delete(IComparable data)
        {
            Console.Clear();
            Console.WriteLine("delete"+data);
            ToStringAF();
            BSTNode node = bt.Delete(data).Parent;
            while (!bt.Root.Equals(data))
            {
                Splay(node);
            }
            
            ToStringAF();
            return node;
        }

        public void InsertList(IComparable[] comparables)
        {
            foreach (var item in comparables)
            {
                Console.Clear();
                Insert(item);
                //ToStringAF();
                Console.WriteLine("splay");
                Console.ReadLine();
                Console.WriteLine();
            }
        }
    }
}
