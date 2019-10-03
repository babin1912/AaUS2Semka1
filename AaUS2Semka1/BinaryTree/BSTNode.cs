using System;
using System.Collections.Generic;
using System.Text;

namespace AaUS2Semka1.BinaryTree
{
    class BSTNode

    {
       

        public BSTNode(IComparable data)
        {
            this.data = data;
        }


        


        public bool Insert(IComparable comparable)
        {
            if (comparable.CompareTo(data) == 0)
            {
                return false;
            } if (comparable.CompareTo(data)>=0)
            {
                 leftChild = InsertChild(leftChild,comparable);
                 return true;
            }
            
            
            rightChild = InsertChild(rightChild,comparable);
            return true;
            

            
            //throw new NotImplementedException();
        }

        

        private BSTNode InsertChild(BSTNode node, IComparable data)
        {
            if (node == null)
            {
                return new BSTNode(data);
                
            }
            else
            {
                node.Insert(data);
                return node;

            }
            
        }


        public bool Contains(IComparable comparable)
        {
            throw new NotImplementedException();
        }



        public override string ToString()
        {
            return data.ToString();
        }

        public string InOrder(string input)
        {
            
            if (leftChild==null && rightChild==null)
            {
                return string.Concat(input, data.ToString()," ");
            }
            else if(rightChild==null)
            {
                return string.Concat(input, leftChild.InOrder(input), data.ToString(), " ");
            }

            if (leftChild== null)
            {
              return string.Concat(input, data.ToString(),rightChild.ToString(), " ");
            }
        
            //output = String.Join("",new String[]{input, leftChild.InOrder(input))};
            return string.Concat(input,leftChild.InOrder(input), data.ToString(), " ", rightChild.ToString(), " ");
            //return input + leftChild.InOrder(input) + data.ToString();
        }


        public IComparable data { get; private set; }

        public BSTNode leftChild { get; set; }

        public BSTNode rightChild { get; set; }


    }
}
