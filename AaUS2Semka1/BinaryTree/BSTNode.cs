using System;
using System.Collections.Generic;
using System.Text;

namespace AaUS2Semka1.BinaryTree
{
    class BSTNode : IComparable<BSTNode>

    {
        public BSTNode(IComparable data)
        {
            this._data = data;
        }

        public IComparable _data { get; }

        public BSTNode _leftSon { get; set; }

        public BSTNode _rightSon { get; set; }


        public int CompareTo(BSTNode other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return Comparer<IComparable>.Default.Compare(_data, other._data);
        }


        public bool Insert(IComparable comparable)
        {
            throw new NotImplementedException();
        }

        public bool Contains(IComparable comparable)
        {
            throw new NotImplementedException();
        }

        public string ToString()
        {
            return _data.ToString();
        }

    }
}
