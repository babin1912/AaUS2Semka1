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

        public void setAtributes(BSTNode node)
        {
            Parent = node.Parent;
            LeftChild = node.LeftChild;
            
            Data = node.Data;
            RightChild = node.RightChild;

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


        public bool LeftRotation()
        {
            if (RightChild == null)
            {
                return false;
            }

            if (Parent == null)
            {

                Parent = new BSTNode(0, null) {RightChild = this};


                //node1 = node.LeftChild;

            }
            else
            {
                RightChild.Parent = Parent;
            }
            
            {
                //RightChild.Parent = Parent;
                if (Parent.RightChild.Equals(this))
                {
                    Parent.RightChild = RightChild;
                }
                else
                {
                    Parent.LeftChild = RightChild;
                }
                //Parent.LeftChild = LeftChild;
            }
            BSTNode lssRs = RightChild.LeftChild != null ? new BSTNode(RightChild.LeftChild) : null;
            RightChild.LeftChild = this;

            //this = LeftChild;

            if (Parent == null)
            {
                //Parent = new BSTNode(0,null);
                //Parent.RightChild = RightChild;
                //LeftChild.RightChild = RightChild;
                //setAtributes(RightChild);
                //RightChild.Parent = null;
            }
            RightChild = lssRs;


            return true;
        }

        public bool RightRotation()
        {

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

        public bool HasNoChild() {
            if (!HasRightChild() && !HasLeftChild())
            {
                return true;
            }
            return false;
        }

        public bool RemoveChild(IComparable data) {
            if (LeftChild.Data.CompareTo(data)==0) {
                LeftChild = null;
                return true;
            }
            else if (RightChild.Data.CompareTo(data)==0)
            {
                RightChild = null;
                return true;
            }
            return false;
        }

        public BSTNode Find(IComparable comparable)
        {
            if (Data.Equals(comparable))
            {
                return this;
            }
            if (Data.CompareTo(comparable) >= 0)
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
