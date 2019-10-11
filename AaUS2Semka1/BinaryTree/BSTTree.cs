using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace AaUS2Semka1.BinaryTree
{
    class BSTTree
    {
        private BSTNode root;

        internal bool Insert(IComparable data)
        {
            if (root==null)
            {
                root = new BSTNode(data);

                return true;
            }
            return root.Insert(data);
            
            
        }

        public void InsertList(IComparable[] data)
        {
            //IComparable[] Data = new IComparable[] { 0, 2, 3 };
            foreach (var t in data)
            {
                Insert(t);
            }

            
        }

        internal bool Contains(IComparable data)
        {
            return root.Contains(data);
        }

        public string InOrder()
        {
            return root.InOrder("");
        }

        public void ToStringAF()
        {

            bool ch = true;
            foreach (var level in LevelOrder())
            {
                
                foreach (var node in level)
                {
                    if (node ==null)
                    {
                        Console.Write("__");
                    }
                    else 
                    {
                        Console.Write(string.Concat(node.ToString(), " "));
                    }

                    if (ch)
                    {
                        Console.Write("|");
                        ch = false;
                    }
                    else
                    {
                        Console.Write(" ");
                        ch = true;
                    }

                    
                    
                    
                }
                Console.WriteLine();
            }
            
            //return "";
        }

        public List<List<object>> LevelOrder()
        {
            List<List<object>> product = new List<List<object>>();
            List<object> level = new List<object>();
            level.Add(root);
            product.Add(new List<object>());
            product[0].Add(root);
            bool work;
            do
            {
                work = false;

                foreach (object node in product[product.Count - 1])
                {
                    if (((BSTNode)node).HasLeftChild())
                    {
                        level.Add(((BSTNode)node).LeftChild );
                        work = true;
                    }
                    else
                    {
                        level.Add(null);
                    }

                    if (((BSTNode)node).HasRightChild())
                    {
                        level.Add(((BSTNode)node).RightChild);
                        work = true;
                    }
                    else
                    {
                        level.Add(null);
                    }
                    product.Add(level);
                    level = new List<object>();
                }
                

            } while (work);

            return product;
        }


    }
}
