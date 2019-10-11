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

        internal bool InsertRecursive(IComparable data)
        {
            if (root==null)
            {
                root = new BSTNode(data);

                return true;
            }
            return root.Insert(data);
            
            
        }

        internal bool Insert(IComparable data)
        {
            if (root == null)
            {
                root = new BSTNode(data);
            }

            if (Equals(root.Data, data))
            {
                return false;
            }
            

            BSTNode node = root;
            //BSTNode refer = new BSTNode(root.LeftChild,node.RightChild,root.Data);
            bool work = true;
            do
            {
                if (node.Data.CompareTo(data)==0)
                {
                    return false;
                }
                if (node.Data.CompareTo(data) > 0)
                {
                    if (node.HasLeftChild())
                    {
                        node = node.LeftChild;
                    }
                    else
                    {
                        node.LeftChild = new BSTNode(data);
                        return true;
                    }
                }
                else
                {
                    if (node.HasRightChild())
                    {
                        node = node.RightChild;
                    }
                    else
                    {
                        node.RightChild = new BSTNode(data);
                        
                        return true;
                    }
                }


            } while (work);

            return false;
        }

        public void InsertList(IComparable[] data)
        {
            //IComparable[] Data = new IComparable[] { 0, 2, 3 };
            

            foreach (var t in data)
            {
                Insert(t);
            }


        }

        public void InsertRecursiveList(IComparable[] data)
        {
            //IComparable[] Data = new IComparable[] { 0, 2, 3 };
            foreach (var t in data)
            {
                InsertRecursive(t);
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
            //LevelOrder();
            var input = LevelOrder();
            bool ch = true;
            int i = input.Count;
            bool first = true;
            
            foreach (var level in input)
            {
                //Console.Write(Math.Pow((double)2.0, (double)i - 2)+1);
                foreach (var node in level)
                {
                    if (!ch && first)
                    {
                        Console.Write("|".PadLeft(((int)Math.Pow((double)2.0, (double)i - 1) * 6)/2 - 2, ' '));
                        
                        first = false;
                    }
                    else if(!ch && !first)
                    {
                        if (i==1)
                        {
                            //Console.Write(i);
                            Console.Write("".PadLeft(((int)Math.Pow((double)2.0, (double)i - 2) * 6), ' '));

                        }
                        else
                        {
                            
                            Console.Write("|".PadLeft(((((int)Math.Pow((double)2.0, (double)i - 1)) * 6)-6), ' '));
                            //Console.Write((int)Math.Pow((double)2.0, (double)i - 2) * 6);

                        }

                    }

                    if (node ==null)
                    {
                        Console.Write("__");
                    }
                    else 
                    {
                        Console.Write(node.ToString().PadLeft(2, '0'));
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
                first = true;
                i--;
                Console.WriteLine();
            }
            

            //return "";
        }

        public List<List<object>> LevelOrder()
        {
            List<List<object>> product = new List<List<object>>();
            List<object> level = new List<object>();
            //level.Add(root);
            product.Add(new List<object>());
            product[0].Add(root);
            bool work;
            //Console.WriteLine(root.ToString().PadLeft(2, '0'));
            do
            {
                work = false;

                foreach (object node in product[product.Count - 1])
                {
                    if (node!=null)
                    {
                        if (((BSTNode)node).HasLeftChild())
                        {
                            level.Add(((BSTNode)node).LeftChild );
                            //Console.Write(((BSTNode)node).LeftChild.ToString().PadLeft(2, '0'));
                            work = true;
                        }
                        else
                        {
                            level.Add(null);
                        }

                        //Console.Write(" ");
                        if (((BSTNode)node).HasRightChild())
                        {
                            level.Add(((BSTNode)node).RightChild);
                            //Console.Write(((BSTNode)node).RightChild.ToString().PadLeft(2, '0'));
                            work = true;
                        }
                        else
                        {
                            level.Add(null);

                        }
                        //Console.Write("|");
                    
                    }
                    else
                    {
                        //Console.Write("__ __");
                        level.Add(null);
                        level.Add(null);

                    }

                }

                //Console.WriteLine();

                if (work)
                {
                    //product = new List<List<object>>();
                    product.Add(level);
                    level = new List<object>();
                }
                
                


            } while (work);

            return product;
        }


    }
}
