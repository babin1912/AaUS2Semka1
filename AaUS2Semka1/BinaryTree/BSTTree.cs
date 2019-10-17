using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace AaUS2Semka1.BinaryTree
{
    class BSTTree
    {
        public BSTNode Root { get; set; }

        

        internal BSTNode Insert(IComparable data)
        { 
            if (Root == null)
            {
                
                Root = new BSTNode(data,null);
            }

            if (Equals(Root.Data, data))
            {
                return null;
            }
            

            BSTNode node = Root;
            //BSTNode refer = new BSTNode(Root.LeftChild,node.RightChild,Root.Data);
            bool work = true;
            do
            {
                if (node.Data.CompareTo(data)==0)
                {
                    return null;
                }
                if (node.Data.CompareTo(data) > 0)
                {
                    if (node.HasLeftChild())
                    {
                        node = node.LeftChild;
                    }
                    else
                    {
                        node.LeftChild = new BSTNode(data,node);
                        return node.LeftChild;
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
                        node.RightChild = new BSTNode(data,node);
                        
                        return node.RightChild;
                    }
                }


            } while (work);

            return null;
        }

        
        public void InsertList(IComparable[] data)
        {
            //IComparable[] Data = new IComparable[] { 0, 2, 3 };
            

            foreach (var t in data)
            {
                Insert(t);
            }


        }

        public BSTNode Delete(IComparable data) {
            BSTNode node = Find(data);
            if (node == null)
            {
                return null;
            }

            if (node.HasNoChild())
            {
                if (node.Parent.LeftChild != null && node.Parent.LeftChild.Equals(node))
                {
                    node.Parent.LeftChild = null;
                    //node.Parent = null;
                }
                else
                {
                    node.Parent.LeftChild = null;
                    //node.Parent = null;
                }
            }
            else if (node.HasOnly1Child())
            {
                if (node.Parent.LeftChild != null && node.Parent.LeftChild.Equals(node))
                {
                    node.Parent.LeftChild = node.HasRightChild() ? node.RightChild : node.LeftChild;
                    node.Parent.LeftChild.Parent = node.Parent;
                    //node.Parent = null;
                }
                else
                {
                    node.Parent.RightChild = !node.HasRightChild() ? node.RightChild : node.LeftChild;
                    node.Parent.RightChild.Parent = node.Parent;
                    //node.Parent = null;
                }
            }
            else if(node.Has2Children()) {
                if (node.Parent == null)
                {
                    BSTNode n = node.InOrderSuccessor();
                    Root.Data = n.Data;
                    if (!Root.RightChild.Equals(n))
                    {
                        n.Parent.LeftChild = null;
                        node.Parent = n.Parent;
                    }
                    else
                    {
                        Root.RightChild = null;
                        node.Parent = n.Parent;
                    }

                    /*Root.Parent.LeftChild = null;
                    Root.Parent = null;
                    Root.RightChild = node.RightChild;*/
                }
                //else if (node.Parent.LeftChild != null && node.Parent.LeftChild.Equals(node))
                else{
                    BSTNode n = node.InOrderSuccessor();
                    node.Data = n.Data;
                    if (!node.RightChild.Equals(n))
                    {
                        n.Parent.LeftChild = null;
                        node.Parent = n.Parent;
                    }
                    else
                    {
                        node.RightChild = null;
                        node.Parent = n.Parent;
                    }
                    //n.Parent.LeftChild = null;
                    /*node.Parent.LeftChild = node.InOrderSuccessor();
                    node.Parent.LeftChild.Parent.LeftChild = null;
                    node.Parent.LeftChild.Parent = node.Parent;

                    node.Parent = null;*/
                }
                /*else
                {
                    BSTNode n = node.InOrderSuccessor();
                    node.Data = n.Data;
                    n.Parent.LeftChild = null;
                    /*node.Parent.RightChild = node.InOrderSuccessor();
                    node.Parent.RightChild.Parent.LeftChild = null;
                    node.Parent.RightChild.Parent = node.Parent;
                    node.Parent = null;#1#
                }*/

            }
            return node; 
        }


        public BSTNode Find(IComparable data){
            var node = Root;
            var inProcess = true;
            do{
                switch (data.CompareTo(node.Data))
	            {
                    case 0:

                        return node;
                            //break;
                        
                    case 1:
                        if (node.HasRightChild())
	                    {
                            node = node.RightChild;
	                    } else {
                            inProcess = false;
                        }
                        break;
                    case -1: {
                        {
                            if (node.HasLeftChild())
	                        {
                                node = node.LeftChild;
	                        } else {
                                inProcess = false;
                            }
                        }
                        break;
                    }
		            default: return null;
	            }
            }while(inProcess);
	
            
            return null;
        }


        

        public bool RightRotation(BSTNode node)
        {
            
            if (node.LeftChild == null)
            {
                return false;
            }

            if (node.Parent == null)
            {

                node.LeftChild.Parent = null;

               
                //node1 = node.LeftChild;

            }
            else
            {
                node.LeftChild.Parent = node.Parent;
                if (node.IsLeftChild())
                {
                    node.Parent.LeftChild = node.LeftChild;
                }
                else if(node.IsRightChild())
                {
                    node.Parent.RightChild = node.LeftChild;
                }
                else
                {
                    Console.WriteLine("hmnn to my nevychadza right rotation");
                }
                //Parent.LeftChild = LeftChild;
            }

            
            BSTNode lssRs = node.LeftChild.RightChild!=null? new BSTNode(node.LeftChild.RightChild):null;
            node.LeftChild.RightChild = node;
            //this = LeftChild;
            
            if (node.Parent == null)
            {
                Root = node.LeftChild;
                //node.Parent = Root;

            }

            node.Parent = node.LeftChild;
            node.LeftChild = lssRs;
                

            
            
            return true;
        }

        

        public bool LeftRotation(BSTNode node)
        {
            if (node.RightChild == null)
            {
                return false;
            }

            if (node.Parent == null)
            {

                node.RightChild.Parent = null;
                //node.Parent = node.RightChild;

                //node1 = node.LeftChild;

            }
            else
            {
                node.RightChild.Parent = node.Parent;
                if (node.IsRightChild())
                {
                    node.Parent.RightChild = node.RightChild;
                }
                else if (node.IsLeftChild())
                {
                    node.Parent.LeftChild = node.RightChild;
                }
                else
                {
                    Console.WriteLine("hmnn to my nevychadza lava rotacia");
                }
                
                //Parent.LeftChild = LeftChild;
            }
            BSTNode lssRs = node.RightChild.LeftChild != null ? new BSTNode(node.RightChild.LeftChild) : null;
            node.RightChild.LeftChild = node;

            //this = LeftChild;

            if (node.Parent == null)
            {
                Root = node.RightChild;
                node.Parent = Root;
            }
            node.RightChild = lssRs;

            return true;
        }

       

        

        /*public List<BSTNode> InOrderSuccessor()
        {
            var output = new List<BSTNode>();
            BSTNode node = Root;
            bool working = true;
            do
            {
                if (node.LeftChild == null && node.RightChild == null)
                {
                    working = false;
                }
                else if (node.RightChild == null)
                {
                    //return 
                    //return string.Concat(input, LeftChild.InOrder(input), Data.ToString(), " ");
                }

                if (node.LeftChild == null)
                {
                    //return string.Concat(input, Data.ToString(), RightChild.ToString(), " ");
                }
            } while (working);
            



            return null;

        }*/

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
            //level.Add(Root);
            product.Add(new List<object>());
            product[0].Add(Root);
            bool work;
            //Console.WriteLine(Root.ToString().PadLeft(2, '0'));
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

        ///not using
        ///
        ///
        ///
        ///
        ///
        ///
        /// not at all ;)
        internal bool InsertRecursive(IComparable data)
        {
            if (Root != null) return Root.Insert(data);
            Root = new BSTNode(data, null);

            return true;


        }

        internal bool Contains(IComparable data)
        {
            return Root.Contains(data);
        }

        public void InsertRecursiveList(IComparable[] data)
        {
            //IComparable[] Data = new IComparable[] { 0, 2, 3 };
            foreach (var t in data)
            {
                InsertRecursive(t);
            }




        }

        public BSTNode FindRecursive(IComparable data)
        {
            return Root.Find(data);
        }
        public string InOrderRecursive()
        {
            return Root.InOrder("");
        }
    }
}
