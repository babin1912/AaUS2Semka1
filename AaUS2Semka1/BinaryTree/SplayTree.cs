using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Dynamic;
using System.Text;
using System.Threading.Channels;

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

            
            //ToStringAF();
            /*Console.WriteLine("insert" + data);
            Console.WriteLine();*/
            if (output != null)

            {
                while (!bt.Root.Data.Equals(data))
                {

                    Splay( ref output);
                    ToStringAF();
                    /*Console.Clear();
                Console.WriteLine(data);
                ToStringAF();

                //ToStringAF();
                Console.ReadLine();*/

                }
            }
           


            return output;
        }

        public BSTNode Splay(ref BSTNode node)
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
                    if (node.IsLeftChild())
                    {
                        bt.RightRotation(node.Parent);
                    }
                    else if (node.IsRightChild())
                    {
                        if (node.Parent.Data.Equals(6))
                        {
                            Console.WriteLine();
                        }
                        bt.LeftRotation(node.Parent);

                    }else
                    {
                        
                        Console.WriteLine("hmnn to mi nevychadza0");
                    }
                }
                else if (node.IsRightChild())
                {
                    if (node.Parent.IsRightChild())
                    {
                        
                        bt.LeftRotation(node.Parent.Parent);
                        ToStringAF();
                        bt.LeftRotation(node.Parent);
                    }
                    else if (node.Parent.IsLeftChild())
                    {
                        bt.LeftRotation(node.Parent);
                        ToStringAF();
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
                        //ToStringAF();
                        bt.RightRotation(node.Parent);
                    }
                    else if (node.Parent.IsRightChild())
                    {
                        bt.RightRotation(node.Parent);
                        ToStringAF();
                        bt.LeftRotation(node.Parent);
                        //ToStringAF();
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
            //Console.Clear();
            Console.WriteLine("delete"+data);
            ToStringAF();
            BSTNode node = bt.Find(data);
            while (!bt.Root.Data.Equals(data))
            {
                //Console.WriteLine(bt.Root.Data + " "+ data);
                
                
                
                Splay(ref node);
            }

            if (bt.Root.HasNoChild())
            {
                bt.Root = null;
            }
            else if(bt.Root.HasOnly1Child())
            {
                bt.Root = bt.Root.LeftChild ?? bt.Root.RightChild;
                bt.Root.Parent = null;
            }
            else
            {
                BSTNode io = bt.Root.InOrderSuccessor();
                bt.Root.Data = io.Data;
                if (io.IsLeftChild())
                {
                    io.Parent.LeftChild = null;
                }
                else
                {
                    io.Parent.RightChild = null;
                }

                
            }
            //bt.Delete(data);
            //bt.Root.Data=((BSTNode)bt.Root.InOrderSuccessor()).Data;
            ToStringAF();
            return node;
        }

        public void InsertList(IEnumerable<IComparable> comparables)
        {
            foreach (var item in comparables)
            {
                Console.WriteLine(item);
                Insert(item);
                //ToStringAF();
                //Console.WriteLine("splay");
                //Console.ReadLine();
                Console.WriteLine();
            }
        }
    }
}
