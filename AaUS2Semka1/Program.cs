using System;
using AaUS2Semka1.BinaryTree;

namespace AaUS2Semka1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BSTTree tree = new BSTTree();
            //var peter = new IComparable[]{0, 2, 3};
            tree.InsertList(new IComparable[] { 24, 31,25, 15,50, 18, 10,22,35,70,4,12,44,66,90});
            Console.WriteLine(" " + tree.InOrder());

            tree.ToStringAF();
            Console.WriteLine(tree.Contains(90));
            //Console.WriteLine(jozef);
        }
    }
}
