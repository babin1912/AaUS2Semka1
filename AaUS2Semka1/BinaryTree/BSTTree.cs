using System;
using System.Collections.Generic;
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
            //IComparable[] data = new IComparable[] { 0, 2, 3 };
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

        public string ToStringAF()
        {
            BSTNode node = null;
            var level = new List<BSTNode>();
            level.Add(root);
            
            do
            {
                node = null;
                foreach (var leverNode in level)
                {
                    if (leverNode)
                    {
                        
                    }
                }



            } while (node != null);
            return "";
        }


    }
}
