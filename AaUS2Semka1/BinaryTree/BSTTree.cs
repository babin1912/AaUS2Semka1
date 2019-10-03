using System;
using System.Collections.Generic;
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
            }
            else
            {
                return root.Insert(data);
            }
            return false;
        }

        internal bool Contains(IComparable data)
        {
            return root.Contains(data);
        }

        
    }
}
