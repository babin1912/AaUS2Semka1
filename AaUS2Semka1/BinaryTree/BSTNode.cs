using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data.SqlTypes;
using System.Text;

namespace AaUS2Semka1.BinaryTree
{
    class BSTNode

    {
        public BSTNode Parent { get; set; }

        public BSTNode(BSTNode node)
        {
            

            Parent = node.Parent;
            LeftChild = node.LeftChild;
            RightChild = node.RightChild;
            Data = node.Data;
        }

        public BSTNode(BSTNode leftChild, BSTNode rightChild, IComparable data, BSTNode parent)
        {
            Parent = parent;
            LeftChild = leftChild;
            RightChild = rightChild;
            Data = data;
        }

        public BSTNode LeftChild { get; set; }

        public BSTNode RightChild { get; set; }

        public BSTNode(IComparable data, BSTNode parent)
        {
            Parent = parent;
            this.Data = data;
        }


        public void LeftRotation()
        {
            //BSTNode 
        }

        public bool RightRotation()
        {
            
            /*if (Parent!=null)
            {
                LeftChild.Parent = Parent;
                Parent.LeftChild = LeftChild;
            }
            else
            {
                LeftChild.Parent = null;
                //Parent.LeftChild = LeftChild;
            }

            if (expr)
            {
                
            }*/
            /*LeftChild.RightChild = this;
            LeftChild = LeftChild.RightChild;

            LeftChild = LssRs;*/
            //LeftChild.Parent = this;
            

            
            /*if (LeftChild.RightChild!=null)
            {
                LssRs = LeftChild.RightChild;
                //LeftChild = LeftChild.RightChild;
            }*/


            return false;

        }




        


        public bool Insert(IComparable comparable)
        {
            if (comparable.CompareTo(Data) == 0)
            {
                return false;
            } if (comparable.CompareTo(Data)<=0)
            {
                 LeftChild = InsertChild(LeftChild,comparable);
                 return true;
            }
            
            
            RightChild = InsertChild(RightChild,comparable);
            return true;
            

            
            //throw new NotImplementedException();
        }

        

        private BSTNode InsertChild(BSTNode node, IComparable data)
        {
            if (node == null)
            {
                return new BSTNode(data, this);
                
            }
            else
            {
                node.Insert(data);
                return node;

            }
            
        }


        public bool Contains(IComparable comparable)
        {
            if (Data.Equals(comparable))
            {
                return true;
            }
            else if (Data.CompareTo(comparable)>=0)
            {
                if (LeftChild!= null)
                {
                    return LeftChild.Contains(comparable);
                }
                
            }
            else
            {
                if (RightChild != null)
                {
                    return RightChild.Contains(comparable);
                }
            }

            return false;
        }



        public override string ToString()
        {
            return Data.ToString();
        }

        public string InOrder(string input)
        {
            
            if (LeftChild==null && RightChild==null)
            {
                return string.Concat(input, Data.ToString()," ");
            }
            else if(RightChild==null)
            {
                return string.Concat(input, LeftChild.InOrder(input), Data.ToString(), " ");
            }

            if (LeftChild== null)
            {
              return string.Concat(input, Data.ToString(),RightChild.ToString(), " ");
            }
        
            //output = String.Join("",new String[]{input, LeftChild.InOrder(input))};
            return string.Concat(input,LeftChild.InOrder(input), Data.ToString(), " ", RightChild.ToString(), " ");
            //return input + LeftChild.InOrder(input) + Data.ToString();
        }

        public bool HasLeftChild()
        {
            return LeftChild!=null;
        }

        public bool HasRightChild()
        {
            return RightChild!=null;
        }

        public IComparable Data { get; private set; }


        public bool IsNull { get; }

        public BSTNode Find(IComparable comparable)
        {
            if (Data.Equals(comparable))
            {
                return this;
            }
            else if (Data.CompareTo(comparable) >= 0)
            {
                if (LeftChild != null)
                {
                    return LeftChild.Find(comparable);
                }

            }
            else
            {
                if (RightChild != null)
                {
                    return RightChild.Find(comparable);
                }
            }

            return null;
        }
    }
}
