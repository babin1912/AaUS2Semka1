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
            if (comparable.CompareTo(data)>=0)
            {
                leftChild = InsertChild(leftChild,comparable);
            }
            else
            {
                rightChild = InsertChild(rightChild,comparable);
            }
            throw new NotImplementedException();
        }

        

        private BSTNode InsertChild(BSTNode node, IComparable data)
        {
            if (data == null)
            {
                node = new BSTNode(data);
            }
            else
            {
                node.Insert(data);
            }
            return null;
        }


        public bool Contains(IComparable comparable)
        {
            throw new NotImplementedException();
        }



        public override string ToString()
        {
            return data.ToString();
        }

        public string InOrder(in string input)
        {
            
            //output = String.Join("",new String[]{input, leftChild.InOrder(input))};
            return string.Concat(input,leftChild.InOrder(input), data.ToString());
        }


        public IComparable data { get; private set; }

        public BSTNode leftChild { get; set; }

        public BSTNode rightChild { get; set; }


    }
}
